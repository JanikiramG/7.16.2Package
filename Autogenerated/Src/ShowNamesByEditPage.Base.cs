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

	#region Class: ShowNamesByEditPageSchema

	/// <exclude/>
	public class ShowNamesByEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TextEdit _separatorEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit SeparatorEdit {
			get {
				return _separatorEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _converterEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit ConverterEdit {
			get {
				return _converterEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public ShowNamesByEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ShowNamesByEditPageSchema(ShowNamesByEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("c8e54b38-9d83-4bc4-97b3-624695614340");
			NameEdit.Required = true;
			NameEdit.ModifiedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("34aec294-225a-40ae-9d9b-08b0ce97f591");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
			RealUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
			Name = "ShowNamesByEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847");
			Height = 250;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateShowNamesByEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(1, CreateSeparatorEdit());
			MainControlLayout.InsertItem(2, CreateConverterEdit());
			MainControlLayout.MoveItem(3, DescriptionEdit);
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

		protected virtual EmbeddedProcessSchema CreateShowNamesByEditPageEventsProcessSchema() {
			var schema = new ShowNamesByEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateSeparatorEdit() {
			_separatorEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_separatorEdit.UId = new Guid("68428715-d54e-4bba-a2f6-ba7f5c3442e5");
			_separatorEdit.Name = "SeparatorEdit";
			_separatorEdit.CreatedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
			_separatorEdit.ModifiedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
			_separatorEdit.CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847");
			_separatorEdit.Tag = "";
			_separatorEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_separatorEdit.Image = new ControlImage {};
			_separatorEdit.Width = System.Web.UI.WebControls.Unit.Pixel(50);
			_separatorEdit.DataSource = "DataSource";
			_separatorEdit.ColumnUId = new Guid("03ec77b9-2aed-4abb-aa8a-16847da9e52a");
			return _separatorEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateConverterEdit() {
			_converterEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_converterEdit.UId = new Guid("7ec4fa0b-d027-4152-abb1-69edd11b5226");
			_converterEdit.Name = "ConverterEdit";
			_converterEdit.CreatedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
			_converterEdit.ModifiedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
			_converterEdit.CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847");
			_converterEdit.Tag = "";
			_converterEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_converterEdit.Image = new ControlImage {};
			_converterEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_converterEdit.DataSource = "DataSource";
			_converterEdit.ColumnUId = new Guid("b64e78b7-69f1-4007-bfc6-aa0f6a6aa500");
			return _converterEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("fe0e9a8c-3ba6-46fb-835e-71ac1d91e2b7");
			DataSource.ModifiedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("295f036d-2e5a-4ce1-aebf-61039ea40094");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
				column.ModifiedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("c87e84a3-a6f9-4451-a9c5-5ef3cbf3c258");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
				column.ModifiedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("084302d2-afce-4d21-82e7-67c34efcb2f1");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
				column.ModifiedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("4e3bce00-c8a0-4915-90e5-610acd5933f5");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
				column.ModifiedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("c650088b-2725-40e1-9236-e9bd06866f03");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
				column.ModifiedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("c8e54b38-9d83-4bc4-97b3-624695614340");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
				column.ModifiedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("34aec294-225a-40ae-9d9b-08b0ce97f591");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
				column.ModifiedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("9c26b1a2-ba88-41c2-ba79-8c8cc4e558e1");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
				column.ModifiedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("5741501e-fb86-4c7b-b1ac-4a2cd53430ce");
			if (column != null) {
				column.UId = new Guid("03ec77b9-2aed-4abb-aa8a-16847da9e52a");
				column.Name = @"Separator";
				column.CreatedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
				column.ModifiedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("f36a44b8-faf2-42ce-a4af-f44e45795230");
			if (column != null) {
				column.UId = new Guid("b64e78b7-69f1-4007-bfc6-aa0f6a6aa500");
				column.Name = @"Converter";
				column.CreatedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
				column.ModifiedInSchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
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
			return new ShowNamesByEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new ShowNamesByEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ShowNamesByEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ShowNamesByEditPageEventsProcess

	/// <exclude/>
	public class ShowNamesByEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ShowNamesByEditPageSchemaUserControl
	{

		public ShowNamesByEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ShowNamesByEditPageEventsProcess";
			SchemaUId = new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d9e4fb02-937f-49c8-86a9-c4a1593a798d");
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

	#region Class: ShowNamesByEditPageEventsProcess

	/// <exclude/>
	public class ShowNamesByEditPageEventsProcess : ShowNamesByEditPageEventsProcess<Terrasoft.WebApp.ShowNamesByEditPageSchemaUserControl>
	{

		public ShowNamesByEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ShowNamesByEditPageSchemaUserControl

	/// <exclude/>
	public partial class ShowNamesByEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TextEdit SeparatorEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("SeparatorEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit ConverterEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("ConverterEdit", true);
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
			var process = (ShowNamesByEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ShowNamesByEditPageEventsProcess(UserConnection);
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
			SchemaName = "ShowNamesByEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: ShowNamesByEditPageEventsProcessSchema

	/// <exclude/>
	public class ShowNamesByEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ShowNamesByEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ShowNamesByEditPageEventsProcessSchema(ShowNamesByEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ShowNamesByEditPageEventsProcess";
			UId = new Guid("07152a1e-9ec7-4de5-b94f-98fc3850270f");
			CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847");
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
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ShowNamesByEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("07152a1e-9ec7-4de5-b94f-98fc3850270f"));
		}

		#endregion

	}

	#endregion

}

