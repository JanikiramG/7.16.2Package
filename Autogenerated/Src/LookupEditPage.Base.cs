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

	#region Class: LookupEditPageSchema

	/// <exclude/>
	public class LookupEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TextEdit _nameEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return _nameEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _sysEntityShemaEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit SysEntityShemaEdit {
			get {
				return _sysEntityShemaEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _sysGridPageSchemaEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit SysGridPageSchemaEdit {
			get {
				return _sysGridPageSchemaEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _sysEditPageSchemaEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit SysEditPageSchemaEdit {
			get {
				return _sysEditPageSchemaEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MemoEdit _descriptionEdit;
		public Terrasoft.UI.WebControls.Controls.MemoEdit DescriptionEdit {
			get {
				return _descriptionEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _isSimpleCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox IsSimpleCheckBox {
			get {
				return _isSimpleCheckBox;
			}
		}

		#endregion

		#region Constructors: Public

		public LookupEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public LookupEditPageSchema(LookupEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
			RealUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
			Name = "LookupEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 405;
			HelpContextId = "272";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLookupEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(0, CreateNameEdit());
			MainControlLayout.InsertItem(1, CreateSysEntityShemaEdit());
			MainControlLayout.InsertItem(2, CreateSysGridPageSchemaEdit());
			MainControlLayout.InsertItem(3, CreateSysEditPageSchemaEdit());
			MainControlLayout.InsertItem(4, CreateDescriptionEdit());
			MainControlLayout.InsertItem(5, CreateIsSimpleCheckBox());
			MainControlLayout.MoveItem(6, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateLookupEditPageEventsProcessSchema() {
			var schema = new LookupEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateNameEdit() {
			_nameEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_nameEdit.UId = new Guid("fa581585-2a41-44c9-ab5b-46f466772d6b");
			_nameEdit.Name = "NameEdit";
			_nameEdit.CreatedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
			_nameEdit.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
			_nameEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_nameEdit.Tag = "";
			_nameEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_nameEdit.Image = new ControlImage {};
			_nameEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_nameEdit.DataSource = "DataSource";
			_nameEdit.ColumnUId = new Guid("09f32378-386c-476b-9218-1d6e6dcc5e10");
			return _nameEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateSysEntityShemaEdit() {
			_sysEntityShemaEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_sysEntityShemaEdit.UId = new Guid("238ff92e-3632-4366-ae35-59e4a9fd0914");
			_sysEntityShemaEdit.Name = "SysEntityShemaEdit";
			_sysEntityShemaEdit.CreatedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
			_sysEntityShemaEdit.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
			_sysEntityShemaEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sysEntityShemaEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_sysEntityShemaEdit.Tag = "";
			_sysEntityShemaEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sysEntityShemaEdit.Image = new ControlImage {};
			_sysEntityShemaEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_sysEntityShemaEdit.Required = true;
			return _sysEntityShemaEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateSysGridPageSchemaEdit() {
			_sysGridPageSchemaEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_sysGridPageSchemaEdit.UId = new Guid("3184b04a-a65e-4501-a7aa-16b7b822d4e8");
			_sysGridPageSchemaEdit.Name = "SysGridPageSchemaEdit";
			_sysGridPageSchemaEdit.CreatedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
			_sysGridPageSchemaEdit.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
			_sysGridPageSchemaEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sysGridPageSchemaEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_sysGridPageSchemaEdit.Tag = "";
			_sysGridPageSchemaEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sysGridPageSchemaEdit.Image = new ControlImage {};
			_sysGridPageSchemaEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _sysGridPageSchemaEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateSysEditPageSchemaEdit() {
			_sysEditPageSchemaEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_sysEditPageSchemaEdit.UId = new Guid("d88e25e5-7796-45da-b565-e8b3dc6fd321");
			_sysEditPageSchemaEdit.Name = "SysEditPageSchemaEdit";
			_sysEditPageSchemaEdit.CreatedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
			_sysEditPageSchemaEdit.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
			_sysEditPageSchemaEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sysEditPageSchemaEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_sysEditPageSchemaEdit.Tag = "";
			_sysEditPageSchemaEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sysEditPageSchemaEdit.Image = new ControlImage {};
			_sysEditPageSchemaEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _sysEditPageSchemaEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MemoEdit CreateDescriptionEdit() {
			_descriptionEdit = new Terrasoft.UI.WebControls.Controls.MemoEdit();
			_descriptionEdit.UId = new Guid("6ece6e97-2744-4df0-b819-2d481373c0b7");
			_descriptionEdit.Name = "DescriptionEdit";
			_descriptionEdit.CreatedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
			_descriptionEdit.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
			_descriptionEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_descriptionEdit.Tag = "";
			_descriptionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_descriptionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_descriptionEdit.CaptionVerticalAlign = Terrasoft.UI.WebControls.VerticalAlign.Middle;
			_descriptionEdit.DataSource = "DataSource";
			_descriptionEdit.ColumnUId = new Guid("4e7e326d-acda-4ef3-81b1-47cddbd5f242");
			return _descriptionEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsSimpleCheckBox() {
			_isSimpleCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isSimpleCheckBox.UId = new Guid("bde57fc9-2665-4553-97f7-7cf385eab9dc");
			_isSimpleCheckBox.Name = "IsSimpleCheckBox";
			_isSimpleCheckBox.CreatedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
			_isSimpleCheckBox.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
			_isSimpleCheckBox.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_isSimpleCheckBox.Tag = "";
			_isSimpleCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isSimpleCheckBox.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isSimpleCheckBox.CaptionPosition = Terrasoft.UI.WebControls.Controls.CheckBoxBaseCaptionPosition.Left;
			_isSimpleCheckBox.DataSource = "DataSource";
			_isSimpleCheckBox.ColumnUId = new Guid("38174ce3-0cbe-47a1-ac81-442401bbd84f");
			return _isSimpleCheckBox;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("ffee71d2-1485-4c86-9cdb-3d74ea091dd1");
			DataSource.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("98f4cba2-0cba-4db2-938e-c66dbc9f700e");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("9031b174-f3b0-459f-b445-9131e05c8bc0");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("1f3a5255-c1ed-4d9b-9b7c-fef290e96670");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("faed7b72-4bbd-42db-82db-e6d80e48bd73");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("0484f374-19ac-4dba-9e3f-5e280b86ba6c");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("09f32378-386c-476b-9218-1d6e6dcc5e10");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("4e7e326d-acda-4ef3-81b1-47cddbd5f242");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9ac36be4-1445-4efb-9045-587e6bb8e227");
			if (column != null) {
				column.UId = new Guid("e7d1e0d6-e7c4-4e47-bd01-df95e96af677");
				column.Name = @"SysFolder";
				column.CreatedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("d7bd7486-d06d-4fb1-b256-4d2fa88e88c9");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("2d6de8c4-3d7f-4a80-84f2-d4a29ede4103");
			if (column != null) {
				column.UId = new Guid("38174ce3-0cbe-47a1-ac81-442401bbd84f");
				column.Name = @"IsSimple";
				column.CreatedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("599a1372-11a5-4327-a342-072bdbb4b38e");
			if (column != null) {
				column.UId = new Guid("ab95130d-8bb4-47f3-b1a9-4d4be7762595");
				column.Name = @"IsSystem";
				column.CreatedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("d2f7d553-0292-4a39-bb17-6f6ba26a3ae1");
			if (column != null) {
				column.UId = new Guid("b6de12a8-7fa1-4809-b79f-9702a6360e19");
				column.Name = @"SysWorkspace";
				column.CreatedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("7c81b883-a2fd-4152-af5a-b30c128aefb0");
			if (column != null) {
				column.UId = new Guid("09a9fb01-ce07-40e2-8ef2-bbd83fb4868d");
				column.Name = @"SysEditPageSchemaUId";
				column.CreatedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9290f7c4-590b-4a35-8e87-61685eb8752e");
			if (column != null) {
				column.UId = new Guid("6e15bc22-63a1-4070-b2bf-918a4526ca83");
				column.Name = @"SysGridPageSchemaU";
				column.CreatedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("d50e7964-0111-4cad-8cc3-eae56078533e");
			if (column != null) {
				column.UId = new Guid("eb953b77-89d7-4c16-958d-a7f0fb04d9bd");
				column.Name = @"SysEntitySchemaU";
				column.CreatedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
				column.ModifiedInSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
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
			return new LookupEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new LookupEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new LookupEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: LookupEditPageEventsProcess

	/// <exclude/>
	public class LookupEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.LookupEditPageSchemaUserControl
	{

		#region Class: SaveToNoRootQuestionUserTaskFlowElement

		/// <exclude/>
		public class SaveToNoRootQuestionUserTaskFlowElement : QuestionUserTask
		{

			public SaveToNoRootQuestionUserTaskFlowElement(UserConnection userConnection, LookupEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SaveToNoRootQuestionUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("a71b7660-fb10-40be-b7b7-7f41bd6923e4");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public LookupEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LookupEditPageEventsProcess";
			SchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
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

		private bool _isCorrectSchema = true;
		public bool IsCorrectSchema {
			get {
				return _isCorrectSchema;
			}
			set {
				_isCorrectSchema = value;
			}
		}

		private ProcessFlowElement _initSubProcess;
		public ProcessFlowElement InitSubProcess {
			get {
				return _initSubProcess ?? (_initSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "InitSubProcess",
					SchemaElementUId = new Guid("f934d81b-cbe3-4c97-830f-c4fff16df289"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _init;
		public ProcessFlowElement Init {
			get {
				return _init ?? (_init = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "Init",
					SchemaElementUId = new Guid("43f52a44-1afa-411c-9f2d-fab4e0497a9c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptInit;
		public ProcessScriptTask ScriptInit {
			get {
				return _scriptInit ?? (_scriptInit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptInit",
					SchemaElementUId = new Guid("6c5691b8-f183-4da7-8043-daebecb2702f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptInitExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessChildPageLoadComplete;
		public ProcessFlowElement SubProcessChildPageLoadComplete {
			get {
				return _subProcessChildPageLoadComplete ?? (_subProcessChildPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessChildPageLoadComplete",
					SchemaElementUId = new Guid("89e28c23-eec6-4150-a527-054268c8d6e2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageChildPageLoadComplete;
		public ProcessFlowElement StartMessageChildPageLoadComplete {
			get {
				return _startMessageChildPageLoadComplete ?? (_startMessageChildPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChildPageLoadComplete",
					SchemaElementUId = new Guid("9dfe7af6-7f29-4b1f-b175-ca4395a25178"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptChildPageLoadComplete;
		public ProcessScriptTask ScriptChildPageLoadComplete {
			get {
				return _scriptChildPageLoadComplete ?? (_scriptChildPageLoadComplete = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildPageLoadComplete",
					SchemaElementUId = new Guid("809013e0-9477-4318-b342-5ededd58c304"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildPageLoadCompleteExecute,
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
					SchemaElementUId = new Guid("3f20f388-ca78-47a7-941b-a1857af1459b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _savingNoRootFolderLookupStartMessage;
		public ProcessFlowElement SavingNoRootFolderLookupStartMessage {
			get {
				return _savingNoRootFolderLookupStartMessage ?? (_savingNoRootFolderLookupStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SavingNoRootFolderLookupStartMessage",
					SchemaElementUId = new Guid("3d171100-037d-43bd-8fa0-ab19c321cc28"),
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
					SchemaElementUId = new Guid("e0e70895-3d30-46c6-99ed-aba15ffc01bb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private SaveToNoRootQuestionUserTaskFlowElement _saveToNoRootQuestionUserTask;
		public SaveToNoRootQuestionUserTaskFlowElement SaveToNoRootQuestionUserTask {
			get {
				return _saveToNoRootQuestionUserTask ?? (_saveToNoRootQuestionUserTask = new SaveToNoRootQuestionUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("ecaf01de-1599-4f34-813a-89d5a10760da"),
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
					SchemaElementUId = new Guid("e243734c-37c0-4b7c-8050-566d22b6911d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
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
					SchemaElementUId = new Guid("13f1bcc9-4e27-4233-b608-17a1b3a0a38c"),
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
					SchemaElementUId = new Guid("cf07a18f-70c9-46ec-b232-7ed191a879c6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3Execute,
				});
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
					SchemaElementUId = new Guid("030603bd-6b7c-402d-83e4-2e993375cc56"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysEntityShemaEditChangeMessage;
		public ProcessFlowElement SysEntityShemaEditChangeMessage {
			get {
				return _sysEntityShemaEditChangeMessage ?? (_sysEntityShemaEditChangeMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysEntityShemaEditChangeMessage",
					SchemaElementUId = new Guid("e46445ed-70db-4bfa-96de-f48c1799011e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _sysEntityShemaEditChangeScript;
		public ProcessScriptTask SysEntityShemaEditChangeScript {
			get {
				return _sysEntityShemaEditChangeScript ?? (_sysEntityShemaEditChangeScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SysEntityShemaEditChangeScript",
					SchemaElementUId = new Guid("6d958648-9c0d-4b94-b203-0f410aecfd52"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SysEntityShemaEditChangeScriptExecute,
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
					SchemaElementUId = new Guid("feb2e79b-169e-484e-aff4-319319bbd5fe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysEditPageSchemaEditChangeMessage;
		public ProcessFlowElement SysEditPageSchemaEditChangeMessage {
			get {
				return _sysEditPageSchemaEditChangeMessage ?? (_sysEditPageSchemaEditChangeMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysEditPageSchemaEditChangeMessage",
					SchemaElementUId = new Guid("e1e477c4-7672-44f6-9244-e3cb37605258"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _sysEditPageSchemaEditChangeScriptTask;
		public ProcessScriptTask SysEditPageSchemaEditChangeScriptTask {
			get {
				return _sysEditPageSchemaEditChangeScriptTask ?? (_sysEditPageSchemaEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SysEditPageSchemaEditChangeScriptTask",
					SchemaElementUId = new Guid("0de342cd-ceab-4e18-ae4b-6d973dc69976"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SysEditPageSchemaEditChangeScriptTaskExecute,
				});
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
					SchemaElementUId = new Guid("a96d73b5-4bed-4dbb-b972-43fb75fe6c30"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysGridPageSchemaEditChangeMessage;
		public ProcessFlowElement SysGridPageSchemaEditChangeMessage {
			get {
				return _sysGridPageSchemaEditChangeMessage ?? (_sysGridPageSchemaEditChangeMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysGridPageSchemaEditChangeMessage",
					SchemaElementUId = new Guid("786045f5-2732-4ec0-b84b-ed30390e7c20"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _sysGridPageSchemaEditChangeScriptTask;
		public ProcessScriptTask SysGridPageSchemaEditChangeScriptTask {
			get {
				return _sysGridPageSchemaEditChangeScriptTask ?? (_sysGridPageSchemaEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SysGridPageSchemaEditChangeScriptTask",
					SchemaElementUId = new Guid("0f16bbb8-12c3-47b9-b4d0-f7db3af3c6b0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SysGridPageSchemaEditChangeScriptTaskExecute,
				});
			}
		}

		private LocalizableString _lookupCaption;
		public LocalizableString LookupCaption {
			get {
				return _lookupCaption ?? (_lookupCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.LookupCaption.Value"));
			}
		}

		private LocalizableString _saveToNoRootQuestion;
		public LocalizableString SaveToNoRootQuestion {
			get {
				return _saveToNoRootQuestion ?? (_saveToNoRootQuestion = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SaveToNoRootQuestion.Value"));
			}
		}

		private LocalizableString _schemaNotCorrectMessage;
		public LocalizableString SchemaNotCorrectMessage {
			get {
				return _schemaNotCorrectMessage ?? (_schemaNotCorrectMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SchemaNotCorrectMessage.Value"));
			}
		}

		private LocalizableString _schemaNotCorrectCaption;
		public LocalizableString SchemaNotCorrectCaption {
			get {
				return _schemaNotCorrectCaption ?? (_schemaNotCorrectCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SchemaNotCorrectCaption.Value"));
			}
		}

		private LocalizableString _schemaIsSystem;
		public LocalizableString SchemaIsSystem {
			get {
				return _schemaIsSystem ?? (_schemaIsSystem = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SchemaIsSystem.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[InitSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { InitSubProcess };
			FlowElements[Init.SchemaElementUId] = new Collection<ProcessFlowElement> { Init };
			FlowElements[ScriptInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptInit };
			FlowElements[SubProcessChildPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessChildPageLoadComplete };
			FlowElements[StartMessageChildPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChildPageLoadComplete };
			FlowElements[ScriptChildPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildPageLoadComplete };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[SavingNoRootFolderLookupStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SavingNoRootFolderLookupStartMessage };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[SaveToNoRootQuestionUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveToNoRootQuestionUserTask };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[ScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3 };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[SysEntityShemaEditChangeMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SysEntityShemaEditChangeMessage };
			FlowElements[SysEntityShemaEditChangeScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SysEntityShemaEditChangeScript };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[SysEditPageSchemaEditChangeMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SysEditPageSchemaEditChangeMessage };
			FlowElements[SysEditPageSchemaEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SysEditPageSchemaEditChangeScriptTask };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[SysGridPageSchemaEditChangeMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SysGridPageSchemaEditChangeMessage };
			FlowElements[SysGridPageSchemaEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SysGridPageSchemaEditChangeScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "InitSubProcess":
						break;
					case "Init":
						e.Context.QueueTasks.Enqueue("ScriptInit");
						break;
					case "ScriptInit":
						break;
					case "SubProcessChildPageLoadComplete":
						break;
					case "StartMessageChildPageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptChildPageLoadComplete");
						break;
					case "ScriptChildPageLoadComplete":
						break;
					case "EventSubProcess4":
						break;
					case "SavingNoRootFolderLookupStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						e.Context.QueueTasks.Enqueue("SaveToNoRootQuestionUserTask");
						break;
					case "SaveToNoRootQuestionUserTask":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "ScriptTask2":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("ScriptTask3");
						break;
					case "ScriptTask3":
						break;
					case "EventSubProcess1":
						break;
					case "SysEntityShemaEditChangeMessage":
						e.Context.QueueTasks.Enqueue("SysEntityShemaEditChangeScript");
						break;
					case "SysEntityShemaEditChangeScript":
						break;
					case "EventSubProcess2":
						break;
					case "SysEditPageSchemaEditChangeMessage":
						e.Context.QueueTasks.Enqueue("SysEditPageSchemaEditChangeScriptTask");
						break;
					case "SysEditPageSchemaEditChangeScriptTask":
						break;
					case "EventSubProcess3":
						break;
					case "SysGridPageSchemaEditChangeMessage":
						e.Context.QueueTasks.Enqueue("SysGridPageSchemaEditChangeScriptTask");
						break;
					case "SysGridPageSchemaEditChangeScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("Init");
			ActivatedEventElements.Add("StartMessageChildPageLoadComplete");
			ActivatedEventElements.Add("SavingNoRootFolderLookupStartMessage");
			ActivatedEventElements.Add("StartMessage1");
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("SysEntityShemaEditChangeMessage");
			ActivatedEventElements.Add("SysEditPageSchemaEditChangeMessage");
			ActivatedEventElements.Add("SysGridPageSchemaEditChangeMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "InitSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "Init":
					context.QueueTasks.Dequeue();
					context.SenderName = "Init";
					result = Init.Execute(context);
					break;
				case "ScriptInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptInit";
					result = ScriptInit.Execute(context, ScriptInitExecute);
					break;
				case "SubProcessChildPageLoadComplete":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageChildPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChildPageLoadComplete";
					result = StartMessageChildPageLoadComplete.Execute(context);
					break;
				case "ScriptChildPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildPageLoadComplete";
					result = ScriptChildPageLoadComplete.Execute(context, ScriptChildPageLoadCompleteExecute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "SavingNoRootFolderLookupStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SavingNoRootFolderLookupStartMessage";
					result = SavingNoRootFolderLookupStartMessage.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "SaveToNoRootQuestionUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SaveToNoRootQuestionUserTask";
					result = SaveToNoRootQuestionUserTask.Execute(context);
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "ScriptTask3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3";
					result = ScriptTask3.Execute(context, ScriptTask3Execute);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "SysEntityShemaEditChangeMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysEntityShemaEditChangeMessage";
					result = SysEntityShemaEditChangeMessage.Execute(context);
					break;
				case "SysEntityShemaEditChangeScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysEntityShemaEditChangeScript";
					result = SysEntityShemaEditChangeScript.Execute(context, SysEntityShemaEditChangeScriptExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "SysEditPageSchemaEditChangeMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysEditPageSchemaEditChangeMessage";
					result = SysEditPageSchemaEditChangeMessage.Execute(context);
					break;
				case "SysEditPageSchemaEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysEditPageSchemaEditChangeScriptTask";
					result = SysEditPageSchemaEditChangeScriptTask.Execute(context, SysEditPageSchemaEditChangeScriptTaskExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "SysGridPageSchemaEditChangeMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysGridPageSchemaEditChangeMessage";
					result = SysGridPageSchemaEditChangeMessage.Execute(context);
					break;
				case "SysGridPageSchemaEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysGridPageSchemaEditChangeScriptTask";
					result = SysGridPageSchemaEditChangeScriptTask.Execute(context, SysGridPageSchemaEditChangeScriptTaskExecute);
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
				case "IsCorrectSchema":
					IsCorrectSchema = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptInitExecute(ProcessExecutingContext context) {
			CreateFilterForLookup();
			return true;
		}

		public virtual bool ScriptChildPageLoadCompleteExecute(ProcessExecutingContext context) {
			var recordId = new Guid(Page.GetParameterValue("recordId").ToString());
			if(recordId.IsEmpty()) IsNew = true;
			else IsNew = false;
			//Код, который компилируется только в Workspace CR173850 VwSysSchemaInWorkspace "4FE60977-C711-48B2-8499-1CEBBECF7868"
			var VwSysSchemaInWorkspace = new Guid("4FE60977-C711-48B2-8499-1CEBBECF7868");
			Page.SysEntityShemaEdit.LookupSchemaUId = VwSysSchemaInWorkspace;
			Page.SysGridPageSchemaEdit.LookupSchemaUId = VwSysSchemaInWorkspace;
			Page.SysEditPageSchemaEdit.LookupSchemaUId = VwSysSchemaInWorkspace;
			
			var dataSource = Page.DataSource;
			string queryString = Page.Request.QueryString.ToString();
			if (queryString.Contains("recordId")) {
				EntityPrimaryColumnValue = new Guid(Page.Request.QueryString["recordId"].ToString());
			}
			var folderId = Guid.Empty;
			if (queryString.Contains("folderId")) {
				folderId = new Guid(Page.Request.QueryString["folderId"].ToString());
			}
			bool isNewRecord = EntityPrimaryColumnValue.Equals(Guid.Empty);
			bool isCopy = queryString.Contains("Copy");
			string primaryColumnName = dataSource.Schema.PrimaryColumn.Name;
			if (dataSource.CurrentStructure.Columns.Count == 0) {
				EntityDataSourceUtilities.InitializeAutoDefStructure(dataSource as EntityDataSource);
			}
			
			if (isNewRecord) {
				var row = dataSource.CreateRow();
				EntityPrimaryColumnValue = new Guid(row.GetColumnValue(primaryColumnName).ToString());
				row.SetColumnValue("SysFolderId",folderId);
				
			//Код, который компилируется только в Workspace CR172707 
				//CR172711 [VwSysLookup] not contain column "SysWorkspaceId"
				row.SetColumnValue("SysWorkspaceId",Page.UserConnection.Workspace.Id);
				
				if (queryString.Contains("defValuesId")) {
					string defValuesId = Page.Request.QueryString["defValuesId"].ToString();
					var defValues = Page.UserConnection.SessionData[defValuesId] as Dictionary<string, object>;
					var columnNames = new List<string>();
					foreach(var value in defValues) {
						row.SetColumnValue(row.Schema.Columns.GetByName(value.Key).ColumnValueName, value.Value);
						columnNames.Add(value.Key);
					}
					row.LoadLookupDisplayValues(columnNames);
				}
			
				dataSource.Insert(row);
			}
			else {
				foreach(var filter in dataSource.CurrentStructure.Filters) {	
					dataSource.CurrentStructure.Filters.Remove(filter.UId);
				}
				dataSource.CurrentStructure.Filters.Add(dataSource.CreateFilterWithParameters(FilterComparisonType.Equal,
					primaryColumnName, EntityPrimaryColumnValue));
				if (dataSource.CurrentStructure.IsHierarchical) {
					Terrasoft.Core.Entities.EntitySchemaColumn hierarchyColumn = (dataSource.Schema.HierarchyColumn.Clone() as Terrasoft.Core.Entities.EntitySchemaColumn);
					dataSource.CurrentStructure.IsHierarchical = false;
					dataSource.LoadRows();
					dataSource.Schema.HierarchyColumn = hierarchyColumn as Terrasoft.Core.Entities.EntitySchemaColumn;
				} else {
					dataSource.LoadRows();
				}
				if (isCopy) {
					var row = dataSource.Rows[0].Clone() as Terrasoft.Core.Entities.Entity;
					Guid currentUserContactId = Page.UserConnection.CurrentUser.ContactId;
					EntityPrimaryColumnValue = Guid.NewGuid();
					row.SetColumnValue(primaryColumnName, EntityPrimaryColumnValue);
					row.SetColumnValue("CreatedOn", DateTime.Now);
					row.SetColumnValue("CreatedById", currentUserContactId);
					row.SetColumnValue("ModifiedOn", DateTime.Now);
					row.SetColumnValue("ModifiedById", currentUserContactId);
					dataSource.Insert(row);
				}
				var editsValues = new Dictionary<string,Guid> {
								{"SysEntitySchemaUId",dataSource.Rows[0].GetTypedColumnValue<Guid>("SysEntitySchemaUId")},
								{"SysGridPageSchemaUId",dataSource.Rows[0].GetTypedColumnValue<Guid>("SysGridPageSchemaUId")},
								{"SysEditPageSchemaUId",dataSource.Rows[0].GetTypedColumnValue<Guid>("SysEditPageSchemaUId")}
							};
				foreach(var editsValue in editsValues )
				{
			//Код, который компилируется только в Workspace CR173850 VwSysSchemaInWorkspace "4FE60977-C711-48B2-8499-1CEBBECF7868"
					var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "VwSysSchemaInWorkspace");
					esq.AddAllSchemaColumns();
					var filter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "UId", editsValue.Value);
					esq.Filters.Add(filter);
					filter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "SysWorkspace.Id", UserConnection.Workspace.Id);
					esq.Filters.Add(filter);
					var entities = esq.GetEntityCollection(UserConnection);
			
					if (entities != null && entities.Count > 0) {
						if(editsValue.Key == "SysEntitySchemaUId")
							Page.SysEntityShemaEdit.SetValueAndText(entities[0].GetTypedColumnValue<Guid>("UId"), entities[0].GetTypedColumnValue<string>("Caption"));
						else if(editsValue.Key == "SysGridPageSchemaUId")
							Page.SysGridPageSchemaEdit.SetValueAndText(entities[0].GetTypedColumnValue<Guid>("UId"), entities[0].GetTypedColumnValue<string>("Caption"));
						else if(editsValue.Key == "SysEditPageSchemaUId")
							Page.SysEditPageSchemaEdit.SetValueAndText(entities[0].GetTypedColumnValue<Guid>("UId"), entities[0].GetTypedColumnValue<string>("Caption"));
					}
				}
			}
			dataSource.SetClientActiveRow(EntityPrimaryColumnValue);
			MakeCaption();
			InitializeContextHelpButton();
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			SaveToNoRootQuestionUserTask.Page = Page;
			SaveToNoRootQuestionUserTask.MessageText = SaveToNoRootQuestion;
			SaveToNoRootQuestionUserTask.Icon = "QUESTION";
			SaveToNoRootQuestionUserTask.Buttons = "YESNO";
			SaveToNoRootQuestionUserTask.ResponseMessages = new Dictionary<string, string> {
			   {"yes", "YesSaveToCurrentGroupAnswer"},
			   {"no", "NoSaveToCurrentGroupAnswer"},
			};
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			SaveEditPageData();
			return true;
		}

		public virtual bool ScriptTask3Execute(ProcessExecutingContext context) {
			SetRootFolderForCurrentRow();
			SaveEditPageData();
			return true;
		}

		public virtual bool SysEntityShemaEditChangeScriptExecute(ProcessExecutingContext context) {
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var sysSchemaInWorkspaceESQ  = new EntitySchemaQuery (entitySchemaManager, "VwSysSchemaInWorkspace");
			sysSchemaInWorkspaceESQ.PrimaryQueryColumn.IsAlwaysSelect = true;
			sysSchemaInWorkspaceESQ.AddColumn("UId");
			var sysSchemaInWorkspaceEntity = sysSchemaInWorkspaceESQ.GetEntity(UserConnection, Page.SysEntityShemaEdit.Value);
			var sysSchemaId = sysSchemaInWorkspaceEntity.GetTypedColumnValue<Guid>("UId"); 
			Page.ScriptManager.AddScript(string.Format("{0}.setColumnValue('SysEntitySchemaUId', '{1}'); ",
				Page.DataSource.ClientID,sysSchemaId));
			
			var entityTableESQ = UserConnection.EntitySchemaManager.GetInstanceByUId(sysSchemaId);
			Page.BaseMessagePanel.Clear();
			IsCorrectSchema = true;
			if(entityTableESQ.PrimaryDisplayColumn == null){
				Page.BaseMessagePanel.AddMessage(SchemaNotCorrectCaption, SchemaNotCorrectMessage, MessageType.Warning);
				IsCorrectSchema = false;
			}
			var sysLookupESQ  = new EntitySchemaQuery (entitySchemaManager, "SysLookup");
			sysLookupESQ.AddColumn("Id");
			sysLookupESQ.Filters.Add(sysLookupESQ.CreateFilterWithParameters(FilterComparisonType.Equal, "SysEntitySchemaUId", 
			sysSchemaId));
			sysLookupESQ.Filters.Add(sysLookupESQ.CreateFilterWithParameters(FilterComparisonType.Equal, "IsSystem", 
			true));
			var sysLookupCollection = sysLookupESQ.GetEntityCollection(UserConnection);
			if (sysLookupCollection.Count > 0) {
				Page.BaseMessagePanel.AddMessage(SchemaNotCorrectCaption, SchemaIsSystem, MessageType.Warning);
				IsCorrectSchema = false;
			}
			
			return true;
		}

		public virtual bool SysEditPageSchemaEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			var schemaId = Page.SysEditPageSchemaEdit.Value.ToString();
			var sysSchemaInWorkspaceESQ  = new EntitySchemaQuery (UserConnection.EntitySchemaManager, "VwSysSchemaInWorkspace");
			sysSchemaInWorkspaceESQ.PrimaryQueryColumn.IsAlwaysSelect = true;
			sysSchemaInWorkspaceESQ.AddColumn("UId");
			var sysSchemaInWorkspaceEntity = sysSchemaInWorkspaceESQ.GetEntity(UserConnection, schemaId);
			var sysSchemaUId = sysSchemaInWorkspaceEntity.GetTypedColumnValue<Guid>("UId"); 
			
			if(!string.IsNullOrEmpty(sysSchemaUId.ToString()) && new Guid(sysSchemaUId.ToString()) != Guid.Empty){
				Page.ScriptManager.AddScript(string.Format("{0}.setColumnValue('SysEditPageSchemaUId', '{1}'); ",
					Page.DataSource.ClientID,sysSchemaUId));
			}
			return true;
		}

		public virtual bool SysGridPageSchemaEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			var schemaId = Page.SysGridPageSchemaEdit.Value.ToString();
			var sysSchemaInWorkspaceESQ  = new EntitySchemaQuery (UserConnection.EntitySchemaManager, "VwSysSchemaInWorkspace");
			sysSchemaInWorkspaceESQ.PrimaryQueryColumn.IsAlwaysSelect = true;
			sysSchemaInWorkspaceESQ.AddColumn("UId");
			var sysSchemaInWorkspaceEntity = sysSchemaInWorkspaceESQ.GetEntity(UserConnection, schemaId);
			var sysSchemaUId = Guid.Empty;
			if (sysSchemaInWorkspaceEntity != null){
				sysSchemaUId = sysSchemaInWorkspaceEntity.GetTypedColumnValue<Guid>("UId"); 
			}
			
			if(!string.IsNullOrEmpty(sysSchemaUId.ToString()) && new Guid(sysSchemaUId.ToString()) != Guid.Empty){
				Page.ScriptManager.AddScript(string.Format("{0}.setColumnValue('SysGridPageSchemaUId', '{1}'); ",
					Page.DataSource.ClientID,sysSchemaUId));
			}
			else{
				Page.ScriptManager.AddScript(string.Format("{0}.setColumnValue('SysGridPageSchemaUId', '{1}'); ",
					Page.DataSource.ClientID,null));
			}
				
			return true;
		}

		public override bool AreConditionsCorrect(Entity row) {
			MessagePanel panel = Page.BaseMessagePanel;
			
			if (!IsCorrectSchema && !panel.HasMessage(SchemaNotCorrectCaption)) {
				panel.AddMessage(SchemaNotCorrectCaption, SchemaNotCorrectMessage , MessageType.Warning);
			}
			return IsCorrectSchema;
		}

		public override void MakeCaption() {
			if(IsCaptionExists) {
				return;
			}
			var columnName = Page.DataSource.Schema.FindPrimaryDisplayColumnName();
			var primaryDisplayColumnName = String.Empty;
			if(string.IsNullOrEmpty(columnName)) {
				primaryDisplayColumnName = EditingRecordCaption;
			} else {
				primaryDisplayColumnName = columnName;
			}
			// var caption = Page.DataSource.Schema.Caption;
			var caption = LookupCaption;
			var recordId = new Guid(Page.GetParameterValue("recordId").ToString());
			caption = (recordId.IsEmpty() || Convert.ToBoolean(Page.GetParameterValue("Copy"))) ?  string.Format("{0} ({1})", caption, NewRecordCaption) 
				: string.Format("{0} ({1})", caption, Page.DataSource.Rows[0].GetTypedColumnValue<string>(columnName));
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = caption;
		}

		public override void OkClickMethod() {
			if(IsNew) {	
				var isSelectedFolderRoot = false;
				if (Page.Request.QueryString.ToString().Contains("folderId")) {
					var folderId = new Guid(Page.Request.QueryString["folderId"]);
					isSelectedFolderRoot = (folderId == new Guid("09bacff2-34e0-df11-971b-001d60e938c6"));
				}
				if(isSelectedFolderRoot) {
					SaveEditPageData();
				} else {
					Page.ThrowEvent("SavingNoRootFolderLookup");
				}
			} else {
				SaveEditPageData();
			}
		}

		public virtual void CreateLookupColumns() {
			var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			//Код, который компилируется только в Workspace CR172707
			var lookupEntitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "VwSysSchemaInWorkspace");
			var lookupIdColumn = lookupEntitySchemaQuery.AddColumn("UId");
			
			lookupEntitySchemaQuery.Filters.Add(lookupEntitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
															"UId", (Guid)Page.SysEntityShemaEdit.Value));
			var lookupEntities = lookupEntitySchemaQuery.GetEntityCollection(UserConnection);
			var schemaId = lookupEntities[0].GetTypedColumnValue<Guid>(lookupIdColumn.Name);
			
			EntitySchema lookupSchema = entitySchemaManager.GetInstanceByUId(schemaId); //, UserConnection.CurrentUser.Id
			foreach(var column in lookupSchema.Columns){
				if(IsNew || Convert.ToBoolean(Page.GetParameterValue("Copy"))){		
					EntitySchema lookupColumnSchema = entitySchemaManager.GetInstanceByName("SysLookupColumn");
					Entity lookupColumn = lookupColumnSchema.CreateEntity(Page.UserConnection);
					lookupColumn.SetColumnValue("Id", Guid.NewGuid());
					lookupColumn.SetColumnValue("SysLookupId", Page.SysEntityShemaEdit.Value);
					lookupColumn.SetColumnValue("MetaPath", column.UId);
					lookupColumn.SetColumnValue("Position", 0);
					lookupColumn.SetColumnValue("Width", 100);
					lookupColumn.SetColumnValue("SysOrderDirectionId", "91e2cce1-6f51-4afd-bfd9-dc786bd7e666");
					lookupColumn.SetColumnValue("MetaCaption", column.Name);
					lookupColumn.Save();
				}
			}
		}

		public virtual void CreateFilterForLookup() {
			Guid sysWorkspaceId = Page.UserConnection.Workspace.Id;
			var pageSchemaManager  = UserConnection.GetSchemaManager("PageSchemaManager") as PageSchemaManager; 
			var entitySchemaManager  = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager; 
			
			Page.SysEntityShemaEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
				Collection<Dictionary<string, object>> filters = e.Filters;
				filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.Equal}, 
					{"leftExpressionColumnPath", "SysWorkspace"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {sysWorkspaceId}}});
				filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.Equal}, 
					{"leftExpressionColumnPath", "ManagerName"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {entitySchemaManager.Name}}});
				filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.Equal}, 
					{"leftExpressionColumnPath", "ExtendParent"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {false}}});
			};
			
			Page.SysGridPageSchemaEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
				Collection<Dictionary<string, object>> filters = e.Filters;
				filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.Equal}, 
					{"leftExpressionColumnPath", "SysWorkspace"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {sysWorkspaceId}}});
				filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.Equal}, 
					{"leftExpressionColumnPath", "ManagerName"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {pageSchemaManager.Name}}});
			};
			
			Page.SysEditPageSchemaEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
				Collection<Dictionary<string, object>> filters = e.Filters;
				filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.Equal}, 
					{"leftExpressionColumnPath", "SysWorkspace"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {sysWorkspaceId}}});
				filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.Equal}, 
					{"leftExpressionColumnPath", "ManagerName"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {pageSchemaManager.Name}}});
			};
		}

		public virtual void SaveEditPageData() {
			Page.ScriptManager.AddScript(
				"if (" + Page.DataSource.ClientID + ".activeRow.modified) {" 		
					+ Page.DataSource.ClientID + ".save(); " + 
				"} else { window.close(); }"
			);
			//CreateLookupColumns();
		}

		public virtual void SetRootFolderForCurrentRow() {
			Page.ScriptManager.AddScript(
				Page.DataSource.ClientID + ".setColumnValue('SysFolderId', '09bacff2-34e0-df11-971b-001d60e938c6'); "
			);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("Init")) {
							context.QueueTasks.Enqueue("Init");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessageChildPageLoadComplete")) {
							context.QueueTasks.Enqueue("StartMessageChildPageLoadComplete");
							ProcessQueue(context);
							return;
						}
						break;
					case "SavingNoRootFolderLookup":
							if (ActivatedEventElements.Contains("SavingNoRootFolderLookupStartMessage")) {
							context.QueueTasks.Enqueue("SavingNoRootFolderLookupStartMessage");
						}
						break;
					case "YesSaveToCurrentGroupAnswer":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
					case "NoSaveToCurrentGroupAnswer":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
						}
						break;
					case "SysEntityShemaEditChange":
							if (ActivatedEventElements.Contains("SysEntityShemaEditChangeMessage")) {
							context.QueueTasks.Enqueue("SysEntityShemaEditChangeMessage");
						}
						break;
					case "SysEditPageSchemaEditChange":
							if (ActivatedEventElements.Contains("SysEditPageSchemaEditChangeMessage")) {
							context.QueueTasks.Enqueue("SysEditPageSchemaEditChangeMessage");
						}
						break;
					case "SysGridPageSchemaEditChange":
							if (ActivatedEventElements.Contains("SysGridPageSchemaEditChangeMessage")) {
							context.QueueTasks.Enqueue("SysGridPageSchemaEditChangeMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("IsCorrectSchema") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsCorrectSchema", IsCorrectSchema, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: LookupEditPageEventsProcess

	/// <exclude/>
	public class LookupEditPageEventsProcess : LookupEditPageEventsProcess<Terrasoft.WebApp.LookupEditPageSchemaUserControl>
	{

		public LookupEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LookupEditPageSchemaUserControl

	/// <exclude/>
	public partial class LookupEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("NameEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit SysEntityShemaEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("SysEntityShemaEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit SysGridPageSchemaEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("SysGridPageSchemaEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit SysEditPageSchemaEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("SysEditPageSchemaEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MemoEdit DescriptionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.MemoEdit)PageContainer.FindPageControl("DescriptionEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox IsSimpleCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("IsSimpleCheckBox", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			SysEntityShemaEdit.AjaxEvents.Change.Event += SysEntityShemaEditChange;
			SysGridPageSchemaEdit.AjaxEvents.Change.Event += SysGridPageSchemaEditChange;
			SysEditPageSchemaEdit.AjaxEvents.Change.Event += SysEditPageSchemaEditChange;
			DataSource.AjaxEvents.DataChanged.Event += DataSourceDataChanged;
			DataSource.SaveRow += DataSourceSaved;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			SysEntityShemaEdit.AjaxEvents.Change.Event -= SysEntityShemaEditChange;
			SysGridPageSchemaEdit.AjaxEvents.Change.Event -= SysGridPageSchemaEditChange;
			SysEditPageSchemaEdit.AjaxEvents.Change.Event -= SysEditPageSchemaEditChange;
			DataSource.AjaxEvents.DataChanged.Event -= DataSourceDataChanged;
			DataSource.SaveRow -= DataSourceSaved;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (LookupEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new LookupEditPageEventsProcess(UserConnection);
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

		public virtual void SysEntityShemaEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("SysEntityShemaEditChange");
		}

		public virtual void SysGridPageSchemaEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("SysGridPageSchemaEditChange");
		}

		public virtual void SysEditPageSchemaEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("SysEditPageSchemaEditChange");
		}

		public virtual void DataSourceDataChanged(object sender, EventArgs e) {
			object result = ThrowEvent("DataSourceDataChanged");
		}

		public virtual void DataSourceSaved(object sender, EventArgs e) {
			object result = ThrowEvent("DataSourceSaved");
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
			SchemaName = "LookupEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: LookupEditPageEventsProcessSchema

	/// <exclude/>
	public class LookupEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public LookupEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LookupEditPageEventsProcessSchema(LookupEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LookupEditPageEventsProcess";
			UId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956");
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

		protected virtual ProcessSchemaParameter CreateIsCorrectSchemaParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0e31cffa-ad3e-4e87-84af-caeb6740910e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"IsCorrectSchema",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"True",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsCorrectSchemaParameter());
		}

		protected virtual void InitializeSaveToNoRootQuestionUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("50c10d30-2b20-4772-ae5c-3686ffdaea68"),
				ContainerUId = new Guid("a71b7660-fb10-40be-b7b7-7f41bd6923e4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("ca9d2217-7ff8-4fa7-9317-a7019aa06ae2"),
				ContainerUId = new Guid("a71b7660-fb10-40be-b7b7-7f41bd6923e4"),
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
				UId = new Guid("90c9c4f3-538d-4bcd-bef7-135eaf9a73fd"),
				ContainerUId = new Guid("a71b7660-fb10-40be-b7b7-7f41bd6923e4"),
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
				UId = new Guid("1d0fde54-58e0-4805-9e59-02ecb5498d74"),
				ContainerUId = new Guid("a71b7660-fb10-40be-b7b7-7f41bd6923e4"),
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
				Name = @"WindowCaption",
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
				UId = new Guid("e27c0f30-0b54-481f-bcca-7b7a0d484253"),
				ContainerUId = new Guid("a71b7660-fb10-40be-b7b7-7f41bd6923e4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("903b7be4-0134-4241-81ae-e3fc59f1535e"),
				ContainerUId = new Guid("a71b7660-fb10-40be-b7b7-7f41bd6923e4"),
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
				UId = new Guid("08c3bdc8-3ec0-4d95-a35b-3650401a7e7b"),
				ContainerUId = new Guid("a71b7660-fb10-40be-b7b7-7f41bd6923e4"),
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
				UId = new Guid("2da2fc5b-0418-459e-969b-6038275d73cf"),
				ContainerUId = new Guid("a71b7660-fb10-40be-b7b7-7f41bd6923e4"),
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
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet194 = CreateLaneSet194LaneSet();
			LaneSets.Add(schemaLaneSet194);
			ProcessSchemaLane schemaLane519 = CreateLane519Lane();
			schemaLaneSet194.Lanes.Add(schemaLane519);
			ProcessSchemaLane schemaLane520 = CreateLane520Lane();
			schemaLaneSet194.Lanes.Add(schemaLane520);
			ProcessSchemaLane schemaLane521 = CreateLane521Lane();
			schemaLaneSet194.Lanes.Add(schemaLane521);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet194.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess initsubprocess = CreateInitSubProcessEventSubProcess();
			FlowElements.Add(initsubprocess);
			ProcessSchemaEventSubProcess subprocesschildpageloadcomplete = CreateSubProcessChildPageLoadCompleteEventSubProcess();
			FlowElements.Add(subprocesschildpageloadcomplete);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaStartMessageEvent init = CreateInitStartMessageEvent();
			initsubprocess.FlowElements.Add(init);
			ProcessSchemaScriptTask scriptinit = CreateScriptInitScriptTask();
			initsubprocess.FlowElements.Add(scriptinit);
			ProcessSchemaStartMessageEvent startmessagechildpageloadcomplete = CreateStartMessageChildPageLoadCompleteStartMessageEvent();
			subprocesschildpageloadcomplete.FlowElements.Add(startmessagechildpageloadcomplete);
			ProcessSchemaScriptTask scriptchildpageloadcomplete = CreateScriptChildPageLoadCompleteScriptTask();
			subprocesschildpageloadcomplete.FlowElements.Add(scriptchildpageloadcomplete);
			ProcessSchemaStartMessageEvent savingnorootfolderlookupstartmessage = CreateSavingNoRootFolderLookupStartMessageStartMessageEvent();
			eventsubprocess4.FlowElements.Add(savingnorootfolderlookupstartmessage);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess4.FlowElements.Add(scripttask1);
			ProcessSchemaUserTask savetonorootquestionusertask = CreateSaveToNoRootQuestionUserTaskUserTask();
			eventsubprocess4.FlowElements.Add(savetonorootquestionusertask);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess4.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess4.FlowElements.Add(scripttask2);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess4.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask scripttask3 = CreateScriptTask3ScriptTask();
			eventsubprocess4.FlowElements.Add(scripttask3);
			ProcessSchemaStartMessageEvent sysentityshemaeditchangemessage = CreateSysEntityShemaEditChangeMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(sysentityshemaeditchangemessage);
			ProcessSchemaScriptTask sysentityshemaeditchangescript = CreateSysEntityShemaEditChangeScriptScriptTask();
			eventsubprocess1.FlowElements.Add(sysentityshemaeditchangescript);
			ProcessSchemaStartMessageEvent syseditpageschemaeditchangemessage = CreateSysEditPageSchemaEditChangeMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(syseditpageschemaeditchangemessage);
			ProcessSchemaScriptTask syseditpageschemaeditchangescripttask = CreateSysEditPageSchemaEditChangeScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(syseditpageschemaeditchangescripttask);
			ProcessSchemaStartMessageEvent sysgridpageschemaeditchangemessage = CreateSysGridPageSchemaEditChangeMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(sysgridpageschemaeditchangemessage);
			ProcessSchemaScriptTask sysgridpageschemaeditchangescripttask = CreateSysGridPageSchemaEditChangeScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(sysgridpageschemaeditchangescripttask);
			FlowElements.Add(CreateSequenceFlow3336SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3341SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3344SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3345SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3346SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3347SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateLookupCaptionLocalizableString());
			LocalizableStrings.Add(CreateSaveToNoRootQuestionLocalizableString());
			LocalizableStrings.Add(CreateSchemaNotCorrectMessageLocalizableString());
			LocalizableStrings.Add(CreateSchemaNotCorrectCaptionLocalizableString());
			LocalizableStrings.Add(CreateSchemaIsSystemLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateLookupCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3ecbf366-fc2a-4bcc-b8ec-2b4e8e4eaa7f"),
				Name = "LookupCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSaveToNoRootQuestionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a23e543e-e2ea-4917-b62d-a39042e8ddb3"),
				Name = "SaveToNoRootQuestion",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSchemaNotCorrectMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6178487b-a251-468f-aed4-07b24bed8cf3"),
				Name = "SchemaNotCorrectMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSchemaNotCorrectCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b3b81aef-7a9f-434c-b04b-9bdc7bea891f"),
				Name = "SchemaNotCorrectCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSchemaIsSystemLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("aefdd8c5-93ca-4ba4-bc1c-523ce1a47ec7"),
				Name = "SchemaIsSystem",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3336SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3336",
				UId = new Guid("b9c12687-a4fe-420b-aba8-5cf297efe5fa"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				CurveCenterPosition = new Point(138, 601),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("43f52a44-1afa-411c-9f2d-fab4e0497a9c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6c5691b8-f183-4da7-8043-daebecb2702f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3341SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3341",
				UId = new Guid("284abbf9-d22c-4f47-8afa-b1a831cac996"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				CurveCenterPosition = new Point(197, 650),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9dfe7af6-7f29-4b1f-b175-ca4395a25178"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("809013e0-9477-4318-b342-5ededd58c304"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3344SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3344",
				UId = new Guid("e38e62d3-6f75-421d-a7c7-f3dd5518c2f1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				CurveCenterPosition = new Point(161, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3d171100-037d-43bd-8fa0-ab19c321cc28"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e0e70895-3d30-46c6-99ed-aba15ffc01bb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3345SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3345",
				UId = new Guid("3a67d904-7936-439a-98c1-fc17d1636755"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				CurveCenterPosition = new Point(293, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e0e70895-3d30-46c6-99ed-aba15ffc01bb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a71b7660-fb10-40be-b7b7-7f41bd6923e4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3346SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3346",
				UId = new Guid("23b25726-c38a-41c8-b56b-c654166411df"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				CurveCenterPosition = new Point(506, 131),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("13f1bcc9-4e27-4233-b608-17a1b3a0a38c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cf07a18f-70c9-46ec-b232-7ed191a879c6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3347SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3347",
				UId = new Guid("06341efb-ac52-4f76-b46b-0ea902113b33"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				CurveCenterPosition = new Point(509, 50),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ecaf01de-1599-4f34-813a-89d5a10760da"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e243734c-37c0-4b7c-8050-566d22b6911d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("f631f3c9-8f30-4baf-b2e2-de195ed02898"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e46445ed-70db-4bfa-96de-f48c1799011e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6d958648-9c0d-4b94-b203-0f410aecfd52"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("35a3ff24-5f91-4de9-9557-2e30f69a8ce8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e1e477c4-7672-44f6-9244-e3cb37605258"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0de342cd-ceab-4e18-ae4b-6d973dc69976"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("54e67656-c5a3-4569-852d-db64e7d6602b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("786045f5-2732-4ec0-b84b-ed30390e7c20"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0f16bbb8-12c3-47b9-b4d0-f7db3af3c6b0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet194LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet194 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("8d1e6bd6-02fa-439b-b993-ebcadb8430bd"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"LaneSet194",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(839, 708),
				UseBackgroundMode = false
			};
			return schemaLaneSet194;
		}

		protected virtual ProcessSchemaLane CreateLane519Lane() {
			ProcessSchemaLane schemaLane519 = new ProcessSchemaLane(this) {
				UId = new Guid("6b58b122-26a6-4f99-976b-709fe67f1293"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("8d1e6bd6-02fa-439b-b993-ebcadb8430bd"),
				CreatedInOwnerSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"Lane519",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 558),
				Size = new Size(810, 150),
				UseBackgroundMode = false
			};
			return schemaLane519;
		}

		protected virtual ProcessSchemaLane CreateLane520Lane() {
			ProcessSchemaLane schemaLane520 = new ProcessSchemaLane(this) {
				UId = new Guid("8ac10326-f9ad-4c18-9be7-073fa4797e7e"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("8d1e6bd6-02fa-439b-b993-ebcadb8430bd"),
				CreatedInOwnerSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"Lane520",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 375),
				Size = new Size(810, 178),
				UseBackgroundMode = false
			};
			return schemaLane520;
		}

		protected virtual ProcessSchemaLane CreateLane521Lane() {
			ProcessSchemaLane schemaLane521 = new ProcessSchemaLane(this) {
				UId = new Guid("fed269fa-a2df-428d-9ed1-b14e150b522f"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("8d1e6bd6-02fa-439b-b993-ebcadb8430bd"),
				CreatedInOwnerSchemaUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"Lane521",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 170),
				Size = new Size(810, 200),
				UseBackgroundMode = false
			};
			return schemaLane521;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("62179fbb-3c72-4635-8bf5-7a336252195f"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("8d1e6bd6-02fa-439b-b993-ebcadb8430bd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(810, 165),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateInitSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaInitSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f934d81b-cbe3-4c97-830f-c4fff16df289"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6b58b122-26a6-4f99-976b-709fe67f1293"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"InitSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(210, 126),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaInitSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("43f52a44-1afa-411c-9f2d-fab4e0497a9c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f934d81b-cbe3-4c97-830f-c4fff16df289"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"Init",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6c5691b8-f183-4da7-8043-daebecb2702f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f934d81b-cbe3-4c97-830f-c4fff16df289"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"ScriptInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(105, 36),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,46,74,77,44,73,117,203,204,41,73,45,114,203,47,242,201,207,207,46,45,208,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,69,27,205,191,37,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessChildPageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessChildPageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("89e28c23-eec6-4150-a527-054268c8d6e2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8ac10326-f9ad-4c18-9be7-073fa4797e7e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"SubProcessChildPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(290, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessChildPageLoadComplete;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChildPageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9dfe7af6-7f29-4b1f-b175-ca4395a25178"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("89e28c23-eec6-4150-a527-054268c8d6e2"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"StartMessageChildPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 59),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildPageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("809013e0-9477-4318-b342-5ededd58c304"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("89e28c23-eec6-4150-a527-054268c8d6e2"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"ScriptChildPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(183, 47),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,88,205,110,27,55,16,62,43,64,222,129,221,67,176,2,228,181,157,184,145,141,196,6,236,181,28,11,117,210,212,178,147,131,225,3,163,165,98,54,171,165,66,114,237,170,134,128,54,61,182,64,239,125,140,162,5,210,166,72,95,97,253,70,29,254,236,46,37,173,100,217,104,209,0,73,20,145,51,223,252,240,227,204,80,231,152,35,78,186,140,71,237,8,109,162,132,92,160,39,41,141,252,231,248,53,9,158,16,249,28,115,220,39,146,240,23,56,78,137,239,229,178,94,61,56,98,29,201,105,242,218,175,215,31,221,189,67,123,126,190,23,180,69,171,63,144,67,216,64,109,241,12,32,55,145,228,41,1,41,18,11,82,172,245,48,124,131,197,229,229,236,151,236,99,246,91,3,101,127,102,31,175,222,193,223,239,174,126,204,254,208,95,179,191,178,191,179,247,217,135,236,61,44,254,144,253,126,245,238,234,251,171,159,145,146,202,62,92,253,164,68,80,246,43,122,201,248,27,49,192,93,130,194,195,213,230,131,245,207,87,208,139,139,206,80,116,186,103,164,143,219,73,185,239,173,237,181,30,174,108,52,155,75,97,115,117,117,105,109,125,231,254,210,250,218,198,198,210,106,216,218,217,105,133,123,205,245,135,235,222,221,59,231,144,153,25,16,78,158,22,67,83,9,210,25,5,184,86,34,169,28,118,20,102,43,162,50,56,96,236,77,58,48,70,142,245,33,84,91,117,32,158,112,26,169,255,27,153,219,162,40,189,219,163,152,4,69,88,226,14,75,185,78,138,6,222,45,86,64,72,104,130,160,183,41,225,67,67,150,92,236,144,192,162,144,193,87,229,150,67,40,205,39,228,59,122,65,200,18,137,105,34,92,10,214,209,229,221,59,53,147,208,231,156,246,49,31,134,44,78,251,137,38,235,20,157,43,108,158,148,104,167,19,132,30,153,8,123,44,142,8,215,185,80,72,129,102,246,92,255,114,141,220,63,7,97,1,127,10,237,10,127,94,49,22,35,170,110,207,161,246,26,16,103,5,31,180,222,166,112,189,252,210,103,133,97,1,66,54,24,130,110,181,251,106,83,19,214,30,222,192,197,126,6,197,0,52,203,99,15,12,55,130,49,15,2,37,102,115,228,136,134,41,231,36,145,96,49,237,202,148,195,130,150,22,240,153,38,18,109,110,162,21,247,68,75,38,29,75,26,83,73,137,8,218,9,124,226,152,126,75,182,83,201,118,73,175,0,115,12,33,44,208,36,132,205,160,241,201,73,161,49,168,14,154,179,139,241,200,66,78,176,36,135,236,66,243,113,33,154,1,134,42,154,206,174,63,149,190,201,194,89,83,74,157,113,37,15,46,221,94,78,132,70,78,9,45,253,95,148,203,251,205,149,38,2,236,229,101,243,109,117,21,157,232,139,111,234,193,41,74,152,68,93,195,16,248,84,126,34,229,98,129,2,94,206,14,196,149,106,104,226,31,11,194,129,112,9,233,74,202,146,160,16,8,138,24,107,179,175,87,68,122,26,91,148,55,172,102,169,234,108,205,169,51,39,99,16,167,227,101,167,166,185,80,8,228,48,19,30,119,136,16,240,169,232,117,226,128,157,42,230,237,82,45,3,103,254,216,184,213,64,236,213,215,160,184,85,192,119,11,50,8,203,158,3,42,164,21,223,178,126,244,24,240,175,123,230,43,133,115,77,52,72,126,97,204,6,94,149,115,189,100,110,101,126,193,128,147,59,67,101,207,215,72,193,23,100,88,15,28,29,181,213,48,86,2,189,96,92,168,57,142,6,219,81,228,104,235,253,145,250,71,153,59,96,56,50,92,217,165,98,16,227,161,113,210,119,244,181,134,190,129,53,231,142,181,19,72,172,84,46,219,11,170,7,4,83,53,203,240,123,52,134,9,68,199,63,167,154,236,105,41,149,25,69,160,218,2,162,192,142,62,59,39,190,193,15,142,45,253,70,227,62,206,212,86,25,153,170,23,102,243,37,149,103,197,232,36,124,179,24,178,254,0,115,42,88,114,52,28,216,10,221,80,174,78,213,136,198,204,186,110,74,198,117,133,181,45,246,41,225,152,119,207,104,23,199,150,43,71,132,115,44,88,79,194,201,131,140,182,160,106,170,29,72,52,99,140,37,116,102,181,173,101,32,169,63,93,242,247,199,133,130,48,102,9,241,235,234,14,44,110,202,16,105,241,88,156,177,113,76,77,49,16,74,181,240,167,0,171,189,5,156,201,32,111,228,183,230,9,42,216,58,219,149,145,61,46,211,117,237,81,84,246,27,165,115,178,114,186,120,30,117,164,170,239,160,174,73,154,173,82,18,119,101,89,1,39,74,87,88,138,6,133,172,70,154,211,224,244,20,1,61,83,55,57,147,225,138,194,115,19,26,207,194,240,204,45,138,190,76,188,6,130,250,74,142,104,159,4,207,76,125,152,171,177,51,84,253,165,50,21,179,117,159,178,136,246,232,141,204,229,42,215,218,155,89,230,52,39,20,5,8,204,220,162,104,52,170,15,76,55,15,149,242,45,91,236,107,181,75,175,124,65,228,83,186,215,168,32,17,84,124,85,100,34,199,245,199,26,202,175,66,168,143,26,174,129,241,247,197,237,76,76,99,76,24,25,127,126,220,50,142,41,140,250,200,216,24,61,154,232,33,101,174,85,31,113,51,95,7,201,203,79,245,21,106,106,5,17,111,45,65,220,147,211,51,141,63,113,191,93,129,167,56,129,228,240,6,242,170,189,240,12,81,1,93,245,178,237,56,118,43,156,112,230,33,219,128,55,149,35,183,236,115,200,211,71,236,100,222,157,52,20,174,219,86,141,65,59,8,253,27,198,221,57,52,208,142,92,55,132,206,245,73,31,138,173,198,214,51,96,170,201,61,164,47,54,160,19,103,83,215,207,230,154,110,7,133,242,103,112,174,105,28,163,123,247,10,64,251,30,218,202,159,67,74,195,119,242,6,243,151,122,44,85,94,100,195,254,89,191,53,64,45,211,16,219,73,116,68,190,145,133,23,215,220,52,141,220,64,215,73,231,243,171,23,226,129,138,215,171,219,49,82,183,201,153,49,84,84,138,241,40,42,126,238,248,36,3,169,168,70,19,199,49,253,139,203,255,19,200,200,52,33,248,227,14,74,208,232,98,10,144,219,192,214,115,253,240,157,215,190,159,226,55,196,194,234,74,81,62,205,85,31,132,88,246,73,60,216,73,165,180,251,156,192,56,151,152,31,2,255,1,165,252,72,62,118,20,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3f20f388-ca78-47a7-941b-a1857af1459b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fed269fa-a2df-428d-9ed1-b14e150b522f"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"EventSubProcess4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(609, 179),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSavingNoRootFolderLookupStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3d171100-037d-43bd-8fa0-ab19c321cc28"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3f20f388-ca78-47a7-941b-a1857af1459b"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SavingNoRootFolderLookup",
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"SavingNoRootFolderLookupStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e0e70895-3d30-46c6-99ed-aba15ffc01bb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3f20f388-ca78-47a7-941b-a1857af1459b"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,206,203,10,194,64,12,5,208,125,191,34,204,186,248,3,85,193,23,210,133,227,163,117,225,178,72,144,34,36,37,201,248,64,252,119,103,168,75,177,171,187,57,247,38,85,115,195,154,61,31,152,109,31,80,173,101,58,42,74,221,232,117,180,107,46,8,19,72,81,100,213,63,185,65,213,168,106,124,88,44,252,162,3,3,229,153,41,54,221,254,184,170,234,114,235,221,128,159,7,51,38,77,149,211,170,242,219,33,127,64,237,162,199,239,163,169,72,120,135,101,123,78,172,145,231,88,77,90,186,228,208,231,20,94,25,0,188,220,19,213,229,241,8,106,191,191,8,34,72,182,22,14,221,140,244,142,226,222,121,79,137,147,244,252,15,190,139,76,208,130,16,152,4,44,62,25,246,15,49,127,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateSaveToNoRootQuestionUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("a71b7660-fb10-40be-b7b7-7f41bd6923e4"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3f20f388-ca78-47a7-941b-a1857af1459b"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"SaveToNoRootQuestionUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(239, 51),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeSaveToNoRootQuestionUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ecaf01de-1599-4f34-813a-89d5a10760da"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3f20f388-ca78-47a7-941b-a1857af1459b"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"YesSaveToCurrentGroupAnswer",
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(351, 23),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e243734c-37c0-4b7c-8050-566d22b6911d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3f20f388-ca78-47a7-941b-a1857af1459b"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"ScriptTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(449, 9),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,44,75,117,77,201,44,9,72,76,79,117,73,44,73,212,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,73,227,20,199,33,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("13f1bcc9-4e27-4233-b608-17a1b3a0a38c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3f20f388-ca78-47a7-941b-a1857af1459b"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"NoSaveToCurrentGroupAnswer",
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"StartMessage2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(351, 107),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cf07a18f-70c9-46ec-b232-7ed191a879c6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3f20f388-ca78-47a7-941b-a1857af1459b"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"ScriptTask3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(449, 93),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,9,202,207,47,113,203,207,73,73,45,114,203,47,114,46,45,42,74,205,3,138,149,107,104,90,115,5,39,150,165,186,166,100,150,4,36,166,167,186,36,150,36,130,196,138,82,75,74,139,242,20,74,138,74,83,173,1,231,119,83,7,62,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("030603bd-6b7c-402d-83e4-2e993375cc56"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("62179fbb-3c72-4635-8bf5-7a336252195f"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"EventSubProcess1",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(213, 144),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysEntityShemaEditChangeMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e46445ed-70db-4bfa-96de-f48c1799011e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("030603bd-6b7c-402d-83e4-2e993375cc56"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SysEntityShemaEditChange",
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"SysEntityShemaEditChangeMessage",
				Position = new Point(29, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSysEntityShemaEditChangeScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6d958648-9c0d-4b94-b203-0f410aecfd52"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("030603bd-6b7c-402d-83e4-2e993375cc56"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"SysEntityShemaEditChangeScript",
				Position = new Point(106, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,83,75,107,227,48,16,62,55,144,255,32,124,137,12,198,116,207,221,22,90,39,45,134,237,146,226,182,57,79,237,105,43,42,75,94,73,110,48,33,255,125,37,203,78,156,215,178,148,221,155,173,153,249,30,210,55,159,160,8,10,195,76,147,229,239,88,194,61,8,120,67,69,46,201,147,70,149,72,33,48,55,76,138,120,118,216,116,49,30,125,218,113,221,104,127,156,138,133,84,31,186,130,28,103,217,3,177,24,2,151,100,56,248,80,163,106,8,61,66,24,145,224,121,153,29,65,10,66,75,115,130,34,158,43,86,130,106,90,216,68,242,186,20,113,170,175,249,18,108,63,114,171,220,106,48,170,198,63,64,92,23,133,159,164,193,83,90,180,108,39,77,181,178,45,228,41,172,59,52,190,135,238,94,94,68,230,214,99,108,237,117,151,225,102,103,5,51,241,51,240,26,15,57,139,83,36,237,184,227,121,108,42,236,132,183,24,223,239,106,86,92,245,30,200,120,228,25,115,197,42,211,93,177,179,234,15,168,54,138,137,183,248,86,170,18,12,13,86,231,235,88,163,25,192,209,201,86,108,43,194,226,78,34,50,89,125,91,79,44,124,16,141,71,103,45,195,20,12,100,178,86,57,198,9,103,246,97,211,105,52,240,17,58,111,222,157,127,244,71,120,225,109,58,254,38,96,206,104,42,180,1,145,227,77,99,37,208,33,244,69,103,242,6,52,222,163,214,246,123,14,2,185,21,130,160,168,171,167,58,145,74,89,2,63,180,77,3,123,165,187,122,250,40,77,153,174,56,116,97,34,151,54,194,53,231,225,170,183,123,192,101,239,180,251,167,158,227,167,52,29,103,2,149,127,252,253,66,55,16,145,238,195,189,101,188,0,37,236,155,56,213,103,135,178,95,129,107,167,123,189,73,202,15,41,63,234,234,43,123,150,245,195,253,106,109,160,134,203,208,237,194,78,249,150,113,131,74,187,54,186,83,72,20,130,65,95,94,48,243,62,7,5,37,186,94,234,15,19,89,86,160,152,150,162,53,59,251,85,3,247,82,246,66,22,68,100,184,171,62,64,255,87,68,170,173,12,131,101,75,237,242,17,14,22,210,195,219,75,225,62,166,126,49,183,164,155,149,223,182,236,45,127,216,198,141,208,35,96,113,34,107,97,200,21,57,15,201,191,136,88,239,228,139,201,26,143,20,154,90,9,191,36,191,1,87,180,172,185,26,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("feb2e79b-169e-484e-aff4-319319bbd5fe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("62179fbb-3c72-4635-8bf5-7a336252195f"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"EventSubProcess2",
				Position = new Point(252, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(223, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysEditPageSchemaEditChangeMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e1e477c4-7672-44f6-9244-e3cb37605258"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("feb2e79b-169e-484e-aff4-319319bbd5fe"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SysEditPageSchemaEditChange",
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"SysEditPageSchemaEditChangeMessage",
				Position = new Point(29, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSysEditPageSchemaEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0de342cd-ceab-4e18-ae4b-6d973dc69976"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("feb2e79b-169e-484e-aff4-319319bbd5fe"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"SysEditPageSchemaEditChangeScriptTask",
				Position = new Point(113, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,75,111,130,64,20,133,215,37,225,63,140,44,4,18,50,105,215,173,77,140,82,195,162,173,6,181,235,9,220,218,73,97,32,243,208,16,227,127,239,60,180,33,181,184,227,113,230,124,231,222,51,123,194,145,40,190,160,38,89,137,38,104,73,118,128,243,78,164,37,149,230,57,183,191,204,27,222,146,74,1,94,55,185,228,148,237,162,248,209,247,246,230,112,39,156,40,99,31,13,255,22,45,41,32,205,87,72,155,49,56,160,148,73,42,59,167,88,41,224,29,138,54,2,248,172,97,12,10,73,27,134,251,138,87,194,52,148,39,40,216,30,242,127,140,3,67,29,32,226,37,167,53,225,157,165,204,154,74,213,12,103,98,90,29,136,214,67,165,105,58,146,228,10,110,88,76,203,210,157,140,130,77,86,6,55,103,180,177,181,229,144,215,2,164,211,252,25,56,249,221,247,149,253,198,118,48,76,51,158,235,174,133,115,72,219,200,211,66,209,242,249,146,23,249,158,239,209,207,104,36,108,75,122,1,111,170,170,222,121,90,183,58,72,31,212,107,50,70,227,177,45,203,88,13,139,70,19,43,192,214,43,62,250,222,157,187,45,5,167,173,60,55,103,54,232,62,68,231,4,47,13,175,137,140,130,227,253,9,11,144,189,228,81,120,117,209,52,50,76,80,120,124,56,133,122,150,32,209,12,7,153,19,73,242,70,241,2,240,172,162,192,100,54,79,250,65,99,179,203,147,239,113,144,138,51,87,243,15,134,234,7,176,219,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a96d73b5-4bed-4dbb-b972-43fb75fe6c30"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("62179fbb-3c72-4635-8bf5-7a336252195f"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"EventSubProcess3",
				Position = new Point(484, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(188, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysGridPageSchemaEditChangeMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("786045f5-2732-4ec0-b84b-ed30390e7c20"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a96d73b5-4bed-4dbb-b972-43fb75fe6c30"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SysGridPageSchemaEditChange",
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"SysGridPageSchemaEditChangeMessage",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSysGridPageSchemaEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0f16bbb8-12c3-47b9-b4d0-f7db3af3c6b0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a96d73b5-4bed-4dbb-b972-43fb75fe6c30"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				Name = @"SysGridPageSchemaEditChangeScriptTask",
				Position = new Point(77, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,146,95,111,130,48,20,197,159,37,225,59,84,30,70,73,72,179,61,239,79,98,148,25,30,182,105,80,247,220,192,157,107,86,10,105,139,134,24,191,251,218,226,22,162,195,215,189,17,122,123,126,231,244,220,29,149,72,229,159,80,210,180,64,143,104,65,183,64,178,86,205,37,43,236,119,230,142,146,130,105,178,161,188,1,178,170,50,45,153,216,226,232,222,247,118,246,114,171,186,161,84,188,87,242,75,213,52,135,36,91,34,35,38,96,143,18,161,153,110,187,137,101,3,178,69,120,173,64,78,43,33,32,215,172,18,164,63,241,66,133,129,202,24,5,155,125,246,135,112,96,169,3,68,178,144,172,164,178,117,148,105,197,155,82,144,84,77,248,158,154,121,224,134,102,44,105,217,192,21,137,73,81,116,55,113,176,78,139,224,106,70,103,219,72,14,105,205,65,119,51,103,129,227,223,247,190,144,95,187,14,230,13,43,72,82,214,186,53,231,236,3,225,43,248,177,121,229,134,243,232,224,123,163,51,153,225,91,214,218,170,173,225,148,213,21,251,96,169,79,63,177,145,239,29,125,207,210,241,88,185,190,205,83,190,26,208,155,116,198,112,159,213,219,137,8,221,220,184,218,173,218,240,208,184,31,210,121,239,246,46,151,172,214,167,29,176,93,116,63,240,201,193,115,37,75,170,113,112,184,61,18,5,186,103,30,135,23,43,107,144,97,140,194,195,221,49,52,113,130,216,48,58,200,140,106,154,85,141,204,129,76,57,3,161,211,89,220,55,26,217,86,76,120,224,10,254,223,153,43,247,228,104,228,123,18,116,35,69,183,197,223,255,43,247,184,186,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateCreateLookupColumnsMethod());
			Methods.Add(CreateCreateFilterForLookupMethod());
			Methods.Add(CreateSaveEditPageDataMethod());
			Methods.Add(CreateSetRootFolderForCurrentRowMethod());
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

		protected override SchemaMethod CreateAreConditionsCorrectMethod() {
			SchemaMethod method = base.CreateAreConditionsCorrectMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,77,45,46,78,76,79,13,72,204,75,205,81,40,0,147,182,10,1,64,17,61,167,196,226,84,95,36,89,107,94,46,94,174,204,52,5,13,69,207,98,231,252,162,162,212,228,146,224,228,140,212,220,68,5,53,53,5,69,176,86,61,143,196,98,168,22,13,136,156,95,126,9,84,173,115,98,65,73,102,126,158,166,166,66,53,47,23,39,68,185,99,74,10,1,229,58,10,232,18,80,13,10,58,10,80,86,72,101,65,170,94,120,98,81,94,102,94,186,38,208,145,181,188,92,69,169,37,165,69,121,10,104,238,180,6,0,204,174,80,236,236,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateMakeCaptionMethod() {
			SchemaMethod method = base.CreateMakeCaptionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,77,79,194,64,16,134,207,146,240,31,54,61,237,38,100,193,171,248,17,45,31,33,49,72,0,245,96,60,172,237,128,27,219,110,51,187,5,27,224,191,187,237,82,155,154,160,158,54,217,121,231,157,121,159,145,43,58,209,190,72,141,84,201,240,83,106,163,25,217,181,91,103,8,38,195,164,223,110,29,218,173,141,64,18,168,40,139,147,169,136,129,92,145,153,88,3,31,8,35,22,42,195,0,248,34,120,135,88,240,145,76,194,25,202,88,96,62,144,58,141,68,238,127,119,81,214,119,70,233,9,129,181,93,24,148,201,154,15,227,212,228,86,45,87,84,187,159,137,158,102,81,244,128,101,133,214,171,48,183,235,47,150,195,80,26,235,48,135,64,97,120,140,89,132,34,16,105,248,171,185,30,228,56,116,187,164,68,225,108,78,115,168,231,52,229,247,74,125,100,105,179,138,229,102,147,208,150,19,216,146,113,38,67,90,218,142,193,204,4,218,217,6,240,73,68,25,80,175,210,122,140,47,149,131,69,89,193,181,30,65,43,141,101,230,104,49,178,223,19,95,37,27,64,99,219,238,148,138,64,36,39,103,248,42,205,61,102,193,222,16,114,164,63,82,24,11,67,189,93,239,64,232,238,252,192,188,78,21,170,67,166,176,109,192,101,196,50,189,248,87,235,79,122,115,181,213,47,189,215,98,171,101,158,66,232,110,81,238,117,233,252,174,27,183,183,193,93,140,91,157,22,47,17,154,44,1,81,104,181,50,252,113,194,159,225,205,6,55,168,34,205,11,1,171,46,83,220,246,120,133,47,187,33,144,72,0,3,0,0 };
			return method;
		}

		protected override SchemaMethod CreateOkClickMethodMethod() {
			SchemaMethod method = base.CreateOkClickMethodMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,208,65,75,195,48,20,7,240,115,5,191,67,200,41,61,180,164,78,54,139,120,210,41,131,49,116,221,109,120,200,154,151,25,44,121,154,164,45,67,246,221,77,219,141,237,176,221,66,120,239,247,254,239,105,197,102,110,1,109,76,254,162,219,155,168,17,150,104,87,64,5,165,7,249,138,149,4,187,68,244,228,137,40,81,57,120,12,53,90,17,246,46,182,144,46,225,183,6,231,211,143,26,236,174,240,86,155,109,186,194,225,193,226,244,25,141,23,218,56,70,85,239,204,36,141,195,152,32,244,99,142,159,129,54,208,146,183,90,203,171,236,250,68,124,198,93,134,232,74,72,118,82,207,88,202,243,141,40,149,186,75,70,247,192,19,169,178,44,201,39,217,38,225,60,147,99,14,249,232,161,28,135,112,157,188,239,55,100,151,252,67,248,66,52,48,149,218,119,97,95,132,23,108,232,35,16,238,51,84,244,107,172,190,44,182,211,6,140,103,52,180,132,45,22,216,41,131,55,71,252,174,127,232,113,228,89,247,69,126,255,15,109,32,178,202,168,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateLookupColumnsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1434b0fc-6bb6-4152-9a15-9999389a337b"),
				Name = "CreateLookupColumns",
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,93,107,19,65,20,125,78,32,255,97,216,167,89,72,54,73,209,196,82,43,216,181,150,64,91,163,253,122,16,31,166,59,19,51,116,51,19,103,103,83,66,91,208,250,168,224,187,63,67,20,170,149,250,23,38,255,200,249,216,132,221,38,109,19,8,97,111,206,61,247,156,123,207,142,144,0,132,73,42,199,123,81,159,12,208,14,98,232,61,17,96,29,28,36,68,132,156,49,18,73,202,89,176,69,100,1,1,189,205,249,54,207,7,40,1,11,254,88,171,148,235,117,245,93,221,168,159,85,160,254,168,155,201,165,254,126,156,124,81,191,237,163,250,171,254,169,43,117,173,174,116,241,179,250,53,185,156,124,154,124,3,6,165,174,39,95,13,4,168,31,224,136,139,147,100,136,34,2,194,55,205,246,74,187,209,174,148,71,218,65,204,249,73,58,204,207,125,157,18,49,214,46,24,57,5,115,117,184,192,113,21,120,135,167,123,227,196,21,59,108,54,202,243,215,242,67,58,56,228,113,58,96,154,251,142,169,193,115,156,97,160,119,208,193,182,191,82,190,11,252,146,198,146,136,196,52,193,187,48,161,32,72,18,135,60,162,178,223,69,2,13,136,105,131,174,24,242,193,16,9,154,112,182,63,30,146,96,243,67,138,226,42,168,148,75,185,143,213,82,5,112,43,165,216,239,106,203,129,118,155,205,50,163,54,49,149,193,33,138,83,226,23,29,91,12,37,201,61,142,117,56,92,81,251,142,93,96,96,49,63,83,202,196,173,23,23,201,52,251,219,198,59,67,99,244,103,219,179,90,158,26,185,207,96,113,247,193,174,182,239,214,154,215,146,49,102,15,235,139,114,109,70,116,88,34,17,139,200,198,88,111,4,78,5,249,107,160,94,175,222,78,125,152,10,161,105,76,53,232,224,74,185,199,245,41,162,62,52,86,34,151,3,202,10,115,3,39,49,241,207,244,250,105,15,118,146,93,29,193,243,115,160,89,71,68,200,96,159,111,112,30,19,196,160,61,130,22,52,59,167,117,12,189,144,15,199,158,239,251,103,165,146,57,225,2,139,110,198,242,70,205,190,160,167,239,189,157,107,183,193,156,210,23,136,103,199,201,207,201,82,232,224,78,251,252,137,75,165,124,99,176,71,100,238,150,208,179,9,52,23,13,244,82,204,47,244,151,232,154,233,182,237,247,71,247,97,182,29,34,81,23,201,190,166,114,23,12,14,204,245,31,236,235,242,132,26,155,186,175,177,4,252,136,98,59,163,217,88,6,173,253,188,18,152,136,23,84,184,101,90,171,222,106,147,172,68,17,105,214,90,189,199,205,218,35,212,195,181,227,30,94,173,225,168,253,164,117,140,219,164,213,106,121,75,122,14,209,48,147,31,21,95,162,219,189,104,68,160,173,95,84,202,23,255,1,33,219,192,224,32,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateFilterForLookupMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ebffc8fd-52c3-4359-a751-d8ef081a9512"),
				Name = "CreateFilterForLookup",
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,85,77,79,194,64,16,61,67,194,127,152,244,4,177,233,31,64,77,12,86,98,162,166,9,126,28,140,135,149,29,202,234,178,91,119,182,106,67,250,223,157,178,4,65,244,224,65,195,129,83,155,221,121,243,222,155,188,105,135,165,146,64,21,221,89,247,76,133,24,227,185,132,35,200,68,142,201,13,161,27,88,99,112,236,149,53,201,170,34,57,151,253,78,251,85,56,40,184,108,52,158,226,76,92,10,195,239,14,24,251,5,54,68,191,81,210,141,178,175,168,168,7,130,96,235,184,15,129,5,141,87,190,250,61,79,186,141,11,76,223,92,52,92,157,246,194,246,168,162,101,65,115,159,74,229,147,204,97,33,28,94,88,251,92,22,103,74,123,86,112,112,4,18,53,230,194,35,116,237,227,19,203,0,66,35,209,197,16,10,27,104,250,202,234,79,92,78,128,61,152,119,218,173,129,213,58,40,62,60,85,139,167,112,213,33,121,167,76,30,67,232,115,124,12,147,5,9,177,77,76,2,33,241,204,91,203,227,228,68,202,174,193,55,248,185,5,204,217,81,171,53,143,198,118,198,218,21,89,115,93,21,24,197,16,218,13,54,142,147,244,165,20,186,142,151,24,141,19,159,190,23,14,137,184,59,75,46,103,38,19,126,202,232,104,180,150,149,168,142,3,160,36,60,85,84,104,81,221,10,93,54,44,19,161,9,87,13,157,202,167,107,29,51,225,196,12,89,197,162,154,184,188,49,19,148,223,63,192,124,51,143,117,93,247,118,196,252,50,45,87,172,254,175,188,127,147,246,164,225,219,161,41,164,239,158,131,206,70,88,235,95,141,33,128,131,231,186,191,190,156,67,167,228,231,183,98,191,159,251,253,252,215,253,220,250,231,173,111,231,102,82,155,128,237,147,186,79,234,110,38,245,3,33,22,90,156,250,9,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSaveEditPageDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("03a9ceb8-3152-4d21-a120-d8b575927278"),
				Name = "SaveEditPageData",
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,141,75,10,131,48,20,69,199,201,42,30,25,41,133,184,0,71,69,39,133,22,164,174,224,145,60,75,104,76,36,31,29,136,123,111,108,23,208,225,189,231,126,6,124,145,28,85,48,75,122,160,43,34,200,171,214,63,163,226,76,152,9,42,1,23,24,206,92,143,9,71,159,131,34,217,89,67,46,221,250,130,132,68,149,204,74,79,191,201,217,107,51,25,210,53,236,2,24,227,140,253,169,70,92,169,170,91,56,63,202,221,1,100,35,193,14,155,113,186,236,41,235,227,151,31,130,215,45,111,154,46,16,38,186,123,255,206,75,231,109,158,93,44,248,3,197,89,82,103,198,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetRootFolderForCurrentRowMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a5d24292-fcc9-409a-81dd-179cdb8ff131"),
				Name = "SetRootFolderForCurrentRow",
				CreatedInSchemaUId = new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,11,78,46,202,44,40,241,77,204,3,114,138,244,28,83,82,32,2,26,92,156,1,32,105,151,196,146,196,224,252,210,162,228,84,61,231,156,204,212,188,18,79,23,5,109,5,37,189,226,212,18,231,252,156,210,220,188,176,196,156,210,84,13,245,224,202,98,183,252,156,148,212,34,207,20,117,29,5,117,3,203,164,196,228,180,52,35,93,99,147,84,3,221,148,52,67,67,93,75,115,195,36,93,3,3,195,20,51,131,84,75,99,139,100,51,117,77,107,5,37,46,77,107,0,115,89,107,77,135,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LookupEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fc784cad-9e8a-49bc-8e8c-b6986b105956"));
		}

		#endregion

	}

	#endregion

}

