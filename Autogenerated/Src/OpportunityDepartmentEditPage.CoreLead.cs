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

	#region Class: OpportunityDepartmentEditPageSchema

	/// <exclude/>
	public class OpportunityDepartmentEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TextEdit _nameEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return _nameEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _sysAdminUnitEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit SysAdminUnitEdit {
			get {
				return _sysAdminUnitEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _salesDirectorEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit SalesDirectorEdit {
			get {
				return _salesDirectorEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public OpportunityDepartmentEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public OpportunityDepartmentEditPageSchema(OpportunityDepartmentEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.FitHeightByContent = true;
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
			RealUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
			Name = "OpportunityDepartmentEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOpportunityDepartmentEditPageEventsProcessSchema();
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
			MainControlLayout.MoveItem(0, CustomControls);
			CustomControls.InsertItem(0, CreateNameEdit());
			CustomControls.InsertItem(1, CreateSysAdminUnitEdit());
			CustomControls.InsertItem(2, CreateSalesDirectorEdit());
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

		protected virtual EmbeddedProcessSchema CreateOpportunityDepartmentEditPageEventsProcessSchema() {
			var schema = new OpportunityDepartmentEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateNameEdit() {
			_nameEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_nameEdit.UId = new Guid("acc47493-c8a3-4e7d-bcde-a71cd28f00de");
			_nameEdit.Name = "NameEdit";
			_nameEdit.CreatedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
			_nameEdit.ModifiedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
			_nameEdit.CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21");
			_nameEdit.Tag = "";
			_nameEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_nameEdit.Image = new ControlImage {};
			_nameEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_nameEdit.DataSource = "DataSource";
			_nameEdit.ColumnUId = new Guid("f7cdc039-1a4b-4144-92a2-8a5040b151b3");
			return _nameEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateSysAdminUnitEdit() {
			_sysAdminUnitEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_sysAdminUnitEdit.UId = new Guid("6a3a557f-1883-439a-9b22-0352d6cde402");
			_sysAdminUnitEdit.Name = "SysAdminUnitEdit";
			_sysAdminUnitEdit.CreatedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
			_sysAdminUnitEdit.ModifiedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
			_sysAdminUnitEdit.CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21");
			_sysAdminUnitEdit.Tag = "";
			_sysAdminUnitEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sysAdminUnitEdit.Image = new ControlImage {};
			_sysAdminUnitEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_sysAdminUnitEdit.DataSource = "DataSource";
			_sysAdminUnitEdit.ColumnUId = new Guid("5b31fee6-beef-4880-81ce-8ecd4cb308a5");
			return _sysAdminUnitEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateSalesDirectorEdit() {
			_salesDirectorEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_salesDirectorEdit.UId = new Guid("25e904f6-a5d1-4fd3-a716-c010791b8c46");
			_salesDirectorEdit.Name = "SalesDirectorEdit";
			_salesDirectorEdit.CreatedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
			_salesDirectorEdit.ModifiedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
			_salesDirectorEdit.CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21");
			_salesDirectorEdit.Tag = "";
			_salesDirectorEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_salesDirectorEdit.Image = new ControlImage {};
			_salesDirectorEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_salesDirectorEdit.DataSource = "DataSource";
			_salesDirectorEdit.ColumnUId = new Guid("45ceea61-cda9-44f0-934a-9e4e992e7615");
			return _salesDirectorEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("5d8456b4-15e0-4de5-b0e5-afb10f6795c0");
			DataSource.ModifiedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("e590c8ca-06a1-49fe-8ea2-51dcce4bc295");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
				column.ModifiedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("69c107d3-cdf3-4b8a-a5ac-35ce83ca9db3");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
				column.ModifiedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("534048cf-1f95-4814-814a-94950e53a047");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
				column.ModifiedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("0080faef-a560-47ef-bf1e-95a31ed4ea7c");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
				column.ModifiedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("4762d307-f892-4609-a887-0e96373b9676");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
				column.ModifiedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("f7cdc039-1a4b-4144-92a2-8a5040b151b3");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
				column.ModifiedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("9630ef08-63bd-4fa1-8f70-1bebb12fb9c7");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
				column.ModifiedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("3e881db3-4efe-46ee-97f7-5436a419fb58");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
				column.ModifiedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("5dc3e9fe-4683-488c-8151-b6ad92164a63");
			if (column != null) {
				column.UId = new Guid("5b31fee6-beef-4880-81ce-8ecd4cb308a5");
				column.Name = @"SysAdminUnit";
				column.CreatedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
				column.ModifiedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e5b2fbc9-3939-43d2-8443-aa5c9b863253");
			if (column != null) {
				column.UId = new Guid("45ceea61-cda9-44f0-934a-9e4e992e7615");
				column.Name = @"SalesDirector";
				column.CreatedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
				column.ModifiedInSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
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
			return new OpportunityDepartmentEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new OpportunityDepartmentEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new OpportunityDepartmentEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityDepartmentEditPageEventsProcess

	/// <exclude/>
	public class OpportunityDepartmentEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.OpportunityDepartmentEditPageSchemaUserControl
	{

		public OpportunityDepartmentEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityDepartmentEditPageEventsProcess";
			SchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3");
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
					SchemaElementUId = new Guid("7df4f1bf-7f78-4073-a5af-d78cfcc8b605"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _initLookupfiltersStartMessage;
		public ProcessFlowElement InitLookupfiltersStartMessage {
			get {
				return _initLookupfiltersStartMessage ?? (_initLookupfiltersStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InitLookupfiltersStartMessage",
					SchemaElementUId = new Guid("901ca0df-7221-49a5-a43e-dd639f65edec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _initLookupfiltersIntermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent InitLookupfiltersIntermediateThrowMessageEvent1 {
			get {
				return _initLookupfiltersIntermediateThrowMessageEvent1 ?? (_initLookupfiltersIntermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "InitLookupfiltersIntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("ed1c91be-fe11-4235-b2c2-daaa599f9e77"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _initLookupfiltersScriptTask;
		public ProcessScriptTask InitLookupfiltersScriptTask {
			get {
				return _initLookupfiltersScriptTask ?? (_initLookupfiltersScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitLookupfiltersScriptTask",
					SchemaElementUId = new Guid("38de8ee1-c7f9-4af9-8248-c5f059dc7c4c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitLookupfiltersScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[InitLookupfiltersStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitLookupfiltersStartMessage };
			FlowElements[InitLookupfiltersIntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { InitLookupfiltersIntermediateThrowMessageEvent1 };
			FlowElements[InitLookupfiltersScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitLookupfiltersScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "InitLookupfiltersStartMessage":
						e.Context.QueueTasks.Enqueue("InitLookupfiltersScriptTask");
						break;
					case "InitLookupfiltersIntermediateThrowMessageEvent1":
						break;
					case "InitLookupfiltersScriptTask":
						e.Context.QueueTasks.Enqueue("InitLookupfiltersIntermediateThrowMessageEvent1");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("InitLookupfiltersStartMessage");
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
				case "InitLookupfiltersStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitLookupfiltersStartMessage";
					result = InitLookupfiltersStartMessage.Execute(context);
					break;
				case "InitLookupfiltersIntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = InitLookupfiltersIntermediateThrowMessageEvent1.Execute(context);
					break;
				case "InitLookupfiltersScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitLookupfiltersScriptTask";
					result = InitLookupfiltersScriptTask.Execute(context, InitLookupfiltersScriptTaskExecute);
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

		public virtual bool InitLookupfiltersScriptTaskExecute(ProcessExecutingContext context) {
			Page.SalesDirectorEdit.PrepareLookupFilter += delegate(object sender, LookupEditEventArgs e) {
			  e.Filters.Add(new Dictionary<string, object> { 
			   {"comparisonType", FilterComparisonType.IsNotNull}, 
			   {"leftExpressionColumnPath", "[SysAdminUnit:Contact].Id"},
			   {"useDisplayValue", false}});   
			 };
			Page.SysAdminUnitEdit.PrepareLookupFilter += delegate(object sender, LookupEditEventArgs e) {
			  e.Filters.Add(new Dictionary<string, object> { 
			   {"comparisonType", FilterComparisonType.Less}, 
			   {"leftExpressionColumnPath", "SysAdminUnitTypeValue"},
			   {"useDisplayValue", false},
			  {"rightExpressionParameterValues", new object[] {4} }});   
			 };
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("InitLookupfiltersStartMessage")) {
							context.QueueTasks.Enqueue("InitLookupfiltersStartMessage");
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

	#region Class: OpportunityDepartmentEditPageEventsProcess

	/// <exclude/>
	public class OpportunityDepartmentEditPageEventsProcess : OpportunityDepartmentEditPageEventsProcess<Terrasoft.WebApp.OpportunityDepartmentEditPageSchemaUserControl>
	{

		public OpportunityDepartmentEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunityDepartmentEditPageSchemaUserControl

	/// <exclude/>
	public partial class OpportunityDepartmentEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("NameEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit SysAdminUnitEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("SysAdminUnitEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit SalesDirectorEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("SalesDirectorEdit", true);
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
			var process = (OpportunityDepartmentEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new OpportunityDepartmentEditPageEventsProcess(UserConnection);
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
			SchemaName = "OpportunityDepartmentEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityDepartmentEditPageEventsProcessSchema

	/// <exclude/>
	public class OpportunityDepartmentEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public OpportunityDepartmentEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public OpportunityDepartmentEditPageEventsProcessSchema(OpportunityDepartmentEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OpportunityDepartmentEditPageEventsProcess";
			UId = new Guid("aec7f5b5-8f40-4280-ac2c-7146338ad58c");
			CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
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
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent initlookupfiltersstartmessage = CreateInitLookupfiltersStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(initlookupfiltersstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent initlookupfiltersintermediatethrowmessageevent1 = CreateInitLookupfiltersIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(initlookupfiltersintermediatethrowmessageevent1);
			ProcessSchemaScriptTask initlookupfiltersscripttask = CreateInitLookupfiltersScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(initlookupfiltersscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("bd94a5b9-e0b8-4dd0-9e9b-5a3a6b2c6e84"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("aec7f5b5-8f40-4280-ac2c-7146338ad58c"),
				CurveCenterPosition = new Point(250, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("aec7f5b5-8f40-4280-ac2c-7146338ad58c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("38de8ee1-c7f9-4af9-8248-c5f059dc7c4c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ed1c91be-fe11-4235-b2c2-daaa599f9e77"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("9d2712c1-1339-4bfa-9352-bd7e81447744"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("aec7f5b5-8f40-4280-ac2c-7146338ad58c"),
				CurveCenterPosition = new Point(143, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("aec7f5b5-8f40-4280-ac2c-7146338ad58c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("901ca0df-7221-49a5-a43e-dd639f65edec"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("38de8ee1-c7f9-4af9-8248-c5f059dc7c4c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("aad795d8-5f9a-4b9e-8a93-eb039a053a15"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("aec7f5b5-8f40-4280-ac2c-7146338ad58c"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("aec7f5b5-8f40-4280-ac2c-7146338ad58c"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(847, 177),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("3d73e046-349f-4b0f-982a-2072c4d7f277"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("aad795d8-5f9a-4b9e-8a93-eb039a053a15"),
				CreatedInOwnerSchemaUId = new Guid("44cc8c2b-53d5-4b8b-8535-ddd0c9d796e3"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("aec7f5b5-8f40-4280-ac2c-7146338ad58c"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("aec7f5b5-8f40-4280-ac2c-7146338ad58c"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(818, 177),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7df4f1bf-7f78-4073-a5af-d78cfcc8b605"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3d73e046-349f-4b0f-982a-2072c4d7f277"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("aec7f5b5-8f40-4280-ac2c-7146338ad58c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("aec7f5b5-8f40-4280-ac2c-7146338ad58c"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(49, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(250, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitLookupfiltersStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("901ca0df-7221-49a5-a43e-dd639f65edec"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7df4f1bf-7f78-4073-a5af-d78cfcc8b605"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("aec7f5b5-8f40-4280-ac2c-7146338ad58c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("aec7f5b5-8f40-4280-ac2c-7146338ad58c"),
				Name = @"InitLookupfiltersStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(8, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateInitLookupfiltersIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("ed1c91be-fe11-4235-b2c2-daaa599f9e77"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7df4f1bf-7f78-4073-a5af-d78cfcc8b605"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("aec7f5b5-8f40-4280-ac2c-7146338ad58c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("aec7f5b5-8f40-4280-ac2c-7146338ad58c"),
				Name = @"InitLookupfiltersIntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(183, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitLookupfiltersScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("38de8ee1-c7f9-4af9-8248-c5f059dc7c4c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7df4f1bf-7f78-4073-a5af-d78cfcc8b605"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("aec7f5b5-8f40-4280-ac2c-7146338ad58c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("aec7f5b5-8f40-4280-ac2c-7146338ad58c"),
				Name = @"InitLookupfiltersScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(71, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,144,65,75,195,64,16,133,239,133,254,135,33,167,22,67,78,158,172,10,161,173,80,40,37,80,245,82,122,88,147,105,186,186,217,13,51,179,106,8,249,239,110,26,133,246,164,87,175,51,239,189,153,247,101,170,196,100,171,12,242,66,19,230,226,104,89,104,73,50,194,90,17,174,157,123,243,245,131,54,130,4,87,119,80,160,193,82,9,78,220,203,107,16,3,163,45,144,98,24,116,189,115,249,142,86,82,42,25,112,10,237,120,4,128,201,224,231,36,45,138,137,197,15,88,232,92,180,179,138,154,91,22,210,182,140,97,200,187,135,22,122,11,180,81,238,170,240,128,102,103,31,155,26,163,24,134,144,249,197,56,89,241,198,201,198,27,211,197,63,70,131,7,89,126,214,132,204,225,198,220,25,95,217,76,201,49,68,68,187,109,195,105,81,105,251,100,181,220,204,157,21,149,203,62,89,21,81,23,127,219,61,227,66,115,109,84,243,172,140,239,15,31,148,97,236,186,233,44,236,131,168,155,141,71,217,9,218,89,214,127,98,182,14,100,254,134,235,188,97,111,29,136,252,138,234,180,111,35,210,229,241,44,58,83,164,42,12,239,156,196,28,212,125,173,161,195,110,15,237,117,7,151,144,9,197,147,5,33,143,179,47,114,66,238,110,166,2,0,0 }
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
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityDepartmentEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aec7f5b5-8f40-4280-ac2c-7146338ad58c"));
		}

		#endregion

	}

	#endregion

}

