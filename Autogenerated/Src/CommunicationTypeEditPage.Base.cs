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

	#region Class: CommunicationTypeEditPageSchema

	/// <exclude/>
	public class CommunicationTypeEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TextEdit _hyperlinkTemplateTextEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit HyperlinkTemplateTextEdit {
			get {
				return _hyperlinkTemplateTextEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _useControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout UseControlLayout {
			get {
				return _useControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _useforContactsCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox UseforContactsCheckBox {
			get {
				return _useforContactsCheckBox;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _useforAccountsCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox UseforAccountsCheckBox {
			get {
				return _useforAccountsCheckBox;
			}
		}

		#endregion

		#region Constructors: Public

		public CommunicationTypeEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public CommunicationTypeEditPageSchema(CommunicationTypeEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("0cd3c135-f4cf-4c40-9de1-427875ed346e");
			NameEdit.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("21b788d2-11fb-4608-84da-fa712206f392");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
			RealUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
			Name = "CommunicationTypeEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 320;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCommunicationTypeEditPageEventsProcessSchema();
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
			UpdateDescriptionEdit();
			UpdateNameEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, NameEdit);
			MainControlLayout.MoveItem(1, DescriptionEdit);
			MainControlLayout.InsertItem(2, CreateHyperlinkTemplateTextEdit());
			MainControlLayout.InsertItem(3, CreateUseControlLayout());
			UseControlLayout.InsertItem(0, CreateUseforContactsCheckBox());
			UseControlLayout.InsertItem(1, CreateUseforAccountsCheckBox());
			MainControlLayout.MoveItem(4, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateCommunicationTypeEditPageEventsProcessSchema() {
			var schema = new CommunicationTypeEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateHyperlinkTemplateTextEdit() {
			_hyperlinkTemplateTextEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_hyperlinkTemplateTextEdit.UId = new Guid("22f5d0f4-97d2-4c81-ada9-8cfe48f5084f");
			_hyperlinkTemplateTextEdit.Name = "HyperlinkTemplateTextEdit";
			_hyperlinkTemplateTextEdit.CreatedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
			_hyperlinkTemplateTextEdit.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
			_hyperlinkTemplateTextEdit.CreatedInPackageId = Guid.Empty;
			_hyperlinkTemplateTextEdit.Tag = "";
			_hyperlinkTemplateTextEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_hyperlinkTemplateTextEdit.Image = new ControlImage {};
			_hyperlinkTemplateTextEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_hyperlinkTemplateTextEdit.CaptionPosition = Terrasoft.UI.WebControls.CaptionPosition.Top;
			_hyperlinkTemplateTextEdit.DataSource = "DataSource";
			_hyperlinkTemplateTextEdit.ColumnUId = new Guid("bff6ae63-4ffa-4de2-9664-30f70a6c4200");
			return _hyperlinkTemplateTextEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateUseforContactsCheckBox() {
			_useforContactsCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_useforContactsCheckBox.UId = new Guid("3108c835-a320-4e16-9edc-3a31ce018e24");
			_useforContactsCheckBox.Name = "UseforContactsCheckBox";
			_useforContactsCheckBox.CreatedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
			_useforContactsCheckBox.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
			_useforContactsCheckBox.CreatedInPackageId = Guid.Empty;
			_useforContactsCheckBox.Tag = "";
			_useforContactsCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_useforContactsCheckBox.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_useforContactsCheckBox.DataSource = "DataSource";
			_useforContactsCheckBox.ColumnUId = new Guid("ba4bd0ce-d703-4305-afab-e53e3fd355de");
			return _useforContactsCheckBox;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateUseforAccountsCheckBox() {
			_useforAccountsCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_useforAccountsCheckBox.UId = new Guid("e4cc1fd4-c72c-4529-9b1e-b58a6fbcfdab");
			_useforAccountsCheckBox.Name = "UseforAccountsCheckBox";
			_useforAccountsCheckBox.CreatedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
			_useforAccountsCheckBox.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
			_useforAccountsCheckBox.CreatedInPackageId = Guid.Empty;
			_useforAccountsCheckBox.Tag = "";
			_useforAccountsCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_useforAccountsCheckBox.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_useforAccountsCheckBox.DataSource = "DataSource";
			_useforAccountsCheckBox.ColumnUId = new Guid("2b7f9bfc-4bf7-4edb-ac13-460255d20776");
			return _useforAccountsCheckBox;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateUseControlLayout() {
			_useControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_useControlLayout.UId = new Guid("9ce85da1-427c-4805-abc5-919a319030d3");
			_useControlLayout.Name = "UseControlLayout";
			_useControlLayout.CreatedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
			_useControlLayout.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
			_useControlLayout.CreatedInPackageId = Guid.Empty;
			_useControlLayout.Tag = "";
			_useControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_useControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_useControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_useControlLayout.FitHeightByContent = true;
			_useControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_useControlLayout.StartNewAlignGroup = false;
			_useControlLayout.Image = new ControlImage {};
			_useControlLayout.Edges = "";
			return _useControlLayout;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("d846cb4f-f18d-469e-83ff-e961f3fba873");
			DataSource.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("f25f6bc4-40e7-47ad-a516-55692e096f06");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
				column.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("0cd3c135-f4cf-4c40-9de1-427875ed346e");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
				column.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("7a8944fa-b3f0-46dc-8f51-f6b0706106f8");
			if (column != null) {
				column.UId = new Guid("a0bebe06-1472-4ede-9944-4b9cc48a5c66");
				column.Name = @"Image";
				column.CreatedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
				column.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("5464fdd4-1264-44c2-ae74-07296e04eb8a");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
				column.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("cdaa6789-41d9-4907-8cd9-9add203027b6");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
				column.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("e1dd5dc8-b294-4f84-ad44-550b74f3148e");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
				column.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("44db1041-3e12-4c98-b9e9-51601e567920");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
				column.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("21b788d2-11fb-4608-84da-fa712206f392");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
				column.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("0da3b0de-9d19-47e8-89e4-e113dde44a8c");
			if (column != null) {
				column.UId = new Guid("bff6ae63-4ffa-4de2-9664-30f70a6c4200");
				column.Name = @"HyperlinkTemplate";
				column.CreatedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
				column.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9583d17a-064d-402d-bdb1-7d377628d64b");
			if (column != null) {
				column.UId = new Guid("2b7f9bfc-4bf7-4edb-ac13-460255d20776");
				column.Name = @"UseforAccounts";
				column.CreatedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
				column.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("07748e81-b1d1-4cdb-9e41-d5e0be2e13d9");
			if (column != null) {
				column.UId = new Guid("ba4bd0ce-d703-4305-afab-e53e3fd355de");
				column.Name = @"UseforContacts";
				column.CreatedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
				column.ModifiedInSchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
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
			return new CommunicationTypeEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new CommunicationTypeEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CommunicationTypeEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: CommunicationTypeEditPageEventsProcess

	/// <exclude/>
	public class CommunicationTypeEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.CommunicationTypeEditPageSchemaUserControl
	{

		public CommunicationTypeEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CommunicationTypeEditPageEventsProcess";
			SchemaUId = new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9584479c-d9c0-4ca6-ae9e-ca9f61d11835");
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

	#region Class: CommunicationTypeEditPageEventsProcess

	/// <exclude/>
	public class CommunicationTypeEditPageEventsProcess : CommunicationTypeEditPageEventsProcess<Terrasoft.WebApp.CommunicationTypeEditPageSchemaUserControl>
	{

		public CommunicationTypeEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CommunicationTypeEditPageSchemaUserControl

	/// <exclude/>
	public partial class CommunicationTypeEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TextEdit HyperlinkTemplateTextEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("HyperlinkTemplateTextEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout UseControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("UseControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox UseforContactsCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("UseforContactsCheckBox", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox UseforAccountsCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("UseforAccountsCheckBox", true);
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
			var process = (CommunicationTypeEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new CommunicationTypeEditPageEventsProcess(UserConnection);
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
			SchemaName = "CommunicationTypeEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: CommunicationTypeEditPageEventsProcessSchema

	/// <exclude/>
	public class CommunicationTypeEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public CommunicationTypeEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CommunicationTypeEditPageEventsProcessSchema(CommunicationTypeEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CommunicationTypeEditPageEventsProcess";
			UId = new Guid("c60838f5-aa21-465b-a7fa-959d2fb2d35e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b");
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
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CommunicationTypeEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c60838f5-aa21-465b-a7fa-959d2fb2d35e"));
		}

		#endregion

	}

	#endregion

}

