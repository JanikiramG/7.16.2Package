namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: EditExecutionContextParametersUserTaskSchema

	/// <exclude/>
	public class EditExecutionContextParametersUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public EditExecutionContextParametersUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public EditExecutionContextParametersUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6db39ba8-61ad-43fd-adba-c3797298adc4");
			RealUId = new Guid("6db39ba8-61ad-43fd-adba-c3797298adc4");
			Name = "EditExecutionContextParametersUserTask";
			CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,80,42,74,45,41,45,202,83,40,41,42,77,181,86,2,0,18,18,231,57,15,0,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateDetailNameParameter());
			Parameters.Add(CreateDetailCaptionParameter());
			Parameters.Add(CreateDetailSchemaNameParameter());
			Parameters.Add(CreateAttributeNameParameter());
			Parameters.Add(CreateAttributeValueParameter());
		}

		protected virtual ProcessSchemaParameter CreateDetailNameParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("fc65b005-d844-47ce-a2f7-5534362b961e"),
				Name = "DetailName",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDetailCaptionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("44032666-dfba-4230-bbec-3b14036d8b86"),
				Name = "DetailCaption",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDetailSchemaNameParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("abb24576-c1ab-485c-b5e2-dc0d8c05f176"),
				Name = "DetailSchemaName",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateAttributeNameParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("6c2f3d2d-f073-4bdd-8ec4-8e26eca2f895"),
				Name = "AttributeName",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateAttributeValueParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("fd948a5c-9238-4b0f-b7b5-e94acda75ce0"),
				Name = "AttributeValue",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetResultParameterAllValuesMethod());
			Methods.Add(CreateCompleteExecutingMethod());
			Methods.Add(CreateCancelExecutingMethod());
			Methods.Add(CreateGetExecutionDataMethod());
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e1098909-8480-43fe-96fe-8289841c98f1"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("6db39ba8-61ad-43fd-adba-c3797298adc4"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("55519dc8-7f92-4400-9db6-9186cad95140"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("6db39ba8-61ad-43fd-adba-c3797298adc4"),
				ModifiedInSchemaUId = new Guid("6db39ba8-61ad-43fd-adba-c3797298adc4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9486bf0e-3a2d-47f3-a29e-2f5dd2df478f"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("6db39ba8-61ad-43fd-adba-c3797298adc4"),
				ModifiedInSchemaUId = new Guid("6db39ba8-61ad-43fd-adba-c3797298adc4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0a83dfda-646b-4481-b97f-44871bbaa8b1"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("6db39ba8-61ad-43fd-adba-c3797298adc4"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("73ed964d-7f10-4e0b-998b-e8e0d7cb15fc"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("6db39ba8-61ad-43fd-adba-c3797298adc4"),
				ModifiedInSchemaUId = new Guid("6db39ba8-61ad-43fd-adba-c3797298adc4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("000d3239-9460-493a-81e6-8b73d6501264"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("6db39ba8-61ad-43fd-adba-c3797298adc4"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9fc16329-ebb3-44e6-bf2f-9add3b7a834b"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("6db39ba8-61ad-43fd-adba-c3797298adc4"),
				ModifiedInSchemaUId = new Guid("6db39ba8-61ad-43fd-adba-c3797298adc4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,115,78,204,75,78,205,113,173,72,77,46,45,201,204,75,215,40,72,44,74,204,77,45,73,45,42,214,180,6,0,4,172,171,3,33,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetExecutionDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("45eb4593-f6ce-4488-b2aa-a7bbe3c0bfc2"),
				Name = "GetExecutionData",
				CreatedInSchemaUId = new Guid("6db39ba8-61ad-43fd-adba-c3797298adc4"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "string",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EditExecutionContextParametersUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6db39ba8-61ad-43fd-adba-c3797298adc4"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new EditExecutionContextParametersUserTask(userConnection) {
				SchemaUId = new Guid("6db39ba8-61ad-43fd-adba-c3797298adc4")
			};
		}

		#endregion

	}

	#endregion

	#region Class: EditExecutionContextParametersUserTask

	[DesignModeProperty(Name = "DetailName", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "6db39ba861ad43fdadbac3797298adc4", CaptionResourceItem = "Parameters.DetailName.Caption", DescriptionResourceItem = "Parameters.DetailName.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DetailCaption", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "6db39ba861ad43fdadbac3797298adc4", CaptionResourceItem = "Parameters.DetailCaption.Caption", DescriptionResourceItem = "Parameters.DetailCaption.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DetailSchemaName", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "6db39ba861ad43fdadbac3797298adc4", CaptionResourceItem = "Parameters.DetailSchemaName.Caption", DescriptionResourceItem = "Parameters.DetailSchemaName.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "AttributeName", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "6db39ba861ad43fdadbac3797298adc4", CaptionResourceItem = "Parameters.AttributeName.Caption", DescriptionResourceItem = "Parameters.AttributeName.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "AttributeValue", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "6db39ba861ad43fdadbac3797298adc4", CaptionResourceItem = "Parameters.AttributeValue.Caption", DescriptionResourceItem = "Parameters.AttributeValue.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class EditExecutionContextParametersUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public EditExecutionContextParametersUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("6db39ba8-61ad-43fd-adba-c3797298adc4");
		}

		#endregion

		#region Properties: Public

		public virtual string DetailName {
			get;
			set;
		}

		public virtual string DetailCaption {
			get;
			set;
		}

		public virtual string DetailSchemaName {
			get;
			set;
		}

		public virtual string AttributeName {
			get;
			set;
		}

		public virtual string AttributeValue {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			return true;
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			return base.CompleteExecuting(parameters);
		}

		public override void CancelExecuting(params object[] parameters) {
			base.CancelExecuting(parameters);
		}

		public override string GetExecutionData() {
			return string.Empty;
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("DetailName")) {
				writer.WriteValue("DetailName", DetailName, null);
			}
			if (!HasMapping("DetailCaption")) {
				writer.WriteValue("DetailCaption", DetailCaption, null);
			}
			if (!HasMapping("DetailSchemaName")) {
				writer.WriteValue("DetailSchemaName", DetailSchemaName, null);
			}
			if (!HasMapping("AttributeName")) {
				writer.WriteValue("AttributeName", AttributeName, null);
			}
			if (!HasMapping("AttributeValue")) {
				writer.WriteValue("AttributeValue", AttributeValue, null);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "DetailName":
					DetailName = reader.GetStringValue();
				break;
				case "DetailCaption":
					DetailCaption = reader.GetStringValue();
				break;
				case "DetailSchemaName":
					DetailSchemaName = reader.GetStringValue();
				break;
				case "AttributeName":
					AttributeName = reader.GetStringValue();
				break;
				case "AttributeValue":
					AttributeValue = reader.GetStringValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

