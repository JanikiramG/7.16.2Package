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

	#region Class: ProcessYouScanMailMessageUserTaskSchema

	/// <exclude/>
	public class ProcessYouScanMailMessageUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public ProcessYouScanMailMessageUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public ProcessYouScanMailMessageUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("de19169e-dbb1-4ccb-a5e6-e4c9bced6d71");
			RealUId = new Guid("de19169e-dbb1-4ccb-a5e6-e4c9bced6d71");
			Name = "ProcessYouScanMailMessageUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,93,111,155,48,20,125,166,191,226,42,47,5,9,89,164,251,238,74,178,143,180,83,164,102,170,6,155,84,69,121,112,169,27,44,129,29,153,75,43,214,228,191,239,98,76,74,214,78,147,16,178,125,206,185,231,248,94,248,52,242,60,111,174,54,53,94,235,58,201,184,90,136,170,226,107,1,49,188,116,58,157,66,133,70,170,53,59,47,55,216,124,60,34,117,119,176,92,193,134,27,172,94,22,178,100,83,72,244,143,183,199,129,213,92,212,42,59,147,10,67,87,110,2,107,129,87,164,39,185,47,3,136,39,240,216,242,60,121,71,123,56,131,8,182,91,144,48,137,59,23,118,41,212,26,243,192,177,60,35,176,54,234,121,54,111,119,52,128,173,116,41,87,22,218,217,119,170,55,50,35,83,103,239,71,93,190,164,44,23,92,81,112,243,157,151,109,51,92,229,175,90,101,28,253,158,61,14,66,24,141,232,9,247,5,78,130,128,165,70,150,254,223,133,206,75,46,139,129,211,171,103,78,26,69,53,32,188,238,8,104,26,119,203,25,71,145,74,138,115,75,11,34,82,152,123,97,144,165,186,71,246,193,222,80,176,164,169,80,148,236,91,161,111,120,33,127,115,148,90,177,158,121,161,77,201,113,174,238,52,155,171,123,110,36,87,118,215,121,62,205,20,165,189,126,95,247,109,208,79,242,212,77,210,163,41,66,174,107,67,172,150,236,38,3,113,12,39,48,5,66,25,41,43,225,183,224,50,90,5,112,10,209,147,178,148,170,182,151,249,191,118,60,212,94,213,55,133,204,236,157,102,93,55,148,120,128,125,31,218,14,177,107,193,77,104,155,197,22,90,97,238,214,51,222,132,54,113,232,220,67,112,83,223,1,85,204,242,118,249,248,15,151,222,129,45,164,250,197,139,90,116,66,59,73,42,153,137,68,162,248,249,227,114,208,179,119,93,113,247,39,28,98,239,15,176,84,98,49,236,246,135,3,244,139,190,109,6,224,56,58,64,63,215,152,107,51,196,199,132,187,15,31,13,5,29,253,1,165,95,77,217,236,3,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateTopicParameter());
			Parameters.Add(CreateSmmManagerNameParameter());
			Parameters.Add(CreateSmmManagerEmailParameter());
			Parameters.Add(CreateSmmManagerNotesParameter());
			Parameters.Add(CreatePublicationDateParameter());
			Parameters.Add(CreateSourceSiteURLParameter());
			Parameters.Add(CreateMessageURLParameter());
			Parameters.Add(CreateMessageTitleParameter());
			Parameters.Add(CreateMessageBodyParameter());
			Parameters.Add(CreateMessageAuthorParameter());
			Parameters.Add(CreateInputYouScanMessageParameter());
		}

		protected virtual ProcessSchemaParameter CreateTopicParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("3e218646-9775-4c64-a99d-84e72ff98d52"),
				Name = "Topic",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSmmManagerNameParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("2385ddd2-1dc7-4627-aa27-ca7544ed5f0c"),
				Name = "SmmManagerName",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSmmManagerEmailParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("d361c78a-ff96-4441-8ca3-9a4741ded362"),
				Name = "SmmManagerEmail",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSmmManagerNotesParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("25fc936f-0e13-4817-8c93-ba4ee3ca086f"),
				Name = "SmmManagerNotes",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreatePublicationDateParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e1e88505-99aa-452f-9363-70890f90b5eb"),
				Name = "PublicationDate",
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSourceSiteURLParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("6940b626-138a-4939-a792-4e5cdb771579"),
				Name = "SourceSiteURL",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateMessageURLParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("967cb098-1345-4a8f-bd93-bdfb5e50ac3b"),
				Name = "MessageURL",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateMessageTitleParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("b7113368-fcca-45b1-8223-1c8e5f724a3d"),
				Name = "MessageTitle",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateMessageBodyParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e62cc135-1c4f-4562-8273-14346c0fd1d3"),
				Name = "MessageBody",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateMessageAuthorParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("32a7d73e-d902-4476-baa8-b4b9ac8af872"),
				Name = "MessageAuthor",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateInputYouScanMessageParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("f6d2b3ab-b736-4ad3-8ac3-b98f731cbcf4"),
				Name = "InputYouScanMessage",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
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

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7f8a6b72-31c0-473e-a27c-df77c4e14ae7"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("de19169e-dbb1-4ccb-a5e6-e4c9bced6d71"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7ea9944d-5445-44b6-8e5b-e382a369fd70"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("de19169e-dbb1-4ccb-a5e6-e4c9bced6d71"),
				ModifiedInSchemaUId = new Guid("de19169e-dbb1-4ccb-a5e6-e4c9bced6d71"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b6fb8bcd-c064-4a89-8a12-35da26fef019"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("de19169e-dbb1-4ccb-a5e6-e4c9bced6d71"),
				ModifiedInSchemaUId = new Guid("de19169e-dbb1-4ccb-a5e6-e4c9bced6d71"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("28388214-3f23-462a-82d5-3279dfbb6a97"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("de19169e-dbb1-4ccb-a5e6-e4c9bced6d71"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("480f03b2-cf5b-43ee-b201-026eca85ea63"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("de19169e-dbb1-4ccb-a5e6-e4c9bced6d71"),
				ModifiedInSchemaUId = new Guid("de19169e-dbb1-4ccb-a5e6-e4c9bced6d71"),
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
				UId = new Guid("2ea7a826-3fc5-4c65-8326-7df7629b5ce1"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("de19169e-dbb1-4ccb-a5e6-e4c9bced6d71"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4d62f5ce-5f60-4a96-9e2c-0def997357ec"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("de19169e-dbb1-4ccb-a5e6-e4c9bced6d71"),
				ModifiedInSchemaUId = new Guid("de19169e-dbb1-4ccb-a5e6-e4c9bced6d71"),
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
			return new ProcessYouScanMailMessageUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("de19169e-dbb1-4ccb-a5e6-e4c9bced6d71"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new ProcessYouScanMailMessageUserTask(userConnection) {
				SchemaUId = new Guid("de19169e-dbb1-4ccb-a5e6-e4c9bced6d71")
			};
		}

		#endregion

	}

	#endregion

	#region Class: ProcessYouScanMailMessageUserTask

	[DesignModeProperty(Name = "Topic", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "de19169edbb14ccba5e6e4c9bced6d71", CaptionResourceItem = "Parameters.Topic.Caption", DescriptionResourceItem = "Parameters.Topic.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SmmManagerName", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "de19169edbb14ccba5e6e4c9bced6d71", CaptionResourceItem = "Parameters.SmmManagerName.Caption", DescriptionResourceItem = "Parameters.SmmManagerName.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SmmManagerEmail", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "de19169edbb14ccba5e6e4c9bced6d71", CaptionResourceItem = "Parameters.SmmManagerEmail.Caption", DescriptionResourceItem = "Parameters.SmmManagerEmail.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SmmManagerNotes", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "de19169edbb14ccba5e6e4c9bced6d71", CaptionResourceItem = "Parameters.SmmManagerNotes.Caption", DescriptionResourceItem = "Parameters.SmmManagerNotes.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "PublicationDate", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "de19169edbb14ccba5e6e4c9bced6d71", CaptionResourceItem = "Parameters.PublicationDate.Caption", DescriptionResourceItem = "Parameters.PublicationDate.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SourceSiteURL", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "de19169edbb14ccba5e6e4c9bced6d71", CaptionResourceItem = "Parameters.SourceSiteURL.Caption", DescriptionResourceItem = "Parameters.SourceSiteURL.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "MessageURL", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "de19169edbb14ccba5e6e4c9bced6d71", CaptionResourceItem = "Parameters.MessageURL.Caption", DescriptionResourceItem = "Parameters.MessageURL.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "MessageTitle", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "de19169edbb14ccba5e6e4c9bced6d71", CaptionResourceItem = "Parameters.MessageTitle.Caption", DescriptionResourceItem = "Parameters.MessageTitle.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "MessageBody", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "de19169edbb14ccba5e6e4c9bced6d71", CaptionResourceItem = "Parameters.MessageBody.Caption", DescriptionResourceItem = "Parameters.MessageBody.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "MessageAuthor", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "de19169edbb14ccba5e6e4c9bced6d71", CaptionResourceItem = "Parameters.MessageAuthor.Caption", DescriptionResourceItem = "Parameters.MessageAuthor.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "InputYouScanMessage", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "de19169edbb14ccba5e6e4c9bced6d71", CaptionResourceItem = "Parameters.InputYouScanMessage.Caption", DescriptionResourceItem = "Parameters.InputYouScanMessage.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class ProcessYouScanMailMessageUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public ProcessYouScanMailMessageUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("de19169e-dbb1-4ccb-a5e6-e4c9bced6d71");
		}

		#endregion

		#region Properties: Public

		public virtual string Topic {
			get;
			set;
		}

		public virtual string SmmManagerName {
			get;
			set;
		}

		public virtual string SmmManagerEmail {
			get;
			set;
		}

		public virtual string SmmManagerNotes {
			get;
			set;
		}

		public virtual DateTime PublicationDate {
			get;
			set;
		}

		public virtual string SourceSiteURL {
			get;
			set;
		}

		public virtual string MessageURL {
			get;
			set;
		}

		public virtual string MessageTitle {
			get;
			set;
		}

		public virtual string MessageBody {
			get;
			set;
		}

		public virtual string MessageAuthor {
			get;
			set;
		}

		public virtual string InputYouScanMessage {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
						InputYouScanMessage = InputYouScanMessage ?? string.Empty;
						string[] parts = InputYouScanMessage.Split('|');
						Func<int, string> getPart = (i) => {
							if (i < 0 || i >= parts.Length) {
								return string.Empty;
							}
							return parts[i];
						};
						Topic = getPart(0);
						SmmManagerName = string.Concat(getPart(1), " ", getPart(2)).Trim();
						SmmManagerEmail = getPart(3);
						SmmManagerNotes = getPart(4);
						try {
							DateTime date = Convert.ToDateTime(getPart(5), System.Globalization.DateTimeFormatInfo.InvariantInfo);
							string[] time = getPart(6).Split(':');
							int hour = time.Length == 2 ? int.Parse(time[0]) : 0;
							int minute = time.Length == 2 ? int.Parse(time[1]) : 0;
							PublicationDate = new DateTime(date.Year, date.Month, date.Day, hour, minute, 0);
						} catch
						{
							PublicationDate = DateTime.MinValue;
						}
						SourceSiteURL = getPart(7);
						MessageURL = getPart(8);
						MessageTitle = getPart(9);
						MessageBody = getPart(10);
						MessageAuthor = getPart(11);
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
			if (!HasMapping("Topic")) {
				writer.WriteValue("Topic", Topic, null);
			}
			if (!HasMapping("SmmManagerName")) {
				writer.WriteValue("SmmManagerName", SmmManagerName, null);
			}
			if (!HasMapping("SmmManagerEmail")) {
				writer.WriteValue("SmmManagerEmail", SmmManagerEmail, null);
			}
			if (!HasMapping("SmmManagerNotes")) {
				writer.WriteValue("SmmManagerNotes", SmmManagerNotes, null);
			}
			if (!HasMapping("PublicationDate")) {
				writer.WriteValue("PublicationDate", PublicationDate, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
			if (!HasMapping("SourceSiteURL")) {
				writer.WriteValue("SourceSiteURL", SourceSiteURL, null);
			}
			if (!HasMapping("MessageURL")) {
				writer.WriteValue("MessageURL", MessageURL, null);
			}
			if (!HasMapping("MessageTitle")) {
				writer.WriteValue("MessageTitle", MessageTitle, null);
			}
			if (!HasMapping("MessageBody")) {
				writer.WriteValue("MessageBody", MessageBody, null);
			}
			if (!HasMapping("MessageAuthor")) {
				writer.WriteValue("MessageAuthor", MessageAuthor, null);
			}
			if (!HasMapping("InputYouScanMessage")) {
				writer.WriteValue("InputYouScanMessage", InputYouScanMessage, null);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "Topic":
					Topic = reader.GetStringValue();
				break;
				case "SmmManagerName":
					SmmManagerName = reader.GetStringValue();
				break;
				case "SmmManagerEmail":
					SmmManagerEmail = reader.GetStringValue();
				break;
				case "SmmManagerNotes":
					SmmManagerNotes = reader.GetStringValue();
				break;
				case "PublicationDate":
					PublicationDate = reader.GetDateTimeValue();
				break;
				case "SourceSiteURL":
					SourceSiteURL = reader.GetStringValue();
				break;
				case "MessageURL":
					MessageURL = reader.GetStringValue();
				break;
				case "MessageTitle":
					MessageTitle = reader.GetStringValue();
				break;
				case "MessageBody":
					MessageBody = reader.GetStringValue();
				break;
				case "MessageAuthor":
					MessageAuthor = reader.GetStringValue();
				break;
				case "InputYouScanMessage":
					InputYouScanMessage = reader.GetStringValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

