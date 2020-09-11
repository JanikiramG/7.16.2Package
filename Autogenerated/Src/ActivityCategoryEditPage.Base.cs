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

	#region Class: ActivityCategoryEditPageSchema

	/// <exclude/>
	public class ActivityCategoryEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _activityTypeEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit ActivityTypeEdit {
			get {
				return _activityTypeEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public ActivityCategoryEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ActivityCategoryEditPageSchema(ActivityCategoryEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("df31d929-9f02-411f-9005-232188cc61ce");
			NameEdit.ModifiedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("5aa06317-d033-48da-ac34-ee41e3d76b72");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
			RealUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
			Name = "ActivityCategoryEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateActivityCategoryEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(1, CreateActivityTypeEdit());
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

		protected virtual EmbeddedProcessSchema CreateActivityCategoryEditPageEventsProcessSchema() {
			var schema = new ActivityCategoryEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateActivityTypeEdit() {
			_activityTypeEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_activityTypeEdit.UId = new Guid("7d5fd3fd-9499-4025-afe6-a9553384245b");
			_activityTypeEdit.Name = "ActivityTypeEdit";
			_activityTypeEdit.CreatedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
			_activityTypeEdit.ModifiedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
			_activityTypeEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_activityTypeEdit.Tag = "";
			_activityTypeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_activityTypeEdit.Image = new ControlImage {};
			_activityTypeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_activityTypeEdit.DataSource = "DataSource";
			_activityTypeEdit.ColumnUId = new Guid("f53e8a86-9ef0-4fc2-91a7-b5a3aa213b80");
			return _activityTypeEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("961e2086-a12b-4d27-b095-40b1e64d6cc0");
			DataSource.ModifiedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("90e250cf-ebc6-4e50-a3cd-91e5e3b8be95");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
				column.ModifiedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("72b851d1-030a-4932-afd6-0ccc71f1aa39");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
				column.ModifiedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("953000e4-002f-44b9-b4bf-281d2889413d");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
				column.ModifiedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("6fa8f961-a13c-48ab-aa3a-9f3385a403ca");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
				column.ModifiedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("43b0a51c-5484-4c57-9cfb-b9a27c9a5815");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
				column.ModifiedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("df31d929-9f02-411f-9005-232188cc61ce");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
				column.ModifiedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("5aa06317-d033-48da-ac34-ee41e3d76b72");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
				column.ModifiedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ca94a324-e7f1-44ab-b1b7-98cdfabd9c11");
			if (column != null) {
				column.UId = new Guid("f53e8a86-9ef0-4fc2-91a7-b5a3aa213b80");
				column.Name = @"ActivityType";
				column.CreatedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
				column.ModifiedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("f807b92e-22aa-4a36-9024-329eb90d5ecc");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
				column.ModifiedInSchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
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
			return new ActivityCategoryEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new ActivityCategoryEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9f21b836-c079-4424-b0a8-c40b782cf790"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ActivityCategoryEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ActivityCategoryEditPageEventsProcess

	/// <exclude/>
	public class ActivityCategoryEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ActivityCategoryEditPageSchemaUserControl
	{

		public ActivityCategoryEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ActivityCategoryEditPageEventsProcess";
			SchemaUId = new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9f21b836-c079-4424-b0a8-c40b782cf790");
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

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
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

	#region Class: ActivityCategoryEditPageEventsProcess

	/// <exclude/>
	public class ActivityCategoryEditPageEventsProcess : ActivityCategoryEditPageEventsProcess<Terrasoft.WebApp.ActivityCategoryEditPageSchemaUserControl>
	{

		public ActivityCategoryEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ActivityCategoryEditPageSchemaUserControl

	/// <exclude/>
	public partial class ActivityCategoryEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit ActivityTypeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("ActivityTypeEdit", true);
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
			var process = (ActivityCategoryEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ActivityCategoryEditPageEventsProcess(UserConnection);
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
			SchemaName = "ActivityCategoryEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: ActivityCategoryEditPageEventsProcessSchema

	/// <exclude/>
	public class ActivityCategoryEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ActivityCategoryEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ActivityCategoryEditPageEventsProcessSchema(ActivityCategoryEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ActivityCategoryEditPageEventsProcess";
			UId = new Guid("b04f7e4d-2a7e-4a6e-b62a-12ac5b391db7");
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
			return new ActivityCategoryEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b04f7e4d-2a7e-4a6e-b62a-12ac5b391db7"));
		}

		#endregion

	}

	#endregion

}

