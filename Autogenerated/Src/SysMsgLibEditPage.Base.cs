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

	#region Class: SysMsgLibEditPageSchema

	/// <exclude/>
	public class SysMsgLibEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TextEdit _fullClassNameEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit FullClassNameEdit {
			get {
				return _fullClassNameEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _codeEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit CodeEdit {
			get {
				return _codeEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _setupPageSchemaNameEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit SetupPageSchemaNameEdit {
			get {
				return _setupPageSchemaNameEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _ctiProviderNameEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit CtiProviderNameEdit {
			get {
				return _ctiProviderNameEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _licOperationsEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit LicOperationsEdit {
			get {
				return _licOperationsEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public SysMsgLibEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysMsgLibEditPageSchema(SysMsgLibEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("96d66182-db1c-47dd-9dec-a6a467e0ffca");
			NameEdit.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("f1923fd6-997a-4d16-9a1c-293870945f9f");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
			RealUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
			Name = "SysMsgLibEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 310;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysMsgLibEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateButtonsControlLayout();
			UpdateDesignerModeButton();
			UpdateCancelButton();
			UpdateOKButton();
			UpdateMainControlLayout();
			UpdateCustomControls();
			UpdateDescriptionEdit();
			UpdateNameEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.InsertItem(0, CreateFullClassNameEdit());
			MainControlLayout.MoveItem(1, NameEdit);
			MainControlLayout.InsertItem(2, CreateCodeEdit());
			MainControlLayout.MoveItem(3, DescriptionEdit);
			MainControlLayout.InsertItem(4, CreateSetupPageSchemaNameEdit());
			MainControlLayout.InsertItem(5, CreateCtiProviderNameEdit());
			MainControlLayout.InsertItem(6, CreateLicOperationsEdit());
			MainControlLayout.MoveItem(7, CustomControls);
			TopLevelControl.MoveItem(2, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, SpacerButton);
			ButtonsControlLayout.MoveItem(1, OKButton);
			ButtonsControlLayout.MoveItem(2, CancelButton);
			ButtonsControlLayout.MoveItem(3, DesignerModeButton);
			TopLevelControl.MoveItem(3, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSysMsgLibEditPageEventsProcessSchema() {
			var schema = new SysMsgLibEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateFullClassNameEdit() {
			_fullClassNameEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_fullClassNameEdit.UId = new Guid("556eb0b5-a086-4e73-a8ff-6a76ced1fcff");
			_fullClassNameEdit.Name = "FullClassNameEdit";
			_fullClassNameEdit.CreatedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
			_fullClassNameEdit.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
			_fullClassNameEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_fullClassNameEdit.Tag = "";
			_fullClassNameEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_fullClassNameEdit.Image = new ControlImage {};
			_fullClassNameEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_fullClassNameEdit.DataSource = "DataSource";
			_fullClassNameEdit.ColumnUId = new Guid("477ffb6c-a3e4-4825-b2ba-08ae2c1fda21");
			return _fullClassNameEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateCodeEdit() {
			_codeEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_codeEdit.UId = new Guid("06fd5b09-e1a4-42c5-afc2-02541e9fe90a");
			_codeEdit.Name = "CodeEdit";
			_codeEdit.CreatedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
			_codeEdit.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
			_codeEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_codeEdit.Tag = "";
			_codeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_codeEdit.Image = new ControlImage {};
			_codeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_codeEdit.DataSource = "DataSource";
			_codeEdit.ColumnUId = new Guid("8665ca3c-b092-4b83-932c-36eabe075a31");
			_codeEdit.Required = true;
			return _codeEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateSetupPageSchemaNameEdit() {
			_setupPageSchemaNameEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_setupPageSchemaNameEdit.UId = new Guid("6e4433c2-5e08-4174-aaac-ec78cba58bfb");
			_setupPageSchemaNameEdit.Name = "SetupPageSchemaNameEdit";
			_setupPageSchemaNameEdit.CreatedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
			_setupPageSchemaNameEdit.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
			_setupPageSchemaNameEdit.CreatedInPackageId = new Guid("fcbbf5a7-101d-4475-ad73-614f06386f57");
			_setupPageSchemaNameEdit.Tag = "";
			_setupPageSchemaNameEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_setupPageSchemaNameEdit.Image = new ControlImage {};
			_setupPageSchemaNameEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_setupPageSchemaNameEdit.DataSource = "DataSource";
			_setupPageSchemaNameEdit.ColumnUId = new Guid("0e804713-12e8-48fd-8d46-c569b61d23a4");
			return _setupPageSchemaNameEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateCtiProviderNameEdit() {
			_ctiProviderNameEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_ctiProviderNameEdit.UId = new Guid("23270273-e206-42d0-a87e-7a584c0afd7c");
			_ctiProviderNameEdit.Name = "CtiProviderNameEdit";
			_ctiProviderNameEdit.CreatedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
			_ctiProviderNameEdit.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
			_ctiProviderNameEdit.CreatedInPackageId = new Guid("fcbbf5a7-101d-4475-ad73-614f06386f57");
			_ctiProviderNameEdit.Tag = "";
			_ctiProviderNameEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_ctiProviderNameEdit.Image = new ControlImage {};
			_ctiProviderNameEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_ctiProviderNameEdit.DataSource = "DataSource";
			_ctiProviderNameEdit.ColumnUId = new Guid("0950b2b9-6ec5-416a-a7b3-bf22a593817e");
			return _ctiProviderNameEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateLicOperationsEdit() {
			_licOperationsEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_licOperationsEdit.UId = new Guid("d790037d-076b-4d86-8184-c7c7381aac67");
			_licOperationsEdit.Name = "LicOperationsEdit";
			_licOperationsEdit.CreatedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
			_licOperationsEdit.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
			_licOperationsEdit.CreatedInPackageId = new Guid("fcbbf5a7-101d-4475-ad73-614f06386f57");
			_licOperationsEdit.Tag = "";
			_licOperationsEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_licOperationsEdit.Image = new ControlImage {};
			_licOperationsEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_licOperationsEdit.DataSource = "DataSource";
			_licOperationsEdit.ColumnUId = new Guid("13f705d6-b5be-4739-abf7-2135f12a88b2");
			return _licOperationsEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("89b9f170-8aed-4f41-8659-c787b50df837");
			DataSource.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("7bad966a-0e94-404b-b60d-701b59211fa8");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("bd72ed94-2efc-45d2-a39a-c550769e0e23");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("003fa7d4-5c96-4583-969b-5bec8fd4c038");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("612cc025-d2d9-4941-b2ef-2e7c7b1d1db1");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("8449ce6c-1400-441c-8285-05ac41b0e93b");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("96d66182-db1c-47dd-9dec-a6a467e0ffca");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("f1923fd6-997a-4d16-9a1c-293870945f9f");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("13aad544-ec30-4e76-a373-f0cff3202e24");
			if (column != null) {
				column.UId = new Guid("8665ca3c-b092-4b83-932c-36eabe075a31");
				column.Name = @"Code";
				column.CreatedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("4bcf3bb8-3837-4522-bb03-67d24fdd96c3");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4ad66197-8e63-4298-ac37-981399166904");
			if (column != null) {
				column.UId = new Guid("477ffb6c-a3e4-4825-b2ba-08ae2c1fda21");
				column.Name = @"FullClassName";
				column.CreatedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("6eea683c-19c3-4347-b1db-1d9de5c232ab");
			if (column != null) {
				column.UId = new Guid("0e804713-12e8-48fd-8d46-c569b61d23a4");
				column.Name = @"SetupPageSchemaName";
				column.CreatedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e1f7baaf-124a-478c-b3d9-d31202568c5c");
			if (column != null) {
				column.UId = new Guid("13f705d6-b5be-4739-abf7-2135f12a88b2");
				column.Name = @"LicOperations";
				column.CreatedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("88da31ac-dcbb-49e8-bdfb-30685ca1cae0");
			if (column != null) {
				column.UId = new Guid("0950b2b9-6ec5-416a-a7b3-bf22a593817e");
				column.Name = @"CtiProviderName";
				column.CreatedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.ModifiedInSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new SysMsgLibEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysMsgLibEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("71c37611-0d56-45e6-bf96-255642763b2d"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysMsgLibEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysMsgLibEditPageEventsProcess

	/// <exclude/>
	public class SysMsgLibEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysMsgLibEditPageSchemaUserControl
	{

		public SysMsgLibEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysMsgLibEditPageEventsProcess";
			SchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
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

	#region Class: SysMsgLibEditPageEventsProcess

	/// <exclude/>
	public class SysMsgLibEditPageEventsProcess : SysMsgLibEditPageEventsProcess<Terrasoft.WebApp.SysMsgLibEditPageSchemaUserControl>
	{

		public SysMsgLibEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysMsgLibEditPageSchemaUserControl

	/// <exclude/>
	public partial class SysMsgLibEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TextEdit FullClassNameEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("FullClassNameEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit CodeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("CodeEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit SetupPageSchemaNameEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("SetupPageSchemaNameEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit CtiProviderNameEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("CtiProviderNameEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit LicOperationsEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("LicOperationsEdit", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			DataSource.SaveRow += DataSourceSaved;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			DataSource.SaveRow -= DataSourceSaved;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (SysMsgLibEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysMsgLibEditPageEventsProcess(UserConnection);
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

		public virtual void DataSourceSaved(object sender, EventArgs e) {
			object result = ThrowEvent("DataSourceSaved");
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
			SchemaName = "SysMsgLibEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysMsgLibEditPageEventsProcessSchema

	/// <exclude/>
	public class SysMsgLibEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysMsgLibEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysMsgLibEditPageEventsProcessSchema(SysMsgLibEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysMsgLibEditPageEventsProcess";
			UId = new Guid("5dd208f2-b57a-4c70-b864-e29cd31ff500");
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
			ProcessSchemaLaneSet schemaLaneSet2 = CreateLaneSet2LaneSet();
			LaneSets.Add(schemaLaneSet2);
			ProcessSchemaLane schemaLane4 = CreateLane4Lane();
			schemaLaneSet2.Lanes.Add(schemaLane4);
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("4ecc8c31-06ed-4cd2-ba56-b3eddf187f1d"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5dd208f2-b57a-4c70-b864-e29cd31ff500"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("5dd208f2-b57a-4c70-b864-e29cd31ff500"),
				Name = @"LaneSet2",
				Position = new Point(5, 5),
				Size = new Size(1673, 175),
				UseBackgroundMode = false
			};
			return schemaLaneSet2;
		}

		protected virtual ProcessSchemaLane CreateLane4Lane() {
			ProcessSchemaLane schemaLane4 = new ProcessSchemaLane(this) {
				UId = new Guid("637b36bc-03f1-4947-ad05-2bd95d2b2487"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("4ecc8c31-06ed-4cd2-ba56-b3eddf187f1d"),
				CreatedInOwnerSchemaUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5dd208f2-b57a-4c70-b864-e29cd31ff500"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("5dd208f2-b57a-4c70-b864-e29cd31ff500"),
				Name = @"Lane4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1644, 175),
				UseBackgroundMode = false
			};
			return schemaLane4;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b750377b-5da9-443b-a870-f03cd0f31886"),
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
			return new SysMsgLibEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5dd208f2-b57a-4c70-b864-e29cd31ff500"));
		}

		#endregion

	}

	#endregion

}

