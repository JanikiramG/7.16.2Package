﻿namespace Terrasoft.Configuration
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

	#region Class: MLModelSchema

	/// <exclude/>
	public class MLModelSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public MLModelSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MLModelSchema(MLModelSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MLModelSchema(MLModelSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b");
			RealUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b");
			Name = "MLModel";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("10e294ac-851a-4b19-b311-15fba1867b12");
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

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("9e53fd7c-dde4-4502-a64c-b9e34148108b")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("564a0aee-87ac-4689-9164-615feb8c6aa7")) == null) {
				Columns.Add(CreateTrainFrequencyColumn());
			}
			if (Columns.FindByUId(new Guid("7dcd6a05-f8cf-4f26-a162-852c0d390e12")) == null) {
				Columns.Add(CreateTrainedOnColumn());
			}
			if (Columns.FindByUId(new Guid("90154141-9251-4342-981f-4c0acf2b8557")) == null) {
				Columns.Add(CreateTriedToTrainOnColumn());
			}
			if (Columns.FindByUId(new Guid("37801848-9109-4a6e-9426-e4e9df99c227")) == null) {
				Columns.Add(CreateMetaDataColumn());
			}
			if (Columns.FindByUId(new Guid("2ed22e17-707f-4fac-a992-4118fdf240bd")) == null) {
				Columns.Add(CreateMetaDataLczColumn());
			}
			if (Columns.FindByUId(new Guid("eeaf6c5e-39ec-43d3-9804-44f7aad138ff")) == null) {
				Columns.Add(CreateTrainingSetQueryColumn());
			}
			if (Columns.FindByUId(new Guid("4052a73f-aa84-4af8-88e1-33cfaf7dec09")) == null) {
				Columns.Add(CreateRootSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("3489b79b-de7a-4a1c-b6ee-c1202ce67226")) == null) {
				Columns.Add(CreateStateColumn());
			}
			if (Columns.FindByUId(new Guid("076fc8aa-541b-4a7a-8bb3-93a29ee60537")) == null) {
				Columns.Add(CreateInstanceMetricColumn());
			}
			if (Columns.FindByUId(new Guid("aa12d9d8-4268-4b2b-8bc0-02e5b0479ea2")) == null) {
				Columns.Add(CreateMetricThresholdColumn());
			}
			if (Columns.FindByUId(new Guid("604e5349-5cac-4321-ae4e-0e2c051b40bd")) == null) {
				Columns.Add(CreatePredictionEnabledColumn());
			}
			if (Columns.FindByUId(new Guid("daba050d-dd24-4318-88e8-39c0ed224874")) == null) {
				Columns.Add(CreateTrainSessionIdColumn());
			}
			if (Columns.FindByUId(new Guid("f9b286c5-f7e4-4903-946e-3ff5e9f0d126")) == null) {
				Columns.Add(CreateMLProblemTypeColumn());
			}
			if (Columns.FindByUId(new Guid("506e63a6-8aa9-46c9-9dd4-925c32021296")) == null) {
				Columns.Add(CreateModelInstanceUIdColumn());
			}
			if (Columns.FindByUId(new Guid("793e2e39-52cf-4c85-9e48-88b495f7ff0c")) == null) {
				Columns.Add(CreateLastErrorColumn());
			}
			if (Columns.FindByUId(new Guid("5cf9d816-7f33-4b2b-b8ad-1501aa3ff764")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("c8ee1799-f14e-4aad-b913-e3c3c16b1b80")) == null) {
				Columns.Add(CreateBatchPredictedOnColumn());
			}
			if (Columns.FindByUId(new Guid("0f24d427-9ad0-48f3-aa43-5641c7b15a4c")) == null) {
				Columns.Add(CreateBatchPredictionQueryColumn());
			}
			if (Columns.FindByUId(new Guid("db5a1dd8-8e54-4367-bd56-984f22db12fc")) == null) {
				Columns.Add(CreateTargetColumnUIdColumn());
			}
			if (Columns.FindByUId(new Guid("bc0eb497-2a76-49b4-bba4-98fcb1e32af2")) == null) {
				Columns.Add(CreateBatchPredictionStartMethodColumn());
			}
			if (Columns.FindByUId(new Guid("99275f57-7f37-4fd5-8b7c-424fdb8c3c5d")) == null) {
				Columns.Add(CreateTrainingMinimumRecordsCountColumn());
			}
			if (Columns.FindByUId(new Guid("5e98be1f-c32b-401e-a72f-7439fd52dbba")) == null) {
				Columns.Add(CreateTrainingMaxRecordsCountColumn());
			}
			if (Columns.FindByUId(new Guid("0349a6eb-617b-476a-a594-6d587aa871b6")) == null) {
				Columns.Add(CreateTrainingFilterDataColumn());
			}
			if (Columns.FindByUId(new Guid("5f778292-a679-4ef2-829a-1d2730b81ec2")) == null) {
				Columns.Add(CreatePredictedResultColumnUIdColumn());
			}
			if (Columns.FindByUId(new Guid("dc14983a-57e2-414d-9c45-0a7c43aa382e")) == null) {
				Columns.Add(CreateTrainingOutputFilterDataColumn());
			}
			if (Columns.FindByUId(new Guid("bddb237e-fac4-4795-8764-fdf68d8146fd")) == null) {
				Columns.Add(CreateBatchPredictionFilterDataColumn());
			}
			if (Columns.FindByUId(new Guid("813876a1-a87e-4e68-8560-d9c61d37bbf2")) == null) {
				Columns.Add(CreateMLConfidentValueMethodColumn());
			}
			if (Columns.FindByUId(new Guid("ac91d6c5-6153-46c7-846a-1b5738dc2fc4")) == null) {
				Columns.Add(CreateConfidentValueLowEdgeColumn());
			}
			if (Columns.FindByUId(new Guid("c455f536-c33d-4f53-a5c7-1d9e8982cff3")) == null) {
				Columns.Add(CreateCFUserColumnPathColumn());
			}
			if (Columns.FindByUId(new Guid("40918ea8-2a5f-497a-9dc9-fd69ef47b4b9")) == null) {
				Columns.Add(CreateCFItemColumnPathColumn());
			}
			if (Columns.FindByUId(new Guid("539587f7-13b7-4cc8-82c2-08ec77e08100")) == null) {
				Columns.Add(CreateCFInteractionValueColumnPathColumn());
			}
			if (Columns.FindByUId(new Guid("d0953cec-19dc-4134-bb88-18a9cd4eaae5")) == null) {
				Columns.Add(CreateCFResultSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("7c18fdbc-9258-41c1-a5a2-7194ea2610ea")) == null) {
				Columns.Add(CreateCFResultUserColumnNameColumn());
			}
			if (Columns.FindByUId(new Guid("d7d07f8a-5e8a-426c-ae4a-a4b88069d77c")) == null) {
				Columns.Add(CreateCFResultItemColumnNameColumn());
			}
			if (Columns.FindByUId(new Guid("9d052301-6653-42b9-acc8-0dc988afc9ad")) == null) {
				Columns.Add(CreateCFResultValueColumnNameColumn());
			}
			if (Columns.FindByUId(new Guid("a9f0280b-9a29-4ef3-87ad-32e543a57734")) == null) {
				Columns.Add(CreateCFResultModelColumnNameColumn());
			}
			if (Columns.FindByUId(new Guid("f041f086-2b10-4c4c-9b57-25236c891492")) == null) {
				Columns.Add(CreateCFResultTimestampColumnNameColumn());
			}
			if (Columns.FindByUId(new Guid("e42aafab-672a-4444-a293-dd07a7434898")) == null) {
				Columns.Add(CreateFactorsCountsColumn());
			}
			if (Columns.FindByUId(new Guid("492d9f04-91b8-4f9a-994a-39a8e6bf3efa")) == null) {
				Columns.Add(CreateRegularizationValuesColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("736c30a7-c0ec-4fa9-b034-2552b319b633"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("9e53fd7c-dde4-4502-a64c-b9e34148108b"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateTrainFrequencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("564a0aee-87ac-4689-9164-615feb8c6aa7"),
				Name = @"TrainFrequency",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("10e294ac-851a-4b19-b311-15fba1867b12")
			};
		}

		protected virtual EntitySchemaColumn CreateTrainedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("7dcd6a05-f8cf-4f26-a162-852c0d390e12"),
				Name = @"TrainedOn",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("10e294ac-851a-4b19-b311-15fba1867b12")
			};
		}

		protected virtual EntitySchemaColumn CreateTriedToTrainOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("90154141-9251-4342-981f-4c0acf2b8557"),
				Name = @"TriedToTrainOn",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa")
			};
		}

		protected virtual EntitySchemaColumn CreateMetaDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("37801848-9109-4a6e-9426-e4e9df99c227"),
				Name = @"MetaData",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("10e294ac-851a-4b19-b311-15fba1867b12"),
				IsMultiLineText = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"{
}"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateMetaDataLczColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("2ed22e17-707f-4fac-a992-4118fdf240bd"),
				Name = @"MetaDataLcz",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa"),
				IsMultiLineText = true,
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateTrainingSetQueryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("eeaf6c5e-39ec-43d3-9804-44f7aad138ff"),
				Name = @"TrainingSetQuery",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("10e294ac-851a-4b19-b311-15fba1867b12"),
				IsMultiLineText = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"new Select(userConnection)"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateRootSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("4052a73f-aa84-4af8-88e1-33cfaf7dec09"),
				Name = @"RootSchemaUId",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("10e294ac-851a-4b19-b311-15fba1867b12")
			};
		}

		protected virtual EntitySchemaColumn CreateStateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3489b79b-de7a-4a1c-b6ee-c1202ce67226"),
				Name = @"State",
				ReferenceSchemaUId = new Guid("83a4b85c-3c8f-45c5-bb2c-ee6a45ba8cdc"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"a241f7fd-00dc-4c4e-a461-f86c5663d630"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateInstanceMetricColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("076fc8aa-541b-4a7a-8bb3-93a29ee60537"),
				Name = @"InstanceMetric",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("10e294ac-851a-4b19-b311-15fba1867b12")
			};
		}

		protected virtual EntitySchemaColumn CreateMetricThresholdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("aa12d9d8-4268-4b2b-8bc0-02e5b0479ea2"),
				Name = @"MetricThreshold",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("10e294ac-851a-4b19-b311-15fba1867b12")
			};
		}

		protected virtual EntitySchemaColumn CreatePredictionEnabledColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("604e5349-5cac-4321-ae4e-0e2c051b40bd"),
				Name = @"PredictionEnabled",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("10e294ac-851a-4b19-b311-15fba1867b12"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateTrainSessionIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("daba050d-dd24-4318-88e8-39c0ed224874"),
				Name = @"TrainSessionId",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("3e9edcdb-49d1-42f1-a12e-8a785812a474")
			};
		}

		protected virtual EntitySchemaColumn CreateMLProblemTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f9b286c5-f7e4-4903-946e-3ff5e9f0d126"),
				Name = @"MLProblemType",
				ReferenceSchemaUId = new Guid("cb5f6c84-15e9-4a53-b3cd-f42c0d364b03"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("3e9edcdb-49d1-42f1-a12e-8a785812a474"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateModelInstanceUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("506e63a6-8aa9-46c9-9dd4-925c32021296"),
				Name = @"ModelInstanceUId",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("3e9edcdb-49d1-42f1-a12e-8a785812a474")
			};
		}

		protected virtual EntitySchemaColumn CreateLastErrorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("793e2e39-52cf-4c85-9e48-88b495f7ff0c"),
				Name = @"LastError",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa")
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("5cf9d816-7f33-4b2b-b8ad-1501aa3ff764"),
				Name = @"Notes",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("3e9edcdb-49d1-42f1-a12e-8a785812a474")
			};
		}

		protected virtual EntitySchemaColumn CreateBatchPredictedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("c8ee1799-f14e-4aad-b913-e3c3c16b1b80"),
				Name = @"BatchPredictedOn",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("3e9edcdb-49d1-42f1-a12e-8a785812a474")
			};
		}

		protected virtual EntitySchemaColumn CreateBatchPredictionQueryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("0f24d427-9ad0-48f3-aa43-5641c7b15a4c"),
				Name = @"BatchPredictionQuery",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa")
			};
		}

		protected virtual EntitySchemaColumn CreateTargetColumnUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("db5a1dd8-8e54-4367-bd56-984f22db12fc"),
				Name = @"TargetColumnUId",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("3e9edcdb-49d1-42f1-a12e-8a785812a474")
			};
		}

		protected virtual EntitySchemaColumn CreateBatchPredictionStartMethodColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("bc0eb497-2a76-49b4-bba4-98fcb1e32af2"),
				Name = @"BatchPredictionStartMethod",
				ReferenceSchemaUId = new Guid("f4f5ebb7-7a26-4894-b9ef-16d25c13d0f9"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateTrainingMinimumRecordsCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("99275f57-7f37-4fd5-8b7c-424fdb8c3c5d"),
				Name = @"TrainingMinimumRecordsCount",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("3e9edcdb-49d1-42f1-a12e-8a785812a474"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"100"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateTrainingMaxRecordsCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("5e98be1f-c32b-401e-a72f-7439fd52dbba"),
				Name = @"TrainingMaxRecordsCount",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"75000"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateTrainingFilterDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("0349a6eb-617b-476a-a594-6d587aa871b6"),
				Name = @"TrainingFilterData",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa")
			};
		}

		protected virtual EntitySchemaColumn CreatePredictedResultColumnUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("5f778292-a679-4ef2-829a-1d2730b81ec2"),
				Name = @"PredictedResultColumnUId",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("8bab9e12-6ef4-4d97-ae92-182a028c5592")
			};
		}

		protected virtual EntitySchemaColumn CreateTrainingOutputFilterDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("dc14983a-57e2-414d-9c45-0a7c43aa382e"),
				Name = @"TrainingOutputFilterData",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa")
			};
		}

		protected virtual EntitySchemaColumn CreateBatchPredictionFilterDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("bddb237e-fac4-4795-8764-fdf68d8146fd"),
				Name = @"BatchPredictionFilterData",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa")
			};
		}

		protected virtual EntitySchemaColumn CreateMLConfidentValueMethodColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("813876a1-a87e-4e68-8560-d9c61d37bbf2"),
				Name = @"MLConfidentValueMethod",
				ReferenceSchemaUId = new Guid("0b41eaba-7a85-49f5-b32b-3cdf47f7619b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa"),
				IsSimpleLookup = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"5ce3f5dc-f541-4d6c-b7f8-819c33139b7f"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateConfidentValueLowEdgeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("ac91d6c5-6153-46c7-846a-1b5738dc2fc4"),
				Name = @"ConfidentValueLowEdge",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa")
			};
		}

		protected virtual EntitySchemaColumn CreateCFUserColumnPathColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("c455f536-c33d-4f53-a5c7-1d9e8982cff3"),
				Name = @"CFUserColumnPath",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa")
			};
		}

		protected virtual EntitySchemaColumn CreateCFItemColumnPathColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("40918ea8-2a5f-497a-9dc9-fd69ef47b4b9"),
				Name = @"CFItemColumnPath",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa")
			};
		}

		protected virtual EntitySchemaColumn CreateCFInteractionValueColumnPathColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("539587f7-13b7-4cc8-82c2-08ec77e08100"),
				Name = @"CFInteractionValueColumnPath",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa")
			};
		}

		protected virtual EntitySchemaColumn CreateCFResultSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("d0953cec-19dc-4134-bb88-18a9cd4eaae5"),
				Name = @"CFResultSchemaUId",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("3e335a15-b311-46b3-b279-c5d4ecce33b5")
			};
		}

		protected virtual EntitySchemaColumn CreateCFResultUserColumnNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("7c18fdbc-9258-41c1-a5a2-7194ea2610ea"),
				Name = @"CFResultUserColumnName",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("3e335a15-b311-46b3-b279-c5d4ecce33b5")
			};
		}

		protected virtual EntitySchemaColumn CreateCFResultItemColumnNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("d7d07f8a-5e8a-426c-ae4a-a4b88069d77c"),
				Name = @"CFResultItemColumnName",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("3e335a15-b311-46b3-b279-c5d4ecce33b5")
			};
		}

		protected virtual EntitySchemaColumn CreateCFResultValueColumnNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("9d052301-6653-42b9-acc8-0dc988afc9ad"),
				Name = @"CFResultValueColumnName",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("3e335a15-b311-46b3-b279-c5d4ecce33b5")
			};
		}

		protected virtual EntitySchemaColumn CreateCFResultModelColumnNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("a9f0280b-9a29-4ef3-87ad-32e543a57734"),
				Name = @"CFResultModelColumnName",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("3e335a15-b311-46b3-b279-c5d4ecce33b5")
			};
		}

		protected virtual EntitySchemaColumn CreateCFResultTimestampColumnNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("f041f086-2b10-4c4c-9b57-25236c891492"),
				Name = @"CFResultTimestampColumnName",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("3e335a15-b311-46b3-b279-c5d4ecce33b5")
			};
		}

		protected virtual EntitySchemaColumn CreateFactorsCountsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("e42aafab-672a-4444-a293-dd07a7434898"),
				Name = @"FactorsCounts",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("3e335a15-b311-46b3-b279-c5d4ecce33b5"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"2; 5; 10; 15; 20; 50; 100"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateRegularizationValuesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("492d9f04-91b8-4f9a-994a-39a8e6bf3efa"),
				Name = @"RegularizationValues",
				CreatedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				ModifiedInSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				CreatedInPackageId = new Guid("3e335a15-b311-46b3-b279-c5d4ecce33b5"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"0.1; 2; 5; 10; 15; 20; 25"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMLModelEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateMLModelEventsProcessSchema() {
			var schema = new MLModelEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new MLModel(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new MLModel_MLBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MLModelSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MLModelSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"));
		}

		#endregion

	}

	#endregion

	#region Class: MLModel

	/// <summary>
	/// ML model.
	/// </summary>
	public class MLModel : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public MLModel(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MLModel";
		}

		public MLModel(MLModel source)
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

		/// <summary>
		/// Retrain after, days.
		/// </summary>
		public int TrainFrequency {
			get {
				return GetTypedColumnValue<int>("TrainFrequency");
			}
			set {
				SetColumnValue("TrainFrequency", value);
			}
		}

		/// <summary>
		/// When the model was trained.
		/// </summary>
		public DateTime TrainedOn {
			get {
				return GetTypedColumnValue<DateTime>("TrainedOn");
			}
			set {
				SetColumnValue("TrainedOn", value);
			}
		}

		/// <summary>
		/// Last attempt to train date.
		/// </summary>
		public DateTime TriedToTrainOn {
			get {
				return GetTypedColumnValue<DateTime>("TriedToTrainOn");
			}
			set {
				SetColumnValue("TriedToTrainOn", value);
			}
		}

		/// <summary>
		/// Query metadata for selecting additional training data.
		/// </summary>
		public string MetaData {
			get {
				return GetTypedColumnValue<string>("MetaData");
			}
			set {
				SetColumnValue("MetaData", value);
			}
		}

		/// <summary>
		/// Localizable part of metadata.
		/// </summary>
		public string MetaDataLcz {
			get {
				return GetTypedColumnValue<string>("MetaDataLcz");
			}
			set {
				SetColumnValue("MetaDataLcz", value);
			}
		}

		/// <summary>
		/// Query for selecting additional training data.
		/// </summary>
		public string TrainingSetQuery {
			get {
				return GetTypedColumnValue<string>("TrainingSetQuery");
			}
			set {
				SetColumnValue("TrainingSetQuery", value);
			}
		}

		/// <summary>
		/// Object.
		/// </summary>
		public Guid RootSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("RootSchemaUId");
			}
			set {
				SetColumnValue("RootSchemaUId", value);
			}
		}

		/// <exclude/>
		public Guid StateId {
			get {
				return GetTypedColumnValue<Guid>("StateId");
			}
			set {
				SetColumnValue("StateId", value);
				_state = null;
			}
		}

		/// <exclude/>
		public string StateName {
			get {
				return GetTypedColumnValue<string>("StateName");
			}
			set {
				SetColumnValue("StateName", value);
				if (_state != null) {
					_state.Name = value;
				}
			}
		}

		private MLModelState _state;
		/// <summary>
		/// Status.
		/// </summary>
		public MLModelState State {
			get {
				return _state ??
					(_state = LookupColumnEntities.GetEntity("State") as MLModelState);
			}
		}

		/// <summary>
		/// Evaluation metric.
		/// </summary>
		public Decimal InstanceMetric {
			get {
				return GetTypedColumnValue<Decimal>("InstanceMetric");
			}
			set {
				SetColumnValue("InstanceMetric", value);
			}
		}

		/// <summary>
		/// Quality metric lower limit.
		/// </summary>
		public Decimal MetricThreshold {
			get {
				return GetTypedColumnValue<Decimal>("MetricThreshold");
			}
			set {
				SetColumnValue("MetricThreshold", value);
			}
		}

		/// <summary>
		/// Prediction enabled.
		/// </summary>
		public bool PredictionEnabled {
			get {
				return GetTypedColumnValue<bool>("PredictionEnabled");
			}
			set {
				SetColumnValue("PredictionEnabled", value);
			}
		}

		/// <summary>
		/// Current training session.
		/// </summary>
		public Guid TrainSessionId {
			get {
				return GetTypedColumnValue<Guid>("TrainSessionId");
			}
			set {
				SetColumnValue("TrainSessionId", value);
			}
		}

		/// <exclude/>
		public Guid MLProblemTypeId {
			get {
				return GetTypedColumnValue<Guid>("MLProblemTypeId");
			}
			set {
				SetColumnValue("MLProblemTypeId", value);
				_mLProblemType = null;
			}
		}

		/// <exclude/>
		public string MLProblemTypeName {
			get {
				return GetTypedColumnValue<string>("MLProblemTypeName");
			}
			set {
				SetColumnValue("MLProblemTypeName", value);
				if (_mLProblemType != null) {
					_mLProblemType.Name = value;
				}
			}
		}

		private MLProblemType _mLProblemType;
		/// <summary>
		/// Type.
		/// </summary>
		public MLProblemType MLProblemType {
			get {
				return _mLProblemType ??
					(_mLProblemType = LookupColumnEntities.GetEntity("MLProblemType") as MLProblemType);
			}
		}

		/// <summary>
		/// Model instance Id.
		/// </summary>
		public string ModelInstanceUId {
			get {
				return GetTypedColumnValue<string>("ModelInstanceUId");
			}
			set {
				SetColumnValue("ModelInstanceUId", value);
			}
		}

		/// <summary>
		/// Last error message text.
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
		/// Batch prediction date.
		/// </summary>
		public DateTime BatchPredictedOn {
			get {
				return GetTypedColumnValue<DateTime>("BatchPredictedOn");
			}
			set {
				SetColumnValue("BatchPredictedOn", value);
			}
		}

		/// <summary>
		/// Query for selecting additional prediction data.
		/// </summary>
		public string BatchPredictionQuery {
			get {
				return GetTypedColumnValue<string>("BatchPredictionQuery");
			}
			set {
				SetColumnValue("BatchPredictionQuery", value);
			}
		}

		/// <summary>
		/// Outcome column.
		/// </summary>
		public Guid TargetColumnUId {
			get {
				return GetTypedColumnValue<Guid>("TargetColumnUId");
			}
			set {
				SetColumnValue("TargetColumnUId", value);
			}
		}

		/// <exclude/>
		public Guid BatchPredictionStartMethodId {
			get {
				return GetTypedColumnValue<Guid>("BatchPredictionStartMethodId");
			}
			set {
				SetColumnValue("BatchPredictionStartMethodId", value);
				_batchPredictionStartMethod = null;
			}
		}

		/// <exclude/>
		public string BatchPredictionStartMethodName {
			get {
				return GetTypedColumnValue<string>("BatchPredictionStartMethodName");
			}
			set {
				SetColumnValue("BatchPredictionStartMethodName", value);
				if (_batchPredictionStartMethod != null) {
					_batchPredictionStartMethod.Name = value;
				}
			}
		}

		private MLTaskStartMethod _batchPredictionStartMethod;
		/// <summary>
		/// Method of batch prediction start.
		/// </summary>
		public MLTaskStartMethod BatchPredictionStartMethod {
			get {
				return _batchPredictionStartMethod ??
					(_batchPredictionStartMethod = LookupColumnEntities.GetEntity("BatchPredictionStartMethod") as MLTaskStartMethod);
			}
		}

		/// <summary>
		/// Minimum training record count.
		/// </summary>
		public int TrainingMinimumRecordsCount {
			get {
				return GetTypedColumnValue<int>("TrainingMinimumRecordsCount");
			}
			set {
				SetColumnValue("TrainingMinimumRecordsCount", value);
			}
		}

		/// <summary>
		/// Maximum training record count.
		/// </summary>
		public int TrainingMaxRecordsCount {
			get {
				return GetTypedColumnValue<int>("TrainingMaxRecordsCount");
			}
			set {
				SetColumnValue("TrainingMaxRecordsCount", value);
			}
		}

		/// <summary>
		/// Prediction result column.
		/// </summary>
		public Guid PredictedResultColumnUId {
			get {
				return GetTypedColumnValue<Guid>("PredictedResultColumnUId");
			}
			set {
				SetColumnValue("PredictedResultColumnUId", value);
			}
		}

		/// <exclude/>
		public Guid MLConfidentValueMethodId {
			get {
				return GetTypedColumnValue<Guid>("MLConfidentValueMethodId");
			}
			set {
				SetColumnValue("MLConfidentValueMethodId", value);
				_mLConfidentValueMethod = null;
			}
		}

		/// <exclude/>
		public string MLConfidentValueMethodName {
			get {
				return GetTypedColumnValue<string>("MLConfidentValueMethodName");
			}
			set {
				SetColumnValue("MLConfidentValueMethodName", value);
				if (_mLConfidentValueMethod != null) {
					_mLConfidentValueMethod.Name = value;
				}
			}
		}

		private MLConfidentValueMethod _mLConfidentValueMethod;
		/// <summary>
		/// Predicted value selection method.
		/// </summary>
		public MLConfidentValueMethod MLConfidentValueMethod {
			get {
				return _mLConfidentValueMethod ??
					(_mLConfidentValueMethod = LookupColumnEntities.GetEntity("MLConfidentValueMethod") as MLConfidentValueMethod);
			}
		}

		/// <summary>
		/// Lower limit of probability for predicted value selection.
		/// </summary>
		public Decimal ConfidentValueLowEdge {
			get {
				return GetTypedColumnValue<Decimal>("ConfidentValueLowEdge");
			}
			set {
				SetColumnValue("ConfidentValueLowEdge", value);
			}
		}

		/// <summary>
		/// Recommended to (Subject).
		/// </summary>
		public string CFUserColumnPath {
			get {
				return GetTypedColumnValue<string>("CFUserColumnPath");
			}
			set {
				SetColumnValue("CFUserColumnPath", value);
			}
		}

		/// <summary>
		/// Recommended object.
		/// </summary>
		public string CFItemColumnPath {
			get {
				return GetTypedColumnValue<string>("CFItemColumnPath");
			}
			set {
				SetColumnValue("CFItemColumnPath", value);
			}
		}

		/// <summary>
		/// Recommendation dependency column.
		/// </summary>
		public string CFInteractionValueColumnPath {
			get {
				return GetTypedColumnValue<string>("CFInteractionValueColumnPath");
			}
			set {
				SetColumnValue("CFInteractionValueColumnPath", value);
			}
		}

		/// <summary>
		/// Schema to save CF prediction results.
		/// </summary>
		public Guid CFResultSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("CFResultSchemaUId");
			}
			set {
				SetColumnValue("CFResultSchemaUId", value);
			}
		}

		/// <summary>
		/// Column to save CF prediction user identifier.
		/// </summary>
		public string CFResultUserColumnName {
			get {
				return GetTypedColumnValue<string>("CFResultUserColumnName");
			}
			set {
				SetColumnValue("CFResultUserColumnName", value);
			}
		}

		/// <summary>
		/// Column to save item from CF prediction result.
		/// </summary>
		public string CFResultItemColumnName {
			get {
				return GetTypedColumnValue<string>("CFResultItemColumnName");
			}
			set {
				SetColumnValue("CFResultItemColumnName", value);
			}
		}

		/// <summary>
		/// Column to save CF predicted value.
		/// </summary>
		public string CFResultValueColumnName {
			get {
				return GetTypedColumnValue<string>("CFResultValueColumnName");
			}
			set {
				SetColumnValue("CFResultValueColumnName", value);
			}
		}

		/// <summary>
		/// Column to save CF prediction model identifier.
		/// </summary>
		public string CFResultModelColumnName {
			get {
				return GetTypedColumnValue<string>("CFResultModelColumnName");
			}
			set {
				SetColumnValue("CFResultModelColumnName", value);
			}
		}

		/// <summary>
		/// Column to save CF prediction timestamp.
		/// </summary>
		public string CFResultTimestampColumnName {
			get {
				return GetTypedColumnValue<string>("CFResultTimestampColumnName");
			}
			set {
				SetColumnValue("CFResultTimestampColumnName", value);
			}
		}

		/// <summary>
		/// List of factors count.
		/// </summary>
		public string FactorsCounts {
			get {
				return GetTypedColumnValue<string>("FactorsCounts");
			}
			set {
				SetColumnValue("FactorsCounts", value);
			}
		}

		/// <summary>
		/// List of regularization values.
		/// </summary>
		public string RegularizationValues {
			get {
				return GetTypedColumnValue<string>("RegularizationValues");
			}
			set {
				SetColumnValue("RegularizationValues", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MLModel_MLBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("MLModelDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MLModel(this);
		}

		#endregion

	}

	#endregion

	#region Class: MLModel_MLBaseEventsProcess

	/// <exclude/>
	public partial class MLModel_MLBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : MLModel
	{

		public MLModel_MLBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MLModel_MLBaseEventsProcess";
			SchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b");
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

	#region Class: MLModel_MLBaseEventsProcess

	/// <exclude/>
	public class MLModel_MLBaseEventsProcess : MLModel_MLBaseEventsProcess<MLModel>
	{

		public MLModel_MLBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MLModel_MLBaseEventsProcess

	public partial class MLModel_MLBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: MLModelEventsProcessSchema

	/// <exclude/>
	public class MLModelEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public MLModelEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MLModelEventsProcessSchema(MLModelEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "MLModel_MLBaseEventsProcess";
			UId = new Guid("44c3bb31-649d-4cd4-8d07-a0dc371122ed");
			CreatedInPackageId = new Guid("10e294ac-851a-4b19-b311-15fba1867b12");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
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

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MLModelEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("44c3bb31-649d-4cd4-8d07-a0dc371122ed"));
		}

		#endregion

	}

	#endregion


	#region Class: MLModelEventsProcess

	/// <exclude/>
	public class MLModelEventsProcess : MLModel_MLBaseEventsProcess
	{

		public MLModelEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

