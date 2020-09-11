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
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using UIControls = Terrasoft.UI.WebControls.Controls;
	using VwSysEntitySchemaInWorkspace = Terrasoft.Configuration.VwSysEntitySchemaInWorkspace;

	#region Class: DeleteDataUserTaskParametersEditPageSchema

	/// <exclude/>
	public class DeleteDataUserTaskParametersEditPageSchema : Terrasoft.WebApp.BaseProcessParametersEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return _controlLayout2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _titleEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit TitleEdit {
			get {
				return _titleEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _entityEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit EntityEdit {
			get {
				return _entityEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _isMatchConditionsEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox IsMatchConditionsEdit {
			get {
				return _isMatchConditionsEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _filterControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout FilterControlLayout {
			get {
				return _filterControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.FilterEdit _filterEdit;
		public Terrasoft.UI.WebControls.Controls.FilterEdit FilterEdit {
			get {
				return _filterEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout4;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return _controlLayout4;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _disableBusinessLogicCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox DisableBusinessLogicCheckBox {
			get {
				return _disableBusinessLogicCheckBox;
			}
		}

		private Terrasoft.UI.WebControls.Controls.EntityDataSource _entityDataSource;
		public Terrasoft.UI.WebControls.Controls.EntityDataSource EntityDataSource {
			get {
				return _entityDataSource;
			}
		}

		#endregion

		#region Constructors: Public

		public DeleteDataUserTaskParametersEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public DeleteDataUserTaskParametersEditPageSchema(DeleteDataUserTaskParametersEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			RealUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			Name = "DeleteDataUserTaskParametersEditPage";
			ParentSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 350;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateDeleteDataUserTaskParametersEditPageEventsProcessSchema();
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
			ControlLayout1.InsertItem(0, CreateControlLayout2());
			ControlLayout2.InsertItem(0, CreateTitleEdit());
			ControlLayout2.InsertItem(1, CreateEntityEdit());
			ControlLayout2.InsertItem(2, CreateIsMatchConditionsEdit());
			ControlLayout1.InsertItem(1, CreateFilterControlLayout());
			FilterControlLayout.InsertItem(0, CreateFilterEdit());
			ControlLayout1.InsertItem(2, CreateControlLayout4());
			ControlLayout4.InsertItem(0, CreateDisableBusinessLogicCheckBox());
			TopLevelControl.MoveItem(2, BottomControlLayout);
			BottomControlLayout.MoveItem(0, ContextHelpButton);
			BottomControlLayout.MoveItem(1, Spacer1);
			BottomControlLayout.MoveItem(2, OkButton);
			BottomControlLayout.MoveItem(3, CancelButton);
			Controls.AddAt(3, CreateEntityDataSource());
			UpdateEntityDataSource();
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateDeleteDataUserTaskParametersEditPageEventsProcessSchema() {
			var schema = new DeleteDataUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateTitleEdit() {
			_titleEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_titleEdit.UId = new Guid("27815c80-b4ba-4c53-aa49-8e40db77fb63");
			_titleEdit.Name = "TitleEdit";
			_titleEdit.CreatedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			_titleEdit.ModifiedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			_titleEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_titleEdit.Tag = "";
			_titleEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_titleEdit.Image = new ControlImage {};
			_titleEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _titleEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateEntityEdit() {
			_entityEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_entityEdit.UId = new Guid("7fb703f9-b087-48d7-b2d7-0c8ca00bf88a");
			_entityEdit.Name = "EntityEdit";
			_entityEdit.CreatedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			_entityEdit.ModifiedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			_entityEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_entityEdit.Tag = "";
			_entityEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_entityEdit.Image = new ControlImage {};
			_entityEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_entityEdit.Required = true;
			_entityEdit.LookupSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15");
			_entityEdit.LookupPageSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			return _entityEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsMatchConditionsEdit() {
			_isMatchConditionsEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isMatchConditionsEdit.UId = new Guid("8553e80a-5280-4d05-a85f-db76182200d5");
			_isMatchConditionsEdit.Name = "IsMatchConditionsEdit";
			_isMatchConditionsEdit.CreatedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			_isMatchConditionsEdit.ModifiedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			_isMatchConditionsEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_isMatchConditionsEdit.AjaxEvents.Check.IsProcessEventHandler = true;
			_isMatchConditionsEdit.Tag = "";
			_isMatchConditionsEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isMatchConditionsEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isMatchConditionsEdit.AlignedByCaption = false;
			_isMatchConditionsEdit.Hidden = true;
			return _isMatchConditionsEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout2() {
			_controlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout2.UId = new Guid("295fa6e8-a08a-4252-98ab-7dae023d1174");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			_controlLayout2.ModifiedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			_controlLayout2.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout2.Tag = "";
			_controlLayout2.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout2.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout2.FitHeightByContent = true;
			_controlLayout2.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout2.StartNewAlignGroup = false;
			_controlLayout2.Image = new ControlImage {};
			_controlLayout2.Edges = "";
			return _controlLayout2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FilterEdit CreateFilterEdit() {
			_filterEdit = new Terrasoft.UI.WebControls.Controls.FilterEdit();
			_filterEdit.UId = new Guid("de684047-eaed-43db-81fc-abb867c1a09f");
			_filterEdit.Name = "FilterEdit";
			_filterEdit.CreatedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			_filterEdit.ModifiedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			_filterEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterEdit.Tag = "";
			_filterEdit.DataSourceId = "EntityDataSource";
			_filterEdit.Edges = "1 1 1 1";
			_filterEdit.HasSplitter = true;
			_filterEdit.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_filterEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _filterEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateFilterControlLayout() {
			_filterControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_filterControlLayout.UId = new Guid("becc6df7-2489-4c60-9544-abfca0c11761");
			_filterControlLayout.Name = "FilterControlLayout";
			_filterControlLayout.CreatedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			_filterControlLayout.ModifiedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			_filterControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterControlLayout.Tag = "";
			_filterControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_filterControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_filterControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_filterControlLayout.Padding = "0 0 0 15";
			_filterControlLayout.StartNewAlignGroup = false;
			_filterControlLayout.Image = new ControlImage {};
			_filterControlLayout.Edges = "";
			return _filterControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateDisableBusinessLogicCheckBox() {
			_disableBusinessLogicCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_disableBusinessLogicCheckBox.UId = new Guid("b30086f9-4f45-49eb-9f44-7d9ed92e4e14");
			_disableBusinessLogicCheckBox.Name = "DisableBusinessLogicCheckBox";
			_disableBusinessLogicCheckBox.CreatedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			_disableBusinessLogicCheckBox.ModifiedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			_disableBusinessLogicCheckBox.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_disableBusinessLogicCheckBox.Tag = "";
			_disableBusinessLogicCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_disableBusinessLogicCheckBox.AlignedByCaption = false;
			return _disableBusinessLogicCheckBox;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout4() {
			_controlLayout4 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout4.UId = new Guid("9411dccc-f148-4c94-9460-92d879bd4224");
			_controlLayout4.Name = "ControlLayout4";
			_controlLayout4.CreatedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			_controlLayout4.ModifiedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			_controlLayout4.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout4.Tag = "";
			_controlLayout4.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout4.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout4.FitHeightByContent = true;
			_controlLayout4.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout4.StartNewAlignGroup = false;
			_controlLayout4.Image = new ControlImage {};
			_controlLayout4.Edges = "";
			_controlLayout4.Hidden = true;
			return _controlLayout4;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("aa99b5a3-cedf-4336-b050-625d8371027a");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			_controlLayout1.ModifiedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.EntityDataSource CreateEntityDataSource() {
			_entityDataSource = new Terrasoft.UI.WebControls.Controls.EntityDataSource();
			_entityDataSource.UId = new Guid("5fae7946-d25c-4750-bb56-b83385a6da2e");
			_entityDataSource.Name = "EntityDataSource";
			_entityDataSource.CreatedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			_entityDataSource.ModifiedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			_entityDataSource.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityDataSource.Tag = "";
			_entityDataSource.EnableServerActiveRow = false;
			_entityDataSource.SchemaUId = Guid.Empty;
			_entityDataSource.HierarchicalDepth = 1;
			_entityDataSource.DefStructure.ID = "c" + _entityDataSource.DefStructure.UId.ToString("N");
			_entityDataSource.DefStructure.UId = new Guid("bb275663-526d-4604-ac62-fc704f06eb43");
			_entityDataSource.DefStructure.Name = "DefStructure";
			_entityDataSource.DefStructure.CreatedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			_entityDataSource.DefStructure.ModifiedInSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			return _entityDataSource;
		}

		protected virtual void UpdateEntityDataSource() {
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new DeleteDataUserTaskParametersEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new DeleteDataUserTaskParametersEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new DeleteDataUserTaskParametersEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: DeleteDataUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class DeleteDataUserTaskParametersEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.DeleteDataUserTaskParametersEditPageSchemaUserControl
	{

		#region Class: ChangeSchemaEntityUserMessageFlowElement

		/// <exclude/>
		public class ChangeSchemaEntityUserMessageFlowElement : QuestionUserTask
		{

			public ChangeSchemaEntityUserMessageFlowElement(UserConnection userConnection, DeleteDataUserTaskParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeSchemaEntityUserMessage";
				IsLogging = false;
				SchemaElementUId = new Guid("8ba9bbd4-5bbb-4408-8f5a-b3fb64b0cad4");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public DeleteDataUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DeleteDataUserTaskParametersEditPageEventsProcess";
			SchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
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

		public virtual bool IsFilterParamsValuesCorrect {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess2;
		public ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("03ed3019-a97d-46b7-a78e-349da9896307"),
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
					SchemaElementUId = new Guid("03c4fcf0-cde2-48d8-821f-9ded86b142e7"),
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
					SchemaElementUId = new Guid("092c6c81-92bd-419e-802d-96d09be40e88"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _childInitScript;
		public ProcessScriptTask ChildInitScript {
			get {
				return _childInitScript ?? (_childInitScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChildInitScript",
					SchemaElementUId = new Guid("de9aee07-6a3a-4be3-b971-bb51752341dc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChildInitScriptExecute,
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
					SchemaElementUId = new Guid("5529809d-8f78-42fd-bd40-aa8391712314"),
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
					SchemaElementUId = new Guid("93a50243-68bb-4365-a307-d6826d90feba"),
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
					SchemaElementUId = new Guid("7583f571-fafd-42ae-ac35-c574ff8a597d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _childPageLoadCompleteScript;
		public ProcessScriptTask ChildPageLoadCompleteScript {
			get {
				return _childPageLoadCompleteScript ?? (_childPageLoadCompleteScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChildPageLoadCompleteScript",
					SchemaElementUId = new Guid("25377329-ef62-4222-88f2-eea008638ec5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChildPageLoadCompleteScriptExecute,
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
					SchemaElementUId = new Guid("32cea53f-005b-48ec-a268-b9390bac99d8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _entityEditChangeStartMessage;
		public ProcessFlowElement EntityEditChangeStartMessage {
			get {
				return _entityEditChangeStartMessage ?? (_entityEditChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EntityEditChangeStartMessage",
					SchemaElementUId = new Guid("7f55766f-6a7c-44d9-901f-eb0957fd0f0e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway1;
		public ProcessExclusiveGateway ExclusiveGateway1 {
			get {
				return _exclusiveGateway1 ?? (_exclusiveGateway1 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway1",
					SchemaElementUId = new Guid("58962d98-d462-4a9a-9b13-f0558c86f29f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _prepareChangeSchemaEntityQuestionScript;
		public ProcessScriptTask PrepareChangeSchemaEntityQuestionScript {
			get {
				return _prepareChangeSchemaEntityQuestionScript ?? (_prepareChangeSchemaEntityQuestionScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareChangeSchemaEntityQuestionScript",
					SchemaElementUId = new Guid("dad01b3a-50e3-487c-9db7-8b9a97a89768"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareChangeSchemaEntityQuestionScriptExecute,
				});
			}
		}

		private ChangeSchemaEntityUserMessageFlowElement _changeSchemaEntityUserMessage;
		public ChangeSchemaEntityUserMessageFlowElement ChangeSchemaEntityUserMessage {
			get {
				return _changeSchemaEntityUserMessage ?? (_changeSchemaEntityUserMessage = new ChangeSchemaEntityUserMessageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("0dd3b78a-308d-4021-a036-d70fc50d4aef"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "ChangeSchemaEntityYesMessage",
				});
			}
		}

		private ProcessFlowElement _eventSubProcess5;
		public ProcessFlowElement EventSubProcess5 {
			get {
				return _eventSubProcess5 ?? (_eventSubProcess5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess5",
					SchemaElementUId = new Guid("e03e5fd2-9f25-47e7-a4b3-d42bbf3d5e6c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _isMatchConditionsEditCheckStartMessage;
		public ProcessFlowElement IsMatchConditionsEditCheckStartMessage {
			get {
				return _isMatchConditionsEditCheckStartMessage ?? (_isMatchConditionsEditCheckStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "IsMatchConditionsEditCheckStartMessage",
					SchemaElementUId = new Guid("1ced1643-be18-4abd-84b4-14e10239ccb7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _isMatchConditionsEditCheckScript;
		public ProcessScriptTask IsMatchConditionsEditCheckScript {
			get {
				return _isMatchConditionsEditCheckScript ?? (_isMatchConditionsEditCheckScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "IsMatchConditionsEditCheckScript",
					SchemaElementUId = new Guid("65d61b51-6456-4b60-a1d6-11d524bf9f8d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = IsMatchConditionsEditCheckScriptExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessChangeSchemaEntityYesMessage;
		public ProcessFlowElement EventSubProcessChangeSchemaEntityYesMessage {
			get {
				return _eventSubProcessChangeSchemaEntityYesMessage ?? (_eventSubProcessChangeSchemaEntityYesMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChangeSchemaEntityYesMessage",
					SchemaElementUId = new Guid("c9d0ab1a-aace-4856-b9a9-1bc42f1f3b9c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _changeSchemaEntityYesMessageBase;
		public ProcessFlowElement ChangeSchemaEntityYesMessageBase {
			get {
				return _changeSchemaEntityYesMessageBase ?? (_changeSchemaEntityYesMessageBase = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChangeSchemaEntityYesMessageBase",
					SchemaElementUId = new Guid("bb1a291e-f14a-4c9e-a0c4-e1a9cc02f4be"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _changeSchemaEntityYesMessageScript;
		public ProcessScriptTask ChangeSchemaEntityYesMessageScript {
			get {
				return _changeSchemaEntityYesMessageScript ?? (_changeSchemaEntityYesMessageScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChangeSchemaEntityYesMessageScript",
					SchemaElementUId = new Guid("562a6b46-d10a-4048-aa27-04feefbc7a9c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChangeSchemaEntityYesMessageScriptExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessChangeSchemaEntityNoMessage;
		public ProcessFlowElement EventSubProcessChangeSchemaEntityNoMessage {
			get {
				return _eventSubProcessChangeSchemaEntityNoMessage ?? (_eventSubProcessChangeSchemaEntityNoMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChangeSchemaEntityNoMessage",
					SchemaElementUId = new Guid("54e3e586-3340-4cd7-b511-3122319c0c39"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _changeSchemaEntityNoMessageBase;
		public ProcessFlowElement ChangeSchemaEntityNoMessageBase {
			get {
				return _changeSchemaEntityNoMessageBase ?? (_changeSchemaEntityNoMessageBase = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChangeSchemaEntityNoMessageBase",
					SchemaElementUId = new Guid("3ed362cc-658d-46a6-9fb9-5b9e0ab8ad17"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _changeSchemaEntityNoMessageScript;
		public ProcessScriptTask ChangeSchemaEntityNoMessageScript {
			get {
				return _changeSchemaEntityNoMessageScript ?? (_changeSchemaEntityNoMessageScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChangeSchemaEntityNoMessageScript",
					SchemaElementUId = new Guid("4ad2800f-64dc-4ed6-8c01-2da6161971cc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChangeSchemaEntityNoMessageScriptExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess6;
		public ProcessFlowElement EventSubProcess6 {
			get {
				return _eventSubProcess6 ?? (_eventSubProcess6 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess6",
					SchemaElementUId = new Guid("8502337d-da57-4595-b0ac-d52bddba7b60"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deleteOkButtonClickStartMessage;
		public ProcessFlowElement DeleteOkButtonClickStartMessage {
			get {
				return _deleteOkButtonClickStartMessage ?? (_deleteOkButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteOkButtonClickStartMessage",
					SchemaElementUId = new Guid("33b3a322-7778-4633-a45f-bda9bfdc9d64"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _deleteOkButtonClickIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent DeleteOkButtonClickIntermediateThrowMessageEvent {
			get {
				return _deleteOkButtonClickIntermediateThrowMessageEvent ?? (_deleteOkButtonClickIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "DeleteOkButtonClickIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("7ff23690-9eb5-4ef1-9fb8-8a806daae295"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OkButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _deleteOkButtonClickScript;
		public ProcessScriptTask DeleteOkButtonClickScript {
			get {
				return _deleteOkButtonClickScript ?? (_deleteOkButtonClickScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeleteOkButtonClickScript",
					SchemaElementUId = new Guid("fe9efc90-8976-4a9f-8c52-5726279ab07e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeleteOkButtonClickScriptExecute,
				});
			}
		}

		private ProcessScriptTask _checkData_ScriptTask;
		public ProcessScriptTask CheckData_ScriptTask {
			get {
				return _checkData_ScriptTask ?? (_checkData_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckData_ScriptTask",
					SchemaElementUId = new Guid("bae40c13-b935-446f-b233-f4b1dc204655"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckData_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("09fb1a1d-fd7a-4d41-b8b2-e513c113a687"),
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

		private ProcessScriptTask _errorMessage_ScriptTask;
		public ProcessScriptTask ErrorMessage_ScriptTask {
			get {
				return _errorMessage_ScriptTask ?? (_errorMessage_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ErrorMessage_ScriptTask",
					SchemaElementUId = new Guid("1fb36f27-c054-4858-8563-f030a3caceed"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ErrorMessage_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("916ec8c7-72a5-4294-9116-754a0f3f5b05"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow2;
		public ProcessConditionalFlow ConditionalFlow2 {
			get {
				return _conditionalFlow2 ?? (_conditionalFlow2 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow2",
					SchemaElementUId = new Guid("c7e04b3a-e592-4ad3-827f-029a54ffba6a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _changeSchemaEntityMessage;
		public LocalizableString ChangeSchemaEntityMessage {
			get {
				return _changeSchemaEntityMessage ?? (_changeSchemaEntityMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ChangeSchemaEntityMessage.Value"));
			}
		}

		private LocalizableString _validationMessageTitle;
		public LocalizableString ValidationMessageTitle {
			get {
				return _validationMessageTitle ?? (_validationMessageTitle = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ValidationMessageTitle.Value"));
			}
		}

		private LocalizableString _validationMessage;
		public LocalizableString ValidationMessage {
			get {
				return _validationMessage ?? (_validationMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ValidationMessage.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[InitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitStartMessage };
			FlowElements[InitIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { InitIntermediateThrowMessageEvent };
			FlowElements[ChildInitScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildInitScript };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[PageLoqdCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoqdCompleteStartMessage };
			FlowElements[PageLoqdCompleteIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoqdCompleteIntermediateThrowMessageEvent };
			FlowElements[ChildPageLoadCompleteScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildPageLoadCompleteScript };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[EntityEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EntityEditChangeStartMessage };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[PrepareChangeSchemaEntityQuestionScript.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareChangeSchemaEntityQuestionScript };
			FlowElements[ChangeSchemaEntityUserMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeSchemaEntityUserMessage };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[IsMatchConditionsEditCheckStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { IsMatchConditionsEditCheckStartMessage };
			FlowElements[IsMatchConditionsEditCheckScript.SchemaElementUId] = new Collection<ProcessFlowElement> { IsMatchConditionsEditCheckScript };
			FlowElements[EventSubProcessChangeSchemaEntityYesMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChangeSchemaEntityYesMessage };
			FlowElements[ChangeSchemaEntityYesMessageBase.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeSchemaEntityYesMessageBase };
			FlowElements[ChangeSchemaEntityYesMessageScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeSchemaEntityYesMessageScript };
			FlowElements[EventSubProcessChangeSchemaEntityNoMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChangeSchemaEntityNoMessage };
			FlowElements[ChangeSchemaEntityNoMessageBase.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeSchemaEntityNoMessageBase };
			FlowElements[ChangeSchemaEntityNoMessageScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeSchemaEntityNoMessageScript };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[DeleteOkButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteOkButtonClickStartMessage };
			FlowElements[DeleteOkButtonClickIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteOkButtonClickIntermediateThrowMessageEvent };
			FlowElements[DeleteOkButtonClickScript.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteOkButtonClickScript };
			FlowElements[CheckData_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckData_ScriptTask };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[ErrorMessage_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ErrorMessage_ScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess2":
						break;
					case "InitStartMessage":
						e.Context.QueueTasks.Enqueue("InitIntermediateThrowMessageEvent");
						break;
					case "InitIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("ChildInitScript");
						break;
					case "ChildInitScript":
						break;
					case "EventSubProcess3":
						break;
					case "PageLoqdCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoqdCompleteIntermediateThrowMessageEvent");
						break;
					case "PageLoqdCompleteIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("ChildPageLoadCompleteScript");
						break;
					case "ChildPageLoadCompleteScript":
						break;
					case "EventSubProcess4":
						break;
					case "EntityEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("PrepareChangeSchemaEntityQuestionScript");
							break;
						}
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "PrepareChangeSchemaEntityQuestionScript":
						e.Context.QueueTasks.Enqueue("ChangeSchemaEntityUserMessage");
						break;
					case "ChangeSchemaEntityUserMessage":
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "EventSubProcess5":
						break;
					case "IsMatchConditionsEditCheckStartMessage":
						e.Context.QueueTasks.Enqueue("IsMatchConditionsEditCheckScript");
						break;
					case "IsMatchConditionsEditCheckScript":
						break;
					case "EventSubProcessChangeSchemaEntityYesMessage":
						break;
					case "ChangeSchemaEntityYesMessageBase":
						e.Context.QueueTasks.Enqueue("ChangeSchemaEntityYesMessageScript");
						break;
					case "ChangeSchemaEntityYesMessageScript":
						break;
					case "EventSubProcessChangeSchemaEntityNoMessage":
						break;
					case "ChangeSchemaEntityNoMessageBase":
						e.Context.QueueTasks.Enqueue("ChangeSchemaEntityNoMessageScript");
						break;
					case "ChangeSchemaEntityNoMessageScript":
						break;
					case "EventSubProcess6":
						break;
					case "DeleteOkButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("CheckData_ScriptTask");
						break;
					case "DeleteOkButtonClickIntermediateThrowMessageEvent":
						break;
					case "DeleteOkButtonClickScript":
						e.Context.QueueTasks.Enqueue("DeleteOkButtonClickIntermediateThrowMessageEvent");
						break;
					case "CheckData_ScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway2");
						break;
					case "ExclusiveGateway2":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("DeleteOkButtonClickScript");
							break;
						}
						e.Context.QueueTasks.Enqueue("ErrorMessage_ScriptTask");
						break;
					case "ErrorMessage_ScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(EntitySchemaUId != Guid.Empty && (Guid)Page.EntityEdit.Value != EntitySchemaUId);
		}

		private bool ConditionalFlow2ExpressionExecute() {
			return Convert.ToBoolean(IsFilterParamsValuesCorrect);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("InitStartMessage");
			ActivatedEventElements.Add("PageLoqdCompleteStartMessage");
			ActivatedEventElements.Add("EntityEditChangeStartMessage");
			ActivatedEventElements.Add("IsMatchConditionsEditCheckStartMessage");
			ActivatedEventElements.Add("ChangeSchemaEntityYesMessageBase");
			ActivatedEventElements.Add("ChangeSchemaEntityNoMessageBase");
			ActivatedEventElements.Add("DeleteOkButtonClickStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess2":
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
				case "ChildInitScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildInitScript";
					result = ChildInitScript.Execute(context, ChildInitScriptExecute);
					break;
				case "EventSubProcess3":
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
				case "ChildPageLoadCompleteScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildPageLoadCompleteScript";
					result = ChildPageLoadCompleteScript.Execute(context, ChildPageLoadCompleteScriptExecute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "EntityEditChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EntityEditChangeStartMessage";
					result = EntityEditChangeStartMessage.Execute(context);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "PrepareChangeSchemaEntityQuestionScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareChangeSchemaEntityQuestionScript";
					result = PrepareChangeSchemaEntityQuestionScript.Execute(context, PrepareChangeSchemaEntityQuestionScriptExecute);
					break;
				case "ChangeSchemaEntityUserMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeSchemaEntityUserMessage";
					result = ChangeSchemaEntityUserMessage.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "IsMatchConditionsEditCheckStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "IsMatchConditionsEditCheckStartMessage";
					result = IsMatchConditionsEditCheckStartMessage.Execute(context);
					break;
				case "IsMatchConditionsEditCheckScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "IsMatchConditionsEditCheckScript";
					result = IsMatchConditionsEditCheckScript.Execute(context, IsMatchConditionsEditCheckScriptExecute);
					break;
				case "EventSubProcessChangeSchemaEntityYesMessage":
					context.QueueTasks.Dequeue();
					break;
				case "ChangeSchemaEntityYesMessageBase":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeSchemaEntityYesMessageBase";
					result = ChangeSchemaEntityYesMessageBase.Execute(context);
					break;
				case "ChangeSchemaEntityYesMessageScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeSchemaEntityYesMessageScript";
					result = ChangeSchemaEntityYesMessageScript.Execute(context, ChangeSchemaEntityYesMessageScriptExecute);
					break;
				case "EventSubProcessChangeSchemaEntityNoMessage":
					context.QueueTasks.Dequeue();
					break;
				case "ChangeSchemaEntityNoMessageBase":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeSchemaEntityNoMessageBase";
					result = ChangeSchemaEntityNoMessageBase.Execute(context);
					break;
				case "ChangeSchemaEntityNoMessageScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeSchemaEntityNoMessageScript";
					result = ChangeSchemaEntityNoMessageScript.Execute(context, ChangeSchemaEntityNoMessageScriptExecute);
					break;
				case "EventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "DeleteOkButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteOkButtonClickStartMessage";
					result = DeleteOkButtonClickStartMessage.Execute(context);
					break;
				case "DeleteOkButtonClickIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OkButtonClick");
					result = DeleteOkButtonClickIntermediateThrowMessageEvent.Execute(context);
					break;
				case "DeleteOkButtonClickScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteOkButtonClickScript";
					result = DeleteOkButtonClickScript.Execute(context, DeleteOkButtonClickScriptExecute);
					break;
				case "CheckData_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckData_ScriptTask";
					result = CheckData_ScriptTask.Execute(context, CheckData_ScriptTaskExecute);
					break;
				case "ExclusiveGateway2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway2";
					result = ExclusiveGateway2.Execute(context);
					break;
				case "ErrorMessage_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ErrorMessage_ScriptTask";
					result = ErrorMessage_ScriptTask.Execute(context, ErrorMessage_ScriptTaskExecute);
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
				case "IsFilterParamsValuesCorrect":
					IsFilterParamsValuesCorrect = reader.GetValue<System.Boolean>();
				break;
				case "EntitySchemaUId":
					EntitySchemaUId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ChildInitScriptExecute(ProcessExecutingContext context) {
			IEnumerable<Guid> packageIds = Terrasoft.Core.Packages.WorkspaceUtilities.GetPackageHierarchyIds(UserConnection, FindDesignedProcessSchema().PackageUId,
				UserConnection.Workspace.Id);
			object[] objectPackageIds = packageIds.Cast<object>().ToArray();
			var packageIdFilter = new Dictionary<string, object> {
					{"comparisonType", FilterComparisonType.Equal},
					{"leftExpressionColumnPath", "SysPackage"},
					{"useDisplayValue", false},
					{"rightExpressionParameterValues", objectPackageIds}};
			var managerNameFilter = new Dictionary<string, object> {
					{"comparisonType", FilterComparisonType.Equal},
					{"leftExpressionColumnPath", "ManagerName"},
					{"useDisplayValue", false},
					{"rightExpressionParameterValues", new object[] {"EntitySchemaManager"}}};
			var extendParentFilter = new Dictionary<string, object> {
					{"comparisonType", FilterComparisonType.Equal},
					{"leftExpressionColumnPath", "ExtendParent"},
					{"useDisplayValue", false},
					{"rightExpressionParameterValues", new object[] {false}}};
			Page.EntityEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
				var filters = e.Filters;
				filters.Add(packageIdFilter);
				filters.Add(managerNameFilter);
				filters.Add(extendParentFilter);
			};
			if (!Ext.IsAjaxRequest) {
				var defValues = (Dictionary<string, ProcessSchemaParameterValue>)DefaultValues;
				Page.TitleEdit.Text = ElementNewCaption;
				//SetDefaultValue(defValues["IsMatchConditions"], false.ToString(), string.Empty, "IsMatchConditions");
				DefaultValues = defValues;
				DesignModeClassDescriptor descriptor = Descriptor as DesignModeClassDescriptor;
				FillPropertyDataSource(Source, descriptor);
				var propertyDataSource = PropertyDataSource as VirtualDataSource;
				propertyDataSource.SetClientActiveRow();
				BindEditors(GetEditorsBinding(), propertyDataSource, defValues);
			}
			return true;
		}

		public virtual bool ChildPageLoadCompleteScriptExecute(ProcessExecutingContext context) {
			var schema = FindDesignedProcessSchema();
			Page.FilterEdit.SetProcessSchema(schema);
			
			var df = DefaultValues as Dictionary<string, ProcessSchemaParameterValue>;
			
			if (df == null) {
				return true;
			}
			
			string entitySchemaId = df["EntitySchemaId"].Value;
			if (!string.IsNullOrEmpty(entitySchemaId)) {
				EntitySchemaUId = new Guid(entitySchemaId);
				
				Page.EntityDataSource.SchemaUId = EntitySchemaUId;
				Page.EntityEdit.SetValueAndText(EntitySchemaUId,
					Page.EntityDataSource.Schema.Caption.ToString());
					
				string filters = df["DataSourceFilters"].Value;
				if (!String.IsNullOrEmpty(filters)) {
					var jsonConverter = new DataSourceFiltersJsonConverter(
						UserConnection, Page.FilterEdit.DataSource);
					var filterCollection = Json.Deserialize(filters, typeof(DataSourceFilterCollection), 
						new List<JsonConverter> { jsonConverter }) as DataSourceFilterCollection;
					if (filterCollection != null) {
						var filterEditGroup = Page.EntityDataSource.FindFiltersGroupByName(filterCollection.Name);
						if (filterEditGroup != null) {
							Page.EntityDataSource.CurrentStructure.Filters.Remove(filterEditGroup);
						}
						Page.EntityDataSource.CurrentStructure.Filters.Add(filterCollection);
					}
				}
				Page.EntityDataSource.LoadStructure();
				Page.FilterEdit.SetDataSource(Page.EntityDataSource);
			}
			
			Page.IsMatchConditionsEdit.Checked = Page.EntityDataSource.SchemaUId != Guid.Empty;
			Page.FilterEdit.Enabled = Page.IsMatchConditionsEdit.Checked;
			
			return true;
		}

		public virtual bool PrepareChangeSchemaEntityQuestionScriptExecute(ProcessExecutingContext context) {
			ChangeSchemaEntityUserMessage.Page = Page;
			ChangeSchemaEntityUserMessage.MessageText = ChangeSchemaEntityMessage;
			ChangeSchemaEntityUserMessage.Icon = "QUESTION";
			ChangeSchemaEntityUserMessage.Buttons = "YESNO";
			ChangeSchemaEntityUserMessage.ResponseMessages = new Dictionary<string, string> {
				{"yes", "ChangeSchemaEntityYesMessage"},
				{"no", "ChangeSchemaEntityNoMessage"},
			};
			return true;
		}

		public virtual bool IsMatchConditionsEditCheckScriptExecute(ProcessExecutingContext context) {
			Page.FilterEdit.Enabled = Page.IsMatchConditionsEdit.Checked;
			return true;
		}

		public virtual bool ChangeSchemaEntityYesMessageScriptExecute(ProcessExecutingContext context) {
			EntitySchemaUId =
				(new Select(UserConnection)
					.Column("UId")
				.From("SysSchema")
				.Where("Id")
				.IsEqual(Column.Parameter((Guid)Page.EntityEdit.Value)) as Select)
				.ExecuteScalar<Guid>();
			bool isNotEmptyEntitySchemaUId = EntitySchemaUId != Guid.Empty;
			Page.EntityDataSource.SchemaUId = EntitySchemaUId;
			Page.IsMatchConditionsEdit.Checked = isNotEmptyEntitySchemaUId;
			ClearControlValues();
			Page.FilterEdit.Enabled = isNotEmptyEntitySchemaUId;
			Page.EntityDataSource.LoadStructure();
			return true;
		}

		public virtual bool ChangeSchemaEntityNoMessageScriptExecute(ProcessExecutingContext context) {
			if (EntitySchemaUId != Guid.Empty) {
				Page.EntityEdit.SuspendAjaxEvents();
				Page.EntityEdit.SetValueAndText(EntitySchemaUId, Page.EntityDataSource.Schema.Caption.ToString());
				Page.EntityEdit.ResumeAjaxEvents();
			}
			
			return true;
		}

		public virtual bool DeleteOkButtonClickScriptExecute(ProcessExecutingContext context) {
			ElementNewCaption = Page.TitleEdit.Text;
			
			var noneVS = ProcessSchemaParameterValueSource.None;
			var constVS = ProcessSchemaParameterValueSource.ConstValue;
			
			var parametersValue = ParametersValue as Dictionary<string, ProcessSchemaParameterValue>;
			if (parametersValue == null) {
				ParametersValue = (parametersValue = new Dictionary<string, ProcessSchemaParameterValue>());
			}
			
			string entitySchemaId = EntitySchemaUId.Equals(Guid.Empty) ? string.Empty : EntitySchemaUId.ToString();
			parametersValue["EntitySchemaId"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = string.IsNullOrEmpty(entitySchemaId) ? noneVS : constVS,
				Value = entitySchemaId
			};
			
			var filterCollection = Page.FilterEdit.DataSource.FindFiltersGroupByName("FilterEdit");
			var jsonConverter = new DataSourceFiltersJsonConverter(
				UserConnection, Page.FilterEdit.DataSource);
			
			parametersValue["DataSourceFilters"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = Page.IsMatchConditionsEdit.Checked ? constVS : noneVS,
				Value = Page.IsMatchConditionsEdit.Checked ? 
					Json.Serialize(filterCollection, jsonConverter) : string.Empty
			};
			
			return true;
		}

		public virtual bool CheckData_ScriptTaskExecute(ProcessExecutingContext context) {
			var filters = Page.FilterEdit.DataSource.FindFiltersGroupByName("FilterEdit");
			if (filters.Count == 0) {
				IsFilterParamsValuesCorrect = false;
			} else {
				IsFilterParamsValuesCorrect = !filters.IsAnyLeftExpressionNullOrEmpty();
			}
			return true;
		}

		public virtual bool ErrorMessage_ScriptTaskExecute(ProcessExecutingContext context) {
			Page.MainMessagePanel.AddMessage(ValidationMessageTitle, ValidationMessage, MessageType.Warning);
			
			return true;
		}

		public override Dictionary<string, Terrasoft.UI.WebControls.WebControl> GetEditorsBinding() {
			return new Dictionary<string, Terrasoft.UI.WebControls.WebControl>() {
				{"EntitySchemaId", Page.EntityEdit},
				//{"IsMatchConditions", Page.IsMatchConditionsEdit}
			};
		}

		public override void MakeCaption() {
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = string.IsNullOrEmpty(Page.TitleEdit.Text) ?
				ElementNewCaption : Page.TitleEdit.Text;
		}

		public virtual void ClearControlValues() {
			Page.FilterEdit.Enabled = false;
			var filterEditGroup = Page.EntityDataSource.FindFiltersGroupByName(Page.FilterEdit.FilterEditGroupName);
			filterEditGroup.Clear();
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
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoqdCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoqdCompleteStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "EntityEditChange":
							if (ActivatedEventElements.Contains("EntityEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("EntityEditChangeStartMessage");
						}
						break;
					case "IsMatchConditionsEditCheck":
							if (ActivatedEventElements.Contains("IsMatchConditionsEditCheckStartMessage")) {
							context.QueueTasks.Enqueue("IsMatchConditionsEditCheckStartMessage");
						}
						break;
					case "ChangeSchemaEntityYesMessage":
							if (ActivatedEventElements.Contains("ChangeSchemaEntityYesMessageBase")) {
							context.QueueTasks.Enqueue("ChangeSchemaEntityYesMessageBase");
						}
						break;
					case "ChangeSchemaEntityNoMessage":
							if (ActivatedEventElements.Contains("ChangeSchemaEntityNoMessageBase")) {
							context.QueueTasks.Enqueue("ChangeSchemaEntityNoMessageBase");
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("DeleteOkButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("DeleteOkButtonClickStartMessage");
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
			if (!HasMapping("IsFilterParamsValuesCorrect") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsFilterParamsValuesCorrect", IsFilterParamsValuesCorrect, false);
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

	#region Class: DeleteDataUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class DeleteDataUserTaskParametersEditPageEventsProcess : DeleteDataUserTaskParametersEditPageEventsProcess<Terrasoft.WebApp.DeleteDataUserTaskParametersEditPageSchemaUserControl>
	{

		public DeleteDataUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DeleteDataUserTaskParametersEditPageSchemaUserControl

	/// <exclude/>
	public partial class DeleteDataUserTaskParametersEditPageSchemaUserControl : Terrasoft.WebApp.BaseProcessParametersEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit TitleEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("TitleEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit EntityEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("EntityEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox IsMatchConditionsEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("IsMatchConditionsEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout FilterControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("FilterControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.FilterEdit FilterEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.FilterEdit)PageContainer.FindPageControl("FilterEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout4", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox DisableBusinessLogicCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("DisableBusinessLogicCheckBox", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.EntityDataSource EntityDataSource {
			get {
				return (Terrasoft.UI.WebControls.Controls.EntityDataSource)PageContainer.FindPageControl("EntityDataSource", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			EntityEdit.AjaxEvents.Change.Event += EntityEditChange;
			IsMatchConditionsEdit.AjaxEvents.Check.Event += IsMatchConditionsEditCheck;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			EntityEdit.AjaxEvents.Change.Event -= EntityEditChange;
			IsMatchConditionsEdit.AjaxEvents.Check.Event -= IsMatchConditionsEditCheck;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (DeleteDataUserTaskParametersEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new DeleteDataUserTaskParametersEditPageEventsProcess(UserConnection);
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

		public virtual void EntityEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("EntityEditChange");
		}

		public virtual void IsMatchConditionsEditCheck(object sender, EventArgs e) {
			object result = ThrowEvent("IsMatchConditionsEditCheck");
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
			SchemaName = "DeleteDataUserTaskParametersEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: DeleteDataUserTaskParametersEditPageEventsProcessSchema

	/// <exclude/>
	public class DeleteDataUserTaskParametersEditPageEventsProcessSchema : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public DeleteDataUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public DeleteDataUserTaskParametersEditPageEventsProcessSchema(DeleteDataUserTaskParametersEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "DeleteDataUserTaskParametersEditPageEventsProcess";
			UId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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

		protected override ProcessSchemaParameter CreatePropertyDataSourceParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e7fe8054-e33d-4fa1-add5-d1b1957d18b7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"PropertyDataSource",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a8cb67cc-c423-4450-a7a5-5e231c5bf456"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsFilterParamsValuesCorrectParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fb8e02ff-c4d2-42a5-b6b4-1259e7c0233e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"IsFilterParamsValuesCorrect",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEntitySchemaUIdParameter());
			Parameters.Add(CreateIsFilterParamsValuesCorrectParameter());
		}

		protected virtual void InitializeChangeSchemaEntityUserMessageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("2c91a3b2-f4fd-465d-a7e6-a3c076e13ac5"),
				ContainerUId = new Guid("8ba9bbd4-5bbb-4408-8f5a-b3fb64b0cad4"),
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
				UId = new Guid("02bbada2-53b2-4bd9-894e-5296f698108f"),
				ContainerUId = new Guid("8ba9bbd4-5bbb-4408-8f5a-b3fb64b0cad4"),
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
				UId = new Guid("966588e3-346a-4238-908b-8c85a95b3728"),
				ContainerUId = new Guid("8ba9bbd4-5bbb-4408-8f5a-b3fb64b0cad4"),
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
				UId = new Guid("c8462d5f-a666-4bda-b427-53c10d0a0f90"),
				ContainerUId = new Guid("8ba9bbd4-5bbb-4408-8f5a-b3fb64b0cad4"),
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
				UId = new Guid("7e8063bc-8c78-4c66-8933-63e10a9d4f41"),
				ContainerUId = new Guid("8ba9bbd4-5bbb-4408-8f5a-b3fb64b0cad4"),
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
				UId = new Guid("71fb9003-ed23-47a1-8202-34a97a706715"),
				ContainerUId = new Guid("8ba9bbd4-5bbb-4408-8f5a-b3fb64b0cad4"),
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
				UId = new Guid("61d91b55-4284-4e7c-9520-fdfe413608df"),
				ContainerUId = new Guid("8ba9bbd4-5bbb-4408-8f5a-b3fb64b0cad4"),
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
				UId = new Guid("24d32f9d-edd3-4e1f-9144-e3e5e8e4f498"),
				ContainerUId = new Guid("8ba9bbd4-5bbb-4408-8f5a-b3fb64b0cad4"),
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
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaLane schemaLane3 = CreateLane3Lane();
			schemaLaneSet1.Lanes.Add(schemaLane3);
			ProcessSchemaLane schemaLane4 = CreateLane4Lane();
			schemaLaneSet1.Lanes.Add(schemaLane4);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaEventSubProcess eventsubprocesschangeschemaentityyesmessage = CreateEventSubProcessChangeSchemaEntityYesMessageEventSubProcess();
			FlowElements.Add(eventsubprocesschangeschemaentityyesmessage);
			ProcessSchemaEventSubProcess eventsubprocesschangeschemaentitynomessage = CreateEventSubProcessChangeSchemaEntityNoMessageEventSubProcess();
			FlowElements.Add(eventsubprocesschangeschemaentitynomessage);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaStartMessageEvent initstartmessage = CreateInitStartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(initstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent initintermediatethrowmessageevent = CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(initintermediatethrowmessageevent);
			ProcessSchemaScriptTask childinitscript = CreateChildInitScriptScriptTask();
			eventsubprocess2.FlowElements.Add(childinitscript);
			ProcessSchemaStartMessageEvent pageloqdcompletestartmessage = CreatePageLoqdCompleteStartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(pageloqdcompletestartmessage);
			ProcessSchemaIntermediateThrowMessageEvent pageloqdcompleteintermediatethrowmessageevent = CreatePageLoqdCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess3.FlowElements.Add(pageloqdcompleteintermediatethrowmessageevent);
			ProcessSchemaScriptTask childpageloadcompletescript = CreateChildPageLoadCompleteScriptScriptTask();
			eventsubprocess3.FlowElements.Add(childpageloadcompletescript);
			ProcessSchemaStartMessageEvent entityeditchangestartmessage = CreateEntityEditChangeStartMessageStartMessageEvent();
			eventsubprocess4.FlowElements.Add(entityeditchangestartmessage);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			eventsubprocess4.FlowElements.Add(exclusivegateway1);
			ProcessSchemaScriptTask preparechangeschemaentityquestionscript = CreatePrepareChangeSchemaEntityQuestionScriptScriptTask();
			eventsubprocess4.FlowElements.Add(preparechangeschemaentityquestionscript);
			ProcessSchemaUserTask changeschemaentityusermessage = CreateChangeSchemaEntityUserMessageUserTask();
			eventsubprocess4.FlowElements.Add(changeschemaentityusermessage);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess4.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaStartMessageEvent ismatchconditionseditcheckstartmessage = CreateIsMatchConditionsEditCheckStartMessageStartMessageEvent();
			eventsubprocess5.FlowElements.Add(ismatchconditionseditcheckstartmessage);
			ProcessSchemaScriptTask ismatchconditionseditcheckscript = CreateIsMatchConditionsEditCheckScriptScriptTask();
			eventsubprocess5.FlowElements.Add(ismatchconditionseditcheckscript);
			ProcessSchemaStartMessageEvent changeschemaentityyesmessagebase = CreateChangeSchemaEntityYesMessageBaseStartMessageEvent();
			eventsubprocesschangeschemaentityyesmessage.FlowElements.Add(changeschemaentityyesmessagebase);
			ProcessSchemaScriptTask changeschemaentityyesmessagescript = CreateChangeSchemaEntityYesMessageScriptScriptTask();
			eventsubprocesschangeschemaentityyesmessage.FlowElements.Add(changeschemaentityyesmessagescript);
			ProcessSchemaStartMessageEvent changeschemaentitynomessagebase = CreateChangeSchemaEntityNoMessageBaseStartMessageEvent();
			eventsubprocesschangeschemaentitynomessage.FlowElements.Add(changeschemaentitynomessagebase);
			ProcessSchemaScriptTask changeschemaentitynomessagescript = CreateChangeSchemaEntityNoMessageScriptScriptTask();
			eventsubprocesschangeschemaentitynomessage.FlowElements.Add(changeschemaentitynomessagescript);
			ProcessSchemaStartMessageEvent deleteokbuttonclickstartmessage = CreateDeleteOkButtonClickStartMessageStartMessageEvent();
			eventsubprocess6.FlowElements.Add(deleteokbuttonclickstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent deleteokbuttonclickintermediatethrowmessageevent = CreateDeleteOkButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess6.FlowElements.Add(deleteokbuttonclickintermediatethrowmessageevent);
			ProcessSchemaScriptTask deleteokbuttonclickscript = CreateDeleteOkButtonClickScriptScriptTask();
			eventsubprocess6.FlowElements.Add(deleteokbuttonclickscript);
			ProcessSchemaScriptTask checkdata_scripttask = CreateCheckData_ScriptTaskScriptTask();
			eventsubprocess6.FlowElements.Add(checkdata_scripttask);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			eventsubprocess6.FlowElements.Add(exclusivegateway2);
			ProcessSchemaScriptTask errormessage_scripttask = CreateErrorMessage_ScriptTaskScriptTask();
			eventsubprocess6.FlowElements.Add(errormessage_scripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateChangeSchemaEntityMessageLocalizableString());
			LocalizableStrings.Add(CreateValidationMessageTitleLocalizableString());
			LocalizableStrings.Add(CreateValidationMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateChangeSchemaEntityMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e102be3c-85d7-4a49-97e1-6966fdde65d6"),
				Name = "ChangeSchemaEntityMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageTitleLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("12e29fda-a3eb-485e-9e75-dbf3623ceeaa"),
				Name = "ValidationMessageTitle",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("33458e08-382c-40bf-bdee-108b91016125"),
				Name = "ValidationMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("e61d158d-e95a-4fa9-8e9f-f0b5cc8a1d76"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				CurveCenterPosition = new Point(182, 110),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("03c4fcf0-cde2-48d8-821f-9ded86b142e7"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("092c6c81-92bd-419e-802d-96d09be40e88"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("1d74586b-9e70-43ae-921a-ad0aed40a92b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				CurveCenterPosition = new Point(301, 112),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("092c6c81-92bd-419e-802d-96d09be40e88"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("de9aee07-6a3a-4be3-b971-bb51752341dc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("0468a92e-3b6c-4444-a321-bd38f1866b87"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				CurveCenterPosition = new Point(200, 308),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("93a50243-68bb-4365-a307-d6826d90feba"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7583f571-fafd-42ae-ac35-c574ff8a597d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("fa9d9bdf-5bc6-4691-8042-6dfc3a82e206"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				CurveCenterPosition = new Point(304, 308),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7583f571-fafd-42ae-ac35-c574ff8a597d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("25377329-ef62-4222-88f2-eea008638ec5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("d31d69a1-aea2-4c11-9f49-9fcaaf5d7396"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1ced1643-be18-4abd-84b4-14e10239ccb7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("65d61b51-6456-4b60-a1d6-11d524bf9f8d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("916ec8c7-72a5-4294-9116-754a0f3f5b05"),
				ConditionExpression = @"EntitySchemaUId != Guid.Empty && (Guid)Page.EntityEdit.Value != EntitySchemaUId",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				CurveCenterPosition = new Point(270, 256),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("58962d98-d462-4a9a-9b13-f0558c86f29f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dad01b3a-50e3-487c-9db7-8b9a97a89768"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("b5553a82-1967-4549-9120-6c7bd3852d76"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				CurveCenterPosition = new Point(419, 232),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dad01b3a-50e3-487c-9db7-8b9a97a89768"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8ba9bbd4-5bbb-4408-8f5a-b3fb64b0cad4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow7",
				UId = new Guid("f09ec0cd-b4f7-4dae-8b8d-85d1f6bb4838"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				CurveCenterPosition = new Point(280, 354),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("58962d98-d462-4a9a-9b13-f0558c86f29f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0dd3b78a-308d-4021-a036-d70fc50d4aef"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("210a6e1d-7518-4db5-8c19-dbcbfed70171"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				CurveCenterPosition = new Point(192, 306),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7f55766f-6a7c-44d9-901f-eb0957fd0f0e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("58962d98-d462-4a9a-9b13-f0558c86f29f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("5a20a016-d5a7-4714-8d17-50f6228863de"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				CurveCenterPosition = new Point(206, 516),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bb1a291e-f14a-4c9e-a0c4-e1a9cc02f4be"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("562a6b46-d10a-4048-aa27-04feefbc7a9c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("be67d19d-108a-41a9-839b-f5e26493fcf7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				CurveCenterPosition = new Point(514, 516),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3ed362cc-658d-46a6-9fb9-5b9e0ab8ad17"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4ad2800f-64dc-4ed6-8c01-2da6161971cc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("07125afd-2312-4a99-8a9d-57bbd557f5e8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fe9efc90-8976-4a9f-8c52-5726279ab07e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7ff23690-9eb5-4ef1-9fb8-8a806daae295"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("5e72baad-75a4-4595-856d-f276cc533058"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("33b3a322-7778-4633-a45f-bda9bfdc9d64"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bae40c13-b935-446f-b233-f4b1dc204655"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("3715a3cb-a4b1-4aa3-a85a-f36f4990c6eb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bae40c13-b935-446f-b233-f4b1dc204655"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("09fb1a1d-fd7a-4d41-b8b2-e513c113a687"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("c7e04b3a-e592-4ad3-827f-029a54ffba6a"),
				ConditionExpression = @"IsFilterParamsValuesCorrect",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				CurveCenterPosition = new Point(439, 140),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("09fb1a1d-fd7a-4d41-b8b2-e513c113a687"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fe9efc90-8976-4a9f-8c52-5726279ab07e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow14",
				UId = new Guid("4f0fab92-fbf0-44eb-8ee2-cf87f60b7f9d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				CurveCenterPosition = new Point(435, 238),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("09fb1a1d-fd7a-4d41-b8b2-e513c113a687"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1fb36f27-c054-4858-8563-f030a3caceed"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("631f17c8-eb66-45ea-b563-9418f8b4faa1"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(879, 1486),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("6f010ffe-ee34-4391-8b8c-61723d04428a"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("631f17c8-eb66-45ea-b563-9418f8b4faa1"),
				CreatedInOwnerSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 1078),
				Size = new Size(850, 408),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("cac106e7-3f8b-4095-876a-65467ce98c3d"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("631f17c8-eb66-45ea-b563-9418f8b4faa1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"Lane2",
				Position = new Point(29, 632),
				Size = new Size(850, 441),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("287fa743-372d-4723-a04c-e5ca0f11c23e"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("631f17c8-eb66-45ea-b563-9418f8b4faa1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"Lane3",
				Position = new Point(29, 359),
				Size = new Size(850, 268),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaLane CreateLane4Lane() {
			ProcessSchemaLane schemaLane4 = new ProcessSchemaLane(this) {
				UId = new Guid("4b569258-ac8d-49c7-8b2c-26944a418cec"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("631f17c8-eb66-45ea-b563-9418f8b4faa1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"Lane4",
				Position = new Point(29, 0),
				Size = new Size(850, 354),
				UseBackgroundMode = false
			};
			return schemaLane4;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("03ed3019-a97d-46b7-a78e-349da9896307"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f010ffe-ee34-4391-8b8c-61723d04428a"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(378, 196),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("03c4fcf0-cde2-48d8-821f-9ded86b142e7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("03ed3019-a97d-46b7-a78e-349da9896307"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"InitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 84),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("092c6c81-92bd-419e-802d-96d09be40e88"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("03ed3019-a97d-46b7-a78e-349da9896307"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"InitIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(133, 84),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChildInitScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("de9aee07-6a3a-4be3-b971-bb51752341dc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("03ed3019-a97d-46b7-a78e-349da9896307"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"ChildInitScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(245, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,85,77,79,227,48,16,61,23,137,255,224,205,41,213,70,225,7,64,43,117,211,192,86,90,80,181,45,236,1,113,48,201,180,53,56,118,176,39,64,132,250,223,119,28,135,166,37,187,183,93,113,170,59,31,111,222,60,143,39,179,84,85,5,24,126,47,225,236,162,18,249,152,149,60,123,228,107,152,229,150,141,216,18,140,225,86,175,48,78,180,129,120,238,125,54,254,165,205,163,165,72,184,70,33,5,10,50,93,0,182,238,239,130,0,77,182,169,9,35,188,182,96,18,173,20,100,40,180,138,216,185,80,249,20,172,88,43,200,231,70,103,96,237,34,219,64,193,195,225,59,252,245,44,143,142,143,6,135,153,93,201,120,150,15,79,143,143,244,253,3,121,110,239,152,63,204,247,105,119,61,196,9,183,120,230,67,198,84,98,169,39,212,81,29,58,132,103,110,186,200,115,33,17,12,229,42,120,97,83,209,212,228,166,62,179,104,132,90,71,109,149,49,123,35,102,131,183,32,211,69,201,141,176,90,45,235,18,2,215,151,203,79,14,204,113,250,84,113,185,141,124,138,132,21,166,175,165,161,142,9,59,209,178,42,212,156,227,134,146,131,69,109,219,6,130,247,240,202,194,84,216,82,242,250,134,203,202,149,88,113,105,225,221,109,196,122,179,7,55,231,134,23,64,12,154,96,27,68,61,89,182,219,182,229,130,43,178,152,43,138,255,220,166,47,59,34,255,172,107,215,200,110,50,222,130,84,161,192,218,15,88,91,46,216,238,148,128,87,4,149,19,8,40,252,92,41,210,61,38,255,73,11,159,219,244,62,39,29,98,47,77,154,11,140,231,6,136,53,252,208,250,177,42,91,33,190,142,88,14,18,214,28,129,133,30,133,89,226,8,38,98,62,208,165,166,207,68,120,98,214,150,193,176,145,198,201,186,106,16,220,59,132,216,163,89,42,58,104,205,241,36,207,195,15,207,110,248,209,223,155,209,94,68,255,238,92,136,235,78,172,88,248,133,4,141,103,118,242,192,95,127,194,19,201,129,29,189,28,86,94,34,34,24,254,225,166,15,182,210,161,170,227,225,20,86,188,146,232,1,28,167,70,203,165,64,9,141,148,75,226,69,184,169,132,130,136,93,193,75,194,75,87,192,133,158,156,44,0,247,1,194,29,149,219,96,102,47,57,102,27,90,120,4,67,9,54,184,107,239,155,118,214,162,161,22,14,35,230,73,198,105,81,98,77,115,211,207,106,132,58,96,201,70,93,203,222,233,182,239,165,206,33,145,220,90,250,155,25,81,162,118,202,236,142,35,182,103,231,150,253,53,201,33,146,254,146,84,43,193,96,61,229,200,23,186,50,25,132,254,39,218,131,109,200,53,107,183,23,77,21,251,16,174,242,141,48,72,175,168,51,58,140,126,126,76,218,38,82,184,113,164,27,125,134,159,250,165,89,242,131,111,244,193,113,87,163,141,13,233,27,213,30,157,181,149,180,143,21,117,130,53,67,117,124,100,0,43,163,24,154,10,78,127,3,69,21,235,243,51,7,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5529809d-8f78-42fd-bd40-aa8391712314"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f010ffe-ee34-4391-8b8c-61723d04428a"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 217),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(371, 177),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoqdCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("93a50243-68bb-4365-a307-d6826d90feba"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5529809d-8f78-42fd-bd40-aa8391712314"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"PageLoqdCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 79),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoqdCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("7583f571-fafd-42ae-ac35-c574ff8a597d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5529809d-8f78-42fd-bd40-aa8391712314"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"PageLoqdCompleteIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(155, 79),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChildPageLoadCompleteScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("25377329-ef62-4222-88f2-eea008638ec5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5529809d-8f78-42fd-bd40-aa8391712314"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"ChildPageLoadCompleteScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(260, 59),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,148,207,110,26,49,16,198,207,139,148,119,112,114,218,149,144,95,128,36,82,10,36,162,74,83,84,146,92,170,30,220,245,44,184,93,108,100,123,105,105,196,187,119,60,94,186,127,128,72,149,16,135,245,204,111,190,249,60,158,173,176,204,229,43,88,11,118,195,238,149,150,19,112,106,169,65,206,173,201,193,185,5,157,165,217,232,98,48,23,75,224,247,170,244,96,167,82,121,190,0,223,13,138,156,16,122,49,216,34,87,22,200,156,64,33,170,210,191,138,178,2,199,132,99,19,149,123,101,180,176,187,107,231,173,210,203,33,235,96,230,194,138,53,96,17,74,185,37,154,42,88,26,104,55,76,87,101,153,177,183,139,65,98,193,87,86,51,111,43,192,152,125,8,139,60,6,218,43,191,139,180,153,68,13,178,248,122,53,237,124,188,250,198,9,63,138,236,203,152,201,103,238,9,249,159,237,116,189,241,187,180,203,201,98,217,54,231,133,232,26,126,177,135,74,201,126,60,178,19,252,145,109,49,107,34,188,88,152,202,230,192,219,128,30,114,212,77,58,120,77,122,239,180,124,134,223,62,237,165,12,49,229,221,66,124,44,54,193,117,254,108,22,212,106,154,145,190,32,176,118,173,160,155,117,181,93,13,33,222,184,107,57,150,144,101,139,83,150,213,144,218,171,36,76,193,15,103,244,216,232,45,88,60,169,237,58,162,127,108,7,165,33,53,121,113,96,241,147,6,26,23,28,146,222,248,53,140,216,73,168,21,203,143,77,89,198,44,44,23,200,28,135,26,172,18,165,250,3,7,137,67,230,119,27,48,69,218,215,210,100,103,67,70,74,130,226,71,229,252,117,71,229,45,123,235,245,182,207,104,190,207,242,72,102,240,238,72,230,101,123,176,219,173,132,78,31,172,169,54,216,201,233,251,13,111,182,54,145,2,63,236,158,240,249,28,149,224,225,107,52,170,37,161,193,247,20,156,25,166,113,101,45,78,57,94,125,149,227,235,59,220,135,227,95,96,109,182,208,167,214,245,246,244,255,159,196,59,41,143,154,136,188,128,219,159,125,88,143,70,200,127,52,218,91,201,137,197,213,36,164,39,49,217,97,165,208,233,204,125,18,62,95,225,77,99,58,234,112,132,25,175,32,255,9,242,236,205,52,79,28,205,13,11,130,211,27,57,177,73,167,90,124,47,27,210,187,229,104,31,182,119,223,95,238,223,143,123,194,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("32cea53f-005b-48ec-a268-b9390bac99d8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cac106e7-3f8b-4095-876a-65467ce98c3d"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"EventSubProcess4",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(480, 254),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEntityEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7f55766f-6a7c-44d9-901f-eb0957fd0f0e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("32cea53f-005b-48ec-a268-b9390bac99d8"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EntityEditChange",
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"EntityEditChangeStartMessage",
				Position = new Point(36, 118),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("58962d98-d462-4a9a-9b13-f0558c86f29f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("32cea53f-005b-48ec-a268-b9390bac99d8"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 104),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareChangeSchemaEntityQuestionScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("dad01b3a-50e3-487c-9db7-8b9a97a89768"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("32cea53f-005b-48ec-a268-b9390bac99d8"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"PrepareChangeSchemaEntityQuestionScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(232, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,140,49,14,130,64,16,69,107,57,197,102,107,226,5,80,11,145,130,66,80,129,130,114,67,38,64,225,172,217,25,162,132,112,119,119,227,22,38,24,105,230,103,242,223,251,113,167,176,133,162,233,224,174,18,228,158,199,138,192,156,129,72,181,176,189,216,35,246,194,69,20,196,127,81,159,37,188,216,26,75,214,247,107,51,105,163,209,250,242,90,37,69,153,230,153,92,19,142,3,179,70,114,78,157,20,89,190,42,220,128,30,86,0,255,59,19,225,41,78,125,195,189,70,101,198,29,177,233,177,13,197,39,15,98,10,54,147,28,129,100,40,228,114,187,6,242,83,114,14,29,137,250,55,152,233,47,110,142,2,3,60,24,20,108,6,136,222,35,22,238,217,135,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeSchemaEntityUserMessageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("8ba9bbd4-5bbb-4408-8f5a-b3fb64b0cad4"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("32cea53f-005b-48ec-a268-b9390bac99d8"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"ChangeSchemaEntityUserMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(379, 27),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeChangeSchemaEntityUserMessageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("0dd3b78a-308d-4021-a036-d70fc50d4aef"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("32cea53f-005b-48ec-a268-b9390bac99d8"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"ChangeSchemaEntityYesMessage",
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(253, 188),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e03e5fd2-9f25-47e7-a4b3-d42bbf3d5e6c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("287fa743-372d-4723-a04c-e5ca0f11c23e"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"EventSubProcess5",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(354, 247),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateIsMatchConditionsEditCheckStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1ced1643-be18-4abd-84b4-14e10239ccb7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e03e5fd2-9f25-47e7-a4b3-d42bbf3d5e6c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"IsMatchConditionsEditCheck",
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"IsMatchConditionsEditCheckStartMessage",
				Position = new Point(43, 114),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateIsMatchConditionsEditCheckScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("65d61b51-6456-4b60-a1d6-11d524bf9f8d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e03e5fd2-9f25-47e7-a4b3-d42bbf3d5e6c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"IsMatchConditionsEditCheckScript",
				Position = new Point(190, 100),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,203,204,41,73,45,114,77,201,44,209,115,205,75,76,202,73,77,81,176,85,8,0,201,120,22,251,38,150,36,103,56,231,231,1,37,51,243,243,138,193,138,156,51,82,147,179,83,83,172,185,138,82,75,74,139,242,20,74,138,74,83,173,1,233,70,199,142,74,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChangeSchemaEntityYesMessageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChangeSchemaEntityYesMessage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c9d0ab1a-aace-4856-b9a9-1bc42f1f3b9c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cac106e7-3f8b-4095-876a-65467ce98c3d"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"EventSubProcessChangeSchemaEntityYesMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 279),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(273, 142),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChangeSchemaEntityYesMessage;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeSchemaEntityYesMessageBaseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("bb1a291e-f14a-4c9e-a0c4-e1a9cc02f4be"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c9d0ab1a-aace-4856-b9a9-1bc42f1f3b9c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeSchemaEntityYesMessage",
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"ChangeSchemaEntityYesMessageBase",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeSchemaEntityYesMessageScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("562a6b46-d10a-4048-aa27-04feefbc7a9c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c9d0ab1a-aace-4856-b9a9-1bc42f1f3b9c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"ChangeSchemaEntityYesMessageScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(154, 43),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,205,78,195,48,16,132,207,173,212,119,48,57,57,23,191,64,41,151,224,162,72,128,42,89,133,243,214,89,53,22,142,13,254,17,244,237,89,59,84,66,21,63,55,107,188,243,121,102,45,93,50,233,164,244,136,19,236,251,129,109,86,203,5,119,248,206,20,90,212,137,239,35,134,206,59,71,103,227,93,75,183,11,209,121,155,39,199,27,154,111,138,34,182,193,79,188,81,167,56,115,102,241,121,196,128,188,57,207,244,81,190,101,176,124,54,139,29,4,152,48,97,224,252,46,155,161,221,193,17,133,172,97,228,96,146,120,2,155,177,109,25,196,175,36,21,34,63,80,231,132,74,131,133,112,93,140,55,188,93,175,150,7,239,45,51,241,209,39,57,189,18,225,178,20,187,84,174,54,172,184,69,29,39,192,183,231,111,33,129,242,57,104,20,127,16,206,158,62,62,64,210,35,173,136,82,211,134,98,77,223,141,168,95,176,216,126,13,69,128,206,34,148,229,166,224,109,237,27,107,153,202,221,26,75,203,169,48,233,224,96,255,133,253,220,224,222,195,160,82,200,58,101,250,140,66,15,72,71,199,72,195,245,39,236,55,148,171,253,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChangeSchemaEntityNoMessageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChangeSchemaEntityNoMessage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("54e3e586-3340-4cd7-b511-3122319c0c39"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cac106e7-3f8b-4095-876a-65467ce98c3d"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"EventSubProcessChangeSchemaEntityNoMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(344, 279),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(273, 143),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChangeSchemaEntityNoMessage;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeSchemaEntityNoMessageBaseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3ed362cc-658d-46a6-9fb9-5b9e0ab8ad17"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("54e3e586-3340-4cd7-b511-3122319c0c39"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeSchemaEntityNoMessage",
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"ChangeSchemaEntityNoMessageBase",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeSchemaEntityNoMessageScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4ad2800f-64dc-4ed6-8c01-2da6161971cc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("54e3e586-3340-4cd7-b511-3122319c0c39"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"ChangeSchemaEntityNoMessageScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(161, 43),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,206,193,10,130,64,16,198,241,115,11,190,195,118,83,136,125,1,233,32,181,68,183,104,173,251,224,78,182,146,163,172,51,161,68,239,222,193,75,136,247,223,199,255,11,15,157,90,226,192,147,171,158,216,194,237,236,245,118,175,79,18,188,177,109,207,83,166,63,137,218,92,160,70,51,59,235,3,27,39,67,143,228,139,6,70,251,70,226,33,205,242,53,134,124,135,151,96,65,190,196,145,151,165,157,254,27,28,129,193,117,18,43,52,51,48,7,232,57,116,100,202,206,113,12,84,167,217,106,228,138,131,180,184,184,242,77,84,162,34,178,68,210,28,5,243,31,152,149,179,248,233,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8502337d-da57-4595-b0ac-d52bddba7b60"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4b569258-ac8d-49c7-8b2c-26944a418cec"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"EventSubProcess6",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(621, 333),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteOkButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("33b3a322-7778-4633-a45f-bda9bfdc9d64"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8502337d-da57-4595-b0ac-d52bddba7b60"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"DeleteOkButtonClickStartMessage",
				Position = new Point(43, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateDeleteOkButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("7ff23690-9eb5-4ef1-9fb8-8a806daae295"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8502337d-da57-4595-b0ac-d52bddba7b60"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"DeleteOkButtonClickIntermediateThrowMessageEvent",
				Position = new Point(554, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleteOkButtonClickScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("fe9efc90-8976-4a9f-8c52-5726279ab07e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8502337d-da57-4595-b0ac-d52bddba7b60"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"DeleteOkButtonClickScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(400, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,84,65,78,195,48,16,60,83,169,127,176,122,114,164,42,15,40,20,36,218,128,130,68,65,74,225,130,56,88,201,150,26,92,187,216,14,80,16,127,103,109,39,33,105,81,5,7,110,201,122,188,51,187,51,73,34,96,5,210,206,224,117,194,214,150,43,73,198,228,154,61,64,60,231,86,64,82,112,27,207,225,205,30,246,123,253,222,11,211,68,42,9,183,153,3,105,149,131,49,89,190,132,21,187,102,154,173,192,130,190,101,162,132,76,149,58,135,120,134,208,195,112,43,87,210,216,95,94,155,120,172,43,52,164,235,26,103,124,221,75,236,86,152,33,83,158,59,253,76,111,142,140,213,92,62,12,247,145,29,99,115,190,32,116,167,245,152,200,82,136,136,124,244,123,7,219,44,227,31,240,68,194,235,95,185,105,20,33,253,167,27,47,192,9,90,192,237,38,128,211,2,187,38,173,194,77,90,196,201,115,201,132,161,231,37,199,231,213,218,110,34,114,66,194,229,240,78,70,59,119,230,42,243,0,234,216,182,132,223,13,146,14,229,224,190,26,101,143,110,26,182,114,169,10,190,224,80,164,178,161,114,130,49,42,205,251,16,97,193,78,60,169,84,166,102,134,139,189,210,94,45,237,14,236,134,169,146,53,170,195,226,122,212,59,238,162,113,117,77,52,22,92,160,188,137,18,2,242,118,124,207,124,221,231,119,202,44,171,178,117,198,101,17,78,204,185,86,229,250,116,51,195,249,232,224,27,61,136,170,200,62,26,37,49,138,47,160,241,164,182,185,233,84,53,185,104,131,40,10,190,49,78,140,148,65,204,112,143,150,200,143,176,227,202,14,197,63,26,227,197,165,230,146,217,124,137,162,17,135,154,141,215,57,89,66,254,4,5,218,82,127,186,163,202,160,182,45,191,106,128,248,3,183,167,56,3,205,153,224,239,64,183,77,27,118,183,29,33,89,59,218,181,223,26,108,169,37,177,26,127,13,95,165,132,142,144,184,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckData_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bae40c13-b935-446f-b233-f4b1dc204655"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8502337d-da57-4595-b0ac-d52bddba7b60"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"CheckData_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 156),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,65,11,130,64,16,133,207,9,254,135,201,147,93,164,187,120,40,179,8,194,132,160,251,160,99,8,235,174,204,236,70,18,254,247,52,139,174,221,102,222,251,230,189,185,35,67,221,40,75,44,144,64,129,55,138,246,239,53,171,26,27,237,208,226,197,56,46,39,85,87,179,35,7,54,174,219,246,57,182,20,6,63,58,88,197,190,215,212,16,126,242,162,212,56,109,33,73,96,189,130,167,239,45,142,50,195,5,50,182,114,69,229,72,82,195,76,229,72,65,141,74,104,76,24,128,198,225,143,131,229,183,231,40,27,221,159,168,182,217,163,99,18,105,140,206,157,82,103,206,218,206,246,225,244,214,224,123,76,214,177,6,203,142,226,23,215,108,222,29,246,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("09fb1a1d-fd7a-4d41-b8b2-e513c113a687"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8502337d-da57-4595-b0ac-d52bddba7b60"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(267, 156),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateErrorMessage_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1fb36f27-c054-4858-8563-f030a3caceed"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8502337d-da57-4595-b0ac-d52bddba7b60"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				Name = @"ErrorMessage_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(400, 233),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,243,77,204,204,243,77,45,46,6,178,3,18,243,82,115,244,28,83,82,160,124,141,176,196,156,204,148,196,146,204,124,152,138,144,204,146,156,84,29,5,12,113,29,5,152,130,202,130,84,189,240,196,162,188,204,188,116,77,107,94,46,94,174,162,212,146,210,162,60,133,146,162,210,84,107,0,3,11,206,34,113,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateClearControlValuesMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d4159d90-4d80-4bc4-804d-6cc2ca63435e"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a9b659b5-9ae3-4218-9fe8-8047f8e6b589"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b6881e55-7df2-4cef-8151-adab44274ad1"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "UIControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0840abef-9bb9-452e-a8da-ae98b5fb397d"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e1b12ba7-35df-4582-a18f-8349f8901d2b"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("395c0893-45f5-4747-8c43-12d14bcfa507"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5285cb12-8a7c-420b-b889-dc20a04f394b"),
				Name = "Terrasoft.Configuration.VwSysEntitySchemaInWorkspace",
				Alias = "VwSysEntitySchemaInWorkspace",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b424ebf7-dbe4-4ba3-91b6-f05370f2faa3"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("efe0905f-8bb1-451e-97ec-00fde53dde25"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f4cf022c-59a4-4abc-8be8-e1b17699bfcc"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c7ef416a-28ae-4242-a67b-3039bc5ef70e"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("568a5dd3-ca8b-4c5e-baa6-5708bd17ad12")
			});
		}

		protected override SchemaMethod CreateGetEditorsBindingMethod() {
			SchemaMethod method = base.CreateGetEditorsBindingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,41,46,41,202,204,75,215,81,8,73,45,42,74,44,206,79,43,209,11,245,212,11,79,77,114,206,207,43,41,202,207,41,70,98,219,105,104,42,84,115,113,86,43,185,230,149,100,150,84,6,39,103,164,230,38,122,166,40,233,40,4,36,166,167,234,65,68,93,83,50,75,106,117,184,56,245,245,171,149,60,139,125,19,75,146,51,128,218,129,130,64,251,138,97,74,49,36,192,186,184,106,173,1,154,80,130,24,164,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateMakeCaptionMethod() {
			SchemaMethod method = base.CreateMakeCaptionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,8,72,76,79,213,115,44,46,0,209,10,137,197,10,33,169,69,69,137,197,249,105,37,122,161,158,122,225,169,73,206,249,121,37,69,249,57,197,122,32,5,154,122,206,137,5,37,153,249,121,10,182,10,197,37,69,153,121,233,122,158,197,126,165,57,57,254,69,174,185,5,37,149,26,96,211,66,50,75,114,82,93,83,50,75,244,66,82,43,74,52,21,236,121,185,56,93,115,82,115,83,243,74,252,82,203,97,38,88,41,96,81,108,13,0,225,43,200,61,144,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateClearControlValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("aa2263e9-a8c1-4928-956f-7a125b0b7960"),
				Name = "ClearControlValues",
				CreatedInSchemaUId = new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,203,204,41,73,45,114,77,201,44,209,115,205,75,76,202,73,77,81,176,85,72,75,204,41,78,181,230,229,42,75,44,82,72,131,43,112,47,202,47,45,0,202,6,128,244,185,230,149,100,150,84,186,36,150,36,6,231,151,22,37,131,12,202,75,129,24,86,12,86,232,84,233,151,152,155,170,17,128,102,137,27,170,113,32,53,154,64,155,208,108,209,115,206,73,77,44,210,0,201,0,0,45,245,107,225,166,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DeleteDataUserTaskParametersEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("efc0bdf3-0c98-4694-a94f-9c1bcdd7c48b"));
		}

		#endregion

	}

	#endregion

}

