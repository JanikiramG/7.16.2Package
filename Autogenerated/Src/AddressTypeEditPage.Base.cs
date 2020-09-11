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

	#region Class: AddressTypeEditPageSchema

	/// <exclude/>
	public class AddressTypeEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return _controlLayout2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _forContactEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox ForContactEdit {
			get {
				return _forContactEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout3;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return _controlLayout3;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _forAccountEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox ForAccountEdit {
			get {
				return _forAccountEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public AddressTypeEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AddressTypeEditPageSchema(AddressTypeEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("10c3f365-200c-48f8-868c-0265c564583f");
			NameEdit.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("529b1481-50ff-4b67-850b-ba79ab4c98bb");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
			RealUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
			Name = "AddressTypeEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAddressTypeEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(2, CreateControlLayout2());
			ControlLayout2.InsertItem(0, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateForContactEdit());
			ControlLayout2.InsertItem(1, CreateControlLayout3());
			ControlLayout3.InsertItem(0, CreateForAccountEdit());
			MainControlLayout.MoveItem(3, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateAddressTypeEditPageEventsProcessSchema() {
			var schema = new AddressTypeEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateForContactEdit() {
			_forContactEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_forContactEdit.UId = new Guid("835427e5-d37f-45e5-8844-7060065fc6c7");
			_forContactEdit.Name = "ForContactEdit";
			_forContactEdit.CreatedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
			_forContactEdit.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
			_forContactEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_forContactEdit.Tag = "";
			_forContactEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_forContactEdit.AlignedByCaption = false;
			_forContactEdit.DataSource = "DataSource";
			_forContactEdit.ColumnUId = new Guid("9f31148b-0976-4135-b165-9e3e6ab63999");
			return _forContactEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("e054ac11-8685-4222-a930-4d49bdb8f906");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
			_controlLayout1.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout1.FitHeightByContent = true;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateForAccountEdit() {
			_forAccountEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_forAccountEdit.UId = new Guid("8866d35e-5449-4a1c-899d-7461896e00ec");
			_forAccountEdit.Name = "ForAccountEdit";
			_forAccountEdit.CreatedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
			_forAccountEdit.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
			_forAccountEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_forAccountEdit.Tag = "";
			_forAccountEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_forAccountEdit.AlignedByCaption = false;
			_forAccountEdit.DataSource = "DataSource";
			_forAccountEdit.ColumnUId = new Guid("1738d4dc-2439-456e-a0d3-247bb338521b");
			return _forAccountEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout3() {
			_controlLayout3 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout3.UId = new Guid("52b85fbb-78b9-4746-b6f4-0e44b48ebd11");
			_controlLayout3.Name = "ControlLayout3";
			_controlLayout3.CreatedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
			_controlLayout3.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
			_controlLayout3.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout3.Tag = "";
			_controlLayout3.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout3.FitHeightByContent = true;
			_controlLayout3.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout3.StartNewAlignGroup = false;
			_controlLayout3.Image = new ControlImage {};
			_controlLayout3.Edges = "";
			return _controlLayout3;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout2() {
			_controlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout2.UId = new Guid("af2c8a94-5a44-4cb4-88c5-a992afd99c45");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
			_controlLayout2.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
			_controlLayout2.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout2.Tag = "";
			_controlLayout2.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout2.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout2.FitHeightByContent = true;
			_controlLayout2.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout2.StartNewAlignGroup = false;
			_controlLayout2.Image = new ControlImage {};
			_controlLayout2.Edges = "";
			return _controlLayout2;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("50837bfc-43ff-466b-94bb-de0847eecd1b");
			DataSource.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("a9471438-866c-4443-aa13-97ed8a78bbe0");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
				column.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("10c3f365-200c-48f8-868c-0265c564583f");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
				column.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("4b46d28a-6bd8-4f55-990a-79bcd2d782d3");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
				column.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("987efac5-8a90-4c00-abb1-db2525e70223");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
				column.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("895d23c4-a428-4860-a4f9-a53f057360aa");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
				column.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("0a664d6a-b2ad-4a66-865e-c06842547999");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
				column.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("529b1481-50ff-4b67-850b-ba79ab4c98bb");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
				column.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("7421096a-1fe8-477b-b718-8d66554c0f97");
			if (column != null) {
				column.UId = new Guid("9f31148b-0976-4135-b165-9e3e6ab63999");
				column.Name = @"ForContact";
				column.CreatedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
				column.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4c02f622-12ca-4649-a1bf-17cf7a94b168");
			if (column != null) {
				column.UId = new Guid("1738d4dc-2439-456e-a0d3-247bb338521b");
				column.Name = @"ForAccount";
				column.CreatedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
				column.ModifiedInSchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
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
			return new AddressTypeEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new AddressTypeEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f796c576-6be9-4f9d-8145-5e9e375be503"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AddressTypeEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AddressTypeEditPageEventsProcess

	/// <exclude/>
	public class AddressTypeEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AddressTypeEditPageSchemaUserControl
	{

		public AddressTypeEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AddressTypeEditPageEventsProcess";
			SchemaUId = new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f796c576-6be9-4f9d-8145-5e9e375be503");
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

	#region Class: AddressTypeEditPageEventsProcess

	/// <exclude/>
	public class AddressTypeEditPageEventsProcess : AddressTypeEditPageEventsProcess<Terrasoft.WebApp.AddressTypeEditPageSchemaUserControl>
	{

		public AddressTypeEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AddressTypeEditPageSchemaUserControl

	/// <exclude/>
	public partial class AddressTypeEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox ForContactEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("ForContactEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout3", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox ForAccountEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("ForAccountEdit", true);
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
			var process = (AddressTypeEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AddressTypeEditPageEventsProcess(UserConnection);
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
			SchemaName = "AddressTypeEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: AddressTypeEditPageEventsProcessSchema

	/// <exclude/>
	public class AddressTypeEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public AddressTypeEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AddressTypeEditPageEventsProcessSchema(AddressTypeEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AddressTypeEditPageEventsProcess";
			UId = new Guid("339b7e34-ad2d-49b5-8ac2-21ee5eda3286");
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
			return new AddressTypeEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("339b7e34-ad2d-49b5-8ac2-21ee5eda3286"));
		}

		#endregion

	}

	#endregion

}

