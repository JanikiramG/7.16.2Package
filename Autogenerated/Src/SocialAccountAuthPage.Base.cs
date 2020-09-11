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
	using System.Web;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GoogleServerConnector;
	using Terrasoft.Social;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.Web.Common;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: SocialAccountAuthPageSchema

	/// <exclude/>
	public class SocialAccountAuthPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TextEdit _consumerKeyEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit ConsumerKeyEdit {
			get {
				return _consumerKeyEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _consumerSecretKeyEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit ConsumerSecretKeyEdit {
			get {
				return _consumerSecretKeyEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public SocialAccountAuthPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SocialAccountAuthPageSchema(SocialAccountAuthPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("3b22f0ff-034a-48da-8758-a0660e5a26ff");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("3b22f0ff-034a-48da-8758-a0660e5a26ff");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("3b22f0ff-034a-48da-8758-a0660e5a26ff");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("3b22f0ff-034a-48da-8758-a0660e5a26ff");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("3b22f0ff-034a-48da-8758-a0660e5a26ff");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("3b22f0ff-034a-48da-8758-a0660e5a26ff");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("3b22f0ff-034a-48da-8758-a0660e5a26ff");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("3b22f0ff-034a-48da-8758-a0660e5a26ff");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3b22f0ff-034a-48da-8758-a0660e5a26ff");
			RealUId = new Guid("3b22f0ff-034a-48da-8758-a0660e5a26ff");
			Name = "SocialAccountAuthPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Width = 600;
			Height = 700;
			ValidationMessagePanel = "";
			HelpContextId = "";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSocialAccountAuthPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(0, CreateConsumerKeyEdit());
			MainControlLayout.InsertItem(1, CreateConsumerSecretKeyEdit());
			MainControlLayout.MoveItem(2, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateSocialAccountAuthPageEventsProcessSchema() {
			var schema = new SocialAccountAuthPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateConsumerKeyEdit() {
			_consumerKeyEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_consumerKeyEdit.UId = new Guid("330875b2-fff6-42f4-86a7-2d5d26671761");
			_consumerKeyEdit.Name = "ConsumerKeyEdit";
			_consumerKeyEdit.CreatedInSchemaUId = new Guid("3b22f0ff-034a-48da-8758-a0660e5a26ff");
			_consumerKeyEdit.ModifiedInSchemaUId = new Guid("3b22f0ff-034a-48da-8758-a0660e5a26ff");
			_consumerKeyEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_consumerKeyEdit.Tag = "";
			_consumerKeyEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_consumerKeyEdit.Image = new ControlImage {};
			_consumerKeyEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_consumerKeyEdit.Required = true;
			return _consumerKeyEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateConsumerSecretKeyEdit() {
			_consumerSecretKeyEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_consumerSecretKeyEdit.UId = new Guid("036f2243-74ba-4e3c-a00d-847aa52ee2b8");
			_consumerSecretKeyEdit.Name = "ConsumerSecretKeyEdit";
			_consumerSecretKeyEdit.CreatedInSchemaUId = new Guid("3b22f0ff-034a-48da-8758-a0660e5a26ff");
			_consumerSecretKeyEdit.ModifiedInSchemaUId = new Guid("3b22f0ff-034a-48da-8758-a0660e5a26ff");
			_consumerSecretKeyEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_consumerSecretKeyEdit.Tag = "";
			_consumerSecretKeyEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_consumerSecretKeyEdit.Image = new ControlImage {};
			_consumerSecretKeyEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_consumerSecretKeyEdit.Required = true;
			return _consumerSecretKeyEdit;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new SocialAccountAuthPageSchemaUserControl();
		}

		public override object Clone() {
			return new SocialAccountAuthPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3b22f0ff-034a-48da-8758-a0660e5a26ff"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SocialAccountAuthPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SocialAccountAuthPageEventsProcess

	/// <exclude/>
	public class SocialAccountAuthPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SocialAccountAuthPageSchemaUserControl
	{

		public SocialAccountAuthPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SocialAccountAuthPageEventsProcess";
			SchemaUId = new Guid("3b22f0ff-034a-48da-8758-a0660e5a26ff");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3b22f0ff-034a-48da-8758-a0660e5a26ff");
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

		private Guid _externalServiceSettingsPageLinkId = new Guid("6251ff6e-e195-4d04-8d20-86dc240aa854");
		public Guid ExternalServiceSettingsPageLinkId {
			get {
				return _externalServiceSettingsPageLinkId;
			}
			set {
				_externalServiceSettingsPageLinkId = value;
			}
		}

		public virtual bool IsBpmConfigurated {
			get;
			set;
		}

		public virtual string OldConsumerKey {
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
					SchemaElementUId = new Guid("dedd769c-3815-42c4-a533-3daecd155756"),
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
					SchemaElementUId = new Guid("a093693d-ab70-472c-b694-984f18f30e69"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _isBpmConfiguratedScriptTask;
		public ProcessScriptTask IsBpmConfiguratedScriptTask {
			get {
				return _isBpmConfiguratedScriptTask ?? (_isBpmConfiguratedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "IsBpmConfiguratedScriptTask",
					SchemaElementUId = new Guid("61984a8e-37b9-43e2-ad69-d308206056a5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = IsBpmConfiguratedScriptTaskExecute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway2;
		public ProcessExclusiveGateway ExclusiveGateway2 {
			get {
				return _exclusiveGateway2 ?? (_exclusiveGateway2 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway2",
					SchemaElementUId = new Guid("335abd18-a757-4b50-a66a-bb5153ea3793"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway2.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway3;
		public ProcessExclusiveGateway ExclusiveGateway3 {
			get {
				return _exclusiveGateway3 ?? (_exclusiveGateway3 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway3",
					SchemaElementUId = new Guid("5b341fdb-7b38-4e54-b002-e857b91519f5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway3.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _showSysSettingsEditorsScriptTask;
		public ProcessScriptTask ShowSysSettingsEditorsScriptTask {
			get {
				return _showSysSettingsEditorsScriptTask ?? (_showSysSettingsEditorsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ShowSysSettingsEditorsScriptTask",
					SchemaElementUId = new Guid("dd0d7955-fd93-4d1b-b6dd-70891ea347c1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ShowSysSettingsEditorsScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _showNotAdminMessageScriptTask;
		public ProcessScriptTask ShowNotAdminMessageScriptTask {
			get {
				return _showNotAdminMessageScriptTask ?? (_showNotAdminMessageScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ShowNotAdminMessageScriptTask",
					SchemaElementUId = new Guid("048b09ba-3cb3-4750-adb5-efecddcea9ac"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ShowNotAdminMessageScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _authUserScriptTask;
		public ProcessScriptTask AuthUserScriptTask {
			get {
				return _authUserScriptTask ?? (_authUserScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AuthUserScriptTask",
					SchemaElementUId = new Guid("33da7af3-698d-4e1d-b15f-dd82bb52a181"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AuthUserScriptTaskExecute,
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
					SchemaElementUId = new Guid("bdd1b2ef-9841-48d9-bb20-eedbc4f58b2d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _oKButtonClickStartMessage;
		public ProcessFlowElement OKButtonClickStartMessage {
			get {
				return _oKButtonClickStartMessage ?? (_oKButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OKButtonClickStartMessage",
					SchemaElementUId = new Guid("813d8c9b-e8ba-4b0b-b308-5edb9a39a027"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _oKButtonClickIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent OKButtonClickIntermediateThrowMessageEvent {
			get {
				return _oKButtonClickIntermediateThrowMessageEvent ?? (_oKButtonClickIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "OKButtonClickIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("51e95151-1d21-4e0f-a64e-3185de46db25"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OKButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _saveSettingsScriptTask;
		public ProcessScriptTask SaveSettingsScriptTask {
			get {
				return _saveSettingsScriptTask ?? (_saveSettingsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SaveSettingsScriptTask",
					SchemaElementUId = new Guid("5cc40a5f-9b52-40a5-a7f0-8d829568fefc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SaveSettingsScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _deleteOldAccountsScriptTask;
		public ProcessScriptTask DeleteOldAccountsScriptTask {
			get {
				return _deleteOldAccountsScriptTask ?? (_deleteOldAccountsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeleteOldAccountsScriptTask",
					SchemaElementUId = new Guid("3f601495-6560-4aaa-9cc4-69b9885802e9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeleteOldAccountsScriptTaskExecute,
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow1;
		public ProcessConditionalFlow ConditionalFlow1 {
			get {
				return _conditionalFlow1 ?? (_conditionalFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow1",
					SchemaElementUId = new Guid("934a467f-e258-4c75-9f39-6a6e0c75974c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _checkOperationRightsConditionalFlow;
		public ProcessConditionalFlow CheckOperationRightsConditionalFlow {
			get {
				return _checkOperationRightsConditionalFlow ?? (_checkOperationRightsConditionalFlow = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "CheckOperationRightsConditionalFlow",
					SchemaElementUId = new Guid("2fea167b-c1e5-4ace-a12e-a3a7c123b015"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _error;
		public LocalizableString Error {
			get {
				return _error ?? (_error = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.Error.Value"));
			}
		}

		private LocalizableString _errorNotHasRights;
		public LocalizableString ErrorNotHasRights {
			get {
				return _errorNotHasRights ?? (_errorNotHasRights = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ErrorNotHasRights.Value"));
			}
		}

		private LocalizableString _helpCaption;
		public LocalizableString HelpCaption {
			get {
				return _helpCaption ?? (_helpCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.HelpCaption.Value"));
			}
		}

		private LocalizableString _helpMessage;
		public LocalizableString HelpMessage {
			get {
				return _helpMessage ?? (_helpMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.HelpMessage.Value"));
			}
		}

		private LocalizableString _communicationTypeNotFound;
		public LocalizableString CommunicationTypeNotFound {
			get {
				return _communicationTypeNotFound ?? (_communicationTypeNotFound = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CommunicationTypeNotFound.Value"));
			}
		}

		private LocalizableString _googleConsumerKey;
		public LocalizableString GoogleConsumerKey {
			get {
				return _googleConsumerKey ?? (_googleConsumerKey = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.GoogleConsumerKey.Value"));
			}
		}

		private LocalizableString _linkedInConsumerKey;
		public LocalizableString LinkedInConsumerKey {
			get {
				return _linkedInConsumerKey ?? (_linkedInConsumerKey = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.LinkedInConsumerKey.Value"));
			}
		}

		private LocalizableString _facebookConsumerKey;
		public LocalizableString FacebookConsumerKey {
			get {
				return _facebookConsumerKey ?? (_facebookConsumerKey = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FacebookConsumerKey.Value"));
			}
		}

		private LocalizableString _twitterConsumerKey;
		public LocalizableString TwitterConsumerKey {
			get {
				return _twitterConsumerKey ?? (_twitterConsumerKey = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.TwitterConsumerKey.Value"));
			}
		}

		private LocalizableString _googleSecretKey;
		public LocalizableString GoogleSecretKey {
			get {
				return _googleSecretKey ?? (_googleSecretKey = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.GoogleSecretKey.Value"));
			}
		}

		private LocalizableString _linkedInSecretKey;
		public LocalizableString LinkedInSecretKey {
			get {
				return _linkedInSecretKey ?? (_linkedInSecretKey = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.LinkedInSecretKey.Value"));
			}
		}

		private LocalizableString _facebookSecretKey;
		public LocalizableString FacebookSecretKey {
			get {
				return _facebookSecretKey ?? (_facebookSecretKey = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FacebookSecretKey.Value"));
			}
		}

		private LocalizableString _twitterSecretKey;
		public LocalizableString TwitterSecretKey {
			get {
				return _twitterSecretKey ?? (_twitterSecretKey = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.TwitterSecretKey.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[IsBpmConfiguratedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { IsBpmConfiguratedScriptTask };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[ExclusiveGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3 };
			FlowElements[ShowSysSettingsEditorsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowSysSettingsEditorsScriptTask };
			FlowElements[ShowNotAdminMessageScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowNotAdminMessageScriptTask };
			FlowElements[AuthUserScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AuthUserScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[OKButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClickStartMessage };
			FlowElements[OKButtonClickIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClickIntermediateThrowMessageEvent };
			FlowElements[SaveSettingsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveSettingsScriptTask };
			FlowElements[DeleteOldAccountsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteOldAccountsScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("IsBpmConfiguratedScriptTask");
						break;
					case "IsBpmConfiguratedScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway2");
						break;
					case "ExclusiveGateway2":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("AuthUserScriptTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("ExclusiveGateway3");
						break;
					case "ExclusiveGateway3":
						if (CheckOperationRightsConditionalFlowExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ShowSysSettingsEditorsScriptTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("ShowNotAdminMessageScriptTask");
						break;
					case "ShowSysSettingsEditorsScriptTask":
						break;
					case "ShowNotAdminMessageScriptTask":
						break;
					case "AuthUserScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "OKButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("OKButtonClickIntermediateThrowMessageEvent");
						break;
					case "OKButtonClickIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("SaveSettingsScriptTask");
						break;
					case "SaveSettingsScriptTask":
						break;
					case "DeleteOldAccountsScriptTask":
						e.Context.QueueTasks.Enqueue("AuthUserScriptTask");
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(IsBpmConfigurated);
		}

		private bool CheckOperationRightsConditionalFlowExpressionExecute() {
			return Convert.ToBoolean(UserConnection.DBSecurityEngine.GetCanExecuteOperation("CanManageAdministration"));
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage1");
			ActivatedEventElements.Add("OKButtonClickStartMessage");
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
				case "IsBpmConfiguratedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "IsBpmConfiguratedScriptTask";
					result = IsBpmConfiguratedScriptTask.Execute(context, IsBpmConfiguratedScriptTaskExecute);
					break;
				case "ExclusiveGateway2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway2";
					result = ExclusiveGateway2.Execute(context);
					break;
				case "ExclusiveGateway3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway3";
					result = ExclusiveGateway3.Execute(context);
					break;
				case "ShowSysSettingsEditorsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowSysSettingsEditorsScriptTask";
					result = ShowSysSettingsEditorsScriptTask.Execute(context, ShowSysSettingsEditorsScriptTaskExecute);
					break;
				case "ShowNotAdminMessageScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowNotAdminMessageScriptTask";
					result = ShowNotAdminMessageScriptTask.Execute(context, ShowNotAdminMessageScriptTaskExecute);
					break;
				case "AuthUserScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AuthUserScriptTask";
					result = AuthUserScriptTask.Execute(context, AuthUserScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "OKButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OKButtonClickStartMessage";
					result = OKButtonClickStartMessage.Execute(context);
					break;
				case "OKButtonClickIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OKButtonClick");
					result = OKButtonClickIntermediateThrowMessageEvent.Execute(context);
					break;
				case "SaveSettingsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SaveSettingsScriptTask";
					result = SaveSettingsScriptTask.Execute(context, SaveSettingsScriptTaskExecute);
					break;
				case "DeleteOldAccountsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteOldAccountsScriptTask";
					result = DeleteOldAccountsScriptTask.Execute(context, DeleteOldAccountsScriptTaskExecute);
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
				case "OldConsumerKey":
					OldConsumerKey = reader.GetValue<System.String>();
				break;
				case "IsBpmConfigurated":
					IsBpmConfigurated = reader.GetValue<System.Boolean>();
				break;
				case "ExternalServiceSettingsPageLinkId":
					ExternalServiceSettingsPageLinkId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool IsBpmConfiguratedScriptTaskExecute(ProcessExecutingContext context) {
			InitializeContextHelpButton();
			IsBpmConfigurated = false;
			string consumerKey;
			string consumerSecret;
			bool useGoogleSharedApplication = (bool)GetSysSettingValue("UseGoogleSharedApplication");
			if (useGoogleSharedApplication) {
				var googleServerConnector = new GoogleServerConnector();
				var consumerInfo = googleServerConnector.GetConsumerInfo();
				consumerKey = consumerInfo.Key;
				consumerSecret = consumerInfo.Secret;
			} else {
				string socialNetworkName = Get("SocialNetwork");
				consumerKey = (string)GetSysSettingValue(socialNetworkName + "ConsumerKey");
				consumerSecret = (string)GetSysSettingValue(socialNetworkName + "ConsumerSecret");
			}
			if (string.IsNullOrEmpty(consumerKey) || string.IsNullOrEmpty(consumerSecret)){
				IsBpmConfigurated = false;
				return true;
			}
			IsBpmConfigurated = true;
			return true;
		}

		public virtual bool ShowSysSettingsEditorsScriptTaskExecute(ProcessExecutingContext context) {
			string socialNetworkName = Get("SocialNetwork");
			if(string.IsNullOrEmpty(socialNetworkName)) {
				Page.BaseMessagePanel.Clear();
				Page.BaseMessagePanel.AddMessage(title: Error, text: CommunicationTypeNotFound,
					messageType: MessageType.Error, closable: false, showIcon: true);
					return false;
			}
			Page.BaseMessagePanel.Clear();
			var newLink = new LinkConfig();
			newLink.Caption = (string)GetSysSettingValue(socialNetworkName + "RegistrationPage");
			newLink.LinkId = ExternalServiceSettingsPageLinkId.ToString();
			Page.BaseMessagePanel.Links.Add(newLink);
			string script = string.Format(@"{0}.on('linkclick', function() {{ Terrasoft.openWindow('{1}'); }});",
				Page.BaseMessagePanel.ClientID, (string)GetSysSettingValue(socialNetworkName + "RegistrationPage"));
			Page.ScriptManager.AddScript(script);
			Page.BaseMessagePanel.AddMessage(
				title: string.Format(HelpCaption, socialNetworkName),
				text: string.Format(HelpMessage, ExternalServiceSettingsPageLinkId.ToString("B")),
				messageType: MessageType.Information, closable: false, showIcon: true);
			Page.ConsumerKeyEdit.Text = OldConsumerKey = (string)GetSysSettingValue(socialNetworkName + "ConsumerKey");
			Page.ConsumerSecretKeyEdit.Text = (string)GetSysSettingValue(socialNetworkName + "ConsumerSecret");
			switch(socialNetworkName) {
				case "Google":
					Page.ConsumerKeyEdit.Caption = 		 GoogleConsumerKey;
					Page.ConsumerSecretKeyEdit.Caption = GoogleSecretKey;
					break;
				case "LinkedIn":
					Page.ConsumerKeyEdit.Caption = 		 LinkedInConsumerKey;
					Page.ConsumerSecretKeyEdit.Caption = LinkedInSecretKey;
					break;
				case "Facebook":
					Page.ConsumerKeyEdit.Caption = 		 FacebookConsumerKey;
					Page.ConsumerSecretKeyEdit.Caption = FacebookSecretKey;
					break;
				case "Twitter":
					Page.ConsumerKeyEdit.Caption = 		 TwitterConsumerKey;
					Page.ConsumerSecretKeyEdit.Caption = TwitterSecretKey;
					break;
				default:
					break;
			}
			return true;
		}

		public virtual bool ShowNotAdminMessageScriptTaskExecute(ProcessExecutingContext context) {
			Page.ConsumerKeyEdit.Hidden = true;
			Page.ConsumerSecretKeyEdit.Hidden = true;
			Page.OKButton.Hidden = true;
			Page.CancelButton.Caption = Page.OKButton.Caption;
			
			Page.BaseMessagePanel.Clear();
			Page.BaseMessagePanel.AddMessage(title: Error, text: string.Format(ErrorNotHasRights, Get("SocialNetwork")),
				messageType: MessageType.Error, closable: false, showIcon: true);
			// TODO change user notify in 7.0
			return true;
		}

		public virtual bool AuthUserScriptTaskExecute(ProcessExecutingContext context) {
			var socialNetworkName = Get("SocialNetwork");
			if (string.IsNullOrEmpty(socialNetworkName)) {
				(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
				return false;
			}
			var accessToken = string.Empty;
			var accessSecretToken = string.Empty;
			var socialId = string.Empty;
			string errorMessage;
			var returnValueKey = "SocialAccountAuth_" + Guid.NewGuid();
			var openerId = Get("OpenerPageId");
			var successEvent = Get("SuccessEventName");
			var failedMessage = Get("FailedEventName");
			bool areParamsEmpty = string.IsNullOrEmpty(returnValueKey) ||
				string.IsNullOrEmpty(openerId) ||
				string.IsNullOrEmpty(successEvent) ||
				string.IsNullOrEmpty(failedMessage);
			var	auth = SocialCommutator.CompleteAuthentication(UserConnection, socialNetworkName,
				out accessToken, out accessSecretToken, out socialId, out errorMessage);
			errorMessage = HttpUtility.HtmlEncode(errorMessage);
			if (auth == AuthResult.Discard) {
				(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
				return true;
			} else if (auth == AuthResult.Failed) {
				if (string.IsNullOrEmpty(errorMessage)){
					var user = new UserToken(Get("userid"), true);
					try {
						SocialCommutator.StartAuthentication(UserConnection, socialNetworkName, user);
					} catch (SocialNetworkException e){
						Page.ConsumerKeyEdit.Hidden = true;
						Page.ConsumerSecretKeyEdit.Hidden = true;
						Page.OKButton.Hidden = true;
						Page.CancelButton.Caption = Page.OKButton.Caption;
						Page.BaseMessagePanel.Clear();
						Page.BaseMessagePanel.AddMessage(title: Warning, text: e.Message,
							messageType: MessageType.Warning, closable: false, showIcon: true);
						if (areParamsEmpty) {
							NUIReturnErrorToOpener(errorMessage);
							(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
						}
					}
				} else {
					Page.ConsumerKeyEdit.Hidden = true;
					Page.ConsumerSecretKeyEdit.Hidden = true;
					Page.OKButton.Hidden = true;
					Page.CancelButton.Caption = Page.OKButton.Caption;
					Page.BaseMessagePanel.Clear();
					Page.BaseMessagePanel.AddMessage(title: Warning, text: errorMessage,
						messageType: MessageType.Warning, closable: false, showIcon: true);
					if (areParamsEmpty) {
						NUIReturnErrorToOpener(errorMessage);
						(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
					}
				}
				return true;
			}
			if (areParamsEmpty) {
				if (auth == AuthResult.Success) {
					NUIReturnKeysToOpener(accessToken, accessSecretToken, socialId);
				}
				(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
				return false;
			}
			if (auth == AuthResult.Success) {
				UserConnection.SessionData[returnValueKey] = @"
				{
					""Token"": """ + accessToken + @""",
					""Secret"":  """ + accessSecretToken + @""",
					""SocialId"": """ + socialId + @"""
				}";
			}
				var sbCallback = new StringBuilder();
				sbCallback.Append("\nvar windowKey = '"+ openerId +"';");
				sbCallback.Append("\nExt.EventManager.on(window, 'beforeunload', function() {\n\t");
				sbCallback.Append("if (window.opener.Terrasoft.AjaxMethods.ThrowClientEvent)");
				sbCallback.Append("\n\t\t{\n\nwindow.opener.Terrasoft.AjaxMethods.ThrowClientEvent(");
				sbCallback.Append("windowKey,'");
				if (auth == AuthResult.Success) {
					sbCallback.Append(successEvent);
				} else {
					sbCallback.Append(failedMessage);
				}	
				sbCallback.Append("','" + returnValueKey.ToString() + "');}");
				sbCallback.Append("\n}, window, {single:true});");
			ScriptManager scriptManager = ((Terrasoft.UI.WebControls.Page)System.Web.HttpContext.Current.CurrentHandler).FindControl("ScriptManager") as ScriptManager;
			scriptManager.AddScript(sbCallback.ToString());
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			return true;
		}

		public virtual bool SaveSettingsScriptTaskExecute(ProcessExecutingContext context) {
			try {
				var consumerKeySettingsName = Get("SocialNetwork") + "ConsumerKey";
				var consumerKeyValue = Page.ConsumerKeyEdit.Text.Trim();
				Terrasoft.Core.Configuration.SysSettings.SetDefValue(UserConnection, consumerKeySettingsName, consumerKeyValue);
				
				var consumerSecretSettingsName = Get("SocialNetwork") + "ConsumerSecret";
				var consumerSecretValue = Page.ConsumerSecretKeyEdit.Text.Trim();
				Terrasoft.Core.Configuration.SysSettings.SetDefValue(UserConnection, consumerSecretSettingsName, consumerSecretValue);
			} catch (Exception ex) {
				Page.BaseMessagePanel.Clear();
				Page.BaseMessagePanel.AddMessage(
					title: Error,
					text: ex.Message,
					messageType: MessageType.Error, closable: false, showIcon: true);
				// TODO change user notify in 7.0
				return false;
			}
			return true;
		}

		public virtual bool DeleteOldAccountsScriptTaskExecute(ProcessExecutingContext context) {
			if (OldConsumerKey.Trim() != Page.ConsumerKeyEdit.Text.Trim()) {
				new Delete(UserConnection)
					.From("SocialAccount")
					.Where("ConsumerKey").IsEqual(Column.Parameter(OldConsumerKey)).Execute();
			}
			return true;
		}

		public virtual string Get(string queryStringParameterName) {
			var state = Page.Request.QueryString["state"];
			if(string.IsNullOrEmpty(state)) {
				return Page.Request.QueryString[queryStringParameterName];
			}
			// HACK for Google
			var query = HttpUtility.ParseQueryString(new UriBuilder(HttpContext.Current.Server.UrlDecode(state)).Query);
			return query[queryStringParameterName];
			
			
		}

		public override void InitializeContextHelpButton() {
			if (!GetIsContextHelpButtonHidden() && GetIsContextHelpEnabled()) {
				string socialNetworkName = Get("SocialNetwork");
				var helpcode = "";
				switch (socialNetworkName) {
					case "Facebook":
						helpcode = "564";
						break;
					case "LinkedIn":
						helpcode = "565";
						break;
					case "Twitter":
						helpcode = "566";
						break;
					case "Google":
						helpcode = "562";
						break;
				}
				string helpContextId = helpcode;
				Page.ContextHelpButton.HelpContextId = helpContextId;
				var userConnection = Page.UserConnection;
				TSConfiguration.VideoHelpUtilities.InitializeContextHelpButton(Page.ContextHelpButton, helpContextId, MenuHelpItemCaption, MenuVideoHelpItemCaption, userConnection);
			}
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public virtual void NUIReturnKeysToOpener(string accessToken, string accessSecretToken, string socialId) {
			var sbCallback = new StringBuilder();
			sbCallback.Append("\nExt.EventManager.on(window, 'beforeunload', function() {\n\t");
			sbCallback.Append("if (window.opener)");
			sbCallback.Append("\n\t\t{\n\nwindow.opener.returnAccessTokens('");
			sbCallback.Append(accessToken + "', '" + accessSecretToken + "', '" + socialId + "', '" + UserConnection.CurrentUser.Id + "');}");
			sbCallback.Append("\n}, window, {single:true});");
			ScriptManager scriptManager = ((Terrasoft.UI.WebControls.Page)System.Web.HttpContext.Current.CurrentHandler).FindControl("ScriptManager") as ScriptManager;
			scriptManager.AddScript(sbCallback.ToString());
		}

		public virtual void NUIReturnErrorToOpener(string message) {
			var sbCallback = new StringBuilder();
			sbCallback.Append("\nExt.EventManager.on(window, 'beforeunload', function() {\n\t");
			sbCallback.Append("if (window.opener)");
			sbCallback.Append("\n\t\t{\n\nwindow.opener.returnAuthErrorMessage(\"");
			sbCallback.Append(message + "\");}");
			sbCallback.Append("\n}, window, {single:true});");
			ScriptManager scriptManager = ((Terrasoft.UI.WebControls.Page)System.Web.HttpContext.Current.CurrentHandler).FindControl("ScriptManager") as ScriptManager;
			scriptManager.AddScript(sbCallback.ToString());
		}

		public virtual object GetSysSettingValue(string settingCode) {
			object value;
			if (SysSettings.TryGetValue(UserConnection, settingCode, out value)) {
				return value;
			}
			throw new ItemNotFoundException(new LocalizableString("Terrasoft.Core",
				"UserConnection.Exception.SettingsByCodeNotFound"), settingCode);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
							ProcessQueue(context);
							return;
						}
						break;
					case "OKButtonClick":
							if (ActivatedEventElements.Contains("OKButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("OKButtonClickStartMessage");
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
			if (!HasMapping("OldConsumerKey") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("OldConsumerKey", OldConsumerKey, null);
			}
			if (!HasMapping("IsBpmConfigurated") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsBpmConfigurated", IsBpmConfigurated, false);
			}
			if (!HasMapping("ExternalServiceSettingsPageLinkId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ExternalServiceSettingsPageLinkId", ExternalServiceSettingsPageLinkId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SocialAccountAuthPageEventsProcess

	/// <exclude/>
	public class SocialAccountAuthPageEventsProcess : SocialAccountAuthPageEventsProcess<Terrasoft.WebApp.SocialAccountAuthPageSchemaUserControl>
	{

		public SocialAccountAuthPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SocialAccountAuthPageSchemaUserControl

	/// <exclude/>
	public partial class SocialAccountAuthPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TextEdit ConsumerKeyEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("ConsumerKeyEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit ConsumerSecretKeyEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("ConsumerSecretKeyEdit", true);
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
			var process = (SocialAccountAuthPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SocialAccountAuthPageEventsProcess(UserConnection);
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
			SchemaName = "SocialAccountAuthPage";
		}

		#endregion

	}

	#endregion

	#region Class: SocialAccountAuthPageEventsProcessSchema

	/// <exclude/>
	public class SocialAccountAuthPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public SocialAccountAuthPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SocialAccountAuthPageEventsProcessSchema(SocialAccountAuthPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SocialAccountAuthPageEventsProcess";
			UId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateExternalServiceSettingsPageLinkIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("979cdf91-4220-441b-8c15-422c7031505a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Name = @"ExternalServiceSettingsPageLinkId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"6251ff6e-e195-4d04-8d20-86dc240aa854",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateIsBpmConfiguratedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("47c5c4d7-c067-4079-80c3-58d8d5a2ef23"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Name = @"IsBpmConfigurated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateOldConsumerKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("24d5da77-3529-4140-8352-6d6f16839888"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Name = @"OldConsumerKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateExternalServiceSettingsPageLinkIdParameter());
			Parameters.Add(CreateIsBpmConfiguratedParameter());
			Parameters.Add(CreateOldConsumerKeyParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet60 = CreateLaneSet60LaneSet();
			LaneSets.Add(schemaLaneSet60);
			ProcessSchemaLane schemaLane164 = CreateLane164Lane();
			schemaLaneSet60.Lanes.Add(schemaLane164);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask isbpmconfiguratedscripttask = CreateIsBpmConfiguratedScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(isbpmconfiguratedscripttask);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			eventsubprocess1.FlowElements.Add(exclusivegateway2);
			ProcessSchemaExclusiveGateway exclusivegateway3 = CreateExclusiveGateway3ExclusiveGateway();
			eventsubprocess1.FlowElements.Add(exclusivegateway3);
			ProcessSchemaScriptTask showsyssettingseditorsscripttask = CreateShowSysSettingsEditorsScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(showsyssettingseditorsscripttask);
			ProcessSchemaScriptTask shownotadminmessagescripttask = CreateShowNotAdminMessageScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(shownotadminmessagescripttask);
			ProcessSchemaScriptTask authuserscripttask = CreateAuthUserScriptTaskScriptTask();
			FlowElements.Add(authuserscripttask);
			ProcessSchemaStartMessageEvent okbuttonclickstartmessage = CreateOKButtonClickStartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(okbuttonclickstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent okbuttonclickintermediatethrowmessageevent = CreateOKButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(okbuttonclickintermediatethrowmessageevent);
			ProcessSchemaScriptTask savesettingsscripttask = CreateSaveSettingsScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(savesettingsscripttask);
			ProcessSchemaScriptTask deleteoldaccountsscripttask = CreateDeleteOldAccountsScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(deleteoldaccountsscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateCheckOperationRightsConditionalFlowConditionalFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateErrorLocalizableString());
			LocalizableStrings.Add(CreateErrorNotHasRightsLocalizableString());
			LocalizableStrings.Add(CreateHelpCaptionLocalizableString());
			LocalizableStrings.Add(CreateHelpMessageLocalizableString());
			LocalizableStrings.Add(CreateCommunicationTypeNotFoundLocalizableString());
			LocalizableStrings.Add(CreateGoogleConsumerKeyLocalizableString());
			LocalizableStrings.Add(CreateLinkedInConsumerKeyLocalizableString());
			LocalizableStrings.Add(CreateFacebookConsumerKeyLocalizableString());
			LocalizableStrings.Add(CreateTwitterConsumerKeyLocalizableString());
			LocalizableStrings.Add(CreateGoogleSecretKeyLocalizableString());
			LocalizableStrings.Add(CreateLinkedInSecretKeyLocalizableString());
			LocalizableStrings.Add(CreateFacebookSecretKeyLocalizableString());
			LocalizableStrings.Add(CreateTwitterSecretKeyLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("cc69999f-05b8-4671-b85d-cf8286a80b52"),
				Name = "Error",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateErrorNotHasRightsLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d764dfc3-8264-4b3c-b3af-9222689da290"),
				Name = "ErrorNotHasRights",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateHelpCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7a517da2-1153-4980-b7a7-daeff1ec980c"),
				Name = "HelpCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateHelpMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5ca39f5f-60ba-42f3-a76c-755cf04b55af"),
				Name = "HelpMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCommunicationTypeNotFoundLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("707c6722-37bd-4aa1-a0e6-32835815f66e"),
				Name = "CommunicationTypeNotFound",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateGoogleConsumerKeyLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e574c10d-b0c4-43a9-87d7-e982319f605f"),
				Name = "GoogleConsumerKey",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLinkedInConsumerKeyLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("738f498b-0dfd-4701-839f-7b3090a76d9d"),
				Name = "LinkedInConsumerKey",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFacebookConsumerKeyLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f9b55a68-64e0-4bee-8aa8-81204142771c"),
				Name = "FacebookConsumerKey",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTwitterConsumerKeyLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("864afbe1-571c-47ee-a948-57c90fdc8d6b"),
				Name = "TwitterConsumerKey",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateGoogleSecretKeyLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("635b702a-6b9d-491a-8475-109d6861fc2e"),
				Name = "GoogleSecretKey",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLinkedInSecretKeyLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d2f1ca94-ae02-499d-8752-2de5a19d0f69"),
				Name = "LinkedInSecretKey",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFacebookSecretKeyLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("29ffe8a5-6e62-4a61-a9ec-c9d553595de5"),
				Name = "FacebookSecretKey",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTwitterSecretKeyLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2d80db63-4fd4-4d90-8979-8c1e981fc44d"),
				Name = "TwitterSecretKey",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("3631072e-8784-4c5f-8147-770b65f1b1b6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				CurveCenterPosition = new Point(201, 144),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a093693d-ab70-472c-b694-984f18f30e69"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("61984a8e-37b9-43e2-ad69-d308206056a5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("a8106106-cdca-469f-9c87-d03ff821c45a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				CurveCenterPosition = new Point(360, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("61984a8e-37b9-43e2-ad69-d308206056a5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("335abd18-a757-4b50-a66a-bb5153ea3793"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(313, 88));
			schemaFlow.PolylinePointPositions.Add(new Point(313, 95));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("934a467f-e258-4c75-9f39-6a6e0c75974c"),
				ConditionExpression = @"IsBpmConfigurated",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				CurveCenterPosition = new Point(648, 102),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("335abd18-a757-4b50-a66a-bb5153ea3793"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("33da7af3-698d-4e1d-b15f-dd82bb52a181"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(547, 95));
			schemaFlow.PolylinePointPositions.Add(new Point(547, 99));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow3",
				UId = new Guid("4e9c7e3b-2664-4d4c-abc7-c0bede8eb899"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				CurveCenterPosition = new Point(421, 170),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("335abd18-a757-4b50-a66a-bb5153ea3793"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5b341fdb-7b38-4e54-b002-e857b91519f5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateCheckOperationRightsConditionalFlowConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "CheckOperationRightsConditionalFlow",
				UId = new Guid("2fea167b-c1e5-4ace-a12e-a3a7c123b015"),
				ConditionExpression = @"UserConnection.DBSecurityEngine.GetCanExecuteOperation(""CanManageAdministration"")",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				CurveCenterPosition = new Point(312, 282),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5b341fdb-7b38-4e54-b002-e857b91519f5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dd0d7955-fd93-4d1b-b6dd-70891ea347c1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(190, 228));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow4",
				UId = new Guid("c9345a72-a26a-4ce6-8675-bd68bb294139"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				CurveCenterPosition = new Point(495, 280),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5b341fdb-7b38-4e54-b002-e857b91519f5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("048b09ba-3cb3-4750-adb5-efecddcea9ac"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(379, 271));
			schemaFlow.PolylinePointPositions.Add(new Point(498, 271));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("588ba44f-18ec-4ca9-8f3e-c35deac9e133"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				CurveCenterPosition = new Point(196, 756),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("813d8c9b-e8ba-4b0b-b308-5edb9a39a027"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("51e95151-1d21-4e0f-a64e-3185de46db25"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("3df0e372-aec6-4e9a-b39b-64858ca92b63"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				CurveCenterPosition = new Point(327, 754),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("51e95151-1d21-4e0f-a64e-3185de46db25"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5cc40a5f-9b52-40a5-a7f0-8d829568fefc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("fb3e00c1-bd53-4680-839c-6ad95a90218e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				CurveCenterPosition = new Point(638, 433),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3f601495-6560-4aaa-9cc4-69b9885802e9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("33da7af3-698d-4e1d-b15f-dd82bb52a181"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet60LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet60 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("ef250bee-b361-45a3-9521-27fa8356384f"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Name = @"LaneSet60",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1050, 457),
				UseBackgroundMode = false
			};
			return schemaLaneSet60;
		}

		protected virtual ProcessSchemaLane CreateLane164Lane() {
			ProcessSchemaLane schemaLane164 = new ProcessSchemaLane(this) {
				UId = new Guid("3fa35e26-6ef0-47ff-82ef-c2e78b2045e8"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("ef250bee-b361-45a3-9521-27fa8356384f"),
				CreatedInOwnerSchemaUId = new Guid("3b22f0ff-034a-48da-8758-a0660e5a26ff"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Name = @"Lane164",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1021, 457),
				UseBackgroundMode = false
			};
			return schemaLane164;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("dedd769c-3815-42c4-a533-3daecd155756"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3fa35e26-6ef0-47ff-82ef-c2e78b2045e8"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(581, 429),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a093693d-ab70-472c-b694-984f18f30e69"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dedd769c-3815-42c4-a533-3daecd155756"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateIsBpmConfiguratedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("61984a8e-37b9-43e2-ad69-d308206056a5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dedd769c-3815-42c4-a533-3daecd155756"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Name = @"IsBpmConfiguratedScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(155, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,193,110,194,48,16,68,207,32,241,15,171,156,28,85,226,7,170,30,10,170,104,84,137,30,162,246,238,134,77,176,234,216,145,189,134,210,194,191,119,137,41,13,37,112,232,213,59,243,60,59,118,102,20,41,169,213,39,78,173,33,252,160,71,212,205,36,16,89,35,210,219,209,48,243,147,166,230,81,169,170,224,36,225,2,238,160,148,218,35,207,60,57,101,42,40,172,241,161,70,247,132,155,243,195,28,11,135,196,231,111,214,106,8,30,103,214,86,26,243,165,116,184,184,111,26,173,10,73,202,26,198,138,189,36,157,33,229,27,159,35,17,99,94,165,14,40,146,151,139,182,100,159,81,149,32,46,147,83,248,26,13,7,43,233,160,138,2,116,43,116,188,146,193,130,172,227,139,13,174,97,214,55,107,27,104,173,63,235,100,166,180,236,232,37,141,57,250,180,163,139,238,78,59,108,236,114,198,177,176,193,105,85,127,69,199,2,119,128,92,123,187,204,161,99,111,11,126,186,57,210,218,186,247,185,172,145,189,156,65,36,121,119,144,244,196,16,145,208,87,246,57,244,6,146,233,175,251,20,119,204,252,95,98,4,180,208,93,124,201,8,26,103,126,30,180,126,118,15,117,67,27,209,137,159,194,118,11,87,69,145,153,166,251,170,174,253,223,1,171,130,51,64,46,96,188,191,79,125,152,118,181,223,155,232,239,141,53,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("335abd18-a757-4b50-a66a-bb5153ea3793"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dedd769c-3815-42c4-a533-3daecd155756"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(302, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway3ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("5b341fdb-7b38-4e54-b002-e857b91519f5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dedd769c-3815-42c4-a533-3daecd155756"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Name = @"ExclusiveGateway3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(302, 184),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateShowSysSettingsEditorsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("dd0d7955-fd93-4d1b-b6dd-70891ea347c1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dedd769c-3815-42c4-a533-3daecd155756"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Name = @"ShowSysSettingsEditorsScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 303),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,85,203,142,218,48,20,93,131,196,63,88,217,144,168,81,212,110,65,149,218,161,48,141,90,152,81,131,218,181,113,110,24,11,199,142,108,103,24,132,248,247,218,142,129,76,129,41,69,221,68,126,156,115,239,185,47,71,105,73,249,18,41,65,40,102,51,208,107,33,87,51,92,2,250,136,238,65,135,65,214,190,8,162,97,175,75,139,80,57,82,146,170,89,205,216,131,28,151,149,222,132,39,38,162,8,109,123,221,206,35,94,66,114,135,21,76,65,41,179,126,196,28,88,50,98,128,101,104,237,93,0,124,206,115,191,15,53,213,12,6,104,44,165,144,49,210,240,162,7,104,36,202,178,230,148,96,77,5,159,111,42,152,9,61,17,53,207,99,99,177,83,54,76,123,62,64,211,227,38,241,54,8,19,10,47,172,209,2,51,5,49,82,79,98,157,18,193,7,72,203,26,156,172,142,4,93,75,222,32,204,193,174,215,253,91,40,207,88,34,14,235,239,148,175,76,254,204,10,217,229,72,240,130,46,29,192,95,38,35,92,89,221,6,228,115,25,153,100,103,27,149,129,214,102,247,19,179,26,78,19,138,222,161,224,7,44,169,161,184,176,173,156,160,109,214,126,210,220,88,29,191,104,144,28,179,12,228,51,37,224,205,42,75,104,48,201,92,100,206,177,147,117,62,46,139,84,182,14,161,183,111,161,202,247,11,145,180,210,198,147,111,133,137,144,37,214,225,167,96,251,126,151,8,30,246,153,193,19,70,201,170,31,163,162,230,196,234,13,77,67,108,209,28,164,196,74,20,58,17,21,240,95,148,231,98,29,246,183,31,118,253,104,136,118,187,104,24,196,111,116,13,5,174,211,47,241,127,200,219,33,240,204,197,50,197,220,108,164,141,183,57,8,155,24,47,231,167,213,161,70,176,111,210,215,249,248,10,172,242,181,142,79,103,44,178,129,54,237,124,74,243,166,227,127,169,101,112,103,194,178,70,47,246,127,202,11,231,194,9,186,98,10,92,228,166,129,85,93,130,252,6,155,113,78,117,50,55,146,77,233,31,88,222,186,185,161,151,91,236,224,196,89,6,196,12,224,31,46,111,245,208,24,115,78,212,154,106,242,116,230,181,114,143,21,49,69,70,193,189,16,75,6,193,192,190,2,103,51,112,156,223,78,7,53,232,22,100,120,194,123,29,204,145,221,80,15,183,142,184,144,128,87,195,131,22,91,99,200,83,126,173,154,61,254,38,61,123,242,155,138,38,152,192,66,136,213,181,138,246,248,155,20,237,201,111,42,154,155,154,154,33,185,86,144,135,223,164,199,115,47,200,201,161,192,53,211,131,246,161,249,111,248,63,137,29,170,225,111,19,169,190,88,113,7,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateShowNotAdminMessageScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("048b09ba-3cb3-4750-adb5-efecddcea9ac"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dedd769c-3815-42c4-a533-3daecd155756"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Name = @"ShowNotAdminMessageScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(414, 303),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,80,77,79,131,64,16,61,75,194,127,152,244,4,9,161,222,76,104,60,88,172,214,52,45,196,246,15,140,203,20,54,46,59,205,238,144,202,191,23,90,18,245,80,111,243,230,125,204,228,149,88,83,154,179,245,93,75,110,67,253,170,210,146,174,117,85,145,133,71,16,215,209,34,12,202,223,162,61,41,71,242,175,180,216,44,59,17,182,55,130,208,42,50,147,34,199,147,104,30,37,127,157,211,126,240,76,174,37,122,218,146,247,195,92,162,37,147,230,134,208,69,241,226,22,255,84,85,19,142,68,139,161,12,86,206,177,75,64,232,75,50,240,226,180,173,211,23,118,45,74,116,161,118,44,107,244,239,186,110,196,39,240,74,18,205,246,172,52,154,29,201,153,221,231,44,142,147,48,184,107,175,169,135,254,52,100,110,127,64,58,229,43,195,30,63,198,131,71,52,158,18,240,13,159,223,20,219,236,82,195,248,241,124,14,135,226,185,0,213,160,173,9,58,79,14,44,139,62,246,160,45,60,164,247,97,48,116,220,57,123,45,238,27,64,159,216,151,165,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateAuthUserScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("33da7af3-698d-4e1d-b15f-dd82bb52a181"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3fa35e26-6ef0-47ff-82ef-c2e78b2045e8"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Name = @"AuthUserScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(687, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,87,93,111,26,59,16,125,222,72,249,15,150,95,216,21,43,255,128,160,72,151,80,218,160,42,31,42,228,246,225,82,85,102,119,40,123,99,108,100,123,67,80,203,127,239,216,94,96,55,4,146,166,121,201,198,187,103,198,103,230,140,199,195,3,215,196,168,172,224,226,26,236,82,233,251,107,62,7,114,78,62,129,141,233,176,254,129,38,157,211,147,98,74,98,99,117,33,127,176,129,185,46,133,184,209,253,249,194,174,226,61,31,73,66,126,158,158,68,241,45,255,1,172,107,22,238,73,184,33,35,208,154,27,53,181,236,110,192,190,194,164,167,164,213,74,24,230,0,9,235,9,101,32,118,91,69,26,108,169,37,153,114,97,0,215,235,211,147,7,36,203,179,12,140,25,169,123,144,72,179,226,226,57,116,234,128,33,100,104,127,4,22,8,15,242,253,175,97,73,144,167,210,87,232,10,121,85,54,129,209,191,92,148,240,25,86,104,89,101,168,155,101,170,148,182,91,218,217,119,74,218,228,83,89,228,236,26,150,238,233,99,113,198,106,1,18,180,223,208,39,247,198,175,93,212,131,156,110,64,166,244,236,251,15,32,237,86,133,218,59,151,217,45,120,202,11,1,121,69,113,131,254,232,95,54,193,19,165,4,225,26,110,185,230,115,227,227,220,133,221,212,177,25,98,66,126,253,66,37,158,69,110,226,57,134,169,135,115,12,215,136,164,10,47,226,152,78,164,25,82,220,83,243,121,105,185,85,154,225,191,11,1,22,92,186,209,111,145,113,91,40,25,223,25,208,88,76,18,50,183,76,247,171,58,197,221,85,105,235,21,148,146,221,139,90,197,132,215,155,10,9,171,122,57,56,134,245,53,178,188,180,118,113,103,11,81,216,21,187,180,115,209,151,153,202,33,126,106,229,206,79,136,235,156,56,254,95,192,148,194,178,15,133,201,184,206,223,235,200,88,93,250,19,67,0,143,14,57,176,103,40,148,176,229,193,99,221,224,159,56,104,228,42,175,196,92,99,208,18,150,196,165,221,39,45,246,229,231,190,20,88,207,169,39,225,73,69,86,175,252,46,81,180,167,229,208,114,109,255,88,72,191,127,240,189,38,104,149,205,72,220,232,85,253,199,12,22,206,154,64,32,29,249,156,162,87,83,206,65,99,101,247,243,194,178,203,34,207,125,127,168,18,246,20,23,74,226,37,244,205,231,139,210,90,37,15,187,227,50,3,81,129,122,60,16,59,39,77,227,234,125,205,236,130,27,168,82,127,203,37,8,20,26,184,14,66,31,130,116,243,205,41,138,109,97,5,156,145,175,92,75,212,21,245,128,71,123,70,128,85,223,83,239,37,154,135,213,104,181,64,236,213,110,193,182,118,25,150,23,159,56,87,190,19,163,30,51,181,28,100,74,158,213,36,246,21,212,236,48,73,165,121,116,125,55,248,226,235,178,239,138,105,164,66,227,219,59,26,14,250,23,165,143,165,224,235,1,255,84,117,239,183,127,165,238,127,36,251,75,170,191,77,244,151,53,127,171,228,181,68,7,213,223,73,244,195,154,191,94,242,191,81,220,107,189,223,245,170,46,251,12,177,3,157,176,186,96,43,242,91,238,88,0,102,75,189,113,105,60,115,97,108,46,11,207,108,253,222,131,207,107,136,55,219,38,27,226,7,124,126,224,150,255,215,188,212,191,97,25,254,67,209,194,135,75,169,143,128,210,51,66,169,27,94,234,3,86,27,129,148,166,1,23,226,117,192,6,178,62,105,53,241,85,74,118,174,183,51,87,192,185,76,209,16,160,191,85,204,164,199,133,152,240,236,190,186,91,134,254,74,186,40,11,145,67,117,8,118,24,214,93,160,52,121,76,199,210,25,47,11,153,171,101,24,203,90,180,189,27,183,218,180,213,161,135,109,251,143,150,249,249,228,138,75,20,66,51,188,129,130,175,148,180,38,48,85,26,74,41,20,207,91,41,153,150,210,39,55,198,140,143,229,216,30,116,235,244,10,78,88,224,193,118,234,119,255,231,143,87,96,103,42,55,108,52,211,106,217,19,5,110,31,102,164,35,68,199,118,108,221,174,242,45,142,227,131,142,183,121,75,91,1,243,170,67,178,239,168,49,234,117,158,116,225,125,248,222,196,23,173,163,231,9,182,144,24,22,76,179,134,217,72,133,226,64,41,218,132,182,146,206,250,72,234,214,41,217,72,250,211,160,17,246,53,215,44,214,73,40,140,97,166,139,197,70,127,98,26,171,115,18,199,199,79,238,112,101,44,204,221,123,230,134,64,247,17,219,46,235,149,90,99,42,54,207,75,46,115,129,67,11,251,136,68,42,7,56,218,215,247,162,137,107,19,141,87,238,215,72,125,237,154,125,0,196,181,64,119,185,112,209,188,189,241,212,251,232,111,99,155,209,135,24,14,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("bdd1b2ef-9841-48d9-bb20-eedbc4f58b2d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3fa35e26-6ef0-47ff-82ef-c2e78b2045e8"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(49, 476),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(595, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOKButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("813d8c9b-e8ba-4b0b-b308-5edb9a39a027"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bdd1b2ef-9841-48d9-bb20-eedbc4f58b2d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Name = @"OKButtonClickStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 36),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateOKButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("51e95151-1d21-4e0f-a64e-3185de46db25"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bdd1b2ef-9841-48d9-bb20-eedbc4f58b2d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Name = @"OKButtonClickIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 36),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSaveSettingsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5cc40a5f-9b52-40a5-a7f0-8d829568fefc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bdd1b2ef-9841-48d9-bb20-eedbc4f58b2d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Name = @"SaveSettingsScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(267, 22),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,82,203,78,195,48,16,60,183,82,255,97,149,83,42,42,151,27,82,43,14,208,86,8,161,62,164,4,238,198,221,164,22,142,93,173,29,218,8,241,239,56,78,160,168,129,3,23,46,214,122,61,51,158,89,219,81,5,111,131,126,239,149,19,8,163,109,89,32,61,96,149,160,115,82,231,118,197,11,132,107,184,67,23,71,137,17,146,171,21,186,131,161,151,104,8,23,16,205,78,140,104,218,85,121,226,170,172,233,27,158,35,251,134,93,108,165,99,41,30,253,66,178,136,135,53,53,69,34,110,77,230,60,144,2,58,147,121,73,220,73,163,89,82,217,79,71,204,23,115,204,130,116,252,104,145,60,82,163,168,97,163,223,18,140,58,166,194,149,103,134,19,20,132,238,143,201,27,82,39,124,211,254,49,127,115,244,31,83,232,6,58,63,251,154,197,59,8,238,196,14,226,197,81,224,190,150,1,60,14,195,207,8,230,111,185,197,37,90,235,235,13,215,168,216,76,33,167,198,243,207,128,155,237,182,221,199,30,211,115,210,41,156,192,130,200,208,40,52,124,240,137,191,132,181,168,208,44,154,58,173,246,30,187,60,109,88,195,3,161,140,229,207,181,80,198,149,245,113,236,206,28,238,125,166,9,56,106,95,117,60,134,116,61,95,131,216,113,157,35,148,126,56,160,141,147,89,5,82,195,21,187,244,24,31,189,36,221,136,212,233,7,253,182,83,171,76,63,0,46,103,10,88,20,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleteOldAccountsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3f601495-6560-4aaa-9cc4-69b9885802e9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bdd1b2ef-9841-48d9-bb20-eedbc4f58b2d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Name = @"DeleteOldAccountsScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(435, 22),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,142,189,10,194,48,24,69,103,11,125,135,216,41,89,242,2,197,65,106,5,113,176,96,197,57,164,87,13,228,7,191,38,88,17,223,221,128,14,197,249,28,238,185,230,194,248,193,14,77,240,99,114,160,61,158,178,39,227,184,96,203,21,235,212,21,114,134,218,193,68,217,99,138,63,71,176,87,89,44,60,30,108,3,139,8,126,26,65,217,247,208,209,4,47,50,92,200,45,5,199,171,99,208,70,217,181,214,33,249,88,125,201,249,6,2,175,102,129,74,200,221,216,222,147,178,188,9,54,57,47,59,69,202,229,105,250,123,41,132,108,39,232,148,163,162,46,139,119,89,16,98,34,207,34,37,212,31,106,164,62,118,214,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetMethod());
			Methods.Add(CreateNUIReturnKeysToOpenerMethod());
			Methods.Add(CreateNUIReturnErrorToOpenerMethod());
			Methods.Add(CreateGetSysSettingValueMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6b1607ec-968f-488b-ba8d-0a0ff4f2fc1c"),
				Name = "Terrasoft.Social",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("05813d5e-5f4f-43a1-822b-e332d1cf264a"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6244a046-7e7b-4005-bff3-ca70b6f0ed62"),
				Name = "System.Web",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa1114a1-b283-4276-a86e-e586f8e33f92"),
				Name = "Terrasoft.GoogleServerConnector",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		protected override SchemaMethod CreateInitializeContextHelpButtonMethod() {
			SchemaMethod method = base.CreateInitializeContextHelpButtonMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,146,205,110,194,48,16,132,207,169,212,119,112,125,64,137,132,114,168,10,135,162,94,138,90,18,169,69,149,128,222,77,188,132,85,130,141,236,77,169,90,241,238,181,161,252,132,132,147,229,217,249,118,71,107,227,130,133,119,35,160,212,14,181,34,248,166,4,202,245,115,69,164,85,130,82,130,10,35,214,233,176,75,199,139,18,243,18,100,24,69,236,247,246,38,176,100,80,229,204,234,12,69,57,6,218,104,83,140,197,10,216,147,39,67,62,57,47,240,104,224,144,47,97,216,210,117,202,180,244,54,206,189,104,55,72,217,146,133,141,70,251,49,65,38,44,48,254,42,50,152,107,93,240,71,175,5,231,93,122,253,135,93,163,32,152,27,16,197,224,4,189,161,42,64,166,170,21,234,93,129,166,46,15,129,105,101,250,87,152,145,214,121,9,173,200,253,37,178,61,237,206,59,255,23,156,74,103,63,144,222,246,33,114,136,27,239,19,39,45,200,241,126,216,113,101,193,56,81,65,70,168,149,115,237,154,205,106,170,247,78,39,238,190,192,188,50,194,75,241,39,74,208,126,194,140,176,68,66,176,113,170,220,41,74,252,129,70,150,176,61,98,183,158,169,203,222,65,85,190,156,18,172,134,98,237,39,237,197,227,184,90,165,30,222,255,155,237,31,123,46,227,231,177,2,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("635de7cc-15f3-4c22-9dfa-a80c82e19d24"),
				Name = "Get",
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("83410a56-e56f-449b-8bb1-75b1e97c806c"),
				Name = "queryStringParameterName",
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,142,187,110,2,49,16,69,235,248,43,44,170,221,198,124,0,162,128,37,10,17,18,79,109,133,82,88,112,89,89,50,54,140,199,11,171,40,255,142,113,18,145,38,84,51,26,157,123,231,180,154,100,96,205,144,67,185,212,13,212,26,231,136,192,106,21,65,221,134,201,184,102,219,203,68,239,99,32,204,161,8,249,166,222,195,60,90,187,160,215,227,137,187,34,3,101,41,63,197,11,129,35,185,255,203,206,143,125,169,73,31,193,160,121,26,169,253,75,244,251,114,58,170,102,242,224,73,190,121,223,88,136,54,25,230,76,50,156,50,159,106,54,214,112,167,82,56,224,79,113,225,112,145,53,153,113,52,118,15,42,238,108,229,29,227,202,170,138,68,112,172,54,160,22,164,106,178,19,236,252,30,191,222,223,130,229,64,252,200,231,127,207,76,133,184,1,220,6,106,140,57,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateNUIReturnKeysToOpenerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("717473e5-beb4-4e82-b517-02329cdf8ad2"),
				Name = "NUIReturnKeysToOpener",
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				CreatedInPackageId = new Guid("e5c6d42d-4b63-47d7-b457-31cfe9b5fb3a"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b7985010-9ec2-4c2f-994a-9f65e3a7cdfc"),
				Name = "accessToken",
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("e5c6d42d-4b63-47d7-b457-31cfe9b5fb3a")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("86f3e2b4-6fdf-47a2-a143-f0facffdbd1a"),
				Name = "accessSecretToken",
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("e5c6d42d-4b63-47d7-b457-31cfe9b5fb3a")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("faa993cb-0731-4c7c-8667-9e0496b461f0"),
				Name = "socialId",
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("e5c6d42d-4b63-47d7-b457-31cfe9b5fb3a")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,65,106,195,48,16,188,23,250,135,197,23,75,52,232,1,53,57,164,33,37,57,20,10,78,232,197,23,217,90,7,19,117,101,86,114,210,18,242,247,202,137,67,98,74,78,146,102,103,71,59,35,237,53,131,47,231,218,218,82,87,59,152,2,225,1,242,192,13,109,223,186,198,26,100,33,179,231,167,27,69,205,218,22,201,136,164,160,197,79,80,139,61,82,248,208,164,183,200,202,145,56,52,100,220,97,2,105,137,181,99,236,200,58,109,210,9,212,29,85,161,137,4,9,199,130,138,144,60,80,109,106,24,52,148,139,8,178,124,196,236,85,138,208,139,209,168,65,49,134,142,105,86,85,232,253,218,237,144,188,72,31,136,232,27,9,94,32,137,115,166,73,220,92,224,28,171,40,245,175,232,93,213,104,187,50,247,216,198,35,207,29,17,158,61,170,121,199,28,99,233,81,53,16,101,118,122,108,228,52,129,107,110,71,31,147,183,248,26,184,195,147,204,206,61,121,197,77,123,13,25,252,232,52,5,33,214,200,172,189,171,131,218,172,212,23,150,113,146,192,206,122,245,25,41,50,255,245,1,191,123,92,45,67,104,251,34,198,135,27,102,188,174,75,77,198,198,180,213,123,28,100,16,16,201,232,230,68,130,246,48,130,122,67,247,103,53,51,230,66,16,119,70,215,238,242,161,132,148,217,31,111,114,95,160,112,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateNUIReturnErrorToOpenerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f4e081a0-c493-4e41-a993-3696f67a8459"),
				Name = "NUIReturnErrorToOpener",
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				CreatedInPackageId = new Guid("e5c6d42d-4b63-47d7-b457-31cfe9b5fb3a"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a3cea043-09f4-46b2-a525-edde7f673d09"),
				Name = "message",
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("e5c6d42d-4b63-47d7-b457-31cfe9b5fb3a")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,145,193,110,194,48,12,134,239,147,246,14,86,47,36,26,202,3,12,113,96,136,137,29,144,38,193,180,75,47,41,113,89,181,224,84,142,3,155,16,239,190,116,128,182,30,122,138,108,127,254,109,255,57,88,134,88,205,173,247,149,221,126,194,20,8,143,176,22,110,104,247,148,26,239,144,149,158,220,223,253,33,102,214,182,72,78,21,37,45,190,196,44,14,72,178,178,100,119,200,38,144,58,54,228,194,113,12,163,10,235,192,152,200,7,235,70,99,168,19,109,165,201,128,134,83,73,165,20,3,170,77,13,87,13,19,114,6,89,15,145,157,74,41,157,24,245,26,12,163,36,166,89,146,143,5,115,224,21,198,152,183,83,101,49,160,180,191,0,240,0,69,153,145,243,240,192,243,24,110,247,157,98,118,200,227,163,112,194,179,158,252,246,172,183,220,180,55,51,32,246,162,41,40,181,65,102,27,67,45,230,237,197,188,99,53,15,36,28,124,52,175,25,209,235,239,40,184,239,242,102,41,210,118,69,204,6,207,19,115,182,248,246,46,45,57,159,93,49,207,121,145,171,128,42,122,147,11,13,54,66,47,213,29,244,63,54,51,231,46,128,250,119,232,38,92,62,94,105,61,249,1,67,44,44,242,24,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSysSettingValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e339102f-2ed5-4b44-8fe7-f8a2f0e86921"),
				Name = "GetSysSettingValue",
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "object"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e9dd979c-aa27-4855-9b0d-72f5d98e951a"),
				Name = "settingCode",
				CreatedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				ModifiedInSchemaUId = new Guid("91705f84-33f7-486d-9060-de01a52e0c92"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,142,65,14,130,48,16,69,215,244,20,77,87,109,66,184,0,59,137,26,19,227,6,116,95,96,84,12,118,204,116,42,162,241,238,66,20,19,214,255,229,253,135,229,5,42,150,119,219,6,72,69,115,148,58,239,125,14,204,141,59,249,164,160,126,13,124,24,71,189,247,64,25,58,55,224,13,186,88,250,47,148,97,13,177,196,240,115,24,35,95,34,34,224,64,110,178,190,5,159,9,59,233,160,147,27,134,235,14,121,133,193,213,203,71,5,183,81,166,199,101,139,149,109,155,167,45,91,200,153,6,179,86,5,16,89,143,71,78,50,36,80,177,136,212,188,34,249,43,146,169,121,209,143,69,211,133,50,179,80,147,126,0,30,210,83,15,240,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SocialAccountAuthPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("91705f84-33f7-486d-9060-de01a52e0c92"));
		}

		#endregion

	}

	#endregion

}

