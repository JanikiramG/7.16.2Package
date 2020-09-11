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

	#region Class: LoadDataSourceFilterUserTaskSchema

	/// <exclude/>
	public class LoadDataSourceFilterUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public LoadDataSourceFilterUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public LoadDataSourceFilterUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750");
			RealUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750");
			Name = "LoadDataSourceFilterUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,203,10,194,64,12,69,215,157,175,8,174,42,72,127,64,4,193,71,113,39,140,143,117,108,163,14,76,103,36,205,8,245,241,239,182,10,182,212,141,187,36,156,123,47,185,211,193,21,25,114,20,212,62,112,70,48,129,121,187,96,9,27,98,198,210,31,37,217,174,146,61,29,102,222,9,123,91,38,223,161,229,199,202,28,33,238,154,77,192,5,107,225,241,0,45,158,141,59,173,217,20,200,213,204,219,80,184,29,218,240,134,210,96,242,100,81,92,164,234,160,11,39,70,42,157,157,169,192,85,222,195,84,20,181,228,199,109,251,3,253,31,59,188,171,136,73,2,59,16,14,245,35,79,213,244,82,18,27,180,230,70,185,150,198,166,110,39,37,209,189,107,60,28,43,77,50,167,47,190,52,86,136,227,190,124,212,41,186,214,116,3,7,47,150,29,233,201,137,1,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateStoringEntitySchemaIdParameter());
			Parameters.Add(CreateStoringColumnUIdParameter());
			Parameters.Add(CreateStoringPrimaryColumnValueParameter());
			Parameters.Add(CreateDataSourceParameter());
			Parameters.Add(CreateFilterNameParameter());
		}

		protected virtual ProcessSchemaParameter CreateStoringEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("969ada21-9a57-4c35-a41d-47384b8b7f5b"),
				Name = "StoringEntitySchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateStoringColumnUIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("c86e0190-4934-4499-853c-f6929750ea66"),
				Name = "StoringColumnUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateStoringPrimaryColumnValueParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e6aeae01-c36c-43aa-b2f8-80d8807a4e46"),
				Name = "StoringPrimaryColumnValue",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDataSourceParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("8791787f-dd74-4de1-9138-fefe42444826"),
				Name = "DataSource",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = false,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateFilterNameParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("b55b7460-41d6-4772-ad49-870103f0ac3b"),
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

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSetDeserializeFilterMethod());
			Methods.Add(CreateGetSerializedStringMethod());
			Methods.Add(CreateUpdateFiltersRightExprMetaDataByParameterValueMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ec6087c0-37f9-41c5-8749-717bb8f10c29"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f6dba20a-59b9-4168-a1e4-671d494bff01"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("07ddb26a-06ad-40c0-a8af-725ee1b2cdd7"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1f85219b-a4e6-4a69-b4a5-c71a1d99e54f"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("174bc259-3419-4628-9a7d-61913dfb641b"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3f3ef541-93c7-4758-ada4-14d5d27c5bb5"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateSetDeserializeFilterMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("00784f39-9d84-4a79-9b54-fbf6c6765ed7"),
				Name = "SetDeserializeFilter",
				CreatedInSchemaUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0a89db81-68f3-410e-96c8-0c718632ced8"),
				Name = "serializedString",
				CreatedInSchemaUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750"),
				ModifiedInSchemaUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("59926d4c-22e8-41f8-aeff-64f028d673b3"),
				Name = "dataSource",
				CreatedInSchemaUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750"),
				ModifiedInSchemaUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.UI.WebControls.Controls.DataSource",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,221,78,194,48,20,190,222,158,162,114,181,37,100,47,48,49,209,129,9,198,128,145,248,0,117,61,195,146,210,146,182,67,209,236,221,61,91,7,219,192,1,238,102,105,123,206,247,119,90,158,145,192,88,205,229,50,154,154,89,46,196,92,79,214,27,187,11,12,104,78,5,255,6,182,168,142,195,144,252,248,30,239,43,127,228,194,130,158,209,53,184,66,175,217,32,35,50,112,171,9,227,118,16,251,94,225,123,91,170,137,18,204,237,27,44,97,212,210,133,202,117,10,81,146,107,13,210,34,111,158,218,92,67,84,87,225,95,178,135,93,137,217,230,35,212,144,241,161,219,29,36,74,8,72,45,87,50,118,162,91,92,55,35,34,81,185,147,217,236,71,137,0,170,131,208,233,211,128,204,216,92,248,165,210,149,81,50,81,114,11,26,43,81,172,132,207,19,74,243,212,46,10,222,76,169,66,74,167,98,216,242,23,150,188,213,247,162,97,139,70,95,97,201,13,246,96,170,137,224,165,243,84,243,141,69,30,76,0,234,226,34,174,148,100,135,192,90,116,209,24,14,227,154,191,175,144,242,182,63,144,187,160,70,60,158,240,176,107,19,131,40,131,203,254,72,173,20,2,95,168,25,187,142,225,255,63,202,154,33,186,126,152,189,220,123,145,101,194,125,69,173,57,123,173,68,59,14,246,166,47,137,241,50,165,129,166,31,36,104,144,166,22,214,132,203,83,92,119,225,250,117,221,51,22,52,16,149,190,226,156,143,103,181,228,41,21,243,13,104,218,213,125,114,20,159,195,153,154,137,164,239,2,88,11,224,176,119,161,115,166,108,167,11,215,238,253,128,48,80,249,189,230,50,52,206,141,123,126,197,47,156,179,218,205,151,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSerializedStringMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("879391a2-64c6-4b89-84b5-16ff7192f275"),
				Name = "GetSerializedString",
				CreatedInSchemaUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,82,207,107,195,32,20,62,39,127,133,235,73,97,200,238,165,151,102,237,232,161,163,144,101,119,73,95,91,33,234,208,151,66,24,249,223,247,212,108,36,172,16,16,190,247,253,122,154,187,242,204,40,171,174,224,217,134,53,1,124,229,172,133,22,181,179,242,13,176,110,111,96,212,49,51,248,106,103,81,227,176,0,87,130,169,192,62,192,123,21,220,5,101,229,60,200,196,211,16,228,3,193,186,188,83,40,204,6,148,60,117,136,145,7,27,80,217,22,182,67,115,56,243,26,157,215,246,58,247,57,156,197,186,204,192,100,67,6,115,63,89,121,80,8,153,194,151,75,137,28,127,87,93,15,149,235,122,99,255,137,19,26,98,149,69,133,140,55,41,93,95,24,207,34,185,7,108,111,123,239,204,235,150,47,124,72,127,242,218,40,63,100,229,187,50,192,197,51,155,236,22,179,207,88,71,8,246,93,22,125,160,33,227,71,48,206,15,53,210,38,134,133,124,252,22,77,15,147,160,164,227,179,101,228,204,47,6,10,65,150,69,172,59,121,60,109,152,237,187,46,69,21,69,6,229,201,5,29,47,135,18,94,214,17,247,128,189,183,139,87,53,134,254,136,156,218,160,238,242,243,254,21,161,11,70,42,55,165,136,104,50,50,232,2,228,156,201,143,184,180,156,220,153,47,28,18,165,164,111,44,35,143,104,15,73,99,249,3,153,146,171,252,163,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateFiltersRightExprMetaDataByParameterValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2406a762-42f5-4a24-80fa-d8cc9be485e4"),
				Name = "UpdateFiltersRightExprMetaDataByParameterValue",
				CreatedInSchemaUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("95683566-9431-4330-85a7-8adc378a4d6c"),
				Name = "process",
				CreatedInSchemaUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750"),
				ModifiedInSchemaUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Process",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f4a1a089-44fb-4591-804b-2bd32ba1477f"),
				Name = "filters",
				CreatedInSchemaUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750"),
				ModifiedInSchemaUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750"),
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
			return new LoadDataSourceFilterUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a4208915-d4ec-42fb-933c-a23c511fe750"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new LoadDataSourceFilterUserTask(userConnection) {
				SchemaUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750")
			};
		}

		#endregion

	}

	#endregion

	#region Class: LoadDataSourceFilterUserTask

	[DesignModeProperty(Name = "StoringEntitySchemaId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "a4208915d4ec42fb933ca23c511fe750", CaptionResourceItem = "Parameters.StoringEntitySchemaId.Caption", DescriptionResourceItem = "Parameters.StoringEntitySchemaId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "StoringColumnUId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "a4208915d4ec42fb933ca23c511fe750", CaptionResourceItem = "Parameters.StoringColumnUId.Caption", DescriptionResourceItem = "Parameters.StoringColumnUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "StoringPrimaryColumnValue", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "a4208915d4ec42fb933ca23c511fe750", CaptionResourceItem = "Parameters.StoringPrimaryColumnValue.Caption", DescriptionResourceItem = "Parameters.StoringPrimaryColumnValue.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DataSource", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "a4208915d4ec42fb933ca23c511fe750", CaptionResourceItem = "Parameters.DataSource.Caption", DescriptionResourceItem = "Parameters.DataSource.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "FilterName", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "a4208915d4ec42fb933ca23c511fe750", CaptionResourceItem = "Parameters.FilterName.Caption", DescriptionResourceItem = "Parameters.FilterName.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class LoadDataSourceFilterUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public LoadDataSourceFilterUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750");
		}

		#endregion

		#region Properties: Public

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

		public virtual Object DataSource {
			get;
			set;
		}

		public virtual string FilterName {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			var dataSource = DataSource as Terrasoft.UI.WebControls.Controls.DataSource;
			if (dataSource == null || StoringPrimaryColumnValue == Guid.Empty || StoringEntitySchemaId == Guid.Empty 
					|| StoringColumnUId == Guid.Empty || StoringPrimaryColumnValue == Guid.Empty){
				return true;
			}
			var serializedString = GetSerializedString();
			SetDeserializeFilter(serializedString, dataSource);
			return true;
		}

		#endregion

		#region Methods: Public

		public virtual void SetDeserializeFilter(string serializedString, Terrasoft.UI.WebControls.Controls.DataSource dataSource) {
			if (string.IsNullOrEmpty(serializedString)) {
				if (string.IsNullOrEmpty(FilterName)) {
					FilterName = "FilterEdit";
				}
				var oldFilters = dataSource.CurrentStructure.Filters.FindByName(FilterName) as DataSourceFilterCollection;
				if (oldFilters != null) {
					oldFilters.Clear();
				}
				return;
			}
			var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, dataSource){
										PreventRegisteringClientScript = true
									};
			var filters = JsonConvert.DeserializeObject<DataSourceFilterCollection>(
									serializedString, jsonConverter);
			if (filters != null) {
				var existingFilterCollection = dataSource.CurrentStructure.Filters.FindByName(filters.Name) as DataSourceFilterCollection;
				if (existingFilterCollection != null){
					existingFilterCollection.Clear();
					var filtersCollection = filters as DataSourceFilterCollection;
					foreach (var filterItem in filtersCollection) {
						existingFilterCollection.Add(filterItem);
					}
					existingFilterCollection.LogicalOperation = filters.LogicalOperation;
					existingFilterCollection.IsEnabled = filters.IsEnabled;
					existingFilterCollection.IsNot = filters.IsNot;
				}
				else {
					dataSource.CurrentStructure.Filters.Add(filters);
				}
			}
		}

		public virtual string GetSerializedString() {
			var manager = UserConnection.GetSchemaManager("EntitySchemaManager") as Terrasoft.Core.Entities.EntitySchemaManager;
			var entitySchema = manager.GetInstanceByUId(StoringEntitySchemaId);
			Entity entity = entitySchema.CreateEntity(UserConnection);
			var valueColumn = entitySchema.Columns.GetByUId(StoringColumnUId);
			if (entity.FetchFromDB(entitySchema.GetPrimaryColumnName(), StoringPrimaryColumnValue)) {
				using (MemoryStream stream = entity.GetStreamValue(valueColumn.ColumnValueName)){
					if (stream != null) {
						stream.Position = 0;
						return Terrasoft.Common.StreamUtilities.GetStreamContent(stream);
					} else {
						return String.Empty;
					}
				}
			}
			else{
				return String.Empty;
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
			if (!HasMapping("StoringEntitySchemaId")) {
				writer.WriteValue("StoringEntitySchemaId", StoringEntitySchemaId, Guid.Empty);
			}
			if (!HasMapping("StoringColumnUId")) {
				writer.WriteValue("StoringColumnUId", StoringColumnUId, Guid.Empty);
			}
			if (!HasMapping("StoringPrimaryColumnValue")) {
				writer.WriteValue("StoringPrimaryColumnValue", StoringPrimaryColumnValue, Guid.Empty);
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
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "StoringEntitySchemaId":
					StoringEntitySchemaId = reader.GetGuidValue();
				break;
				case "StoringColumnUId":
					StoringColumnUId = reader.GetGuidValue();
				break;
				case "StoringPrimaryColumnValue":
					StoringPrimaryColumnValue = reader.GetGuidValue();
				break;
				case "DataSource":
					if (!UseFlowEngineMode) {
						break;
					}
					DataSource = reader.GetSerializableObjectValue();
				break;
				case "FilterName":
					FilterName = reader.GetStringValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

