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

	#region Class: ContextElementEditPageSchema

	/// <exclude/>
	public class ContextElementEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.LookupEdit _widgetEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit WidgetEdit {
			get {
				return _widgetEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _isDefaultEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox IsDefaultEdit {
			get {
				return _isDefaultEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public ContextElementEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ContextElementEditPageSchema(ContextElementEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.DataSource = "";
			NameEdit.Enabled = false;
			NameEdit.Hidden = true;
			NameEdit.ModifiedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("75d07b68-891f-4fbd-a42a-b5f9c098b364");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
			RealUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
			Name = "ContextElementEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("9cb36bb0-ef94-4bd9-b530-e0e0d5d64a20");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateContextElementEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(0, CreateWidgetEdit());
			MainControlLayout.MoveItem(1, NameEdit);
			MainControlLayout.MoveItem(2, DescriptionEdit);
			MainControlLayout.InsertItem(3, CreateIsDefaultEdit());
			MainControlLayout.MoveItem(4, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateContextElementEditPageEventsProcessSchema() {
			var schema = new ContextElementEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateWidgetEdit() {
			_widgetEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_widgetEdit.UId = new Guid("34760eb7-f4da-4dd5-b734-1c73665e0778");
			_widgetEdit.Name = "WidgetEdit";
			_widgetEdit.CreatedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
			_widgetEdit.ModifiedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
			_widgetEdit.CreatedInPackageId = new Guid("9cb36bb0-ef94-4bd9-b530-e0e0d5d64a20");
			_widgetEdit.Tag = "";
			_widgetEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_widgetEdit.Image = new ControlImage {};
			_widgetEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_widgetEdit.Required = true;
			_widgetEdit.LookupSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			return _widgetEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsDefaultEdit() {
			_isDefaultEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isDefaultEdit.UId = new Guid("bb2326f6-cf56-4b35-902e-cd64766a0e8d");
			_isDefaultEdit.Name = "IsDefaultEdit";
			_isDefaultEdit.CreatedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
			_isDefaultEdit.ModifiedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
			_isDefaultEdit.CreatedInPackageId = new Guid("9cb36bb0-ef94-4bd9-b530-e0e0d5d64a20");
			_isDefaultEdit.Tag = "";
			_isDefaultEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isDefaultEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isDefaultEdit.CaptionPosition = Terrasoft.UI.WebControls.Controls.CheckBoxBaseCaptionPosition.Left;
			_isDefaultEdit.DataSource = "DataSource";
			_isDefaultEdit.ColumnUId = new Guid("041769c5-89ec-4a8f-9df0-5fea4b6e3977");
			return _isDefaultEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("de1889aa-69c4-4a40-b06e-88d03365e9d4");
			DataSource.ModifiedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("63cd07cf-2333-438e-815d-cf8e96adb767");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
				column.ModifiedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("6e56f384-8a1f-418a-a223-081f42a3306e");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
				column.ModifiedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("a973cf1e-3929-4d8e-a36d-1460c2cddc77");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
				column.ModifiedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("4e213010-e0c3-46fd-83af-9a74f1801dee");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
				column.ModifiedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("5d78d5c6-3e42-4bf1-90db-3c82d84fd971");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
				column.ModifiedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("51ddc213-be69-474f-b4cb-8a38654d7b75");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
				column.ModifiedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("baf2be39-2fd5-487e-8864-be2cdf31791d");
			if (column != null) {
				column.UId = new Guid("870dd35c-6029-4ce5-8f51-fffdedbb41d5");
				column.Name = @"ClientUnitSchemaUId";
				column.CreatedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
				column.ModifiedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("1960723b-09ff-462a-adad-d8fd2195ac69");
			if (column != null) {
				column.UId = new Guid("9e6bad28-9ef8-45ed-a4d1-7ca2ee979137");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
				column.ModifiedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("5cf57de2-8f47-4d48-90ea-07414707b694");
			if (column != null) {
				column.UId = new Guid("75d07b68-891f-4fbd-a42a-b5f9c098b364");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
				column.ModifiedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("cd6ce280-8f61-4f67-90e4-6b6ed9da6d0f");
			if (column != null) {
				column.UId = new Guid("041769c5-89ec-4a8f-9df0-5fea4b6e3977");
				column.Name = @"IsDefault";
				column.CreatedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
				column.ModifiedInSchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
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
			return new ContextElementEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new ContextElementEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ContextElementEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ContextElementEditPageEventsProcess

	/// <exclude/>
	public class ContextElementEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ContextElementEditPageSchemaUserControl
	{

		public ContextElementEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContextElementEditPageEventsProcess";
			SchemaUId = new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("507aaf1c-8270-4f6f-8fef-18a82a6eba96");
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

	#region Class: ContextElementEditPageEventsProcess

	/// <exclude/>
	public class ContextElementEditPageEventsProcess : ContextElementEditPageEventsProcess<Terrasoft.WebApp.ContextElementEditPageSchemaUserControl>
	{

		public ContextElementEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContextElementEditPageSchemaUserControl

	/// <exclude/>
	public partial class ContextElementEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.LookupEdit WidgetEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("WidgetEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox IsDefaultEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("IsDefaultEdit", true);
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
			var process = (ContextElementEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ContextElementEditPageEventsProcess(UserConnection);
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
			SchemaName = "ContextElementEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: ContextElementEditPageEventsProcessSchema

	/// <exclude/>
	public class ContextElementEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ContextElementEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ContextElementEditPageEventsProcessSchema(ContextElementEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ContextElementEditPageEventsProcess";
			UId = new Guid("5534e771-de3d-4568-aca9-1c2f20ca3ad4");
			CreatedInPackageId = new Guid("9cb36bb0-ef94-4bd9-b530-e0e0d5d64a20");
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
				CreatedInPackageId = new Guid("9cb36bb0-ef94-4bd9-b530-e0e0d5d64a20")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("9cb36bb0-ef94-4bd9-b530-e0e0d5d64a20")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("9cb36bb0-ef94-4bd9-b530-e0e0d5d64a20")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContextElementEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5534e771-de3d-4568-aca9-1c2f20ca3ad4"));
		}

		#endregion

	}

	#endregion

}

