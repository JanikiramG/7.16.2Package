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

	#region Class: CashflowCategoryEditPageSchema

	/// <exclude/>
	public class CashflowCategoryEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _cashflowTypeEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit CashflowTypeEdit {
			get {
				return _cashflowTypeEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public CashflowCategoryEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public CashflowCategoryEditPageSchema(CashflowCategoryEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("fc25a162-eb0d-496b-bca1-aee051872537");
			NameEdit.ModifiedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("9d5beb71-fcf9-4136-b075-3f4aa353fe41");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
			RealUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
			Name = "CashflowCategoryEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCashflowCategoryEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(1, CreateCashflowTypeEdit());
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

		protected virtual EmbeddedProcessSchema CreateCashflowCategoryEditPageEventsProcessSchema() {
			var schema = new CashflowCategoryEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateCashflowTypeEdit() {
			_cashflowTypeEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_cashflowTypeEdit.UId = new Guid("6d857532-b600-4b74-b141-85b7f22abf9b");
			_cashflowTypeEdit.Name = "CashflowTypeEdit";
			_cashflowTypeEdit.CreatedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
			_cashflowTypeEdit.ModifiedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
			_cashflowTypeEdit.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			_cashflowTypeEdit.Tag = "";
			_cashflowTypeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_cashflowTypeEdit.Image = new ControlImage {};
			_cashflowTypeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_cashflowTypeEdit.DataSource = "DataSource";
			_cashflowTypeEdit.ColumnUId = new Guid("3742030d-d543-4972-b95c-e7aba2d608ed");
			return _cashflowTypeEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("31bad651-347e-4d44-90c6-70b79b83dbac");
			DataSource.ModifiedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("ab72896d-afd9-45ef-be59-18c0eb03557f");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
				column.ModifiedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("0d4363d2-dd81-4cb7-87b1-0a5b4fc79ab7");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
				column.ModifiedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("feb17e02-fb09-458a-8cc9-fc21bbd31860");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
				column.ModifiedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("22e8f559-3faf-43b6-80b6-c6ceeafa7466");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
				column.ModifiedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("18c2918d-5e25-4ad1-8b41-488fa3d91948");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
				column.ModifiedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("fc25a162-eb0d-496b-bca1-aee051872537");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
				column.ModifiedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("9d5beb71-fcf9-4136-b075-3f4aa353fe41");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
				column.ModifiedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("463c7b5d-520c-49ba-a709-357b660abfdf");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
				column.ModifiedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c62a12cb-b285-45a3-9811-7f0a05477232");
			if (column != null) {
				column.UId = new Guid("3742030d-d543-4972-b95c-e7aba2d608ed");
				column.Name = @"CashflowType";
				column.CreatedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
				column.ModifiedInSchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
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
			return new CashflowCategoryEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new CashflowCategoryEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CashflowCategoryEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: CashflowCategoryEditPageEventsProcess

	/// <exclude/>
	public class CashflowCategoryEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.CashflowCategoryEditPageSchemaUserControl
	{

		public CashflowCategoryEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CashflowCategoryEditPageEventsProcess";
			SchemaUId = new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f0ca686c-ecda-41da-8e68-8d01017945dc");
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

	#region Class: CashflowCategoryEditPageEventsProcess

	/// <exclude/>
	public class CashflowCategoryEditPageEventsProcess : CashflowCategoryEditPageEventsProcess<Terrasoft.WebApp.CashflowCategoryEditPageSchemaUserControl>
	{

		public CashflowCategoryEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CashflowCategoryEditPageSchemaUserControl

	/// <exclude/>
	public partial class CashflowCategoryEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit CashflowTypeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("CashflowTypeEdit", true);
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
			var process = (CashflowCategoryEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new CashflowCategoryEditPageEventsProcess(UserConnection);
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
			SchemaName = "CashflowCategoryEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: CashflowCategoryEditPageEventsProcessSchema

	/// <exclude/>
	public class CashflowCategoryEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public CashflowCategoryEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CashflowCategoryEditPageEventsProcessSchema(CashflowCategoryEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CashflowCategoryEditPageEventsProcess";
			UId = new Guid("ede2cc9a-c8c7-4a45-b0b5-d5b2ae57a769");
			CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
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
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CashflowCategoryEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ede2cc9a-c8c7-4a45-b0b5-d5b2ae57a769"));
		}

		#endregion

	}

	#endregion

}

