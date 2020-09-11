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
	using System.IO;
	using System.Resources;
	using System.Text;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.Web.Common;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: SysProcessViewPageSchema

	/// <exclude/>
	public class SysProcessViewPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.SilverlightContainer _processSilverlightContainer;
		public Terrasoft.UI.WebControls.Controls.SilverlightContainer ProcessSilverlightContainer {
			get {
				return _processSilverlightContainer;
			}
		}

		#endregion

		#region Constructors: Public

		public SysProcessViewPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysProcessViewPageSchema(SysProcessViewPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.None;
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.AutoScroll = false;
			MainControlLayout.ModifiedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.Hidden = true;
			CancelButton.ModifiedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
			RealUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
			Name = "SysProcessViewPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Width = 800;
			Height = 600;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysProcessViewPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateButtonsControlLayout();
			UpdateApplyChangesButton();
			UpdateCancelButton();
			UpdateOKButton();
			UpdateDesignerModeButton();
			UpdateContextHelpButton();
			UpdateMainControlLayout();
			UpdateCustomControls();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.InsertItem(0, CreateProcessSilverlightContainer());
			MainControlLayout.MoveItem(1, CustomControls);
			TopLevelControl.MoveItem(2, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, ContextHelpButton);
			ButtonsControlLayout.MoveItem(1, DesignerModeButton);
			ButtonsControlLayout.MoveItem(2, SpacerButton);
			ButtonsControlLayout.MoveItem(3, OKButton);
			ButtonsControlLayout.MoveItem(4, CancelButton);
			ButtonsControlLayout.MoveItem(5, ApplyChangesButton);
			TopLevelControl.MoveItem(3, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSysProcessViewPageEventsProcessSchema() {
			var schema = new SysProcessViewPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.SilverlightContainer CreateProcessSilverlightContainer() {
			_processSilverlightContainer = new Terrasoft.UI.WebControls.Controls.SilverlightContainer();
			_processSilverlightContainer.UId = new Guid("0be9e0b5-8e4d-4bd4-8372-7b214a41689c");
			_processSilverlightContainer.Name = "ProcessSilverlightContainer";
			_processSilverlightContainer.CreatedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
			_processSilverlightContainer.ModifiedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
			_processSilverlightContainer.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_processSilverlightContainer.AjaxEvents.PluginLoaded.IsProcessEventHandler = true;
			_processSilverlightContainer.Tag = "";
			_processSilverlightContainer.Source = "/ClientBin/Terrasoft.UI.WindowsControls.Process.xap";
			_processSilverlightContainer.Edges = "";
			_processSilverlightContainer.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_processSilverlightContainer.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _processSilverlightContainer;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("ac2d8e0f-a926-4f76-a1fa-604d5eaaa1d2");
			DataSource.ModifiedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("ced62f5a-76b2-42e4-a49a-1cad71a660b2");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.ModifiedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("8bcbeef6-bf2c-4e16-9511-ed5bf84b074b");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.ModifiedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("392380cd-98f4-4dae-b122-d7a5121d7eb8");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.ModifiedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("e7efbc15-fe21-4658-a916-10e2ad99ea1b");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.ModifiedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("e732c35a-3e62-4883-b2b3-e20b23cc6ba8");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.ModifiedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("7b97fbe0-a474-4207-8d0c-971130ee5629");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.ModifiedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c9f2d733-fb0a-4f8e-ad91-1eb06891d2e6");
			if (column != null) {
				column.UId = new Guid("4da71f65-524a-4b21-bba2-309be8077b01");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.ModifiedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("03e35775-3e19-4a17-b038-5b927c2f14f3");
			if (column != null) {
				column.UId = new Guid("b5b46459-7613-44e6-bf02-8b987d62e7ac");
				column.Name = @"StartDate";
				column.CreatedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.ModifiedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("453bcbc6-eae2-481f-b808-b7cfea46304b");
			if (column != null) {
				column.UId = new Guid("d956d06f-ff19-45c3-907e-5c1658c62c61");
				column.Name = @"CompleteDate";
				column.CreatedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.ModifiedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("7be578a4-bc9a-4e7e-9d00-087de2a606bd");
			if (column != null) {
				column.UId = new Guid("d44af201-60fb-44c9-a703-766b9749db10");
				column.Name = @"SysSchema";
				column.CreatedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.ModifiedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("1f85a957-c2b6-4aa1-afff-575ad9bd443e");
			if (column != null) {
				column.UId = new Guid("2b25afa2-6f3b-454c-9b1a-c31f1ec674e6");
				column.Name = @"Parent";
				column.CreatedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.ModifiedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("be00ec0f-14af-4063-ab36-ac4953e639a9");
			if (column != null) {
				column.UId = new Guid("e7f38e74-1f27-4a74-bcee-582c4e170b5b");
				column.Name = @"Status";
				column.CreatedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.ModifiedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("f4364fd0-8a42-425f-9771-9be6c83d8394");
			if (column != null) {
				column.UId = new Guid("0c63c8f4-aae7-4f61-bcaf-a1086939ae15");
				column.Name = @"Owner";
				column.CreatedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.ModifiedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b35c48a0-6ab5-4e12-b151-e108bb20f1ea");
			if (column != null) {
				column.UId = new Guid("6fb00042-1887-4b89-97d2-51d36432875c");
				column.Name = @"SysWorkspace";
				column.CreatedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.ModifiedInSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
				column.CreatedInPackageId = Guid.Empty;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new SysProcessViewPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysProcessViewPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fc771f06-fa62-4782-9b01-b858e86266f3"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysProcessViewPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysProcessViewPageEventsProcess

	/// <exclude/>
	public class SysProcessViewPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysProcessViewPageSchemaUserControl
	{

		public SysProcessViewPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysProcessViewPageEventsProcess";
			SchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fc771f06-fa62-4782-9b01-b858e86266f3");
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

		private ProcessFlowElement _subProcess2;
		public ProcessFlowElement SubProcess2 {
			get {
				return _subProcess2 ?? (_subProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess2",
					SchemaElementUId = new Guid("6df12634-abc5-4b85-ad97-eced1b6c2642"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessagePageLoadComplete;
		public ProcessFlowElement StartMessagePageLoadComplete {
			get {
				return _startMessagePageLoadComplete ?? (_startMessagePageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessagePageLoadComplete",
					SchemaElementUId = new Guid("1a103d91-3a97-4320-99ce-b67506d57a1c"),
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
					SchemaElementUId = new Guid("2a084dba-fb83-40be-9bd4-26b66b7d728c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptTaskPageLoadComplete;
		public ProcessScriptTask ScriptTaskPageLoadComplete {
			get {
				return _scriptTaskPageLoadComplete ?? (_scriptTaskPageLoadComplete = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskPageLoadComplete",
					SchemaElementUId = new Guid("e7cca454-c56f-469e-b749-a6b7a33eb894"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskPageLoadCompleteExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessSilverlightLoaded;
		public ProcessFlowElement SubProcessSilverlightLoaded {
			get {
				return _subProcessSilverlightLoaded ?? (_subProcessSilverlightLoaded = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessSilverlightLoaded",
					SchemaElementUId = new Guid("ca36e5ba-5a80-47aa-acde-d925bf8fab43"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _processSilverlightContainerPluginLoaded;
		public ProcessFlowElement ProcessSilverlightContainerPluginLoaded {
			get {
				return _processSilverlightContainerPluginLoaded ?? (_processSilverlightContainerPluginLoaded = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ProcessSilverlightContainerPluginLoaded",
					SchemaElementUId = new Guid("c263f920-c823-486f-9757-c06e26a46b53"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptProcessSilverlightContainerPluginLoaded;
		public ProcessScriptTask ScriptProcessSilverlightContainerPluginLoaded {
			get {
				return _scriptProcessSilverlightContainerPluginLoaded ?? (_scriptProcessSilverlightContainerPluginLoaded = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptProcessSilverlightContainerPluginLoaded",
					SchemaElementUId = new Guid("b3563dea-5436-475c-98b8-cdcdeb8f9fa3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptProcessSilverlightContainerPluginLoadedExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess2 };
			FlowElements[StartMessagePageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessagePageLoadComplete };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[ScriptTaskPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskPageLoadComplete };
			FlowElements[SubProcessSilverlightLoaded.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessSilverlightLoaded };
			FlowElements[ProcessSilverlightContainerPluginLoaded.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessSilverlightContainerPluginLoaded };
			FlowElements[ScriptProcessSilverlightContainerPluginLoaded.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptProcessSilverlightContainerPluginLoaded };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcess2":
						break;
					case "StartMessagePageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptTaskPageLoadComplete");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "ScriptTaskPageLoadComplete":
						break;
					case "SubProcessSilverlightLoaded":
						break;
					case "ProcessSilverlightContainerPluginLoaded":
						e.Context.QueueTasks.Enqueue("ScriptProcessSilverlightContainerPluginLoaded");
						break;
					case "ScriptProcessSilverlightContainerPluginLoaded":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessagePageLoadComplete");
			ActivatedEventElements.Add("ProcessSilverlightContainerPluginLoaded");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessagePageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessagePageLoadComplete";
					result = StartMessagePageLoadComplete.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "ScriptTaskPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskPageLoadComplete";
					result = ScriptTaskPageLoadComplete.Execute(context, ScriptTaskPageLoadCompleteExecute);
					break;
				case "SubProcessSilverlightLoaded":
					context.QueueTasks.Dequeue();
					break;
				case "ProcessSilverlightContainerPluginLoaded":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProcessSilverlightContainerPluginLoaded";
					result = ProcessSilverlightContainerPluginLoaded.Execute(context);
					break;
				case "ScriptProcessSilverlightContainerPluginLoaded":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptProcessSilverlightContainerPluginLoaded";
					result = ScriptProcessSilverlightContainerPluginLoaded.Execute(context, ScriptProcessSilverlightContainerPluginLoadedExecute);
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

		public virtual bool ScriptTaskPageLoadCompleteExecute(ProcessExecutingContext context) {
			// There is no base event. Why?
			return true;
		}

		public virtual bool ScriptProcessSilverlightContainerPluginLoadedExecute(ProcessExecutingContext context) {
			string queryString = Page.Request.QueryString.ToString();
			if (queryString.Contains("recordId")) {
				EntityPrimaryColumnValue = new Guid(Page.Request.QueryString["recordId"].ToString());
			}
			var dataSource = Page.DataSource;
			var currentStructure = dataSource.CurrentStructure;
			if (currentStructure.Columns.Count == 0) {
				EntityDataSourceUtilities.InitializeAutoDefStructure(dataSource as EntityDataSource);
			}
			currentStructure.Filters.Clear();
			string primaryColumnName = dataSource.Schema.PrimaryColumn.Name;
			currentStructure.Filters.Add(dataSource.CreateFilterWithParameters(FilterComparisonType.Equal, primaryColumnName, EntityPrimaryColumnValue));
			//if (dataSource.Schema.HierarchyColumn != null) {
			if (dataSource.CurrentStructure.IsHierarchical) {
				Terrasoft.Core.Entities.EntitySchemaColumn hierarchyColumn = (dataSource.Schema.HierarchyColumn.Clone() as Terrasoft.Core.Entities.EntitySchemaColumn);
				dataSource.CurrentStructure.IsHierarchical = false;	
			  	//dataSource.Schema.HierarchyColumn = null;	
				dataSource.LoadRows();
				dataSource.Schema.HierarchyColumn = hierarchyColumn as Terrasoft.Core.Entities.EntitySchemaColumn;
			} else {
				dataSource.LoadRows();
			}
			dataSource.SetClientActiveRow(EntityPrimaryColumnValue);
			if (dataSource.Rows.Count <= 0) {
				return true;
			}
			
			var sysSchemaId = (Guid)dataSource.Rows[0].GetColumnValue("SysSchemaId");
			ProcessSchema sourceProcessSchema = UserConnection.ProcessSchemaManager.FindInstanceByUId(sysSchemaId);
			if (sourceProcessSchema == null) {
				var processSchemaManagerItem = UserConnection.ProcessSchemaManager.GetItems().Find(
				item => item.Id == sysSchemaId);
				if (processSchemaManagerItem == null) {
					return true;
				}
				sourceProcessSchema = processSchemaManagerItem.Instance;
			}
			var resourceManager = UserConnection.Workspace.ResourceStorage
				.GetManager(sourceProcessSchema.GetResourceManagerName());
			sourceProcessSchema.ResourceManager = resourceManager;
			resourceManager.ReleaseAllResources();
			sourceProcessSchema.InitializeLocalizableValues();
			EntitySchema entitySchema = Page.UserConnection.EntitySchemaManager.GetInstanceByName("SysProcessElementLog");
			var query = new EntitySchemaQuery(entitySchema);
			EntitySchemaQueryColumn elementUIdColumn = query.AddColumn("SchemaElementUId");
			EntitySchemaQueryColumn executeCountColumn = query.AddColumn(query.CreateAggregationFunction(AggregationTypeStrict.Count,
				entitySchema.PrimaryColumn.Name));
			IEntitySchemaQueryFilterItem sysProcessIdFilter = query.CreateFilterWithParameters(FilterComparisonType.Equal, "SysProcess", EntityPrimaryColumnValue);
			query.Filters.Add(sysProcessIdFilter);
			EntityCollection entities = query.GetEntityCollection(UserConnection);
			var processSchema = new ProcessSchema(sourceProcessSchema);
			foreach (var entity in entities) {
				var elementUId = entity.GetTypedColumnValue<Guid>(elementUIdColumn.Name);
				ProcessSchemaBaseElement element = processSchema.FindBaseElementByUId(elementUId);
				if (element != null) {
					int executeCount = entity.GetTypedColumnValue<int>(executeCountColumn.Name);
					element.StatisticInfo = new ProcessSchemaElementStatisticInfo(executeCount);
				}
			}
			var sb = new StringBuilder();
			var stringWriter = new StringWriter(sb);
			JsonDataWriterSettings settings = new JsonDataWriterSettings() {
				WriteDefValues = true
			};
			using (var writer = new ProcessJsonDataWriter(settings, stringWriter)) {
				processSchema.WriteUIData(writer);
			}
			string jsonUIData = Json.Serialize(sb.ToString());
			ProcessSilverlightPluginLoadUIData(jsonUIData);
			return true;
		}

		public virtual void ProcessSilverlightPluginLoadUIData(string jsonUIData) {
			var containerClientID = Page.ProcessSilverlightContainer.ClientID;
			Page.AddScript(string.Format("{0}.scriptableObject.IsReadOnly = true;", containerClientID));
			Page.AddScript(string.Format("{0}.scriptableObject.ShowOutgoingLinkAnimation = true;", containerClientID));
			Page.AddScript(string.Format("{0}.scriptableObject.ShowIncomingLinkAnimation = true;", containerClientID));
			Page.AddScript(string.Format("{0}.scriptableObject.ReadUIData({1});", containerClientID, jsonUIData));
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessagePageLoadComplete")) {
							context.QueueTasks.Enqueue("StartMessagePageLoadComplete");
							ProcessQueue(context);
							return;
						}
						break;
					case "ProcessSilverlightContainerPluginLoaded":
							if (ActivatedEventElements.Contains("ProcessSilverlightContainerPluginLoaded")) {
							context.QueueTasks.Enqueue("ProcessSilverlightContainerPluginLoaded");
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

	#region Class: SysProcessViewPageEventsProcess

	/// <exclude/>
	public class SysProcessViewPageEventsProcess : SysProcessViewPageEventsProcess<Terrasoft.WebApp.SysProcessViewPageSchemaUserControl>
	{

		public SysProcessViewPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysProcessViewPageSchemaUserControl

	/// <exclude/>
	public partial class SysProcessViewPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.SilverlightContainer ProcessSilverlightContainer {
			get {
				return (Terrasoft.UI.WebControls.Controls.SilverlightContainer)PageContainer.FindPageControl("ProcessSilverlightContainer", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			ProcessSilverlightContainer.AjaxEvents.PluginLoaded.Event += ProcessSilverlightContainerPluginLoaded;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			ProcessSilverlightContainer.AjaxEvents.PluginLoaded.Event -= ProcessSilverlightContainerPluginLoaded;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (SysProcessViewPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysProcessViewPageEventsProcess(UserConnection);
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

		public virtual void ProcessSilverlightContainerPluginLoaded(object sender, EventArgs e) {
			object result = ThrowEvent("ProcessSilverlightContainerPluginLoaded");
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
			SchemaName = "SysProcessViewPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysProcessViewPageEventsProcessSchema

	/// <exclude/>
	public class SysProcessViewPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysProcessViewPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysProcessViewPageEventsProcessSchema(SysProcessViewPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysProcessViewPageEventsProcess";
			UId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet206 = CreateLaneSet206LaneSet();
			LaneSets.Add(schemaLaneSet206);
			ProcessSchemaLane schemaLane556 = CreateLane556Lane();
			schemaLaneSet206.Lanes.Add(schemaLane556);
			ProcessSchemaEventSubProcess subprocess2 = CreateSubProcess2EventSubProcess();
			FlowElements.Add(subprocess2);
			ProcessSchemaEventSubProcess subprocesssilverlightloaded = CreateSubProcessSilverlightLoadedEventSubProcess();
			FlowElements.Add(subprocesssilverlightloaded);
			ProcessSchemaStartMessageEvent startmessagepageloadcomplete = CreateStartMessagePageLoadCompleteStartMessageEvent();
			subprocess2.FlowElements.Add(startmessagepageloadcomplete);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			subprocess2.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask scripttaskpageloadcomplete = CreateScriptTaskPageLoadCompleteScriptTask();
			subprocess2.FlowElements.Add(scripttaskpageloadcomplete);
			ProcessSchemaStartMessageEvent processsilverlightcontainerpluginloaded = CreateProcessSilverlightContainerPluginLoadedStartMessageEvent();
			subprocesssilverlightloaded.FlowElements.Add(processsilverlightcontainerpluginloaded);
			ProcessSchemaScriptTask scriptprocesssilverlightcontainerpluginloaded = CreateScriptProcessSilverlightContainerPluginLoadedScriptTask();
			subprocesssilverlightloaded.FlowElements.Add(scriptprocesssilverlightcontainerpluginloaded);
			FlowElements.Add(CreateSequenceFlow3492SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3499SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3492SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3492",
				UId = new Guid("b0c73081-ef9d-4eba-a4e5-934151d7cdff"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c263f920-c823-486f-9757-c06e26a46b53"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b3563dea-5436-475c-98b8-cdcdeb8f9fa3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3499SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3499",
				UId = new Guid("853d5867-8c73-4e31-963c-e8b5abcdd850"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				CurveCenterPosition = new Point(140, 82),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1a103d91-3a97-4320-99ce-b67506d57a1c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e7cca454-c56f-469e-b749-a6b7a33eb894"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet206LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet206 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("a18328bd-993b-4d17-9ecd-86085c536708"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				Name = @"LaneSet206",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1293, 336),
				UseBackgroundMode = false
			};
			return schemaLaneSet206;
		}

		protected virtual ProcessSchemaLane CreateLane556Lane() {
			ProcessSchemaLane schemaLane556 = new ProcessSchemaLane(this) {
				UId = new Guid("5a73d5f2-ec1e-4345-8a57-182f93e4dcc4"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("a18328bd-993b-4d17-9ecd-86085c536708"),
				CreatedInOwnerSchemaUId = new Guid("fc771f06-fa62-4782-9b01-b858e86266f3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				Name = @"Lane556",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1264, 177),
				UseBackgroundMode = false
			};
			return schemaLane556;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6df12634-abc5-4b85-ad97-eced1b6c2642"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a73d5f2-ec1e-4345-8a57-182f93e4dcc4"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				Name = @"SubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(280, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessagePageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1a103d91-3a97-4320-99ce-b67506d57a1c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6df12634-abc5-4b85-ad97-eced1b6c2642"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				Name = @"StartMessagePageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("2a084dba-fb83-40be-9bd4-26b66b7d728c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6df12634-abc5-4b85-ad97-eced1b6c2642"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(211, 16),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskPageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e7cca454-c56f-469e-b749-a6b7a33eb894"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6df12634-abc5-4b85-ad97-eced1b6c2642"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				Name = @"ScriptTaskPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(92, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,215,87,8,201,72,45,74,85,200,44,86,200,203,87,72,74,44,78,85,72,45,75,205,43,209,83,8,207,168,180,231,42,74,45,41,45,202,83,40,41,42,77,181,6,0,68,191,136,187,44,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessSilverlightLoadedEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessSilverlightLoaded = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ca36e5ba-5a80-47aa-acde-d925bf8fab43"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a73d5f2-ec1e-4345-8a57-182f93e4dcc4"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				Name = @"SubProcessSilverlightLoaded",
				Position = new Point(29, 191),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(230, 131),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessSilverlightLoaded;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateProcessSilverlightContainerPluginLoadedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c263f920-c823-486f-9757-c06e26a46b53"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca36e5ba-5a80-47aa-acde-d925bf8fab43"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ProcessSilverlightContainerPluginLoaded",
				ModifiedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				Name = @"ProcessSilverlightContainerPluginLoaded",
				Position = new Point(14, 45),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptProcessSilverlightContainerPluginLoadedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b3563dea-5436-475c-98b8-cdcdeb8f9fa3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca36e5ba-5a80-47aa-acde-d925bf8fab43"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				Name = @"ScriptProcessSilverlightContainerPluginLoaded",
				Position = new Point(119, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,87,77,111,227,54,16,61,59,64,254,3,215,39,26,8,148,189,123,189,128,227,205,110,85,164,69,26,39,205,97,177,7,70,162,109,182,50,229,37,169,164,110,209,255,222,25,14,37,81,180,157,166,61,217,30,206,188,121,243,193,25,218,58,163,244,154,125,111,164,217,47,233,251,140,221,138,181,204,238,36,8,173,203,126,233,143,178,251,154,190,240,201,244,252,76,173,24,143,236,178,69,173,157,80,218,242,177,145,69,109,202,188,28,79,38,236,175,243,179,209,181,118,202,237,111,141,218,10,179,95,212,85,179,213,191,138,170,145,224,74,203,23,246,165,81,37,63,229,243,107,143,246,45,242,143,4,254,62,63,123,22,134,149,194,137,101,221,152,66,182,212,63,117,146,41,169,20,141,49,82,59,48,110,10,215,24,84,236,173,178,69,114,26,98,75,141,50,98,110,225,179,209,142,205,102,236,125,28,94,239,244,193,169,74,57,37,109,150,107,248,20,149,250,83,206,27,87,127,146,171,14,140,71,172,133,101,41,68,8,239,128,194,103,85,57,105,128,66,37,133,241,85,176,84,180,93,156,220,159,197,54,9,113,89,108,228,86,100,131,18,100,168,54,125,197,201,188,44,121,156,38,35,133,147,116,248,168,220,230,86,24,0,64,77,78,194,69,189,221,9,163,108,173,239,247,59,153,93,127,111,68,117,113,200,236,130,157,234,7,95,213,203,75,76,254,33,247,31,148,52,194,20,155,96,192,222,65,243,52,85,229,75,144,88,164,5,205,114,219,90,171,66,144,201,232,94,26,35,108,189,114,80,79,80,241,156,176,102,68,142,156,6,87,155,196,245,236,13,252,160,68,181,150,124,130,213,125,187,43,76,192,232,237,145,0,147,149,168,172,156,142,206,207,24,27,93,94,254,123,218,40,107,104,16,251,185,169,69,121,87,191,88,158,18,56,137,146,230,228,63,133,137,221,205,36,16,247,149,56,197,3,46,64,204,68,186,69,165,32,25,243,194,169,103,9,90,252,100,31,77,15,90,2,65,195,197,253,208,93,92,35,33,167,154,65,114,37,185,163,105,97,247,150,200,230,37,150,26,199,211,36,129,250,250,254,91,246,5,8,245,62,249,120,217,155,141,145,193,173,169,11,105,131,140,89,111,60,148,205,216,131,197,107,163,181,132,152,106,157,13,142,127,18,26,134,153,129,235,168,203,92,91,39,116,33,175,246,15,121,201,35,130,109,168,71,225,163,27,50,194,192,118,71,224,115,39,183,111,36,2,1,163,54,20,199,115,226,128,170,188,245,71,134,159,25,166,107,198,18,114,35,100,119,218,113,76,49,169,199,8,10,50,58,158,182,83,120,89,155,167,126,59,24,73,16,65,235,48,212,199,218,252,110,119,2,11,27,84,151,174,54,160,11,222,49,228,96,120,44,195,120,124,55,196,199,1,71,219,233,152,254,221,1,153,132,30,216,37,18,176,129,89,111,229,188,170,90,107,186,29,199,240,251,125,115,83,23,248,41,158,42,233,219,147,108,226,155,200,100,252,35,108,206,36,55,177,126,220,5,93,55,250,112,177,243,3,143,235,74,110,1,247,166,94,251,43,128,5,240,79,132,176,233,99,60,191,227,121,76,34,101,232,53,194,120,145,4,12,221,223,77,32,15,140,75,138,36,64,195,91,93,119,154,227,87,1,255,144,69,227,164,31,9,39,33,233,55,45,190,249,122,109,228,90,96,94,62,55,218,231,135,71,50,92,121,248,56,41,28,141,153,11,104,159,56,184,35,187,215,183,73,126,64,144,150,169,191,30,182,75,108,94,146,184,35,249,63,183,113,84,171,241,43,139,24,136,145,155,248,45,112,200,166,79,48,24,87,212,52,212,87,48,247,59,170,208,49,169,18,31,54,90,219,43,187,228,158,99,207,12,58,252,216,45,68,227,21,44,28,81,108,24,71,20,74,59,83,61,149,126,4,246,125,4,240,164,136,252,48,69,101,148,128,15,56,244,63,242,180,235,168,108,56,155,6,12,174,224,126,134,182,107,29,164,67,202,79,204,72,143,6,121,143,223,141,202,214,254,221,96,50,42,68,142,58,246,117,242,160,13,220,15,26,188,103,63,10,94,178,165,131,230,181,78,21,185,94,213,199,18,30,232,14,244,6,208,147,48,169,195,184,181,79,1,133,30,234,87,141,170,74,73,47,85,127,236,165,143,70,81,43,247,138,36,226,246,9,53,127,132,166,197,183,48,9,97,241,59,208,176,204,182,95,200,240,184,22,167,140,121,33,60,184,105,248,129,5,46,21,96,9,232,141,197,7,179,239,148,151,152,72,136,123,8,203,91,167,23,3,238,225,143,205,176,196,254,232,33,71,99,78,200,225,21,19,222,232,191,1,50,29,131,71,116,3,111,26,67,227,26,2,79,254,220,180,85,80,213,179,52,149,90,111,220,109,213,172,149,198,23,82,240,209,227,77,252,222,232,151,231,63,185,77,163,146,214,13,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateProcessSilverlightPluginLoadUIDataMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("733f55c8-5312-44c6-9a9b-bd6033bc6172"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f8512071-40bf-413f-8681-f64825226f22"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("53bbab9a-5a61-4cce-9def-4583cb530428"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b22cedfd-39cd-46e5-b5c4-6f7cd276eb74"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5d6afec9-0572-4676-9d0c-8a660a1ea2dc"),
				Name = "System.Resources",
				Alias = "",
				CreatedInPackageId = new Guid("d11c08ce-4dbf-4d8f-ae87-3e25d69a4b53")
			});
		}

		protected virtual SchemaMethod CreateProcessSilverlightPluginLoadUIDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4123574e-6920-4763-9ba7-a667c414d3ba"),
				Name = "ProcessSilverlightPluginLoadUIData",
				CreatedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5b7422da-1d28-4840-a78f-dd390224823a"),
				Name = "jsonUIData",
				CreatedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				ModifiedInSchemaUId = new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,208,193,10,130,64,16,128,225,123,79,33,157,20,100,169,179,116,8,35,16,2,37,233,1,214,117,176,169,117,54,118,71,35,196,119,79,13,79,117,10,234,60,31,243,15,211,74,235,41,67,44,145,192,198,26,129,56,217,121,27,47,147,21,136,204,26,5,206,229,168,91,176,26,171,51,199,51,21,179,141,22,19,221,150,101,174,44,222,216,119,108,145,42,177,55,182,150,236,47,187,85,47,220,52,145,133,134,180,184,128,98,145,184,35,200,50,37,253,24,82,108,27,136,150,225,251,25,65,240,213,242,252,108,238,105,195,149,25,228,1,233,186,37,28,48,26,250,81,43,33,101,234,63,180,198,151,157,146,157,100,233,119,235,62,248,184,58,244,46,206,208,75,141,153,39,239,186,88,118,223,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysProcessViewPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("43054547-24d4-46d3-8218-8637b4c5ea3f"));
		}

		#endregion

	}

	#endregion

}

