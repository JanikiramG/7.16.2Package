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

	#region Class: CheckUniqueNumberValueUserTaskSchema

	/// <exclude/>
	public class CheckUniqueNumberValueUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public CheckUniqueNumberValueUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public CheckUniqueNumberValueUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5f4f8d00-f750-4397-9ae2-c043a7442f05");
			RealUId = new Guid("5f4f8d00-f750-4397-9ae2-c043a7442f05");
			Name = "CheckUniqueNumberValueUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,83,193,78,195,48,12,61,15,137,127,136,122,152,146,75,196,125,2,193,182,14,237,192,128,177,193,1,113,200,58,111,171,212,166,224,36,99,21,226,223,113,210,78,235,88,161,106,43,197,207,126,182,95,236,235,40,93,49,110,44,166,122,45,199,102,226,178,236,30,227,252,221,150,124,226,242,5,224,179,202,28,8,193,190,206,207,58,83,48,46,179,236,146,89,116,208,59,63,251,102,144,25,8,208,86,33,3,109,83,91,62,37,27,200,213,157,210,106,13,72,190,73,161,45,236,172,156,27,192,65,161,53,36,54,45,180,188,5,123,228,201,163,40,62,141,143,34,193,148,97,45,72,175,37,41,101,107,169,193,167,26,107,99,149,78,160,95,206,199,75,222,164,163,243,73,138,54,238,137,202,225,23,191,244,182,189,111,82,100,46,215,109,94,131,128,24,95,70,149,190,50,248,196,71,12,58,232,253,4,25,41,68,28,26,62,217,12,16,149,41,86,150,72,16,228,176,47,43,152,183,139,42,136,41,60,117,78,126,26,63,114,58,161,131,211,158,99,95,177,16,242,198,208,5,84,55,30,80,18,190,38,147,35,44,114,126,210,183,144,47,27,64,104,178,208,252,196,31,78,101,220,151,254,232,0,203,7,133,4,88,186,221,227,97,34,189,255,106,205,171,225,12,77,35,227,94,148,229,34,222,65,226,108,241,207,40,197,218,56,132,97,255,96,226,245,192,54,153,16,212,50,12,100,83,103,89,177,195,52,128,252,144,109,79,208,241,235,81,133,74,239,196,5,235,118,217,175,2,134,253,89,249,14,100,216,2,82,179,116,14,141,206,138,49,201,92,5,191,94,188,9,118,197,46,246,180,135,93,90,41,218,161,94,48,54,246,169,233,81,111,155,119,240,127,255,163,143,94,4,235,80,87,120,244,3,222,140,107,231,202,3,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateEntitySchemaUIdParameter());
			Parameters.Add(CreateColumnUIdParameter());
			Parameters.Add(CreateNumberValueParameter());
			Parameters.Add(CreateResultParameter());
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("a16921d6-aace-4cec-9d00-a23d561da4d9"),
				Name = "EntitySchemaUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnUIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e7b7f5c5-bf5e-4a8d-a0b1-2b92b23c2683"),
				Name = "ColumnUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateNumberValueParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("dede7527-55e2-4327-a9f6-aeb6a9de474b"),
				Name = "NumberValue",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateResultParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("50b2740d-d977-453f-b4cf-12646a34b3a3"),
				Name = "Result",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
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
			Methods.Add(CreateUpdateFiltersRightExprMetaDataByParameterValueMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("62075b76-df47-4ff0-80be-ce3ccb0890e4"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateUpdateFiltersRightExprMetaDataByParameterValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9c186aa3-a438-4c66-ae16-92641093bfa7"),
				Name = "UpdateFiltersRightExprMetaDataByParameterValue",
				CreatedInSchemaUId = new Guid("5f4f8d00-f750-4397-9ae2-c043a7442f05"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ccf985e8-4b65-4d32-b38c-f5a3fd16b694"),
				Name = "process",
				CreatedInSchemaUId = new Guid("5f4f8d00-f750-4397-9ae2-c043a7442f05"),
				ModifiedInSchemaUId = new Guid("5f4f8d00-f750-4397-9ae2-c043a7442f05"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Process",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7eb3ee6b-bfb3-4d24-a23b-83423026ca15"),
				Name = "filters",
				CreatedInSchemaUId = new Guid("5f4f8d00-f750-4397-9ae2-c043a7442f05"),
				ModifiedInSchemaUId = new Guid("5f4f8d00-f750-4397-9ae2-c043a7442f05"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceFilterCollection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,82,77,79,194,48,24,62,143,95,81,47,164,75,76,131,94,9,38,130,31,39,18,2,234,197,120,168,227,133,53,217,218,165,125,75,36,102,255,221,118,237,134,130,34,122,235,250,62,95,125,246,174,148,6,158,229,132,110,184,38,43,81,32,104,34,100,60,153,148,188,247,18,177,34,180,157,24,114,195,145,47,148,213,25,220,53,119,19,85,20,144,161,80,178,1,39,143,213,146,99,156,153,185,88,231,120,251,86,233,41,32,247,204,241,118,198,53,47,193,13,159,120,97,129,86,90,101,96,204,57,161,71,132,131,123,58,116,242,153,146,40,164,5,119,174,147,94,226,83,47,59,98,76,57,58,20,139,18,195,240,154,125,6,235,114,186,40,206,144,140,70,68,218,162,8,47,250,108,121,26,159,61,108,43,240,34,251,49,118,16,143,96,19,107,80,149,193,229,68,205,223,36,187,122,125,89,39,101,237,24,134,77,148,149,232,115,95,134,76,77,189,85,55,119,238,127,80,27,182,2,238,147,207,56,230,142,190,211,122,190,120,97,205,6,52,176,111,238,61,58,236,6,187,7,252,186,53,227,237,52,106,82,106,80,11,185,78,91,147,116,79,143,205,161,84,27,184,70,58,104,70,245,79,181,44,236,107,92,90,114,22,254,62,233,247,15,223,187,131,197,182,174,200,32,150,245,223,205,63,226,209,70,174,123,245,7,22,168,67,142,169,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CheckUniqueNumberValueUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5f4f8d00-f750-4397-9ae2-c043a7442f05"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new CheckUniqueNumberValueUserTask(userConnection) {
				SchemaUId = new Guid("5f4f8d00-f750-4397-9ae2-c043a7442f05")
			};
		}

		#endregion

	}

	#endregion

	#region Class: CheckUniqueNumberValueUserTask

	[DesignModeProperty(Name = "EntitySchemaUId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "5f4f8d00f75043979ae2c043a7442f05", CaptionResourceItem = "Parameters.EntitySchemaUId.Caption", DescriptionResourceItem = "Parameters.EntitySchemaUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ColumnUId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "5f4f8d00f75043979ae2c043a7442f05", CaptionResourceItem = "Parameters.ColumnUId.Caption", DescriptionResourceItem = "Parameters.ColumnUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "NumberValue", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "5f4f8d00f75043979ae2c043a7442f05", CaptionResourceItem = "Parameters.NumberValue.Caption", DescriptionResourceItem = "Parameters.NumberValue.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Result", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "5f4f8d00f75043979ae2c043a7442f05", CaptionResourceItem = "Parameters.Result.Caption", DescriptionResourceItem = "Parameters.Result.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class CheckUniqueNumberValueUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public CheckUniqueNumberValueUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("5f4f8d00-f750-4397-9ae2-c043a7442f05");
		}

		#endregion

		#region Properties: Public

		public virtual Guid EntitySchemaUId {
			get;
			set;
		}

		public virtual Guid ColumnUId {
			get;
			set;
		}

		public virtual string NumberValue {
			get;
			set;
		}

		public virtual bool Result {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			if (string.IsNullOrEmpty(NumberValue)) {
				Result = true;
			} else {
				var entitySchemaManager = context.UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
				var entitySchema = entitySchemaManager.GetInstanceByUId(EntitySchemaUId) as EntitySchema;
				var entitySchemaName = entitySchema.Name;
				var columnName = entitySchema.Columns.GetByUId(ColumnUId).Name;
				var numberSelect = new Terrasoft.Core.DB.Select(context.UserConnection)
									.Column(Terrasoft.Core.DB.Func.Count(columnName)).As("NumberCount")
								.From(entitySchema.Name).Where(columnName).IsEqual(new QueryParameter(NumberValue)) as Terrasoft.Core.DB.Select;
				using (var dbExecutor = context.UserConnection.EnsureDBConnection()) {
					using (var reader = numberSelect.ExecuteReader(dbExecutor)) {
						if (reader.Read() && UserConnection.DBTypeConverter.DBValueToInt(reader[0]) > 0) {
							Result = false;
						} else {
							Result = true;
						}
					}
				}
			}
			return true;
		}

		#endregion

		#region Methods: Public

		public virtual void UpdateFiltersRightExprMetaDataByParameterValue(Process process, DataSourceFilterCollection filters) {
			foreach (var filter in filters) {
				if (filter is DataSourceFilterCollection) {
					UpdateFiltersRightExprMetaDataByParameterValue(process, (DataSourceFilterCollection)filter);
					continue;
				}	
				var dataSourcefilter = (DataSourceFilter)filter;
				if (dataSourcefilter.RightExpression == null) {
					continue;
				}
				if (dataSourcefilter.RightExpression.Type == DataSourceFilterExpressionType.Custom) {
					dataSourcefilter.RightExpression.Type = DataSourceFilterExpressionType.Parameter;
					if (dataSourcefilter.RightExpression.Parameters.Count == 2) {
						var parameters = dataSourcefilter.RightExpression.Parameters;
						var metaPath = parameters[1].Value;
						parameters[1].Value = process.GetParameterValueByMetaPath((string)metaPath);
						parameters.RemoveAt(0);
					}
					if (dataSourcefilter.SubFilters != null && dataSourcefilter.SubFilters.Count > 0) {
						UpdateFiltersRightExprMetaDataByParameterValue(process, dataSourcefilter.SubFilters);
					}
				}
			}
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("EntitySchemaUId")) {
				writer.WriteValue("EntitySchemaUId", EntitySchemaUId, Guid.Empty);
			}
			if (!HasMapping("ColumnUId")) {
				writer.WriteValue("ColumnUId", ColumnUId, Guid.Empty);
			}
			if (!HasMapping("NumberValue")) {
				writer.WriteValue("NumberValue", NumberValue, null);
			}
			if (!HasMapping("Result")) {
				writer.WriteValue("Result", Result, false);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "EntitySchemaUId":
					EntitySchemaUId = reader.GetGuidValue();
				break;
				case "ColumnUId":
					ColumnUId = reader.GetGuidValue();
				break;
				case "NumberValue":
					NumberValue = reader.GetStringValue();
				break;
				case "Result":
					Result = reader.GetBoolValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

