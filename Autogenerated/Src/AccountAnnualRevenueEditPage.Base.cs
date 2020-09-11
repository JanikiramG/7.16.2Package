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

	#region Class: AccountAnnualRevenueEditPageSchema

	/// <exclude/>
	public class AccountAnnualRevenueEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _fromBaseCurrencyEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit FromBaseCurrencyEdit {
			get {
				return _fromBaseCurrencyEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _toBaseCurrencyEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit ToBaseCurrencyEdit {
			get {
				return _toBaseCurrencyEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public AccountAnnualRevenueEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AccountAnnualRevenueEditPageSchema(AccountAnnualRevenueEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("a492f001-5bd5-4461-ae6c-407bc996d375");
			NameEdit.ModifiedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("620e62c3-b1e9-4984-84bb-23d36b738671");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
			RealUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
			Name = "AccountAnnualRevenueEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAccountAnnualRevenueEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(1, CreateFromBaseCurrencyEdit());
			MainControlLayout.InsertItem(2, CreateToBaseCurrencyEdit());
			MainControlLayout.MoveItem(3, DescriptionEdit);
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

		protected virtual EmbeddedProcessSchema CreateAccountAnnualRevenueEditPageEventsProcessSchema() {
			var schema = new AccountAnnualRevenueEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreateFromBaseCurrencyEdit() {
			_fromBaseCurrencyEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_fromBaseCurrencyEdit.UId = new Guid("c68a5a59-78f1-4868-95b2-ca82d1b0ab9f");
			_fromBaseCurrencyEdit.Name = "FromBaseCurrencyEdit";
			_fromBaseCurrencyEdit.CreatedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
			_fromBaseCurrencyEdit.ModifiedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
			_fromBaseCurrencyEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_fromBaseCurrencyEdit.Tag = "";
			_fromBaseCurrencyEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_fromBaseCurrencyEdit.Image = new ControlImage {};
			_fromBaseCurrencyEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_fromBaseCurrencyEdit.DataSource = "DataSource";
			_fromBaseCurrencyEdit.ColumnUId = new Guid("0965314d-414d-4a63-bda9-f3238a216f2f");
			return _fromBaseCurrencyEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreateToBaseCurrencyEdit() {
			_toBaseCurrencyEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_toBaseCurrencyEdit.UId = new Guid("87eef9fa-4fa9-460c-b3cf-ccbd844e6aba");
			_toBaseCurrencyEdit.Name = "ToBaseCurrencyEdit";
			_toBaseCurrencyEdit.CreatedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
			_toBaseCurrencyEdit.ModifiedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
			_toBaseCurrencyEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_toBaseCurrencyEdit.Tag = "";
			_toBaseCurrencyEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_toBaseCurrencyEdit.Image = new ControlImage {};
			_toBaseCurrencyEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_toBaseCurrencyEdit.DataSource = "DataSource";
			_toBaseCurrencyEdit.ColumnUId = new Guid("6c7aaa54-c9f1-4f18-aaef-7e66181cb792");
			return _toBaseCurrencyEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("24d201f8-5f03-47f3-9e7b-1c967c11d7b9");
			DataSource.ModifiedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("4cdc76a3-0789-475d-8e6b-e58e5b5b86e7");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
				column.ModifiedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("a492f001-5bd5-4461-ae6c-407bc996d375");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
				column.ModifiedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("634519c9-df15-4ad9-a325-7096220ea682");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
				column.ModifiedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("6dadb54b-f066-446d-a53d-2a6f2576149f");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
				column.ModifiedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("a310bf40-548c-4255-9cf3-0732fa8ba1a2");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
				column.ModifiedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("f19522f4-0a03-4b1c-b103-f886813707ce");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
				column.ModifiedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("620e62c3-b1e9-4984-84bb-23d36b738671");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
				column.ModifiedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("633ed4cd-fe02-423a-a4d4-062cae2a2ec4");
			if (column != null) {
				column.UId = new Guid("0965314d-414d-4a63-bda9-f3238a216f2f");
				column.Name = @"FromBaseCurrency";
				column.CreatedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
				column.ModifiedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("94a2ebc5-c110-4929-94b4-baaafee43d7d");
			if (column != null) {
				column.UId = new Guid("6c7aaa54-c9f1-4f18-aaef-7e66181cb792");
				column.Name = @"ToBaseCurrency";
				column.CreatedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
				column.ModifiedInSchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
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
			return new AccountAnnualRevenueEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new AccountAnnualRevenueEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AccountAnnualRevenueEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AccountAnnualRevenueEditPageEventsProcess

	/// <exclude/>
	public class AccountAnnualRevenueEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AccountAnnualRevenueEditPageSchemaUserControl
	{

		public AccountAnnualRevenueEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountAnnualRevenueEditPageEventsProcess";
			SchemaUId = new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("101bf50f-02b6-42f3-abf5-b3547a8e99d3");
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

	#region Class: AccountAnnualRevenueEditPageEventsProcess

	/// <exclude/>
	public class AccountAnnualRevenueEditPageEventsProcess : AccountAnnualRevenueEditPageEventsProcess<Terrasoft.WebApp.AccountAnnualRevenueEditPageSchemaUserControl>
	{

		public AccountAnnualRevenueEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountAnnualRevenueEditPageSchemaUserControl

	/// <exclude/>
	public partial class AccountAnnualRevenueEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.IntegerEdit FromBaseCurrencyEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("FromBaseCurrencyEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.IntegerEdit ToBaseCurrencyEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("ToBaseCurrencyEdit", true);
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
			var process = (AccountAnnualRevenueEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AccountAnnualRevenueEditPageEventsProcess(UserConnection);
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
			SchemaName = "AccountAnnualRevenueEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: AccountAnnualRevenueEditPageEventsProcessSchema

	/// <exclude/>
	public class AccountAnnualRevenueEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public AccountAnnualRevenueEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AccountAnnualRevenueEditPageEventsProcessSchema(AccountAnnualRevenueEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AccountAnnualRevenueEditPageEventsProcess";
			UId = new Guid("840cdc27-4abc-4ad1-83d0-2b16793a0d01");
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
			return new AccountAnnualRevenueEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("840cdc27-4abc-4ad1-83d0-2b16793a0d01"));
		}

		#endregion

	}

	#endregion

}

