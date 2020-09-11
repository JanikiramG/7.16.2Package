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

	#region Class: ActivityStatusEditPageSchema

	/// <exclude/>
	public class ActivityStatusEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TextEdit _codeEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit CodeEdit {
			get {
				return _codeEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _finishEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox FinishEdit {
			get {
				return _finishEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public ActivityStatusEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ActivityStatusEditPageSchema(ActivityStatusEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("c650d6ef-b549-4884-93ef-f6b146689ac1");
			NameEdit.ModifiedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("6e7ae295-001b-4004-80dd-bfb5c21b1a8a");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
			RealUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
			Name = "ActivityStatusEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 320;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateActivityStatusEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(1, CreateCodeEdit());
			MainControlLayout.MoveItem(2, DescriptionEdit);
			MainControlLayout.InsertItem(3, CreateFinishEdit());
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

		protected virtual EmbeddedProcessSchema CreateActivityStatusEditPageEventsProcessSchema() {
			var schema = new ActivityStatusEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateCodeEdit() {
			_codeEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_codeEdit.UId = new Guid("881290e1-7aec-45b4-a8ca-7110a1625bcc");
			_codeEdit.Name = "CodeEdit";
			_codeEdit.CreatedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
			_codeEdit.ModifiedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
			_codeEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_codeEdit.Tag = "";
			_codeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_codeEdit.Image = new ControlImage {};
			_codeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_codeEdit.DataSource = "DataSource";
			_codeEdit.ColumnUId = new Guid("c4ac02b1-4c6b-4e22-8bae-bc9ce9893a3a");
			_codeEdit.Required = true;
			return _codeEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateFinishEdit() {
			_finishEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_finishEdit.UId = new Guid("1cd7cc2b-1cbb-4f12-89d0-fbb9a21d552d");
			_finishEdit.Name = "FinishEdit";
			_finishEdit.CreatedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
			_finishEdit.ModifiedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
			_finishEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_finishEdit.Tag = "";
			_finishEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_finishEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_finishEdit.CaptionPosition = Terrasoft.UI.WebControls.Controls.CheckBoxBaseCaptionPosition.Left;
			_finishEdit.DataSource = "DataSource";
			_finishEdit.ColumnUId = new Guid("5bd37d9d-01ba-40b2-943d-1df03fbdad5d");
			return _finishEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("805aace4-8604-40e7-a9eb-0f54174593c0");
			DataSource.ModifiedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("e562cc93-302b-4ffa-8a66-356d36f58b8e");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
				column.ModifiedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("c650d6ef-b549-4884-93ef-f6b146689ac1");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
				column.ModifiedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("b2ef60d0-dac8-4c81-b53b-33b57d2cf472");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
				column.ModifiedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("eb2c51eb-7498-43e9-8866-919abbf4c6f5");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
				column.ModifiedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("ee3f456d-62f9-41b2-9cad-9ce7d95a1e00");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
				column.ModifiedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("dd31a40f-4ae1-4e71-af61-116c492800f0");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
				column.ModifiedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("6e7ae295-001b-4004-80dd-bfb5c21b1a8a");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
				column.ModifiedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b618e983-400b-4eee-8645-f6a53fd325ec");
			if (column != null) {
				column.UId = new Guid("5bd37d9d-01ba-40b2-943d-1df03fbdad5d");
				column.Name = @"Finish";
				column.CreatedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
				column.ModifiedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("13aad544-ec30-4e76-a373-f0cff3202e24");
			if (column != null) {
				column.UId = new Guid("c4ac02b1-4c6b-4e22-8bae-bc9ce9893a3a");
				column.Name = @"Code";
				column.CreatedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
				column.ModifiedInSchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
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
			return new ActivityStatusEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new ActivityStatusEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("262927d2-870f-475a-baa9-d72bc966bd27"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ActivityStatusEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ActivityStatusEditPageEventsProcess

	/// <exclude/>
	public class ActivityStatusEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ActivityStatusEditPageSchemaUserControl
	{

		public ActivityStatusEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ActivityStatusEditPageEventsProcess";
			SchemaUId = new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("262927d2-870f-475a-baa9-d72bc966bd27");
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

	#region Class: ActivityStatusEditPageEventsProcess

	/// <exclude/>
	public class ActivityStatusEditPageEventsProcess : ActivityStatusEditPageEventsProcess<Terrasoft.WebApp.ActivityStatusEditPageSchemaUserControl>
	{

		public ActivityStatusEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ActivityStatusEditPageSchemaUserControl

	/// <exclude/>
	public partial class ActivityStatusEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TextEdit CodeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("CodeEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox FinishEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("FinishEdit", true);
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
			var process = (ActivityStatusEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ActivityStatusEditPageEventsProcess(UserConnection);
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
			SchemaName = "ActivityStatusEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: ActivityStatusEditPageEventsProcessSchema

	/// <exclude/>
	public class ActivityStatusEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ActivityStatusEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ActivityStatusEditPageEventsProcessSchema(ActivityStatusEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ActivityStatusEditPageEventsProcess";
			UId = new Guid("eb07ea0f-edae-48d8-a194-1739c23020e1");
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
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
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
			return new ActivityStatusEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eb07ea0f-edae-48d8-a194-1739c23020e1"));
		}

		#endregion

	}

	#endregion

}

