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

	#region Class: AdministrationUnitsGridPageSchema

	/// <exclude/>
	public class AdministrationUnitsGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Constructors: Public

		public AdministrationUnitsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AdministrationUnitsGridPageSchema(AdministrationUnitsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
			TreeGrid.AjaxEvents.SelectionChange.ShowLoadMask = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
			RealUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
			Name = "AdministrationUnitsGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			HelpContextId = "257";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAdministrationUnitsGridPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateAdministrationUnitsGridPageEventsProcessSchema() {
			var schema = new AdministrationUnitsGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364");
			DataSource.ModifiedInSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("5290130e-33dd-4505-ab30-5c14b4e28e78");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
				column.ModifiedInSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("5b7f0f95-f410-4bfe-a332-0508c3ff1b7d");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
				column.ModifiedInSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3678b2d1-343e-4e0c-8a93-f082143be510");
			if (column != null) {
				column.UId = new Guid("8fa75504-6206-4792-a43c-e6681eeb884e");
				column.Name = @"ParentRole";
				column.CreatedInSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
				column.ModifiedInSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3b1b6e4c-aa09-413c-9ded-a6ad81bb93c1");
			if (column != null) {
				column.UId = new Guid("b2365d76-f73c-415e-8fae-abfe5ed3ae09");
				column.Name = @"SysAdminUnitType";
				column.CreatedInSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
				column.ModifiedInSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4acc2d13-7573-41ec-9a30-e20696bf0314");
			if (column != null) {
				column.UId = new Guid("7f048df9-860f-40d8-92f8-2d2daa04daf6");
				column.Name = @"ConnectionType";
				column.CreatedInSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
				column.ModifiedInSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
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
			return new AdministrationUnitsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new AdministrationUnitsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AdministrationUnitsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AdministrationUnitsGridPageEventsProcess

	/// <exclude/>
	public class AdministrationUnitsGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AdministrationUnitsGridPageSchemaUserControl
	{

		#region Class: DenyDeleteRootRecordFlowElement

		/// <exclude/>
		public class DenyDeleteRootRecordFlowElement : QuestionUserTask
		{

			public DenyDeleteRootRecordFlowElement(UserConnection userConnection, AdministrationUnitsGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "DenyDeleteRootRecord";
				IsLogging = false;
				SchemaElementUId = new Guid("7e57ce12-11fd-4b10-8c1f-5d28754412fd");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public AdministrationUnitsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdministrationUnitsGridPageEventsProcess";
			SchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
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

		public virtual Guid EntitySchemaHierarchyColumnUId {
			get;
			set;
		}

		public virtual Guid AvailableForAddSysAdminUnitType {
			get;
			set;
		}

		public virtual Guid AddElementId {
			get;
			set;
		}

		public virtual bool DoDeleteRecord {
			get;
			set;
		}

		public virtual Guid ParentRoleId {
			get;
			set;
		}

		private ProcessFlowElement _subProcessDataSourceBeforeLoad;
		public ProcessFlowElement SubProcessDataSourceBeforeLoad {
			get {
				return _subProcessDataSourceBeforeLoad ?? (_subProcessDataSourceBeforeLoad = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessDataSourceBeforeLoad",
					SchemaElementUId = new Guid("a738c919-d50e-4e67-8ad7-cbd8eb19a474"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dataSourceBeforeLoadMessage;
		public ProcessFlowElement DataSourceBeforeLoadMessage {
			get {
				return _dataSourceBeforeLoadMessage ?? (_dataSourceBeforeLoadMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataSourceBeforeLoadMessage",
					SchemaElementUId = new Guid("6f9a43b7-8772-491c-9ca7-21095a78f001"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDataSourceBeforeLoad;
		public ProcessScriptTask ScriptDataSourceBeforeLoad {
			get {
				return _scriptDataSourceBeforeLoad ?? (_scriptDataSourceBeforeLoad = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDataSourceBeforeLoad",
					SchemaElementUId = new Guid("7e61051d-e0fa-4a8e-bf73-6a287910648c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDataSourceBeforeLoadExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessDataSourceLoaded;
		public ProcessFlowElement SubProcessDataSourceLoaded {
			get {
				return _subProcessDataSourceLoaded ?? (_subProcessDataSourceLoaded = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessDataSourceLoaded",
					SchemaElementUId = new Guid("7ff2a044-9d12-4d78-823c-809d4e7d1d7a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dataSourceLoadedMessage;
		public ProcessFlowElement DataSourceLoadedMessage {
			get {
				return _dataSourceLoadedMessage ?? (_dataSourceLoadedMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataSourceLoadedMessage",
					SchemaElementUId = new Guid("6b401249-46db-4b65-8d17-42d71c7b9f09"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDataSourceLoaded;
		public ProcessScriptTask ScriptDataSourceLoaded {
			get {
				return _scriptDataSourceLoaded ?? (_scriptDataSourceLoaded = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDataSourceLoaded",
					SchemaElementUId = new Guid("dfc2d046-a2e8-4bf4-aa3e-5109b09bc23a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDataSourceLoadedExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessInit;
		public ProcessFlowElement SubProcessInit {
			get {
				return _subProcessInit ?? (_subProcessInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessInit",
					SchemaElementUId = new Guid("5ddd3610-d0f7-408a-a4df-83eeeb239c91"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _initMessage;
		public ProcessFlowElement InitMessage {
			get {
				return _initMessage ?? (_initMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InitMessage",
					SchemaElementUId = new Guid("a2e36889-5f4d-419c-a09c-03eeaed73699"),
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
					SchemaElementUId = new Guid("234ff53e-23e0-4051-9a4e-a34585c29877"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptInitExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _throwInitParent;
		public ProcessThrowMessageEvent ThrowInitParent {
			get {
				return _throwInitParent ?? (_throwInitParent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowInitParent",
					SchemaElementUId = new Guid("65971a5b-50b0-47ae-af78-193223ed87da"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _subProcess9;
		public ProcessFlowElement SubProcess9 {
			get {
				return _subProcess9 ?? (_subProcess9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess9",
					SchemaElementUId = new Guid("9a53b087-7117-4ee6-b882-7012c3230411"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _gridPageRefreshRowChild;
		public ProcessFlowElement GridPageRefreshRowChild {
			get {
				return _gridPageRefreshRowChild ?? (_gridPageRefreshRowChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "GridPageRefreshRowChild",
					SchemaElementUId = new Guid("f9dbd54a-e20e-49d2-af1a-9b6f46d4526c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptGridPageRefreshRowChild;
		public ProcessScriptTask ScriptGridPageRefreshRowChild {
			get {
				return _scriptGridPageRefreshRowChild ?? (_scriptGridPageRefreshRowChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptGridPageRefreshRowChild",
					SchemaElementUId = new Guid("4800adf6-65dd-457d-84fe-849ff7975a71"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptGridPageRefreshRowChildExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess11;
		public ProcessFlowElement SubProcess11 {
			get {
				return _subProcess11 ?? (_subProcess11 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess11",
					SchemaElementUId = new Guid("98e38993-d2c1-4691-8a3c-449cd5934230"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dataSourceLoadRowsResponseRegisteredChild;
		public ProcessFlowElement DataSourceLoadRowsResponseRegisteredChild {
			get {
				return _dataSourceLoadRowsResponseRegisteredChild ?? (_dataSourceLoadRowsResponseRegisteredChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataSourceLoadRowsResponseRegisteredChild",
					SchemaElementUId = new Guid("3dfc1f3a-62de-4264-9f97-d23f3e404728"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptChildDataSourceLoadRowsResponseRegistered;
		public ProcessScriptTask ScriptChildDataSourceLoadRowsResponseRegistered {
			get {
				return _scriptChildDataSourceLoadRowsResponseRegistered ?? (_scriptChildDataSourceLoadRowsResponseRegistered = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildDataSourceLoadRowsResponseRegistered",
					SchemaElementUId = new Guid("b746701a-0a60-40c0-954c-bbc7e86d1397"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildDataSourceLoadRowsResponseRegisteredExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _throwDataSourceLoadRowsResponseRegisteredParent;
		public ProcessThrowMessageEvent ThrowDataSourceLoadRowsResponseRegisteredParent {
			get {
				return _throwDataSourceLoadRowsResponseRegisteredParent ?? (_throwDataSourceLoadRowsResponseRegisteredParent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowDataSourceLoadRowsResponseRegisteredParent",
					SchemaElementUId = new Guid("4091e0ff-21a4-4033-9e26-f41bb817a547"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DataSourceLoadRowsResponseRegistered",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _subProcess13;
		public ProcessFlowElement SubProcess13 {
			get {
				return _subProcess13 ?? (_subProcess13 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess13",
					SchemaElementUId = new Guid("b46699a0-03d9-44c0-a523-697e2d3cb294"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deleteButtonClickChild;
		public ProcessFlowElement DeleteButtonClickChild {
			get {
				return _deleteButtonClickChild ?? (_deleteButtonClickChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteButtonClickChild",
					SchemaElementUId = new Guid("5c070686-44d0-4cbe-ba17-e527cfec5ccb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDeleteButtonClickChild;
		public ProcessScriptTask ScriptDeleteButtonClickChild {
			get {
				return _scriptDeleteButtonClickChild ?? (_scriptDeleteButtonClickChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDeleteButtonClickChild",
					SchemaElementUId = new Guid("99b04025-f973-48ec-912e-5401be227345"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDeleteButtonClickChildExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _throwDeleteButtonClickParent;
		public ProcessThrowMessageEvent ThrowDeleteButtonClickParent {
			get {
				return _throwDeleteButtonClickParent ?? (_throwDeleteButtonClickParent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowDeleteButtonClickParent",
					SchemaElementUId = new Guid("c582aa6b-3f06-4770-bc1a-1778a5496fc4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DeleteButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptScriptDeleteButtonClickChildBefore;
		public ProcessScriptTask ScriptScriptDeleteButtonClickChildBefore {
			get {
				return _scriptScriptDeleteButtonClickChildBefore ?? (_scriptScriptDeleteButtonClickChildBefore = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptScriptDeleteButtonClickChildBefore",
					SchemaElementUId = new Guid("d67a8286-282c-4e6a-ad65-b8a7d41b17ea"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptScriptDeleteButtonClickChildBeforeExecute,
				});
			}
		}

		private DenyDeleteRootRecordFlowElement _denyDeleteRootRecord;
		public DenyDeleteRootRecordFlowElement DenyDeleteRootRecord {
			get {
				return _denyDeleteRootRecord ?? (_denyDeleteRootRecord = new DenyDeleteRootRecordFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _startChildDataSourceRemoved;
		public ProcessFlowElement StartChildDataSourceRemoved {
			get {
				return _startChildDataSourceRemoved ?? (_startChildDataSourceRemoved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartChildDataSourceRemoved",
					SchemaElementUId = new Guid("ea3aeee9-5703-4951-9216-fc0d696fba52"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowDataSourceRemoved;
		public ProcessThrowMessageEvent IntermediateThrowDataSourceRemoved {
			get {
				return _intermediateThrowDataSourceRemoved ?? (_intermediateThrowDataSourceRemoved = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowDataSourceRemoved",
					SchemaElementUId = new Guid("83240534-e533-4db2-b90d-db6780033feb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DataSourceRemoved",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _subProcess10;
		public ProcessFlowElement SubProcess10 {
			get {
				return _subProcess10 ?? (_subProcess10 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess10",
					SchemaElementUId = new Guid("8fdf8b49-f501-4521-a402-61ccdd2f1446"),
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
					SchemaElementUId = new Guid("dd2ea106-66bd-4852-9510-5c886a10a75f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("469e3251-3d92-4153-b737-c8bb91bd684b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadCompleteChildExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _throwPageLoadCompleteParent;
		public ProcessThrowMessageEvent ThrowPageLoadCompleteParent {
			get {
				return _throwPageLoadCompleteParent ?? (_throwPageLoadCompleteParent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowPageLoadCompleteParent",
					SchemaElementUId = new Guid("dbcb519c-8168-465a-bc64-ec8c1940a52f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _subProcess12;
		public ProcessFlowElement SubProcess12 {
			get {
				return _subProcess12 ?? (_subProcess12 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess12",
					SchemaElementUId = new Guid("f1cc9870-9762-4f18-b0ce-345018587c60"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _applyFolderFilterChild;
		public ProcessFlowElement ApplyFolderFilterChild {
			get {
				return _applyFolderFilterChild ?? (_applyFolderFilterChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ApplyFolderFilterChild",
					SchemaElementUId = new Guid("ab2a712a-f489-4e98-91a1-7bcf646462da"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptApplyFolderFilterChild;
		public ProcessScriptTask ScriptApplyFolderFilterChild {
			get {
				return _scriptApplyFolderFilterChild ?? (_scriptApplyFolderFilterChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptApplyFolderFilterChild",
					SchemaElementUId = new Guid("ce496dad-7603-40fe-87c6-475f9784e602"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptApplyFolderFilterChildExecute,
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow249;
		public ProcessConditionalFlow ConditionalFlow249 {
			get {
				return _conditionalFlow249 ?? (_conditionalFlow249 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow249",
					SchemaElementUId = new Guid("99ffe649-8972-491f-ada9-22f0419c8728"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow250;
		public ProcessConditionalFlow ConditionalFlow250 {
			get {
				return _conditionalFlow250 ?? (_conditionalFlow250 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow250",
					SchemaElementUId = new Guid("9c0e3826-f207-45a5-9c3d-ddcba93f243c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _denyDeletRootRecord;
		public LocalizableString DenyDeletRootRecord {
			get {
				return _denyDeletRootRecord ?? (_denyDeletRootRecord = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DenyDeletRootRecord.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SubProcessDataSourceBeforeLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessDataSourceBeforeLoad };
			FlowElements[DataSourceBeforeLoadMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceBeforeLoadMessage };
			FlowElements[ScriptDataSourceBeforeLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDataSourceBeforeLoad };
			FlowElements[SubProcessDataSourceLoaded.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessDataSourceLoaded };
			FlowElements[DataSourceLoadedMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceLoadedMessage };
			FlowElements[ScriptDataSourceLoaded.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDataSourceLoaded };
			FlowElements[SubProcessInit.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessInit };
			FlowElements[InitMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitMessage };
			FlowElements[ScriptInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptInit };
			FlowElements[ThrowInitParent.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowInitParent };
			FlowElements[SubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess9 };
			FlowElements[GridPageRefreshRowChild.SchemaElementUId] = new Collection<ProcessFlowElement> { GridPageRefreshRowChild };
			FlowElements[ScriptGridPageRefreshRowChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptGridPageRefreshRowChild };
			FlowElements[SubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess11 };
			FlowElements[DataSourceLoadRowsResponseRegisteredChild.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceLoadRowsResponseRegisteredChild };
			FlowElements[ScriptChildDataSourceLoadRowsResponseRegistered.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildDataSourceLoadRowsResponseRegistered };
			FlowElements[ThrowDataSourceLoadRowsResponseRegisteredParent.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowDataSourceLoadRowsResponseRegisteredParent };
			FlowElements[SubProcess13.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess13 };
			FlowElements[DeleteButtonClickChild.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteButtonClickChild };
			FlowElements[ScriptDeleteButtonClickChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDeleteButtonClickChild };
			FlowElements[ThrowDeleteButtonClickParent.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowDeleteButtonClickParent };
			FlowElements[ScriptScriptDeleteButtonClickChildBefore.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptScriptDeleteButtonClickChildBefore };
			FlowElements[DenyDeleteRootRecord.SchemaElementUId] = new Collection<ProcessFlowElement> { DenyDeleteRootRecord };
			FlowElements[StartChildDataSourceRemoved.SchemaElementUId] = new Collection<ProcessFlowElement> { StartChildDataSourceRemoved };
			FlowElements[IntermediateThrowDataSourceRemoved.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowDataSourceRemoved };
			FlowElements[SubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess10 };
			FlowElements[PageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChild };
			FlowElements[ScriptPageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadCompleteChild };
			FlowElements[ThrowPageLoadCompleteParent.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowPageLoadCompleteParent };
			FlowElements[SubProcess12.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess12 };
			FlowElements[ApplyFolderFilterChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ApplyFolderFilterChild };
			FlowElements[ScriptApplyFolderFilterChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptApplyFolderFilterChild };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcessDataSourceBeforeLoad":
						break;
					case "DataSourceBeforeLoadMessage":
						e.Context.QueueTasks.Enqueue("ScriptDataSourceBeforeLoad");
						break;
					case "ScriptDataSourceBeforeLoad":
						break;
					case "SubProcessDataSourceLoaded":
						break;
					case "DataSourceLoadedMessage":
						e.Context.QueueTasks.Enqueue("ScriptDataSourceLoaded");
						break;
					case "ScriptDataSourceLoaded":
						break;
					case "SubProcessInit":
						break;
					case "InitMessage":
						e.Context.QueueTasks.Enqueue("ScriptInit");
						break;
					case "ScriptInit":
						e.Context.QueueTasks.Enqueue("ThrowInitParent");
						break;
					case "ThrowInitParent":
						break;
					case "SubProcess9":
						break;
					case "GridPageRefreshRowChild":
						e.Context.QueueTasks.Enqueue("ScriptGridPageRefreshRowChild");
						break;
					case "ScriptGridPageRefreshRowChild":
						break;
					case "SubProcess11":
						break;
					case "DataSourceLoadRowsResponseRegisteredChild":
						e.Context.QueueTasks.Enqueue("ThrowDataSourceLoadRowsResponseRegisteredParent");
						break;
					case "ScriptChildDataSourceLoadRowsResponseRegistered":
						break;
					case "ThrowDataSourceLoadRowsResponseRegisteredParent":
						e.Context.QueueTasks.Enqueue("ScriptChildDataSourceLoadRowsResponseRegistered");
						break;
					case "SubProcess13":
						break;
					case "DeleteButtonClickChild":
						e.Context.QueueTasks.Enqueue("ScriptScriptDeleteButtonClickChildBefore");
						break;
					case "ScriptDeleteButtonClickChild":
						break;
					case "ThrowDeleteButtonClickParent":
						break;
					case "ScriptScriptDeleteButtonClickChildBefore":
						if (ConditionalFlow249ExpressionExecute()) {
						e.Context.QueueTasks.Enqueue("DenyDeleteRootRecord");
							break;
						}
						if (ConditionalFlow250ExpressionExecute()) {
						e.Context.QueueTasks.Enqueue("ThrowDeleteButtonClickParent");
							break;
						}
						break;
					case "DenyDeleteRootRecord":
						break;
					case "StartChildDataSourceRemoved":
						e.Context.QueueTasks.Enqueue("IntermediateThrowDataSourceRemoved");
						break;
					case "IntermediateThrowDataSourceRemoved":
						e.Context.QueueTasks.Enqueue("ScriptDeleteButtonClickChild");
						break;
					case "SubProcess10":
						break;
					case "PageLoadCompleteChild":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadCompleteChild");
						break;
					case "ScriptPageLoadCompleteChild":
						e.Context.QueueTasks.Enqueue("ThrowPageLoadCompleteParent");
						break;
					case "ThrowPageLoadCompleteParent":
						break;
					case "SubProcess12":
						break;
					case "ApplyFolderFilterChild":
						e.Context.QueueTasks.Enqueue("ScriptApplyFolderFilterChild");
						break;
					case "ScriptApplyFolderFilterChild":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow249ExpressionExecute() {
			return Convert.ToBoolean(!DoDeleteRecord);
		}

		private bool ConditionalFlow250ExpressionExecute() {
			return Convert.ToBoolean(DoDeleteRecord);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("DataSourceBeforeLoadMessage");
			ActivatedEventElements.Add("DataSourceLoadedMessage");
			ActivatedEventElements.Add("InitMessage");
			ActivatedEventElements.Add("GridPageRefreshRowChild");
			ActivatedEventElements.Add("DataSourceLoadRowsResponseRegisteredChild");
			ActivatedEventElements.Add("DeleteButtonClickChild");
			ActivatedEventElements.Add("StartChildDataSourceRemoved");
			ActivatedEventElements.Add("PageLoadCompleteChild");
			ActivatedEventElements.Add("ApplyFolderFilterChild");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcessDataSourceBeforeLoad":
					context.QueueTasks.Dequeue();
					break;
				case "DataSourceBeforeLoadMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceBeforeLoadMessage";
					result = DataSourceBeforeLoadMessage.Execute(context);
					break;
				case "ScriptDataSourceBeforeLoad":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDataSourceBeforeLoad";
					result = ScriptDataSourceBeforeLoad.Execute(context, ScriptDataSourceBeforeLoadExecute);
					break;
				case "SubProcessDataSourceLoaded":
					context.QueueTasks.Dequeue();
					break;
				case "DataSourceLoadedMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceLoadedMessage";
					result = DataSourceLoadedMessage.Execute(context);
					break;
				case "ScriptDataSourceLoaded":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDataSourceLoaded";
					result = ScriptDataSourceLoaded.Execute(context, ScriptDataSourceLoadedExecute);
					break;
				case "SubProcessInit":
					context.QueueTasks.Dequeue();
					break;
				case "InitMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitMessage";
					result = InitMessage.Execute(context);
					break;
				case "ScriptInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptInit";
					result = ScriptInit.Execute(context, ScriptInitExecute);
					break;
				case "ThrowInitParent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = ThrowInitParent.Execute(context);
					break;
				case "SubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "GridPageRefreshRowChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "GridPageRefreshRowChild";
					result = GridPageRefreshRowChild.Execute(context);
					break;
				case "ScriptGridPageRefreshRowChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptGridPageRefreshRowChild";
					result = ScriptGridPageRefreshRowChild.Execute(context, ScriptGridPageRefreshRowChildExecute);
					break;
				case "SubProcess11":
					context.QueueTasks.Dequeue();
					break;
				case "DataSourceLoadRowsResponseRegisteredChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceLoadRowsResponseRegisteredChild";
					result = DataSourceLoadRowsResponseRegisteredChild.Execute(context);
					break;
				case "ScriptChildDataSourceLoadRowsResponseRegistered":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildDataSourceLoadRowsResponseRegistered";
					result = ScriptChildDataSourceLoadRowsResponseRegistered.Execute(context, ScriptChildDataSourceLoadRowsResponseRegisteredExecute);
					break;
				case "ThrowDataSourceLoadRowsResponseRegisteredParent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DataSourceLoadRowsResponseRegistered");
					result = ThrowDataSourceLoadRowsResponseRegisteredParent.Execute(context);
					break;
				case "SubProcess13":
					context.QueueTasks.Dequeue();
					break;
				case "DeleteButtonClickChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteButtonClickChild";
					result = DeleteButtonClickChild.Execute(context);
					break;
				case "ScriptDeleteButtonClickChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDeleteButtonClickChild";
					result = ScriptDeleteButtonClickChild.Execute(context, ScriptDeleteButtonClickChildExecute);
					break;
				case "ThrowDeleteButtonClickParent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DeleteButtonClick");
					result = ThrowDeleteButtonClickParent.Execute(context);
					break;
				case "ScriptScriptDeleteButtonClickChildBefore":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptScriptDeleteButtonClickChildBefore";
					result = ScriptScriptDeleteButtonClickChildBefore.Execute(context, ScriptScriptDeleteButtonClickChildBeforeExecute);
					break;
				case "DenyDeleteRootRecord":
					context.QueueTasks.Dequeue();
					context.SenderName = "DenyDeleteRootRecord";
					result = DenyDeleteRootRecord.Execute(context);
					break;
				case "StartChildDataSourceRemoved":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartChildDataSourceRemoved";
					result = StartChildDataSourceRemoved.Execute(context);
					break;
				case "IntermediateThrowDataSourceRemoved":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DataSourceRemoved");
					result = IntermediateThrowDataSourceRemoved.Execute(context);
					break;
				case "SubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteChild";
					result = PageLoadCompleteChild.Execute(context);
					break;
				case "ScriptPageLoadCompleteChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPageLoadCompleteChild";
					result = ScriptPageLoadCompleteChild.Execute(context, ScriptPageLoadCompleteChildExecute);
					break;
				case "ThrowPageLoadCompleteParent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = ThrowPageLoadCompleteParent.Execute(context);
					break;
				case "SubProcess12":
					context.QueueTasks.Dequeue();
					break;
				case "ApplyFolderFilterChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ApplyFolderFilterChild";
					result = ApplyFolderFilterChild.Execute(context);
					break;
				case "ScriptApplyFolderFilterChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptApplyFolderFilterChild";
					result = ScriptApplyFolderFilterChild.Execute(context, ScriptApplyFolderFilterChildExecute);
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
				case "ParentRoleId":
					ParentRoleId = reader.GetValue<System.Guid>();
				break;
				case "DoDeleteRecord":
					DoDeleteRecord = reader.GetValue<System.Boolean>();
				break;
				case "AddElementId":
					AddElementId = reader.GetValue<System.Guid>();
				break;
				case "AvailableForAddSysAdminUnitType":
					AvailableForAddSysAdminUnitType = reader.GetValue<System.Guid>();
				break;
				case "EntitySchemaHierarchyColumnUId":
					EntitySchemaHierarchyColumnUId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptDataSourceBeforeLoadExecute(ProcessExecutingContext context) {
			this.Page.TreeGrid.GetRowConfigHandler =
			 delegate(Terrasoft.Core.Entities.Entity row) {
			   string primaryColumnName = row.Schema.PrimaryColumn.Name;
			   string primaryColumnValue = row.GetColumnValue(primaryColumnName).ToString();
			   var config = new DataSourceRowConfig(primaryColumnValue);
			   string imageName = "organization.png";
				var sysAdminUnitTypeId = row.GetTypedColumnValue<Guid>("SysAdminUnitTypeId");
				if (sysAdminUnitTypeId == new Guid("462E97C7-6BD7-DF11-9B2A-001D60E938C6")) { // Team
					imageName = "team.png";
				} else if (sysAdminUnitTypeId == new Guid("B759F1C0-6BD7-DF11-9B2A-001D60E938C6")) { // Chief
					imageName = "chief.png";
				} else if (sysAdminUnitTypeId == new Guid("B659F1C0-6BD7-DF11-9B2A-001D60E938C6")) { // Department
					imageName = "department.png";
				}
				Dictionary<string, ImageConfigValue> icons = new Dictionary<string, ImageConfigValue>();
				icons.Add("Name", new ImageConfigValue(imageName));
				config.AddConfig(new DataSourceRowColumnIconsConfigValue(icons));
			   // config.AddConfig(new ImageConfigValue(imageName));
			   return config;
			};
			Page.DataSource.CurrentStructure.IsHierarchical = false;
			this.Page.DataSource.Loaded += this.Page.TreeGrid.DataLoaded;
			return true;
		}

		public virtual bool ScriptDataSourceLoadedExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ScriptInitExecute(ProcessExecutingContext context) {
			Page.DataSource.CurrentStructure.IsHierarchical = false;
			return true;
		}

		public virtual bool ScriptGridPageRefreshRowChildExecute(ProcessExecutingContext context) {
			if (IsDetailGrid) {
				var buttonsControlLayout = Page.ButtonsControlLayout;
				if (buttonsControlLayout != null) {
					var grid = (Page.PageContainer.Parent.NamingContainer as PageContainer).FindPageControlByName("Grid");//(ListenerPage as PageSchemaUserControl).PageContainer.FindPageControlByName("Grid");
					foreach(var button in buttonsControlLayout.Items) {
						button.Enabled =
							(SelectedNodePrimaryColumnValue != null && !SelectedNodePrimaryColumnValue.Equals(Guid.Empty));
					}
				}
			}
			var dataSource = Page.DataSource;
			var currentStructure = dataSource.CurrentStructure;
			var detailFilters = currentStructure.Filters.FindByName("DetailFilter");
			if (detailFilters != null) {
				currentStructure.Filters.Remove(detailFilters);
			}
			var searchFilters = currentStructure.Filters.FindByName("SearchFilter");
			if (searchFilters != null) {
				currentStructure.Filters.Remove(searchFilters);
			}
			var folderFilters = currentStructure.Filters.FindByName("FolderFilter");
			if (folderFilters != null) {
				currentStructure.Filters.Remove(folderFilters);
			}
			if(DataSourceFilter != null){
				currentStructure.Filters.Add((Terrasoft.UI.WebControls.Controls.IDataSourceFilterItem) DataSourceFilter);
			}
			DataSourceFilter = null;
			var treeGrid = Page.TreeGrid;
			treeGrid.Clear();
			dataSource.CurrentStructure.Filters.Add(dataSource.CreateFilterWithParameters(FilterComparisonType.Less, "SysAdminUnitType.Value", (int)Terrasoft.Core.DB.SysAdminUnitType.User));
			dataSource.LoadRows();
			return true;
		}

		public virtual bool ScriptChildDataSourceLoadRowsResponseRegisteredExecute(ProcessExecutingContext context) {
			if (Page.DataSource.ActiveRowPrimaryColumnValue != Guid.Empty) {
				SetEditPageUId(Page.DataSource.ActiveRow.GetTypedColumnValue<Guid>("SysAdminUnitTypeId"));
			}
			var sysAdminUnitTypeId = Guid.Empty;
			var sysAdminUnitParentRoleId = (Guid)GetListenerProcessPropertyValue(ListenerPageProcessUId, "ParentRoleId");
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var query = new EntitySchemaQuery(entitySchemaManager, "VwSysAdminUnit");
			var typeColumnName = query.AddColumn("SysAdminUnitType.Id").Name;
			query.Filters.Add(query.CreateFilterWithParameters(
				FilterComparisonType.Equal, "Id", sysAdminUnitParentRoleId));
			var entities = query.GetEntityCollection(UserConnection);
			if (entities.Count > 0) {
				sysAdminUnitTypeId = entities[0].GetTypedColumnValue<Guid>(typeColumnName);
			}
			var hasUnitChief = HasUnitChief(sysAdminUnitParentRoleId);
			var buttonMenu = Page.AddButton.Menu;
			var organizationMenuItem = buttonMenu.Find(item => item.Name.Contains(new Guid("DF93DCB9-6BD7-DF11-9B2A-001D60E938C6").ToString("N")));
			var unitMenuItem = buttonMenu.Find(item => item.Name.Contains(new Guid("B659F1C0-6BD7-DF11-9B2A-001D60E938C6").ToString("N")));
			var chiefMenuItem = buttonMenu.Find(item => item.Name.Contains(new Guid("B759F1C0-6BD7-DF11-9B2A-001D60E938C6").ToString("N")));
			var teamMenuItem = buttonMenu.Find(item => item.Name.Contains(new Guid("462E97C7-6BD7-DF11-9B2A-001D60E938C6").ToString("N")));
			AvailableForAddSysAdminUnitType = Guid.Empty;
			if (sysAdminUnitTypeId == new Guid("DF93DCB9-6BD7-DF11-9B2A-001D60E938C6")) { // Организация
				AvailableForAddSysAdminUnitType = new Guid("DF93DCB9-6BD7-DF11-9B2A-001D60E938C6");
				organizationMenuItem.Enabled = true;
				unitMenuItem.Enabled = true;
				chiefMenuItem.Enabled = !hasUnitChief;
				teamMenuItem.Enabled = true;
			} else if (sysAdminUnitTypeId == new Guid("B659F1C0-6BD7-DF11-9B2A-001D60E938C6")) { // Подразделение
				//Page.AddButton.Enabled =
				AvailableForAddSysAdminUnitType = new Guid("B659F1C0-6BD7-DF11-9B2A-001D60E938C6");
				organizationMenuItem.Enabled = false;
				unitMenuItem.Enabled = true;
				chiefMenuItem.Enabled = !hasUnitChief;
				teamMenuItem.Enabled = true;
			} else if (sysAdminUnitTypeId == new Guid("B759F1C0-6BD7-DF11-9B2A-001D60E938C6")) { // Руководитель
				organizationMenuItem.Enabled = false;
				unitMenuItem.Enabled = false;
				chiefMenuItem.Enabled = false;
				teamMenuItem.Enabled = false;
			} else if (sysAdminUnitTypeId == new Guid("462E97C7-6BD7-DF11-9B2A-001D60E938C6")) { // Команда
				//Page.AddButton.Enabled =
				organizationMenuItem.Enabled = false;
				unitMenuItem.Enabled = false;
				chiefMenuItem.Enabled = !hasUnitChief;
				teamMenuItem.Enabled = false;
				if (!hasUnitChief) {
					AvailableForAddSysAdminUnitType = new Guid("B759F1C0-6BD7-DF11-9B2A-001D60E938C6");
				}
			}
			Page.AddButton.Enabled = organizationMenuItem.Enabled || unitMenuItem.Enabled || chiefMenuItem.Enabled || teamMenuItem.Enabled;
			return true;
		}

		public virtual bool ScriptDeleteButtonClickChildExecute(ProcessExecutingContext context) {
			if (SelectedNodePrimaryColumnValue != Guid.Empty) {
				var listenerPage = (Page.PageContainer.Parent.NamingContainer as PageContainer).PageInstance as Terrasoft.WebApp.BaseModulePageSchemaUserControl;//ListenerPage as Terrasoft.WebApp.BaseModulePageSchemaUserControl;
				var pageContainer = listenerPage.BaseFolder as PageContainer;
				var dataSource = pageContainer.FindPageControlByName("DataSource") as DataSource;
				dataSource.Remove(SelectedNodePrimaryColumnValue);
			}
			SelectedNodePrimaryColumnValue = Guid.Empty;
			return true;
		}

		public virtual bool ScriptScriptDeleteButtonClickChildBeforeExecute(ProcessExecutingContext context) {
			DoDeleteRecord = true;
			var activeRow = Page.DataSource.ActiveRow;
			var organizationTypeId = new Guid("DF93DCB9-6BD7-DF11-9B2A-001D60E938C6");
			Guid typeId = activeRow.GetTypedColumnValue<Guid>("SysAdminUnitTypeId");
			Guid parentId = activeRow.GetTypedColumnValue<Guid>(Page.DataSource.Schema.HierarchyColumn.ColumnValueName);
			if (typeId.Equals(organizationTypeId) && parentId == Guid.Empty) {
				DoDeleteRecord = false;
				DenyDeleteRootRecord.MessageText = DenyDeletRootRecord;
				DenyDeleteRootRecord.Caption = Warning;
				DenyDeleteRootRecord.Page = Page;
			}
			return true;
		}

		public virtual bool ScriptPageLoadCompleteChildExecute(ProcessExecutingContext context) {
			Page.DataSource.EnableServerActiveRow = true;
			EditPageUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
			Page.TreeGrid.ImageList = "Terrasoft.WebApp";
			return true;
		}

		public virtual bool ScriptApplyFolderFilterChildExecute(ProcessExecutingContext context) {
			var listenerPage = (Page.PageContainer.Parent.NamingContainer as PageContainer).PageInstance as Terrasoft.WebApp.BaseModulePageSchemaUserControl;//ListenerPage as Terrasoft.WebApp.BaseModulePageSchemaUserControl;
			var dataSource = Page.DataSource;
			var currentStructure = dataSource.CurrentStructure;
			var dataSourceFilter = (Terrasoft.UI.WebControls.Controls.IDataSourceFilterItem) DataSourceFilter;
			if(!object.ReferenceEquals(DataSourceFilter, null)) {
				for(int i = 0; i < currentStructure.Filters.Count; i++) {
					if(currentStructure.Filters[i].Name.Equals(dataSourceFilter.Name)) {
						currentStructure.Filters[i] = dataSourceFilter;
					}
				}
				if(!currentStructure.Filters.Contains(dataSourceFilter)) {
					currentStructure.Filters.Add(dataSourceFilter);
				}
				foreach (var filter in currentStructure.Filters) {
					if(!filter.Name.Equals("SearchFilter")) {	
						filter.IsEnabled = !IsSearch;
					}
				}
			} else {
				if(currentStructure.Filters.Count > 0) {
					var filters = new List<IDataSourceFilterItem>();
					foreach (var filter in currentStructure.Filters) {
						if(!filter.Name.Equals("SearchFilter")) {					
							filter.IsEnabled = !IsSearch;
						}
						if(filter.Name.Equals("FolderFilter")) {					
							filters.Add(filter);
						}			
					}
					foreach (var filter in filters) {
						currentStructure.Filters.Remove(filter);
					}
				}
			}
			currentStructure.Filters.Add(dataSource.CreateFilterWithParameters(FilterComparisonType.Less, "SysAdminUnitType.Value", (int)Terrasoft.Core.DB.SysAdminUnitType.User));
			Page.TreeGrid.Clear();
			dataSource.LoadRows();
			var detailsTabPanel = listenerPage.DetailsTabPanel;
			if(detailsTabPanel.Tabs.Count == 0) {
				return true;
			}
			var activeTab = detailsTabPanel.Tabs[detailsTabPanel.ActiveTabIndex];
			if (activeTab.Items.Count == 0) {
				return true;
			}
			var detailPageContainer = activeTab.Items[0] as PageControl;
			var detailDataSource = (detailPageContainer.FindPageControlByName("DataSource")) as DataSource;
			Guid filterColumnValue = Guid.Empty;
			if(dataSource.Rows.Count != 0) {
				var primaryColumnName = dataSource.Schema.PrimaryColumn.Name;
				filterColumnValue = new Guid(dataSource.Rows[0].GetColumnValue(primaryColumnName).ToString());
			}
			ListenerProcessSetProperty(ListenerPageProcessUId, "FilterColumnValue", filterColumnValue);
			ListenerThrowEvent(ListenerPageProcessUId, "RefreshDetails");
			return true;
		}

		public virtual void SetDefValuesForAddAdministrativeUnit(Guid SysAdminUnitTypeId) {
			if (DefValuesId.IsEmpty()) {
				DefValuesId = Guid.NewGuid();
				UserConnection.SessionData[DefValuesId.ToString()] = new Dictionary<string, object>();
			}
			var defValues = UserConnection.SessionData[DefValuesId.ToString()] as Dictionary<string, object>;
			var selectedNodes = Page.TreeGrid.SelectedNodes;
			if (selectedNodes.Count > 0) {
				defValues["ParentRole"] = selectedNodes[0].Values[Page.DataSource.Schema.GetPrimaryColumnName()];
			}
			defValues["SysAdminUnitType"] = SysAdminUnitTypeId;
			defValues["UserPassword"] = null;
			UserConnection.SessionData[DefValuesId.ToString()] = defValues;
		}

		public virtual bool HasUnitChief(Guid UnitUId) {
			var selectCount = new Terrasoft.Core.DB.Select(Page.UserConnection)
					.Column(Terrasoft.Core.DB.Func.Count(Terrasoft.Core.DB.Column.Asterisk()))
				.From("SysAdminUnit")
				.Where("SysAdminUnitTypeValue").IsEqual(Terrasoft.Core.DB.Column.Parameter(2))
				.And("ParentRoleId").IsEqual(Terrasoft.Core.DB.Column.Parameter(UnitUId)) as Terrasoft.Core.DB.Select;
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (var reader = selectCount.ExecuteReader(dbExecutor)) {
					if (reader.Read()) {
						return UserConnection.DBTypeConverter.DBValueToInt(reader[0]) > 0;
					}
				}
			}
			return false;
		}

		public virtual void SetEditPageUId(Guid SysAdminUnitUId) {
			if (SysAdminUnitUId == new Guid("df93dcb9-6bd7-df11-9b2a-001d60e938c6")) {
				//Organization
				EditPageUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
			} else if (SysAdminUnitUId == new Guid("b659f1c0-6bd7-df11-9b2a-001d60e938c6")) {
				// Department
				EditPageUId = new Guid("921acc0b-bc2d-4d46-8422-3a3cd2c99b79");
			} else if (SysAdminUnitUId == new Guid("b759f1c0-6bd7-df11-9b2a-001d60e938c6")) {
				// Chief
				EditPageUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
			} else {
				// Team (462e97c7-6bd7-df11-9b2a-001d60e938c6)
				EditPageUId = new Guid("5cc6b39d-d152-4768-91d7-ed417fca9073");
			}
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public override void ModifyAddPageParameters(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters) {
			var listenerPage = (Page.PageContainer.Parent.NamingContainer as PageContainer).PageInstance as Terrasoft.WebApp.BaseModulePageSchemaUserControl;
			var pageInstance = listenerPage.BaseFolder.PageInstance as Terrasoft.WebApp.BaseModuleFoldersPageSchemaUserControl;
			queryStringParameters["additionalTreeGrid"] = pageInstance.TreeGrid.ClientID;
			string selectedParentId = "Ext.decode(Ext.get('customDataField').dom.value)['SysModule_selectedParentRoleId']";
			queryStringParameters["ParentRole"] = selectedParentId;
		}

		public override void ModifyEditPageParameters(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters) {
			var listenerPage = (Page.PageContainer.Parent.NamingContainer as PageContainer).PageInstance as Terrasoft.WebApp.BaseModulePageSchemaUserControl;
			var pageInstance = listenerPage.Grid.PageInstance as Terrasoft.WebApp.BaseGridPageSchemaUserControl;
			queryStringParameters["additionalTreeGrid"] = pageInstance.TreeGrid.ClientID;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "DataSourceBeforeLoad":
							if (ActivatedEventElements.Contains("DataSourceBeforeLoadMessage")) {
							context.QueueTasks.Enqueue("DataSourceBeforeLoadMessage");
						}
						break;
					case "DataSourceLoaded":
							if (ActivatedEventElements.Contains("DataSourceLoadedMessage")) {
							context.QueueTasks.Enqueue("DataSourceLoadedMessage");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("InitMessage")) {
							context.QueueTasks.Enqueue("InitMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "GridPageRefreshRow":
							if (ActivatedEventElements.Contains("GridPageRefreshRowChild")) {
							context.QueueTasks.Enqueue("GridPageRefreshRowChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "DataSourceLoadRowsResponseRegistered":
							if (ActivatedEventElements.Contains("DataSourceLoadRowsResponseRegisteredChild")) {
							context.QueueTasks.Enqueue("DataSourceLoadRowsResponseRegisteredChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "DeleteButtonClick":
							if (ActivatedEventElements.Contains("DeleteButtonClickChild")) {
							context.QueueTasks.Enqueue("DeleteButtonClickChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "DataSourceRemoved":
							if (ActivatedEventElements.Contains("StartChildDataSourceRemoved")) {
							context.QueueTasks.Enqueue("StartChildDataSourceRemoved");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteChild")) {
							context.QueueTasks.Enqueue("PageLoadCompleteChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "ApplyFolderFilter":
							if (ActivatedEventElements.Contains("ApplyFolderFilterChild")) {
							context.QueueTasks.Enqueue("ApplyFolderFilterChild");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("ParentRoleId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ParentRoleId", ParentRoleId, Guid.Empty);
			}
			if (!HasMapping("DoDeleteRecord") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DoDeleteRecord", DoDeleteRecord, false);
			}
			if (!HasMapping("AddElementId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("AddElementId", AddElementId, Guid.Empty);
			}
			if (!HasMapping("AvailableForAddSysAdminUnitType") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("AvailableForAddSysAdminUnitType", AvailableForAddSysAdminUnitType, Guid.Empty);
			}
			if (!HasMapping("EntitySchemaHierarchyColumnUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntitySchemaHierarchyColumnUId", EntitySchemaHierarchyColumnUId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: AdministrationUnitsGridPageEventsProcess

	/// <exclude/>
	public class AdministrationUnitsGridPageEventsProcess : AdministrationUnitsGridPageEventsProcess<Terrasoft.WebApp.AdministrationUnitsGridPageSchemaUserControl>
	{

		public AdministrationUnitsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdministrationUnitsGridPageSchemaUserControl

	/// <exclude/>
	public partial class AdministrationUnitsGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			DataSource.BeforeLoad += DataSourceBeforeLoad;
			DataSource.Loaded += DataSourceLoaded;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			DataSource.BeforeLoad -= DataSourceBeforeLoad;
			DataSource.Loaded -= DataSourceLoaded;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (AdministrationUnitsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AdministrationUnitsGridPageEventsProcess(UserConnection);
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

		public virtual void DataSourceBeforeLoad(object sender, EventArgs e) {
			object result = ThrowEvent("DataSourceBeforeLoad");
		}

		public virtual void DataSourceLoaded(object sender, EventArgs e) {
			object result = ThrowEvent("DataSourceLoaded");
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
			SchemaName = "AdministrationUnitsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: AdministrationUnitsGridPageEventsProcessSchema

	/// <exclude/>
	public class AdministrationUnitsGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public AdministrationUnitsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AdministrationUnitsGridPageEventsProcessSchema(AdministrationUnitsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AdministrationUnitsGridPageEventsProcess";
			UId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699");
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

		protected virtual ProcessSchemaParameter CreateEntitySchemaHierarchyColumnUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2c03e0fc-a3fe-4f08-b613-7d2711b061b6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"EntitySchemaHierarchyColumnUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateAvailableForAddSysAdminUnitTypeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d11cf58a-6f87-4377-b894-a1999689cbe8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"AvailableForAddSysAdminUnitType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateAddElementIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1ba1a81c-7eb9-4040-86cb-9edaf371ffb0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"AddElementId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDoDeleteRecordParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6ff9ae3b-452e-4b54-9c9f-2c0f90c158f2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"DoDeleteRecord",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParentRoleIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b66994f5-f07b-48b4-98af-2733c797dca0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"ParentRoleId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEntitySchemaHierarchyColumnUIdParameter());
			Parameters.Add(CreateAvailableForAddSysAdminUnitTypeParameter());
			Parameters.Add(CreateAddElementIdParameter());
			Parameters.Add(CreateDoDeleteRecordParameter());
			Parameters.Add(CreateParentRoleIdParameter());
		}

		protected virtual void InitializeDenyDeleteRootRecordParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("8dcfb292-cd85-427a-b3b2-acf22a2c6475"),
				ContainerUId = new Guid("7e57ce12-11fd-4b10-8c1f-5d28754412fd"),
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
				UId = new Guid("96a787ca-f28b-4383-98e9-4462d4ff58c9"),
				ContainerUId = new Guid("7e57ce12-11fd-4b10-8c1f-5d28754412fd"),
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
				UId = new Guid("40d131f7-d159-4f35-b833-f17968c926f5"),
				ContainerUId = new Guid("7e57ce12-11fd-4b10-8c1f-5d28754412fd"),
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
				UId = new Guid("66d1369f-7e8c-4d6b-8e66-3926f7d16298"),
				ContainerUId = new Guid("7e57ce12-11fd-4b10-8c1f-5d28754412fd"),
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
				UId = new Guid("4093cf3e-29a1-4fd1-82e6-9d149b3c1468"),
				ContainerUId = new Guid("7e57ce12-11fd-4b10-8c1f-5d28754412fd"),
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
				UId = new Guid("fc605026-6507-4061-a044-f9029650b790"),
				ContainerUId = new Guid("7e57ce12-11fd-4b10-8c1f-5d28754412fd"),
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
				UId = new Guid("094303d8-855d-4093-9ced-85aea78d9f77"),
				ContainerUId = new Guid("7e57ce12-11fd-4b10-8c1f-5d28754412fd"),
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
				UId = new Guid("8b86ac39-25e7-4abc-a5fd-8592e8951dd1"),
				ContainerUId = new Guid("7e57ce12-11fd-4b10-8c1f-5d28754412fd"),
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
			ProcessSchemaLaneSet schemaLaneSet502 = CreateLaneSet502LaneSet();
			LaneSets.Add(schemaLaneSet502);
			ProcessSchemaLane schemaLane1665 = CreateLane1665Lane();
			schemaLaneSet502.Lanes.Add(schemaLane1665);
			ProcessSchemaLane schemaLane1666 = CreateLane1666Lane();
			schemaLaneSet502.Lanes.Add(schemaLane1666);
			ProcessSchemaLane schemaLane1667 = CreateLane1667Lane();
			schemaLaneSet502.Lanes.Add(schemaLane1667);
			ProcessSchemaEventSubProcess subprocessdatasourcebeforeload = CreateSubProcessDataSourceBeforeLoadEventSubProcess();
			FlowElements.Add(subprocessdatasourcebeforeload);
			ProcessSchemaEventSubProcess subprocessdatasourceloaded = CreateSubProcessDataSourceLoadedEventSubProcess();
			FlowElements.Add(subprocessdatasourceloaded);
			ProcessSchemaEventSubProcess subprocessinit = CreateSubProcessInitEventSubProcess();
			FlowElements.Add(subprocessinit);
			ProcessSchemaEventSubProcess subprocess9 = CreateSubProcess9EventSubProcess();
			FlowElements.Add(subprocess9);
			ProcessSchemaEventSubProcess subprocess11 = CreateSubProcess11EventSubProcess();
			FlowElements.Add(subprocess11);
			ProcessSchemaEventSubProcess subprocess13 = CreateSubProcess13EventSubProcess();
			FlowElements.Add(subprocess13);
			ProcessSchemaEventSubProcess subprocess10 = CreateSubProcess10EventSubProcess();
			FlowElements.Add(subprocess10);
			ProcessSchemaEventSubProcess subprocess12 = CreateSubProcess12EventSubProcess();
			FlowElements.Add(subprocess12);
			ProcessSchemaStartMessageEvent datasourcebeforeloadmessage = CreateDataSourceBeforeLoadMessageStartMessageEvent();
			subprocessdatasourcebeforeload.FlowElements.Add(datasourcebeforeloadmessage);
			ProcessSchemaScriptTask scriptdatasourcebeforeload = CreateScriptDataSourceBeforeLoadScriptTask();
			subprocessdatasourcebeforeload.FlowElements.Add(scriptdatasourcebeforeload);
			ProcessSchemaStartMessageEvent datasourceloadedmessage = CreateDataSourceLoadedMessageStartMessageEvent();
			subprocessdatasourceloaded.FlowElements.Add(datasourceloadedmessage);
			ProcessSchemaScriptTask scriptdatasourceloaded = CreateScriptDataSourceLoadedScriptTask();
			subprocessdatasourceloaded.FlowElements.Add(scriptdatasourceloaded);
			ProcessSchemaStartMessageEvent initmessage = CreateInitMessageStartMessageEvent();
			subprocessinit.FlowElements.Add(initmessage);
			ProcessSchemaScriptTask scriptinit = CreateScriptInitScriptTask();
			subprocessinit.FlowElements.Add(scriptinit);
			ProcessSchemaIntermediateThrowMessageEvent throwinitparent = CreateThrowInitParentIntermediateThrowMessageEvent();
			subprocessinit.FlowElements.Add(throwinitparent);
			ProcessSchemaStartMessageEvent gridpagerefreshrowchild = CreateGridPageRefreshRowChildStartMessageEvent();
			subprocess9.FlowElements.Add(gridpagerefreshrowchild);
			ProcessSchemaScriptTask scriptgridpagerefreshrowchild = CreateScriptGridPageRefreshRowChildScriptTask();
			subprocess9.FlowElements.Add(scriptgridpagerefreshrowchild);
			ProcessSchemaStartMessageEvent datasourceloadrowsresponseregisteredchild = CreateDataSourceLoadRowsResponseRegisteredChildStartMessageEvent();
			subprocess11.FlowElements.Add(datasourceloadrowsresponseregisteredchild);
			ProcessSchemaScriptTask scriptchilddatasourceloadrowsresponseregistered = CreateScriptChildDataSourceLoadRowsResponseRegisteredScriptTask();
			subprocess11.FlowElements.Add(scriptchilddatasourceloadrowsresponseregistered);
			ProcessSchemaIntermediateThrowMessageEvent throwdatasourceloadrowsresponseregisteredparent = CreateThrowDataSourceLoadRowsResponseRegisteredParentIntermediateThrowMessageEvent();
			subprocess11.FlowElements.Add(throwdatasourceloadrowsresponseregisteredparent);
			ProcessSchemaStartMessageEvent deletebuttonclickchild = CreateDeleteButtonClickChildStartMessageEvent();
			subprocess13.FlowElements.Add(deletebuttonclickchild);
			ProcessSchemaScriptTask scriptdeletebuttonclickchild = CreateScriptDeleteButtonClickChildScriptTask();
			subprocess13.FlowElements.Add(scriptdeletebuttonclickchild);
			ProcessSchemaIntermediateThrowMessageEvent throwdeletebuttonclickparent = CreateThrowDeleteButtonClickParentIntermediateThrowMessageEvent();
			subprocess13.FlowElements.Add(throwdeletebuttonclickparent);
			ProcessSchemaScriptTask scriptscriptdeletebuttonclickchildbefore = CreateScriptScriptDeleteButtonClickChildBeforeScriptTask();
			subprocess13.FlowElements.Add(scriptscriptdeletebuttonclickchildbefore);
			ProcessSchemaUserTask denydeleterootrecord = CreateDenyDeleteRootRecordUserTask();
			subprocess13.FlowElements.Add(denydeleterootrecord);
			ProcessSchemaStartMessageEvent startchilddatasourceremoved = CreateStartChildDataSourceRemovedStartMessageEvent();
			subprocess13.FlowElements.Add(startchilddatasourceremoved);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowdatasourceremoved = CreateIntermediateThrowDataSourceRemovedIntermediateThrowMessageEvent();
			subprocess13.FlowElements.Add(intermediatethrowdatasourceremoved);
			ProcessSchemaStartMessageEvent pageloadcompletechild = CreatePageLoadCompleteChildStartMessageEvent();
			subprocess10.FlowElements.Add(pageloadcompletechild);
			ProcessSchemaScriptTask scriptpageloadcompletechild = CreateScriptPageLoadCompleteChildScriptTask();
			subprocess10.FlowElements.Add(scriptpageloadcompletechild);
			ProcessSchemaIntermediateThrowMessageEvent throwpageloadcompleteparent = CreateThrowPageLoadCompleteParentIntermediateThrowMessageEvent();
			subprocess10.FlowElements.Add(throwpageloadcompleteparent);
			ProcessSchemaStartMessageEvent applyfolderfilterchild = CreateApplyFolderFilterChildStartMessageEvent();
			subprocess12.FlowElements.Add(applyfolderfilterchild);
			ProcessSchemaScriptTask scriptapplyfolderfilterchild = CreateScriptApplyFolderFilterChildScriptTask();
			subprocess12.FlowElements.Add(scriptapplyfolderfilterchild);
			FlowElements.Add(CreateSequenceFlow9892SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9893SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9894SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9924SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9925SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9926SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9927SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9928SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9929SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9932SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9936SequenceFlow());
			FlowElements.Add(CreateConditionalFlow249ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow250ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow9940SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9941SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateDenyDeletRootRecordLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateDenyDeletRootRecordLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c58c51c3-b74d-455e-bc8c-f65486f689cd"),
				Name = "DenyDeletRootRecord",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9892SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9892",
				UId = new Guid("9dcc28f2-8473-4f14-aaad-6993411c59da"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6f9a43b7-8772-491c-9ca7-21095a78f001"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7e61051d-e0fa-4a8e-bf73-6a287910648c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9893SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9893",
				UId = new Guid("c45f5112-f737-404f-93ca-4af21e843bc9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6b401249-46db-4b65-8d17-42d71c7b9f09"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dfc2d046-a2e8-4bf4-aa3e-5109b09bc23a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9894SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9894",
				UId = new Guid("94599a80-1eb3-4e59-a8e3-7e3b3feee1ae"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				CurveCenterPosition = new Point(331, 1006),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a2e36889-5f4d-419c-a09c-03eeaed73699"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("234ff53e-23e0-4051-9a4e-a34585c29877"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9924SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9924",
				UId = new Guid("f1cbda43-847f-4631-af90-baead234fe89"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				CurveCenterPosition = new Point(422, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f9dbd54a-e20e-49d2-af1a-9b6f46d4526c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4800adf6-65dd-457d-84fe-849ff7975a71"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9925SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9925",
				UId = new Guid("0a7cb4ba-b49b-4e1c-b076-f40a6427a639"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				CurveCenterPosition = new Point(635, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dd2ea106-66bd-4852-9510-5c886a10a75f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("469e3251-3d92-4153-b737-c8bb91bd684b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9926SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9926",
				UId = new Guid("104011be-cd29-4fcd-a13e-f5ee2b968981"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				CurveCenterPosition = new Point(740, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("469e3251-3d92-4153-b737-c8bb91bd684b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dbcb519c-8168-465a-bc64-ec8c1940a52f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9927SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9927",
				UId = new Guid("35900951-447f-4646-9422-b09d88b6a33e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				CurveCenterPosition = new Point(636, 262),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4091e0ff-21a4-4033-9e26-f41bb817a547"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b746701a-0a60-40c0-954c-bbc7e86d1397"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9928SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9928",
				UId = new Guid("6d4c3491-6528-40d2-95be-52addb39881e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				CurveCenterPosition = new Point(636, 262),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3dfc1f3a-62de-4264-9f97-d23f3e404728"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4091e0ff-21a4-4033-9e26-f41bb817a547"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9929SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9929",
				UId = new Guid("e67f0965-76c7-44c4-a898-6e028bf9b87c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				CurveCenterPosition = new Point(138, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ab2a712a-f489-4e98-91a1-7bcf646462da"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ce496dad-7603-40fe-87c6-475f9784e602"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9932SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9932",
				UId = new Guid("6814fbf8-200b-449d-8338-f5662fdcb408"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				CurveCenterPosition = new Point(468, 377),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("234ff53e-23e0-4051-9a4e-a34585c29877"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("65971a5b-50b0-47ae-af78-193223ed87da"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9936SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9936",
				UId = new Guid("a96edc0b-352f-4410-872b-00aabe2b0587"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				CurveCenterPosition = new Point(336, 72),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5c070686-44d0-4cbe-ba17-e527cfec5ccb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d67a8286-282c-4e6a-ad65-b8a7d41b17ea"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow249ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow249",
				UId = new Guid("99ffe649-8972-491f-ada9-22f0419c8728"),
				ConditionExpression = @"!DoDeleteRecord",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				CurveCenterPosition = new Point(198, 294),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d67a8286-282c-4e6a-ad65-b8a7d41b17ea"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7e57ce12-11fd-4b10-8c1f-5d28754412fd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow250ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow250",
				UId = new Guid("9c0e3826-f207-45a5-9c3d-ddcba93f243c"),
				ConditionExpression = @"DoDeleteRecord",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				CurveCenterPosition = new Point(270, 226),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d67a8286-282c-4e6a-ad65-b8a7d41b17ea"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c582aa6b-3f06-4770-bc1a-1778a5496fc4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9940SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9940",
				UId = new Guid("d0e6284c-e495-4355-82a6-c7d6d3afad8b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				CurveCenterPosition = new Point(394, 337),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ea3aeee9-5703-4951-9216-fc0d696fba52"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("83240534-e533-4db2-b90d-db6780033feb"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9941SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9941",
				UId = new Guid("2a1464b6-9a2a-4de7-99e1-364596793534"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				CurveCenterPosition = new Point(444, 290),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("83240534-e533-4db2-b90d-db6780033feb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("99b04025-f973-48ec-912e-5401be227345"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet502LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet502 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("d4b5a2a9-6759-4765-ba0e-969158d5ddf4"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"LaneSet502",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(884, 571),
				UseBackgroundMode = false
			};
			return schemaLaneSet502;
		}

		protected virtual ProcessSchemaLane CreateLane1665Lane() {
			ProcessSchemaLane schemaLane1665 = new ProcessSchemaLane(this) {
				UId = new Guid("aecd67fe-86b2-49e1-9038-f2362ff6e026"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("d4b5a2a9-6759-4765-ba0e-969158d5ddf4"),
				CreatedInOwnerSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"Lane1665",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 151),
				Size = new Size(855, 259),
				UseBackgroundMode = false
			};
			return schemaLane1665;
		}

		protected virtual ProcessSchemaLane CreateLane1666Lane() {
			ProcessSchemaLane schemaLane1666 = new ProcessSchemaLane(this) {
				UId = new Guid("ba66d5af-b37e-40d2-9022-22b3155271ba"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("d4b5a2a9-6759-4765-ba0e-969158d5ddf4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"Lane1666",
				Position = new Point(29, 0),
				Size = new Size(855, 146),
				UseBackgroundMode = false
			};
			return schemaLane1666;
		}

		protected virtual ProcessSchemaLane CreateLane1667Lane() {
			ProcessSchemaLane schemaLane1667 = new ProcessSchemaLane(this) {
				UId = new Guid("4df43d5b-16bf-4e8e-96d8-b0cd89b8f83d"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("d4b5a2a9-6759-4765-ba0e-969158d5ddf4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"Lane1667",
				Position = new Point(29, 415),
				Size = new Size(855, 156),
				UseBackgroundMode = false
			};
			return schemaLane1667;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessDataSourceBeforeLoadEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessDataSourceBeforeLoad = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a738c919-d50e-4e67-8ad7-cbd8eb19a474"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4df43d5b-16bf-4e8e-96d8-b0cd89b8f83d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"SubProcessDataSourceBeforeLoad",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(201, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessDataSourceBeforeLoad;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceBeforeLoadMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6f9a43b7-8772-491c-9ca7-21095a78f001"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a738c919-d50e-4e67-8ad7-cbd8eb19a474"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DataSourceBeforeLoad",
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"DataSourceBeforeLoadMessage",
				Position = new Point(22, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDataSourceBeforeLoadScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7e61051d-e0fa-4a8e-bf73-6a287910648c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a738c919-d50e-4e67-8ad7-cbd8eb19a474"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"ScriptDataSourceBeforeLoad",
				Position = new Point(92, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,93,111,218,64,16,124,166,82,255,195,201,79,182,26,46,144,182,80,148,16,9,108,66,144,170,42,42,180,239,39,223,218,156,100,223,161,245,185,136,84,249,239,221,179,29,62,106,170,210,62,88,178,119,119,118,102,111,199,103,215,170,224,79,34,5,190,66,128,57,42,201,231,96,191,154,109,104,116,162,210,71,161,101,6,200,198,111,223,48,9,25,164,194,130,191,2,68,81,152,196,242,208,32,240,153,182,202,42,40,234,151,29,67,179,13,216,79,2,48,86,88,84,58,101,27,84,185,192,93,104,178,50,215,95,68,14,108,236,170,248,50,94,67,46,248,211,113,154,187,252,237,31,209,223,69,86,190,194,73,232,81,208,111,177,4,124,101,150,85,15,63,168,59,254,16,200,226,106,48,106,161,97,203,34,97,197,210,148,24,195,126,100,191,205,23,156,232,161,108,10,205,20,158,193,84,104,245,44,172,50,154,111,116,234,81,105,199,209,20,187,98,34,115,165,191,105,101,87,187,13,44,228,65,181,251,150,71,253,239,230,165,146,247,190,183,108,97,60,71,221,81,9,243,207,245,171,103,112,96,223,251,48,184,153,141,134,225,176,59,152,70,195,110,244,208,239,119,71,211,155,73,183,215,235,71,131,222,108,244,254,83,56,240,2,90,12,187,190,102,43,16,57,245,237,156,140,98,41,184,31,225,133,65,86,0,187,132,121,58,252,56,122,232,135,189,139,152,195,181,130,164,69,29,187,232,127,113,15,254,129,59,130,141,64,155,131,182,45,1,114,159,58,168,160,39,82,177,91,44,185,225,174,94,254,21,91,56,88,237,148,106,119,247,76,145,163,138,87,63,93,0,240,235,157,58,20,159,72,26,194,137,240,174,42,252,239,197,254,94,101,80,161,106,243,58,88,99,214,51,38,118,182,90,184,238,39,125,92,32,104,140,76,103,113,182,209,95,216,9,137,96,75,212,13,154,66,47,244,84,183,199,65,3,15,75,68,58,72,250,243,202,152,170,129,47,138,71,5,40,144,182,28,139,140,78,42,17,180,95,66,218,253,229,115,4,255,108,132,4,201,222,141,153,109,223,77,174,174,46,32,120,35,134,120,224,246,23,110,55,97,188,200,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessDataSourceLoadedEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessDataSourceLoaded = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7ff2a044-9d12-4d78-823c-809d4e7d1d7a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba66d5af-b37e-40d2-9022-22b3155271ba"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"SubProcessDataSourceLoaded",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(200, 123),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessDataSourceLoaded;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceLoadedMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6b401249-46db-4b65-8d17-42d71c7b9f09"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7ff2a044-9d12-4d78-823c-809d4e7d1d7a"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DataSourceLoaded",
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"DataSourceLoadedMessage",
				Position = new Point(22, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDataSourceLoadedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("dfc2d046-a2e8-4bf4-aa3e-5109b09bc23a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7ff2a044-9d12-4d78-823c-809d4e7d1d7a"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"ScriptDataSourceLoaded",
				Position = new Point(92, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5ddd3610-d0f7-408a-a4df-83eeeb239c91"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4df43d5b-16bf-4e8e-96d8-b0cd89b8f83d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"SubProcessInit",
				Position = new Point(238, 0),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(280, 124),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessInit;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a2e36889-5f4d-419c-a09c-03eeaed73699"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5ddd3610-d0f7-408a-a4df-83eeeb239c91"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"InitMessage",
				Position = new Point(15, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("234ff53e-23e0-4051-9a4e-a34585c29877"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5ddd3610-d0f7-408a-a4df-83eeeb239c91"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"ScriptInit",
				Position = new Point(99, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,73,44,73,12,206,47,45,74,78,213,115,46,45,42,74,205,43,9,46,41,42,77,46,41,45,74,213,243,44,246,200,76,45,74,44,74,206,200,76,78,204,81,176,85,72,75,204,41,78,181,230,42,74,5,74,231,41,0,213,165,90,3,0,139,38,138,242,69,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowInitParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("65971a5b-50b0-47ae-af78-193223ed87da"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5ddd3610-d0f7-408a-a4df-83eeeb239c91"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"ThrowInitParent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(211, 45),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9a53b087-7117-4ee6-b882-7012c3230411"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba66d5af-b37e-40d2-9022-22b3155271ba"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"SubProcess9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(238, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(203, 121),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateGridPageRefreshRowChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f9dbd54a-e20e-49d2-af1a-9b6f46d4526c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9a53b087-7117-4ee6-b882-7012c3230411"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"GridPageRefreshRow",
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"GridPageRefreshRowChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptGridPageRefreshRowChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4800adf6-65dd-457d-84fe-849ff7975a71"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9a53b087-7117-4ee6-b882-7012c3230411"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"ScriptGridPageRefreshRowChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(92, 21),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,219,110,226,48,16,125,134,175,112,121,168,28,169,114,63,0,245,161,132,139,144,80,85,53,176,125,54,241,0,150,28,155,29,219,93,69,171,254,251,218,14,1,66,89,36,36,20,145,153,115,142,207,76,198,35,55,132,206,237,24,28,151,106,134,82,100,228,111,191,247,197,145,172,189,115,70,219,220,104,135,70,45,120,109,188,35,47,228,157,111,129,141,174,228,134,253,158,12,90,87,105,15,47,68,123,165,146,118,18,223,134,147,130,24,77,106,241,17,241,92,106,192,240,134,160,29,123,227,149,212,219,99,152,112,75,58,184,140,77,165,22,109,40,28,53,170,3,5,232,32,22,49,200,134,207,207,116,33,173,131,0,141,160,150,95,148,59,168,248,202,2,30,104,217,197,241,183,85,131,253,141,65,224,229,142,158,122,68,164,190,218,45,54,119,80,217,166,232,94,3,96,19,205,215,10,66,237,49,214,163,5,40,40,29,136,55,35,224,29,101,197,177,206,141,242,149,254,197,149,135,182,111,228,241,145,60,220,134,178,201,111,207,149,165,51,47,5,155,84,123,87,103,201,237,119,63,252,190,251,209,172,224,142,23,198,99,9,237,103,28,31,35,195,132,40,61,198,222,23,14,125,233,60,70,220,137,196,242,139,108,195,17,105,114,166,82,57,64,27,8,151,26,236,144,74,141,109,187,57,62,35,197,174,198,193,233,10,157,79,204,127,37,63,160,50,95,208,101,6,181,166,92,11,28,203,221,157,198,138,51,82,107,172,43,116,143,177,14,243,104,108,99,148,0,188,211,216,244,140,212,26,235,10,221,99,172,195,76,198,228,134,158,166,161,73,28,21,111,9,190,10,65,233,18,16,185,53,27,199,86,115,246,9,235,195,45,176,236,248,103,126,41,30,175,70,70,46,163,201,202,15,31,141,141,102,220,28,2,204,154,229,145,70,120,121,120,31,246,219,12,203,85,104,59,13,82,55,102,183,227,255,28,23,238,182,59,156,251,41,221,46,44,163,208,254,136,164,77,48,55,213,158,163,180,70,47,235,61,176,5,88,251,68,6,69,109,95,69,216,87,43,45,93,138,167,59,57,120,34,84,106,151,157,218,147,135,221,193,198,35,246,3,31,23,82,214,181,188,48,92,124,152,63,54,86,130,16,76,235,80,188,135,225,63,26,149,175,47,177,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("98e38993-d2c1-4691-8a3c-449cd5934230"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4df43d5b-16bf-4e8e-96d8-b0cd89b8f83d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"SubProcess11",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(533, 3),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(308, 138),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceLoadRowsResponseRegisteredChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3dfc1f3a-62de-4264-9f97-d23f3e404728"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("98e38993-d2c1-4691-8a3c-449cd5934230"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DataSourceLoadRowsResponseRegistered",
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"DataSourceLoadRowsResponseRegisteredChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(21, 39),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildDataSourceLoadRowsResponseRegisteredScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b746701a-0a60-40c0-954c-bbc7e86d1397"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("98e38993-d2c1-4691-8a3c-449cd5934230"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"ScriptChildDataSourceLoadRowsResponseRegistered",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(196, 25),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,85,77,111,218,64,16,61,227,95,177,225,100,164,96,32,105,161,136,54,18,24,72,34,53,17,13,73,122,168,122,216,224,77,88,201,94,147,245,58,145,219,68,170,90,169,167,74,189,247,208,246,39,160,54,81,163,126,253,6,243,143,58,107,99,106,130,73,32,168,82,15,17,202,204,219,153,121,111,223,172,233,33,82,91,248,136,104,117,44,112,219,118,121,135,104,213,142,160,39,100,199,62,109,113,106,97,238,233,182,233,90,108,31,155,46,65,75,143,208,186,75,13,173,97,245,132,151,65,47,149,84,155,136,134,65,133,44,178,183,105,76,47,166,173,19,177,235,245,136,17,43,247,80,214,90,83,211,109,207,169,26,22,101,123,140,6,152,77,35,157,201,84,148,115,229,4,115,228,76,36,81,124,136,202,4,168,133,57,97,98,199,54,67,168,42,177,25,232,254,152,58,130,48,194,91,220,238,16,199,129,159,30,225,194,11,38,81,71,73,152,127,8,0,58,203,40,29,175,150,206,132,221,32,64,133,215,238,116,137,133,183,48,131,35,28,26,237,57,132,235,54,99,4,40,219,76,107,76,130,194,211,199,46,225,30,224,25,57,69,113,208,19,25,87,19,106,195,20,251,167,113,141,162,57,4,200,17,202,185,141,45,2,37,131,210,90,213,24,138,60,169,172,38,73,104,18,93,81,66,112,147,154,130,112,71,30,82,195,136,206,9,22,36,140,63,165,162,11,10,0,94,130,84,37,21,134,117,219,234,97,78,29,155,5,69,27,199,46,54,97,74,40,190,60,245,42,50,113,241,40,113,70,227,194,213,132,50,192,208,102,40,158,58,174,37,156,164,96,212,232,164,166,219,46,19,104,13,229,3,7,38,26,36,194,62,203,63,191,193,121,227,2,142,44,215,197,142,44,166,119,41,57,132,90,27,177,127,213,169,244,66,118,7,174,16,54,219,34,204,133,131,193,50,128,176,181,32,168,201,104,136,178,249,17,102,244,5,150,228,100,116,83,16,11,240,127,15,195,181,48,67,165,65,120,13,201,223,224,210,128,57,19,152,50,71,149,230,145,28,212,116,189,89,94,173,235,181,114,182,88,171,151,178,245,102,161,144,45,215,86,170,217,124,190,80,47,230,27,229,213,7,122,17,238,124,215,110,11,78,217,145,154,222,134,229,26,78,235,2,137,69,251,215,138,247,203,205,130,158,191,75,255,142,148,116,225,1,74,119,31,64,16,108,45,218,255,94,113,165,81,46,233,165,121,251,87,79,48,53,241,129,73,154,54,7,147,92,95,213,107,175,156,92,128,36,167,135,239,200,60,86,128,165,65,185,28,242,63,14,94,249,95,253,190,255,203,191,242,191,249,253,193,91,255,106,240,94,73,221,62,214,188,13,43,74,42,201,240,240,66,202,54,114,91,5,119,225,65,74,197,237,56,153,29,51,75,44,189,20,95,87,192,197,239,116,162,202,57,34,166,67,208,44,106,206,102,236,72,205,79,254,111,255,2,20,237,131,150,23,254,165,255,3,254,164,178,151,74,42,151,187,246,16,140,134,154,79,237,217,6,186,93,237,67,12,18,252,127,114,207,180,198,145,220,159,7,111,252,239,32,249,23,41,59,24,247,181,148,124,240,110,81,238,81,122,26,249,40,63,133,244,48,61,7,235,217,30,143,136,245,7,96,251,51,88,217,11,191,127,179,177,254,173,14,51,154,32,42,35,149,24,59,18,124,184,231,51,255,76,246,128,94,231,240,17,159,38,75,226,135,119,148,62,59,67,137,114,64,60,89,7,72,36,17,175,40,156,8,151,179,112,7,254,0,157,217,106,153,99,11,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowDataSourceLoadRowsResponseRegisteredParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("4091e0ff-21a4-4033-9e26-f41bb817a547"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("98e38993-d2c1-4691-8a3c-449cd5934230"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DataSourceLoadRowsResponseRegistered",
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"ThrowDataSourceLoadRowsResponseRegisteredParent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(105, 39),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess13EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess13 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b46699a0-03d9-44c0-a523-697e2d3cb294"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aecd67fe-86b2-49e1-9038-f2362ff6e026"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"SubProcess13",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(456, 231),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess13;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteButtonClickChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5c070686-44d0-4cbe-ba17-e527cfec5ccb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b46699a0-03d9-44c0-a523-697e2d3cb294"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteButtonClick",
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"DeleteButtonClickChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(14, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDeleteButtonClickChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("99b04025-f973-48ec-912e-5401be227345"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b46699a0-03d9-44c0-a523-697e2d3cb294"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"ScriptDeleteButtonClickChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(344, 26),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,145,221,74,3,49,16,133,175,221,167,136,189,218,189,73,31,96,233,133,173,86,4,45,197,245,231,122,220,156,214,64,126,150,73,82,88,196,119,119,83,181,221,130,80,240,38,97,50,115,190,204,153,209,27,81,54,48,104,35,212,202,43,172,89,91,226,126,225,77,178,238,133,76,130,184,156,137,219,164,149,188,177,93,236,43,241,81,92,236,136,133,209,33,194,129,215,180,133,152,137,50,223,50,31,11,239,34,233,33,51,68,12,23,229,138,172,118,219,195,179,160,32,78,234,170,189,236,206,133,72,174,69,78,63,129,153,130,223,68,249,138,183,171,174,147,115,10,120,240,42,25,228,210,166,125,135,165,231,0,206,12,246,166,158,78,239,199,237,252,7,241,237,170,27,55,54,216,26,187,220,35,150,222,168,63,60,252,200,21,69,106,124,226,54,143,228,132,37,151,218,169,95,201,240,223,188,31,198,130,114,114,125,80,76,170,76,61,198,3,242,136,147,143,176,126,135,51,171,170,234,226,179,56,179,205,241,50,235,130,17,19,59,17,57,161,254,2,27,11,143,45,11,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowDeleteButtonClickParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("c582aa6b-3f06-4770-bc1a-1778a5496fc4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b46699a0-03d9-44c0-a523-697e2d3cb294"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DeleteButtonClick",
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"ThrowDeleteButtonClickParent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(232, 40),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptScriptDeleteButtonClickChildBeforeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d67a8286-282c-4e6a-ad65-b8a7d41b17ea"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b46699a0-03d9-44c0-a523-697e2d3cb294"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"ScriptScriptDeleteButtonClickChildBefore",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 26),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,65,79,194,64,16,133,207,244,87,108,56,144,114,232,6,36,65,27,196,4,186,128,30,52,6,80,207,147,118,128,77,218,221,186,157,5,171,241,191,187,181,128,6,67,226,117,231,123,111,222,204,172,208,2,83,36,156,99,172,77,194,134,140,140,197,129,183,5,195,32,38,185,197,185,222,185,215,71,88,35,23,64,176,208,214,196,200,71,135,90,141,106,179,6,37,223,129,164,86,203,50,199,187,202,73,225,142,205,172,76,252,166,152,134,61,17,141,195,160,63,22,151,129,152,118,187,65,56,190,24,5,157,78,87,244,59,147,176,119,21,245,155,237,129,87,209,140,14,250,99,127,62,67,170,92,147,72,167,54,83,207,144,90,188,174,216,27,191,185,40,139,81,146,73,245,164,36,213,157,143,70,57,24,84,244,111,171,211,17,23,241,6,51,224,183,18,13,152,120,83,214,10,254,75,248,0,25,186,102,114,197,252,58,52,159,188,90,72,11,255,239,58,218,172,213,250,21,104,248,189,24,62,201,114,42,219,236,195,107,136,211,51,172,156,143,187,67,67,160,42,247,37,173,169,46,243,123,44,10,151,118,137,111,228,208,35,242,67,156,19,70,144,87,153,156,232,5,140,146,106,125,14,172,150,177,63,251,192,251,244,12,146,53,170,254,27,95,105,183,179,219,50,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateDenyDeleteRootRecordUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("7e57ce12-11fd-4b10-8c1f-5d28754412fd"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b46699a0-03d9-44c0-a523-697e2d3cb294"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"DenyDeleteRootRecord",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 131),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeDenyDeleteRootRecordParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartChildDataSourceRemovedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ea3aeee9-5703-4951-9216-fc0d696fba52"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b46699a0-03d9-44c0-a523-697e2d3cb294"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DataSourceRemoved",
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"StartChildDataSourceRemoved",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(267, 159),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowDataSourceRemovedIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("83240534-e533-4db2-b90d-db6780033feb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b46699a0-03d9-44c0-a523-697e2d3cb294"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DataSourceRemoved",
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"IntermediateThrowDataSourceRemoved",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(365, 159),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8fdf8b49-f501-4521-a402-61ccdd2f1446"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aecd67fe-86b2-49e1-9038-f2362ff6e026"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"SubProcess10",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(477, 5),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(278, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("dd2ea106-66bd-4852-9510-5c886a10a75f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8fdf8b49-f501-4521-a402-61ccdd2f1446"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"PageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadCompleteChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("469e3251-3d92-4153-b737-c8bb91bd684b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8fdf8b49-f501-4521-a402-61ccdd2f1446"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"ScriptPageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(98, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,37,141,177,10,131,48,20,69,119,191,66,50,181,67,130,105,37,86,164,131,80,17,161,131,84,75,231,152,188,72,160,85,121,38,250,251,77,233,120,46,156,123,90,57,2,187,73,39,187,217,163,2,86,77,114,120,67,7,184,1,150,202,217,13,30,243,30,95,99,135,30,138,168,210,214,181,193,120,54,58,108,19,236,113,237,173,62,144,139,22,41,40,99,104,106,78,154,166,89,206,169,204,19,73,133,224,137,57,103,70,113,46,200,177,136,126,46,235,17,160,70,171,89,243,9,120,183,171,11,95,164,7,68,185,206,198,177,23,12,229,178,144,34,66,112,30,167,127,250,11,143,252,67,162,168,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowPageLoadCompleteParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("dbcb519c-8168-465a-bc64-ec8c1940a52f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8fdf8b49-f501-4521-a402-61ccdd2f1446"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"ThrowPageLoadCompleteParent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(211, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess12EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess12 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f1cc9870-9762-4f18-b0ce-345018587c60"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba66d5af-b37e-40d2-9022-22b3155271ba"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"SubProcess12",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(449, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(196, 123),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess12;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateApplyFolderFilterChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ab2a712a-f489-4e98-91a1-7bcf646462da"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f1cc9870-9762-4f18-b0ce-345018587c60"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ApplyFolderFilter",
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"ApplyFolderFilterChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptApplyFolderFilterChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ce496dad-7603-40fe-87c6-475f9784e602"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f1cc9870-9762-4f18-b0ce-345018587c60"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Name = @"ScriptApplyFolderFilterChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(85, 23),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,86,77,111,226,48,16,61,195,175,48,156,130,90,185,189,247,67,162,64,171,72,221,85,85,96,123,168,122,48,201,164,120,149,216,172,237,208,69,43,254,251,206,196,129,132,240,177,221,34,4,193,158,121,243,222,204,216,195,82,24,150,74,235,64,129,121,18,239,192,110,88,64,223,156,62,6,90,57,33,113,7,127,25,80,142,127,23,153,84,239,219,101,38,44,219,177,235,21,110,161,178,78,168,8,104,123,2,198,8,171,19,199,95,96,214,95,44,248,157,176,240,77,199,121,10,100,58,142,230,144,137,169,5,67,24,70,167,87,23,23,143,117,58,95,129,104,47,81,84,44,156,24,235,220,68,36,169,80,52,220,174,120,139,40,55,36,106,236,76,30,185,220,144,93,229,196,7,141,221,38,234,189,76,29,102,0,211,85,241,155,134,68,177,164,97,249,246,33,28,54,220,66,7,89,143,53,87,175,218,50,9,58,122,246,19,34,199,159,33,1,36,16,193,232,87,46,82,27,52,141,207,153,202,211,180,215,99,127,218,173,68,155,64,42,199,36,210,185,188,194,175,235,61,113,220,123,17,169,92,57,180,57,59,43,92,91,24,242,152,237,171,124,163,138,3,47,41,52,197,23,155,158,65,171,117,2,100,39,177,27,169,173,214,186,77,111,146,124,130,108,209,88,251,161,203,168,71,29,251,113,188,239,115,85,4,196,100,129,136,230,44,160,122,38,190,138,82,29,77,216,54,75,157,164,18,189,201,72,119,12,194,68,115,111,218,37,82,45,202,69,105,25,218,145,18,179,20,98,76,64,39,180,222,118,171,124,205,32,181,64,232,39,74,224,203,197,110,217,165,231,81,113,182,8,170,224,131,209,105,185,62,216,96,183,1,41,254,154,222,255,16,76,47,242,248,167,106,146,93,0,31,194,189,215,105,12,230,4,174,175,105,178,173,36,194,121,131,245,113,141,201,142,164,163,57,126,134,76,47,161,142,237,11,212,254,100,123,241,1,70,119,101,230,95,164,155,227,109,137,218,200,50,240,139,3,157,45,132,145,86,171,201,106,1,252,17,172,61,103,221,241,202,246,99,188,80,167,74,186,98,253,135,72,115,232,158,51,58,204,189,234,90,25,160,58,62,188,227,123,246,116,233,245,144,112,113,189,77,12,192,131,145,49,31,164,152,114,170,125,141,225,163,22,241,179,254,176,180,92,220,99,128,231,42,181,19,49,123,18,10,82,44,85,125,8,240,225,238,118,113,49,53,92,56,62,108,218,243,230,166,236,79,3,152,38,197,48,95,120,95,174,139,72,34,114,114,9,104,76,183,192,1,136,215,230,98,127,227,16,170,24,126,191,81,108,22,108,81,56,117,246,103,226,122,216,157,233,132,12,26,56,175,151,111,245,25,86,13,143,194,121,88,31,33,193,1,64,236,7,21,215,156,239,86,212,211,65,183,114,164,86,198,0,245,209,243,144,203,184,236,204,129,78,243,76,21,85,199,8,180,193,71,217,194,173,124,190,171,234,81,229,74,201,157,141,100,162,185,48,50,19,102,229,97,40,244,238,8,243,147,145,63,213,173,138,83,135,45,126,136,0,93,39,68,162,25,26,179,196,31,192,213,140,131,189,200,61,62,209,120,78,240,223,65,64,29,185,110,111,167,184,209,17,182,251,24,28,62,45,192,184,85,80,31,240,229,246,52,140,241,64,220,55,73,225,89,216,35,138,232,27,128,201,220,232,143,209,18,143,232,113,76,156,163,6,236,188,236,232,46,122,215,155,229,47,40,223,11,165,255,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSetDefValuesForAddAdministrativeUnitMethod());
			Methods.Add(CreateHasUnitChiefMethod());
			Methods.Add(CreateSetEditPageUIdMethod());
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

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateModifyAddPageParametersMethod() {
			SchemaMethod method = base.CreateModifyAddPageParametersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,193,78,195,48,12,134,239,123,138,168,151,182,151,188,64,181,3,108,12,245,0,66,116,136,195,52,33,211,252,148,72,105,82,18,183,98,111,79,218,10,88,145,38,113,73,226,248,247,239,207,30,200,11,163,3,195,194,63,80,3,177,22,217,120,203,241,216,56,203,164,99,38,70,30,150,229,61,181,218,54,63,223,130,130,88,232,242,169,172,180,129,201,214,24,211,123,120,79,193,189,177,124,198,235,85,215,201,107,10,184,115,170,55,24,165,85,253,142,150,158,2,252,232,225,157,41,86,67,36,234,206,93,214,11,192,201,96,231,140,154,168,254,221,108,174,8,23,122,126,244,240,167,138,125,28,46,78,74,45,56,106,15,9,41,165,89,59,75,102,239,129,91,175,85,114,140,56,231,116,242,59,35,55,70,199,21,149,219,98,21,38,35,17,96,80,51,212,188,187,82,197,202,228,230,147,165,66,237,20,178,241,217,128,179,180,238,3,187,118,75,76,59,13,163,210,92,42,215,202,129,76,143,252,144,86,167,48,79,240,178,244,123,116,6,165,74,143,201,69,250,95,221,68,253,23,167,248,2,106,170,218,20,251,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateModifyEditPageParametersMethod() {
			SchemaMethod method = base.CreateModifyEditPageParametersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,80,193,10,194,48,12,189,251,21,101,39,189,244,7,198,14,58,65,118,80,132,77,60,136,135,184,198,89,232,218,153,102,3,255,222,118,160,108,7,193,75,66,242,94,242,94,50,0,9,163,61,163,69,58,66,131,34,19,203,152,101,12,185,179,12,58,32,161,34,180,44,15,208,106,219,124,219,2,188,152,241,86,227,88,97,61,131,173,49,194,21,18,129,119,119,150,103,188,173,187,78,110,192,227,222,169,222,96,164,150,245,3,91,56,121,164,184,131,156,73,23,67,112,212,77,183,100,51,131,114,71,90,253,39,19,153,63,68,158,61,210,171,100,10,215,132,211,160,69,70,242,151,4,148,210,172,157,5,83,17,142,243,201,53,232,79,237,200,15,34,115,163,195,79,138,109,250,6,30,67,63,23,68,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetDefValuesForAddAdministrativeUnitMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ae21317c-6e6d-4b93-ba8d-26fd549cdf84"),
				Name = "SetDefValuesForAddAdministrativeUnit",
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("85862917-e1a6-4ada-a4fe-d15dc74a67c3"),
				Name = "SysAdminUnitTypeId",
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,81,61,107,195,48,16,157,227,95,33,50,217,80,68,118,181,129,98,23,227,197,152,202,233,98,50,168,214,37,85,177,164,160,143,26,83,250,223,43,171,109,112,58,100,200,116,156,238,222,123,247,158,196,1,165,5,28,94,216,224,193,86,28,87,246,73,158,220,148,102,25,250,76,86,139,9,122,64,165,23,28,215,48,206,53,205,72,178,218,89,48,185,86,10,122,39,180,194,20,172,13,181,96,142,117,75,206,86,83,103,132,58,166,217,62,176,40,24,81,33,34,130,153,233,222,198,209,29,210,175,239,129,102,59,243,126,37,31,204,32,254,199,16,48,55,8,49,123,69,133,68,5,11,67,104,128,215,154,71,149,134,29,1,183,6,160,52,193,40,93,78,73,34,66,80,23,0,156,107,175,28,218,162,77,140,234,124,110,183,110,152,1,229,158,245,0,235,217,240,5,170,219,236,241,239,94,148,155,61,80,237,77,15,152,246,111,32,25,46,193,53,70,200,112,117,174,7,47,85,205,36,4,67,115,44,11,13,58,217,71,46,133,218,41,225,218,233,244,163,244,255,177,226,100,137,153,83,108,152,181,163,54,60,238,43,63,12,36,185,233,23,207,180,228,27,255,159,35,100,66,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateHasUnitChiefMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d160b131-c5cf-466f-a33d-40610fb3f84f"),
				Name = "HasUnitChief",
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7a61cff8-7823-44b0-8879-401e81de7659"),
				Name = "UnitUId",
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,75,79,195,48,16,132,207,201,175,176,114,178,47,86,197,181,2,169,121,84,202,173,234,3,14,136,131,105,182,37,34,89,195,218,46,84,168,255,157,77,82,169,45,208,3,146,47,30,239,124,99,143,119,134,132,131,6,214,62,179,1,189,184,21,8,31,98,9,68,198,217,141,215,153,37,208,121,170,23,253,140,156,153,45,232,149,3,202,44,34,11,181,69,21,71,17,143,53,161,69,249,219,55,13,184,214,61,250,143,195,193,165,39,206,3,213,238,85,42,197,48,61,37,219,202,100,177,119,147,170,173,113,133,181,79,58,249,225,5,8,46,245,229,254,13,238,77,19,32,81,186,116,197,123,48,205,245,148,153,33,211,2,39,201,155,62,102,130,149,76,88,4,244,115,219,64,89,253,15,210,229,175,202,74,41,97,220,213,190,198,113,112,53,110,133,220,113,205,213,115,241,9,235,224,45,113,203,151,29,234,2,93,32,200,211,147,196,101,136,175,56,58,243,19,152,10,58,239,217,127,233,1,9,243,254,76,158,34,6,119,84,111,132,28,124,186,27,57,66,163,136,192,7,194,159,183,200,211,174,81,22,118,64,252,70,222,247,237,46,109,201,223,55,96,30,71,79,74,220,137,209,152,41,135,152,215,33,62,178,54,166,113,48,254,6,161,137,214,239,80,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetEditPageUIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("42589b1c-1038-489b-b7f0-a94384700016"),
				Name = "SetEditPageUId",
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("46867b8a-1b85-4ad4-b0d7-b4c369ca0532"),
				Name = "SysAdminUnitUId",
				CreatedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				ModifiedInSchemaUId = new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,209,61,78,3,49,16,134,225,58,123,10,43,213,166,24,197,127,107,239,8,165,64,128,16,21,72,144,3,216,158,113,176,68,22,148,44,66,128,184,59,38,52,105,2,73,235,226,157,71,254,74,22,237,253,251,246,156,214,101,88,14,101,92,222,144,88,44,196,192,111,226,250,181,80,59,165,140,134,82,68,112,145,60,80,86,10,48,234,0,82,42,114,146,209,244,201,77,103,51,241,217,76,230,243,219,205,42,12,229,35,140,229,121,104,38,87,84,198,187,176,226,93,115,47,217,147,179,156,114,6,155,53,129,245,168,32,160,12,224,156,146,217,248,156,148,170,201,179,230,75,240,211,150,69,249,143,24,93,135,89,37,121,20,81,92,242,75,216,140,107,30,198,195,66,212,42,164,36,35,196,244,35,36,235,160,183,90,131,9,38,145,78,136,209,227,73,66,127,138,240,226,177,112,62,140,211,214,179,210,33,2,25,111,235,31,198,14,130,173,217,250,100,162,100,242,157,12,123,184,223,230,3,135,181,104,173,211,140,62,249,191,28,179,195,151,187,148,92,52,72,64,170,211,117,56,215,3,170,26,98,178,170,206,86,71,244,102,119,249,27,96,35,187,101,86,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AdministrationUnitsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("309eddc2-f344-40f2-a4f1-f61fd1522699"));
		}

		#endregion

	}

	#endregion

}

