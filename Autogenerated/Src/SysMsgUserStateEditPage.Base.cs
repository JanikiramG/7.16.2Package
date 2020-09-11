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
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using Terrasoft.Web.Common;
	using TSConfiguration = Terrasoft.Configuration;
	using web = System.Web;

	#region Class: SysMsgUserStateEditPageSchema

	/// <exclude/>
	public class SysMsgUserStateEditPageSchema : Terrasoft.WebApp.BaseCodeLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _iconEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit IconEdit {
			get {
				return _iconEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _isDisplayOnlyEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox IsDisplayOnlyEdit {
			get {
				return _isDisplayOnlyEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public SysMsgUserStateEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysMsgUserStateEditPageSchema(SysMsgUserStateEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("7a971760-11af-45dd-9ea5-e7c2c9908366");
			NameEdit.ModifiedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
		}

		private void UpdateCodeEdit() {
			CodeEdit.Image = new ControlImage {};
			CodeEdit.ColumnUId = new Guid("fdf749f0-63e3-48ca-81c8-69e6f4d5ab75");
			CodeEdit.ModifiedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("220355d9-cb3c-4f2e-8700-81af199de3a6");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
			RealUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
			Name = "SysMsgUserStateEditPage";
			ParentSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 300;
			ValidationMessagePanel = "";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysMsgUserStateEditPageEventsProcessSchema();
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
			UpdateCodeEdit();
			UpdateNameEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, NameEdit);
			MainControlLayout.MoveItem(1, CodeEdit);
			MainControlLayout.InsertItem(2, CreateIconEdit());
			MainControlLayout.MoveItem(3, DescriptionEdit);
			MainControlLayout.InsertItem(4, CreateIsDisplayOnlyEdit());
			MainControlLayout.MoveItem(5, CustomControls);
			TopLevelControl.MoveItem(2, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, SpacerButton);
			ButtonsControlLayout.MoveItem(1, OKButton);
			ButtonsControlLayout.MoveItem(2, CancelButton);
			ButtonsControlLayout.MoveItem(3, DesignerModeButton);
			TopLevelControl.MoveItem(3, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSysMsgUserStateEditPageEventsProcessSchema() {
			var schema = new SysMsgUserStateEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateIconEdit() {
			_iconEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_iconEdit.UId = new Guid("bb2baf12-523c-4260-a6e6-7c6d0137ee94");
			_iconEdit.Name = "IconEdit";
			_iconEdit.CreatedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
			_iconEdit.ModifiedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
			_iconEdit.CreatedInPackageId = new Guid("643e56ac-edab-4421-a0b3-a6802bb73ff3");
			_iconEdit.Tag = "";
			_iconEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_iconEdit.Image = new ControlImage {};
			_iconEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_iconEdit.DataSource = "DataSource";
			_iconEdit.ColumnUId = new Guid("f632e5ab-af3d-440f-8c24-c7c2a61bffc9");
			return _iconEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsDisplayOnlyEdit() {
			_isDisplayOnlyEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isDisplayOnlyEdit.UId = new Guid("060095a6-0caa-4047-b888-122b4e4d73e3");
			_isDisplayOnlyEdit.Name = "IsDisplayOnlyEdit";
			_isDisplayOnlyEdit.CreatedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
			_isDisplayOnlyEdit.ModifiedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
			_isDisplayOnlyEdit.CreatedInPackageId = new Guid("c7325125-3da0-4051-8d8f-fcafc2a62849");
			_isDisplayOnlyEdit.Tag = "";
			_isDisplayOnlyEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isDisplayOnlyEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isDisplayOnlyEdit.DataSource = "DataSource";
			_isDisplayOnlyEdit.ColumnUId = new Guid("8709b25d-7cdf-42db-a0ba-2594fbd7d7cf");
			return _isDisplayOnlyEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("bb85a556-c9b9-41ee-acfa-eabc9bfb84ac");
			DataSource.ModifiedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("cdc0807b-8056-42b1-937e-5915e0172b0e");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
				column.ModifiedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("7a971760-11af-45dd-9ea5-e7c2c9908366");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
				column.ModifiedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("fb937a57-0097-4f25-9c8a-db6c09c4fbc6");
			if (column != null) {
				column.UId = new Guid("a95a8bab-390a-4893-9525-b0f5f502f779");
				column.Name = @"Image";
				column.CreatedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
				column.ModifiedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("7e90b79a-3892-49cd-8865-8cb5f80d93b6");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
				column.ModifiedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("9bf5f2d2-23bf-4dc2-bb03-5ce31dce8a63");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
				column.ModifiedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("ab349bc4-0927-4288-b103-9a96c513aa72");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
				column.ModifiedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("df0409d0-fc0c-4cc6-a667-9da96885f507");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
				column.ModifiedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("220355d9-cb3c-4f2e-8700-81af199de3a6");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
				column.ModifiedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("13aad544-ec30-4e76-a373-f0cff3202e24");
			if (column != null) {
				column.UId = new Guid("fdf749f0-63e3-48ca-81c8-69e6f4d5ab75");
				column.Name = @"Code";
				column.CreatedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
				column.ModifiedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e67359d9-76c4-4118-a79c-46e421b11c62");
			if (column != null) {
				column.UId = new Guid("8709b25d-7cdf-42db-a0ba-2594fbd7d7cf");
				column.Name = @"IsDisplayOnly";
				column.CreatedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
				column.ModifiedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("a987423b-a858-4feb-885e-00db8293f227");
			if (column != null) {
				column.UId = new Guid("f632e5ab-af3d-440f-8c24-c7c2a61bffc9");
				column.Name = @"Icon";
				column.CreatedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
				column.ModifiedInSchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
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
			return new SysMsgUserStateEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysMsgUserStateEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysMsgUserStateEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysMsgUserStateEditPageEventsProcess

	/// <exclude/>
	public class SysMsgUserStateEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseCodeLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysMsgUserStateEditPageSchemaUserControl
	{

		public SysMsgUserStateEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysMsgUserStateEditPageEventsProcess";
			SchemaUId = new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e164c0c4-76a3-4f91-aff0-412d4ddc0cad");
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

	#region Class: SysMsgUserStateEditPageEventsProcess

	/// <exclude/>
	public class SysMsgUserStateEditPageEventsProcess : SysMsgUserStateEditPageEventsProcess<Terrasoft.WebApp.SysMsgUserStateEditPageSchemaUserControl>
	{

		public SysMsgUserStateEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysMsgUserStateEditPageSchemaUserControl

	/// <exclude/>
	public partial class SysMsgUserStateEditPageSchemaUserControl : Terrasoft.WebApp.BaseCodeLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit IconEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("IconEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox IsDisplayOnlyEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("IsDisplayOnlyEdit", true);
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
			var process = (SysMsgUserStateEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysMsgUserStateEditPageEventsProcess(UserConnection);
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
			SchemaName = "SysMsgUserStateEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysMsgUserStateEditPageEventsProcessSchema

	/// <exclude/>
	public class SysMsgUserStateEditPageEventsProcessSchema : Terrasoft.WebApp.BaseCodeLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysMsgUserStateEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysMsgUserStateEditPageEventsProcessSchema(SysMsgUserStateEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysMsgUserStateEditPageEventsProcess";
			UId = new Guid("00154c24-ce5e-4abb-922d-60958df7973e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd");
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
				UId = new Guid("2bbab41b-6fcf-468b-a92b-46ea0824a409"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
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
			return new SysMsgUserStateEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("00154c24-ce5e-4abb-922d-60958df7973e"));
		}

		#endregion

	}

	#endregion

}

