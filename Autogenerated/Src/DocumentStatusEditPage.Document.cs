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

	#region Class: DocumentStatusEditPageSchema

	/// <exclude/>
	public class DocumentStatusEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.CheckBox _finalEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox FinalEdit {
			get {
				return _finalEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public DocumentStatusEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public DocumentStatusEditPageSchema(DocumentStatusEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("d9b0eec8-6dfd-477d-a5e2-d86fd27ae134");
			NameEdit.ModifiedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("ed83cf46-ce06-4b4e-baf1-d32bd160bf63");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
			RealUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
			Name = "DocumentStatusEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateDocumentStatusEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(2, CreateFinalEdit());
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

		protected virtual EmbeddedProcessSchema CreateDocumentStatusEditPageEventsProcessSchema() {
			var schema = new DocumentStatusEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateFinalEdit() {
			_finalEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_finalEdit.UId = new Guid("ac46f82c-4c4a-42c0-a6a4-dcae050d7355");
			_finalEdit.Name = "FinalEdit";
			_finalEdit.CreatedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
			_finalEdit.ModifiedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
			_finalEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_finalEdit.Tag = "";
			_finalEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_finalEdit.CaptionPosition = Terrasoft.UI.WebControls.Controls.CheckBoxBaseCaptionPosition.Left;
			_finalEdit.DataSource = "DataSource";
			_finalEdit.ColumnUId = new Guid("6d9e142a-13fd-471d-8ac4-11da6766a1e6");
			return _finalEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("d32d5914-e52f-40c6-a0eb-f80ef1d2e252");
			DataSource.ModifiedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("54018def-5500-4859-9d21-b2d67521e501");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
				column.ModifiedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("d9b0eec8-6dfd-477d-a5e2-d86fd27ae134");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
				column.ModifiedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("da0a09be-5617-4daf-aa0a-052c03bc259b");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
				column.ModifiedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("f892ace4-aa4b-4f1f-8282-0b035a65bc7e");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
				column.ModifiedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("8b89cffb-28ab-4691-b1b0-4475861f8728");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
				column.ModifiedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("a0f1867e-6a2e-4698-b683-8a1c4afab3c1");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
				column.ModifiedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("ed83cf46-ce06-4b4e-baf1-d32bd160bf63");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
				column.ModifiedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("0d324e79-756f-4965-b549-df85c1130d5f");
			if (column != null) {
				column.UId = new Guid("6d9e142a-13fd-471d-8ac4-11da6766a1e6");
				column.Name = @"Final";
				column.CreatedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
				column.ModifiedInSchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
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
			return new DocumentStatusEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new DocumentStatusEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new DocumentStatusEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: DocumentStatusEditPageEventsProcess

	/// <exclude/>
	public class DocumentStatusEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.DocumentStatusEditPageSchemaUserControl
	{

		public DocumentStatusEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DocumentStatusEditPageEventsProcess";
			SchemaUId = new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("348b443f-a2a1-4dd8-88ff-2a63ba757e4e");
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

	#region Class: DocumentStatusEditPageEventsProcess

	/// <exclude/>
	public class DocumentStatusEditPageEventsProcess : DocumentStatusEditPageEventsProcess<Terrasoft.WebApp.DocumentStatusEditPageSchemaUserControl>
	{

		public DocumentStatusEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DocumentStatusEditPageSchemaUserControl

	/// <exclude/>
	public partial class DocumentStatusEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.CheckBox FinalEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("FinalEdit", true);
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
			var process = (DocumentStatusEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new DocumentStatusEditPageEventsProcess(UserConnection);
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
			SchemaName = "DocumentStatusEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: DocumentStatusEditPageEventsProcessSchema

	/// <exclude/>
	public class DocumentStatusEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public DocumentStatusEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public DocumentStatusEditPageEventsProcessSchema(DocumentStatusEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "DocumentStatusEditPageEventsProcess";
			UId = new Guid("4e8f9022-dd83-4e1b-9f7f-3ec24c5b783d");
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
			return new DocumentStatusEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4e8f9022-dd83-4e1b-9f7f-3ec24c5b783d"));
		}

		#endregion

	}

	#endregion

}

