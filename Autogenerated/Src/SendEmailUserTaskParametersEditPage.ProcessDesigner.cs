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
	using System.Text;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using UIControls = Terrasoft.UI.WebControls.Controls;

	#region Class: SendEmailUserTaskParametersEditPageSchema

	/// <exclude/>
	public class SendEmailUserTaskParametersEditPageSchema : Terrasoft.WebApp.BaseProcessParametersEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _userTaskTitleEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit UserTaskTitleEdit {
			get {
				return _userTaskTitleEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout3;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return _controlLayout3;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _senderEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit SenderEdit {
			get {
				return _senderEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _importanceEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit ImportanceEdit {
			get {
				return _importanceEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _recepientEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit RecepientEdit {
			get {
				return _recepientEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _copyRecepientEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CopyRecepientEdit {
			get {
				return _copyRecepientEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _blindCopyRecepientEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit BlindCopyRecepientEdit {
			get {
				return _blindCopyRecepientEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _subjectEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit SubjectEdit {
			get {
				return _subjectEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _isIgnoreErrorsEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox IsIgnoreErrorsEdit {
			get {
				return _isIgnoreErrorsEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return _controlLayout2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.HtmlEdit _bodyEdit;
		public Terrasoft.UI.WebControls.Controls.HtmlEdit BodyEdit {
			get {
				return _bodyEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public SendEmailUserTaskParametersEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SendEmailUserTaskParametersEditPageSchema(SendEmailUserTaskParametersEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			RealUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			Name = "SendEmailUserTaskParametersEditPage";
			ParentSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b");
			Height = 600;
			HelpContextId = "352";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSendEmailUserTaskParametersEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateBottomControlLayout();
			UpdateCancelButton();
			UpdateOkButton();
			UpdateContextHelpButton();
			UpdateTopControlLayout();
			TopLevelControl.MoveItem(0, MainMessagePanel);
			TopLevelControl.MoveItem(1, TopControlLayout);
			TopControlLayout.InsertItem(0, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateUserTaskTitleEdit());
			ControlLayout1.InsertItem(1, CreateControlLayout3());
			ControlLayout3.InsertItem(0, CreateSenderEdit());
			ControlLayout3.InsertItem(1, CreateImportanceEdit());
			ControlLayout1.InsertItem(2, CreateRecepientEdit());
			ControlLayout1.InsertItem(3, CreateCopyRecepientEdit());
			ControlLayout1.InsertItem(4, CreateBlindCopyRecepientEdit());
			ControlLayout1.InsertItem(5, CreateSubjectEdit());
			ControlLayout1.InsertItem(6, CreateIsIgnoreErrorsEdit());
			TopControlLayout.InsertItem(1, CreateControlLayout2());
			ControlLayout2.InsertItem(0, CreateBodyEdit());
			TopLevelControl.MoveItem(2, BottomControlLayout);
			BottomControlLayout.MoveItem(0, ContextHelpButton);
			BottomControlLayout.MoveItem(1, Spacer1);
			BottomControlLayout.MoveItem(2, OkButton);
			BottomControlLayout.MoveItem(3, CancelButton);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSendEmailUserTaskParametersEditPageEventsProcessSchema() {
			var schema = new SendEmailUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateUserTaskTitleEdit() {
			_userTaskTitleEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_userTaskTitleEdit.UId = new Guid("aa8ec7a0-1f85-4edd-86af-546ccca366c4");
			_userTaskTitleEdit.Name = "UserTaskTitleEdit";
			_userTaskTitleEdit.CreatedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			_userTaskTitleEdit.ModifiedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			_userTaskTitleEdit.CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b");
			_userTaskTitleEdit.Tag = "";
			_userTaskTitleEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_userTaskTitleEdit.Image = new ControlImage {};
			_userTaskTitleEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _userTaskTitleEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateSenderEdit() {
			_senderEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_senderEdit.UId = new Guid("a15b9a37-b58f-4460-9527-17658857089f");
			_senderEdit.Name = "SenderEdit";
			_senderEdit.CreatedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			_senderEdit.ModifiedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			_senderEdit.CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b");
			_senderEdit.Tag = "";
			_senderEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_senderEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			_senderEdit.Image = new ControlImage {};
			_senderEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _senderEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateImportanceEdit() {
			_importanceEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_importanceEdit.UId = new Guid("fabc891c-f88f-415d-b293-2f2839a755b1");
			_importanceEdit.Name = "ImportanceEdit";
			_importanceEdit.CreatedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			_importanceEdit.ModifiedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			_importanceEdit.CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b");
			_importanceEdit.Tag = "";
			_importanceEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_importanceEdit.Image = new ControlImage {};
			_importanceEdit.AlignedByCaption = false;
			return _importanceEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout3() {
			_controlLayout3 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout3.UId = new Guid("bd96d1ba-b133-4b2c-b091-a5620940400f");
			_controlLayout3.Name = "ControlLayout3";
			_controlLayout3.CreatedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			_controlLayout3.ModifiedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			_controlLayout3.CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b");
			_controlLayout3.Tag = "";
			_controlLayout3.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout3.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout3.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout3.FitHeightByContent = true;
			_controlLayout3.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout3.StartNewAlignGroup = false;
			_controlLayout3.Image = new ControlImage {};
			_controlLayout3.Edges = "";
			return _controlLayout3;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateRecepientEdit() {
			_recepientEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_recepientEdit.UId = new Guid("97e52ac1-12a0-4f55-a892-a1398fa53774");
			_recepientEdit.Name = "RecepientEdit";
			_recepientEdit.CreatedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			_recepientEdit.ModifiedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			_recepientEdit.CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b");
			_recepientEdit.Tag = "";
			_recepientEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_recepientEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			_recepientEdit.Image = new ControlImage {};
			_recepientEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_recepientEdit.Required = true;
			return _recepientEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateCopyRecepientEdit() {
			_copyRecepientEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_copyRecepientEdit.UId = new Guid("e83ca420-e3ae-4ed1-b461-9a8bf3c15618");
			_copyRecepientEdit.Name = "CopyRecepientEdit";
			_copyRecepientEdit.CreatedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			_copyRecepientEdit.ModifiedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			_copyRecepientEdit.CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b");
			_copyRecepientEdit.Tag = "";
			_copyRecepientEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_copyRecepientEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			_copyRecepientEdit.Image = new ControlImage {};
			_copyRecepientEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _copyRecepientEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateBlindCopyRecepientEdit() {
			_blindCopyRecepientEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_blindCopyRecepientEdit.UId = new Guid("645a6444-acce-4886-a259-309bad78eae9");
			_blindCopyRecepientEdit.Name = "BlindCopyRecepientEdit";
			_blindCopyRecepientEdit.CreatedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			_blindCopyRecepientEdit.ModifiedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			_blindCopyRecepientEdit.CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b");
			_blindCopyRecepientEdit.Tag = "";
			_blindCopyRecepientEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_blindCopyRecepientEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			_blindCopyRecepientEdit.Image = new ControlImage {};
			_blindCopyRecepientEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _blindCopyRecepientEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateSubjectEdit() {
			_subjectEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_subjectEdit.UId = new Guid("2800c5da-dd8d-4a28-b7c7-93e8b9f2ae5f");
			_subjectEdit.Name = "SubjectEdit";
			_subjectEdit.CreatedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			_subjectEdit.ModifiedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			_subjectEdit.CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b");
			_subjectEdit.Tag = "";
			_subjectEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_subjectEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			_subjectEdit.Image = new ControlImage {};
			_subjectEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _subjectEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsIgnoreErrorsEdit() {
			_isIgnoreErrorsEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isIgnoreErrorsEdit.UId = new Guid("b76b3496-0c47-4c5e-987d-92ea9d55b58f");
			_isIgnoreErrorsEdit.Name = "IsIgnoreErrorsEdit";
			_isIgnoreErrorsEdit.CreatedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			_isIgnoreErrorsEdit.ModifiedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			_isIgnoreErrorsEdit.CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b");
			_isIgnoreErrorsEdit.Tag = "";
			_isIgnoreErrorsEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isIgnoreErrorsEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isIgnoreErrorsEdit.AlignedByCaption = false;
			return _isIgnoreErrorsEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("055d9085-0f01-4750-8574-9e49edd3b0a5");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			_controlLayout1.ModifiedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			_controlLayout1.CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b");
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

		protected virtual Terrasoft.UI.WebControls.Controls.HtmlEdit CreateBodyEdit() {
			_bodyEdit = new Terrasoft.UI.WebControls.Controls.HtmlEdit();
			_bodyEdit.UId = new Guid("dbf1c16e-42f9-4008-af08-c6ff7c18e472");
			_bodyEdit.Name = "BodyEdit";
			_bodyEdit.CreatedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			_bodyEdit.ModifiedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			_bodyEdit.CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b");
			_bodyEdit.Tag = "";
			_bodyEdit.Edges = "";
			_bodyEdit.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_bodyEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_bodyEdit.ImageButtonVisible = false;
			return _bodyEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout2() {
			_controlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout2.UId = new Guid("a6b3a938-215e-40b3-b1ba-911fb33fa22a");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			_controlLayout2.ModifiedInSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			_controlLayout2.CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b");
			_controlLayout2.Tag = "";
			_controlLayout2.Height = System.Web.UI.WebControls.Unit.Percentage(50);
			_controlLayout2.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout2.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout2.StartNewAlignGroup = false;
			_controlLayout2.Image = new ControlImage {};
			_controlLayout2.Edges = "1 1 1 1";
			return _controlLayout2;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new SendEmailUserTaskParametersEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new SendEmailUserTaskParametersEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SendEmailUserTaskParametersEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SendEmailUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class SendEmailUserTaskParametersEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SendEmailUserTaskParametersEditPageSchemaUserControl
	{

		public SendEmailUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SendEmailUserTaskParametersEditPageEventsProcess";
			SchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
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

		public virtual Object ImportanceDictionary {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcessOkButtonClick;
		public ProcessFlowElement EventSubProcessOkButtonClick {
			get {
				return _eventSubProcessOkButtonClick ?? (_eventSubProcessOkButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessOkButtonClick",
					SchemaElementUId = new Guid("64e8327c-5b26-4764-b51c-dd6dd570ca4f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _okButtonClickStartMessage;
		public ProcessFlowElement OkButtonClickStartMessage {
			get {
				return _okButtonClickStartMessage ?? (_okButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OkButtonClickStartMessage",
					SchemaElementUId = new Guid("6846d1fd-46bb-483f-b378-d2c0608f826d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("90474f65-9ebd-439f-be1c-4e5a080a79c8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OkButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptTaskOkButtonClick;
		public ProcessScriptTask ScriptTaskOkButtonClick {
			get {
				return _scriptTaskOkButtonClick ?? (_scriptTaskOkButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskOkButtonClick",
					SchemaElementUId = new Guid("e11ff6dd-5118-4559-abdd-fa6abcd64f4c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskOkButtonClickExecute,
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
					SchemaElementUId = new Guid("b5c2cfe6-3b70-4856-b0be-e9587f95718c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptChildInit;
		public ProcessScriptTask ScriptChildInit {
			get {
				return _scriptChildInit ?? (_scriptChildInit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildInit",
					SchemaElementUId = new Guid("545d7b4d-0c96-443d-a318-d6c916a003e5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildInitExecute,
				});
			}
		}

		private ProcessFlowElement _startMessageChildInit;
		public ProcessFlowElement StartMessageChildInit {
			get {
				return _startMessageChildInit ?? (_startMessageChildInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChildInit",
					SchemaElementUId = new Guid("8073d5f5-80cb-46c2-9363-f00b01162333"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("358acde1-5cb4-4f97-8cc3-b5cdeeaebc87"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("96dd539d-238e-4960-bf8a-394cd850c351"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessagePageLoadComplete;
		public ProcessFlowElement StartMessagePageLoadComplete {
			get {
				return _startMessagePageLoadComplete ?? (_startMessagePageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessagePageLoadComplete",
					SchemaElementUId = new Guid("88812a24-ab46-4ae8-aa03-069430ecf7bf"),
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
					SchemaElementUId = new Guid("37c098fe-4948-4bc2-9d57-2897f105c539"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _pageLoadCompleteChildScript;
		public ProcessScriptTask PageLoadCompleteChildScript {
			get {
				return _pageLoadCompleteChildScript ?? (_pageLoadCompleteChildScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageLoadCompleteChildScript",
					SchemaElementUId = new Guid("8e40b124-3ba1-4df4-b3d5-5589ad4ad273"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteChildScriptExecute,
				});
			}
		}

		private LocalizableString _lowMailImportance;
		public LocalizableString LowMailImportance {
			get {
				return _lowMailImportance ?? (_lowMailImportance = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.LowMailImportance.Value"));
			}
		}

		private LocalizableString _normalMailImportance;
		public LocalizableString NormalMailImportance {
			get {
				return _normalMailImportance ?? (_normalMailImportance = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.NormalMailImportance.Value"));
			}
		}

		private LocalizableString _highMailImportance;
		public LocalizableString HighMailImportance {
			get {
				return _highMailImportance ?? (_highMailImportance = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.HighMailImportance.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcessOkButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessOkButtonClick };
			FlowElements[OkButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickStartMessage };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[ScriptTaskOkButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskOkButtonClick };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[ScriptChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildInit };
			FlowElements[StartMessageChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChildInit };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[StartMessagePageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessagePageLoadComplete };
			FlowElements[IntermediateThrowMessageEvent3.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent3 };
			FlowElements[PageLoadCompleteChildScript.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChildScript };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcessOkButtonClick":
						break;
					case "OkButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTaskOkButtonClick");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "ScriptTaskOkButtonClick":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "EventSubProcess2":
						break;
					case "ScriptChildInit":
						break;
					case "StartMessageChildInit":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "IntermediateThrowMessageEvent2":
						e.Context.QueueTasks.Enqueue("ScriptChildInit");
						break;
					case "EventSubProcess3":
						break;
					case "StartMessagePageLoadComplete":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent3");
						break;
					case "IntermediateThrowMessageEvent3":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteChildScript");
						break;
					case "PageLoadCompleteChildScript":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("OkButtonClickStartMessage");
			ActivatedEventElements.Add("StartMessageChildInit");
			ActivatedEventElements.Add("StartMessagePageLoadComplete");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcessOkButtonClick":
					context.QueueTasks.Dequeue();
					break;
				case "OkButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickStartMessage";
					result = OkButtonClickStartMessage.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OkButtonClick");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "ScriptTaskOkButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskOkButtonClick";
					result = ScriptTaskOkButtonClick.Execute(context, ScriptTaskOkButtonClickExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptChildInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildInit";
					result = ScriptChildInit.Execute(context, ScriptChildInitExecute);
					break;
				case "StartMessageChildInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChildInit";
					result = StartMessageChildInit.Execute(context);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent2.Execute(context);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessagePageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessagePageLoadComplete";
					result = StartMessagePageLoadComplete.Execute(context);
					break;
				case "IntermediateThrowMessageEvent3":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent3.Execute(context);
					break;
				case "PageLoadCompleteChildScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteChildScript";
					result = PageLoadCompleteChildScript.Execute(context, PageLoadCompleteChildScriptExecute);
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
				case "ImportanceDictionary":
					ImportanceDictionary = reader.GetSerializableObjectValue();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTaskOkButtonClickExecute(ProcessExecutingContext context) {
			ElementNewCaption = Page.UserTaskTitleEdit.Text;
			var parametersValue = ParametersValue as Dictionary<string, ProcessSchemaParameterValue>;
			if (parametersValue == null) {
				ParametersValue = (parametersValue = new Dictionary<string, ProcessSchemaParameterValue>());
			}
			parametersValue["Importance"] = new ProcessSchemaParameterValue() {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Page.ImportanceEdit.SelectedItem.Value,
				ModifiedInSchemaUId = EditSchemaUId,
			};
			return true;
		}

		public virtual bool ScriptChildInitExecute(ProcessExecutingContext context) {
			InitImportanceEditControl();
			if (!Ext.IsAjaxRequest) {
				var defValues = DefaultValues as Dictionary<string, ProcessSchemaParameterValue>;
				Page.UserTaskTitleEdit.Text = ElementNewCaption;
				var descriptor = Descriptor as DesignModeClassDescriptor;
				FillPropertyDataSource(Source, descriptor);
				var propertyDataSource = PropertyDataSource as VirtualDataSource;
				propertyDataSource.SetClientActiveRow();
				BindEditors(GetEditorsBinding(), propertyDataSource, defValues);
				SetImportanceEditControlsDefValue(propertyDataSource);
			}
			Page.SenderEdit.CustomConfig.Add(new ConfigItem("showLookupEditToolButton", "true"));
			Page.SenderEdit.LookupFilters.Add(new Dictionary<string, object> { 
				 {"comparisonType", FilterComparisonType.Equal},
				 {"leftExpressionColumnPath", "SendEmailsViaThisAccount"},
				 {"useDisplayValue", false }, 
				 {"rightExpressionParameterValues", new object[] { true }}
			});
			return true;
		}

		public virtual bool PageLoadCompleteChildScriptExecute(ProcessExecutingContext context) {
			return true;
		}

		public override Dictionary<string, Terrasoft.UI.WebControls.WebControl> GetEditorsBinding() {
			return new Dictionary<string, Terrasoft.UI.WebControls.WebControl> {
				{ "Sender", Page.SenderEdit },
				{ "Recepient", Page.RecepientEdit },
				{ "CopyRecepient", Page.CopyRecepientEdit },
				{ "BlindCopyRecepient", Page.BlindCopyRecepientEdit },
				{ "Subject", Page.SubjectEdit },
				{ "Body", Page.BodyEdit },
				{ "IsIgnoreErrors", Page.IsIgnoreErrorsEdit }
			};
		}

		public override void MakeCaption() {
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = string.IsNullOrEmpty(Page.UserTaskTitleEdit.Text) ?
				ElementNewCaption : Page.UserTaskTitleEdit.Text;
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public virtual void InitImportanceEditControl() {
			Page.ImportanceEdit.Items.Add(new UIControls.ListItem(LowMailImportance, "0"));
			Page.ImportanceEdit.Items.Add(new UIControls.ListItem(NormalMailImportance, "1"));
			Page.ImportanceEdit.Items.Add(new UIControls.ListItem(HighMailImportance, "2"));
			ImportanceDictionary = new Dictionary<string, string> {
					{ "0", LowMailImportance },
					{ "1", NormalMailImportance },
					{ "2", HighMailImportance }
				};
		}

		public virtual void SetImportanceEditControlsDefValue(VirtualDataSource propertyDataSource) {
			Entity row = propertyDataSource.Rows.First.Value;
			string importanceValue = row.GetColumnValue("Importance").ToString();
			var sb = new StringBuilder(256);
			sb.Append(Page.ImportanceEdit.ClientID);
			sb.Append(".setValueAndText(\"");
			sb.Append(importanceValue);
			sb.Append("\", \"");
			sb.Append(((Dictionary<string, string>)ImportanceDictionary)[importanceValue]);
			sb.Append("\");");
			Page.AddScript(sb.ToString());
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("OkButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("OkButtonClickStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("StartMessageChildInit")) {
							context.QueueTasks.Enqueue("StartMessageChildInit");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessagePageLoadComplete")) {
							context.QueueTasks.Enqueue("StartMessagePageLoadComplete");
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
			if (ImportanceDictionary != null) {
				if (ImportanceDictionary.GetType().IsSerializable ||
					ImportanceDictionary.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ImportanceDictionary", ImportanceDictionary, null);
				}
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SendEmailUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class SendEmailUserTaskParametersEditPageEventsProcess : SendEmailUserTaskParametersEditPageEventsProcess<Terrasoft.WebApp.SendEmailUserTaskParametersEditPageSchemaUserControl>
	{

		public SendEmailUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SendEmailUserTaskParametersEditPageSchemaUserControl

	/// <exclude/>
	public partial class SendEmailUserTaskParametersEditPageSchemaUserControl : Terrasoft.WebApp.BaseProcessParametersEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit UserTaskTitleEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("UserTaskTitleEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout3", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit SenderEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("SenderEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit ImportanceEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("ImportanceEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit RecepientEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("RecepientEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CopyRecepientEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("CopyRecepientEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit BlindCopyRecepientEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("BlindCopyRecepientEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit SubjectEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("SubjectEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox IsIgnoreErrorsEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("IsIgnoreErrorsEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.HtmlEdit BodyEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.HtmlEdit)PageContainer.FindPageControl("BodyEdit", true);
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
			var process = (SendEmailUserTaskParametersEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SendEmailUserTaskParametersEditPageEventsProcess(UserConnection);
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
			SchemaName = "SendEmailUserTaskParametersEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: SendEmailUserTaskParametersEditPageEventsProcessSchema

	/// <exclude/>
	public class SendEmailUserTaskParametersEditPageEventsProcessSchema : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public SendEmailUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SendEmailUserTaskParametersEditPageEventsProcessSchema(SendEmailUserTaskParametersEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SendEmailUserTaskParametersEditPageEventsProcess";
			UId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd");
			CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateImportanceDictionaryParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("cb6bb942-54d3-470d-9165-feed2ded756c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				Name = @"ImportanceDictionary",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateImportanceDictionaryParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess eventsubprocessokbuttonclick = CreateEventSubProcessOkButtonClickEventSubProcess();
			FlowElements.Add(eventsubprocessokbuttonclick);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaStartMessageEvent okbuttonclickstartmessage = CreateOkButtonClickStartMessageStartMessageEvent();
			eventsubprocessokbuttonclick.FlowElements.Add(okbuttonclickstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocessokbuttonclick.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask scripttaskokbuttonclick = CreateScriptTaskOkButtonClickScriptTask();
			eventsubprocessokbuttonclick.FlowElements.Add(scripttaskokbuttonclick);
			ProcessSchemaScriptTask scriptchildinit = CreateScriptChildInitScriptTask();
			eventsubprocess2.FlowElements.Add(scriptchildinit);
			ProcessSchemaStartMessageEvent startmessagechildinit = CreateStartMessageChildInitStartMessageEvent();
			eventsubprocess2.FlowElements.Add(startmessagechildinit);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaStartMessageEvent startmessagepageloadcomplete = CreateStartMessagePageLoadCompleteStartMessageEvent();
			eventsubprocess3.FlowElements.Add(startmessagepageloadcomplete);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent3 = CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent();
			eventsubprocess3.FlowElements.Add(intermediatethrowmessageevent3);
			ProcessSchemaScriptTask pageloadcompletechildscript = CreatePageLoadCompleteChildScriptScriptTask();
			eventsubprocess3.FlowElements.Add(pageloadcompletechildscript);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateLowMailImportanceLocalizableString());
			LocalizableStrings.Add(CreateNormalMailImportanceLocalizableString());
			LocalizableStrings.Add(CreateHighMailImportanceLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateLowMailImportanceLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2969df56-9db3-4afa-b27a-c8ad02a680d2"),
				Name = "LowMailImportance",
				CreatedInPackageId = new Guid("f92f6bea-5f0b-420e-8adc-843ed74daca8"),
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNormalMailImportanceLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("66133e3c-a360-439e-9c16-f6751fed49e4"),
				Name = "NormalMailImportance",
				CreatedInPackageId = new Guid("f92f6bea-5f0b-420e-8adc-843ed74daca8"),
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateHighMailImportanceLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5626a6e4-6003-4e71-b99b-1d2a19ca582b"),
				Name = "HighMailImportance",
				CreatedInPackageId = new Guid("f92f6bea-5f0b-420e-8adc-843ed74daca8"),
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("57a44ccb-4061-4288-bacd-ded96e15a767"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6846d1fd-46bb-483f-b378-d2c0608f826d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e11ff6dd-5118-4559-abdd-fa6abcd64f4c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("ad69de1b-0d77-4699-92a5-2d5aa46de660"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e11ff6dd-5118-4559-abdd-fa6abcd64f4c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("90474f65-9ebd-439f-be1c-4e5a080a79c8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("0a87a092-ce02-48ce-ad30-3bfc01b00ca0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				CurveCenterPosition = new Point(264, 258),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("358acde1-5cb4-4f97-8cc3-b5cdeeaebc87"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("545d7b4d-0c96-443d-a318-d6c916a003e5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("8c9bfed2-b2a1-4312-a555-89ae7528372b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				CurveCenterPosition = new Point(162, 260),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8073d5f5-80cb-46c2-9363-f00b01162333"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("358acde1-5cb4-4f97-8cc3-b5cdeeaebc87"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("7fed0c46-86c9-45a7-999b-d9168d9e57a2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				CurveCenterPosition = new Point(160, 440),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("88812a24-ab46-4ae8-aa03-069430ecf7bf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("37c098fe-4948-4bc2-9d57-2897f105c539"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("5229d411-52dc-4401-98ba-73d299f4ce21"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				CurveCenterPosition = new Point(262, 440),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("37c098fe-4948-4bc2-9d57-2897f105c539"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8e40b124-3ba1-4df4-b3d5-5589ad4ad273"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("9f30a437-ee57-4dee-b23a-b33c71e823c1"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1199, 522),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("cb10226d-a2a9-402c-95b1-5e36b0f0185f"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("9f30a437-ee57-4dee-b23a-b33c71e823c1"),
				CreatedInOwnerSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 156),
				Size = new Size(1170, 366),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("0e4784b5-0cca-43c6-af32-5463fd00e7ec"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("9f30a437-ee57-4dee-b23a-b33c71e823c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				Name = @"Lane2",
				Position = new Point(29, 0),
				Size = new Size(1170, 151),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessOkButtonClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessOkButtonClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("64e8327c-5b26-4764-b51c-dd6dd570ca4f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0e4784b5-0cca-43c6-af32-5463fd00e7ec"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				Name = @"EventSubProcessOkButtonClick",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(269, 130),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessOkButtonClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOkButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6846d1fd-46bb-483f-b378-d2c0608f826d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("64e8327c-5b26-4764-b51c-dd6dd570ca4f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				Name = @"OkButtonClickStartMessage",
				Position = new Point(29, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("90474f65-9ebd-439f-be1c-4e5a080a79c8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("64e8327c-5b26-4764-b51c-dd6dd570ca4f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				Name = @"IntermediateThrowMessageEvent1",
				Position = new Point(218, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskOkButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e11ff6dd-5118-4559-abdd-fa6abcd64f4c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("64e8327c-5b26-4764-b51c-dd6dd570ca4f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				Name = @"ScriptTaskOkButtonClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,205,106,195,48,16,132,207,53,248,29,68,78,54,4,191,64,234,94,210,28,124,104,9,216,233,165,244,176,200,155,84,84,63,102,181,106,90,74,222,189,138,92,28,154,254,64,142,26,230,155,145,70,43,141,6,45,223,227,126,9,3,43,103,69,45,214,176,195,106,227,145,58,240,47,157,98,141,171,94,113,213,225,27,47,242,236,21,72,12,64,96,144,145,252,3,232,128,137,249,174,128,23,183,74,30,3,129,222,175,61,147,178,187,185,88,147,147,232,125,43,159,209,192,132,36,226,38,70,171,173,40,126,68,215,194,6,173,75,241,145,103,87,231,45,245,47,126,97,113,127,105,119,81,150,177,254,144,103,103,105,143,179,198,12,142,24,172,196,217,211,87,246,63,65,197,120,205,214,5,146,105,149,191,173,163,167,90,58,235,57,9,243,8,158,214,140,63,112,170,78,243,183,168,81,50,246,13,163,169,38,226,206,245,106,171,162,106,199,146,77,211,71,254,8,76,231,104,59,196,215,17,114,32,43,152,2,46,62,1,136,30,125,170,246,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b5c2cfe6-3b70-4856-b0be-e9587f95718c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cb10226d-a2a9-402c-95b1-5e36b0f0185f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(319, 163),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("545d7b4d-0c96-443d-a318-d6c916a003e5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b5c2cfe6-3b70-4856-b0be-e9587f95718c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				Name = @"ScriptChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(218, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,82,193,110,218,64,16,61,131,196,63,108,125,50,146,229,31,160,141,68,140,91,33,181,21,10,46,151,170,135,137,61,134,77,214,187,206,206,108,0,33,254,189,187,54,129,36,112,178,103,118,222,155,55,111,102,174,37,207,155,214,88,6,93,98,94,73,206,140,102,107,84,60,158,140,134,178,22,241,151,124,199,233,156,166,79,176,123,192,23,135,196,99,113,24,13,7,175,96,69,133,245,10,148,207,137,111,98,134,53,56,197,167,24,72,204,100,201,210,104,176,251,175,196,86,234,117,34,22,214,148,72,180,44,55,216,192,2,44,52,200,104,59,200,157,111,55,88,192,26,211,63,132,182,0,122,46,36,171,78,81,90,224,142,125,135,92,97,131,154,127,227,54,131,54,80,79,206,50,168,180,178,101,99,59,29,231,32,136,64,146,107,253,203,84,152,41,32,186,60,6,236,119,169,148,151,212,162,229,253,12,24,150,198,217,18,227,254,147,188,163,29,191,117,106,175,170,125,199,107,138,208,121,37,45,59,80,151,100,224,184,198,167,75,228,76,73,63,215,212,219,245,138,15,102,219,89,63,184,151,186,10,211,27,75,241,15,228,211,111,200,122,43,227,113,114,67,75,114,89,72,71,225,169,111,238,214,219,208,151,197,215,28,1,120,28,13,187,77,44,81,87,104,187,21,100,142,216,52,30,95,203,117,58,173,170,88,227,86,244,225,156,177,137,35,218,152,237,79,99,158,93,27,234,11,99,212,189,99,54,58,74,68,196,214,97,52,14,204,159,105,123,132,223,131,63,3,58,243,222,184,28,243,248,132,37,223,137,131,240,115,137,67,84,154,166,5,43,201,232,98,223,162,111,210,115,100,31,210,105,254,226,55,112,76,122,136,194,154,243,93,107,253,1,122,242,204,40,215,232,5,240,38,40,12,146,242,6,164,162,149,132,98,35,105,90,150,198,105,142,222,192,142,112,38,169,85,176,239,140,243,152,26,20,161,56,38,39,65,86,174,55,239,232,63,30,55,249,250,48,88,63,197,223,127,126,140,224,137,56,122,167,143,193,23,139,236,172,238,146,147,255,47,73,76,0,147,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChildInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8073d5f5-80cb-46c2-9363-f00b01162333"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b5c2cfe6-3b70-4856-b0be-e9587f95718c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				Name = @"StartMessageChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("358acde1-5cb4-4f97-8cc3-b5cdeeaebc87"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b5c2cfe6-3b70-4856-b0be-e9587f95718c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("96dd539d-238e-4960-bf8a-394cd850c351"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cb10226d-a2a9-402c-95b1-5e36b0f0185f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 189),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(328, 163),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessagePageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("88812a24-ab46-4ae8-aa03-069430ecf7bf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("96dd539d-238e-4960-bf8a-394cd850c351"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				Name = @"StartMessagePageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 77),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("37c098fe-4948-4bc2-9d57-2897f105c539"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("96dd539d-238e-4960-bf8a-394cd850c351"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				Name = @"IntermediateThrowMessageEvent3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 77),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteChildScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8e40b124-3ba1-4df4-b3d5-5589ad4ad273"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("96dd539d-238e-4960-bf8a-394cd850c351"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				Name = @"PageLoadCompleteChildScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(218, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateInitImportanceEditControlMethod());
			Methods.Add(CreateSetImportanceEditControlsDefValueMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d4159d90-4d80-4bc4-804d-6cc2ca63435e"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a9b659b5-9ae3-4218-9fe8-8047f8e6b589"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b6881e55-7df2-4cef-8151-adab44274ad1"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "UIControls",
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0840abef-9bb9-452e-a8da-ae98b5fb397d"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e1b12ba7-35df-4582-a18f-8349f8901d2b"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b424ebf7-dbe4-4ba3-91b6-f05370f2faa3"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b")
			});
		}

		protected override SchemaMethod CreateGetEditorsBindingMethod() {
			SchemaMethod method = base.CreateGetEditorsBindingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,140,205,10,130,80,16,133,215,9,189,195,197,181,248,2,69,139,204,133,187,200,162,181,122,39,185,33,51,50,119,36,68,124,247,2,83,26,108,119,126,190,115,24,164,99,52,8,47,115,114,149,56,194,130,251,189,23,118,88,71,230,10,204,133,167,135,196,183,44,190,67,153,16,10,83,227,127,244,193,12,219,96,51,152,48,7,180,192,97,100,206,69,13,241,228,82,235,196,140,209,4,92,160,130,214,1,202,204,44,129,194,18,106,251,21,170,66,133,31,27,135,246,239,102,221,168,97,222,149,79,168,22,250,107,245,55,217,126,121,251,104,85,102,62,171,145,24,82,102,98,63,99,58,157,6,219,96,220,189,1,14,131,217,142,104,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateMakeCaptionMethod() {
			SchemaMethod method = base.CreateMakeCaptionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,140,49,10,194,64,16,0,107,5,255,176,101,210,236,3,20,17,9,87,164,73,44,46,88,159,184,134,195,205,221,177,187,33,250,123,137,96,107,53,205,204,84,151,48,18,158,181,172,132,160,224,73,36,104,126,24,14,45,94,233,214,228,100,146,89,113,21,106,108,66,177,152,19,28,65,77,98,26,177,213,110,102,238,197,77,197,222,213,247,54,40,137,15,250,244,209,152,220,61,26,122,122,89,13,167,221,118,227,152,38,74,214,209,242,59,237,225,79,116,248,0,32,151,60,254,160,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitImportanceEditControlMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fc0d731c-df11-4267-b6f3-f58cf374c623"),
				Name = "InitImportanceEditControl",
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,243,204,45,200,47,42,73,204,75,78,117,77,201,44,209,243,44,73,205,45,214,115,76,73,209,200,75,45,87,8,245,116,206,207,43,41,202,207,41,214,243,201,44,46,1,73,106,248,228,151,251,38,102,230,32,244,233,40,40,25,40,105,106,90,243,114,5,144,101,160,95,126,81,110,98,14,134,153,134,148,152,233,145,153,158,129,97,162,17,196,68,132,152,75,102,114,73,102,126,94,98,81,165,130,173,2,200,40,132,128,77,113,73,81,102,94,186,142,2,132,182,83,168,230,229,226,228,172,6,121,85,71,1,35,8,20,106,117,160,210,134,64,105,108,30,66,168,48,2,170,192,116,158,66,45,80,186,214,26,0,255,45,114,152,147,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetImportanceEditControlsDefValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("60357fa0-9aad-4c1d-a645-fe3206c5e7ea"),
				Name = "SetImportanceEditControlsDefValue",
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6d9db010-f49d-48e6-babf-dbac6a32f8aa"),
				Name = "propertyDataSource",
				CreatedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				ModifiedInSchemaUId = new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "VirtualDataSource",
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,65,107,195,48,12,133,239,131,253,7,227,147,13,197,135,193,118,201,54,72,155,110,244,54,150,178,203,186,131,27,139,34,72,109,35,43,203,242,239,151,57,176,208,244,36,144,190,247,158,164,173,103,228,65,80,232,197,147,136,20,34,16,15,149,101,91,135,142,26,48,239,161,79,230,5,41,177,249,176,109,7,197,237,77,98,66,127,18,120,142,129,216,250,6,242,96,148,143,38,230,21,120,19,218,238,236,115,83,201,221,63,37,181,217,135,58,107,149,30,109,190,45,137,116,28,101,30,122,49,245,215,29,182,14,72,221,221,63,252,17,233,104,202,24,193,59,245,102,79,96,102,171,173,67,54,155,22,193,243,174,186,36,165,73,192,57,187,244,110,15,63,172,14,82,94,34,139,197,23,250,131,92,137,43,137,82,21,54,140,193,91,26,30,167,251,87,98,170,207,122,222,107,134,244,231,34,229,235,42,70,23,57,36,159,86,58,87,55,132,145,213,136,204,95,210,197,47,126,85,82,90,159,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SendEmailUserTaskParametersEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("59b0a0a6-b906-42a3-acdd-fbc7080436fd"));
		}

		#endregion

	}

	#endregion

}

