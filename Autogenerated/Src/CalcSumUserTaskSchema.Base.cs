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

	#region Class: CalcSumUserTaskSchema

	/// <exclude/>
	public class CalcSumUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public CalcSumUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public CalcSumUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48");
			RealUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48");
			Name = "CalcSumUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,83,203,106,195,48,16,60,215,95,33,114,146,32,136,222,77,161,212,36,197,135,134,80,55,237,89,181,151,196,32,203,169,30,109,243,247,213,139,88,177,93,104,160,39,161,217,221,209,204,176,186,95,124,50,137,64,232,86,159,170,250,0,29,123,98,130,237,65,162,59,180,83,32,139,94,8,168,117,219,11,186,154,54,229,153,155,62,50,105,9,66,193,142,205,144,209,71,208,165,80,154,137,26,30,78,187,178,193,219,100,198,222,73,158,41,45,91,177,191,32,219,176,14,44,97,10,81,135,77,159,45,122,110,58,161,198,205,17,30,145,7,244,25,148,225,122,230,137,56,68,215,173,104,82,177,233,152,147,28,165,120,45,245,161,229,205,117,9,20,195,200,69,0,9,85,20,151,32,137,253,4,29,220,167,173,99,243,190,22,192,41,241,212,116,49,180,39,110,103,131,228,204,45,200,95,72,183,51,115,158,61,64,175,140,27,136,177,86,192,237,226,33,229,143,202,116,150,90,192,23,10,48,190,220,77,66,179,155,192,128,215,70,212,212,182,227,145,93,226,122,214,178,143,133,33,96,135,191,29,64,2,254,205,20,161,165,90,125,24,198,113,168,81,235,194,194,26,228,172,31,111,130,190,244,149,143,10,19,66,50,166,162,238,60,219,29,27,166,1,25,127,132,241,232,44,84,70,206,150,147,15,225,244,86,160,241,252,46,47,145,15,160,84,27,195,207,122,43,243,30,99,59,167,73,150,40,22,237,91,74,227,91,66,134,32,210,45,218,202,182,99,242,20,155,255,37,14,100,227,8,102,243,44,205,129,174,190,161,54,54,2,251,25,36,104,35,5,210,210,64,190,248,1,224,52,65,172,165,4,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateParentSchemaUIdParameter());
			Parameters.Add(CreateChildSchemaUIdParameter());
			Parameters.Add(CreateParentColumnResultUIdParameter());
			Parameters.Add(CreateParentColumnRelationUIdParameter());
			Parameters.Add(CreateChildColumnUIdParameter());
			Parameters.Add(CreateParentColumnRelationValueParameter());
		}

		protected virtual ProcessSchemaParameter CreateParentSchemaUIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("2e9e5fba-1871-45fb-b10e-ce927c6d8772"),
				Name = "ParentSchemaUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateChildSchemaUIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("2d6a3a13-40e0-47b5-8f73-c0801db217d4"),
				Name = "ChildSchemaUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateParentColumnResultUIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("d63394ed-0d41-4a13-aeff-7b66a50a266b"),
				Name = "ParentColumnResultUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateParentColumnRelationUIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("2658efea-9895-421c-aa24-d7d5ceb1ca9d"),
				Name = "ParentColumnRelationUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateChildColumnUIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("3492f782-7f1d-4ae3-b433-81caa328a2ec"),
				Name = "ChildColumnUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateParentColumnRelationValueParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e6e9d146-ade5-4f23-bbd7-ea507beb10bf"),
				Name = "ParentColumnRelationValue",
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
			Methods.Add(CreateUpdateFiltersRightExprMetaDataByParameterValueMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("dafc4aa3-c84c-42f1-9dc6-602475de6235"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateUpdateFiltersRightExprMetaDataByParameterValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("dfa3edbb-c1cb-4787-8714-087a729f3b8f"),
				Name = "UpdateFiltersRightExprMetaDataByParameterValue",
				CreatedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("36dc3bc3-3cd6-438c-a561-ef62664b3204"),
				Name = "process",
				CreatedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				ModifiedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Process",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b007da73-b34b-4ba5-b62f-330dab09e858"),
				Name = "filters",
				CreatedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
				ModifiedInSchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48"),
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
			return new CalcSumUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("25e62f47-5459-470f-9aca-b6410c643c48"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new CalcSumUserTask(userConnection) {
				SchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48")
			};
		}

		#endregion

	}

	#endregion

	#region Class: CalcSumUserTask

	[DesignModeProperty(Name = "ParentSchemaUId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "25e62f475459470f9acab6410c643c48", CaptionResourceItem = "Parameters.ParentSchemaUId.Caption", DescriptionResourceItem = "Parameters.ParentSchemaUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ChildSchemaUId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "25e62f475459470f9acab6410c643c48", CaptionResourceItem = "Parameters.ChildSchemaUId.Caption", DescriptionResourceItem = "Parameters.ChildSchemaUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ParentColumnResultUId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "25e62f475459470f9acab6410c643c48", CaptionResourceItem = "Parameters.ParentColumnResultUId.Caption", DescriptionResourceItem = "Parameters.ParentColumnResultUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ParentColumnRelationUId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "25e62f475459470f9acab6410c643c48", CaptionResourceItem = "Parameters.ParentColumnRelationUId.Caption", DescriptionResourceItem = "Parameters.ParentColumnRelationUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ChildColumnUId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "25e62f475459470f9acab6410c643c48", CaptionResourceItem = "Parameters.ChildColumnUId.Caption", DescriptionResourceItem = "Parameters.ChildColumnUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ParentColumnRelationValue", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "25e62f475459470f9acab6410c643c48", CaptionResourceItem = "Parameters.ParentColumnRelationValue.Caption", DescriptionResourceItem = "Parameters.ParentColumnRelationValue.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class CalcSumUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public CalcSumUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("25e62f47-5459-470f-9aca-b6410c643c48");
		}

		#endregion

		#region Properties: Public

		public virtual Guid ParentSchemaUId {
			get;
			set;
		}

		public virtual Guid ChildSchemaUId {
			get;
			set;
		}

		public virtual Guid ParentColumnResultUId {
			get;
			set;
		}

		public virtual Guid ParentColumnRelationUId {
			get;
			set;
		}

		public virtual Guid ChildColumnUId {
			get;
			set;
		}

		public virtual Guid ParentColumnRelationValue {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var parentSchema = entitySchemaManager.GetInstanceByUId(ParentSchemaUId);
			string parentSchemaName = parentSchema.Name;
			var parentSchemaColumns = parentSchema.Columns;
			string parentColumnResultName = parentSchemaColumns.FindByUId(ParentColumnResultUId).Name;
			
			var childSchema = entitySchemaManager.GetInstanceByUId(ChildSchemaUId);
			string childSchemaName = childSchema.Name;
			var childSchemaColumns = childSchema.Columns;
			string childColumnName = childSchemaColumns.FindByUId(ChildColumnUId).Name;
			string parentColumnRelationName = childSchemaColumns.FindByUId(ParentColumnRelationUId).ColumnValueName;
			
			Select selectSum = new Select(UserConnection).
				Column(Func.Sum(childColumnName)).
				From(childSchemaName).
				Where(parentColumnRelationName).IsEqual(Column.Parameter(ParentColumnRelationValue.ToString()))
			as Select;
			Update updateParent = new Update(UserConnection, parentSchemaName).
				Set(parentColumnResultName, Func.IsNull(Column.SubSelect(selectSum), Column.Const(0))).
				Where(childSchema.PrimaryColumn.Name).IsEqual(Column.Parameter(ParentColumnRelationValue.ToString())) as Update;
			updateParent.Execute();
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
			if (!HasMapping("ParentSchemaUId")) {
				writer.WriteValue("ParentSchemaUId", ParentSchemaUId, Guid.Empty);
			}
			if (!HasMapping("ChildSchemaUId")) {
				writer.WriteValue("ChildSchemaUId", ChildSchemaUId, Guid.Empty);
			}
			if (!HasMapping("ParentColumnResultUId")) {
				writer.WriteValue("ParentColumnResultUId", ParentColumnResultUId, Guid.Empty);
			}
			if (!HasMapping("ParentColumnRelationUId")) {
				writer.WriteValue("ParentColumnRelationUId", ParentColumnRelationUId, Guid.Empty);
			}
			if (!HasMapping("ChildColumnUId")) {
				writer.WriteValue("ChildColumnUId", ChildColumnUId, Guid.Empty);
			}
			if (!HasMapping("ParentColumnRelationValue")) {
				writer.WriteValue("ParentColumnRelationValue", ParentColumnRelationValue, Guid.Empty);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "ParentSchemaUId":
					ParentSchemaUId = reader.GetGuidValue();
				break;
				case "ChildSchemaUId":
					ChildSchemaUId = reader.GetGuidValue();
				break;
				case "ParentColumnResultUId":
					ParentColumnResultUId = reader.GetGuidValue();
				break;
				case "ParentColumnRelationUId":
					ParentColumnRelationUId = reader.GetGuidValue();
				break;
				case "ChildColumnUId":
					ChildColumnUId = reader.GetGuidValue();
				break;
				case "ParentColumnRelationValue":
					ParentColumnRelationValue = reader.GetGuidValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

