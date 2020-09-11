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

	#region Class: TaxEditPageSchema

	/// <exclude/>
	public class TaxEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.FloatEdit _percentEdit;
		public Terrasoft.UI.WebControls.Controls.FloatEdit PercentEdit {
			get {
				return _percentEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public TaxEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public TaxEditPageSchema(TaxEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("f767ccb4-41a8-449c-ad73-271f289e78ff");
			NameEdit.ModifiedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("38349e3e-6838-49d5-b787-8b7ce4b68a05");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
			RealUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
			Name = "TaxEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 320;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateTaxEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(1, CreatePercentEdit());
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

		protected virtual EmbeddedProcessSchema CreateTaxEditPageEventsProcessSchema() {
			var schema = new TaxEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FloatEdit CreatePercentEdit() {
			_percentEdit = new Terrasoft.UI.WebControls.Controls.FloatEdit();
			_percentEdit.UId = new Guid("e336922d-e89f-43cf-8db5-d1bc448aeb14");
			_percentEdit.Name = "PercentEdit";
			_percentEdit.CreatedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
			_percentEdit.ModifiedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
			_percentEdit.CreatedInPackageId = Guid.Empty;
			_percentEdit.Tag = "";
			_percentEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_percentEdit.Image = new ControlImage {};
			_percentEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_percentEdit.DataSource = "DataSource";
			_percentEdit.ColumnUId = new Guid("1c2879dd-866e-4b24-92cf-762385127c4f");
			return _percentEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("a32b5f57-0ef1-4d3d-a6ef-a6de2113fbe0");
			DataSource.ModifiedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("17f4f2fb-bbc3-43b0-b25e-8ab1b7d61dd7");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
				column.ModifiedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("e577dbca-ae30-4361-a98f-323977393b21");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
				column.ModifiedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("2507e42c-3650-4ba9-950b-d61f912a1127");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
				column.ModifiedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("0a7ee14a-e9ec-4502-a38a-94b5b364a9e9");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
				column.ModifiedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("6ac1a66f-1c52-49c7-b4ee-741fcdd8516b");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
				column.ModifiedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("f767ccb4-41a8-449c-ad73-271f289e78ff");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
				column.ModifiedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("38349e3e-6838-49d5-b787-8b7ce4b68a05");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
				column.ModifiedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("09de73af-3a4c-43d2-94ff-536f40a98048");
			if (column != null) {
				column.UId = new Guid("1c2879dd-866e-4b24-92cf-762385127c4f");
				column.Name = @"Percent";
				column.CreatedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
				column.ModifiedInSchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
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
			return new TaxEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new TaxEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8a8d3148-348a-460b-af91-05098c60ef13"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new TaxEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: TaxEditPageEventsProcess

	/// <exclude/>
	public class TaxEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.TaxEditPageSchemaUserControl
	{

		public TaxEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "TaxEditPageEventsProcess";
			SchemaUId = new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8a8d3148-348a-460b-af91-05098c60ef13");
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

	#region Class: TaxEditPageEventsProcess

	/// <exclude/>
	public class TaxEditPageEventsProcess : TaxEditPageEventsProcess<Terrasoft.WebApp.TaxEditPageSchemaUserControl>
	{

		public TaxEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: TaxEditPageSchemaUserControl

	/// <exclude/>
	public partial class TaxEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.FloatEdit PercentEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.FloatEdit)PageContainer.FindPageControl("PercentEdit", true);
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
			var process = (TaxEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new TaxEditPageEventsProcess(UserConnection);
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
			SchemaName = "TaxEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: TaxEditPageEventsProcessSchema

	/// <exclude/>
	public class TaxEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public TaxEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public TaxEditPageEventsProcessSchema(TaxEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "TaxEditPageEventsProcess";
			UId = new Guid("1cde6108-1500-4777-9b95-e313955fc25d");
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
			return new TaxEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1cde6108-1500-4777-9b95-e313955fc25d"));
		}

		#endregion

	}

	#endregion

}

