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

	#region Class: SetDuplicateCheckedStatusSchema

	/// <exclude/>
	public class SetDuplicateCheckedStatusSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public SetDuplicateCheckedStatusSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public SetDuplicateCheckedStatusSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a1d98c56-6dd1-4621-8635-04fcdfb8f792");
			RealUId = new Guid("a1d98c56-6dd1-4621-8635-04fcdfb8f792");
			Name = "SetDuplicateCheckedStatus";
			CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,91,139,156,48,20,126,30,127,69,240,201,129,70,146,24,53,50,221,82,53,153,101,160,55,186,236,15,8,49,219,21,102,226,162,177,221,161,236,127,111,212,210,209,185,64,159,2,39,231,187,156,239,156,143,254,125,95,87,160,234,95,246,181,146,86,63,168,103,125,144,187,10,220,129,225,35,20,135,23,123,220,120,99,147,106,140,149,202,206,90,140,254,53,182,5,190,143,147,66,68,73,140,33,219,10,2,41,142,51,200,56,71,48,103,40,226,52,97,17,231,145,239,175,255,82,73,165,154,222,220,160,34,49,79,75,156,23,16,115,129,32,141,17,134,5,69,4,34,34,144,136,243,148,240,68,156,168,76,99,249,63,247,86,218,190,91,178,33,68,17,38,140,194,109,148,56,74,138,17,204,48,227,144,160,114,27,33,86,150,130,227,145,173,126,2,193,201,208,221,249,184,107,240,219,91,93,203,105,166,149,111,57,227,44,117,10,101,146,67,74,25,129,69,134,4,140,163,132,145,92,240,36,193,108,212,122,3,122,223,105,112,46,121,22,203,127,73,210,52,37,9,45,160,75,37,131,148,21,41,204,72,194,160,200,10,202,163,76,20,91,22,205,37,29,99,171,109,223,26,96,219,94,187,178,247,83,182,231,251,119,18,143,157,110,203,198,24,173,108,221,152,80,24,91,219,227,244,251,89,26,249,67,183,225,189,182,59,211,89,105,148,46,142,143,187,42,184,176,234,100,249,178,246,69,30,180,99,63,235,12,135,242,102,233,100,88,35,151,86,2,217,129,79,117,103,223,15,3,127,216,120,79,77,171,165,122,6,193,162,219,197,82,155,25,120,140,110,136,119,215,229,123,7,168,142,226,85,237,251,74,207,92,58,127,99,219,106,216,116,109,134,52,86,111,222,202,205,164,91,235,232,198,103,10,123,170,5,203,80,214,225,206,216,38,184,50,161,155,123,53,225,195,7,109,221,150,166,195,252,250,196,79,218,190,255,14,148,205,190,63,152,240,155,108,29,200,234,54,184,60,230,245,5,215,180,10,124,131,225,187,86,77,91,13,163,93,199,145,27,184,69,42,39,168,120,213,170,183,58,24,14,200,155,31,142,255,7,25,26,78,247,58,4,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateSchemaIdParameter());
			Parameters.Add(CreateDataParameter());
			Parameters.Add(CreateRecordIdParameter());
			Parameters.Add(CreateDuplicateSchemaNameParameter());
		}

		protected virtual ProcessSchemaParameter CreateSchemaIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("0e6f3f07-a038-4ad3-98a1-7e3485d45623"),
				Name = "SchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDataParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("09d718e4-4609-4529-8720-480c48b139cc"),
				Name = "Data",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRecordIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("37c1ff50-f598-42ba-af8d-5cd17d6521b8"),
				Name = "RecordId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDuplicateSchemaNameParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("cfde4187-11f0-4d05-ab95-44b8a0196ecd"),
				Name = "DuplicateSchemaName",
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
			Methods.Add(CreateIsAlreadyExcludedMethod());
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("da9374cd-905f-4ec8-9e16-f21188372e1e"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("a1d98c56-6dd1-4621-8635-04fcdfb8f792"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8841e510-e15a-408b-a199-467cdde7714b"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("a1d98c56-6dd1-4621-8635-04fcdfb8f792"),
				ModifiedInSchemaUId = new Guid("a1d98c56-6dd1-4621-8635-04fcdfb8f792"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b4b24a01-7a63-4589-a697-35a0f7916b19"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("a1d98c56-6dd1-4621-8635-04fcdfb8f792"),
				ModifiedInSchemaUId = new Guid("a1d98c56-6dd1-4621-8635-04fcdfb8f792"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8c02ef93-be3b-451f-9f29-6bf18876734c"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("a1d98c56-6dd1-4621-8635-04fcdfb8f792"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("45876870-c8ec-4805-9d8e-1cff76b8367f"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("a1d98c56-6dd1-4621-8635-04fcdfb8f792"),
				ModifiedInSchemaUId = new Guid("a1d98c56-6dd1-4621-8635-04fcdfb8f792"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsAlreadyExcludedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("108fce7a-157a-4299-bec8-92a048404355"),
				Name = "IsAlreadyExcluded",
				CreatedInSchemaUId = new Guid("a1d98c56-6dd1-4621-8635-04fcdfb8f792"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("cce84c39-982e-4f37-90f4-237b23832d22"),
				Name = "duplicateId",
				CreatedInSchemaUId = new Guid("a1d98c56-6dd1-4621-8635-04fcdfb8f792"),
				ModifiedInSchemaUId = new Guid("a1d98c56-6dd1-4621-8635-04fcdfb8f792"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,82,203,78,195,48,16,60,199,95,97,229,100,95,44,224,26,90,169,77,83,41,23,42,81,33,206,198,94,209,8,103,93,252,224,33,196,191,227,52,73,211,10,36,4,190,120,188,94,207,142,53,211,96,160,14,124,52,129,206,232,69,65,182,96,64,5,234,251,109,70,17,94,105,95,99,119,30,92,105,17,19,110,44,114,146,117,75,148,214,196,22,217,58,162,74,56,98,96,121,173,115,206,197,194,119,232,80,202,249,161,119,120,177,118,182,101,171,184,55,141,146,1,182,106,7,173,188,145,45,12,140,153,184,223,129,3,198,197,112,222,236,1,151,198,170,39,150,87,24,154,240,126,217,13,24,46,51,81,251,234,57,74,195,122,33,73,3,250,192,110,65,89,167,107,205,167,190,5,234,145,224,234,119,2,61,234,59,225,16,165,177,30,122,41,199,218,198,157,224,127,40,253,105,208,95,197,126,251,237,153,82,42,253,96,97,65,162,111,240,145,178,23,233,168,126,168,222,64,197,96,93,178,249,220,91,81,161,143,14,86,203,169,196,56,167,31,36,59,70,165,15,136,232,41,146,137,210,72,119,221,96,152,179,137,151,23,25,249,36,14,66,116,56,134,108,158,66,246,5,72,225,94,139,116,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SetDuplicateCheckedStatusSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a1d98c56-6dd1-4621-8635-04fcdfb8f792"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new SetDuplicateCheckedStatus(userConnection) {
				SchemaUId = new Guid("a1d98c56-6dd1-4621-8635-04fcdfb8f792")
			};
		}

		#endregion

	}

	#endregion

	#region Class: SetDuplicateCheckedStatus

	[DesignModeProperty(Name = "SchemaId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "a1d98c566dd14621863504fcdfb8f792", CaptionResourceItem = "Parameters.SchemaId.Caption", DescriptionResourceItem = "Parameters.SchemaId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Data", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "a1d98c566dd14621863504fcdfb8f792", CaptionResourceItem = "Parameters.Data.Caption", DescriptionResourceItem = "Parameters.Data.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RecordId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "a1d98c566dd14621863504fcdfb8f792", CaptionResourceItem = "Parameters.RecordId.Caption", DescriptionResourceItem = "Parameters.RecordId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DuplicateSchemaName", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "a1d98c566dd14621863504fcdfb8f792", CaptionResourceItem = "Parameters.DuplicateSchemaName.Caption", DescriptionResourceItem = "Parameters.DuplicateSchemaName.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class SetDuplicateCheckedStatus : ProcessUserTask
	{

		#region Constructors: Public

		public SetDuplicateCheckedStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("a1d98c56-6dd1-4621-8635-04fcdfb8f792");
		}

		#endregion

		#region Properties: Public

		public virtual Guid SchemaId {
			get;
			set;
		}

		public virtual Object Data {
			get;
			set;
		}

		public virtual Guid RecordId {
			get;
			set;
		}

		public virtual string DuplicateSchemaName {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			Guid duplicateSchemaId = Guid.Empty;
			Guid contactSchemaId = new Guid("16BE3651-8FE2-4159-8DD0-A803D4683DD3");
			Guid accountSchemaId = new Guid("25D7C1AB-1DE0-4501-B402-02E0E5A72D6E");
			Guid notDuplicateStatus = new Guid("00401284-F36B-1410-918D-20CF308CCED1");
			if (SchemaId == contactSchemaId) {
				duplicateSchemaId = new Guid("AFD8D870-9C6A-4482-B90E-53682AED6618");
			} else if (SchemaId == accountSchemaId) {
				duplicateSchemaId = new Guid("A477264B-2D69-48B7-9268-E9B4D39EBF83");
			} else {
				return true;
			}
			var duplicateSchema = UserConnection.EntitySchemaManager.GetInstanceByUId(duplicateSchemaId);
			DuplicateSchemaName = duplicateSchema.Name;
			var duplicates = Data as List<Guid>;
			foreach (var duplicateId in duplicates) {
				if (IsAlreadyExcluded(duplicateId)) {
					continue;
				}
				Insert insert = new Insert(UserConnection).Into(DuplicateSchemaName);
				insert.Set("StatusOfDuplicateId", Column.Parameter(notDuplicateStatus));
				insert.Set("Entity1Id", Column.Parameter(RecordId));
				insert.Set("Entity2Id", Column.Parameter(duplicateId));
				insert.Execute();
			}
			return true;
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			return base.CompleteExecuting(parameters);
		}

		public virtual bool IsAlreadyExcluded(Guid duplicateId) {
			int result = 0;
			Select select = new Select(UserConnection)
								.Column(Func.Count("Id")).As("IdCount")					
								.From(DuplicateSchemaName)
									.Where().
									OpenBlock("Entity1Id")
										.IsEqual(Column.Const(RecordId))
										.And("Entity2Id")
										.IsEqual(Column.Const(duplicateId))
									.CloseBlock()
									.Or()
									.OpenBlock("Entity1Id")
										.IsEqual(Column.Const(duplicateId))
										.And("Entity2Id")
										.IsEqual(Column.Const(RecordId))
									.CloseBlock() as Select;
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				result = select.ExecuteScalar<int>(dbExecutor);	
			}
			return result > 0;
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("SchemaId")) {
				writer.WriteValue("SchemaId", SchemaId, Guid.Empty);
			}
			if (Data != null) {
				if (Data.GetType().IsSerializable || Data.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("Data", Data, null);
				}
			}
			if (!HasMapping("RecordId")) {
				writer.WriteValue("RecordId", RecordId, Guid.Empty);
			}
			if (!HasMapping("DuplicateSchemaName")) {
				writer.WriteValue("DuplicateSchemaName", DuplicateSchemaName, null);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "SchemaId":
					SchemaId = reader.GetGuidValue();
				break;
				case "Data":
					Data = reader.GetSerializableObjectValue();
				break;
				case "RecordId":
					RecordId = reader.GetGuidValue();
				break;
				case "DuplicateSchemaName":
					DuplicateSchemaName = reader.GetStringValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

