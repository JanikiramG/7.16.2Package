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

	#region Class: CreateActivityProcessCloneForDocumentSchema

	/// <exclude/>
	public class CreateActivityProcessCloneForDocumentSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public CreateActivityProcessCloneForDocumentSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public CreateActivityProcessCloneForDocumentSchema(CreateActivityProcessCloneForDocumentSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CreateActivityProcessCloneForDocument";
			UId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.15.2.501";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = false;
			SerializeToMemory = true;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982");
			Version = 0;
			PackageUId = new Guid("f0a4df72-c82f-425f-8080-82c120139634");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreatePageInstanceIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("48afa22b-7602-4990-9f3e-061a442a8e6a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Direction = ProcessSchemaParameterDirection.In,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"PageInstanceId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateActiveTreeGridCurrentRowIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("68768651-b929-4d24-ad67-4b7f1dd06f1b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Direction = ProcessSchemaParameterDirection.In,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"ActiveTreeGridCurrentRowId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedActivityParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5fca99d5-4536-4f81-8778-87f2b17c44ed"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"SelectedActivity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreatePageInstanceIdParameter());
			Parameters.Add(CreateActiveTreeGridCurrentRowIdParameter());
			Parameters.Add(CreateSelectedActivityParameter());
		}

		protected virtual void InitializeOpenActivityTypeLookupUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var pageParametersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7c42a570-d16c-4740-85e9-587a7c231a16"),
				ContainerUId = new Guid("3d73d129-a59e-4b61-bb05-e48e4209788e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"PageParameters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object")
			};
			pageParametersParameter.SourceValue = new ProcessSchemaParameterValue(pageParametersParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(pageParametersParameter);
			var processKeyParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7222b831-d4eb-4d55-b69b-0bf8578b9e9e"),
				ContainerUId = new Guid("3d73d129-a59e-4b61-bb05-e48e4209788e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"ProcessKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			processKeyParameter.SourceValue = new ProcessSchemaParameterValue(processKeyParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(processKeyParameter);
			var userContextKeyParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5b90e09c-c471-46d6-9f5d-87cdc7efe4e4"),
				ContainerUId = new Guid("3d73d129-a59e-4b61-bb05-e48e4209788e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"UserContextKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			userContextKeyParameter.SourceValue = new ProcessSchemaParameterValue(userContextKeyParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(userContextKeyParameter);
			var useCurrentActivePageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fc012c0e-2e6c-421b-ad7f-440b0f036325"),
				ContainerUId = new Guid("3d73d129-a59e-4b61-bb05-e48e4209788e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"UseCurrentActivePage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			useCurrentActivePageParameter.SourceValue = new ProcessSchemaParameterValue(useCurrentActivePageParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(useCurrentActivePageParameter);
		}

		protected virtual void InitializeOpenActivityEditPageUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var pageUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9cc3e5db-0506-47e6-8b27-efadda2cb88b"),
				ContainerUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			pageUIdParameter.SourceValue = new ProcessSchemaParameterValue(pageUIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(pageUIdParameter);
			var pageUrlParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b79dad0a-6cf5-450f-a4e6-b8917e7e9301"),
				ContainerUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageUrl",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			pageUrlParameter.SourceValue = new ProcessSchemaParameterValue(pageUrlParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(pageUrlParameter);
			var openerInstanceIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("26db47b8-17d4-4ffb-82e9-4453d8f508b2"),
				ContainerUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"OpenerInstanceId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			openerInstanceIdParameter.SourceValue = new ProcessSchemaParameterValue(openerInstanceIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(openerInstanceIdParameter);
			var closeOpenerOnLoadParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c9a42adb-6104-4870-b756-4bf340757950"),
				ContainerUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"CloseOpenerOnLoad",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			closeOpenerOnLoadParameter.SourceValue = new ProcessSchemaParameterValue(closeOpenerOnLoadParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(closeOpenerOnLoadParameter);
			var pageParametersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a7cfd311-080e-4bea-a766-8e8dcab60aa0"),
				ContainerUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageParameters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object")
			};
			pageParametersParameter.SourceValue = new ProcessSchemaParameterValue(pageParametersParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(pageParametersParameter);
			var widthParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a0be2a70-6167-4750-b6fc-cfd85f6f52f7"),
				ContainerUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Width",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			widthParameter.SourceValue = new ProcessSchemaParameterValue(widthParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(widthParameter);
			var closeMessageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("824337a6-ab71-4560-9425-1820381aef1c"),
				ContainerUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"CloseMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			closeMessageParameter.SourceValue = new ProcessSchemaParameterValue(closeMessageParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(closeMessageParameter);
			var heightParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0362a1ad-23f4-400f-9c87-58b6ae2cfae0"),
				ContainerUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Height",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			heightParameter.SourceValue = new ProcessSchemaParameterValue(heightParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(heightParameter);
			var centeredParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3bdd4182-000f-4d5c-8cf4-d1234ab6bba7"),
				ContainerUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Centered",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object")
			};
			centeredParameter.SourceValue = new ProcessSchemaParameterValue(centeredParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(centeredParameter);
			var useOpenerRegisterScriptParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3e111e58-83bf-4da4-823f-cb70ffcf49f5"),
				ContainerUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"UseOpenerRegisterScript",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			useOpenerRegisterScriptParameter.SourceValue = new ProcessSchemaParameterValue(useOpenerRegisterScriptParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(useOpenerRegisterScriptParameter);
			var useCurrentActivePageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d1d2784c-8bea-4fd7-a223-bb3659de78c7"),
				ContainerUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"UseCurrentActivePage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			useCurrentActivePageParameter.SourceValue = new ProcessSchemaParameterValue(useCurrentActivePageParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(useCurrentActivePageParameter);
			var ignoreProfileParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bb40ba52-ad85-4880-90df-f4882e51e669"),
				ContainerUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"IgnoreProfile",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreProfileParameter.SourceValue = new ProcessSchemaParameterValue(ignoreProfileParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreProfileParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet44 = CreateLaneSet44LaneSet();
			LaneSets.Add(schemaLaneSet44);
			ProcessSchemaLane schemaLane132 = CreateLane132Lane();
			schemaLaneSet44.Lanes.Add(schemaLane132);
			ProcessSchemaStartEvent createactivitystart = CreateCreateActivityStartStartEvent();
			FlowElements.Add(createactivitystart);
			ProcessSchemaEndEvent createactivityend = CreateCreateActivityEndEndEvent();
			FlowElements.Add(createactivityend);
			ProcessSchemaScriptTask beforeopenactivitytypelookupusertaskscripttask = CreateBeforeOpenActivityTypeLookupUserTaskScriptTaskScriptTask();
			FlowElements.Add(beforeopenactivitytypelookupusertaskscripttask);
			ProcessSchemaUserTask openactivitytypelookupusertask = CreateOpenActivityTypeLookupUserTaskUserTask();
			FlowElements.Add(openactivitytypelookupusertask);
			ProcessSchemaScriptTask beforeopenactivityeditpageusertaskscripttask = CreateBeforeOpenActivityEditPageUserTaskScriptTaskScriptTask();
			FlowElements.Add(beforeopenactivityeditpageusertaskscripttask);
			ProcessSchemaUserTask openactivityeditpageusertask = CreateOpenActivityEditPageUserTaskUserTask();
			FlowElements.Add(openactivityeditpageusertask);
			ProcessSchemaIntermediateCatchMessageEvent lookupgridpageclosedintermediatecatchmessageevent = CreateLookupGridPageClosedIntermediateCatchMessageEventIntermediateCatchMessageEvent();
			FlowElements.Add(lookupgridpageclosedintermediatecatchmessageevent);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			Artifacts.Add(CreateChooseActivityTypeGroupGroup());
			Artifacts.Add(CreateOpenActivityEditPageGroupGroup());
			FlowElements.Add(CreateSequenceFlow445SequenceFlow());
			FlowElements.Add(CreateSequenceFlow446SequenceFlow());
			FlowElements.Add(CreateSequenceFlow447SequenceFlow());
			FlowElements.Add(CreateSequenceFlow448SequenceFlow());
			FlowElements.Add(CreateSequenceFlow449SequenceFlow());
			FlowElements.Add(CreateSequenceFlow450SequenceFlow());
			FlowElements.Add(CreateConditionalFlow33ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow452SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow445SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow445",
				UId = new Guid("0c4f094c-4d91-4bf6-b6b6-66251497ad4d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				CurveCenterPosition = new Point(169, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6fc4602c-fc70-44c3-970e-fd8f8c346555"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c27651a6-c904-4c67-b6cd-02bcf3eef885"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow446SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow446",
				UId = new Guid("25133738-d010-4dcc-97e8-0478ab9fa550"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				CurveCenterPosition = new Point(528, 294),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("507d0b8e-760c-4043-aa61-4603a3736178"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow447SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow447",
				UId = new Guid("aa53f9fd-740d-434e-b186-4e3146651918"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				CurveCenterPosition = new Point(346, 200),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("467490ca-d037-45ec-a492-7d5378b331f1"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("920b034f-e9f0-4a34-9ffe-6dd95c6d8119"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow448SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow448",
				UId = new Guid("951e2629-0b2d-485f-8466-c7e6827b297e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				CurveCenterPosition = new Point(366, 106),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c27651a6-c904-4c67-b6cd-02bcf3eef885"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3d73d129-a59e-4b61-bb05-e48e4209788e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow449SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow449",
				UId = new Guid("ee5128a2-2875-4375-bea1-e7fc9b896bc4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				CurveCenterPosition = new Point(497, 106),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3d73d129-a59e-4b61-bb05-e48e4209788e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("467490ca-d037-45ec-a492-7d5378b331f1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow450SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow450",
				UId = new Guid("0c4dbc32-3c79-4aef-a4cf-58e3c95e0e21"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				CurveCenterPosition = new Point(354, 293),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("920b034f-e9f0-4a34-9ffe-6dd95c6d8119"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d2b5ab64-78f2-462b-b415-c626cb09c07d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow33ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow33",
				UId = new Guid("98339cc3-bd6c-44cd-9c17-ca3764eb5c79"),
				ConditionExpression = @"!SelectedActivity",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				CurveCenterPosition = new Point(546, 298),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d2b5ab64-78f2-462b-b415-c626cb09c07d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("507d0b8e-760c-4043-aa61-4603a3736178"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow452SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow452",
				UId = new Guid("539742c1-7fc7-401d-8333-ec4d282aefee"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				CurveCenterPosition = new Point(390, 374),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d2b5ab64-78f2-462b-b415-c626cb09c07d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet44LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet44 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("2ab231ce-25c1-4294-b43e-8e0e7f116999"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"LaneSet44",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(702, 515),
				UseBackgroundMode = false
			};
			return schemaLaneSet44;
		}

		protected virtual ProcessSchemaLane CreateLane132Lane() {
			ProcessSchemaLane schemaLane132 = new ProcessSchemaLane(this) {
				UId = new Guid("49398f23-e44b-4ebd-86a8-a3994832afcc"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("2ab231ce-25c1-4294-b43e-8e0e7f116999"),
				CreatedInOwnerSchemaUId = new Guid("9bbcfc0d-93c2-4a92-8a30-9ccf72b4610e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"Lane132",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(673, 515),
				UseBackgroundMode = false
			};
			return schemaLane132;
		}

		protected virtual ProcessSchemaGroup CreateChooseActivityTypeGroupGroup() {
			ProcessSchemaGroup schemaChooseActivityTypeGroup = new ProcessSchemaGroup(this) {
				UId = new Guid("b4cf2404-62c0-4872-b5fb-84edd60b84a0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("49398f23-e44b-4ebd-86a8-a3994832afcc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				DragGroupName = @"Group",
				IsExpanded = true,
				ManagerItemUId = new Guid("eb7053a9-51e7-456f-9498-73ccc42bfeb6"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"ChooseActivityTypeGroup",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(134, 23),
				Size = new Size(427, 154),
				UseBackgroundMode = false
			};
			schemaChooseActivityTypeGroup.CategorizedFlowElementsUIds = new Collection<Guid>() {
			};
			return schemaChooseActivityTypeGroup;
		}

		protected virtual ProcessSchemaGroup CreateOpenActivityEditPageGroupGroup() {
			ProcessSchemaGroup schemaOpenActivityEditPageGroup = new ProcessSchemaGroup(this) {
				UId = new Guid("279cfd30-17db-450e-9985-cc649b790580"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("49398f23-e44b-4ebd-86a8-a3994832afcc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				DragGroupName = @"Group",
				IsExpanded = true,
				ManagerItemUId = new Guid("eb7053a9-51e7-456f-9498-73ccc42bfeb6"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"OpenActivityEditPageGroup",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(133, 210),
				Size = new Size(427, 291),
				UseBackgroundMode = false
			};
			schemaOpenActivityEditPageGroup.CategorizedFlowElementsUIds = new Collection<Guid>() {
			};
			return schemaOpenActivityEditPageGroup;
		}

		protected virtual ProcessSchemaStartEvent CreateCreateActivityStartStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("6fc4602c-fc70-44c3-970e-fd8f8c346555"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("49398f23-e44b-4ebd-86a8-a3994832afcc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"CreateActivityStart",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(36, 86),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaEndEvent CreateCreateActivityEndEndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("507d0b8e-760c-4043-aa61-4603a3736178"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("49398f23-e44b-4ebd-86a8-a3994832afcc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"CreateActivityEnd",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(631, 275),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBeforeOpenActivityTypeLookupUserTaskScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c27651a6-c904-4c67-b6cd-02bcf3eef885"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b4cf2404-62c0-4872-b5fb-84edd60b84a0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"BeforeOpenActivityTypeLookupUserTaskScriptTask",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(70, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,144,93,79,194,48,20,134,239,251,43,78,118,181,37,108,209,176,1,203,144,132,104,76,136,26,184,128,31,208,181,103,88,25,237,210,158,161,251,247,86,23,69,137,159,119,205,201,243,190,125,206,89,54,168,231,130,212,65,81,183,238,26,188,53,102,215,54,27,135,118,205,221,46,89,89,35,208,185,27,236,224,2,132,209,132,79,244,54,76,22,218,17,215,2,55,11,89,48,71,86,233,45,56,113,143,123,238,39,158,15,198,89,153,202,97,94,198,89,38,69,156,150,114,20,79,228,249,89,60,172,210,156,103,19,153,143,196,56,40,0,216,242,23,11,190,197,21,183,124,143,132,214,249,102,141,143,112,165,124,192,104,110,59,152,246,159,15,192,148,15,40,104,22,70,5,59,112,11,205,105,142,133,63,164,34,248,151,70,193,62,215,39,115,41,195,224,125,255,96,112,188,69,244,53,139,82,209,157,145,232,209,138,215,14,61,118,105,234,26,95,13,167,71,211,83,209,25,84,170,254,112,137,191,133,194,111,44,250,37,175,251,198,23,149,254,229,105,139,212,90,13,100,91,44,158,1,46,160,243,209,40,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenActivityTypeLookupUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("3d73d129-a59e-4b61-bb05-e48e4209788e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b4cf2404-62c0-4872-b5fb-84edd60b84a0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"OpenActivityTypeLookupUserTask",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(217, 49),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeOpenActivityTypeLookupUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateBeforeOpenActivityEditPageUserTaskScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("920b034f-e9f0-4a34-9ffe-6dd95c6d8119"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("279cfd30-17db-450e-9985-cc649b790580"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"BeforeOpenActivityEditPageUserTaskScriptTask",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(71, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,86,93,111,155,48,20,125,46,191,194,229,9,164,128,32,31,132,42,109,165,244,99,85,181,173,141,150,108,47,211,30,140,109,90,214,4,71,198,180,139,170,252,247,217,6,19,72,72,210,62,133,152,235,115,174,239,57,247,154,87,200,0,68,60,121,77,248,106,182,90,146,113,138,111,113,194,39,240,137,220,36,98,157,166,144,173,192,5,72,201,27,216,44,156,103,156,37,233,83,167,248,185,180,108,240,110,156,188,155,113,68,60,136,48,114,80,140,60,7,199,190,239,68,158,23,59,158,231,227,192,35,103,189,16,5,102,7,152,113,55,138,123,103,195,200,9,99,216,115,250,97,4,157,40,56,243,157,193,176,23,120,225,208,63,11,134,208,92,119,36,36,241,195,158,143,201,81,72,216,245,122,1,10,67,7,65,175,239,244,135,253,190,35,80,34,103,16,133,176,31,4,126,23,135,61,13,217,253,24,36,70,24,67,47,24,56,189,174,31,57,253,65,224,57,16,162,200,241,6,113,128,208,176,139,112,232,153,107,99,61,50,140,87,81,197,140,204,9,226,4,143,139,106,38,36,147,245,204,68,237,172,221,194,1,26,253,21,209,151,182,245,184,36,233,184,38,192,55,74,95,242,229,207,140,176,25,204,94,220,59,194,167,37,240,47,56,207,73,102,201,87,215,52,77,137,194,180,237,81,27,187,130,186,199,130,188,32,116,111,23,75,190,42,66,181,220,90,231,150,176,152,50,2,209,51,176,190,146,149,162,157,192,132,109,231,14,18,78,22,32,73,247,157,92,153,98,111,94,114,179,43,224,71,198,122,67,39,211,211,168,71,93,169,240,147,24,88,26,10,92,92,236,169,131,10,61,105,61,184,218,172,206,56,18,33,145,72,228,69,60,8,89,13,9,61,45,202,114,159,61,228,243,249,35,83,229,177,118,113,108,27,48,194,115,150,2,206,36,144,81,87,85,135,85,154,170,63,138,92,118,213,93,158,224,54,200,145,113,196,26,19,70,17,201,50,117,112,128,104,202,201,63,174,23,221,251,52,227,48,69,146,167,244,167,166,120,92,46,41,227,121,42,30,85,14,146,191,205,30,99,132,104,158,242,131,49,194,135,92,60,31,140,185,161,40,95,144,22,32,89,95,117,60,50,99,132,220,177,4,95,231,140,137,200,31,244,77,4,159,138,242,136,162,43,233,36,30,46,113,202,178,205,8,99,48,163,49,119,69,18,113,242,148,51,40,125,225,106,186,237,62,25,21,94,209,40,238,23,194,209,243,23,70,23,55,87,7,178,176,155,206,105,156,101,255,174,81,109,203,118,185,171,4,68,103,75,81,241,53,157,231,139,84,57,240,92,150,231,210,50,27,123,76,187,14,87,87,229,35,80,85,124,19,166,46,220,71,96,170,120,5,179,62,57,17,253,97,76,183,122,77,96,149,246,151,122,9,68,177,54,69,207,100,1,191,195,84,152,154,137,128,166,42,106,188,213,35,44,243,118,119,155,105,3,152,129,150,23,229,232,83,75,2,187,133,81,18,232,86,184,90,61,192,5,145,37,41,210,53,203,209,169,207,63,174,106,35,143,47,99,229,92,84,104,110,177,150,73,56,13,163,189,96,218,174,92,40,176,232,70,185,79,194,213,52,111,32,194,66,192,79,162,149,178,55,144,80,161,225,39,145,74,229,43,164,162,100,36,46,110,163,77,83,63,144,55,53,201,116,81,117,196,206,183,3,216,190,71,228,22,217,154,45,77,118,90,159,24,170,21,43,92,119,140,177,181,95,186,78,203,252,113,103,180,152,231,150,188,53,133,129,235,172,155,198,58,70,186,87,145,206,238,236,220,166,172,51,110,122,240,24,227,94,229,58,187,147,248,16,99,115,22,29,99,61,232,229,78,251,125,210,96,151,67,98,171,223,167,226,110,18,191,55,144,195,223,53,19,213,182,253,145,19,73,191,41,237,182,132,76,80,114,194,118,221,84,153,169,250,20,29,25,155,112,117,14,179,70,36,190,235,218,105,183,174,219,214,59,123,82,79,99,67,34,146,172,95,254,255,1,134,93,101,152,82,11,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenActivityEditPageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("279cfd30-17db-450e-9985-cc649b790580"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"OpenActivityEditPageUserTask",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(190, 191),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeOpenActivityEditPageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateLookupGridPageClosedIntermediateCatchMessageEventIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("467490ca-d037-45ec-a492-7d5378b331f1"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b4cf2404-62c0-4872-b5fb-84edd60b84a0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"LookupGridPageClosed",
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"LookupGridPageClosedIntermediateCatchMessageEvent",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(336, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("d2b5ab64-78f2-462b-b415-c626cb09c07d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("279cfd30-17db-450e-9985-cc649b790580"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(197, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("664357bb-934c-4fde-b2f2-e8fc0a67309b"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new CreateActivityProcessCloneForDocument(userConnection);
		}

		public override object Clone() {
			return new CreateActivityProcessCloneForDocumentSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("75b8cfc6-80da-47f3-a167-779b61341982"));
		}

		#endregion

	}

	#endregion

	#region Class: CreateActivityProcessCloneForDocument

	/// <exclude/>
	public class CreateActivityProcessCloneForDocument : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane132

		/// <exclude/>
		public class ProcessLane132 : ProcessLane
		{

			public ProcessLane132(UserConnection userConnection, CreateActivityProcessCloneForDocument process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: OpenActivityTypeLookupUserTaskFlowElement

		/// <exclude/>
		public class OpenActivityTypeLookupUserTaskFlowElement : OpenLookupUserTask
		{

			#region Constructors: Public

			public OpenActivityTypeLookupUserTaskFlowElement(UserConnection userConnection, CreateActivityProcessCloneForDocument process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenActivityTypeLookupUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("3d73d129-a59e-4b61-bb05-e48e4209788e");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

			#endregion

		}

		#endregion

		#region Class: OpenActivityEditPageUserTaskFlowElement

		/// <exclude/>
		public class OpenActivityEditPageUserTaskFlowElement : OpenPageUserTask
		{

			#region Constructors: Public

			public OpenActivityEditPageUserTaskFlowElement(UserConnection userConnection, CreateActivityProcessCloneForDocument process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenActivityEditPageUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

			#endregion

		}

		#endregion

		public CreateActivityProcessCloneForDocument(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CreateActivityProcessCloneForDocument";
			SchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("75b8cfc6-80da-47f3-a167-779b61341982");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: CreateActivityProcessCloneForDocument, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: CreateActivityProcessCloneForDocument, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual string PageInstanceId {
			get;
			set;
		}

		public virtual Guid ActiveTreeGridCurrentRowId {
			get;
			set;
		}

		public virtual bool SelectedActivity {
			get;
			set;
		}

		private ProcessLane132 _lane132;
		public ProcessLane132 Lane132 {
			get {
				return _lane132 ?? ((_lane132) = new ProcessLane132(UserConnection, this));
			}
		}

		private ProcessFlowElement _createActivityStart;
		public ProcessFlowElement CreateActivityStart {
			get {
				return _createActivityStart ?? (_createActivityStart = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "CreateActivityStart",
					SchemaElementUId = new Guid("6fc4602c-fc70-44c3-970e-fd8f8c346555"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessEndEvent _createActivityEnd;
		public ProcessEndEvent CreateActivityEnd {
			get {
				return _createActivityEnd ?? (_createActivityEnd = new ProcessEndEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEndEvent",
					Name = "CreateActivityEnd",
					SchemaElementUId = new Guid("507d0b8e-760c-4043-aa61-4603a3736178"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _beforeOpenActivityTypeLookupUserTaskScriptTask;
		public ProcessScriptTask BeforeOpenActivityTypeLookupUserTaskScriptTask {
			get {
				return _beforeOpenActivityTypeLookupUserTaskScriptTask ?? (_beforeOpenActivityTypeLookupUserTaskScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BeforeOpenActivityTypeLookupUserTaskScriptTask",
					SchemaElementUId = new Guid("c27651a6-c904-4c67-b6cd-02bcf3eef885"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = BeforeOpenActivityTypeLookupUserTaskScriptTaskExecute,
				});
			}
		}

		private OpenActivityTypeLookupUserTaskFlowElement _openActivityTypeLookupUserTask;
		public OpenActivityTypeLookupUserTaskFlowElement OpenActivityTypeLookupUserTask {
			get {
				return _openActivityTypeLookupUserTask ?? (_openActivityTypeLookupUserTask = new OpenActivityTypeLookupUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _beforeOpenActivityEditPageUserTaskScriptTask;
		public ProcessScriptTask BeforeOpenActivityEditPageUserTaskScriptTask {
			get {
				return _beforeOpenActivityEditPageUserTaskScriptTask ?? (_beforeOpenActivityEditPageUserTaskScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BeforeOpenActivityEditPageUserTaskScriptTask",
					SchemaElementUId = new Guid("920b034f-e9f0-4a34-9ffe-6dd95c6d8119"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = BeforeOpenActivityEditPageUserTaskScriptTaskExecute,
				});
			}
		}

		private OpenActivityEditPageUserTaskFlowElement _openActivityEditPageUserTask;
		public OpenActivityEditPageUserTaskFlowElement OpenActivityEditPageUserTask {
			get {
				return _openActivityEditPageUserTask ?? (_openActivityEditPageUserTask = new OpenActivityEditPageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessIntermediateCatchMessageEvent _lookupGridPageClosedIntermediateCatchMessageEvent;
		public ProcessIntermediateCatchMessageEvent LookupGridPageClosedIntermediateCatchMessageEvent {
			get {
				return _lookupGridPageClosedIntermediateCatchMessageEvent ?? (_lookupGridPageClosedIntermediateCatchMessageEvent = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "LookupGridPageClosedIntermediateCatchMessageEvent",
					SchemaElementUId = new Guid("467490ca-d037-45ec-a492-7d5378b331f1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "LookupGridPageClosed",
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
					SchemaElementUId = new Guid("d2b5ab64-78f2-462b-b415-c626cb09c07d"),
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

		private ProcessConditionalFlow _conditionalFlow33;
		public ProcessConditionalFlow ConditionalFlow33 {
			get {
				return _conditionalFlow33 ?? (_conditionalFlow33 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow33",
					SchemaElementUId = new Guid("98339cc3-bd6c-44cd-9c17-ca3764eb5c79"),
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
			FlowElements[CreateActivityStart.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateActivityStart };
			FlowElements[CreateActivityEnd.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateActivityEnd };
			FlowElements[BeforeOpenActivityTypeLookupUserTaskScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BeforeOpenActivityTypeLookupUserTaskScriptTask };
			FlowElements[OpenActivityTypeLookupUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenActivityTypeLookupUserTask };
			FlowElements[BeforeOpenActivityEditPageUserTaskScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BeforeOpenActivityEditPageUserTaskScriptTask };
			FlowElements[OpenActivityEditPageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenActivityEditPageUserTask };
			FlowElements[LookupGridPageClosedIntermediateCatchMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { LookupGridPageClosedIntermediateCatchMessageEvent };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "CreateActivityStart":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("BeforeOpenActivityTypeLookupUserTaskScriptTask", e.Context.SenderName));
						break;
					case "CreateActivityEnd":
						CompleteProcess();
						break;
					case "BeforeOpenActivityTypeLookupUserTaskScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpenActivityTypeLookupUserTask", e.Context.SenderName));
						break;
					case "OpenActivityTypeLookupUserTask":
						ActivatedEventElements.Add("LookupGridPageClosedIntermediateCatchMessageEvent");
						break;
					case "BeforeOpenActivityEditPageUserTaskScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "OpenActivityEditPageUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CreateActivityEnd", e.Context.SenderName));
						break;
					case "LookupGridPageClosedIntermediateCatchMessageEvent":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("BeforeOpenActivityEditPageUserTaskScriptTask", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow33ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CreateActivityEnd", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpenActivityEditPageUserTask", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlow33ExpressionExecute() {
			bool result = Convert.ToBoolean(!SelectedActivity);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalFlow33", "!SelectedActivity", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("PageInstanceId")) {
				writer.WriteValue("PageInstanceId", PageInstanceId, null);
			}
			if (!HasMapping("SelectedActivity")) {
				writer.WriteValue("SelectedActivity", SelectedActivity, false);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("CreateActivityStart", string.Empty));
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
			MetaPathParameterValues.Add("48afa22b-7602-4990-9f3e-061a442a8e6a", () => PageInstanceId);
			MetaPathParameterValues.Add("68768651-b929-4d24-ad67-4b7f1dd06f1b", () => ActiveTreeGridCurrentRowId);
			MetaPathParameterValues.Add("5fca99d5-4536-4f81-8778-87f2b17c44ed", () => SelectedActivity);
			MetaPathParameterValues.Add("7c42a570-d16c-4740-85e9-587a7c231a16", () => OpenActivityTypeLookupUserTask.PageParameters);
			MetaPathParameterValues.Add("7222b831-d4eb-4d55-b69b-0bf8578b9e9e", () => OpenActivityTypeLookupUserTask.ProcessKey);
			MetaPathParameterValues.Add("5b90e09c-c471-46d6-9f5d-87cdc7efe4e4", () => OpenActivityTypeLookupUserTask.UserContextKey);
			MetaPathParameterValues.Add("fc012c0e-2e6c-421b-ad7f-440b0f036325", () => OpenActivityTypeLookupUserTask.UseCurrentActivePage);
			MetaPathParameterValues.Add("9cc3e5db-0506-47e6-8b27-efadda2cb88b", () => OpenActivityEditPageUserTask.PageUId);
			MetaPathParameterValues.Add("b79dad0a-6cf5-450f-a4e6-b8917e7e9301", () => OpenActivityEditPageUserTask.PageUrl);
			MetaPathParameterValues.Add("26db47b8-17d4-4ffb-82e9-4453d8f508b2", () => OpenActivityEditPageUserTask.OpenerInstanceId);
			MetaPathParameterValues.Add("c9a42adb-6104-4870-b756-4bf340757950", () => OpenActivityEditPageUserTask.CloseOpenerOnLoad);
			MetaPathParameterValues.Add("a7cfd311-080e-4bea-a766-8e8dcab60aa0", () => OpenActivityEditPageUserTask.PageParameters);
			MetaPathParameterValues.Add("a0be2a70-6167-4750-b6fc-cfd85f6f52f7", () => OpenActivityEditPageUserTask.Width);
			MetaPathParameterValues.Add("824337a6-ab71-4560-9425-1820381aef1c", () => OpenActivityEditPageUserTask.CloseMessage);
			MetaPathParameterValues.Add("0362a1ad-23f4-400f-9c87-58b6ae2cfae0", () => OpenActivityEditPageUserTask.Height);
			MetaPathParameterValues.Add("3bdd4182-000f-4d5c-8cf4-d1234ab6bba7", () => OpenActivityEditPageUserTask.Centered);
			MetaPathParameterValues.Add("3e111e58-83bf-4da4-823f-cb70ffcf49f5", () => OpenActivityEditPageUserTask.UseOpenerRegisterScript);
			MetaPathParameterValues.Add("d1d2784c-8bea-4fd7-a223-bb3659de78c7", () => OpenActivityEditPageUserTask.UseCurrentActivePage);
			MetaPathParameterValues.Add("bb40ba52-ad85-4880-90df-f4882e51e669", () => OpenActivityEditPageUserTask.IgnoreProfile);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "PageInstanceId":
					if (!hasValueToRead) break;
					PageInstanceId = reader.GetValue<System.String>();
				break;
				case "SelectedActivity":
					if (!hasValueToRead) break;
					SelectedActivity = reader.GetValue<System.Boolean>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool BeforeOpenActivityTypeLookupUserTaskScriptTaskExecute(ProcessExecutingContext context) {
			OpenActivityTypeLookupUserTask.ProcessKey = context.Process.InstanceUId;
			string schemaUId = "75b4d39b-55dc-4bd6-8d10-3f49a58d96c7";  
			OpenActivityTypeLookupUserTask.PageParameters = new Dictionary <string, object>();
			var pageParameters = 
			(Dictionary <string, object>) OpenActivityTypeLookupUserTask.PageParameters;
			pageParameters.Add("schemaUId", schemaUId);
			pageParameters.Add("editMode", false);
			Collection<Dictionary<string, object>> filters = new Collection<Dictionary<string, object>>();
			pageParameters.Add("LookupFilters", filters);
			return true;
		}

		public virtual bool BeforeOpenActivityEditPageUserTaskScriptTaskExecute(ProcessExecutingContext context) {
			var activityTypeAndEditPageDictionary = new Dictionary<string,string>() {
				{"fbe0acdc-cfc0-df11-b00f-001d60e938c6", "f2bf397b-8fa3-48ba-b691-57360871967a"},
				{"e1831dec-cfc0-df11-b00f-001d60e938c6", "a2036c88-ca04-4744-967b-5b8a46612d83"},
				{"e2831dec-cfc0-df11-b00f-001d60e938c6", "dcdda065-321b-4560-aacb-05f6cc72cd80"}
			};
			
			var selectedActivitiesTypes = (Dictionary<string, object>)(OpenActivityTypeLookupUserTask.GetSelectedValues(UserConnection));
			var selectedActivityTypeId = string.Empty;
			var activityEditPageId = string.Empty;
			foreach (KeyValuePair<string, object> item in selectedActivitiesTypes) {
				selectedActivityTypeId = item.Key;
			}
			foreach (var item in activityTypeAndEditPageDictionary) {
				if (item.Key == selectedActivityTypeId) {
					activityEditPageId = item.Value;
					break;
				}
			}
			if (String.IsNullOrEmpty(activityEditPageId)) return true;
			
			OpenActivityEditPageUserTask.PageUId = new Guid(activityEditPageId);
			OpenActivityTypeLookupUserTask.ProcessKey = context.Process.InstanceUId;
			
			var activityOpportunityId = Guid.Empty;
			var activityAccountId = Guid.Empty;
			var activityContactId = Guid.Empty;
			var activityDocumentId = Guid.Empty;
			if (ActiveTreeGridCurrentRowId != null) {
				var document = new Terrasoft.Configuration.Document(UserConnection);
				if (document.FetchFromDB(ActiveTreeGridCurrentRowId)) {
					activityDocumentId = ActiveTreeGridCurrentRowId;
					activityOpportunityId = document.GetTypedColumnValue<Guid>("OpportunityId");
					activityAccountId = document.GetTypedColumnValue<Guid>("AccountId");
					activityContactId = document.GetTypedColumnValue<Guid>("ContactId");
				}		
			}
			
			SelectedActivity = true;
			
			var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			var schema = entitySchemaManager.GetInstanceByName("Activity");
			var documentActivityColumnName = schema.Columns.GetByName("Document").Name;
			var opportunityActivityColumnName = schema.Columns.GetByName("Opportunity").Name;
			var accountActivityColumnName = schema.Columns.GetByName("Account").Name;
			var contactActivityColumnName = schema.Columns.GetByName("Contact").Name;
			
			var defValuesId = Guid.NewGuid();
			var defValues = new Dictionary <string, object>();
			if (activityDocumentId != Guid.Empty) {
				defValues.Add(documentActivityColumnName, activityDocumentId.ToString());
			}
			
			if (activityAccountId != Guid.Empty) {
				defValues.Add(accountActivityColumnName, activityAccountId.ToString());
			}
			if (activityContactId != Guid.Empty) {
				defValues.Add(contactActivityColumnName, activityContactId.ToString());
			}
			if (activityOpportunityId != Guid.Empty) {
				defValues.Add(opportunityActivityColumnName, activityOpportunityId.ToString());	
			}
			UserConnection.SessionData[defValuesId.ToString()] = defValues;
			
			var parameters = new Dictionary<string, string>();
			parameters.Add("defValuesId", defValuesId.ToString());
			OpenActivityEditPageUserTask.PageParameters = parameters;
			
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "LookupGridPageClosed":
					if (ActivatedEventElements.Remove("LookupGridPageClosedIntermediateCatchMessageEvent")) {
						context.QueueTasksV2.Enqueue(new ProcessQueueElement("LookupGridPageClosedIntermediateCatchMessageEvent", "LookupGridPageClosedIntermediateCatchMessageEvent"));
					}
					break;
			}
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
			var cloneItem = (CreateActivityProcessCloneForDocument)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

