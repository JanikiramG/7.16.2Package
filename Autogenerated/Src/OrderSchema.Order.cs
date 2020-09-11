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

	#region Class: Order_Order_TerrasoftSchema

	/// <exclude/>
	public class Order_Order_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public Order_Order_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Order_Order_TerrasoftSchema(Order_Order_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Order_Order_TerrasoftSchema(Order_Order_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			RealUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			Name = "Order_Order_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445");
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
			if (Columns.FindByUId(new Guid("c7000dc3-98ae-4f74-a43e-78e959604c29")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("0fd688be-10f3-4c9b-a9ce-3eab4a4eaaf5")) == null) {
				Columns.Add(CreateDateColumn());
			}
			if (Columns.FindByUId(new Guid("b3fc6240-4ba6-4d99-808c-c090d13862f7")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("f0989427-15ec-454f-9895-3ecd431d0959")) == null) {
				Columns.Add(CreatePaymentStatusColumn());
			}
			if (Columns.FindByUId(new Guid("66bfb36b-300e-4dc1-8693-df090fde2d30")) == null) {
				Columns.Add(CreateDeliveryStatusColumn());
			}
			if (Columns.FindByUId(new Guid("8e8985ca-8d3e-4cc0-9cba-246633902169")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("4a418844-a3ec-4ef2-8d9a-aa333a5139a1")) == null) {
				Columns.Add(CreateDueDateColumn());
			}
			if (Columns.FindByUId(new Guid("62de58be-fb36-493d-a499-ea71d7ae2be4")) == null) {
				Columns.Add(CreateActualDateColumn());
			}
			if (Columns.FindByUId(new Guid("e8baae01-73b8-43c4-b4ca-f653c1c4bb94")) == null) {
				Columns.Add(CreateCurrencyColumn());
			}
			if (Columns.FindByUId(new Guid("1b70c1f1-6805-49dd-a73c-b00e46c6ff63")) == null) {
				Columns.Add(CreateCurrencyRateColumn());
			}
			if (Columns.FindByUId(new Guid("f397997e-a5b6-474d-a12f-9a1449c29e96")) == null) {
				Columns.Add(CreateAmountColumn());
			}
			if (Columns.FindByUId(new Guid("13efad8a-9522-412b-9f0e-2e43df125406")) == null) {
				Columns.Add(CreatePaymentAmountColumn());
			}
			if (Columns.FindByUId(new Guid("b275e869-f951-4f7b-9392-7457f4bf625e")) == null) {
				Columns.Add(CreatePrimaryAmountColumn());
			}
			if (Columns.FindByUId(new Guid("8007a0cc-f7b8-4a7c-a0c5-3bf80805c813")) == null) {
				Columns.Add(CreatePrimaryPaymentAmountColumn());
			}
			if (Columns.FindByUId(new Guid("fd306048-13d8-4ad4-a640-fda378a74693")) == null) {
				Columns.Add(CreateSourceOrderColumn());
			}
			if (Columns.FindByUId(new Guid("d56f1b6b-3d46-4a42-ac08-3014c569f314")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("673e7526-3356-4a7b-aa14-78592983118e")) == null) {
				Columns.Add(CreateDeliveryAddressColumn());
			}
			if (Columns.FindByUId(new Guid("3a54989b-8245-4321-a561-e683f4348bd0")) == null) {
				Columns.Add(CreateDeliveryTypeColumn());
			}
			if (Columns.FindByUId(new Guid("c55f4de9-a44b-4665-bb42-cfa8f66454f3")) == null) {
				Columns.Add(CreatePaymentTypeColumn());
			}
			if (Columns.FindByUId(new Guid("6d877814-c8af-40be-9532-770586e78936")) == null) {
				Columns.Add(CreateReceiverNameColumn());
			}
			if (Columns.FindByUId(new Guid("3d670e44-d54a-4d61-a087-e6ebbecbb208")) == null) {
				Columns.Add(CreateCommentColumn());
			}
			if (Columns.FindByUId(new Guid("4e5c0375-c940-49b0-9859-424b89e5cbcd")) == null) {
				Columns.Add(CreateContactNumberColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			column.CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			column.CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			column.CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			column.CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			column.CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			column.CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("df2849fa-59d7-44cf-bbd3-43d665480846"),
				Name = @"Number",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445"),
				IsTrackChangesInDB = true
			};
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c7000dc3-98ae-4f74-a43e-78e959604c29"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445"),
				IsTrackChangesInDB = true
			};
		}

		protected virtual EntitySchemaColumn CreateDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("0fd688be-10f3-4c9b-a9ce-3eab4a4eaaf5"),
				Name = @"Date",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445"),
				IsTrackChangesInDB = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDateTime")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("81c8e318-76ac-4895-9a9b-9760b27c55ea"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b3fc6240-4ba6-4d99-808c-c090d13862f7"),
				Name = @"Status",
				ReferenceSchemaUId = new Guid("41201050-146e-47a5-8952-c3d0242e0787"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"OrderStatusDef"
				}
			};
		}

		protected virtual EntitySchemaColumn CreatePaymentStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f0989427-15ec-454f-9895-3ecd431d0959"),
				Name = @"PaymentStatus",
				ReferenceSchemaUId = new Guid("c121173e-9034-4066-aede-682a4ce8fa88"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"OrderPaymentStatusDef"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateDeliveryStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("66bfb36b-300e-4dc1-8693-df090fde2d30"),
				Name = @"DeliveryStatus",
				ReferenceSchemaUId = new Guid("40955b77-5ef4-480c-95fb-49dfbd502c09"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"OrderDeliveryStatusDef"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8e8985ca-8d3e-4cc0-9cba-246633902169"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			};
		}

		protected virtual EntitySchemaColumn CreateDueDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("4a418844-a3ec-4ef2-8d9a-aa333a5139a1"),
				Name = @"DueDate",
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			};
		}

		protected virtual EntitySchemaColumn CreateActualDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("62de58be-fb36-493d-a499-ea71d7ae2be4"),
				Name = @"ActualDate",
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			};
		}

		protected virtual EntitySchemaColumn CreateCurrencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e8baae01-73b8-43c4-b4ca-f653c1c4bb94"),
				Name = @"Currency",
				ReferenceSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"PrimaryCurrency"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateCurrencyRateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float8")) {
				UId = new Guid("1b70c1f1-6805-49dd-a73c-b00e46c6ff63"),
				Name = @"CurrencyRate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"1"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("f397997e-a5b6-474d-a12f-9a1449c29e96"),
				Name = @"Amount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			};
		}

		protected virtual EntitySchemaColumn CreatePaymentAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("13efad8a-9522-412b-9f0e-2e43df125406"),
				Name = @"PaymentAmount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("b275e869-f951-4f7b-9392-7457f4bf625e"),
				Name = @"PrimaryAmount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryPaymentAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("8007a0cc-f7b8-4a7c-a0c5-3bf80805c813"),
				Name = @"PrimaryPaymentAmount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			};
		}

		protected virtual EntitySchemaColumn CreateSourceOrderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fd306048-13d8-4ad4-a640-fda378a74693"),
				Name = @"SourceOrder",
				ReferenceSchemaUId = new Guid("ccfa0e1e-c7fb-4251-8fbc-b59e0817f7ed"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("d56f1b6b-3d46-4a42-ac08-3014c569f314"),
				Name = @"Notes",
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb")
			};
		}

		protected virtual EntitySchemaColumn CreateDeliveryAddressColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("673e7526-3356-4a7b-aa14-78592983118e"),
				Name = @"DeliveryAddress",
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("d6ad04c1-fa0b-4adb-bfd8-17ec17775a03")
			};
		}

		protected virtual EntitySchemaColumn CreateDeliveryTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3a54989b-8245-4321-a561-e683f4348bd0"),
				Name = @"DeliveryType",
				ReferenceSchemaUId = new Guid("dc257b41-06e9-468a-9ec2-39d4fcc920aa"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("dc9b0a8f-3f62-409f-a803-948a13d96822"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"50df77d0-7b1f-4dbc-a02d-7b6ebb95dfd0"
				}
			};
		}

		protected virtual EntitySchemaColumn CreatePaymentTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c55f4de9-a44b-4665-bb42-cfa8f66454f3"),
				Name = @"PaymentType",
				ReferenceSchemaUId = new Guid("9d6072ff-8b5d-4fb8-83df-f07b403028e7"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("dc9b0a8f-3f62-409f-a803-948a13d96822"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"c2d88243-685d-4e8b-a533-73f4cb8e869b"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateReceiverNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("6d877814-c8af-40be-9532-770586e78936"),
				Name = @"ReceiverName",
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("dc9b0a8f-3f62-409f-a803-948a13d96822")
			};
		}

		protected virtual EntitySchemaColumn CreateCommentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("3d670e44-d54a-4d61-a087-e6ebbecbb208"),
				Name = @"Comment",
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("dc9b0a8f-3f62-409f-a803-948a13d96822")
			};
		}

		protected virtual EntitySchemaColumn CreateContactNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("4e5c0375-c940-49b0-9859-424b89e5cbcd"),
				Name = @"ContactNumber",
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("dc9b0a8f-3f62-409f-a803-948a13d96822")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOrder_Order_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateOrder_Order_TerrasoftEventsProcessSchema() {
			var schema = new Order_Order_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Order_Order_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Order_OrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Order_Order_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Order_Order_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("80294582-06b5-4faa-a85f-3323e5536b71"));
		}

		#endregion

	}

	#endregion

	#region Class: Order_Order_Terrasoft

	/// <summary>
	/// Order.
	/// </summary>
	public class Order_Order_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public Order_Order_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Order_Order_Terrasoft";
		}

		public Order_Order_Terrasoft(Order_Order_Terrasoft source)
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
		/// Date.
		/// </summary>
		public DateTime Date {
			get {
				return GetTypedColumnValue<DateTime>("Date");
			}
			set {
				SetColumnValue("Date", value);
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

		private OrderStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public OrderStatus Status {
			get {
				return _status ??
					(_status = LookupColumnEntities.GetEntity("Status") as OrderStatus);
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

		private OrderPaymentStatus _paymentStatus;
		/// <summary>
		/// Payment status.
		/// </summary>
		public OrderPaymentStatus PaymentStatus {
			get {
				return _paymentStatus ??
					(_paymentStatus = LookupColumnEntities.GetEntity("PaymentStatus") as OrderPaymentStatus);
			}
		}

		/// <exclude/>
		public Guid DeliveryStatusId {
			get {
				return GetTypedColumnValue<Guid>("DeliveryStatusId");
			}
			set {
				SetColumnValue("DeliveryStatusId", value);
				_deliveryStatus = null;
			}
		}

		/// <exclude/>
		public string DeliveryStatusName {
			get {
				return GetTypedColumnValue<string>("DeliveryStatusName");
			}
			set {
				SetColumnValue("DeliveryStatusName", value);
				if (_deliveryStatus != null) {
					_deliveryStatus.Name = value;
				}
			}
		}

		private OrderDeliveryStatus _deliveryStatus;
		/// <summary>
		/// Delivery status.
		/// </summary>
		public OrderDeliveryStatus DeliveryStatus {
			get {
				return _deliveryStatus ??
					(_deliveryStatus = LookupColumnEntities.GetEntity("DeliveryStatus") as OrderDeliveryStatus);
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
		/// Planned end date.
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
		/// Actual end date.
		/// </summary>
		public DateTime ActualDate {
			get {
				return GetTypedColumnValue<DateTime>("ActualDate");
			}
			set {
				SetColumnValue("ActualDate", value);
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
		/// Total.
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
		/// Total, base currency.
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
		public Guid SourceOrderId {
			get {
				return GetTypedColumnValue<Guid>("SourceOrderId");
			}
			set {
				SetColumnValue("SourceOrderId", value);
				_sourceOrder = null;
			}
		}

		/// <exclude/>
		public string SourceOrderName {
			get {
				return GetTypedColumnValue<string>("SourceOrderName");
			}
			set {
				SetColumnValue("SourceOrderName", value);
				if (_sourceOrder != null) {
					_sourceOrder.Name = value;
				}
			}
		}

		private SourceOrder _sourceOrder;
		/// <summary>
		/// Order channel.
		/// </summary>
		public SourceOrder SourceOrder {
			get {
				return _sourceOrder ??
					(_sourceOrder = LookupColumnEntities.GetEntity("SourceOrder") as SourceOrder);
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
		/// Delivery address.
		/// </summary>
		public string DeliveryAddress {
			get {
				return GetTypedColumnValue<string>("DeliveryAddress");
			}
			set {
				SetColumnValue("DeliveryAddress", value);
			}
		}

		/// <exclude/>
		public Guid DeliveryTypeId {
			get {
				return GetTypedColumnValue<Guid>("DeliveryTypeId");
			}
			set {
				SetColumnValue("DeliveryTypeId", value);
				_deliveryType = null;
			}
		}

		/// <exclude/>
		public string DeliveryTypeName {
			get {
				return GetTypedColumnValue<string>("DeliveryTypeName");
			}
			set {
				SetColumnValue("DeliveryTypeName", value);
				if (_deliveryType != null) {
					_deliveryType.Name = value;
				}
			}
		}

		private DeliveryType _deliveryType;
		/// <summary>
		/// Delivery type.
		/// </summary>
		public DeliveryType DeliveryType {
			get {
				return _deliveryType ??
					(_deliveryType = LookupColumnEntities.GetEntity("DeliveryType") as DeliveryType);
			}
		}

		/// <exclude/>
		public Guid PaymentTypeId {
			get {
				return GetTypedColumnValue<Guid>("PaymentTypeId");
			}
			set {
				SetColumnValue("PaymentTypeId", value);
				_paymentType = null;
			}
		}

		/// <exclude/>
		public string PaymentTypeName {
			get {
				return GetTypedColumnValue<string>("PaymentTypeName");
			}
			set {
				SetColumnValue("PaymentTypeName", value);
				if (_paymentType != null) {
					_paymentType.Name = value;
				}
			}
		}

		private PaymentType _paymentType;
		/// <summary>
		/// Payment type.
		/// </summary>
		public PaymentType PaymentType {
			get {
				return _paymentType ??
					(_paymentType = LookupColumnEntities.GetEntity("PaymentType") as PaymentType);
			}
		}

		/// <summary>
		/// Recipient's name.
		/// </summary>
		public string ReceiverName {
			get {
				return GetTypedColumnValue<string>("ReceiverName");
			}
			set {
				SetColumnValue("ReceiverName", value);
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string Comment {
			get {
				return GetTypedColumnValue<string>("Comment");
			}
			set {
				SetColumnValue("Comment", value);
			}
		}

		/// <summary>
		/// Phone.
		/// </summary>
		public string ContactNumber {
			get {
				return GetTypedColumnValue<string>("ContactNumber");
			}
			set {
				SetColumnValue("ContactNumber", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Order_OrderEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Order_Order_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("Order_Order_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Order_Order_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Order_Order_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Order_Order_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Order_Order_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Order_OrderEventsProcess

	/// <exclude/>
	public partial class Order_OrderEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : Order_Order_Terrasoft
	{

		#region Class: GenerateNumberUserTaskFlowElement

		/// <exclude/>
		public class GenerateNumberUserTaskFlowElement : GenerateSequenseNumberUserTask
		{

			public GenerateNumberUserTaskFlowElement(UserConnection userConnection, Order_OrderEventsProcess<TEntity> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "GenerateNumberUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("967540d2-9cfe-4217-83c7-32b09ff47d39");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public Order_OrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Order_OrderEventsProcess";
			SchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
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

		public virtual bool CanGenerateAnniversaryReminding {
			get;
			set;
		}

		public virtual Object EntityChangedColumns {
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
					SchemaElementUId = new Guid("ceb5e226-f35f-495b-bdbf-4df1e1f28384"),
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
					SchemaElementUId = new Guid("6902d6d9-dbc8-49db-b186-f234b870d541"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent1 {
			get {
				return _intermediateThrowMessageEvent1 ?? (_intermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("0f7b2f51-711d-435a-9dfa-58eb8cbef95f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OrderSaving",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("e2a17606-4f8e-4013-8e08-bc1121473859"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
				});
			}
		}

		private ProcessScriptTask _scriptTask3;
		public ProcessScriptTask ScriptTask3 {
			get {
				return _scriptTask3 ?? (_scriptTask3 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3",
					SchemaElementUId = new Guid("acf2c364-3dee-49f6-a184-f58bc5eee6ea"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3Execute,
				});
			}
		}

		private GenerateNumberUserTaskFlowElement _generateNumberUserTask;
		public GenerateNumberUserTaskFlowElement GenerateNumberUserTask {
			get {
				return _generateNumberUserTask ?? (_generateNumberUserTask = new GenerateNumberUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _scriptTask4;
		public ProcessScriptTask ScriptTask4 {
			get {
				return _scriptTask4 ?? (_scriptTask4 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4",
					SchemaElementUId = new Guid("61f0f115-952c-4eed-bce3-8bfa206aac76"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4Execute,
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
					SchemaElementUId = new Guid("7c23a4bf-41cc-4705-bdd2-30444a2634e2"),
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

		private ProcessTerminateEvent _terminate1;
		public ProcessTerminateEvent Terminate1 {
			get {
				return _terminate1 ?? (_terminate1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate1",
					SchemaElementUId = new Guid("56754eee-89d3-4689-8152-ac8372843639"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask5;
		public ProcessScriptTask ScriptTask5 {
			get {
				return _scriptTask5 ?? (_scriptTask5 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask5",
					SchemaElementUId = new Guid("62b59ee1-80a5-4e88-9af4-23074addc3d9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask5Execute,
				});
			}
		}

		private ProcessScriptTask _init;
		public ProcessScriptTask Init {
			get {
				return _init ?? (_init = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "Init",
					SchemaElementUId = new Guid("127f9985-3bc7-414d-bb5a-bc9070c29bb8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitExecute,
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
					SchemaElementUId = new Guid("b0cecfc7-7597-4062-8bc0-c9d8b2d9600d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _orderSavedStartMessage;
		public ProcessFlowElement OrderSavedStartMessage {
			get {
				return _orderSavedStartMessage ?? (_orderSavedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OrderSavedStartMessage",
					SchemaElementUId = new Guid("e9a16780-d67b-43c8-8f9b-871a344f47cb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _orderSavedIntermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent OrderSavedIntermediateThrowMessageEvent1 {
			get {
				return _orderSavedIntermediateThrowMessageEvent1 ?? (_orderSavedIntermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "OrderSavedIntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("7b80c346-d9db-45da-aa84-122dc530d472"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OrderSaved",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("77bb4754-f3f4-4897-9f2a-9ef5b1e1b325"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
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
					SchemaElementUId = new Guid("5f5d98a4-71dc-41e0-9ee0-9afed6972599"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateRemindingsExecute,
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow1;
		public ProcessConditionalFlow ConditionalFlow1 {
			get {
				return _conditionalFlow1 ?? (_conditionalFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow1",
					SchemaElementUId = new Guid("657b0b4f-51e3-4766-a029-24443144deb2"),
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
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[ScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3 };
			FlowElements[GenerateNumberUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { GenerateNumberUserTask };
			FlowElements[ScriptTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[ScriptTask5.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask5 };
			FlowElements[Init.SchemaElementUId] = new Collection<ProcessFlowElement> { Init };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[OrderSavedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OrderSavedStartMessage };
			FlowElements[OrderSavedIntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { OrderSavedIntermediateThrowMessageEvent1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[UpdateRemindings.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateRemindings };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess2":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("Init");
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ScriptTask2":
						e.Context.QueueTasks.Enqueue("ScriptTask5");
						break;
					case "ScriptTask3":
						e.Context.QueueTasks.Enqueue("GenerateNumberUserTask");
						break;
					case "GenerateNumberUserTask":
							e.Context.QueueTasks.Enqueue("ScriptTask4");
						break;
					case "ScriptTask4":
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptTask3");
							break;
						}
						e.Context.QueueTasks.Enqueue("Terminate1");
						break;
					case "Terminate1":
						break;
					case "ScriptTask5":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "Init":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "EventSubProcess1":
						break;
					case "OrderSavedStartMessage":
						e.Context.QueueTasks.Enqueue("UpdateRemindings");
						break;
					case "OrderSavedIntermediateThrowMessageEvent1":
						break;
					case "ScriptTask1":
						e.Context.QueueTasks.Enqueue("OrderSavedIntermediateThrowMessageEvent1");
						break;
					case "UpdateRemindings":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(string.IsNullOrEmpty(Entity.GetTypedColumnValue<string>("Number")));
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage1");
			ActivatedEventElements.Add("OrderSavedStartMessage");
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
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OrderSaving");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
					break;
				case "ScriptTask3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3";
					result = ScriptTask3.Execute(context, ScriptTask3Execute);
					break;
				case "GenerateNumberUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "GenerateNumberUserTask";
					result = GenerateNumberUserTask.Execute(context);
					break;
				case "ScriptTask4":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4";
					result = ScriptTask4.Execute(context, ScriptTask4Execute);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "Terminate1":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptTask5":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask5";
					result = ScriptTask5.Execute(context, ScriptTask5Execute);
					break;
				case "Init":
					context.QueueTasks.Dequeue();
					context.SenderName = "Init";
					result = Init.Execute(context, InitExecute);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "OrderSavedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OrderSavedStartMessage";
					result = OrderSavedStartMessage.Execute(context);
					break;
				case "OrderSavedIntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OrderSaved");
					result = OrderSavedIntermediateThrowMessageEvent1.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "UpdateRemindings":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateRemindings";
					result = UpdateRemindings.Execute(context, UpdateRemindingsExecute);
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
				case "NeedFinRecalc":
					NeedFinRecalc = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			return ChangeStatus();
		}

		public virtual bool ScriptTask3Execute(ProcessExecutingContext context) {
			return SetNumberGenerationParams();
		}

		public virtual bool ScriptTask4Execute(ProcessExecutingContext context) {
			return UpdateNumber();
		}

		public virtual bool ScriptTask5Execute(ProcessExecutingContext context) {
			return CalculatePrimaryAmount();
		}

		public virtual bool InitExecute(ProcessExecutingContext context) {
			InitCanGenerateAnniversaryReminding();
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			UpdateProductAmounts();
			return true;
		}

		public virtual bool UpdateRemindingsExecute(ProcessExecutingContext context) {
			return UpdateReminders();
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Order_Order_TerrasoftSaving":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
					case "Order_Order_TerrasoftSaved":
							if (ActivatedEventElements.Contains("OrderSavedStartMessage")) {
							context.QueueTasks.Enqueue("OrderSavedStartMessage");
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

	#region Class: Order_OrderEventsProcess

	/// <exclude/>
	public class Order_OrderEventsProcess : Order_OrderEventsProcess<Order_Order_Terrasoft>
	{

		public Order_OrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Order_Order_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Order_Order_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public Order_Order_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Order_Order_TerrasoftEventsProcessSchema(Order_Order_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Order_OrderEventsProcess";
			UId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b");
			CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445");
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

		protected virtual ProcessSchemaParameter CreateNeedFinRecalcParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9fc7152d-0b2b-456d-8471-0ddeea7ca415"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Name = @"NeedFinRecalc",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCanGenerateAnniversaryRemindingParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("cefeb6cc-f154-4915-a160-9133d81b6b24"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Name = @"CanGenerateAnniversaryReminding",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityChangedColumnsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e6ea397b-1ece-4edb-b105-38f5611d64fa"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Name = @"EntityChangedColumns",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateNeedFinRecalcParameter());
			Parameters.Add(CreateCanGenerateAnniversaryRemindingParameter());
			Parameters.Add(CreateEntityChangedColumnsParameter());
		}

		protected virtual void InitializeGenerateNumberUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("435efaac-bfb2-4950-ae5d-dfbe01638875"),
				ContainerUId = new Guid("967540d2-9cfe-4217-83c7-32b09ff47d39"),
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
				UId = new Guid("c5a0485c-d837-4b09-80a6-601d7407dfff"),
				ContainerUId = new Guid("967540d2-9cfe-4217-83c7-32b09ff47d39"),
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
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess2.FlowElements.Add(startmessage1);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess2.FlowElements.Add(scripttask2);
			ProcessSchemaScriptTask scripttask3 = CreateScriptTask3ScriptTask();
			eventsubprocess2.FlowElements.Add(scripttask3);
			ProcessSchemaUserTask generatenumberusertask = CreateGenerateNumberUserTaskUserTask();
			eventsubprocess2.FlowElements.Add(generatenumberusertask);
			ProcessSchemaScriptTask scripttask4 = CreateScriptTask4ScriptTask();
			eventsubprocess2.FlowElements.Add(scripttask4);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			eventsubprocess2.FlowElements.Add(exclusivegateway1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			eventsubprocess2.FlowElements.Add(terminate1);
			ProcessSchemaScriptTask scripttask5 = CreateScriptTask5ScriptTask();
			eventsubprocess2.FlowElements.Add(scripttask5);
			ProcessSchemaScriptTask init = CreateInitScriptTask();
			eventsubprocess2.FlowElements.Add(init);
			ProcessSchemaStartMessageEvent ordersavedstartmessage = CreateOrderSavedStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(ordersavedstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent ordersavedintermediatethrowmessageevent1 = CreateOrderSavedIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(ordersavedintermediatethrowmessageevent1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			ProcessSchemaScriptTask updateremindings = CreateUpdateRemindingsScriptTask();
			eventsubprocess1.FlowElements.Add(updateremindings);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlowPrAmountToSequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlowPrAmountFromSequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9_17b54d343f434c88864e6b147323ea3cSequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("0f6d14f3-4a43-457c-975a-d6ecefdf14c2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CurveCenterPosition = new Point(133, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e9a16780-d67b-43c8-8f9b-871a344f47cb"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5f5d98a4-71dc-41e0-9ee0-9afed6972599"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(119, 398));
			schemaFlow.PolylinePointPositions.Add(new Point(119, 310));
			schemaFlow.PolylinePointPositions.Add(new Point(157, 310));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("cea5d920-6485-43bb-bccb-696924dacb3c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CurveCenterPosition = new Point(255, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("77bb4754-f3f4-4897-9f2a-9ef5b1e1b325"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7b80c346-d9db-45da-aa84-122dc530d472"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(225, 487));
			schemaFlow.PolylinePointPositions.Add(new Point(225, 481));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("10ab79d7-5646-4c31-b37a-f5b1e1c00a9b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CurveCenterPosition = new Point(138, 257),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6902d6d9-dbc8-49db-b186-f234b870d541"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("127f9985-3bc7-414d-bb5a-bc9070c29bb8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowPrAmountToSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowPrAmountTo",
				UId = new Guid("40827c95-c3a4-40aa-90ef-52040fb4af83"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CurveCenterPosition = new Point(260, 262),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e2a17606-4f8e-4013-8e08-bc1121473859"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("62b59ee1-80a5-4e88-9af4-23074addc3d9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("3b9c347c-5b70-4a22-8bf5-03b620e6a023"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CurveCenterPosition = new Point(602, 184),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("967540d2-9cfe-4217-83c7-32b09ff47d39"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("61f0f115-952c-4eed-bce3-8bfa206aac76"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("657b0b4f-51e3-4766-a029-24443144deb2"),
				ConditionExpression = @"string.IsNullOrEmpty(Entity.GetTypedColumnValue<string>(""Number""))",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CurveCenterPosition = new Point(444, 228),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7c23a4bf-41cc-4705-bdd2-30444a2634e2"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("acf2c364-3dee-49f6-a184-f58bc5eee6ea"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow6",
				UId = new Guid("d4ff9301-02d3-4c52-94e7-e3306ad216b7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CurveCenterPosition = new Point(357, 306),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7c23a4bf-41cc-4705-bdd2-30444a2634e2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("56754eee-89d3-4689-8152-ac8372843639"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("9df4bef6-6a76-4903-9e0b-ecc84e92ac6c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("d6ad04c1-fa0b-4adb-bfd8-17ec17775a03"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CurveCenterPosition = new Point(431, 206),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("acf2c364-3dee-49f6-a184-f58bc5eee6ea"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("967540d2-9cfe-4217-83c7-32b09ff47d39"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("7f0d7e39-4053-4b33-aa78-f038b0e2ce07"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("d6ad04c1-fa0b-4adb-bfd8-17ec17775a03"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CurveCenterPosition = new Point(334, 426),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0f7b2f51-711d-435a-9dfa-58eb8cbef95f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7c23a4bf-41cc-4705-bdd2-30444a2634e2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowPrAmountFromSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowPrAmountFrom",
				UId = new Guid("4ea872df-74d1-4a9a-b40e-315a5184cfff"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("62033795-80ad-4927-88b6-250dc62d8011"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("62b59ee1-80a5-4e88-9af4-23074addc3d9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0f7b2f51-711d-435a-9dfa-58eb8cbef95f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("2f90782d-daae-4133-b391-c5927932953a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("62033795-80ad-4927-88b6-250dc62d8011"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5f5d98a4-71dc-41e0-9ee0-9afed6972599"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("77bb4754-f3f4-4897-9f2a-9ef5b1e1b325"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(221, 367));
			schemaFlow.PolylinePointPositions.Add(new Point(221, 430));
			schemaFlow.PolylinePointPositions.Add(new Point(157, 430));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9_17b54d343f434c88864e6b147323ea3cSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9_17b54d343f434c88864e6b147323ea3c",
				UId = new Guid("17b54d34-3f43-4c88-864e-6b147323ea3c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e8c4bc03-2f14-47b7-8005-47fab57cc1b8"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("127f9985-3bc7-414d-bb5a-bc9070c29bb8"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e2a17606-4f8e-4013-8e08-bc1121473859"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("8915d376-8dbf-437f-ba3a-95e3f178f554"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("e23c4f1d-71a4-47b6-a6da-c930e283a640"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("8915d376-8dbf-437f-ba3a-95e3f178f554"),
				CreatedInOwnerSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Name = @"Lane2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ceb5e226-f35f-495b-bdbf-4df1e1f28384"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e23c4f1d-71a4-47b6-a6da-c930e283a640"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(1562, 240),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6902d6d9-dbc8-49db-b186-f234b870d541"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ceb5e226-f35f-495b-bdbf-4df1e1f28384"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OrderSaving",
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(15, 63),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("0f7b2f51-711d-435a-9dfa-58eb8cbef95f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ceb5e226-f35f-495b-bdbf-4df1e1f28384"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OrderSaving",
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(413, 63),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e2a17606-4f8e-4013-8e08-bc1121473859"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ceb5e226-f35f-495b-bdbf-4df1e1f28384"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Name = @"ScriptTask2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(171, 49),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,206,72,204,75,79,13,46,73,44,41,45,214,208,180,6,0,182,64,69,192,22,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("acf2c364-3dee-49f6-a184-f58bc5eee6ea"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ceb5e226-f35f-495b-bdbf-4df1e1f28384"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Name = @"ScriptTask3",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(638, 49),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,78,45,241,43,205,77,74,45,114,79,205,75,45,74,44,201,204,207,11,72,44,74,204,45,214,208,180,6,0,75,73,38,28,35,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateGenerateNumberUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("967540d2-9cfe-4217-83c7-32b09ff47d39"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ceb5e226-f35f-495b-bdbf-4df1e1f28384"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Name = @"GenerateNumberUserTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(811, 49),
				SchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false
			};
			InitializeGenerateNumberUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask4ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("61f0f115-952c-4eed-bce3-8bfa206aac76"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ceb5e226-f35f-495b-bdbf-4df1e1f28384"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Name = @"ScriptTask4",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(971, 49),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,45,72,73,44,73,245,43,205,77,74,45,210,208,180,6,0,84,121,207,240,22,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("7c23a4bf-41cc-4705-bdd2-30444a2634e2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ceb5e226-f35f-495b-bdbf-4df1e1f28384"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(480, 49),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("56754eee-89d3-4689-8152-ac8372843639"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ceb5e226-f35f-495b-bdbf-4df1e1f28384"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Name = @"Terminate1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(494, 153),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask5ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("62b59ee1-80a5-4e88-9af4-23074addc3d9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ceb5e226-f35f-495b-bdbf-4df1e1f28384"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("62033795-80ad-4927-88b6-250dc62d8011"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Name = @"ScriptTask5",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(302, 49),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,78,204,73,46,205,73,44,73,13,40,202,204,77,44,170,116,204,205,47,205,43,209,208,180,6,0,201,248,70,52,32,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("127f9985-3bc7-414d-bb5a-bc9070c29bb8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ceb5e226-f35f-495b-bdbf-4df1e1f28384"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e8c4bc03-2f14-47b7-8005-47fab57cc1b8"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Name = @"Init",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(69, 49),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,204,203,44,113,78,204,115,79,205,75,45,74,44,73,117,204,203,203,44,75,45,42,78,44,170,12,74,205,205,204,75,201,204,75,215,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,87,172,107,87,51,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b0cecfc7-7597-4062-8bc0-c9d8b2d9600d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e23c4f1d-71a4-47b6-a6da-c930e283a640"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 320),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(288, 280),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOrderSavedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e9a16780-d67b-43c8-8f9b-871a344f47cb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b0cecfc7-7597-4062-8bc0-c9d8b2d9600d"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OrderSaved",
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Name = @"OrderSavedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 65),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateOrderSavedIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("7b80c346-d9db-45da-aa84-122dc530d472"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b0cecfc7-7597-4062-8bc0-c9d8b2d9600d"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OrderSaved",
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Name = @"OrderSavedIntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(216, 148),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("77bb4754-f3f4-4897-9f2a-9ef5b1e1b325"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b0cecfc7-7597-4062-8bc0-c9d8b2d9600d"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(80, 140),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,72,73,44,73,13,40,202,79,41,77,46,113,204,205,47,205,43,41,214,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,246,27,227,16,37,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateRemindingsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5f5d98a4-71dc-41e0-9ee0-9afed6972599"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b0cecfc7-7597-4062-8bc0-c9d8b2d9600d"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("3b2c18d5-a5e4-4022-a755-b98a1cfd84eb"),
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				Name = @"UpdateRemindings",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(80, 20),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,45,72,73,44,73,13,74,205,205,204,75,73,45,42,214,208,180,6,0,244,251,177,124,25,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSetOrderProductCurrencyMethod());
			Methods.Add(CreateUpdateProductAmountsMethod());
			Methods.Add(CreateGetCurrencyInfoMethod());
			Methods.Add(CreateChangeStatusMethod());
			Methods.Add(CreateCalculatePrimaryAmountMethod());
			Methods.Add(CreateSetNumberGenerationParamsMethod());
			Methods.Add(CreateUpdateNumberMethod());
			Methods.Add(CreateUpdateRemindersMethod());
			Methods.Add(CreateInitCanGenerateAnniversaryRemindingMethod());
			Methods.Add(CreateGetAnniversaryDependentColumnsMethod());
			Methods.Add(CreateGetRemindingOptionsMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
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
				UId = new Guid("e367e682-e0e1-481b-90fa-2080cf131acc"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a435aadb-cccf-48cf-b82e-d0bd146a0851"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("d6ad04c1-fa0b-4adb-bfd8-17ec17775a03")
			});
		}

		protected virtual SchemaMethod CreateSetOrderProductCurrencyMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ffc4a0b6-09fd-4e67-bdc7-5723fcca3934"),
				Name = "SetOrderProductCurrency",
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CreatedInPackageId = new Guid("07098908-ab0e-4ed8-9b1d-72204639ef75"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,148,203,78,195,48,16,69,215,84,234,63,152,172,98,84,25,214,148,135,104,250,80,23,64,69,121,44,16,11,203,25,209,72,137,13,19,27,136,16,255,142,29,135,214,77,81,217,208,101,156,153,115,60,55,118,38,38,75,137,48,136,32,69,53,77,201,41,25,73,157,233,138,77,64,223,86,47,144,38,42,55,133,188,231,185,129,147,137,45,62,139,163,100,89,30,209,126,183,147,130,200,10,158,47,41,55,92,195,118,78,211,17,160,92,79,13,123,227,184,4,121,130,69,221,149,128,137,146,18,132,206,148,100,126,125,46,22,80,240,75,46,249,51,160,211,76,101,169,185,20,48,168,174,120,1,43,118,68,89,130,96,5,190,47,94,167,57,233,186,144,141,65,139,197,24,85,49,28,196,173,87,94,234,108,51,180,35,96,229,199,170,133,180,23,4,217,35,18,222,31,159,200,39,137,134,217,91,86,90,83,68,190,194,184,210,102,217,206,215,146,108,143,108,137,251,45,123,183,235,102,103,99,46,180,66,75,255,17,237,159,146,163,243,245,175,116,184,218,197,49,57,106,226,55,47,169,255,130,118,2,114,87,63,180,50,235,145,232,26,83,192,25,170,212,8,29,209,110,103,143,205,65,175,29,141,30,241,251,103,51,142,54,30,13,24,175,226,161,155,45,245,17,216,210,228,222,7,109,118,74,177,181,126,35,10,74,14,126,170,231,202,160,0,255,80,163,92,149,39,6,138,139,66,25,169,255,213,209,32,3,201,48,43,133,91,219,129,172,133,14,164,183,252,99,7,190,21,53,84,41,205,243,93,200,2,174,211,177,135,5,160,189,245,245,193,116,127,38,54,45,71,175,134,231,241,134,243,239,63,156,235,167,148,240,178,57,255,246,102,248,91,193,70,31,32,140,189,16,180,255,13,160,133,192,91,58,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateProductAmountsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("27ae649f-bb81-4a42-b370-78e5b1e5eb1e"),
				Name = "UpdateProductAmounts",
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CreatedInPackageId = new Guid("d6ad04c1-fa0b-4adb-bfd8-17ec17775a03"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,77,10,194,48,16,70,215,10,222,33,116,149,66,201,5,252,129,82,172,59,17,161,7,8,201,40,129,118,34,51,19,164,136,119,55,173,110,164,155,129,111,134,55,223,11,55,165,207,0,190,13,120,5,103,123,87,170,215,102,189,186,80,244,201,201,17,133,198,78,66,207,42,205,115,175,154,72,96,90,235,36,82,0,54,77,111,153,191,113,52,39,144,221,130,60,104,132,231,2,139,200,66,105,138,53,221,211,0,40,186,72,12,148,15,8,78,66,196,162,82,221,223,162,44,183,217,108,246,48,221,195,91,129,108,28,201,255,26,235,33,38,20,214,185,57,200,88,169,252,30,38,226,253,1,193,93,60,200,227,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetCurrencyInfoMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b4623a01-11e3-40c4-b467-5a4512299cf8"),
				Name = "GetCurrencyInfo",
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CreatedInPackageId = new Guid("62033795-80ad-4927-88b6-250dc62d8011"),
				ResultValueTypeName = "CurrencyRateInfo"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,65,107,2,65,12,133,207,245,87,44,123,154,133,50,127,64,43,200,84,197,83,193,90,239,97,54,187,12,140,153,146,73,148,253,247,157,109,65,87,91,122,76,222,227,203,123,57,3,87,94,153,145,252,176,107,171,151,106,77,18,100,176,91,148,195,240,137,173,75,81,79,116,132,168,184,216,106,104,151,166,118,87,123,221,204,103,231,9,96,15,130,239,146,24,122,44,164,3,50,67,78,157,88,151,24,237,6,124,145,2,102,235,34,228,252,51,126,31,90,76,157,212,133,94,25,36,36,178,238,55,119,105,102,79,132,151,127,224,137,178,176,142,227,138,123,61,33,137,169,53,35,23,129,208,143,220,250,185,250,184,91,52,15,61,118,212,165,82,224,143,90,99,220,149,23,133,56,205,150,205,237,133,141,221,4,206,242,198,175,216,129,70,49,133,205,40,202,116,135,159,127,1,13,31,142,234,121,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateChangeStatusMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9aae6e3b-ac69-49ef-aa01-b552761a7167"),
				Name = "ChangeStatus",
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CreatedInPackageId = new Guid("62033795-80ad-4927-88b6-250dc62d8011"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,147,77,143,211,48,16,134,207,205,175,24,114,88,37,18,178,184,119,19,169,91,10,170,132,218,170,93,224,128,56,120,157,33,49,56,206,202,118,90,69,171,254,119,198,110,90,98,237,101,47,228,20,219,243,241,188,239,216,242,23,100,43,237,164,27,216,193,117,70,234,250,224,184,67,40,10,24,215,219,167,223,40,92,216,101,27,60,229,240,146,204,12,186,222,104,112,166,199,121,114,78,190,72,235,238,173,243,209,37,136,134,235,26,171,101,167,250,86,111,120,139,22,10,24,91,124,70,183,156,30,127,227,170,71,155,229,201,236,246,177,239,13,26,204,196,177,40,197,145,133,0,120,87,0,253,111,85,21,150,81,244,99,231,155,103,57,91,118,250,136,198,45,148,162,92,40,74,159,113,105,194,60,68,62,79,54,136,213,39,169,247,40,184,18,196,244,26,148,173,181,67,99,73,110,166,241,244,227,39,188,164,203,222,24,212,98,216,147,252,244,61,220,214,233,57,103,11,61,100,84,247,200,13,80,78,111,72,225,74,215,82,147,123,240,213,162,33,36,77,181,100,167,217,199,135,67,20,49,79,158,186,78,65,195,237,94,214,141,163,132,184,130,119,106,109,47,174,29,68,131,45,191,96,174,42,233,200,101,82,217,157,176,202,210,173,169,208,120,174,29,31,90,212,97,76,189,77,137,74,210,96,223,164,112,209,118,189,118,147,26,227,198,85,32,220,221,221,56,195,240,189,94,30,98,162,193,62,14,207,209,88,239,43,20,178,229,170,204,174,45,136,42,36,63,79,251,188,181,70,12,231,75,121,133,35,71,9,31,60,230,149,170,136,91,4,234,217,245,150,211,21,252,215,32,139,141,91,87,228,67,240,116,199,197,31,94,163,191,86,214,113,237,44,11,219,108,60,156,228,176,29,151,149,231,57,3,42,139,224,177,98,133,68,247,223,17,140,147,92,169,225,198,66,175,114,250,72,255,2,166,49,202,176,231,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCalculatePrimaryAmountMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ffb8736a-80e8-4498-ab90-a55640b68b22"),
				Name = "CalculatePrimaryAmount",
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CreatedInPackageId = new Guid("62033795-80ad-4927-88b6-250dc62d8011"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,203,106,195,48,16,60,91,95,177,205,33,216,37,184,189,167,14,4,39,132,220,74,91,122,23,182,2,2,89,54,138,100,16,197,255,94,201,79,73,165,33,57,122,153,153,157,25,173,91,44,0,87,181,226,18,50,56,114,73,165,78,79,68,126,233,134,148,121,205,84,197,191,49,83,228,173,36,5,173,48,219,197,171,125,143,94,37,91,212,26,110,35,204,88,232,253,67,18,239,46,105,82,42,148,16,132,23,250,92,222,150,57,41,90,26,141,124,134,135,2,31,88,146,123,157,228,14,199,234,208,11,196,174,145,12,236,186,244,88,53,82,39,240,131,34,65,164,18,28,164,80,100,139,58,228,242,207,252,82,47,41,236,71,6,92,49,230,171,14,238,50,120,237,229,2,184,49,155,59,147,216,56,138,60,75,61,108,144,237,249,190,159,168,91,20,199,22,92,102,106,103,6,53,54,243,105,150,45,165,4,93,108,188,58,19,155,213,26,9,158,219,196,128,245,122,58,160,167,41,213,109,203,119,100,238,30,142,237,30,192,129,182,244,74,107,30,198,159,230,65,169,51,124,246,31,133,87,61,6,124,246,111,236,229,207,70,163,252,95,187,254,205,111,252,31,103,200,220,33,55,214,47,98,61,141,87,154,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetNumberGenerationParamsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f09899a0-9f07-4ff2-aded-3c6b0be58cb8"),
				Name = "SetNumberGenerationParams",
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CreatedInPackageId = new Guid("62033795-80ad-4927-88b6-250dc62d8011"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,79,205,75,45,74,44,73,245,43,205,77,74,45,10,45,78,45,10,73,44,206,214,115,205,43,201,44,169,12,78,206,72,205,77,84,176,85,128,112,245,32,124,107,174,162,212,146,210,162,60,133,146,162,210,84,107,0,63,169,196,40,65,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateNumberMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("52bad7fa-6b9e-4289-b3d8-74ba7dede487"),
				Name = "UpdateNumber",
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CreatedInPackageId = new Guid("62033795-80ad-4927-88b6-250dc62d8011"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,37,140,59,10,128,48,16,5,123,79,17,172,20,196,11,4,43,17,59,11,127,125,212,135,136,113,133,205,110,225,237,13,90,14,204,76,16,62,104,55,235,189,193,84,166,5,129,157,160,211,107,1,79,1,60,186,112,150,61,130,122,169,163,99,147,134,228,144,167,28,16,217,235,69,179,243,138,44,253,139,180,248,78,185,77,24,162,76,70,88,97,95,235,41,207,62,100,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateRemindersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e3e3d3f4-c4ea-444d-9268-b5c981950916"),
				Name = "UpdateReminders",
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CreatedInPackageId = new Guid("62033795-80ad-4927-88b6-250dc62d8011"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,193,10,194,48,16,68,207,230,43,98,79,41,72,127,160,42,72,145,226,169,32,234,61,52,171,4,218,77,217,108,148,34,254,187,41,212,122,105,97,15,203,50,111,118,24,123,151,106,93,104,44,1,129,52,195,1,209,62,129,188,166,254,12,173,69,99,241,145,202,183,88,17,112,32,148,76,1,114,241,17,101,176,70,198,217,201,35,178,229,62,43,129,47,125,7,166,112,77,104,241,166,155,0,219,65,180,87,201,201,36,105,46,42,50,64,115,246,146,126,155,31,83,56,138,190,8,47,185,200,168,171,7,42,28,34,212,108,29,110,98,148,248,98,198,40,171,186,65,224,163,97,76,56,241,227,85,45,64,83,27,53,7,221,76,212,168,255,23,241,5,185,58,11,112,62,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitCanGenerateAnniversaryRemindingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e539dfad-c818-430f-ba70-f91eb0a7dbd5"),
				Name = "InitCanGenerateAnniversaryReminding",
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CreatedInPackageId = new Guid("e8c4bc03-2f14-47b7-8005-47fab57cc1b8"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,193,10,194,48,12,134,239,130,239,208,163,94,250,2,82,65,170,120,17,5,39,222,179,45,104,101,75,165,203,148,189,189,113,235,116,42,30,147,252,223,159,252,73,189,47,148,171,182,120,87,70,173,136,29,55,58,97,31,28,157,18,6,70,101,140,138,245,46,189,96,198,109,87,139,126,54,30,221,32,168,204,23,117,73,149,208,107,228,5,145,187,97,168,32,52,75,188,34,229,72,108,59,193,100,218,3,103,160,19,230,246,197,197,173,130,219,225,232,8,69,141,29,214,41,236,55,248,233,164,15,126,227,42,110,129,244,153,10,222,199,68,73,116,248,69,23,212,76,36,136,50,243,62,143,182,158,24,156,220,45,13,189,133,18,167,79,99,11,180,70,194,32,63,24,100,221,99,233,40,151,23,137,243,223,173,179,7,215,11,55,98,107,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetAnniversaryDependentColumnsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fc26066f-6012-4a16-a2ba-9b6d7018a3c0"),
				Name = "GetAnniversaryDependentColumns",
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CreatedInPackageId = new Guid("e8c4bc03-2f14-47b7-8005-47fab57cc1b8"),
				ResultValueTypeName = "IEnumerable<string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,143,142,85,168,86,80,114,206,207,43,73,76,46,241,76,81,210,81,80,114,76,78,206,47,205,131,114,252,203,243,82,139,128,76,133,90,107,0,34,162,128,38,53,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRemindingOptionsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("42bd8ddf-793c-4534-8d16-96ecf0348cf0"),
				Name = "GetRemindingOptions",
				CreatedInSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CreatedInPackageId = new Guid("e8c4bc03-2f14-47b7-8005-47fab57cc1b8"),
				ResultValueTypeName = "IEnumerable<string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,80,77,75,195,64,16,61,167,208,255,48,244,180,1,201,31,208,164,132,224,65,40,13,244,224,69,60,44,187,99,187,144,204,202,236,38,37,72,255,187,219,117,69,162,34,230,52,240,62,230,205,155,81,50,216,87,111,44,57,40,129,240,12,59,227,252,157,243,108,232,88,137,252,118,189,26,131,68,157,36,29,81,55,182,27,250,168,188,39,111,252,212,204,97,233,62,220,137,140,232,163,236,6,172,96,187,253,90,254,147,142,57,230,5,196,60,167,168,105,18,202,118,80,86,16,70,177,151,61,66,89,194,166,61,19,242,131,222,228,57,188,173,87,89,42,80,212,90,31,174,126,17,162,158,158,35,149,181,172,145,107,34,51,34,59,201,211,1,123,67,58,148,43,106,165,236,64,190,141,230,155,191,181,141,37,47,85,210,6,233,229,122,112,198,232,7,166,207,255,5,228,178,168,69,90,250,107,15,241,207,91,242,197,169,169,246,210,212,217,183,82,234,183,254,239,144,49,211,205,76,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Order_Order_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"));
		}

		#endregion

	}

	#endregion

}

