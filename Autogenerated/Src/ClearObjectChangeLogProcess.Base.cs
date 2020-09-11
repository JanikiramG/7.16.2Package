namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: ClearObjectChangeLogProcessSchema

	/// <exclude/>
	public class ClearObjectChangeLogProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public ClearObjectChangeLogProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public ClearObjectChangeLogProcessSchema(ClearObjectChangeLogProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ClearObjectChangeLogProcess";
			UId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9");
			CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsActiveVersion = false;
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
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,82,77,79,195,48,12,61,131,180,255,16,245,148,74,83,255,0,12,105,84,48,33,241,221,109,28,16,135,172,49,93,88,154,116,78,90,84,33,254,59,14,41,3,149,75,43,219,207,47,239,217,110,80,117,194,3,91,180,74,62,191,176,5,248,37,138,114,7,178,40,183,80,11,199,83,246,49,57,62,234,4,50,112,123,54,99,6,222,217,133,241,202,247,17,241,208,2,246,124,229,0,115,107,12,148,94,89,147,253,5,220,8,35,42,192,41,75,214,239,215,182,186,219,188,17,200,37,145,247,136,26,231,178,86,230,81,85,91,239,136,255,85,104,7,84,249,60,161,207,191,135,114,171,219,218,48,247,157,89,93,201,33,158,5,113,217,92,14,49,79,168,148,164,129,33,228,47,149,246,128,46,212,121,136,115,4,178,28,179,79,202,111,239,5,138,26,2,132,199,100,110,235,70,160,114,214,44,251,6,178,139,125,43,244,52,168,77,138,222,61,89,220,185,70,148,144,76,217,200,246,161,148,93,201,52,253,53,64,170,116,132,48,8,9,5,110,144,76,243,30,67,70,179,252,166,65,240,45,254,54,103,5,4,48,7,54,59,131,192,17,100,14,222,215,66,183,112,26,214,121,198,71,99,202,110,201,102,154,102,75,59,71,20,61,15,212,159,193,214,228,184,105,55,90,149,172,83,232,201,43,235,172,146,172,0,35,31,129,118,35,149,169,184,243,72,63,86,131,115,180,206,184,189,67,181,0,236,0,87,94,233,168,47,78,248,80,62,239,239,209,150,212,57,242,70,55,145,107,16,24,111,34,223,10,83,1,157,200,0,166,249,254,188,22,132,126,1,224,76,134,94,170,2,0,0 };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9");
			Version = 0;
			PackageUId = new Guid("5be3998b-c5c3-42bb-a01c-2e4149059a97");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("26fa5f17-c6cd-4623-a163-2f48820e59d9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateChunkSizeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1b3af3d1-3495-4770-a9fc-c62235bec979"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Name = @"ChunkSize",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"500",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateChunkProcessingDelayParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4977bd75-708c-4914-8b07-bbd248542368"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Name = @"ChunkProcessingDelay",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"500",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateMaxDegreeOfParallelismParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4c37a499-b647-4d81-8556-a993a95d3fb3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Name = @"MaxDegreeOfParallelism",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"2",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateSuccessMessageForObjectsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("109d42aa-b651-4f3f-b885-db06517bd3b0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Name = @"SuccessMessageForObjects",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateFromDateParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("64e4e2c4-c386-4af0-bca1-f931ffdf45dd"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Name = @"FromDate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEndDateParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("02685588-f8ca-4440-8250-15b2d3b51b93"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Name = @"EndDate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSuccessMessageForOneObjectParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("504957be-b628-4a73-af72-b03a3f3996a5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Name = @"SuccessMessageForOneObject",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateErrorMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a433e6b5-e02f-46b9-a11f-b4b74a05f3f5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Name = @"ErrorMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEntitySchemaUIdParameter());
			Parameters.Add(CreateChunkSizeParameter());
			Parameters.Add(CreateChunkProcessingDelayParameter());
			Parameters.Add(CreateMaxDegreeOfParallelismParameter());
			Parameters.Add(CreateSuccessMessageForObjectsParameter());
			Parameters.Add(CreateFromDateParameter());
			Parameters.Add(CreateEndDateParameter());
			Parameters.Add(CreateSuccessMessageForOneObjectParameter());
			Parameters.Add(CreateErrorMessageParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaStartEvent startcleaningevent = CreateStartCleaningEventStartEvent();
			FlowElements.Add(startcleaningevent);
			ProcessSchemaTerminateEvent endcleaningevent = CreateEndCleaningEventTerminateEvent();
			FlowElements.Add(endcleaningevent);
			ProcessSchemaScriptTask clearchangelogscripttask = CreateClearChangeLogScriptTaskScriptTask();
			FlowElements.Add(clearchangelogscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("100803b7-baf5-4019-9582-bfa3746f14f8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("5be3998b-c5c3-42bb-a01c-2e4149059a97"),
				CreatedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("117f5545-db57-45ab-9b79-f24841f9295f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("54e03f6b-018e-4e79-9be4-c1a92091bcff"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("55b39004-9198-4410-bd5f-d54582ca10b6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("5be3998b-c5c3-42bb-a01c-2e4149059a97"),
				CreatedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("54e03f6b-018e-4e79-9be4-c1a92091bcff"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cc285ab6-9731-496f-97c9-d5ec42c92035"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("e9e7a486-3d8f-4b22-b180-2398894c2841"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("5be3998b-c5c3-42bb-a01c-2e4149059a97"),
				CreatedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("16d6f549-e19f-492d-af27-7ad3c88986f9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9e7a486-3d8f-4b22-b180-2398894c2841"),
				CreatedInOwnerSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				CreatedInPackageId = new Guid("5be3998b-c5c3-42bb-a01c-2e4149059a97"),
				CreatedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStartCleaningEventStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("117f5545-db57-45ab-9b79-f24841f9295f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("16d6f549-e19f-492d-af27-7ad3c88986f9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("5be3998b-c5c3-42bb-a01c-2e4149059a97"),
				CreatedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Name = @"StartCleaningEvent",
				Position = new Point(53, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = true
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateEndCleaningEventTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("cc285ab6-9731-496f-97c9-d5ec42c92035"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("16d6f549-e19f-492d-af27-7ad3c88986f9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("5be3998b-c5c3-42bb-a01c-2e4149059a97"),
				CreatedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Name = @"EndCleaningEvent",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateClearChangeLogScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("54e03f6b-018e-4e79-9be4-c1a92091bcff"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("16d6f549-e19f-492d-af27-7ad3c88986f9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("5be3998b-c5c3-42bb-a01c-2e4149059a97"),
				CreatedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"),
				Name = @"ClearChangeLogScriptTask",
				Position = new Point(299, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = true,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,148,81,111,155,48,16,199,159,19,41,223,193,226,9,164,136,15,176,172,141,180,132,86,149,150,53,90,218,167,106,15,158,185,128,87,48,213,217,164,101,85,191,251,206,24,72,128,84,171,212,39,100,251,254,191,59,223,255,204,129,35,3,101,164,169,118,34,133,156,223,223,196,236,130,153,84,234,240,26,204,215,235,82,198,151,190,23,245,35,188,96,49,155,30,72,185,199,34,95,115,3,39,10,187,188,147,57,144,234,170,57,237,194,65,197,118,205,206,135,71,238,180,139,22,41,87,9,124,47,146,85,6,92,1,146,76,193,51,91,13,182,253,142,117,175,1,87,133,82,32,140,44,20,17,251,27,94,96,201,67,106,184,74,75,245,184,147,127,123,101,73,101,72,223,29,121,239,43,183,88,8,208,90,170,100,13,25,175,222,129,12,162,206,243,54,252,101,13,9,2,220,238,183,28,121,150,65,38,117,62,38,158,143,171,153,214,175,135,95,76,183,78,105,218,211,6,41,47,203,41,63,79,236,45,221,70,24,229,79,166,162,115,185,103,254,104,4,46,152,69,185,152,128,189,206,166,147,35,147,16,84,204,29,114,241,8,177,211,104,223,102,159,140,114,92,21,152,115,115,180,200,109,211,29,118,165,176,13,217,56,1,133,221,254,254,67,54,105,103,210,27,131,76,195,56,173,245,191,185,226,235,104,108,223,108,5,135,193,60,111,184,34,62,158,54,241,191,99,18,70,99,64,203,206,138,36,129,216,21,75,208,51,169,108,142,27,165,13,87,2,190,85,84,216,176,185,159,238,148,2,151,223,11,230,189,122,194,31,60,135,186,125,179,105,251,174,150,196,231,104,182,128,178,176,47,187,125,177,214,225,24,246,188,204,140,223,198,6,108,201,186,197,50,80,101,150,177,47,157,98,113,10,165,151,220,33,187,87,253,81,98,35,32,160,193,106,96,178,237,67,196,69,234,235,122,12,47,71,127,129,208,126,177,62,158,159,222,109,126,172,169,30,161,201,142,214,63,33,151,42,166,62,250,77,191,221,112,9,110,68,202,252,232,69,192,147,181,156,129,27,241,190,100,108,69,132,88,96,99,132,27,212,137,73,177,120,118,45,71,48,37,42,102,176,132,197,63,250,74,44,194,87,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("81d242c0-9e1f-4163-bdb5-6fec8e0fde36"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("bc8d52c3-aa32-46e3-b866-46f89b82bd0e"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41de0eb7-ec82-48bb-8c08-d8ccc2832bef"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7c855e7c-512d-4e7f-b879-f6cfb471b27d"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("05be42a5-957c-4481-8da3-aefbf9fe66be"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("90f6f376-b70c-4991-9fdf-6a79419bae77"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8c3dd43e-9218-4323-b156-79d6eab16e55"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new ClearObjectChangeLogProcess(userConnection);
		}

		public override object Clone() {
			return new ClearObjectChangeLogProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fc3af9e0-a16e-4002-861b-8940856017f9"));
		}

		#endregion

	}

	#endregion

	#region Class: ClearObjectChangeLogProcessMethodsWrapper

	/// <exclude/>
	public class ClearObjectChangeLogProcessMethodsWrapper : ProcessModel
	{

		public ClearObjectChangeLogProcessMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ClearChangeLogScriptTaskExecute", ClearChangeLogScriptTaskExecute);
		}

		#region Methods: Private

		private bool ClearChangeLogScriptTaskExecute(ProcessExecutingContext context) {
			var entitySchemaUId = this.Get<Guid>("EntitySchemaUId");
			var fromDate= this.Get<DateTime>("FromDate");
			var endDate = this.Get<DateTime>("EndDate");
			var changeLogCleaner = new ChangeLogCleaner(this.Get<UserConnection>("UserConnection"));
			changeLogCleaner.ChunkSize = this.Get<int>("ChunkSize");
			changeLogCleaner.ChunkProcessingDelay = this.Get<int>("ChunkProcessingDelay");
			changeLogCleaner.MaxDegreeOfParallelism = this.Get<int>("MaxDegreeOfParallelism");
			Guid[] schemaUIds;
			string message = string.Empty;
			if (entitySchemaUId == Guid.Empty) {
				schemaUIds = GetTrackedSchemas();
				message = string.Format(this.Get<string>("SuccessMessageForObjects"));
			} else {
				schemaUIds = new Guid[] { entitySchemaUId };
				var entitySchemaManager = this.Get<UserConnection>("UserConnection").EntitySchemaManager;
				var loggedObject = entitySchemaManager.GetInstanceByUId(entitySchemaUId);
				message = string.Format(this.Get<string>("SuccessMessageForOneObject"), loggedObject.Name);
			}
			DateTime? startPeriod = fromDate == default(DateTime) ? (DateTime?)null : fromDate;
			DateTime? endPeriod = endDate == default(DateTime) ? (DateTime?)null : endDate;
			try {
				schemaUIds.ForEach(sUId => changeLogCleaner.Clear(sUId, startPeriod, endPeriod));
				SendReminding(message);
			} catch (Exception e) {
				SendReminding(this.Get<string>("ErrorMessage"));
				throw;
			}
			return true;
		}

			private Guid[] GetTrackedSchemas() {
				var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "VwLogObjects") {
					UseAdminRights = false
				};
				EntitySchemaQueryColumn schemaUIdColumn = esq.AddColumn("UId");
				esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal,
					"SysWorkspace", UserConnection.Workspace.Id));
				EntityCollection entities = esq.GetEntityCollection(UserConnection);
				return entities.Select(e =>e.GetTypedColumnValue<Guid>(schemaUIdColumn.Name)).ToArray();
			}
					
			public virtual void SendReminding(string message) {
				RemindingServerUtilities.CreateRemindingByProcess(UserConnection, "ClearObjectChangeLogProcess", message);
			}

		#endregion

	}

	#endregion

	#region Class: ClearObjectChangeLogProcess

	/// <exclude/>
	public class ClearObjectChangeLogProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, ClearObjectChangeLogProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public ClearObjectChangeLogProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ClearObjectChangeLogProcess";
			SchemaUId = new Guid("fc3af9e0-a16e-4002-861b-8940856017f9");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			ProcessModel = new ClearObjectChangeLogProcessMethodsWrapper(this);
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fc3af9e0-a16e-4002-861b-8940856017f9");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: ClearObjectChangeLogProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: ClearObjectChangeLogProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		private string _successMessageForObjects;
		public virtual string SuccessMessageForObjects {
			get {
				return _successMessageForObjects ?? (_successMessageForObjects = GetLocalizableString("fc3af9e0a16e4002861b8940856017f9",
						 "Parameters.SuccessMessageForObjects.Value"));
			}
			set {
				_successMessageForObjects = value;
			}
		}

		public virtual DateTime FromDate {
			get;
			set;
		}

		public virtual DateTime EndDate {
			get;
			set;
		}

		private string _successMessageForOneObject;
		public virtual string SuccessMessageForOneObject {
			get {
				return _successMessageForOneObject ?? (_successMessageForOneObject = GetLocalizableString("fc3af9e0a16e4002861b8940856017f9",
						 "Parameters.SuccessMessageForOneObject.Value"));
			}
			set {
				_successMessageForOneObject = value;
			}
		}

		private string _errorMessage;
		public virtual string ErrorMessage {
			get {
				return _errorMessage ?? (_errorMessage = GetLocalizableString("fc3af9e0a16e4002861b8940856017f9",
						 "Parameters.ErrorMessage.Value"));
			}
			set {
				_errorMessage = value;
			}
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessFlowElement _startCleaningEvent;
		public ProcessFlowElement StartCleaningEvent {
			get {
				return _startCleaningEvent ?? (_startCleaningEvent = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "StartCleaningEvent",
					SchemaElementUId = new Guid("117f5545-db57-45ab-9b79-f24841f9295f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessTerminateEvent _endCleaningEvent;
		public ProcessTerminateEvent EndCleaningEvent {
			get {
				return _endCleaningEvent ?? (_endCleaningEvent = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "EndCleaningEvent",
					SchemaElementUId = new Guid("cc285ab6-9731-496f-97c9-d5ec42c92035"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _clearChangeLogScriptTask;
		public ProcessScriptTask ClearChangeLogScriptTask {
			get {
				return _clearChangeLogScriptTask ?? (_clearChangeLogScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ClearChangeLogScriptTask",
					SchemaElementUId = new Guid("54e03f6b-018e-4e79-9be4-c1a92091bcff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ProcessModel.GetScriptTaskMethod("ClearChangeLogScriptTaskExecute"),
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[StartCleaningEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { StartCleaningEvent };
			FlowElements[EndCleaningEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { EndCleaningEvent };
			FlowElements[ClearChangeLogScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ClearChangeLogScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "StartCleaningEvent":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ClearChangeLogScriptTask", e.Context.SenderName));
						break;
					case "EndCleaningEvent":
						CompleteProcess();
						break;
					case "ClearChangeLogScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("EndCleaningEvent", e.Context.SenderName));
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
			if (!HasMapping("SuccessMessageForObjects")) {
				writer.WriteValue("SuccessMessageForObjects", SuccessMessageForObjects, null);
			}
			if (!HasMapping("FromDate")) {
				writer.WriteValue("FromDate", FromDate, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
			if (!HasMapping("EndDate")) {
				writer.WriteValue("EndDate", EndDate, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
			if (!HasMapping("SuccessMessageForOneObject")) {
				writer.WriteValue("SuccessMessageForOneObject", SuccessMessageForOneObject, null);
			}
			if (!HasMapping("ErrorMessage")) {
				writer.WriteValue("ErrorMessage", ErrorMessage, null);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartCleaningEvent", string.Empty));
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
			MetaPathParameterValues.Add("26fa5f17-c6cd-4623-a163-2f48820e59d9", () => EntitySchemaUId);
			MetaPathParameterValues.Add("1b3af3d1-3495-4770-a9fc-c62235bec979", () => ChunkSize);
			MetaPathParameterValues.Add("4977bd75-708c-4914-8b07-bbd248542368", () => ChunkProcessingDelay);
			MetaPathParameterValues.Add("4c37a499-b647-4d81-8556-a993a95d3fb3", () => MaxDegreeOfParallelism);
			MetaPathParameterValues.Add("109d42aa-b651-4f3f-b885-db06517bd3b0", () => SuccessMessageForObjects);
			MetaPathParameterValues.Add("64e4e2c4-c386-4af0-bca1-f931ffdf45dd", () => FromDate);
			MetaPathParameterValues.Add("02685588-f8ca-4440-8250-15b2d3b51b93", () => EndDate);
			MetaPathParameterValues.Add("504957be-b628-4a73-af72-b03a3f3996a5", () => SuccessMessageForOneObject);
			MetaPathParameterValues.Add("a433e6b5-e02f-46b9-a11f-b4b74a05f3f5", () => ErrorMessage);
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
				case "SuccessMessageForObjects":
					if (!hasValueToRead) break;
					SuccessMessageForObjects = reader.GetValue<System.String>();
				break;
				case "FromDate":
					if (!hasValueToRead) break;
					FromDate = reader.GetValue<System.DateTime>();
				break;
				case "EndDate":
					if (!hasValueToRead) break;
					EndDate = reader.GetValue<System.DateTime>();
				break;
				case "SuccessMessageForOneObject":
					if (!hasValueToRead) break;
					SuccessMessageForOneObject = reader.GetValue<System.String>();
				break;
				case "ErrorMessage":
					if (!hasValueToRead) break;
					ErrorMessage = reader.GetValue<System.String>();
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
			var cloneItem = (ClearObjectChangeLogProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

