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
	using System.IO;
	using System.Text;
	using System.Threading;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
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

	#region Class: BaseLookupGridPageSchema

	/// <exclude/>
	public class BaseLookupGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.Button _downloadTemplateForImportProductsButton;
		public Terrasoft.UI.WebControls.Controls.Button DownloadTemplateForImportProductsButton {
			get {
				return _downloadTemplateForImportProductsButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _importProductsButton;
		public Terrasoft.UI.WebControls.Controls.Button ImportProductsButton {
			get {
				return _importProductsButton;
			}
		}

		#endregion

		#region Constructors: Public

		public BaseLookupGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseLookupGridPageSchema(BaseLookupGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
			RealUId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
			Name = "BaseLookupGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Width = 700;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseLookupGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateTreeGrid();
			UpdateShowChangelogMenuItem();
			UpdateCallMenuItem();
			UpdateSendTemplateEmailMenuItem();
			UpdateSendEmailMenuItem();
			UpdateButtonsControlLayout();
			UpdateActionButton();
			UpdateContextHelpButton();
			UpdatePrintButton();
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
			ButtonsControlLayout.MoveItem(5, PrintButton);
			ButtonsControlLayout.MoveItem(6, ContextHelpButton);
			ButtonsControlLayout.InsertItem(7, CreateDownloadTemplateForImportProductsButton());
			ButtonsControlLayout.InsertItem(8, CreateImportProductsButton());
			ButtonsControlLayout.MoveItem(9, ActionButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateBaseLookupGridPageEventsProcessSchema() {
			var schema = new BaseLookupGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDownloadTemplateForImportProductsButton() {
			_downloadTemplateForImportProductsButton = new Terrasoft.UI.WebControls.Controls.Button();
			_downloadTemplateForImportProductsButton.UId = new Guid("f7ce2e3f-66a8-4abb-8d56-8c644fbd9d3e");
			_downloadTemplateForImportProductsButton.Name = "DownloadTemplateForImportProductsButton";
			_downloadTemplateForImportProductsButton.CreatedInSchemaUId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
			_downloadTemplateForImportProductsButton.ModifiedInSchemaUId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
			_downloadTemplateForImportProductsButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_downloadTemplateForImportProductsButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_downloadTemplateForImportProductsButton.Tag = "";
			_downloadTemplateForImportProductsButton.Image = new ControlImage {};
			_downloadTemplateForImportProductsButton.Hidden = true;
			return _downloadTemplateForImportProductsButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateImportProductsButton() {
			_importProductsButton = new Terrasoft.UI.WebControls.Controls.Button();
			_importProductsButton.UId = new Guid("ab30b779-f890-44c0-ab94-2e24504916f6");
			_importProductsButton.Name = "ImportProductsButton";
			_importProductsButton.CreatedInSchemaUId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
			_importProductsButton.ModifiedInSchemaUId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
			_importProductsButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_importProductsButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_importProductsButton.Tag = "";
			_importProductsButton.Image = new ControlImage {};
			_importProductsButton.Hidden = true;
			return _importProductsButton;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new BaseLookupGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseLookupGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("39f129b6-b225-4949-95a6-820d78cf6294"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseLookupGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseLookupGridPageEventsProcess

	/// <exclude/>
	public class BaseLookupGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.BaseLookupGridPageSchemaUserControl
	{

		#region Class: OpenImportProductsSettingsPageUserTaskFlowElement

		/// <exclude/>
		public class OpenImportProductsSettingsPageUserTaskFlowElement : OpenPageUserTask
		{

			public OpenImportProductsSettingsPageUserTaskFlowElement(UserConnection userConnection, BaseLookupGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenImportProductsSettingsPageUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("75092ba4-ecb0-4693-84b7-dcd035acc2c6");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: ConfirmOpenLogFileFlowElement

		/// <exclude/>
		public class ConfirmOpenLogFileFlowElement : QuestionUserTask
		{

			public ConfirmOpenLogFileFlowElement(UserConnection userConnection, BaseLookupGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ConfirmOpenLogFile";
				IsLogging = false;
				SchemaElementUId = new Guid("750af419-1bf5-41db-ab23-7c37e42b7804");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public BaseLookupGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseLookupGridPageEventsProcess";
			SchemaUId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
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

		public virtual Guid LookupSchemaUId {
			get;
			set;
		}

		private ProcessFlowElement _shadowingBaseEventsSubProcess;
		public ProcessFlowElement ShadowingBaseEventsSubProcess {
			get {
				return _shadowingBaseEventsSubProcess ?? (_shadowingBaseEventsSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ShadowingBaseEventsSubProcess",
					SchemaElementUId = new Guid("a79ecad8-b7ba-425e-a113-f08dc7c544c6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseLookupGridPageTreeGridSelectionChangeStartMassage;
		public ProcessFlowElement BaseLookupGridPageTreeGridSelectionChangeStartMassage {
			get {
				return _baseLookupGridPageTreeGridSelectionChangeStartMassage ?? (_baseLookupGridPageTreeGridSelectionChangeStartMassage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseLookupGridPageTreeGridSelectionChangeStartMassage",
					SchemaElementUId = new Guid("934bb160-0195-413c-b529-db404c15aa23"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _setParentPrimaryColumnValueScriptTask;
		public ProcessScriptTask SetParentPrimaryColumnValueScriptTask {
			get {
				return _setParentPrimaryColumnValueScriptTask ?? (_setParentPrimaryColumnValueScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetParentPrimaryColumnValueScriptTask",
					SchemaElementUId = new Guid("39e16073-fa8d-48ed-8b53-d10e30dc41d5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetParentPrimaryColumnValueScriptTaskExecute,
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
					SchemaElementUId = new Guid("975732ec-f9de-44b9-b9a4-8ccd764eddc8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "TreeGridSelectionChange",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _pageEventHandlerSubProcess;
		public ProcessFlowElement PageEventHandlerSubProcess {
			get {
				return _pageEventHandlerSubProcess ?? (_pageEventHandlerSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageEventHandlerSubProcess",
					SchemaElementUId = new Guid("66e685cc-369b-4f9c-82e5-518721e410c4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseLookupGridPageInitStartMassage;
		public ProcessFlowElement BaseLookupGridPageInitStartMassage {
			get {
				return _baseLookupGridPageInitStartMassage ?? (_baseLookupGridPageInitStartMassage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseLookupGridPageInitStartMassage",
					SchemaElementUId = new Guid("daf0ac11-dbdb-4af1-aa47-bda076077337"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _baseLookupGridPageInitScriptTask;
		public ProcessScriptTask BaseLookupGridPageInitScriptTask {
			get {
				return _baseLookupGridPageInitScriptTask ?? (_baseLookupGridPageInitScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BaseLookupGridPageInitScriptTask",
					SchemaElementUId = new Guid("db071bdc-29fe-4166-a2b0-1b453869f0f3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BaseLookupGridPageInitScriptTaskExecute,
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
					SchemaElementUId = new Guid("fcd11339-c2c1-4137-b88f-9e842a3f490b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
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
					SchemaElementUId = new Guid("b7fb066e-bc23-474b-a0bd-7886d8157c4d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseLookupGridPageDataSourceBeforeLoadStartMessage;
		public ProcessFlowElement BaseLookupGridPageDataSourceBeforeLoadStartMessage {
			get {
				return _baseLookupGridPageDataSourceBeforeLoadStartMessage ?? (_baseLookupGridPageDataSourceBeforeLoadStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseLookupGridPageDataSourceBeforeLoadStartMessage",
					SchemaElementUId = new Guid("45549b86-c30e-411c-a525-0b58f27951e3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _baseLookupGridPageDataSourceBeforeLoadScriptTask;
		public ProcessScriptTask BaseLookupGridPageDataSourceBeforeLoadScriptTask {
			get {
				return _baseLookupGridPageDataSourceBeforeLoadScriptTask ?? (_baseLookupGridPageDataSourceBeforeLoadScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BaseLookupGridPageDataSourceBeforeLoadScriptTask",
					SchemaElementUId = new Guid("993eb94e-eea1-464a-b518-2a45060843f9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BaseLookupGridPageDataSourceBeforeLoadScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _downloadTemplateForImportProductsButtonClickEventSubProcess;
		public ProcessFlowElement DownloadTemplateForImportProductsButtonClickEventSubProcess {
			get {
				return _downloadTemplateForImportProductsButtonClickEventSubProcess ?? (_downloadTemplateForImportProductsButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "DownloadTemplateForImportProductsButtonClickEventSubProcess",
					SchemaElementUId = new Guid("035a1334-0efa-40b0-8503-3d326c248edb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _downloadTemplateForImportProductsButtonClickStartMessage;
		public ProcessFlowElement DownloadTemplateForImportProductsButtonClickStartMessage {
			get {
				return _downloadTemplateForImportProductsButtonClickStartMessage ?? (_downloadTemplateForImportProductsButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DownloadTemplateForImportProductsButtonClickStartMessage",
					SchemaElementUId = new Guid("49177e0b-2450-411e-8409-3a6452e98c16"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _downloadTemplateScript;
		public ProcessScriptTask DownloadTemplateScript {
			get {
				return _downloadTemplateScript ?? (_downloadTemplateScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DownloadTemplateScript",
					SchemaElementUId = new Guid("30d7fa2f-2c9d-49f8-83e5-54d304bcca21"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DownloadTemplateScriptExecute,
				});
			}
		}

		private ProcessFlowElement _importProductsButtonClickEventSubProcess;
		public ProcessFlowElement ImportProductsButtonClickEventSubProcess {
			get {
				return _importProductsButtonClickEventSubProcess ?? (_importProductsButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ImportProductsButtonClickEventSubProcess",
					SchemaElementUId = new Guid("a612cced-055a-4863-b26e-79f85a7579d5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _importProductsButtonClickStartMessage;
		public ProcessFlowElement ImportProductsButtonClickStartMessage {
			get {
				return _importProductsButtonClickStartMessage ?? (_importProductsButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ImportProductsButtonClickStartMessage",
					SchemaElementUId = new Guid("ef166337-390d-4646-84c5-6a853d9f0b06"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _setParametersScript;
		public ProcessScriptTask SetParametersScript {
			get {
				return _setParametersScript ?? (_setParametersScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetParametersScript",
					SchemaElementUId = new Guid("5b9cd1e6-bdfc-4fce-ba15-330a602bee05"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetParametersScriptExecute,
				});
			}
		}

		private OpenImportProductsSettingsPageUserTaskFlowElement _openImportProductsSettingsPageUserTask;
		public OpenImportProductsSettingsPageUserTaskFlowElement OpenImportProductsSettingsPageUserTask {
			get {
				return _openImportProductsSettingsPageUserTask ?? (_openImportProductsSettingsPageUserTask = new OpenImportProductsSettingsPageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessIntermediateCatchMessageEvent _showMessageBoxStartMessage;
		public ProcessIntermediateCatchMessageEvent ShowMessageBoxStartMessage {
			get {
				return _showMessageBoxStartMessage ?? (_showMessageBoxStartMessage = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "ShowMessageBoxStartMessage",
					SchemaElementUId = new Guid("5da1e53e-e6c2-48fe-95f3-3f73866e901a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "ShowMessageBox",
				});
			}
		}

		private ProcessScriptTask _showMessageBoxScript;
		public ProcessScriptTask ShowMessageBoxScript {
			get {
				return _showMessageBoxScript ?? (_showMessageBoxScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ShowMessageBoxScript",
					SchemaElementUId = new Guid("421b027f-9383-4b56-b55c-5fb9f9bfafd9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ShowMessageBoxScriptExecute,
				});
			}
		}

		private ConfirmOpenLogFileFlowElement _confirmOpenLogFile;
		public ConfirmOpenLogFileFlowElement ConfirmOpenLogFile {
			get {
				return _confirmOpenLogFile ?? (_confirmOpenLogFile = new ConfirmOpenLogFileFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessIntermediateCatchMessageEvent _noMessageStartMessage;
		public ProcessIntermediateCatchMessageEvent NoMessageStartMessage {
			get {
				return _noMessageStartMessage ?? (_noMessageStartMessage = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "NoMessageStartMessage",
					SchemaElementUId = new Guid("abcba71b-a3c6-447b-959f-097f8ffc1605"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "NoMessage",
				});
			}
		}

		private ProcessScriptTask _clearParametersScript;
		public ProcessScriptTask ClearParametersScript {
			get {
				return _clearParametersScript ?? (_clearParametersScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ClearParametersScript",
					SchemaElementUId = new Guid("67b5b6e8-67a7-41fe-bbae-5918d9e16be4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ClearParametersScriptExecute,
				});
			}
		}

		private ProcessIntermediateCatchMessageEvent _yesMessageStartMessage;
		public ProcessIntermediateCatchMessageEvent YesMessageStartMessage {
			get {
				return _yesMessageStartMessage ?? (_yesMessageStartMessage = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "YesMessageStartMessage",
					SchemaElementUId = new Guid("7a887db0-c2de-4344-a81c-3896dcdadce5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "YesMessage",
				});
			}
		}

		private ProcessScriptTask _prepareUploadScript;
		public ProcessScriptTask PrepareUploadScript {
			get {
				return _prepareUploadScript ?? (_prepareUploadScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareUploadScript",
					SchemaElementUId = new Guid("769b7bc2-acca-4817-ab6b-27e2a7a52af9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareUploadScriptExecute,
				});
			}
		}

		private ProcessIntermediateCatchMessageEvent _saveLogIntermediateCatchMessageEvent;
		public ProcessIntermediateCatchMessageEvent SaveLogIntermediateCatchMessageEvent {
			get {
				return _saveLogIntermediateCatchMessageEvent ?? (_saveLogIntermediateCatchMessageEvent = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "SaveLogIntermediateCatchMessageEvent",
					SchemaElementUId = new Guid("4b05dd3a-20db-41b5-8896-a8b4c53e424e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SaveLog",
				});
			}
		}

		private ProcessScriptTask _saveLogScriptTask;
		public ProcessScriptTask SaveLogScriptTask {
			get {
				return _saveLogScriptTask ?? (_saveLogScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SaveLogScriptTask",
					SchemaElementUId = new Guid("7d9e26dc-d4ec-4301-a39d-73b876434b9e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SaveLogScriptTaskExecute,
				});
			}
		}

		private ProcessEndEvent _end1;
		public ProcessEndEvent End1 {
			get {
				return _end1 ?? (_end1 = new ProcessEndEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEndEvent",
					Name = "End1",
					SchemaElementUId = new Guid("a6aa388c-bbfc-498d-90b3-854bedf3c3c3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("ac99f109-73b2-45d2-928b-5148cb36a0af"),
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

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("b8d4cf96-7c29-4c6b-9042-5cb54cfe0daa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteStartMessage;
		public ProcessFlowElement PageLoadCompleteStartMessage {
			get {
				return _pageLoadCompleteStartMessage ?? (_pageLoadCompleteStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadCompleteStartMessage",
					SchemaElementUId = new Guid("4c3d3b34-9952-4179-96ea-214e7caa715f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoadCompleteIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent PageLoadCompleteIntermediateThrowMessageEvent {
			get {
				return _pageLoadCompleteIntermediateThrowMessageEvent ?? (_pageLoadCompleteIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoadCompleteIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("96dfcecd-9c66-4b03-9efa-d52aeeb17679"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _pageLoadCompleteScript;
		public ProcessScriptTask PageLoadCompleteScript {
			get {
				return _pageLoadCompleteScript ?? (_pageLoadCompleteScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageLoadCompleteScript",
					SchemaElementUId = new Guid("c36e3433-8fd5-4c56-8989-f7634b49ade8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptExecute,
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
					SchemaElementUId = new Guid("31008b07-d42b-4cb1-a4bf-1cb38e25ea17"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _openLogFileMessage;
		public LocalizableString OpenLogFileMessage {
			get {
				return _openLogFileMessage ?? (_openLogFileMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.OpenLogFileMessage.Value"));
			}
		}

		private LocalizableString _productsImportFileLog;
		public LocalizableString ProductsImportFileLog {
			get {
				return _productsImportFileLog ?? (_productsImportFileLog = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ProductsImportFileLog.Value"));
			}
		}

		private LocalizableString _fileName;
		public LocalizableString FileName {
			get {
				return _fileName ?? (_fileName = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FileName.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ShadowingBaseEventsSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ShadowingBaseEventsSubProcess };
			FlowElements[BaseLookupGridPageTreeGridSelectionChangeStartMassage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseLookupGridPageTreeGridSelectionChangeStartMassage };
			FlowElements[SetParentPrimaryColumnValueScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SetParentPrimaryColumnValueScriptTask };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[PageEventHandlerSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageEventHandlerSubProcess };
			FlowElements[BaseLookupGridPageInitStartMassage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseLookupGridPageInitStartMassage };
			FlowElements[BaseLookupGridPageInitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseLookupGridPageInitScriptTask };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[BaseLookupGridPageDataSourceBeforeLoadStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseLookupGridPageDataSourceBeforeLoadStartMessage };
			FlowElements[BaseLookupGridPageDataSourceBeforeLoadScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseLookupGridPageDataSourceBeforeLoadScriptTask };
			FlowElements[DownloadTemplateForImportProductsButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { DownloadTemplateForImportProductsButtonClickEventSubProcess };
			FlowElements[DownloadTemplateForImportProductsButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DownloadTemplateForImportProductsButtonClickStartMessage };
			FlowElements[DownloadTemplateScript.SchemaElementUId] = new Collection<ProcessFlowElement> { DownloadTemplateScript };
			FlowElements[ImportProductsButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ImportProductsButtonClickEventSubProcess };
			FlowElements[ImportProductsButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ImportProductsButtonClickStartMessage };
			FlowElements[SetParametersScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SetParametersScript };
			FlowElements[OpenImportProductsSettingsPageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenImportProductsSettingsPageUserTask };
			FlowElements[ShowMessageBoxStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowMessageBoxStartMessage };
			FlowElements[ShowMessageBoxScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowMessageBoxScript };
			FlowElements[ConfirmOpenLogFile.SchemaElementUId] = new Collection<ProcessFlowElement> { ConfirmOpenLogFile };
			FlowElements[NoMessageStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { NoMessageStartMessage };
			FlowElements[ClearParametersScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ClearParametersScript };
			FlowElements[YesMessageStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { YesMessageStartMessage };
			FlowElements[PrepareUploadScript.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareUploadScript };
			FlowElements[SaveLogIntermediateCatchMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveLogIntermediateCatchMessageEvent };
			FlowElements[SaveLogScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveLogScriptTask };
			FlowElements[End1.SchemaElementUId] = new Collection<ProcessFlowElement> { End1 };
			FlowElements[ExclusiveGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3 };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[PageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage };
			FlowElements[PageLoadCompleteIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteIntermediateThrowMessageEvent };
			FlowElements[PageLoadCompleteScript.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScript };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ShadowingBaseEventsSubProcess":
						break;
					case "BaseLookupGridPageTreeGridSelectionChangeStartMassage":
						e.Context.QueueTasks.Enqueue("SetParentPrimaryColumnValueScriptTask");
						break;
					case "SetParentPrimaryColumnValueScriptTask":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "PageEventHandlerSubProcess":
						break;
					case "BaseLookupGridPageInitStartMassage":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "BaseLookupGridPageInitScriptTask":
						break;
					case "IntermediateThrowMessageEvent2":
						e.Context.QueueTasks.Enqueue("BaseLookupGridPageInitScriptTask");
						break;
					case "EventSubProcess10":
						break;
					case "BaseLookupGridPageDataSourceBeforeLoadStartMessage":
						e.Context.QueueTasks.Enqueue("BaseLookupGridPageDataSourceBeforeLoadScriptTask");
						break;
					case "BaseLookupGridPageDataSourceBeforeLoadScriptTask":
						break;
					case "DownloadTemplateForImportProductsButtonClickEventSubProcess":
						break;
					case "DownloadTemplateForImportProductsButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("DownloadTemplateScript");
						break;
					case "DownloadTemplateScript":
						break;
					case "ImportProductsButtonClickEventSubProcess":
						break;
					case "ImportProductsButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("SetParametersScript");
						break;
					case "SetParametersScript":
						e.Context.QueueTasks.Enqueue("OpenImportProductsSettingsPageUserTask");
						break;
					case "OpenImportProductsSettingsPageUserTask":
						ActivatedEventElements.Add("ShowMessageBoxStartMessage");
						break;
					case "ShowMessageBoxStartMessage":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway3");
						break;
					case "ShowMessageBoxScript":
						e.Context.QueueTasks.Enqueue("ConfirmOpenLogFile");
						break;
					case "ConfirmOpenLogFile":
						ActivatedEventElements.Add("NoMessageStartMessage");
						ActivatedEventElements.Add("YesMessageStartMessage");
						break;
					case "NoMessageStartMessage":
						e.Context.QueueTasks.Enqueue("ClearParametersScript");
						break;
					case "ClearParametersScript":
						e.Context.QueueTasks.Enqueue("End1");
						break;
					case "YesMessageStartMessage":
						e.Context.QueueTasks.Enqueue("PrepareUploadScript");
						break;
					case "PrepareUploadScript":
						if (!ActivatedEventElements.Contains("SaveLogIntermediateCatchMessageEvent")) {
							ActivatedEventElements.Add("SaveLogIntermediateCatchMessageEvent");
						}
						break;
					case "SaveLogIntermediateCatchMessageEvent":
						e.Context.QueueTasks.Enqueue("SaveLogScriptTask");
						break;
					case "SaveLogScriptTask":
						e.Context.QueueTasks.Enqueue("End1");
						break;
					case "End1":
						break;
					case "ExclusiveGateway3":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ClearParametersScript");
							break;
						}
						e.Context.QueueTasks.Enqueue("ShowMessageBoxScript");
						break;
					case "EventSubProcess1":
						break;
					case "PageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteIntermediateThrowMessageEvent");
						break;
					case "PageLoadCompleteIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScript");
						break;
					case "PageLoadCompleteScript":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(UserConnection.SessionData["ImportedRowsCount"] == null);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("BaseLookupGridPageTreeGridSelectionChangeStartMassage");
			ActivatedEventElements.Add("BaseLookupGridPageInitStartMassage");
			ActivatedEventElements.Add("BaseLookupGridPageDataSourceBeforeLoadStartMessage");
			ActivatedEventElements.Add("DownloadTemplateForImportProductsButtonClickStartMessage");
			ActivatedEventElements.Add("ImportProductsButtonClickStartMessage");
			ActivatedEventElements.Add("PageLoadCompleteStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "ShadowingBaseEventsSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BaseLookupGridPageTreeGridSelectionChangeStartMassage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseLookupGridPageTreeGridSelectionChangeStartMassage";
					result = BaseLookupGridPageTreeGridSelectionChangeStartMassage.Execute(context);
					break;
				case "SetParentPrimaryColumnValueScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetParentPrimaryColumnValueScriptTask";
					result = SetParentPrimaryColumnValueScriptTask.Execute(context, SetParentPrimaryColumnValueScriptTaskExecute);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "TreeGridSelectionChange");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "PageEventHandlerSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BaseLookupGridPageInitStartMassage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseLookupGridPageInitStartMassage";
					result = BaseLookupGridPageInitStartMassage.Execute(context);
					break;
				case "BaseLookupGridPageInitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseLookupGridPageInitScriptTask";
					result = BaseLookupGridPageInitScriptTask.Execute(context, BaseLookupGridPageInitScriptTaskExecute);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent2.Execute(context);
					break;
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "BaseLookupGridPageDataSourceBeforeLoadStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseLookupGridPageDataSourceBeforeLoadStartMessage";
					result = BaseLookupGridPageDataSourceBeforeLoadStartMessage.Execute(context);
					break;
				case "BaseLookupGridPageDataSourceBeforeLoadScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseLookupGridPageDataSourceBeforeLoadScriptTask";
					result = BaseLookupGridPageDataSourceBeforeLoadScriptTask.Execute(context, BaseLookupGridPageDataSourceBeforeLoadScriptTaskExecute);
					break;
				case "DownloadTemplateForImportProductsButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "DownloadTemplateForImportProductsButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DownloadTemplateForImportProductsButtonClickStartMessage";
					result = DownloadTemplateForImportProductsButtonClickStartMessage.Execute(context);
					break;
				case "DownloadTemplateScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "DownloadTemplateScript";
					result = DownloadTemplateScript.Execute(context, DownloadTemplateScriptExecute);
					break;
				case "ImportProductsButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ImportProductsButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ImportProductsButtonClickStartMessage";
					result = ImportProductsButtonClickStartMessage.Execute(context);
					break;
				case "SetParametersScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetParametersScript";
					result = SetParametersScript.Execute(context, SetParametersScriptExecute);
					break;
				case "OpenImportProductsSettingsPageUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenImportProductsSettingsPageUserTask";
					result = OpenImportProductsSettingsPageUserTask.Execute(context);
					break;
				case "ShowMessageBoxStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowMessageBoxStartMessage";
					result = ShowMessageBoxStartMessage.Execute(context);
					break;
				case "ShowMessageBoxScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowMessageBoxScript";
					result = ShowMessageBoxScript.Execute(context, ShowMessageBoxScriptExecute);
					break;
				case "ConfirmOpenLogFile":
					context.QueueTasks.Dequeue();
					context.SenderName = "ConfirmOpenLogFile";
					result = ConfirmOpenLogFile.Execute(context);
					break;
				case "NoMessageStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "NoMessageStartMessage";
					result = NoMessageStartMessage.Execute(context);
					break;
				case "ClearParametersScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ClearParametersScript";
					result = ClearParametersScript.Execute(context, ClearParametersScriptExecute);
					break;
				case "YesMessageStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "YesMessageStartMessage";
					result = YesMessageStartMessage.Execute(context);
					break;
				case "PrepareUploadScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareUploadScript";
					result = PrepareUploadScript.Execute(context, PrepareUploadScriptExecute);
					break;
				case "SaveLogIntermediateCatchMessageEvent":
					context.QueueTasks.Dequeue();
					context.SenderName = "SaveLogIntermediateCatchMessageEvent";
					result = SaveLogIntermediateCatchMessageEvent.Execute(context);
					break;
				case "SaveLogScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SaveLogScriptTask";
					result = SaveLogScriptTask.Execute(context, SaveLogScriptTaskExecute);
					break;
				case "End1":
					context.QueueTasks.Dequeue();
					break;
				case "ExclusiveGateway3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway3";
					result = ExclusiveGateway3.Execute(context);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteStartMessage";
					result = PageLoadCompleteStartMessage.Execute(context);
					break;
				case "PageLoadCompleteIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoadCompleteIntermediateThrowMessageEvent.Execute(context);
					break;
				case "PageLoadCompleteScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScript";
					result = PageLoadCompleteScript.Execute(context, PageLoadCompleteScriptExecute);
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
				case "LookupSchemaUId":
					LookupSchemaUId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool SetParentPrimaryColumnValueScriptTaskExecute(ProcessExecutingContext context) {
			if (Page.DataSource != null) {
				ListenerProcessSetProperty(ListenerPageProcessUId, "ParentPrimaryColumnValue", Page.DataSource.ActiveRowPrimaryColumnValue);
			}
			return true;
		}

		public virtual bool BaseLookupGridPageInitScriptTaskExecute(ProcessExecutingContext context) {
			if(!Ext.IsAjaxRequest) {
				Page.DataSource.AllowCallbackScriptMonitoring = false;
				Page.DataSource.UseProfile = false;
				Page.DataSource.AllowCallbackScriptMonitoring = true;
				InitializeDataSourceCurrentStructure();
				Page.DownloadTemplateForImportProductsButton.AjaxEvents.Click.IsUpload = true;
			}
			return true;
		}

		public virtual bool BaseLookupGridPageDataSourceBeforeLoadScriptTaskExecute(ProcessExecutingContext context) {
			// Set order direction for primary display column
			DataSourceStructure currentStructure = Page.DataSource.CurrentStructure;
			string displayColumnName = currentStructure.PrimaryDisplayColumnName;
			if (!String.IsNullOrEmpty(displayColumnName)) {
				DataSourceStructureColumn displayColumn = currentStructure.Columns.FindByName(displayColumnName);
				if (displayColumn != null && displayColumn.OrderDirection == OrderDirection.None) {
					foreach (var column in currentStructure.Columns) {
						if (column.OrderDirection != OrderDirection.None) {
							return true;
						}
					}
					displayColumn.OrderDirection = OrderDirection.Ascending;
					displayColumn.OrderPosition = 1;
				}
			}
			return true;
		}

		public virtual bool DownloadTemplateScriptExecute(ProcessExecutingContext context) {
			Terrasoft.Configuration.ImportTemplateDownloader.DownloadTemplate(UserConnection, FileName);
			return true;
		}

		public virtual bool SetParametersScriptExecute(ProcessExecutingContext context) {
			OpenImportProductsSettingsPageUserTask.PageUId = new Guid("c9d3708b-32e9-4ab9-9f57-fb9bc6f6a652");
			OpenImportProductsSettingsPageUserTask.OpenerInstanceId = context.Process.InstanceUId;	  
			OpenImportProductsSettingsPageUserTask.CloseMessage = "ShowMessageBox";	
			OpenImportProductsSettingsPageUserTask.UseCurrentActivePage = true;
			return true;
		}

		public virtual bool ShowMessageBoxScriptExecute(ProcessExecutingContext context) {
			var importedRowsCount = new KeyValuePair<int, int>(0, 0);
			object importedRowsCountSessionData = UserConnection.SessionData["ImportedRowsCount"];
			if (importedRowsCountSessionData != null) { 
				importedRowsCount = (KeyValuePair<int, int>)importedRowsCountSessionData;
			}
			ConfirmOpenLogFile.MessageText = string.Format(OpenLogFileMessage, importedRowsCount.Key, importedRowsCount.Value);
			ConfirmOpenLogFile.Icon = "QUESTION";
			ConfirmOpenLogFile.Buttons = "YESNO";
			ConfirmOpenLogFile.ResponseMessages = new Dictionary<string, string> {{"yes", "YesMessage"}, {"no", "NoMessage"}};
			ConfirmOpenLogFile.ProcessInstanceId = InstanceUId;
			UserConnection.SessionData.Remove("ImportedRowsCount");
			return true;
		}

		public virtual bool ClearParametersScriptExecute(ProcessExecutingContext context) {
			object excelImportIdSessionData = UserConnection.SessionData["ExcelImportId"];
			if (excelImportIdSessionData != null) { 
				var excelImportId = (Guid)excelImportIdSessionData;
				new Delete(UserConnection).From("ExcelImport").
					Where("Id").IsEqual(Column.Parameter(excelImportId)).Execute();
				UserConnection.SessionData.Remove("ExcelImportId");
			}
			return true;
		}

		public virtual bool PrepareUploadScriptExecute(ProcessExecutingContext context) {
			string script = "window.Terrasoft.AjaxMethods.ThrowClientEvent('" + 
				InstanceUId +
				"', 'SaveLog', '', { isUpload : true });"; 
			Page.AddScript(script);
			
			return true;
		}

		public virtual bool SaveLogScriptTaskExecute(ProcessExecutingContext context) {
			if (UserConnection.SessionData["ExcelImportId"] != null) { 
				var excelImportId = (Guid)UserConnection.SessionData["ExcelImportId"];
				var stringBuilder = new StringBuilder();
				var logMessages = new Select(UserConnection).Column("MessageText").From("ExcelImportLog")
					.Where("ExcelImportId").IsEqual(Column.Parameter(excelImportId))
					.OrderByAsc("CreatedOn")
					as Select;
				using (var dbExecutor = UserConnection.EnsureDBConnection()) {
					using (IDataReader message = logMessages.ExecuteReader(dbExecutor)) {
						while (message.Read()) {
							if (message[0] != null) {
								stringBuilder.Append(message[0].ToString());
								stringBuilder.Append("\r\n");
							}
						}
					}
				}
				var fileData = stringBuilder.ToString();
				var response = Page.Response; 
				response.ContentType = "text/plain";
				response.AddHeader("Content-Disposition", string.Format("attachment; filename={0}.txt", ProductsImportFileLog));
				response.Write(fileData);
				response.End();
				new Delete(UserConnection).From("ExcelImport").
					Where("Id").IsEqual(Column.Parameter(excelImportId)).Execute();
				UserConnection.SessionData.Remove("ExcelImportId");
			}
			return true;
		}

		public virtual bool PageLoadCompleteScriptExecute(ProcessExecutingContext context) {
			if (EntitySchemaUId == new Guid("{4c7a6ead-4eb8-4fc0-863e-98a664569fed}")) {
				Page.DownloadTemplateForImportProductsButton.Show();
				Page.ImportProductsButton.Show();
			}
			Page.DataSource.LoadRows();
			return true;
		}

		public virtual void InitializeDataSourceCurrentStructure() {
			if (EntitySchemaUId == Guid.Empty) {
				return;
			}
			// Create datasource entity schema
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			EntitySchema entitySchema =  entitySchemaManager.GetInstanceByUId(EntitySchemaUId);
			Page.DataSource.Schema = entitySchema;
			DataSourceStructure dsCurrentStructure = Page.DataSource.CurrentStructure;
			
			// Get entity edit page id
			Guid editPageSchemaId = Guid.Empty;
			EntitySchema lookupEntitySchema =  entitySchemaManager.GetInstanceByName("SysLookup");
			EntitySchemaQuery lookupEntitySchemaQuery = new EntitySchemaQuery(lookupEntitySchema);
			
			// Primary column added to schema query is named "Id1"
			// TODO: Reimplement get value logic when fixed if needed
			var queryPrimaryColumn = lookupEntitySchemaQuery.AddColumn(lookupEntitySchema.GetPrimaryColumnName());
			var queryEditPageColumn = lookupEntitySchemaQuery.AddColumn("SysEditPageSchemaUId");
			lookupEntitySchemaQuery.Filters.Add(lookupEntitySchemaQuery.CreateFilterWithParameters(
				FilterComparisonType.Equal,"SysEntitySchemaUId", EntitySchemaUId));
			EntityCollection entityCollection = lookupEntitySchemaQuery.GetEntityCollection(UserConnection);
			if (entityCollection.Count >= 1) {
				// TODO: Get appropriate entity if quantity greater than 1 or throw an exception
				Entity lookupEntity = entityCollection[0];
				editPageSchemaId = lookupEntity.GetTypedColumnValue<Guid>(
					lookupEntitySchema.Columns.FindByName(queryEditPageColumn.Name).ColumnValueName);
				LookupSchemaUId = lookupEntity.GetTypedColumnValue<Guid>(queryPrimaryColumn.Name);
			}
			EditPageUId = (editPageSchemaId == Guid.Empty ? GetDeafaultLookupEditSchemaId() : editPageSchemaId);
			
			// Query for columns display in DataSourse
			EntitySchema lookupColumnSchema =  entitySchemaManager.GetInstanceByName("SysLookupColumn");
			EntitySchemaQuery entitySchemaQuery = new EntitySchemaQuery(lookupColumnSchema);
			entitySchemaQuery.AddColumn("MetaPath");
			entitySchemaQuery.AddColumn("Caption");
			entitySchemaQuery.AddColumn("Width");
			var codeColumn = entitySchemaQuery.AddColumn("SysOrderDirection.Code");
			
			// Add a filter for SysLookup column
			var sysLookupFilter = entitySchemaQuery.CreateFilterWithParameters(
				FilterComparisonType.Equal, "SysLookup", LookupSchemaUId);
			entitySchemaQuery.Filters.Add(sysLookupFilter);
			EntityCollection sysColumnsCollection = entitySchemaQuery.GetEntityCollection(UserConnection);
			Guid primaryColumnUId = (entitySchema.PrimaryColumn != null) ?
					entitySchema.PrimaryColumn.UId : Guid.Empty;
			Guid hierarchyColumnUId = (entitySchema.HierarchyColumn != null) ?
					entitySchema.HierarchyColumn.UId : Guid.Empty;
			Guid primaryDisplayColumnUId = (entitySchema.PrimaryDisplayColumn != null) ?
					entitySchema.PrimaryDisplayColumn.UId : Guid.Empty;
			
			// Initialize the datasourse column strusture
			bool isPrimaryColumnAdded = false;
			bool isPrimaryDisplayColumnAdded = false;
			bool isHierarchyColumnAdded = false;
			if (sysColumnsCollection.Count > 0) {
				foreach(Entity columnEntity in sysColumnsCollection) {
					string metaPath = columnEntity.GetTypedColumnValue<string>("MetaPath");
					var column = dsCurrentStructure.AddColumnByMetaPath(metaPath);
					bool isPrimaryColumn = column.SchemaColumnUId == primaryColumnUId;
					bool isPrimaryDisplayColumn = column.SchemaColumnUId == primaryDisplayColumnUId;
					bool isHierarchyColumn = (entitySchema.HierarchyColumn != null ?
						entitySchema.HierarchyColumn.UId == column.SchemaColumnUId : false);
					column.IsVisible = !(isPrimaryColumn || isHierarchyColumn);
					string caption = columnEntity.GetTypedColumnValue<string>("Caption");
					if (!string.IsNullOrEmpty(caption)) {
							column.Caption = caption;
					}
					column.Width = columnEntity.GetTypedColumnValue<int>("Width");
					column.OrderDirection = columnEntity.GetTypedColumnValue<OrderDirection>(codeColumn.Name);
					if (isPrimaryColumn) {
						isPrimaryColumnAdded = true;
					} else if (isPrimaryDisplayColumn) {
						isPrimaryDisplayColumnAdded = true;
					} else if (isHierarchyColumn) {
						isHierarchyColumnAdded = true;
					}
				}
			}
			if (!isPrimaryColumnAdded) {
				var primaryColumn = dsCurrentStructure.AddColumnByMetaPath(primaryColumnUId.ToString());
				primaryColumn.IsVisible = false;
			}
			if (!isPrimaryDisplayColumnAdded) {
				var primaryDisplayColumn = dsCurrentStructure.AddColumnByMetaPath(primaryDisplayColumnUId.ToString());
			}
			if (!isHierarchyColumnAdded) {
				if (hierarchyColumnUId != Guid.Empty) {
					var hierarchyColumn = dsCurrentStructure.AddColumnByMetaPath(hierarchyColumnUId.ToString());
					hierarchyColumn.IsVisible = false;
				}
			}
			// Set parent primary column value for listener page
			if (Page.DataSource.Rows.Count > 0) {
				ListenerProcessSetProperty(ListenerPageProcessUId, "ParentPrimaryColumnValue", Page.DataSource.Rows[0].PrimaryColumnValue);
			}
		}

		public virtual Guid GetDeafaultLookupEditSchemaId() {
			var schemaUId = Terrasoft.Core.Configuration.SysSettings.GetValue(UserConnection, "DefLookupEditPageSchemaUId");
			return schemaUId == null ? Guid.Empty : (Guid)schemaUId;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "TreeGridSelectionChange":
							if (ActivatedEventElements.Contains("BaseLookupGridPageTreeGridSelectionChangeStartMassage")) {
							context.QueueTasks.Enqueue("BaseLookupGridPageTreeGridSelectionChangeStartMassage");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("BaseLookupGridPageInitStartMassage")) {
							context.QueueTasks.Enqueue("BaseLookupGridPageInitStartMassage");
							ProcessQueue(context);
							return;
						}
						break;
					case "DataSourceBeforeLoad":
							if (ActivatedEventElements.Contains("BaseLookupGridPageDataSourceBeforeLoadStartMessage")) {
							context.QueueTasks.Enqueue("BaseLookupGridPageDataSourceBeforeLoadStartMessage");
						}
						break;
					case "DownloadTemplateForImportProductsButtonClick":
							if (ActivatedEventElements.Contains("DownloadTemplateForImportProductsButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("DownloadTemplateForImportProductsButtonClickStartMessage");
						}
						break;
					case "ImportProductsButtonClick":
							if (ActivatedEventElements.Contains("ImportProductsButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("ImportProductsButtonClickStartMessage");
						}
						break;
					case "ShowMessageBox":
					if (ActivatedEventElements.Remove("ShowMessageBoxStartMessage")) {
						context.QueueTasks.Enqueue("ShowMessageBoxStartMessage");
					}
					break;
					case "NoMessage":
					if (ActivatedEventElements.Remove("NoMessageStartMessage")) {
						context.QueueTasks.Enqueue("NoMessageStartMessage");
					}
					break;
					case "YesMessage":
					if (ActivatedEventElements.Remove("YesMessageStartMessage")) {
						context.QueueTasks.Enqueue("YesMessageStartMessage");
					}
					break;
					case "SaveLog":
					if (ActivatedEventElements.Remove("SaveLogIntermediateCatchMessageEvent")) {
						context.QueueTasks.Enqueue("SaveLogIntermediateCatchMessageEvent");
					}
					break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteStartMessage");
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
			if (!HasMapping("LookupSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("LookupSchemaUId", LookupSchemaUId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: BaseLookupGridPageEventsProcess

	/// <exclude/>
	public class BaseLookupGridPageEventsProcess : BaseLookupGridPageEventsProcess<Terrasoft.WebApp.BaseLookupGridPageSchemaUserControl>
	{

		public BaseLookupGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseLookupGridPageSchemaUserControl

	/// <exclude/>
	public partial class BaseLookupGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.Button DownloadTemplateForImportProductsButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("DownloadTemplateForImportProductsButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button ImportProductsButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("ImportProductsButton", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			DownloadTemplateForImportProductsButton.AjaxEvents.Click.Event += DownloadTemplateForImportProductsButtonClick;
			ImportProductsButton.AjaxEvents.Click.Event += ImportProductsButtonClick;
			DataSource.BeforeLoad += DataSourceBeforeLoad;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			DownloadTemplateForImportProductsButton.AjaxEvents.Click.Event -= DownloadTemplateForImportProductsButtonClick;
			ImportProductsButton.AjaxEvents.Click.Event -= ImportProductsButtonClick;
			DataSource.BeforeLoad -= DataSourceBeforeLoad;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (BaseLookupGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseLookupGridPageEventsProcess(UserConnection);
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

		public virtual void DownloadTemplateForImportProductsButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("DownloadTemplateForImportProductsButtonClick");
		}

		public virtual void ImportProductsButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("ImportProductsButtonClick");
		}

		public virtual void DataSourceBeforeLoad(object sender, EventArgs e) {
			object result = ThrowEvent("DataSourceBeforeLoad");
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
			SchemaName = "BaseLookupGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseLookupGridPageEventsProcessSchema

	/// <exclude/>
	public class BaseLookupGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public BaseLookupGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseLookupGridPageEventsProcessSchema(BaseLookupGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseLookupGridPageEventsProcess";
			UId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd");
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

		protected virtual ProcessSchemaParameter CreateLookupSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6a1a6a2d-8516-4515-b486-71ed05bf7d62"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"LookupSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateLookupSchemaUIdParameter());
		}

		protected virtual void InitializeOpenImportProductsSettingsPageUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("49815a71-d705-4788-aa22-b74150416949"),
				ContainerUId = new Guid("75092ba4-ecb0-4693-84b7-dcd035acc2c6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageUId",
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
				UId = new Guid("bd5ca849-8fd4-404a-bfde-ee47d278fa68"),
				ContainerUId = new Guid("75092ba4-ecb0-4693-84b7-dcd035acc2c6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageUrl",
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
				UId = new Guid("e9ce6e9f-afbb-44a5-bcb6-75b28dd83252"),
				ContainerUId = new Guid("75092ba4-ecb0-4693-84b7-dcd035acc2c6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"OpenerInstanceId",
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
				UId = new Guid("69156259-9383-4323-a40d-c60a5a6e6651"),
				ContainerUId = new Guid("75092ba4-ecb0-4693-84b7-dcd035acc2c6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"CloseOpenerOnLoad",
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
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("c687ca52-b92d-417a-b514-482158240d8b"),
				ContainerUId = new Guid("75092ba4-ecb0-4693-84b7-dcd035acc2c6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
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
				UId = new Guid("2d77cfd6-179d-4ed1-a7c3-3e79f46d5bf4"),
				ContainerUId = new Guid("75092ba4-ecb0-4693-84b7-dcd035acc2c6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Width",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("af617af9-bf17-4c1d-8246-87d355e9c395"),
				ContainerUId = new Guid("75092ba4-ecb0-4693-84b7-dcd035acc2c6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"CloseMessage",
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
				UId = new Guid("29579899-7b03-4fbb-a88a-a33978a91fd2"),
				ContainerUId = new Guid("75092ba4-ecb0-4693-84b7-dcd035acc2c6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Height",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("74cc0408-4626-4d2d-bf74-969df9a15427"),
				ContainerUId = new Guid("75092ba4-ecb0-4693-84b7-dcd035acc2c6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Centered",
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
				UId = new Guid("f8c92d36-b78b-45d9-b885-0639f99783e8"),
				ContainerUId = new Guid("75092ba4-ecb0-4693-84b7-dcd035acc2c6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"UseOpenerRegisterScript",
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
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("94d84945-a6d6-4c76-b391-764e1e9e51f2"),
				ContainerUId = new Guid("75092ba4-ecb0-4693-84b7-dcd035acc2c6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
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
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("99cfcb28-5487-471c-a6d9-1300de218fa8"),
				ContainerUId = new Guid("75092ba4-ecb0-4693-84b7-dcd035acc2c6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"IgnoreProfile",
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

		protected virtual void InitializeConfirmOpenLogFileParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("164e424c-2c21-4fb3-8bf4-486847b09645"),
				ContainerUId = new Guid("750af419-1bf5-41db-ab23-7c37e42b7804"),
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
				UId = new Guid("ecc67c57-8cc1-4088-ae24-a4290c006edc"),
				ContainerUId = new Guid("750af419-1bf5-41db-ab23-7c37e42b7804"),
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
				UId = new Guid("909e50ae-fd0e-4186-a58a-632e4b991a23"),
				ContainerUId = new Guid("750af419-1bf5-41db-ab23-7c37e42b7804"),
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
				UId = new Guid("b4cbf8c4-9232-40d1-bff9-c87bed4a22be"),
				ContainerUId = new Guid("750af419-1bf5-41db-ab23-7c37e42b7804"),
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
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("8bcfd615-0636-4070-b3a2-7d95e92dfca6"),
				ContainerUId = new Guid("750af419-1bf5-41db-ab23-7c37e42b7804"),
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
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("6362cb4f-3395-42b2-9c34-49302f2cf28d"),
				ContainerUId = new Guid("750af419-1bf5-41db-ab23-7c37e42b7804"),
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
				UId = new Guid("c2868b77-76c0-489a-9e14-5c5d3597a2c3"),
				ContainerUId = new Guid("750af419-1bf5-41db-ab23-7c37e42b7804"),
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
				UId = new Guid("27f00f52-481a-4e5a-b1b8-f07b7ff11e6c"),
				ContainerUId = new Guid("750af419-1bf5-41db-ab23-7c37e42b7804"),
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
			ProcessSchemaLaneSet schemaLaneSet558 = CreateLaneSet558LaneSet();
			LaneSets.Add(schemaLaneSet558);
			ProcessSchemaLane schemaLane1939 = CreateLane1939Lane();
			schemaLaneSet558.Lanes.Add(schemaLane1939);
			ProcessSchemaLane schemaLane1940 = CreateLane1940Lane();
			schemaLaneSet558.Lanes.Add(schemaLane1940);
			ProcessSchemaLane schemaLane1941 = CreateLane1941Lane();
			schemaLaneSet558.Lanes.Add(schemaLane1941);
			ProcessSchemaLane schemaLane1942 = CreateLane1942Lane();
			schemaLaneSet558.Lanes.Add(schemaLane1942);
			ProcessSchemaEventSubProcess shadowingbaseeventssubprocess = CreateShadowingBaseEventsSubProcessEventSubProcess();
			FlowElements.Add(shadowingbaseeventssubprocess);
			ProcessSchemaEventSubProcess pageeventhandlersubprocess = CreatePageEventHandlerSubProcessEventSubProcess();
			FlowElements.Add(pageeventhandlersubprocess);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaEventSubProcess downloadtemplateforimportproductsbuttonclickeventsubprocess = CreateDownloadTemplateForImportProductsButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(downloadtemplateforimportproductsbuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess importproductsbuttonclickeventsubprocess = CreateImportProductsButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(importproductsbuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent baselookupgridpagetreegridselectionchangestartmassage = CreateBaseLookupGridPageTreeGridSelectionChangeStartMassageStartMessageEvent();
			shadowingbaseeventssubprocess.FlowElements.Add(baselookupgridpagetreegridselectionchangestartmassage);
			ProcessSchemaScriptTask setparentprimarycolumnvaluescripttask = CreateSetParentPrimaryColumnValueScriptTaskScriptTask();
			shadowingbaseeventssubprocess.FlowElements.Add(setparentprimarycolumnvaluescripttask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			shadowingbaseeventssubprocess.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaStartMessageEvent baselookupgridpageinitstartmassage = CreateBaseLookupGridPageInitStartMassageStartMessageEvent();
			pageeventhandlersubprocess.FlowElements.Add(baselookupgridpageinitstartmassage);
			ProcessSchemaScriptTask baselookupgridpageinitscripttask = CreateBaseLookupGridPageInitScriptTaskScriptTask();
			pageeventhandlersubprocess.FlowElements.Add(baselookupgridpageinitscripttask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			pageeventhandlersubprocess.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaStartMessageEvent baselookupgridpagedatasourcebeforeloadstartmessage = CreateBaseLookupGridPageDataSourceBeforeLoadStartMessageStartMessageEvent();
			eventsubprocess10.FlowElements.Add(baselookupgridpagedatasourcebeforeloadstartmessage);
			ProcessSchemaScriptTask baselookupgridpagedatasourcebeforeloadscripttask = CreateBaseLookupGridPageDataSourceBeforeLoadScriptTaskScriptTask();
			eventsubprocess10.FlowElements.Add(baselookupgridpagedatasourcebeforeloadscripttask);
			ProcessSchemaStartMessageEvent downloadtemplateforimportproductsbuttonclickstartmessage = CreateDownloadTemplateForImportProductsButtonClickStartMessageStartMessageEvent();
			downloadtemplateforimportproductsbuttonclickeventsubprocess.FlowElements.Add(downloadtemplateforimportproductsbuttonclickstartmessage);
			ProcessSchemaScriptTask downloadtemplatescript = CreateDownloadTemplateScriptScriptTask();
			downloadtemplateforimportproductsbuttonclickeventsubprocess.FlowElements.Add(downloadtemplatescript);
			ProcessSchemaStartMessageEvent importproductsbuttonclickstartmessage = CreateImportProductsButtonClickStartMessageStartMessageEvent();
			importproductsbuttonclickeventsubprocess.FlowElements.Add(importproductsbuttonclickstartmessage);
			ProcessSchemaScriptTask setparametersscript = CreateSetParametersScriptScriptTask();
			importproductsbuttonclickeventsubprocess.FlowElements.Add(setparametersscript);
			ProcessSchemaUserTask openimportproductssettingspageusertask = CreateOpenImportProductsSettingsPageUserTaskUserTask();
			importproductsbuttonclickeventsubprocess.FlowElements.Add(openimportproductssettingspageusertask);
			ProcessSchemaIntermediateCatchMessageEvent showmessageboxstartmessage = CreateShowMessageBoxStartMessageIntermediateCatchMessageEvent();
			importproductsbuttonclickeventsubprocess.FlowElements.Add(showmessageboxstartmessage);
			ProcessSchemaScriptTask showmessageboxscript = CreateShowMessageBoxScriptScriptTask();
			importproductsbuttonclickeventsubprocess.FlowElements.Add(showmessageboxscript);
			ProcessSchemaUserTask confirmopenlogfile = CreateConfirmOpenLogFileUserTask();
			importproductsbuttonclickeventsubprocess.FlowElements.Add(confirmopenlogfile);
			ProcessSchemaIntermediateCatchMessageEvent nomessagestartmessage = CreateNoMessageStartMessageIntermediateCatchMessageEvent();
			importproductsbuttonclickeventsubprocess.FlowElements.Add(nomessagestartmessage);
			ProcessSchemaScriptTask clearparametersscript = CreateClearParametersScriptScriptTask();
			importproductsbuttonclickeventsubprocess.FlowElements.Add(clearparametersscript);
			ProcessSchemaIntermediateCatchMessageEvent yesmessagestartmessage = CreateYesMessageStartMessageIntermediateCatchMessageEvent();
			importproductsbuttonclickeventsubprocess.FlowElements.Add(yesmessagestartmessage);
			ProcessSchemaScriptTask prepareuploadscript = CreatePrepareUploadScriptScriptTask();
			importproductsbuttonclickeventsubprocess.FlowElements.Add(prepareuploadscript);
			ProcessSchemaIntermediateCatchMessageEvent savelogintermediatecatchmessageevent = CreateSaveLogIntermediateCatchMessageEventIntermediateCatchMessageEvent();
			importproductsbuttonclickeventsubprocess.FlowElements.Add(savelogintermediatecatchmessageevent);
			ProcessSchemaScriptTask savelogscripttask = CreateSaveLogScriptTaskScriptTask();
			importproductsbuttonclickeventsubprocess.FlowElements.Add(savelogscripttask);
			ProcessSchemaEndEvent end1 = CreateEnd1EndEvent();
			importproductsbuttonclickeventsubprocess.FlowElements.Add(end1);
			ProcessSchemaExclusiveGateway exclusivegateway3 = CreateExclusiveGateway3ExclusiveGateway();
			importproductsbuttonclickeventsubprocess.FlowElements.Add(exclusivegateway3);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage = CreatePageLoadCompleteStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(pageloadcompletestartmessage);
			ProcessSchemaIntermediateThrowMessageEvent pageloadcompleteintermediatethrowmessageevent = CreatePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(pageloadcompleteintermediatethrowmessageevent);
			ProcessSchemaScriptTask pageloadcompletescript = CreatePageLoadCompleteScriptScriptTask();
			eventsubprocess1.FlowElements.Add(pageloadcompletescript);
			FlowElements.Add(CreateSequenceFlow11912SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11913SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11914SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11917SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11918SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11927SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11928SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11929SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11930SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11931SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateOpenLogFileMessageLocalizableString());
			LocalizableStrings.Add(CreateProductsImportFileLogLocalizableString());
			LocalizableStrings.Add(CreateFileNameLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateOpenLogFileMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("07baafb5-000f-4e6b-a9fb-b76d931b138a"),
				Name = "OpenLogFileMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateProductsImportFileLogLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3b27287a-58ee-4c87-9e50-0a69fe051006"),
				Name = "ProductsImportFileLog",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFileNameLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("77d5b374-c261-4b38-a134-2f230cba4bd9"),
				Name = "FileName",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11912SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11912",
				UId = new Guid("3ae809e5-b804-4229-9082-88c2013bfc45"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CurveCenterPosition = new Point(159, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fcd11339-c2c1-4137-b88f-9e842a3f490b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("db071bdc-29fe-4166-a2b0-1b453869f0f3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11913SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11913",
				UId = new Guid("e56b6365-ce36-49e6-8473-82d377acade5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CurveCenterPosition = new Point(170, 69),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("934bb160-0195-413c-b529-db404c15aa23"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("39e16073-fa8d-48ed-8b53-d10e30dc41d5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11914SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11914",
				UId = new Guid("fb8985ec-4e97-46a5-b125-524bc9be2398"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CurveCenterPosition = new Point(320, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("39e16073-fa8d-48ed-8b53-d10e30dc41d5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("975732ec-f9de-44b9-b9a4-8ccd764eddc8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11917SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11917",
				UId = new Guid("93f4a985-ec5b-4582-978f-3532c813af79"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CurveCenterPosition = new Point(154, 266),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("daf0ac11-dbdb-4af1-aa47-bda076077337"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fcd11339-c2c1-4137-b88f-9e842a3f490b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11918SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11918",
				UId = new Guid("24577e49-1c6d-4aa7-b982-dc7b937bb0f6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("45549b86-c30e-411c-a525-0b58f27951e3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("993eb94e-eea1-464a-b518-2a45060843f9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11927SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11927",
				UId = new Guid("bd16cd4d-03d8-447c-b934-3428aa4c76ed"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("49177e0b-2450-411e-8409-3a6452e98c16"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("30d7fa2f-2c9d-49f8-83e5-54d304bcca21"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11928SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11928",
				UId = new Guid("a3a5a744-fa34-4a37-ba63-816dabd382d6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ef166337-390d-4646-84c5-6a853d9f0b06"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5b9cd1e6-bdfc-4fce-ba15-330a602bee05"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11929SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11929",
				UId = new Guid("af7d9823-37da-4e8c-b8a3-6cebe019487c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CurveCenterPosition = new Point(330, 362),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5b9cd1e6-bdfc-4fce-ba15-330a602bee05"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("75092ba4-ecb0-4693-84b7-dcd035acc2c6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11930SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11930",
				UId = new Guid("e8cb3a4c-7cc5-459d-b341-81ef36db5daa"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CurveCenterPosition = new Point(556, 364),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4c3d3b34-9952-4179-96ea-214e7caa715f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("96dfcecd-9c66-4b03-9efa-d52aeeb17679"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11931SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11931",
				UId = new Guid("1df1ff3e-4a6d-43b6-a0f5-69db6af6c8eb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CurveCenterPosition = new Point(662, 365),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("96dfcecd-9c66-4b03-9efa-d52aeeb17679"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c36e3433-8fd5-4c56-8989-f7634b49ade8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("a869d7ad-b651-43a1-a6b8-493f3f5029d8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CurveCenterPosition = new Point(465, 420),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("75092ba4-ecb0-4693-84b7-dcd035acc2c6"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5da1e53e-e6c2-48fe-95f3-3f73866e901a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("2c5c8791-f513-4a2d-952a-aab84d342b04"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CurveCenterPosition = new Point(590, 418),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5da1e53e-e6c2-48fe-95f3-3f73866e901a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ac99f109-73b2-45d2-928b-5148cb36a0af"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("d98aab7e-484a-4970-a6c0-7ff9301a4756"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CurveCenterPosition = new Point(740, 418),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("421b027f-9383-4b56-b55c-5fb9f9bfafd9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("750af419-1bf5-41db-ab23-7c37e42b7804"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("c5ffc795-652b-40d2-af67-e0f55299af5b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CurveCenterPosition = new Point(863, 356),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("750af419-1bf5-41db-ab23-7c37e42b7804"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("abcba71b-a3c6-447b-959f-097f8ffc1605"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("e44e1e6c-b8bf-4f1f-993f-37900d966420"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CurveCenterPosition = new Point(871, 482),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("750af419-1bf5-41db-ab23-7c37e42b7804"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7a887db0-c2de-4344-a81c-3896dcdadce5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("762cb102-53e4-4ca5-9ea1-2c5040a6b97c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CurveCenterPosition = new Point(988, 320),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("abcba71b-a3c6-447b-959f-097f8ffc1605"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("67b5b6e8-67a7-41fe-bbae-5918d9e16be4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("8bbebf47-8c80-4c89-9bb9-627f7a257991"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CurveCenterPosition = new Point(998, 512),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7a887db0-c2de-4344-a81c-3896dcdadce5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("769b7bc2-acca-4817-ab6b-27e2a7a52af9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("d04a7261-cf66-4d88-95dc-341a1fe51176"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CurveCenterPosition = new Point(1146, 514),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("769b7bc2-acca-4817-ab6b-27e2a7a52af9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4b05dd3a-20db-41b5-8896-a8b4c53e424e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("23523aea-5592-47ff-96da-707954082fdb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CurveCenterPosition = new Point(1280, 513),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4b05dd3a-20db-41b5-8896-a8b4c53e424e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7d9e26dc-d4ec-4301-a39d-73b876434b9e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("66e321fa-08a4-4e0a-aabc-9ea7d2b812fe"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CurveCenterPosition = new Point(1410, 462),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7d9e26dc-d4ec-4301-a39d-73b876434b9e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a6aa388c-bbfc-498d-90b3-854bedf3c3c3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("042609ae-508f-4b46-8fb7-23eca00bc700"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CurveCenterPosition = new Point(1268, 356),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("67b5b6e8-67a7-41fe-bbae-5918d9e16be4"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a6aa388c-bbfc-498d-90b3-854bedf3c3c3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow12",
				UId = new Guid("1f04ee3c-fc17-4b70-b811-738f48e86263"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CurveCenterPosition = new Point(740, 417),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ac99f109-73b2-45d2-928b-5148cb36a0af"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("421b027f-9383-4b56-b55c-5fb9f9bfafd9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("31008b07-d42b-4cb1-a4bf-1cb38e25ea17"),
				ConditionExpression = @"UserConnection.SessionData[""ImportedRowsCount""] == null",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CurveCenterPosition = new Point(1050, 343),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ac99f109-73b2-45d2-928b-5148cb36a0af"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("67b5b6e8-67a7-41fe-bbae-5918d9e16be4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet558LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet558 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("20ccb07c-72d3-458e-9f38-259cddea1062"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"LaneSet558",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1636, 1189),
				UseBackgroundMode = false
			};
			return schemaLaneSet558;
		}

		protected virtual ProcessSchemaLane CreateLane1939Lane() {
			ProcessSchemaLane schemaLane1939 = new ProcessSchemaLane(this) {
				UId = new Guid("5b997dc6-619b-42ed-974e-3724fa91dacd"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("20ccb07c-72d3-458e-9f38-259cddea1062"),
				CreatedInOwnerSchemaUId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"Lane1939",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 767),
				Size = new Size(1607, 422),
				UseBackgroundMode = false
			};
			return schemaLane1939;
		}

		protected virtual ProcessSchemaLane CreateLane1940Lane() {
			ProcessSchemaLane schemaLane1940 = new ProcessSchemaLane(this) {
				UId = new Guid("0f3bda2c-5100-40d9-92fd-e4f7c0f76796"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("20ccb07c-72d3-458e-9f38-259cddea1062"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"Lane1940",
				Position = new Point(29, 604),
				Size = new Size(1607, 158),
				UseBackgroundMode = false
			};
			return schemaLane1940;
		}

		protected virtual ProcessSchemaLane CreateLane1941Lane() {
			ProcessSchemaLane schemaLane1941 = new ProcessSchemaLane(this) {
				UId = new Guid("02aaaba3-b35e-4d43-96ab-5a01146b77b4"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("20ccb07c-72d3-458e-9f38-259cddea1062"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"Lane1941",
				Position = new Point(29, 0),
				Size = new Size(1607, 236),
				UseBackgroundMode = false
			};
			return schemaLane1941;
		}

		protected virtual ProcessSchemaLane CreateLane1942Lane() {
			ProcessSchemaLane schemaLane1942 = new ProcessSchemaLane(this) {
				UId = new Guid("70393949-f1bd-48a6-84b3-65a2800e0fff"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("20ccb07c-72d3-458e-9f38-259cddea1062"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"Lane1942",
				Position = new Point(29, 241),
				Size = new Size(1607, 358),
				UseBackgroundMode = false
			};
			return schemaLane1942;
		}

		protected virtual ProcessSchemaEventSubProcess CreateShadowingBaseEventsSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaShadowingBaseEventsSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a79ecad8-b7ba-425e-a113-f08dc7c544c6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b997dc6-619b-42ed-974e-3724fa91dacd"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"ShadowingBaseEventsSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(316, 150),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaShadowingBaseEventsSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseLookupGridPageTreeGridSelectionChangeStartMassageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("934bb160-0195-413c-b529-db404c15aa23"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a79ecad8-b7ba-425e-a113-f08dc7c544c6"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"TreeGridSelectionChange",
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"BaseLookupGridPageTreeGridSelectionChangeStartMassage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSetParentPrimaryColumnValueScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("39e16073-fa8d-48ed-8b53-d10e30dc41d5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a79ecad8-b7ba-425e-a113-f08dc7c544c6"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"SetParentPrimaryColumnValueScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,141,177,10,194,48,20,69,103,243,21,207,78,45,148,254,64,113,16,93,4,135,96,209,253,81,175,18,72,19,121,121,81,138,248,239,102,16,7,221,46,156,115,184,238,66,181,229,43,186,45,43,15,49,203,8,90,174,40,100,239,27,122,154,197,222,37,69,128,88,137,35,82,26,160,101,221,32,58,215,95,84,242,15,62,238,206,45,85,150,5,161,120,110,98,153,55,209,231,41,156,216,103,84,45,253,92,117,235,81,221,29,135,248,248,183,155,222,188,140,64,179,4,82,201,232,223,10,169,163,240,171,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("975732ec-f9de-44b9-b9a4-8ccd764eddc8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a79ecad8-b7ba-425e-a113-f08dc7c544c6"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"TreeGridSelectionChange",
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(274, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageEventHandlerSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageEventHandlerSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("66e685cc-369b-4f9c-82e5-518721e410c4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b997dc6-619b-42ed-974e-3724fa91dacd"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"PageEventHandlerSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 191),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(337, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageEventHandlerSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseLookupGridPageInitStartMassageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("daf0ac11-dbdb-4af1-aa47-bda076077337"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("66e685cc-369b-4f9c-82e5-518721e410c4"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"BaseLookupGridPageInitStartMassage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(14, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBaseLookupGridPageInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("db071bdc-29fe-4166-a2b0-1b453869f0f3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("66e685cc-369b-4f9c-82e5-518721e410c4"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"BaseLookupGridPageInitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(231, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,207,14,1,65,12,135,207,60,197,186,113,153,23,16,7,22,201,30,36,98,121,128,26,93,25,91,211,213,233,32,196,187,155,141,132,131,132,99,155,223,247,245,143,171,250,189,217,85,77,17,198,7,184,174,240,20,49,232,32,187,119,59,75,216,163,153,130,66,201,81,44,154,49,17,95,114,32,218,130,173,75,43,174,209,5,123,167,44,206,239,179,81,86,1,5,28,126,115,155,128,75,225,202,17,254,8,253,147,171,196,22,43,82,203,1,185,27,126,216,60,138,160,215,50,69,172,70,193,254,224,237,231,139,39,134,221,26,143,13,129,226,156,165,56,54,44,154,246,217,165,112,152,68,85,246,166,189,124,118,78,142,96,114,114,182,78,207,216,52,45,248,30,252,232,10,38,183,127,149,79,99,85,26,85,52,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("fcd11339-c2c1-4137-b88f-9e842a3f490b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("66e685cc-369b-4f9c-82e5-518721e410c4"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(119, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b7fb066e-bc23-474b-a0bd-7886d8157c4d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0f3bda2c-5100-40d9-92fd-e4f7c0f76796"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"EventSubProcess10",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(322, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseLookupGridPageDataSourceBeforeLoadStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("45549b86-c30e-411c-a525-0b58f27951e3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b7fb066e-bc23-474b-a0bd-7886d8157c4d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DataSourceBeforeLoad",
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"BaseLookupGridPageDataSourceBeforeLoadStartMessage",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBaseLookupGridPageDataSourceBeforeLoadScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("993eb94e-eea1-464a-b518-2a45060843f9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b7fb066e-bc23-474b-a0bd-7886d8157c4d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"BaseLookupGridPageDataSourceBeforeLoadScriptTask",
				Position = new Point(190, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,145,193,110,131,48,12,134,207,228,41,204,165,162,151,84,61,35,14,91,217,164,93,40,18,79,16,5,183,139,4,9,114,146,73,168,226,221,23,160,91,5,99,61,112,192,177,191,255,147,125,56,64,133,14,12,213,72,80,43,66,233,148,209,112,49,4,29,169,86,80,31,170,182,107,68,15,210,52,190,213,44,23,78,84,198,147,196,202,145,151,206,19,130,244,68,168,221,163,144,65,41,174,200,31,189,252,180,106,73,153,117,164,244,245,7,127,154,232,133,104,199,225,53,143,151,179,75,190,238,77,153,186,64,18,87,19,138,127,216,194,55,205,153,222,218,206,245,201,31,240,126,15,55,22,109,248,207,45,75,147,45,139,249,197,242,119,165,235,215,126,68,110,132,164,44,26,157,150,176,56,3,29,212,96,183,91,166,240,243,184,248,252,119,239,89,6,203,10,47,140,198,201,59,10,55,65,33,63,33,249,18,116,63,6,40,253,175,229,60,52,185,200,205,172,248,73,86,20,17,6,152,134,64,13,75,14,255,3,155,191,231,250,107,226,139,149,168,235,112,155,116,123,180,52,86,221,39,143,161,101,96,3,91,4,127,3,240,39,91,101,159,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateDownloadTemplateForImportProductsButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaDownloadTemplateForImportProductsButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("035a1334-0efa-40b0-8503-3d326c248edb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("02aaaba3-b35e-4d43-96ab-5a01146b77b4"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"DownloadTemplateForImportProductsButtonClickEventSubProcess",
				Position = new Point(43, 23),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(318, 177),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaDownloadTemplateForImportProductsButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDownloadTemplateForImportProductsButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("49177e0b-2450-411e-8409-3a6452e98c16"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("035a1334-0efa-40b0-8503-3d326c248edb"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DownloadTemplateForImportProductsButtonClick",
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"DownloadTemplateForImportProductsButtonClickStartMessage",
				Position = new Point(36, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDownloadTemplateScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("30d7fa2f-2c9d-49f8-83e5-54d304bcca21"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("035a1334-0efa-40b0-8503-3d326c248edb"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"DownloadTemplateScript",
				Position = new Point(175, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,73,45,42,74,44,206,79,43,209,115,206,207,75,203,76,47,45,74,44,201,204,207,211,243,204,45,200,47,42,9,73,205,45,200,73,44,73,117,201,47,207,203,201,79,76,73,45,210,131,49,97,82,26,161,197,169,69,64,189,121,169,201,32,141,58,10,110,153,57,169,126,137,185,169,154,214,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,181,45,59,105,106,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateImportProductsButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaImportProductsButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a612cced-055a-4863-b26e-79f85a7579d5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("70393949-f1bd-48a6-84b3-65a2800e0fff"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"ImportProductsButtonClickEventSubProcess",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(1558, 337),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaImportProductsButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateImportProductsButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ef166337-390d-4646-84c5-6a853d9f0b06"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a612cced-055a-4863-b26e-79f85a7579d5"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ImportProductsButtonClick",
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"ImportProductsButtonClickStartMessage",
				Position = new Point(36, 153),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSetParametersScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5b9cd1e6-bdfc-4fce-ba15-330a602bee05"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a612cced-055a-4863-b26e-79f85a7579d5"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"SetParametersScript",
				Position = new Point(134, 139),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,203,14,130,48,16,69,215,248,21,13,43,93,64,140,10,218,16,23,234,194,176,48,144,160,31,208,150,65,137,218,154,233,84,248,124,235,107,207,110,206,60,206,157,226,1,58,191,63,12,82,137,166,118,138,108,5,68,173,62,219,82,156,225,100,1,143,194,94,227,15,228,53,91,51,13,29,219,187,182,30,135,138,215,243,229,116,37,163,249,12,120,180,16,146,71,188,73,150,81,35,185,84,105,147,138,52,153,133,147,108,84,12,139,120,175,1,230,218,146,208,10,62,89,202,104,130,158,98,127,167,192,218,248,63,244,159,100,1,99,67,205,187,155,177,112,240,2,223,244,214,176,186,152,238,135,91,211,135,89,48,84,228,139,157,67,4,77,27,69,237,19,202,175,144,208,65,54,66,32,135,250,7,47,149,183,192,23,87,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenImportProductsSettingsPageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("75092ba4-ecb0-4693-84b7-dcd035acc2c6"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a612cced-055a-4863-b26e-79f85a7579d5"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"OpenImportProductsSettingsPageUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(274, 139),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenImportProductsSettingsPageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateShowMessageBoxStartMessageIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("5da1e53e-e6c2-48fe-95f3-3f73866e901a"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a612cced-055a-4863-b26e-79f85a7579d5"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"ShowMessageBox",
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"ShowMessageBoxStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(428, 153),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateShowMessageBoxScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("421b027f-9383-4b56-b55c-5fb9f9bfafd9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a612cced-055a-4863-b26e-79f85a7579d5"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"ShowMessageBoxScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(701, 139),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,77,107,2,49,16,134,207,21,252,15,105,78,43,44,139,119,173,135,250,1,75,91,181,126,20,74,233,33,93,71,73,217,157,145,36,171,149,197,255,222,89,93,139,212,232,37,144,201,51,239,251,102,146,141,50,66,103,107,50,14,22,19,218,218,46,229,232,196,131,64,216,138,39,216,189,169,52,135,177,210,166,173,209,133,130,151,78,208,12,69,179,209,170,215,232,235,27,18,119,217,61,5,107,53,97,79,57,197,66,115,11,166,75,136,140,114,49,58,59,252,144,241,255,86,249,201,186,122,41,130,155,162,247,28,47,79,211,134,40,68,189,118,231,75,31,248,163,55,110,201,178,243,190,94,227,168,75,109,178,209,26,240,153,86,3,157,66,244,194,140,90,193,12,126,74,105,235,140,198,85,52,32,147,41,23,156,113,21,22,94,14,36,226,52,190,242,33,97,57,73,143,105,156,16,178,155,124,157,247,167,179,120,52,148,126,236,49,119,142,208,150,228,123,127,58,28,93,193,38,96,215,140,157,50,218,234,129,123,250,240,40,202,236,218,199,107,133,213,245,58,162,40,228,14,172,12,89,23,108,213,38,247,161,40,36,82,89,29,210,95,113,239,247,28,27,74,24,137,209,58,133,9,196,11,54,61,109,230,241,130,155,174,127,13,14,156,209,6,2,207,15,41,231,101,192,229,6,133,51,57,180,126,1,29,192,10,66,193,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateConfirmOpenLogFileUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("750af419-1bf5-41db-ab23-7c37e42b7804"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a612cced-055a-4863-b26e-79f85a7579d5"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"ConfirmOpenLogFile",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(862, 139),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeConfirmOpenLogFileParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateNoMessageStartMessageIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("abcba71b-a3c6-447b-959f-097f8ffc1605"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a612cced-055a-4863-b26e-79f85a7579d5"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"NoMessage",
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"NoMessageStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(1142, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateClearParametersScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("67b5b6e8-67a7-41fe-bbae-5918d9e16be4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a612cced-055a-4863-b26e-79f85a7579d5"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"ClearParametersScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(1352, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,187,14,130,64,16,69,107,72,248,135,145,106,183,217,31,32,84,128,134,206,104,140,133,177,88,113,140,152,125,232,176,139,36,198,127,119,233,192,132,118,102,238,185,39,99,47,15,108,28,224,208,160,170,245,211,146,171,175,123,236,186,214,154,82,58,9,57,28,58,164,194,26,19,206,194,80,76,150,167,180,154,198,210,115,150,196,237,13,216,34,108,149,131,241,74,113,248,64,18,71,189,164,121,111,40,99,27,223,94,249,18,32,240,35,131,111,40,81,161,67,54,55,227,98,77,86,179,169,83,202,69,72,68,199,59,18,178,52,24,114,81,119,213,203,75,197,10,171,188,54,98,43,73,234,192,162,185,52,231,162,26,176,241,161,132,143,165,203,63,16,59,212,182,71,246,247,138,49,245,77,98,66,231,201,128,35,143,217,15,143,96,72,57,106,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateYesMessageStartMessageIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("7a887db0-c2de-4344-a81c-3896dcdadce5"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a612cced-055a-4863-b26e-79f85a7579d5"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"YesMessage",
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"YesMessageStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(1002, 251),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareUploadScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("769b7bc2-acca-4817-ab6b-27e2a7a52af9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a612cced-055a-4863-b26e-79f85a7579d5"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"PrepareUploadScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(1128, 237),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,37,142,65,10,131,48,16,69,215,230,20,67,54,42,150,28,160,161,11,41,93,8,45,20,212,3,4,51,213,20,73,100,50,106,161,244,238,181,118,241,62,111,241,23,47,50,57,223,67,236,200,77,12,39,144,171,243,54,172,170,65,34,19,195,131,85,249,52,175,27,242,16,108,84,205,64,97,61,143,14,61,95,150,109,178,84,66,1,34,169,124,100,227,59,108,43,11,133,72,100,122,128,180,54,11,94,67,255,211,141,55,184,216,78,99,48,22,142,192,52,35,124,114,45,53,136,187,233,81,149,214,214,123,65,246,15,201,181,16,132,60,147,223,191,250,11,97,206,77,159,166,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateSaveLogIntermediateCatchMessageEventIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("4b05dd3a-20db-41b5-8896-a8b4c53e424e"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a612cced-055a-4863-b26e-79f85a7579d5"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"SaveLog",
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"SaveLogIntermediateCatchMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(1261, 251),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSaveLogScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7d9e26dc-d4ec-4301-a39d-73b876434b9e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a612cced-055a-4863-b26e-79f85a7579d5"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"SaveLogScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(1380, 237),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,203,110,219,48,16,60,203,95,193,242,68,1,41,155,187,224,131,31,114,107,160,69,140,198,69,14,73,14,172,180,182,9,72,164,202,71,226,32,240,191,119,41,210,177,236,160,5,114,144,5,115,135,179,59,179,35,185,33,236,151,5,51,211,74,65,229,164,86,252,22,172,197,247,92,56,113,79,203,125,5,205,178,237,180,113,203,154,62,146,79,99,162,124,211,228,228,149,140,178,39,97,8,12,1,100,76,216,87,47,235,252,3,148,69,228,177,206,72,181,157,122,217,212,96,144,71,193,51,185,29,158,177,60,33,27,189,253,129,124,98,11,246,136,131,6,27,93,232,200,249,76,55,190,85,140,38,244,26,246,142,230,124,97,116,203,134,67,124,215,91,154,143,178,140,223,237,192,0,187,152,47,231,75,91,254,241,162,97,145,142,175,132,17,45,56,28,232,76,122,222,83,220,24,156,116,250,50,177,21,163,51,3,194,65,125,163,122,118,97,211,152,168,194,91,148,69,88,16,83,255,46,247,80,121,167,131,230,11,215,74,101,189,129,249,244,116,196,114,52,30,201,18,193,50,24,250,19,68,112,172,141,34,145,101,224,15,143,228,16,49,236,212,44,241,100,207,59,217,0,97,233,50,15,184,99,143,44,147,155,183,202,253,245,112,245,125,53,59,219,24,159,116,29,168,122,128,231,107,29,247,135,132,197,127,110,208,7,243,128,22,69,200,97,148,126,240,57,196,117,111,112,194,160,19,149,157,223,63,241,167,96,24,176,157,86,54,120,176,138,106,226,255,2,163,122,172,97,40,148,3,229,214,47,93,192,81,135,161,248,210,53,66,42,90,12,80,147,186,254,22,61,163,233,194,231,185,196,154,149,97,13,244,42,141,194,23,218,180,194,49,42,156,19,213,174,69,92,209,15,172,48,34,227,215,235,3,119,152,185,43,178,50,186,246,149,179,49,44,11,4,96,232,122,91,222,58,222,25,233,128,29,197,158,149,74,116,41,28,132,168,207,49,67,136,187,140,250,187,80,99,110,209,197,148,232,15,197,248,152,153,190,229,191,191,99,116,183,213,79,239,63,151,98,116,24,25,112,222,40,226,140,135,226,47,133,244,62,214,97,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd1EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("a6aa388c-bbfc-498d-90b3-854bedf3c3c3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a612cced-055a-4863-b26e-79f85a7579d5"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"End1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(1492, 139),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway3ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("ac99f109-73b2-45d2-928b-5148cb36a0af"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a612cced-055a-4863-b26e-79f85a7579d5"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"ExclusiveGateway3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(547, 139),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b8d4cf96-7c29-4c6b-9042-5cb54cfe0daa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b997dc6-619b-42ed-974e-3724fa91dacd"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(427, 196),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(324, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4c3d3b34-9952-4179-96ea-214e7caa715f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b8d4cf96-7c29-4c6b-9042-5cb54cfe0daa"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"PageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("96dfcecd-9c66-4b03-9efa-d52aeeb17679"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b8d4cf96-7c29-4c6b-9042-5cb54cfe0daa"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"PageLoadCompleteIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c36e3433-8fd5-4c56-8989-f7634b49ade8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b8d4cf96-7c29-4c6b-9042-5cb54cfe0daa"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				Name = @"PageLoadCompleteScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(218, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,141,205,10,130,64,20,70,215,249,20,131,43,93,40,65,54,25,225,38,250,65,104,17,89,15,112,155,185,166,160,115,101,188,131,132,248,238,21,181,110,253,157,115,190,186,20,193,222,112,205,207,66,85,216,194,45,215,34,203,132,193,65,28,93,173,3,127,76,212,10,36,130,142,18,188,167,81,82,170,121,148,202,5,70,235,20,164,76,150,114,93,162,158,252,48,20,163,55,59,195,3,227,29,13,166,33,208,87,108,187,6,24,15,100,243,182,35,203,103,75,218,41,238,183,142,153,76,92,84,52,4,225,230,103,253,69,38,239,91,6,134,130,156,85,24,159,222,7,23,26,250,207,106,145,157,53,130,173,195,205,11,199,50,254,107,208,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateInitializeDataSourceCurrentStructureMethod());
			Methods.Add(CreateGetDeafaultLookupEditSchemaIdMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2ec18d58-d5ad-4b15-9d7a-8ac963b89dfd"),
				Name = "Terrasoft.Configuration",
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
				UId = new Guid("775363c7-62ae-4a8d-b363-4350699b5cf2"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("51e927e4-70cf-41b6-867a-8768292a856e"),
				Name = "System.Data",
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

		protected virtual SchemaMethod CreateInitializeDataSourceCurrentStructureMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("dac950a4-45bc-49cb-af22-3da3a698836d"),
				Name = "InitializeDataSourceCurrentStructure",
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,88,77,111,219,56,16,61,219,128,255,195,196,39,25,8,212,230,154,93,167,104,29,111,55,64,219,120,235,180,61,20,61,176,18,29,19,43,75,42,41,53,117,183,249,239,59,228,80,31,164,232,196,233,37,112,168,225,155,55,95,143,148,196,6,162,101,94,137,106,191,78,182,124,199,62,92,165,48,159,195,235,90,164,241,114,87,86,251,25,252,55,25,143,36,175,106,153,255,49,25,223,79,198,207,158,193,66,114,86,113,72,89,197,84,81,203,132,3,55,24,160,12,200,100,252,157,73,187,68,176,111,89,206,110,185,132,57,124,80,92,46,138,60,231,73,37,138,60,94,14,141,208,75,127,213,193,65,128,16,110,252,154,87,87,185,170,88,158,240,87,123,140,193,143,105,134,160,43,180,140,47,145,242,218,80,142,91,196,62,32,218,117,38,235,74,214,9,6,142,145,170,69,45,37,26,118,75,115,240,1,125,19,196,50,217,66,114,77,126,120,42,42,40,113,31,136,116,50,214,89,54,75,26,137,252,235,244,247,178,239,231,34,43,138,127,235,114,249,212,140,188,99,59,30,77,215,123,245,198,236,159,206,60,220,127,106,46,247,1,112,90,159,67,206,239,96,176,30,13,237,103,77,200,43,41,118,12,183,38,69,86,239,114,96,105,202,83,168,10,219,31,240,205,224,10,5,57,18,75,97,122,149,158,77,205,190,155,235,203,235,115,120,207,197,174,204,248,14,227,130,91,76,222,119,150,213,28,233,221,138,4,238,182,60,135,141,248,129,219,196,6,137,113,68,166,126,51,160,214,241,130,252,206,15,197,20,191,76,83,178,9,68,161,115,231,224,152,244,205,116,112,173,159,165,173,218,19,28,233,252,47,157,98,99,99,154,82,28,218,251,151,200,42,46,149,198,8,208,36,27,26,69,178,252,36,170,237,138,73,100,171,183,69,56,183,180,190,40,118,37,147,66,21,249,205,190,228,241,242,91,205,178,83,67,199,157,146,233,41,248,115,211,117,10,70,145,209,208,218,126,235,45,28,14,31,83,233,111,143,92,9,208,30,176,146,145,15,26,47,138,26,235,127,49,135,51,210,160,182,61,244,60,177,178,148,69,41,133,150,33,59,91,8,130,129,209,239,91,147,21,9,213,150,229,112,6,133,254,37,139,59,192,255,248,143,132,151,218,1,66,18,53,135,124,171,7,29,147,207,207,191,32,199,81,96,80,251,27,117,168,58,189,182,220,31,117,207,254,169,39,249,66,23,98,20,104,51,50,84,88,230,60,181,51,26,232,173,88,63,152,197,61,84,179,160,25,209,52,247,132,251,88,66,195,81,137,27,80,20,248,198,63,65,70,195,184,251,10,5,47,116,61,46,57,219,176,58,171,136,145,6,104,172,163,25,156,15,52,174,213,9,18,152,13,214,135,148,66,65,42,84,153,49,172,102,14,141,180,42,30,84,65,34,254,251,42,72,251,15,104,33,127,162,10,246,201,104,196,193,254,190,16,188,229,21,91,177,106,59,125,212,114,193,76,171,62,110,248,73,164,22,79,75,84,82,164,157,50,61,184,15,179,113,45,83,46,47,133,108,199,46,229,211,182,64,104,10,12,245,86,203,136,169,83,155,62,91,49,114,168,154,85,18,156,160,215,223,86,42,232,157,92,167,224,53,125,56,51,125,229,244,184,5,21,13,109,236,52,58,170,54,4,62,78,207,204,193,94,246,231,171,153,165,254,252,187,103,213,9,54,88,157,101,51,120,161,229,226,176,97,172,161,206,221,59,130,241,183,21,92,50,153,108,31,240,248,183,107,242,144,79,207,244,160,87,27,229,37,141,237,163,193,58,118,71,196,236,216,135,72,152,46,189,202,69,37,88,38,126,114,212,249,238,94,170,120,115,1,81,120,39,83,250,78,54,25,127,45,138,12,175,30,78,78,95,154,251,201,28,54,44,83,250,218,230,218,56,28,14,152,122,233,242,173,244,1,23,234,177,230,144,131,231,116,198,225,132,113,150,108,237,245,213,178,183,255,136,112,155,210,198,17,70,40,242,91,216,89,105,65,223,253,205,193,179,128,182,92,120,122,52,26,145,130,88,245,24,222,124,59,249,120,181,111,118,70,141,95,66,8,229,184,101,100,47,222,189,86,153,15,102,37,128,226,118,206,17,96,126,75,246,49,253,65,56,114,80,168,79,31,31,148,249,65,122,231,212,18,148,38,107,115,165,62,10,37,190,102,250,157,226,36,242,211,246,235,215,144,47,109,183,37,79,232,140,120,82,197,251,231,202,104,164,187,243,132,158,33,153,119,24,232,181,52,243,21,89,236,153,109,178,150,242,162,243,73,191,12,206,125,47,40,115,32,29,195,73,228,213,69,255,252,106,17,220,115,233,24,40,119,199,69,212,29,131,237,245,134,130,245,114,220,68,119,64,21,176,241,57,197,7,28,107,7,14,130,211,101,3,160,160,116,132,241,252,18,183,80,7,164,165,67,193,63,247,230,226,102,234,24,10,130,192,244,92,151,222,72,30,57,222,254,124,198,55,197,218,244,11,189,22,141,156,231,78,67,55,10,56,160,55,76,205,128,165,63,242,79,35,235,207,191,199,185,35,20,74,48,113,209,6,129,99,245,100,248,129,196,208,222,14,84,229,72,198,67,31,126,130,71,158,73,48,199,182,13,240,64,92,115,253,153,65,59,110,114,217,40,58,189,75,235,155,92,38,84,197,115,188,172,233,239,17,148,12,255,139,198,251,226,78,249,71,212,27,187,109,37,139,132,43,181,214,239,202,69,201,37,170,69,251,8,97,236,99,12,5,239,111,43,67,197,233,75,51,177,120,157,11,185,196,23,174,120,104,108,138,246,63,250,253,63,23,176,18,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDeafaultLookupEditSchemaIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ab1024d8-4d9d-4a95-8a8a-63ee8e6fd414"),
				Name = "GetDeafaultLookupEditSchemaId",
				CreatedInSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,205,193,10,194,48,16,4,208,187,95,177,244,212,130,228,3,44,197,131,150,34,120,16,98,189,135,102,83,131,233,166,108,54,66,255,222,246,160,120,25,24,120,204,188,13,67,26,158,56,153,254,98,161,129,59,50,155,20,157,168,83,100,92,131,156,31,51,27,241,145,148,94,146,70,17,79,99,82,29,202,195,132,140,101,159,144,87,70,56,108,102,15,197,25,221,53,198,87,158,91,235,229,102,70,212,223,253,162,170,119,140,146,153,254,63,27,160,28,2,28,161,203,222,170,118,154,101,129,3,148,91,171,126,172,254,0,98,9,57,203,169,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseLookupGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"));
		}

		#endregion

	}

	#endregion

}

