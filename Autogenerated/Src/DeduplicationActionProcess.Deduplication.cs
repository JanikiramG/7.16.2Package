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
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: DeduplicationActionProcessSchema

	/// <exclude/>
	public class DeduplicationActionProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public DeduplicationActionProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public DeduplicationActionProcessSchema(DeduplicationActionProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "DeduplicationActionProcess";
			UId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666");
			CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.7.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,83,77,107,219,64,16,61,219,224,255,48,201,33,89,129,16,185,215,82,72,236,196,53,228,3,34,74,14,165,135,173,52,150,22,228,93,177,31,46,38,237,127,239,106,87,182,165,200,46,185,244,22,176,12,59,59,111,222,155,157,55,147,113,109,126,86,44,131,13,147,218,208,10,54,130,229,240,72,25,39,1,188,77,198,35,182,2,242,92,163,164,154,9,190,204,33,142,97,142,185,169,45,198,133,102,130,43,173,162,20,169,204,202,78,162,71,143,210,172,196,53,125,162,107,132,24,58,135,235,107,80,90,50,94,68,119,235,90,111,191,52,185,62,240,253,7,168,125,158,234,161,162,212,210,106,114,249,251,50,112,128,149,144,72,179,18,136,71,118,112,192,120,183,74,244,90,162,68,194,157,140,4,206,82,79,189,84,79,166,170,158,229,107,201,52,166,53,205,124,74,16,180,226,71,174,57,105,50,45,228,141,44,204,26,185,238,148,221,135,98,224,248,11,142,36,147,243,67,246,121,216,129,122,253,71,235,27,133,210,198,57,102,205,67,126,132,163,143,176,60,223,122,129,150,171,55,181,27,119,243,21,43,59,48,160,221,67,12,179,138,42,117,79,27,142,109,180,64,61,61,137,76,200,240,49,66,71,54,58,222,69,43,165,75,24,221,98,193,184,183,15,241,247,127,236,95,243,125,220,125,143,40,11,28,154,239,129,41,61,93,24,150,39,176,195,160,106,130,182,203,249,46,240,130,153,144,249,50,87,64,21,28,16,78,201,156,57,165,84,110,167,222,98,97,235,218,4,36,42,81,109,48,183,10,86,182,144,110,156,250,50,136,217,146,167,107,56,10,102,103,91,72,97,234,166,59,32,246,24,236,165,45,124,220,231,217,151,248,135,111,15,75,18,192,197,197,251,118,207,172,123,44,162,185,241,227,217,49,218,139,171,97,126,52,19,198,202,74,224,234,63,45,66,250,185,8,39,22,193,57,153,180,227,9,223,205,37,28,186,174,183,49,246,55,25,255,5,21,82,213,56,210,5,0,0 };
			RealUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666");
			Version = 0;
			PackageUId = new Guid("b5967e5d-641c-4d1f-ad1d-a02f69fcc776");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateSchemaNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b3039b1a-323a-4fee-b5d7-437acd810775"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"),
				Name = @"SchemaName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateOperationIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f007b958-c46e-4876-8331-220fd44c5f13"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"),
				Name = @"OperationId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDuplicateRecordIdsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8a830a8e-6b86-43e9-9f30-0bee4ad0ab01"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"),
				Name = @"DuplicateRecordIds",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDuplicateGroupIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("12e32a26-3adb-4e83-8022-cee5d7aca001"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"),
				Name = @"DuplicateGroupId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateResolvedConflictsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3872c3e8-715d-44c8-9718-782b83aca273"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"),
				Name = @"ResolvedConflicts",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateSchemaNameParameter());
			Parameters.Add(CreateOperationIdParameter());
			Parameters.Add(CreateDuplicateRecordIdsParameter());
			Parameters.Add(CreateDuplicateGroupIdParameter());
			Parameters.Add(CreateResolvedConflictsParameter());
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
				UId = new Guid("799ada9b-5721-4a7d-ad52-8698e17b1669"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7"),
				CreatedInSchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ee9e24df-15f7-43b8-bc2f-fda897bde191"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("df8220cf-a667-4938-ba9b-5e4a19232e43"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("b4fd70d0-fa55-42b7-806f-e2402e3ee028"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7"),
				CreatedInSchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("df8220cf-a667-4938-ba9b-5e4a19232e43"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("884985ea-3105-49b0-9fa8-d7bab09690f3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("d90ef81b-0a9d-4bf1-8858-6d5856b6c40d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7"),
				CreatedInSchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("6cb6819d-e37b-4f6d-a546-d74bbdb40e8b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d90ef81b-0a9d-4bf1-8858-6d5856b6c40d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7"),
				CreatedInSchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("ee9e24df-15f7-43b8-bc2f-fda897bde191"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cb6819d-e37b-4f6d-a546-d74bbdb40e8b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7"),
				CreatedInSchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"),
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
				UId = new Guid("884985ea-3105-49b0-9fa8-d7bab09690f3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cb6819d-e37b-4f6d-a546-d74bbdb40e8b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7"),
				CreatedInSchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"),
				Name = @"Terminate1",
				Position = new Point(680, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateMainScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("df8220cf-a667-4938-ba9b-5e4a19232e43"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cb6819d-e37b-4f6d-a546-d74bbdb40e8b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7"),
				CreatedInSchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"),
				Name = @"MainScriptTask",
				Position = new Point(340, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,77,204,204,211,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,176,217,148,41,21,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e7af5a8c-13a2-430e-9323-59fa83ba2875"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("99f8556b-9d3f-42f2-823e-784708f4f25b"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3669c994-a9bd-4e68-be31-75ce83e8ebbb"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c8636092-31d5-4e58-a47f-ac2a3230646c"),
				Name = "System",
				Alias = "",
				CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("203753cd-b2e5-42a2-ae80-455ece8c8a7a"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new DeduplicationActionProcess(userConnection);
		}

		public override object Clone() {
			return new DeduplicationActionProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666"));
		}

		#endregion

	}

	#endregion

	#region Class: DeduplicationActionProcess

	/// <exclude/>
	public class DeduplicationActionProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, DeduplicationActionProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public DeduplicationActionProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DeduplicationActionProcess";
			SchemaUId = new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("21b965c8-37af-4e87-ae30-b6cc5866d666");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: DeduplicationActionProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: DeduplicationActionProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual string SchemaName {
			get;
			set;
		}

		public virtual Guid OperationId {
			get;
			set;
		}

		public virtual Object DuplicateRecordIds {
			get;
			set;
		}

		public virtual Object DuplicateGroupId {
			get;
			set;
		}

		public virtual Object ResolvedConflicts {
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
					SchemaElementUId = new Guid("ee9e24df-15f7-43b8-bc2f-fda897bde191"),
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
					SchemaElementUId = new Guid("884985ea-3105-49b0-9fa8-d7bab09690f3"),
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
					SchemaElementUId = new Guid("df8220cf-a667-4938-ba9b-5e4a19232e43"),
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
			if (!HasMapping("SchemaName")) {
				writer.WriteValue("SchemaName", SchemaName, null);
			}
			if (!HasMapping("OperationId")) {
				writer.WriteValue("OperationId", OperationId, Guid.Empty);
			}
			if (DuplicateRecordIds != null) {
				if (DuplicateRecordIds.GetType().IsSerializable ||
					DuplicateRecordIds.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("DuplicateRecordIds", DuplicateRecordIds, null);
				}
			}
			if (DuplicateGroupId != null) {
				if (DuplicateGroupId.GetType().IsSerializable ||
					DuplicateGroupId.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("DuplicateGroupId", DuplicateGroupId, null);
				}
			}
			if (ResolvedConflicts != null) {
				if (ResolvedConflicts.GetType().IsSerializable ||
					ResolvedConflicts.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ResolvedConflicts", ResolvedConflicts, null);
				}
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
			MetaPathParameterValues.Add("b3039b1a-323a-4fee-b5d7-437acd810775", () => SchemaName);
			MetaPathParameterValues.Add("f007b958-c46e-4876-8331-220fd44c5f13", () => OperationId);
			MetaPathParameterValues.Add("8a830a8e-6b86-43e9-9f30-0bee4ad0ab01", () => DuplicateRecordIds);
			MetaPathParameterValues.Add("12e32a26-3adb-4e83-8022-cee5d7aca001", () => DuplicateGroupId);
			MetaPathParameterValues.Add("3872c3e8-715d-44c8-9718-782b83aca273", () => ResolvedConflicts);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "SchemaName":
					if (!hasValueToRead) break;
					SchemaName = reader.GetValue<System.String>();
				break;
				case "OperationId":
					if (!hasValueToRead) break;
					OperationId = reader.GetValue<System.Guid>();
				break;
				case "DuplicateRecordIds":
					if (!hasValueToRead) break;
					DuplicateRecordIds = reader.GetSerializableObjectValue();
				break;
				case "DuplicateGroupId":
					if (!hasValueToRead) break;
					DuplicateGroupId = reader.GetSerializableObjectValue();
				break;
				case "ResolvedConflicts":
					if (!hasValueToRead) break;
					ResolvedConflicts = reader.GetSerializableObjectValue();
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
			Main();
			return true;
		}

			
			public virtual void Main() {
				if (OperationId == DeduplicationConsts.SearchOperationId) {
					SchemaName = SchemaName ?? string.Empty;
					string[] schemaNames = SchemaName.Split('|');
					foreach (string schemaName in schemaNames.Where(name => !String.IsNullOrWhiteSpace(name))) {
						ConstructorArgument schemaNameArgument = new ConstructorArgument("schemaName", schemaName);
						ConstructorArgument userConnectionArgument = new ConstructorArgument("userConnection", UserConnection);
						DeduplicationActionHelper actionHelper = ClassFactory.Get<DeduplicationActionHelper>(schemaNameArgument,
							userConnectionArgument);
						actionHelper.BeginSearch();
					}
				}
				
				if (OperationId == DeduplicationConsts.MergeOperationId) {
					List<Guid> duplicatesList = DuplicateRecordIds as List<Guid>;
					Dictionary<string, string> resolvedConflicts = ResolvedConflicts as Dictionary<string, string>;
					int groupId = (int)DuplicateGroupId;
					if (!String.IsNullOrWhiteSpace(SchemaName) && duplicatesList != null && 
							groupId != 0 && duplicatesList.Count > 0) {
						ConstructorArgument schemaNameArgument = new ConstructorArgument("schemaName", SchemaName);
						ConstructorArgument userConnectionArgument = new ConstructorArgument("userConnection", UserConnection);
						DeduplicationActionHelper actionHelper = ClassFactory.Get<DeduplicationActionHelper>(schemaNameArgument,
							userConnectionArgument);
						actionHelper.BeginMerge(groupId, duplicatesList, resolvedConflicts);
					}
				}
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
			var cloneItem = (DeduplicationActionProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			cloneItem.DuplicateRecordIds = DuplicateRecordIds;
			cloneItem.DuplicateGroupId = DuplicateGroupId;
			cloneItem.ResolvedConflicts = ResolvedConflicts;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

