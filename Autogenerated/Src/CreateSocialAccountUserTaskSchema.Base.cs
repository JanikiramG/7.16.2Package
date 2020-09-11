namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: CreateSocialAccountUserTaskSchema

	/// <exclude/>
	public class CreateSocialAccountUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public CreateSocialAccountUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public CreateSocialAccountUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25");
			RealUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25");
			Name = "CreateSocialAccountUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,193,110,219,48,12,61,219,95,33,248,18,27,48,212,237,218,108,195,210,108,89,131,97,221,128,52,237,97,217,65,177,153,70,152,35,5,18,221,52,8,252,239,163,36,167,177,19,20,216,197,150,40,242,61,242,137,226,231,36,126,22,134,109,197,19,204,138,53,108,196,15,161,104,109,216,71,54,183,96,198,90,41,40,80,106,197,191,1,246,60,210,36,249,117,30,149,36,25,19,150,93,216,135,103,36,132,126,193,232,8,166,202,162,80,5,220,236,239,196,6,136,97,166,11,41,170,81,81,232,90,225,168,198,181,131,38,150,97,228,17,237,146,144,20,236,216,12,141,84,79,55,181,172,74,202,44,27,198,118,201,71,219,45,168,114,162,205,70,32,65,221,131,49,194,234,21,114,77,246,71,169,74,189,75,7,15,18,118,14,147,11,187,125,25,228,131,195,187,102,144,39,73,222,201,143,207,167,37,191,215,129,34,205,8,60,190,186,162,115,35,54,246,250,68,68,20,191,93,102,241,82,235,138,73,59,145,198,34,165,135,166,134,99,253,20,2,8,198,182,89,127,145,94,90,97,246,31,172,71,207,89,248,127,58,196,209,129,37,73,77,87,48,45,93,58,115,191,234,164,193,154,60,248,4,137,238,0,119,218,252,117,174,61,195,171,219,79,202,17,140,43,53,0,118,247,39,172,186,40,192,218,175,207,160,208,221,128,135,59,179,189,58,79,132,172,160,236,249,158,153,88,19,55,195,120,165,13,136,98,205,210,158,6,76,170,142,32,25,163,138,229,138,165,173,110,126,31,157,68,92,137,202,146,138,81,195,128,22,254,176,43,124,190,80,11,244,226,71,77,220,59,57,4,235,101,59,44,80,17,247,53,235,222,120,155,13,255,14,251,183,130,158,69,85,31,163,250,65,15,238,164,23,70,1,141,167,111,226,94,155,44,240,79,30,122,216,183,197,78,150,184,238,189,8,254,232,76,167,203,30,215,21,214,6,166,106,165,249,84,81,140,20,10,91,99,22,122,107,13,242,105,141,125,148,91,111,251,111,152,203,114,169,200,156,29,222,211,199,149,234,243,204,91,38,202,62,114,207,64,218,49,93,54,152,240,158,174,89,212,171,212,245,126,54,244,26,28,7,0,165,152,206,246,22,97,195,31,97,201,111,17,183,52,100,16,94,144,143,107,99,8,236,248,191,21,170,172,168,81,104,160,156,222,238,124,234,194,92,132,209,149,229,174,127,51,255,29,198,179,194,200,45,30,231,151,237,237,130,46,124,66,89,182,177,110,184,116,93,218,209,245,38,211,235,162,23,69,170,121,109,91,58,226,161,242,79,143,148,142,187,222,124,84,150,33,60,13,118,114,48,64,242,171,48,37,146,127,221,13,44,95,142,5,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateUserIdParameter());
			Parameters.Add(CreateSocialNetworkParameter());
			Parameters.Add(CreateOpenerPageIdParameter());
			Parameters.Add(CreateSuccessEventNameParameter());
			Parameters.Add(CreateFailedEventNameParameter());
		}

		protected virtual ProcessSchemaParameter CreateUserIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("c008dd23-b2ca-4a57-aaf5-d0187f7e2c94"),
				Name = "UserId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSocialNetworkParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("9fc0768f-bc10-4e40-90e3-376aa6e7ea25"),
				Name = "SocialNetwork",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateOpenerPageIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("cf262fdf-aff1-43fd-ad15-a5244fd71931"),
				Name = "OpenerPageId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSuccessEventNameParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("a2e37b86-9db0-4b8c-be08-0c4cb52083c4"),
				Name = "SuccessEventName",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				},
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateFailedEventNameParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e527ebea-58a7-4988-9f4a-8f43c7cd93fe"),
				Name = "FailedEventName",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				},
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
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7663a93a-f93d-44b7-aef7-181d1a627c2b"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("16e0b458-bdb7-4eef-9321-1a0c9810bcca"),
				Name = "System.Globalization",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9a7dd765-f6d8-4e86-9b86-b7eb5323ee95"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6dd472ed-379a-4ba1-9002-e2ce8d3494c4"),
				Name = "Terrasoft.UI.WebControls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7a3064f0-b569-4ee5-8f78-f90a44ef17e2"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("76105dcb-9398-4a35-961a-303e7ca60739"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				ModifiedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("111d8bbb-1f9b-45c6-9c83-7753046b8289"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				ModifiedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("599af13f-2447-41a9-9610-1becd9c7fc57"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6ea17bfe-a133-4ab1-b6f0-7f31f7604e73"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				ModifiedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
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
				UId = new Guid("90e10a4c-27b9-4d3a-997c-5ea5c75dbc93"),
				Name = "UpdateFiltersRightExprMetaDataByParameterValue",
				CreatedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("05a8658b-6330-41a1-a1ef-e8921bd0d141"),
				Name = "process",
				CreatedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				ModifiedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Process",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b9fb758c-d7da-4d1e-8e1d-b862ca238b7f"),
				Name = "filters",
				CreatedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				ModifiedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
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
			return new CreateSocialAccountUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new CreateSocialAccountUserTask(userConnection) {
				SchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25")
			};
		}

		#endregion

	}

	#endregion

	#region Class: CreateSocialAccountUserTask

	[DesignModeGroup(Name = "Incoming", Position = 1, UseSolutionStorage = true, ResourceManager = "4c647b901d28415a83933699e8ed5e25", CaptionResourceItem = "Parameters.UserId.Group", DescriptionResourceItem = "Parameters.UserId.Group")]
	[DesignModeGroup(Name = "Event names", Position = 2, UseSolutionStorage = true, ResourceManager = "4c647b901d28415a83933699e8ed5e25", CaptionResourceItem = "Parameters.SuccessEventName.Group", DescriptionResourceItem = "Parameters.SuccessEventName.Group")]
	[DesignModeProperty(Name = "UserId", Group = "Incoming", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "4c647b901d28415a83933699e8ed5e25", CaptionResourceItem = "Parameters.UserId.Caption", DescriptionResourceItem = "Parameters.UserId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SocialNetwork", Group = "Incoming", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "4c647b901d28415a83933699e8ed5e25", CaptionResourceItem = "Parameters.SocialNetwork.Caption", DescriptionResourceItem = "Parameters.SocialNetwork.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "OpenerPageId", Group = "Incoming", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "4c647b901d28415a83933699e8ed5e25", CaptionResourceItem = "Parameters.OpenerPageId.Caption", DescriptionResourceItem = "Parameters.OpenerPageId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SuccessEventName", Group = "Event names", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "4c647b901d28415a83933699e8ed5e25", CaptionResourceItem = "Parameters.SuccessEventName.Caption", DescriptionResourceItem = "Parameters.SuccessEventName.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "FailedEventName", Group = "Event names", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "4c647b901d28415a83933699e8ed5e25", CaptionResourceItem = "Parameters.FailedEventName.Caption", DescriptionResourceItem = "Parameters.FailedEventName.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class CreateSocialAccountUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public CreateSocialAccountUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25");
		}

		#endregion

		#region Properties: Public

		public virtual Guid UserId {
			get;
			set;
		}

		public virtual string SocialNetwork {
			get;
			set;
		}

		public virtual string OpenerPageId {
			get;
			set;
		}

		private string _successEventName = @"SocialAccountCreatedSuccessfullyEvent";
		public virtual string SuccessEventName {
			get {
				return _successEventName;
			}
			set {
				_successEventName = value;
			}
		}

		private string _failedEventName = @"SocialAccountCreationFailedEvent";
		public virtual string FailedEventName {
			get {
				return _failedEventName;
			}
			set {
				_failedEventName = value;
			}
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			
			var pageSchemaManager = UserConnection.GetSchemaManager("PageSchemaManager") as PageSchemaManager;
			var pageSchema = pageSchemaManager.GetInstanceByName("SocialAccountAuthPage");	
			var sb = new StringBuilder();
			sb.AppendFormat("Terrasoft.openWindow('ViewPage.aspx','{0}',", pageSchema.UId.ToString());
			
			// params:
			sb.Append("[");
			bool isFirst = true;
			var parameters = new Dictionary<string, string>{
				{ "userId", UserId.ToString() },
				{ "SocialNetwork", SocialNetwork },
				{ "OpenerPageId", OpenerPageId },
				{ "SuccessEventName", SuccessEventName },
				{ "FailedEventName", FailedEventName }
			};
			foreach (var parameter in parameters) {
				if (isFirst) {
					isFirst = false;
				} else {
					sb.Append(",\n\t");
				}
				sb.Append("{");
				sb.AppendFormat("\tname: '{0}',", parameter.Key);
				sb.AppendFormat("\tvalue: '{0}'", parameter.Value);
				sb.Append("}");
			}
			
			sb.Append("\t],");	
			
			var width = pageSchema.Width.ToString(CultureInfo.InvariantCulture);
			var height = pageSchema.Height.ToString(CultureInfo.InvariantCulture);
			sb.AppendFormat("{0}, {1}, ", width, height);		
			// isCenterWindow: 	
			sb.Append("true);");
			var page = (System.Web.HttpContext.Current.CurrentHandler as Terrasoft.UI.WebControls.Page).Page;
			ScriptManager scriptManager = page.FindControl("ScriptManager") as Terrasoft.UI.WebControls.Controls.ScriptManager;
			string script = sb.ToString();
			scriptManager.AddScript(script);
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
			if (!HasMapping("UserId")) {
				writer.WriteValue("UserId", UserId, Guid.Empty);
			}
			if (!HasMapping("SocialNetwork")) {
				writer.WriteValue("SocialNetwork", SocialNetwork, null);
			}
			if (!HasMapping("OpenerPageId")) {
				writer.WriteValue("OpenerPageId", OpenerPageId, null);
			}
			if (!HasMapping("SuccessEventName")) {
				writer.WriteValue("SuccessEventName", SuccessEventName, null);
			}
			if (!HasMapping("FailedEventName")) {
				writer.WriteValue("FailedEventName", FailedEventName, null);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "UserId":
					UserId = reader.GetGuidValue();
				break;
				case "SocialNetwork":
					SocialNetwork = reader.GetStringValue();
				break;
				case "OpenerPageId":
					OpenerPageId = reader.GetStringValue();
				break;
				case "SuccessEventName":
					SuccessEventName = reader.GetStringValue();
				break;
				case "FailedEventName":
					FailedEventName = reader.GetStringValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

