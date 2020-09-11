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

	#region Class: ActivityResultEditPageSchema

	/// <exclude/>
	public class ActivityResultEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _categoryEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit CategoryEdit {
			get {
				return _categoryEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _businessProcessOnlyCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox BusinessProcessOnlyCheckBox {
			get {
				return _businessProcessOnlyCheckBox;
			}
		}

		#endregion

		#region Constructors: Public

		public ActivityResultEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ActivityResultEditPageSchema(ActivityResultEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("2a18f371-9a86-451f-be86-5df651a94ecf");
			NameEdit.ModifiedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("5ab97352-6c97-4861-be5e-12235beb3d31");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
			RealUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
			Name = "ActivityResultEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6");
			Width = 480;
			Height = 230;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateActivityResultEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(1, CreateCategoryEdit());
			MainControlLayout.MoveItem(2, DescriptionEdit);
			MainControlLayout.InsertItem(3, CreateBusinessProcessOnlyCheckBox());
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

		protected virtual EmbeddedProcessSchema CreateActivityResultEditPageEventsProcessSchema() {
			var schema = new ActivityResultEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateCategoryEdit() {
			_categoryEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_categoryEdit.UId = new Guid("39c1e9ab-b2f3-4580-8e40-0c282b2aca5a");
			_categoryEdit.Name = "CategoryEdit";
			_categoryEdit.CreatedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
			_categoryEdit.ModifiedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
			_categoryEdit.CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6");
			_categoryEdit.Tag = "";
			_categoryEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_categoryEdit.Image = new ControlImage {};
			_categoryEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_categoryEdit.DataSource = "DataSource";
			_categoryEdit.ColumnUId = new Guid("b2be0abb-1d09-4ee6-b96e-3a7140b7e2d7");
			_categoryEdit.Required = true;
			return _categoryEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateBusinessProcessOnlyCheckBox() {
			_businessProcessOnlyCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_businessProcessOnlyCheckBox.UId = new Guid("7af26305-c346-4616-b5c9-267ea17af92b");
			_businessProcessOnlyCheckBox.Name = "BusinessProcessOnlyCheckBox";
			_businessProcessOnlyCheckBox.CreatedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
			_businessProcessOnlyCheckBox.ModifiedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
			_businessProcessOnlyCheckBox.CreatedInPackageId = new Guid("1687c2a3-d7aa-4424-abab-d22315cd0bba");
			_businessProcessOnlyCheckBox.Tag = "";
			_businessProcessOnlyCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_businessProcessOnlyCheckBox.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_businessProcessOnlyCheckBox.DataSource = "DataSource";
			_businessProcessOnlyCheckBox.ColumnUId = new Guid("c78d5c9d-4f6c-491a-9e5d-e67499dac387");
			return _businessProcessOnlyCheckBox;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("329bd06e-f95f-4824-a0fb-85edff2f2948");
			DataSource.ModifiedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("61464aff-8de4-4e25-a56e-133ec63899b0");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
				column.ModifiedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("75cb9fec-ef48-4b46-9591-d04cccb63f30");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
				column.ModifiedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("4aa83665-b54c-451d-a608-1bf9c4fa533a");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
				column.ModifiedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("20752f21-4cb7-4dde-b9c2-816ef6d98fcd");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
				column.ModifiedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("f1b8a003-e88e-4c68-a4b9-9afcfe8b6599");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
				column.ModifiedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("2a18f371-9a86-451f-be86-5df651a94ecf");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
				column.ModifiedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("5ab97352-6c97-4861-be5e-12235beb3d31");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
				column.ModifiedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("ca42e270-65e9-4380-a613-93ac5ceb5008");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
				column.ModifiedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("53fd3525-a4b3-4fe1-b1f2-2ce79128f5e4");
			if (column != null) {
				column.UId = new Guid("b2be0abb-1d09-4ee6-b96e-3a7140b7e2d7");
				column.Name = @"Category";
				column.CreatedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
				column.ModifiedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("28dedc44-4148-44b3-a642-5bfe30e3e8af");
			if (column != null) {
				column.UId = new Guid("c78d5c9d-4f6c-491a-9e5d-e67499dac387");
				column.Name = @"BusinessProcessOnly";
				column.CreatedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
				column.ModifiedInSchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
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
			return new ActivityResultEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new ActivityResultEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ActivityResultEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ActivityResultEditPageEventsProcess

	/// <exclude/>
	public class ActivityResultEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ActivityResultEditPageSchemaUserControl
	{

		public ActivityResultEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ActivityResultEditPageEventsProcess";
			SchemaUId = new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4f39067b-b7b0-4104-819e-cb3280d8189a");
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

		public virtual EntityCollection Activities {
			get;
			set;
		}

		public virtual EntityCollection OldValueActivities {
			get;
			set;
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

	#region Class: ActivityResultEditPageEventsProcess

	/// <exclude/>
	public class ActivityResultEditPageEventsProcess : ActivityResultEditPageEventsProcess<Terrasoft.WebApp.ActivityResultEditPageSchemaUserControl>
	{

		public ActivityResultEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ActivityResultEditPageSchemaUserControl

	/// <exclude/>
	public partial class ActivityResultEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit CategoryEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("CategoryEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox BusinessProcessOnlyCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("BusinessProcessOnlyCheckBox", true);
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
			var process = (ActivityResultEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ActivityResultEditPageEventsProcess(UserConnection);
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
			SchemaName = "ActivityResultEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: ActivityResultEditPageEventsProcessSchema

	/// <exclude/>
	public class ActivityResultEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ActivityResultEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ActivityResultEditPageEventsProcessSchema(ActivityResultEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ActivityResultEditPageEventsProcess";
			UId = new Guid("8b9ebace-7ca9-4278-a267-8537cb6c4bbb");
			CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6");
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

		protected virtual ProcessSchemaParameter CreateActivitiesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7606ccde-567b-4f61-9896-e71badf55dea"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("8b9ebace-7ca9-4278-a267-8537cb6c4bbb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("8b9ebace-7ca9-4278-a267-8537cb6c4bbb"),
				Name = @"Activities",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType"),
			};
		}

		protected virtual ProcessSchemaParameter CreateOldValueActivitiesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("cec5ab33-c6b7-4cf3-84f4-eb3fce2e6a2c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("8b9ebace-7ca9-4278-a267-8537cb6c4bbb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("8b9ebace-7ca9-4278-a267-8537cb6c4bbb"),
				Name = @"OldValueActivities",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateActivitiesParameter());
			Parameters.Add(CreateOldValueActivitiesParameter());
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
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ActivityResultEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8b9ebace-7ca9-4278-a267-8537cb6c4bbb"));
		}

		#endregion

	}

	#endregion

}

