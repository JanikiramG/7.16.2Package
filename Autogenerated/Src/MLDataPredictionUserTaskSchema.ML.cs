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

	#region Class: MLDataPredictionUserTaskSchema

	/// <exclude/>
	public class MLDataPredictionUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public MLDataPredictionUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public MLDataPredictionUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f6925dae-5a55-48b5-af60-bdd77b573b91");
			RealUId = new Guid("f6925dae-5a55-48b5-af60-bdd77b573b91");
			Name = "MLDataPredictionUserTask";
			CreatedInPackageId = new Guid("cad98641-0ee5-4173-9c03-6ef86b0857c5");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = new Guid("a5569491-2b7c-4033-8ed2-e09b6358bf85");
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,143,209,78,195,48,12,69,159,215,175,176,242,148,73,85,127,96,48,177,149,13,21,181,82,53,4,239,89,226,177,74,33,65,142,51,52,33,254,157,102,99,64,213,189,218,215,199,231,222,137,110,7,178,10,75,197,122,223,18,154,78,115,231,221,20,62,179,201,65,17,108,135,243,71,191,133,91,40,173,10,97,173,52,123,58,22,15,200,55,85,83,47,71,193,185,156,206,178,201,24,80,180,228,53,134,208,120,131,86,62,7,164,210,59,135,167,117,14,77,125,154,87,38,135,191,171,117,103,25,233,94,177,234,145,95,128,54,224,69,80,123,23,152,98,114,89,208,107,124,67,199,189,161,195,15,40,199,27,41,68,28,252,19,34,135,161,65,114,78,220,247,243,115,79,215,250,54,245,202,113,199,199,246,18,154,203,43,30,9,245,139,41,126,178,231,195,23,101,35,46,156,121,82,7,220,96,136,150,229,191,226,27,212,158,76,101,82,217,140,144,35,57,232,217,56,19,223,96,139,46,177,175,1,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = true;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateMLModelIdParameter());
			Parameters.Add(CreateIsBatchPredictionParameter());
			Parameters.Add(CreatePredictionFilterDataParameter());
			Parameters.Add(CreateRecordIdParameter());
			Parameters.Add(CreateCFUserFilterDataParameter());
			Parameters.Add(CreateCFItemFilterDataParameter());
			Parameters.Add(CreateCFTopNParameter());
			Parameters.Add(CreateCFFilterAlreadyInteractedItemsParameter());
		}

		protected virtual ProcessSchemaParameter CreateMLModelIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("dbd995b3-643b-40ae-b155-e245ad31a94a"),
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

		protected virtual ProcessSchemaParameter CreateIsBatchPredictionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("66509a65-d453-47c1-917e-2848694d5a18"),
				Name = "IsBatchPrediction",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreatePredictionFilterDataParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("3ff13372-fc47-4340-bc56-2b2e0ed9444b"),
				Name = "PredictionFilterData",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRecordIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("f42dfedb-7bdf-43b3-9790-00e37e865f2e"),
				Name = "RecordId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateCFUserFilterDataParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("a4846855-09ae-4c64-ba7d-9720d172f402"),
				Name = "CFUserFilterData",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateCFItemFilterDataParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("4f555042-aacc-4252-8577-6499b6d9bb93"),
				Name = "CFItemFilterData",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateCFTopNParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("0bf069ee-97aa-4d96-a892-a4e79682481b"),
				Name = "CFTopN",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"3",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("f6925dae-5a55-48b5-af60-bdd77b573b91"),
				},
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateCFFilterAlreadyInteractedItemsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("40adbba6-aca4-4b37-b8d0-8e1d94b39ccc"),
				Name = "CFFilterAlreadyInteractedItems",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"True",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("f6925dae-5a55-48b5-af60-bdd77b573b91"),
				},
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
			Methods.Add(CreateSynchronizeDynamicParametersMethod());
			Methods.Add(CreateGetNotificationDataMethod());
			Methods.Add(CreateSynchronizeParametersMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6e20c611-5bc7-41de-82c3-89bab9ddb80c"),
				Name = "Terrasoft.Configuration.ML",
				Alias = "",
				CreatedInPackageId = new Guid("cad98641-0ee5-4173-9c03-6ef86b0857c5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ea7e1dd5-64cb-44c2-a8ef-b13baf66c3c0"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("cad98641-0ee5-4173-9c03-6ef86b0857c5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("034367bd-15f0-4708-af04-34585e74e1b2"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("cad98641-0ee5-4173-9c03-6ef86b0857c5")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a2527cf4-43b8-4505-aaad-68344b9dd9c6"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("f6925dae-5a55-48b5-af60-bdd77b573b91"),
				CreatedInPackageId = new Guid("cad98641-0ee5-4173-9c03-6ef86b0857c5"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a78954b8-986c-409c-9a83-87582b2dd49c"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("f6925dae-5a55-48b5-af60-bdd77b573b91"),
				ModifiedInSchemaUId = new Guid("f6925dae-5a55-48b5-af60-bdd77b573b91"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("cad98641-0ee5-4173-9c03-6ef86b0857c5")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("08a49259-1ba1-4826-baf3-642fd7c3b65e"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("f6925dae-5a55-48b5-af60-bdd77b573b91"),
				ModifiedInSchemaUId = new Guid("f6925dae-5a55-48b5-af60-bdd77b573b91"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("cad98641-0ee5-4173-9c03-6ef86b0857c5")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3ea02369-22b2-44b1-9e7f-38765cb1e3a6"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("f6925dae-5a55-48b5-af60-bdd77b573b91"),
				CreatedInPackageId = new Guid("cad98641-0ee5-4173-9c03-6ef86b0857c5"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7b7808f0-495a-493b-a02c-26b420ace361"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("f6925dae-5a55-48b5-af60-bdd77b573b91"),
				ModifiedInSchemaUId = new Guid("f6925dae-5a55-48b5-af60-bdd77b573b91"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("cad98641-0ee5-4173-9c03-6ef86b0857c5"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("876c64e8-d747-415f-80fe-049d863da1c9"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("f6925dae-5a55-48b5-af60-bdd77b573b91"),
				CreatedInPackageId = new Guid("cad98641-0ee5-4173-9c03-6ef86b0857c5"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e0ffd3a6-1b85-43d7-a556-76fe47a1b9db"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("f6925dae-5a55-48b5-af60-bdd77b573b91"),
				ModifiedInSchemaUId = new Guid("f6925dae-5a55-48b5-af60-bdd77b573b91"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("cad98641-0ee5-4173-9c03-6ef86b0857c5"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,115,78,204,75,78,205,113,173,72,77,46,45,201,204,75,215,40,72,44,74,204,77,45,73,45,42,214,180,6,0,4,172,171,3,33,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetExecutionDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9b437a9c-0f64-445d-b7b3-0f10390be6a9"),
				Name = "GetExecutionData",
				CreatedInSchemaUId = new Guid("f6925dae-5a55-48b5-af60-bdd77b573b91"),
				CreatedInPackageId = new Guid("cad98641-0ee5-4173-9c03-6ef86b0857c5"),
				ResultValueTypeName = "string",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeDynamicParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("456d9e6f-8555-4382-a0c4-4b79c595ec92"),
				Name = "SynchronizeDynamicParameters",
				CreatedInSchemaUId = new Guid("f6925dae-5a55-48b5-af60-bdd77b573b91"),
				CreatedInPackageId = new Guid("cad98641-0ee5-4173-9c03-6ef86b0857c5"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("52317d2e-e9b8-4641-8c72-5e95bbb6e102"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("f6925dae-5a55-48b5-af60-bdd77b573b91"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("cad98641-0ee5-4173-9c03-6ef86b0857c5")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2ad26202-e112-4cb6-b0ba-499e32ad79e2"),
				Name = "target",
				CreatedInSchemaUId = new Guid("f6925dae-5a55-48b5-af60-bdd77b573b91"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessUserTaskSchema",
				CreatedInPackageId = new Guid("cad98641-0ee5-4173-9c03-6ef86b0857c5")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,11,174,204,75,206,40,202,207,203,172,74,117,169,204,75,204,205,76,14,72,44,74,204,77,45,73,45,42,214,40,45,78,45,114,206,207,203,75,77,46,201,204,207,211,81,40,73,44,74,79,45,209,180,6,0,220,224,0,174,58,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetNotificationDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4a9a53c5-a630-4058-ba91-cb1524063726"),
				Name = "GetNotificationData",
				CreatedInSchemaUId = new Guid("f6925dae-5a55-48b5-af60-bdd77b573b91"),
				CreatedInPackageId = new Guid("cad98641-0ee5-4173-9c03-6ef86b0857c5"),
				ResultValueTypeName = "ProcessElementNotification",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,79,45,241,203,47,201,76,203,76,78,44,201,204,207,115,73,44,73,212,208,180,6,0,189,127,96,121,34,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5fc3f594-7f99-46a5-a5ad-c54c6c7efa3e"),
				Name = "SynchronizeParameters",
				CreatedInSchemaUId = new Guid("f6925dae-5a55-48b5-af60-bdd77b573b91"),
				CreatedInPackageId = new Guid("cad98641-0ee5-4173-9c03-6ef86b0857c5"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6343fd1c-3e4e-4c8e-b387-36267118be8b"),
				Name = "schemaElement",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("cad98641-0ee5-4173-9c03-6ef86b0857c5")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,11,174,204,75,206,40,202,207,203,172,74,13,72,44,74,204,77,45,73,45,42,214,40,78,206,72,205,77,116,205,73,205,77,205,43,209,180,6,0,231,209,250,48,42,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MLDataPredictionUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f6925dae-5a55-48b5-af60-bdd77b573b91"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new MLDataPredictionUserTask(userConnection) {
				SchemaUId = new Guid("f6925dae-5a55-48b5-af60-bdd77b573b91")
			};
		}

		#endregion

	}

	#endregion

	#region Class: MLDataPredictionUserTask

	[DesignModeProperty(Name = "MLModelId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f6925dae5a5548b5af60bdd77b573b91", CaptionResourceItem = "Parameters.MLModelId.Caption", DescriptionResourceItem = "Parameters.MLModelId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsBatchPrediction", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f6925dae5a5548b5af60bdd77b573b91", CaptionResourceItem = "Parameters.IsBatchPrediction.Caption", DescriptionResourceItem = "Parameters.IsBatchPrediction.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "PredictionFilterData", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f6925dae5a5548b5af60bdd77b573b91", CaptionResourceItem = "Parameters.PredictionFilterData.Caption", DescriptionResourceItem = "Parameters.PredictionFilterData.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RecordId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f6925dae5a5548b5af60bdd77b573b91", CaptionResourceItem = "Parameters.RecordId.Caption", DescriptionResourceItem = "Parameters.RecordId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "CFUserFilterData", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f6925dae5a5548b5af60bdd77b573b91", CaptionResourceItem = "Parameters.CFUserFilterData.Caption", DescriptionResourceItem = "Parameters.CFUserFilterData.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "CFItemFilterData", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f6925dae5a5548b5af60bdd77b573b91", CaptionResourceItem = "Parameters.CFItemFilterData.Caption", DescriptionResourceItem = "Parameters.CFItemFilterData.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "CFTopN", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f6925dae5a5548b5af60bdd77b573b91", CaptionResourceItem = "Parameters.CFTopN.Caption", DescriptionResourceItem = "Parameters.CFTopN.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "CFFilterAlreadyInteractedItems", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f6925dae5a5548b5af60bdd77b573b91", CaptionResourceItem = "Parameters.CFFilterAlreadyInteractedItems.Caption", DescriptionResourceItem = "Parameters.CFFilterAlreadyInteractedItems.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public partial class MLDataPredictionUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public MLDataPredictionUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("f6925dae-5a55-48b5-af60-bdd77b573b91");
			_cFTopN = () => { return 3; };
		}

		#endregion

		#region Properties: Public

		public virtual Guid MLModelId {
			get;
			set;
		}

		public virtual bool IsBatchPrediction {
			get;
			set;
		}

		public virtual string PredictionFilterData {
			get;
			set;
		}

		public virtual Guid RecordId {
			get;
			set;
		}

		public virtual string CFUserFilterData {
			get;
			set;
		}

		public virtual string CFItemFilterData {
			get;
			set;
		}

		private Func<int> _cFTopN;
		public virtual int CFTopN {
			get {
				return (_cFTopN ?? (_cFTopN = () => 0)).Invoke();
			}
			set {
				_cFTopN = () => { return value; };
			}
		}

		private bool _cFFilterAlreadyInteractedItems = true;
		public virtual bool CFFilterAlreadyInteractedItems {
			get {
				return _cFFilterAlreadyInteractedItems;
			}
			set {
				_cFFilterAlreadyInteractedItems = value;
			}
		}

		#endregion

		#region Methods: Public

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
			if (!HasMapping("IsBatchPrediction")) {
				writer.WriteValue("IsBatchPrediction", IsBatchPrediction, false);
			}
			if (!HasMapping("PredictionFilterData")) {
				writer.WriteValue("PredictionFilterData", PredictionFilterData, null);
			}
			if (!HasMapping("RecordId")) {
				writer.WriteValue("RecordId", RecordId, Guid.Empty);
			}
			if (!HasMapping("CFUserFilterData")) {
				writer.WriteValue("CFUserFilterData", CFUserFilterData, null);
			}
			if (!HasMapping("CFItemFilterData")) {
				writer.WriteValue("CFItemFilterData", CFItemFilterData, null);
			}
			if (!HasMapping("CFTopN")) {
				writer.WriteValue("CFTopN", CFTopN, 0);
			}
			if (!HasMapping("CFFilterAlreadyInteractedItems")) {
				writer.WriteValue("CFFilterAlreadyInteractedItems", CFFilterAlreadyInteractedItems, false);
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
				case "IsBatchPrediction":
					IsBatchPrediction = reader.GetBoolValue();
				break;
				case "PredictionFilterData":
					PredictionFilterData = reader.GetStringValue();
				break;
				case "RecordId":
					RecordId = reader.GetGuidValue();
				break;
				case "CFUserFilterData":
					CFUserFilterData = reader.GetStringValue();
				break;
				case "CFItemFilterData":
					CFItemFilterData = reader.GetStringValue();
				break;
				case "CFTopN":
					CFTopN = reader.GetIntValue();
				break;
				case "CFFilterAlreadyInteractedItems":
					CFFilterAlreadyInteractedItems = reader.GetBoolValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

