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
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: PostUserMessageUserTaskSchema

	/// <exclude/>
	public class PostUserMessageUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public PostUserMessageUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public PostUserMessageUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23");
			RealUId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23");
			Name = "PostUserMessageUserTask";
			CreatedInPackageId = new Guid("d5227176-6716-4fb5-bba8-cc5a2de7deeb");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,143,65,75,3,49,16,133,207,201,175,152,246,180,189,236,31,216,174,168,149,74,168,5,161,173,23,241,16,54,211,109,32,38,144,73,192,34,253,239,78,234,202,106,69,33,144,132,121,243,190,247,174,167,107,234,23,7,237,61,186,181,246,186,199,8,221,207,111,11,191,36,181,242,148,180,239,176,145,118,15,213,100,131,222,44,67,188,113,110,6,239,82,60,88,74,243,251,108,205,21,36,29,123,76,202,16,219,236,8,227,34,176,77,151,108,240,245,6,137,248,190,211,73,63,111,207,178,34,96,233,10,143,47,160,9,70,155,70,138,194,25,205,38,45,248,60,208,196,62,68,212,221,161,42,82,40,199,143,88,86,8,150,8,53,118,128,92,114,12,239,246,162,109,189,180,222,168,132,175,183,199,157,50,149,53,179,166,172,63,6,74,236,176,197,183,84,125,91,63,15,79,146,207,9,208,17,150,56,95,105,254,34,114,186,11,228,48,161,250,73,187,140,244,89,234,31,34,211,100,196,148,35,247,140,25,155,233,7,17,0,92,142,197,1,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateSendForAllParameter());
			Parameters.Add(CreateTargetUserIdsKeyParameter());
			Parameters.Add(CreateSenderNameParameter());
			Parameters.Add(CreateMessageTextParameter());
		}

		protected virtual ProcessSchemaParameter CreateSendForAllParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("469c3de2-013f-4ba6-9a03-3117787d73e0"),
				Name = "SendForAll",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateTargetUserIdsKeyParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("28660f67-48cf-45cf-ad5c-bc527c71a2b3"),
				Name = "TargetUserIdsKey",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSenderNameParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("bb9e1624-5dbc-47e6-adc0-0d5a3777498e"),
				Name = "SenderName",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateMessageTextParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("b2cc185d-f260-4d3c-9aca-ee0828d37ac4"),
				Name = "MessageText",
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
			Methods.Add(CreateCancelExecutingMethod());
			Methods.Add(CreatePostMsgTextMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("09569f4a-3e56-4ea9-9cf8-b8b8cd9c0ae9"),
				Name = "Terrasoft.Messaging.Common",
				Alias = "",
				CreatedInPackageId = new Guid("d5227176-6716-4fb5-bba8-cc5a2de7deeb")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6f9d8948-2f41-40b0-a3a6-6e5980cc072f"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23"),
				CreatedInPackageId = new Guid("d5227176-6716-4fb5-bba8-cc5a2de7deeb"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("88276388-4303-438f-a7d1-864ecd21d145"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23"),
				ModifiedInSchemaUId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("d5227176-6716-4fb5-bba8-cc5a2de7deeb")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9eaa1ce7-9da7-4e99-892d-72e5070510fb"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23"),
				ModifiedInSchemaUId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("d5227176-6716-4fb5-bba8-cc5a2de7deeb")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ba81e0cb-bf11-45dc-a880-52f443dd7095"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23"),
				CreatedInPackageId = new Guid("d5227176-6716-4fb5-bba8-cc5a2de7deeb"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b32bb955-eb7e-4664-939c-70311a868ed4"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23"),
				ModifiedInSchemaUId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("d5227176-6716-4fb5-bba8-cc5a2de7deeb"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e27c9155-7047-43a0-aa1d-51caf58dd1da"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23"),
				CreatedInPackageId = new Guid("d5227176-6716-4fb5-bba8-cc5a2de7deeb"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("24022e43-7b88-45b8-8a19-3df4cffc6867"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23"),
				ModifiedInSchemaUId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("d5227176-6716-4fb5-bba8-cc5a2de7deeb"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,115,78,204,75,78,205,113,173,72,77,46,45,201,204,75,215,40,72,44,74,204,77,45,73,45,42,214,180,6,0,4,172,171,3,33,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePostMsgTextMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("59f6cdb3-8c96-49b7-96cf-efb8eb045615"),
				Name = "PostMsgText",
				CreatedInSchemaUId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23"),
				CreatedInPackageId = new Guid("d5227176-6716-4fb5-bba8-cc5a2de7deeb"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0775dde5-8a48-4f5a-b691-5bed7b38e7a6"),
				Name = "userChannel",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "IMsgChannel",
				CreatedInPackageId = new Guid("d5227176-6716-4fb5-bba8-cc5a2de7deeb")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,244,45,78,87,200,5,98,91,133,188,212,114,133,224,204,220,130,156,84,223,212,226,226,196,244,84,13,77,133,106,94,46,78,207,20,168,164,123,105,102,138,134,166,14,80,200,41,63,165,18,40,8,85,23,146,90,81,194,203,85,107,205,203,5,52,72,207,35,53,49,37,181,72,47,56,53,15,72,1,21,65,24,126,137,185,169,64,5,165,197,169,69,206,25,137,121,121,169,57,122,1,249,197,37,48,155,128,26,53,173,1,112,187,127,114,140,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PostUserMessageUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4b1606b8-26b2-466b-9135-1167317fea23"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new PostUserMessageUserTask(userConnection) {
				SchemaUId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23")
			};
		}

		#endregion

	}

	#endregion

	#region Class: PostUserMessageUserTask

	[DesignModeProperty(Name = "SendForAll", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "4b1606b826b2466b91351167317fea23", CaptionResourceItem = "Parameters.SendForAll.Caption", DescriptionResourceItem = "Parameters.SendForAll.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "TargetUserIdsKey", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "4b1606b826b2466b91351167317fea23", CaptionResourceItem = "Parameters.TargetUserIdsKey.Caption", DescriptionResourceItem = "Parameters.TargetUserIdsKey.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SenderName", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "4b1606b826b2466b91351167317fea23", CaptionResourceItem = "Parameters.SenderName.Caption", DescriptionResourceItem = "Parameters.SenderName.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "MessageText", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "4b1606b826b2466b91351167317fea23", CaptionResourceItem = "Parameters.MessageText.Caption", DescriptionResourceItem = "Parameters.MessageText.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class PostUserMessageUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public PostUserMessageUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23");
		}

		#endregion

		#region Properties: Public

		public virtual bool SendForAll {
			get;
			set;
		}

		public virtual string TargetUserIdsKey {
			get;
			set;
		}

		public virtual string SenderName {
			get;
			set;
		}

		public virtual string MessageText {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			MsgChannelManager channelManager = MsgChannelManager.Instance;
			if (!SendForAll) {
				List<Guid> targetIds = UserConnection.SessionData[TargetUserIdsKey] as List<Guid>;
				if (targetIds != null) {
					foreach(Guid id in targetIds) {	
						IMsgChannel userChannel = channelManager.FindItemByUId(id);
						PostMsgText(userChannel);
					}
				}
			} else {
				foreach(IMsgChannel userChannel in channelManager.Channels.Values) {
					PostMsgText(userChannel);
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

		public virtual void PostMsgText(IMsgChannel userChannel) {
			IMsg msg = new SimpleMessage() {
				Id = new Guid(),
				Body = MessageText
			};
			msg.Header.Sender = SenderName;
			userChannel.PostMessage(msg);
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("SendForAll")) {
				writer.WriteValue("SendForAll", SendForAll, false);
			}
			if (!HasMapping("TargetUserIdsKey")) {
				writer.WriteValue("TargetUserIdsKey", TargetUserIdsKey, null);
			}
			if (!HasMapping("SenderName")) {
				writer.WriteValue("SenderName", SenderName, null);
			}
			if (!HasMapping("MessageText")) {
				writer.WriteValue("MessageText", MessageText, null);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "SendForAll":
					SendForAll = reader.GetBoolValue();
				break;
				case "TargetUserIdsKey":
					TargetUserIdsKey = reader.GetStringValue();
				break;
				case "SenderName":
					SenderName = reader.GetStringValue();
				break;
				case "MessageText":
					MessageText = reader.GetStringValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

