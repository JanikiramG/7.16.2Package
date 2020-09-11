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
	using System.Text;
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

	#region Class: SysMainPageShellSchema

	/// <exclude/>
	public class SysMainPageShellSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.HtmlPageContainer _htmlMainPage;
		public Terrasoft.UI.WebControls.Controls.HtmlPageContainer HtmlMainPage {
			get {
				return _htmlMainPage;
			}
		}

		#endregion

		#region Constructors: Public

		public SysMainPageShellSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysMainPageShellSchema(SysMainPageShellSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4e342d5e-bd89-4b79-98e2-22e433122403");
			RealUId = new Guid("4e342d5e-bd89-4b79-98e2-22e433122403");
			Name = "SysMainPageShell";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Maximized = true;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysMainPageShellEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateHtmlMainPage());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSysMainPageShellEventsProcessSchema() {
			var schema = new SysMainPageShellEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.HtmlPageContainer CreateHtmlMainPage() {
			_htmlMainPage = new Terrasoft.UI.WebControls.Controls.HtmlPageContainer();
			_htmlMainPage.UId = new Guid("8f313a83-1c77-422c-8c6b-d165e1cf26c5");
			_htmlMainPage.Name = "HtmlMainPage";
			_htmlMainPage.CreatedInSchemaUId = new Guid("4e342d5e-bd89-4b79-98e2-22e433122403");
			_htmlMainPage.ModifiedInSchemaUId = new Guid("4e342d5e-bd89-4b79-98e2-22e433122403");
			_htmlMainPage.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_htmlMainPage.Tag = "";
			_htmlMainPage.SourceUrl = "";
			_htmlMainPage.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_htmlMainPage.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_htmlMainPage.Edges = "";
			return _htmlMainPage;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new SysMainPageShellSchemaUserControl();
		}

		public override object Clone() {
			return new SysMainPageShellSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4e342d5e-bd89-4b79-98e2-22e433122403"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysMainPageShellEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysMainPageShellEventsProcess

	/// <exclude/>
	public class SysMainPageShellEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.SysMainPageShellSchemaUserControl
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

		public SysMainPageShellEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysMainPageShellEventsProcess";
			SchemaUId = new Guid("4e342d5e-bd89-4b79-98e2-22e433122403");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4e342d5e-bd89-4b79-98e2-22e433122403");
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

		private ProcessFlowElement _baseEventsSubProcess;
		public ProcessFlowElement BaseEventsSubProcess {
			get {
				return _baseEventsSubProcess ?? (_baseEventsSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseEventsSubProcess",
					SchemaElementUId = new Guid("2be86853-b7f5-4e2f-b552-ad3b8efce5f0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskInit;
		public ProcessScriptTask ScriptTaskInit {
			get {
				return _scriptTaskInit ?? (_scriptTaskInit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskInit",
					SchemaElementUId = new Guid("ef5dbdf0-d85a-4e58-aed3-860e62ee5cc3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskInitExecute,
				});
			}
		}

		private ProcessFlowElement _startMessageInit;
		public ProcessFlowElement StartMessageInit {
			get {
				return _startMessageInit ?? (_startMessageInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageInit",
					SchemaElementUId = new Guid("617ea5bf-d6a2-4ab1-b1fe-e54a5d7f998d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[BaseEventsSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEventsSubProcess };
			FlowElements[ScriptTaskInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskInit };
			FlowElements[StartMessageInit.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageInit };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "BaseEventsSubProcess":
						break;
					case "ScriptTaskInit":
						break;
					case "StartMessageInit":
						e.Context.QueueTasks.Enqueue("ScriptTaskInit");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageInit");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "BaseEventsSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptTaskInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskInit";
					result = ScriptTaskInit.Execute(context, ScriptTaskInitExecute);
					break;
				case "StartMessageInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageInit";
					result = StartMessageInit.Execute(context);
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

		public virtual bool ScriptTaskInitExecute(ProcessExecutingContext context) {
			if (!Ext.IsAjaxRequest) {
				var url = "ViewPage.aspx?Id=5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a";
				if (UserConnection.SessionData["MainActiveTabId"] != null) {
					var activeTabId = UserConnection.SessionData["MainActiveTabId"] as string;
					if (!string.IsNullOrEmpty(activeTabId)) {
						url = string.Format("{0}&ActiveTabId={1}", url, activeTabId);
					}
				}
				url = string.Format("{0}&SysMainPageShellClientId={1}", url, Page.HtmlMainPage.ClientID);
				Page.HtmlMainPage.SourceUrl = url;
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("StartMessageInit")) {
							context.QueueTasks.Enqueue("StartMessageInit");
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

	#region Class: SysMainPageShellEventsProcess

	/// <exclude/>
	public class SysMainPageShellEventsProcess : SysMainPageShellEventsProcess<Terrasoft.WebApp.SysMainPageShellSchemaUserControl>
	{

		public SysMainPageShellEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysMainPageShellSchemaUserControl

	/// <exclude/>
	public partial class SysMainPageShellSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.HtmlPageContainer HtmlMainPage {
			get {
				return (Terrasoft.UI.WebControls.Controls.HtmlPageContainer)PageContainer.FindPageControl("HtmlMainPage", true);
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
			var process = (SysMainPageShellEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysMainPageShellEventsProcess(UserConnection);
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
			SchemaName = "SysMainPageShell";
		}

		#endregion

	}

	#endregion

	#region Class: SysMainPageShellEventsProcessSchema

	/// <exclude/>
	public class SysMainPageShellEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public SysMainPageShellEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysMainPageShellEventsProcessSchema(SysMainPageShellEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysMainPageShellEventsProcess";
			UId = new Guid("008b786c-bd9f-43d7-b527-708a6141d00a");
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

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaShellMainlLaneSet = CreateShellMainlLaneSetLaneSet();
			LaneSets.Add(schemaShellMainlLaneSet);
			ProcessSchemaLane schemaShellPageLane = CreateShellPageLaneLane();
			schemaShellMainlLaneSet.Lanes.Add(schemaShellPageLane);
			ProcessSchemaEventSubProcess baseeventssubprocess = CreateBaseEventsSubProcessEventSubProcess();
			FlowElements.Add(baseeventssubprocess);
			ProcessSchemaScriptTask scripttaskinit = CreateScriptTaskInitScriptTask();
			baseeventssubprocess.FlowElements.Add(scripttaskinit);
			ProcessSchemaStartMessageEvent startmessageinit = CreateStartMessageInitStartMessageEvent();
			baseeventssubprocess.FlowElements.Add(startmessageinit);
			FlowElements.Add(CreateSequenceFlowInitSequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowInitSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowInit",
				UId = new Guid("21805795-99d8-4fa8-a0a3-398b8fb7a4e6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("008b786c-bd9f-43d7-b527-708a6141d00a"),
				CurveCenterPosition = new Point(383, 185),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("008b786c-bd9f-43d7-b527-708a6141d00a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("617ea5bf-d6a2-4ab1-b1fe-e54a5d7f998d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ef5dbdf0-d85a-4e58-aed3-860e62ee5cc3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateShellMainlLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaShellMainlLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("d85ad810-6f26-42e5-93d9-1d6fbadd22d5"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("008b786c-bd9f-43d7-b527-708a6141d00a"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("008b786c-bd9f-43d7-b527-708a6141d00a"),
				Name = @"ShellMainlLaneSet",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1589, 588),
				UseBackgroundMode = false
			};
			return schemaShellMainlLaneSet;
		}

		protected virtual ProcessSchemaLane CreateShellPageLaneLane() {
			ProcessSchemaLane schemaShellPageLane = new ProcessSchemaLane(this) {
				UId = new Guid("02c49dec-0830-47fa-a21f-e55bb0613134"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("d85ad810-6f26-42e5-93d9-1d6fbadd22d5"),
				CreatedInOwnerSchemaUId = new Guid("4e342d5e-bd89-4b79-98e2-22e433122403"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("008b786c-bd9f-43d7-b527-708a6141d00a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("008b786c-bd9f-43d7-b527-708a6141d00a"),
				Name = @"ShellPageLane",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1560, 588),
				UseBackgroundMode = false
			};
			return schemaShellPageLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBaseEventsSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBaseEventsSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2be86853-b7f5-4e2f-b552-ad3b8efce5f0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("02c49dec-0830-47fa-a21f-e55bb0613134"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("008b786c-bd9f-43d7-b527-708a6141d00a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("008b786c-bd9f-43d7-b527-708a6141d00a"),
				Name = @"BaseEventsSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 0),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(742, 256),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBaseEventsSubProcess;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ef5dbdf0-d85a-4e58-aed3-860e62ee5cc3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2be86853-b7f5-4e2f-b552-ad3b8efce5f0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("008b786c-bd9f-43d7-b527-708a6141d00a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("008b786c-bd9f-43d7-b527-708a6141d00a"),
				Name = @"ScriptTaskInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 156),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,144,77,75,195,64,16,134,207,21,252,15,155,28,164,129,38,180,218,32,65,130,148,182,98,15,126,96,172,23,241,48,77,38,117,101,179,169,187,155,218,18,242,223,157,124,136,21,241,224,97,103,217,217,151,247,125,102,120,202,250,214,124,103,188,133,158,188,193,238,1,223,11,212,198,97,229,241,81,111,11,138,21,74,176,144,217,79,28,63,238,97,141,30,232,205,238,114,145,132,62,250,105,0,1,186,0,231,137,59,30,82,9,112,132,238,40,62,29,199,103,105,176,242,3,176,47,200,132,83,192,82,163,154,230,82,98,108,120,46,189,8,181,166,123,6,6,158,237,27,224,114,66,253,45,62,194,106,145,216,47,204,10,153,44,132,104,25,26,8,248,254,39,152,255,185,129,102,218,40,46,215,53,76,67,99,181,111,154,248,150,98,238,212,60,219,152,125,255,32,195,233,162,123,237,240,157,252,42,87,25,152,190,93,14,171,147,131,136,176,28,85,246,160,222,211,224,144,211,105,226,42,42,245,249,211,40,218,235,26,185,94,109,244,138,66,76,5,71,105,126,186,54,123,191,54,153,248,82,122,157,106,214,132,252,254,142,242,66,197,184,108,50,201,129,68,196,160,208,20,74,50,163,10,164,198,39,26,86,148,190,247,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("617ea5bf-d6a2-4ab1-b1fe-e54a5d7f998d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2be86853-b7f5-4e2f-b552-ad3b8efce5f0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("008b786c-bd9f-43d7-b527-708a6141d00a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("008b786c-bd9f-43d7-b527-708a6141d00a"),
				Name = @"StartMessageInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("93f9b487-21e4-430b-b72b-831716bb0fa2"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysMainPageShellEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("008b786c-bd9f-43d7-b527-708a6141d00a"));
		}

		#endregion

	}

	#endregion

}

