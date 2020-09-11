namespace Terrasoft.WebApp
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Data;
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

	#region Class: SocialAccountGridPageSchema

	/// <exclude/>
	public class SocialAccountGridPageSchema : Terrasoft.WebApp.LookupGridPageSchema
	{

		#region Constructors: Public

		public SocialAccountGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SocialAccountGridPageSchema(SocialAccountGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateSchemaListEdit() {
			SchemaListEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			SchemaListEdit.Image = new ControlImage {};
			SchemaListEdit.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdateSearchComboBoxEdit() {
			SearchComboBoxEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			SearchComboBoxEdit.Image = new ControlImage {};
			SearchComboBoxEdit.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdateToolButtonClearSearch() {
			ToolButtonClearSearch.AjaxEvents.Click.IsProcessEventHandler = true;
			ToolButtonClearSearch.Image = new ControlImage {
				Source = ControlImageSource.ResourceManager,
				SchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31"),
				ResourceManagerName = @"Terrasoft.UI.WebControls",
				ResourceItemName = @"toolbutton-close.gif",
				ImageHash = @"6936621ac4b4c164b51744b8634fe7a0"
			};
			ToolButtonClearSearch.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdateSearchEdit() {
			SearchEdit.Image = new ControlImage {};
			SearchEdit.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdateSearchButton() {
			SearchButton.AjaxEvents.Click.IsProcessEventHandler = true;
			SearchButton.Image = new ControlImage {};
			SearchButton.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdateSearchControlLayout() {
			SearchControlLayout.Image = new ControlImage {};
			SearchControlLayout.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.DblClick.ShowLoadMask = true;
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
			TreeGrid.AjaxEvents.SelectionChange.ShowLoadMask = true;
		}

		private void UpdateAddSelectedRecordButton() {
			AddSelectedRecordButton.AjaxEvents.Click.IsProcessEventHandler = true;
			AddSelectedRecordButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31"),
				ImageHash = @"f5fb6c4a8d5abab00bede0e49a38a6ff"
			};
			AddSelectedRecordButton.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdateRemoveSelectedRecordButton() {
			RemoveSelectedRecordButton.AjaxEvents.Click.IsProcessEventHandler = true;
			RemoveSelectedRecordButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31"),
				ImageHash = @"012f06e2ee1dc8d32d3959105560eacd"
			};
			RemoveSelectedRecordButton.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdateSelectedRecordButtonsControlLayout() {
			SelectedRecordButtonsControlLayout.Image = new ControlImage {};
			SelectedRecordButtonsControlLayout.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdateSelectedRecordsGridContolLayout() {
			SelectedRecordsGridContolLayout.Image = new ControlImage {};
			SelectedRecordsGridContolLayout.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdateSelectedRowsControlLayout() {
			SelectedRowsControlLayout.Image = new ControlImage {};
			SelectedRowsControlLayout.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdateCommonControlLayout() {
			CommonControlLayout.Image = new ControlImage {};
			CommonControlLayout.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		private void UpdateActionButtonsControlLayout() {
			ActionButtonsControlLayout.Image = new ControlImage {};
			ActionButtonsControlLayout.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
			RealUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
			Name = "SocialAccountGridPage";
			ParentSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ValidationMessagePanel = "";
			UseProfile = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSocialAccountGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateActionButtonsControlLayout();
			UpdateCancelButton();
			UpdateOKButton();
			UpdateCommonControlLayout();
			UpdateSelectedRowsControlLayout();
			UpdateSelectedRecordsGridContolLayout();
			UpdateSelectedRecordButtonsControlLayout();
			UpdateRemoveSelectedRecordButton();
			UpdateAddSelectedRecordButton();
			UpdateTreeGrid();
			UpdateShowChangelogMenuItem();
			UpdateCallMenuItem();
			UpdateSendEmailMenuItem();
			UpdateButtonsControlLayout();
			UpdateActionButton();
			UpdateContextHelpButton();
			UpdatePrintButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateCopyButton();
			UpdateAddButton();
			UpdateSearchControlLayout();
			UpdateSearchButton();
			UpdateSearchEdit();
			UpdateToolButtonClearSearch();
			UpdateSearchComboBoxEdit();
			UpdateSchemaListEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, SearchControlLayout);
			SearchControlLayout.MoveItem(0, SchemaListEdit);
			SearchControlLayout.MoveItem(1, SearchComboBoxEdit);
			SearchControlLayout.MoveItem(2, SearchEdit);
			SearchEdit.MoveItem(0, ToolButtonClearSearch);
			SearchControlLayout.MoveItem(3, SearchButton);
			TopLevelControl.MoveItem(2, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.MoveItem(4, SpacerDeleteButton);
			ButtonsControlLayout.MoveItem(5, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(6, PrintButton);
			ButtonsControlLayout.MoveItem(7, ContextHelpButton);
			ButtonsControlLayout.MoveItem(8, ActionButton);
			TopLevelControl.MoveItem(3, CommonControlLayout);
			CommonControlLayout.MoveItem(0, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, CallMenuItem);
			TreeGrid.MoveItem(2, ShowChangelogMenuItem);
			CommonControlLayout.MoveItem(1, SelectedRowsControlLayout);
			SelectedRowsControlLayout.MoveItem(0, SelectedRecordButtonsControlLayout);
			SelectedRecordButtonsControlLayout.MoveItem(0, Spacer1);
			SelectedRecordButtonsControlLayout.MoveItem(1, AddSelectedRecordButton);
			SelectedRecordButtonsControlLayout.MoveItem(2, RemoveSelectedRecordButton);
			SelectedRecordButtonsControlLayout.MoveItem(3, Spacer2);
			SelectedRowsControlLayout.MoveItem(1, SelectedRecordsGridContolLayout);
			SelectedRecordsGridContolLayout.MoveItem(0, SelectedRecordsGrid);
			TopLevelControl.MoveItem(4, ActionButtonsControlLayout);
			ActionButtonsControlLayout.MoveItem(0, SpacerOKButton);
			ActionButtonsControlLayout.MoveItem(1, OKButton);
			ActionButtonsControlLayout.MoveItem(2, CancelButton);
			TopLevelControl.MoveItem(5, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSocialAccountGridPageEventsProcessSchema() {
			var schema = new SocialAccountGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff");
			DataSource.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("17023734-308e-47de-bc4a-061325c890cd");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("6a86e81d-86b2-4650-b1dc-fd775bd0a277");
			if (column != null) {
				column.UId = new Guid("08302fe1-2eb3-48c9-b115-9548182c7e4c");
				column.Name = @"Login";
				column.CreatedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("0970d0ac-3bc2-478f-85db-4ea9e939a521");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("243ce265-9f49-4def-a2cd-ca2f218d8d40");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("f7368c48-02b7-4c1e-906b-bb96ca142b58");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("1cd9aeaf-2e90-47ea-94b4-a69118a536d7");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("7fd8f7c7-740f-4058-b05b-84528ab537d9");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("abc96728-faf6-451d-91f6-35bc53ea9745");
			if (column != null) {
				column.UId = new Guid("3c8ea40b-fc43-48af-88bf-361f9ea317a1");
				column.Name = @"Notes";
				column.CreatedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("6287d2bd-93ac-4ca2-921f-3e87d81dc00b");
			if (column != null) {
				column.UId = new Guid("4777bcb5-e88e-4114-825e-2262c8de8de9");
				column.Name = @"Public";
				column.CreatedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("14f15a6f-d70a-4c77-8f00-984f7bc1821f");
			if (column != null) {
				column.UId = new Guid("2a357715-c1b1-4638-8eb5-2ce015968278");
				column.Name = @"AccessToken";
				column.CreatedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ef8d65a0-3f11-43ac-a259-a28a34494d23");
			if (column != null) {
				column.UId = new Guid("98ca2dc9-fb21-40a1-a66c-2605686db195");
				column.Name = @"AccessSecretToken";
				column.CreatedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("eee3f2c0-52b4-4d86-95bf-bf4d7fe00f24");
			if (column != null) {
				column.UId = new Guid("5d2feb8b-35bb-42eb-ade0-dcea34055ba7");
				column.Name = @"ConsumerKey";
				column.CreatedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("6be6d2f0-6c1c-463b-8daa-972f1687ec4f");
			if (column != null) {
				column.UId = new Guid("0825d0f1-2b93-4c33-bf42-818b33d31645");
				column.Name = @"Type";
				column.CreatedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("f22ba771-1414-4be2-9ff8-3028ce093bcf");
			if (column != null) {
				column.UId = new Guid("cfc067db-66ee-43d6-a5fd-82b42eaa72fc");
				column.Name = @"User";
				column.CreatedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("72ef9eba-b06f-4bda-b9e1-4c04309aaf5e");
			if (column != null) {
				column.UId = new Guid("69bae95d-c275-4916-a544-f51e5dd89cbf");
				column.Name = @"SocialId";
				column.CreatedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e2a409c4-5ace-48d0-ac77-766ed29cb397");
			if (column != null) {
				column.UId = new Guid("8e52a191-209b-4fd5-a953-009cc2b94c7a");
				column.Name = @"IsExpired";
				column.CreatedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("bbaf2034-8e52-432d-849c-9ddf83e19d6f");
			if (column != null) {
				column.UId = new Guid("067e6714-7eac-42af-8112-a2389e4579c8");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
				column.ModifiedInSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
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
			return new SocialAccountGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new SocialAccountGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SocialAccountGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SocialAccountGridPageEventsProcess

	/// <exclude/>
	public class SocialAccountGridPageEventsProcess<TPage> : Terrasoft.WebApp.LookupGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SocialAccountGridPageSchemaUserControl
	{

		public SocialAccountGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SocialAccountGridPageEventsProcess";
			SchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef");
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

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("e9adff0b-5f75-4d6b-b481-90d13655863d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteChild;
		public ProcessFlowElement PageLoadCompleteChild {
			get {
				return _pageLoadCompleteChild ?? (_pageLoadCompleteChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadCompleteChild",
					SchemaElementUId = new Guid("86c5e638-81b6-4c93-8002-b755d87c438a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _throwPageLoadComplete;
		public ProcessThrowMessageEvent ThrowPageLoadComplete {
			get {
				return _throwPageLoadComplete ?? (_throwPageLoadComplete = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowPageLoadComplete",
					SchemaElementUId = new Guid("5251169c-16a0-4499-a6e8-3a6e635fbb79"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptPageLoadCompleteChild;
		public ProcessScriptTask ScriptPageLoadCompleteChild {
			get {
				return _scriptPageLoadCompleteChild ?? (_scriptPageLoadCompleteChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPageLoadCompleteChild",
					SchemaElementUId = new Guid("46ab0ea7-c767-4ef9-83db-4e0d4175948f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadCompleteChildExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[PageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChild };
			FlowElements[ThrowPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowPageLoadComplete };
			FlowElements[ScriptPageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadCompleteChild };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "PageLoadCompleteChild":
						e.Context.QueueTasks.Enqueue("ThrowPageLoadComplete");
						break;
					case "ThrowPageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadCompleteChild");
						break;
					case "ScriptPageLoadCompleteChild":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("PageLoadCompleteChild");
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
				case "PageLoadCompleteChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteChild";
					result = PageLoadCompleteChild.Execute(context);
					break;
				case "ThrowPageLoadComplete":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = ThrowPageLoadComplete.Execute(context);
					break;
				case "ScriptPageLoadCompleteChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPageLoadCompleteChild";
					result = ScriptPageLoadCompleteChild.Execute(context, ScriptPageLoadCompleteChildExecute);
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

		public virtual bool ScriptPageLoadCompleteChildExecute(ProcessExecutingContext context) {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageAdministration");
			Page.DataSource.EnableServerActiveRow = true;
			return true;
		}

		public override Dictionary<string, string> GetEditPages() {
			var result = base.GetEditPages();
			if (result.Count == 0 && EditPageUId == Guid.Empty) {
				EditPageUId = GetDeafaultLookupEditSchemaId();
				HasOwnEditPage = true;
			}
			return result;
		}

		public override void ActivateButtons(bool activate) {
			base.ActivateButtons(activate);
			var activeRow = Page.DataSource.ActiveRow;
			if (activeRow == null) {
				return;
			}
			Page.DeleteButton.SetEnabled(Page.DeleteButton.Enabled 
				&& (activeRow.GetTypedColumnValue<Guid>("TypeId") != new Guid("EFE5D7A2-5F38-E111-851E-00155D04C01D")));
		}

		public override string GetRegisterTreeGridDblClickScript(string defaultScript) {
			if (EditMode) {
				return base.GetRegisterTreeGridDblClickScript(defaultScript);
			} if  (MultiSelectMode) {
				var script = string.Concat("window.Terrasoft.AjaxMethods.ThrowClientEventWithMask('", InstanceUId, "', 'AddSelectedRecordButtonClick');");
				script = string.Format("if ({0}.activeRow) {{ {1} }}", Page.DataSource.ClientID, script);
				return script;
			} else {
				var script = string.Concat("window.Terrasoft.AjaxMethods.ThrowClientEventWithMask('", InstanceUId, "', 'LookupRecordSelected');");
				if (!IsVirtualMode) {
					script = string.Format("if ({0}.activeRow) {{ {1} }}", Page.DataSource.ClientID, script);
				}
				return script;
			}
			// 14.08.2012
			/*if (EditMode) {
				return base.GetRegisterTreeGridDblClickScript(defaultScript);
			} 
			else {
				var script = string.Concat("window.Terrasoft.AjaxMethods.ThrowClientEvent('", InstanceUId, "', 'LookupRecordSelected');");
				if (!IsVirtualMode) {
					script = string.Format("if ({0}.activeRow) {{ {1} }}", Page.DataSource.ClientID, script);
				}
			return script;
			}*/
			
			/*if (!EditMode) {
				var script = string.Concat("window.Terrasoft.AjaxMethods.ThrowClientEvent('", InstanceUId, "', 'LookupRecordSelected');");
				return string.Format("if ({0}.activeRow) {{ {1} }}", Page.DataSource.ClientID, script);
			} else {*/
				
			//}
			/*if (!Page.ButtonsControlLayout.Hidden) {
				return defaultScript;
			}
			else {
				return string.Empty;
			}*/
		}

		public override void FillPrintMenu() {
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteChild")) {
							context.QueueTasks.Enqueue("PageLoadCompleteChild");
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

	#region Class: SocialAccountGridPageEventsProcess

	/// <exclude/>
	public class SocialAccountGridPageEventsProcess : SocialAccountGridPageEventsProcess<Terrasoft.WebApp.SocialAccountGridPageSchemaUserControl>
	{

		public SocialAccountGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SocialAccountGridPageSchemaUserControl

	/// <exclude/>
	public partial class SocialAccountGridPageSchemaUserControl : Terrasoft.WebApp.LookupGridPageSchemaUserControl
	{

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
			var process = (SocialAccountGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SocialAccountGridPageEventsProcess(UserConnection);
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
			SchemaName = "SocialAccountGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: SocialAccountGridPageEventsProcessSchema

	/// <exclude/>
	public class SocialAccountGridPageEventsProcessSchema : Terrasoft.WebApp.LookupGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public SocialAccountGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SocialAccountGridPageEventsProcessSchema(SocialAccountGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SocialAccountGridPageEventsProcess";
			UId = new Guid("af04b160-2852-43fa-a2f7-8298ef885b2d");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent pageloadcompletechild = CreatePageLoadCompleteChildStartMessageEvent();
			eventsubprocess1.FlowElements.Add(pageloadcompletechild);
			ProcessSchemaIntermediateThrowMessageEvent throwpageloadcomplete = CreateThrowPageLoadCompleteIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(throwpageloadcomplete);
			ProcessSchemaScriptTask scriptpageloadcompletechild = CreateScriptPageLoadCompleteChildScriptTask();
			eventsubprocess1.FlowElements.Add(scriptpageloadcompletechild);
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("74842b99-bffb-4ee9-9dc3-2f6bf9e50b3b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("af04b160-2852-43fa-a2f7-8298ef885b2d"),
				CurveCenterPosition = new Point(149, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("af04b160-2852-43fa-a2f7-8298ef885b2d"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("86c5e638-81b6-4c93-8002-b755d87c438a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5251169c-16a0-4499-a6e8-3a6e635fbb79"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("66f6e5b6-2f32-40b8-905c-b90d2b6bfb32"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("af04b160-2852-43fa-a2f7-8298ef885b2d"),
				CurveCenterPosition = new Point(236, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("af04b160-2852-43fa-a2f7-8298ef885b2d"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5251169c-16a0-4499-a6e8-3a6e635fbb79"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("46ab0ea7-c767-4ef9-83db-4e0d4175948f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("d41407ad-beba-4640-84bf-f6028dd4bb1f"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("af04b160-2852-43fa-a2f7-8298ef885b2d"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("af04b160-2852-43fa-a2f7-8298ef885b2d"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(897, 184),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("f650f654-c3f4-4281-8cbc-54fc50ee6c67"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("d41407ad-beba-4640-84bf-f6028dd4bb1f"),
				CreatedInOwnerSchemaUId = new Guid("f3d96925-bfb1-43fd-90ad-e5a9686f2cef"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("af04b160-2852-43fa-a2f7-8298ef885b2d"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("af04b160-2852-43fa-a2f7-8298ef885b2d"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(868, 184),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e9adff0b-5f75-4d6b-b481-90d13655863d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f650f654-c3f4-4281-8cbc-54fc50ee6c67"),
				CreatedInOwnerSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("af04b160-2852-43fa-a2f7-8298ef885b2d"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("af04b160-2852-43fa-a2f7-8298ef885b2d"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(49, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(271, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("86c5e638-81b6-4c93-8002-b755d87c438a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9adff0b-5f75-4d6b-b481-90d13655863d"),
				CreatedInOwnerSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("af04b160-2852-43fa-a2f7-8298ef885b2d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("af04b160-2852-43fa-a2f7-8298ef885b2d"),
				Name = @"PageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(7, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowPageLoadCompleteIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("5251169c-16a0-4499-a6e8-3a6e635fbb79"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9adff0b-5f75-4d6b-b481-90d13655863d"),
				CreatedInOwnerSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("af04b160-2852-43fa-a2f7-8298ef885b2d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("af04b160-2852-43fa-a2f7-8298ef885b2d"),
				Name = @"ThrowPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(84, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadCompleteChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("46ab0ea7-c767-4ef9-83db-4e0d4175948f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9adff0b-5f75-4d6b-b481-90d13655863d"),
				CreatedInOwnerSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("af04b160-2852-43fa-a2f7-8298ef885b2d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("af04b160-2852-43fa-a2f7-8298ef885b2d"),
				Name = @"ScriptPageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(162, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,37,141,65,10,194,48,16,69,247,130,119,40,93,233,38,23,16,23,53,205,82,20,131,7,24,227,167,14,234,68,166,147,170,183,55,210,229,127,255,193,59,143,80,159,69,144,140,179,184,126,23,145,138,178,125,131,12,44,112,254,134,116,247,36,225,83,185,225,240,130,210,223,92,181,21,238,73,104,64,119,125,178,240,104,243,209,174,55,203,197,177,98,215,147,81,204,69,19,92,16,186,60,16,161,19,180,171,165,9,167,252,110,182,141,105,65,213,21,86,84,230,245,3,153,165,141,154,145,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("041f8571-1e0d-4d76-9587-98645fd79cea"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
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
				UId = new Guid("dc00bb50-26d4-4608-809c-73585d9eebd9"),
				Name = "System.Data",
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

		protected override SchemaMethod CreateGetEditPagesMethod() {
			SchemaMethod method = base.CreateGetEditPagesMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,74,45,46,205,41,81,176,85,72,74,44,78,213,115,79,45,113,77,201,44,9,72,76,79,45,214,208,180,230,229,202,76,83,208,128,40,209,115,206,47,205,3,42,180,85,48,80,80,83,83,128,41,11,245,76,1,137,185,151,102,166,232,185,230,22,148,84,106,42,84,243,114,113,162,72,43,0,141,117,73,77,76,75,4,26,227,147,159,159,93,90,0,146,14,78,206,72,205,77,244,76,1,219,195,233,145,88,236,95,158,7,211,6,212,83,82,84,154,10,148,168,229,229,42,74,45,41,45,202,131,186,212,26,0,83,195,192,240,181,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateActivateButtonsMethod() {
			SchemaMethod method = base.CreateActivateButtonsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,65,107,194,64,16,133,207,238,175,24,115,8,187,135,132,172,237,162,16,21,172,217,136,183,82,197,251,104,198,18,216,110,36,238,26,138,248,223,109,52,66,160,199,247,190,121,239,205,30,207,20,47,14,174,188,160,163,15,239,92,101,207,28,59,45,82,118,193,26,30,146,190,170,6,102,240,137,223,20,103,232,112,83,249,250,208,69,91,150,178,242,8,188,119,58,3,235,141,17,112,101,131,154,156,175,109,202,110,236,25,39,67,175,177,120,67,78,91,220,27,42,248,127,216,17,96,131,48,236,149,199,43,114,219,223,19,21,203,202,248,31,187,67,227,105,186,242,101,49,231,65,235,175,139,64,192,240,239,1,106,160,181,121,160,115,173,178,241,98,20,169,252,109,18,105,41,101,52,81,82,71,73,34,149,202,146,247,101,34,179,64,8,145,222,1,93,175,53,162,16,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterTreeGridDblClickScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterTreeGridDblClickScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,148,79,79,194,48,24,135,207,44,217,119,40,92,24,132,148,63,241,96,66,60,32,32,146,176,196,0,234,185,172,239,160,50,90,210,190,3,9,217,119,183,219,0,69,61,162,198,203,146,54,91,223,231,247,236,183,137,144,120,125,46,208,87,28,42,100,239,58,5,13,24,107,73,102,204,0,29,0,142,97,46,12,130,158,106,128,129,22,188,55,139,186,145,8,150,147,64,139,53,122,28,66,22,71,152,175,42,109,215,73,136,8,9,241,124,187,41,38,16,65,240,225,232,13,211,196,100,119,146,27,98,80,11,57,167,93,37,3,134,94,105,43,36,87,91,58,5,173,153,81,33,210,206,11,123,245,1,23,138,27,58,93,104,181,181,99,65,98,127,99,47,207,2,23,62,51,75,175,92,170,145,161,52,200,100,0,143,67,94,35,165,114,141,148,59,156,231,163,129,143,33,80,154,223,198,136,74,102,220,229,74,187,148,114,22,62,131,220,41,189,74,65,44,190,183,111,36,148,5,40,54,48,86,91,203,190,39,251,102,66,146,196,78,123,96,115,160,61,134,108,162,98,29,0,205,169,134,189,218,33,89,118,246,193,97,190,147,73,129,200,192,175,58,24,41,181,140,215,121,252,163,140,83,246,52,99,113,104,158,132,198,152,69,239,47,232,71,165,36,223,137,113,157,122,157,52,175,104,227,154,182,26,205,150,93,86,197,229,43,233,58,151,247,255,159,188,127,209,94,173,187,206,209,117,241,92,246,159,10,58,130,94,220,194,241,11,76,131,23,210,210,37,167,248,217,227,249,31,194,216,160,168,85,52,98,59,21,35,189,23,156,131,60,235,224,89,185,242,2,159,170,117,14,223,95,173,113,151,187,126,3,132,208,73,210,101,5,0,0 };
			return method;
		}

		protected override SchemaMethod CreateFillPrintMenuMethod() {
			SchemaMethod method = base.CreateFillPrintMenuMethod();
			method.IsOverride = true;
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SocialAccountGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("af04b160-2852-43fa-a2f7-8298ef885b2d"));
		}

		#endregion

	}

	#endregion

}

