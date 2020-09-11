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
	using System.Security;
	using System.Text;
	using System.Threading;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.OperationLog;
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

	#region Class: AdministrativeObjectColumnRightsGridPageSchema

	/// <exclude/>
	public class AdministrativeObjectColumnRightsGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.Button _upButton;
		public Terrasoft.UI.WebControls.Controls.Button UpButton {
			get {
				return _upButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _downButton;
		public Terrasoft.UI.WebControls.Controls.Button DownButton {
			get {
				return _downButton;
			}
		}

		#endregion

		#region Constructors: Public

		public AdministrativeObjectColumnRightsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AdministrativeObjectColumnRightsGridPageSchema(AdministrativeObjectColumnRightsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.Hidden = true;
			EditButton.ModifiedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
			TreeGrid.AjaxEvents.CellIconClick.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
			RealUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
			Name = "AdministrativeObjectColumnRightsGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAdministrativeObjectColumnRightsGridPageEventsProcessSchema();
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
			ButtonsControlLayout.InsertItem(4, CreateUpButton());
			ButtonsControlLayout.InsertItem(5, CreateDownButton());
			ButtonsControlLayout.MoveItem(6, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(7, PrintButton);
			ButtonsControlLayout.MoveItem(8, ContextHelpButton);
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

		protected virtual EmbeddedProcessSchema CreateAdministrativeObjectColumnRightsGridPageEventsProcessSchema() {
			var schema = new AdministrativeObjectColumnRightsGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateUpButton() {
			_upButton = new Terrasoft.UI.WebControls.Controls.Button();
			_upButton.UId = new Guid("ef1f9094-a2ba-4804-a0f1-c52ea87bfe5d");
			_upButton.Name = "UpButton";
			_upButton.CreatedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
			_upButton.ModifiedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
			_upButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_upButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_upButton.Tag = "";
			_upButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3"),
				ImageHash = @"237f430c77240f66f9368acf2476bfc0"
			};
			_upButton.Enabled = false;
			return _upButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDownButton() {
			_downButton = new Terrasoft.UI.WebControls.Controls.Button();
			_downButton.UId = new Guid("1c4aac4d-6a36-46f8-ba47-45a379cb24fd");
			_downButton.Name = "DownButton";
			_downButton.CreatedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
			_downButton.ModifiedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
			_downButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_downButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_downButton.Tag = "";
			_downButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3"),
				ImageHash = @"237f430c77240f66f9368acf2476bfc0"
			};
			_downButton.Enabled = false;
			return _downButton;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("f302c13d-4a72-483f-9744-345f6b0eb555");
			DataSource.ModifiedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("d213e4d3-7484-4ab4-b026-80c9f41b0012");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
				column.ModifiedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.IsSortable = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4e633c16-e807-4873-9c46-375d376d0a2a");
			if (column != null) {
				column.UId = new Guid("067fe1b5-4f6a-494a-8794-c53c7493f7a7");
				column.Name = @"SysAdminUnit";
				column.CreatedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
				column.ModifiedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.IsSortable = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4d7ac7e2-9285-462a-b942-b8ae69d229ea");
			if (column != null) {
				column.UId = new Guid("f07dbf21-7f7b-4977-ba95-a020d5398eb6");
				column.Name = @"RightLevel";
				column.CreatedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
				column.ModifiedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.IsSortable = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c55f4107-514d-4fe3-8ed6-f56e272c31a7");
			if (column != null) {
				column.UId = new Guid("90a25a20-33ff-41d0-9c1f-eff772bc9c64");
				column.Name = @"SubjectSchemaUId";
				column.CreatedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
				column.ModifiedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.IsSortable = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("6bae586e-5d9c-4484-b8d0-5c9a59f3bfb9");
			if (column != null) {
				column.UId = new Guid("3889b658-2881-414e-a9d7-e2b14ddf5bea");
				column.Name = @"SubjectColumnUId";
				column.CreatedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
				column.ModifiedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.IsSortable = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("90af7c81-0689-48a8-83fb-3ecaeba22b7f");
			if (column != null) {
				column.UId = new Guid("b994803b-fd69-43b4-a4a0-1f0de858c463");
				column.Name = @"Position";
				column.CreatedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
				column.ModifiedInSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.IsSortable = false;
				column.OrderDirection = OrderDirection.Ascending;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new AdministrativeObjectColumnRightsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new AdministrativeObjectColumnRightsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AdministrativeObjectColumnRightsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeObjectColumnRightsGridPageEventsProcess

	/// <exclude/>
	public class AdministrativeObjectColumnRightsGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AdministrativeObjectColumnRightsGridPageSchemaUserControl
	{

		#region Class: OpenLookupUserTaskFlowElement

		/// <exclude/>
		public class OpenLookupUserTaskFlowElement : OpenLookupUserTask
		{

			public OpenLookupUserTaskFlowElement(UserConnection userConnection, AdministrativeObjectColumnRightsGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenLookupUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("d8a70e1a-74ff-4523-9030-8883ca939300");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: ApplyDataUserTaskFlowElement

		/// <exclude/>
		public class ApplyDataUserTaskFlowElement : QuestionUserTask
		{

			public ApplyDataUserTaskFlowElement(UserConnection userConnection, AdministrativeObjectColumnRightsGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ApplyDataUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("c8fc346b-ae73-48f1-924e-b1077f140def");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public AdministrativeObjectColumnRightsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdministrativeObjectColumnRightsGridPageEventsProcess";
			SchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
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

		public virtual string RightsSchemaName {
			get;
			set;
		}

		public virtual string RightsGrouppingColumnNames {
			get;
			set;
		}

		public virtual Guid SubjectColumnUId {
			get;
			set;
		}

		public virtual Guid SubjectSchemaUId {
			get;
			set;
		}

		private ProcessFlowElement _subProcess9;
		public ProcessFlowElement SubProcess9 {
			get {
				return _subProcess9 ?? (_subProcess9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess9",
					SchemaElementUId = new Guid("7a8132bd-d508-43fd-b6d0-526f70338ad5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage5;
		public ProcessFlowElement StartMessage5 {
			get {
				return _startMessage5 ?? (_startMessage5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage5",
					SchemaElementUId = new Guid("8e504483-8d1b-4ee1-9721-1d7285098408"),
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
					SchemaElementUId = new Guid("fb4e0526-981c-425e-a82d-349a55517837"),
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
					SchemaElementUId = new Guid("595ea418-4318-40ba-8c90-fe99ae05a0f0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
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
					SchemaElementUId = new Guid("1b0c0949-23e1-4188-aed7-77970a575bb4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadChild;
		public ProcessFlowElement PageLoadChild {
			get {
				return _pageLoadChild ?? (_pageLoadChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadChild",
					SchemaElementUId = new Guid("010373b4-9d4c-4000-bef9-76f2d94eed9c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptPageLoadChild;
		public ProcessScriptTask ScriptPageLoadChild {
			get {
				return _scriptPageLoadChild ?? (_scriptPageLoadChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPageLoadChild",
					SchemaElementUId = new Guid("758359a3-a4bd-4058-adb1-672b97f273d1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadChildExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _throwScriptPageLoadParent;
		public ProcessThrowMessageEvent ThrowScriptPageLoadParent {
			get {
				return _throwScriptPageLoadParent ?? (_throwScriptPageLoadParent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowScriptPageLoadParent",
					SchemaElementUId = new Guid("99be1677-3cf3-4214-ba9e-48e79cfcd61a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoad",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("00a71c1e-9025-4b42-90f8-52f16c03dcb7"),
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
					SchemaElementUId = new Guid("6178f0b4-597d-4aed-864a-596cb61cafac"),
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
					SchemaElementUId = new Guid("486798a4-29f5-47d5-940d-087222e2c479"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptGridPageRefreshRowChildExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _throwGridPageRefreshRowParent;
		public ProcessThrowMessageEvent ThrowGridPageRefreshRowParent {
			get {
				return _throwGridPageRefreshRowParent ?? (_throwGridPageRefreshRowParent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowGridPageRefreshRowParent",
					SchemaElementUId = new Guid("b6444541-1e30-4a6a-be62-df952e18c460"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "GridPageRefreshRow",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _subProcess9OpenVwSysSchemaInSolution;
		public ProcessFlowElement SubProcess9OpenVwSysSchemaInSolution {
			get {
				return _subProcess9OpenVwSysSchemaInSolution ?? (_subProcess9OpenVwSysSchemaInSolution = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess9OpenVwSysSchemaInSolution",
					SchemaElementUId = new Guid("b6173a01-f02a-4a83-8fef-713a069ef368"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _openVwSysSchemaInSolution;
		public ProcessFlowElement OpenVwSysSchemaInSolution {
			get {
				return _openVwSysSchemaInSolution ?? (_openVwSysSchemaInSolution = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OpenVwSysSchemaInSolution",
					SchemaElementUId = new Guid("9b356a50-be2f-4a6b-a1ed-89664972f2e3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _initOpenLookupUserTaskScript;
		public ProcessScriptTask InitOpenLookupUserTaskScript {
			get {
				return _initOpenLookupUserTaskScript ?? (_initOpenLookupUserTaskScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitOpenLookupUserTaskScript",
					SchemaElementUId = new Guid("b5ef33b9-a85a-4b1a-955a-85aa3adc721c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitOpenLookupUserTaskScriptExecute,
				});
			}
		}

		private OpenLookupUserTaskFlowElement _openLookupUserTask;
		public OpenLookupUserTaskFlowElement OpenLookupUserTask {
			get {
				return _openLookupUserTask ?? (_openLookupUserTask = new OpenLookupUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessIntermediateCatchMessageEvent _lookupGridPageClosed;
		public ProcessIntermediateCatchMessageEvent LookupGridPageClosed {
			get {
				return _lookupGridPageClosed ?? (_lookupGridPageClosed = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "LookupGridPageClosed",
					SchemaElementUId = new Guid("ca1c7b34-15f5-4ad3-8995-de4d0a920a47"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "LookupGridPageClosed",
				});
			}
		}

		private ProcessScriptTask _applyDataScript;
		public ProcessScriptTask ApplyDataScript {
			get {
				return _applyDataScript ?? (_applyDataScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ApplyDataScript",
					SchemaElementUId = new Guid("019cce6c-9d9d-40af-9ba1-f84df4cae5c3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ApplyDataScriptExecute,
				});
			}
		}

		private ApplyDataUserTaskFlowElement _applyDataUserTask;
		public ApplyDataUserTaskFlowElement ApplyDataUserTask {
			get {
				return _applyDataUserTask ?? (_applyDataUserTask = new ApplyDataUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _okButtonHandler;
		public ProcessFlowElement OkButtonHandler {
			get {
				return _okButtonHandler ?? (_okButtonHandler = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OkButtonHandler",
					SchemaElementUId = new Guid("e11c3c21-3bd2-44b5-a3a0-4684809cd761"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _okButtonHandlerScriptTask;
		public ProcessScriptTask OkButtonHandlerScriptTask {
			get {
				return _okButtonHandlerScriptTask ?? (_okButtonHandlerScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OkButtonHandlerScriptTask",
					SchemaElementUId = new Guid("e4b9d97a-4a6e-4a8c-bccf-cc77039815b4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OkButtonHandlerScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessTreeGridCellIconClick;
		public ProcessFlowElement SubProcessTreeGridCellIconClick {
			get {
				return _subProcessTreeGridCellIconClick ?? (_subProcessTreeGridCellIconClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessTreeGridCellIconClick",
					SchemaElementUId = new Guid("dde5eb0f-a557-4588-a0c3-55b34771a3aa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _treeGridCellIconClick;
		public ProcessFlowElement TreeGridCellIconClick {
			get {
				return _treeGridCellIconClick ?? (_treeGridCellIconClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "TreeGridCellIconClick",
					SchemaElementUId = new Guid("ef5f6a9a-25d4-4cdc-8923-0c13d180da24"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTreeGridCellIconClick;
		public ProcessScriptTask ScriptTreeGridCellIconClick {
			get {
				return _scriptTreeGridCellIconClick ?? (_scriptTreeGridCellIconClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTreeGridCellIconClick",
					SchemaElementUId = new Guid("7e4c7151-cfb3-4ae1-9d51-2b8dfd433aa4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTreeGridCellIconClickExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess9DataSourceBeforeLoad;
		public ProcessFlowElement SubProcess9DataSourceBeforeLoad {
			get {
				return _subProcess9DataSourceBeforeLoad ?? (_subProcess9DataSourceBeforeLoad = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess9DataSourceBeforeLoad",
					SchemaElementUId = new Guid("151dd994-e3d0-4edd-81bc-984924418c9a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dataSourceBeforeLoad;
		public ProcessFlowElement DataSourceBeforeLoad {
			get {
				return _dataSourceBeforeLoad ?? (_dataSourceBeforeLoad = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataSourceBeforeLoad",
					SchemaElementUId = new Guid("ce53c96c-9d51-4f05-969e-bbbe8ab7bf8c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _subProcessDownButtonClick;
		public ProcessFlowElement SubProcessDownButtonClick {
			get {
				return _subProcessDownButtonClick ?? (_subProcessDownButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessDownButtonClick",
					SchemaElementUId = new Guid("e4dc3da5-7153-468b-8ffd-3715bd4d5a39"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _downButtonClick;
		public ProcessFlowElement DownButtonClick {
			get {
				return _downButtonClick ?? (_downButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DownButtonClick",
					SchemaElementUId = new Guid("930e1a33-c94b-4a38-9b2a-e05892b7fa42"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDownButtonClick;
		public ProcessScriptTask ScriptDownButtonClick {
			get {
				return _scriptDownButtonClick ?? (_scriptDownButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDownButtonClick",
					SchemaElementUId = new Guid("5d4cd314-11b9-46dd-91ed-bd9a622b2525"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDownButtonClickExecute,
				});
			}
		}

		private ProcessFlowElement _upButtonClick;
		public ProcessFlowElement UpButtonClick {
			get {
				return _upButtonClick ?? (_upButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "UpButtonClick",
					SchemaElementUId = new Guid("8edae77f-59ec-45f5-b8b5-687072fdde7e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptUpButtonClick;
		public ProcessScriptTask ScriptUpButtonClick {
			get {
				return _scriptUpButtonClick ?? (_scriptUpButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptUpButtonClick",
					SchemaElementUId = new Guid("f1dcf5ef-cf7b-465c-8e9a-5b6108da1d29"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptUpButtonClickExecute,
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
					SchemaElementUId = new Guid("1c65e15c-4b4c-43bc-8873-dc4b7477ba81"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dataSourceLoadRowsChild;
		public ProcessFlowElement DataSourceLoadRowsChild {
			get {
				return _dataSourceLoadRowsChild ?? (_dataSourceLoadRowsChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataSourceLoadRowsChild",
					SchemaElementUId = new Guid("f782b455-f099-4316-be36-1d2fd1cb8067"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDataSourceLoadRowsChild;
		public ProcessScriptTask ScriptDataSourceLoadRowsChild {
			get {
				return _scriptDataSourceLoadRowsChild ?? (_scriptDataSourceLoadRowsChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDataSourceLoadRowsChild",
					SchemaElementUId = new Guid("60007875-fe3c-4710-9f99-5a3decbfa860"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDataSourceLoadRowsChildExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess11;
		public ProcessFlowElement EventSubProcess11 {
			get {
				return _eventSubProcess11 ?? (_eventSubProcess11 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess11",
					SchemaElementUId = new Guid("a95d5cc2-a203-4fea-8594-c41861882c96"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dataSourceRemovedChild;
		public ProcessFlowElement DataSourceRemovedChild {
			get {
				return _dataSourceRemovedChild ?? (_dataSourceRemovedChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataSourceRemovedChild",
					SchemaElementUId = new Guid("dff9c88b-ffd8-4f87-9214-4335fbb41041"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDataSourceRemovedChild;
		public ProcessScriptTask ScriptDataSourceRemovedChild {
			get {
				return _scriptDataSourceRemovedChild ?? (_scriptDataSourceRemovedChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDataSourceRemovedChild",
					SchemaElementUId = new Guid("6d412b4f-f4bb-4975-b613-0d3dd083d941"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDataSourceRemovedChildExecute,
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
					SchemaElementUId = new Guid("9664da22-ef37-447d-9838-09bdd7b632ca"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDataSourceBeforeLoadExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess9 };
			FlowElements[StartMessage5.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage5 };
			FlowElements[ScriptPageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadCompleteChild };
			FlowElements[ThrowPageLoadCompleteParent.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowPageLoadCompleteParent };
			FlowElements[SubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess10 };
			FlowElements[PageLoadChild.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadChild };
			FlowElements[ScriptPageLoadChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadChild };
			FlowElements[ThrowScriptPageLoadParent.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowScriptPageLoadParent };
			FlowElements[SubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess11 };
			FlowElements[GridPageRefreshRowChild.SchemaElementUId] = new Collection<ProcessFlowElement> { GridPageRefreshRowChild };
			FlowElements[ScriptGridPageRefreshRowChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptGridPageRefreshRowChild };
			FlowElements[ThrowGridPageRefreshRowParent.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowGridPageRefreshRowParent };
			FlowElements[SubProcess9OpenVwSysSchemaInSolution.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess9OpenVwSysSchemaInSolution };
			FlowElements[OpenVwSysSchemaInSolution.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenVwSysSchemaInSolution };
			FlowElements[InitOpenLookupUserTaskScript.SchemaElementUId] = new Collection<ProcessFlowElement> { InitOpenLookupUserTaskScript };
			FlowElements[OpenLookupUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenLookupUserTask };
			FlowElements[LookupGridPageClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { LookupGridPageClosed };
			FlowElements[ApplyDataScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ApplyDataScript };
			FlowElements[ApplyDataUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ApplyDataUserTask };
			FlowElements[OkButtonHandler.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonHandler };
			FlowElements[OkButtonHandlerScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonHandlerScriptTask };
			FlowElements[SubProcessTreeGridCellIconClick.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessTreeGridCellIconClick };
			FlowElements[TreeGridCellIconClick.SchemaElementUId] = new Collection<ProcessFlowElement> { TreeGridCellIconClick };
			FlowElements[ScriptTreeGridCellIconClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTreeGridCellIconClick };
			FlowElements[SubProcess9DataSourceBeforeLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess9DataSourceBeforeLoad };
			FlowElements[DataSourceBeforeLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceBeforeLoad };
			FlowElements[SubProcessDownButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessDownButtonClick };
			FlowElements[DownButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { DownButtonClick };
			FlowElements[ScriptDownButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDownButtonClick };
			FlowElements[UpButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { UpButtonClick };
			FlowElements[ScriptUpButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptUpButtonClick };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[DataSourceLoadRowsChild.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceLoadRowsChild };
			FlowElements[ScriptDataSourceLoadRowsChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDataSourceLoadRowsChild };
			FlowElements[EventSubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess11 };
			FlowElements[DataSourceRemovedChild.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceRemovedChild };
			FlowElements[ScriptDataSourceRemovedChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDataSourceRemovedChild };
			FlowElements[ScriptDataSourceBeforeLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDataSourceBeforeLoad };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcess9":
						break;
					case "StartMessage5":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadCompleteChild");
						break;
					case "ScriptPageLoadCompleteChild":
						e.Context.QueueTasks.Enqueue("ThrowPageLoadCompleteParent");
						break;
					case "ThrowPageLoadCompleteParent":
						break;
					case "SubProcess10":
						break;
					case "PageLoadChild":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadChild");
						break;
					case "ScriptPageLoadChild":
						e.Context.QueueTasks.Enqueue("ThrowScriptPageLoadParent");
						break;
					case "ThrowScriptPageLoadParent":
						break;
					case "SubProcess11":
						break;
					case "GridPageRefreshRowChild":
						e.Context.QueueTasks.Enqueue("ThrowGridPageRefreshRowParent");
						break;
					case "ScriptGridPageRefreshRowChild":
						break;
					case "ThrowGridPageRefreshRowParent":
						e.Context.QueueTasks.Enqueue("ScriptGridPageRefreshRowChild");
						break;
					case "SubProcess9OpenVwSysSchemaInSolution":
						break;
					case "OpenVwSysSchemaInSolution":
						e.Context.QueueTasks.Enqueue("InitOpenLookupUserTaskScript");
						break;
					case "InitOpenLookupUserTaskScript":
						e.Context.QueueTasks.Enqueue("OpenLookupUserTask");
						break;
					case "OpenLookupUserTask":
						ActivatedEventElements.Add("LookupGridPageClosed");
						break;
					case "LookupGridPageClosed":
						e.Context.QueueTasks.Enqueue("ApplyDataScript");
						break;
					case "ApplyDataScript":
						e.Context.QueueTasks.Enqueue("ApplyDataUserTask");
						break;
					case "ApplyDataUserTask":
						break;
					case "OkButtonHandler":
						e.Context.QueueTasks.Enqueue("OkButtonHandlerScriptTask");
						break;
					case "OkButtonHandlerScriptTask":
						break;
					case "SubProcessTreeGridCellIconClick":
						break;
					case "TreeGridCellIconClick":
						e.Context.QueueTasks.Enqueue("ScriptTreeGridCellIconClick");
						break;
					case "ScriptTreeGridCellIconClick":
						break;
					case "SubProcess9DataSourceBeforeLoad":
						break;
					case "DataSourceBeforeLoad":
						e.Context.QueueTasks.Enqueue("ScriptDataSourceBeforeLoad");
						break;
					case "SubProcessDownButtonClick":
						break;
					case "DownButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptDownButtonClick");
						break;
					case "ScriptDownButtonClick":
						break;
					case "UpButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptUpButtonClick");
						break;
					case "ScriptUpButtonClick":
						break;
					case "EventSubProcess10":
						break;
					case "DataSourceLoadRowsChild":
						e.Context.QueueTasks.Enqueue("ScriptDataSourceLoadRowsChild");
						break;
					case "ScriptDataSourceLoadRowsChild":
						break;
					case "EventSubProcess11":
						break;
					case "DataSourceRemovedChild":
						e.Context.QueueTasks.Enqueue("ScriptDataSourceRemovedChild");
						break;
					case "ScriptDataSourceRemovedChild":
						break;
					case "ScriptDataSourceBeforeLoad":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage5");
			ActivatedEventElements.Add("PageLoadChild");
			ActivatedEventElements.Add("GridPageRefreshRowChild");
			ActivatedEventElements.Add("OpenVwSysSchemaInSolution");
			ActivatedEventElements.Add("OkButtonHandler");
			ActivatedEventElements.Add("TreeGridCellIconClick");
			ActivatedEventElements.Add("DataSourceBeforeLoad");
			ActivatedEventElements.Add("DownButtonClick");
			ActivatedEventElements.Add("UpButtonClick");
			ActivatedEventElements.Add("DataSourceLoadRowsChild");
			ActivatedEventElements.Add("DataSourceRemovedChild");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage5":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage5";
					result = StartMessage5.Execute(context);
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
				case "SubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadChild";
					result = PageLoadChild.Execute(context);
					break;
				case "ScriptPageLoadChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPageLoadChild";
					result = ScriptPageLoadChild.Execute(context, ScriptPageLoadChildExecute);
					break;
				case "ThrowScriptPageLoadParent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoad");
					result = ThrowScriptPageLoadParent.Execute(context);
					break;
				case "SubProcess11":
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
				case "ThrowGridPageRefreshRowParent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "GridPageRefreshRow");
					result = ThrowGridPageRefreshRowParent.Execute(context);
					break;
				case "SubProcess9OpenVwSysSchemaInSolution":
					context.QueueTasks.Dequeue();
					break;
				case "OpenVwSysSchemaInSolution":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenVwSysSchemaInSolution";
					result = OpenVwSysSchemaInSolution.Execute(context);
					break;
				case "InitOpenLookupUserTaskScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitOpenLookupUserTaskScript";
					result = InitOpenLookupUserTaskScript.Execute(context, InitOpenLookupUserTaskScriptExecute);
					break;
				case "OpenLookupUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenLookupUserTask";
					result = OpenLookupUserTask.Execute(context);
					break;
				case "LookupGridPageClosed":
					context.QueueTasks.Dequeue();
					context.SenderName = "LookupGridPageClosed";
					result = LookupGridPageClosed.Execute(context);
					break;
				case "ApplyDataScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ApplyDataScript";
					result = ApplyDataScript.Execute(context, ApplyDataScriptExecute);
					break;
				case "ApplyDataUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ApplyDataUserTask";
					result = ApplyDataUserTask.Execute(context);
					break;
				case "OkButtonHandler":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonHandler";
					result = OkButtonHandler.Execute(context);
					break;
				case "OkButtonHandlerScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonHandlerScriptTask";
					result = OkButtonHandlerScriptTask.Execute(context, OkButtonHandlerScriptTaskExecute);
					break;
				case "SubProcessTreeGridCellIconClick":
					context.QueueTasks.Dequeue();
					break;
				case "TreeGridCellIconClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "TreeGridCellIconClick";
					result = TreeGridCellIconClick.Execute(context);
					break;
				case "ScriptTreeGridCellIconClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTreeGridCellIconClick";
					result = ScriptTreeGridCellIconClick.Execute(context, ScriptTreeGridCellIconClickExecute);
					break;
				case "SubProcess9DataSourceBeforeLoad":
					context.QueueTasks.Dequeue();
					break;
				case "DataSourceBeforeLoad":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceBeforeLoad";
					result = DataSourceBeforeLoad.Execute(context);
					break;
				case "SubProcessDownButtonClick":
					context.QueueTasks.Dequeue();
					break;
				case "DownButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "DownButtonClick";
					result = DownButtonClick.Execute(context);
					break;
				case "ScriptDownButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDownButtonClick";
					result = ScriptDownButtonClick.Execute(context, ScriptDownButtonClickExecute);
					break;
				case "UpButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpButtonClick";
					result = UpButtonClick.Execute(context);
					break;
				case "ScriptUpButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptUpButtonClick";
					result = ScriptUpButtonClick.Execute(context, ScriptUpButtonClickExecute);
					break;
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "DataSourceLoadRowsChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceLoadRowsChild";
					result = DataSourceLoadRowsChild.Execute(context);
					break;
				case "ScriptDataSourceLoadRowsChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDataSourceLoadRowsChild";
					result = ScriptDataSourceLoadRowsChild.Execute(context, ScriptDataSourceLoadRowsChildExecute);
					break;
				case "EventSubProcess11":
					context.QueueTasks.Dequeue();
					break;
				case "DataSourceRemovedChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceRemovedChild";
					result = DataSourceRemovedChild.Execute(context);
					break;
				case "ScriptDataSourceRemovedChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDataSourceRemovedChild";
					result = ScriptDataSourceRemovedChild.Execute(context, ScriptDataSourceRemovedChildExecute);
					break;
				case "ScriptDataSourceBeforeLoad":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDataSourceBeforeLoad";
					result = ScriptDataSourceBeforeLoad.Execute(context, ScriptDataSourceBeforeLoadExecute);
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
				case "SubjectSchemaUId":
					SubjectSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "SubjectColumnUId":
					SubjectColumnUId = reader.GetValue<System.Guid>();
				break;
				case "RightsGrouppingColumnNames":
					RightsGrouppingColumnNames = reader.GetValue<System.String>();
				break;
				case "RightsSchemaName":
					RightsSchemaName = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptPageLoadCompleteChildExecute(ProcessExecutingContext context) {
			RightsSchemaName = "SysEntitySchemaColumnRight";
			RightsGrouppingColumnNames = "SubjectColumnUId, SubjectSchemaUId";
			IsDetailGrid = true;
			//Page.AddButton.AjaxEvents.Click.SignalName = "OpenVwSysSchemaInSolution";
			return true;
		}

		public virtual bool ScriptPageLoadChildExecute(ProcessExecutingContext context) {
			Page.TreeGrid.AjaxEvents.CellIconClick.ExtraParameters.Add(new Terrasoft.UI.WebControls.Controls.Parameter("nodeId", "nodeId", Terrasoft.UI.WebControls.Controls.ParameterMode.Raw));
			Page.TreeGrid.AjaxEvents.CellIconClick.SignalName = "TreeGridCellIconClick";
			Page.AddButton.AjaxEvents.Click.SignalName = "OpenVwSysSchemaInSolution";
			Page.TreeGrid.ImageList = "Terrasoft.WebApp";  
			Page.TreeGrid.GetRowConfigHandler = delegate(Terrasoft.Core.Entities.Entity row) {
			   string primaryColumnName = row.Schema.PrimaryColumn.Name;
			   string primaryColumnValue = row.GetColumnValue(primaryColumnName).ToString();
			   var config = new DataSourceRowConfig(primaryColumnValue);
			   string RightLevel = row.GetColumnValue("RightLevelId").ToString().ToUpper();
			   string imageName = RightLevel == "C7EAA3F4-1FE1-DF11-971B-001D60E938C6" ? "Deny.png" : 
								  RightLevel == "C6EAA3F4-1FE1-DF11-971B-001D60E938C6" ? "CanRead.png" : 
								  "CanEdit.png"; 
				var icons = new Dictionary<string, ImageConfigValue>();
				var imageConfig = new ImageConfigValue(imageName);
				imageConfig.DisplayImageOnly = true;
				imageConfig.ImagePosition = ImagePosition.Center;
				icons.Add("RightLevel", imageConfig);
				config.AddConfig(new DataSourceRowColumnIconsConfigValue(icons));
				return config;
			};
			Page.DataSource.Loaded += Page.TreeGrid.DataLoaded;
			return true;
		}

		public virtual bool ScriptGridPageRefreshRowChildExecute(ProcessExecutingContext context) {
			/*var dataSource = Page.DataSource;
			bool enableButtons = (dataSource.Rows.Count > 0);
			var buttonsControlLayout = Page.ButtonsControlLayout;
			if (buttonsControlLayout != null) {
				foreach(var button in buttonsControlLayout.Items) {
					//if (button.Name != "AddButton") {
						button.Enabled = enableButtons;
					//}
				}
			}*/
			return true;
		}

		public virtual bool InitOpenLookupUserTaskScriptExecute(ProcessExecutingContext context) {
			string instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
			OpenLookupUserTask.ProcessKey = instanceId + Page.PageContainer.UniqueID;
			string schemaUId = "D5D01FCD-6D8C-4B29-9E58-CCA3FFE62364";  //SysAdminUnit
			OpenLookupUserTask.PageParameters = new Dictionary <string, object>();
			var pageParameters = (Dictionary <string, object>) OpenLookupUserTask.PageParameters;
			pageParameters.Add("schemaUId", schemaUId);
			Collection<Dictionary<string, object>> filters = new Collection<Dictionary<string, object>>();
			/*filters.Add(new Dictionary<string, object> { 
				 {"comparisonType", FilterComparisonType.Equal},
				 {"leftExpressionColumnPath", "SysSolution"},
				 {"useDisplayValue", false }, 
				 {"rightExpressionParameterValues", new object[] {Page.UserConnection.Solution.Id}}});
			filters.Add(new Dictionary<string, object> { 
				 {"comparisonType", FilterComparisonType.Equal},
				 {"leftExpressionColumnPath", "SysSchemaManagerName"},
				 {"useDisplayValue", false },
				 {"rightExpressionParameterValues", new object[] {"EntitySchemaManager"}}});*/
			pageParameters.Add("LookupFilters", filters);
			pageParameters.Add("hideButtons", true);
			return true;
		}

		public virtual bool ApplyDataScriptExecute(ProcessExecutingContext context) {
			var values = (Dictionary <string, object>)OpenLookupUserTask.GetSelectedValues(UserConnection);
			var schema = UserConnection.EntitySchemaManager.GetInstanceByUId(SubjectSchemaUId);
			try {
				foreach (var sysAdminUnitId in values) {
					var id = UserConnection.DBSecurityEngine.SetEntitySchemaColumnRightLevel(new Guid(sysAdminUnitId.Key), 
						SubjectSchemaUId, SubjectColumnUId, EntitySchemaColumnRightLevel.CanEdit);
					ChangeRightItemPosition(id, 0, true, schema.Name);
				}
				ApplyDataUserTask.MessageText = null;
			} catch (SecurityException securityException) {
				var ls = new LocalizableString("Terrasoft.Core", "DBSecurityEngine.Exception.NoDistributingMoreRightsFor.ColumnThanYouHave");
				var columnCaption = schema.Columns.GetByUId(SubjectColumnUId).Caption;
				ApplyDataUserTask.MessageText = string.Format(ls, string.Concat(schema.Caption, ".", columnCaption));
				ApplyDataUserTask.ProcessInstanceId = InstanceUId;
				ApplyDataUserTask.ResponseMessages = new Dictionary<string, string> {
					{"ok", "OkButtonHandler"},
				};
				ApplyDataUserTask.Icon = "ERROR";
			} finally {
				Page.TreeGrid.RefreshData();
			}
			return true;
		}

		public virtual bool OkButtonHandlerScriptTaskExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ScriptTreeGridCellIconClickExecute(ProcessExecutingContext context) {
			var treeGrid = Page.TreeGrid;
			var selectedNodes = treeGrid.SelectedNodes;
			if (selectedNodes.Count < 1) {
				return true;
			}
			
			Guid canEditRightLevelId = new Guid("007F04EE-1FE1-DF11-971B-001D60E938C6");
			Guid canReadRightLevelId = new Guid("C6EAA3F4-1FE1-DF11-971B-001D60E938C6");
			Guid denyRightLevelId = new Guid("C7EAA3F4-1FE1-DF11-971B-001D60E938C6");
			
			var throwEventArgs = context.ThrowEventArgs as Dictionary<string, object>;
			if (throwEventArgs == null) {
				return true;
			}
			Guid id = Guid.Empty;
			if (throwEventArgs.ContainsKey("nodeId")) { 
				string stringId = (Terrasoft.Common.Json.Json.Deserialize(throwEventArgs["nodeId"].ToString())).ToString();
				Guid.TryParse(stringId, out id);
			}
			
			QueryCase queryCase = new QueryCase();
			QueryCondition queryCondition = new QueryCondition(QueryConditionType.Equal) {
				LeftExpression = new QueryColumnExpression("RightLevelId")
			};
			queryCondition.RightExpressions.Add(Column.Const(canEditRightLevelId));
			queryCase.AddWhenItem(queryCondition, Column.Const(denyRightLevelId));
			
			queryCondition = new QueryCondition(QueryConditionType.Equal) {
				LeftExpression = new QueryColumnExpression("RightLevelId")
			};
			queryCondition.RightExpressions.Add(Column.Const(canReadRightLevelId));
			queryCase.AddWhenItem(queryCondition, Column.Const(canEditRightLevelId));
			
			queryCondition = new QueryCondition(QueryConditionType.Equal) {
				LeftExpression = new QueryColumnExpression("RightLevelId")
			};
			queryCondition.RightExpressions.Add(Column.Const(denyRightLevelId));
			queryCase.AddWhenItem(queryCondition, Column.Const(canReadRightLevelId));
			
			Update update = new Update(Page.UserConnection, Page.DataSource.Schema.Name).
				Set("RightLevelId", new QueryColumnExpression(queryCase)).
				Where("Id").IsEqual(Column.Parameter(id)) as Update;
			update.Execute();
			OperationLogger.Instance.LogEntitySchemaColumnRightEdit(Page.UserConnection, id);
			Page.DataSource.LoadRow(id);
			return true;
		}

		public virtual bool ScriptDownButtonClickExecute(ProcessExecutingContext context) {
			if (Page.TreeGrid.SelectedNodes.Count == 0) {
				return true;
			}
			var selectedNode = Page.TreeGrid.SelectedNodes[0];
			var id = new Guid(selectedNode.Values["Id"].ToString());
			var position = Convert.ToInt32(selectedNode.Values["Position"]) + 1;
			var sysSchemaUId = new Guid(selectedNode.Values["SubjectSchemaUId"].ToString());
			var entitySchemaManager = Page.UserConnection.EntitySchemaManager;
			string subjectSchemaName = entitySchemaManager.GetItemByUId(sysSchemaUId).Name;
			ChangeRightItemPosition(id, position, true, subjectSchemaName);
			OperationLogger.Instance.LogEntitySchemaColumnRightEdit(Page.UserConnection, id);
			Page.TreeGrid.RefreshData();
			return true;
		}

		public virtual bool ScriptUpButtonClickExecute(ProcessExecutingContext context) {
			if (Page.TreeGrid.SelectedNodes.Count == 0) {
				return true;
			}
			var selectedNode = Page.TreeGrid.SelectedNodes[0];
			var id = new Guid(selectedNode.Values["Id"].ToString());
			var position = Convert.ToInt32(selectedNode.Values["Position"]) - 1;
			if (position < 0) {
				return true;
			}
			var sysSchemaUId = new Guid(selectedNode.Values["SubjectSchemaUId"].ToString());
			var entitySchemaManager = Page.UserConnection.EntitySchemaManager;
			string subjectSchemaName = entitySchemaManager.GetItemByUId(sysSchemaUId).Name;
			ChangeRightItemPosition(id, position, false, subjectSchemaName);
			OperationLogger.Instance.LogEntitySchemaColumnRightEdit(Page.UserConnection, id);
			Page.TreeGrid.RefreshData();
			return true;
		}

		public virtual bool ScriptDataSourceLoadRowsChildExecute(ProcessExecutingContext context) {
			if ((context.ThrowEventArgs as DataSourceEventArgs).Request.HierarchicalColumnValue.IsEmpty()) {
				var buttons = GetButtons();
				var dataSourceRowsCount = Page.DataSource.Rows.Count;
				bool addButtonEnabledByRights = true;
				bool deleteButtonEnabledByRights = true;
				bool editButtonEnabledByRights = true;
				bool copyButtonEnabledByRights = true;
				var entitySchema = Page.DataSource.Schema;
				if (entitySchema != null) {
					var dbSecurityEngine = Page.UserConnection.DBSecurityEngine;
					string schemaName = entitySchema.Name;
					deleteButtonEnabledByRights = dbSecurityEngine.GetIsEntitySchemaDeletingAllowed(schemaName);
					addButtonEnabledByRights = dbSecurityEngine.GetIsEntitySchemaAppendingAllowed(schemaName);
					copyButtonEnabledByRights = dbSecurityEngine.GetIsEntitySchemaAppendingAllowed(schemaName);
					editButtonEnabledByRights = dbSecurityEngine.GetIsEntitySchemaEditingAllowed(schemaName);
				}
				foreach(var control in Page.ButtonsControlLayout.Controls) {
					var button = control as Terrasoft.UI.WebControls.Controls.Button;
					if (button != null) {
						if (buttons.Contains(button.Name)) {
							switch (button.Name) {
								case "AddButton":
									button.Enabled = (dataSourceRowsCount > 0) && addButtonEnabledByRights;
								break;
								case "DeleteButton":
									button.Enabled = (dataSourceRowsCount > 0) && deleteButtonEnabledByRights;
								break;
								case "EditButton":
									button.Enabled = (dataSourceRowsCount > 0) && editButtonEnabledByRights;
								break;
								case "CopyButton":
									button.Enabled = (dataSourceRowsCount > 0) && copyButtonEnabledByRights;
								break;
								case "UpButton":
									button.Enabled = (dataSourceRowsCount > 1);
								break;
								case "DownButton":
									button.Enabled = (dataSourceRowsCount > 1);
								break;
								default :
									button.Enabled = (dataSourceRowsCount > 0);
								break;
							}
						} else {
							button.Enabled = true;
						}
					}
				}
			}
			if (!IsDetailGrid) {
				SelectedNodePrimaryColumnValue = Guid.Empty;
				if (Page.DataSource.Rows.Count > 0) {
					SelectedNodePrimaryColumnValue = Page.DataSource.Rows[0].PrimaryColumnValue;
				}
				ListenerThrowEvent(ListenerPageProcessUId, "GridLoadRows");
			}
			return true;
		}

		public virtual bool ScriptDataSourceRemovedChildExecute(ProcessExecutingContext context) {
			ActivateButtons(true);
			return true;
		}

		public virtual bool ScriptDataSourceBeforeLoadExecute(ProcessExecutingContext context) {
			Page.TreeGrid.ImageList = "Terrasoft.WebApp";  
			Page.TreeGrid.GetRowConfigHandler =
			delegate(Terrasoft.Core.Entities.Entity row) {
			   string primaryColumnName = row.Schema.PrimaryColumn.Name;
			   string primaryColumnValue = row.GetColumnValue(primaryColumnName).ToString();
			   var config = new DataSourceRowConfig(primaryColumnValue);
			   string RightLevel = row.GetColumnValue("RightLevelId").ToString().ToUpper();
			   string imageName = RightLevel == "C7EAA3F4-1FE1-DF11-971B-001D60E938C6" ? "Deny.png" : 
								  RightLevel == "C6EAA3F4-1FE1-DF11-971B-001D60E938C6" ? "CanRead.png" : 
								  "CanEdit.png"; 
				var icons = new Dictionary<string, ImageConfigValue>();
				icons.Add("RightLevel", new ImageConfigValue(imageName));
				config.AddConfig(new DataSourceRowColumnIconsConfigValue(icons));
				return config;
			};
			Page.DataSource.Loaded +=
			   Page.TreeGrid.DataLoaded;
			return true;
		}

		public override System.Collections.Generic.List<string> GetButtons() {
			var buttons = new System.Collections.Generic.List<string>();
			buttons.Add(Page.AddButton.Name);
			buttons.Add(Page.EditButton.Name);
			buttons.Add(Page.CopyButton.Name);
			buttons.Add(Page.DeleteButton.Name);
			buttons.Add(Page.UpButton.Name);
			buttons.Add(Page.DownButton.Name);
			buttons.Add(Page.PrintButton.Name);
			return buttons;
		}

		public override void ActivateButtons(bool activate) {
			var buttons = GetButtons();
			var dataSourceRowsCount = Page.DataSource.ActiveRowPrimaryColumnValue == Guid.Empty || !activate ? 0 : 1;
			bool addButtonEnabledByRights = true;
			bool deleteButtonEnabledByRights = true;
			bool editButtonEnabledByRights = true;
			bool copyButtonEnabledByRights = true;
			var entitySchema = Page.DataSource.Schema;
			base.ActivateButtons(activate);
			var canChangeRight = UserConnection.DBSecurityEngine.GetCanExecuteOperation("CanChangeEntitySchemaRecordDefRight");
			if ((IsDetailGrid && SubjectColumnUId == Guid.Empty) || !canChangeRight) {
				foreach(var control in Page.ButtonsControlLayout.Controls) {
					var button = control as Terrasoft.UI.WebControls.Controls.Button;
					if ((button != null) && (string.CompareOrdinal(button.Name, "ContextHelpButton") != 0)) {
						button.Enabled = false;		
					}
				}
			}
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public virtual void ChangeRightItemPosition(Guid primaryColumnValue, int position, bool increasePosition, string subjectSchemaName) {
			if (string.IsNullOrEmpty(RightsSchemaName) || string.IsNullOrEmpty(RightsGrouppingColumnNames)) {
				return;
			}
			//position = DeterminePositionForMove(position, increasePosition, subjectSchemaName);
			StoredProcedure setRecordPositionProcedure = new StoredProcedure(Page.UserConnection, "tsp_SetRecordPosition")
				.WithParameter("TableName", RightsSchemaName)
				.WithParameter("PrimaryColumnName", "Id")
				.WithParameter("PrimaryColumnValue", primaryColumnValue)
				.WithParameter("GrouppingColumnNames", RightsGrouppingColumnNames)
				.WithParameter("Position", position) as StoredProcedure;
			setRecordPositionProcedure.PackageName = Page.UserConnection.DBEngine.SystemPackageName;
			setRecordPositionProcedure.Execute();
		}

		public virtual int DeterminePositionForMove(int sourcePosition, bool doIncreasePosition, string sourceSubjectName) {
			return 0;
		}

		public override string GetRegisterEditPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return string.Empty;
		}

		public override string GetRegisterCopyPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return string.Empty;
		}

		public override string GetRegisterAddPageScript(Guid editPageUId, Guid sysModuleEditId, Guid typeId) {
			return string.Empty;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessage5")) {
							context.QueueTasks.Enqueue("StartMessage5");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoad":
							if (ActivatedEventElements.Contains("PageLoadChild")) {
							context.QueueTasks.Enqueue("PageLoadChild");
						}
						break;
					case "GridPageRefreshRow":
							if (ActivatedEventElements.Contains("GridPageRefreshRowChild")) {
							context.QueueTasks.Enqueue("GridPageRefreshRowChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "OpenVwSysSchemaInSolution":
							if (ActivatedEventElements.Contains("OpenVwSysSchemaInSolution")) {
							context.QueueTasks.Enqueue("OpenVwSysSchemaInSolution");
						}
						break;
					case "LookupGridPageClosed":
					if (ActivatedEventElements.Remove("LookupGridPageClosed")) {
						context.QueueTasks.Enqueue("LookupGridPageClosed");
					}
					break;
					case "OkButtonHandler":
							if (ActivatedEventElements.Contains("OkButtonHandler")) {
							context.QueueTasks.Enqueue("OkButtonHandler");
						}
						break;
					case "TreeGridCellIconClick":
							if (ActivatedEventElements.Contains("TreeGridCellIconClick")) {
							context.QueueTasks.Enqueue("TreeGridCellIconClick");
						}
						break;
					case "DataSourceBeforeLoad":
							if (ActivatedEventElements.Contains("DataSourceBeforeLoad")) {
							context.QueueTasks.Enqueue("DataSourceBeforeLoad");
						}
						break;
					case "DownButtonClick":
							if (ActivatedEventElements.Contains("DownButtonClick")) {
							context.QueueTasks.Enqueue("DownButtonClick");
						}
						break;
					case "UpButtonClick":
							if (ActivatedEventElements.Contains("UpButtonClick")) {
							context.QueueTasks.Enqueue("UpButtonClick");
						}
						break;
					case "DataSourceLoadRows":
							if (ActivatedEventElements.Contains("DataSourceLoadRowsChild")) {
							context.QueueTasks.Enqueue("DataSourceLoadRowsChild");
						}
						break;
					case "DataSourceRemoved":
							if (ActivatedEventElements.Contains("DataSourceRemovedChild")) {
							context.QueueTasks.Enqueue("DataSourceRemovedChild");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("SubjectSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SubjectSchemaUId", SubjectSchemaUId, Guid.Empty);
			}
			if (!HasMapping("SubjectColumnUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SubjectColumnUId", SubjectColumnUId, Guid.Empty);
			}
			if (!HasMapping("RightsGrouppingColumnNames") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("RightsGrouppingColumnNames", RightsGrouppingColumnNames, null);
			}
			if (!HasMapping("RightsSchemaName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("RightsSchemaName", RightsSchemaName, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeObjectColumnRightsGridPageEventsProcess

	/// <exclude/>
	public class AdministrativeObjectColumnRightsGridPageEventsProcess : AdministrativeObjectColumnRightsGridPageEventsProcess<Terrasoft.WebApp.AdministrativeObjectColumnRightsGridPageSchemaUserControl>
	{

		public AdministrativeObjectColumnRightsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdministrativeObjectColumnRightsGridPageSchemaUserControl

	/// <exclude/>
	public partial class AdministrativeObjectColumnRightsGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.Button UpButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("UpButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button DownButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("DownButton", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			UpButton.AjaxEvents.Click.Event += UpButtonClick;
			DownButton.AjaxEvents.Click.Event += DownButtonClick;
			TreeGrid.AjaxEvents.CellIconClick.Event += TreeGridCellIconClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			UpButton.AjaxEvents.Click.Event -= UpButtonClick;
			DownButton.AjaxEvents.Click.Event -= DownButtonClick;
			TreeGrid.AjaxEvents.CellIconClick.Event -= TreeGridCellIconClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (AdministrativeObjectColumnRightsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AdministrativeObjectColumnRightsGridPageEventsProcess(UserConnection);
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

		public virtual void UpButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("UpButtonClick");
		}

		public virtual void DownButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("DownButtonClick");
		}

		public virtual void TreeGridCellIconClick(object sender, EventArgs e) {
			object result = ThrowEvent("TreeGridCellIconClick");
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
			SchemaName = "AdministrativeObjectColumnRightsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeObjectColumnRightsGridPageEventsProcessSchema

	/// <exclude/>
	public class AdministrativeObjectColumnRightsGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public AdministrativeObjectColumnRightsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AdministrativeObjectColumnRightsGridPageEventsProcessSchema(AdministrativeObjectColumnRightsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AdministrativeObjectColumnRightsGridPageEventsProcess";
			UId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5");
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

		protected virtual ProcessSchemaParameter CreateRightsSchemaNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e9bb44a2-2f6a-4a91-83b3-44368ca347ce"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"RightsSchemaName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateRightsGrouppingColumnNamesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("12c458f6-86a9-4810-bb17-5aea5148816e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"RightsGrouppingColumnNames",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSubjectColumnUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0f8461a2-b7d8-428e-bfb9-6d3472285840"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"SubjectColumnUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSubjectSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d107c42c-88ff-44b6-bf9c-3eefe7ef3854"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"SubjectSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateRightsSchemaNameParameter());
			Parameters.Add(CreateRightsGrouppingColumnNamesParameter());
			Parameters.Add(CreateSubjectColumnUIdParameter());
			Parameters.Add(CreateSubjectSchemaUIdParameter());
		}

		protected virtual void InitializeOpenLookupUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("2ff77614-c964-4d36-9a75-d05249de96e7"),
				ContainerUId = new Guid("d8a70e1a-74ff-4523-9030-8883ca939300"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("fe920c4d-427b-4df0-863a-9406886b4a56"),
				ContainerUId = new Guid("d8a70e1a-74ff-4523-9030-8883ca939300"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("aad24e91-bc86-4262-9d0f-b6d8761a1afe"),
				ContainerUId = new Guid("d8a70e1a-74ff-4523-9030-8883ca939300"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("542f8d00-e6a1-4175-9340-ce010fa7573d"),
				ContainerUId = new Guid("d8a70e1a-74ff-4523-9030-8883ca939300"),
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

		protected virtual void InitializeApplyDataUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("2e6bb2ab-4682-4c05-961a-66fe13c82f46"),
				ContainerUId = new Guid("c8fc346b-ae73-48f1-924e-b1077f140def"),
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
				UId = new Guid("0d2b95a5-011c-46d3-a080-d5b3baf994d1"),
				ContainerUId = new Guid("c8fc346b-ae73-48f1-924e-b1077f140def"),
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
				UId = new Guid("fd66b507-cab5-428a-8266-6bce24a2d950"),
				ContainerUId = new Guid("c8fc346b-ae73-48f1-924e-b1077f140def"),
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
				UId = new Guid("3d4db002-0724-4430-b37c-79f9d98927f7"),
				ContainerUId = new Guid("c8fc346b-ae73-48f1-924e-b1077f140def"),
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
				UId = new Guid("1f4ee61a-5507-41e5-99d1-875d0631b6bc"),
				ContainerUId = new Guid("c8fc346b-ae73-48f1-924e-b1077f140def"),
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
				UId = new Guid("228a299b-a379-4690-b05c-b0e1bc074f38"),
				ContainerUId = new Guid("c8fc346b-ae73-48f1-924e-b1077f140def"),
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
				UId = new Guid("eab332b1-fe0f-4131-9c7a-724f2d20dec4"),
				ContainerUId = new Guid("c8fc346b-ae73-48f1-924e-b1077f140def"),
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
				UId = new Guid("2a4f8127-36ba-48e8-a6db-268fb686cd38"),
				ContainerUId = new Guid("c8fc346b-ae73-48f1-924e-b1077f140def"),
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
			ProcessSchemaLaneSet schemaLaneSet481 = CreateLaneSet481LaneSet();
			LaneSets.Add(schemaLaneSet481);
			ProcessSchemaLane schemaLane1565 = CreateLane1565Lane();
			schemaLaneSet481.Lanes.Add(schemaLane1565);
			ProcessSchemaEventSubProcess subprocess9 = CreateSubProcess9EventSubProcess();
			FlowElements.Add(subprocess9);
			ProcessSchemaEventSubProcess subprocess10 = CreateSubProcess10EventSubProcess();
			FlowElements.Add(subprocess10);
			ProcessSchemaEventSubProcess subprocess11 = CreateSubProcess11EventSubProcess();
			FlowElements.Add(subprocess11);
			ProcessSchemaEventSubProcess subprocess9openvwsysschemainsolution = CreateSubProcess9OpenVwSysSchemaInSolutionEventSubProcess();
			FlowElements.Add(subprocess9openvwsysschemainsolution);
			ProcessSchemaEventSubProcess subprocesstreegridcelliconclick = CreateSubProcessTreeGridCellIconClickEventSubProcess();
			FlowElements.Add(subprocesstreegridcelliconclick);
			ProcessSchemaEventSubProcess subprocess9datasourcebeforeload = CreateSubProcess9DataSourceBeforeLoadEventSubProcess();
			FlowElements.Add(subprocess9datasourcebeforeload);
			ProcessSchemaEventSubProcess subprocessdownbuttonclick = CreateSubProcessDownButtonClickEventSubProcess();
			FlowElements.Add(subprocessdownbuttonclick);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaEventSubProcess eventsubprocess11 = CreateEventSubProcess11EventSubProcess();
			FlowElements.Add(eventsubprocess11);
			ProcessSchemaStartMessageEvent startmessage5 = CreateStartMessage5StartMessageEvent();
			subprocess9.FlowElements.Add(startmessage5);
			ProcessSchemaScriptTask scriptpageloadcompletechild = CreateScriptPageLoadCompleteChildScriptTask();
			subprocess9.FlowElements.Add(scriptpageloadcompletechild);
			ProcessSchemaIntermediateThrowMessageEvent throwpageloadcompleteparent = CreateThrowPageLoadCompleteParentIntermediateThrowMessageEvent();
			subprocess9.FlowElements.Add(throwpageloadcompleteparent);
			ProcessSchemaStartMessageEvent pageloadchild = CreatePageLoadChildStartMessageEvent();
			subprocess10.FlowElements.Add(pageloadchild);
			ProcessSchemaScriptTask scriptpageloadchild = CreateScriptPageLoadChildScriptTask();
			subprocess10.FlowElements.Add(scriptpageloadchild);
			ProcessSchemaIntermediateThrowMessageEvent throwscriptpageloadparent = CreateThrowScriptPageLoadParentIntermediateThrowMessageEvent();
			subprocess10.FlowElements.Add(throwscriptpageloadparent);
			ProcessSchemaStartMessageEvent gridpagerefreshrowchild = CreateGridPageRefreshRowChildStartMessageEvent();
			subprocess11.FlowElements.Add(gridpagerefreshrowchild);
			ProcessSchemaScriptTask scriptgridpagerefreshrowchild = CreateScriptGridPageRefreshRowChildScriptTask();
			subprocess11.FlowElements.Add(scriptgridpagerefreshrowchild);
			ProcessSchemaIntermediateThrowMessageEvent throwgridpagerefreshrowparent = CreateThrowGridPageRefreshRowParentIntermediateThrowMessageEvent();
			subprocess11.FlowElements.Add(throwgridpagerefreshrowparent);
			ProcessSchemaStartMessageEvent openvwsysschemainsolution = CreateOpenVwSysSchemaInSolutionStartMessageEvent();
			subprocess9openvwsysschemainsolution.FlowElements.Add(openvwsysschemainsolution);
			ProcessSchemaScriptTask initopenlookupusertaskscript = CreateInitOpenLookupUserTaskScriptScriptTask();
			subprocess9openvwsysschemainsolution.FlowElements.Add(initopenlookupusertaskscript);
			ProcessSchemaUserTask openlookupusertask = CreateOpenLookupUserTaskUserTask();
			subprocess9openvwsysschemainsolution.FlowElements.Add(openlookupusertask);
			ProcessSchemaIntermediateCatchMessageEvent lookupgridpageclosed = CreateLookupGridPageClosedIntermediateCatchMessageEvent();
			subprocess9openvwsysschemainsolution.FlowElements.Add(lookupgridpageclosed);
			ProcessSchemaScriptTask applydatascript = CreateApplyDataScriptScriptTask();
			subprocess9openvwsysschemainsolution.FlowElements.Add(applydatascript);
			ProcessSchemaUserTask applydatausertask = CreateApplyDataUserTaskUserTask();
			subprocess9openvwsysschemainsolution.FlowElements.Add(applydatausertask);
			ProcessSchemaStartMessageEvent okbuttonhandler = CreateOkButtonHandlerStartMessageEvent();
			subprocess9openvwsysschemainsolution.FlowElements.Add(okbuttonhandler);
			ProcessSchemaScriptTask okbuttonhandlerscripttask = CreateOkButtonHandlerScriptTaskScriptTask();
			subprocess9openvwsysschemainsolution.FlowElements.Add(okbuttonhandlerscripttask);
			ProcessSchemaStartMessageEvent treegridcelliconclick = CreateTreeGridCellIconClickStartMessageEvent();
			subprocesstreegridcelliconclick.FlowElements.Add(treegridcelliconclick);
			ProcessSchemaScriptTask scripttreegridcelliconclick = CreateScriptTreeGridCellIconClickScriptTask();
			subprocesstreegridcelliconclick.FlowElements.Add(scripttreegridcelliconclick);
			ProcessSchemaStartMessageEvent datasourcebeforeload = CreateDataSourceBeforeLoadStartMessageEvent();
			subprocess9datasourcebeforeload.FlowElements.Add(datasourcebeforeload);
			ProcessSchemaStartMessageEvent downbuttonclick = CreateDownButtonClickStartMessageEvent();
			subprocessdownbuttonclick.FlowElements.Add(downbuttonclick);
			ProcessSchemaScriptTask scriptdownbuttonclick = CreateScriptDownButtonClickScriptTask();
			subprocessdownbuttonclick.FlowElements.Add(scriptdownbuttonclick);
			ProcessSchemaStartMessageEvent upbuttonclick = CreateUpButtonClickStartMessageEvent();
			subprocessdownbuttonclick.FlowElements.Add(upbuttonclick);
			ProcessSchemaScriptTask scriptupbuttonclick = CreateScriptUpButtonClickScriptTask();
			subprocessdownbuttonclick.FlowElements.Add(scriptupbuttonclick);
			ProcessSchemaStartMessageEvent datasourceloadrowschild = CreateDataSourceLoadRowsChildStartMessageEvent();
			eventsubprocess10.FlowElements.Add(datasourceloadrowschild);
			ProcessSchemaScriptTask scriptdatasourceloadrowschild = CreateScriptDataSourceLoadRowsChildScriptTask();
			eventsubprocess10.FlowElements.Add(scriptdatasourceloadrowschild);
			ProcessSchemaStartMessageEvent datasourceremovedchild = CreateDataSourceRemovedChildStartMessageEvent();
			eventsubprocess11.FlowElements.Add(datasourceremovedchild);
			ProcessSchemaScriptTask scriptdatasourceremovedchild = CreateScriptDataSourceRemovedChildScriptTask();
			eventsubprocess11.FlowElements.Add(scriptdatasourceremovedchild);
			ProcessSchemaScriptTask scriptdatasourcebeforeload = CreateScriptDataSourceBeforeLoadScriptTask();
			FlowElements.Add(scriptdatasourcebeforeload);
			FlowElements.Add(CreateSequenceFlow9212SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9213SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9214SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9215SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9216SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9217SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9218SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9219SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9220SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9221SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9222SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9223SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9224SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9225SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9226SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9227SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9212SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9212",
				UId = new Guid("b39a2ae4-eb3e-463d-bfa7-0148964a10b3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8edae77f-59ec-45f5-b8b5-687072fdde7e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f1dcf5ef-cf7b-465c-8e9a-5b6108da1d29"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9213SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9213",
				UId = new Guid("f48f80a8-4276-4d35-a59a-47995efa27f0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("930e1a33-c94b-4a38-9b2a-e05892b7fa42"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5d4cd314-11b9-46dd-91ed-bd9a622b2525"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9214SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9214",
				UId = new Guid("c8c42655-2e98-4f84-905c-65337af73470"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ce53c96c-9d51-4f05-969e-bbbe8ab7bf8c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9664da22-ef37-447d-9838-09bdd7b632ca"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9215SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9215",
				UId = new Guid("8290f4c0-7fd9-4ebc-9546-e0c98e9b4a0c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ef5f6a9a-25d4-4cdc-8923-0c13d180da24"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7e4c7151-cfb3-4ae1-9d51-2b8dfd433aa4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9216SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9216",
				UId = new Guid("4c61e5fa-ba8a-4c84-b84c-76edc9e2ef6f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				CurveCenterPosition = new Point(152, 2299),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9b356a50-be2f-4a6b-a1ed-89664972f2e3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b5ef33b9-a85a-4b1a-955a-85aa3adc721c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9217SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9217",
				UId = new Guid("5caa86ae-d885-4edf-ac3d-82c8354a093b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				CurveCenterPosition = new Point(282, 2297),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b5ef33b9-a85a-4b1a-955a-85aa3adc721c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d8a70e1a-74ff-4523-9030-8883ca939300"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(228, 468));
			schemaFlow.PolylinePointPositions.Add(new Point(228, 465));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9218SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9218",
				UId = new Guid("8c563189-1de1-401a-8fda-4f21dc20a415"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				CurveCenterPosition = new Point(394, 2296),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d8a70e1a-74ff-4523-9030-8883ca939300"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ca1c7b34-15f5-4ad3-8995-de4d0a920a47"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9219SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9219",
				UId = new Guid("9d82b52c-8e3a-46c4-a8a5-0e2c44013e91"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				CurveCenterPosition = new Point(478, 2297),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ca1c7b34-15f5-4ad3-8995-de4d0a920a47"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("019cce6c-9d9d-40af-9ba1-f84df4cae5c3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9220SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9220",
				UId = new Guid("81364b7c-da88-4923-bf61-9c9cc3e9a64e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				CurveCenterPosition = new Point(150, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8e504483-8d1b-4ee1-9721-1d7285098408"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fb4e0526-981c-425e-a82d-349a55517837"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9221SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9221",
				UId = new Guid("8008481c-b07c-4113-8070-4078adb72048"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				CurveCenterPosition = new Point(154, 280),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("010373b4-9d4c-4000-bef9-76f2d94eed9c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("758359a3-a4bd-4058-adb1-672b97f273d1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9222SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9222",
				UId = new Guid("abc8249f-3ded-4a48-9b20-f03912998e2a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				CurveCenterPosition = new Point(269, 282),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("758359a3-a4bd-4058-adb1-672b97f273d1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("99be1677-3cf3-4214-ba9e-48e79cfcd61a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9223SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9223",
				UId = new Guid("50035ec2-3a0a-4d98-a84b-230085d8b4ab"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				CurveCenterPosition = new Point(268, 93),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fb4e0526-981c-425e-a82d-349a55517837"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("595ea418-4318-40ba-8c90-fe99ae05a0f0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9224SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9224",
				UId = new Guid("f52a5d72-66a0-4fba-8655-e76b2fa489c9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				CurveCenterPosition = new Point(213, 458),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6178f0b4-597d-4aed-864a-596cb61cafac"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b6444541-1e30-4a6a-be62-df952e18c460"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9225SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9225",
				UId = new Guid("9023aa9b-e34e-4771-9e93-3673cede3b09"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				CurveCenterPosition = new Point(230, 463),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b6444541-1e30-4a6a-be62-df952e18c460"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("486798a4-29f5-47d5-940d-087222e2c479"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9226SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9226",
				UId = new Guid("2dd8cbef-70d1-4795-b4bf-90214a123364"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				CurveCenterPosition = new Point(156, 1098),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f782b455-f099-4316-be36-1d2fd1cb8067"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("60007875-fe3c-4710-9f99-5a3decbfa860"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9227SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9227",
				UId = new Guid("a74f1b05-6c04-43c5-827d-598e34878138"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				CurveCenterPosition = new Point(364, 1102),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dff9c88b-ffd8-4f87-9214-4335fbb41041"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6d412b4f-f4bb-4975-b613-0d3dd083d941"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("f3dd6c96-ad4a-4137-b543-cb6acb79518b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				CurveCenterPosition = new Point(618, 471),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("019cce6c-9d9d-40af-9ba1-f84df4cae5c3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c8fc346b-ae73-48f1-924e-b1077f140def"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("14920e19-4375-4120-a281-b3bf988d8f8d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				CurveCenterPosition = new Point(816, 470),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e11c3c21-3bd2-44b5-a3a0-4684809cd761"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e4b9d97a-4a6e-4a8c-bccf-cc77039815b4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet481LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet481 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("f87fe391-601b-4dd0-a74a-9b829888a9e0"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"LaneSet481",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1005, 1188),
				UseBackgroundMode = false
			};
			return schemaLaneSet481;
		}

		protected virtual ProcessSchemaLane CreateLane1565Lane() {
			ProcessSchemaLane schemaLane1565 = new ProcessSchemaLane(this) {
				UId = new Guid("c9169d94-71b5-4355-94aa-26bb16efaea8"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("f87fe391-601b-4dd0-a74a-9b829888a9e0"),
				CreatedInOwnerSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"Lane1565",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(976, 184),
				UseBackgroundMode = false
			};
			return schemaLane1565;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7a8132bd-d508-43fd-b6d0-526f70338ad5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c9169d94-71b5-4355-94aa-26bb16efaea8"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"SubProcess9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 16),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(318, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage5StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8e504483-8d1b-4ee1-9721-1d7285098408"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7a8132bd-d508-43fd-b6d0-526f70338ad5"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"StartMessage5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(21, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadCompleteChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("fb4e0526-981c-425e-a82d-349a55517837"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7a8132bd-d508-43fd-b6d0-526f70338ad5"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"ScriptPageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(105, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,53,142,193,14,130,48,12,134,239,38,190,3,225,108,198,3,24,15,136,132,112,81,3,209,251,132,6,138,163,35,91,167,242,246,14,166,183,230,107,255,175,127,133,93,207,182,110,122,24,229,89,142,16,29,162,184,158,109,78,140,60,7,156,105,229,70,170,150,195,120,191,221,172,131,45,140,118,211,132,212,133,237,18,181,107,214,61,6,104,56,208,91,217,238,162,31,9,46,79,22,71,105,79,192,18,85,97,176,245,41,54,14,60,77,146,171,236,64,164,109,123,116,204,154,68,58,200,79,254,2,98,43,50,133,205,83,212,216,145,84,255,158,151,9,232,254,246,109,131,187,164,218,127,101,212,180,188,48,192,206,80,80,127,1,31,183,52,230,229,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowPageLoadCompleteParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("595ea418-4318-40ba-8c90-fe99ae05a0f0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7a8132bd-d508-43fd-b6d0-526f70338ad5"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"ThrowPageLoadCompleteParent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(224, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1b0c0949-23e1-4188-aed7-77970a575bb4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c9169d94-71b5-4355-94aa-26bb16efaea8"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"SubProcess10",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(358, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(317, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("010373b4-9d4c-4000-bef9-76f2d94eed9c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1b0c0949-23e1-4188-aed7-77970a575bb4"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"PageLoadChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("758359a3-a4bd-4058-adb1-672b97f273d1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1b0c0949-23e1-4188-aed7-77970a575bb4"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"ScriptPageLoadChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(85, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,81,111,155,48,16,126,110,165,254,7,139,39,162,53,86,80,167,116,93,214,77,41,161,109,164,108,141,66,218,61,123,112,165,222,136,141,140,73,138,166,253,247,157,13,36,144,100,82,199,147,241,221,247,249,251,206,119,158,179,4,232,82,1,220,41,30,211,241,79,246,26,172,65,232,156,250,144,166,211,72,10,63,229,209,47,26,188,106,197,230,76,177,21,104,80,57,29,199,177,43,96,67,150,160,20,203,229,179,166,143,83,250,29,126,248,82,104,37,83,132,55,139,45,200,117,132,140,97,26,59,231,100,183,250,15,252,87,196,208,5,219,244,122,163,179,211,249,219,100,135,60,17,44,253,134,4,228,154,56,77,126,39,199,105,216,208,210,77,161,181,20,29,186,35,52,15,25,136,167,77,88,230,97,244,2,43,54,21,161,76,11,205,165,112,14,132,77,87,248,59,227,185,182,199,111,189,162,209,113,150,57,35,66,246,1,119,160,23,114,131,230,159,121,114,207,68,156,130,66,104,12,41,36,76,131,187,163,240,165,2,26,8,205,53,135,188,90,148,68,201,77,143,252,62,59,37,132,228,90,113,145,144,76,241,21,83,165,143,10,87,162,54,128,89,180,146,78,231,237,48,53,241,209,63,209,79,44,45,26,56,202,108,109,186,7,167,244,232,82,134,150,195,237,85,140,107,166,72,100,109,33,133,233,156,9,211,44,148,133,138,96,107,216,61,60,175,215,209,179,224,201,139,158,193,26,210,227,58,156,93,2,118,87,91,4,46,31,179,12,155,176,75,200,205,253,212,101,105,147,227,109,249,151,193,120,124,113,251,190,239,221,6,94,127,114,235,121,253,171,75,239,166,63,24,120,147,225,32,184,186,248,224,15,29,242,133,56,19,16,37,205,68,226,144,143,120,157,39,230,35,7,100,195,55,146,249,76,44,128,197,7,124,38,16,196,92,219,192,200,236,155,130,114,172,104,222,212,147,71,166,7,177,124,159,42,115,231,196,118,95,85,90,91,159,207,214,125,133,220,133,106,252,126,178,187,173,141,5,181,0,116,194,243,44,101,165,69,60,136,180,68,6,173,10,216,79,179,241,185,204,185,209,133,57,157,127,28,84,129,67,109,49,198,133,125,81,90,247,135,111,67,139,203,74,168,218,199,36,214,237,114,164,141,76,47,152,209,206,59,78,204,134,125,54,78,20,232,66,137,186,19,113,227,79,51,178,59,30,58,147,44,134,152,188,187,38,221,217,52,41,85,12,65,53,145,245,253,23,35,173,83,225,68,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowScriptPageLoadParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("99be1677-3cf3-4214-ba9e-48e79cfcd61a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1b0c0949-23e1-4188-aed7-77970a575bb4"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"ThrowScriptPageLoadParent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(225, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("00a71c1e-9025-4b42-90f8-52f16c03dcb7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c9169d94-71b5-4355-94aa-26bb16efaea8"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"SubProcess11",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 191),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(325, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateGridPageRefreshRowChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6178f0b4-597d-4aed-864a-596cb61cafac"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("00a71c1e-9025-4b42-90f8-52f16c03dcb7"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"GridPageRefreshRow",
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"GridPageRefreshRowChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptGridPageRefreshRowChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("486798a4-29f5-47d5-940d-087222e2c479"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("00a71c1e-9025-4b42-90f8-52f16c03dcb7"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"ScriptGridPageRefreshRowChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(196, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,143,205,10,194,48,16,132,207,205,83,172,61,213,30,82,239,161,130,127,7,65,68,244,9,210,118,171,66,204,66,186,81,68,250,238,246,71,45,66,175,187,51,223,204,36,241,93,59,40,52,235,19,121,151,35,164,112,208,103,148,235,223,69,137,140,200,0,90,157,25,92,122,102,178,85,163,138,6,143,60,210,163,146,43,242,150,97,14,179,169,18,45,51,235,165,43,178,236,200,236,244,147,60,127,233,203,145,159,18,215,18,162,81,215,36,5,235,141,153,194,75,4,37,57,212,249,37,26,34,224,106,71,195,228,150,241,86,117,166,32,73,6,184,220,235,27,182,204,112,81,20,125,147,176,87,5,31,193,166,219,90,52,109,255,86,171,14,84,139,160,22,117,156,8,135,236,157,5,118,30,213,27,192,145,99,193,71,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowGridPageRefreshRowParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("b6444541-1e30-4a6a-be62-df952e18c460"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("00a71c1e-9025-4b42-90f8-52f16c03dcb7"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"GridPageRefreshRow",
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"ThrowGridPageRefreshRowParent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess9OpenVwSysSchemaInSolutionEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess9OpenVwSysSchemaInSolution = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b6173a01-f02a-4a83-8fef-713a069ef368"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c9169d94-71b5-4355-94aa-26bb16efaea8"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"SubProcess9OpenVwSysSchemaInSolution",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 378),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(927, 175),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess9OpenVwSysSchemaInSolution;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOpenVwSysSchemaInSolutionStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9b356a50-be2f-4a6b-a1ed-89664972f2e3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b6173a01-f02a-4a83-8fef-713a069ef368"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OpenVwSysSchemaInSolution",
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"OpenVwSysSchemaInSolution",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(14, 77),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitOpenLookupUserTaskScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b5ef33b9-a85a-4b1a-955a-85aa3adc721c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b6173a01-f02a-4a83-8fef-713a069ef368"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"InitOpenLookupUserTaskScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,82,91,111,211,48,20,126,102,210,254,131,229,167,116,180,46,236,82,109,218,152,212,37,169,20,113,171,212,22,30,16,15,94,114,218,154,57,118,230,11,16,85,249,239,216,78,215,181,213,128,137,39,94,44,217,58,223,213,71,27,197,196,2,49,161,13,21,57,100,5,122,131,162,104,10,74,81,45,231,134,204,50,242,25,110,99,41,140,146,92,147,49,93,64,199,31,100,168,171,112,33,217,6,74,166,114,18,232,162,206,229,225,193,199,10,196,59,41,239,108,53,211,160,166,84,223,145,177,146,57,104,253,22,106,167,178,37,249,18,5,74,127,120,37,202,4,40,50,19,236,222,66,150,56,42,221,154,212,249,18,74,58,11,30,113,114,150,188,122,61,138,147,222,32,57,143,123,167,55,199,23,189,139,244,236,188,23,199,195,147,209,40,29,28,159,12,78,241,37,66,253,254,164,214,195,162,100,194,17,154,167,109,57,221,49,85,180,4,3,74,59,114,1,63,80,194,114,195,164,160,170,70,87,173,126,23,201,219,111,144,155,235,16,239,59,85,168,218,7,70,127,64,117,208,95,165,29,237,46,37,25,22,69,132,55,185,113,247,177,3,239,33,150,156,67,16,188,122,20,222,215,189,70,115,198,183,130,61,15,20,50,246,143,214,208,224,99,183,149,125,4,90,161,195,131,23,104,133,115,89,86,84,49,45,197,180,174,192,89,30,5,142,120,231,153,164,247,150,242,166,219,66,56,204,77,250,179,82,110,55,28,185,51,104,75,49,166,102,233,192,216,253,222,196,61,120,85,252,48,111,53,36,76,87,156,214,159,40,183,94,99,78,185,6,212,116,215,30,20,91,44,183,24,55,133,134,113,237,230,125,150,214,248,151,175,104,21,182,207,255,137,219,62,209,118,67,30,68,73,86,52,77,227,219,248,63,186,8,255,255,158,10,103,89,125,112,169,158,81,202,63,117,130,83,97,152,169,119,244,112,104,226,168,255,244,154,182,171,221,38,244,124,235,190,58,191,217,234,37,43,224,198,26,35,133,31,54,202,130,159,84,96,172,18,225,234,110,191,0,26,61,59,91,158,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenLookupUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("d8a70e1a-74ff-4523-9030-8883ca939300"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b6173a01-f02a-4a83-8fef-713a069ef368"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"OpenLookupUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(218, 60),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenLookupUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateLookupGridPageClosedIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("ca1c7b34-15f5-4ad3-8995-de4d0a920a47"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b6173a01-f02a-4a83-8fef-713a069ef368"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"BoundaryEvent",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"LookupGridPageClosed",
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"LookupGridPageClosed",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(330, 74),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateApplyDataScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("019cce6c-9d9d-40af-9ba1-f84df4cae5c3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b6173a01-f02a-4a83-8fef-713a069ef368"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"ApplyDataScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(421, 60),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,209,110,218,48,20,125,166,82,255,193,202,83,34,69,214,222,187,86,42,129,209,104,80,16,129,73,123,52,206,5,60,28,59,178,29,214,172,234,191,239,218,33,108,180,104,218,3,138,184,215,247,156,115,143,143,143,204,144,35,147,13,88,114,79,226,145,224,78,104,197,76,75,62,91,103,132,218,165,68,111,126,0,119,15,201,188,6,53,213,250,208,212,107,11,102,197,236,129,78,192,21,32,177,11,229,183,128,17,251,86,166,149,130,128,147,220,221,222,28,145,192,242,61,84,12,9,46,219,116,172,156,112,109,17,186,51,166,216,14,140,199,204,149,117,76,113,24,182,235,188,140,139,38,8,232,78,97,193,131,58,20,248,122,123,51,216,106,3,140,239,73,28,88,90,251,88,86,66,173,149,112,121,73,132,58,45,150,132,163,3,127,68,148,31,69,140,134,5,240,198,160,144,177,218,9,5,180,0,247,183,176,76,203,166,82,75,177,219,187,41,28,65,198,10,126,146,73,35,202,248,146,144,126,133,54,73,137,167,26,188,215,156,146,83,165,3,11,149,127,113,208,140,169,113,41,156,223,117,48,200,246,76,237,32,116,115,7,213,66,91,225,149,199,2,81,62,165,196,153,6,210,147,199,244,153,85,16,166,222,240,247,88,215,178,29,49,199,206,55,54,3,107,209,230,21,188,56,116,66,53,82,226,217,55,194,153,243,46,158,141,120,225,80,123,10,98,223,87,58,51,189,151,210,39,198,123,49,213,156,73,241,139,109,36,20,33,51,113,180,2,99,152,213,91,71,51,188,161,40,37,209,7,151,207,136,244,89,143,132,15,219,166,113,56,60,195,129,176,170,253,162,13,237,140,89,161,1,223,117,243,196,142,16,133,229,60,63,15,173,140,117,66,239,123,3,186,9,235,115,116,145,159,179,243,9,61,205,220,253,135,67,221,35,160,40,165,98,46,150,54,237,43,24,32,52,45,238,73,59,68,220,147,226,178,23,202,146,228,58,207,194,104,142,84,125,214,115,159,204,254,15,170,188,62,180,4,91,107,101,225,36,178,191,129,63,207,246,252,106,187,239,67,23,253,215,72,31,252,37,204,15,195,198,57,173,158,152,42,37,152,232,45,245,65,185,78,149,243,224,106,52,94,46,231,203,40,164,100,43,20,147,178,123,121,11,164,167,43,3,48,49,162,68,93,91,3,118,239,1,98,191,47,134,207,128,107,140,10,225,196,194,111,56,229,28,36,103,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateApplyDataUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("c8fc346b-ae73-48f1-924e-b1077f140def"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b6173a01-f02a-4a83-8fef-713a069ef368"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"ApplyDataUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(561, 58),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeApplyDataUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOkButtonHandlerStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e11c3c21-3bd2-44b5-a3a0-4684809cd761"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b6173a01-f02a-4a83-8fef-713a069ef368"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OkButtonHandler",
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"OkButtonHandler",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(673, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOkButtonHandlerScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e4b9d97a-4a6e-4a8c-bccf-cc77039815b4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b6173a01-f02a-4a83-8fef-713a069ef368"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"OkButtonHandlerScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(771, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessTreeGridCellIconClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessTreeGridCellIconClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("dde5eb0f-a557-4588-a0c3-55b34771a3aa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c9169d94-71b5-4355-94aa-26bb16efaea8"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"SubProcessTreeGridCellIconClick",
				Position = new Point(36, 589),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(191, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessTreeGridCellIconClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateTreeGridCellIconClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ef5f6a9a-25d4-4cdc-8923-0c13d180da24"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dde5eb0f-a557-4588-a0c3-55b34771a3aa"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"TreeGridCellIconClick",
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"TreeGridCellIconClick",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTreeGridCellIconClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7e4c7151-cfb3-4ae1-9d51-2b8dfd433aa4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dde5eb0f-a557-4588-a0c3-55b34771a3aa"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"ScriptTreeGridCellIconClick",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,149,81,111,218,48,16,199,159,139,196,119,176,242,100,75,197,34,106,213,174,106,55,137,65,168,88,81,215,21,170,61,76,123,240,146,43,100,34,54,181,47,180,217,180,239,190,75,76,40,48,152,170,190,245,133,196,185,243,223,255,251,157,109,22,202,50,180,0,151,54,77,216,123,118,163,38,32,199,203,241,121,179,177,160,176,131,25,196,8,201,181,73,192,81,78,157,46,71,235,1,74,78,239,25,223,72,150,93,147,107,100,23,44,20,236,119,179,113,96,1,115,171,73,32,7,74,255,211,108,52,27,151,57,173,27,43,29,37,41,222,166,147,41,14,97,1,179,65,233,69,195,35,43,195,60,104,183,79,251,237,227,40,106,133,253,40,108,245,250,97,216,58,59,13,63,182,218,237,176,119,210,142,206,142,222,117,79,2,113,254,172,118,11,42,217,171,214,61,137,58,157,163,254,241,203,212,18,208,197,126,169,211,23,74,121,146,56,181,230,49,90,128,198,142,157,148,40,99,163,17,158,80,142,55,3,202,177,94,26,99,106,180,178,197,133,67,155,234,201,33,51,63,126,18,218,15,75,208,219,90,100,43,159,205,246,112,174,42,169,26,92,190,201,40,155,99,177,83,135,58,166,81,165,218,93,65,193,3,77,77,28,36,129,32,85,70,178,222,8,243,143,138,4,31,131,181,202,153,123,164,137,89,102,180,252,228,234,159,30,56,176,169,154,165,191,96,107,145,111,181,240,119,57,54,163,74,141,11,33,214,6,228,237,160,114,58,182,197,141,178,14,120,189,40,97,200,145,74,17,245,6,250,146,131,45,186,202,1,123,88,189,249,22,173,34,149,158,31,25,77,251,140,184,46,147,87,195,245,25,245,71,190,57,28,23,115,144,209,67,174,150,144,135,112,143,209,211,220,130,115,255,40,204,242,76,63,199,120,176,190,129,2,65,206,201,208,166,3,89,165,60,207,113,178,147,36,220,43,149,77,113,200,119,156,18,33,86,66,84,103,57,229,235,20,244,0,33,227,155,242,135,108,67,106,123,83,11,191,71,223,38,148,237,195,254,90,40,251,248,190,73,46,59,59,252,58,40,59,249,54,27,119,243,68,33,176,220,63,124,69,254,27,175,254,69,238,232,248,147,134,134,216,203,86,31,123,10,213,200,228,54,6,57,138,167,144,41,121,173,50,16,146,16,141,0,183,106,63,252,15,165,85,41,162,154,76,197,88,224,65,9,76,14,92,5,190,230,65,247,7,45,129,96,57,221,26,162,188,91,189,75,42,194,123,151,209,19,196,57,250,107,226,243,28,172,42,13,15,205,100,2,86,14,8,130,210,100,151,198,145,198,20,11,239,219,139,251,62,16,184,221,37,251,107,106,187,240,161,33,158,230,145,251,232,250,93,253,23,120,36,3,233,141,7,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess9DataSourceBeforeLoadEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess9DataSourceBeforeLoad = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("151dd994-e3d0-4edd-81bc-984924418c9a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c9169d94-71b5-4355-94aa-26bb16efaea8"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"SubProcess9DataSourceBeforeLoad",
				Position = new Point(239, 590),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(186, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess9DataSourceBeforeLoad;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceBeforeLoadStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ce53c96c-9d51-4f05-969e-bbbe8ab7bf8c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("151dd994-e3d0-4edd-81bc-984924418c9a"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DataSourceBeforeLoad",
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"DataSourceBeforeLoad",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessDownButtonClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessDownButtonClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e4dc3da5-7153-468b-8ffd-3715bd4d5a39"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c9169d94-71b5-4355-94aa-26bb16efaea8"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"SubProcessDownButtonClick",
				Position = new Point(35, 751),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(203, 226),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessDownButtonClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDownButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("930e1a33-c94b-4a38-9b2a-e05892b7fa42"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e4dc3da5-7153-468b-8ffd-3715bd4d5a39"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DownButtonClick",
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"DownButtonClick",
				Position = new Point(29, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDownButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5d4cd314-11b9-46dd-91ed-bd9a622b2525"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e4dc3da5-7153-468b-8ffd-3715bd4d5a39"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"ScriptDownButtonClick",
				Position = new Point(99, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,146,95,107,194,48,20,197,159,39,248,29,130,79,41,43,193,109,143,226,203,58,145,194,230,196,170,47,195,135,204,92,219,12,155,72,114,235,144,177,239,190,155,250,135,14,203,246,216,244,156,223,61,247,36,122,195,248,84,230,32,230,14,96,236,180,18,25,108,97,141,160,38,86,129,23,137,173,12,178,225,144,245,35,246,213,237,220,56,192,202,25,134,174,130,65,183,243,221,237,236,165,99,190,97,97,67,246,7,239,173,191,26,28,61,90,145,210,192,39,27,87,90,241,38,65,44,229,182,34,105,47,85,189,149,152,219,12,157,54,57,143,162,147,115,103,189,70,109,13,249,19,107,246,224,144,68,169,193,135,251,118,204,244,164,239,173,34,118,203,238,78,20,127,240,217,186,128,82,46,210,255,147,100,213,251,7,157,94,12,173,185,192,160,198,195,81,243,34,13,149,224,206,101,44,60,56,202,106,136,65,65,196,232,90,73,12,95,243,152,111,206,154,200,50,52,218,130,22,99,192,20,161,124,60,80,30,222,220,38,18,193,69,192,164,144,38,135,153,206,139,90,121,238,129,107,21,95,74,140,235,171,140,175,167,134,173,94,119,224,100,80,61,219,60,140,76,141,71,105,214,32,232,187,185,67,98,183,85,105,234,65,35,165,145,183,236,28,211,133,7,228,239,183,49,131,141,3,95,60,73,148,60,252,109,190,174,31,158,68,19,230,154,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateUpButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8edae77f-59ec-45f5-b8b5-687072fdde7e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e4dc3da5-7153-468b-8ffd-3715bd4d5a39"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"UpButtonClick",
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"UpButtonClick",
				Position = new Point(29, 140),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptUpButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f1dcf5ef-cf7b-465c-8e9a-5b6108da1d29"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e4dc3da5-7153-468b-8ffd-3715bd4d5a39"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"ScriptUpButtonClick",
				Position = new Point(99, 126),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,146,95,79,194,48,20,197,159,37,225,59,52,60,117,201,108,80,31,145,23,39,33,75,20,9,19,95,12,15,149,94,182,154,173,37,237,29,134,24,191,187,183,252,203,12,11,62,118,61,231,119,239,57,171,94,49,62,149,57,136,87,7,48,118,90,137,12,74,88,34,168,137,85,224,69,98,107,131,108,56,100,253,136,125,119,59,87,14,176,118,134,161,171,97,208,237,252,116,59,27,233,152,111,88,216,144,93,224,189,247,23,131,189,71,43,82,26,248,98,227,90,43,222,36,136,55,89,214,36,237,165,170,183,16,175,54,67,167,77,206,163,232,224,92,91,175,81,91,67,254,196,154,13,56,36,81,106,240,238,182,29,51,61,232,123,139,136,93,179,27,162,104,10,125,162,220,95,142,182,245,217,178,128,74,206,211,255,23,206,234,143,79,250,122,50,180,174,15,6,53,110,247,154,103,105,168,43,119,236,108,238,193,81,36,67,12,218,76,140,206,149,196,240,59,30,243,205,89,19,89,133,226,91,208,98,12,152,34,84,15,91,218,135,55,211,68,34,184,8,152,20,210,228,48,211,121,177,83,30,235,226,90,197,167,174,99,182,146,165,135,248,124,108,136,245,178,6,39,131,236,201,230,97,102,106,60,74,179,4,65,231,102,136,196,150,117,101,118,147,70,74,35,111,9,29,211,195,8,200,191,111,104,6,43,7,190,120,148,40,121,184,109,254,170,95,73,128,189,95,194,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1c65e15c-4b4c-43bc-8873-dc4b7477ba81"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c9169d94-71b5-4355-94aa-26bb16efaea8"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"EventSubProcess10",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 1020),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(217, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceLoadRowsChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f782b455-f099-4316-be36-1d2fd1cb8067"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1c65e15c-4b4c-43bc-8873-dc4b7477ba81"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DataSourceLoadRows",
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"DataSourceLoadRowsChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 60),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDataSourceLoadRowsChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("60007875-fe3c-4710-9f99-5a3decbfa860"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1c65e15c-4b4c-43bc-8873-dc4b7477ba81"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"ScriptDataSourceLoadRowsChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,93,139,26,49,20,125,182,208,255,144,245,97,153,129,18,182,175,149,45,248,49,108,5,89,68,215,237,67,233,67,38,185,106,104,76,108,62,214,14,197,255,222,100,50,227,71,87,199,69,22,20,153,220,115,207,73,238,189,103,34,159,163,36,161,74,90,248,99,241,211,82,171,77,246,2,210,118,245,194,32,98,208,128,88,50,85,78,83,216,45,167,120,2,191,29,24,139,191,113,208,68,211,37,167,68,244,149,112,43,249,76,132,3,60,52,217,106,109,139,36,77,209,223,143,31,90,47,68,163,220,89,171,164,65,247,232,1,108,47,62,36,105,167,138,178,157,202,68,109,76,95,57,105,61,114,76,22,128,247,27,192,33,134,203,96,200,203,149,18,136,48,22,201,50,73,114,1,172,87,76,248,98,105,131,142,213,14,118,56,6,2,44,188,9,10,140,219,55,1,169,90,23,151,128,225,112,190,108,220,22,83,186,132,21,57,113,170,24,8,96,238,91,113,4,190,185,71,210,9,17,171,24,11,149,79,129,58,237,33,153,92,112,9,53,223,204,128,238,43,41,129,90,174,36,30,244,142,97,129,189,101,172,230,114,129,76,201,253,72,86,33,249,80,14,135,181,18,217,92,173,255,247,128,125,71,125,199,15,152,6,33,223,107,117,133,80,27,96,201,94,178,236,120,171,161,107,151,201,187,235,53,72,214,192,222,212,151,119,160,111,154,143,203,244,153,207,62,79,190,245,223,185,210,64,232,50,9,237,14,190,212,126,212,184,140,109,174,140,211,143,203,35,82,40,103,113,245,100,14,198,36,186,205,111,168,38,240,78,126,2,173,137,81,115,139,103,67,252,29,242,58,109,151,95,177,151,135,12,163,88,145,28,15,225,65,36,102,18,238,141,28,23,202,1,74,107,96,203,108,184,165,75,116,20,172,99,45,74,12,160,118,183,30,132,246,151,106,189,85,161,171,218,250,35,36,167,94,14,95,209,93,138,110,111,207,250,191,83,209,229,190,150,191,58,71,154,131,131,225,190,86,182,193,32,13,202,217,110,114,174,213,61,59,123,13,170,253,157,29,174,85,61,107,168,6,213,217,250,90,205,207,105,83,243,212,70,190,51,49,131,57,113,194,162,43,138,115,138,111,91,254,108,17,8,191,223,106,218,95,49,214,215,67,5,223,70,235,251,79,112,215,205,208,12,192,251,74,60,104,206,162,99,166,126,222,168,5,246,168,24,140,53,95,17,93,28,220,183,225,82,117,156,225,242,210,173,47,146,243,151,103,236,107,185,181,139,188,167,88,126,220,253,196,175,193,245,235,107,196,141,5,9,122,255,87,34,169,151,2,217,88,43,10,198,204,134,236,19,106,135,3,142,20,97,129,181,29,170,233,9,52,88,167,101,172,208,63,178,79,68,131,156,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a95d5cc2-a203-4fea-8594-c41861882c96"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c9169d94-71b5-4355-94aa-26bb16efaea8"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"EventSubProcess11",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(238, 1020),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(210, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceRemovedChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("dff9c88b-ffd8-4f87-9214-4335fbb41041"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a95d5cc2-a203-4fea-8594-c41861882c96"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DataSourceRemoved",
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"DataSourceRemovedChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 60),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDataSourceRemovedChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6d412b4f-f4bb-4975-b613-0d3dd083d941"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a95d5cc2-a203-4fea-8594-c41861882c96"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"ScriptDataSourceRemovedChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,76,46,201,44,75,44,73,117,42,45,41,201,207,43,214,40,41,42,77,213,180,230,42,74,45,41,45,202,83,0,241,172,1,200,179,135,67,35,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDataSourceBeforeLoadScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9664da22-ef37-447d-9838-09bdd7b632ca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c9169d94-71b5-4355-94aa-26bb16efaea8"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Name = @"ScriptDataSourceBeforeLoad",
				Position = new Point(316, 625),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,147,111,79,194,48,16,198,95,187,79,113,217,171,45,74,195,162,193,63,19,13,142,161,36,196,16,64,125,93,233,57,155,108,237,210,117,18,98,252,238,182,29,202,16,77,220,171,238,122,247,235,221,243,180,83,154,33,89,40,196,91,197,25,25,23,230,119,194,43,13,125,240,23,168,20,173,228,139,38,79,248,60,40,75,63,6,240,166,59,249,183,168,103,114,149,72,241,194,179,59,42,88,142,10,250,30,195,28,51,170,49,216,18,18,169,144,164,66,115,205,177,106,22,107,80,114,21,194,187,7,0,149,86,92,100,80,42,94,80,181,78,100,94,23,226,158,22,104,218,48,73,100,190,124,197,130,146,105,123,155,216,253,248,175,226,71,154,215,95,213,166,201,86,48,216,59,36,36,11,57,119,140,32,116,192,55,170,96,233,102,50,4,129,43,24,82,77,231,178,86,75,252,158,54,216,63,46,108,119,51,227,217,171,158,224,27,230,191,119,225,111,19,198,204,111,183,96,150,15,101,137,42,216,225,113,235,204,70,146,54,219,248,148,156,166,131,193,241,232,164,19,141,210,168,51,28,69,81,231,252,52,186,233,116,187,209,176,215,77,207,143,207,146,158,15,215,224,15,81,172,73,41,50,31,46,192,59,176,31,236,177,122,255,100,37,84,204,144,178,159,56,27,79,25,215,46,30,155,176,213,146,27,49,171,47,41,249,82,115,41,140,114,151,205,100,71,224,46,93,163,170,211,230,202,78,126,224,138,200,128,177,182,84,254,145,131,252,172,8,190,213,9,109,105,227,157,173,221,120,245,139,135,214,137,177,61,98,7,99,3,14,161,80,215,74,108,110,65,236,125,196,205,197,223,66,200,68,82,134,12,14,251,214,164,221,87,97,179,154,237,216,219,128,180,170,49,254,4,172,166,36,232,108,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateChangeRightItemPositionMethod());
			Methods.Add(CreateDeterminePositionForMoveMethod());
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3b4b993c-39e7-4ce9-86c4-610775507e64"),
				Name = "Terrasoft.Core.OperationLog",
				Alias = "",
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a6ad9e40-cce5-485f-acfd-5aa466479fc7"),
				Name = "System.Security",
				Alias = "",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
		}

		protected override SchemaMethod CreateGetButtonsMethod() {
			SchemaMethod method = base.CreateGetButtonsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,42,45,41,201,207,43,86,176,85,200,75,45,87,8,174,44,46,73,205,213,115,206,207,201,73,77,46,201,4,74,232,185,167,230,165,22,101,38,235,249,100,22,151,216,20,151,20,101,230,165,219,105,104,90,115,65,53,234,57,166,164,104,4,36,166,167,130,24,78,96,49,61,191,196,220,84,108,42,92,83,50,75,8,40,113,206,47,168,36,160,196,37,53,39,181,36,149,128,162,208,2,66,166,228,151,231,17,80,18,0,244,43,154,123,139,82,75,74,139,242,96,129,102,13,0,78,2,77,199,65,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateActivateButtonsMethod() {
			SchemaMethod method = base.CreateActivateButtonsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,223,107,219,48,16,126,118,254,10,53,15,197,134,33,218,215,134,48,22,199,116,129,178,150,100,217,158,207,214,217,209,144,37,35,157,178,154,182,255,251,100,91,14,43,140,81,208,139,116,223,125,63,238,116,6,203,74,79,100,180,99,107,118,143,180,153,46,105,182,90,156,67,77,0,193,193,120,91,225,222,252,118,185,241,154,2,238,9,26,228,219,75,137,127,169,72,158,7,196,147,149,45,216,62,55,202,183,250,7,40,143,108,29,104,189,20,188,104,59,234,217,235,43,187,130,1,13,132,236,51,187,97,119,236,118,181,40,141,81,12,132,152,196,11,13,165,66,177,233,247,178,57,209,224,139,172,199,136,18,168,144,240,3,64,20,146,62,0,171,76,215,255,31,54,140,1,53,73,234,15,213,9,91,248,71,254,169,16,24,193,197,97,192,236,209,165,115,220,56,209,10,116,126,2,221,224,40,19,200,142,14,109,110,180,198,128,51,154,111,55,7,172,188,13,114,133,110,164,70,30,150,146,131,46,158,195,43,225,99,135,22,6,92,186,204,103,162,226,47,115,123,172,140,21,91,172,71,246,101,208,148,53,75,211,157,219,34,129,84,247,86,10,118,125,205,14,190,252,21,244,166,61,29,119,226,253,150,178,113,77,239,141,102,236,101,145,212,198,34,84,167,116,204,97,52,217,48,64,169,167,113,196,184,249,244,252,0,189,241,196,227,205,141,221,201,249,242,217,66,236,185,31,28,251,142,214,130,51,53,241,227,142,255,196,114,238,186,180,71,242,85,224,24,227,68,146,171,53,211,94,169,108,72,148,58,178,82,55,161,165,237,192,226,163,21,82,131,138,72,254,13,90,252,196,150,3,31,62,211,87,84,221,196,184,204,6,146,155,108,242,151,68,116,252,9,193,100,13,202,225,42,73,66,241,109,17,206,219,31,154,67,118,93,48,3,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterEditPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterEditPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterCopyPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterCopyPageScriptMethod();
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

		protected virtual SchemaMethod CreateChangeRightItemPositionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2cb2c1ab-4e78-4744-b3d6-2b7bc3808fed"),
				Name = "ChangeRightItemPosition",
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("cfdf140d-3d67-4901-b4d6-0e48e89f7293"),
				Name = "primaryColumnValue",
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ddc0d72d-e608-4132-99ef-fb2453980d07"),
				Name = "position",
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2e903d53-18b4-43b0-9885-1fb3826ec64d"),
				Name = "increasePosition",
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ea441715-00a8-4948-8259-ff9e32ffdc0a"),
				Name = "subjectSchemaName",
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,201,78,195,48,16,61,55,95,97,229,148,72,85,250,1,81,47,180,1,245,64,137,26,150,35,114,157,33,53,196,118,52,30,3,21,229,223,113,80,55,146,208,155,53,243,150,153,55,150,47,44,178,132,82,87,201,194,46,93,93,223,97,166,26,218,70,43,89,109,200,22,98,3,138,47,185,130,152,237,118,236,2,242,6,141,107,26,223,157,153,218,41,221,82,108,28,179,175,96,132,64,14,117,26,124,7,147,73,99,172,36,105,52,155,178,57,16,160,146,26,242,125,237,218,224,173,121,135,232,128,25,51,169,5,2,183,71,196,152,89,183,126,5,65,103,99,165,65,65,6,161,204,209,8,40,29,2,179,64,43,16,6,203,3,237,212,154,50,13,31,172,67,136,114,94,65,242,96,1,103,70,107,175,254,235,20,146,109,158,139,174,84,24,7,163,228,73,210,38,231,232,221,253,6,81,120,207,215,53,180,179,132,99,214,75,173,15,207,81,42,142,219,83,76,158,22,46,202,33,229,63,208,71,94,187,22,219,244,138,3,204,161,107,28,199,27,60,213,128,251,97,103,239,185,127,198,140,219,110,124,105,240,127,224,73,206,197,155,79,183,181,240,225,15,4,157,204,175,50,93,249,95,144,20,91,75,160,206,8,23,133,179,79,16,142,32,138,211,31,240,201,149,46,194,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDeterminePositionForMoveMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("aeaf4d29-e3fc-462b-9e62-ef573ee53816"),
				Name = "DeterminePositionForMove",
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "int"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("caaf2d92-702c-4858-86ed-b399e0fdd8c6"),
				Name = "sourcePosition",
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2698e874-449a-4e2f-bb1e-eda4103cc2ba"),
				Name = "doIncreasePosition",
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("baa14e9e-353b-4549-aeba-910953a0c89d"),
				Name = "sourceSubjectName",
				CreatedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				ModifiedInSchemaUId = new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,48,176,6,0,192,147,116,237,9,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AdministrativeObjectColumnRightsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f68889e3-c531-4863-befa-2d6a36152ea5"));
		}

		#endregion

	}

	#endregion

}

