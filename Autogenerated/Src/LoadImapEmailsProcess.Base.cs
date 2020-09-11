namespace Terrasoft.Core.Process
{

	using IntegrationApi.Interfaces;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
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
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Mail;

	#region Class: LoadImapEmailsProcessSchema

	/// <exclude/>
	public class LoadImapEmailsProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LoadImapEmailsProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LoadImapEmailsProcessSchema(LoadImapEmailsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LoadImapEmailsProcess";
			UId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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
			SerializeToDB = false;
			SerializeToMemory = true;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,89,89,111,219,56,16,126,118,129,254,7,173,158,164,194,86,156,196,185,144,3,136,29,187,245,110,143,180,78,54,207,180,68,39,194,202,146,75,82,73,188,139,252,247,157,33,41,235,162,28,181,88,236,2,219,2,181,36,14,191,25,206,241,113,200,190,125,179,74,231,81,232,91,143,33,19,41,137,172,233,56,78,151,148,145,121,68,207,222,167,97,112,97,189,167,98,148,50,70,99,113,203,41,251,68,194,104,158,60,207,214,177,255,192,146,56,252,147,136,48,137,103,84,136,48,190,231,183,211,128,59,174,245,215,219,55,157,71,194,172,229,86,225,113,44,66,177,158,249,15,116,73,172,115,11,209,71,73,28,83,31,133,188,226,232,39,18,147,123,202,60,48,101,26,115,65,98,159,14,215,159,201,146,58,118,193,158,12,215,118,79,181,126,90,192,248,154,82,182,6,53,49,125,178,198,213,239,206,235,202,187,86,123,93,163,36,74,151,49,40,171,25,224,93,6,129,26,117,218,59,7,215,125,205,194,37,97,107,53,87,46,221,149,170,235,26,38,97,36,40,227,168,201,1,1,131,196,136,81,34,168,146,187,11,197,195,53,97,0,136,147,28,245,113,148,44,87,132,133,60,137,111,214,43,234,141,191,67,102,116,45,4,235,216,179,53,191,12,150,97,124,27,135,194,238,86,163,86,200,20,111,26,252,71,38,98,156,102,148,61,130,13,56,8,86,98,208,49,155,29,251,120,48,152,244,143,247,143,122,227,203,203,126,111,48,25,244,123,195,147,195,131,222,209,238,228,224,106,120,50,190,28,31,142,109,215,221,132,245,59,154,243,141,242,52,18,220,24,80,136,141,138,21,132,38,82,94,168,100,147,196,98,84,164,44,182,22,44,89,90,76,194,89,97,92,70,231,20,231,235,81,196,69,227,117,182,252,78,162,84,23,164,83,207,52,15,19,2,213,188,188,125,131,127,43,53,141,254,0,135,6,56,145,68,28,43,58,119,81,97,192,65,124,89,180,106,8,170,57,175,101,109,180,42,160,10,162,35,151,24,46,44,167,52,217,250,229,92,122,221,27,47,87,98,173,160,106,181,162,203,171,78,0,96,101,73,194,177,13,85,105,187,22,225,150,97,224,52,211,149,91,84,225,27,131,17,77,4,163,230,171,90,223,2,90,171,81,208,98,150,108,168,232,31,193,111,198,86,227,28,117,232,69,180,52,55,215,239,171,50,206,215,174,227,126,67,25,35,60,89,8,80,18,47,194,251,148,73,210,242,114,65,83,238,43,200,141,26,126,147,76,168,240,31,52,230,199,144,139,51,46,24,176,222,133,74,145,142,13,196,0,249,198,237,174,122,189,78,152,200,158,1,127,54,251,152,189,77,249,76,16,38,110,34,110,227,135,151,138,58,147,170,113,173,124,46,180,231,23,9,176,14,8,59,101,123,177,80,235,214,235,116,238,148,21,73,74,107,29,151,28,85,17,78,231,5,255,193,58,170,5,192,147,240,19,160,143,171,97,155,120,118,203,117,220,173,56,196,205,204,215,108,243,33,225,88,219,117,181,58,18,167,69,97,12,135,81,24,7,74,146,24,44,30,25,101,85,28,75,210,89,40,141,242,121,164,55,158,122,201,121,85,33,52,50,224,111,116,45,25,244,154,132,236,204,176,141,119,171,140,118,81,38,73,153,212,38,162,220,218,10,85,201,115,123,239,84,160,214,138,117,166,154,42,163,22,108,107,65,208,91,141,54,146,54,206,108,179,134,90,150,110,247,79,57,9,171,219,212,121,243,70,213,202,150,124,42,168,58,109,86,132,169,200,52,93,183,2,206,228,95,195,188,38,156,63,37,44,248,17,220,108,206,54,236,25,141,3,40,125,244,175,46,207,182,26,234,51,75,197,84,219,231,127,162,110,16,175,85,124,186,230,252,45,118,75,213,170,222,121,87,169,235,199,4,234,240,154,81,104,5,233,118,109,215,176,191,127,89,209,24,158,29,252,197,119,244,247,13,225,127,88,73,229,67,219,19,140,156,51,13,180,179,84,131,185,240,233,241,241,225,128,246,142,230,253,221,222,96,239,132,246,78,246,118,105,175,127,112,184,239,31,237,29,4,240,155,159,26,182,227,191,103,97,96,210,225,31,251,116,119,159,244,123,251,199,251,135,189,193,156,28,245,230,251,199,39,240,116,66,247,250,187,131,254,238,190,175,116,84,87,230,225,75,222,76,107,212,171,80,18,11,108,30,122,35,238,90,122,67,118,54,150,174,178,137,56,233,53,88,232,201,154,49,51,42,194,128,13,147,231,73,18,5,88,162,214,121,137,120,36,51,24,245,40,111,180,246,156,204,240,220,122,185,67,219,41,71,149,175,157,95,188,155,100,38,109,214,135,173,23,139,70,156,202,228,176,126,222,182,109,118,49,234,67,241,75,203,52,249,1,206,52,168,250,202,173,89,102,138,53,230,57,72,235,134,86,90,150,189,104,253,181,41,240,160,93,112,9,14,121,164,56,8,211,4,75,145,237,94,222,237,52,20,98,222,24,222,78,189,59,58,7,151,10,150,0,87,109,30,62,1,217,200,197,198,52,210,107,147,170,139,223,203,87,7,177,86,14,39,78,65,151,136,234,125,16,98,133,136,244,89,100,161,242,62,144,56,136,160,67,133,156,107,180,2,145,54,37,87,80,168,5,64,201,214,169,112,96,141,3,253,101,184,30,69,33,232,157,202,62,79,218,216,181,236,33,225,165,149,64,252,208,103,174,73,41,38,136,193,134,109,246,27,189,88,32,202,101,249,243,38,78,38,186,156,61,36,79,227,32,20,89,58,106,72,237,251,157,29,131,185,141,225,58,173,206,0,97,85,229,222,36,97,75,34,156,207,148,6,51,218,176,21,104,176,174,245,58,119,223,22,171,209,30,218,174,214,93,180,20,75,40,91,77,27,189,101,204,207,182,219,133,250,88,72,187,65,104,68,86,248,211,205,150,38,21,58,78,129,215,144,173,54,172,230,106,80,238,202,74,174,20,108,215,106,99,80,165,170,205,189,172,12,226,85,242,20,71,9,9,228,86,206,177,225,210,10,75,173,105,177,5,229,213,38,170,218,95,85,123,220,28,195,147,61,64,70,219,245,99,250,148,79,40,129,60,164,227,24,239,13,129,198,164,89,83,168,211,123,117,64,252,125,207,118,11,231,127,46,91,8,206,97,4,172,24,69,208,243,76,136,47,18,117,157,114,54,157,229,227,23,26,76,95,226,128,98,240,119,138,178,151,236,62,93,130,177,64,230,126,141,200,93,117,62,108,156,194,107,141,16,64,212,92,100,232,151,244,65,173,176,2,117,108,209,71,72,85,143,25,35,11,182,86,139,78,57,4,85,157,43,225,140,182,154,189,178,254,105,89,230,66,94,146,53,47,191,180,242,6,87,52,206,246,243,229,154,92,240,202,236,40,185,15,227,140,236,54,253,124,101,141,30,62,227,154,48,217,180,163,58,89,185,140,146,52,198,118,179,58,231,27,93,38,130,142,30,72,156,9,229,173,170,229,19,60,212,59,136,57,126,246,169,44,84,139,130,250,14,202,252,56,135,233,41,79,132,97,131,168,43,95,55,71,95,83,202,241,53,219,35,171,167,49,239,174,52,75,195,53,241,82,89,69,215,162,94,78,130,234,65,222,103,106,76,101,92,107,210,217,148,108,1,215,208,41,152,121,69,18,71,169,233,144,95,22,89,203,81,96,146,72,187,102,38,111,44,171,14,65,147,245,101,135,249,126,30,246,75,232,112,148,28,82,87,195,45,190,28,255,72,23,226,75,10,77,229,175,73,8,112,178,43,9,197,90,241,170,237,122,95,234,31,1,30,79,103,10,160,227,77,185,188,28,110,52,69,127,206,167,120,119,15,148,81,19,44,90,189,193,211,87,175,155,174,215,217,120,74,222,73,42,223,160,199,11,197,31,204,199,207,212,79,161,132,76,255,225,193,129,66,175,134,249,39,71,23,148,5,127,244,70,15,190,247,20,4,157,249,36,34,76,223,9,231,192,219,131,172,242,166,16,230,58,195,57,255,108,164,235,10,254,127,145,175,118,231,255,106,2,100,39,181,134,20,248,27,65,193,2,135,226,27,0,0 };
			RealUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435");
			Version = 0;
			PackageUId = new Guid("5be3998b-c5c3-42bb-a01c-2e4149059a97");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreatePageInstanceIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4fe53caa-18f6-4c4b-b63b-d475fe7b8a0f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"PageInstanceId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateActiveTreeGridCurrentRowIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b9ae9fb7-09a7-4689-89fe-c1c439f10368"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"ActiveTreeGridCurrentRowId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentUserMailboxSynchronizationSettingsUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ff591096-1b06-47b0-a988-cbd658b46fef"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"CurrentUserMailboxSynchronizationSettingsUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMailboxSynchronizationSettingsPageUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("be94aa4b-5b04-442f-88b6-6841d5c40218"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"MailboxSynchronizationSettingsPageUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"fce8864e-7b01-429e-921e-0563c725d563",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedSetMailboxSynchronizationMessageUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9891be68-d59b-4533-9be3-85e194af599f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"NeedSetMailboxSynchronizationMessageUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"{E9D59B5B-D6D0-47D6-9F8E-C475806C019C}",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateMailBoxFolderIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3be2837e-0163-4330-836b-ffca8a2909be"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"MailBoxFolderId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLoadResultParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("532cb61b-8379-42bc-9a48-99fd98f7801b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"LoadResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMessagesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("574326c8-1b08-4af9-9e49-7da640ea2c9e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"Messages",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMessagesCountParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("562516d4-4d62-4421-b65f-3924fb92a101"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"MessagesCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSenderEmailAddressParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9df9ed0b-1c24-40f3-94dc-f7cfa995d7db"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"SenderEmailAddress",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedSetMailboxSynchronizationMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("21444bbc-5fee-4669-9cb3-26a7af386911"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"NeedSetMailboxSynchronizationMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateInformationCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c7cc5b5d-0efd-428c-80d5-c6feea55dec6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"InformationCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateSuccessLoadEmailsMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e255669d-4628-4d24-b91e-f4e34a99cc0a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"SuccessLoadEmailsMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreatePageInstanceIdParameter());
			Parameters.Add(CreateActiveTreeGridCurrentRowIdParameter());
			Parameters.Add(CreateCurrentUserMailboxSynchronizationSettingsUIdParameter());
			Parameters.Add(CreateMailboxSynchronizationSettingsPageUIdParameter());
			Parameters.Add(CreateNeedSetMailboxSynchronizationMessageUIdParameter());
			Parameters.Add(CreateMailBoxFolderIdParameter());
			Parameters.Add(CreateLoadResultParameter());
			Parameters.Add(CreateMessagesParameter());
			Parameters.Add(CreateMessagesCountParameter());
			Parameters.Add(CreateSenderEmailAddressParameter());
			Parameters.Add(CreateNeedSetMailboxSynchronizationMessageParameter());
			Parameters.Add(CreateInformationCaptionParameter());
			Parameters.Add(CreateSuccessLoadEmailsMessageParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLoadImapEmailsUserTaskLaneSet = CreateLoadImapEmailsUserTaskLaneSetLaneSet();
			LaneSets.Add(schemaLoadImapEmailsUserTaskLaneSet);
			ProcessSchemaLane schemaLoadImapEmailsUserTaskLane = CreateLoadImapEmailsUserTaskLaneLane();
			schemaLoadImapEmailsUserTaskLaneSet.Lanes.Add(schemaLoadImapEmailsUserTaskLane);
			ProcessSchemaStartEvent loadimapemailsusertaskstart = CreateLoadImapEmailsUserTaskStartStartEvent();
			FlowElements.Add(loadimapemailsusertaskstart);
			ProcessSchemaEndEvent loadimapemailsusertaskend = CreateLoadImapEmailsUserTaskEndEndEvent();
			FlowElements.Add(loadimapemailsusertaskend);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			FlowElements.Add(scripttask1);
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("336acfd9-6be3-4f8e-9ee0-842af3c10118"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				CurveCenterPosition = new Point(374, 210),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fb4cf670-1ecc-4fbe-ad34-44ab952d9f62"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9ddd22ce-1f21-454f-8dff-aa6510f4434e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("4fcbcae3-6713-47fc-ade0-561c841d572b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				CurveCenterPosition = new Point(440, 212),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9ddd22ce-1f21-454f-8dff-aa6510f4434e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("279c7f52-7577-4bf9-a283-8d6621415e69"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLoadImapEmailsUserTaskLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaLoadImapEmailsUserTaskLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("21cd00c5-c917-4b96-a25b-d555ef360329"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"LoadImapEmailsUserTaskLaneSet",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLoadImapEmailsUserTaskLaneSet;
		}

		protected virtual ProcessSchemaLane CreateLoadImapEmailsUserTaskLaneLane() {
			ProcessSchemaLane schemaLoadImapEmailsUserTaskLane = new ProcessSchemaLane(this) {
				UId = new Guid("a105506e-8d97-4c59-8fb8-a2e5b037ce28"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("21cd00c5-c917-4b96-a25b-d555ef360329"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"LoadImapEmailsUserTaskLane",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLoadImapEmailsUserTaskLane;
		}

		protected virtual ProcessSchemaStartEvent CreateLoadImapEmailsUserTaskStartStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("fb4cf670-1ecc-4fbe-ad34-44ab952d9f62"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a105506e-8d97-4c59-8fb8-a2e5b037ce28"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"LoadImapEmailsUserTaskStart",
				Position = new Point(50, 191),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaEndEvent CreateLoadImapEmailsUserTaskEndEndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("279c7f52-7577-4bf9-a283-8d6621415e69"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a105506e-8d97-4c59-8fb8-a2e5b037ce28"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"LoadImapEmailsUserTaskEnd",
				Position = new Point(547, 191),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9ddd22ce-1f21-454f-8dff-aa6510f4434e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a105506e-8d97-4c59-8fb8-a2e5b037ce28"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"ScriptTask1",
				Position = new Point(267, 177),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,147,81,79,219,48,20,133,159,139,196,127,184,228,1,37,162,137,18,141,78,176,173,147,70,147,162,10,10,18,21,123,89,247,224,53,151,214,82,98,79,182,67,233,170,252,119,236,216,77,186,138,141,183,216,185,247,220,239,156,220,76,81,74,178,68,9,67,96,184,134,148,46,20,229,140,136,205,151,235,138,230,125,144,74,80,182,252,234,7,159,143,143,158,137,0,193,185,202,74,66,139,49,47,114,20,147,220,53,154,106,223,75,46,146,241,101,250,225,60,28,164,89,22,102,113,146,132,223,46,62,94,133,113,156,12,6,105,124,62,138,147,212,51,82,244,9,252,169,86,185,226,47,157,208,176,81,137,178,242,183,218,4,176,61,62,234,205,86,124,157,229,84,205,80,41,141,33,167,150,182,161,233,9,84,149,96,160,68,133,250,88,91,209,55,248,134,112,48,201,106,27,55,52,55,198,175,81,141,42,33,144,169,71,137,194,20,255,226,47,179,13,91,172,4,103,244,15,49,137,236,8,30,39,185,180,227,205,52,221,31,141,120,197,148,31,152,57,177,85,254,63,182,6,237,61,113,129,100,177,242,45,3,80,102,72,92,115,202,215,172,224,36,111,92,200,177,224,165,195,215,211,172,0,104,183,128,133,196,214,71,105,153,155,175,161,221,76,119,199,195,140,91,240,174,225,100,63,117,56,61,133,191,94,177,170,40,222,229,106,59,28,94,139,246,110,16,181,93,170,178,91,66,187,111,150,70,23,237,7,229,170,76,90,254,191,246,52,112,19,92,152,173,240,89,171,60,230,162,36,202,247,182,219,185,71,243,185,247,9,230,222,54,174,231,94,95,63,184,122,119,155,232,219,186,238,235,55,238,62,186,193,77,119,248,78,138,10,131,110,245,78,220,132,137,188,211,169,221,139,198,131,191,67,8,14,136,134,173,235,232,1,75,254,140,109,101,116,139,108,169,86,16,66,226,212,111,117,236,15,40,171,66,193,27,62,52,234,206,181,1,255,161,221,252,132,186,238,176,165,145,217,255,91,94,1,75,100,250,205,245,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("276b5906-88fa-4d43-a6ea-8d6213245d72"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3e068d19-8d8c-4768-b6a9-83bd4995c9bc"),
				Name = "Terrasoft.Mail",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b6da2fd2-6cc9-4667-ab57-4f614f3fc9ca"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ef7eb62b-f609-42c2-af07-585c5670410d"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a973b80b-c06f-4f64-b532-26268ad871c3"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("997719b8-45ce-4814-939a-6ff72a85e213"),
				Name = "IntegrationApi.Interfaces",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LoadImapEmailsProcess(userConnection);
		}

		public override object Clone() {
			return new LoadImapEmailsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"));
		}

		#endregion

	}

	#endregion

	#region Class: LoadImapEmailsProcess

	/// <exclude/>
	public class LoadImapEmailsProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLoadImapEmailsUserTaskLane

		/// <exclude/>
		public class ProcessLoadImapEmailsUserTaskLane : ProcessLane
		{

			public ProcessLoadImapEmailsUserTaskLane(UserConnection userConnection, LoadImapEmailsProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public LoadImapEmailsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LoadImapEmailsProcess";
			SchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2f9740b2-eaba-4296-af86-64b5692d7435");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: LoadImapEmailsProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: LoadImapEmailsProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual string PageInstanceId {
			get;
			set;
		}

		public virtual Guid ActiveTreeGridCurrentRowId {
			get;
			set;
		}

		public virtual Guid CurrentUserMailboxSynchronizationSettingsUId {
			get;
			set;
		}

		private Guid _mailboxSynchronizationSettingsPageUId = new Guid("fce8864e-7b01-429e-921e-0563c725d563");
		public Guid MailboxSynchronizationSettingsPageUId {
			get {
				return _mailboxSynchronizationSettingsPageUId;
			}
			set {
				_mailboxSynchronizationSettingsPageUId = value;
			}
		}

		private Guid _needSetMailboxSynchronizationMessageUId = new Guid("{E9D59B5B-D6D0-47D6-9F8E-C475806C019C}");
		public Guid NeedSetMailboxSynchronizationMessageUId {
			get {
				return _needSetMailboxSynchronizationMessageUId;
			}
			set {
				_needSetMailboxSynchronizationMessageUId = value;
			}
		}

		public virtual Guid MailBoxFolderId {
			get;
			set;
		}

		public virtual string LoadResult {
			get;
			set;
		}

		public virtual Object Messages {
			get;
			set;
		}

		public virtual int MessagesCount {
			get;
			set;
		}

		public virtual string SenderEmailAddress {
			get;
			set;
		}

		private LocalizableString _needSetMailboxSynchronizationMessage;
		public virtual LocalizableString NeedSetMailboxSynchronizationMessage {
			get {
				return _needSetMailboxSynchronizationMessage ?? (_needSetMailboxSynchronizationMessage = GetLocalizableString("2f9740b2eaba4296af8664b5692d7435",
						 "Parameters.NeedSetMailboxSynchronizationMessage.Value"));
			}
			set {
				_needSetMailboxSynchronizationMessage = value;
			}
		}

		private LocalizableString _informationCaption;
		public virtual LocalizableString InformationCaption {
			get {
				return _informationCaption ?? (_informationCaption = GetLocalizableString("2f9740b2eaba4296af8664b5692d7435",
						 "Parameters.InformationCaption.Value"));
			}
			set {
				_informationCaption = value;
			}
		}

		private LocalizableString _successLoadEmailsMessage;
		public virtual LocalizableString SuccessLoadEmailsMessage {
			get {
				return _successLoadEmailsMessage ?? (_successLoadEmailsMessage = GetLocalizableString("2f9740b2eaba4296af8664b5692d7435",
						 "Parameters.SuccessLoadEmailsMessage.Value"));
			}
			set {
				_successLoadEmailsMessage = value;
			}
		}

		private ProcessLoadImapEmailsUserTaskLane _loadImapEmailsUserTaskLane;
		public ProcessLoadImapEmailsUserTaskLane LoadImapEmailsUserTaskLane {
			get {
				return _loadImapEmailsUserTaskLane ?? ((_loadImapEmailsUserTaskLane) = new ProcessLoadImapEmailsUserTaskLane(UserConnection, this));
			}
		}

		private ProcessFlowElement _loadImapEmailsUserTaskStart;
		public ProcessFlowElement LoadImapEmailsUserTaskStart {
			get {
				return _loadImapEmailsUserTaskStart ?? (_loadImapEmailsUserTaskStart = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "LoadImapEmailsUserTaskStart",
					SchemaElementUId = new Guid("fb4cf670-1ecc-4fbe-ad34-44ab952d9f62"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessEndEvent _loadImapEmailsUserTaskEnd;
		public ProcessEndEvent LoadImapEmailsUserTaskEnd {
			get {
				return _loadImapEmailsUserTaskEnd ?? (_loadImapEmailsUserTaskEnd = new ProcessEndEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEndEvent",
					Name = "LoadImapEmailsUserTaskEnd",
					SchemaElementUId = new Guid("279c7f52-7577-4bf9-a283-8d6621415e69"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
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
					SchemaElementUId = new Guid("9ddd22ce-1f21-454f-8dff-aa6510f4434e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ScriptTask1Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[LoadImapEmailsUserTaskStart.SchemaElementUId] = new Collection<ProcessFlowElement> { LoadImapEmailsUserTaskStart };
			FlowElements[LoadImapEmailsUserTaskEnd.SchemaElementUId] = new Collection<ProcessFlowElement> { LoadImapEmailsUserTaskEnd };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "LoadImapEmailsUserTaskStart":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask1", e.Context.SenderName));
						break;
					case "LoadImapEmailsUserTaskEnd":
						CompleteProcess();
						break;
					case "ScriptTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LoadImapEmailsUserTaskEnd", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("PageInstanceId")) {
				writer.WriteValue("PageInstanceId", PageInstanceId, null);
			}
			if (!HasMapping("ActiveTreeGridCurrentRowId")) {
				writer.WriteValue("ActiveTreeGridCurrentRowId", ActiveTreeGridCurrentRowId, Guid.Empty);
			}
			if (!HasMapping("CurrentUserMailboxSynchronizationSettingsUId")) {
				writer.WriteValue("CurrentUserMailboxSynchronizationSettingsUId", CurrentUserMailboxSynchronizationSettingsUId, Guid.Empty);
			}
			if (!HasMapping("MailboxSynchronizationSettingsPageUId")) {
				writer.WriteValue("MailboxSynchronizationSettingsPageUId", MailboxSynchronizationSettingsPageUId, Guid.Empty);
			}
			if (!HasMapping("NeedSetMailboxSynchronizationMessageUId")) {
				writer.WriteValue("NeedSetMailboxSynchronizationMessageUId", NeedSetMailboxSynchronizationMessageUId, Guid.Empty);
			}
			if (!HasMapping("MailBoxFolderId")) {
				writer.WriteValue("MailBoxFolderId", MailBoxFolderId, Guid.Empty);
			}
			if (!HasMapping("LoadResult")) {
				writer.WriteValue("LoadResult", LoadResult, null);
			}
			if (Messages != null) {
				if (Messages.GetType().IsSerializable ||
					Messages.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("Messages", Messages, null);
				}
			}
			if (!HasMapping("MessagesCount")) {
				writer.WriteValue("MessagesCount", MessagesCount, 0);
			}
			if (!HasMapping("SenderEmailAddress")) {
				writer.WriteValue("SenderEmailAddress", SenderEmailAddress, null);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("LoadImapEmailsUserTaskStart", string.Empty));
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
			MetaPathParameterValues.Add("4fe53caa-18f6-4c4b-b63b-d475fe7b8a0f", () => PageInstanceId);
			MetaPathParameterValues.Add("b9ae9fb7-09a7-4689-89fe-c1c439f10368", () => ActiveTreeGridCurrentRowId);
			MetaPathParameterValues.Add("ff591096-1b06-47b0-a988-cbd658b46fef", () => CurrentUserMailboxSynchronizationSettingsUId);
			MetaPathParameterValues.Add("be94aa4b-5b04-442f-88b6-6841d5c40218", () => MailboxSynchronizationSettingsPageUId);
			MetaPathParameterValues.Add("9891be68-d59b-4533-9be3-85e194af599f", () => NeedSetMailboxSynchronizationMessageUId);
			MetaPathParameterValues.Add("3be2837e-0163-4330-836b-ffca8a2909be", () => MailBoxFolderId);
			MetaPathParameterValues.Add("532cb61b-8379-42bc-9a48-99fd98f7801b", () => LoadResult);
			MetaPathParameterValues.Add("574326c8-1b08-4af9-9e49-7da640ea2c9e", () => Messages);
			MetaPathParameterValues.Add("562516d4-4d62-4421-b65f-3924fb92a101", () => MessagesCount);
			MetaPathParameterValues.Add("9df9ed0b-1c24-40f3-94dc-f7cfa995d7db", () => SenderEmailAddress);
			MetaPathParameterValues.Add("21444bbc-5fee-4669-9cb3-26a7af386911", () => NeedSetMailboxSynchronizationMessage);
			MetaPathParameterValues.Add("c7cc5b5d-0efd-428c-80d5-c6feea55dec6", () => InformationCaption);
			MetaPathParameterValues.Add("e255669d-4628-4d24-b91e-f4e34a99cc0a", () => SuccessLoadEmailsMessage);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "PageInstanceId":
					if (!hasValueToRead) break;
					PageInstanceId = reader.GetValue<System.String>();
				break;
				case "ActiveTreeGridCurrentRowId":
					if (!hasValueToRead) break;
					ActiveTreeGridCurrentRowId = reader.GetValue<System.Guid>();
				break;
				case "CurrentUserMailboxSynchronizationSettingsUId":
					if (!hasValueToRead) break;
					CurrentUserMailboxSynchronizationSettingsUId = reader.GetValue<System.Guid>();
				break;
				case "MailboxSynchronizationSettingsPageUId":
					if (!hasValueToRead) break;
					MailboxSynchronizationSettingsPageUId = reader.GetValue<System.Guid>();
				break;
				case "NeedSetMailboxSynchronizationMessageUId":
					if (!hasValueToRead) break;
					NeedSetMailboxSynchronizationMessageUId = reader.GetValue<System.Guid>();
				break;
				case "MailBoxFolderId":
					if (!hasValueToRead) break;
					MailBoxFolderId = reader.GetValue<System.Guid>();
				break;
				case "LoadResult":
					if (!hasValueToRead) break;
					LoadResult = reader.GetValue<System.String>();
				break;
				case "Messages":
					if (!hasValueToRead) break;
					Messages = reader.GetSerializableObjectValue();
				break;
				case "MessagesCount":
					if (!hasValueToRead) break;
					MessagesCount = reader.GetValue<System.Int32>();
				break;
				case "SenderEmailAddress":
					if (!hasValueToRead) break;
					SenderEmailAddress = reader.GetValue<System.String>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			Messages = new Dictionary<Guid, string>();
			var rootEmailFolderId = new Guid("181F9D34-5DEE-E011-A86B-00155D04C01D");
			if (MailBoxFolderId == Guid.Empty) {
				ShowEditSettingsMessage();
				return true;
			}
			if (rootEmailFolderId == MailBoxFolderId) {
				var ids = GetCurrentUserMailboxSynchronizationSettingsUIds();
				if (ids.Count() == 0) {
					ShowEditSettingsMessage();
				}
				foreach(var id in ids) {
					DownloadEmailsFromMailBox(id);
				} 
			} else {
				var mailboxId = GetMailboxId(MailBoxFolderId);
				if (mailboxId != Guid.Empty && mailboxId != null) {
					DownloadEmailsFromMailBox(mailboxId);
				} else {
					ShowEditSettingsMessage();
				}
			}
			var messages = string.Empty;
			foreach(var message in (Dictionary<Guid, string>)Messages) {
				messages += string.Format("{{\"id\": \"{0}\", \"message\": \"{1}\"}},", message.Key, message.Value);
			}
			if (!string.IsNullOrEmpty(messages)) {
				messages = messages.Remove(messages.Length - 1);
			}
			LoadResult = string.Format("{{ \"Messages\": [{0}] }}", messages);
			return true;
		}

			
			public virtual IEnumerable<Guid> GetCurrentUserMailboxSynchronizationSettingsUIds() {
				var mailboxSynchronizationSettingsEntitySchema = UserConnection.EntitySchemaManager.GetInstanceByName("MailboxSyncSettings");
				var entitySchemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "MailboxSyncSettings");
				var entitySchemaColumn = entitySchemaQuery.AddColumn(mailboxSynchronizationSettingsEntitySchema.GetPrimaryColumnName());
				entitySchemaQuery.Filters.Add(
					entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
						"SysAdminUnit", UserConnection.CurrentUser.Id));
				entitySchemaQuery.Filters.Add(
					entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
						"MailServer.Type", new Guid("844F0837-EAA0-4F40-B965-71F5DB9EAE6E")));
				var queryResults = entitySchemaQuery.GetEntityCollection(UserConnection);
				return from result in queryResults select result.GetTypedColumnValue<Guid>(entitySchemaColumn.Name);
			}
			
			
			public virtual MailCredentials GetMailServerCredentials(Guid mailServerUId) {
				var result = new MailCredentials();
				if (mailServerUId != Guid.Empty) {
					var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
					var mailServerEntitySchema = entitySchemaManager.GetInstanceByName("MailServer");
					var mailServerEntitySchemaPrimaryColumnName = mailServerEntitySchema.GetPrimaryColumnName();
					var mailServerEntitySchemaPrimaryColumn = mailServerEntitySchema.Columns.GetByName(mailServerEntitySchemaPrimaryColumnName);
					var currentMailServer = new Terrasoft.Configuration.MailServer(UserConnection);
					var columnNamesToFetch = new List<string> {
						"Address",
						"Port",
						"UseSSL",
						"IsStartTls"
					};
					var columnsToFetch = new List<EntitySchemaColumn>();
					foreach (var columnName in columnNamesToFetch) {
						columnsToFetch.Add(mailServerEntitySchema.Columns.GetByName(columnName));
					}
					if (currentMailServer.FetchFromDB(mailServerEntitySchemaPrimaryColumn, mailServerUId, columnsToFetch)) {
						result.Host = currentMailServer.Address;
						result.Port = currentMailServer.Port;
						result.UseSsl = currentMailServer.UseSSL;
						result.StartTls = currentMailServer.IsStartTls;
					}
				}
				return result;
			}
			
			
			public virtual KeyValuePair<MailboxSyncSettings, MailCredentials> GetMailServerUserCredentials(Guid mailboxSynchronizationSettingsUId) {
				var resultMailboxSynchronizationSettings = new MailboxSyncSettings(UserConnection);
				var resultMailCredentials= new MailCredentials();
				if (mailboxSynchronizationSettingsUId != Guid.Empty) {
					if (resultMailboxSynchronizationSettings.FetchFromDB(mailboxSynchronizationSettingsUId)) {
						resultMailCredentials = GetMailServerCredentials(resultMailboxSynchronizationSettings.MailServerId);
						resultMailCredentials.UserName = resultMailboxSynchronizationSettings.UserName;
						resultMailCredentials.UserPassword = resultMailboxSynchronizationSettings.UserPassword;
						resultMailCredentials.SenderEmailAddress = resultMailboxSynchronizationSettings.SenderEmailAddress;
					}
				}
				var result = new KeyValuePair<MailboxSyncSettings, MailCredentials> 
					(resultMailboxSynchronizationSettings, resultMailCredentials);
				return result;
			}
			
			
			/*public virtual void PrepareMailboxSynchronizationSettingsPageOpening(OpenPageUserTask openPageUserTask) {
				var mailboxSynchronizationSettingsPageUId = new Guid("fce8864e-7b01-429e-921e-0563c725d563");
				var mailboxSynchronizationSettingsGridPageUId = new Guid("c8ce13a0-3836-4ba7-b389-4b9e2014013c");
				openPageUserTask.PageParameters = new Dictionary<string, string>();
				var pageParams = openPageUserTask.PageParameters as Dictionary<string, string>;
				if (MailBoxFolderId == Guid.Empty){
					openPageUserTask.PageUId = mailboxSynchronizationSettingsGridPageUId;
					pageParams.Add("userId", UserConnection.CurrentUser.Id.ToString());
				} else {
				 	openPageUserTask.PageUId = mailboxSynchronizationSettingsPageUId;
					pageParams.Add("recordId", GetMailboxId(MailBoxFolderId).ToString());
				}
				openPageUserTask.OpenerInstanceId = InstanceUId;
				openPageUserTask.UseCurrentActivePage = true;
			}*/
			
			
			/*public virtual Terrasoft.UI.WebControls.Controls.MessagePanel GetMainPageMessagePanel() {
				var mainPage = System.Web.HttpContext.Current.Handler as Terrasoft.UI.WebControls.Page;
				var messagePanelControl = Terrasoft.UI.WebControls.Page.FindControlByClientId(mainPage, "BaseMessagePanel", true);
				var messagePanel = messagePanelControl as Terrasoft.UI.WebControls.Controls.MessagePanel;
				return messagePanel;
			}*/
			
			
			public virtual void ShowEditSettingsMessage() {
				//var messagePanel = GetMainPageMessagePanel();
				//var message = string.Format(NeedSetMailboxSynchronizationMessage, MailboxSynchronizationSettingsPageUId.ToString("B"));
				//messagePanel.AddMessage(NeedSetMailboxSynchronizationMessageUId.ToString("N"), InformationCaption, message);
				((Dictionary<Guid, string>)Messages).Add(MailBoxFolderId, NeedSetMailboxSynchronizationMessage.ToString());
			}
			
			
			public virtual void DownloadEmailsFromMailBox(Guid mailboxId) {
				var serverCredentials = GetMailServerUserCredentials(mailboxId).Value;
				if (UserConnection.GetIsFeatureEnabled("EmailIntegrationV2")) {
					var syncSession = ClassFactory.Get<ISyncSession>("Email", new ConstructorArgument("uc", UserConnection),
						new ConstructorArgument("senderEmailAddress", serverCredentials.SenderEmailAddress));
					syncSession.Start();
					return;
				}
				try {
					using (var imapSyncSession = ClassFactory.Get<IImapSyncSession>(
					new ConstructorArgument("userConnection", UserConnection),
					new ConstructorArgument("credentials", serverCredentials),
					new ConstructorArgument("login", true))) {
						imapSyncSession.SyncImapMail();
						MessagesCount = imapSyncSession.RemoteChangesCount;
					}
				} catch (ImapException e) {	
					//var messagePanel = GetMainPageMessagePanel();
					//var warningCaption = new QuestionUserTask(UserConnection).WarningCaption;
					//messagePanel.AddMessage(warningCaption, e.Message, MessageType.Warning);
					((Dictionary<Guid, string>)Messages).Add(mailboxId, e.Message.ToString());
				}
			}
			
			
			public virtual Guid GetMailboxId(Guid folderId) {
				var sel = new Select(UserConnection)
					.Column("MailboxSyncSettings", "Id")
					.From("MailboxSyncSettings")
					.LeftOuterJoin("ActivityFolder").On("ActivityFolder", "Name")
						.IsEqual("MailboxSyncSettings", "MailboxName")
					.Where("ActivityFolder", "Id").IsEqual(Column.Parameter(folderId)) as Select;
				using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				    return sel.ExecuteScalar<Guid>(dbExecutor);
				}
			}
			
			
			public virtual string GetMailboxSenderEmailAddress() {
				var sel = new Select(UserConnection)
					.Column("MailboxSyncSettings", "SenderEmailAddress")
					.From("MailboxSyncSettings")
					.LeftOuterJoin("ActivityFolder").On("ActivityFolder", "Name")
						.IsEqual("MailboxSyncSettings", "MailboxName")
					.Where("ActivityFolder", "Id").IsEqual(Column.Parameter(MailBoxFolderId)) as Select;
				using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				    return sel.ExecuteScalar<string>(dbExecutor);
				}
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
			var cloneItem = (LoadImapEmailsProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			cloneItem.Messages = Messages;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

