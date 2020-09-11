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
	using Terrasoft.Configuration.OrderInvoice;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: CreateInvoiceFromOrderSchema

	/// <exclude/>
	public class CreateInvoiceFromOrderSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public CreateInvoiceFromOrderSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public CreateInvoiceFromOrderSchema(CreateInvoiceFromOrderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CreateInvoiceFromOrder";
			UId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835");
			CreatedInPackageId = new Guid("5aa8040b-8cb0-4885-ac08-be852fb6adeb");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = @"ru-RU";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"CreateInvoiceFromOrder";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,81,219,138,131,48,16,125,94,193,127,8,62,41,136,63,176,221,66,113,111,125,42,44,236,7,216,56,116,83,116,34,99,210,34,197,127,223,49,137,162,44,139,15,57,39,231,204,228,204,24,71,157,61,55,74,138,155,34,99,171,70,220,180,170,69,73,80,25,56,34,19,9,105,38,30,113,244,116,162,26,40,92,125,66,211,1,137,31,127,188,136,247,74,26,77,10,250,162,108,170,190,247,116,40,62,192,236,254,150,237,83,132,251,186,68,99,111,200,78,244,64,23,219,2,154,52,177,61,16,11,8,210,40,141,73,46,190,55,23,89,246,28,71,62,101,29,154,31,107,14,226,19,21,94,121,67,163,204,144,38,46,2,183,72,130,147,97,105,137,248,29,167,228,98,202,243,170,92,227,138,134,29,167,81,120,201,133,63,247,110,250,71,226,75,228,48,53,90,240,152,111,180,47,126,117,173,59,62,123,52,26,158,217,201,1,6,229,32,165,182,232,148,25,6,229,116,71,159,220,131,217,223,46,246,118,227,238,58,205,63,17,121,104,87,179,162,99,28,141,255,206,169,207,87,222,42,207,201,223,178,172,245,134,196,40,198,105,225,220,37,142,126,1,227,248,19,10,50,2,0,0 };
			RealUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835");
			Version = 0;
			PackageUId = new Guid("25b0287a-c3a8-4066-b6ef-e5dad7c3be5a");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateCurrentOrderParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("08117217-b6a2-4caa-87cb-57b42ebbdf81"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				Name = @"CurrentOrder",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCreatedInvoiceIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9b6df9ca-b4dc-4748-a446-878f58f9abe8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				Name = @"CreatedInvoiceId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCurrentOrderParameter());
			Parameters.Add(CreateCreatedInvoiceIdParameter());
		}

		protected virtual void InitializeOpenEditPageUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var objectSchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("d85118e6-2c1e-4d34-afa5-de5b61c76366"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				Value = @"bfb313dd-bb55-4e1b-8e42-3d346e0da7c5",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835")
			};
			parametrizedElement.Parameters.Add(objectSchemaIdParameter);
			var pageSchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("91937424-2f71-4f1f-a3b2-d440bd5541d2"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				Value = @"b8a98131-367e-4bc0-88b7-06bea6a143de",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835")
			};
			parametrizedElement.Parameters.Add(pageSchemaIdParameter);
			var editModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2dac85ca-0040-4966-a412-c2232b004d2b"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835")
			};
			parametrizedElement.Parameters.Add(editModeParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c1fbab13-0fcc-4a08-8a27-9c61b940678a"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				UId = new Guid("69857298-5af6-4e7c-8304-9fec7c1d334f"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{9b6df9ca-b4dc-4748-a446-878f58f9abe8}]#]",
				MetaPath = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{9b6df9ca-b4dc-4748-a446-878f58f9abe8}]#]",
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var executedModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("03005092-ebd2-40a5-a4ba-1feda715e4ab"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("0e17b357-37db-48e3-b5b8-e62e0687bddf"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e7f46f88-3a82-4148-a2e2-d7bd427e03a0"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var generateDecisionsFromColumnParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2ae3d7cd-e356-43c7-bc44-a3695025a7f9"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835")
			};
			parametrizedElement.Parameters.Add(generateDecisionsFromColumnParameter);
			var decisionalColumnMetaPathParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9bdca34c-1f63-47aa-a579-fdd93f26eac3"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835")
			};
			parametrizedElement.Parameters.Add(decisionalColumnMetaPathParameter);
			var resultParameterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4a705262-6f06-417e-a8c7-f5a2d1f63fe5"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("26151eb5-20dc-466e-972e-c72498300aa7"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("ea935a75-0c11-482c-9e99-d04fc6977707"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				Value = @"Fill in the needed fields and save the invoice",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var activityCategoryParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("961e2086-a12b-4d27-b095-40b1e64d6cc0"),
				UId = new Guid("a3c2a6f9-b087-4a04-b687-52b26aa4e66b"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("75d81580-4664-441e-9b0d-0d954ffefc72"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var durationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("56d9018d-ca95-4d5a-b482-07336f8786cb"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("171f4ae2-f53f-4545-8cec-973f64a4576c"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(durationPeriodParameter);
			var startInParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("83f5e8fe-aef9-4bc8-b439-e3d3f6f61866"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("22b00966-521c-4147-b0dd-880c07bb49b4"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(startInPeriodParameter);
			var remindBeforeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1076ae54-e8ed-4d6f-8d4d-2e25408bb776"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(remindBeforeParameter);
			var remindBeforePeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("390e7e01-63f1-47ee-9272-137e604112f1"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(remindBeforePeriodParameter);
			var showInSchedulerParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3100ca53-bbf6-4ce1-81f5-3a74d220ec16"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(showInSchedulerParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1864aa91-6db8-4edf-9528-1e271677b340"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("d4513854-0edf-4b46-864c-3ec250465806"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("d1a00ae7-ea8e-4faf-9be8-bbb151893c96"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(accountParameter);
			var contactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("81643ee9-7afe-4461-9cf6-9a97b4c18843"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(contactParameter);
			var opportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("7d314b93-7262-4ca5-9f0b-175bcee0be87"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(opportunityParameter);
			var invoiceParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				UId = new Guid("0dcd1985-fcf0-477b-85e3-cc32230b0c60"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("9d7f3abd-fc1c-4c09-8a0d-793ad6b9a9d1"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("28c6ffdb-91ea-49c5-a622-85c4248e047b"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("ca2ee227-e2c2-4921-9f1a-a4c6d06626af"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("b0b3b700-462c-4ee9-9ee9-96a4e8025ac3"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("181dd2d4-64b2-43c6-81b6-7da3a77e8d99"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("390cf318-8787-4fe8-a591-fd13ce90f619"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("7f8bb765-5d0a-48b2-9e75-386a8ab527be"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("60f21d76-a090-4c82-84cb-c585656e2ded"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835")
			};
			parametrizedElement.Parameters.Add(pageTypeUIdParameter);
			var activitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("88f33366-ebf3-4f29-a163-205a1deb5e34"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("3dd6fca7-4f4a-40a9-9e3d-f07132784352"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("278b08b6-9931-4a80-9bec-d1cf8806418e"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("94f83067-f3d9-441a-9281-b941faa79cfe"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("ea59ddce-2ba7-40ed-aa25-704516701ef4"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("fcc06da5-e8f1-46c5-b82b-cc2bad57d865"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("ffd60755-0701-4d4a-839e-d42c73b329d1"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("c4615610-2142-459f-939a-22b2b835c4e6"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("5bd2622b-1a31-47db-9cc6-ef0f1d28d691"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("6eb2abed-f54f-4366-b8c5-7433e0d5803b"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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
				UId = new Guid("f7032715-9611-4c85-ba14-fd6be7ecb408"),
				ContainerUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
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

		protected virtual void InitializeAddDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("e6c68d49-3a67-4c77-af1f-5ebc245cef08"),
				ContainerUId = new Guid("7c141fed-2ab7-4b81-aaf7-05788f198103"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"EntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"732baa21-890b-4894-a457-623630e33a6f",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f0e3fb86-16b6-43cd-bf28-e690dfa14675"),
				ContainerUId = new Guid("7c141fed-2ab7-4b81-aaf7-05788f198103"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,193,110,219,48,12,253,149,193,231,170,176,29,199,118,114,27,178,108,200,101,9,208,160,151,58,7,90,162,19,97,178,101,72,114,183,44,240,191,79,178,19,55,219,210,172,235,165,189,73,15,143,143,228,35,121,240,168,0,173,191,66,137,222,212,91,163,82,160,101,97,110,63,115,97,80,125,81,178,169,189,27,79,163,226,32,248,79,100,61,62,103,220,124,2,3,54,228,144,61,41,100,222,52,187,172,145,121,55,153,199,13,150,218,114,92,136,31,7,56,41,38,36,199,60,39,81,202,236,139,226,136,140,139,56,128,148,225,40,143,242,35,243,25,241,69,213,203,119,202,69,247,92,239,107,199,138,44,64,101,89,131,226,90,86,71,112,228,242,235,121,5,185,64,102,255,70,53,104,33,163,120,105,27,193,53,47,113,5,202,166,113,58,210,65,150,84,128,208,142,37,176,48,243,31,181,66,173,185,172,174,215,53,147,162,41,171,115,182,21,192,225,123,44,199,239,106,116,204,21,152,93,39,177,84,204,117,211,118,133,126,220,110,21,110,193,240,199,243,58,190,225,190,163,190,204,61,27,192,236,140,238,65,52,120,76,27,248,127,117,51,131,218,244,77,13,37,88,142,194,2,21,86,20,239,232,14,75,24,250,60,99,240,237,238,76,198,205,245,225,138,45,131,185,255,114,38,180,96,125,34,95,183,122,245,68,187,208,107,24,91,240,209,1,189,202,233,153,121,15,11,189,252,94,161,234,123,235,221,221,220,90,244,15,96,208,159,30,252,52,8,146,48,72,72,30,67,72,34,10,64,210,132,230,100,156,228,81,104,135,192,138,52,104,55,125,29,92,215,2,246,247,67,186,89,163,172,149,230,131,28,188,91,176,126,140,163,52,30,39,126,68,130,9,70,36,138,67,32,121,130,1,161,241,24,210,17,197,9,195,216,46,68,219,110,90,183,21,66,110,57,5,177,172,81,193,113,100,254,229,173,254,237,28,156,13,74,74,115,105,146,43,37,89,67,77,87,212,105,185,108,70,123,241,206,205,59,217,40,138,253,153,233,254,212,95,117,194,111,112,157,255,121,112,207,44,243,75,150,243,189,172,221,251,219,169,214,107,127,1,81,160,194,163,94,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("21a0db48-c769-44b9-bca9-1e4a8e5d8196"),
				ContainerUId = new Guid("7c141fed-2ab7-4b81-aaf7-05788f198103"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordAddMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			recordAddModeParameter.SourceValue = new ProcessSchemaParameterValue(recordAddModeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,51,4,0,183,239,220,131,1,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("98e598ab-767c-4f41-b9d0-7f528e24771c"),
				ContainerUId = new Guid("7c141fed-2ab7-4b81-aaf7-05788f198103"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"FilterEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			filterEntitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(filterEntitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"a31247aa-b718-40ed-982e-5b569d7d7b0e",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9aee3d4d-32c8-472c-b908-f40aee815e2b"),
				ContainerUId = new Guid("7c141fed-2ab7-4b81-aaf7-05788f198103"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordDefValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordDefValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordDefValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,154,77,111,27,71,18,134,255,138,64,39,55,149,208,223,221,165,219,34,185,24,112,18,239,218,201,197,246,161,170,187,122,67,128,34,13,126,36,235,24,250,239,91,67,73,241,7,236,1,105,83,81,22,59,60,80,226,144,221,213,51,243,62,93,245,118,207,219,217,55,219,55,175,101,118,57,123,46,235,53,109,86,125,123,241,221,106,45,23,79,215,171,42,155,205,197,147,85,165,197,252,15,226,133,60,165,53,93,201,86,214,191,208,98,39,155,39,243,205,246,252,236,195,102,179,243,217,55,191,237,191,157,93,190,120,59,123,188,149,171,159,31,55,237,221,184,104,125,22,15,46,153,10,161,35,2,37,12,64,209,18,90,74,190,198,174,141,235,106,177,187,90,254,32,91,122,74,219,95,103,151,111,103,251,222,180,131,150,187,88,139,4,84,188,133,80,29,1,83,14,192,141,56,150,18,179,79,126,118,125,62,219,212,95,229,138,246,65,223,53,206,222,49,145,179,80,208,48,132,50,4,14,49,67,114,218,202,136,247,148,250,208,248,246,247,199,71,109,243,205,235,5,189,249,229,227,246,47,30,61,147,133,212,237,124,181,60,91,203,102,183,216,94,252,188,156,111,207,86,253,236,74,104,179,91,203,163,87,67,251,215,31,92,218,247,123,120,251,242,230,14,189,156,93,190,252,220,61,186,253,251,108,127,234,31,222,165,143,111,208,203,217,249,203,217,179,213,110,93,135,30,147,126,248,254,189,161,239,131,236,127,242,209,199,187,59,162,71,150,187,197,226,246,200,247,180,165,187,31,222,29,94,181,121,159,75,123,188,124,118,119,35,246,189,152,219,23,124,226,237,238,117,51,182,175,105,246,3,45,233,223,178,254,81,47,192,187,177,255,57,202,231,122,25,239,58,102,135,209,100,219,33,11,33,4,73,14,74,179,4,104,145,187,87,189,244,238,246,173,255,37,93,214,178,172,242,225,192,124,233,206,57,35,144,77,137,16,48,52,224,80,17,60,38,125,113,242,46,243,109,251,205,254,106,15,40,220,142,107,184,84,215,179,235,235,243,247,1,145,234,140,205,196,80,106,208,14,75,70,29,16,53,176,209,246,30,188,160,9,102,20,144,138,185,166,65,212,84,244,2,133,236,26,160,41,12,136,86,146,231,20,217,196,211,3,114,104,212,35,0,121,190,218,210,98,194,226,65,176,192,132,6,189,56,112,28,4,130,222,65,40,197,19,248,230,185,212,100,187,169,109,12,139,131,7,118,40,22,69,181,95,77,239,16,187,81,44,82,52,192,9,43,152,160,156,38,235,82,10,50,138,133,77,213,134,90,11,132,136,170,108,83,20,212,90,85,232,156,170,67,233,236,110,148,125,90,44,14,141,122,44,22,231,103,76,27,57,171,187,245,112,241,223,76,148,76,148,12,148,52,239,72,245,150,193,117,223,85,167,189,0,71,143,224,106,75,154,83,114,235,226,199,147,71,144,16,67,40,64,45,104,157,211,85,185,88,135,105,220,132,140,166,25,227,251,61,80,114,104,212,35,40,249,231,142,150,219,249,118,34,227,97,200,136,89,36,84,45,149,163,212,160,147,95,215,122,25,99,3,79,174,164,66,84,144,202,95,74,134,150,39,98,179,20,136,158,181,62,9,86,235,60,175,69,10,119,167,156,186,26,35,243,40,25,61,137,161,210,13,36,97,61,163,128,9,200,160,3,118,14,107,247,106,93,90,58,61,25,135,70,253,2,50,110,83,200,78,109,200,230,98,194,100,194,100,192,132,115,80,135,27,117,38,182,93,203,44,214,73,184,4,34,168,177,58,182,189,90,83,210,40,38,198,231,168,37,191,64,175,42,247,144,139,78,229,236,68,85,107,98,107,206,150,226,218,233,48,153,111,158,212,63,110,197,186,93,171,206,142,30,199,199,224,124,190,199,79,160,52,92,201,137,156,7,33,167,176,239,14,153,65,180,224,129,80,37,2,197,26,193,161,39,212,47,18,211,168,111,63,57,57,22,19,69,21,48,80,110,164,149,190,66,67,54,33,24,107,67,104,49,99,247,227,9,166,21,239,89,109,52,148,110,213,47,216,212,129,164,91,232,89,213,74,172,226,53,39,36,231,216,168,199,24,20,250,207,4,197,131,64,241,181,139,89,164,42,138,93,101,99,6,9,132,230,27,80,18,85,68,106,226,172,245,157,229,56,40,124,73,62,89,77,109,213,146,131,224,134,130,171,137,129,108,114,244,166,187,150,221,248,106,47,54,182,177,89,15,234,163,181,108,43,170,209,34,122,130,189,114,140,152,67,45,94,78,15,197,161,81,143,131,226,236,219,9,139,7,193,226,111,87,101,185,64,41,149,164,194,12,90,146,4,71,154,188,130,81,195,78,209,103,12,232,92,8,163,88,16,230,108,7,154,212,26,84,8,200,67,97,83,5,152,177,83,47,150,91,189,7,51,114,104,212,35,176,80,53,183,93,221,78,96,252,79,230,139,80,179,230,7,106,218,148,203,176,110,99,64,39,124,1,44,170,239,16,19,118,105,71,129,17,27,218,106,130,146,218,120,88,229,245,29,138,213,241,153,222,66,237,220,168,182,56,10,134,243,185,82,86,117,114,136,195,138,156,26,126,42,194,144,178,120,19,213,202,116,239,254,10,251,113,232,56,190,202,126,124,183,219,108,87,87,103,175,39,134,38,35,242,158,133,215,87,172,168,12,113,209,89,218,168,143,71,171,122,110,145,122,244,173,152,128,227,53,151,205,226,34,214,166,67,72,94,181,219,20,194,170,78,218,25,230,32,142,168,21,190,135,157,146,3,163,30,145,92,84,144,117,181,91,110,207,167,202,235,129,224,248,219,109,144,20,27,99,75,90,212,231,172,201,42,24,173,7,177,56,132,76,70,167,231,78,217,26,55,190,12,92,107,73,212,2,152,60,236,176,132,97,31,146,136,129,180,177,115,137,81,12,221,195,50,240,129,81,143,128,227,31,87,3,26,19,23,19,23,251,213,171,90,189,154,219,14,201,160,22,94,157,42,96,213,58,76,13,188,142,197,163,211,114,102,220,145,52,118,165,114,214,83,200,73,211,32,122,77,131,161,3,102,10,53,153,130,24,238,195,145,28,24,245,72,163,78,19,27,19,27,239,182,14,59,214,152,141,213,226,125,88,217,21,203,234,120,117,6,118,28,209,8,138,58,226,50,190,39,18,8,213,91,133,193,28,169,77,210,138,241,102,163,219,154,97,111,175,197,226,59,158,158,141,67,163,126,17,27,211,243,39,19,42,159,242,239,201,217,28,99,132,196,195,74,155,97,77,35,69,139,248,132,174,97,37,65,139,227,207,159,164,162,54,10,91,129,104,156,170,125,216,79,209,19,74,64,24,145,107,247,34,148,79,143,202,161,81,191,192,123,76,185,100,2,228,253,199,223,187,218,216,26,10,160,40,27,161,212,14,108,109,133,92,75,53,34,41,34,141,215,89,166,52,244,169,119,176,156,245,140,40,101,160,142,122,130,84,52,69,21,67,21,239,97,151,240,208,168,95,14,200,148,80,38,94,62,181,129,24,162,67,111,50,68,217,239,143,96,83,114,90,6,99,187,179,129,179,109,60,254,60,74,166,22,83,12,9,114,44,122,70,93,167,118,238,18,128,49,81,45,28,74,179,247,240,64,227,161,81,143,246,235,19,38,19,38,159,178,40,177,96,175,182,67,147,97,126,174,53,1,87,54,192,193,249,110,213,164,80,24,183,40,37,49,87,68,157,224,81,231,246,208,93,210,10,72,229,238,179,51,146,155,83,216,194,233,49,121,241,232,197,227,205,79,191,47,101,125,115,125,46,59,45,54,242,234,66,143,126,116,224,79,93,94,190,69,78,77,29,25,233,201,53,77,161,121,120,108,56,40,106,37,151,30,75,71,98,41,215,175,110,200,248,60,95,63,202,239,103,243,229,111,171,121,149,179,199,237,65,57,242,255,15,28,125,134,4,238,236,173,111,109,112,212,241,198,91,23,9,110,32,41,36,49,141,114,141,71,47,240,118,63,144,128,42,195,96,11,171,58,122,129,74,89,191,98,182,185,140,47,240,218,226,99,43,53,66,78,69,73,96,106,218,1,101,224,164,253,112,15,17,21,165,211,239,126,28,24,245,168,173,117,213,246,148,32,166,4,49,96,65,182,23,180,74,23,6,83,116,210,36,167,255,233,155,50,22,21,11,43,36,227,88,120,180,197,85,49,138,148,168,178,123,182,90,209,40,178,182,9,151,162,74,79,229,30,176,56,52,234,177,88,76,101,212,68,201,13,37,175,174,255,11,12,218,181,172,250,62,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("79d72c86-b946-4e74-b82c-577c9d0709aa"),
				ContainerUId = new Guid("7c141fed-2ab7-4b81-aaf7-05788f198103"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaTerminateEvent terminate2 = CreateTerminate2TerminateEvent();
			FlowElements.Add(terminate2);
			ProcessSchemaUserTask openeditpageusertask1 = CreateOpenEditPageUserTask1UserTask();
			FlowElements.Add(openeditpageusertask1);
			ProcessSchemaScriptTask createinvoicebyorderscripttask = CreateCreateInvoiceByOrderScriptTaskScriptTask();
			FlowElements.Add(createinvoicebyorderscripttask);
			ProcessSchemaUserTask adddatausertask1 = CreateAddDataUserTask1UserTask();
			FlowElements.Add(adddatausertask1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("f443c380-06ca-42a4-a4e4-b7b872174d35"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("5aa8040b-8cb0-4885-ac08-be852fb6adeb"),
				CreatedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a3117259-5f0d-4df4-bc73-269483d394df"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a003fd82-9248-4113-b40e-b8740d59adfc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("f46b6e3b-9407-4fbb-996a-46db3398573f"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{08117217-b6a2-4caa-87cb-57b42ebbdf81}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("5aa8040b-8cb0-4885-ac08-be852fb6adeb"),
				CreatedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				CurveCenterPosition = new Point(280, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a003fd82-9248-4113-b40e-b8740d59adfc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a4dd9327-058c-4700-90d5-2755a7fb610e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow5",
				UId = new Guid("6232cb52-bf09-4f98-ba6c-c2f814947e82"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("5aa8040b-8cb0-4885-ac08-be852fb6adeb"),
				CreatedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				CurveCenterPosition = new Point(196, 132),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a003fd82-9248-4113-b40e-b8740d59adfc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5ea2d96f-07ec-414d-94ef-8b09e6207daa"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("1e44a001-eb2b-4334-a096-4a5004526ddb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c8c880a9-c137-49b0-9cc0-525f6f195c44"),
				CreatedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0b76f581-3e18-4e18-be44-b60d06cfca12"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow2",
				UId = new Guid("0ee76b44-a070-4ad2-aaf7-74d92fd9cf6a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("650a2ad9-42d3-4738-b18c-b0f4ce2ed031"),
				CreatedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				CurveCenterPosition = new Point(424, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a4dd9327-058c-4700-90d5-2755a7fb610e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7c141fed-2ab7-4b81-aaf7-05788f198103"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("00639cff-47d3-49fc-9b19-be763f064d26"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("25b0287a-c3a8-4066-b6ef-e5dad7c3be5a"),
				CreatedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7c141fed-2ab7-4b81-aaf7-05788f198103"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("b3946209-b995-4883-907a-ab9d2b18d187"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("5aa8040b-8cb0-4885-ac08-be852fb6adeb"),
				CreatedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("c8da6c77-6ee6-42cc-8c4e-47768f1b383a"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("b3946209-b995-4883-907a-ab9d2b18d187"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("5aa8040b-8cb0-4885-ac08-be852fb6adeb"),
				CreatedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("a3117259-5f0d-4df4-bc73-269483d394df"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c8da6c77-6ee6-42cc-8c4e-47768f1b383a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("5aa8040b-8cb0-4885-ac08-be852fb6adeb"),
				CreatedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				Name = @"Start1",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("0b76f581-3e18-4e18-be44-b60d06cfca12"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c8da6c77-6ee6-42cc-8c4e-47768f1b383a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("5aa8040b-8cb0-4885-ac08-be852fb6adeb"),
				CreatedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				Name = @"Terminate1",
				Position = new Point(687, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("a003fd82-9248-4113-b40e-b8740d59adfc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c8da6c77-6ee6-42cc-8c4e-47768f1b383a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("5aa8040b-8cb0-4885-ac08-be852fb6adeb"),
				CreatedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				Name = @"ExclusiveGateway1",
				Position = new Point(134, 170),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate2TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("5ea2d96f-07ec-414d-94ef-8b09e6207daa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c8da6c77-6ee6-42cc-8c4e-47768f1b383a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("5aa8040b-8cb0-4885-ac08-be852fb6adeb"),
				CreatedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				Name = @"Terminate2",
				Position = new Point(148, 72),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateOpenEditPageUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c8da6c77-6ee6-42cc-8c4e-47768f1b383a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c8c880a9-c137-49b0-9cc0-525f6f195c44"),
				CreatedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				DragGroupName = @"Task",
				EntitySchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				Name = @"OpenEditPageUserTask1",
				Position = new Point(561, 170),
				SchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeOpenEditPageUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateCreateInvoiceByOrderScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a4dd9327-058c-4700-90d5-2755a7fb610e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c8da6c77-6ee6-42cc-8c4e-47768f1b383a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("650a2ad9-42d3-4738-b18c-b0f4ce2ed031"),
				CreatedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				Name = @"CreateInvoiceByOrderScriptTask",
				Position = new Point(281, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,46,74,77,44,73,245,204,43,203,207,76,78,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,141,78,144,14,30,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("7c141fed-2ab7-4b81-aaf7-05788f198103"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c8da6c77-6ee6-42cc-8c4e-47768f1b383a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("25b0287a-c3a8-4066-b6ef-e5dad7c3be5a"),
				CreatedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"),
				Name = @"AddDataUserTask1",
				Position = new Point(421, 170),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeAddDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("26608e55-5a62-4b83-bf82-7355ce9827fa"),
				Name = "Terrasoft.Configuration.OrderInvoice",
				Alias = "",
				CreatedInPackageId = new Guid("650a2ad9-42d3-4738-b18c-b0f4ce2ed031")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new CreateInvoiceFromOrder(userConnection);
		}

		public override object Clone() {
			return new CreateInvoiceFromOrderSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835"));
		}

		#endregion

	}

	#endregion

	#region Class: CreateInvoiceFromOrder

	/// <exclude/>
	public class CreateInvoiceFromOrder : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, CreateInvoiceFromOrder process)
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

			public OpenEditPageUserTask1FlowElement(UserConnection userConnection, CreateInvoiceFromOrder process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenEditPageUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("f1a1e116-6123-4a56-9344-3526a839225c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
				SerializeToDB = true;
				_recordId = () => (Guid)((process.CreatedInvoiceId));
			}

			#endregion

			#region Properties: Public

			private Guid _objectSchemaId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5");
			public override Guid ObjectSchemaId {
				get {
					return _objectSchemaId;
				}
				set {
					_objectSchemaId = value;
				}
			}

			private Guid _pageSchemaId = new Guid("b8a98131-367e-4bc0-88b7-06bea6a143de");
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
					return _recommendation ?? (_recommendation = GetLocalizableString("608044dbcecb4a1fbf9171d57b8a1835",
						 "BaseElements.OpenEditPageUserTask1.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: AddDataUserTask1FlowElement

		/// <exclude/>
		public class AddDataUserTask1FlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddDataUserTask1FlowElement(UserConnection userConnection, CreateInvoiceFromOrder process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("7c141fed-2ab7-4b81-aaf7-05788f198103");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Invoice = () => (Guid)((process.CreatedInvoiceId));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Unit", () => _recordDefValues_Unit.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_TotalAmount", () => _recordDefValues_TotalAmount.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_PrimaryTotalAmount", () => _recordDefValues_PrimaryTotalAmount.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Quantity", () => _recordDefValues_Quantity.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_BaseQuantity", () => _recordDefValues_BaseQuantity.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Name", () => _recordDefValues_Name.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Tax", () => _recordDefValues_Tax.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DiscountTax", () => _recordDefValues_DiscountTax.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Product", () => _recordDefValues_Product.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_CustomProduct", () => _recordDefValues_CustomProduct.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DiscountPercent", () => _recordDefValues_DiscountPercent.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Amount", () => _recordDefValues_Amount.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_TaxAmount", () => _recordDefValues_TaxAmount.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_PrimaryTaxAmount", () => _recordDefValues_PrimaryTaxAmount.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DiscountAmount", () => _recordDefValues_DiscountAmount.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_PrimaryDiscountAmount", () => _recordDefValues_PrimaryDiscountAmount.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_PrimaryAmount", () => _recordDefValues_PrimaryAmount.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Invoice", () => _recordDefValues_Invoice.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Price", () => _recordDefValues_Price.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_PrimaryPrice", () => _recordDefValues_PrimaryPrice.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_Unit;
			internal Func<Decimal> _recordDefValues_TotalAmount;
			internal Func<Decimal> _recordDefValues_PrimaryTotalAmount;
			internal Func<Decimal> _recordDefValues_Quantity;
			internal Func<Decimal> _recordDefValues_BaseQuantity;
			internal Func<string> _recordDefValues_Name;
			internal Func<Guid> _recordDefValues_Tax;
			internal Func<Decimal> _recordDefValues_DiscountTax;
			internal Func<Guid> _recordDefValues_Product;
			internal Func<string> _recordDefValues_CustomProduct;
			internal Func<Decimal> _recordDefValues_DiscountPercent;
			internal Func<Decimal> _recordDefValues_Amount;
			internal Func<Decimal> _recordDefValues_TaxAmount;
			internal Func<Decimal> _recordDefValues_PrimaryTaxAmount;
			internal Func<Decimal> _recordDefValues_DiscountAmount;
			internal Func<Decimal> _recordDefValues_PrimaryDiscountAmount;
			internal Func<Decimal> _recordDefValues_PrimaryAmount;
			internal Func<Guid> _recordDefValues_Invoice;
			internal Func<Decimal> _recordDefValues_Price;
			internal Func<Decimal> _recordDefValues_PrimaryPrice;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("732baa21-890b-4894-a457-623630e33a6f");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,193,110,219,48,12,253,149,193,231,170,176,29,199,118,114,27,178,108,200,101,9,208,160,151,58,7,90,162,19,97,178,101,72,114,183,44,240,191,79,178,19,55,219,210,172,235,165,189,73,15,143,143,228,35,121,240,168,0,173,191,66,137,222,212,91,163,82,160,101,97,110,63,115,97,80,125,81,178,169,189,27,79,163,226,32,248,79,100,61,62,103,220,124,2,3,54,228,144,61,41,100,222,52,187,172,145,121,55,153,199,13,150,218,114,92,136,31,7,56,41,38,36,199,60,39,81,202,236,139,226,136,140,139,56,128,148,225,40,143,242,35,243,25,241,69,213,203,119,202,69,247,92,239,107,199,138,44,64,101,89,131,226,90,86,71,112,228,242,235,121,5,185,64,102,255,70,53,104,33,163,120,105,27,193,53,47,113,5,202,166,113,58,210,65,150,84,128,208,142,37,176,48,243,31,181,66,173,185,172,174,215,53,147,162,41,171,115,182,21,192,225,123,44,199,239,106,116,204,21,152,93,39,177,84,204,117,211,118,133,126,220,110,21,110,193,240,199,243,58,190,225,190,163,190,204,61,27,192,236,140,238,65,52,120,76,27,248,127,117,51,131,218,244,77,13,37,88,142,194,2,21,86,20,239,232,14,75,24,250,60,99,240,237,238,76,198,205,245,225,138,45,131,185,255,114,38,180,96,125,34,95,183,122,245,68,187,208,107,24,91,240,209,1,189,202,233,153,121,15,11,189,252,94,161,234,123,235,221,221,220,90,244,15,96,208,159,30,252,52,8,146,48,72,72,30,67,72,34,10,64,210,132,230,100,156,228,81,104,135,192,138,52,104,55,125,29,92,215,2,246,247,67,186,89,163,172,149,230,131,28,188,91,176,126,140,163,52,30,39,126,68,130,9,70,36,138,67,32,121,130,1,161,241,24,210,17,197,9,195,216,46,68,219,110,90,183,21,66,110,57,5,177,172,81,193,113,100,254,229,173,254,237,28,156,13,74,74,115,105,146,43,37,89,67,77,87,212,105,185,108,70,123,241,206,205,59,217,40,138,253,153,233,254,212,95,117,194,111,112,157,255,121,112,207,44,243,75,150,243,189,172,221,251,219,169,214,107,127,1,81,160,194,163,94,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private string _recordAddMode;
			public override string RecordAddMode {
				get {
					return _recordAddMode ?? (_recordAddMode = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,51,4,0,183,239,220,131,1,0,0,0 })));
				}
				set {
					_recordAddMode = value;
				}
			}

			private Guid _filterEntitySchemaId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			public override Guid FilterEntitySchemaId {
				get {
					return _filterEntitySchemaId;
				}
				set {
					_filterEntitySchemaId = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,154,77,111,27,71,18,134,255,138,192,100,111,42,161,191,187,75,183,197,230,98,192,201,122,215,78,46,182,15,85,221,213,27,2,20,105,240,35,89,199,208,127,223,26,74,138,63,32,15,72,135,138,188,200,240,64,137,67,118,87,207,204,251,116,213,219,61,239,102,223,110,223,190,145,217,229,236,133,172,215,180,89,245,237,197,63,86,107,185,120,182,94,85,217,108,46,158,174,42,45,230,191,17,47,228,25,173,233,74,182,178,254,137,22,59,217,60,157,111,182,231,103,31,55,155,157,207,190,253,101,255,237,236,242,229,187,217,147,173,92,253,248,164,105,239,198,69,235,179,120,112,201,84,8,29,17,40,97,0,138,150,208,82,242,53,118,109,92,87,139,221,213,242,123,217,210,51,218,254,60,187,124,55,219,247,166,29,180,220,197,90,36,160,226,45,132,234,8,152,114,0,110,196,177,148,152,125,242,179,235,243,217,166,254,44,87,180,15,250,190,113,246,142,137,156,133,130,134,33,148,33,112,136,25,146,211,86,70,188,167,212,135,198,183,191,63,62,106,155,111,222,44,232,237,79,159,182,127,249,205,115,89,72,221,206,87,203,179,181,108,118,139,237,197,143,203,249,246,108,213,207,174,132,54,187,181,124,243,122,104,255,230,163,75,251,97,15,239,94,221,220,161,87,179,203,87,159,187,71,183,127,159,239,79,253,227,187,244,233,13,122,53,59,127,53,123,190,218,173,235,208,99,210,15,223,125,48,244,125,144,253,79,62,249,120,119,71,244,200,114,183,88,220,30,249,142,182,116,247,195,187,195,171,54,239,115,105,79,150,207,239,110,196,190,23,115,251,130,123,222,238,94,55,99,251,35,205,190,167,37,253,71,214,63,232,5,120,63,246,223,71,249,66,47,227,93,199,236,48,154,108,59,100,33,132,32,201,65,105,150,0,45,114,247,170,151,222,221,190,245,191,165,203,90,150,85,62,30,152,47,221,57,103,4,178,41,17,2,134,6,28,42,130,199,164,47,78,222,101,190,109,191,217,95,237,1,133,219,113,13,151,234,122,118,125,125,254,33,32,82,157,177,153,24,74,13,218,97,201,168,3,162,6,54,218,222,131,23,52,193,140,2,82,49,215,52,136,154,138,94,160,144,93,3,52,133,1,209,74,242,156,34,155,120,122,64,14,141,122,4,32,47,86,91,90,76,88,60,10,22,152,208,160,23,7,142,131,64,208,59,8,165,120,2,223,60,151,154,108,55,181,141,97,113,240,192,14,197,162,168,246,171,233,29,98,55,138,69,138,6,56,97,5,19,148,211,100,93,74,65,70,177,176,169,218,80,107,129,16,81,149,109,138,130,90,171,10,157,83,117,40,157,221,141,178,79,139,197,161,81,143,197,226,252,140,105,35,103,117,183,30,46,254,219,137,146,137,146,129,146,230,29,169,222,50,184,238,187,234,180,23,224,232,17,92,109,73,115,74,110,93,252,120,242,8,18,98,8,5,168,5,173,115,186,42,23,235,48,141,155,144,209,52,99,124,127,0,74,14,141,122,4,37,255,218,209,114,59,223,78,100,60,14,25,49,139,132,170,165,114,148,26,116,242,235,90,47,99,108,224,201,149,84,136,10,82,249,83,201,208,242,68,108,150,2,209,179,214,39,193,106,157,231,181,72,225,238,148,83,87,99,100,30,37,163,39,49,84,186,129,36,172,103,20,48,1,25,116,192,206,97,237,94,173,75,75,167,39,227,208,168,95,64,198,109,10,217,169,13,217,92,76,152,76,152,12,152,112,14,234,112,163,206,196,182,107,153,197,58,9,151,64,4,53,86,199,182,87,107,74,26,197,196,248,28,181,228,23,232,85,229,30,114,209,169,156,157,168,106,77,108,205,217,82,92,59,29,38,243,205,211,250,219,173,88,183,235,157,220,67,194,61,63,153,100,254,39,203,188,176,239,14,153,65,180,58,129,80,37,2,197,26,193,161,39,212,47,18,211,168,201,62,185,204,45,38,138,170,54,160,220,72,203,114,85,56,217,132,96,172,13,161,197,140,221,143,103,131,86,188,103,245,188,80,186,213,226,222,166,14,36,221,66,207,42,113,98,85,188,57,161,204,143,141,122,140,155,160,255,78,115,255,163,64,241,71,87,158,72,85,20,187,202,198,12,18,8,205,55,160,36,170,136,212,196,89,235,59,203,113,80,248,146,124,178,154,135,170,37,7,193,13,213,81,19,3,217,228,232,77,119,45,187,241,165,89,108,108,99,179,30,212,244,106,141,85,84,163,69,244,4,123,229,24,49,135,90,188,156,30,138,67,163,30,7,197,217,223,38,44,30,5,139,175,174,36,114,129,82,42,73,133,25,180,142,9,142,52,121,5,163,238,154,162,207,24,208,185,16,70,177,32,204,217,14,52,105,29,95,33,32,15,213,80,21,96,198,78,189,88,110,245,1,156,195,161,81,143,192,66,213,220,118,117,59,129,241,127,153,47,66,205,154,31,168,105,83,46,195,34,139,1,157,240,5,176,168,190,67,76,216,165,29,5,70,108,104,171,9,74,106,227,97,73,214,119,40,86,199,103,122,11,181,115,163,218,226,40,24,206,231,74,89,213,201,33,14,203,103,234,206,169,8,67,202,226,77,84,223,209,189,155,188,194,95,76,230,95,157,87,96,125,197,138,42,115,46,58,145,26,245,197,104,85,114,45,82,143,190,21,19,112,188,44,178,89,92,196,218,116,8,201,171,204,155,114,82,213,33,59,195,28,196,17,181,194,15,176,243,112,96,212,35,230,127,21,100,93,237,150,219,243,169,56,122,36,56,190,186,13,135,98,99,108,73,235,238,156,53,159,4,163,37,27,22,135,144,201,232,76,222,41,91,227,198,151,85,107,45,137,90,0,147,135,29,139,48,236,235,17,49,144,54,118,46,49,138,161,7,88,86,61,48,234,17,112,252,253,106,64,99,226,98,226,98,191,192,84,171,87,255,217,33,25,212,218,168,83,5,172,90,42,169,199,214,177,120,116,90,249,140,155,134,198,174,84,206,122,10,57,105,26,68,175,105,48,116,192,76,161,38,83,16,195,67,152,134,3,163,30,233,165,105,98,99,98,227,253,86,92,199,26,179,177,90,231,15,139,175,98,89,77,169,206,192,142,35,26,65,81,211,90,198,247,24,2,161,218,159,48,248,23,117,50,90,49,222,108,28,91,51,236,149,181,88,124,199,211,179,113,104,212,47,98,99,122,158,99,66,229,62,139,157,156,205,49,70,72,60,44,134,25,214,52,82,180,136,79,232,26,86,18,245,254,227,207,115,164,162,54,10,91,129,104,156,170,125,216,242,208,19,74,64,24,145,107,247,34,148,79,143,202,161,81,191,192,123,76,185,100,2,228,195,199,201,187,218,216,26,10,160,40,27,161,212,14,108,109,133,92,75,53,34,41,34,141,215,89,166,52,244,169,119,176,156,245,140,40,101,160,142,122,130,84,52,69,21,67,21,31,96,35,239,208,168,95,14,200,148,80,38,94,238,219,227,11,209,161,55,25,162,236,183,48,176,41,57,45,131,177,221,217,192,217,54,30,127,190,35,83,139,41,134,4,57,22,61,163,174,83,59,119,9,192,152,168,22,14,165,217,7,120,64,240,208,168,71,251,245,9,147,9,147,251,44,74,44,216,171,237,208,100,152,159,107,77,192,149,13,112,112,190,91,53,41,20,198,45,74,73,204,21,81,39,120,212,185,61,116,151,180,2,82,185,251,236,140,228,230,20,182,112,122,76,94,126,243,242,201,230,159,191,46,101,125,115,125,46,59,45,54,242,250,66,143,126,114,224,119,93,94,190,67,78,77,29,25,233,201,53,77,161,121,120,12,55,40,106,37,151,30,75,71,98,41,215,175,111,200,248,60,95,63,200,175,103,243,229,47,171,121,149,179,39,237,81,57,242,127,5,142,62,67,2,119,246,214,183,54,56,234,120,227,173,139,4,55,144,20,146,152,70,185,198,163,23,120,187,31,72,64,149,97,176,133,85,29,189,64,165,172,95,49,219,92,198,23,120,109,241,177,149,26,33,167,162,36,48,53,237,128,50,112,210,126,184,135,136,138,210,233,119,63,14,140,122,212,238,183,106,123,74,16,83,130,24,176,32,219,11,90,165,11,131,41,58,105,146,211,255,244,77,25,139,138,133,21,146,113,44,60,218,226,170,24,69,74,84,217,61,91,173,104,20,89,219,132,75,81,165,167,242,0,88,28,26,245,88,44,166,50,106,162,228,134,146,215,215,255,3,138,111,173,133,74,62,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "608044dbcecb4a1fbf9171d57b8a1835",
							"BaseElements.AddDataUserTask1.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("25b0287a-c3a8-4066-b6ef-e5dad7c3be5a");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordDefValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordDefValues", getColumnValue);
					}
					return _recordDefValues;
				}
				set {
					_recordDefValues = value;
				}
			}

			#endregion

		}

		#endregion

		public CreateInvoiceFromOrder(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CreateInvoiceFromOrder";
			SchemaUId = new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835");
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
				return new Guid("608044db-cecb-4a1f-bf91-71d57b8a1835");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: CreateInvoiceFromOrder, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: CreateInvoiceFromOrder, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual Guid CurrentOrder {
			get;
			set;
		}

		public virtual Guid CreatedInvoiceId {
			get;
			set;
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
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
					SchemaElementUId = new Guid("a3117259-5f0d-4df4-bc73-269483d394df"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
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
					SchemaElementUId = new Guid("0b76f581-3e18-4e18-be44-b60d06cfca12"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
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
					SchemaElementUId = new Guid("a003fd82-9248-4113-b40e-b8740d59adfc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
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
					SchemaElementUId = new Guid("5ea2d96f-07ec-414d-94ef-8b09e6207daa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private OpenEditPageUserTask1FlowElement _openEditPageUserTask1;
		public OpenEditPageUserTask1FlowElement OpenEditPageUserTask1 {
			get {
				return _openEditPageUserTask1 ?? (_openEditPageUserTask1 = new OpenEditPageUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _createInvoiceByOrderScriptTask;
		public ProcessScriptTask CreateInvoiceByOrderScriptTask {
			get {
				return _createInvoiceByOrderScriptTask ?? (_createInvoiceByOrderScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CreateInvoiceByOrderScriptTask",
					SchemaElementUId = new Guid("a4dd9327-058c-4700-90d5-2755a7fb610e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = CreateInvoiceByOrderScriptTaskExecute,
				});
			}
		}

		private AddDataUserTask1FlowElement _addDataUserTask1;
		public AddDataUserTask1FlowElement AddDataUserTask1 {
			get {
				return _addDataUserTask1 ?? (_addDataUserTask1 = new AddDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("f46b6e3b-9407-4fbb-996a-46db3398573f"),
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
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[Terminate2.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate2 };
			FlowElements[OpenEditPageUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditPageUserTask1 };
			FlowElements[CreateInvoiceByOrderScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateInvoiceByOrderScriptTask };
			FlowElements[AddDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataUserTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CreateInvoiceByOrderScriptTask", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate2", e.Context.SenderName));
						break;
					case "Terminate2":
						CompleteProcess();
						break;
					case "OpenEditPageUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "CreateInvoiceByOrderScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask1", e.Context.SenderName));
						break;
					case "AddDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpenEditPageUserTask1", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean((CurrentOrder) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalFlow1", "(CurrentOrder) != Guid.Empty", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("CurrentOrder")) {
				writer.WriteValue("CurrentOrder", CurrentOrder, Guid.Empty);
			}
			if (!HasMapping("CreatedInvoiceId")) {
				writer.WriteValue("CreatedInvoiceId", CreatedInvoiceId, Guid.Empty);
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
			MetaPathParameterValues.Add("08117217-b6a2-4caa-87cb-57b42ebbdf81", () => CurrentOrder);
			MetaPathParameterValues.Add("9b6df9ca-b4dc-4748-a446-878f58f9abe8", () => CreatedInvoiceId);
			MetaPathParameterValues.Add("d85118e6-2c1e-4d34-afa5-de5b61c76366", () => OpenEditPageUserTask1.ObjectSchemaId);
			MetaPathParameterValues.Add("91937424-2f71-4f1f-a3b2-d440bd5541d2", () => OpenEditPageUserTask1.PageSchemaId);
			MetaPathParameterValues.Add("2dac85ca-0040-4966-a412-c2232b004d2b", () => OpenEditPageUserTask1.EditMode);
			MetaPathParameterValues.Add("c1fbab13-0fcc-4a08-8a27-9c61b940678a", () => OpenEditPageUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("69857298-5af6-4e7c-8304-9fec7c1d334f", () => OpenEditPageUserTask1.RecordId);
			MetaPathParameterValues.Add("03005092-ebd2-40a5-a4ba-1feda715e4ab", () => OpenEditPageUserTask1.ExecutedMode);
			MetaPathParameterValues.Add("0e17b357-37db-48e3-b5b8-e62e0687bddf", () => OpenEditPageUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("e7f46f88-3a82-4148-a2e2-d7bd427e03a0", () => OpenEditPageUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("2ae3d7cd-e356-43c7-bc44-a3695025a7f9", () => OpenEditPageUserTask1.GenerateDecisionsFromColumn);
			MetaPathParameterValues.Add("9bdca34c-1f63-47aa-a579-fdd93f26eac3", () => OpenEditPageUserTask1.DecisionalColumnMetaPath);
			MetaPathParameterValues.Add("4a705262-6f06-417e-a8c7-f5a2d1f63fe5", () => OpenEditPageUserTask1.ResultParameter);
			MetaPathParameterValues.Add("26151eb5-20dc-466e-972e-c72498300aa7", () => OpenEditPageUserTask1.IsReexecution);
			MetaPathParameterValues.Add("ea935a75-0c11-482c-9e99-d04fc6977707", () => OpenEditPageUserTask1.Recommendation);
			MetaPathParameterValues.Add("a3c2a6f9-b087-4a04-b687-52b26aa4e66b", () => OpenEditPageUserTask1.ActivityCategory);
			MetaPathParameterValues.Add("75d81580-4664-441e-9b0d-0d954ffefc72", () => OpenEditPageUserTask1.OwnerId);
			MetaPathParameterValues.Add("56d9018d-ca95-4d5a-b482-07336f8786cb", () => OpenEditPageUserTask1.Duration);
			MetaPathParameterValues.Add("171f4ae2-f53f-4545-8cec-973f64a4576c", () => OpenEditPageUserTask1.DurationPeriod);
			MetaPathParameterValues.Add("83f5e8fe-aef9-4bc8-b439-e3d3f6f61866", () => OpenEditPageUserTask1.StartIn);
			MetaPathParameterValues.Add("22b00966-521c-4147-b0dd-880c07bb49b4", () => OpenEditPageUserTask1.StartInPeriod);
			MetaPathParameterValues.Add("1076ae54-e8ed-4d6f-8d4d-2e25408bb776", () => OpenEditPageUserTask1.RemindBefore);
			MetaPathParameterValues.Add("390e7e01-63f1-47ee-9272-137e604112f1", () => OpenEditPageUserTask1.RemindBeforePeriod);
			MetaPathParameterValues.Add("3100ca53-bbf6-4ce1-81f5-3a74d220ec16", () => OpenEditPageUserTask1.ShowInScheduler);
			MetaPathParameterValues.Add("1864aa91-6db8-4edf-9528-1e271677b340", () => OpenEditPageUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("d4513854-0edf-4b46-864c-3ec250465806", () => OpenEditPageUserTask1.Lead);
			MetaPathParameterValues.Add("d1a00ae7-ea8e-4faf-9be8-bbb151893c96", () => OpenEditPageUserTask1.Account);
			MetaPathParameterValues.Add("81643ee9-7afe-4461-9cf6-9a97b4c18843", () => OpenEditPageUserTask1.Contact);
			MetaPathParameterValues.Add("7d314b93-7262-4ca5-9f0b-175bcee0be87", () => OpenEditPageUserTask1.Opportunity);
			MetaPathParameterValues.Add("0dcd1985-fcf0-477b-85e3-cc32230b0c60", () => OpenEditPageUserTask1.Invoice);
			MetaPathParameterValues.Add("9d7f3abd-fc1c-4c09-8a0d-793ad6b9a9d1", () => OpenEditPageUserTask1.Document);
			MetaPathParameterValues.Add("28c6ffdb-91ea-49c5-a622-85c4248e047b", () => OpenEditPageUserTask1.Incident);
			MetaPathParameterValues.Add("ca2ee227-e2c2-4921-9f1a-a4c6d06626af", () => OpenEditPageUserTask1.Case);
			MetaPathParameterValues.Add("b0b3b700-462c-4ee9-9ee9-96a4e8025ac3", () => OpenEditPageUserTask1.ActivityResult);
			MetaPathParameterValues.Add("181dd2d4-64b2-43c6-81b6-7da3a77e8d99", () => OpenEditPageUserTask1.CurrentActivityId);
			MetaPathParameterValues.Add("390cf318-8787-4fe8-a591-fd13ce90f619", () => OpenEditPageUserTask1.IsActivityCompleted);
			MetaPathParameterValues.Add("7f8bb765-5d0a-48b2-9e75-386a8ab527be", () => OpenEditPageUserTask1.ExecutionContext);
			MetaPathParameterValues.Add("60f21d76-a090-4c82-84cb-c585656e2ded", () => OpenEditPageUserTask1.PageTypeUId);
			MetaPathParameterValues.Add("88f33366-ebf3-4f29-a163-205a1deb5e34", () => OpenEditPageUserTask1.ActivitySchemaUId);
			MetaPathParameterValues.Add("3dd6fca7-4f4a-40a9-9e3d-f07132784352", () => OpenEditPageUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("278b08b6-9931-4a80-9bec-d1cf8806418e", () => OpenEditPageUserTask1.Order);
			MetaPathParameterValues.Add("94f83067-f3d9-441a-9281-b941faa79cfe", () => OpenEditPageUserTask1.Requests);
			MetaPathParameterValues.Add("ea59ddce-2ba7-40ed-aa25-704516701ef4", () => OpenEditPageUserTask1.Listing);
			MetaPathParameterValues.Add("fcc06da5-e8f1-46c5-b82b-cc2bad57d865", () => OpenEditPageUserTask1.Property);
			MetaPathParameterValues.Add("ffd60755-0701-4d4a-839e-d42c73b329d1", () => OpenEditPageUserTask1.Contract);
			MetaPathParameterValues.Add("c4615610-2142-459f-939a-22b2b835c4e6", () => OpenEditPageUserTask1.Problem);
			MetaPathParameterValues.Add("5bd2622b-1a31-47db-9cc6-ef0f1d28d691", () => OpenEditPageUserTask1.Change);
			MetaPathParameterValues.Add("6eb2abed-f54f-4366-b8c5-7433e0d5803b", () => OpenEditPageUserTask1.Release);
			MetaPathParameterValues.Add("f7032715-9611-4c85-ba14-fd6be7ecb408", () => OpenEditPageUserTask1.Project);
			MetaPathParameterValues.Add("e6c68d49-3a67-4c77-af1f-5ebc245cef08", () => AddDataUserTask1.EntitySchemaId);
			MetaPathParameterValues.Add("f0e3fb86-16b6-43cd-bf28-e690dfa14675", () => AddDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("21a0db48-c769-44b9-bca9-1e4a8e5d8196", () => AddDataUserTask1.RecordAddMode);
			MetaPathParameterValues.Add("98e598ab-767c-4f41-b9d0-7f528e24771c", () => AddDataUserTask1.FilterEntitySchemaId);
			MetaPathParameterValues.Add("9aee3d4d-32c8-472c-b908-f40aee815e2b", () => AddDataUserTask1.RecordDefValues);
			MetaPathParameterValues.Add("79d72c86-b946-4e74-b82c-577c9d0709aa", () => AddDataUserTask1.RecordId);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "CurrentOrder":
					if (!hasValueToRead) break;
					CurrentOrder = reader.GetValue<System.Guid>();
				break;
				case "CreatedInvoiceId":
					if (!hasValueToRead) break;
					CreatedInvoiceId = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool CreateInvoiceByOrderScriptTaskExecute(ProcessExecutingContext context) {
			CreateInvoice();
			return true;
		}

			
			public virtual void CreateInvoice() {
				OrderInvoiceHelper helper = Factories.ClassFactory.Get<OrderInvoiceHelper>(new Factories.ConstructorArgument("userConnection", UserConnection));
			CreatedInvoiceId = helper.CreateEntity("Order", "Invoice", CurrentOrder, new Dictionary<string, string> {
				{"Currency", "Currency"},
				{"CurrencyRate", "CurrencyRate"},
				{"Contact", "Contact"},
				{"Account", "Account"},
				{"Owner", "Owner"},
				{"Amount", "Amount"},
				{"Opportunity", "Opportunity"}
			}, new Dictionary<string, object> { { "Order", CurrentOrder } });
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
			var cloneItem = (CreateInvoiceFromOrder)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

