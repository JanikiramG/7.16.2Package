namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
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
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Sync;
	using Terrasoft.Sync.Exchange;

	#region Class: SyncExchangeActivitiesProcessSchema

	/// <exclude/>
	public class SyncExchangeActivitiesProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SyncExchangeActivitiesProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SyncExchangeActivitiesProcessSchema(SyncExchangeActivitiesProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SyncExchangeActivitiesProcess";
			UId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a");
			CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = @"ru-RU";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = false;
			SerializeToMemory = false;
			Tag = @"Business Process";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,86,77,111,219,48,12,61,183,64,255,3,39,236,224,160,70,176,93,155,181,64,150,166,91,129,174,27,218,230,180,236,160,198,108,106,212,150,2,73,206,230,5,254,239,163,44,167,241,135,146,180,216,101,67,16,196,160,200,71,242,241,201,204,209,225,34,187,79,226,25,44,99,101,50,158,192,82,198,17,220,230,98,246,168,164,136,127,99,208,131,213,209,225,193,149,156,159,227,125,54,15,222,178,218,33,224,175,217,35,23,115,4,62,51,241,50,54,49,106,208,134,43,131,17,60,72,5,171,91,20,17,170,113,202,227,100,24,69,10,181,46,88,111,64,128,241,3,4,221,195,254,165,190,206,146,228,43,25,23,38,15,122,46,249,107,178,163,82,54,239,53,98,116,139,102,162,81,53,243,30,92,72,149,114,115,131,58,75,76,208,117,115,78,10,77,166,132,125,44,232,187,228,10,30,49,89,160,130,83,16,248,19,198,194,196,38,175,149,162,62,151,199,65,25,237,92,251,163,4,185,234,122,6,54,217,72,10,129,84,180,20,101,196,184,106,100,98,226,132,220,251,231,152,160,193,146,131,161,107,45,191,80,50,93,63,239,128,11,97,237,68,54,109,116,255,142,235,167,187,124,129,147,203,200,241,46,12,240,197,66,210,111,138,194,92,201,25,79,70,101,114,61,146,153,48,97,253,244,6,83,105,176,126,108,33,180,81,177,152,55,253,44,155,95,136,62,62,199,193,75,228,178,137,125,169,96,218,28,89,220,181,237,210,96,170,59,76,116,161,66,176,195,37,73,159,158,193,40,225,90,95,144,114,164,202,251,159,208,124,248,200,53,174,1,45,248,55,37,151,49,1,156,5,108,109,30,110,202,174,123,176,208,194,30,88,101,148,172,171,204,162,14,213,60,179,158,1,203,26,133,177,16,90,18,216,19,174,59,125,48,95,115,61,135,35,51,179,117,52,33,180,78,61,227,239,196,183,37,224,72,108,143,163,174,77,226,101,70,9,175,121,138,229,232,42,217,25,146,162,39,161,53,239,20,154,115,120,165,194,108,208,255,36,45,123,79,255,65,77,237,133,49,134,70,100,131,5,189,183,107,18,236,12,205,41,107,139,6,54,17,127,175,182,74,53,170,173,152,134,129,94,228,187,222,95,118,59,189,113,64,173,149,212,233,107,189,163,154,240,199,167,192,6,192,224,216,175,222,98,103,14,229,195,175,9,126,236,219,186,207,151,128,219,249,87,237,111,21,254,9,172,26,89,188,219,177,89,135,103,49,190,102,47,83,9,123,238,33,33,218,143,239,15,73,163,172,106,192,105,85,87,73,143,111,232,52,227,138,94,23,30,176,213,106,202,158,48,159,178,19,152,178,213,187,98,74,186,157,178,10,168,178,190,39,107,81,132,172,20,158,239,158,167,27,62,174,36,143,92,81,190,92,132,86,85,162,45,246,119,74,248,3,138,130,144,59,196,22,219,26,127,102,216,215,116,251,86,144,115,223,121,167,13,232,63,186,4,46,88,229,9,0,0 };
			RealUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a");
			Version = 0;
			PackageUId = new Guid("b8c22230-2173-426f-959e-be736709a63f");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateSenderEmailAddressParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1706a8e4-a8db-40dd-bcfe-70083813c584"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"SenderEmailAddress",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLoadResultParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f363e086-ca54-4a07-b6a4-f2d793380738"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"LoadResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCreateRemindingParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f4f43cc4-e123-4ce2-9acd-20ddaba5c641"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"CreateReminding",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedSetUserAddressParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("264bbae8-6f36-4dcf-94e7-82abf4ec9e24"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"NeedSetUserAddress",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateSyncActivitySuccessMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d17b41bd-be12-494e-934a-ba442230f54f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"SyncActivitySuccessMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateSenderEmailAddressParameter());
			Parameters.Add(CreateLoadResultParameter());
			Parameters.Add(CreateCreateRemindingParameter());
			Parameters.Add(CreateNeedSetUserAddressParameter());
			Parameters.Add(CreateSyncActivitySuccessMessageParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaScriptTask mainscripttask = CreateMainScriptTaskScriptTask();
			FlowElements.Add(mainscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("41f16446-2ae5-4ea4-ac7d-30b3c1e71a02"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("01fff802-295f-4649-9bca-a1af184a280f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("143c11fd-593c-4449-b58c-0f5cf0393adb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("e4a99538-e8d9-4f6d-a8d2-c4de8277151e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("143c11fd-593c-4449-b58c-0f5cf0393adb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("49cf4a4b-4e8c-49da-a7bb-669368c326fc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("9fc02540-1342-4ae4-bf1f-3768b697dea1"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("0744a239-2513-49f9-b6fa-459d7ee83ba3"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("9fc02540-1342-4ae4-bf1f-3768b697dea1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("01fff802-295f-4649-9bca-a1af184a280f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0744a239-2513-49f9-b6fa-459d7ee83ba3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"Start1",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("49cf4a4b-4e8c-49da-a7bb-669368c326fc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0744a239-2513-49f9-b6fa-459d7ee83ba3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"Terminate1",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateMainScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("143c11fd-593c-4449-b58c-0f5cf0393adb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0744a239-2513-49f9-b6fa-459d7ee83ba3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"MainScriptTask",
				Position = new Point(295, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,174,204,75,206,40,202,207,203,172,74,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,209,75,113,44,28,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ccf59d5b-a728-418e-9389-ed5f74140b3b"),
				Name = "Terrasoft.Sync.Exchange",
				Alias = "",
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e1699d33-d81c-428e-ab95-b9519e811946"),
				Name = "Terrasoft.Sync",
				Alias = "",
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2cc2de4d-4a49-4023-84e0-87f513f606fd"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7d06a26f-7484-42fa-a34a-a289a78da842"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7835e741-23c7-4f92-bfad-db3d847fa2ad"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c25553c6-8f82-4df6-aa2e-7aa7bdef3c27"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("405cd56e-8293-41da-83e9-a9cf9867a065")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("23df5e27-0cfa-4ef6-b0b4-19e72992cfcc"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SyncExchangeActivitiesProcess(userConnection);
		}

		public override object Clone() {
			return new SyncExchangeActivitiesProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"));
		}

		#endregion

	}

	#endregion

	#region Class: SyncExchangeActivitiesProcess

	/// <exclude/>
	public class SyncExchangeActivitiesProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SyncExchangeActivitiesProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public SyncExchangeActivitiesProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SyncExchangeActivitiesProcess";
			SchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = false;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: SyncExchangeActivitiesProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: SyncExchangeActivitiesProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual string SenderEmailAddress {
			get;
			set;
		}

		public virtual string LoadResult {
			get;
			set;
		}

		public virtual bool CreateReminding {
			get;
			set;
		}

		private LocalizableString _needSetUserAddress;
		public virtual LocalizableString NeedSetUserAddress {
			get {
				return _needSetUserAddress ?? (_needSetUserAddress = GetLocalizableString("e58738377f4e4bce93c30179fb72eb6a",
						 "Parameters.NeedSetUserAddress.Value"));
			}
			set {
				_needSetUserAddress = value;
			}
		}

		private LocalizableString _syncActivitySuccessMessage;
		public virtual LocalizableString SyncActivitySuccessMessage {
			get {
				return _syncActivitySuccessMessage ?? (_syncActivitySuccessMessage = GetLocalizableString("e58738377f4e4bce93c30179fb72eb6a",
						 "Parameters.SyncActivitySuccessMessage.Value"));
			}
			set {
				_syncActivitySuccessMessage = value;
			}
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
					SchemaElementUId = new Guid("01fff802-295f-4649-9bca-a1af184a280f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessTerminateEvent _terminate1;
		public ProcessTerminateEvent Terminate1 {
			get {
				return _terminate1 ?? (_terminate1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate1",
					SchemaElementUId = new Guid("49cf4a4b-4e8c-49da-a7bb-669368c326fc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _mainScriptTask;
		public ProcessScriptTask MainScriptTask {
			get {
				return _mainScriptTask ?? (_mainScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "MainScriptTask",
					SchemaElementUId = new Guid("143c11fd-593c-4449-b58c-0f5cf0393adb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = MainScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[MainScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { MainScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("MainScriptTask", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "MainScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("SenderEmailAddress")) {
				writer.WriteValue("SenderEmailAddress", SenderEmailAddress, null);
			}
			if (!HasMapping("LoadResult")) {
				writer.WriteValue("LoadResult", LoadResult, null);
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
			MetaPathParameterValues.Add("1706a8e4-a8db-40dd-bcfe-70083813c584", () => SenderEmailAddress);
			MetaPathParameterValues.Add("f363e086-ca54-4a07-b6a4-f2d793380738", () => LoadResult);
			MetaPathParameterValues.Add("f4f43cc4-e123-4ce2-9acd-20ddaba5c641", () => CreateReminding);
			MetaPathParameterValues.Add("264bbae8-6f36-4dcf-94e7-82abf4ec9e24", () => NeedSetUserAddress);
			MetaPathParameterValues.Add("d17b41bd-be12-494e-934a-ba442230f54f", () => SyncActivitySuccessMessage);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "SenderEmailAddress":
					if (!hasValueToRead) break;
					SenderEmailAddress = reader.GetValue<System.String>();
				break;
				case "LoadResult":
					if (!hasValueToRead) break;
					LoadResult = reader.GetValue<System.String>();
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

		public virtual bool MainScriptTaskExecute(ProcessExecutingContext context) {
			Synchronize();
			return true;
		}

			
			public virtual void Synchronize() {
				LogDebug($"Synchronize exchange activities started for {SenderEmailAddress}");
				if (SenderEmailAddress.IsNullOrEmpty()) {
					LogDebug($"Synchronize exchange activities error {NeedSetUserAddress}");
					FormatResult(NeedSetUserAddress);
					return;
				}
				var helper = new EntitySynchronizerHelper();
				helper.ClearEntitySynchronizer(UserConnection);
				ExchangeUtility.DeleteEmptyActivityFromActivitySynchronizer(UserConnection, ActivityConsts.TaskTypeUId);
				int appointmentLocalChangesCount, appointmentRemoteChangesCount;
				string appointmentResultMessage;
				LogDebug($"Synchronize exchange appointments started for {SenderEmailAddress}");
				ExchangeUtility.SyncExchangeItems(UserConnection, SenderEmailAddress, 
					() => ClassFactory.Get<BaseExchangeSyncProvider>("ExchangeAppointmentSyncProvider",
						new ConstructorArgument("userConnection", UserConnection),
						new ConstructorArgument("senderEmailAddress", SenderEmailAddress)),
					out appointmentResultMessage, out appointmentLocalChangesCount, out appointmentRemoteChangesCount, 
					ExchangeUtility.ActivitySyncProcessName);
				
				int taskLocalChangesCount, taskRemoteChangesCount;
				string taskResultMessage;
				LogDebug($"Synchronize exchange tasks started for {SenderEmailAddress}");
				ExchangeUtility.SyncExchangeItems(UserConnection, SenderEmailAddress, 
					() => ClassFactory.Get<BaseExchangeSyncProvider>("ExchangeTaskSyncProvider",
						new ConstructorArgument("userConnection", UserConnection),
						new ConstructorArgument("senderEmailAddress", SenderEmailAddress),
						new ConstructorArgument("settings", null)),
					out taskResultMessage, out taskLocalChangesCount, out taskRemoteChangesCount, 
					ExchangeUtility.ActivitySyncProcessName);
				string resultMessage;
				resultMessage = appointmentResultMessage;
				if (!string.IsNullOrEmpty(taskResultMessage)) {
					resultMessage += "; " + taskResultMessage;
				}
				if (!string.IsNullOrEmpty(resultMessage)) {
					LogDebug($"Exchange activities synchronization result for {SenderEmailAddress}: {resultMessage}");
					FormatResult(resultMessage);
					return;
				}
				LogDebug($"Synchronize exchange activities ended for {SenderEmailAddress}");
			}
			
			
			public virtual void FormatResult(string message) {
				string resultMessage = string.Format("{{\"key\": \"{0}\", \"message\": \"{1}\"}},", 
				SenderEmailAddress, message);
			LoadResult = string.Format("{{ \"Messages\": [{0}] }}", resultMessage);
			}
			
			public virtual void LogDebug(string message) {
				ExchangeUtility.Log.Debug(message);
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
			var cloneItem = (SyncExchangeActivitiesProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

