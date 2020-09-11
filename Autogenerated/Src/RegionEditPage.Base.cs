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

	#region Class: RegionEditPageSchema

	/// <exclude/>
	public class RegionEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _countryEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit CountryEdit {
			get {
				return _countryEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public RegionEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public RegionEditPageSchema(RegionEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("f11654df-c968-447e-ab8b-c703423b536e");
			NameEdit.ModifiedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("95014971-0c34-43a2-9d1a-9a582a2f8f78");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
			RealUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
			Name = "RegionEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 320;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateRegionEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(1, CreateCountryEdit());
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

		protected virtual EmbeddedProcessSchema CreateRegionEditPageEventsProcessSchema() {
			var schema = new RegionEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateCountryEdit() {
			_countryEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_countryEdit.UId = new Guid("edc4d9b0-3792-4fee-8beb-663e872c6a49");
			_countryEdit.Name = "CountryEdit";
			_countryEdit.CreatedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
			_countryEdit.ModifiedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
			_countryEdit.CreatedInPackageId = Guid.Empty;
			_countryEdit.Tag = "";
			_countryEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_countryEdit.Image = new ControlImage {};
			_countryEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_countryEdit.DataSource = "DataSource";
			_countryEdit.ColumnUId = new Guid("3fbef91f-db58-4e22-9697-ebd9f9cfa641");
			return _countryEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("fa4eb497-e6a3-4f8c-8568-5df4bd2a8b91");
			DataSource.ModifiedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("cb343365-bb95-46a1-91c6-02b67f516d9f");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
				column.ModifiedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("953e54cd-5dfd-48ed-b69a-4f49dd7ac0d6");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
				column.ModifiedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("61a01e49-5332-40b0-902d-4085164d4b40");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
				column.ModifiedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("e39b6ab9-4181-44c2-a8be-3bfd85588d15");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
				column.ModifiedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("e4c896b6-ecc0-4a60-84ad-3f0d38e77bff");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
				column.ModifiedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("f11654df-c968-447e-ab8b-c703423b536e");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
				column.ModifiedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("95014971-0c34-43a2-9d1a-9a582a2f8f78");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
				column.ModifiedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("8469bcc6-3a77-4706-85a9-72a2ec3aa2f5");
			if (column != null) {
				column.UId = new Guid("3fbef91f-db58-4e22-9697-ebd9f9cfa641");
				column.Name = @"Country";
				column.CreatedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
				column.ModifiedInSchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
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
			return new RegionEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new RegionEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new RegionEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: RegionEditPageEventsProcess

	/// <exclude/>
	public class RegionEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.RegionEditPageSchemaUserControl
	{

		public RegionEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "RegionEditPageEventsProcess";
			SchemaUId = new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("cf8468e2-46c5-433b-987f-ecd01020a6f2");
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

	#region Class: RegionEditPageEventsProcess

	/// <exclude/>
	public class RegionEditPageEventsProcess : RegionEditPageEventsProcess<Terrasoft.WebApp.RegionEditPageSchemaUserControl>
	{

		public RegionEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: RegionEditPageSchemaUserControl

	/// <exclude/>
	public partial class RegionEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit CountryEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("CountryEdit", true);
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
			var process = (RegionEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new RegionEditPageEventsProcess(UserConnection);
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
			SchemaName = "RegionEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: RegionEditPageEventsProcessSchema

	/// <exclude/>
	public class RegionEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public RegionEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public RegionEditPageEventsProcessSchema(RegionEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "RegionEditPageEventsProcess";
			UId = new Guid("d920af01-6c67-49ee-8742-253afe408235");
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
			return new RegionEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d920af01-6c67-49ee-8742-253afe408235"));
		}

		#endregion

	}

	#endregion

}

