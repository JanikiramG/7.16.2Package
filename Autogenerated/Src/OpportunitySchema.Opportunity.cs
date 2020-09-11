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

	#region Class: Opportunity_Opportunity_TerrasoftSchema

	/// <exclude/>
	public class Opportunity_Opportunity_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public Opportunity_Opportunity_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Opportunity_Opportunity_TerrasoftSchema(Opportunity_Opportunity_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Opportunity_Opportunity_TerrasoftSchema(Opportunity_Opportunity_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIDX_OpportunityTitleIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("538d5288-c406-4b69-8f00-7b42c02cbdf3");
			index.Name = "IDX_OpportunityTitle";
			index.CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			index.ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			index.CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
			EntitySchemaIndexColumn titleIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("7a45b5d6-7ce5-4417-8995-a0f6d21a272b"),
				ColumnUId = new Guid("790563cf-fd14-4d5d-a5fd-b6eddb10d6d3"),
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(titleIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			RealUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			Name = "Opportunity_Opportunity_Terrasoft";
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

		protected override void InitializeOwnerColumn() {
			base.InitializeOwnerColumn();
			OwnerColumn = CreateOwnerColumn();
			if (Columns.FindByUId(OwnerColumn.UId) == null) {
				Columns.Add(OwnerColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("2b2e93bb-c5ac-4478-9e31-306c5bd5ceeb")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("797ac352-4979-4d28-906f-82feb6dbc9dc")) == null) {
				Columns.Add(CreateStageColumn());
			}
			if (Columns.FindByUId(new Guid("c8f5d6d7-aa99-4295-ade0-4ff6e840655f")) == null) {
				Columns.Add(CreateDueDateColumn());
			}
			if (Columns.FindByUId(new Guid("d979bca9-13c3-463b-b279-641c0c51f9df")) == null) {
				Columns.Add(CreateCloseReasonColumn());
			}
			if (Columns.FindByUId(new Guid("975de813-489f-495b-98ab-e56a8a527e77")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("4b95e3ff-fd52-4ae1-b0a5-2c5103ff15a7")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("fae41c1b-a153-43df-852a-17ab3e608c18")) == null) {
				Columns.Add(CreateCategoryColumn());
			}
			if (Columns.FindByUId(new Guid("c4eab4ef-2c91-43b5-b2a1-df5e60f6c3cd")) == null) {
				Columns.Add(CreateMoodColumn());
			}
			if (Columns.FindByUId(new Guid("3aab3a22-ded6-41a6-98bb-4bc7ca20bb06")) == null) {
				Columns.Add(CreateIsPrimaryColumn());
			}
			if (Columns.FindByUId(new Guid("75ad358c-8d9c-4bbb-83d5-2d9f60d3b7c3")) == null) {
				Columns.Add(CreatePartnerColumn());
			}
			if (Columns.FindByUId(new Guid("4348809e-6f05-426c-8802-958ffe90b176")) == null) {
				Columns.Add(CreateBudgetColumn());
			}
			if (Columns.FindByUId(new Guid("bc62f730-7e4a-4578-953c-1cd9ac58a2b2")) == null) {
				Columns.Add(CreateProbabilityColumn());
			}
			if (Columns.FindByUId(new Guid("63c0fc1f-ac41-4497-96be-c27201994072")) == null) {
				Columns.Add(CreateAmountColumn());
			}
			if (Columns.FindByUId(new Guid("6c76d697-8138-47fc-897c-1f3820c45893")) == null) {
				Columns.Add(CreateSourceColumn());
			}
			if (Columns.FindByUId(new Guid("15f0f091-e66f-42db-807b-f4c2ad6337b6")) == null) {
				Columns.Add(CreateResponsibleDepartmentColumn());
			}
			if (Columns.FindByUId(new Guid("19429c25-e5dc-4a77-ab74-69bbec821ce4")) == null) {
				Columns.Add(CreateWeaknessesColumn());
			}
			if (Columns.FindByUId(new Guid("9295050c-1727-416a-949d-4684e2b61e3b")) == null) {
				Columns.Add(CreateStrengthColumn());
			}
			if (Columns.FindByUId(new Guid("d1cf610a-dc34-447b-b637-9970dc4f1b7e")) == null) {
				Columns.Add(CreateTacticColumn());
			}
			if (Columns.FindByUId(new Guid("7d2e418f-2cac-4b0c-823c-9f431027ce56")) == null) {
				Columns.Add(CreateCheckDateColumn());
			}
			if (Columns.FindByUId(new Guid("65715559-fa3f-4781-be93-5f3920b3e8f4")) == null) {
				Columns.Add(CreateProcessIdColumn());
			}
			if (Columns.FindByUId(new Guid("f460aa34-e072-4804-aa46-f886e60a3852")) == null) {
				Columns.Add(CreateWinnerColumn());
			}
			if (Columns.FindByUId(new Guid("64a05bfa-350d-4dbf-bfd8-fb579a74f39e")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("cf5dc330-48e7-48ac-8b86-06ffb1ae0391")) == null) {
				Columns.Add(CreateCompletenessColumn());
			}
			if (Columns.FindByUId(new Guid("f22a9cf5-213a-427f-aed7-ef864ffff2dd")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.IsIndexed = true;
			column.ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			return column;
		}

		protected virtual EntitySchemaColumn CreateTitleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("790563cf-fd14-4d5d-a5fd-b6eddb10d6d3"),
				Name = @"Title",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2b2e93bb-c5ac-4478-9e31-306c5bd5ceeb"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("85fe0df7-a970-4717-8f7b-8caba783906b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateStageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("797ac352-4979-4d28-906f-82feb6dbc9dc"),
				Name = @"Stage",
				ReferenceSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"c2067b11-0ee0-df11-971b-001d60e938c6"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateDueDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("c8f5d6d7-aa99-4295-ade0-4ff6e840655f"),
				Name = @"DueDate",
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCloseReasonColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d979bca9-13c3-463b-b279-641c0c51f9df"),
				Name = @"CloseReason",
				ReferenceSchemaUId = new Guid("27ba43e5-6280-4458-855d-3c7118f678d7"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("684553a7-a59d-46fa-af4b-fc76e9fe3694"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("975de813-489f-495b-98ab-e56a8a527e77"),
				Name = @"Notes",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4b95e3ff-fd52-4ae1-b0a5-2c5103ff15a7"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fae41c1b-a153-43df-852a-17ab3e608c18"),
				Name = @"Category",
				ReferenceSchemaUId = new Guid("98f95046-8a53-4d6d-be56-91d68e624e6a"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateMoodColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c4eab4ef-2c91-43b5-b2a1-df5e60f6c3cd"),
				Name = @"Mood",
				ReferenceSchemaUId = new Guid("c8b8800f-c6ca-4b8b-962b-e79307b5d95e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateIsPrimaryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("3aab3a22-ded6-41a6-98bb-4bc7ca20bb06"),
				Name = @"IsPrimary",
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreatePartnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("75ad358c-8d9c-4bbb-83d5-2d9f60d3b7c3"),
				Name = @"Partner",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateBudgetColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("4348809e-6f05-426c-8802-958ffe90b176"),
				Name = @"Budget",
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateProbabilityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("bc62f730-7e4a-4578-953c-1cd9ac58a2b2"),
				Name = @"Probability",
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("63c0fc1f-ac41-4497-96be-c27201994072"),
				Name = @"Amount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateSourceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6c76d697-8138-47fc-897c-1f3820c45893"),
				Name = @"Source",
				ReferenceSchemaUId = new Guid("6f66df29-03a2-41b3-9cde-021eeeedfcb0"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateResponsibleDepartmentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("15f0f091-e66f-42db-807b-f4c2ad6337b6"),
				Name = @"ResponsibleDepartment",
				ReferenceSchemaUId = new Guid("5d8456b4-15e0-4de5-b0e5-afb10f6795c0"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateWeaknessesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("19429c25-e5dc-4a77-ab74-69bbec821ce4"),
				Name = @"Weaknesses",
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateStrengthColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("9295050c-1727-416a-949d-4684e2b61e3b"),
				Name = @"Strength",
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateTacticColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("d1cf610a-dc34-447b-b637-9970dc4f1b7e"),
				Name = @"Tactic",
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateCheckDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("7d2e418f-2cac-4b0c-823c-9f431027ce56"),
				Name = @"CheckDate",
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateProcessIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("65715559-fa3f-4781-be93-5f3920b3e8f4"),
				Name = @"ProcessId",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			};
		}

		protected virtual EntitySchemaColumn CreateWinnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f460aa34-e072-4804-aa46-f886e60a3852"),
				Name = @"Winner",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("64a05bfa-350d-4dbf-bfd8-fb579a74f39e"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("847c168f-46d2-4935-ba54-2d351061d222")
			};
		}

		protected virtual EntitySchemaColumn CreateCompletenessColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("cf5dc330-48e7-48ac-8b86-06ffb1ae0391"),
				Name = @"Completeness",
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("2e81487b-ecb4-48b5-b3e6-cfc1669b881f")
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("f22a9cf5-213a-427f-aed7-ef864ffff2dd"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340"),
				IsMultiLineText = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIDX_OpportunityTitleIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOpportunity_Opportunity_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateOpportunity_Opportunity_TerrasoftEventsProcessSchema() {
			var schema = new Opportunity_Opportunity_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Opportunity_Opportunity_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Opportunity_OpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Opportunity_Opportunity_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Opportunity_Opportunity_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"));
		}

		#endregion

	}

	#endregion

	#region Class: Opportunity_Opportunity_Terrasoft

	/// <summary>
	/// Opportunity.
	/// </summary>
	public class Opportunity_Opportunity_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public Opportunity_Opportunity_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Opportunity_Opportunity_Terrasoft";
		}

		public Opportunity_Opportunity_Terrasoft(Opportunity_Opportunity_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public string Title {
			get {
				return GetTypedColumnValue<string>("Title");
			}
			set {
				SetColumnValue("Title", value);
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

		private OpportunityType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public OpportunityType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as OpportunityType);
			}
		}

		/// <exclude/>
		public Guid StageId {
			get {
				return GetTypedColumnValue<Guid>("StageId");
			}
			set {
				SetColumnValue("StageId", value);
				_stage = null;
			}
		}

		/// <exclude/>
		public string StageName {
			get {
				return GetTypedColumnValue<string>("StageName");
			}
			set {
				SetColumnValue("StageName", value);
				if (_stage != null) {
					_stage.Name = value;
				}
			}
		}

		private OpportunityStage _stage;
		/// <summary>
		/// Stage.
		/// </summary>
		public OpportunityStage Stage {
			get {
				return _stage ??
					(_stage = LookupColumnEntities.GetEntity("Stage") as OpportunityStage);
			}
		}

		/// <summary>
		/// Closed on.
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
		public Guid CloseReasonId {
			get {
				return GetTypedColumnValue<Guid>("CloseReasonId");
			}
			set {
				SetColumnValue("CloseReasonId", value);
				_closeReason = null;
			}
		}

		/// <exclude/>
		public string CloseReasonName {
			get {
				return GetTypedColumnValue<string>("CloseReasonName");
			}
			set {
				SetColumnValue("CloseReasonName", value);
				if (_closeReason != null) {
					_closeReason.Name = value;
				}
			}
		}

		private OpportunityCloseReason _closeReason;
		/// <summary>
		/// Reason for closing.
		/// </summary>
		public OpportunityCloseReason CloseReason {
			get {
				return _closeReason ??
					(_closeReason = LookupColumnEntities.GetEntity("CloseReason") as OpportunityCloseReason);
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
		public Guid CategoryId {
			get {
				return GetTypedColumnValue<Guid>("CategoryId");
			}
			set {
				SetColumnValue("CategoryId", value);
				_category = null;
			}
		}

		/// <exclude/>
		public string CategoryName {
			get {
				return GetTypedColumnValue<string>("CategoryName");
			}
			set {
				SetColumnValue("CategoryName", value);
				if (_category != null) {
					_category.Name = value;
				}
			}
		}

		private OpportunityCategory _category;
		/// <summary>
		/// Category.
		/// </summary>
		public OpportunityCategory Category {
			get {
				return _category ??
					(_category = LookupColumnEntities.GetEntity("Category") as OpportunityCategory);
			}
		}

		/// <exclude/>
		public Guid MoodId {
			get {
				return GetTypedColumnValue<Guid>("MoodId");
			}
			set {
				SetColumnValue("MoodId", value);
				_mood = null;
			}
		}

		/// <exclude/>
		public string MoodName {
			get {
				return GetTypedColumnValue<string>("MoodName");
			}
			set {
				SetColumnValue("MoodName", value);
				if (_mood != null) {
					_mood.Name = value;
				}
			}
		}

		private OpportunityMood _mood;
		/// <summary>
		/// Mood.
		/// </summary>
		public OpportunityMood Mood {
			get {
				return _mood ??
					(_mood = LookupColumnEntities.GetEntity("Mood") as OpportunityMood);
			}
		}

		/// <summary>
		/// New customer.
		/// </summary>
		public bool IsPrimary {
			get {
				return GetTypedColumnValue<bool>("IsPrimary");
			}
			set {
				SetColumnValue("IsPrimary", value);
			}
		}

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

		/// <summary>
		/// Budget.
		/// </summary>
		public Decimal Budget {
			get {
				return GetTypedColumnValue<Decimal>("Budget");
			}
			set {
				SetColumnValue("Budget", value);
			}
		}

		/// <summary>
		/// Probability, %.
		/// </summary>
		public int Probability {
			get {
				return GetTypedColumnValue<int>("Probability");
			}
			set {
				SetColumnValue("Probability", value);
			}
		}

		/// <summary>
		/// Opportunity amount.
		/// </summary>
		public Decimal Amount {
			get {
				return GetTypedColumnValue<Decimal>("Amount");
			}
			set {
				SetColumnValue("Amount", value);
			}
		}

		/// <exclude/>
		public Guid SourceId {
			get {
				return GetTypedColumnValue<Guid>("SourceId");
			}
			set {
				SetColumnValue("SourceId", value);
				_source = null;
			}
		}

		/// <exclude/>
		public string SourceName {
			get {
				return GetTypedColumnValue<string>("SourceName");
			}
			set {
				SetColumnValue("SourceName", value);
				if (_source != null) {
					_source.Name = value;
				}
			}
		}

		private OpportunitySource _source;
		/// <summary>
		/// Source.
		/// </summary>
		public OpportunitySource Source {
			get {
				return _source ??
					(_source = LookupColumnEntities.GetEntity("Source") as OpportunitySource);
			}
		}

		/// <exclude/>
		public Guid ResponsibleDepartmentId {
			get {
				return GetTypedColumnValue<Guid>("ResponsibleDepartmentId");
			}
			set {
				SetColumnValue("ResponsibleDepartmentId", value);
				_responsibleDepartment = null;
			}
		}

		/// <exclude/>
		public string ResponsibleDepartmentName {
			get {
				return GetTypedColumnValue<string>("ResponsibleDepartmentName");
			}
			set {
				SetColumnValue("ResponsibleDepartmentName", value);
				if (_responsibleDepartment != null) {
					_responsibleDepartment.Name = value;
				}
			}
		}

		private OpportunityDepartment _responsibleDepartment;
		/// <summary>
		/// Division.
		/// </summary>
		public OpportunityDepartment ResponsibleDepartment {
			get {
				return _responsibleDepartment ??
					(_responsibleDepartment = LookupColumnEntities.GetEntity("ResponsibleDepartment") as OpportunityDepartment);
			}
		}

		/// <summary>
		/// Our weaknesses.
		/// </summary>
		public string Weaknesses {
			get {
				return GetTypedColumnValue<string>("Weaknesses");
			}
			set {
				SetColumnValue("Weaknesses", value);
			}
		}

		/// <summary>
		/// Our strengths.
		/// </summary>
		public string Strength {
			get {
				return GetTypedColumnValue<string>("Strength");
			}
			set {
				SetColumnValue("Strength", value);
			}
		}

		/// <summary>
		/// Sales tactics.
		/// </summary>
		public string Tactic {
			get {
				return GetTypedColumnValue<string>("Tactic");
			}
			set {
				SetColumnValue("Tactic", value);
			}
		}

		/// <summary>
		/// Verified on.
		/// </summary>
		public DateTime CheckDate {
			get {
				return GetTypedColumnValue<DateTime>("CheckDate");
			}
			set {
				SetColumnValue("CheckDate", value);
			}
		}

		/// <summary>
		/// Process Id.
		/// </summary>
		public Guid ProcessId {
			get {
				return GetTypedColumnValue<Guid>("ProcessId");
			}
			set {
				SetColumnValue("ProcessId", value);
			}
		}

		/// <exclude/>
		public Guid WinnerId {
			get {
				return GetTypedColumnValue<Guid>("WinnerId");
			}
			set {
				SetColumnValue("WinnerId", value);
				_winner = null;
			}
		}

		/// <exclude/>
		public string WinnerName {
			get {
				return GetTypedColumnValue<string>("WinnerName");
			}
			set {
				SetColumnValue("WinnerName", value);
				if (_winner != null) {
					_winner.Name = value;
				}
			}
		}

		private Account _winner;
		/// <summary>
		/// Winner.
		/// </summary>
		public Account Winner {
			get {
				return _winner ??
					(_winner = LookupColumnEntities.GetEntity("Winner") as Account);
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
		/// Completeness.
		/// </summary>
		public int Completeness {
			get {
				return GetTypedColumnValue<int>("Completeness");
			}
			set {
				SetColumnValue("Completeness", value);
			}
		}

		/// <summary>
		/// Description.
		/// </summary>
		public string Description {
			get {
				return GetTypedColumnValue<string>("Description");
			}
			set {
				SetColumnValue("Description", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Opportunity_OpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Opportunity_Opportunity_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Opportunity_Opportunity_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("Opportunity_Opportunity_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("Opportunity_Opportunity_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Opportunity_Opportunity_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Opportunity_Opportunity_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Opportunity_Opportunity_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Opportunity_Opportunity_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Opportunity_OpportunityEventsProcess

	/// <exclude/>
	public partial class Opportunity_OpportunityEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : Opportunity_Opportunity_Terrasoft
	{

		#region Class: PrimaryActualRevenueCalcSumUserTaskFlowElement

		/// <exclude/>
		public class PrimaryActualRevenueCalcSumUserTaskFlowElement : CalcSumUserTask
		{

			public PrimaryActualRevenueCalcSumUserTaskFlowElement(UserConnection userConnection, Opportunity_OpportunityEventsProcess<TEntity> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "PrimaryActualRevenueCalcSumUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("047e7598-b79a-46b1-8e57-8a057cfe8e5e");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: SynchronizeStageFlowElement

		/// <exclude/>
		public class SynchronizeStageFlowElement : SynchronizeChildEntityData
		{

			public SynchronizeStageFlowElement(UserConnection userConnection, Opportunity_OpportunityEventsProcess<TEntity> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SynchronizeStage";
				IsLogging = false;
				SchemaElementUId = new Guid("5363dbee-cfca-42db-a161-776e61c80ee8");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: PrimaryActualRevenueCalcSumOnDeleteUserTaskFlowElement

		/// <exclude/>
		public class PrimaryActualRevenueCalcSumOnDeleteUserTaskFlowElement : CalcSumUserTask
		{

			public PrimaryActualRevenueCalcSumOnDeleteUserTaskFlowElement(UserConnection userConnection, Opportunity_OpportunityEventsProcess<TEntity> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "PrimaryActualRevenueCalcSumOnDeleteUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("5dfe5189-466f-49c2-b05b-c2a6f82981f2");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public Opportunity_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Opportunity_OpportunityEventsProcess";
			SchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Guid StageOldValue {
			get;
			set;
		}

		public virtual bool IsStageChanged {
			get;
			set;
		}

		public virtual bool NeedSynchronizeCompetitor {
			get;
			set;
		}

		public virtual bool IsOwnerChanged {
			get;
			set;
		}

		public virtual Guid CampaignId {
			get;
			set;
		}

		public virtual Guid CampaignOldValue {
			get;
			set;
		}

		public virtual bool IsNewStageEnd {
			get;
			set;
		}

		public virtual Guid OldOwnerId {
			get;
			set;
		}

		public virtual bool IsTacticChanged {
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

		private ProcessFlowElement _subProcess1;
		public ProcessFlowElement SubProcess1 {
			get {
				return _subProcess1 ?? (_subProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess1",
					SchemaElementUId = new Guid("67267353-ee30-460a-a08f-7f503cdef2ca"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _opportunitySaved;
		public ProcessFlowElement OpportunitySaved {
			get {
				return _opportunitySaved ?? (_opportunitySaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OpportunitySaved",
					SchemaElementUId = new Guid("8af1be52-c288-43d8-afc4-a09b32ab1996"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _synchronizeStageScript;
		public ProcessScriptTask SynchronizeStageScript {
			get {
				return _synchronizeStageScript ?? (_synchronizeStageScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SynchronizeStageScript",
					SchemaElementUId = new Guid("8020eaaf-f57a-4bf3-9c97-2cb7d483e5aa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SynchronizeStageScriptExecute,
				});
			}
		}

		private ProcessScriptTask _resetCompetitorsIsWinnerFalgScriptTask;
		public ProcessScriptTask ResetCompetitorsIsWinnerFalgScriptTask {
			get {
				return _resetCompetitorsIsWinnerFalgScriptTask ?? (_resetCompetitorsIsWinnerFalgScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ResetCompetitorsIsWinnerFalgScriptTask",
					SchemaElementUId = new Guid("8d0ca9d5-2876-404e-bddd-57cfcf8f47ab"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ResetCompetitorsIsWinnerFalgScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _scriptPrimaryActualRevenueCalcSum;
		public ProcessScriptTask ScriptPrimaryActualRevenueCalcSum {
			get {
				return _scriptPrimaryActualRevenueCalcSum ?? (_scriptPrimaryActualRevenueCalcSum = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPrimaryActualRevenueCalcSum",
					SchemaElementUId = new Guid("8075f06c-e302-49cd-b9c2-3548a040da09"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPrimaryActualRevenueCalcSumExecute,
				});
			}
		}

		private PrimaryActualRevenueCalcSumUserTaskFlowElement _primaryActualRevenueCalcSumUserTask;
		public PrimaryActualRevenueCalcSumUserTaskFlowElement PrimaryActualRevenueCalcSumUserTask {
			get {
				return _primaryActualRevenueCalcSumUserTask ?? (_primaryActualRevenueCalcSumUserTask = new PrimaryActualRevenueCalcSumUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _scriptDoNothing;
		public ProcessScriptTask ScriptDoNothing {
			get {
				return _scriptDoNothing ?? (_scriptDoNothing = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDoNothing",
					SchemaElementUId = new Guid("d4e66c47-cd0c-4e92-9a59-1b705d7e3334"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDoNothingExecute,
				});
			}
		}

		private SynchronizeStageFlowElement _synchronizeStage;
		public SynchronizeStageFlowElement SynchronizeStage {
			get {
				return _synchronizeStage ?? (_synchronizeStage = new SynchronizeStageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("56796de1-8d42-460e-b1cc-30f198063445"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateRemindingsExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess2;
		public ProcessFlowElement SubProcess2 {
			get {
				return _subProcess2 ?? (_subProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess2",
					SchemaElementUId = new Guid("2b072ee0-6c70-4a3b-b0b0-1752cbe3259a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _opportunitySaving;
		public ProcessFlowElement OpportunitySaving {
			get {
				return _opportunitySaving ?? (_opportunitySaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OpportunitySaving",
					SchemaElementUId = new Guid("6be2a148-5ab8-4792-947c-5594134ff4b3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptOpportunitySaving;
		public ProcessScriptTask ScriptOpportunitySaving {
			get {
				return _scriptOpportunitySaving ?? (_scriptOpportunitySaving = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptOpportunitySaving",
					SchemaElementUId = new Guid("a0e6fad5-70a6-47b0-9328-11505b526d6b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptOpportunitySavingExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess3;
		public ProcessFlowElement SubProcess3 {
			get {
				return _subProcess3 ?? (_subProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess3",
					SchemaElementUId = new Guid("42fb7d8c-e942-4855-9233-9dd870db06cb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _opportunityDeleting;
		public ProcessFlowElement OpportunityDeleting {
			get {
				return _opportunityDeleting ?? (_opportunityDeleting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OpportunityDeleting",
					SchemaElementUId = new Guid("3a094e2c-1580-4f53-a8e8-155cac0202f5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptOpportunityDeleting;
		public ProcessScriptTask ScriptOpportunityDeleting {
			get {
				return _scriptOpportunityDeleting ?? (_scriptOpportunityDeleting = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptOpportunityDeleting",
					SchemaElementUId = new Guid("27e3276c-fd8a-4ec2-858d-68c734734a22"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptOpportunityDeletingExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess4;
		public ProcessFlowElement SubProcess4 {
			get {
				return _subProcess4 ?? (_subProcess4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess4",
					SchemaElementUId = new Guid("049ceae7-6039-4901-80af-77656912f566"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask2;
		public ProcessScriptTask ScriptTask2 {
			get {
				return _scriptTask2 ?? (_scriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask2",
					SchemaElementUId = new Guid("48265622-0d8c-4a5f-9246-eb16a24a6a7d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
				});
			}
		}

		private PrimaryActualRevenueCalcSumOnDeleteUserTaskFlowElement _primaryActualRevenueCalcSumOnDeleteUserTask;
		public PrimaryActualRevenueCalcSumOnDeleteUserTaskFlowElement PrimaryActualRevenueCalcSumOnDeleteUserTask {
			get {
				return _primaryActualRevenueCalcSumOnDeleteUserTask ?? (_primaryActualRevenueCalcSumOnDeleteUserTask = new PrimaryActualRevenueCalcSumOnDeleteUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _scriptDeleteDoNothing;
		public ProcessScriptTask ScriptDeleteDoNothing {
			get {
				return _scriptDeleteDoNothing ?? (_scriptDeleteDoNothing = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDeleteDoNothing",
					SchemaElementUId = new Guid("d314254b-f9a9-42a9-9d05-c0de08ed91e5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDeleteDoNothingExecute,
				});
			}
		}

		private ProcessConditionalFlow _sequenceFlow6790;
		public ProcessConditionalFlow SequenceFlow6790 {
			get {
				return _sequenceFlow6790 ?? (_sequenceFlow6790 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "SequenceFlow6790",
					SchemaElementUId = new Guid("171018ec-9329-4062-bdad-99f499b5bcb7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _sequenceFlow6793;
		public ProcessConditionalFlow SequenceFlow6793 {
			get {
				return _sequenceFlow6793 ?? (_sequenceFlow6793 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "SequenceFlow6793",
					SchemaElementUId = new Guid("efb73336-27e0-48e3-bf29-9fb9843aab75"),
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
			FlowElements[SubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess1 };
			FlowElements[OpportunitySaved.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunitySaved };
			FlowElements[SynchronizeStageScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeStageScript };
			FlowElements[ResetCompetitorsIsWinnerFalgScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ResetCompetitorsIsWinnerFalgScriptTask };
			FlowElements[ScriptPrimaryActualRevenueCalcSum.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPrimaryActualRevenueCalcSum };
			FlowElements[PrimaryActualRevenueCalcSumUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PrimaryActualRevenueCalcSumUserTask };
			FlowElements[ScriptDoNothing.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDoNothing };
			FlowElements[SynchronizeStage.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeStage };
			FlowElements[UpdateRemindings.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateRemindings };
			FlowElements[SubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess2 };
			FlowElements[OpportunitySaving.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunitySaving };
			FlowElements[ScriptOpportunitySaving.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptOpportunitySaving };
			FlowElements[SubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess3 };
			FlowElements[OpportunityDeleting.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityDeleting };
			FlowElements[ScriptOpportunityDeleting.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptOpportunityDeleting };
			FlowElements[SubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess4 };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[PrimaryActualRevenueCalcSumOnDeleteUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PrimaryActualRevenueCalcSumOnDeleteUserTask };
			FlowElements[ScriptDeleteDoNothing.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDeleteDoNothing };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcess1":
						break;
					case "OpportunitySaved":
						e.Context.QueueTasks.Enqueue("SynchronizeStageScript");
						e.Context.QueueTasks.Enqueue("UpdateRemindings");
						break;
					case "SynchronizeStageScript":
						e.Context.QueueTasks.Enqueue("ResetCompetitorsIsWinnerFalgScriptTask");
						break;
					case "ResetCompetitorsIsWinnerFalgScriptTask":
						break;
					case "ScriptPrimaryActualRevenueCalcSum":
						if (SequenceFlow6790ExpressionExecute()) {
						e.Context.QueueTasks.Enqueue("PrimaryActualRevenueCalcSumUserTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("ScriptDoNothing");
						break;
					case "PrimaryActualRevenueCalcSumUserTask":
						break;
					case "ScriptDoNothing":
						break;
					case "SynchronizeStage":
						break;
					case "UpdateRemindings":
						break;
					case "SubProcess2":
						break;
					case "OpportunitySaving":
						e.Context.QueueTasks.Enqueue("ScriptOpportunitySaving");
						break;
					case "ScriptOpportunitySaving":
						break;
					case "SubProcess3":
						break;
					case "OpportunityDeleting":
						e.Context.QueueTasks.Enqueue("ScriptOpportunityDeleting");
						break;
					case "ScriptOpportunityDeleting":
						break;
					case "SubProcess4":
						break;
					case "ScriptTask2":
						if (SequenceFlow6793ExpressionExecute()) {
						e.Context.QueueTasks.Enqueue("PrimaryActualRevenueCalcSumOnDeleteUserTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("ScriptDeleteDoNothing");
						break;
					case "PrimaryActualRevenueCalcSumOnDeleteUserTask":
						break;
					case "ScriptDeleteDoNothing":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool SequenceFlow6790ExpressionExecute() {
			return Convert.ToBoolean((CampaignId != null) || (CampaignOldValue != null));
		}

		private bool SequenceFlow6793ExpressionExecute() {
			return Convert.ToBoolean((CampaignOldValue != null));
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("OpportunitySaved");
			ActivatedEventElements.Add("OpportunitySaving");
			ActivatedEventElements.Add("OpportunityDeleting");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "OpportunitySaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpportunitySaved";
					result = OpportunitySaved.Execute(context);
					break;
				case "SynchronizeStageScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SynchronizeStageScript";
					result = SynchronizeStageScript.Execute(context, SynchronizeStageScriptExecute);
					break;
				case "ResetCompetitorsIsWinnerFalgScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ResetCompetitorsIsWinnerFalgScriptTask";
					result = ResetCompetitorsIsWinnerFalgScriptTask.Execute(context, ResetCompetitorsIsWinnerFalgScriptTaskExecute);
					break;
				case "ScriptPrimaryActualRevenueCalcSum":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPrimaryActualRevenueCalcSum";
					result = ScriptPrimaryActualRevenueCalcSum.Execute(context, ScriptPrimaryActualRevenueCalcSumExecute);
					break;
				case "PrimaryActualRevenueCalcSumUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrimaryActualRevenueCalcSumUserTask";
					result = PrimaryActualRevenueCalcSumUserTask.Execute(context);
					break;
				case "ScriptDoNothing":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDoNothing";
					result = ScriptDoNothing.Execute(context, ScriptDoNothingExecute);
					break;
				case "SynchronizeStage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SynchronizeStage";
					result = SynchronizeStage.Execute(context);
					break;
				case "UpdateRemindings":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateRemindings";
					result = UpdateRemindings.Execute(context, UpdateRemindingsExecute);
					break;
				case "SubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "OpportunitySaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpportunitySaving";
					result = OpportunitySaving.Execute(context);
					break;
				case "ScriptOpportunitySaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptOpportunitySaving";
					result = ScriptOpportunitySaving.Execute(context, ScriptOpportunitySavingExecute);
					break;
				case "SubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "OpportunityDeleting":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpportunityDeleting";
					result = OpportunityDeleting.Execute(context);
					break;
				case "ScriptOpportunityDeleting":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptOpportunityDeleting";
					result = ScriptOpportunityDeleting.Execute(context, ScriptOpportunityDeletingExecute);
					break;
				case "SubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
					break;
				case "PrimaryActualRevenueCalcSumOnDeleteUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrimaryActualRevenueCalcSumOnDeleteUserTask";
					result = PrimaryActualRevenueCalcSumOnDeleteUserTask.Execute(context);
					break;
				case "ScriptDeleteDoNothing":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDeleteDoNothing";
					result = ScriptDeleteDoNothing.Execute(context, ScriptDeleteDoNothingExecute);
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
				case "IsTacticChanged":
					IsTacticChanged = reader.GetValue<System.Boolean>();
				break;
				case "OldOwnerId":
					OldOwnerId = reader.GetValue<System.Guid>();
				break;
				case "IsNewStageEnd":
					IsNewStageEnd = reader.GetValue<System.Boolean>();
				break;
				case "CampaignOldValue":
					CampaignOldValue = reader.GetValue<System.Guid>();
				break;
				case "CampaignId":
					CampaignId = reader.GetValue<System.Guid>();
				break;
				case "IsOwnerChanged":
					IsOwnerChanged = reader.GetValue<System.Boolean>();
				break;
				case "NeedSynchronizeCompetitor":
					NeedSynchronizeCompetitor = reader.GetValue<System.Boolean>();
				break;
				case "IsStageChanged":
					IsStageChanged = reader.GetValue<System.Boolean>();
				break;
				case "StageOldValue":
					StageOldValue = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool SynchronizeStageScriptExecute(ProcessExecutingContext context) {
			if (CampaignOldValue.Equals(Guid.Empty) && IsTacticChanged) {
				var tacticHelper = Terrasoft.Core.Factories.ClassFactory.Get<Terrasoft.Configuration.OpportunityTacticsHelper>(
					new Terrasoft.Core.Factories.ConstructorArgument("userConnection", UserConnection));
				tacticHelper.UpdateOpportunityTacticHistory(Entity);
			}
			SynchronizeOpportunityStage();
			return true;
		}

		public virtual bool ResetCompetitorsIsWinnerFalgScriptTaskExecute(ProcessExecutingContext context) {
			if(IsStageChanged && Entity.GetTypedColumnValue<Guid>("StageId") == new Guid("60D5310C-5BE6-DF11-971B-001D60E938C6")) {
				var update = new Update(UserConnection, "OpportunityCompetitor")
					.Set("IsWinner", Column.Parameter(false))
					.Where("OpportunityId").IsEqual(Column.Parameter(Entity.PrimaryColumnValue))
					.And("IsWinner").IsEqual(Column.Parameter(true));
				update.Execute();
			}
			return true;
		}

		public virtual bool ScriptPrimaryActualRevenueCalcSumExecute(ProcessExecutingContext context) {
			Guid CampaignId = Guid.Empty;
			//CampaignId = Entity.GetTypedColumnValue<Guid>("CampaignId");
			if ((CampaignId != null) || (CampaignOldValue != null)) {
				CampaignId = (CampaignId != null) ? CampaignId : CampaignOldValue;
				PrimaryActualRevenueCalcSumUserTask.ParentSchemaUId = new Guid("a7dc714c-45a7-4971-9e1e-cfe64d5cd410");
				PrimaryActualRevenueCalcSumUserTask.ChildSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
				PrimaryActualRevenueCalcSumUserTask.ParentColumnResultUId = new Guid("eb2b9611-afa5-41f2-b8c8-88e09a258f30");
				PrimaryActualRevenueCalcSumUserTask.ParentColumnRelationUId = new Guid("c6d27fd7-1dd3-40f0-aba0-f32018ce59a7");
				PrimaryActualRevenueCalcSumUserTask.ChildColumnUId = new Guid("68fae92e-bdb4-4473-bf47-8edff49010ea");
				PrimaryActualRevenueCalcSumUserTask.ParentColumnRelationValue = new Guid(CampaignId.ToString());
			}
			return true;
		}

		public virtual bool ScriptDoNothingExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool UpdateRemindingsExecute(ProcessExecutingContext context) {
			ExecuteUpdateRemindings();
			return true;
		}

		public virtual bool ScriptOpportunitySavingExecute(ProcessExecutingContext context) {
			/*CampaignOldValue = Entity.GetTypedOldColumnValue<Guid>(Entity.Schema.Columns.GetByName("Campaign").ColumnValueName);
			if (CampaignOldValue.Equals(Guid.Empty)) {
				return true;
			}*/
			var columns = Entity.GetChangedColumnValues();
			InitCanGenerateAnniversaryReminding();
			string ownerColumnName = Entity.Schema.Columns.GetByName("Owner").ColumnValueName;
			IsOwnerChanged = columns.Any(c => c.Name == ownerColumnName);
			string stageColumnName = Entity.Schema.Columns.GetByName("Stage").ColumnValueName;
			bool isTacticChanged = columns.Any(c => c.Name == "Tactic");
			bool isCheckDateChanged = columns.Any(c => c.Name == "CheckDate");
			bool isStageColumnLoaded = Entity.IsColumnValueLoaded(stageColumnName);
			string dueDateColumnName = "DueDate";
			IsTacticChanged = isTacticChanged || isCheckDateChanged;
			OldOwnerId = Entity.GetTypedOldColumnValue<Guid>(ownerColumnName);
			StageOldValue = isStageColumnLoaded ? Entity.GetTypedOldColumnValue<Guid>(stageColumnName) : Guid.Empty;
			var stageId = isStageColumnLoaded ? Entity.GetTypedColumnValue<Guid>(stageColumnName) : Guid.Empty;
			var dueDate = Entity.IsColumnValueLoaded(dueDateColumnName) ?
				Entity.GetTypedColumnValue<DateTime>(dueDateColumnName) :
				new DateTime();
			IsStageChanged = StageOldValue != stageId;
			
			if (IsStageChanged) {
				IsNewStageEnd = false;
				var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
				var stageSchemaQuery = new EntitySchemaQuery(entitySchemaManager, "OpportunityStage");
				stageSchemaQuery.AddColumn("End");				
				var stageIdFilter = stageSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", stageId);
				stageSchemaQuery.Filters.Add(stageIdFilter);	
				var stages = stageSchemaQuery.GetEntityCollection(UserConnection);
				if (stages.Count > 0) {
					IsNewStageEnd = stages[0].GetTypedColumnValue<bool>("End");
				}
				if(IsNewStageEnd) {
					Entity.SetColumnValue("DueDate", UserConnection.CurrentUser.GetCurrentDateTime().Date);
				}
			}
			return true;
		}

		public virtual bool ScriptOpportunityDeletingExecute(ProcessExecutingContext context) {
			//CampaignOldValue = Entity.GetTypedOldColumnValue<Guid>(Entity.Schema.Columns.GetByName("Campaign").ColumnValueName);
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			if (CampaignOldValue != null) {
				PrimaryActualRevenueCalcSumOnDeleteUserTask.ParentSchemaUId = new Guid("a7dc714c-45a7-4971-9e1e-cfe64d5cd410");
				PrimaryActualRevenueCalcSumOnDeleteUserTask.ChildSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
				PrimaryActualRevenueCalcSumOnDeleteUserTask.ParentColumnResultUId = new Guid("eb2b9611-afa5-41f2-b8c8-88e09a258f30");
				PrimaryActualRevenueCalcSumOnDeleteUserTask.ParentColumnRelationUId = new Guid("c6d27fd7-1dd3-40f0-aba0-f32018ce59a7");
				PrimaryActualRevenueCalcSumOnDeleteUserTask.ChildColumnUId = new Guid("68fae92e-bdb4-4473-bf47-8edff49010ea");
				PrimaryActualRevenueCalcSumOnDeleteUserTask.ParentColumnRelationValue = new Guid(CampaignOldValue.ToString());
			}
			return true;
		}

		public virtual bool ScriptDeleteDoNothingExecute(ProcessExecutingContext context) {
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Opportunity_Opportunity_TerrasoftSaved":
							if (ActivatedEventElements.Contains("OpportunitySaved")) {
							context.QueueTasks.Enqueue("OpportunitySaved");
						}
						break;
					case "Opportunity_Opportunity_TerrasoftSaving":
							if (ActivatedEventElements.Contains("OpportunitySaving")) {
							context.QueueTasks.Enqueue("OpportunitySaving");
						}
						break;
					case "Opportunity_Opportunity_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("OpportunityDeleting")) {
							context.QueueTasks.Enqueue("OpportunityDeleting");
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
			if (!HasMapping("IsTacticChanged") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsTacticChanged", IsTacticChanged, false);
			}
			if (!HasMapping("OldOwnerId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("OldOwnerId", OldOwnerId, Guid.Empty);
			}
			if (!HasMapping("IsNewStageEnd") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNewStageEnd", IsNewStageEnd, false);
			}
			if (!HasMapping("CampaignOldValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CampaignOldValue", CampaignOldValue, Guid.Empty);
			}
			if (!HasMapping("CampaignId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CampaignId", CampaignId, Guid.Empty);
			}
			if (!HasMapping("IsOwnerChanged") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsOwnerChanged", IsOwnerChanged, false);
			}
			if (!HasMapping("NeedSynchronizeCompetitor") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NeedSynchronizeCompetitor", NeedSynchronizeCompetitor, false);
			}
			if (!HasMapping("IsStageChanged") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsStageChanged", IsStageChanged, false);
			}
			if (!HasMapping("StageOldValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("StageOldValue", StageOldValue, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: Opportunity_OpportunityEventsProcess

	/// <exclude/>
	public class Opportunity_OpportunityEventsProcess : Opportunity_OpportunityEventsProcess<Opportunity_Opportunity_Terrasoft>
	{

		public Opportunity_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Opportunity_OpportunityEventsProcess

	public partial class Opportunity_OpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual bool IsOpportunityInStageNotEmpty() {
			var entitySchemaColumnName = "Opportunity";
			var entitySchemaName = "OpportunityInStage";
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var entitySchema = entitySchemaManager.GetInstanceByName(entitySchemaName);
			var entitySchemaQueryFilterParameterName = "Opportunity";
			var entitySchemaQueryFilterParameterValue = Entity.PrimaryColumnValue;
			var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, entitySchemaName);
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(
				FilterComparisonType.Equal, entitySchemaQueryFilterParameterName, entitySchemaQueryFilterParameterValue));
			var entitySchemaColumn = entitySchemaQuery.AddColumn(entitySchemaColumnName);     
			var queryResult = entitySchemaQuery.GetEntityCollection(UserConnection);  
			return queryResult.Count > 0;
		}

		public virtual decimal CalculatePotential(Guid Probability, decimal Revenue) {
			 if (!Probability.Equals(Guid.Empty) && Revenue != 0) {
				var probabilityESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "OpportunityProbability");
				var valueColumn = probabilityESQ.AddColumn("Value");
				var probabilityEntity = probabilityESQ.GetEntity(UserConnection, Probability);
				return Revenue * probabilityEntity.GetTypedColumnValue<int>(valueColumn.Name) / 100;
			} else {
				return 0;
			}
		}

		public virtual void UpdateOpportunityTacticHistory() {
			var tactic = Entity.GetTypedColumnValue<string>("Tactic");
			var oldTactic = Entity.GetTypedOldColumnValue<string>("Tactic");
			var checkDateobj = Entity.GetColumnValue("CheckDate");
			var oldCheckDate = Entity.GetTypedOldColumnValue<DateTime>("CheckDate");
			if(checkDateobj != null) {
				var checkDate = Convert.ToDateTime(checkDateobj);
				if (tactic != oldTactic || checkDate != oldCheckDate || (CampaignOldValue == Guid.Empty && tactic != "")) {
					var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
					var opportunityTacticHist = entitySchemaManager.GetInstanceByName("OpportunityTacticHist").CreateEntity(UserConnection);
					opportunityTacticHist.SetDefColumnValues();
					opportunityTacticHist.SetColumnValue("Tactics", tactic);
					opportunityTacticHist.SetColumnValue("CheckDate", checkDate);
					opportunityTacticHist.SetColumnValue("ModifyDate", DateTime.Now);
					opportunityTacticHist.SetColumnValue("OpportunityId", Entity.GetTypedOldColumnValue<Guid>("Id"));
					opportunityTacticHist.Save();
				}
			} else {
				if (tactic != oldTactic || (CampaignOldValue == Guid.Empty && tactic != "")) {
					var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
					var opportunityTacticHist = entitySchemaManager.GetInstanceByName("OpportunityTacticHist").CreateEntity(UserConnection);
					opportunityTacticHist.SetDefColumnValues();
					opportunityTacticHist.SetColumnValue("Tactics", tactic);
					opportunityTacticHist.SetColumnValue("CheckDate", null);
					opportunityTacticHist.SetColumnValue("ModifyDate", DateTime.Now);
					opportunityTacticHist.SetColumnValue("OpportunityId", Entity.GetTypedOldColumnValue<Guid>("Id"));
					opportunityTacticHist.Save();
				}
			}
		}

		public virtual void SetOpportunityWinner() {
			var setOpportunityWinnerOperation = Terrasoft.Core.Factories.ClassFactory.Get<SetOpportunityWinnerOperation>(
				new Terrasoft.Core.Factories.ConstructorArgument("userConnection", UserConnection));
			setOpportunityWinnerOperation.DoOperation(Entity);
		}

		public virtual void SynchronizeOpportunityStage() {
			if (UserConnection.GetIsFeatureEnabled("DisableOldOpportunityStageSynchronizers")) {
				return;
			}
			if (UserConnection.GetIsFeatureEnabled("NewOpportunityStageManager")) {
				var opportunityStageRepository =
					Terrasoft.Core.Factories.ClassFactory.Get<Terrasoft.Configuration.OpportunityStageRepository>(
						new Terrasoft.Core.Factories.ConstructorArgument("userConnection", UserConnection));
				var opportunityInStageRepository =
					Terrasoft.Core.Factories.ClassFactory.Get<Terrasoft.Configuration.OpportunityInStageRepository>(
						new Terrasoft.Core.Factories.ConstructorArgument("userConnection", UserConnection));
				var opportunityStageManager =
					Terrasoft.Core.Factories.ClassFactory.Get<Terrasoft.Configuration.OpportunityStageManager>(
						new Terrasoft.Core.Factories.ConstructorArgument("userConnection", UserConnection),
						new Terrasoft.Core.Factories.ConstructorArgument("opportunityStageRepository", opportunityStageRepository),
						new Terrasoft.Core.Factories.ConstructorArgument("opportunityInStageRepository", opportunityInStageRepository));
				opportunityStageManager.SynchronizeStage(StageOldValue, OldOwnerId, Entity);
			} else {
				var oppInStageSchema = UserConnection.EntitySchemaManager.GetInstanceByName("OpportunityInStage");
				var stageHelper = Terrasoft.Core.Factories.ClassFactory.Get<Terrasoft.Configuration.OpportunityStageHelper>(
					new Terrasoft.Core.Factories.ConstructorArgument("userConnection", UserConnection),
					new Terrasoft.Core.Factories.ConstructorArgument("oppInStageSchema", oppInStageSchema));
				stageHelper.SynchronizeStage(StageOldValue, OldOwnerId, Entity);
			}
		}

		public virtual void InitCanGenerateAnniversaryReminding() {
			bool isNew = Entity.StoringState == StoringObjectState.New;
			var columns = GetAnniversaryDependentColumns();
			var changedColumns = Entity.GetChangedColumnValues();
			EntityChangedColumns = changedColumns.ToList();
			bool anniversaryColumnsChanged = changedColumns.Any(col => columns.Contains(col.Name));
			CanGenerateAnniversaryReminding = anniversaryColumnsChanged;
		}

		public virtual void ExecuteUpdateRemindings() {
			if (!CanGenerateAnniversaryReminding) {
				return;
			}
			Guid id = Entity.GetTypedColumnValue<Guid>("Id");
			OpportunityAnniversaryReminding remindingsGenerator = new OpportunityAnniversaryReminding(UserConnection, id);
			remindingsGenerator.Options = GetRemindingOptions();
			remindingsGenerator.GenerateActualRemindings();
		}

		public virtual IEnumerable<string> GetAnniversaryDependentColumns() {
			return new[] { "ContactId", "AccountId", "OwnerId" };
		}

		public virtual IEnumerable<string> GetRemindingOptions() {
			var options = new List<string>();
			var changedColumns = EntityChangedColumns as List<EntityColumnValue> ?? new List<EntityColumnValue>();
			if (changedColumns.Any(col => col.Name == "OwnerId")) {
				options.AddRange(new[] {
					OpportunityAnniversaryReminding.AccountOption,
					OpportunityAnniversaryReminding.ContactOption,
					OpportunityAnniversaryReminding.ParticipantOption
				});
				return options;
			}
			if (changedColumns.Any(col => col.Name == "ContactId")) {
				options.Add(OpportunityAnniversaryReminding.ContactOption);
			}
			if (changedColumns.Any(col => col.Name == "AccountId")) {
				options.Add(OpportunityAnniversaryReminding.AccountOption);
			}
			return options;
		}

		#endregion

	}

	#endregion

	#region Class: Opportunity_Opportunity_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Opportunity_Opportunity_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public Opportunity_Opportunity_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Opportunity_Opportunity_TerrasoftEventsProcessSchema(Opportunity_Opportunity_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Opportunity_OpportunityEventsProcess";
			UId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0");
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

		protected virtual ProcessSchemaParameter CreateStageOldValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9f6be553-7ee2-4aad-8ec2-aee1f793659e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"StageOldValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsStageChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8c71fd79-090a-4412-8019-8714724ba94c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"IsStageChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedSynchronizeCompetitorParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("becbceeb-604b-49e0-a78b-5ec88c985df4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"NeedSynchronizeCompetitor",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsOwnerChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3626acc4-16c3-48f4-97bd-4e57784b09cb"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"IsOwnerChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCampaignIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f3b38f50-aa04-42bc-bff7-29e3e0b824b8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"CampaignId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCampaignOldValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1daab7aa-097d-41f2-a97f-26393fffdef2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"CampaignOldValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsNewStageEndParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9a662638-0d92-46cf-9729-dd5e54296f95"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"IsNewStageEnd",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateOldOwnerIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("32bcd176-a341-43d5-9ac0-da61c16163d9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"OldOwnerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsTacticChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("eac0254a-47b7-4b77-b5f0-901837d8842e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"IsTacticChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCanGenerateAnniversaryRemindingParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("80272aa8-bbf7-4474-bab6-df88b19435fa"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"CanGenerateAnniversaryReminding",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityChangedColumnsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b05cf2b3-3ebd-454b-b06a-f265ac05b966"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"EntityChangedColumns",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateStageOldValueParameter());
			Parameters.Add(CreateIsStageChangedParameter());
			Parameters.Add(CreateNeedSynchronizeCompetitorParameter());
			Parameters.Add(CreateIsOwnerChangedParameter());
			Parameters.Add(CreateCampaignIdParameter());
			Parameters.Add(CreateCampaignOldValueParameter());
			Parameters.Add(CreateIsNewStageEndParameter());
			Parameters.Add(CreateOldOwnerIdParameter());
			Parameters.Add(CreateIsTacticChangedParameter());
			Parameters.Add(CreateCanGenerateAnniversaryRemindingParameter());
			Parameters.Add(CreateEntityChangedColumnsParameter());
		}

		protected virtual void InitializePrimaryActualRevenueCalcSumUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("f7a020a4-0611-4f40-9d9a-e5905f33ad85"),
				ContainerUId = new Guid("047e7598-b79a-46b1-8e57-8a057cfe8e5e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Name = @"ParentSchemaUId",
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
				UId = new Guid("9693b4f8-bccf-471e-9a10-873b77dba5e5"),
				ContainerUId = new Guid("047e7598-b79a-46b1-8e57-8a057cfe8e5e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Name = @"ChildSchemaUId",
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
				UId = new Guid("a47b5669-4406-4b04-8829-d9a095b00ca9"),
				ContainerUId = new Guid("047e7598-b79a-46b1-8e57-8a057cfe8e5e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Name = @"ParentColumnResultUId",
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
				UId = new Guid("c602ff64-b996-466c-ab2b-4591d6c1ccad"),
				ContainerUId = new Guid("047e7598-b79a-46b1-8e57-8a057cfe8e5e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Name = @"ParentColumnRelationUId",
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
				UId = new Guid("c0dc8067-67b2-4f19-bb6a-40a9506a1161"),
				ContainerUId = new Guid("047e7598-b79a-46b1-8e57-8a057cfe8e5e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Name = @"ChildColumnUId",
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
				UId = new Guid("c55e1081-0bff-4a2a-91db-141327d0fab0"),
				ContainerUId = new Guid("047e7598-b79a-46b1-8e57-8a057cfe8e5e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Name = @"ParentColumnRelationValue",
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
		}

		protected virtual void InitializeSynchronizeStageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("55049523-187d-433a-91fe-6532b4451e1b"),
				ContainerUId = new Guid("5363dbee-cfca-42db-a161-776e61c80ee8"),
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
				UId = new Guid("bc2cdf20-20e5-4e5d-86a2-a8dd6273510a"),
				ContainerUId = new Guid("5363dbee-cfca-42db-a161-776e61c80ee8"),
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
				UId = new Guid("06131996-bcac-4e7a-9189-68cd8965a5e6"),
				ContainerUId = new Guid("5363dbee-cfca-42db-a161-776e61c80ee8"),
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
				UId = new Guid("5b6620c3-fbe1-497a-8e4c-c5b5c81bf875"),
				ContainerUId = new Guid("5363dbee-cfca-42db-a161-776e61c80ee8"),
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
				UId = new Guid("36346852-33d9-475a-b583-5b7ceef54893"),
				ContainerUId = new Guid("5363dbee-cfca-42db-a161-776e61c80ee8"),
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
				UId = new Guid("20125033-e93d-4803-91ed-f039c3480fc9"),
				ContainerUId = new Guid("5363dbee-cfca-42db-a161-776e61c80ee8"),
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
				UId = new Guid("bffacc2a-e83c-4d53-afee-bbf02ac019ae"),
				ContainerUId = new Guid("5363dbee-cfca-42db-a161-776e61c80ee8"),
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
				UId = new Guid("2c616da3-d35b-4e46-a246-1741bc976ecd"),
				ContainerUId = new Guid("5363dbee-cfca-42db-a161-776e61c80ee8"),
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

		protected virtual void InitializePrimaryActualRevenueCalcSumOnDeleteUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("1433f661-ab34-4b4d-9c13-e44b8e5b2d3e"),
				ContainerUId = new Guid("5dfe5189-466f-49c2-b05b-c2a6f82981f2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Name = @"ParentSchemaUId",
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
				UId = new Guid("765a08d5-9327-49a8-8e02-0a49ca32cb8c"),
				ContainerUId = new Guid("5dfe5189-466f-49c2-b05b-c2a6f82981f2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Name = @"ChildSchemaUId",
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
				UId = new Guid("c0bdae9b-0405-47b4-9715-14f041cdb914"),
				ContainerUId = new Guid("5dfe5189-466f-49c2-b05b-c2a6f82981f2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Name = @"ParentColumnResultUId",
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
				UId = new Guid("ebce8f2a-4dc6-4cf1-aa1e-5cf86c38cd41"),
				ContainerUId = new Guid("5dfe5189-466f-49c2-b05b-c2a6f82981f2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Name = @"ParentColumnRelationUId",
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
				UId = new Guid("e4baeb35-d43b-4414-8ac8-6c6c82dedea0"),
				ContainerUId = new Guid("5dfe5189-466f-49c2-b05b-c2a6f82981f2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Name = @"ChildColumnUId",
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
				UId = new Guid("80421822-2cfe-455f-a606-7984e701b58a"),
				ContainerUId = new Guid("5dfe5189-466f-49c2-b05b-c2a6f82981f2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Name = @"ParentColumnRelationValue",
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
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet390 = CreateLaneSet390LaneSet();
			LaneSets.Add(schemaLaneSet390);
			ProcessSchemaLane schemaLane1188 = CreateLane1188Lane();
			schemaLaneSet390.Lanes.Add(schemaLane1188);
			ProcessSchemaEventSubProcess subprocess1 = CreateSubProcess1EventSubProcess();
			FlowElements.Add(subprocess1);
			ProcessSchemaEventSubProcess subprocess2 = CreateSubProcess2EventSubProcess();
			FlowElements.Add(subprocess2);
			ProcessSchemaEventSubProcess subprocess3 = CreateSubProcess3EventSubProcess();
			FlowElements.Add(subprocess3);
			ProcessSchemaEventSubProcess subprocess4 = CreateSubProcess4EventSubProcess();
			FlowElements.Add(subprocess4);
			ProcessSchemaStartMessageEvent opportunitysaved = CreateOpportunitySavedStartMessageEvent();
			subprocess1.FlowElements.Add(opportunitysaved);
			ProcessSchemaScriptTask synchronizestagescript = CreateSynchronizeStageScriptScriptTask();
			subprocess1.FlowElements.Add(synchronizestagescript);
			ProcessSchemaScriptTask resetcompetitorsiswinnerfalgscripttask = CreateResetCompetitorsIsWinnerFalgScriptTaskScriptTask();
			subprocess1.FlowElements.Add(resetcompetitorsiswinnerfalgscripttask);
			ProcessSchemaScriptTask scriptprimaryactualrevenuecalcsum = CreateScriptPrimaryActualRevenueCalcSumScriptTask();
			subprocess1.FlowElements.Add(scriptprimaryactualrevenuecalcsum);
			ProcessSchemaUserTask primaryactualrevenuecalcsumusertask = CreatePrimaryActualRevenueCalcSumUserTaskUserTask();
			subprocess1.FlowElements.Add(primaryactualrevenuecalcsumusertask);
			ProcessSchemaScriptTask scriptdonothing = CreateScriptDoNothingScriptTask();
			subprocess1.FlowElements.Add(scriptdonothing);
			ProcessSchemaUserTask synchronizestage = CreateSynchronizeStageUserTask();
			subprocess1.FlowElements.Add(synchronizestage);
			ProcessSchemaScriptTask updateremindings = CreateUpdateRemindingsScriptTask();
			subprocess1.FlowElements.Add(updateremindings);
			ProcessSchemaStartMessageEvent opportunitysaving = CreateOpportunitySavingStartMessageEvent();
			subprocess2.FlowElements.Add(opportunitysaving);
			ProcessSchemaScriptTask scriptopportunitysaving = CreateScriptOpportunitySavingScriptTask();
			subprocess2.FlowElements.Add(scriptopportunitysaving);
			ProcessSchemaStartMessageEvent opportunitydeleting = CreateOpportunityDeletingStartMessageEvent();
			subprocess3.FlowElements.Add(opportunitydeleting);
			ProcessSchemaScriptTask scriptopportunitydeleting = CreateScriptOpportunityDeletingScriptTask();
			subprocess3.FlowElements.Add(scriptopportunitydeleting);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			subprocess4.FlowElements.Add(scripttask2);
			ProcessSchemaUserTask primaryactualrevenuecalcsumondeleteusertask = CreatePrimaryActualRevenueCalcSumOnDeleteUserTaskUserTask();
			subprocess4.FlowElements.Add(primaryactualrevenuecalcsumondeleteusertask);
			ProcessSchemaScriptTask scriptdeletedonothing = CreateScriptDeleteDoNothingScriptTask();
			subprocess4.FlowElements.Add(scriptdeletedonothing);
			FlowElements.Add(CreateSequenceFlow6782SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6783SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6784SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6790ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow6791SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6792SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6793ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow6794SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6782SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6782",
				UId = new Guid("53d433b7-8766-4250-adac-aca80a1080b1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8af1be52-c288-43d8-afc4-a09b32ab1996"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8020eaaf-f57a-4bf3-9c97-2cb7d483e5aa"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6783SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6783",
				UId = new Guid("2813fd97-7f95-436b-816a-0cdc860a9be1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				CurveCenterPosition = new Point(157, 259),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6be2a148-5ab8-4792-947c-5594134ff4b3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a0e6fad5-70a6-47b0-9328-11505b526d6b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6784SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6784",
				UId = new Guid("ccd5c063-e801-405c-ab76-c84c8bb2bd06"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				CurveCenterPosition = new Point(232, 137),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8020eaaf-f57a-4bf3-9c97-2cb7d483e5aa"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8d0ca9d5-2876-404e-bddd-57cfcf8f47ab"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateSequenceFlow6790ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "SequenceFlow6790",
				UId = new Guid("171018ec-9329-4062-bdad-99f499b5bcb7"),
				ConditionExpression = @"(CampaignId != null) || (CampaignOldValue != null)",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				CurveCenterPosition = new Point(300, 455),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8075f06c-e302-49cd-b9c2-3548a040da09"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("047e7598-b79a-46b1-8e57-8a057cfe8e5e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6791SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow6791",
				UId = new Guid("af5d9e6b-737b-46b0-a15d-a4f74649bd3f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				CurveCenterPosition = new Point(232, 512),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8075f06c-e302-49cd-b9c2-3548a040da09"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d4e66c47-cd0c-4e92-9a59-1b705d7e3334"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(203, 420));
			schemaFlow.PolylinePointPositions.Add(new Point(205, 420));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6792SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6792",
				UId = new Guid("46ccc272-3e25-4beb-b6f4-6596211f653f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				CurveCenterPosition = new Point(412, 674),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3a094e2c-1580-4f53-a8e8-155cac0202f5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("27e3276c-fd8a-4ec2-858d-68c734734a22"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateSequenceFlow6793ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "SequenceFlow6793",
				UId = new Guid("efb73336-27e0-48e3-bf29-9fb9843aab75"),
				ConditionExpression = @"(CampaignOldValue != null)",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				CurveCenterPosition = new Point(268, 849),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("48265622-0d8c-4a5f-9246-eb16a24a6a7d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5dfe5189-466f-49c2-b05b-c2a6f82981f2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6794SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow6794",
				UId = new Guid("07c8cff0-44bd-44bf-b544-cb010baa7b2b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				CurveCenterPosition = new Point(190, 912),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("48265622-0d8c-4a5f-9246-eb16a24a6a7d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d314254b-f9a9-42a9-9d05-c0de08ed91e5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("085120d7-30e3-45f9-85ea-f050e2905944"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e5329beb-3e10-4a27-8bfb-870941c1260e"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				CurveCenterPosition = new Point(158, 220),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8af1be52-c288-43d8-afc4-a09b32ab1996"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("56796de1-8d42-460e-b1cc-30f198063445"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(71, 272));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet390LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet390 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("5e3e24ad-f409-4031-81b1-17eb320c9e05"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"LaneSet390",
				Position = new Point(5, 5),
				Size = new Size(787, 1012),
				UseBackgroundMode = false
			};
			return schemaLaneSet390;
		}

		protected virtual ProcessSchemaLane CreateLane1188Lane() {
			ProcessSchemaLane schemaLane1188 = new ProcessSchemaLane(this) {
				UId = new Guid("c6f0530e-7fc0-4653-a32c-273708781290"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("5e3e24ad-f409-4031-81b1-17eb320c9e05"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"Lane1188",
				Position = new Point(29, 0),
				Size = new Size(758, 1012),
				UseBackgroundMode = false
			};
			return schemaLane1188;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("67267353-ee30-460a-a08f-7f503cdef2ca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c6f0530e-7fc0-4653-a32c-273708781290"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"SubProcess1",
				Position = new Point(29, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(624, 482),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOpportunitySavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8af1be52-c288-43d8-afc4-a09b32ab1996"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("67267353-ee30-460a-a08f-7f503cdef2ca"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OpportunitySaved",
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"OpportunitySaved",
				Position = new Point(29, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSynchronizeStageScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8020eaaf-f57a-4bf3-9c97-2cb7d483e5aa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("67267353-ee30-460a-a08f-7f503cdef2ca"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"SynchronizeStageScript",
				Position = new Point(134, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,79,203,106,195,48,16,60,39,144,127,16,57,4,25,138,126,32,109,161,24,231,113,202,33,73,239,139,189,86,4,246,74,93,173,82,220,210,127,175,92,95,92,10,61,206,236,188,214,181,74,151,208,7,112,150,78,93,243,10,93,66,83,189,37,232,162,222,39,215,152,170,15,50,20,106,179,81,199,120,129,90,92,93,222,128,44,54,133,250,92,45,23,119,96,37,63,244,1,187,128,172,158,212,5,153,33,250,86,76,233,25,205,46,95,61,59,140,166,236,32,198,9,14,102,143,242,56,87,82,235,108,98,16,231,201,156,66,240,44,137,156,12,83,101,156,194,159,117,110,92,16,190,255,211,225,41,10,167,17,190,176,77,61,146,232,117,138,200,249,64,88,143,241,235,7,117,253,69,20,197,54,231,206,191,48,215,208,128,224,159,29,7,23,199,241,186,34,201,220,104,251,90,45,207,3,213,55,246,228,62,230,134,179,128,69,61,74,24,37,49,169,188,10,183,223,74,65,193,148,111,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateResetCompetitorsIsWinnerFalgScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8d0ca9d5-2876-404e-bddd-57cfcf8f47ab"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("67267353-ee30-460a-a08f-7f503cdef2ca"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"ResetCompetitorsIsWinnerFalgScriptTask",
				Position = new Point(134, 135),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,65,107,194,64,16,133,207,10,254,135,101,15,178,1,19,18,196,180,98,45,212,77,42,57,85,176,214,243,226,142,186,144,236,166,147,221,182,82,250,223,187,49,30,2,133,30,103,120,239,155,247,70,29,89,209,108,173,56,1,63,11,125,2,73,198,99,146,107,171,236,37,90,131,125,189,212,32,185,41,93,165,223,68,233,224,97,237,148,124,100,244,234,40,36,13,200,114,73,52,124,146,118,207,104,26,103,179,105,18,243,112,182,202,211,48,123,78,146,112,126,151,172,194,56,78,178,52,206,231,211,123,158,210,32,32,223,163,225,224,67,32,113,181,20,22,72,135,216,93,7,182,107,0,185,209,26,14,86,25,61,33,244,165,174,13,90,167,125,36,110,170,26,124,54,131,52,240,136,65,180,5,203,104,209,236,149,215,35,157,144,46,106,180,17,40,42,176,128,236,40,202,6,130,78,188,63,3,2,235,243,218,6,81,209,228,239,78,148,236,143,247,246,134,13,170,74,224,165,247,133,27,239,73,203,222,241,127,64,22,91,207,194,155,186,194,81,254,5,7,231,187,182,187,159,209,16,193,58,212,164,149,45,126,1,172,65,236,136,145,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPrimaryActualRevenueCalcSumScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8075f06c-e302-49cd-b9c2-3548a040da09"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("67267353-ee30-460a-a08f-7f503cdef2ca"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"ScriptPrimaryActualRevenueCalcSum",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(140, 315),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,210,81,79,219,48,16,0,224,103,42,245,63,120,125,74,31,92,236,196,137,237,13,54,77,21,170,120,26,162,101,239,23,251,12,17,142,91,165,246,166,106,240,223,9,173,4,109,53,36,16,175,62,223,125,190,243,205,82,99,201,20,218,21,52,183,225,210,146,115,50,235,79,38,23,237,42,110,190,13,7,167,167,7,177,139,16,155,184,153,204,48,46,54,43,180,211,165,79,109,248,13,62,225,217,115,218,247,108,244,122,125,52,238,243,27,71,178,108,175,196,151,115,18,146,247,99,242,240,64,94,206,127,121,187,173,241,18,29,147,127,195,193,201,129,252,223,34,63,246,95,254,149,28,215,235,253,147,171,174,105,161,219,252,52,49,129,191,198,63,24,18,78,193,155,121,106,111,214,216,45,96,125,63,185,130,14,67,156,155,59,108,225,102,171,5,252,187,157,67,54,2,105,141,228,194,80,81,130,164,66,75,78,53,114,164,198,97,37,108,105,172,224,108,219,233,187,164,233,93,227,237,27,16,138,202,213,74,82,195,242,94,3,84,20,108,193,41,232,188,48,214,106,45,140,123,63,180,107,105,247,63,215,184,78,62,30,123,88,231,181,174,120,15,56,40,169,224,46,167,181,50,138,42,133,76,67,94,42,87,124,160,177,67,207,67,108,150,225,88,52,149,205,165,179,146,114,107,11,42,152,99,20,106,96,212,21,57,227,202,96,169,65,126,112,148,59,240,24,170,148,3,212,57,210,218,214,130,10,33,11,90,59,33,169,66,235,156,208,140,51,132,207,181,182,91,215,61,243,117,15,39,139,229,60,118,77,184,205,198,207,196,227,112,208,97,76,93,32,177,235,55,242,9,84,176,252,98,111,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreatePrimaryActualRevenueCalcSumUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("047e7598-b79a-46b1-8e57-8a057cfe8e5e"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("67267353-ee30-460a-a08f-7f503cdef2ca"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"PrimaryActualRevenueCalcSumUserTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(273, 315),
				SchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializePrimaryActualRevenueCalcSumUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDoNothingScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d4e66c47-cd0c-4e92-9a59-1b705d7e3334"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("67267353-ee30-460a-a08f-7f503cdef2ca"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"ScriptDoNothing",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(142, 407),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateSynchronizeStageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("5363dbee-cfca-42db-a161-776e61c80ee8"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("67267353-ee30-460a-a08f-7f503cdef2ca"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"SynchronizeStage",
				Position = new Point(308, 35),
				SchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeSynchronizeStageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateRemindingsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("56796de1-8d42-460e-b1cc-30f198063445"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("67267353-ee30-460a-a08f-7f503cdef2ca"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e5329beb-3e10-4a27-8bfb-870941c1260e"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"UpdateRemindings",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(140, 225),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,173,72,77,46,45,73,13,45,72,73,44,73,13,74,205,205,204,75,201,204,75,47,214,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,204,143,128,196,40,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2b072ee0-6c70-4a3b-b0b0-1752cbe3259a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c6f0530e-7fc0-4653-a32c-273708781290"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"SubProcess2",
				Position = new Point(35, 506),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(246, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOpportunitySavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6be2a148-5ab8-4792-947c-5594134ff4b3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2b072ee0-6c70-4a3b-b0b0-1752cbe3259a"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OpportunitySaving",
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"OpportunitySaving",
				Position = new Point(20, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptOpportunitySavingScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a0e6fad5-70a6-47b0-9328-11505b526d6b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2b072ee0-6c70-4a3b-b0b0-1752cbe3259a"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"ScriptOpportunitySaving",
				Position = new Point(133, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,85,81,111,211,48,16,126,110,165,254,7,147,39,103,170,178,61,111,180,83,201,74,21,9,86,160,5,30,16,15,38,246,90,139,196,41,182,179,42,98,251,239,156,237,164,117,210,48,21,170,62,36,190,251,190,251,238,206,119,185,188,136,73,190,35,124,35,150,25,253,66,178,146,161,9,154,11,205,117,21,45,152,94,87,59,70,193,18,23,89,153,11,107,127,189,40,57,157,226,218,103,149,110,89,78,34,103,87,6,242,166,186,39,57,195,65,195,27,132,145,135,54,182,240,102,52,228,15,8,119,35,71,243,95,37,201,20,54,1,162,121,190,211,85,24,162,223,163,225,64,50,93,74,129,180,44,25,64,159,47,46,71,195,71,34,81,234,130,182,4,199,91,34,54,204,215,171,176,137,151,8,174,99,34,22,76,48,73,52,155,9,193,31,153,84,68,86,159,88,206,5,229,98,99,253,148,150,240,136,138,61,248,57,18,163,248,24,226,239,249,46,13,228,52,89,19,91,89,91,45,13,184,106,225,209,76,84,56,69,147,41,74,35,23,101,210,13,236,73,82,154,108,216,191,73,90,25,72,175,164,31,69,145,33,174,214,36,213,60,61,75,88,224,124,131,240,136,142,183,44,253,121,7,213,60,143,224,224,238,115,172,142,89,189,43,8,181,36,117,94,137,242,116,59,35,238,20,193,43,15,45,153,149,226,23,40,184,115,135,129,109,66,55,217,110,250,79,79,61,57,1,18,174,167,237,95,66,207,28,141,158,30,218,52,189,9,235,75,252,246,44,242,110,5,208,53,58,206,203,141,27,12,235,147,208,115,227,252,95,144,186,224,47,247,235,164,43,33,186,133,129,126,65,128,113,95,243,156,77,251,176,215,128,21,108,143,26,39,55,218,117,142,135,198,182,139,253,106,210,212,3,124,221,226,105,35,220,142,73,212,61,219,219,227,185,48,36,15,176,137,204,164,12,76,174,204,234,117,131,246,158,8,112,146,224,242,89,153,54,11,193,224,22,21,194,100,211,242,192,193,252,20,22,132,136,40,212,99,104,66,89,173,206,242,177,100,178,130,56,38,99,31,97,207,113,143,166,49,10,150,187,93,33,117,41,140,201,77,191,33,238,146,70,51,90,23,221,136,164,224,52,128,159,175,32,161,111,121,166,109,154,39,224,88,50,168,191,179,127,229,122,251,129,72,232,14,188,40,236,14,227,2,22,187,228,170,16,166,189,110,173,131,182,132,6,227,134,189,95,150,131,43,35,15,183,100,128,64,95,157,234,147,5,245,119,85,130,204,50,215,19,220,110,145,13,106,46,128,35,129,189,88,10,141,166,232,202,93,129,147,59,224,220,190,93,125,239,189,169,102,131,77,155,250,1,252,217,146,227,22,73,77,220,108,106,248,62,29,9,240,97,61,141,187,87,41,46,165,132,254,154,83,251,81,115,175,199,91,31,153,199,38,40,252,253,15,228,31,136,26,92,122,210,7,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("42fb7d8c-e942-4855-9233-9dd870db06cb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c6f0530e-7fc0-4653-a32c-273708781290"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"SubProcess3",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(296, 506),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(224, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOpportunityDeletingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3a094e2c-1580-4f53-a8e8-155cac0202f5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("42fb7d8c-e942-4855-9233-9dd870db06cb"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OpportunityDeleting",
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"OpportunityDeleting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(22, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptOpportunityDeletingScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("27e3276c-fd8a-4ec2-858d-68c734734a22"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("42fb7d8c-e942-4855-9233-9dd870db06cb"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"ScriptOpportunityDeleting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(113, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,215,119,78,204,45,72,204,76,207,243,207,73,9,75,204,41,77,85,176,85,112,205,43,201,44,169,212,115,79,45,9,169,44,72,77,1,202,56,231,231,148,230,230,129,229,109,220,75,51,83,236,52,160,106,130,147,51,82,115,19,245,32,242,197,32,45,78,149,126,137,185,169,26,74,48,115,149,52,245,144,116,131,228,52,173,121,185,138,82,75,74,139,242,20,74,138,74,83,173,1,104,123,1,7,132,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("049ceae7-6039-4901-80af-77656912f566"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c6f0530e-7fc0-4653-a32c-273708781290"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"SubProcess4",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(38, 665),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(371, 235),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess4;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("48265622-0d8c-4a5f-9246-eb16a24a6a7d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("049ceae7-6039-4901-80af-77656912f566"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"ScriptTask2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(85, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,210,193,75,195,48,20,199,241,179,251,43,234,78,219,225,141,164,77,155,132,225,65,42,136,167,141,205,121,127,73,94,182,98,154,73,215,40,34,254,239,22,118,209,130,135,137,255,192,251,240,125,252,26,159,205,106,108,95,176,217,199,85,112,79,24,18,101,215,55,89,76,33,204,179,143,201,213,186,107,90,236,222,111,109,159,48,108,232,149,98,162,26,131,221,166,118,21,239,40,80,79,187,19,117,143,120,122,94,172,177,163,216,111,237,129,90,220,61,184,108,56,67,111,217,125,106,220,108,138,210,89,201,133,5,81,162,4,161,37,7,77,156,192,122,170,132,43,173,19,156,77,231,203,203,192,250,208,4,247,139,71,162,242,70,73,176,44,31,80,36,5,232,10,14,168,243,194,58,167,181,176,254,98,239,28,88,31,67,106,227,134,78,41,244,99,150,76,110,116,197,7,199,99,9,130,251,28,140,178,10,148,34,166,49,47,149,47,46,207,252,201,6,236,155,99,28,195,182,114,185,244,78,2,119,174,0,193,60,3,52,200,192,23,57,227,202,82,169,81,254,237,191,103,119,236,85,202,35,233,156,192,56,35,64,8,89,128,241,66,130,34,231,189,208,140,51,194,127,9,61,79,242,27,61,158,235,226,241,184,237,187,38,238,103,243,193,251,156,116,212,167,46,102,125,151,104,249,5,107,18,250,3,223,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreatePrimaryActualRevenueCalcSumOnDeleteUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("5dfe5189-466f-49c2-b05b-c2a6f82981f2"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("049ceae7-6039-4901-80af-77656912f566"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"PrimaryActualRevenueCalcSumOnDeleteUserTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(211, 51),
				SchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializePrimaryActualRevenueCalcSumOnDeleteUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDeleteDoNothingScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d314254b-f9a9-42a9-9d05-c0de08ed91e5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("049ceae7-6039-4901-80af-77656912f566"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Name = @"ScriptDeleteDoNothing",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(85, 149),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateIsOpportunityInStageNotEmptyMethod());
			Methods.Add(CreateCalculatePotentialMethod());
			Methods.Add(CreateUpdateOpportunityTacticHistoryMethod());
			Methods.Add(CreateSetOpportunityWinnerMethod());
			Methods.Add(CreateSynchronizeOpportunityStageMethod());
			Methods.Add(CreateInitCanGenerateAnniversaryRemindingMethod());
			Methods.Add(CreateExecuteUpdateRemindingsMethod());
			Methods.Add(CreateGetAnniversaryDependentColumnsMethod());
			Methods.Add(CreateGetRemindingOptionsMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("99588ad2-b9c4-4ecd-87bc-9534b4a7be0d"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4648de12-5440-4895-9fdc-5e9b6f34f7e2"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c5a3eefb-8711-4da4-b899-2b19ce17d943"),
				Name = "System.Data",
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
				Name = "System.Linq",
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

		protected virtual SchemaMethod CreateIsOpportunityInStageNotEmptyMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2dbb2f96-e278-4583-ac5d-acce31a9468d"),
				Name = "IsOpportunityInStageNotEmpty",
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,77,75,196,48,16,61,219,95,17,246,148,194,18,188,23,5,45,85,246,160,174,174,31,231,176,59,236,6,210,73,119,50,89,233,191,55,109,64,180,141,184,57,133,188,15,230,189,204,73,147,0,100,195,253,102,123,128,86,215,206,134,22,31,117,11,226,74,44,158,186,206,17,7,140,240,162,42,78,19,110,134,181,194,13,235,61,100,200,15,26,35,64,145,255,230,129,106,135,8,91,54,14,85,51,39,205,213,81,150,49,83,247,192,43,244,172,113,11,183,253,48,142,156,206,87,206,189,158,3,80,127,103,44,3,173,53,69,78,188,156,23,56,167,124,215,54,12,210,20,67,173,201,180,154,250,84,227,136,253,97,19,37,8,159,162,153,190,203,76,206,229,172,246,24,107,230,168,210,100,94,221,236,118,114,142,214,4,154,33,113,62,12,31,190,19,120,89,92,164,231,218,181,157,38,227,29,190,246,29,168,230,24,180,93,158,213,221,255,172,177,139,50,243,29,169,170,201,7,167,145,99,144,132,202,252,138,150,149,24,206,104,121,28,20,47,224,131,229,172,87,92,149,212,117,148,219,180,122,242,247,38,14,110,5,1,7,194,159,110,170,118,1,89,92,139,203,234,11,57,186,23,33,45,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCalculatePotentialMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("872ab380-5c79-4998-ae9b-8c96c9e28440"),
				Name = "CalculatePotential",
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "decimal"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ca43e9f7-a214-4ef7-a9d4-d55d69652280"),
				Name = "Probability",
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c7c99206-b310-4bab-9efd-fd67f94e79bf"),
				Name = "Revenue",
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				ModifiedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "decimal",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,207,79,194,48,20,199,207,242,87,60,118,32,29,33,117,158,17,18,66,22,78,42,136,122,47,236,1,77,186,215,218,181,51,11,225,127,119,101,4,170,28,219,239,175,79,30,200,29,176,254,210,234,141,216,72,37,93,195,243,111,47,84,197,22,94,22,60,47,141,107,82,24,12,224,29,107,36,143,208,159,64,150,194,177,247,80,11,11,230,22,203,215,43,152,0,225,15,228,228,218,247,122,123,192,82,172,60,218,134,125,86,104,231,154,8,183,78,106,226,177,225,69,144,216,163,29,65,242,102,140,182,206,83,43,69,52,73,58,238,166,106,161,60,206,181,242,37,181,59,127,135,249,172,40,58,137,37,95,193,119,77,197,190,243,234,125,118,129,174,147,254,97,142,32,194,8,125,22,157,183,116,61,196,240,190,60,116,125,52,6,47,48,103,148,103,73,110,202,34,122,254,42,74,76,225,17,158,178,108,220,59,1,170,10,195,61,47,245,225,239,23,216,19,52,97,148,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateOpportunityTacticHistoryMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6c18ebbb-bac6-4316-8240-782ab31e4f85"),
				Name = "UpdateOpportunityTacticHistory",
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,77,79,131,48,24,62,143,132,255,80,123,48,37,89,248,3,147,29,100,203,220,97,219,97,232,189,194,203,172,66,75,104,193,16,183,255,110,129,33,160,184,185,163,198,43,239,251,124,244,233,83,114,154,34,69,125,197,124,228,160,57,87,76,21,246,2,148,87,36,16,184,34,202,98,254,64,163,12,110,164,74,25,223,77,9,246,170,101,108,77,76,35,215,88,17,5,222,55,240,77,244,35,6,255,9,252,151,25,85,32,30,159,123,36,29,48,193,110,179,213,85,254,248,120,86,188,92,242,88,12,211,207,76,44,36,61,3,87,14,226,89,20,89,232,205,52,70,61,123,90,195,21,60,135,84,217,158,104,248,122,224,146,111,196,66,68,142,129,106,174,54,158,253,190,67,85,79,90,251,122,72,92,26,39,148,237,184,118,94,121,70,142,131,22,25,11,236,121,156,168,2,93,95,163,150,22,99,171,118,88,89,132,234,232,91,77,31,211,21,229,116,7,169,54,123,47,33,213,134,57,104,144,224,101,48,189,13,130,231,95,97,216,66,84,162,129,193,164,209,18,73,34,82,149,113,189,80,31,236,142,73,165,213,6,60,148,146,75,46,21,229,62,220,22,107,170,211,194,155,33,56,182,108,55,5,157,67,45,76,250,206,171,84,71,131,186,246,22,212,12,194,206,69,75,114,102,189,87,170,122,36,241,248,24,237,37,216,182,70,227,246,98,47,33,88,137,128,133,197,145,161,233,147,189,22,175,151,144,116,242,92,6,154,231,244,43,40,235,164,95,128,222,180,78,138,208,28,234,28,15,166,113,64,16,73,168,202,118,162,218,255,237,253,189,237,173,254,119,127,176,184,166,241,14,146,222,34,175,221,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetOpportunityWinnerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b7d29fe1-97fd-487e-9976-14c63243035b"),
				Name = "SetOpportunityWinner",
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				CreatedInPackageId = new Guid("de2b3e7f-7fd4-4205-83d9-d3278f5d6ce6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,142,203,10,194,48,16,69,215,246,43,66,87,9,72,126,160,42,72,125,44,187,168,226,58,148,81,2,58,19,102,38,150,254,189,45,130,224,38,187,251,226,112,223,129,141,128,118,41,17,107,198,168,211,45,34,2,119,9,56,104,36,52,91,115,1,230,32,116,87,223,18,131,63,133,65,137,35,136,111,159,65,228,107,39,127,6,221,244,37,210,206,86,43,132,177,128,35,20,229,188,216,61,63,242,11,80,109,157,5,120,46,16,134,133,81,175,205,245,47,112,174,169,138,255,253,129,126,218,30,81,231,133,107,62,164,6,23,182,246,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeOpportunityStageMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("78edcbbd-cf66-4231-89f4-75f559f601d8"),
				Name = "SynchronizeOpportunityStage",
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,84,77,79,195,48,12,61,175,210,254,67,212,83,43,85,253,3,99,72,48,54,216,129,77,98,192,61,116,222,22,169,115,42,39,101,42,104,255,157,100,25,208,15,21,161,138,114,137,146,216,241,179,253,94,44,54,44,120,82,64,19,137,8,137,22,18,227,91,208,115,53,3,174,115,130,41,242,151,20,214,129,127,35,148,221,45,211,245,50,203,36,233,28,133,46,86,154,111,97,85,96,178,35,137,226,13,72,249,97,200,222,135,222,128,192,188,198,209,208,59,14,61,241,75,136,5,28,234,177,239,57,154,149,62,163,190,114,98,178,230,242,0,153,84,66,75,42,216,216,184,12,30,129,136,43,185,209,241,68,18,196,51,158,24,155,0,21,79,82,174,148,59,22,54,129,139,178,39,110,196,54,39,126,74,174,158,196,55,194,101,96,17,6,8,7,214,14,35,81,105,202,237,241,138,182,249,30,80,7,126,94,41,223,143,88,181,31,97,56,106,86,55,199,254,235,107,96,252,107,133,101,138,251,34,239,28,190,183,186,162,142,113,219,101,108,48,218,141,127,129,215,32,189,138,216,48,59,238,90,120,139,75,223,255,116,31,156,86,51,39,158,121,154,67,196,236,196,56,32,208,124,29,177,41,106,243,220,134,59,50,72,21,148,63,245,25,118,149,236,96,207,217,184,214,231,216,61,117,214,79,104,59,69,76,169,28,19,184,46,22,124,15,129,223,212,182,255,165,60,101,143,119,144,102,86,109,63,180,175,171,212,92,104,167,180,158,132,214,137,247,74,103,29,215,149,43,199,111,169,59,93,57,29,122,31,42,86,52,15,78,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitCanGenerateAnniversaryRemindingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2a06829c-9953-41e0-bd85-11967b263335"),
				Name = "InitCanGenerateAnniversaryReminding",
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,193,10,194,48,12,134,239,130,239,208,163,94,250,2,82,65,170,120,17,5,39,222,179,45,104,101,75,165,203,148,189,189,113,235,116,42,30,147,252,223,159,252,73,189,47,148,171,182,120,87,70,173,136,29,55,58,97,31,28,157,18,6,70,101,140,138,245,46,189,96,198,109,87,139,126,54,30,221,32,168,204,23,117,73,149,208,107,228,5,145,187,97,168,32,52,75,188,34,229,72,108,59,193,100,218,3,103,160,19,230,246,197,197,173,130,219,225,232,8,69,141,29,214,41,236,55,248,233,164,15,126,227,42,110,129,244,153,10,222,199,68,73,116,248,69,23,212,76,36,136,50,243,62,143,182,158,24,156,220,45,13,189,133,18,167,79,99,11,180,70,194,32,63,24,100,221,99,233,40,151,23,137,243,223,173,179,7,215,11,55,98,107,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateExecuteUpdateRemindingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("be373a86-5981-4c57-ad70-87d037a93b79"),
				Name = "ExecuteUpdateRemindings",
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,65,10,194,48,16,69,215,230,20,177,171,8,210,11,84,5,41,82,92,21,68,221,135,102,148,64,59,9,147,137,82,196,187,155,66,237,170,34,100,49,132,255,222,124,198,222,164,90,150,26,43,64,32,205,176,71,180,15,160,160,169,63,65,103,209,88,188,175,228,75,44,8,56,18,22,226,45,170,104,141,76,111,43,15,200,150,251,188,2,62,247,30,76,233,218,216,225,85,183,17,54,67,104,167,178,163,201,86,133,168,189,119,196,17,83,120,206,47,233,59,133,177,134,163,100,71,120,202,63,164,186,4,160,210,33,66,195,214,225,58,213,74,235,102,116,121,237,135,64,72,218,212,118,226,199,95,245,3,154,142,210,112,212,237,68,13,249,15,66,254,84,204,56,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetAnniversaryDependentColumnsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ae10ce38-1e77-47b8-8cda-490320dfae3a"),
				Name = "GetAnniversaryDependentColumns",
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13"),
				ResultValueTypeName = "IEnumerable<string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,143,142,85,168,86,80,114,206,207,43,73,76,46,241,76,81,210,81,80,114,76,78,206,47,205,131,114,252,203,243,82,139,128,76,133,90,107,0,34,162,128,38,53,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRemindingOptionsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3eab26da-8899-4325-82de-1edfa7924d97"),
				Name = "GetRemindingOptions",
				CreatedInSchemaUId = new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"),
				CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13"),
				ResultValueTypeName = "IEnumerable<string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,145,193,106,195,48,12,134,207,41,244,29,68,79,14,140,188,192,150,148,16,118,24,148,102,244,176,203,216,193,216,94,103,72,228,96,203,41,97,244,221,231,122,46,35,219,14,203,78,6,73,191,62,253,191,71,110,193,12,164,13,58,40,1,213,9,118,218,209,157,35,171,241,88,177,252,118,189,26,195,136,120,227,120,84,178,49,157,239,227,228,61,146,166,169,153,151,185,251,84,167,102,172,62,241,206,171,10,182,219,175,229,63,219,145,163,95,129,205,57,69,141,19,19,166,131,178,130,240,20,123,222,43,40,75,216,180,39,84,246,65,110,242,28,222,215,171,44,25,40,106,41,15,23,61,11,168,231,151,216,202,218,97,48,150,60,6,98,141,168,71,101,29,183,211,65,245,26,101,176,88,212,66,24,143,212,198,21,55,127,81,52,6,137,139,37,138,71,110,73,11,61,240,43,39,136,206,23,203,153,85,228,45,94,127,32,84,206,139,114,72,167,252,154,4,91,228,35,95,204,78,193,253,143,61,75,61,177,191,101,241,1,138,23,100,96,154,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Opportunity_Opportunity_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("64a772c0-4b1e-451b-864f-1a396a6234e0"));
		}

		#endregion

	}

	#endregion

}

