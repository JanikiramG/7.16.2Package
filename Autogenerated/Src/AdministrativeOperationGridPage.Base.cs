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

	#region Class: AdministrativeOperationGridPageSchema

	/// <exclude/>
	public class AdministrativeOperationGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Constructors: Public

		public AdministrativeOperationGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AdministrativeOperationGridPageSchema(AdministrativeOperationGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
			RealUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
			Name = "AdministrativeOperationGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			HelpContextId = "258";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAdministrativeOperationGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateTreeGrid();
			UpdateShowChangelogMenuItem();
			UpdateCallMenuItem();
			UpdateSendTemplateEmailMenuItem();
			UpdateSendEmailMenuItem();
			UpdateButtonsControlLayout();
			UpdateContextHelpButton();
			UpdatePrintButton();
			UpdateActionButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateCopyButton();
			UpdateAddButton();
			TopLevelControl.MoveItem(0, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.MoveItem(4, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(5, ActionButton);
			ButtonsControlLayout.MoveItem(6, PrintButton);
			ButtonsControlLayout.MoveItem(7, ContextHelpButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateAdministrativeOperationGridPageEventsProcessSchema() {
			var schema = new AdministrativeOperationGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("c8fd2fd0-1f44-48c7-84e4-045250b9a638");
			DataSource.ModifiedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("8990af38-1519-487a-aea6-66f67ef018e2");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
				column.ModifiedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("0131a275-d373-421f-a3d6-57288607566f");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
				column.ModifiedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("f6ea503b-0b1c-43f2-a35f-cc1107c1a5ba");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
				column.ModifiedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("179df719-8f40-4f7e-ba62-c7ff71d89248");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
				column.ModifiedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("91713e2d-e22e-4563-9f67-4ecc99982b24");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
				column.ModifiedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("f1d2966a-5424-4a87-980a-937421aafeb9");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
				column.ModifiedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("b3c0f658-7632-4722-993d-1d0ba0e2a069");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
				column.ModifiedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("2aec9cef-232e-413a-9a5a-9ddde2e8a2af");
			if (column != null) {
				column.UId = new Guid("5cfee967-0520-4921-87d3-ab3130806634");
				column.Name = @"Code";
				column.CreatedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
				column.ModifiedInSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new AdministrativeOperationGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new AdministrativeOperationGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AdministrativeOperationGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeOperationGridPageEventsProcess

	/// <exclude/>
	public class AdministrativeOperationGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AdministrativeOperationGridPageSchemaUserControl
	{

		public AdministrativeOperationGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdministrativeOperationGridPageEventsProcess";
			SchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038");
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

		private ProcessFlowElement _processAdministrativeOperationGridPageLoadComplete;
		public ProcessFlowElement ProcessAdministrativeOperationGridPageLoadComplete {
			get {
				return _processAdministrativeOperationGridPageLoadComplete ?? (_processAdministrativeOperationGridPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ProcessAdministrativeOperationGridPageLoadComplete",
					SchemaElementUId = new Guid("0a389219-05b5-4959-a885-01d7af2d6793"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowBasePageLoadComplete;
		public ProcessThrowMessageEvent IntermediateThrowBasePageLoadComplete {
			get {
				return _intermediateThrowBasePageLoadComplete ?? (_intermediateThrowBasePageLoadComplete = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowBasePageLoadComplete",
					SchemaElementUId = new Guid("a44ce102-208e-47e8-a767-e3f3be0587eb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptAdministrativeOperationPageLoadComplete;
		public ProcessScriptTask ScriptAdministrativeOperationPageLoadComplete {
			get {
				return _scriptAdministrativeOperationPageLoadComplete ?? (_scriptAdministrativeOperationPageLoadComplete = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAdministrativeOperationPageLoadComplete",
					SchemaElementUId = new Guid("6fafa2a3-7c74-4559-8a50-eb1ace3bfb6d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAdministrativeOperationPageLoadCompleteExecute,
				});
			}
		}

		private ProcessFlowElement _startMessageAdministrativePageLoadComplete;
		public ProcessFlowElement StartMessageAdministrativePageLoadComplete {
			get {
				return _startMessageAdministrativePageLoadComplete ?? (_startMessageAdministrativePageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageAdministrativePageLoadComplete",
					SchemaElementUId = new Guid("c5a1b4e9-5608-4782-b821-6d8cb32ac845"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ProcessAdministrativeOperationGridPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessAdministrativeOperationGridPageLoadComplete };
			FlowElements[IntermediateThrowBasePageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowBasePageLoadComplete };
			FlowElements[ScriptAdministrativeOperationPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAdministrativeOperationPageLoadComplete };
			FlowElements[StartMessageAdministrativePageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageAdministrativePageLoadComplete };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ProcessAdministrativeOperationGridPageLoadComplete":
						break;
					case "IntermediateThrowBasePageLoadComplete":
						break;
					case "ScriptAdministrativeOperationPageLoadComplete":
						e.Context.QueueTasks.Enqueue("IntermediateThrowBasePageLoadComplete");
						break;
					case "StartMessageAdministrativePageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptAdministrativeOperationPageLoadComplete");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageAdministrativePageLoadComplete");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "ProcessAdministrativeOperationGridPageLoadComplete":
					context.QueueTasks.Dequeue();
					break;
				case "IntermediateThrowBasePageLoadComplete":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowBasePageLoadComplete.Execute(context);
					break;
				case "ScriptAdministrativeOperationPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAdministrativeOperationPageLoadComplete";
					result = ScriptAdministrativeOperationPageLoadComplete.Execute(context, ScriptAdministrativeOperationPageLoadCompleteExecute);
					break;
				case "StartMessageAdministrativePageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageAdministrativePageLoadComplete";
					result = StartMessageAdministrativePageLoadComplete.Execute(context);
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

		public virtual bool ScriptAdministrativeOperationPageLoadCompleteExecute(ProcessExecutingContext context) {
			NeedAddDetailRequest = false;
			IsDetailGrid = false;
			EditPageUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
			Page.DataSource.LoadRows();
			return true;
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessageAdministrativePageLoadComplete")) {
							context.QueueTasks.Enqueue("StartMessageAdministrativePageLoadComplete");
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

	#region Class: AdministrativeOperationGridPageEventsProcess

	/// <exclude/>
	public class AdministrativeOperationGridPageEventsProcess : AdministrativeOperationGridPageEventsProcess<Terrasoft.WebApp.AdministrativeOperationGridPageSchemaUserControl>
	{

		public AdministrativeOperationGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdministrativeOperationGridPageSchemaUserControl

	/// <exclude/>
	public partial class AdministrativeOperationGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (AdministrativeOperationGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AdministrativeOperationGridPageEventsProcess(UserConnection);
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
			SchemaName = "AdministrativeOperationGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeOperationGridPageEventsProcessSchema

	/// <exclude/>
	public class AdministrativeOperationGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public AdministrativeOperationGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AdministrativeOperationGridPageEventsProcessSchema(AdministrativeOperationGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AdministrativeOperationGridPageEventsProcess";
			UId = new Guid("9bfa9686-19b3-4935-8e32-6a18c326a242");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet587 = CreateLaneSet587LaneSet();
			LaneSets.Add(schemaLaneSet587);
			ProcessSchemaLane schemaLane2079 = CreateLane2079Lane();
			schemaLaneSet587.Lanes.Add(schemaLane2079);
			ProcessSchemaEventSubProcess processadministrativeoperationgridpageloadcomplete = CreateProcessAdministrativeOperationGridPageLoadCompleteEventSubProcess();
			FlowElements.Add(processadministrativeoperationgridpageloadcomplete);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowbasepageloadcomplete = CreateIntermediateThrowBasePageLoadCompleteIntermediateThrowMessageEvent();
			processadministrativeoperationgridpageloadcomplete.FlowElements.Add(intermediatethrowbasepageloadcomplete);
			ProcessSchemaScriptTask scriptadministrativeoperationpageloadcomplete = CreateScriptAdministrativeOperationPageLoadCompleteScriptTask();
			processadministrativeoperationgridpageloadcomplete.FlowElements.Add(scriptadministrativeoperationpageloadcomplete);
			ProcessSchemaStartMessageEvent startmessageadministrativepageloadcomplete = CreateStartMessageAdministrativePageLoadCompleteStartMessageEvent();
			processadministrativeoperationgridpageloadcomplete.FlowElements.Add(startmessageadministrativepageloadcomplete);
			FlowElements.Add(CreateSequenceFlow12906SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12907SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12906SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12906",
				UId = new Guid("dbf29696-7d79-461f-8b85-c6ead81f77ac"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9bfa9686-19b3-4935-8e32-6a18c326a242"),
				CurveCenterPosition = new Point(146, 1706),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9bfa9686-19b3-4935-8e32-6a18c326a242"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c5a1b4e9-5608-4782-b821-6d8cb32ac845"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6fafa2a3-7c74-4559-8a50-eb1ace3bfb6d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12907SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12907",
				UId = new Guid("92a000c1-ad11-41db-933f-e89f3814bb3c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9bfa9686-19b3-4935-8e32-6a18c326a242"),
				CurveCenterPosition = new Point(242, 1710),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9bfa9686-19b3-4935-8e32-6a18c326a242"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6fafa2a3-7c74-4559-8a50-eb1ace3bfb6d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a44ce102-208e-47e8-a767-e3f3be0587eb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet587LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet587 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("edf31416-48c1-4c85-aee1-0004ccb6ff04"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9bfa9686-19b3-4935-8e32-6a18c326a242"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("9bfa9686-19b3-4935-8e32-6a18c326a242"),
				Name = @"LaneSet587",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(891, 182),
				UseBackgroundMode = false
			};
			return schemaLaneSet587;
		}

		protected virtual ProcessSchemaLane CreateLane2079Lane() {
			ProcessSchemaLane schemaLane2079 = new ProcessSchemaLane(this) {
				UId = new Guid("221c08a7-c132-4953-bc40-5c400224aca8"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("edf31416-48c1-4c85-aee1-0004ccb6ff04"),
				CreatedInOwnerSchemaUId = new Guid("b3d00aff-db4f-4456-8c05-5d02ed73d038"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9bfa9686-19b3-4935-8e32-6a18c326a242"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("9bfa9686-19b3-4935-8e32-6a18c326a242"),
				Name = @"Lane2079",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(862, 182),
				UseBackgroundMode = false
			};
			return schemaLane2079;
		}

		protected virtual ProcessSchemaEventSubProcess CreateProcessAdministrativeOperationGridPageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaProcessAdministrativeOperationGridPageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0a389219-05b5-4959-a885-01d7af2d6793"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("221c08a7-c132-4953-bc40-5c400224aca8"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9bfa9686-19b3-4935-8e32-6a18c326a242"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("9bfa9686-19b3-4935-8e32-6a18c326a242"),
				Name = @"ProcessAdministrativeOperationGridPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 13),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(386, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaProcessAdministrativeOperationGridPageLoadComplete;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowBasePageLoadCompleteIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("a44ce102-208e-47e8-a767-e3f3be0587eb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0a389219-05b5-4959-a885-01d7af2d6793"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9bfa9686-19b3-4935-8e32-6a18c326a242"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("9bfa9686-19b3-4935-8e32-6a18c326a242"),
				Name = @"IntermediateThrowBasePageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(316, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAdministrativeOperationPageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6fafa2a3-7c74-4559-8a50-eb1ace3bfb6d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0a389219-05b5-4959-a885-01d7af2d6793"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9bfa9686-19b3-4935-8e32-6a18c326a242"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("9bfa9686-19b3-4935-8e32-6a18c326a242"),
				Name = @"ScriptAdministrativeOperationPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(148, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,69,203,205,10,130,64,20,64,225,189,79,49,184,178,197,136,153,142,202,208,34,48,68,136,8,163,7,184,206,189,202,128,56,52,63,248,250,37,45,218,158,143,115,39,194,11,98,75,30,244,50,208,59,144,243,236,204,38,88,28,201,168,119,63,232,172,198,127,189,162,246,15,152,233,213,239,113,165,141,117,65,99,18,151,199,76,77,170,26,185,168,235,134,23,170,1,62,22,185,224,217,73,52,148,149,34,175,64,196,7,25,237,111,218,130,135,167,9,86,81,122,51,128,131,217,92,242,53,75,62,216,149,121,27,72,126,0,224,187,130,112,156,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageAdministrativePageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c5a1b4e9-5608-4782-b821-6d8cb32ac845"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0a389219-05b5-4959-a885-01d7af2d6793"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9bfa9686-19b3-4935-8e32-6a18c326a242"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("9bfa9686-19b3-4935-8e32-6a18c326a242"),
				Name = @"StartMessageAdministrativePageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 62),
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

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AdministrativeOperationGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9bfa9686-19b3-4935-8e32-6a18c326a242"));
		}

		#endregion

	}

	#endregion

}

