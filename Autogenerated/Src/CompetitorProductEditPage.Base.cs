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

	#region Class: CompetitorProductEditPageSchema

	/// <exclude/>
	public class CompetitorProductEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TextEdit _nameEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return _nameEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _competitorEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit CompetitorEdit {
			get {
				return _competitorEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MemoEdit _strengthsEdit;
		public Terrasoft.UI.WebControls.Controls.MemoEdit StrengthsEdit {
			get {
				return _strengthsEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MemoEdit _weaknessEdit;
		public Terrasoft.UI.WebControls.Controls.MemoEdit WeaknessEdit {
			get {
				return _weaknessEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public CompetitorProductEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public CompetitorProductEditPageSchema(CompetitorProductEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
			RealUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
			Name = "CompetitorProductEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 400;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCompetitorProductEditPageEventsProcessSchema();
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
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.InsertItem(0, CreateNameEdit());
			MainControlLayout.InsertItem(1, CreateCompetitorEdit());
			MainControlLayout.InsertItem(2, CreateStrengthsEdit());
			MainControlLayout.InsertItem(3, CreateWeaknessEdit());
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

		protected virtual EmbeddedProcessSchema CreateCompetitorProductEditPageEventsProcessSchema() {
			var schema = new CompetitorProductEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateNameEdit() {
			_nameEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_nameEdit.UId = new Guid("d3a89f6c-8834-4db9-9753-bb3c60a15f13");
			_nameEdit.Name = "NameEdit";
			_nameEdit.CreatedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
			_nameEdit.ModifiedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
			_nameEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_nameEdit.Tag = "";
			_nameEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_nameEdit.Image = new ControlImage {};
			_nameEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_nameEdit.DataSource = "DataSource";
			_nameEdit.ColumnUId = new Guid("37af104c-28d5-4aa7-8107-d358ab2b9ead");
			return _nameEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateCompetitorEdit() {
			_competitorEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_competitorEdit.UId = new Guid("3fce523a-f2d0-46f3-a705-384c6fc89315");
			_competitorEdit.Name = "CompetitorEdit";
			_competitorEdit.CreatedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
			_competitorEdit.ModifiedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
			_competitorEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_competitorEdit.Tag = "";
			_competitorEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_competitorEdit.Image = new ControlImage {};
			_competitorEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_competitorEdit.DataSource = "DataSource";
			_competitorEdit.ColumnUId = new Guid("95aa1495-bdcc-4006-a5d1-bf79d5122e56");
			return _competitorEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MemoEdit CreateStrengthsEdit() {
			_strengthsEdit = new Terrasoft.UI.WebControls.Controls.MemoEdit();
			_strengthsEdit.UId = new Guid("b6e1b3fb-10f6-4e2a-ab58-d5f697a90f59");
			_strengthsEdit.Name = "StrengthsEdit";
			_strengthsEdit.CreatedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
			_strengthsEdit.ModifiedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
			_strengthsEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_strengthsEdit.Tag = "";
			_strengthsEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_strengthsEdit.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_strengthsEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_strengthsEdit.DataSource = "DataSource";
			_strengthsEdit.ColumnUId = new Guid("55940ba1-3b77-4227-bdc4-4bce3c954a9d");
			return _strengthsEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MemoEdit CreateWeaknessEdit() {
			_weaknessEdit = new Terrasoft.UI.WebControls.Controls.MemoEdit();
			_weaknessEdit.UId = new Guid("ad8d274c-9f19-492d-89b0-df75e5eef50d");
			_weaknessEdit.Name = "WeaknessEdit";
			_weaknessEdit.CreatedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
			_weaknessEdit.ModifiedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
			_weaknessEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_weaknessEdit.Tag = "";
			_weaknessEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_weaknessEdit.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_weaknessEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_weaknessEdit.DataSource = "DataSource";
			_weaknessEdit.ColumnUId = new Guid("d281e2cd-82ec-42c9-a932-c100dc8b1ed0");
			return _weaknessEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("a90cf5af-917c-4b33-8eee-832906dbe6d5");
			DataSource.ModifiedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("46d261ad-77a8-4867-9aff-ac6ed29ebda0");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
				column.ModifiedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3d005156-0544-4b66-b8ab-0e82042396ad");
			if (column != null) {
				column.UId = new Guid("37af104c-28d5-4aa7-8107-d358ab2b9ead");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
				column.ModifiedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("8b5abedc-89bc-4331-b080-e3e40d9e5938");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
				column.ModifiedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("19ec66d0-94e9-4d16-8f49-40861f9a10d9");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
				column.ModifiedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("264c7517-0167-423d-a540-70fd82a7efb0");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
				column.ModifiedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("d811a378-c1d9-450c-beb8-98831ef8cee4");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
				column.ModifiedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("27274924-78bf-4c01-b980-a934997f4a5f");
			if (column != null) {
				column.UId = new Guid("95aa1495-bdcc-4006-a5d1-bf79d5122e56");
				column.Name = @"Competitor";
				column.CreatedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
				column.ModifiedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("d533eb3b-aa86-413e-88f1-7ee456dda433");
			if (column != null) {
				column.UId = new Guid("d281e2cd-82ec-42c9-a932-c100dc8b1ed0");
				column.Name = @"Weakness";
				column.CreatedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
				column.ModifiedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("fa76bce1-6298-45a5-9f64-fd4d081136af");
			if (column != null) {
				column.UId = new Guid("55940ba1-3b77-4227-bdc4-4bce3c954a9d");
				column.Name = @"Strengths";
				column.CreatedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
				column.ModifiedInSchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
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
			return new CompetitorProductEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new CompetitorProductEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CompetitorProductEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: CompetitorProductEditPageEventsProcess

	/// <exclude/>
	public class CompetitorProductEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.CompetitorProductEditPageSchemaUserControl
	{

		public CompetitorProductEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CompetitorProductEditPageEventsProcess";
			SchemaUId = new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e40e9f3b-6dbf-4ef8-a557-b704a0c6a11e");
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

	#region Class: CompetitorProductEditPageEventsProcess

	/// <exclude/>
	public class CompetitorProductEditPageEventsProcess : CompetitorProductEditPageEventsProcess<Terrasoft.WebApp.CompetitorProductEditPageSchemaUserControl>
	{

		public CompetitorProductEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CompetitorProductEditPageSchemaUserControl

	/// <exclude/>
	public partial class CompetitorProductEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("NameEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit CompetitorEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("CompetitorEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MemoEdit StrengthsEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.MemoEdit)PageContainer.FindPageControl("StrengthsEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MemoEdit WeaknessEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.MemoEdit)PageContainer.FindPageControl("WeaknessEdit", true);
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
			var process = (CompetitorProductEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new CompetitorProductEditPageEventsProcess(UserConnection);
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
			SchemaName = "CompetitorProductEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: CompetitorProductEditPageEventsProcessSchema

	/// <exclude/>
	public class CompetitorProductEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public CompetitorProductEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CompetitorProductEditPageEventsProcessSchema(CompetitorProductEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CompetitorProductEditPageEventsProcess";
			UId = new Guid("675eaea4-fce6-4aa8-b5f4-f45d73215e07");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1");
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
			return new CompetitorProductEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("675eaea4-fce6-4aa8-b5f4-f45d73215e07"));
		}

		#endregion

	}

	#endregion

}

