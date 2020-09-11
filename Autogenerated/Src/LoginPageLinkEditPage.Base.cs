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

	#region Class: LoginPageLinkEditPageSchema

	/// <exclude/>
	public class LoginPageLinkEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TextEdit _linkEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit LinkEdit {
			get {
				return _linkEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public LoginPageLinkEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public LoginPageLinkEditPageSchema(LoginPageLinkEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ModifiedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
			RealUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
			Name = "LoginPageLinkEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLoginPageLinkEditPageEventsProcessSchema();
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
			UpdateNameEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, NameEdit);
			MainControlLayout.InsertItem(1, CreateLinkEdit());
			MainControlLayout.MoveItem(2, DescriptionEdit);
			MainControlLayout.MoveItem(3, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateLoginPageLinkEditPageEventsProcessSchema() {
			var schema = new LoginPageLinkEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateLinkEdit() {
			_linkEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_linkEdit.UId = new Guid("4ae10aaa-e0a4-401b-b8a0-82cb76c4e656");
			_linkEdit.Name = "LinkEdit";
			_linkEdit.CreatedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
			_linkEdit.ModifiedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
			_linkEdit.CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7");
			_linkEdit.Tag = "";
			_linkEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_linkEdit.Image = new ControlImage {};
			_linkEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_linkEdit.DataSource = "DataSource";
			_linkEdit.ColumnUId = new Guid("b31ce52f-d07c-483c-a86e-7845725720a4");
			return _linkEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("9f146202-c40f-4a14-ab9d-b543ae801ffb");
			DataSource.ModifiedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("a6659290-e160-454f-babd-4bf2d3fa5d97");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
				column.ModifiedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("a992b221-e38c-400c-8b7a-fe0cc4ae4079");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
				column.ModifiedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("c6d882cc-ac08-4a7b-97d2-100bb7722c28");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
				column.ModifiedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("c4677fe7-a28f-49d1-955d-b46b61e8740b");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
				column.ModifiedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("687d94bd-5f76-47dc-b138-1a2c8a4380b0");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
				column.ModifiedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("ad3cbf2e-151f-40a5-90f1-6382a78867d9");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
				column.ModifiedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("d9453ae9-c0db-44c5-a573-f73e355c84d3");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
				column.ModifiedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("1daafb78-846b-4877-9baf-702fcffdba1f");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
				column.ModifiedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("24df4754-c006-4741-b19e-848c5f118b1f");
			if (column != null) {
				column.UId = new Guid("b31ce52f-d07c-483c-a86e-7845725720a4");
				column.Name = @"Link";
				column.CreatedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
				column.ModifiedInSchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
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
			return new LoginPageLinkEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new LoginPageLinkEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new LoginPageLinkEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: LoginPageLinkEditPageEventsProcess

	/// <exclude/>
	public class LoginPageLinkEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.LoginPageLinkEditPageSchemaUserControl
	{

		public LoginPageLinkEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LoginPageLinkEditPageEventsProcess";
			SchemaUId = new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("19e8b381-45b2-4dc5-af5b-9089444a7966");
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

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("a9dbbdc6-c6d0-478f-a7cc-e8dea31c581f"),
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
					SchemaElementUId = new Guid("c0f470ab-2fe0-434c-833c-8128d138e807"),
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
					SchemaElementUId = new Guid("9e48dee1-aaae-4f82-8676-41803e7b56df"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OKButtonClick",
						ThrowToBase = true,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
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
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OKButtonClick");
					result = IntermediateThrowMessageEvent1.Execute(context);
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

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OKButtonClick":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
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

	#region Class: LoginPageLinkEditPageEventsProcess

	/// <exclude/>
	public class LoginPageLinkEditPageEventsProcess : LoginPageLinkEditPageEventsProcess<Terrasoft.WebApp.LoginPageLinkEditPageSchemaUserControl>
	{

		public LoginPageLinkEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LoginPageLinkEditPageSchemaUserControl

	/// <exclude/>
	public partial class LoginPageLinkEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TextEdit LinkEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("LinkEdit", true);
			}
		}

		#endregion

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
			var process = (LoginPageLinkEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new LoginPageLinkEditPageEventsProcess(UserConnection);
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
			SchemaName = "LoginPageLinkEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: LoginPageLinkEditPageEventsProcessSchema

	/// <exclude/>
	public class LoginPageLinkEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public LoginPageLinkEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LoginPageLinkEditPageEventsProcessSchema(LoginPageLinkEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LoginPageLinkEditPageEventsProcess";
			UId = new Guid("fd1a9055-8a58-4e2c-bdee-ec6c8bd2556c");
			CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage1);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatethrowmessageevent1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("ae742338-e896-431a-9177-4a0f914bde9b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7"),
				CreatedInSchemaUId = new Guid("fd1a9055-8a58-4e2c-bdee-ec6c8bd2556c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fd1a9055-8a58-4e2c-bdee-ec6c8bd2556c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c0f470ab-2fe0-434c-833c-8128d138e807"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9e48dee1-aaae-4f82-8676-41803e7b56df"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("8d709a7e-7718-4f13-9b27-a8177945b25b"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7"),
				CreatedInSchemaUId = new Guid("fd1a9055-8a58-4e2c-bdee-ec6c8bd2556c"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("fd1a9055-8a58-4e2c-bdee-ec6c8bd2556c"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(1560, 124),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("729e1c60-cea1-4505-b1d3-4bfeed4e5a60"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("8d709a7e-7718-4f13-9b27-a8177945b25b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7"),
				CreatedInSchemaUId = new Guid("fd1a9055-8a58-4e2c-bdee-ec6c8bd2556c"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("fd1a9055-8a58-4e2c-bdee-ec6c8bd2556c"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(1531, 124),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a9dbbdc6-c6d0-478f-a7cc-e8dea31c581f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("729e1c60-cea1-4505-b1d3-4bfeed4e5a60"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7"),
				CreatedInSchemaUId = new Guid("fd1a9055-8a58-4e2c-bdee-ec6c8bd2556c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fd1a9055-8a58-4e2c-bdee-ec6c8bd2556c"),
				Name = @"EventSubProcess1",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(150, 100),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c0f470ab-2fe0-434c-833c-8128d138e807"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a9dbbdc6-c6d0-478f-a7cc-e8dea31c581f"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7"),
				CreatedInSchemaUId = new Guid("fd1a9055-8a58-4e2c-bdee-ec6c8bd2556c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("fd1a9055-8a58-4e2c-bdee-ec6c8bd2556c"),
				Name = @"StartMessage1",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("9e48dee1-aaae-4f82-8676-41803e7b56df"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a9dbbdc6-c6d0-478f-a7cc-e8dea31c581f"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7"),
				CreatedInSchemaUId = new Guid("fd1a9055-8a58-4e2c-bdee-ec6c8bd2556c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("fd1a9055-8a58-4e2c-bdee-ec6c8bd2556c"),
				Name = @"IntermediateThrowMessageEvent1",
				Position = new Point(75, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b22cedfd-39cd-46e5-b5c4-6f7cd276eb74"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LoginPageLinkEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fd1a9055-8a58-4e2c-bdee-ec6c8bd2556c"));
		}

		#endregion

	}

	#endregion

}

