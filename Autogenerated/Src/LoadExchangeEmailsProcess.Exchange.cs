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

	#region Class: LoadExchangeEmailsProcessSchema

	/// <exclude/>
	public class LoadExchangeEmailsProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LoadExchangeEmailsProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LoadExchangeEmailsProcessSchema(LoadExchangeEmailsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LoadExchangeEmailsProcess";
			UId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42");
			CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93");
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
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,85,77,111,211,64,16,61,167,82,255,195,176,112,112,36,43,2,142,133,86,42,105,130,34,218,20,53,20,14,132,195,214,158,184,22,235,221,106,119,29,8,145,255,59,179,94,55,216,241,86,233,5,229,98,205,190,121,243,230,51,199,71,15,229,157,200,19,88,231,218,150,92,192,90,229,41,44,54,50,185,215,74,230,127,48,26,194,246,248,104,112,169,178,11,188,43,179,232,21,107,61,2,254,78,238,185,204,232,163,224,185,48,96,44,215,22,83,88,41,13,219,5,202,20,245,196,189,156,167,169,70,99,42,54,124,71,100,249,10,34,99,117,46,179,209,204,204,75,33,174,9,245,96,55,81,223,99,232,195,63,55,62,106,237,34,207,17,211,5,218,91,131,186,27,121,48,85,186,224,246,6,77,41,108,212,135,121,144,70,91,106,233,62,171,70,173,131,140,149,148,152,216,92,201,209,71,180,51,51,69,78,48,156,72,126,39,48,141,88,45,123,38,45,102,154,59,212,215,183,44,160,190,143,130,149,39,2,244,76,49,204,92,138,11,146,67,239,190,164,144,112,33,14,214,117,176,230,26,76,203,247,20,198,130,27,51,229,137,85,122,227,100,191,111,115,159,53,162,89,12,18,127,1,37,72,93,41,29,246,92,103,101,129,210,70,172,76,232,181,155,254,48,118,177,6,79,186,152,158,62,162,8,181,182,214,220,210,59,90,184,92,35,111,111,213,172,83,15,199,115,176,16,221,14,190,164,22,206,39,95,166,55,231,87,147,111,215,55,159,200,228,199,15,116,61,8,87,228,201,51,172,71,83,90,16,138,170,61,174,231,202,140,85,41,109,76,184,66,89,108,219,28,120,210,76,223,173,205,69,110,55,35,39,243,209,54,179,88,152,189,185,9,85,33,6,167,151,182,236,244,172,223,172,15,220,224,35,161,35,255,172,213,58,39,2,215,184,198,92,115,181,223,216,129,238,148,29,73,255,173,185,7,104,132,226,105,141,55,83,173,138,11,110,145,104,46,123,198,67,52,46,25,218,96,75,189,116,58,36,221,146,161,247,81,165,237,118,55,6,103,10,244,214,35,247,251,91,147,236,55,248,234,95,173,19,98,157,243,2,119,7,237,69,240,162,117,36,132,206,193,254,1,221,29,183,250,58,52,41,60,57,238,39,176,237,68,8,158,185,174,134,208,126,16,113,190,122,254,149,127,206,10,238,34,80,0,247,11,253,205,116,84,54,27,89,52,50,235,74,133,182,148,142,90,83,105,239,30,177,237,118,201,126,226,102,201,78,96,201,182,175,171,37,77,194,146,53,68,141,245,13,89,171,42,102,126,221,66,107,88,180,234,227,6,209,203,10,69,35,190,70,139,113,236,223,41,228,15,168,42,22,67,175,210,213,83,169,239,42,29,74,123,127,236,8,60,242,232,150,200,234,47,253,7,198,6,187,7,0,0 };
			RealUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42");
			Version = 0;
			PackageUId = new Guid("b8c22230-2173-426f-959e-be736709a63f");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateSenderEmailAddressParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("82543a97-c9a8-4beb-941d-8ef4b3f14761"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Name = @"SenderEmailAddress",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLoadResultParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("378fb237-3b1a-409e-a4b7-b409772eb5d8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Name = @"LoadResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCreateRemindingParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e736a65f-4d19-4d0b-be8f-fba81c125580"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Name = @"CreateReminding",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedSetUserAddressParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7468e799-61c5-41b3-9071-7396ff10fa12"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93"),
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Name = @"NeedSetUserAddress",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateSuccessLoadEmailsMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("68c595cd-9fa1-477c-bdbc-d7a5686bdcff"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Name = @"SuccessLoadEmailsMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLoadEmailsFromDateParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("23032bb7-f14e-4c42-8f0e-f0de93e358ae"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Name = @"LoadEmailsFromDate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateSenderEmailAddressParameter());
			Parameters.Add(CreateLoadResultParameter());
			Parameters.Add(CreateCreateRemindingParameter());
			Parameters.Add(CreateNeedSetUserAddressParameter());
			Parameters.Add(CreateSuccessLoadEmailsMessageParameter());
			Parameters.Add(CreateLoadEmailsFromDateParameter());
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
			ProcessSchemaScriptTask loadexchangeemailscripttask = CreateLoadExchangeEmailScriptTaskScriptTask();
			FlowElements.Add(loadexchangeemailscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("2178232f-0167-4c4f-8412-e10940f40071"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93"),
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c810b5c3-95d5-43bb-93e2-f16b7b84f0a3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ceaf2735-60b0-4ba1-8c27-a604399b7531"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("fc9c113d-852c-4c28-a48a-79195b92ef4a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93"),
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ceaf2735-60b0-4ba1-8c27-a604399b7531"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3c7ed91d-008c-4351-b8ab-13fff632de5a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("deba005a-95f2-4bf3-b2c9-7320be29feda"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93"),
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("366e12ec-8725-426c-9436-7be163ac6e66"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("deba005a-95f2-4bf3-b2c9-7320be29feda"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93"),
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("c810b5c3-95d5-43bb-93e2-f16b7b84f0a3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("366e12ec-8725-426c-9436-7be163ac6e66"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93"),
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
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
				UId = new Guid("3c7ed91d-008c-4351-b8ab-13fff632de5a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("366e12ec-8725-426c-9436-7be163ac6e66"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93"),
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Name = @"Terminate1",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateLoadExchangeEmailScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ceaf2735-60b0-4ba1-8c27-a604399b7531"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("366e12ec-8725-426c-9436-7be163ac6e66"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93"),
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Name = @"LoadExchangeEmailScriptTask",
				Position = new Point(274, 170),
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
				UId = new Guid("7ef76fa2-afb6-4ff1-b0d8-05122e2a708b"),
				Name = "Terrasoft.Sync.Exchange",
				Alias = "",
				CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("da06c9d8-9a38-4073-bc77-89b836cb6504"),
				Name = "Terrasoft.Sync",
				Alias = "",
				CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("261eafa1-808b-4377-aeb5-67d29bcc8923"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("bf52bc50-6b05-4e41-90f3-592b01faa181"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1e203cd8-80e1-4a0d-a0e2-4733b9d9e4d4"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a87ff3b8-7f79-4ef2-8410-8ae2fea47c7e"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("af45d813-3b4d-4c55-bf0a-04fba228af5d"),
				Name = "IntegrationApi.Interfaces",
				Alias = "",
				CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LoadExchangeEmailsProcess(userConnection);
		}

		public override object Clone() {
			return new LoadExchangeEmailsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"));
		}

		#endregion

	}

	#endregion

	#region Class: LoadExchangeEmailsProcess

	/// <exclude/>
	public class LoadExchangeEmailsProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, LoadExchangeEmailsProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public LoadExchangeEmailsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LoadExchangeEmailsProcess";
			SchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: LoadExchangeEmailsProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: LoadExchangeEmailsProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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
				return _needSetUserAddress ?? (_needSetUserAddress = GetLocalizableString("ed2b4c2d5943414584487d829df84c42",
						 "Parameters.NeedSetUserAddress.Value"));
			}
			set {
				_needSetUserAddress = value;
			}
		}

		private LocalizableString _successLoadEmailsMessage;
		public virtual LocalizableString SuccessLoadEmailsMessage {
			get {
				return _successLoadEmailsMessage ?? (_successLoadEmailsMessage = GetLocalizableString("ed2b4c2d5943414584487d829df84c42",
						 "Parameters.SuccessLoadEmailsMessage.Value"));
			}
			set {
				_successLoadEmailsMessage = value;
			}
		}

		public virtual DateTime LoadEmailsFromDate {
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
					SchemaElementUId = new Guid("c810b5c3-95d5-43bb-93e2-f16b7b84f0a3"),
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
					SchemaElementUId = new Guid("3c7ed91d-008c-4351-b8ab-13fff632de5a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _loadExchangeEmailScriptTask;
		public ProcessScriptTask LoadExchangeEmailScriptTask {
			get {
				return _loadExchangeEmailScriptTask ?? (_loadExchangeEmailScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "LoadExchangeEmailScriptTask",
					SchemaElementUId = new Guid("ceaf2735-60b0-4ba1-8c27-a604399b7531"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = LoadExchangeEmailScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[LoadExchangeEmailScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LoadExchangeEmailScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LoadExchangeEmailScriptTask", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "LoadExchangeEmailScriptTask":
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
			if (!HasMapping("LoadEmailsFromDate")) {
				writer.WriteValue("LoadEmailsFromDate", LoadEmailsFromDate, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
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
			MetaPathParameterValues.Add("82543a97-c9a8-4beb-941d-8ef4b3f14761", () => SenderEmailAddress);
			MetaPathParameterValues.Add("378fb237-3b1a-409e-a4b7-b409772eb5d8", () => LoadResult);
			MetaPathParameterValues.Add("e736a65f-4d19-4d0b-be8f-fba81c125580", () => CreateReminding);
			MetaPathParameterValues.Add("7468e799-61c5-41b3-9071-7396ff10fa12", () => NeedSetUserAddress);
			MetaPathParameterValues.Add("68c595cd-9fa1-477c-bdbc-d7a5686bdcff", () => SuccessLoadEmailsMessage);
			MetaPathParameterValues.Add("23032bb7-f14e-4c42-8f0e-f0de93e358ae", () => LoadEmailsFromDate);
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
				case "LoadEmailsFromDate":
					if (!hasValueToRead) break;
					LoadEmailsFromDate = reader.GetValue<System.DateTime>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool LoadExchangeEmailScriptTaskExecute(ProcessExecutingContext context) {
			Synchronize();
			return true;
		}

			
			public virtual void Synchronize() {
				LogDebug($"Synchronize exchange emails started for {SenderEmailAddress}");
				if (string.IsNullOrEmpty(SenderEmailAddress)) {
					LogDebug($"Synchronize exchange emails error {NeedSetUserAddress}");
					FormatResult(NeedSetUserAddress);
					return;
				}
				if (UserConnection.GetIsFeatureEnabled("EmailIntegrationV2")) {
					LogDebug($"EmailIntegrationV2 feature enabled, ISyncSession start called for {SenderEmailAddress}");
					var syncSession = ClassFactory.Get<ISyncSession>("Email", new ConstructorArgument("uc", UserConnection),
						new ConstructorArgument("senderEmailAddress", SenderEmailAddress));
					syncSession.Start();
					LogDebug($"ISyncSession ended for {SenderEmailAddress}");
					return;
				}
				#if NETFRAMEWORK
				string resultMessage;
				int localChangesCount, remoteChangesCount;
				ExchangeUtility.SyncExchangeItems(UserConnection, SenderEmailAddress, 
					() => ClassFactory.Get<BaseExchangeSyncProvider>("ExchangeEmailSyncProvider",
						new ConstructorArgument("userConnection", UserConnection),
						new ConstructorArgument("senderEmailAddress", SenderEmailAddress),
						new ConstructorArgument("loadEmailsFromDate", LoadEmailsFromDate),
						new ConstructorArgument("userSettings", null)),
					out resultMessage, out localChangesCount, out remoteChangesCount,
					ExchangeUtility.MailSyncProcessName);
				if (!string.IsNullOrEmpty(resultMessage)) {
					LogDebug($"Exchange emails synchronization result for {SenderEmailAddress}: {resultMessage}");
					FormatResult(resultMessage);
					return;
				}
				#endif
				LogDebug($"Synchronize exchange emails ended for {SenderEmailAddress}");
				return;
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
			var cloneItem = (LoadExchangeEmailsProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

