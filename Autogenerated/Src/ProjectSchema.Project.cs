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

	#region Class: Project_Project_TerrasoftSchema

	/// <exclude/>
	public class Project_Project_TerrasoftSchema : Terrasoft.Configuration.BaseEntityNotesSchema
	{

		#region Constructors: Public

		public Project_Project_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Project_Project_TerrasoftSchema(Project_Project_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Project_Project_TerrasoftSchema(Project_Project_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be");
			RealUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be");
			Name = "Project_Project_Terrasoft";
			ParentSchemaUId = new Guid("a22b1e79-7fc1-4fe5-aba0-538e9df96f17");
			ExtendParent = false;
			CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
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

		protected override void InitializePrimaryOrderColumn() {
			base.InitializePrimaryOrderColumn();
			PrimaryOrderColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryOrderColumn.UId) == null) {
				Columns.Add(PrimaryOrderColumn);
			}
		}

		protected override void InitializeHierarchyColumn() {
			base.InitializeHierarchyColumn();
			HierarchyColumn = CreateParentProjectColumn();
			if (Columns.FindByUId(HierarchyColumn.UId) == null) {
				Columns.Add(HierarchyColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("62a1bf12-279e-48d8-8a28-041be01c5003")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("1b4c54b0-33fc-4aeb-9f48-acddb453fe5b")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("41e82ce8-a31c-48a0-b6a5-b90660c83759")) == null) {
				Columns.Add(CreateProjectEntryTypeColumn());
			}
			if (Columns.FindByUId(new Guid("e0d39946-16ca-4649-b6fb-1be29312f709")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("532d4f22-8b39-4860-8e62-60b678c9193a")) == null) {
				Columns.Add(CreateOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("e1829b39-9b37-4a34-9e33-18fc056fdcbd")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("8f11337c-f8fe-4e3c-9576-b26554359fd7")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("470aee83-6564-4676-b0c7-44e8374664d5")) == null) {
				Columns.Add(CreateEndDateColumn());
			}
			if (Columns.FindByUId(new Guid("e8cb5416-f527-45fa-ab0d-625b915c088c")) == null) {
				Columns.Add(CreateDurationColumn());
			}
			if (Columns.FindByUId(new Guid("f78cd4b2-fd18-4053-894d-b255fd197b62")) == null) {
				Columns.Add(CreateDeadlineColumn());
			}
			if (Columns.FindByUId(new Guid("88bc4b97-11f8-448f-9d43-3c801f60790e")) == null) {
				Columns.Add(CreateSupplierColumn());
			}
			if (Columns.FindByUId(new Guid("32044112-504d-4450-9d02-bd669f4c4f01")) == null) {
				Columns.Add(CreateOpportunityColumn());
			}
			if (Columns.FindByUId(new Guid("66e7067f-6bcd-431f-bc33-93a89d748ad6")) == null) {
				Columns.Add(CreateActualCompletionColumn());
			}
			if (Columns.FindByUId(new Guid("99967435-03c4-41e2-ac57-e1313ee1aac1")) == null) {
				Columns.Add(CreateIsAutoCalcCompletionColumn());
			}
			if (Columns.FindByUId(new Guid("d3a36229-802e-4ca7-8136-991aedd18274")) == null) {
				Columns.Add(CreatePlanIncomeColumn());
			}
			if (Columns.FindByUId(new Guid("486f48f4-375e-4a21-aa9f-b0cf7dfef749")) == null) {
				Columns.Add(CreateFactIncomeColumn());
			}
			if (Columns.FindByUId(new Guid("ae3fe8ec-0c11-4db9-891b-0a3a97f7e4be")) == null) {
				Columns.Add(CreateIncomeDevColumn());
			}
			if (Columns.FindByUId(new Guid("1e0cfd57-b456-4e2c-af46-e9161c3f7aff")) == null) {
				Columns.Add(CreateIncomeDevPercColumn());
			}
			if (Columns.FindByUId(new Guid("19c7568e-fa60-4afe-a1b4-5b63f75bffb4")) == null) {
				Columns.Add(CreatePlanExternalCostColumn());
			}
			if (Columns.FindByUId(new Guid("48f4cd4f-df8a-4894-a574-f04c5c7760f2")) == null) {
				Columns.Add(CreateFactExternalCostColumn());
			}
			if (Columns.FindByUId(new Guid("a3ee342c-2693-4946-8923-dfae5a31758a")) == null) {
				Columns.Add(CreateExternalCostDevColumn());
			}
			if (Columns.FindByUId(new Guid("a1d3575a-66fd-41f9-ba98-5f6db0a378e0")) == null) {
				Columns.Add(CreatePlanExternalDevPercColumn());
			}
			if (Columns.FindByUId(new Guid("4d54a487-00a3-4365-89b2-1c1db30cd74b")) == null) {
				Columns.Add(CreatePlanExpenseColumn());
			}
			if (Columns.FindByUId(new Guid("5409edce-b74d-43d1-b2bc-809d3e704441")) == null) {
				Columns.Add(CreateFactExpenseColumn());
			}
			if (Columns.FindByUId(new Guid("61c108ff-dde2-481a-862c-aefbf5c427a8")) == null) {
				Columns.Add(CreateExpenseDevColumn());
			}
			if (Columns.FindByUId(new Guid("b81af69b-d44c-413a-ab0f-e92d747f98b0")) == null) {
				Columns.Add(CreateExpenseDevPercColumn());
			}
			if (Columns.FindByUId(new Guid("9da8c8a1-94c2-43bd-b3d3-110811d7cebf")) == null) {
				Columns.Add(CreatePlanInternalCostColumn());
			}
			if (Columns.FindByUId(new Guid("76578c06-52ea-4daf-9fc7-cb311960a9d4")) == null) {
				Columns.Add(CreateFactInternalCostColumn());
			}
			if (Columns.FindByUId(new Guid("d0c0c991-79b5-4c4d-a023-c21247ac055f")) == null) {
				Columns.Add(CreateInternalCostDevColumn());
			}
			if (Columns.FindByUId(new Guid("5ca01a2f-a281-4f2c-9683-bed1debf6499")) == null) {
				Columns.Add(CreatePlanInternalDevPercColumn());
			}
			if (Columns.FindByUId(new Guid("49fdaaf1-5d6d-4733-9db3-d91072236648")) == null) {
				Columns.Add(CreatePlanMarginColumn());
			}
			if (Columns.FindByUId(new Guid("caca0f15-0494-47c7-a6e9-d6e2ff54fa5a")) == null) {
				Columns.Add(CreatePlanMarginPercColumn());
			}
			if (Columns.FindByUId(new Guid("e4e98bdc-f728-41a4-89b9-7c70ff75def5")) == null) {
				Columns.Add(CreateFactMarginColumn());
			}
			if (Columns.FindByUId(new Guid("2a15bb6d-441c-4b2a-b8fd-a4d0d1bfe4ff")) == null) {
				Columns.Add(CreateFactMarginPercColumn());
			}
			if (Columns.FindByUId(new Guid("3c28c5e9-a73f-4a49-bf98-59634c5310c9")) == null) {
				Columns.Add(CreateMarginDevColumn());
			}
			if (Columns.FindByUId(new Guid("a95be56a-d10a-4921-bfe4-faea45cf0db2")) == null) {
				Columns.Add(CreateMarginDevPercColumn());
			}
			if (Columns.FindByUId(new Guid("07b548e1-64fe-41bd-ae88-0f4927be9c65")) == null) {
				Columns.Add(CreatePositionColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateNotesColumn() {
			EntitySchemaColumn column = base.CreateNotesColumn();
			column.ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("aaec4bf5-a07d-4f79-b45d-8c7eeead3fad"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("62a1bf12-279e-48d8-8a28-041be01c5003"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1b4c54b0-33fc-4aeb-9f48-acddb453fe5b"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateProjectEntryTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("41e82ce8-a31c-48a0-b6a5-b90660c83759"),
				Name = @"ProjectEntryType",
				ReferenceSchemaUId = new Guid("282a4e1e-5384-406c-8b67-a66fe9b9c0d9"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e0d39946-16ca-4649-b6fb-1be29312f709"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("ebcd53e5-4d8a-4109-b995-951d35677bc5"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("532d4f22-8b39-4860-8e62-60b678c9193a"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e1829b39-9b37-4a34-9e33-18fc056fdcbd"),
				Name = @"Status",
				ReferenceSchemaUId = new Guid("8bafd341-8ae7-4703-bca6-8de07c992d37"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"ProjectStateDef"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("8f11337c-f8fe-4e3c-9576-b26554359fd7"),
				Name = @"StartDate",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDate")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateEndDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("470aee83-6564-4676-b0c7-44e8374664d5"),
				Name = @"EndDate",
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateDurationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("e8cb5416-f527-45fa-ab0d-625b915c088c"),
				Name = @"Duration",
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateDeadlineColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("f78cd4b2-fd18-4053-894d-b255fd197b62"),
				Name = @"Deadline",
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateSupplierColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("88bc4b97-11f8-448f-9d43-3c801f60790e"),
				Name = @"Supplier",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserAccount")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateOpportunityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("32044112-504d-4450-9d02-bd669f4c4f01"),
				Name = @"Opportunity",
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateParentProjectColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1e08e1e5-e00b-4abb-8022-43a6b913d48f"),
				Name = @"ParentProject",
				ReferenceSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateActualCompletionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("66e7067f-6bcd-431f-bc33-93a89d748ad6"),
				Name = @"ActualCompletion",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateIsAutoCalcCompletionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("99967435-03c4-41e2-ac57-e1313ee1aac1"),
				Name = @"IsAutoCalcCompletion",
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("ee500218-76c6-4043-a948-469ada4fc1d4")
			};
		}

		protected virtual EntitySchemaColumn CreatePlanIncomeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("d3a36229-802e-4ca7-8136-991aedd18274"),
				Name = @"PlanIncome",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateFactIncomeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("486f48f4-375e-4a21-aa9f-b0cf7dfef749"),
				Name = @"FactIncome",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateIncomeDevColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("ae3fe8ec-0c11-4db9-891b-0a3a97f7e4be"),
				Name = @"IncomeDev",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateIncomeDevPercColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("1e0cfd57-b456-4e2c-af46-e9161c3f7aff"),
				Name = @"IncomeDevPerc",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreatePlanExternalCostColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("19c7568e-fa60-4afe-a1b4-5b63f75bffb4"),
				Name = @"PlanExternalCost",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateFactExternalCostColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("48f4cd4f-df8a-4894-a574-f04c5c7760f2"),
				Name = @"FactExternalCost",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateExternalCostDevColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("a3ee342c-2693-4946-8923-dfae5a31758a"),
				Name = @"ExternalCostDev",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreatePlanExternalDevPercColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("a1d3575a-66fd-41f9-ba98-5f6db0a378e0"),
				Name = @"PlanExternalDevPerc",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreatePlanExpenseColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("4d54a487-00a3-4365-89b2-1c1db30cd74b"),
				Name = @"PlanExpense",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateFactExpenseColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("5409edce-b74d-43d1-b2bc-809d3e704441"),
				Name = @"FactExpense",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateExpenseDevColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("61c108ff-dde2-481a-862c-aefbf5c427a8"),
				Name = @"ExpenseDev",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateExpenseDevPercColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("b81af69b-d44c-413a-ab0f-e92d747f98b0"),
				Name = @"ExpenseDevPerc",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreatePlanInternalCostColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("9da8c8a1-94c2-43bd-b3d3-110811d7cebf"),
				Name = @"PlanInternalCost",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateFactInternalCostColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("76578c06-52ea-4daf-9fc7-cb311960a9d4"),
				Name = @"FactInternalCost",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateInternalCostDevColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("d0c0c991-79b5-4c4d-a023-c21247ac055f"),
				Name = @"InternalCostDev",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreatePlanInternalDevPercColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("5ca01a2f-a281-4f2c-9683-bed1debf6499"),
				Name = @"PlanInternalDevPerc",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreatePlanMarginColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("49fdaaf1-5d6d-4733-9db3-d91072236648"),
				Name = @"PlanMargin",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreatePlanMarginPercColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("caca0f15-0494-47c7-a6e9-d6e2ff54fa5a"),
				Name = @"PlanMarginPerc",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateFactMarginColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("e4e98bdc-f728-41a4-89b9-7c70ff75def5"),
				Name = @"FactMargin",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateFactMarginPercColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("2a15bb6d-441c-4b2a-b8fd-a4d0d1bfe4ff"),
				Name = @"FactMarginPerc",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateMarginDevColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("3c28c5e9-a73f-4a49-bf98-59634c5310c9"),
				Name = @"MarginDev",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateMarginDevPercColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("a95be56a-d10a-4921-bfe4-faea45cf0db2"),
				Name = @"MarginDevPerc",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("07b548e1-64fe-41bd-ae88-0f4927be9c65"),
				Name = @"Position",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				ModifiedInSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateProject_Project_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateProject_Project_TerrasoftEventsProcessSchema() {
			var schema = new Project_Project_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Project_Project_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Project_ProjectEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Project_Project_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Project_Project_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"));
		}

		#endregion

	}

	#endregion

	#region Class: Project_Project_Terrasoft

	/// <summary>
	/// Project.
	/// </summary>
	public class Project_Project_Terrasoft : Terrasoft.Configuration.BaseEntityNotes
	{

		#region Constructors: Public

		public Project_Project_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Project_Project_Terrasoft";
		}

		public Project_Project_Terrasoft(Project_Project_Terrasoft source)
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
		public Guid ProjectEntryTypeId {
			get {
				return GetTypedColumnValue<Guid>("ProjectEntryTypeId");
			}
			set {
				SetColumnValue("ProjectEntryTypeId", value);
				_projectEntryType = null;
			}
		}

		/// <exclude/>
		public string ProjectEntryTypeName {
			get {
				return GetTypedColumnValue<string>("ProjectEntryTypeName");
			}
			set {
				SetColumnValue("ProjectEntryTypeName", value);
				if (_projectEntryType != null) {
					_projectEntryType.Name = value;
				}
			}
		}

		private ProjectEntryType _projectEntryType;
		/// <summary>
		/// Project record type.
		/// </summary>
		public ProjectEntryType ProjectEntryType {
			get {
				return _projectEntryType ??
					(_projectEntryType = LookupColumnEntities.GetEntity("ProjectEntryType") as ProjectEntryType);
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

		private ProjectType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public ProjectType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as ProjectType);
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

		private ProjectStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public ProjectStatus Status {
			get {
				return _status ??
					(_status = LookupColumnEntities.GetEntity("Status") as ProjectStatus);
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
		/// End.
		/// </summary>
		public DateTime EndDate {
			get {
				return GetTypedColumnValue<DateTime>("EndDate");
			}
			set {
				SetColumnValue("EndDate", value);
			}
		}

		/// <summary>
		/// Duration.
		/// </summary>
		public int Duration {
			get {
				return GetTypedColumnValue<int>("Duration");
			}
			set {
				SetColumnValue("Duration", value);
			}
		}

		/// <summary>
		/// Deadline.
		/// </summary>
		public DateTime Deadline {
			get {
				return GetTypedColumnValue<DateTime>("Deadline");
			}
			set {
				SetColumnValue("Deadline", value);
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

		/// <exclude/>
		public Guid OpportunityId {
			get {
				return GetTypedColumnValue<Guid>("OpportunityId");
			}
			set {
				SetColumnValue("OpportunityId", value);
				_opportunity = null;
			}
		}

		/// <exclude/>
		public string OpportunityTitle {
			get {
				return GetTypedColumnValue<string>("OpportunityTitle");
			}
			set {
				SetColumnValue("OpportunityTitle", value);
				if (_opportunity != null) {
					_opportunity.Title = value;
				}
			}
		}

		private Opportunity _opportunity;
		/// <summary>
		/// Opportunity.
		/// </summary>
		public Opportunity Opportunity {
			get {
				return _opportunity ??
					(_opportunity = LookupColumnEntities.GetEntity("Opportunity") as Opportunity);
			}
		}

		/// <exclude/>
		public Guid ParentProjectId {
			get {
				return GetTypedColumnValue<Guid>("ParentProjectId");
			}
			set {
				SetColumnValue("ParentProjectId", value);
				_parentProject = null;
			}
		}

		/// <exclude/>
		public string ParentProjectName {
			get {
				return GetTypedColumnValue<string>("ParentProjectName");
			}
			set {
				SetColumnValue("ParentProjectName", value);
				if (_parentProject != null) {
					_parentProject.Name = value;
				}
			}
		}

		private Project _parentProject;
		/// <summary>
		/// Parent item.
		/// </summary>
		public Project ParentProject {
			get {
				return _parentProject ??
					(_parentProject = LookupColumnEntities.GetEntity("ParentProject") as Project);
			}
		}

		/// <summary>
		/// Completion %.
		/// </summary>
		public Decimal ActualCompletion {
			get {
				return GetTypedColumnValue<Decimal>("ActualCompletion");
			}
			set {
				SetColumnValue("ActualCompletion", value);
			}
		}

		/// <summary>
		/// Calculate automatically.
		/// </summary>
		public bool IsAutoCalcCompletion {
			get {
				return GetTypedColumnValue<bool>("IsAutoCalcCompletion");
			}
			set {
				SetColumnValue("IsAutoCalcCompletion", value);
			}
		}

		/// <summary>
		/// Expected revenue.
		/// </summary>
		public Decimal PlanIncome {
			get {
				return GetTypedColumnValue<Decimal>("PlanIncome");
			}
			set {
				SetColumnValue("PlanIncome", value);
			}
		}

		/// <summary>
		/// Actual revenue.
		/// </summary>
		public Decimal FactIncome {
			get {
				return GetTypedColumnValue<Decimal>("FactIncome");
			}
			set {
				SetColumnValue("FactIncome", value);
			}
		}

		/// <summary>
		/// Revenue deviation.
		/// </summary>
		public Decimal IncomeDev {
			get {
				return GetTypedColumnValue<Decimal>("IncomeDev");
			}
			set {
				SetColumnValue("IncomeDev", value);
			}
		}

		/// <summary>
		/// Revenue deviation, %.
		/// </summary>
		public Decimal IncomeDevPerc {
			get {
				return GetTypedColumnValue<Decimal>("IncomeDevPerc");
			}
			set {
				SetColumnValue("IncomeDevPerc", value);
			}
		}

		/// <summary>
		/// Expected total cost.
		/// </summary>
		public Decimal PlanExternalCost {
			get {
				return GetTypedColumnValue<Decimal>("PlanExternalCost");
			}
			set {
				SetColumnValue("PlanExternalCost", value);
			}
		}

		/// <summary>
		/// Actual total cost.
		/// </summary>
		public Decimal FactExternalCost {
			get {
				return GetTypedColumnValue<Decimal>("FactExternalCost");
			}
			set {
				SetColumnValue("FactExternalCost", value);
			}
		}

		/// <summary>
		/// Total cost deviation.
		/// </summary>
		public Decimal ExternalCostDev {
			get {
				return GetTypedColumnValue<Decimal>("ExternalCostDev");
			}
			set {
				SetColumnValue("ExternalCostDev", value);
			}
		}

		/// <summary>
		/// Total cost deviation, %.
		/// </summary>
		public Decimal PlanExternalDevPerc {
			get {
				return GetTypedColumnValue<Decimal>("PlanExternalDevPerc");
			}
			set {
				SetColumnValue("PlanExternalDevPerc", value);
			}
		}

		/// <summary>
		/// Expected direct expense.
		/// </summary>
		public Decimal PlanExpense {
			get {
				return GetTypedColumnValue<Decimal>("PlanExpense");
			}
			set {
				SetColumnValue("PlanExpense", value);
			}
		}

		/// <summary>
		/// Actual direct expense.
		/// </summary>
		public Decimal FactExpense {
			get {
				return GetTypedColumnValue<Decimal>("FactExpense");
			}
			set {
				SetColumnValue("FactExpense", value);
			}
		}

		/// <summary>
		/// Direct expenses deviation.
		/// </summary>
		public Decimal ExpenseDev {
			get {
				return GetTypedColumnValue<Decimal>("ExpenseDev");
			}
			set {
				SetColumnValue("ExpenseDev", value);
			}
		}

		/// <summary>
		/// Direct expenses deviation, %.
		/// </summary>
		public Decimal ExpenseDevPerc {
			get {
				return GetTypedColumnValue<Decimal>("ExpenseDevPerc");
			}
			set {
				SetColumnValue("ExpenseDevPerc", value);
			}
		}

		/// <summary>
		/// Expected prime cost.
		/// </summary>
		public Decimal PlanInternalCost {
			get {
				return GetTypedColumnValue<Decimal>("PlanInternalCost");
			}
			set {
				SetColumnValue("PlanInternalCost", value);
			}
		}

		/// <summary>
		/// Actual prime cost.
		/// </summary>
		public Decimal FactInternalCost {
			get {
				return GetTypedColumnValue<Decimal>("FactInternalCost");
			}
			set {
				SetColumnValue("FactInternalCost", value);
			}
		}

		/// <summary>
		/// Prime cost deviation.
		/// </summary>
		public Decimal InternalCostDev {
			get {
				return GetTypedColumnValue<Decimal>("InternalCostDev");
			}
			set {
				SetColumnValue("InternalCostDev", value);
			}
		}

		/// <summary>
		/// Prime cost deviation, %.
		/// </summary>
		public Decimal PlanInternalDevPerc {
			get {
				return GetTypedColumnValue<Decimal>("PlanInternalDevPerc");
			}
			set {
				SetColumnValue("PlanInternalDevPerc", value);
			}
		}

		/// <summary>
		/// Expected margin.
		/// </summary>
		public Decimal PlanMargin {
			get {
				return GetTypedColumnValue<Decimal>("PlanMargin");
			}
			set {
				SetColumnValue("PlanMargin", value);
			}
		}

		/// <summary>
		/// Expected margin, %.
		/// </summary>
		public Decimal PlanMarginPerc {
			get {
				return GetTypedColumnValue<Decimal>("PlanMarginPerc");
			}
			set {
				SetColumnValue("PlanMarginPerc", value);
			}
		}

		/// <summary>
		/// Actual margin.
		/// </summary>
		public Decimal FactMargin {
			get {
				return GetTypedColumnValue<Decimal>("FactMargin");
			}
			set {
				SetColumnValue("FactMargin", value);
			}
		}

		/// <summary>
		/// Actual margin, %.
		/// </summary>
		public Decimal FactMarginPerc {
			get {
				return GetTypedColumnValue<Decimal>("FactMarginPerc");
			}
			set {
				SetColumnValue("FactMarginPerc", value);
			}
		}

		/// <summary>
		/// Margin deviation.
		/// </summary>
		public Decimal MarginDev {
			get {
				return GetTypedColumnValue<Decimal>("MarginDev");
			}
			set {
				SetColumnValue("MarginDev", value);
			}
		}

		/// <summary>
		/// Margin deviation, %.
		/// </summary>
		public Decimal MarginDevPerc {
			get {
				return GetTypedColumnValue<Decimal>("MarginDevPerc");
			}
			set {
				SetColumnValue("MarginDevPerc", value);
			}
		}

		/// <summary>
		/// Position.
		/// </summary>
		public int Position {
			get {
				return GetTypedColumnValue<int>("Position");
			}
			set {
				SetColumnValue("Position", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Project_ProjectEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Project_Project_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("Project_Project_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Project_Project_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Project_Project_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Project_Project_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Project_Project_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Project_ProjectEventsProcess

	/// <exclude/>
	public partial class Project_ProjectEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntityNotes_BaseEventsProcess<TEntity> where TEntity : Project_Project_Terrasoft
	{

		public Project_ProjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Project_ProjectEventsProcess";
			SchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a11d7fa4-9946-494c-ae41-2169844d29be");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private bool _isNeedLog = false;
		public bool IsNeedLog {
			get {
				return _isNeedLog;
			}
			set {
				_isNeedLog = value;
			}
		}

		private bool _needUpdatePosition = true;
		public bool NeedUpdatePosition {
			get {
				return _needUpdatePosition;
			}
			set {
				_needUpdatePosition = value;
			}
		}

		public virtual bool ContactChanged {
			get;
			set;
		}

		public virtual bool AccountChanged {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess2;
		public ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("cb8cef88-5377-4da2-be1d-161d09fc70d2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _projectSaved;
		public ProcessFlowElement ProjectSaved {
			get {
				return _projectSaved ?? (_projectSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ProjectSaved",
					SchemaElementUId = new Guid("797b2a67-63b9-49db-bae0-b31132b13252"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _projectSavedScriptTask;
		public ProcessScriptTask ProjectSavedScriptTask {
			get {
				return _projectSavedScriptTask ?? (_projectSavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProjectSavedScriptTask",
					SchemaElementUId = new Guid("b4a11403-587f-4b26-ac2f-09d15c19975e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ProjectSavedScriptTaskExecute,
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
					SchemaElementUId = new Guid("5fac7060-a713-4b35-bc4f-aeb64f926aef"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _projectSaving;
		public ProcessFlowElement ProjectSaving {
			get {
				return _projectSaving ?? (_projectSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ProjectSaving",
					SchemaElementUId = new Guid("44b055ea-2c68-4566-b722-cc86020d40d8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _projectSavingScriptTask;
		public ProcessScriptTask ProjectSavingScriptTask {
			get {
				return _projectSavingScriptTask ?? (_projectSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProjectSavingScriptTask",
					SchemaElementUId = new Guid("3c3e0d00-9ceb-4027-88f1-e509b2cce5a9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ProjectSavingScriptTaskExecute,
				});
			}
		}

		private LocalizableString _parentArgumentException;
		public LocalizableString ParentArgumentException {
			get {
				return _parentArgumentException ?? (_parentArgumentException = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ParentArgumentException.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[ProjectSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ProjectSaved };
			FlowElements[ProjectSavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProjectSavedScriptTask };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ProjectSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { ProjectSaving };
			FlowElements[ProjectSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProjectSavingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess2":
						break;
					case "ProjectSaved":
						e.Context.QueueTasks.Enqueue("ProjectSavedScriptTask");
						break;
					case "ProjectSavedScriptTask":
						break;
					case "EventSubProcess1":
						break;
					case "ProjectSaving":
						e.Context.QueueTasks.Enqueue("ProjectSavingScriptTask");
						break;
					case "ProjectSavingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ProjectSaved");
			ActivatedEventElements.Add("ProjectSaving");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "ProjectSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProjectSaved";
					result = ProjectSaved.Execute(context);
					break;
				case "ProjectSavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProjectSavedScriptTask";
					result = ProjectSavedScriptTask.Execute(context, ProjectSavedScriptTaskExecute);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "ProjectSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProjectSaving";
					result = ProjectSaving.Execute(context);
					break;
				case "ProjectSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProjectSavingScriptTask";
					result = ProjectSavingScriptTask.Execute(context, ProjectSavingScriptTaskExecute);
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
				case "AccountChanged":
					AccountChanged = reader.GetValue<System.Boolean>();
				break;
				case "ContactChanged":
					ContactChanged = reader.GetValue<System.Boolean>();
				break;
				case "NeedUpdatePosition":
					NeedUpdatePosition = reader.GetValue<System.Boolean>();
				break;
				case "IsNeedLog":
					IsNeedLog = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ProjectSavedScriptTaskExecute(ProcessExecutingContext context) {
			if (ContactChanged || AccountChanged) {
				UpdateChildren(Entity.GetTypedColumnValue<Guid>("Id"), Entity.GetColumnValue("ContactId"), Entity.GetColumnValue("AccountId"));
			}
			return true;
		}

		public virtual bool ProjectSavingScriptTaskExecute(ProcessExecutingContext context) {
			ContactChanged = false;
			AccountChanged = false;
			if (!CheckParent()) {
				throw new ArgumentException(ParentArgumentException);
			}
			if (NeedUpdatePosition) {
				UpdatePosition();
			}
			ContactChanged = GetChanged("Guid","ContactId");
			AccountChanged = GetChanged("Guid","AccountId");
			if (Entity.SupplierId == Guid.Empty) {
				EntitySchemaColumn supplier = Entity.Schema.Columns.FindByName("Supplier");
				supplier.DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.None,
					ValueSource = @""
				};
				Entity.SetColumnValue("SupplierId", null);
			}
			return true; 
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Project_Project_TerrasoftSaved":
							if (ActivatedEventElements.Contains("ProjectSaved")) {
							context.QueueTasks.Enqueue("ProjectSaved");
						}
						break;
					case "Project_Project_TerrasoftSaving":
							if (ActivatedEventElements.Contains("ProjectSaving")) {
							context.QueueTasks.Enqueue("ProjectSaving");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("AccountChanged") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("AccountChanged", AccountChanged, false);
			}
			if (!HasMapping("ContactChanged") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ContactChanged", ContactChanged, false);
			}
			if (!HasMapping("NeedUpdatePosition") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NeedUpdatePosition", NeedUpdatePosition, false);
			}
			if (!HasMapping("IsNeedLog") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNeedLog", IsNeedLog, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: Project_ProjectEventsProcess

	/// <exclude/>
	public class Project_ProjectEventsProcess : Project_ProjectEventsProcess<Project_Project_Terrasoft>
	{

		public Project_ProjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Project_ProjectEventsProcess

	public partial class Project_ProjectEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual bool GetChanged(string typeName, string columnName) {
			var value = Entity.GetColumnValue(columnName);
			var oldValue = Entity.GetColumnOldValue(columnName);
			if (value == null && oldValue == null) {
				return false;
			}
			if (value == null || oldValue == null) {
				return true;
			} 
			if ((typeName == "decimal" && (decimal)value != (decimal)oldValue) ||
				(typeName == "DateTime" && (DateTime)value != (DateTime)oldValue) ||
				(typeName == "Guid" && (Guid)value != (Guid)oldValue)) {
				return true;
			}
			return false;
		}

		public virtual void UpdatePosition() {
			var OldParentProjectId = Entity.GetTypedOldColumnValue<Guid>("ParentProjectId");
			var parentId = Entity.GetTypedColumnValue<Guid>("ParentProjectId");
			if (Entity.StoringState != StoringObjectState.New && parentId == Guid.Empty) {
				return;
			}
			int currentPosition = Entity.GetTypedColumnValue<int>("Position");
			if ((Entity.StoringState != StoringObjectState.New) || 
				(Entity.StoringState == StoringObjectState.New && currentPosition != default(int))) {
				return;
			}
			Select selectCount = new Select(UserConnection).
				Column(Func.Count("Id")).
				From("Project").
				Where("ParentProjectId").IsEqual(Column.Parameter(parentId)) as Select;
			int position = 0;
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (var reader = selectCount.ExecuteReader(dbExecutor)) {
					if (reader.Read()) {
						position = UserConnection.DBTypeConverter.DBValueToInt(reader[0]);
					}
				}
			}
			Entity.SetColumnValue("Position",position);
		}

		public virtual bool CheckParent() {
			var projectId = Entity.GetTypedColumnValue<Guid>(Entity.Schema.GetPrimaryColumnName());
			var parentId = Entity.GetTypedColumnValue<Guid>("ParentProjectId");
			if (projectId != parentId) {
				List<Guid> childProjectsIds = HierarchicalProjectUtilities.GetChildProjectsIDs(projectId,UserConnection);
				if (!childProjectsIds.Contains(parentId)) {
					return true;
				}
			}
			return false;
		}

		public virtual void UpdateChildren(Guid projectId, object newContactId, object newAccountId) {
			if (projectId != Guid.Empty) {
				var childProjectsIds = HierarchicalProjectUtilities.GetChildProjectsIDs(projectId,UserConnection).Select(x => new QueryParameter(x));
				(new Update(UserConnection, "Project")
								.Set("ContactId", Column.Parameter(newContactId, "Guid"))
								.Set("AccountId", Column.Parameter(newAccountId, "Guid"))
								.Where("Id")
									.In(childProjectsIds) as Update).Execute();
			}
		}

		#endregion

	}

	#endregion

	#region Class: Project_Project_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Project_Project_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityNotesEventsProcessSchema
	{

		#region Constructors: Public

		public Project_Project_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Project_Project_TerrasoftEventsProcessSchema(Project_Project_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Project_ProjectEventsProcess";
			UId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69");
			CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("58e8159b-d9c4-497b-9d9e-42548d6ffd2e");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateIsNeedLogParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("26eb82b0-32cc-4d73-adc5-311babb71d4a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				Name = @"IsNeedLog",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"False",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedUpdatePositionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("98756912-9b39-495d-b384-1acda848e667"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				Name = @"NeedUpdatePosition",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"True",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateContactChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7401e94e-3a35-4e3e-a8c9-e53842f6383c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				Name = @"ContactChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateAccountChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b184882f-4b29-4d03-a01f-a693a94e8cde"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				Name = @"AccountChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsNeedLogParameter());
			Parameters.Add(CreateNeedUpdatePositionParameter());
			Parameters.Add(CreateContactChangedParameter());
			Parameters.Add(CreateAccountChangedParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaSaveLaneSet = CreateSaveLaneSetLaneSet();
			LaneSets.Add(schemaSaveLaneSet);
			ProcessSchemaLane schemaSavedLane = CreateSavedLaneLane();
			schemaSaveLaneSet.Lanes.Add(schemaSavedLane);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent projectsaved = CreateProjectSavedStartMessageEvent();
			eventsubprocess2.FlowElements.Add(projectsaved);
			ProcessSchemaScriptTask projectsavedscripttask = CreateProjectSavedScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(projectsavedscripttask);
			ProcessSchemaStartMessageEvent projectsaving = CreateProjectSavingStartMessageEvent();
			eventsubprocess1.FlowElements.Add(projectsaving);
			ProcessSchemaScriptTask projectsavingscripttask = CreateProjectSavingScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(projectsavingscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateParentArgumentExceptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateParentArgumentExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("21f8d7aa-e6f9-4df7-b8df-e79affecfc6c"),
				Name = "ParentArgumentException",
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb"),
				CreatedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				ModifiedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("484b1dd6-a888-4c19-bc72-fd15a93cf0d6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("58e8159b-d9c4-497b-9d9e-42548d6ffd2e"),
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f"),
				CreatedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				CurveCenterPosition = new Point(185, 68),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("44b055ea-2c68-4566-b722-cc86020d40d8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3c3e0d00-9ceb-4027-88f1-e509b2cce5a9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("853095e1-4393-425f-bcae-e7d358134dcf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("58e8159b-d9c4-497b-9d9e-42548d6ffd2e"),
				CreatedInPackageId = new Guid("61c8641f-c044-4b81-ab30-bcda839818c3"),
				CreatedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				CurveCenterPosition = new Point(190, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("797b2a67-63b9-49db-bae0-b31132b13252"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b4a11403-587f-4b26-ac2f-09d15c19975e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateSaveLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaSaveLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("f35f3f0c-786f-46ec-be69-457fadc60381"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("58e8159b-d9c4-497b-9d9e-42548d6ffd2e"),
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f"),
				CreatedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				Name = @"SaveLaneSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1237, 177),
				UseBackgroundMode = false
			};
			return schemaSaveLaneSet;
		}

		protected virtual ProcessSchemaLane CreateSavedLaneLane() {
			ProcessSchemaLane schemaSavedLane = new ProcessSchemaLane(this) {
				UId = new Guid("102df002-9b05-400a-9f58-d15a2b3c8207"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("f35f3f0c-786f-46ec-be69-457fadc60381"),
				CreatedInOwnerSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				CreatedInPackageId = new Guid("61c8641f-c044-4b81-ab30-bcda839818c3"),
				CreatedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				Name = @"SavedLane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1208, 177),
				UseBackgroundMode = false
			};
			return schemaSavedLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("cb8cef88-5377-4da2-be1d-161d09fc70d2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("102df002-9b05-400a-9f58-d15a2b3c8207"),
				CreatedInOwnerSchemaUId = new Guid("58e8159b-d9c4-497b-9d9e-42548d6ffd2e"),
				CreatedInPackageId = new Guid("61c8641f-c044-4b81-ab30-bcda839818c3"),
				CreatedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(49, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(259, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateProjectSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("797b2a67-63b9-49db-bae0-b31132b13252"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cb8cef88-5377-4da2-be1d-161d09fc70d2"),
				CreatedInOwnerSchemaUId = new Guid("58e8159b-d9c4-497b-9d9e-42548d6ffd2e"),
				CreatedInPackageId = new Guid("61c8641f-c044-4b81-ab30-bcda839818c3"),
				CreatedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ProjectSaved",
				ModifiedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				Name = @"ProjectSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateProjectSavedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b4a11403-587f-4b26-ac2f-09d15c19975e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cb8cef88-5377-4da2-be1d-161d09fc70d2"),
				CreatedInOwnerSchemaUId = new Guid("58e8159b-d9c4-497b-9d9e-42548d6ffd2e"),
				CreatedInPackageId = new Guid("61c8641f-c044-4b81-ab30-bcda839818c3"),
				CreatedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				Name = @"ProjectSavedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(121, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,112,206,207,43,73,76,46,113,206,72,204,75,79,77,81,168,169,81,112,76,78,206,47,205,131,137,104,42,84,243,114,113,134,22,164,36,150,164,58,103,100,230,164,20,165,230,105,184,230,149,100,150,84,234,185,167,150,132,84,22,164,166,56,231,231,148,230,230,133,37,230,148,166,218,184,151,102,166,216,105,40,121,166,40,105,234,40,32,212,33,41,209,80,130,218,137,87,13,212,21,32,53,154,214,188,92,181,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,35,221,91,12,186,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5fac7060-a713-4b35-bc4f-aeb64f926aef"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("102df002-9b05-400a-9f58-d15a2b3c8207"),
				CreatedInOwnerSchemaUId = new Guid("58e8159b-d9c4-497b-9d9e-42548d6ffd2e"),
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f"),
				CreatedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(50, 198),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 126),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateProjectSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("44b055ea-2c68-4566-b722-cc86020d40d8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5fac7060-a713-4b35-bc4f-aeb64f926aef"),
				CreatedInOwnerSchemaUId = new Guid("58e8159b-d9c4-497b-9d9e-42548d6ffd2e"),
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f"),
				CreatedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ProjectSaving",
				ModifiedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				Name = @"ProjectSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateProjectSavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3c3e0d00-9ceb-4027-88f1-e509b2cce5a9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5fac7060-a713-4b35-bc4f-aeb64f926aef"),
				CreatedInOwnerSchemaUId = new Guid("58e8159b-d9c4-497b-9d9e-42548d6ffd2e"),
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f"),
				CreatedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				Name = @"ProjectSavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(120, 23),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,145,81,107,131,48,20,133,159,45,244,63,100,121,138,32,249,3,50,88,231,92,233,139,20,100,123,15,241,90,195,52,145,152,208,201,232,127,95,76,212,177,214,71,239,57,223,185,39,215,76,73,195,184,201,26,38,47,80,161,103,84,179,118,128,116,191,59,112,174,172,220,16,68,141,200,83,214,0,255,58,51,13,210,144,56,70,63,251,93,100,26,173,174,72,194,21,29,244,197,118,78,201,191,57,244,70,40,73,130,243,97,30,187,184,91,72,44,0,170,143,190,98,6,206,106,16,94,244,169,255,103,100,38,178,251,214,71,88,62,8,62,90,81,225,4,207,158,83,133,227,173,231,108,16,179,103,38,166,86,185,52,194,140,180,180,125,223,10,208,39,7,58,210,185,105,222,245,102,12,21,131,169,228,13,116,44,83,173,237,36,26,102,192,237,89,34,188,76,131,62,208,119,33,171,215,177,96,29,16,188,164,251,173,209,130,210,55,168,63,89,107,193,101,76,71,125,220,226,12,36,52,136,74,101,53,135,117,219,157,43,168,180,80,18,146,201,237,99,87,228,5,99,55,188,165,235,75,104,233,78,227,89,111,252,43,232,14,147,32,105,219,118,254,11,26,140,213,18,25,109,33,69,191,100,205,1,140,73,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetChangedMethod());
			Methods.Add(CreateUpdatePositionMethod());
			Methods.Add(CreateCheckParentMethod());
			Methods.Add(CreateUpdateChildrenMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
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
				UId = new Guid("e37cc7f3-7c17-4d44-84bf-dd73c393b537"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("61c8641f-c044-4b81-ab30-bcda839818c3")
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

		protected virtual SchemaMethod CreateGetChangedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d1a9a991-e073-4902-b61b-595e268d0d19"),
				Name = "GetChanged",
				CreatedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d341fe89-966a-49d3-99b6-6b5f58952d7c"),
				Name = "typeName",
				CreatedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				ModifiedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("971274c2-5d4c-4f35-b4a0-f2d0ec721af6"),
				Name = "columnName",
				CreatedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				ModifiedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,177,14,130,48,16,134,103,73,120,135,147,129,180,139,47,96,152,212,176,233,98,216,27,56,146,38,45,152,218,146,16,241,221,109,41,32,24,100,235,253,189,239,187,107,27,166,160,97,194,32,36,112,169,52,215,237,33,69,125,170,133,145,85,230,114,146,247,231,43,147,72,143,97,208,216,254,90,20,217,31,228,54,92,253,80,188,4,50,76,73,160,50,66,64,28,207,52,62,163,240,10,131,157,66,109,84,5,37,19,79,180,228,123,13,238,186,109,88,43,211,179,224,97,162,219,7,186,85,92,115,84,96,206,37,19,145,91,129,12,5,245,254,125,242,77,198,1,212,78,179,230,165,227,204,52,222,185,68,47,25,171,153,101,138,54,53,169,225,133,87,184,211,12,239,203,9,93,125,91,24,44,126,234,3,53,152,1,13,200,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdatePositionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f0c85a5d-5c04-43d3-8928-1ea89cb867c1"),
				Name = "UpdatePosition",
				CreatedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,193,78,194,64,16,61,151,132,127,88,123,48,219,196,108,184,99,61,0,133,112,17,34,168,7,227,97,105,7,173,105,119,235,118,23,37,226,191,59,187,109,165,34,33,154,180,105,119,118,222,155,55,243,102,195,21,153,101,201,156,43,16,122,174,228,11,196,122,154,144,144,68,66,167,122,203,38,160,151,219,2,18,204,25,202,204,228,226,142,103,6,46,39,38,77,174,168,127,0,243,131,126,183,179,65,198,194,197,143,241,252,145,36,93,19,90,35,23,90,170,84,60,45,52,215,64,206,66,82,159,103,43,155,238,162,236,26,222,200,249,121,171,106,72,44,55,139,242,66,111,3,242,209,237,120,10,180,81,2,153,63,145,92,104,18,27,229,170,202,50,213,169,20,167,133,34,192,234,172,115,191,5,254,79,97,64,118,59,130,74,142,162,194,83,125,29,106,197,18,9,172,185,201,52,69,101,65,240,187,195,5,100,72,66,74,247,25,74,131,13,135,68,32,91,117,65,111,75,80,67,41,4,254,35,97,192,16,94,245,75,199,70,196,204,33,168,111,189,112,119,99,37,115,236,191,114,200,119,161,251,103,80,112,196,59,54,45,163,87,195,51,90,241,49,76,224,57,104,80,180,113,7,229,242,178,22,210,175,204,40,246,46,244,48,100,74,156,3,161,118,145,146,85,244,14,177,193,209,224,221,79,213,44,18,165,81,48,26,236,67,180,30,69,139,64,1,79,192,130,91,179,96,21,39,220,184,59,186,175,81,195,61,107,110,5,100,54,167,161,245,188,150,208,3,49,163,129,221,26,12,108,64,97,183,120,118,171,179,148,83,156,100,197,245,208,123,180,155,227,121,104,144,125,241,105,86,1,116,107,221,90,155,118,209,20,180,192,47,228,154,235,141,171,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCheckParentMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b4dc5981-f9c6-44da-a616-2ab08ee80356"),
				Name = "CheckParent",
				CreatedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,205,138,194,64,12,199,207,45,244,29,70,79,45,44,190,128,31,151,174,168,176,44,133,93,189,135,78,196,44,211,169,100,50,66,89,124,119,103,108,85,244,36,228,146,228,255,241,59,1,171,35,183,127,88,203,70,171,185,90,90,33,233,38,43,148,223,238,136,186,108,141,111,236,14,140,199,217,202,147,94,228,131,224,167,62,96,3,81,87,49,53,192,93,175,252,134,6,243,162,152,102,233,41,6,3,163,125,51,119,92,93,197,213,141,101,28,67,104,175,242,7,221,104,126,79,44,212,127,150,38,95,228,164,183,171,250,64,70,15,102,183,209,46,84,174,9,25,56,60,106,48,195,103,43,100,72,8,93,4,41,159,44,159,238,209,244,177,117,200,101,107,109,216,168,181,145,36,137,40,163,215,150,73,16,9,144,13,222,27,88,79,150,48,138,103,171,132,61,70,247,57,75,195,12,199,61,24,135,211,11,196,113,61,128,122,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateChildrenMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3a93ca71-915f-4e90-90e6-9457ddb3aa68"),
				Name = "UpdateChildren",
				CreatedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				CreatedInPackageId = new Guid("61c8641f-c044-4b81-ab30-bcda839818c3"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8b3f5f5f-d4b8-4d70-b734-78881d247621"),
				Name = "projectId",
				CreatedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				ModifiedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("61c8641f-c044-4b81-ab30-bcda839818c3")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a4091a94-7b0a-43ab-ad4d-99ea8124c3c4"),
				Name = "newContactId",
				CreatedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				ModifiedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("61c8641f-c044-4b81-ab30-bcda839818c3")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3194d6df-fa75-4629-b594-d8bc637443fc"),
				Name = "newAccountId",
				CreatedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				ModifiedInSchemaUId = new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("61c8641f-c044-4b81-ab30-bcda839818c3")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,205,106,195,48,16,132,207,246,83,108,116,146,192,232,5,138,11,197,13,169,111,41,197,244,44,164,45,81,145,37,163,159,212,161,244,221,187,166,38,193,45,213,73,218,217,249,134,145,125,3,62,197,240,142,58,247,6,118,45,28,138,53,114,63,78,249,34,224,179,174,206,42,130,62,89,103,142,63,75,169,55,9,90,120,178,24,85,36,65,43,183,42,67,182,206,102,139,73,30,48,119,27,203,99,186,101,52,67,194,216,5,239,233,101,131,23,242,5,29,93,249,12,237,61,120,252,128,231,130,241,114,84,81,141,152,49,242,89,136,187,186,226,139,50,76,70,101,228,91,64,3,108,205,97,162,174,150,67,196,204,25,109,100,181,4,178,6,186,224,202,232,229,13,74,180,171,78,128,165,51,19,27,251,131,214,161,248,255,237,87,253,143,253,245,132,17,57,35,231,58,169,100,239,249,239,63,20,160,210,90,72,200,253,140,186,80,51,106,250,245,13,111,208,39,161,145,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Project_Project_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4042bf9a-90d2-49d5-ae63-91193f53fe69"));
		}

		#endregion

	}

	#endregion

}

