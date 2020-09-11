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

	#region Class: LoadRecentFolderFilterUserTaskSchema

	/// <exclude/>
	public class LoadRecentFolderFilterUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public LoadRecentFolderFilterUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public LoadRecentFolderFilterUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d45a14b3-7763-4005-9423-27a8bcebb6ef");
			RealUId = new Guid("d45a14b3-7763-4005-9423-27a8bcebb6ef");
			Name = "LoadRecentFolderFilterUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,82,193,78,2,49,16,61,187,95,49,246,4,9,233,7,184,33,81,17,205,94,140,97,33,28,8,135,178,59,72,205,110,139,211,46,74,8,255,110,75,23,86,49,40,7,227,94,186,175,51,243,102,222,244,93,179,76,43,99,193,88,146,234,25,230,178,176,72,230,81,148,8,93,96,236,126,135,7,152,161,178,140,197,209,74,16,228,194,138,84,87,148,249,148,187,6,8,3,67,36,18,70,207,45,31,37,124,140,179,158,86,150,116,97,248,225,167,201,143,163,29,91,221,209,81,53,188,188,87,17,185,142,169,165,42,179,21,185,11,66,97,49,76,99,30,72,87,203,214,167,81,219,113,84,35,126,147,231,173,8,220,119,46,219,88,218,197,147,32,199,226,235,67,237,81,125,154,45,176,20,29,56,196,66,101,79,151,75,65,210,104,53,92,47,145,247,95,43,81,116,14,57,140,77,210,181,9,155,235,43,43,237,250,42,28,73,62,229,46,50,50,72,140,53,249,10,223,64,207,94,48,179,147,41,108,192,135,221,210,148,195,82,171,189,4,127,203,147,28,182,237,255,145,252,167,138,3,8,204,163,36,255,65,252,183,65,156,157,106,209,59,207,224,187,52,214,217,117,63,85,81,132,53,253,98,162,218,62,238,84,249,237,218,27,231,139,137,188,129,27,123,30,115,199,145,156,67,235,100,231,203,46,168,170,40,218,209,38,186,56,103,134,1,150,122,133,39,249,156,210,45,68,231,16,249,215,175,85,248,245,16,186,168,2,151,134,49,251,0,217,214,76,117,221,3,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateDataSourceParameter());
		}

		protected virtual ProcessSchemaParameter CreateDataSourceParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("528aaf76-303a-4d30-b473-2c82c80cf63d"),
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

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateUpdateFiltersRightExprMetaDataByParameterValueMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fe773d95-b706-4e5b-953f-104acbbb1aaf"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e5aa9cb0-cbb7-4940-a55b-533c07ad74a9"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateUpdateFiltersRightExprMetaDataByParameterValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a4f65bbc-6d79-4ff1-bc2f-0396d9e80c5e"),
				Name = "UpdateFiltersRightExprMetaDataByParameterValue",
				CreatedInSchemaUId = new Guid("d45a14b3-7763-4005-9423-27a8bcebb6ef"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9550013e-8036-4a99-809f-d36f9b985bb9"),
				Name = "process",
				CreatedInSchemaUId = new Guid("d45a14b3-7763-4005-9423-27a8bcebb6ef"),
				ModifiedInSchemaUId = new Guid("d45a14b3-7763-4005-9423-27a8bcebb6ef"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Process",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("10e24f13-177a-42f8-a633-e55049cace32"),
				Name = "filters",
				CreatedInSchemaUId = new Guid("d45a14b3-7763-4005-9423-27a8bcebb6ef"),
				ModifiedInSchemaUId = new Guid("d45a14b3-7763-4005-9423-27a8bcebb6ef"),
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
			return new LoadRecentFolderFilterUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d45a14b3-7763-4005-9423-27a8bcebb6ef"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new LoadRecentFolderFilterUserTask(userConnection) {
				SchemaUId = new Guid("d45a14b3-7763-4005-9423-27a8bcebb6ef")
			};
		}

		#endregion

	}

	#endregion

	#region Class: LoadRecentFolderFilterUserTask

	[DesignModeProperty(Name = "DataSource", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d45a14b377634005942327a8bcebb6ef", CaptionResourceItem = "Parameters.DataSource.Caption", DescriptionResourceItem = "Parameters.DataSource.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class LoadRecentFolderFilterUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public LoadRecentFolderFilterUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("d45a14b3-7763-4005-9423-27a8bcebb6ef");
		}

		#endregion

		#region Properties: Public

		public virtual Object DataSource {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			const string filtersName = "FilterRecent";
			var dataSource = DataSource as Terrasoft.UI.WebControls.Controls.DataSource;
			
			var filters = dataSource.CurrentStructure.CreateFiltersGroup(filtersName);
			filters.Add(
			    dataSource.CurrentStructure.CreateFilterWithParameters(
			        dataSource.Schema, 
			        FilterComparisonType.Equal,
			        "[SysRecentEntity:EntityId].SysUser",
			        new object[] { UserConnection.CurrentUser.Id }));
			filters.Add(
			    dataSource.CurrentStructure.CreateFilterWithParameters(
			        dataSource.Schema,
			        FilterComparisonType.Equal,
			        "[SysRecentEntity:EntityId].SysEntitySchemaUId",
			        new object[] { dataSource.Schema.UId }));
			
			var existingFilterCollection = dataSource.CurrentStructure.Filters.FindByName(filtersName) as DataSourceFilterCollection;
			if (existingFilterCollection != null)
			{
				dataSource.CurrentStructure.Filters.Remove(existingFilterCollection);
			} 
			dataSource.CurrentStructure.Filters.Add(filters);
			
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
			if (DataSource != null) {
				if (DataSource.GetType().IsSerializable || DataSource.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("DataSource", DataSource, null);
				}
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
			}
		}

		#endregion

	}

	#endregion

}

