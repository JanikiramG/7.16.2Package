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

	#region Class: WebServiceURLSchema

	/// <exclude/>
	public class WebServiceURLSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public WebServiceURLSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public WebServiceURLSchema(WebServiceURLSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public WebServiceURLSchema(WebServiceURLSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("543e7919-0d37-4610-a08f-443e8605f9bc");
			RealUId = new Guid("543e7919-0d37-4610-a08f-443e8605f9bc");
			Name = "WebServiceURL";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateURLColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("eed5f6a4-93d3-4b74-afff-027b0e407504")) == null) {
				Columns.Add(CreateWebServiceColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("543e7919-0d37-4610-a08f-443e8605f9bc");
			column.CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("543e7919-0d37-4610-a08f-443e8605f9bc");
			column.CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("543e7919-0d37-4610-a08f-443e8605f9bc");
			column.CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("543e7919-0d37-4610-a08f-443e8605f9bc");
			column.CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("543e7919-0d37-4610-a08f-443e8605f9bc");
			column.CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("543e7919-0d37-4610-a08f-443e8605f9bc");
			column.CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b");
			return column;
		}

		protected virtual EntitySchemaColumn CreateURLColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("62951142-48fe-4a39-a5e4-e8fc3da163c8"),
				Name = @"URL",
				CreatedInSchemaUId = new Guid("543e7919-0d37-4610-a08f-443e8605f9bc"),
				ModifiedInSchemaUId = new Guid("543e7919-0d37-4610-a08f-443e8605f9bc"),
				CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b")
			};
		}

		protected virtual EntitySchemaColumn CreateWebServiceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("eed5f6a4-93d3-4b74-afff-027b0e407504"),
				Name = @"WebService",
				ReferenceSchemaUId = new Guid("34a72c74-848f-4081-86c8-87310ee15fb5"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("543e7919-0d37-4610-a08f-443e8605f9bc"),
				ModifiedInSchemaUId = new Guid("543e7919-0d37-4610-a08f-443e8605f9bc"),
				CreatedInPackageId = new Guid("b25ba612-51fa-4b36-88e3-e38746f7044b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateWebServiceURLEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateWebServiceURLEventsProcessSchema() {
			var schema = new WebServiceURLEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new WebServiceURL(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new WebServiceURL_ProcessDesignerEventsProcess(userConnection);
		}

		public override object Clone() {
			return new WebServiceURLSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new WebServiceURLSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("543e7919-0d37-4610-a08f-443e8605f9bc"));
		}

		#endregion

	}

	#endregion

	#region Class: WebServiceURL

	/// <summary>
	/// Web service address.
	/// </summary>
	public class WebServiceURL : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public WebServiceURL(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "WebServiceURL";
		}

		public WebServiceURL(WebServiceURL source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// URL.
		/// </summary>
		public string URL {
			get {
				return GetTypedColumnValue<string>("URL");
			}
			set {
				SetColumnValue("URL", value);
			}
		}

		/// <exclude/>
		public Guid WebServiceId {
			get {
				return GetTypedColumnValue<Guid>("WebServiceId");
			}
			set {
				SetColumnValue("WebServiceId", value);
				_webService = null;
			}
		}

		/// <exclude/>
		public string WebServiceName {
			get {
				return GetTypedColumnValue<string>("WebServiceName");
			}
			set {
				SetColumnValue("WebServiceName", value);
				if (_webService != null) {
					_webService.Name = value;
				}
			}
		}

		private WebService _webService;
		/// <summary>
		/// Web service.
		/// </summary>
		public WebService WebService {
			get {
				return _webService ??
					(_webService = LookupColumnEntities.GetEntity("WebService") as WebService);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new WebServiceURL_ProcessDesignerEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("WebServiceURLDeleted", e);
			Deleting += (s, e) => ThrowEvent("WebServiceURLDeleting", e);
			Inserting += (s, e) => ThrowEvent("WebServiceURLInserting", e);
			Saving += (s, e) => ThrowEvent("WebServiceURLSaving", e);
			Validating += (s, e) => ThrowEvent("WebServiceURLValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new WebServiceURL(this);
		}

		#endregion

	}

	#endregion

	#region Class: WebServiceURL_ProcessDesignerEventsProcess

	/// <exclude/>
	public partial class WebServiceURL_ProcessDesignerEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : WebServiceURL
	{

		public WebServiceURL_ProcessDesignerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "WebServiceURL_ProcessDesignerEventsProcess";
			SchemaUId = new Guid("543e7919-0d37-4610-a08f-443e8605f9bc");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("543e7919-0d37-4610-a08f-443e8605f9bc");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _webServiceURLEventSubProcess;
		public ProcessFlowElement WebServiceURLEventSubProcess {
			get {
				return _webServiceURLEventSubProcess ?? (_webServiceURLEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "WebServiceURLEventSubProcess",
					SchemaElementUId = new Guid("d82fea9a-f0ca-4005-94b4-f05dc2177da8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _webServiceURLInsertingStartMessage;
		public ProcessFlowElement WebServiceURLInsertingStartMessage {
			get {
				return _webServiceURLInsertingStartMessage ?? (_webServiceURLInsertingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "WebServiceURLInsertingStartMessage",
					SchemaElementUId = new Guid("29868cf6-3162-4414-aa4f-542feb36a19c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _webServiceURLSavingStartMessage;
		public ProcessFlowElement WebServiceURLSavingStartMessage {
			get {
				return _webServiceURLSavingStartMessage ?? (_webServiceURLSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "WebServiceURLSavingStartMessage",
					SchemaElementUId = new Guid("18472a68-df48-4dcb-991b-68258be35494"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _webServiceURLDeletingStartMessage;
		public ProcessFlowElement WebServiceURLDeletingStartMessage {
			get {
				return _webServiceURLDeletingStartMessage ?? (_webServiceURLDeletingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "WebServiceURLDeletingStartMessage",
					SchemaElementUId = new Guid("04a03ded-f627-4d71-8130-8c36feabf095"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _checkCanManageLookupsScriptTask;
		public ProcessScriptTask CheckCanManageLookupsScriptTask {
			get {
				return _checkCanManageLookupsScriptTask ?? (_checkCanManageLookupsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckCanManageLookupsScriptTask",
					SchemaElementUId = new Guid("d33c6259-764e-4be4-afe5-675d518cc310"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckCanManageLookupsScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[WebServiceURLEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { WebServiceURLEventSubProcess };
			FlowElements[WebServiceURLInsertingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { WebServiceURLInsertingStartMessage };
			FlowElements[WebServiceURLSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { WebServiceURLSavingStartMessage };
			FlowElements[WebServiceURLDeletingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { WebServiceURLDeletingStartMessage };
			FlowElements[CheckCanManageLookupsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckCanManageLookupsScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "WebServiceURLEventSubProcess":
						break;
					case "WebServiceURLInsertingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckCanManageLookupsScriptTask");
						break;
					case "WebServiceURLSavingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckCanManageLookupsScriptTask");
						break;
					case "WebServiceURLDeletingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckCanManageLookupsScriptTask");
						break;
					case "CheckCanManageLookupsScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("WebServiceURLInsertingStartMessage");
			ActivatedEventElements.Add("WebServiceURLSavingStartMessage");
			ActivatedEventElements.Add("WebServiceURLDeletingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "WebServiceURLEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "WebServiceURLInsertingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "WebServiceURLInsertingStartMessage";
					result = WebServiceURLInsertingStartMessage.Execute(context);
					break;
				case "WebServiceURLSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "WebServiceURLSavingStartMessage";
					result = WebServiceURLSavingStartMessage.Execute(context);
					break;
				case "WebServiceURLDeletingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "WebServiceURLDeletingStartMessage";
					result = WebServiceURLDeletingStartMessage.Execute(context);
					break;
				case "CheckCanManageLookupsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckCanManageLookupsScriptTask";
					result = CheckCanManageLookupsScriptTask.Execute(context, CheckCanManageLookupsScriptTaskExecute);
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

		public virtual bool CheckCanManageLookupsScriptTaskExecute(ProcessExecutingContext context) {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageLookups");
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "WebServiceURLInserting":
							if (ActivatedEventElements.Contains("WebServiceURLInsertingStartMessage")) {
							context.QueueTasks.Enqueue("WebServiceURLInsertingStartMessage");
						}
						break;
					case "WebServiceURLSaving":
							if (ActivatedEventElements.Contains("WebServiceURLSavingStartMessage")) {
							context.QueueTasks.Enqueue("WebServiceURLSavingStartMessage");
						}
						break;
					case "WebServiceURLDeleting":
							if (ActivatedEventElements.Contains("WebServiceURLDeletingStartMessage")) {
							context.QueueTasks.Enqueue("WebServiceURLDeletingStartMessage");
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

	#region Class: WebServiceURL_ProcessDesignerEventsProcess

	/// <exclude/>
	public class WebServiceURL_ProcessDesignerEventsProcess : WebServiceURL_ProcessDesignerEventsProcess<WebServiceURL>
	{

		public WebServiceURL_ProcessDesignerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: WebServiceURL_ProcessDesignerEventsProcess

	public partial class WebServiceURL_ProcessDesignerEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: WebServiceURLEventsProcessSchema

	/// <exclude/>
	public class WebServiceURLEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public WebServiceURLEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public WebServiceURLEventsProcessSchema(WebServiceURLEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "WebServiceURL_ProcessDesignerEventsProcess";
			UId = new Guid("6018e518-73d1-4b35-95e7-143eaec5b22c");
			CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaWebServiceURLLaneSet = CreateWebServiceURLLaneSetLaneSet();
			LaneSets.Add(schemaWebServiceURLLaneSet);
			ProcessSchemaLane schemaWebServiceURLLane = CreateWebServiceURLLaneLane();
			schemaWebServiceURLLaneSet.Lanes.Add(schemaWebServiceURLLane);
			ProcessSchemaEventSubProcess webserviceurleventsubprocess = CreateWebServiceURLEventSubProcessEventSubProcess();
			FlowElements.Add(webserviceurleventsubprocess);
			ProcessSchemaStartMessageEvent webserviceurlinsertingstartmessage = CreateWebServiceURLInsertingStartMessageStartMessageEvent();
			webserviceurleventsubprocess.FlowElements.Add(webserviceurlinsertingstartmessage);
			ProcessSchemaStartMessageEvent webserviceurlsavingstartmessage = CreateWebServiceURLSavingStartMessageStartMessageEvent();
			webserviceurleventsubprocess.FlowElements.Add(webserviceurlsavingstartmessage);
			ProcessSchemaStartMessageEvent webserviceurldeletingstartmessage = CreateWebServiceURLDeletingStartMessageStartMessageEvent();
			webserviceurleventsubprocess.FlowElements.Add(webserviceurldeletingstartmessage);
			ProcessSchemaScriptTask checkcanmanagelookupsscripttask = CreateCheckCanManageLookupsScriptTaskScriptTask();
			FlowElements.Add(checkcanmanagelookupsscripttask);
			FlowElements.Add(CreateWebServiceURLSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateWebServiceURLSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateWebServiceURLSequenceFlow3SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateWebServiceURLSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "WebServiceURLSequenceFlow1",
				UId = new Guid("fa475f98-8d75-420c-b19a-199dbc956595"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("cbae53f9-5667-4e24-b302-4210ac4a9274"),
				CreatedInSchemaUId = new Guid("6018e518-73d1-4b35-95e7-143eaec5b22c"),
				CurveCenterPosition = new Point(236, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6018e518-73d1-4b35-95e7-143eaec5b22c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("29868cf6-3162-4414-aa4f-542feb36a19c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d33c6259-764e-4be4-afe5-675d518cc310"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateWebServiceURLSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "WebServiceURLSequenceFlow2",
				UId = new Guid("e877cea5-065c-4cf3-ac1c-ad687c0ca2a8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("cbae53f9-5667-4e24-b302-4210ac4a9274"),
				CreatedInSchemaUId = new Guid("6018e518-73d1-4b35-95e7-143eaec5b22c"),
				CurveCenterPosition = new Point(234, 102),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6018e518-73d1-4b35-95e7-143eaec5b22c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("18472a68-df48-4dcb-991b-68258be35494"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d33c6259-764e-4be4-afe5-675d518cc310"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateWebServiceURLSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "WebServiceURLSequenceFlow3",
				UId = new Guid("103dad56-e090-47e1-97a2-80523013ebd6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("cbae53f9-5667-4e24-b302-4210ac4a9274"),
				CreatedInSchemaUId = new Guid("6018e518-73d1-4b35-95e7-143eaec5b22c"),
				CurveCenterPosition = new Point(220, 138),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6018e518-73d1-4b35-95e7-143eaec5b22c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("04a03ded-f627-4d71-8130-8c36feabf095"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d33c6259-764e-4be4-afe5-675d518cc310"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateWebServiceURLLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaWebServiceURLLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("8e7b0d7b-bfa4-40d5-ad81-0f4e3b906cdc"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("cbae53f9-5667-4e24-b302-4210ac4a9274"),
				CreatedInSchemaUId = new Guid("6018e518-73d1-4b35-95e7-143eaec5b22c"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("6018e518-73d1-4b35-95e7-143eaec5b22c"),
				Name = @"WebServiceURLLaneSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(560, 228),
				UseBackgroundMode = false
			};
			return schemaWebServiceURLLaneSet;
		}

		protected virtual ProcessSchemaLane CreateWebServiceURLLaneLane() {
			ProcessSchemaLane schemaWebServiceURLLane = new ProcessSchemaLane(this) {
				UId = new Guid("7ddedc83-bf23-46c7-a72a-ff1bbc465705"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("8e7b0d7b-bfa4-40d5-ad81-0f4e3b906cdc"),
				CreatedInOwnerSchemaUId = new Guid("543e7919-0d37-4610-a08f-443e8605f9bc"),
				CreatedInPackageId = new Guid("cbae53f9-5667-4e24-b302-4210ac4a9274"),
				CreatedInSchemaUId = new Guid("6018e518-73d1-4b35-95e7-143eaec5b22c"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("6018e518-73d1-4b35-95e7-143eaec5b22c"),
				Name = @"WebServiceURLLane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(531, 228),
				UseBackgroundMode = false
			};
			return schemaWebServiceURLLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateWebServiceURLEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaWebServiceURLEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d82fea9a-f0ca-4005-94b4-f05dc2177da8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7ddedc83-bf23-46c7-a72a-ff1bbc465705"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("cbae53f9-5667-4e24-b302-4210ac4a9274"),
				CreatedInSchemaUId = new Guid("6018e518-73d1-4b35-95e7-143eaec5b22c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6018e518-73d1-4b35-95e7-143eaec5b22c"),
				Name = @"WebServiceURLEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(133, 207),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaWebServiceURLEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateWebServiceURLInsertingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("29868cf6-3162-4414-aa4f-542feb36a19c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d82fea9a-f0ca-4005-94b4-f05dc2177da8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("cbae53f9-5667-4e24-b302-4210ac4a9274"),
				CreatedInSchemaUId = new Guid("6018e518-73d1-4b35-95e7-143eaec5b22c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"WebServiceURLInserting",
				ModifiedInSchemaUId = new Guid("6018e518-73d1-4b35-95e7-143eaec5b22c"),
				Name = @"WebServiceURLInsertingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(50, 23),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateWebServiceURLSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("18472a68-df48-4dcb-991b-68258be35494"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d82fea9a-f0ca-4005-94b4-f05dc2177da8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("cbae53f9-5667-4e24-b302-4210ac4a9274"),
				CreatedInSchemaUId = new Guid("6018e518-73d1-4b35-95e7-143eaec5b22c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"WebServiceURLSaving",
				ModifiedInSchemaUId = new Guid("6018e518-73d1-4b35-95e7-143eaec5b22c"),
				Name = @"WebServiceURLSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(50, 79),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateWebServiceURLDeletingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("04a03ded-f627-4d71-8130-8c36feabf095"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d82fea9a-f0ca-4005-94b4-f05dc2177da8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("cbae53f9-5667-4e24-b302-4210ac4a9274"),
				CreatedInSchemaUId = new Guid("6018e518-73d1-4b35-95e7-143eaec5b22c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"WebServiceURLDeleting",
				ModifiedInSchemaUId = new Guid("6018e518-73d1-4b35-95e7-143eaec5b22c"),
				Name = @"WebServiceURLDeletingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(50, 135),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckCanManageLookupsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d33c6259-764e-4be4-afe5-675d518cc310"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7ddedc83-bf23-46c7-a72a-ff1bbc465705"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("cbae53f9-5667-4e24-b302-4210ac4a9274"),
				CreatedInSchemaUId = new Guid("6018e518-73d1-4b35-95e7-143eaec5b22c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6018e518-73d1-4b35-95e7-143eaec5b22c"),
				Name = @"CheckCanManageLookupsScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(232, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,113,10,78,77,46,45,202,44,169,116,205,75,207,204,75,213,115,206,72,77,206,118,78,204,115,173,0,138,151,164,250,23,164,22,37,130,84,106,40,1,5,125,19,243,18,211,83,125,242,243,179,75,11,138,149,52,173,121,185,138,82,75,74,139,242,20,74,138,74,83,173,1,55,130,180,236,91,0,0,0 }
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
				CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b")
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
			return new WebServiceURLEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6018e518-73d1-4b35-95e7-143eaec5b22c"));
		}

		#endregion

	}

	#endregion


	#region Class: WebServiceURLEventsProcess

	/// <exclude/>
	public class WebServiceURLEventsProcess : WebServiceURL_ProcessDesignerEventsProcess
	{

		public WebServiceURLEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

