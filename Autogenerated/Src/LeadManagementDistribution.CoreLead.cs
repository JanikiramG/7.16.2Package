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

	#region Class: LeadManagementDistributionSchema

	/// <exclude/>
	public class LeadManagementDistributionSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LeadManagementDistributionSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LeadManagementDistributionSchema(LeadManagementDistributionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LeadManagementDistribution";
			UId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe");
			CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.15.4.3055";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"LeadManagementDistribution";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe");
			Version = 0;
			PackageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateLeadIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("30cf6943-a881-4c30-a088-ff65572e4241"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"LeadId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCreateReminderParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9cd3f863-0eda-4338-895e-97f82adfe406"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"CreateReminder",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{3e566048-ef49-45bf-9d2d-500669220b4e}].[Parameter:{cd5eefc4-6c19-4719-be10-6babbc9acc6e}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateResponsibleIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("77bfc541-1a1a-4b5e-bd77-3e429c4b637f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"ResponsibleId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{3e566048-ef49-45bf-9d2d-500669220b4e}].[Parameter:{0d01d7bb-ccf9-4184-a64f-953b68988ea4}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateShowDistributionPageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("51139bfa-4db4-45f7-aa2f-590d604f8469"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"ShowDistributionPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateLeadIdParameter());
			Parameters.Add(CreateCreateReminderParameter());
			Parameters.Add(CreateResponsibleIdParameter());
			Parameters.Add(CreateShowDistributionPageParameter());
		}

		protected virtual void InitializeSaveLeadHandoffParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("188fdd38-de95-4c10-8ab3-34128e7e82c9"),
				ContainerUId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9cad839f-9e67-4603-a369-f4c25fce8216"),
				ContainerUId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"IsMatchConditions",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMatchConditionsParameter.SourceValue = new ProcessSchemaParameterValue(isMatchConditionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("51b908e1-277f-4fd9-954b-c200b506502f"),
				ContainerUId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,79,107,220,48,16,197,191,139,14,61,89,69,182,198,178,236,30,151,109,89,40,105,160,105,41,36,75,24,75,163,172,192,127,54,182,76,19,204,126,247,202,235,108,10,57,148,210,91,193,135,209,216,239,167,55,143,241,124,239,199,143,190,9,52,84,14,155,145,146,105,103,43,38,108,86,103,136,192,51,5,5,7,43,5,199,210,104,14,160,92,46,108,129,194,32,75,58,108,169,98,171,122,107,125,96,137,15,212,142,213,237,252,27,26,134,137,146,123,119,62,124,53,7,106,241,219,114,1,164,232,116,73,37,47,114,81,115,160,186,230,218,160,225,206,201,178,86,160,33,37,195,86,47,168,4,101,26,136,231,18,4,135,28,11,94,103,96,121,90,80,14,153,148,145,3,44,105,200,133,237,211,113,160,113,244,125,87,205,244,90,223,60,31,163,203,245,238,77,223,76,109,199,146,150,2,94,99,56,68,58,9,130,220,32,55,80,230,28,28,21,28,101,105,185,196,186,200,10,77,169,74,11,150,24,60,134,5,203,118,150,37,22,3,126,199,102,162,51,121,246,209,99,38,69,170,115,21,181,169,52,28,100,38,184,86,186,224,206,42,87,146,84,101,89,219,75,94,159,38,31,107,63,94,77,45,13,222,188,196,78,49,191,126,168,102,211,119,97,232,155,5,125,117,254,252,134,158,194,26,238,203,171,31,235,64,33,246,23,17,59,37,211,72,155,198,83,23,182,157,233,173,239,30,86,230,233,20,37,237,17,7,63,94,82,216,62,78,216,176,100,240,15,135,63,166,181,153,198,208,183,255,209,168,73,28,51,50,226,146,157,237,46,59,104,253,120,108,240,249,124,174,216,187,199,169,15,31,62,19,218,181,98,111,20,21,187,99,82,24,167,74,144,28,181,78,57,152,101,235,133,214,113,41,85,158,23,25,65,6,233,29,139,46,254,129,125,187,27,191,252,236,46,255,192,234,122,255,62,118,223,52,174,47,202,106,254,27,59,167,253,98,104,127,138,207,47,177,221,110,55,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e91b04af-7a52-4f54-a02b-32ac50a9f8ad"),
				ContainerUId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"RecordColumnValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,150,77,111,27,71,12,134,255,138,176,201,209,20,230,251,67,215,164,64,13,36,109,80,39,185,196,62,112,102,200,70,168,164,53,118,215,41,82,67,255,189,212,218,110,236,160,177,141,22,69,83,164,123,24,73,179,122,201,153,33,31,114,46,187,167,211,199,115,234,86,221,107,26,6,28,123,158,150,207,250,129,150,175,134,190,210,56,46,95,244,21,55,235,223,176,108,232,21,14,184,165,137,134,183,184,185,160,241,197,122,156,142,22,119,101,221,81,247,244,195,252,182,91,189,187,236,142,39,218,190,57,110,98,157,76,37,23,98,3,167,20,203,96,51,160,81,25,50,230,16,116,114,78,153,34,226,218,111,46,182,187,151,52,225,43,156,222,119,171,203,110,182,38,6,74,85,213,180,160,192,163,21,43,201,41,64,116,4,53,40,194,24,3,25,21,186,253,81,55,214,247,180,197,217,233,39,177,211,200,41,83,134,232,85,1,71,165,64,170,88,129,217,230,18,196,152,166,122,16,95,255,255,147,240,221,147,23,125,255,203,197,249,210,24,235,116,109,26,124,177,22,92,21,247,89,105,13,129,99,200,150,56,144,115,203,74,37,170,98,43,228,228,101,147,41,68,64,138,21,82,226,220,90,212,42,164,244,228,236,224,168,173,199,243,13,126,124,251,69,127,39,19,254,76,203,239,113,215,122,230,197,212,47,70,220,208,120,37,62,191,19,135,219,242,203,211,171,112,158,118,171,211,47,5,244,250,243,100,62,167,187,33,253,60,154,167,221,209,105,119,210,95,12,245,96,209,30,126,220,156,238,236,65,93,63,240,39,195,205,115,101,99,150,189,196,157,108,106,248,65,60,206,242,249,213,115,156,112,118,254,90,214,125,99,184,152,236,85,212,12,145,48,75,188,130,129,212,52,66,214,185,176,141,214,48,155,89,253,19,49,13,180,171,116,119,97,143,137,214,172,159,61,127,90,204,77,226,201,204,238,98,179,153,29,140,243,254,15,153,124,189,240,235,55,207,111,133,240,150,133,190,173,121,77,237,120,247,87,142,106,223,237,247,71,183,177,81,149,124,45,146,240,137,157,100,84,213,22,82,44,26,34,150,172,98,76,84,8,239,197,198,155,164,163,117,73,180,74,11,119,218,3,198,16,160,22,173,106,44,222,187,154,254,9,108,222,29,143,63,254,186,163,225,234,20,86,140,155,145,206,150,50,251,217,196,31,9,184,186,140,177,112,245,78,131,70,9,181,43,158,160,180,24,193,146,51,185,186,18,108,228,253,217,67,252,204,94,255,231,228,113,156,232,80,200,6,175,37,189,200,128,211,62,139,190,73,101,77,202,54,23,146,109,205,254,39,56,177,41,59,149,147,146,82,171,36,119,52,23,40,33,105,144,204,119,14,89,185,200,250,94,78,76,204,76,150,20,196,92,21,56,22,83,5,165,83,177,15,141,141,243,236,114,253,74,56,201,181,89,78,193,130,162,38,123,181,54,65,202,2,75,142,156,12,54,38,167,194,195,156,60,27,8,39,90,12,180,93,239,26,13,11,238,135,69,255,45,177,147,85,9,190,112,2,197,92,37,101,164,240,164,24,51,24,103,148,124,65,150,2,123,31,59,143,94,216,215,206,78,242,37,73,226,34,112,150,250,225,188,52,203,100,117,1,163,91,82,202,59,211,178,187,151,29,116,10,131,99,4,148,171,152,244,24,10,144,93,12,128,62,87,221,184,148,108,249,223,100,231,187,13,109,105,55,173,46,45,249,16,148,52,67,18,156,101,167,133,33,55,211,192,43,21,66,54,70,21,71,251,187,176,37,99,162,52,76,2,10,81,110,18,10,53,160,101,43,135,163,12,177,151,212,136,248,48,108,18,199,105,88,151,139,105,221,239,22,231,135,155,221,201,225,58,183,104,235,15,235,81,230,190,21,230,254,110,191,242,45,57,31,138,3,237,165,84,187,70,30,138,146,1,89,174,51,28,98,246,245,171,101,238,108,255,59,129,78,83,81,108,13,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeSaveLeadNoInterestParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("a147d2f0-eb4f-4a91-bda3-6b4d5423014b"),
				ContainerUId = new Guid("7969b2cd-51e0-490c-b289-63e0473f9af3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d71bf98b-10c9-4b4e-9da3-927f4c707df2"),
				ContainerUId = new Guid("7969b2cd-51e0-490c-b289-63e0473f9af3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"IsMatchConditions",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMatchConditionsParameter.SourceValue = new ProcessSchemaParameterValue(isMatchConditionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8b04704d-b57f-4aed-8143-0ba2dc774953"),
				ContainerUId = new Guid("7969b2cd-51e0-490c-b289-63e0473f9af3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,36,21,203,146,245,225,30,151,109,89,40,105,160,105,41,36,75,144,165,81,86,224,143,141,37,211,4,179,255,189,242,58,155,66,14,165,244,86,208,97,52,154,247,230,205,99,52,223,135,248,49,180,9,198,218,155,54,2,158,118,174,70,69,229,20,48,197,8,5,230,9,23,162,36,186,162,21,113,86,73,203,37,99,32,27,132,123,211,65,141,86,244,214,133,132,112,72,208,197,250,118,254,77,154,198,9,240,189,63,95,190,218,3,116,230,219,210,128,83,227,149,6,77,100,85,52,132,67,211,16,101,141,37,222,51,221,8,174,56,5,139,86,45,76,23,66,230,90,82,22,174,36,220,8,75,180,84,146,72,224,180,148,90,59,90,50,132,91,240,105,251,116,28,33,198,48,244,245,12,175,241,205,243,49,171,92,123,111,134,118,234,122,132,59,72,230,218,164,67,141,12,20,192,43,107,136,229,186,34,220,131,36,134,105,71,152,105,100,41,21,80,65,37,194,214,28,211,66,139,118,14,97,103,146,249,110,218,9,206,204,115,200,26,75,86,80,85,137,140,165,204,18,206,202,130,40,145,53,122,39,188,6,38,180,110,220,197,175,79,83,200,113,136,87,83,7,99,176,47,182,67,246,111,24,235,217,14,125,26,135,118,161,190,58,151,223,192,83,90,205,125,121,250,177,14,148,114,126,1,161,19,158,34,108,218,0,125,218,246,118,112,161,127,88,57,79,167,12,233,142,102,12,241,226,194,246,113,50,45,194,99,120,56,252,209,173,205,20,211,208,253,71,163,226,60,102,230,200,75,118,150,187,236,160,11,241,216,154,231,243,189,70,239,30,167,33,125,248,12,198,173,17,122,131,168,209,29,98,133,245,66,115,70,140,82,148,112,203,10,98,10,165,242,82,138,170,146,37,240,146,211,59,148,85,252,3,247,237,46,126,249,217,95,254,192,170,122,255,62,103,223,36,174,47,200,122,254,27,57,167,253,34,104,127,202,231,23,171,70,92,220,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("63cb5219-81b3-4e2c-8f12-bb56e164296d"),
				ContainerUId = new Guid("7969b2cd-51e0-490c-b289-63e0473f9af3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"RecordColumnValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,87,75,111,219,72,12,254,43,134,218,99,104,204,251,225,107,187,135,0,105,54,104,186,189,36,57,112,102,56,91,97,109,43,144,228,46,186,134,255,251,210,74,210,36,197,54,27,164,40,208,160,213,65,150,71,243,145,20,201,143,228,108,155,151,227,167,75,106,22,205,59,234,123,28,186,58,206,95,117,61,205,79,250,46,211,48,204,143,186,140,203,246,31,76,75,58,193,30,87,52,82,255,30,151,27,26,142,218,97,60,152,221,135,53,7,205,203,143,211,219,102,113,182,109,14,71,90,253,113,88,88,122,173,33,71,99,60,100,83,10,24,180,17,162,211,4,34,145,64,172,168,209,238,193,185,91,110,86,235,55,52,226,9,142,31,154,197,182,153,164,177,128,148,69,86,197,9,176,168,89,64,48,2,16,13,65,118,130,208,123,71,74,184,102,119,208,12,249,3,173,112,82,122,11,54,18,107,136,20,193,91,145,192,80,74,16,50,102,168,85,199,228,88,152,164,188,7,95,239,191,5,158,189,56,234,186,191,54,151,115,165,180,145,185,72,176,73,107,48,153,213,71,33,37,184,234,93,212,84,29,25,51,183,18,75,214,148,65,91,193,155,146,100,27,5,43,12,137,116,18,36,101,21,225,197,197,94,81,105,135,203,37,126,122,255,85,125,167,35,254,73,243,227,110,156,181,107,246,56,13,35,149,43,232,229,189,40,220,5,111,207,175,130,121,222,44,206,191,22,206,235,223,211,201,75,247,3,250,101,44,207,155,131,243,230,180,219,244,121,47,81,239,255,220,248,118,210,32,174,47,248,143,219,205,117,37,99,130,189,193,53,127,82,127,204,26,39,248,244,234,53,142,56,41,127,199,118,223,8,78,42,90,225,101,5,79,24,57,90,78,65,40,18,33,202,152,170,246,90,213,170,38,244,91,170,236,154,117,166,251,134,61,38,86,19,126,210,124,107,204,77,218,241,202,122,179,92,78,10,134,233,251,247,121,124,109,248,245,155,215,119,2,120,71,66,87,218,218,82,57,92,63,197,85,187,102,183,59,184,75,154,80,60,69,89,45,88,229,16,76,148,9,146,146,25,172,214,58,83,80,74,73,251,32,105,98,82,62,102,239,64,40,201,158,168,86,2,230,226,64,71,237,72,10,23,83,49,223,147,52,165,202,156,131,3,167,124,6,83,248,134,133,227,42,10,5,162,132,201,136,60,175,62,8,231,138,6,244,92,15,12,241,246,148,98,4,50,222,215,156,162,73,234,177,164,57,38,42,51,102,206,184,25,126,81,231,105,212,121,68,196,158,5,117,172,71,25,92,214,16,226,62,121,163,225,15,49,194,3,114,73,16,62,106,75,74,61,72,29,171,130,244,218,4,174,31,66,130,17,210,114,130,58,7,153,171,122,246,201,90,147,195,247,160,206,217,225,240,251,223,107,234,175,188,176,168,184,28,232,98,206,171,95,44,252,182,164,21,173,199,197,86,147,117,78,176,161,84,13,135,220,166,10,177,168,2,86,48,173,162,82,34,25,218,49,224,115,198,46,182,54,232,44,208,23,136,84,24,194,38,77,9,2,53,185,204,205,184,74,85,203,238,226,255,72,199,113,28,251,54,109,198,182,91,207,46,247,237,106,50,252,23,213,30,71,53,233,120,42,112,92,145,67,37,5,70,242,68,20,74,225,137,33,8,93,140,11,186,20,253,44,168,166,188,241,66,87,9,146,60,59,66,160,134,88,67,225,201,140,164,138,38,96,160,240,32,213,184,71,85,210,36,128,123,149,224,46,21,4,36,20,21,170,117,165,42,99,57,175,243,115,165,90,46,150,168,102,3,46,75,134,120,190,37,238,188,224,184,150,166,28,49,179,151,158,66,181,183,180,106,215,133,250,89,237,250,89,247,51,241,142,235,185,99,207,7,16,181,114,139,146,134,25,228,57,241,148,81,130,31,176,70,225,31,226,221,163,13,251,209,121,199,7,39,37,108,65,176,206,240,116,24,40,65,100,42,130,180,232,115,48,158,207,27,254,65,222,113,67,68,103,42,242,33,133,88,128,32,110,3,134,135,69,62,156,101,89,42,79,97,186,62,87,222,241,112,236,185,95,19,144,243,122,95,148,120,242,213,85,131,146,66,81,181,156,26,30,159,194,187,83,92,210,48,43,237,199,118,224,181,159,133,115,223,218,235,108,9,198,186,100,56,55,185,204,155,66,22,248,60,204,19,85,229,105,170,58,31,109,254,97,57,119,177,251,23,86,136,208,208,36,17,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeAddReminderParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("55dd5f60-cee9-44b6-8f68-b543a4174bf2"),
				ContainerUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
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
				Value = @"ae7a5bc6-115f-4ed2-97c5-13f5c5142c37",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7a3aa063-9af4-482e-adbf-9312dad8b0bf"),
				ContainerUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2e6f433c-09c2-46dc-89d2-80e6a8f6ebda"),
				ContainerUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("ddff7e72-873c-4e34-a274-b1fe98dc4dc5"),
				ContainerUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("95dfe792-7d3e-4db6-8add-2effff3ca7f4"),
				ContainerUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,89,223,79,27,71,16,254,87,78,151,60,180,18,107,237,239,31,188,85,73,90,33,37,41,10,105,94,48,15,179,187,51,193,170,241,33,251,156,136,34,254,247,206,29,208,0,77,13,141,136,148,4,252,96,236,243,205,236,238,204,124,223,124,115,156,182,79,251,147,99,108,183,219,183,184,92,194,170,163,126,242,172,91,226,100,119,217,21,92,173,38,47,187,2,243,217,95,144,231,184,11,75,56,194,30,151,239,96,190,198,213,203,217,170,223,106,174,155,181,91,237,211,15,227,175,237,246,254,105,187,211,227,209,31,59,149,189,151,72,57,67,149,2,193,105,97,43,89,145,99,208,34,23,5,214,162,82,50,39,54,46,221,124,125,180,120,133,61,236,66,127,216,110,159,182,163,55,118,128,158,144,130,245,130,192,37,97,165,68,17,131,231,79,214,6,99,179,2,45,77,123,182,213,174,202,33,30,193,184,232,39,99,192,0,46,23,47,148,114,36,44,86,45,82,40,78,40,67,174,56,101,117,49,97,48,190,184,255,147,225,2,63,54,191,173,103,245,167,105,107,21,80,76,152,68,112,50,179,143,156,69,44,80,4,145,73,217,219,104,21,150,105,251,243,224,166,206,86,199,115,56,121,119,63,222,142,175,133,253,170,191,211,233,121,246,166,237,246,244,191,242,119,241,119,111,12,203,245,12,222,76,222,180,221,154,182,123,221,122,89,6,143,102,248,114,25,204,113,5,121,241,18,159,121,187,124,157,251,24,205,94,193,2,222,227,242,53,175,56,154,143,63,61,135,30,198,197,223,242,190,47,29,103,157,156,12,138,68,64,224,140,162,215,34,86,5,34,169,148,201,4,163,137,244,104,253,6,9,151,184,40,120,125,99,160,171,149,1,148,40,21,172,176,198,90,1,37,40,17,35,88,212,153,82,209,113,180,31,87,254,180,153,203,58,227,43,139,245,124,62,46,176,26,207,63,20,238,197,198,47,126,121,126,37,167,87,60,116,117,70,51,172,59,139,47,9,213,89,123,118,182,117,21,37,58,27,87,65,21,97,50,113,85,128,13,34,65,168,194,122,155,44,101,210,25,220,70,148,88,169,172,81,165,10,85,7,152,89,149,4,40,82,34,120,31,192,56,107,171,46,247,143,146,253,39,251,59,171,223,63,46,112,121,30,133,109,130,249,10,15,38,124,245,198,133,127,10,112,251,52,132,76,197,89,37,20,112,170,109,118,40,114,13,65,24,180,58,21,155,189,9,116,118,240,228,96,19,160,246,159,140,171,158,223,244,136,147,219,112,162,124,70,227,29,3,131,144,171,67,49,145,198,202,156,12,81,154,106,125,52,181,154,239,2,39,57,64,206,49,27,33,29,223,108,97,12,132,206,34,88,155,53,6,79,30,55,227,68,58,149,172,161,202,61,36,69,102,12,28,58,145,53,162,80,14,146,178,213,81,218,111,4,39,70,22,242,188,89,206,82,84,194,22,195,249,146,49,114,167,240,206,5,205,104,177,234,118,156,188,68,168,15,5,38,218,72,21,157,15,76,125,166,112,114,181,20,209,199,32,168,122,74,12,128,148,114,221,4,147,59,111,236,91,135,137,178,64,37,235,32,170,83,134,97,162,184,202,101,36,174,86,50,202,4,105,52,250,141,48,41,24,40,5,25,133,43,153,187,144,81,94,100,48,76,61,201,163,49,42,57,163,191,10,76,246,78,86,239,96,57,27,68,231,228,217,122,201,57,234,57,211,248,118,118,132,183,21,58,155,242,249,155,15,55,204,155,202,246,13,44,106,211,179,147,102,188,255,161,224,161,106,133,9,89,113,23,233,89,30,201,161,12,116,28,148,180,130,168,130,98,209,100,31,4,30,130,196,152,125,32,225,205,80,145,217,123,145,80,6,161,137,27,42,73,158,44,178,218,136,7,32,84,220,29,130,192,164,152,139,181,97,60,132,26,132,179,185,58,23,131,74,241,43,12,33,204,222,93,247,231,250,120,82,75,201,152,163,19,142,219,159,176,60,63,136,68,132,44,246,0,160,100,78,103,117,19,240,190,202,136,74,104,212,85,160,228,141,66,145,192,177,81,206,85,57,208,161,187,181,91,156,175,247,186,235,57,252,5,250,89,183,104,206,51,55,249,101,221,31,118,143,138,235,142,138,235,46,25,251,46,160,147,75,246,42,73,174,219,52,28,36,241,156,149,130,179,34,152,144,107,73,9,157,221,60,191,83,148,53,169,192,74,159,18,191,121,21,68,246,12,29,32,34,200,42,167,234,194,253,67,103,175,95,206,22,239,185,134,22,92,197,60,118,191,70,172,13,199,167,185,187,20,123,49,199,35,110,32,219,167,88,48,26,159,61,119,211,202,181,48,12,88,192,172,33,146,1,86,207,153,39,80,103,207,174,107,183,234,164,15,74,51,75,40,93,6,230,101,193,105,74,17,206,212,40,65,27,173,93,24,76,94,44,250,89,127,242,108,12,30,79,70,198,179,202,131,192,124,141,108,69,92,121,89,26,43,180,115,60,32,114,229,121,99,6,197,183,197,39,105,58,106,250,67,108,74,183,232,161,244,95,122,182,148,29,5,91,73,112,124,2,7,152,153,131,133,52,31,213,107,19,93,74,54,36,186,113,54,206,91,208,58,41,102,64,139,92,218,172,75,163,49,70,56,15,85,89,137,30,67,249,247,217,192,149,2,33,241,244,17,42,43,10,29,129,173,120,214,117,37,233,92,43,43,19,138,227,217,248,104,31,97,213,28,15,36,129,149,179,214,119,205,33,247,239,142,232,150,167,44,27,114,254,134,85,112,179,24,190,15,228,52,249,117,182,92,245,205,108,208,11,28,198,37,174,214,243,158,77,57,152,243,57,150,129,245,38,3,212,54,69,122,244,56,31,222,46,174,255,15,167,183,31,241,199,39,88,87,128,123,177,226,153,70,201,97,186,25,84,123,242,32,12,15,163,224,129,160,80,121,16,218,196,122,19,201,48,173,186,100,24,129,22,228,192,46,158,27,15,211,38,19,101,100,236,111,36,216,64,182,56,76,3,173,166,225,217,81,28,250,126,144,130,129,109,170,102,202,200,234,43,104,147,207,129,237,145,95,191,3,126,109,238,151,96,239,135,95,239,143,91,239,112,188,31,159,92,107,205,6,20,162,144,1,35,35,138,213,107,14,92,237,149,171,71,197,44,37,61,144,7,33,46,75,23,19,48,169,209,56,1,91,47,192,50,246,193,59,144,137,53,186,182,176,249,191,79,24,76,204,60,238,57,21,25,91,186,132,115,29,207,92,157,13,207,7,86,82,189,127,114,157,182,195,99,187,105,187,9,140,87,239,121,172,232,31,185,162,15,206,254,6,144,158,85,23,173,29,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2af26cad-fdd2-4138-9712-bb3c00009344"),
				ContainerUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
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

		protected virtual void InitializeReadLeadDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("88b815f6-9ed2-474a-a40e-f96b169054b4"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,36,21,203,146,109,201,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,63,54,150,76,19,204,254,247,202,235,108,10,57,148,210,91,65,135,153,145,222,155,55,143,209,124,239,195,71,223,70,28,107,7,109,64,58,237,108,77,20,22,141,43,13,103,121,213,20,76,54,220,50,205,65,50,107,108,137,185,203,27,173,36,161,61,116,88,147,21,189,181,62,18,234,35,118,161,190,157,127,147,198,113,66,122,239,206,201,87,115,192,14,190,45,13,36,7,167,52,106,86,21,89,195,36,54,13,83,6,12,115,78,232,166,148,74,114,52,100,213,98,11,157,73,173,145,85,198,85,76,106,80,76,59,37,24,20,38,19,194,102,80,112,78,104,139,46,110,159,142,35,134,224,135,190,158,241,53,190,121,62,38,149,107,239,205,208,78,93,79,104,135,17,174,33,30,106,2,152,161,44,12,48,35,117,154,212,97,197,64,104,203,4,52,85,94,41,228,37,175,8,53,112,140,11,45,217,89,66,45,68,248,14,237,132,103,230,217,39,141,185,200,184,42,202,132,229,194,48,41,242,140,169,82,85,204,217,210,105,20,165,214,141,189,248,245,105,242,41,246,225,106,234,112,244,230,197,118,76,254,13,99,61,155,161,143,227,208,46,212,87,231,231,55,248,20,87,115,95,174,126,172,3,197,84,95,64,228,68,167,128,155,214,99,31,183,189,25,172,239,31,86,206,211,41,65,186,35,140,62,92,92,216,62,78,208,18,58,250,135,195,31,221,218,76,33,14,221,127,52,42,77,99,38,142,180,100,103,185,203,14,90,31,142,45,60,159,243,154,188,123,156,134,248,225,51,130,93,35,242,6,81,147,59,34,50,227,74,45,211,106,41,197,153,52,34,99,144,41,149,150,178,44,138,42,71,153,75,126,71,146,138,127,224,190,221,133,47,63,251,203,31,88,85,239,223,167,234,155,194,245,5,89,207,127,35,231,180,95,4,237,79,233,252,2,246,133,21,47,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7c774b4b-6e9a-4ef1-bd4d-4af18e1f5a68"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
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
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4a5fff69-b63a-49e0-a7c9-da42ff12623b"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
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
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1b730802-2250-4ca2-84c5-b50b5d4a07fb"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
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
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("be3ad5ec-1ac1-4d88-8421-74079d80259b"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
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
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("19076150-3efa-4513-be4e-b624b7233322"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
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
				UId = new Guid("9adb2ee5-70ec-4c6c-b1ab-4cb1ddf4c59b"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,73,77,76,241,75,204,77,181,50,180,50,212,241,1,114,66,42,11,82,227,193,34,6,86,6,58,129,165,137,57,153,105,153,169,41,206,249,121,37,137,201,37,8,25,207,20,16,5,0,82,99,140,34,63,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("81e8d9be-76bf-41e2-a013-9bfb7a60bbf7"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
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
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0a4b4eb8-5619-4c19-a817-49e7435ddac0"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
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
				UId = new Guid("18ee65b6-9004-44b1-b810-660c4b69eb54"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
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
				UId = new Guid("2ba36ea2-087d-4183-8f2e-029d86d94b6b"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
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
				UId = new Guid("39c22bae-af9c-474a-8c12-e087a1cc5bcc"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
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
				UId = new Guid("befd9ddf-c017-4e87-bf55-98e25f140075"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
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
				UId = new Guid("2fd8069c-26a9-41c0-9022-20c047525340"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
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
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("b92dc5ab-c714-451b-b938-04990fc76593"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
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
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("904a1de6-b8cd-43d7-a193-0a8234806d6f"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
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
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("addb84e6-59ea-4d30-acaf-3f26b8c94365"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
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
				UId = new Guid("85876f5f-4440-4fe1-bca9-78939b0740ff"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
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
				UId = new Guid("cf464302-caaf-4d4f-b723-4fe3c28b0aeb"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
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

		protected virtual void InitializeReadLeadTypeParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ca3d3049-0f26-41a3-bca2-dd669a7d3396"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,193,106,220,48,16,134,95,101,209,161,39,107,145,45,89,146,221,99,216,148,92,210,208,166,165,144,132,32,75,163,68,32,219,27,91,166,9,102,223,189,227,117,182,133,28,74,78,133,130,17,146,172,255,159,153,79,163,249,62,140,231,33,38,24,106,111,226,8,217,116,225,106,98,185,168,84,99,24,149,185,6,42,44,115,212,232,210,81,85,152,188,210,80,50,239,4,201,58,211,66,77,86,245,206,133,68,178,144,160,29,235,155,249,143,105,26,38,200,238,253,113,241,213,62,66,107,190,45,1,128,185,6,154,162,160,162,226,56,0,0,6,240,5,53,133,80,166,244,22,180,214,100,205,133,131,42,133,102,130,10,15,56,228,92,208,170,241,150,230,130,57,193,29,175,140,50,36,139,224,211,238,121,63,192,56,134,190,171,103,248,61,191,126,217,99,150,107,236,179,62,78,109,71,178,22,146,185,50,233,177,38,6,24,136,210,26,106,69,85,46,33,20,53,188,114,148,155,70,21,74,67,46,115,69,50,107,246,105,177,37,23,142,100,206,36,243,221,196,9,142,206,115,192,28,11,206,114,93,74,212,230,220,82,193,11,70,181,212,138,122,39,125,5,92,86,85,227,78,188,62,77,1,231,97,188,156,90,24,130,125,197,14,200,175,31,234,217,246,93,26,250,184,88,95,30,143,95,195,115,90,225,190,254,250,177,22,148,112,127,17,145,67,54,141,112,22,3,116,105,215,217,222,133,238,97,245,60,28,80,210,238,205,16,198,19,133,221,211,100,34,201,134,240,240,248,87,90,103,211,152,250,246,63,42,53,195,50,209,3,155,236,152,238,210,131,46,140,251,104,94,142,235,154,124,120,154,250,244,241,11,24,183,137,56,108,207,195,48,166,205,210,175,155,222,111,176,248,41,38,180,219,216,62,70,176,203,101,111,47,1,220,38,97,6,171,150,188,137,81,147,91,98,125,46,177,121,75,170,75,235,241,157,32,145,74,48,75,161,129,162,204,189,173,114,197,182,58,7,237,170,6,168,146,13,30,202,1,219,156,229,124,233,226,70,25,201,154,198,171,109,105,101,37,21,118,185,44,64,83,81,50,142,88,241,56,56,41,45,119,78,114,87,222,18,36,240,79,234,186,185,24,63,255,236,78,47,118,101,124,183,197,221,55,27,187,8,45,94,6,222,229,59,64,28,80,112,117,10,85,207,239,193,178,72,118,93,10,233,101,125,185,245,252,30,78,135,187,133,212,221,1,191,95,243,2,190,158,223,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9bb7fdf0-23d9-4a53-9bfc-b65d5b2b58ef"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
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
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1fc1bf95-66f6-437e-ae96-ab0226deef9f"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
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
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b6eaed28-95a3-4e02-bc92-584da91d9666"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
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
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8af81470-64e6-4c25-bc4e-996386dd37c1"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
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
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("876c91d3-f5fd-430b-99a7-6da066af2251"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
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
				UId = new Guid("a511d00e-3b57-438c-ad43-a0b965ac41ff"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
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
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888"),
				UId = new Guid("d5067126-b12c-401d-83cc-53d80a232257"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
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
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c25ddf34-5ec7-43ef-9f1b-1f022d5afa06"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
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
				UId = new Guid("39e87f5c-2965-45a4-8ce7-4446e1173001"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
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
				UId = new Guid("3aec9151-bb18-4f05-9f98-6ef24b8eb8fa"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
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
				UId = new Guid("8319a4e6-2ecb-470d-b2fd-9af8514e9ab2"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
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
				UId = new Guid("0e55a545-db7b-429c-8850-c3c910df6b27"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
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
				UId = new Guid("d246ad4e-36de-4230-bc79-a36f43b1befe"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
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
				ReferenceSchemaUId = new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888"),
				UId = new Guid("7ad11547-1b9b-4507-b7ff-0d224aa61262"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
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
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5bfef119-7795-4c1c-8d01-0d38138f2a41"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
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
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3e1d582a-dce9-475f-9eed-bc65b2d11830"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
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
				UId = new Guid("13ef4b43-d4fe-40b3-833c-6cfe1c96e0f4"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
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
				UId = new Guid("35b7b87e-d9bf-4617-b784-27beef5fa487"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
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

		protected virtual void InitializeReadLeadContactParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fe828bdd-0b5b-4b21-8d0d-7fe8bbb6c978"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,75,107,220,48,16,199,191,202,162,67,79,214,98,89,15,203,238,49,108,74,46,105,250,164,144,132,160,199,40,17,248,177,177,101,154,96,246,187,119,188,206,182,144,67,201,169,80,108,140,36,107,254,51,255,159,70,243,93,28,207,99,147,96,168,131,105,70,200,166,11,95,19,163,152,224,70,148,52,247,86,83,33,100,160,182,16,57,45,116,176,202,230,58,84,220,145,172,51,45,212,100,141,222,249,152,72,22,19,180,99,125,61,255,17,77,195,4,217,93,56,78,190,184,7,104,205,183,37,1,83,22,184,146,140,234,0,5,21,76,86,84,123,159,83,163,115,238,133,210,220,123,78,214,90,100,48,10,10,93,82,172,201,80,1,86,210,74,107,65,165,51,165,198,71,178,178,32,89,3,33,237,158,246,3,140,99,236,187,122,134,223,227,175,207,123,172,114,205,125,214,55,83,219,145,172,133,100,174,76,122,64,167,144,131,64,41,234,68,37,169,8,80,82,195,43,79,185,177,101,81,106,96,138,149,36,115,102,159,22,89,114,225,73,230,77,50,223,77,51,193,81,121,142,88,99,193,115,166,165,194,88,198,29,21,188,200,169,86,88,114,240,42,84,104,180,170,172,63,241,250,48,69,28,199,241,114,106,97,136,238,5,59,32,191,126,168,103,215,119,105,232,155,69,250,242,184,253,43,60,165,21,238,203,175,31,171,161,132,235,75,16,57,100,211,8,103,77,132,46,237,58,215,251,216,221,175,154,135,3,134,180,123,51,196,241,68,97,247,56,153,134,100,67,188,127,248,43,173,179,105,76,125,251,31,89,205,208,38,106,96,147,29,203,93,122,208,199,113,223,152,231,227,188,38,239,30,167,62,189,255,12,198,111,26,252,108,207,227,48,166,205,210,175,155,62,108,208,252,212,36,148,219,184,190,105,192,45,135,189,253,132,172,98,136,224,55,102,220,44,21,25,151,86,25,242,42,93,77,110,136,11,76,9,0,73,181,116,129,10,135,112,42,145,59,10,22,10,201,130,171,88,153,111,53,3,237,43,11,180,84,22,55,49,236,125,147,51,78,43,27,108,105,84,110,109,40,183,198,139,42,247,82,211,92,46,13,239,53,54,124,33,20,245,94,11,165,192,242,74,243,27,130,48,254,181,197,235,139,241,227,207,238,116,143,87,242,183,91,92,125,181,176,107,160,197,35,194,19,126,3,147,3,6,92,157,82,213,243,91,8,45,33,187,46,197,244,188,222,231,122,126,11,178,195,237,2,237,246,128,239,47,10,149,52,23,245,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b4af7ceb-60b9-467c-a8b3-81953d377341"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
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
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("311fcede-bca4-4fec-9a42-0f943fe03159"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
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
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4f32f247-07f2-471b-ba49-b42cae200cf0"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
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
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d72c0941-da6e-42f6-b7a5-0b3ffe8b2c2e"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
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
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3356dca2-6b01-46e0-9fe2-d0de44ff97b0"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
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
				UId = new Guid("d550d767-aeda-4cf2-9b2a-90c7c38be81b"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
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
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("fff72291-b74e-4830-8333-56ad140e6e7c"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
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
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("05f02083-70af-4052-8ee7-2b228747244c"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
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
				UId = new Guid("123bb774-23e8-4cbe-a707-c0bf2149c012"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
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
				UId = new Guid("a43adf8a-3d3f-4d55-bbb1-030b98ca7464"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
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
				UId = new Guid("2a298fa9-f151-46ad-b486-c3c3bcb89af4"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
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
				UId = new Guid("51b3ba73-2cd0-43a5-b1bb-d655502ea451"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
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
				UId = new Guid("bd94e2da-67c7-4c33-985e-1f6fdecc4562"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
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
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("53665a2a-42d9-47f3-8bf4-e4ebbd2e10f3"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
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
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f382eb7c-1c7a-4c11-93b3-5b6271585801"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
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
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("377fdd7e-2835-4e98-a892-93bd77cfe77f"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
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
				UId = new Guid("c86054c5-11bd-442c-8cad-f413a456d299"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
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
				UId = new Guid("812b0c07-934e-4b42-92df-0fb9f4091dad"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
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

		protected virtual void InitializeDistributionLeadPageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var titleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bbe769c2-34d8-4a8b-a580-a9e4311e6053"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"Title",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			titleParameter.SourceValue = new ProcessSchemaParameterValue(titleParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Distribution page",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(titleParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5160bb63-99ee-4be0-ad4e-f804a2c25915"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"Recommendation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			recommendationParameter.SourceValue = new ProcessSchemaParameterValue(recommendationParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var clientUnitSchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2021bd48-f45e-4cd3-b993-7b97a0c3308d"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"ClientUnitSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			clientUnitSchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(clientUnitSchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"65a13f26-c1c8-49e6-9744-ce1c028164df",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(clientUnitSchemaUIdParameter);
			var entityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1905b493-d577-4148-a465-5b25ff5f0ab4"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.In,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"EntityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entityIdParameter.SourceValue = new ProcessSchemaParameterValue(entityIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(entityIdParameter);
			var entryPointIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("702a610c-eae3-442a-b9e5-1eae1657abca"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"EntryPointId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entryPointIdParameter.SourceValue = new ProcessSchemaParameterValue(entryPointIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entryPointIdParameter);
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("ab6017ca-8f69-4ec1-95d6-57eb04cec232"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var useCardProcessModuleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1babcc34-fbcc-4e3e-84fe-432c05fdbbe5"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"UseCardProcessModule",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			useCardProcessModuleParameter.SourceValue = new ProcessSchemaParameterValue(useCardProcessModuleParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(useCardProcessModuleParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("583c0a7d-9ed9-49b6-919b-fb6caaff12fd"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = true,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3aeda084-6af5-44ea-8738-d38edc340131"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"ShowExecutionPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showExecutionPageParameter.SourceValue = new ProcessSchemaParameterValue(showExecutionPageParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{51139bfa-4db4-45f7-aa2f-590d604f8469}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("63033799-a11b-4b1e-9c2b-6e17977e2c43"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
			var isRunningParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("809907b4-6caf-4cda-8cd8-58f9c1196633"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"IsRunning",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isRunningParameter.SourceValue = new ProcessSchemaParameterValue(isRunningParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(isRunningParameter);
			var templateParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae"),
				UId = new Guid("f9aec3cc-c5b5-4b0b-a7b8-b1678e0065cc"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"Template",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			templateParameter.SourceValue = new ProcessSchemaParameterValue(templateParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#Lookup.90fa6d02-3e93-45d6-a72b-58dcffa411ae.21620f25-166f-42f1-8b4d-224a959040a3#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(templateParameter);
			var moduleParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae"),
				UId = new Guid("284418dc-2d40-480b-8a88-4eadf9076834"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"Module",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			moduleParameter.SourceValue = new ProcessSchemaParameterValue(moduleParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#Lookup.90fa6d02-3e93-45d6-a72b-58dcffa411ae.eb89c336-08b9-4951-bffd-3f5abc433174#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(moduleParameter);
			var pressedButtonCodeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6c9b11d3-782e-48a9-bdbb-1e8ce5b6188c"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"PressedButtonCode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			pressedButtonCodeParameter.SourceValue = new ProcessSchemaParameterValue(pressedButtonCodeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(pressedButtonCodeParameter);
			var urlParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1301bffa-691c-4e8f-b9a8-e3c3f257668c"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"Url",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			urlParameter.SourceValue = new ProcessSchemaParameterValue(urlParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"""[Module]/[Page]/add""",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(urlParameter);
			var leadIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("345b747f-6492-4686-a503-0062acd716e0"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"LeadId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			leadIdParameter.SourceValue = new ProcessSchemaParameterValue(leadIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{30cf6943-a881-4c30-a088-ff65572e4241}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(leadIdParameter);
			var resultParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a9e78508-ae1b-4141-abe0-24ed11eadb13"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"Result",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText")
			};
			resultParameter.SourceValue = new ProcessSchemaParameterValue(resultParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(resultParameter);
			var remindToOwnerParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cd5eefc4-6c19-4719-be10-6babbc9acc6e"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"RemindToOwner",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			remindToOwnerParameter.SourceValue = new ProcessSchemaParameterValue(remindToOwnerParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(remindToOwnerParameter);
			var leadOwnerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("0d01d7bb-ccf9-4184-a64f-953b68988ea4"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"LeadOwnerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			leadOwnerIdParameter.SourceValue = new ProcessSchemaParameterValue(leadOwnerIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(leadOwnerIdParameter);
			var opportunityDepartmentParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8227a76e-e673-40a1-a3f3-2102ef5efe7a"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"OpportunityDepartment",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			opportunityDepartmentParameter.SourceValue = new ProcessSchemaParameterValue(opportunityDepartmentParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(opportunityDepartmentParameter);
		}

		protected virtual void InitializeSaveLeadByDefaultParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("560bc47f-ebc5-4687-aa0c-08705e061a9a"),
				ContainerUId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c4e20e54-2a71-4e75-a167-24858aec6fcb"),
				ContainerUId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"IsMatchConditions",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMatchConditionsParameter.SourceValue = new ProcessSchemaParameterValue(isMatchConditionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ba1c792f-b05d-43b6-b1d4-1f6f092ae9d7"),
				ContainerUId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,79,107,220,48,16,197,191,139,14,61,89,197,178,100,75,114,143,203,182,44,148,52,208,180,20,146,37,140,165,81,86,224,63,27,75,166,9,102,191,123,181,118,54,133,28,74,233,173,224,195,104,236,247,230,55,15,121,190,247,225,163,111,35,142,181,131,54,96,54,237,108,77,132,211,166,41,154,134,10,107,56,21,96,129,170,162,212,84,200,28,65,241,178,105,242,130,100,61,116,88,147,85,189,181,62,146,204,71,236,66,125,59,255,54,141,227,132,217,189,91,14,95,205,1,59,248,182,12,96,224,148,70,77,101,153,167,41,152,70,41,3,134,58,199,117,83,9,37,24,26,178,178,96,195,36,56,224,20,25,43,18,139,49,180,1,89,80,205,19,5,151,92,88,157,88,90,116,113,251,116,28,49,4,63,244,245,140,175,245,205,243,49,81,174,179,55,67,59,117,61,201,58,140,112,13,241,80,19,192,28,69,105,128,26,161,75,42,28,74,10,92,91,202,161,145,133,84,200,42,38,73,102,224,24,207,182,100,103,73,102,33,194,119,104,39,92,156,103,159,24,11,158,51,85,86,73,203,184,161,130,23,57,85,149,146,212,217,202,105,228,149,214,141,189,228,245,105,242,169,246,225,106,234,112,244,230,37,118,76,249,13,99,61,155,161,143,227,208,158,173,175,150,207,111,240,41,174,225,190,188,250,177,46,20,83,255,44,34,167,108,10,184,105,61,246,113,219,155,193,250,254,97,245,60,157,146,164,59,194,232,195,37,133,237,227,4,45,201,70,255,112,248,99,90,155,41,196,161,251,143,86,205,210,154,201,35,93,178,5,247,124,7,173,15,199,22,158,151,115,77,222,61,78,67,252,240,25,193,174,21,121,163,168,201,29,225,185,113,149,22,156,130,82,140,10,195,115,10,185,82,233,82,86,101,41,11,20,133,96,119,36,81,252,131,247,237,46,124,249,217,95,254,129,149,122,255,62,117,223,52,174,47,202,122,254,27,156,211,254,12,180,63,165,231,23,66,164,233,35,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f3fd0d58-28e8-457f-8737-49c12cc4cc1d"),
				ContainerUId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"RecordColumnValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,151,75,111,27,71,12,199,191,138,176,201,209,52,230,253,208,53,233,193,64,210,26,117,154,139,237,3,103,134,108,4,232,97,236,174,83,164,130,190,123,169,181,28,219,105,227,4,185,196,69,178,135,149,52,59,127,146,75,242,55,51,218,118,207,199,15,87,212,205,187,55,212,247,56,108,120,60,126,177,233,233,248,180,223,84,26,134,227,87,155,138,203,197,223,88,150,116,138,61,174,104,164,254,45,46,175,105,120,181,24,198,163,217,67,89,119,212,61,127,63,61,237,230,231,219,238,100,164,213,31,39,77,172,231,232,93,174,152,0,163,74,224,172,87,144,83,107,16,149,66,29,42,171,90,180,136,235,102,121,189,90,191,166,17,79,113,124,215,205,183,221,100,77,12,120,147,116,180,78,180,85,105,112,74,123,49,21,2,136,78,213,88,188,119,53,117,187,163,110,168,239,104,133,147,211,59,177,211,200,41,83,134,232,85,1,71,165,64,170,88,129,217,230,18,92,114,154,234,94,124,152,127,39,60,127,118,126,50,252,246,215,154,250,179,201,238,156,113,57,208,229,177,140,126,50,240,49,57,243,109,140,133,171,119,26,52,106,4,87,60,65,105,49,130,37,103,114,117,37,216,200,187,203,103,151,123,143,109,49,92,45,241,195,219,127,59,158,188,222,76,186,122,144,248,251,211,182,23,55,245,187,232,230,23,159,171,224,225,243,38,222,135,53,252,180,124,23,221,209,69,119,182,185,238,235,222,162,221,255,184,77,231,228,65,29,46,248,143,219,237,117,99,99,146,189,198,53,254,73,253,175,226,113,146,79,143,94,226,136,147,243,55,18,247,173,225,98,178,87,81,51,68,194,44,5,10,6,82,147,228,101,157,11,219,104,13,179,153,212,191,19,83,79,235,74,15,3,211,161,144,13,94,67,98,50,224,180,207,162,111,10,48,41,219,92,72,182,53,59,233,39,207,119,193,220,118,154,140,172,175,151,203,201,193,48,189,255,190,117,15,129,31,158,188,188,87,170,123,22,54,109,193,11,106,39,235,111,73,213,174,219,237,142,238,115,210,178,183,54,104,13,210,64,14,92,48,14,114,222,103,131,90,138,104,106,41,218,61,202,137,137,153,201,146,130,152,171,2,199,73,65,65,197,192,62,52,54,206,179,96,248,68,56,201,181,89,78,193,130,162,38,156,88,155,32,101,129,37,71,78,6,27,147,83,225,203,156,188,232,9,71,154,245,180,90,172,27,245,51,222,244,179,205,143,196,78,86,37,248,194,9,20,115,149,222,151,133,39,197,152,193,56,163,228,11,114,86,241,49,118,190,58,176,167,206,14,133,22,147,32,3,46,135,40,221,219,34,20,102,134,160,131,138,134,173,210,38,61,190,199,84,197,24,115,128,162,146,149,76,154,0,88,133,134,202,173,85,227,189,205,168,190,39,59,191,44,105,69,235,113,190,181,228,67,80,178,25,146,224,12,78,170,15,185,153,6,94,169,16,178,49,170,56,218,61,132,205,39,91,21,198,6,153,154,72,36,164,105,113,5,46,161,34,50,107,195,237,203,176,73,29,199,126,81,174,199,197,102,61,187,146,6,61,254,185,77,253,136,219,148,103,229,201,196,253,235,251,38,219,84,144,102,247,236,33,185,130,129,163,182,197,61,142,26,58,133,193,49,2,42,146,181,95,145,180,163,139,194,155,207,85,55,46,37,91,254,191,162,150,140,137,114,54,37,160,16,101,25,145,3,46,160,101,11,70,43,67,236,165,53,34,126,11,106,103,184,164,97,214,22,239,23,131,140,253,100,238,235,152,243,45,57,31,138,3,237,229,84,228,26,121,89,222,229,134,44,255,28,56,196,44,171,254,83,101,238,114,247,15,50,106,29,73,160,13,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLeadDistributionProcess = CreateLeadDistributionProcessLaneSet();
			LaneSets.Add(schemaLeadDistributionProcess);
			ProcessSchemaLane schemaLeadDistribution = CreateLeadDistributionLane();
			schemaLeadDistributionProcess.Lanes.Add(schemaLeadDistribution);
			ProcessSchemaStartEvent start = CreateStartStartEvent();
			FlowElements.Add(start);
			ProcessSchemaTerminateEvent terminatehandoff = CreateTerminateHandoffTerminateEvent();
			FlowElements.Add(terminatehandoff);
			ProcessSchemaExclusiveGateway exclusivegatewayisleadset = CreateExclusiveGatewayIsLeadSetExclusiveGateway();
			FlowElements.Add(exclusivegatewayisleadset);
			ProcessSchemaTerminateEvent terminateleadisnotset = CreateTerminateLeadIsNotSetTerminateEvent();
			FlowElements.Add(terminateleadisnotset);
			ProcessSchemaUserTask saveleadhandoff = CreateSaveLeadHandoffUserTask();
			FlowElements.Add(saveleadhandoff);
			ProcessSchemaUserTask saveleadnointerest = CreateSaveLeadNoInterestUserTask();
			FlowElements.Add(saveleadnointerest);
			ProcessSchemaTerminateEvent terminatenointerest = CreateTerminateNoInterestTerminateEvent();
			FlowElements.Add(terminatenointerest);
			ProcessSchemaTerminateEvent terminatecontinuedistribution = CreateTerminateContinueDistributionTerminateEvent();
			FlowElements.Add(terminatecontinuedistribution);
			ProcessSchemaUserTask addreminder = CreateAddReminderUserTask();
			FlowElements.Add(addreminder);
			ProcessSchemaUserTask readleaddata = CreateReadLeadDataUserTask();
			FlowElements.Add(readleaddata);
			ProcessSchemaUserTask readleadtype = CreateReadLeadTypeUserTask();
			FlowElements.Add(readleadtype);
			ProcessSchemaUserTask readleadcontact = CreateReadLeadContactUserTask();
			FlowElements.Add(readleadcontact);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			FlowElements.Add(exclusivegateway2);
			ProcessSchemaUserTask distributionleadpage = CreateDistributionLeadPageUserTask();
			FlowElements.Add(distributionleadpage);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask saveleadbydefault = CreateSaveLeadByDefaultUserTask();
			FlowElements.Add(saveleadbydefault);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalFlowLeadUndefinedConditionalFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateConditionalFlowCreateReminderConditionalFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlowNoReminderSequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("5fb58e15-c3e0-48b9-b270-c3878ba5ec8d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7a92b7ab-7ed4-4582-8e65-9e766afb2829"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0788b001-b01e-467d-8078-6e3f56e8a438"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowLeadUndefinedConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowLeadUndefined",
				UId = new Guid("5805d2d7-5516-4f97-9107-0c6b5c4bbc5c"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{30cf6943-a881-4c30-a088-ff65572e4241}]#] == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(182, 288),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0788b001-b01e-467d-8078-6e3f56e8a438"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("28c1efc4-e3b9-4c23-8307-4e19e53453b3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("290d5fde-c5b4-44ae-9d6b-38bd65766e89"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(598, 322),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7969b2cd-51e0-490c-b289-63e0473f9af3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("721db265-d834-462e-bd2d-515b03c3eaf9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowCreateReminderConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowCreateReminder",
				UId = new Guid("97e8e894-d220-43dc-9cfa-0e37f8166e2a"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{9cd3f863-0eda-4338-895e-97f82adfe406}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(648, 154),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("e7b9f7af-f3f3-45b3-b5ef-e55931027930"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(677, 155),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("68552fe0-b6b1-47de-9bdd-6c06dbdf6839"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e0fc6ab2-437d-4492-a531-191b3013d93d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowNoReminderSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlowNoReminder",
				UId = new Guid("74e4203e-f8b4-42a4-9a72-43c7354d017c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(916, 130),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("68552fe0-b6b1-47de-9bdd-6c06dbdf6839"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow4",
				UId = new Guid("8e0f40d1-6611-4d88-a2b3-db13f8f8268e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(220, 155),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0788b001-b01e-467d-8078-6e3f56e8a438"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("f5da7633-709e-40ac-ab2f-51d79b4f1e75"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{3e566048-ef49-45bf-9d2d-500669220b4e}].[Parameter:{a9e78508-ae1b-4141-abe0-24ed11eadb13}]#] == ""TransferToSale""",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(480, 152),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fe8039af-a364-42b4-bf9d-dbe3a1991c15"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow3",
				UId = new Guid("15c1b993-b41b-4b3d-be24-96f8a835c457"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{3e566048-ef49-45bf-9d2d-500669220b4e}].[Parameter:{a9e78508-ae1b-4141-abe0-24ed11eadb13}]#] == ""NotInteresting""",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(468, 226),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fe8039af-a364-42b4-bf9d-dbe3a1991c15"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7969b2cd-51e0-490c-b289-63e0473f9af3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("7f0e3663-1ccd-4022-9a63-af412567e1dd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(348, 154),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fe8039af-a364-42b4-bf9d-dbe3a1991c15"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow10",
				UId = new Guid("1d497f73-83f1-49f1-922b-d98d94ddb5e6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(562, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fe8039af-a364-42b4-bf9d-dbe3a1991c15"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow11",
				UId = new Guid("68e53e5d-ec55-45bb-8ce1-febdee9aa067"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(562, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cb6102fb-8548-4fa4-aae5-b307af30608f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("8693d20e-d10c-4049-b6c4-7b603c0c353d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(1144, 166),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("68552fe0-b6b1-47de-9bdd-6c06dbdf6839"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("a69b197e-c39e-4b7f-b3e2-f9f7e49e02ff"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(809, 166),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("efeba810-1988-471e-8f37-8fdf1b4013e7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(920, 168),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("a2112edf-8702-462c-8323-8546cb7408a8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(1026, 168),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLeadDistributionProcessLaneSet() {
			ProcessSchemaLaneSet schemaLeadDistributionProcess = new ProcessSchemaLaneSet(this) {
				UId = new Guid("4d9afef7-9066-439f-b71e-60e2c82e61da"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"LeadDistributionProcess",
				Position = new Point(5, 5),
				Size = new Size(1344, 436),
				UseBackgroundMode = false
			};
			return schemaLeadDistributionProcess;
		}

		protected virtual ProcessSchemaLane CreateLeadDistributionLane() {
			ProcessSchemaLane schemaLeadDistribution = new ProcessSchemaLane(this) {
				UId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("4d9afef7-9066-439f-b71e-60e2c82e61da"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"LeadDistribution",
				Position = new Point(29, 0),
				Size = new Size(1315, 436),
				UseBackgroundMode = false
			};
			return schemaLeadDistribution;
		}

		protected virtual ProcessSchemaStartEvent CreateStartStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("7a92b7ab-7ed4-4582-8e65-9e766afb2829"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"Start",
				Position = new Point(50, 23),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateHandoffTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("e0fc6ab2-437d-4492-a531-191b3013d93d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"TerminateHandoff",
				Position = new Point(1059, 247),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayIsLeadSetExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("0788b001-b01e-467d-8078-6e3f56e8a438"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"ExclusiveGatewayIsLeadSet",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(36, 121),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateLeadIsNotSetTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("28c1efc4-e3b9-4c23-8307-4e19e53453b3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"TerminateLeadIsNotSet",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(50, 247),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateSaveLeadHandoffUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"SaveLeadHandoff",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(371, 121),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeSaveLeadHandoffParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateSaveLeadNoInterestUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("7969b2cd-51e0-490c-b289-63e0473f9af3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"SaveLeadNoInterest",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(320, 233),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeSaveLeadNoInterestParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateNoInterestTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("721db265-d834-462e-bd2d-515b03c3eaf9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"TerminateNoInterest",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(440, 247),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateContinueDistributionTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("cb6102fb-8548-4fa4-aae5-b307af30608f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"TerminateContinueDistribution",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(440, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateAddReminderUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"AddReminder",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(929, 121),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeAddReminderParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"ReadLeadData",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(531, 121),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadLeadDataParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadTypeUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"ReadLeadType",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(800, 121),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadLeadTypeParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadContactUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"ReadLeadContact",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(671, 121),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadLeadContactParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("68552fe0-b6b1-47de-9bdd-6c06dbdf6839"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1045, 121),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateDistributionLeadPageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"DistributionLeadPage",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(131, 121),
				SchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeDistributionLeadPageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("fe8039af-a364-42b4-bf9d-dbe3a1991c15"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(240, 121),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateSaveLeadByDefaultUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"SaveLeadByDefault",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(320, 20),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeSaveLeadByDefaultParameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LeadManagementDistribution(userConnection);
		}

		public override object Clone() {
			return new LeadManagementDistributionSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadManagementDistribution

	/// <exclude/>
	public class LeadManagementDistribution : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLeadDistribution

		/// <exclude/>
		public class ProcessLeadDistribution : ProcessLane
		{

			public ProcessLeadDistribution(UserConnection userConnection, LeadManagementDistribution process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: SaveLeadHandoffFlowElement

		/// <exclude/>
		public class SaveLeadHandoffFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public SaveLeadHandoffFlowElement(UserConnection userConnection, LeadManagementDistribution process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SaveLeadHandoff";
				IsLogging = true;
				SchemaElementUId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifyStatus = () => (Guid)(new Guid("ceb70b3c-985f-4867-ae7c-88f9dd710688"));
				_recordColumnValues_Owner = () => (Guid)((process.ResponsibleId));
				_recordColumnValues_RemindToOwner = () => (bool)((process.CreateReminder));
				_recordColumnValues_OpportunityDepartment = () => (Guid)((process.DistributionLeadPage.OpportunityDepartment));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifyStatus", () => _recordColumnValues_QualifyStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_Owner", () => _recordColumnValues_Owner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_RemindToOwner", () => _recordColumnValues_RemindToOwner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_OpportunityDepartment", () => _recordColumnValues_OpportunityDepartment.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifyStatus;
			internal Func<Guid> _recordColumnValues_Owner;
			internal Func<bool> _recordColumnValues_RemindToOwner;
			internal Func<Guid> _recordColumnValues_OpportunityDepartment;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			public override Guid EntitySchemaUId {
				get {
					return _entitySchemaUId;
				}
				set {
					_entitySchemaUId = value;
				}
			}

			private bool _isMatchConditions = true;
			public override bool IsMatchConditions {
				get {
					return _isMatchConditions;
				}
				set {
					_isMatchConditions = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,79,107,220,48,16,197,191,139,14,61,89,69,182,198,178,236,30,151,109,89,40,105,160,105,41,36,75,24,75,163,172,192,127,54,182,76,19,204,126,247,202,235,108,10,57,148,210,91,193,135,209,216,239,167,55,143,241,124,239,199,143,190,9,52,84,14,155,145,146,105,103,43,38,108,86,103,136,192,51,5,5,7,43,5,199,210,104,14,160,92,46,108,129,194,32,75,58,108,169,98,171,122,107,125,96,137,15,212,142,213,237,252,27,26,134,137,146,123,119,62,124,53,7,106,241,219,114,1,164,232,116,73,37,47,114,81,115,160,186,230,218,160,225,206,201,178,86,160,33,37,195,86,47,168,4,101,26,136,231,18,4,135,28,11,94,103,96,121,90,80,14,153,148,145,3,44,105,200,133,237,211,113,160,113,244,125,87,205,244,90,223,60,31,163,203,245,238,77,223,76,109,199,146,150,2,94,99,56,68,58,9,130,220,32,55,80,230,28,28,21,28,101,105,185,196,186,200,10,77,169,74,11,150,24,60,134,5,203,118,150,37,22,3,126,199,102,162,51,121,246,209,99,38,69,170,115,21,181,169,52,28,100,38,184,86,186,224,206,42,87,146,84,101,89,219,75,94,159,38,31,107,63,94,77,45,13,222,188,196,78,49,191,126,168,102,211,119,97,232,155,5,125,117,254,252,134,158,194,26,238,203,171,31,235,64,33,246,23,17,59,37,211,72,155,198,83,23,182,157,233,173,239,30,86,230,233,20,37,237,17,7,63,94,82,216,62,78,216,176,100,240,15,135,63,166,181,153,198,208,183,255,209,168,73,28,51,50,226,146,157,237,46,59,104,253,120,108,240,249,124,174,216,187,199,169,15,31,62,19,218,181,98,111,20,21,187,99,82,24,167,74,144,28,181,78,57,152,101,235,133,214,113,41,85,158,23,25,65,6,233,29,139,46,254,129,125,187,27,191,252,236,46,255,192,234,122,255,62,118,223,52,174,47,202,106,254,27,59,167,253,98,104,127,138,207,47,177,221,110,55,202,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,150,77,111,27,71,12,134,255,138,176,201,209,20,230,251,67,215,164,64,13,36,109,80,39,185,196,62,112,102,200,70,168,164,53,118,215,41,82,67,255,189,212,218,110,236,160,177,141,22,69,83,164,123,24,73,179,122,201,153,33,31,114,46,187,167,211,199,115,234,86,221,107,26,6,28,123,158,150,207,250,129,150,175,134,190,210,56,46,95,244,21,55,235,223,176,108,232,21,14,184,165,137,134,183,184,185,160,241,197,122,156,142,22,119,101,221,81,247,244,195,252,182,91,189,187,236,142,39,218,190,57,110,98,157,76,37,23,98,3,167,20,203,96,51,160,81,25,50,230,16,116,114,78,153,34,226,218,111,46,182,187,151,52,225,43,156,222,119,171,203,110,182,38,6,74,85,213,180,160,192,163,21,43,201,41,64,116,4,53,40,194,24,3,25,21,186,253,81,55,214,247,180,197,217,233,39,177,211,200,41,83,134,232,85,1,71,165,64,170,88,129,217,230,18,196,152,166,122,16,95,255,255,147,240,221,147,23,125,255,203,197,249,210,24,235,116,109,26,124,177,22,92,21,247,89,105,13,129,99,200,150,56,144,115,203,74,37,170,98,43,228,228,101,147,41,68,64,138,21,82,226,220,90,212,42,164,244,228,236,224,168,173,199,243,13,126,124,251,69,127,39,19,254,76,203,239,113,215,122,230,197,212,47,70,220,208,120,37,62,191,19,135,219,242,203,211,171,112,158,118,171,211,47,5,244,250,243,100,62,167,187,33,253,60,154,167,221,209,105,119,210,95,12,245,96,209,30,126,220,156,238,236,65,93,63,240,39,195,205,115,101,99,150,189,196,157,108,106,248,65,60,206,242,249,213,115,156,112,118,254,90,214,125,99,184,152,236,85,212,12,145,48,75,188,130,129,212,52,66,214,185,176,141,214,48,155,89,253,19,49,13,180,171,116,119,97,143,137,214,172,159,61,127,90,204,77,226,201,204,238,98,179,153,29,140,243,254,15,153,124,189,240,235,55,207,111,133,240,150,133,190,173,121,77,237,120,247,87,142,106,223,237,247,71,183,177,81,149,124,45,146,240,137,157,100,84,213,22,82,44,26,34,150,172,98,76,84,8,239,197,198,155,164,163,117,73,180,74,11,119,218,3,198,16,160,22,173,106,44,222,187,154,254,9,108,222,29,143,63,254,186,163,225,234,20,86,140,155,145,206,150,50,251,217,196,31,9,184,186,140,177,112,245,78,131,70,9,181,43,158,160,180,24,193,146,51,185,186,18,108,228,253,217,67,252,204,94,255,231,228,113,156,232,80,200,6,175,37,189,200,128,211,62,139,190,73,101,77,202,54,23,146,109,205,254,39,56,177,41,59,149,147,146,82,171,36,119,52,23,40,33,105,144,204,119,14,89,185,200,250,94,78,76,204,76,150,20,196,92,21,56,22,83,5,165,83,177,15,141,141,243,236,114,253,74,56,201,181,89,78,193,130,162,38,123,181,54,65,202,2,75,142,156,12,54,38,167,194,195,156,60,27,8,39,90,12,180,93,239,26,13,11,238,135,69,255,45,177,147,85,9,190,112,2,197,92,37,101,164,240,164,24,51,24,103,148,124,65,150,2,123,31,59,143,94,216,215,206,78,242,37,73,226,34,112,150,250,225,188,52,203,100,117,1,163,91,82,202,59,211,178,187,151,29,116,10,131,99,4,148,171,152,244,24,10,144,93,12,128,62,87,221,184,148,108,249,223,100,231,187,13,109,105,55,173,46,45,249,16,148,52,67,18,156,101,167,133,33,55,211,192,43,21,66,54,70,21,71,251,187,176,37,99,162,52,76,2,10,81,110,18,10,53,160,101,43,135,163,12,177,151,212,136,248,48,108,18,199,105,88,151,139,105,221,239,22,231,135,155,221,201,225,58,183,104,235,15,235,81,230,190,21,230,254,110,191,242,45,57,31,138,3,237,165,84,187,70,30,138,146,1,89,174,51,28,98,246,245,171,101,238,108,255,59,129,78,83,81,108,13,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "d6c59cedf94c477daef17418c7544cfe",
							"BaseElements.SaveLeadHandoff.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordColumnValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordColumnValues", getColumnValue);
					}
					return _recordColumnValues;
				}
				set {
					_recordColumnValues = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: SaveLeadNoInterestFlowElement

		/// <exclude/>
		public class SaveLeadNoInterestFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public SaveLeadNoInterestFlowElement(UserConnection userConnection, LeadManagementDistribution process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SaveLeadNoInterest";
				IsLogging = true;
				SchemaElementUId = new Guid("7969b2cd-51e0-490c-b289-63e0473f9af3");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifyStatus = () => (Guid)(new Guid("51adc3ec-3503-4b10-a00b-8be3b0e11f08"));
				_recordColumnValues_LeadTypeStatus = () => (Guid)(new Guid("f78066d3-a73e-4e86-bb99-e477fcb94b28"));
				_recordColumnValues_Owner = () => (Guid)((process.DistributionLeadPage.OwnerId));
				_recordColumnValues_RemindToOwner = () => (bool)((process.DistributionLeadPage.RemindToOwner));
				_recordColumnValues_OpportunityDepartment = () => (Guid)((process.DistributionLeadPage.OpportunityDepartment));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifyStatus", () => _recordColumnValues_QualifyStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_LeadTypeStatus", () => _recordColumnValues_LeadTypeStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_Owner", () => _recordColumnValues_Owner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_RemindToOwner", () => _recordColumnValues_RemindToOwner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_OpportunityDepartment", () => _recordColumnValues_OpportunityDepartment.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifyStatus;
			internal Func<Guid> _recordColumnValues_LeadTypeStatus;
			internal Func<Guid> _recordColumnValues_Owner;
			internal Func<bool> _recordColumnValues_RemindToOwner;
			internal Func<Guid> _recordColumnValues_OpportunityDepartment;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			public override Guid EntitySchemaUId {
				get {
					return _entitySchemaUId;
				}
				set {
					_entitySchemaUId = value;
				}
			}

			private bool _isMatchConditions = true;
			public override bool IsMatchConditions {
				get {
					return _isMatchConditions;
				}
				set {
					_isMatchConditions = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,36,21,203,146,245,225,30,151,109,89,40,105,160,105,41,36,75,144,165,81,86,224,143,141,37,211,4,179,255,189,242,58,155,66,14,165,244,86,208,97,52,154,247,230,205,99,52,223,135,248,49,180,9,198,218,155,54,2,158,118,174,70,69,229,20,48,197,8,5,230,9,23,162,36,186,162,21,113,86,73,203,37,99,32,27,132,123,211,65,141,86,244,214,133,132,112,72,208,197,250,118,254,77,154,198,9,240,189,63,95,190,218,3,116,230,219,210,128,83,227,149,6,77,100,85,52,132,67,211,16,101,141,37,222,51,221,8,174,56,5,139,86,45,76,23,66,230,90,82,22,174,36,220,8,75,180,84,146,72,224,180,148,90,59,90,50,132,91,240,105,251,116,28,33,198,48,244,245,12,175,241,205,243,49,171,92,123,111,134,118,234,122,132,59,72,230,218,164,67,141,12,20,192,43,107,136,229,186,34,220,131,36,134,105,71,152,105,100,41,21,80,65,37,194,214,28,211,66,139,118,14,97,103,146,249,110,218,9,206,204,115,200,26,75,86,80,85,137,140,165,204,18,206,202,130,40,145,53,122,39,188,6,38,180,110,220,197,175,79,83,200,113,136,87,83,7,99,176,47,182,67,246,111,24,235,217,14,125,26,135,118,161,190,58,151,223,192,83,90,205,125,121,250,177,14,148,114,126,1,161,19,158,34,108,218,0,125,218,246,118,112,161,127,88,57,79,167,12,233,142,102,12,241,226,194,246,113,50,45,194,99,120,56,252,209,173,205,20,211,208,253,71,163,226,60,102,230,200,75,118,150,187,236,160,11,241,216,154,231,243,189,70,239,30,167,33,125,248,12,198,173,17,122,131,168,209,29,98,133,245,66,115,70,140,82,148,112,203,10,98,10,165,242,82,138,170,146,37,240,146,211,59,148,85,252,3,247,237,46,126,249,217,95,254,192,170,122,255,62,103,223,36,174,47,200,122,254,27,57,167,253,34,104,127,202,231,23,171,70,92,220,202,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,87,75,111,219,72,12,254,43,134,218,99,104,204,251,225,107,187,135,0,105,54,104,186,189,36,57,112,102,56,91,97,109,43,144,228,46,186,134,255,251,210,74,210,36,197,54,27,164,40,208,160,213,65,150,71,243,145,20,201,143,228,108,155,151,227,167,75,106,22,205,59,234,123,28,186,58,206,95,117,61,205,79,250,46,211,48,204,143,186,140,203,246,31,76,75,58,193,30,87,52,82,255,30,151,27,26,142,218,97,60,152,221,135,53,7,205,203,143,211,219,102,113,182,109,14,71,90,253,113,88,88,122,173,33,71,99,60,100,83,10,24,180,17,162,211,4,34,145,64,172,168,209,238,193,185,91,110,86,235,55,52,226,9,142,31,154,197,182,153,164,177,128,148,69,86,197,9,176,168,89,64,48,2,16,13,65,118,130,208,123,71,74,184,102,119,208,12,249,3,173,112,82,122,11,54,18,107,136,20,193,91,145,192,80,74,16,50,102,168,85,199,228,88,152,164,188,7,95,239,191,5,158,189,56,234,186,191,54,151,115,165,180,145,185,72,176,73,107,48,153,213,71,33,37,184,234,93,212,84,29,25,51,183,18,75,214,148,65,91,193,155,146,100,27,5,43,12,137,116,18,36,101,21,225,197,197,94,81,105,135,203,37,126,122,255,85,125,167,35,254,73,243,227,110,156,181,107,246,56,13,35,149,43,232,229,189,40,220,5,111,207,175,130,121,222,44,206,191,22,206,235,223,211,201,75,247,3,250,101,44,207,155,131,243,230,180,219,244,121,47,81,239,255,220,248,118,210,32,174,47,248,143,219,205,117,37,99,130,189,193,53,127,82,127,204,26,39,248,244,234,53,142,56,41,127,199,118,223,8,78,42,90,225,101,5,79,24,57,90,78,65,40,18,33,202,152,170,246,90,213,170,38,244,91,170,236,154,117,166,251,134,61,38,86,19,126,210,124,107,204,77,218,241,202,122,179,92,78,10,134,233,251,247,121,124,109,248,245,155,215,119,2,120,71,66,87,218,218,82,57,92,63,197,85,187,102,183,59,184,75,154,80,60,69,89,45,88,229,16,76,148,9,146,146,25,172,214,58,83,80,74,73,251,32,105,98,82,62,102,239,64,40,201,158,168,86,2,230,226,64,71,237,72,10,23,83,49,223,147,52,165,202,156,131,3,167,124,6,83,248,134,133,227,42,10,5,162,132,201,136,60,175,62,8,231,138,6,244,92,15,12,241,246,148,98,4,50,222,215,156,162,73,234,177,164,57,38,42,51,102,206,184,25,126,81,231,105,212,121,68,196,158,5,117,172,71,25,92,214,16,226,62,121,163,225,15,49,194,3,114,73,16,62,106,75,74,61,72,29,171,130,244,218,4,174,31,66,130,17,210,114,130,58,7,153,171,122,246,201,90,147,195,247,160,206,217,225,240,251,223,107,234,175,188,176,168,184,28,232,98,206,171,95,44,252,182,164,21,173,199,197,86,147,117,78,176,161,84,13,135,220,166,10,177,168,2,86,48,173,162,82,34,25,218,49,224,115,198,46,182,54,232,44,208,23,136,84,24,194,38,77,9,2,53,185,204,205,184,74,85,203,238,226,255,72,199,113,28,251,54,109,198,182,91,207,46,247,237,106,50,252,23,213,30,71,53,233,120,42,112,92,145,67,37,5,70,242,68,20,74,225,137,33,8,93,140,11,186,20,253,44,168,166,188,241,66,87,9,146,60,59,66,160,134,88,67,225,201,140,164,138,38,96,160,240,32,213,184,71,85,210,36,128,123,149,224,46,21,4,36,20,21,170,117,165,42,99,57,175,243,115,165,90,46,150,168,102,3,46,75,134,120,190,37,238,188,224,184,150,166,28,49,179,151,158,66,181,183,180,106,215,133,250,89,237,250,89,247,51,241,142,235,185,99,207,7,16,181,114,139,146,134,25,228,57,241,148,81,130,31,176,70,225,31,226,221,163,13,251,209,121,199,7,39,37,108,65,176,206,240,116,24,40,65,100,42,130,180,232,115,48,158,207,27,254,65,222,113,67,68,103,42,242,33,133,88,128,32,110,3,134,135,69,62,156,101,89,42,79,97,186,62,87,222,241,112,236,185,95,19,144,243,122,95,148,120,242,213,85,131,146,66,81,181,156,26,30,159,194,187,83,92,210,48,43,237,199,118,224,181,159,133,115,223,218,235,108,9,198,186,100,56,55,185,204,155,66,22,248,60,204,19,85,229,105,170,58,31,109,254,97,57,119,177,251,23,86,136,208,208,36,17,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "d6c59cedf94c477daef17418c7544cfe",
							"BaseElements.SaveLeadNoInterest.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordColumnValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordColumnValues", getColumnValue);
					}
					return _recordColumnValues;
				}
				set {
					_recordColumnValues = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: AddReminderFlowElement

		/// <exclude/>
		public class AddReminderFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddReminderFlowElement(UserConnection userConnection, LeadManagementDistribution process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddReminder";
				IsLogging = true;
				SchemaElementUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_SysEntitySchema = () => (Guid)(new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"));
				_recordDefValues_Contact = () => (Guid)((process.ResponsibleId));
				_recordDefValues_SubjectId = () => (Guid)((process.LeadId));
				_recordDefValues_RemindTime = () => (DateTime)(((DateTime)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentDateTime")));
				_recordDefValues_Source = () => (Guid)(new Guid("a66d08e1-2e2d-e011-ac0a-00155d043205"));
				_recordDefValues_SubjectCaption = () => new LocalizableString(String.Concat("Need ", ((process.ReadLeadType.ResultEntity.IsColumnValueLoaded(process.ReadLeadType.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? process.ReadLeadType.ResultEntity.GetTypedColumnValue<string>("Name") : null)), " of the contact ", ((process.ReadLeadContact.ResultEntity.IsColumnValueLoaded(process.ReadLeadContact.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? process.ReadLeadContact.ResultEntity.GetTypedColumnValue<string>("Name") : null))," was proceeded to handoff"));
				_recordDefValues_Description = () => new LocalizableString(String.Concat("Need", ((process.ReadLeadType.ResultEntity.IsColumnValueLoaded(process.ReadLeadType.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? process.ReadLeadType.ResultEntity.GetTypedColumnValue<string>("Name") : null)), " of the contact ", ((process.ReadLeadContact.ResultEntity.IsColumnValueLoaded(process.ReadLeadContact.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? process.ReadLeadContact.ResultEntity.GetTypedColumnValue<string>("Name") : null)), " was proceeded to handoff"));
				_recordDefValues_TypeCaption = () => new LocalizableString("Lead");
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_SysEntitySchema", () => _recordDefValues_SysEntitySchema.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_SubjectId", () => _recordDefValues_SubjectId.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_RemindTime", () => _recordDefValues_RemindTime.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Source", () => _recordDefValues_Source.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_SubjectCaption", () => _recordDefValues_SubjectCaption.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Description", () => _recordDefValues_Description.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_TypeCaption", () => _recordDefValues_TypeCaption.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_SysEntitySchema;
			internal Func<Guid> _recordDefValues_Contact;
			internal Func<Guid> _recordDefValues_SubjectId;
			internal Func<DateTime> _recordDefValues_RemindTime;
			internal Func<Guid> _recordDefValues_Source;
			internal Func<string> _recordDefValues_SubjectCaption;
			internal Func<string> _recordDefValues_Description;
			internal Func<string> _recordDefValues_TypeCaption;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,89,223,79,27,71,16,254,87,78,151,60,180,18,107,237,239,31,188,85,73,90,33,37,41,10,105,94,48,15,179,187,51,193,170,241,33,251,156,136,34,254,247,206,29,208,0,77,13,141,136,148,4,252,96,236,243,205,236,238,204,124,223,124,115,156,182,79,251,147,99,108,183,219,183,184,92,194,170,163,126,242,172,91,226,100,119,217,21,92,173,38,47,187,2,243,217,95,144,231,184,11,75,56,194,30,151,239,96,190,198,213,203,217,170,223,106,174,155,181,91,237,211,15,227,175,237,246,254,105,187,211,227,209,31,59,149,189,151,72,57,67,149,2,193,105,97,43,89,145,99,208,34,23,5,214,162,82,50,39,54,46,221,124,125,180,120,133,61,236,66,127,216,110,159,182,163,55,118,128,158,144,130,245,130,192,37,97,165,68,17,131,231,79,214,6,99,179,2,45,77,123,182,213,174,202,33,30,193,184,232,39,99,192,0,46,23,47,148,114,36,44,86,45,82,40,78,40,67,174,56,101,117,49,97,48,190,184,255,147,225,2,63,54,191,173,103,245,167,105,107,21,80,76,152,68,112,50,179,143,156,69,44,80,4,145,73,217,219,104,21,150,105,251,243,224,166,206,86,199,115,56,121,119,63,222,142,175,133,253,170,191,211,233,121,246,166,237,246,244,191,242,119,241,119,111,12,203,245,12,222,76,222,180,221,154,182,123,221,122,89,6,143,102,248,114,25,204,113,5,121,241,18,159,121,187,124,157,251,24,205,94,193,2,222,227,242,53,175,56,154,143,63,61,135,30,198,197,223,242,190,47,29,103,157,156,12,138,68,64,224,140,162,215,34,86,5,34,169,148,201,4,163,137,244,104,253,6,9,151,184,40,120,125,99,160,171,149,1,148,40,21,172,176,198,90,1,37,40,17,35,88,212,153,82,209,113,180,31,87,254,180,153,203,58,227,43,139,245,124,62,46,176,26,207,63,20,238,197,198,47,126,121,126,37,167,87,60,116,117,70,51,172,59,139,47,9,213,89,123,118,182,117,21,37,58,27,87,65,21,97,50,113,85,128,13,34,65,168,194,122,155,44,101,210,25,220,70,148,88,169,172,81,165,10,85,7,152,89,149,4,40,82,34,120,31,192,56,107,171,46,247,143,146,253,39,251,59,171,223,63,46,112,121,30,133,109,130,249,10,15,38,124,245,198,133,127,10,112,251,52,132,76,197,89,37,20,112,170,109,118,40,114,13,65,24,180,58,21,155,189,9,116,118,240,228,96,19,160,246,159,140,171,158,223,244,136,147,219,112,162,124,70,227,29,3,131,144,171,67,49,145,198,202,156,12,81,154,106,125,52,181,154,239,2,39,57,64,206,49,27,33,29,223,108,97,12,132,206,34,88,155,53,6,79,30,55,227,68,58,149,172,161,202,61,36,69,102,12,28,58,145,53,162,80,14,146,178,213,81,218,111,4,39,70,22,242,188,89,206,82,84,194,22,195,249,146,49,114,167,240,206,5,205,104,177,234,118,156,188,68,168,15,5,38,218,72,21,157,15,76,125,166,112,114,181,20,209,199,32,168,122,74,12,128,148,114,221,4,147,59,111,236,91,135,137,178,64,37,235,32,170,83,134,97,162,184,202,101,36,174,86,50,202,4,105,52,250,141,48,41,24,40,5,25,133,43,153,187,144,81,94,100,48,76,61,201,163,49,42,57,163,191,10,76,246,78,86,239,96,57,27,68,231,228,217,122,201,57,234,57,211,248,118,118,132,183,21,58,155,242,249,155,15,55,204,155,202,246,13,44,106,211,179,147,102,188,255,161,224,161,106,133,9,89,113,23,233,89,30,201,161,12,116,28,148,180,130,168,130,98,209,100,31,4,30,130,196,152,125,32,225,205,80,145,217,123,145,80,6,161,137,27,42,73,158,44,178,218,136,7,32,84,220,29,130,192,164,152,139,181,97,60,132,26,132,179,185,58,23,131,74,241,43,12,33,204,222,93,247,231,250,120,82,75,201,152,163,19,142,219,159,176,60,63,136,68,132,44,246,0,160,100,78,103,117,19,240,190,202,136,74,104,212,85,160,228,141,66,145,192,177,81,206,85,57,208,161,187,181,91,156,175,247,186,235,57,252,5,250,89,183,104,206,51,55,249,101,221,31,118,143,138,235,142,138,235,46,25,251,46,160,147,75,246,42,73,174,219,52,28,36,241,156,149,130,179,34,152,144,107,73,9,157,221,60,191,83,148,53,169,192,74,159,18,191,121,21,68,246,12,29,32,34,200,42,167,234,194,253,67,103,175,95,206,22,239,185,134,22,92,197,60,118,191,70,172,13,199,167,185,187,20,123,49,199,35,110,32,219,167,88,48,26,159,61,119,211,202,181,48,12,88,192,172,33,146,1,86,207,153,39,80,103,207,174,107,183,234,164,15,74,51,75,40,93,6,230,101,193,105,74,17,206,212,40,65,27,173,93,24,76,94,44,250,89,127,242,108,12,30,79,70,198,179,202,131,192,124,141,108,69,92,121,89,26,43,180,115,60,32,114,229,121,99,6,197,183,197,39,105,58,106,250,67,108,74,183,232,161,244,95,122,182,148,29,5,91,73,112,124,2,7,152,153,131,133,52,31,213,107,19,93,74,54,36,186,113,54,206,91,208,58,41,102,64,139,92,218,172,75,163,49,70,56,15,85,89,137,30,67,249,247,217,192,149,2,33,241,244,17,42,43,10,29,129,173,120,214,117,37,233,92,43,43,19,138,227,217,248,104,31,97,213,28,15,36,129,149,179,214,119,205,33,247,239,142,232,150,167,44,27,114,254,134,85,112,179,24,190,15,228,52,249,117,182,92,245,205,108,208,11,28,198,37,174,214,243,158,77,57,152,243,57,150,129,245,38,3,212,54,69,122,244,56,31,222,46,174,255,15,167,183,31,241,199,39,88,87,128,123,177,226,153,70,201,97,186,25,84,123,242,32,12,15,163,224,129,160,80,121,16,218,196,122,19,201,48,173,186,100,24,129,22,228,192,46,158,27,15,211,38,19,101,100,236,111,36,216,64,182,56,76,3,173,166,225,217,81,28,250,126,144,130,129,109,170,102,202,200,234,43,104,147,207,129,237,145,95,191,3,126,109,238,151,96,239,135,95,239,143,91,239,112,188,31,159,92,107,205,6,20,162,144,1,35,35,138,213,107,14,92,237,149,171,71,197,44,37,61,144,7,33,46,75,23,19,48,169,209,56,1,91,47,192,50,246,193,59,144,137,53,186,182,176,249,191,79,24,76,204,60,238,57,21,25,91,186,132,115,29,207,92,157,13,207,7,86,82,189,127,114,157,182,195,99,187,105,187,9,140,87,239,121,172,232,31,185,162,15,206,254,6,144,158,85,23,173,29,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "d6c59cedf94c477daef17418c7544cfe",
							"BaseElements.AddReminder.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
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

		#region Class: ReadLeadDataFlowElement

		/// <exclude/>
		public class ReadLeadDataFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLeadDataFlowElement(UserConnection userConnection, LeadManagementDistribution process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLeadData";
				IsLogging = true;
				SchemaElementUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,36,21,203,146,109,201,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,63,54,150,76,19,204,254,247,202,235,108,10,57,148,210,91,65,135,153,145,222,155,55,143,209,124,239,195,71,223,70,28,107,7,109,64,58,237,108,77,20,22,141,43,13,103,121,213,20,76,54,220,50,205,65,50,107,108,137,185,203,27,173,36,161,61,116,88,147,21,189,181,62,18,234,35,118,161,190,157,127,147,198,113,66,122,239,206,201,87,115,192,14,190,45,13,36,7,167,52,106,86,21,89,195,36,54,13,83,6,12,115,78,232,166,148,74,114,52,100,213,98,11,157,73,173,145,85,198,85,76,106,80,76,59,37,24,20,38,19,194,102,80,112,78,104,139,46,110,159,142,35,134,224,135,190,158,241,53,190,121,62,38,149,107,239,205,208,78,93,79,104,135,17,174,33,30,106,2,152,161,44,12,48,35,117,154,212,97,197,64,104,203,4,52,85,94,41,228,37,175,8,53,112,140,11,45,217,89,66,45,68,248,14,237,132,103,230,217,39,141,185,200,184,42,202,132,229,194,48,41,242,140,169,82,85,204,217,210,105,20,165,214,141,189,248,245,105,242,41,246,225,106,234,112,244,230,197,118,76,254,13,99,61,155,161,143,227,208,46,212,87,231,231,55,248,20,87,115,95,174,126,172,3,197,84,95,64,228,68,167,128,155,214,99,31,183,189,25,172,239,31,86,206,211,41,65,186,35,140,62,92,92,216,62,78,208,18,58,250,135,195,31,221,218,76,33,14,221,127,52,42,77,99,38,142,180,100,103,185,203,14,90,31,142,45,60,159,243,154,188,123,156,134,248,225,51,130,93,35,242,6,81,147,59,34,50,227,74,45,211,106,41,197,153,52,34,99,144,41,149,150,178,44,138,42,71,153,75,126,71,146,138,127,224,190,221,133,47,63,251,203,31,88,85,239,223,167,234,155,194,245,5,89,207,127,35,231,180,95,4,237,79,233,252,2,246,133,21,47,202,3,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,73,77,76,241,75,204,77,181,50,180,50,212,241,1,114,66,42,11,82,227,193,34,6,86,6,58,129,165,137,57,153,105,153,169,41,206,249,121,37,137,201,37,8,25,207,20,16,5,0,82,99,140,34,63,0,0,0 })));
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
								new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"));
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

		#region Class: ReadLeadTypeFlowElement

		/// <exclude/>
		public class ReadLeadTypeFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLeadTypeFlowElement(UserConnection userConnection, LeadManagementDistribution process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLeadType";
				IsLogging = true;
				SchemaElementUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,193,106,220,48,16,134,95,101,209,161,39,107,145,45,89,146,221,99,216,148,92,210,208,166,165,144,132,32,75,163,68,32,219,27,91,166,9,102,223,189,227,117,182,133,28,74,78,133,130,17,146,172,255,159,153,79,163,249,62,140,231,33,38,24,106,111,226,8,217,116,225,106,98,185,168,84,99,24,149,185,6,42,44,115,212,232,210,81,85,152,188,210,80,50,239,4,201,58,211,66,77,86,245,206,133,68,178,144,160,29,235,155,249,143,105,26,38,200,238,253,113,241,213,62,66,107,190,45,1,128,185,6,154,162,160,162,226,56,0,0,6,240,5,53,133,80,166,244,22,180,214,100,205,133,131,42,133,102,130,10,15,56,228,92,208,170,241,150,230,130,57,193,29,175,140,50,36,139,224,211,238,121,63,192,56,134,190,171,103,248,61,191,126,217,99,150,107,236,179,62,78,109,71,178,22,146,185,50,233,177,38,6,24,136,210,26,106,69,85,46,33,20,53,188,114,148,155,70,21,74,67,46,115,69,50,107,246,105,177,37,23,142,100,206,36,243,221,196,9,142,206,115,192,28,11,206,114,93,74,212,230,220,82,193,11,70,181,212,138,122,39,125,5,92,86,85,227,78,188,62,77,1,231,97,188,156,90,24,130,125,197,14,200,175,31,234,217,246,93,26,250,184,88,95,30,143,95,195,115,90,225,190,254,250,177,22,148,112,127,17,145,67,54,141,112,22,3,116,105,215,217,222,133,238,97,245,60,28,80,210,238,205,16,198,19,133,221,211,100,34,201,134,240,240,248,87,90,103,211,152,250,246,63,42,53,195,50,209,3,155,236,152,238,210,131,46,140,251,104,94,142,235,154,124,120,154,250,244,241,11,24,183,137,56,108,207,195,48,166,205,210,175,155,222,111,176,248,41,38,180,219,216,62,70,176,203,101,111,47,1,220,38,97,6,171,150,188,137,81,147,91,98,125,46,177,121,75,170,75,235,241,157,32,145,74,48,75,161,129,162,204,189,173,114,197,182,58,7,237,170,6,168,146,13,30,202,1,219,156,229,124,233,226,70,25,201,154,198,171,109,105,101,37,21,118,185,44,64,83,81,50,142,88,241,56,56,41,45,119,78,114,87,222,18,36,240,79,234,186,185,24,63,255,236,78,47,118,101,124,183,197,221,55,27,187,8,45,94,6,222,229,59,64,28,80,112,117,10,85,207,239,193,178,72,118,93,10,233,101,125,185,245,252,30,78,135,187,133,212,221,1,191,95,243,2,190,158,223,4,0,0 })));
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
								new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888"));
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

		#region Class: ReadLeadContactFlowElement

		/// <exclude/>
		public class ReadLeadContactFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLeadContactFlowElement(UserConnection userConnection, LeadManagementDistribution process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLeadContact";
				IsLogging = true;
				SchemaElementUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,75,107,220,48,16,199,191,202,162,67,79,214,98,89,15,203,238,49,108,74,46,105,250,164,144,132,160,199,40,17,248,177,177,101,154,96,246,187,119,188,206,182,144,67,201,169,80,108,140,36,107,254,51,255,159,70,243,93,28,207,99,147,96,168,131,105,70,200,166,11,95,19,163,152,224,70,148,52,247,86,83,33,100,160,182,16,57,45,116,176,202,230,58,84,220,145,172,51,45,212,100,141,222,249,152,72,22,19,180,99,125,61,255,17,77,195,4,217,93,56,78,190,184,7,104,205,183,37,1,83,22,184,146,140,234,0,5,21,76,86,84,123,159,83,163,115,238,133,210,220,123,78,214,90,100,48,10,10,93,82,172,201,80,1,86,210,74,107,65,165,51,165,198,71,178,178,32,89,3,33,237,158,246,3,140,99,236,187,122,134,223,227,175,207,123,172,114,205,125,214,55,83,219,145,172,133,100,174,76,122,64,167,144,131,64,41,234,68,37,169,8,80,82,195,43,79,185,177,101,81,106,96,138,149,36,115,102,159,22,89,114,225,73,230,77,50,223,77,51,193,81,121,142,88,99,193,115,166,165,194,88,198,29,21,188,200,169,86,88,114,240,42,84,104,180,170,172,63,241,250,48,69,28,199,241,114,106,97,136,238,5,59,32,191,126,168,103,215,119,105,232,155,69,250,242,184,253,43,60,165,21,238,203,175,31,171,161,132,235,75,16,57,100,211,8,103,77,132,46,237,58,215,251,216,221,175,154,135,3,134,180,123,51,196,241,68,97,247,56,153,134,100,67,188,127,248,43,173,179,105,76,125,251,31,89,205,208,38,106,96,147,29,203,93,122,208,199,113,223,152,231,227,188,38,239,30,167,62,189,255,12,198,111,26,252,108,207,227,48,166,205,210,175,155,62,108,208,252,212,36,148,219,184,190,105,192,45,135,189,253,132,172,98,136,224,55,102,220,44,21,25,151,86,25,242,42,93,77,110,136,11,76,9,0,73,181,116,129,10,135,112,42,145,59,10,22,10,201,130,171,88,153,111,53,3,237,43,11,180,84,22,55,49,236,125,147,51,78,43,27,108,105,84,110,109,40,183,198,139,42,247,82,211,92,46,13,239,53,54,124,33,20,245,94,11,165,192,242,74,243,27,130,48,254,181,197,235,139,241,227,207,238,116,143,87,242,183,91,92,125,181,176,107,160,197,35,194,19,126,3,147,3,6,92,157,82,213,243,91,8,45,33,187,46,197,244,188,222,231,122,126,11,178,195,237,2,237,246,128,239,47,10,149,52,23,245,4,0,0 })));
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
								new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"));
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

		#region Class: DistributionLeadPageFlowElement

		/// <exclude/>
		public class DistributionLeadPageFlowElement : PreconfiguredPageUserTask
		{

			#region Constructors: Public

			public DistributionLeadPageFlowElement(UserConnection userConnection, LeadManagementDistribution process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "DistributionLeadPage";
				IsLogging = true;
				SchemaElementUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.LeadDistribution;
				SerializeToDB = true;
				_showExecutionPage = () => (bool)((process.ShowDistributionPage));
				_leadId = () => (Guid)((process.LeadId));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _title;
			public override LocalizableString Title {
				get {
					return _title ?? (_title = GetLocalizableString("d6c59cedf94c477daef17418c7544cfe",
						 "BaseElements.DistributionLeadPage.Parameters.Title.Value"));
				}
				set {
					_title = value;
				}
			}

			private Guid _clientUnitSchemaUId = new Guid("65a13f26-c1c8-49e6-9744-ce1c028164df");
			public override Guid ClientUnitSchemaUId {
				get {
					return _clientUnitSchemaUId;
				}
				set {
					_clientUnitSchemaUId = value;
				}
			}

			private bool _useCardProcessModule = true;
			public override bool UseCardProcessModule {
				get {
					return _useCardProcessModule;
				}
				set {
					_useCardProcessModule = value;
				}
			}

			internal Func<bool> _showExecutionPage;
			public override bool ShowExecutionPage {
				get {
					return (_showExecutionPage ?? (_showExecutionPage = () => false)).Invoke();
				}
				set {
					_showExecutionPage = () => { return value; };
				}
			}

			internal Func<Guid> _leadId;
			public virtual Guid LeadId {
				get {
					return (_leadId ?? (_leadId = () => Guid.Empty)).Invoke();
				}
				set {
					_leadId = () => { return value; };
				}
			}

			public virtual string Result {
				get;
				set;
			}

			public virtual bool RemindToOwner {
				get;
				set;
			}

			public virtual Guid LeadOwnerId {
				get;
				set;
			}

			public virtual Guid OpportunityDepartment {
				get;
				set;
			}

			#endregion

		}

		#endregion

		#region Class: SaveLeadByDefaultFlowElement

		/// <exclude/>
		public class SaveLeadByDefaultFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public SaveLeadByDefaultFlowElement(UserConnection userConnection, LeadManagementDistribution process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SaveLeadByDefault";
				IsLogging = true;
				SchemaElementUId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Owner = () => (Guid)((process.ResponsibleId));
				_recordColumnValues_RemindToOwner = () => (bool)((process.CreateReminder));
				_recordColumnValues_SalesOwner = () => (Guid)((process.DistributionLeadPage.OwnerId));
				_recordColumnValues_OpportunityDepartment = () => (Guid)((process.DistributionLeadPage.OpportunityDepartment));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_Owner", () => _recordColumnValues_Owner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_RemindToOwner", () => _recordColumnValues_RemindToOwner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_SalesOwner", () => _recordColumnValues_SalesOwner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_OpportunityDepartment", () => _recordColumnValues_OpportunityDepartment.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_Owner;
			internal Func<bool> _recordColumnValues_RemindToOwner;
			internal Func<Guid> _recordColumnValues_SalesOwner;
			internal Func<Guid> _recordColumnValues_OpportunityDepartment;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			public override Guid EntitySchemaUId {
				get {
					return _entitySchemaUId;
				}
				set {
					_entitySchemaUId = value;
				}
			}

			private bool _isMatchConditions = true;
			public override bool IsMatchConditions {
				get {
					return _isMatchConditions;
				}
				set {
					_isMatchConditions = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,79,107,220,48,16,197,191,139,14,61,89,197,178,100,75,114,143,203,182,44,148,52,208,180,20,146,37,140,165,81,86,224,63,27,75,166,9,102,191,123,181,118,54,133,28,74,233,173,224,195,104,236,247,230,55,15,121,190,247,225,163,111,35,142,181,131,54,96,54,237,108,77,132,211,166,41,154,134,10,107,56,21,96,129,170,162,212,84,200,28,65,241,178,105,242,130,100,61,116,88,147,85,189,181,62,146,204,71,236,66,125,59,255,54,141,227,132,217,189,91,14,95,205,1,59,248,182,12,96,224,148,70,77,101,153,167,41,152,70,41,3,134,58,199,117,83,9,37,24,26,178,178,96,195,36,56,224,20,25,43,18,139,49,180,1,89,80,205,19,5,151,92,88,157,88,90,116,113,251,116,28,49,4,63,244,245,140,175,245,205,243,49,81,174,179,55,67,59,117,61,201,58,140,112,13,241,80,19,192,28,69,105,128,26,161,75,42,28,74,10,92,91,202,161,145,133,84,200,42,38,73,102,224,24,207,182,100,103,73,102,33,194,119,104,39,92,156,103,159,24,11,158,51,85,86,73,203,184,161,130,23,57,85,149,146,212,217,202,105,228,149,214,141,189,228,245,105,242,169,246,225,106,234,112,244,230,37,118,76,249,13,99,61,155,161,143,227,208,158,173,175,150,207,111,240,41,174,225,190,188,250,177,46,20,83,255,44,34,167,108,10,184,105,61,246,113,219,155,193,250,254,97,245,60,157,146,164,59,194,232,195,37,133,237,227,4,45,201,70,255,112,248,99,90,155,41,196,161,251,143,86,205,210,154,201,35,93,178,5,247,124,7,173,15,199,22,158,151,115,77,222,61,78,67,252,240,25,193,174,21,121,163,168,201,29,225,185,113,149,22,156,130,82,140,10,195,115,10,185,82,233,82,86,101,41,11,20,133,96,119,36,81,252,131,247,237,46,124,249,217,95,254,129,149,122,255,62,117,223,52,174,47,202,122,254,27,156,211,254,12,180,63,165,231,23,66,164,233,35,202,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,151,75,111,27,71,12,199,191,138,176,201,209,52,230,253,208,53,233,193,64,210,26,117,154,139,237,3,103,134,108,4,232,97,236,174,83,164,130,190,123,169,181,28,219,105,227,4,185,196,69,178,135,149,52,59,127,146,75,242,55,51,218,118,207,199,15,87,212,205,187,55,212,247,56,108,120,60,126,177,233,233,248,180,223,84,26,134,227,87,155,138,203,197,223,88,150,116,138,61,174,104,164,254,45,46,175,105,120,181,24,198,163,217,67,89,119,212,61,127,63,61,237,230,231,219,238,100,164,213,31,39,77,172,231,232,93,174,152,0,163,74,224,172,87,144,83,107,16,149,66,29,42,171,90,180,136,235,102,121,189,90,191,166,17,79,113,124,215,205,183,221,100,77,12,120,147,116,180,78,180,85,105,112,74,123,49,21,2,136,78,213,88,188,119,53,117,187,163,110,168,239,104,133,147,211,59,177,211,200,41,83,134,232,85,1,71,165,64,170,88,129,217,230,18,92,114,154,234,94,124,152,127,39,60,127,118,126,50,252,246,215,154,250,179,201,238,156,113,57,208,229,177,140,126,50,240,49,57,243,109,140,133,171,119,26,52,106,4,87,60,65,105,49,130,37,103,114,117,37,216,200,187,203,103,151,123,143,109,49,92,45,241,195,219,127,59,158,188,222,76,186,122,144,248,251,211,182,23,55,245,187,232,230,23,159,171,224,225,243,38,222,135,53,252,180,124,23,221,209,69,119,182,185,238,235,222,162,221,255,184,77,231,228,65,29,46,248,143,219,237,117,99,99,146,189,198,53,254,73,253,175,226,113,146,79,143,94,226,136,147,243,55,18,247,173,225,98,178,87,81,51,68,194,44,5,10,6,82,147,228,101,157,11,219,104,13,179,153,212,191,19,83,79,235,74,15,3,211,161,144,13,94,67,98,50,224,180,207,162,111,10,48,41,219,92,72,182,53,59,233,39,207,119,193,220,118,154,140,172,175,151,203,201,193,48,189,255,190,117,15,129,31,158,188,188,87,170,123,22,54,109,193,11,106,39,235,111,73,213,174,219,237,142,238,115,210,178,183,54,104,13,210,64,14,92,48,14,114,222,103,131,90,138,104,106,41,218,61,202,137,137,153,201,146,130,152,171,2,199,73,65,65,197,192,62,52,54,206,179,96,248,68,56,201,181,89,78,193,130,162,38,156,88,155,32,101,129,37,71,78,6,27,147,83,225,203,156,188,232,9,71,154,245,180,90,172,27,245,51,222,244,179,205,143,196,78,86,37,248,194,9,20,115,149,222,151,133,39,197,152,193,56,163,228,11,114,86,241,49,118,190,58,176,167,206,14,133,22,147,32,3,46,135,40,221,219,34,20,102,134,160,131,138,134,173,210,38,61,190,199,84,197,24,115,128,162,146,149,76,154,0,88,133,134,202,173,85,227,189,205,168,190,39,59,191,44,105,69,235,113,190,181,228,67,80,178,25,146,224,12,78,170,15,185,153,6,94,169,16,178,49,170,56,218,61,132,205,39,91,21,198,6,153,154,72,36,164,105,113,5,46,161,34,50,107,195,237,203,176,73,29,199,126,81,174,199,197,102,61,187,146,6,61,254,185,77,253,136,219,148,103,229,201,196,253,235,251,38,219,84,144,102,247,236,33,185,130,129,163,182,197,61,142,26,58,133,193,49,2,42,146,181,95,145,180,163,139,194,155,207,85,55,46,37,91,254,191,162,150,140,137,114,54,37,160,16,101,25,145,3,46,160,101,11,70,43,67,236,165,53,34,126,11,106,103,184,164,97,214,22,239,23,131,140,253,100,238,235,152,243,45,57,31,138,3,237,229,84,228,26,121,89,222,229,134,44,255,28,56,196,44,171,254,83,101,238,114,247,15,50,106,29,73,160,13,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "d6c59cedf94c477daef17418c7544cfe",
							"BaseElements.SaveLeadByDefault.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordColumnValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordColumnValues", getColumnValue);
					}
					return _recordColumnValues;
				}
				set {
					_recordColumnValues = value;
				}
			}

			#endregion

		}

		#endregion

		public LeadManagementDistribution(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadManagementDistribution";
			SchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_createReminder = () => { return (bool)((DistributionLeadPage.RemindToOwner)); };
			_responsibleId = () => { return (Guid)((DistributionLeadPage.LeadOwnerId)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: LeadManagementDistribution, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: LeadManagementDistribution, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual Guid LeadId {
			get;
			set;
		}

		private Func<bool> _createReminder;
		public virtual bool CreateReminder {
			get {
				return (_createReminder ?? (_createReminder = () => false)).Invoke();
			}
			set {
				_createReminder = () => { return value; };
			}
		}

		private Func<Guid> _responsibleId;
		public virtual Guid ResponsibleId {
			get {
				return (_responsibleId ?? (_responsibleId = () => Guid.Empty)).Invoke();
			}
			set {
				_responsibleId = () => { return value; };
			}
		}

		public virtual bool ShowDistributionPage {
			get;
			set;
		}

		private ProcessLeadDistribution _leadDistribution;
		public ProcessLeadDistribution LeadDistribution {
			get {
				return _leadDistribution ?? ((_leadDistribution) = new ProcessLeadDistribution(UserConnection, this));
			}
		}

		private ProcessFlowElement _start;
		public ProcessFlowElement Start {
			get {
				return _start ?? (_start = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "Start",
					SchemaElementUId = new Guid("7a92b7ab-7ed4-4582-8e65-9e766afb2829"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessTerminateEvent _terminateHandoff;
		public ProcessTerminateEvent TerminateHandoff {
			get {
				return _terminateHandoff ?? (_terminateHandoff = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateHandoff",
					SchemaElementUId = new Guid("e0fc6ab2-437d-4492-a531-191b3013d93d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayIsLeadSet;
		public ProcessExclusiveGateway ExclusiveGatewayIsLeadSet {
			get {
				return _exclusiveGatewayIsLeadSet ?? (_exclusiveGatewayIsLeadSet = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayIsLeadSet",
					SchemaElementUId = new Guid("0788b001-b01e-467d-8078-6e3f56e8a438"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewayIsLeadSet.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessTerminateEvent _terminateLeadIsNotSet;
		public ProcessTerminateEvent TerminateLeadIsNotSet {
			get {
				return _terminateLeadIsNotSet ?? (_terminateLeadIsNotSet = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateLeadIsNotSet",
					SchemaElementUId = new Guid("28c1efc4-e3b9-4c23-8307-4e19e53453b3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private SaveLeadHandoffFlowElement _saveLeadHandoff;
		public SaveLeadHandoffFlowElement SaveLeadHandoff {
			get {
				return _saveLeadHandoff ?? (_saveLeadHandoff = new SaveLeadHandoffFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private SaveLeadNoInterestFlowElement _saveLeadNoInterest;
		public SaveLeadNoInterestFlowElement SaveLeadNoInterest {
			get {
				return _saveLeadNoInterest ?? (_saveLeadNoInterest = new SaveLeadNoInterestFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessTerminateEvent _terminateNoInterest;
		public ProcessTerminateEvent TerminateNoInterest {
			get {
				return _terminateNoInterest ?? (_terminateNoInterest = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateNoInterest",
					SchemaElementUId = new Guid("721db265-d834-462e-bd2d-515b03c3eaf9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessTerminateEvent _terminateContinueDistribution;
		public ProcessTerminateEvent TerminateContinueDistribution {
			get {
				return _terminateContinueDistribution ?? (_terminateContinueDistribution = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateContinueDistribution",
					SchemaElementUId = new Guid("cb6102fb-8548-4fa4-aae5-b307af30608f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private AddReminderFlowElement _addReminder;
		public AddReminderFlowElement AddReminder {
			get {
				return _addReminder ?? (_addReminder = new AddReminderFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadLeadDataFlowElement _readLeadData;
		public ReadLeadDataFlowElement ReadLeadData {
			get {
				return _readLeadData ?? (_readLeadData = new ReadLeadDataFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadLeadTypeFlowElement _readLeadType;
		public ReadLeadTypeFlowElement ReadLeadType {
			get {
				return _readLeadType ?? (_readLeadType = new ReadLeadTypeFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadLeadContactFlowElement _readLeadContact;
		public ReadLeadContactFlowElement ReadLeadContact {
			get {
				return _readLeadContact ?? (_readLeadContact = new ReadLeadContactFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway2;
		public ProcessExclusiveGateway ExclusiveGateway2 {
			get {
				return _exclusiveGateway2 ?? (_exclusiveGateway2 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway2",
					SchemaElementUId = new Guid("68552fe0-b6b1-47de-9bdd-6c06dbdf6839"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway2.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private DistributionLeadPageFlowElement _distributionLeadPage;
		public DistributionLeadPageFlowElement DistributionLeadPage {
			get {
				return _distributionLeadPage ?? (_distributionLeadPage = new DistributionLeadPageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("fe8039af-a364-42b4-bf9d-dbe3a1991c15"),
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

		private SaveLeadByDefaultFlowElement _saveLeadByDefault;
		public SaveLeadByDefaultFlowElement SaveLeadByDefault {
			get {
				return _saveLeadByDefault ?? (_saveLeadByDefault = new SaveLeadByDefaultFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessConditionalFlow _conditionalFlowLeadUndefined;
		public ProcessConditionalFlow ConditionalFlowLeadUndefined {
			get {
				return _conditionalFlowLeadUndefined ?? (_conditionalFlowLeadUndefined = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlowLeadUndefined",
					SchemaElementUId = new Guid("5805d2d7-5516-4f97-9107-0c6b5c4bbc5c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlowCreateReminder;
		public ProcessConditionalFlow ConditionalFlowCreateReminder {
			get {
				return _conditionalFlowCreateReminder ?? (_conditionalFlowCreateReminder = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlowCreateReminder",
					SchemaElementUId = new Guid("97e8e894-d220-43dc-9cfa-0e37f8166e2a"),
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
					SchemaElementUId = new Guid("f5da7633-709e-40ac-ab2f-51d79b4f1e75"),
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
					SchemaElementUId = new Guid("15c1b993-b41b-4b3d-be24-96f8a835c457"),
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
			FlowElements[Start.SchemaElementUId] = new Collection<ProcessFlowElement> { Start };
			FlowElements[TerminateHandoff.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateHandoff };
			FlowElements[ExclusiveGatewayIsLeadSet.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayIsLeadSet };
			FlowElements[TerminateLeadIsNotSet.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateLeadIsNotSet };
			FlowElements[SaveLeadHandoff.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveLeadHandoff };
			FlowElements[SaveLeadNoInterest.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveLeadNoInterest };
			FlowElements[TerminateNoInterest.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateNoInterest };
			FlowElements[TerminateContinueDistribution.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateContinueDistribution };
			FlowElements[AddReminder.SchemaElementUId] = new Collection<ProcessFlowElement> { AddReminder };
			FlowElements[ReadLeadData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadData };
			FlowElements[ReadLeadType.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadType };
			FlowElements[ReadLeadContact.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadContact };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[DistributionLeadPage.SchemaElementUId] = new Collection<ProcessFlowElement> { DistributionLeadPage };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[SaveLeadByDefault.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveLeadByDefault };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayIsLeadSet", e.Context.SenderName));
						break;
					case "TerminateHandoff":
						CompleteProcess();
						break;
					case "ExclusiveGatewayIsLeadSet":
						if (ConditionalFlowLeadUndefinedExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateLeadIsNotSet", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("DistributionLeadPage", e.Context.SenderName));
						break;
					case "TerminateLeadIsNotSet":
						CompleteProcess();
						break;
					case "SaveLeadHandoff":
						if (ConditionalFlowCreateReminderExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadData", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway2", e.Context.SenderName));
						break;
					case "SaveLeadNoInterest":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateNoInterest", e.Context.SenderName));
						break;
					case "TerminateNoInterest":
						CompleteProcess();
						break;
					case "TerminateContinueDistribution":
						CompleteProcess();
						break;
					case "AddReminder":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway2", e.Context.SenderName));
						break;
					case "ReadLeadData":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadContact", e.Context.SenderName));
						break;
					case "ReadLeadType":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddReminder", e.Context.SenderName));
						break;
					case "ReadLeadContact":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadType", e.Context.SenderName));
						break;
					case "ExclusiveGateway2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateHandoff", e.Context.SenderName));
						break;
					case "DistributionLeadPage":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SaveLeadHandoff", e.Context.SenderName));
							break;
						}
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SaveLeadNoInterest", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SaveLeadByDefault", e.Context.SenderName));
						break;
					case "SaveLeadByDefault":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateContinueDistribution", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlowLeadUndefinedExpressionExecute() {
			bool result = Convert.ToBoolean((LeadId) == Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGatewayIsLeadSet", "ConditionalFlowLeadUndefined", "(LeadId) == Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlowCreateReminderExpressionExecute() {
			bool result = Convert.ToBoolean((CreateReminder));
			Log.InfoFormat(ConditionalExpressionLogMessage, "SaveLeadHandoff", "ConditionalFlowCreateReminder", "(CreateReminder)", result);
			return result;
		}

		private bool ConditionalFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean((DistributionLeadPage.Result) == "TransferToSale");
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalFlow2", "(DistributionLeadPage.Result) == \"TransferToSale\"", result);
			return result;
		}

		private bool ConditionalFlow3ExpressionExecute() {
			bool result = Convert.ToBoolean((DistributionLeadPage.Result) == "NotInteresting");
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalFlow3", "(DistributionLeadPage.Result) == \"NotInteresting\"", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("DistributionLeadPage.LeadId")) {
				writer.WriteValue("DistributionLeadPage.LeadId", DistributionLeadPage.LeadId, Guid.Empty);
			}
			if (!HasMapping("DistributionLeadPage.Result")) {
				writer.WriteValue("DistributionLeadPage.Result", DistributionLeadPage.Result, null);
			}
			if (!HasMapping("DistributionLeadPage.RemindToOwner")) {
				writer.WriteValue("DistributionLeadPage.RemindToOwner", DistributionLeadPage.RemindToOwner, false);
			}
			if (!HasMapping("DistributionLeadPage.LeadOwnerId")) {
				writer.WriteValue("DistributionLeadPage.LeadOwnerId", DistributionLeadPage.LeadOwnerId, Guid.Empty);
			}
			if (!HasMapping("DistributionLeadPage.OpportunityDepartment")) {
				writer.WriteValue("DistributionLeadPage.OpportunityDepartment", DistributionLeadPage.OpportunityDepartment, Guid.Empty);
			}
			if (!HasMapping("LeadId")) {
				writer.WriteValue("LeadId", LeadId, Guid.Empty);
			}
			if (!HasMapping("ShowDistributionPage")) {
				writer.WriteValue("ShowDistributionPage", ShowDistributionPage, false);
			}
			if (!HasMapping("CreateReminder")) {
				writer.WriteValue("CreateReminder", CreateReminder, false);
			}
			if (!HasMapping("ResponsibleId")) {
				writer.WriteValue("ResponsibleId", ResponsibleId, Guid.Empty);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("Start", string.Empty));
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
			MetaPathParameterValues.Add("30cf6943-a881-4c30-a088-ff65572e4241", () => LeadId);
			MetaPathParameterValues.Add("9cd3f863-0eda-4338-895e-97f82adfe406", () => CreateReminder);
			MetaPathParameterValues.Add("77bfc541-1a1a-4b5e-bd77-3e429c4b637f", () => ResponsibleId);
			MetaPathParameterValues.Add("51139bfa-4db4-45f7-aa2f-590d604f8469", () => ShowDistributionPage);
			MetaPathParameterValues.Add("188fdd38-de95-4c10-8ab3-34128e7e82c9", () => SaveLeadHandoff.EntitySchemaUId);
			MetaPathParameterValues.Add("9cad839f-9e67-4603-a369-f4c25fce8216", () => SaveLeadHandoff.IsMatchConditions);
			MetaPathParameterValues.Add("51b908e1-277f-4fd9-954b-c200b506502f", () => SaveLeadHandoff.DataSourceFilters);
			MetaPathParameterValues.Add("e91b04af-7a52-4f54-a02b-32ac50a9f8ad", () => SaveLeadHandoff.RecordColumnValues);
			MetaPathParameterValues.Add("a147d2f0-eb4f-4a91-bda3-6b4d5423014b", () => SaveLeadNoInterest.EntitySchemaUId);
			MetaPathParameterValues.Add("d71bf98b-10c9-4b4e-9da3-927f4c707df2", () => SaveLeadNoInterest.IsMatchConditions);
			MetaPathParameterValues.Add("8b04704d-b57f-4aed-8143-0ba2dc774953", () => SaveLeadNoInterest.DataSourceFilters);
			MetaPathParameterValues.Add("63cb5219-81b3-4e2c-8f12-bb56e164296d", () => SaveLeadNoInterest.RecordColumnValues);
			MetaPathParameterValues.Add("55dd5f60-cee9-44b6-8f68-b543a4174bf2", () => AddReminder.EntitySchemaId);
			MetaPathParameterValues.Add("7a3aa063-9af4-482e-adbf-9312dad8b0bf", () => AddReminder.DataSourceFilters);
			MetaPathParameterValues.Add("2e6f433c-09c2-46dc-89d2-80e6a8f6ebda", () => AddReminder.RecordAddMode);
			MetaPathParameterValues.Add("ddff7e72-873c-4e34-a274-b1fe98dc4dc5", () => AddReminder.FilterEntitySchemaId);
			MetaPathParameterValues.Add("95dfe792-7d3e-4db6-8add-2effff3ca7f4", () => AddReminder.RecordDefValues);
			MetaPathParameterValues.Add("2af26cad-fdd2-4138-9712-bb3c00009344", () => AddReminder.RecordId);
			MetaPathParameterValues.Add("88b815f6-9ed2-474a-a40e-f96b169054b4", () => ReadLeadData.DataSourceFilters);
			MetaPathParameterValues.Add("7c774b4b-6e9a-4ef1-bd4d-4af18e1f5a68", () => ReadLeadData.ResultType);
			MetaPathParameterValues.Add("4a5fff69-b63a-49e0-a7c9-da42ff12623b", () => ReadLeadData.ReadSomeTopRecords);
			MetaPathParameterValues.Add("1b730802-2250-4ca2-84c5-b50b5d4a07fb", () => ReadLeadData.NumberOfRecords);
			MetaPathParameterValues.Add("be3ad5ec-1ac1-4d88-8421-74079d80259b", () => ReadLeadData.FunctionType);
			MetaPathParameterValues.Add("19076150-3efa-4513-be4e-b624b7233322", () => ReadLeadData.AggregationColumnName);
			MetaPathParameterValues.Add("9adb2ee5-70ec-4c6c-b1ab-4cb1ddf4c59b", () => ReadLeadData.OrderInfo);
			MetaPathParameterValues.Add("81e8d9be-76bf-41e2-a013-9bfb7a60bbf7", () => ReadLeadData.ResultEntity);
			MetaPathParameterValues.Add("0a4b4eb8-5619-4c19-a817-49e7435ddac0", () => ReadLeadData.ResultCount);
			MetaPathParameterValues.Add("18ee65b6-9004-44b1-b810-660c4b69eb54", () => ReadLeadData.ResultIntegerFunction);
			MetaPathParameterValues.Add("2ba36ea2-087d-4183-8f2e-029d86d94b6b", () => ReadLeadData.ResultFloatFunction);
			MetaPathParameterValues.Add("39c22bae-af9c-474a-8c12-e087a1cc5bcc", () => ReadLeadData.ResultDateTimeFunction);
			MetaPathParameterValues.Add("befd9ddf-c017-4e87-bf55-98e25f140075", () => ReadLeadData.ResultRowsCount);
			MetaPathParameterValues.Add("2fd8069c-26a9-41c0-9022-20c047525340", () => ReadLeadData.CanReadUncommitedData);
			MetaPathParameterValues.Add("b92dc5ab-c714-451b-b938-04990fc76593", () => ReadLeadData.ResultEntityCollection);
			MetaPathParameterValues.Add("904a1de6-b8cd-43d7-a193-0a8234806d6f", () => ReadLeadData.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("addb84e6-59ea-4d30-acaf-3f26b8c94365", () => ReadLeadData.IgnoreDisplayValues);
			MetaPathParameterValues.Add("85876f5f-4440-4fe1-bca9-78939b0740ff", () => ReadLeadData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("cf464302-caaf-4d4f-b723-4fe3c28b0aeb", () => ReadLeadData.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("ca3d3049-0f26-41a3-bca2-dd669a7d3396", () => ReadLeadType.DataSourceFilters);
			MetaPathParameterValues.Add("9bb7fdf0-23d9-4a53-9bfc-b65d5b2b58ef", () => ReadLeadType.ResultType);
			MetaPathParameterValues.Add("1fc1bf95-66f6-437e-ae96-ab0226deef9f", () => ReadLeadType.ReadSomeTopRecords);
			MetaPathParameterValues.Add("b6eaed28-95a3-4e02-bc92-584da91d9666", () => ReadLeadType.NumberOfRecords);
			MetaPathParameterValues.Add("8af81470-64e6-4c25-bc4e-996386dd37c1", () => ReadLeadType.FunctionType);
			MetaPathParameterValues.Add("876c91d3-f5fd-430b-99a7-6da066af2251", () => ReadLeadType.AggregationColumnName);
			MetaPathParameterValues.Add("a511d00e-3b57-438c-ad43-a0b965ac41ff", () => ReadLeadType.OrderInfo);
			MetaPathParameterValues.Add("d5067126-b12c-401d-83cc-53d80a232257", () => ReadLeadType.ResultEntity);
			MetaPathParameterValues.Add("c25ddf34-5ec7-43ef-9f1b-1f022d5afa06", () => ReadLeadType.ResultCount);
			MetaPathParameterValues.Add("39e87f5c-2965-45a4-8ce7-4446e1173001", () => ReadLeadType.ResultIntegerFunction);
			MetaPathParameterValues.Add("3aec9151-bb18-4f05-9f98-6ef24b8eb8fa", () => ReadLeadType.ResultFloatFunction);
			MetaPathParameterValues.Add("8319a4e6-2ecb-470d-b2fd-9af8514e9ab2", () => ReadLeadType.ResultDateTimeFunction);
			MetaPathParameterValues.Add("0e55a545-db7b-429c-8850-c3c910df6b27", () => ReadLeadType.ResultRowsCount);
			MetaPathParameterValues.Add("d246ad4e-36de-4230-bc79-a36f43b1befe", () => ReadLeadType.CanReadUncommitedData);
			MetaPathParameterValues.Add("7ad11547-1b9b-4507-b7ff-0d224aa61262", () => ReadLeadType.ResultEntityCollection);
			MetaPathParameterValues.Add("5bfef119-7795-4c1c-8d01-0d38138f2a41", () => ReadLeadType.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("3e1d582a-dce9-475f-9eed-bc65b2d11830", () => ReadLeadType.IgnoreDisplayValues);
			MetaPathParameterValues.Add("13ef4b43-d4fe-40b3-833c-6cfe1c96e0f4", () => ReadLeadType.ResultCompositeObjectList);
			MetaPathParameterValues.Add("35b7b87e-d9bf-4617-b784-27beef5fa487", () => ReadLeadType.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("fe828bdd-0b5b-4b21-8d0d-7fe8bbb6c978", () => ReadLeadContact.DataSourceFilters);
			MetaPathParameterValues.Add("b4af7ceb-60b9-467c-a8b3-81953d377341", () => ReadLeadContact.ResultType);
			MetaPathParameterValues.Add("311fcede-bca4-4fec-9a42-0f943fe03159", () => ReadLeadContact.ReadSomeTopRecords);
			MetaPathParameterValues.Add("4f32f247-07f2-471b-ba49-b42cae200cf0", () => ReadLeadContact.NumberOfRecords);
			MetaPathParameterValues.Add("d72c0941-da6e-42f6-b7a5-0b3ffe8b2c2e", () => ReadLeadContact.FunctionType);
			MetaPathParameterValues.Add("3356dca2-6b01-46e0-9fe2-d0de44ff97b0", () => ReadLeadContact.AggregationColumnName);
			MetaPathParameterValues.Add("d550d767-aeda-4cf2-9b2a-90c7c38be81b", () => ReadLeadContact.OrderInfo);
			MetaPathParameterValues.Add("fff72291-b74e-4830-8333-56ad140e6e7c", () => ReadLeadContact.ResultEntity);
			MetaPathParameterValues.Add("05f02083-70af-4052-8ee7-2b228747244c", () => ReadLeadContact.ResultCount);
			MetaPathParameterValues.Add("123bb774-23e8-4cbe-a707-c0bf2149c012", () => ReadLeadContact.ResultIntegerFunction);
			MetaPathParameterValues.Add("a43adf8a-3d3f-4d55-bbb1-030b98ca7464", () => ReadLeadContact.ResultFloatFunction);
			MetaPathParameterValues.Add("2a298fa9-f151-46ad-b486-c3c3bcb89af4", () => ReadLeadContact.ResultDateTimeFunction);
			MetaPathParameterValues.Add("51b3ba73-2cd0-43a5-b1bb-d655502ea451", () => ReadLeadContact.ResultRowsCount);
			MetaPathParameterValues.Add("bd94e2da-67c7-4c33-985e-1f6fdecc4562", () => ReadLeadContact.CanReadUncommitedData);
			MetaPathParameterValues.Add("53665a2a-42d9-47f3-8bf4-e4ebbd2e10f3", () => ReadLeadContact.ResultEntityCollection);
			MetaPathParameterValues.Add("f382eb7c-1c7a-4c11-93b3-5b6271585801", () => ReadLeadContact.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("377fdd7e-2835-4e98-a892-93bd77cfe77f", () => ReadLeadContact.IgnoreDisplayValues);
			MetaPathParameterValues.Add("c86054c5-11bd-442c-8cad-f413a456d299", () => ReadLeadContact.ResultCompositeObjectList);
			MetaPathParameterValues.Add("812b0c07-934e-4b42-92df-0fb9f4091dad", () => ReadLeadContact.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("bbe769c2-34d8-4a8b-a580-a9e4311e6053", () => DistributionLeadPage.Title);
			MetaPathParameterValues.Add("5160bb63-99ee-4be0-ad4e-f804a2c25915", () => DistributionLeadPage.Recommendation);
			MetaPathParameterValues.Add("2021bd48-f45e-4cd3-b993-7b97a0c3308d", () => DistributionLeadPage.ClientUnitSchemaUId);
			MetaPathParameterValues.Add("1905b493-d577-4148-a465-5b25ff5f0ab4", () => DistributionLeadPage.EntityId);
			MetaPathParameterValues.Add("702a610c-eae3-442a-b9e5-1eae1657abca", () => DistributionLeadPage.EntryPointId);
			MetaPathParameterValues.Add("ab6017ca-8f69-4ec1-95d6-57eb04cec232", () => DistributionLeadPage.EntitySchemaUId);
			MetaPathParameterValues.Add("1babcc34-fbcc-4e3e-84fe-432c05fdbbe5", () => DistributionLeadPage.UseCardProcessModule);
			MetaPathParameterValues.Add("583c0a7d-9ed9-49b6-919b-fb6caaff12fd", () => DistributionLeadPage.OwnerId);
			MetaPathParameterValues.Add("3aeda084-6af5-44ea-8738-d38edc340131", () => DistributionLeadPage.ShowExecutionPage);
			MetaPathParameterValues.Add("63033799-a11b-4b1e-9c2b-6e17977e2c43", () => DistributionLeadPage.InformationOnStep);
			MetaPathParameterValues.Add("809907b4-6caf-4cda-8cd8-58f9c1196633", () => DistributionLeadPage.IsRunning);
			MetaPathParameterValues.Add("f9aec3cc-c5b5-4b0b-a7b8-b1678e0065cc", () => DistributionLeadPage.Template);
			MetaPathParameterValues.Add("284418dc-2d40-480b-8a88-4eadf9076834", () => DistributionLeadPage.Module);
			MetaPathParameterValues.Add("6c9b11d3-782e-48a9-bdbb-1e8ce5b6188c", () => DistributionLeadPage.PressedButtonCode);
			MetaPathParameterValues.Add("1301bffa-691c-4e8f-b9a8-e3c3f257668c", () => DistributionLeadPage.Url);
			MetaPathParameterValues.Add("345b747f-6492-4686-a503-0062acd716e0", () => DistributionLeadPage.LeadId);
			MetaPathParameterValues.Add("a9e78508-ae1b-4141-abe0-24ed11eadb13", () => DistributionLeadPage.Result);
			MetaPathParameterValues.Add("cd5eefc4-6c19-4719-be10-6babbc9acc6e", () => DistributionLeadPage.RemindToOwner);
			MetaPathParameterValues.Add("0d01d7bb-ccf9-4184-a64f-953b68988ea4", () => DistributionLeadPage.LeadOwnerId);
			MetaPathParameterValues.Add("8227a76e-e673-40a1-a3f3-2102ef5efe7a", () => DistributionLeadPage.OpportunityDepartment);
			MetaPathParameterValues.Add("560bc47f-ebc5-4687-aa0c-08705e061a9a", () => SaveLeadByDefault.EntitySchemaUId);
			MetaPathParameterValues.Add("c4e20e54-2a71-4e75-a167-24858aec6fcb", () => SaveLeadByDefault.IsMatchConditions);
			MetaPathParameterValues.Add("ba1c792f-b05d-43b6-b1d4-1f6f092ae9d7", () => SaveLeadByDefault.DataSourceFilters);
			MetaPathParameterValues.Add("f3fd0d58-28e8-457f-8737-49c12cc4cc1d", () => SaveLeadByDefault.RecordColumnValues);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "DistributionLeadPage.LeadId":
					DistributionLeadPage.LeadId = reader.GetValue<System.Guid>();
				break;
				case "DistributionLeadPage.Result":
					DistributionLeadPage.Result = reader.GetValue<System.String>();
				break;
				case "DistributionLeadPage.RemindToOwner":
					DistributionLeadPage.RemindToOwner = reader.GetValue<System.Boolean>();
				break;
				case "DistributionLeadPage.LeadOwnerId":
					DistributionLeadPage.LeadOwnerId = reader.GetValue<System.Guid>();
				break;
				case "DistributionLeadPage.OpportunityDepartment":
					DistributionLeadPage.OpportunityDepartment = reader.GetValue<System.Guid>();
				break;
				case "LeadId":
					if (!hasValueToRead) break;
					LeadId = reader.GetValue<System.Guid>();
				break;
				case "ShowDistributionPage":
					if (!hasValueToRead) break;
					ShowDistributionPage = reader.GetValue<System.Boolean>();
				break;
				case "CreateReminder":
					if (!hasValueToRead) break;
					CreateReminder = reader.GetValue<System.Boolean>();
				break;
				case "ResponsibleId":
					if (!hasValueToRead) break;
					ResponsibleId = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

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
			var cloneItem = (LeadManagementDistribution)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

