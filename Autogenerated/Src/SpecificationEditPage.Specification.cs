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

	#region Class: SpecificationEditPageSchema

	/// <exclude/>
	public class SpecificationEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _typeEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit TypeEdit {
			get {
				return _typeEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public SpecificationEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SpecificationEditPageSchema(SpecificationEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("efa50906-851c-4cf4-a08c-8963e8ea4fa3");
			NameEdit.ModifiedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
		}

		private void UpdateCustomControls() {
			CustomControls.FitHeightByContent = true;
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("127529ad-a12d-4f8d-9f69-b6c15954f055");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
			RealUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
			Name = "SpecificationEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSpecificationEditPageEventsProcessSchema();
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
			UpdateDescriptionEdit();
			UpdateCustomControls();
			UpdateNameEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, NameEdit);
			MainControlLayout.MoveItem(1, CustomControls);
			CustomControls.InsertItem(0, CreateTypeEdit());
			MainControlLayout.MoveItem(2, DescriptionEdit);
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

		protected virtual EmbeddedProcessSchema CreateSpecificationEditPageEventsProcessSchema() {
			var schema = new SpecificationEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateTypeEdit() {
			_typeEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_typeEdit.UId = new Guid("65cb9375-07ad-40b8-b8b3-81966840b107");
			_typeEdit.Name = "TypeEdit";
			_typeEdit.CreatedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
			_typeEdit.ModifiedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
			_typeEdit.CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
			_typeEdit.Tag = "";
			_typeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_typeEdit.Image = new ControlImage {};
			_typeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_typeEdit.DataSource = "DataSource";
			_typeEdit.ColumnUId = new Guid("7e794fa8-ed3e-4c25-8b2f-13c34e413b5f");
			return _typeEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("ec3cebc4-ea18-40ea-9b0f-e348570481ef");
			DataSource.ModifiedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("7e79e30f-765f-4089-a0bd-125684893d88");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
				column.ModifiedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("25e9a99c-ac49-4154-969c-de56c6fc7b3d");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
				column.ModifiedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("8070ffcf-8378-4e74-a12f-17afebfc20e7");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
				column.ModifiedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("aaac8dee-eec8-49a6-aa39-7f944e031b08");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
				column.ModifiedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("a7fbf10a-617a-41e0-a430-d08d6ea88cb9");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
				column.ModifiedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("b495c53f-6e91-4fda-958a-fb8b63598baa");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
				column.ModifiedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3c956bc9-fc5b-422b-9eec-2d3806df2e5b");
			if (column != null) {
				column.UId = new Guid("efa50906-851c-4cf4-a08c-8963e8ea4fa3");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
				column.ModifiedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("fb8e1b40-dec1-4ea7-851d-4225fc9ead06");
			if (column != null) {
				column.UId = new Guid("7e794fa8-ed3e-4c25-8b2f-13c34e413b5f");
				column.Name = @"Type";
				column.CreatedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
				column.ModifiedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("d1509949-c97b-4560-8b90-f257f9511d14");
			if (column != null) {
				column.UId = new Guid("127529ad-a12d-4f8d-9f69-b6c15954f055");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
				column.ModifiedInSchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
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
			return new SpecificationEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new SpecificationEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SpecificationEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationEditPageEventsProcess

	/// <exclude/>
	public class SpecificationEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SpecificationEditPageSchemaUserControl
	{

		public SpecificationEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecificationEditPageEventsProcess";
			SchemaUId = new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5187431c-d1fc-4bb0-b8cf-e09d708bd321");
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

	#region Class: SpecificationEditPageEventsProcess

	/// <exclude/>
	public class SpecificationEditPageEventsProcess : SpecificationEditPageEventsProcess<Terrasoft.WebApp.SpecificationEditPageSchemaUserControl>
	{

		public SpecificationEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SpecificationEditPageSchemaUserControl

	/// <exclude/>
	public partial class SpecificationEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit TypeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("TypeEdit", true);
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
			var process = (SpecificationEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SpecificationEditPageEventsProcess(UserConnection);
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
			SchemaName = "SpecificationEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationEditPageEventsProcessSchema

	/// <exclude/>
	public class SpecificationEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public SpecificationEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SpecificationEditPageEventsProcessSchema(SpecificationEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SpecificationEditPageEventsProcess";
			UId = new Guid("417ab71a-202a-4147-a0e9-81937ef6a352");
			CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
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
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SpecificationEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("417ab71a-202a-4147-a0e9-81937ef6a352"));
		}

		#endregion

	}

	#endregion

}

