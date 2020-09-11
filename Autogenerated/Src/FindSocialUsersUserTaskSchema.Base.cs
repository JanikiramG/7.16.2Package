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
	using Terrasoft.Social;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: FindSocialUsersUserTaskSchema

	/// <exclude/>
	public class FindSocialUsersUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public FindSocialUsersUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public FindSocialUsersUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1ecbfc38-5dd1-4aa3-a343-ab604e18117c");
			RealUId = new Guid("1ecbfc38-5dd1-4aa3-a343-ab604e18117c");
			Name = "FindSocialUsersUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,146,193,110,194,48,12,134,207,244,41,188,30,32,149,80,180,123,133,52,132,216,52,105,99,155,96,15,16,181,46,68,180,9,115,220,77,104,240,238,75,90,96,107,217,165,106,252,219,159,127,59,185,139,117,1,226,102,102,13,171,140,31,115,249,232,230,213,142,247,34,129,225,16,28,147,54,107,31,91,212,101,249,66,173,178,68,69,217,102,70,154,145,180,74,18,248,142,6,159,138,0,13,107,222,47,179,13,86,234,89,25,181,70,130,9,188,59,36,79,55,152,177,182,70,206,175,147,210,104,240,55,250,86,35,237,225,163,249,78,192,224,23,92,169,226,159,86,99,136,227,211,20,113,156,120,102,67,144,211,60,159,217,178,174,140,136,227,133,170,176,213,130,221,172,77,246,61,196,10,137,148,179,5,75,79,40,244,186,38,213,152,61,241,146,22,245,128,220,58,17,221,153,198,112,217,94,96,135,125,158,217,55,126,0,191,185,102,69,131,238,222,124,223,83,150,12,190,228,138,116,37,66,253,49,58,70,75,155,105,85,46,144,191,44,109,193,117,78,19,184,77,163,48,128,9,129,173,243,129,78,186,147,203,93,169,89,140,14,35,143,11,110,46,137,173,27,56,28,206,181,242,9,205,154,55,65,185,77,188,199,126,167,14,88,78,203,50,245,230,10,75,168,178,141,248,245,0,218,156,137,205,168,125,76,247,124,0,209,225,38,115,83,87,242,85,145,67,193,251,29,218,162,167,143,79,240,49,48,213,152,164,151,5,205,108,85,213,172,216,134,219,188,252,182,143,166,159,113,117,105,29,83,30,26,116,215,220,202,185,68,222,107,147,55,225,254,155,79,35,66,174,201,52,134,210,248,7,170,99,139,211,69,3,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateContactIdParameter());
			Parameters.Add(CreateSearchCriteriaParameter());
			Parameters.Add(CreateSocialNetworksParameter());
			Parameters.Add(CreateUsersParameter());
		}

		protected virtual ProcessSchemaParameter CreateContactIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("510bdc21-bdf5-4ff8-9250-cbf3d36f183d"),
				Name = "ContactId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSearchCriteriaParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("fe3a41a0-51a5-4bab-bbcb-56aa9f6b306d"),
				Name = "SearchCriteria",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSocialNetworksParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("c3bce1e5-df16-4f2b-bf02-7ef60731ec3d"),
				Name = "SocialNetworks",
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateUsersParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("6a454b81-1458-4594-8e9b-dcb6b958f1fc"),
				Name = "Users",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = true,
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
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9c6e37a2-0d84-4375-ad18-1e384e7dde2d"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d0bff645-b466-47ca-9d51-8e50078b560c"),
				Name = "Terrasoft.Social",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ba79ce2d-beff-430d-afe6-d9ac0d9a18a7"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("1ecbfc38-5dd1-4aa3-a343-ab604e18117c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4591ab7e-4648-4f50-8e91-ab961a920b61"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("1ecbfc38-5dd1-4aa3-a343-ab604e18117c"),
				ModifiedInSchemaUId = new Guid("1ecbfc38-5dd1-4aa3-a343-ab604e18117c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("262668dc-fc27-454a-8d43-99aca3d051e6"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("1ecbfc38-5dd1-4aa3-a343-ab604e18117c"),
				ModifiedInSchemaUId = new Guid("1ecbfc38-5dd1-4aa3-a343-ab604e18117c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a02030b5-dee2-45fe-a590-5deda9df643a"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("1ecbfc38-5dd1-4aa3-a343-ab604e18117c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4d862158-2e73-43a9-8242-3075a58e994e"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("1ecbfc38-5dd1-4aa3-a343-ab604e18117c"),
				ModifiedInSchemaUId = new Guid("1ecbfc38-5dd1-4aa3-a343-ab604e18117c"),
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
				UId = new Guid("14fedebf-2282-499c-9fc5-87290d1d7c32"),
				Name = "UpdateFiltersRightExprMetaDataByParameterValue",
				CreatedInSchemaUId = new Guid("1ecbfc38-5dd1-4aa3-a343-ab604e18117c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8edc5c24-1712-4a42-ae76-321c969dc97e"),
				Name = "process",
				CreatedInSchemaUId = new Guid("1ecbfc38-5dd1-4aa3-a343-ab604e18117c"),
				ModifiedInSchemaUId = new Guid("1ecbfc38-5dd1-4aa3-a343-ab604e18117c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Process",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("301b4654-544c-4f6a-81b8-d45e8f09c80a"),
				Name = "filters",
				CreatedInSchemaUId = new Guid("1ecbfc38-5dd1-4aa3-a343-ab604e18117c"),
				ModifiedInSchemaUId = new Guid("1ecbfc38-5dd1-4aa3-a343-ab604e18117c"),
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
			return new FindSocialUsersUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1ecbfc38-5dd1-4aa3-a343-ab604e18117c"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new FindSocialUsersUserTask(userConnection) {
				SchemaUId = new Guid("1ecbfc38-5dd1-4aa3-a343-ab604e18117c")
			};
		}

		#endregion

	}

	#endregion

	#region Class: FindSocialUsersUserTask

	[DesignModeProperty(Name = "ContactId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "1ecbfc385dd14aa3a343ab604e18117c", CaptionResourceItem = "Parameters.ContactId.Caption", DescriptionResourceItem = "Parameters.ContactId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SearchCriteria", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "1ecbfc385dd14aa3a343ab604e18117c", CaptionResourceItem = "Parameters.SearchCriteria.Caption", DescriptionResourceItem = "Parameters.SearchCriteria.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SocialNetworks", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "1ecbfc385dd14aa3a343ab604e18117c", CaptionResourceItem = "Parameters.SocialNetworks.Caption", DescriptionResourceItem = "Parameters.SocialNetworks.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Users", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "1ecbfc385dd14aa3a343ab604e18117c", CaptionResourceItem = "Parameters.Users.Caption", DescriptionResourceItem = "Parameters.Users.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class FindSocialUsersUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public FindSocialUsersUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("1ecbfc38-5dd1-4aa3-a343-ab604e18117c");
		}

		#endregion

		#region Properties: Public

		public virtual Guid ContactId {
			get;
			set;
		}

		public virtual string SearchCriteria {
			get;
			set;
		}

		public virtual string SocialNetworks {
			get;
			set;
		}

		public virtual Object Users {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			if (!ContactId.IsEmpty() && string.IsNullOrEmpty(SearchCriteria)) {
				var entitySchemaManager = UserConnection.EntitySchemaManager;
				EntitySchemaQuery query = new EntitySchemaQuery(entitySchemaManager, "Contact");
				query.AddColumn("Name");
				var contact = (Terrasoft.Configuration.Contact)query.GetEntity(UserConnection, ContactId);
				if (contact != null) {
					SearchCriteria = contact.Name.Trim();
				}
			}
			SocialNetwork socialNetwork = 0;
			var netwoks = SocialNetworks.Split('|');
			if (netwoks == null || netwoks.Length == 0){
				socialNetwork = SocialNetwork.All;
			}
			foreach(var netwok in netwoks) {
				socialNetwork = socialNetwork | (SocialNetwork)Enum.Parse(typeof(SocialNetwork), netwok, true);
			}
			SocialCommutator commutator = new SocialCommutator(UserConnection, socialNetwork);
			Users = commutator.FindUsers(SearchCriteria);
			return true;
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			return base.CompleteExecuting(parameters);
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
			if (!HasMapping("ContactId")) {
				writer.WriteValue("ContactId", ContactId, Guid.Empty);
			}
			if (!HasMapping("SearchCriteria")) {
				writer.WriteValue("SearchCriteria", SearchCriteria, null);
			}
			if (!HasMapping("SocialNetworks")) {
				writer.WriteValue("SocialNetworks", SocialNetworks, null);
			}
			if (Users != null) {
				if (Users.GetType().IsSerializable || Users.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("Users", Users, null);
				}
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "ContactId":
					ContactId = reader.GetGuidValue();
				break;
				case "SearchCriteria":
					SearchCriteria = reader.GetStringValue();
				break;
				case "SocialNetworks":
					SocialNetworks = reader.GetStringValue();
				break;
				case "Users":
					Users = reader.GetSerializableObjectValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

