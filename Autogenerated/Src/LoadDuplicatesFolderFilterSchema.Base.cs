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

	#region Class: LoadDuplicatesFolderFilterSchema

	/// <exclude/>
	public class LoadDuplicatesFolderFilterSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public LoadDuplicatesFolderFilterSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public LoadDuplicatesFolderFilterSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1e3195d9-976c-421b-8570-5207023cf352");
			RealUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352");
			Name = "LoadDuplicatesFolderFilter";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,80,42,75,44,82,72,73,44,73,12,206,47,45,74,78,85,176,85,112,65,112,18,139,21,66,82,139,138,18,139,243,211,74,244,66,61,245,194,83,147,156,243,243,74,138,242,115,138,245,224,12,215,188,146,204,146,74,132,46,107,46,132,113,122,62,249,137,41,153,121,233,10,218,200,230,66,5,173,185,138,82,75,74,139,242,20,74,138,74,83,173,149,0,160,102,74,237,139,0,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateDataSourceParameter());
			Parameters.Add(CreateDuplicatesTableNameParameter());
		}

		protected virtual ProcessSchemaParameter CreateDataSourceParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("5e18217f-2935-47b5-bca3-974fd1a2d995"),
				Name = "DataSource",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDuplicatesTableNameParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("5b9b9c6d-d7e8-4e48-9448-4aef657a3c6d"),
				Name = "DuplicatesTableName",
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
			Methods.Add(CreateUpdateFiltersRightExprMetaDataByParameterValueMethod());
			Methods.Add(CreateDataSourceLoadingMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("12d978ef-ec5a-4791-aa47-0c06c8046846"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9cf16e0f-ffa3-47c5-a327-a4cbc478f7b8"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("04dd9f85-4076-4d3c-8c81-972e453d8de3"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("91f911eb-38dc-45da-87c3-1fd89029b750"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352"),
				ModifiedInSchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6093076f-ca41-4159-b373-322a6ab0351d"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352"),
				ModifiedInSchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3ebe345b-3051-4413-9aa4-56f12c2527e7"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("91e13d63-0be6-4bd5-8a86-7285675ad137"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352"),
				ModifiedInSchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateFiltersRightExprMetaDataByParameterValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("496768a2-8736-45d7-b77b-c1354611062b"),
				Name = "UpdateFiltersRightExprMetaDataByParameterValue",
				CreatedInSchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f580ee40-2f76-459b-9c3b-3eadcd46cecc"),
				Name = "process",
				CreatedInSchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352"),
				ModifiedInSchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Process",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a1782f18-4ec1-47cc-aa7e-32f54e27148b"),
				Name = "filters",
				CreatedInSchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352"),
				ModifiedInSchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceFilterCollection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,203,106,195,48,16,69,215,41,244,31,166,155,32,67,17,105,183,193,133,36,125,172,10,33,105,187,41,93,168,238,56,22,216,146,209,35,212,148,252,123,37,91,145,169,251,74,22,6,89,115,231,204,157,171,92,42,100,89,1,100,203,20,228,188,52,168,128,139,112,210,9,124,156,158,140,124,233,141,25,182,150,86,101,24,68,41,144,235,120,119,219,222,37,93,105,234,90,120,14,100,216,66,87,124,83,152,155,247,90,161,214,92,10,250,208,212,8,105,10,67,78,47,241,10,186,176,218,200,170,179,50,58,16,250,31,115,201,20,171,48,152,61,204,109,108,209,116,33,173,48,222,249,101,112,213,70,84,71,129,155,127,4,110,26,9,238,159,45,153,41,92,127,15,123,190,120,161,79,172,180,216,233,126,40,120,185,146,153,3,211,59,52,17,220,214,230,205,125,128,18,162,141,226,98,147,236,167,36,67,32,93,97,37,183,56,51,100,210,213,118,191,134,179,182,175,93,174,26,206,82,16,182,44,97,60,254,190,116,47,11,153,93,193,100,31,217,99,237,228,225,117,116,76,199,187,245,111,55,111,190,238,65,194,134,231,127,13,233,93,187,111,247,9,246,23,61,245,219,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDataSourceLoadingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2d2c7cdb-cfb9-479e-82ad-d0e67bb1b67a"),
				Name = "DataSourceLoading",
				CreatedInSchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("44765502-3409-42d4-97b8-675b0890f1f3"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352"),
				ModifiedInSchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("80b67fd1-93ff-409b-bf6e-92a2cbd01cc2"),
				Name = "args",
				CreatedInSchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352"),
				ModifiedInSchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,203,110,219,48,16,60,75,95,65,232,68,1,13,145,156,221,4,136,95,129,128,180,65,33,39,62,211,226,218,38,34,147,10,31,105,141,162,255,222,165,40,75,145,157,67,116,18,119,57,195,153,225,242,157,27,34,184,227,165,246,166,2,114,75,44,40,1,134,112,75,86,96,12,183,122,235,216,115,193,214,176,153,105,229,140,174,45,235,127,22,202,73,119,156,247,240,73,250,224,165,32,194,55,181,172,184,131,210,113,231,109,33,38,233,123,56,102,92,142,96,60,241,217,130,65,74,5,149,147,90,117,164,101,181,135,3,255,193,21,223,129,97,75,169,68,161,172,227,170,130,233,241,39,63,0,205,230,99,186,44,103,51,3,184,140,120,58,102,205,39,233,167,199,179,37,184,106,191,52,250,48,159,210,108,166,5,100,223,200,64,157,93,226,10,129,146,63,231,122,0,183,58,54,32,102,186,246,7,245,194,107,15,223,67,32,119,52,43,4,82,37,109,12,22,106,212,132,36,220,236,44,43,219,213,47,15,230,24,83,178,126,83,158,118,40,248,77,226,226,220,78,154,132,143,5,225,180,87,107,87,124,83,67,72,231,212,143,74,104,22,5,222,4,21,93,103,46,173,147,10,137,79,133,245,30,12,166,26,13,61,109,123,210,128,97,133,93,188,121,94,211,200,23,6,192,58,122,17,76,158,135,177,137,130,163,25,52,128,123,133,12,154,59,63,173,213,190,72,99,26,24,243,199,173,172,255,11,121,34,112,12,10,69,54,173,117,245,26,79,169,176,209,78,110,160,26,176,103,156,143,176,117,139,63,141,1,107,47,212,4,87,67,143,14,15,130,197,57,100,33,84,28,140,246,26,199,180,5,122,56,93,25,246,228,150,208,160,7,101,120,229,200,29,185,206,201,223,52,233,74,95,117,149,116,150,90,216,218,240,166,173,83,228,79,198,158,244,14,111,160,126,106,192,240,46,227,243,18,187,87,248,254,254,165,45,213,189,16,244,35,65,24,239,193,235,163,230,66,170,29,185,186,37,195,155,238,138,147,255,219,171,132,66,41,4,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LoadDuplicatesFolderFilterSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1e3195d9-976c-421b-8570-5207023cf352"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new LoadDuplicatesFolderFilter(userConnection) {
				SchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352")
			};
		}

		#endregion

	}

	#endregion

	#region Class: LoadDuplicatesFolderFilter

	[DesignModeProperty(Name = "DataSource", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "1e3195d9976c421b85705207023cf352", CaptionResourceItem = "Parameters.DataSource.Caption", DescriptionResourceItem = "Parameters.DataSource.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DuplicatesTableName", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "1e3195d9976c421b85705207023cf352", CaptionResourceItem = "Parameters.DuplicatesTableName.Caption", DescriptionResourceItem = "Parameters.DuplicatesTableName.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class LoadDuplicatesFolderFilter : ProcessUserTask
	{

		#region Constructors: Public

		public LoadDuplicatesFolderFilter(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352");
		}

		#endregion

		#region Properties: Public

		public virtual Object DataSource {
			get;
			set;
		}

		public virtual string DuplicatesTableName {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			var dataSource = DataSource as Terrasoft.UI.WebControls.Controls.EntityDataSource;
			dataSource.Loading += DataSourceLoading;
			return true;
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			return base.CompleteExecuting(parameters);
		}

		public virtual void UpdateFiltersRightExprMetaDataByParameterValue(Process process, DataSourceFilterCollection filters) {
			foreach (var filter in filters) {
				var dataSourcefilter = (DataSourceFilter)filter;
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

		public virtual void DataSourceLoading(object sender, DataSourceEventArgs args) {
			var dataSource = sender as Terrasoft.UI.WebControls.Controls.EntityDataSource;
			Guid duplicateStatusId;
			var duplicateStatusEntity = UserConnection.EntitySchemaManager.FindInstanceByName("DuplicateStatus").CreateEntity(UserConnection);
			duplicateStatusEntity.FetchFromDB("Code", "Duplicate");
			duplicateStatusId = duplicateStatusEntity.GetTypedColumnValue<Guid>("Id");	
			var select = args.SelectQuery;
			var subSelect = new Select(UserConnection)
								.From(DuplicatesTableName)
								.Column("Entity1Id")
								.Distinct()
								.Where("StatusOfDuplicateId").IsEqual(Column.Const(duplicateStatusId)) as Select;
			var newCondition = new QueryCondition(select);
			newCondition.ConditionType = QueryConditionType.Block;
			var cond = select.Condition;
			newCondition.LeftExpression = new QueryColumnExpression(dataSource.Schema.Name, "Id");
			newCondition.In(subSelect);
			if (cond.Count > 0) {
				cond.ConditionType = QueryConditionType.Block;
				cond = cond.WrapBlock();
				newCondition.LogicalOperation = LogicalOperation.And;
			}
			cond.Add(newCondition);
			dataSource.Loading -= DataSourceLoading;
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (DataSource != null) {
				if (DataSource.GetType().IsSerializable || DataSource.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("DataSource", DataSource, null);
				}
			}
			if (!HasMapping("DuplicatesTableName")) {
				writer.WriteValue("DuplicatesTableName", DuplicatesTableName, null);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "DataSource":
					DataSource = reader.GetSerializableObjectValue();
				break;
				case "DuplicatesTableName":
					DuplicatesTableName = reader.GetStringValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

