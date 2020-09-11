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
	using System.Linq;
	using System.Text;
	using System.Threading;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.Reports;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using TSConfiguration = Terrasoft.Configuration;
	using web = System.Web;
	using WebControls = Terrasoft.UI.WebControls.Controls;

	#region Class: MailServersGridPage_Base_TerrasoftSchema

	/// <exclude/>
	public class MailServersGridPage_Base_TerrasoftSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.MessagePanel _baseMessagePanel;
		public Terrasoft.UI.WebControls.Controls.MessagePanel BaseMessagePanel {
			get {
				return _baseMessagePanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer1;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return _spacer1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _closeButton;
		public Terrasoft.UI.WebControls.Controls.Button CloseButton {
			get {
				return _closeButton;
			}
		}

		#endregion

		#region Constructors: Public

		public MailServersGridPage_Base_TerrasoftSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public MailServersGridPage_Base_TerrasoftSchema(MailServersGridPage_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
			RealUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
			Name = "MailServersGridPage_Base_Terrasoft";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ValidationMessagePanel = "BaseMessagePanel";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMailServersGridPage_Base_TerrasoftEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateTreeGrid();
			UpdateShowChangelogMenuItem();
			UpdateCallMenuItem();
			UpdateSendTemplateEmailMenuItem();
			UpdateSendEmailMenuItem();
			UpdateButtonsControlLayout();
			UpdateContextHelpButton();
			UpdatePrintButton();
			UpdateActionButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateCopyButton();
			UpdateAddButton();
			Controls.AddAt(0, CreateBaseMessagePanel());
			TopLevelControl.MoveItem(1, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.MoveItem(4, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(5, ActionButton);
			ButtonsControlLayout.MoveItem(6, PrintButton);
			ButtonsControlLayout.MoveItem(7, ContextHelpButton);
			TopLevelControl.MoveItem(2, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			Controls.AddAt(3, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateSpacer1());
			ControlLayout1.InsertItem(1, CreateCloseButton());
			TopLevelControl.MoveItem(4, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateMailServersGridPage_Base_TerrasoftEventsProcessSchema() {
			var schema = new MailServersGridPage_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MessagePanel CreateBaseMessagePanel() {
			_baseMessagePanel = new Terrasoft.UI.WebControls.Controls.MessagePanel();
			_baseMessagePanel.UId = new Guid("148b4340-fc59-436b-881d-1145eaaff273");
			_baseMessagePanel.Name = "BaseMessagePanel";
			_baseMessagePanel.CreatedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
			_baseMessagePanel.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
			_baseMessagePanel.CreatedInPackageId = new Guid("0a5cc54a-531f-442f-b102-da02daef27de");
			_baseMessagePanel.Tag = "";
			_baseMessagePanel.ContentLeftOffset = System.Web.UI.WebControls.Unit.Pixel(0);
			_baseMessagePanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_baseMessagePanel.Edges = "0 0 1 0";
			return _baseMessagePanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer1() {
			_spacer1 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer1.UId = new Guid("20f62841-d94a-464d-9eb5-18cf42d2ad81");
			_spacer1.Name = "Spacer1";
			_spacer1.CreatedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
			_spacer1.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
			_spacer1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer1.Tag = "";
			_spacer1.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacer1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCloseButton() {
			_closeButton = new Terrasoft.UI.WebControls.Controls.Button();
			_closeButton.UId = new Guid("9bc59245-eb7c-4a2c-8008-c5e29bf77134");
			_closeButton.Name = "CloseButton";
			_closeButton.CreatedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
			_closeButton.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
			_closeButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_closeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_closeButton.Tag = "";
			_closeButton.Image = new ControlImage {};
			return _closeButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("4c1b84c5-dbe8-4190-9a66-04c242fe13f9");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
			_controlLayout1.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout1.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Footer;
			_controlLayout1.FitHeightByContent = true;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4");
			DataSource.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("92e11404-139a-4a59-88f6-28df26f6a10d");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("f0fec10e-c639-4ebb-b0d4-75ba7beb2b30");
			if (column != null) {
				column.UId = new Guid("56914695-7a58-4e12-adcd-1e7d0e51cd4a");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("446befeb-cdb5-4abe-9bca-46841970d412");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("7330a8a9-480c-46ef-af78-07b84a7bdcec");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("e40d09ba-8221-47e2-b072-3677de201703");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("407550ad-ffec-47b9-8cf9-a3ce72bb17db");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("be4a6212-190c-4430-8b31-6972ac32503f");
			if (column != null) {
				column.UId = new Guid("1ea7aa3a-af3f-4992-b4ba-87f0a8196bc9");
				column.Name = @"Address";
				column.CreatedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b9e6dfc3-cd79-4707-9f3d-9b6bedda3c5f");
			if (column != null) {
				column.UId = new Guid("d7fd1253-52a0-4a11-96e9-91749dce3064");
				column.Name = @"Port";
				column.CreatedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("773d7c26-389e-421c-a67e-9ca6a8b8a3e9");
			if (column != null) {
				column.UId = new Guid("2d3eb606-e8e7-4d8e-8270-ebf258d48950");
				column.Name = @"UseSSL";
				column.CreatedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("411aaeae-43da-4e1c-8b1c-1655c25aac96");
			if (column != null) {
				column.UId = new Guid("9ecb4bcb-4c5f-4219-ae4e-5a86c2a61399");
				column.Name = @"AllowEmailSending";
				column.CreatedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("6094ebec-dee7-492e-8977-4e2748a9b4bb");
			if (column != null) {
				column.UId = new Guid("9f24ecc7-7b7c-4878-b993-148204b5f610");
				column.Name = @"SMTPServerTimeout";
				column.CreatedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("394009b0-7664-46b4-b052-5754522f03c3");
			if (column != null) {
				column.UId = new Guid("a077567c-bce6-4973-b76a-994abd30519f");
				column.Name = @"SMTPServerAddress";
				column.CreatedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("33affd30-ab8b-4975-8917-9baa63d2d025");
			if (column != null) {
				column.UId = new Guid("38c6fcd4-713a-4dce-8f0d-494df3a7ec7f");
				column.Name = @"UseSSLforSending";
				column.CreatedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c6d3e3b2-5552-4b06-9d5c-fe34b58ae7aa");
			if (column != null) {
				column.UId = new Guid("1940c914-94c6-4d26-8ccc-b2cafb5c09c5");
				column.Name = @"SMTPPort";
				column.CreatedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9a6b34c9-96b3-45f5-b005-dfcd12e79d6d");
			if (column != null) {
				column.UId = new Guid("499f6e55-a066-4240-8df7-2e98a0725fc9");
				column.Name = @"EmailProtocol";
				column.CreatedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("89e2b329-bf63-4d5c-a079-6cf6c5fa9430");
			if (column != null) {
				column.UId = new Guid("7a7233a0-b0ac-4785-851e-5e3766879023");
				column.Name = @"AllowEmailDownloading";
				column.CreatedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("411aaeae-43da-4e1c-8b1c-1655c25aac96");
			if (column != null) {
				column.UId = new Guid("9a16a7b3-0924-4825-8277-e5483fd01754");
				column.Name = @"AllowEmailSending";
				column.CreatedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.ModifiedInSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new MailServersGridPage_Base_TerrasoftSchemaUserControl();
		}

		public override object Clone() {
			return new MailServersGridPage_Base_TerrasoftSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new MailServersGridPage_Base_TerrasoftEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: MailServersGridPage_Base_TerrasoftEventsProcess

	/// <exclude/>
	public class MailServersGridPage_Base_TerrasoftEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.MailServersGridPage_Base_TerrasoftSchemaUserControl
	{

		public MailServersGridPage_Base_TerrasoftEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MailServersGridPage_Base_TerrasoftEventsProcess";
			SchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
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

		private Guid _editPageUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
		public override Guid EditPageUId {
			get {
				return _editPageUId;
			}
			set {
				_editPageUId = value;
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
					SchemaElementUId = new Guid("9712b418-61ee-4fc6-a68d-72f4a530763c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _closeButtonClickStartMessage;
		public ProcessFlowElement CloseButtonClickStartMessage {
			get {
				return _closeButtonClickStartMessage ?? (_closeButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CloseButtonClickStartMessage",
					SchemaElementUId = new Guid("d0607e9b-faa2-4993-b58c-aa4d85293e04"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("0fca782b-26d3-4f08-b573-2fcb0b6790be"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessFlowElement _mailServersGridPagePageLoadCompleteEventSubProcess;
		public ProcessFlowElement MailServersGridPagePageLoadCompleteEventSubProcess {
			get {
				return _mailServersGridPagePageLoadCompleteEventSubProcess ?? (_mailServersGridPagePageLoadCompleteEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "MailServersGridPagePageLoadCompleteEventSubProcess",
					SchemaElementUId = new Guid("6ce840dd-6d49-47f0-a8d3-91a9eaf838d6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _mailServersGridPagePageLoadCompleteStartMessage;
		public ProcessFlowElement MailServersGridPagePageLoadCompleteStartMessage {
			get {
				return _mailServersGridPagePageLoadCompleteStartMessage ?? (_mailServersGridPagePageLoadCompleteStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MailServersGridPagePageLoadCompleteStartMessage",
					SchemaElementUId = new Guid("d9d5ccec-0d63-4eeb-b7ce-bba755445c88"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _mailServersGridPagePageLoadCompleteScriptTask;
		public ProcessScriptTask MailServersGridPagePageLoadCompleteScriptTask {
			get {
				return _mailServersGridPagePageLoadCompleteScriptTask ?? (_mailServersGridPagePageLoadCompleteScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "MailServersGridPagePageLoadCompleteScriptTask",
					SchemaElementUId = new Guid("f9dd8499-f488-4207-9f22-38986410fb67"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = MailServersGridPagePageLoadCompleteScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _mailServersGridPagePageLoadCompleteIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent MailServersGridPagePageLoadCompleteIntermediateThrowMessageEvent {
			get {
				return _mailServersGridPagePageLoadCompleteIntermediateThrowMessageEvent ?? (_mailServersGridPagePageLoadCompleteIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "MailServersGridPagePageLoadCompleteIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("17072123-0844-4a11-8bbb-66b3478179cf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private LocalizableString _pageCaption;
		public LocalizableString PageCaption {
			get {
				return _pageCaption ?? (_pageCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.PageCaption.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[CloseButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CloseButtonClickStartMessage };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[MailServersGridPagePageLoadCompleteEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { MailServersGridPagePageLoadCompleteEventSubProcess };
			FlowElements[MailServersGridPagePageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { MailServersGridPagePageLoadCompleteStartMessage };
			FlowElements[MailServersGridPagePageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { MailServersGridPagePageLoadCompleteScriptTask };
			FlowElements[MailServersGridPagePageLoadCompleteIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { MailServersGridPagePageLoadCompleteIntermediateThrowMessageEvent };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "CloseButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
					case "MailServersGridPagePageLoadCompleteEventSubProcess":
						break;
					case "MailServersGridPagePageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("MailServersGridPagePageLoadCompleteScriptTask");
						break;
					case "MailServersGridPagePageLoadCompleteScriptTask":
						e.Context.QueueTasks.Enqueue("MailServersGridPagePageLoadCompleteIntermediateThrowMessageEvent");
						break;
					case "MailServersGridPagePageLoadCompleteIntermediateThrowMessageEvent":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("CloseButtonClickStartMessage");
			ActivatedEventElements.Add("MailServersGridPagePageLoadCompleteStartMessage");
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
				case "CloseButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CloseButtonClickStartMessage";
					result = CloseButtonClickStartMessage.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "MailServersGridPagePageLoadCompleteEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "MailServersGridPagePageLoadCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailServersGridPagePageLoadCompleteStartMessage";
					result = MailServersGridPagePageLoadCompleteStartMessage.Execute(context);
					break;
				case "MailServersGridPagePageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailServersGridPagePageLoadCompleteScriptTask";
					result = MailServersGridPagePageLoadCompleteScriptTask.Execute(context, MailServersGridPagePageLoadCompleteScriptTaskExecute);
					break;
				case "MailServersGridPagePageLoadCompleteIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = MailServersGridPagePageLoadCompleteIntermediateThrowMessageEvent.Execute(context);
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

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			((Terrasoft.UI.WebControls.Page)Page.AspPage).Close();
			return true;
		}

		public virtual bool MailServersGridPagePageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageMailServers");
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = PageCaption;
			Page.DataSource.LoadRows();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "CloseButtonClick":
							if (ActivatedEventElements.Contains("CloseButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("CloseButtonClickStartMessage");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("MailServersGridPagePageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("MailServersGridPagePageLoadCompleteStartMessage");
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

	#region Class: MailServersGridPage_Base_TerrasoftEventsProcess

	/// <exclude/>
	public class MailServersGridPage_Base_TerrasoftEventsProcess : MailServersGridPage_Base_TerrasoftEventsProcess<Terrasoft.WebApp.MailServersGridPage_Base_TerrasoftSchemaUserControl>
	{

		public MailServersGridPage_Base_TerrasoftEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MailServersGridPage_Base_TerrasoftSchemaUserControl

	/// <exclude/>
	public partial class MailServersGridPage_Base_TerrasoftSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.MessagePanel BaseMessagePanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.MessagePanel)PageContainer.FindPageControl("BaseMessagePanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button CloseButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("CloseButton", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			CloseButton.AjaxEvents.Click.Event += CloseButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			CloseButton.AjaxEvents.Click.Event -= CloseButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (MailServersGridPage_Base_TerrasoftEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new MailServersGridPage_Base_TerrasoftEventsProcess(UserConnection);
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

		public virtual void CloseButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("CloseButtonClick");
		}

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
			SchemaName = "MailServersGridPage_Base_Terrasoft";
		}

		#endregion

	}

	#endregion

	#region Class: MailServersGridPage_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class MailServersGridPage_Base_TerrasoftEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public MailServersGridPage_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MailServersGridPage_Base_TerrasoftEventsProcessSchema(MailServersGridPage_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "MailServersGridPage_Base_TerrasoftEventsProcess";
			UId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override ProcessSchemaParameter CreateEditPageUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a676227c-1197-410d-9d09-3e896ddf170d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EditPageUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"727ec41d-9d34-4095-b1c1-d811ddcf18f3",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaMailServersGridPageLaneSet = CreateMailServersGridPageLaneSetLaneSet();
			LaneSets.Add(schemaMailServersGridPageLaneSet);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaMailServersGridPageLaneSet.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess mailserversgridpagepageloadcompleteeventsubprocess = CreateMailServersGridPagePageLoadCompleteEventSubProcessEventSubProcess();
			FlowElements.Add(mailserversgridpagepageloadcompleteeventsubprocess);
			ProcessSchemaStartMessageEvent closebuttonclickstartmessage = CreateCloseButtonClickStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(closebuttonclickstartmessage);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			ProcessSchemaStartMessageEvent mailserversgridpagepageloadcompletestartmessage = CreateMailServersGridPagePageLoadCompleteStartMessageStartMessageEvent();
			mailserversgridpagepageloadcompleteeventsubprocess.FlowElements.Add(mailserversgridpagepageloadcompletestartmessage);
			ProcessSchemaScriptTask mailserversgridpagepageloadcompletescripttask = CreateMailServersGridPagePageLoadCompleteScriptTaskScriptTask();
			mailserversgridpagepageloadcompleteeventsubprocess.FlowElements.Add(mailserversgridpagepageloadcompletescripttask);
			ProcessSchemaIntermediateThrowMessageEvent mailserversgridpagepageloadcompleteintermediatethrowmessageevent = CreateMailServersGridPagePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			mailserversgridpagepageloadcompleteeventsubprocess.FlowElements.Add(mailserversgridpagepageloadcompleteintermediatethrowmessageevent);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreatePageCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreatePageCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("51ea7448-e002-4fec-a679-8d4f4f8612f2"),
				Name = "PageCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				ModifiedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("77f16954-fec7-4f51-9729-46b9478d4bd8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				CurveCenterPosition = new Point(160, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d9d5ccec-0d63-4eeb-b7ce-bba755445c88"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f9dd8499-f488-4207-9f22-38986410fb67"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("693bacfa-e04d-4164-a607-3b1498880cf0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				CurveCenterPosition = new Point(266, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f9dd8499-f488-4207-9f22-38986410fb67"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("17072123-0844-4a11-8bbb-66b3478179cf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("b9fe2ae7-6710-49bf-8c62-8affe22449d1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d0607e9b-faa2-4993-b58c-aa4d85293e04"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0fca782b-26d3-4f08-b573-2fcb0b6790be"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateMailServersGridPageLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaMailServersGridPageLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("580080a8-9356-45ad-9b0b-86175c314f8c"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				Name = @"MailServersGridPageLaneSet",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(897, 159),
				UseBackgroundMode = false
			};
			return schemaMailServersGridPageLaneSet;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("3ab419cf-08d5-4de1-a02d-44c24d5385a7"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("580080a8-9356-45ad-9b0b-86175c314f8c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(868, 159),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9712b418-61ee-4fc6-a68d-72f4a530763c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ab419cf-08d5-4de1-a02d-44c24d5385a7"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				Name = @"EventSubProcess1",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(241, 140),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCloseButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d0607e9b-faa2-4993-b58c-aa4d85293e04"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9712b418-61ee-4fc6-a68d-72f4a530763c"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CloseButtonClick",
				ModifiedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				Name = @"CloseButtonClickStartMessage",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0fca782b-26d3-4f08-b573-2fcb0b6790be"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9712b418-61ee-4fc6-a68d-72f4a530763c"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				Name = @"ScriptTask1",
				Position = new Point(127, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,208,8,73,45,42,74,44,206,79,43,209,11,245,212,11,79,77,114,206,207,43,41,202,207,41,214,11,72,76,79,213,4,17,122,142,197,5,96,142,158,115,78,126,113,170,134,166,53,47,87,81,106,73,105,81,158,66,73,81,105,170,53,0,157,57,6,49,68,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateMailServersGridPagePageLoadCompleteEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaMailServersGridPagePageLoadCompleteEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6ce840dd-6d49-47f0-a8d3-91a9eaf838d6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ab419cf-08d5-4de1-a02d-44c24d5385a7"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				Name = @"MailServersGridPagePageLoadCompleteEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 171),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(280, 167),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaMailServersGridPagePageLoadCompleteEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMailServersGridPagePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d9d5ccec-0d63-4eeb-b7ce-bba755445c88"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6ce840dd-6d49-47f0-a8d3-91a9eaf838d6"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				Name = @"MailServersGridPagePageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateMailServersGridPagePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f9dd8499-f488-4207-9f22-38986410fb67"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6ce840dd-6d49-47f0-a8d3-91a9eaf838d6"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				Name = @"MailServersGridPagePageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(105, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,45,141,205,10,194,48,16,132,239,130,239,16,122,106,47,251,2,197,131,166,61,8,22,197,90,60,175,113,173,193,178,41,155,196,159,183,55,17,79,195,124,12,223,12,158,68,59,102,50,193,58,134,102,211,147,137,98,195,167,229,209,50,129,190,147,121,104,228,246,157,120,160,253,76,130,121,89,22,9,118,200,56,82,135,118,234,73,158,36,190,168,234,229,162,60,36,8,107,63,231,84,232,213,137,68,208,187,91,128,97,11,103,186,164,191,32,110,242,144,7,21,104,156,179,81,173,84,238,255,150,60,63,77,131,1,123,23,197,16,236,28,94,143,238,229,203,124,34,20,162,176,10,18,169,254,2,252,251,62,243,196,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateMailServersGridPagePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("17072123-0844-4a11-8bbb-66b3478179cf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6ce840dd-6d49-47f0-a8d3-91a9eaf838d6"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				Name = @"MailServersGridPagePageLoadCompleteIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(211, 65),
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
				UId = new Guid("9d7efbbf-8549-484c-9592-82bf90843f5d"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("95c66740-e509-4ca4-b1ef-c7a6bb406ec0"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7c7fbab2-546c-4dd3-ba02-c8f1ddbc356d"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5869487f-ebcd-414c-9fb2-40b8f070b351"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41c60d94-6edf-44e4-9edb-0e16c226d725"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("92dceabc-4c2b-49a1-baa4-e5bdfa59f339"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa8aa1ac-15e9-42cc-9636-16aa514d5797"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10a2ccab-756c-4712-b1b8-f4ebab9f54a0"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f5452a8-39be-4d73-aff7-044da2a7684d"),
				Name = "System.Threading",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0655a6cd-c0cc-42ef-b029-8e7b7f8cbd5b"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MailServersGridPage_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"));
		}

		#endregion

	}

	#endregion

}

