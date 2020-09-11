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

	#region Class: MailboxSyncSettings_Base_TerrasoftSchema

	/// <exclude/>
	public class MailboxSyncSettings_Base_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public MailboxSyncSettings_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MailboxSyncSettings_Base_TerrasoftSchema(MailboxSyncSettings_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MailboxSyncSettings_Base_TerrasoftSchema(MailboxSyncSettings_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315");
			RealUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315");
			Name = "MailboxSyncSettings_Base_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateUserNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeOwnerColumn() {
			base.InitializeOwnerColumn();
			OwnerColumn = CreateCreatedByColumn();
			if (Columns.FindByUId(OwnerColumn.UId) == null) {
				Columns.Add(OwnerColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b238f1d8-39c2-4498-b0a1-d63f123309ea")) == null) {
				Columns.Add(CreateSysAdminUnitColumn());
			}
			if (Columns.FindByUId(new Guid("04423276-208b-4661-8602-6b6eadd409b9")) == null) {
				Columns.Add(CreateMailServerColumn());
			}
			if (Columns.FindByUId(new Guid("6f989bb4-4185-4531-87c8-62927005896b")) == null) {
				Columns.Add(CreateUserPasswordColumn());
			}
			if (Columns.FindByUId(new Guid("ead0a7dd-f3e3-4679-b766-d8a9f70b2b53")) == null) {
				Columns.Add(CreateEnableMailSynhronizationColumn());
			}
			if (Columns.FindByUId(new Guid("1dd6b43d-22e9-49f5-9676-f4e93fffc0a5")) == null) {
				Columns.Add(CreateAutomaticallyAddNewEmailsColumn());
			}
			if (Columns.FindByUId(new Guid("5b147af6-5886-41cd-b7aa-2ba9a253aab5")) == null) {
				Columns.Add(CreateCyclicallyAddNewEmailsColumn());
			}
			if (Columns.FindByUId(new Guid("04e621fc-8584-4c36-b616-5e790d2d28ca")) == null) {
				Columns.Add(CreateEmailsCyclicallyAddingIntervalColumn());
			}
			if (Columns.FindByUId(new Guid("c8b179f9-5a7e-4c20-944e-b6930162b98f")) == null) {
				Columns.Add(CreateIsCustomFlagsNotSuportedColumn());
			}
			if (Columns.FindByUId(new Guid("64ef7eb3-9995-497d-9c61-e4e09e951132")) == null) {
				Columns.Add(CreateLastSyncDateColumn());
			}
			if (Columns.FindByUId(new Guid("bd47456d-aeb5-4454-b2ce-f6dff54a7794")) == null) {
				Columns.Add(CreateIsSharedColumn());
			}
			if (Columns.FindByUId(new Guid("e727b47c-883f-4fdf-94aa-e85369c2f8f1")) == null) {
				Columns.Add(CreateSendEmailsViaThisAccountColumn());
			}
			if (Columns.FindByUId(new Guid("2b8a9515-0fd9-40ea-84d2-ba1fa641e03e")) == null) {
				Columns.Add(CreateIsDefaultColumn());
			}
			if (Columns.FindByUId(new Guid("d52de6c0-104f-4d78-8e92-3376e97a8268")) == null) {
				Columns.Add(CreateLoadAllEmailsFromMailBoxColumn());
			}
			if (Columns.FindByUId(new Guid("705a60bf-aee9-4168-993d-ed634328174c")) == null) {
				Columns.Add(CreateLoadEmailsFromDateColumn());
			}
			if (Columns.FindByUId(new Guid("06c19861-2ce5-4eb7-88b0-117c28deecf4")) == null) {
				Columns.Add(CreateMailboxNameColumn());
			}
			if (Columns.FindByUId(new Guid("1400f977-628f-4ebe-bcdb-9fbd661d4799")) == null) {
				Columns.Add(CreateSenderEmailAddressColumn());
			}
			if (Columns.FindByUId(new Guid("f13ef65d-d5d7-4ef4-af7f-0091a818d68d")) == null) {
				Columns.Add(CreateIsAnonymousAuthenticationColumn());
			}
			if (Columns.FindByUId(new Guid("70615ebe-d19c-4f72-bc86-bfb4df3d0e7e")) == null) {
				Columns.Add(CreateSenderDisplayValueColumn());
			}
			if (Columns.FindByUId(new Guid("7a199eeb-e500-49fd-b0ad-9b67a46c2954")) == null) {
				Columns.Add(CreateSignatureColumn());
			}
			if (Columns.FindByUId(new Guid("a1893376-351f-4313-ac3c-9cce40a90fb7")) == null) {
				Columns.Add(CreateUseSignatureColumn());
			}
			if (Columns.FindByUId(new Guid("15fdc6ab-dabd-4cae-bd25-8a43e6b9e4e2")) == null) {
				Columns.Add(CreateActualizeMessageRelationsColumn());
			}
			if (Columns.FindByUId(new Guid("286e13db-feea-4cb1-94eb-1243692da2b1")) == null) {
				Columns.Add(CreateErrorCodeColumn());
			}
			if (Columns.FindByUId(new Guid("2c6db188-9b8b-4f1c-8be7-150749951df2")) == null) {
				Columns.Add(CreateLastErrorColumn());
			}
			if (Columns.FindByUId(new Guid("1117201b-9272-4977-b4bb-fb4e958c272b")) == null) {
				Columns.Add(CreateRetryCounterColumn());
			}
			if (Columns.FindByUId(new Guid("ce5f1f0d-f5f9-42b6-b855-8ec26bc97177")) == null) {
				Columns.Add(CreateOAuthTokenStorageColumn());
			}
			if (Columns.FindByUId(new Guid("13a7f989-c37b-415d-a681-84d0f520eb87")) == null) {
				Columns.Add(CreateSendWebsocketNotificationsColumn());
			}
			if (Columns.FindByUId(new Guid("a5839346-f78d-43e6-964a-e108f8f129d8")) == null) {
				Columns.Add(CreateSynchronizationStoppedColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysAdminUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b238f1d8-39c2-4498-b0a1-d63f123309ea"),
				Name = @"SysAdminUnit",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUser")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateMailServerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("04423276-208b-4661-8602-6b6eadd409b9"),
				Name = @"MailServer",
				ReferenceSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateUserNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("3490d31d-b9b4-4017-a5c4-3019416d0c0e"),
				Name = @"UserName",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateUserPasswordColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("SecureText")) {
				UId = new Guid("6f989bb4-4185-4531-87c8-62927005896b"),
				Name = @"UserPassword",
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateEnableMailSynhronizationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("ead0a7dd-f3e3-4679-b766-d8a9f70b2b53"),
				Name = @"EnableMailSynhronization",
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateAutomaticallyAddNewEmailsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("1dd6b43d-22e9-49f5-9676-f4e93fffc0a5"),
				Name = @"AutomaticallyAddNewEmails",
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCyclicallyAddNewEmailsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("5b147af6-5886-41cd-b7aa-2ba9a253aab5"),
				Name = @"CyclicallyAddNewEmails",
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateEmailsCyclicallyAddingIntervalColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("04e621fc-8584-4c36-b616-5e790d2d28ca"),
				Name = @"EmailsCyclicallyAddingInterval",
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsCustomFlagsNotSuportedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("c8b179f9-5a7e-4c20-944e-b6930162b98f"),
				Name = @"IsCustomFlagsNotSuported",
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateLastSyncDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("64ef7eb3-9995-497d-9c61-e4e09e951132"),
				Name = @"LastSyncDate",
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsSharedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("bd47456d-aeb5-4454-b2ce-f6dff54a7794"),
				Name = @"IsShared",
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSendEmailsViaThisAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("e727b47c-883f-4fdf-94aa-e85369c2f8f1"),
				Name = @"SendEmailsViaThisAccount",
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsDefaultColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("2b8a9515-0fd9-40ea-84d2-ba1fa641e03e"),
				Name = @"IsDefault",
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateLoadAllEmailsFromMailBoxColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("d52de6c0-104f-4d78-8e92-3376e97a8268"),
				Name = @"LoadAllEmailsFromMailBox",
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateLoadEmailsFromDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("705a60bf-aee9-4168-993d-ed634328174c"),
				Name = @"LoadEmailsFromDate",
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDate")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateMailboxNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("06c19861-2ce5-4eb7-88b0-117c28deecf4"),
				Name = @"MailboxName",
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49")
			};
		}

		protected virtual EntitySchemaColumn CreateSenderEmailAddressColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("1400f977-628f-4ebe-bcdb-9fbd661d4799"),
				Name = @"SenderEmailAddress",
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("02c41552-6138-41c7-b1d8-208f324fe99a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsAnonymousAuthenticationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("f13ef65d-d5d7-4ef4-af7f-0091a818d68d"),
				Name = @"IsAnonymousAuthentication",
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("9c993461-5823-4a8d-8ebf-57b39ee436fa"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateSenderDisplayValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("70615ebe-d19c-4f72-bc86-bfb4df3d0e7e"),
				Name = @"SenderDisplayValue",
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateSignatureColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("7a199eeb-e500-49fd-b0ad-9b67a46c2954"),
				Name = @"Signature",
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("90e8157f-4651-4349-83a7-f0455fc70915")
			};
		}

		protected virtual EntitySchemaColumn CreateUseSignatureColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("a1893376-351f-4313-ac3c-9cce40a90fb7"),
				Name = @"UseSignature",
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("90e8157f-4651-4349-83a7-f0455fc70915")
			};
		}

		protected virtual EntitySchemaColumn CreateActualizeMessageRelationsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("15fdc6ab-dabd-4cae-bd25-8a43e6b9e4e2"),
				Name = @"ActualizeMessageRelations",
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateErrorCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("286e13db-feea-4cb1-94eb-1243692da2b1"),
				Name = @"ErrorCode",
				ReferenceSchemaUId = new Guid("ff5ba9c1-ee5d-4485-b6b4-da2865a0508d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateLastErrorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("2c6db188-9b8b-4f1c-8be7-150749951df2"),
				Name = @"LastError",
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateRetryCounterColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("1117201b-9272-4977-b4bb-fb4e958c272b"),
				Name = @"RetryCounter",
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateOAuthTokenStorageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ce5f1f0d-f5f9-42b6-b855-8ec26bc97177"),
				Name = @"OAuthTokenStorage",
				ReferenceSchemaUId = new Guid("44bea56e-8a8f-4e29-9494-83253eff2594"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("50cc600a-f6aa-433b-8a0a-6a453519907c")
			};
		}

		protected virtual EntitySchemaColumn CreateSendWebsocketNotificationsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("13a7f989-c37b-415d-a681-84d0f520eb87"),
				Name = @"SendWebsocketNotifications",
				UsageType = EntitySchemaColumnUsageType.Advanced,
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("79d5e1e4-18af-4001-8dc1-26f09fca92c2"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateSynchronizationStoppedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("a5839346-f78d-43e6-964a-e108f8f129d8"),
				Name = @"SynchronizationStopped",
				CreatedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				ModifiedInSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("79d5e1e4-18af-4001-8dc1-26f09fca92c2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMailboxSyncSettings_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateMailboxSyncSettings_Base_TerrasoftEventsProcessSchema() {
			var schema = new MailboxSyncSettings_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new MailboxSyncSettings_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new MailboxSyncSettings_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MailboxSyncSettings_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MailboxSyncSettings_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"));
		}

		#endregion

	}

	#endregion

	#region Class: MailboxSyncSettings_Base_Terrasoft

	/// <summary>
	/// Mailbox synchronization settings.
	/// </summary>
	public class MailboxSyncSettings_Base_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public MailboxSyncSettings_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MailboxSyncSettings_Base_Terrasoft";
		}

		public MailboxSyncSettings_Base_Terrasoft(MailboxSyncSettings_Base_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
		/// User.
		/// </summary>
		public SysAdminUnit SysAdminUnit {
			get {
				return _sysAdminUnit ??
					(_sysAdminUnit = LookupColumnEntities.GetEntity("SysAdminUnit") as SysAdminUnit);
			}
		}

		/// <exclude/>
		public Guid MailServerId {
			get {
				return GetTypedColumnValue<Guid>("MailServerId");
			}
			set {
				SetColumnValue("MailServerId", value);
				_mailServer = null;
			}
		}

		/// <exclude/>
		public string MailServerName {
			get {
				return GetTypedColumnValue<string>("MailServerName");
			}
			set {
				SetColumnValue("MailServerName", value);
				if (_mailServer != null) {
					_mailServer.Name = value;
				}
			}
		}

		private MailServer _mailServer;
		/// <summary>
		/// Email provider.
		/// </summary>
		public MailServer MailServer {
			get {
				return _mailServer ??
					(_mailServer = LookupColumnEntities.GetEntity("MailServer") as MailServer);
			}
		}

		/// <summary>
		/// Username.
		/// </summary>
		public string UserName {
			get {
				return GetTypedColumnValue<string>("UserName");
			}
			set {
				SetColumnValue("UserName", value);
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
		/// Download emails to Creatio.
		/// </summary>
		public bool EnableMailSynhronization {
			get {
				return GetTypedColumnValue<bool>("EnableMailSynhronization");
			}
			set {
				SetColumnValue("EnableMailSynhronization", value);
			}
		}

		/// <summary>
		/// Automatically download new emails.
		/// </summary>
		public bool AutomaticallyAddNewEmails {
			get {
				return GetTypedColumnValue<bool>("AutomaticallyAddNewEmails");
			}
			set {
				SetColumnValue("AutomaticallyAddNewEmails", value);
			}
		}

		/// <summary>
		/// Load new messages repeatedly.
		/// </summary>
		public bool CyclicallyAddNewEmails {
			get {
				return GetTypedColumnValue<bool>("CyclicallyAddNewEmails");
			}
			set {
				SetColumnValue("CyclicallyAddNewEmails", value);
			}
		}

		/// <summary>
		/// Cyclic download interval.
		/// </summary>
		public int EmailsCyclicallyAddingInterval {
			get {
				return GetTypedColumnValue<int>("EmailsCyclicallyAddingInterval");
			}
			set {
				SetColumnValue("EmailsCyclicallyAddingInterval", value);
			}
		}

		/// <summary>
		/// IsCustomFlagsNotSuported.
		/// </summary>
		public bool IsCustomFlagsNotSuported {
			get {
				return GetTypedColumnValue<bool>("IsCustomFlagsNotSuported");
			}
			set {
				SetColumnValue("IsCustomFlagsNotSuported", value);
			}
		}

		/// <summary>
		/// LastSyncDate.
		/// </summary>
		public DateTime LastSyncDate {
			get {
				return GetTypedColumnValue<DateTime>("LastSyncDate");
			}
			set {
				SetColumnValue("LastSyncDate", value);
			}
		}

		/// <summary>
		/// Allow shared access.
		/// </summary>
		public bool IsShared {
			get {
				return GetTypedColumnValue<bool>("IsShared");
			}
			set {
				SetColumnValue("IsShared", value);
			}
		}

		/// <summary>
		/// Send emails from Creatio.
		/// </summary>
		public bool SendEmailsViaThisAccount {
			get {
				return GetTypedColumnValue<bool>("SendEmailsViaThisAccount");
			}
			set {
				SetColumnValue("SendEmailsViaThisAccount", value);
			}
		}

		/// <summary>
		/// Use by default.
		/// </summary>
		public bool IsDefault {
			get {
				return GetTypedColumnValue<bool>("IsDefault");
			}
			set {
				SetColumnValue("IsDefault", value);
			}
		}

		/// <summary>
		/// Download all emails from mailbox.
		/// </summary>
		public bool LoadAllEmailsFromMailBox {
			get {
				return GetTypedColumnValue<bool>("LoadAllEmailsFromMailBox");
			}
			set {
				SetColumnValue("LoadAllEmailsFromMailBox", value);
			}
		}

		/// <summary>
		/// Download emails starting from.
		/// </summary>
		public DateTime LoadEmailsFromDate {
			get {
				return GetTypedColumnValue<DateTime>("LoadEmailsFromDate");
			}
			set {
				SetColumnValue("LoadEmailsFromDate", value);
			}
		}

		/// <summary>
		/// Mailbox name.
		/// </summary>
		public string MailboxName {
			get {
				return GetTypedColumnValue<string>("MailboxName");
			}
			set {
				SetColumnValue("MailboxName", value);
			}
		}

		/// <summary>
		/// Sender's email.
		/// </summary>
		public string SenderEmailAddress {
			get {
				return GetTypedColumnValue<string>("SenderEmailAddress");
			}
			set {
				SetColumnValue("SenderEmailAddress", value);
			}
		}

		/// <summary>
		/// Anonymous authentication.
		/// </summary>
		public bool IsAnonymousAuthentication {
			get {
				return GetTypedColumnValue<bool>("IsAnonymousAuthentication");
			}
			set {
				SetColumnValue("IsAnonymousAuthentication", value);
			}
		}

		/// <summary>
		/// Set custom display name.
		/// </summary>
		public string SenderDisplayValue {
			get {
				return GetTypedColumnValue<string>("SenderDisplayValue");
			}
			set {
				SetColumnValue("SenderDisplayValue", value);
			}
		}

		/// <summary>
		/// Signature.
		/// </summary>
		public string Signature {
			get {
				return GetTypedColumnValue<string>("Signature");
			}
			set {
				SetColumnValue("Signature", value);
			}
		}

		/// <summary>
		/// Add signatures to outbound emails.
		/// </summary>
		public bool UseSignature {
			get {
				return GetTypedColumnValue<bool>("UseSignature");
			}
			set {
				SetColumnValue("UseSignature", value);
			}
		}

		/// <summary>
		/// ActualizeMessageRelations.
		/// </summary>
		public bool ActualizeMessageRelations {
			get {
				return GetTypedColumnValue<bool>("ActualizeMessageRelations");
			}
			set {
				SetColumnValue("ActualizeMessageRelations", value);
			}
		}

		/// <exclude/>
		public Guid ErrorCodeId {
			get {
				return GetTypedColumnValue<Guid>("ErrorCodeId");
			}
			set {
				SetColumnValue("ErrorCodeId", value);
				_errorCode = null;
			}
		}

		/// <exclude/>
		public string ErrorCodeName {
			get {
				return GetTypedColumnValue<string>("ErrorCodeName");
			}
			set {
				SetColumnValue("ErrorCodeName", value);
				if (_errorCode != null) {
					_errorCode.Name = value;
				}
			}
		}

		private SyncErrorMessage _errorCode;
		/// <summary>
		/// Error code identifier.
		/// </summary>
		public SyncErrorMessage ErrorCode {
			get {
				return _errorCode ??
					(_errorCode = LookupColumnEntities.GetEntity("ErrorCode") as SyncErrorMessage);
			}
		}

		/// <summary>
		/// Last synchronization error text.
		/// </summary>
		public string LastError {
			get {
				return GetTypedColumnValue<string>("LastError");
			}
			set {
				SetColumnValue("LastError", value);
			}
		}

		/// <summary>
		/// Number of retry attempts.
		/// </summary>
		public int RetryCounter {
			get {
				return GetTypedColumnValue<int>("RetryCounter");
			}
			set {
				SetColumnValue("RetryCounter", value);
			}
		}

		/// <exclude/>
		public Guid OAuthTokenStorageId {
			get {
				return GetTypedColumnValue<Guid>("OAuthTokenStorageId");
			}
			set {
				SetColumnValue("OAuthTokenStorageId", value);
				_oAuthTokenStorage = null;
			}
		}

		/// <exclude/>
		public string OAuthTokenStorageUserAppLogin {
			get {
				return GetTypedColumnValue<string>("OAuthTokenStorageUserAppLogin");
			}
			set {
				SetColumnValue("OAuthTokenStorageUserAppLogin", value);
				if (_oAuthTokenStorage != null) {
					_oAuthTokenStorage.UserAppLogin = value;
				}
			}
		}

		private OAuthTokenStorage _oAuthTokenStorage;
		/// <summary>
		/// OAuth token storage identifier.
		/// </summary>
		public OAuthTokenStorage OAuthTokenStorage {
			get {
				return _oAuthTokenStorage ??
					(_oAuthTokenStorage = LookupColumnEntities.GetEntity("OAuthTokenStorage") as OAuthTokenStorage);
			}
		}

		/// <summary>
		/// Send new emails notifications by web socket.
		/// </summary>
		public bool SendWebsocketNotifications {
			get {
				return GetTypedColumnValue<bool>("SendWebsocketNotifications");
			}
			set {
				SetColumnValue("SendWebsocketNotifications", value);
			}
		}

		/// <summary>
		/// Synchronization stopped.
		/// </summary>
		public bool SynchronizationStopped {
			get {
				return GetTypedColumnValue<bool>("SynchronizationStopped");
			}
			set {
				SetColumnValue("SynchronizationStopped", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MailboxSyncSettings_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("MailboxSyncSettings_Base_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("MailboxSyncSettings_Base_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("MailboxSyncSettings_Base_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("MailboxSyncSettings_Base_TerrasoftInserting", e);
			Loaded += (s, e) => ThrowEvent("MailboxSyncSettings_Base_TerrasoftLoaded", e);
			Saved += (s, e) => ThrowEvent("MailboxSyncSettings_Base_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("MailboxSyncSettings_Base_TerrasoftSaving", e);
			Updated += (s, e) => ThrowEvent("MailboxSyncSettings_Base_TerrasoftUpdated", e);
			Validating += (s, e) => ThrowEvent("MailboxSyncSettings_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MailboxSyncSettings_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: MailboxSyncSettings_BaseEventsProcess

	/// <exclude/>
	public partial class MailboxSyncSettings_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : MailboxSyncSettings_Base_Terrasoft
	{

		public MailboxSyncSettings_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MailboxSyncSettings_BaseEventsProcess";
			SchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5e487721-02e2-48ee-b755-dfa5160f5315");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool IsSharedDef {
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
					SchemaElementUId = new Guid("f05546ac-fcc7-4711-8849-cb96618fa7de"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _mailboxSyncSettingsSaved;
		public ProcessFlowElement MailboxSyncSettingsSaved {
			get {
				return _mailboxSyncSettingsSaved ?? (_mailboxSyncSettingsSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MailboxSyncSettingsSaved",
					SchemaElementUId = new Guid("932ab824-8e8b-49f1-a156-5db83030dd13"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _mailboxSyncSettingsSavedScriptTask;
		public ProcessScriptTask MailboxSyncSettingsSavedScriptTask {
			get {
				return _mailboxSyncSettingsSavedScriptTask ?? (_mailboxSyncSettingsSavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "MailboxSyncSettingsSavedScriptTask",
					SchemaElementUId = new Guid("ef4f7464-130e-48ef-b835-ac60389c9b97"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = MailboxSyncSettingsSavedScriptTaskExecute,
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
					SchemaElementUId = new Guid("404d60dd-ba85-419c-8bab-5c75a5d06070"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _mailboxSyncSettingsInserted;
		public ProcessFlowElement MailboxSyncSettingsInserted {
			get {
				return _mailboxSyncSettingsInserted ?? (_mailboxSyncSettingsInserted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MailboxSyncSettingsInserted",
					SchemaElementUId = new Guid("5de1e911-2a94-4b30-9517-d770f7f0eeb7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _mailboxSyncSettingsInsertedScriptTask;
		public ProcessScriptTask MailboxSyncSettingsInsertedScriptTask {
			get {
				return _mailboxSyncSettingsInsertedScriptTask ?? (_mailboxSyncSettingsInsertedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "MailboxSyncSettingsInsertedScriptTask",
					SchemaElementUId = new Guid("118f9ee5-9549-4986-9545-7493769e4cc4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = MailboxSyncSettingsInsertedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess4;
		public ProcessFlowElement EventSubProcess4 {
			get {
				return _eventSubProcess4 ?? (_eventSubProcess4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4",
					SchemaElementUId = new Guid("4a2df159-f182-465e-bad1-4db4e7275fac"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _mailboxSyncSettingsSaving;
		public ProcessFlowElement MailboxSyncSettingsSaving {
			get {
				return _mailboxSyncSettingsSaving ?? (_mailboxSyncSettingsSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MailboxSyncSettingsSaving",
					SchemaElementUId = new Guid("deec75e4-b0e6-4702-b03a-7ccd779c0358"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _mailboxSyncSettingsSavingScriptTask;
		public ProcessScriptTask MailboxSyncSettingsSavingScriptTask {
			get {
				return _mailboxSyncSettingsSavingScriptTask ?? (_mailboxSyncSettingsSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "MailboxSyncSettingsSavingScriptTask",
					SchemaElementUId = new Guid("52d5eb7f-7e4d-47e1-98d7-97797a897ed4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = MailboxSyncSettingsSavingScriptTaskExecute,
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
					SchemaElementUId = new Guid("97f942d4-6d57-47aa-b066-8c61a65f9413"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _mailboxSyncSettingsDeleting;
		public ProcessFlowElement MailboxSyncSettingsDeleting {
			get {
				return _mailboxSyncSettingsDeleting ?? (_mailboxSyncSettingsDeleting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MailboxSyncSettingsDeleting",
					SchemaElementUId = new Guid("52c6eb3b-0cbb-479b-8e64-1da87e475068"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _mailboxSyncSettingsDeletingScriptTask;
		public ProcessScriptTask MailboxSyncSettingsDeletingScriptTask {
			get {
				return _mailboxSyncSettingsDeletingScriptTask ?? (_mailboxSyncSettingsDeletingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "MailboxSyncSettingsDeletingScriptTask",
					SchemaElementUId = new Guid("c5e440a2-089b-4410-a9e7-1713f6467682"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = MailboxSyncSettingsDeletingScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess5;
		public ProcessFlowElement EventSubProcess5 {
			get {
				return _eventSubProcess5 ?? (_eventSubProcess5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess5",
					SchemaElementUId = new Guid("f02a626a-3bfe-41e4-9743-d9279f6d7e8f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageMailboxSyncSettingsUpdated;
		public ProcessFlowElement StartMessageMailboxSyncSettingsUpdated {
			get {
				return _startMessageMailboxSyncSettingsUpdated ?? (_startMessageMailboxSyncSettingsUpdated = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageMailboxSyncSettingsUpdated",
					SchemaElementUId = new Guid("5143a02b-b6cf-46a2-be05-2c5435bcf38c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskMailboxSyncSettingsUpdated;
		public ProcessScriptTask ScriptTaskMailboxSyncSettingsUpdated {
			get {
				return _scriptTaskMailboxSyncSettingsUpdated ?? (_scriptTaskMailboxSyncSettingsUpdated = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskMailboxSyncSettingsUpdated",
					SchemaElementUId = new Guid("907cdc92-62d3-46b7-8114-aa716742b41a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskMailboxSyncSettingsUpdatedExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[MailboxSyncSettingsSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { MailboxSyncSettingsSaved };
			FlowElements[MailboxSyncSettingsSavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { MailboxSyncSettingsSavedScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[MailboxSyncSettingsInserted.SchemaElementUId] = new Collection<ProcessFlowElement> { MailboxSyncSettingsInserted };
			FlowElements[MailboxSyncSettingsInsertedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { MailboxSyncSettingsInsertedScriptTask };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[MailboxSyncSettingsSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { MailboxSyncSettingsSaving };
			FlowElements[MailboxSyncSettingsSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { MailboxSyncSettingsSavingScriptTask };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[MailboxSyncSettingsDeleting.SchemaElementUId] = new Collection<ProcessFlowElement> { MailboxSyncSettingsDeleting };
			FlowElements[MailboxSyncSettingsDeletingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { MailboxSyncSettingsDeletingScriptTask };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[StartMessageMailboxSyncSettingsUpdated.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageMailboxSyncSettingsUpdated };
			FlowElements[ScriptTaskMailboxSyncSettingsUpdated.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskMailboxSyncSettingsUpdated };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "MailboxSyncSettingsSaved":
						e.Context.QueueTasks.Enqueue("MailboxSyncSettingsSavedScriptTask");
						break;
					case "MailboxSyncSettingsSavedScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "MailboxSyncSettingsInserted":
						e.Context.QueueTasks.Enqueue("MailboxSyncSettingsInsertedScriptTask");
						break;
					case "MailboxSyncSettingsInsertedScriptTask":
						break;
					case "EventSubProcess4":
						break;
					case "MailboxSyncSettingsSaving":
						e.Context.QueueTasks.Enqueue("MailboxSyncSettingsSavingScriptTask");
						break;
					case "MailboxSyncSettingsSavingScriptTask":
						break;
					case "EventSubProcess3":
						break;
					case "MailboxSyncSettingsDeleting":
						e.Context.QueueTasks.Enqueue("MailboxSyncSettingsDeletingScriptTask");
						break;
					case "MailboxSyncSettingsDeletingScriptTask":
						break;
					case "EventSubProcess5":
						break;
					case "StartMessageMailboxSyncSettingsUpdated":
						e.Context.QueueTasks.Enqueue("ScriptTaskMailboxSyncSettingsUpdated");
						break;
					case "ScriptTaskMailboxSyncSettingsUpdated":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("MailboxSyncSettingsSaved");
			ActivatedEventElements.Add("MailboxSyncSettingsInserted");
			ActivatedEventElements.Add("MailboxSyncSettingsSaving");
			ActivatedEventElements.Add("MailboxSyncSettingsDeleting");
			ActivatedEventElements.Add("StartMessageMailboxSyncSettingsUpdated");
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
				case "MailboxSyncSettingsSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailboxSyncSettingsSaved";
					result = MailboxSyncSettingsSaved.Execute(context);
					break;
				case "MailboxSyncSettingsSavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailboxSyncSettingsSavedScriptTask";
					result = MailboxSyncSettingsSavedScriptTask.Execute(context, MailboxSyncSettingsSavedScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "MailboxSyncSettingsInserted":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailboxSyncSettingsInserted";
					result = MailboxSyncSettingsInserted.Execute(context);
					break;
				case "MailboxSyncSettingsInsertedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailboxSyncSettingsInsertedScriptTask";
					result = MailboxSyncSettingsInsertedScriptTask.Execute(context, MailboxSyncSettingsInsertedScriptTaskExecute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "MailboxSyncSettingsSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailboxSyncSettingsSaving";
					result = MailboxSyncSettingsSaving.Execute(context);
					break;
				case "MailboxSyncSettingsSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailboxSyncSettingsSavingScriptTask";
					result = MailboxSyncSettingsSavingScriptTask.Execute(context, MailboxSyncSettingsSavingScriptTaskExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "MailboxSyncSettingsDeleting":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailboxSyncSettingsDeleting";
					result = MailboxSyncSettingsDeleting.Execute(context);
					break;
				case "MailboxSyncSettingsDeletingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailboxSyncSettingsDeletingScriptTask";
					result = MailboxSyncSettingsDeletingScriptTask.Execute(context, MailboxSyncSettingsDeletingScriptTaskExecute);
					break;
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageMailboxSyncSettingsUpdated":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageMailboxSyncSettingsUpdated";
					result = StartMessageMailboxSyncSettingsUpdated.Execute(context);
					break;
				case "ScriptTaskMailboxSyncSettingsUpdated":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskMailboxSyncSettingsUpdated";
					result = ScriptTaskMailboxSyncSettingsUpdated.Execute(context, ScriptTaskMailboxSyncSettingsUpdatedExecute);
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
				case "IsSharedDef":
					IsSharedDef = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool MailboxSyncSettingsSavedScriptTaskExecute(ProcessExecutingContext context) {
			if (Entity.IsDefault) {
				var upd = new Update(UserConnection, "MailboxSyncSettings")
					.Set("IsDefault", Column.Parameter(false))
					.Where("Id").IsNotEqual(Column.Parameter(Entity.Id))
					.And("IsDefault").IsEqual(Column.Parameter(true))
					.And("SysAdminUnitId").IsEqual(Column.Parameter(Entity.SysAdminUnitId)) as Update;
				upd.Execute();
			}
			if (IsSharedDef && !Entity.IsShared) {
				DeleteSharedRights();
			}
			return true;
		}

		public virtual bool MailboxSyncSettingsInsertedScriptTaskExecute(ProcessExecutingContext context) {
			var rootEmailFolderId = new Guid("181F9D34-5DEE-E011-A86B-00155D04C01D");
			var mailboxFolderTypeId = FolderConsts.MailboxFolderTypeId;
			var activityFolder = new Terrasoft.Configuration.ActivityFolder(UserConnection);
			activityFolder.Id = Guid.NewGuid();
			activityFolder.Name = Entity.MailboxName;
			activityFolder.ParentId = rootEmailFolderId;
			activityFolder.FolderTypeId = mailboxFolderTypeId;
			activityFolder.Save();
			return true;
		}

		public virtual bool MailboxSyncSettingsSavingScriptTaskExecute(ProcessExecutingContext context) {
			IsSharedDef = (bool)(Entity.GetColumnOldValue("IsShared") ?? false);
			return true;
		}

		public virtual bool MailboxSyncSettingsDeletingScriptTaskExecute(ProcessExecutingContext context) {
			var activityFolderSchema = UserConnection.EntitySchemaManager.FindInstanceByName("ActivityFolder");
			var activityFolder = activityFolderSchema.CreateEntity(UserConnection);
			var condition = new Dictionary<string, object>();
			condition.Add("Name", Entity.MailboxName);
			if(activityFolder.FetchFromDB(condition)) {
				activityFolder.Delete();
			}
			return true;
		}

		public virtual bool ScriptTaskMailboxSyncSettingsUpdatedExecute(ProcessExecutingContext context) {
			var newValue = Entity.GetTypedColumnValue<string>("MailboxName");
			var oldValue = Entity.GetTypedOldColumnValue<string>("MailboxName");
			if (newValue != oldValue) {
				var update = new Update(UserConnection, "ActivityFolder")
					.Set("Name", Column.Parameter(newValue))
					.Where("Name").IsLike(Column.Parameter(oldValue))
					.And("FolderTypeId").IsEqual(Column.Parameter(FolderConsts.MailboxFolderTypeId));
				update.Execute();
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "MailboxSyncSettings_Base_TerrasoftSaved":
							if (ActivatedEventElements.Contains("MailboxSyncSettingsSaved")) {
							context.QueueTasks.Enqueue("MailboxSyncSettingsSaved");
						}
						break;
					case "MailboxSyncSettings_Base_TerrasoftInserted":
							if (ActivatedEventElements.Contains("MailboxSyncSettingsInserted")) {
							context.QueueTasks.Enqueue("MailboxSyncSettingsInserted");
						}
						break;
					case "MailboxSyncSettings_Base_TerrasoftSaving":
							if (ActivatedEventElements.Contains("MailboxSyncSettingsSaving")) {
							context.QueueTasks.Enqueue("MailboxSyncSettingsSaving");
						}
						break;
					case "MailboxSyncSettings_Base_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("MailboxSyncSettingsDeleting")) {
							context.QueueTasks.Enqueue("MailboxSyncSettingsDeleting");
						}
						break;
					case "MailboxSyncSettings_Base_TerrasoftUpdated":
							if (ActivatedEventElements.Contains("StartMessageMailboxSyncSettingsUpdated")) {
							context.QueueTasks.Enqueue("StartMessageMailboxSyncSettingsUpdated");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("IsSharedDef") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsSharedDef", IsSharedDef, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: MailboxSyncSettings_BaseEventsProcess

	/// <exclude/>
	public class MailboxSyncSettings_BaseEventsProcess : MailboxSyncSettings_BaseEventsProcess<MailboxSyncSettings_Base_Terrasoft>
	{

		public MailboxSyncSettings_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MailboxSyncSettings_BaseEventsProcess

	public partial class MailboxSyncSettings_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void DeleteSharedRights() {
			var currentUserId = UserConnection.CurrentUser.Id;
			var manualSourceId = new Guid("8A248A03-E9A5-DF11-9989-485B39C18470");
			var del = new Delete(UserConnection)
				.From("SysMailboxSyncSettingsRight")
				.Where("RecordId").IsEqual(Column.Parameter(Entity.Id))
				.And("SysAdminUnitId").IsNotEqual(Column.Parameter(currentUserId)) as Delete;
			del.Execute();
			var sel = new Select(UserConnection)
				.Column("Id")
				.From("SysMailboxSyncSettingsRight")
				.Where("RecordId").IsEqual(Column.Parameter(Entity.Id))
				.And("SysAdminUnitId").IsEqual(Column.Parameter(currentUserId)) as Select;
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dr = sel.ExecuteReader(dbExecutor)) {
					if(!dr.Read()) {
						Insert ins =
							new Insert(UserConnection)
								.Into("SysMailboxSyncSettingsRight")
								.Set("RecordId", Column.Parameter(Entity.Id))
								.Set("SysAdminUnitId", Column.Parameter(currentUserId))
								.Set("Operation", Column.Parameter(EntitySchemaRecordRightOperation.Read))
								.Set("RightLevel", Column.Parameter(2))
								.Set("Position", Column.Parameter(0))
								.Set("SourceId", Column.Parameter("8A248A03-E9A5-DF11-9989-485B39C18470"))
								 as Insert;
						ins.Execute();
						ins =
							new Insert(UserConnection)
								.Into("SysMailboxSyncSettingsRight")
								.Set("RecordId", Column.Parameter(Entity.Id))
								.Set("SysAdminUnitId", Column.Parameter(currentUserId))
								.Set("Operation", Column.Parameter(EntitySchemaRecordRightOperation.Edit))
								.Set("RightLevel", Column.Parameter(2))
								.Set("Position", Column.Parameter(0))
								.Set("SourceId", Column.Parameter("8A248A03-E9A5-DF11-9989-485B39C18470"))
								 as Insert;
						ins.Execute();
						ins =
							new Insert(UserConnection)
								.Into("SysMailboxSyncSettingsRight")
								.Set("RecordId", Column.Parameter(Entity.Id))
								.Set("SysAdminUnitId", Column.Parameter(currentUserId))
								.Set("Operation", Column.Parameter(EntitySchemaRecordRightOperation.Delete))
								.Set("RightLevel", Column.Parameter(2))
								.Set("Position", Column.Parameter(0))
								.Set("SourceId", Column.Parameter("8A248A03-E9A5-DF11-9989-485B39C18470"))
								 as Insert;
						ins.Execute();
					}
				}
			}
		}

		#endregion

	}

	#endregion

	#region Class: MailboxSyncSettings_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class MailboxSyncSettings_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public MailboxSyncSettings_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MailboxSyncSettings_Base_TerrasoftEventsProcessSchema(MailboxSyncSettings_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "MailboxSyncSettings_BaseEventsProcess";
			UId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateIsSharedDefParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5f8aa1d7-47eb-4141-b404-553f9c3d0731"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				Name = @"IsSharedDef",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsSharedDefParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaStartMessageEvent mailboxsyncsettingssaved = CreateMailboxSyncSettingsSavedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(mailboxsyncsettingssaved);
			ProcessSchemaScriptTask mailboxsyncsettingssavedscripttask = CreateMailboxSyncSettingsSavedScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(mailboxsyncsettingssavedscripttask);
			ProcessSchemaStartMessageEvent mailboxsyncsettingsinserted = CreateMailboxSyncSettingsInsertedStartMessageEvent();
			eventsubprocess2.FlowElements.Add(mailboxsyncsettingsinserted);
			ProcessSchemaScriptTask mailboxsyncsettingsinsertedscripttask = CreateMailboxSyncSettingsInsertedScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(mailboxsyncsettingsinsertedscripttask);
			ProcessSchemaStartMessageEvent mailboxsyncsettingssaving = CreateMailboxSyncSettingsSavingStartMessageEvent();
			eventsubprocess4.FlowElements.Add(mailboxsyncsettingssaving);
			ProcessSchemaScriptTask mailboxsyncsettingssavingscripttask = CreateMailboxSyncSettingsSavingScriptTaskScriptTask();
			eventsubprocess4.FlowElements.Add(mailboxsyncsettingssavingscripttask);
			ProcessSchemaStartMessageEvent mailboxsyncsettingsdeleting = CreateMailboxSyncSettingsDeletingStartMessageEvent();
			eventsubprocess3.FlowElements.Add(mailboxsyncsettingsdeleting);
			ProcessSchemaScriptTask mailboxsyncsettingsdeletingscripttask = CreateMailboxSyncSettingsDeletingScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(mailboxsyncsettingsdeletingscripttask);
			ProcessSchemaStartMessageEvent startmessagemailboxsyncsettingsupdated = CreateStartMessageMailboxSyncSettingsUpdatedStartMessageEvent();
			eventsubprocess5.FlowElements.Add(startmessagemailboxsyncsettingsupdated);
			ProcessSchemaScriptTask scripttaskmailboxsyncsettingsupdated = CreateScriptTaskMailboxSyncSettingsUpdatedScriptTask();
			eventsubprocess5.FlowElements.Add(scripttaskmailboxsyncsettingsupdated);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("4ec1ce37-7072-4c0f-b8c1-6044d3cbc1b9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				CurveCenterPosition = new Point(145, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("932ab824-8e8b-49f1-a156-5db83030dd13"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ef4f7464-130e-48ef-b835-ac60389c9b97"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("f0f33974-1ff9-445f-a9d2-dd8116d1f4c5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				CurveCenterPosition = new Point(408, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5de1e911-2a94-4b30-9517-d770f7f0eeb7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("118f9ee5-9549-4986-9545-7493769e4cc4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("3fe3a67f-e16a-41f3-a917-9bc0987accc3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				CurveCenterPosition = new Point(162, 259),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("deec75e4-b0e6-4702-b03a-7ccd779c0358"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("52d5eb7f-7e4d-47e1-98d7-97797a897ed4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("096103be-12ff-4693-9608-19eea5d6035e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("02c41552-6138-41c7-b1d8-208f324fe99a"),
				CreatedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				CurveCenterPosition = new Point(398, 261),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("52c6eb3b-0cbb-479b-8e64-1da87e475068"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c5e440a2-089b-4410-a9e7-1713f6467682"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("0b5065e1-aa71-40ef-b3b1-e6b25d2b3edd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				CreatedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				CurveCenterPosition = new Point(663, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5143a02b-b6cf-46a2-be05-2c5435bcf38c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("907cdc92-62d3-46b7-8114-aa716742b41a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("6d09bd84-cd30-414e-8ebb-c55abde8f2a6"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(841, 340),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("209dfcbd-3aa1-44d7-9c2e-6678b7619eea"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("6d09bd84-cd30-414e-8ebb-c55abde8f2a6"),
				CreatedInOwnerSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(812, 340),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f05546ac-fcc7-4711-8849-cb96618fa7de"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("209dfcbd-3aa1-44d7-9c2e-6678b7619eea"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(233, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMailboxSyncSettingsSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("932ab824-8e8b-49f1-a156-5db83030dd13"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f05546ac-fcc7-4711-8849-cb96618fa7de"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"MailboxSyncSettingsSaved",
				ModifiedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				Name = @"MailboxSyncSettingsSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateMailboxSyncSettingsSavedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ef4f7464-130e-48ef-b835-ac60389c9b97"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f05546ac-fcc7-4711-8849-cb96618fa7de"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				Name = @"MailboxSyncSettingsSavedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(120, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,193,106,195,48,16,68,207,9,228,31,182,62,4,9,130,127,32,244,16,18,31,114,104,41,53,166,103,213,90,199,2,121,157,74,171,54,166,244,223,187,193,78,72,41,237,113,135,125,51,195,184,6,84,65,236,120,200,247,113,135,141,73,158,53,124,46,230,179,119,19,32,29,45,220,3,225,7,84,71,107,24,85,21,49,108,123,34,172,217,245,180,130,236,193,56,255,218,159,202,129,234,18,153,29,29,98,166,133,158,229,114,170,236,234,153,173,96,219,251,212,81,254,100,130,233,144,49,168,198,248,136,122,252,126,105,49,160,252,219,76,75,145,199,158,139,183,100,188,250,197,92,186,218,137,219,144,189,77,57,195,127,144,28,18,222,66,229,16,55,182,115,84,145,227,41,246,255,204,159,128,214,96,226,52,203,90,92,101,170,188,56,97,157,100,37,45,194,215,98,238,100,219,125,44,91,19,208,74,65,88,46,225,238,186,245,40,143,83,239,208,75,208,168,60,187,67,203,241,98,17,144,83,32,56,119,95,127,3,115,212,142,60,171,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("404d60dd-ba85-419c-8bab-5c75a5d06070"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("209dfcbd-3aa1-44d7-9c2e-6678b7619eea"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(280, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(212, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMailboxSyncSettingsInsertedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5de1e911-2a94-4b30-9517-d770f7f0eeb7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("404d60dd-ba85-419c-8bab-5c75a5d06070"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"MailboxSyncSettingsInserted",
				ModifiedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				Name = @"MailboxSyncSettingsInserted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateMailboxSyncSettingsInsertedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("118f9ee5-9549-4986-9545-7493769e4cc4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("404d60dd-ba85-419c-8bab-5c75a5d06070"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				Name = @"MailboxSyncSettingsInsertedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(99, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,193,110,194,48,16,68,239,149,248,7,139,83,56,196,178,5,169,64,168,7,74,28,212,3,168,82,225,3,12,89,42,75,96,87,155,77,128,191,111,236,164,135,212,28,189,251,102,60,59,141,70,134,206,145,186,106,115,41,220,165,4,252,40,217,27,179,112,99,155,218,148,201,88,206,101,177,200,167,179,52,203,149,74,149,144,50,93,205,95,223,83,33,100,150,229,98,182,22,50,31,79,150,163,151,166,181,242,46,71,119,239,140,246,143,31,8,102,221,115,237,108,69,21,223,198,72,47,214,39,50,141,161,71,183,234,67,236,1,81,87,238,76,188,213,159,205,119,141,154,140,179,124,53,128,147,67,21,62,176,112,242,91,31,103,232,198,67,16,127,17,223,193,45,92,246,4,218,233,43,180,152,178,212,206,254,146,250,97,140,126,106,4,75,193,53,234,47,166,255,21,242,164,166,88,243,165,27,8,33,17,168,70,203,8,107,88,254,2,134,194,121,149,176,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4a2df159-f182-465e-bad1-4db4e7275fac"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("209dfcbd-3aa1-44d7-9c2e-6678b7619eea"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				Name = @"EventSubProcess4",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 168),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(233, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMailboxSyncSettingsSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("deec75e4-b0e6-4702-b03a-7ccd779c0358"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4a2df159-f182-465e-bad1-4db4e7275fac"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"MailboxSyncSettingsSaving",
				ModifiedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				Name = @"MailboxSyncSettingsSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateMailboxSyncSettingsSavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("52d5eb7f-7e4d-47e1-98d7-97797a897ed4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4a2df159-f182-465e-bad1-4db4e7275fac"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				Name = @"MailboxSyncSettingsSavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(120, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,44,14,206,72,44,74,77,113,73,77,83,176,85,208,72,202,207,207,209,212,112,205,43,201,44,169,212,115,79,45,113,206,207,41,205,205,243,207,73,9,75,204,41,77,213,80,242,132,42,87,210,84,176,183,87,72,75,204,41,78,213,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,246,187,198,165,82,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("97f942d4-6d57-47aa-b066-8c61a65f9413"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("209dfcbd-3aa1-44d7-9c2e-6678b7619eea"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("02c41552-6138-41c7-b1d8-208f324fe99a"),
				CreatedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(280, 168),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(210, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMailboxSyncSettingsDeletingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("52c6eb3b-0cbb-479b-8e64-1da87e475068"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("97f942d4-6d57-47aa-b066-8c61a65f9413"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("02c41552-6138-41c7-b1d8-208f324fe99a"),
				CreatedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"MailboxSyncSettingsDeleting",
				ModifiedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				Name = @"MailboxSyncSettingsDeleting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateMailboxSyncSettingsDeletingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c5e440a2-089b-4410-a9e7-1713f6467682"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("97f942d4-6d57-47aa-b066-8c61a65f9413"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("02c41552-6138-41c7-b1d8-208f324fe99a"),
				CreatedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				Name = @"MailboxSyncSettingsDeletingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(99, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,77,106,195,48,16,133,215,53,248,14,194,43,25,130,46,144,31,72,226,26,186,72,55,161,7,152,72,211,68,197,30,193,120,226,214,132,220,189,82,76,2,78,187,157,247,230,251,94,15,172,192,138,239,189,12,117,104,28,242,222,158,176,5,181,84,31,29,242,54,16,97,140,3,153,87,146,216,25,211,29,16,28,145,77,237,201,189,81,39,64,22,55,195,59,180,168,139,245,132,86,148,243,60,235,255,72,34,254,63,171,217,50,130,224,168,210,211,1,119,144,13,228,124,58,68,6,225,183,170,252,45,6,30,22,157,176,167,227,76,133,195,87,252,89,233,244,242,168,155,181,115,186,72,27,139,153,26,13,102,7,190,57,132,159,116,76,93,255,169,167,171,76,141,98,79,53,135,182,218,232,7,169,44,213,37,207,94,158,170,21,54,40,120,115,94,243,140,81,206,76,74,248,140,243,95,176,112,37,90,100,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f02a626a-3bfe-41e4-9743-d9279f6d7e8f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("209dfcbd-3aa1-44d7-9c2e-6678b7619eea"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				CreatedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				Name = @"EventSubProcess5",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(504, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(280, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageMailboxSyncSettingsUpdatedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5143a02b-b6cf-46a2-be05-2c5435bcf38c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f02a626a-3bfe-41e4-9743-d9279f6d7e8f"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				CreatedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"MailboxSyncSettingsUpdated",
				ModifiedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				Name = @"StartMessageMailboxSyncSettingsUpdated",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskMailboxSyncSettingsUpdatedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("907cdc92-62d3-46b7-8114-aa716742b41a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f02a626a-3bfe-41e4-9743-d9279f6d7e8f"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				CreatedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				Name = @"ScriptTaskMailboxSyncSettingsUpdated",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(148, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,221,74,3,49,16,133,175,119,97,223,33,230,42,129,146,23,168,21,74,89,165,224,31,104,245,58,109,70,13,166,73,157,157,172,45,226,187,155,108,202,34,20,193,187,76,114,190,115,206,164,215,200,60,124,62,105,23,129,205,88,235,201,210,65,93,1,61,30,118,96,22,193,197,173,31,30,207,59,66,235,95,47,4,191,209,214,173,195,254,86,111,129,203,105,83,247,201,34,56,243,135,197,157,251,159,139,125,97,98,44,114,54,27,29,37,251,106,234,42,103,196,157,209,148,19,146,140,173,134,65,172,58,192,69,240,30,54,100,131,159,48,62,79,135,62,229,95,38,30,144,203,196,86,234,1,72,240,33,105,194,74,25,117,175,49,205,4,56,134,202,162,125,126,3,132,163,90,170,101,119,109,223,65,156,64,99,187,2,205,189,17,188,68,230,165,151,102,64,219,143,168,221,41,91,116,169,117,71,157,58,126,195,111,86,230,239,168,202,182,170,221,195,38,166,69,243,221,119,83,35,80,68,207,8,35,76,127,0,161,114,207,216,187,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateDeleteSharedRightsMethod());
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

		protected virtual SchemaMethod CreateDeleteSharedRightsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e61ff82e-592a-4ce3-a117-7ccfd7ac2b63"),
				Name = "DeleteSharedRights",
				CreatedInSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,85,93,111,155,48,20,125,166,82,255,3,227,201,72,11,74,218,84,3,85,125,32,129,78,72,251,168,130,170,62,187,248,174,177,4,246,102,155,172,209,212,255,190,139,33,97,161,68,237,219,164,170,72,32,235,250,158,115,239,185,7,204,134,42,183,168,149,2,97,110,53,168,140,185,87,110,179,88,74,33,160,48,92,138,96,217,111,7,25,187,60,61,217,32,166,162,162,166,101,46,107,85,128,5,9,248,237,126,174,57,35,94,24,159,205,195,120,122,62,73,163,248,98,146,92,207,102,147,40,10,163,201,60,188,88,156,71,203,89,56,255,52,245,252,142,135,65,217,129,19,40,193,0,57,44,238,159,158,56,193,181,146,21,241,242,173,254,74,121,121,47,31,243,173,40,114,48,134,139,7,189,226,15,107,227,217,180,187,53,40,32,222,10,10,169,88,198,60,63,200,116,250,11,187,36,75,89,214,149,8,110,168,162,21,214,80,36,21,134,155,45,170,241,45,50,22,204,242,199,172,226,226,86,112,211,161,191,73,115,132,224,96,100,190,239,82,221,245,143,178,80,82,144,62,66,81,163,154,157,76,189,151,153,99,90,97,198,100,182,69,136,215,20,255,175,178,95,175,185,21,131,26,107,141,93,185,36,89,180,194,37,26,123,191,95,62,123,163,82,161,107,5,201,162,15,17,228,251,131,61,117,60,89,66,13,93,1,101,128,68,13,129,238,103,218,134,73,207,223,65,29,254,131,124,96,42,104,246,119,116,142,147,9,44,109,92,46,180,123,101,3,78,99,66,27,29,49,161,185,130,76,24,249,242,224,109,42,134,255,25,253,71,247,133,145,247,152,193,216,71,144,131,113,31,160,191,255,4,69,155,158,143,151,204,139,53,84,180,109,205,54,189,199,216,9,13,8,109,198,23,216,64,57,198,120,54,200,190,145,154,31,171,62,29,10,237,142,136,177,220,87,30,21,59,194,230,141,107,157,187,180,17,52,245,224,67,107,67,239,62,239,124,78,25,55,239,62,191,125,159,219,63,207,219,116,250,9,31,120,63,253,5,64,12,115,207,168,8,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MailboxSyncSettings_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"));
		}

		#endregion

	}

	#endregion

}

