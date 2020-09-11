namespace Terrasoft.WebApp
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using ServiceStack = ServiceStack.Text;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
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

	#region Class: PreconfiguredPageUserTaskParametersEditPageSchema

	/// <exclude/>
	public class PreconfiguredPageUserTaskParametersEditPageSchema : Terrasoft.WebApp.BaseProcessParametersEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TextEdit _userTaskTitleEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit UserTaskTitleEdit {
			get {
				return _userTaskTitleEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MemoEdit _recommendationEdit;
		public Terrasoft.UI.WebControls.Controls.MemoEdit RecommendationEdit {
			get {
				return _recommendationEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MemoEdit _informationOnStepMemoEdit;
		public Terrasoft.UI.WebControls.Controls.MemoEdit InformationOnStepMemoEdit {
			get {
				return _informationOnStepMemoEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _clientUnitSchemaeEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit ClientUnitSchemaeEdit {
			get {
				return _clientUnitSchemaeEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _entitySchemaLookupEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit EntitySchemaLookupEdit {
			get {
				return _entitySchemaLookupEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _showExecutionPageEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit ShowExecutionPageEdit {
			get {
				return _showExecutionPageEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _entityEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit EntityEdit {
			get {
				return _entityEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _useCardProcessModuleCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox UseCardProcessModuleCheckBox {
			get {
				return _useCardProcessModuleCheckBox;
			}
		}

		#endregion

		#region Constructors: Public

		public PreconfiguredPageUserTaskParametersEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public PreconfiguredPageUserTaskParametersEditPageSchema(PreconfiguredPageUserTaskParametersEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
			RealUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
			Name = "PreconfiguredPageUserTaskParametersEditPage";
			ParentSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			CreatedInPackageId = new Guid("2eb2739e-09fc-468f-bc49-96baa1a33d59");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreatePreconfiguredPageUserTaskParametersEditPageEventsProcessSchema();
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
			TopControlLayout.InsertItem(0, CreateUserTaskTitleEdit());
			TopControlLayout.InsertItem(1, CreateRecommendationEdit());
			TopControlLayout.InsertItem(2, CreateInformationOnStepMemoEdit());
			TopControlLayout.InsertItem(3, CreateClientUnitSchemaeEdit());
			TopControlLayout.InsertItem(4, CreateEntitySchemaLookupEdit());
			TopControlLayout.InsertItem(5, CreateShowExecutionPageEdit());
			TopControlLayout.InsertItem(6, CreateEntityEdit());
			TopControlLayout.InsertItem(7, CreateUseCardProcessModuleCheckBox());
			TopLevelControl.MoveItem(2, BottomControlLayout);
			BottomControlLayout.MoveItem(0, ContextHelpButton);
			BottomControlLayout.MoveItem(1, Spacer1);
			BottomControlLayout.MoveItem(2, OkButton);
			BottomControlLayout.MoveItem(3, CancelButton);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreatePreconfiguredPageUserTaskParametersEditPageEventsProcessSchema() {
			var schema = new PreconfiguredPageUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateUserTaskTitleEdit() {
			_userTaskTitleEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_userTaskTitleEdit.UId = new Guid("16a52b9a-1b1d-4a30-b4ab-3b916b4f14a8");
			_userTaskTitleEdit.Name = "UserTaskTitleEdit";
			_userTaskTitleEdit.CreatedInSchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
			_userTaskTitleEdit.ModifiedInSchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
			_userTaskTitleEdit.CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251");
			_userTaskTitleEdit.Tag = "";
			_userTaskTitleEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_userTaskTitleEdit.Image = new ControlImage {};
			_userTaskTitleEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _userTaskTitleEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MemoEdit CreateRecommendationEdit() {
			_recommendationEdit = new Terrasoft.UI.WebControls.Controls.MemoEdit();
			_recommendationEdit.UId = new Guid("52a7cc31-3ddd-4c69-acc1-4b4aecf3d1b1");
			_recommendationEdit.Name = "RecommendationEdit";
			_recommendationEdit.CreatedInSchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
			_recommendationEdit.ModifiedInSchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
			_recommendationEdit.CreatedInPackageId = new Guid("415f292c-4eb5-4c80-8e80-df146f3cd0dc");
			_recommendationEdit.Tag = "";
			_recommendationEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_recommendationEdit.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_recommendationEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _recommendationEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MemoEdit CreateInformationOnStepMemoEdit() {
			_informationOnStepMemoEdit = new Terrasoft.UI.WebControls.Controls.MemoEdit();
			_informationOnStepMemoEdit.UId = new Guid("37cc51dc-d487-40ff-b8c8-03382516e418");
			_informationOnStepMemoEdit.Name = "InformationOnStepMemoEdit";
			_informationOnStepMemoEdit.CreatedInSchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
			_informationOnStepMemoEdit.ModifiedInSchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
			_informationOnStepMemoEdit.CreatedInPackageId = new Guid("726732c0-931c-4e11-9479-6aff326ae941");
			_informationOnStepMemoEdit.Tag = "";
			_informationOnStepMemoEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_informationOnStepMemoEdit.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_informationOnStepMemoEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _informationOnStepMemoEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateClientUnitSchemaeEdit() {
			_clientUnitSchemaeEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_clientUnitSchemaeEdit.UId = new Guid("fddb8d74-cff9-493b-a498-5db6d38039c2");
			_clientUnitSchemaeEdit.Name = "ClientUnitSchemaeEdit";
			_clientUnitSchemaeEdit.CreatedInSchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
			_clientUnitSchemaeEdit.ModifiedInSchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
			_clientUnitSchemaeEdit.CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251");
			_clientUnitSchemaeEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_clientUnitSchemaeEdit.Tag = "";
			_clientUnitSchemaeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_clientUnitSchemaeEdit.Image = new ControlImage {};
			_clientUnitSchemaeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_clientUnitSchemaeEdit.Required = true;
			_clientUnitSchemaeEdit.LookupSchemaUId = new Guid("46ffda25-af49-4a3d-aa4d-10b43e7154cf");
			return _clientUnitSchemaeEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateEntitySchemaLookupEdit() {
			_entitySchemaLookupEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_entitySchemaLookupEdit.UId = new Guid("7dd3db0c-ce74-4edd-bff3-a26fb6ac5cb1");
			_entitySchemaLookupEdit.Name = "EntitySchemaLookupEdit";
			_entitySchemaLookupEdit.CreatedInSchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
			_entitySchemaLookupEdit.ModifiedInSchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
			_entitySchemaLookupEdit.CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4");
			_entitySchemaLookupEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_entitySchemaLookupEdit.Tag = "";
			_entitySchemaLookupEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_entitySchemaLookupEdit.Image = new ControlImage {};
			_entitySchemaLookupEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_entitySchemaLookupEdit.LookupSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111");
			_entitySchemaLookupEdit.LookupPageSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			return _entitySchemaLookupEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateShowExecutionPageEdit() {
			_showExecutionPageEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_showExecutionPageEdit.UId = new Guid("510602b1-1ac5-4a43-ace5-1aa4f9c70748");
			_showExecutionPageEdit.Name = "ShowExecutionPageEdit";
			_showExecutionPageEdit.CreatedInSchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
			_showExecutionPageEdit.ModifiedInSchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
			_showExecutionPageEdit.CreatedInPackageId = new Guid("280c479b-4214-48d2-8ad6-756cf8c224d7");
			_showExecutionPageEdit.Tag = "";
			_showExecutionPageEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_showExecutionPageEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			_showExecutionPageEdit.Image = new ControlImage {};
			_showExecutionPageEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_showExecutionPageEdit.Hidden = true;
			return _showExecutionPageEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateEntityEdit() {
			_entityEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_entityEdit.UId = new Guid("4415e8c1-4726-4df7-802b-47ef060d750d");
			_entityEdit.Name = "EntityEdit";
			_entityEdit.CreatedInSchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
			_entityEdit.ModifiedInSchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
			_entityEdit.CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251");
			_entityEdit.Tag = "";
			_entityEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_entityEdit.DataValueTypeUId = new Guid("b295071f-7ea9-4e62-8d1a-919bf3732ff2");
			_entityEdit.Image = new ControlImage {};
			_entityEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_entityEdit.Enabled = false;
			return _entityEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateUseCardProcessModuleCheckBox() {
			_useCardProcessModuleCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_useCardProcessModuleCheckBox.UId = new Guid("8827c077-f969-431c-bb32-ab408af0dcdb");
			_useCardProcessModuleCheckBox.Name = "UseCardProcessModuleCheckBox";
			_useCardProcessModuleCheckBox.CreatedInSchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
			_useCardProcessModuleCheckBox.ModifiedInSchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
			_useCardProcessModuleCheckBox.CreatedInPackageId = new Guid("f92f6bea-5f0b-420e-8adc-843ed74daca8");
			_useCardProcessModuleCheckBox.Tag = "";
			_useCardProcessModuleCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_useCardProcessModuleCheckBox.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_useCardProcessModuleCheckBox.AlignedByCaption = false;
			_useCardProcessModuleCheckBox.Hidden = true;
			return _useCardProcessModuleCheckBox;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new PreconfiguredPageUserTaskParametersEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new PreconfiguredPageUserTaskParametersEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new PreconfiguredPageUserTaskParametersEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: PreconfiguredPageUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class PreconfiguredPageUserTaskParametersEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.PreconfiguredPageUserTaskParametersEditPageSchemaUserControl
	{

		public PreconfiguredPageUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "PreconfiguredPageUserTaskParametersEditPageEventsProcess";
			SchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
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

		public virtual Guid EntitySchemaUId {
			get;
			set;
		}

		public virtual Guid EntitySchemaEditOldValue {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcessPreconfiguredFormInit;
		public ProcessFlowElement EventSubProcessPreconfiguredFormInit {
			get {
				return _eventSubProcessPreconfiguredFormInit ?? (_eventSubProcessPreconfiguredFormInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessPreconfiguredFormInit",
					SchemaElementUId = new Guid("9f994e14-b7f8-4a3f-be31-282c1c7f7e1e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _initStartMessage;
		public ProcessFlowElement InitStartMessage {
			get {
				return _initStartMessage ?? (_initStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InitStartMessage",
					SchemaElementUId = new Guid("485786b7-a3e1-42ee-8752-2f0f252e9252"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _initIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent InitIntermediateThrowMessageEvent {
			get {
				return _initIntermediateThrowMessageEvent ?? (_initIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "InitIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("18d3af5f-055c-4304-ba51-6f911f24bd5c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _initScriptTask;
		public ProcessScriptTask InitScriptTask {
			get {
				return _initScriptTask ?? (_initScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitScriptTask",
					SchemaElementUId = new Guid("20f367b1-c524-4fb9-99f5-0cbb94641ec4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessPressedButtonOK;
		public ProcessFlowElement EventSubProcessPressedButtonOK {
			get {
				return _eventSubProcessPressedButtonOK ?? (_eventSubProcessPressedButtonOK = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessPressedButtonOK",
					SchemaElementUId = new Guid("e4f84319-5360-4e6e-b260-255d75628353"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _okButtonClickPreconfiguredFormStartMessage;
		public ProcessFlowElement OkButtonClickPreconfiguredFormStartMessage {
			get {
				return _okButtonClickPreconfiguredFormStartMessage ?? (_okButtonClickPreconfiguredFormStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OkButtonClickPreconfiguredFormStartMessage",
					SchemaElementUId = new Guid("909f1dcc-eceb-43a4-8b9f-840ea80df3a1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _okButtonClickPreconfiguredFormScriptTask;
		public ProcessScriptTask OkButtonClickPreconfiguredFormScriptTask {
			get {
				return _okButtonClickPreconfiguredFormScriptTask ?? (_okButtonClickPreconfiguredFormScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OkButtonClickPreconfiguredFormScriptTask",
					SchemaElementUId = new Guid("6214c098-3b9b-45d2-8a29-cda92a00139c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OkButtonClickPreconfiguredFormScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _okButtonClickIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent OkButtonClickIntermediateThrowMessageEvent {
			get {
				return _okButtonClickIntermediateThrowMessageEvent ?? (_okButtonClickIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "OkButtonClickIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("6c718c71-90c8-4de1-8503-d242f3c5d765"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OkButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteEventSubProcess;
		public ProcessFlowElement PageLoadCompleteEventSubProcess {
			get {
				return _pageLoadCompleteEventSubProcess ?? (_pageLoadCompleteEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageLoadCompleteEventSubProcess",
					SchemaElementUId = new Guid("55ec07b6-0184-4a92-b34a-9fde76f8da50"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoqdCompleteStartMessage;
		public ProcessFlowElement PageLoqdCompleteStartMessage {
			get {
				return _pageLoqdCompleteStartMessage ?? (_pageLoqdCompleteStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoqdCompleteStartMessage",
					SchemaElementUId = new Guid("ba0d9eed-c5a9-4aca-af0c-05cb0a662bad"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoqdCompleteIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent PageLoqdCompleteIntermediateThrowMessageEvent {
			get {
				return _pageLoqdCompleteIntermediateThrowMessageEvent ?? (_pageLoqdCompleteIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoqdCompleteIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("33de6576-bc52-4dda-95dc-2c87ef03f248"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _pageLoadCompleteScriptTask;
		public ProcessScriptTask PageLoadCompleteScriptTask {
			get {
				return _pageLoadCompleteScriptTask ?? (_pageLoadCompleteScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageLoadCompleteScriptTask",
					SchemaElementUId = new Guid("bb723294-caf2-4f95-8f08-d74dbca15f34"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _clientUnitSchemaeEditChangeEventSubProcess;
		public ProcessFlowElement ClientUnitSchemaeEditChangeEventSubProcess {
			get {
				return _clientUnitSchemaeEditChangeEventSubProcess ?? (_clientUnitSchemaeEditChangeEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ClientUnitSchemaeEditChangeEventSubProcess",
					SchemaElementUId = new Guid("4b48b8e9-489a-497c-93e6-3818ec4a191a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _clientUnitSchemaeEditChangeStartMessage;
		public ProcessFlowElement ClientUnitSchemaeEditChangeStartMessage {
			get {
				return _clientUnitSchemaeEditChangeStartMessage ?? (_clientUnitSchemaeEditChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ClientUnitSchemaeEditChangeStartMessage",
					SchemaElementUId = new Guid("bd5c23d1-eefe-4712-bf6f-719f5589b54b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _clientUnitSchemaeEditChangeScriptTask;
		public ProcessScriptTask ClientUnitSchemaeEditChangeScriptTask {
			get {
				return _clientUnitSchemaeEditChangeScriptTask ?? (_clientUnitSchemaeEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ClientUnitSchemaeEditChangeScriptTask",
					SchemaElementUId = new Guid("b1e7dc97-0c9c-4ab8-93eb-183dbcc82447"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ClientUnitSchemaeEditChangeScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _entitySchemaLookupEditChangeEventSubProcess;
		public ProcessFlowElement EntitySchemaLookupEditChangeEventSubProcess {
			get {
				return _entitySchemaLookupEditChangeEventSubProcess ?? (_entitySchemaLookupEditChangeEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EntitySchemaLookupEditChangeEventSubProcess",
					SchemaElementUId = new Guid("bc2e309c-013f-4fbf-8c19-49bb49bb2c1a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _entitySchemaLookupEditChangeStartMessage;
		public ProcessFlowElement EntitySchemaLookupEditChangeStartMessage {
			get {
				return _entitySchemaLookupEditChangeStartMessage ?? (_entitySchemaLookupEditChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EntitySchemaLookupEditChangeStartMessage",
					SchemaElementUId = new Guid("aacbbfbc-8d10-46cf-8d75-9f9a9d8525a1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _entitySchemaLookupEditChangeScriptTask;
		public ProcessScriptTask EntitySchemaLookupEditChangeScriptTask {
			get {
				return _entitySchemaLookupEditChangeScriptTask ?? (_entitySchemaLookupEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "EntitySchemaLookupEditChangeScriptTask",
					SchemaElementUId = new Guid("4c5ae6a7-665b-4ef1-ba42-9f08be980458"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EntitySchemaLookupEditChangeScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcessPreconfiguredFormInit.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessPreconfiguredFormInit };
			FlowElements[InitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitStartMessage };
			FlowElements[InitIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { InitIntermediateThrowMessageEvent };
			FlowElements[InitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask };
			FlowElements[EventSubProcessPressedButtonOK.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessPressedButtonOK };
			FlowElements[OkButtonClickPreconfiguredFormStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickPreconfiguredFormStartMessage };
			FlowElements[OkButtonClickPreconfiguredFormScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickPreconfiguredFormScriptTask };
			FlowElements[OkButtonClickIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickIntermediateThrowMessageEvent };
			FlowElements[PageLoadCompleteEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteEventSubProcess };
			FlowElements[PageLoqdCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoqdCompleteStartMessage };
			FlowElements[PageLoqdCompleteIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoqdCompleteIntermediateThrowMessageEvent };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[ClientUnitSchemaeEditChangeEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ClientUnitSchemaeEditChangeEventSubProcess };
			FlowElements[ClientUnitSchemaeEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ClientUnitSchemaeEditChangeStartMessage };
			FlowElements[ClientUnitSchemaeEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ClientUnitSchemaeEditChangeScriptTask };
			FlowElements[EntitySchemaLookupEditChangeEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { EntitySchemaLookupEditChangeEventSubProcess };
			FlowElements[EntitySchemaLookupEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EntitySchemaLookupEditChangeStartMessage };
			FlowElements[EntitySchemaLookupEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EntitySchemaLookupEditChangeScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcessPreconfiguredFormInit":
						break;
					case "InitStartMessage":
						e.Context.QueueTasks.Enqueue("InitIntermediateThrowMessageEvent");
						break;
					case "InitIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("InitScriptTask");
						break;
					case "InitScriptTask":
						break;
					case "EventSubProcessPressedButtonOK":
						break;
					case "OkButtonClickPreconfiguredFormStartMessage":
						e.Context.QueueTasks.Enqueue("OkButtonClickPreconfiguredFormScriptTask");
						break;
					case "OkButtonClickPreconfiguredFormScriptTask":
						e.Context.QueueTasks.Enqueue("OkButtonClickIntermediateThrowMessageEvent");
						break;
					case "OkButtonClickIntermediateThrowMessageEvent":
						break;
					case "PageLoadCompleteEventSubProcess":
						break;
					case "PageLoqdCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoqdCompleteIntermediateThrowMessageEvent");
						break;
					case "PageLoqdCompleteIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						break;
					case "ClientUnitSchemaeEditChangeEventSubProcess":
						break;
					case "ClientUnitSchemaeEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("ClientUnitSchemaeEditChangeScriptTask");
						break;
					case "ClientUnitSchemaeEditChangeScriptTask":
						break;
					case "EntitySchemaLookupEditChangeEventSubProcess":
						break;
					case "EntitySchemaLookupEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("EntitySchemaLookupEditChangeScriptTask");
						break;
					case "EntitySchemaLookupEditChangeScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("InitStartMessage");
			ActivatedEventElements.Add("OkButtonClickPreconfiguredFormStartMessage");
			ActivatedEventElements.Add("PageLoqdCompleteStartMessage");
			ActivatedEventElements.Add("ClientUnitSchemaeEditChangeStartMessage");
			ActivatedEventElements.Add("EntitySchemaLookupEditChangeStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcessPreconfiguredFormInit":
					context.QueueTasks.Dequeue();
					break;
				case "InitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitStartMessage";
					result = InitStartMessage.Execute(context);
					break;
				case "InitIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = InitIntermediateThrowMessageEvent.Execute(context);
					break;
				case "InitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitScriptTask";
					result = InitScriptTask.Execute(context, InitScriptTaskExecute);
					break;
				case "EventSubProcessPressedButtonOK":
					context.QueueTasks.Dequeue();
					break;
				case "OkButtonClickPreconfiguredFormStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickPreconfiguredFormStartMessage";
					result = OkButtonClickPreconfiguredFormStartMessage.Execute(context);
					break;
				case "OkButtonClickPreconfiguredFormScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickPreconfiguredFormScriptTask";
					result = OkButtonClickPreconfiguredFormScriptTask.Execute(context, OkButtonClickPreconfiguredFormScriptTaskExecute);
					break;
				case "OkButtonClickIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OkButtonClick");
					result = OkButtonClickIntermediateThrowMessageEvent.Execute(context);
					break;
				case "PageLoadCompleteEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoqdCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoqdCompleteStartMessage";
					result = PageLoqdCompleteStartMessage.Execute(context);
					break;
				case "PageLoqdCompleteIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoqdCompleteIntermediateThrowMessageEvent.Execute(context);
					break;
				case "PageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask";
					result = PageLoadCompleteScriptTask.Execute(context, PageLoadCompleteScriptTaskExecute);
					break;
				case "ClientUnitSchemaeEditChangeEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ClientUnitSchemaeEditChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ClientUnitSchemaeEditChangeStartMessage";
					result = ClientUnitSchemaeEditChangeStartMessage.Execute(context);
					break;
				case "ClientUnitSchemaeEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ClientUnitSchemaeEditChangeScriptTask";
					result = ClientUnitSchemaeEditChangeScriptTask.Execute(context, ClientUnitSchemaeEditChangeScriptTaskExecute);
					break;
				case "EntitySchemaLookupEditChangeEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "EntitySchemaLookupEditChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EntitySchemaLookupEditChangeStartMessage";
					result = EntitySchemaLookupEditChangeStartMessage.Execute(context);
					break;
				case "EntitySchemaLookupEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "EntitySchemaLookupEditChangeScriptTask";
					result = EntitySchemaLookupEditChangeScriptTask.Execute(context, EntitySchemaLookupEditChangeScriptTaskExecute);
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
				case "EntitySchemaEditOldValue":
					EntitySchemaEditOldValue = reader.GetValue<System.Guid>();
				break;
				case "EntitySchemaUId":
					EntitySchemaUId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool InitScriptTaskExecute(ProcessExecutingContext context) {
			IEnumerable<Guid> packageIds = Terrasoft.Core.Packages.WorkspaceUtilities.GetPackageHierarchyIds(UserConnection, FindDesignedProcessSchema().PackageUId,
				UserConnection.Workspace.Id);
			object[] objectPackageIds = packageIds.Cast<object>().ToArray();
			var packageFilter = new Dictionary<string, object> {
				{ "comparisonType", FilterComparisonType.Equal },
				{ "leftExpressionColumnPath", "SysPackage" },
				{ "useDisplayValue", false },
				{ "rightExpressionParameterValues", objectPackageIds }
			};
			var extendParentFilter = new Dictionary<string, object> {
				{"comparisonType", FilterComparisonType.Equal},
				{"leftExpressionColumnPath", "ExtendParent"},
				{"useDisplayValue", false},
				{"rightExpressionParameterValues", new object[] {false}}};
			Page.ClientUnitSchemaeEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
				var lookupFilters = (Collection<Dictionary<string, object>>)e.Filters;
				lookupFilters.Add(packageFilter);
				lookupFilters.Add(extendParentFilter);
			};
			Page.EntitySchemaLookupEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
				var filters = e.Filters;
				filters.Add(packageFilter);
				filters.Add(extendParentFilter);
			};
			var defValues = DefaultValues as Dictionary<string, ProcessSchemaParameterValue>;
			if (defValues == null) {
				return false;
			}
			ProcessSchemaParameterValue parameter = defValues["EntitySchemaUId"];
			if (!string.IsNullOrEmpty(parameter.Value) && parameter.Source == ProcessSchemaParameterValueSource.Mapping) {
				Page.AddScript(String.Format("{0}.defaultAvailableValueSources = ['Mapping'];", Page.EntityEdit.ClientID));
			}
			if (Ext.IsAjaxRequest) {
				return true;
			}
			Page.UserTaskTitleEdit.Text = ElementNewCaption;
			string userTaskTitle = Page.UserTaskTitleEdit.Text;
			SetDefaultValue(defValues["Title"], userTaskTitle, userTaskTitle, "Title");
			DefaultValues = defValues;
			var descriptor = (DesignModeClassDescriptor)Descriptor;
			FillPropertyDataSource(Source, descriptor);
			var propertyDataSource = (VirtualDataSource)PropertyDataSource;
			propertyDataSource.SetClientActiveRow();
			BindEditors(GetEditorsBinding(), propertyDataSource, defValues);
			return true;
		}

		public virtual bool OkButtonClickPreconfiguredFormScriptTaskExecute(ProcessExecutingContext context) {
			ElementNewCaption = Page.UserTaskTitleEdit.Text;
			var noneVS = ProcessSchemaParameterValueSource.None;
			var constVS = ProcessSchemaParameterValueSource.ConstValue;
			var parametersValue = ParametersValue as Dictionary<string, ProcessSchemaParameterValue>;
			if (parametersValue == null) {
				ParametersValue = (parametersValue = new Dictionary<string, ProcessSchemaParameterValue>());
			}
			bool isEmptyEntitySchemaUId = EntitySchemaUId == Guid.Empty;
			parametersValue["EntitySchemaUId"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = isEmptyEntitySchemaUId ? noneVS : constVS,
				Value = isEmptyEntitySchemaUId ? string.Empty : EntitySchemaUId.ToString()
			};
			if (isEmptyEntitySchemaUId) {
					parametersValue["EntityId"] = new ProcessSchemaParameterValue() {
					ModifiedInSchemaUId = EditSchemaUId,
					Source = noneVS,
					Value = string.Empty
				};
			}
			var clientSchemaId = (Guid)Page.ClientUnitSchemaeEdit.Value;
			Guid clientSchemaUId = GetSchemaUIdById(clientSchemaId);
			parametersValue["ClientUnitSchemaUId"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = constVS,
				Value = clientSchemaUId.ToString()
			};
			var clientUnitSchemaManager = (ClientUnitSchemaManager)UserConnection
				.GetSchemaManager("ClientUnitSchemaManager");
			ClientUnitSchema clientUnitSchema = clientUnitSchemaManager.GetInstanceByUId(clientSchemaUId);
			ClientUnitSchemaParameterCollection clientSchemaParameters = clientUnitSchema.Parameters;
			parametersValue["UseCardProcessModule"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = constVS,
				Value = clientUnitSchema.SchemaType == ClientUnitSchemaType.EditViewModelSchema ? "true" : "false"
			};
			/*
			if (clientSchemaParameters.Count == 0) {
				return true;
			}
			*/
			ProcessSchema schema = FindDesignedProcessSchema();
			var userTask = (ProcessSchemaUserTask)schema.GetBaseElementByUId(EditElementUId);
			var modifiedParameters = new List<ProcessSchemaParameter>(clientSchemaParameters.Count);
			if (clientSchemaParameters.Count > 0) {
				foreach (ClientUnitSchemaParameter clientSchemaParameter in clientSchemaParameters) {
					ProcessSchemaParameter parameter = new ProcessSchemaParameter(schema) {
						UId = clientSchemaParameter.UId,
						Name = clientSchemaParameter.Name,
						Caption = clientSchemaParameter.Caption,
						ContainerUId = userTask.UId,
						DataValueTypeUId = clientSchemaParameter.DataValueTypeUId,
						ReferenceSchemaUId = clientSchemaParameter.ReferenceSchemaUId,
						IsResult = clientSchemaParameter.IsResult,
						SourceValue = {
							ModifiedInSchemaUId = schema.UId
						}
					};
					modifiedParameters.Add(parameter);
				}
			}
			UpdateProcessSchemaUserTaskCustomParameters(schema, userTask, modifiedParameters);
			/*
			if (modifiedParameters.Count != 0) {
				UpdateProcessSchemaUserTaskCustomParameters(schema, userTask, modifiedParameters);
			}
			*/
			return true;
		}

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			var parameters = DefaultValues as Dictionary<string, ProcessSchemaParameterValue>;
			if (parameters == null) {
				return true;
			}
			ProcessSchemaParameterValue parameter = parameters["ClientUnitSchemaUId"];
			if (parameter != null && !string.IsNullOrEmpty(parameter.Value)) {
				var clientUnitSchemaUId = new Guid(parameter.Value);
				var clientUnitSchemaManager = (ClientUnitSchemaManager)UserConnection
					.GetSchemaManager("ClientUnitSchemaManager");
				ISchemaManagerItem<ClientUnitSchema> clientUnitSchemaItem =
					clientUnitSchemaManager.GetItemByUId(clientUnitSchemaUId);
				Page.ClientUnitSchemaeEdit.SetValueAndText(clientUnitSchemaManager.GetItemIdByUId(clientUnitSchemaUId), clientUnitSchemaItem.Name);
			}
			string parameterValue = parameters["EntitySchemaUId"].Value;
			if (!string.IsNullOrEmpty(parameterValue)) {
				EntitySchemaUId = new Guid(parameterValue);
				Guid entitySchemaId = GetSchemaIdByUId(EntitySchemaUId);
				EntitySchemaEditOldValue = entitySchemaId;
				Page.EntitySchemaLookupEdit.SetValueAndText(entitySchemaId,
					UserConnection.EntitySchemaManager.GetItemByUId(EntitySchemaUId).Caption);
				Page.EntityEdit.Enabled = true;
				ProcessSchemaParameterValue paramValue = Page.EntityEdit.ParameterValue;
				paramValue.ReferenceSchemaUId = EntitySchemaUId;
				Page.EntityEdit.Value = paramValue;
				/*
				Page.AddScript(string.Concat("(function(){", Page.EntityEdit.ClientID,
					".constValueEditor.referenceSchemaUId=\"", EntitySchemaUId.ToString(), "\";})();"));
				*/
			}
			//Page.AddScript(String.Format("{0}.defaultAvailableValueSources = ['ConstValue', 'Mapping', 'SystemValue', 'SystemSetting'];", Page.EntityEdit.ClientID));
			return true;
		}

		public virtual bool ClientUnitSchemaeEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool EntitySchemaLookupEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			var entitySchemaId = (Guid)Page.EntitySchemaLookupEdit.Value;
			if (EntitySchemaEditOldValue == entitySchemaId) {
				return true;
			}
			bool isNotEmpty = entitySchemaId != Guid.Empty;
			if (isNotEmpty) {
				EntitySchemaUId = GetSchemaUIdById(entitySchemaId);
			} else {
				EntitySchemaUId = Guid.Empty;
				/*
				Page.AddScript(string.Format("{0}.setValue({1})", Page.EntityEdit.ClientID,
					"{\"source\":\"None\",\"value\":\"\",\"displayValue\":\"\",\"constValueEditor\":{\"xtype\":\"lookupedit\",\"referenceSchemaUId\":\"00000000000000000000000000000000\"}}"));
				*/
			}
			UpdateEntityIdParameterValue();
			Page.EntityEdit.SetRequired(isNotEmpty);
			Page.EntityEdit.Enabled = isNotEmpty;
			EntitySchemaEditOldValue = entitySchemaId;
			return true;
		}

		public override void InitializeSchemaExplorerWindow() {
			base.InitializeSchemaExplorerWindow();
			var schemaExplorer = SchemaExplorer as UIControls.SchemaStructureExplorer;
			schemaExplorer.IncludedDataValueTypes[ParameterDataValueTypeUId] = EntitySchemaUId;
		}

		public override Dictionary<string, Terrasoft.UI.WebControls.WebControl> GetEditorsBinding() {
			return new Dictionary<string, Terrasoft.UI.WebControls.WebControl>() {
				{"EntityId", Page.EntityEdit},
				{"Title", Page.UserTaskTitleEdit},
				{"Recommendation", Page.RecommendationEdit},
				{"InformationOnStep", Page.InformationOnStepMemoEdit},
				{"ShowExecutionPage", Page.ShowExecutionPageEdit},
			};
		}

		public override void MakeCaption() {
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = string.IsNullOrEmpty(Page.UserTaskTitleEdit.Text) ?
				string.Format("{0} ({1})", WindowCaption, NewRecord) : Page.UserTaskTitleEdit.Text;
		}

		public virtual Guid GetSchemaUIdById(Guid schemaId) {
			return
				(new Select(UserConnection)
					.Column("UId")
				.From("SysSchema")
				.Where("Id")
				.IsEqual(Column.Parameter(schemaId)) as Select)
				.ExecuteScalar<Guid>();
		}

		public virtual Guid GetSchemaIdByUId(Guid schemaUId) {
			return
				(new Select(UserConnection)
					.Column("SysSchema", "Id")
				.From("SysSchema")
				.InnerJoin("SysPackage").On("SysPackage", "Id").IsEqual("SysSchema", "SysPackageId")
				.Where("SysSchema", "UId").IsEqual(Column.Parameter(schemaUId))
				.And("SysPackage", "SysWorkspaceId").IsEqual(Column.Parameter(UserConnection.Workspace.Id)) as Select)
				.ExecuteScalar<Guid>();
		}

		public virtual void SetDefEntityEditValue() {
			var entityEditValue = new ProcessSchemaParameterValue() {
				DataValueType = (DataValueType)UserConnection.DataValueTypeManager.GetItemByName("Lookup").Instance,
				ReferenceSchemaUId = EntitySchemaUId
			};
			Page.EntityEdit.Value = entityEditValue;
			/*
			Page.AddScript(String.Format("{0}.defaultAvailableValueSources = ['ConstValue', 'Mapping', 'SystemValue', 'SystemSetting'];", Page.EntityEdit.ClientID));
			Page.AddScript(String.Format("{0}.setReferenceSchemaUId('{1}')", Page.EntityEdit.ClientID, EntitySchemaUId));
			*/
		}

		public virtual void UpdateEntityIdParameterValue() {
			ProcessSchemaParameterValue parameterValue = Page.EntityEdit.ParameterValue;
			parameterValue.ModifiedInSchemaUId = EditSchemaUId;
			parameterValue.ReferenceSchemaUId = EntitySchemaUId;
			parameterValue.Value = null;
			parameterValue.DisplayValue = null;
			parameterValue.Source = ProcessSchemaParameterValueSource.None;
			Page.EntityEdit.Value = parameterValue;
		}

		public override void UpdateProcessSchemaCustomParameter(ProcessSchemaParameter currentParameter, ProcessSchemaParameter modifiedParameter) {
			base.UpdateProcessSchemaCustomParameter(currentParameter, modifiedParameter);
			currentParameter.IsResult = modifiedParameter.IsResult;
		}

		public virtual ProcessSchemaParameter CreateCustomParameter() {
			return null;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("InitStartMessage")) {
							context.QueueTasks.Enqueue("InitStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("OkButtonClickPreconfiguredFormStartMessage")) {
							context.QueueTasks.Enqueue("OkButtonClickPreconfiguredFormStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoqdCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoqdCompleteStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "ClientUnitSchemaeEditChange":
							if (ActivatedEventElements.Contains("ClientUnitSchemaeEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("ClientUnitSchemaeEditChangeStartMessage");
						}
						break;
					case "EntitySchemaLookupEditChange":
							if (ActivatedEventElements.Contains("EntitySchemaLookupEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("EntitySchemaLookupEditChangeStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("EntitySchemaEditOldValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntitySchemaEditOldValue", EntitySchemaEditOldValue, Guid.Empty);
			}
			if (!HasMapping("EntitySchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntitySchemaUId", EntitySchemaUId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: PreconfiguredPageUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class PreconfiguredPageUserTaskParametersEditPageEventsProcess : PreconfiguredPageUserTaskParametersEditPageEventsProcess<Terrasoft.WebApp.PreconfiguredPageUserTaskParametersEditPageSchemaUserControl>
	{

		public PreconfiguredPageUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: PreconfiguredPageUserTaskParametersEditPageSchemaUserControl

	/// <exclude/>
	public partial class PreconfiguredPageUserTaskParametersEditPageSchemaUserControl : Terrasoft.WebApp.BaseProcessParametersEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TextEdit UserTaskTitleEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("UserTaskTitleEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MemoEdit RecommendationEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.MemoEdit)PageContainer.FindPageControl("RecommendationEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MemoEdit InformationOnStepMemoEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.MemoEdit)PageContainer.FindPageControl("InformationOnStepMemoEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit ClientUnitSchemaeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("ClientUnitSchemaeEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit EntitySchemaLookupEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("EntitySchemaLookupEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit ShowExecutionPageEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("ShowExecutionPageEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit EntityEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("EntityEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox UseCardProcessModuleCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("UseCardProcessModuleCheckBox", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			ClientUnitSchemaeEdit.AjaxEvents.Change.Event += ClientUnitSchemaeEditChange;
			EntitySchemaLookupEdit.AjaxEvents.Change.Event += EntitySchemaLookupEditChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			ClientUnitSchemaeEdit.AjaxEvents.Change.Event -= ClientUnitSchemaeEditChange;
			EntitySchemaLookupEdit.AjaxEvents.Change.Event -= EntitySchemaLookupEditChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (PreconfiguredPageUserTaskParametersEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new PreconfiguredPageUserTaskParametersEditPageEventsProcess(UserConnection);
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

		public virtual void ClientUnitSchemaeEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("ClientUnitSchemaeEditChange");
		}

		public virtual void EntitySchemaLookupEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("EntitySchemaLookupEditChange");
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
			SchemaName = "PreconfiguredPageUserTaskParametersEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: PreconfiguredPageUserTaskParametersEditPageEventsProcessSchema

	/// <exclude/>
	public class PreconfiguredPageUserTaskParametersEditPageEventsProcessSchema : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public PreconfiguredPageUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public PreconfiguredPageUserTaskParametersEditPageEventsProcessSchema(PreconfiguredPageUserTaskParametersEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "PreconfiguredPageUserTaskParametersEditPageEventsProcess";
			UId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b");
			CreatedInPackageId = new Guid("2eb2739e-09fc-468f-bc49-96baa1a33d59");
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

		protected virtual ProcessSchemaParameter CreateEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f97a7b05-7837-441d-aa34-1175a1ae382a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaEditOldValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7591278d-e1d3-40a4-b22e-558afa4ead8a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Name = @"EntitySchemaEditOldValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEntitySchemaUIdParameter());
			Parameters.Add(CreateEntitySchemaEditOldValueParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSetPreconfiguredForm = CreateLaneSetPreconfiguredFormLaneSet();
			LaneSets.Add(schemaLaneSetPreconfiguredForm);
			ProcessSchemaLane schemaLanePreconfiguredForm1 = CreateLanePreconfiguredForm1Lane();
			schemaLaneSetPreconfiguredForm.Lanes.Add(schemaLanePreconfiguredForm1);
			ProcessSchemaLane schemaLanePreconfiguredForm2 = CreateLanePreconfiguredForm2Lane();
			schemaLaneSetPreconfiguredForm.Lanes.Add(schemaLanePreconfiguredForm2);
			ProcessSchemaLane schemaLanePreconfiguredForm3 = CreateLanePreconfiguredForm3Lane();
			schemaLaneSetPreconfiguredForm.Lanes.Add(schemaLanePreconfiguredForm3);
			ProcessSchemaEventSubProcess eventsubprocesspreconfiguredforminit = CreateEventSubProcessPreconfiguredFormInitEventSubProcess();
			FlowElements.Add(eventsubprocesspreconfiguredforminit);
			ProcessSchemaEventSubProcess eventsubprocesspressedbuttonok = CreateEventSubProcessPressedButtonOKEventSubProcess();
			FlowElements.Add(eventsubprocesspressedbuttonok);
			ProcessSchemaEventSubProcess pageloadcompleteeventsubprocess = CreatePageLoadCompleteEventSubProcessEventSubProcess();
			FlowElements.Add(pageloadcompleteeventsubprocess);
			ProcessSchemaEventSubProcess clientunitschemaeeditchangeeventsubprocess = CreateClientUnitSchemaeEditChangeEventSubProcessEventSubProcess();
			FlowElements.Add(clientunitschemaeeditchangeeventsubprocess);
			ProcessSchemaEventSubProcess entityschemalookupeditchangeeventsubprocess = CreateEntitySchemaLookupEditChangeEventSubProcessEventSubProcess();
			FlowElements.Add(entityschemalookupeditchangeeventsubprocess);
			ProcessSchemaStartMessageEvent initstartmessage = CreateInitStartMessageStartMessageEvent();
			eventsubprocesspreconfiguredforminit.FlowElements.Add(initstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent initintermediatethrowmessageevent = CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocesspreconfiguredforminit.FlowElements.Add(initintermediatethrowmessageevent);
			ProcessSchemaScriptTask initscripttask = CreateInitScriptTaskScriptTask();
			eventsubprocesspreconfiguredforminit.FlowElements.Add(initscripttask);
			ProcessSchemaStartMessageEvent okbuttonclickpreconfiguredformstartmessage = CreateOkButtonClickPreconfiguredFormStartMessageStartMessageEvent();
			eventsubprocesspressedbuttonok.FlowElements.Add(okbuttonclickpreconfiguredformstartmessage);
			ProcessSchemaScriptTask okbuttonclickpreconfiguredformscripttask = CreateOkButtonClickPreconfiguredFormScriptTaskScriptTask();
			eventsubprocesspressedbuttonok.FlowElements.Add(okbuttonclickpreconfiguredformscripttask);
			ProcessSchemaIntermediateThrowMessageEvent okbuttonclickintermediatethrowmessageevent = CreateOkButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocesspressedbuttonok.FlowElements.Add(okbuttonclickintermediatethrowmessageevent);
			ProcessSchemaStartMessageEvent pageloqdcompletestartmessage = CreatePageLoqdCompleteStartMessageStartMessageEvent();
			pageloadcompleteeventsubprocess.FlowElements.Add(pageloqdcompletestartmessage);
			ProcessSchemaIntermediateThrowMessageEvent pageloqdcompleteintermediatethrowmessageevent = CreatePageLoqdCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			pageloadcompleteeventsubprocess.FlowElements.Add(pageloqdcompleteintermediatethrowmessageevent);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			pageloadcompleteeventsubprocess.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaStartMessageEvent clientunitschemaeeditchangestartmessage = CreateClientUnitSchemaeEditChangeStartMessageStartMessageEvent();
			clientunitschemaeeditchangeeventsubprocess.FlowElements.Add(clientunitschemaeeditchangestartmessage);
			ProcessSchemaScriptTask clientunitschemaeeditchangescripttask = CreateClientUnitSchemaeEditChangeScriptTaskScriptTask();
			clientunitschemaeeditchangeeventsubprocess.FlowElements.Add(clientunitschemaeeditchangescripttask);
			ProcessSchemaStartMessageEvent entityschemalookupeditchangestartmessage = CreateEntitySchemaLookupEditChangeStartMessageStartMessageEvent();
			entityschemalookupeditchangeeventsubprocess.FlowElements.Add(entityschemalookupeditchangestartmessage);
			ProcessSchemaScriptTask entityschemalookupeditchangescripttask = CreateEntitySchemaLookupEditChangeScriptTaskScriptTask();
			entityschemalookupeditchangeeventsubprocess.FlowElements.Add(entityschemalookupeditchangescripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("f304776c-9000-4f65-866b-d54acd1d4933"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				CurveCenterPosition = new Point(168, 93),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("485786b7-a3e1-42ee-8752-2f0f252e9252"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("18d3af5f-055c-4304-ba51-6f911f24bd5c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("92ec41fd-df16-426d-aded-8c4ea054e137"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				CurveCenterPosition = new Point(281, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("18d3af5f-055c-4304-ba51-6f911f24bd5c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("20f367b1-c524-4fb9-99f5-0cbb94641ec4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("17ebc09e-b3b6-4398-b363-cc3c47b50369"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				CurveCenterPosition = new Point(172, 304),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("909f1dcc-eceb-43a4-8b9f-840ea80df3a1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6214c098-3b9b-45d2-8a29-cda92a00139c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("06624260-e37d-4153-94c2-bf28788a8fdb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				CurveCenterPosition = new Point(315, 302),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6214c098-3b9b-45d2-8a29-cda92a00139c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6c718c71-90c8-4de1-8503-d242f3c5d765"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("98b4c389-a79d-47a7-8ef3-aecb2d1688e0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				CurveCenterPosition = new Point(604, 268),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("33de6576-bc52-4dda-95dc-2c87ef03f248"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bb723294-caf2-4f95-8f08-d74dbca15f34"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("6f60476a-8efa-4cba-8643-cb1ad3c410c8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				CurveCenterPosition = new Point(512, 266),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ba0d9eed-c5a9-4aca-af0c-05cb0a662bad"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("33de6576-bc52-4dda-95dc-2c87ef03f248"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("3fd280ec-4dbc-438a-84ef-fba010001adf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bd5c23d1-eefe-4712-bf6f-719f5589b54b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b1e7dc97-0c9c-4ab8-93eb-183dbcc82447"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("5854a9da-f68a-4df7-9197-7275b249cf22"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("aacbbfbc-8d10-46cf-8d75-9f9a9d8525a1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4c5ae6a7-665b-4ef1-ba42-9f08be980458"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSetPreconfiguredFormLaneSet() {
			ProcessSchemaLaneSet schemaLaneSetPreconfiguredForm = new ProcessSchemaLaneSet(this) {
				UId = new Guid("faa703d5-085e-4dc2-83ff-3d8d50c7527e"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Name = @"LaneSetPreconfiguredForm",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(977, 560),
				UseBackgroundMode = false
			};
			return schemaLaneSetPreconfiguredForm;
		}

		protected virtual ProcessSchemaLane CreateLanePreconfiguredForm1Lane() {
			ProcessSchemaLane schemaLanePreconfiguredForm1 = new ProcessSchemaLane(this) {
				UId = new Guid("272165d1-b3cb-4485-9474-d2ca247097bb"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("faa703d5-085e-4dc2-83ff-3d8d50c7527e"),
				CreatedInOwnerSchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Name = @"LanePreconfiguredForm1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 165),
				Size = new Size(948, 194),
				UseBackgroundMode = false
			};
			return schemaLanePreconfiguredForm1;
		}

		protected virtual ProcessSchemaLane CreateLanePreconfiguredForm2Lane() {
			ProcessSchemaLane schemaLanePreconfiguredForm2 = new ProcessSchemaLane(this) {
				UId = new Guid("4126bcbf-aa08-45ed-8fc9-977783af6ae6"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("faa703d5-085e-4dc2-83ff-3d8d50c7527e"),
				CreatedInOwnerSchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Name = @"LanePreconfiguredForm2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 364),
				Size = new Size(948, 196),
				UseBackgroundMode = false
			};
			return schemaLanePreconfiguredForm2;
		}

		protected virtual ProcessSchemaLane CreateLanePreconfiguredForm3Lane() {
			ProcessSchemaLane schemaLanePreconfiguredForm3 = new ProcessSchemaLane(this) {
				UId = new Guid("8e929b86-532e-4200-a912-4cb76e737636"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("faa703d5-085e-4dc2-83ff-3d8d50c7527e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Name = @"LanePreconfiguredForm3",
				Position = new Point(29, 0),
				Size = new Size(948, 160),
				UseBackgroundMode = false
			};
			return schemaLanePreconfiguredForm3;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessPreconfiguredFormInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessPreconfiguredFormInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9f994e14-b7f8-4a3f-be31-282c1c7f7e1e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("272165d1-b3cb-4485-9474-d2ca247097bb"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Name = @"EventSubProcessPreconfiguredFormInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(321, 171),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessPreconfiguredFormInit;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("485786b7-a3e1-42ee-8752-2f0f252e9252"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9f994e14-b7f8-4a3f-be31-282c1c7f7e1e"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Name = @"InitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("18d3af5f-055c-4304-ba51-6f911f24bd5c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9f994e14-b7f8-4a3f-be31-282c1c7f7e1e"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Name = @"InitIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("20f367b1-c524-4fb9-99f5-0cbb94641ec4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9f994e14-b7f8-4a3f-be31-282c1c7f7e1e"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Name = @"InitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(211, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,85,77,79,227,48,16,61,131,196,127,240,230,0,137,54,138,246,78,169,212,77,3,91,105,97,43,218,178,7,212,131,105,38,173,169,19,7,219,1,162,170,255,125,199,113,72,19,21,186,139,180,167,124,120,230,205,188,55,207,246,40,202,138,20,36,125,224,208,187,42,88,220,39,57,93,172,233,18,70,177,34,23,100,10,82,82,37,18,29,132,66,66,48,182,107,42,248,45,228,90,97,36,204,52,227,76,51,252,117,5,186,94,254,193,16,80,46,86,37,98,184,51,5,50,20,89,6,11,205,68,230,147,75,150,197,67,80,108,153,65,60,150,98,1,74,77,22,43,72,169,235,189,193,207,70,177,127,114,124,212,205,220,149,12,70,177,119,126,114,44,30,30,113,229,126,78,236,203,184,221,246,142,67,16,82,165,123,54,164,143,37,166,98,128,140,74,215,32,60,83,249,22,121,201,184,6,137,153,25,188,144,33,171,42,82,89,246,148,150,44,91,250,117,141,62,217,96,95,27,226,44,68,154,83,201,148,200,166,101,14,142,97,101,242,195,206,239,32,122,42,40,39,91,223,230,112,72,116,244,154,75,36,140,224,161,224,69,154,141,169,94,97,182,51,41,85,221,191,211,196,23,10,134,76,229,156,150,119,148,23,166,72,66,185,130,102,93,178,229,170,5,56,166,146,166,128,77,84,209,202,241,247,117,217,158,28,111,107,218,240,170,33,139,49,7,50,253,41,238,159,161,110,59,61,72,60,106,245,225,212,241,31,16,175,87,255,74,219,176,104,188,177,177,169,91,195,123,140,50,4,33,103,88,106,150,49,109,93,7,81,204,116,48,150,128,221,195,79,33,214,69,94,235,241,245,130,196,192,97,73,53,16,215,2,18,133,205,130,244,137,13,52,169,209,51,194,13,228,82,17,240,42,133,140,186,188,133,99,236,232,34,105,110,109,220,251,88,224,190,7,65,157,131,221,30,117,64,130,65,28,187,29,175,122,239,199,236,15,214,4,54,244,163,76,51,93,90,234,59,18,255,155,127,210,48,239,48,74,14,114,73,254,137,133,129,143,33,177,211,198,2,67,72,104,193,117,253,77,213,123,6,238,28,51,93,195,244,17,146,37,196,109,65,226,62,40,56,183,100,36,232,66,102,214,127,166,1,84,241,99,44,60,75,234,79,114,177,235,241,222,105,107,142,71,155,51,175,107,126,177,253,5,35,117,131,5,127,201,40,205,117,233,54,32,65,149,239,145,211,211,29,112,48,17,133,92,128,105,242,64,35,54,40,184,166,121,142,248,150,73,53,125,148,118,178,144,44,215,238,196,150,190,20,50,165,218,117,54,223,182,65,108,149,28,60,83,198,205,117,208,130,50,66,223,159,213,120,103,243,115,220,101,45,55,85,14,178,251,106,52,244,60,171,147,33,136,155,27,201,13,30,233,235,45,60,161,20,186,35,170,150,197,155,166,6,203,156,246,83,170,214,83,166,185,221,148,83,116,1,22,142,56,164,8,125,3,47,33,205,205,104,49,201,42,71,138,118,14,134,30,0,194,164,9,232,182,91,220,214,136,170,88,103,238,119,17,247,62,235,56,67,177,235,187,214,188,27,143,170,74,105,97,204,224,218,11,239,90,196,16,114,170,212,176,89,244,118,175,152,136,86,231,56,215,28,164,46,135,84,83,171,190,107,31,126,11,179,185,189,246,130,77,181,59,38,53,30,191,187,159,222,62,40,2,236,39,7,40,145,29,228,0,55,209,51,220,138,151,234,162,252,142,119,182,81,82,72,229,226,53,95,191,154,191,56,5,215,243,223,233,195,223,41,98,16,218,51,255,3,58,94,117,92,115,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessPressedButtonOKEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessPressedButtonOK = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e4f84319-5360-4e6e-b260-255d75628353"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4126bcbf-aa08-45ed-8fc9-977783af6ae6"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Name = @"EventSubProcessPressedButtonOK",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(341, 175),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessPressedButtonOK;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOkButtonClickPreconfiguredFormStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("909f1dcc-eceb-43a4-8b9f-840ea80df3a1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e4f84319-5360-4e6e-b260-255d75628353"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Name = @"OkButtonClickPreconfiguredFormStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 73),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOkButtonClickPreconfiguredFormScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6214c098-3b9b-45d2-8a29-cda92a00139c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e4f84319-5360-4e6e-b260-255d75628353"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Name = @"OkButtonClickPreconfiguredFormScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 59),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,86,93,111,218,48,20,125,6,137,255,224,229,41,169,80,186,231,173,180,90,41,171,144,214,170,42,208,151,105,15,30,185,180,214,130,131,108,103,29,154,250,223,103,251,218,9,73,28,212,62,84,147,16,40,246,185,95,231,158,123,195,44,135,45,112,117,11,207,83,186,83,172,224,100,66,238,232,35,164,43,9,98,73,229,175,37,83,57,204,50,166,210,37,252,81,159,71,195,223,84,16,94,112,120,88,24,168,40,214,32,229,98,253,4,91,122,71,5,221,130,2,241,64,243,18,22,69,41,214,144,222,106,168,179,90,23,92,170,87,154,77,45,214,28,56,227,157,71,73,123,106,211,108,158,80,73,174,216,218,212,64,197,254,76,42,193,248,227,248,88,168,115,237,154,109,72,220,113,61,33,188,204,243,132,252,29,13,7,237,40,147,0,158,112,120,126,107,236,56,73,116,248,151,209,240,103,81,228,132,201,217,118,167,246,51,174,152,218,35,126,53,207,180,231,206,201,132,92,151,44,75,45,92,59,104,229,242,61,106,25,68,63,92,122,71,114,137,177,210,155,34,99,27,6,217,156,55,18,208,173,175,158,199,26,134,13,210,55,61,57,95,120,117,124,242,13,55,86,158,169,94,35,228,12,235,210,166,45,64,186,44,22,22,16,39,154,52,215,183,176,47,44,102,208,67,204,155,24,121,45,37,53,39,88,186,61,243,21,31,22,166,207,95,176,235,118,30,114,166,71,15,61,89,199,177,105,109,98,199,111,106,239,86,220,71,194,17,244,3,97,112,13,115,76,236,26,234,199,75,93,106,220,140,144,132,244,210,14,244,190,154,9,40,162,85,70,167,211,53,83,117,146,55,148,107,146,132,161,172,157,191,187,74,204,254,210,75,132,131,157,74,29,47,173,216,113,144,184,83,187,187,136,12,81,237,187,78,14,85,234,29,123,19,105,174,235,164,124,13,151,251,85,171,15,43,108,68,219,127,69,239,180,200,115,76,186,65,77,189,135,2,129,211,250,54,212,99,205,197,148,138,204,181,83,247,172,204,225,127,52,249,32,97,252,89,238,119,118,221,182,201,48,231,169,9,240,192,224,89,135,135,220,113,126,65,34,37,74,136,244,134,136,54,52,151,16,161,72,78,79,112,37,132,25,211,111,147,146,43,19,232,35,86,36,64,149,130,19,227,10,199,241,228,116,52,108,16,65,164,111,242,87,198,179,43,144,236,145,67,214,128,196,137,83,103,233,94,149,70,142,13,132,127,135,38,232,204,232,226,146,74,152,225,59,23,165,97,170,116,7,78,25,198,229,214,81,222,232,186,233,214,55,38,213,89,184,101,231,71,171,79,62,191,130,161,115,79,208,166,16,64,215,79,221,241,170,76,194,226,36,172,79,181,110,163,134,83,175,223,238,71,69,25,35,143,206,213,0,117,24,12,151,250,205,60,184,213,7,189,40,115,137,176,250,223,79,24,233,238,29,184,224,138,50,14,2,51,240,253,175,131,94,81,69,173,244,141,144,143,165,217,6,162,249,61,108,64,128,222,30,135,243,22,118,208,133,162,139,185,188,7,89,230,170,215,208,3,16,142,179,235,167,21,233,237,153,123,167,101,253,96,81,47,230,219,140,224,96,208,21,109,250,37,203,234,191,75,70,130,6,175,63,171,93,70,21,4,135,101,90,74,85,108,107,31,174,233,227,138,230,113,96,58,146,131,29,16,72,3,213,253,161,154,255,247,8,239,182,200,225,106,249,7,186,197,56,249,93,11,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateOkButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("6c718c71-90c8-4de1-8503-d242f3c5d765"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e4f84319-5360-4e6e-b260-255d75628353"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Name = @"OkButtonClickIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(274, 73),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadCompleteEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadCompleteEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("55ec07b6-0184-4a92-b34a-9fde76f8da50"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("272165d1-b3cb-4485-9474-d2ca247097bb"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Name = @"PageLoadCompleteEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(379, 13),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(321, 156),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadCompleteEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoqdCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ba0d9eed-c5a9-4aca-af0c-05cb0a662bad"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("55ec07b6-0184-4a92-b34a-9fde76f8da50"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Name = @"PageLoqdCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoqdCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("33de6576-bc52-4dda-95dc-2c87ef03f248"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("55ec07b6-0184-4a92-b34a-9fde76f8da50"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Name = @"PageLoqdCompleteIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(126, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bb723294-caf2-4f95-8f08-d74dbca15f34"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("55ec07b6-0184-4a92-b34a-9fde76f8da50"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(210, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,84,91,111,218,48,20,126,6,137,255,224,230,161,36,21,50,123,79,169,196,128,85,145,214,22,45,101,47,109,31,188,228,208,89,11,78,228,56,108,8,241,223,231,75,200,197,9,237,27,216,231,187,156,115,62,103,79,56,202,8,39,59,16,192,115,52,67,75,216,146,34,17,63,73,82,64,142,72,142,150,52,18,52,101,132,31,110,115,193,41,123,159,160,53,79,35,200,243,48,250,13,59,178,62,163,53,228,206,31,13,233,22,185,77,206,25,98,69,146,120,232,56,26,14,56,136,130,51,36,120,1,178,242,52,26,126,192,85,27,147,190,106,194,23,103,145,80,96,98,195,168,48,176,77,16,59,111,182,48,186,50,186,232,250,26,93,25,231,56,200,31,229,201,19,95,237,50,113,168,75,177,150,243,140,195,189,156,72,212,21,144,22,24,252,69,247,5,141,59,64,255,2,236,129,48,242,174,221,187,182,229,242,202,219,228,192,23,41,99,160,135,44,121,6,248,30,218,53,110,167,223,242,194,209,194,65,235,44,16,176,187,181,235,239,58,206,84,25,154,41,185,11,158,149,11,85,244,245,32,123,119,123,230,161,181,215,178,20,219,106,176,138,169,192,33,152,12,205,89,252,12,255,68,135,194,210,9,226,203,74,147,94,251,248,81,238,192,51,33,50,235,173,51,98,226,211,14,205,138,9,42,14,141,192,152,229,149,177,249,36,33,205,128,88,68,189,193,168,115,161,206,17,52,32,26,81,237,248,220,183,69,170,161,205,51,53,211,167,36,62,55,214,38,172,86,209,68,124,79,211,63,69,214,187,139,54,122,162,98,208,206,97,139,168,55,17,182,95,188,32,153,66,122,150,23,173,191,98,228,87,2,170,239,242,221,15,62,125,245,231,70,109,170,118,173,162,170,203,241,15,216,2,7,22,65,115,57,150,211,62,127,173,184,84,196,211,155,115,233,60,142,195,136,211,76,184,101,74,228,164,34,34,92,199,221,22,76,15,204,245,142,206,164,99,214,188,140,96,169,39,236,224,40,101,185,89,132,186,77,57,230,29,191,179,87,71,242,88,150,241,115,26,106,93,87,62,5,231,213,241,79,158,235,249,142,167,103,125,51,213,47,96,58,181,156,26,4,254,150,242,157,114,122,252,114,194,177,249,180,207,247,132,38,106,33,218,74,152,22,92,174,66,118,255,50,94,84,6,199,19,52,126,32,89,38,41,212,207,240,144,203,205,87,55,230,175,76,149,80,247,111,254,7,173,107,147,205,143,254,127,152,50,15,157,113,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateClientUnitSchemaeEditChangeEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaClientUnitSchemaeEditChangeEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4b48b8e9-489a-497c-93e6-3818ec4a191a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8e929b86-532e-4200-a912-4cb76e737636"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Name = @"ClientUnitSchemaeEditChangeEventSubProcess",
				Position = new Point(302, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(270, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaClientUnitSchemaeEditChangeEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateClientUnitSchemaeEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("bd5c23d1-eefe-4712-bf6f-719f5589b54b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4b48b8e9-489a-497c-93e6-3818ec4a191a"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ClientUnitSchemaeEditChange",
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Name = @"ClientUnitSchemaeEditChangeStartMessage",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateClientUnitSchemaeEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b1e7dc97-0c9c-4ab8-93eb-183dbcc82447"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4b48b8e9-489a-497c-93e6-3818ec4a191a"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Name = @"ClientUnitSchemaeEditChangeScriptTask",
				Position = new Point(155, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEntitySchemaLookupEditChangeEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEntitySchemaLookupEditChangeEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("bc2e309c-013f-4fbf-8c19-49bb49bb2c1a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8e929b86-532e-4200-a912-4cb76e737636"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Name = @"EntitySchemaLookupEditChangeEventSubProcess",
				Position = new Point(43, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(246, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEntitySchemaLookupEditChangeEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEntitySchemaLookupEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("aacbbfbc-8d10-46cf-8d75-9f9a9d8525a1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bc2e309c-013f-4fbf-8c19-49bb49bb2c1a"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EntitySchemaLookupEditChange",
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Name = @"EntitySchemaLookupEditChangeStartMessage",
				Position = new Point(36, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEntitySchemaLookupEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4c5ae6a7-665b-4ef1-ba42-9f08be980458"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bc2e309c-013f-4fbf-8c19-49bb49bb2c1a"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Name = @"EntitySchemaLookupEditChangeScriptTask",
				Position = new Point(134, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,203,110,131,48,16,60,39,82,254,193,245,9,162,136,164,215,86,28,250,160,17,82,149,70,141,146,19,23,7,111,82,171,6,83,179,68,69,136,127,175,109,170,132,162,86,245,193,178,61,227,217,157,221,61,49,77,32,71,129,245,38,125,131,140,197,156,132,196,91,86,130,251,107,118,132,32,234,97,207,74,189,87,69,196,5,6,59,38,43,184,157,140,197,129,120,125,138,5,95,36,119,48,9,195,129,180,79,154,201,120,164,1,43,157,19,212,78,161,157,140,247,74,73,34,202,149,194,40,43,176,38,195,111,228,42,36,54,163,192,193,223,81,47,252,78,181,159,197,214,185,88,2,158,175,247,117,204,189,65,50,54,56,1,89,194,95,255,251,33,71,243,169,217,92,73,238,56,223,164,90,20,232,149,168,69,126,12,158,148,206,24,122,180,89,180,65,9,232,204,123,205,117,235,211,25,233,21,209,21,238,65,10,147,70,252,56,51,106,35,218,36,180,84,149,78,33,161,55,9,93,169,220,28,102,9,61,89,5,247,228,174,92,148,133,100,245,238,231,107,170,242,178,139,101,133,149,54,136,145,251,196,186,232,72,210,117,11,12,230,232,26,14,160,33,79,225,108,209,177,22,255,172,132,182,45,245,109,173,70,211,185,235,214,182,224,12,161,179,20,243,53,211,44,3,4,221,185,182,196,161,229,13,224,43,124,84,66,3,239,119,237,23,102,148,179,189,4,91,251,11,207,208,254,30,176,193,160,24,110,127,184,190,0,196,141,13,135,220,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetSchemaUIdByIdMethod());
			Methods.Add(CreateGetSchemaIdByUIdMethod());
			Methods.Add(CreateSetDefEntityEditValueMethod());
			Methods.Add(CreateUpdateEntityIdParameterValueMethod());
			Methods.Add(CreateCreateCustomParameterMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d4159d90-4d80-4bc4-804d-6cc2ca63435e"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("2eb2739e-09fc-468f-bc49-96baa1a33d59")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a9b659b5-9ae3-4218-9fe8-8047f8e6b589"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("2eb2739e-09fc-468f-bc49-96baa1a33d59")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b6881e55-7df2-4cef-8151-adab44274ad1"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "UIControls",
				CreatedInPackageId = new Guid("2eb2739e-09fc-468f-bc49-96baa1a33d59")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0840abef-9bb9-452e-a8da-ae98b5fb397d"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("2eb2739e-09fc-468f-bc49-96baa1a33d59")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e1b12ba7-35df-4582-a18f-8349f8901d2b"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("2eb2739e-09fc-468f-bc49-96baa1a33d59")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b424ebf7-dbe4-4ba3-91b6-f05370f2faa3"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("2eb2739e-09fc-468f-bc49-96baa1a33d59")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("085215ad-eae5-4666-af72-ca0a8f5beb61"),
				Name = "ServiceStack.Text",
				Alias = "ServiceStack",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("80c47572-4a9a-4768-8f8a-2fecf7ddd278"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("de8ba084-7212-4480-9dbe-8a387a10844f")
			});
		}

		protected override SchemaMethod CreateInitializeSchemaExplorerWindowMethod() {
			SchemaMethod method = base.CreateInitializeSchemaExplorerWindowMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,141,49,14,194,48,16,4,251,188,194,37,52,249,128,69,5,41,220,33,133,132,34,162,56,236,147,176,228,216,209,221,25,18,94,143,165,136,194,237,204,106,231,9,140,173,137,94,60,4,255,197,222,190,112,134,110,93,66,34,164,187,143,46,125,14,71,221,188,129,20,87,78,157,84,61,86,192,106,48,231,20,133,82,224,118,151,189,80,182,146,9,255,43,221,212,55,165,109,67,118,232,46,32,48,66,200,120,219,22,228,233,10,4,51,10,82,197,7,227,30,37,220,69,241,178,237,133,130,244,15,94,149,197,29,197,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetEditorsBindingMethod() {
			SchemaMethod method = base.CreateGetEditorsBindingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,193,10,130,64,16,134,207,245,20,139,167,2,241,5,138,46,229,193,67,20,169,116,222,116,180,37,119,54,102,71,76,196,119,143,181,196,194,219,206,255,125,31,44,1,215,132,2,161,17,7,149,177,50,40,169,221,90,38,133,165,47,18,32,146,214,20,28,164,81,112,133,219,222,32,147,169,236,207,123,183,90,139,110,185,232,188,16,89,113,27,229,158,47,206,178,132,224,115,135,185,226,222,119,60,81,92,193,8,83,11,148,72,251,24,198,201,185,64,102,180,6,204,165,251,201,40,255,175,147,29,97,97,72,15,227,9,99,134,231,24,204,192,17,180,153,186,248,110,154,240,5,89,237,4,23,140,221,12,124,155,126,243,6,45,242,1,114,39,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateMakeCaptionMethod() {
			SchemaMethod method = base.CreateMakeCaptionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,204,177,10,194,48,20,133,225,89,159,226,210,41,129,18,116,85,68,164,84,232,82,69,82,58,71,123,45,193,52,41,185,87,170,148,190,187,84,156,157,206,242,159,79,156,77,139,234,64,253,188,96,8,52,198,104,40,220,89,85,133,170,241,154,5,207,49,56,82,115,32,85,102,122,182,193,195,14,136,163,245,173,42,168,124,58,119,138,121,215,243,91,124,181,138,48,106,67,15,109,217,97,222,88,86,26,95,44,97,191,92,252,78,199,16,59,195,34,25,87,19,136,113,61,201,36,133,218,250,38,12,63,63,133,18,135,11,222,66,108,36,108,224,15,187,253,0,212,67,124,110,194,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateUpdateProcessSchemaCustomParameterMethod() {
			SchemaMethod method = base.CreateUpdateProcessSchemaCustomParameterMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,11,45,72,73,44,73,13,40,202,79,78,45,46,14,78,206,72,205,77,116,46,45,46,201,207,13,72,44,74,204,77,45,73,45,210,72,46,45,42,74,205,43,129,11,232,40,228,230,167,100,166,101,166,166,192,133,52,173,121,185,208,149,233,121,22,7,165,22,151,230,148,40,216,98,106,128,75,90,3,0,141,105,242,183,134,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSchemaUIdByIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("efeffc77-202c-433e-921c-5e52e1be4b66"),
				Name = "GetSchemaUIdById",
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f3914e18-e384-4a8a-84bd-fd846d64e963"),
				Name = "schemaId",
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,53,141,193,10,194,48,16,68,207,21,252,135,146,211,230,146,31,80,188,148,42,185,21,66,241,188,164,11,45,36,27,220,36,168,127,111,109,245,54,188,153,199,8,149,42,124,60,52,192,244,108,29,5,242,5,198,76,210,37,230,53,47,137,245,218,54,166,75,161,70,6,53,218,73,125,137,185,74,138,160,220,59,59,63,83,196,29,222,103,18,2,245,223,216,220,63,42,6,216,101,51,160,96,164,66,2,121,115,236,164,117,139,249,119,187,25,253,139,124,45,228,60,6,148,243,173,46,211,5,244,233,3,60,46,93,100,166,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSchemaIdByUIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e1bd0bf7-958e-4960-8d94-b97e140994ba"),
				Name = "GetSchemaIdByUId",
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("cee28633-5da8-451d-bea5-f5e856157ce7"),
				Name = "schemaUId",
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				ModifiedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,221,10,130,64,16,133,175,13,122,7,217,171,21,98,95,160,8,66,42,236,38,65,196,235,97,29,82,212,221,154,117,169,222,190,245,167,31,189,232,110,102,206,153,239,12,67,216,90,82,203,133,199,21,222,253,4,107,148,45,79,13,82,168,149,114,117,169,85,224,84,79,132,186,182,141,226,44,121,154,68,22,216,0,91,249,44,202,89,167,138,3,233,230,87,234,135,145,3,208,73,151,195,82,12,178,130,11,178,64,156,167,131,17,35,34,179,191,89,168,103,9,95,227,59,43,43,144,112,230,74,39,132,225,84,17,3,65,131,45,18,55,189,209,153,130,158,176,83,249,252,2,215,101,154,42,115,5,137,255,89,211,223,136,207,150,232,232,62,152,241,135,125,208,254,129,210,182,152,72,168,129,54,71,91,230,91,30,172,95,81,138,116,160,115,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetDefEntityEditValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f14ceb02-9e0f-4768-8fe0-c61fd4d55315"),
				Name = "SetDefEntityEditValue",
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,80,193,74,195,64,16,61,91,232,63,44,185,100,183,132,173,158,139,135,218,70,9,88,9,198,122,17,15,99,50,173,139,201,110,216,157,84,66,232,191,187,77,181,208,8,226,109,222,204,155,55,239,205,14,44,67,77,138,218,184,80,244,12,101,131,236,154,105,252,100,169,53,57,58,151,229,239,88,65,10,22,42,36,180,61,131,11,214,141,71,23,75,32,232,241,83,91,31,182,248,89,67,172,29,218,133,209,26,115,82,70,203,179,225,10,52,108,209,202,59,164,132,176,186,105,31,188,60,15,238,141,249,104,234,64,200,68,59,2,157,99,228,207,60,226,6,45,122,112,180,178,78,10,127,43,238,61,159,58,227,209,126,54,30,165,94,83,198,167,52,242,39,206,32,160,103,78,39,223,236,121,81,100,185,85,53,241,140,172,210,91,121,107,108,5,196,131,238,114,47,11,220,64,83,210,124,7,170,132,183,18,251,237,204,52,214,63,198,203,190,132,62,158,59,106,134,17,11,87,80,215,94,226,80,102,173,243,177,78,147,35,204,144,232,48,127,157,5,17,27,122,93,148,202,219,76,150,66,204,254,99,205,33,253,254,11,15,187,171,125,40,254,80,143,134,143,235,207,77,166,95,188,95,78,183,7,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateEntityIdParameterValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a583226d-be34-49db-8928-56936c9d821d"),
				Name = "UpdateEntityIdParameterValue",
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,40,202,79,78,45,46,14,78,206,72,205,77,12,72,44,74,204,77,45,73,45,10,75,204,41,77,85,40,64,229,218,42,4,36,166,167,234,185,230,149,100,150,84,186,166,100,150,232,161,170,183,230,229,66,213,161,231,155,159,146,153,150,153,154,226,153,7,49,63,212,51,5,104,10,72,43,156,143,169,41,40,53,45,181,40,53,47,57,21,69,15,216,82,60,186,96,78,204,43,205,201,193,148,117,201,44,46,200,73,172,196,175,40,56,191,180,40,25,236,77,220,97,2,81,163,231,151,159,7,242,46,122,120,192,204,71,53,216,26,0,103,61,254,135,100,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateCustomParameterMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("819d5d7e-6b02-4b41-8b94-58df51c34a70"),
				Name = "CreateCustomParameter",
				CreatedInSchemaUId = new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "ProcessSchemaParameter"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,43,205,201,177,6,0,44,130,140,166,12,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PreconfiguredPageUserTaskParametersEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("728a96e4-0ea2-4036-a09b-0973c57e632b"));
		}

		#endregion

	}

	#endregion

}

