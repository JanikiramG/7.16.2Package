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

	#region Class: AdministrativeOperationEditPageSchema

	/// <exclude/>
	public class AdministrativeOperationEditPageSchema : Terrasoft.WebApp.BaseCodeLookupEditPageSchema
	{

		#region Constructors: Public

		public AdministrativeOperationEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AdministrativeOperationEditPageSchema(AdministrativeOperationEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("caf947ce-a6b8-46aa-a411-eb93a04473ed");
			NameEdit.ModifiedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
		}

		private void UpdateCodeEdit() {
			CodeEdit.Image = new ControlImage {};
			CodeEdit.ColumnUId = new Guid("f39db6aa-654c-465e-a515-ea279fd37d9b");
			CodeEdit.ModifiedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("36f91146-02b2-493c-82ba-d0aaf76eb9e5");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
			RealUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
			Name = "AdministrativeOperationEditPage";
			ParentSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 320;
			HelpContextId = "255";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAdministrativeOperationEditPageEventsProcessSchema();
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
			UpdateDescriptionEdit();
			UpdateCodeEdit();
			UpdateNameEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, NameEdit);
			MainControlLayout.MoveItem(1, CodeEdit);
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

		protected virtual EmbeddedProcessSchema CreateAdministrativeOperationEditPageEventsProcessSchema() {
			var schema = new AdministrativeOperationEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("c8fd2fd0-1f44-48c7-84e4-045250b9a638");
			DataSource.ModifiedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("98061680-500e-475f-a9f5-bdc549636e36");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
				column.ModifiedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("caf947ce-a6b8-46aa-a411-eb93a04473ed");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
				column.ModifiedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("144999ce-e8b0-4d15-8ca3-71a4e3072195");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
				column.ModifiedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("fc573977-de1d-430e-9640-5c843c5937b7");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
				column.ModifiedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("c5e4f5c3-8a2b-4563-bf36-4106004a1e17");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
				column.ModifiedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("771ba65d-fc2c-4cd7-a50e-b8771198cdd2");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
				column.ModifiedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("36f91146-02b2-493c-82ba-d0aaf76eb9e5");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
				column.ModifiedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("2aec9cef-232e-413a-9a5a-9ddde2e8a2af");
			if (column != null) {
				column.UId = new Guid("f39db6aa-654c-465e-a515-ea279fd37d9b");
				column.Name = @"Code";
				column.CreatedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
				column.ModifiedInSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
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
			return new AdministrativeOperationEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new AdministrativeOperationEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AdministrativeOperationEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeOperationEditPageEventsProcess

	/// <exclude/>
	public class AdministrativeOperationEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseCodeLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AdministrativeOperationEditPageSchemaUserControl
	{

		public AdministrativeOperationEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdministrativeOperationEditPageEventsProcess";
			SchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6");
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
					SchemaElementUId = new Guid("de870d2a-953a-4f39-9d45-367e2bf818f7"),
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
					SchemaElementUId = new Guid("7a079301-a566-4166-8086-8e7d3ef047c1"),
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
					SchemaElementUId = new Guid("2bce09ed-4e33-4ab6-a1c5-f9569a56f956"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _onPageLoadCompleteScriptTask;
		public ProcessScriptTask OnPageLoadCompleteScriptTask {
			get {
				return _onPageLoadCompleteScriptTask ?? (_onPageLoadCompleteScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OnPageLoadCompleteScriptTask",
					SchemaElementUId = new Guid("a499a1ba-4c86-4332-be51-00f370b5e4ac"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OnPageLoadCompleteScriptTaskExecute,
				});
			}
		}

		private LocalizableString _dublicateCodeMessage;
		public LocalizableString DublicateCodeMessage {
			get {
				return _dublicateCodeMessage ?? (_dublicateCodeMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DublicateCodeMessage.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[PageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[OnPageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OnPageLoadCompleteScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "PageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("OnPageLoadCompleteScriptTask");
						break;
					case "OnPageLoadCompleteScriptTask":
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
				case "PageLoadCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteStartMessage";
					result = PageLoadCompleteStartMessage.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "OnPageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OnPageLoadCompleteScriptTask";
					result = OnPageLoadCompleteScriptTask.Execute(context, OnPageLoadCompleteScriptTaskExecute);
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

		public virtual bool OnPageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			Page.BaseMessagePanel.Links.Add(new LinkConfig {
			                             LinkId = Page.CodeEdit.ClientID,
			                             Caption = Page.DataSource.Schema.Columns.GetByColumnValueName("Code").Caption
			});
			
			return true;
		}

		public override bool AreConditionsCorrect(Entity row) {
			bool notDublicateCode = true;
			string code = Page.DataSource.ActiveRow.GetTypedColumnValue<string>("Code");
			var ESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysAdminOperation"); 
			ESQ.PrimaryQueryColumn.IsAlwaysSelect = true;
			ESQ.Filters.Add(ESQ.CreateFilterWithParameters(FilterComparisonType.Equal, "Code", code));
			ESQ.Filters.Add(ESQ.CreateFilterWithParameters(FilterComparisonType.NotEqual, 
				Page.DataSource.Schema.PrimaryColumn.Name, Page.DataSource.ActiveRowPrimaryColumnValue));
			var entities = ESQ.GetEntityCollection(UserConnection);
			if (entities.Count > 0) {
				var messagePanelMessage = DublicateCodeMessage.Value;
				messagePanelMessage = string.Format(messagePanelMessage, "{" + Page.CodeEdit.ClientID + "}");
				Page.BaseMessagePanel.AddMessage(Warning, messagePanelMessage, MessageType.Warning);   
				notDublicateCode = false;
			}	
			return base.AreConditionsCorrect(row) && notDublicateCode;
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
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

	#region Class: AdministrativeOperationEditPageEventsProcess

	/// <exclude/>
	public class AdministrativeOperationEditPageEventsProcess : AdministrativeOperationEditPageEventsProcess<Terrasoft.WebApp.AdministrativeOperationEditPageSchemaUserControl>
	{

		public AdministrativeOperationEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdministrativeOperationEditPageSchemaUserControl

	/// <exclude/>
	public partial class AdministrativeOperationEditPageSchemaUserControl : Terrasoft.WebApp.BaseCodeLookupEditPageSchemaUserControl
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
			var process = (AdministrativeOperationEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AdministrativeOperationEditPageEventsProcess(UserConnection);
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
			SchemaName = "AdministrativeOperationEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeOperationEditPageEventsProcessSchema

	/// <exclude/>
	public class AdministrativeOperationEditPageEventsProcessSchema : Terrasoft.WebApp.BaseCodeLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public AdministrativeOperationEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AdministrativeOperationEditPageEventsProcessSchema(AdministrativeOperationEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AdministrativeOperationEditPageEventsProcess";
			UId = new Guid("d4bc01b2-89b1-44e2-b3ca-4299e3723ed1");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35");
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
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage = CreatePageLoadCompleteStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(pageloadcompletestartmessage);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask onpageloadcompletescripttask = CreateOnPageLoadCompleteScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(onpageloadcompletescripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateDublicateCodeMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateDublicateCodeMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d5535631-9e0a-4ef4-9c0b-a7a9452b0f87"),
				Name = "DublicateCodeMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d4bc01b2-89b1-44e2-b3ca-4299e3723ed1"),
				ModifiedInSchemaUId = new Guid("d4bc01b2-89b1-44e2-b3ca-4299e3723ed1")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("3242bb7e-305b-47f4-8243-bc71626279bb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d4bc01b2-89b1-44e2-b3ca-4299e3723ed1"),
				CurveCenterPosition = new Point(158, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d4bc01b2-89b1-44e2-b3ca-4299e3723ed1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7a079301-a566-4166-8086-8e7d3ef047c1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2bce09ed-4e33-4ab6-a1c5-f9569a56f956"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("f8a53d15-f2ba-4d19-b165-59a293eafe68"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d4bc01b2-89b1-44e2-b3ca-4299e3723ed1"),
				CurveCenterPosition = new Point(232, 88),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d4bc01b2-89b1-44e2-b3ca-4299e3723ed1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2bce09ed-4e33-4ab6-a1c5-f9569a56f956"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a499a1ba-4c86-4332-be51-00f370b5e4ac"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("07515d37-a938-4294-94d9-12035df05933"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d4bc01b2-89b1-44e2-b3ca-4299e3723ed1"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("d4bc01b2-89b1-44e2-b3ca-4299e3723ed1"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(625, 149),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("22460985-f26c-46f6-8fe1-c069afda391a"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("07515d37-a938-4294-94d9-12035df05933"),
				CreatedInOwnerSchemaUId = new Guid("510cfc7b-6889-4c9a-b426-0369e05627a6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d4bc01b2-89b1-44e2-b3ca-4299e3723ed1"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d4bc01b2-89b1-44e2-b3ca-4299e3723ed1"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(596, 149),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("de870d2a-953a-4f39-9d45-367e2bf818f7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("22460985-f26c-46f6-8fe1-c069afda391a"),
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d4bc01b2-89b1-44e2-b3ca-4299e3723ed1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d4bc01b2-89b1-44e2-b3ca-4299e3723ed1"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 0),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(315, 133),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7a079301-a566-4166-8086-8e7d3ef047c1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("de870d2a-953a-4f39-9d45-367e2bf818f7"),
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d4bc01b2-89b1-44e2-b3ca-4299e3723ed1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("d4bc01b2-89b1-44e2-b3ca-4299e3723ed1"),
				Name = @"PageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("2bce09ed-4e33-4ab6-a1c5-f9569a56f956"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("de870d2a-953a-4f39-9d45-367e2bf818f7"),
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d4bc01b2-89b1-44e2-b3ca-4299e3723ed1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("d4bc01b2-89b1-44e2-b3ca-4299e3723ed1"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(119, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOnPageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a499a1ba-4c86-4332-be51-00f370b5e4ac"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("de870d2a-953a-4f39-9d45-367e2bf818f7"),
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d4bc01b2-89b1-44e2-b3ca-4299e3723ed1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d4bc01b2-89b1-44e2-b3ca-4299e3723ed1"),
				Name = @"OnPageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(203, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,141,205,10,194,48,16,132,239,129,188,67,232,169,5,201,11,20,15,54,21,41,168,20,10,222,151,102,213,96,186,145,252,32,34,190,187,13,234,85,231,52,3,51,223,244,112,66,217,64,192,29,134,48,251,30,8,173,220,26,186,4,185,210,186,36,188,137,156,148,163,163,57,137,7,103,226,151,114,181,211,98,41,250,204,85,78,227,90,155,40,149,53,72,177,107,23,127,230,10,174,209,56,250,238,91,136,48,184,228,71,148,195,120,198,9,102,162,77,19,5,185,193,216,220,223,225,0,54,225,30,38,44,139,252,87,84,242,67,225,236,89,213,156,113,230,49,38,79,34,250,132,245,11,219,234,137,221,240,0,0,0 }
			};
			
			return ScriptTask;
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
		}

		protected override SchemaMethod CreateAreConditionsCorrectMethod() {
			SchemaMethod method = base.CreateAreConditionsCorrectMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,83,77,111,219,48,12,61,199,191,66,240,161,176,49,67,232,61,91,1,215,73,135,30,218,165,243,214,158,25,155,109,5,200,82,74,73,13,140,162,255,125,148,229,12,253,200,110,187,73,20,249,248,248,30,181,181,86,11,99,253,42,108,181,234,192,99,99,123,20,223,132,167,128,203,204,121,82,230,65,116,41,182,129,7,148,43,240,208,218,64,29,202,186,243,234,25,127,218,189,252,142,254,215,184,195,190,177,58,12,230,22,116,192,175,169,246,172,200,35,98,94,46,179,103,32,177,110,111,24,200,224,94,172,141,87,126,108,187,71,28,224,38,32,141,197,111,135,212,88,99,144,97,173,145,111,19,174,192,112,111,170,68,222,142,174,238,7,101,126,236,144,32,230,49,178,200,24,86,110,72,13,64,227,132,149,120,200,75,87,235,61,140,174,69,205,160,127,167,138,217,23,74,123,36,39,235,190,47,226,189,33,228,225,83,244,78,249,199,13,16,12,24,83,138,20,108,236,176,3,82,206,154,56,169,92,63,5,208,204,103,26,174,154,20,42,203,255,3,125,109,253,140,158,45,62,74,158,228,56,204,58,143,121,205,112,213,191,221,121,151,60,121,83,206,110,96,148,88,161,99,101,34,81,118,49,137,206,169,58,185,240,193,20,174,83,247,162,56,212,201,198,6,227,197,153,56,45,197,75,182,136,144,3,58,199,68,54,96,80,95,165,51,163,191,219,174,57,44,39,42,203,108,113,188,36,173,143,188,176,52,128,47,142,228,176,248,47,185,248,146,230,142,184,235,94,121,217,104,197,236,46,87,252,144,191,198,173,75,18,158,131,59,244,157,48,162,57,243,189,184,3,50,220,170,58,198,189,18,243,97,114,102,206,228,141,19,236,205,145,95,115,15,218,241,72,175,139,140,208,7,50,98,203,125,101,77,252,110,152,29,43,232,26,75,196,98,22,100,247,165,56,57,249,244,247,150,127,0,235,91,170,185,146,3,0,0 };
			return method;
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
			return new AdministrativeOperationEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d4bc01b2-89b1-44e2-b3ca-4299e3723ed1"));
		}

		#endregion

	}

	#endregion

}

