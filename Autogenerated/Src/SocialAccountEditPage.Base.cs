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
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Social;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.Web.Common;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: SocialAccountEditPageSchema

	/// <exclude/>
	public class SocialAccountEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _nameEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return _nameEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _userEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit UserEdit {
			get {
				return _userEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return _controlLayout2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _typeEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit TypeEdit {
			get {
				return _typeEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _loginEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit LoginEdit {
			get {
				return _loginEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _publicCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox PublicCheckBox {
			get {
				return _publicCheckBox;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout3;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return _controlLayout3;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MemoEdit _memoEdit1;
		public Terrasoft.UI.WebControls.Controls.MemoEdit MemoEdit1 {
			get {
				return _memoEdit1;
			}
		}

		#endregion

		#region Constructors: Public

		public SocialAccountEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SocialAccountEditPageSchema(SocialAccountEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
			RealUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
			Name = "SocialAccountEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 350;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSocialAccountEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(0, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateNameEdit());
			ControlLayout1.InsertItem(1, CreateUserEdit());
			ControlLayout1.InsertItem(2, CreateControlLayout2());
			ControlLayout2.InsertItem(0, CreateTypeEdit());
			ControlLayout2.InsertItem(1, CreateLoginEdit());
			ControlLayout2.InsertItem(2, CreatePublicCheckBox());
			ControlLayout1.InsertItem(3, CreateControlLayout3());
			ControlLayout3.InsertItem(0, CreateMemoEdit1());
			MainControlLayout.MoveItem(1, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateSocialAccountEditPageEventsProcessSchema() {
			var schema = new SocialAccountEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateNameEdit() {
			_nameEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_nameEdit.UId = new Guid("8117c0d5-7da7-4dda-847a-f35ec1fc7cfa");
			_nameEdit.Name = "NameEdit";
			_nameEdit.CreatedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
			_nameEdit.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
			_nameEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_nameEdit.Tag = "";
			_nameEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_nameEdit.Image = new ControlImage {};
			_nameEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_nameEdit.DataSource = "DataSource";
			_nameEdit.ColumnUId = new Guid("395f6d6d-9b74-425c-8455-fad7bf33edbd");
			return _nameEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateUserEdit() {
			_userEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_userEdit.UId = new Guid("011477e8-f041-495e-ac7e-28ab497d85e6");
			_userEdit.Name = "UserEdit";
			_userEdit.CreatedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
			_userEdit.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
			_userEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_userEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_userEdit.AjaxEvents.Change.ShowLoadMask = true;
			_userEdit.Tag = "";
			_userEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_userEdit.Image = new ControlImage {};
			_userEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_userEdit.DataSource = "DataSource";
			_userEdit.ColumnUId = new Guid("a8fbf2d2-d569-4edb-aa05-a1495337297e");
			return _userEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateTypeEdit() {
			_typeEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_typeEdit.UId = new Guid("be4baa78-2dc2-415d-a44d-0d7509e23b18");
			_typeEdit.Name = "TypeEdit";
			_typeEdit.CreatedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
			_typeEdit.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
			_typeEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_typeEdit.Tag = "";
			_typeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_typeEdit.Image = new ControlImage {};
			_typeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(60);
			_typeEdit.DataSource = "DataSource";
			_typeEdit.ColumnUId = new Guid("be5c09d4-8c51-442d-a568-45f3add6643c");
			return _typeEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateLoginEdit() {
			_loginEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_loginEdit.UId = new Guid("945e9b6d-fd66-4837-ae96-40e17cb4847d");
			_loginEdit.Name = "LoginEdit";
			_loginEdit.CreatedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
			_loginEdit.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
			_loginEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_loginEdit.Tag = "";
			_loginEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_loginEdit.Image = new ControlImage {};
			_loginEdit.Width = System.Web.UI.WebControls.Unit.Percentage(50);
			_loginEdit.DataSource = "DataSource";
			_loginEdit.ColumnUId = new Guid("46999b36-4597-4201-a7db-7880f3fb6f54");
			return _loginEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreatePublicCheckBox() {
			_publicCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_publicCheckBox.UId = new Guid("6c20b7eb-f92c-4837-89ab-f3cec1e972a9");
			_publicCheckBox.Name = "PublicCheckBox";
			_publicCheckBox.CreatedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
			_publicCheckBox.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
			_publicCheckBox.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_publicCheckBox.Tag = "";
			_publicCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_publicCheckBox.Width = System.Web.UI.WebControls.Unit.Pixel(55);
			_publicCheckBox.DataSource = "DataSource";
			_publicCheckBox.ColumnUId = new Guid("3946ed49-6178-4992-a12f-d6b9573fe484");
			return _publicCheckBox;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout2() {
			_controlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout2.UId = new Guid("f593bef7-55ef-4012-b66e-750ac40f452d");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
			_controlLayout2.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
			_controlLayout2.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout2.Tag = "";
			_controlLayout2.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout2.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout2.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout2.FitHeightByContent = true;
			_controlLayout2.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout2.StartNewAlignGroup = false;
			_controlLayout2.Image = new ControlImage {};
			_controlLayout2.Edges = "";
			return _controlLayout2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MemoEdit CreateMemoEdit1() {
			_memoEdit1 = new Terrasoft.UI.WebControls.Controls.MemoEdit();
			_memoEdit1.UId = new Guid("5c42a70a-a600-47f4-bb91-b9dceb54d42f");
			_memoEdit1.Name = "MemoEdit1";
			_memoEdit1.CreatedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
			_memoEdit1.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
			_memoEdit1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_memoEdit1.Tag = "";
			_memoEdit1.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_memoEdit1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_memoEdit1.AlignedByCaption = false;
			_memoEdit1.DataSource = "DataSource";
			_memoEdit1.ColumnUId = new Guid("62c8c6da-c396-4880-a203-759b27913aba");
			return _memoEdit1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout3() {
			_controlLayout3 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout3.UId = new Guid("039d8c36-37eb-4908-bf5a-ff023c608b89");
			_controlLayout3.Name = "ControlLayout3";
			_controlLayout3.CreatedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
			_controlLayout3.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
			_controlLayout3.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout3.Tag = "";
			_controlLayout3.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout3.FitHeightByContent = true;
			_controlLayout3.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout3.StartNewAlignGroup = false;
			_controlLayout3.Image = new ControlImage {};
			_controlLayout3.Edges = "";
			return _controlLayout3;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("951e1ea9-e14f-4ef5-a9e6-e3673c2f7bb7");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
			_controlLayout1.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout1.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout1.FitHeightByContent = true;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff");
			DataSource.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("c663fc2b-e3b0-4475-a10f-c50e80ab78bf");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("e14530d0-899e-4af6-abec-7536a36b25bf");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("bf6eea58-5243-4a9f-9832-c40ef0b8cad7");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("3874004c-c305-468b-90d3-e67a5d351228");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("424c2295-1b99-4022-95a6-d03abfa4a317");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("abc96728-faf6-451d-91f6-35bc53ea9745");
			if (column != null) {
				column.UId = new Guid("62c8c6da-c396-4880-a203-759b27913aba");
				column.Name = @"Notes";
				column.CreatedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("6a86e81d-86b2-4650-b1dc-fd775bd0a277");
			if (column != null) {
				column.UId = new Guid("46999b36-4597-4201-a7db-7880f3fb6f54");
				column.Name = @"Login";
				column.CreatedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("6287d2bd-93ac-4ca2-921f-3e87d81dc00b");
			if (column != null) {
				column.UId = new Guid("3946ed49-6178-4992-a12f-d6b9573fe484");
				column.Name = @"Public";
				column.CreatedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("14f15a6f-d70a-4c77-8f00-984f7bc1821f");
			if (column != null) {
				column.UId = new Guid("43bb654f-ce92-4d1b-9f83-68156d8b504c");
				column.Name = @"AccessToken";
				column.CreatedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("6be6d2f0-6c1c-463b-8daa-972f1687ec4f");
			if (column != null) {
				column.UId = new Guid("be5c09d4-8c51-442d-a568-45f3add6643c");
				column.Name = @"Type";
				column.CreatedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("f22ba771-1414-4be2-9ff8-3028ce093bcf");
			if (column != null) {
				column.UId = new Guid("a8fbf2d2-d569-4edb-aa05-a1495337297e");
				column.Name = @"User";
				column.CreatedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("72ef9eba-b06f-4bda-b9e1-4c04309aaf5e");
			if (column != null) {
				column.UId = new Guid("e06db55d-f79b-461b-ba1b-7c57246d5ad8");
				column.Name = @"SocialId";
				column.CreatedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("bbaf2034-8e52-432d-849c-9ddf83e19d6f");
			if (column != null) {
				column.UId = new Guid("395f6d6d-9b74-425c-8455-fad7bf33edbd");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
				column.ModifiedInSchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
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
			return new SocialAccountEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new SocialAccountEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SocialAccountEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SocialAccountEditPageEventsProcess

	/// <exclude/>
	public class SocialAccountEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SocialAccountEditPageSchemaUserControl
	{

		#region Class: OpenMessageWindowFlowElement

		/// <exclude/>
		public class OpenMessageWindowFlowElement : QuestionUserTask
		{

			public OpenMessageWindowFlowElement(UserConnection userConnection, SocialAccountEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenMessageWindow";
				IsLogging = false;
				SchemaElementUId = new Guid("5956e602-8975-4f22-98d0-5d313a033ff3");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: CreateSocialAccountUserTaskFlowElement

		/// <exclude/>
		public class CreateSocialAccountUserTaskFlowElement : CreateSocialAccountUserTask
		{

			public CreateSocialAccountUserTaskFlowElement(UserConnection userConnection, SocialAccountEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "CreateSocialAccountUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("ce7c2c32-b1a5-4aa6-b9a6-ad6b66b9c0bf");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public SocialAccountEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SocialAccountEditPageEventsProcess";
			SchemaUId = new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9d0d82f0-154b-4656-b6d6-024f54c62ffa");
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

		public virtual string ReturnValueKey {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("717e0ffa-b9be-4139-9c28-476388a164cb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage1;
		public ProcessFlowElement StartMessage1 {
			get {
				return _startMessage1 ?? (_startMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage1",
					SchemaElementUId = new Guid("2538245d-6233-4e6a-886d-5c388fcc1b7c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _userEditPrepareLookupFilterScriptTask;
		public ProcessScriptTask UserEditPrepareLookupFilterScriptTask {
			get {
				return _userEditPrepareLookupFilterScriptTask ?? (_userEditPrepareLookupFilterScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UserEditPrepareLookupFilterScriptTask",
					SchemaElementUId = new Guid("f0aae8ee-f4be-4218-b318-da2f549ee058"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UserEditPrepareLookupFilterScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent2;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent2 {
			get {
				return _intermediateThrowMessageEvent2 ?? (_intermediateThrowMessageEvent2 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent2",
					SchemaElementUId = new Guid("f1c0983e-3f9e-44ad-97cd-820c45d489ec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess2;
		public ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("17044ac5-c9c8-4551-b28f-759c7cc1aea7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage2;
		public ProcessFlowElement StartMessage2 {
			get {
				return _startMessage2 ?? (_startMessage2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage2",
					SchemaElementUId = new Guid("96de3f84-cc54-43ac-8782-173f31ad8907"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _oKBtnClickScriptTask;
		public ProcessScriptTask OKBtnClickScriptTask {
			get {
				return _oKBtnClickScriptTask ?? (_oKBtnClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OKBtnClickScriptTask",
					SchemaElementUId = new Guid("2037da26-4c8f-4c88-add9-0cab9d633c27"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OKBtnClickScriptTaskExecute,
				});
			}
		}

		private OpenMessageWindowFlowElement _openMessageWindow;
		public OpenMessageWindowFlowElement OpenMessageWindow {
			get {
				return _openMessageWindow ?? (_openMessageWindow = new OpenMessageWindowFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _eventSubProcess3;
		public ProcessFlowElement EventSubProcess3 {
			get {
				return _eventSubProcess3 ?? (_eventSubProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3",
					SchemaElementUId = new Guid("2c8cc60f-7d78-4a7f-b0be-f4456511b4b5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask2;
		public ProcessScriptTask ScriptTask2 {
			get {
				return _scriptTask2 ?? (_scriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask2",
					SchemaElementUId = new Guid("e1e8ddcc-b8c7-4858-8cc5-708751f5ff06"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
				});
			}
		}

		private ProcessFlowElement _startMessage4;
		public ProcessFlowElement StartMessage4 {
			get {
				return _startMessage4 ?? (_startMessage4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4",
					SchemaElementUId = new Guid("45800540-328a-43c0-b161-df7dc95cdd55"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess6;
		public ProcessFlowElement EventSubProcess6 {
			get {
				return _eventSubProcess6 ?? (_eventSubProcess6 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess6",
					SchemaElementUId = new Guid("e68e0471-c792-4e4c-a998-28712b86c5ba"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _typeEditChangeStartMessage5;
		public ProcessFlowElement TypeEditChangeStartMessage5 {
			get {
				return _typeEditChangeStartMessage5 ?? (_typeEditChangeStartMessage5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "TypeEditChangeStartMessage5",
					SchemaElementUId = new Guid("7581ccdf-e270-4d66-966a-519ee35084f8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3;
		public ProcessScriptTask ScriptTask3 {
			get {
				return _scriptTask3 ?? (_scriptTask3 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3",
					SchemaElementUId = new Guid("a85f9cd4-ce08-4dfe-b409-f7885e7ff295"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess8;
		public ProcessFlowElement EventSubProcess8 {
			get {
				return _eventSubProcess8 ?? (_eventSubProcess8 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess8",
					SchemaElementUId = new Guid("b980b605-58ff-4aa4-be93-f912f46a2152"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage8;
		public ProcessFlowElement StartMessage8 {
			get {
				return _startMessage8 ?? (_startMessage8 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage8",
					SchemaElementUId = new Guid("9717e7d5-6073-48d7-96e8-48a13a515b5c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent3;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent3 {
			get {
				return _intermediateThrowMessageEvent3 ?? (_intermediateThrowMessageEvent3 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent3",
					SchemaElementUId = new Guid("ca9e7b13-4b63-4969-94c7-788691baaae6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptTask6;
		public ProcessScriptTask ScriptTask6 {
			get {
				return _scriptTask6 ?? (_scriptTask6 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask6",
					SchemaElementUId = new Guid("e7f47146-f777-49ef-9aa0-0c1d9ea6c6b4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask6Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess4;
		public ProcessFlowElement EventSubProcess4 {
			get {
				return _eventSubProcess4 ?? (_eventSubProcess4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4",
					SchemaElementUId = new Guid("182657e7-ce8e-4ad8-b951-b1cdd001732a"),
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
					SchemaElementUId = new Guid("d5c7a924-7aa4-49c1-b9b3-613bad2ec62e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessFlowElement _startMessage3;
		public ProcessFlowElement StartMessage3 {
			get {
				return _startMessage3 ?? (_startMessage3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3",
					SchemaElementUId = new Guid("5999fff7-3f13-4a40-bd87-6f3ef5164293"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private CreateSocialAccountUserTaskFlowElement _createSocialAccountUserTask;
		public CreateSocialAccountUserTaskFlowElement CreateSocialAccountUserTask {
			get {
				return _createSocialAccountUserTask ?? (_createSocialAccountUserTask = new CreateSocialAccountUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _eventSubProcess10;
		public ProcessFlowElement EventSubProcess10 {
			get {
				return _eventSubProcess10 ?? (_eventSubProcess10 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess10",
					SchemaElementUId = new Guid("8c0a399e-6a77-4647-b441-32bfb0d0cef5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _socialAccountCreationFailedEvent;
		public ProcessFlowElement SocialAccountCreationFailedEvent {
			get {
				return _socialAccountCreationFailedEvent ?? (_socialAccountCreationFailedEvent = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SocialAccountCreationFailedEvent",
					SchemaElementUId = new Guid("feef5120-f829-4bab-b62a-6316c0ab171d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask8;
		public ProcessScriptTask ScriptTask8 {
			get {
				return _scriptTask8 ?? (_scriptTask8 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask8",
					SchemaElementUId = new Guid("a4552c0b-a158-41e5-8513-bbe057dbbc52"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask8Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess9;
		public ProcessFlowElement EventSubProcess9 {
			get {
				return _eventSubProcess9 ?? (_eventSubProcess9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess9",
					SchemaElementUId = new Guid("096c4033-106a-42cf-9d6a-4de941144d57"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _socialAccountCreatedSuccessfullyEvent;
		public ProcessFlowElement SocialAccountCreatedSuccessfullyEvent {
			get {
				return _socialAccountCreatedSuccessfullyEvent ?? (_socialAccountCreatedSuccessfullyEvent = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SocialAccountCreatedSuccessfullyEvent",
					SchemaElementUId = new Guid("6bf85221-9968-45c0-bc1a-10dea7d9e6dd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask7;
		public ProcessScriptTask ScriptTask7 {
			get {
				return _scriptTask7 ?? (_scriptTask7 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask7",
					SchemaElementUId = new Guid("24e0f74c-b8ac-4724-9f20-a7f0030c0c95"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask7Execute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent1 {
			get {
				return _intermediateThrowMessageEvent1 ?? (_intermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("d50b5efd-7bc5-47fe-b5fe-2068b767eafb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OKButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess7;
		public ProcessFlowElement EventSubProcess7 {
			get {
				return _eventSubProcess7 ?? (_eventSubProcess7 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess7",
					SchemaElementUId = new Guid("8fccc841-f3b5-427c-92d9-9ca530bdc8aa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _userEditChangeStartMessage7;
		public ProcessFlowElement UserEditChangeStartMessage7 {
			get {
				return _userEditChangeStartMessage7 ?? (_userEditChangeStartMessage7 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "UserEditChangeStartMessage7",
					SchemaElementUId = new Guid("808d08e7-c671-4400-935e-1df334534701"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask5;
		public ProcessScriptTask ScriptTask5 {
			get {
				return _scriptTask5 ?? (_scriptTask5 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask5",
					SchemaElementUId = new Guid("ab34580a-93e6-4e44-b408-15e0202c7369"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask5Execute,
				});
			}
		}

		private LocalizableString _socialNetworkAuthFailedMessage;
		public LocalizableString SocialNetworkAuthFailedMessage {
			get {
				return _socialNetworkAuthFailedMessage ?? (_socialNetworkAuthFailedMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SocialNetworkAuthFailedMessage.Value"));
			}
		}

		private LocalizableString _openMessageWindowText;
		public LocalizableString OpenMessageWindowText {
			get {
				return _openMessageWindowText ?? (_openMessageWindowText = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.OpenMessageWindowText.Value"));
			}
		}

		private LocalizableString _openMessageWindowCaption;
		public LocalizableString OpenMessageWindowCaption {
			get {
				return _openMessageWindowCaption ?? (_openMessageWindowCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.OpenMessageWindowCaption.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[UserEditPrepareLookupFilterScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { UserEditPrepareLookupFilterScriptTask };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[OKBtnClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OKBtnClickScriptTask };
			FlowElements[OpenMessageWindow.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenMessageWindow };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[StartMessage4.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4 };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[TypeEditChangeStartMessage5.SchemaElementUId] = new Collection<ProcessFlowElement> { TypeEditChangeStartMessage5 };
			FlowElements[ScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3 };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[StartMessage8.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage8 };
			FlowElements[IntermediateThrowMessageEvent3.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent3 };
			FlowElements[ScriptTask6.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask6 };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[StartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3 };
			FlowElements[CreateSocialAccountUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateSocialAccountUserTask };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[SocialAccountCreationFailedEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialAccountCreationFailedEvent };
			FlowElements[ScriptTask8.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask8 };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[SocialAccountCreatedSuccessfullyEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialAccountCreatedSuccessfullyEvent };
			FlowElements[ScriptTask7.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask7 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[EventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7 };
			FlowElements[UserEditChangeStartMessage7.SchemaElementUId] = new Collection<ProcessFlowElement> { UserEditChangeStartMessage7 };
			FlowElements[ScriptTask5.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask5 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "UserEditPrepareLookupFilterScriptTask":
						break;
					case "IntermediateThrowMessageEvent2":
						e.Context.QueueTasks.Enqueue("UserEditPrepareLookupFilterScriptTask");
						break;
					case "EventSubProcess2":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("OKBtnClickScriptTask");
						break;
					case "OKBtnClickScriptTask":
						e.Context.QueueTasks.Enqueue("OpenMessageWindow");
						break;
					case "OpenMessageWindow":
						break;
					case "EventSubProcess3":
						break;
					case "ScriptTask2":
						break;
					case "StartMessage4":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "EventSubProcess6":
						break;
					case "TypeEditChangeStartMessage5":
						e.Context.QueueTasks.Enqueue("ScriptTask3");
						break;
					case "ScriptTask3":
						break;
					case "EventSubProcess8":
						break;
					case "StartMessage8":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent3");
						break;
					case "IntermediateThrowMessageEvent3":
						e.Context.QueueTasks.Enqueue("ScriptTask6");
						break;
					case "ScriptTask6":
						break;
					case "EventSubProcess4":
						break;
					case "ScriptTask1":
						e.Context.QueueTasks.Enqueue("CreateSocialAccountUserTask");
						break;
					case "StartMessage3":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "CreateSocialAccountUserTask":
						break;
					case "EventSubProcess10":
						break;
					case "SocialAccountCreationFailedEvent":
						e.Context.QueueTasks.Enqueue("ScriptTask8");
						break;
					case "ScriptTask8":
						break;
					case "EventSubProcess9":
						break;
					case "SocialAccountCreatedSuccessfullyEvent":
						e.Context.QueueTasks.Enqueue("ScriptTask7");
						break;
					case "ScriptTask7":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "EventSubProcess7":
						break;
					case "UserEditChangeStartMessage7":
						e.Context.QueueTasks.Enqueue("ScriptTask5");
						break;
					case "ScriptTask5":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage1");
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("StartMessage4");
			ActivatedEventElements.Add("TypeEditChangeStartMessage5");
			ActivatedEventElements.Add("StartMessage8");
			ActivatedEventElements.Add("StartMessage3");
			ActivatedEventElements.Add("SocialAccountCreationFailedEvent");
			ActivatedEventElements.Add("SocialAccountCreatedSuccessfullyEvent");
			ActivatedEventElements.Add("UserEditChangeStartMessage7");
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
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "UserEditPrepareLookupFilterScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserEditPrepareLookupFilterScriptTask";
					result = UserEditPrepareLookupFilterScriptTask.Execute(context, UserEditPrepareLookupFilterScriptTaskExecute);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent2.Execute(context);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "OKBtnClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OKBtnClickScriptTask";
					result = OKBtnClickScriptTask.Execute(context, OKBtnClickScriptTaskExecute);
					break;
				case "OpenMessageWindow":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenMessageWindow";
					result = OpenMessageWindow.Execute(context);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
					break;
				case "StartMessage4":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4";
					result = StartMessage4.Execute(context);
					break;
				case "EventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "TypeEditChangeStartMessage5":
					context.QueueTasks.Dequeue();
					context.SenderName = "TypeEditChangeStartMessage5";
					result = TypeEditChangeStartMessage5.Execute(context);
					break;
				case "ScriptTask3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3";
					result = ScriptTask3.Execute(context, ScriptTask3Execute);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage8":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage8";
					result = StartMessage8.Execute(context);
					break;
				case "IntermediateThrowMessageEvent3":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent3.Execute(context);
					break;
				case "ScriptTask6":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask6";
					result = ScriptTask6.Execute(context, ScriptTask6Execute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "StartMessage3":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3";
					result = StartMessage3.Execute(context);
					break;
				case "CreateSocialAccountUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CreateSocialAccountUserTask";
					result = CreateSocialAccountUserTask.Execute(context);
					break;
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "SocialAccountCreationFailedEvent":
					context.QueueTasks.Dequeue();
					context.SenderName = "SocialAccountCreationFailedEvent";
					result = SocialAccountCreationFailedEvent.Execute(context);
					break;
				case "ScriptTask8":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask8";
					result = ScriptTask8.Execute(context, ScriptTask8Execute);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "SocialAccountCreatedSuccessfullyEvent":
					context.QueueTasks.Dequeue();
					context.SenderName = "SocialAccountCreatedSuccessfullyEvent";
					result = SocialAccountCreatedSuccessfullyEvent.Execute(context);
					break;
				case "ScriptTask7":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask7";
					result = ScriptTask7.Execute(context, ScriptTask7Execute);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OKButtonClick");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "EventSubProcess7":
					context.QueueTasks.Dequeue();
					break;
				case "UserEditChangeStartMessage7":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserEditChangeStartMessage7";
					result = UserEditChangeStartMessage7.Execute(context);
					break;
				case "ScriptTask5":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask5";
					result = ScriptTask5.Execute(context, ScriptTask5Execute);
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

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "ReturnValueKey":
					ReturnValueKey = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool UserEditPrepareLookupFilterScriptTaskExecute(ProcessExecutingContext context) {
			Page.UserEdit.PrepareLookupFilter += (s, e) => {
					Collection<Dictionary<string, object>> filters = e.Filters;
					filters.Add(new Dictionary<string, object> { 
						{"comparisonType", FilterComparisonType.Equal}, 
						{"leftExpressionColumnPath", "SysAdminUnitTypeValue"},
						{"useDisplayValue", false}, 
						{"rightExpressionParameterValues", new object[] {(int)SysAdminUnitType.User}}
					});
				};
			
			Page.TypeEdit.PrepareLookupFilter += (s,e) => {
				Collection<Dictionary<string, object>> filters = e.Filters;
				EntitySchemaManager entitySchemaManager = Page.UserConnection.EntitySchemaManager;
				EntitySchema entitySchema = entitySchemaManager.GetInstanceByName("Contact");
				filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.Equal}, 
					{"leftExpressionColumnPath", "[ComTypebyCommunication:CommunicationType].Communication.Code"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {"SocialNetwork"}}
				});
				EntitySchemaColumn entitySchemaColumn = entitySchema.Columns.FindByName("LinkedIn");
				if (entitySchemaColumn.UsageType == EntitySchemaColumnUsageType.None) {
					filters.Add(new Dictionary<string, object> { 
						{"comparisonType", FilterComparisonType.NotEqual}, 
						{"leftExpressionColumnPath", "Id"},
						{"rightExpressionParameterValues", new object[] {TSConfiguration.CommunicationTypeConsts.LinkedInId}}
					});
				}
			};
			
			return true;
		}

		public virtual bool OKBtnClickScriptTaskExecute(ProcessExecutingContext context) {
			OpenMessageWindow.Page = Page;
			// OpenMessageWindow.MessageText = ConfirmAbandoningLocalizableString;
			OpenMessageWindow.Icon = "QUESTION";
			OpenMessageWindow.Buttons = "YESNO";
			OpenMessageWindow.MessageText = OpenMessageWindowText.ToString();
			OpenMessageWindow.WindowCaption = OpenMessageWindowCaption.ToString();
			OpenMessageWindow.ResponseMessages = new Dictionary<string, string> {
			       {"yes", "YesConfirmMessage"},
			       {"no", "NoConfirmMessage"}                                                           
			 };
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ScriptTask3Execute(ProcessExecutingContext context) {
			if (string.IsNullOrEmpty(Page.TypeEdit.Text)) {
				 return true;
			}
			 Func<string, string> systemValue = (name) => {
				 var value = SysSettings.GetValue(UserConnection, Page.TypeEdit.Text + name);
				 if (value != null) {
					 return value.ToString();
				 }
				 throw new ArgumentNullOrEmptyException("SystemValue." + Page.TypeEdit.Text + name);
			 };
			 Page.DataSource.ActiveRow.SetColumnValue("ConsumerKey", systemValue("ConsumerKey"));
			return true;
		}

		public virtual bool ScriptTask6Execute(ProcessExecutingContext context) {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageAdministration");
			if (!UserConnection.DBSecurityEngine.GetCanExecuteOperation("CanManageLookups")) {
				Page.DataSource.ActiveRow.SetColumnValue("UserId", UserConnection.CurrentUser.Id);
				Page.DataSource.ActiveRow.LoadLookupDisplayValues("User");
				Page.UserEdit.Enabled = false;
				Page.UserEdit.Hidden = true;
				Page.PublicCheckBox.Enabled = true;
				Page.PublicCheckBox.Checked = true;
			}
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			/*OpenSocialNetworkAuthPage.PageUId = new Guid("3b22f0ff-034a-48da-8758-a0660e5a26ff");;
			var parameters = new Dictionary<string, string>();
			ReturnValueKey = "SocialNetworkAuth" + Guid.NewGuid().ToString();
			parameters.Add("SocialNetwork", Page.TypeEdit.Text);
			parameters.Add("userid", Page.UserEdit.Value.ToString());
			parameters.Add("public", Page.PublicCheckBox.Checked.ToString());
			parameters.Add("ReturnValueKey", ReturnValueKey);
			parameters.Add("CloseMessage", "SocialNetworkAuthPageClosed");
			parameters.Add("FailedMessage", "SocialNetworkAuthFailed");
			parameters.Add("OpenerPageId", InstanceUId);
			OpenSocialNetworkAuthPage.PageParameters = parameters;
			OpenSocialNetworkAuthPage.OpenerInstanceId = InstanceUId;
			// OpenSocialNetworkAuthPage.CloseMessage = "SocialNetworkAuthPageClosed";
			*/
			
			CreateSocialAccountUserTask.UserId = (Guid)Page.UserEdit.Value;
			CreateSocialAccountUserTask.SocialNetwork = Page.TypeEdit.Text;
			CreateSocialAccountUserTask.OpenerPageId = InstanceUId;
			return true;
		}

		public virtual bool ScriptTask8Execute(ProcessExecutingContext context) {
			Page.BaseMessagePanel.AddMessage(string.Empty, SocialNetworkAuthFailedMessage, MessageType.Warning);
			return true;
		}

		public virtual bool ScriptTask7Execute(ProcessExecutingContext context) {
			string claim = context.ThrowEventArgs.ToString();
			
			var jclaim = (JToken)Json.Deserialize(claim);
			var token = ((JValue)jclaim["Token"]).Value.ToString();
			var secret = ((JValue)jclaim["Secret"]).Value.ToString();
			var socialId = ((JValue)jclaim["SocialId"]).Value.ToString();
			
			ScriptManager scriptManager = ((Terrasoft.UI.WebControls.Page)System.Web.HttpContext.Current.CurrentHandler).FindControl("ScriptManager") as ScriptManager;
			var converters = new JsonConverter[] {new GuidJsonConverter()};
			string id = Json.Serialize(Page.DataSource.ActiveRow.PrimaryColumnValue, converters[0]);
			string script = Page.DataSource.ClientID + 
			".onActiveRowColumnValuesChangedResponse(" + id + @",{'AccessToken' : {columnValue: '" + token + "'}})";
			scriptManager.AddScript(script);
			
			script = Page.DataSource.ClientID + 
			".onActiveRowColumnValuesChangedResponse(" + id + @",{'AccessSecretToken' : {columnValue: '" + secret + "'}})";
			scriptManager.AddScript(script);
			
			script = Page.DataSource.ClientID + 
			".onActiveRowColumnValuesChangedResponse(" + id + @",{'SocialId' : {columnValue: '" + socialId + "'}})";
			scriptManager.AddScript(script);
			return true;
		}

		public virtual bool ScriptTask5Execute(ProcessExecutingContext context) {
			if(!Page.UserEdit.Hidden) {
				if (string.IsNullOrEmpty(Page.UserEdit.Text)) {
					Page.PublicCheckBox.Enabled = false;
					Page.PublicCheckBox.Checked = true;
				} else {
					Page.PublicCheckBox.Enabled = true;
				}
			}
			
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
							ProcessQueue(context);
							return;
						}
						break;
					case "OKButtonClick":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
							ProcessQueue(context);
							return;
						}
						break;
					case "NoConfirmMessage":
							if (ActivatedEventElements.Contains("StartMessage4")) {
							context.QueueTasks.Enqueue("StartMessage4");
						}
						break;
					case "TypeEditChange":
							if (ActivatedEventElements.Contains("TypeEditChangeStartMessage5")) {
							context.QueueTasks.Enqueue("TypeEditChangeStartMessage5");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessage8")) {
							context.QueueTasks.Enqueue("StartMessage8");
							ProcessQueue(context);
							return;
						}
						break;
					case "YesConfirmMessage":
							if (ActivatedEventElements.Contains("StartMessage3")) {
							context.QueueTasks.Enqueue("StartMessage3");
						}
						break;
					case "SocialAccountCreationFailedEvent":
							if (ActivatedEventElements.Contains("SocialAccountCreationFailedEvent")) {
							context.QueueTasks.Enqueue("SocialAccountCreationFailedEvent");
						}
						break;
					case "SocialAccountCreatedSuccessfullyEvent":
							if (ActivatedEventElements.Contains("SocialAccountCreatedSuccessfullyEvent")) {
							context.QueueTasks.Enqueue("SocialAccountCreatedSuccessfullyEvent");
						}
						break;
					case "UserEditChange":
							if (ActivatedEventElements.Contains("UserEditChangeStartMessage7")) {
							context.QueueTasks.Enqueue("UserEditChangeStartMessage7");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("ReturnValueKey") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ReturnValueKey", ReturnValueKey, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SocialAccountEditPageEventsProcess

	/// <exclude/>
	public class SocialAccountEditPageEventsProcess : SocialAccountEditPageEventsProcess<Terrasoft.WebApp.SocialAccountEditPageSchemaUserControl>
	{

		public SocialAccountEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SocialAccountEditPageSchemaUserControl

	/// <exclude/>
	public partial class SocialAccountEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("NameEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit UserEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("UserEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit TypeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("TypeEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit LoginEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("LoginEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox PublicCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("PublicCheckBox", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout3", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MemoEdit MemoEdit1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.MemoEdit)PageContainer.FindPageControl("MemoEdit1", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			UserEdit.AjaxEvents.Change.Event += UserEditChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			UserEdit.AjaxEvents.Change.Event -= UserEditChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (SocialAccountEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SocialAccountEditPageEventsProcess(UserConnection);
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

		public virtual void UserEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("UserEditChange");
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
			SchemaName = "SocialAccountEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: SocialAccountEditPageEventsProcessSchema

	/// <exclude/>
	public class SocialAccountEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public SocialAccountEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SocialAccountEditPageEventsProcessSchema(SocialAccountEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SocialAccountEditPageEventsProcess";
			UId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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

		protected virtual ProcessSchemaParameter CreateReturnValueKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("48ac5bbd-13e6-4617-8cf9-fc79397cafe1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"ReturnValueKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateReturnValueKeyParameter());
		}

		protected virtual void InitializeOpenMessageWindowParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("878456b2-556c-485c-9c3f-35ec7d663aa2"),
				ContainerUId = new Guid("5956e602-8975-4f22-98d0-5d313a033ff3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"Page",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("dd59206d-a650-4124-98b6-9d4c215f4a0c"),
				ContainerUId = new Guid("5956e602-8975-4f22-98d0-5d313a033ff3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"Icon",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("f2555c84-d97a-42db-a128-acd8403080db"),
				ContainerUId = new Guid("5956e602-8975-4f22-98d0-5d313a033ff3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"Buttons",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("9a9dbc79-0d94-410a-81ab-1ef01e475261"),
				ContainerUId = new Guid("5956e602-8975-4f22-98d0-5d313a033ff3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"WindowCaption",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("58e3a9de-bdbb-474e-ae37-e1328e2eb57d"),
				ContainerUId = new Guid("5956e602-8975-4f22-98d0-5d313a033ff3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"MessageText",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("7f2810a4-e1a6-4fd7-9d33-6de0de89c79a"),
				ContainerUId = new Guid("5956e602-8975-4f22-98d0-5d313a033ff3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"ResponseMessages",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("2792343a-3e7b-42a1-a1ca-9e47ec941f66"),
				ContainerUId = new Guid("5956e602-8975-4f22-98d0-5d313a033ff3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"ProcessInstanceId",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("f8667826-3f13-455d-bb2b-df79ab60e665"),
				ContainerUId = new Guid("5956e602-8975-4f22-98d0-5d313a033ff3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"PageParameters",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
		}

		protected virtual void InitializeCreateSocialAccountUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("230154c9-fa61-4255-b056-07be1db07d7b"),
				ContainerUId = new Guid("ce7c2c32-b1a5-4aa6-b9a6-ad6b66b9c0bf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				Direction = ProcessSchemaParameterDirection.In,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				Name = @"UserId",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("26147ba3-0637-4491-b60b-5faf0b4d5c4c"),
				ContainerUId = new Guid("ce7c2c32-b1a5-4aa6-b9a6-ad6b66b9c0bf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				Direction = ProcessSchemaParameterDirection.In,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				Name = @"SocialNetwork",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("91ab832a-109d-4bb1-9185-fb9dbcc61873"),
				ContainerUId = new Guid("ce7c2c32-b1a5-4aa6-b9a6-ad6b66b9c0bf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				Direction = ProcessSchemaParameterDirection.In,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				Name = @"OpenerPageId",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("0395146f-f4c3-4c3c-abc5-ab184af0959e"),
				ContainerUId = new Guid("ce7c2c32-b1a5-4aa6-b9a6-ad6b66b9c0bf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				Name = @"SuccessEventName",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("ae0f6353-dfbb-420f-8447-64cb253ce231"),
				ContainerUId = new Guid("ce7c2c32-b1a5-4aa6-b9a6-ad6b66b9c0bf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				Name = @"FailedEventName",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet203 = CreateLaneSet203LaneSet();
			LaneSets.Add(schemaLaneSet203);
			ProcessSchemaLane schemaLane547 = CreateLane547Lane();
			schemaLaneSet203.Lanes.Add(schemaLane547);
			ProcessSchemaLane schemaLane548 = CreateLane548Lane();
			schemaLaneSet203.Lanes.Add(schemaLane548);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess eventsubprocess7 = CreateEventSubProcess7EventSubProcess();
			FlowElements.Add(eventsubprocess7);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask usereditpreparelookupfilterscripttask = CreateUserEditPrepareLookupFilterScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(usereditpreparelookupfilterscripttask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess2.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask okbtnclickscripttask = CreateOKBtnClickScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(okbtnclickscripttask);
			ProcessSchemaUserTask openmessagewindow = CreateOpenMessageWindowUserTask();
			eventsubprocess2.FlowElements.Add(openmessagewindow);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess3.FlowElements.Add(scripttask2);
			ProcessSchemaStartMessageEvent startmessage4 = CreateStartMessage4StartMessageEvent();
			eventsubprocess3.FlowElements.Add(startmessage4);
			ProcessSchemaStartMessageEvent typeeditchangestartmessage5 = CreateTypeEditChangeStartMessage5StartMessageEvent();
			eventsubprocess6.FlowElements.Add(typeeditchangestartmessage5);
			ProcessSchemaScriptTask scripttask3 = CreateScriptTask3ScriptTask();
			eventsubprocess6.FlowElements.Add(scripttask3);
			ProcessSchemaStartMessageEvent startmessage8 = CreateStartMessage8StartMessageEvent();
			eventsubprocess8.FlowElements.Add(startmessage8);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent3 = CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent();
			eventsubprocess8.FlowElements.Add(intermediatethrowmessageevent3);
			ProcessSchemaScriptTask scripttask6 = CreateScriptTask6ScriptTask();
			eventsubprocess8.FlowElements.Add(scripttask6);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess4.FlowElements.Add(scripttask1);
			ProcessSchemaStartMessageEvent startmessage3 = CreateStartMessage3StartMessageEvent();
			eventsubprocess4.FlowElements.Add(startmessage3);
			ProcessSchemaUserTask createsocialaccountusertask = CreateCreateSocialAccountUserTaskUserTask();
			eventsubprocess4.FlowElements.Add(createsocialaccountusertask);
			ProcessSchemaStartMessageEvent socialaccountcreationfailedevent = CreateSocialAccountCreationFailedEventStartMessageEvent();
			eventsubprocess10.FlowElements.Add(socialaccountcreationfailedevent);
			ProcessSchemaScriptTask scripttask8 = CreateScriptTask8ScriptTask();
			eventsubprocess10.FlowElements.Add(scripttask8);
			ProcessSchemaStartMessageEvent socialaccountcreatedsuccessfullyevent = CreateSocialAccountCreatedSuccessfullyEventStartMessageEvent();
			eventsubprocess9.FlowElements.Add(socialaccountcreatedsuccessfullyevent);
			ProcessSchemaScriptTask scripttask7 = CreateScriptTask7ScriptTask();
			eventsubprocess9.FlowElements.Add(scripttask7);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess9.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaStartMessageEvent usereditchangestartmessage7 = CreateUserEditChangeStartMessage7StartMessageEvent();
			eventsubprocess7.FlowElements.Add(usereditchangestartmessage7);
			ProcessSchemaScriptTask scripttask5 = CreateScriptTask5ScriptTask();
			eventsubprocess7.FlowElements.Add(scripttask5);
			Artifacts.Add(CreateGroup1Group());
			FlowElements.Add(CreateSequenceFlow3465SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3466SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3467SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3468SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3472SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateSocialNetworkAuthFailedMessageLocalizableString());
			LocalizableStrings.Add(CreateOpenMessageWindowTextLocalizableString());
			LocalizableStrings.Add(CreateOpenMessageWindowCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateSocialNetworkAuthFailedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("74c7c880-dfb8-4db5-9da0-7c902defe5e9"),
				Name = "SocialNetworkAuthFailedMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOpenMessageWindowTextLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f783ce6b-364a-4878-af54-c817142cfaa7"),
				Name = "OpenMessageWindowText",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOpenMessageWindowCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("707b4a50-fb94-4907-84ca-9360641b18e4"),
				Name = "OpenMessageWindowCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3465SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3465",
				UId = new Guid("5a17f187-d444-425a-82c7-e08e2f76905d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("96de3f84-cc54-43ac-8782-173f31ad8907"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2037da26-4c8f-4c88-add9-0cab9d633c27"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3466SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3466",
				UId = new Guid("6d0e377a-ebd2-46e6-8235-fbd4bae3fbf1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				CurveCenterPosition = new Point(298, 264),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2037da26-4c8f-4c88-add9-0cab9d633c27"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5956e602-8975-4f22-98d0-5d313a033ff3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3467SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3467",
				UId = new Guid("727618fa-b95d-4f24-915b-620c6f92f13c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				CurveCenterPosition = new Point(519, 236),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5999fff7-3f13-4a40-bd87-6f3ef5164293"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d5c7a924-7aa4-49c1-b9b3-613bad2ec62e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3468SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3468",
				UId = new Guid("76289629-e12e-4e83-95a6-4752bdb0140c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				CurveCenterPosition = new Point(482, 336),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("45800540-328a-43c0-b161-df7dc95cdd55"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e1e8ddcc-b8c7-4858-8cc5-708751f5ff06"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3472SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3472",
				UId = new Guid("51c68b2d-b86d-4434-b14a-7b05f577e07a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7581ccdf-e270-4d66-966a-519ee35084f8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a85f9cd4-ce08-4dfe-b409-f7885e7ff295"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("510a1b36-5aa6-4728-b65f-962c47084165"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				CurveCenterPosition = new Point(157, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2538245d-6233-4e6a-886d-5c388fcc1b7c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f1c0983e-3f9e-44ad-97cd-820c45d489ec"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("9ebc1664-a801-47ff-b1dc-541ee2d0ed38"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				CurveCenterPosition = new Point(238, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f1c0983e-3f9e-44ad-97cd-820c45d489ec"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f0aae8ee-f4be-4218-b318-da2f549ee058"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("3b105bb0-4b1a-4ca4-8ac5-9774f7c1cada"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				CurveCenterPosition = new Point(148, 254),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9717e7d5-6073-48d7-96e8-48a13a515b5c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ca9e7b13-4b63-4969-94c7-788691baaae6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("eb5a3cc1-fa9b-47e8-9178-9e7edbff0937"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				CurveCenterPosition = new Point(300, 244),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ca9e7b13-4b63-4969-94c7-788691baaae6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e7f47146-f777-49ef-9aa0-0c1d9ea6c6b4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("fa4b2655-b8a7-4ff4-9238-25dfc94b7b44"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				CurveCenterPosition = new Point(660, 516),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d5c7a924-7aa4-49c1-b9b3-613bad2ec62e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ce7c2c32-b1a5-4aa6-b9a6-ad6b66b9c0bf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("aebae2f2-eac0-4c1e-90b6-4502fee8a747"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				CurveCenterPosition = new Point(524, 682),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6bf85221-9968-45c0-bc1a-10dea7d9e6dd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("24e0f74c-b8ac-4724-9f20-a7f0030c0c95"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("0f866e33-8f37-41b5-ab75-3287978cd025"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				CurveCenterPosition = new Point(532, 786),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("feef5120-f829-4bab-b62a-6316c0ab171d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a4552c0b-a158-41e5-8513-bbe057dbbc52"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("d96978c5-429a-4fe2-abbc-1f5e452e9b46"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				CurveCenterPosition = new Point(648, 680),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("24e0f74c-b8ac-4724-9f20-a7f0030c0c95"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d50b5efd-7bc5-47fe-b5fe-2068b767eafb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("8fdd4ce2-f4a8-48c3-b20c-ec047ff8e4b8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("808d08e7-c671-4400-935e-1df334534701"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ab34580a-93e6-4e44-b408-15e0202c7369"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet203LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet203 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("a8228f69-6a95-42fa-8eee-c045730df4f3"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"LaneSet203",
				Position = new Point(5, 5),
				Size = new Size(918, 1098),
				UseBackgroundMode = false
			};
			return schemaLaneSet203;
		}

		protected virtual ProcessSchemaLane CreateLane547Lane() {
			ProcessSchemaLane schemaLane547 = new ProcessSchemaLane(this) {
				UId = new Guid("bef6be0d-14f6-4733-aea7-0a4b8f12ee19"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("a8228f69-6a95-42fa-8eee-c045730df4f3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"Lane547",
				Position = new Point(29, 354),
				Size = new Size(889, 744),
				UseBackgroundMode = false
			};
			return schemaLane547;
		}

		protected virtual ProcessSchemaLane CreateLane548Lane() {
			ProcessSchemaLane schemaLane548 = new ProcessSchemaLane(this) {
				UId = new Guid("49be16e3-da03-4008-8ccd-b6d5be010c7e"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("a8228f69-6a95-42fa-8eee-c045730df4f3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"Lane548",
				Position = new Point(29, 0),
				Size = new Size(889, 349),
				UseBackgroundMode = false
			};
			return schemaLane548;
		}

		protected virtual ProcessSchemaGroup CreateGroup1Group() {
			ProcessSchemaGroup schemaGroup1 = new ProcessSchemaGroup(this) {
				UId = new Guid("4859d00a-9527-4d5b-8807-ba49fe26a711"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bef6be0d-14f6-4733-aea7-0a4b8f12ee19"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Group",
				IsExpanded = true,
				ManagerItemUId = new Guid("eb7053a9-51e7-456f-9498-73ccc42bfeb6"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"Group1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(371, 112),
				Size = new Size(504, 464),
				UseBackgroundMode = false
			};
			schemaGroup1.CategorizedFlowElementsUIds = new Collection<Guid>() {
			};
			return schemaGroup1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("717e0ffa-b9be-4139-9c28-476388a164cb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("49be16e3-da03-4008-8ccd-b6d5be010c7e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"EventSubProcess1",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(377, 144),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2538245d-6233-4e6a-886d-5c388fcc1b7c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("717e0ffa-b9be-4139-9c28-476388a164cb"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"StartMessage1",
				Position = new Point(28, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUserEditPrepareLookupFilterScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f0aae8ee-f4be-4218-b318-da2f549ee058"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("717e0ffa-b9be-4139-9c28-476388a164cb"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"UserEditPrepareLookupFilterScriptTask",
				Position = new Point(189, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,84,203,110,219,48,16,60,219,128,255,97,161,147,140,10,252,128,38,50,144,58,110,97,32,53,4,56,233,37,200,129,145,86,54,107,137,84,73,10,169,32,232,223,187,148,172,56,178,243,128,91,244,162,199,46,103,118,185,51,100,196,55,200,238,12,234,69,34,44,139,52,22,92,227,141,82,187,178,248,42,50,139,26,62,133,224,155,0,112,10,225,12,234,201,120,52,154,171,44,195,216,10,37,47,175,69,251,230,186,186,52,86,11,185,9,64,61,254,164,228,108,6,105,139,55,16,2,178,142,203,92,56,248,62,206,174,146,196,151,248,4,111,115,64,13,14,48,170,189,88,229,212,152,48,74,222,86,5,122,1,116,132,243,65,152,45,126,149,60,107,130,30,148,97,106,23,191,11,141,198,16,63,117,93,230,50,226,118,75,112,111,93,153,171,36,23,242,78,10,235,176,63,120,86,162,215,4,123,104,105,240,90,152,34,227,85,151,8,32,229,153,193,3,183,22,155,237,11,242,136,107,158,35,117,212,46,55,180,222,237,172,219,198,253,3,212,190,144,118,122,92,179,157,123,211,56,198,102,234,70,211,208,99,50,142,156,36,46,255,129,36,7,69,254,77,144,133,180,194,86,235,120,139,57,255,206,37,85,215,128,175,196,66,136,122,179,204,149,148,93,65,246,10,250,152,116,192,230,170,159,66,216,55,180,75,105,44,151,49,126,169,86,52,75,223,163,34,150,199,214,107,71,115,182,105,254,198,51,239,91,230,158,144,14,242,88,209,71,94,74,17,115,215,194,231,193,159,91,240,192,6,33,250,75,122,107,125,228,172,179,141,229,173,85,44,120,182,66,251,164,244,206,107,221,212,153,233,165,2,221,70,6,131,223,135,134,106,176,46,106,200,30,50,233,117,184,17,114,135,201,82,118,66,136,20,252,83,30,114,5,201,232,54,15,97,8,167,165,159,211,108,165,36,25,183,254,191,23,193,74,217,51,238,130,101,114,56,248,103,142,255,118,77,46,77,197,166,212,189,212,71,94,160,180,177,134,245,51,92,38,131,243,62,25,119,71,94,163,45,181,4,171,75,188,248,3,228,155,74,48,146,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("f1c0983e-3f9e-44ad-97cd-820c45d489ec"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("717e0ffa-b9be-4139-9c28-476388a164cb"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(105, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("17044ac5-c9c8-4551-b28f-759c7cc1aea7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bef6be0d-14f6-4733-aea7-0a4b8f12ee19"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"EventSubProcess2",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(325, 175),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("96de3f84-cc54-43ac-8782-173f31ad8907"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("17044ac5-c9c8-4551-b28f-759c7cc1aea7"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"StartMessage2",
				Position = new Point(14, 77),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOKBtnClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2037da26-4c8f-4c88-add9-0cab9d633c27"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("17044ac5-c9c8-4551-b28f-759c7cc1aea7"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"OKBtnClickScriptTask",
				Position = new Point(91, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,144,193,138,194,48,16,134,239,121,138,33,39,23,138,62,64,93,65,93,15,130,219,186,182,34,30,99,29,37,224,78,74,146,226,170,248,238,38,54,32,218,130,176,115,153,100,230,251,127,254,36,45,145,190,209,24,177,199,149,164,173,58,118,231,238,8,159,224,91,204,122,61,72,27,68,184,229,248,103,29,56,86,180,147,250,119,184,17,110,73,146,246,51,85,136,131,60,139,205,1,51,171,221,32,102,77,143,105,161,200,137,249,207,114,146,229,211,52,225,109,208,168,178,86,145,241,220,122,146,37,105,43,244,156,166,177,247,243,110,174,234,36,157,143,54,135,186,141,69,105,229,61,84,131,8,171,55,54,11,52,165,75,139,97,234,99,19,30,225,75,22,94,44,244,169,111,238,234,8,234,62,128,11,131,186,46,252,132,134,71,238,153,104,194,127,6,23,126,141,30,16,41,207,36,234,21,129,255,23,131,107,204,52,218,74,19,88,93,97,124,3,86,17,91,254,17,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenMessageWindowUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("5956e602-8975-4f22-98d0-5d313a033ff3"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("17044ac5-c9c8-4551-b28f-759c7cc1aea7"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"OpenMessageWindow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(217, 63),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenMessageWindowParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2c8cc60f-7d78-4a7f-b0be-f4456511b4b5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bef6be0d-14f6-4733-aea7-0a4b8f12ee19"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(379, 12),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(196, 93),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e1e8ddcc-b8c7-4858-8cc5-708751f5ff06"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2c8cc60f-7d78-4a7f-b0be-f4456511b4b5"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"ScriptTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(92, 19),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage4StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("45800540-328a-43c0-b161-df7dc95cdd55"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2c8cc60f-7d78-4a7f-b0be-f4456511b4b5"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"NoConfirmMessage",
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"StartMessage4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e68e0471-c792-4e4c-a998-28712b86c5ba"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("49be16e3-da03-4008-8ccd-b6d5be010c7e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"EventSubProcess6",
				Position = new Point(456, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateTypeEditChangeStartMessage5StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7581ccdf-e270-4d66-966a-519ee35084f8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e68e0471-c792-4e4c-a998-28712b86c5ba"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"TypeEditChange",
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"TypeEditChangeStartMessage5",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a85f9cd4-ce08-4dfe-b409-f7885e7ff295"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e68e0471-c792-4e4c-a998-28712b86c5ba"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"ScriptTask3",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,65,75,196,48,16,133,207,246,87,140,61,165,88,242,7,214,46,44,107,21,17,84,108,245,30,234,88,11,109,82,38,147,237,22,233,127,119,76,65,87,4,15,67,14,47,243,222,251,166,123,3,229,153,58,219,234,91,127,31,250,254,129,202,97,228,89,61,154,22,117,61,143,88,190,118,172,107,60,114,150,193,71,114,6,132,28,200,2,83,192,77,178,36,112,29,108,115,185,90,228,176,190,91,240,179,103,28,94,76,31,16,10,80,214,12,152,65,177,141,6,7,67,50,171,82,205,190,66,102,217,241,250,6,57,46,168,103,143,180,119,214,98,195,157,179,57,252,173,2,23,16,45,55,98,215,9,193,106,119,94,128,21,130,88,243,187,103,148,116,237,170,216,76,197,149,69,134,223,201,77,96,113,130,29,181,97,64,203,39,244,229,177,193,241,43,92,165,213,15,137,78,37,247,191,50,176,200,196,15,87,134,77,229,2,53,168,119,66,113,192,39,55,105,33,221,187,62,12,118,197,76,133,209,75,50,221,225,156,230,167,39,251,45,101,226,124,122,244,79,61,226,75,117,179,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b980b605-58ff-4aa4-be93-f912f46a2152"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("49be16e3-da03-4008-8ccd-b6d5be010c7e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"EventSubProcess8",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 161),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(374, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage8StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9717e7d5-6073-48d7-96e8-48a13a515b5c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b980b605-58ff-4aa4-be93-f912f46a2152"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"StartMessage8",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("ca9e7b13-4b63-4969-94c7-788691baaae6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b980b605-58ff-4aa4-be93-f912f46a2152"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"IntermediateThrowMessageEvent3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask6ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e7f47146-f777-49ef-9aa0-0c1d9ea6c6b4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b980b605-58ff-4aa4-be93-f912f46a2152"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"ScriptTask6",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(246, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,205,106,195,48,16,132,207,53,248,29,84,157,108,40,122,129,208,67,98,155,54,144,146,80,147,222,55,214,38,21,81,86,70,63,109,66,233,187,87,178,15,9,45,184,183,213,204,236,183,131,182,14,109,101,136,176,243,202,144,168,23,45,118,193,42,127,105,232,160,8,69,245,142,221,177,2,106,206,81,247,184,238,209,66,74,22,60,138,47,64,112,192,185,60,41,82,206,143,6,47,103,121,166,246,172,184,223,254,131,126,66,63,13,94,25,115,12,189,227,101,201,190,242,236,110,19,37,81,131,135,214,4,219,161,152,71,238,7,190,154,79,209,70,146,209,225,68,111,160,3,22,60,93,94,74,254,192,126,85,168,130,181,72,62,169,98,41,83,209,9,232,202,128,28,27,212,202,245,26,46,3,220,141,116,126,93,78,207,70,42,47,26,130,157,70,201,30,217,30,180,195,191,129,103,37,37,82,244,189,13,87,123,19,118,90,117,195,63,47,204,249,134,50,149,26,134,219,212,119,158,89,244,193,210,40,252,0,137,224,10,134,215,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("182657e7-ce8e-4ad8-b951-b1cdd001732a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4859d00a-9527-4d5b-8807-ba49fe26a711"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"EventSubProcess4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 21),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(371, 130),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d5c7a924-7aa4-49c1-b9b3-613bad2ec62e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("182657e7-ce8e-4ad8-b951-b1cdd001732a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(105, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,91,111,130,48,24,125,231,87,52,60,137,147,75,188,205,132,109,137,115,151,152,101,206,76,220,123,165,31,218,200,10,105,203,156,255,126,109,153,17,38,227,5,40,57,183,158,28,191,251,150,3,91,101,49,197,233,2,228,33,227,251,105,33,119,75,188,5,79,63,214,115,130,110,17,131,3,122,46,40,233,216,131,77,191,159,4,73,226,6,131,33,118,135,19,130,221,201,245,104,226,226,96,60,14,96,132,251,227,36,177,157,48,180,190,48,71,57,230,248,19,36,112,241,171,241,64,99,73,51,134,249,241,70,72,78,217,182,135,202,247,93,199,9,173,119,144,5,103,31,56,45,224,5,142,138,98,95,228,178,209,149,9,226,45,224,96,2,57,94,148,173,140,132,86,56,27,122,83,162,210,214,248,118,15,153,107,69,199,28,30,9,149,94,4,223,178,129,84,8,224,148,156,208,107,117,50,104,147,171,226,214,192,204,139,77,74,227,19,115,105,78,179,29,196,251,251,236,219,51,31,64,218,21,234,21,40,165,250,143,6,198,44,205,4,188,130,16,202,82,225,47,43,211,89,12,136,216,13,244,39,76,83,32,109,252,18,209,196,213,203,1,174,245,231,186,174,57,19,18,179,88,79,70,129,219,103,181,172,46,227,172,219,70,43,221,78,38,102,150,21,199,208,242,125,244,63,185,218,82,227,176,42,45,133,86,215,183,172,25,7,44,161,196,77,227,56,43,152,212,83,136,176,216,155,77,152,0,29,189,65,167,97,39,97,43,191,230,174,100,46,103,217,206,175,22,255,183,6,110,6,131,36,87,33,126,0,233,210,147,175,221,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5999fff7-3f13-4a40-bd87-6f3ef5164293"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("182657e7-ce8e-4ad8-b951-b1cdd001732a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"YesConfirmMessage",
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"StartMessage3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaUserTask CreateCreateSocialAccountUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ce7c2c32-b1a5-4aa6-b9a6-ad6b66b9c0bf"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("182657e7-ce8e-4ad8-b951-b1cdd001732a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"CreateSocialAccountUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(232, 30),
				SchemaUId = new Guid("4c647b90-1d28-415a-8393-3699e8ed5e25"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeCreateSocialAccountUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8c0a399e-6a77-4647-b441-32bfb0d0cef5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4859d00a-9527-4d5b-8807-ba49fe26a711"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"EventSubProcess10",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 310),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(371, 130),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSocialAccountCreationFailedEventStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("feef5120-f829-4bab-b62a-6316c0ab171d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8c0a399e-6a77-4647-b441-32bfb0d0cef5"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SocialAccountCreationFailedEvent",
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"SocialAccountCreationFailedEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask8ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a4552c0b-a158-41e5-8513-bbe057dbbc52"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8c0a399e-6a77-4647-b441-32bfb0d0cef5"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"ScriptTask8",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,74,44,78,245,77,45,46,6,178,3,18,243,82,115,244,28,83,82,160,124,141,226,146,162,204,188,116,61,215,220,130,146,74,29,133,224,252,228,204,196,28,191,212,146,242,252,162,108,199,210,146,12,183,196,204,156,84,152,98,29,5,40,35,164,178,32,85,47,60,177,40,15,168,85,211,154,171,40,181,164,180,40,79,161,164,168,52,213,26,0,192,212,58,35,113,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("096c4033-106a-42cf-9d6a-4de941144d57"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4859d00a-9527-4d5b-8807-ba49fe26a711"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"EventSubProcess9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 161),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(371, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSocialAccountCreatedSuccessfullyEventStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6bf85221-9968-45c0-bc1a-10dea7d9e6dd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("096c4033-106a-42cf-9d6a-4de941144d57"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SocialAccountCreatedSuccessfullyEvent",
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"SocialAccountCreatedSuccessfullyEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask7ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("24e0f74c-b8ac-4724-9f20-a7f0030c0c95"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("096c4033-106a-42cf-9d6a-4de941144d57"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"ScriptTask7",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,77,79,2,49,16,189,147,240,31,154,94,216,6,211,120,150,152,72,22,63,32,49,49,46,234,129,112,168,221,17,171,75,75,166,93,16,9,255,221,118,63,128,53,106,226,197,120,218,236,204,123,175,175,111,166,214,161,210,51,34,51,161,230,228,148,72,163,29,188,57,62,126,70,179,58,95,130,118,125,156,89,62,54,73,129,139,88,175,221,106,183,150,2,201,75,77,137,70,99,243,10,154,141,172,209,124,0,22,80,137,76,189,67,84,0,2,33,192,93,192,4,116,52,186,23,89,14,172,228,79,104,65,166,83,198,139,114,243,164,64,180,32,17,220,87,204,164,232,252,68,53,210,91,25,166,95,146,171,222,55,244,118,43,145,168,22,238,90,104,49,3,47,213,248,11,122,99,64,20,214,60,57,126,55,228,15,240,24,251,228,208,100,150,223,120,8,75,214,214,193,60,212,249,149,115,139,184,138,53,206,17,125,166,245,247,74,232,52,3,100,252,66,233,180,18,136,104,227,100,202,136,176,164,81,170,110,231,71,181,4,116,128,214,251,209,176,34,97,0,113,93,156,76,201,38,20,47,115,149,54,26,17,219,122,1,91,142,93,133,108,138,193,37,187,177,5,255,124,32,156,72,76,142,18,120,95,58,181,132,91,179,226,55,168,230,2,215,177,201,242,185,46,66,59,58,112,49,57,158,178,189,114,25,152,87,255,44,23,103,202,223,124,56,32,93,210,110,81,110,244,78,255,64,215,198,207,66,207,32,189,5,187,48,218,66,68,61,220,155,237,146,51,122,180,233,244,165,4,107,139,205,233,144,19,178,145,123,230,9,233,4,108,185,110,93,66,59,219,45,163,193,214,97,130,188,159,166,101,164,81,89,47,71,254,7,158,203,157,253,201,121,181,239,255,201,122,253,86,190,115,92,63,179,95,121,246,151,204,81,19,135,57,244,62,0,134,73,134,30,133,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("d50b5efd-7bc5-47fe-b5fe-2068b767eafb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("096c4033-106a-42cf-9d6a-4de941144d57"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(239, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8fccc841-f3b5-427c-92d9-9ca530bdc8aa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("49be16e3-da03-4008-8ccd-b6d5be010c7e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"EventSubProcess7",
				Position = new Point(456, 170),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateUserEditChangeStartMessage7StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("808d08e7-c671-4400-935e-1df334534701"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8fccc841-f3b5-427c-92d9-9ca530bdc8aa"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"UserEditChange",
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"UserEditChangeStartMessage7",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask5ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ab34580a-93e6-4e44-b408-15e0202c7369"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8fccc841-f3b5-427c-92d9-9ca530bdc8aa"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"),
				Name = @"ScriptTask5",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,211,80,12,72,76,79,213,11,45,78,45,114,77,201,44,209,243,200,76,73,73,205,211,84,168,230,226,204,76,83,208,40,46,41,202,204,75,215,243,44,246,43,205,201,241,47,114,205,45,40,169,212,64,213,17,146,90,81,162,9,214,192,9,150,8,40,77,202,201,76,118,206,72,77,206,118,202,175,208,115,205,75,76,202,73,77,81,176,85,72,75,204,41,78,181,198,161,12,204,0,43,43,41,42,5,169,170,85,72,5,42,39,194,88,152,122,174,90,46,174,162,212,146,210,162,60,136,16,0,125,125,84,176,220,0,0,0 }
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
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f5e1214-4f30-4d95-93a1-cfd95f7483ca"),
				Name = "Terrasoft.Social",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3d4ae9f6-71dd-45f7-b860-167715e547d1"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9c221783-b971-4868-9eff-321982ff78fa"),
				Name = "Terrasoft.Common.Json",
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
			return new SocialAccountEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bb273005-fbe5-418a-a617-c3cbc250e779"));
		}

		#endregion

	}

	#endregion

}

