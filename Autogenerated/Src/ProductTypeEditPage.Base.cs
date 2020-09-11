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

	#region Class: ProductTypeEditPage_Base_TerrasoftSchema

	/// <exclude/>
	public class ProductTypeEditPage_Base_TerrasoftSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.CheckBox _isServiceEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox IsServiceEdit {
			get {
				return _isServiceEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public ProductTypeEditPage_Base_TerrasoftSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ProductTypeEditPage_Base_TerrasoftSchema(ProductTypeEditPage_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("49193060-c63e-421c-9879-46e9f6ee7e1f");
			NameEdit.ModifiedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("724856cb-4e5a-4886-9c85-9c92f24678d3");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
			RealUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
			Name = "ProductTypeEditPage_Base_Terrasoft";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateProductTypeEditPage_Base_TerrasoftEventsProcessSchema();
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
			MainControlLayout.InsertItem(2, CreateIsServiceEdit());
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

		protected virtual EmbeddedProcessSchema CreateProductTypeEditPage_Base_TerrasoftEventsProcessSchema() {
			var schema = new ProductTypeEditPage_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsServiceEdit() {
			_isServiceEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isServiceEdit.UId = new Guid("3c95d292-6864-40ef-8ea0-3c1fa3f6b04a");
			_isServiceEdit.Name = "IsServiceEdit";
			_isServiceEdit.CreatedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
			_isServiceEdit.ModifiedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
			_isServiceEdit.CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f");
			_isServiceEdit.Tag = "";
			_isServiceEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isServiceEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isServiceEdit.AlignedByCaption = false;
			_isServiceEdit.DataSource = "DataSource";
			_isServiceEdit.ColumnUId = new Guid("8d2231b9-1bd2-43fe-8f15-455faee13643");
			return _isServiceEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("41663f5e-affb-406e-b92d-4d72eea6f8a8");
			DataSource.ModifiedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("32aff081-bfa8-4ec6-ba74-00b4fe7d8d62");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
				column.ModifiedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("f422d272-8e9d-466c-a254-261f0e3fe4fe");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
				column.ModifiedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("5e0bf2e0-8f87-431b-a0da-98b1c2b8f15f");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
				column.ModifiedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("42927174-6fe6-410b-b27c-b5eeeb2d8c61");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
				column.ModifiedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("7cafc532-d584-419b-aca0-5e6ec00aa58d");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
				column.ModifiedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("49193060-c63e-421c-9879-46e9f6ee7e1f");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
				column.ModifiedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("724856cb-4e5a-4886-9c85-9c92f24678d3");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
				column.ModifiedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("74805d12-3b93-499c-bff0-c533978859b8");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
				column.ModifiedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b38bd826-cb96-46fc-8798-992420f5ef87");
			if (column != null) {
				column.UId = new Guid("8d2231b9-1bd2-43fe-8f15-455faee13643");
				column.Name = @"IsService";
				column.CreatedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
				column.ModifiedInSchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
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
			return new ProductTypeEditPage_Base_TerrasoftSchemaUserControl();
		}

		public override object Clone() {
			return new ProductTypeEditPage_Base_TerrasoftSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("11369c49-16db-4b53-b79a-847938faf7a2"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ProductTypeEditPage_Base_TerrasoftEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ProductTypeEditPage_Base_TerrasoftEventsProcess

	/// <exclude/>
	public class ProductTypeEditPage_Base_TerrasoftEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ProductTypeEditPage_Base_TerrasoftSchemaUserControl
	{

		public ProductTypeEditPage_Base_TerrasoftEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductTypeEditPage_Base_TerrasoftEventsProcess";
			SchemaUId = new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("11369c49-16db-4b53-b79a-847938faf7a2");
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

	#region Class: ProductTypeEditPage_Base_TerrasoftEventsProcess

	/// <exclude/>
	public class ProductTypeEditPage_Base_TerrasoftEventsProcess : ProductTypeEditPage_Base_TerrasoftEventsProcess<Terrasoft.WebApp.ProductTypeEditPage_Base_TerrasoftSchemaUserControl>
	{

		public ProductTypeEditPage_Base_TerrasoftEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductTypeEditPage_Base_TerrasoftSchemaUserControl

	/// <exclude/>
	public partial class ProductTypeEditPage_Base_TerrasoftSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.CheckBox IsServiceEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("IsServiceEdit", true);
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
			var process = (ProductTypeEditPage_Base_TerrasoftEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ProductTypeEditPage_Base_TerrasoftEventsProcess(UserConnection);
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
			SchemaName = "ProductTypeEditPage_Base_Terrasoft";
		}

		#endregion

	}

	#endregion

	#region Class: ProductTypeEditPage_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class ProductTypeEditPage_Base_TerrasoftEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ProductTypeEditPage_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ProductTypeEditPage_Base_TerrasoftEventsProcessSchema(ProductTypeEditPage_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ProductTypeEditPage_Base_TerrasoftEventsProcess";
			UId = new Guid("cd2929d9-8c1e-4889-8764-6cdb06f8b49f");
			CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f");
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

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b22cedfd-39cd-46e5-b5c4-6f7cd276eb74"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProductTypeEditPage_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cd2929d9-8c1e-4889-8764-6cdb06f8b49f"));
		}

		#endregion

	}

	#endregion

}

