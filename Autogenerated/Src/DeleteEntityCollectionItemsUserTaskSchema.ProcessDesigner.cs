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

	#region Class: DeleteEntityCollectionItemsUserTaskSchema

	/// <exclude/>
	public class DeleteEntityCollectionItemsUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public DeleteEntityCollectionItemsUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public DeleteEntityCollectionItemsUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3ca906cd-b2f9-486b-a4e0-3893d418422e");
			RealUId = new Guid("3ca906cd-b2f9-486b-a4e0-3893d418422e");
			Name = "DeleteEntityCollectionItemsUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,203,110,194,48,16,60,199,95,97,113,10,82,20,245,78,83,149,82,42,33,161,210,242,248,0,55,217,130,85,99,211,245,154,42,42,252,123,157,4,169,73,12,71,123,119,102,103,102,247,113,32,63,121,60,213,36,169,156,24,165,32,39,105,52,207,50,174,157,82,252,116,226,253,90,58,49,78,83,213,113,55,228,191,44,66,32,135,154,19,58,24,177,51,107,218,87,249,14,246,130,67,251,145,133,84,77,101,196,42,13,150,80,234,109,58,179,175,126,240,2,167,251,3,149,241,179,32,177,50,14,115,120,145,138,0,237,176,146,212,165,109,164,94,211,210,71,183,12,22,125,98,158,177,232,13,77,14,214,110,44,224,90,216,175,13,73,37,73,130,245,150,245,17,144,214,230,210,113,155,56,102,81,84,225,61,66,55,63,73,71,110,194,105,39,109,194,67,99,85,10,241,21,89,255,155,8,138,237,85,132,238,143,2,67,136,143,215,120,4,215,240,19,104,104,185,8,112,117,188,115,179,149,185,80,139,3,160,104,206,132,247,191,86,126,139,57,165,99,93,36,44,154,217,169,22,31,10,10,223,88,169,138,34,118,30,213,186,148,212,223,151,80,1,111,200,153,183,123,226,110,168,62,173,217,187,3,44,43,250,251,230,174,30,56,130,117,138,234,127,207,217,153,145,62,57,169,138,186,20,92,123,114,35,38,63,36,184,216,37,236,205,17,150,66,111,33,110,141,75,215,102,140,40,202,120,232,65,237,61,12,254,0,66,13,88,175,97,3,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateEntityCollectionParameter());
			Parameters.Add(CreateDataSourceFiltersParameter());
		}

		protected virtual ProcessSchemaParameter CreateEntityCollectionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("7fa363f5-8838-4142-933f-d71a1552b536"),
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

		protected virtual ProcessSchemaParameter CreateDataSourceFiltersParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("62908afa-d342-435a-bf0d-665970f4470c"),
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

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetResultParameterAllValuesMethod());
			Methods.Add(CreateCompleteExecutingMethod());
			Methods.Add(CreateCancelExecutingMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("acb6471c-1fde-4f9e-9e3c-259387fbebd6"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8c88c749-b781-4d92-95c9-ff0b1aacd2a9"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4bea905e-2c1f-4088-bb1e-74ca5a80a432"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a333495a-47ba-49a1-a674-b18c0026210a"),
				Name = "Terrasoft.UI.WebControls.Utilities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7261f9bc-09ba-4cfc-a186-ea73a97c4e82"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c7da6a86-3cec-414e-ae5d-1c09d11f2503"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("f8215a95-244f-454b-b31f-c689a99cb261")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f0aa4ac0-9103-431e-9fd0-a655acbebaf2"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("3ca906cd-b2f9-486b-a4e0-3893d418422e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bd6cbaba-4b36-4b0a-9ba6-3332e7c0f133"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("3ca906cd-b2f9-486b-a4e0-3893d418422e"),
				ModifiedInSchemaUId = new Guid("3ca906cd-b2f9-486b-a4e0-3893d418422e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9f1febda-efb8-4b28-8aa1-ed04744940b1"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("3ca906cd-b2f9-486b-a4e0-3893d418422e"),
				ModifiedInSchemaUId = new Guid("3ca906cd-b2f9-486b-a4e0-3893d418422e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bc5219af-ffb8-48c7-921e-6755cfd3e1b7"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("3ca906cd-b2f9-486b-a4e0-3893d418422e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("da88471b-a936-4d55-8e28-2277049b0eb4"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("3ca906cd-b2f9-486b-a4e0-3893d418422e"),
				ModifiedInSchemaUId = new Guid("3ca906cd-b2f9-486b-a4e0-3893d418422e"),
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
				UId = new Guid("9e2ef91c-1935-4b27-b5fe-d2e232bd0e2b"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("3ca906cd-b2f9-486b-a4e0-3893d418422e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4950a147-e678-42cb-b285-28392a424304"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("3ca906cd-b2f9-486b-a4e0-3893d418422e"),
				ModifiedInSchemaUId = new Guid("3ca906cd-b2f9-486b-a4e0-3893d418422e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,115,78,204,75,78,205,113,173,72,77,46,45,201,204,75,215,40,72,44,74,204,77,45,73,45,42,214,180,6,0,4,172,171,3,33,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DeleteEntityCollectionItemsUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3ca906cd-b2f9-486b-a4e0-3893d418422e"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new DeleteEntityCollectionItemsUserTask(userConnection) {
				SchemaUId = new Guid("3ca906cd-b2f9-486b-a4e0-3893d418422e")
			};
		}

		#endregion

	}

	#endregion

	#region Class: DeleteEntityCollectionItemsUserTask

	[DesignModeProperty(Name = "EntityCollection", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "3ca906cdb2f9486ba4e03893d418422e", CaptionResourceItem = "Parameters.EntityCollection.Caption", DescriptionResourceItem = "Parameters.EntityCollection.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DataSourceFilters", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "3ca906cdb2f9486ba4e03893d418422e", CaptionResourceItem = "Parameters.DataSourceFilters.Caption", DescriptionResourceItem = "Parameters.DataSourceFilters.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class DeleteEntityCollectionItemsUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public DeleteEntityCollectionItemsUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("3ca906cd-b2f9-486b-a4e0-3893d418422e");
		}

		#endregion

		#region Properties: Public

		public virtual EntityCollection EntityCollection {
			get;
			set;
		}

		public virtual string DataSourceFilters {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			if (EntityCollection == null || EntityCollection.Count == 0) {
				return true;
			}
			EntitySchema entitySchema = EntityCollection.Schema;
			if (string.IsNullOrEmpty(DataSourceFilters) || entitySchema == null) {
				return true;
			}
			DataSourceFilterCollection dataSourceFilters =
				ProcessUserTaskUtilities.ConvertToProcessDataSourceFilterCollection(
					UserConnection, entitySchema, this, DataSourceFilters);
			if(dataSourceFilters == null || dataSourceFilters.Count == 0){
				return true;
			}
			var dataSourceFiltersIsNot = new DataSourceFilterCollection(dataSourceFilters) {
				LogicalOperation = LogicalOperationStrict.And,
				IsEnabled = true		
			};
			var linqConverter = new DataSourceFilterLinqConverter(UserConnection);
			IQueryable<Entity> resultQuery = linqConverter.BuildQuery(EntityCollection, dataSourceFiltersIsNot);
			EntityCollection.RemoveRange(resultQuery.ToArray());
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
			}
		}

		#endregion

	}

	#endregion

}

