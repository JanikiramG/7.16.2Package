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

	#region Class: DocumentStatePageSchema

	/// <exclude/>
	public class DocumentStatePageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _positionEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit PositionEdit {
			get {
				return _positionEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public DocumentStatePageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public DocumentStatePageSchema(DocumentStatePageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ModifiedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
			RealUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
			Name = "DocumentStatePage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("93f2b0e4-b421-42dc-86e5-35e5b932239c");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateDocumentStatePageEventsProcessSchema();
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
			UpdateNameEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, NameEdit);
			MainControlLayout.MoveItem(1, DescriptionEdit);
			MainControlLayout.MoveItem(2, CustomControls);
			CustomControls.InsertItem(0, CreatePositionEdit());
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

		protected virtual EmbeddedProcessSchema CreateDocumentStatePageEventsProcessSchema() {
			var schema = new DocumentStatePageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreatePositionEdit() {
			_positionEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_positionEdit.UId = new Guid("a090ca33-c529-4f77-acc5-954c74eba837");
			_positionEdit.Name = "PositionEdit";
			_positionEdit.CreatedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
			_positionEdit.ModifiedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
			_positionEdit.CreatedInPackageId = new Guid("93f2b0e4-b421-42dc-86e5-35e5b932239c");
			_positionEdit.Tag = "";
			_positionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_positionEdit.Image = new ControlImage {};
			_positionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_positionEdit.DataSource = "DataSource";
			_positionEdit.ColumnUId = new Guid("5669aed1-c533-4a24-8b68-684a0fa71596");
			return _positionEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("3fa49baa-57d4-40d7-9293-1e6742b1b0dd");
			DataSource.ModifiedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("ec48e66a-4bca-40bd-a241-21f5af78e0b7");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
				column.ModifiedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("df01b15f-12e7-4dfe-b048-1c6cea888ef7");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
				column.ModifiedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("7c215335-3000-4646-a802-36172b883e25");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
				column.ModifiedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("37be0c57-941e-476f-b672-2c284a437721");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
				column.ModifiedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("caec07d9-ad00-4f83-bd6e-53c9c4e7fcc0");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
				column.ModifiedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("bfcefec0-d464-4f0e-ac6d-c8aa798ee172");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
				column.ModifiedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("8415d7be-1c50-448a-a2e0-8ccdfec4b06d");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
				column.ModifiedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("7605f453-3589-49ee-8c0e-f05c09e20d77");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
				column.ModifiedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e97b79d-5d55-4b98-bfb0-c803e3d1467f");
			if (column != null) {
				column.UId = new Guid("5669aed1-c533-4a24-8b68-684a0fa71596");
				column.Name = @"Position";
				column.CreatedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
				column.ModifiedInSchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
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
			return new DocumentStatePageSchemaUserControl();
		}

		public override object Clone() {
			return new DocumentStatePageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new DocumentStatePageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: DocumentStatePageEventsProcess

	/// <exclude/>
	public class DocumentStatePageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.DocumentStatePageSchemaUserControl
	{

		public DocumentStatePageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DocumentStatePageEventsProcess";
			SchemaUId = new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c8880a2f-cea3-4d46-9663-c4ec41f2f258");
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

	#region Class: DocumentStatePageEventsProcess

	/// <exclude/>
	public class DocumentStatePageEventsProcess : DocumentStatePageEventsProcess<Terrasoft.WebApp.DocumentStatePageSchemaUserControl>
	{

		public DocumentStatePageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DocumentStatePageSchemaUserControl

	/// <exclude/>
	public partial class DocumentStatePageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.IntegerEdit PositionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("PositionEdit", true);
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
			var process = (DocumentStatePageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new DocumentStatePageEventsProcess(UserConnection);
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
			SchemaName = "DocumentStatePage";
		}

		#endregion

	}

	#endregion

	#region Class: DocumentStatePageEventsProcessSchema

	/// <exclude/>
	public class DocumentStatePageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public DocumentStatePageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public DocumentStatePageEventsProcessSchema(DocumentStatePageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "DocumentStatePageEventsProcess";
			UId = new Guid("1027ff04-76ca-4e48-9372-7fb3a1883ddf");
			CreatedInPackageId = new Guid("93f2b0e4-b421-42dc-86e5-35e5b932239c");
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
			return new DocumentStatePageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1027ff04-76ca-4e48-9372-7fb3a1883ddf"));
		}

		#endregion

	}

	#endregion

}

