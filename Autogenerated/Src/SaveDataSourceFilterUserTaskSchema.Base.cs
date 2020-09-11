namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using System.IO;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: SaveDataSourceFilterUserTaskSchema

	/// <exclude/>
	public class SaveDataSourceFilterUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public SaveDataSourceFilterUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public SaveDataSourceFilterUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56");
			RealUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56");
			Name = "SaveDataSourceFilterUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,143,77,14,130,64,12,133,215,204,41,26,86,186,225,2,198,196,196,31,226,206,100,68,215,21,138,78,50,204,152,210,49,65,241,238,66,76,0,221,245,181,95,95,251,86,241,3,25,10,20,212,62,112,78,176,132,205,40,176,134,35,49,99,237,75,73,178,125,114,166,203,218,59,97,111,235,100,40,70,126,161,76,9,179,169,217,18,92,176,54,106,91,208,226,217,184,235,214,137,145,70,231,55,170,112,95,244,64,26,76,145,108,171,187,52,48,98,107,111,67,229,178,127,66,69,19,171,3,155,10,185,249,162,39,180,129,126,225,57,188,84,196,36,129,29,8,135,238,187,183,234,195,214,196,6,173,121,82,161,165,247,233,34,167,36,122,232,238,140,21,226,73,140,249,66,101,247,78,82,159,116,246,191,222,77,167,71,226,15,178,247,55,139,82,1,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateDataSourceParameter());
			Parameters.Add(CreateFilterNameParameter());
			Parameters.Add(CreateStoringEntitySchemaIdParameter());
			Parameters.Add(CreateStoringColumnUIdParameter());
			Parameters.Add(CreateStoringPrimaryColumnValueParameter());
		}

		protected virtual ProcessSchemaParameter CreateDataSourceParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("4e4a942e-4c1c-4f82-ad81-2a31dc803558"),
				Name = "DataSource",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = false,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateFilterNameParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("ceeccb53-4da6-44f3-90f4-3dc0b2b77c20"),
				Name = "FilterName",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateStoringEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("75ef1f3b-49eb-42fb-b03c-4ff85947d252"),
				Name = "StoringEntitySchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateStoringColumnUIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("a6076ecf-79e9-44b3-b2db-3cea26f4f3e5"),
				Name = "StoringColumnUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateStoringPrimaryColumnValueParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("fff64137-08d6-4b74-a9a5-d1afd25c0f2c"),
				Name = "StoringPrimaryColumnValue",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
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
			Methods.Add(CreateGetSerializedFilterMethod());
			Methods.Add(CreateUpdateDataMethod());
			Methods.Add(CreateUpdateFiltersRightExprMetaDataByParameterValueMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d9d0f354-94a6-489d-9e19-0abb0610fc35"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7753d859-b7c5-41ca-870c-98dcb6570542"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("85891215-d4ef-4ddc-b093-4a47b07819ab"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1742e38e-9781-4bef-9997-47d318abf1c4"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("497556b5-69c9-4fb4-9fc2-cf7ad1174c64"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("57ad1bff-14fe-449d-92bf-11e2e03daf87"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateGetSerializedFilterMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a0ebeb86-31c2-4667-9fbf-a0120fbbed1f"),
				Name = "GetSerializedFilter",
				CreatedInSchemaUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3b5f451c-47bb-490e-960c-680dda8271ad"),
				Name = "dataSource",
				CreatedInSchemaUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56"),
				ModifiedInSchemaUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.UI.WebControls.Controls.DataSource",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,142,193,10,130,64,16,134,207,9,190,195,226,105,5,217,23,144,46,153,65,29,236,32,61,192,162,99,108,232,24,179,179,134,69,239,158,182,81,118,26,254,153,249,191,255,55,141,144,150,201,224,89,237,109,225,218,246,72,121,119,229,81,238,76,203,64,133,238,32,142,197,35,12,86,191,133,88,139,200,171,188,54,28,165,97,240,12,131,65,147,104,222,203,233,92,107,214,101,239,168,2,149,57,34,64,46,153,92,197,142,64,121,167,157,38,214,155,113,230,45,179,82,79,186,216,30,179,30,7,32,15,68,184,137,237,23,250,65,28,150,79,242,100,129,38,133,80,177,233,49,89,116,152,161,4,83,56,138,217,162,74,32,163,91,115,7,233,11,39,255,113,113,250,2,55,30,110,251,21,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7b9972eb-2146-42e6-834b-e16b317813d7"),
				Name = "UpdateData",
				CreatedInSchemaUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8786c1ef-09de-4dce-a4de-c34d759ab359"),
				Name = "serializedString",
				CreatedInSchemaUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56"),
				ModifiedInSchemaUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,146,65,107,132,48,16,133,207,245,87,132,61,37,176,132,30,11,210,139,118,45,30,182,44,184,246,62,232,236,110,192,36,144,100,45,182,244,191,119,98,164,40,237,73,242,102,222,247,102,18,155,224,16,52,243,233,243,204,12,126,176,35,106,235,166,102,150,120,123,174,158,14,166,179,189,50,87,25,15,242,21,67,49,5,244,220,163,83,48,168,79,236,169,151,202,66,228,89,2,201,147,245,42,40,107,136,248,152,103,35,56,166,193,192,21,29,9,45,249,74,107,12,118,177,35,226,154,238,134,26,142,169,131,239,14,38,168,48,109,196,157,96,224,217,25,157,3,111,47,65,150,214,161,156,251,20,122,249,143,33,133,226,170,64,201,203,12,49,178,54,62,128,233,176,152,218,186,231,77,176,113,129,53,167,238,105,155,36,44,24,2,172,121,178,164,77,3,166,22,190,93,74,164,248,17,134,59,150,118,184,107,243,199,60,171,62,93,230,106,132,164,183,115,186,186,48,158,76,178,194,208,221,42,103,245,75,193,55,28,242,159,156,210,224,166,228,124,3,141,92,236,217,130,219,212,222,227,56,66,124,101,15,11,181,161,171,159,223,107,174,240,213,184,114,229,136,200,253,242,135,208,84,191,102,24,41,41,207,190,127,0,100,72,96,109,67,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateFiltersRightExprMetaDataByParameterValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("20f8fc0d-b1d4-4243-8026-8687cb68c6db"),
				Name = "UpdateFiltersRightExprMetaDataByParameterValue",
				CreatedInSchemaUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2baf97bb-56d0-4880-915e-e4307f72b40a"),
				Name = "process",
				CreatedInSchemaUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56"),
				ModifiedInSchemaUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Process",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("026f34fc-e2c0-428e-89ad-76b3a28e0f21"),
				Name = "filters",
				CreatedInSchemaUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56"),
				ModifiedInSchemaUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56"),
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
			return new SaveDataSourceFilterUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new SaveDataSourceFilterUserTask(userConnection) {
				SchemaUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56")
			};
		}

		#endregion

	}

	#endregion

	#region Class: SaveDataSourceFilterUserTask

	[DesignModeProperty(Name = "DataSource", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "15dcd24fb49b4c289c88bbb615bcef56", CaptionResourceItem = "Parameters.DataSource.Caption", DescriptionResourceItem = "Parameters.DataSource.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "FilterName", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "15dcd24fb49b4c289c88bbb615bcef56", CaptionResourceItem = "Parameters.FilterName.Caption", DescriptionResourceItem = "Parameters.FilterName.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "StoringEntitySchemaId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "15dcd24fb49b4c289c88bbb615bcef56", CaptionResourceItem = "Parameters.StoringEntitySchemaId.Caption", DescriptionResourceItem = "Parameters.StoringEntitySchemaId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "StoringColumnUId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "15dcd24fb49b4c289c88bbb615bcef56", CaptionResourceItem = "Parameters.StoringColumnUId.Caption", DescriptionResourceItem = "Parameters.StoringColumnUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "StoringPrimaryColumnValue", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "15dcd24fb49b4c289c88bbb615bcef56", CaptionResourceItem = "Parameters.StoringPrimaryColumnValue.Caption", DescriptionResourceItem = "Parameters.StoringPrimaryColumnValue.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class SaveDataSourceFilterUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public SaveDataSourceFilterUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56");
		}

		#endregion

		#region Properties: Public

		public virtual Object DataSource {
			get;
			set;
		}

		public virtual string FilterName {
			get;
			set;
		}

		public virtual Guid StoringEntitySchemaId {
			get;
			set;
		}

		public virtual Guid StoringColumnUId {
			get;
			set;
		}

		public virtual Guid StoringPrimaryColumnValue {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			var dataSource = DataSource as Terrasoft.UI.WebControls.Controls.DataSource;
			if (dataSource == null	|| StoringEntitySchemaId == Guid.Empty || StoringColumnUId == Guid.Empty
					|| StoringPrimaryColumnValue == Guid.Empty) {
				return true;
			}
			var serializedString = GetSerializedFilter(dataSource);
			UpdateData(serializedString);
			return true;
		}

		#endregion

		#region Methods: Public

		public virtual string GetSerializedFilter(Terrasoft.UI.WebControls.Controls.DataSource dataSource) {
			if (string.IsNullOrEmpty(FilterName)) {
				FilterName = "FilterEdit";
			}
			var filter = dataSource.CurrentStructure.Filters.FindByName(FilterName);
			var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, dataSource);
			return Json.Serialize(filter, jsonConverter);
		}

		public virtual void UpdateData(string serializedString) {
			Stream stream = new MemoryStream(UTF8Encoding.UTF8.GetBytes(serializedString));
			stream.Position = 0;
			var manager = UserConnection.GetSchemaManager("EntitySchemaManager") as Terrasoft.Core.Entities.EntitySchemaManager;
			var entitySchema = manager.GetInstanceByUId(StoringEntitySchemaId);
			Entity entity = entitySchema.CreateEntity(UserConnection);
			var valueColumn = entitySchema.Columns.GetByUId(StoringColumnUId);
			if (entity.FetchFromDB(entitySchema.GetPrimaryColumnName(), StoringPrimaryColumnValue)){
				entity.SetStreamValue(valueColumn.ColumnValueName, stream);
				entity.Save();
			}
		}

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
			if (UseFlowEngineMode) {
				if (DataSource != null) {
					if (DataSource.GetType().IsSerializable || DataSource.GetType().GetInterface("ISerializable") != null) {
						writer.WriteSerializableObjectValue("DataSource", DataSource, null);
					}
				}
			}
			if (!HasMapping("FilterName")) {
				writer.WriteValue("FilterName", FilterName, null);
			}
			if (!HasMapping("StoringEntitySchemaId")) {
				writer.WriteValue("StoringEntitySchemaId", StoringEntitySchemaId, Guid.Empty);
			}
			if (!HasMapping("StoringColumnUId")) {
				writer.WriteValue("StoringColumnUId", StoringColumnUId, Guid.Empty);
			}
			if (!HasMapping("StoringPrimaryColumnValue")) {
				writer.WriteValue("StoringPrimaryColumnValue", StoringPrimaryColumnValue, Guid.Empty);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "DataSource":
					if (!UseFlowEngineMode) {
						break;
					}
					DataSource = reader.GetSerializableObjectValue();
				break;
				case "FilterName":
					FilterName = reader.GetStringValue();
				break;
				case "StoringEntitySchemaId":
					StoringEntitySchemaId = reader.GetGuidValue();
				break;
				case "StoringColumnUId":
					StoringColumnUId = reader.GetGuidValue();
				break;
				case "StoringPrimaryColumnValue":
					StoringPrimaryColumnValue = reader.GetGuidValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

