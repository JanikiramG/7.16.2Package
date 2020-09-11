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

	#region Class: SyncronizeRecentEntityUserTaskSchema

	/// <exclude/>
	public class SyncronizeRecentEntityUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public SyncronizeRecentEntityUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public SyncronizeRecentEntityUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6");
			RealUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6");
			Name = "SyncronizeRecentEntityUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,77,143,155,48,16,61,227,95,97,113,50,210,202,82,207,40,82,91,66,43,46,105,181,108,212,67,213,131,133,39,187,72,96,168,63,186,139,186,251,223,59,198,176,33,36,217,149,106,33,17,198,243,230,227,189,153,124,140,235,3,101,185,178,181,29,10,73,55,27,250,213,213,146,231,109,111,7,250,252,76,203,193,132,203,178,122,128,86,172,93,18,250,151,68,26,172,211,138,90,237,32,37,47,132,252,17,154,154,193,236,13,104,239,79,253,143,172,83,10,42,91,119,138,103,78,107,80,214,91,121,33,83,66,156,169,213,61,101,30,6,79,80,57,219,233,115,84,174,140,211,176,253,124,52,177,36,33,152,125,204,6,13,218,16,164,224,145,150,227,7,59,197,39,252,174,235,217,135,132,68,120,40,30,158,117,141,107,21,139,227,66,198,241,194,254,69,119,45,90,177,241,91,168,176,206,208,254,137,203,143,7,208,128,62,51,109,120,201,11,147,255,118,162,97,33,44,255,46,180,104,193,130,126,229,54,89,4,248,164,100,72,17,56,122,19,255,202,228,20,64,152,169,67,100,110,108,190,246,28,75,56,8,215,88,230,165,73,82,18,77,87,102,135,132,108,38,105,162,5,209,218,131,2,109,60,31,73,135,91,16,18,243,205,18,248,116,72,111,228,231,67,75,238,111,217,88,130,55,70,99,82,207,182,79,136,247,63,3,143,191,144,230,210,106,76,131,190,233,232,56,149,112,16,141,241,53,68,47,4,31,130,97,217,120,53,101,41,20,246,104,105,29,94,33,116,176,157,9,89,40,219,93,23,8,15,47,193,158,168,115,67,223,83,101,141,202,68,239,147,189,1,221,214,166,111,196,176,67,227,89,140,213,210,236,175,212,112,182,91,151,2,205,19,114,1,191,158,140,35,14,205,242,219,229,234,49,164,133,150,111,133,133,187,186,5,190,235,30,131,82,129,250,121,24,142,99,144,122,189,34,64,245,130,82,251,94,34,150,186,240,10,74,5,219,74,169,27,122,93,36,58,157,255,172,119,21,100,222,199,119,54,9,55,35,161,184,62,161,90,223,115,104,226,74,207,56,165,89,3,66,231,79,21,24,83,96,21,102,65,57,110,223,242,127,47,254,7,240,81,106,113,73,5,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateSysEntitySchemaIdParameter());
			Parameters.Add(CreateEntityIdParameter());
			Parameters.Add(CreateEntityDisplayNameParameter());
		}

		protected virtual ProcessSchemaParameter CreateSysEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("d2f0cd11-080c-4e01-969e-f62c82d56652"),
				Name = "SysEntitySchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("3c74255f-0eed-4998-ad37-266b113d85b0"),
				Name = "EntityId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityDisplayNameParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("9d96a026-1189-4b38-ad95-c9bb4c3c0e1f"),
				Name = "EntityDisplayName",
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
			Methods.Add(CreateClearExcessItemsMethod());
			Methods.Add(CreateUpdateFiltersRightExprMetaDataByParameterValueMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("80829ffd-4fb2-4a1e-bf1d-9577d457d9b2"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateClearExcessItemsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("20af186b-f31d-4a85-86c3-425a7080c91c"),
				Name = "ClearExcessItems",
				CreatedInSchemaUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("aed0125d-fc6e-4606-a7a7-3fccd7134cf1"),
				Name = "SysUserId",
				CreatedInSchemaUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6"),
				ModifiedInSchemaUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,146,65,75,195,64,16,133,207,45,244,63,44,57,237,130,44,162,71,233,193,166,81,114,177,98,90,61,47,201,180,13,36,187,58,59,91,45,210,255,238,36,177,53,86,81,4,47,11,179,243,230,125,111,96,54,6,5,66,14,150,18,75,37,109,99,23,44,137,177,136,157,221,0,146,158,187,212,210,249,153,156,3,162,241,110,73,58,118,8,252,216,101,185,10,104,168,116,86,103,91,159,1,81,105,87,94,95,3,221,155,42,128,92,120,64,150,89,200,27,205,137,136,238,142,49,145,82,23,163,97,185,20,242,155,4,99,113,170,196,235,104,56,64,160,128,150,133,187,209,48,120,102,8,185,225,208,240,2,121,32,135,156,245,51,73,39,214,7,132,233,228,227,75,170,206,170,153,43,160,2,2,158,178,240,44,166,109,113,20,85,233,43,116,181,140,120,171,126,228,72,177,195,64,63,172,1,65,198,174,10,53,47,238,2,230,208,21,50,74,11,222,72,223,56,146,74,167,86,54,242,65,67,201,152,146,211,23,202,220,61,126,93,188,133,48,166,239,249,254,245,67,170,67,174,166,221,112,154,49,157,250,228,41,152,106,31,246,214,160,169,121,93,148,7,145,218,79,95,218,162,157,237,76,179,124,13,181,89,252,106,210,87,247,204,102,88,0,78,182,83,240,185,140,24,84,204,108,212,53,15,156,63,103,252,167,132,124,70,236,214,221,128,78,218,19,2,185,63,165,166,187,123,3,148,39,108,123,17,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateFiltersRightExprMetaDataByParameterValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a09462b6-ab80-4579-b295-56eab7ed1ba2"),
				Name = "UpdateFiltersRightExprMetaDataByParameterValue",
				CreatedInSchemaUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fba7557a-b56c-4a4a-98b3-e14037611bcf"),
				Name = "process",
				CreatedInSchemaUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6"),
				ModifiedInSchemaUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Process",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8db91cf2-9605-4cc4-8d0c-ceb350561c75"),
				Name = "filters",
				CreatedInSchemaUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6"),
				ModifiedInSchemaUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceFilterCollection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,147,95,75,195,48,20,197,159,39,248,29,226,203,72,65,194,244,181,84,112,245,207,211,96,108,234,139,248,16,187,219,53,208,37,37,185,25,14,217,119,55,105,179,150,117,58,167,15,45,109,239,185,191,115,114,185,205,149,6,158,21,132,174,185,38,185,40,17,52,17,50,60,153,136,124,158,159,13,68,78,232,174,100,200,29,71,62,87,86,103,240,80,127,75,85,89,66,134,66,201,70,61,120,174,22,28,67,209,204,196,178,192,251,143,74,79,0,185,111,29,111,166,92,243,21,184,226,11,47,45,208,74,171,12,140,185,36,244,8,185,177,143,98,207,207,148,68,33,45,248,151,237,192,221,124,244,69,219,27,146,38,135,188,64,137,195,145,250,45,172,205,234,226,56,83,146,36,68,218,178,12,199,218,179,61,17,193,158,54,21,120,78,63,74,39,241,10,150,90,131,106,21,140,78,132,254,198,108,199,92,15,237,164,180,109,139,97,169,178,18,125,242,235,144,170,158,114,213,10,156,255,31,112,113,75,112,239,124,202,177,112,253,29,236,245,234,141,213,203,208,232,190,41,120,121,179,39,236,17,112,127,131,198,155,73,128,82,106,80,11,185,140,118,46,81,31,200,102,176,82,107,184,69,58,106,106,219,31,135,51,183,239,97,135,201,69,179,8,100,56,60,60,116,39,11,51,187,33,163,221,200,254,251,39,28,49,233,82,187,107,251,5,106,6,88,161,190,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SyncronizeRecentEntityUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new SyncronizeRecentEntityUserTask(userConnection) {
				SchemaUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6")
			};
		}

		#endregion

	}

	#endregion

	#region Class: SyncronizeRecentEntityUserTask

	[DesignModeProperty(Name = "SysEntitySchemaId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "788daa7e2cdc4ddfb73a7b2f38c98ba6", CaptionResourceItem = "Parameters.SysEntitySchemaId.Caption", DescriptionResourceItem = "Parameters.SysEntitySchemaId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "EntityId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "788daa7e2cdc4ddfb73a7b2f38c98ba6", CaptionResourceItem = "Parameters.EntityId.Caption", DescriptionResourceItem = "Parameters.EntityId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "EntityDisplayName", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "788daa7e2cdc4ddfb73a7b2f38c98ba6", CaptionResourceItem = "Parameters.EntityDisplayName.Caption", DescriptionResourceItem = "Parameters.EntityDisplayName.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class SyncronizeRecentEntityUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public SyncronizeRecentEntityUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6");
		}

		#endregion

		#region Properties: Public

		public virtual Guid SysEntitySchemaId {
			get;
			set;
		}

		public virtual Guid EntityId {
			get;
			set;
		}

		public virtual string EntityDisplayName {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			if (EntityId == Guid.Empty || SysEntitySchemaId == Guid.Empty) {
				return true;
			}
			
			var sysUserId = UserConnection.CurrentUser.Id;
			
			using (var executor = UserConnection.EnsureDBConnection())
			{
				var select = new Select(UserConnection).Top(1)
							    .Column("Id")
							    .From("SysRecentEntity")
							    .Where("EntityId").IsEqual(Column.Parameter(EntityId))
							    .And("SysUserId").IsEqual(Column.Parameter(sysUserId))
							as Select;
			
				var id = default(Guid);
				
				var isNew = true;
				using (var rd = select.ExecuteReader(executor))
				{
					if (rd.Read())
					{
						id = new Guid(rd["Id"].ToString());
						isNew = false;
					}
				}
			
				if(isNew)
				{
					Insert insert = new Insert(UserConnection).Into("SysRecentEntity")
										.Set("EntityId", Column.Parameter(EntityId))
										.Set("EntityCaption", Column.Parameter(EntityDisplayName))
										.Set("SysEntitySchemaUId", Column.Parameter(SysEntitySchemaId))
										.Set("SysUserId", Column.Parameter(sysUserId))
										.Set("UsedOn", Column.Parameter(System.DateTime.Now));
					insert.Execute(executor);
				}
				else
				{
					Update update = new Update(UserConnection, "SysRecentEntity")
								        .Set("UsedOn", Column.Parameter(System.DateTime.Now))
								        .Where("Id").IsEqual(Column.Parameter(id)) as Update;
					update.Execute(executor);
				}
			}
			
			ClearExcessItems(sysUserId);
			
			return true;
		}

		#endregion

		#region Methods: Public

		public virtual void ClearExcessItems(Guid SysUserId) {
			var recentEntityCount = Convert.ToInt32(Terrasoft.Core.Configuration.SysSettings.GetValue(UserConnection, "RecentEntityCount"));
			if (recentEntityCount == 0) {
				return;
			}
			using (var executor = UserConnection.EnsureDBConnection()) {
				var delete = new Delete(UserConnection).From("SysRecentEntity")
					.Where(Column.SourceColumn("Id")).Not().In(
						new Select(UserConnection).Top(recentEntityCount)
							.Column("Id")
							.From("SysRecentEntity")
							.Where("SysUserId").IsEqual(Column.Parameter(SysUserId))
							.And("SysEntitySchemaUId").IsEqual(Column.Parameter(SysEntitySchemaId))
							.OrderByDesc("UsedOn"))
					.And("SysUserId").IsEqual(Column.Parameter(SysUserId))
					.And("SysEntitySchemaUId").IsEqual(Column.Parameter(SysEntitySchemaId));
			
				delete.Execute(executor);
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
			if (!HasMapping("SysEntitySchemaId")) {
				writer.WriteValue("SysEntitySchemaId", SysEntitySchemaId, Guid.Empty);
			}
			if (!HasMapping("EntityId")) {
				writer.WriteValue("EntityId", EntityId, Guid.Empty);
			}
			if (!HasMapping("EntityDisplayName")) {
				writer.WriteValue("EntityDisplayName", EntityDisplayName, null);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "SysEntitySchemaId":
					SysEntitySchemaId = reader.GetGuidValue();
				break;
				case "EntityId":
					EntityId = reader.GetGuidValue();
				break;
				case "EntityDisplayName":
					EntityDisplayName = reader.GetStringValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

