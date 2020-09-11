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
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.Reports;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: LoadPrintMenuProcessSchema

	/// <exclude/>
	public class LoadPrintMenuProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LoadPrintMenuProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LoadPrintMenuProcessSchema(LoadPrintMenuProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LoadPrintMenuProcess";
			UId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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
			SerializeToMemory = true;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,86,109,111,226,56,16,254,204,74,251,31,188,249,80,5,53,68,45,165,165,28,215,187,131,0,21,82,219,173,26,184,126,168,86,39,3,134,102,27,226,200,113,216,114,183,253,239,55,182,243,254,66,187,42,13,216,158,121,102,230,153,241,100,62,127,242,195,133,235,44,209,206,97,60,196,46,218,81,103,133,110,40,94,221,18,47,212,155,232,191,207,159,26,59,204,208,22,150,232,10,137,93,132,3,52,35,140,225,128,174,185,57,159,154,143,100,97,81,143,51,234,6,102,242,67,72,14,113,64,44,234,186,100,201,29,234,245,1,202,89,35,93,66,125,185,66,94,232,186,202,128,180,128,125,223,194,203,103,2,86,230,1,97,0,228,41,61,211,38,65,0,223,242,212,124,116,248,243,13,93,98,87,44,29,111,163,207,108,16,93,59,155,144,97,41,45,197,230,220,113,29,238,144,192,124,164,236,37,240,241,146,200,253,107,70,67,191,217,143,109,50,226,83,198,131,212,71,48,158,134,86,192,165,219,45,245,82,224,107,194,109,34,212,70,152,99,61,239,178,241,43,40,183,116,21,186,228,65,185,162,32,141,132,13,64,58,28,95,164,39,119,85,96,1,103,192,11,90,98,95,200,67,108,225,214,187,195,91,242,107,177,221,44,255,77,85,75,225,105,246,62,200,250,173,193,150,165,12,106,69,122,109,240,108,139,111,177,135,55,132,149,179,11,182,30,202,114,122,138,226,195,250,125,140,188,182,118,95,84,210,154,7,235,182,36,47,205,151,234,195,180,97,173,175,32,73,27,204,137,62,114,228,46,102,251,223,21,235,6,162,139,239,32,250,7,242,79,13,116,232,184,13,165,143,132,13,48,194,67,230,129,194,83,41,101,223,204,25,181,165,166,222,20,73,242,49,35,51,170,251,237,195,162,205,254,155,162,111,77,25,129,194,64,122,154,13,228,120,229,178,143,174,97,227,58,132,219,31,196,169,157,174,128,105,143,252,64,98,91,87,74,79,90,230,88,203,27,149,16,226,134,219,89,132,171,44,96,108,72,89,82,144,239,152,121,136,132,170,140,41,24,190,247,107,124,85,39,149,154,249,91,2,202,145,206,65,98,243,186,207,196,245,69,1,145,87,21,67,108,53,183,175,85,232,11,142,98,167,51,94,107,103,237,73,183,109,245,172,22,60,187,173,78,103,124,210,186,180,46,59,173,179,142,213,27,143,78,187,214,224,252,68,107,38,28,102,73,84,181,59,175,229,242,33,47,85,73,73,146,254,175,146,130,32,189,19,243,92,124,53,18,218,55,17,205,104,120,7,125,221,252,27,187,33,65,127,74,63,204,241,214,231,123,244,91,165,99,213,72,85,222,9,214,42,58,138,57,113,188,213,148,147,237,112,15,170,122,129,142,102,252,166,65,71,71,17,78,67,175,13,241,42,235,239,207,159,229,214,83,48,86,3,148,24,205,228,170,33,94,123,230,96,181,210,45,184,147,156,136,247,163,0,210,163,130,51,138,137,204,80,16,67,52,142,209,95,218,145,134,142,235,146,148,209,65,137,108,174,28,141,4,75,187,7,193,168,245,198,206,252,163,29,199,119,50,133,210,160,165,27,136,179,144,164,185,120,83,223,111,136,184,1,65,117,245,124,57,180,218,231,189,241,164,213,105,119,47,90,157,222,201,69,107,216,29,92,180,218,103,35,235,188,55,28,119,39,227,118,182,158,63,72,81,201,185,119,98,2,14,234,162,90,99,240,63,9,75,69,37,159,226,1,255,240,17,127,133,33,233,99,211,143,48,142,10,145,68,157,35,94,91,113,96,133,253,25,222,36,123,130,148,233,200,64,11,74,93,228,4,35,178,27,191,250,12,70,34,21,102,126,68,147,54,85,10,62,238,164,234,75,177,186,57,29,1,130,178,218,111,100,15,84,23,144,55,228,142,252,144,41,206,107,90,73,51,45,4,88,37,5,29,150,138,87,185,252,54,39,140,110,7,108,179,208,79,140,182,209,237,26,167,231,23,121,108,160,36,131,11,171,220,233,224,59,126,29,239,136,199,33,60,200,212,139,105,59,27,15,187,209,216,83,102,13,58,147,246,213,39,158,172,151,226,225,45,252,130,91,165,65,199,210,162,252,217,48,70,174,242,167,241,56,251,165,46,39,7,188,155,6,115,223,133,33,27,124,19,247,170,175,138,45,158,4,98,189,126,93,253,201,33,93,184,175,204,137,22,16,87,22,76,8,16,51,39,44,72,11,227,133,236,35,34,178,247,227,62,145,148,161,84,207,220,98,182,125,138,244,161,189,103,224,99,231,254,7,227,69,86,95,66,12,0,0 };
			RealUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4");
			Version = 0;
			PackageUId = new Guid("5be3998b-c5c3-42bb-a01c-2e4149059a97");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateMenuParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8d814a0f-f49c-47b8-811a-9d7fcedd7c1f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Name = @"Menu",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysModuleIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("720ead89-8627-4304-a359-d709a91ead74"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Name = @"SysModuleId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateMenuParameter());
			Parameters.Add(CreateSysModuleIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet4 = CreateLaneSet4LaneSet();
			LaneSets.Add(schemaLaneSet4);
			ProcessSchemaLane schemaLane8 = CreateLane8Lane();
			schemaLaneSet4.Lanes.Add(schemaLane8);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaEndEvent end1 = CreateEnd1EndEvent();
			FlowElements.Add(end1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			FlowElements.Add(scripttask1);
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("f1217494-1fb3-445d-9f17-0fcfc701b6f6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				CurveCenterPosition = new Point(174, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("97ae99d0-c2e3-47dd-a4dd-8a6878366ee1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("776ac1f3-00bb-472b-a5ee-8a9a1b2a43be"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("99284bf7-21f1-4235-9ee8-97831b800760"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				CurveCenterPosition = new Point(324, 96),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("776ac1f3-00bb-472b-a5ee-8a9a1b2a43be"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b0634007-ed0b-46c9-860c-e2819299abfb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet4LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet4 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("22a03e1e-7d55-4798-a4f9-8501cbfc71d1"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Name = @"LaneSet4",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet4;
		}

		protected virtual ProcessSchemaLane CreateLane8Lane() {
			ProcessSchemaLane schemaLane8 = new ProcessSchemaLane(this) {
				UId = new Guid("b499f499-2977-45ce-aa15-281af0a76bba"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("22a03e1e-7d55-4798-a4f9-8501cbfc71d1"),
				CreatedInOwnerSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Name = @"Lane8",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane8;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("97ae99d0-c2e3-47dd-a4dd-8a6878366ee1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b499f499-2977-45ce-aa15-281af0a76bba"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Name = @"Start1",
				Position = new Point(57, 72),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd1EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("b0634007-ed0b-46c9-860c-e2819299abfb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b499f499-2977-45ce-aa15-281af0a76bba"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Name = @"End1",
				Position = new Point(316, 72),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("776ac1f3-00bb-472b-a5ee-8a9a1b2a43be"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b499f499-2977-45ce-aa15-281af0a76bba"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Name = @"ScriptTask1",
				Position = new Point(169, 58),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,201,79,76,241,77,205,43,213,208,180,230,229,2,49,20,108,21,242,74,115,114,128,188,162,212,146,210,162,60,133,146,162,210,84,107,0,71,19,235,36,39,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7a147170-d041-4a67-b3b1-c7ff2b70fef8"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1ea5759e-7be8-45c7-a793-b66f77ab8b4f"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b00609b8-3139-4513-8337-2a8cafd4a7fb"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("15406e8e-7657-422a-9d4c-760556f1a647"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LoadPrintMenuProcess(userConnection);
		}

		public override object Clone() {
			return new LoadPrintMenuProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"));
		}

		#endregion

	}

	#endregion

	#region Class: LoadPrintMenuProcess

	/// <exclude/>
	public class LoadPrintMenuProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane8

		/// <exclude/>
		public class ProcessLane8 : ProcessLane
		{

			public ProcessLane8(UserConnection userConnection, LoadPrintMenuProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public LoadPrintMenuProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LoadPrintMenuProcess";
			SchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4");
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
				return new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: LoadPrintMenuProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: LoadPrintMenuProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual Object Menu {
			get;
			set;
		}

		public virtual Guid SysModuleId {
			get;
			set;
		}

		private ProcessLane8 _lane8;
		public ProcessLane8 Lane8 {
			get {
				return _lane8 ?? ((_lane8) = new ProcessLane8(UserConnection, this));
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
					SchemaElementUId = new Guid("97ae99d0-c2e3-47dd-a4dd-8a6878366ee1"),
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
					SchemaElementUId = new Guid("b0634007-ed0b-46c9-860c-e2819299abfb"),
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
					SchemaElementUId = new Guid("776ac1f3-00bb-472b-a5ee-8a9a1b2a43be"),
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
			if (!HasMapping("SysModuleId")) {
				writer.WriteValue("SysModuleId", SysModuleId, Guid.Empty);
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
			MetaPathParameterValues.Add("8d814a0f-f49c-47b8-811a-9d7fcedd7c1f", () => Menu);
			MetaPathParameterValues.Add("720ead89-8627-4304-a359-d709a91ead74", () => SysModuleId);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "SysModuleId":
					if (!hasValueToRead) break;
					SysModuleId = reader.GetValue<System.Guid>();
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
			LoadMenu();
			Menu = null;
			return true;
		}

			
			public virtual void LoadMenu() {
				var menu = Menu as Terrasoft.UI.WebControls.Controls.MenuBaseCollection;
				if (menu != null) {
					var appCache = UserConnection.SessionCache.WithLocalCaching(TSConfiguration.CacheUtilities.WorkspaceCacheGroup);
					var reportsCollection = Terrasoft.Configuration.CommonUtilities.GetSelectData(UserConnection, Terrasoft.Configuration.CommonUtilities.GetModuleReportsSelect, appCache, TSConfiguration.CacheUtilities.ReportsCache);
					string captionColumnName = Terrasoft.Configuration.CommonUtilities.GetLczColumnName(UserConnection, "SysModuleReport", "Caption");
					var reportSchemaManager = UserConnection.GetReportSchemaManager();
					var pageSchemaManager = UserConnection.GetSchemaManager("PageSchemaManager") as Terrasoft.UI.WebControls.PageSchemaManager;
					reportsCollection.Sort(delegate(Dictionary<string, object> p1, Dictionary<string, object> p2) { 
						return p1[captionColumnName].ToString().CompareTo(p2[captionColumnName].ToString());});
					foreach (var report in reportsCollection) {
						Guid sysModuleId = new Guid(report["sysModuleId"].ToString());
						if (SysModuleId == sysModuleId) {
							Guid reportId = new Guid(report["sysModuleReportId"].ToString());
							Guid typeId = new Guid(report["typeId"].ToString());
							string caption = report[captionColumnName].ToString();
							string helpContextId = report["helpContextId"].ToString();
							if (typeId == new Guid("32F72C9C-72C7-44E0-8C84-34C9ED17CA50")) {
								Guid reportSchemaUId = new Guid(report["sysReportSchemaUId"].ToString());
								Guid sysOptionsPageSchemaUId = report["sysOptionsPageSchemaUId"] == DBNull.Value ? Guid.Empty : new Guid(report["sysOptionsPageSchemaUId"].ToString());
								if (reportSchemaManager.FindItemByUId(reportSchemaUId) != null &&
									(sysOptionsPageSchemaUId == Guid.Empty || pageSchemaManager.FindItemByUId(sysOptionsPageSchemaUId) != null)) {
									menu.Add(CreateMenuItem(caption, reportSchemaUId.ToString()
										+ @"&" + sysOptionsPageSchemaUId.ToString() + @"&" + helpContextId,
										"PrintReportMenuItem_"+reportId.ToString("n"), true));
								}
							} else if (typeId == new Guid("8BC259EF-4276-4906-B7A6-23DC59BE7FE2")) {
								menu.Add(CreateMenuItem(caption, reportId.ToString("n"),
										"PrintReportMenuItem_" + reportId.ToString("n"), false));
							}
						}
					}
				}
			}
			
			
			public virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateMenuItem(string MenuItemCaption, string MenuItemTag, string menuID, bool isDevExpressReport) {
				var menuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
				menuItem.ID = menuID;	
				menuItem.UId = Guid.NewGuid();
				menuItem.Caption = MenuItemCaption;
				menuItem.CaptionColor = Color.FromArgb(0,2,77,156);
				menuItem.Tag = MenuItemTag;
				menuItem.AjaxEvents.Click.SignalName = isDevExpressReport ? "OpenPrintDevExpressReportMessage" : "CreateMSWordReportMessage";
				if (!isDevExpressReport) {
					menuItem.AjaxEvents.Click.IsUpload = true;
				}
				return menuItem;
			}
			
			
			public virtual void OpenReportPage(string parameters) {
				var keyName = "PrintReportParameters";
				UserConnection.SessionData[keyName] = parameters;
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
			var cloneItem = (LoadPrintMenuProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			cloneItem.Menu = Menu;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

