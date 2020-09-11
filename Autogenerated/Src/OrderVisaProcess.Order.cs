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

	#region Class: OrderVisaProcessSchema

	/// <exclude/>
	public class OrderVisaProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public OrderVisaProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public OrderVisaProcessSchema(OrderVisaProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OrderVisaProcess";
			UId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47");
			CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27");
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
			RealUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47");
			Version = 0;
			PackageUId = new Guid("ef11e995-ba92-40e9-9077-1a6fee8d4c35");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateEmailBodyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3be84f48-2ec9-45e3-9957-5bc4267296c5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Name = @"EmailBody",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEmailSubjectParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f5a0902d-7693-4996-b837-c4f23f36f0e4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Name = @"EmailSubject",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateRecordIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("dcab9004-d6b0-4591-adc4-bf85fdcda9ac"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
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

		protected virtual void InitializeOrderVisaSubProcessParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var orderParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f55702a5-89cb-4603-a337-bbf985ba4fd9"),
				ContainerUId = new Guid("cc939664-f533-46cb-97ba-222f10143fcf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"Order",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			orderParameter.SourceValue = new ProcessSchemaParameterValue(orderParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{dcab9004-d6b0-4591-adc4-bf85fdcda9ac}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(orderParameter);
			var visaOwnerParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				UId = new Guid("0aabfff9-93ff-46e0-bd91-bd4a90083993"),
				ContainerUId = new Guid("cc939664-f533-46cb-97ba-222f10143fcf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"VisaOwner",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			visaOwnerParameter.SourceValue = new ProcessSchemaParameterValue(visaOwnerParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{974a113f-ac5d-468d-8ecb-ebd004bb94e9}].[Parameter:{48e0d754-08c0-40a9-9d39-60666bfa2ce8}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(visaOwnerParameter);
			var visaObjectiveParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4460c79c-4faf-42e4-bc80-b7e9caa8d023"),
				ContainerUId = new Guid("cc939664-f533-46cb-97ba-222f10143fcf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"VisaObjective",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText")
			};
			visaObjectiveParameter.SourceValue = new ProcessSchemaParameterValue(visaObjectiveParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{974a113f-ac5d-468d-8ecb-ebd004bb94e9}].[Parameter:{cb3cea56-7d6a-486a-9408-7f11b73730cd}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(visaObjectiveParameter);
			var visaResultParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0e8d8a98-20fb-40c2-92ba-536a8b9a9263"),
				ContainerUId = new Guid("cc939664-f533-46cb-97ba-222f10143fcf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
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
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be")
			};
			parametrizedElement.Parameters.Add(visaResultParameter);
			var isAllowedToDelegateParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1cc8b94b-0076-4f89-9664-ce3c3049d133"),
				ContainerUId = new Guid("cc939664-f533-46cb-97ba-222f10143fcf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"IsAllowedToDelegate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isAllowedToDelegateParameter.SourceValue = new ProcessSchemaParameterValue(isAllowedToDelegateParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{974a113f-ac5d-468d-8ecb-ebd004bb94e9}].[Parameter:{5aa0f7c2-d6d9-45eb-9d46-002d2f9f7ef5}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(isAllowedToDelegateParameter);
			var isPreviousVisaCountsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("10e3cea0-d69d-4274-83e4-5d162e3671d9"),
				ContainerUId = new Guid("cc939664-f533-46cb-97ba-222f10143fcf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(isPreviousVisaCountsParameter);
		}

		protected virtual void InitializeAutoGeneratedPageUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var titleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7d5d0c86-68d0-40b8-b86e-948614c80619"),
				ContainerUId = new Guid("974a113f-ac5d-468d-8ecb-ebd004bb94e9"),
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(titleParameter);
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("e685a7b9-94b0-4438-b0c5-243b4f6a690e"),
				ContainerUId = new Guid("974a113f-ac5d-468d-8ecb-ebd004bb94e9"),
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b0717664-6354-45ab-bd3c-53fe9b7c8b78"),
				ContainerUId = new Guid("974a113f-ac5d-468d-8ecb-ebd004bb94e9"),
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
				UId = new Guid("6c67afa0-5b6b-4e31-bc55-82a4883ce328"),
				ContainerUId = new Guid("974a113f-ac5d-468d-8ecb-ebd004bb94e9"),
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(entityIdParameter);
			var buttonsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f4ee6415-c497-4e78-a929-febe1125aac3"),
				ContainerUId = new Guid("974a113f-ac5d-468d-8ecb-ebd004bb94e9"),
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
				Value = @"{""$type"":""System.Collections.Generic.List`1[[System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib]], mscorlib"",""$values"":[{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""dd340939-b2f0-473c-8b99-ea9e4352ee64"",""name"":""ButtonOk"",""caption"":""Save"",""style"":""green"",""performValidation"":true,""isEnabled"":true,""generateSignal"":""""}]}",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(buttonsParameter);
			var elementsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dd2f6a69-a67d-4da1-b6d3-eb804984848e"),
				ContainerUId = new Guid("974a113f-ac5d-468d-8ecb-ebd004bb94e9"),
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
				Value = @"{""$type"":""System.Collections.Generic.List`1[[System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib]], mscorlib"",""$values"":[{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""48e0d754-08c0-40a9-9d39-60666bfa2ce8"",""name"":""VisaOwner"",""caption"":""Approver"",""controlEditType"":""SelectionField"",""isRequired"":true,""dataFilter"":"""",""controlDataValueType"":""10"",""dataSource"":""84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""cb3cea56-7d6a-486a-9408-7f11b73730cd"",""name"":""Objective"",""caption"":""Approval objective"",""controlEditType"":""1"",""isMultiline"":true,""isRequired"":false},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""5aa0f7c2-d6d9-45eb-9d46-002d2f9f7ef5"",""name"":""IsAllowedToDelegate"",""caption"":""Delegation permitted"",""controlEditType"":""12""}]}",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(elementsParameter);
			var extendedClientModuleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("de9d4b1e-dc1e-405b-ad5e-155376db49f5"),
				ContainerUId = new Guid("974a113f-ac5d-468d-8ecb-ebd004bb94e9"),
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(extendedClientModuleParameter);
			var entryPointIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ffeb48c9-a70a-4533-b631-94d55a3f5993"),
				ContainerUId = new Guid("974a113f-ac5d-468d-8ecb-ebd004bb94e9"),
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
				UId = new Guid("71c1b336-d3e4-4fea-ae5f-fe4c6a6099fa"),
				ContainerUId = new Guid("974a113f-ac5d-468d-8ecb-ebd004bb94e9"),
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
				UId = new Guid("6444f7f7-650a-40b8-9eae-e9eb023ee67c"),
				ContainerUId = new Guid("974a113f-ac5d-468d-8ecb-ebd004bb94e9"),
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
				UId = new Guid("54530a2b-97d6-474a-9038-ac4b4ad703ab"),
				ContainerUId = new Guid("974a113f-ac5d-468d-8ecb-ebd004bb94e9"),
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
				UId = new Guid("170a5e21-3611-43ae-8fd7-1be80e149ed9"),
				ContainerUId = new Guid("974a113f-ac5d-468d-8ecb-ebd004bb94e9"),
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
				UId = new Guid("ac69f773-300c-46c8-b710-efaa4c62ec0b"),
				ContainerUId = new Guid("974a113f-ac5d-468d-8ecb-ebd004bb94e9"),
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
				UId = new Guid("48e0d754-08c0-40a9-9d39-60666bfa2ce8"),
				ContainerUId = new Guid("974a113f-ac5d-468d-8ecb-ebd004bb94e9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(visaOwnerParameter);
			var objectiveParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cb3cea56-7d6a-486a-9408-7f11b73730cd"),
				ContainerUId = new Guid("974a113f-ac5d-468d-8ecb-ebd004bb94e9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(objectiveParameter);
			var isAllowedToDelegateParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5aa0f7c2-d6d9-45eb-9d46-002d2f9f7ef5"),
				ContainerUId = new Guid("974a113f-ac5d-468d-8ecb-ebd004bb94e9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(isAllowedToDelegateParameter);
		}

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("47332adc-637c-4b3a-808e-39197ef2431d"),
				ContainerUId = new Guid("f556c035-c4ad-4b5a-9e40-2435f02b99e3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,79,107,220,48,16,197,191,139,14,61,89,69,182,100,201,114,143,203,182,236,37,13,109,90,10,201,18,198,210,56,43,240,191,88,50,77,48,254,238,149,215,217,20,114,40,165,183,130,15,154,177,223,211,111,30,227,249,222,249,143,174,9,56,150,53,52,30,147,233,96,75,162,52,214,200,57,210,148,23,130,10,158,23,180,210,70,81,129,140,9,83,43,84,146,147,164,131,22,75,178,169,247,214,5,146,184,128,173,47,111,231,223,166,97,156,48,185,175,207,197,87,115,194,22,190,173,23,20,44,211,34,47,50,202,100,149,83,81,3,80,40,242,154,114,158,113,204,115,46,43,149,146,141,69,138,140,89,134,72,77,154,73,42,140,172,168,70,5,212,72,105,25,88,81,241,60,178,52,88,135,253,211,48,162,247,174,239,202,25,95,207,55,207,67,164,220,238,222,245,205,212,118,36,105,49,192,53,132,83,73,0,25,138,220,68,59,161,87,16,84,20,184,182,148,67,165,50,85,96,42,83,69,18,3,67,88,109,201,193,146,196,66,128,239,208,76,120,118,158,93,100,204,56,75,139,92,70,109,202,77,204,43,99,180,144,133,162,181,149,181,70,46,181,174,236,37,175,79,147,139,103,231,175,166,22,71,103,94,98,199,152,95,63,150,179,233,187,48,246,205,106,125,117,254,252,6,159,194,22,238,203,171,31,219,64,33,246,87,17,89,146,201,227,174,113,216,133,125,103,122,235,186,135,205,115,89,162,164,29,96,116,254,146,194,254,113,130,134,36,163,123,56,253,49,173,221,228,67,223,254,71,163,38,113,204,232,17,151,236,140,187,238,160,117,126,104,224,249,92,151,228,221,227,212,135,15,95,208,244,163,61,216,173,34,111,84,37,185,35,214,64,165,227,146,83,43,43,70,69,174,83,10,214,8,90,213,113,61,173,177,160,193,220,145,72,242,143,254,183,7,255,249,103,119,249,23,54,250,227,251,216,125,211,184,190,40,203,249,111,144,150,227,10,117,92,226,243,11,251,145,172,118,210,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5e08c82f-f563-4b4f-b5de-a3106f4c302c"),
				ContainerUId = new Guid("f556c035-c4ad-4b5a-9e40-2435f02b99e3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("67079823-ca29-4171-98e9-2eb22d596163"),
				ContainerUId = new Guid("f556c035-c4ad-4b5a-9e40-2435f02b99e3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b31d769e-31c1-4e18-b3fc-0e74bfbefd63"),
				ContainerUId = new Guid("f556c035-c4ad-4b5a-9e40-2435f02b99e3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("088b2d27-0d05-40fb-ae62-f22fc1d90d83"),
				ContainerUId = new Guid("f556c035-c4ad-4b5a-9e40-2435f02b99e3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4ba624fc-7ec2-45d2-8d59-eef1c3cb9809"),
				ContainerUId = new Guid("f556c035-c4ad-4b5a-9e40-2435f02b99e3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("912cfc03-f375-49d8-a280-eac85b844d25"),
				ContainerUId = new Guid("f556c035-c4ad-4b5a-9e40-2435f02b99e3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				UId = new Guid("f9db3fa8-979f-46f4-b673-16c1853c0ae6"),
				ContainerUId = new Guid("f556c035-c4ad-4b5a-9e40-2435f02b99e3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2220dcad-7243-4a68-b0b9-2d67a4ce1199"),
				ContainerUId = new Guid("f556c035-c4ad-4b5a-9e40-2435f02b99e3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("aac3176b-4b48-4126-ae99-fbe31bd9fb86"),
				ContainerUId = new Guid("f556c035-c4ad-4b5a-9e40-2435f02b99e3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("9715e434-be86-4b63-8778-cd749be859b9"),
				ContainerUId = new Guid("f556c035-c4ad-4b5a-9e40-2435f02b99e3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("39be95a0-1ca9-49e4-a8a3-923dd3e29e03"),
				ContainerUId = new Guid("f556c035-c4ad-4b5a-9e40-2435f02b99e3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("3d04bdfa-d07c-4250-b41d-c15861060bee"),
				ContainerUId = new Guid("f556c035-c4ad-4b5a-9e40-2435f02b99e3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("71a1e3c8-62e8-4d9e-849a-8f297265d848"),
				ContainerUId = new Guid("f556c035-c4ad-4b5a-9e40-2435f02b99e3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				UId = new Guid("b428b93e-5086-4d8a-bc68-88b7aa053524"),
				ContainerUId = new Guid("f556c035-c4ad-4b5a-9e40-2435f02b99e3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d3a1b1f9-bf92-4481-a5e5-c9e7b75cb477"),
				ContainerUId = new Guid("f556c035-c4ad-4b5a-9e40-2435f02b99e3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5b9f0015-f772-42da-baec-7aac33c39049"),
				ContainerUId = new Guid("f556c035-c4ad-4b5a-9e40-2435f02b99e3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("45dffa51-3539-4fdd-8cb4-25f3363526bf"),
				ContainerUId = new Guid("f556c035-c4ad-4b5a-9e40-2435f02b99e3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("d9b534da-5393-42f1-be32-e6cc6675654a"),
				ContainerUId = new Guid("f556c035-c4ad-4b5a-9e40-2435f02b99e3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeReadDataUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c2832253-8b80-4bd4-9059-3d26e46fa2b9"),
				ContainerUId = new Guid("1229c735-09aa-4ee5-8525-7e5e900b27a5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,77,107,220,48,16,134,255,202,162,67,79,214,34,91,178,44,185,199,176,41,185,164,161,77,75,161,9,97,44,141,18,129,63,54,182,76,19,150,253,239,29,175,155,22,114,40,185,244,80,48,66,146,245,206,204,251,104,116,184,139,211,121,108,19,142,117,128,118,194,108,190,240,53,19,6,155,188,48,37,87,78,52,52,20,138,67,131,138,163,46,154,74,32,250,208,84,44,235,161,195,154,173,234,157,143,137,101,49,97,55,213,223,15,127,130,166,113,198,236,46,156,22,159,221,3,118,240,101,73,144,235,6,165,46,115,110,2,22,92,229,165,229,198,123,193,193,8,233,149,54,210,123,201,214,90,156,18,165,65,109,56,128,167,163,190,12,220,186,220,113,111,141,119,21,228,121,16,138,101,45,134,180,123,218,143,56,77,113,232,235,3,254,158,95,63,239,169,202,53,247,217,208,206,93,207,178,14,19,92,65,122,168,25,160,64,85,58,224,78,89,178,27,176,226,32,173,231,18,154,170,168,12,230,58,39,167,14,246,105,9,203,46,60,203,60,36,248,10,237,140,167,200,135,72,53,22,82,228,166,212,164,205,165,227,74,22,130,27,109,42,30,188,14,150,140,90,219,248,23,94,31,230,72,243,56,93,206,29,142,209,253,194,142,196,111,24,235,131,27,250,52,14,237,18,250,242,116,252,26,159,210,10,247,215,175,111,171,161,68,251,139,136,29,179,121,194,179,54,98,159,118,189,27,124,236,239,215,152,199,35,73,186,61,140,113,122,161,176,123,156,161,101,217,24,239,31,254,74,235,108,158,210,208,253,71,86,51,178,73,49,168,201,78,229,46,61,232,227,180,111,225,249,180,174,217,187,199,121,72,239,63,33,248,205,48,122,28,183,231,113,156,210,102,105,216,205,16,54,228,126,110,19,197,219,184,161,109,209,45,183,189,253,248,163,199,113,21,178,87,9,106,118,195,66,89,106,39,100,73,173,3,158,171,166,4,110,81,9,94,40,89,6,81,52,150,112,108,131,245,141,12,96,184,173,108,224,74,7,197,27,93,73,158,107,71,24,165,19,128,122,107,114,103,80,230,134,87,26,136,169,161,78,180,96,27,210,104,209,20,149,43,75,132,27,70,246,255,189,169,239,23,211,233,196,250,94,86,186,183,91,218,125,181,177,107,177,163,107,168,15,111,161,112,36,193,213,75,42,146,188,129,201,34,217,245,41,166,231,245,205,214,135,183,64,58,222,46,152,110,143,244,253,4,205,230,201,253,217,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("434ce1d3-6e07-4699-93db-b01705ec21d1"),
				ContainerUId = new Guid("1229c735-09aa-4ee5-8525-7e5e900b27a5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d9d40c49-13a3-46fc-ad8b-a4f987b3e7ae"),
				ContainerUId = new Guid("1229c735-09aa-4ee5-8525-7e5e900b27a5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1063030b-28ed-4349-83f1-f88f0c253b8f"),
				ContainerUId = new Guid("1229c735-09aa-4ee5-8525-7e5e900b27a5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("35901807-73b5-4d6a-a986-4a703ce774bc"),
				ContainerUId = new Guid("1229c735-09aa-4ee5-8525-7e5e900b27a5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b3f68a12-f0e7-4dbc-95dc-3aa993f1396a"),
				ContainerUId = new Guid("1229c735-09aa-4ee5-8525-7e5e900b27a5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("3df2bdde-18ee-451a-905a-ba278470a322"),
				ContainerUId = new Guid("1229c735-09aa-4ee5-8525-7e5e900b27a5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("5b159456-5fda-4b8d-a9da-8834e8ecff25"),
				ContainerUId = new Guid("1229c735-09aa-4ee5-8525-7e5e900b27a5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cab64fdd-d9c8-4716-9374-04b8c65c8e58"),
				ContainerUId = new Guid("1229c735-09aa-4ee5-8525-7e5e900b27a5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("75b749cb-919a-4155-bc75-71aeaac350c3"),
				ContainerUId = new Guid("1229c735-09aa-4ee5-8525-7e5e900b27a5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("ebe93ac6-61cb-4604-b9fb-2f61805b7505"),
				ContainerUId = new Guid("1229c735-09aa-4ee5-8525-7e5e900b27a5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("a00022fb-ec61-40f9-9ff8-7671f9aa224d"),
				ContainerUId = new Guid("1229c735-09aa-4ee5-8525-7e5e900b27a5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("af966caf-821e-4b78-aa8c-6616c22121fd"),
				ContainerUId = new Guid("1229c735-09aa-4ee5-8525-7e5e900b27a5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("2a686d88-37aa-4fe9-8504-56df612323cf"),
				ContainerUId = new Guid("1229c735-09aa-4ee5-8525-7e5e900b27a5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("7fa4e729-8a82-4309-b45d-78704c4aa63b"),
				ContainerUId = new Guid("1229c735-09aa-4ee5-8525-7e5e900b27a5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e1371407-e306-4321-b51f-29ca9ebcdeba"),
				ContainerUId = new Guid("1229c735-09aa-4ee5-8525-7e5e900b27a5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("610abf96-01f0-45e3-a38b-748d3acf7700"),
				ContainerUId = new Guid("1229c735-09aa-4ee5-8525-7e5e900b27a5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("543a50ee-266b-44ae-9cda-3cd5c8a31403"),
				ContainerUId = new Guid("1229c735-09aa-4ee5-8525-7e5e900b27a5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("42a55883-c37d-44f5-99aa-e6759f2622e2"),
				ContainerUId = new Guid("1229c735-09aa-4ee5-8525-7e5e900b27a5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("7a0f3021-87ac-40b1-a047-2efc1706f4df"),
				ContainerUId = new Guid("3df47a17-9fa0-4ffa-9eb9-ec8bc555c578"),
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
				Value = @"80294582-06b5-4faa-a85f-3323e5536b71",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("49180349-f18b-43d5-b1ff-f3696e187539"),
				ContainerUId = new Guid("3df47a17-9fa0-4ffa-9eb9-ec8bc555c578"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,79,107,220,48,16,197,191,139,14,61,89,197,182,36,91,114,143,203,182,236,37,13,109,90,10,201,18,198,210,40,43,240,191,88,50,77,48,254,238,149,215,217,20,114,40,165,183,130,15,154,177,223,211,111,30,227,249,222,249,143,174,9,56,86,22,26,143,201,116,48,21,97,134,11,139,57,163,202,178,154,114,163,44,133,34,3,90,104,171,75,97,133,146,92,146,164,131,22,43,178,169,247,198,5,146,184,128,173,175,110,231,223,166,97,156,48,185,183,231,226,171,62,97,11,223,214,11,100,154,43,46,100,78,211,162,22,148,91,0,10,82,88,202,88,206,80,8,86,212,101,70,54,22,155,2,136,44,227,84,32,103,148,11,131,180,102,165,137,104,214,74,145,115,64,25,89,26,180,97,255,52,140,232,189,235,187,106,198,215,243,205,243,16,41,183,187,119,125,51,181,29,73,90,12,112,13,225,84,17,192,20,185,208,64,53,87,43,8,150,20,152,50,148,65,93,230,165,196,172,200,74,146,104,24,194,106,75,14,134,36,6,2,124,135,102,194,179,243,236,34,99,206,210,76,138,34,106,51,166,41,103,121,74,101,33,75,106,77,97,21,178,66,169,218,92,242,250,52,185,120,118,254,106,106,113,116,250,37,118,140,249,245,99,53,235,190,11,99,223,172,214,87,231,207,111,240,41,108,225,190,188,250,177,13,20,98,127,21,145,37,153,60,238,26,135,93,216,119,186,55,174,123,216,60,151,37,74,218,1,70,231,47,41,236,31,39,104,72,50,186,135,211,31,211,218,77,62,244,237,127,52,106,18,199,140,30,113,201,206,184,235,14,26,231,135,6,158,207,117,69,222,61,78,125,248,240,5,117,63,154,131,217,42,242,70,85,145,59,98,52,212,42,77,57,53,69,157,198,109,83,25,5,163,57,173,227,174,89,163,13,40,208,119,36,146,252,163,255,237,193,127,254,217,93,254,133,141,254,248,62,118,223,52,174,47,202,106,254,27,164,229,184,66,29,151,248,252,2,141,35,191,90,210,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var deleteRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("85f4379a-e11e-4bb2-9820-64ceda7a6dae"),
				ContainerUId = new Guid("3df47a17-9fa0-4ffa-9eb9-ec8bc555c578"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,37,140,59,11,194,48,20,70,255,74,200,156,12,197,212,166,217,138,138,184,56,180,116,18,135,219,220,27,40,196,20,242,152,196,255,110,31,219,119,190,3,231,245,125,160,225,85,171,166,170,209,78,194,25,180,84,22,79,114,162,26,164,198,214,41,165,26,91,163,229,226,2,161,39,64,227,192,39,218,232,134,115,54,57,150,29,174,228,41,211,129,195,82,162,165,181,203,197,61,66,200,180,238,206,251,126,241,148,186,128,99,162,152,184,120,194,231,248,89,220,4,131,128,172,236,234,247,254,3,227,158,202,99,152,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(deleteRightsParameter);
			var addRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("aaac2e3d-968e-44df-9437-d7259ef3353c"),
				ContainerUId = new Guid("3df47a17-9fa0-4ffa-9eb9-ec8bc555c578"),
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(addRightsParameter);
		}

		protected virtual void InitializeChangeAdminRightsUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("715d9783-6e60-4275-a211-6654d9017627"),
				ContainerUId = new Guid("1b1101ef-7d0f-4bd5-9aad-2576b35849dd"),
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
				Value = @"80294582-06b5-4faa-a85f-3323e5536b71",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a86cf9e4-ea24-4335-9045-5cc306b446ed"),
				ContainerUId = new Guid("1b1101ef-7d0f-4bd5-9aad-2576b35849dd"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,100,21,91,95,150,220,227,178,45,123,73,67,155,150,66,178,132,177,52,78,4,254,216,88,50,77,48,251,223,43,175,119,83,200,161,148,222,10,58,204,140,244,222,188,121,140,230,123,31,62,250,54,226,88,53,208,6,204,166,157,171,8,162,53,28,141,163,38,87,64,5,150,156,106,199,74,138,70,115,87,72,87,48,166,73,214,67,135,21,89,209,91,231,35,201,124,196,46,84,183,243,111,210,56,78,152,221,55,167,228,171,125,196,14,190,45,13,116,206,140,144,154,209,92,213,146,138,6,128,130,150,13,229,156,113,148,146,171,186,44,200,89,75,97,155,188,150,72,121,153,94,9,230,20,5,6,142,42,171,177,214,82,215,185,104,72,214,98,19,183,207,135,17,67,240,67,95,205,248,26,223,188,28,146,202,181,247,102,104,167,174,39,89,135,17,174,33,62,86,4,48,71,33,45,80,43,204,34,4,75,10,60,13,206,161,46,89,169,177,80,69,73,50,11,135,184,208,146,157,35,153,131,8,223,161,157,240,196,60,251,164,145,241,188,208,82,37,108,193,45,21,156,229,84,43,93,210,198,169,198,32,87,198,212,238,226,215,167,201,167,216,135,171,169,195,209,219,179,237,152,252,27,198,106,182,67,31,199,161,93,168,175,78,207,111,240,57,174,230,158,175,126,172,3,197,84,95,64,228,152,77,1,55,173,199,62,110,123,59,56,223,63,172,156,199,99,130,116,7,24,125,184,184,176,125,154,160,37,217,232,31,30,255,232,214,102,10,113,232,254,163,81,179,52,102,226,72,75,118,146,187,236,160,243,225,208,194,203,41,175,200,187,167,105,136,31,190,160,29,70,183,115,107,70,222,160,42,114,71,156,133,218,228,185,160,78,213,57,21,210,20,20,156,21,180,110,210,122,58,235,192,128,189,35,73,201,63,242,223,238,194,231,159,253,229,47,172,234,247,239,83,245,77,225,250,130,172,230,191,145,116,220,47,162,246,199,116,126,1,218,139,177,101,210,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var deleteRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2b09ebf2-4fc5-4866-9c5f-fdb6ecbb4544"),
				ContainerUId = new Guid("1b1101ef-7d0f-4bd5-9aad-2576b35849dd"),
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(deleteRightsParameter);
			var addRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b0fd2cf4-cef1-4cbb-ad13-35a8ed0e2519"),
				ContainerUId = new Guid("1b1101ef-7d0f-4bd5-9aad-2576b35849dd"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,93,144,193,106,195,48,16,68,127,197,184,215,40,216,150,101,75,190,166,110,9,148,166,36,208,75,240,97,37,173,18,131,44,7,89,110,9,33,255,94,57,133,30,122,219,55,48,195,206,28,111,91,221,164,8,165,206,106,35,9,170,186,38,165,148,53,145,69,77,9,207,51,174,25,101,138,49,76,87,27,112,123,4,221,4,63,227,2,173,238,195,31,60,163,197,128,191,120,24,103,175,176,73,105,186,122,245,224,2,198,187,29,46,118,188,98,140,121,135,33,242,241,105,201,74,70,175,209,175,95,122,63,133,164,15,56,36,163,73,60,78,179,13,189,59,37,106,180,22,85,232,71,183,222,125,59,244,79,93,186,250,4,59,63,252,199,237,244,16,15,234,140,3,52,6,236,132,221,58,170,255,132,214,226,128,46,52,55,195,88,165,50,202,136,42,65,199,150,12,136,192,50,35,69,73,153,201,10,41,4,210,123,52,124,128,143,47,6,244,209,34,180,164,6,56,17,181,48,164,172,76,73,100,21,135,201,43,149,115,70,85,6,88,45,150,214,133,62,92,55,163,157,7,215,220,120,174,56,210,156,147,186,2,69,74,46,24,17,32,100,12,169,178,184,235,178,38,220,187,165,204,238,130,30,150,126,251,254,116,14,111,248,133,182,73,139,244,222,253,0,138,249,68,249,152,1,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(addRightsParameter);
			var employee1Parameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("ea4d07fb-ec77-4bb7-b273-8108d535c55e"),
				ContainerUId = new Guid("1b1101ef-7d0f-4bd5-9aad-2576b35849dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Name = @"Employee1",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			employee1Parameter.SourceValue = new ProcessSchemaParameterValue(employee1Parameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{f556c035-c4ad-4b5a-9e40-2435f02b99e3}].[Parameter:{f9db3fa8-979f-46f4-b673-16c1853c0ae6}].[EntityColumn:{81c8e318-76ac-4895-9a9b-9760b27c55ea}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(employee1Parameter);
		}

		protected virtual void InitializeSendEmailUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var senderParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				UId = new Guid("d8e02cae-bddc-4ad4-b1a7-d3884e48b3e0"),
				ContainerUId = new Guid("7b1bce61-7682-4d71-99ce-36b72451bdad"),
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
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(senderParameter);
			var recepientParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("279b36d4-3051-42d2-855e-a6468792afd5"),
				ContainerUId = new Guid("7b1bce61-7682-4d71-99ce-36b72451bdad"),
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
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{1229c735-09aa-4ee5-8525-7e5e900b27a5}].[Parameter:{5b159456-5fda-4b8d-a9da-8834e8ecff25}].[EntityColumn:{dbf202ec-c444-479b-bcf4-d8e5b1863201}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(recepientParameter);
			var copyRecepientParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d9fc1537-e977-47b2-ad3a-1969e1f46250"),
				ContainerUId = new Guid("7b1bce61-7682-4d71-99ce-36b72451bdad"),
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
				UId = new Guid("293075ea-1e56-4c2d-96c4-ea3d418c0825"),
				ContainerUId = new Guid("7b1bce61-7682-4d71-99ce-36b72451bdad"),
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
				UId = new Guid("9efb7ccc-4ec1-4628-810b-b039072bc1eb"),
				ContainerUId = new Guid("7b1bce61-7682-4d71-99ce-36b72451bdad"),
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
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{f5a0902d-7693-4996-b837-c4f23f36f0e4}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(subjectParameter);
			var bodyParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b7dd75b0-1de1-4b8a-bfed-006a54509a92"),
				ContainerUId = new Guid("7b1bce61-7682-4d71-99ce-36b72451bdad"),
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
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{3be84f48-2ec9-45e3-9957-5bc4267296c5}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(bodyParameter);
			var importanceParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a7dc66e5-5d32-44bc-b00b-d47172fbbffb"),
				ContainerUId = new Guid("7b1bce61-7682-4d71-99ce-36b72451bdad"),
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
				UId = new Guid("bcb8c68f-82ae-42bc-a9f6-b0ef566ea9c9"),
				ContainerUId = new Guid("7b1bce61-7682-4d71-99ce-36b72451bdad"),
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
				Value = @"True",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926")
			};
			parametrizedElement.Parameters.Add(isIgnoreErrorsParameter);
		}

		protected virtual void InitializeGiveRightsToVisaOwnerParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8bb24c30-d947-4357-9f8b-67567a930b23"),
				ContainerUId = new Guid("47428468-6fc8-44b4-ac36-afafef90436c"),
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
				Value = @"80294582-06b5-4faa-a85f-3323e5536b71",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5d6d30fd-b020-4557-abfa-83f41068a362"),
				ContainerUId = new Guid("47428468-6fc8-44b4-ac36-afafef90436c"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,79,107,220,48,16,197,191,139,14,61,89,197,178,44,217,114,143,203,182,236,37,13,109,90,10,201,18,70,210,40,43,240,159,141,37,211,4,179,223,189,242,58,155,66,14,165,244,86,240,65,26,251,189,249,205,99,60,223,251,240,209,183,17,199,198,65,27,48,155,118,182,33,185,99,181,99,26,169,168,164,160,37,23,140,106,97,144,26,110,192,202,82,49,229,74,146,245,208,97,67,86,245,214,250,72,50,31,177,11,205,237,252,219,52,142,19,102,247,238,124,249,106,14,216,193,183,165,65,157,23,170,20,117,65,115,169,83,3,7,64,161,22,142,114,94,112,20,130,75,93,49,178,178,48,161,133,51,88,81,41,57,167,101,197,10,90,59,94,37,32,46,173,230,88,49,201,73,214,162,139,219,167,227,136,33,248,161,111,102,124,61,223,60,31,19,229,218,123,51,180,83,215,147,172,195,8,215,16,15,13,1,204,177,20,6,168,41,213,2,146,250,0,87,150,114,208,85,81,213,200,36,171,72,102,224,24,23,91,178,179,36,179,16,225,59,180,19,158,157,103,159,24,11,158,179,90,200,164,101,220,164,188,138,156,214,178,174,168,179,210,41,228,82,41,109,47,121,125,154,124,58,251,112,53,117,56,122,243,18,59,166,252,134,177,153,205,208,199,113,104,23,235,171,243,231,55,248,20,215,112,95,94,253,88,7,138,169,190,136,200,41,155,2,110,90,143,125,220,246,102,176,190,127,88,61,79,167,36,233,142,48,250,112,73,97,251,56,65,75,178,209,63,28,254,152,214,102,10,113,232,254,163,81,179,52,102,242,72,75,118,198,93,118,208,250,112,108,225,249,124,111,200,187,199,105,136,31,190,160,25,70,187,179,235,141,188,81,53,228,142,88,3,90,229,121,73,173,212,57,45,133,98,20,172,41,169,118,105,61,173,177,160,192,220,145,68,242,143,254,183,187,240,249,103,127,249,23,86,250,253,251,84,125,83,184,190,40,155,249,111,144,78,251,5,106,127,74,207,47,49,186,224,44,210,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var deleteRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("528b6dbc-3e55-4984-ac5c-3561f9fc45d5"),
				ContainerUId = new Guid("47428468-6fc8-44b4-ac36-afafef90436c"),
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
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(deleteRightsParameter);
			var addRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("53b17576-c93f-48fc-b7e5-4f5b50ba8e72"),
				ContainerUId = new Guid("47428468-6fc8-44b4-ac36-afafef90436c"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,93,143,205,106,195,48,16,132,95,197,40,87,43,40,182,172,88,186,149,54,148,64,105,138,13,189,4,31,86,218,117,99,144,127,80,148,148,18,242,238,117,210,246,210,219,124,179,12,179,179,191,108,209,48,64,153,101,40,20,71,167,144,203,214,21,220,162,205,56,22,173,182,153,116,14,165,101,233,35,12,21,1,154,24,78,116,131,13,118,209,180,224,143,119,122,34,79,145,126,185,30,79,193,145,97,57,75,159,3,12,145,102,93,141,158,88,250,10,253,172,247,139,122,34,215,181,95,9,76,83,24,207,224,147,9,194,124,138,20,142,203,228,225,110,82,88,52,44,125,7,127,186,39,246,219,227,238,115,160,80,187,3,245,240,83,212,44,103,247,159,177,241,212,211,16,205,69,175,37,172,86,121,203,193,21,243,42,85,34,47,201,89,78,22,133,144,214,106,73,250,58,7,222,254,154,205,69,150,36,112,93,72,46,74,39,184,20,160,185,198,92,115,37,148,82,182,133,204,81,121,109,110,111,237,38,10,16,187,113,168,186,143,67,124,161,51,121,195,50,118,109,190,1,124,82,213,179,82,1,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(addRightsParameter);
			var role1Parameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				UId = new Guid("ad422d06-dc6d-4fc5-bdb2-d5f9b24ccd4b"),
				ContainerUId = new Guid("47428468-6fc8-44b4-ac36-afafef90436c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Name = @"Role1",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			role1Parameter.SourceValue = new ProcessSchemaParameterValue(role1Parameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{974a113f-ac5d-468d-8ecb-ebd004bb94e9}].[Parameter:{48e0d754-08c0-40a9-9d39-60666bfa2ce8}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			parametrizedElement.Parameters.Add(role1Parameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaSubProcess ordervisasubprocess = CreateOrderVisaSubProcessSubProcess();
			FlowElements.Add(ordervisasubprocess);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaUserTask autogeneratedpageusertask1 = CreateAutoGeneratedPageUserTask1UserTask();
			FlowElements.Add(autogeneratedpageusertask1);
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			ProcessSchemaUserTask readdatausertask2 = CreateReadDataUserTask2UserTask();
			FlowElements.Add(readdatausertask2);
			ProcessSchemaUserTask changeadminrightsusertask1 = CreateChangeAdminRightsUserTask1UserTask();
			FlowElements.Add(changeadminrightsusertask1);
			ProcessSchemaTerminateEvent terminate2 = CreateTerminate2TerminateEvent();
			FlowElements.Add(terminate2);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			ProcessSchemaFormulaTask formulatask2 = CreateFormulaTask2FormulaTask();
			FlowElements.Add(formulatask2);
			ProcessSchemaUserTask changeadminrightsusertask2 = CreateChangeAdminRightsUserTask2UserTask();
			FlowElements.Add(changeadminrightsusertask2);
			ProcessSchemaFormulaTask formulatask3 = CreateFormulaTask3FormulaTask();
			FlowElements.Add(formulatask3);
			ProcessSchemaFormulaTask formulatask4 = CreateFormulaTask4FormulaTask();
			FlowElements.Add(formulatask4);
			ProcessSchemaUserTask sendemailusertask1 = CreateSendEmailUserTask1UserTask();
			FlowElements.Add(sendemailusertask1);
			ProcessSchemaTerminateEvent terminate3 = CreateTerminate3TerminateEvent();
			FlowElements.Add(terminate3);
			ProcessSchemaUserTask giverightstovisaowner = CreateGiveRightsToVisaOwnerUserTask();
			FlowElements.Add(giverightstovisaowner);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateConditionalFlow4ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
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
				UId = new Guid("dc7926ca-c100-4d68-8cdc-713a31c09648"),
				Name = "BodyRejected",
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSubjectRejectedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8558a3a5-f15d-4c9d-8a39-92829cbdc365"),
				Name = "SubjectRejected",
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateBodyApprovedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("29c3d046-24be-4116-8999-c9ecc8e5f2ea"),
				Name = "BodyApproved",
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSubjectApprovedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("859b4b21-2e44-418a-b01b-ac5742236a38"),
				Name = "SubjectApproved",
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("2baab3b9-77bd-4a07-8584-66d583a1df28"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				CurveCenterPosition = new Point(153, 208),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cab8cfe0-d5f3-4c99-aeb8-34206447bc9f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("974a113f-ac5d-468d-8ecb-ebd004bb94e9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("8e563afe-5967-487f-9123-59379b11d248"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				CurveCenterPosition = new Point(308, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("974a113f-ac5d-468d-8ecb-ebd004bb94e9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f556c035-c4ad-4b5a-9e40-2435f02b99e3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
				ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
					{new Guid("974a113f-ac5d-468d-8ecb-ebd004bb94e9"), new Collection<Guid>() {
						new Guid("dd340939-b2f0-473c-8b99-ea9e4352ee64"),
					}},
				}
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("fa0f90fb-e234-4934-9d3f-86399b2cbf36"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				CurveCenterPosition = new Point(466, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f556c035-c4ad-4b5a-9e40-2435f02b99e3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1229c735-09aa-4ee5-8525-7e5e900b27a5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("64c25928-1ea9-4315-8578-1491334bfb94"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				CurveCenterPosition = new Point(619, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1229c735-09aa-4ee5-8525-7e5e900b27a5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3df47a17-9fa0-4ffa-9eb9-ec8bc555c578"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("e8a10773-b2b3-4995-88c5-4c049bc8d216"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				CurveCenterPosition = new Point(766, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3df47a17-9fa0-4ffa-9eb9-ec8bc555c578"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("47428468-6fc8-44b4-ac36-afafef90436c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow5",
				UId = new Guid("f35ece9d-846b-4a47-b277-99bedb3e5264"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				CurveCenterPosition = new Point(833, 268),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cc939664-f533-46cb-97ba-222f10143fcf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8b821e7e-d93f-48cf-8c17-e2fa1b5ce7c7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow3",
				UId = new Guid("72cd1145-9f82-4d0b-a86b-9ce612885050"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{cc939664-f533-46cb-97ba-222f10143fcf}].[Parameter:{0e8d8a98-20fb-40c2-92ba-536a8b9a9263}]#]==""Rejected""",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				CurveCenterPosition = new Point(862, 122),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cc939664-f533-46cb-97ba-222f10143fcf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4319201a-d137-4f87-932a-1caf6cec6b0e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("e2b18df0-cc47-496a-8b8a-395dba11027b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				CurveCenterPosition = new Point(1000, 70),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4319201a-d137-4f87-932a-1caf6cec6b0e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dd16215e-5225-4211-83b6-8515e3cfaf51"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("59f29cf7-d825-4fd5-bc86-edfe8c233400"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				CurveCenterPosition = new Point(1151, 70),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dd16215e-5225-4211-83b6-8515e3cfaf51"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1b1101ef-7d0f-4bd5-9aad-2576b35849dd"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow4ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow4",
				UId = new Guid("a35a66f4-7cf7-47d0-b5e2-acd4b7e99a59"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{cc939664-f533-46cb-97ba-222f10143fcf}].[Parameter:{0e8d8a98-20fb-40c2-92ba-536a8b9a9263}]#] == ""Approved""",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				CurveCenterPosition = new Point(906, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cc939664-f533-46cb-97ba-222f10143fcf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f4006d4f-d961-4241-82de-5bd4162bb3c8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("efd815cf-d29b-485e-a387-ee969fc00165"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				CurveCenterPosition = new Point(1045, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f4006d4f-d961-4241-82de-5bd4162bb3c8"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d7069b39-753a-41ff-8cbc-cb63bedc2f31"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("cad58a7f-aca6-49e3-8d21-7448e4575aef"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				CurveCenterPosition = new Point(1186, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d7069b39-753a-41ff-8cbc-cb63bedc2f31"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7b1bce61-7682-4d71-99ce-36b72451bdad"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("df65e375-e2c6-43a1-b31b-46fb44d21a1c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				CurveCenterPosition = new Point(1240, 139),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1b1101ef-7d0f-4bd5-9aad-2576b35849dd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7b1bce61-7682-4d71-99ce-36b72451bdad"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("1008f8f2-f45e-460f-bcfd-072fe26e93d7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				CurveCenterPosition = new Point(1336, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7b1bce61-7682-4d71-99ce-36b72451bdad"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d794aebd-7733-44f5-a744-3f6f8b28094e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("8c275e91-54bf-4b5d-9a60-b29b9fa77c0b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("89e565c9-50da-4c25-81e9-da9ea88c968e"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				CurveCenterPosition = new Point(766, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("47428468-6fc8-44b4-ac36-afafef90436c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cc939664-f533-46cb-97ba-222f10143fcf"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("41013f3a-673b-496f-a366-6ee369af931f"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(1559, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("12c78d6a-5e36-47ee-bfbd-8cd16edf917e"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("41013f3a-673b-496f-a366-6ee369af931f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(1530, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("cab8cfe0-d5f3-4c99-aeb8-34206447bc9f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("12c78d6a-5e36-47ee-bfbd-8cd16edf917e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Name = @"Start1",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaUserTask CreateAutoGeneratedPageUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("974a113f-ac5d-468d-8ecb-ebd004bb94e9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("12c78d6a-5e36-47ee-bfbd-8cd16edf917e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Name = @"AutoGeneratedPageUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(155, 170),
				SchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeAutoGeneratedPageUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("f556c035-c4ad-4b5a-9e40-2435f02b99e3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("12c78d6a-5e36-47ee-bfbd-8cd16edf917e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Name = @"ReadDataUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(316, 170),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("1229c735-09aa-4ee5-8525-7e5e900b27a5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("12c78d6a-5e36-47ee-bfbd-8cd16edf917e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Name = @"ReadDataUserTask2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(470, 170),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeAdminRightsUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("3df47a17-9fa0-4ffa-9eb9-ec8bc555c578"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("12c78d6a-5e36-47ee-bfbd-8cd16edf917e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Name = @"ChangeAdminRightsUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(624, 170),
				SchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeAdminRightsUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaSubProcess CreateOrderVisaSubProcessSubProcess() {
			ProcessSchemaSubProcess schemaOrderVisaSubProcess = new ProcessSchemaSubProcess(this) {
				UId = new Guid("cc939664-f533-46cb-97ba-222f10143fcf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("12c78d6a-5e36-47ee-bfbd-8cd16edf917e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Name = @"OrderVisaSubProcess",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(904, 170),
				SchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeOrderVisaSubProcessParameters(schemaOrderVisaSubProcess);
			return schemaOrderVisaSubProcess;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate2TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("8b821e7e-d93f-48cf-8c17-e2fa1b5ce7c7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("12c78d6a-5e36-47ee-bfbd-8cd16edf917e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Name = @"Terminate2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(925, 296),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask1FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("4319201a-d137-4f87-932a-1caf6cec6b0e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("12c78d6a-5e36-47ee-bfbd-8cd16edf917e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Name = @"FormulaTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(995, 37),
				ResultParameterMetaPath = @"3be84f48-2ec9-45e3-9957-5bc4267296c5",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,203,193,106,2,49,16,0,208,143,241,210,66,71,226,102,146,77,246,216,162,224,169,165,30,197,195,36,153,105,45,155,44,100,35,34,210,127,239,122,237,245,193,155,91,61,151,175,245,110,170,153,218,211,235,148,110,159,252,195,177,113,122,57,174,142,251,249,253,90,184,30,226,55,103,26,132,198,153,79,235,69,255,193,118,228,204,165,13,119,49,198,70,165,13,68,164,4,24,12,129,103,84,208,161,54,162,186,224,61,235,223,37,124,80,165,204,141,235,82,124,10,90,200,129,239,189,0,90,65,8,182,215,176,177,113,227,140,142,138,216,62,202,182,180,115,187,189,77,227,37,151,225,158,164,115,232,133,192,248,212,3,98,20,8,33,105,64,157,172,53,232,148,195,101,173,78,207,127,51,210,85,199,224,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask2FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("dd16215e-5225-4211-83b6-8515e3cfaf51"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("12c78d6a-5e36-47ee-bfbd-8cd16edf917e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Name = @"FormulaTask2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1142, 37),
				ResultParameterMetaPath = @"f5a0902d-7693-4996-b837-c4f23f36f0e4",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,46,77,202,74,77,46,9,74,5,145,169,41,0,18,77,35,34,15,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeAdminRightsUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("1b1101ef-7d0f-4bd5-9aad-2576b35849dd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("12c78d6a-5e36-47ee-bfbd-8cd16edf917e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Name = @"ChangeAdminRightsUserTask2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1296, 37),
				SchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeAdminRightsUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask3FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("f4006d4f-d961-4241-82de-5bd4162bb3c8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("12c78d6a-5e36-47ee-bfbd-8cd16edf917e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Name = @"FormulaTask3",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1044, 170),
				ResultParameterMetaPath = @"3be84f48-2ec9-45e3-9957-5bc4267296c5",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,203,193,74,3,49,16,0,208,143,233,69,161,83,210,205,36,155,236,173,45,21,60,41,120,44,61,76,146,25,45,108,178,37,27,149,82,252,119,215,171,215,7,111,110,245,82,222,55,79,83,205,212,30,246,83,186,237,174,215,58,125,113,90,159,86,167,231,249,229,187,112,125,139,31,156,105,16,26,103,62,111,22,253,7,199,145,51,151,54,220,197,24,27,149,54,16,145,18,96,48,4,158,81,65,135,218,136,234,130,247,172,127,150,240,74,149,50,55,174,75,241,41,104,33,7,190,247,2,104,5,33,216,94,195,214,198,173,51,58,42,98,251,87,142,165,93,218,237,48,141,159,185,12,247,36,157,67,47,4,198,167,30,16,163,64,8,73,3,234,100,173,65,167,28,46,107,117,126,252,5,93,120,174,27,224,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask4FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("d7069b39-753a-41ff-8cbc-cb63bedc2f31"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("12c78d6a-5e36-47ee-bfbd-8cd16edf917e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Name = @"FormulaTask4",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1184, 170),
				ResultParameterMetaPath = @"f5a0902d-7693-4996-b837-c4f23f36f0e4",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,46,77,202,74,77,46,113,44,40,40,202,47,75,77,1,0,10,201,46,220,15,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreateSendEmailUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("7b1bce61-7682-4d71-99ce-36b72451bdad"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("12c78d6a-5e36-47ee-bfbd-8cd16edf917e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Name = @"SendEmailUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1324, 170),
				SchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeSendEmailUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate3TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("d794aebd-7733-44f5-a744-3f6f8b28094e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("12c78d6a-5e36-47ee-bfbd-8cd16edf917e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Name = @"Terminate3",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1471, 184),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateGiveRightsToVisaOwnerUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("47428468-6fc8-44b4-ac36-afafef90436c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("12c78d6a-5e36-47ee-bfbd-8cd16edf917e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("89e565c9-50da-4c25-81e9-da9ea88c968e"),
				CreatedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				ModifiedInSchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"),
				Name = @"GiveRightsToVisaOwner",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(764, 170),
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
			return new OrderVisaProcess(userConnection);
		}

		public override object Clone() {
			return new OrderVisaProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47"));
		}

		#endregion

	}

	#endregion

	#region Class: OrderVisaProcess

	/// <exclude/>
	public class OrderVisaProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, OrderVisaProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: AutoGeneratedPageUserTask1FlowElement

		/// <exclude/>
		public class AutoGeneratedPageUserTask1FlowElement : AutoGeneratedPageUserTask
		{

			#region Constructors: Public

			public AutoGeneratedPageUserTask1FlowElement(UserConnection userConnection, OrderVisaProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AutoGeneratedPageUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("974a113f-ac5d-468d-8ecb-ebd004bb94e9");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private LocalizableString _title;
			public override LocalizableString Title {
				get {
					return _title ?? (_title = GetLocalizableString("ede755ac401e48b6ab6a5dba4123df47",
						 "BaseElements.AutoGeneratedPageUserTask1.Parameters.Title.Value"));
				}
				set {
					_title = value;
				}
			}

			private LocalizableString _buttons;
			public override LocalizableString Buttons {
				get {
					return _buttons ?? (_buttons = GetLocalizableString("ede755ac401e48b6ab6a5dba4123df47",
						 "BaseElements.AutoGeneratedPageUserTask1.Parameters.Buttons.Value"));
				}
				set {
					_buttons = value;
				}
			}

			private LocalizableString _elements;
			public override LocalizableString Elements {
				get {
					return _elements ?? (_elements = GetLocalizableString("ede755ac401e48b6ab6a5dba4123df47",
						 "BaseElements.AutoGeneratedPageUserTask1.Parameters.Elements.Value"));
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
				return "[\"dd340939-b2f0-473c-8b99-ea9e4352ee64\"]";
			}

			#endregion

		}

		#endregion

		#region Class: ReadDataUserTask1FlowElement

		/// <exclude/>
		public class ReadDataUserTask1FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask1FlowElement(UserConnection userConnection, OrderVisaProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("f556c035-c4ad-4b5a-9e40-2435f02b99e3");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,79,107,220,48,16,197,191,139,14,61,89,69,182,100,201,114,143,203,182,236,37,13,109,90,10,201,18,198,210,56,43,240,191,88,50,77,48,254,238,149,215,217,20,114,40,165,183,130,15,154,177,223,211,111,30,227,249,222,249,143,174,9,56,150,53,52,30,147,233,96,75,162,52,214,200,57,210,148,23,130,10,158,23,180,210,70,81,129,140,9,83,43,84,146,147,164,131,22,75,178,169,247,214,5,146,184,128,173,47,111,231,223,166,97,156,48,185,175,207,197,87,115,194,22,190,173,23,20,44,211,34,47,50,202,100,149,83,81,3,80,40,242,154,114,158,113,204,115,46,43,149,146,141,69,138,140,89,134,72,77,154,73,42,140,172,168,70,5,212,72,105,25,88,81,241,60,178,52,88,135,253,211,48,162,247,174,239,202,25,95,207,55,207,67,164,220,238,222,245,205,212,118,36,105,49,192,53,132,83,73,0,25,138,220,68,59,161,87,16,84,20,184,182,148,67,165,50,85,96,42,83,69,18,3,67,88,109,201,193,146,196,66,128,239,208,76,120,118,158,93,100,204,56,75,139,92,70,109,202,77,204,43,99,180,144,133,162,181,149,181,70,46,181,174,236,37,175,79,147,139,103,231,175,166,22,71,103,94,98,199,152,95,63,150,179,233,187,48,246,205,106,125,117,254,252,6,159,194,22,238,203,171,31,219,64,33,246,87,17,89,146,201,227,174,113,216,133,125,103,122,235,186,135,205,115,89,162,164,29,96,116,254,146,194,254,113,130,134,36,163,123,56,253,49,173,221,228,67,223,254,71,163,38,113,204,232,17,151,236,140,187,238,160,117,126,104,224,249,92,151,228,221,227,212,135,15,95,208,244,163,61,216,173,34,111,84,37,185,35,214,64,165,227,146,83,43,43,70,69,174,83,10,214,8,90,213,113,61,173,177,160,193,220,145,72,242,143,254,183,7,255,249,103,119,249,23,54,250,227,251,216,125,211,184,190,40,203,249,111,144,150,227,10,117,92,226,243,11,251,145,172,118,210,3,0,0 })));
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
								new Guid("80294582-06b5-4faa-a85f-3323e5536b71")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("80294582-06b5-4faa-a85f-3323e5536b71"));
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

		#region Class: ReadDataUserTask2FlowElement

		/// <exclude/>
		public class ReadDataUserTask2FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask2FlowElement(UserConnection userConnection, OrderVisaProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("1229c735-09aa-4ee5-8525-7e5e900b27a5");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,77,107,220,48,16,134,255,202,162,67,79,214,34,91,178,44,185,199,176,41,185,164,161,77,75,161,9,97,44,141,18,129,63,54,182,76,19,150,253,239,29,175,155,22,114,40,185,244,80,48,66,146,245,206,204,251,104,116,184,139,211,121,108,19,142,117,128,118,194,108,190,240,53,19,6,155,188,48,37,87,78,52,52,20,138,67,131,138,163,46,154,74,32,250,208,84,44,235,161,195,154,173,234,157,143,137,101,49,97,55,213,223,15,127,130,166,113,198,236,46,156,22,159,221,3,118,240,101,73,144,235,6,165,46,115,110,2,22,92,229,165,229,198,123,193,193,8,233,149,54,210,123,201,214,90,156,18,165,65,109,56,128,167,163,190,12,220,186,220,113,111,141,119,21,228,121,16,138,101,45,134,180,123,218,143,56,77,113,232,235,3,254,158,95,63,239,169,202,53,247,217,208,206,93,207,178,14,19,92,65,122,168,25,160,64,85,58,224,78,89,178,27,176,226,32,173,231,18,154,170,168,12,230,58,39,167,14,246,105,9,203,46,60,203,60,36,248,10,237,140,167,200,135,72,53,22,82,228,166,212,164,205,165,227,74,22,130,27,109,42,30,188,14,150,140,90,219,248,23,94,31,230,72,243,56,93,206,29,142,209,253,194,142,196,111,24,235,131,27,250,52,14,237,18,250,242,116,252,26,159,210,10,247,215,175,111,171,161,68,251,139,136,29,179,121,194,179,54,98,159,118,189,27,124,236,239,215,152,199,35,73,186,61,140,113,122,161,176,123,156,161,101,217,24,239,31,254,74,235,108,158,210,208,253,71,86,51,178,73,49,168,201,78,229,46,61,232,227,180,111,225,249,180,174,217,187,199,121,72,239,63,33,248,205,48,122,28,183,231,113,156,210,102,105,216,205,16,54,228,126,110,19,197,219,184,161,109,209,45,183,189,253,248,163,199,113,21,178,87,9,106,118,195,66,89,106,39,100,73,173,3,158,171,166,4,110,81,9,94,40,89,6,81,52,150,112,108,131,245,141,12,96,184,173,108,224,74,7,197,27,93,73,158,107,71,24,165,19,128,122,107,114,103,80,230,134,87,26,136,169,161,78,180,96,27,210,104,209,20,149,43,75,132,27,70,246,255,189,169,239,23,211,233,196,250,94,86,186,183,91,218,125,181,177,107,177,163,107,168,15,111,161,112,36,193,213,75,42,146,188,129,201,34,217,245,41,166,231,245,205,214,135,183,64,58,222,46,152,110,143,244,253,4,205,230,201,253,217,4,0,0 })));
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

		#region Class: ChangeAdminRightsUserTask1FlowElement

		/// <exclude/>
		public class ChangeAdminRightsUserTask1FlowElement : ChangeAdminRightsUserTask
		{

			#region Constructors: Public

			public ChangeAdminRightsUserTask1FlowElement(UserConnection userConnection, OrderVisaProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeAdminRightsUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("3df47a17-9fa0-4ffa-9eb9-ec8bc555c578");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,79,107,220,48,16,197,191,139,14,61,89,197,182,36,91,114,143,203,182,236,37,13,109,90,10,201,18,198,210,40,43,240,191,88,50,77,48,254,238,149,215,217,20,114,40,165,183,130,15,154,177,223,211,111,30,227,249,222,249,143,174,9,56,86,22,26,143,201,116,48,21,97,134,11,139,57,163,202,178,154,114,163,44,133,34,3,90,104,171,75,97,133,146,92,146,164,131,22,43,178,169,247,198,5,146,184,128,173,175,110,231,223,166,97,156,48,185,183,231,226,171,62,97,11,223,214,11,100,154,43,46,100,78,211,162,22,148,91,0,10,82,88,202,88,206,80,8,86,212,101,70,54,22,155,2,136,44,227,84,32,103,148,11,131,180,102,165,137,104,214,74,145,115,64,25,89,26,180,97,255,52,140,232,189,235,187,106,198,215,243,205,243,16,41,183,187,119,125,51,181,29,73,90,12,112,13,225,84,17,192,20,185,208,64,53,87,43,8,150,20,152,50,148,65,93,230,165,196,172,200,74,146,104,24,194,106,75,14,134,36,6,2,124,135,102,194,179,243,236,34,99,206,210,76,138,34,106,51,166,41,103,121,74,101,33,75,106,77,97,21,178,66,169,218,92,242,250,52,185,120,118,254,106,106,113,116,250,37,118,140,249,245,99,53,235,190,11,99,223,172,214,87,231,207,111,240,41,108,225,190,188,250,177,13,20,98,127,21,145,37,153,60,238,26,135,93,216,119,186,55,174,123,216,60,151,37,74,218,1,70,231,47,41,236,31,39,104,72,50,186,135,211,31,211,218,77,62,244,237,127,52,106,18,199,140,30,113,201,206,184,235,14,26,231,135,6,158,207,117,69,222,61,78,125,248,240,5,117,63,154,131,217,42,242,70,85,145,59,98,52,212,42,77,57,53,69,157,198,109,83,25,5,163,57,173,227,174,89,163,13,40,208,119,36,146,252,163,255,237,193,127,254,217,93,254,133,141,254,248,62,118,223,52,174,47,202,106,254,27,164,229,184,66,29,151,248,252,2,141,35,191,90,210,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private string _deleteRights;
			public override string DeleteRights {
				get {
					return _deleteRights ?? (_deleteRights = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,37,140,59,11,194,48,20,70,255,74,200,156,12,197,212,166,217,138,138,184,56,180,116,18,135,219,220,27,40,196,20,242,152,196,255,110,31,219,119,190,3,231,245,125,160,225,85,171,166,170,209,78,194,25,180,84,22,79,114,162,26,164,198,214,41,165,26,91,163,229,226,2,161,39,64,227,192,39,218,232,134,115,54,57,150,29,174,228,41,211,129,195,82,162,165,181,203,197,61,66,200,180,238,206,251,126,241,148,186,128,99,162,152,184,120,194,231,248,89,220,4,131,128,172,236,234,247,254,3,227,158,202,99,152,0,0,0 })));
				}
				set {
					_deleteRights = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: OrderVisaSubProcessFlowElement

		/// <exclude/>
		public class OrderVisaSubProcessFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public OrderVisaSubProcessFlowElement(UserConnection userConnection, OrderVisaProcess process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be");
			}

			#endregion

			#region Properties: Public

			public Guid Order {
				get {
					return GetParameterValue<Guid>("Order");
				}
				set {
					SetParameterValue("Order", value);
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
				var process = (OrderVisaProcess)owner;
				Name = "OrderVisaSubProcess";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("cc939664-f533-46cb-97ba-222f10143fcf");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (OrderVisaProcess)Owner;
				SetParameterValue("Order", (Guid)((process.RecordId)));
				SetParameterValue("VisaOwner", (Guid)((process.AutoGeneratedPageUserTask1.VisaOwner)));
				SetParameterValue("VisaObjective", new LocalizableString((process.AutoGeneratedPageUserTask1.Objective)));
				SetParameterValue("IsAllowedToDelegate", (bool)((process.AutoGeneratedPageUserTask1.IsAllowedToDelegate)));
				SetParameterValue("IsPreviousVisaCounts", (bool)(false));
			}

			#endregion

		}

		#endregion

		#region Class: ChangeAdminRightsUserTask2FlowElement

		/// <exclude/>
		public class ChangeAdminRightsUserTask2FlowElement : ChangeAdminRightsUserTask
		{

			#region Constructors: Public

			public ChangeAdminRightsUserTask2FlowElement(UserConnection userConnection, OrderVisaProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeAdminRightsUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("1b1101ef-7d0f-4bd5-9aad-2576b35849dd");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_employee1 = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
			}

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,100,21,91,95,150,220,227,178,45,123,73,67,155,150,66,178,132,177,52,78,4,254,216,88,50,77,48,251,223,43,175,119,83,200,161,148,222,10,58,204,140,244,222,188,121,140,230,123,31,62,250,54,226,88,53,208,6,204,166,157,171,8,162,53,28,141,163,38,87,64,5,150,156,106,199,74,138,70,115,87,72,87,48,166,73,214,67,135,21,89,209,91,231,35,201,124,196,46,84,183,243,111,210,56,78,152,221,55,167,228,171,125,196,14,190,45,13,116,206,140,144,154,209,92,213,146,138,6,128,130,150,13,229,156,113,148,146,171,186,44,200,89,75,97,155,188,150,72,121,153,94,9,230,20,5,6,142,42,171,177,214,82,215,185,104,72,214,98,19,183,207,135,17,67,240,67,95,205,248,26,223,188,28,146,202,181,247,102,104,167,174,39,89,135,17,174,33,62,86,4,48,71,33,45,80,43,204,34,4,75,10,60,13,206,161,46,89,169,177,80,69,73,50,11,135,184,208,146,157,35,153,131,8,223,161,157,240,196,60,251,164,145,241,188,208,82,37,108,193,45,21,156,229,84,43,93,210,198,169,198,32,87,198,212,238,226,215,167,201,167,216,135,171,169,195,209,219,179,237,152,252,27,198,106,182,67,31,199,161,93,168,175,78,207,111,240,57,174,230,158,175,126,172,3,197,84,95,64,228,152,77,1,55,173,199,62,110,123,59,56,223,63,172,156,199,99,130,116,7,24,125,184,184,176,125,154,160,37,217,232,31,30,255,232,214,102,10,113,232,254,163,81,179,52,102,226,72,75,118,146,187,236,160,243,225,208,194,203,41,175,200,187,167,105,136,31,190,160,29,70,183,115,107,70,222,160,42,114,71,156,133,218,228,185,160,78,213,57,21,210,20,20,156,21,180,110,210,122,58,235,192,128,189,35,73,201,63,242,223,238,194,231,159,253,229,47,172,234,247,239,83,245,77,225,250,130,172,230,191,145,116,220,47,162,246,199,116,126,1,218,139,177,101,210,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private string _addRights;
			public override string AddRights {
				get {
					return _addRights ?? (_addRights = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,93,144,193,106,195,48,16,68,127,197,184,215,40,216,150,101,75,190,166,110,9,148,166,36,208,75,240,97,37,173,18,131,44,7,89,110,9,33,255,94,57,133,30,122,219,55,48,195,206,28,111,91,221,164,8,165,206,106,35,9,170,186,38,165,148,53,145,69,77,9,207,51,174,25,101,138,49,76,87,27,112,123,4,221,4,63,227,2,173,238,195,31,60,163,197,128,191,120,24,103,175,176,73,105,186,122,245,224,2,198,187,29,46,118,188,98,140,121,135,33,242,241,105,201,74,70,175,209,175,95,122,63,133,164,15,56,36,163,73,60,78,179,13,189,59,37,106,180,22,85,232,71,183,222,125,59,244,79,93,186,250,4,59,63,252,199,237,244,16,15,234,140,3,52,6,236,132,221,58,170,255,132,214,226,128,46,52,55,195,88,165,50,202,136,42,65,199,150,12,136,192,50,35,69,73,153,201,10,41,4,210,123,52,124,128,143,47,6,244,209,34,180,164,6,56,17,181,48,164,172,76,73,100,21,135,201,43,149,115,70,85,6,88,45,150,214,133,62,92,55,163,157,7,215,220,120,174,56,210,156,147,186,2,69,74,46,24,17,32,100,12,169,178,184,235,178,38,220,187,165,204,238,130,30,150,126,251,254,116,14,111,248,133,182,73,139,244,222,253,0,138,249,68,249,152,1,0,0 })));
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

		#region Class: SendEmailUserTask1FlowElement

		/// <exclude/>
		public class SendEmailUserTask1FlowElement : SendEmailUserTask
		{

			#region Constructors: Public

			public SendEmailUserTask1FlowElement(UserConnection userConnection, OrderVisaProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SendEmailUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("7b1bce61-7682-4d71-99ce-36b72451bdad");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recepient = () => new LocalizableString(((process.ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? process.ReadDataUserTask2.ResultEntity.GetTypedColumnValue<string>("Email") : null)));
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

			#endregion

		}

		#endregion

		#region Class: GiveRightsToVisaOwnerFlowElement

		/// <exclude/>
		public class GiveRightsToVisaOwnerFlowElement : ChangeAdminRightsUserTask
		{

			#region Constructors: Public

			public GiveRightsToVisaOwnerFlowElement(UserConnection userConnection, OrderVisaProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "GiveRightsToVisaOwner";
				IsLogging = true;
				SchemaElementUId = new Guid("47428468-6fc8-44b4-ac36-afafef90436c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_role1 = () => (Guid)((process.AutoGeneratedPageUserTask1.VisaOwner));
			}

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,79,107,220,48,16,197,191,139,14,61,89,197,178,44,217,114,143,203,182,236,37,13,109,90,10,201,18,70,210,40,43,240,159,141,37,211,4,179,223,189,242,58,155,66,14,165,244,86,240,65,26,251,189,249,205,99,60,223,251,240,209,183,17,199,198,65,27,48,155,118,182,33,185,99,181,99,26,169,168,164,160,37,23,140,106,97,144,26,110,192,202,82,49,229,74,146,245,208,97,67,86,245,214,250,72,50,31,177,11,205,237,252,219,52,142,19,102,247,238,124,249,106,14,216,193,183,165,65,157,23,170,20,117,65,115,169,83,3,7,64,161,22,142,114,94,112,20,130,75,93,49,178,178,48,161,133,51,88,81,41,57,167,101,197,10,90,59,94,37,32,46,173,230,88,49,201,73,214,162,139,219,167,227,136,33,248,161,111,102,124,61,223,60,31,19,229,218,123,51,180,83,215,147,172,195,8,215,16,15,13,1,204,177,20,6,168,41,213,2,146,250,0,87,150,114,208,85,81,213,200,36,171,72,102,224,24,23,91,178,179,36,179,16,225,59,180,19,158,157,103,159,24,11,158,179,90,200,164,101,220,164,188,138,156,214,178,174,168,179,210,41,228,82,41,109,47,121,125,154,124,58,251,112,53,117,56,122,243,18,59,166,252,134,177,153,205,208,199,113,104,23,235,171,243,231,55,248,20,215,112,95,94,253,88,7,138,169,190,136,200,41,155,2,110,90,143,125,220,246,102,176,190,127,88,61,79,167,36,233,142,48,250,112,73,97,251,56,65,75,178,209,63,28,254,152,214,102,10,113,232,254,163,81,179,52,102,242,72,75,118,198,93,118,208,250,112,108,225,249,124,111,200,187,199,105,136,31,190,160,25,70,187,179,235,141,188,81,53,228,142,88,3,90,229,121,73,173,212,57,45,133,98,20,172,41,169,118,105,61,173,177,160,192,220,145,68,242,143,254,183,187,240,249,103,127,249,23,86,250,253,251,84,125,83,184,190,40,155,249,111,144,78,251,5,106,127,74,207,47,49,186,224,44,210,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private string _addRights;
			public override string AddRights {
				get {
					return _addRights ?? (_addRights = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,93,143,205,106,195,48,16,132,95,197,40,87,43,40,182,172,88,186,149,54,148,64,105,138,13,189,4,31,86,218,117,99,144,127,80,148,148,18,242,238,117,210,246,210,219,124,179,12,179,179,191,108,209,48,64,153,101,40,20,71,167,144,203,214,21,220,162,205,56,22,173,182,153,116,14,165,101,233,35,12,21,1,154,24,78,116,131,13,118,209,180,224,143,119,122,34,79,145,126,185,30,79,193,145,97,57,75,159,3,12,145,102,93,141,158,88,250,10,253,172,247,139,122,34,215,181,95,9,76,83,24,207,224,147,9,194,124,138,20,142,203,228,225,110,82,88,52,44,125,7,127,186,39,246,219,227,238,115,160,80,187,3,245,240,83,212,44,103,247,159,177,241,212,211,16,205,69,175,37,172,86,121,203,193,21,243,42,85,34,47,201,89,78,22,133,144,214,106,73,250,58,7,222,254,154,205,69,150,36,112,93,72,46,74,39,184,20,160,185,198,92,115,37,148,82,182,133,204,81,121,109,110,111,237,38,10,16,187,113,168,186,143,67,124,161,51,121,195,50,118,109,190,1,124,82,213,179,82,1,0,0 })));
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

		public OrderVisaProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OrderVisaProcess";
			SchemaUId = new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47");
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
				return new Guid("ede755ac-401e-48b6-ab6a-5dba4123df47");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: OrderVisaProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: OrderVisaProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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
					SchemaElementUId = new Guid("cab8cfe0-d5f3-4c99-aeb8-34206447bc9f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private AutoGeneratedPageUserTask1FlowElement _autoGeneratedPageUserTask1;
		public AutoGeneratedPageUserTask1FlowElement AutoGeneratedPageUserTask1 {
			get {
				return _autoGeneratedPageUserTask1 ?? (_autoGeneratedPageUserTask1 = new AutoGeneratedPageUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadDataUserTask1FlowElement _readDataUserTask1;
		public ReadDataUserTask1FlowElement ReadDataUserTask1 {
			get {
				return _readDataUserTask1 ?? (_readDataUserTask1 = new ReadDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadDataUserTask2FlowElement _readDataUserTask2;
		public ReadDataUserTask2FlowElement ReadDataUserTask2 {
			get {
				return _readDataUserTask2 ?? (_readDataUserTask2 = new ReadDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeAdminRightsUserTask1FlowElement _changeAdminRightsUserTask1;
		public ChangeAdminRightsUserTask1FlowElement ChangeAdminRightsUserTask1 {
			get {
				return _changeAdminRightsUserTask1 ?? (_changeAdminRightsUserTask1 = new ChangeAdminRightsUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private OrderVisaSubProcessFlowElement _orderVisaSubProcess;
		public OrderVisaSubProcessFlowElement OrderVisaSubProcess {
			get {
				return _orderVisaSubProcess ?? ((_orderVisaSubProcess) = new OrderVisaSubProcessFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("8b821e7e-d93f-48cf-8c17-e2fa1b5ce7c7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
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
					SchemaElementUId = new Guid("4319201a-d137-4f87-932a-1caf6cec6b0e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask1Execute,
				});
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
					SchemaElementUId = new Guid("dd16215e-5225-4211-83b6-8515e3cfaf51"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask2Execute,
				});
			}
		}

		private ChangeAdminRightsUserTask2FlowElement _changeAdminRightsUserTask2;
		public ChangeAdminRightsUserTask2FlowElement ChangeAdminRightsUserTask2 {
			get {
				return _changeAdminRightsUserTask2 ?? (_changeAdminRightsUserTask2 = new ChangeAdminRightsUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("f4006d4f-d961-4241-82de-5bd4162bb3c8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask3Execute,
				});
			}
		}

		private ProcessScriptTask _formulaTask4;
		public ProcessScriptTask FormulaTask4 {
			get {
				return _formulaTask4 ?? (_formulaTask4 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask4",
					SchemaElementUId = new Guid("d7069b39-753a-41ff-8cbc-cb63bedc2f31"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask4Execute,
				});
			}
		}

		private SendEmailUserTask1FlowElement _sendEmailUserTask1;
		public SendEmailUserTask1FlowElement SendEmailUserTask1 {
			get {
				return _sendEmailUserTask1 ?? (_sendEmailUserTask1 = new SendEmailUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("d794aebd-7733-44f5-a744-3f6f8b28094e"),
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
					SchemaElementUId = new Guid("8e563afe-5967-487f-9123-59379b11d248"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("974a113f-ac5d-468d-8ecb-ebd004bb94e9"), new Collection<Guid>() {
							new Guid("dd340939-b2f0-473c-8b99-ea9e4352ee64"),
						}},
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
					SchemaElementUId = new Guid("72cd1145-9f82-4d0b-a86b-9ce612885050"),
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
					SchemaElementUId = new Guid("a35a66f4-7cf7-47d0-b5e2-acd4b7e99a59"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessToken _giveRightsToVisaOwnerOrderVisaSubProcessToken;
		public ProcessToken GiveRightsToVisaOwnerOrderVisaSubProcessToken {
			get {
				return _giveRightsToVisaOwnerOrderVisaSubProcessToken ?? (_giveRightsToVisaOwnerOrderVisaSubProcessToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "GiveRightsToVisaOwnerOrderVisaSubProcessToken",
					SchemaElementUId = new Guid("e0e5365e-335d-4089-bd90-8f614b124d39"),
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
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[AutoGeneratedPageUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AutoGeneratedPageUserTask1 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[ReadDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask2 };
			FlowElements[ChangeAdminRightsUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeAdminRightsUserTask1 };
			FlowElements[OrderVisaSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { OrderVisaSubProcess };
			FlowElements[Terminate2.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate2 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
			FlowElements[FormulaTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask2 };
			FlowElements[ChangeAdminRightsUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeAdminRightsUserTask2 };
			FlowElements[FormulaTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask3 };
			FlowElements[FormulaTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask4 };
			FlowElements[SendEmailUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { SendEmailUserTask1 };
			FlowElements[Terminate3.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate3 };
			FlowElements[GiveRightsToVisaOwner.SchemaElementUId] = new Collection<ProcessFlowElement> { GiveRightsToVisaOwner };
			FlowElements[GiveRightsToVisaOwnerOrderVisaSubProcessToken.SchemaElementUId] = new Collection<ProcessFlowElement> { GiveRightsToVisaOwnerOrderVisaSubProcessToken };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AutoGeneratedPageUserTask1", e.Context.SenderName));
						break;
					case "AutoGeneratedPageUserTask1":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
							break;
						}
						Log.ErrorFormat(DeadEndGatewayLogMessage, "AutoGeneratedPageUserTask1");
						break;
					case "ReadDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask2", e.Context.SenderName));
						break;
					case "ReadDataUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeAdminRightsUserTask1", e.Context.SenderName));
						break;
					case "ChangeAdminRightsUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("GiveRightsToVisaOwner", e.Context.SenderName));
						break;
					case "OrderVisaSubProcess":
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
							break;
						}
						if (ConditionalFlow4ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask3", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate2", e.Context.SenderName));
						break;
					case "Terminate2":
						CompleteProcess();
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask2", e.Context.SenderName));
						break;
					case "FormulaTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeAdminRightsUserTask2", e.Context.SenderName));
						break;
					case "ChangeAdminRightsUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SendEmailUserTask1", e.Context.SenderName));
						break;
					case "FormulaTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask4", e.Context.SenderName));
						break;
					case "FormulaTask4":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SendEmailUserTask1", e.Context.SenderName));
						break;
					case "SendEmailUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate3", e.Context.SenderName));
						break;
					case "Terminate3":
						CompleteProcess();
						break;
					case "GiveRightsToVisaOwner":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("GiveRightsToVisaOwnerOrderVisaSubProcessToken", e.Context.SenderName));
						break;
					case "GiveRightsToVisaOwnerOrderVisaSubProcessToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OrderVisaSubProcess", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlow2ExpressionExecute() {
			bool result = AutoGeneratedPageUserTask1.PressedButtonCode == @"ButtonOk";
			Log.InfoFormat(ConditionalExpressionLogMessage, "AutoGeneratedPageUserTask1", "ConditionalFlow2", "AutoGeneratedPageUserTask1.PressedButtonCode == @\"ButtonOk\"", result);
			Log.Info($"AutoGeneratedPageUserTask1.PressedButtonCode: {AutoGeneratedPageUserTask1.PressedButtonCode}");
			return result;
		}

		private bool ConditionalFlow3ExpressionExecute() {
			bool result = Convert.ToBoolean((OrderVisaSubProcess.VisaResult)=="Rejected");
			Log.InfoFormat(ConditionalExpressionLogMessage, "OrderVisaSubProcess", "ConditionalFlow3", "(OrderVisaSubProcess.VisaResult)==\"Rejected\"", result);
			return result;
		}

		private bool ConditionalFlow4ExpressionExecute() {
			bool result = Convert.ToBoolean((OrderVisaSubProcess.VisaResult) == "Approved");
			Log.InfoFormat(ConditionalExpressionLogMessage, "OrderVisaSubProcess", "ConditionalFlow4", "(OrderVisaSubProcess.VisaResult) == \"Approved\"", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("AutoGeneratedPageUserTask1.VisaOwner")) {
				writer.WriteValue("AutoGeneratedPageUserTask1.VisaOwner", AutoGeneratedPageUserTask1.VisaOwner, Guid.Empty);
			}
			if (!HasMapping("AutoGeneratedPageUserTask1.Objective")) {
				writer.WriteValue("AutoGeneratedPageUserTask1.Objective", AutoGeneratedPageUserTask1.Objective, null);
			}
			if (!HasMapping("AutoGeneratedPageUserTask1.IsAllowedToDelegate")) {
				writer.WriteValue("AutoGeneratedPageUserTask1.IsAllowedToDelegate", AutoGeneratedPageUserTask1.IsAllowedToDelegate, false);
			}
			if (!HasMapping("ChangeAdminRightsUserTask2.Employee1")) {
				writer.WriteValue("ChangeAdminRightsUserTask2.Employee1", ChangeAdminRightsUserTask2.Employee1, Guid.Empty);
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
			MetaPathParameterValues.Add("3be84f48-2ec9-45e3-9957-5bc4267296c5", () => EmailBody);
			MetaPathParameterValues.Add("f5a0902d-7693-4996-b837-c4f23f36f0e4", () => EmailSubject);
			MetaPathParameterValues.Add("dcab9004-d6b0-4591-adc4-bf85fdcda9ac", () => RecordId);
			MetaPathParameterValues.Add("7d5d0c86-68d0-40b8-b86e-948614c80619", () => AutoGeneratedPageUserTask1.Title);
			MetaPathParameterValues.Add("e685a7b9-94b0-4438-b0c5-243b4f6a690e", () => AutoGeneratedPageUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("b0717664-6354-45ab-bd3c-53fe9b7c8b78", () => AutoGeneratedPageUserTask1.Recommendation);
			MetaPathParameterValues.Add("6c67afa0-5b6b-4e31-bc55-82a4883ce328", () => AutoGeneratedPageUserTask1.EntityId);
			MetaPathParameterValues.Add("f4ee6415-c497-4e78-a929-febe1125aac3", () => AutoGeneratedPageUserTask1.Buttons);
			MetaPathParameterValues.Add("dd2f6a69-a67d-4da1-b6d3-eb804984848e", () => AutoGeneratedPageUserTask1.Elements);
			MetaPathParameterValues.Add("de9d4b1e-dc1e-405b-ad5e-155376db49f5", () => AutoGeneratedPageUserTask1.ExtendedClientModule);
			MetaPathParameterValues.Add("ffeb48c9-a70a-4533-b631-94d55a3f5993", () => AutoGeneratedPageUserTask1.EntryPointId);
			MetaPathParameterValues.Add("71c1b336-d3e4-4fea-ae5f-fe4c6a6099fa", () => AutoGeneratedPageUserTask1.PressedButtonCode);
			MetaPathParameterValues.Add("6444f7f7-650a-40b8-9eae-e9eb023ee67c", () => AutoGeneratedPageUserTask1.OwnerId);
			MetaPathParameterValues.Add("54530a2b-97d6-474a-9038-ac4b4ad703ab", () => AutoGeneratedPageUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("170a5e21-3611-43ae-8fd7-1be80e149ed9", () => AutoGeneratedPageUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("ac69f773-300c-46c8-b710-efaa4c62ec0b", () => AutoGeneratedPageUserTask1.IsRunning);
			MetaPathParameterValues.Add("48e0d754-08c0-40a9-9d39-60666bfa2ce8", () => AutoGeneratedPageUserTask1.VisaOwner);
			MetaPathParameterValues.Add("cb3cea56-7d6a-486a-9408-7f11b73730cd", () => AutoGeneratedPageUserTask1.Objective);
			MetaPathParameterValues.Add("5aa0f7c2-d6d9-45eb-9d46-002d2f9f7ef5", () => AutoGeneratedPageUserTask1.IsAllowedToDelegate);
			MetaPathParameterValues.Add("47332adc-637c-4b3a-808e-39197ef2431d", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("5e08c82f-f563-4b4f-b5de-a3106f4c302c", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("67079823-ca29-4171-98e9-2eb22d596163", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("b31d769e-31c1-4e18-b3fc-0e74bfbefd63", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("088b2d27-0d05-40fb-ae62-f22fc1d90d83", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("4ba624fc-7ec2-45d2-8d59-eef1c3cb9809", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("912cfc03-f375-49d8-a280-eac85b844d25", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("f9db3fa8-979f-46f4-b673-16c1853c0ae6", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("2220dcad-7243-4a68-b0b9-2d67a4ce1199", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("aac3176b-4b48-4126-ae99-fbe31bd9fb86", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("9715e434-be86-4b63-8778-cd749be859b9", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("39be95a0-1ca9-49e4-a8a3-923dd3e29e03", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("3d04bdfa-d07c-4250-b41d-c15861060bee", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("71a1e3c8-62e8-4d9e-849a-8f297265d848", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("b428b93e-5086-4d8a-bc68-88b7aa053524", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("d3a1b1f9-bf92-4481-a5e5-c9e7b75cb477", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("5b9f0015-f772-42da-baec-7aac33c39049", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("45dffa51-3539-4fdd-8cb4-25f3363526bf", () => ReadDataUserTask1.ResultCompositeObjectList);
			MetaPathParameterValues.Add("d9b534da-5393-42f1-be32-e6cc6675654a", () => ReadDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("c2832253-8b80-4bd4-9059-3d26e46fa2b9", () => ReadDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("434ce1d3-6e07-4699-93db-b01705ec21d1", () => ReadDataUserTask2.ResultType);
			MetaPathParameterValues.Add("d9d40c49-13a3-46fc-ad8b-a4f987b3e7ae", () => ReadDataUserTask2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("1063030b-28ed-4349-83f1-f88f0c253b8f", () => ReadDataUserTask2.NumberOfRecords);
			MetaPathParameterValues.Add("35901807-73b5-4d6a-a986-4a703ce774bc", () => ReadDataUserTask2.FunctionType);
			MetaPathParameterValues.Add("b3f68a12-f0e7-4dbc-95dc-3aa993f1396a", () => ReadDataUserTask2.AggregationColumnName);
			MetaPathParameterValues.Add("3df2bdde-18ee-451a-905a-ba278470a322", () => ReadDataUserTask2.OrderInfo);
			MetaPathParameterValues.Add("5b159456-5fda-4b8d-a9da-8834e8ecff25", () => ReadDataUserTask2.ResultEntity);
			MetaPathParameterValues.Add("cab64fdd-d9c8-4716-9374-04b8c65c8e58", () => ReadDataUserTask2.ResultCount);
			MetaPathParameterValues.Add("75b749cb-919a-4155-bc75-71aeaac350c3", () => ReadDataUserTask2.ResultIntegerFunction);
			MetaPathParameterValues.Add("ebe93ac6-61cb-4604-b9fb-2f61805b7505", () => ReadDataUserTask2.ResultFloatFunction);
			MetaPathParameterValues.Add("a00022fb-ec61-40f9-9ff8-7671f9aa224d", () => ReadDataUserTask2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("af966caf-821e-4b78-aa8c-6616c22121fd", () => ReadDataUserTask2.ResultRowsCount);
			MetaPathParameterValues.Add("2a686d88-37aa-4fe9-8504-56df612323cf", () => ReadDataUserTask2.CanReadUncommitedData);
			MetaPathParameterValues.Add("7fa4e729-8a82-4309-b45d-78704c4aa63b", () => ReadDataUserTask2.ResultEntityCollection);
			MetaPathParameterValues.Add("e1371407-e306-4321-b51f-29ca9ebcdeba", () => ReadDataUserTask2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("610abf96-01f0-45e3-a38b-748d3acf7700", () => ReadDataUserTask2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("543a50ee-266b-44ae-9cda-3cd5c8a31403", () => ReadDataUserTask2.ResultCompositeObjectList);
			MetaPathParameterValues.Add("42a55883-c37d-44f5-99aa-e6759f2622e2", () => ReadDataUserTask2.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("7a0f3021-87ac-40b1-a047-2efc1706f4df", () => ChangeAdminRightsUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("49180349-f18b-43d5-b1ff-f3696e187539", () => ChangeAdminRightsUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("85f4379a-e11e-4bb2-9820-64ceda7a6dae", () => ChangeAdminRightsUserTask1.DeleteRights);
			MetaPathParameterValues.Add("aaac2e3d-968e-44df-9437-d7259ef3353c", () => ChangeAdminRightsUserTask1.AddRights);
			MetaPathParameterValues.Add("f55702a5-89cb-4603-a337-bbf985ba4fd9", () => OrderVisaSubProcess.Order);
			MetaPathParameterValues.Add("0aabfff9-93ff-46e0-bd91-bd4a90083993", () => OrderVisaSubProcess.VisaOwner);
			MetaPathParameterValues.Add("4460c79c-4faf-42e4-bc80-b7e9caa8d023", () => OrderVisaSubProcess.VisaObjective);
			MetaPathParameterValues.Add("0e8d8a98-20fb-40c2-92ba-536a8b9a9263", () => OrderVisaSubProcess.VisaResult);
			MetaPathParameterValues.Add("1cc8b94b-0076-4f89-9664-ce3c3049d133", () => OrderVisaSubProcess.IsAllowedToDelegate);
			MetaPathParameterValues.Add("10e3cea0-d69d-4274-83e4-5d162e3671d9", () => OrderVisaSubProcess.IsPreviousVisaCounts);
			MetaPathParameterValues.Add("715d9783-6e60-4275-a211-6654d9017627", () => ChangeAdminRightsUserTask2.EntitySchemaUId);
			MetaPathParameterValues.Add("a86cf9e4-ea24-4335-9045-5cc306b446ed", () => ChangeAdminRightsUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("2b09ebf2-4fc5-4866-9c5f-fdb6ecbb4544", () => ChangeAdminRightsUserTask2.DeleteRights);
			MetaPathParameterValues.Add("b0fd2cf4-cef1-4cbb-ad13-35a8ed0e2519", () => ChangeAdminRightsUserTask2.AddRights);
			MetaPathParameterValues.Add("ea4d07fb-ec77-4bb7-b273-8108d535c55e", () => ChangeAdminRightsUserTask2.Employee1);
			MetaPathParameterValues.Add("d8e02cae-bddc-4ad4-b1a7-d3884e48b3e0", () => SendEmailUserTask1.Sender);
			MetaPathParameterValues.Add("279b36d4-3051-42d2-855e-a6468792afd5", () => SendEmailUserTask1.Recepient);
			MetaPathParameterValues.Add("d9fc1537-e977-47b2-ad3a-1969e1f46250", () => SendEmailUserTask1.CopyRecepient);
			MetaPathParameterValues.Add("293075ea-1e56-4c2d-96c4-ea3d418c0825", () => SendEmailUserTask1.BlindCopyRecepient);
			MetaPathParameterValues.Add("9efb7ccc-4ec1-4628-810b-b039072bc1eb", () => SendEmailUserTask1.Subject);
			MetaPathParameterValues.Add("b7dd75b0-1de1-4b8a-bfed-006a54509a92", () => SendEmailUserTask1.Body);
			MetaPathParameterValues.Add("a7dc66e5-5d32-44bc-b00b-d47172fbbffb", () => SendEmailUserTask1.Importance);
			MetaPathParameterValues.Add("bcb8c68f-82ae-42bc-a9f6-b0ef566ea9c9", () => SendEmailUserTask1.IsIgnoreErrors);
			MetaPathParameterValues.Add("8bb24c30-d947-4357-9f8b-67567a930b23", () => GiveRightsToVisaOwner.EntitySchemaUId);
			MetaPathParameterValues.Add("5d6d30fd-b020-4557-abfa-83f41068a362", () => GiveRightsToVisaOwner.DataSourceFilters);
			MetaPathParameterValues.Add("528b6dbc-3e55-4984-ac5c-3561f9fc45d5", () => GiveRightsToVisaOwner.DeleteRights);
			MetaPathParameterValues.Add("53b17576-c93f-48fc-b7e5-4f5b50ba8e72", () => GiveRightsToVisaOwner.AddRights);
			MetaPathParameterValues.Add("ad422d06-dc6d-4fc5-bdb2-d5f9b24ccd4b", () => GiveRightsToVisaOwner.Role1);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "AutoGeneratedPageUserTask1.VisaOwner":
					AutoGeneratedPageUserTask1.VisaOwner = reader.GetValue<System.Guid>();
				break;
				case "AutoGeneratedPageUserTask1.Objective":
					AutoGeneratedPageUserTask1.Objective = reader.GetValue<System.String>();
				break;
				case "AutoGeneratedPageUserTask1.IsAllowedToDelegate":
					AutoGeneratedPageUserTask1.IsAllowedToDelegate = reader.GetValue<System.Boolean>();
				break;
				case "ChangeAdminRightsUserTask2.Employee1":
					ChangeAdminRightsUserTask2.Employee1 = reader.GetValue<System.Guid>();
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

		public virtual bool FormulaTask1Execute(ProcessExecutingContext context) {
			var localEmailBody = string.Format(BodyRejected,((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Number").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<string>("Number") : null)));
			EmailBody = (System.String)localEmailBody;
			return true;
		}

		public virtual bool FormulaTask2Execute(ProcessExecutingContext context) {
			var localEmailSubject = SubjectRejected;
			EmailSubject = (System.String)localEmailSubject;
			return true;
		}

		public virtual bool FormulaTask3Execute(ProcessExecutingContext context) {
			var localEmailBody = string.Format(BodyApproved,((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Number").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<string>("Number") : null)));
			EmailBody = (System.String)localEmailBody;
			return true;
		}

		public virtual bool FormulaTask4Execute(ProcessExecutingContext context) {
			var localEmailSubject = SubjectApproved;
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
			var cloneItem = (OrderVisaProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

