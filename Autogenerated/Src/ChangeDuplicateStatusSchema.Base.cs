namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: ChangeDuplicateStatusSchema

	/// <exclude/>
	public class ChangeDuplicateStatusSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public ChangeDuplicateStatusSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public ChangeDuplicateStatusSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f26d1391-8445-4cb3-8088-0be2264b24f9");
			RealUId = new Guid("f26d1391-8445-4cb3-8088-0be2264b24f9");
			Name = "ChangeDuplicateStatus";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,148,93,107,219,48,20,134,175,173,95,33,116,37,67,98,146,165,13,25,166,176,38,118,75,110,58,88,218,237,90,179,79,23,131,45,123,250,104,87,70,254,251,36,217,169,63,234,180,176,4,12,209,199,121,207,123,206,35,233,11,121,98,2,39,37,87,44,81,187,100,15,5,219,166,248,10,115,120,198,183,58,75,41,33,243,229,58,94,44,47,231,211,213,77,252,105,122,49,191,252,60,93,69,209,108,122,189,154,45,162,139,229,106,17,69,11,66,252,16,73,37,50,254,11,167,186,202,179,132,41,168,229,238,88,1,33,66,86,12,151,85,85,202,204,172,40,166,180,116,137,236,124,16,23,149,122,9,81,246,136,105,235,225,106,104,203,199,127,145,55,162,110,84,8,217,212,123,163,227,50,33,33,58,96,200,37,188,23,117,157,36,165,230,131,40,231,99,163,133,0,174,90,167,93,171,206,137,109,156,116,203,95,31,95,5,118,144,67,162,154,6,214,3,250,32,65,24,123,220,252,207,74,238,35,239,245,23,108,202,92,23,156,142,216,155,24,119,187,161,250,54,53,141,238,198,223,136,178,24,139,238,109,250,177,7,1,6,164,139,14,182,50,254,173,89,78,235,212,198,1,151,138,118,50,248,62,102,178,177,30,34,79,75,203,148,218,98,211,159,241,31,72,180,42,133,169,175,95,84,16,115,169,5,68,235,118,138,250,174,75,71,129,109,196,20,251,6,44,5,35,100,5,78,180,46,168,115,64,189,149,182,57,27,57,239,121,159,229,128,105,42,2,187,229,152,197,243,222,0,27,90,140,214,247,47,21,152,137,39,16,10,132,25,127,103,185,134,251,210,157,115,163,119,11,202,205,208,153,239,135,158,103,85,15,200,125,7,115,40,108,7,250,231,247,108,236,132,180,2,78,145,16,139,125,156,242,200,230,119,41,223,149,106,4,244,160,75,125,216,232,92,216,167,88,127,208,183,143,152,159,64,62,242,154,156,143,188,67,91,87,169,177,216,64,125,112,131,1,212,201,216,99,215,80,9,118,160,232,137,59,60,193,61,40,195,66,124,191,102,138,254,255,254,214,118,67,84,215,112,108,48,53,175,244,219,123,210,125,130,5,40,45,56,86,66,67,72,254,1,90,38,5,38,29,6,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateSchemaIdParameter());
			Parameters.Add(CreateDuplicateIdParameter());
			Parameters.Add(CreateCurrentStatusIdParameter());
		}

		protected virtual ProcessSchemaParameter CreateSchemaIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("54e357a1-5aef-4587-b0e7-6ab7dea7bb2d"),
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

		protected virtual ProcessSchemaParameter CreateDuplicateIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("54a59b9e-be9e-40d4-8344-d0250620c0f2"),
				Name = "DuplicateId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentStatusIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("ddc45ba8-166f-4b65-b3ae-3d22e69335ef"),
				Name = "CurrentStatusId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
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
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d110662f-c57f-41e8-8708-8ffdae184e46"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1bfd3b87-5bfe-4db4-9c0e-8e6aea693bc6"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("f26d1391-8445-4cb3-8088-0be2264b24f9"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a43e5b34-0fe7-4fa1-a936-69f0d9c66990"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("f26d1391-8445-4cb3-8088-0be2264b24f9"),
				ModifiedInSchemaUId = new Guid("f26d1391-8445-4cb3-8088-0be2264b24f9"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8a4d2660-cab0-447d-99cc-1dd48601dd15"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("f26d1391-8445-4cb3-8088-0be2264b24f9"),
				ModifiedInSchemaUId = new Guid("f26d1391-8445-4cb3-8088-0be2264b24f9"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("85cbba90-39db-41ae-b918-75afb5ee2f6f"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("f26d1391-8445-4cb3-8088-0be2264b24f9"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("93e04bff-b322-4158-a0cf-c1db21fe02ca"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("f26d1391-8445-4cb3-8088-0be2264b24f9"),
				ModifiedInSchemaUId = new Guid("f26d1391-8445-4cb3-8088-0be2264b24f9"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ChangeDuplicateStatusSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f26d1391-8445-4cb3-8088-0be2264b24f9"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new ChangeDuplicateStatus(userConnection) {
				SchemaUId = new Guid("f26d1391-8445-4cb3-8088-0be2264b24f9")
			};
		}

		#endregion

	}

	#endregion

	#region Class: ChangeDuplicateStatus

	[DesignModeProperty(Name = "SchemaId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f26d139184454cb380880be2264b24f9", CaptionResourceItem = "Parameters.SchemaId.Caption", DescriptionResourceItem = "Parameters.SchemaId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DuplicateId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f26d139184454cb380880be2264b24f9", CaptionResourceItem = "Parameters.DuplicateId.Caption", DescriptionResourceItem = "Parameters.DuplicateId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "CurrentStatusId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f26d139184454cb380880be2264b24f9", CaptionResourceItem = "Parameters.CurrentStatusId.Caption", DescriptionResourceItem = "Parameters.CurrentStatusId.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class ChangeDuplicateStatus : ProcessUserTask
	{

		#region Constructors: Public

		public ChangeDuplicateStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("f26d1391-8445-4cb3-8088-0be2264b24f9");
		}

		#endregion

		#region Properties: Public

		public virtual Guid SchemaId {
			get;
			set;
		}

		public virtual Guid DuplicateId {
			get;
			set;
		}

		public virtual Guid CurrentStatusId {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			var contactSchemaId = new Guid("16BE3651-8FE2-4159-8DD0-A803D4683DD3");
			string duplicateSchemaName;
			
			Guid oppositeStatusId = Guid.Empty;
			if (SchemaId == contactSchemaId) {
				duplicateSchemaName = "ContactDuplicate";
			} else {
				duplicateSchemaName = "AccountDuplicate";
			}
			if (CurrentStatusId == Guid.Empty) {
				var statusOfDuplicateSelect = new Select(UserConnection)
													.Column(duplicateSchemaName, "StatusOfDuplicateId")
													.From(duplicateSchemaName)
													.Where("Id").IsEqual(Column.Const(DuplicateId)) as Select;
				using (var dbExecutor = UserConnection.EnsureDBConnection()) {
					using (IDataReader dr = statusOfDuplicateSelect.ExecuteReader(dbExecutor)) {
						while (dr.Read()) {
							CurrentStatusId = UserConnection.DBTypeConverter.DBValueToGuid(dr.GetValue(0));		
						}
					}
				}
			}
			var oppositeStatusOfDuplicateSelect = new Select(UserConnection)
													.Column("DuplicateStatus", "Id")
													.From("DuplicateStatus")
													.Where("Id").IsNotEqual(Column.Const(CurrentStatusId)) as Select;
			
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dr = oppositeStatusOfDuplicateSelect.ExecuteReader(dbExecutor)) {
					while (dr.Read()) {
						oppositeStatusId = UserConnection.DBTypeConverter.DBValueToGuid(dr.GetValue(0));		
					}
				}
			}
			var update = new Update(UserConnection, duplicateSchemaName)
								.Set("StatusOfDuplicateId", Column.Const(oppositeStatusId))						
								.Where("Id").IsEqual(Column.Const(DuplicateId)) as Update;
			update.Execute();
			CurrentStatusId = Guid.Empty;
			return true;
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			return base.CompleteExecuting(parameters);
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
			if (!HasMapping("DuplicateId")) {
				writer.WriteValue("DuplicateId", DuplicateId, Guid.Empty);
			}
			if (!HasMapping("CurrentStatusId")) {
				writer.WriteValue("CurrentStatusId", CurrentStatusId, Guid.Empty);
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
				case "DuplicateId":
					DuplicateId = reader.GetGuidValue();
				break;
				case "CurrentStatusId":
					CurrentStatusId = reader.GetGuidValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

