namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: ReadDataUserTaskSchema

	/// <exclude/>
	public class ReadDataUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public ReadDataUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public ReadDataUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f");
			RealUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f");
			Name = "ReadDataUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			ParametersEditPageSchemaV2UId = new Guid("5e64f089-f6db-4cfe-92dd-33246ca806e5");
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,84,77,111,219,48,12,61,207,191,66,243,161,176,129,192,232,101,39,47,195,90,183,41,2,108,253,136,219,221,85,135,113,180,202,82,38,201,27,188,161,255,125,148,100,39,118,156,20,40,86,236,102,83,228,227,227,227,3,63,135,151,194,48,211,228,197,26,42,74,160,255,51,37,11,208,53,55,62,35,241,209,52,96,43,18,13,243,166,68,212,156,199,228,79,240,78,129,169,149,32,70,213,144,6,207,193,79,170,8,232,31,8,149,41,160,6,250,205,238,106,80,205,0,41,185,166,21,196,105,128,21,201,131,134,179,101,197,196,130,149,107,163,17,96,69,185,70,76,109,20,19,37,161,101,169,160,164,134,73,145,73,94,87,194,150,98,86,24,206,106,81,216,112,24,166,193,173,146,5,104,189,0,186,188,160,134,250,113,238,155,13,16,181,251,156,146,232,104,94,188,251,76,131,124,3,5,91,53,151,249,157,111,169,35,36,58,233,65,217,239,213,97,106,241,150,12,14,166,238,169,126,122,48,140,51,195,64,39,59,220,25,227,6,148,142,108,78,38,133,0,55,201,132,152,53,211,147,193,114,38,196,245,182,108,115,89,171,2,218,210,184,79,243,70,45,65,157,55,185,65,229,43,172,30,17,110,181,206,168,176,163,63,136,66,86,21,51,224,68,176,59,59,20,247,37,243,82,72,5,23,76,111,56,109,190,81,94,131,221,209,129,168,247,203,21,151,143,148,159,109,54,57,24,131,251,211,201,12,237,80,43,232,36,223,170,162,33,91,215,226,73,147,147,147,193,146,166,228,232,146,18,239,42,20,155,123,193,156,19,221,96,22,42,103,191,237,146,51,100,150,160,168,43,86,214,202,109,39,201,27,189,229,115,5,198,17,30,105,31,134,93,199,45,90,24,78,200,135,211,216,26,124,191,117,187,164,94,96,106,55,101,225,247,83,247,58,33,156,31,105,33,127,233,76,214,194,216,210,189,154,196,61,120,77,255,73,29,180,11,247,57,153,172,54,82,227,118,111,30,191,99,194,23,166,77,20,205,91,184,91,170,208,188,214,88,95,193,208,185,88,201,24,39,241,22,188,228,206,84,81,60,25,209,116,210,88,142,163,137,166,228,212,245,239,95,150,161,88,123,161,116,116,83,124,81,107,142,246,231,128,82,51,166,180,73,220,78,71,122,189,127,73,175,238,128,140,120,98,151,126,211,244,13,166,240,74,250,51,49,62,28,123,13,219,11,156,180,215,199,122,234,188,177,199,37,58,118,114,236,216,221,56,157,81,34,38,76,124,182,43,176,241,28,143,106,97,188,185,122,99,119,46,28,144,192,174,182,100,233,27,57,125,63,34,228,167,163,36,158,9,224,229,38,150,203,40,37,177,218,59,12,71,143,105,50,23,6,74,80,131,120,143,82,251,220,13,245,159,201,93,215,21,160,82,199,200,205,184,164,230,53,212,150,120,169,43,202,223,138,30,6,224,158,85,112,140,95,247,254,26,138,93,205,11,28,131,190,181,195,191,205,222,192,189,82,8,0,0 };
			SerializeToDB = true;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateDataSourceFiltersParameter());
			Parameters.Add(CreateResultTypeParameter());
			Parameters.Add(CreateReadSomeTopRecordsParameter());
			Parameters.Add(CreateNumberOfRecordsParameter());
			Parameters.Add(CreateFunctionTypeParameter());
			Parameters.Add(CreateAggregationColumnNameParameter());
			Parameters.Add(CreateOrderInfoParameter());
			Parameters.Add(CreateResultEntityParameter());
			Parameters.Add(CreateResultCountParameter());
			Parameters.Add(CreateResultIntegerFunctionParameter());
			Parameters.Add(CreateResultFloatFunctionParameter());
			Parameters.Add(CreateResultDateTimeFunctionParameter());
			Parameters.Add(CreateResultRowsCountParameter());
			Parameters.Add(CreateCanReadUncommitedDataParameter());
			Parameters.Add(CreateResultEntityCollectionParameter());
			Parameters.Add(CreateEntityColumnMetaPathesParameter());
			Parameters.Add(CreateIgnoreDisplayValuesParameter());
			Parameters.Add(CreateResultCompositeObjectListParameter());
			Parameters.Add(CreateConsiderTimeInFilterParameter());
		}

		protected virtual ProcessSchemaParameter CreateDataSourceFiltersParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("5d9ac9a7-7782-49ce-8990-dcb1c73832b0"),
				Name = "DataSourceFilters",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateResultTypeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("643e4d6d-7ec8-49f0-842a-066a996fbe8b"),
				Name = "ResultType",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"0",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				},
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateReadSomeTopRecordsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("29115add-7520-4ad4-8371-d91f537ac913"),
				Name = "ReadSomeTopRecords",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateNumberOfRecordsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("f29e5660-c5ef-4d84-8331-9046c3093519"),
				Name = "NumberOfRecords",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateFunctionTypeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("94ba9876-18c1-4a68-bcef-08f7e7f0e25c"),
				Name = "FunctionType",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateAggregationColumnNameParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("cb5d6d26-7e81-4cbe-8730-8b7169000d14"),
				Name = "AggregationColumnName",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateOrderInfoParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("473e79e2-727e-40a7-8829-7eefc576b403"),
				Name = "OrderInfo",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateResultEntityParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e2fced10-4842-423e-ada0-523bf7ea8ad3"),
				Name = "ResultEntity",
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateResultCountParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("2e63ea99-8125-4254-88bd-20d3610bd471"),
				Name = "ResultCount",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateResultIntegerFunctionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("a3660fce-a8f9-4a68-a3c1-b4f2f7983635"),
				Name = "ResultIntegerFunction",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateResultFloatFunctionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("9a594933-75da-4304-b6a3-5945dba159e3"),
				Name = "ResultFloatFunction",
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateResultDateTimeFunctionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("11fb235f-c06a-4111-84cd-a5dbf9a440d5"),
				Name = "ResultDateTimeFunction",
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateResultRowsCountParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("78252e95-b759-416a-9c48-c128fbdf59ef"),
				Name = "ResultRowsCount",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateCanReadUncommitedDataParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("2f797429-6f43-4594-96bb-62fbc7b7deec"),
				Name = "CanReadUncommitedData",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"true",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				},
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateResultEntityCollectionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("be4a0d16-6a15-41cf-ac44-a8b757565428"),
				Name = "ResultEntityCollection",
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityColumnMetaPathesParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("cc12005f-f434-4a40-b9d0-dc8f81755545"),
				Name = "EntityColumnMetaPathes",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIgnoreDisplayValuesParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("6dada847-859b-4e0a-9297-b3c9572530b6"),
				Name = "IgnoreDisplayValues",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateResultCompositeObjectListParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("555901ef-f707-4803-a887-1bc07e882096"),
				Name = "ResultCompositeObjectList",
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateConsiderTimeInFilterParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("978b550e-1b81-448a-8700-9c9190c3a2a4"),
				Name = "ConsiderTimeInFilter",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"false",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
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
			Methods.Add(CreateSpecifyESQColumnsMethod());
			Methods.Add(CreateSpecifyESQOrderByStatementsMethod());
			Methods.Add(CreateSynchronizeParametersMethod());
			Methods.Add(CreateFillResultCompositeObjectListMethod());
			Methods.Add(CreateCreateEntitySchemaQueryMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("26cec65d-e5f2-475f-bc25-76ca2bc95917"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0e213f9c-df09-46f1-bb20-55d1bd77c84e"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d9e0d720-a8aa-43a3-b6cc-457587ca313d"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c860da3f-842b-47e2-a00a-90ae025bbe01"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e1176396-6812-4fa9-a6a8-c8873eadaea4"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("57743241-e356-4bb6-afcd-8f42a5ba5cd2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e39d7434-bac2-4561-ad4d-191745e5c7a5"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("57743241-e356-4bb6-afcd-8f42a5ba5cd2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a0c207f6-a226-46d3-9d42-4778d2b9cd70"),
				Name = "Terrasoft.Core.Process",
				Alias = "",
				CreatedInPackageId = new Guid("57743241-e356-4bb6-afcd-8f42a5ba5cd2")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("40149ba8-dd4a-4520-882d-b981eb8bc4b4"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f6c9c101-54e7-4923-bb9e-8481198f10aa"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fbd61b83-3d99-4a22-a234-da34cda1c7b7"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("65b6aeeb-0964-41c8-87d9-aeea6af9b165"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("49efaffe-6845-48b4-b868-94a3b1354232"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSpecifyESQColumnsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("65c0b1fa-aab5-40e1-a6f6-531e9ed8e90d"),
				Name = "SpecifyESQColumns",
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("41ab6592-dc54-422d-b1e4-e9a77031885f"),
				Name = "esq",
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchemaQuery",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d9a3974b-49d0-4c76-97df-ce41a337f73f"),
				Name = "resultType",
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessReadDataResultType",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d215173f-a3d4-448b-8e61-c45fbd0eb5ec"),
				Name = "aggregationColumnName",
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ref string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,59,79,195,48,16,158,147,95,225,169,36,18,138,196,92,117,40,229,161,14,148,146,176,33,6,227,94,91,75,142,93,236,51,40,66,253,239,248,145,132,20,210,129,49,151,239,113,247,221,153,111,73,166,193,88,129,207,205,1,200,108,70,214,90,49,48,166,4,186,185,161,72,203,254,103,113,103,37,67,174,100,78,190,210,228,131,106,66,119,59,13,59,234,107,145,77,178,249,105,169,66,205,25,230,29,211,151,166,105,194,157,169,113,127,228,174,88,154,149,21,226,81,223,214,7,108,134,236,133,18,182,150,43,90,67,78,38,147,191,86,51,50,106,85,44,148,149,24,58,76,110,37,114,108,42,182,135,154,18,24,126,204,8,152,247,162,84,10,99,193,245,148,208,49,111,143,28,16,139,181,230,53,213,77,4,20,30,225,168,71,2,194,64,176,60,39,50,58,152,167,166,231,125,93,135,243,205,38,214,50,167,237,11,11,13,20,97,160,214,37,155,253,10,232,146,140,234,230,121,215,180,6,180,90,78,211,99,122,118,27,49,191,72,126,0,164,107,138,123,48,121,8,183,237,110,46,68,76,38,162,76,150,59,197,62,142,127,45,32,182,240,242,74,234,222,202,193,198,123,40,170,131,224,152,93,76,47,156,95,178,85,46,21,182,111,135,232,249,132,203,129,86,60,137,22,194,130,94,0,253,90,240,61,224,112,32,15,185,110,58,227,172,147,243,174,225,138,135,66,113,166,246,66,158,44,244,103,18,24,193,62,97,202,153,73,235,23,224,119,159,156,46,249,71,45,15,183,113,76,207,40,46,205,92,124,210,198,84,32,128,161,155,1,181,215,228,255,120,204,49,216,126,151,165,250,12,47,199,105,93,117,71,225,89,149,170,225,89,29,74,96,74,111,204,24,124,101,235,55,208,143,219,22,226,200,223,39,68,149,79,84,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSpecifyESQOrderByStatementsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a3d1ca2d-5bac-44f0-b328-16a5990a6e21"),
				Name = "SpecifyESQOrderByStatements",
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("05b4be6c-09dd-41fa-98c7-6a698a7d10de"),
				Name = "esq",
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchemaQuery",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("14362360-a2de-44f6-b178-bf6b9701a279"),
				Name = "resultType",
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessReadDataResultType",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,145,63,79,195,48,16,197,231,230,83,152,169,169,90,69,5,54,66,6,160,173,132,132,32,20,182,42,131,149,92,90,75,201,185,248,207,16,209,126,119,206,177,67,105,37,22,91,186,123,247,243,189,103,81,179,88,129,182,141,249,236,246,192,178,140,229,74,150,160,245,26,120,181,224,134,175,127,155,201,202,98,105,132,68,118,56,176,55,85,129,122,198,90,186,17,180,77,115,86,76,94,0,183,102,231,122,243,9,251,142,70,10,140,85,152,70,199,104,137,70,152,238,163,220,65,203,223,45,168,238,73,54,182,69,58,27,240,244,178,47,104,150,49,208,95,137,111,235,52,210,70,9,220,110,10,38,221,43,174,125,122,238,99,223,8,19,143,103,227,73,26,213,82,177,88,160,97,130,36,243,148,174,251,48,18,182,162,210,116,218,111,117,142,36,185,215,109,68,49,16,239,28,113,36,40,164,190,53,248,186,202,216,109,79,24,149,146,252,160,5,82,29,7,96,112,144,115,151,128,103,110,230,5,41,254,241,30,244,164,13,214,147,149,192,234,177,123,229,45,196,39,214,176,201,160,246,185,15,107,4,130,139,236,161,170,60,248,98,152,22,244,133,164,79,110,33,84,72,60,99,241,121,101,178,68,219,38,57,87,26,98,67,95,47,235,75,193,44,248,186,46,28,249,47,54,151,90,4,42,253,66,128,120,241,141,19,31,127,0,68,231,144,47,115,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("20f92709-bfd0-4298-9f41-02e72b9ea010"),
				Name = "SynchronizeParameters",
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				CreatedInPackageId = new Guid("57743241-e356-4bb6-afcd-8f42a5ba5cd2"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c9ea4ab7-1dab-48f3-8573-3d47291491b2"),
				Name = "schemaElement",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("57743241-e356-4bb6-afcd-8f42a5ba5cd2")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,87,95,111,219,54,16,127,150,62,5,235,151,74,128,193,47,224,122,64,226,185,133,135,54,9,236,100,123,24,246,192,72,151,152,157,68,25,36,229,198,43,242,221,119,36,101,137,212,31,47,235,75,129,32,182,79,119,191,187,251,221,145,119,58,86,60,39,91,40,171,35,172,133,230,250,180,170,138,186,20,119,76,178,18,52,72,149,108,214,162,46,65,178,199,2,62,56,149,93,182,135,146,57,197,95,8,120,102,106,78,36,60,145,59,89,101,160,148,211,107,161,80,165,128,76,243,74,144,67,11,159,198,223,227,232,200,36,41,185,82,144,119,126,201,210,211,162,127,236,65,66,210,10,200,178,231,151,94,21,69,146,217,239,230,153,251,70,31,54,57,121,183,36,159,106,158,83,68,86,30,2,189,103,207,105,154,46,226,200,243,226,120,216,50,241,12,73,63,30,122,95,125,230,74,39,198,230,53,142,143,134,183,171,60,255,41,164,205,227,40,186,102,10,2,19,114,240,127,205,109,214,72,132,208,140,11,144,72,133,165,250,169,146,192,178,61,73,12,231,13,97,92,132,241,164,113,132,154,17,127,34,137,71,142,97,56,40,192,36,173,134,243,174,2,41,194,89,60,159,105,100,46,89,97,36,26,218,76,155,242,205,251,121,4,41,152,130,69,175,49,254,157,107,240,112,200,17,229,231,245,110,64,104,199,15,15,21,45,1,70,67,85,181,204,96,213,116,106,175,137,63,114,137,29,54,218,198,203,75,109,108,72,233,68,55,248,137,208,190,39,43,11,181,86,236,96,211,233,41,54,98,236,246,157,150,92,60,39,61,240,95,153,102,191,179,162,134,251,211,97,224,37,120,184,104,170,52,78,40,233,87,127,88,30,114,110,136,31,108,117,9,186,150,130,8,248,54,81,84,87,21,203,174,35,247,6,190,153,207,36,53,7,108,229,225,145,101,0,111,30,35,241,196,111,115,143,49,107,221,210,155,77,17,107,212,250,116,102,35,68,26,189,166,166,89,87,77,35,197,76,176,129,190,128,102,13,47,203,30,51,198,3,151,77,227,46,39,104,104,53,232,109,173,177,104,238,126,243,187,89,109,241,96,96,173,173,221,186,128,18,189,210,238,152,45,172,246,227,160,74,35,22,97,184,76,13,107,235,192,192,153,56,234,67,20,148,45,226,56,188,156,48,62,186,126,193,235,89,93,159,12,57,201,108,11,170,46,180,161,111,150,182,51,70,182,194,174,15,151,97,154,244,19,232,49,140,69,31,193,150,7,173,71,48,233,206,30,10,171,65,237,127,180,230,24,250,189,60,185,243,219,131,153,147,170,214,120,101,104,15,205,120,52,73,118,18,115,7,36,168,148,54,124,109,129,229,166,81,186,48,105,123,13,54,151,149,119,241,128,119,190,190,48,193,158,109,238,193,177,107,196,233,160,146,52,120,142,143,142,60,199,52,145,170,70,148,204,70,112,44,105,145,61,155,190,115,87,211,255,32,221,193,205,82,28,201,79,56,249,69,6,173,177,1,245,189,5,224,100,105,6,205,72,174,120,183,138,124,35,148,102,136,245,81,86,165,105,67,195,222,53,150,36,251,27,85,16,58,233,197,105,206,79,20,13,233,232,44,166,52,118,39,165,161,124,80,102,114,8,209,20,195,68,62,113,27,186,42,175,170,242,80,41,174,225,246,241,43,218,152,125,227,127,52,234,136,245,236,130,207,209,145,214,54,244,165,80,232,6,115,67,208,3,72,205,65,45,154,93,33,168,3,174,0,162,46,138,118,246,119,45,216,12,187,118,248,53,140,181,139,156,234,102,182,27,62,83,156,249,112,166,154,119,76,239,65,189,137,176,245,168,169,99,43,82,246,126,158,128,239,205,236,17,191,163,167,223,103,168,111,73,55,234,166,210,55,200,214,173,92,151,7,125,74,236,202,228,120,27,18,135,93,55,29,5,221,29,10,174,147,247,139,247,46,151,104,156,243,51,217,191,85,92,36,3,244,57,25,91,65,206,82,123,126,131,237,175,149,167,238,56,68,237,42,215,61,233,176,92,96,175,231,166,56,158,199,156,33,1,135,227,73,100,123,89,9,254,143,185,92,113,118,255,249,23,249,78,130,121,72,175,185,96,242,20,200,76,80,175,139,176,209,252,93,98,152,186,123,163,120,49,113,189,155,142,129,54,91,128,74,94,104,223,97,154,226,48,191,146,146,157,154,62,189,248,26,53,18,147,91,56,189,53,209,162,92,92,104,223,140,50,253,106,242,6,136,249,112,152,207,189,145,124,94,194,35,40,20,140,44,247,171,2,152,76,188,85,253,95,110,153,203,119,101,14,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFillResultCompositeObjectListMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c8071b92-196b-4b18-bbaa-8460e85f1710"),
				Name = "FillResultCompositeObjectList",
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				CreatedInPackageId = new Guid("6b752d82-945c-4729-b067-d3f384b1bc2d"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("62366483-8bd5-46f0-816c-cdc9da375e3c"),
				Name = "schemaElement",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "IProcessParametersMetaInfo",
				CreatedInPackageId = new Guid("6b752d82-945c-4729-b067-d3f384b1bc2d")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1e269436-4f6f-4471-81f2-cc652a0437b7"),
				Name = "entityCollection",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntityCollection",
				CreatedInPackageId = new Guid("6b752d82-945c-4729-b067-d3f384b1bc2d")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,221,78,195,48,12,133,175,219,167,136,118,149,74,40,47,48,64,98,5,166,73,252,76,48,174,16,23,161,245,182,64,147,84,177,11,170,208,222,29,183,145,90,166,177,93,85,142,143,125,142,63,213,172,133,4,71,134,218,220,87,21,20,100,188,83,87,174,149,89,38,126,210,228,75,7,17,219,226,66,28,232,110,77,64,146,217,52,77,150,193,23,128,248,92,108,193,234,165,14,218,2,65,24,165,2,247,59,200,235,226,211,77,5,150,23,171,177,53,141,182,92,232,82,211,56,51,140,140,82,53,7,154,181,15,92,201,201,19,96,83,81,238,109,237,209,16,60,190,127,176,245,157,65,154,116,1,175,77,159,67,135,246,28,41,24,183,57,19,241,123,41,62,161,189,215,53,111,119,240,45,142,235,250,59,215,62,128,46,182,66,118,9,29,32,65,57,164,89,16,88,230,80,67,96,90,198,29,30,160,254,40,12,160,232,9,247,183,22,190,106,172,27,16,171,200,81,229,253,51,50,103,87,206,218,151,69,41,231,141,41,59,84,8,242,132,187,90,233,77,214,197,77,226,109,175,167,180,29,189,55,182,142,25,250,146,39,119,105,114,20,232,127,191,194,42,104,135,76,199,202,104,201,238,187,244,23,69,121,190,13,93,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateEntitySchemaQueryMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4d0fd537-aa52-4609-aa33-015bd49d25db"),
				Name = "CreateEntitySchemaQuery",
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90"),
				ResultValueTypeName = "EntitySchemaQuery"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6df1d452-b46a-4b69-a43f-c23a8e02ddef"),
				Name = "entitySchemaName",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,205,43,201,44,169,12,78,206,72,205,77,12,44,77,45,170,212,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,67,86,224,155,152,151,152,158,90,164,163,144,138,36,232,151,152,155,170,105,13,0,163,135,61,97,83,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ReadDataUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new ReadDataUserTask(userConnection) {
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
		}

		#endregion

	}

	#endregion

	#region Class: ReadDataUserTaskSchemaExtension

	/// <exclude/>
	public class ReadDataUserTaskSchemaExtension : ProcessUserTaskSchemaExtension
	{

		#region Methods: Public

		public override void SynchronizeParameters(ProcessSchemaUserTask schemaElement) {
			void RemoveEntityColumnParameters(IEnumerable<EntitySchemaColumn> entityColumns, ref ProcessSchemaParameterCollection parameters)
			{
				var missedParameters = parameters.Where(parameter => entityColumns.All(column => column.UId != Guid.Parse(parameter.Tag)));
				parameters.RemoveRange(missedParameters.ToList());
			}
			
			void AddEntityColumnParameters(IEnumerable<EntitySchemaColumn> entityColumns, ref ProcessSchemaParameterCollection parameters,
					BaseProcessSchema processSchema, Guid containerUId)
			{
				foreach (var column in entityColumns)
				{
					if (parameters.All(parameter => Guid.Parse(parameter.Tag) != column.UId))
					{
						parameters.Add(CreateParameter(column, processSchema, containerUId));
					}
				}
			}
			
			void UpdateEntityColumnParameters(IEnumerable<EntitySchemaColumn> entityColumns, ref ProcessSchemaParameterCollection parameters)
			{
				foreach (var parameter in parameters)
				{
					var sourceColumn = entityColumns.First(column => column.UId == Guid.Parse(parameter.Tag));
					parameter.Name = sourceColumn.Name;
					parameter.Caption = sourceColumn.Caption.ToString();
					parameter.DataValueType = sourceColumn.DataValueType;
				}
			}
			
			ProcessSchemaParameter CreateParameter(EntitySchemaColumn column, BaseProcessSchema processSchema, Guid containerUId)
			{
				return new ProcessSchemaParameter
				{
					UId = Guid.NewGuid(),
					ContainerUId = containerUId,
					Tag = column.UId.ToString(),
					Caption = column.Caption.ToString(),
					DataValueType = column.DataValueType,
					Name = column.Name,
					ParentMetaSchema = processSchema,
					Direction = ProcessSchemaParameterDirection.Out
				};
			}
			
			var parametersRef = schemaElement.Parameters;
			var baseProcessSchema = schemaElement.ParentMetaSchema as BaseProcessSchema;
			var elementUId = schemaElement.UId;
			
			if (parametersRef.ExistsByName("ResultType"))
			{
				var resultTypeParameter = parametersRef.GetByName("ResultType");
				var resultTypeValue = resultTypeParameter.SourceValue.Value;
				int.TryParse(resultTypeValue, out int resultType);
				if (resultType == (int)ProcessReadDataResultType.EntityCollection)
				{
					var entitySchemaManager = (EntitySchemaManager)baseProcessSchema.SchemaManagerProvider.GetManager("EntitySchemaManager");
					Guid entitySchemaUId = parametersRef.GetByName("ResultEntity").ReferenceSchemaUId;
					EntitySchema entitySchema =
						entitySchemaManager.FindInstanceFromMetaDataByPackageUId(entitySchemaUId,
							baseProcessSchema.PackageUId,
							baseProcessSchema.SystemUserConnection);
					ProcessSchemaParameter resultCompositeObjectListParameter = parametersRef.GetByName("ResultCompositeObjectList");
					ProcessSchemaParameterCollection parameters = resultCompositeObjectListParameter.ItemProperties;
					if (entitySchema != null)
					{
						var entityColumns = entitySchema.Columns.AsEnumerable();
						ProcessSchemaParameter entityColumnMetaPathesParameter = parametersRef.GetByName("EntityColumnMetaPathes");
						string entityColumnMetaPathes = entityColumnMetaPathesParameter.SourceValue.Value;
						if (entityColumnMetaPathes.IsNotNullOrEmpty())
						{
							var entityColumnsUIds = entityColumnMetaPathes.Split(';');
							entityColumns = entityColumns.Join(entityColumnsUIds, column => column.UId, columnUId => Guid.Parse(columnUId),
								(column, columnUId) => column);
						}
						var valueTypesNotToSynchronize = new[] { DataValueType.BinaryDataValueTypeUId };
						var entitySchemaColumns = entityColumns.Where(x => !valueTypesNotToSynchronize.Contains(x.DataValueTypeUId)).ToArray();
						RemoveEntityColumnParameters(entitySchemaColumns, ref parameters);
						UpdateEntityColumnParameters(entitySchemaColumns, ref parameters);
						AddEntityColumnParameters(entitySchemaColumns, ref parameters, baseProcessSchema, elementUId);
					}
					else
					{
						parameters.Clear();
					}
				}
			}
		}

		#endregion

	}

	#endregion

	#region Class: ReadDataUserTask

	[DesignModeProperty(Name = "DataSourceFilters", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "cb455b6f78ff4b1eb241c2bbc0b37e9f", CaptionResourceItem = "Parameters.DataSourceFilters.Caption", DescriptionResourceItem = "Parameters.DataSourceFilters.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultType", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "cb455b6f78ff4b1eb241c2bbc0b37e9f", CaptionResourceItem = "Parameters.ResultType.Caption", DescriptionResourceItem = "Parameters.ResultType.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ReadSomeTopRecords", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "cb455b6f78ff4b1eb241c2bbc0b37e9f", CaptionResourceItem = "Parameters.ReadSomeTopRecords.Caption", DescriptionResourceItem = "Parameters.ReadSomeTopRecords.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "NumberOfRecords", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "cb455b6f78ff4b1eb241c2bbc0b37e9f", CaptionResourceItem = "Parameters.NumberOfRecords.Caption", DescriptionResourceItem = "Parameters.NumberOfRecords.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "FunctionType", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "cb455b6f78ff4b1eb241c2bbc0b37e9f", CaptionResourceItem = "Parameters.FunctionType.Caption", DescriptionResourceItem = "Parameters.FunctionType.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "AggregationColumnName", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "cb455b6f78ff4b1eb241c2bbc0b37e9f", CaptionResourceItem = "Parameters.AggregationColumnName.Caption", DescriptionResourceItem = "Parameters.AggregationColumnName.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "OrderInfo", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "cb455b6f78ff4b1eb241c2bbc0b37e9f", CaptionResourceItem = "Parameters.OrderInfo.Caption", DescriptionResourceItem = "Parameters.OrderInfo.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultEntity", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "cb455b6f78ff4b1eb241c2bbc0b37e9f", CaptionResourceItem = "Parameters.ResultEntity.Caption", DescriptionResourceItem = "Parameters.ResultEntity.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultCount", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "cb455b6f78ff4b1eb241c2bbc0b37e9f", CaptionResourceItem = "Parameters.ResultCount.Caption", DescriptionResourceItem = "Parameters.ResultCount.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultIntegerFunction", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "cb455b6f78ff4b1eb241c2bbc0b37e9f", CaptionResourceItem = "Parameters.ResultIntegerFunction.Caption", DescriptionResourceItem = "Parameters.ResultIntegerFunction.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultFloatFunction", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "cb455b6f78ff4b1eb241c2bbc0b37e9f", CaptionResourceItem = "Parameters.ResultFloatFunction.Caption", DescriptionResourceItem = "Parameters.ResultFloatFunction.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultDateTimeFunction", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "cb455b6f78ff4b1eb241c2bbc0b37e9f", CaptionResourceItem = "Parameters.ResultDateTimeFunction.Caption", DescriptionResourceItem = "Parameters.ResultDateTimeFunction.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultRowsCount", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "cb455b6f78ff4b1eb241c2bbc0b37e9f", CaptionResourceItem = "Parameters.ResultRowsCount.Caption", DescriptionResourceItem = "Parameters.ResultRowsCount.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "CanReadUncommitedData", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "cb455b6f78ff4b1eb241c2bbc0b37e9f", CaptionResourceItem = "Parameters.CanReadUncommitedData.Caption", DescriptionResourceItem = "Parameters.CanReadUncommitedData.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultEntityCollection", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "cb455b6f78ff4b1eb241c2bbc0b37e9f", CaptionResourceItem = "Parameters.ResultEntityCollection.Caption", DescriptionResourceItem = "Parameters.ResultEntityCollection.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "EntityColumnMetaPathes", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "cb455b6f78ff4b1eb241c2bbc0b37e9f", CaptionResourceItem = "Parameters.EntityColumnMetaPathes.Caption", DescriptionResourceItem = "Parameters.EntityColumnMetaPathes.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IgnoreDisplayValues", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "cb455b6f78ff4b1eb241c2bbc0b37e9f", CaptionResourceItem = "Parameters.IgnoreDisplayValues.Caption", DescriptionResourceItem = "Parameters.IgnoreDisplayValues.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultCompositeObjectList", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "cb455b6f78ff4b1eb241c2bbc0b37e9f", CaptionResourceItem = "Parameters.ResultCompositeObjectList.Caption", DescriptionResourceItem = "Parameters.ResultCompositeObjectList.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ConsiderTimeInFilter", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "cb455b6f78ff4b1eb241c2bbc0b37e9f", CaptionResourceItem = "Parameters.ConsiderTimeInFilter.Caption", DescriptionResourceItem = "Parameters.ConsiderTimeInFilter.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class ReadDataUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public ReadDataUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f");
			_considerTimeInFilter = () => { return false; };
		}

		#endregion

		#region Properties: Public

		public virtual string DataSourceFilters {
			get;
			set;
		}

		private int _resultType = 0;
		public virtual int ResultType {
			get {
				return _resultType;
			}
			set {
				_resultType = value;
			}
		}

		public virtual bool ReadSomeTopRecords {
			get;
			set;
		}

		public virtual int NumberOfRecords {
			get;
			set;
		}

		public virtual int FunctionType {
			get;
			set;
		}

		public virtual string AggregationColumnName {
			get;
			set;
		}

		public virtual string OrderInfo {
			get;
			set;
		}

		private Entity _resultEntity;
		public virtual Entity ResultEntity {
			get {
				return _resultEntity ?? (_resultEntity = new Entity(UserConnection));
			}
			set {
				_resultEntity = value;
			}
		}

		public virtual int ResultCount {
			get;
			set;
		}

		public virtual int ResultIntegerFunction {
			get;
			set;
		}

		public virtual Decimal ResultFloatFunction {
			get;
			set;
		}

		public virtual DateTime ResultDateTimeFunction {
			get;
			set;
		}

		public virtual int ResultRowsCount {
			get;
			set;
		}

		private bool _canReadUncommitedData = true;
		public virtual bool CanReadUncommitedData {
			get {
				return _canReadUncommitedData;
			}
			set {
				_canReadUncommitedData = value;
			}
		}

		public virtual EntityCollection ResultEntityCollection {
			get;
			set;
		}

		public virtual string EntityColumnMetaPathes {
			get;
			set;
		}

		public virtual bool IgnoreDisplayValues {
			get;
			set;
		}

		public virtual ICompositeObjectList<ICompositeObject> ResultCompositeObjectList {
			get;
			set;
		}

		private Func<bool> _considerTimeInFilter;
		public virtual bool ConsiderTimeInFilter {
			get {
				return (_considerTimeInFilter ?? (_considerTimeInFilter = () => false)).Invoke();
			}
			set {
				_considerTimeInFilter = () => { return value; };
			}
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			EntitySchema entitySchema = ResultEntity.Schema;
			if (entitySchema == null) {
				return true;
			}
			var esq = CreateEntitySchemaQuery(entitySchema.Name);
			esq.UseAdminRights = false;
			string aggregationColumnName = "Function";
			ProcessReadDataResultType resultType = (ProcessReadDataResultType)ResultType;
			SpecifyESQColumns(esq, resultType, ref aggregationColumnName);
			ProcessUserTaskUtilities.SpecifyESQFilters(UserConnection, this, entitySchema, esq, DataSourceFilters);
			SpecifyESQOrderByStatements(esq, resultType);
			esq.CanReadUncommitedData = CanReadUncommitedData;
			esq.IgnoreDisplayValues = IgnoreDisplayValues;
			if (GlobalAppSettings.FeatureReadDataUserTaskUseChunks && resultType == ProcessReadDataResultType.EntityCollection) {
				esq.ChunkSize = Core.Configuration.SysSettings.GetValue(UserConnection, "ReadDataChunkSize", 50);
			}
			EntityCollection entityCollection = esq.GetEntityCollection(UserConnection);
			ResultRowsCount = entityCollection.Count;
			if (resultType == ProcessReadDataResultType.EntityCollection) {
				FillResultCompositeObjectList((IProcessParametersMetaInfo)GetSchemaElement(), entityCollection);
			}
			if (ResultRowsCount == 0) {
				ResultEntityCollection = entityCollection;
				return true;
			}
			Entity resultEntity = entityCollection.First.Value;
			if (resultType != ProcessReadDataResultType.Function) {
				ResultEntity = resultEntity;
				ResultEntityCollection = entityCollection;
				return true;
			}
			EntitySchemaColumn aggregationColumn = resultEntity.Schema.Columns.GetByName(aggregationColumnName);
			if (FunctionType == (int)AggregationTypeStrict.Count) {
				ResultCount = resultEntity.GetTypedColumnValue<int>(aggregationColumnName);
			} else if (aggregationColumn.DataValueType is IntegerDataValueType) {
				ResultIntegerFunction = resultEntity.GetTypedColumnValue<int>(aggregationColumnName);
			} else if (aggregationColumn.DataValueType is NumericDataValueType) {
				ResultFloatFunction = resultEntity.GetTypedColumnValue<decimal>(aggregationColumnName);
			} else if (aggregationColumn.DataValueType is DateTimeDataValueType) {
				ResultDateTimeFunction = resultEntity.GetTypedColumnValue<DateTime>(aggregationColumnName);
			}
			return true;
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			return base.CompleteExecuting(parameters);
		}

		public virtual void SpecifyESQColumns(EntitySchemaQuery esq, ProcessReadDataResultType resultType, ref string aggregationColumnName) {
			if (resultType == ProcessReadDataResultType.Function) {
				var aggregationType = (AggregationTypeStrict)FunctionType;
				if (string.IsNullOrEmpty(AggregationColumnName) && aggregationType == AggregationTypeStrict.Count) {
					EntitySchema entitySchema = esq.RootSchema;
					aggregationColumnName = entitySchema.PrimaryColumn.Name;
				} else {
					aggregationColumnName = AggregationColumnName;
				}
				aggregationColumnName = esq.AddColumn(
					esq.CreateAggregationFunction(aggregationType, aggregationColumnName)).Name;
				return;
			}
			if (string.IsNullOrEmpty(EntityColumnMetaPathes)) {
				esq.AddAllSchemaColumns();
			} else {
				EntitySchema entitySchema = esq.RootSchema;
				string[] metaPathes = EntityColumnMetaPathes.Split(';');
				foreach(string metaPath in metaPathes) {
					string columnPath = entitySchema.GetSchemaColumnPathByMetaPath(metaPath);
					if (columnPath == esq.PrimaryQueryColumn.Path) {
						continue;
					}
					esq.AddColumn(columnPath);
				}
			}
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			if (resultType == ProcessReadDataResultType.Entity) {
				esq.RowCount = 1;
			}
			if (ReadSomeTopRecords) {
				esq.RowCount = NumberOfRecords;
			}
		}

		public virtual void SpecifyESQOrderByStatements(EntitySchemaQuery esq, ProcessReadDataResultType resultType) {
			if (resultType == ProcessReadDataResultType.Function || OrderInfo == null || OrderInfo.Length == 0) {
				return;
			}
			EntitySchemaQueryColumnCollection columns = esq.Columns;
			string[] orders = OrderInfo.Split(',');
			for (int i = 0; i < orders.Length; i++) {
				string[] order = orders[i].Split(':');
				if (order.Length != 3) {
					continue;
				}
				string columnPath = order[0];
				EntitySchemaQueryColumn column = columns.FindByName(columnPath);
				if (column == null) {
					column = esq.AddColumn(columnPath);
				}
				column.OrderDirection = (OrderDirection)Enum.Parse(typeof(OrderDirection), order[1]);
				column.OrderPosition = int.Parse(order[2]);
			}
		}

		public virtual void FillResultCompositeObjectList(IProcessParametersMetaInfo schemaElement, EntityCollection entityCollection) {
			if (entityCollection.Any()) {
				var entity = entityCollection.First();
				ProcessSchemaParameterCollection schemaParameters = schemaElement.Parameters;
				var metadataParameter = schemaParameters.GetByName("ResultCompositeObjectList");
				Dictionary<string, string> keyMap = new Dictionary<string, string>();
				foreach (var nestedParameterItemProperty in metadataParameter.ItemProperties ) {
					var column = entity.Schema.Columns.FindByUId(Guid.Parse(nestedParameterItemProperty.Tag));
					keyMap[nestedParameterItemProperty.Name] = column.Name;
				}
				ResultCompositeObjectList = entityCollection.Transform(keyMap);
			}
		}

		public virtual EntitySchemaQuery CreateEntitySchemaQuery(string entitySchemaName) {
			return new EntitySchemaQuery(UserConnection.EntitySchemaManager, entitySchemaName);
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("DataSourceFilters")) {
				writer.WriteValue("DataSourceFilters", DataSourceFilters, null);
			}
			if (!HasMapping("ResultType")) {
				writer.WriteValue("ResultType", ResultType, 0);
			}
			if (!HasMapping("ReadSomeTopRecords")) {
				writer.WriteValue("ReadSomeTopRecords", ReadSomeTopRecords, false);
			}
			if (!HasMapping("NumberOfRecords")) {
				writer.WriteValue("NumberOfRecords", NumberOfRecords, 0);
			}
			if (!HasMapping("FunctionType")) {
				writer.WriteValue("FunctionType", FunctionType, 0);
			}
			if (!HasMapping("AggregationColumnName")) {
				writer.WriteValue("AggregationColumnName", AggregationColumnName, null);
			}
			if (!HasMapping("OrderInfo")) {
				writer.WriteValue("OrderInfo", OrderInfo, null);
			}
			if (ResultEntity != null && ResultEntity.Schema != null) {
				if (UseFlowEngineMode) {
					ResultEntity.Write(writer, "ResultEntity");
				} else {
					string serializedEntity = Entity.SerializeToJson(ResultEntity);
					writer.WriteValue("ResultEntity", serializedEntity, null);
				}
			}
			if (!HasMapping("ResultCount")) {
				writer.WriteValue("ResultCount", ResultCount, 0);
			}
			if (!HasMapping("ResultIntegerFunction")) {
				writer.WriteValue("ResultIntegerFunction", ResultIntegerFunction, 0);
			}
			if (!HasMapping("ResultFloatFunction")) {
				writer.WriteValue("ResultFloatFunction", ResultFloatFunction, 0m);
			}
			if (!HasMapping("ResultDateTimeFunction")) {
				writer.WriteValue("ResultDateTimeFunction", ResultDateTimeFunction, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
			if (!HasMapping("ResultRowsCount")) {
				writer.WriteValue("ResultRowsCount", ResultRowsCount, 0);
			}
			if (!HasMapping("CanReadUncommitedData")) {
				writer.WriteValue("CanReadUncommitedData", CanReadUncommitedData, false);
			}
			if (!HasMapping("EntityColumnMetaPathes")) {
				writer.WriteValue("EntityColumnMetaPathes", EntityColumnMetaPathes, null);
			}
			if (!HasMapping("IgnoreDisplayValues")) {
				writer.WriteValue("IgnoreDisplayValues", IgnoreDisplayValues, false);
			}
			WriteSerializableObject<ICompositeObjectList<ICompositeObject>>(writer, "ResultCompositeObjectList", ResultCompositeObjectList);
			if (!HasMapping("ConsiderTimeInFilter")) {
				writer.WriteValue("ConsiderTimeInFilter", ConsiderTimeInFilter, false);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "DataSourceFilters":
					DataSourceFilters = reader.GetStringValue();
				break;
				case "ResultType":
					ResultType = reader.GetIntValue();
				break;
				case "ReadSomeTopRecords":
					ReadSomeTopRecords = reader.GetBoolValue();
				break;
				case "NumberOfRecords":
					NumberOfRecords = reader.GetIntValue();
				break;
				case "FunctionType":
					FunctionType = reader.GetIntValue();
				break;
				case "AggregationColumnName":
					AggregationColumnName = reader.GetStringValue();
				break;
				case "OrderInfo":
					OrderInfo = reader.GetStringValue();
				break;
				case "ResultEntity":
					if (UseFlowEngineMode) {
						ResultEntity = reader.GetValue<Entity>();
					} else {
						ResultEntity = Entity.DeserializeFromJson(UserConnection, reader.GetValue<System.String>());
					}
				break;
				case "ResultCount":
					ResultCount = reader.GetIntValue();
				break;
				case "ResultIntegerFunction":
					ResultIntegerFunction = reader.GetIntValue();
				break;
				case "ResultFloatFunction":
					ResultFloatFunction = reader.GetValue<System.Decimal>();
				break;
				case "ResultDateTimeFunction":
					ResultDateTimeFunction = reader.GetDateTimeValue();
				break;
				case "ResultRowsCount":
					ResultRowsCount = reader.GetIntValue();
				break;
				case "CanReadUncommitedData":
					CanReadUncommitedData = reader.GetBoolValue();
				break;
				case "EntityColumnMetaPathes":
					EntityColumnMetaPathes = reader.GetStringValue();
				break;
				case "IgnoreDisplayValues":
					IgnoreDisplayValues = reader.GetBoolValue();
				break;
				case "ResultCompositeObjectList":
					ResultCompositeObjectList = ReadSerializableObject<ICompositeObjectList<ICompositeObject>>(reader);
				break;
				case "ConsiderTimeInFilter":
					ConsiderTimeInFilter = reader.GetBoolValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

