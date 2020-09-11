namespace Terrasoft.Core.Process
{

	using IntegrationApi.Interfaces;
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
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Mail;

	#region Class: SyncImapMailSchema

	/// <exclude/>
	public class SyncImapMailSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SyncImapMailSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SyncImapMailSchema(SyncImapMailSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SyncImapMail";
			UId = new Guid("237dd150-53cf-4801-bd72-d517975107f8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = false;
			SerializeToMemory = true;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,83,0,0,69,207,108,233,1,0,0,0 };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8");
			Version = 0;
			PackageUId = new Guid("5be3998b-c5c3-42bb-a01c-2e4149059a97");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreatePageInstanceIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a54165a0-7744-4599-95de-a742bd292b40"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"PageInstanceId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateActiveTreeGridCurrentRowIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("57e04ecc-eb57-43da-bb56-54c46c31c8d3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"ActiveTreeGridCurrentRowId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMailUserNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("97325781-b945-49f7-8732-c6cfdd3aebc1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"MailUserName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSenderEmailAddressParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5cda26a9-50cc-4292-9c8a-84b7533a2e06"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"SenderEmailAddress",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentUserIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("294c50f3-a39f-4a40-a91e-58e6766978b9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"CurrentUserId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLoadEmailsFromDateParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ed3fa5d3-4777-4bfb-95e1-e80decf6e0a9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"LoadEmailsFromDate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCreateRemindingParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7f27c14c-c3e5-4e1c-9b16-b0f669ff0e28"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"CreateReminding",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreatePageInstanceIdParameter());
			Parameters.Add(CreateActiveTreeGridCurrentRowIdParameter());
			Parameters.Add(CreateMailUserNameParameter());
			Parameters.Add(CreateSenderEmailAddressParameter());
			Parameters.Add(CreateCurrentUserIdParameter());
			Parameters.Add(CreateLoadEmailsFromDateParameter());
			Parameters.Add(CreateCreateRemindingParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaEndEvent end1 = CreateEnd1EndEvent();
			FlowElements.Add(end1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			FlowElements.Add(scripttask1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("adfc9151-77b2-4fe4-a87b-92ae60725da1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				CurveCenterPosition = new Point(373, 199),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1edb1620-1236-4a0a-91ef-2612ae3a0993"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8727a659-1a61-4eec-87bc-f4e360329497"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("1910142d-434b-41cb-9592-e2c24eee63bd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				CurveCenterPosition = new Point(373, 199),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9ac7eaae-3d0b-4972-89fe-e58baaedcc67"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1edb1620-1236-4a0a-91ef-2612ae3a0993"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("5d241632-5559-4887-b0c1-a279e8a744cf"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("13ec4d62-a0e8-4c2f-8f8a-cfefd74363e3"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("5d241632-5559-4887-b0c1-a279e8a744cf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("9ac7eaae-3d0b-4972-89fe-e58baaedcc67"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("13ec4d62-a0e8-4c2f-8f8a-cfefd74363e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"Start1",
				Position = new Point(57, 44),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd1EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("8727a659-1a61-4eec-87bc-f4e360329497"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("13ec4d62-a0e8-4c2f-8f8a-cfefd74363e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"End1",
				Position = new Point(246, 44),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1edb1620-1236-4a0a-91ef-2612ae3a0993"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("13ec4d62-a0e8-4c2f-8f8a-cfefd74363e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"ScriptTask1",
				Position = new Point(134, 30),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,86,77,111,219,56,16,61,187,64,255,3,163,94,100,192,171,118,179,105,15,77,227,194,181,157,174,22,205,71,35,183,123,44,104,105,146,112,65,145,14,73,197,209,22,249,239,29,146,178,37,203,86,91,31,2,4,70,76,206,188,55,243,200,121,244,11,118,77,14,206,167,179,100,54,58,159,140,174,38,135,223,94,145,151,47,201,236,98,114,65,198,87,103,127,28,29,190,62,122,67,158,63,187,167,138,104,72,11,5,51,120,48,228,132,144,47,26,212,88,10,1,169,97,82,68,19,106,232,87,202,11,152,149,11,56,163,130,222,128,138,62,130,137,133,54,84,164,240,161,60,167,57,132,65,178,6,9,250,132,106,82,127,223,64,56,246,148,184,167,64,24,203,21,103,200,58,222,248,126,112,66,62,22,44,139,166,249,194,148,228,125,107,247,109,187,196,198,118,20,103,200,48,21,134,153,50,73,111,33,167,159,11,80,37,185,115,159,39,68,192,146,108,237,134,45,188,102,64,213,241,0,165,234,245,130,51,202,248,92,62,36,165,72,19,48,134,137,27,29,244,145,208,193,71,163,44,27,75,94,228,34,12,44,162,213,165,123,247,146,106,189,148,42,219,29,97,137,18,80,247,216,17,174,42,208,29,60,141,184,75,169,204,47,131,144,57,73,62,253,50,44,214,137,161,202,204,120,7,109,2,34,3,53,205,49,99,187,188,83,198,13,40,109,227,67,191,50,86,64,13,248,245,127,153,185,189,164,10,181,177,65,161,95,28,203,124,65,21,211,82,216,59,18,77,239,10,202,157,228,65,82,234,81,150,51,241,69,48,131,135,27,12,54,175,78,255,137,104,155,250,115,46,151,174,213,137,92,10,46,105,134,199,142,117,24,85,192,83,209,79,5,157,115,112,69,148,226,86,73,193,254,167,246,106,62,49,237,142,99,29,144,237,69,71,239,141,131,227,200,224,88,121,102,116,133,196,173,236,154,42,155,131,36,182,39,172,48,195,19,100,148,107,146,54,254,247,227,217,138,8,109,98,161,81,115,18,90,206,108,62,125,64,107,49,82,97,252,214,224,106,244,156,201,135,122,41,236,247,201,119,108,173,1,128,242,96,63,152,236,171,143,60,28,92,185,229,176,134,175,50,123,104,164,225,129,79,138,108,208,10,178,215,179,104,139,181,186,85,249,19,230,136,169,42,223,105,163,144,117,64,228,252,63,36,26,86,89,189,239,228,119,133,38,143,131,117,202,134,7,182,199,128,60,186,184,199,227,117,93,26,221,43,43,184,107,116,204,209,107,78,105,138,77,185,67,122,55,3,165,168,150,215,38,178,98,71,113,156,211,133,245,180,127,228,60,89,229,13,157,240,136,182,70,194,238,115,121,15,85,96,235,120,7,13,37,170,68,131,23,119,233,52,25,169,155,34,199,98,167,15,41,44,220,177,4,5,102,147,76,130,38,66,26,114,75,239,129,216,198,9,77,83,89,8,111,100,216,144,253,104,92,145,104,229,171,216,85,117,36,216,143,119,37,247,196,84,154,15,195,122,215,61,79,175,250,30,208,111,19,69,151,43,255,221,23,233,207,10,201,95,139,26,7,61,243,188,224,252,66,185,71,171,190,36,237,234,27,188,245,187,107,209,29,235,169,84,159,208,97,182,196,109,16,245,163,153,76,92,109,97,135,72,127,75,109,246,109,235,176,106,171,137,99,95,148,78,28,38,204,22,200,95,59,64,236,139,163,121,39,204,92,74,190,133,115,180,3,103,245,32,237,135,244,122,23,210,246,156,237,41,214,27,143,138,194,227,223,11,132,99,215,207,159,217,11,209,242,35,251,51,73,159,162,29,227,49,123,75,207,194,192,17,199,194,192,141,114,158,254,245,48,168,46,139,155,91,247,211,66,107,220,216,53,185,113,82,239,15,43,44,52,3,59,100,200,139,229,22,54,118,53,111,56,102,41,238,182,140,216,121,74,103,134,222,227,13,232,53,170,245,7,228,175,164,2,236,88,184,167,234,216,107,244,59,191,70,55,108,158,85,150,244,51,45,226,205,152,97,136,212,221,74,108,136,176,91,149,206,228,198,245,177,214,91,127,235,87,71,215,42,55,178,255,219,242,172,191,58,77,26,23,165,169,206,15,224,189,152,161,167,11,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("699b2038-adc5-418a-bdd1-d4d0f094a7b3"),
				Name = "Terrasoft.Mail",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2a014b6d-9ec5-48df-a642-6190afc95cc5"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d3124134-245b-4f52-9d71-d7d3dc858b19"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8ebced27-c4ad-4322-bdc4-d34ece6c78e1"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb1fe6c6-00d9-494f-a471-a3a73bc90279"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("411c2ea8-1b30-46ea-8e80-a814bd7b2e00"),
				Name = "IntegrationApi.Interfaces",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SyncImapMail(userConnection);
		}

		public override object Clone() {
			return new SyncImapMailSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("237dd150-53cf-4801-bd72-d517975107f8"));
		}

		#endregion

	}

	#endregion

	#region Class: SyncImapMailMethodsWrapper

	/// <exclude/>
	public class SyncImapMailMethodsWrapper : ProcessModel
	{

		public SyncImapMailMethodsWrapper(Process process)
			: base(process) {
		}

		#region Methods: Private

			 

		#endregion

	}

	#endregion

	#region Class: SyncImapMail

	/// <exclude/>
	public class SyncImapMail : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SyncImapMail process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public SyncImapMail(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SyncImapMail";
			SchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			ProcessModel = new SyncImapMailMethodsWrapper(this);
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("237dd150-53cf-4801-bd72-d517975107f8");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: SyncImapMail, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: SyncImapMail, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual string PageInstanceId {
			get;
			set;
		}

		public virtual Guid ActiveTreeGridCurrentRowId {
			get;
			set;
		}

		public virtual string MailUserName {
			get;
			set;
		}

		public virtual string SenderEmailAddress {
			get;
			set;
		}

		public virtual Guid CurrentUserId {
			get;
			set;
		}

		public virtual DateTime LoadEmailsFromDate {
			get;
			set;
		}

		public virtual bool CreateReminding {
			get;
			set;
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessFlowElement _start1;
		public ProcessFlowElement Start1 {
			get {
				return _start1 ?? (_start1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "Start1",
					SchemaElementUId = new Guid("9ac7eaae-3d0b-4972-89fe-e58baaedcc67"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessEndEvent _end1;
		public ProcessEndEvent End1 {
			get {
				return _end1 ?? (_end1 = new ProcessEndEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEndEvent",
					Name = "End1",
					SchemaElementUId = new Guid("8727a659-1a61-4eec-87bc-f4e360329497"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("1edb1620-1236-4a0a-91ef-2612ae3a0993"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ScriptTask1Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[End1.SchemaElementUId] = new Collection<ProcessFlowElement> { End1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask1", e.Context.SenderName));
						break;
					case "End1":
						CompleteProcess();
						break;
					case "ScriptTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("End1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("PageInstanceId")) {
				writer.WriteValue("PageInstanceId", PageInstanceId, null);
			}
			if (!HasMapping("ActiveTreeGridCurrentRowId")) {
				writer.WriteValue("ActiveTreeGridCurrentRowId", ActiveTreeGridCurrentRowId, Guid.Empty);
			}
			if (!HasMapping("MailUserName")) {
				writer.WriteValue("MailUserName", MailUserName, null);
			}
			if (!HasMapping("SenderEmailAddress")) {
				writer.WriteValue("SenderEmailAddress", SenderEmailAddress, null);
			}
			if (!HasMapping("CurrentUserId")) {
				writer.WriteValue("CurrentUserId", CurrentUserId, Guid.Empty);
			}
			if (!HasMapping("LoadEmailsFromDate")) {
				writer.WriteValue("LoadEmailsFromDate", LoadEmailsFromDate, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
			if (!HasMapping("CreateReminding")) {
				writer.WriteValue("CreateReminding", CreateReminding, false);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("Start1", string.Empty));
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
			MetaPathParameterValues.Add("a54165a0-7744-4599-95de-a742bd292b40", () => PageInstanceId);
			MetaPathParameterValues.Add("57e04ecc-eb57-43da-bb56-54c46c31c8d3", () => ActiveTreeGridCurrentRowId);
			MetaPathParameterValues.Add("97325781-b945-49f7-8732-c6cfdd3aebc1", () => MailUserName);
			MetaPathParameterValues.Add("5cda26a9-50cc-4292-9c8a-84b7533a2e06", () => SenderEmailAddress);
			MetaPathParameterValues.Add("294c50f3-a39f-4a40-a91e-58e6766978b9", () => CurrentUserId);
			MetaPathParameterValues.Add("ed3fa5d3-4777-4bfb-95e1-e80decf6e0a9", () => LoadEmailsFromDate);
			MetaPathParameterValues.Add("7f27c14c-c3e5-4e1c-9b16-b0f669ff0e28", () => CreateReminding);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "PageInstanceId":
					if (!hasValueToRead) break;
					PageInstanceId = reader.GetValue<System.String>();
				break;
				case "ActiveTreeGridCurrentRowId":
					if (!hasValueToRead) break;
					ActiveTreeGridCurrentRowId = reader.GetValue<System.Guid>();
				break;
				case "MailUserName":
					if (!hasValueToRead) break;
					MailUserName = reader.GetValue<System.String>();
				break;
				case "SenderEmailAddress":
					if (!hasValueToRead) break;
					SenderEmailAddress = reader.GetValue<System.String>();
				break;
				case "CurrentUserId":
					if (!hasValueToRead) break;
					CurrentUserId = reader.GetValue<System.Guid>();
				break;
				case "LoadEmailsFromDate":
					if (!hasValueToRead) break;
					LoadEmailsFromDate = reader.GetValue<System.DateTime>();
				break;
				case "CreateReminding":
					if (!hasValueToRead) break;
					CreateReminding = reader.GetValue<System.Boolean>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			#if !NETSTANDARD2_0 // TODO CRM-42546 
			var secureText =  UserConnection.DataValueTypeManager.GetInstanceByName("SecureText") as SecureTextDataValueType;
			var currentUserId = CurrentUserId != Guid.Empty ? CurrentUserId : UserConnection.CurrentUser.Id;
			EntitySchemaQuery query = new EntitySchemaQuery(UserConnection.EntitySchemaManager, 
					"MailboxSyncSettings");
			query.AddColumn("UserName");
			query.AddColumn("UserPassword");
			query.AddColumn("MailServer.Address");
			query.AddColumn("MailServer.Port");
			query.AddColumn("MailServer.UseSSL");
			query.AddColumn("MailServer.IsStartTls");
			query.AddColumn("SenderEmailAddress");
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"SysAdminUnit.Id", currentUserId));
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"MailServer.AllowEmailDownloading", true));
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"EnableMailSynhronization", true));
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"SenderEmailAddress", SenderEmailAddress));
			var select = query.GetSelectQuery(UserConnection);
			 
			MailCredentials credentials = new MailCredentials();
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (var reader = select.ExecuteReader(dbExecutor)) {
					if (!reader.Read()) {
						var parameters = new Dictionary<string, object> {
							{ "SenderEmailAddress", SenderEmailAddress },
							{ "CurrentUserId", currentUserId }
						};
						var scheduler = ClassFactory.Get<Terrasoft.Mail.IImapSyncJobScheduler>();
						scheduler.RemoveSyncJob(UserConnection, parameters);
						throw new ArgumentException("user does not have mail account");
					}
					credentials.UserName = reader.GetColumnValue<string>(reader.GetName(0));
					string rawPassword = reader.GetColumnValue<string>(reader.GetName(1));
					if (!rawPassword.IsNullOrEmpty()) {
						credentials.UserPassword = secureText.GetValueForLoad(UserConnection, rawPassword).ToString();
					}
					credentials.Host = reader.GetColumnValue<string>(reader.GetName(2));
					credentials.Port = reader.GetColumnValue<int>(reader.GetName(3));
					credentials.UseSsl = reader.GetColumnValue<bool>(reader.GetName(4));
					credentials.StartTls = reader.GetColumnValue<bool>(reader.GetName(5));
					credentials.SenderEmailAddress = reader.GetColumnValue<string>(reader.GetName(6));
				}
			}
			#endif
			if (UserConnection.GetIsFeatureEnabled("EmailIntegrationV2")) {
				var syncSession = ClassFactory.Get<ISyncSession>("Email", new ConstructorArgument("uc", UserConnection),
					new ConstructorArgument("senderEmailAddress", SenderEmailAddress));
				syncSession.Start();
				return true;
			}
			#if !NETSTANDARD2_0 // TODO CRM-42546
			using (var imapSyncSession = ClassFactory.Get<IImapSyncSession>(
				new ConstructorArgument("userConnection", UserConnection),
				new ConstructorArgument("credentials", credentials))) {
				imapSyncSession.SyncImapMail();
			}
			#endif
			return true;
		}

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
			var cloneItem = (SyncImapMail)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

