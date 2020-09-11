namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: VwSysSSPEntitySchemaAccessListSchema

	/// <exclude/>
	public class VwSysSSPEntitySchemaAccessListSchema : Terrasoft.Configuration.VwSysSSPEntitySchemaAccessList_Base_TerrasoftSchema
	{

		#region Constructors: Public

		public VwSysSSPEntitySchemaAccessListSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSysSSPEntitySchemaAccessListSchema(VwSysSSPEntitySchemaAccessListSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSysSSPEntitySchemaAccessListSchema(VwSysSSPEntitySchemaAccessListSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("613da198-638b-4cd0-aaca-88269a97165a");
			Name = "VwSysSSPEntitySchemaAccessList";
			ParentSchemaUId = new Guid("a7982d2c-1ee2-43ce-a6e1-43d6c67c5a51");
			ExtendParent = true;
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateSysSchemaColumn() {
			EntitySchemaColumn column = base.CreateSysSchemaColumn();
			column.RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel;
			column.ModifiedInSchemaUId = new Guid("613da198-638b-4cd0-aaca-88269a97165a");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwSysSSPEntitySchemaAccessListEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwSysSSPEntitySchemaAccessListEventsProcessSchema() {
			var schema = new VwSysSSPEntitySchemaAccessListEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSysSSPEntitySchemaAccessList(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSysSSPEntitySchemaAccessList_SSPEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSysSSPEntitySchemaAccessListSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSysSSPEntitySchemaAccessListSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("613da198-638b-4cd0-aaca-88269a97165a"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSysSSPEntitySchemaAccessList

	/// <summary>
	/// SSP Entity Schema Access List (View).
	/// </summary>
	public class VwSysSSPEntitySchemaAccessList : Terrasoft.Configuration.VwSysSSPEntitySchemaAccessList_Base_Terrasoft
	{

		#region Constructors: Public

		public VwSysSSPEntitySchemaAccessList(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSysSSPEntitySchemaAccessList";
		}

		public VwSysSSPEntitySchemaAccessList(VwSysSSPEntitySchemaAccessList source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSysSSPEntitySchemaAccessList_SSPEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("VwSysSSPEntitySchemaAccessListValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysSSPEntitySchemaAccessList(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysSSPEntitySchemaAccessList_SSPEventsProcess

	/// <exclude/>
	public partial class VwSysSSPEntitySchemaAccessList_SSPEventsProcess<TEntity> : Terrasoft.Configuration.VwSysSSPEntitySchemaAccessList_BaseEventsProcess<TEntity> where TEntity : VwSysSSPEntitySchemaAccessList
	{

		public VwSysSSPEntitySchemaAccessList_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysSSPEntitySchemaAccessList_SSPEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("613da198-638b-4cd0-aaca-88269a97165a");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _vwSysSSPEntitySchemaAccessListValidating;
		public ProcessFlowElement VwSysSSPEntitySchemaAccessListValidating {
			get {
				return _vwSysSSPEntitySchemaAccessListValidating ?? (_vwSysSSPEntitySchemaAccessListValidating = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "VwSysSSPEntitySchemaAccessListValidating",
					SchemaElementUId = new Guid("0bd8a217-3b18-472d-9d55-bc6cbc102db3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _vwSysSSPEntitySchemaAccessListValidatingScriptTask;
		public ProcessScriptTask VwSysSSPEntitySchemaAccessListValidatingScriptTask {
			get {
				return _vwSysSSPEntitySchemaAccessListValidatingScriptTask ?? (_vwSysSSPEntitySchemaAccessListValidatingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "VwSysSSPEntitySchemaAccessListValidatingScriptTask",
					SchemaElementUId = new Guid("ac24ae31-e0bc-4e83-8638-a29c16549e7a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = VwSysSSPEntitySchemaAccessListValidatingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[VwSysSSPEntitySchemaAccessListValidating.SchemaElementUId] = new Collection<ProcessFlowElement> { VwSysSSPEntitySchemaAccessListValidating };
			FlowElements[VwSysSSPEntitySchemaAccessListValidatingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { VwSysSSPEntitySchemaAccessListValidatingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "VwSysSSPEntitySchemaAccessListValidating":
						e.Context.QueueTasks.Enqueue("VwSysSSPEntitySchemaAccessListValidatingScriptTask");
						break;
					case "VwSysSSPEntitySchemaAccessListValidatingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "VwSysSSPEntitySchemaAccessListValidating":
					context.QueueTasks.Dequeue();
					context.SenderName = "VwSysSSPEntitySchemaAccessListValidating";
					result = VwSysSSPEntitySchemaAccessListValidating.Execute(context);
					break;
				case "VwSysSSPEntitySchemaAccessListValidatingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "VwSysSSPEntitySchemaAccessListValidatingScriptTask";
					result = VwSysSSPEntitySchemaAccessListValidatingScriptTask.Execute(context, VwSysSSPEntitySchemaAccessListValidatingScriptTaskExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
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

		#endregion

		#region Methods: Public

		public virtual bool VwSysSSPEntitySchemaAccessListValidatingScriptTaskExecute(ProcessExecutingContext context) {
			if (Entity.UserConnection.DBSecurityEngine.GetCanExecuteOperation("CanManageLookups")){
				return true;
			}
			return false;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: VwSysSSPEntitySchemaAccessList_SSPEventsProcess

	/// <exclude/>
	public class VwSysSSPEntitySchemaAccessList_SSPEventsProcess : VwSysSSPEntitySchemaAccessList_SSPEventsProcess<VwSysSSPEntitySchemaAccessList>
	{

		public VwSysSSPEntitySchemaAccessList_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysSSPEntitySchemaAccessList_SSPEventsProcess

	public partial class VwSysSSPEntitySchemaAccessList_SSPEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwSysSSPEntitySchemaAccessListEventsProcessSchema

	/// <exclude/>
	public class VwSysSSPEntitySchemaAccessListEventsProcessSchema : Terrasoft.Configuration.VwSysSSPEntitySchemaAccessList_Base_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public VwSysSSPEntitySchemaAccessListEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwSysSSPEntitySchemaAccessListEventsProcessSchema(VwSysSSPEntitySchemaAccessListEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwSysSSPEntitySchemaAccessList_SSPEventsProcess";
			UId = new Guid("4f304de3-7b3d-4c44-a3af-d73d3915a242");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet2_3e7d419f59c84350a12fb9774b57f6d1 = CreateLaneSet2_3e7d419f59c84350a12fb9774b57f6d1LaneSet();
			LaneSets.Add(schemaLaneSet2_3e7d419f59c84350a12fb9774b57f6d1);
			ProcessSchemaLane schemaLane1_f5b40169d0474e70b1ce7ecaf99f82fa = CreateLane1_f5b40169d0474e70b1ce7ecaf99f82faLane();
			schemaLaneSet2_3e7d419f59c84350a12fb9774b57f6d1.Lanes.Add(schemaLane1_f5b40169d0474e70b1ce7ecaf99f82fa);
			ProcessSchemaStartMessageEvent vwsyssspentityschemaaccesslistvalidating = CreateVwSysSSPEntitySchemaAccessListValidatingStartMessageEvent();
			FlowElements.Add(vwsyssspentityschemaaccesslistvalidating);
			ProcessSchemaScriptTask vwsyssspentityschemaaccesslistvalidatingscripttask = CreateVwSysSSPEntitySchemaAccessListValidatingScriptTaskScriptTask();
			FlowElements.Add(vwsyssspentityschemaaccesslistvalidatingscripttask);
			FlowElements.Add(CreateSequenceFlow4_479dfa070ac2459f89270d184975e29aSequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4_479dfa070ac2459f89270d184975e29aSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4_479dfa070ac2459f89270d184975e29a",
				UId = new Guid("479dfa07-0ac2-459f-8927-0d184975e29a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc"),
				CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c"),
				CreatedInSchemaUId = new Guid("4f304de3-7b3d-4c44-a3af-d73d3915a242"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4f304de3-7b3d-4c44-a3af-d73d3915a242"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0bd8a217-3b18-472d-9d55-bc6cbc102db3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ac24ae31-e0bc-4e83-8638-a29c16549e7a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_3e7d419f59c84350a12fb9774b57f6d1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_3e7d419f59c84350a12fb9774b57f6d1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("3e7d419f-59c8-4350-a12f-b9774b57f6d1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc"),
				CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c"),
				CreatedInSchemaUId = new Guid("4f304de3-7b3d-4c44-a3af-d73d3915a242"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("4f304de3-7b3d-4c44-a3af-d73d3915a242"),
				Name = @"LaneSet2_3e7d419f59c84350a12fb9774b57f6d1",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_3e7d419f59c84350a12fb9774b57f6d1;
		}

		protected virtual ProcessSchemaLane CreateLane1_f5b40169d0474e70b1ce7ecaf99f82faLane() {
			ProcessSchemaLane schemaLane1_f5b40169d0474e70b1ce7ecaf99f82fa = new ProcessSchemaLane(this) {
				UId = new Guid("f5b40169-d047-4e70-b1ce-7ecaf99f82fa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3e7d419f-59c8-4350-a12f-b9774b57f6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c"),
				CreatedInSchemaUId = new Guid("4f304de3-7b3d-4c44-a3af-d73d3915a242"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("4f304de3-7b3d-4c44-a3af-d73d3915a242"),
				Name = @"Lane1_f5b40169d0474e70b1ce7ecaf99f82fa",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1_f5b40169d0474e70b1ce7ecaf99f82fa;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateVwSysSSPEntitySchemaAccessListValidatingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0bd8a217-3b18-472d-9d55-bc6cbc102db3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f5b40169-d047-4e70-b1ce-7ecaf99f82fa"),
				CreatedInOwnerSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc"),
				CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c"),
				CreatedInSchemaUId = new Guid("4f304de3-7b3d-4c44-a3af-d73d3915a242"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"VwSysSSPEntitySchemaAccessListValidating",
				ModifiedInSchemaUId = new Guid("4f304de3-7b3d-4c44-a3af-d73d3915a242"),
				Name = @"VwSysSSPEntitySchemaAccessListValidating",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(92, 222),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateVwSysSSPEntitySchemaAccessListValidatingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ac24ae31-e0bc-4e83-8638-a29c16549e7a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f5b40169-d047-4e70-b1ce-7ecaf99f82fa"),
				CreatedInOwnerSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc"),
				CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c"),
				CreatedInSchemaUId = new Guid("4f304de3-7b3d-4c44-a3af-d73d3915a242"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4f304de3-7b3d-4c44-a3af-d73d3915a242"),
				Name = @"VwSysSSPEntitySchemaAccessListValidatingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(235, 208),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,45,138,77,10,194,48,16,133,215,230,20,165,171,118,147,11,116,103,13,110,20,23,226,1,134,242,90,130,242,82,38,19,80,74,239,110,4,151,223,79,156,155,46,208,162,125,252,35,67,199,68,98,178,152,232,79,199,59,166,162,181,4,46,145,240,103,216,40,12,239,106,13,183,21,42,191,175,107,171,188,10,101,193,37,165,103,89,115,219,247,155,59,40,172,40,27,211,130,193,237,238,143,179,188,50,134,47,61,138,47,23,117,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d5bb3512-71e0-482a-9c7e-16bf22c586b7"),
				Name = "Terrasoft.Nui.ServiceModel.DataContract",
				Alias = "DataContract",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b261d1c9-cc98-44e8-aabd-7806d1dc26ed"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c261d1c9-cc98-44e8-aabd-7806d1dc26ec"),
				Name = "Terrasoft.Core.DcmProcess",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aca2294b-e209-4c40-9400-0d59d9ecd1ea"),
				Name = "Terrasoft.GlobalSearch.Indexing",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5410f06b-83f8-43fa-bc49-82a2dd508d3c"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysSSPEntitySchemaAccessListEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4f304de3-7b3d-4c44-a3af-d73d3915a242"));
		}

		#endregion

	}

	#endregion


	#region Class: VwSysSSPEntitySchemaAccessListEventsProcess

	/// <exclude/>
	public class VwSysSSPEntitySchemaAccessListEventsProcess : VwSysSSPEntitySchemaAccessList_SSPEventsProcess
	{

		public VwSysSSPEntitySchemaAccessListEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

