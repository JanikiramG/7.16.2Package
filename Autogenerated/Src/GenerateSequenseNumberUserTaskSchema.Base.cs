namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using SystemSettings = Terrasoft.Core.Configuration.SysSettings;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: GenerateSequenseNumberUserTaskSchema

	/// <exclude/>
	public class GenerateSequenseNumberUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public GenerateSequenseNumberUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public GenerateSequenseNumberUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666");
			RealUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666");
			Name = "GenerateSequenseNumberUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,142,65,10,194,48,16,69,215,230,20,99,87,21,36,23,40,5,161,136,59,23,86,15,16,235,47,6,218,9,78,38,162,136,119,183,168,72,156,221,231,61,30,179,42,124,79,229,154,213,235,189,237,206,24,29,205,107,226,52,12,11,122,152,217,213,9,33,135,53,253,185,46,210,30,34,46,134,94,109,19,4,246,141,61,162,205,189,234,83,234,2,51,58,245,129,167,206,52,20,55,181,135,8,105,126,160,50,244,189,29,98,26,180,9,39,76,242,6,12,113,138,22,151,4,142,216,166,241,8,41,243,215,150,89,126,81,153,167,17,104,18,38,149,132,170,120,1,219,94,124,50,232,0,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = true;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateResultCodeParameter());
			Parameters.Add(CreateEntitySchemaParameter());
		}

		protected virtual ProcessSchemaParameter CreateResultCodeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e5525f9c-51c4-47b8-af3c-b32bbc6471a8"),
				Name = "ResultCode",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("a7c5be65-feb5-4e5a-a264-cf4a4bc16d94"),
				Name = "EntitySchema",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
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
			Methods.Add(CreateUpdateFiltersRightExprMetaDataByParameterValueMethod());
			Methods.Add(CreateGenerateSequenseNumberMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b5614cee-489a-4af3-8a04-48d7da6127b2"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cf819365-32ca-419f-9ec4-5b727cffcf67"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d71c4213-17ee-4149-afd2-65a7165c85b0"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6bce6cdb-9f3b-4016-bab3-6cce23fdaeea"),
				Name = "Terrasoft.Core.Configuration.SysSettings",
				Alias = "SystemSettings",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		protected virtual SchemaMethod CreateUpdateFiltersRightExprMetaDataByParameterValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("939a01da-127f-4832-a2fe-89c868352d89"),
				Name = "UpdateFiltersRightExprMetaDataByParameterValue",
				CreatedInSchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("970c8916-2b1c-4fd6-a013-6178ab1b3bfb"),
				Name = "process",
				CreatedInSchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				ModifiedInSchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Process",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3fa08e7e-d385-46d6-8dbb-4d0eb0fb1dbe"),
				Name = "filters",
				CreatedInSchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				ModifiedInSchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceFilterCollection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,82,77,79,194,48,24,62,143,95,81,47,164,75,76,131,94,9,38,130,31,39,18,2,234,197,120,168,227,133,53,217,218,165,125,75,36,102,255,221,118,237,134,130,34,122,235,250,62,95,125,246,174,148,6,158,229,132,110,184,38,43,81,32,104,34,100,60,153,148,188,247,18,177,34,180,157,24,114,195,145,47,148,213,25,220,53,119,19,85,20,144,161,80,178,1,39,143,213,146,99,156,153,185,88,231,120,251,86,233,41,32,247,204,241,118,198,53,47,193,13,159,120,97,129,86,90,101,96,204,57,161,71,132,131,123,58,116,242,153,146,40,164,5,119,174,147,94,226,83,47,59,98,76,57,58,20,139,18,195,240,154,125,6,235,114,186,40,206,144,140,70,68,218,162,8,47,250,108,121,26,159,61,108,43,240,34,251,49,118,16,143,96,19,107,80,149,193,229,68,205,223,36,187,122,125,89,39,101,237,24,134,77,148,149,232,115,95,134,76,77,189,85,55,119,238,127,80,27,182,2,238,147,207,56,230,142,190,211,122,190,120,97,205,6,52,176,111,238,61,58,236,6,187,7,252,186,53,227,237,52,106,82,106,80,11,185,78,91,147,116,79,143,205,161,84,27,184,70,58,104,70,245,79,181,44,236,107,92,90,114,22,254,62,233,247,15,223,187,131,197,182,174,200,32,150,245,223,205,63,226,209,70,174,123,245,7,22,168,67,142,169,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGenerateSequenseNumberMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("81ddef68-c4f5-46fc-9827-8ae4e881d4e6"),
				Name = "GenerateSequenseNumber",
				CreatedInSchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				CreatedInPackageId = new Guid("c6dca304-a1bb-4543-b6b7-745cf618e36d"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a36e7bf9-dea6-4a4c-a9e4-85276cf0e63b"),
				Name = "entitySchema",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Var,
				ValueTypeName = "EntitySchema",
				CreatedInPackageId = new Guid("c6dca304-a1bb-4543-b6b7-745cf618e36d")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("940d1b78-5753-4e7d-b205-8e9b09ec45a7"),
				Name = "connection",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("c6dca304-a1bb-4543-b6b7-745cf618e36d")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,77,111,130,64,16,61,203,175,88,61,24,136,134,67,123,52,61,248,17,141,73,181,77,169,189,175,56,173,164,176,107,119,7,91,211,248,223,187,139,130,80,7,91,111,48,251,230,205,155,183,15,52,170,72,188,49,16,24,225,46,8,215,144,240,57,79,128,221,85,74,190,173,245,28,125,0,135,114,5,51,174,223,3,64,52,239,4,62,43,117,88,107,120,68,182,138,222,152,107,156,167,201,18,212,223,221,247,5,214,244,71,2,153,222,233,99,151,62,157,21,212,165,211,124,174,33,118,15,167,94,176,211,8,73,14,240,39,128,47,60,78,193,13,165,16,16,98,36,69,151,90,204,235,57,91,174,202,220,22,48,53,84,134,91,192,39,171,242,150,232,60,246,237,52,172,16,3,36,136,157,189,217,233,213,200,59,103,246,199,128,225,122,172,100,50,26,184,153,135,45,90,27,107,183,89,147,34,152,234,71,80,90,10,30,103,42,46,59,67,17,140,224,53,179,167,231,236,51,149,147,88,46,121,220,223,108,10,3,23,26,70,131,0,62,82,16,33,100,83,50,159,142,133,25,223,228,254,156,42,101,115,122,85,188,1,151,90,237,237,12,118,118,197,7,101,148,240,52,70,151,12,142,165,81,128,169,18,236,176,140,63,150,42,225,232,18,27,119,139,9,150,126,14,95,199,0,120,158,93,146,140,150,81,53,148,98,11,10,253,103,57,21,120,123,227,254,39,70,180,212,243,36,157,6,93,155,39,114,2,145,168,234,4,50,87,180,88,147,172,70,179,158,168,62,95,21,243,92,243,209,122,245,44,167,144,209,12,21,144,161,235,116,106,126,0,23,218,3,190,53,87,108,110,152,65,172,193,138,253,117,131,1,253,35,200,159,253,39,41,177,191,74,34,177,16,17,78,148,76,55,211,85,141,107,93,230,52,26,53,34,179,144,93,17,85,154,227,7,253,115,20,127,174,5,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new GenerateSequenseNumberUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new GenerateSequenseNumberUserTask(userConnection) {
				SchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666")
			};
		}

		#endregion

	}

	#endregion

	#region Class: GenerateSequenseNumberUserTask

	[DesignModeProperty(Name = "ResultCode", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b9b23348b89c48368c5b283ef5ed8666", CaptionResourceItem = "Parameters.ResultCode.Caption", DescriptionResourceItem = "Parameters.ResultCode.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "EntitySchema", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b9b23348b89c48368c5b283ef5ed8666", CaptionResourceItem = "Parameters.EntitySchema.Caption", DescriptionResourceItem = "Parameters.EntitySchema.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public partial class GenerateSequenseNumberUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public GenerateSequenseNumberUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666");
		}

		#endregion

		#region Properties: Public

		public virtual string ResultCode {
			get;
			set;
		}

		public virtual Object EntitySchema {
			get;
			set;
		}

		#endregion

		#region Methods: Public

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("ResultCode")) {
				writer.WriteValue("ResultCode", ResultCode, null);
			}
			if (EntitySchema != null) {
				if (EntitySchema.GetType().IsSerializable || EntitySchema.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("EntitySchema", EntitySchema, null);
				}
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "ResultCode":
					ResultCode = reader.GetStringValue();
				break;
				case "EntitySchema":
					EntitySchema = reader.GetSerializableObjectValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

