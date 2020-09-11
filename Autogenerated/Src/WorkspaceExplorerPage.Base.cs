namespace Terrasoft.WebApp
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Drawing;
	using System.Globalization;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;

	#region Class: WorkspaceExplorerPageSchema

	/// <exclude/>
	public class WorkspaceExplorerPageSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.HtmlPageContainer _htmlPageContainer1;
		public Terrasoft.UI.WebControls.Controls.HtmlPageContainer HtmlPageContainer1 {
			get {
				return _htmlPageContainer1;
			}
		}

		#endregion

		#region Constructors: Public

		public WorkspaceExplorerPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public WorkspaceExplorerPageSchema(WorkspaceExplorerPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("05748dbb-734f-4cde-85a6-1f9c68b6577f");
			RealUId = new Guid("05748dbb-734f-4cde-85a6-1f9c68b6577f");
			Name = "WorkspaceExplorerPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Maximized = true;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateWorkspaceExplorerPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateHtmlPageContainer1());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateWorkspaceExplorerPageEventsProcessSchema() {
			var schema = new WorkspaceExplorerPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.HtmlPageContainer CreateHtmlPageContainer1() {
			_htmlPageContainer1 = new Terrasoft.UI.WebControls.Controls.HtmlPageContainer();
			_htmlPageContainer1.UId = new Guid("cd99075d-35fe-427a-984d-49f4f69d988e");
			_htmlPageContainer1.Name = "HtmlPageContainer1";
			_htmlPageContainer1.CreatedInSchemaUId = new Guid("05748dbb-734f-4cde-85a6-1f9c68b6577f");
			_htmlPageContainer1.ModifiedInSchemaUId = new Guid("05748dbb-734f-4cde-85a6-1f9c68b6577f");
			_htmlPageContainer1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_htmlPageContainer1.Tag = "";
			_htmlPageContainer1.SourceUrl = "/WorkspaceExplorerModule.aspx";
			_htmlPageContainer1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_htmlPageContainer1.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_htmlPageContainer1.Edges = "";
			return _htmlPageContainer1;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new WorkspaceExplorerPageSchemaUserControl();
		}

		public override object Clone() {
			return new WorkspaceExplorerPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("05748dbb-734f-4cde-85a6-1f9c68b6577f"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new WorkspaceExplorerPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: WorkspaceExplorerPageEventsProcess

	/// <exclude/>
	public class WorkspaceExplorerPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.WorkspaceExplorerPageSchemaUserControl
	{

		private TPage _page;
		public TPage Page {
			get {
				return _page;
			}
			set {
				_page = value;
			}
		}

		public WorkspaceExplorerPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "WorkspaceExplorerPageEventsProcess";
			SchemaUId = new Guid("05748dbb-734f-4cde-85a6-1f9c68b6577f");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("05748dbb-734f-4cde-85a6-1f9c68b6577f");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString() + 
				Page.PageContainer.UniqueID;
			}
		}

		public virtual Object MainPage {
			get;
			set;
		}

		public virtual string MainPageProcessUId {
			get;
			set;
		}

		public virtual Guid SysModuleId {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("66524938-7407-43b2-a89b-7c70bbcd3347"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage1;
		public ProcessFlowElement StartMessage1 {
			get {
				return _startMessage1 ?? (_startMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage1",
					SchemaElementUId = new Guid("9a636f1d-4f7c-4d40-a0a7-cec28bb16a0d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("935d22f4-18c7-43d8-82c5-89d2a8b80d70"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess2;
		public ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("03920853-4e55-4b48-9e90-3a6c4c656f52"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent1 {
			get {
				return _intermediateThrowMessageEvent1 ?? (_intermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("de434523-8353-4d85-a9c0-538e6d44630c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _startMessage2;
		public ProcessFlowElement StartMessage2 {
			get {
				return _startMessage2 ?? (_startMessage2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage2",
					SchemaElementUId = new Guid("880d01fe-ef7e-44bd-89b4-661a307352f1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _pageLoadCompleteScript;
		public ProcessScriptTask PageLoadCompleteScript {
			get {
				return _pageLoadCompleteScript ?? (_pageLoadCompleteScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageLoadCompleteScript",
					SchemaElementUId = new Guid("53b19512-3f6d-4b21-b1ad-b02c455adc35"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[PageLoadCompleteScript.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScript };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
					case "EventSubProcess2":
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScript");
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "PageLoadCompleteScript":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage1");
			ActivatedEventElements.Add("StartMessage2");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "PageLoadCompleteScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScript";
					result = PageLoadCompleteScript.Execute(context, PageLoadCompleteScriptExecute);
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

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "SysModuleId":
					SysModuleId = reader.GetValue<System.Guid>();
				break;
				case "MainPageProcessUId":
					MainPageProcessUId = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool PageLoadCompleteScriptExecute(ProcessExecutingContext context) {
			if (Page.Request.ApplicationPath != "/") {
				Page.HtmlPageContainer1.SourceUrl = Page.Request.ApplicationPath + Page.HtmlPageContainer1.SourceUrl;
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("SysModuleId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysModuleId", SysModuleId, Guid.Empty);
			}
			if (!HasMapping("MainPageProcessUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MainPageProcessUId", MainPageProcessUId, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: WorkspaceExplorerPageEventsProcess

	/// <exclude/>
	public class WorkspaceExplorerPageEventsProcess : WorkspaceExplorerPageEventsProcess<Terrasoft.WebApp.WorkspaceExplorerPageSchemaUserControl>
	{

		public WorkspaceExplorerPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: WorkspaceExplorerPageSchemaUserControl

	/// <exclude/>
	public partial class WorkspaceExplorerPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.HtmlPageContainer HtmlPageContainer1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.HtmlPageContainer)PageContainer.FindPageControl("HtmlPageContainer1", true);
			}
		}

		private Terrasoft.UI.WebControls.Controls.ScriptManager _scriptManager;
		public Terrasoft.UI.WebControls.Controls.ScriptManager ScriptManager {
			get {
				if (this._scriptManager != null) {
					return this._scriptManager;
				}
				if (!this.DesignMode && this.Page != null) {
					this._scriptManager = ScriptManager.GetCurrent(this.Page);
					if (this._scriptManager != null) {
						return this._scriptManager;
					}
				}
				if (this.Page != null) {
					this._scriptManager = ControlUtilities.FindControl(this.Page,
						"Terrasoft.UI.WebControls.ScriptManagerProxy") as ScriptManager;
					if (this._scriptManager != null) {
						return this._scriptManager;
					}
					this._scriptManager = (ScriptManager)ControlUtilities.FindControl(this.Page,
						"Terrasoft.UI.WebControls.ScriptManager");
					if (this.DesignMode && this._scriptManager == null) {
						this._scriptManager = new ScriptManager();
						this.Page.Controls.Add(this._scriptManager);
					}
				}
				if (this._scriptManager == null) {
					throw new InvalidOperationException("The Terrasoft Script Manager Control " +
						"is missing from this Page." +
						Environment.NewLine + Environment.NewLine +
						"Please add the following Script Manager tag inside the <body> or " +
						"<form> of this Page." +
						Environment.NewLine + Environment.NewLine + "Example" +
						Environment.NewLine + Environment.NewLine +
						" <ext:Script Manager runat=\"server\" />");
				}
				return this._scriptManager;
			}
		}

		#endregion

		#region Methods: Protected

		protected override void PageLoadComplete(object sender, EventArgs e) {
			if (!((PageContainer)PageContainer).IsPageLoadCompleted) {
				((PageContainer)PageContainer).IsPageLoadCompleted = true;
				ThrowEvent("PageLoadComplete");
			}
		}

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (WorkspaceExplorerPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new WorkspaceExplorerPageEventsProcess(UserConnection);
				process.Page = this;
				Process = process;
				UserConnection.ProcessEngine.SetProcess(process);
				process.Execute(UserConnection);
				UserConnection.ProcessEngine.SetProcessPropertiesData(process);
			} else {
				process.InternalContext = new ProcessExecutingContext(UserConnection) {
					Process = process
				};
				process.Page = this;
				Process = process;
				UserConnection.ProcessEngine.SetProcess(process);
			}
		}

		protected override void InitializePageSchemaControls() {
			base.InitializePageSchemaControls();
			if (!PageContainer.IsDesignMode) {
					InitializeEmbeddedProcess();
				}
		}

		#endregion

		#region Methods: Public

		public virtual void ThrowClientEvent(string message, params object[] parameters) {
			string key = CopyParameters(parameters);
			ScriptManager.AddScript("if (window.opener) { if (window.key) {window.opener.Terrasoft.AjaxMethods.ThrowClientEvent(window.key, '" + message + "', '" + key + "')}}");
		}

		public virtual void AjaxRefresh() {
			ScriptManager.AddScript("window.Terrasoft.AjaxMethods.ThrowClientEvent(null, null);");
		}

		public virtual void AddScript(string script) {
			this.ScriptManager.AddScript(script);
		}

		public virtual void RegisterClientScriptIncludeInternal(string key, string resourceName) {
			this.ScriptManager.RegisterClientScriptIncludeInternal(key, resourceName);
		}

		public virtual void RegisterClientScriptBlock(string key, string script) {
			this.ScriptManager.RegisterClientScriptBlock(key, script);
		}

		public override void SetSchemaName() {
			SchemaName = "WorkspaceExplorerPage";
		}

		#endregion

	}

	#endregion

	#region Class: WorkspaceExplorerPageEventsProcessSchema

	/// <exclude/>
	public class WorkspaceExplorerPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public WorkspaceExplorerPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public WorkspaceExplorerPageEventsProcessSchema(WorkspaceExplorerPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "WorkspaceExplorerPageEventsProcess";
			UId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateMainPageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b84d1ebb-10b4-4fc5-b7fd-7ca4bb5bc64e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				Name = @"MainPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMainPageProcessUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("08540e35-6515-49f4-91d7-32507418ef67"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				Name = @"MainPageProcessUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysModuleIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5d017935-70f5-44f5-837b-efc574036126"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				Name = @"SysModuleId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateMainPageParameter());
			Parameters.Add(CreateMainPageProcessUIdParameter());
			Parameters.Add(CreateSysModuleIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet11 = CreateLaneSet11LaneSet();
			LaneSets.Add(schemaLaneSet11);
			ProcessSchemaLane schemaLane34 = CreateLane34Lane();
			schemaLaneSet11.Lanes.Add(schemaLane34);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess2.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask pageloadcompletescript = CreatePageLoadCompleteScriptScriptTask();
			eventsubprocess2.FlowElements.Add(pageloadcompletescript);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("76c8bc0b-337e-4437-89e2-a9cfebf8008e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				CurveCenterPosition = new Point(240, 114),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9a636f1d-4f7c-4d40-a0a7-cec28bb16a0d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("935d22f4-18c7-43d8-82c5-89d2a8b80d70"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("d5b252ef-aee8-417f-ab11-629bea1f9f1c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				CurveCenterPosition = new Point(206, 294),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("880d01fe-ef7e-44bd-89b4-661a307352f1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("de434523-8353-4d85-a9c0-538e6d44630c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("c64019d2-8fb1-46ac-be35-652070612b15"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				CurveCenterPosition = new Point(290, 293),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("de434523-8353-4d85-a9c0-538e6d44630c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("53b19512-3f6d-4b21-b1ad-b02c455adc35"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet11LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet11 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("9f556d61-6054-47dc-97ee-00f6f54de115"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				Name = @"LaneSet11",
				Position = new Point(5, 5),
				Size = new Size(759, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet11;
		}

		protected virtual ProcessSchemaLane CreateLane34Lane() {
			ProcessSchemaLane schemaLane34 = new ProcessSchemaLane(this) {
				UId = new Guid("29f8c189-3794-4f08-8be8-6745dd76a999"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("9f556d61-6054-47dc-97ee-00f6f54de115"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				Name = @"Lane34",
				Position = new Point(29, 0),
				Size = new Size(730, 400),
				UseBackgroundMode = false
			};
			return schemaLane34;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("66524938-7407-43b2-a89b-7c70bbcd3347"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("29f8c189-3794-4f08-8be8-6745dd76a999"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(57, 30),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(469, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9a636f1d-4f7c-4d40-a0a7-cec28bb16a0d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("66524938-7407-43b2-a89b-7c70bbcd3347"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(49, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("935d22f4-18c7-43d8-82c5-89d2a8b80d70"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("66524938-7407-43b2-a89b-7c70bbcd3347"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(217, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("03920853-4e55-4b48-9e90-3a6c4c656f52"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("29f8c189-3794-4f08-8be8-6745dd76a999"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(63, 210),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(448, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("de434523-8353-4d85-a9c0-538e6d44630c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("03920853-4e55-4b48-9e90-3a6c4c656f52"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("880d01fe-ef7e-44bd-89b4-661a307352f1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("03920853-4e55-4b48-9e90-3a6c4c656f52"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				Name = @"StartMessage2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("53b19512-3f6d-4b21-b1ad-b02c455adc35"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("03920853-4e55-4b48-9e90-3a6c4c656f52"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"),
				Name = @"PageLoadCompleteScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(211, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,8,72,76,79,213,11,74,45,44,77,45,46,209,115,44,40,200,201,76,78,44,201,204,207,11,72,44,201,80,80,180,85,80,210,87,210,84,168,230,229,226,4,43,244,40,201,205,1,49,156,243,243,74,18,51,243,82,139,12,245,130,243,75,139,146,83,67,139,114,20,108,21,240,26,166,173,64,208,8,107,94,174,90,94,174,162,212,146,210,162,60,133,146,162,210,84,107,0,85,46,71,244,163,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new WorkspaceExplorerPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a7b7e00f-aaf2-4a69-9710-5d33604f14df"));
		}

		#endregion

	}

	#endregion

}

