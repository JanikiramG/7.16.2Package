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
	using UIControls = Terrasoft.UI.WebControls;

	#region Class: DeleteEntityCollectionItemsUserTaskParametersEditPageSchema

	/// <exclude/>
	public class DeleteEntityCollectionItemsUserTaskParametersEditPageSchema : Terrasoft.WebApp.BaseProcessParametersEditPageSchema
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

		private Terrasoft.UI.WebControls.Controls.TextEdit _entityCollectionTextEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit EntityCollectionTextEdit {
			get {
				return _entityCollectionTextEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _entityCollectionEditToolButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton EntityCollectionEditToolButton {
			get {
				return _entityCollectionEditToolButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _entityCollectionEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit EntityCollectionEdit {
			get {
				return _entityCollectionEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _matchConditionsLabel;
		public Terrasoft.UI.WebControls.Controls.Label MatchConditionsLabel {
			get {
				return _matchConditionsLabel;
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

		private Terrasoft.UI.WebControls.Controls.EntityDataSource _entityDataSource;
		public Terrasoft.UI.WebControls.Controls.EntityDataSource EntityDataSource {
			get {
				return _entityDataSource;
			}
		}

		#endregion

		#region Constructors: Public

		public DeleteEntityCollectionItemsUserTaskParametersEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public DeleteEntityCollectionItemsUserTaskParametersEditPageSchema(DeleteEntityCollectionItemsUserTaskParametersEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
			RealUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
			Name = "DeleteEntityCollectionItemsUserTaskParametersEditPage";
			ParentSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 350;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateDeleteEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema();
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
			ControlLayout2.InsertItem(1, CreateEntityCollectionTextEdit());
			EntityCollectionTextEdit.InsertItem(0, CreateEntityCollectionEditToolButton());
			ControlLayout2.InsertItem(2, CreateEntityCollectionEdit());
			ControlLayout2.InsertItem(3, CreateMatchConditionsLabel());
			ControlLayout2.InsertItem(4, CreateIsMatchConditionsEdit());
			ControlLayout1.InsertItem(1, CreateFilterControlLayout());
			FilterControlLayout.InsertItem(0, CreateFilterEdit());
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

		protected virtual EmbeddedProcessSchema CreateDeleteEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema() {
			var schema = new DeleteEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateTitleEdit() {
			_titleEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_titleEdit.UId = new Guid("cc612fb4-b398-4824-a668-ef26b93dc1b6");
			_titleEdit.Name = "TitleEdit";
			_titleEdit.CreatedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
			_titleEdit.ModifiedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
			_titleEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_titleEdit.Tag = "";
			_titleEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_titleEdit.Image = new ControlImage {};
			_titleEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _titleEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateEntityCollectionEditToolButton() {
			_entityCollectionEditToolButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_entityCollectionEditToolButton.UId = new Guid("48c64993-9806-4280-90cc-5ce93f02844b");
			_entityCollectionEditToolButton.Name = "EntityCollectionEditToolButton";
			_entityCollectionEditToolButton.CreatedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
			_entityCollectionEditToolButton.ModifiedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
			_entityCollectionEditToolButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityCollectionEditToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_entityCollectionEditToolButton.Tag = "";
			_entityCollectionEditToolButton.Image = new ControlImage {};
			return _entityCollectionEditToolButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateEntityCollectionTextEdit() {
			_entityCollectionTextEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_entityCollectionTextEdit.UId = new Guid("c2b2ab8c-5c9f-4444-8268-2a91c8d1c2a8");
			_entityCollectionTextEdit.Name = "EntityCollectionTextEdit";
			_entityCollectionTextEdit.CreatedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
			_entityCollectionTextEdit.ModifiedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
			_entityCollectionTextEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityCollectionTextEdit.Tag = "";
			_entityCollectionTextEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_entityCollectionTextEdit.Image = new ControlImage {};
			_entityCollectionTextEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_entityCollectionTextEdit.Required = true;
			return _entityCollectionTextEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateEntityCollectionEdit() {
			_entityCollectionEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_entityCollectionEdit.UId = new Guid("837e8aba-cbe5-4972-ab88-342e92e8eabb");
			_entityCollectionEdit.Name = "EntityCollectionEdit";
			_entityCollectionEdit.CreatedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
			_entityCollectionEdit.ModifiedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
			_entityCollectionEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityCollectionEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_entityCollectionEdit.Tag = "";
			_entityCollectionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_entityCollectionEdit.DataValueTypeUId = new Guid("51fb23ba-3eb2-11e2-b7d5-b0c76188709b");
			_entityCollectionEdit.Image = new ControlImage {};
			_entityCollectionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_entityCollectionEdit.Hidden = true;
			return _entityCollectionEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateMatchConditionsLabel() {
			_matchConditionsLabel = new Terrasoft.UI.WebControls.Controls.Label();
			_matchConditionsLabel.UId = new Guid("d6e90b1d-4816-4e17-b39a-32302e814812");
			_matchConditionsLabel.Name = "MatchConditionsLabel";
			_matchConditionsLabel.CreatedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
			_matchConditionsLabel.ModifiedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
			_matchConditionsLabel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_matchConditionsLabel.Tag = "";
			_matchConditionsLabel.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			return _matchConditionsLabel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsMatchConditionsEdit() {
			_isMatchConditionsEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isMatchConditionsEdit.UId = new Guid("83332277-b788-4bbe-8302-c473f0b0e823");
			_isMatchConditionsEdit.Name = "IsMatchConditionsEdit";
			_isMatchConditionsEdit.CreatedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
			_isMatchConditionsEdit.ModifiedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
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
			_controlLayout2.UId = new Guid("a9f01720-beed-4e44-808f-7531aba5cbd8");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
			_controlLayout2.ModifiedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
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
			_filterEdit.UId = new Guid("cb416c6c-cf47-4dc2-af08-a3eb69834f71");
			_filterEdit.Name = "FilterEdit";
			_filterEdit.CreatedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
			_filterEdit.ModifiedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
			_filterEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterEdit.Tag = "";
			_filterEdit.DataSourceId = "EntityDataSource";
			_filterEdit.Edges = "1 1 1 1";
			_filterEdit.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_filterEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _filterEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateFilterControlLayout() {
			_filterControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_filterControlLayout.UId = new Guid("7173f86c-e36d-43df-b738-f6930b82a435");
			_filterControlLayout.Name = "FilterControlLayout";
			_filterControlLayout.CreatedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
			_filterControlLayout.ModifiedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
			_filterControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterControlLayout.Tag = "";
			_filterControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_filterControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_filterControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_filterControlLayout.StartNewAlignGroup = false;
			_filterControlLayout.Image = new ControlImage {};
			_filterControlLayout.Edges = "";
			return _filterControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("71a37e9f-49fc-4919-927b-d7e77b6af86f");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
			_controlLayout1.ModifiedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
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
			_entityDataSource.UId = new Guid("a3bddb89-f666-48ff-a276-fe7d34fcebe3");
			_entityDataSource.Name = "EntityDataSource";
			_entityDataSource.CreatedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
			_entityDataSource.ModifiedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
			_entityDataSource.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityDataSource.Tag = "";
			_entityDataSource.EnableServerActiveRow = false;
			_entityDataSource.SchemaUId = Guid.Empty;
			_entityDataSource.HierarchicalDepth = 1;
			_entityDataSource.DefStructure.ID = "c" + _entityDataSource.DefStructure.UId.ToString("N");
			_entityDataSource.DefStructure.UId = new Guid("3e9a3139-c345-4bc1-bbc7-db2a14d4ccf8");
			_entityDataSource.DefStructure.Name = "DefStructure";
			_entityDataSource.DefStructure.CreatedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
			_entityDataSource.DefStructure.ModifiedInSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
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
			return new DeleteEntityCollectionItemsUserTaskParametersEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new DeleteEntityCollectionItemsUserTaskParametersEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f94380f0-f678-48bc-baee-db6a795fdafe"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new DeleteEntityCollectionItemsUserTaskParametersEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: DeleteEntityCollectionItemsUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class DeleteEntityCollectionItemsUserTaskParametersEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.DeleteEntityCollectionItemsUserTaskParametersEditPageSchemaUserControl
	{

		#region Class: ChangeEntityCollectionUserMessageFlowElement

		/// <exclude/>
		public class ChangeEntityCollectionUserMessageFlowElement : QuestionUserTask
		{

			public ChangeEntityCollectionUserMessageFlowElement(UserConnection userConnection, DeleteEntityCollectionItemsUserTaskParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeEntityCollectionUserMessage";
				IsLogging = false;
				SchemaElementUId = new Guid("259a02a2-25e0-4164-8c21-e421bcd782fd");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public DeleteEntityCollectionItemsUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DeleteEntityCollectionItemsUserTaskParametersEditPageEventsProcess";
			SchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f94380f0-f678-48bc-baee-db6a795fdafe");
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

		private string _collectionItemsDataSourceId;
		public virtual string CollectionItemsDataSourceId {
			get {
				return _collectionItemsDataSourceId ?? (_collectionItemsDataSourceId = new LocalizableString(Storage, "f94380f0f67848bcbaeedb6a795fdafe",
						 "EventsProcessSchema.Parameters.CollectionItemsDataSourceId.Value"));
			}
			set {
				_collectionItemsDataSourceId = value;
			}
		}

		public virtual bool IsFilterParamsValuesCorrect {
			get;
			set;
		}

		public virtual string EntityCollectionMetaPath {
			get;
			set;
		}

		public virtual Guid EntityCollectionSchemaUId {
			get;
			set;
		}

		public virtual bool IsNew {
			get;
			set;
		}

		public virtual string EntityCollectionDisplayValue {
			get;
			set;
		}

		public virtual string NewEntityCollectionParameterValue {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess3;
		public ProcessFlowElement EventSubProcess3 {
			get {
				return _eventSubProcess3 ?? (_eventSubProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3",
					SchemaElementUId = new Guid("29f8fde4-c059-4a0e-a04a-245cd8da6c20"),
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
					SchemaElementUId = new Guid("a8177037-7d5b-4a86-93e8-f1639c8c4695"),
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
					SchemaElementUId = new Guid("513108bb-1bcb-497b-b5f6-316421c007d8"),
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
					SchemaElementUId = new Guid("20e15f77-c511-4b6d-aea7-4bf8ea407353"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChildInitScriptExecute,
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
					SchemaElementUId = new Guid("9becf0ae-0e97-40b5-958f-8400e334de91"),
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
					SchemaElementUId = new Guid("b56d78a6-d5cc-4054-897d-a1f615496567"),
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
					SchemaElementUId = new Guid("1b9a45ff-301e-4c71-adef-347f34a3a338"),
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
					SchemaElementUId = new Guid("d0865375-3022-43c6-ac64-4b47590d228f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChildPageLoadCompleteScriptExecute,
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
					SchemaElementUId = new Guid("6aa51f3f-1816-4d4c-8c34-e48e225c5f1e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _prepareChangeEntityCollectionQuestionScript;
		public ProcessScriptTask PrepareChangeEntityCollectionQuestionScript {
			get {
				return _prepareChangeEntityCollectionQuestionScript ?? (_prepareChangeEntityCollectionQuestionScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareChangeEntityCollectionQuestionScript",
					SchemaElementUId = new Guid("3d2eed15-85d6-4d60-96c4-b135257bcf9e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareChangeEntityCollectionQuestionScriptExecute,
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
					SchemaElementUId = new Guid("3c983fdf-a228-41b2-a92c-40138e0baeff"),
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

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent1 {
			get {
				return _intermediateThrowMessageEvent1 ?? (_intermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("7ed037e4-515c-49ed-85ee-e463f2c7b466"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "ChangeEntityCollectionYesMessage",
				});
			}
		}

		private ChangeEntityCollectionUserMessageFlowElement _changeEntityCollectionUserMessage;
		public ChangeEntityCollectionUserMessageFlowElement ChangeEntityCollectionUserMessage {
			get {
				return _changeEntityCollectionUserMessage ?? (_changeEntityCollectionUserMessage = new ChangeEntityCollectionUserMessageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _newEntityCollectionParameterValueScriptTask;
		public ProcessScriptTask NewEntityCollectionParameterValueScriptTask {
			get {
				return _newEntityCollectionParameterValueScriptTask ?? (_newEntityCollectionParameterValueScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "NewEntityCollectionParameterValueScriptTask",
					SchemaElementUId = new Guid("a334792f-8081-4186-b9da-bed989bef183"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = NewEntityCollectionParameterValueScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _startMessage212;
		public ProcessFlowElement StartMessage212 {
			get {
				return _startMessage212 ?? (_startMessage212 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage212",
					SchemaElementUId = new Guid("7a98b771-209f-43f5-9973-b4f857257260"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessChangeEntityCollectionYesMessage;
		public ProcessFlowElement EventSubProcessChangeEntityCollectionYesMessage {
			get {
				return _eventSubProcessChangeEntityCollectionYesMessage ?? (_eventSubProcessChangeEntityCollectionYesMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChangeEntityCollectionYesMessage",
					SchemaElementUId = new Guid("a2ed35de-f070-43d2-a8dc-170d83057e64"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _changeEntityCollectionYesMessageBase;
		public ProcessFlowElement ChangeEntityCollectionYesMessageBase {
			get {
				return _changeEntityCollectionYesMessageBase ?? (_changeEntityCollectionYesMessageBase = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChangeEntityCollectionYesMessageBase",
					SchemaElementUId = new Guid("7c2602fe-e2ff-422b-b386-4cf44adac209"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _changeEntityCollectionYesMessageScript;
		public ProcessScriptTask ChangeEntityCollectionYesMessageScript {
			get {
				return _changeEntityCollectionYesMessageScript ?? (_changeEntityCollectionYesMessageScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChangeEntityCollectionYesMessageScript",
					SchemaElementUId = new Guid("2d824c8f-5018-451a-8869-5ba0b11df0f5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChangeEntityCollectionYesMessageScriptExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessChangeEntityCollectionNoMessage;
		public ProcessFlowElement EventSubProcessChangeEntityCollectionNoMessage {
			get {
				return _eventSubProcessChangeEntityCollectionNoMessage ?? (_eventSubProcessChangeEntityCollectionNoMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChangeEntityCollectionNoMessage",
					SchemaElementUId = new Guid("284cb2c2-ba13-4263-b72e-756c5544507a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _changeEntityCollectionNoMessageBase;
		public ProcessFlowElement ChangeEntityCollectionNoMessageBase {
			get {
				return _changeEntityCollectionNoMessageBase ?? (_changeEntityCollectionNoMessageBase = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChangeEntityCollectionNoMessageBase",
					SchemaElementUId = new Guid("a8f1064a-ee42-4e4f-b135-9e5e7fe5825a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _changeEntityCollectionNoMessageScript;
		public ProcessScriptTask ChangeEntityCollectionNoMessageScript {
			get {
				return _changeEntityCollectionNoMessageScript ?? (_changeEntityCollectionNoMessageScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChangeEntityCollectionNoMessageScript",
					SchemaElementUId = new Guid("3ce0e05e-8390-4205-a7b0-00f3c8cc910a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChangeEntityCollectionNoMessageScriptExecute,
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
					SchemaElementUId = new Guid("71b2aee4-eba1-484f-8087-4c68ae6e85c9"),
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
					SchemaElementUId = new Guid("613bddba-645b-4f97-93b0-422c6a4e8fae"),
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
					SchemaElementUId = new Guid("7de82a5f-b020-4e5c-bb6f-0598c60ccb0d"),
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
					SchemaElementUId = new Guid("91bc3a6f-1404-42a7-bea1-4478b81d9968"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeleteOkButtonClickScriptExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess7;
		public ProcessFlowElement EventSubProcess7 {
			get {
				return _eventSubProcess7 ?? (_eventSubProcess7 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess7",
					SchemaElementUId = new Guid("e609f7b8-0935-437f-a0be-96e4e54f35ad"),
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
					SchemaElementUId = new Guid("37bca9ee-985b-4731-874f-0dc4c12b5e4d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _deleteEntityCollectionScriptTask1;
		public ProcessScriptTask DeleteEntityCollectionScriptTask1 {
			get {
				return _deleteEntityCollectionScriptTask1 ?? (_deleteEntityCollectionScriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeleteEntityCollectionScriptTask1",
					SchemaElementUId = new Guid("4babf40b-80c0-44f6-900b-5cdbffa217b5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeleteEntityCollectionScriptTask1Execute,
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
					SchemaElementUId = new Guid("5cf9b002-ac3e-4d5d-8e0c-735eb97d909a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
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

		private LocalizableString _changeSchemaEntityMessage;
		public LocalizableString ChangeSchemaEntityMessage {
			get {
				return _changeSchemaEntityMessage ?? (_changeSchemaEntityMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ChangeSchemaEntityMessage.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[InitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitStartMessage };
			FlowElements[InitIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { InitIntermediateThrowMessageEvent };
			FlowElements[ChildInitScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildInitScript };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[PageLoqdCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoqdCompleteStartMessage };
			FlowElements[PageLoqdCompleteIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoqdCompleteIntermediateThrowMessageEvent };
			FlowElements[ChildPageLoadCompleteScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildPageLoadCompleteScript };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[PrepareChangeEntityCollectionQuestionScript.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareChangeEntityCollectionQuestionScript };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[ChangeEntityCollectionUserMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionUserMessage };
			FlowElements[NewEntityCollectionParameterValueScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { NewEntityCollectionParameterValueScriptTask };
			FlowElements[StartMessage212.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage212 };
			FlowElements[EventSubProcessChangeEntityCollectionYesMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChangeEntityCollectionYesMessage };
			FlowElements[ChangeEntityCollectionYesMessageBase.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionYesMessageBase };
			FlowElements[ChangeEntityCollectionYesMessageScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionYesMessageScript };
			FlowElements[EventSubProcessChangeEntityCollectionNoMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChangeEntityCollectionNoMessage };
			FlowElements[ChangeEntityCollectionNoMessageBase.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionNoMessageBase };
			FlowElements[ChangeEntityCollectionNoMessageScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionNoMessageScript };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[DeleteOkButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteOkButtonClickStartMessage };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[DeleteOkButtonClickScript.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteOkButtonClickScript };
			FlowElements[EventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[DeleteEntityCollectionScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteEntityCollectionScriptTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3":
						break;
					case "InitStartMessage":
						e.Context.QueueTasks.Enqueue("InitIntermediateThrowMessageEvent");
						break;
					case "InitIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("ChildInitScript");
						break;
					case "ChildInitScript":
						break;
					case "EventSubProcess4":
						break;
					case "PageLoqdCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoqdCompleteIntermediateThrowMessageEvent");
						break;
					case "PageLoqdCompleteIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("ChildPageLoadCompleteScript");
						break;
					case "ChildPageLoadCompleteScript":
						break;
					case "EventSubProcess5":
						break;
					case "PrepareChangeEntityCollectionQuestionScript":
						e.Context.QueueTasks.Enqueue("ChangeEntityCollectionUserMessage");
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("PrepareChangeEntityCollectionQuestionScript");
							break;
						}
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "ChangeEntityCollectionUserMessage":
						break;
					case "NewEntityCollectionParameterValueScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "StartMessage212":
						e.Context.QueueTasks.Enqueue("NewEntityCollectionParameterValueScriptTask");
						break;
					case "EventSubProcessChangeEntityCollectionYesMessage":
						break;
					case "ChangeEntityCollectionYesMessageBase":
						e.Context.QueueTasks.Enqueue("ChangeEntityCollectionYesMessageScript");
						break;
					case "ChangeEntityCollectionYesMessageScript":
						break;
					case "EventSubProcessChangeEntityCollectionNoMessage":
						break;
					case "ChangeEntityCollectionNoMessageBase":
						e.Context.QueueTasks.Enqueue("ChangeEntityCollectionNoMessageScript");
						break;
					case "ChangeEntityCollectionNoMessageScript":
						break;
					case "EventSubProcess6":
						break;
					case "DeleteOkButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("DeleteOkButtonClickScript");
						break;
					case "IntermediateThrowMessageEvent2":
						break;
					case "DeleteOkButtonClickScript":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "EventSubProcess7":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("DeleteEntityCollectionScriptTask1");
						break;
					case "DeleteEntityCollectionScriptTask1":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(!IsNew);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("InitStartMessage");
			ActivatedEventElements.Add("PageLoqdCompleteStartMessage");
			ActivatedEventElements.Add("StartMessage212");
			ActivatedEventElements.Add("ChangeEntityCollectionYesMessageBase");
			ActivatedEventElements.Add("ChangeEntityCollectionNoMessageBase");
			ActivatedEventElements.Add("DeleteOkButtonClickStartMessage");
			ActivatedEventElements.Add("StartMessage1");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3":
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
				case "EventSubProcess4":
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
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "PrepareChangeEntityCollectionQuestionScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareChangeEntityCollectionQuestionScript";
					result = PrepareChangeEntityCollectionQuestionScript.Execute(context, PrepareChangeEntityCollectionQuestionScriptExecute);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "ChangeEntityCollectionUserMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeEntityCollectionUserMessage";
					result = ChangeEntityCollectionUserMessage.Execute(context);
					break;
				case "NewEntityCollectionParameterValueScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "NewEntityCollectionParameterValueScriptTask";
					result = NewEntityCollectionParameterValueScriptTask.Execute(context, NewEntityCollectionParameterValueScriptTaskExecute);
					break;
				case "StartMessage212":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage212";
					result = StartMessage212.Execute(context);
					break;
				case "EventSubProcessChangeEntityCollectionYesMessage":
					context.QueueTasks.Dequeue();
					break;
				case "ChangeEntityCollectionYesMessageBase":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeEntityCollectionYesMessageBase";
					result = ChangeEntityCollectionYesMessageBase.Execute(context);
					break;
				case "ChangeEntityCollectionYesMessageScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeEntityCollectionYesMessageScript";
					result = ChangeEntityCollectionYesMessageScript.Execute(context, ChangeEntityCollectionYesMessageScriptExecute);
					break;
				case "EventSubProcessChangeEntityCollectionNoMessage":
					context.QueueTasks.Dequeue();
					break;
				case "ChangeEntityCollectionNoMessageBase":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeEntityCollectionNoMessageBase";
					result = ChangeEntityCollectionNoMessageBase.Execute(context);
					break;
				case "ChangeEntityCollectionNoMessageScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeEntityCollectionNoMessageScript";
					result = ChangeEntityCollectionNoMessageScript.Execute(context, ChangeEntityCollectionNoMessageScriptExecute);
					break;
				case "EventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "DeleteOkButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteOkButtonClickStartMessage";
					result = DeleteOkButtonClickStartMessage.Execute(context);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OkButtonClick");
					result = IntermediateThrowMessageEvent2.Execute(context);
					break;
				case "DeleteOkButtonClickScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteOkButtonClickScript";
					result = DeleteOkButtonClickScript.Execute(context, DeleteOkButtonClickScriptExecute);
					break;
				case "EventSubProcess7":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "DeleteEntityCollectionScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteEntityCollectionScriptTask1";
					result = DeleteEntityCollectionScriptTask1.Execute(context, DeleteEntityCollectionScriptTask1Execute);
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
				case "NewEntityCollectionParameterValue":
					NewEntityCollectionParameterValue = reader.GetValue<System.String>();
				break;
				case "EntityCollectionDisplayValue":
					EntityCollectionDisplayValue = reader.GetValue<System.String>();
				break;
				case "IsNew":
					IsNew = reader.GetValue<System.Boolean>();
				break;
				case "EntityCollectionSchemaUId":
					EntityCollectionSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "EntityCollectionMetaPath":
					EntityCollectionMetaPath = reader.GetValue<System.String>();
				break;
				case "IsFilterParamsValuesCorrect":
					IsFilterParamsValuesCorrect = reader.GetValue<System.Boolean>();
				break;
				case "CollectionItemsDataSourceId":
					CollectionItemsDataSourceId = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ChildInitScriptExecute(ProcessExecutingContext context) {
			if (!Ext.IsAjaxRequest) {
				ParameterDataValueTypeUId = UserConnection.DataValueTypeManager.GetItemByName("EntityCollectionDataValueType").UId;
				Page.TitleEdit.Text = ElementNewCaption;
				var values = DefaultValues as Dictionary<string, ProcessSchemaParameterValue>;
				DesignModeClassDescriptor descriptor = Descriptor as DesignModeClassDescriptor;
				FillPropertyDataSource(Source, descriptor);
				var propertyDataSource = PropertyDataSource as VirtualDataSource;
				propertyDataSource.SetClientActiveRow();
				BindEditors(GetEditorsBinding(), propertyDataSource, values);
			}
			return true;
		}

		public virtual bool ChildPageLoadCompleteScriptExecute(ProcessExecutingContext context) {
			EntityCollectionMetaPath = string.Empty;
			EntityCollectionDisplayValue = string.Empty;
			var schema = FindDesignedProcessSchema();
			Page.FilterEdit.SetProcessSchema(schema);
			Page.FilterEdit.AggregationEnable = false;
			var df = DefaultValues as Dictionary<string, ProcessSchemaParameterValue>;
			if (df == null) {
				return true;
			}
			var entityCollection = df["EntityCollection"];
			if (entityCollection == null) {
				return true;
			}
			((Terrasoft.UI.WebControls.Page)Page.AspPage).CustomData["EntityCollectionCustomDataKey"] = Json.Serialize(entityCollection);
			if (entityCollection.ReferenceSchemaUId != Guid.Empty) {
				EntityCollectionSchemaUId = entityCollection.ReferenceSchemaUId;
				EntityCollectionMetaPath = entityCollection.Value;
				EntityCollectionDisplayValue = GetPropertyDisplayPathByServerMetaPath(GetPropertyServerMetaPathByClientMetaPath(entityCollection.Value));
				Page.EntityDataSource.SchemaUId = EntityCollectionSchemaUId;
				EntityCollectionDisplayValue = GetEntityCollectionDisplayValue(EntityCollectionDisplayValue, EntityCollectionMetaPath);
				Page.EntityCollectionTextEdit.Text = EntityCollectionDisplayValue;
				string filters = df["DataSourceFilters"].Value;
				if (!String.IsNullOrEmpty(filters)) {
					var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, Page.FilterEdit.DataSource);
					var filterCollection = Json.Deserialize(filters, typeof(DataSourceFilterCollection), 
						new List<JsonConverter> { jsonConverter }) as DataSourceFilterCollection;	
					if (filterCollection != null) {
						Page.EntityDataSource.CurrentStructure.Filters.Add(filterCollection);
					}
				}
				InitializeFilterEdit();
				Page.EntityDataSource.LoadStructure();
			} else {
				IsNew = true;
			}
			Page.FilterEdit.Enabled = EntityCollectionSchemaUId != Guid.Empty;
			return true;
		}

		public virtual bool PrepareChangeEntityCollectionQuestionScriptExecute(ProcessExecutingContext context) {
			ChangeEntityCollectionUserMessage.Page = Page;
			ChangeEntityCollectionUserMessage.MessageText = ChangeSchemaEntityMessage;
			ChangeEntityCollectionUserMessage.Icon = "QUESTION";
			ChangeEntityCollectionUserMessage.Buttons = "YESNO";
			ChangeEntityCollectionUserMessage.ResponseMessages = new Dictionary<string, string> {
				{"yes", "ChangeEntityCollectionYesMessage"},
				{"no", "ChangeEntityCollectionNoMessage"},
			};
			return true;
		}

		public virtual bool NewEntityCollectionParameterValueScriptTaskExecute(ProcessExecutingContext context) {
			NewEntityCollectionParameterValue = Json.Serialize(context.ThrowEventArgs);
			return true;
		}

		public virtual bool ChangeEntityCollectionYesMessageScriptExecute(ProcessExecutingContext context) {
			var entityCollectionSelectedParameterValues = Json.Deserialize<Dictionary<string, object>>(NewEntityCollectionParameterValue);
			EntityCollectionSchemaUId = new Guid(entityCollectionSelectedParameterValues["referenceSchemaUId"].ToString());
			EntityCollectionMetaPath = entityCollectionSelectedParameterValues["metaPath"].ToString();
			EntityCollectionDisplayValue = entityCollectionSelectedParameterValues["caption"].ToString();
			EntityCollectionDisplayValue = GetEntityCollectionDisplayValue(EntityCollectionDisplayValue, EntityCollectionMetaPath);
			Page.EntityCollectionTextEdit.Text = EntityCollectionDisplayValue;
			if (!IsNew) {
				ClearDataSourceFilters();	
			}
			IsNew = false;
			Page.EntityDataSource.SchemaUId = EntityCollectionSchemaUId;
			InitializeFilterEdit();
			Page.EntityDataSource.LoadStructure();
			Page.FilterEdit.Enabled = EntityCollectionSchemaUId != Guid.Empty;
			return true;
		}

		public virtual bool ChangeEntityCollectionNoMessageScriptExecute(ProcessExecutingContext context) {
			Page.EntityCollectionTextEdit.Text = EntityCollectionDisplayValue;
			return true;
		}

		public virtual bool DeleteOkButtonClickScriptExecute(ProcessExecutingContext context) {
			ElementNewCaption = Page.TitleEdit.Text;
			var noneVS = ProcessSchemaParameterValueSource.None;
			var constVS = ProcessSchemaParameterValueSource.ConstValue;
			var mappingVS = ProcessSchemaParameterValueSource.Mapping;
			var parametersValue = ParametersValue as Dictionary<string, ProcessSchemaParameterValue>;
			if (parametersValue == null) {
				ParametersValue = (parametersValue = new Dictionary<string, ProcessSchemaParameterValue>());
			}
			var entityCollection =
				Json.Deserialize<ProcessSchemaParameterValue>(((Terrasoft.UI.WebControls.Page)Page.AspPage).CustomData["EntityCollectionCustomDataKey"].ToString());
			entityCollection.MetaPath = EntityCollectionMetaPath;
			entityCollection.Value = EntityCollectionMetaPath;
			//entityCollection.DisplayValue = EntityCollectionDisplayValue;
			entityCollection.ModifiedInSchemaUId = EditSchemaUId;
			entityCollection.Source = string.IsNullOrEmpty(EntityCollectionMetaPath)? noneVS : mappingVS;
			entityCollection.ReferenceSchemaUId = EntityCollectionSchemaUId;
			parametersValue["EntityCollection"] = entityCollection;
			var filterCollection = Page.FilterEdit.DataSource.FindFiltersGroupByName("FilterEdit");
			var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, Page.FilterEdit.DataSource);
			var serializedFilterCollection = Json.Serialize(filterCollection, jsonConverter);
			bool isNoneVS = filterCollection == null || filterCollection.Count == 0;
			parametersValue["DataSourceFilters"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = isNoneVS ? noneVS : constVS,
				Value = isNoneVS ? string.Empty : serializedFilterCollection
			};
			return true;
		}

		public virtual bool DeleteEntityCollectionScriptTask1Execute(ProcessExecutingContext context) {
			InitializeSchemaExplorerWindow();
			var schemaExplorer = SchemaExplorer as SchemaStructureExplorer;
			var processSchema = FindDesignedProcessSchema();
			string handler = string.Empty;
			string handlerReferenceName = string.Format("window.{0}_EditCompleteParameter", schemaExplorer.ClientID);
			var propertyDataSource = PropertyDataSource as VirtualDataSource;
			var sb = new StringBuilder();
			sb.Append("function(columnInfo) {\n");
			sb.Append("var info = Ext.util.JSON.decode(columnInfo);");
			sb.AppendFormat("{0}.setValue(info.caption);", Page.EntityCollectionTextEdit.ClientID);
			sb.AppendFormat("window.Terrasoft.AjaxMethods.ThrowClientEventWithParameters('{0}', '{1}', columnInfo);", InstanceUId, "EntityCollectionEditChange");
			sb.Append("}");
			handler = sb.ToString();
			handler = string.Format(@"{0} = {1}", handlerReferenceName, handler);
			Page.ScriptManager.AddScript(string.Format("if ({2}) {{ {0}.un(\"{1}\",{2}); }}", schemaExplorer.ClientID, "editcomplete", handlerReferenceName));
			Page.ScriptManager.AddScript(handler);
			Page.ScriptManager.AddScript(string.Format("{0}.on(\"{1}\",{2});", schemaExplorer.ClientID, "editcomplete", handlerReferenceName));
			schemaExplorer.ManagerName = processSchema.Manager.Name;
			schemaExplorer.ShowEditWindow(processSchema.UId, EntityCollectionMetaPath);
			return true;
		}

		public override void InitializeSchemaExplorerWindow() {
			bool isNewSchemaExplorer = SchemaExplorer == null;
			if (isNewSchemaExplorer) {
				SchemaExplorer = new SchemaStructureExplorer(Page.TopControlLayout, "schemaStructure", false, false);
			}
			var schemaExplorer = SchemaExplorer as SchemaStructureExplorer;
			if (isNewSchemaExplorer) {
				schemaExplorer.ManagerName = EditSchemaManagerName;
			} else {
				schemaExplorer.IncludedDataValueTypes.Clear();
			}
			schemaExplorer.IgnoredSchemaElementUId = EditElementUId;
			schemaExplorer.IncludedDataValueTypes.Add(ParameterDataValueTypeUId, Guid.NewGuid());
			Guid guidDataValueTypeUId = UserConnection.DataValueTypeManager.GetItemByName("Guid").UId;
			if (IsParameterLookup) {
				schemaExplorer.IncludedDataValueTypes.Add(guidDataValueTypeUId, Guid.Empty);
			}
			if (ParameterDataValueTypeUId == guidDataValueTypeUId) {
				schemaExplorer.IncludedDataValueTypes.Add(UserConnection.DataValueTypeManager.GetItemByName("Lookup").UId, Guid.Empty);
			}
			SchemaExplorerCreated = true;
			if (!SchemaExplorerRegistered) {
				schemaExplorer.Register();
				SchemaExplorerRegistered = true;
			}
		}

		public override void MakeCaption() {
			((Terrasoft.UI.WebControls.Page)Page.AspPage).Caption = string.IsNullOrEmpty(Page.TitleEdit.Text) ?
				string.Format("{0} ({1})", WindowCaption, NewRecord) : Page.TitleEdit.Text;
		}

		public virtual void ClearDataSourceFilters() {
			EntityDataSource dataSource = Page.EntityDataSource;
			var oldFilters = dataSource.CurrentStructure.Filters.FindByName("FilterEdit") as DataSourceFilterCollection;
			if (oldFilters != null) {
				oldFilters.Clear();
			}
			Page.FilterEdit.IsColumnsExplorerRootMode = true;
			//Page.FilterEdit.Reinitialize(dataSource);
		}

		public virtual void InitializeFilterEdit() {
			EntityDataSource dataSource = Page.EntityDataSource;
			var filterEditGroup = dataSource.FindFiltersGroupByName("FilterEdit");
			if (filterEditGroup == null) {
				filterEditGroup = dataSource.CreateFiltersGroup("FilterEdit");
				dataSource.CurrentStructure.Filters.Add(filterEditGroup);
			}
			Page.FilterEdit.IsColumnsExplorerRootMode = true;
			//Page.FilterEdit.Reinitialize(dataSource);
		}

		public virtual string GetPropertyDisplayPathByServerMetaPath(string serverMetaPath) {
			ProcessSchema processSchema = FindDesignedProcessSchema();
			var generator = new ProcessSchemaGenerator(UserConnection, processSchema.ProcessSchemaManager.Namespace);
			return generator.GetPropertyPathByMetaPath(new ProcessSchemaParameter(processSchema), serverMetaPath, true);
		}

		public virtual string GetPropertyServerMetaPathByClientMetaPath(string clientMetaPath) {
			ProcessSchema processSchema = FindDesignedProcessSchema();
			var generator = new ProcessSchemaGenerator(UserConnection, processSchema.ProcessSchemaManager.Namespace);
			return generator.GetMetaPath(processSchema, clientMetaPath);
		}

		public virtual string GetEntityCollectionDisplayValue(string displayValue, string metaPath) {
			if (string.IsNullOrEmpty(displayValue)) {
				ProcessSchema processSchema = FindDesignedProcessSchema();
				displayValue = processSchema.GetBaseElementByUId(new Guid(metaPath)).Name;
			}
			return displayValue;
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
					case "EntityCollectionEditChange":
							if (ActivatedEventElements.Contains("StartMessage212")) {
							context.QueueTasks.Enqueue("StartMessage212");
						}
						break;
					case "ChangeEntityCollectionYesMessage":
							if (ActivatedEventElements.Contains("ChangeEntityCollectionYesMessageBase")) {
							context.QueueTasks.Enqueue("ChangeEntityCollectionYesMessageBase");
						}
						break;
					case "ChangeEntityCollectionNoMessage":
							if (ActivatedEventElements.Contains("ChangeEntityCollectionNoMessageBase")) {
							context.QueueTasks.Enqueue("ChangeEntityCollectionNoMessageBase");
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("DeleteOkButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("DeleteOkButtonClickStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "EntityCollectionEditToolButtonClick":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("NewEntityCollectionParameterValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NewEntityCollectionParameterValue", NewEntityCollectionParameterValue, null);
			}
			if (!HasMapping("EntityCollectionDisplayValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntityCollectionDisplayValue", EntityCollectionDisplayValue, null);
			}
			if (!HasMapping("IsNew") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNew", IsNew, false);
			}
			if (!HasMapping("EntityCollectionSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntityCollectionSchemaUId", EntityCollectionSchemaUId, Guid.Empty);
			}
			if (!HasMapping("EntityCollectionMetaPath") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntityCollectionMetaPath", EntityCollectionMetaPath, null);
			}
			if (!HasMapping("IsFilterParamsValuesCorrect") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsFilterParamsValuesCorrect", IsFilterParamsValuesCorrect, false);
			}
			if (!HasMapping("CollectionItemsDataSourceId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CollectionItemsDataSourceId", CollectionItemsDataSourceId, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: DeleteEntityCollectionItemsUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class DeleteEntityCollectionItemsUserTaskParametersEditPageEventsProcess : DeleteEntityCollectionItemsUserTaskParametersEditPageEventsProcess<Terrasoft.WebApp.DeleteEntityCollectionItemsUserTaskParametersEditPageSchemaUserControl>
	{

		public DeleteEntityCollectionItemsUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DeleteEntityCollectionItemsUserTaskParametersEditPageSchemaUserControl

	/// <exclude/>
	public partial class DeleteEntityCollectionItemsUserTaskParametersEditPageSchemaUserControl : Terrasoft.WebApp.BaseProcessParametersEditPageSchemaUserControl
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

		public Terrasoft.UI.WebControls.Controls.TextEdit EntityCollectionTextEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("EntityCollectionTextEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton EntityCollectionEditToolButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("EntityCollectionEditToolButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit EntityCollectionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("EntityCollectionEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label MatchConditionsLabel {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("MatchConditionsLabel", true);
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

		public Terrasoft.UI.WebControls.Controls.EntityDataSource EntityDataSource {
			get {
				return (Terrasoft.UI.WebControls.Controls.EntityDataSource)PageContainer.FindPageControl("EntityDataSource", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			EntityCollectionEditToolButton.AjaxEvents.Click.Event += EntityCollectionEditToolButtonClick;
			EntityCollectionEdit.AjaxEvents.Change.Event += EntityCollectionEditChange;
			IsMatchConditionsEdit.AjaxEvents.Check.Event += IsMatchConditionsEditCheck;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			EntityCollectionEditToolButton.AjaxEvents.Click.Event -= EntityCollectionEditToolButtonClick;
			EntityCollectionEdit.AjaxEvents.Change.Event -= EntityCollectionEditChange;
			IsMatchConditionsEdit.AjaxEvents.Check.Event -= IsMatchConditionsEditCheck;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (DeleteEntityCollectionItemsUserTaskParametersEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new DeleteEntityCollectionItemsUserTaskParametersEditPageEventsProcess(UserConnection);
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

		public virtual void EntityCollectionEditToolButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("EntityCollectionEditToolButtonClick");
		}

		public virtual void EntityCollectionEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("EntityCollectionEditChange");
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
			SchemaName = "DeleteEntityCollectionItemsUserTaskParametersEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: DeleteEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema

	/// <exclude/>
	public class DeleteEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public DeleteEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public DeleteEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema(DeleteEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "DeleteEntityCollectionItemsUserTaskParametersEditPageEventsProcess";
			UId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7");
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

		protected virtual ProcessSchemaParameter CreateCollectionItemsDataSourceIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4059cd09-9d77-4e2c-92c4-99a4707d11d6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"CollectionItemsDataSourceId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateIsFilterParamsValuesCorrectParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3d44e705-1fd3-428c-81c1-80977b0f4f37"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"IsFilterParamsValuesCorrect",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityCollectionMetaPathParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("612ed384-3cf5-4f1e-bed7-fa323bc98b99"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"EntityCollectionMetaPath",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityCollectionSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("145fb5f0-d09e-4fb7-b5b2-74d2526a76f5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"EntityCollectionSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsNewParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3a13e028-6ead-4aa7-be7f-afa2ed69bbb5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"IsNew",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityCollectionDisplayValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("bb6ab29b-9a0a-4762-9524-fd10fb5d964b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"EntityCollectionDisplayValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNewEntityCollectionParameterValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fff6ef6c-a6b8-4220-aa6c-fdcd1deba3d8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"NewEntityCollectionParameterValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCollectionItemsDataSourceIdParameter());
			Parameters.Add(CreateIsFilterParamsValuesCorrectParameter());
			Parameters.Add(CreateEntityCollectionMetaPathParameter());
			Parameters.Add(CreateEntityCollectionSchemaUIdParameter());
			Parameters.Add(CreateIsNewParameter());
			Parameters.Add(CreateEntityCollectionDisplayValueParameter());
			Parameters.Add(CreateNewEntityCollectionParameterValueParameter());
		}

		protected virtual void InitializeChangeEntityCollectionUserMessageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("78c37b15-d8ad-44a7-8afa-bba1542af6f6"),
				ContainerUId = new Guid("259a02a2-25e0-4164-8c21-e421bcd782fd"),
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
				UId = new Guid("8e3c2d81-1e11-4e79-9ff2-406d1b283171"),
				ContainerUId = new Guid("259a02a2-25e0-4164-8c21-e421bcd782fd"),
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
				UId = new Guid("f55ca083-a122-4210-9157-074799837aac"),
				ContainerUId = new Guid("259a02a2-25e0-4164-8c21-e421bcd782fd"),
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
				UId = new Guid("bf97276d-cd5e-430e-9521-228926b39a14"),
				ContainerUId = new Guid("259a02a2-25e0-4164-8c21-e421bcd782fd"),
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
				UId = new Guid("6c9c86d6-18ee-4bfd-9e5c-8dad76f103dd"),
				ContainerUId = new Guid("259a02a2-25e0-4164-8c21-e421bcd782fd"),
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
				UId = new Guid("97233ff1-4afb-4311-8b56-2f0e6fb86dd4"),
				ContainerUId = new Guid("259a02a2-25e0-4164-8c21-e421bcd782fd"),
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
				UId = new Guid("ecf05dac-6aa2-4e18-bd71-01c63acab6cc"),
				ContainerUId = new Guid("259a02a2-25e0-4164-8c21-e421bcd782fd"),
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
				UId = new Guid("e03a6046-4be9-4e9f-9507-0d2f6a7513fb"),
				ContainerUId = new Guid("259a02a2-25e0-4164-8c21-e421bcd782fd"),
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
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaLane3 = CreateLane3Lane();
			schemaLaneSet1.Lanes.Add(schemaLane3);
			ProcessSchemaLane schemaLane4 = CreateLane4Lane();
			schemaLaneSet1.Lanes.Add(schemaLane4);
			ProcessSchemaLane schemaLane5 = CreateLane5Lane();
			schemaLaneSet1.Lanes.Add(schemaLane5);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaEventSubProcess eventsubprocesschangeentitycollectionyesmessage = CreateEventSubProcessChangeEntityCollectionYesMessageEventSubProcess();
			FlowElements.Add(eventsubprocesschangeentitycollectionyesmessage);
			ProcessSchemaEventSubProcess eventsubprocesschangeentitycollectionnomessage = CreateEventSubProcessChangeEntityCollectionNoMessageEventSubProcess();
			FlowElements.Add(eventsubprocesschangeentitycollectionnomessage);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaEventSubProcess eventsubprocess7 = CreateEventSubProcess7EventSubProcess();
			FlowElements.Add(eventsubprocess7);
			ProcessSchemaStartMessageEvent initstartmessage = CreateInitStartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(initstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent initintermediatethrowmessageevent = CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess3.FlowElements.Add(initintermediatethrowmessageevent);
			ProcessSchemaScriptTask childinitscript = CreateChildInitScriptScriptTask();
			eventsubprocess3.FlowElements.Add(childinitscript);
			ProcessSchemaStartMessageEvent pageloqdcompletestartmessage = CreatePageLoqdCompleteStartMessageStartMessageEvent();
			eventsubprocess4.FlowElements.Add(pageloqdcompletestartmessage);
			ProcessSchemaIntermediateThrowMessageEvent pageloqdcompleteintermediatethrowmessageevent = CreatePageLoqdCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess4.FlowElements.Add(pageloqdcompleteintermediatethrowmessageevent);
			ProcessSchemaScriptTask childpageloadcompletescript = CreateChildPageLoadCompleteScriptScriptTask();
			eventsubprocess4.FlowElements.Add(childpageloadcompletescript);
			ProcessSchemaScriptTask preparechangeentitycollectionquestionscript = CreatePrepareChangeEntityCollectionQuestionScriptScriptTask();
			eventsubprocess5.FlowElements.Add(preparechangeentitycollectionquestionscript);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			eventsubprocess5.FlowElements.Add(exclusivegateway1);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess5.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaUserTask changeentitycollectionusermessage = CreateChangeEntityCollectionUserMessageUserTask();
			eventsubprocess5.FlowElements.Add(changeentitycollectionusermessage);
			ProcessSchemaScriptTask newentitycollectionparametervaluescripttask = CreateNewEntityCollectionParameterValueScriptTaskScriptTask();
			eventsubprocess5.FlowElements.Add(newentitycollectionparametervaluescripttask);
			ProcessSchemaStartMessageEvent startmessage212 = CreateStartMessage212StartMessageEvent();
			eventsubprocess5.FlowElements.Add(startmessage212);
			ProcessSchemaStartMessageEvent changeentitycollectionyesmessagebase = CreateChangeEntityCollectionYesMessageBaseStartMessageEvent();
			eventsubprocesschangeentitycollectionyesmessage.FlowElements.Add(changeentitycollectionyesmessagebase);
			ProcessSchemaScriptTask changeentitycollectionyesmessagescript = CreateChangeEntityCollectionYesMessageScriptScriptTask();
			eventsubprocesschangeentitycollectionyesmessage.FlowElements.Add(changeentitycollectionyesmessagescript);
			ProcessSchemaStartMessageEvent changeentitycollectionnomessagebase = CreateChangeEntityCollectionNoMessageBaseStartMessageEvent();
			eventsubprocesschangeentitycollectionnomessage.FlowElements.Add(changeentitycollectionnomessagebase);
			ProcessSchemaScriptTask changeentitycollectionnomessagescript = CreateChangeEntityCollectionNoMessageScriptScriptTask();
			eventsubprocesschangeentitycollectionnomessage.FlowElements.Add(changeentitycollectionnomessagescript);
			ProcessSchemaStartMessageEvent deleteokbuttonclickstartmessage = CreateDeleteOkButtonClickStartMessageStartMessageEvent();
			eventsubprocess6.FlowElements.Add(deleteokbuttonclickstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess6.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaScriptTask deleteokbuttonclickscript = CreateDeleteOkButtonClickScriptScriptTask();
			eventsubprocess6.FlowElements.Add(deleteokbuttonclickscript);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess7.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask deleteentitycollectionscripttask1 = CreateDeleteEntityCollectionScriptTask1ScriptTask();
			eventsubprocess7.FlowElements.Add(deleteentitycollectionscripttask1);
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValidationMessageTitleLocalizableString());
			LocalizableStrings.Add(CreateValidationMessageLocalizableString());
			LocalizableStrings.Add(CreateChangeSchemaEntityMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValidationMessageTitleLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9269119d-b14b-4a3c-8682-ed416960fbed"),
				Name = "ValidationMessageTitle",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("38f0596c-369e-481a-822c-c2d87e2c2c17"),
				Name = "ValidationMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateChangeSchemaEntityMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f097962b-e4a7-467f-aef3-a3fe986fd6b3"),
				Name = "ChangeSchemaEntityMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow6",
				UId = new Guid("067646a1-d8f3-4a8c-a2f2-96832e796529"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				CurveCenterPosition = new Point(300, 208),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3c983fdf-a228-41b2-a92c-40138e0baeff"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7ed037e4-515c-49ed-85ee-e463f2c7b466"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("81c8ec4e-9f69-42db-9116-08b8b751c849"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				CurveCenterPosition = new Point(469, 70),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3d2eed15-85d6-4d60-96c4-b135257bcf9e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("259a02a2-25e0-4164-8c21-e421bcd782fd"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("9338d828-655a-4522-a78c-fc19371b8155"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				CurveCenterPosition = new Point(782, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7c2602fe-e2ff-422b-b386-4cf44adac209"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2d824c8f-5018-451a-8869-5ba0b11df0f5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("a73f8d39-199e-485d-9d96-5e5cd84a9128"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				CurveCenterPosition = new Point(782, 259),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a8f1064a-ee42-4e4f-b135-9e5e7fe5825a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3ce0e05e-8390-4205-a7b0-00f3c8cc910a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("d8965a90-7a51-4be7-b3a0-6b2333422074"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				CurveCenterPosition = new Point(706, 48),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("91bc3a6f-1404-42a7-bea1-4478b81d9968"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7de82a5f-b020-4e5c-bb6f-0598c60ccb0d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("3daee780-174a-4f13-8cd7-a451e3066cf5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				CurveCenterPosition = new Point(170, 973),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a8177037-7d5b-4a86-93e8-f1639c8c4695"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("513108bb-1bcb-497b-b5f6-316421c007d8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("9d5420ea-f294-46a5-8c3c-07d0f2b74b7e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				CurveCenterPosition = new Point(269, 973),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("513108bb-1bcb-497b-b5f6-316421c007d8"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("20e15f77-c511-4b6d-aea7-4bf8ea407353"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("7222926d-123c-4bdd-be5a-a10e5fe2de09"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				CurveCenterPosition = new Point(170, 1176),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b56d78a6-d5cc-4054-897d-a1f615496567"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1b9a45ff-301e-4c71-adef-347f34a3a338"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("56813527-1fa8-458c-be51-7d798f5992e3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				CurveCenterPosition = new Point(264, 1176),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1b9a45ff-301e-4c71-adef-347f34a3a338"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d0865375-3022-43c6-ac64-4b47590d228f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("bd63dc0c-4d32-4d9d-8382-4659c3ea6b61"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("37bca9ee-985b-4731-874f-0dc4c12b5e4d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4babf40b-80c0-44f6-900b-5cdbffa217b5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("18bf25f8-e30e-4189-9e1b-91f3bbd6c90a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				CurveCenterPosition = new Point(220, 286),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("613bddba-645b-4f97-93b0-422c6a4e8fae"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("91bc3a6f-1404-42a7-bea1-4478b81d9968"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("53630093-b9a8-45f2-990e-a0dba3e707af"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				CurveCenterPosition = new Point(106, 600),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7a98b771-209f-43f5-9973-b4f857257260"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a334792f-8081-4186-b9da-bed989bef183"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("5a3fe43e-e6ce-43a9-807d-d49bea961df7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				CurveCenterPosition = new Point(189, 533),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a334792f-8081-4186-b9da-bed989bef183"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3c983fdf-a228-41b2-a92c-40138e0baeff"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("5cf9b002-ac3e-4d5d-8e0c-735eb97d909a"),
				ConditionExpression = @"!IsNew",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				CurveCenterPosition = new Point(274, 474),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3c983fdf-a228-41b2-a92c-40138e0baeff"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3d2eed15-85d6-4d60-96c4-b135257bcf9e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("d8627450-d6be-40de-91a7-285be36324fa"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(926, 1117),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("21ff73ff-de43-4419-b4f0-87c55b8c5981"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("d8627450-d6be-40de-91a7-285be36324fa"),
				CreatedInOwnerSchemaUId = new Guid("f94380f0-f678-48bc-baee-db6a795fdafe"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 723),
				Size = new Size(897, 394),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("20e70da0-68f8-48da-800c-5a844bd4a657"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("d8627450-d6be-40de-91a7-285be36324fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"Lane3",
				Position = new Point(29, 369),
				Size = new Size(897, 349),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaLane CreateLane4Lane() {
			ProcessSchemaLane schemaLane4 = new ProcessSchemaLane(this) {
				UId = new Guid("cda2fb67-3b7e-4848-a87b-e33953b67f3c"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("d8627450-d6be-40de-91a7-285be36324fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"Lane4",
				Position = new Point(29, 164),
				Size = new Size(897, 200),
				UseBackgroundMode = false
			};
			return schemaLane4;
		}

		protected virtual ProcessSchemaLane CreateLane5Lane() {
			ProcessSchemaLane schemaLane5 = new ProcessSchemaLane(this) {
				UId = new Guid("de081ac9-fb84-48ad-9a56-cdbaa43dd3d0"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("d8627450-d6be-40de-91a7-285be36324fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"Lane5",
				Position = new Point(29, 0),
				Size = new Size(897, 159),
				UseBackgroundMode = false
			};
			return schemaLane5;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("29f8fde4-c059-4a0e-a04a-245cd8da6c20"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("21ff73ff-de43-4419-b4f0-87c55b8c5981"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(357, 167),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a8177037-7d5b-4a86-93e8-f1639c8c4695"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("29f8fde4-c059-4a0e-a04a-245cd8da6c20"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"InitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("513108bb-1bcb-497b-b5f6-316421c007d8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("29f8fde4-c059-4a0e-a04a-245cd8da6c20"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"InitIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(133, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChildInitScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("20e15f77-c511-4b6d-aea7-4bf8ea407353"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("29f8fde4-c059-4a0e-a04a-245cd8da6c20"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"ChildInitScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(224, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,145,203,110,194,48,16,69,215,69,226,31,92,86,137,20,229,7,104,43,65,146,86,44,64,136,215,126,148,12,169,43,199,78,199,19,32,170,250,239,181,3,229,33,218,149,61,163,185,247,120,174,229,86,4,143,217,129,227,137,29,125,192,97,129,159,13,90,14,197,87,191,247,48,7,130,10,25,41,5,134,13,168,6,87,109,141,235,73,33,158,197,218,34,37,70,107,204,89,26,29,223,76,76,65,67,137,20,191,33,79,24,171,113,59,115,54,193,32,211,44,185,77,140,82,71,209,141,102,16,198,206,120,216,81,75,140,87,146,21,102,133,228,120,133,7,118,188,76,97,133,154,103,184,79,160,246,106,63,186,3,18,59,239,96,221,68,138,91,104,20,111,142,53,88,145,202,14,3,212,62,89,38,169,203,72,204,201,228,104,237,50,127,199,10,206,235,117,146,23,111,152,162,149,165,158,154,2,19,5,214,186,50,39,89,179,33,81,92,174,30,117,46,60,231,63,145,119,124,149,74,57,106,141,196,173,95,120,105,26,202,49,56,30,209,149,109,248,187,80,125,55,237,136,247,22,158,188,145,196,13,168,75,211,123,220,235,227,37,114,162,164,139,111,228,18,217,225,194,236,131,14,55,150,186,240,33,27,178,129,251,172,211,213,119,93,90,65,24,253,241,150,232,20,184,215,127,247,123,132,220,144,22,76,13,14,127,0,75,130,169,21,75,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9becf0ae-0e97-40b5-958f-8400e334de91"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("21ff73ff-de43-4419-b4f0-87c55b8c5981"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"EventSubProcess4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 203),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(364, 170),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoqdCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b56d78a6-d5cc-4054-897d-a1f615496567"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9becf0ae-0e97-40b5-958f-8400e334de91"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"PageLoqdCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 82),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoqdCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("1b9a45ff-301e-4c71-adef-347f34a3a338"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9becf0ae-0e97-40b5-958f-8400e334de91"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"PageLoqdCompleteIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 82),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChildPageLoadCompleteScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d0865375-3022-43c6-ac64-4b47590d228f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9becf0ae-0e97-40b5-958f-8400e334de91"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"ChildPageLoadCompleteScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(232, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,93,111,218,48,20,125,78,165,254,7,195,83,34,161,252,1,74,37,10,180,162,235,54,52,202,246,48,241,224,38,55,169,43,227,32,219,233,150,85,252,247,93,219,129,124,130,250,128,68,114,111,206,61,62,190,231,44,132,102,186,152,101,156,67,164,89,38,190,130,166,43,170,95,201,132,40,45,153,72,195,197,110,175,139,241,245,213,162,213,57,103,106,207,105,241,147,242,28,186,221,239,84,18,21,189,194,142,98,237,158,137,120,14,138,165,2,226,149,204,34,80,106,109,107,126,128,173,43,154,66,120,207,184,6,185,136,153,14,215,160,155,77,14,167,175,117,154,166,18,82,106,232,44,4,125,225,134,72,66,185,130,146,65,156,224,139,57,36,52,231,218,18,85,132,42,50,103,246,0,84,22,55,142,245,136,52,6,174,168,164,59,192,25,246,147,91,196,98,9,241,13,214,132,136,156,243,128,124,92,95,121,18,116,46,5,209,50,55,211,14,110,32,180,68,194,241,113,242,123,216,214,110,184,45,65,187,253,23,71,248,254,51,72,73,85,150,232,112,179,12,127,193,203,44,19,90,102,92,133,70,154,192,234,51,85,123,251,16,206,114,165,179,221,156,106,218,101,80,213,190,64,49,220,34,207,71,149,9,212,94,50,202,217,63,232,48,11,206,48,14,127,64,2,18,68,4,78,188,205,50,38,131,9,121,200,89,236,150,193,29,165,61,191,106,158,116,68,235,129,28,247,64,212,86,181,131,96,111,174,239,163,214,214,62,216,93,219,131,212,69,89,49,136,119,5,234,240,14,242,56,193,175,181,53,43,119,197,140,51,156,126,234,236,103,18,24,245,60,123,59,142,144,17,126,157,229,50,130,176,174,196,89,149,62,119,148,75,29,254,165,226,168,51,249,120,160,54,241,170,227,25,254,106,107,66,243,167,135,123,29,223,128,56,171,145,196,186,87,149,198,168,116,112,174,86,195,109,117,119,102,221,6,107,151,43,75,245,13,109,241,93,218,149,242,75,144,192,237,150,103,156,247,134,235,139,102,192,187,193,10,162,11,248,67,58,232,143,245,38,127,163,64,226,147,112,124,49,4,90,233,82,125,110,85,176,99,220,228,134,193,173,113,48,222,78,214,41,217,141,136,46,246,144,37,126,155,70,205,84,35,98,128,61,67,246,137,41,125,211,32,120,75,62,90,199,58,4,54,191,206,226,141,61,3,103,116,235,240,28,212,131,197,59,179,139,179,92,162,239,52,106,158,71,24,61,71,53,84,56,141,227,14,164,19,5,83,201,254,150,130,105,119,254,74,65,255,194,218,63,101,52,62,205,177,141,7,2,152,220,150,31,222,54,42,50,169,37,95,251,110,92,220,95,244,76,51,134,16,166,30,167,255,1,218,83,148,72,248,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6aa51f3f-1816-4d4c-8c34-e48e225c5f1e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("20e70da0-68f8-48da-800c-5a844bd4a657"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"EventSubProcess5",
				Position = new Point(29, 11),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(471, 324),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareChangeEntityCollectionQuestionScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3d2eed15-85d6-4d60-96c4-b135257bcf9e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6aa51f3f-1816-4d4c-8c34-e48e225c5f1e"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"PrepareChangeEntityCollectionQuestionScript",
				Position = new Point(224, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,177,14,130,48,16,134,103,73,120,135,166,51,241,5,80,7,145,129,65,80,129,129,145,144,11,52,193,171,105,143,40,33,188,187,5,58,56,104,100,185,63,151,126,223,127,13,154,18,107,8,145,4,245,129,108,91,168,72,72,204,53,168,51,104,93,214,176,189,152,193,246,108,10,223,117,130,191,188,205,12,94,100,180,133,79,171,6,238,229,98,217,247,85,93,81,37,209,148,240,107,30,166,89,148,196,124,149,117,236,136,36,234,73,44,194,52,78,214,89,55,208,15,99,129,221,39,29,225,201,78,98,38,75,213,239,52,41,129,181,199,150,60,176,193,117,54,3,239,65,115,143,241,239,7,10,208,182,143,143,222,140,163,252,77,199,242,19,30,205,183,21,80,167,144,145,234,192,127,3,172,124,101,110,171,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("3c983fdf-a228-41b2-a92c-40138e0baeff"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6aa51f3f-1816-4d4c-8c34-e48e225c5f1e"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(154, 119),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("7ed037e4-515c-49ed-85ee-e463f2c7b466"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6aa51f3f-1816-4d4c-8c34-e48e225c5f1e"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"ChangeEntityCollectionYesMessage",
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(245, 203),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaUserTask CreateChangeEntityCollectionUserMessageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("259a02a2-25e0-4164-8c21-e421bcd782fd"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6aa51f3f-1816-4d4c-8c34-e48e225c5f1e"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"ChangeEntityCollectionUserMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(364, 28),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeChangeEntityCollectionUserMessageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateNewEntityCollectionParameterValueScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a334792f-8081-4186-b9da-bed989bef183"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6aa51f3f-1816-4d4c-8c34-e48e225c5f1e"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"NewEntityCollectionParameterValueScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 119),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,75,45,119,205,43,201,44,169,116,206,207,201,73,77,46,201,204,207,11,72,44,74,204,77,45,73,45,10,75,204,41,77,85,176,85,240,42,206,207,211,11,78,45,202,76,204,201,172,74,213,72,206,207,43,73,173,40,209,11,201,40,202,47,119,45,75,205,43,113,44,74,47,214,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,207,202,118,138,89,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage212StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7a98b771-209f-43f5-9973-b4f857257260"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6aa51f3f-1816-4d4c-8c34-e48e225c5f1e"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EntityCollectionEditChange",
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"StartMessage212",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(49, 245),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChangeEntityCollectionYesMessageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChangeEntityCollectionYesMessage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a2ed35de-f070-43d2-a8dc-170d83057e64"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("20e70da0-68f8-48da-800c-5a844bd4a657"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"EventSubProcessChangeEntityCollectionYesMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(610, 4),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(273, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChangeEntityCollectionYesMessage;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeEntityCollectionYesMessageBaseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7c2602fe-e2ff-422b-b386-4cf44adac209"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a2ed35de-f070-43d2-a8dc-170d83057e64"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeEntityCollectionYesMessage",
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"ChangeEntityCollectionYesMessageBase",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeEntityCollectionYesMessageScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2d824c8f-5018-451a-8869-5ba0b11df0f5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a2ed35de-f070-43d2-a8dc-170d83057e64"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"ChangeEntityCollectionYesMessageScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(140, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,79,107,194,64,16,197,207,6,242,29,86,79,9,72,190,128,127,46,198,138,165,45,66,108,47,165,135,49,25,117,203,102,87,118,39,181,105,233,119,239,36,22,173,162,65,111,11,243,222,239,205,14,239,3,172,64,77,146,202,145,81,10,83,146,70,39,88,61,48,155,129,133,28,9,237,11,168,2,157,24,136,123,103,116,20,163,67,43,65,201,47,236,199,178,118,128,45,251,142,172,212,171,174,48,139,119,118,15,135,193,19,110,199,39,228,99,98,216,243,189,83,69,146,174,49,135,231,105,198,105,26,183,98,82,200,44,184,114,193,215,142,197,37,90,212,41,238,49,157,183,104,110,146,122,181,32,60,23,248,136,4,51,160,53,231,93,29,147,255,121,142,224,103,216,177,116,27,5,101,109,187,133,159,194,166,154,223,136,159,32,53,41,130,166,97,87,92,186,75,21,60,131,21,70,167,130,57,126,210,56,147,20,85,15,142,111,194,51,67,46,69,208,158,58,46,69,40,190,125,175,53,82,8,54,6,130,196,20,54,197,59,169,248,0,142,255,217,242,189,31,223,171,149,76,93,130,114,120,188,194,193,20,253,111,203,197,38,177,123,170,37,237,26,187,203,169,246,14,194,139,216,7,3,25,223,189,72,169,176,120,208,29,188,108,129,133,194,198,88,209,30,212,237,141,198,249,134,74,102,88,100,156,22,204,197,222,47,134,77,111,126,119,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChangeEntityCollectionNoMessageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChangeEntityCollectionNoMessage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("284cb2c2-ba13-4263-b72e-756c5544507a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("20e70da0-68f8-48da-800c-5a844bd4a657"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"EventSubProcessChangeEntityCollectionNoMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(610, 165),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(273, 155),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChangeEntityCollectionNoMessage;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeEntityCollectionNoMessageBaseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a8f1064a-ee42-4e4f-b135-9e5e7fe5825a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("284cb2c2-ba13-4263-b72e-756c5544507a"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeEntityCollectionNoMessage",
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"ChangeEntityCollectionNoMessageBase",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeEntityCollectionNoMessageScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3ce0e05e-8390-4205-a7b0-00f3c8cc910a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("284cb2c2-ba13-4263-b72e-756c5544507a"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"ChangeEntityCollectionNoMessageScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(140, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,205,43,201,44,169,116,206,207,201,73,77,46,201,204,207,11,73,173,40,113,77,201,44,209,3,49,20,108,21,208,229,93,50,139,11,114,18,43,195,18,115,74,83,173,121,185,138,82,75,74,139,242,20,74,138,128,60,0,226,252,1,62,80,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("71b2aee4-eba1-484f-8087-4c68ae6e85c9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cda2fb67-3b7e-4848-a87b-e33953b67f3c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"EventSubProcess6",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(815, 179),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteOkButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("613bddba-645b-4f97-93b0-422c6a4e8fae"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("71b2aee4-eba1-484f-8087-4c68ae6e85c9"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"DeleteOkButtonClickStartMessage",
				Position = new Point(43, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("7de82a5f-b020-4e5c-bb6f-0598c60ccb0d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("71b2aee4-eba1-484f-8087-4c68ae6e85c9"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"IntermediateThrowMessageEvent2",
				Position = new Point(246, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleteOkButtonClickScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("91bc3a6f-1404-42a7-bea1-4478b81d9968"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("71b2aee4-eba1-484f-8087-4c68ae6e85c9"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"DeleteOkButtonClickScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,93,79,219,48,20,125,30,18,255,193,234,83,34,85,102,207,27,29,218,218,50,149,137,14,45,45,60,76,60,152,244,22,60,57,118,100,59,176,12,246,223,119,109,39,109,154,164,85,247,104,223,115,238,231,185,119,42,32,3,105,231,240,50,102,185,229,74,146,17,185,97,143,64,23,220,10,152,174,184,165,11,248,109,63,158,158,60,51,77,164,146,112,155,56,136,86,41,24,147,164,79,144,177,27,166,89,6,22,244,45,19,5,36,170,208,41,208,57,66,43,86,170,164,177,71,210,198,30,235,62,42,114,198,242,156,203,199,35,233,215,1,93,113,243,26,98,60,198,151,182,251,195,12,153,240,212,213,205,116,121,110,172,70,242,240,80,156,79,232,154,175,73,212,113,61,34,178,16,34,38,175,167,39,239,218,81,70,61,120,34,225,229,127,99,71,113,140,225,255,134,226,112,106,220,150,99,37,4,164,97,112,24,249,202,40,73,39,96,64,115,38,248,31,56,63,232,46,138,22,160,53,51,106,109,233,114,70,239,224,1,219,111,181,18,134,58,13,196,94,8,159,77,238,31,116,92,24,171,178,9,179,236,231,96,218,10,190,181,125,131,114,112,79,23,42,241,245,132,140,219,169,210,107,176,152,140,125,194,54,180,61,213,166,62,90,221,186,3,156,179,179,14,107,194,77,46,88,185,143,220,52,247,230,170,86,124,205,97,53,147,161,137,203,217,202,121,193,205,216,188,251,104,65,144,136,12,131,165,51,51,71,125,124,215,211,44,183,101,180,175,130,248,162,222,177,15,91,229,247,185,255,1,107,208,32,83,216,73,170,133,106,38,216,18,96,119,132,131,123,244,208,142,83,45,210,154,11,100,54,181,22,142,196,165,255,247,87,194,205,190,90,194,75,46,87,193,98,190,106,85,228,95,202,57,134,142,6,91,244,32,174,28,255,66,189,162,230,158,65,163,165,94,138,141,167,202,201,85,19,20,45,141,203,68,202,144,201,240,64,34,117,144,205,54,84,89,237,212,225,55,38,169,17,81,187,210,225,110,138,206,229,131,82,130,112,51,175,111,97,183,57,225,22,144,183,183,142,13,239,91,33,173,67,188,239,155,73,167,116,63,20,215,148,3,123,28,133,163,115,132,78,135,8,219,232,114,83,65,67,114,213,165,118,184,122,93,26,176,74,201,94,193,8,222,223,86,188,81,88,157,6,91,104,73,172,198,189,250,7,136,220,184,250,103,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e609f7b8-0935-437f-a0be-96e4e54f35ad"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("de081ac9-fb84-48ad-9a56-cdbaa43dd3d0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"EventSubProcess7",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(210, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("37bca9ee-985b-4731-874f-0dc4c12b5e4d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e609f7b8-0935-437f-a0be-96e4e54f35ad"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EntityCollectionEditToolButtonClick",
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"StartMessage1",
				Position = new Point(28, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleteEntityCollectionScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4babf40b-80c0-44f6-900b-5cdbffa217b5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e609f7b8-0935-437f-a0be-96e4e54f35ad"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Name = @"DeleteEntityCollectionScriptTask1",
				Position = new Point(126, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,93,139,218,64,20,125,47,244,63,12,121,49,66,24,218,190,74,161,86,179,96,97,183,210,216,221,23,161,140,153,27,51,101,50,19,38,55,171,86,252,239,189,147,196,213,196,46,133,210,23,197,115,191,206,61,247,56,11,163,80,9,173,126,65,146,230,80,136,120,95,106,235,192,61,41,35,237,46,28,79,222,190,121,22,142,85,189,32,251,200,250,217,76,84,29,146,160,171,83,172,29,156,67,93,131,210,217,20,170,170,77,162,250,59,234,63,135,74,109,13,200,229,117,172,25,89,161,83,102,203,114,97,164,110,198,181,0,143,139,18,15,55,241,111,144,129,3,147,194,131,40,224,146,124,103,93,33,48,12,118,205,42,252,248,238,244,35,150,10,103,182,40,53,32,44,133,163,116,4,23,68,131,245,248,76,43,48,184,152,143,47,228,75,112,120,152,11,20,137,173,93,234,167,44,111,65,82,225,81,57,172,133,190,128,103,1,55,84,98,96,199,146,134,220,231,90,105,9,174,93,118,195,167,101,9,70,134,65,86,155,20,149,53,97,106,117,93,152,133,201,236,152,29,215,38,24,228,249,142,138,130,212,51,222,35,175,81,105,254,37,249,250,192,37,164,86,194,117,249,164,95,123,22,133,212,224,21,224,163,208,53,132,190,21,79,69,233,71,83,65,196,150,98,11,60,54,168,240,48,179,90,67,67,106,5,123,244,2,246,228,185,105,220,169,189,2,231,68,101,51,228,211,159,98,127,15,152,91,89,241,85,238,236,174,45,143,159,233,227,73,97,254,114,135,42,28,17,171,81,196,70,199,247,254,171,183,68,196,22,166,66,65,71,254,190,144,17,11,134,228,154,203,146,31,182,48,212,234,212,0,87,86,218,240,149,109,175,16,14,34,61,223,124,242,26,17,74,100,104,250,159,172,246,130,250,54,141,100,73,234,84,137,247,194,208,15,199,167,82,182,64,56,112,164,202,88,120,252,112,162,211,30,153,63,68,109,194,117,64,115,214,65,228,225,9,59,157,94,55,37,45,15,180,108,218,217,248,21,110,227,191,114,250,71,238,158,175,29,240,253,47,100,7,29,58,34,221,95,186,247,124,156,99,220,7,111,43,147,220,238,188,29,186,39,172,95,218,184,103,104,30,178,167,88,10,204,61,13,7,244,122,25,70,207,24,76,126,3,91,83,105,131,29,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateClearDataSourceFiltersMethod());
			Methods.Add(CreateInitializeFilterEditMethod());
			Methods.Add(CreateGetPropertyDisplayPathByServerMetaPathMethod());
			Methods.Add(CreateGetPropertyServerMetaPathByClientMetaPathMethod());
			Methods.Add(CreateGetEntityCollectionDisplayValueMethod());
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
				Name = "Terrasoft.UI.WebControls",
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
				UId = new Guid("b424ebf7-dbe4-4ba3-91b6-f05370f2faa3"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("80aae919-3f5c-457b-8c6d-feb99bc274b9"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("102b1ce4-4d80-4ae7-9a07-a0ea04ac050b"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fe825805-ef5f-4b56-9e27-9cfe96e3dca5"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected override SchemaMethod CreateInitializeSchemaExplorerWindowMethod() {
			SchemaMethod method = base.CreateInitializeSchemaExplorerWindowMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,93,79,194,48,20,134,175,33,225,63,212,93,109,9,217,31,32,92,40,16,178,4,137,17,240,190,174,135,185,216,181,75,63,196,197,240,223,61,117,69,28,20,137,222,172,203,233,249,120,222,183,231,89,74,78,74,189,132,221,42,127,129,138,206,222,107,46,21,40,50,38,167,129,49,17,150,243,209,160,95,110,73,28,40,73,200,199,160,223,59,107,35,96,231,91,173,140,178,185,177,10,14,183,241,3,45,32,93,203,122,34,133,81,146,47,104,35,173,25,146,72,119,243,163,33,217,82,174,193,31,9,50,236,7,253,55,170,136,190,2,77,245,165,217,215,116,116,59,167,247,84,32,171,90,210,10,112,202,140,149,166,45,250,17,119,84,4,144,47,84,159,137,156,91,6,108,74,13,125,162,220,194,186,169,65,167,19,14,84,197,94,208,105,73,33,240,100,30,142,67,5,194,108,50,230,199,31,3,163,243,202,240,176,91,198,208,113,133,168,6,84,231,14,187,12,201,220,150,44,69,55,220,25,39,142,201,253,145,2,63,167,201,200,176,209,160,240,217,4,228,166,148,34,237,100,120,83,210,57,152,204,64,117,215,56,123,226,200,181,139,146,180,69,118,230,103,250,27,103,33,229,171,173,131,214,255,162,38,196,230,133,204,170,218,52,222,88,55,235,162,112,183,216,161,62,127,101,249,135,33,173,232,214,146,0,118,119,45,39,10,168,1,103,61,174,50,120,7,111,186,57,143,80,148,26,53,66,152,254,112,253,181,112,189,75,165,199,9,251,79,61,108,203,29,30,4,0,0 };
			return method;
		}

		protected override SchemaMethod CreateMakeCaptionMethod() {
			SchemaMethod method = base.CreateMakeCaptionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,140,177,10,194,48,20,0,103,5,255,225,209,41,129,242,208,85,17,145,82,161,75,21,169,116,142,54,150,64,154,23,146,39,85,74,255,93,44,29,93,14,14,142,19,162,210,33,168,72,79,198,91,129,181,190,103,228,56,144,141,120,81,173,150,63,224,49,250,73,48,83,158,13,57,216,67,228,96,92,139,69,44,95,214,158,67,222,121,254,136,41,174,12,91,157,55,134,177,210,111,150,112,88,45,23,115,125,162,208,41,22,201,176,30,65,12,155,81,38,41,212,198,53,212,207,227,20,74,221,95,245,131,66,35,97,11,127,126,187,47,14,193,44,118,177,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateClearDataSourceFiltersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("392f25f0-f6e5-437f-a2bc-1827a2bc7a25"),
				Name = "ClearDataSourceFilters",
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,79,205,10,194,48,12,62,59,216,59,212,157,182,75,125,128,177,139,115,130,7,69,220,19,148,53,74,32,182,146,165,226,15,190,187,245,7,42,158,18,146,239,183,115,130,114,93,24,49,189,15,60,128,178,105,109,212,214,28,64,119,127,144,58,207,206,134,149,39,187,68,18,224,49,2,19,75,183,129,25,156,244,194,97,144,192,160,191,168,56,157,157,95,55,230,8,101,241,185,117,22,165,168,148,25,85,82,255,124,90,79,4,131,160,119,209,13,247,170,252,113,155,54,202,5,162,74,221,243,108,146,238,186,37,48,92,86,145,240,200,179,119,242,228,162,87,99,148,12,71,55,118,151,19,121,6,222,121,47,107,111,95,45,99,210,87,169,217,236,159,180,3,116,40,104,8,111,80,166,138,85,253,4,61,5,91,246,54,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeFilterEditMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ce9ccf48-33e3-474e-b0fe-484665a4688e"),
				Name = "InitializeFilterEdit",
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,77,10,194,48,16,133,215,22,122,135,208,85,187,169,7,16,23,254,180,226,66,145,122,130,208,140,50,144,38,101,58,17,127,240,238,54,93,24,105,193,221,192,188,239,189,55,83,24,70,126,108,37,203,179,117,84,131,80,97,92,138,147,188,66,94,140,36,139,56,186,73,18,23,212,12,84,40,228,29,89,215,246,234,128,230,37,26,85,14,130,110,216,174,31,71,217,64,154,148,95,40,201,122,31,188,136,116,226,179,20,198,105,157,137,87,28,205,254,134,108,8,36,195,111,204,36,96,246,43,119,68,96,248,204,228,106,118,228,75,14,100,190,82,106,220,194,179,239,56,26,238,15,150,249,190,219,88,237,26,211,21,247,86,91,2,170,172,229,131,85,254,87,189,173,127,205,124,62,134,42,64,131,140,82,227,19,210,208,39,91,124,0,93,212,174,170,124,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetPropertyDisplayPathByServerMetaPathMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("11b2bb8c-afde-4057-9cf5-026a5c8df980"),
				Name = "GetPropertyDisplayPathByServerMetaPath",
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("40106f3d-666d-4bc6-9945-a0ff8464cede"),
				Name = "serverMetaPath",
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,193,10,194,48,16,68,239,126,69,142,41,132,254,128,120,81,177,167,74,64,252,128,37,29,218,30,186,41,155,109,165,127,111,60,20,13,222,118,152,153,125,227,37,6,164,244,8,3,38,50,115,161,78,230,54,114,119,69,26,123,70,231,127,61,91,29,15,43,137,233,193,16,210,40,57,204,120,153,34,212,236,166,125,38,200,37,50,35,232,24,217,149,156,186,40,181,196,212,67,234,59,77,72,51,5,100,146,64,23,225,47,172,110,160,185,52,67,116,243,164,195,121,107,161,244,185,236,223,8,79,146,63,41,196,22,208,202,153,188,105,133,236,77,103,84,150,12,123,3,108,176,144,21,17,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetPropertyServerMetaPathByClientMetaPathMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("12e2fbfb-ad64-4ea7-9263-f7be7f92183a"),
				Name = "GetPropertyServerMetaPathByClientMetaPath",
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("693a4097-26dd-433d-a7cd-6410494b89f5"),
				Name = "clientMetaPath",
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,141,59,10,195,48,16,68,251,156,66,165,12,70,23,48,174,18,226,202,65,16,114,128,69,30,100,65,188,50,171,117,114,125,187,201,71,229,240,102,230,121,201,1,165,220,195,140,133,204,90,165,222,92,19,79,23,148,20,25,147,255,103,182,233,78,47,18,19,193,16,210,44,71,153,241,54,85,105,248,64,251,40,144,115,102,70,208,148,185,173,61,174,26,141,196,20,33,238,70,11,202,74,1,135,73,160,155,240,79,230,6,232,8,37,79,58,219,234,171,53,225,153,192,95,218,116,59,151,52,170,164,225,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEntityCollectionDisplayValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a8b74f5c-77d4-4cf8-85ca-fa2780c1e6b5"),
				Name = "GetEntityCollectionDisplayValue",
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c255f608-84d7-462b-aaaf-794133bbc3f8"),
				Name = "displayValue",
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("cda4bd88-6442-4f01-a6de-037af91c12e7"),
				Name = "metaPath",
				CreatedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				ModifiedInSchemaUId = new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,140,177,10,195,32,20,0,231,248,21,142,186,228,7,164,75,104,26,178,164,129,210,238,143,248,154,8,106,197,247,164,72,233,191,183,99,50,30,220,157,123,74,69,156,93,92,219,145,166,226,253,53,247,33,113,85,214,81,242,80,31,224,11,106,45,63,162,153,243,107,65,162,219,178,97,0,153,14,116,146,23,23,237,25,201,173,17,237,193,84,218,136,102,127,251,203,135,184,29,144,59,32,236,61,6,140,220,213,251,104,85,196,183,28,138,179,42,32,195,12,188,105,221,78,16,208,136,175,200,200,37,71,185,127,154,31,50,114,192,190,200,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DeleteEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bb15b42b-e78e-4c46-96b4-27a46d8eeef7"));
		}

		#endregion

	}

	#endregion

}

