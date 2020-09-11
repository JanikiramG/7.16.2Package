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

	#region Class: CountryEditPageSchema

	/// <exclude/>
	public class CountryEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.MemoEdit _billingInfoEdit;
		public Terrasoft.UI.WebControls.Controls.MemoEdit BillingInfoEdit {
			get {
				return _billingInfoEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public CountryEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public CountryEditPageSchema(CountryEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("0e4608c0-3dea-4297-a69a-e4f38b82734d");
			NameEdit.ModifiedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("6b98f9e9-f28b-4c18-bf29-8394bc1f71a9");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
			RealUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
			Name = "CountryEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 400;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCountryEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(1, CreateBillingInfoEdit());
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

		protected virtual EmbeddedProcessSchema CreateCountryEditPageEventsProcessSchema() {
			var schema = new CountryEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MemoEdit CreateBillingInfoEdit() {
			_billingInfoEdit = new Terrasoft.UI.WebControls.Controls.MemoEdit();
			_billingInfoEdit.UId = new Guid("b6b394f8-5558-4000-9b13-0cce938eab5c");
			_billingInfoEdit.Name = "BillingInfoEdit";
			_billingInfoEdit.CreatedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
			_billingInfoEdit.ModifiedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
			_billingInfoEdit.CreatedInPackageId = Guid.Empty;
			_billingInfoEdit.Tag = "";
			_billingInfoEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_billingInfoEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_billingInfoEdit.DataSource = "DataSource";
			_billingInfoEdit.ColumnUId = new Guid("c1f141e2-b2db-4fe2-83da-fde6da0958bc");
			return _billingInfoEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("09fce1f8-515c-4296-95cd-8cd93f79a6cf");
			DataSource.ModifiedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("14793d4a-1af2-4af6-8631-ab75f62af544");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
				column.ModifiedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("fd9674f0-bcbe-4085-9e5a-b6389c199af3");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
				column.ModifiedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("7cbad4d3-2a6a-4bb6-b9fc-a49cc338a92a");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
				column.ModifiedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("c5bd30c4-691e-405e-913c-dd7959fc2d95");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
				column.ModifiedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("8701b324-054f-43d9-8414-c954d4aee5af");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
				column.ModifiedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("0e4608c0-3dea-4297-a69a-e4f38b82734d");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
				column.ModifiedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("6b98f9e9-f28b-4c18-bf29-8394bc1f71a9");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
				column.ModifiedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("7a8944fa-b3f0-46dc-8f51-f6b0706106f8");
			if (column != null) {
				column.UId = new Guid("52a7cba2-5e63-4e11-8f31-35b3d8a6ea2c");
				column.Name = @"Image";
				column.CreatedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
				column.ModifiedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("6c43eac6-1530-4d3a-8839-89cb19d5484a");
			if (column != null) {
				column.UId = new Guid("c1f141e2-b2db-4fe2-83da-fde6da0958bc");
				column.Name = @"BillingInfo";
				column.CreatedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
				column.ModifiedInSchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
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
			return new CountryEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new CountryEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CountryEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: CountryEditPageEventsProcess

	/// <exclude/>
	public class CountryEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.CountryEditPageSchemaUserControl
	{

		public CountryEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CountryEditPageEventsProcess";
			SchemaUId = new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1b6b067f-cef4-40c4-87d9-154871bcc405");
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

	#region Class: CountryEditPageEventsProcess

	/// <exclude/>
	public class CountryEditPageEventsProcess : CountryEditPageEventsProcess<Terrasoft.WebApp.CountryEditPageSchemaUserControl>
	{

		public CountryEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CountryEditPageSchemaUserControl

	/// <exclude/>
	public partial class CountryEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.MemoEdit BillingInfoEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.MemoEdit)PageContainer.FindPageControl("BillingInfoEdit", true);
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
			var process = (CountryEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new CountryEditPageEventsProcess(UserConnection);
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
			SchemaName = "CountryEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: CountryEditPageEventsProcessSchema

	/// <exclude/>
	public class CountryEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public CountryEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CountryEditPageEventsProcessSchema(CountryEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CountryEditPageEventsProcess";
			UId = new Guid("5e3863f9-b9dc-4fc5-af3c-9a1b9af8f551");
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
			return new CountryEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5e3863f9-b9dc-4fc5-af3c-9a1b9af8f551"));
		}

		#endregion

	}

	#endregion

}

