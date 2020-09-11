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

	#region Class: LoginPageCommunicationEditPageSchema

	/// <exclude/>
	public class LoginPageCommunicationEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TextEdit _phoneEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit PhoneEdit {
			get {
				return _phoneEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public LoginPageCommunicationEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public LoginPageCommunicationEditPageSchema(LoginPageCommunicationEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ModifiedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
			RealUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
			Name = "LoginPageCommunicationEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d");
			Maximized = true;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLoginPageCommunicationEditPageEventsProcessSchema();
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
			UpdateNameEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, NameEdit);
			MainControlLayout.InsertItem(1, CreatePhoneEdit());
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

		protected virtual EmbeddedProcessSchema CreateLoginPageCommunicationEditPageEventsProcessSchema() {
			var schema = new LoginPageCommunicationEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreatePhoneEdit() {
			_phoneEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_phoneEdit.UId = new Guid("a056174d-a563-4467-afb6-bc9f36601fda");
			_phoneEdit.Name = "PhoneEdit";
			_phoneEdit.CreatedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
			_phoneEdit.ModifiedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
			_phoneEdit.CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d");
			_phoneEdit.Tag = "";
			_phoneEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_phoneEdit.Image = new ControlImage {};
			_phoneEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_phoneEdit.DataSource = "DataSource";
			_phoneEdit.ColumnUId = new Guid("2ac7aa2d-ee1c-4a7f-a886-c3e722b263b4");
			return _phoneEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("7af64378-e2d0-4549-929a-92545d835dda");
			DataSource.ModifiedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("751a0779-354e-4163-998a-61f72aa0877a");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
				column.ModifiedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("020fa9c3-d45a-4e7b-b37e-d2964a92a9d2");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
				column.ModifiedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("5d9034b2-0dc6-4a49-b9e8-3dd915532ed3");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
				column.ModifiedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("c665d395-6659-4073-89b5-e7f1c76c5c1a");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
				column.ModifiedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("b4d7e140-9f55-4665-bd77-c76ae61ca03a");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
				column.ModifiedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("77eb8540-d817-4552-90e8-b05e629e5d78");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
				column.ModifiedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("a8d288b5-4aeb-47ce-ad78-c00b03318bbf");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
				column.ModifiedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("f990b36e-6e9e-448d-a532-073f71a34827");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
				column.ModifiedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("70e277a1-3dd5-46d0-8333-5584aea82c54");
			if (column != null) {
				column.UId = new Guid("2ac7aa2d-ee1c-4a7f-a886-c3e722b263b4");
				column.Name = @"Phone";
				column.CreatedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
				column.ModifiedInSchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
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
			return new LoginPageCommunicationEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new LoginPageCommunicationEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new LoginPageCommunicationEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: LoginPageCommunicationEditPageEventsProcess

	/// <exclude/>
	public class LoginPageCommunicationEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.LoginPageCommunicationEditPageSchemaUserControl
	{

		public LoginPageCommunicationEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LoginPageCommunicationEditPageEventsProcess";
			SchemaUId = new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("951009a4-0a3b-4c1e-81b8-9dbc9064f54b");
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

	#region Class: LoginPageCommunicationEditPageEventsProcess

	/// <exclude/>
	public class LoginPageCommunicationEditPageEventsProcess : LoginPageCommunicationEditPageEventsProcess<Terrasoft.WebApp.LoginPageCommunicationEditPageSchemaUserControl>
	{

		public LoginPageCommunicationEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LoginPageCommunicationEditPageSchemaUserControl

	/// <exclude/>
	public partial class LoginPageCommunicationEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TextEdit PhoneEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("PhoneEdit", true);
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
			var process = (LoginPageCommunicationEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new LoginPageCommunicationEditPageEventsProcess(UserConnection);
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
			SchemaName = "LoginPageCommunicationEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: LoginPageCommunicationEditPageEventsProcessSchema

	/// <exclude/>
	public class LoginPageCommunicationEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public LoginPageCommunicationEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LoginPageCommunicationEditPageEventsProcessSchema(LoginPageCommunicationEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LoginPageCommunicationEditPageEventsProcess";
			UId = new Guid("b172c9d4-dcee-4465-9074-bfc492133bda");
			CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d");
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
				CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LoginPageCommunicationEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b172c9d4-dcee-4465-9074-bfc492133bda"));
		}

		#endregion

	}

	#endregion

}

