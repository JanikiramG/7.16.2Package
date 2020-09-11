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

	#region Class: InvoicePaymentStatusEditPageSchema

	/// <exclude/>
	public class InvoicePaymentStatusEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.CheckBox _finalStatusEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox FinalStatusEdit {
			get {
				return _finalStatusEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public InvoicePaymentStatusEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public InvoicePaymentStatusEditPageSchema(InvoicePaymentStatusEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("6eb81a8d-5997-4c74-8df5-a8b23731df2a");
			NameEdit.ModifiedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("2d5edf05-4a0f-4e36-b4ba-5ac8e1e27180");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
			RealUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
			Name = "InvoicePaymentStatusEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 320;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateInvoicePaymentStatusEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(2, CreateFinalStatusEdit());
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

		protected virtual EmbeddedProcessSchema CreateInvoicePaymentStatusEditPageEventsProcessSchema() {
			var schema = new InvoicePaymentStatusEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateFinalStatusEdit() {
			_finalStatusEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_finalStatusEdit.UId = new Guid("55382456-a7a1-496e-a60a-914959d01172");
			_finalStatusEdit.Name = "FinalStatusEdit";
			_finalStatusEdit.CreatedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
			_finalStatusEdit.ModifiedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
			_finalStatusEdit.CreatedInPackageId = new Guid("f3bc47ce-fcc6-4dea-b6da-22a7435d9adc");
			_finalStatusEdit.Tag = "";
			_finalStatusEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_finalStatusEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_finalStatusEdit.CaptionPosition = Terrasoft.UI.WebControls.Controls.CheckBoxBaseCaptionPosition.Left;
			_finalStatusEdit.DataSource = "DataSource";
			_finalStatusEdit.ColumnUId = new Guid("cf602884-3674-4de4-88ca-516858a9145b");
			return _finalStatusEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("4a75f63d-e1b2-453b-a19d-fe614c158861");
			DataSource.ModifiedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("8717e46d-17cf-4846-b9ae-446c403c2abb");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
				column.ModifiedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("673dd524-2848-49b7-af0f-055fbe112183");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
				column.ModifiedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("6f3503ae-5b9a-4272-9905-f89ed61d102a");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
				column.ModifiedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("306771ff-6f34-40fd-94d3-ece48e5d227c");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
				column.ModifiedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("8e586652-8d3c-4ad3-9771-8e5ec5e86f22");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
				column.ModifiedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("6eb81a8d-5997-4c74-8df5-a8b23731df2a");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
				column.ModifiedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("2d5edf05-4a0f-4e36-b4ba-5ac8e1e27180");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
				column.ModifiedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ca97d08a-da88-4e75-a732-6501bc043dcb");
			if (column != null) {
				column.UId = new Guid("cf602884-3674-4de4-88ca-516858a9145b");
				column.Name = @"FinalStatus";
				column.CreatedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
				column.ModifiedInSchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
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
			return new InvoicePaymentStatusEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new InvoicePaymentStatusEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new InvoicePaymentStatusEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: InvoicePaymentStatusEditPageEventsProcess

	/// <exclude/>
	public class InvoicePaymentStatusEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.InvoicePaymentStatusEditPageSchemaUserControl
	{

		public InvoicePaymentStatusEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "InvoicePaymentStatusEditPageEventsProcess";
			SchemaUId = new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("775beb5b-468f-47c2-a3fb-58c99b64b7eb");
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

	#region Class: InvoicePaymentStatusEditPageEventsProcess

	/// <exclude/>
	public class InvoicePaymentStatusEditPageEventsProcess : InvoicePaymentStatusEditPageEventsProcess<Terrasoft.WebApp.InvoicePaymentStatusEditPageSchemaUserControl>
	{

		public InvoicePaymentStatusEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: InvoicePaymentStatusEditPageSchemaUserControl

	/// <exclude/>
	public partial class InvoicePaymentStatusEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.CheckBox FinalStatusEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("FinalStatusEdit", true);
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
			var process = (InvoicePaymentStatusEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new InvoicePaymentStatusEditPageEventsProcess(UserConnection);
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
			SchemaName = "InvoicePaymentStatusEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: InvoicePaymentStatusEditPageEventsProcessSchema

	/// <exclude/>
	public class InvoicePaymentStatusEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public InvoicePaymentStatusEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public InvoicePaymentStatusEditPageEventsProcessSchema(InvoicePaymentStatusEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "InvoicePaymentStatusEditPageEventsProcess";
			UId = new Guid("16eb1a8e-c008-456c-9260-0890cdbe2577");
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
			return new InvoicePaymentStatusEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("16eb1a8e-c008-456c-9260-0890cdbe2577"));
		}

		#endregion

	}

	#endregion

}

