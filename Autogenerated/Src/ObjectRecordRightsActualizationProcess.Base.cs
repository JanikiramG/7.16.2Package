namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: ObjectRecordRightsActualizationProcessSchema

	/// <exclude/>
	public class ObjectRecordRightsActualizationProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public ObjectRecordRightsActualizationProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public ObjectRecordRightsActualizationProcessSchema(ObjectRecordRightsActualizationProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ObjectRecordRightsActualizationProcess";
			UId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301");
			CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"Business Process";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			UseSystemSecurityContext = true;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,61,142,81,10,194,48,16,68,191,45,244,14,161,95,21,138,23,240,75,123,0,37,165,7,72,147,37,174,180,155,178,217,6,84,188,187,41,72,190,102,96,230,49,179,110,211,140,86,37,100,217,204,172,82,64,167,6,32,167,97,65,114,72,190,141,194,89,212,2,49,26,15,71,245,169,171,67,73,7,224,4,60,10,206,40,8,241,212,51,24,129,18,95,95,119,14,54,147,237,24,129,251,64,4,86,48,80,167,154,219,244,204,94,131,13,236,52,250,135,196,139,221,47,224,219,236,141,63,215,116,101,248,92,87,223,31,83,176,29,62,174,0,0,0 };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301");
			Version = 0;
			PackageUId = new Guid("5be3998b-c5c3-42bb-a01c-2e4149059a97");
			UseSystemSecurityContext = true;
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a5251af1-5a5f-4a1a-b2df-fa3127bd8a6d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateChunkSizeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3a99f3cf-49f7-4bb2-8733-3f5ae25c02a6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Name = @"ChunkSize",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"500",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateChunkProcessingDelayParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("63f8392a-72cc-4846-a89e-83ae75644a3c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Name = @"ChunkProcessingDelay",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"500",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateMaxDegreeOfParallelismParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9975462c-580e-4b2b-93b8-5e7bd11a190c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Name = @"MaxDegreeOfParallelism",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"2",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateActualizationSuccessMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a9fa7b5b-d4bb-4388-a77e-49064d132625"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Name = @"ActualizationSuccessMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateErrorMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6354a50a-69fc-4571-acc6-d1383701816d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Name = @"ErrorMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateGeneralErrorMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4153df13-3f82-47fc-b18f-281fe0e47ae6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Name = @"GeneralErrorMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEntitySchemaUIdParameter());
			Parameters.Add(CreateChunkSizeParameter());
			Parameters.Add(CreateChunkProcessingDelayParameter());
			Parameters.Add(CreateMaxDegreeOfParallelismParameter());
			Parameters.Add(CreateActualizationSuccessMessageParameter());
			Parameters.Add(CreateErrorMessageParameter());
			Parameters.Add(CreateGeneralErrorMessageParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaStartEvent startevent1 = CreateStartEvent1StartEvent();
			FlowElements.Add(startevent1);
			ProcessSchemaTerminateEvent terminator = CreateTerminatorTerminateEvent();
			FlowElements.Add(terminator);
			ProcessSchemaScriptTask actualizationexecutionscripttask = CreateActualizationExecutionScriptTaskScriptTask();
			FlowElements.Add(actualizationexecutionscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("bf247216-8908-4312-80d9-ccfc78d89f9c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("be6f6b49-189f-4148-bff8-2c8c58642b76"),
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c7a5f5a7-e453-44de-91ea-22c336bb64a1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dfc394f8-650b-4d0a-a8cf-51caf2020168"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("da8527a2-5a1a-424e-9051-2e16259681f7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("be6f6b49-189f-4148-bff8-2c8c58642b76"),
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dfc394f8-650b-4d0a-a8cf-51caf2020168"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("88ba5837-c741-4192-be87-98750b79328e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("f4d04a01-c7d4-4bdd-a1c6-e8b41cb0d318"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("be6f6b49-189f-4148-bff8-2c8c58642b76"),
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("c6e7cba3-06af-4f9e-ad67-421c556de0e7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f4d04a01-c7d4-4bdd-a1c6-e8b41cb0d318"),
				CreatedInOwnerSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				CreatedInPackageId = new Guid("be6f6b49-189f-4148-bff8-2c8c58642b76"),
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStartEvent1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("c7a5f5a7-e453-44de-91ea-22c336bb64a1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c6e7cba3-06af-4f9e-ad67-421c556de0e7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("be6f6b49-189f-4148-bff8-2c8c58642b76"),
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Name = @"StartEvent1",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = true
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminatorTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("88ba5837-c741-4192-be87-98750b79328e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c6e7cba3-06af-4f9e-ad67-421c556de0e7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("be6f6b49-189f-4148-bff8-2c8c58642b76"),
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Name = @"Terminator",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateActualizationExecutionScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("dfc394f8-650b-4d0a-a8cf-51caf2020168"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c6e7cba3-06af-4f9e-ad67-421c556de0e7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("be6f6b49-189f-4148-bff8-2c8c58642b76"),
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Name = @"ActualizationExecutionScriptTask",
				Position = new Point(304, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = true,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,203,110,219,48,16,60,91,95,65,232,68,1,5,63,160,106,83,180,142,108,248,96,59,176,27,244,204,72,27,139,45,73,185,36,229,68,45,242,239,93,74,178,170,151,219,155,205,221,153,221,217,25,93,184,33,160,157,112,213,49,205,65,241,199,77,70,62,18,151,11,203,214,224,62,172,75,145,221,209,48,25,118,132,81,28,92,16,88,90,48,203,66,107,72,157,40,116,31,247,56,168,32,195,240,225,74,192,83,87,114,41,126,129,65,176,134,23,178,127,250,142,29,7,72,11,147,29,196,41,119,246,115,215,66,135,227,144,226,47,156,45,243,82,255,56,226,207,254,22,66,59,28,221,149,194,25,200,131,41,82,176,86,232,211,61,72,94,221,64,143,186,70,68,91,254,122,15,39,3,176,127,126,224,134,75,9,82,88,53,165,154,239,243,100,226,153,208,145,11,44,249,137,252,150,162,126,113,193,2,10,183,206,178,235,223,145,35,81,68,126,7,139,246,164,117,195,17,36,222,105,37,164,235,142,219,60,209,161,21,17,91,22,178,84,154,134,222,87,182,50,133,162,225,117,74,24,5,139,5,251,150,131,1,26,126,173,206,80,247,108,236,174,112,245,122,180,193,50,47,71,1,78,26,175,155,40,46,164,7,54,59,114,219,46,17,7,139,222,1,27,49,141,235,155,108,180,249,156,160,56,120,171,243,211,191,217,150,107,126,170,17,195,156,176,100,218,212,166,47,83,66,11,235,12,119,144,53,201,67,244,12,167,247,112,131,122,184,78,225,75,133,82,198,102,161,133,72,131,241,152,227,220,225,105,188,142,105,133,249,82,28,56,83,121,247,122,7,233,66,63,51,168,118,89,97,26,113,51,164,109,230,178,85,97,20,119,180,75,92,243,124,87,91,89,83,113,127,139,99,153,250,28,111,27,116,24,189,187,181,175,159,115,4,157,29,0,203,25,50,209,118,34,22,222,72,202,93,154,19,154,188,166,112,174,191,124,168,227,215,158,0,140,41,204,182,91,240,198,132,38,69,187,82,202,189,73,212,217,85,212,103,237,211,127,245,36,61,246,127,9,64,178,247,100,10,95,131,6,252,244,134,44,19,177,125,9,190,234,114,83,188,248,208,25,112,165,209,196,153,18,226,63,149,179,31,70,59,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("bb926b70-8e92-4f36-94ed-dfe5dc28b2d5"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("896b9851-e42c-45a9-b833-b6ce2cb9410a"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("05699b3f-cd69-4cf9-b85e-834319913046"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new ObjectRecordRightsActualizationProcess(userConnection);
		}

		public override object Clone() {
			return new ObjectRecordRightsActualizationProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"));
		}

		#endregion

	}

	#endregion

	#region Class: ObjectRecordRightsActualizationProcessMethodsWrapper

	/// <exclude/>
	public class ObjectRecordRightsActualizationProcessMethodsWrapper : ProcessModel
	{

		public ObjectRecordRightsActualizationProcessMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ActualizationExecutionScriptTaskExecute", ActualizationExecutionScriptTaskExecute);
		}

		#region Methods: Private

		private bool ActualizationExecutionScriptTaskExecute(ProcessExecutingContext context) {
			var entitySchemaUId = this.Get<Guid>("EntitySchemaUId");
			var userConnection = this.Get<UserConnection>("UserConnection");
			var actualizer = new ObjectRecordRightsActualizer(userConnection);
			actualizer.ChunkSize = this.Get<int>("ChunkSize");
			actualizer.ChunkProcessingDelay = this.Get<int>("ChunkProcessingDelay");
			actualizer.MaxDegreeOfParallelism = this.Get<int>("MaxDegreeOfParallelism");
			if (entitySchemaUId.Equals(ActivityConsts.ActivityEntitySchemaUId)) {
				var activitySelectFilter = new Select(UserConnection).Column("Id").From("Activity")
					.Where("TypeId").IsNotEqual(Column.Parameter(ActivityConsts.EmailTypeUId)) as Select;
				actualizer.EntityRecordIdSelectFilter = activitySelectFilter;
			}
			var entitySchemaManager = userConnection.EntitySchemaManager;
			var administratedObject = entitySchemaManager.GetInstanceByUId(entitySchemaUId);
			string administratedObjectName = administratedObject.Name;
			try {
				actualizer.Actualize(entitySchemaUId);
				var message = string.Format(this.Get<string>("ActualizationSuccessMessage"), administratedObjectName);
				SendReminding(message);
			} catch (Exception e) {
				string errorMessage = administratedObjectName.IsNotNullOrEmpty()
					? string.Format(this.Get<string>("ErrorMessage"), administratedObjectName)
					: this.Get<string>("GeneralErrorMessage");
				SendReminding(errorMessage);
				throw;
			}
			return true;
		}

			public virtual void SendReminding(string message) {
				RemindingServerUtilities.CreateRemindingByProcess(UserConnection, "ObjectRecordRightsActualizationProcess", message);
			}

		#endregion

	}

	#endregion

	#region Class: ObjectRecordRightsActualizationProcess

	/// <exclude/>
	public class ObjectRecordRightsActualizationProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, ObjectRecordRightsActualizationProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public ObjectRecordRightsActualizationProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ObjectRecordRightsActualizationProcess";
			SchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = true;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			ProcessModel = new ObjectRecordRightsActualizationProcessMethodsWrapper(this);
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: ObjectRecordRightsActualizationProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: ObjectRecordRightsActualizationProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		private Func<string> _notificationCaption;
		public virtual string NotificationCaption {
			get {
				return (_notificationCaption ?? (_notificationCaption = () => null)).Invoke();
			}
			set {
				_notificationCaption = () => { return value; };
			}
		}

		public virtual Guid EntitySchemaUId {
			get;
			set;
		}

		private int _chunkSize = 500;
		public int ChunkSize {
			get {
				return _chunkSize;
			}
			set {
				_chunkSize = value;
			}
		}

		private int _chunkProcessingDelay = 500;
		public int ChunkProcessingDelay {
			get {
				return _chunkProcessingDelay;
			}
			set {
				_chunkProcessingDelay = value;
			}
		}

		private int _maxDegreeOfParallelism = 2;
		public int MaxDegreeOfParallelism {
			get {
				return _maxDegreeOfParallelism;
			}
			set {
				_maxDegreeOfParallelism = value;
			}
		}

		private string _actualizationSuccessMessage;
		public virtual string ActualizationSuccessMessage {
			get {
				return _actualizationSuccessMessage ?? (_actualizationSuccessMessage = GetLocalizableString("c949331e753b48bb88a99e89d8c8a301",
						 "Parameters.ActualizationSuccessMessage.Value"));
			}
			set {
				_actualizationSuccessMessage = value;
			}
		}

		private string _errorMessage;
		public virtual string ErrorMessage {
			get {
				return _errorMessage ?? (_errorMessage = GetLocalizableString("c949331e753b48bb88a99e89d8c8a301",
						 "Parameters.ErrorMessage.Value"));
			}
			set {
				_errorMessage = value;
			}
		}

		private string _generalErrorMessage;
		public virtual string GeneralErrorMessage {
			get {
				return _generalErrorMessage ?? (_generalErrorMessage = GetLocalizableString("c949331e753b48bb88a99e89d8c8a301",
						 "Parameters.GeneralErrorMessage.Value"));
			}
			set {
				_generalErrorMessage = value;
			}
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessFlowElement _startEvent1;
		public ProcessFlowElement StartEvent1 {
			get {
				return _startEvent1 ?? (_startEvent1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "StartEvent1",
					SchemaElementUId = new Guid("c7a5f5a7-e453-44de-91ea-22c336bb64a1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessTerminateEvent _terminator;
		public ProcessTerminateEvent Terminator {
			get {
				return _terminator ?? (_terminator = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminator",
					SchemaElementUId = new Guid("88ba5837-c741-4192-be87-98750b79328e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _actualizationExecutionScriptTask;
		public ProcessScriptTask ActualizationExecutionScriptTask {
			get {
				return _actualizationExecutionScriptTask ?? (_actualizationExecutionScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActualizationExecutionScriptTask",
					SchemaElementUId = new Guid("dfc394f8-650b-4d0a-a8cf-51caf2020168"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ProcessModel.GetScriptTaskMethod("ActualizationExecutionScriptTaskExecute"),
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[StartEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartEvent1 };
			FlowElements[Terminator.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminator };
			FlowElements[ActualizationExecutionScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActualizationExecutionScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "StartEvent1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ActualizationExecutionScriptTask", e.Context.SenderName));
						break;
					case "Terminator":
						CompleteProcess();
						break;
					case "ActualizationExecutionScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminator", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("EntitySchemaUId")) {
				writer.WriteValue("EntitySchemaUId", EntitySchemaUId, Guid.Empty);
			}
			if (!HasMapping("ChunkSize")) {
				writer.WriteValue("ChunkSize", ChunkSize, 0);
			}
			if (!HasMapping("ChunkProcessingDelay")) {
				writer.WriteValue("ChunkProcessingDelay", ChunkProcessingDelay, 0);
			}
			if (!HasMapping("MaxDegreeOfParallelism")) {
				writer.WriteValue("MaxDegreeOfParallelism", MaxDegreeOfParallelism, 0);
			}
			if (!HasMapping("ActualizationSuccessMessage")) {
				writer.WriteValue("ActualizationSuccessMessage", ActualizationSuccessMessage, null);
			}
			if (!HasMapping("ErrorMessage")) {
				writer.WriteValue("ErrorMessage", ErrorMessage, null);
			}
			if (!HasMapping("GeneralErrorMessage")) {
				writer.WriteValue("GeneralErrorMessage", GeneralErrorMessage, null);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			if (IsProcessExecutedBySignal) {
				return;
			}
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartEvent1", string.Empty));
		}

		protected override void CompleteApplyingFlowElementsPropertiesData() {
			base.CompleteApplyingFlowElementsPropertiesData();
			foreach (var item in FlowElements) {
				foreach (var itemValue in item.Value) {
					if (Guid.Equals(itemValue.CreatedInSchemaUId, InternalSchemaUId)) {
						itemValue.ExecutedEventHandler = OnExecuted;
					}
				}
			}
		}

		protected override void InitializeMetaPathParameterValues() {
			base.InitializeMetaPathParameterValues();
			MetaPathParameterValues.Add("a5251af1-5a5f-4a1a-b2df-fa3127bd8a6d", () => EntitySchemaUId);
			MetaPathParameterValues.Add("3a99f3cf-49f7-4bb2-8733-3f5ae25c02a6", () => ChunkSize);
			MetaPathParameterValues.Add("63f8392a-72cc-4846-a89e-83ae75644a3c", () => ChunkProcessingDelay);
			MetaPathParameterValues.Add("9975462c-580e-4b2b-93b8-5e7bd11a190c", () => MaxDegreeOfParallelism);
			MetaPathParameterValues.Add("a9fa7b5b-d4bb-4388-a77e-49064d132625", () => ActualizationSuccessMessage);
			MetaPathParameterValues.Add("6354a50a-69fc-4571-acc6-d1383701816d", () => ErrorMessage);
			MetaPathParameterValues.Add("4153df13-3f82-47fc-b18f-281fe0e47ae6", () => GeneralErrorMessage);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "EntitySchemaUId":
					if (!hasValueToRead) break;
					EntitySchemaUId = reader.GetValue<System.Guid>();
				break;
				case "ChunkSize":
					if (!hasValueToRead) break;
					ChunkSize = reader.GetValue<System.Int32>();
				break;
				case "ChunkProcessingDelay":
					if (!hasValueToRead) break;
					ChunkProcessingDelay = reader.GetValue<System.Int32>();
				break;
				case "MaxDegreeOfParallelism":
					if (!hasValueToRead) break;
					MaxDegreeOfParallelism = reader.GetValue<System.Int32>();
				break;
				case "ActualizationSuccessMessage":
					if (!hasValueToRead) break;
					ActualizationSuccessMessage = reader.GetValue<System.String>();
				break;
				case "ErrorMessage":
					if (!hasValueToRead) break;
					ErrorMessage = reader.GetValue<System.String>();
				break;
				case "GeneralErrorMessage":
					if (!hasValueToRead) break;
					GeneralErrorMessage = reader.GetValue<System.String>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			if (Status == Core.Process.ProcessStatus.Inactive) {
				return;
			}
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer, writeFlowElements);
			WritePropertyValues(writer, false);
			writer.WriteFinishObject();
		}

		public override object CloneShallow() {
			var cloneItem = (ObjectRecordRightsActualizationProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

