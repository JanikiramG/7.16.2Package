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

	#region Class: IntegrationLogEditPageSchema

	/// <exclude/>
	public class IntegrationLogEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _inactiveControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout InactiveControlLayout {
			get {
				return _inactiveControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _topControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout TopControlLayout {
			get {
				return _topControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _topTopControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout TopTopControlLayout {
			get {
				return _topTopControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _integrationSystemEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit IntegrationSystemEdit {
			get {
				return _integrationSystemEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _topBottomControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout TopBottomControlLayout {
			get {
				return _topBottomControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _sessionNumberEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit SessionNumberEdit {
			get {
				return _sessionNumberEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _dateEdit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit DateEdit {
			get {
				return _dateEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _centerControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout CenterControlLayout {
			get {
				return _centerControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _directionEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit DirectionEdit {
			get {
				return _directionEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _resultEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit ResultEdit {
			get {
				return _resultEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _operationEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit OperationEdit {
			get {
				return _operationEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _bottomControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout BottomControlLayout {
			get {
				return _bottomControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MemoEdit _descriptionEdit;
		public Terrasoft.UI.WebControls.Controls.MemoEdit DescriptionEdit {
			get {
				return _descriptionEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public IntegrationLogEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public IntegrationLogEditPageSchema(IntegrationLogEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			RealUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			Name = "IntegrationLogEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6");
			Width = 600;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateIntegrationLogEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(0, CreateInactiveControlLayout());
			InactiveControlLayout.InsertItem(0, CreateTopControlLayout());
			TopControlLayout.InsertItem(0, CreateTopTopControlLayout());
			TopTopControlLayout.InsertItem(0, CreateIntegrationSystemEdit());
			TopControlLayout.InsertItem(1, CreateTopBottomControlLayout());
			TopBottomControlLayout.InsertItem(0, CreateSessionNumberEdit());
			TopBottomControlLayout.InsertItem(1, CreateDateEdit());
			InactiveControlLayout.InsertItem(1, CreateCenterControlLayout());
			CenterControlLayout.InsertItem(0, CreateDirectionEdit());
			CenterControlLayout.InsertItem(1, CreateResultEdit());
			CenterControlLayout.InsertItem(2, CreateOperationEdit());
			InactiveControlLayout.InsertItem(2, CreateBottomControlLayout());
			BottomControlLayout.InsertItem(0, CreateDescriptionEdit());
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

		protected virtual EmbeddedProcessSchema CreateIntegrationLogEditPageEventsProcessSchema() {
			var schema = new IntegrationLogEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateIntegrationSystemEdit() {
			_integrationSystemEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_integrationSystemEdit.UId = new Guid("40ba52c7-4170-4170-845f-1a9f8487d35c");
			_integrationSystemEdit.Name = "IntegrationSystemEdit";
			_integrationSystemEdit.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_integrationSystemEdit.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_integrationSystemEdit.CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6");
			_integrationSystemEdit.Tag = "";
			_integrationSystemEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_integrationSystemEdit.Image = new ControlImage {};
			_integrationSystemEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_integrationSystemEdit.DataSource = "DataSource";
			_integrationSystemEdit.ColumnUId = new Guid("3238e429-7023-45d0-8498-d721566ff1b7");
			_integrationSystemEdit.Enabled = false;
			return _integrationSystemEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateTopTopControlLayout() {
			_topTopControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_topTopControlLayout.UId = new Guid("7c9f74f2-c833-4eb6-8970-86a4f9f27a44");
			_topTopControlLayout.Name = "TopTopControlLayout";
			_topTopControlLayout.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_topTopControlLayout.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_topTopControlLayout.CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6");
			_topTopControlLayout.Tag = "";
			_topTopControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_topTopControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_topTopControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_topTopControlLayout.FitHeightByContent = true;
			_topTopControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_topTopControlLayout.StartNewAlignGroup = false;
			_topTopControlLayout.Image = new ControlImage {};
			_topTopControlLayout.Edges = "";
			return _topTopControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreateSessionNumberEdit() {
			_sessionNumberEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_sessionNumberEdit.UId = new Guid("ce8fe4a9-4327-4ee9-8499-1c65cdafd514");
			_sessionNumberEdit.Name = "SessionNumberEdit";
			_sessionNumberEdit.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_sessionNumberEdit.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_sessionNumberEdit.CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6");
			_sessionNumberEdit.Tag = "";
			_sessionNumberEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sessionNumberEdit.Image = new ControlImage {};
			_sessionNumberEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_sessionNumberEdit.DataSource = "DataSource";
			_sessionNumberEdit.ColumnUId = new Guid("b1db70b2-12a1-4896-93da-3a6184a0a74b");
			_sessionNumberEdit.Enabled = false;
			return _sessionNumberEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateDateEdit() {
			_dateEdit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_dateEdit.UId = new Guid("e248a6bc-7f17-4097-934d-5fa5fd1b0fd4");
			_dateEdit.Name = "DateEdit";
			_dateEdit.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_dateEdit.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_dateEdit.CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6");
			_dateEdit.Tag = "";
			_dateEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_dateEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_dateEdit.DataSource = "DataSource";
			_dateEdit.ColumnUId = new Guid("6d7e4a36-6ed5-4546-859d-ed84d9800b30");
			_dateEdit.Enabled = false;
			return _dateEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateTopBottomControlLayout() {
			_topBottomControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_topBottomControlLayout.UId = new Guid("58d0fa33-fa83-4911-8966-599abe6a7102");
			_topBottomControlLayout.Name = "TopBottomControlLayout";
			_topBottomControlLayout.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_topBottomControlLayout.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_topBottomControlLayout.CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6");
			_topBottomControlLayout.Tag = "";
			_topBottomControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_topBottomControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_topBottomControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_topBottomControlLayout.FitHeightByContent = true;
			_topBottomControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_topBottomControlLayout.StartNewAlignGroup = false;
			_topBottomControlLayout.Image = new ControlImage {};
			_topBottomControlLayout.Edges = "";
			return _topBottomControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateTopControlLayout() {
			_topControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_topControlLayout.UId = new Guid("89c4c3ea-16e6-4caf-bfeb-6ebc4dae059f");
			_topControlLayout.Name = "TopControlLayout";
			_topControlLayout.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_topControlLayout.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_topControlLayout.CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6");
			_topControlLayout.Tag = "";
			_topControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_topControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_topControlLayout.FitHeightByContent = true;
			_topControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_topControlLayout.StartNewAlignGroup = false;
			_topControlLayout.Image = new ControlImage {};
			_topControlLayout.Edges = "";
			return _topControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateDirectionEdit() {
			_directionEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_directionEdit.UId = new Guid("ba306881-2377-407d-883f-4117eba054d3");
			_directionEdit.Name = "DirectionEdit";
			_directionEdit.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_directionEdit.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_directionEdit.CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6");
			_directionEdit.Tag = "";
			_directionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_directionEdit.Image = new ControlImage {};
			_directionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(40);
			_directionEdit.DataSource = "DataSource";
			_directionEdit.ColumnUId = new Guid("2ae412cb-9e4b-4a2a-83a6-f480e84050c5");
			_directionEdit.Enabled = false;
			return _directionEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateResultEdit() {
			_resultEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_resultEdit.UId = new Guid("62354913-bc6b-46c9-87f5-82e172b83e94");
			_resultEdit.Name = "ResultEdit";
			_resultEdit.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_resultEdit.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_resultEdit.CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6");
			_resultEdit.Tag = "";
			_resultEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_resultEdit.Image = new ControlImage {};
			_resultEdit.Width = System.Web.UI.WebControls.Unit.Percentage(30);
			_resultEdit.DataSource = "DataSource";
			_resultEdit.ColumnUId = new Guid("24224073-49d2-4c9c-9056-5fc704ce08d4");
			_resultEdit.Enabled = false;
			return _resultEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateOperationEdit() {
			_operationEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_operationEdit.UId = new Guid("e573664e-ada1-4a88-88cb-a00784e85f38");
			_operationEdit.Name = "OperationEdit";
			_operationEdit.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_operationEdit.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_operationEdit.CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6");
			_operationEdit.Tag = "";
			_operationEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_operationEdit.Image = new ControlImage {};
			_operationEdit.Width = System.Web.UI.WebControls.Unit.Percentage(30);
			_operationEdit.DataSource = "DataSource";
			_operationEdit.ColumnUId = new Guid("450b02eb-30cc-4f17-b3ad-3f37ccb8f37c");
			_operationEdit.Enabled = false;
			return _operationEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateCenterControlLayout() {
			_centerControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_centerControlLayout.UId = new Guid("572e5f8d-53f7-4a05-9204-d231ed59c543");
			_centerControlLayout.Name = "CenterControlLayout";
			_centerControlLayout.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_centerControlLayout.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_centerControlLayout.CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6");
			_centerControlLayout.Tag = "";
			_centerControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_centerControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_centerControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_centerControlLayout.FitHeightByContent = true;
			_centerControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_centerControlLayout.StartNewAlignGroup = false;
			_centerControlLayout.Image = new ControlImage {};
			_centerControlLayout.Edges = "";
			return _centerControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MemoEdit CreateDescriptionEdit() {
			_descriptionEdit = new Terrasoft.UI.WebControls.Controls.MemoEdit();
			_descriptionEdit.UId = new Guid("c057a6bc-6216-4637-86de-ac8a295df3b2");
			_descriptionEdit.Name = "DescriptionEdit";
			_descriptionEdit.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_descriptionEdit.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_descriptionEdit.CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6");
			_descriptionEdit.Tag = "";
			_descriptionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_descriptionEdit.Height = System.Web.UI.WebControls.Unit.Pixel(80);
			_descriptionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_descriptionEdit.DataSource = "DataSource";
			_descriptionEdit.ColumnUId = new Guid("0f977259-a355-471a-9f7f-dd760cff0a94");
			return _descriptionEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateBottomControlLayout() {
			_bottomControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_bottomControlLayout.UId = new Guid("95875e63-4a1f-4f5c-af2a-8e26283f0973");
			_bottomControlLayout.Name = "BottomControlLayout";
			_bottomControlLayout.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_bottomControlLayout.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_bottomControlLayout.CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6");
			_bottomControlLayout.Tag = "";
			_bottomControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_bottomControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_bottomControlLayout.FitHeightByContent = true;
			_bottomControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_bottomControlLayout.StartNewAlignGroup = false;
			_bottomControlLayout.Image = new ControlImage {};
			_bottomControlLayout.Edges = "";
			return _bottomControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateInactiveControlLayout() {
			_inactiveControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_inactiveControlLayout.UId = new Guid("4641d4a8-3efc-473e-b078-afb84cefa1fc");
			_inactiveControlLayout.Name = "InactiveControlLayout";
			_inactiveControlLayout.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_inactiveControlLayout.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			_inactiveControlLayout.CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6");
			_inactiveControlLayout.Tag = "";
			_inactiveControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_inactiveControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_inactiveControlLayout.FitHeightByContent = true;
			_inactiveControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_inactiveControlLayout.StartNewAlignGroup = false;
			_inactiveControlLayout.Image = new ControlImage {};
			_inactiveControlLayout.Edges = "";
			_inactiveControlLayout.Enabled = false;
			return _inactiveControlLayout;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("d5bb4bdc-06d3-4275-8d23-96ae2a19b086");
			DataSource.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("c64eb1ca-84ef-4775-bcf5-730ac2f176e6");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("a84d9a61-919c-4efd-9377-9a13a9811849");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("52fda55d-0a56-4dbe-8797-bb002bcb18c8");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("ee6c8db9-0582-4488-b7b3-dd6d66e28961");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("f6838735-3e8a-43d6-8148-94cda028b2e7");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("6ca5ec3e-bcd9-4090-8543-38ee7c7c8822");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("cc2ebf21-ef2d-4ef3-80da-6345649c70c9");
			if (column != null) {
				column.UId = new Guid("3238e429-7023-45d0-8498-d721566ff1b7");
				column.Name = @"IntegrationSystem";
				column.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("0712b7db-3846-47e5-b735-6fc5d962f759");
			if (column != null) {
				column.UId = new Guid("b1db70b2-12a1-4896-93da-3a6184a0a74b");
				column.Name = @"SessionNumber";
				column.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("0c2b0beb-339d-4e42-bba6-3f06267b831b");
			if (column != null) {
				column.UId = new Guid("6d7e4a36-6ed5-4546-859d-ed84d9800b30");
				column.Name = @"Date";
				column.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4f45a347-95cf-4c1b-be43-be69fc62806d");
			if (column != null) {
				column.UId = new Guid("2ae412cb-9e4b-4a2a-83a6-f480e84050c5");
				column.Name = @"Direction";
				column.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("384024d7-330a-4487-90e8-a8bbaf58bb49");
			if (column != null) {
				column.UId = new Guid("450b02eb-30cc-4f17-b3ad-3f37ccb8f37c");
				column.Name = @"Operation";
				column.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("40ad9faa-f737-4828-83d4-90c845b435a5");
			if (column != null) {
				column.UId = new Guid("24224073-49d2-4c9c-9056-5fc704ce08d4");
				column.Name = @"Result";
				column.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e272fb1a-d751-4cbe-b633-f24086f64cf2");
			if (column != null) {
				column.UId = new Guid("0f977259-a355-471a-9f7f-dd760cff0a94");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("98bfc088-c17b-4fdd-bafd-fa59253b2c66");
			if (column != null) {
				column.UId = new Guid("cb78cfee-e3b4-43f3-871d-f0b18e01e461");
				column.Name = @"ErrorDescription";
				column.CreatedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
				column.ModifiedInSchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
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
			return new IntegrationLogEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new IntegrationLogEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new IntegrationLogEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: IntegrationLogEditPageEventsProcess

	/// <exclude/>
	public class IntegrationLogEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.IntegrationLogEditPageSchemaUserControl
	{

		public IntegrationLogEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "IntegrationLogEditPageEventsProcess";
			SchemaUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
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

	#region Class: IntegrationLogEditPageEventsProcess

	/// <exclude/>
	public class IntegrationLogEditPageEventsProcess : IntegrationLogEditPageEventsProcess<Terrasoft.WebApp.IntegrationLogEditPageSchemaUserControl>
	{

		public IntegrationLogEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: IntegrationLogEditPageSchemaUserControl

	/// <exclude/>
	public partial class IntegrationLogEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout InactiveControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("InactiveControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout TopControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("TopControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout TopTopControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("TopTopControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit IntegrationSystemEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("IntegrationSystemEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout TopBottomControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("TopBottomControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.IntegerEdit SessionNumberEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("SessionNumberEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit DateEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("DateEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout CenterControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("CenterControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit DirectionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("DirectionEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit ResultEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("ResultEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit OperationEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("OperationEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout BottomControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("BottomControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MemoEdit DescriptionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.MemoEdit)PageContainer.FindPageControl("DescriptionEdit", true);
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
			var process = (IntegrationLogEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new IntegrationLogEditPageEventsProcess(UserConnection);
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
			SchemaName = "IntegrationLogEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: IntegrationLogEditPageEventsProcessSchema

	/// <exclude/>
	public class IntegrationLogEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public IntegrationLogEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public IntegrationLogEditPageEventsProcessSchema(IntegrationLogEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "IntegrationLogEditPageEventsProcess";
			UId = new Guid("d6abe9a7-615f-4c39-9ca1-1e6da80ecd30");
			CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6");
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
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new IntegrationLogEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d6abe9a7-615f-4c39-9ca1-1e6da80ecd30"));
		}

		#endregion

	}

	#endregion

}

