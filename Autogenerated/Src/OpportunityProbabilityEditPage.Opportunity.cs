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

	#region Class: OpportunityProbabilityEditPageSchema

	/// <exclude/>
	public class OpportunityProbabilityEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _valueEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit ValueEdit {
			get {
				return _valueEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public OpportunityProbabilityEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public OpportunityProbabilityEditPageSchema(OpportunityProbabilityEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("d7ca24db-df9b-4847-b46d-7885c34a7b9a");
			NameEdit.ModifiedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("c416632d-971a-4d20-b5d5-c580c3d485c4");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
			RealUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
			Name = "OpportunityProbabilityEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 320;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOpportunityProbabilityEditPageEventsProcessSchema();
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
			UpdateNameEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, NameEdit);
			MainControlLayout.InsertItem(1, CreateValueEdit());
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

		protected virtual EmbeddedProcessSchema CreateOpportunityProbabilityEditPageEventsProcessSchema() {
			var schema = new OpportunityProbabilityEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreateValueEdit() {
			_valueEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_valueEdit.UId = new Guid("ee978039-7c19-477b-b359-fc031f9ca940");
			_valueEdit.Name = "ValueEdit";
			_valueEdit.CreatedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
			_valueEdit.ModifiedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
			_valueEdit.CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6");
			_valueEdit.Tag = "";
			_valueEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_valueEdit.Image = new ControlImage {};
			_valueEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_valueEdit.DataSource = "DataSource";
			_valueEdit.ColumnUId = new Guid("064129a4-e9ce-4a96-8475-7c57d1dabc60");
			return _valueEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("7b621c2d-9f2a-46aa-9563-eabfdc4c720f");
			DataSource.ModifiedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("ac8d087b-f883-4e61-ac16-e1e6c8b8c85c");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
				column.ModifiedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("f6eed32d-967b-4927-9f2a-47bee9b23781");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
				column.ModifiedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("75f6d55a-de20-4253-8808-02cadd26bea8");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
				column.ModifiedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("04971553-ecdd-4362-a769-b9b64f493197");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
				column.ModifiedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("3990f021-e3f2-4727-afe2-41d64507b7d8");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
				column.ModifiedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("d7ca24db-df9b-4847-b46d-7885c34a7b9a");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
				column.ModifiedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("c416632d-971a-4d20-b5d5-c580c3d485c4");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
				column.ModifiedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("94d7ee6d-c521-4213-8ae0-592c9f391a74");
			if (column != null) {
				column.UId = new Guid("064129a4-e9ce-4a96-8475-7c57d1dabc60");
				column.Name = @"Value";
				column.CreatedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
				column.ModifiedInSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
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
			return new OpportunityProbabilityEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new OpportunityProbabilityEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new OpportunityProbabilityEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityProbabilityEditPageEventsProcess

	/// <exclude/>
	public class OpportunityProbabilityEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.OpportunityProbabilityEditPageSchemaUserControl
	{

		public OpportunityProbabilityEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityProbabilityEditPageEventsProcess";
			SchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587");
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

		private ProcessFlowElement _opportunityProbabilityEditPagePageLoadCompleteEventSubProcess;
		public ProcessFlowElement OpportunityProbabilityEditPagePageLoadCompleteEventSubProcess {
			get {
				return _opportunityProbabilityEditPagePageLoadCompleteEventSubProcess ?? (_opportunityProbabilityEditPagePageLoadCompleteEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OpportunityProbabilityEditPagePageLoadCompleteEventSubProcess",
					SchemaElementUId = new Guid("6e657b34-5874-46e0-82d0-9e4c7670573a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _opportunityProbabilityEditPagePageLoadCompleteStartMessage;
		public ProcessFlowElement OpportunityProbabilityEditPagePageLoadCompleteStartMessage {
			get {
				return _opportunityProbabilityEditPagePageLoadCompleteStartMessage ?? (_opportunityProbabilityEditPagePageLoadCompleteStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OpportunityProbabilityEditPagePageLoadCompleteStartMessage",
					SchemaElementUId = new Guid("b4ef19ef-ad1c-47a1-919f-4dae08db08bb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _opportunityProbabilityEditPagePageLoadCompleteScriptTask;
		public ProcessScriptTask OpportunityProbabilityEditPagePageLoadCompleteScriptTask {
			get {
				return _opportunityProbabilityEditPagePageLoadCompleteScriptTask ?? (_opportunityProbabilityEditPagePageLoadCompleteScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OpportunityProbabilityEditPagePageLoadCompleteScriptTask",
					SchemaElementUId = new Guid("14451ccc-796b-44b4-bff6-fd60241aa96b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OpportunityProbabilityEditPagePageLoadCompleteScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _opportunityProbabilityEditPagePageLoadCompleteIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent OpportunityProbabilityEditPagePageLoadCompleteIntermediateThrowMessageEvent {
			get {
				return _opportunityProbabilityEditPagePageLoadCompleteIntermediateThrowMessageEvent ?? (_opportunityProbabilityEditPagePageLoadCompleteIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "OpportunityProbabilityEditPagePageLoadCompleteIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("e5815702-29ff-45d9-8905-172371f7f53f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[OpportunityProbabilityEditPagePageLoadCompleteEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityProbabilityEditPagePageLoadCompleteEventSubProcess };
			FlowElements[OpportunityProbabilityEditPagePageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityProbabilityEditPagePageLoadCompleteStartMessage };
			FlowElements[OpportunityProbabilityEditPagePageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityProbabilityEditPagePageLoadCompleteScriptTask };
			FlowElements[OpportunityProbabilityEditPagePageLoadCompleteIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityProbabilityEditPagePageLoadCompleteIntermediateThrowMessageEvent };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "OpportunityProbabilityEditPagePageLoadCompleteEventSubProcess":
						break;
					case "OpportunityProbabilityEditPagePageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("OpportunityProbabilityEditPagePageLoadCompleteIntermediateThrowMessageEvent");
						break;
					case "OpportunityProbabilityEditPagePageLoadCompleteScriptTask":
						break;
					case "OpportunityProbabilityEditPagePageLoadCompleteIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("OpportunityProbabilityEditPagePageLoadCompleteScriptTask");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("OpportunityProbabilityEditPagePageLoadCompleteStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "OpportunityProbabilityEditPagePageLoadCompleteEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "OpportunityProbabilityEditPagePageLoadCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpportunityProbabilityEditPagePageLoadCompleteStartMessage";
					result = OpportunityProbabilityEditPagePageLoadCompleteStartMessage.Execute(context);
					break;
				case "OpportunityProbabilityEditPagePageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpportunityProbabilityEditPagePageLoadCompleteScriptTask";
					result = OpportunityProbabilityEditPagePageLoadCompleteScriptTask.Execute(context, OpportunityProbabilityEditPagePageLoadCompleteScriptTaskExecute);
					break;
				case "OpportunityProbabilityEditPagePageLoadCompleteIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = OpportunityProbabilityEditPagePageLoadCompleteIntermediateThrowMessageEvent.Execute(context);
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

		public virtual bool OpportunityProbabilityEditPagePageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			// Specify max and min value for NumberEdit control
			Page.ValueEdit.MaxValue = 100;
			Page.ValueEdit.MinValue = 0;
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("OpportunityProbabilityEditPagePageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("OpportunityProbabilityEditPagePageLoadCompleteStartMessage");
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

	#region Class: OpportunityProbabilityEditPageEventsProcess

	/// <exclude/>
	public class OpportunityProbabilityEditPageEventsProcess : OpportunityProbabilityEditPageEventsProcess<Terrasoft.WebApp.OpportunityProbabilityEditPageSchemaUserControl>
	{

		public OpportunityProbabilityEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunityProbabilityEditPageSchemaUserControl

	/// <exclude/>
	public partial class OpportunityProbabilityEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.IntegerEdit ValueEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("ValueEdit", true);
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
			var process = (OpportunityProbabilityEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new OpportunityProbabilityEditPageEventsProcess(UserConnection);
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
			SchemaName = "OpportunityProbabilityEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityProbabilityEditPageEventsProcessSchema

	/// <exclude/>
	public class OpportunityProbabilityEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public OpportunityProbabilityEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public OpportunityProbabilityEditPageEventsProcessSchema(OpportunityProbabilityEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OpportunityProbabilityEditPageEventsProcess";
			UId = new Guid("542e7acf-44c9-4034-8dde-db5d5dad2ff8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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
			ProcessSchemaLaneSet schemaLaneSet1087 = CreateLaneSet1087LaneSet();
			LaneSets.Add(schemaLaneSet1087);
			ProcessSchemaLane schemaLane3725 = CreateLane3725Lane();
			schemaLaneSet1087.Lanes.Add(schemaLane3725);
			ProcessSchemaEventSubProcess opportunityprobabilityeditpagepageloadcompleteeventsubprocess = CreateOpportunityProbabilityEditPagePageLoadCompleteEventSubProcessEventSubProcess();
			FlowElements.Add(opportunityprobabilityeditpagepageloadcompleteeventsubprocess);
			ProcessSchemaStartMessageEvent opportunityprobabilityeditpagepageloadcompletestartmessage = CreateOpportunityProbabilityEditPagePageLoadCompleteStartMessageStartMessageEvent();
			opportunityprobabilityeditpagepageloadcompleteeventsubprocess.FlowElements.Add(opportunityprobabilityeditpagepageloadcompletestartmessage);
			ProcessSchemaScriptTask opportunityprobabilityeditpagepageloadcompletescripttask = CreateOpportunityProbabilityEditPagePageLoadCompleteScriptTaskScriptTask();
			opportunityprobabilityeditpagepageloadcompleteeventsubprocess.FlowElements.Add(opportunityprobabilityeditpagepageloadcompletescripttask);
			ProcessSchemaIntermediateThrowMessageEvent opportunityprobabilityeditpagepageloadcompleteintermediatethrowmessageevent = CreateOpportunityProbabilityEditPagePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			opportunityprobabilityeditpagepageloadcompleteeventsubprocess.FlowElements.Add(opportunityprobabilityeditpagepageloadcompleteintermediatethrowmessageevent);
			FlowElements.Add(CreateSequenceFlow21036SequenceFlow());
			FlowElements.Add(CreateSequenceFlow21037SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow21036SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow21036",
				UId = new Guid("61b39def-aa30-41c3-8507-52a11a3badac"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6"),
				CreatedInSchemaUId = new Guid("542e7acf-44c9-4034-8dde-db5d5dad2ff8"),
				CurveCenterPosition = new Point(197, 70),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("542e7acf-44c9-4034-8dde-db5d5dad2ff8"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e5815702-29ff-45d9-8905-172371f7f53f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("14451ccc-796b-44b4-bff6-fd60241aa96b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow21037SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow21037",
				UId = new Guid("17186bea-be73-474c-bb2e-1f4fe86532d8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6"),
				CreatedInSchemaUId = new Guid("542e7acf-44c9-4034-8dde-db5d5dad2ff8"),
				CurveCenterPosition = new Point(197, 70),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("542e7acf-44c9-4034-8dde-db5d5dad2ff8"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b4ef19ef-ad1c-47a1-919f-4dae08db08bb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e5815702-29ff-45d9-8905-172371f7f53f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1087LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1087 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("a615ed67-5d1e-44cd-ad69-d737218cb7e7"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6"),
				CreatedInSchemaUId = new Guid("542e7acf-44c9-4034-8dde-db5d5dad2ff8"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("542e7acf-44c9-4034-8dde-db5d5dad2ff8"),
				Name = @"LaneSet1087",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(785, 170),
				UseBackgroundMode = false
			};
			return schemaLaneSet1087;
		}

		protected virtual ProcessSchemaLane CreateLane3725Lane() {
			ProcessSchemaLane schemaLane3725 = new ProcessSchemaLane(this) {
				UId = new Guid("f1a6b96d-3257-40b0-94f8-ffd9a64601fc"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("a615ed67-5d1e-44cd-ad69-d737218cb7e7"),
				CreatedInOwnerSchemaUId = new Guid("9e278d68-77c1-4fa3-9cd6-0675f81f6587"),
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6"),
				CreatedInSchemaUId = new Guid("542e7acf-44c9-4034-8dde-db5d5dad2ff8"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("542e7acf-44c9-4034-8dde-db5d5dad2ff8"),
				Name = @"Lane3725",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(756, 170),
				UseBackgroundMode = false
			};
			return schemaLane3725;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOpportunityProbabilityEditPagePageLoadCompleteEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOpportunityProbabilityEditPagePageLoadCompleteEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6e657b34-5874-46e0-82d0-9e4c7670573a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f1a6b96d-3257-40b0-94f8-ffd9a64601fc"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6"),
				CreatedInSchemaUId = new Guid("542e7acf-44c9-4034-8dde-db5d5dad2ff8"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("542e7acf-44c9-4034-8dde-db5d5dad2ff8"),
				Name = @"OpportunityProbabilityEditPagePageLoadCompleteEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 0),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(327, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOpportunityProbabilityEditPagePageLoadCompleteEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOpportunityProbabilityEditPagePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b4ef19ef-ad1c-47a1-919f-4dae08db08bb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6e657b34-5874-46e0-82d0-9e4c7670573a"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6"),
				CreatedInSchemaUId = new Guid("542e7acf-44c9-4034-8dde-db5d5dad2ff8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("542e7acf-44c9-4034-8dde-db5d5dad2ff8"),
				Name = @"OpportunityProbabilityEditPagePageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOpportunityProbabilityEditPagePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("14451ccc-796b-44b4-bff6-fd60241aa96b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6e657b34-5874-46e0-82d0-9e4c7670573a"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6"),
				CreatedInSchemaUId = new Guid("542e7acf-44c9-4034-8dde-db5d5dad2ff8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("542e7acf-44c9-4034-8dde-db5d5dad2ff8"),
				Name = @"OpportunityProbabilityEditPagePageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(225, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,215,87,8,46,72,77,206,76,171,84,200,77,172,80,72,204,75,81,200,205,204,83,40,75,204,41,77,85,72,203,47,82,240,43,205,77,74,45,114,77,201,44,81,72,206,207,43,41,202,207,225,10,72,76,79,213,11,3,169,0,9,235,249,38,86,128,57,10,182,10,134,6,6,214,24,210,153,121,48,105,160,100,81,106,73,105,81,158,66,73,81,105,170,53,0,214,82,78,63,124,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateOpportunityProbabilityEditPagePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("e5815702-29ff-45d9-8905-172371f7f53f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6e657b34-5874-46e0-82d0-9e4c7670573a"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6"),
				CreatedInSchemaUId = new Guid("542e7acf-44c9-4034-8dde-db5d5dad2ff8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("542e7acf-44c9-4034-8dde-db5d5dad2ff8"),
				Name = @"OpportunityProbabilityEditPagePageLoadCompleteIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 58),
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

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityProbabilityEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("542e7acf-44c9-4034-8dde-db5d5dad2ff8"));
		}

		#endregion

	}

	#endregion

}

