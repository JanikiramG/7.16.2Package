namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: LeadManagementQualification78Schema

	/// <exclude/>
	public class LeadManagementQualification78Schema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LeadManagementQualification78Schema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LeadManagementQualification78Schema(LeadManagementQualification78Schema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LeadManagementQualification78";
			UId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a");
			CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = false;
			Tag = @"LeadManagementQualification.7.8.0";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			UseForceCompile = true;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,90,221,111,219,54,16,127,118,129,254,15,108,30,10,25,48,148,237,185,77,129,196,78,139,108,109,147,38,105,11,116,216,3,45,211,49,87,89,242,40,41,169,183,246,127,223,145,60,82,164,68,202,14,178,13,27,80,244,161,230,241,190,121,247,227,135,242,248,209,166,153,231,60,35,183,92,212,13,205,201,109,201,23,228,66,148,25,171,170,227,44,43,155,162,78,198,228,207,199,143,70,175,26,152,161,154,116,182,32,71,228,53,163,139,99,51,126,6,28,243,178,204,73,38,24,173,25,210,129,107,234,142,207,139,119,96,132,47,121,70,107,94,22,82,232,150,10,163,21,184,11,118,71,174,153,16,180,42,151,117,58,45,139,37,191,105,132,98,78,141,59,239,43,38,96,166,96,153,36,143,173,101,212,114,250,133,87,117,5,186,150,52,175,152,156,229,75,146,88,199,211,179,234,116,189,169,183,201,88,135,53,114,67,146,49,166,111,217,157,252,63,81,154,191,17,6,90,60,78,107,0,199,233,75,86,103,171,151,162,92,207,78,90,59,90,26,173,63,241,68,209,176,156,240,178,133,244,145,151,216,214,142,78,178,117,35,29,154,187,98,245,140,45,167,101,222,172,139,15,52,111,88,165,195,241,226,25,9,86,55,162,208,116,215,219,170,22,188,184,129,76,189,109,242,252,92,232,124,57,94,189,165,107,214,73,95,42,105,126,81,72,138,155,132,160,86,87,220,168,108,221,146,162,16,138,138,192,176,78,200,193,249,93,193,68,181,226,155,179,197,193,68,153,180,20,21,101,76,196,103,143,177,158,21,139,6,124,221,90,110,67,136,9,96,188,83,88,201,155,210,145,235,208,99,226,144,136,188,220,50,6,121,89,207,29,39,59,244,168,245,162,128,158,186,100,183,172,104,88,107,219,165,42,81,147,105,104,159,227,197,154,23,151,252,102,229,247,137,45,30,122,203,18,69,213,54,183,69,102,66,41,215,235,166,192,238,173,146,182,18,21,99,180,102,143,23,38,23,240,75,0,178,248,109,2,171,44,255,133,144,200,198,123,90,212,188,222,18,166,254,155,16,93,75,228,86,206,201,210,153,144,243,249,111,0,8,154,162,235,72,214,156,26,146,35,0,22,168,57,242,245,171,238,112,85,122,233,233,239,96,166,74,80,2,230,130,5,170,166,211,235,242,74,77,2,106,4,139,84,251,37,219,206,233,185,196,113,79,91,25,14,22,97,23,176,173,166,153,7,187,153,38,89,216,157,154,177,65,80,100,216,129,160,70,115,0,65,49,161,168,199,105,230,105,75,49,88,106,189,233,97,105,28,61,28,197,134,121,228,70,213,71,94,59,31,7,51,203,161,84,100,110,82,134,129,78,207,41,111,141,10,23,196,173,166,240,98,223,43,74,163,31,83,154,249,233,148,234,166,78,26,188,24,108,241,35,21,154,125,198,168,192,14,151,63,199,17,182,157,104,215,178,254,84,206,175,121,157,51,228,125,9,209,24,82,76,228,10,198,181,170,168,235,237,166,133,156,150,60,96,203,114,195,239,24,219,140,109,168,168,215,76,226,131,13,214,144,98,66,175,88,177,112,98,214,195,184,133,140,87,224,232,101,153,51,199,70,75,84,130,102,233,84,19,137,53,147,11,84,139,134,185,115,113,52,181,213,219,71,83,92,241,14,154,182,197,60,70,208,212,124,6,51,253,249,33,208,140,154,240,193,68,87,232,140,43,20,160,98,251,92,78,27,108,125,65,114,213,253,174,60,194,75,76,66,119,229,240,9,226,164,169,120,1,209,92,172,202,194,246,72,223,210,47,210,142,194,2,143,46,235,13,34,131,51,84,250,177,20,159,149,18,136,227,87,196,42,79,249,238,110,149,34,111,202,57,207,217,131,189,113,212,56,254,56,212,253,188,57,93,83,158,63,196,15,165,192,241,64,141,219,147,84,46,183,72,38,15,161,96,95,31,43,204,162,234,201,238,214,32,253,72,53,242,38,7,90,224,64,19,37,84,38,7,161,50,67,134,143,43,38,152,229,128,46,27,203,237,66,238,185,137,86,152,94,80,1,48,88,51,225,1,46,173,208,23,233,246,107,112,245,185,41,200,204,51,230,149,164,203,167,203,80,150,194,13,73,102,39,167,95,88,214,212,165,32,139,185,253,121,68,252,56,211,211,162,106,4,155,157,180,36,187,167,161,162,179,25,173,233,37,164,148,9,34,244,127,71,221,84,166,218,0,211,108,73,107,112,60,214,251,208,221,10,234,129,36,90,62,149,108,214,140,221,41,188,240,82,104,126,195,254,138,213,120,8,249,97,12,7,146,215,229,29,216,24,227,78,248,205,61,196,171,108,252,204,182,10,246,46,40,23,126,159,202,76,186,101,5,135,27,64,12,8,39,92,117,184,146,5,57,122,65,158,4,157,84,107,204,1,95,138,244,3,30,151,140,119,202,83,112,71,47,202,178,132,88,178,21,73,226,206,249,190,17,94,4,157,197,164,57,71,31,207,103,172,138,80,117,134,14,63,163,144,142,248,177,35,200,173,75,64,109,225,46,89,9,198,165,122,125,140,167,0,151,7,114,53,164,32,114,120,136,196,228,111,70,223,118,238,35,225,131,191,255,22,240,191,222,71,222,64,225,254,13,251,200,75,250,229,33,94,128,184,99,31,70,251,89,253,200,230,21,175,31,182,143,178,185,99,25,21,254,131,59,70,168,160,252,29,195,94,35,135,118,140,182,248,190,239,24,223,119,140,251,237,24,52,80,130,88,21,161,234,12,238,24,33,29,241,29,35,200,189,115,199,8,74,221,103,199,8,42,136,191,44,134,99,186,207,142,209,187,179,132,46,28,18,210,212,19,149,230,145,49,180,15,9,228,233,83,98,31,65,167,242,77,37,60,117,201,110,164,119,17,57,25,134,8,137,94,197,144,244,19,223,236,193,133,46,135,159,5,14,15,167,43,150,125,38,188,34,84,243,17,154,203,78,220,234,174,175,48,246,179,10,213,232,215,224,68,153,52,231,100,156,130,43,169,71,86,151,84,255,209,100,210,198,235,100,114,226,103,111,210,205,216,164,151,37,135,2,73,232,107,141,6,171,158,174,237,203,147,9,121,9,40,175,182,18,255,101,10,149,249,7,51,83,37,129,6,243,197,162,157,213,189,219,35,191,124,22,109,115,210,62,138,182,180,29,210,50,119,86,76,14,118,240,235,228,90,9,61,220,101,67,231,191,53,163,199,59,164,96,141,144,255,83,247,181,59,150,3,63,250,80,122,163,167,200,238,50,120,96,48,12,4,157,23,223,208,145,241,59,18,132,144,192,79,156,69,130,246,88,132,20,155,204,255,8,18,152,175,120,49,36,160,94,92,254,134,59,128,4,190,216,110,36,240,249,239,139,4,61,233,29,72,208,227,223,3,9,250,54,246,65,130,158,212,0,18,196,114,16,64,130,78,122,163,167,131,238,50,236,129,4,234,171,108,183,198,241,67,3,22,201,53,157,231,248,133,4,39,4,203,213,193,67,175,176,158,82,216,225,79,168,56,113,134,186,69,239,82,116,221,187,20,83,250,30,151,169,126,244,224,15,190,65,237,190,175,31,218,79,75,170,156,53,21,175,72,123,95,137,228,170,249,20,179,54,206,45,169,155,29,247,126,212,79,208,192,53,41,144,180,238,133,201,92,50,157,44,246,191,145,187,177,166,199,197,34,233,116,213,208,77,205,105,181,206,71,241,118,149,246,177,136,157,184,219,148,234,210,160,169,238,94,17,55,102,219,120,183,57,108,241,112,108,221,253,103,32,60,11,2,123,68,136,0,97,109,234,63,189,40,215,27,42,24,84,88,247,175,31,158,4,247,49,83,232,198,41,51,6,105,243,179,189,151,165,215,130,175,241,58,179,191,202,145,231,147,249,120,98,175,157,174,219,237,190,176,135,235,94,75,250,57,53,33,184,195,251,134,17,82,63,234,249,217,11,231,95,121,65,240,75,39,254,126,128,94,31,30,94,179,170,38,234,18,141,162,233,238,151,133,22,10,193,226,224,107,130,155,80,43,71,109,142,122,178,63,70,101,85,49,128,197,55,180,6,95,157,50,48,115,168,53,52,127,120,248,174,225,53,185,91,177,194,26,135,211,215,154,214,43,205,160,191,91,219,90,132,243,157,246,231,125,205,115,94,115,86,225,159,3,156,221,20,165,96,83,90,49,89,203,19,210,43,104,213,38,198,5,91,1,248,156,226,77,182,63,143,156,214,124,214,243,199,20,212,62,62,81,179,163,7,43,212,246,64,220,191,14,131,63,60,234,244,162,227,171,13,6,188,116,133,90,211,250,84,216,55,233,189,51,33,147,89,58,117,110,248,11,52,161,35,22,132,38,0,0 };
			RealUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a");
			Version = 0;
			PackageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateLeadIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7da3d394-c5b2-4fba-be47-747a00d3685e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateAccountIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("adff468f-5785-4238-a962-2d46a6df9207"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"AccountId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateContactIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("21f03e5d-1b78-48dc-9e30-1c86f9161488"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"ContactId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadAddressTypeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2365f649-230d-4d6e-b38b-15932b94c2d9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadAddressType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{66852a75-b22e-4390-a8df-49814cdb0131}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadCityParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a00b4828-9039-473d-9786-1042a8a4d495"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadCity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{4258b690-fe71-4b7a-8278-f0a7b9dd4780}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadZipParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b9c2234b-9f29-4b4b-bff9-43ed0aee7fd4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadZip",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadRegionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b120b526-724c-470e-9bde-cca7c5bce38b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadRegion",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{dce30e38-3b37-40b3-b9f5-08b790d93420}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadCountryParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7f25c2c6-3a0b-430a-b8f4-14dac4a33300"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadCountry",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{d79b4d09-4791-4993-952b-e097088b55c6}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadWebsiteParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7573b5d0-d90d-43fb-a4ff-b434212f304d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadWebsite",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadFaxParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ef248d37-29b4-41f3-ae05-29aa2ca78c1e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadFax",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadBusinessPhoneParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("237e51db-51d4-40d3-ba2e-657d419fe693"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadBusinessPhone",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadEmailParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6547686a-48b1-457a-810e-01431f20fcf7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadEmail",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadMobilePhoneParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f609b031-6cfd-4dbc-9110-5a3c4aaf1d59"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadMobilePhone",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadDecisionRoleParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7d3339ff-d4dd-47f4-aad0-f962a3c06682"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadDecisionRole",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{4a577f44-6cf7-40d0-b1f8-81c2cf6539d1}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadGenderParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("26e960a5-407f-49ef-9aeb-194c10c5c07a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadGender",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{257a1321-f45d-4868-bf44-e9f2297661d3}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadDepartmentParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8ad4103a-0d1e-4f62-a22a-707a1d45a404"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadDepartment",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{c7fb190e-51d8-4c65-a5db-c3714d3b0af7}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadJobParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a0f4b101-277c-452d-94c8-b44202a3a196"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadJob",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{aa8c19b4-a8fb-4284-b969-8f15630a25ec}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadSalutationParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f34298ea-de28-49a3-a7dd-0537e9d81810"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadSalutation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{afdaca14-10c0-4767-b1f4-ed06946d37eb}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadDearParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("61ebe384-47c3-41a5-8f7a-689cc754debd"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadDear",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadFullJobTitleParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("69d73113-cfb5-46b5-bad8-db01b0089ad7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadFullJobTitle",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadContactNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9ccf4757-79ad-4fda-8a8d-091f07d873c6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadContactName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadAccountNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d7cbdc44-a5b7-48dc-bbaf-a96bd83d7066"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadAccountName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadAnnualRevenueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("485ac59c-8ec0-45f6-b314-99549ce9eedf"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadAnnualRevenue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{718683e1-7d00-48d6-ad3f-c882ee2ce79f}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadEmployeesNumberParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("81219640-87de-43de-9f88-0867fbbd7c43"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadEmployeesNumber",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{49508aa7-fa69-4ce3-aa4d-1eeb2c9d73a5}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadAccountCategoryParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("347c7337-e229-470b-a321-5aa2e5a4d102"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadAccountCategory",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{a3200694-9a9a-42a6-824f-870d5b03e255}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadIndustryParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7ab43aa0-0265-44da-baf7-13ae2e552bfe"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadIndustry",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{2edaf1d4-f64e-4351-aa6b-c81a7ebfc108}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadOwnershipParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5b328e21-1e24-46e8-a579-71076a3c942a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadOwnership",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{6a7045c5-ab82-4bf9-a929-9ac065c69343}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadAccountIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ae489f7c-9167-44af-a723-c61c0541a93a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadAccountId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{32949ae4-ff13-48f5-9f5d-45a74558ea55}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadContactIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f302fbc3-0ce9-4626-9957-2cf93197d6fd"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadContactId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{ad490d58-054a-4d85-9246-dd8466eb3983}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadAddressParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c945f2af-1eae-4ba3-a433-a8ea8b69d8b1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadAddress",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateCreateAccountOnQualificationParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("70ebb313-bd3c-472f-bf4f-f07a23506a9c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"CreateAccountOnQualification",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a188ff27-c185-4b79-b24c-71503e5df1a6}].[Parameter:{411b2f2b-abb2-49c4-b63c-c589bc81bb8c}].[EntityColumn:{297f4697-d071-4be2-8509-9090c07dfe18}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadQualificationPassedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9c638b0f-7b13-46c3-bef4-2010a78fb3a4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadQualificationPassed",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{d46a1b66-17a7-4603-b1ce-49313701da31}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadOwnerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d957170c-e768-44a5-a025-d5d08a8f9f76"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadOwner",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{52817348-4c01-4015-a766-cb10c7b554c8}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateLeadIdParameter());
			Parameters.Add(CreateAccountIdParameter());
			Parameters.Add(CreateContactIdParameter());
			Parameters.Add(CreateLeadAddressTypeParameter());
			Parameters.Add(CreateLeadCityParameter());
			Parameters.Add(CreateLeadZipParameter());
			Parameters.Add(CreateLeadRegionParameter());
			Parameters.Add(CreateLeadCountryParameter());
			Parameters.Add(CreateLeadWebsiteParameter());
			Parameters.Add(CreateLeadFaxParameter());
			Parameters.Add(CreateLeadBusinessPhoneParameter());
			Parameters.Add(CreateLeadEmailParameter());
			Parameters.Add(CreateLeadMobilePhoneParameter());
			Parameters.Add(CreateLeadDecisionRoleParameter());
			Parameters.Add(CreateLeadGenderParameter());
			Parameters.Add(CreateLeadDepartmentParameter());
			Parameters.Add(CreateLeadJobParameter());
			Parameters.Add(CreateLeadSalutationParameter());
			Parameters.Add(CreateLeadDearParameter());
			Parameters.Add(CreateLeadFullJobTitleParameter());
			Parameters.Add(CreateLeadContactNameParameter());
			Parameters.Add(CreateLeadAccountNameParameter());
			Parameters.Add(CreateLeadAnnualRevenueParameter());
			Parameters.Add(CreateLeadEmployeesNumberParameter());
			Parameters.Add(CreateLeadAccountCategoryParameter());
			Parameters.Add(CreateLeadIndustryParameter());
			Parameters.Add(CreateLeadOwnershipParameter());
			Parameters.Add(CreateLeadAccountIdParameter());
			Parameters.Add(CreateLeadContactIdParameter());
			Parameters.Add(CreateLeadAddressParameter());
			Parameters.Add(CreateCreateAccountOnQualificationParameter());
			Parameters.Add(CreateLeadQualificationPassedParameter());
			Parameters.Add(CreateLeadOwnerParameter());
		}

		protected virtual void InitializeReadLeadDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("eb174310-4f6b-4191-b705-5ac74e8d6810"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,64,79,147,242,173,72,221,34,64,209,4,136,145,75,149,195,138,90,217,68,245,2,73,167,117,13,255,123,151,162,173,58,133,139,184,189,52,58,137,131,225,236,236,112,119,23,200,6,140,249,12,45,6,243,96,137,90,131,233,107,123,253,65,53,22,245,71,221,111,134,224,42,48,168,21,52,234,7,86,30,95,84,202,190,7,11,116,101,87,252,82,40,130,121,113,94,163,8,174,138,64,89,108,13,113,232,10,230,137,228,178,76,89,197,101,198,210,186,230,44,175,65,178,188,20,89,157,199,81,4,124,230,153,127,18,191,233,219,1,52,250,26,163,124,61,254,46,183,131,163,70,4,200,145,162,76,223,29,192,196,153,48,139,14,202,6,43,58,91,189,65,130,172,86,45,117,131,75,213,226,61,104,170,229,116,122,7,17,169,134,198,56,86,131,181,93,124,31,52,26,163,250,238,53,115,205,166,237,78,217,36,128,211,241,96,39,28,61,58,230,61,216,245,40,113,75,182,246,163,203,119,171,149,198,21,88,245,124,106,226,43,110,71,222,101,249,209,133,138,94,233,17,154,13,158,212,124,217,201,13,12,214,55,228,203,19,65,171,213,250,226,94,167,196,94,107,55,38,112,56,146,47,212,60,219,67,60,35,240,217,1,94,229,248,91,4,95,110,205,221,183,14,245,131,92,99,11,62,181,167,107,66,127,3,38,253,249,142,87,144,84,73,158,50,153,149,49,37,89,2,43,49,229,140,167,28,194,176,74,102,34,195,253,147,247,161,204,208,192,246,113,42,247,9,193,7,230,114,163,179,0,153,135,117,18,178,40,131,154,180,146,140,229,97,30,179,48,227,89,196,203,90,74,136,232,125,221,231,158,161,95,41,9,205,221,128,26,14,47,16,158,31,208,23,147,237,154,215,125,111,125,75,83,120,147,151,227,136,8,30,206,132,204,4,75,100,142,44,141,170,25,19,40,74,150,196,188,140,69,36,74,33,129,204,208,118,187,124,31,250,141,150,135,109,50,126,173,255,105,93,255,195,18,254,205,94,157,157,236,75,38,245,173,204,224,155,153,180,125,176,255,9,9,30,136,247,60,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2c5fddb8-7f3b-431c-a140-15c790c47997"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
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
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c9715250-2f51-47c6-ae51-692c6ef09e35"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
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
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7aa6f27f-9136-4c8a-95c8-d11d8c5dd57c"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
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
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("105c3fa8-1208-4d19-bf97-40057718c52f"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
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
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("001d410e-1ab8-4cd6-bb61-83ee17b39a5b"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
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
				UId = new Guid("a1588d18-597e-4d60-95bc-bd4c78338608"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
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
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("724a8768-9516-4d2c-aa88-41a1bb2d5e37"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
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
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1eb2f334-3b2d-4e66-96ae-e2c0468ec136"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
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
				UId = new Guid("02e6f3dc-c3b7-48c5-b1bb-858d7d4b6706"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
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
				UId = new Guid("552d4238-195d-4289-9c82-72b9a2a6cc13"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
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
				UId = new Guid("2ee6855b-3c07-41fe-9ed9-dce8afc87598"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
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
				UId = new Guid("d8c1e15f-029b-46de-8fb1-c9ab4e292106"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
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
				UId = new Guid("30fc9f29-8bc3-4e4c-8238-8d93757cf810"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
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
				UId = new Guid("2ab23a86-7cff-4fa0-b600-4001d8b72aca"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
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
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fd8b3b5a-0afb-4d72-b51c-4907de28ec37"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
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
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6d962028-129a-453e-8ba9-f69a2f78e60c"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
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
				UId = new Guid("d2014bab-ec05-4880-9e20-25862680d97a"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
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
				UId = new Guid("12c2859f-0077-4ba5-a75e-9d121e261ff2"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
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

		protected virtual void InitializeChangeContactAccountParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("ea29a1a7-83b3-4850-9134-d716cf498910"),
				ContainerUId = new Guid("304c2e1a-af0b-4016-a95f-ee471f292c6e"),
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
				Value = @"16be3651-8fe2-4159-8dd0-a803d4683dd3",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2a3f5cb3-7035-42b2-9882-c80f7985168f"),
				ContainerUId = new Guid("304c2e1a-af0b-4016-a95f-ee471f292c6e"),
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
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0d8e007f-f368-46a3-840e-c8c133b97854"),
				ContainerUId = new Guid("304c2e1a-af0b-4016-a95f-ee471f292c6e"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,149,64,231,48,208,131,150,41,223,10,215,45,114,105,82,196,200,165,202,97,69,45,109,162,122,129,164,210,186,134,255,189,75,201,118,157,194,69,220,94,26,157,200,209,112,118,246,181,13,100,5,214,126,130,26,131,89,176,68,99,192,182,202,221,124,208,149,67,243,209,180,125,23,92,7,22,141,134,74,255,192,114,196,23,165,118,239,193,1,61,217,230,191,20,242,96,150,159,215,200,131,235,60,208,14,107,75,28,122,162,210,50,46,139,12,88,40,138,148,113,201,21,3,224,146,169,34,230,5,72,41,149,152,142,204,63,137,207,219,186,3,131,99,140,65,94,13,199,229,166,243,212,136,0,57,80,180,109,155,61,152,120,19,118,209,64,81,97,73,119,103,122,36,200,25,93,83,54,184,212,53,222,131,161,88,94,167,245,16,145,20,84,214,179,42,84,110,241,189,51,104,173,110,155,215,204,85,125,221,156,178,73,0,143,215,189,157,112,240,232,153,247,224,214,131,196,45,217,218,13,46,223,173,86,6,87,224,244,243,169,137,175,184,25,120,151,213,143,30,148,212,165,71,168,122,60,137,249,50,147,57,116,110,76,104,12,79,4,163,87,235,139,115,61,86,236,181,116,99,2,187,3,249,66,205,179,57,196,41,129,207,30,24,85,14,199,60,248,114,107,239,190,53,104,30,228,26,107,24,171,246,116,67,232,111,192,81,127,182,141,35,21,38,56,41,89,84,76,5,227,162,148,44,195,36,100,145,20,169,202,162,52,226,66,236,158,70,31,218,118,21,108,30,143,225,62,247,180,20,74,99,121,5,246,74,182,141,3,233,6,166,175,35,253,143,202,20,49,137,11,198,39,60,97,92,133,49,19,33,198,76,241,73,52,149,34,83,34,156,80,191,253,231,219,210,174,180,132,234,174,67,3,251,142,132,231,7,246,197,164,251,98,152,182,117,99,138,199,98,206,79,236,28,166,70,76,10,197,85,70,6,162,8,25,231,9,176,34,204,20,43,213,180,136,64,101,188,72,104,106,118,180,240,190,228,15,109,111,228,126,193,236,184,233,255,180,193,255,97,47,255,102,213,206,14,251,37,195,251,86,198,242,45,13,219,46,216,253,4,180,148,83,62,82,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c0fe375b-e8e3-406d-b4a8-8783f94f8903"),
				ContainerUId = new Guid("304c2e1a-af0b-4016-a95f-ee471f292c6e"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,77,115,155,48,20,252,43,30,37,71,203,35,9,4,136,107,115,241,76,62,220,58,205,197,248,240,144,158,26,207,96,240,32,104,39,245,240,223,43,48,196,177,155,158,170,3,140,30,218,125,203,238,211,145,220,54,111,7,36,41,121,198,186,6,87,217,102,241,165,170,113,177,170,43,141,206,45,238,43,13,197,238,55,228,5,174,160,134,61,54,88,191,64,209,162,187,223,185,102,62,187,132,145,57,185,253,57,124,37,233,230,72,150,13,238,191,47,141,103,207,163,200,70,49,211,84,9,205,104,40,115,77,115,6,57,229,10,18,195,49,150,66,25,15,214,85,209,238,203,7,108,96,5,205,43,73,143,100,96,243,4,82,71,26,56,67,202,121,226,9,52,71,154,128,100,84,74,136,133,181,42,55,38,36,221,156,56,253,138,123,24,154,158,193,60,202,49,136,36,167,137,69,65,67,46,21,77,140,97,20,18,22,152,48,74,2,99,130,30,60,158,63,3,55,55,155,165,123,250,85,98,189,30,120,83,11,133,195,237,194,87,175,10,239,230,164,71,48,214,122,82,75,101,156,72,26,138,32,161,160,34,65,133,111,5,145,177,74,176,184,219,222,108,251,142,102,231,14,5,188,189,252,221,248,107,235,125,183,59,52,51,112,51,208,186,106,203,230,132,57,92,228,240,17,117,204,78,113,102,36,205,254,21,232,248,62,201,191,140,244,58,205,140,204,51,178,174,218,90,247,140,129,223,220,125,144,59,52,25,142,92,109,167,248,124,165,108,139,98,172,220,65,3,211,193,169,92,153,225,15,151,229,122,74,109,96,97,227,162,159,60,166,117,210,246,63,176,7,40,225,7,214,143,222,128,179,246,119,149,207,222,198,137,56,23,74,178,152,91,26,35,40,26,162,207,210,15,45,80,197,85,110,131,56,240,243,39,6,244,55,180,88,99,169,241,82,152,144,38,214,188,159,118,131,253,240,51,78,243,144,9,202,4,50,236,231,215,68,56,226,221,224,118,127,111,70,93,189,85,29,233,186,109,247,7,6,29,9,78,171,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeChangeLeadStageHandoffToSaleParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("9e34dc39-7d39-421f-8d27-92a8af9a80c6"),
				ContainerUId = new Guid("2b2b8a21-5d60-4170-a9eb-caa404a44b84"),
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
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bcf5b8fe-4737-4d4e-a037-b2c70a7900e8"),
				ContainerUId = new Guid("2b2b8a21-5d60-4170-a9eb-caa404a44b84"),
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
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bb68e8f2-44a8-4731-b948-176e754a5d8b"),
				ContainerUId = new Guid("2b2b8a21-5d60-4170-a9eb-caa404a44b84"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,85,223,79,219,48,16,254,87,166,60,99,148,218,78,156,240,54,49,54,33,77,131,9,180,23,202,195,197,62,151,104,105,19,217,46,91,135,248,223,119,73,218,82,74,129,12,9,193,250,228,92,207,159,191,251,241,221,221,68,186,2,239,191,193,20,163,131,232,28,157,3,95,219,176,255,185,172,2,186,47,174,158,55,209,94,228,209,149,80,149,127,208,244,246,35,83,134,79,16,128,174,220,140,239,16,198,209,193,120,55,198,56,218,27,71,101,192,169,39,31,186,162,100,174,99,158,90,6,113,108,153,76,45,157,50,157,48,163,69,162,193,154,216,40,236,61,31,3,63,172,167,13,56,236,223,232,224,109,119,60,95,52,173,235,136,12,186,115,41,125,61,91,26,69,75,194,31,205,160,168,208,208,119,112,115,36,83,112,229,148,162,193,243,114,138,167,224,232,173,22,167,110,77,228,100,161,242,173,87,133,54,28,253,110,28,122,95,214,179,231,200,85,243,233,108,211,155,0,112,253,185,164,19,119,28,91,207,83,8,87,29,196,49,209,186,237,88,126,156,76,28,78,32,148,215,155,36,126,226,162,243,27,150,63,186,96,168,74,63,160,154,227,198,155,247,35,57,132,38,244,1,245,207,147,131,43,39,87,131,99,93,103,236,185,112,57,25,155,149,243,64,204,157,49,240,148,140,215,173,161,71,89,29,199,209,197,177,63,249,53,67,119,166,175,112,10,125,214,46,247,201,186,101,88,227,31,220,40,3,194,136,92,50,157,20,156,73,91,0,43,80,42,166,164,162,220,26,145,102,9,222,94,246,60,74,223,84,176,248,177,126,238,43,66,159,176,54,111,244,109,101,145,161,20,154,9,145,39,76,106,153,178,60,149,5,203,51,40,20,79,139,108,100,114,170,47,253,218,202,23,22,180,201,98,38,172,42,152,84,182,96,192,5,48,37,140,210,84,63,41,133,120,58,75,199,179,199,186,95,254,159,221,255,125,78,67,198,46,206,2,132,185,31,38,132,97,89,220,209,68,163,167,149,208,150,246,131,15,48,233,101,228,208,162,195,153,198,190,145,214,65,111,49,126,168,157,118,222,93,188,43,245,116,129,111,168,103,217,187,70,229,49,200,196,176,88,208,48,145,198,80,219,26,4,150,197,153,82,156,235,36,227,186,195,219,138,189,212,16,86,164,239,132,56,24,237,129,166,182,80,73,43,151,157,92,170,122,66,198,234,164,65,183,252,171,235,160,29,13,125,79,9,237,168,112,117,29,182,234,182,86,238,170,143,184,226,98,148,106,197,112,36,13,147,50,183,44,227,92,178,36,231,68,87,38,35,193,19,98,67,187,176,205,231,89,61,119,122,185,123,124,191,4,95,180,220,222,96,101,253,203,22,218,185,7,134,116,230,123,153,216,175,59,151,223,96,228,190,112,138,62,50,148,94,82,202,123,227,99,168,208,95,83,196,183,209,237,95,25,174,46,194,197,10,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f994ffb6-8edf-41e3-892d-aa56db1c821b"),
				ContainerUId = new Guid("2b2b8a21-5d60-4170-a9eb-caa404a44b84"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,93,111,219,32,20,253,43,17,237,99,176,192,56,96,242,186,62,44,82,58,69,75,215,151,166,15,23,184,172,214,28,19,25,103,82,23,229,191,143,56,246,210,84,171,52,105,60,216,226,154,243,161,115,240,129,220,118,175,59,36,115,242,128,109,11,49,248,46,251,20,90,204,86,109,176,24,99,182,12,22,234,234,23,152,26,87,208,194,22,59,108,31,161,222,99,92,86,177,155,78,174,97,100,74,110,127,246,95,201,252,233,64,22,29,110,191,45,92,98,247,165,97,160,133,167,32,53,208,34,151,158,106,166,12,205,17,208,24,227,81,112,150,192,54,212,251,109,115,143,29,172,160,123,33,243,3,233,217,18,129,177,204,230,78,50,58,3,225,104,81,22,140,2,20,72,173,100,8,74,73,204,153,36,199,41,137,246,5,183,208,139,94,192,5,7,95,106,212,84,205,152,161,69,82,164,165,5,75,189,23,218,200,68,198,209,158,192,195,249,11,240,233,102,25,194,143,253,46,203,115,81,112,235,56,157,25,33,104,97,147,188,102,156,83,233,149,212,2,189,196,162,200,44,26,197,140,176,84,151,51,159,60,74,69,1,149,165,101,233,181,115,138,51,89,150,55,207,39,33,87,197,93,13,175,143,31,234,45,17,220,36,118,240,29,179,207,208,184,224,253,164,11,147,8,53,198,51,195,238,170,140,183,28,135,205,185,211,13,153,111,62,106,117,120,175,251,176,174,123,125,95,233,134,76,55,100,29,246,173,61,49,138,180,185,123,99,190,23,233,143,188,219,142,29,166,73,179,175,235,97,114,7,29,140,7,199,113,112,149,175,208,45,154,245,88,93,207,194,134,69,255,242,24,215,217,219,255,192,238,161,73,25,183,95,82,0,23,239,127,92,62,164,24,71,98,147,235,25,83,220,83,133,160,211,29,146,57,45,29,7,170,185,54,94,40,145,123,159,247,232,175,232,177,197,198,226,181,177,127,185,65,3,62,246,105,159,126,158,193,215,41,170,35,57,30,159,143,191,1,109,248,165,114,176,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeLinkContactToLeadParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("6dd0bc3f-edfa-4078-87d0-79fe8307a8ab"),
				ContainerUId = new Guid("9da5af0d-7621-41eb-8e00-f682895bb04e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("55ac08c6-ba80-4060-81f6-fb82943a2aa6"),
				ContainerUId = new Guid("9da5af0d-7621-41eb-8e00-f682895bb04e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("34908b60-ff49-4067-a7d9-fecfeba3d015"),
				ContainerUId = new Guid("9da5af0d-7621-41eb-8e00-f682895bb04e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,128,182,222,190,21,169,91,4,40,154,0,49,114,169,114,88,146,75,155,168,100,9,36,157,214,53,252,239,93,74,182,234,20,46,226,246,210,232,164,29,12,103,103,95,187,72,214,224,220,103,104,48,154,69,11,180,22,92,171,253,245,7,83,123,180,31,109,187,233,162,171,200,161,53,80,155,31,168,6,124,174,140,127,15,30,232,201,174,250,165,80,69,179,234,188,70,21,93,85,145,241,216,56,226,208,19,129,178,140,51,201,153,206,177,100,137,156,32,43,210,36,15,33,36,101,145,136,73,30,15,204,63,137,223,180,77,7,22,135,28,189,188,238,127,23,219,46,80,39,4,200,158,98,92,187,62,128,113,48,225,230,107,16,53,42,138,189,221,32,65,222,154,134,170,193,133,105,240,30,44,229,10,58,109,128,136,164,161,118,129,85,163,246,243,239,157,69,231,76,187,126,205,92,189,105,214,167,108,18,192,49,60,216,225,189,199,192,188,7,191,234,37,110,201,214,190,119,249,110,185,180,184,4,111,158,79,77,124,197,109,207,187,172,127,244,64,209,148,30,161,222,224,73,206,151,149,220,64,231,135,130,134,244,68,176,102,185,186,184,214,177,99,175,149,59,37,176,59,146,47,212,60,91,195,52,35,240,57,0,131,202,241,183,138,190,220,186,187,111,107,180,15,114,133,13,12,93,123,186,38,244,55,96,212,159,237,114,5,177,138,203,132,201,84,76,89,162,5,48,129,212,201,60,201,129,115,21,103,69,138,251,167,193,135,113,93,13,219,199,49,221,39,132,161,97,161,111,20,151,185,40,115,158,166,172,212,165,102,137,42,166,76,104,205,153,72,181,228,133,228,92,2,167,249,134,47,140,161,93,26,9,245,93,135,22,14,19,224,231,23,244,197,102,135,226,109,219,250,161,164,177,121,163,151,227,138,112,208,83,29,23,130,41,153,165,180,34,249,132,21,137,74,153,80,37,242,50,203,164,40,4,153,161,235,14,253,125,104,55,86,30,174,201,13,103,253,79,231,250,31,142,240,111,238,234,236,102,95,178,169,111,101,7,223,204,166,237,163,253,79,6,10,39,89,60,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ee931748-590a-41b4-8229-e4dc1c8b23af"),
				ContainerUId = new Guid("9da5af0d-7621-41eb-8e00-f682895bb04e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,193,114,155,48,16,253,21,143,146,163,215,35,33,33,36,174,205,197,51,73,235,54,105,46,182,15,139,180,106,60,131,193,3,184,157,212,195,191,23,99,136,99,55,61,85,7,24,173,246,189,125,122,15,14,236,182,121,221,17,75,217,19,85,21,214,101,104,102,159,202,138,102,139,170,116,84,215,179,251,210,97,190,249,141,89,78,11,172,112,75,13,85,207,152,239,169,190,223,212,205,116,114,9,99,83,118,251,179,63,101,233,242,192,230,13,109,191,207,125,199,206,61,5,12,73,0,31,180,5,197,149,4,19,25,5,222,161,212,34,177,145,241,81,7,118,101,190,223,22,15,212,224,2,155,23,150,30,88,207,214,17,160,87,150,251,216,0,143,21,130,242,38,6,27,41,13,222,27,165,53,101,210,26,201,218,41,171,221,11,109,177,31,122,6,43,129,193,88,178,144,196,60,3,69,89,6,198,161,131,16,164,205,180,50,74,144,59,130,135,254,51,112,121,179,156,215,95,126,21,84,61,246,188,105,192,188,166,245,172,171,94,21,222,204,73,15,145,8,92,82,236,65,100,137,1,101,188,3,75,146,131,112,70,7,43,180,80,198,180,235,155,245,113,162,223,212,187,28,95,159,255,30,252,117,223,249,30,54,228,39,88,79,92,89,52,232,154,19,102,119,145,195,123,212,97,117,138,115,197,210,213,191,2,29,222,39,249,151,145,94,167,185,98,211,21,123,44,247,149,59,50,202,110,115,247,78,110,63,164,111,185,218,142,241,117,149,98,159,231,67,229,14,27,28,27,199,114,233,251,27,206,139,199,49,181,158,133,15,11,62,120,140,235,164,237,127,96,15,88,224,15,170,62,119,6,156,181,191,169,124,234,108,28,137,179,200,198,60,17,1,18,194,238,227,37,29,129,241,2,193,10,155,5,153,200,40,132,168,71,127,163,64,21,21,142,46,133,9,157,145,212,177,0,19,40,2,37,98,219,225,61,7,52,92,122,165,141,244,94,14,248,186,119,251,248,223,12,186,142,86,181,172,109,215,237,31,224,2,233,168,171,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeLinkAccountToLeadParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("7b3e0e2a-6d32-492c-9290-46e7c194da0b"),
				ContainerUId = new Guid("1337590d-7ee1-488b-b0db-de061f6759f5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fbd3778b-b29e-4da4-878c-479ce66f6695"),
				ContainerUId = new Guid("1337590d-7ee1-488b-b0db-de061f6759f5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e2572aab-9833-4451-bac3-3c93b4938008"),
				ContainerUId = new Guid("1337590d-7ee1-488b-b0db-de061f6759f5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,64,239,135,111,69,234,22,1,138,38,64,140,92,170,28,150,212,210,38,170,23,72,58,173,107,232,223,187,148,108,213,41,92,196,237,165,225,137,28,204,206,206,46,119,247,158,168,193,152,207,208,160,183,240,86,168,53,152,78,218,235,15,170,182,168,63,234,110,219,123,87,158,65,173,160,86,63,176,154,240,101,165,236,123,176,64,33,251,242,151,66,233,45,202,243,26,165,119,85,122,202,98,99,136,67,33,9,151,97,234,71,25,11,179,84,176,184,74,10,198,19,153,50,145,201,16,5,15,69,2,201,196,252,147,248,77,215,244,160,113,202,49,202,203,241,186,218,245,142,26,16,32,70,138,50,93,123,0,35,103,194,44,91,224,53,86,244,182,122,139,4,89,173,26,170,6,87,170,193,123,208,148,203,233,116,14,34,146,132,218,56,86,141,210,46,191,247,26,141,81,93,251,154,185,122,219,180,167,108,18,192,249,121,176,227,143,30,29,243,30,236,102,148,184,37,91,195,232,242,221,122,173,113,13,86,61,159,154,248,138,187,145,119,89,255,40,160,162,95,122,132,122,139,39,57,95,86,114,3,189,157,10,154,210,19,65,171,245,230,226,90,231,142,189,86,110,72,96,127,36,95,168,121,182,134,48,37,240,217,1,147,202,241,90,122,95,110,205,221,183,22,245,131,216,96,3,83,215,158,174,9,253,13,152,245,23,251,172,130,168,138,138,152,137,132,135,44,150,28,24,199,56,99,89,156,129,239,87,81,154,39,56,60,77,62,148,233,107,216,61,206,233,62,33,76,13,115,125,163,119,64,17,50,71,193,124,30,20,44,206,179,140,229,89,24,179,36,22,81,148,35,132,133,27,187,193,29,247,13,221,90,9,168,239,122,212,112,248,1,255,252,128,190,152,108,87,188,238,58,59,149,52,55,111,246,114,28,17,63,200,43,14,92,178,176,8,42,22,99,206,25,151,185,96,69,42,227,128,124,114,46,41,114,160,237,118,253,125,232,182,90,28,182,201,76,107,253,79,235,250,31,150,240,111,246,234,236,100,95,50,169,111,101,6,223,204,164,13,222,240,19,106,59,58,37,60,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2c5dda1b-35c1-410a-8a66-b8e7dbef353d"),
				ContainerUId = new Guid("1337590d-7ee1-488b-b0db-de061f6759f5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,77,115,155,48,16,253,43,30,37,71,203,3,66,2,137,107,115,241,76,62,220,58,205,197,246,97,37,173,26,207,96,240,32,104,39,245,240,223,43,99,136,99,55,61,85,7,24,45,251,222,190,221,183,28,200,109,243,182,71,146,147,103,172,107,240,149,107,102,95,170,26,103,139,186,50,232,253,236,190,50,80,108,127,131,46,112,1,53,236,176,193,250,5,138,22,253,253,214,55,211,201,37,140,76,201,237,207,254,43,201,87,7,50,111,112,247,125,110,3,59,139,165,72,109,34,105,170,193,81,206,83,160,160,53,167,42,3,37,83,30,107,39,117,0,155,170,104,119,229,3,54,176,128,230,149,228,7,210,179,5,130,132,41,174,0,57,117,46,78,40,151,78,80,229,132,165,92,64,198,133,144,8,66,144,110,74,188,121,197,29,244,69,207,96,30,131,147,10,21,205,68,164,41,71,173,169,52,96,2,87,162,116,202,37,143,209,28,193,67,254,25,184,186,89,205,253,211,175,18,235,101,207,155,59,40,60,110,102,33,122,21,120,31,78,126,0,235,28,79,165,163,34,147,130,114,22,186,6,149,50,202,108,104,59,181,78,177,40,235,54,55,155,99,69,187,245,251,2,222,94,254,46,252,181,13,115,119,91,180,19,240,19,48,166,106,203,230,132,217,95,248,240,17,117,88,159,236,92,147,124,253,47,67,135,247,73,254,165,165,215,110,174,201,116,77,150,85,91,155,35,99,18,46,119,31,228,246,69,250,148,171,235,104,95,136,148,109,81,12,145,59,104,96,76,28,195,149,237,59,156,151,203,209,181,158,37,26,14,253,228,49,158,147,182,255,129,61,64,9,63,176,126,12,3,56,107,127,87,249,28,198,56,18,107,166,68,148,197,142,102,8,42,172,79,240,82,218,24,168,138,149,118,73,150,48,231,88,143,254,134,14,107,44,13,94,10,99,194,102,38,6,77,99,139,81,216,216,40,166,154,71,140,70,12,35,12,251,203,108,138,3,222,247,211,62,254,55,131,174,227,168,58,210,117,155,238,15,240,41,104,173,171,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeReadSystemSettingsParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5b47b7b3-1c3a-4e76-8b27-d2d1429d61ee"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,193,142,155,48,16,253,149,202,231,165,10,196,129,176,183,85,54,237,173,187,85,162,61,113,25,204,64,172,53,24,217,102,213,116,149,127,239,216,208,148,149,82,109,180,151,170,156,224,241,230,249,205,204,243,43,19,10,172,253,6,45,178,91,182,71,99,192,234,218,125,254,34,149,67,243,213,232,161,103,55,204,162,145,160,228,79,172,70,124,91,73,119,15,14,168,228,181,248,163,80,176,219,226,178,70,193,110,10,38,29,182,150,56,84,146,100,235,52,75,86,171,40,73,22,117,196,5,23,81,190,230,105,180,18,241,34,175,210,108,137,21,31,153,127,19,223,232,182,7,131,227,25,65,190,14,175,251,99,239,169,49,1,34,80,164,213,221,4,46,189,9,187,237,160,84,88,209,183,51,3,18,228,140,108,169,27,220,203,22,31,193,208,89,94,71,123,136,72,53,40,235,89,10,107,183,253,209,27,180,86,234,238,61,115,106,104,187,57,155,4,240,252,57,217,89,4,143,158,249,8,238,16,36,118,71,187,67,231,100,215,88,18,169,136,117,10,158,239,154,198,96,3,78,190,204,45,61,227,49,84,93,55,77,42,168,104,103,79,160,6,156,77,233,109,95,27,232,221,216,94,48,67,27,251,100,71,67,147,31,170,48,178,57,92,61,138,243,64,223,155,70,66,96,255,155,124,165,230,197,166,146,140,192,23,15,132,178,141,65,90,228,157,16,122,232,220,67,247,125,160,32,215,82,192,216,230,137,30,63,4,221,16,164,30,122,52,211,143,176,157,11,97,121,147,178,212,79,67,107,183,19,7,108,225,236,116,182,197,167,209,199,108,89,28,82,94,229,101,30,149,124,89,70,60,206,211,104,141,49,68,88,174,51,142,203,122,17,99,76,190,232,214,249,198,118,122,48,98,74,185,29,175,219,135,174,209,63,184,28,31,207,251,197,128,93,19,152,255,33,10,39,118,250,5,226,168,0,60,117,5,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("055337fb-4c12-4162-baa0-f0a6f82b04f1"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
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
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("61008822-6246-4cb7-94b5-d7ab2c0e761f"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
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
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a18bad05-72bd-47e8-8a76-9adc5adb727a"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
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
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("05ce4b0d-7adf-4370-a4da-9a578ae526a6"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
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
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b54c1807-d3db-417d-acc8-5ec641e8f114"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
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
				UId = new Guid("eb5b205e-4427-45cf-8b2f-e5c11ffb5d04"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,11,174,44,14,78,45,41,201,204,75,47,182,50,180,50,212,241,76,177,50,176,50,0,0,176,83,7,250,22,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("951b2bbb-0ba3-4049-9a29-b5d4c0b6d50f"),
				UId = new Guid("411b2f2b-abb2-49c4-b63c-c589bc81bb8c"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0107e886-cf9e-458c-9fa5-10337b71312c"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
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
				UId = new Guid("c92f52ed-8123-486d-ae9b-c9c0f3e785cf"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
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
				UId = new Guid("6c8845de-fd11-481f-ba54-02935c4aeb9d"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
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
				UId = new Guid("63c46681-2887-41fe-8ea5-3cd9bd9e60fe"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
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
				UId = new Guid("f0232a3c-912e-48ab-9927-5fc33677f7ba"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
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
				UId = new Guid("06e3ef5a-2fa6-49b7-bfa6-3a114e683d05"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
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
				ReferenceSchemaUId = new Guid("951b2bbb-0ba3-4049-9a29-b5d4c0b6d50f"),
				UId = new Guid("0a40e220-4683-47e0-a0c2-892934668fc3"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
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
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("44d1abb0-802b-49e6-9571-d667de498b3e"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
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
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("11fe36aa-20e3-41b3-99f4-0a35fd3628cc"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
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
				UId = new Guid("7b761d52-e117-4dc0-a0c4-c2846c0292bb"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
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
				UId = new Guid("91d86af3-634e-48c9-b566-355568110d9f"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
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

		protected virtual void InitializeChangeLeadIsQualificationPassedTrueParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("2585e082-21c1-4b40-97bb-421446d5072b"),
				ContainerUId = new Guid("d5956d29-6377-467e-a94b-24cf386951b3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8e537058-764d-485f-976a-f2c1892e719d"),
				ContainerUId = new Guid("d5956d29-6377-467e-a94b-24cf386951b3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7fa0d07d-a96d-43f6-8700-5d9b0a159e1c"),
				ContainerUId = new Guid("d5956d29-6377-467e-a94b-24cf386951b3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,65,110,219,48,16,252,139,206,97,64,89,178,68,249,86,164,110,17,160,104,2,196,200,165,202,97,69,174,108,162,146,37,144,116,90,215,240,223,187,20,109,213,41,92,196,237,165,209,73,28,12,103,103,150,187,187,72,54,96,237,103,104,49,154,69,11,52,6,108,87,187,235,15,186,113,104,62,154,110,211,71,87,145,69,163,161,209,63,80,5,124,174,180,123,15,14,232,202,174,252,165,80,70,179,242,188,70,25,93,149,145,118,216,90,226,208,149,105,146,229,169,40,42,198,33,150,44,77,39,138,21,25,198,172,22,21,78,161,226,137,4,12,204,63,137,223,116,109,15,6,67,141,65,190,30,126,23,219,222,83,99,2,228,64,209,182,91,31,192,196,155,176,243,53,84,13,42,58,59,179,65,130,156,209,45,165,193,133,110,241,30,12,213,242,58,157,135,136,84,67,99,61,171,193,218,205,191,247,6,173,213,221,250,53,115,205,166,93,159,178,73,0,199,227,193,14,31,60,122,230,61,184,213,32,113,75,182,246,131,203,119,203,165,193,37,56,253,124,106,226,43,110,7,222,101,253,163,11,138,94,233,17,154,13,158,212,124,153,228,6,122,23,2,133,242,68,48,122,185,186,56,235,216,177,215,226,78,8,236,143,228,11,53,207,102,152,100,4,62,123,32,168,28,127,203,232,203,173,189,251,182,70,243,32,87,216,66,232,218,211,53,161,191,1,163,254,108,151,43,72,84,82,164,76,78,171,9,75,235,10,88,133,105,206,242,52,7,206,85,146,137,41,238,159,130,15,109,251,6,182,143,99,185,79,8,161,97,190,111,116,206,115,17,199,156,39,76,212,156,180,64,10,38,84,142,76,74,169,42,16,73,193,227,130,222,215,127,254,25,186,165,150,208,220,245,104,224,240,2,252,252,128,190,152,108,31,222,116,157,11,145,198,230,141,94,142,35,82,37,185,20,21,87,76,76,33,101,105,38,114,6,105,34,88,60,201,84,130,57,121,138,57,153,161,237,246,253,125,232,54,70,30,182,201,134,181,254,167,117,253,15,75,248,55,123,117,118,178,47,153,212,183,50,131,111,102,210,246,209,254,39,244,144,220,81,60,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("95da49a7-ccce-4ad9-befc-0d569ae20247"),
				ContainerUId = new Guid("d5956d29-6377-467e-a94b-24cf386951b3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,165,146,79,79,227,48,16,197,191,202,202,226,88,87,118,226,198,113,175,112,169,4,168,162,192,133,236,97,108,143,33,82,154,84,142,139,196,86,249,238,235,154,100,75,209,114,1,31,226,63,51,239,205,211,79,57,144,139,240,182,67,178,36,247,232,61,244,157,11,243,203,206,227,124,237,59,131,125,63,191,238,12,52,245,31,208,13,174,193,195,22,3,250,71,104,246,216,95,215,125,152,253,58,151,145,25,185,120,77,85,178,124,58,144,85,192,237,195,202,70,119,112,165,45,11,37,105,33,133,163,34,95,88,90,170,44,163,139,82,114,38,100,134,198,138,40,54,93,179,223,182,55,24,96,13,225,133,44,15,36,185,69,3,43,10,224,186,40,40,151,32,169,40,88,78,53,55,72,133,202,121,46,25,183,144,115,50,204,72,111,94,112,11,105,232,73,44,120,156,175,80,81,185,96,154,10,212,154,150,6,12,117,46,87,186,16,165,224,104,142,226,177,255,36,12,62,110,177,96,235,126,215,192,219,227,87,245,221,25,154,143,29,135,234,157,112,69,150,213,87,140,199,125,147,162,159,83,254,12,184,34,179,138,108,186,189,55,71,199,60,94,174,62,68,75,67,82,203,167,235,68,52,190,180,251,166,25,95,174,32,192,212,56,61,119,182,118,53,218,85,187,153,64,38,23,54,46,250,159,207,180,222,179,253,68,118,3,45,60,163,191,141,0,78,217,255,165,188,143,24,39,99,197,116,177,208,174,164,204,57,67,5,23,156,150,82,42,154,137,140,197,3,56,197,100,82,223,161,67,143,173,193,111,6,187,195,62,209,62,254,202,99,174,35,170,129,12,195,239,225,47,192,55,28,150,62,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLeadQualificationProcess = CreateLeadQualificationProcessLaneSet();
			LaneSets.Add(schemaLeadQualificationProcess);
			ProcessSchemaLane schemaLeadQualification = CreateLeadQualificationLane();
			schemaLeadQualificationProcess.Lanes.Add(schemaLeadQualification);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaTerminateEvent terminatequalified = CreateTerminateQualifiedTerminateEvent();
			FlowElements.Add(terminatequalified);
			ProcessSchemaExclusiveGateway exclusivegatewayisleadset = CreateExclusiveGatewayIsLeadSetExclusiveGateway();
			FlowElements.Add(exclusivegatewayisleadset);
			ProcessSchemaTerminateEvent terminate2 = CreateTerminate2TerminateEvent();
			FlowElements.Add(terminate2);
			ProcessSchemaUserTask readleaddata = CreateReadLeadDataUserTask();
			FlowElements.Add(readleaddata);
			ProcessSchemaUserTask changecontactaccount = CreateChangeContactAccountUserTask();
			FlowElements.Add(changecontactaccount);
			ProcessSchemaExclusiveGateway exclusivegatewayaccountconnection = CreateExclusiveGatewayAccountConnectionExclusiveGateway();
			FlowElements.Add(exclusivegatewayaccountconnection);
			ProcessSchemaUserTask changeleadstagehandofftosale = CreateChangeLeadStageHandoffToSaleUserTask();
			FlowElements.Add(changeleadstagehandofftosale);
			ProcessSchemaScriptTask changeaccountscripttask = CreateChangeAccountScriptTaskScriptTask();
			FlowElements.Add(changeaccountscripttask);
			ProcessSchemaScriptTask changecontactscripttask = CreateChangeContactScriptTaskScriptTask();
			FlowElements.Add(changecontactscripttask);
			ProcessSchemaUserTask linkcontacttolead = CreateLinkContactToLeadUserTask();
			FlowElements.Add(linkcontacttolead);
			ProcessSchemaUserTask linkaccounttolead = CreateLinkAccountToLeadUserTask();
			FlowElements.Add(linkaccounttolead);
			ProcessSchemaExclusiveGateway exclusivegatewayqualifiedaccount = CreateExclusiveGatewayQualifiedAccountExclusiveGateway();
			FlowElements.Add(exclusivegatewayqualifiedaccount);
			ProcessSchemaUserTask readsystemsettings = CreateReadSystemSettingsUserTask();
			FlowElements.Add(readsystemsettings);
			ProcessSchemaExclusiveGateway exclusivegatewayisqualificationpassed = CreateExclusiveGatewayIsQualificationPassedExclusiveGateway();
			FlowElements.Add(exclusivegatewayisqualificationpassed);
			ProcessSchemaUserTask changeleadisqualificationpassedtrue = CreateChangeLeadIsQualificationPassedTrueUserTask();
			FlowElements.Add(changeleadisqualificationpassedtrue);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalFlowLeadUndefinedConditionalFlow());
			FlowElements.Add(CreateLeadDefinedSequenceFlow());
			FlowElements.Add(CreateSequenceFlowNoAccountSequenceFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23SequenceFlow());
			FlowElements.Add(CreateSequenceFlow26SequenceFlow());
			FlowElements.Add(CreateQualifiedContactExistsSequenceFlowConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateQualifiedAccountExistsSequenceFlowConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1ConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("c65a1bbe-a2e1-4643-aea1-a3b83207ea88"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bf1b5b17-6f6d-4e3d-8136-b213854f53b7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ed9cbb4d-b5c9-4231-ab67-76ffff3433b0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowLeadUndefinedConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowLeadUndefined",
				UId = new Guid("00b2c101-a67f-4a28-a60e-f6ef8f988808"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{7da3d394-c5b2-4fba-be47-747a00d3685e}]#] == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				CurveCenterPosition = new Point(176, 271),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ed9cbb4d-b5c9-4231-ab67-76ffff3433b0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("478ef5b0-3cfe-49aa-9d92-d33e5210847a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(127, 416));
			schemaFlow.PolylinePointPositions.Add(new Point(126, 416));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateLeadDefinedSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "LeadDefined",
				UId = new Guid("756698c0-b46a-4130-a2ea-3b7d3f77b46b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				CurveCenterPosition = new Point(231, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ed9cbb4d-b5c9-4231-ab67-76ffff3433b0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(195, 373));
			schemaFlow.PolylinePointPositions.Add(new Point(195, 687));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowNoAccountSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlowNoAccount",
				UId = new Guid("c7e87ab7-7efe-4228-b1ed-7c57a2135e50"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				CurveCenterPosition = new Point(1084, 512),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("968e7a35-4c26-459a-806f-a3b34d7fe1c2"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2b2b8a21-5d60-4170-a9eb-caa404a44b84"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(684, 512));
			schemaFlow.PolylinePointPositions.Add(new Point(684, 92));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow3",
				UId = new Guid("8df03451-825f-4626-947e-1c39dddd618f"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{adff468f-5785-4238-a962-2d46a6df9207}]#]!= Guid.Empty && [#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{21f03e5d-1b78-48dc-9e30-1c86f9161488}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				CurveCenterPosition = new Point(1021, 601),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("968e7a35-4c26-459a-806f-a3b34d7fe1c2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("304c2e1a-af0b-4016-a95f-ee471f292c6e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("d11e3a52-d220-4d16-b36a-25b6d32fa2d8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				CurveCenterPosition = new Point(1104, 628),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("304c2e1a-af0b-4016-a95f-ee471f292c6e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2b2b8a21-5d60-4170-a9eb-caa404a44b84"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(830, 687));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23",
				UId = new Guid("aecc3666-b64f-448b-92d5-e58fceb68420"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				CurveCenterPosition = new Point(1782, 434),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2b2b8a21-5d60-4170-a9eb-caa404a44b84"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d5956d29-6377-467e-a94b-24cf386951b3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow26SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow26",
				UId = new Guid("d5c984cc-6130-459a-87b9-d537c71ee823"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				CurveCenterPosition = new Point(793, 206),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9970214a-b543-4895-ab00-ab57461e70cf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("97776b38-7f29-472a-ab13-e87884d17d43"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(270, 121));
			schemaFlow.PolylinePointPositions.Add(new Point(274, 121));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateQualifiedContactExistsSequenceFlowConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "QualifiedContactExistsSequenceFlow",
				UId = new Guid("644d1a44-d831-44e0-982d-8da2dc9c15bf"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{21f03e5d-1b78-48dc-9e30-1c86f9161488}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("92323026-06de-4fcc-b310-6de28b5b7964"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("97776b38-7f29-472a-ab13-e87884d17d43"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9da5af0d-7621-41eb-8e00-f682895bb04e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(274, 21));
			schemaFlow.PolylinePointPositions.Add(new Point(552, 21));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("2f920b5d-24b3-48d4-8c77-b0608b4cbdac"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("92323026-06de-4fcc-b310-6de28b5b7964"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("97776b38-7f29-472a-ab13-e87884d17d43"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("045b9d72-61cb-4f5f-8a92-c02297c04e1d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(413, 78));
			schemaFlow.PolylinePointPositions.Add(new Point(413, 232));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("b8793434-8131-45af-9836-038f53b3d96f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("06d6585a-7cd3-4bd9-a9f3-7b52c8d29213"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1337590d-7ee1-488b-b0db-de061f6759f5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("968e7a35-4c26-459a-806f-a3b34d7fe1c2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("48ad4d37-ec71-49c5-bbbc-48d071c60c63"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("06d6585a-7cd3-4bd9-a9f3-7b52c8d29213"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9da5af0d-7621-41eb-8e00-f682895bb04e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("045b9d72-61cb-4f5f-8a92-c02297c04e1d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(552, 150));
			schemaFlow.PolylinePointPositions.Add(new Point(545, 150));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("5307b755-7675-4cab-b5a0-bbf36f487016"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("06d6585a-7cd3-4bd9-a9f3-7b52c8d29213"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9970214a-b543-4895-ab00-ab57461e70cf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateQualifiedAccountExistsSequenceFlowConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "QualifiedAccountExistsSequenceFlow",
				UId = new Guid("2e0ed20e-8966-4d04-847a-b6b5a83c0b82"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{adff468f-5785-4238-a962-2d46a6df9207}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("06d6585a-7cd3-4bd9-a9f3-7b52c8d29213"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("045b9d72-61cb-4f5f-8a92-c02297c04e1d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1337590d-7ee1-488b-b0db-de061f6759f5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(588, 232));
			schemaFlow.PolylinePointPositions.Add(new Point(588, 344));
			schemaFlow.PolylinePointPositions.Add(new Point(545, 344));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow2",
				UId = new Guid("8f67e700-62e9-40c4-a643-f73bb5f05cad"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("06d6585a-7cd3-4bd9-a9f3-7b52c8d29213"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("045b9d72-61cb-4f5f-8a92-c02297c04e1d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("968e7a35-4c26-459a-806f-a3b34d7fe1c2"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(545, 275));
			schemaFlow.PolylinePointPositions.Add(new Point(445, 275));
			schemaFlow.PolylinePointPositions.Add(new Point(445, 512));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("c084c45e-344c-4716-9e7d-5c2a2156f893"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("720d23f3-8251-42b3-a7b6-da9abd6ef059"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("afcc2355-be16-486b-bcf6-db2841519eb1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1",
				UId = new Guid("fce21b7b-3f73-4e8d-abd1-a8c48ebfab45"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{9c638b0f-7b13-46c3-bef4-2010a78fb3a4}]#]==true ",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("720d23f3-8251-42b3-a7b6-da9abd6ef059"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("afcc2355-be16-486b-bcf6-db2841519eb1"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("478ef5b0-3cfe-49aa-9d92-d33e5210847a"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(313, 492));
			schemaFlow.PolylinePointPositions.Add(new Point(313, 791));
			schemaFlow.PolylinePointPositions.Add(new Point(155, 791));
			schemaFlow.PolylinePointPositions.Add(new Point(155, 506));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow3",
				UId = new Guid("164357f3-a851-4f43-b08a-6416dd1e9661"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("720d23f3-8251-42b3-a7b6-da9abd6ef059"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("afcc2355-be16-486b-bcf6-db2841519eb1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("cd4daabe-3357-4592-82a8-76ba3320c72a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("720d23f3-8251-42b3-a7b6-da9abd6ef059"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d5956d29-6377-467e-a94b-24cf386951b3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("279e66a8-61fb-4e2b-8559-0362a5ebb1fe"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLeadQualificationProcessLaneSet() {
			ProcessSchemaLaneSet schemaLeadQualificationProcess = new ProcessSchemaLaneSet(this) {
				UId = new Guid("52a0ec41-f948-487a-bbce-75440b557857"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadQualificationProcess",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLeadQualificationProcess;
		}

		protected virtual ProcessSchemaLane CreateLeadQualificationLane() {
			ProcessSchemaLane schemaLeadQualification = new ProcessSchemaLane(this) {
				UId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("52a0ec41-f948-487a-bbce-75440b557857"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadQualification",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLeadQualification;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("bf1b5b17-6f6d-4e3d-8136-b213854f53b7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"Start1",
				Position = new Point(20, 360),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateQualifiedTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("279e66a8-61fb-4e2b-8559-0362a5ebb1fe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"TerminateQualified",
				Position = new Point(1113, 79),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayIsLeadSetExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("ed9cbb4d-b5c9-4231-ab67-76ffff3433b0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"ExclusiveGatewayIsLeadSet",
				Position = new Point(100, 346),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate2TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("478ef5b0-3cfe-49aa-9d92-d33e5210847a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"Terminate2",
				Position = new Point(113, 493),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"ReadLeadData",
				Position = new Point(236, 660),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadLeadDataParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeContactAccountUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("304c2e1a-af0b-4016-a95f-ee471f292c6e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"ChangeContactAccount",
				Position = new Point(511, 660),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeContactAccountParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayAccountConnectionExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("968e7a35-4c26-459a-806f-a3b34d7fe1c2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"ExclusiveGatewayAccountConnection",
				Position = new Point(518, 485),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateChangeLeadStageHandoffToSaleUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("2b2b8a21-5d60-4170-a9eb-caa404a44b84"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"ChangeLeadStageHandoffToSale",
				Position = new Point(796, 65),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeLeadStageHandoffToSaleParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeAccountScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("97776b38-7f29-472a-ab13-e87884d17d43"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"ChangeAccountScriptTask",
				Position = new Point(240, 51),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,40,202,79,78,45,46,118,76,78,206,47,205,43,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,181,13,239,214,31,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeContactScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9970214a-b543-4895-ab00-ab57461e70cf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"ChangeContactScriptTask",
				Position = new Point(236, 185),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,40,202,79,78,45,46,118,206,207,43,73,76,46,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,245,187,243,113,31,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateLinkContactToLeadUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("9da5af0d-7621-41eb-8e00-f682895bb04e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("92323026-06de-4fcc-b310-6de28b5b7964"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LinkContactToLead",
				Position = new Point(518, 65),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeLinkContactToLeadParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateLinkAccountToLeadUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("1337590d-7ee1-488b-b0db-de061f6759f5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("06d6585a-7cd3-4bd9-a9f3-7b52c8d29213"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LinkAccountToLead",
				Position = new Point(511, 359),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeLinkAccountToLeadParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayQualifiedAccountExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("045b9d72-61cb-4f5f-8a92-c02297c04e1d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("06d6585a-7cd3-4bd9-a9f3-7b52c8d29213"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"ExclusiveGatewayQualifiedAccount",
				Position = new Point(518, 205),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadSystemSettingsUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("06d6585a-7cd3-4bd9-a9f3-7b52c8d29213"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"ReadSystemSettings",
				Position = new Point(236, 304),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadSystemSettingsParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayIsQualificationPassedExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("afcc2355-be16-486b-bcf6-db2841519eb1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("720d23f3-8251-42b3-a7b6-da9abd6ef059"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"ExclusiveGatewayIsQualificationPassed",
				Position = new Point(243, 465),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateChangeLeadIsQualificationPassedTrueUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("d5956d29-6377-467e-a94b-24cf386951b3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("720d23f3-8251-42b3-a7b6-da9abd6ef059"),
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"ChangeLeadIsQualificationPassedTrue",
				Position = new Point(951, 65),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeLeadIsQualificationPassedTrueParameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3c6ecdc6-bc79-4245-a9cc-a34cb13e3cc3"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("44f94bf0-4527-4bb4-ac7e-a66ed2ff2653"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("86b4ee06-6bcf-45c0-ab44-66865e38fa0d"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LeadManagementQualification78(userConnection);
		}

		public override object Clone() {
			return new LeadManagementQualification78Schema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadManagementQualification78

	/// <exclude/>
	public class LeadManagementQualification78 : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLeadQualification

		/// <exclude/>
		public class ProcessLeadQualification : ProcessLane
		{

			public ProcessLeadQualification(UserConnection userConnection, LeadManagementQualification78 process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: ReadLeadDataFlowElement

		/// <exclude/>
		public class ReadLeadDataFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLeadDataFlowElement(UserConnection userConnection, LeadManagementQualification78 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLeadData";
				IsLogging = true;
				SchemaElementUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,64,79,147,242,173,72,221,34,64,209,4,136,145,75,149,195,138,90,217,68,245,2,73,167,117,13,255,123,151,162,173,58,133,139,184,189,52,58,137,131,225,236,236,112,119,23,200,6,140,249,12,45,6,243,96,137,90,131,233,107,123,253,65,53,22,245,71,221,111,134,224,42,48,168,21,52,234,7,86,30,95,84,202,190,7,11,116,101,87,252,82,40,130,121,113,94,163,8,174,138,64,89,108,13,113,232,10,230,137,228,178,76,89,197,101,198,210,186,230,44,175,65,178,188,20,89,157,199,81,4,124,230,153,127,18,191,233,219,1,52,250,26,163,124,61,254,46,183,131,163,70,4,200,145,162,76,223,29,192,196,153,48,139,14,202,6,43,58,91,189,65,130,172,86,45,117,131,75,213,226,61,104,170,229,116,122,7,17,169,134,198,56,86,131,181,93,124,31,52,26,163,250,238,53,115,205,166,237,78,217,36,128,211,241,96,39,28,61,58,230,61,216,245,40,113,75,182,246,163,203,119,171,149,198,21,88,245,124,106,226,43,110,71,222,101,249,209,133,138,94,233,17,154,13,158,212,124,217,201,13,12,214,55,228,203,19,65,171,213,250,226,94,167,196,94,107,55,38,112,56,146,47,212,60,219,67,60,35,240,217,1,94,229,248,91,4,95,110,205,221,183,14,245,131,92,99,11,62,181,167,107,66,127,3,38,253,249,142,87,144,84,73,158,50,153,149,49,37,89,2,43,49,229,140,167,28,194,176,74,102,34,195,253,147,247,161,204,208,192,246,113,42,247,9,193,7,230,114,163,179,0,153,135,117,18,178,40,131,154,180,146,140,229,97,30,179,48,227,89,196,203,90,74,136,232,125,221,231,158,161,95,41,9,205,221,128,26,14,47,16,158,31,208,23,147,237,154,215,125,111,125,75,83,120,147,151,227,136,8,30,206,132,204,4,75,100,142,44,141,170,25,19,40,74,150,196,188,140,69,36,74,33,129,204,208,118,187,124,31,250,141,150,135,109,50,126,173,255,105,93,255,195,18,254,205,94,157,157,236,75,38,245,173,204,224,155,153,180,125,176,255,9,9,30,136,247,60,6,0,0 })));
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

		#region Class: ChangeContactAccountFlowElement

		/// <exclude/>
		public class ChangeContactAccountFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeContactAccountFlowElement(UserConnection userConnection, LeadManagementQualification78 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeContactAccount";
				IsLogging = true;
				SchemaElementUId = new Guid("304c2e1a-af0b-4016-a95f-ee471f292c6e");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Account = () => (Guid)((process.AccountId));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_Account", () => _recordColumnValues_Account.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_Account;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,149,64,231,48,208,131,150,41,223,10,215,45,114,105,82,196,200,165,202,97,69,45,109,162,122,129,164,210,186,134,255,189,75,201,118,157,194,69,220,94,26,157,200,209,112,118,246,181,13,100,5,214,126,130,26,131,89,176,68,99,192,182,202,221,124,208,149,67,243,209,180,125,23,92,7,22,141,134,74,255,192,114,196,23,165,118,239,193,1,61,217,230,191,20,242,96,150,159,215,200,131,235,60,208,14,107,75,28,122,162,210,50,46,139,12,88,40,138,148,113,201,21,3,224,146,169,34,230,5,72,41,149,152,142,204,63,137,207,219,186,3,131,99,140,65,94,13,199,229,166,243,212,136,0,57,80,180,109,155,61,152,120,19,118,209,64,81,97,73,119,103,122,36,200,25,93,83,54,184,212,53,222,131,161,88,94,167,245,16,145,20,84,214,179,42,84,110,241,189,51,104,173,110,155,215,204,85,125,221,156,178,73,0,143,215,189,157,112,240,232,153,247,224,214,131,196,45,217,218,13,46,223,173,86,6,87,224,244,243,169,137,175,184,25,120,151,213,143,30,148,212,165,71,168,122,60,137,249,50,147,57,116,110,76,104,12,79,4,163,87,235,139,115,61,86,236,181,116,99,2,187,3,249,66,205,179,57,196,41,129,207,30,24,85,14,199,60,248,114,107,239,190,53,104,30,228,26,107,24,171,246,116,67,232,111,192,81,127,182,141,35,21,38,56,41,89,84,76,5,227,162,148,44,195,36,100,145,20,169,202,162,52,226,66,236,158,70,31,218,118,21,108,30,143,225,62,247,180,20,74,99,121,5,246,74,182,141,3,233,6,166,175,35,253,143,202,20,49,137,11,198,39,60,97,92,133,49,19,33,198,76,241,73,52,149,34,83,34,156,80,191,253,231,219,210,174,180,132,234,174,67,3,251,142,132,231,7,246,197,164,251,98,152,182,117,99,138,199,98,206,79,236,28,166,70,76,10,197,85,70,6,162,8,25,231,9,176,34,204,20,43,213,180,136,64,101,188,72,104,106,118,180,240,190,228,15,109,111,228,126,193,236,184,233,255,180,193,255,97,47,255,102,213,206,14,251,37,195,251,86,198,242,45,13,219,46,216,253,4,180,148,83,62,82,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,77,115,155,48,20,252,43,30,37,71,203,35,9,4,136,107,115,241,76,62,220,58,205,197,248,240,144,158,26,207,96,240,32,104,39,245,240,223,43,48,196,177,155,158,170,3,140,30,218,125,203,238,211,145,220,54,111,7,36,41,121,198,186,6,87,217,102,241,165,170,113,177,170,43,141,206,45,238,43,13,197,238,55,228,5,174,160,134,61,54,88,191,64,209,162,187,223,185,102,62,187,132,145,57,185,253,57,124,37,233,230,72,150,13,238,191,47,141,103,207,163,200,70,49,211,84,9,205,104,40,115,77,115,6,57,229,10,18,195,49,150,66,25,15,214,85,209,238,203,7,108,96,5,205,43,73,143,100,96,243,4,82,71,26,56,67,202,121,226,9,52,71,154,128,100,84,74,136,133,181,42,55,38,36,221,156,56,253,138,123,24,154,158,193,60,202,49,136,36,167,137,69,65,67,46,21,77,140,97,20,18,22,152,48,74,2,99,130,30,60,158,63,3,55,55,155,165,123,250,85,98,189,30,120,83,11,133,195,237,194,87,175,10,239,230,164,71,48,214,122,82,75,101,156,72,26,138,32,161,160,34,65,133,111,5,145,177,74,176,184,219,222,108,251,142,102,231,14,5,188,189,252,221,248,107,235,125,183,59,52,51,112,51,208,186,106,203,230,132,57,92,228,240,17,117,204,78,113,102,36,205,254,21,232,248,62,201,191,140,244,58,205,140,204,51,178,174,218,90,247,140,129,223,220,125,144,59,52,25,142,92,109,167,248,124,165,108,139,98,172,220,65,3,211,193,169,92,153,225,15,151,229,122,74,109,96,97,227,162,159,60,166,117,210,246,63,176,7,40,225,7,214,143,222,128,179,246,119,149,207,222,198,137,56,23,74,178,152,91,26,35,40,26,162,207,210,15,45,80,197,85,110,131,56,240,243,39,6,244,55,180,88,99,169,241,82,152,144,38,214,188,159,118,131,253,240,51,78,243,144,9,202,4,50,236,231,215,68,56,226,221,224,118,127,111,70,93,189,85,29,233,186,109,247,7,6,29,9,78,171,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "63c69a324ff64ed8bdd02ff85dfbe88a",
							"BaseElements.ChangeContactAccount.Parameters.RecordColumnValues.Value");
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

		#region Class: ChangeLeadStageHandoffToSaleFlowElement

		/// <exclude/>
		public class ChangeLeadStageHandoffToSaleFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeLeadStageHandoffToSaleFlowElement(UserConnection userConnection, LeadManagementQualification78 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeLeadStageHandoffToSale";
				IsLogging = true;
				SchemaElementUId = new Guid("2b2b8a21-5d60-4170-a9eb-caa404a44b84");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifyStatus = () => (Guid)(new Guid("ceb70b3c-985f-4867-ae7c-88f9dd710688"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifyStatus", () => _recordColumnValues_QualifyStatus.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifyStatus;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,85,223,79,219,48,16,254,87,166,60,99,148,218,78,156,240,54,49,54,33,77,131,9,180,23,202,195,197,62,151,104,105,19,217,46,91,135,248,223,119,73,218,82,74,129,12,9,193,250,228,92,207,159,191,251,241,221,221,68,186,2,239,191,193,20,163,131,232,28,157,3,95,219,176,255,185,172,2,186,47,174,158,55,209,94,228,209,149,80,149,127,208,244,246,35,83,134,79,16,128,174,220,140,239,16,198,209,193,120,55,198,56,218,27,71,101,192,169,39,31,186,162,100,174,99,158,90,6,113,108,153,76,45,157,50,157,48,163,69,162,193,154,216,40,236,61,31,3,63,172,167,13,56,236,223,232,224,109,119,60,95,52,173,235,136,12,186,115,41,125,61,91,26,69,75,194,31,205,160,168,208,208,119,112,115,36,83,112,229,148,162,193,243,114,138,167,224,232,173,22,167,110,77,228,100,161,242,173,87,133,54,28,253,110,28,122,95,214,179,231,200,85,243,233,108,211,155,0,112,253,185,164,19,119,28,91,207,83,8,87,29,196,49,209,186,237,88,126,156,76,28,78,32,148,215,155,36,126,226,162,243,27,150,63,186,96,168,74,63,160,154,227,198,155,247,35,57,132,38,244,1,245,207,147,131,43,39,87,131,99,93,103,236,185,112,57,25,155,149,243,64,204,157,49,240,148,140,215,173,161,71,89,29,199,209,197,177,63,249,53,67,119,166,175,112,10,125,214,46,247,201,186,101,88,227,31,220,40,3,194,136,92,50,157,20,156,73,91,0,43,80,42,166,164,162,220,26,145,102,9,222,94,246,60,74,223,84,176,248,177,126,238,43,66,159,176,54,111,244,109,101,145,161,20,154,9,145,39,76,106,153,178,60,149,5,203,51,40,20,79,139,108,100,114,170,47,253,218,202,23,22,180,201,98,38,172,42,152,84,182,96,192,5,48,37,140,210,84,63,41,133,120,58,75,199,179,199,186,95,254,159,221,255,125,78,67,198,46,206,2,132,185,31,38,132,97,89,220,209,68,163,167,149,208,150,246,131,15,48,233,101,228,208,162,195,153,198,190,145,214,65,111,49,126,168,157,118,222,93,188,43,245,116,129,111,168,103,217,187,70,229,49,200,196,176,88,208,48,145,198,80,219,26,4,150,197,153,82,156,235,36,227,186,195,219,138,189,212,16,86,164,239,132,56,24,237,129,166,182,80,73,43,151,157,92,170,122,66,198,234,164,65,183,252,171,235,160,29,13,125,79,9,237,168,112,117,29,182,234,182,86,238,170,143,184,226,98,148,106,197,112,36,13,147,50,183,44,227,92,178,36,231,68,87,38,35,193,19,98,67,187,176,205,231,89,61,119,122,185,123,124,191,4,95,180,220,222,96,101,253,203,22,218,185,7,134,116,230,123,153,216,175,59,151,223,96,228,190,112,138,62,50,148,94,82,202,123,227,99,168,208,95,83,196,183,209,237,95,25,174,46,194,197,10,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,93,111,219,32,20,253,43,17,237,99,176,192,56,96,242,186,62,44,82,58,69,75,215,151,166,15,23,184,172,214,28,19,25,103,82,23,229,191,143,56,246,210,84,171,52,105,60,216,226,154,243,161,115,240,129,220,118,175,59,36,115,242,128,109,11,49,248,46,251,20,90,204,86,109,176,24,99,182,12,22,234,234,23,152,26,87,208,194,22,59,108,31,161,222,99,92,86,177,155,78,174,97,100,74,110,127,246,95,201,252,233,64,22,29,110,191,45,92,98,247,165,97,160,133,167,32,53,208,34,151,158,106,166,12,205,17,208,24,227,81,112,150,192,54,212,251,109,115,143,29,172,160,123,33,243,3,233,217,18,129,177,204,230,78,50,58,3,225,104,81,22,140,2,20,72,173,100,8,74,73,204,153,36,199,41,137,246,5,183,208,139,94,192,5,7,95,106,212,84,205,152,161,69,82,164,165,5,75,189,23,218,200,68,198,209,158,192,195,249,11,240,233,102,25,194,143,253,46,203,115,81,112,235,56,157,25,33,104,97,147,188,102,156,83,233,149,212,2,189,196,162,200,44,26,197,140,176,84,151,51,159,60,74,69,1,149,165,101,233,181,115,138,51,89,150,55,207,39,33,87,197,93,13,175,143,31,234,45,17,220,36,118,240,29,179,207,208,184,224,253,164,11,147,8,53,198,51,195,238,170,140,183,28,135,205,185,211,13,153,111,62,106,117,120,175,251,176,174,123,125,95,233,134,76,55,100,29,246,173,61,49,138,180,185,123,99,190,23,233,143,188,219,142,29,166,73,179,175,235,97,114,7,29,140,7,199,113,112,149,175,208,45,154,245,88,93,207,194,134,69,255,242,24,215,217,219,255,192,238,161,73,25,183,95,82,0,23,239,127,92,62,164,24,71,98,147,235,25,83,220,83,133,160,211,29,146,57,45,29,7,170,185,54,94,40,145,123,159,247,232,175,232,177,197,198,226,181,177,127,185,65,3,62,246,105,159,126,158,193,215,41,170,35,57,30,159,143,191,1,109,248,165,114,176,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "63c69a324ff64ed8bdd02ff85dfbe88a",
							"BaseElements.ChangeLeadStageHandoffToSale.Parameters.RecordColumnValues.Value");
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

		#region Class: LinkContactToLeadFlowElement

		/// <exclude/>
		public class LinkContactToLeadFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public LinkContactToLeadFlowElement(UserConnection userConnection, LeadManagementQualification78 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "LinkContactToLead";
				IsLogging = true;
				SchemaElementUId = new Guid("9da5af0d-7621-41eb-8e00-f682895bb04e");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifiedContact = () => (Guid)((process.ContactId));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifiedContact", () => _recordColumnValues_QualifiedContact.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifiedContact;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,128,182,222,190,21,169,91,4,40,154,0,49,114,169,114,88,146,75,155,168,100,9,36,157,214,53,252,239,93,74,182,234,20,46,226,246,210,232,164,29,12,103,103,95,187,72,214,224,220,103,104,48,154,69,11,180,22,92,171,253,245,7,83,123,180,31,109,187,233,162,171,200,161,53,80,155,31,168,6,124,174,140,127,15,30,232,201,174,250,165,80,69,179,234,188,70,21,93,85,145,241,216,56,226,208,19,129,178,140,51,201,153,206,177,100,137,156,32,43,210,36,15,33,36,101,145,136,73,30,15,204,63,137,223,180,77,7,22,135,28,189,188,238,127,23,219,46,80,39,4,200,158,98,92,187,62,128,113,48,225,230,107,16,53,42,138,189,221,32,65,222,154,134,170,193,133,105,240,30,44,229,10,58,109,128,136,164,161,118,129,85,163,246,243,239,157,69,231,76,187,126,205,92,189,105,214,167,108,18,192,49,60,216,225,189,199,192,188,7,191,234,37,110,201,214,190,119,249,110,185,180,184,4,111,158,79,77,124,197,109,207,187,172,127,244,64,209,148,30,161,222,224,73,206,151,149,220,64,231,135,130,134,244,68,176,102,185,186,184,214,177,99,175,149,59,37,176,59,146,47,212,60,91,195,52,35,240,57,0,131,202,241,183,138,190,220,186,187,111,107,180,15,114,133,13,12,93,123,186,38,244,55,96,212,159,237,114,5,177,138,203,132,201,84,76,89,162,5,48,129,212,201,60,201,129,115,21,103,69,138,251,167,193,135,113,93,13,219,199,49,221,39,132,161,97,161,111,20,151,185,40,115,158,166,172,212,165,102,137,42,166,76,104,205,153,72,181,228,133,228,92,2,167,249,134,47,140,161,93,26,9,245,93,135,22,14,19,224,231,23,244,197,102,135,226,109,219,250,161,164,177,121,163,151,227,138,112,208,83,29,23,130,41,153,165,180,34,249,132,21,137,74,153,80,37,242,50,203,164,40,4,153,161,235,14,253,125,104,55,86,30,174,201,13,103,253,79,231,250,31,142,240,111,238,234,236,102,95,178,169,111,101,7,223,204,166,237,163,253,79,6,10,39,89,60,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,193,114,155,48,16,253,21,143,146,163,215,35,33,33,36,174,205,197,51,73,235,54,105,46,182,15,139,180,106,60,131,193,3,184,157,212,195,191,23,99,136,99,55,61,85,7,24,173,246,189,125,122,15,14,236,182,121,221,17,75,217,19,85,21,214,101,104,102,159,202,138,102,139,170,116,84,215,179,251,210,97,190,249,141,89,78,11,172,112,75,13,85,207,152,239,169,190,223,212,205,116,114,9,99,83,118,251,179,63,101,233,242,192,230,13,109,191,207,125,199,206,61,5,12,73,0,31,180,5,197,149,4,19,25,5,222,161,212,34,177,145,241,81,7,118,101,190,223,22,15,212,224,2,155,23,150,30,88,207,214,17,160,87,150,251,216,0,143,21,130,242,38,6,27,41,13,222,27,165,53,101,210,26,201,218,41,171,221,11,109,177,31,122,6,43,129,193,88,178,144,196,60,3,69,89,6,198,161,131,16,164,205,180,50,74,144,59,130,135,254,51,112,121,179,156,215,95,126,21,84,61,246,188,105,192,188,166,245,172,171,94,21,222,204,73,15,145,8,92,82,236,65,100,137,1,101,188,3,75,146,131,112,70,7,43,180,80,198,180,235,155,245,113,162,223,212,187,28,95,159,255,30,252,117,223,249,30,54,228,39,88,79,92,89,52,232,154,19,102,119,145,195,123,212,97,117,138,115,197,210,213,191,2,29,222,39,249,151,145,94,167,185,98,211,21,123,44,247,149,59,50,202,110,115,247,78,110,63,164,111,185,218,142,241,117,149,98,159,231,67,229,14,27,28,27,199,114,233,251,27,206,139,199,49,181,158,133,15,11,62,120,140,235,164,237,127,96,15,88,224,15,170,62,119,6,156,181,191,169,124,234,108,28,137,179,200,198,60,17,1,18,194,238,227,37,29,129,241,2,193,10,155,5,153,200,40,132,168,71,127,163,64,21,21,142,46,133,9,157,145,212,177,0,19,40,2,37,98,219,225,61,7,52,92,122,165,141,244,94,14,248,186,119,251,248,223,12,186,142,86,181,172,109,215,237,31,224,2,233,168,171,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "63c69a324ff64ed8bdd02ff85dfbe88a",
							"BaseElements.LinkContactToLead.Parameters.RecordColumnValues.Value");
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

		#region Class: LinkAccountToLeadFlowElement

		/// <exclude/>
		public class LinkAccountToLeadFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public LinkAccountToLeadFlowElement(UserConnection userConnection, LeadManagementQualification78 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "LinkAccountToLead";
				IsLogging = true;
				SchemaElementUId = new Guid("1337590d-7ee1-488b-b0db-de061f6759f5");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifiedAccount = () => (Guid)((process.AccountId));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifiedAccount", () => _recordColumnValues_QualifiedAccount.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifiedAccount;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,64,239,135,111,69,234,22,1,138,38,64,140,92,170,28,150,212,210,38,170,23,72,58,173,107,232,223,187,148,108,213,41,92,196,237,165,225,137,28,204,206,206,46,119,247,158,168,193,152,207,208,160,183,240,86,168,53,152,78,218,235,15,170,182,168,63,234,110,219,123,87,158,65,173,160,86,63,176,154,240,101,165,236,123,176,64,33,251,242,151,66,233,45,202,243,26,165,119,85,122,202,98,99,136,67,33,9,151,97,234,71,25,11,179,84,176,184,74,10,198,19,153,50,145,201,16,5,15,69,2,201,196,252,147,248,77,215,244,160,113,202,49,202,203,241,186,218,245,142,26,16,32,70,138,50,93,123,0,35,103,194,44,91,224,53,86,244,182,122,139,4,89,173,26,170,6,87,170,193,123,208,148,203,233,116,14,34,146,132,218,56,86,141,210,46,191,247,26,141,81,93,251,154,185,122,219,180,167,108,18,192,249,121,176,227,143,30,29,243,30,236,102,148,184,37,91,195,232,242,221,122,173,113,13,86,61,159,154,248,138,187,145,119,89,255,40,160,162,95,122,132,122,139,39,57,95,86,114,3,189,157,10,154,210,19,65,171,245,230,226,90,231,142,189,86,110,72,96,127,36,95,168,121,182,134,48,37,240,217,1,147,202,241,90,122,95,110,205,221,183,22,245,131,216,96,3,83,215,158,174,9,253,13,152,245,23,251,172,130,168,138,138,152,137,132,135,44,150,28,24,199,56,99,89,156,129,239,87,81,154,39,56,60,77,62,148,233,107,216,61,206,233,62,33,76,13,115,125,163,119,64,17,50,71,193,124,30,20,44,206,179,140,229,89,24,179,36,22,81,148,35,132,133,27,187,193,29,247,13,221,90,9,168,239,122,212,112,248,1,255,252,128,190,152,108,87,188,238,58,59,149,52,55,111,246,114,28,17,63,200,43,14,92,178,176,8,42,22,99,206,25,151,185,96,69,42,227,128,124,114,46,41,114,160,237,118,253,125,232,182,90,28,182,201,76,107,253,79,235,250,31,150,240,111,246,234,236,100,95,50,169,111,101,6,223,204,164,13,222,240,19,106,59,58,37,60,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,77,115,155,48,16,253,43,30,37,71,203,3,66,2,137,107,115,241,76,62,220,58,205,197,246,97,37,173,26,207,96,240,32,104,39,245,240,223,43,99,136,99,55,61,85,7,24,45,251,222,190,221,183,28,200,109,243,182,71,146,147,103,172,107,240,149,107,102,95,170,26,103,139,186,50,232,253,236,190,50,80,108,127,131,46,112,1,53,236,176,193,250,5,138,22,253,253,214,55,211,201,37,140,76,201,237,207,254,43,201,87,7,50,111,112,247,125,110,3,59,139,165,72,109,34,105,170,193,81,206,83,160,160,53,167,42,3,37,83,30,107,39,117,0,155,170,104,119,229,3,54,176,128,230,149,228,7,210,179,5,130,132,41,174,0,57,117,46,78,40,151,78,80,229,132,165,92,64,198,133,144,8,66,144,110,74,188,121,197,29,244,69,207,96,30,131,147,10,21,205,68,164,41,71,173,169,52,96,2,87,162,116,202,37,143,209,28,193,67,254,25,184,186,89,205,253,211,175,18,235,101,207,155,59,40,60,110,102,33,122,21,120,31,78,126,0,235,28,79,165,163,34,147,130,114,22,186,6,149,50,202,108,104,59,181,78,177,40,235,54,55,155,99,69,187,245,251,2,222,94,254,46,252,181,13,115,119,91,180,19,240,19,48,166,106,203,230,132,217,95,248,240,17,117,88,159,236,92,147,124,253,47,67,135,247,73,254,165,165,215,110,174,201,116,77,150,85,91,155,35,99,18,46,119,31,228,246,69,250,148,171,235,104,95,136,148,109,81,12,145,59,104,96,76,28,195,149,237,59,156,151,203,209,181,158,37,26,14,253,228,49,158,147,182,255,129,61,64,9,63,176,126,12,3,56,107,127,87,249,28,198,56,18,107,166,68,148,197,142,102,8,42,172,79,240,82,218,24,168,138,149,118,73,150,48,231,88,143,254,134,14,107,44,13,94,10,99,194,102,38,6,77,99,139,81,216,216,40,166,154,71,140,70,12,35,12,251,203,108,138,3,222,247,211,62,254,55,131,174,227,168,58,210,117,155,238,15,240,41,104,173,171,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "63c69a324ff64ed8bdd02ff85dfbe88a",
							"BaseElements.LinkAccountToLead.Parameters.RecordColumnValues.Value");
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

		#region Class: ReadSystemSettingsFlowElement

		/// <exclude/>
		public class ReadSystemSettingsFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadSystemSettingsFlowElement(UserConnection userConnection, LeadManagementQualification78 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadSystemSettings";
				IsLogging = true;
				SchemaElementUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,193,142,155,48,16,253,149,202,231,165,10,196,129,176,183,85,54,237,173,187,85,162,61,113,25,204,64,172,53,24,217,102,213,116,149,127,239,216,208,148,149,82,109,180,151,170,156,224,241,230,249,205,204,243,43,19,10,172,253,6,45,178,91,182,71,99,192,234,218,125,254,34,149,67,243,213,232,161,103,55,204,162,145,160,228,79,172,70,124,91,73,119,15,14,168,228,181,248,163,80,176,219,226,178,70,193,110,10,38,29,182,150,56,84,146,100,235,52,75,86,171,40,73,22,117,196,5,23,81,190,230,105,180,18,241,34,175,210,108,137,21,31,153,127,19,223,232,182,7,131,227,25,65,190,14,175,251,99,239,169,49,1,34,80,164,213,221,4,46,189,9,187,237,160,84,88,209,183,51,3,18,228,140,108,169,27,220,203,22,31,193,208,89,94,71,123,136,72,53,40,235,89,10,107,183,253,209,27,180,86,234,238,61,115,106,104,187,57,155,4,240,252,57,217,89,4,143,158,249,8,238,16,36,118,71,187,67,231,100,215,88,18,169,136,117,10,158,239,154,198,96,3,78,190,204,45,61,227,49,84,93,55,77,42,168,104,103,79,160,6,156,77,233,109,95,27,232,221,216,94,48,67,27,251,100,71,67,147,31,170,48,178,57,92,61,138,243,64,223,155,70,66,96,255,155,124,165,230,197,166,146,140,192,23,15,132,178,141,65,90,228,157,16,122,232,220,67,247,125,160,32,215,82,192,216,230,137,30,63,4,221,16,164,30,122,52,211,143,176,157,11,97,121,147,178,212,79,67,107,183,19,7,108,225,236,116,182,197,167,209,199,108,89,28,82,94,229,101,30,149,124,89,70,60,206,211,104,141,49,68,88,174,51,142,203,122,17,99,76,190,232,214,249,198,118,122,48,98,74,185,29,175,219,135,174,209,63,184,28,31,207,251,197,128,93,19,152,255,33,10,39,118,250,5,226,168,0,60,117,5,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,11,174,44,14,78,45,41,201,204,75,47,182,50,180,50,212,241,76,177,50,176,50,0,0,176,83,7,250,22,0,0,0 })));
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
								new Guid("951b2bbb-0ba3-4049-9a29-b5d4c0b6d50f")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("951b2bbb-0ba3-4049-9a29-b5d4c0b6d50f"));
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

		#region Class: ChangeLeadIsQualificationPassedTrueFlowElement

		/// <exclude/>
		public class ChangeLeadIsQualificationPassedTrueFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeLeadIsQualificationPassedTrueFlowElement(UserConnection userConnection, LeadManagementQualification78 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeLeadIsQualificationPassedTrue";
				IsLogging = true;
				SchemaElementUId = new Guid("d5956d29-6377-467e-a94b-24cf386951b3");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualificationPassed = () => (bool)(true);
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualificationPassed", () => _recordColumnValues_QualificationPassed.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<bool> _recordColumnValues_QualificationPassed;

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

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,65,110,219,48,16,252,139,206,97,64,89,178,68,249,86,164,110,17,160,104,2,196,200,165,202,97,69,174,108,162,146,37,144,116,90,215,240,223,187,20,109,213,41,92,196,237,165,209,73,28,12,103,103,150,187,187,72,54,96,237,103,104,49,154,69,11,52,6,108,87,187,235,15,186,113,104,62,154,110,211,71,87,145,69,163,161,209,63,80,5,124,174,180,123,15,14,232,202,174,252,165,80,70,179,242,188,70,25,93,149,145,118,216,90,226,208,149,105,146,229,169,40,42,198,33,150,44,77,39,138,21,25,198,172,22,21,78,161,226,137,4,12,204,63,137,223,116,109,15,6,67,141,65,190,30,126,23,219,222,83,99,2,228,64,209,182,91,31,192,196,155,176,243,53,84,13,42,58,59,179,65,130,156,209,45,165,193,133,110,241,30,12,213,242,58,157,135,136,84,67,99,61,171,193,218,205,191,247,6,173,213,221,250,53,115,205,166,93,159,178,73,0,199,227,193,14,31,60,122,230,61,184,213,32,113,75,182,246,131,203,119,203,165,193,37,56,253,124,106,226,43,110,7,222,101,253,163,11,138,94,233,17,154,13,158,212,124,153,228,6,122,23,2,133,242,68,48,122,185,186,56,235,216,177,215,226,78,8,236,143,228,11,53,207,102,152,100,4,62,123,32,168,28,127,203,232,203,173,189,251,182,70,243,32,87,216,66,232,218,211,53,161,191,1,163,254,108,151,43,72,84,82,164,76,78,171,9,75,235,10,88,133,105,206,242,52,7,206,85,146,137,41,238,159,130,15,109,251,6,182,143,99,185,79,8,161,97,190,111,116,206,115,17,199,156,39,76,212,156,180,64,10,38,84,142,76,74,169,42,16,73,193,227,130,222,215,127,254,25,186,165,150,208,220,245,104,224,240,2,252,252,128,190,152,108,31,222,116,157,11,145,198,230,141,94,142,35,82,37,185,20,21,87,76,76,33,101,105,38,114,6,105,34,88,60,201,84,130,57,121,138,57,153,161,237,246,253,125,232,54,70,30,182,201,134,181,254,167,117,253,15,75,248,55,123,117,118,178,47,153,212,183,50,131,111,102,210,246,209,254,39,244,144,220,81,60,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,146,79,79,227,48,16,197,191,202,202,226,88,87,118,226,198,113,175,112,169,4,168,162,192,133,236,97,108,143,33,82,154,84,142,139,196,86,249,238,235,154,100,75,209,114,1,31,226,63,51,239,205,211,79,57,144,139,240,182,67,178,36,247,232,61,244,157,11,243,203,206,227,124,237,59,131,125,63,191,238,12,52,245,31,208,13,174,193,195,22,3,250,71,104,246,216,95,215,125,152,253,58,151,145,25,185,120,77,85,178,124,58,144,85,192,237,195,202,70,119,112,165,45,11,37,105,33,133,163,34,95,88,90,170,44,163,139,82,114,38,100,134,198,138,40,54,93,179,223,182,55,24,96,13,225,133,44,15,36,185,69,3,43,10,224,186,40,40,151,32,169,40,88,78,53,55,72,133,202,121,46,25,183,144,115,50,204,72,111,94,112,11,105,232,73,44,120,156,175,80,81,185,96,154,10,212,154,150,6,12,117,46,87,186,16,165,224,104,142,226,177,255,36,12,62,110,177,96,235,126,215,192,219,227,87,245,221,25,154,143,29,135,234,157,112,69,150,213,87,140,199,125,147,162,159,83,254,12,184,34,179,138,108,186,189,55,71,199,60,94,174,62,68,75,67,82,203,167,235,68,52,190,180,251,166,25,95,174,32,192,212,56,61,119,182,118,53,218,85,187,153,64,38,23,54,46,250,159,207,180,222,179,253,68,118,3,45,60,163,191,141,0,78,217,255,165,188,143,24,39,99,197,116,177,208,174,164,204,57,67,5,23,156,150,82,42,154,137,140,197,3,56,197,100,82,223,161,67,143,173,193,111,6,187,195,62,209,62,254,202,99,174,35,170,129,12,195,239,225,47,192,55,28,150,62,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "63c69a324ff64ed8bdd02ff85dfbe88a",
							"BaseElements.ChangeLeadIsQualificationPassedTrue.Parameters.RecordColumnValues.Value");
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

		public LeadManagementQualification78(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadManagementQualification78";
			SchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = false;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_leadAddressType = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("AddressType").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("AddressTypeId") : Guid.Empty))); };
			_leadCity = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("City").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("CityId") : Guid.Empty))); };
			_leadZip = () => { return new LocalizableString(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Zip").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Zip") : null))); };
			_leadRegion = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Region").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("RegionId") : Guid.Empty))); };
			_leadCountry = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Country").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("CountryId") : Guid.Empty))); };
			_leadWebsite = () => { return new LocalizableString(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Website").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Website") : null))); };
			_leadFax = () => { return new LocalizableString(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Fax").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Fax") : null))); };
			_leadBusinessPhone = () => { return new LocalizableString(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("BusinesPhone").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("BusinesPhone") : null))); };
			_leadEmail = () => { return new LocalizableString(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Email") : null))); };
			_leadMobilePhone = () => { return new LocalizableString(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("MobilePhone").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("MobilePhone") : null))); };
			_leadDecisionRole = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("DecisionRole").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("DecisionRoleId") : Guid.Empty))); };
			_leadGender = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Gender").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("GenderId") : Guid.Empty))); };
			_leadDepartment = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Department").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("DepartmentId") : Guid.Empty))); };
			_leadJob = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Job").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("JobId") : Guid.Empty))); };
			_leadSalutation = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("TitleId") : Guid.Empty))); };
			_leadDear = () => { return new LocalizableString(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Dear").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Dear") : null))); };
			_leadFullJobTitle = () => { return new LocalizableString(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("FullJobTitle").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("FullJobTitle") : null))); };
			_leadContactName = () => { return new LocalizableString(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Contact") : null))); };
			_leadAccountName = () => { return new LocalizableString(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Account") : null))); };
			_leadAnnualRevenue = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("AnnualRevenue").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("AnnualRevenueId") : Guid.Empty))); };
			_leadEmployeesNumber = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("EmployeesNumber").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("EmployeesNumberId") : Guid.Empty))); };
			_leadAccountCategory = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("AccountCategory").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("AccountCategoryId") : Guid.Empty))); };
			_leadIndustry = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Industry").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("IndustryId") : Guid.Empty))); };
			_leadOwnership = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("AccountOwnership").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("AccountOwnershipId") : Guid.Empty))); };
			_leadAccountId = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("QualifiedAccount").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("QualifiedAccountId") : Guid.Empty))); };
			_leadContactId = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("QualifiedContact").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("QualifiedContactId") : Guid.Empty))); };
			_leadAddress = () => { return new LocalizableString(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Address").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Address") : null))); };
			_createAccountOnQualification = () => { return (bool)(((ReadSystemSettings.ResultEntity.IsColumnValueLoaded(ReadSystemSettings.ResultEntity.Schema.Columns.GetByName("BooleanValue").ColumnValueName) ? ReadSystemSettings.ResultEntity.GetTypedColumnValue<bool>("BooleanValue") : false))); };
			_leadQualificationPassed = () => { return (bool)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("QualificationPassed").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<bool>("QualificationPassed") : false))); };
			_leadOwner = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty))); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: LeadManagementQualification78, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: LeadManagementQualification78, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual Guid AccountId {
			get;
			set;
		}

		public virtual Guid ContactId {
			get;
			set;
		}

		private Func<Guid> _leadAddressType;
		public virtual Guid LeadAddressType {
			get {
				return (_leadAddressType ?? (_leadAddressType = () => Guid.Empty)).Invoke();
			}
			set {
				_leadAddressType = () => { return value; };
			}
		}

		private Func<Guid> _leadCity;
		public virtual Guid LeadCity {
			get {
				return (_leadCity ?? (_leadCity = () => Guid.Empty)).Invoke();
			}
			set {
				_leadCity = () => { return value; };
			}
		}

		private Func<string> _leadZip;
		public virtual string LeadZip {
			get {
				return (_leadZip ?? (_leadZip = () => null)).Invoke();
			}
			set {
				_leadZip = () => { return value; };
			}
		}

		private Func<Guid> _leadRegion;
		public virtual Guid LeadRegion {
			get {
				return (_leadRegion ?? (_leadRegion = () => Guid.Empty)).Invoke();
			}
			set {
				_leadRegion = () => { return value; };
			}
		}

		private Func<Guid> _leadCountry;
		public virtual Guid LeadCountry {
			get {
				return (_leadCountry ?? (_leadCountry = () => Guid.Empty)).Invoke();
			}
			set {
				_leadCountry = () => { return value; };
			}
		}

		private Func<string> _leadWebsite;
		public virtual string LeadWebsite {
			get {
				return (_leadWebsite ?? (_leadWebsite = () => null)).Invoke();
			}
			set {
				_leadWebsite = () => { return value; };
			}
		}

		private Func<string> _leadFax;
		public virtual string LeadFax {
			get {
				return (_leadFax ?? (_leadFax = () => null)).Invoke();
			}
			set {
				_leadFax = () => { return value; };
			}
		}

		private Func<string> _leadBusinessPhone;
		public virtual string LeadBusinessPhone {
			get {
				return (_leadBusinessPhone ?? (_leadBusinessPhone = () => null)).Invoke();
			}
			set {
				_leadBusinessPhone = () => { return value; };
			}
		}

		private Func<string> _leadEmail;
		public virtual string LeadEmail {
			get {
				return (_leadEmail ?? (_leadEmail = () => null)).Invoke();
			}
			set {
				_leadEmail = () => { return value; };
			}
		}

		private Func<string> _leadMobilePhone;
		public virtual string LeadMobilePhone {
			get {
				return (_leadMobilePhone ?? (_leadMobilePhone = () => null)).Invoke();
			}
			set {
				_leadMobilePhone = () => { return value; };
			}
		}

		private Func<Guid> _leadDecisionRole;
		public virtual Guid LeadDecisionRole {
			get {
				return (_leadDecisionRole ?? (_leadDecisionRole = () => Guid.Empty)).Invoke();
			}
			set {
				_leadDecisionRole = () => { return value; };
			}
		}

		private Func<Guid> _leadGender;
		public virtual Guid LeadGender {
			get {
				return (_leadGender ?? (_leadGender = () => Guid.Empty)).Invoke();
			}
			set {
				_leadGender = () => { return value; };
			}
		}

		private Func<Guid> _leadDepartment;
		public virtual Guid LeadDepartment {
			get {
				return (_leadDepartment ?? (_leadDepartment = () => Guid.Empty)).Invoke();
			}
			set {
				_leadDepartment = () => { return value; };
			}
		}

		private Func<Guid> _leadJob;
		public virtual Guid LeadJob {
			get {
				return (_leadJob ?? (_leadJob = () => Guid.Empty)).Invoke();
			}
			set {
				_leadJob = () => { return value; };
			}
		}

		private Func<Guid> _leadSalutation;
		public virtual Guid LeadSalutation {
			get {
				return (_leadSalutation ?? (_leadSalutation = () => Guid.Empty)).Invoke();
			}
			set {
				_leadSalutation = () => { return value; };
			}
		}

		private Func<string> _leadDear;
		public virtual string LeadDear {
			get {
				return (_leadDear ?? (_leadDear = () => null)).Invoke();
			}
			set {
				_leadDear = () => { return value; };
			}
		}

		private Func<string> _leadFullJobTitle;
		public virtual string LeadFullJobTitle {
			get {
				return (_leadFullJobTitle ?? (_leadFullJobTitle = () => null)).Invoke();
			}
			set {
				_leadFullJobTitle = () => { return value; };
			}
		}

		private Func<string> _leadContactName;
		public virtual string LeadContactName {
			get {
				return (_leadContactName ?? (_leadContactName = () => null)).Invoke();
			}
			set {
				_leadContactName = () => { return value; };
			}
		}

		private Func<string> _leadAccountName;
		public virtual string LeadAccountName {
			get {
				return (_leadAccountName ?? (_leadAccountName = () => null)).Invoke();
			}
			set {
				_leadAccountName = () => { return value; };
			}
		}

		private Func<Guid> _leadAnnualRevenue;
		public virtual Guid LeadAnnualRevenue {
			get {
				return (_leadAnnualRevenue ?? (_leadAnnualRevenue = () => Guid.Empty)).Invoke();
			}
			set {
				_leadAnnualRevenue = () => { return value; };
			}
		}

		private Func<Guid> _leadEmployeesNumber;
		public virtual Guid LeadEmployeesNumber {
			get {
				return (_leadEmployeesNumber ?? (_leadEmployeesNumber = () => Guid.Empty)).Invoke();
			}
			set {
				_leadEmployeesNumber = () => { return value; };
			}
		}

		private Func<Guid> _leadAccountCategory;
		public virtual Guid LeadAccountCategory {
			get {
				return (_leadAccountCategory ?? (_leadAccountCategory = () => Guid.Empty)).Invoke();
			}
			set {
				_leadAccountCategory = () => { return value; };
			}
		}

		private Func<Guid> _leadIndustry;
		public virtual Guid LeadIndustry {
			get {
				return (_leadIndustry ?? (_leadIndustry = () => Guid.Empty)).Invoke();
			}
			set {
				_leadIndustry = () => { return value; };
			}
		}

		private Func<Guid> _leadOwnership;
		public virtual Guid LeadOwnership {
			get {
				return (_leadOwnership ?? (_leadOwnership = () => Guid.Empty)).Invoke();
			}
			set {
				_leadOwnership = () => { return value; };
			}
		}

		private Func<Guid> _leadAccountId;
		public virtual Guid LeadAccountId {
			get {
				return (_leadAccountId ?? (_leadAccountId = () => Guid.Empty)).Invoke();
			}
			set {
				_leadAccountId = () => { return value; };
			}
		}

		private Func<Guid> _leadContactId;
		public virtual Guid LeadContactId {
			get {
				return (_leadContactId ?? (_leadContactId = () => Guid.Empty)).Invoke();
			}
			set {
				_leadContactId = () => { return value; };
			}
		}

		private Func<string> _leadAddress;
		public virtual string LeadAddress {
			get {
				return (_leadAddress ?? (_leadAddress = () => null)).Invoke();
			}
			set {
				_leadAddress = () => { return value; };
			}
		}

		private Func<bool> _createAccountOnQualification;
		public virtual bool CreateAccountOnQualification {
			get {
				return (_createAccountOnQualification ?? (_createAccountOnQualification = () => false)).Invoke();
			}
			set {
				_createAccountOnQualification = () => { return value; };
			}
		}

		private Func<bool> _leadQualificationPassed;
		public virtual bool LeadQualificationPassed {
			get {
				return (_leadQualificationPassed ?? (_leadQualificationPassed = () => false)).Invoke();
			}
			set {
				_leadQualificationPassed = () => { return value; };
			}
		}

		private Func<Guid> _leadOwner;
		public virtual Guid LeadOwner {
			get {
				return (_leadOwner ?? (_leadOwner = () => Guid.Empty)).Invoke();
			}
			set {
				_leadOwner = () => { return value; };
			}
		}

		private ProcessLeadQualification _leadQualification;
		public ProcessLeadQualification LeadQualification {
			get {
				return _leadQualification ?? ((_leadQualification) = new ProcessLeadQualification(UserConnection, this));
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
					SchemaElementUId = new Guid("bf1b5b17-6f6d-4e3d-8136-b213854f53b7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessTerminateEvent _terminateQualified;
		public ProcessTerminateEvent TerminateQualified {
			get {
				return _terminateQualified ?? (_terminateQualified = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateQualified",
					SchemaElementUId = new Guid("279e66a8-61fb-4e2b-8559-0362a5ebb1fe"),
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
					SchemaElementUId = new Guid("ed9cbb4d-b5c9-4231-ab67-76ffff3433b0"),
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

		private ProcessTerminateEvent _terminate2;
		public ProcessTerminateEvent Terminate2 {
			get {
				return _terminate2 ?? (_terminate2 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate2",
					SchemaElementUId = new Guid("478ef5b0-3cfe-49aa-9d92-d33e5210847a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ReadLeadDataFlowElement _readLeadData;
		public ReadLeadDataFlowElement ReadLeadData {
			get {
				return _readLeadData ?? (_readLeadData = new ReadLeadDataFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeContactAccountFlowElement _changeContactAccount;
		public ChangeContactAccountFlowElement ChangeContactAccount {
			get {
				return _changeContactAccount ?? (_changeContactAccount = new ChangeContactAccountFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayAccountConnection;
		public ProcessExclusiveGateway ExclusiveGatewayAccountConnection {
			get {
				return _exclusiveGatewayAccountConnection ?? (_exclusiveGatewayAccountConnection = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayAccountConnection",
					SchemaElementUId = new Guid("968e7a35-4c26-459a-806f-a3b34d7fe1c2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewayAccountConnection.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ChangeLeadStageHandoffToSaleFlowElement _changeLeadStageHandoffToSale;
		public ChangeLeadStageHandoffToSaleFlowElement ChangeLeadStageHandoffToSale {
			get {
				return _changeLeadStageHandoffToSale ?? (_changeLeadStageHandoffToSale = new ChangeLeadStageHandoffToSaleFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _changeAccountScriptTask;
		public ProcessScriptTask ChangeAccountScriptTask {
			get {
				return _changeAccountScriptTask ?? (_changeAccountScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChangeAccountScriptTask",
					SchemaElementUId = new Guid("97776b38-7f29-472a-ab13-e87884d17d43"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ChangeAccountScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _changeContactScriptTask;
		public ProcessScriptTask ChangeContactScriptTask {
			get {
				return _changeContactScriptTask ?? (_changeContactScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChangeContactScriptTask",
					SchemaElementUId = new Guid("9970214a-b543-4895-ab00-ab57461e70cf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ChangeContactScriptTaskExecute,
				});
			}
		}

		private LinkContactToLeadFlowElement _linkContactToLead;
		public LinkContactToLeadFlowElement LinkContactToLead {
			get {
				return _linkContactToLead ?? (_linkContactToLead = new LinkContactToLeadFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private LinkAccountToLeadFlowElement _linkAccountToLead;
		public LinkAccountToLeadFlowElement LinkAccountToLead {
			get {
				return _linkAccountToLead ?? (_linkAccountToLead = new LinkAccountToLeadFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayQualifiedAccount;
		public ProcessExclusiveGateway ExclusiveGatewayQualifiedAccount {
			get {
				return _exclusiveGatewayQualifiedAccount ?? (_exclusiveGatewayQualifiedAccount = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayQualifiedAccount",
					SchemaElementUId = new Guid("045b9d72-61cb-4f5f-8a92-c02297c04e1d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewayQualifiedAccount.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ReadSystemSettingsFlowElement _readSystemSettings;
		public ReadSystemSettingsFlowElement ReadSystemSettings {
			get {
				return _readSystemSettings ?? (_readSystemSettings = new ReadSystemSettingsFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayIsQualificationPassed;
		public ProcessExclusiveGateway ExclusiveGatewayIsQualificationPassed {
			get {
				return _exclusiveGatewayIsQualificationPassed ?? (_exclusiveGatewayIsQualificationPassed = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayIsQualificationPassed",
					SchemaElementUId = new Guid("afcc2355-be16-486b-bcf6-db2841519eb1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewayIsQualificationPassed.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ChangeLeadIsQualificationPassedTrueFlowElement _changeLeadIsQualificationPassedTrue;
		public ChangeLeadIsQualificationPassedTrueFlowElement ChangeLeadIsQualificationPassedTrue {
			get {
				return _changeLeadIsQualificationPassedTrue ?? (_changeLeadIsQualificationPassedTrue = new ChangeLeadIsQualificationPassedTrueFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("00b2c101-a67f-4a28-a60e-f6ef8f988808"),
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
					SchemaElementUId = new Guid("8df03451-825f-4626-947e-1c39dddd618f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _qualifiedContactExistsSequenceFlow;
		public ProcessConditionalFlow QualifiedContactExistsSequenceFlow {
			get {
				return _qualifiedContactExistsSequenceFlow ?? (_qualifiedContactExistsSequenceFlow = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "QualifiedContactExistsSequenceFlow",
					SchemaElementUId = new Guid("644d1a44-d831-44e0-982d-8da2dc9c15bf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _qualifiedAccountExistsSequenceFlow;
		public ProcessConditionalFlow QualifiedAccountExistsSequenceFlow {
			get {
				return _qualifiedAccountExistsSequenceFlow ?? (_qualifiedAccountExistsSequenceFlow = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "QualifiedAccountExistsSequenceFlow",
					SchemaElementUId = new Guid("2e0ed20e-8966-4d04-847a-b6b5a83c0b82"),
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
					SchemaElementUId = new Guid("fce21b7b-3f73-4e8d-abd1-a8c48ebfab45"),
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
			FlowElements[TerminateQualified.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateQualified };
			FlowElements[ExclusiveGatewayIsLeadSet.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayIsLeadSet };
			FlowElements[Terminate2.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate2 };
			FlowElements[ReadLeadData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadData };
			FlowElements[ChangeContactAccount.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeContactAccount };
			FlowElements[ExclusiveGatewayAccountConnection.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayAccountConnection };
			FlowElements[ChangeLeadStageHandoffToSale.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeLeadStageHandoffToSale };
			FlowElements[ChangeAccountScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeAccountScriptTask };
			FlowElements[ChangeContactScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeContactScriptTask };
			FlowElements[LinkContactToLead.SchemaElementUId] = new Collection<ProcessFlowElement> { LinkContactToLead };
			FlowElements[LinkAccountToLead.SchemaElementUId] = new Collection<ProcessFlowElement> { LinkAccountToLead };
			FlowElements[ExclusiveGatewayQualifiedAccount.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayQualifiedAccount };
			FlowElements[ReadSystemSettings.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadSystemSettings };
			FlowElements[ExclusiveGatewayIsQualificationPassed.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayIsQualificationPassed };
			FlowElements[ChangeLeadIsQualificationPassedTrue.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeLeadIsQualificationPassedTrue };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayIsLeadSet", e.Context.SenderName));
						break;
					case "TerminateQualified":
						CompleteProcess();
						break;
					case "ExclusiveGatewayIsLeadSet":
						if (ConditionalFlowLeadUndefinedExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate2", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadData", e.Context.SenderName));
						break;
					case "Terminate2":
						CompleteProcess();
						break;
					case "ReadLeadData":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayIsQualificationPassed", e.Context.SenderName));
						break;
					case "ChangeContactAccount":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeLeadStageHandoffToSale", e.Context.SenderName));
						break;
					case "ExclusiveGatewayAccountConnection":
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeContactAccount", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeLeadStageHandoffToSale", e.Context.SenderName));
						break;
					case "ChangeLeadStageHandoffToSale":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeLeadIsQualificationPassedTrue", e.Context.SenderName));
						break;
					case "ChangeAccountScriptTask":
						if (QualifiedContactExistsSequenceFlowExpressionExecute()) {
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LinkContactToLead", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayQualifiedAccount", e.Context.SenderName));
						Log.ErrorFormat(DeadEndGatewayLogMessage, "ChangeAccountScriptTask");
						break;
					case "ChangeContactScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeAccountScriptTask", e.Context.SenderName));
						break;
					case "LinkContactToLead":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayQualifiedAccount", e.Context.SenderName));
						break;
					case "LinkAccountToLead":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayAccountConnection", e.Context.SenderName));
						break;
					case "ExclusiveGatewayQualifiedAccount":
						if (QualifiedAccountExistsSequenceFlowExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LinkAccountToLead", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayAccountConnection", e.Context.SenderName));
						break;
					case "ReadSystemSettings":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeContactScriptTask", e.Context.SenderName));
						break;
					case "ExclusiveGatewayIsQualificationPassed":
						if (ConditionalSequenceFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate2", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadSystemSettings", e.Context.SenderName));
						break;
					case "ChangeLeadIsQualificationPassedTrue":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateQualified", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlowLeadUndefinedExpressionExecute() {
			bool result = Convert.ToBoolean((LeadId) == Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGatewayIsLeadSet", "ConditionalFlowLeadUndefined", "(LeadId) == Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlow3ExpressionExecute() {
			bool result = Convert.ToBoolean((AccountId)!= Guid.Empty && (ContactId) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGatewayAccountConnection", "ConditionalFlow3", "(AccountId)!= Guid.Empty && (ContactId) != Guid.Empty", result);
			return result;
		}

		private bool QualifiedContactExistsSequenceFlowExpressionExecute() {
			bool result = Convert.ToBoolean((ContactId) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ChangeAccountScriptTask", "QualifiedContactExistsSequenceFlow", "(ContactId) != Guid.Empty", result);
			return result;
		}

		private bool QualifiedAccountExistsSequenceFlowExpressionExecute() {
			bool result = Convert.ToBoolean((AccountId) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGatewayQualifiedAccount", "QualifiedAccountExistsSequenceFlow", "(AccountId) != Guid.Empty", result);
			return result;
		}

		private bool ConditionalSequenceFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean((LeadQualificationPassed)==true );
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGatewayIsQualificationPassed", "ConditionalSequenceFlow1", "(LeadQualificationPassed)==true ", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("LeadId")) {
				writer.WriteValue("LeadId", LeadId, Guid.Empty);
			}
			if (!HasMapping("AccountId")) {
				writer.WriteValue("AccountId", AccountId, Guid.Empty);
			}
			if (!HasMapping("ContactId")) {
				writer.WriteValue("ContactId", ContactId, Guid.Empty);
			}
			if (!HasMapping("LeadAddressType")) {
				writer.WriteValue("LeadAddressType", LeadAddressType, Guid.Empty);
			}
			if (!HasMapping("LeadCity")) {
				writer.WriteValue("LeadCity", LeadCity, Guid.Empty);
			}
			if (!HasMapping("LeadZip")) {
				writer.WriteValue("LeadZip", LeadZip, null);
			}
			if (!HasMapping("LeadRegion")) {
				writer.WriteValue("LeadRegion", LeadRegion, Guid.Empty);
			}
			if (!HasMapping("LeadCountry")) {
				writer.WriteValue("LeadCountry", LeadCountry, Guid.Empty);
			}
			if (!HasMapping("LeadWebsite")) {
				writer.WriteValue("LeadWebsite", LeadWebsite, null);
			}
			if (!HasMapping("LeadFax")) {
				writer.WriteValue("LeadFax", LeadFax, null);
			}
			if (!HasMapping("LeadBusinessPhone")) {
				writer.WriteValue("LeadBusinessPhone", LeadBusinessPhone, null);
			}
			if (!HasMapping("LeadEmail")) {
				writer.WriteValue("LeadEmail", LeadEmail, null);
			}
			if (!HasMapping("LeadMobilePhone")) {
				writer.WriteValue("LeadMobilePhone", LeadMobilePhone, null);
			}
			if (!HasMapping("LeadDecisionRole")) {
				writer.WriteValue("LeadDecisionRole", LeadDecisionRole, Guid.Empty);
			}
			if (!HasMapping("LeadGender")) {
				writer.WriteValue("LeadGender", LeadGender, Guid.Empty);
			}
			if (!HasMapping("LeadDepartment")) {
				writer.WriteValue("LeadDepartment", LeadDepartment, Guid.Empty);
			}
			if (!HasMapping("LeadJob")) {
				writer.WriteValue("LeadJob", LeadJob, Guid.Empty);
			}
			if (!HasMapping("LeadSalutation")) {
				writer.WriteValue("LeadSalutation", LeadSalutation, Guid.Empty);
			}
			if (!HasMapping("LeadDear")) {
				writer.WriteValue("LeadDear", LeadDear, null);
			}
			if (!HasMapping("LeadFullJobTitle")) {
				writer.WriteValue("LeadFullJobTitle", LeadFullJobTitle, null);
			}
			if (!HasMapping("LeadContactName")) {
				writer.WriteValue("LeadContactName", LeadContactName, null);
			}
			if (!HasMapping("LeadAccountName")) {
				writer.WriteValue("LeadAccountName", LeadAccountName, null);
			}
			if (!HasMapping("LeadAnnualRevenue")) {
				writer.WriteValue("LeadAnnualRevenue", LeadAnnualRevenue, Guid.Empty);
			}
			if (!HasMapping("LeadEmployeesNumber")) {
				writer.WriteValue("LeadEmployeesNumber", LeadEmployeesNumber, Guid.Empty);
			}
			if (!HasMapping("LeadAccountCategory")) {
				writer.WriteValue("LeadAccountCategory", LeadAccountCategory, Guid.Empty);
			}
			if (!HasMapping("LeadIndustry")) {
				writer.WriteValue("LeadIndustry", LeadIndustry, Guid.Empty);
			}
			if (!HasMapping("LeadOwnership")) {
				writer.WriteValue("LeadOwnership", LeadOwnership, Guid.Empty);
			}
			if (!HasMapping("LeadAccountId")) {
				writer.WriteValue("LeadAccountId", LeadAccountId, Guid.Empty);
			}
			if (!HasMapping("LeadContactId")) {
				writer.WriteValue("LeadContactId", LeadContactId, Guid.Empty);
			}
			if (!HasMapping("LeadAddress")) {
				writer.WriteValue("LeadAddress", LeadAddress, null);
			}
			if (!HasMapping("CreateAccountOnQualification")) {
				writer.WriteValue("CreateAccountOnQualification", CreateAccountOnQualification, false);
			}
			if (!HasMapping("LeadQualificationPassed")) {
				writer.WriteValue("LeadQualificationPassed", LeadQualificationPassed, false);
			}
			if (!HasMapping("LeadOwner")) {
				writer.WriteValue("LeadOwner", LeadOwner, Guid.Empty);
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
			MetaPathParameterValues.Add("7da3d394-c5b2-4fba-be47-747a00d3685e", () => LeadId);
			MetaPathParameterValues.Add("adff468f-5785-4238-a962-2d46a6df9207", () => AccountId);
			MetaPathParameterValues.Add("21f03e5d-1b78-48dc-9e30-1c86f9161488", () => ContactId);
			MetaPathParameterValues.Add("2365f649-230d-4d6e-b38b-15932b94c2d9", () => LeadAddressType);
			MetaPathParameterValues.Add("a00b4828-9039-473d-9786-1042a8a4d495", () => LeadCity);
			MetaPathParameterValues.Add("b9c2234b-9f29-4b4b-bff9-43ed0aee7fd4", () => LeadZip);
			MetaPathParameterValues.Add("b120b526-724c-470e-9bde-cca7c5bce38b", () => LeadRegion);
			MetaPathParameterValues.Add("7f25c2c6-3a0b-430a-b8f4-14dac4a33300", () => LeadCountry);
			MetaPathParameterValues.Add("7573b5d0-d90d-43fb-a4ff-b434212f304d", () => LeadWebsite);
			MetaPathParameterValues.Add("ef248d37-29b4-41f3-ae05-29aa2ca78c1e", () => LeadFax);
			MetaPathParameterValues.Add("237e51db-51d4-40d3-ba2e-657d419fe693", () => LeadBusinessPhone);
			MetaPathParameterValues.Add("6547686a-48b1-457a-810e-01431f20fcf7", () => LeadEmail);
			MetaPathParameterValues.Add("f609b031-6cfd-4dbc-9110-5a3c4aaf1d59", () => LeadMobilePhone);
			MetaPathParameterValues.Add("7d3339ff-d4dd-47f4-aad0-f962a3c06682", () => LeadDecisionRole);
			MetaPathParameterValues.Add("26e960a5-407f-49ef-9aeb-194c10c5c07a", () => LeadGender);
			MetaPathParameterValues.Add("8ad4103a-0d1e-4f62-a22a-707a1d45a404", () => LeadDepartment);
			MetaPathParameterValues.Add("a0f4b101-277c-452d-94c8-b44202a3a196", () => LeadJob);
			MetaPathParameterValues.Add("f34298ea-de28-49a3-a7dd-0537e9d81810", () => LeadSalutation);
			MetaPathParameterValues.Add("61ebe384-47c3-41a5-8f7a-689cc754debd", () => LeadDear);
			MetaPathParameterValues.Add("69d73113-cfb5-46b5-bad8-db01b0089ad7", () => LeadFullJobTitle);
			MetaPathParameterValues.Add("9ccf4757-79ad-4fda-8a8d-091f07d873c6", () => LeadContactName);
			MetaPathParameterValues.Add("d7cbdc44-a5b7-48dc-bbaf-a96bd83d7066", () => LeadAccountName);
			MetaPathParameterValues.Add("485ac59c-8ec0-45f6-b314-99549ce9eedf", () => LeadAnnualRevenue);
			MetaPathParameterValues.Add("81219640-87de-43de-9f88-0867fbbd7c43", () => LeadEmployeesNumber);
			MetaPathParameterValues.Add("347c7337-e229-470b-a321-5aa2e5a4d102", () => LeadAccountCategory);
			MetaPathParameterValues.Add("7ab43aa0-0265-44da-baf7-13ae2e552bfe", () => LeadIndustry);
			MetaPathParameterValues.Add("5b328e21-1e24-46e8-a579-71076a3c942a", () => LeadOwnership);
			MetaPathParameterValues.Add("ae489f7c-9167-44af-a723-c61c0541a93a", () => LeadAccountId);
			MetaPathParameterValues.Add("f302fbc3-0ce9-4626-9957-2cf93197d6fd", () => LeadContactId);
			MetaPathParameterValues.Add("c945f2af-1eae-4ba3-a433-a8ea8b69d8b1", () => LeadAddress);
			MetaPathParameterValues.Add("70ebb313-bd3c-472f-bf4f-f07a23506a9c", () => CreateAccountOnQualification);
			MetaPathParameterValues.Add("9c638b0f-7b13-46c3-bef4-2010a78fb3a4", () => LeadQualificationPassed);
			MetaPathParameterValues.Add("d957170c-e768-44a5-a025-d5d08a8f9f76", () => LeadOwner);
			MetaPathParameterValues.Add("eb174310-4f6b-4191-b705-5ac74e8d6810", () => ReadLeadData.DataSourceFilters);
			MetaPathParameterValues.Add("2c5fddb8-7f3b-431c-a140-15c790c47997", () => ReadLeadData.ResultType);
			MetaPathParameterValues.Add("c9715250-2f51-47c6-ae51-692c6ef09e35", () => ReadLeadData.ReadSomeTopRecords);
			MetaPathParameterValues.Add("7aa6f27f-9136-4c8a-95c8-d11d8c5dd57c", () => ReadLeadData.NumberOfRecords);
			MetaPathParameterValues.Add("105c3fa8-1208-4d19-bf97-40057718c52f", () => ReadLeadData.FunctionType);
			MetaPathParameterValues.Add("001d410e-1ab8-4cd6-bb61-83ee17b39a5b", () => ReadLeadData.AggregationColumnName);
			MetaPathParameterValues.Add("a1588d18-597e-4d60-95bc-bd4c78338608", () => ReadLeadData.OrderInfo);
			MetaPathParameterValues.Add("724a8768-9516-4d2c-aa88-41a1bb2d5e37", () => ReadLeadData.ResultEntity);
			MetaPathParameterValues.Add("1eb2f334-3b2d-4e66-96ae-e2c0468ec136", () => ReadLeadData.ResultCount);
			MetaPathParameterValues.Add("02e6f3dc-c3b7-48c5-b1bb-858d7d4b6706", () => ReadLeadData.ResultIntegerFunction);
			MetaPathParameterValues.Add("552d4238-195d-4289-9c82-72b9a2a6cc13", () => ReadLeadData.ResultFloatFunction);
			MetaPathParameterValues.Add("2ee6855b-3c07-41fe-9ed9-dce8afc87598", () => ReadLeadData.ResultDateTimeFunction);
			MetaPathParameterValues.Add("d8c1e15f-029b-46de-8fb1-c9ab4e292106", () => ReadLeadData.ResultRowsCount);
			MetaPathParameterValues.Add("30fc9f29-8bc3-4e4c-8238-8d93757cf810", () => ReadLeadData.CanReadUncommitedData);
			MetaPathParameterValues.Add("2ab23a86-7cff-4fa0-b600-4001d8b72aca", () => ReadLeadData.ResultEntityCollection);
			MetaPathParameterValues.Add("fd8b3b5a-0afb-4d72-b51c-4907de28ec37", () => ReadLeadData.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("6d962028-129a-453e-8ba9-f69a2f78e60c", () => ReadLeadData.IgnoreDisplayValues);
			MetaPathParameterValues.Add("d2014bab-ec05-4880-9e20-25862680d97a", () => ReadLeadData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("12c2859f-0077-4ba5-a75e-9d121e261ff2", () => ReadLeadData.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("ea29a1a7-83b3-4850-9134-d716cf498910", () => ChangeContactAccount.EntitySchemaUId);
			MetaPathParameterValues.Add("2a3f5cb3-7035-42b2-9882-c80f7985168f", () => ChangeContactAccount.IsMatchConditions);
			MetaPathParameterValues.Add("0d8e007f-f368-46a3-840e-c8c133b97854", () => ChangeContactAccount.DataSourceFilters);
			MetaPathParameterValues.Add("c0fe375b-e8e3-406d-b4a8-8783f94f8903", () => ChangeContactAccount.RecordColumnValues);
			MetaPathParameterValues.Add("9e34dc39-7d39-421f-8d27-92a8af9a80c6", () => ChangeLeadStageHandoffToSale.EntitySchemaUId);
			MetaPathParameterValues.Add("bcf5b8fe-4737-4d4e-a037-b2c70a7900e8", () => ChangeLeadStageHandoffToSale.IsMatchConditions);
			MetaPathParameterValues.Add("bb68e8f2-44a8-4731-b948-176e754a5d8b", () => ChangeLeadStageHandoffToSale.DataSourceFilters);
			MetaPathParameterValues.Add("f994ffb6-8edf-41e3-892d-aa56db1c821b", () => ChangeLeadStageHandoffToSale.RecordColumnValues);
			MetaPathParameterValues.Add("6dd0bc3f-edfa-4078-87d0-79fe8307a8ab", () => LinkContactToLead.EntitySchemaUId);
			MetaPathParameterValues.Add("55ac08c6-ba80-4060-81f6-fb82943a2aa6", () => LinkContactToLead.IsMatchConditions);
			MetaPathParameterValues.Add("34908b60-ff49-4067-a7d9-fecfeba3d015", () => LinkContactToLead.DataSourceFilters);
			MetaPathParameterValues.Add("ee931748-590a-41b4-8229-e4dc1c8b23af", () => LinkContactToLead.RecordColumnValues);
			MetaPathParameterValues.Add("7b3e0e2a-6d32-492c-9290-46e7c194da0b", () => LinkAccountToLead.EntitySchemaUId);
			MetaPathParameterValues.Add("fbd3778b-b29e-4da4-878c-479ce66f6695", () => LinkAccountToLead.IsMatchConditions);
			MetaPathParameterValues.Add("e2572aab-9833-4451-bac3-3c93b4938008", () => LinkAccountToLead.DataSourceFilters);
			MetaPathParameterValues.Add("2c5dda1b-35c1-410a-8a66-b8e7dbef353d", () => LinkAccountToLead.RecordColumnValues);
			MetaPathParameterValues.Add("5b47b7b3-1c3a-4e76-8b27-d2d1429d61ee", () => ReadSystemSettings.DataSourceFilters);
			MetaPathParameterValues.Add("055337fb-4c12-4162-baa0-f0a6f82b04f1", () => ReadSystemSettings.ResultType);
			MetaPathParameterValues.Add("61008822-6246-4cb7-94b5-d7ab2c0e761f", () => ReadSystemSettings.ReadSomeTopRecords);
			MetaPathParameterValues.Add("a18bad05-72bd-47e8-8a76-9adc5adb727a", () => ReadSystemSettings.NumberOfRecords);
			MetaPathParameterValues.Add("05ce4b0d-7adf-4370-a4da-9a578ae526a6", () => ReadSystemSettings.FunctionType);
			MetaPathParameterValues.Add("b54c1807-d3db-417d-acc8-5ec641e8f114", () => ReadSystemSettings.AggregationColumnName);
			MetaPathParameterValues.Add("eb5b205e-4427-45cf-8b2f-e5c11ffb5d04", () => ReadSystemSettings.OrderInfo);
			MetaPathParameterValues.Add("411b2f2b-abb2-49c4-b63c-c589bc81bb8c", () => ReadSystemSettings.ResultEntity);
			MetaPathParameterValues.Add("0107e886-cf9e-458c-9fa5-10337b71312c", () => ReadSystemSettings.ResultCount);
			MetaPathParameterValues.Add("c92f52ed-8123-486d-ae9b-c9c0f3e785cf", () => ReadSystemSettings.ResultIntegerFunction);
			MetaPathParameterValues.Add("6c8845de-fd11-481f-ba54-02935c4aeb9d", () => ReadSystemSettings.ResultFloatFunction);
			MetaPathParameterValues.Add("63c46681-2887-41fe-8ea5-3cd9bd9e60fe", () => ReadSystemSettings.ResultDateTimeFunction);
			MetaPathParameterValues.Add("f0232a3c-912e-48ab-9927-5fc33677f7ba", () => ReadSystemSettings.ResultRowsCount);
			MetaPathParameterValues.Add("06e3ef5a-2fa6-49b7-bfa6-3a114e683d05", () => ReadSystemSettings.CanReadUncommitedData);
			MetaPathParameterValues.Add("0a40e220-4683-47e0-a0c2-892934668fc3", () => ReadSystemSettings.ResultEntityCollection);
			MetaPathParameterValues.Add("44d1abb0-802b-49e6-9571-d667de498b3e", () => ReadSystemSettings.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("11fe36aa-20e3-41b3-99f4-0a35fd3628cc", () => ReadSystemSettings.IgnoreDisplayValues);
			MetaPathParameterValues.Add("7b761d52-e117-4dc0-a0c4-c2846c0292bb", () => ReadSystemSettings.ResultCompositeObjectList);
			MetaPathParameterValues.Add("91d86af3-634e-48c9-b566-355568110d9f", () => ReadSystemSettings.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("2585e082-21c1-4b40-97bb-421446d5072b", () => ChangeLeadIsQualificationPassedTrue.EntitySchemaUId);
			MetaPathParameterValues.Add("8e537058-764d-485f-976a-f2c1892e719d", () => ChangeLeadIsQualificationPassedTrue.IsMatchConditions);
			MetaPathParameterValues.Add("7fa0d07d-a96d-43f6-8700-5d9b0a159e1c", () => ChangeLeadIsQualificationPassedTrue.DataSourceFilters);
			MetaPathParameterValues.Add("95da49a7-ccce-4ad9-befc-0d569ae20247", () => ChangeLeadIsQualificationPassedTrue.RecordColumnValues);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "LeadId":
					if (!hasValueToRead) break;
					LeadId = reader.GetValue<System.Guid>();
				break;
				case "AccountId":
					if (!hasValueToRead) break;
					AccountId = reader.GetValue<System.Guid>();
				break;
				case "ContactId":
					if (!hasValueToRead) break;
					ContactId = reader.GetValue<System.Guid>();
				break;
				case "LeadAddressType":
					if (!hasValueToRead) break;
					LeadAddressType = reader.GetValue<System.Guid>();
				break;
				case "LeadCity":
					if (!hasValueToRead) break;
					LeadCity = reader.GetValue<System.Guid>();
				break;
				case "LeadZip":
					if (!hasValueToRead) break;
					LeadZip = reader.GetValue<System.String>();
				break;
				case "LeadRegion":
					if (!hasValueToRead) break;
					LeadRegion = reader.GetValue<System.Guid>();
				break;
				case "LeadCountry":
					if (!hasValueToRead) break;
					LeadCountry = reader.GetValue<System.Guid>();
				break;
				case "LeadWebsite":
					if (!hasValueToRead) break;
					LeadWebsite = reader.GetValue<System.String>();
				break;
				case "LeadFax":
					if (!hasValueToRead) break;
					LeadFax = reader.GetValue<System.String>();
				break;
				case "LeadBusinessPhone":
					if (!hasValueToRead) break;
					LeadBusinessPhone = reader.GetValue<System.String>();
				break;
				case "LeadEmail":
					if (!hasValueToRead) break;
					LeadEmail = reader.GetValue<System.String>();
				break;
				case "LeadMobilePhone":
					if (!hasValueToRead) break;
					LeadMobilePhone = reader.GetValue<System.String>();
				break;
				case "LeadDecisionRole":
					if (!hasValueToRead) break;
					LeadDecisionRole = reader.GetValue<System.Guid>();
				break;
				case "LeadGender":
					if (!hasValueToRead) break;
					LeadGender = reader.GetValue<System.Guid>();
				break;
				case "LeadDepartment":
					if (!hasValueToRead) break;
					LeadDepartment = reader.GetValue<System.Guid>();
				break;
				case "LeadJob":
					if (!hasValueToRead) break;
					LeadJob = reader.GetValue<System.Guid>();
				break;
				case "LeadSalutation":
					if (!hasValueToRead) break;
					LeadSalutation = reader.GetValue<System.Guid>();
				break;
				case "LeadDear":
					if (!hasValueToRead) break;
					LeadDear = reader.GetValue<System.String>();
				break;
				case "LeadFullJobTitle":
					if (!hasValueToRead) break;
					LeadFullJobTitle = reader.GetValue<System.String>();
				break;
				case "LeadContactName":
					if (!hasValueToRead) break;
					LeadContactName = reader.GetValue<System.String>();
				break;
				case "LeadAccountName":
					if (!hasValueToRead) break;
					LeadAccountName = reader.GetValue<System.String>();
				break;
				case "LeadAnnualRevenue":
					if (!hasValueToRead) break;
					LeadAnnualRevenue = reader.GetValue<System.Guid>();
				break;
				case "LeadEmployeesNumber":
					if (!hasValueToRead) break;
					LeadEmployeesNumber = reader.GetValue<System.Guid>();
				break;
				case "LeadAccountCategory":
					if (!hasValueToRead) break;
					LeadAccountCategory = reader.GetValue<System.Guid>();
				break;
				case "LeadIndustry":
					if (!hasValueToRead) break;
					LeadIndustry = reader.GetValue<System.Guid>();
				break;
				case "LeadOwnership":
					if (!hasValueToRead) break;
					LeadOwnership = reader.GetValue<System.Guid>();
				break;
				case "LeadAccountId":
					if (!hasValueToRead) break;
					LeadAccountId = reader.GetValue<System.Guid>();
				break;
				case "LeadContactId":
					if (!hasValueToRead) break;
					LeadContactId = reader.GetValue<System.Guid>();
				break;
				case "LeadAddress":
					if (!hasValueToRead) break;
					LeadAddress = reader.GetValue<System.String>();
				break;
				case "CreateAccountOnQualification":
					if (!hasValueToRead) break;
					CreateAccountOnQualification = reader.GetValue<System.Boolean>();
				break;
				case "LeadQualificationPassed":
					if (!hasValueToRead) break;
					LeadQualificationPassed = reader.GetValue<System.Boolean>();
				break;
				case "LeadOwner":
					if (!hasValueToRead) break;
					LeadOwner = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool ChangeAccountScriptTaskExecute(ProcessExecutingContext context) {
			ProcessAccount();
			return true;
		}

		public virtual bool ChangeContactScriptTaskExecute(ProcessExecutingContext context) {
			ProcessContact();
			return true;
		}

			
			public virtual void ProcessAccount() {
				Guid accountId = LeadAccountId;
				bool createAccount = CreateAccountOnQualification;
				var account = new Terrasoft.Configuration.Account(UserConnection);
				bool accountExists = false;
				if (accountId.IsEmpty()) {
					accountId = Guid.NewGuid();
				} else {
					accountExists = account.FetchFromDB(accountId);
				}
				if (!accountExists) {
					if (createAccount) {
						LeadAccountId = accountId;
						account.Id = accountId;
						account.SetDefColumnValues();
					} else {
						return;
					}
				}
				if (!string.IsNullOrEmpty(LeadAccountName)) {
					account.Name = LeadAccountName;
				}
				if (string.IsNullOrEmpty(account.Name)) {
					return;
				}
				SetValue(account, "OwnershipId", LeadOwnership);
				SetValue(account, "OwnerId", LeadOwner);
				SetValue(account, "IndustryId", LeadIndustry);
				SetValue(account, "AccountCategoryId", LeadAccountCategory);
				SetValue(account, "EmployeesNumberId", LeadEmployeesNumber);
				SetValue(account, "AnnualRevenueId", LeadAnnualRevenue);
				account.UseAdminRights = false;
				account.Save(false);
				SyncAccountCommunications(account.Id);
				AccountId = accountId;
				AddAccountAddress(accountId);
			}
			
			
			public virtual void SetValue(Entity entity, string valueName, Object value) {
				if (value == null || Guid.Empty.Equals(value) || string.IsNullOrEmpty(value.ToString())) {
					return;
				}
				entity.SetColumnValue(valueName, value);
			}
			
			
			public virtual void ProcessContact() {
				Guid contactId = LeadContactId;
				var contact = new Terrasoft.Configuration.Contact(UserConnection);
				string contactName = LeadContactName;
				if (contactId.IsEmpty()) {
					if (!string.IsNullOrEmpty(contactName)) {
						contactId = Guid.NewGuid();
						contact.SetDefColumnValues();
						contact.Id = contactId;
					} else {
						return;
					}
				} else if (!contact.FetchFromDB(contactId)) {
					return;
				}
				if (!string.IsNullOrEmpty(contactName)) {
					contact.Name = contactName;
				}
				ContactId = contactId;
				SetValue(contact, "Dear", LeadDear);
				SetValue(contact, "OwnerId", LeadOwner);
				SetValue(contact, "JobTitle", LeadFullJobTitle);
				SetValue(contact, "SalutationTypeId", LeadSalutation);
				SetValue(contact, "JobId", LeadJob);
				SetValue(contact, "DepartmentId", LeadDepartment);
				SetValue(contact, "GenderId", LeadGender);
				SetValue(contact, "DecisionRoleId", LeadDecisionRole);
				contact.Confirmed = true;
				contact.UseAdminRights = false;
				contact.Save(false);
				SyncContactCommunications(contact.Id);
				AddContacAddress(contact.Id);
			}
			
			
			public virtual void SyncContactCommunications(Guid contactId) {
				Dictionary<Guid, string> leadCommunications = new Dictionary<Guid, string>();
				if (!string.IsNullOrEmpty(LeadBusinessPhone)) {
					leadCommunications[new Guid(CommunicationTypeConsts.WorkPhoneId)] = LeadBusinessPhone;
				}
				if (!string.IsNullOrEmpty(LeadMobilePhone)) {
					leadCommunications[new Guid(CommunicationTypeConsts.MobilePhoneId)] = LeadMobilePhone;
				}
				if (!string.IsNullOrEmpty(LeadEmail)) {
					leadCommunications[new Guid(CommunicationTypeConsts.EmailId)] = LeadEmail;
				}
				Select existingNumbers = new Select(UserConnection)
					.Column("Number")
					.From("ContactCommunication")
					.Where("ContactId").IsEqual(Column.Parameter(contactId)) as Select;
				List<string> contactCommuniations = new List<string>();
				using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
					using (IDataReader reader = existingNumbers.ExecuteReader(dbExecutor)){
						while (reader.Read()) {
							contactCommuniations.Add(reader.GetString(0).ToLower());
						}
					}
				}
				List<KeyValuePair<Guid, string>> communicationsToSync = 
					leadCommunications.Where(n => !contactCommuniations.Contains(n.Value.ToLower())).ToList();
				foreach (KeyValuePair<Guid, string> communication in communicationsToSync) {
					var contactCommunication = new ContactCommunication(UserConnection);
					contactCommunication.SetDefColumnValues();
					contactCommunication.Number = communication.Value;
					contactCommunication.CommunicationTypeId = communication.Key;
					contactCommunication.ContactId = contactId;
					contactCommunication.Save(false);
				}
			}
			
			
			public virtual void SyncAccountCommunications(Guid accountId) {
				Dictionary<Guid, string> leadCommunications = new Dictionary<Guid, string>();
				if (!string.IsNullOrEmpty(LeadBusinessPhone)) {
					leadCommunications[new Guid(CommunicationTypeConsts.MainPhoneId)] = LeadBusinessPhone;
				}
				if (!string.IsNullOrEmpty(LeadFax)) {
					leadCommunications[new Guid(CommunicationTypeConsts.FaxId)] = LeadFax;
				}
				if (!string.IsNullOrEmpty(LeadWebsite)) {
					leadCommunications[new Guid(CommunicationTypeConsts.WebId)] = LeadWebsite;
				}
				Select existingNumbers = new Select(UserConnection)
					.Column("Number")
					.From("AccountCommunication")
					.Where("AccountId").IsEqual(Column.Parameter(accountId)) as Select;
				List<string> contactCommuniations = new List<string>();
				using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
					using (IDataReader reader = existingNumbers.ExecuteReader(dbExecutor)){
						while (reader.Read()) {
							contactCommuniations.Add(reader.GetString(0).ToLower());
						}
					}
				}
				List<KeyValuePair<Guid, string>> communicationsToSync = 
					leadCommunications.Where(n => !contactCommuniations.Contains(n.Value.ToLower())).ToList();
				foreach (KeyValuePair<Guid, string> communication in communicationsToSync) {
					var accountCommunication = new AccountCommunication(UserConnection);
					accountCommunication.SetDefColumnValues();
					accountCommunication.Number = communication.Value;
					accountCommunication.CommunicationTypeId = communication.Key;
					accountCommunication.AccountId = accountId;
					accountCommunication.Save(false);
				}
			}
			
			
			public virtual void AddContacAddress(Guid contactId) {
				if (LeadAddressType.IsEmpty() && 
						LeadCity.IsEmpty() && 
						LeadRegion.IsEmpty() && 
						LeadCountry.IsEmpty() && 
						String.IsNullOrEmpty(LeadZip) && 
						String.IsNullOrEmpty(LeadAddress)) {
					return;
				}
				//Check is address already exists
				if (IsAddressExists(
						"ContactAddress", 
						"ContactId", 
						contactId, 
						LeadAddressType, 
						LeadCity, 
						LeadRegion, 
						LeadCountry, 
						LeadZip, 
						LeadAddress)) {
					return;
				}
				//Create contact address from Lead
				var contactAddress = new ContactAddress(UserConnection);
				contactAddress.SetDefColumnValues();
				SetValue(contactAddress, "AddressTypeId", LeadAddressType);
				SetValue(contactAddress, "CityId", LeadCity);
				SetValue(contactAddress, "RegionId", LeadRegion);
				SetValue(contactAddress, "CountryId", LeadCountry);
				SetValue(contactAddress, "Zip", LeadZip);
				SetValue(contactAddress, "Address", LeadAddress);
				contactAddress.ContactId = contactId;
				contactAddress.Save(false);
			}
			
			
			public virtual void AddAccountAddress(Guid accountId) {
				if (LeadAddressType.IsEmpty() && 
						LeadCity.IsEmpty() && 
						LeadRegion.IsEmpty() && 
						LeadCountry.IsEmpty() && 
						String.IsNullOrEmpty(LeadZip) && 
						String.IsNullOrEmpty(LeadAddress)) {
					return;
				}
				//Check is address already exists
				if (IsAddressExists(
						"AccountAddress", 
						"AccountId", 
						accountId, 
						LeadAddressType, 
						LeadCity, 
						LeadRegion, 
						LeadCountry, 
						LeadZip, 
						LeadAddress)) {
					return;
				}
				//Create account address from Lead
				var accountAddress = new AccountAddress(UserConnection);
				accountAddress.SetDefColumnValues();
				SetValue(accountAddress, "AddressTypeId", LeadAddressType);
				SetValue(accountAddress, "CityId", LeadCity);
				SetValue(accountAddress, "RegionId", LeadRegion);
				SetValue(accountAddress, "CountryId", LeadCountry);
				SetValue(accountAddress, "Zip", LeadZip);
				SetValue(accountAddress, "Address", LeadAddress);
				accountAddress.AccountId = accountId;
				accountAddress.Save(false);
			}
			
			
			public virtual bool IsAddressExists(string addressTableName, string relationColumnName, Guid relationColumnValue, Guid addressType, Guid addressCity, Guid addressRegion, Guid addressCountry, string zipValue, string addressValue) {
				var addressSelect = new Select(UserConnection)
					.Column("Zip")
					.Column("Address")
					.From(addressTableName)
					.Where(relationColumnName).IsEqual(Column.Parameter(relationColumnValue)) as Select;
				
				if (!addressType.IsEmpty()) {
					addressSelect.And("AddressTypeId").IsEqual(Column.Parameter(addressType));
				}
				if (!addressCity.IsEmpty()) {
					addressSelect.And("CityId").IsEqual(Column.Parameter(addressCity));
				}
				if (!addressRegion.IsEmpty()) {
					addressSelect.And("RegionId").IsEqual(Column.Parameter(addressRegion));
				}
				if (!addressCountry.IsEmpty()) {
					addressSelect.And("CountryId").IsEqual(Column.Parameter(addressCountry));
				}
				bool compareZip = false;
				if (!String.IsNullOrEmpty(zipValue)) {
					zipValue = zipValue.ToLower().Trim();
					if (!String.IsNullOrEmpty(zipValue)) {
						compareZip = true;
					}
				}
				bool compareAddress = false;
				if (!String.IsNullOrEmpty(addressValue)) {
					addressValue = addressValue.ToLower().Trim();
					if (!String.IsNullOrEmpty(addressValue)) {
						compareAddress = true;
					}
				}
				using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
					using (IDataReader reader = addressSelect.ExecuteReader(dbExecutor)) {
						//Test each address.
						while (reader.Read()) {
							string zip = reader.GetString(0).ToLower().Trim();
							string address = reader.GetString(1).ToLower().Trim();
							bool zipMatch = false;
							bool addressMatch = false;
							//Quit when address is math
							if (compareZip && StringUtilities.EqualsIgnoreCase(zip, zipValue)) {
								zipMatch = true;
							}
							zipMatch = zipMatch == compareZip;
							if (compareAddress && StringUtilities.EqualsIgnoreCase(address, addressValue)) {
								addressMatch = true;
							}
							addressMatch = addressMatch == compareAddress;
							if (zipMatch && addressMatch) {
								return true;
							}
						}
					}
				}
				return false;
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
			var cloneItem = (LeadManagementQualification78)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

