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
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: SynchronizeSubjectRemindingUserTaskSchema

	/// <exclude/>
	public class SynchronizeSubjectRemindingUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public SynchronizeSubjectRemindingUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public SynchronizeSubjectRemindingUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("30392711-0c15-40b6-8b03-9e3232660270");
			RealUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270");
			Name = "SynchronizeSubjectRemindingUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,87,75,111,227,54,16,62,91,191,130,214,97,65,1,129,16,244,88,55,105,189,182,19,24,216,166,233,218,187,57,44,246,64,75,147,152,173,68,57,20,149,212,232,250,191,151,67,82,47,75,206,186,133,141,94,156,104,56,250,230,155,39,71,191,248,252,145,208,113,161,214,153,36,87,87,68,20,73,18,144,191,189,65,41,34,159,114,144,147,76,8,136,20,207,68,56,41,164,4,161,80,26,106,177,98,145,154,199,35,111,231,189,48,73,36,164,92,196,92,60,45,162,53,164,172,251,246,76,40,174,182,246,244,87,38,216,147,70,185,5,53,23,185,98,34,130,247,219,59,150,2,245,253,143,37,144,239,7,163,62,232,73,150,20,169,200,181,133,189,131,208,157,140,188,85,150,37,245,233,236,47,158,43,212,127,100,73,14,22,19,186,108,142,162,108,223,126,46,64,110,181,190,128,87,210,84,250,29,229,180,7,251,130,180,29,195,48,107,99,227,88,139,62,242,167,181,161,119,155,100,43,150,140,55,155,5,40,165,245,242,240,6,152,42,36,180,53,231,98,150,174,32,142,33,254,144,61,241,200,219,141,60,195,39,28,199,241,56,73,90,65,162,65,121,120,195,19,5,50,71,37,106,37,19,169,209,193,202,31,184,90,223,51,169,51,128,74,212,10,39,89,186,97,146,231,153,88,110,55,16,206,158,11,150,160,35,139,98,245,7,96,238,125,255,130,184,135,123,201,83,38,183,214,236,103,150,20,16,104,211,252,145,14,231,185,83,153,66,162,209,201,187,119,132,160,80,59,152,128,141,9,72,19,144,147,19,117,69,138,52,221,191,72,106,119,134,136,100,133,140,0,237,208,219,130,199,1,177,130,224,44,209,223,230,205,146,11,245,243,67,38,255,204,55,44,130,208,230,100,175,140,155,199,65,208,168,127,14,88,118,150,143,110,69,11,171,83,152,216,23,105,27,199,228,147,208,222,212,213,45,181,204,92,158,175,42,27,225,195,26,36,80,45,186,70,93,163,28,149,243,3,245,208,56,58,25,55,202,231,39,12,228,53,173,146,136,158,105,6,131,129,4,221,18,130,12,43,4,27,154,156,150,41,214,74,59,252,121,93,243,4,104,155,85,56,22,91,26,24,202,131,189,147,27,46,115,69,131,208,62,82,3,163,107,165,59,69,42,183,38,89,33,20,185,38,151,88,211,186,164,63,104,5,87,235,54,56,122,18,217,152,234,89,244,92,112,9,113,53,3,186,56,122,2,95,146,111,223,72,31,142,55,248,185,59,236,76,1,89,252,253,76,121,131,31,43,248,47,151,95,71,94,199,126,120,162,233,51,242,76,81,140,181,221,23,8,116,88,177,229,247,98,102,195,221,165,160,13,77,225,177,145,115,51,174,250,52,187,211,5,9,235,2,9,239,224,21,255,186,116,13,144,203,193,137,68,134,238,165,89,186,81,219,55,88,53,222,161,90,103,208,127,1,97,213,86,183,86,99,38,6,97,227,125,60,190,32,8,114,144,150,62,52,110,35,247,97,174,36,146,152,231,119,250,54,254,77,26,166,165,71,19,182,49,217,181,204,143,163,254,175,216,59,3,7,93,168,189,40,169,32,239,29,1,125,173,90,78,58,251,123,243,169,47,232,118,4,228,22,234,63,239,11,159,230,241,190,49,195,167,133,238,250,239,170,109,237,205,230,177,24,152,141,22,134,110,7,21,173,111,100,150,78,223,31,174,177,50,57,255,83,122,218,140,251,198,234,194,20,216,53,109,199,67,107,58,95,166,60,223,36,204,185,100,236,7,129,5,119,129,217,121,238,103,87,117,156,155,188,231,236,175,234,42,63,224,187,59,119,189,228,120,245,119,19,134,164,221,74,88,47,170,150,90,3,221,253,178,143,87,3,204,221,79,104,184,11,54,108,236,215,71,68,165,3,208,245,186,233,198,168,149,14,187,131,216,21,228,172,51,207,109,61,7,82,210,164,81,231,229,24,227,71,216,182,175,47,121,122,208,126,173,225,25,219,117,100,220,247,205,25,35,99,45,124,39,50,86,233,228,145,153,66,30,73,254,230,164,104,168,212,177,57,98,110,159,172,112,218,166,250,104,154,27,179,173,214,238,237,251,108,83,108,150,92,37,128,237,157,41,219,225,15,107,174,96,129,187,110,185,229,125,151,179,239,215,80,184,60,215,79,13,107,123,119,19,222,67,185,91,143,102,130,173,18,136,53,142,102,193,31,121,196,80,229,243,15,218,171,163,25,104,15,0,226,101,182,0,97,22,120,37,11,56,109,85,52,185,225,228,56,84,26,251,122,182,62,122,72,176,23,179,35,215,151,191,253,214,235,238,174,110,57,110,125,4,30,10,76,115,247,174,183,10,43,173,180,208,4,45,183,219,122,77,55,95,5,24,184,145,255,15,103,5,159,43,218,16,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateActiveParameter());
			Parameters.Add(CreateSubjectPrimaryColumnValueParameter());
			Parameters.Add(CreateAuthorParameter());
			Parameters.Add(CreateContactParameter());
			Parameters.Add(CreateSourceParameter());
			Parameters.Add(CreateRemindTimeParameter());
			Parameters.Add(CreateDescriptionParameter());
			Parameters.Add(CreateSysEntitySchemaParameter());
			Parameters.Add(CreateSubjectCaptionParameter());
			Parameters.Add(CreateTypeCaptionParameter());
			Parameters.Add(CreateIsListSubjectRemindsParameter());
			Parameters.Add(CreateIsSubjectDeleteParameter());
			Parameters.Add(CreateNotificationTypeParameter());
			Parameters.Add(CreatePopupTitleParameter());
			Parameters.Add(CreateIsSingleReminderParameter());
		}

		protected virtual ProcessSchemaParameter CreateActiveParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("bb2cfe13-818f-406d-b306-238b5c83cc5d"),
				Name = "Active",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSubjectPrimaryColumnValueParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("0eedefc0-8e0c-4485-80eb-022489352861"),
				Name = "SubjectPrimaryColumnValue",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateAuthorParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("f41f2b3e-8b41-4101-b028-09a5bad36ab8"),
				Name = "Author",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateContactParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("3964073d-e93f-48fc-baba-c7deb337b232"),
				Name = "Contact",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSourceParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("a454b4a0-85c8-49a8-afa9-a918b86569a5"),
				Name = "Source",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRemindTimeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("59410b57-d0cf-4b57-b794-b1fc70b3bb53"),
				Name = "RemindTime",
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDescriptionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("da854917-3d08-4d13-bfd9-8834e2122321"),
				Name = "Description",
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSysEntitySchemaParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("492fb3fb-4d86-4ff0-a6f8-dbd5a0419893"),
				Name = "SysEntitySchema",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSubjectCaptionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("17c36094-1f3d-4fc3-84fd-85c0d6c40647"),
				Name = "SubjectCaption",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateTypeCaptionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("131a3953-62ab-472a-b575-ecf2ff2c0e05"),
				Name = "TypeCaption",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIsListSubjectRemindsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("916137b3-0b84-467e-9f5a-e6c478a6b33c"),
				Name = "IsListSubjectReminds",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIsSubjectDeleteParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("b4d927c1-e0b0-4451-abbb-2cb5d6f5b818"),
				Name = "IsSubjectDelete",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateNotificationTypeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("71a40919-3237-4692-9c5c-1e31bca92712"),
				Name = "NotificationType",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreatePopupTitleParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("b4a8c3cd-aba4-4189-be98-ec02f4b07ba7"),
				Name = "PopupTitle",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIsSingleReminderParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("38404fef-2ad9-4d24-9a24-d5c4057cb40b"),
				Name = "IsSingleReminder",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
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
			Methods.Add(CreateDeleteRemindingListMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("defca40a-31d5-45aa-92c9-5a329365835f"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("04a0aab7-23a5-48be-b5c3-aad0677a78c4"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c73c8b55-d498-4a91-97b2-bc1e4602fe26"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		protected virtual SchemaMethod CreateDeleteRemindingListMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1f6c0d84-7a7a-49a8-a5ec-7df820bfca43"),
				Name = "DeleteRemindingList",
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("728c87bf-e6fc-4343-bada-ac131b688464"),
				Name = "entities",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntityCollection",
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,207,200,204,73,213,72,205,43,201,44,201,76,45,214,115,204,171,212,208,212,84,168,230,226,132,11,185,101,22,21,151,104,104,234,185,164,230,164,150,164,106,104,90,115,213,114,1,0,125,250,202,156,54,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SynchronizeSubjectRemindingUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("30392711-0c15-40b6-8b03-9e3232660270"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new SynchronizeSubjectRemindingUserTask(userConnection) {
				SchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270")
			};
		}

		#endregion

	}

	#endregion

	#region Class: SynchronizeSubjectRemindingUserTask

	[DesignModeProperty(Name = "Active", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.Active.Caption", DescriptionResourceItem = "Parameters.Active.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SubjectPrimaryColumnValue", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.SubjectPrimaryColumnValue.Caption", DescriptionResourceItem = "Parameters.SubjectPrimaryColumnValue.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Author", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.Author.Caption", DescriptionResourceItem = "Parameters.Author.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Contact", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.Contact.Caption", DescriptionResourceItem = "Parameters.Contact.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Source", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.Source.Caption", DescriptionResourceItem = "Parameters.Source.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RemindTime", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.RemindTime.Caption", DescriptionResourceItem = "Parameters.RemindTime.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Description", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.Description.Caption", DescriptionResourceItem = "Parameters.Description.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SysEntitySchema", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.SysEntitySchema.Caption", DescriptionResourceItem = "Parameters.SysEntitySchema.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SubjectCaption", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.SubjectCaption.Caption", DescriptionResourceItem = "Parameters.SubjectCaption.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "TypeCaption", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.TypeCaption.Caption", DescriptionResourceItem = "Parameters.TypeCaption.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsListSubjectReminds", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.IsListSubjectReminds.Caption", DescriptionResourceItem = "Parameters.IsListSubjectReminds.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsSubjectDelete", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.IsSubjectDelete.Caption", DescriptionResourceItem = "Parameters.IsSubjectDelete.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "NotificationType", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.NotificationType.Caption", DescriptionResourceItem = "Parameters.NotificationType.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "PopupTitle", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.PopupTitle.Caption", DescriptionResourceItem = "Parameters.PopupTitle.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsSingleReminder", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.IsSingleReminder.Caption", DescriptionResourceItem = "Parameters.IsSingleReminder.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class SynchronizeSubjectRemindingUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public SynchronizeSubjectRemindingUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270");
		}

		#endregion

		#region Properties: Public

		public virtual bool Active {
			get;
			set;
		}

		public virtual Guid SubjectPrimaryColumnValue {
			get;
			set;
		}

		public virtual Object Author {
			get;
			set;
		}

		public virtual Guid Contact {
			get;
			set;
		}

		public virtual Object Source {
			get;
			set;
		}

		public virtual DateTime RemindTime {
			get;
			set;
		}

		public virtual string Description {
			get;
			set;
		}

		public virtual Guid SysEntitySchema {
			get;
			set;
		}

		public virtual string SubjectCaption {
			get;
			set;
		}

		public virtual string TypeCaption {
			get;
			set;
		}

		public virtual bool IsListSubjectReminds {
			get;
			set;
		}

		public virtual bool IsSubjectDelete {
			get;
			set;
		}

		public virtual Guid NotificationType {
			get;
			set;
		}

		public virtual string PopupTitle {
			get;
			set;
		}

		public virtual bool IsSingleReminder {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			if (Author == null) {
				Author = UserConnection.CurrentUser.ContactId;
			}
			var remindingSchema = UserConnection.EntitySchemaManager.GetInstanceByName("Reminding");
			var remindingSchemaColumns = remindingSchema.Columns;
			bool remindingExists = false;
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var query = new EntitySchemaQuery(entitySchemaManager, "Reminding") {
				UseAdminRights = GlobalAppSettings.FeatureUseAdminRightsInEmbeddedLogic
			};
			query.AddAllSchemaColumns();
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, "SubjectId", SubjectPrimaryColumnValue));
			if(!IsSubjectDelete &&  !IsSingleReminder) {
				query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, "Contact", Contact));
			}
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, "Source", (Guid) Source));
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, "SysEntitySchema.SysWorkspace.Id", UserConnection.Workspace.Id));
			var entities = query.GetEntityCollection(UserConnection);
			if (IsSingleReminder) {
				var entityToDelete = entities.Where(e => {
					var contactId = e.GetTypedColumnValue<Guid>("ContactId");
					return !contactId.Equals(Contact);
				});
				while(entityToDelete.Any()) {
					entityToDelete.First().Delete();
				}
			}
			remindingExists = entities.Count > 0 && !IsListSubjectReminds;
			Entity requiredReminding = entities.Count == 0 || IsListSubjectReminds
				? remindingSchema.CreateEntity(UserConnection)
				: entities[0];
			requiredReminding.UseAdminRights = GlobalAppSettings.FeatureUseAdminRightsInEmbeddedLogic;
			
			if (Active){
				if(!remindingExists) {
					requiredReminding.SetDefColumnValues();
					requiredReminding.PrimaryColumnValue = Guid.NewGuid();
				}
				if (SubjectPrimaryColumnValue != Guid.Empty) {
					requiredReminding.SetColumnValue(
						remindingSchemaColumns.GetByName("SubjectId").ColumnValueName, 
						SubjectPrimaryColumnValue
					);
					if (!string.IsNullOrEmpty(SubjectCaption)) {
						requiredReminding.SetColumnValue(
									remindingSchemaColumns.GetByName("SubjectCaption").ColumnValueName, 
									SubjectCaption);
					} else {
						if(SysEntitySchema != Guid.Empty) {
							var subjectSchema = UserConnection.EntitySchemaManager.GetInstanceByUId(SysEntitySchema);
							var subjectEntity = subjectSchema.CreateEntity(UserConnection);
							if (subjectEntity.FetchFromDB(SubjectPrimaryColumnValue)) {
								requiredReminding.SetColumnValue(
									remindingSchemaColumns.GetByName("SubjectCaption").ColumnValueName, 
									subjectEntity.GetTypedColumnValue<String>(subjectSchema.GetPrimaryDisplayColumnName())
								);
							}
						}
					}
				}
				if (Contact != Guid.Empty) {
					requiredReminding.SetColumnValue(
						remindingSchemaColumns.GetByName("Contact").ColumnValueName, 
						Contact
					);
				}
				if (!string.IsNullOrEmpty(TypeCaption)) {
					var typeCaptionColumn = remindingSchemaColumns.GetByName("TypeCaption");
					if (typeCaptionColumn != null) {
						requiredReminding.SetColumnValue(typeCaptionColumn.ColumnValueName, TypeCaption);
					}
				}
				if ((Guid)Source != Guid.Empty) {
					requiredReminding.SetColumnValue(
						remindingSchemaColumns.GetByName("Source").ColumnValueName, 
						(Guid)Source
					);
				}
				requiredReminding.SetColumnValue(
					remindingSchemaColumns.GetByName("RemindTime").ColumnValueName, 
					RemindTime
				);
				if ((Guid)Author != Guid.Empty) {
					requiredReminding.SetColumnValue(
						remindingSchemaColumns.GetByName("Author").ColumnValueName, 
						(Guid)Author
					);
				}
				requiredReminding.SetColumnValue(
					remindingSchemaColumns.GetByName("Description").ColumnValueName, 
					Description
				);
				if (SysEntitySchema != Guid.Empty) {
					requiredReminding.SetColumnValue(
						remindingSchemaColumns.GetByName("SysEntitySchema").ColumnValueName,
						SysEntitySchema
					);
				}
				if (PopupTitle.IsNotNullOrWhiteSpace()) {
					requiredReminding.SetColumnValue("PopupTitle", PopupTitle);
				}
				if (UserConnection.GetIsFeatureEnabled("NotificationV2")) {
					requiredReminding.SetColumnValue("IsNeedToSend", true);
				}
				requiredReminding.SetColumnValue(
					remindingSchemaColumns.GetByName("NotificationType").ColumnValueName, 
					NotificationType
				);
				requiredReminding.Save();
			} else {
				if(!IsListSubjectReminds && !IsSubjectDelete) {
					requiredReminding.Delete();
				} else {
					DeleteRemindingList(entities);
				}
			}
			return true;
		}

		#endregion

		#region Methods: Public

		public virtual void DeleteRemindingList(EntityCollection entities) {
			while(entities.Any()) {
				entities.First().Delete();
			}
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("Active")) {
				writer.WriteValue("Active", Active, false);
			}
			if (!HasMapping("SubjectPrimaryColumnValue")) {
				writer.WriteValue("SubjectPrimaryColumnValue", SubjectPrimaryColumnValue, Guid.Empty);
			}
			if (Author != null) {
				if (Author.GetType().IsSerializable || Author.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("Author", Author, null);
				}
			}
			if (!HasMapping("Contact")) {
				writer.WriteValue("Contact", Contact, Guid.Empty);
			}
			if (Source != null) {
				if (Source.GetType().IsSerializable || Source.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("Source", Source, null);
				}
			}
			if (!HasMapping("RemindTime")) {
				writer.WriteValue("RemindTime", RemindTime, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
			if (!HasMapping("Description")) {
				writer.WriteValue("Description", Description, null);
			}
			if (!HasMapping("SysEntitySchema")) {
				writer.WriteValue("SysEntitySchema", SysEntitySchema, Guid.Empty);
			}
			if (!HasMapping("SubjectCaption")) {
				writer.WriteValue("SubjectCaption", SubjectCaption, null);
			}
			if (!HasMapping("TypeCaption")) {
				writer.WriteValue("TypeCaption", TypeCaption, null);
			}
			if (!HasMapping("IsListSubjectReminds")) {
				writer.WriteValue("IsListSubjectReminds", IsListSubjectReminds, false);
			}
			if (!HasMapping("IsSubjectDelete")) {
				writer.WriteValue("IsSubjectDelete", IsSubjectDelete, false);
			}
			if (!HasMapping("NotificationType")) {
				writer.WriteValue("NotificationType", NotificationType, Guid.Empty);
			}
			if (!HasMapping("PopupTitle")) {
				writer.WriteValue("PopupTitle", PopupTitle, null);
			}
			if (!HasMapping("IsSingleReminder")) {
				writer.WriteValue("IsSingleReminder", IsSingleReminder, false);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "Active":
					Active = reader.GetBoolValue();
				break;
				case "SubjectPrimaryColumnValue":
					SubjectPrimaryColumnValue = reader.GetGuidValue();
				break;
				case "Author":
					Author = reader.GetSerializableObjectValue();
				break;
				case "Contact":
					Contact = reader.GetGuidValue();
				break;
				case "Source":
					Source = reader.GetSerializableObjectValue();
				break;
				case "RemindTime":
					RemindTime = reader.GetDateTimeValue();
				break;
				case "Description":
					Description = reader.GetStringValue();
				break;
				case "SysEntitySchema":
					SysEntitySchema = reader.GetGuidValue();
				break;
				case "SubjectCaption":
					SubjectCaption = reader.GetStringValue();
				break;
				case "TypeCaption":
					TypeCaption = reader.GetStringValue();
				break;
				case "IsListSubjectReminds":
					IsListSubjectReminds = reader.GetBoolValue();
				break;
				case "IsSubjectDelete":
					IsSubjectDelete = reader.GetBoolValue();
				break;
				case "NotificationType":
					NotificationType = reader.GetGuidValue();
				break;
				case "PopupTitle":
					PopupTitle = reader.GetStringValue();
				break;
				case "IsSingleReminder":
					IsSingleReminder = reader.GetBoolValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

