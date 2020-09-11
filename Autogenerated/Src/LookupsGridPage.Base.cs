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

	#region Class: LookupsGridPageSchema

	/// <exclude/>
	public class LookupsGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer1;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return _spacer1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _openButton;
		public Terrasoft.UI.WebControls.Controls.Button OpenButton {
			get {
				return _openButton;
			}
		}

		#endregion

		#region Constructors: Public

		public LookupsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public LookupsGridPageSchema(LookupsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				ImageHash = @""
			};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
		}

		private void UpdateEditButton() {
			EditButton.AjaxEvents.Click.IsProcessEventHandler = true;
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.DblClick.IsProcessEventHandler = true;
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
			RealUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
			Name = "LookupsGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			HelpContextId = "271";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLookupsGridPageEventsProcessSchema();
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
			ButtonsControlLayout.InsertItem(4, CreateSpacer1());
			ButtonsControlLayout.InsertItem(5, CreateOpenButton());
			ButtonsControlLayout.MoveItem(6, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(7, ActionButton);
			ButtonsControlLayout.MoveItem(8, PrintButton);
			ButtonsControlLayout.MoveItem(9, ContextHelpButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateLookupsGridPageEventsProcessSchema() {
			var schema = new LookupsGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer1() {
			_spacer1 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer1.UId = new Guid("e0e7e812-324d-4bd1-a0fc-2dd00fda3f9f");
			_spacer1.Name = "Spacer1";
			_spacer1.CreatedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
			_spacer1.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
			_spacer1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer1.Tag = "";
			_spacer1.Size = System.Web.UI.WebControls.Unit.Pixel(15);
			return _spacer1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateOpenButton() {
			_openButton = new Terrasoft.UI.WebControls.Controls.Button();
			_openButton.UId = new Guid("dd412631-c321-4e3f-8745-89c7350077bb");
			_openButton.Name = "OpenButton";
			_openButton.CreatedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
			_openButton.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
			_openButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_openButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_openButton.Tag = "";
			_openButton.Image = new ControlImage {};
			return _openButton;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("ffee71d2-1485-4c86-9cdb-3d74ea091dd1");
			DataSource.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("a21ddf13-a82d-415a-a847-77360b0d591c");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("68b18b72-3a33-4b35-8930-b5f5c281666c");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("84d4936a-33aa-4260-a177-69ceb8274ebc");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("9fcbc10f-910b-43f4-b33b-62e85c51c324");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("ef811eae-9401-4813-98c8-0e2ecb34a000");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("a50bf2cf-3523-47e8-8f8c-bac5b0bccec8");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("a3c8b010-676f-448f-abf4-7bd2d3d6993b");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9ac36be4-1445-4efb-9045-587e6bb8e227");
			if (column != null) {
				column.UId = new Guid("9a155351-4920-42df-9259-70df26aa9a5c");
				column.Name = @"SysFolder";
				column.CreatedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("3b5c6494-229e-40ab-9240-faa5956a9458");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("2d6de8c4-3d7f-4a80-84f2-d4a29ede4103");
			if (column != null) {
				column.UId = new Guid("1a3ccdc3-e04a-49ac-a322-1c479e39b868");
				column.Name = @"IsSimple";
				column.CreatedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("599a1372-11a5-4327-a342-072bdbb4b38e");
			if (column != null) {
				column.UId = new Guid("2267f6f6-7ded-41af-9c2a-343414f1009f");
				column.Name = @"IsSystem";
				column.CreatedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("d2f7d553-0292-4a39-bb17-6f6ba26a3ae1");
			if (column != null) {
				column.UId = new Guid("72cfe691-36dd-4e30-ae7f-625fb6084de2");
				column.Name = @"SysWorkspace";
				column.CreatedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("7c81b883-a2fd-4152-af5a-b30c128aefb0");
			if (column != null) {
				column.UId = new Guid("dd79da52-760f-4acc-a001-13f6e319f9be");
				column.Name = @"SysEditPageSchemaUId";
				column.CreatedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9290f7c4-590b-4a35-8e87-61685eb8752e");
			if (column != null) {
				column.UId = new Guid("521a5ecf-617e-4ecb-a984-a7e3ddf910dd");
				column.Name = @"SysGridPageSchemaU";
				column.CreatedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("d50e7964-0111-4cad-8cc3-eae56078533e");
			if (column != null) {
				column.UId = new Guid("8d2b786f-94e0-4bd9-83e0-02090777eb89");
				column.Name = @"SysEntitySchemaU";
				column.CreatedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.ModifiedInSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
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
			return new LookupsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new LookupsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new LookupsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: LookupsGridPageEventsProcess

	/// <exclude/>
	public class LookupsGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.LookupsGridPageSchemaUserControl
	{

		#region Class: UserTaskOpenPageFlowElement

		/// <exclude/>
		public class UserTaskOpenPageFlowElement : OpenPageUserTask
		{

			public UserTaskOpenPageFlowElement(UserConnection userConnection, LookupsGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserTaskOpenPage";
				IsLogging = false;
				SchemaElementUId = new Guid("ab7dac87-cb06-4278-bd1e-3aeb121bfefe");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenLookupUserTaskFlowElement

		/// <exclude/>
		public class OpenLookupUserTaskFlowElement : OpenLookupUserTask
		{

			public OpenLookupUserTaskFlowElement(UserConnection userConnection, LookupsGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenLookupUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("8843e781-b673-43be-98a0-4f9b18a17a62");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public LookupsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LookupsGridPageEventsProcess";
			SchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
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

		public virtual Guid CurrentLookupFolder {
			get;
			set;
		}

		public virtual bool OpenGridPage {
			get;
			set;
		}

		public virtual bool IsSelectedFolderRoot {
			get;
			set;
		}

		private ProcessFlowElement _subProcessChildPageLoadComplete;
		public ProcessFlowElement SubProcessChildPageLoadComplete {
			get {
				return _subProcessChildPageLoadComplete ?? (_subProcessChildPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessChildPageLoadComplete",
					SchemaElementUId = new Guid("18e3210a-dc05-4406-8a30-ef242b7680ff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageChildPageLoadComplete;
		public ProcessFlowElement StartMessageChildPageLoadComplete {
			get {
				return _startMessageChildPageLoadComplete ?? (_startMessageChildPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChildPageLoadComplete",
					SchemaElementUId = new Guid("69933426-e9be-4952-ad9d-b80978252bd1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptChildPageLoadComplete;
		public ProcessScriptTask ScriptChildPageLoadComplete {
			get {
				return _scriptChildPageLoadComplete ?? (_scriptChildPageLoadComplete = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildPageLoadComplete",
					SchemaElementUId = new Guid("c39cdb4b-e946-430d-aa26-0867dfeb2318"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildPageLoadCompleteExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowBasePageLoadComplete;
		public ProcessThrowMessageEvent IntermediateThrowBasePageLoadComplete {
			get {
				return _intermediateThrowBasePageLoadComplete ?? (_intermediateThrowBasePageLoadComplete = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowBasePageLoadComplete",
					SchemaElementUId = new Guid("028dc97b-1833-4460-8f90-eadef477169a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
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
					SchemaElementUId = new Guid("84e8d76d-7228-4e6f-935a-104fa1754f04"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage2;
		public ProcessFlowElement StartMessage2 {
			get {
				return _startMessage2 ?? (_startMessage2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage2",
					SchemaElementUId = new Guid("07acc873-7c63-468e-8067-df765decf009"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3;
		public ProcessScriptTask ScriptTask3 {
			get {
				return _scriptTask3 ?? (_scriptTask3 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3",
					SchemaElementUId = new Guid("ee3b701f-8831-4ecc-9839-0e14ba288098"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3Execute,
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
					SchemaElementUId = new Guid("4c133949-de31-4122-abc3-e0823c6f9130"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DataSourceLoadRowsResponseRegistered",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _subProcessChildApplyFolderFilter;
		public ProcessFlowElement SubProcessChildApplyFolderFilter {
			get {
				return _subProcessChildApplyFolderFilter ?? (_subProcessChildApplyFolderFilter = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessChildApplyFolderFilter",
					SchemaElementUId = new Guid("84bfed56-e7b5-49da-85b3-8ff85b925ae2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptChildApplyFolderFilter;
		public ProcessScriptTask ScriptChildApplyFolderFilter {
			get {
				return _scriptChildApplyFolderFilter ?? (_scriptChildApplyFolderFilter = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildApplyFolderFilter",
					SchemaElementUId = new Guid("1d2df63f-7e2c-4dca-9dcb-bc5428e93dfb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildApplyFolderFilterExecute,
				});
			}
		}

		private ProcessFlowElement _startMessageChildApplyFolderFilter;
		public ProcessFlowElement StartMessageChildApplyFolderFilter {
			get {
				return _startMessageChildApplyFolderFilter ?? (_startMessageChildApplyFolderFilter = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChildApplyFolderFilter",
					SchemaElementUId = new Guid("7a70825b-fcb6-457a-9b10-b2215d4503ce"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess8;
		public ProcessFlowElement EventSubProcess8 {
			get {
				return _eventSubProcess8 ?? (_eventSubProcess8 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess8",
					SchemaElementUId = new Guid("3ab2871c-bd54-4080-9686-a3b2201bd55d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _childStartMessageBasePrepareFilters;
		public ProcessFlowElement ChildStartMessageBasePrepareFilters {
			get {
				return _childStartMessageBasePrepareFilters ?? (_childStartMessageBasePrepareFilters = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChildStartMessageBasePrepareFilters",
					SchemaElementUId = new Guid("2eaa6c66-d0db-4ec2-a62c-da05d9ac783a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _throwMessageBasePrepareFilters;
		public ProcessThrowMessageEvent ThrowMessageBasePrepareFilters {
			get {
				return _throwMessageBasePrepareFilters ?? (_throwMessageBasePrepareFilters = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowMessageBasePrepareFilters",
					SchemaElementUId = new Guid("0b4c66a2-72af-4dd1-90f0-ba9f4eb2eb0d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "BasePrepareFilters",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _childBasePrepareFiltersScriptTask;
		public ProcessScriptTask ChildBasePrepareFiltersScriptTask {
			get {
				return _childBasePrepareFiltersScriptTask ?? (_childBasePrepareFiltersScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChildBasePrepareFiltersScriptTask",
					SchemaElementUId = new Guid("3b933db1-5465-4d3a-9b2b-9184bcbf8816"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChildBasePrepareFiltersScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _openGridSubProcess;
		public ProcessFlowElement OpenGridSubProcess {
			get {
				return _openGridSubProcess ?? (_openGridSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OpenGridSubProcess",
					SchemaElementUId = new Guid("87b3dd4c-7645-4969-b445-8537b26a2995"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _openButtonClick;
		public ProcessFlowElement OpenButtonClick {
			get {
				return _openButtonClick ?? (_openButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OpenButtonClick",
					SchemaElementUId = new Guid("dd63c28d-7b4e-4eeb-bf48-a6adc885ea62"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptOpenButtonClick;
		public ProcessScriptTask ScriptOpenButtonClick {
			get {
				return _scriptOpenButtonClick ?? (_scriptOpenButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptOpenButtonClick",
					SchemaElementUId = new Guid("21816672-d825-486f-838d-a31f90c3341e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptOpenButtonClickExecute,
				});
			}
		}

		private UserTaskOpenPageFlowElement _userTaskOpenPage;
		public UserTaskOpenPageFlowElement UserTaskOpenPage {
			get {
				return _userTaskOpenPage ?? (_userTaskOpenPage = new UserTaskOpenPageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("58d429a8-3d39-4549-ab21-c5d68fc8549e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
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
					SchemaElementUId = new Guid("b8c21877-b0f8-4056-8eba-e1d9287dc784"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _openLookup;
		public ProcessFlowElement OpenLookup {
			get {
				return _openLookup ?? (_openLookup = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OpenLookup",
					SchemaElementUId = new Guid("614e9aaf-0d00-47de-aafa-fb9a00bf3168"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptPrepareOpenLookup;
		public ProcessScriptTask ScriptPrepareOpenLookup {
			get {
				return _scriptPrepareOpenLookup ?? (_scriptPrepareOpenLookup = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPrepareOpenLookup",
					SchemaElementUId = new Guid("dbf56a73-ef1f-4f7f-80f0-5f2a894fdf40"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPrepareOpenLookupExecute,
				});
			}
		}

		private OpenLookupUserTaskFlowElement _openLookupUserTask;
		public OpenLookupUserTaskFlowElement OpenLookupUserTask {
			get {
				return _openLookupUserTask ?? (_openLookupUserTask = new OpenLookupUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("6c214867-2f8e-4123-823e-5b6e98b19e83"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _treeGridDblClick2;
		public ProcessFlowElement TreeGridDblClick2 {
			get {
				return _treeGridDblClick2 ?? (_treeGridDblClick2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "TreeGridDblClick2",
					SchemaElementUId = new Guid("258f6696-9fd8-4514-9965-a44e49cdef8d"),
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
					SchemaElementUId = new Guid("25437241-95bd-4214-b347-e8e158bccd0d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OpenButtonClick",
				});
			}
		}

		private ProcessFlowElement _dataSourceActiveRowChangedEventChildSubProcess;
		public ProcessFlowElement DataSourceActiveRowChangedEventChildSubProcess {
			get {
				return _dataSourceActiveRowChangedEventChildSubProcess ?? (_dataSourceActiveRowChangedEventChildSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "DataSourceActiveRowChangedEventChildSubProcess",
					SchemaElementUId = new Guid("1b4b8222-9d2b-4f19-b666-312eaeaacd7d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dataSourceActiveRowChangedChildStartMessage;
		public ProcessFlowElement DataSourceActiveRowChangedChildStartMessage {
			get {
				return _dataSourceActiveRowChangedChildStartMessage ?? (_dataSourceActiveRowChangedChildStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataSourceActiveRowChangedChildStartMessage",
					SchemaElementUId = new Guid("ae6614ea-ae79-4de9-8759-e86975d7d939"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _dataSourceActiveRowChangedChildIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent DataSourceActiveRowChangedChildIntermediateThrowMessageEvent {
			get {
				return _dataSourceActiveRowChangedChildIntermediateThrowMessageEvent ?? (_dataSourceActiveRowChangedChildIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "DataSourceActiveRowChangedChildIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("c8d3865c-ec77-4b84-bac3-a50a1ae19b05"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DataSourceActiveRowChanged",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptTask2;
		public ProcessScriptTask ScriptTask2 {
			get {
				return _scriptTask2 ?? (_scriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask2",
					SchemaElementUId = new Guid("8be81003-8b0b-45a0-8ea7-7c6e0780b809"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
				});
			}
		}

		private ProcessConditionalFlow _sequenceFlow9523;
		public ProcessConditionalFlow SequenceFlow9523 {
			get {
				return _sequenceFlow9523 ?? (_sequenceFlow9523 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "SequenceFlow9523",
					SchemaElementUId = new Guid("e88917f4-baf1-4db9-a9a2-8d4daa954810"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SubProcessChildPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessChildPageLoadComplete };
			FlowElements[StartMessageChildPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChildPageLoadComplete };
			FlowElements[ScriptChildPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildPageLoadComplete };
			FlowElements[IntermediateThrowBasePageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowBasePageLoadComplete };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[ScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[SubProcessChildApplyFolderFilter.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessChildApplyFolderFilter };
			FlowElements[ScriptChildApplyFolderFilter.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildApplyFolderFilter };
			FlowElements[StartMessageChildApplyFolderFilter.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChildApplyFolderFilter };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[ChildStartMessageBasePrepareFilters.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildStartMessageBasePrepareFilters };
			FlowElements[ThrowMessageBasePrepareFilters.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowMessageBasePrepareFilters };
			FlowElements[ChildBasePrepareFiltersScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildBasePrepareFiltersScriptTask };
			FlowElements[OpenGridSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenGridSubProcess };
			FlowElements[OpenButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenButtonClick };
			FlowElements[ScriptOpenButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptOpenButtonClick };
			FlowElements[UserTaskOpenPage.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTaskOpenPage };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[SubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess9 };
			FlowElements[OpenLookup.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenLookup };
			FlowElements[ScriptPrepareOpenLookup.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPrepareOpenLookup };
			FlowElements[OpenLookupUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenLookupUserTask };
			FlowElements[SubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess10 };
			FlowElements[TreeGridDblClick2.SchemaElementUId] = new Collection<ProcessFlowElement> { TreeGridDblClick2 };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[DataSourceActiveRowChangedEventChildSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceActiveRowChangedEventChildSubProcess };
			FlowElements[DataSourceActiveRowChangedChildStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceActiveRowChangedChildStartMessage };
			FlowElements[DataSourceActiveRowChangedChildIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceActiveRowChangedChildIntermediateThrowMessageEvent };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcessChildPageLoadComplete":
						break;
					case "StartMessageChildPageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptChildPageLoadComplete");
						break;
					case "ScriptChildPageLoadComplete":
						e.Context.QueueTasks.Enqueue("IntermediateThrowBasePageLoadComplete");
						break;
					case "IntermediateThrowBasePageLoadComplete":
						break;
					case "EventSubProcess1":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "ScriptTask3":
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("ScriptTask3");
						break;
					case "SubProcessChildApplyFolderFilter":
						break;
					case "ScriptChildApplyFolderFilter":
						break;
					case "StartMessageChildApplyFolderFilter":
						e.Context.QueueTasks.Enqueue("ScriptChildApplyFolderFilter");
						break;
					case "EventSubProcess8":
						break;
					case "ChildStartMessageBasePrepareFilters":
						e.Context.QueueTasks.Enqueue("ThrowMessageBasePrepareFilters");
						break;
					case "ThrowMessageBasePrepareFilters":
						e.Context.QueueTasks.Enqueue("ChildBasePrepareFiltersScriptTask");
						break;
					case "ChildBasePrepareFiltersScriptTask":
						break;
					case "OpenGridSubProcess":
						break;
					case "OpenButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptOpenButtonClick");
						break;
					case "ScriptOpenButtonClick":
						if (SequenceFlow9523ExpressionExecute()) {
						e.Context.QueueTasks.Enqueue("UserTaskOpenPage");
							break;
						}
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "UserTaskOpenPage":
						break;
					case "ScriptTask1":
						break;
					case "SubProcess9":
						break;
					case "OpenLookup":
						e.Context.QueueTasks.Enqueue("ScriptPrepareOpenLookup");
						break;
					case "ScriptPrepareOpenLookup":
						e.Context.QueueTasks.Enqueue("OpenLookupUserTask");
						break;
					case "OpenLookupUserTask":
						break;
					case "SubProcess10":
						break;
					case "TreeGridDblClick2":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "IntermediateThrowMessageEvent2":
						break;
					case "DataSourceActiveRowChangedEventChildSubProcess":
						break;
					case "DataSourceActiveRowChangedChildStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "DataSourceActiveRowChangedChildIntermediateThrowMessageEvent":
						break;
					case "ScriptTask2":
						e.Context.QueueTasks.Enqueue("DataSourceActiveRowChangedChildIntermediateThrowMessageEvent");
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool SequenceFlow9523ExpressionExecute() {
			return Convert.ToBoolean(OpenGridPage);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageChildPageLoadComplete");
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("StartMessageChildApplyFolderFilter");
			ActivatedEventElements.Add("ChildStartMessageBasePrepareFilters");
			ActivatedEventElements.Add("OpenButtonClick");
			ActivatedEventElements.Add("OpenLookup");
			ActivatedEventElements.Add("TreeGridDblClick2");
			ActivatedEventElements.Add("DataSourceActiveRowChangedChildStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcessChildPageLoadComplete":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageChildPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChildPageLoadComplete";
					result = StartMessageChildPageLoadComplete.Execute(context);
					break;
				case "ScriptChildPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildPageLoadComplete";
					result = ScriptChildPageLoadComplete.Execute(context, ScriptChildPageLoadCompleteExecute);
					break;
				case "IntermediateThrowBasePageLoadComplete":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowBasePageLoadComplete.Execute(context);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "ScriptTask3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3";
					result = ScriptTask3.Execute(context, ScriptTask3Execute);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DataSourceLoadRowsResponseRegistered");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "SubProcessChildApplyFolderFilter":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptChildApplyFolderFilter":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildApplyFolderFilter";
					result = ScriptChildApplyFolderFilter.Execute(context, ScriptChildApplyFolderFilterExecute);
					break;
				case "StartMessageChildApplyFolderFilter":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChildApplyFolderFilter";
					result = StartMessageChildApplyFolderFilter.Execute(context);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "ChildStartMessageBasePrepareFilters":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildStartMessageBasePrepareFilters";
					result = ChildStartMessageBasePrepareFilters.Execute(context);
					break;
				case "ThrowMessageBasePrepareFilters":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "BasePrepareFilters");
					result = ThrowMessageBasePrepareFilters.Execute(context);
					break;
				case "ChildBasePrepareFiltersScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildBasePrepareFiltersScriptTask";
					result = ChildBasePrepareFiltersScriptTask.Execute(context, ChildBasePrepareFiltersScriptTaskExecute);
					break;
				case "OpenGridSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "OpenButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenButtonClick";
					result = OpenButtonClick.Execute(context);
					break;
				case "ScriptOpenButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptOpenButtonClick";
					result = ScriptOpenButtonClick.Execute(context, ScriptOpenButtonClickExecute);
					break;
				case "UserTaskOpenPage":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserTaskOpenPage";
					result = UserTaskOpenPage.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "SubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "OpenLookup":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenLookup";
					result = OpenLookup.Execute(context);
					break;
				case "ScriptPrepareOpenLookup":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPrepareOpenLookup";
					result = ScriptPrepareOpenLookup.Execute(context, ScriptPrepareOpenLookupExecute);
					break;
				case "OpenLookupUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenLookupUserTask";
					result = OpenLookupUserTask.Execute(context);
					break;
				case "SubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "TreeGridDblClick2":
					context.QueueTasks.Dequeue();
					context.SenderName = "TreeGridDblClick2";
					result = TreeGridDblClick2.Execute(context);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessageEvent2.Execute(context);
					break;
				case "DataSourceActiveRowChangedEventChildSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "DataSourceActiveRowChangedChildStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceActiveRowChangedChildStartMessage";
					result = DataSourceActiveRowChangedChildStartMessage.Execute(context);
					break;
				case "DataSourceActiveRowChangedChildIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DataSourceActiveRowChanged");
					result = DataSourceActiveRowChangedChildIntermediateThrowMessageEvent.Execute(context);
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
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
				case "IsSelectedFolderRoot":
					IsSelectedFolderRoot = reader.GetValue<System.Boolean>();
				break;
				case "OpenGridPage":
					OpenGridPage = reader.GetValue<System.Boolean>();
				break;
				case "CurrentLookupFolder":
					CurrentLookupFolder = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptChildPageLoadCompleteExecute(ProcessExecutingContext context) {
			if (EditPageUId == Guid.Empty || EditPageUId == null) {
				EditPageUId = new Guid("fd4a2808-4549-4bb6-929c-ddc70ec2c5ac");
			}
			Page.TreeGrid.QuickViewMode = TreeGridQuickViewMode.None;
			return true;
		}

		public virtual bool ScriptTask3Execute(ProcessExecutingContext context) {
			//System.Diagnostics.Debugger.Break();
			
			var dataSource = Page.DataSource;
			if (dataSource.SelectedItemPrimaryColumnValues.Count > 0) {
				Page.UserConnection.SessionData["LookupSchemaUid"] = dataSource.Schema.UId;
				Page.UserConnection.SessionData["LookupUid"] = dataSource.ActiveRowPrimaryColumnValue;
			}
			return true;
		}

		public virtual bool ScriptChildApplyFolderFilterExecute(ProcessExecutingContext context) {
			var listenerPageProcess = UserConnection.IProcessEngine.GetProcessByUId(ListenerPageProcessUId);
			var dataSource = Page.DataSource;
			var currentStructure = dataSource.CurrentStructure;
			bool clearFilter = dataSource.CurrentStructure.Filters.Count > 0;
			if(clearFilter){
				var filterEdit = dataSource.CurrentStructure.Filters[0];
				foreach(var filter in dataSource.CurrentStructure.Filters){
					if(filter.Name == "FilterEdit")
						filterEdit = filter;
				}
				dataSource.CurrentStructure.Filters.Clear();
				dataSource.CurrentStructure.Filters.Add(filterEdit);
			}
			if(CurrentLookupFolder!=null){
				if((Guid)CurrentLookupFolder !=Guid.Empty) {
					currentStructure.Filters.Add(dataSource.CreateFilterWithParameters(FilterComparisonType.Equal,
								"SysFolder", CurrentLookupFolder));
				}
			}
			Page.TreeGrid.Clear();
			dataSource.LoadRows();
			Guid filterColumnValue = Guid.Empty;
			if(dataSource.Rows.Count != 0) {
				var primaryColumnName = dataSource.Schema.PrimaryColumn.Name;
				filterColumnValue = new Guid(dataSource.Rows[0].GetColumnValue(primaryColumnName).ToString());
			}
			listenerPageProcess.SetPropertyValue("FilterColumnValue", filterColumnValue);
			ListenerThrowEvent(ListenerPageProcessUId, "RefreshDetails");
			return true;
		}

		public virtual bool ChildBasePrepareFiltersScriptTaskExecute(ProcessExecutingContext context) {
			var dataSource = Page.DataSource;
			var structure = dataSource.CurrentStructure;
			var filtersName = "WorkspaceFilters";
			var filters = dataSource.FindFiltersGroupByName(filtersName);
			if (filters != null) {
				structure.Filters.Remove(filters);
			}
			filters = structure.CreateFiltersGroup(filtersName, LogicalOperationStrict.Or);
			filters.Add(structure.CreateFilterWithParameters(dataSource.Schema, FilterComparisonType.Equal,"SysWorkspace", UserConnection.Workspace.Id));
			structure.Filters.Add(filters);
			return true;
		}

		public virtual bool ScriptOpenButtonClickExecute(ProcessExecutingContext context) {
			Guid gridSchemaId = Guid.Empty;
			string url = String.Empty;
			var selectedNodes = Page.TreeGrid.SelectedNodes;
			if (selectedNodes.Count == 0) {
				return true;
			}
			if (selectedNodes[0].Values.ContainsKey("SysGridPageSchemaUId")){
				OpenGridPage = true;
				gridSchemaId = new Guid(selectedNodes[0].Values["SysGridPageSchemaUId"].ToString());	
				UserTaskOpenPage.OpenerInstanceId = InstanceUId;
				UserTaskOpenPage.PageUId = gridSchemaId; 	
				UserTaskOpenPage.PageParameters = new Dictionary<string, string>() {
					{ "editMode", "true" }
				};
			} else {
				OpenGridPage = false;
				Page.ThrowEvent("OpenLookup");
			}
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ScriptPrepareOpenLookupExecute(ProcessExecutingContext context) {
			string instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
			OpenLookupUserTask.ProcessKey = instanceId + Page.PageContainer.UniqueID;
			var selectedNodes = Page.TreeGrid.SelectedNodes;
			string schemaUId = selectedNodes[0].Values["SysEntitySchemaUId"].ToString();  
			OpenLookupUserTask.PageParameters = new Dictionary <string, object>();
			var pageParameters = 
			(Dictionary <string, object>) OpenLookupUserTask.PageParameters;
			pageParameters.Add("schemaUId", schemaUId);
			pageParameters.Add("editMode", true);
			Collection<Dictionary<string, object>> filters = new Collection<Dictionary<string, object>>();
			pageParameters.Add("LookupFilters", filters);	
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			var dataSource = Page.DataSource;
			if (Guid.Empty.Equals(dataSource.ActiveRowPrimaryColumnValue)) {
				return false;
			}
			Page.UserConnection.SessionData["LookupSchemaUid"] = dataSource.Schema.UId;
			Page.UserConnection.SessionData["LookupUid"] = dataSource.ActiveRowPrimaryColumnValue;
			return true;
		}

		public override System.Collections.Generic.List<string> GetButtons() {
			var buttons = base.GetButtons();
			buttons.Add(Page.OpenButton.Name);
			return buttons;
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public override string GetRegisterEditPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return String.Empty;
		}

		public override void ModifyAddPageParameters(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters) {
			queryStringParameters.Remove("SysModuleEditId");
			if (!queryStringParameters.ContainsKey("folderId")) {
				var allFoldersId = new Guid("09bacff2-34e0-df11-971b-001d60e938c6");
				queryStringParameters["folderId"] = Json.Serialize(allFoldersId.ToString());
			}
		}

		public override void LoadViewFilters(bool enabledFilters) {
			base.LoadViewFilters(enabledFilters);
			var dataSource = Page.DataSource as DataSource;
			DataSourceFilter systemFilter1 = dataSource.CreateFilterWithParameters(FilterComparisonType.Equal, "IsSystem", false);
			DataSourceFilter systemFilter2 = dataSource.CreateFilterWithParameters(FilterComparisonType.Equal, "SysWorkspace", UserConnection.Workspace.Id);
			
			DataSourceFilter systemFilter3 = dataSource.CreateFilterWithParameters(FilterComparisonType.Equal, "SysEntitySchemaU.SysWorkspace", UserConnection.Workspace.Id);
			DataSourceFilter systemFilter4 = dataSource.CreateFilterWithParameters(FilterComparisonType.IsNull, "SysEntitySchemaU.SysWorkspace");
			
			DataSourceFilterCollection filtersGroup1 = dataSource.CurrentStructure.CreateFiltersGroup("SysEntitySchemaUFilter", LogicalOperationStrict.Or);
			filtersGroup1.Add(systemFilter3);
			filtersGroup1.Add(systemFilter4);
			DataSourceFilter systemFilter5 = dataSource.CreateFilterWithParameters(FilterComparisonType.Equal, "SysGridPageSchemaU.SysWorkspace", UserConnection.Workspace.Id);
			DataSourceFilter systemFilter6 = dataSource.CreateFilterWithParameters(FilterComparisonType.IsNull, "SysGridPageSchemaU.SysWorkspace");
			
			DataSourceFilterCollection filtersGroup2 = dataSource.CurrentStructure.CreateFiltersGroup("SysGridPageSchemaUFilter", LogicalOperationStrict.Or);
			filtersGroup2.Add(systemFilter5);
			filtersGroup2.Add(systemFilter6);
			
			dataSource.CurrentStructure.Filters.Add(systemFilter1);
			dataSource.CurrentStructure.Filters.Add(systemFilter2);
			dataSource.CurrentStructure.Filters.Add(filtersGroup1);
			dataSource.CurrentStructure.Filters.Add(filtersGroup2);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessageChildPageLoadComplete")) {
							context.QueueTasks.Enqueue("StartMessageChildPageLoadComplete");
							ProcessQueue(context);
							return;
						}
						break;
					case "DataSourceLoadRowsResponseRegistered":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
							ProcessQueue(context);
							return;
						}
						break;
					case "ApplyFolderFilter":
							if (ActivatedEventElements.Contains("StartMessageChildApplyFolderFilter")) {
							context.QueueTasks.Enqueue("StartMessageChildApplyFolderFilter");
						}
						break;
					case "BasePrepareFilters":
							if (ActivatedEventElements.Contains("ChildStartMessageBasePrepareFilters")) {
							context.QueueTasks.Enqueue("ChildStartMessageBasePrepareFilters");
							ProcessQueue(context);
							return;
						}
						break;
					case "OpenButtonClick":
							if (ActivatedEventElements.Contains("OpenButtonClick")) {
							context.QueueTasks.Enqueue("OpenButtonClick");
						}
						break;
					case "OpenLookup":
							if (ActivatedEventElements.Contains("OpenLookup")) {
							context.QueueTasks.Enqueue("OpenLookup");
						}
						break;
					case "TreeGridDblClick":
							if (ActivatedEventElements.Contains("TreeGridDblClick2")) {
							context.QueueTasks.Enqueue("TreeGridDblClick2");
							ProcessQueue(context);
							return;
						}
						break;
					case "DataSourceActiveRowChanged":
							if (ActivatedEventElements.Contains("DataSourceActiveRowChangedChildStartMessage")) {
							context.QueueTasks.Enqueue("DataSourceActiveRowChangedChildStartMessage");
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
			if (!HasMapping("IsSelectedFolderRoot") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsSelectedFolderRoot", IsSelectedFolderRoot, false);
			}
			if (!HasMapping("OpenGridPage") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("OpenGridPage", OpenGridPage, false);
			}
			if (!HasMapping("CurrentLookupFolder") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CurrentLookupFolder", CurrentLookupFolder, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: LookupsGridPageEventsProcess

	/// <exclude/>
	public class LookupsGridPageEventsProcess : LookupsGridPageEventsProcess<Terrasoft.WebApp.LookupsGridPageSchemaUserControl>
	{

		public LookupsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LookupsGridPageSchemaUserControl

	/// <exclude/>
	public partial class LookupsGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button OpenButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("OpenButton", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			EditButton.AjaxEvents.Click.Event += EditButtonClick;
			OpenButton.AjaxEvents.Click.Event += OpenButtonClick;
			TreeGrid.AjaxEvents.DblClick.Event += TreeGridDblClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			EditButton.AjaxEvents.Click.Event -= EditButtonClick;
			OpenButton.AjaxEvents.Click.Event -= OpenButtonClick;
			TreeGrid.AjaxEvents.DblClick.Event -= TreeGridDblClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (LookupsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new LookupsGridPageEventsProcess(UserConnection);
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

		public virtual void EditButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("EditButtonClick");
		}

		public virtual void OpenButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("OpenButtonClick");
		}

		public virtual void TreeGridDblClick(object sender, EventArgs e) {
			object result = ThrowEvent("TreeGridDblClick");
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
			SchemaName = "LookupsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: LookupsGridPageEventsProcessSchema

	/// <exclude/>
	public class LookupsGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public LookupsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LookupsGridPageEventsProcessSchema(LookupsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LookupsGridPageEventsProcess";
			UId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273");
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

		protected virtual ProcessSchemaParameter CreateCurrentLookupFolderParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("17efb59a-e8c1-4fc1-af1f-b990e3717340"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"CurrentLookupFolder",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateOpenGridPageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("65a2ad59-0130-4d90-9d56-60a597e72efd"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"OpenGridPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsSelectedFolderRootParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fb143c90-852a-4379-be98-98830bfe0137"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"IsSelectedFolderRoot",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCurrentLookupFolderParameter());
			Parameters.Add(CreateOpenGridPageParameter());
			Parameters.Add(CreateIsSelectedFolderRootParameter());
		}

		protected virtual void InitializeUserTaskOpenPageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("fd8e58fe-7b89-452e-ab66-3a70f48e8065"),
				ContainerUId = new Guid("ab7dac87-cb06-4278-bd1e-3aeb121bfefe"),
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
				UId = new Guid("e2b8cb89-3fd6-4d53-8523-7b41d6957516"),
				ContainerUId = new Guid("ab7dac87-cb06-4278-bd1e-3aeb121bfefe"),
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
				UId = new Guid("63862313-7a54-4697-a6ac-ba7564fb4310"),
				ContainerUId = new Guid("ab7dac87-cb06-4278-bd1e-3aeb121bfefe"),
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
				UId = new Guid("b52bd46b-3da3-4ca3-8daa-4b41f1304d26"),
				ContainerUId = new Guid("ab7dac87-cb06-4278-bd1e-3aeb121bfefe"),
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
				UId = new Guid("210f36fa-e04f-4d76-993b-9fc1e0196ab9"),
				ContainerUId = new Guid("ab7dac87-cb06-4278-bd1e-3aeb121bfefe"),
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
				UId = new Guid("d8965f5e-9aa8-4936-979c-4fe32a1c0e9e"),
				ContainerUId = new Guid("ab7dac87-cb06-4278-bd1e-3aeb121bfefe"),
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
				UId = new Guid("ca172b82-6015-4941-8a53-7641461915c4"),
				ContainerUId = new Guid("ab7dac87-cb06-4278-bd1e-3aeb121bfefe"),
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
				UId = new Guid("65fcea3f-ed54-4a46-bcc7-aa29dcfa0e6b"),
				ContainerUId = new Guid("ab7dac87-cb06-4278-bd1e-3aeb121bfefe"),
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
				UId = new Guid("259211df-2118-4892-96a2-460c359dd4b2"),
				ContainerUId = new Guid("ab7dac87-cb06-4278-bd1e-3aeb121bfefe"),
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
				UId = new Guid("5a4189dc-fd33-44e6-be18-e214526671d9"),
				ContainerUId = new Guid("ab7dac87-cb06-4278-bd1e-3aeb121bfefe"),
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
				UId = new Guid("77d8fb92-a775-4c7d-8827-bba9d700da88"),
				ContainerUId = new Guid("ab7dac87-cb06-4278-bd1e-3aeb121bfefe"),
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
				UId = new Guid("c9287263-ccdb-4f83-9fee-3166c123b028"),
				ContainerUId = new Guid("ab7dac87-cb06-4278-bd1e-3aeb121bfefe"),
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

		protected virtual void InitializeOpenLookupUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("c7f598ca-b036-438d-9728-4f1e3a67fc6b"),
				ContainerUId = new Guid("8843e781-b673-43be-98a0-4f9b18a17a62"),
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
				UId = new Guid("c6a7916e-e02c-423c-b080-4542ad33cc8b"),
				ContainerUId = new Guid("8843e781-b673-43be-98a0-4f9b18a17a62"),
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
				UId = new Guid("31ebc5b5-6a68-47a2-98e3-d5a3aaca8fa5"),
				ContainerUId = new Guid("8843e781-b673-43be-98a0-4f9b18a17a62"),
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
				UId = new Guid("7b652739-7354-4161-8988-07975d5d5563"),
				ContainerUId = new Guid("8843e781-b673-43be-98a0-4f9b18a17a62"),
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

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet490 = CreateLaneSet490LaneSet();
			LaneSets.Add(schemaLaneSet490);
			ProcessSchemaLane schemaLane1610 = CreateLane1610Lane();
			schemaLaneSet490.Lanes.Add(schemaLane1610);
			ProcessSchemaEventSubProcess subprocesschildpageloadcomplete = CreateSubProcessChildPageLoadCompleteEventSubProcess();
			FlowElements.Add(subprocesschildpageloadcomplete);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess subprocesschildapplyfolderfilter = CreateSubProcessChildApplyFolderFilterEventSubProcess();
			FlowElements.Add(subprocesschildapplyfolderfilter);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess opengridsubprocess = CreateOpenGridSubProcessEventSubProcess();
			FlowElements.Add(opengridsubprocess);
			ProcessSchemaEventSubProcess subprocess9 = CreateSubProcess9EventSubProcess();
			FlowElements.Add(subprocess9);
			ProcessSchemaEventSubProcess subprocess10 = CreateSubProcess10EventSubProcess();
			FlowElements.Add(subprocess10);
			ProcessSchemaEventSubProcess datasourceactiverowchangedeventchildsubprocess = CreateDataSourceActiveRowChangedEventChildSubProcessEventSubProcess();
			FlowElements.Add(datasourceactiverowchangedeventchildsubprocess);
			ProcessSchemaStartMessageEvent startmessagechildpageloadcomplete = CreateStartMessageChildPageLoadCompleteStartMessageEvent();
			subprocesschildpageloadcomplete.FlowElements.Add(startmessagechildpageloadcomplete);
			ProcessSchemaScriptTask scriptchildpageloadcomplete = CreateScriptChildPageLoadCompleteScriptTask();
			subprocesschildpageloadcomplete.FlowElements.Add(scriptchildpageloadcomplete);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowbasepageloadcomplete = CreateIntermediateThrowBasePageLoadCompleteIntermediateThrowMessageEvent();
			subprocesschildpageloadcomplete.FlowElements.Add(intermediatethrowbasepageloadcomplete);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask scripttask3 = CreateScriptTask3ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask3);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask scriptchildapplyfolderfilter = CreateScriptChildApplyFolderFilterScriptTask();
			subprocesschildapplyfolderfilter.FlowElements.Add(scriptchildapplyfolderfilter);
			ProcessSchemaStartMessageEvent startmessagechildapplyfolderfilter = CreateStartMessageChildApplyFolderFilterStartMessageEvent();
			subprocesschildapplyfolderfilter.FlowElements.Add(startmessagechildapplyfolderfilter);
			ProcessSchemaStartMessageEvent childstartmessagebasepreparefilters = CreateChildStartMessageBasePrepareFiltersStartMessageEvent();
			eventsubprocess8.FlowElements.Add(childstartmessagebasepreparefilters);
			ProcessSchemaIntermediateThrowMessageEvent throwmessagebasepreparefilters = CreateThrowMessageBasePrepareFiltersIntermediateThrowMessageEvent();
			eventsubprocess8.FlowElements.Add(throwmessagebasepreparefilters);
			ProcessSchemaScriptTask childbasepreparefiltersscripttask = CreateChildBasePrepareFiltersScriptTaskScriptTask();
			eventsubprocess8.FlowElements.Add(childbasepreparefiltersscripttask);
			ProcessSchemaStartMessageEvent openbuttonclick = CreateOpenButtonClickStartMessageEvent();
			opengridsubprocess.FlowElements.Add(openbuttonclick);
			ProcessSchemaScriptTask scriptopenbuttonclick = CreateScriptOpenButtonClickScriptTask();
			opengridsubprocess.FlowElements.Add(scriptopenbuttonclick);
			ProcessSchemaUserTask usertaskopenpage = CreateUserTaskOpenPageUserTask();
			opengridsubprocess.FlowElements.Add(usertaskopenpage);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			opengridsubprocess.FlowElements.Add(scripttask1);
			ProcessSchemaStartMessageEvent openlookup = CreateOpenLookupStartMessageEvent();
			subprocess9.FlowElements.Add(openlookup);
			ProcessSchemaScriptTask scriptprepareopenlookup = CreateScriptPrepareOpenLookupScriptTask();
			subprocess9.FlowElements.Add(scriptprepareopenlookup);
			ProcessSchemaUserTask openlookupusertask = CreateOpenLookupUserTaskUserTask();
			subprocess9.FlowElements.Add(openlookupusertask);
			ProcessSchemaStartMessageEvent treegriddblclick2 = CreateTreeGridDblClick2StartMessageEvent();
			subprocess10.FlowElements.Add(treegriddblclick2);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			subprocess10.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaStartMessageEvent datasourceactiverowchangedchildstartmessage = CreateDataSourceActiveRowChangedChildStartMessageStartMessageEvent();
			datasourceactiverowchangedeventchildsubprocess.FlowElements.Add(datasourceactiverowchangedchildstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent datasourceactiverowchangedchildintermediatethrowmessageevent = CreateDataSourceActiveRowChangedChildIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			datasourceactiverowchangedeventchildsubprocess.FlowElements.Add(datasourceactiverowchangedchildintermediatethrowmessageevent);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			datasourceactiverowchangedeventchildsubprocess.FlowElements.Add(scripttask2);
			FlowElements.Add(CreateSequenceFlow9496SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9506SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9507SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9517SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9518SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9519SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9522SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9523ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow9524SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9529SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9533SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9534SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9535SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9496SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9496",
				UId = new Guid("974b6fb9-a5fa-4b30-b3f0-3207ab35b9bc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dd63c28d-7b4e-4eeb-bf48-a6adc885ea62"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("21816672-d825-486f-838d-a31f90c3341e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9506SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9506",
				UId = new Guid("b7c2f9a8-5e90-4cf8-954c-6f7c42ae9afc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				CurveCenterPosition = new Point(342, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("614e9aaf-0d00-47de-aafa-fb9a00bf3168"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dbf56a73-ef1f-4f7f-80f0-5f2a894fdf40"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9507SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9507",
				UId = new Guid("648d5925-8670-4d02-a6a3-083c19fdf1f3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				CurveCenterPosition = new Point(442, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dbf56a73-ef1f-4f7f-80f0-5f2a894fdf40"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8843e781-b673-43be-98a0-4f9b18a17a62"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9517SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9517",
				UId = new Guid("48851d5f-6c5c-46e4-a734-60eca5c56740"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				CurveCenterPosition = new Point(436, 1806),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("258f6696-9fd8-4514-9965-a44e49cdef8d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("25437241-95bd-4214-b347-e8e158bccd0d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9518SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9518",
				UId = new Guid("2f974923-e7a4-4de5-bfab-2e8d5992a55e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				CurveCenterPosition = new Point(187, 1602),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("69933426-e9be-4952-ad9d-b80978252bd1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c39cdb4b-e946-430d-aa26-0867dfeb2318"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9519SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9519",
				UId = new Guid("758f9b5c-d1dc-4e1f-b893-5522bfd783c5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				CurveCenterPosition = new Point(359, 1612),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c39cdb4b-e946-430d-aa26-0867dfeb2318"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("028dc97b-1833-4460-8f90-eadef477169a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9522SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9522",
				UId = new Guid("b5b31129-e34e-4ff7-86fd-39bab55bb96b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				CurveCenterPosition = new Point(161, 468),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7a70825b-fcb6-457a-9b10-b2215d4503ce"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1d2df63f-7e2c-4dca-9dcb-bc5428e93dfb"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateSequenceFlow9523ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "SequenceFlow9523",
				UId = new Guid("e88917f4-baf1-4db9-a9a2-8d4daa954810"),
				ConditionExpression = @"OpenGridPage",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				CurveCenterPosition = new Point(274, 616),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("21816672-d825-486f-838d-a31f90c3341e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ab7dac87-cb06-4278-bd1e-3aeb121bfefe"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9524SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow9524",
				UId = new Guid("d8c27b93-fd8b-44fd-adc8-ef757bc3d938"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				CurveCenterPosition = new Point(203, 670),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("21816672-d825-486f-838d-a31f90c3341e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("58d429a8-3d39-4549-ab21-c5d68fc8549e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9529SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9529",
				UId = new Guid("1e182b22-d2f9-40fe-a5ba-302866121122"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				CurveCenterPosition = new Point(138, 576),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8be81003-8b0b-45a0-8ea7-7c6e0780b809"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c8d3865c-ec77-4b84-bac3-a50a1ae19b05"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9533SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9533",
				UId = new Guid("7159e3b2-7a64-43f6-a704-5277a0f2d310"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				CurveCenterPosition = new Point(138, 576),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ae6614ea-ae79-4de9-8759-e86975d7d939"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8be81003-8b0b-45a0-8ea7-7c6e0780b809"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9534SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9534",
				UId = new Guid("f5523934-ab1e-4f25-b481-b64a067dff7d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				CurveCenterPosition = new Point(600, 86),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("07acc873-7c63-468e-8067-df765decf009"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4c133949-de31-4122-abc3-e0823c6f9130"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9535SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9535",
				UId = new Guid("06b423fc-9209-4a69-8856-a0b6a50bfb35"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				CurveCenterPosition = new Point(694, 88),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4c133949-de31-4122-abc3-e0823c6f9130"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ee3b701f-8831-4ecc-9839-0e14ba288098"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("abcfedcb-4eb8-4117-b988-36ec3cdc154a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				CurveCenterPosition = new Point(432, 268),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2eaa6c66-d0db-4ec2-a62c-da05d9ac783a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0b4c66a2-72af-4dd1-90f0-ba9f4eb2eb0d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("34f1b2b2-18a5-4fe5-b4b0-1e230785cc1a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				CurveCenterPosition = new Point(522, 266),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0b4c66a2-72af-4dd1-90f0-ba9f4eb2eb0d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3b933db1-5465-4d3a-9b2b-9184bcbf8816"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet490LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet490 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("dc1fa9f0-4245-43dd-bffd-792a7e51bbfe"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"LaneSet490",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1112, 801),
				UseBackgroundMode = false
			};
			return schemaLaneSet490;
		}

		protected virtual ProcessSchemaLane CreateLane1610Lane() {
			ProcessSchemaLane schemaLane1610 = new ProcessSchemaLane(this) {
				UId = new Guid("a09d732e-3b3e-4af0-98c7-4cf90bf4a780"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("dc1fa9f0-4245-43dd-bffd-792a7e51bbfe"),
				CreatedInOwnerSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"Lane1610",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1083, 177),
				UseBackgroundMode = false
			};
			return schemaLane1610;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessChildPageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessChildPageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("18e3210a-dc05-4406-8a30-ef242b7680ff"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a09d732e-3b3e-4af0-98c7-4cf90bf4a780"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"SubProcessChildPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(406, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessChildPageLoadComplete;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChildPageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("69933426-e9be-4952-ad9d-b80978252bd1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("18e3210a-dc05-4406-8a30-ef242b7680ff"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"StartMessageChildPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildPageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c39cdb4b-e946-430d-aa26-0867dfeb2318"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("18e3210a-dc05-4406-8a30-ef242b7680ff"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"ScriptChildPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,141,193,10,130,64,20,69,215,205,87,60,92,233,98,68,100,44,69,92,138,180,40,10,170,189,206,123,202,144,141,49,204,32,145,253,123,22,180,176,237,57,156,123,85,11,126,137,202,30,234,142,206,91,132,162,128,202,41,12,203,219,221,62,96,154,224,79,106,215,247,1,60,217,106,193,65,211,248,237,124,175,69,81,199,105,148,114,145,136,140,139,166,89,243,44,206,36,71,148,155,136,100,44,147,90,122,65,206,94,236,83,135,39,67,84,153,249,240,232,148,188,94,20,141,187,1,105,94,252,137,5,15,247,131,166,156,25,178,206,104,176,198,81,254,6,23,23,59,210,193,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowBasePageLoadCompleteIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("028dc97b-1833-4460-8f90-eadef477169a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("18e3210a-dc05-4406-8a30-ef242b7680ff"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"IntermediateThrowBasePageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(323, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("84e8d76d-7228-4e6f-935a-104fa1754f04"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a09d732e-3b3e-4af0-98c7-4cf90bf4a780"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(463, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(314, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("07acc873-7c63-468e-8067-df765decf009"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("84e8d76d-7228-4e6f-935a-104fa1754f04"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DataSourceLoadRowsResponseRegistered",
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"StartMessage2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ee3b701f-8831-4ecc-9839-0e14ba288098"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("84e8d76d-7228-4e6f-935a-104fa1754f04"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"ScriptTask3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(203, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,49,11,194,48,16,133,103,243,43,130,83,187,68,247,162,160,237,34,56,136,165,46,226,112,182,103,13,182,57,185,36,74,17,255,187,177,131,10,58,56,29,119,239,221,247,222,104,148,119,214,97,171,50,13,181,33,235,116,105,85,134,123,95,215,200,106,206,8,167,40,78,132,184,0,203,10,28,228,228,185,68,57,145,43,168,81,101,175,75,34,244,65,70,111,135,202,177,193,210,97,181,8,240,21,235,22,184,75,169,241,173,217,64,227,209,170,148,188,113,114,42,199,177,188,137,65,79,43,44,114,74,198,132,63,77,38,16,172,13,243,153,177,29,46,137,78,254,156,151,71,108,161,208,213,112,23,42,124,166,245,130,42,22,85,242,55,236,7,102,22,204,23,92,211,245,187,113,34,238,130,209,121,54,210,113,88,31,84,163,123,10,57,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("4c133949-de31-4122-abc3-e0823c6f9130"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("84e8d76d-7228-4e6f-935a-104fa1754f04"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DataSourceLoadRowsResponseRegistered",
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(126, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessChildApplyFolderFilterEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessChildApplyFolderFilter = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("84bfed56-e7b5-49da-85b3-8ff85b925ae2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a09d732e-3b3e-4af0-98c7-4cf90bf4a780"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"SubProcessChildApplyFolderFilter",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 189),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(259, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessChildApplyFolderFilter;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildApplyFolderFilterScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1d2df63f-7e2c-4dca-9dcb-bc5428e93dfb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("84bfed56-e7b5-49da-85b3-8ff85b925ae2"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"ScriptChildApplyFolderFilter",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 39),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,193,142,218,48,16,61,39,95,97,114,74,36,100,113,143,168,212,178,1,173,132,42,180,176,237,161,234,193,77,6,98,173,99,167,19,27,20,85,252,123,199,9,133,44,208,21,199,204,188,153,121,243,230,197,123,129,76,201,198,130,6,92,137,29,172,208,228,208,52,108,202,94,27,192,153,209,26,114,43,141,230,207,167,76,166,119,82,3,95,128,61,5,190,180,175,207,69,188,188,237,65,225,36,13,247,52,160,16,86,172,141,195,28,168,175,71,240,167,115,164,71,228,14,17,180,93,91,116,185,117,232,113,151,34,62,187,202,166,225,47,99,20,203,21,8,156,75,101,1,63,198,243,30,212,240,153,113,218,178,79,108,146,134,114,27,15,234,147,63,97,224,121,108,187,175,172,144,246,177,142,63,38,63,211,48,216,26,4,145,151,241,165,3,147,250,145,114,63,54,32,38,125,17,255,42,42,218,124,202,162,249,153,70,148,16,34,120,71,171,255,160,177,199,48,120,104,105,191,102,76,167,120,8,253,185,40,226,203,56,170,58,122,169,78,240,165,49,111,174,158,27,85,0,142,166,218,41,229,55,160,124,188,112,178,72,238,160,216,104,234,83,60,171,106,219,38,204,239,123,125,235,119,163,135,20,73,84,11,125,242,187,180,229,74,32,233,227,145,113,31,156,153,170,22,40,27,163,55,109,13,60,251,237,132,26,123,185,130,32,90,183,77,79,32,26,179,59,180,146,164,211,239,24,118,110,220,32,192,2,137,229,89,170,1,141,165,17,197,139,57,52,62,236,87,57,233,63,51,202,85,250,155,80,206,155,245,178,99,231,172,65,185,47,61,249,110,52,101,147,78,2,239,147,26,101,37,176,237,219,244,135,31,58,102,157,151,80,9,190,26,162,58,127,120,187,221,33,160,225,208,145,184,30,77,6,245,255,234,0,28,223,76,78,248,198,208,53,164,222,197,73,119,240,59,15,2,95,119,63,124,13,104,219,190,77,52,191,166,65,82,223,80,163,126,255,158,134,77,137,230,144,237,233,18,255,121,45,198,44,122,129,45,66,83,62,129,21,82,53,17,85,35,144,71,52,35,179,64,250,23,241,17,26,2,173,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChildApplyFolderFilterStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7a70825b-fcb6-457a-9b10-b2215d4503ce"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("84bfed56-e7b5-49da-85b3-8ff85b925ae2"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ApplyFolderFilter",
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"StartMessageChildApplyFolderFilter",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 54),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3ab2871c-bd54-4080-9686-a3b2201bd55d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a09d732e-3b3e-4af0-98c7-4cf90bf4a780"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"EventSubProcess8",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(301, 189),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(343, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildStartMessageBasePrepareFiltersStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2eaa6c66-d0db-4ec2-a62c-da05d9ac783a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ab2871c-bd54-4080-9686-a3b2201bd55d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BasePrepareFilters",
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"ChildStartMessageBasePrepareFilters",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowMessageBasePrepareFiltersIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("0b4c66a2-72af-4dd1-90f0-ba9f4eb2eb0d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ab2871c-bd54-4080-9686-a3b2201bd55d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"BasePrepareFilters",
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"ThrowMessageBasePrepareFilters",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChildBasePrepareFiltersScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3b933db1-5465-4d3a-9b2b-9184bcbf8816"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ab2871c-bd54-4080-9686-a3b2201bd55d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"ChildBasePrepareFiltersScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(197, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,193,78,195,48,12,134,207,84,234,59,132,158,90,169,202,11,76,59,64,97,8,9,177,137,130,118,182,82,111,139,72,147,226,36,149,42,196,187,147,104,93,219,9,174,246,231,207,191,221,3,177,6,28,212,198,147,64,182,102,59,56,34,127,152,42,171,52,233,3,98,29,121,225,60,69,98,198,121,229,137,80,187,250,210,29,233,131,84,14,201,190,66,27,249,108,111,232,211,118,32,112,115,174,103,215,216,181,114,35,117,51,114,79,100,124,119,63,68,77,190,80,22,97,92,30,216,165,196,110,215,76,123,165,10,246,157,38,55,83,80,62,74,248,27,182,166,159,4,113,248,39,77,230,213,243,64,69,8,14,151,187,151,91,75,246,98,142,82,128,218,118,72,224,164,209,225,106,41,28,223,82,116,142,36,191,107,154,252,127,229,94,186,211,14,40,168,34,152,47,78,174,197,9,91,40,217,153,171,76,219,1,73,107,244,251,208,33,127,252,242,160,202,172,30,236,244,198,172,100,31,54,130,90,163,136,73,248,212,226,207,77,17,227,252,125,67,12,182,248,1,97,232,106,22,48,92,253,2,27,215,93,97,4,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOpenGridSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOpenGridSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("87b3dd4c-7645-4969-b445-8537b26a2995"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a09d732e-3b3e-4af0-98c7-4cf90bf4a780"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"OpenGridSubProcess",
				Position = new Point(35, 371),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(342, 230),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOpenGridSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOpenButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("dd63c28d-7b4e-4eeb-bf48-a6adc885ea62"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("87b3dd4c-7645-4969-b445-8537b26a2995"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OpenButtonClick",
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"OpenButtonClick",
				Position = new Point(15, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptOpenButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("21816672-d825-486f-838d-a31f90c3341e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("87b3dd4c-7645-4969-b445-8537b26a2995"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"ScriptOpenButtonClick",
				Position = new Point(99, 32),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,81,77,139,194,48,16,61,87,240,63,12,57,181,32,197,123,215,189,236,138,200,126,9,213,189,136,135,208,140,26,172,137,76,18,165,136,255,125,147,70,23,93,186,151,180,201,204,123,111,222,155,137,147,2,54,36,69,89,109,113,207,167,2,70,48,241,111,249,120,127,176,77,209,239,25,75,82,109,192,81,237,43,101,123,249,173,29,57,129,193,26,43,139,226,83,11,52,190,101,198,55,152,207,9,113,226,73,243,242,190,234,17,114,13,233,3,34,127,209,78,89,24,141,96,152,193,185,223,75,8,173,35,5,150,28,250,254,75,7,100,57,92,229,223,188,118,45,88,89,46,149,121,195,38,101,101,99,130,102,24,32,154,89,76,5,203,178,64,250,117,64,117,171,249,25,175,228,201,31,223,10,79,173,247,255,228,150,221,18,171,124,174,99,48,105,150,21,137,231,93,24,164,57,55,187,32,219,230,17,126,144,166,202,88,174,42,108,197,110,23,207,80,116,65,194,177,104,59,239,167,44,160,147,63,28,51,78,124,143,22,201,92,173,188,202,202,74,173,56,53,79,113,137,3,136,223,231,52,70,157,156,129,161,144,246,195,219,100,3,96,33,22,6,62,242,228,18,162,7,172,13,66,71,124,107,238,11,97,232,184,235,45,233,211,248,136,202,166,44,52,190,107,189,115,7,150,197,237,221,175,243,7,172,94,90,69,108,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateUserTaskOpenPageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ab7dac87-cb06-4278-bd1e-3aeb121bfefe"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("87b3dd4c-7645-4969-b445-8537b26a2995"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"UserTaskOpenPage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(246, 32),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserTaskOpenPageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("58d429a8-3d39-4549-ab21-c5d68fc8549e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("87b3dd4c-7645-4969-b445-8537b26a2995"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 144),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b8c21877-b0f8-4056-8eba-e1d9287dc784"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a09d732e-3b3e-4af0-98c7-4cf90bf4a780"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"SubProcess9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(386, 372),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(385, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOpenLookupStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("614e9aaf-0d00-47de-aafa-fb9a00bf3168"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b8c21877-b0f8-4056-8eba-e1d9287dc784"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OpenLookup",
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"OpenLookup",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPrepareOpenLookupScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("dbf56a73-ef1f-4f7f-80f0-5f2a894fdf40"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b8c21877-b0f8-4056-8eba-e1d9287dc784"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"ScriptPrepareOpenLookup",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(77, 38),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,80,77,79,194,48,24,62,75,194,127,104,118,218,34,105,188,131,36,4,212,44,126,145,108,211,131,225,80,215,23,172,140,118,190,111,167,217,191,183,221,20,6,17,245,210,180,233,243,77,22,149,94,49,165,201,10,157,67,44,217,57,11,195,20,16,5,153,165,229,89,204,31,225,121,106,180,69,83,16,159,139,21,68,254,224,19,42,155,7,143,183,84,158,154,164,145,11,163,97,191,119,95,130,190,49,102,93,149,25,1,166,130,214,124,142,38,7,162,107,168,157,75,199,242,148,53,146,254,240,78,66,105,64,158,105,245,86,65,60,115,82,239,2,25,65,1,185,5,121,103,36,144,163,55,140,20,1,174,80,73,158,116,127,29,131,218,90,148,191,192,70,100,77,171,61,129,167,179,5,127,16,69,229,110,65,82,211,133,182,202,214,201,55,58,88,116,171,48,246,115,25,23,96,46,80,108,192,2,250,68,26,62,216,76,229,86,25,45,176,102,163,54,195,128,153,231,87,103,60,110,70,241,77,202,67,98,191,23,254,194,139,216,159,230,78,120,95,148,79,164,12,131,109,251,96,176,91,34,58,2,6,169,236,173,155,198,97,45,86,224,97,83,83,248,201,92,174,209,46,223,97,188,49,91,170,162,179,192,255,72,225,177,24,109,207,203,86,210,101,249,18,143,134,39,253,30,130,173,80,55,241,28,251,19,1,204,133,165,186,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenLookupUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("8843e781-b673-43be-98a0-4f9b18a17a62"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b8c21877-b0f8-4056-8eba-e1d9287dc784"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"OpenLookupUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(182, 38),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenLookupUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6c214867-2f8e-4123-823e-5b6e98b19e83"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a09d732e-3b3e-4af0-98c7-4cf90bf4a780"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"SubProcess10",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(561, 633),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(189, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateTreeGridDblClick2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("258f6696-9fd8-4514-9965-a44e49cdef8d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c214867-2f8e-4123-823e-5b6e98b19e83"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"TreeGridDblClick",
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"TreeGridDblClick2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("25437241-95bd-4214-b347-e8e158bccd0d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c214867-2f8e-4123-823e-5b6e98b19e83"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OpenButtonClick",
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(105, 67),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateDataSourceActiveRowChangedEventChildSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaDataSourceActiveRowChangedEventChildSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1b4b8222-9d2b-4f19-b666-312eaeaacd7d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a09d732e-3b3e-4af0-98c7-4cf90bf4a780"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"DataSourceActiveRowChangedEventChildSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 627),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(511, 156),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaDataSourceActiveRowChangedEventChildSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceActiveRowChangedChildStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ae6614ea-ae79-4de9-8759-e86975d7d939"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1b4b8222-9d2b-4f19-b666-312eaeaacd7d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DataSourceActiveRowChanged",
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"DataSourceActiveRowChangedChildStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(57, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateDataSourceActiveRowChangedChildIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("c8d3865c-ec77-4b84-bac3-a50a1ae19b05"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1b4b8222-9d2b-4f19-b666-312eaeaacd7d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DataSourceActiveRowChanged",
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"DataSourceActiveRowChangedChildIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(281, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8be81003-8b0b-45a0-8ea7-7c6e0780b809"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1b4b8222-9d2b-4f19-b666-312eaeaacd7d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"),
				Name = @"ScriptTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(155, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,61,11,194,48,16,134,103,243,43,66,167,118,201,31,40,14,82,139,8,14,197,82,23,113,56,154,83,131,77,82,175,73,165,136,255,221,248,129,58,136,56,29,119,199,243,190,79,15,196,37,56,40,173,167,26,249,152,23,176,67,49,125,93,82,166,182,60,158,121,37,69,174,91,55,136,252,232,161,233,226,55,35,38,181,83,61,46,237,169,32,165,129,134,204,54,94,155,21,52,30,147,132,159,217,136,208,121,50,124,27,184,144,119,97,247,138,170,67,202,172,49,24,104,107,68,137,93,23,230,173,120,29,45,172,61,248,182,172,247,168,161,82,50,218,4,175,143,194,199,67,84,115,153,254,155,245,37,229,135,118,202,158,202,142,194,114,5,120,146,169,38,35,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
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

		protected override SchemaMethod CreateGetButtonsMethod() {
			SchemaMethod method = base.CreateGetButtonsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,42,45,41,201,207,43,86,176,85,72,74,44,78,213,115,79,45,113,130,136,104,104,90,115,65,37,245,28,83,82,52,2,18,211,83,245,252,11,82,243,32,242,122,126,137,185,169,64,37,69,169,37,165,69,121,48,99,172,1,66,44,140,90,83,0,0,0 };
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
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,46,41,202,204,75,215,115,205,45,40,169,180,6,0,123,132,81,183,20,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateModifyAddPageParametersMethod() {
			SchemaMethod method = base.CreateModifyAddPageParametersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,205,189,10,194,48,24,133,225,217,94,69,204,148,14,41,137,138,90,196,73,84,170,8,98,221,196,33,154,47,18,72,19,154,180,74,21,239,221,191,65,7,215,3,239,121,202,26,124,147,87,94,219,211,90,120,81,64,5,62,36,27,40,220,25,8,206,155,176,114,178,54,48,149,186,202,36,142,71,145,86,136,180,203,191,213,196,217,74,104,27,150,208,16,172,156,145,224,95,77,140,110,81,235,44,60,18,198,204,222,107,200,36,26,35,11,23,52,175,181,36,152,165,7,113,84,170,67,187,61,96,84,42,206,105,58,224,7,202,24,151,125,6,105,119,120,236,191,236,214,95,119,247,181,246,207,219,69,112,54,201,193,107,97,244,21,200,47,154,108,221,39,38,241,243,237,254,0,106,139,31,131,252,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateLoadViewFiltersMethod() {
			SchemaMethod method = base.CreateLoadViewFiltersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,147,65,107,2,49,16,133,239,133,254,135,224,73,65,2,90,245,82,122,40,214,138,32,85,216,90,207,227,238,168,161,217,205,118,146,180,248,239,155,53,210,101,85,220,174,221,30,39,153,55,239,75,242,178,2,141,124,170,32,122,19,248,245,44,164,65,210,77,76,96,37,49,58,148,173,251,219,155,79,32,22,129,129,64,89,10,145,61,176,57,108,144,63,229,43,160,89,94,57,65,94,248,41,76,239,180,193,216,23,29,55,32,159,198,135,132,96,14,125,75,97,182,115,32,136,113,79,226,23,135,42,78,129,132,86,201,235,46,69,62,250,176,32,219,172,49,209,193,126,104,163,205,214,32,53,182,202,124,187,245,248,58,215,165,162,119,157,66,136,206,123,161,179,206,36,193,208,8,149,240,159,45,62,137,50,162,18,166,187,218,152,70,137,17,102,23,132,91,140,97,193,171,65,94,68,236,253,13,113,162,95,172,44,103,60,127,87,67,37,165,103,102,107,31,199,49,41,155,30,39,200,18,97,98,2,67,54,52,150,138,140,94,209,60,177,247,187,238,110,166,106,35,66,144,179,20,9,50,39,55,70,132,134,207,40,67,42,184,242,199,40,106,22,94,175,188,165,87,122,191,253,218,34,48,38,17,101,63,243,31,66,48,168,47,4,23,41,43,197,224,248,67,255,50,6,71,0,213,131,208,61,121,229,126,121,203,192,31,237,18,239,129,244,68,218,201,164,215,8,187,85,132,133,28,95,43,116,142,223,189,239,175,117,84,6,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LookupsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("19f9b211-e9ed-4655-ad94-6193e8c93273"));
		}

		#endregion

	}

	#endregion

}

