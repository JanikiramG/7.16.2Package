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

	#region Class: InvoiceVisaProcessSchema

	/// <exclude/>
	public class InvoiceVisaProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public InvoiceVisaProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public InvoiceVisaProcessSchema(InvoiceVisaProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "InvoiceVisaProcess";
			UId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243");
			CreatedInPackageId = new Guid("ed1b5d86-de48-4aad-b58a-ff58e682dbe0");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.16.0.4461";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"Visa Process";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243");
			Version = 0;
			PackageUId = new Guid("e7a2c20a-9591-484e-bf77-5953f2dc592e");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateEmailBodyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("74993b60-74e2-40cb-9814-23ff874d9202"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"EmailBody",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEmailSubjectParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3cb8a4b7-f45b-44ff-b96d-91b115085a87"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"EmailSubject",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateRecordIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7b7f0b9b-4163-46fa-9880-794c80c407c4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEmailBodyParameter());
			Parameters.Add(CreateEmailSubjectParameter());
			Parameters.Add(CreateRecordIdParameter());
		}

		protected virtual void InitializeInvoiceVisaSubProcessParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var invoiceParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3cff9b6a-3056-44a8-9a1f-c6bfec3caa52"),
				ContainerUId = new Guid("542e8d6c-f4fa-4b4e-983a-9c865c132053"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Name = @"Invoice",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			invoiceParameter.SourceValue = new ProcessSchemaParameterValue(invoiceParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{7b7f0b9b-4163-46fa-9880-794c80c407c4}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(invoiceParameter);
			var visaOwnerParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				UId = new Guid("3056cd61-172a-449e-999b-ce78323fd7ec"),
				ContainerUId = new Guid("542e8d6c-f4fa-4b4e-983a-9c865c132053"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Name = @"VisaOwner",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			visaOwnerParameter.SourceValue = new ProcessSchemaParameterValue(visaOwnerParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{836ca04a-78fa-4cf4-a449-453ee4c8b6cd}].[Parameter:{e0dd21fb-3d51-44e8-b854-0e07c860de49}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(visaOwnerParameter);
			var visaObjectiveParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9b499fc0-a472-4fc1-8168-5a7f139ed935"),
				ContainerUId = new Guid("542e8d6c-f4fa-4b4e-983a-9c865c132053"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Name = @"VisaObjective",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText")
			};
			visaObjectiveParameter.SourceValue = new ProcessSchemaParameterValue(visaObjectiveParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{836ca04a-78fa-4cf4-a449-453ee4c8b6cd}].[Parameter:{4e06d591-5e64-4ada-8d8c-ecc485ed6411}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(visaObjectiveParameter);
			var visaResultParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8f1116ee-11da-40ee-bb56-440bdf99b269"),
				ContainerUId = new Guid("542e8d6c-f4fa-4b4e-983a-9c865c132053"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Name = @"VisaResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText")
			};
			visaResultParameter.SourceValue = new ProcessSchemaParameterValue(visaResultParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c")
			};
			parametrizedElement.Parameters.Add(visaResultParameter);
			var isAllowedToDelegateParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7ef81b65-2836-4432-b1da-f17b53c9a6de"),
				ContainerUId = new Guid("542e8d6c-f4fa-4b4e-983a-9c865c132053"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Name = @"IsAllowedToDelegate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isAllowedToDelegateParameter.SourceValue = new ProcessSchemaParameterValue(isAllowedToDelegateParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{836ca04a-78fa-4cf4-a449-453ee4c8b6cd}].[Parameter:{e4157d41-c7c0-423c-90ea-9b31a9527bea}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(isAllowedToDelegateParameter);
			var isPreviousVisaCountsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1f29d0dc-0ab8-4b13-a121-53bd4037b40d"),
				ContainerUId = new Guid("542e8d6c-f4fa-4b4e-983a-9c865c132053"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Name = @"IsPreviousVisaCounts",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isPreviousVisaCountsParameter.SourceValue = new ProcessSchemaParameterValue(isPreviousVisaCountsParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(isPreviousVisaCountsParameter);
		}

		protected virtual void InitializeInputVisaParametersParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var titleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("15e74ec5-0326-4f08-8eff-34dd48372d46"),
				ContainerUId = new Guid("836ca04a-78fa-4cf4-a449-453ee4c8b6cd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.In,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"Title",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			titleParameter.SourceValue = new ProcessSchemaParameterValue(titleParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"New approval",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(titleParameter);
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("03bf1a8c-ab55-4047-aa71-9f75cf806d53"),
				ContainerUId = new Guid("836ca04a-78fa-4cf4-a449-453ee4c8b6cd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.In,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
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
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6fda6d18-1dcb-4cdc-beb8-3d93131256a5"),
				ContainerUId = new Guid("836ca04a-78fa-4cf4-a449-453ee4c8b6cd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
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
			var entityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("af3a440c-346a-45ea-b989-ad9edad884e9"),
				ContainerUId = new Guid("836ca04a-78fa-4cf4-a449-453ee4c8b6cd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.In,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
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
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(entityIdParameter);
			var buttonsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("64a3cca3-4c10-4274-aef0-5a1ef5d6712f"),
				ContainerUId = new Guid("836ca04a-78fa-4cf4-a449-453ee4c8b6cd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"Buttons",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			buttonsParameter.SourceValue = new ProcessSchemaParameterValue(buttonsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"{""$type"":""System.Collections.Generic.List`1[[System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib]], mscorlib"",""$values"":[{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""f3e3b4f4-4c3e-4efd-b334-bd6521c4fef7"",""name"":""ButtonOk"",""caption"":""Save"",""style"":""green"",""performValidation"":true,""isEnabled"":true,""generateSignal"":""""}]}",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(buttonsParameter);
			var elementsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("67d2763d-f0c5-4de5-be15-11bb62ecf373"),
				ContainerUId = new Guid("836ca04a-78fa-4cf4-a449-453ee4c8b6cd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"Elements",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			elementsParameter.SourceValue = new ProcessSchemaParameterValue(elementsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"{""$type"":""System.Collections.Generic.List`1[[System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib]], mscorlib"",""$values"":[{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""e0dd21fb-3d51-44e8-b854-0e07c860de49"",""name"":""VisaOwner"",""caption"":""Approver"",""controlEditType"":""SelectionField"",""isRequired"":true,""dataFilter"":"""",""controlDataValueType"":""10"",""dataSource"":""84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""4e06d591-5e64-4ada-8d8c-ecc485ed6411"",""name"":""Objective"",""caption"":""Approval objective"",""controlEditType"":""1"",""isMultiline"":true,""isRequired"":false},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""e4157d41-c7c0-423c-90ea-9b31a9527bea"",""name"":""IsAllowedToDelegate"",""caption"":""Delegation permitted"",""controlEditType"":""12""}]}",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(elementsParameter);
			var extendedClientModuleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("05607c13-cca8-4ff4-9db7-ca1b00e9d924"),
				ContainerUId = new Guid("836ca04a-78fa-4cf4-a449-453ee4c8b6cd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"ExtendedClientModule",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			extendedClientModuleParameter.SourceValue = new ProcessSchemaParameterValue(extendedClientModuleParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(extendedClientModuleParameter);
			var entryPointIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2c1c4abc-e8a6-48a5-bc00-7f05f8db1732"),
				ContainerUId = new Guid("836ca04a-78fa-4cf4-a449-453ee4c8b6cd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
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
			var pressedButtonCodeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d649bbc1-42b3-4dd3-b3f4-288751672e90"),
				ContainerUId = new Guid("836ca04a-78fa-4cf4-a449-453ee4c8b6cd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
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
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("c36b3fbb-0cda-4054-9d6c-3f2764a2a299"),
				ContainerUId = new Guid("836ca04a-78fa-4cf4-a449-453ee4c8b6cd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = true,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
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
				UId = new Guid("2f5005e0-98ac-49c4-95a3-093aed380ddb"),
				ContainerUId = new Guid("836ca04a-78fa-4cf4-a449-453ee4c8b6cd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"ShowExecutionPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showExecutionPageParameter.SourceValue = new ProcessSchemaParameterValue(showExecutionPageParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f789c4c3-1f20-4baa-9abc-19ae652beb7b"),
				ContainerUId = new Guid("836ca04a-78fa-4cf4-a449-453ee4c8b6cd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
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
				UId = new Guid("2a68b2b8-60a8-47eb-873f-949b07b7200c"),
				ContainerUId = new Guid("836ca04a-78fa-4cf4-a449-453ee4c8b6cd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
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
			var visaOwnerParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				UId = new Guid("e0dd21fb-3d51-44e8-b854-0e07c860de49"),
				ContainerUId = new Guid("836ca04a-78fa-4cf4-a449-453ee4c8b6cd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"VisaOwner",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			visaOwnerParameter.SourceValue = new ProcessSchemaParameterValue(visaOwnerParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(visaOwnerParameter);
			var objectiveParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4e06d591-5e64-4ada-8d8c-ecc485ed6411"),
				ContainerUId = new Guid("836ca04a-78fa-4cf4-a449-453ee4c8b6cd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"Objective",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			objectiveParameter.SourceValue = new ProcessSchemaParameterValue(objectiveParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(objectiveParameter);
			var isAllowedToDelegateParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e4157d41-c7c0-423c-90ea-9b31a9527bea"),
				ContainerUId = new Guid("836ca04a-78fa-4cf4-a449-453ee4c8b6cd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"IsAllowedToDelegate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isAllowedToDelegateParameter.SourceValue = new ProcessSchemaParameterValue(isAllowedToDelegateParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(isAllowedToDelegateParameter);
		}

		protected virtual void InitializeForbitInvoiceChangeParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6410dd64-cb18-4b43-92d8-ea4e92452489"),
				ContainerUId = new Guid("35a81948-7702-4db3-a7bf-3f258a365e3b"),
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
				Value = @"bfb313dd-bb55-4e1b-8e42-3d346e0da7c5",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5aca796c-35c6-418a-9deb-b088a8f677dc"),
				ContainerUId = new Guid("35a81948-7702-4db3-a7bf-3f258a365e3b"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,36,21,217,146,45,217,61,46,219,178,151,52,180,105,41,36,75,24,75,163,172,192,31,27,75,166,9,102,255,123,229,117,54,133,28,74,233,173,160,195,204,72,239,205,155,199,104,190,247,225,163,111,35,142,181,131,54,32,157,118,182,38,216,128,70,5,154,65,197,57,147,32,115,6,90,24,134,96,139,44,203,51,165,180,38,180,135,14,107,178,162,183,214,71,66,125,196,46,212,183,243,111,210,56,78,72,239,221,57,249,106,14,216,193,183,165,65,227,26,145,9,107,89,211,20,5,147,152,53,76,99,234,34,172,144,37,114,11,202,20,100,213,82,42,225,56,55,142,85,210,165,167,50,67,6,69,201,89,81,130,202,157,169,108,225,28,161,45,186,184,125,58,142,24,130,31,250,122,198,215,248,230,249,152,84,174,189,55,67,59,117,61,161,29,70,184,134,120,168,9,32,71,89,24,96,70,86,137,221,161,98,32,42,203,4,52,42,87,26,179,50,83,132,26,56,198,133,150,236,44,161,22,34,124,135,118,194,51,243,236,147,198,92,240,76,23,101,194,102,201,37,41,114,206,116,169,21,115,182,116,21,138,178,170,26,123,241,235,211,228,83,236,195,213,212,225,232,205,139,237,152,252,27,198,122,54,67,31,199,161,93,168,175,206,207,111,240,41,174,230,190,92,253,88,7,138,169,190,128,200,137,78,1,55,173,199,62,110,123,51,88,223,63,172,156,167,83,130,116,71,24,125,184,184,176,125,156,160,37,116,244,15,135,63,186,181,153,66,28,186,255,104,84,154,198,76,28,105,201,206,114,151,29,180,62,28,91,120,62,231,53,121,247,56,13,241,195,23,52,195,104,119,118,205,200,27,84,77,238,136,106,148,227,77,213,48,153,149,130,201,210,1,171,180,230,76,85,210,104,110,36,87,70,222,145,164,228,31,249,111,119,225,243,207,254,242,23,86,245,251,247,169,250,166,112,125,65,214,243,223,72,58,237,23,81,251,83,58,191,0,218,18,108,245,210,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var deleteRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("24dfe4df-9bb5-49a4-95db-61542b4948d1"),
				ContainerUId = new Guid("35a81948-7702-4db3-a7bf-3f258a365e3b"),
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,37,137,189,10,194,48,16,128,95,37,100,78,160,218,88,66,182,162,34,46,14,21,39,113,184,230,46,32,196,20,46,201,36,190,187,253,217,190,159,231,247,138,78,182,118,12,93,59,162,134,125,103,181,9,120,208,224,97,38,99,125,211,144,53,38,128,84,71,72,3,1,186,0,49,211,98,103,124,23,87,184,174,114,162,72,133,54,189,79,149,61,57,185,147,234,194,144,10,205,220,199,56,76,145,114,159,240,145,137,179,84,55,248,108,93,240,50,4,36,20,117,93,191,215,31,121,168,35,25,152,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(deleteRightsParameter);
			var addRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("00434e0c-82ed-4624-aecf-e0253c869124"),
				ContainerUId = new Guid("35a81948-7702-4db3-a7bf-3f258a365e3b"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,139,142,5,0,41,187,76,13,2,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(addRightsParameter);
		}

		protected virtual void InitializeReadInvoiceParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("eb5c0633-71b5-4885-bf63-9348c6e716fe"),
				ContainerUId = new Guid("a870c1ce-bfa0-4d8b-8b91-f65750ebcaa7"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,77,107,220,48,16,134,255,139,14,61,89,197,182,100,75,118,143,203,182,236,37,13,109,90,10,201,18,244,49,147,21,248,43,150,76,19,140,255,123,229,117,54,133,28,74,233,173,224,131,52,246,251,206,51,47,227,249,222,249,143,174,9,48,214,168,26,15,201,116,176,53,169,16,11,212,136,52,71,97,40,47,165,166,90,27,164,74,20,178,64,196,210,170,148,36,157,106,161,38,155,122,111,93,32,137,11,208,250,250,118,254,109,26,198,9,146,123,60,95,190,154,19,180,234,219,218,64,163,102,25,179,54,218,22,5,229,144,105,42,129,231,148,89,198,75,72,173,18,166,32,27,139,22,140,149,85,193,41,72,180,148,219,28,169,206,13,167,185,1,99,57,51,185,145,150,36,13,96,216,63,13,35,120,239,250,174,158,225,245,124,243,60,68,202,173,247,174,111,166,182,35,73,11,65,93,171,112,170,137,130,20,120,97,20,53,188,138,32,8,130,42,86,89,202,148,22,185,144,144,149,153,32,137,81,67,88,109,201,33,182,178,42,168,239,170,153,224,236,60,187,200,152,179,52,147,69,25,181,25,139,121,177,60,165,178,148,130,162,45,177,130,136,95,105,123,201,235,211,228,226,217,249,171,169,133,209,153,151,216,33,230,215,143,245,108,250,46,140,125,179,90,95,157,63,191,129,167,176,133,251,242,234,199,54,80,136,245,85,68,150,100,242,176,107,28,116,97,223,153,222,186,238,97,243,92,150,40,105,7,53,58,127,73,97,255,56,169,134,36,163,123,56,253,49,173,221,228,67,223,254,71,163,38,113,204,232,17,151,236,140,187,238,160,117,126,104,212,243,249,94,147,119,143,83,31,62,124,1,211,143,246,96,183,27,121,163,170,201,29,17,90,96,170,43,77,121,86,178,184,249,168,104,37,101,74,69,197,141,76,13,79,133,225,119,36,146,252,163,255,237,193,127,254,217,93,254,133,141,254,248,62,86,223,20,174,47,202,122,254,27,164,229,184,66,29,151,248,252,2,36,175,107,249,210,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("df762cbe-8d50-45aa-a692-fc3ca13753f4"),
				ContainerUId = new Guid("a870c1ce-bfa0-4d8b-8b91-f65750ebcaa7"),
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
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0e9f1193-9fc1-4b4b-8432-b733eba80912"),
				ContainerUId = new Guid("a870c1ce-bfa0-4d8b-8b91-f65750ebcaa7"),
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
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9d143566-7ff6-4ddc-91a8-d591f09cd961"),
				ContainerUId = new Guid("a870c1ce-bfa0-4d8b-8b91-f65750ebcaa7"),
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
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e5201aee-681b-4744-8a31-9ddd18e21086"),
				ContainerUId = new Guid("a870c1ce-bfa0-4d8b-8b91-f65750ebcaa7"),
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
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("11075dd3-15ea-48cc-bc90-e0d56c7659c3"),
				ContainerUId = new Guid("a870c1ce-bfa0-4d8b-8b91-f65750ebcaa7"),
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
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9cc48116-aeb9-466b-8bfc-4e956a8a224a"),
				ContainerUId = new Guid("a870c1ce-bfa0-4d8b-8b91-f65750ebcaa7"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,43,205,77,74,45,178,50,180,50,212,241,76,177,50,176,50,0,0,237,33,101,51,17,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				UId = new Guid("7357770f-8b54-46b0-8ac6-9419f1e3851d"),
				ContainerUId = new Guid("a870c1ce-bfa0-4d8b-8b91-f65750ebcaa7"),
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
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8a5724d5-1ff6-487b-9fc6-200c9ad0f055"),
				ContainerUId = new Guid("a870c1ce-bfa0-4d8b-8b91-f65750ebcaa7"),
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
				UId = new Guid("ba20003a-340e-46d9-a946-c7b838095ecf"),
				ContainerUId = new Guid("a870c1ce-bfa0-4d8b-8b91-f65750ebcaa7"),
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
				UId = new Guid("449de235-c6b7-424f-85d8-fb162b49bb7b"),
				ContainerUId = new Guid("a870c1ce-bfa0-4d8b-8b91-f65750ebcaa7"),
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
				UId = new Guid("ba4dd278-a683-4a23-bb70-76dbea3a6008"),
				ContainerUId = new Guid("a870c1ce-bfa0-4d8b-8b91-f65750ebcaa7"),
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
				UId = new Guid("88ad9c3b-a5af-4854-a28b-1335fb70031e"),
				ContainerUId = new Guid("a870c1ce-bfa0-4d8b-8b91-f65750ebcaa7"),
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
				UId = new Guid("e8e6e487-50e1-4bf3-8f69-9a817f3ab435"),
				ContainerUId = new Guid("a870c1ce-bfa0-4d8b-8b91-f65750ebcaa7"),
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
				ReferenceSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				UId = new Guid("221e16c4-8293-45d9-8259-d695e5af79eb"),
				ContainerUId = new Guid("a870c1ce-bfa0-4d8b-8b91-f65750ebcaa7"),
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
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("43a99aa6-4673-4153-a178-a5b9790d2ad5"),
				ContainerUId = new Guid("a870c1ce-bfa0-4d8b-8b91-f65750ebcaa7"),
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
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c85fb573-bcfe-41e9-a9a9-27b68c96c857"),
				ContainerUId = new Guid("a870c1ce-bfa0-4d8b-8b91-f65750ebcaa7"),
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
				UId = new Guid("95fb85e2-48cd-487b-8b32-017ae2bde0ef"),
				ContainerUId = new Guid("a870c1ce-bfa0-4d8b-8b91-f65750ebcaa7"),
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
				UId = new Guid("f2e1aba9-04eb-49bb-b534-e8dcc3aad782"),
				ContainerUId = new Guid("a870c1ce-bfa0-4d8b-8b91-f65750ebcaa7"),
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

		protected virtual void InitializeSendEmailToOwnerParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var senderParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				UId = new Guid("e23b91be-231f-435f-8517-737db19c220d"),
				ContainerUId = new Guid("a4f303ab-3ca4-40cf-bd61-6c4b651a7584"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				Name = @"Sender",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			senderParameter.SourceValue = new ProcessSchemaParameterValue(senderParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(senderParameter);
			var recepientParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("eafc53b1-5965-4420-91e0-d855598a9606"),
				ContainerUId = new Guid("a4f303ab-3ca4-40cf-bd61-6c4b651a7584"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				Name = @"Recepient",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			recepientParameter.SourceValue = new ProcessSchemaParameterValue(recepientParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{bff63975-7641-445b-a526-7e12cd421a7e}].[Parameter:{31f0b17f-eb70-4992-b1b1-bca006ff0170}].[EntityColumn:{dbf202ec-c444-479b-bcf4-d8e5b1863201}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(recepientParameter);
			var copyRecepientParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5267c7f6-bd77-4ed7-824c-b431dbd24c08"),
				ContainerUId = new Guid("a4f303ab-3ca4-40cf-bd61-6c4b651a7584"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				Name = @"CopyRecepient",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			copyRecepientParameter.SourceValue = new ProcessSchemaParameterValue(copyRecepientParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(copyRecepientParameter);
			var blindCopyRecepientParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fe9744a9-7550-407f-802d-aa723487447d"),
				ContainerUId = new Guid("a4f303ab-3ca4-40cf-bd61-6c4b651a7584"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				Name = @"BlindCopyRecepient",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			blindCopyRecepientParameter.SourceValue = new ProcessSchemaParameterValue(blindCopyRecepientParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(blindCopyRecepientParameter);
			var subjectParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d722c459-1025-4d56-86cc-230572deb759"),
				ContainerUId = new Guid("a4f303ab-3ca4-40cf-bd61-6c4b651a7584"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				Name = @"Subject",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			subjectParameter.SourceValue = new ProcessSchemaParameterValue(subjectParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{3cb8a4b7-f45b-44ff-b96d-91b115085a87}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(subjectParameter);
			var bodyParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("62b9d136-3ff8-48ad-91e5-9dc61486aef5"),
				ContainerUId = new Guid("a4f303ab-3ca4-40cf-bd61-6c4b651a7584"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				Name = @"Body",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			bodyParameter.SourceValue = new ProcessSchemaParameterValue(bodyParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{74993b60-74e2-40cb-9814-23ff874d9202}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(bodyParameter);
			var importanceParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0ededcb2-d1f2-4ed5-8714-1a853d7276ec"),
				ContainerUId = new Guid("a4f303ab-3ca4-40cf-bd61-6c4b651a7584"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				Name = @"Importance",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			importanceParameter.SourceValue = new ProcessSchemaParameterValue(importanceParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(importanceParameter);
			var isIgnoreErrorsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ed7f847d-ac6b-4f96-880b-b96226ea317b"),
				ContainerUId = new Guid("a4f303ab-3ca4-40cf-bd61-6c4b651a7584"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				Name = @"IsIgnoreErrors",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isIgnoreErrorsParameter.SourceValue = new ProcessSchemaParameterValue(isIgnoreErrorsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(isIgnoreErrorsParameter);
		}

		protected virtual void InitializeReadOwnerParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8584ab53-ba83-4f42-a7bc-feab37d28011"),
				ContainerUId = new Guid("bff63975-7641-445b-a526-7e12cd421a7e"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,77,107,220,48,16,134,255,202,162,67,79,214,34,89,214,151,123,12,155,146,75,26,218,180,4,146,16,244,49,74,4,254,216,216,114,155,96,246,191,87,94,39,45,228,80,114,42,20,124,144,37,189,239,204,60,154,153,239,226,120,26,155,4,67,29,76,51,66,49,157,249,26,41,21,20,40,77,176,178,212,226,74,16,157,87,186,196,37,81,86,18,47,5,169,2,42,58,211,66,141,86,245,206,199,132,138,152,160,29,235,235,249,143,105,26,38,40,238,194,241,231,171,123,128,214,124,91,2,80,97,129,9,78,177,10,80,226,138,242,28,192,123,130,141,34,204,87,66,49,239,25,90,115,41,1,40,39,170,196,18,180,198,85,0,192,154,82,141,93,169,109,101,43,89,6,97,81,209,64,72,187,167,253,0,227,24,251,174,158,225,247,250,242,121,159,179,92,99,159,244,205,212,118,168,104,33,153,11,147,30,106,100,128,64,197,157,193,174,210,124,113,151,216,48,237,49,51,86,150,82,1,21,84,162,194,153,125,90,108,209,153,71,133,55,201,124,55,205,4,71,231,57,46,57,50,66,21,23,89,75,153,195,21,43,51,57,161,36,14,94,4,157,11,213,218,250,87,94,159,166,152,215,113,60,159,90,24,162,123,193,14,153,95,63,212,179,235,187,52,244,205,98,125,126,188,126,9,79,105,133,251,114,116,181,22,148,242,254,34,66,135,98,26,225,164,137,208,165,93,231,122,31,187,251,213,243,112,200,146,118,111,134,56,190,82,216,61,78,166,65,197,16,239,31,254,74,235,100,26,83,223,254,71,165,22,185,204,236,145,155,236,152,238,210,131,62,142,251,198,60,31,255,107,244,225,113,234,211,199,47,96,252,38,118,63,250,232,96,123,26,135,49,109,150,150,221,244,97,147,235,159,154,148,29,55,174,111,26,112,203,123,111,63,255,236,96,88,165,232,77,136,26,221,32,163,36,113,212,1,182,193,16,92,121,101,151,49,161,56,8,46,57,1,235,140,145,91,201,184,148,146,132,124,196,171,60,75,54,3,51,78,96,93,81,29,40,48,197,169,223,58,230,75,224,204,96,78,68,158,7,205,242,40,120,227,176,116,214,121,237,89,224,202,221,160,12,224,95,148,117,125,54,30,111,172,51,179,18,190,221,230,221,55,27,187,6,218,252,20,245,252,30,14,135,44,184,120,13,85,207,239,161,178,72,118,93,138,233,121,157,219,220,50,239,192,116,184,93,64,221,30,242,247,11,94,131,101,143,221,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c376d60e-a7a4-4e19-bd8a-dae2932a0e78"),
				ContainerUId = new Guid("bff63975-7641-445b-a526-7e12cd421a7e"),
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
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9f2bb0a7-bb26-44d6-982d-bae251821d05"),
				ContainerUId = new Guid("bff63975-7641-445b-a526-7e12cd421a7e"),
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
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8891e889-db66-4762-9171-8140dd7cf232"),
				ContainerUId = new Guid("bff63975-7641-445b-a526-7e12cd421a7e"),
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
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5d406829-cb2c-4bc8-aee9-9b1c2127c6fd"),
				ContainerUId = new Guid("bff63975-7641-445b-a526-7e12cd421a7e"),
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
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cb921596-274f-4b21-8c44-b212fc1920ca"),
				ContainerUId = new Guid("bff63975-7641-445b-a526-7e12cd421a7e"),
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
				UId = new Guid("f1ff7012-8664-41bf-9c72-c0b8ed663964"),
				ContainerUId = new Guid("bff63975-7641-445b-a526-7e12cd421a7e"),
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
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("31f0b17f-eb70-4992-b1b1-bca006ff0170"),
				ContainerUId = new Guid("bff63975-7641-445b-a526-7e12cd421a7e"),
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
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("aa386400-da48-4c38-ad31-fc6fc0b48215"),
				ContainerUId = new Guid("bff63975-7641-445b-a526-7e12cd421a7e"),
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
				UId = new Guid("d69de283-3768-4fed-88cf-ba8a30d46115"),
				ContainerUId = new Guid("bff63975-7641-445b-a526-7e12cd421a7e"),
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
				UId = new Guid("d49960ad-0a29-4f36-993a-f6d4071447e8"),
				ContainerUId = new Guid("bff63975-7641-445b-a526-7e12cd421a7e"),
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
				UId = new Guid("2170fceb-72f6-4c84-8877-fe0d9df8d2db"),
				ContainerUId = new Guid("bff63975-7641-445b-a526-7e12cd421a7e"),
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
				UId = new Guid("2af17b6f-5672-4495-9124-0e90d072d034"),
				ContainerUId = new Guid("bff63975-7641-445b-a526-7e12cd421a7e"),
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
				UId = new Guid("ac4a8ce3-7747-409c-9280-55e75a467639"),
				ContainerUId = new Guid("bff63975-7641-445b-a526-7e12cd421a7e"),
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
				UId = new Guid("9d748d72-4039-430d-9516-9bf95155fd9b"),
				ContainerUId = new Guid("bff63975-7641-445b-a526-7e12cd421a7e"),
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
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c3c00126-734d-41e9-bf79-8da33bbe8ad7"),
				ContainerUId = new Guid("bff63975-7641-445b-a526-7e12cd421a7e"),
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
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3ae21b6c-fec9-4c92-9a29-c7820bacc7cd"),
				ContainerUId = new Guid("bff63975-7641-445b-a526-7e12cd421a7e"),
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
				UId = new Guid("a302c4f1-905f-49fe-8ec4-c4ba7fc5c1ca"),
				ContainerUId = new Guid("bff63975-7641-445b-a526-7e12cd421a7e"),
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
				UId = new Guid("9753632e-eb3c-451b-922a-f34a9743b97e"),
				ContainerUId = new Guid("bff63975-7641-445b-a526-7e12cd421a7e"),
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

		protected virtual void InitializeGiveRightsToOwnerParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("06f32bdb-9ee2-46db-8d39-5c0ebc39ed25"),
				ContainerUId = new Guid("861a907f-8d89-4961-a75c-b5ea8d15568d"),
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
				Value = @"bfb313dd-bb55-4e1b-8e42-3d346e0da7c5",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1b719a91-d070-4e60-a646-559e44548e48"),
				ContainerUId = new Guid("861a907f-8d89-4961-a75c-b5ea8d15568d"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,203,106,220,48,20,253,23,45,186,146,138,108,201,122,184,203,97,90,102,147,134,54,45,133,100,8,122,92,101,4,126,76,108,153,38,152,249,247,202,227,76,10,89,148,210,93,65,11,221,43,157,163,115,15,71,243,125,28,63,198,38,193,80,7,211,140,128,167,157,175,145,41,125,201,132,172,8,19,32,8,231,188,32,186,228,146,128,100,90,85,148,89,8,28,225,206,180,80,163,21,189,245,49,33,28,19,180,99,125,59,255,38,77,195,4,248,62,156,139,175,238,0,173,249,182,60,96,131,101,5,243,158,88,91,85,132,67,97,137,2,94,18,230,25,23,64,189,145,174,66,171,22,107,104,62,86,64,164,207,183,184,160,21,209,180,210,68,42,37,164,227,50,0,80,132,27,8,105,251,116,28,96,28,99,223,213,51,188,238,111,158,143,89,229,250,246,166,111,166,182,67,184,133,100,174,77,58,228,73,129,2,175,156,33,142,235,44,36,128,36,134,105,79,152,177,178,148,10,10,81,72,132,157,57,166,133,22,237,60,194,222,36,243,221,52,19,156,153,231,152,53,150,140,22,170,18,25,91,48,71,56,43,41,81,66,73,18,188,8,26,152,208,218,250,139,95,159,166,152,247,113,188,154,90,24,162,123,177,29,178,127,253,80,207,174,239,210,208,55,11,245,213,249,250,13,60,165,213,220,151,163,31,235,64,41,247,23,16,58,225,105,132,77,19,161,75,219,206,245,62,118,15,43,231,233,148,33,237,209,12,113,188,184,176,125,156,76,131,240,16,31,14,127,116,107,51,141,169,111,255,163,81,113,30,51,115,228,144,157,229,46,25,244,113,60,54,230,249,92,215,232,221,227,212,167,15,95,192,245,131,223,249,181,66,111,80,53,186,67,210,202,64,173,206,65,43,4,203,105,11,134,104,165,40,145,154,59,69,29,167,57,114,119,40,43,249,71,254,219,221,248,249,103,119,249,11,171,250,253,251,220,125,211,184,190,32,235,249,111,36,157,246,139,168,253,41,175,95,21,93,69,91,210,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var deleteRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("53ae98a2-1434-4e56-92e4-392b7492161e"),
				ContainerUId = new Guid("861a907f-8d89-4961-a75c-b5ea8d15568d"),
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
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(deleteRightsParameter);
			var addRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c0b02be0-7324-41cb-a63d-7302690aac40"),
				ContainerUId = new Guid("861a907f-8d89-4961-a75c-b5ea8d15568d"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,93,143,81,107,194,48,20,133,255,74,169,175,141,180,54,105,146,190,186,110,8,99,14,133,189,136,15,55,201,141,6,210,84,98,234,16,241,191,175,58,216,195,222,238,119,56,231,112,207,238,182,50,109,174,25,149,149,90,0,177,32,21,161,148,11,162,120,37,137,21,0,82,210,70,151,32,242,98,9,97,131,96,218,20,71,124,64,103,92,250,131,23,244,152,240,23,183,195,24,53,182,121,157,23,111,17,66,194,233,238,250,147,31,174,136,121,241,1,253,196,187,217,110,246,104,203,92,184,12,78,227,252,213,197,115,202,92,194,62,27,108,22,241,60,250,228,194,33,211,131,247,168,147,27,194,124,253,29,48,206,246,179,125,94,124,129,31,127,91,86,231,167,188,213,71,236,161,181,224,207,184,159,79,234,63,161,243,216,99,72,237,13,4,47,117,165,145,40,11,37,161,70,40,34,148,172,136,109,24,103,37,42,13,192,239,83,224,19,226,244,104,194,216,222,120,205,56,231,165,157,140,140,18,218,168,146,8,208,13,145,180,146,182,194,90,176,202,60,34,93,72,46,93,151,131,31,251,208,222,116,109,22,200,106,32,172,108,22,132,202,186,36,96,64,19,174,149,54,210,212,150,9,125,127,142,89,159,48,194,99,225,198,29,142,233,29,47,232,219,124,145,223,247,63,45,166,252,10,158,1,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(addRightsParameter);
			var employee2Parameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("c5491b2a-fa9b-4478-b719-f8aa9946c0a8"),
				ContainerUId = new Guid("861a907f-8d89-4961-a75c-b5ea8d15568d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"Employee2",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			employee2Parameter.SourceValue = new ProcessSchemaParameterValue(employee2Parameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a870c1ce-bfa0-4d8b-8b91-f65750ebcaa7}].[Parameter:{7357770f-8b54-46b0-8ac6-9419f1e3851d}].[EntityColumn:{c3d2e53a-5062-4930-adac-7cbcd9d3f58c}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(employee2Parameter);
		}

		protected virtual void InitializeGiveRightsToVisaOwnerParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4b5986e6-7044-4e29-9c25-835d23c947d0"),
				ContainerUId = new Guid("7c567273-cb10-4531-ace7-344acf45ce1b"),
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
				Value = @"bfb313dd-bb55-4e1b-8e42-3d346e0da7c5",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e3405dd4-6438-45db-8a22-33f5fa053c32"),
				ContainerUId = new Guid("7c567273-cb10-4531-ace7-344acf45ce1b"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,203,106,220,48,20,253,23,45,186,178,138,52,146,245,112,151,195,180,204,38,13,109,90,10,201,16,244,184,206,8,252,138,37,211,4,51,255,94,121,156,73,33,139,82,186,43,104,161,123,165,115,116,238,225,104,190,15,241,99,104,18,140,85,109,154,8,197,180,247,21,242,130,41,101,173,195,68,91,139,57,101,22,107,206,36,166,86,73,34,55,178,38,194,160,162,51,45,84,104,69,239,124,72,168,8,9,218,88,221,206,191,73,211,56,65,113,95,159,139,175,238,8,173,249,182,60,96,107,203,40,243,30,91,91,150,152,3,181,88,1,223,96,230,25,23,64,188,145,174,68,171,22,43,137,3,166,9,174,149,160,89,11,55,88,151,148,97,170,25,213,84,155,146,234,124,181,129,58,237,158,134,17,98,12,125,87,205,240,186,191,121,30,178,202,245,237,109,223,76,109,135,138,22,146,185,54,233,88,33,3,4,120,233,12,118,92,103,33,53,72,108,152,246,152,25,155,231,84,64,5,149,168,112,102,72,11,45,218,123,84,120,147,204,119,211,76,112,102,158,67,214,184,97,132,170,82,100,44,101,14,115,182,33,88,9,37,113,237,69,173,129,9,173,173,191,248,245,105,10,121,31,226,213,212,194,24,220,139,237,144,253,235,199,106,118,125,151,198,190,89,168,175,206,215,111,224,41,173,230,190,28,253,88,7,74,185,191,128,208,169,152,34,108,155,0,93,218,117,174,247,161,123,88,57,79,167,12,105,7,51,134,120,113,97,247,56,153,6,21,99,120,56,254,209,173,237,20,83,223,254,71,163,22,121,204,204,145,67,118,150,187,100,208,135,56,52,230,249,92,87,232,221,227,212,167,15,95,192,245,163,223,251,181,66,111,80,21,186,67,210,230,112,91,189,132,94,48,204,69,157,211,166,20,193,82,115,167,136,227,68,58,126,135,178,146,127,228,191,221,199,207,63,187,203,95,88,213,31,222,231,238,155,198,245,5,89,205,127,35,233,116,88,68,29,78,121,253,2,230,55,85,86,210,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var deleteRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fe5895d5-2409-461c-8b7f-4db552d8ab2a"),
				ContainerUId = new Guid("7c567273-cb10-4531-ace7-344acf45ce1b"),
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
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(deleteRightsParameter);
			var addRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b5c1528f-4e52-4e27-b0ea-b872c51fb27f"),
				ContainerUId = new Guid("7c567273-cb10-4531-ace7-344acf45ce1b"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,93,143,205,106,195,48,16,132,95,37,40,87,43,200,177,236,216,186,149,54,148,64,105,138,3,189,4,31,214,210,168,49,200,63,40,74,74,9,121,247,42,105,123,233,109,102,150,97,246,219,95,54,70,49,139,214,146,149,196,101,81,73,46,117,169,57,9,43,121,149,234,212,20,148,106,164,130,37,143,52,212,32,163,130,63,225,102,214,166,11,202,146,59,222,221,19,28,2,126,253,110,60,121,13,197,50,150,60,123,26,2,162,174,71,7,150,188,82,31,245,126,190,155,160,59,251,53,163,105,242,227,153,220,108,34,31,79,1,254,184,152,61,220,67,248,121,195,146,119,114,167,123,99,191,57,110,63,7,248,157,62,160,167,159,161,102,17,211,127,193,218,161,199,16,212,165,204,10,77,34,82,173,74,27,209,116,4,34,41,43,46,243,12,136,144,109,161,205,53,22,222,254,150,213,5,194,152,101,106,91,158,153,60,229,82,162,228,109,153,75,46,32,86,186,44,132,129,172,174,205,237,173,237,4,79,161,27,135,186,251,56,132,23,156,225,20,91,178,107,243,13,110,9,203,148,82,1,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(addRightsParameter);
			var role1Parameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				UId = new Guid("febfaf4a-4694-4c8c-a0f4-91c1d6a1ce10"),
				ContainerUId = new Guid("7c567273-cb10-4531-ace7-344acf45ce1b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"Role1",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			role1Parameter.SourceValue = new ProcessSchemaParameterValue(role1Parameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{836ca04a-78fa-4cf4-a449-453ee4c8b6cd}].[Parameter:{e0dd21fb-3d51-44e8-b854-0e07c860de49}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			parametrizedElement.Parameters.Add(role1Parameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaInvoiceVisa = CreateInvoiceVisaLaneSet();
			LaneSets.Add(schemaInvoiceVisa);
			ProcessSchemaLane schemaInvoiceAuthor = CreateInvoiceAuthorLane();
			schemaInvoiceVisa.Lanes.Add(schemaInvoiceAuthor);
			ProcessSchemaSubProcess invoicevisasubprocess = CreateInvoiceVisaSubProcessSubProcess();
			FlowElements.Add(invoicevisasubprocess);
			ProcessSchemaStartEvent start = CreateStartStartEvent();
			FlowElements.Add(start);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaUserTask inputvisaparameters = CreateInputVisaParametersUserTask();
			FlowElements.Add(inputvisaparameters);
			ProcessSchemaUserTask forbitinvoicechange = CreateForbitInvoiceChangeUserTask();
			FlowElements.Add(forbitinvoicechange);
			ProcessSchemaUserTask readinvoice = CreateReadInvoiceUserTask();
			FlowElements.Add(readinvoice);
			ProcessSchemaUserTask sendemailtoowner = CreateSendEmailToOwnerUserTask();
			FlowElements.Add(sendemailtoowner);
			ProcessSchemaUserTask readowner = CreateReadOwnerUserTask();
			FlowElements.Add(readowner);
			ProcessSchemaFormulaTask emailbodyvisaapproved = CreateEmailBodyVisaApprovedFormulaTask();
			FlowElements.Add(emailbodyvisaapproved);
			ProcessSchemaFormulaTask emailbodyvisarejected = CreateEmailBodyVisaRejectedFormulaTask();
			FlowElements.Add(emailbodyvisarejected);
			ProcessSchemaFormulaTask emailsubjectvisaapproved = CreateEmailSubjectVisaApprovedFormulaTask();
			FlowElements.Add(emailsubjectvisaapproved);
			ProcessSchemaFormulaTask emailsubjectvisarejected = CreateEmailSubjectVisaRejectedFormulaTask();
			FlowElements.Add(emailsubjectvisarejected);
			ProcessSchemaUserTask giverightstoowner = CreateGiveRightsToOwnerUserTask();
			FlowElements.Add(giverightstoowner);
			ProcessSchemaTerminateEvent terminate3 = CreateTerminate3TerminateEvent();
			FlowElements.Add(terminate3);
			ProcessSchemaUserTask giverightstovisaowner = CreateGiveRightsToVisaOwnerUserTask();
			FlowElements.Add(giverightstovisaowner);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateConditionalFlow4ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateBodyRejectedLocalizableString());
			LocalizableStrings.Add(CreateSubjectRejectedLocalizableString());
			LocalizableStrings.Add(CreateBodyApprovedLocalizableString());
			LocalizableStrings.Add(CreateSubjectApprovedLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateBodyRejectedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2f319cdd-0193-4bfe-b079-559e1c30124f"),
				Name = "BodyRejected",
				CreatedInPackageId = new Guid("713adf76-4da1-47f0-97e7-6f284e391ea9"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSubjectRejectedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c716efe5-10f7-456c-8133-e895bfdb5be5"),
				Name = "SubjectRejected",
				CreatedInPackageId = new Guid("713adf76-4da1-47f0-97e7-6f284e391ea9"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateBodyApprovedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f94f0327-16e1-4334-b02a-7c721653c33b"),
				Name = "BodyApproved",
				CreatedInPackageId = new Guid("713adf76-4da1-47f0-97e7-6f284e391ea9"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSubjectApprovedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("cf129e95-c580-4e13-82b0-7a76b2bcadf1"),
				Name = "SubjectApproved",
				CreatedInPackageId = new Guid("713adf76-4da1-47f0-97e7-6f284e391ea9"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("6ac4d589-1703-4bd9-9a3f-88b534a48f9e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ed1b5d86-de48-4aad-b58a-ff58e682dbe0"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				CurveCenterPosition = new Point(245, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e046d5ca-5771-47ed-b113-a5824ad25bc6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("836ca04a-78fa-4cf4-a449-453ee4c8b6cd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("aba5b30f-9c17-4a77-bbec-1c8488f79339"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ed1b5d86-de48-4aad-b58a-ff58e682dbe0"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				CurveCenterPosition = new Point(312, 202),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("836ca04a-78fa-4cf4-a449-453ee4c8b6cd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a870c1ce-bfa0-4d8b-8b91-f65750ebcaa7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
				ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
					{new Guid("836ca04a-78fa-4cf4-a449-453ee4c8b6cd"), new Collection<Guid>() {
						new Guid("f3e3b4f4-4c3e-4efd-b334-bd6521c4fef7"),
					}},
				}
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("c109c02d-a7a5-43a6-85e7-7de3f50014f7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ed1b5d86-de48-4aad-b58a-ff58e682dbe0"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				CurveCenterPosition = new Point(428, 142),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("35a81948-7702-4db3-a7bf-3f258a365e3b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7c567273-cb10-4531-ace7-344acf45ce1b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("706847f9-0bfa-47b0-a228-e0d77a6e8acb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ed1b5d86-de48-4aad-b58a-ff58e682dbe0"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				CurveCenterPosition = new Point(446, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a870c1ce-bfa0-4d8b-8b91-f65750ebcaa7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bff63975-7641-445b-a526-7e12cd421a7e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("31dd8931-96c6-415d-90ff-536f846d4ec1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ed1b5d86-de48-4aad-b58a-ff58e682dbe0"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a4f303ab-3ca4-40cf-bd61-6c4b651a7584"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6bf142a4-d790-4de9-9883-b52824cb229a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("1fe18c6e-5fae-4cf2-abf4-49ce0f27ba8b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ed1b5d86-de48-4aad-b58a-ff58e682dbe0"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				CurveCenterPosition = new Point(446, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bff63975-7641-445b-a526-7e12cd421a7e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("35a81948-7702-4db3-a7bf-3f258a365e3b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("54de2b68-b576-47e4-9a47-a115f2533a10"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ed1b5d86-de48-4aad-b58a-ff58e682dbe0"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("63ea368e-bf20-4fc5-a69f-5863c7bd43bb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("60239cd9-2e10-49bd-a633-089150c684f8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("5ec9aa40-eeed-4cd1-b847-2403184673c9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ed1b5d86-de48-4aad-b58a-ff58e682dbe0"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				CurveCenterPosition = new Point(618, 232),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9e242f5f-62c8-4d23-b0b3-1f425b446b41"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3d69e54c-2a2f-4d7c-8fee-7e2cc579b767"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("7f3cd5bf-526f-46a2-839e-6b3179cef781"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ed1b5d86-de48-4aad-b58a-ff58e682dbe0"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("60239cd9-2e10-49bd-a633-089150c684f8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a4f303ab-3ca4-40cf-bd61-6c4b651a7584"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("2f16f1ec-3288-4324-af70-83a2b722a56f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ed1b5d86-de48-4aad-b58a-ff58e682dbe0"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				CurveCenterPosition = new Point(618, 232),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3d69e54c-2a2f-4d7c-8fee-7e2cc579b767"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("861a907f-8d89-4961-a75c-b5ea8d15568d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("50c11efd-97ee-4cff-9eb8-aab3aacded01"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8b83e365-44e9-4039-b573-f0156747e76b"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				CurveCenterPosition = new Point(618, 232),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("861a907f-8d89-4961-a75c-b5ea8d15568d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a4f303ab-3ca4-40cf-bd61-6c4b651a7584"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow4ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow4",
				UId = new Guid("9b782f6a-2b01-4398-babd-ec7161a1522d"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{542e8d6c-f4fa-4b4e-983a-9c865c132053}].[Parameter:{8f1116ee-11da-40ee-bb56-440bdf99b269}]#] == ""Approved""",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8b83e365-44e9-4039-b573-f0156747e76b"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				CurveCenterPosition = new Point(694, 162),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("542e8d6c-f4fa-4b4e-983a-9c865c132053"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("63ea368e-bf20-4fc5-a69f-5863c7bd43bb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow3",
				UId = new Guid("5316b598-2325-4f50-b2fd-af4afa22b081"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8b83e365-44e9-4039-b573-f0156747e76b"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				CurveCenterPosition = new Point(714, 176),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("542e8d6c-f4fa-4b4e-983a-9c865c132053"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("492364f3-9bfa-4554-b2f6-c86157c2f9e8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("0238eb90-0358-427e-b744-d6728b80e5fe"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{542e8d6c-f4fa-4b4e-983a-9c865c132053}].[Parameter:{8f1116ee-11da-40ee-bb56-440bdf99b269}]#]==""Rejected""",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8b83e365-44e9-4039-b573-f0156747e76b"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				CurveCenterPosition = new Point(707, 102),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("542e8d6c-f4fa-4b4e-983a-9c865c132053"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9e242f5f-62c8-4d23-b0b3-1f425b446b41"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("a25bf005-7191-430f-9e93-18b59af48bb5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("db5558b0-2d71-4fc8-90f8-eaabbf477ee7"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				CurveCenterPosition = new Point(428, 142),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7c567273-cb10-4531-ace7-344acf45ce1b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("542e8d6c-f4fa-4b4e-983a-9c865c132053"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateInvoiceVisaLaneSet() {
			ProcessSchemaLaneSet schemaInvoiceVisa = new ProcessSchemaLaneSet(this) {
				UId = new Guid("03fb0d25-b184-4f90-913b-f93ec8ee15fe"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ed1b5d86-de48-4aad-b58a-ff58e682dbe0"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"InvoiceVisa",
				Position = new Point(5, 5),
				Size = new Size(1412, 400),
				UseBackgroundMode = false
			};
			return schemaInvoiceVisa;
		}

		protected virtual ProcessSchemaLane CreateInvoiceAuthorLane() {
			ProcessSchemaLane schemaInvoiceAuthor = new ProcessSchemaLane(this) {
				UId = new Guid("6f0e3dff-cc26-4371-b613-19572ae3e120"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("03fb0d25-b184-4f90-913b-f93ec8ee15fe"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("ed1b5d86-de48-4aad-b58a-ff58e682dbe0"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"InvoiceAuthor",
				Position = new Point(29, 0),
				Size = new Size(1383, 400),
				UseBackgroundMode = false
			};
			return schemaInvoiceAuthor;
		}

		protected virtual ProcessSchemaStartEvent CreateStartStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("e046d5ca-5771-47ed-b113-a5824ad25bc6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f0e3dff-cc26-4371-b613-19572ae3e120"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ed1b5d86-de48-4aad-b58a-ff58e682dbe0"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"Start",
				Position = new Point(57, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("6bf142a4-d790-4de9-9883-b52824cb229a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f0e3dff-cc26-4371-b613-19572ae3e120"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ed1b5d86-de48-4aad-b58a-ff58e682dbe0"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"Terminate1",
				Position = new Point(1324, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateInputVisaParametersUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("836ca04a-78fa-4cf4-a449-453ee4c8b6cd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f0e3dff-cc26-4371-b613-19572ae3e120"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ed1b5d86-de48-4aad-b58a-ff58e682dbe0"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"InputVisaParameters",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(127, 156),
				SchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeInputVisaParametersParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateForbitInvoiceChangeUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("35a81948-7702-4db3-a7bf-3f258a365e3b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f0e3dff-cc26-4371-b613-19572ae3e120"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ed1b5d86-de48-4aad-b58a-ff58e682dbe0"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"ForbitInvoiceChange",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(484, 156),
				SchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeForbitInvoiceChangeParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadInvoiceUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("a870c1ce-bfa0-4d8b-8b91-f65750ebcaa7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f0e3dff-cc26-4371-b613-19572ae3e120"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ed1b5d86-de48-4aad-b58a-ff58e682dbe0"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"ReadInvoice",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(260, 156),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadInvoiceParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateSendEmailToOwnerUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("a4f303ab-3ca4-40cf-bd61-6c4b651a7584"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f0e3dff-cc26-4371-b613-19572ae3e120"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ed1b5d86-de48-4aad-b58a-ff58e682dbe0"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"SendEmailToOwner",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1198, 156),
				SchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeSendEmailToOwnerParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadOwnerUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("bff63975-7641-445b-a526-7e12cd421a7e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f0e3dff-cc26-4371-b613-19572ae3e120"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ed1b5d86-de48-4aad-b58a-ff58e682dbe0"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"ReadOwner",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(365, 156),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadOwnerParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateEmailBodyVisaApprovedFormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("63ea368e-bf20-4fc5-a69f-5863c7bd43bb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f0e3dff-cc26-4371-b613-19572ae3e120"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ed1b5d86-de48-4aad-b58a-ff58e682dbe0"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"EmailBodyVisaApproved",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(974, 156),
				ResultParameterMetaPath = @"74993b60-74e2-40cb-9814-23ff874d9202",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,203,177,106,195,48,16,128,225,87,41,100,105,33,23,36,71,210,201,222,154,144,64,167,22,58,6,15,39,233,212,6,44,57,200,74,74,48,121,247,186,107,215,159,255,155,106,57,231,175,205,113,44,137,234,243,110,12,247,215,203,165,140,55,14,235,167,211,234,244,54,189,255,100,46,159,254,155,19,117,145,134,137,251,205,82,255,133,195,192,137,115,237,102,178,40,188,244,12,46,146,0,21,172,3,235,90,9,209,104,212,130,157,39,194,199,2,62,168,80,226,202,165,155,113,171,17,81,196,101,212,10,148,113,2,44,121,3,173,146,109,148,188,181,90,134,63,114,200,245,92,239,251,113,184,166,220,205,49,4,68,178,13,68,106,52,40,191,248,86,5,3,218,248,40,26,173,116,35,227,163,95,245,47,191,47,228,82,128,225,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateEmailBodyVisaRejectedFormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("9e242f5f-62c8-4d23-b0b3-1f425b446b41"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f0e3dff-cc26-4371-b613-19572ae3e120"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ed1b5d86-de48-4aad-b58a-ff58e682dbe0"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"EmailBodyVisaRejected",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(862, 30),
				ResultParameterMetaPath = @"74993b60-74e2-40cb-9814-23ff874d9202",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,203,193,74,196,48,16,128,225,87,17,246,162,224,44,73,55,201,164,61,42,43,120,82,244,184,244,48,73,102,116,165,73,33,141,200,82,246,221,173,87,175,63,255,183,180,122,46,31,251,167,185,102,106,183,15,115,186,188,241,23,199,198,233,254,230,180,59,61,47,47,63,133,235,123,252,228,76,131,208,180,240,184,223,234,191,112,156,56,115,105,195,74,30,85,212,145,33,8,41,48,201,7,240,161,215,32,206,162,85,28,34,17,94,55,240,74,149,50,55,174,195,138,7,139,136,74,182,209,26,48,46,40,240,20,29,244,70,247,162,249,224,173,78,127,228,88,218,185,93,30,231,233,59,151,97,149,148,16,201,119,32,212,89,48,113,243,189,73,14,172,139,162,58,107,108,167,229,58,238,198,187,95,218,83,132,42,225,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateEmailSubjectVisaApprovedFormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("60239cd9-2e10-49bd-a633-089150c684f8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f0e3dff-cc26-4371-b613-19572ae3e120"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ed1b5d86-de48-4aad-b58a-ff58e682dbe0"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"EmailSubjectVisaApproved",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1086, 156),
				ResultParameterMetaPath = @"3cb8a4b7-f45b-44ff-b96d-91b115085a87",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,46,77,202,74,77,46,113,44,40,40,202,47,75,77,1,0,10,201,46,220,15,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateEmailSubjectVisaRejectedFormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("3d69e54c-2a2f-4d7c-8fee-7e2cc579b767"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f0e3dff-cc26-4371-b613-19572ae3e120"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ed1b5d86-de48-4aad-b58a-ff58e682dbe0"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"EmailSubjectVisaRejected",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(974, 30),
				ResultParameterMetaPath = @"3cb8a4b7-f45b-44ff-b96d-91b115085a87",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,46,77,202,74,77,46,9,74,5,145,169,41,0,18,77,35,34,15,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreateGiveRightsToOwnerUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("861a907f-8d89-4961-a75c-b5ea8d15568d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f0e3dff-cc26-4371-b613-19572ae3e120"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8b83e365-44e9-4039-b573-f0156747e76b"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"GiveRightsToOwner",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1086, 30),
				SchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeGiveRightsToOwnerParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaSubProcess CreateInvoiceVisaSubProcessSubProcess() {
			ProcessSchemaSubProcess schemaInvoiceVisaSubProcess = new ProcessSchemaSubProcess(this) {
				UId = new Guid("542e8d6c-f4fa-4b4e-983a-9c865c132053"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f0e3dff-cc26-4371-b613-19572ae3e120"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8b83e365-44e9-4039-b573-f0156747e76b"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"InvoiceVisaSubProcess",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(757, 156),
				SchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeInvoiceVisaSubProcessParameters(schemaInvoiceVisaSubProcess);
			return schemaInvoiceVisaSubProcess;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate3TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("492364f3-9bfa-4554-b2f6-c86157c2f9e8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f0e3dff-cc26-4371-b613-19572ae3e120"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8b83e365-44e9-4039-b573-f0156747e76b"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"Terminate3",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(778, 296),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateGiveRightsToVisaOwnerUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("7c567273-cb10-4531-ace7-344acf45ce1b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f0e3dff-cc26-4371-b613-19572ae3e120"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("db5558b0-2d71-4fc8-90f8-eaabbf477ee7"),
				CreatedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				ModifiedInSchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"),
				Name = @"GiveRightsToVisaOwner",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(610, 156),
				SchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeGiveRightsToVisaOwnerParameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new InvoiceVisaProcess(userConnection);
		}

		public override object Clone() {
			return new InvoiceVisaProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243"));
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceVisaProcess

	/// <exclude/>
	public class InvoiceVisaProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessInvoiceAuthor

		/// <exclude/>
		public class ProcessInvoiceAuthor : ProcessLane
		{

			public ProcessInvoiceAuthor(UserConnection userConnection, InvoiceVisaProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: InputVisaParametersFlowElement

		/// <exclude/>
		public class InputVisaParametersFlowElement : AutoGeneratedPageUserTask
		{

			#region Constructors: Public

			public InputVisaParametersFlowElement(UserConnection userConnection, InvoiceVisaProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "InputVisaParameters";
				IsLogging = true;
				SchemaElementUId = new Guid("836ca04a-78fa-4cf4-a449-453ee4c8b6cd");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.InvoiceAuthor;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private LocalizableString _title;
			public override LocalizableString Title {
				get {
					return _title ?? (_title = GetLocalizableString("332eac2514434e4ea9726c0e66cb9243",
						 "BaseElements.InputVisaParameters.Parameters.Title.Value"));
				}
				set {
					_title = value;
				}
			}

			private LocalizableString _buttons;
			public override LocalizableString Buttons {
				get {
					return _buttons ?? (_buttons = GetLocalizableString("332eac2514434e4ea9726c0e66cb9243",
						 "BaseElements.InputVisaParameters.Parameters.Buttons.Value"));
				}
				set {
					_buttons = value;
				}
			}

			private LocalizableString _elements;
			public override LocalizableString Elements {
				get {
					return _elements ?? (_elements = GetLocalizableString("332eac2514434e4ea9726c0e66cb9243",
						 "BaseElements.InputVisaParameters.Parameters.Elements.Value"));
				}
				set {
					_elements = value;
				}
			}

			public virtual Guid VisaOwner {
				get;
				set;
			}

			public virtual string Objective {
				get;
				set;
			}

			public virtual bool IsAllowedToDelegate {
				get;
				set;
			}

			#endregion

			#region Methods: Public

			public override string GetResultAllowedValues() {
				return "[\"f3e3b4f4-4c3e-4efd-b334-bd6521c4fef7\"]";
			}

			#endregion

		}

		#endregion

		#region Class: ForbitInvoiceChangeFlowElement

		/// <exclude/>
		public class ForbitInvoiceChangeFlowElement : ChangeAdminRightsUserTask
		{

			#region Constructors: Public

			public ForbitInvoiceChangeFlowElement(UserConnection userConnection, InvoiceVisaProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ForbitInvoiceChange";
				IsLogging = true;
				SchemaElementUId = new Guid("35a81948-7702-4db3-a7bf-3f258a365e3b");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,36,21,217,146,45,217,61,46,219,178,151,52,180,105,41,36,75,24,75,163,172,192,31,27,75,166,9,102,255,123,229,117,54,133,28,74,233,173,160,195,204,72,239,205,155,199,104,190,247,225,163,111,35,142,181,131,54,32,157,118,182,38,216,128,70,5,154,65,197,57,147,32,115,6,90,24,134,96,139,44,203,51,165,180,38,180,135,14,107,178,162,183,214,71,66,125,196,46,212,183,243,111,210,56,78,72,239,221,57,249,106,14,216,193,183,165,65,227,26,145,9,107,89,211,20,5,147,152,53,76,99,234,34,172,144,37,114,11,202,20,100,213,82,42,225,56,55,142,85,210,165,167,50,67,6,69,201,89,81,130,202,157,169,108,225,28,161,45,186,184,125,58,142,24,130,31,250,122,198,215,248,230,249,152,84,174,189,55,67,59,117,61,161,29,70,184,134,120,168,9,32,71,89,24,96,70,86,137,221,161,98,32,42,203,4,52,42,87,26,179,50,83,132,26,56,198,133,150,236,44,161,22,34,124,135,118,194,51,243,236,147,198,92,240,76,23,101,194,102,201,37,41,114,206,116,169,21,115,182,116,21,138,178,170,26,123,241,235,211,228,83,236,195,213,212,225,232,205,139,237,152,252,27,198,122,54,67,31,199,161,93,168,175,206,207,111,240,41,174,230,190,92,253,88,7,138,169,190,128,200,137,78,1,55,173,199,62,110,123,51,88,223,63,172,156,167,83,130,116,71,24,125,184,184,176,125,156,160,37,116,244,15,135,63,186,181,153,66,28,186,255,104,84,154,198,76,28,105,201,206,114,151,29,180,62,28,91,120,62,231,53,121,247,56,13,241,195,23,52,195,104,119,118,205,200,27,84,77,238,136,106,148,227,77,213,48,153,149,130,201,210,1,171,180,230,76,85,210,104,110,36,87,70,222,145,164,228,31,249,111,119,225,243,207,254,242,23,86,245,251,247,169,250,166,112,125,65,214,243,223,72,58,237,23,81,251,83,58,191,0,218,18,108,245,210,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private string _deleteRights;
			public override string DeleteRights {
				get {
					return _deleteRights ?? (_deleteRights = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,37,137,189,10,194,48,16,128,95,37,100,78,160,218,88,66,182,162,34,46,14,21,39,113,184,230,46,32,196,20,46,201,36,190,187,253,217,190,159,231,247,138,78,182,118,12,93,59,162,134,125,103,181,9,120,208,224,97,38,99,125,211,144,53,38,128,84,71,72,3,1,186,0,49,211,98,103,124,23,87,184,174,114,162,72,133,54,189,79,149,61,57,185,147,234,194,144,10,205,220,199,56,76,145,114,159,240,145,137,179,84,55,248,108,93,240,50,4,36,20,117,93,191,215,31,121,168,35,25,152,0,0,0 })));
				}
				set {
					_deleteRights = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadInvoiceFlowElement

		/// <exclude/>
		public class ReadInvoiceFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadInvoiceFlowElement(UserConnection userConnection, InvoiceVisaProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadInvoice";
				IsLogging = true;
				SchemaElementUId = new Guid("a870c1ce-bfa0-4d8b-8b91-f65750ebcaa7");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,77,107,220,48,16,134,255,139,14,61,89,197,182,100,75,118,143,203,182,236,37,13,109,90,10,201,18,244,49,147,21,248,43,150,76,19,140,255,123,229,117,54,133,28,74,233,173,224,131,52,246,251,206,51,47,227,249,222,249,143,174,9,48,214,168,26,15,201,116,176,53,169,16,11,212,136,52,71,97,40,47,165,166,90,27,164,74,20,178,64,196,210,170,148,36,157,106,161,38,155,122,111,93,32,137,11,208,250,250,118,254,109,26,198,9,146,123,60,95,190,154,19,180,234,219,218,64,163,102,25,179,54,218,22,5,229,144,105,42,129,231,148,89,198,75,72,173,18,166,32,27,139,22,140,149,85,193,41,72,180,148,219,28,169,206,13,167,185,1,99,57,51,185,145,150,36,13,96,216,63,13,35,120,239,250,174,158,225,245,124,243,60,68,202,173,247,174,111,166,182,35,73,11,65,93,171,112,170,137,130,20,120,97,20,53,188,138,32,8,130,42,86,89,202,148,22,185,144,144,149,153,32,137,81,67,88,109,201,33,182,178,42,168,239,170,153,224,236,60,187,200,152,179,52,147,69,25,181,25,139,121,177,60,165,178,148,130,162,45,177,130,136,95,105,123,201,235,211,228,226,217,249,171,169,133,209,153,151,216,33,230,215,143,245,108,250,46,140,125,179,90,95,157,63,191,129,167,176,133,251,242,234,199,54,80,136,245,85,68,150,100,242,176,107,28,116,97,223,153,222,186,238,97,243,92,150,40,105,7,53,58,127,73,97,255,56,169,134,36,163,123,56,253,49,173,221,228,67,223,254,71,163,38,113,204,232,17,151,236,140,187,238,160,117,126,104,212,243,249,94,147,119,143,83,31,62,124,1,211,143,246,96,183,27,121,163,170,201,29,17,90,96,170,43,77,121,86,178,184,249,168,104,37,101,74,69,197,141,76,13,79,133,225,119,36,146,252,163,255,237,193,127,254,217,93,254,133,141,254,248,62,86,223,20,174,47,202,122,254,27,164,229,184,66,29,151,248,252,2,36,175,107,249,210,3,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,43,205,77,74,45,178,50,180,50,212,241,76,177,50,176,50,0,0,237,33,101,51,17,0,0,0 })));
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
								new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"));
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

		#region Class: SendEmailToOwnerFlowElement

		/// <exclude/>
		public class SendEmailToOwnerFlowElement : SendEmailUserTask
		{

			#region Constructors: Public

			public SendEmailToOwnerFlowElement(UserConnection userConnection, InvoiceVisaProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SendEmailToOwner";
				IsLogging = true;
				SchemaElementUId = new Guid("a4f303ab-3ca4-40cf-bd61-6c4b651a7584");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recepient = () => new LocalizableString(((process.ReadOwner.ResultEntity.IsColumnValueLoaded(process.ReadOwner.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? process.ReadOwner.ResultEntity.GetTypedColumnValue<string>("Email") : null)));
				_subject = () => new LocalizableString((process.EmailSubject));
				_body = () => new LocalizableString((process.EmailBody));
			}

			#endregion

			#region Properties: Public

			internal Func<string> _recepient;
			public override string Recepient {
				get {
					return (_recepient ?? (_recepient = () => null)).Invoke();
				}
				set {
					_recepient = () => { return value; };
				}
			}

			internal Func<LocalizableString> _subject;
			public override LocalizableString Subject {
				get {
					return (_subject ?? (_subject = () => null)).Invoke();
				}
				set {
					_subject = () => { return value; };
				}
			}

			internal Func<LocalizableString> _body;
			public override LocalizableString Body {
				get {
					return (_body ?? (_body = () => null)).Invoke();
				}
				set {
					_body = () => { return value; };
				}
			}

			private bool _isIgnoreErrors = true;
			public override bool IsIgnoreErrors {
				get {
					return _isIgnoreErrors;
				}
				set {
					_isIgnoreErrors = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadOwnerFlowElement

		/// <exclude/>
		public class ReadOwnerFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadOwnerFlowElement(UserConnection userConnection, InvoiceVisaProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadOwner";
				IsLogging = true;
				SchemaElementUId = new Guid("bff63975-7641-445b-a526-7e12cd421a7e");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,77,107,220,48,16,134,255,202,162,67,79,214,34,89,214,151,123,12,155,146,75,26,218,180,4,146,16,244,49,74,4,254,216,216,114,155,96,246,191,87,94,39,45,228,80,114,42,20,124,144,37,189,239,204,60,154,153,239,226,120,26,155,4,67,29,76,51,66,49,157,249,26,41,21,20,40,77,176,178,212,226,74,16,157,87,186,196,37,81,86,18,47,5,169,2,42,58,211,66,141,86,245,206,199,132,138,152,160,29,235,235,249,143,105,26,38,40,238,194,241,231,171,123,128,214,124,91,2,80,97,129,9,78,177,10,80,226,138,242,28,192,123,130,141,34,204,87,66,49,239,25,90,115,41,1,40,39,170,196,18,180,198,85,0,192,154,82,141,93,169,109,101,43,89,6,97,81,209,64,72,187,167,253,0,227,24,251,174,158,225,247,250,242,121,159,179,92,99,159,244,205,212,118,168,104,33,153,11,147,30,106,100,128,64,197,157,193,174,210,124,113,151,216,48,237,49,51,86,150,82,1,21,84,162,194,153,125,90,108,209,153,71,133,55,201,124,55,205,4,71,231,57,46,57,50,66,21,23,89,75,153,195,21,43,51,57,161,36,14,94,4,157,11,213,218,250,87,94,159,166,152,215,113,60,159,90,24,162,123,193,14,153,95,63,212,179,235,187,52,244,205,98,125,126,188,126,9,79,105,133,251,114,116,181,22,148,242,254,34,66,135,98,26,225,164,137,208,165,93,231,122,31,187,251,213,243,112,200,146,118,111,134,56,190,82,216,61,78,166,65,197,16,239,31,254,74,235,100,26,83,223,254,71,165,22,185,204,236,145,155,236,152,238,210,131,62,142,251,198,60,31,255,107,244,225,113,234,211,199,47,96,252,38,118,63,250,232,96,123,26,135,49,109,150,150,221,244,97,147,235,159,154,148,29,55,174,111,26,112,203,123,111,63,255,236,96,88,165,232,77,136,26,221,32,163,36,113,212,1,182,193,16,92,121,101,151,49,161,56,8,46,57,1,235,140,145,91,201,184,148,146,132,124,196,171,60,75,54,3,51,78,96,93,81,29,40,48,197,169,223,58,230,75,224,204,96,78,68,158,7,205,242,40,120,227,176,116,214,121,237,89,224,202,221,160,12,224,95,148,117,125,54,30,111,172,51,179,18,190,221,230,221,55,27,187,6,218,252,20,245,252,30,14,135,44,184,120,13,85,207,239,161,178,72,118,93,138,233,121,157,219,220,50,239,192,116,184,93,64,221,30,242,247,11,94,131,101,143,221,4,0,0 })));
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

		#region Class: GiveRightsToOwnerFlowElement

		/// <exclude/>
		public class GiveRightsToOwnerFlowElement : ChangeAdminRightsUserTask
		{

			#region Constructors: Public

			public GiveRightsToOwnerFlowElement(UserConnection userConnection, InvoiceVisaProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "GiveRightsToOwner";
				IsLogging = true;
				SchemaElementUId = new Guid("861a907f-8d89-4961-a75c-b5ea8d15568d");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_employee2 = () => (Guid)(((process.ReadInvoice.ResultEntity.IsColumnValueLoaded(process.ReadInvoice.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadInvoice.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
			}

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,203,106,220,48,20,253,23,45,186,146,138,108,201,122,184,203,97,90,102,147,134,54,45,133,100,8,122,92,101,4,126,76,108,153,38,152,249,247,202,227,76,10,89,148,210,93,65,11,221,43,157,163,115,15,71,243,125,28,63,198,38,193,80,7,211,140,128,167,157,175,145,41,125,201,132,172,8,19,32,8,231,188,32,186,228,146,128,100,90,85,148,89,8,28,225,206,180,80,163,21,189,245,49,33,28,19,180,99,125,59,255,38,77,195,4,248,62,156,139,175,238,0,173,249,182,60,96,131,101,5,243,158,88,91,85,132,67,97,137,2,94,18,230,25,23,64,189,145,174,66,171,22,107,104,62,86,64,164,207,183,184,160,21,209,180,210,68,42,37,164,227,50,0,80,132,27,8,105,251,116,28,96,28,99,223,213,51,188,238,111,158,143,89,229,250,246,166,111,166,182,67,184,133,100,174,77,58,228,73,129,2,175,156,33,142,235,44,36,128,36,134,105,79,152,177,178,148,10,10,81,72,132,157,57,166,133,22,237,60,194,222,36,243,221,52,19,156,153,231,152,53,150,140,22,170,18,25,91,48,71,56,43,41,81,66,73,18,188,8,26,152,208,218,250,139,95,159,166,152,247,113,188,154,90,24,162,123,177,29,178,127,253,80,207,174,239,210,208,55,11,245,213,249,250,13,60,165,213,220,151,163,31,235,64,41,247,23,16,58,225,105,132,77,19,161,75,219,206,245,62,118,15,43,231,233,148,33,237,209,12,113,188,184,176,125,156,76,131,240,16,31,14,127,116,107,51,141,169,111,255,163,81,113,30,51,115,228,144,157,229,46,25,244,113,60,54,230,249,92,215,232,221,227,212,167,15,95,192,245,131,223,249,181,66,111,80,53,186,67,210,202,64,173,206,65,43,4,203,105,11,134,104,165,40,145,154,59,69,29,167,57,114,119,40,43,249,71,254,219,221,248,249,103,119,249,11,171,250,253,251,220,125,211,184,190,32,235,249,111,36,157,246,139,168,253,41,175,95,21,93,69,91,210,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private string _addRights;
			public override string AddRights {
				get {
					return _addRights ?? (_addRights = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,93,143,81,107,194,48,20,133,255,74,169,175,141,180,54,105,146,190,186,110,8,99,14,133,189,136,15,55,201,141,6,210,84,98,234,16,241,191,175,58,216,195,222,238,119,56,231,112,207,238,182,50,109,174,25,149,149,90,0,177,32,21,161,148,11,162,120,37,137,21,0,82,210,70,151,32,242,98,9,97,131,96,218,20,71,124,64,103,92,250,131,23,244,152,240,23,183,195,24,53,182,121,157,23,111,17,66,194,233,238,250,147,31,174,136,121,241,1,253,196,187,217,110,246,104,203,92,184,12,78,227,252,213,197,115,202,92,194,62,27,108,22,241,60,250,228,194,33,211,131,247,168,147,27,194,124,253,29,48,206,246,179,125,94,124,129,31,127,91,86,231,167,188,213,71,236,161,181,224,207,184,159,79,234,63,161,243,216,99,72,237,13,4,47,117,165,145,40,11,37,161,70,40,34,148,172,136,109,24,103,37,42,13,192,239,83,224,19,226,244,104,194,216,222,120,205,56,231,165,157,140,140,18,218,168,146,8,208,13,145,180,146,182,194,90,176,202,60,34,93,72,46,93,151,131,31,251,208,222,116,109,22,200,106,32,172,108,22,132,202,186,36,96,64,19,174,149,54,210,212,150,9,125,127,142,89,159,48,194,99,225,198,29,142,233,29,47,232,219,124,145,223,247,63,45,166,252,10,158,1,0,0 })));
				}
				set {
					_addRights = value;
				}
			}

			internal Func<Guid> _employee2;
			public virtual Guid Employee2 {
				get {
					return (_employee2 ?? (_employee2 = () => Guid.Empty)).Invoke();
				}
				set {
					_employee2 = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		#region Class: InvoiceVisaSubProcessFlowElement

		/// <exclude/>
		public class InvoiceVisaSubProcessFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public InvoiceVisaSubProcessFlowElement(UserConnection userConnection, InvoiceVisaProcess process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c");
			}

			#endregion

			#region Properties: Public

			public Guid Invoice {
				get {
					return GetParameterValue<Guid>("Invoice");
				}
				set {
					SetParameterValue("Invoice", value);
				}
			}

			public Guid VisaOwner {
				get {
					return GetParameterValue<Guid>("VisaOwner");
				}
				set {
					SetParameterValue("VisaOwner", value);
				}
			}

			public string VisaObjective {
				get {
					return GetParameterValue<string>("VisaObjective");
				}
				set {
					SetParameterValue("VisaObjective", value);
				}
			}

			public string VisaResult {
				get {
					return GetParameterValue<string>("VisaResult");
				}
				set {
					SetParameterValue("VisaResult", value);
				}
			}

			public bool IsAllowedToDelegate {
				get {
					return GetParameterValue<bool>("IsAllowedToDelegate");
				}
				set {
					SetParameterValue("IsAllowedToDelegate", value);
				}
			}

			public bool IsPreviousVisaCounts {
				get {
					return GetParameterValue<bool>("IsPreviousVisaCounts");
				}
				set {
					SetParameterValue("IsPreviousVisaCounts", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (InvoiceVisaProcess)owner;
				Name = "InvoiceVisaSubProcess";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("542e8d6c-f4fa-4b4e-983a-9c865c132053");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.InvoiceAuthor;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (InvoiceVisaProcess)Owner;
				SetParameterValue("Invoice", (Guid)((process.RecordId)));
				SetParameterValue("VisaOwner", (Guid)((process.InputVisaParameters.VisaOwner)));
				SetParameterValue("VisaObjective", new LocalizableString((process.InputVisaParameters.Objective)));
				SetParameterValue("IsAllowedToDelegate", (bool)((process.InputVisaParameters.IsAllowedToDelegate)));
				SetParameterValue("IsPreviousVisaCounts", (bool)(false));
			}

			#endregion

		}

		#endregion

		#region Class: GiveRightsToVisaOwnerFlowElement

		/// <exclude/>
		public class GiveRightsToVisaOwnerFlowElement : ChangeAdminRightsUserTask
		{

			#region Constructors: Public

			public GiveRightsToVisaOwnerFlowElement(UserConnection userConnection, InvoiceVisaProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "GiveRightsToVisaOwner";
				IsLogging = true;
				SchemaElementUId = new Guid("7c567273-cb10-4531-ace7-344acf45ce1b");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_role1 = () => (Guid)((process.InputVisaParameters.VisaOwner));
			}

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,203,106,220,48,20,253,23,45,186,178,138,52,146,245,112,151,195,180,204,38,13,109,90,10,201,16,244,184,206,8,252,138,37,211,4,51,255,94,121,156,73,33,139,82,186,43,104,161,123,165,115,116,238,225,104,190,15,241,99,104,18,140,85,109,154,8,197,180,247,21,242,130,41,101,173,195,68,91,139,57,101,22,107,206,36,166,86,73,34,55,178,38,194,160,162,51,45,84,104,69,239,124,72,168,8,9,218,88,221,206,191,73,211,56,65,113,95,159,139,175,238,8,173,249,182,60,96,107,203,40,243,30,91,91,150,152,3,181,88,1,223,96,230,25,23,64,188,145,174,68,171,22,43,137,3,166,9,174,149,160,89,11,55,88,151,148,97,170,25,213,84,155,146,234,124,181,129,58,237,158,134,17,98,12,125,87,205,240,186,191,121,30,178,202,245,237,109,223,76,109,135,138,22,146,185,54,233,88,33,3,4,120,233,12,118,92,103,33,53,72,108,152,246,152,25,155,231,84,64,5,149,168,112,102,72,11,45,218,123,84,120,147,204,119,211,76,112,102,158,67,214,184,97,132,170,82,100,44,101,14,115,182,33,88,9,37,113,237,69,173,129,9,173,173,191,248,245,105,10,121,31,226,213,212,194,24,220,139,237,144,253,235,199,106,118,125,151,198,190,89,168,175,206,215,111,224,41,173,230,190,28,253,88,7,74,185,191,128,208,169,152,34,108,155,0,93,218,117,174,247,161,123,88,57,79,167,12,105,7,51,134,120,113,97,247,56,153,6,21,99,120,56,254,209,173,237,20,83,223,254,71,163,22,121,204,204,145,67,118,150,187,100,208,135,56,52,230,249,92,87,232,221,227,212,167,15,95,192,245,163,223,251,181,66,111,80,21,186,67,210,230,112,91,189,132,94,48,204,69,157,211,166,20,193,82,115,167,136,227,68,58,126,135,178,146,127,228,191,221,199,207,63,187,203,95,88,213,31,222,231,238,155,198,245,5,89,205,127,35,233,116,88,68,29,78,121,253,2,230,55,85,86,210,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private string _addRights;
			public override string AddRights {
				get {
					return _addRights ?? (_addRights = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,93,143,205,106,195,48,16,132,95,37,40,87,43,200,177,236,216,186,149,54,148,64,105,138,3,189,4,31,214,210,168,49,200,63,40,74,74,9,121,247,42,105,123,233,109,102,150,97,246,219,95,54,70,49,139,214,146,149,196,101,81,73,46,117,169,57,9,43,121,149,234,212,20,148,106,164,130,37,143,52,212,32,163,130,63,225,102,214,166,11,202,146,59,222,221,19,28,2,126,253,110,60,121,13,197,50,150,60,123,26,2,162,174,71,7,150,188,82,31,245,126,190,155,160,59,251,53,163,105,242,227,153,220,108,34,31,79,1,254,184,152,61,220,67,248,121,195,146,119,114,167,123,99,191,57,110,63,7,248,157,62,160,167,159,161,102,17,211,127,193,218,161,199,16,212,165,204,10,77,34,82,173,74,27,209,116,4,34,41,43,46,243,12,136,144,109,161,205,53,22,222,254,150,213,5,194,152,101,106,91,158,153,60,229,82,162,228,109,153,75,46,32,86,186,44,132,129,172,174,205,237,173,237,4,79,161,27,135,186,251,56,132,23,156,225,20,91,178,107,243,13,110,9,203,148,82,1,0,0 })));
				}
				set {
					_addRights = value;
				}
			}

			internal Func<Guid> _role1;
			public virtual Guid Role1 {
				get {
					return (_role1 ?? (_role1 = () => Guid.Empty)).Invoke();
				}
				set {
					_role1 = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		public InvoiceVisaProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "InvoiceVisaProcess";
			SchemaUId = new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243");
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
				return new Guid("332eac25-1443-4e4e-a972-6c0e66cb9243");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: InvoiceVisaProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: InvoiceVisaProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual string EmailBody {
			get;
			set;
		}

		public virtual string EmailSubject {
			get;
			set;
		}

		public virtual Guid RecordId {
			get;
			set;
		}

		private ProcessInvoiceAuthor _invoiceAuthor;
		public ProcessInvoiceAuthor InvoiceAuthor {
			get {
				return _invoiceAuthor ?? ((_invoiceAuthor) = new ProcessInvoiceAuthor(UserConnection, this));
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
					SchemaElementUId = new Guid("e046d5ca-5771-47ed-b113-a5824ad25bc6"),
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
					SchemaElementUId = new Guid("6bf142a4-d790-4de9-9883-b52824cb229a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private InputVisaParametersFlowElement _inputVisaParameters;
		public InputVisaParametersFlowElement InputVisaParameters {
			get {
				return _inputVisaParameters ?? (_inputVisaParameters = new InputVisaParametersFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ForbitInvoiceChangeFlowElement _forbitInvoiceChange;
		public ForbitInvoiceChangeFlowElement ForbitInvoiceChange {
			get {
				return _forbitInvoiceChange ?? (_forbitInvoiceChange = new ForbitInvoiceChangeFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadInvoiceFlowElement _readInvoice;
		public ReadInvoiceFlowElement ReadInvoice {
			get {
				return _readInvoice ?? (_readInvoice = new ReadInvoiceFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private SendEmailToOwnerFlowElement _sendEmailToOwner;
		public SendEmailToOwnerFlowElement SendEmailToOwner {
			get {
				return _sendEmailToOwner ?? (_sendEmailToOwner = new SendEmailToOwnerFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadOwnerFlowElement _readOwner;
		public ReadOwnerFlowElement ReadOwner {
			get {
				return _readOwner ?? (_readOwner = new ReadOwnerFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _emailBodyVisaApproved;
		public ProcessScriptTask EmailBodyVisaApproved {
			get {
				return _emailBodyVisaApproved ?? (_emailBodyVisaApproved = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "EmailBodyVisaApproved",
					SchemaElementUId = new Guid("63ea368e-bf20-4fc5-a69f-5863c7bd43bb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = EmailBodyVisaApprovedExecute,
				});
			}
		}

		private ProcessScriptTask _emailBodyVisaRejected;
		public ProcessScriptTask EmailBodyVisaRejected {
			get {
				return _emailBodyVisaRejected ?? (_emailBodyVisaRejected = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "EmailBodyVisaRejected",
					SchemaElementUId = new Guid("9e242f5f-62c8-4d23-b0b3-1f425b446b41"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = EmailBodyVisaRejectedExecute,
				});
			}
		}

		private ProcessScriptTask _emailSubjectVisaApproved;
		public ProcessScriptTask EmailSubjectVisaApproved {
			get {
				return _emailSubjectVisaApproved ?? (_emailSubjectVisaApproved = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "EmailSubjectVisaApproved",
					SchemaElementUId = new Guid("60239cd9-2e10-49bd-a633-089150c684f8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = EmailSubjectVisaApprovedExecute,
				});
			}
		}

		private ProcessScriptTask _emailSubjectVisaRejected;
		public ProcessScriptTask EmailSubjectVisaRejected {
			get {
				return _emailSubjectVisaRejected ?? (_emailSubjectVisaRejected = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "EmailSubjectVisaRejected",
					SchemaElementUId = new Guid("3d69e54c-2a2f-4d7c-8fee-7e2cc579b767"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = EmailSubjectVisaRejectedExecute,
				});
			}
		}

		private GiveRightsToOwnerFlowElement _giveRightsToOwner;
		public GiveRightsToOwnerFlowElement GiveRightsToOwner {
			get {
				return _giveRightsToOwner ?? (_giveRightsToOwner = new GiveRightsToOwnerFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private InvoiceVisaSubProcessFlowElement _invoiceVisaSubProcess;
		public InvoiceVisaSubProcessFlowElement InvoiceVisaSubProcess {
			get {
				return _invoiceVisaSubProcess ?? ((_invoiceVisaSubProcess) = new InvoiceVisaSubProcessFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessTerminateEvent _terminate3;
		public ProcessTerminateEvent Terminate3 {
			get {
				return _terminate3 ?? (_terminate3 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate3",
					SchemaElementUId = new Guid("492364f3-9bfa-4554-b2f6-c86157c2f9e8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private GiveRightsToVisaOwnerFlowElement _giveRightsToVisaOwner;
		public GiveRightsToVisaOwnerFlowElement GiveRightsToVisaOwner {
			get {
				return _giveRightsToVisaOwner ?? (_giveRightsToVisaOwner = new GiveRightsToVisaOwnerFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("aba5b30f-9c17-4a77-bbec-1c8488f79339"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("836ca04a-78fa-4cf4-a449-453ee4c8b6cd"), new Collection<Guid>() {
							new Guid("f3e3b4f4-4c3e-4efd-b334-bd6521c4fef7"),
						}},
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
					SchemaElementUId = new Guid("9b782f6a-2b01-4398-babd-ec7161a1522d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
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
					SchemaElementUId = new Guid("0238eb90-0358-427e-b744-d6728b80e5fe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessToken _giveRightsToVisaOwnerInvoiceVisaSubProcessToken;
		public ProcessToken GiveRightsToVisaOwnerInvoiceVisaSubProcessToken {
			get {
				return _giveRightsToVisaOwnerInvoiceVisaSubProcessToken ?? (_giveRightsToVisaOwnerInvoiceVisaSubProcessToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "GiveRightsToVisaOwnerInvoiceVisaSubProcessToken",
					SchemaElementUId = new Guid("1dca7ff9-93f5-4c11-a1e7-393b71e81a65"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private LocalizableString _bodyRejected;
		public LocalizableString BodyRejected {
			get {
				return _bodyRejected ?? (_bodyRejected = new LocalizableString(Storage, Schema.GetResourceManagerName(), "LocalizableStrings.BodyRejected.Value"));
			}
		}

		private LocalizableString _subjectRejected;
		public LocalizableString SubjectRejected {
			get {
				return _subjectRejected ?? (_subjectRejected = new LocalizableString(Storage, Schema.GetResourceManagerName(), "LocalizableStrings.SubjectRejected.Value"));
			}
		}

		private LocalizableString _bodyApproved;
		public LocalizableString BodyApproved {
			get {
				return _bodyApproved ?? (_bodyApproved = new LocalizableString(Storage, Schema.GetResourceManagerName(), "LocalizableStrings.BodyApproved.Value"));
			}
		}

		private LocalizableString _subjectApproved;
		public LocalizableString SubjectApproved {
			get {
				return _subjectApproved ?? (_subjectApproved = new LocalizableString(Storage, Schema.GetResourceManagerName(), "LocalizableStrings.SubjectApproved.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start.SchemaElementUId] = new Collection<ProcessFlowElement> { Start };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[InputVisaParameters.SchemaElementUId] = new Collection<ProcessFlowElement> { InputVisaParameters };
			FlowElements[ForbitInvoiceChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ForbitInvoiceChange };
			FlowElements[ReadInvoice.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadInvoice };
			FlowElements[SendEmailToOwner.SchemaElementUId] = new Collection<ProcessFlowElement> { SendEmailToOwner };
			FlowElements[ReadOwner.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadOwner };
			FlowElements[EmailBodyVisaApproved.SchemaElementUId] = new Collection<ProcessFlowElement> { EmailBodyVisaApproved };
			FlowElements[EmailBodyVisaRejected.SchemaElementUId] = new Collection<ProcessFlowElement> { EmailBodyVisaRejected };
			FlowElements[EmailSubjectVisaApproved.SchemaElementUId] = new Collection<ProcessFlowElement> { EmailSubjectVisaApproved };
			FlowElements[EmailSubjectVisaRejected.SchemaElementUId] = new Collection<ProcessFlowElement> { EmailSubjectVisaRejected };
			FlowElements[GiveRightsToOwner.SchemaElementUId] = new Collection<ProcessFlowElement> { GiveRightsToOwner };
			FlowElements[InvoiceVisaSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { InvoiceVisaSubProcess };
			FlowElements[Terminate3.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate3 };
			FlowElements[GiveRightsToVisaOwner.SchemaElementUId] = new Collection<ProcessFlowElement> { GiveRightsToVisaOwner };
			FlowElements[GiveRightsToVisaOwnerInvoiceVisaSubProcessToken.SchemaElementUId] = new Collection<ProcessFlowElement> { GiveRightsToVisaOwnerInvoiceVisaSubProcessToken };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("InputVisaParameters", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "InputVisaParameters":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadInvoice", e.Context.SenderName));
							break;
						}
						Log.ErrorFormat(DeadEndGatewayLogMessage, "InputVisaParameters");
						break;
					case "ForbitInvoiceChange":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("GiveRightsToVisaOwner", e.Context.SenderName));
						break;
					case "ReadInvoice":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadOwner", e.Context.SenderName));
						break;
					case "SendEmailToOwner":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ReadOwner":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ForbitInvoiceChange", e.Context.SenderName));
						break;
					case "EmailBodyVisaApproved":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("EmailSubjectVisaApproved", e.Context.SenderName));
						break;
					case "EmailBodyVisaRejected":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("EmailSubjectVisaRejected", e.Context.SenderName));
						break;
					case "EmailSubjectVisaApproved":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SendEmailToOwner", e.Context.SenderName));
						break;
					case "EmailSubjectVisaRejected":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("GiveRightsToOwner", e.Context.SenderName));
						break;
					case "GiveRightsToOwner":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SendEmailToOwner", e.Context.SenderName));
						break;
					case "InvoiceVisaSubProcess":
						if (ConditionalFlow4ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("EmailBodyVisaApproved", e.Context.SenderName));
							break;
						}
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("EmailBodyVisaRejected", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate3", e.Context.SenderName));
						break;
					case "Terminate3":
						CompleteProcess();
						break;
					case "GiveRightsToVisaOwner":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("GiveRightsToVisaOwnerInvoiceVisaSubProcessToken", e.Context.SenderName));
						break;
					case "GiveRightsToVisaOwnerInvoiceVisaSubProcessToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("InvoiceVisaSubProcess", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlow2ExpressionExecute() {
			bool result = InputVisaParameters.PressedButtonCode == @"ButtonOk";
			Log.InfoFormat(ConditionalExpressionLogMessage, "InputVisaParameters", "ConditionalFlow2", "InputVisaParameters.PressedButtonCode == @\"ButtonOk\"", result);
			Log.Info($"InputVisaParameters.PressedButtonCode: {InputVisaParameters.PressedButtonCode}");
			return result;
		}

		private bool ConditionalFlow4ExpressionExecute() {
			bool result = Convert.ToBoolean((InvoiceVisaSubProcess.VisaResult) == "Approved");
			Log.InfoFormat(ConditionalExpressionLogMessage, "InvoiceVisaSubProcess", "ConditionalFlow4", "(InvoiceVisaSubProcess.VisaResult) == \"Approved\"", result);
			return result;
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean((InvoiceVisaSubProcess.VisaResult)=="Rejected");
			Log.InfoFormat(ConditionalExpressionLogMessage, "InvoiceVisaSubProcess", "ConditionalFlow1", "(InvoiceVisaSubProcess.VisaResult)==\"Rejected\"", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("InputVisaParameters.VisaOwner")) {
				writer.WriteValue("InputVisaParameters.VisaOwner", InputVisaParameters.VisaOwner, Guid.Empty);
			}
			if (!HasMapping("InputVisaParameters.Objective")) {
				writer.WriteValue("InputVisaParameters.Objective", InputVisaParameters.Objective, null);
			}
			if (!HasMapping("InputVisaParameters.IsAllowedToDelegate")) {
				writer.WriteValue("InputVisaParameters.IsAllowedToDelegate", InputVisaParameters.IsAllowedToDelegate, false);
			}
			if (!HasMapping("GiveRightsToOwner.Employee2")) {
				writer.WriteValue("GiveRightsToOwner.Employee2", GiveRightsToOwner.Employee2, Guid.Empty);
			}
			if (!HasMapping("GiveRightsToVisaOwner.Role1")) {
				writer.WriteValue("GiveRightsToVisaOwner.Role1", GiveRightsToVisaOwner.Role1, Guid.Empty);
			}
			if (!HasMapping("EmailBody")) {
				writer.WriteValue("EmailBody", EmailBody, null);
			}
			if (!HasMapping("EmailSubject")) {
				writer.WriteValue("EmailSubject", EmailSubject, null);
			}
			if (!HasMapping("RecordId")) {
				writer.WriteValue("RecordId", RecordId, Guid.Empty);
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
			MetaPathParameterValues.Add("74993b60-74e2-40cb-9814-23ff874d9202", () => EmailBody);
			MetaPathParameterValues.Add("3cb8a4b7-f45b-44ff-b96d-91b115085a87", () => EmailSubject);
			MetaPathParameterValues.Add("7b7f0b9b-4163-46fa-9880-794c80c407c4", () => RecordId);
			MetaPathParameterValues.Add("15e74ec5-0326-4f08-8eff-34dd48372d46", () => InputVisaParameters.Title);
			MetaPathParameterValues.Add("03bf1a8c-ab55-4047-aa71-9f75cf806d53", () => InputVisaParameters.EntitySchemaUId);
			MetaPathParameterValues.Add("6fda6d18-1dcb-4cdc-beb8-3d93131256a5", () => InputVisaParameters.Recommendation);
			MetaPathParameterValues.Add("af3a440c-346a-45ea-b989-ad9edad884e9", () => InputVisaParameters.EntityId);
			MetaPathParameterValues.Add("64a3cca3-4c10-4274-aef0-5a1ef5d6712f", () => InputVisaParameters.Buttons);
			MetaPathParameterValues.Add("67d2763d-f0c5-4de5-be15-11bb62ecf373", () => InputVisaParameters.Elements);
			MetaPathParameterValues.Add("05607c13-cca8-4ff4-9db7-ca1b00e9d924", () => InputVisaParameters.ExtendedClientModule);
			MetaPathParameterValues.Add("2c1c4abc-e8a6-48a5-bc00-7f05f8db1732", () => InputVisaParameters.EntryPointId);
			MetaPathParameterValues.Add("d649bbc1-42b3-4dd3-b3f4-288751672e90", () => InputVisaParameters.PressedButtonCode);
			MetaPathParameterValues.Add("c36b3fbb-0cda-4054-9d6c-3f2764a2a299", () => InputVisaParameters.OwnerId);
			MetaPathParameterValues.Add("2f5005e0-98ac-49c4-95a3-093aed380ddb", () => InputVisaParameters.ShowExecutionPage);
			MetaPathParameterValues.Add("f789c4c3-1f20-4baa-9abc-19ae652beb7b", () => InputVisaParameters.InformationOnStep);
			MetaPathParameterValues.Add("2a68b2b8-60a8-47eb-873f-949b07b7200c", () => InputVisaParameters.IsRunning);
			MetaPathParameterValues.Add("e0dd21fb-3d51-44e8-b854-0e07c860de49", () => InputVisaParameters.VisaOwner);
			MetaPathParameterValues.Add("4e06d591-5e64-4ada-8d8c-ecc485ed6411", () => InputVisaParameters.Objective);
			MetaPathParameterValues.Add("e4157d41-c7c0-423c-90ea-9b31a9527bea", () => InputVisaParameters.IsAllowedToDelegate);
			MetaPathParameterValues.Add("6410dd64-cb18-4b43-92d8-ea4e92452489", () => ForbitInvoiceChange.EntitySchemaUId);
			MetaPathParameterValues.Add("5aca796c-35c6-418a-9deb-b088a8f677dc", () => ForbitInvoiceChange.DataSourceFilters);
			MetaPathParameterValues.Add("24dfe4df-9bb5-49a4-95db-61542b4948d1", () => ForbitInvoiceChange.DeleteRights);
			MetaPathParameterValues.Add("00434e0c-82ed-4624-aecf-e0253c869124", () => ForbitInvoiceChange.AddRights);
			MetaPathParameterValues.Add("eb5c0633-71b5-4885-bf63-9348c6e716fe", () => ReadInvoice.DataSourceFilters);
			MetaPathParameterValues.Add("df762cbe-8d50-45aa-a692-fc3ca13753f4", () => ReadInvoice.ResultType);
			MetaPathParameterValues.Add("0e9f1193-9fc1-4b4b-8432-b733eba80912", () => ReadInvoice.ReadSomeTopRecords);
			MetaPathParameterValues.Add("9d143566-7ff6-4ddc-91a8-d591f09cd961", () => ReadInvoice.NumberOfRecords);
			MetaPathParameterValues.Add("e5201aee-681b-4744-8a31-9ddd18e21086", () => ReadInvoice.FunctionType);
			MetaPathParameterValues.Add("11075dd3-15ea-48cc-bc90-e0d56c7659c3", () => ReadInvoice.AggregationColumnName);
			MetaPathParameterValues.Add("9cc48116-aeb9-466b-8bfc-4e956a8a224a", () => ReadInvoice.OrderInfo);
			MetaPathParameterValues.Add("7357770f-8b54-46b0-8ac6-9419f1e3851d", () => ReadInvoice.ResultEntity);
			MetaPathParameterValues.Add("8a5724d5-1ff6-487b-9fc6-200c9ad0f055", () => ReadInvoice.ResultCount);
			MetaPathParameterValues.Add("ba20003a-340e-46d9-a946-c7b838095ecf", () => ReadInvoice.ResultIntegerFunction);
			MetaPathParameterValues.Add("449de235-c6b7-424f-85d8-fb162b49bb7b", () => ReadInvoice.ResultFloatFunction);
			MetaPathParameterValues.Add("ba4dd278-a683-4a23-bb70-76dbea3a6008", () => ReadInvoice.ResultDateTimeFunction);
			MetaPathParameterValues.Add("88ad9c3b-a5af-4854-a28b-1335fb70031e", () => ReadInvoice.ResultRowsCount);
			MetaPathParameterValues.Add("e8e6e487-50e1-4bf3-8f69-9a817f3ab435", () => ReadInvoice.CanReadUncommitedData);
			MetaPathParameterValues.Add("221e16c4-8293-45d9-8259-d695e5af79eb", () => ReadInvoice.ResultEntityCollection);
			MetaPathParameterValues.Add("43a99aa6-4673-4153-a178-a5b9790d2ad5", () => ReadInvoice.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("c85fb573-bcfe-41e9-a9a9-27b68c96c857", () => ReadInvoice.IgnoreDisplayValues);
			MetaPathParameterValues.Add("95fb85e2-48cd-487b-8b32-017ae2bde0ef", () => ReadInvoice.ResultCompositeObjectList);
			MetaPathParameterValues.Add("f2e1aba9-04eb-49bb-b534-e8dcc3aad782", () => ReadInvoice.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("e23b91be-231f-435f-8517-737db19c220d", () => SendEmailToOwner.Sender);
			MetaPathParameterValues.Add("eafc53b1-5965-4420-91e0-d855598a9606", () => SendEmailToOwner.Recepient);
			MetaPathParameterValues.Add("5267c7f6-bd77-4ed7-824c-b431dbd24c08", () => SendEmailToOwner.CopyRecepient);
			MetaPathParameterValues.Add("fe9744a9-7550-407f-802d-aa723487447d", () => SendEmailToOwner.BlindCopyRecepient);
			MetaPathParameterValues.Add("d722c459-1025-4d56-86cc-230572deb759", () => SendEmailToOwner.Subject);
			MetaPathParameterValues.Add("62b9d136-3ff8-48ad-91e5-9dc61486aef5", () => SendEmailToOwner.Body);
			MetaPathParameterValues.Add("0ededcb2-d1f2-4ed5-8714-1a853d7276ec", () => SendEmailToOwner.Importance);
			MetaPathParameterValues.Add("ed7f847d-ac6b-4f96-880b-b96226ea317b", () => SendEmailToOwner.IsIgnoreErrors);
			MetaPathParameterValues.Add("8584ab53-ba83-4f42-a7bc-feab37d28011", () => ReadOwner.DataSourceFilters);
			MetaPathParameterValues.Add("c376d60e-a7a4-4e19-bd8a-dae2932a0e78", () => ReadOwner.ResultType);
			MetaPathParameterValues.Add("9f2bb0a7-bb26-44d6-982d-bae251821d05", () => ReadOwner.ReadSomeTopRecords);
			MetaPathParameterValues.Add("8891e889-db66-4762-9171-8140dd7cf232", () => ReadOwner.NumberOfRecords);
			MetaPathParameterValues.Add("5d406829-cb2c-4bc8-aee9-9b1c2127c6fd", () => ReadOwner.FunctionType);
			MetaPathParameterValues.Add("cb921596-274f-4b21-8c44-b212fc1920ca", () => ReadOwner.AggregationColumnName);
			MetaPathParameterValues.Add("f1ff7012-8664-41bf-9c72-c0b8ed663964", () => ReadOwner.OrderInfo);
			MetaPathParameterValues.Add("31f0b17f-eb70-4992-b1b1-bca006ff0170", () => ReadOwner.ResultEntity);
			MetaPathParameterValues.Add("aa386400-da48-4c38-ad31-fc6fc0b48215", () => ReadOwner.ResultCount);
			MetaPathParameterValues.Add("d69de283-3768-4fed-88cf-ba8a30d46115", () => ReadOwner.ResultIntegerFunction);
			MetaPathParameterValues.Add("d49960ad-0a29-4f36-993a-f6d4071447e8", () => ReadOwner.ResultFloatFunction);
			MetaPathParameterValues.Add("2170fceb-72f6-4c84-8877-fe0d9df8d2db", () => ReadOwner.ResultDateTimeFunction);
			MetaPathParameterValues.Add("2af17b6f-5672-4495-9124-0e90d072d034", () => ReadOwner.ResultRowsCount);
			MetaPathParameterValues.Add("ac4a8ce3-7747-409c-9280-55e75a467639", () => ReadOwner.CanReadUncommitedData);
			MetaPathParameterValues.Add("9d748d72-4039-430d-9516-9bf95155fd9b", () => ReadOwner.ResultEntityCollection);
			MetaPathParameterValues.Add("c3c00126-734d-41e9-bf79-8da33bbe8ad7", () => ReadOwner.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("3ae21b6c-fec9-4c92-9a29-c7820bacc7cd", () => ReadOwner.IgnoreDisplayValues);
			MetaPathParameterValues.Add("a302c4f1-905f-49fe-8ec4-c4ba7fc5c1ca", () => ReadOwner.ResultCompositeObjectList);
			MetaPathParameterValues.Add("9753632e-eb3c-451b-922a-f34a9743b97e", () => ReadOwner.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("06f32bdb-9ee2-46db-8d39-5c0ebc39ed25", () => GiveRightsToOwner.EntitySchemaUId);
			MetaPathParameterValues.Add("1b719a91-d070-4e60-a646-559e44548e48", () => GiveRightsToOwner.DataSourceFilters);
			MetaPathParameterValues.Add("53ae98a2-1434-4e56-92e4-392b7492161e", () => GiveRightsToOwner.DeleteRights);
			MetaPathParameterValues.Add("c0b02be0-7324-41cb-a63d-7302690aac40", () => GiveRightsToOwner.AddRights);
			MetaPathParameterValues.Add("c5491b2a-fa9b-4478-b719-f8aa9946c0a8", () => GiveRightsToOwner.Employee2);
			MetaPathParameterValues.Add("3cff9b6a-3056-44a8-9a1f-c6bfec3caa52", () => InvoiceVisaSubProcess.Invoice);
			MetaPathParameterValues.Add("3056cd61-172a-449e-999b-ce78323fd7ec", () => InvoiceVisaSubProcess.VisaOwner);
			MetaPathParameterValues.Add("9b499fc0-a472-4fc1-8168-5a7f139ed935", () => InvoiceVisaSubProcess.VisaObjective);
			MetaPathParameterValues.Add("8f1116ee-11da-40ee-bb56-440bdf99b269", () => InvoiceVisaSubProcess.VisaResult);
			MetaPathParameterValues.Add("7ef81b65-2836-4432-b1da-f17b53c9a6de", () => InvoiceVisaSubProcess.IsAllowedToDelegate);
			MetaPathParameterValues.Add("1f29d0dc-0ab8-4b13-a121-53bd4037b40d", () => InvoiceVisaSubProcess.IsPreviousVisaCounts);
			MetaPathParameterValues.Add("4b5986e6-7044-4e29-9c25-835d23c947d0", () => GiveRightsToVisaOwner.EntitySchemaUId);
			MetaPathParameterValues.Add("e3405dd4-6438-45db-8a22-33f5fa053c32", () => GiveRightsToVisaOwner.DataSourceFilters);
			MetaPathParameterValues.Add("fe5895d5-2409-461c-8b7f-4db552d8ab2a", () => GiveRightsToVisaOwner.DeleteRights);
			MetaPathParameterValues.Add("b5c1528f-4e52-4e27-b0ea-b872c51fb27f", () => GiveRightsToVisaOwner.AddRights);
			MetaPathParameterValues.Add("febfaf4a-4694-4c8c-a0f4-91c1d6a1ce10", () => GiveRightsToVisaOwner.Role1);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "InputVisaParameters.VisaOwner":
					InputVisaParameters.VisaOwner = reader.GetValue<System.Guid>();
				break;
				case "InputVisaParameters.Objective":
					InputVisaParameters.Objective = reader.GetValue<System.String>();
				break;
				case "InputVisaParameters.IsAllowedToDelegate":
					InputVisaParameters.IsAllowedToDelegate = reader.GetValue<System.Boolean>();
				break;
				case "GiveRightsToOwner.Employee2":
					GiveRightsToOwner.Employee2 = reader.GetValue<System.Guid>();
				break;
				case "GiveRightsToVisaOwner.Role1":
					GiveRightsToVisaOwner.Role1 = reader.GetValue<System.Guid>();
				break;
				case "EmailBody":
					if (!hasValueToRead) break;
					EmailBody = reader.GetValue<System.String>();
				break;
				case "EmailSubject":
					if (!hasValueToRead) break;
					EmailSubject = reader.GetValue<System.String>();
				break;
				case "RecordId":
					if (!hasValueToRead) break;
					RecordId = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool EmailBodyVisaApprovedExecute(ProcessExecutingContext context) {
			var localEmailBody = string.Format(BodyApproved, ((ReadInvoice.ResultEntity.IsColumnValueLoaded(ReadInvoice.ResultEntity.Schema.Columns.GetByName("Number").ColumnValueName) ? ReadInvoice.ResultEntity.GetTypedColumnValue<string>("Number") : null)));
			EmailBody = (System.String)localEmailBody;
			return true;
		}

		public virtual bool EmailBodyVisaRejectedExecute(ProcessExecutingContext context) {
			var localEmailBody = string.Format(BodyRejected, ((ReadInvoice.ResultEntity.IsColumnValueLoaded(ReadInvoice.ResultEntity.Schema.Columns.GetByName("Number").ColumnValueName) ? ReadInvoice.ResultEntity.GetTypedColumnValue<string>("Number") : null)));
			EmailBody = (System.String)localEmailBody;
			return true;
		}

		public virtual bool EmailSubjectVisaApprovedExecute(ProcessExecutingContext context) {
			var localEmailSubject = SubjectApproved;
			EmailSubject = (System.String)localEmailSubject;
			return true;
		}

		public virtual bool EmailSubjectVisaRejectedExecute(ProcessExecutingContext context) {
			var localEmailSubject = SubjectRejected;
			EmailSubject = (System.String)localEmailSubject;
			return true;
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
			var cloneItem = (InvoiceVisaProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

