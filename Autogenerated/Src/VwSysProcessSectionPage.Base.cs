namespace Terrasoft.WebApp
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.Security;
	using System.Text;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using TSConfiguration = Terrasoft.Configuration;
	using web = System.Web;
	using WebControls = Terrasoft.UI.WebControls.Controls;

	#region Class: VwSysProcessSectionPageSchema

	/// <exclude/>
	public class VwSysProcessSectionPageSchema : Terrasoft.WebApp.BaseModulePageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.CheckMenuItem _allSchemaVersionsMenuItem;
		public Terrasoft.UI.WebControls.Controls.CheckMenuItem AllSchemaVersionsMenuItem {
			get {
				return _allSchemaVersionsMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckMenuItem _maxVersionSchemaMenuItem;
		public Terrasoft.UI.WebControls.Controls.CheckMenuItem MaxVersionSchemaMenuItem {
			get {
				return _maxVersionSchemaMenuItem;
			}
		}

		#endregion

		#region Constructors: Public

		public VwSysProcessSectionPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public VwSysProcessSectionPageSchema(VwSysProcessSectionPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateFolderLayout() {
			FolderLayout.Image = new ControlImage {};
			FolderLayout.ModifiedInSchemaUId = new Guid("179558ce-e1f7-4d82-a00a-c6a507ce7e9f");
		}

		private void UpdateSaveToolButton() {
			SaveToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			SaveToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf"),
				ImageHash = @"4dde0eddf6e97ed8c6d821a115676e80"
			};
			SaveToolButton.ModifiedInSchemaUId = new Guid("179558ce-e1f7-4d82-a00a-c6a507ce7e9f");
		}

		private void UpdateApplyToolButton() {
			ApplyToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf"),
				ImageHash = @"4dde0eddf6e97ed8c6d821a115676e80"
			};
			ApplyToolButton.ModifiedInSchemaUId = new Guid("179558ce-e1f7-4d82-a00a-c6a507ce7e9f");
		}

		private void UpdateFilterEditLayout() {
			FilterEditLayout.Image = new ControlImage {};
			FilterEditLayout.ModifiedInSchemaUId = new Guid("179558ce-e1f7-4d82-a00a-c6a507ce7e9f");
		}

		private void UpdateLeftControlLayout() {
			LeftControlLayout.Image = new ControlImage {};
			LeftControlLayout.ModifiedInSchemaUId = new Guid("179558ce-e1f7-4d82-a00a-c6a507ce7e9f");
		}

		private void UpdateGrid() {
			Grid.PageSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
			Grid.ModifiedInSchemaUId = new Guid("179558ce-e1f7-4d82-a00a-c6a507ce7e9f");
		}

		private void UpdateGridTab() {
			GridTab.Image = new ControlImage {};
			GridTab.ModifiedInSchemaUId = new Guid("179558ce-e1f7-4d82-a00a-c6a507ce7e9f");
		}

		private void UpdateGridTabPanel() {
			GridTabPanel.AjaxEvents.TabChange.IsProcessEventHandler = true;
		}

		private void UpdateDetailsTabPanel() {
			DetailsTabPanel.AjaxEvents.TabChange.IsProcessEventHandler = true;
			DetailsTabPanel.AjaxEvents.TabChange.ShowLoadMask = true;
		}

		private void UpdateRightControlLayout() {
			RightControlLayout.Image = new ControlImage {};
			RightControlLayout.ModifiedInSchemaUId = new Guid("179558ce-e1f7-4d82-a00a-c6a507ce7e9f");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("179558ce-e1f7-4d82-a00a-c6a507ce7e9f");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("179558ce-e1f7-4d82-a00a-c6a507ce7e9f");
			RealUId = new Guid("179558ce-e1f7-4d82-a00a-c6a507ce7e9f");
			Name = "VwSysProcessSectionPage";
			ParentSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ValidationMessagePanel = "";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwSysProcessSectionPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateMainControlLayout();
			UpdateRightControlLayout();
			UpdateDetailsTabPanel();
			UpdateGridTabPanel();
			UpdateGridTab();
			UpdateGrid();
			UpdateLeftControlLayout();
			UpdateFilterEditLayout();
			UpdateApplyToolButton();
			UpdateSaveToolButton();
			UpdateFolderLayout();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, LeftControlLayout);
			LeftControlLayout.MoveItem(0, CustomSearchContainer);
			LeftControlLayout.MoveItem(1, FolderLayout);
			FolderLayout.MoveItem(0, BaseFolder);
			LeftControlLayout.MoveItem(2, FilterEditLayout);
			FilterEditLayout.MoveItem(0, FilterEdit);
			FilterEdit.MoveItem(0, SaveToolButton);
			FilterEdit.MoveItem(1, ApplyToolButton);
			MainControlLayout.MoveItem(1, RightControlLayout);
			RightControlLayout.MoveItem(0, GridTabPanel);
			GridTabPanel.MoveItem(0, GridTab);
			GridTab.MoveItem(0, Grid);
			GridTab.InsertItem(0, CreateAllSchemaVersionsMenuItem());
			GridTab.InsertItem(1, CreateMaxVersionSchemaMenuItem());
			RightControlLayout.MoveItem(1, DetailsTabPanel);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateVwSysProcessSectionPageEventsProcessSchema() {
			var schema = new VwSysProcessSectionPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckMenuItem CreateAllSchemaVersionsMenuItem() {
			_allSchemaVersionsMenuItem = new Terrasoft.UI.WebControls.Controls.CheckMenuItem();
			_allSchemaVersionsMenuItem.UId = new Guid("7ded5217-c008-4959-bb5e-3f050427a3b5");
			_allSchemaVersionsMenuItem.Name = "AllSchemaVersionsMenuItem";
			_allSchemaVersionsMenuItem.CreatedInSchemaUId = new Guid("179558ce-e1f7-4d82-a00a-c6a507ce7e9f");
			_allSchemaVersionsMenuItem.ModifiedInSchemaUId = new Guid("179558ce-e1f7-4d82-a00a-c6a507ce7e9f");
			_allSchemaVersionsMenuItem.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			_allSchemaVersionsMenuItem.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			_allSchemaVersionsMenuItem.Group = "Default";
			_allSchemaVersionsMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_allSchemaVersionsMenuItem.Image = new ControlImage {};
			_allSchemaVersionsMenuItem.Tag = "AllVersion";
			return _allSchemaVersionsMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckMenuItem CreateMaxVersionSchemaMenuItem() {
			_maxVersionSchemaMenuItem = new Terrasoft.UI.WebControls.Controls.CheckMenuItem();
			_maxVersionSchemaMenuItem.UId = new Guid("cc003592-140a-41ff-bc58-bb62e2ef92f2");
			_maxVersionSchemaMenuItem.Name = "MaxVersionSchemaMenuItem";
			_maxVersionSchemaMenuItem.CreatedInSchemaUId = new Guid("179558ce-e1f7-4d82-a00a-c6a507ce7e9f");
			_maxVersionSchemaMenuItem.ModifiedInSchemaUId = new Guid("179558ce-e1f7-4d82-a00a-c6a507ce7e9f");
			_maxVersionSchemaMenuItem.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			_maxVersionSchemaMenuItem.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			_maxVersionSchemaMenuItem.Group = "Default";
			_maxVersionSchemaMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_maxVersionSchemaMenuItem.Image = new ControlImage {};
			_maxVersionSchemaMenuItem.Tag = "LastVersion";
			return _maxVersionSchemaMenuItem;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new VwSysProcessSectionPageSchemaUserControl();
		}

		public override object Clone() {
			return new VwSysProcessSectionPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("179558ce-e1f7-4d82-a00a-c6a507ce7e9f"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new VwSysProcessSectionPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysProcessSectionPageEventsProcess

	/// <exclude/>
	public class VwSysProcessSectionPageEventsProcess<TPage> : Terrasoft.WebApp.BaseModulePageEventsProcess<TPage> where TPage : Terrasoft.WebApp.VwSysProcessSectionPageSchemaUserControl
	{

		public VwSysProcessSectionPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysProcessSectionPageEventsProcess";
			SchemaUId = new Guid("179558ce-e1f7-4d82-a00a-c6a507ce7e9f");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("179558ce-e1f7-4d82-a00a-c6a507ce7e9f");
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

		public virtual string DisplayMode {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess3;
		public ProcessFlowElement EventSubProcess3 {
			get {
				return _eventSubProcess3 ?? (_eventSubProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3",
					SchemaElementUId = new Guid("24eb1dc3-b719-419f-95cb-1fa920230863"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteStartMessage;
		public ProcessFlowElement PageLoadCompleteStartMessage {
			get {
				return _pageLoadCompleteStartMessage ?? (_pageLoadCompleteStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadCompleteStartMessage",
					SchemaElementUId = new Guid("e6db2880-0764-41d1-ac8b-ccdcfd03e368"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _basePageLoadCompleteStartMessage;
		public ProcessThrowMessageEvent BasePageLoadCompleteStartMessage {
			get {
				return _basePageLoadCompleteStartMessage ?? (_basePageLoadCompleteStartMessage = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "BasePageLoadCompleteStartMessage",
					SchemaElementUId = new Guid("d466d635-e1af-4c62-b63c-a91b0d074e4b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _pageLoadCompleteScriptTask;
		public ProcessScriptTask PageLoadCompleteScriptTask {
			get {
				return _pageLoadCompleteScriptTask ?? (_pageLoadCompleteScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageLoadCompleteScriptTask",
					SchemaElementUId = new Guid("331f8a78-08b2-49e8-8d4b-315f4b204079"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess8;
		public ProcessFlowElement EventSubProcess8 {
			get {
				return _eventSubProcess8 ?? (_eventSubProcess8 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess8",
					SchemaElementUId = new Guid("a9607c39-8d02-4836-a345-4dcf0c8feba6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3;
		public ProcessFlowElement StartMessage3 {
			get {
				return _startMessage3 ?? (_startMessage3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3",
					SchemaElementUId = new Guid("9252f51b-393d-45d4-b7a4-96936cd16422"),
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
					SchemaElementUId = new Guid("35ff1ebf-98c5-4df5-9671-1a68b70b24c9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess9;
		public ProcessFlowElement EventSubProcess9 {
			get {
				return _eventSubProcess9 ?? (_eventSubProcess9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess9",
					SchemaElementUId = new Guid("d7289eb4-54a4-42be-bfc3-a8f682598a99"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4;
		public ProcessFlowElement StartMessage4 {
			get {
				return _startMessage4 ?? (_startMessage4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4",
					SchemaElementUId = new Guid("e63f506b-94f4-4b4d-bec9-91e0b5aef2e9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask2;
		public ProcessScriptTask ScriptTask2 {
			get {
				return _scriptTask2 ?? (_scriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask2",
					SchemaElementUId = new Guid("4642ab93-226b-4352-8ead-6a3d14b94dfd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess10;
		public ProcessFlowElement EventSubProcess10 {
			get {
				return _eventSubProcess10 ?? (_eventSubProcess10 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess10",
					SchemaElementUId = new Guid("74724e0a-5adb-4cbd-9d41-0d7463aad8ee"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage5;
		public ProcessFlowElement StartMessage5 {
			get {
				return _startMessage5 ?? (_startMessage5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage5",
					SchemaElementUId = new Guid("9350fee6-835b-44f2-9c8b-afb7dab254db"),
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
					SchemaElementUId = new Guid("2c4cd5fd-abca-4b22-b3ac-c5466b383e3c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "GridTabPanelTabChange",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptTask4;
		public ProcessScriptTask ScriptTask4 {
			get {
				return _scriptTask4 ?? (_scriptTask4 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4",
					SchemaElementUId = new Guid("7dd3103b-6424-4753-ab50-3a605f3c8e24"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4Execute,
				});
			}
		}

		private LocalizableString _allSchemaVersionsTabCaption;
		public LocalizableString AllSchemaVersionsTabCaption {
			get {
				return _allSchemaVersionsTabCaption ?? (_allSchemaVersionsTabCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.AllSchemaVersionsTabCaption.Value"));
			}
		}

		private LocalizableString _maxVersionSchemaTabCaption;
		public LocalizableString MaxVersionSchemaTabCaption {
			get {
				return _maxVersionSchemaTabCaption ?? (_maxVersionSchemaTabCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.MaxVersionSchemaTabCaption.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[PageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage };
			FlowElements[BasePageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BasePageLoadCompleteStartMessage };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[StartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[StartMessage4.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4 };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[StartMessage5.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage5 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[ScriptTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3":
						break;
					case "PageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("BasePageLoadCompleteStartMessage");
						break;
					case "BasePageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						break;
					case "EventSubProcess8":
						break;
					case "StartMessage3":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
					case "EventSubProcess9":
						break;
					case "StartMessage4":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "ScriptTask2":
						break;
					case "EventSubProcess10":
						break;
					case "StartMessage5":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("ScriptTask4");
						break;
					case "ScriptTask4":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("PageLoadCompleteStartMessage");
			ActivatedEventElements.Add("StartMessage3");
			ActivatedEventElements.Add("StartMessage4");
			ActivatedEventElements.Add("StartMessage5");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteStartMessage";
					result = PageLoadCompleteStartMessage.Execute(context);
					break;
				case "BasePageLoadCompleteStartMessage":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = BasePageLoadCompleteStartMessage.Execute(context);
					break;
				case "PageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask";
					result = PageLoadCompleteScriptTask.Execute(context, PageLoadCompleteScriptTaskExecute);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3";
					result = StartMessage3.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4";
					result = StartMessage4.Execute(context);
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
					break;
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage5":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage5";
					result = StartMessage5.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "GridTabPanelTabChange");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "ScriptTask4":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4";
					result = ScriptTask4.Execute(context, ScriptTask4Execute);
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
				case "DisplayMode":
					DisplayMode = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			if (Terrasoft.Configuration.CommonUtilities.IsDemoBuild(UserConnection)) {
				Page.LeftControlLayout.Hidden = true;
			}
			Page.MaxVersionSchemaMenuItem.Checked = true;
			DisplayMode = Page.MaxVersionSchemaMenuItem.Tag;
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			if (DisplayMode == Page.AllSchemaVersionsMenuItem.Tag) {
				return true;
			}
			DisplayMode = Page.AllSchemaVersionsMenuItem.Tag;
			//Page.GridTabPanel.GridTab.Caption = AllSchemaVersionsTabCaption;
			if (Page.GridTabPanel.ActiveTabIndex == 0) {
				Page.Grid.PageInstance.Process.SetPropertyValue("DisplayMode", DisplayMode);
				Page.Grid.PageInstance.ThrowEvent("ChangeViewMode");
			}
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			if (DisplayMode == Page.MaxVersionSchemaMenuItem.Tag) {
				return true;
			}
			DisplayMode = Page.MaxVersionSchemaMenuItem.Tag;
			//((Terrasoft.UI.WebControls.Controls.Tab)(Page.GridTabPanel.FindControl("GridTab"))).Caption = MaxVersionSchemaTabCaption;
			if (Page.GridTabPanel.ActiveTabIndex == 0) {
				Page.Grid.PageInstance.Process.SetPropertyValue("DisplayMode", DisplayMode);
				Page.Grid.PageInstance.ThrowEvent("ChangeViewMode");
			}
			return true;
		}

		public virtual bool ScriptTask4Execute(ProcessExecutingContext context) {
			if (Page.GridTabPanel.ActiveTabIndex == 0) {
				Page.Grid.PageInstance.Process.SetPropertyValue("DisplayMode", DisplayMode);
				Page.Grid.PageInstance.ThrowEvent("ChangeViewMode");
			}
			return true;
		}

		public override bool OnPageLoadComlete() {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageProcessDesign");
			return base.OnPageLoadComlete();
		}

		public override void CreateAnalytics(bool hasAnalytics) {
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "AllSchemaVersionsMenuItemCheckChange":
							if (ActivatedEventElements.Contains("StartMessage3")) {
							context.QueueTasks.Enqueue("StartMessage3");
						}
						break;
					case "MaxVersionSchemaMenuItemCheckChange":
							if (ActivatedEventElements.Contains("StartMessage4")) {
							context.QueueTasks.Enqueue("StartMessage4");
						}
						break;
					case "GridTabPanelTabChange":
							if (ActivatedEventElements.Contains("StartMessage5")) {
							context.QueueTasks.Enqueue("StartMessage5");
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
			if (!HasMapping("DisplayMode") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DisplayMode", DisplayMode, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: VwSysProcessSectionPageEventsProcess

	/// <exclude/>
	public class VwSysProcessSectionPageEventsProcess : VwSysProcessSectionPageEventsProcess<Terrasoft.WebApp.VwSysProcessSectionPageSchemaUserControl>
	{

		public VwSysProcessSectionPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysProcessSectionPageSchemaUserControl

	/// <exclude/>
	public partial class VwSysProcessSectionPageSchemaUserControl : Terrasoft.WebApp.BaseModulePageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.CheckMenuItem AllSchemaVersionsMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckMenuItem)PageContainer.FindPageControl("AllSchemaVersionsMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckMenuItem MaxVersionSchemaMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckMenuItem)PageContainer.FindPageControl("MaxVersionSchemaMenuItem", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			AllSchemaVersionsMenuItem.AjaxEvents.CheckChange.Event += AllSchemaVersionsMenuItemCheckChange;
			MaxVersionSchemaMenuItem.AjaxEvents.CheckChange.Event += MaxVersionSchemaMenuItemCheckChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			AllSchemaVersionsMenuItem.AjaxEvents.CheckChange.Event -= AllSchemaVersionsMenuItemCheckChange;
			MaxVersionSchemaMenuItem.AjaxEvents.CheckChange.Event -= MaxVersionSchemaMenuItemCheckChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (VwSysProcessSectionPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new VwSysProcessSectionPageEventsProcess(UserConnection);
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

		public virtual void AllSchemaVersionsMenuItemCheckChange(object sender, EventArgs e) {
			object result = ThrowEvent("AllSchemaVersionsMenuItemCheckChange");
		}

		public virtual void MaxVersionSchemaMenuItemCheckChange(object sender, EventArgs e) {
			object result = ThrowEvent("MaxVersionSchemaMenuItemCheckChange");
		}

		public override void AddScript(string script) {
			this.ScriptManager.AddScript(script);
		}

		public override void RegisterClientScriptIncludeInternal(string key, string resourceName) {
			this.ScriptManager.RegisterClientScriptIncludeInternal(key, resourceName);
		}

		public override void RegisterClientScriptBlock(string key, string script) {
			this.ScriptManager.RegisterClientScriptBlock(key, script);
		}

		public override void SetSchemaName() {
			SchemaName = "VwSysProcessSectionPage";
		}

		#endregion

	}

	#endregion

	#region Class: VwSysProcessSectionPageEventsProcessSchema

	/// <exclude/>
	public class VwSysProcessSectionPageEventsProcessSchema : Terrasoft.WebApp.BaseModulePageEventsProcessSchema
	{

		#region Constructors: Public

		public VwSysProcessSectionPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwSysProcessSectionPageEventsProcessSchema(VwSysProcessSectionPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwSysProcessSectionPageEventsProcess";
			UId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateDisplayModeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("002b3fb0-80bd-489a-a82b-bb572ff01fec"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Name = @"DisplayMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateDisplayModeParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaLane schemaLane3 = CreateLane3Lane();
			schemaLaneSet1.Lanes.Add(schemaLane3);
			ProcessSchemaLane schemaLane4 = CreateLane4Lane();
			schemaLaneSet1.Lanes.Add(schemaLane4);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage = CreatePageLoadCompleteStartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(pageloadcompletestartmessage);
			ProcessSchemaIntermediateThrowMessageEvent basepageloadcompletestartmessage = CreateBasePageLoadCompleteStartMessageIntermediateThrowMessageEvent();
			eventsubprocess3.FlowElements.Add(basepageloadcompletestartmessage);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaStartMessageEvent startmessage3 = CreateStartMessage3StartMessageEvent();
			eventsubprocess8.FlowElements.Add(startmessage3);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess8.FlowElements.Add(scripttask1);
			ProcessSchemaStartMessageEvent startmessage4 = CreateStartMessage4StartMessageEvent();
			eventsubprocess9.FlowElements.Add(startmessage4);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess9.FlowElements.Add(scripttask2);
			ProcessSchemaStartMessageEvent startmessage5 = CreateStartMessage5StartMessageEvent();
			eventsubprocess10.FlowElements.Add(startmessage5);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess10.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask scripttask4 = CreateScriptTask4ScriptTask();
			eventsubprocess10.FlowElements.Add(scripttask4);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateAllSchemaVersionsTabCaptionLocalizableString());
			LocalizableStrings.Add(CreateMaxVersionSchemaTabCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateAllSchemaVersionsTabCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0d37d119-2aec-49bb-b978-98615a3b2deb"),
				Name = "AllSchemaVersionsTabCaption",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMaxVersionSchemaTabCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c9fee727-09a1-4c1b-9cbd-db082c7488d5"),
				Name = "MaxVersionSchemaTabCaption",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("238e9a37-a834-4d7f-bb25-7ce4546f5753"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				CurveCenterPosition = new Point(172, 88),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e6db2880-0764-41d1-ac8b-ccdcfd03e368"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d466d635-e1af-4c62-b63c-a91b0d074e4b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("1421d511-8a20-41d8-8a2e-c85182de95a1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				CurveCenterPosition = new Point(254, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d466d635-e1af-4c62-b63c-a91b0d074e4b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("331f8a78-08b2-49e8-8d4b-315f4b204079"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("f4bf1679-a076-4f67-bfce-5e6f799b7c30"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9252f51b-393d-45d4-b7a4-96936cd16422"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("35ff1ebf-98c5-4df5-9671-1a68b70b24c9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("f2183283-e727-431b-8964-bafc7e61fde1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e63f506b-94f4-4b4d-bec9-91e0b5aef2e9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4642ab93-226b-4352-8ead-6a3d14b94dfd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("84643b4e-dfa8-446c-b89e-48ce445d5e76"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9350fee6-835b-44f2-9c8b-afb7dab254db"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2c4cd5fd-abca-4b22-b3ac-c5466b383e3c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("5f7a86c3-9201-40b3-ab6e-8a4bcf877260"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				CurveCenterPosition = new Point(206, 80),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2c4cd5fd-abca-4b22-b3ac-c5466b383e3c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7dd3103b-6424-4753-ab50-3a605f3c8e24"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("42182515-e349-4565-830c-a5541bcc678e"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(585, 671),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("fb6be9a1-24fc-48fb-ab22-4473e932eb50"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("42182515-e349-4565-830c-a5541bcc678e"),
				CreatedInOwnerSchemaUId = new Guid("179558ce-e1f7-4d82-a00a-c6a507ce7e9f"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 494),
				Size = new Size(556, 177),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("e1a1d3a7-5207-45a9-8d3d-0f5a558ba908"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("42182515-e349-4565-830c-a5541bcc678e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Name = @"Lane2",
				Position = new Point(29, 327),
				Size = new Size(556, 162),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("cce67e33-1834-44ee-8ddc-bb0771dfe984"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("42182515-e349-4565-830c-a5541bcc678e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Name = @"Lane3",
				Position = new Point(29, 163),
				Size = new Size(556, 159),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaLane CreateLane4Lane() {
			ProcessSchemaLane schemaLane4 = new ProcessSchemaLane(this) {
				UId = new Guid("eb78c9c4-af9b-475c-b2e7-d9fe7fbddee3"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("42182515-e349-4565-830c-a5541bcc678e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Name = @"Lane4",
				Position = new Point(29, 0),
				Size = new Size(556, 158),
				UseBackgroundMode = false
			};
			return schemaLane4;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("24eb1dc3-b719-419f-95cb-1fa920230863"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fb6be9a1-24fc-48fb-ab22-4473e932eb50"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(299, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e6db2880-0764-41d1-ac8b-ccdcfd03e368"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("24eb1dc3-b719-419f-95cb-1fa920230863"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Name = @"PageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateBasePageLoadCompleteStartMessageIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("d466d635-e1af-4c62-b63c-a91b0d074e4b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("24eb1dc3-b719-419f-95cb-1fa920230863"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Name = @"BasePageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("331f8a78-08b2-49e8-8d4b-315f4b204079"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("24eb1dc3-b719-419f-95cb-1fa920230863"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(190, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,203,177,10,194,48,16,198,241,217,66,223,161,99,187,228,5,196,197,118,80,176,32,216,186,135,230,107,61,108,18,185,92,192,34,190,187,81,7,55,199,251,238,255,163,177,40,59,48,235,224,71,81,181,119,35,77,145,181,144,119,233,178,214,187,94,104,38,33,4,181,15,13,172,223,70,154,77,217,7,112,170,29,134,119,90,85,197,35,207,86,71,61,65,29,48,74,250,8,251,249,160,23,31,69,237,200,24,184,98,83,8,71,172,243,236,153,103,159,178,213,247,51,56,36,127,26,46,176,186,133,139,123,129,85,245,5,195,21,230,39,26,10,183,89,47,173,55,72,227,127,220,233,41,9,134,68,118,95,255,2,205,215,218,98,228,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a9607c39-8d02-4836-a345-4dcf0c8feba6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e1a1d3a7-5207-45a9-8d3d-0f5a558ba908"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Name = @"EventSubProcess8",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 138),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9252f51b-393d-45d4-b7a4-96936cd16422"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a9607c39-8d02-4836-a345-4dcf0c8feba6"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AllSchemaVersionsMenuItemCheckChange",
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Name = @"StartMessage3",
				Position = new Point(14, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("35ff1ebf-98c5-4df5-9671-1a68b70b24c9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a9607c39-8d02-4836-a345-4dcf0c8feba6"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Name = @"ScriptTask1",
				Position = new Point(77, 38),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,79,107,131,64,16,197,207,21,252,14,139,39,133,178,201,61,228,16,210,82,60,4,132,136,247,169,190,234,194,102,148,221,49,105,40,249,238,221,252,43,150,80,232,237,61,222,204,143,121,99,62,84,250,98,252,96,233,184,233,27,168,229,82,21,212,66,175,172,221,214,29,118,84,193,121,211,179,223,128,199,92,176,211,37,181,153,250,138,163,39,7,25,29,43,113,35,22,113,116,138,163,95,156,127,96,194,214,108,118,25,123,115,166,41,233,189,32,134,189,27,189,166,65,194,74,64,61,80,66,124,75,3,195,132,10,143,148,85,45,102,143,96,115,110,240,121,238,53,191,158,253,51,170,207,42,103,47,196,53,116,225,250,26,222,235,45,36,200,1,78,142,21,217,17,105,50,169,149,60,171,137,203,22,127,227,202,206,245,135,215,61,88,210,100,221,17,183,168,12,14,23,70,118,253,214,244,125,223,35,83,158,137,134,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d7289eb4-54a4-42be-bfc3-a8f682598a99"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cce67e33-1834-44ee-8ddc-bb0771dfe984"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Name = @"EventSubProcess9",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage4StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e63f506b-94f4-4b4d-bec9-91e0b5aef2e9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d7289eb4-54a4-42be-bfc3-a8f682598a99"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"MaxVersionSchemaMenuItemCheckChange",
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Name = @"StartMessage4",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4642ab93-226b-4352-8ead-6a3d14b94dfd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d7289eb4-54a4-42be-bfc3-a8f682598a99"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Name = @"ScriptTask2",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,75,107,195,48,16,132,207,53,248,63,8,159,36,40,74,239,33,135,226,62,240,193,96,136,235,158,55,246,198,22,56,43,35,173,243,160,244,191,87,73,76,112,91,74,111,51,236,234,27,237,152,173,144,79,198,15,61,156,114,219,160,88,173,68,1,45,234,28,142,21,58,111,44,173,235,14,119,144,35,141,25,227,78,151,208,42,241,17,71,119,14,121,116,36,216,141,184,140,163,207,56,250,134,249,159,18,30,45,22,82,150,232,28,120,187,101,253,150,233,119,220,164,150,216,217,222,235,155,40,97,163,228,5,247,234,76,19,92,1,132,189,126,49,212,76,59,50,153,38,137,82,74,167,48,112,72,12,127,248,25,31,54,166,97,8,55,225,242,223,212,199,154,205,30,131,205,168,193,227,185,142,135,235,185,183,85,125,86,25,121,6,170,81,23,206,214,232,189,94,35,7,57,160,227,83,5,253,136,50,153,213,145,220,139,153,83,203,191,113,101,231,236,225,121,143,196,50,73,59,160,22,43,131,135,11,67,93,91,158,215,254,5,191,124,81,70,189,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("74724e0a-5adb-4cbd-9d41-0d7463aad8ee"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eb78c9c4-af9b-475c-b2e7-d9fe7fbddee3"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Name = @"EventSubProcess10",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(284, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage5StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9350fee6-835b-44f2-9c8b-afb7dab254db"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("74724e0a-5adb-4cbd-9d41-0d7463aad8ee"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"GridTabPanelTabChange",
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Name = @"StartMessage5",
				Position = new Point(15, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("2c4cd5fd-abca-4b22-b3ac-c5466b383e3c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("74724e0a-5adb-4cbd-9d41-0d7463aad8ee"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"GridTabPanelTabChange",
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Name = @"IntermediateThrowMessageEvent1",
				Position = new Point(92, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask4ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7dd3103b-6424-4753-ab50-3a605f3c8e24"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("74724e0a-5adb-4cbd-9d41-0d7463aad8ee"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"),
				Name = @"ScriptTask4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(183, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,140,193,10,130,64,20,69,215,9,254,195,224,74,33,134,246,226,34,42,194,69,32,36,238,39,189,233,128,60,229,205,83,147,232,223,211,22,209,166,221,57,112,239,177,119,21,102,166,134,62,179,173,114,115,203,12,161,213,251,82,236,136,69,83,170,240,80,73,162,118,145,122,250,222,230,59,213,43,165,228,196,80,9,157,113,87,194,57,125,133,44,216,131,101,46,76,59,32,12,142,214,245,173,153,47,93,133,96,171,126,44,138,255,231,242,134,187,233,52,130,36,12,14,141,161,26,133,197,244,105,172,183,151,239,49,100,96,82,194,3,226,55,56,13,135,61,195,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a8d2abf8-07ab-4e55-8690-1a75dfa0f6da"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d6630e4d-7a19-48f1-9051-b7afb4319d94"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9eaf8c85-25b4-4106-b135-2ce7c11e0517"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("80e9a624-774f-4aa9-bdc1-372108d985e1"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("66c04ada-c3e9-49ab-83a7-051f50d29d99"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f1f380c2-17a6-4748-871a-be4cb513b6b0"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cafacd03-d1a2-43da-8fb1-db3dc13351a7"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8a52f61f-eae7-4d4d-8095-62319ae446eb"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f54c9c05-732e-45af-939f-13fc737c792b"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fdc1f75a-bdaa-4bb9-913e-3e80b88105af"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7e624e1a-9617-4102-957b-d7222d4aa9d1"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("bf65b20f-83ce-45ac-91fe-c1f474e2bb8a"),
				Name = "System.Security",
				Alias = "",
				CreatedInPackageId = new Guid("592586a4-2724-49fa-a693-3bd65f4bda74")
			});
		}

		protected override SchemaMethod CreateOnPageLoadComleteMethod() {
			SchemaMethod method = base.CreateOnPageLoadComleteMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,21,202,65,10,194,64,12,5,208,189,224,29,164,171,118,51,23,232,206,105,119,74,11,226,1,226,248,25,7,53,41,73,10,246,246,29,183,143,119,55,104,20,102,36,47,194,97,56,223,144,86,45,190,141,156,11,35,196,23,210,59,18,143,191,234,142,105,129,210,127,182,77,197,43,49,101,204,42,9,102,3,172,100,110,186,254,120,80,248,170,124,122,144,33,76,60,215,115,17,122,70,249,126,224,104,187,126,7,246,47,130,132,117,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateCreateAnalyticsMethod() {
			SchemaMethod method = base.CreateCreateAnalyticsMethod();
			method.IsOverride = true;
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysProcessSectionPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1cd7b34b-945d-4c20-8ecd-fb5d9cde7d45"));
		}

		#endregion

	}

	#endregion

}

