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

	#region Class: BaseCodeLookupEditPageSchema

	/// <exclude/>
	public class BaseCodeLookupEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TextEdit _codeEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit CodeEdit {
			get {
				return _codeEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public BaseCodeLookupEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseCodeLookupEditPageSchema(BaseCodeLookupEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("34e23fd7-4522-48b9-ba76-b726ee77bbef");
			NameEdit.ModifiedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("c0962840-eaf0-4945-af1c-2def14d6f844");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
			RealUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
			Name = "BaseCodeLookupEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 240;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseCodeLookupEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(1, CreateCodeEdit());
			MainControlLayout.MoveItem(2, DescriptionEdit);
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

		protected virtual EmbeddedProcessSchema CreateBaseCodeLookupEditPageEventsProcessSchema() {
			var schema = new BaseCodeLookupEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateCodeEdit() {
			_codeEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_codeEdit.UId = new Guid("97641304-3580-43e9-a22a-1c6627078ae8");
			_codeEdit.Name = "CodeEdit";
			_codeEdit.CreatedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
			_codeEdit.ModifiedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
			_codeEdit.CreatedInPackageId = Guid.Empty;
			_codeEdit.Tag = "";
			_codeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_codeEdit.Image = new ControlImage {};
			_codeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_codeEdit.DataSource = "DataSource";
			_codeEdit.ColumnUId = new Guid("a573f5bf-8a26-4fae-be0c-41038c3c78eb");
			return _codeEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
			DataSource.ModifiedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("35468ae6-2780-429c-b220-aed4943fd76c");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
				column.ModifiedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("34e23fd7-4522-48b9-ba76-b726ee77bbef");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
				column.ModifiedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("a1702153-5b72-471a-aadc-466ec789bc32");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
				column.ModifiedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("7a508188-17ce-4fbb-9406-5667a7815028");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
				column.ModifiedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("e2d05fbc-a8ac-49e2-be84-7f74076c1cb9");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
				column.ModifiedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("49ae0736-fb1b-43ce-b60b-ee9bebd7c547");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
				column.ModifiedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("c0962840-eaf0-4945-af1c-2def14d6f844");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
				column.ModifiedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("13aad544-ec30-4e76-a373-f0cff3202e24");
			if (column != null) {
				column.UId = new Guid("a573f5bf-8a26-4fae-be0c-41038c3c78eb");
				column.Name = @"Code";
				column.CreatedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
				column.ModifiedInSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
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
			return new BaseCodeLookupEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseCodeLookupEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseCodeLookupEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseCodeLookupEditPageEventsProcess

	/// <exclude/>
	public class BaseCodeLookupEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.BaseCodeLookupEditPageSchemaUserControl
	{

		public BaseCodeLookupEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseCodeLookupEditPageEventsProcess";
			SchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
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

	#region Class: BaseCodeLookupEditPageEventsProcess

	/// <exclude/>
	public class BaseCodeLookupEditPageEventsProcess : BaseCodeLookupEditPageEventsProcess<Terrasoft.WebApp.BaseCodeLookupEditPageSchemaUserControl>
	{

		public BaseCodeLookupEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseCodeLookupEditPageSchemaUserControl

	/// <exclude/>
	public partial class BaseCodeLookupEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TextEdit CodeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("CodeEdit", true);
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
			var process = (BaseCodeLookupEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseCodeLookupEditPageEventsProcess(UserConnection);
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
			SchemaName = "BaseCodeLookupEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseCodeLookupEditPageEventsProcessSchema

	/// <exclude/>
	public class BaseCodeLookupEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public BaseCodeLookupEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseCodeLookupEditPageEventsProcessSchema(BaseCodeLookupEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseCodeLookupEditPageEventsProcess";
			UId = new Guid("70385971-9645-442e-a042-de6f8d36ba35");
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
			return new BaseCodeLookupEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("70385971-9645-442e-a042-de6f8d36ba35"));
		}

		#endregion

	}

	#endregion

}

