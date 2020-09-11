namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: OpportunityManagementProspectingSchema

	/// <exclude/>
	public class OpportunityManagementProspectingSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public OpportunityManagementProspectingSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public OpportunityManagementProspectingSchema(OpportunityManagementProspectingSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OpportunityManagementProspecting";
			UId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f");
			CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.15.2.501";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"OpportunityManagement";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f");
			Version = 0;
			PackageUId = new Guid("75b64d44-f646-4025-b2dc-16a7526ff5fd");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateCurrentOpportunityParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4c6e9a6c-52a3-4f25-879f-96941c1aa349"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"CurrentOpportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateOpportunityStageChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0bd1bc47-97dc-487d-b8b8-e5bd0a629ed8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"OpportunityStageChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMainContactParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("83114e9e-fb66-424f-a1a6-d23fb5945480"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"MainContact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCurrentOpportunityParameter());
			Parameters.Add(CreateOpportunityStageChangedParameter());
			Parameters.Add(CreateMainContactParameter());
		}

		protected virtual void InitializeOpenEditPageUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var objectSchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("ae7d9be8-2794-4f16-9a39-ccf50ecdba24"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ObjectSchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			objectSchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(objectSchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"ae46fb87-c02c-4ae8-ad31-a923cdd994cf",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(objectSchemaIdParameter);
			var pageSchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("db76b6e1-5420-4968-9631-759ba37819e2"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"PageSchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			pageSchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(pageSchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"df249c13-df7a-48d2-b128-85183c4a0e10",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(pageSchemaIdParameter);
			var editModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6efa15b1-5137-45fa-809e-79bb3db89358"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"EditMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			editModeParameter.SourceValue = new ProcessSchemaParameterValue(editModeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(editModeParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9324bb9c-5017-411c-b5a5-fb117947ef43"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"RecordColumnValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,171,86,82,41,169,44,72,85,178,82,10,73,45,42,74,44,206,79,43,209,115,206,47,74,213,11,40,202,79,78,45,46,214,243,201,79,78,204,201,172,74,76,202,73,13,72,44,74,204,77,45,73,45,10,75,204,41,77,45,246,201,44,46,209,81,64,213,166,164,163,164,82,6,150,85,178,138,142,173,5,0,199,127,71,237,94,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("f271250b-3c06-467b-b95f-c2d2e9c3019c"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{4c6e9a6c-52a3-4f25-879f-96941c1aa349}]#]",
				MetaPath = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{4c6e9a6c-52a3-4f25-879f-96941c1aa349}]#]",
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var executedModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dbb47148-8d67-4fe3-825b-477f8d55c92b"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ExecutedMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			executedModeParameter.SourceValue = new ProcessSchemaParameterValue(executedModeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(executedModeParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("701175ea-0e46-4f61-938b-eedf9af21920"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"IsMatchConditions",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMatchConditionsParameter.SourceValue = new ProcessSchemaParameterValue(isMatchConditionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("540b1d28-96f8-4793-b6dc-f222c6d4efbd"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var generateDecisionsFromColumnParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8a056fe6-95e1-4710-b4ff-d50ef63e2916"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"GenerateDecisionsFromColumn",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			generateDecisionsFromColumnParameter.SourceValue = new ProcessSchemaParameterValue(generateDecisionsFromColumnParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(generateDecisionsFromColumnParameter);
			var decisionalColumnMetaPathParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e842c411-a194-41b8-8520-bc517224cd01"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"DecisionalColumnMetaPath",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			decisionalColumnMetaPathParameter.SourceValue = new ProcessSchemaParameterValue(decisionalColumnMetaPathParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(decisionalColumnMetaPathParameter);
			var resultParameterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d6313c1e-3152-439f-88a5-ca4f5b397ee8"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ResultParameter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			resultParameterParameter.SourceValue = new ProcessSchemaParameterValue(resultParameterParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultParameterParameter);
			var isReexecutionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ed2ab973-7009-4a0c-bc37-6e4eaa3450bd"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"IsReexecution",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isReexecutionParameter.SourceValue = new ProcessSchemaParameterValue(isReexecutionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(isReexecutionParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5f81e72e-7cb6-4775-b4ef-709235e30ef2"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Recommendation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			recommendationParameter.SourceValue = new ProcessSchemaParameterValue(recommendationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Assign opportunity owner",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var activityCategoryParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("961e2086-a12b-4d27-b095-40b1e64d6cc0"),
				UId = new Guid("e825034b-3779-4c1e-aa88-08a25cddf922"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ActivityCategory",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			activityCategoryParameter.SourceValue = new ProcessSchemaParameterValue(activityCategoryParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"f51c4643-58e6-df11-971b-001d60e938c6",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(activityCategoryParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("79b71a16-363b-4270-804f-96c0266a9226"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = true,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"OwnerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			ownerIdParameter.SourceValue = new ProcessSchemaParameterValue(ownerIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var durationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("49fc1967-693a-4c7c-a90b-ff57e9609483"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Duration",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			durationParameter.SourceValue = new ProcessSchemaParameterValue(durationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"5",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(durationParameter);
			var durationPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("15acbe32-9e04-4bda-813f-0dbf7140366e"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"DurationPeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			durationPeriodParameter.SourceValue = new ProcessSchemaParameterValue(durationPeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(durationPeriodParameter);
			var startInParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fac6a98d-6e1f-4791-90ff-6388fd5c7dfa"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"StartIn",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startInParameter.SourceValue = new ProcessSchemaParameterValue(startInParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(startInParameter);
			var startInPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("52348b4d-d057-423b-bbd2-b27ffdcb31b7"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"StartInPeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startInPeriodParameter.SourceValue = new ProcessSchemaParameterValue(startInPeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(startInPeriodParameter);
			var remindBeforeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ac12bebe-1559-4b69-be65-0ec920c26ed8"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"RemindBefore",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			remindBeforeParameter.SourceValue = new ProcessSchemaParameterValue(remindBeforeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"5",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(remindBeforeParameter);
			var remindBeforePeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1163d8da-f734-4ad7-824c-da7bd888483c"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"RemindBeforePeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			remindBeforePeriodParameter.SourceValue = new ProcessSchemaParameterValue(remindBeforePeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(remindBeforePeriodParameter);
			var showInSchedulerParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("09e933cd-ec8e-464b-aa57-a0653129c148"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ShowInScheduler",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showInSchedulerParameter.SourceValue = new ProcessSchemaParameterValue(showInSchedulerParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(showInSchedulerParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e108111b-f473-4ec3-ac71-171a7e932396"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ShowExecutionPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showExecutionPageParameter.SourceValue = new ProcessSchemaParameterValue(showExecutionPageParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"True",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var leadParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("c5cbdcb1-8456-4d6c-a2a3-efde611f3db8"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Lead",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadParameter.SourceValue = new ProcessSchemaParameterValue(leadParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(leadParameter);
			var accountParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("8727b23d-8ab9-43de-adcf-b6411baf04bf"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Account",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			accountParameter.SourceValue = new ProcessSchemaParameterValue(accountParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{219dc79c-3bc4-48da-b5b7-90defe1aec40}].[Parameter:{40333f27-6073-4fdf-8195-0a76448c3050}].[EntityColumn:{4b95e3ff-fd52-4ae1-b0a5-2c5103ff15a7}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(accountParameter);
			var contactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("701b6be8-7bde-4ddc-a8ea-05d5e3a6f32b"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Contact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contactParameter.SourceValue = new ProcessSchemaParameterValue(contactParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{219dc79c-3bc4-48da-b5b7-90defe1aec40}].[Parameter:{40333f27-6073-4fdf-8195-0a76448c3050}].[EntityColumn:{64a05bfa-350d-4dbf-bfd8-fb579a74f39e}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(contactParameter);
			var opportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("070365fb-e8d5-49f1-a71d-933a82563693"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Opportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			opportunityParameter.SourceValue = new ProcessSchemaParameterValue(opportunityParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{4c6e9a6c-52a3-4f25-879f-96941c1aa349}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(opportunityParameter);
			var invoiceParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				UId = new Guid("798646c0-f074-4300-a2d7-73558f4302b8"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Invoice",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			invoiceParameter.SourceValue = new ProcessSchemaParameterValue(invoiceParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(invoiceParameter);
			var documentParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				UId = new Guid("97e1828c-89e8-4b30-a736-129257a18787"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Document",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			documentParameter.SourceValue = new ProcessSchemaParameterValue(documentParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(documentParameter);
			var incidentParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dc76bc3f-26e8-4e12-99eb-06875b580140"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Incident",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			incidentParameter.SourceValue = new ProcessSchemaParameterValue(incidentParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(incidentParameter);
			var caseParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("10863539-42e3-4ec9-a0e1-93835649f96f"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Case",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			caseParameter.SourceValue = new ProcessSchemaParameterValue(caseParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(caseParameter);
			var activityResultParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ed45b44a-4ef2-4090-a7d6-d660ff6794df"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Out,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ActivityResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			activityResultParameter.SourceValue = new ProcessSchemaParameterValue(activityResultParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(activityResultParameter);
			var currentActivityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4dddec06-0b54-4279-b578-5adbd29937de"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"CurrentActivityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			currentActivityIdParameter.SourceValue = new ProcessSchemaParameterValue(currentActivityIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(currentActivityIdParameter);
			var isActivityCompletedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9dea1cae-603b-480e-91b9-2cedc8043fe3"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Out,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"IsActivityCompleted",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isActivityCompletedParameter.SourceValue = new ProcessSchemaParameterValue(isActivityCompletedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(isActivityCompletedParameter);
			var executionContextParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("396ca1cb-2a2c-47c0-9bce-7f8d32e2948e"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ExecutionContext",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			executionContextParameter.SourceValue = new ProcessSchemaParameterValue(executionContextParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(executionContextParameter);
			var pageTypeUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d8194d6c-dcc9-4b4e-a9d6-3d49314e8e98"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"PageTypeUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			pageTypeUIdParameter.SourceValue = new ProcessSchemaParameterValue(pageTypeUIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(pageTypeUIdParameter);
			var activitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0c84cdb3-00ef-43ef-8ec5-929ab4936120"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ActivitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			activitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(activitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(activitySchemaUIdParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("265cd111-1e70-4cac-83ae-bf14d2756bb9"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"InformationOnStep",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			informationOnStepParameter.SourceValue = new ProcessSchemaParameterValue(informationOnStepParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(informationOnStepParameter);
			var orderParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				UId = new Guid("2d1fa997-5890-44a6-8b5f-864795599deb"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Order",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			orderParameter.SourceValue = new ProcessSchemaParameterValue(orderParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(orderParameter);
			var requestsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("69814e7a-c257-4df5-bec5-ce4565034b2d"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Requests",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			requestsParameter.SourceValue = new ProcessSchemaParameterValue(requestsParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(requestsParameter);
			var listingParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("862b6225-5967-4969-9fd9-8c8e79df20c0"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Listing",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			listingParameter.SourceValue = new ProcessSchemaParameterValue(listingParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(listingParameter);
			var propertyParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ead44738-c37f-4ac5-b25e-4cbcd2ae893b"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Property",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			propertyParameter.SourceValue = new ProcessSchemaParameterValue(propertyParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(propertyParameter);
			var contractParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810"),
				UId = new Guid("b0849d2a-bce7-43f8-beb1-fa2c375357ac"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Contract",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contractParameter.SourceValue = new ProcessSchemaParameterValue(contractParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(contractParameter);
			var problemParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d7450c11-e4da-4c5a-96e1-fbcb7ea94867"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Problem",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			problemParameter.SourceValue = new ProcessSchemaParameterValue(problemParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(problemParameter);
			var changeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c54f578d-a593-499f-a846-b08a7bd3ca7b"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Change",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			changeParameter.SourceValue = new ProcessSchemaParameterValue(changeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(changeParameter);
			var releaseParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("40753f3d-3149-4919-9649-169e2c608b25"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Release",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			releaseParameter.SourceValue = new ProcessSchemaParameterValue(releaseParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(releaseParameter);
			var projectParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				UId = new Guid("54a12540-bcb5-4fb7-b795-3cc857cd0d72"),
				ContainerUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Project",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			projectParameter.SourceValue = new ProcessSchemaParameterValue(projectParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(projectParameter);
		}

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6f986137-04cb-4983-b7b0-54ae0cf8a109"),
				ContainerUId = new Guid("219dc79c-3bc4-48da-b5b7-90defe1aec40"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,20,252,43,69,135,158,164,98,75,178,108,57,199,101,91,246,146,6,154,150,66,178,132,103,233,57,43,240,87,108,137,102,49,251,223,43,175,179,41,228,80,10,61,5,116,144,158,52,243,102,134,167,249,193,77,159,93,227,113,44,107,104,38,164,97,103,75,146,37,149,22,9,102,12,114,35,153,76,117,193,32,169,42,198,21,160,149,86,165,73,97,8,237,160,197,146,172,232,173,117,158,80,231,177,157,202,187,249,15,169,31,3,210,135,250,124,248,102,14,216,194,247,165,1,160,84,117,85,228,204,36,220,48,9,24,27,88,145,50,208,92,24,107,181,150,166,38,171,22,52,156,23,26,21,19,92,42,38,49,55,12,138,20,89,149,43,195,21,79,120,158,115,66,27,172,253,246,121,24,113,154,92,223,149,51,190,238,111,143,67,84,185,246,222,244,77,104,59,66,91,244,112,3,254,176,8,73,80,102,6,152,145,58,99,178,198,156,129,208,150,9,168,114,158,23,152,170,52,39,212,192,224,23,90,178,179,132,90,240,240,3,154,128,103,230,217,69,141,92,36,105,145,169,136,77,69,180,35,120,194,10,21,221,213,86,213,26,133,210,186,178,151,188,190,4,23,247,110,186,14,45,142,206,188,196,142,49,191,126,44,103,211,119,126,236,155,133,250,250,252,252,22,159,253,26,238,203,213,207,213,144,143,245,5,68,78,52,76,184,105,28,118,126,219,153,222,186,238,113,229,60,157,34,164,29,96,116,211,37,133,237,83,128,134,208,209,61,30,254,154,214,38,76,190,111,223,145,85,26,109,70,142,56,100,103,185,203,12,90,55,13,13,28,207,231,146,124,124,10,189,191,218,132,113,140,224,15,253,48,244,163,15,157,243,199,245,130,188,33,40,201,61,145,70,161,6,101,88,198,65,196,209,224,25,43,114,93,51,173,180,76,77,10,32,164,190,39,81,212,255,183,186,219,77,95,127,117,151,31,178,122,218,127,138,213,55,133,155,11,178,156,255,69,221,105,191,232,219,159,226,250,13,90,200,224,72,232,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9ead078e-f887-43ca-a04e-d8ce3a1ce902"),
				ContainerUId = new Guid("219dc79c-3bc4-48da-b5b7-90defe1aec40"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3f155961-0b7c-488a-ad58-3d3edf964358"),
				ContainerUId = new Guid("219dc79c-3bc4-48da-b5b7-90defe1aec40"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("97f729d1-9c97-41b7-807b-90a33d51655e"),
				ContainerUId = new Guid("219dc79c-3bc4-48da-b5b7-90defe1aec40"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("36f4066e-90fc-4fdb-9746-c383e7463ec7"),
				ContainerUId = new Guid("219dc79c-3bc4-48da-b5b7-90defe1aec40"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("05e54116-4bc1-4945-ba99-e9e2dc05d937"),
				ContainerUId = new Guid("219dc79c-3bc4-48da-b5b7-90defe1aec40"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e6227e17-dc85-4e02-837c-e9990987d128"),
				ContainerUId = new Guid("219dc79c-3bc4-48da-b5b7-90defe1aec40"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,11,201,44,201,73,181,50,180,50,212,241,76,177,50,176,50,0,0,169,240,29,88,16,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("40333f27-6073-4fdf-8195-0a76448c3050"),
				ContainerUId = new Guid("219dc79c-3bc4-48da-b5b7-90defe1aec40"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0bfa05ed-5c32-4321-830d-fdf5729623fc"),
				ContainerUId = new Guid("219dc79c-3bc4-48da-b5b7-90defe1aec40"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7072dcc2-6391-4ac4-90c5-03e41d350032"),
				ContainerUId = new Guid("219dc79c-3bc4-48da-b5b7-90defe1aec40"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("158d4a9d-89ef-4cff-94d2-a1d2c46119d9"),
				ContainerUId = new Guid("219dc79c-3bc4-48da-b5b7-90defe1aec40"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5c5148f8-73c6-4e66-9f88-0776da38ac4a"),
				ContainerUId = new Guid("219dc79c-3bc4-48da-b5b7-90defe1aec40"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5306de25-557e-4d14-ab0d-61ef40ef14f7"),
				ContainerUId = new Guid("219dc79c-3bc4-48da-b5b7-90defe1aec40"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7088c4df-1695-4ef3-bc05-566678b8b453"),
				ContainerUId = new Guid("219dc79c-3bc4-48da-b5b7-90defe1aec40"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("51c42171-ea97-42a6-86d6-748585c8132e"),
				ContainerUId = new Guid("219dc79c-3bc4-48da-b5b7-90defe1aec40"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("225571a2-2754-47d9-8903-bcf25cb22132"),
				ContainerUId = new Guid("219dc79c-3bc4-48da-b5b7-90defe1aec40"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ac7c66ef-d757-43a3-b7c8-3172e4cf1bf7"),
				ContainerUId = new Guid("219dc79c-3bc4-48da-b5b7-90defe1aec40"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("043fe795-d872-437f-b39e-55a556b5fe39"),
				ContainerUId = new Guid("219dc79c-3bc4-48da-b5b7-90defe1aec40"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("97825518-45a2-4cd1-bf70-efcf8cf88284"),
				ContainerUId = new Guid("219dc79c-3bc4-48da-b5b7-90defe1aec40"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeChangeAdminRightsUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c0fec3ae-801f-45d1-9ef1-f5d96f2e507e"),
				ContainerUId = new Guid("3d527ad4-f295-4b8c-a9d8-5bd27c06dc5c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"25d7c1ab-1de0-4501-b402-02e0e5a72d6e",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("219973db-f3e9-415f-9801-d02ea613c197"),
				ContainerUId = new Guid("3d527ad4-f295-4b8c-a9d8-5bd27c06dc5c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,148,77,111,156,48,16,134,255,10,242,161,39,188,194,198,198,64,79,85,180,169,114,73,163,126,169,82,18,69,131,61,100,45,1,222,128,81,19,173,246,191,119,88,146,86,202,161,202,177,149,56,216,195,204,59,51,15,51,28,238,252,116,238,187,136,99,221,66,55,97,58,95,184,154,137,182,201,155,82,75,142,160,42,174,148,173,56,128,52,188,208,70,201,188,20,153,43,75,150,14,208,99,205,214,232,173,243,145,165,62,98,63,213,215,135,63,162,113,156,49,189,107,79,151,47,118,135,61,124,91,18,72,237,140,21,208,112,225,48,227,74,103,130,55,42,147,60,147,152,161,6,35,93,129,108,173,37,215,194,72,33,37,47,68,163,184,202,12,185,234,18,184,16,160,80,229,166,210,138,106,233,176,141,219,199,253,136,211,228,195,80,31,240,247,249,235,211,158,170,92,115,159,133,110,238,7,150,246,24,225,10,226,174,102,64,249,148,182,192,173,170,52,87,45,26,14,121,229,120,14,141,145,166,68,81,8,195,82,11,251,184,200,178,11,199,82,7,17,190,67,55,227,73,249,224,151,118,242,76,148,186,160,88,145,91,174,114,153,241,178,40,13,111,93,209,86,152,23,85,213,184,23,94,31,103,79,103,63,93,206,61,142,222,62,99,71,226,23,198,250,96,195,16,199,208,45,210,151,39,247,175,248,24,87,184,207,175,126,172,13,69,178,47,65,236,152,206,19,158,117,30,135,184,29,108,112,126,184,95,53,143,71,10,233,247,48,250,233,133,194,246,97,134,142,165,163,191,223,253,149,214,217,60,197,208,255,71,173,166,212,38,105,208,144,157,202,93,102,208,249,105,223,193,211,233,94,179,119,15,115,136,239,63,35,184,36,236,247,97,140,243,224,227,83,178,52,152,64,75,113,201,132,29,218,72,146,73,248,57,224,184,57,247,227,20,147,101,162,147,208,38,113,135,9,33,154,187,147,135,13,221,201,57,12,155,15,214,134,121,136,171,62,123,85,71,205,110,152,53,121,163,243,172,229,46,171,4,87,206,17,176,198,74,94,229,214,24,215,86,214,202,108,3,116,1,80,150,235,166,109,136,106,134,52,134,144,115,34,43,203,162,85,198,22,98,163,154,74,99,222,182,196,154,86,83,1,210,38,100,160,185,180,90,100,100,23,180,56,55,140,40,253,51,189,95,95,76,159,22,193,117,251,214,111,117,187,33,235,43,195,182,195,158,62,42,205,196,27,96,29,41,224,234,37,85,125,120,11,186,37,100,59,68,234,122,253,3,212,135,183,176,60,222,46,52,111,143,244,252,2,22,70,107,78,39,5,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var deleteRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bc07c289-1319-4c29-92d4-aebdf026812e"),
				ContainerUId = new Guid("3d527ad4-f295-4b8c-a9d8-5bd27c06dc5c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"DeleteRights",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			deleteRightsParameter.SourceValue = new ProcessSchemaParameterValue(deleteRightsParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,139,142,5,0,41,187,76,13,2,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(deleteRightsParameter);
			var addRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d3292ff8-7bbd-45cb-a9ee-cb83ff795d43"),
				ContainerUId = new Guid("3d527ad4-f295-4b8c-a9d8-5bd27c06dc5c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"AddRights",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			addRightsParameter.SourceValue = new ProcessSchemaParameterValue(addRightsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,93,80,203,106,195,48,16,252,21,225,94,163,96,91,242,67,186,166,105,9,148,166,36,208,75,240,97,45,173,18,131,44,7,89,110,9,33,255,94,217,133,30,122,219,153,157,217,221,217,211,125,167,101,162,91,228,41,162,162,74,104,69,121,46,144,130,202,56,21,6,178,82,87,121,166,51,150,172,54,224,14,8,90,6,63,225,12,182,186,11,127,224,25,45,6,148,6,236,136,171,227,48,121,133,50,137,166,87,15,46,96,172,183,253,213,14,55,196,100,245,14,125,196,167,167,121,24,25,174,215,193,135,201,117,225,70,52,4,32,96,2,122,114,140,227,84,232,220,153,236,191,29,250,245,75,231,199,64,186,128,61,25,12,9,23,36,30,199,201,46,10,53,216,69,60,184,245,34,126,106,146,213,39,216,105,89,114,218,141,11,121,84,23,236,225,247,190,102,29,217,127,196,214,98,143,46,200,187,170,88,91,176,212,80,157,138,140,114,173,83,90,183,42,167,130,169,170,210,70,40,149,167,143,104,248,0,31,115,196,91,229,29,98,11,128,43,90,180,166,165,156,165,241,125,12,24,45,235,42,175,75,195,43,85,102,179,101,235,66,140,185,25,236,212,59,121,47,107,94,20,12,42,10,133,208,148,151,6,40,24,222,82,163,170,18,133,65,86,10,254,104,230,48,251,43,122,152,243,29,186,243,37,188,225,23,90,153,100,201,163,249,1,183,167,229,144,190,1,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(addRightsParameter);
			var employee1Parameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("dbe40eec-c9dc-429e-ac14-9fa16d721d13"),
				ContainerUId = new Guid("3d527ad4-f295-4b8c-a9d8-5bd27c06dc5c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"Employee1",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			employee1Parameter.SourceValue = new ProcessSchemaParameterValue(employee1Parameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{c73b530f-d091-4dd0-8bc2-93c77df9cc20}].[Parameter:{a3c7aa4c-5bfb-430e-a3a3-687286f47c61}].[EntityColumn:{684553a7-a59d-46fa-af4b-fc76e9fe3694}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(employee1Parameter);
		}

		protected virtual void InitializeChangeAdminRightsUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4e965dc3-d0a7-4e19-90e1-c7cbf2fc0ab5"),
				ContainerUId = new Guid("fc62fa4b-52eb-4eaa-ad02-5b1dfefe4d77"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"ae46fb87-c02c-4ae8-ad31-a923cdd994cf",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f82856dc-9a64-4a0c-9fb8-9535d9d36049"),
				ContainerUId = new Guid("fc62fa4b-52eb-4eaa-ad02-5b1dfefe4d77"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,77,107,220,48,16,253,43,198,135,158,172,197,150,63,100,185,167,146,110,32,80,210,208,166,165,16,150,48,146,70,89,81,219,114,108,153,54,152,253,239,149,237,221,52,228,80,246,144,75,193,7,107,164,247,230,205,155,145,166,123,51,92,154,218,97,95,105,168,7,140,198,43,85,133,34,161,37,114,1,68,230,12,72,198,57,146,82,42,73,120,145,43,196,52,161,146,37,97,212,66,131,85,184,162,183,202,184,48,50,14,155,161,186,155,254,146,186,126,196,232,94,47,139,175,114,143,13,124,155,19,0,102,133,22,37,35,50,166,146,100,128,37,1,149,38,4,56,77,165,82,156,103,82,135,171,22,9,64,25,213,148,136,44,85,36,67,161,8,71,65,9,203,4,165,130,43,240,12,97,228,122,211,124,4,135,183,166,193,27,232,189,50,159,240,214,206,161,85,67,141,218,109,127,119,61,14,131,177,109,53,225,243,255,237,83,231,203,88,197,93,216,122,108,218,48,242,112,184,1,183,175,194,76,240,28,83,173,137,86,57,157,149,38,68,196,144,19,42,243,36,246,241,36,7,22,70,18,58,55,211,134,31,164,180,99,235,173,232,81,99,143,173,196,23,85,211,92,49,153,128,32,137,194,152,100,121,236,185,178,152,146,152,98,140,158,135,170,2,195,72,129,131,239,80,143,184,8,155,204,220,15,202,243,152,37,154,48,4,238,61,40,40,41,85,2,132,39,92,232,148,165,84,107,122,234,199,39,107,127,142,157,239,197,112,61,54,216,27,121,108,44,250,14,217,190,154,164,109,93,111,235,153,252,250,5,96,109,224,113,243,199,234,73,189,236,204,192,240,16,141,3,94,212,6,91,183,109,165,85,166,125,88,124,61,28,60,166,233,160,55,195,201,201,237,227,8,181,55,192,60,236,255,233,248,197,56,56,219,252,111,245,70,221,105,186,22,205,243,180,43,51,116,53,60,45,235,42,124,247,56,90,247,254,11,130,10,108,215,217,222,141,173,113,79,193,92,101,0,218,227,130,1,107,148,206,51,6,246,87,139,253,230,210,244,131,11,230,187,19,88,29,184,61,6,222,167,177,94,78,72,91,47,135,109,187,57,142,214,202,31,190,210,113,202,43,89,42,242,52,214,68,197,60,33,153,82,49,41,133,164,132,167,146,49,165,185,148,52,222,128,95,0,100,146,228,66,11,146,165,49,18,72,33,37,69,201,104,89,232,140,201,34,217,156,51,248,71,45,135,232,141,60,184,122,19,15,238,174,134,207,51,233,122,243,214,113,216,109,124,244,85,96,91,99,227,251,235,71,228,12,211,14,30,240,252,176,84,211,57,22,206,144,109,235,124,229,235,179,82,77,231,120,122,216,157,92,221,29,252,247,7,212,144,166,153,161,5,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var deleteRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1231ae80-ee39-4ea7-b240-5e40eeb4c9d1"),
				ContainerUId = new Guid("fc62fa4b-52eb-4eaa-ad02-5b1dfefe4d77"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"DeleteRights",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			deleteRightsParameter.SourceValue = new ProcessSchemaParameterValue(deleteRightsParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,139,142,5,0,41,187,76,13,2,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(deleteRightsParameter);
			var addRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("53a4af30-14e3-43b5-8ef1-88f2cf3a040f"),
				ContainerUId = new Guid("fc62fa4b-52eb-4eaa-ad02-5b1dfefe4d77"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"AddRights",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			addRightsParameter.SourceValue = new ProcessSchemaParameterValue(addRightsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,93,81,203,78,195,48,16,252,21,43,92,235,42,173,29,59,206,181,20,84,9,1,2,137,75,149,195,198,94,183,145,28,187,114,28,16,170,250,239,56,129,19,183,157,217,217,199,236,30,175,7,211,20,90,67,93,85,188,163,26,172,165,92,109,129,42,161,128,138,90,73,107,21,19,92,214,197,106,7,254,13,193,52,41,78,56,131,189,233,83,99,193,141,11,186,71,135,9,255,240,123,152,162,198,166,96,197,234,49,130,79,152,227,253,112,113,225,27,177,88,61,195,144,241,241,110,238,70,194,229,18,98,154,124,159,190,137,129,4,4,108,194,72,198,220,78,167,222,159,72,248,242,24,215,15,125,28,19,233,19,14,36,88,146,206,72,34,142,147,91,20,58,184,69,28,252,250,101,22,223,181,197,234,3,220,180,12,57,30,198,133,124,215,103,28,224,119,191,118,157,217,127,196,222,225,128,62,53,87,45,89,87,177,210,82,83,170,13,229,198,148,180,238,244,150,42,166,165,52,86,105,189,45,111,185,224,21,98,246,145,119,109,174,144,83,0,92,211,170,179,29,229,172,68,10,12,88,190,159,220,214,194,114,169,197,102,46,217,251,148,109,238,130,155,6,223,92,69,205,171,138,129,164,80,41,67,185,176,64,193,230,39,88,45,5,42,139,76,40,126,107,103,51,47,23,140,48,251,123,235,79,231,244,132,159,232,154,98,83,220,218,31,203,76,157,36,191,1,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(addRightsParameter);
			var employee1Parameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("cca8554b-caff-492a-969a-6897ff936478"),
				ContainerUId = new Guid("fc62fa4b-52eb-4eaa-ad02-5b1dfefe4d77"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"Employee1",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			employee1Parameter.SourceValue = new ProcessSchemaParameterValue(employee1Parameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{c73b530f-d091-4dd0-8bc2-93c77df9cc20}].[Parameter:{a3c7aa4c-5bfb-430e-a3a3-687286f47c61}].[EntityColumn:{684553a7-a59d-46fa-af4b-fc76e9fe3694}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(employee1Parameter);
		}

		protected virtual void InitializeIntermediateCatchSignalEvent1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("09cca40d-6c18-48f7-9457-13734419af29"),
				ContainerUId = new Guid("b0a72e82-9fc1-437a-ae75-2166804d3791"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0a72e82-9fc1-437a-ae75-2166804d3791"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{4c6e9a6c-52a3-4f25-879f-96941c1aa349}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeReadDataUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6ae9a99b-d2db-4a58-b211-f6e962641886"),
				ContainerUId = new Guid("c73b530f-d091-4dd0-8bc2-93c77df9cc20"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,20,252,43,69,135,158,172,98,89,178,108,57,199,101,91,246,146,6,154,150,66,178,132,103,233,41,43,240,87,108,137,102,49,251,223,43,175,179,41,228,80,10,61,5,116,144,158,52,243,102,134,167,249,193,77,159,93,227,113,172,44,52,19,38,97,103,42,82,107,133,12,68,73,107,83,48,42,20,72,90,51,193,40,170,20,65,10,91,90,43,72,210,65,139,21,89,209,91,227,60,73,156,199,118,170,238,230,63,164,126,12,152,60,216,243,225,155,62,96,11,223,151,6,128,66,218,186,44,168,78,51,77,5,96,73,193,112,70,65,101,92,27,163,148,208,150,172,90,100,158,66,201,106,69,69,158,213,84,72,206,169,202,141,161,105,109,11,41,75,166,149,229,36,105,208,250,237,243,48,226,52,185,190,171,102,124,221,223,30,135,168,114,237,189,233,155,208,118,36,105,209,195,13,248,195,34,36,69,145,107,160,90,168,156,10,139,5,5,174,12,229,80,23,89,81,34,147,172,32,137,134,193,47,180,100,103,72,98,192,195,15,104,2,158,153,103,23,53,102,60,101,101,46,35,150,241,104,135,103,41,45,101,116,103,141,180,10,185,84,170,54,151,188,190,4,23,247,110,186,14,45,142,78,191,196,142,49,191,126,172,102,221,119,126,236,155,133,250,250,252,252,22,159,253,26,238,203,213,207,213,144,143,245,5,68,78,73,152,112,211,56,236,252,182,211,189,113,221,227,202,121,58,69,72,59,192,232,166,75,10,219,167,0,13,73,70,247,120,248,107,90,155,48,249,190,125,71,86,147,104,51,114,196,33,59,203,93,102,208,184,105,104,224,120,62,87,228,227,83,232,253,213,38,140,99,4,127,232,135,161,31,125,232,156,63,174,23,228,13,65,69,238,137,208,18,227,228,107,154,103,192,227,104,100,57,45,11,101,169,146,74,48,205,0,184,80,247,36,138,250,255,86,119,187,233,235,175,238,242,67,86,79,251,79,177,250,166,112,115,65,86,243,191,168,59,237,23,125,251,83,92,191,1,80,88,168,180,232,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8f241b16-53a3-4a3f-bca5-3fb01c76cdd9"),
				ContainerUId = new Guid("c73b530f-d091-4dd0-8bc2-93c77df9cc20"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("feb5fafe-ddb7-4fe9-b154-6aef4a84a2cf"),
				ContainerUId = new Guid("c73b530f-d091-4dd0-8bc2-93c77df9cc20"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dee4a26d-9bf8-4814-aeaa-2079ae11751d"),
				ContainerUId = new Guid("c73b530f-d091-4dd0-8bc2-93c77df9cc20"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b36aaeec-e9e9-4b97-83b4-c930ade9d221"),
				ContainerUId = new Guid("c73b530f-d091-4dd0-8bc2-93c77df9cc20"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("93823506-41d3-455a-be79-cd11bd04d813"),
				ContainerUId = new Guid("c73b530f-d091-4dd0-8bc2-93c77df9cc20"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6f281dc6-1639-492d-b3a7-91eea3ca365f"),
				ContainerUId = new Guid("c73b530f-d091-4dd0-8bc2-93c77df9cc20"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,9,201,44,201,73,181,50,180,50,4,0,57,183,224,50,16,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("a3c7aa4c-5bfb-430e-a3a3-687286f47c61"),
				ContainerUId = new Guid("c73b530f-d091-4dd0-8bc2-93c77df9cc20"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("08fb2ebc-49a5-4226-98ba-39f6038c9c60"),
				ContainerUId = new Guid("c73b530f-d091-4dd0-8bc2-93c77df9cc20"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1fb6d738-110a-43fc-b8d1-6ad1b87f1781"),
				ContainerUId = new Guid("c73b530f-d091-4dd0-8bc2-93c77df9cc20"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f96019c2-3d7b-4c65-af7c-00f7360fdef1"),
				ContainerUId = new Guid("c73b530f-d091-4dd0-8bc2-93c77df9cc20"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("607243ca-d4f9-4326-ba0d-63444eb5120f"),
				ContainerUId = new Guid("c73b530f-d091-4dd0-8bc2-93c77df9cc20"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5eef0b4b-0874-4d83-bc5e-5cd3703dc83e"),
				ContainerUId = new Guid("c73b530f-d091-4dd0-8bc2-93c77df9cc20"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("960b87b1-7cf1-4c07-9505-dcda4ff83c63"),
				ContainerUId = new Guid("c73b530f-d091-4dd0-8bc2-93c77df9cc20"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("32c63487-e6c1-47ec-90de-78ac92f5bc30"),
				ContainerUId = new Guid("c73b530f-d091-4dd0-8bc2-93c77df9cc20"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8633d044-d682-4d53-abc5-2ebe81cc2939"),
				ContainerUId = new Guid("c73b530f-d091-4dd0-8bc2-93c77df9cc20"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a147c744-f32b-48b9-a6b4-71a9270154db"),
				ContainerUId = new Guid("c73b530f-d091-4dd0-8bc2-93c77df9cc20"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6b0b18f7-2baa-456c-9d14-bec0da9c1525"),
				ContainerUId = new Guid("c73b530f-d091-4dd0-8bc2-93c77df9cc20"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("294349f9-aad1-46d2-a999-a076e9a3e823"),
				ContainerUId = new Guid("c73b530f-d091-4dd0-8bc2-93c77df9cc20"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeReadDataUserTask3Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("113f4e62-765c-44d4-8ae1-58cf9d82d61f"),
				ContainerUId = new Guid("da320ded-d51f-4e8a-8548-66d935dce5b4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,85,219,138,220,70,16,253,149,161,31,242,164,30,250,126,81,30,215,99,179,144,108,76,226,132,128,189,152,190,84,239,54,209,72,99,169,149,120,25,230,223,221,26,121,18,99,54,97,19,130,193,47,162,111,117,170,234,84,157,210,241,109,158,158,231,174,192,216,38,215,77,208,204,215,177,69,70,18,77,18,225,216,18,43,176,48,38,96,151,40,224,192,34,11,140,7,163,165,71,77,239,246,208,162,213,122,23,115,65,77,46,176,159,218,215,199,191,64,203,56,67,243,54,157,55,63,133,123,216,187,159,23,7,50,26,33,149,23,152,74,32,88,68,144,216,147,250,113,201,83,146,148,182,50,16,180,198,18,45,87,201,202,250,32,68,139,133,98,30,59,65,60,142,194,81,206,169,215,68,82,212,116,144,202,238,253,97,132,105,202,67,223,30,225,207,245,171,135,67,141,114,245,125,53,116,243,190,71,205,30,138,123,233,202,125,139,28,16,16,50,56,28,132,149,88,36,208,216,113,27,49,119,94,51,109,128,42,170,81,19,220,161,44,176,232,58,162,38,186,226,126,113,221,12,103,228,99,174,49,50,78,168,145,170,218,82,30,176,224,140,96,163,140,198,41,214,208,129,43,107,125,188,240,245,98,206,117,157,167,155,121,15,99,14,31,105,135,202,223,48,182,199,48,244,101,28,186,5,250,230,252,252,21,188,47,43,185,31,175,126,93,19,42,245,124,49,66,167,102,158,224,170,203,208,151,93,31,134,152,251,187,21,243,116,170,38,251,131,27,243,116,97,97,247,110,118,29,106,198,124,119,255,143,108,93,205,83,25,246,95,81,170,77,77,179,98,212,38,59,135,187,244,96,204,211,161,115,15,231,125,139,190,121,55,15,229,219,31,193,197,205,112,56,12,99,153,251,92,30,54,75,130,219,231,121,156,202,102,233,221,77,238,55,149,136,185,43,21,122,19,134,174,131,176,20,126,251,44,255,158,23,122,86,24,244,153,187,22,189,65,140,218,24,180,13,152,251,176,72,38,58,236,165,215,85,65,17,18,80,7,65,144,173,32,156,243,196,52,86,68,243,218,109,49,97,67,107,223,17,167,149,16,38,112,34,201,150,202,84,181,103,41,6,165,18,22,44,122,108,136,246,56,137,192,92,84,156,107,175,222,160,74,198,151,78,241,245,245,244,195,31,253,69,199,43,243,183,219,122,250,217,193,174,131,125,45,81,123,124,10,39,167,106,240,242,226,170,61,62,133,161,197,100,215,151,154,220,170,231,246,248,20,202,78,183,11,105,183,85,21,255,235,120,226,140,5,71,153,194,194,242,154,99,136,17,187,24,0,131,208,65,50,81,71,165,137,255,125,60,129,244,44,249,96,49,183,188,14,63,30,25,54,66,112,236,156,12,214,27,197,153,228,159,140,167,239,93,239,238,96,172,10,175,252,142,208,7,248,36,41,170,124,213,167,164,216,36,96,88,80,105,177,137,145,96,103,8,143,66,25,30,35,127,84,242,158,217,250,63,160,9,107,112,53,8,80,53,136,72,29,182,212,250,196,53,103,41,177,139,228,191,27,134,223,230,195,191,16,253,106,240,152,236,187,243,205,223,10,127,41,221,35,35,238,122,186,25,202,205,220,117,75,173,63,0,61,86,32,219,222,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("081ada6f-f2ec-42a9-9282-5b3d9c407f55"),
				ContainerUId = new Guid("da320ded-d51f-4e8a-8548-66d935dce5b4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("50975cf4-f986-42be-848f-f2dbab118fa5"),
				ContainerUId = new Guid("da320ded-d51f-4e8a-8548-66d935dce5b4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8e5ac671-36f1-474e-9cff-66a8407b8fa5"),
				ContainerUId = new Guid("da320ded-d51f-4e8a-8548-66d935dce5b4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e0169671-eb4f-4762-b6a3-191c60062fb3"),
				ContainerUId = new Guid("da320ded-d51f-4e8a-8548-66d935dce5b4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("19d5393e-631c-4edd-b20b-b75111f8c70b"),
				ContainerUId = new Guid("da320ded-d51f-4e8a-8548-66d935dce5b4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0498e93f-e38c-409f-a4b4-8d6ca4869331"),
				ContainerUId = new Guid("da320ded-d51f-4e8a-8548-66d935dce5b4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,248,134,94,83,15,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("5d8456b4-15e0-4de5-b0e5-afb10f6795c0"),
				UId = new Guid("b2e51ef1-6aab-4ca1-8848-6008a8d519a5"),
				ContainerUId = new Guid("da320ded-d51f-4e8a-8548-66d935dce5b4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1e00e7f8-aeee-4b21-a00c-23045ba60e93"),
				ContainerUId = new Guid("da320ded-d51f-4e8a-8548-66d935dce5b4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bf8fa2bb-6f13-45d3-8ac3-1af8add4e2e1"),
				ContainerUId = new Guid("da320ded-d51f-4e8a-8548-66d935dce5b4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b11bba9c-7570-4c91-b5b8-ce0f87f32de9"),
				ContainerUId = new Guid("da320ded-d51f-4e8a-8548-66d935dce5b4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3f45a94b-9b1a-45bc-a1eb-1c63396fd296"),
				ContainerUId = new Guid("da320ded-d51f-4e8a-8548-66d935dce5b4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("65beb8a8-7a77-4d89-b41a-5e90a25bf16f"),
				ContainerUId = new Guid("da320ded-d51f-4e8a-8548-66d935dce5b4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("70f9d4af-0491-4dd3-bc7e-64f44d775fc3"),
				ContainerUId = new Guid("da320ded-d51f-4e8a-8548-66d935dce5b4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("5d8456b4-15e0-4de5-b0e5-afb10f6795c0"),
				UId = new Guid("02165bd8-27fb-4e68-8dbc-6910d0dd6351"),
				ContainerUId = new Guid("da320ded-d51f-4e8a-8548-66d935dce5b4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c018b09d-9be8-4dc0-94a3-6a98bb7f7223"),
				ContainerUId = new Guid("da320ded-d51f-4e8a-8548-66d935dce5b4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b90f88bb-6a42-491a-b18c-602ac3087bbb"),
				ContainerUId = new Guid("da320ded-d51f-4e8a-8548-66d935dce5b4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("61e3d8cf-9ddc-4ab6-89f2-6c7c56ad263b"),
				ContainerUId = new Guid("da320ded-d51f-4e8a-8548-66d935dce5b4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("951b30fa-c86c-4c03-9672-c8029124a84c"),
				ContainerUId = new Guid("da320ded-d51f-4e8a-8548-66d935dce5b4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeReadDataUserTask4Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a20fbdf2-0724-4878-885a-78691620252b"),
				ContainerUId = new Guid("dd4cc279-afe1-401f-a48a-8aa72c711e42"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,148,93,139,220,54,20,134,255,202,224,139,94,249,12,146,245,237,94,110,38,97,161,221,134,54,45,133,100,9,250,56,218,21,245,216,19,91,110,179,12,243,223,35,143,51,109,8,219,178,45,37,144,27,99,75,62,175,206,121,116,222,115,124,155,166,231,169,203,56,182,209,118,19,214,243,117,104,43,21,3,53,40,60,40,19,24,112,97,3,88,34,21,248,200,57,67,107,153,240,88,213,189,221,99,91,173,209,187,144,114,85,167,140,251,169,125,125,252,75,52,143,51,214,111,227,249,227,39,127,143,123,251,243,114,128,8,154,11,233,56,80,129,4,120,64,1,142,148,135,141,142,146,40,149,17,158,84,107,46,65,72,238,89,244,32,208,112,224,196,51,208,222,123,48,13,137,218,51,210,112,174,170,186,195,152,119,239,15,35,78,83,26,250,246,136,127,190,191,122,56,148,44,215,179,175,134,110,222,247,85,189,199,108,95,218,124,223,86,22,9,114,225,45,120,110,4,240,136,10,44,51,1,152,117,170,81,26,169,164,69,221,219,67,94,100,171,235,80,213,193,102,251,139,237,102,60,43,31,83,201,177,97,132,106,81,0,89,202,60,112,214,16,208,82,43,136,65,70,131,76,26,227,194,133,215,139,57,149,247,52,221,204,123,28,147,255,136,29,11,191,97,108,143,126,232,243,56,116,139,244,205,249,247,87,248,62,175,112,63,110,253,186,22,148,203,250,18,84,157,234,121,194,171,46,97,159,119,189,31,66,234,239,86,205,211,169,132,236,15,118,76,211,133,194,238,221,108,187,170,30,211,221,253,63,210,186,154,167,60,236,191,162,82,235,82,102,209,40,77,118,78,119,233,193,144,166,67,103,31,206,223,109,245,205,187,121,200,223,254,136,54,108,134,195,97,24,243,220,167,252,176,89,10,220,62,79,227,148,55,75,239,110,82,191,41,32,230,46,23,233,141,31,186,14,253,114,241,219,103,233,247,180,224,89,101,170,207,142,107,171,55,85,67,77,240,202,120,96,206,151,54,213,193,130,19,78,129,33,1,35,82,139,158,147,45,39,140,177,216,40,144,68,21,95,197,16,65,211,210,119,196,42,201,249,210,205,130,108,169,136,36,18,67,1,165,140,192,155,224,64,19,229,32,114,223,216,32,25,83,78,190,169,10,140,47,93,226,235,235,233,135,63,250,139,143,87,242,183,219,178,250,217,194,174,195,125,185,162,246,248,20,38,167,18,240,242,114,84,123,124,10,161,37,100,215,231,82,220,234,231,246,248,20,100,167,219,5,218,109,113,197,255,58,158,168,247,212,73,137,101,74,82,89,252,16,154,242,87,212,16,24,10,29,131,51,33,226,127,31,79,40,92,19,157,55,192,12,51,171,186,46,35,24,172,21,222,56,45,89,35,216,39,227,233,123,219,219,59,28,139,195,11,223,17,123,143,159,20,69,165,43,254,20,20,116,196,6,56,21,6,116,8,4,172,38,44,112,169,89,8,236,81,203,187,198,8,162,104,4,133,182,36,129,178,36,17,168,5,67,141,139,76,177,38,198,230,98,249,239,134,225,183,249,240,47,76,191,6,60,102,251,238,188,243,183,198,95,174,238,145,17,119,61,221,12,249,102,238,186,229,174,63,0,230,134,229,47,222,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("27339781-38b3-4487-9014-db0a37f14b83"),
				ContainerUId = new Guid("dd4cc279-afe1-401f-a48a-8aa72c711e42"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4521de8c-08bc-444c-b658-6c4d2a4e5fe3"),
				ContainerUId = new Guid("dd4cc279-afe1-401f-a48a-8aa72c711e42"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7d343aa0-5460-4284-979f-8f5994a7d42b"),
				ContainerUId = new Guid("dd4cc279-afe1-401f-a48a-8aa72c711e42"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e1b48494-ddbb-473b-a958-1051eee1f98a"),
				ContainerUId = new Guid("dd4cc279-afe1-401f-a48a-8aa72c711e42"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("70780388-abf3-42af-893d-f28adb4649e9"),
				ContainerUId = new Guid("dd4cc279-afe1-401f-a48a-8aa72c711e42"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,1,0,242,67,189,42,2,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("aec5d8f1-c2e7-4e32-a7c0-04acfef39267"),
				ContainerUId = new Guid("dd4cc279-afe1-401f-a48a-8aa72c711e42"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,75,204,77,181,50,180,50,4,0,203,8,241,43,15,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("5d8456b4-15e0-4de5-b0e5-afb10f6795c0"),
				UId = new Guid("bee4631c-fc60-4367-b698-697143c1db86"),
				ContainerUId = new Guid("dd4cc279-afe1-401f-a48a-8aa72c711e42"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a3bc60f3-2c39-4535-b598-fbd578d70e3e"),
				ContainerUId = new Guid("dd4cc279-afe1-401f-a48a-8aa72c711e42"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("abc3c14b-0934-40d2-bbe4-d7850d2fbf68"),
				ContainerUId = new Guid("dd4cc279-afe1-401f-a48a-8aa72c711e42"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("769bd711-c503-449a-b51c-4a46a32185a4"),
				ContainerUId = new Guid("dd4cc279-afe1-401f-a48a-8aa72c711e42"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3f93d92a-65c1-4d5d-a345-d590032b6d6f"),
				ContainerUId = new Guid("dd4cc279-afe1-401f-a48a-8aa72c711e42"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4c78f474-685f-4529-81f4-9021f679a821"),
				ContainerUId = new Guid("dd4cc279-afe1-401f-a48a-8aa72c711e42"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("092e4b03-f419-48ef-a4be-8468d71225ed"),
				ContainerUId = new Guid("dd4cc279-afe1-401f-a48a-8aa72c711e42"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("5d8456b4-15e0-4de5-b0e5-afb10f6795c0"),
				UId = new Guid("e799395e-b3b7-458a-83af-8462a0ee992e"),
				ContainerUId = new Guid("dd4cc279-afe1-401f-a48a-8aa72c711e42"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5e3110b5-1123-4cb7-b152-accafabe8138"),
				ContainerUId = new Guid("dd4cc279-afe1-401f-a48a-8aa72c711e42"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3dd48f20-8cf8-49bb-802a-23fa55d6001d"),
				ContainerUId = new Guid("dd4cc279-afe1-401f-a48a-8aa72c711e42"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c22bc1d6-ca51-406d-91f3-c32ff0511135"),
				ContainerUId = new Guid("dd4cc279-afe1-401f-a48a-8aa72c711e42"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8a75e1d4-a585-49a8-a159-b053271cf991"),
				ContainerUId = new Guid("dd4cc279-afe1-401f-a48a-8aa72c711e42"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeChangeAdminRightsUserTask3Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e7f3928e-a4d5-465d-bbc7-a71f81fc3a25"),
				ContainerUId = new Guid("9953d48c-257d-4ca8-84fc-cae371581aa3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"16be3651-8fe2-4159-8dd0-a803d4683dd3",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5a649550-03e1-4b0f-bc8c-d2de65fc0b09"),
				ContainerUId = new Guid("9953d48c-257d-4ca8-84fc-cae371581aa3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,77,107,220,48,20,252,43,70,135,158,172,197,182,108,73,118,143,203,166,228,146,134,54,45,133,36,132,39,233,41,17,248,99,99,203,52,97,217,255,222,231,117,210,66,14,37,199,22,124,208,199,155,209,204,232,201,135,187,48,157,133,54,226,216,120,104,39,76,231,115,215,176,170,46,170,92,10,195,243,50,147,188,84,22,57,160,68,94,20,181,174,45,42,109,140,103,105,15,29,54,108,69,239,92,136,44,13,17,187,169,185,62,252,33,141,227,140,233,157,63,77,190,218,7,236,224,219,114,64,46,13,10,89,229,92,123,44,120,153,87,53,215,206,101,28,116,38,92,41,181,112,78,176,85,139,213,162,50,96,36,215,86,40,210,130,134,131,178,138,235,18,43,167,165,51,10,168,180,69,31,119,79,251,17,167,41,12,125,115,192,223,227,171,231,61,169,92,207,222,14,237,220,245,44,237,48,194,37,196,135,134,1,102,88,86,22,184,45,235,138,151,30,21,7,81,59,46,192,168,66,105,204,101,174,88,106,97,31,23,90,118,238,88,234,32,194,119,104,103,60,49,31,2,105,44,68,150,235,74,18,54,23,150,151,162,200,184,150,90,113,239,164,175,201,104,93,27,247,154,215,167,57,208,56,76,23,115,135,99,176,47,177,35,229,55,140,205,193,14,125,28,135,118,161,190,56,149,95,225,83,92,195,125,217,250,177,26,138,180,190,128,216,49,157,39,220,182,1,251,184,235,237,224,66,127,191,114,30,143,4,233,246,48,134,233,53,133,221,227,12,45,75,199,112,255,240,215,180,182,243,20,135,238,63,178,154,146,77,226,160,38,59,201,93,122,208,133,105,223,194,243,105,222,176,15,143,243,16,63,126,65,112,201,176,223,15,99,156,251,16,159,147,197,96,2,158,112,201,132,45,218,72,148,73,124,192,100,248,217,227,184,57,11,227,20,147,165,171,147,193,39,20,209,220,158,42,236,208,158,138,135,126,179,37,169,96,227,202,207,222,232,104,216,13,179,74,152,74,100,158,187,172,206,121,185,116,185,54,182,224,181,176,74,57,95,91,91,100,27,160,9,64,105,121,101,188,161,84,51,122,112,2,4,167,100,11,45,61,189,64,153,111,100,9,25,237,3,23,85,230,136,201,120,110,188,211,220,155,74,213,160,74,47,106,188,97,148,210,63,227,253,250,124,250,188,144,173,175,111,189,171,219,13,173,190,89,216,181,216,209,165,82,79,188,35,172,35,1,46,95,143,106,14,239,137,110,129,236,250,72,174,215,63,64,115,120,79,150,199,219,37,205,219,35,125,191,0,170,240,95,94,39,5,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var deleteRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d450dd6d-3502-4a49-93dc-3796f8d6b862"),
				ContainerUId = new Guid("9953d48c-257d-4ca8-84fc-cae371581aa3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"DeleteRights",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			deleteRightsParameter.SourceValue = new ProcessSchemaParameterValue(deleteRightsParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,139,142,5,0,41,187,76,13,2,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(deleteRightsParameter);
			var addRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c573582f-cae6-4f5d-9f77-cddaff23070d"),
				ContainerUId = new Guid("9953d48c-257d-4ca8-84fc-cae371581aa3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"AddRights",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			addRightsParameter.SourceValue = new ProcessSchemaParameterValue(addRightsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,93,80,193,110,194,48,12,253,149,168,187,54,40,52,165,161,189,50,54,33,77,99,2,105,23,196,193,77,28,168,148,38,40,117,55,33,196,191,47,101,210,14,187,249,217,126,126,126,239,112,219,152,38,19,178,45,132,154,3,183,69,173,120,105,160,224,117,105,4,215,10,12,66,165,171,57,66,150,175,192,239,16,76,67,113,196,9,172,77,71,127,224,25,29,18,54,22,220,128,249,62,140,81,99,147,201,44,127,141,224,9,83,189,238,47,46,92,17,179,252,29,250,132,15,79,211,49,22,46,151,16,105,244,29,93,153,1,2,6,150,48,178,33,157,211,212,249,19,163,51,178,240,237,49,206,94,186,56,16,235,8,123,22,44,139,56,140,238,177,161,131,123,44,7,63,91,5,79,160,233,233,152,229,159,224,198,135,204,97,51,108,39,254,94,159,177,135,223,15,143,179,212,253,215,88,59,236,209,83,115,211,74,182,11,41,44,55,162,158,167,52,82,16,203,86,167,72,164,86,202,216,90,235,66,220,19,225,3,98,114,146,190,109,110,144,70,0,165,230,139,214,182,188,148,2,57,72,144,188,90,170,98,89,217,82,165,8,39,202,218,83,50,186,10,110,236,125,115,171,74,16,137,0,92,46,132,73,66,173,229,173,53,75,110,219,133,170,65,149,86,214,120,63,78,102,182,23,140,48,57,220,117,167,51,189,225,23,186,38,155,103,247,227,15,31,118,193,246,192,1,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(addRightsParameter);
			var employee1Parameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("03b2071a-f297-4da2-94d0-c7adea6c61ea"),
				ContainerUId = new Guid("9953d48c-257d-4ca8-84fc-cae371581aa3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"Employee1",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			employee1Parameter.SourceValue = new ProcessSchemaParameterValue(employee1Parameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{c73b530f-d091-4dd0-8bc2-93c77df9cc20}].[Parameter:{a3c7aa4c-5bfb-430e-a3a3-687286f47c61}].[EntityColumn:{64a05bfa-350d-4dbf-bfd8-fb579a74f39e}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(employee1Parameter);
		}

		protected virtual void InitializeChangeAdminRightsUserTask4Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c2fd6fee-f1c7-45e7-ac9a-c1ab494df220"),
				ContainerUId = new Guid("bfa78fda-181f-4764-8b3a-2f4b75e455ea"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"ae46fb87-c02c-4ae8-ad31-a923cdd994cf",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b7a5464f-131b-4b4c-8a32-1f2138329f44"),
				ContainerUId = new Guid("bfa78fda-181f-4764-8b3a-2f4b75e455ea"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,93,107,157,64,16,253,43,226,67,159,220,139,186,171,171,246,241,114,3,129,146,134,126,17,8,33,140,187,179,185,82,117,141,174,180,65,252,239,29,245,222,54,228,161,220,199,22,68,220,143,51,115,230,204,25,167,199,106,184,170,106,135,125,97,160,30,48,24,175,117,225,103,42,133,48,41,13,203,66,101,152,16,165,100,0,40,88,170,68,104,36,202,72,36,210,15,90,104,176,240,55,244,65,87,206,15,42,135,205,80,220,79,127,130,186,126,196,224,209,172,139,207,234,136,13,124,93,18,80,176,212,148,153,100,42,140,21,19,128,25,3,205,35,6,121,204,149,214,121,46,148,241,55,46,148,43,142,227,136,110,233,56,99,130,39,17,43,19,73,175,44,53,137,9,35,19,133,220,15,106,52,238,240,179,235,113,24,42,219,22,19,254,254,254,242,210,17,203,45,247,222,214,99,211,250,65,131,14,110,193,29,11,63,21,107,161,192,120,18,106,74,65,53,151,70,103,204,80,142,28,164,48,60,71,63,80,208,185,37,172,191,183,173,3,69,149,246,104,176,199,86,225,171,162,162,180,68,158,18,191,204,96,204,68,148,228,44,211,58,100,144,133,92,139,52,227,90,19,83,13,14,190,65,61,226,74,108,170,8,88,198,121,18,202,200,48,137,144,51,129,105,76,192,8,88,30,229,165,225,146,199,198,196,103,185,63,88,251,125,236,72,234,225,102,108,176,175,212,169,111,72,13,176,125,49,41,98,216,219,122,9,126,243,10,176,245,231,116,120,183,105,82,175,39,11,208,159,131,113,192,125,93,97,235,14,173,178,186,106,159,214,214,205,51,97,154,14,250,106,56,43,121,120,30,161,38,1,170,167,227,95,21,223,143,131,179,205,255,86,111,64,181,82,24,114,235,202,121,49,179,174,134,174,134,151,117,93,248,239,158,71,235,222,127,66,208,158,237,58,219,187,177,173,220,139,183,84,233,129,33,156,55,96,141,202,81,68,207,29,209,179,63,90,236,119,87,85,63,56,111,25,15,207,26,143,116,26,235,245,134,178,245,122,217,182,187,147,181,182,248,254,27,30,231,188,74,242,50,225,161,97,58,204,35,178,43,185,43,43,85,204,114,174,164,212,38,87,42,14,119,64,11,0,161,24,25,187,164,137,9,145,1,7,206,210,76,198,52,52,66,170,52,218,93,98,252,19,151,57,248,167,52,184,191,30,62,46,1,183,201,219,236,240,176,163,221,55,27,135,26,27,234,47,89,228,2,209,102,2,220,158,211,21,211,37,18,46,144,67,235,168,242,237,183,82,76,151,104,58,63,156,85,125,152,233,249,5,1,227,254,146,128,5,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var deleteRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("310641c2-c313-4ca7-9003-58bb95ba5d84"),
				ContainerUId = new Guid("bfa78fda-181f-4764-8b3a-2f4b75e455ea"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"DeleteRights",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			deleteRightsParameter.SourceValue = new ProcessSchemaParameterValue(deleteRightsParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,139,142,5,0,41,187,76,13,2,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(deleteRightsParameter);
			var addRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0f101973-6976-4c62-8342-e1c9f265457a"),
				ContainerUId = new Guid("bfa78fda-181f-4764-8b3a-2f4b75e455ea"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"AddRights",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			addRightsParameter.SourceValue = new ProcessSchemaParameterValue(addRightsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,93,79,65,78,195,48,16,252,138,21,174,117,149,118,29,187,201,181,20,132,132,40,2,137,75,213,195,198,94,211,72,142,93,57,14,168,170,250,119,156,192,137,219,206,236,204,238,204,225,250,100,154,162,174,165,109,21,148,124,173,37,112,161,1,56,182,82,115,5,74,0,89,208,176,42,139,197,22,253,27,161,105,82,28,105,2,59,211,165,198,162,27,102,116,79,142,18,253,225,247,48,70,77,77,1,197,226,49,162,79,148,231,93,127,118,225,66,84,44,94,176,207,248,112,55,93,99,225,124,14,49,141,190,75,23,102,48,33,67,155,40,178,33,159,211,169,243,159,44,157,136,133,111,79,113,249,208,197,33,177,46,81,207,130,101,145,134,209,205,10,29,220,44,14,126,185,159,132,119,199,98,241,129,110,156,159,28,158,134,153,124,215,39,234,241,55,223,113,153,217,127,196,206,81,79,62,53,87,173,160,173,160,180,220,148,245,138,11,99,74,190,105,245,154,215,160,149,50,182,214,122,93,222,178,225,21,99,238,145,179,54,87,204,43,68,161,121,213,218,150,11,40,137,35,32,112,185,81,235,141,180,66,105,185,154,44,59,159,114,205,109,112,99,239,155,171,220,136,170,2,84,28,171,218,112,33,45,114,180,162,229,86,43,73,181,37,144,181,184,29,167,50,251,51,69,156,250,189,117,159,167,244,76,95,228,154,98,85,220,142,63,160,13,224,194,191,1,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(addRightsParameter);
			var employee1Parameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("996fb730-2c63-4c33-ab6c-73743ef3c310"),
				ContainerUId = new Guid("bfa78fda-181f-4764-8b3a-2f4b75e455ea"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"Employee1",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			employee1Parameter.SourceValue = new ProcessSchemaParameterValue(employee1Parameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{c73b530f-d091-4dd0-8bc2-93c77df9cc20}].[Parameter:{a3c7aa4c-5bfb-430e-a3a3-687286f47c61}].[EntityColumn:{684553a7-a59d-46fa-af4b-fc76e9fe3694}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(employee1Parameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaProspecting = CreateProspectingLaneSet();
			LaneSets.Add(schemaProspecting);
			ProcessSchemaLane schemaSalesManager = CreateSalesManagerLane();
			schemaProspecting.Lanes.Add(schemaSalesManager);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaUserTask openeditpageusertask1 = CreateOpenEditPageUserTask1UserTask();
			FlowElements.Add(openeditpageusertask1);
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			ProcessSchemaUserTask changeadminrightsusertask1 = CreateChangeAdminRightsUserTask1UserTask();
			FlowElements.Add(changeadminrightsusertask1);
			ProcessSchemaUserTask changeadminrightsusertask2 = CreateChangeAdminRightsUserTask2UserTask();
			FlowElements.Add(changeadminrightsusertask2);
			ProcessSchemaIntermediateCatchSignalEvent intermediatecatchsignalevent1 = CreateIntermediateCatchSignalEvent1IntermediateCatchSignalEvent();
			FlowElements.Add(intermediatecatchsignalevent1);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			ProcessSchemaUserTask readdatausertask2 = CreateReadDataUserTask2UserTask();
			FlowElements.Add(readdatausertask2);
			ProcessSchemaTerminateEvent terminate2 = CreateTerminate2TerminateEvent();
			FlowElements.Add(terminate2);
			ProcessSchemaUserTask readdatausertask3 = CreateReadDataUserTask3UserTask();
			FlowElements.Add(readdatausertask3);
			ProcessSchemaUserTask readdatausertask4 = CreateReadDataUserTask4UserTask();
			FlowElements.Add(readdatausertask4);
			ProcessSchemaFormulaTask formulatask2 = CreateFormulaTask2FormulaTask();
			FlowElements.Add(formulatask2);
			ProcessSchemaFormulaTask formulatask3 = CreateFormulaTask3FormulaTask();
			FlowElements.Add(formulatask3);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			FlowElements.Add(scripttask1);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask changeadminrightsusertask3 = CreateChangeAdminRightsUserTask3UserTask();
			FlowElements.Add(changeadminrightsusertask3);
			ProcessSchemaUserTask changeadminrightsusertask4 = CreateChangeAdminRightsUserTask4UserTask();
			FlowElements.Add(changeadminrightsusertask4);
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateConditionalFlow4ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateConditionalFlow5ConditionalFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("6f29b238-4584-4950-b6ad-b68667918619"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				CurveCenterPosition = new Point(522, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3d527ad4-f295-4b8c-a9d8-5bd27c06dc5c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fc62fa4b-52eb-4eaa-ad02-5b1dfefe4d77"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("1b71a3e8-6c51-490e-9444-e5f6d5cf43fd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				CurveCenterPosition = new Point(152, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("80ba5382-aa5f-407f-adb0-a09f93271323"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("219dc79c-3bc4-48da-b5b7-90defe1aec40"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("1b51c7a8-2830-4a6f-92ee-2073ea6ca9c1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				CurveCenterPosition = new Point(436, 206),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b0b23273-c3ed-47d0-bab7-c44b1459da2c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("15cfe4b9-aede-4d41-8c5a-58dc03ead64a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("126115de-6094-4d04-b02d-edb4098a40a6"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				CurveCenterPosition = new Point(96, 256),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("80ba5382-aa5f-407f-adb0-a09f93271323"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b0a72e82-9fc1-437a-ae75-2166804d3791"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("b7b9cf0a-fcd3-4e86-aeae-88c3bf0a6266"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("126115de-6094-4d04-b02d-edb4098a40a6"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				CurveCenterPosition = new Point(481, 260),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b0a72e82-9fc1-437a-ae75-2166804d3791"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4529baea-eac0-49a9-818f-ed63ef212d92"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("60146d87-d82b-4ea6-ad78-672d75ecfb77"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				CurveCenterPosition = new Point(292, 268),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4529baea-eac0-49a9-818f-ed63ef212d92"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5a3a044f-4e7d-4766-b31d-7faa8b9908e8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("6abb8a1d-d77d-4d5d-9a41-f39f1512025d"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{dd4cc279-afe1-401f-a48a-8aa72c711e42}].[Parameter:{a3bc60f3-2c39-4535-b598-fbd578d70e3e}]#] > 0",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				CurveCenterPosition = new Point(398, 126),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dd4cc279-afe1-401f-a48a-8aa72c711e42"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("da320ded-d51f-4e8a-8548-66d935dce5b4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("47c8f086-6221-4fdc-abce-6709e2e61ead"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{dd4cc279-afe1-401f-a48a-8aa72c711e42}].[Parameter:{a3bc60f3-2c39-4535-b598-fbd578d70e3e}]#] == 0",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				CurveCenterPosition = new Point(450, 89),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dd4cc279-afe1-401f-a48a-8aa72c711e42"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1915b8b9-69de-4118-8fd3-21a88fdd3097"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("8cd798ac-003a-4f7f-9951-ed637a29ad57"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				CurveCenterPosition = new Point(506, 125),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("da320ded-d51f-4e8a-8548-66d935dce5b4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("90929524-44b3-4698-8b37-0a5c654d1461"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("f9665c87-412e-409c-afda-6e97c759a5cb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				CurveCenterPosition = new Point(619, 126),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("90929524-44b3-4698-8b37-0a5c654d1461"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("e0b03253-ff26-4de3-ba2e-c20782c1ef24"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				CurveCenterPosition = new Point(638, 74),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1915b8b9-69de-4118-8fd3-21a88fdd3097"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow3",
				UId = new Guid("3351d977-0f52-4d7f-8471-7f0b417a163a"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{219dc79c-3bc4-48da-b5b7-90defe1aec40}].[Parameter:{40333f27-6073-4fdf-8195-0a76448c3050}].[EntityColumn:{15f0f091-e66f-42db-807b-f4c2ad6337b6}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				CurveCenterPosition = new Point(294, 125),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("219dc79c-3bc4-48da-b5b7-90defe1aec40"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dd4cc279-afe1-401f-a48a-8aa72c711e42"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow2",
				UId = new Guid("f245c894-e899-4439-b757-5cda1041f135"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				CurveCenterPosition = new Point(470, 138),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("219dc79c-3bc4-48da-b5b7-90defe1aec40"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1915b8b9-69de-4118-8fd3-21a88fdd3097"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow4ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow4",
				UId = new Guid("4476647f-b722-42dd-ac2f-219a0e5e87de"),
				ConditionExpression = @"true",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1444d101-6aac-4086-8471-ffd89cf6e26d"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				CurveCenterPosition = new Point(958, 232),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b0b23273-c3ed-47d0-bab7-c44b1459da2c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c73b530f-d091-4dd0-8bc2-93c77df9cc20"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("26657c91-c5a9-4613-a3c7-9581caa59fb7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("098b9d4a-82ed-44bc-912f-a5f1c3a148bb"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				CurveCenterPosition = new Point(1084, 232),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c73b530f-d091-4dd0-8bc2-93c77df9cc20"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9e7139c8-194f-4683-8e84-ae27396bdfa7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow13",
				UId = new Guid("3ce58dd3-2a27-4f6b-8ff1-4e3df2884ede"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("098b9d4a-82ed-44bc-912f-a5f1c3a148bb"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				CurveCenterPosition = new Point(1171, 155),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9e7139c8-194f-4683-8e84-ae27396bdfa7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3d527ad4-f295-4b8c-a9d8-5bd27c06dc5c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("825a5e1d-1211-4599-8ac9-2f948b86fc56"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("098b9d4a-82ed-44bc-912f-a5f1c3a148bb"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				CurveCenterPosition = new Point(1308, 322),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9953d48c-257d-4ca8-84fc-cae371581aa3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bfa78fda-181f-4764-8b3a-2f4b75e455ea"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("1958a841-6837-438a-bd91-1abfc424609b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("098b9d4a-82ed-44bc-912f-a5f1c3a148bb"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				CurveCenterPosition = new Point(1440, 280),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bfa78fda-181f-4764-8b3a-2f4b75e455ea"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0906a331-a59b-4472-bf33-a9c04f38e6f6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("d99f5c75-3d4f-45e7-993e-d796c641cdfd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("098b9d4a-82ed-44bc-912f-a5f1c3a148bb"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				CurveCenterPosition = new Point(1440, 162),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fc62fa4b-52eb-4eaa-ad02-5b1dfefe4d77"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0906a331-a59b-4472-bf33-a9c04f38e6f6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow5ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow5",
				UId = new Guid("ea08f07d-eb4d-48f3-a091-6ee9d8a32153"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{c73b530f-d091-4dd0-8bc2-93c77df9cc20}].[Parameter:{a3c7aa4c-5bfb-430e-a3a3-687286f47c61}].[EntityColumn:{4b95e3ff-fd52-4ae1-b0a5-2c5103ff15a7}]#] == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("098b9d4a-82ed-44bc-912f-a5f1c3a148bb"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				CurveCenterPosition = new Point(1171, 292),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9e7139c8-194f-4683-8e84-ae27396bdfa7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9953d48c-257d-4ca8-84fc-cae371581aa3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateProspectingLaneSet() {
			ProcessSchemaLaneSet schemaProspecting = new ProcessSchemaLaneSet(this) {
				UId = new Guid("0b311493-4d71-4e0c-bd28-39dd809640e3"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"Prospecting",
				Position = new Point(5, 5),
				Size = new Size(1493, 437),
				UseBackgroundMode = false
			};
			return schemaProspecting;
		}

		protected virtual ProcessSchemaLane CreateSalesManagerLane() {
			ProcessSchemaLane schemaSalesManager = new ProcessSchemaLane(this) {
				UId = new Guid("f49c28d5-51b7-49b8-b1d1-cad272db9f2f"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("0b311493-4d71-4e0c-bd28-39dd809640e3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"SalesManager",
				Position = new Point(29, 0),
				Size = new Size(1464, 437),
				UseBackgroundMode = false
			};
			return schemaSalesManager;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("80ba5382-aa5f-407f-adb0-a09f93271323"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f49c28d5-51b7-49b8-b1d1-cad272db9f2f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"Start1",
				Position = new Point(78, 212),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("0906a331-a59b-4472-bf33-a9c04f38e6f6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f49c28d5-51b7-49b8-b1d1-cad272db9f2f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"Terminate1",
				Position = new Point(1422, 212),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateOpenEditPageUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f49c28d5-51b7-49b8-b1d1-cad272db9f2f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				DragGroupName = @"Task",
				EntitySchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"OpenEditPageUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(708, 198),
				SchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeOpenEditPageUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("219dc79c-3bc4-48da-b5b7-90defe1aec40"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f49c28d5-51b7-49b8-b1d1-cad272db9f2f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"ReadDataUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(155, 198),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeAdminRightsUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("3d527ad4-f295-4b8c-a9d8-5bd27c06dc5c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f49c28d5-51b7-49b8-b1d1-cad272db9f2f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"ChangeAdminRightsUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1170, 72),
				SchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeAdminRightsUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeAdminRightsUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("fc62fa4b-52eb-4eaa-ad02-5b1dfefe4d77"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f49c28d5-51b7-49b8-b1d1-cad272db9f2f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"ChangeAdminRightsUserTask2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1303, 72),
				SchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeAdminRightsUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchSignalEvent CreateIntermediateCatchSignalEvent1IntermediateCatchSignalEvent() {
			ProcessSchemaIntermediateCatchSignalEvent schemaCatchSignalEvent = new ProcessSchemaIntermediateCatchSignalEvent(this) {
				UId = new Guid("b0a72e82-9fc1-437a-ae75-2166804d3791"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f49c28d5-51b7-49b8-b1d1-cad272db9f2f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("126115de-6094-4d04-b02d-edb4098a40a6"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"IntermediateCatchSignalEvent1",
				NewEntityChangedColumns = false,
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(78, 359),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaCatchSignalEvent.EntityChangedColumns.Add("797ac352-4979-4d28-906f-82feb6dbc9dc");
			InitializeIntermediateCatchSignalEvent1Parameters(schemaCatchSignalEvent);
			return schemaCatchSignalEvent;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask1FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("4529baea-eac0-49a9-818f-ed63ef212d92"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f49c28d5-51b7-49b8-b1d1-cad272db9f2f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("126115de-6094-4d04-b02d-edb4098a40a6"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"FormulaTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(155, 345),
				ResultParameterMetaPath = @"0bd1bc47-97dc-487d-b8b8-e5bd0a629ed8",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,41,42,77,5,0,141,76,252,253,4,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("c73b530f-d091-4dd0-8bc2-93c77df9cc20"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f49c28d5-51b7-49b8-b1d1-cad272db9f2f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"ReadDataUserTask2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(953, 198),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate2TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("5a3a044f-4e7d-4766-b31d-7faa8b9908e8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f49c28d5-51b7-49b8-b1d1-cad272db9f2f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"Terminate2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(288, 359),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask3UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("da320ded-d51f-4e8a-8548-66d935dce5b4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f49c28d5-51b7-49b8-b1d1-cad272db9f2f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"ReadDataUserTask3",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(470, 198),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadDataUserTask3Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask4UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("dd4cc279-afe1-401f-a48a-8aa72c711e42"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f49c28d5-51b7-49b8-b1d1-cad272db9f2f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"ReadDataUserTask4",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(330, 198),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadDataUserTask4Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask2FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("90929524-44b3-4698-8b37-0a5c654d1461"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f49c28d5-51b7-49b8-b1d1-cad272db9f2f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"FormulaTask2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(589, 198),
				ResultParameterMetaPath = @"d8dabfd8-e319-49b0-8bc4-b3f85a47f487.79b71a16-363b-4270-804f-96c0266a9226",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,204,189,10,194,48,20,64,225,135,233,124,165,249,229,38,171,116,112,82,112,44,29,110,146,27,20,218,10,109,68,164,244,221,77,87,215,3,223,233,155,254,178,94,63,51,47,247,248,224,137,124,166,113,229,225,84,235,95,232,70,158,120,46,126,75,164,100,155,56,65,50,34,131,102,36,64,163,17,172,77,78,153,20,217,4,189,87,112,163,133,38,46,188,248,45,72,54,130,179,0,75,20,64,71,18,128,120,144,182,69,194,250,113,100,14,210,205,229,89,190,231,215,248,158,102,191,213,145,204,33,58,80,78,57,208,42,73,64,173,21,16,153,232,2,90,37,141,218,135,102,248,1,12,195,44,181,196,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask3FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("1915b8b9-69de-4118-8fd3-21a88fdd3097"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f49c28d5-51b7-49b8-b1d1-cad272db9f2f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"FormulaTask3",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(330, 72),
				ResultParameterMetaPath = @"d8dabfd8-e319-49b0-8bc4-b3f85a47f487.79b71a16-363b-4270-804f-96c0266a9226",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,139,86,14,174,44,14,75,44,202,76,76,202,73,213,115,46,45,42,74,205,43,9,45,78,45,114,206,207,43,73,76,46,81,142,5,0,45,65,78,225,34,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b0b23273-c3ed-47d0-bab7-c44b1459da2c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f49c28d5-51b7-49b8-b1d1-cad272db9f2f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1444d101-6aac-4086-8471-ffd89cf6e26d"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(820, 198),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,201,200,44,214,11,74,77,76,113,73,44,73,12,45,78,45,10,73,44,206,54,2,138,20,151,230,148,184,230,149,100,150,84,58,231,231,228,164,38,151,100,230,231,233,57,231,151,230,149,40,216,218,42,24,88,3,0,7,66,170,173,64,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("9e7139c8-194f-4683-8e84-ae27396bdfa7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f49c28d5-51b7-49b8-b1d1-cad272db9f2f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("098b9d4a-82ed-44bc-912f-a5f1c3a148bb"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1072, 198),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateChangeAdminRightsUserTask3UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("9953d48c-257d-4ca8-84fc-cae371581aa3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f49c28d5-51b7-49b8-b1d1-cad272db9f2f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("098b9d4a-82ed-44bc-912f-a5f1c3a148bb"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"ChangeAdminRightsUserTask3",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1170, 289),
				SchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeAdminRightsUserTask3Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeAdminRightsUserTask4UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("bfa78fda-181f-4764-8b3a-2f4b75e455ea"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f49c28d5-51b7-49b8-b1d1-cad272db9f2f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("098b9d4a-82ed-44bc-912f-a5f1c3a148bb"),
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"ChangeAdminRightsUserTask4",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1303, 289),
				SchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeAdminRightsUserTask4Parameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new OpportunityManagementProspecting(userConnection);
		}

		public override object Clone() {
			return new OpportunityManagementProspectingSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityManagementProspecting

	/// <exclude/>
	public class OpportunityManagementProspecting : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessSalesManager

		/// <exclude/>
		public class ProcessSalesManager : ProcessLane
		{

			public ProcessSalesManager(UserConnection userConnection, OpportunityManagementProspecting process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: OpenEditPageUserTask1FlowElement

		/// <exclude/>
		public class OpenEditPageUserTask1FlowElement : OpenEditPageUserTask
		{

			#region Constructors: Public

			public OpenEditPageUserTask1FlowElement(UserConnection userConnection, OpportunityManagementProspecting process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenEditPageUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("d8dabfd8-e319-49b0-8bc4-b3f85a47f487");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.SalesManager;
				SerializeToDB = true;
				_recordId = () => (Guid)((process.CurrentOpportunity));
				_account = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("AccountId") : Guid.Empty)));
				_contact = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty)));
				_opportunity = () => (Guid)((process.CurrentOpportunity));
			}

			#endregion

			#region Properties: Public

			private Guid _objectSchemaId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			public override Guid ObjectSchemaId {
				get {
					return _objectSchemaId;
				}
				set {
					_objectSchemaId = value;
				}
			}

			private Guid _pageSchemaId = new Guid("df249c13-df7a-48d2-b128-85183c4a0e10");
			public override Guid PageSchemaId {
				get {
					return _pageSchemaId;
				}
				set {
					_pageSchemaId = value;
				}
			}

			private int _editMode = 1;
			public override int EditMode {
				get {
					return _editMode;
				}
				set {
					_editMode = value;
				}
			}

			internal Func<Guid> _recordId;
			public override Guid RecordId {
				get {
					return (_recordId ?? (_recordId = () => Guid.Empty)).Invoke();
				}
				set {
					_recordId = () => { return value; };
				}
			}

			private bool _isMatchConditions = false;
			public override bool IsMatchConditions {
				get {
					return _isMatchConditions;
				}
				set {
					_isMatchConditions = value;
				}
			}

			private bool _generateDecisionsFromColumn = false;
			public override bool GenerateDecisionsFromColumn {
				get {
					return _generateDecisionsFromColumn;
				}
				set {
					_generateDecisionsFromColumn = value;
				}
			}

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("7fce678b995e4c539b43ec2f04fae40f",
						 "BaseElements.OpenEditPageUserTask1.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			private int _durationPeriod = 0;
			public override int DurationPeriod {
				get {
					return _durationPeriod;
				}
				set {
					_durationPeriod = value;
				}
			}

			private int _startInPeriod = 0;
			public override int StartInPeriod {
				get {
					return _startInPeriod;
				}
				set {
					_startInPeriod = value;
				}
			}

			private int _remindBefore = 5;
			public override int RemindBefore {
				get {
					return _remindBefore;
				}
				set {
					_remindBefore = value;
				}
			}

			private int _remindBeforePeriod = 0;
			public override int RemindBeforePeriod {
				get {
					return _remindBeforePeriod;
				}
				set {
					_remindBeforePeriod = value;
				}
			}

			private bool _showInScheduler = true;
			public override bool ShowInScheduler {
				get {
					return _showInScheduler;
				}
				set {
					_showInScheduler = value;
				}
			}

			internal Func<Guid> _account;
			public override Guid Account {
				get {
					return (_account ?? (_account = () => Guid.Empty)).Invoke();
				}
				set {
					_account = () => { return value; };
				}
			}

			internal Func<Guid> _contact;
			public override Guid Contact {
				get {
					return (_contact ?? (_contact = () => Guid.Empty)).Invoke();
				}
				set {
					_contact = () => { return value; };
				}
			}

			internal Func<Guid> _opportunity;
			public override Guid Opportunity {
				get {
					return (_opportunity ?? (_opportunity = () => Guid.Empty)).Invoke();
				}
				set {
					_opportunity = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadDataUserTask1FlowElement

		/// <exclude/>
		public class ReadDataUserTask1FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask1FlowElement(UserConnection userConnection, OpportunityManagementProspecting process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("219dc79c-3bc4-48da-b5b7-90defe1aec40");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,20,252,43,69,135,158,164,98,75,178,108,57,199,101,91,246,146,6,154,150,66,178,132,103,233,57,43,240,87,108,137,102,49,251,223,43,175,179,41,228,80,10,61,5,116,144,158,52,243,102,134,167,249,193,77,159,93,227,113,44,107,104,38,164,97,103,75,146,37,149,22,9,102,12,114,35,153,76,117,193,32,169,42,198,21,160,149,86,165,73,97,8,237,160,197,146,172,232,173,117,158,80,231,177,157,202,187,249,15,169,31,3,210,135,250,124,248,102,14,216,194,247,165,1,160,84,117,85,228,204,36,220,48,9,24,27,88,145,50,208,92,24,107,181,150,166,38,171,22,52,156,23,26,21,19,92,42,38,49,55,12,138,20,89,149,43,195,21,79,120,158,115,66,27,172,253,246,121,24,113,154,92,223,149,51,190,238,111,143,67,84,185,246,222,244,77,104,59,66,91,244,112,3,254,176,8,73,80,102,6,152,145,58,99,178,198,156,129,208,150,9,168,114,158,23,152,170,52,39,212,192,224,23,90,178,179,132,90,240,240,3,154,128,103,230,217,69,141,92,36,105,145,169,136,77,69,180,35,120,194,10,21,221,213,86,213,26,133,210,186,178,151,188,190,4,23,247,110,186,14,45,142,206,188,196,142,49,191,126,44,103,211,119,126,236,155,133,250,250,252,252,22,159,253,26,238,203,213,207,213,144,143,245,5,68,78,52,76,184,105,28,118,126,219,153,222,186,238,113,229,60,157,34,164,29,96,116,211,37,133,237,83,128,134,208,209,61,30,254,154,214,38,76,190,111,223,145,85,26,109,70,142,56,100,103,185,203,12,90,55,13,13,28,207,231,146,124,124,10,189,191,218,132,113,140,224,15,253,48,244,163,15,157,243,199,245,130,188,33,40,201,61,145,70,161,6,101,88,198,65,196,209,224,25,43,114,93,51,173,180,76,77,10,32,164,190,39,81,212,255,183,186,219,77,95,127,117,151,31,178,122,218,127,138,213,55,133,155,11,178,156,255,69,221,105,191,232,219,159,226,250,13,90,200,224,72,232,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = false;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,11,201,44,201,73,181,50,180,50,212,241,76,177,50,176,50,0,0,169,240,29,88,16,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ChangeAdminRightsUserTask1FlowElement

		/// <exclude/>
		public class ChangeAdminRightsUserTask1FlowElement : ChangeAdminRightsUserTask
		{

			#region Constructors: Public

			public ChangeAdminRightsUserTask1FlowElement(UserConnection userConnection, OpportunityManagementProspecting process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeAdminRightsUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("3d527ad4-f295-4b8c-a9d8-5bd27c06dc5c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_employee1 = () => (Guid)(((process.ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadDataUserTask2.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
			}

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e");
			public override Guid EntitySchemaUId {
				get {
					return _entitySchemaUId;
				}
				set {
					_entitySchemaUId = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,148,77,111,156,48,16,134,255,10,242,161,39,188,194,198,198,64,79,85,180,169,114,73,163,126,169,82,18,69,131,61,100,45,1,222,128,81,19,173,246,191,119,88,146,86,202,161,202,177,149,56,216,195,204,59,51,15,51,28,238,252,116,238,187,136,99,221,66,55,97,58,95,184,154,137,182,201,155,82,75,142,160,42,174,148,173,56,128,52,188,208,70,201,188,20,153,43,75,150,14,208,99,205,214,232,173,243,145,165,62,98,63,213,215,135,63,162,113,156,49,189,107,79,151,47,118,135,61,124,91,18,72,237,140,21,208,112,225,48,227,74,103,130,55,42,147,60,147,152,161,6,35,93,129,108,173,37,215,194,72,33,37,47,68,163,184,202,12,185,234,18,184,16,160,80,229,166,210,138,106,233,176,141,219,199,253,136,211,228,195,80,31,240,247,249,235,211,158,170,92,115,159,133,110,238,7,150,246,24,225,10,226,174,102,64,249,148,182,192,173,170,52,87,45,26,14,121,229,120,14,141,145,166,68,81,8,195,82,11,251,184,200,178,11,199,82,7,17,190,67,55,227,73,249,224,151,118,242,76,148,186,160,88,145,91,174,114,153,241,178,40,13,111,93,209,86,152,23,85,213,184,23,94,31,103,79,103,63,93,206,61,142,222,62,99,71,226,23,198,250,96,195,16,199,208,45,210,151,39,247,175,248,24,87,184,207,175,126,172,13,69,178,47,65,236,152,206,19,158,117,30,135,184,29,108,112,126,184,95,53,143,71,10,233,247,48,250,233,133,194,246,97,134,142,165,163,191,223,253,149,214,217,60,197,208,255,71,173,166,212,38,105,208,144,157,202,93,102,208,249,105,223,193,211,233,94,179,119,15,115,136,239,63,35,184,36,236,247,97,140,243,224,227,83,178,52,152,64,75,113,201,132,29,218,72,146,73,248,57,224,184,57,247,227,20,147,101,162,147,208,38,113,135,9,33,154,187,147,135,13,221,201,57,12,155,15,214,134,121,136,171,62,123,85,71,205,110,152,53,121,163,243,172,229,46,171,4,87,206,17,176,198,74,94,229,214,24,215,86,214,202,108,3,116,1,80,150,235,166,109,136,106,134,52,134,144,115,34,43,203,162,85,198,22,98,163,154,74,99,222,182,196,154,86,83,1,210,38,100,160,185,180,90,100,100,23,180,56,55,140,40,253,51,189,95,95,76,159,22,193,117,251,214,111,117,187,33,235,43,195,182,195,158,62,42,205,196,27,96,29,41,224,234,37,85,125,120,11,186,37,100,59,68,234,122,253,3,212,135,183,176,60,222,46,52,111,143,244,252,2,22,70,107,78,39,5,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private string _addRights;
			public override string AddRights {
				get {
					return _addRights ?? (_addRights = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,93,80,203,106,195,48,16,252,21,225,94,163,96,91,242,67,186,166,105,9,148,166,36,208,75,240,97,45,173,18,131,44,7,89,110,9,33,255,94,217,133,30,122,219,153,157,217,221,217,211,125,167,101,162,91,228,41,162,162,74,104,69,121,46,144,130,202,56,21,6,178,82,87,121,166,51,150,172,54,224,14,8,90,6,63,225,12,182,186,11,127,224,25,45,6,148,6,236,136,171,227,48,121,133,50,137,166,87,15,46,96,172,183,253,213,14,55,196,100,245,14,125,196,167,167,121,24,25,174,215,193,135,201,117,225,70,52,4,32,96,2,122,114,140,227,84,232,220,153,236,191,29,250,245,75,231,199,64,186,128,61,25,12,9,23,36,30,199,201,46,10,53,216,69,60,184,245,34,126,106,146,213,39,216,105,89,114,218,141,11,121,84,23,236,225,247,190,102,29,217,127,196,214,98,143,46,200,187,170,88,91,176,212,80,157,138,140,114,173,83,90,183,42,167,130,169,170,210,70,40,149,167,143,104,248,0,31,115,196,91,229,29,98,11,128,43,90,180,166,165,156,165,241,125,12,24,45,235,42,175,75,195,43,85,102,179,101,235,66,140,185,25,236,212,59,121,47,107,94,20,12,42,10,133,208,148,151,6,40,24,222,82,163,170,18,133,65,86,10,254,104,230,48,251,43,122,152,243,29,186,243,37,188,225,23,90,153,100,201,163,249,1,183,167,229,144,190,1,0,0 })));
				}
				set {
					_addRights = value;
				}
			}

			internal Func<Guid> _employee1;
			public virtual Guid Employee1 {
				get {
					return (_employee1 ?? (_employee1 = () => Guid.Empty)).Invoke();
				}
				set {
					_employee1 = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		#region Class: ChangeAdminRightsUserTask2FlowElement

		/// <exclude/>
		public class ChangeAdminRightsUserTask2FlowElement : ChangeAdminRightsUserTask
		{

			#region Constructors: Public

			public ChangeAdminRightsUserTask2FlowElement(UserConnection userConnection, OpportunityManagementProspecting process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeAdminRightsUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("fc62fa4b-52eb-4eaa-ad02-5b1dfefe4d77");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_employee1 = () => (Guid)(((process.ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadDataUserTask2.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
			}

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			public override Guid EntitySchemaUId {
				get {
					return _entitySchemaUId;
				}
				set {
					_entitySchemaUId = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,77,107,220,48,16,253,43,198,135,158,172,197,150,63,100,185,167,146,110,32,80,210,208,166,165,16,150,48,146,70,89,81,219,114,108,153,54,152,253,239,149,237,221,52,228,80,246,144,75,193,7,107,164,247,230,205,155,145,166,123,51,92,154,218,97,95,105,168,7,140,198,43,85,133,34,161,37,114,1,68,230,12,72,198,57,146,82,42,73,120,145,43,196,52,161,146,37,97,212,66,131,85,184,162,183,202,184,48,50,14,155,161,186,155,254,146,186,126,196,232,94,47,139,175,114,143,13,124,155,19,0,102,133,22,37,35,50,166,146,100,128,37,1,149,38,4,56,77,165,82,156,103,82,135,171,22,9,64,25,213,148,136,44,85,36,67,161,8,71,65,9,203,4,165,130,43,240,12,97,228,122,211,124,4,135,183,166,193,27,232,189,50,159,240,214,206,161,85,67,141,218,109,127,119,61,14,131,177,109,53,225,243,255,237,83,231,203,88,197,93,216,122,108,218,48,242,112,184,1,183,175,194,76,240,28,83,173,137,86,57,157,149,38,68,196,144,19,42,243,36,246,241,36,7,22,70,18,58,55,211,134,31,164,180,99,235,173,232,81,99,143,173,196,23,85,211,92,49,153,128,32,137,194,152,100,121,236,185,178,152,146,152,98,140,158,135,170,2,195,72,129,131,239,80,143,184,8,155,204,220,15,202,243,152,37,154,48,4,238,61,40,40,41,85,2,132,39,92,232,148,165,84,107,122,234,199,39,107,127,142,157,239,197,112,61,54,216,27,121,108,44,250,14,217,190,154,164,109,93,111,235,153,252,250,5,96,109,224,113,243,199,234,73,189,236,204,192,240,16,141,3,94,212,6,91,183,109,165,85,166,125,88,124,61,28,60,166,233,160,55,195,201,201,237,227,8,181,55,192,60,236,255,233,248,197,56,56,219,252,111,245,70,221,105,186,22,205,243,180,43,51,116,53,60,45,235,42,124,247,56,90,247,254,11,130,10,108,215,217,222,141,173,113,79,193,92,101,0,218,227,130,1,107,148,206,51,6,246,87,139,253,230,210,244,131,11,230,187,19,88,29,184,61,6,222,167,177,94,78,72,91,47,135,109,187,57,142,214,202,31,190,210,113,202,43,89,42,242,52,214,68,197,60,33,153,82,49,41,133,164,132,167,146,49,165,185,148,52,222,128,95,0,100,146,228,66,11,146,165,49,18,72,33,37,69,201,104,89,232,140,201,34,217,156,51,248,71,45,135,232,141,60,184,122,19,15,238,174,134,207,51,233,122,243,214,113,216,109,124,244,85,96,91,99,227,251,235,71,228,12,211,14,30,240,252,176,84,211,57,22,206,144,109,235,124,229,235,179,82,77,231,120,122,216,157,92,221,29,252,247,7,212,144,166,153,161,5,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private string _addRights;
			public override string AddRights {
				get {
					return _addRights ?? (_addRights = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,93,81,203,78,195,48,16,252,21,43,92,235,42,173,29,59,206,181,20,84,9,1,2,137,75,149,195,198,94,183,145,28,187,114,28,16,170,250,239,56,129,19,183,157,217,217,199,236,30,175,7,211,20,90,67,93,85,188,163,26,172,165,92,109,129,42,161,128,138,90,73,107,21,19,92,214,197,106,7,254,13,193,52,41,78,56,131,189,233,83,99,193,141,11,186,71,135,9,255,240,123,152,162,198,166,96,197,234,49,130,79,152,227,253,112,113,225,27,177,88,61,195,144,241,241,110,238,70,194,229,18,98,154,124,159,190,137,129,4,4,108,194,72,198,220,78,167,222,159,72,248,242,24,215,15,125,28,19,233,19,14,36,88,146,206,72,34,142,147,91,20,58,184,69,28,252,250,101,22,223,181,197,234,3,220,180,12,57,30,198,133,124,215,103,28,224,119,191,118,157,217,127,196,222,225,128,62,53,87,45,89,87,177,210,82,83,170,13,229,198,148,180,238,244,150,42,166,165,52,86,105,189,45,111,185,224,21,98,246,145,119,109,174,144,83,0,92,211,170,179,29,229,172,68,10,12,88,190,159,220,214,194,114,169,197,102,46,217,251,148,109,238,130,155,6,223,92,69,205,171,138,129,164,80,41,67,185,176,64,193,230,39,88,45,5,42,139,76,40,126,107,103,51,47,23,140,48,251,123,235,79,231,244,132,159,232,154,98,83,220,218,31,203,76,157,36,191,1,0,0 })));
				}
				set {
					_addRights = value;
				}
			}

			internal Func<Guid> _employee1;
			public virtual Guid Employee1 {
				get {
					return (_employee1 ?? (_employee1 = () => Guid.Empty)).Invoke();
				}
				set {
					_employee1 = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		#region Class: IntermediateCatchSignalEvent1FlowElement

		/// <exclude/>
		public class IntermediateCatchSignalEvent1FlowElement : ProcessIntermediateCatchSignalEvent
		{

			#region Constructors: Public

			public IntermediateCatchSignalEvent1FlowElement(UserConnection userConnection, OpportunityManagementProspecting process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchSignalEvent";
				Name = "IntermediateCatchSignalEvent1";
				IsLogging = false;
				SchemaElementUId = new Guid("b0a72e82-9fc1-437a-ae75-2166804d3791");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				Message = "";
				WaitingRandomSignal = false;
				WaitingEntitySignal = true;
				EntitySchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
				EntitySignal = EntityChangeType.Updated;
				HasEntityColumnChange = true;
				HasEntityFilters = true;
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, mscorlib]], mscorlib"",""$values"":[""797ac352-4979-4d28-906f-82feb6dbc9dc""]}";
				EntityFilters = @"{_isFilter:false,uId:""3d415f87-6985-4957-bafe-aabb330637fa"",name:""FilterEdit"",items:[]}";
				_recordId = () => (Guid)((process.CurrentOpportunity));
			}

			#endregion

			#region Properties: Public

			internal Func<Guid> _recordId;
			public override Guid RecordId {
				get {
					return (_recordId ?? (_recordId = () => Guid.Empty)).Invoke();
				}
				set {
					_recordId = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadDataUserTask2FlowElement

		/// <exclude/>
		public class ReadDataUserTask2FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask2FlowElement(UserConnection userConnection, OpportunityManagementProspecting process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("c73b530f-d091-4dd0-8bc2-93c77df9cc20");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,20,252,43,69,135,158,172,98,89,178,108,57,199,101,91,246,146,6,154,150,66,178,132,103,233,41,43,240,87,108,137,102,49,251,223,43,175,179,41,228,80,10,61,5,116,144,158,52,243,102,134,167,249,193,77,159,93,227,113,172,44,52,19,38,97,103,42,82,107,133,12,68,73,107,83,48,42,20,72,90,51,193,40,170,20,65,10,91,90,43,72,210,65,139,21,89,209,91,227,60,73,156,199,118,170,238,230,63,164,126,12,152,60,216,243,225,155,62,96,11,223,151,6,128,66,218,186,44,168,78,51,77,5,96,73,193,112,70,65,101,92,27,163,148,208,150,172,90,100,158,66,201,106,69,69,158,213,84,72,206,169,202,141,161,105,109,11,41,75,166,149,229,36,105,208,250,237,243,48,226,52,185,190,171,102,124,221,223,30,135,168,114,237,189,233,155,208,118,36,105,209,195,13,248,195,34,36,69,145,107,160,90,168,156,10,139,5,5,174,12,229,80,23,89,81,34,147,172,32,137,134,193,47,180,100,103,72,98,192,195,15,104,2,158,153,103,23,53,102,60,101,101,46,35,150,241,104,135,103,41,45,101,116,103,141,180,10,185,84,170,54,151,188,190,4,23,247,110,186,14,45,142,78,191,196,142,49,191,126,172,102,221,119,126,236,155,133,250,250,252,252,22,159,253,26,238,203,213,207,213,144,143,245,5,68,78,73,152,112,211,56,236,252,182,211,189,113,221,227,202,121,58,69,72,59,192,232,166,75,10,219,167,0,13,73,70,247,120,248,107,90,155,48,249,190,125,71,86,147,104,51,114,196,33,59,203,93,102,208,184,105,104,224,120,62,87,228,227,83,232,253,213,38,140,99,4,127,232,135,161,31,125,232,156,63,174,23,228,13,65,69,238,137,208,18,227,228,107,154,103,192,227,104,100,57,45,11,101,169,146,74,48,205,0,184,80,247,36,138,250,255,86,119,187,233,235,175,238,242,67,86,79,251,79,177,250,166,112,115,65,86,243,191,168,59,237,23,125,251,83,92,191,1,80,88,168,180,232,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = false;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,9,201,44,201,73,181,50,180,50,4,0,57,183,224,50,16,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadDataUserTask3FlowElement

		/// <exclude/>
		public class ReadDataUserTask3FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask3FlowElement(UserConnection userConnection, OpportunityManagementProspecting process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask3";
				IsLogging = true;
				SchemaElementUId = new Guid("da320ded-d51f-4e8a-8548-66d935dce5b4");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,85,219,138,220,70,16,253,149,161,31,242,164,30,250,126,81,30,215,99,179,144,108,76,226,132,128,189,152,190,84,239,54,209,72,99,169,149,120,25,230,223,221,26,121,18,99,54,97,19,130,193,47,162,111,117,170,234,84,157,210,241,109,158,158,231,174,192,216,38,215,77,208,204,215,177,69,70,18,77,18,225,216,18,43,176,48,38,96,151,40,224,192,34,11,140,7,163,165,71,77,239,246,208,162,213,122,23,115,65,77,46,176,159,218,215,199,191,64,203,56,67,243,54,157,55,63,133,123,216,187,159,23,7,50,26,33,149,23,152,74,32,88,68,144,216,147,250,113,201,83,146,148,182,50,16,180,198,18,45,87,201,202,250,32,68,139,133,98,30,59,65,60,142,194,81,206,169,215,68,82,212,116,144,202,238,253,97,132,105,202,67,223,30,225,207,245,171,135,67,141,114,245,125,53,116,243,190,71,205,30,138,123,233,202,125,139,28,16,16,50,56,28,132,149,88,36,208,216,113,27,49,119,94,51,109,128,42,170,81,19,220,161,44,176,232,58,162,38,186,226,126,113,221,12,103,228,99,174,49,50,78,168,145,170,218,82,30,176,224,140,96,163,140,198,41,214,208,129,43,107,125,188,240,245,98,206,117,157,167,155,121,15,99,14,31,105,135,202,223,48,182,199,48,244,101,28,186,5,250,230,252,252,21,188,47,43,185,31,175,126,93,19,42,245,124,49,66,167,102,158,224,170,203,208,151,93,31,134,152,251,187,21,243,116,170,38,251,131,27,243,116,97,97,247,110,118,29,106,198,124,119,255,143,108,93,205,83,25,246,95,81,170,77,77,179,98,212,38,59,135,187,244,96,204,211,161,115,15,231,125,139,190,121,55,15,229,219,31,193,197,205,112,56,12,99,153,251,92,30,54,75,130,219,231,121,156,202,102,233,221,77,238,55,149,136,185,43,21,122,19,134,174,131,176,20,126,251,44,255,158,23,122,86,24,244,153,187,22,189,65,140,218,24,180,13,152,251,176,72,38,58,236,165,215,85,65,17,18,80,7,65,144,173,32,156,243,196,52,86,68,243,218,109,49,97,67,107,223,17,167,149,16,38,112,34,201,150,202,84,181,103,41,6,165,18,22,44,122,108,136,246,56,137,192,92,84,156,107,175,222,160,74,198,151,78,241,245,245,244,195,31,253,69,199,43,243,183,219,122,250,217,193,174,131,125,45,81,123,124,10,39,167,106,240,242,226,170,61,62,133,161,197,100,215,151,154,220,170,231,246,248,20,202,78,183,11,105,183,85,21,255,235,120,226,140,5,71,153,194,194,242,154,99,136,17,187,24,0,131,208,65,50,81,71,165,137,255,125,60,129,244,44,249,96,49,183,188,14,63,30,25,54,66,112,236,156,12,214,27,197,153,228,159,140,167,239,93,239,238,96,172,10,175,252,142,208,7,248,36,41,170,124,213,167,164,216,36,96,88,80,105,177,137,145,96,103,8,143,66,25,30,35,127,84,242,158,217,250,63,160,9,107,112,53,8,80,53,136,72,29,182,212,250,196,53,103,41,177,139,228,191,27,134,223,230,195,191,16,253,106,240,152,236,187,243,205,223,10,127,41,221,35,35,238,122,186,25,202,205,220,117,75,173,63,0,61,86,32,219,222,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = false;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,248,134,94,83,15,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("5d8456b4-15e0-4de5-b0e5-afb10f6795c0")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("5d8456b4-15e0-4de5-b0e5-afb10f6795c0"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadDataUserTask4FlowElement

		/// <exclude/>
		public class ReadDataUserTask4FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask4FlowElement(UserConnection userConnection, OpportunityManagementProspecting process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask4";
				IsLogging = true;
				SchemaElementUId = new Guid("dd4cc279-afe1-401f-a48a-8aa72c711e42");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,148,93,139,220,54,20,134,255,202,224,139,94,249,12,146,245,237,94,110,38,97,161,221,134,54,45,133,100,9,250,56,218,21,245,216,19,91,110,179,12,243,223,35,143,51,109,8,219,178,45,37,144,27,99,75,62,175,206,121,116,222,115,124,155,166,231,169,203,56,182,209,118,19,214,243,117,104,43,21,3,53,40,60,40,19,24,112,97,3,88,34,21,248,200,57,67,107,153,240,88,213,189,221,99,91,173,209,187,144,114,85,167,140,251,169,125,125,252,75,52,143,51,214,111,227,249,227,39,127,143,123,251,243,114,128,8,154,11,233,56,80,129,4,120,64,1,142,148,135,141,142,146,40,149,17,158,84,107,46,65,72,238,89,244,32,208,112,224,196,51,208,222,123,48,13,137,218,51,210,112,174,170,186,195,152,119,239,15,35,78,83,26,250,246,136,127,190,191,122,56,148,44,215,179,175,134,110,222,247,85,189,199,108,95,218,124,223,86,22,9,114,225,45,120,110,4,240,136,10,44,51,1,152,117,170,81,26,169,164,69,221,219,67,94,100,171,235,80,213,193,102,251,139,237,102,60,43,31,83,201,177,97,132,106,81,0,89,202,60,112,214,16,208,82,43,136,65,70,131,76,26,227,194,133,215,139,57,149,247,52,221,204,123,28,147,255,136,29,11,191,97,108,143,126,232,243,56,116,139,244,205,249,247,87,248,62,175,112,63,110,253,186,22,148,203,250,18,84,157,234,121,194,171,46,97,159,119,189,31,66,234,239,86,205,211,169,132,236,15,118,76,211,133,194,238,221,108,187,170,30,211,221,253,63,210,186,154,167,60,236,191,162,82,235,82,102,209,40,77,118,78,119,233,193,144,166,67,103,31,206,223,109,245,205,187,121,200,223,254,136,54,108,134,195,97,24,243,220,167,252,176,89,10,220,62,79,227,148,55,75,239,110,82,191,41,32,230,46,23,233,141,31,186,14,253,114,241,219,103,233,247,180,224,89,101,170,207,142,107,171,55,85,67,77,240,202,120,96,206,151,54,213,193,130,19,78,129,33,1,35,82,139,158,147,45,39,140,177,216,40,144,68,21,95,197,16,65,211,210,119,196,42,201,249,210,205,130,108,169,136,36,18,67,1,165,140,192,155,224,64,19,229,32,114,223,216,32,25,83,78,190,169,10,140,47,93,226,235,235,233,135,63,250,139,143,87,242,183,219,178,250,217,194,174,195,125,185,162,246,248,20,38,167,18,240,242,114,84,123,124,10,161,37,100,215,231,82,220,234,231,246,248,20,100,167,219,5,218,109,113,197,255,58,158,168,247,212,73,137,101,74,82,89,252,16,154,242,87,212,16,24,10,29,131,51,33,226,127,31,79,40,92,19,157,55,192,12,51,171,186,46,35,24,172,21,222,56,45,89,35,216,39,227,233,123,219,219,59,28,139,195,11,223,17,123,143,159,20,69,165,43,254,20,20,116,196,6,56,21,6,116,8,4,172,38,44,112,169,89,8,236,81,203,187,198,8,162,104,4,133,182,36,129,178,36,17,168,5,67,141,139,76,177,38,198,230,98,249,239,134,225,183,249,240,47,76,191,6,60,102,251,238,188,243,183,198,95,174,238,145,17,119,61,221,12,249,102,238,186,229,174,63,0,230,134,229,47,222,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 1;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = false;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _aggregationColumnName;
			public override string AggregationColumnName {
				get {
					return _aggregationColumnName ?? (_aggregationColumnName = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,1,0,242,67,189,42,2,0,0,0 })));
				}
				set {
					_aggregationColumnName = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,75,204,77,181,50,180,50,4,0,203,8,241,43,15,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("5d8456b4-15e0-4de5-b0e5-afb10f6795c0")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("5d8456b4-15e0-4de5-b0e5-afb10f6795c0"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ChangeAdminRightsUserTask3FlowElement

		/// <exclude/>
		public class ChangeAdminRightsUserTask3FlowElement : ChangeAdminRightsUserTask
		{

			#region Constructors: Public

			public ChangeAdminRightsUserTask3FlowElement(UserConnection userConnection, OpportunityManagementProspecting process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeAdminRightsUserTask3";
				IsLogging = true;
				SchemaElementUId = new Guid("9953d48c-257d-4ca8-84fc-cae371581aa3");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_employee1 = () => (Guid)(((process.ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? process.ReadDataUserTask2.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty)));
			}

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			public override Guid EntitySchemaUId {
				get {
					return _entitySchemaUId;
				}
				set {
					_entitySchemaUId = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,77,107,220,48,20,252,43,70,135,158,172,197,182,108,73,118,143,203,166,228,146,134,54,45,133,36,132,39,233,41,17,248,99,99,203,52,97,217,255,222,231,117,210,66,14,37,199,22,124,208,199,155,209,204,232,201,135,187,48,157,133,54,226,216,120,104,39,76,231,115,215,176,170,46,170,92,10,195,243,50,147,188,84,22,57,160,68,94,20,181,174,45,42,109,140,103,105,15,29,54,108,69,239,92,136,44,13,17,187,169,185,62,252,33,141,227,140,233,157,63,77,190,218,7,236,224,219,114,64,46,13,10,89,229,92,123,44,120,153,87,53,215,206,101,28,116,38,92,41,181,112,78,176,85,139,213,162,50,96,36,215,86,40,210,130,134,131,178,138,235,18,43,167,165,51,10,168,180,69,31,119,79,251,17,167,41,12,125,115,192,223,227,171,231,61,169,92,207,222,14,237,220,245,44,237,48,194,37,196,135,134,1,102,88,86,22,184,45,235,138,151,30,21,7,81,59,46,192,168,66,105,204,101,174,88,106,97,31,23,90,118,238,88,234,32,194,119,104,103,60,49,31,2,105,44,68,150,235,74,18,54,23,150,151,162,200,184,150,90,113,239,164,175,201,104,93,27,247,154,215,167,57,208,56,76,23,115,135,99,176,47,177,35,229,55,140,205,193,14,125,28,135,118,161,190,56,149,95,225,83,92,195,125,217,250,177,26,138,180,190,128,216,49,157,39,220,182,1,251,184,235,237,224,66,127,191,114,30,143,4,233,246,48,134,233,53,133,221,227,12,45,75,199,112,255,240,215,180,182,243,20,135,238,63,178,154,146,77,226,160,38,59,201,93,122,208,133,105,223,194,243,105,222,176,15,143,243,16,63,126,65,112,201,176,223,15,99,156,251,16,159,147,197,96,2,158,112,201,132,45,218,72,148,73,124,192,100,248,217,227,184,57,11,227,20,147,165,171,147,193,39,20,209,220,158,42,236,208,158,138,135,126,179,37,169,96,227,202,207,222,232,104,216,13,179,74,152,74,100,158,187,172,206,121,185,116,185,54,182,224,181,176,74,57,95,91,91,100,27,160,9,64,105,121,101,188,161,84,51,122,112,2,4,167,100,11,45,61,189,64,153,111,100,9,25,237,3,23,85,230,136,201,120,110,188,211,220,155,74,213,160,74,47,106,188,97,148,210,63,227,253,250,124,250,188,144,173,175,111,189,171,219,13,173,190,89,216,181,216,209,165,82,79,188,35,172,35,1,46,95,143,106,14,239,137,110,129,236,250,72,174,215,63,64,115,120,79,150,199,219,37,205,219,35,125,191,0,170,240,95,94,39,5,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private string _addRights;
			public override string AddRights {
				get {
					return _addRights ?? (_addRights = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,93,80,193,110,194,48,12,253,149,168,187,54,40,52,165,161,189,50,54,33,77,99,2,105,23,196,193,77,28,168,148,38,40,117,55,33,196,191,47,101,210,14,187,249,217,126,126,126,239,112,219,152,38,19,178,45,132,154,3,183,69,173,120,105,160,224,117,105,4,215,10,12,66,165,171,57,66,150,175,192,239,16,76,67,113,196,9,172,77,71,127,224,25,29,18,54,22,220,128,249,62,140,81,99,147,201,44,127,141,224,9,83,189,238,47,46,92,17,179,252,29,250,132,15,79,211,49,22,46,151,16,105,244,29,93,153,1,2,6,150,48,178,33,157,211,212,249,19,163,51,178,240,237,49,206,94,186,56,16,235,8,123,22,44,139,56,140,238,177,161,131,123,44,7,63,91,5,79,160,233,233,152,229,159,224,198,135,204,97,51,108,39,254,94,159,177,135,223,15,143,179,212,253,215,88,59,236,209,83,115,211,74,182,11,41,44,55,162,158,167,52,82,16,203,86,167,72,164,86,202,216,90,235,66,220,19,225,3,98,114,146,190,109,110,144,70,0,165,230,139,214,182,188,148,2,57,72,144,188,90,170,98,89,217,82,165,8,39,202,218,83,50,186,10,110,236,125,115,171,74,16,137,0,92,46,132,73,66,173,229,173,53,75,110,219,133,170,65,149,86,214,120,63,78,102,182,23,140,48,57,220,117,167,51,189,225,23,186,38,155,103,247,227,15,31,118,193,246,192,1,0,0 })));
				}
				set {
					_addRights = value;
				}
			}

			internal Func<Guid> _employee1;
			public virtual Guid Employee1 {
				get {
					return (_employee1 ?? (_employee1 = () => Guid.Empty)).Invoke();
				}
				set {
					_employee1 = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		#region Class: ChangeAdminRightsUserTask4FlowElement

		/// <exclude/>
		public class ChangeAdminRightsUserTask4FlowElement : ChangeAdminRightsUserTask
		{

			#region Constructors: Public

			public ChangeAdminRightsUserTask4FlowElement(UserConnection userConnection, OpportunityManagementProspecting process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeAdminRightsUserTask4";
				IsLogging = true;
				SchemaElementUId = new Guid("bfa78fda-181f-4764-8b3a-2f4b75e455ea");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_employee1 = () => (Guid)(((process.ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadDataUserTask2.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
			}

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			public override Guid EntitySchemaUId {
				get {
					return _entitySchemaUId;
				}
				set {
					_entitySchemaUId = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,93,107,157,64,16,253,43,226,67,159,220,139,186,171,171,246,241,114,3,129,146,134,126,17,8,33,140,187,179,185,82,117,141,174,180,65,252,239,29,245,222,54,228,161,220,199,22,68,220,143,51,115,230,204,25,167,199,106,184,170,106,135,125,97,160,30,48,24,175,117,225,103,42,133,48,41,13,203,66,101,152,16,165,100,0,40,88,170,68,104,36,202,72,36,210,15,90,104,176,240,55,244,65,87,206,15,42,135,205,80,220,79,127,130,186,126,196,224,209,172,139,207,234,136,13,124,93,18,80,176,212,148,153,100,42,140,21,19,128,25,3,205,35,6,121,204,149,214,121,46,148,241,55,46,148,43,142,227,136,110,233,56,99,130,39,17,43,19,73,175,44,53,137,9,35,19,133,220,15,106,52,238,240,179,235,113,24,42,219,22,19,254,254,254,242,210,17,203,45,247,222,214,99,211,250,65,131,14,110,193,29,11,63,21,107,161,192,120,18,106,74,65,53,151,70,103,204,80,142,28,164,48,60,71,63,80,208,185,37,172,191,183,173,3,69,149,246,104,176,199,86,225,171,162,162,180,68,158,18,191,204,96,204,68,148,228,44,211,58,100,144,133,92,139,52,227,90,19,83,13,14,190,65,61,226,74,108,170,8,88,198,121,18,202,200,48,137,144,51,129,105,76,192,8,88,30,229,165,225,146,199,198,196,103,185,63,88,251,125,236,72,234,225,102,108,176,175,212,169,111,72,13,176,125,49,41,98,216,219,122,9,126,243,10,176,245,231,116,120,183,105,82,175,39,11,208,159,131,113,192,125,93,97,235,14,173,178,186,106,159,214,214,205,51,97,154,14,250,106,56,43,121,120,30,161,38,1,170,167,227,95,21,223,143,131,179,205,255,86,111,64,181,82,24,114,235,202,121,49,179,174,134,174,134,151,117,93,248,239,158,71,235,222,127,66,208,158,237,58,219,187,177,173,220,139,183,84,233,129,33,156,55,96,141,202,81,68,207,29,209,179,63,90,236,119,87,85,63,56,111,25,15,207,26,143,116,26,235,245,134,178,245,122,217,182,187,147,181,182,248,254,27,30,231,188,74,242,50,225,161,97,58,204,35,178,43,185,43,43,85,204,114,174,164,212,38,87,42,14,119,64,11,0,161,24,25,187,164,137,9,145,1,7,206,210,76,198,52,52,66,170,52,218,93,98,252,19,151,57,248,167,52,184,191,30,62,46,1,183,201,219,236,240,176,163,221,55,27,135,26,27,234,47,89,228,2,209,102,2,220,158,211,21,211,37,18,46,144,67,235,168,242,237,183,82,76,151,104,58,63,156,85,125,152,233,249,5,1,227,254,146,128,5,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private string _addRights;
			public override string AddRights {
				get {
					return _addRights ?? (_addRights = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,93,79,65,78,195,48,16,252,138,21,174,117,149,118,29,187,201,181,20,132,132,40,2,137,75,213,195,198,94,211,72,142,93,57,14,168,170,250,119,156,192,137,219,206,236,204,238,204,225,250,100,154,162,174,165,109,21,148,124,173,37,112,161,1,56,182,82,115,5,74,0,89,208,176,42,139,197,22,253,27,161,105,82,28,105,2,59,211,165,198,162,27,102,116,79,142,18,253,225,247,48,70,77,77,1,197,226,49,162,79,148,231,93,127,118,225,66,84,44,94,176,207,248,112,55,93,99,225,124,14,49,141,190,75,23,102,48,33,67,155,40,178,33,159,211,169,243,159,44,157,136,133,111,79,113,249,208,197,33,177,46,81,207,130,101,145,134,209,205,10,29,220,44,14,126,185,159,132,119,199,98,241,129,110,156,159,28,158,134,153,124,215,39,234,241,55,223,113,153,217,127,196,206,81,79,62,53,87,173,160,173,160,180,220,148,245,138,11,99,74,190,105,245,154,215,160,149,50,182,214,122,93,222,178,225,21,99,238,145,179,54,87,204,43,68,161,121,213,218,150,11,40,137,35,32,112,185,81,235,141,180,66,105,185,154,44,59,159,114,205,109,112,99,239,155,171,220,136,170,2,84,28,171,218,112,33,45,114,180,162,229,86,43,73,181,37,144,181,184,29,167,50,251,51,69,156,250,189,117,159,167,244,76,95,228,154,98,85,220,142,63,160,13,224,194,191,1,0,0 })));
				}
				set {
					_addRights = value;
				}
			}

			internal Func<Guid> _employee1;
			public virtual Guid Employee1 {
				get {
					return (_employee1 ?? (_employee1 = () => Guid.Empty)).Invoke();
				}
				set {
					_employee1 = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		public OpportunityManagementProspecting(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityManagementProspecting";
			SchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: OpportunityManagementProspecting, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: OpportunityManagementProspecting, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual Guid CurrentOpportunity {
			get;
			set;
		}

		public virtual bool OpportunityStageChanged {
			get;
			set;
		}

		public virtual Guid MainContact {
			get;
			set;
		}

		private ProcessSalesManager _salesManager;
		public ProcessSalesManager SalesManager {
			get {
				return _salesManager ?? ((_salesManager) = new ProcessSalesManager(UserConnection, this));
			}
		}

		private ProcessFlowElement _start1;
		public ProcessFlowElement Start1 {
			get {
				return _start1 ?? (_start1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "Start1",
					SchemaElementUId = new Guid("80ba5382-aa5f-407f-adb0-a09f93271323"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("0906a331-a59b-4472-bf33-a9c04f38e6f6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private OpenEditPageUserTask1FlowElement _openEditPageUserTask1;
		public OpenEditPageUserTask1FlowElement OpenEditPageUserTask1 {
			get {
				return _openEditPageUserTask1 ?? (_openEditPageUserTask1 = new OpenEditPageUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadDataUserTask1FlowElement _readDataUserTask1;
		public ReadDataUserTask1FlowElement ReadDataUserTask1 {
			get {
				return _readDataUserTask1 ?? (_readDataUserTask1 = new ReadDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeAdminRightsUserTask1FlowElement _changeAdminRightsUserTask1;
		public ChangeAdminRightsUserTask1FlowElement ChangeAdminRightsUserTask1 {
			get {
				return _changeAdminRightsUserTask1 ?? (_changeAdminRightsUserTask1 = new ChangeAdminRightsUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeAdminRightsUserTask2FlowElement _changeAdminRightsUserTask2;
		public ChangeAdminRightsUserTask2FlowElement ChangeAdminRightsUserTask2 {
			get {
				return _changeAdminRightsUserTask2 ?? (_changeAdminRightsUserTask2 = new ChangeAdminRightsUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private IntermediateCatchSignalEvent1FlowElement _intermediateCatchSignalEvent1;
		public IntermediateCatchSignalEvent1FlowElement IntermediateCatchSignalEvent1 {
			get {
				return _intermediateCatchSignalEvent1 ?? ((_intermediateCatchSignalEvent1) = new IntermediateCatchSignalEvent1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _formulaTask1;
		public ProcessScriptTask FormulaTask1 {
			get {
				return _formulaTask1 ?? (_formulaTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask1",
					SchemaElementUId = new Guid("4529baea-eac0-49a9-818f-ed63ef212d92"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask1Execute,
				});
			}
		}

		private ReadDataUserTask2FlowElement _readDataUserTask2;
		public ReadDataUserTask2FlowElement ReadDataUserTask2 {
			get {
				return _readDataUserTask2 ?? (_readDataUserTask2 = new ReadDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessTerminateEvent _terminate2;
		public ProcessTerminateEvent Terminate2 {
			get {
				return _terminate2 ?? (_terminate2 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate2",
					SchemaElementUId = new Guid("5a3a044f-4e7d-4766-b31d-7faa8b9908e8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ReadDataUserTask3FlowElement _readDataUserTask3;
		public ReadDataUserTask3FlowElement ReadDataUserTask3 {
			get {
				return _readDataUserTask3 ?? (_readDataUserTask3 = new ReadDataUserTask3FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadDataUserTask4FlowElement _readDataUserTask4;
		public ReadDataUserTask4FlowElement ReadDataUserTask4 {
			get {
				return _readDataUserTask4 ?? (_readDataUserTask4 = new ReadDataUserTask4FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _formulaTask2;
		public ProcessScriptTask FormulaTask2 {
			get {
				return _formulaTask2 ?? (_formulaTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask2",
					SchemaElementUId = new Guid("90929524-44b3-4698-8b37-0a5c654d1461"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask2Execute,
				});
			}
		}

		private ProcessScriptTask _formulaTask3;
		public ProcessScriptTask FormulaTask3 {
			get {
				return _formulaTask3 ?? (_formulaTask3 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask3",
					SchemaElementUId = new Guid("1915b8b9-69de-4118-8fd3-21a88fdd3097"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask3Execute,
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
					SchemaElementUId = new Guid("b0b23273-c3ed-47d0-bab7-c44b1459da2c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = ScriptTask1Execute,
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
					SchemaElementUId = new Guid("9e7139c8-194f-4683-8e84-ae27396bdfa7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ChangeAdminRightsUserTask3FlowElement _changeAdminRightsUserTask3;
		public ChangeAdminRightsUserTask3FlowElement ChangeAdminRightsUserTask3 {
			get {
				return _changeAdminRightsUserTask3 ?? (_changeAdminRightsUserTask3 = new ChangeAdminRightsUserTask3FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeAdminRightsUserTask4FlowElement _changeAdminRightsUserTask4;
		public ChangeAdminRightsUserTask4FlowElement ChangeAdminRightsUserTask4 {
			get {
				return _changeAdminRightsUserTask4 ?? (_changeAdminRightsUserTask4 = new ChangeAdminRightsUserTask4FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("6abb8a1d-d77d-4d5d-9a41-f39f1512025d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow2;
		public ProcessConditionalFlow ConditionalFlow2 {
			get {
				return _conditionalFlow2 ?? (_conditionalFlow2 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow2",
					SchemaElementUId = new Guid("47c8f086-6221-4fdc-abce-6709e2e61ead"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow3;
		public ProcessConditionalFlow ConditionalFlow3 {
			get {
				return _conditionalFlow3 ?? (_conditionalFlow3 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow3",
					SchemaElementUId = new Guid("3351d977-0f52-4d7f-8471-7f0b417a163a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow4;
		public ProcessConditionalFlow ConditionalFlow4 {
			get {
				return _conditionalFlow4 ?? (_conditionalFlow4 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow4",
					SchemaElementUId = new Guid("4476647f-b722-42dd-ac2f-219a0e5e87de"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow5;
		public ProcessConditionalFlow ConditionalFlow5 {
			get {
				return _conditionalFlow5 ?? (_conditionalFlow5 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow5",
					SchemaElementUId = new Guid("ea08f07d-eb4d-48f3-a091-6ee9d8a32153"),
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
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[OpenEditPageUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditPageUserTask1 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[ChangeAdminRightsUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeAdminRightsUserTask1 };
			FlowElements[ChangeAdminRightsUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeAdminRightsUserTask2 };
			FlowElements[IntermediateCatchSignalEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchSignalEvent1 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
			FlowElements[ReadDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask2 };
			FlowElements[Terminate2.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate2 };
			FlowElements[ReadDataUserTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask3 };
			FlowElements[ReadDataUserTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask4 };
			FlowElements[FormulaTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask2 };
			FlowElements[FormulaTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask3 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ChangeAdminRightsUserTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeAdminRightsUserTask3 };
			FlowElements[ChangeAdminRightsUserTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeAdminRightsUserTask4 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("IntermediateCatchSignalEvent1", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "OpenEditPageUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask1", e.Context.SenderName));
						break;
					case "ReadDataUserTask1":
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask4", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask3", e.Context.SenderName));
						break;
					case "ChangeAdminRightsUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeAdminRightsUserTask2", e.Context.SenderName));
						break;
					case "ChangeAdminRightsUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "IntermediateCatchSignalEvent1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate2", e.Context.SenderName));
						break;
					case "ReadDataUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "Terminate2":
						CompleteProcess();
						break;
					case "ReadDataUserTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask2", e.Context.SenderName));
						break;
					case "ReadDataUserTask4":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask3", e.Context.SenderName));
							break;
						}
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask3", e.Context.SenderName));
							break;
						}
						Log.ErrorFormat(DeadEndGatewayLogMessage, "ReadDataUserTask4");
						break;
					case "FormulaTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpenEditPageUserTask1", e.Context.SenderName));
						break;
					case "FormulaTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpenEditPageUserTask1", e.Context.SenderName));
						break;
					case "ScriptTask1":
						if (ConditionalFlow4ExpressionExecute()) {
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask2", e.Context.SenderName));
							break;
						}
						Log.ErrorFormat(DeadEndGatewayLogMessage, "ScriptTask1");
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow5ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeAdminRightsUserTask3", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeAdminRightsUserTask1", e.Context.SenderName));
						break;
					case "ChangeAdminRightsUserTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeAdminRightsUserTask4", e.Context.SenderName));
						break;
					case "ChangeAdminRightsUserTask4":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean((ReadDataUserTask4.ResultCount) > 0);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadDataUserTask4", "ConditionalFlow1", "(ReadDataUserTask4.ResultCount) > 0", result);
			return result;
		}

		private bool ConditionalFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean((ReadDataUserTask4.ResultCount) == 0);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadDataUserTask4", "ConditionalFlow2", "(ReadDataUserTask4.ResultCount) == 0", result);
			return result;
		}

		private bool ConditionalFlow3ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("ResponsibleDepartment").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("ResponsibleDepartmentId") : Guid.Empty)) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadDataUserTask1", "ConditionalFlow3", "((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName(\"ResponsibleDepartment\").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>(\"ResponsibleDepartmentId\") : Guid.Empty)) != Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlow4ExpressionExecute() {
			bool result = Convert.ToBoolean(true);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ScriptTask1", "ConditionalFlow4", "true", result);
			return result;
		}

		private bool ConditionalFlow5ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<Guid>("AccountId") : Guid.Empty)) == Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalFlow5", "((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName(\"Account\").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<Guid>(\"AccountId\") : Guid.Empty)) == Guid.Empty", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("ChangeAdminRightsUserTask1.Employee1")) {
				writer.WriteValue("ChangeAdminRightsUserTask1.Employee1", ChangeAdminRightsUserTask1.Employee1, Guid.Empty);
			}
			if (!HasMapping("ChangeAdminRightsUserTask2.Employee1")) {
				writer.WriteValue("ChangeAdminRightsUserTask2.Employee1", ChangeAdminRightsUserTask2.Employee1, Guid.Empty);
			}
			if (!HasMapping("ChangeAdminRightsUserTask3.Employee1")) {
				writer.WriteValue("ChangeAdminRightsUserTask3.Employee1", ChangeAdminRightsUserTask3.Employee1, Guid.Empty);
			}
			if (!HasMapping("ChangeAdminRightsUserTask4.Employee1")) {
				writer.WriteValue("ChangeAdminRightsUserTask4.Employee1", ChangeAdminRightsUserTask4.Employee1, Guid.Empty);
			}
			if (!HasMapping("CurrentOpportunity")) {
				writer.WriteValue("CurrentOpportunity", CurrentOpportunity, Guid.Empty);
			}
			if (!HasMapping("MainContact")) {
				writer.WriteValue("MainContact", MainContact, Guid.Empty);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			if (IsProcessExecutedBySignal) {
				return;
			}
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("Start1", string.Empty));
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

		protected override void InitializeMetaPathParameterValues() {
			base.InitializeMetaPathParameterValues();
			MetaPathParameterValues.Add("4c6e9a6c-52a3-4f25-879f-96941c1aa349", () => CurrentOpportunity);
			MetaPathParameterValues.Add("0bd1bc47-97dc-487d-b8b8-e5bd0a629ed8", () => OpportunityStageChanged);
			MetaPathParameterValues.Add("83114e9e-fb66-424f-a1a6-d23fb5945480", () => MainContact);
			MetaPathParameterValues.Add("ae7d9be8-2794-4f16-9a39-ccf50ecdba24", () => OpenEditPageUserTask1.ObjectSchemaId);
			MetaPathParameterValues.Add("db76b6e1-5420-4968-9631-759ba37819e2", () => OpenEditPageUserTask1.PageSchemaId);
			MetaPathParameterValues.Add("6efa15b1-5137-45fa-809e-79bb3db89358", () => OpenEditPageUserTask1.EditMode);
			MetaPathParameterValues.Add("9324bb9c-5017-411c-b5a5-fb117947ef43", () => OpenEditPageUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("f271250b-3c06-467b-b95f-c2d2e9c3019c", () => OpenEditPageUserTask1.RecordId);
			MetaPathParameterValues.Add("dbb47148-8d67-4fe3-825b-477f8d55c92b", () => OpenEditPageUserTask1.ExecutedMode);
			MetaPathParameterValues.Add("701175ea-0e46-4f61-938b-eedf9af21920", () => OpenEditPageUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("540b1d28-96f8-4793-b6dc-f222c6d4efbd", () => OpenEditPageUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("8a056fe6-95e1-4710-b4ff-d50ef63e2916", () => OpenEditPageUserTask1.GenerateDecisionsFromColumn);
			MetaPathParameterValues.Add("e842c411-a194-41b8-8520-bc517224cd01", () => OpenEditPageUserTask1.DecisionalColumnMetaPath);
			MetaPathParameterValues.Add("d6313c1e-3152-439f-88a5-ca4f5b397ee8", () => OpenEditPageUserTask1.ResultParameter);
			MetaPathParameterValues.Add("ed2ab973-7009-4a0c-bc37-6e4eaa3450bd", () => OpenEditPageUserTask1.IsReexecution);
			MetaPathParameterValues.Add("5f81e72e-7cb6-4775-b4ef-709235e30ef2", () => OpenEditPageUserTask1.Recommendation);
			MetaPathParameterValues.Add("e825034b-3779-4c1e-aa88-08a25cddf922", () => OpenEditPageUserTask1.ActivityCategory);
			MetaPathParameterValues.Add("79b71a16-363b-4270-804f-96c0266a9226", () => OpenEditPageUserTask1.OwnerId);
			MetaPathParameterValues.Add("49fc1967-693a-4c7c-a90b-ff57e9609483", () => OpenEditPageUserTask1.Duration);
			MetaPathParameterValues.Add("15acbe32-9e04-4bda-813f-0dbf7140366e", () => OpenEditPageUserTask1.DurationPeriod);
			MetaPathParameterValues.Add("fac6a98d-6e1f-4791-90ff-6388fd5c7dfa", () => OpenEditPageUserTask1.StartIn);
			MetaPathParameterValues.Add("52348b4d-d057-423b-bbd2-b27ffdcb31b7", () => OpenEditPageUserTask1.StartInPeriod);
			MetaPathParameterValues.Add("ac12bebe-1559-4b69-be65-0ec920c26ed8", () => OpenEditPageUserTask1.RemindBefore);
			MetaPathParameterValues.Add("1163d8da-f734-4ad7-824c-da7bd888483c", () => OpenEditPageUserTask1.RemindBeforePeriod);
			MetaPathParameterValues.Add("09e933cd-ec8e-464b-aa57-a0653129c148", () => OpenEditPageUserTask1.ShowInScheduler);
			MetaPathParameterValues.Add("e108111b-f473-4ec3-ac71-171a7e932396", () => OpenEditPageUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("c5cbdcb1-8456-4d6c-a2a3-efde611f3db8", () => OpenEditPageUserTask1.Lead);
			MetaPathParameterValues.Add("8727b23d-8ab9-43de-adcf-b6411baf04bf", () => OpenEditPageUserTask1.Account);
			MetaPathParameterValues.Add("701b6be8-7bde-4ddc-a8ea-05d5e3a6f32b", () => OpenEditPageUserTask1.Contact);
			MetaPathParameterValues.Add("070365fb-e8d5-49f1-a71d-933a82563693", () => OpenEditPageUserTask1.Opportunity);
			MetaPathParameterValues.Add("798646c0-f074-4300-a2d7-73558f4302b8", () => OpenEditPageUserTask1.Invoice);
			MetaPathParameterValues.Add("97e1828c-89e8-4b30-a736-129257a18787", () => OpenEditPageUserTask1.Document);
			MetaPathParameterValues.Add("dc76bc3f-26e8-4e12-99eb-06875b580140", () => OpenEditPageUserTask1.Incident);
			MetaPathParameterValues.Add("10863539-42e3-4ec9-a0e1-93835649f96f", () => OpenEditPageUserTask1.Case);
			MetaPathParameterValues.Add("ed45b44a-4ef2-4090-a7d6-d660ff6794df", () => OpenEditPageUserTask1.ActivityResult);
			MetaPathParameterValues.Add("4dddec06-0b54-4279-b578-5adbd29937de", () => OpenEditPageUserTask1.CurrentActivityId);
			MetaPathParameterValues.Add("9dea1cae-603b-480e-91b9-2cedc8043fe3", () => OpenEditPageUserTask1.IsActivityCompleted);
			MetaPathParameterValues.Add("396ca1cb-2a2c-47c0-9bce-7f8d32e2948e", () => OpenEditPageUserTask1.ExecutionContext);
			MetaPathParameterValues.Add("d8194d6c-dcc9-4b4e-a9d6-3d49314e8e98", () => OpenEditPageUserTask1.PageTypeUId);
			MetaPathParameterValues.Add("0c84cdb3-00ef-43ef-8ec5-929ab4936120", () => OpenEditPageUserTask1.ActivitySchemaUId);
			MetaPathParameterValues.Add("265cd111-1e70-4cac-83ae-bf14d2756bb9", () => OpenEditPageUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("2d1fa997-5890-44a6-8b5f-864795599deb", () => OpenEditPageUserTask1.Order);
			MetaPathParameterValues.Add("69814e7a-c257-4df5-bec5-ce4565034b2d", () => OpenEditPageUserTask1.Requests);
			MetaPathParameterValues.Add("862b6225-5967-4969-9fd9-8c8e79df20c0", () => OpenEditPageUserTask1.Listing);
			MetaPathParameterValues.Add("ead44738-c37f-4ac5-b25e-4cbcd2ae893b", () => OpenEditPageUserTask1.Property);
			MetaPathParameterValues.Add("b0849d2a-bce7-43f8-beb1-fa2c375357ac", () => OpenEditPageUserTask1.Contract);
			MetaPathParameterValues.Add("d7450c11-e4da-4c5a-96e1-fbcb7ea94867", () => OpenEditPageUserTask1.Problem);
			MetaPathParameterValues.Add("c54f578d-a593-499f-a846-b08a7bd3ca7b", () => OpenEditPageUserTask1.Change);
			MetaPathParameterValues.Add("40753f3d-3149-4919-9649-169e2c608b25", () => OpenEditPageUserTask1.Release);
			MetaPathParameterValues.Add("54a12540-bcb5-4fb7-b795-3cc857cd0d72", () => OpenEditPageUserTask1.Project);
			MetaPathParameterValues.Add("6f986137-04cb-4983-b7b0-54ae0cf8a109", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("9ead078e-f887-43ca-a04e-d8ce3a1ce902", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("3f155961-0b7c-488a-ad58-3d3edf964358", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("97f729d1-9c97-41b7-807b-90a33d51655e", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("36f4066e-90fc-4fdb-9746-c383e7463ec7", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("05e54116-4bc1-4945-ba99-e9e2dc05d937", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("e6227e17-dc85-4e02-837c-e9990987d128", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("40333f27-6073-4fdf-8195-0a76448c3050", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("0bfa05ed-5c32-4321-830d-fdf5729623fc", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("7072dcc2-6391-4ac4-90c5-03e41d350032", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("158d4a9d-89ef-4cff-94d2-a1d2c46119d9", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("5c5148f8-73c6-4e66-9f88-0776da38ac4a", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("5306de25-557e-4d14-ab0d-61ef40ef14f7", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("7088c4df-1695-4ef3-bc05-566678b8b453", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("51c42171-ea97-42a6-86d6-748585c8132e", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("225571a2-2754-47d9-8903-bcf25cb22132", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("ac7c66ef-d757-43a3-b7c8-3172e4cf1bf7", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("043fe795-d872-437f-b39e-55a556b5fe39", () => ReadDataUserTask1.ResultCompositeObjectList);
			MetaPathParameterValues.Add("97825518-45a2-4cd1-bf70-efcf8cf88284", () => ReadDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("c0fec3ae-801f-45d1-9ef1-f5d96f2e507e", () => ChangeAdminRightsUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("219973db-f3e9-415f-9801-d02ea613c197", () => ChangeAdminRightsUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("bc07c289-1319-4c29-92d4-aebdf026812e", () => ChangeAdminRightsUserTask1.DeleteRights);
			MetaPathParameterValues.Add("d3292ff8-7bbd-45cb-a9ee-cb83ff795d43", () => ChangeAdminRightsUserTask1.AddRights);
			MetaPathParameterValues.Add("dbe40eec-c9dc-429e-ac14-9fa16d721d13", () => ChangeAdminRightsUserTask1.Employee1);
			MetaPathParameterValues.Add("4e965dc3-d0a7-4e19-90e1-c7cbf2fc0ab5", () => ChangeAdminRightsUserTask2.EntitySchemaUId);
			MetaPathParameterValues.Add("f82856dc-9a64-4a0c-9fb8-9535d9d36049", () => ChangeAdminRightsUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("1231ae80-ee39-4ea7-b240-5e40eeb4c9d1", () => ChangeAdminRightsUserTask2.DeleteRights);
			MetaPathParameterValues.Add("53a4af30-14e3-43b5-8ef1-88f2cf3a040f", () => ChangeAdminRightsUserTask2.AddRights);
			MetaPathParameterValues.Add("cca8554b-caff-492a-969a-6897ff936478", () => ChangeAdminRightsUserTask2.Employee1);
			MetaPathParameterValues.Add("09cca40d-6c18-48f7-9457-13734419af29", () => IntermediateCatchSignalEvent1.RecordId);
			MetaPathParameterValues.Add("6ae9a99b-d2db-4a58-b211-f6e962641886", () => ReadDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("8f241b16-53a3-4a3f-bca5-3fb01c76cdd9", () => ReadDataUserTask2.ResultType);
			MetaPathParameterValues.Add("feb5fafe-ddb7-4fe9-b154-6aef4a84a2cf", () => ReadDataUserTask2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("dee4a26d-9bf8-4814-aeaa-2079ae11751d", () => ReadDataUserTask2.NumberOfRecords);
			MetaPathParameterValues.Add("b36aaeec-e9e9-4b97-83b4-c930ade9d221", () => ReadDataUserTask2.FunctionType);
			MetaPathParameterValues.Add("93823506-41d3-455a-be79-cd11bd04d813", () => ReadDataUserTask2.AggregationColumnName);
			MetaPathParameterValues.Add("6f281dc6-1639-492d-b3a7-91eea3ca365f", () => ReadDataUserTask2.OrderInfo);
			MetaPathParameterValues.Add("a3c7aa4c-5bfb-430e-a3a3-687286f47c61", () => ReadDataUserTask2.ResultEntity);
			MetaPathParameterValues.Add("08fb2ebc-49a5-4226-98ba-39f6038c9c60", () => ReadDataUserTask2.ResultCount);
			MetaPathParameterValues.Add("1fb6d738-110a-43fc-b8d1-6ad1b87f1781", () => ReadDataUserTask2.ResultIntegerFunction);
			MetaPathParameterValues.Add("f96019c2-3d7b-4c65-af7c-00f7360fdef1", () => ReadDataUserTask2.ResultFloatFunction);
			MetaPathParameterValues.Add("607243ca-d4f9-4326-ba0d-63444eb5120f", () => ReadDataUserTask2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("5eef0b4b-0874-4d83-bc5e-5cd3703dc83e", () => ReadDataUserTask2.ResultRowsCount);
			MetaPathParameterValues.Add("960b87b1-7cf1-4c07-9505-dcda4ff83c63", () => ReadDataUserTask2.CanReadUncommitedData);
			MetaPathParameterValues.Add("32c63487-e6c1-47ec-90de-78ac92f5bc30", () => ReadDataUserTask2.ResultEntityCollection);
			MetaPathParameterValues.Add("8633d044-d682-4d53-abc5-2ebe81cc2939", () => ReadDataUserTask2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("a147c744-f32b-48b9-a6b4-71a9270154db", () => ReadDataUserTask2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("6b0b18f7-2baa-456c-9d14-bec0da9c1525", () => ReadDataUserTask2.ResultCompositeObjectList);
			MetaPathParameterValues.Add("294349f9-aad1-46d2-a999-a076e9a3e823", () => ReadDataUserTask2.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("113f4e62-765c-44d4-8ae1-58cf9d82d61f", () => ReadDataUserTask3.DataSourceFilters);
			MetaPathParameterValues.Add("081ada6f-f2ec-42a9-9282-5b3d9c407f55", () => ReadDataUserTask3.ResultType);
			MetaPathParameterValues.Add("50975cf4-f986-42be-848f-f2dbab118fa5", () => ReadDataUserTask3.ReadSomeTopRecords);
			MetaPathParameterValues.Add("8e5ac671-36f1-474e-9cff-66a8407b8fa5", () => ReadDataUserTask3.NumberOfRecords);
			MetaPathParameterValues.Add("e0169671-eb4f-4762-b6a3-191c60062fb3", () => ReadDataUserTask3.FunctionType);
			MetaPathParameterValues.Add("19d5393e-631c-4edd-b20b-b75111f8c70b", () => ReadDataUserTask3.AggregationColumnName);
			MetaPathParameterValues.Add("0498e93f-e38c-409f-a4b4-8d6ca4869331", () => ReadDataUserTask3.OrderInfo);
			MetaPathParameterValues.Add("b2e51ef1-6aab-4ca1-8848-6008a8d519a5", () => ReadDataUserTask3.ResultEntity);
			MetaPathParameterValues.Add("1e00e7f8-aeee-4b21-a00c-23045ba60e93", () => ReadDataUserTask3.ResultCount);
			MetaPathParameterValues.Add("bf8fa2bb-6f13-45d3-8ac3-1af8add4e2e1", () => ReadDataUserTask3.ResultIntegerFunction);
			MetaPathParameterValues.Add("b11bba9c-7570-4c91-b5b8-ce0f87f32de9", () => ReadDataUserTask3.ResultFloatFunction);
			MetaPathParameterValues.Add("3f45a94b-9b1a-45bc-a1eb-1c63396fd296", () => ReadDataUserTask3.ResultDateTimeFunction);
			MetaPathParameterValues.Add("65beb8a8-7a77-4d89-b41a-5e90a25bf16f", () => ReadDataUserTask3.ResultRowsCount);
			MetaPathParameterValues.Add("70f9d4af-0491-4dd3-bc7e-64f44d775fc3", () => ReadDataUserTask3.CanReadUncommitedData);
			MetaPathParameterValues.Add("02165bd8-27fb-4e68-8dbc-6910d0dd6351", () => ReadDataUserTask3.ResultEntityCollection);
			MetaPathParameterValues.Add("c018b09d-9be8-4dc0-94a3-6a98bb7f7223", () => ReadDataUserTask3.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("b90f88bb-6a42-491a-b18c-602ac3087bbb", () => ReadDataUserTask3.IgnoreDisplayValues);
			MetaPathParameterValues.Add("61e3d8cf-9ddc-4ab6-89f2-6c7c56ad263b", () => ReadDataUserTask3.ResultCompositeObjectList);
			MetaPathParameterValues.Add("951b30fa-c86c-4c03-9672-c8029124a84c", () => ReadDataUserTask3.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("a20fbdf2-0724-4878-885a-78691620252b", () => ReadDataUserTask4.DataSourceFilters);
			MetaPathParameterValues.Add("27339781-38b3-4487-9014-db0a37f14b83", () => ReadDataUserTask4.ResultType);
			MetaPathParameterValues.Add("4521de8c-08bc-444c-b658-6c4d2a4e5fe3", () => ReadDataUserTask4.ReadSomeTopRecords);
			MetaPathParameterValues.Add("7d343aa0-5460-4284-979f-8f5994a7d42b", () => ReadDataUserTask4.NumberOfRecords);
			MetaPathParameterValues.Add("e1b48494-ddbb-473b-a958-1051eee1f98a", () => ReadDataUserTask4.FunctionType);
			MetaPathParameterValues.Add("70780388-abf3-42af-893d-f28adb4649e9", () => ReadDataUserTask4.AggregationColumnName);
			MetaPathParameterValues.Add("aec5d8f1-c2e7-4e32-a7c0-04acfef39267", () => ReadDataUserTask4.OrderInfo);
			MetaPathParameterValues.Add("bee4631c-fc60-4367-b698-697143c1db86", () => ReadDataUserTask4.ResultEntity);
			MetaPathParameterValues.Add("a3bc60f3-2c39-4535-b598-fbd578d70e3e", () => ReadDataUserTask4.ResultCount);
			MetaPathParameterValues.Add("abc3c14b-0934-40d2-bbe4-d7850d2fbf68", () => ReadDataUserTask4.ResultIntegerFunction);
			MetaPathParameterValues.Add("769bd711-c503-449a-b51c-4a46a32185a4", () => ReadDataUserTask4.ResultFloatFunction);
			MetaPathParameterValues.Add("3f93d92a-65c1-4d5d-a345-d590032b6d6f", () => ReadDataUserTask4.ResultDateTimeFunction);
			MetaPathParameterValues.Add("4c78f474-685f-4529-81f4-9021f679a821", () => ReadDataUserTask4.ResultRowsCount);
			MetaPathParameterValues.Add("092e4b03-f419-48ef-a4be-8468d71225ed", () => ReadDataUserTask4.CanReadUncommitedData);
			MetaPathParameterValues.Add("e799395e-b3b7-458a-83af-8462a0ee992e", () => ReadDataUserTask4.ResultEntityCollection);
			MetaPathParameterValues.Add("5e3110b5-1123-4cb7-b152-accafabe8138", () => ReadDataUserTask4.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("3dd48f20-8cf8-49bb-802a-23fa55d6001d", () => ReadDataUserTask4.IgnoreDisplayValues);
			MetaPathParameterValues.Add("c22bc1d6-ca51-406d-91f3-c32ff0511135", () => ReadDataUserTask4.ResultCompositeObjectList);
			MetaPathParameterValues.Add("8a75e1d4-a585-49a8-a159-b053271cf991", () => ReadDataUserTask4.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("e7f3928e-a4d5-465d-bbc7-a71f81fc3a25", () => ChangeAdminRightsUserTask3.EntitySchemaUId);
			MetaPathParameterValues.Add("5a649550-03e1-4b0f-bc8c-d2de65fc0b09", () => ChangeAdminRightsUserTask3.DataSourceFilters);
			MetaPathParameterValues.Add("d450dd6d-3502-4a49-93dc-3796f8d6b862", () => ChangeAdminRightsUserTask3.DeleteRights);
			MetaPathParameterValues.Add("c573582f-cae6-4f5d-9f77-cddaff23070d", () => ChangeAdminRightsUserTask3.AddRights);
			MetaPathParameterValues.Add("03b2071a-f297-4da2-94d0-c7adea6c61ea", () => ChangeAdminRightsUserTask3.Employee1);
			MetaPathParameterValues.Add("c2fd6fee-f1c7-45e7-ac9a-c1ab494df220", () => ChangeAdminRightsUserTask4.EntitySchemaUId);
			MetaPathParameterValues.Add("b7a5464f-131b-4b4c-8a32-1f2138329f44", () => ChangeAdminRightsUserTask4.DataSourceFilters);
			MetaPathParameterValues.Add("310641c2-c313-4ca7-9003-58bb95ba5d84", () => ChangeAdminRightsUserTask4.DeleteRights);
			MetaPathParameterValues.Add("0f101973-6976-4c62-8342-e1c9f265457a", () => ChangeAdminRightsUserTask4.AddRights);
			MetaPathParameterValues.Add("996fb730-2c63-4c33-ab6c-73743ef3c310", () => ChangeAdminRightsUserTask4.Employee1);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "ChangeAdminRightsUserTask1.Employee1":
					ChangeAdminRightsUserTask1.Employee1 = reader.GetValue<System.Guid>();
				break;
				case "ChangeAdminRightsUserTask2.Employee1":
					ChangeAdminRightsUserTask2.Employee1 = reader.GetValue<System.Guid>();
				break;
				case "ChangeAdminRightsUserTask3.Employee1":
					ChangeAdminRightsUserTask3.Employee1 = reader.GetValue<System.Guid>();
				break;
				case "ChangeAdminRightsUserTask4.Employee1":
					ChangeAdminRightsUserTask4.Employee1 = reader.GetValue<System.Guid>();
				break;
				case "CurrentOpportunity":
					if (!hasValueToRead) break;
					CurrentOpportunity = reader.GetValue<System.Guid>();
				break;
				case "MainContact":
					if (!hasValueToRead) break;
					MainContact = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool FormulaTask1Execute(ProcessExecutingContext context) {
			var localOpportunityStageChanged = true;
			OpportunityStageChanged = (System.Boolean)localOpportunityStageChanged;
			return true;
		}

		public virtual bool FormulaTask2Execute(ProcessExecutingContext context) {
			var localOpenEditPageUserTask1_OwnerId = ((ReadDataUserTask3.ResultEntity.IsColumnValueLoaded(ReadDataUserTask3.ResultEntity.Schema.Columns.GetByName("SalesDirector").ColumnValueName) ? ReadDataUserTask3.ResultEntity.GetTypedColumnValue<Guid>("SalesDirectorId") : Guid.Empty));
			OpenEditPageUserTask1.OwnerId = (System.Guid)localOpenEditPageUserTask1_OwnerId;
			return true;
		}

		public virtual bool FormulaTask3Execute(ProcessExecutingContext context) {
			var localOpenEditPageUserTask1_OwnerId = ((Guid)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentUserContact"));
			OpenEditPageUserTask1.OwnerId = (System.Guid)localOpenEditPageUserTask1_OwnerId;
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			return this.ReadDataUserTask2.ResultEntityCollection.Count == 0;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			if (Status == Core.Process.ProcessStatus.Inactive) {
				return;
			}
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer, writeFlowElements);
			WritePropertyValues(writer, false);
			writer.WriteFinishObject();
		}

		public override object CloneShallow() {
			var cloneItem = (OpportunityManagementProspecting)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

