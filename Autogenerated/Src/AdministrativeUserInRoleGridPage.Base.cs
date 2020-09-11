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

	#region Class: AdministrativeUserInRoleGridPageSchema

	/// <exclude/>
	public class AdministrativeUserInRoleGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Constructors: Public

		public AdministrativeUserInRoleGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AdministrativeUserInRoleGridPageSchema(AdministrativeUserInRoleGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.AjaxEvents.Click.IsProcessEventHandler = true;
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.Hidden = true;
			EditButton.ModifiedInSchemaUId = new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b");
		}

		private void UpdateDeleteButton() {
			DeleteButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b");
			RealUId = new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b");
			Name = "AdministrativeUserInRoleGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAdministrativeUserInRoleGridPageEventsProcessSchema();
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
			TopLevelControl.MoveItem(0, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.MoveItem(4, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(5, ActionButton);
			ButtonsControlLayout.MoveItem(6, PrintButton);
			ButtonsControlLayout.MoveItem(7, ContextHelpButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateAdministrativeUserInRoleGridPageEventsProcessSchema() {
			var schema = new AdministrativeUserInRoleGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("4b27f502-c296-47cf-af5d-3197d54e0d2a");
			DataSource.ModifiedInSchemaUId = new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("a9cc8ad4-e4a6-47f9-814d-c77d99723f09");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b");
				column.ModifiedInSchemaUId = new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c540ad32-33ed-4ad0-abb7-cc1575b9f6f2");
			if (column != null) {
				column.UId = new Guid("5679656b-9016-45df-af29-e4b3431e705f");
				column.Name = @"SysUser";
				column.CreatedInSchemaUId = new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b");
				column.ModifiedInSchemaUId = new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ceffac9c-08c8-4792-a3fc-2931b23bc538");
			if (column != null) {
				column.UId = new Guid("1262ccd5-f2b5-4f05-9d97-120762aff5cd");
				column.Name = @"SysRole";
				column.CreatedInSchemaUId = new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b");
				column.ModifiedInSchemaUId = new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new AdministrativeUserInRoleGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new AdministrativeUserInRoleGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AdministrativeUserInRoleGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeUserInRoleGridPageEventsProcess

	/// <exclude/>
	public class AdministrativeUserInRoleGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AdministrativeUserInRoleGridPageSchemaUserControl
	{

		#region Class: OpenLookupUserTaskFlowElement

		/// <exclude/>
		public class OpenLookupUserTaskFlowElement : OpenLookupUserTask
		{

			public OpenLookupUserTaskFlowElement(UserConnection userConnection, AdministrativeUserInRoleGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenLookupUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("678b4cbe-bbf0-4075-9b24-4d9b0672c2ab");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: CantAddUserTaskFlowElement

		/// <exclude/>
		public class CantAddUserTaskFlowElement : QuestionUserTask
		{

			public CantAddUserTaskFlowElement(UserConnection userConnection, AdministrativeUserInRoleGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "CantAddUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("00b46d1f-4be2-4d1e-9d74-8ad8279e0bb9");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: LdapUserInLdapGroupUserTaskFlowElement

		/// <exclude/>
		public class LdapUserInLdapGroupUserTaskFlowElement : QuestionUserTask
		{

			public LdapUserInLdapGroupUserTaskFlowElement(UserConnection userConnection, AdministrativeUserInRoleGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "LdapUserInLdapGroupUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("41df0d0d-8e9e-41fb-9e6f-b5a9fd776156");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public AdministrativeUserInRoleGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdministrativeUserInRoleGridPageEventsProcess";
			SchemaUId = new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b");
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

		public virtual bool ldapUserInLdapGroup {
			get;
			set;
		}

		private ProcessFlowElement _subProcessOpenRoles;
		public ProcessFlowElement SubProcessOpenRoles {
			get {
				return _subProcessOpenRoles ?? (_subProcessOpenRoles = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessOpenRoles",
					SchemaElementUId = new Guid("a45bf1e0-54fd-442b-b9bd-0813c76f2974"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _messageOpenRoles;
		public ProcessFlowElement MessageOpenRoles {
			get {
				return _messageOpenRoles ?? (_messageOpenRoles = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MessageOpenRoles",
					SchemaElementUId = new Guid("ed2b8e13-d0b0-4861-805d-7988a6ab04d7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptOpenRoles;
		public ProcessScriptTask ScriptOpenRoles {
			get {
				return _scriptOpenRoles ?? (_scriptOpenRoles = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptOpenRoles",
					SchemaElementUId = new Guid("5e74e172-d81c-45ac-abe4-5778209b929f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptOpenRolesExecute,
				});
			}
		}

		private OpenLookupUserTaskFlowElement _openLookupUserTask;
		public OpenLookupUserTaskFlowElement OpenLookupUserTask {
			get {
				return _openLookupUserTask ?? (_openLookupUserTask = new OpenLookupUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessIntermediateCatchMessageEvent _catchMessage_LookupGridPageClosed;
		public ProcessIntermediateCatchMessageEvent CatchMessage_LookupGridPageClosed {
			get {
				return _catchMessage_LookupGridPageClosed ?? (_catchMessage_LookupGridPageClosed = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "CatchMessage_LookupGridPageClosed",
					SchemaElementUId = new Guid("de346683-e398-4609-bdbb-dfb2736a55a4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "LookupGridPageClosed",
				});
			}
		}

		private ProcessScriptTask _scriptAssotiateUserWithRole;
		public ProcessScriptTask ScriptAssotiateUserWithRole {
			get {
				return _scriptAssotiateUserWithRole ?? (_scriptAssotiateUserWithRole = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAssotiateUserWithRole",
					SchemaElementUId = new Guid("4252c10e-0653-4af8-90a6-a61f686dc3cd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAssotiateUserWithRoleExecute,
				});
			}
		}

		private CantAddUserTaskFlowElement _cantAddUserTask;
		public CantAddUserTaskFlowElement CantAddUserTask {
			get {
				return _cantAddUserTask ?? (_cantAddUserTask = new CantAddUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("f313174c-155c-47e3-a483-6743002b2ea2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessFlowElement _subProcessPageLoad;
		public ProcessFlowElement SubProcessPageLoad {
			get {
				return _subProcessPageLoad ?? (_subProcessPageLoad = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessPageLoad",
					SchemaElementUId = new Guid("e02c4ff7-ba25-4469-bdfd-876d5f80a18f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _message_PageLoad;
		public ProcessFlowElement Message_PageLoad {
			get {
				return _message_PageLoad ?? (_message_PageLoad = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "Message_PageLoad",
					SchemaElementUId = new Guid("e3f0934e-d367-47f6-88e3-a0f372860919"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask_PageLoad;
		public ProcessScriptTask ScriptTask_PageLoad {
			get {
				return _scriptTask_PageLoad ?? (_scriptTask_PageLoad = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask_PageLoad",
					SchemaElementUId = new Guid("9556aa11-81cd-4647-ab81-83177526868d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask_PageLoadExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _throwPageLoadParent;
		public ProcessThrowMessageEvent ThrowPageLoadParent {
			get {
				return _throwPageLoadParent ?? (_throwPageLoadParent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowPageLoadParent",
					SchemaElementUId = new Guid("bf9fd9c3-7110-4bfa-923f-050d7fce3f06"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoad",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("1598995d-3fcd-43c5-9648-0313c59ef649"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _childDeleteButtonClick;
		public ProcessFlowElement ChildDeleteButtonClick {
			get {
				return _childDeleteButtonClick ?? (_childDeleteButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChildDeleteButtonClick",
					SchemaElementUId = new Guid("a983ccdf-3a80-4a97-ba14-099fca58116a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptChildDeleteButtonClick;
		public ProcessScriptTask ScriptChildDeleteButtonClick {
			get {
				return _scriptChildDeleteButtonClick ?? (_scriptChildDeleteButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildDeleteButtonClick",
					SchemaElementUId = new Guid("9bd2c2af-806a-4fa8-b790-4c714c8e7c92"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildDeleteButtonClickExecute,
				});
			}
		}

		private LdapUserInLdapGroupUserTaskFlowElement _ldapUserInLdapGroupUserTask;
		public LdapUserInLdapGroupUserTaskFlowElement LdapUserInLdapGroupUserTask {
			get {
				return _ldapUserInLdapGroupUserTask ?? (_ldapUserInLdapGroupUserTask = new LdapUserInLdapGroupUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessConditionalFlow _conditionalFlow201;
		public ProcessConditionalFlow ConditionalFlow201 {
			get {
				return _conditionalFlow201 ?? (_conditionalFlow201 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow201",
					SchemaElementUId = new Guid("5d124de9-0b50-45f0-9a2a-cba09a6769dc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _cantDeleteLdapUserFromLdapGroupLS;
		public LocalizableString CantDeleteLdapUserFromLdapGroupLS {
			get {
				return _cantDeleteLdapUserFromLdapGroupLS ?? (_cantDeleteLdapUserFromLdapGroupLS = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CantDeleteLdapUserFromLdapGroupLS.Value"));
			}
		}

		private LocalizableString _cantInsertLdapUserToLdapGroupLS;
		public LocalizableString CantInsertLdapUserToLdapGroupLS {
			get {
				return _cantInsertLdapUserToLdapGroupLS ?? (_cantInsertLdapUserToLdapGroupLS = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CantInsertLdapUserToLdapGroupLS.Value"));
			}
		}

		private LocalizableString _addCantInsertLdapUserToLdapGroupLS;
		public LocalizableString AddCantInsertLdapUserToLdapGroupLS {
			get {
				return _addCantInsertLdapUserToLdapGroupLS ?? (_addCantInsertLdapUserToLdapGroupLS = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.AddCantInsertLdapUserToLdapGroupLS.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SubProcessOpenRoles.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessOpenRoles };
			FlowElements[MessageOpenRoles.SchemaElementUId] = new Collection<ProcessFlowElement> { MessageOpenRoles };
			FlowElements[ScriptOpenRoles.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptOpenRoles };
			FlowElements[OpenLookupUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenLookupUserTask };
			FlowElements[CatchMessage_LookupGridPageClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { CatchMessage_LookupGridPageClosed };
			FlowElements[ScriptAssotiateUserWithRole.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAssotiateUserWithRole };
			FlowElements[CantAddUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CantAddUserTask };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[SubProcessPageLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessPageLoad };
			FlowElements[Message_PageLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { Message_PageLoad };
			FlowElements[ScriptTask_PageLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask_PageLoad };
			FlowElements[ThrowPageLoadParent.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowPageLoadParent };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ChildDeleteButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildDeleteButtonClick };
			FlowElements[ScriptChildDeleteButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildDeleteButtonClick };
			FlowElements[LdapUserInLdapGroupUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LdapUserInLdapGroupUserTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcessOpenRoles":
						break;
					case "MessageOpenRoles":
						e.Context.QueueTasks.Enqueue("ScriptOpenRoles");
						break;
					case "ScriptOpenRoles":
						e.Context.QueueTasks.Enqueue("OpenLookupUserTask");
						break;
					case "OpenLookupUserTask":
						ActivatedEventElements.Add("CatchMessage_LookupGridPageClosed");
						break;
					case "CatchMessage_LookupGridPageClosed":
						e.Context.QueueTasks.Enqueue("ScriptAssotiateUserWithRole");
						break;
					case "ScriptAssotiateUserWithRole":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						if (ConditionalFlow201ExpressionExecute()) {
						e.Context.QueueTasks.Enqueue("CantAddUserTask");
							break;
						}
						break;
					case "CantAddUserTask":
						break;
					case "ScriptTask1":
						break;
					case "SubProcessPageLoad":
						break;
					case "Message_PageLoad":
						e.Context.QueueTasks.Enqueue("ScriptTask_PageLoad");
						break;
					case "ScriptTask_PageLoad":
						e.Context.QueueTasks.Enqueue("ThrowPageLoadParent");
						break;
					case "ThrowPageLoadParent":
						break;
					case "EventSubProcess1":
						break;
					case "ChildDeleteButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptChildDeleteButtonClick");
						break;
					case "ScriptChildDeleteButtonClick":
						e.Context.QueueTasks.Enqueue("LdapUserInLdapGroupUserTask");
						break;
					case "LdapUserInLdapGroupUserTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow201ExpressionExecute() {
			return Convert.ToBoolean(ldapUserInLdapGroup);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("MessageOpenRoles");
			ActivatedEventElements.Add("Message_PageLoad");
			ActivatedEventElements.Add("ChildDeleteButtonClick");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcessOpenRoles":
					context.QueueTasks.Dequeue();
					break;
				case "MessageOpenRoles":
					context.QueueTasks.Dequeue();
					context.SenderName = "MessageOpenRoles";
					result = MessageOpenRoles.Execute(context);
					break;
				case "ScriptOpenRoles":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptOpenRoles";
					result = ScriptOpenRoles.Execute(context, ScriptOpenRolesExecute);
					break;
				case "OpenLookupUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenLookupUserTask";
					result = OpenLookupUserTask.Execute(context);
					break;
				case "CatchMessage_LookupGridPageClosed":
					context.QueueTasks.Dequeue();
					context.SenderName = "CatchMessage_LookupGridPageClosed";
					result = CatchMessage_LookupGridPageClosed.Execute(context);
					break;
				case "ScriptAssotiateUserWithRole":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAssotiateUserWithRole";
					result = ScriptAssotiateUserWithRole.Execute(context, ScriptAssotiateUserWithRoleExecute);
					break;
				case "CantAddUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CantAddUserTask";
					result = CantAddUserTask.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "SubProcessPageLoad":
					context.QueueTasks.Dequeue();
					break;
				case "Message_PageLoad":
					context.QueueTasks.Dequeue();
					context.SenderName = "Message_PageLoad";
					result = Message_PageLoad.Execute(context);
					break;
				case "ScriptTask_PageLoad":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask_PageLoad";
					result = ScriptTask_PageLoad.Execute(context, ScriptTask_PageLoadExecute);
					break;
				case "ThrowPageLoadParent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoad");
					result = ThrowPageLoadParent.Execute(context);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "ChildDeleteButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildDeleteButtonClick";
					result = ChildDeleteButtonClick.Execute(context);
					break;
				case "ScriptChildDeleteButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildDeleteButtonClick";
					result = ScriptChildDeleteButtonClick.Execute(context, ScriptChildDeleteButtonClickExecute);
					break;
				case "LdapUserInLdapGroupUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "LdapUserInLdapGroupUserTask";
					result = LdapUserInLdapGroupUserTask.Execute(context);
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
				case "ldapUserInLdapGroup":
					ldapUserInLdapGroup = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptOpenRolesExecute(ProcessExecutingContext context) {
			string instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
			OpenLookupUserTask.ProcessKey = instanceId + Page.PageContainer.UniqueID;
			string schemaUId = "d5d01fcd-6d8c-4b29-9e58-cca3ffe62364";
			OpenLookupUserTask.PageParameters = new Dictionary <string, object>();
			var pageParameters = (Dictionary <string, object>)OpenLookupUserTask.PageParameters;
			pageParameters.Add("schemaUId", schemaUId);
			pageParameters.Add("useHierarchy", false);
			pageParameters.Add("hideButtons", true);
			Collection<Dictionary<string, object>> filters = new Collection<Dictionary<string, object>>();
			filters.Add(new Dictionary<string, object> { 
				 {"comparisonType", FilterComparisonType.NotEqual},
				 {"leftExpressionColumnPath", "SysAdminUnitType"},
				 {"useDisplayValue", false }, 
				 {"rightExpressionParameterValues", new object[] {new Guid("472E97C7-6BD7-DF11-9B2A-001D60E938C6")}}});
			filters.Add(new Dictionary<string, object> {
				{"comparisonType", FilterComparisonType.IsNotNull},
				{"leftExpressionColumnPath", "ParentRole"},
				{"useDisplayValue", false}}
			);
			pageParameters.Add("LookupFilters", filters);
			return true;
		}

		public virtual bool ScriptAssotiateUserWithRoleExecute(ProcessExecutingContext context) {
			var folderIds = (Dictionary <string, object>)OpenLookupUserTask.GetSelectedValues(UserConnection); 
			var ids = new Collection<Guid>();
			var modulePage = Page.PageContainer.Parent.NamingContainer as PageContainer;
			var tabPanel = modulePage.FindPageControlByName("GridTabPanel") as TabPanel;
			PageContainer grid = null;
			foreach (var item in tabPanel.Items) {
				if ((item as PageContainer) != null) {
					grid = item as PageContainer;
					break;
				}
			}
			if (grid != null) {
				var moduleDataSource = modulePage.FindPageControlByName("DataSource") as EntityDataSource;
				string primaryColumnName = moduleDataSource.Schema.PrimaryColumn.Name;
				string primaryDisplayColumnName = moduleDataSource.Schema.PrimaryDisplayColumn.Name;
				var moduleTreeGrid = grid.FindPageControlByName("TreeGrid") as TreeGrid;
				foreach(var row in moduleTreeGrid.SelectedNodes) {
					ids.Add(new Guid(row.Values[primaryColumnName].ToString()));
				}
			} else {
				ids.Add(SelectedNodePrimaryColumnValue);
			}
			var dataSource = Page.DataSource;
			Guid defValuesId = SetDefValues();
			var defValues = UserConnection.SessionData[defValuesId.ToString()] as Dictionary<string, object>;
			
			string defValueColumnName = String.Empty;
			foreach (var value in defValues) {
				defValueColumnName = value.Key.ToString();
				break;
			}
			string columnValueName = string.Empty;
			string columnName = string.Empty;
			if (!string.IsNullOrEmpty(defValueColumnName)) {
				columnValueName = dataSource.Schema.Columns.GetByName(defValueColumnName).ColumnValueName;
				columnName = dataSource.Schema.Columns.GetByName(defValueColumnName).Name;
			} else {
				columnValueName = "SysUserId";
				columnName = "SysUser";
			}
				
			var sysUserInRole = new SysUserInRole(Page.UserConnection);
			Dictionary<string, object> conditions = new Dictionary<string, object> {
				{ "SysRole", Guid.Empty },
				{ columnName, Guid.Empty }
			};
			Entity newRow;
			Guid recordId;
			ldapUserInLdapGroup = false;
			foreach (Guid id in ids) {
				var isLdapUser = GetIsLDAPEntry(id.ToString());
				foreach (var folderId in folderIds) {
					if (isLdapUser && GetIsLDAPEntry(folderId.Key)) {
						ldapUserInLdapGroup = true;
						continue;
					}
					conditions["SysRole"] = folderId.Key;
					conditions[columnName] = id;
					if (sysUserInRole.FetchFromDB(conditions)) {
						continue;
					}
			 		newRow = dataSource.CreateRow();
					recordId = Guid.NewGuid();
					newRow.SetColumnValue(dataSource.Schema.PrimaryColumn.Name, recordId);
					newRow.SetColumnValue("SysRoleId", (folderId.Key));
					newRow.SetColumnValue(columnValueName, id);
					newRow.Save();
					dataSource.LoadRow(recordId);
				}
			}
			if (ldapUserInLdapGroup) {
				CantAddUserTask.MessageText = (ids.Count > 1) || (folderIds.Count > 1) ? 
					AddCantInsertLdapUserToLdapGroupLS : CantInsertLdapUserToLdapGroupLS;
				CantAddUserTask.Page = Page;
				CantAddUserTask.Caption = Warning;
			}
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ScriptTask_PageLoadExecute(ProcessExecutingContext context) {
			Page.AddButton.AjaxEvents.Click.SignalName = "OpenRoles";
			return true;
		}

		public virtual bool ScriptChildDeleteButtonClickExecute(ProcessExecutingContext context) {
			ldapUserInLdapGroup = false;
			if (GetIsLDAPEntry(SelectedNodePrimaryColumnValue.ToString())) {
				var selectedNodes = Page.TreeGrid.SelectedNodes;
				if (selectedNodes.Count > 0) {
					foreach(var node in selectedNodes) {
						ldapUserInLdapGroup = ldapUserInLdapGroup ||
							GetIsLDAPEntry(node.Values["SysRoleId"].ToString());
					}
				}
			}
			if (ldapUserInLdapGroup) {
				LdapUserInLdapGroupUserTask.MessageText = CantDeleteLdapUserFromLdapGroupLS;
				LdapUserInLdapGroupUserTask.Caption= Warning;
				LdapUserInLdapGroupUserTask.Icon = "WARNING";
				LdapUserInLdapGroupUserTask.Buttons = "YES";
				LdapUserInLdapGroupUserTask.ResponseMessages = new Dictionary<string, string>();
			} else {
				LdapUserInLdapGroupUserTask.Icon = "QUESTION";
				LdapUserInLdapGroupUserTask.Buttons = "YESNO";
				LdapUserInLdapGroupUserTask.ResponseMessages = new Dictionary<string, string> {
					{"yes", "DeleteYesMessage"},
					{"no", "DeleteNoMessage"},
				};
				LdapUserInLdapGroupUserTask.MessageText = DeleteRecordMessage;
				LdapUserInLdapGroupUserTask.Caption= QuestionCaption;
			}
			LdapUserInLdapGroupUserTask.Page = Page;
			return true;
		}

		public override System.Collections.Generic.List<string> GetButtons() {
			var buttons = new System.Collections.Generic.List<string>();
			buttons.Add(Page.EditButton.Name);
			buttons.Add(Page.CopyButton.Name);
			buttons.Add(Page.DeleteButton.Name);
			return buttons;
		}

		public override void SetAdditionalDataSourceProperties() {
			if (IsDetailGrid) {
				var buttonsControlLayout = Page.ButtonsControlLayout;
				if (buttonsControlLayout != null) {
					var modulePage = (Page.PageContainer.Parent.NamingContainer as PageContainer).PageInstance as Terrasoft.WebApp.BaseModulePageSchemaUserControl;//ListenerPage as BaseModulePageSchemaUserControl;
					var gridTabPanel = modulePage.GridTabPanel;
					if (gridTabPanel.ActiveTabIndex != 0) {
						foreach(var button in buttonsControlLayout.Items) {
							if (button.Enabled) {
								button.Enabled = false;
							}
						}
					}
				}
			}
			return;
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public override string GetRegisterQuestionScript() {
			return string.Empty;
		}

		public override string GetRegisterEditPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return string.Empty;
		}

		public override string GetRegisterAddPageScript(Guid editPageUId, Guid sysModuleEditId, Guid typeId) {
			return string.Empty;
		}

		public virtual bool GetIsLDAPEntry(string sysAdminUnitId) {
			var sysAdminUnitSchema = UserConnection.EntitySchemaManager.GetInstanceByName("SysAdminUnit");
			var sysAdminUnit = sysAdminUnitSchema.CreateEntity(UserConnection);
			if (sysAdminUnit.FetchFromDB(sysAdminUnitId)) {
				return (bool)sysAdminUnit.GetColumnValue("SynchronizeWithLDAP");
			}
			return false;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OpenRoles":
							if (ActivatedEventElements.Contains("MessageOpenRoles")) {
							context.QueueTasks.Enqueue("MessageOpenRoles");
						}
						break;
					case "LookupGridPageClosed":
					if (ActivatedEventElements.Remove("CatchMessage_LookupGridPageClosed")) {
						context.QueueTasks.Enqueue("CatchMessage_LookupGridPageClosed");
					}
					break;
					case "PageLoad":
							if (ActivatedEventElements.Contains("Message_PageLoad")) {
							context.QueueTasks.Enqueue("Message_PageLoad");
						}
						break;
					case "DeleteButtonClick":
							if (ActivatedEventElements.Contains("ChildDeleteButtonClick")) {
							context.QueueTasks.Enqueue("ChildDeleteButtonClick");
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
			if (!HasMapping("ldapUserInLdapGroup") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ldapUserInLdapGroup", ldapUserInLdapGroup, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeUserInRoleGridPageEventsProcess

	/// <exclude/>
	public class AdministrativeUserInRoleGridPageEventsProcess : AdministrativeUserInRoleGridPageEventsProcess<Terrasoft.WebApp.AdministrativeUserInRoleGridPageSchemaUserControl>
	{

		public AdministrativeUserInRoleGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdministrativeUserInRoleGridPageSchemaUserControl

	/// <exclude/>
	public partial class AdministrativeUserInRoleGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			AddButton.AjaxEvents.Click.Event += AddButtonClick;
			DeleteButton.AjaxEvents.Click.Event += DeleteButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			AddButton.AjaxEvents.Click.Event -= AddButtonClick;
			DeleteButton.AjaxEvents.Click.Event -= DeleteButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (AdministrativeUserInRoleGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AdministrativeUserInRoleGridPageEventsProcess(UserConnection);
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

		public virtual void AddButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddButtonClick");
		}

		public virtual void DeleteButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("DeleteButtonClick");
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
			SchemaName = "AdministrativeUserInRoleGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeUserInRoleGridPageEventsProcessSchema

	/// <exclude/>
	public class AdministrativeUserInRoleGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public AdministrativeUserInRoleGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AdministrativeUserInRoleGridPageEventsProcessSchema(AdministrativeUserInRoleGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AdministrativeUserInRoleGridPageEventsProcess";
			UId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3");
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

		protected virtual ProcessSchemaParameter CreateldapUserInLdapGroupParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("69337002-34af-495e-bd05-272545aa969f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Name = @"ldapUserInLdapGroup",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateldapUserInLdapGroupParameter());
		}

		protected virtual void InitializeOpenLookupUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("f1dc9b9b-0ec0-4b10-b979-487ed60abe6d"),
				ContainerUId = new Guid("678b4cbe-bbf0-4075-9b24-4d9b0672c2ab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
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
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("e31fe3ed-5814-4c5b-94bf-df18295ecf62"),
				ContainerUId = new Guid("678b4cbe-bbf0-4075-9b24-4d9b0672c2ab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"ProcessKey",
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
				UId = new Guid("26cba720-22ed-42ab-a8dc-c6dd7e299964"),
				ContainerUId = new Guid("678b4cbe-bbf0-4075-9b24-4d9b0672c2ab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"UserContextKey",
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
				UId = new Guid("af3ea4f6-5316-43aa-8a25-c7dd847c3281"),
				ContainerUId = new Guid("678b4cbe-bbf0-4075-9b24-4d9b0672c2ab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"UseCurrentActivePage",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
		}

		protected virtual void InitializeCantAddUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("5412e968-54b0-431a-8720-b1a8c4a809e5"),
				ContainerUId = new Guid("00b46d1f-4be2-4d1e-9d74-8ad8279e0bb9"),
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
				UId = new Guid("1b25ec99-aba1-4f40-a3bb-cfd85160c8ee"),
				ContainerUId = new Guid("00b46d1f-4be2-4d1e-9d74-8ad8279e0bb9"),
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
				UId = new Guid("bd942bc7-8df4-4fef-8d95-6dc21ada9b91"),
				ContainerUId = new Guid("00b46d1f-4be2-4d1e-9d74-8ad8279e0bb9"),
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
				UId = new Guid("788c7b30-ca50-4a13-bb9e-9b86689f780c"),
				ContainerUId = new Guid("00b46d1f-4be2-4d1e-9d74-8ad8279e0bb9"),
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
				UId = new Guid("d4e6cea6-d718-41f0-bed4-5a6fe5d6b96d"),
				ContainerUId = new Guid("00b46d1f-4be2-4d1e-9d74-8ad8279e0bb9"),
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
				UId = new Guid("e64f7f6f-97b0-43f5-af7b-ceef90c7009d"),
				ContainerUId = new Guid("00b46d1f-4be2-4d1e-9d74-8ad8279e0bb9"),
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
				UId = new Guid("2625e9a3-3ba0-417e-b6c6-37b960a70eff"),
				ContainerUId = new Guid("00b46d1f-4be2-4d1e-9d74-8ad8279e0bb9"),
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
				UId = new Guid("b2ae66c7-c30d-406b-97a2-962836dee68e"),
				ContainerUId = new Guid("00b46d1f-4be2-4d1e-9d74-8ad8279e0bb9"),
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

		protected virtual void InitializeLdapUserInLdapGroupUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("c17ff261-6121-4b26-b224-0529dd21092b"),
				ContainerUId = new Guid("41df0d0d-8e9e-41fb-9e6f-b5a9fd776156"),
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
				UId = new Guid("d6214cd6-65fa-4b37-8880-f4669514af54"),
				ContainerUId = new Guid("41df0d0d-8e9e-41fb-9e6f-b5a9fd776156"),
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
				UId = new Guid("e67d40e3-3e62-46c0-b4d1-682643a66eda"),
				ContainerUId = new Guid("41df0d0d-8e9e-41fb-9e6f-b5a9fd776156"),
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
				UId = new Guid("8b5a0ba8-9264-475b-b463-b819b12c05be"),
				ContainerUId = new Guid("41df0d0d-8e9e-41fb-9e6f-b5a9fd776156"),
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
				UId = new Guid("7add9b08-936f-4682-851c-4226b2f9bdfa"),
				ContainerUId = new Guid("41df0d0d-8e9e-41fb-9e6f-b5a9fd776156"),
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
				UId = new Guid("b591ed0e-1a76-4c84-bdcc-866ea29cd104"),
				ContainerUId = new Guid("41df0d0d-8e9e-41fb-9e6f-b5a9fd776156"),
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
				UId = new Guid("401042bb-4c88-446a-aa93-d17dfc4cab35"),
				ContainerUId = new Guid("41df0d0d-8e9e-41fb-9e6f-b5a9fd776156"),
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
				UId = new Guid("4657dc42-e335-4a5d-8d72-59644b1bf81e"),
				ContainerUId = new Guid("41df0d0d-8e9e-41fb-9e6f-b5a9fd776156"),
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

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet431 = CreateLaneSet431LaneSet();
			LaneSets.Add(schemaLaneSet431);
			ProcessSchemaLane schemaLane1318 = CreateLane1318Lane();
			schemaLaneSet431.Lanes.Add(schemaLane1318);
			ProcessSchemaEventSubProcess subprocessopenroles = CreateSubProcessOpenRolesEventSubProcess();
			FlowElements.Add(subprocessopenroles);
			ProcessSchemaEventSubProcess subprocesspageload = CreateSubProcessPageLoadEventSubProcess();
			FlowElements.Add(subprocesspageload);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent messageopenroles = CreateMessageOpenRolesStartMessageEvent();
			subprocessopenroles.FlowElements.Add(messageopenroles);
			ProcessSchemaScriptTask scriptopenroles = CreateScriptOpenRolesScriptTask();
			subprocessopenroles.FlowElements.Add(scriptopenroles);
			ProcessSchemaUserTask openlookupusertask = CreateOpenLookupUserTaskUserTask();
			subprocessopenroles.FlowElements.Add(openlookupusertask);
			ProcessSchemaIntermediateCatchMessageEvent catchmessage_lookupgridpageclosed = CreateCatchMessage_LookupGridPageClosedIntermediateCatchMessageEvent();
			subprocessopenroles.FlowElements.Add(catchmessage_lookupgridpageclosed);
			ProcessSchemaScriptTask scriptassotiateuserwithrole = CreateScriptAssotiateUserWithRoleScriptTask();
			subprocessopenroles.FlowElements.Add(scriptassotiateuserwithrole);
			ProcessSchemaUserTask cantaddusertask = CreateCantAddUserTaskUserTask();
			subprocessopenroles.FlowElements.Add(cantaddusertask);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			subprocessopenroles.FlowElements.Add(scripttask1);
			ProcessSchemaStartMessageEvent message_pageload = CreateMessage_PageLoadStartMessageEvent();
			subprocesspageload.FlowElements.Add(message_pageload);
			ProcessSchemaScriptTask scripttask_pageload = CreateScriptTask_PageLoadScriptTask();
			subprocesspageload.FlowElements.Add(scripttask_pageload);
			ProcessSchemaIntermediateThrowMessageEvent throwpageloadparent = CreateThrowPageLoadParentIntermediateThrowMessageEvent();
			subprocesspageload.FlowElements.Add(throwpageloadparent);
			ProcessSchemaStartMessageEvent childdeletebuttonclick = CreateChildDeleteButtonClickStartMessageEvent();
			eventsubprocess1.FlowElements.Add(childdeletebuttonclick);
			ProcessSchemaScriptTask scriptchilddeletebuttonclick = CreateScriptChildDeleteButtonClickScriptTask();
			eventsubprocess1.FlowElements.Add(scriptchilddeletebuttonclick);
			ProcessSchemaUserTask ldapuserinldapgroupusertask = CreateLdapUserInLdapGroupUserTaskUserTask();
			eventsubprocess1.FlowElements.Add(ldapuserinldapgroupusertask);
			FlowElements.Add(CreateSequenceFlow7455SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7456SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7457SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7458SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7488SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7489SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7499SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7501SequenceFlow());
			FlowElements.Add(CreateConditionalFlow201ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCantDeleteLdapUserFromLdapGroupLSLocalizableString());
			LocalizableStrings.Add(CreateCantInsertLdapUserToLdapGroupLSLocalizableString());
			LocalizableStrings.Add(CreateAddCantInsertLdapUserToLdapGroupLSLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCantDeleteLdapUserFromLdapGroupLSLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1304ffa1-91d0-436e-a7cd-5e90a40f9461"),
				Name = "CantDeleteLdapUserFromLdapGroupLS",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCantInsertLdapUserToLdapGroupLSLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("bf413248-fd73-44c1-bddd-99ec9cf4fd1f"),
				Name = "CantInsertLdapUserToLdapGroupLS",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAddCantInsertLdapUserToLdapGroupLSLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b110db0e-527f-408c-8ce9-f8f18671ee1a"),
				Name = "AddCantInsertLdapUserToLdapGroupLS",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7455SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7455",
				UId = new Guid("03111494-a941-4d5e-b314-48dd86d04f61"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				CurveCenterPosition = new Point(388, 743),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ed2b8e13-d0b0-4861-805d-7988a6ab04d7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5e74e172-d81c-45ac-abe4-5778209b929f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7456SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7456",
				UId = new Guid("f534852c-0563-4292-b57c-93c5b8bf4235"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				CurveCenterPosition = new Point(518, 742),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5e74e172-d81c-45ac-abe4-5778209b929f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("678b4cbe-bbf0-4075-9b24-4d9b0672c2ab"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7457SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7457",
				UId = new Guid("72728e5e-015a-4579-8644-fb8cbc0d90ff"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				CurveCenterPosition = new Point(863, 681),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("678b4cbe-bbf0-4075-9b24-4d9b0672c2ab"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("de346683-e398-4609-bdbb-dfb2736a55a4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7458SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7458",
				UId = new Guid("08ff1356-f5fa-4d7a-a93e-8a513d1e37cc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				CurveCenterPosition = new Point(507, 728),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("de346683-e398-4609-bdbb-dfb2736a55a4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4252c10e-0653-4af8-90a6-a61f686dc3cd"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7488SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7488",
				UId = new Guid("b578a2c0-9b8d-4bbe-a445-871a8fe071f7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				CurveCenterPosition = new Point(759, 85),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e3f0934e-d367-47f6-88e3-a0f372860919"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9556aa11-81cd-4647-ab81-83177526868d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7489SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7489",
				UId = new Guid("03a3695d-ccfd-4a1d-9337-62aefa6c2da7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				CurveCenterPosition = new Point(860, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9556aa11-81cd-4647-ab81-83177526868d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bf9fd9c3-7110-4bfa-923f-050d7fce3f06"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7499SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7499",
				UId = new Guid("9aa00593-8a31-43d4-af31-c9a4985318c7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				CurveCenterPosition = new Point(411, 290),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a983ccdf-3a80-4a97-ba14-099fca58116a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9bd2c2af-806a-4fa8-b790-4c714c8e7c92"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7501SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow7501",
				UId = new Guid("e311a095-2f27-4be9-a0bf-fa8ac72089d1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				CurveCenterPosition = new Point(588, 154),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4252c10e-0653-4af8-90a6-a61f686dc3cd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f313174c-155c-47e3-a483-6743002b2ea2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow201ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow201",
				UId = new Guid("5d124de9-0b50-45f0-9a2a-cba09a6769dc"),
				ConditionExpression = @"ldapUserInLdapGroup",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				CurveCenterPosition = new Point(666, 102),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4252c10e-0653-4af8-90a6-a61f686dc3cd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("00b46d1f-4be2-4d1e-9d74-8ad8279e0bb9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("69f94934-2409-4646-86e8-e321bd6bb668"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				CurveCenterPosition = new Point(305, 300),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9bd2c2af-806a-4fa8-b790-4c714c8e7c92"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("41df0d0d-8e9e-41fb-9e6f-b5a9fd776156"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet431LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet431 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("ede28c87-959c-4301-aaf4-c84ea9119bfc"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Name = @"LaneSet431",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(773, 415),
				UseBackgroundMode = false
			};
			return schemaLaneSet431;
		}

		protected virtual ProcessSchemaLane CreateLane1318Lane() {
			ProcessSchemaLane schemaLane1318 = new ProcessSchemaLane(this) {
				UId = new Guid("1cb41274-c1f6-434f-8845-51d6910a8ced"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("ede28c87-959c-4301-aaf4-c84ea9119bfc"),
				CreatedInOwnerSchemaUId = new Guid("bd9f7eca-cf36-493e-9af6-9a01f79d2a6b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Name = @"Lane1318",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(744, 415),
				UseBackgroundMode = false
			};
			return schemaLane1318;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessOpenRolesEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessOpenRoles = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a45bf1e0-54fd-442b-b9bd-0813c76f2974"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1cb41274-c1f6-434f-8845-51d6910a8ced"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Name = @"SubProcessOpenRoles",
				Position = new Point(36, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(694, 219),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessOpenRoles;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMessageOpenRolesStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ed2b8e13-d0b0-4861-805d-7988a6ab04d7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a45bf1e0-54fd-442b-b9bd-0813c76f2974"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OpenRoles",
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Name = @"MessageOpenRoles",
				Position = new Point(22, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptOpenRolesScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5e74e172-d81c-45ac-abe4-5778209b929f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a45bf1e0-54fd-442b-b9bd-0813c76f2974"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Name = @"ScriptOpenRoles",
				Position = new Point(106, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,221,111,218,48,20,197,159,135,196,255,96,229,9,52,18,241,213,0,106,87,9,8,221,80,167,14,173,176,61,76,123,48,206,13,120,53,118,234,143,173,17,202,255,62,199,161,20,144,232,186,151,72,142,206,61,247,156,159,174,210,146,242,21,162,92,105,204,9,76,99,244,1,213,106,115,144,18,43,145,232,96,49,13,190,195,114,44,184,150,130,169,96,134,87,80,47,62,193,80,165,238,17,76,247,163,193,92,220,59,187,90,253,178,90,249,146,2,255,44,196,131,73,23,10,228,28,171,135,96,38,5,1,165,110,33,179,91,14,86,190,71,206,178,248,20,155,48,229,32,131,5,167,143,6,166,145,181,82,101,72,69,214,176,193,11,151,209,139,47,226,102,43,33,177,31,198,125,226,119,151,237,129,63,128,139,190,79,8,238,36,9,132,237,78,216,245,206,196,176,123,102,88,226,13,104,144,202,154,113,248,131,34,74,52,21,28,203,12,93,149,251,26,72,44,127,1,209,215,174,206,111,44,81,122,58,88,123,101,170,254,207,205,214,245,216,49,24,198,113,205,219,215,244,26,47,149,235,103,196,70,193,39,10,18,75,178,206,172,62,193,76,193,57,237,154,198,48,50,90,11,174,172,84,75,227,148,99,193,24,184,22,87,47,109,78,203,92,163,132,178,3,90,111,27,114,224,118,131,46,194,49,232,83,61,218,162,106,229,29,218,122,68,108,82,44,169,18,124,158,165,96,179,222,56,143,241,209,239,224,78,232,201,163,193,44,111,148,83,12,18,61,121,74,165,189,48,235,111,19,154,13,159,97,189,182,243,222,125,166,134,241,134,114,123,84,218,121,62,15,89,126,17,85,41,195,217,55,204,12,60,35,68,121,99,151,69,210,213,250,192,118,207,212,201,11,142,69,167,178,192,143,159,104,91,188,62,26,106,105,119,123,237,201,160,55,238,249,225,40,234,249,209,77,171,229,15,70,237,161,223,108,182,162,176,57,25,116,250,227,208,171,231,121,254,191,144,108,174,183,34,154,42,11,233,206,176,146,209,235,136,108,51,224,250,171,96,59,56,103,217,228,121,181,114,238,196,202,123,47,179,20,112,118,189,10,185,4,109,36,119,103,119,249,23,84,44,233,221,118,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenLookupUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("678b4cbe-bbf0-4075-9b24-4d9b0672c2ab"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a45bf1e0-54fd-442b-b9bd-0813c76f2974"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Name = @"OpenLookupUserTask",
				Position = new Point(246, 51),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenLookupUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateCatchMessage_LookupGridPageClosedIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("de346683-e398-4609-bdbb-dfb2736a55a4"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a45bf1e0-54fd-442b-b9bd-0813c76f2974"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				DragGroupName = @"BoundaryEvent",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"LookupGridPageClosed",
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Name = @"CatchMessage_LookupGridPageClosed",
				Position = new Point(371, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAssotiateUserWithRoleScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4252c10e-0653-4af8-90a6-a61f686dc3cd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a45bf1e0-54fd-442b-b9bd-0813c76f2974"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Name = @"ScriptAssotiateUserWithRole",
				Position = new Point(490, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,86,221,111,219,54,16,127,150,1,255,15,172,31,10,9,48,4,236,117,238,82,180,118,99,24,243,210,160,246,214,135,32,15,140,121,78,180,200,164,65,82,201,140,54,255,251,238,72,234,131,178,154,109,24,96,216,22,239,238,119,31,191,187,163,158,184,102,123,85,10,208,43,97,216,47,44,93,20,59,91,40,201,245,137,189,51,86,23,242,126,202,212,221,159,176,179,23,217,231,35,200,181,82,143,213,241,119,3,122,203,205,99,190,4,187,129,18,165,32,254,224,101,5,38,37,209,92,73,9,14,39,155,177,241,232,9,157,20,14,94,194,51,155,171,178,244,194,119,203,170,16,23,105,54,243,42,7,37,170,18,174,249,61,160,38,253,228,244,133,88,150,23,18,52,62,105,144,54,191,226,7,140,170,57,102,220,176,72,47,160,89,126,119,205,37,148,136,213,2,231,151,133,20,181,182,86,229,199,19,162,65,58,89,234,66,108,131,193,36,35,200,250,9,209,34,116,118,143,170,148,73,85,146,108,175,52,240,221,3,75,93,142,22,14,172,144,141,235,124,133,7,38,99,223,198,163,164,216,179,52,117,10,253,120,51,246,198,195,121,197,36,56,24,212,157,145,194,29,186,124,164,127,47,227,17,126,8,217,217,68,48,109,65,23,220,242,141,170,244,14,254,85,41,90,117,95,136,79,210,22,246,212,158,146,99,223,24,236,168,139,3,54,10,18,90,29,36,89,55,14,90,245,124,179,123,128,3,207,175,187,186,196,225,0,208,162,48,199,146,255,39,188,200,164,129,109,147,223,106,128,165,47,40,213,232,71,73,215,106,129,251,240,68,80,129,96,199,175,86,207,68,111,140,156,215,253,127,165,4,4,178,19,236,246,252,131,16,41,245,59,53,121,138,166,185,31,144,155,179,170,221,230,91,181,113,133,72,179,44,171,137,101,80,26,240,173,19,192,186,142,162,114,58,96,50,124,241,173,47,186,140,59,174,35,250,40,32,38,96,239,227,89,81,109,54,96,23,245,65,51,143,141,10,42,196,83,141,57,27,131,191,4,123,211,65,234,36,114,75,133,108,151,73,127,151,160,139,241,40,176,95,3,68,188,123,156,252,211,225,104,79,253,57,123,34,109,98,162,113,237,203,62,8,228,148,243,95,225,212,9,142,106,92,79,209,75,19,199,174,45,102,176,53,113,16,145,222,176,10,13,227,155,112,182,50,87,56,142,159,181,147,165,231,193,101,62,234,115,183,226,172,219,189,145,161,117,27,90,118,0,46,159,199,72,179,6,252,127,226,6,176,78,75,158,199,60,217,156,12,53,201,74,76,206,252,214,178,137,47,119,226,219,203,4,3,249,69,149,16,238,134,77,247,44,117,173,219,191,79,198,163,31,119,21,82,35,69,65,194,250,178,121,69,151,242,248,230,98,35,103,147,169,27,84,79,36,123,153,58,97,155,69,44,197,52,48,14,191,25,201,205,23,245,92,207,149,134,157,210,98,69,187,163,20,252,232,179,89,227,191,165,86,213,17,163,218,115,44,98,183,163,157,25,125,36,93,146,237,246,46,204,58,0,160,21,18,180,50,235,197,135,107,116,170,79,105,209,29,181,172,179,167,252,128,212,55,58,97,54,183,123,189,154,176,67,59,208,111,223,246,177,107,3,154,153,208,162,73,50,156,139,213,149,235,178,4,249,198,98,200,240,68,28,39,45,21,55,77,141,111,41,255,14,252,172,167,216,214,155,52,253,2,118,1,71,189,146,95,130,221,61,92,106,117,88,124,76,91,235,38,214,126,44,44,73,60,71,241,8,204,177,96,22,240,216,239,131,164,102,142,170,77,92,95,193,179,91,221,94,234,17,112,241,217,206,148,165,231,19,117,126,207,77,155,158,120,13,169,174,17,206,207,148,245,56,120,197,172,55,136,83,44,90,172,206,159,32,100,208,137,117,173,184,160,196,163,192,218,183,137,1,178,125,109,231,92,90,188,137,154,183,191,223,240,26,192,25,221,194,95,150,222,29,233,162,154,171,74,90,118,193,126,202,216,247,239,109,34,145,224,61,163,120,16,136,240,86,18,209,108,221,143,91,213,184,92,111,216,207,236,31,52,102,3,65,117,94,32,135,196,115,126,164,118,65,141,175,92,75,28,32,191,148,52,216,74,75,223,209,127,3,109,119,212,51,21,11,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateCantAddUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("00b46d1f-4be2-4d1e-9d74-8ad8279e0bb9"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a45bf1e0-54fd-442b-b9bd-0813c76f2974"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Name = @"CantAddUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(602, 51),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeCantAddUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f313174c-155c-47e3-a483-6743002b2ea2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a45bf1e0-54fd-442b-b9bd-0813c76f2974"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(483, 149),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessPageLoadEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessPageLoad = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e02c4ff7-ba25-4469-bdfd-876d5f80a18f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1cb41274-c1f6-434f-8845-51d6910a8ced"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Name = @"SubProcessPageLoad",
				Position = new Point(414, 247),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(288, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessPageLoad;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMessage_PageLoadStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e3f0934e-d367-47f6-88e3-a0f372860919"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e02c4ff7-ba25-4469-bdfd-876d5f80a18f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Name = @"Message_PageLoad",
				Position = new Point(22, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask_PageLoadScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9556aa11-81cd-4647-ab81-83177526868d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e02c4ff7-ba25-4469-bdfd-876d5f80a18f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Name = @"ScriptTask_PageLoad",
				Position = new Point(106, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,76,73,113,42,45,41,201,207,211,115,204,74,172,112,45,75,205,43,41,214,115,206,201,76,206,214,11,206,76,207,75,204,241,75,204,77,85,176,85,80,242,47,72,205,11,202,207,73,45,86,178,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,151,28,239,63,70,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowPageLoadParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("bf9fd9c3-7110-4bfa-923f-050d7fce3f06"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e02c4ff7-ba25-4469-bdfd-876d5f80a18f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Name = @"ThrowPageLoadParent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(218, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1598995d-3fcd-43c5-9648-0313c59ef649"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1cb41274-c1f6-434f-8845-51d6910a8ced"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 245),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(368, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildDeleteButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a983ccdf-3a80-4a97-ba14-099fca58116a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1598995d-3fcd-43c5-9648-0313c59ef649"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteButtonClick",
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Name = @"ChildDeleteButtonClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildDeleteButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9bd2c2af-806a-4fa8-b790-4c714c8e7c92"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1598995d-3fcd-43c5-9648-0313c59ef649"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Name = @"ScriptChildDeleteButtonClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(112, 21),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,83,93,107,194,48,20,125,110,127,69,200,83,5,41,123,239,20,92,117,82,112,245,163,110,34,99,15,161,189,186,178,154,72,146,110,19,237,127,223,77,173,155,110,98,55,24,20,154,228,158,115,238,185,55,55,89,194,214,247,10,100,192,7,184,234,75,145,175,73,139,44,88,166,192,179,211,5,113,250,160,3,53,232,118,70,61,174,229,198,137,32,131,88,67,18,138,4,70,50,93,49,185,241,69,150,175,248,3,203,114,112,167,34,210,50,229,75,167,209,104,144,173,109,189,50,73,212,17,69,161,248,136,45,17,40,1,250,50,77,220,99,65,229,217,150,201,121,194,112,125,145,115,77,218,228,170,84,180,22,66,2,139,159,29,35,205,17,64,82,126,154,98,15,179,178,179,149,157,59,221,237,12,222,250,86,169,209,118,203,170,212,35,141,54,106,34,50,8,18,250,116,92,35,250,181,10,27,191,162,236,213,25,241,210,204,224,231,185,217,78,153,122,113,239,64,41,108,200,20,222,53,218,243,25,215,93,44,70,195,129,115,43,197,234,147,53,136,188,203,106,62,91,235,84,240,22,153,49,201,209,99,13,60,136,5,199,172,116,214,153,132,65,216,167,53,240,155,92,107,193,205,29,210,121,47,170,67,79,64,173,17,13,85,133,134,198,225,141,116,211,216,88,196,193,185,86,101,31,155,100,255,111,59,216,207,130,0,142,94,93,211,14,190,199,247,189,104,26,12,195,191,25,15,135,255,110,189,28,185,45,221,128,162,77,66,247,55,56,7,85,241,105,209,44,195,92,124,69,67,113,28,44,106,12,157,78,201,94,97,2,177,144,73,21,249,237,92,140,113,156,205,170,58,192,134,219,151,120,230,173,86,79,214,179,37,232,92,114,162,101,14,222,7,31,64,147,59,56,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateLdapUserInLdapGroupUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("41df0d0d-8e9e-41fb-9e6f-b5a9fd776156"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1598995d-3fcd-43c5-9648-0313c59ef649"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Name = @"LdapUserInLdapGroupUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(238, 21),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeLdapUserInLdapGroupUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetIsLDAPEntryMethod());
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
				UId = new Guid("7d3fcbe5-fdfa-46bf-beef-27e9d73fe23a"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
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

		protected override SchemaMethod CreateGetButtonsMethod() {
			SchemaMethod method = base.CreateGetButtonsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,42,45,41,201,207,43,86,176,85,200,75,45,87,8,174,44,46,73,205,213,115,206,207,201,73,77,46,201,4,74,232,185,167,230,165,22,101,38,235,249,100,22,151,216,20,151,20,101,230,165,219,105,104,90,115,65,53,234,57,166,164,104,4,36,166,167,234,185,166,100,150,56,129,5,245,252,18,115,83,177,41,113,206,47,168,36,160,196,37,53,39,181,36,21,85,81,81,106,73,105,81,30,204,169,214,0,90,139,91,22,183,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateSetAdditionalDataSourcePropertiesMethod() {
			SchemaMethod method = base.CreateSetAdditionalDataSourcePropertiesMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,81,193,106,195,48,12,61,39,95,225,221,210,139,187,123,232,161,221,74,9,116,163,176,142,157,149,68,73,13,142,92,108,165,108,140,252,251,108,47,107,83,8,236,96,129,244,244,158,165,39,213,136,172,112,207,200,160,244,206,170,122,33,190,211,228,2,86,148,61,179,33,247,100,136,173,209,123,248,50,61,139,149,56,64,139,114,51,131,229,105,162,188,214,44,237,97,37,168,215,58,106,71,241,206,212,189,198,160,229,37,179,168,25,66,96,129,34,180,62,179,72,44,95,161,83,212,94,203,2,156,184,235,91,68,90,65,142,129,42,12,240,17,173,5,103,26,150,31,88,174,207,103,185,1,135,47,215,239,222,170,19,118,240,238,208,142,19,230,203,229,94,57,70,47,22,199,241,18,255,49,198,29,90,239,214,17,202,3,16,106,191,197,109,37,185,155,32,161,59,248,50,237,150,235,138,213,5,125,90,80,141,159,193,158,199,95,111,146,198,88,132,234,148,221,46,32,20,205,222,66,22,140,157,27,105,19,235,229,150,160,212,88,255,33,201,125,217,79,218,128,118,152,71,112,72,199,224,223,144,14,169,69,238,45,229,63,212,6,94,169,21,2,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterQuestionScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterQuestionScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterEditPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterEditPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterAddPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterAddPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsLDAPEntryMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3e25b135-7bb9-49bf-9bf4-b45bfc60c320"),
				Name = "GetIsLDAPEntry",
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("49691ab2-da6b-4e4e-9eb5-c0638e0ad33f"),
				Name = "sysAdminUnitId",
				CreatedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				ModifiedInSchemaUId = new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,205,10,130,64,20,70,215,9,190,195,224,74,55,190,128,180,48,203,16,42,2,169,214,183,233,218,12,56,119,96,230,42,88,244,238,253,46,178,214,31,223,57,167,7,39,252,224,243,147,209,180,35,205,181,84,104,64,76,197,206,163,43,44,17,74,214,150,210,5,177,230,225,189,174,129,224,140,46,93,34,87,228,25,72,226,108,216,128,193,56,170,191,80,81,146,133,65,255,195,127,144,255,117,105,225,16,24,223,142,120,108,126,66,116,35,226,239,87,90,34,75,85,58,107,230,179,209,80,157,146,68,92,195,96,226,144,59,71,34,62,90,219,38,163,235,35,186,176,109,103,104,15,109,247,42,38,169,156,37,125,193,131,102,181,154,231,219,87,248,45,12,62,144,6,90,143,217,29,42,60,224,34,41,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AdministrativeUserInRoleGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c6f3d972-1a7c-48a9-adf7-b4cd713690e3"));
		}

		#endregion

	}

	#endregion

}

