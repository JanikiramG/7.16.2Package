namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.ML;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: MLEntityPredictionUserTaskSchema

	/// <exclude/>
	public class MLEntityPredictionUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public MLEntityPredictionUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public MLEntityPredictionUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b6060c08-0311-4aed-a7f7-79e1b7b62165");
			RealUId = new Guid("b6060c08-0311-4aed-a7f7-79e1b7b62165");
			Name = "MLEntityPredictionUserTask";
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,142,193,10,194,48,16,68,239,126,197,146,83,133,210,31,168,138,165,168,20,90,144,138,222,67,178,72,33,110,100,179,169,244,239,77,81,11,30,103,152,247,152,189,26,53,131,241,68,104,100,240,84,241,29,182,64,248,130,218,83,16,142,70,60,167,50,62,144,36,83,42,6,228,122,89,43,149,195,245,175,89,151,171,89,248,100,180,195,140,38,89,237,116,8,71,61,167,169,56,161,108,186,246,64,50,200,116,254,141,118,217,223,129,228,88,248,226,59,250,16,55,237,34,86,100,47,122,196,30,67,116,146,117,109,231,45,186,198,230,208,163,241,108,27,155,120,70,137,76,144,254,99,169,222,189,205,3,115,228,0,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateMLModelIdParameter());
			Parameters.Add(CreateRecordIdParameter());
		}

		protected virtual ProcessSchemaParameter CreateMLModelIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("fe517f2c-1cf9-49a3-b354-69e0f2a98cea"),
				Name = "MLModelId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRecordIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e62db413-789d-4bea-83a0-c5ef07ff320f"),
				Name = "RecordId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
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
			Methods.Add(CreateSynchronizeDynamicParametersMethod());
			Methods.Add(CreateGetNotificationDataMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb4b5b06-160b-41df-952a-648e449694e2"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("01907dfc-0f51-43dc-b31a-108f36ce5e9f"),
				Name = "Terrasoft.Configuration.ML",
				Alias = "",
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7a029bc6-69e8-4e62-9a8a-8cda5f902ebe"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ac6e37ff-ea50-4f20-818b-685142ce2ba4"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("b6060c08-0311-4aed-a7f7-79e1b7b62165"),
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("65c1a1ec-b20c-492c-8b39-5cce7560d416"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("b6060c08-0311-4aed-a7f7-79e1b7b62165"),
				ModifiedInSchemaUId = new Guid("b6060c08-0311-4aed-a7f7-79e1b7b62165"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c8834a5e-b879-44ad-b2d3-720bffcf7710"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("b6060c08-0311-4aed-a7f7-79e1b7b62165"),
				ModifiedInSchemaUId = new Guid("b6060c08-0311-4aed-a7f7-79e1b7b62165"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("884193a2-ff30-46bf-9aae-2639b439c6d1"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("b6060c08-0311-4aed-a7f7-79e1b7b62165"),
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3c4ec0ff-b948-422a-9353-f7dea6d9d6c7"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("b6060c08-0311-4aed-a7f7-79e1b7b62165"),
				ModifiedInSchemaUId = new Guid("b6060c08-0311-4aed-a7f7-79e1b7b62165"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("774247e9-c0bf-45e1-b809-bc46e139176c"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("b6060c08-0311-4aed-a7f7-79e1b7b62165"),
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f316b083-caca-4691-933e-88e99f82baad"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("b6060c08-0311-4aed-a7f7-79e1b7b62165"),
				ModifiedInSchemaUId = new Guid("b6060c08-0311-4aed-a7f7-79e1b7b62165"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,115,78,204,75,78,205,113,173,72,77,46,45,201,204,75,215,40,72,44,74,204,77,45,73,45,42,214,180,6,0,4,172,171,3,33,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetExecutionDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("936e89c8-1299-400c-9382-f14e2be20ea1"),
				Name = "GetExecutionData",
				CreatedInSchemaUId = new Guid("b6060c08-0311-4aed-a7f7-79e1b7b62165"),
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f"),
				ResultValueTypeName = "string",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeDynamicParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("66928732-2f85-4852-9e71-5526d573227e"),
				Name = "SynchronizeDynamicParameters",
				CreatedInSchemaUId = new Guid("b6060c08-0311-4aed-a7f7-79e1b7b62165"),
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("51e131ad-e95f-41f6-bb4c-51d2b82e61e7"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("b6060c08-0311-4aed-a7f7-79e1b7b62165"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f9062cd0-b997-4338-a14a-46b3ca26f6a7"),
				Name = "target",
				CreatedInSchemaUId = new Guid("b6060c08-0311-4aed-a7f7-79e1b7b62165"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessUserTaskSchema",
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,11,174,204,75,206,40,202,207,203,172,74,117,169,204,75,204,205,76,14,72,44,74,204,77,45,73,45,42,214,40,45,78,45,114,206,207,203,75,77,46,201,204,207,211,81,40,73,44,74,79,45,209,180,6,0,220,224,0,174,58,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetNotificationDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cc411d83-1568-46a9-bdf6-b783e68818fd"),
				Name = "GetNotificationData",
				CreatedInSchemaUId = new Guid("b6060c08-0311-4aed-a7f7-79e1b7b62165"),
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f"),
				ResultValueTypeName = "ProcessElementNotification",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,79,45,241,203,47,201,76,203,76,78,44,201,204,207,115,73,44,73,212,208,180,6,0,189,127,96,121,34,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MLEntityPredictionUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b6060c08-0311-4aed-a7f7-79e1b7b62165"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new MLEntityPredictionUserTask(userConnection) {
				SchemaUId = new Guid("b6060c08-0311-4aed-a7f7-79e1b7b62165")
			};
		}

		#endregion

	}

	#endregion

	#region Class: MLEntityPredictionUserTask

	[DesignModeProperty(Name = "MLModelId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b6060c0803114aeda7f779e1b7b62165", CaptionResourceItem = "Parameters.MLModelId.Caption", DescriptionResourceItem = "Parameters.MLModelId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RecordId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b6060c0803114aeda7f779e1b7b62165", CaptionResourceItem = "Parameters.RecordId.Caption", DescriptionResourceItem = "Parameters.RecordId.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class MLEntityPredictionUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public MLEntityPredictionUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("b6060c08-0311-4aed-a7f7-79e1b7b62165");
		}

		#endregion

		#region Properties: Public

		public virtual Guid MLModelId {
			get;
			set;
		}

		public virtual Guid RecordId {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			var connectionArg = new ConstructorArgument("userConnection", UserConnection);
			var predictor = ClassFactory.Get<MLEntityPredictor>(connectionArg);
			predictor.PredictEntityValueAndSaveResult(MLModelId, RecordId);
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

		public override ProcessElementNotification GetNotificationData() {
			return base.GetNotificationData();
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("MLModelId")) {
				writer.WriteValue("MLModelId", MLModelId, Guid.Empty);
			}
			if (!HasMapping("RecordId")) {
				writer.WriteValue("RecordId", RecordId, Guid.Empty);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "MLModelId":
					MLModelId = reader.GetGuidValue();
				break;
				case "RecordId":
					RecordId = reader.GetGuidValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

