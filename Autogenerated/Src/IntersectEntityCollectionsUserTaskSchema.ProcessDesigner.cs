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
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: IntersectEntityCollectionsUserTaskSchema

	/// <exclude/>
	public class IntersectEntityCollectionsUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public IntersectEntityCollectionsUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public IntersectEntityCollectionsUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0b85d913-20ed-46ed-ba83-e131a8f49d63");
			RealUId = new Guid("0b85d913-20ed-46ed-ba83-e131a8f49d63");
			Name = "IntersectEntityCollectionsUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,147,207,110,131,48,12,198,207,240,20,86,79,32,85,188,64,75,181,141,253,61,108,218,134,182,123,74,221,145,41,132,41,113,54,85,107,223,125,129,20,68,41,116,61,69,113,156,239,179,127,113,46,38,124,13,193,141,36,78,155,164,20,2,51,226,165,132,56,6,105,132,128,237,22,250,103,81,154,229,88,176,38,37,132,95,223,83,72,70,73,32,101,112,230,239,252,74,50,101,197,151,224,242,227,148,244,88,206,25,22,15,47,6,213,134,45,5,206,221,237,5,96,79,165,206,128,24,18,133,140,176,222,29,53,58,133,107,70,44,45,141,202,240,150,11,66,165,195,217,144,184,30,41,117,111,226,123,93,151,177,190,166,109,199,67,174,46,219,181,110,239,152,66,66,230,150,248,63,82,190,23,221,33,117,175,94,109,30,145,216,51,163,188,173,198,29,52,97,107,168,73,217,240,222,228,157,9,131,79,172,64,235,230,34,81,114,120,48,243,191,153,130,156,233,60,69,178,89,18,127,224,222,237,230,229,242,211,22,180,8,172,234,186,180,36,178,188,25,170,30,57,224,242,52,203,250,177,247,38,209,229,106,21,28,102,87,125,118,234,10,122,197,135,97,53,28,45,182,17,92,39,96,29,65,58,159,206,43,106,35,232,120,222,107,80,253,112,240,166,81,37,165,148,205,100,140,148,58,0,20,91,144,131,19,95,3,172,126,96,3,209,186,16,227,82,7,120,30,193,90,192,27,238,166,126,17,167,99,43,243,118,22,118,247,99,78,254,0,2,82,11,165,79,4,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateEntityCollectionParameter());
			Parameters.Add(CreateSamplingEntityCollectionParameter());
			Parameters.Add(CreateResultEntityCollectionParameter());
			Parameters.Add(CreateDataSourceFiltersParameter());
			Parameters.Add(CreateSamplingDataSourceFiltersParameter());
			Parameters.Add(CreateColumnMetaPathParameter());
			Parameters.Add(CreateSamplingColumnMetaPathParameter());
		}

		protected virtual ProcessSchemaParameter CreateEntityCollectionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("99a169ba-8d27-4087-bc04-5cbe023b71f6"),
				Name = "EntityCollection",
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSamplingEntityCollectionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("801ca348-ded6-45ac-bca9-8183c3f1ff12"),
				Name = "SamplingEntityCollection",
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType"),
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
				UId = new Guid("01584453-f0c9-4750-99cb-51c66fae2e32"),
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

		protected virtual ProcessSchemaParameter CreateDataSourceFiltersParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("8bdcf618-0a93-45b7-b0aa-f4314d2cf686"),
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

		protected virtual ProcessSchemaParameter CreateSamplingDataSourceFiltersParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("1c138d83-4c70-4577-b998-10b7a6346730"),
				Name = "SamplingDataSourceFilters",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnMetaPathParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("8c17250a-7d3f-4c21-b083-4ead011ee1c1"),
				Name = "ColumnMetaPath",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSamplingColumnMetaPathParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("149389ce-48c1-480e-aaef-0784194d1ffe"),
				Name = "SamplingColumnMetaPath",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
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
			Methods.Add(CreateCreateQueryMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("91baa639-046c-41d6-8719-57e482c676a3"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7a27b3da-d7d3-4869-8191-d1f167d20159"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("704d5ff6-ecc8-4676-9d3d-a4ec94372a90"),
				Name = "Terrasoft.UI.WebControls.Utilities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5bc9c2e5-6a72-414b-b163-53f594cc679a"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("87870061-8e38-4794-b01a-1ba00e836999"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("f8215a95-244f-454b-b31f-c689a99cb261")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7099b992-09e4-4f8c-b3b1-194e6acb2b3f"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("0b85d913-20ed-46ed-ba83-e131a8f49d63"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("704e0c4f-3af5-41ff-a4f7-e2af7c606836"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("0b85d913-20ed-46ed-ba83-e131a8f49d63"),
				ModifiedInSchemaUId = new Guid("0b85d913-20ed-46ed-ba83-e131a8f49d63"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c3aab218-268b-4cfd-be3d-c9b07a02a324"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("0b85d913-20ed-46ed-ba83-e131a8f49d63"),
				ModifiedInSchemaUId = new Guid("0b85d913-20ed-46ed-ba83-e131a8f49d63"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("409e3240-80e8-4c9c-8353-c476a05a82ce"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("0b85d913-20ed-46ed-ba83-e131a8f49d63"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6fa96f42-06a9-4ece-8a89-9f7a94eae163"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("0b85d913-20ed-46ed-ba83-e131a8f49d63"),
				ModifiedInSchemaUId = new Guid("0b85d913-20ed-46ed-ba83-e131a8f49d63"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cab8e58d-0ec1-49ca-b74e-675f0c6346d0"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("0b85d913-20ed-46ed-ba83-e131a8f49d63"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("badc62fe-2d83-4f78-becd-e7bd87ba97df"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("0b85d913-20ed-46ed-ba83-e131a8f49d63"),
				ModifiedInSchemaUId = new Guid("0b85d913-20ed-46ed-ba83-e131a8f49d63"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,115,78,204,75,78,205,113,173,72,77,46,45,201,204,75,215,40,72,44,74,204,77,45,73,45,42,214,180,6,0,4,172,171,3,33,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateQueryMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4490efe4-c7c3-4968-bd8e-93fc1b6ada73"),
				Name = "CreateQuery",
				CreatedInSchemaUId = new Guid("0b85d913-20ed-46ed-ba83-e131a8f49d63"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "IQueryable<Entity>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ab74d65c-fa86-432d-b16a-0b837b38b043"),
				Name = "entityCollection",
				CreatedInSchemaUId = new Guid("0b85d913-20ed-46ed-ba83-e131a8f49d63"),
				ModifiedInSchemaUId = new Guid("0b85d913-20ed-46ed-ba83-e131a8f49d63"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntityCollection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f3fabb00-9a83-44b3-9ac5-bb415b46e073"),
				Name = "serializedDataSourceFilters",
				CreatedInSchemaUId = new Guid("0b85d913-20ed-46ed-ba83-e131a8f49d63"),
				ModifiedInSchemaUId = new Guid("0b85d913-20ed-46ed-ba83-e131a8f49d63"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,205,110,194,64,12,132,207,217,167,112,111,27,41,202,11,68,189,0,173,84,169,234,143,128,7,88,5,83,44,204,110,107,123,65,1,245,221,27,90,170,136,112,29,205,124,51,246,44,88,152,167,44,45,62,18,27,202,52,49,99,107,148,34,172,127,5,133,123,136,153,185,113,180,6,127,167,38,20,63,234,39,125,233,181,87,121,216,125,90,231,21,133,2,211,17,87,179,17,78,203,18,78,174,24,80,111,146,90,84,93,246,145,69,208,237,210,136,201,8,181,158,166,184,71,177,69,186,56,198,164,97,152,119,69,113,206,247,137,248,167,84,128,209,200,186,193,83,207,219,13,238,66,5,182,33,173,224,118,86,227,190,221,62,8,48,197,175,75,117,146,243,169,120,184,113,63,15,30,20,127,93,221,131,4,45,75,188,38,213,147,76,188,122,207,40,157,31,111,171,254,63,91,54,63,69,192,61,231,126,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new IntersectEntityCollectionsUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0b85d913-20ed-46ed-ba83-e131a8f49d63"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new IntersectEntityCollectionsUserTask(userConnection) {
				SchemaUId = new Guid("0b85d913-20ed-46ed-ba83-e131a8f49d63")
			};
		}

		#endregion

	}

	#endregion

	#region Class: IntersectEntityCollectionsUserTask

	[DesignModeProperty(Name = "EntityCollection", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "0b85d91320ed46edba83e131a8f49d63", CaptionResourceItem = "Parameters.EntityCollection.Caption", DescriptionResourceItem = "Parameters.EntityCollection.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SamplingEntityCollection", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "0b85d91320ed46edba83e131a8f49d63", CaptionResourceItem = "Parameters.SamplingEntityCollection.Caption", DescriptionResourceItem = "Parameters.SamplingEntityCollection.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultEntityCollection", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "0b85d91320ed46edba83e131a8f49d63", CaptionResourceItem = "Parameters.ResultEntityCollection.Caption", DescriptionResourceItem = "Parameters.ResultEntityCollection.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DataSourceFilters", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "0b85d91320ed46edba83e131a8f49d63", CaptionResourceItem = "Parameters.DataSourceFilters.Caption", DescriptionResourceItem = "Parameters.DataSourceFilters.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SamplingDataSourceFilters", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "0b85d91320ed46edba83e131a8f49d63", CaptionResourceItem = "Parameters.SamplingDataSourceFilters.Caption", DescriptionResourceItem = "Parameters.SamplingDataSourceFilters.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ColumnMetaPath", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "0b85d91320ed46edba83e131a8f49d63", CaptionResourceItem = "Parameters.ColumnMetaPath.Caption", DescriptionResourceItem = "Parameters.ColumnMetaPath.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SamplingColumnMetaPath", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "0b85d91320ed46edba83e131a8f49d63", CaptionResourceItem = "Parameters.SamplingColumnMetaPath.Caption", DescriptionResourceItem = "Parameters.SamplingColumnMetaPath.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class IntersectEntityCollectionsUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public IntersectEntityCollectionsUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("0b85d913-20ed-46ed-ba83-e131a8f49d63");
		}

		#endregion

		#region Properties: Public

		public virtual EntityCollection EntityCollection {
			get;
			set;
		}

		public virtual EntityCollection SamplingEntityCollection {
			get;
			set;
		}

		public virtual EntityCollection ResultEntityCollection {
			get;
			set;
		}

		public virtual string DataSourceFilters {
			get;
			set;
		}

		public virtual string SamplingDataSourceFilters {
			get;
			set;
		}

		public virtual string ColumnMetaPath {
			get;
			set;
		}

		public virtual string SamplingColumnMetaPath {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			if (EntityCollection == null || EntityCollection.Schema == null) {
				return true;
			}
			if (SamplingEntityCollection == null || SamplingEntityCollection.Schema == null) {
				return true;
			}
			IQueryable<Entity> entityCollectionQuery = CreateQuery(EntityCollection, DataSourceFilters);
			IQueryable<Entity> samplingEntityCollectionQuery =
				CreateQuery(SamplingEntityCollection, SamplingDataSourceFilters);
			EntitySchemaColumn column = SamplingEntityCollection.Schema
				.GetSchemaColumnByMetaPath(SamplingColumnMetaPath);
			string columnValueName = column.ColumnValueName;
			var hashSet = new HashSet<object>();
			foreach (Entity samplingEntity in samplingEntityCollectionQuery) {
				hashSet.Add(samplingEntity.GetColumnValue(columnValueName));
			}
			column = EntityCollection.Schema.GetSchemaColumnByMetaPath(ColumnMetaPath);
			columnValueName = column.ColumnValueName;
			ResultEntityCollection = new EntityCollection(UserConnection, EntityCollection.Schema);
			foreach (Entity entity in entityCollectionQuery) {
				if (hashSet.Contains(entity.GetColumnValue(columnValueName))) {
					ResultEntityCollection.Add(entity);
				}
			}
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

		public virtual IQueryable<Entity> CreateQuery(EntityCollection entityCollection, string serializedDataSourceFilters) {
			DataSourceFilterCollection filters = null;
			if (!string.IsNullOrEmpty(serializedDataSourceFilters)) {
				filters = ProcessUserTaskUtilities.ConvertToProcessDataSourceFilterCollection(
					UserConnection, entityCollection.Schema, this, DataSourceFilters);
			}
			var linqConvertor = new DataSourceFilterLinqConverter(UserConnection);
			return linqConvertor.BuildQuery(entityCollection, filters);
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
			if (!HasMapping("SamplingDataSourceFilters")) {
				writer.WriteValue("SamplingDataSourceFilters", SamplingDataSourceFilters, null);
			}
			if (!HasMapping("ColumnMetaPath")) {
				writer.WriteValue("ColumnMetaPath", ColumnMetaPath, null);
			}
			if (!HasMapping("SamplingColumnMetaPath")) {
				writer.WriteValue("SamplingColumnMetaPath", SamplingColumnMetaPath, null);
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
				case "SamplingDataSourceFilters":
					SamplingDataSourceFilters = reader.GetStringValue();
				break;
				case "ColumnMetaPath":
					ColumnMetaPath = reader.GetStringValue();
				break;
				case "SamplingColumnMetaPath":
					SamplingColumnMetaPath = reader.GetStringValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

