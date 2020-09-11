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

	#region Class: LeadManagementDistribution78Schema

	/// <exclude/>
	public class LeadManagementDistribution78Schema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LeadManagementDistribution78Schema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LeadManagementDistribution78Schema(LeadManagementDistribution78Schema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LeadManagementDistribution78";
			UId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe");
			CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.8.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"LeadManagementDistribution78";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			UseForceCompile = true;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe");
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"CreateReminder",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{3e566048-ef49-45bf-9d2d-500669220b4e}].[Parameter:{cd5eefc4-6c19-4719-be10-6babbc9acc6e}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateResponsibleIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("77bfc541-1a1a-4b5e-bd77-3e429c4b637f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"ResponsibleId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{3e566048-ef49-45bf-9d2d-500669220b4e}].[Parameter:{0d01d7bb-ccf9-4184-a64f-953b68988ea4}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateShowDistributionPageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("51139bfa-4db4-45f7-aa2f-590d604f8469"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"ShowDistributionPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"false",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateNotificationTemplateParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("32a9ba6f-4045-4aad-9a53-b618b30c6a99"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"NotificationTemplate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateLeadIdParameter());
			Parameters.Add(CreateCreateReminderParameter());
			Parameters.Add(CreateResponsibleIdParameter());
			Parameters.Add(CreateShowDistributionPageParameter());
			Parameters.Add(CreateNotificationTemplateParameter());
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,128,162,168,151,111,69,234,22,1,138,38,64,140,92,170,28,214,210,202,38,170,23,72,58,173,107,248,223,187,20,109,213,41,92,196,237,165,209,73,28,12,103,103,150,187,187,160,108,192,152,207,208,98,48,11,22,168,53,152,190,182,215,31,84,99,81,127,212,253,102,8,174,2,131,90,65,163,126,96,229,241,121,165,236,123,176,64,87,118,197,47,133,34,152,21,231,53,138,224,170,8,148,197,214,16,135,174,64,194,81,100,18,89,28,73,206,100,12,41,91,10,89,177,48,197,88,138,40,170,179,92,122,230,159,196,111,250,118,0,141,190,198,40,95,143,191,139,237,224,168,33,1,229,72,81,166,239,14,96,228,76,152,121,7,203,6,43,58,91,189,65,130,172,86,45,165,193,133,106,241,30,52,213,114,58,189,131,136,84,67,99,28,171,193,218,206,191,15,26,141,81,125,247,154,185,102,211,118,167,108,18,192,233,120,176,195,71,143,142,121,15,118,61,74,220,146,173,253,232,242,221,106,165,113,5,86,61,159,154,248,138,219,145,119,89,255,232,66,69,175,244,8,205,6,79,106,190,76,114,3,131,245,129,124,121,34,104,181,90,95,156,117,234,216,107,113,5,129,195,145,124,161,230,217,12,34,33,240,217,1,94,229,248,91,4,95,110,205,221,183,14,245,67,185,198,22,124,215,158,174,9,253,13,152,244,103,187,136,151,117,146,203,136,65,150,133,76,150,17,103,192,179,140,213,117,18,199,169,64,41,100,184,127,242,62,148,25,26,216,62,78,229,62,33,248,134,185,190,209,57,227,117,152,66,10,12,185,136,153,148,73,197,96,89,69,12,243,144,158,37,207,151,60,78,233,125,221,231,158,161,95,169,18,154,187,1,53,28,94,128,159,31,208,23,147,237,194,235,190,183,62,210,212,188,201,203,113,68,120,37,150,2,64,50,145,200,148,201,202,5,203,203,204,217,170,99,94,165,192,75,32,51,180,221,174,191,15,253,70,151,135,109,50,126,173,255,105,93,255,195,18,254,205,94,157,157,236,75,38,245,173,204,224,155,153,180,125,176,255,9,209,204,1,60,60,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,151,91,111,219,86,12,199,191,138,161,246,49,52,206,253,226,215,118,192,2,164,91,176,116,125,73,242,112,46,228,106,204,182,2,73,238,208,25,254,238,163,28,187,137,131,53,201,48,12,93,129,248,65,150,142,197,63,41,146,63,29,122,211,188,30,62,223,96,51,107,222,99,215,165,190,165,97,250,166,237,112,122,222,181,5,251,126,122,214,150,180,152,255,153,242,2,207,83,151,150,56,96,247,33,45,214,216,159,205,251,225,100,114,108,214,156,52,175,63,237,126,109,102,151,155,230,116,192,229,175,167,149,213,179,141,94,217,96,32,38,202,96,82,13,144,98,73,124,230,141,166,168,68,174,129,141,75,187,88,47,87,239,112,72,231,105,248,216,204,54,205,78,109,20,40,162,168,234,4,216,164,43,152,96,4,164,100,16,138,19,152,188,119,168,132,107,182,39,77,95,62,226,50,237,156,222,25,27,153,40,68,140,224,173,96,239,152,51,132,146,10,16,233,152,29,139,73,44,163,241,254,254,59,195,203,87,103,109,251,251,250,102,170,148,54,178,84,9,54,107,13,166,176,251,40,164,4,71,222,69,141,228,208,152,105,193,236,69,214,5,98,176,196,49,58,15,9,125,129,16,40,214,234,165,112,33,188,186,30,29,213,121,127,179,72,159,63,124,213,223,25,166,58,233,135,244,27,78,127,76,171,218,18,77,134,118,210,167,5,246,183,10,55,71,197,184,175,177,185,186,173,233,85,51,187,250,90,85,247,223,23,187,100,29,215,245,97,73,175,154,147,171,230,162,93,119,101,84,212,124,241,246,94,240,59,39,187,91,30,92,30,106,200,43,171,245,98,177,95,121,155,134,116,184,241,176,220,214,57,205,177,158,174,46,14,165,219,169,136,253,7,254,230,112,248,220,198,246,111,204,222,165,21,231,184,251,137,19,112,23,251,151,40,223,115,26,15,194,89,69,43,188,36,240,152,34,247,144,83,16,170,76,16,101,204,164,189,86,68,106,103,253,11,18,118,184,42,120,28,216,115,58,104,111,223,239,178,61,194,179,143,107,76,213,182,217,110,79,238,35,197,98,206,27,79,252,104,18,193,232,202,221,22,68,0,95,13,161,183,104,114,42,143,34,101,85,144,94,155,192,193,8,9,70,72,11,201,59,7,37,75,81,124,182,214,148,240,95,32,117,121,218,255,252,199,10,187,219,252,204,40,45,122,188,158,242,234,131,133,47,125,57,219,120,159,169,88,35,65,38,78,185,201,22,33,87,239,65,163,81,177,152,236,180,167,237,245,147,108,141,80,181,163,235,23,134,190,75,134,164,203,168,157,149,16,8,21,24,105,35,219,87,49,246,189,174,198,5,93,171,254,71,12,229,196,225,184,200,228,24,18,99,64,30,34,58,110,106,101,10,81,52,57,203,248,40,67,202,71,66,141,2,124,44,44,64,65,0,107,18,144,117,149,148,177,100,98,249,159,48,20,75,213,20,156,6,129,149,25,210,58,64,136,12,82,244,20,84,170,132,70,184,167,25,122,211,97,26,112,210,225,114,190,170,216,77,168,237,94,144,250,134,72,69,145,157,205,20,64,16,21,70,130,223,145,193,251,8,202,40,193,39,137,162,240,143,33,245,236,192,158,139,148,211,60,235,161,227,86,214,138,183,37,43,28,195,149,50,104,226,241,71,88,157,179,149,143,34,149,140,72,206,80,130,196,147,29,111,75,232,32,26,207,42,54,22,89,41,231,168,233,91,34,245,195,2,151,184,26,102,27,141,214,57,193,251,39,50,229,252,164,153,32,86,85,193,10,225,92,84,60,211,26,220,30,51,24,148,242,188,199,34,240,155,134,135,0,145,36,36,77,26,148,20,10,201,114,137,124,122,154,65,238,244,161,155,231,245,48,111,87,147,155,113,70,188,24,7,195,73,157,127,154,247,188,246,130,226,119,185,187,217,26,140,117,217,128,180,188,161,152,138,22,178,224,3,255,99,146,130,156,143,182,60,137,226,245,246,47,98,169,118,174,210,13,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,19,49,20,253,151,89,215,149,103,236,121,101,135,74,64,149,16,173,212,168,27,166,139,27,251,78,98,49,47,217,78,33,68,249,119,236,113,50,164,40,168,129,13,245,202,62,58,62,247,220,215,46,18,13,24,243,25,90,140,102,209,2,181,6,211,215,246,250,131,106,44,234,143,186,223,12,209,85,100,80,43,104,212,15,148,1,159,75,101,223,131,5,247,101,87,253,82,168,162,89,117,94,163,138,174,170,72,89,108,141,227,184,47,172,164,89,94,148,72,18,42,19,194,33,19,164,204,139,156,228,200,227,36,47,75,25,39,44,48,255,36,126,211,183,3,104,12,49,70,249,122,188,46,182,131,167,198,14,16,35,69,153,190,59,128,204,155,48,243,14,150,13,74,247,182,122,131,14,178,90,181,46,27,92,168,22,239,65,187,88,94,167,247,144,35,213,208,24,207,106,176,182,243,239,131,70,99,84,223,189,102,174,217,180,221,41,219,9,224,244,60,216,161,163,71,207,188,7,187,30,37,110,157,173,253,232,242,221,106,165,113,5,86,61,159,154,248,138,219,145,119,89,253,220,7,233,186,244,8,205,6,79,98,190,204,228,6,6,27,18,10,225,29,65,171,213,250,226,92,167,138,189,150,110,226,192,225,72,190,80,243,108,14,73,230,192,103,15,4,149,227,181,138,190,220,154,187,111,29,234,7,177,198,22,66,213,158,174,29,250,27,48,233,207,118,140,138,58,43,57,35,80,20,49,225,130,81,2,180,40,72,93,103,105,154,39,200,19,30,239,159,130,15,101,134,6,182,143,83,184,79,8,161,96,190,110,238,237,218,64,11,73,129,8,81,46,9,79,101,73,150,76,166,36,97,144,83,202,249,50,142,133,235,175,63,190,13,253,74,9,104,238,6,212,112,232,0,61,63,160,47,38,219,39,175,251,222,134,148,166,226,77,94,142,35,66,83,89,32,43,24,137,145,213,132,103,89,66,202,52,78,137,20,69,46,120,206,24,230,75,103,198,109,183,175,239,67,191,209,226,176,77,38,172,245,63,173,235,127,88,194,191,217,171,179,147,125,201,164,190,149,25,124,51,147,182,143,246,63,1,13,84,133,31,60,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,151,75,111,27,71,12,128,255,138,176,201,209,20,230,253,208,181,233,193,128,227,26,113,154,139,237,3,103,134,108,132,234,97,104,87,41,92,67,255,189,148,108,199,15,36,142,147,34,40,92,120,15,171,221,209,240,1,146,223,144,123,217,189,30,46,206,169,155,116,239,105,181,194,126,201,195,248,151,229,138,198,71,171,101,165,190,31,31,44,43,206,166,127,99,153,209,17,174,112,78,3,173,62,224,108,77,253,193,180,31,246,70,247,197,186,189,238,245,167,221,191,221,228,228,178,219,31,104,254,251,126,19,237,33,215,226,41,102,224,228,34,184,128,10,48,54,11,222,88,74,220,98,9,57,139,112,93,206,214,243,197,91,26,240,8,135,143,221,228,178,219,105,19,5,165,170,106,90,80,224,209,54,112,201,137,2,116,4,53,40,194,24,3,25,21,186,205,94,215,215,143,52,199,157,209,91,97,167,145,83,166,12,209,171,2,142,74,129,84,177,2,179,205,37,136,50,77,117,43,124,189,255,86,240,228,213,193,114,249,231,250,124,108,140,117,186,54,13,190,88,11,174,138,249,172,180,134,192,49,100,75,28,200,185,177,215,216,170,165,10,214,43,217,84,180,248,168,196,96,42,100,139,34,173,89,165,87,103,91,67,109,218,159,207,240,226,195,87,237,29,16,182,81,63,224,31,52,62,92,14,163,233,66,194,78,253,64,237,74,254,252,94,42,238,106,184,60,189,202,232,105,55,57,253,90,78,175,127,143,119,161,186,159,213,135,9,61,237,246,78,187,227,229,122,85,183,26,173,188,188,185,227,250,206,200,110,203,131,215,155,12,202,202,98,61,155,93,175,188,193,1,111,54,222,44,47,219,148,167,212,246,23,199,55,137,219,105,81,215,23,124,225,118,115,93,249,246,111,196,222,226,66,34,188,58,148,0,220,250,254,217,203,247,18,198,27,197,197,100,175,162,102,136,132,89,42,40,24,72,77,35,100,157,11,219,104,13,179,217,73,191,35,150,76,45,42,221,119,236,41,245,115,45,223,239,162,189,69,231,218,175,109,168,54,221,102,179,119,23,168,109,209,70,76,5,178,97,3,78,115,134,140,33,73,233,53,85,74,172,228,74,122,20,168,92,76,204,53,6,80,70,139,71,236,53,96,109,1,108,182,129,180,10,185,52,247,51,129,106,172,107,77,1,130,137,21,92,147,27,54,137,175,106,148,136,10,22,167,234,152,99,82,33,200,49,129,209,146,152,145,237,165,228,12,228,98,228,90,178,43,230,169,64,29,18,181,209,28,135,245,106,58,92,188,48,245,191,96,234,9,37,244,93,76,233,202,213,113,106,96,116,82,224,48,58,40,198,100,168,218,69,36,76,41,25,255,40,83,222,36,29,173,75,2,184,210,224,148,246,82,185,33,64,149,86,80,99,241,222,213,244,51,152,58,217,239,127,251,107,65,171,171,248,76,24,103,61,157,141,101,245,193,194,175,51,154,211,98,152,92,90,242,33,40,113,148,216,73,232,125,97,200,205,52,240,74,120,203,198,168,226,104,35,2,159,11,121,114,233,147,173,74,122,54,100,106,34,34,46,237,18,5,92,66,69,100,214,134,219,230,236,91,52,74,165,15,171,105,89,15,211,229,98,116,190,109,111,59,199,95,8,124,150,4,234,32,147,77,144,206,145,152,182,77,200,103,145,111,50,245,36,101,155,11,201,182,102,191,139,192,152,180,73,72,1,76,174,65,166,60,146,186,12,69,8,100,164,198,193,82,142,245,81,2,165,167,49,89,82,32,189,77,16,102,225,184,160,98,96,31,26,27,231,165,220,235,115,37,176,54,79,36,39,20,132,170,69,36,202,173,72,167,134,32,71,93,169,25,107,13,244,35,4,190,163,249,116,209,70,203,23,16,255,51,16,179,42,65,74,32,129,98,150,86,166,157,32,21,229,107,201,56,163,228,1,57,171,248,24,136,79,118,236,201,32,182,22,131,247,85,106,205,203,228,37,83,23,36,43,71,126,50,166,42,226,82,27,149,71,65,68,167,48,56,70,249,2,34,148,86,40,76,103,39,211,38,250,92,117,99,81,104,249,185,130,40,65,136,210,215,9,40,68,25,157,21,202,232,108,217,202,216,160,12,177,151,20,69,252,17,16,143,113,70,253,168,77,63,77,123,89,123,65,241,89,246,68,223,146,243,161,56,208,94,218,144,107,228,65,190,253,101,16,100,25,2,57,196,236,235,55,81,60,219,252,3,174,141,39,228,152,17,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,51,0,0,33,223,219,244,1,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,89,203,110,91,55,16,253,21,225,38,139,20,48,5,190,31,222,58,73,97,32,73,131,56,205,38,242,98,56,28,38,66,245,48,174,174,82,184,134,255,189,67,217,78,108,183,85,156,119,139,74,11,201,162,238,12,201,225,156,51,103,232,179,238,254,112,122,66,221,126,247,146,250,30,86,203,58,140,15,150,61,141,159,247,75,164,213,106,252,100,137,48,155,254,1,121,70,207,161,135,57,13,212,191,130,217,154,86,79,166,171,97,111,116,211,172,219,235,238,191,219,252,218,237,191,62,235,14,7,154,255,122,88,216,187,74,154,140,199,40,98,65,41,108,142,94,128,73,32,0,92,41,89,87,210,165,25,227,114,182,158,47,158,210,0,207,97,120,219,237,159,117,27,111,236,128,124,165,26,172,23,21,92,18,86,74,18,49,120,254,203,218,96,108,86,160,165,233,206,247,186,21,190,165,57,108,38,253,96,12,20,192,101,244,66,41,87,133,165,162,69,10,232,132,50,213,161,83,86,163,9,205,248,242,249,15,134,11,250,125,244,243,122,90,30,76,58,171,160,198,68,73,4,39,51,251,200,89,68,4,20,181,154,148,189,141,86,17,78,186,159,154,155,50,93,157,204,224,244,213,215,241,118,114,35,236,215,253,157,77,46,78,111,210,237,79,254,233,252,46,63,143,54,97,185,121,130,183,15,111,210,237,77,186,163,229,186,199,230,209,240,151,135,215,54,178,153,100,243,200,173,175,87,167,197,35,139,245,108,118,57,242,16,6,184,122,240,106,120,89,166,117,74,229,112,113,116,117,72,27,47,242,242,37,254,230,237,234,117,177,182,47,49,123,10,11,120,67,253,51,14,192,135,181,191,95,229,75,14,227,149,227,172,147,147,65,85,17,8,56,193,200,107,206,90,5,34,169,148,171,9,70,215,170,55,214,47,168,82,79,11,164,155,11,3,93,172,12,160,4,22,176,194,26,107,5,96,80,34,70,176,164,115,77,168,227,165,253,106,19,237,6,147,203,117,181,80,157,119,231,231,123,215,193,35,37,79,109,19,59,4,226,244,117,154,68,162,108,5,39,144,206,217,163,133,88,183,130,199,74,101,141,194,34,84,113,154,33,163,146,0,85,149,8,222,7,48,206,218,162,241,235,131,231,245,189,215,135,171,95,126,95,80,127,17,159,253,10,179,21,29,143,121,244,214,192,251,188,220,63,11,33,87,116,86,9,5,28,114,155,29,137,92,66,16,134,172,78,104,179,55,161,158,31,223,59,222,134,179,215,247,158,16,148,209,178,77,125,241,228,14,67,255,49,12,41,159,185,94,56,6,13,151,6,97,21,115,126,44,69,10,136,210,20,235,163,41,197,124,18,134,200,21,208,6,72,132,168,189,96,130,173,34,146,145,205,107,65,165,61,4,237,182,98,72,58,198,160,169,133,203,78,138,140,106,94,86,70,107,4,214,28,100,205,86,71,105,255,37,24,50,18,171,231,197,114,180,162,18,22,121,155,32,99,228,226,226,157,11,154,145,100,213,221,48,180,67,207,15,65,143,54,82,69,231,3,179,180,65,206,53,205,121,234,99,16,181,248,154,24,23,41,229,178,13,61,119,94,216,93,209,99,52,72,165,18,99,70,42,98,245,197,107,129,200,98,76,25,227,117,54,197,129,133,173,232,65,10,53,5,25,133,195,92,120,71,202,139,204,2,80,216,228,201,24,149,156,209,223,4,61,71,167,171,87,208,79,155,124,29,31,172,123,142,213,192,17,167,151,211,57,125,44,255,217,148,247,63,122,119,203,124,212,108,71,176,40,163,230,104,7,144,31,2,144,162,21,37,170,86,160,244,44,177,164,98,50,214,177,53,7,10,162,10,138,133,151,253,174,0,97,108,164,80,125,195,134,229,172,198,18,68,74,92,254,36,160,75,96,144,213,87,218,10,16,168,164,184,138,4,65,73,49,103,107,195,0,9,236,197,217,92,156,139,65,165,248,13,250,27,102,249,229,242,183,245,201,184,32,102,202,209,9,7,220,138,88,86,150,34,213,74,44,24,1,0,51,135,181,184,49,120,95,100,36,37,52,183,107,130,152,17,88,216,74,224,168,41,231,138,108,60,229,62,90,85,46,230,123,182,28,56,209,16,134,233,114,49,186,72,232,241,65,79,140,168,50,202,167,59,84,253,16,84,125,169,104,187,75,18,125,18,170,180,66,80,26,85,171,131,92,53,144,29,230,228,145,27,31,46,135,224,200,65,220,126,107,80,163,44,73,5,110,36,106,226,55,175,130,200,158,81,5,181,86,200,42,167,226,194,215,71,213,209,208,79,23,111,198,143,151,253,28,134,7,159,39,225,52,164,12,190,54,62,113,194,2,20,145,192,25,94,189,138,153,245,157,135,148,154,132,219,27,221,221,253,163,25,205,185,128,237,159,17,82,52,62,123,81,92,225,115,110,61,33,64,149,34,25,96,113,157,185,121,117,246,252,230,122,138,147,62,176,76,22,153,207,163,17,46,235,96,131,40,156,41,81,178,176,214,218,133,102,242,104,49,76,135,211,131,205,129,112,51,103,60,139,79,8,76,211,196,86,149,179,42,75,99,133,118,142,85,3,103,149,55,230,179,119,145,178,171,193,150,42,136,248,68,109,163,164,172,137,55,229,181,137,46,37,27,82,189,181,11,62,245,160,53,55,210,57,88,166,234,216,244,191,49,70,56,15,69,89,73,158,2,254,117,23,224,16,33,36,110,67,66,225,44,212,17,216,170,102,150,50,73,231,82,152,247,107,108,187,216,122,247,115,59,39,94,208,124,186,40,60,52,226,108,103,139,38,37,90,24,94,180,206,21,215,171,97,57,167,126,180,224,189,141,31,79,251,213,48,154,54,49,178,172,163,158,86,235,217,208,12,57,237,103,132,141,65,199,13,68,215,236,103,27,39,203,197,0,56,220,197,252,49,131,111,180,216,248,216,93,57,253,8,230,117,8,198,85,197,125,154,146,173,99,107,210,63,121,16,134,27,93,240,80,1,43,126,95,193,143,46,160,97,194,209,214,115,187,108,209,50,69,88,46,250,30,81,135,6,135,24,183,50,111,168,22,29,165,198,183,137,107,1,171,178,118,9,38,5,99,214,20,205,184,207,234,27,232,153,29,243,238,152,119,199,188,59,230,253,132,78,178,100,3,138,72,200,64,145,17,201,154,55,7,70,75,225,156,100,192,75,89,191,243,85,75,37,158,211,113,251,87,131,100,112,97,64,6,87,102,246,44,190,214,130,38,98,180,219,255,83,70,193,48,83,121,225,84,100,228,104,12,23,42,60,153,144,13,171,123,43,107,249,250,204,59,233,218,125,225,164,219,134,196,235,207,236,18,253,127,152,232,199,231,127,2,58,202,38,107,112,30,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,64,212,91,190,21,169,91,4,40,154,0,49,114,169,114,88,81,75,155,168,100,9,36,157,214,53,252,239,93,138,182,234,20,46,226,246,210,232,36,14,134,179,179,195,221,93,32,90,48,230,51,116,24,204,130,5,106,13,166,151,246,250,131,106,45,234,143,186,223,12,193,85,96,80,43,104,213,15,108,60,62,111,148,125,15,22,232,202,174,250,165,80,5,179,234,188,70,21,92,85,129,178,216,25,226,208,149,38,45,195,164,44,145,229,66,230,44,41,161,96,165,44,98,6,169,8,227,184,9,33,229,220,51,255,36,126,211,119,3,104,244,53,70,121,57,254,46,182,131,163,114,2,196,72,81,166,95,31,192,216,153,48,243,53,212,45,54,116,182,122,131,4,89,173,58,234,6,23,170,195,123,208,84,203,233,244,14,34,146,132,214,56,86,139,210,206,191,15,26,141,81,253,250,53,115,237,166,91,159,178,73,0,167,227,193,78,56,122,116,204,123,176,171,81,226,150,108,237,71,151,239,150,75,141,75,176,234,249,212,196,87,220,142,188,203,242,163,11,13,189,210,35,180,27,60,169,249,178,147,27,24,172,111,200,151,39,130,86,203,213,197,189,78,137,189,214,110,68,224,112,36,95,168,121,182,135,40,35,240,217,1,94,229,248,91,5,95,110,205,221,183,53,234,7,177,194,14,124,106,79,215,132,254,6,76,250,179,93,28,10,153,149,9,69,87,20,156,37,34,14,25,132,69,193,164,204,210,52,143,48,137,18,190,127,242,62,148,25,90,216,62,78,229,62,33,248,192,92,110,116,230,113,145,198,60,79,89,13,18,73,75,54,12,114,193,89,198,27,17,150,113,65,165,82,122,95,247,185,103,232,151,74,64,123,55,160,134,195,11,132,231,7,244,197,100,187,230,117,223,91,223,210,20,222,228,229,56,34,5,166,181,204,168,122,148,215,41,75,106,222,176,146,67,194,26,209,100,24,201,168,46,139,132,204,208,118,187,124,31,250,141,22,135,109,50,126,173,255,105,93,255,195,18,254,205,94,157,157,236,75,38,245,173,204,224,155,153,180,125,176,255,9,228,195,68,119,60,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,73,77,76,241,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,197,68,70,233,19,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				IsResult = true,
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				UId = new Guid("9891f0ad-db82-488b-aedd-64f50dc28baf"),
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
				UId = new Guid("58751358-9137-4811-8c8b-e31b4917cc58"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,229,84,203,110,219,48,16,252,21,67,231,48,160,222,146,111,69,234,22,1,138,38,104,130,92,226,28,86,228,202,33,74,61,64,82,105,93,195,255,222,165,228,184,78,225,34,110,47,45,80,29,4,105,48,59,156,125,113,19,8,13,214,126,132,6,131,121,112,139,198,128,237,106,119,254,78,105,135,230,189,233,134,62,56,11,44,26,5,90,125,67,57,225,11,169,220,91,112,64,33,155,229,15,133,101,48,95,30,215,88,6,103,203,64,57,108,44,113,40,36,198,60,77,10,158,176,164,70,122,133,113,194,202,170,22,44,76,184,76,98,25,151,144,195,196,252,149,248,69,215,244,96,112,58,99,148,175,199,207,219,117,239,169,33,1,98,164,40,219,181,59,48,246,38,236,162,133,74,163,164,127,103,6,36,200,25,213,80,54,120,171,26,188,6,67,103,121,157,206,67,68,170,65,91,207,210,88,187,197,215,222,160,181,170,107,95,51,167,135,166,61,100,147,0,238,127,119,118,248,232,209,51,175,193,61,142,18,151,100,107,59,186,124,179,90,25,92,129,83,79,135,38,62,227,122,228,157,86,63,10,144,212,165,59,208,3,30,156,249,50,147,11,232,221,148,208,116,60,17,140,90,61,158,156,235,190,98,175,165,27,17,216,63,147,79,212,60,154,67,148,17,248,228,129,73,229,249,115,25,220,95,218,171,47,45,154,27,241,136,13,76,85,123,56,39,244,39,96,161,177,193,214,205,55,162,14,179,4,49,101,69,42,106,150,136,88,176,50,225,130,97,133,81,26,214,162,12,115,190,165,128,189,161,249,166,8,177,144,101,133,44,207,42,10,9,49,98,192,195,216,215,191,202,33,227,85,85,231,62,100,209,58,229,214,211,36,204,55,169,200,202,44,167,134,101,17,22,44,73,121,204,10,31,143,50,203,68,44,101,22,203,116,251,48,165,171,108,175,97,125,183,207,234,19,130,156,105,122,209,70,25,235,102,126,143,102,93,61,163,242,14,218,169,118,53,163,41,210,40,124,27,207,47,6,235,186,6,205,172,69,156,186,233,155,74,42,80,65,150,167,188,98,188,162,124,19,94,86,172,204,210,144,21,88,2,112,41,75,136,56,13,159,127,252,140,116,43,37,64,95,245,104,96,55,30,252,248,246,188,88,59,223,25,211,117,110,170,247,190,179,31,200,252,196,56,152,97,17,39,101,94,1,103,89,88,32,213,158,75,6,69,42,89,30,65,88,22,152,242,90,38,100,136,174,31,63,0,55,221,96,196,110,221,237,116,239,252,209,125,242,23,110,137,223,89,252,163,171,119,202,42,253,103,75,242,79,13,245,54,216,126,7,242,110,120,181,72,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,248,134,94,83,15,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				IsResult = true,
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				UId = new Guid("ebb14ab8-1576-4069-9eff-8964285cc2b3"),
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
				UId = new Guid("fd914a29-a951-4c58-a6e5-7402fa7e8761"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,229,84,93,111,211,48,20,253,43,85,158,231,41,113,156,196,233,27,26,5,237,133,77,108,218,11,221,195,181,115,221,89,228,75,142,59,24,85,255,59,215,73,87,58,84,180,194,11,72,52,82,149,28,157,123,124,238,151,55,145,174,97,24,62,64,131,209,60,186,69,231,96,232,140,63,127,103,107,143,238,189,235,214,125,116,22,13,232,44,212,246,27,86,19,190,168,172,127,11,30,40,100,179,252,161,176,140,230,203,227,26,203,232,108,25,89,143,205,64,28,10,201,12,228,200,101,193,242,68,0,19,168,50,86,74,41,88,166,161,144,244,100,73,193,39,230,175,196,47,186,166,7,135,211,25,163,188,25,95,111,159,250,64,77,8,208,35,197,14,93,187,3,211,96,98,88,180,160,106,172,232,219,187,53,18,228,157,109,40,27,188,181,13,94,131,163,179,130,78,23,32,34,25,168,135,192,170,209,248,197,215,222,225,48,216,174,125,205,92,189,110,218,67,54,9,224,254,115,103,39,30,61,6,230,53,248,135,81,226,146,108,109,71,151,111,86,43,135,43,240,246,241,208,196,103,124,26,121,167,213,143,2,42,234,210,29,212,107,60,56,243,101,38,23,208,251,41,161,233,120,34,56,187,122,56,57,215,125,197,94,75,151,19,216,63,147,79,212,60,154,3,207,9,124,12,192,164,242,252,186,140,62,93,14,87,95,90,116,55,250,1,27,152,170,118,127,78,232,79,192,162,198,6,91,63,223,104,147,228,2,49,99,50,211,134,9,157,106,86,138,88,51,84,200,179,196,232,50,41,226,45,5,236,13,205,55,50,65,89,149,10,89,145,43,10,73,144,51,136,147,148,149,202,168,2,242,88,41,83,132,144,69,235,173,127,154,38,97,190,129,74,148,113,149,73,22,103,161,97,149,164,134,113,145,179,170,146,34,207,81,165,165,76,183,247,83,186,118,232,107,120,186,219,103,245,17,161,154,213,244,71,27,229,6,63,11,123,52,235,204,140,202,187,174,189,109,87,51,154,162,26,117,104,35,141,94,235,65,251,81,41,180,147,226,243,56,77,120,198,145,65,101,56,19,16,115,166,114,13,44,227,153,130,44,209,185,230,5,141,93,248,133,233,232,86,86,67,125,213,163,131,221,96,196,199,247,230,197,194,133,158,184,174,243,83,165,247,61,61,180,243,60,188,64,67,155,130,40,88,92,41,201,132,200,12,83,92,196,140,75,163,114,21,75,83,166,154,252,208,189,19,58,127,211,173,157,222,237,249,48,93,56,127,116,145,252,133,235,225,119,54,254,232,206,157,178,67,255,217,118,252,75,51,189,141,182,223,1,93,152,49,71,64,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,248,134,94,83,15,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				IsResult = true,
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				UId = new Guid("76b641e0-afa5-49a2-a9f7-6c63a2f449de"),
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
				UId = new Guid("4ea3d1b9-bd07-4221-9d68-e9102d93f89a"),
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Distribute lead and specify lead nurturing strategy",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
			};
			parametrizedElement.Parameters.Add(clientUnitSchemaUIdParameter);
			var entityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1905b493-d577-4148-a465-5b25ff5f0ab4"),
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#SysVariable.CurrentUserContact#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				UId = new Guid("b6ff1632-8447-43c2-9b76-658146844be1"),
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
				UId = new Guid("7235fee8-643a-4105-bf60-d6e3855e65b9"),
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
				UId = new Guid("f164d1ac-d486-4ad3-91da-1174260bbd01"),
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
				UId = new Guid("1c855ecf-3361-49bf-825f-6281043116c4"),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
			};
			parametrizedElement.Parameters.Add(leadIdParameter);
			var resultParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a9e78508-ae1b-4141-abe0-24ed11eadb13"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
			};
			parametrizedElement.Parameters.Add(resultParameter);
			var remindToOwnerParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cd5eefc4-6c19-4719-be10-6babbc9acc6e"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
			};
			parametrizedElement.Parameters.Add(remindToOwnerParameter);
			var leadOwnerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("0d01d7bb-ccf9-4184-a64f-953b68988ea4"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
			};
			parametrizedElement.Parameters.Add(leadOwnerIdParameter);
			var opportunityDepartmentParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8227a76e-e673-40a1-a3f3-2102ef5efe7a"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,64,18,41,75,242,173,72,221,34,64,209,4,136,145,75,149,195,146,90,217,68,245,2,73,167,117,13,255,123,151,146,173,58,133,139,184,189,52,58,137,131,225,236,236,114,118,23,168,26,172,253,12,13,6,243,96,137,198,128,237,42,119,253,65,215,14,205,71,211,109,250,224,42,176,104,52,212,250,7,150,35,190,40,181,123,15,14,232,202,174,248,165,80,4,243,226,188,70,17,92,21,129,118,216,88,226,208,21,148,81,10,21,112,134,81,20,51,1,74,49,9,105,204,114,46,101,200,83,46,202,60,30,153,127,18,191,233,154,30,12,142,53,6,249,106,248,93,110,123,79,141,8,80,3,69,219,174,61,128,220,155,176,139,22,100,141,37,157,157,217,32,65,206,232,134,186,193,165,110,240,30,12,213,242,58,157,135,136,84,65,109,61,171,198,202,45,190,247,6,173,213,93,251,154,185,122,211,180,167,108,18,192,233,120,176,19,14,30,61,243,30,220,122,144,184,37,91,251,193,229,187,213,202,224,10,156,126,62,53,241,21,183,3,239,178,249,209,133,146,94,233,17,234,13,158,212,124,217,201,13,244,110,108,104,44,79,4,163,87,235,139,123,157,38,246,90,187,49,129,253,145,124,161,230,217,30,226,25,129,207,30,24,85,142,191,69,240,229,214,222,125,107,209,60,168,53,54,48,78,237,233,154,208,223,128,73,127,190,227,161,170,102,185,224,12,178,44,98,66,241,144,65,152,101,172,170,102,73,146,198,40,98,17,237,159,70,31,218,246,53,108,31,167,114,159,16,198,129,249,185,209,185,140,64,113,44,115,150,200,100,198,68,20,70,76,86,42,103,233,44,20,74,242,8,101,42,232,125,253,231,159,161,91,105,5,245,93,143,6,14,47,16,158,15,232,139,100,251,230,77,215,185,177,165,105,120,147,151,99,68,68,149,43,25,75,201,68,169,56,69,164,4,150,197,73,206,68,26,34,100,60,161,160,80,68,246,180,221,126,190,15,221,198,168,195,54,217,113,173,255,105,93,255,195,18,254,205,94,157,77,246,37,73,125,43,25,124,51,73,219,7,251,159,58,179,138,198,60,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,151,75,111,27,71,12,128,255,138,176,201,209,52,230,253,208,53,233,193,128,211,24,117,154,139,237,3,103,134,108,4,232,97,236,174,83,164,130,254,123,41,89,138,31,109,237,160,61,164,1,188,135,213,46,69,114,40,146,223,112,180,238,94,143,95,174,169,155,118,31,168,239,113,88,241,120,252,102,213,211,241,89,191,170,52,12,199,167,171,138,243,217,31,88,230,116,134,61,46,104,164,254,35,206,111,104,56,157,13,227,209,228,161,89,119,212,189,254,188,251,182,155,94,172,187,147,145,22,191,158,52,241,158,18,99,35,91,161,69,77,224,178,79,144,147,54,96,171,206,193,4,237,90,41,98,92,87,243,155,197,242,29,141,120,134,227,167,110,186,238,118,222,196,129,55,73,71,235,18,184,170,52,56,165,61,96,12,1,106,209,170,198,226,189,171,169,219,28,117,67,253,68,11,220,45,122,103,236,52,114,202,148,33,122,85,192,81,41,144,42,86,96,182,185,4,151,156,166,186,53,222,235,223,25,94,188,186,56,25,222,255,190,164,254,124,231,119,202,56,31,232,234,88,164,143,4,95,147,51,93,199,88,184,122,167,65,163,70,112,197,19,148,22,35,88,114,38,87,87,130,141,188,185,122,117,181,93,177,205,134,235,57,126,249,248,215,133,79,9,219,100,181,93,250,86,243,250,65,246,239,235,174,47,111,139,120,217,77,47,255,169,140,251,207,219,160,31,22,242,113,13,47,187,163,203,238,124,117,211,215,173,71,43,47,111,239,5,185,91,100,167,242,232,245,80,52,145,44,111,230,243,189,228,45,142,120,80,60,136,87,109,198,51,106,39,203,243,67,173,118,94,212,254,130,191,185,29,174,219,216,254,139,217,59,92,226,111,212,255,44,9,184,139,253,107,148,31,36,141,7,199,197,100,175,162,102,136,132,89,154,38,24,72,77,10,154,117,46,108,163,53,204,102,103,253,11,49,245,180,172,244,48,48,29,10,217,224,53,36,38,3,78,251,44,246,77,1,38,101,155,11,201,182,102,247,246,195,46,219,91,90,246,113,109,83,181,233,54,155,163,251,12,217,172,99,81,209,1,54,95,193,57,114,80,182,68,132,228,74,145,166,51,153,243,147,12,153,152,153,44,41,136,185,42,112,156,20,20,84,12,236,67,99,227,60,187,92,255,39,12,229,218,44,167,96,65,81,19,134,172,77,144,178,128,148,35,39,131,141,201,169,240,60,67,111,122,194,145,38,61,45,102,203,70,253,132,87,253,11,82,223,17,169,172,74,240,133,19,40,102,233,96,45,123,100,138,49,131,113,70,201,3,114,86,241,41,164,190,57,176,111,69,170,22,68,147,146,135,106,85,3,105,226,6,25,3,131,205,206,7,212,185,17,165,167,199,82,85,140,49,7,40,42,89,249,69,38,0,86,129,164,114,107,213,120,111,51,170,239,137,212,79,115,90,208,114,156,174,45,249,16,148,236,22,36,148,131,147,42,64,110,166,129,87,42,132,108,140,42,142,54,15,25,244,201,86,133,81,82,66,77,76,36,164,221,222,7,92,66,69,100,214,134,219,243,12,74,167,143,253,172,220,140,179,213,114,114,45,141,114,252,254,133,192,151,161,118,32,16,147,175,65,201,110,16,34,243,246,176,164,161,68,142,224,115,245,33,169,170,228,224,248,36,129,232,20,6,199,8,168,72,38,133,34,233,82,23,5,67,241,160,27,151,146,45,255,168,4,38,99,162,156,114,9,40,68,217,93,20,106,64,203,22,140,86,134,216,75,137,34,254,27,2,207,113,78,195,164,205,62,207,6,145,189,160,248,67,162,232,91,146,33,85,28,104,47,71,58,215,200,203,16,146,27,178,252,37,226,16,179,204,166,231,80,188,218,252,9,154,74,162,23,1,14,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeIntermediateCatchSignal1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3113a34a-8da2-40e6-8256-f154360ef8a5"),
				ContainerUId = new Guid("dbcbd41e-b326-4d01-b8f3-3d49f00820fe"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("dbcbd41e-b326-4d01-b8f3-3d49f00820fe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{30cf6943-a881-4c30-a088-ff65572e4241}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeLinkLeadToProcessParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entityIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("eaf23f6b-c09c-445f-910f-846067cc4260"),
				ContainerUId = new Guid("030582fb-9053-4d10-9c8d-0d58e8ad1641"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				Name = @"EntityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entityIdParameter.SourceValue = new ProcessSchemaParameterValue(entityIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{30cf6943-a881-4c30-a088-ff65572e4241}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
			};
			parametrizedElement.Parameters.Add(entityIdParameter);
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("eb235528-1302-40b2-8b0d-75f09ed4804b"),
				ContainerUId = new Guid("030582fb-9053-4d10-9c8d-0d58e8ad1641"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				Name = @"EntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
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
			ProcessSchemaIntermediateCatchSignalEvent intermediatecatchsignal1 = CreateIntermediateCatchSignal1IntermediateCatchSignalEvent();
			FlowElements.Add(intermediatecatchsignal1);
			ProcessSchemaParallelGateway parallelgateway1 = CreateParallelGateway1ParallelGateway();
			FlowElements.Add(parallelgateway1);
			ProcessSchemaUserTask linkleadtoprocess = CreateLinkLeadToProcessUserTask();
			FlowElements.Add(linkleadtoprocess);
			ProcessSchemaInclusiveGateway inclusivegateway1 = CreateInclusiveGateway1InclusiveGateway();
			FlowElements.Add(inclusivegateway1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalFlowLeadUndefinedConditionalFlow());
			FlowElements.Add(CreateConditionalFlowCreateReminderConditionalFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlowNoReminderSequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("5fb58e15-c3e0-48b9-b270-c3878ba5ec8d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				CurveCenterPosition = new Point(182, 288),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
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

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowCreateReminderConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowCreateReminder",
				UId = new Guid("97e8e894-d220-43dc-9cfa-0e37f8166e2a"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{9cd3f863-0eda-4338-895e-97f82adfe406}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				CurveCenterPosition = new Point(648, 154),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				CurveCenterPosition = new Point(677, 155),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				CurveCenterPosition = new Point(916, 130),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
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
			schemaFlow.PolylinePointPositions.Add(new Point(693, 116));
			schemaFlow.PolylinePointPositions.Add(new Point(1360, 116));
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				CurveCenterPosition = new Point(220, 155),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0788b001-b01e-467d-8078-6e3f56e8a438"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("030582fb-9053-4d10-9c8d-0d58e8ad1641"),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				CurveCenterPosition = new Point(480, 152),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				CurveCenterPosition = new Point(468, 226),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
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
			schemaFlow.PolylinePointPositions.Add(new Point(555, 270));
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				CurveCenterPosition = new Point(348, 154),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				CurveCenterPosition = new Point(562, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
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
			schemaFlow.PolylinePointPositions.Add(new Point(555, 57));
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				CurveCenterPosition = new Point(1144, 166),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				CurveCenterPosition = new Point(809, 166),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				CurveCenterPosition = new Point(920, 168),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				CurveCenterPosition = new Point(1026, 168),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
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

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("4365907e-4259-43b7-b5c9-9198eed877cd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("62282042-1255-4e64-85bb-e0f48d66d46e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dbcbd41e-b326-4d01-b8f3-3d49f00820fe"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(317, 387));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow2",
				UId = new Guid("adf061c8-5e2b-4b81-9dd6-01ff389371e0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("030582fb-9053-4d10-9c8d-0d58e8ad1641"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("62282042-1255-4e64-85bb-e0f48d66d46e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("c6e3e495-2035-4485-b3cf-2b7861e7a0f2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("62282042-1255-4e64-85bb-e0f48d66d46e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("a85b720a-fc41-4983-b4eb-113739de786c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dbcbd41e-b326-4d01-b8f3-3d49f00820fe"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7ce091e6-4511-4f24-aa1c-98b98f288332"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1",
				UId = new Guid("0ae66221-8406-4b11-ac9c-ce039b98f222"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{3e566048-ef49-45bf-9d2d-500669220b4e}].[Parameter:{a9e78508-ae1b-4141-abe0-24ed11eadb13}]#] != ""TransferToSale""",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7ce091e6-4511-4f24-aa1c-98b98f288332"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e0fc6ab2-437d-4492-a531-191b3013d93d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1360, 387));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("0c3a16d2-6cd1-4cf1-818b-7872e864d8ec"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9991b8a2-84b0-4228-a2dc-a24cad0bd72d"),
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c"),
				SourceSequenceFlowPointLocalPosition = new Point(-1, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(608, 15));
			schemaFlow.PolylinePointPositions.Add(new Point(453, 15));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLeadDistributionProcessLaneSet() {
			ProcessSchemaLaneSet schemaLeadDistributionProcess = new ProcessSchemaLaneSet(this) {
				UId = new Guid("4d9afef7-9066-439f-b71e-60e2c82e61da"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"LeadDistributionProcess",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"LeadDistribution",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"Start",
				Position = new Point(50, 23),
				SerializeToDB = false,
				Size = new Size(27, 27),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"TerminateHandoff",
				Position = new Point(1347, 257),
				SerializeToDB = false,
				Size = new Size(27, 27),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"ExclusiveGatewayIsLeadSet",
				Position = new Point(36, 131),
				SerializeToDB = false,
				Size = new Size(55, 55),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"TerminateLeadIsNotSet",
				Position = new Point(50, 247),
				SerializeToDB = false,
				Size = new Size(27, 27),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"SaveLeadHandoff",
				Position = new Point(659, 131),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"SaveLeadNoInterest",
				Position = new Point(608, 243),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeSaveLeadNoInterestParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddReminderUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"AddReminder",
				Position = new Point(1217, 131),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"ReadLeadData",
				Position = new Point(819, 131),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"ReadLeadType",
				Position = new Point(1088, 131),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"ReadLeadContact",
				Position = new Point(959, 131),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"ExclusiveGateway2",
				Position = new Point(1333, 131),
				SerializeToDB = false,
				Size = new Size(55, 55),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"DistributionLeadPage",
				Position = new Point(419, 131),
				SchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				SerializeToDB = true,
				Size = new Size(69, 55),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"ExclusiveGateway1",
				Position = new Point(528, 131),
				SerializeToDB = false,
				Size = new Size(55, 55),
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
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"SaveLeadByDefault",
				Position = new Point(608, 30),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeSaveLeadByDefaultParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchSignalEvent CreateIntermediateCatchSignal1IntermediateCatchSignalEvent() {
			ProcessSchemaIntermediateCatchSignalEvent schemaCatchSignalEvent = new ProcessSchemaIntermediateCatchSignalEvent(this) {
				UId = new Guid("dbcbd41e-b326-4d01-b8f3-3d49f00820fe"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = false,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = false,
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"IntermediateCatchSignal1",
				NewEntityChangedColumns = false,
				Position = new Point(792, 374),
				SerializeToDB = true,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaCatchSignalEvent.EntityChangedColumns.Add("bc0c2d60-5a3d-4840-aa4e-c60ea776e206");
			InitializeIntermediateCatchSignal1Parameters(schemaCatchSignalEvent);
			return schemaCatchSignalEvent;
		}

		protected virtual ProcessSchemaParallelGateway CreateParallelGateway1ParallelGateway() {
			ProcessSchemaParallelGateway gateway = new ProcessSchemaParallelGateway(this) {
				UId = new Guid("62282042-1255-4e64-85bb-e0f48d66d46e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("e9e1e6de-7066-4eb1-bbb4-5b75b13d4f56"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"ParallelGateway1",
				Position = new Point(290, 131),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateLinkLeadToProcessUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("030582fb-9053-4d10-9c8d-0d58e8ad1641"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"LinkLeadToProcess",
				Position = new Point(147, 131),
				SchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeLinkLeadToProcessParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaInclusiveGateway CreateInclusiveGateway1InclusiveGateway() {
			ProcessSchemaInclusiveGateway gateway = new ProcessSchemaInclusiveGateway(this) {
				UId = new Guid("7ce091e6-4511-4f24-aa1c-98b98f288332"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("ffa4a06a-5747-49d4-96c2-c32a727a3b14"),
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"InclusiveGateway1",
				Position = new Point(925, 360),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LeadManagementDistribution78(userConnection);
		}

		public override object Clone() {
			return new LeadManagementDistribution78Schema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadManagementDistribution78

	/// <exclude/>
	public class LeadManagementDistribution78 : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLeadDistribution

		/// <exclude/>
		public class ProcessLeadDistribution : ProcessLane
		{

			public ProcessLeadDistribution(UserConnection userConnection, LeadManagementDistribution78 process)
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

			public SaveLeadHandoffFlowElement(UserConnection userConnection, LeadManagementDistribution78 process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,128,162,168,151,111,69,234,22,1,138,38,64,140,92,170,28,214,210,202,38,170,23,72,58,173,107,248,223,187,20,109,213,41,92,196,237,165,209,73,28,12,103,103,150,187,187,160,108,192,152,207,208,98,48,11,22,168,53,152,190,182,215,31,84,99,81,127,212,253,102,8,174,2,131,90,65,163,126,96,229,241,121,165,236,123,176,64,87,118,197,47,133,34,152,21,231,53,138,224,170,8,148,197,214,16,135,174,64,194,81,100,18,89,28,73,206,100,12,41,91,10,89,177,48,197,88,138,40,170,179,92,122,230,159,196,111,250,118,0,141,190,198,40,95,143,191,139,237,224,168,33,1,229,72,81,166,239,14,96,228,76,152,121,7,203,6,43,58,91,189,65,130,172,86,45,165,193,133,106,241,30,52,213,114,58,189,131,136,84,67,99,28,171,193,218,206,191,15,26,141,81,125,247,154,185,102,211,118,167,108,18,192,233,120,176,195,71,143,142,121,15,118,61,74,220,146,173,253,232,242,221,106,165,113,5,86,61,159,154,248,138,219,145,119,89,255,232,66,69,175,244,8,205,6,79,106,190,76,114,3,131,245,129,124,121,34,104,181,90,95,156,117,234,216,107,113,5,129,195,145,124,161,230,217,12,34,33,240,217,1,94,229,248,91,4,95,110,205,221,183,14,245,67,185,198,22,124,215,158,174,9,253,13,152,244,103,187,136,151,117,146,203,136,65,150,133,76,150,17,103,192,179,140,213,117,18,199,169,64,41,100,184,127,242,62,148,25,26,216,62,78,229,62,33,248,134,185,190,209,57,227,117,152,66,10,12,185,136,153,148,73,197,96,89,69,12,243,144,158,37,207,151,60,78,233,125,221,231,158,161,95,169,18,154,187,1,53,28,94,128,159,31,208,23,147,237,194,235,190,183,62,210,212,188,201,203,113,68,120,37,150,2,64,50,145,200,148,201,202,5,203,203,204,217,170,99,94,165,192,75,32,51,180,221,174,191,15,253,70,151,135,109,50,126,173,255,105,93,255,195,18,254,205,94,157,157,236,75,38,245,173,204,224,155,153,180,125,176,255,9,209,204,1,60,60,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,151,91,111,219,86,12,199,191,138,161,246,49,52,206,253,226,215,118,192,2,164,91,176,116,125,73,242,112,46,228,106,204,182,2,73,238,208,25,254,238,163,28,187,137,131,53,201,48,12,93,129,248,65,150,142,197,63,41,146,63,29,122,211,188,30,62,223,96,51,107,222,99,215,165,190,165,97,250,166,237,112,122,222,181,5,251,126,122,214,150,180,152,255,153,242,2,207,83,151,150,56,96,247,33,45,214,216,159,205,251,225,100,114,108,214,156,52,175,63,237,126,109,102,151,155,230,116,192,229,175,167,149,213,179,141,94,217,96,32,38,202,96,82,13,144,98,73,124,230,141,166,168,68,174,129,141,75,187,88,47,87,239,112,72,231,105,248,216,204,54,205,78,109,20,40,162,168,234,4,216,164,43,152,96,4,164,100,16,138,19,152,188,119,168,132,107,182,39,77,95,62,226,50,237,156,222,25,27,153,40,68,140,224,173,96,239,152,51,132,146,10,16,233,152,29,139,73,44,163,241,254,254,59,195,203,87,103,109,251,251,250,102,170,148,54,178,84,9,54,107,13,166,176,251,40,164,4,71,222,69,141,228,208,152,105,193,236,69,214,5,98,176,196,49,58,15,9,125,129,16,40,214,234,165,112,33,188,186,30,29,213,121,127,179,72,159,63,124,213,223,25,166,58,233,135,244,27,78,127,76,171,218,18,77,134,118,210,167,5,246,183,10,55,71,197,184,175,177,185,186,173,233,85,51,187,250,90,85,247,223,23,187,100,29,215,245,97,73,175,154,147,171,230,162,93,119,101,84,212,124,241,246,94,240,59,39,187,91,30,92,30,106,200,43,171,245,98,177,95,121,155,134,116,184,241,176,220,214,57,205,177,158,174,46,14,165,219,169,136,253,7,254,230,112,248,220,198,246,111,204,222,165,21,231,184,251,137,19,112,23,251,151,40,223,115,26,15,194,89,69,43,188,36,240,152,34,247,144,83,16,170,76,16,101,204,164,189,86,68,106,103,253,11,18,118,184,42,120,28,216,115,58,104,111,223,239,178,61,194,179,143,107,76,213,182,217,110,79,238,35,197,98,206,27,79,252,104,18,193,232,202,221,22,68,0,95,13,161,183,104,114,42,143,34,101,85,144,94,155,192,193,8,9,70,72,11,201,59,7,37,75,81,124,182,214,148,240,95,32,117,121,218,255,252,199,10,187,219,252,204,40,45,122,188,158,242,234,131,133,47,125,57,219,120,159,169,88,35,65,38,78,185,201,22,33,87,239,65,163,81,177,152,236,180,167,237,245,147,108,141,80,181,163,235,23,134,190,75,134,164,203,168,157,149,16,8,21,24,105,35,219,87,49,246,189,174,198,5,93,171,254,71,12,229,196,225,184,200,228,24,18,99,64,30,34,58,110,106,101,10,81,52,57,203,248,40,67,202,71,66,141,2,124,44,44,64,65,0,107,18,144,117,149,148,177,100,98,249,159,48,20,75,213,20,156,6,129,149,25,210,58,64,136,12,82,244,20,84,170,132,70,184,167,25,122,211,97,26,112,210,225,114,190,170,216,77,168,237,94,144,250,134,72,69,145,157,205,20,64,16,21,70,130,223,145,193,251,8,202,40,193,39,137,162,240,143,33,245,236,192,158,139,148,211,60,235,161,227,86,214,138,183,37,43,28,195,149,50,104,226,241,71,88,157,179,149,143,34,149,140,72,206,80,130,196,147,29,111,75,232,32,26,207,42,54,22,89,41,231,168,233,91,34,245,195,2,151,184,26,102,27,141,214,57,193,251,39,50,229,252,164,153,32,86,85,193,10,225,92,84,60,211,26,220,30,51,24,148,242,188,199,34,240,155,134,135,0,145,36,36,77,26,148,20,10,201,114,137,124,122,154,65,238,244,161,155,231,245,48,111,87,147,155,113,70,188,24,7,195,73,157,127,154,247,188,246,130,226,119,185,187,217,26,140,117,217,128,180,188,161,152,138,22,178,224,3,255,99,146,130,156,143,182,60,137,226,245,246,47,98,169,118,174,210,13,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "2747a38633284c0da1bc2acc2ae61cfe",
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

			public SaveLeadNoInterestFlowElement(UserConnection userConnection, LeadManagementDistribution78 process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,19,49,20,253,151,89,215,149,103,236,121,101,135,74,64,149,16,173,212,168,27,166,139,27,251,78,98,49,47,217,78,33,68,249,119,236,113,50,164,40,168,129,13,245,202,62,58,62,247,220,215,46,18,13,24,243,25,90,140,102,209,2,181,6,211,215,246,250,131,106,44,234,143,186,223,12,209,85,100,80,43,104,212,15,148,1,159,75,101,223,131,5,247,101,87,253,82,168,162,89,117,94,163,138,174,170,72,89,108,141,227,184,47,172,164,89,94,148,72,18,42,19,194,33,19,164,204,139,156,228,200,227,36,47,75,25,39,44,48,255,36,126,211,183,3,104,12,49,70,249,122,188,46,182,131,167,198,14,16,35,69,153,190,59,128,204,155,48,243,14,150,13,74,247,182,122,131,14,178,90,181,46,27,92,168,22,239,65,187,88,94,167,247,144,35,213,208,24,207,106,176,182,243,239,131,70,99,84,223,189,102,174,217,180,221,41,219,9,224,244,60,216,161,163,71,207,188,7,187,30,37,110,157,173,253,232,242,221,106,165,113,5,86,61,159,154,248,138,219,145,119,89,253,220,7,233,186,244,8,205,6,79,98,190,204,228,6,6,27,18,10,225,29,65,171,213,250,226,92,167,138,189,150,110,226,192,225,72,190,80,243,108,14,73,230,192,103,15,4,149,227,181,138,190,220,154,187,111,29,234,7,177,198,22,66,213,158,174,29,250,27,48,233,207,118,140,138,58,43,57,35,80,20,49,225,130,81,2,180,40,72,93,103,105,154,39,200,19,30,239,159,130,15,101,134,6,182,143,83,184,79,8,161,96,190,110,238,237,218,64,11,73,129,8,81,46,9,79,101,73,150,76,166,36,97,144,83,202,249,50,142,133,235,175,63,190,13,253,74,9,104,238,6,212,112,232,0,61,63,160,47,38,219,39,175,251,222,134,148,166,226,77,94,142,35,66,83,89,32,43,24,137,145,213,132,103,89,66,202,52,78,137,20,69,46,120,206,24,230,75,103,198,109,183,175,239,67,191,209,226,176,77,38,172,245,63,173,235,127,88,194,191,217,171,179,147,125,201,164,190,149,25,124,51,147,182,143,246,63,1,13,84,133,31,60,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,151,75,111,27,71,12,128,255,138,176,201,209,20,230,253,208,181,233,193,128,227,26,113,154,139,237,3,103,134,108,132,234,97,104,87,41,92,67,255,189,148,108,199,15,36,142,147,34,40,92,120,15,171,221,209,240,1,146,223,144,123,217,189,30,46,206,169,155,116,239,105,181,194,126,201,195,248,151,229,138,198,71,171,101,165,190,31,31,44,43,206,166,127,99,153,209,17,174,112,78,3,173,62,224,108,77,253,193,180,31,246,70,247,197,186,189,238,245,167,221,191,221,228,228,178,219,31,104,254,251,126,19,237,33,215,226,41,102,224,228,34,184,128,10,48,54,11,222,88,74,220,98,9,57,139,112,93,206,214,243,197,91,26,240,8,135,143,221,228,178,219,105,19,5,165,170,106,90,80,224,209,54,112,201,137,2,116,4,53,40,194,24,3,25,21,186,205,94,215,215,143,52,199,157,209,91,97,167,145,83,166,12,209,171,2,142,74,129,84,177,2,179,205,37,136,50,77,117,43,124,189,255,86,240,228,213,193,114,249,231,250,124,108,140,117,186,54,13,190,88,11,174,138,249,172,180,134,192,49,100,75,28,200,185,177,215,216,170,165,10,214,43,217,84,180,248,168,196,96,42,100,139,34,173,89,165,87,103,91,67,109,218,159,207,240,226,195,87,237,29,16,182,81,63,224,31,52,62,92,14,163,233,66,194,78,253,64,237,74,254,252,94,42,238,106,184,60,189,202,232,105,55,57,253,90,78,175,127,143,119,161,186,159,213,135,9,61,237,246,78,187,227,229,122,85,183,26,173,188,188,185,227,250,206,200,110,203,131,215,155,12,202,202,98,61,155,93,175,188,193,1,111,54,222,44,47,219,148,167,212,246,23,199,55,137,219,105,81,215,23,124,225,118,115,93,249,246,111,196,222,226,66,34,188,58,148,0,220,250,254,217,203,247,18,198,27,197,197,100,175,162,102,136,132,89,42,40,24,72,77,35,100,157,11,219,104,13,179,217,73,191,35,150,76,45,42,221,119,236,41,245,115,45,223,239,162,189,69,231,218,175,109,168,54,221,102,179,119,23,168,109,209,70,76,5,178,97,3,78,115,134,140,33,73,233,53,85,74,172,228,74,122,20,168,92,76,204,53,6,80,70,139,71,236,53,96,109,1,108,182,129,180,10,185,52,247,51,129,106,172,107,77,1,130,137,21,92,147,27,54,137,175,106,148,136,10,22,167,234,152,99,82,33,200,49,129,209,146,152,145,237,165,228,12,228,98,228,90,178,43,230,169,64,29,18,181,209,28,135,245,106,58,92,188,48,245,191,96,234,9,37,244,93,76,233,202,213,113,106,96,116,82,224,48,58,40,198,100,168,218,69,36,76,41,25,255,40,83,222,36,29,173,75,2,184,210,224,148,246,82,185,33,64,149,86,80,99,241,222,213,244,51,152,58,217,239,127,251,107,65,171,171,248,76,24,103,61,157,141,101,245,193,194,175,51,154,211,98,152,92,90,242,33,40,113,148,216,73,232,125,97,200,205,52,240,74,120,203,198,168,226,104,35,2,159,11,121,114,233,147,173,74,122,54,100,106,34,34,46,237,18,5,92,66,69,100,214,134,219,230,236,91,52,74,165,15,171,105,89,15,211,229,98,116,190,109,111,59,199,95,8,124,150,4,234,32,147,77,144,206,145,152,182,77,200,103,145,111,50,245,36,101,155,11,201,182,102,191,139,192,152,180,73,72,1,76,174,65,166,60,146,186,12,69,8,100,164,198,193,82,142,245,81,2,165,167,49,89,82,32,189,77,16,102,225,184,160,98,96,31,26,27,231,165,220,235,115,37,176,54,79,36,39,20,132,170,69,36,202,173,72,167,134,32,71,93,169,25,107,13,244,35,4,190,163,249,116,209,70,203,23,16,255,51,16,179,42,65,74,32,129,98,150,86,166,157,32,21,229,107,201,56,163,228,1,57,171,248,24,136,79,118,236,201,32,182,22,131,247,85,106,205,203,228,37,83,23,36,43,71,126,50,166,42,226,82,27,149,71,65,68,167,48,56,70,249,2,34,148,86,40,76,103,39,211,38,250,92,117,99,81,104,249,185,130,40,65,136,210,215,9,40,68,25,157,21,202,232,108,217,202,216,160,12,177,151,20,69,252,17,16,143,113,70,253,168,77,63,77,123,89,123,65,241,89,246,68,223,146,243,161,56,208,94,218,144,107,228,65,190,253,101,16,100,25,2,57,196,236,235,55,81,60,219,252,3,174,141,39,228,152,17,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "2747a38633284c0da1bc2acc2ae61cfe",
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

			public AddReminderFlowElement(UserConnection userConnection, LeadManagementDistribution78 process)
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
				_recordDefValues_SubjectCaption = () => new LocalizableString(String.Format((process.NotificationTemplate), ((process.ReadLeadType.ResultEntity.IsColumnValueLoaded(process.ReadLeadType.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? process.ReadLeadType.ResultEntity.GetTypedColumnValue<string>("Name") : null)), ((process.ReadLeadContact.ResultEntity.IsColumnValueLoaded(process.ReadLeadContact.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? process.ReadLeadContact.ResultEntity.GetTypedColumnValue<string>("Name") : null))));
				_recordDefValues_Description = () => new LocalizableString(String.Format((process.NotificationTemplate), ((process.ReadLeadType.ResultEntity.IsColumnValueLoaded(process.ReadLeadType.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? process.ReadLeadType.ResultEntity.GetTypedColumnValue<string>("Name") : null)), ((process.ReadLeadContact.ResultEntity.IsColumnValueLoaded(process.ReadLeadContact.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? process.ReadLeadContact.ResultEntity.GetTypedColumnValue<string>("Name") : null))));
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

			private string _recordAddMode;
			public override string RecordAddMode {
				get {
					return _recordAddMode ?? (_recordAddMode = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,51,0,0,33,223,219,244,1,0,0,0 })));
				}
				set {
					_recordAddMode = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,89,203,110,91,55,16,253,21,225,38,139,20,48,5,190,31,222,58,73,97,32,73,131,56,205,38,242,98,56,28,38,66,245,48,174,174,82,184,134,255,189,67,217,78,108,183,85,156,119,139,74,11,201,162,238,12,201,225,156,51,103,232,179,238,254,112,122,66,221,126,247,146,250,30,86,203,58,140,15,150,61,141,159,247,75,164,213,106,252,100,137,48,155,254,1,121,70,207,161,135,57,13,212,191,130,217,154,86,79,166,171,97,111,116,211,172,219,235,238,191,219,252,218,237,191,62,235,14,7,154,255,122,88,216,187,74,154,140,199,40,98,65,41,108,142,94,128,73,32,0,92,41,89,87,210,165,25,227,114,182,158,47,158,210,0,207,97,120,219,237,159,117,27,111,236,128,124,165,26,172,23,21,92,18,86,74,18,49,120,254,203,218,96,108,86,160,165,233,206,247,186,21,190,165,57,108,38,253,96,12,20,192,101,244,66,41,87,133,165,162,69,10,232,132,50,213,161,83,86,163,9,205,248,242,249,15,134,11,250,125,244,243,122,90,30,76,58,171,160,198,68,73,4,39,51,251,200,89,68,4,20,181,154,148,189,141,86,17,78,186,159,154,155,50,93,157,204,224,244,213,215,241,118,114,35,236,215,253,157,77,46,78,111,210,237,79,254,233,252,46,63,143,54,97,185,121,130,183,15,111,210,237,77,186,163,229,186,199,230,209,240,151,135,215,54,178,153,100,243,200,173,175,87,167,197,35,139,245,108,118,57,242,16,6,184,122,240,106,120,89,166,117,74,229,112,113,116,117,72,27,47,242,242,37,254,230,237,234,117,177,182,47,49,123,10,11,120,67,253,51,14,192,135,181,191,95,229,75,14,227,149,227,172,147,147,65,85,17,8,56,193,200,107,206,90,5,34,169,148,171,9,70,215,170,55,214,47,168,82,79,11,164,155,11,3,93,172,12,160,4,22,176,194,26,107,5,96,80,34,70,176,164,115,77,168,227,165,253,106,19,237,6,147,203,117,181,80,157,119,231,231,123,215,193,35,37,79,109,19,59,4,226,244,117,154,68,162,108,5,39,144,206,217,163,133,88,183,130,199,74,101,141,194,34,84,113,154,33,163,146,0,85,149,8,222,7,48,206,218,162,241,235,131,231,245,189,215,135,171,95,126,95,80,127,17,159,253,10,179,21,29,143,121,244,214,192,251,188,220,63,11,33,87,116,86,9,5,28,114,155,29,137,92,66,16,134,172,78,104,179,55,161,158,31,223,59,222,134,179,215,247,158,16,148,209,178,77,125,241,228,14,67,255,49,12,41,159,185,94,56,6,13,151,6,97,21,115,126,44,69,10,136,210,20,235,163,41,197,124,18,134,200,21,208,6,72,132,168,189,96,130,173,34,146,145,205,107,65,165,61,4,237,182,98,72,58,198,160,169,133,203,78,138,140,106,94,86,70,107,4,214,28,100,205,86,71,105,255,37,24,50,18,171,231,197,114,180,162,18,22,121,155,32,99,228,226,226,157,11,154,145,100,213,221,48,180,67,207,15,65,143,54,82,69,231,3,179,180,65,206,53,205,121,234,99,16,181,248,154,24,23,41,229,178,13,61,119,94,216,93,209,99,52,72,165,18,99,70,42,98,245,197,107,129,200,98,76,25,227,117,54,197,129,133,173,232,65,10,53,5,25,133,195,92,120,71,202,139,204,2,80,216,228,201,24,149,156,209,223,4,61,71,167,171,87,208,79,155,124,29,31,172,123,142,213,192,17,167,151,211,57,125,44,255,217,148,247,63,122,119,203,124,212,108,71,176,40,163,230,104,7,144,31,2,144,162,21,37,170,86,160,244,44,177,164,98,50,214,177,53,7,10,162,10,138,133,151,253,174,0,97,108,164,80,125,195,134,229,172,198,18,68,74,92,254,36,160,75,96,144,213,87,218,10,16,168,164,184,138,4,65,73,49,103,107,195,0,9,236,197,217,92,156,139,65,165,248,13,250,27,102,249,229,242,183,245,201,184,32,102,202,209,9,7,220,138,88,86,150,34,213,74,44,24,1,0,51,135,181,184,49,120,95,100,36,37,52,183,107,130,152,17,88,216,74,224,168,41,231,138,108,60,229,62,90,85,46,230,123,182,28,56,209,16,134,233,114,49,186,72,232,241,65,79,140,168,50,202,167,59,84,253,16,84,125,169,104,187,75,18,125,18,170,180,66,80,26,85,171,131,92,53,144,29,230,228,145,27,31,46,135,224,200,65,220,126,107,80,163,44,73,5,110,36,106,226,55,175,130,200,158,81,5,181,86,200,42,167,226,194,215,71,213,209,208,79,23,111,198,143,151,253,28,134,7,159,39,225,52,164,12,190,54,62,113,194,2,20,145,192,25,94,189,138,153,245,157,135,148,154,132,219,27,221,221,253,163,25,205,185,128,237,159,17,82,52,62,123,81,92,225,115,110,61,33,64,149,34,25,96,113,157,185,121,117,246,252,230,122,138,147,62,176,76,22,153,207,163,17,46,235,96,131,40,156,41,81,178,176,214,218,133,102,242,104,49,76,135,211,131,205,129,112,51,103,60,139,79,8,76,211,196,86,149,179,42,75,99,133,118,142,85,3,103,149,55,230,179,119,145,178,171,193,150,42,136,248,68,109,163,164,172,137,55,229,181,137,46,37,27,82,189,181,11,62,245,160,53,55,210,57,88,166,234,216,244,191,49,70,56,15,69,89,73,158,2,254,117,23,224,16,33,36,110,67,66,225,44,212,17,216,170,102,150,50,73,231,82,152,247,107,108,187,216,122,247,115,59,39,94,208,124,186,40,60,52,226,108,103,139,38,37,90,24,94,180,206,21,215,171,97,57,167,126,180,224,189,141,31,79,251,213,48,154,54,49,178,172,163,158,86,235,217,208,12,57,237,103,132,141,65,199,13,68,215,236,103,27,39,203,197,0,56,220,197,252,49,131,111,180,216,248,216,93,57,253,8,230,117,8,198,85,197,125,154,146,173,99,107,210,63,121,16,134,27,93,240,80,1,43,126,95,193,143,46,160,97,194,209,214,115,187,108,209,50,69,88,46,250,30,81,135,6,135,24,183,50,111,168,22,29,165,198,183,137,107,1,171,178,118,9,38,5,99,214,20,205,184,207,234,27,232,153,29,243,238,152,119,199,188,59,230,253,132,78,178,100,3,138,72,200,64,145,17,201,154,55,7,70,75,225,156,100,192,75,89,191,243,85,75,37,158,211,113,251,87,131,100,112,97,64,6,87,102,246,44,190,214,130,38,98,180,219,255,83,70,193,48,83,121,225,84,100,228,104,12,23,42,60,153,144,13,171,123,43,107,249,250,204,59,233,218,125,225,164,219,134,196,235,207,236,18,253,127,152,232,199,231,127,2,58,202,38,107,112,30,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "2747a38633284c0da1bc2acc2ae61cfe",
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

			public ReadLeadDataFlowElement(UserConnection userConnection, LeadManagementDistribution78 process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,64,212,91,190,21,169,91,4,40,154,0,49,114,169,114,88,81,75,155,168,100,9,36,157,214,53,252,239,93,138,182,234,20,46,226,246,210,232,36,14,134,179,179,195,221,93,32,90,48,230,51,116,24,204,130,5,106,13,166,151,246,250,131,106,45,234,143,186,223,12,193,85,96,80,43,104,213,15,108,60,62,111,148,125,15,22,232,202,174,250,165,80,5,179,234,188,70,21,92,85,129,178,216,25,226,208,149,38,45,195,164,44,145,229,66,230,44,41,161,96,165,44,98,6,169,8,227,184,9,33,229,220,51,255,36,126,211,119,3,104,244,53,70,121,57,254,46,182,131,163,114,2,196,72,81,166,95,31,192,216,153,48,243,53,212,45,54,116,182,122,131,4,89,173,58,234,6,23,170,195,123,208,84,203,233,244,14,34,146,132,214,56,86,139,210,206,191,15,26,141,81,253,250,53,115,237,166,91,159,178,73,0,167,227,193,78,56,122,116,204,123,176,171,81,226,150,108,237,71,151,239,150,75,141,75,176,234,249,212,196,87,220,142,188,203,242,163,11,13,189,210,35,180,27,60,169,249,178,147,27,24,172,111,200,151,39,130,86,203,213,197,189,78,137,189,214,110,68,224,112,36,95,168,121,182,135,40,35,240,217,1,94,229,248,91,5,95,110,205,221,183,53,234,7,177,194,14,124,106,79,215,132,254,6,76,250,179,93,28,10,153,149,9,69,87,20,156,37,34,14,25,132,69,193,164,204,210,52,143,48,137,18,190,127,242,62,148,25,90,216,62,78,229,62,33,248,192,92,110,116,230,113,145,198,60,79,89,13,18,73,75,54,12,114,193,89,198,27,17,150,113,65,165,82,122,95,247,185,103,232,151,74,64,123,55,160,134,195,11,132,231,7,244,197,100,187,230,117,223,91,223,210,20,222,228,229,56,34,5,166,181,204,168,122,148,215,41,75,106,222,176,146,67,194,26,209,100,24,201,168,46,139,132,204,208,118,187,124,31,250,141,22,135,109,50,126,173,255,105,93,255,195,18,254,205,94,157,157,236,75,38,245,173,204,224,155,153,180,125,176,255,9,228,195,68,119,60,6,0,0 })));
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

			private bool _readSomeTopRecords = true;
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,73,77,76,241,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,197,68,70,233,19,0,0,0 })));
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

			public ReadLeadTypeFlowElement(UserConnection userConnection, LeadManagementDistribution78 process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,229,84,203,110,219,48,16,252,21,67,231,48,160,222,146,111,69,234,22,1,138,38,104,130,92,226,28,86,228,202,33,74,61,64,82,105,93,195,255,222,165,228,184,78,225,34,110,47,45,80,29,4,105,48,59,156,125,113,19,8,13,214,126,132,6,131,121,112,139,198,128,237,106,119,254,78,105,135,230,189,233,134,62,56,11,44,26,5,90,125,67,57,225,11,169,220,91,112,64,33,155,229,15,133,101,48,95,30,215,88,6,103,203,64,57,108,44,113,40,36,198,60,77,10,158,176,164,70,122,133,113,194,202,170,22,44,76,184,76,98,25,151,144,195,196,252,149,248,69,215,244,96,112,58,99,148,175,199,207,219,117,239,169,33,1,98,164,40,219,181,59,48,246,38,236,162,133,74,163,164,127,103,6,36,200,25,213,80,54,120,171,26,188,6,67,103,121,157,206,67,68,170,65,91,207,210,88,187,197,215,222,160,181,170,107,95,51,167,135,166,61,100,147,0,238,127,119,118,248,232,209,51,175,193,61,142,18,151,100,107,59,186,124,179,90,25,92,129,83,79,135,38,62,227,122,228,157,86,63,10,144,212,165,59,208,3,30,156,249,50,147,11,232,221,148,208,116,60,17,140,90,61,158,156,235,190,98,175,165,27,17,216,63,147,79,212,60,154,67,148,17,248,228,129,73,229,249,115,25,220,95,218,171,47,45,154,27,241,136,13,76,85,123,56,39,244,39,96,161,177,193,214,205,55,162,14,179,4,49,101,69,42,106,150,136,88,176,50,225,130,97,133,81,26,214,162,12,115,190,165,128,189,161,249,166,8,177,144,101,133,44,207,42,10,9,49,98,192,195,216,215,191,202,33,227,85,85,231,62,100,209,58,229,214,211,36,204,55,169,200,202,44,167,134,101,17,22,44,73,121,204,10,31,143,50,203,68,44,101,22,203,116,251,48,165,171,108,175,97,125,183,207,234,19,130,156,105,122,209,70,25,235,102,126,143,102,93,61,163,242,14,218,169,118,53,163,41,210,40,124,27,207,47,6,235,186,6,205,172,69,156,186,233,155,74,42,80,65,150,167,188,98,188,162,124,19,94,86,172,204,210,144,21,88,2,112,41,75,136,56,13,159,127,252,140,116,43,37,64,95,245,104,96,55,30,252,248,246,188,88,59,223,25,211,117,110,170,247,190,179,31,200,252,196,56,152,97,17,39,101,94,1,103,89,88,32,213,158,75,6,69,42,89,30,65,88,22,152,242,90,38,100,136,174,31,63,0,55,221,96,196,110,221,237,116,239,252,209,125,242,23,110,137,223,89,252,163,171,119,202,42,253,103,75,242,79,13,245,54,216,126,7,242,110,120,181,72,7,0,0 })));
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

			private bool _readSomeTopRecords = true;
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

			public ReadLeadContactFlowElement(UserConnection userConnection, LeadManagementDistribution78 process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,229,84,93,111,211,48,20,253,43,85,158,231,41,113,156,196,233,27,26,5,237,133,77,108,218,11,221,195,181,115,221,89,228,75,142,59,24,85,255,59,215,73,87,58,84,180,194,11,72,52,82,149,28,157,123,124,238,151,55,145,174,97,24,62,64,131,209,60,186,69,231,96,232,140,63,127,103,107,143,238,189,235,214,125,116,22,13,232,44,212,246,27,86,19,190,168,172,127,11,30,40,100,179,252,161,176,140,230,203,227,26,203,232,108,25,89,143,205,64,28,10,201,12,228,200,101,193,242,68,0,19,168,50,86,74,41,88,166,161,144,244,100,73,193,39,230,175,196,47,186,166,7,135,211,25,163,188,25,95,111,159,250,64,77,8,208,35,197,14,93,187,3,211,96,98,88,180,160,106,172,232,219,187,53,18,228,157,109,40,27,188,181,13,94,131,163,179,130,78,23,32,34,25,168,135,192,170,209,248,197,215,222,225,48,216,174,125,205,92,189,110,218,67,54,9,224,254,115,103,39,30,61,6,230,53,248,135,81,226,146,108,109,71,151,111,86,43,135,43,240,246,241,208,196,103,124,26,121,167,213,143,2,42,234,210,29,212,107,60,56,243,101,38,23,208,251,41,161,233,120,34,56,187,122,56,57,215,125,197,94,75,151,19,216,63,147,79,212,60,154,3,207,9,124,12,192,164,242,252,186,140,62,93,14,87,95,90,116,55,250,1,27,152,170,118,127,78,232,79,192,162,198,6,91,63,223,104,147,228,2,49,99,50,211,134,9,157,106,86,138,88,51,84,200,179,196,232,50,41,226,45,5,236,13,205,55,50,65,89,149,10,89,145,43,10,73,144,51,136,147,148,149,202,168,2,242,88,41,83,132,144,69,235,173,127,154,38,97,190,129,74,148,113,149,73,22,103,161,97,149,164,134,113,145,179,170,146,34,207,81,165,165,76,183,247,83,186,118,232,107,120,186,219,103,245,17,161,154,213,244,71,27,229,6,63,11,123,52,235,204,140,202,187,174,189,109,87,51,154,162,26,117,104,35,141,94,235,65,251,81,41,180,147,226,243,56,77,120,198,145,65,101,56,19,16,115,166,114,13,44,227,153,130,44,209,185,230,5,141,93,248,133,233,232,86,86,67,125,213,163,131,221,96,196,199,247,230,197,194,133,158,184,174,243,83,165,247,61,61,180,243,60,188,64,67,155,130,40,88,92,41,201,132,200,12,83,92,196,140,75,163,114,21,75,83,166,154,252,208,189,19,58,127,211,173,157,222,237,249,48,93,56,127,116,145,252,133,235,225,119,54,254,232,206,157,178,67,255,217,118,252,75,51,189,141,182,223,1,93,152,49,71,64,7,0,0 })));
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

			private bool _readSomeTopRecords = true;
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

			public DistributionLeadPageFlowElement(UserConnection userConnection, LeadManagementDistribution78 process)
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
				_ownerId = () => (Guid)(((Guid)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentUserContact")));
				_showExecutionPage = () => (bool)((process.ShowDistributionPage));
				_leadId = () => (Guid)((process.LeadId));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _title;
			public override LocalizableString Title {
				get {
					return _title ?? (_title = GetLocalizableString("2747a38633284c0da1bc2acc2ae61cfe",
						 "BaseElements.DistributionLeadPage.Parameters.Title.Value"));
				}
				set {
					_title = value;
				}
			}

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("2747a38633284c0da1bc2acc2ae61cfe",
						 "BaseElements.DistributionLeadPage.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
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

			internal Func<Guid> _ownerId;
			public override Guid OwnerId {
				get {
					return (_ownerId ?? (_ownerId = () => Guid.Empty)).Invoke();
				}
				set {
					_ownerId = () => { return value; };
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

			public SaveLeadByDefaultFlowElement(UserConnection userConnection, LeadManagementDistribution78 process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,64,18,41,75,242,173,72,221,34,64,209,4,136,145,75,149,195,146,90,217,68,245,2,73,167,117,13,255,123,151,146,173,58,133,139,184,189,52,58,137,131,225,236,236,114,118,23,168,26,172,253,12,13,6,243,96,137,198,128,237,42,119,253,65,215,14,205,71,211,109,250,224,42,176,104,52,212,250,7,150,35,190,40,181,123,15,14,232,202,174,248,165,80,4,243,226,188,70,17,92,21,129,118,216,88,226,208,21,148,81,10,21,112,134,81,20,51,1,74,49,9,105,204,114,46,101,200,83,46,202,60,30,153,127,18,191,233,154,30,12,142,53,6,249,106,248,93,110,123,79,141,8,80,3,69,219,174,61,128,220,155,176,139,22,100,141,37,157,157,217,32,65,206,232,134,186,193,165,110,240,30,12,213,242,58,157,135,136,84,65,109,61,171,198,202,45,190,247,6,173,213,93,251,154,185,122,211,180,167,108,18,192,233,120,176,19,14,30,61,243,30,220,122,144,184,37,91,251,193,229,187,213,202,224,10,156,126,62,53,241,21,183,3,239,178,249,209,133,146,94,233,17,234,13,158,212,124,217,201,13,244,110,108,104,44,79,4,163,87,235,139,123,157,38,246,90,187,49,129,253,145,124,161,230,217,30,226,25,129,207,30,24,85,142,191,69,240,229,214,222,125,107,209,60,168,53,54,48,78,237,233,154,208,223,128,73,127,190,227,161,170,102,185,224,12,178,44,98,66,241,144,65,152,101,172,170,102,73,146,198,40,98,17,237,159,70,31,218,246,53,108,31,167,114,159,16,198,129,249,185,209,185,140,64,113,44,115,150,200,100,198,68,20,70,76,86,42,103,233,44,20,74,242,8,101,42,232,125,253,231,159,161,91,105,5,245,93,143,6,14,47,16,158,15,232,139,100,251,230,77,215,185,177,165,105,120,147,151,99,68,68,149,43,25,75,201,68,169,56,69,164,4,150,197,73,206,68,26,34,100,60,161,160,80,68,246,180,221,126,190,15,221,198,168,195,54,217,113,173,255,105,93,255,195,18,254,205,94,157,77,246,37,73,125,43,25,124,51,73,219,7,251,159,58,179,138,198,60,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,151,75,111,27,71,12,128,255,138,176,201,209,52,230,253,208,53,233,193,128,211,24,117,154,139,237,3,103,134,108,4,232,97,236,174,83,164,130,254,123,41,89,138,31,109,237,160,61,164,1,188,135,213,46,69,114,40,146,223,112,180,238,94,143,95,174,169,155,118,31,168,239,113,88,241,120,252,102,213,211,241,89,191,170,52,12,199,167,171,138,243,217,31,88,230,116,134,61,46,104,164,254,35,206,111,104,56,157,13,227,209,228,161,89,119,212,189,254,188,251,182,155,94,172,187,147,145,22,191,158,52,241,158,18,99,35,91,161,69,77,224,178,79,144,147,54,96,171,206,193,4,237,90,41,98,92,87,243,155,197,242,29,141,120,134,227,167,110,186,238,118,222,196,129,55,73,71,235,18,184,170,52,56,165,61,96,12,1,106,209,170,198,226,189,171,169,219,28,117,67,253,68,11,220,45,122,103,236,52,114,202,148,33,122,85,192,81,41,144,42,86,96,182,185,4,151,156,166,186,53,222,235,223,25,94,188,186,56,25,222,255,190,164,254,124,231,119,202,56,31,232,234,88,164,143,4,95,147,51,93,199,88,184,122,167,65,163,70,112,197,19,148,22,35,88,114,38,87,87,130,141,188,185,122,117,181,93,177,205,134,235,57,126,249,248,215,133,79,9,219,100,181,93,250,86,243,250,65,246,239,235,174,47,111,139,120,217,77,47,255,169,140,251,207,219,160,31,22,242,113,13,47,187,163,203,238,124,117,211,215,173,71,43,47,111,239,5,185,91,100,167,242,232,245,80,52,145,44,111,230,243,189,228,45,142,120,80,60,136,87,109,198,51,106,39,203,243,67,173,118,94,212,254,130,191,185,29,174,219,216,254,139,217,59,92,226,111,212,255,44,9,184,139,253,107,148,31,36,141,7,199,197,100,175,162,102,136,132,89,154,38,24,72,77,10,154,117,46,108,163,53,204,102,103,253,11,49,245,180,172,244,48,48,29,10,217,224,53,36,38,3,78,251,44,246,77,1,38,101,155,11,201,182,102,247,246,195,46,219,91,90,246,113,109,83,181,233,54,155,163,251,12,217,172,99,81,209,1,54,95,193,57,114,80,182,68,132,228,74,145,166,51,153,243,147,12,153,152,153,44,41,136,185,42,112,156,20,20,84,12,236,67,99,227,60,187,92,255,39,12,229,218,44,167,96,65,81,19,134,172,77,144,178,128,148,35,39,131,141,201,169,240,60,67,111,122,194,145,38,61,45,102,203,70,253,132,87,253,11,82,223,17,169,172,74,240,133,19,40,102,233,96,45,123,100,138,49,131,113,70,201,3,114,86,241,41,164,190,57,176,111,69,170,22,68,147,146,135,106,85,3,105,226,6,25,3,131,205,206,7,212,185,17,165,167,199,82,85,140,49,7,40,42,89,249,69,38,0,86,129,164,114,107,213,120,111,51,170,239,137,212,79,115,90,208,114,156,174,45,249,16,148,236,22,36,148,131,147,42,64,110,166,129,87,42,132,108,140,42,142,54,15,25,244,201,86,133,81,82,66,77,76,36,164,221,222,7,92,66,69,100,214,134,219,243,12,74,167,143,253,172,220,140,179,213,114,114,45,141,114,252,254,133,192,151,161,118,32,16,147,175,65,201,110,16,34,243,246,176,164,161,68,142,224,115,245,33,169,170,228,224,248,36,129,232,20,6,199,8,168,72,38,133,34,233,82,23,5,67,241,160,27,151,146,45,255,168,4,38,99,162,156,114,9,40,68,217,93,20,106,64,203,22,140,86,134,216,75,137,34,254,27,2,207,113,78,195,164,205,62,207,6,145,189,160,248,67,162,232,91,146,33,85,28,104,47,71,58,215,200,203,16,146,27,178,252,37,226,16,179,204,166,231,80,188,218,252,9,154,74,162,23,1,14,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "2747a38633284c0da1bc2acc2ae61cfe",
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

		#region Class: IntermediateCatchSignal1FlowElement

		/// <exclude/>
		public class IntermediateCatchSignal1FlowElement : ProcessIntermediateCatchSignalEvent
		{

			#region Constructors: Public

			public IntermediateCatchSignal1FlowElement(UserConnection userConnection, LeadManagementDistribution78 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchSignalEvent";
				Name = "IntermediateCatchSignal1";
				IsLogging = true;
				SchemaElementUId = new Guid("dbcbd41e-b326-4d01-b8f3-3d49f00820fe");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				Message = "";
				WaitingRandomSignal = false;
				WaitingEntitySignal = true;
				EntitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
				EntitySignal = EntityChangeType.Updated;
				HasEntityColumnChange = true;
				HasEntityFilters = false;
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, mscorlib]], mscorlib"",""$values"":[""bc0c2d60-5a3d-4840-aa4e-c60ea776e206""]}";
				EntityFilters = @"{""className"":""Terrasoft.FilterGroup"",""serializedFilterEditData"":""{\""className\"":\""Terrasoft.FilterGroup\"",\""items\"":{\""fe5d2409-9f82-49cf-b246-2d86ac466b83\"":{\""className\"":\""Terrasoft.InFilter\"",\""filterType\"":4,\""comparisonType\"":4,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""className\"":\""Terrasoft.ColumnExpression\"",\""expressionType\"":0,\""columnPath\"":\""QualifyStatus\""},\""isAggregative\"":false,\""key\"":\""fe5d2409-9f82-49cf-b246-2d86ac466b83\"",\""dataValueType\"":10,\""leftExpressionCaption\"":\""Lead stage\"",\""referenceSchemaName\"":\""QualifyStatus\"",\""rightExpressions\"":[{\""className\"":\""Terrasoft.ParameterExpression\"",\""expressionType\"":2,\""parameter\"":{\""className\"":\""Terrasoft.Parameter\"",\""dataValueType\"":10,\""value\"":{\""Id\"":\""ceb70b3c-985f-4867-ae7c-88f9dd710688\"",\""Name\"":\""Handoff to sales\"",\""value\"":\""ceb70b3c-985f-4867-ae7c-88f9dd710688\"",\""displayValue\"":\""Handoff to sales\""}}}]}},\""logicalOperation\"":0,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Lead\"",\""key\"":\""83621912-8d00-4adf-874d-f52cb98cac29\""}"",""dataSourceFilters"":""{\""items\"":{\""fe5d2409-9f82-49cf-b246-2d86ac466b83\"":{\""filterType\"":4,\""comparisonType\"":4,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""expressionType\"":0,\""columnPath\"":\""QualifyStatus\""},\""rightExpressions\"":[{\""expressionType\"":2,\""parameter\"":{\""dataValueType\"":10,\""value\"":\""ceb70b3c-985f-4867-ae7c-88f9dd710688\""}}]}},\""logicalOperation\"":0,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Lead\""}""}";
				_recordId = () => (Guid)((process.LeadId));
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

		#region Class: ParallelGateway1FlowElement

		/// <exclude/>
		public class ParallelGateway1FlowElement : ProcessParallelGateway
		{

			public ParallelGateway1FlowElement(UserConnection userConnection, LeadManagementDistribution78 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessParallelGateway";
				Name = "ParallelGateway1";
				IsLogging = true;
				SchemaElementUId = new Guid("62282042-1255-4e64-85bb-e0f48d66d46e");
				CreatedInSchemaUId = process.InternalSchemaUId;
				IncomingTokens = new Dictionary<string, bool> { { "LinkLeadToProcess", false }, };
				SerializeToDB = Owner.SerializeToDB;
			}

		}

		#endregion

		#region Class: LinkLeadToProcessFlowElement

		/// <exclude/>
		public class LinkLeadToProcessFlowElement : LinkEntityToProcessUserTask
		{

			#region Constructors: Public

			public LinkLeadToProcessFlowElement(UserConnection userConnection, LeadManagementDistribution78 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "LinkLeadToProcess";
				IsLogging = true;
				SchemaElementUId = new Guid("030582fb-9053-4d10-9c8d-0d58e8ad1641");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_entityId = () => (Guid)((process.LeadId));
			}

			#endregion

			#region Properties: Public

			internal Func<Guid> _entityId;
			public override Guid EntityId {
				get {
					return (_entityId ?? (_entityId = () => Guid.Empty)).Invoke();
				}
				set {
					_entityId = () => { return value; };
				}
			}

			private Guid _entitySchemaId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			#endregion

		}

		#endregion

		public LeadManagementDistribution78(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadManagementDistribution78";
			SchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_createReminder = () => { return (bool)((DistributionLeadPage.RemindToOwner)); };
			_responsibleId = () => { return (Guid)((DistributionLeadPage.LeadOwnerId)); };
			_showDistributionPage = () => { return (bool)(false); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: LeadManagementDistribution78, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: LeadManagementDistribution78, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		private Func<string> _notificationCaption;
		public virtual string NotificationCaption {
			get {
				return (_notificationCaption ?? (_notificationCaption = () => null)).Invoke();
			}
			set {
				_notificationCaption = () => { return value; };
			}
		}

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

		private Func<bool> _showDistributionPage;
		public virtual bool ShowDistributionPage {
			get {
				return (_showDistributionPage ?? (_showDistributionPage = () => false)).Invoke();
			}
			set {
				_showDistributionPage = () => { return value; };
			}
		}

		private string _notificationTemplate;
		public virtual string NotificationTemplate {
			get {
				return _notificationTemplate ?? (_notificationTemplate = GetLocalizableString("2747a38633284c0da1bc2acc2ae61cfe",
						 "Parameters.NotificationTemplate.Value"));
			}
			set {
				_notificationTemplate = value;
			}
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
					IsLogging = true,
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
					IsLogging = true,
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
					IsLogging = true,
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
					IsLogging = true,
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
					IsLogging = true,
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

		private SaveLeadByDefaultFlowElement _saveLeadByDefault;
		public SaveLeadByDefaultFlowElement SaveLeadByDefault {
			get {
				return _saveLeadByDefault ?? (_saveLeadByDefault = new SaveLeadByDefaultFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private IntermediateCatchSignal1FlowElement _intermediateCatchSignal1;
		public IntermediateCatchSignal1FlowElement IntermediateCatchSignal1 {
			get {
				return _intermediateCatchSignal1 ?? ((_intermediateCatchSignal1) = new IntermediateCatchSignal1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ParallelGateway1FlowElement _parallelGateway1;
		public ParallelGateway1FlowElement ParallelGateway1 {
			get {
				return _parallelGateway1 ?? ((_parallelGateway1) = new ParallelGateway1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private LinkLeadToProcessFlowElement _linkLeadToProcess;
		public LinkLeadToProcessFlowElement LinkLeadToProcess {
			get {
				return _linkLeadToProcess ?? (_linkLeadToProcess = new LinkLeadToProcessFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessInclusiveGateway _inclusiveGateway1;
		public ProcessInclusiveGateway InclusiveGateway1 {
			get {
				return _inclusiveGateway1 ?? (_inclusiveGateway1 = new ProcessInclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaInclusiveGateway",
					Name = "InclusiveGateway1",
					SchemaElementUId = new Guid("7ce091e6-4511-4f24-aa1c-98b98f288332"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.InclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
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

		private ProcessConditionalFlow _conditionalSequenceFlow1;
		public ProcessConditionalFlow ConditionalSequenceFlow1 {
			get {
				return _conditionalSequenceFlow1 ?? (_conditionalSequenceFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow1",
					SchemaElementUId = new Guid("0ae66221-8406-4b11-ac9c-ce039b98f222"),
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
			FlowElements[AddReminder.SchemaElementUId] = new Collection<ProcessFlowElement> { AddReminder };
			FlowElements[ReadLeadData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadData };
			FlowElements[ReadLeadType.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadType };
			FlowElements[ReadLeadContact.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadContact };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[DistributionLeadPage.SchemaElementUId] = new Collection<ProcessFlowElement> { DistributionLeadPage };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[SaveLeadByDefault.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveLeadByDefault };
			FlowElements[IntermediateCatchSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchSignal1 };
			FlowElements[ParallelGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ParallelGateway1 };
			FlowElements[LinkLeadToProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { LinkLeadToProcess };
			FlowElements[InclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { InclusiveGateway1 };
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
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LinkLeadToProcess", e.Context.SenderName));
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
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("DistributionLeadPage", e.Context.SenderName));
						break;
					case "IntermediateCatchSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("InclusiveGateway1", e.Context.SenderName));
						break;
					case "ParallelGateway1":
						if (ParallelGateway1.IsAllPreviousFlowElementsExecuted()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("IntermediateCatchSignal1", e.Context.SenderName));
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("DistributionLeadPage", e.Context.SenderName));
						}
						break;
					case "LinkLeadToProcess":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ParallelGateway1", e.Context.SenderName));
						break;
					case "InclusiveGateway1":
						bool isInclusiveGateway1ConditionsEvulated = false;
						if (ConditionalSequenceFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateHandoff", e.Context.SenderName));
							isInclusiveGateway1ConditionsEvulated = true;
						} 
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

		private bool ConditionalSequenceFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean((DistributionLeadPage.Result) != "TransferToSale");
			Log.InfoFormat(ConditionalExpressionLogMessage, "InclusiveGateway1", "ConditionalSequenceFlow1", "(DistributionLeadPage.Result) != \"TransferToSale\"", result);
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
			if (!HasMapping("NotificationTemplate")) {
				writer.WriteValue("NotificationTemplate", NotificationTemplate, null);
			}
			if (!HasMapping("CreateReminder")) {
				writer.WriteValue("CreateReminder", CreateReminder, false);
			}
			if (!HasMapping("ResponsibleId")) {
				writer.WriteValue("ResponsibleId", ResponsibleId, Guid.Empty);
			}
			if (!HasMapping("ShowDistributionPage")) {
				writer.WriteValue("ShowDistributionPage", ShowDistributionPage, false);
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
			MetaPathParameterValues.Add("32a9ba6f-4045-4aad-9a53-b618b30c6a99", () => NotificationTemplate);
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
			MetaPathParameterValues.Add("9891f0ad-db82-488b-aedd-64f50dc28baf", () => ReadLeadData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("58751358-9137-4811-8c8b-e31b4917cc58", () => ReadLeadData.ConsiderTimeInFilter);
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
			MetaPathParameterValues.Add("ebb14ab8-1576-4069-9eff-8964285cc2b3", () => ReadLeadType.ResultCompositeObjectList);
			MetaPathParameterValues.Add("fd914a29-a951-4c58-a6e5-7402fa7e8761", () => ReadLeadType.ConsiderTimeInFilter);
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
			MetaPathParameterValues.Add("76b641e0-afa5-49a2-a9f7-6c63a2f449de", () => ReadLeadContact.ResultCompositeObjectList);
			MetaPathParameterValues.Add("4ea3d1b9-bd07-4221-9d68-e9102d93f89a", () => ReadLeadContact.ConsiderTimeInFilter);
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
			MetaPathParameterValues.Add("b6ff1632-8447-43c2-9b76-658146844be1", () => DistributionLeadPage.Template);
			MetaPathParameterValues.Add("7235fee8-643a-4105-bf60-d6e3855e65b9", () => DistributionLeadPage.Module);
			MetaPathParameterValues.Add("f164d1ac-d486-4ad3-91da-1174260bbd01", () => DistributionLeadPage.PressedButtonCode);
			MetaPathParameterValues.Add("1c855ecf-3361-49bf-825f-6281043116c4", () => DistributionLeadPage.Url);
			MetaPathParameterValues.Add("345b747f-6492-4686-a503-0062acd716e0", () => DistributionLeadPage.LeadId);
			MetaPathParameterValues.Add("a9e78508-ae1b-4141-abe0-24ed11eadb13", () => DistributionLeadPage.Result);
			MetaPathParameterValues.Add("cd5eefc4-6c19-4719-be10-6babbc9acc6e", () => DistributionLeadPage.RemindToOwner);
			MetaPathParameterValues.Add("0d01d7bb-ccf9-4184-a64f-953b68988ea4", () => DistributionLeadPage.LeadOwnerId);
			MetaPathParameterValues.Add("8227a76e-e673-40a1-a3f3-2102ef5efe7a", () => DistributionLeadPage.OpportunityDepartment);
			MetaPathParameterValues.Add("560bc47f-ebc5-4687-aa0c-08705e061a9a", () => SaveLeadByDefault.EntitySchemaUId);
			MetaPathParameterValues.Add("c4e20e54-2a71-4e75-a167-24858aec6fcb", () => SaveLeadByDefault.IsMatchConditions);
			MetaPathParameterValues.Add("ba1c792f-b05d-43b6-b1d4-1f6f092ae9d7", () => SaveLeadByDefault.DataSourceFilters);
			MetaPathParameterValues.Add("f3fd0d58-28e8-457f-8737-49c12cc4cc1d", () => SaveLeadByDefault.RecordColumnValues);
			MetaPathParameterValues.Add("3113a34a-8da2-40e6-8256-f154360ef8a5", () => IntermediateCatchSignal1.RecordId);
			MetaPathParameterValues.Add("eaf23f6b-c09c-445f-910f-846067cc4260", () => LinkLeadToProcess.EntityId);
			MetaPathParameterValues.Add("eb235528-1302-40b2-8b0d-75f09ed4804b", () => LinkLeadToProcess.EntitySchemaId);
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
				case "NotificationTemplate":
					if (!hasValueToRead) break;
					NotificationTemplate = reader.GetValue<System.String>();
				break;
				case "CreateReminder":
					if (!hasValueToRead) break;
					CreateReminder = reader.GetValue<System.Boolean>();
				break;
				case "ResponsibleId":
					if (!hasValueToRead) break;
					ResponsibleId = reader.GetValue<System.Guid>();
				break;
				case "ShowDistributionPage":
					if (!hasValueToRead) break;
					ShowDistributionPage = reader.GetValue<System.Boolean>();
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
			var cloneItem = (LeadManagementDistribution78)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

