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
	using Terrasoft.Configuration.PRM;
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

	#region Class: Lead_PRMPortal_TerrasoftSchema

	/// <exclude/>
	public class Lead_PRMPortal_TerrasoftSchema : Terrasoft.Configuration.Lead_PRMBase_TerrasoftSchema
	{

		#region Constructors: Public

		public Lead_PRMPortal_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Lead_PRMPortal_TerrasoftSchema(Lead_PRMPortal_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Lead_PRMPortal_TerrasoftSchema(Lead_PRMPortal_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIMLLeadModifiedOnIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("e0ee791a-7d9e-4ef7-8653-eb995a3f6d74");
			index.Name = "IMLLeadModifiedOn";
			index.CreatedInSchemaUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258");
			index.ModifiedInSchemaUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258");
			index.CreatedInPackageId = new Guid("296a0a1e-e6de-4406-bbd8-86a62e047ff0");
			EntitySchemaIndexColumn modifiedOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("aaa8ad09-ce33-4f85-9c6f-46d679ad61ee"),
				ColumnUId = new Guid("9928edec-4272-425a-93bb-48743fee4b04"),
				CreatedInSchemaUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258"),
				ModifiedInSchemaUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258"),
				CreatedInPackageId = new Guid("296a0a1e-e6de-4406-bbd8-86a62e047ff0"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(modifiedOnIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIDX_LeadNameIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("bf3f62f3-5d38-4031-a648-58b036f8f19d");
			index.Name = "IDX_LeadName";
			index.CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			index.ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			index.CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06");
			EntitySchemaIndexColumn leadNameIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("2c3ed9bd-ff44-447d-b4af-c6a4e4090a5a"),
				ColumnUId = new Guid("d06ba9af-faf5-4741-a672-e154ae561a94"),
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(leadNameIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("07b9e4ee-6b92-4a34-8444-7d9556c2adbb");
			Name = "Lead_PRMPortal_Terrasoft";
			ParentSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			ExtendParent = true;
			CreatedInPackageId = new Guid("ba438a7b-1c87-4703-9a24-35e026996df4");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIMLLeadModifiedOnIndex());
			Indexes.Add(CreateIDX_LeadNameIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLead_PRMPortal_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateLead_PRMPortal_TerrasoftEventsProcessSchema() {
			var schema = new Lead_PRMPortal_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Lead_PRMPortal_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Lead_PRMPortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Lead_PRMPortal_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Lead_PRMPortal_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("07b9e4ee-6b92-4a34-8444-7d9556c2adbb"));
		}

		#endregion

	}

	#endregion

	#region Class: Lead_PRMPortal_Terrasoft

	/// <summary>
	/// Lead.
	/// </summary>
	public class Lead_PRMPortal_Terrasoft : Terrasoft.Configuration.Lead_PRMBase_Terrasoft
	{

		#region Constructors: Public

		public Lead_PRMPortal_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Lead_PRMPortal_Terrasoft";
		}

		public Lead_PRMPortal_Terrasoft(Lead_PRMPortal_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Lead_PRMPortalEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Lead_PRMPortal_TerrasoftDeleted", e);
			Inserted += (s, e) => ThrowEvent("Lead_PRMPortal_TerrasoftInserted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Lead_PRMPortal_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Lead_PRMPortalEventsProcess

	/// <exclude/>
	public partial class Lead_PRMPortalEventsProcess<TEntity> : Terrasoft.Configuration.Lead_PRMBaseEventsProcess<TEntity> where TEntity : Lead_PRMPortal_Terrasoft
	{

		public Lead_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Lead_PRMPortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("07b9e4ee-6b92-4a34-8444-7d9556c2adbb");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess1_f68eb686c4e64d70bceadde0a0538834;
		public ProcessFlowElement EventSubProcess1_f68eb686c4e64d70bceadde0a0538834 {
			get {
				return _eventSubProcess1_f68eb686c4e64d70bceadde0a0538834 ?? (_eventSubProcess1_f68eb686c4e64d70bceadde0a0538834 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1_f68eb686c4e64d70bceadde0a0538834",
					SchemaElementUId = new Guid("f68eb686-c4e6-4d70-bcea-dde0a0538834"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pRMPortalLeadInsertedStartMessage;
		public ProcessFlowElement PRMPortalLeadInsertedStartMessage {
			get {
				return _pRMPortalLeadInsertedStartMessage ?? (_pRMPortalLeadInsertedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PRMPortalLeadInsertedStartMessage",
					SchemaElementUId = new Guid("ead724f6-3871-4b67-8b91-89f21e9b822d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask1_d870fe5b381b4e81a5460d80276ae41e;
		public ProcessScriptTask ScriptTask1_d870fe5b381b4e81a5460d80276ae41e {
			get {
				return _scriptTask1_d870fe5b381b4e81a5460d80276ae41e ?? (_scriptTask1_d870fe5b381b4e81a5460d80276ae41e = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1_d870fe5b381b4e81a5460d80276ae41e",
					SchemaElementUId = new Guid("d870fe5b-381b-4e81-a546-0d80276ae41e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1_d870fe5b381b4e81a5460d80276ae41eExecute,
				});
			}
		}

		private ProcessTerminateEvent _terminateEvent1_91862e76ec2a4f9ba31e1c3349553cd7;
		public ProcessTerminateEvent TerminateEvent1_91862e76ec2a4f9ba31e1c3349553cd7 {
			get {
				return _terminateEvent1_91862e76ec2a4f9ba31e1c3349553cd7 ?? (_terminateEvent1_91862e76ec2a4f9ba31e1c3349553cd7 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateEvent1_91862e76ec2a4f9ba31e1c3349553cd7",
					SchemaElementUId = new Guid("91862e76-ec2a-4f9b-a31e-1c3349553cd7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1_f68eb686c4e64d70bceadde0a0538834.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1_f68eb686c4e64d70bceadde0a0538834 };
			FlowElements[PRMPortalLeadInsertedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PRMPortalLeadInsertedStartMessage };
			FlowElements[ScriptTask1_d870fe5b381b4e81a5460d80276ae41e.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1_d870fe5b381b4e81a5460d80276ae41e };
			FlowElements[TerminateEvent1_91862e76ec2a4f9ba31e1c3349553cd7.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1_91862e76ec2a4f9ba31e1c3349553cd7 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1_f68eb686c4e64d70bceadde0a0538834":
						break;
					case "PRMPortalLeadInsertedStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask1_d870fe5b381b4e81a5460d80276ae41e");
						break;
					case "ScriptTask1_d870fe5b381b4e81a5460d80276ae41e":
						e.Context.QueueTasks.Enqueue("TerminateEvent1_91862e76ec2a4f9ba31e1c3349553cd7");
						break;
					case "TerminateEvent1_91862e76ec2a4f9ba31e1c3349553cd7":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("PRMPortalLeadInsertedStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess1_f68eb686c4e64d70bceadde0a0538834":
					context.QueueTasks.Dequeue();
					break;
				case "PRMPortalLeadInsertedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PRMPortalLeadInsertedStartMessage";
					result = PRMPortalLeadInsertedStartMessage.Execute(context);
					break;
				case "ScriptTask1_d870fe5b381b4e81a5460d80276ae41e":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1_d870fe5b381b4e81a5460d80276ae41e";
					result = ScriptTask1_d870fe5b381b4e81a5460d80276ae41e.Execute(context, ScriptTask1_d870fe5b381b4e81a5460d80276ae41eExecute);
					break;
				case "TerminateEvent1_91862e76ec2a4f9ba31e1c3349553cd7":
					context.QueueTasks.Dequeue();
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

		public virtual bool ScriptTask1_d870fe5b381b4e81a5460d80276ae41eExecute(ProcessExecutingContext context) {
			PartnerGrantRight();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Lead_PRMPortal_TerrasoftInserted":
							if (ActivatedEventElements.Contains("PRMPortalLeadInsertedStartMessage")) {
							context.QueueTasks.Enqueue("PRMPortalLeadInsertedStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
			}
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

	#region Class: Lead_PRMPortalEventsProcess

	/// <exclude/>
	public class Lead_PRMPortalEventsProcess : Lead_PRMPortalEventsProcess<Lead_PRMPortal_Terrasoft>
	{

		public Lead_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Lead_PRMPortalEventsProcess

	public partial class Lead_PRMPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void LeadInserting() {
			base.LeadInserting();
			string bpmHrefColumnName = "BpmHref";
			string bpmRefColumnName = "BpmRef";
			string bpmHref = Entity.IsColumnValueLoaded(bpmHrefColumnName) 
				? Entity.GetTypedColumnValue<string>(bpmHrefColumnName) : String.Empty;
			string bpmRef = Entity.IsColumnValueLoaded(bpmRefColumnName) 
				? Entity.GetTypedColumnValue<string>(bpmRefColumnName) : String.Empty;
			Terrasoft.Configuration.LeadSourceHelper lsh = 
				new Terrasoft.Configuration.LeadSourceHelper(UserConnection, bpmHref, bpmRef);
			lsh.ComputeMediumAndSource();
			Guid resultLeadMediumId = lsh.ResultLeadMediumId;
			Guid resultLeadSourceId = lsh.ResultLeadSourceId;
			if (resultLeadMediumId != Guid.Empty) {
				Entity.SetColumnValue("LeadMediumId", resultLeadMediumId);
			}
			if (resultLeadSourceId != Guid.Empty) {
				Entity.SetColumnValue("LeadSourceId", resultLeadSourceId);
			}
		}

		public virtual void PartnerGrantRight() {
			Guid partnerId =Entity.GetTypedColumnValue<Guid>("PartnerId");
			PRMUtility utility = new PRMUtility(UserConnection);
			Guid recordId = Entity.GetTypedColumnValue<Guid>("Id");
			Guid partnershipRoleId = utility.GetPartnershipRoleByAccount(partnerId);
			if(partnershipRoleId != Guid.Empty) {
				RightsManagerHelper rightsHelper = new RightsManagerHelper(UserConnection, Entity.SchemaName);
				RightsParams param = new RightsParams(recordId, PRMBaseConstants.SysEntitySchemaRecRightSourceLeadPartnerOwner);
				param.SysAdminUnitId = partnershipRoleId;
				param.OperationsRights = new Dictionary<EntitySchemaRecordRightLevel, List<EntitySchemaRecordRightOperation>> { {
								EntitySchemaRecordRightLevel.Allow,
									new List<EntitySchemaRecordRightOperation> {
										EntitySchemaRecordRightOperation.Read,
										EntitySchemaRecordRightOperation.Edit,
										EntitySchemaRecordRightOperation.Delete
									}
								}
							};
				rightsHelper.GrantRightsForRecord(param);
			}
		}

		#endregion

	}

	#endregion

	#region Class: Lead_PRMPortal_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Lead_PRMPortal_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Lead_PRMBase_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Lead_PRMPortal_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Lead_PRMPortal_TerrasoftEventsProcessSchema(Lead_PRMPortal_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Lead_PRMPortalEventsProcess";
			UId = new Guid("55b1be06-8f2a-4524-ab99-b796eb7b55c7");
			CreatedInPackageId = new Guid("ba438a7b-1c87-4703-9a24-35e026996df4");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("065de26f-5ffd-4bc4-b862-ab37d85ac483");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet2 = CreateLaneSet2LaneSet();
			LaneSets.Add(schemaLaneSet2);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet2.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1_f68eb686c4e64d70bceadde0a0538834 = CreateEventSubProcess1_f68eb686c4e64d70bceadde0a0538834EventSubProcess();
			FlowElements.Add(eventsubprocess1_f68eb686c4e64d70bceadde0a0538834);
			ProcessSchemaStartMessageEvent prmportalleadinsertedstartmessage = CreatePRMPortalLeadInsertedStartMessageStartMessageEvent();
			eventsubprocess1_f68eb686c4e64d70bceadde0a0538834.FlowElements.Add(prmportalleadinsertedstartmessage);
			ProcessSchemaScriptTask scripttask1_d870fe5b381b4e81a5460d80276ae41e = CreateScriptTask1_d870fe5b381b4e81a5460d80276ae41eScriptTask();
			eventsubprocess1_f68eb686c4e64d70bceadde0a0538834.FlowElements.Add(scripttask1_d870fe5b381b4e81a5460d80276ae41e);
			ProcessSchemaTerminateEvent terminateevent1_91862e76ec2a4f9ba31e1c3349553cd7 = CreateTerminateEvent1_91862e76ec2a4f9ba31e1c3349553cd7TerminateEvent();
			eventsubprocess1_f68eb686c4e64d70bceadde0a0538834.FlowElements.Add(terminateevent1_91862e76ec2a4f9ba31e1c3349553cd7);
			FlowElements.Add(CreateSequenceFlow1_edbe9d28f4254f9cb48dc9ef69e4d66dSequenceFlow());
			FlowElements.Add(CreateSequenceFlow1_aec2ed1363da43b28be142088a5db2f3SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1_edbe9d28f4254f9cb48dc9ef69e4d66dSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1_edbe9d28f4254f9cb48dc9ef69e4d66d",
				UId = new Guid("edbe9d28-f425-4f9c-b48d-c9ef69e4d66d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("43ab6994-29c4-4f63-a2a5-f9feb3eff762"),
				CreatedInPackageId = new Guid("1bc37faf-30bf-4d4a-b067-5fd52b4ccffd"),
				CreatedInSchemaUId = new Guid("55b1be06-8f2a-4524-ab99-b796eb7b55c7"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55b1be06-8f2a-4524-ab99-b796eb7b55c7"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ead724f6-3871-4b67-8b91-89f21e9b822d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d870fe5b-381b-4e81-a546-0d80276ae41e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1_aec2ed1363da43b28be142088a5db2f3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1_aec2ed1363da43b28be142088a5db2f3",
				UId = new Guid("aec2ed13-63da-43b2-8be1-42088a5db2f3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("43ab6994-29c4-4f63-a2a5-f9feb3eff762"),
				CreatedInPackageId = new Guid("1bc37faf-30bf-4d4a-b067-5fd52b4ccffd"),
				CreatedInSchemaUId = new Guid("55b1be06-8f2a-4524-ab99-b796eb7b55c7"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55b1be06-8f2a-4524-ab99-b796eb7b55c7"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d870fe5b-381b-4e81-a546-0d80276ae41e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("91862e76-ec2a-4f9b-a31e-1c3349553cd7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("1d1b3ce4-62f4-4049-96db-af0c8a7a3eb7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("43ab6994-29c4-4f63-a2a5-f9feb3eff762"),
				CreatedInPackageId = new Guid("1bc37faf-30bf-4d4a-b067-5fd52b4ccffd"),
				CreatedInSchemaUId = new Guid("55b1be06-8f2a-4524-ab99-b796eb7b55c7"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("55b1be06-8f2a-4524-ab99-b796eb7b55c7"),
				Name = @"LaneSet2",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet2;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("221c33db-7e10-46dc-8a21-f23ca5ac72ec"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1d1b3ce4-62f4-4049-96db-af0c8a7a3eb7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("1bc37faf-30bf-4d4a-b067-5fd52b4ccffd"),
				CreatedInSchemaUId = new Guid("55b1be06-8f2a-4524-ab99-b796eb7b55c7"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("55b1be06-8f2a-4524-ab99-b796eb7b55c7"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1_f68eb686c4e64d70bceadde0a0538834EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1_f68eb686c4e64d70bceadde0a0538834 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f68eb686-c4e6-4d70-bcea-dde0a0538834"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("221c33db-7e10-46dc-8a21-f23ca5ac72ec"),
				CreatedInOwnerSchemaUId = new Guid("43ab6994-29c4-4f63-a2a5-f9feb3eff762"),
				CreatedInPackageId = new Guid("1bc37faf-30bf-4d4a-b067-5fd52b4ccffd"),
				CreatedInSchemaUId = new Guid("55b1be06-8f2a-4524-ab99-b796eb7b55c7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("55b1be06-8f2a-4524-ab99-b796eb7b55c7"),
				Name = @"EventSubProcess1_f68eb686c4e64d70bceadde0a0538834",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(44, 33),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(616, 300),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1_f68eb686c4e64d70bceadde0a0538834;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePRMPortalLeadInsertedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ead724f6-3871-4b67-8b91-89f21e9b822d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f68eb686-c4e6-4d70-bcea-dde0a0538834"),
				CreatedInOwnerSchemaUId = new Guid("43ab6994-29c4-4f63-a2a5-f9feb3eff762"),
				CreatedInPackageId = new Guid("1bc37faf-30bf-4d4a-b067-5fd52b4ccffd"),
				CreatedInSchemaUId = new Guid("55b1be06-8f2a-4524-ab99-b796eb7b55c7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"LeadInserted",
				ModifiedInSchemaUId = new Guid("55b1be06-8f2a-4524-ab99-b796eb7b55c7"),
				Name = @"PRMPortalLeadInsertedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(56, 117),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1_d870fe5b381b4e81a5460d80276ae41eScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d870fe5b-381b-4e81-a546-0d80276ae41e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f68eb686-c4e6-4d70-bcea-dde0a0538834"),
				CreatedInOwnerSchemaUId = new Guid("43ab6994-29c4-4f63-a2a5-f9feb3eff762"),
				CreatedInPackageId = new Guid("1bc37faf-30bf-4d4a-b067-5fd52b4ccffd"),
				CreatedInSchemaUId = new Guid("55b1be06-8f2a-4524-ab99-b796eb7b55c7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55b1be06-8f2a-4524-ab99-b796eb7b55c7"),
				Name = @"ScriptTask1_d870fe5b381b4e81a5460d80276ae41e",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(256, 103),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,44,42,201,75,45,114,47,74,204,43,9,202,76,207,40,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,22,152,252,108,33,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateEvent1_91862e76ec2a4f9ba31e1c3349553cd7TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("91862e76-ec2a-4f9b-a31e-1c3349553cd7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f68eb686-c4e6-4d70-bcea-dde0a0538834"),
				CreatedInOwnerSchemaUId = new Guid("43ab6994-29c4-4f63-a2a5-f9feb3eff762"),
				CreatedInPackageId = new Guid("1bc37faf-30bf-4d4a-b067-5fd52b4ccffd"),
				CreatedInSchemaUId = new Guid("55b1be06-8f2a-4524-ab99-b796eb7b55c7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("55b1be06-8f2a-4524-ab99-b796eb7b55c7"),
				Name = @"TerminateEvent1_91862e76ec2a4f9ba31e1c3349553cd7",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(497, 117),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreatePartnerGrantRightMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("b1a963da-a78f-4fae-8e9e-52d870dd0ef3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("b1a963da-a78f-4fae-8e9e-52d870dd0ef3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("b1a963da-a78f-4fae-8e9e-52d870dd0ef3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("b1a963da-a78f-4fae-8e9e-52d870dd0ef3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("b1a963da-a78f-4fae-8e9e-52d870dd0ef3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("b1a963da-a78f-4fae-8e9e-52d870dd0ef3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("b1a963da-a78f-4fae-8e9e-52d870dd0ef3")
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
				UId = new Guid("68e5b019-87de-4d69-b7d9-eb3b79989128"),
				Name = "Terrasoft.Configuration.PRM",
				Alias = "",
				CreatedInPackageId = new Guid("1bc37faf-30bf-4d4a-b067-5fd52b4ccffd")
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

		protected override SchemaMethod CreateLeadInsertingMethod() {
			SchemaMethod method = base.CreateLeadInsertingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,145,223,78,131,48,20,198,175,225,41,42,87,144,16,30,192,57,141,46,203,70,50,189,128,233,125,183,30,102,19,218,146,254,137,33,198,119,183,93,193,32,16,167,222,53,61,231,247,125,223,57,231,128,21,100,59,192,36,231,10,164,166,252,20,39,139,80,105,105,95,232,208,176,173,132,106,37,106,195,248,19,102,128,150,40,122,240,159,209,176,171,152,105,42,70,61,14,178,165,53,215,84,183,89,174,60,240,130,107,3,59,129,9,144,120,98,151,160,48,184,235,137,13,232,125,219,0,25,112,55,94,253,118,142,188,70,229,185,152,173,89,163,219,81,216,139,57,138,255,198,40,126,78,177,7,41,177,18,149,206,86,130,87,244,100,36,214,84,240,243,5,74,97,228,17,182,80,55,32,81,173,94,109,200,48,224,240,134,126,11,197,207,246,132,182,133,195,209,213,211,126,235,105,55,181,61,172,149,181,34,172,49,26,30,129,80,195,238,121,39,225,206,190,49,148,32,9,202,212,218,105,251,142,156,216,32,142,43,38,133,9,225,165,102,136,190,176,8,105,133,226,25,139,171,37,114,90,126,79,9,122,15,131,110,223,37,232,193,170,227,104,72,69,233,76,90,59,199,199,200,229,43,214,159,92,122,234,155,75,255,233,92,62,1,17,117,220,216,60,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePartnerGrantRightMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1c2f7dc4-e01d-4f26-86b0-c56444bca4e5"),
				Name = "PartnerGrantRight",
				CreatedInSchemaUId = new Guid("55b1be06-8f2a-4524-ab99-b796eb7b55c7"),
				CreatedInPackageId = new Guid("1bc37faf-30bf-4d4a-b067-5fd52b4ccffd"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,93,111,130,48,24,133,175,245,87,116,94,97,66,248,3,83,19,191,198,150,232,52,56,119,223,192,59,109,82,90,210,190,204,16,227,127,95,63,128,57,157,155,92,64,160,167,207,123,206,41,113,201,50,82,80,133,2,212,75,70,134,115,129,12,171,40,6,124,171,10,200,166,146,151,185,120,167,188,132,65,108,164,163,160,183,110,196,189,254,99,119,157,44,183,200,184,217,66,202,250,57,36,2,14,228,123,33,216,106,80,83,41,4,164,200,164,48,155,44,136,40,72,165,202,236,72,242,255,76,63,44,62,243,170,247,172,72,36,7,7,168,71,91,194,250,231,242,164,26,167,169,44,5,6,109,70,3,98,31,193,53,230,97,72,236,128,104,158,23,88,245,201,177,219,73,216,110,143,122,73,5,221,129,122,6,94,128,34,202,125,171,95,124,212,95,100,23,153,195,38,226,38,221,67,78,95,105,14,198,69,205,55,142,105,174,109,46,154,255,32,250,133,160,41,42,180,157,78,168,6,195,213,72,5,234,104,83,105,15,246,220,4,82,183,115,35,75,149,194,2,104,86,183,177,58,152,155,157,232,134,216,109,227,44,103,98,43,24,186,254,174,202,104,165,43,19,134,218,8,218,123,170,13,206,152,203,69,85,53,184,48,96,172,58,229,2,62,129,135,100,193,52,222,146,180,236,209,136,28,109,223,246,250,11,23,141,57,151,135,208,11,59,214,199,125,248,134,125,147,222,74,163,196,148,22,222,173,158,103,12,239,87,207,128,3,66,45,63,117,207,30,39,211,247,249,143,21,197,202,156,175,111,252,73,42,79,11,220,137,152,83,60,125,1,27,6,243,150,180,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Lead_PRMPortal_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("55b1be06-8f2a-4524-ab99-b796eb7b55c7"));
		}

		#endregion

	}

	#endregion

}

