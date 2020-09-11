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

	#region Class: CityEditPageSchema

	/// <exclude/>
	public class CityEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _countryEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit CountryEdit {
			get {
				return _countryEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _regionEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit RegionEdit {
			get {
				return _regionEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _timeZoneEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit TimeZoneEdit {
			get {
				return _timeZoneEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public CityEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public CityEditPageSchema(CityEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("547ba551-cbcf-4651-b277-cd422f17fd00");
			NameEdit.ModifiedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("505e8eef-a17b-47b6-a078-17b1b22ada46");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
			RealUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
			Name = "CityEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 370;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCityEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(2, CreateRegionEdit());
			MainControlLayout.InsertItem(3, CreateTimeZoneEdit());
			MainControlLayout.MoveItem(4, DescriptionEdit);
			MainControlLayout.MoveItem(5, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateCityEditPageEventsProcessSchema() {
			var schema = new CityEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateCountryEdit() {
			_countryEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_countryEdit.UId = new Guid("2feafcd3-e1f7-40f7-8e6f-1971f9441edf");
			_countryEdit.Name = "CountryEdit";
			_countryEdit.CreatedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
			_countryEdit.ModifiedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
			_countryEdit.CreatedInPackageId = Guid.Empty;
			_countryEdit.Tag = "";
			_countryEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_countryEdit.Image = new ControlImage {};
			_countryEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_countryEdit.DataSource = "DataSource";
			_countryEdit.ColumnUId = new Guid("0e3fbec3-cd69-41e4-bf05-b908e6a59282");
			return _countryEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateRegionEdit() {
			_regionEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_regionEdit.UId = new Guid("9b381c5c-327d-4de1-83ce-db5cc8a12eb8");
			_regionEdit.Name = "RegionEdit";
			_regionEdit.CreatedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
			_regionEdit.ModifiedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
			_regionEdit.CreatedInPackageId = Guid.Empty;
			_regionEdit.Tag = "";
			_regionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_regionEdit.Image = new ControlImage {};
			_regionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_regionEdit.DataSource = "DataSource";
			_regionEdit.ColumnUId = new Guid("4868bc57-e126-4b92-bab5-b68c423aaf21");
			return _regionEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateTimeZoneEdit() {
			_timeZoneEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_timeZoneEdit.UId = new Guid("20199bcc-5c28-48ce-bd61-9560c37861ff");
			_timeZoneEdit.Name = "TimeZoneEdit";
			_timeZoneEdit.CreatedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
			_timeZoneEdit.ModifiedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
			_timeZoneEdit.CreatedInPackageId = Guid.Empty;
			_timeZoneEdit.Tag = "";
			_timeZoneEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_timeZoneEdit.Image = new ControlImage {};
			_timeZoneEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_timeZoneEdit.DataSource = "DataSource";
			_timeZoneEdit.ColumnUId = new Guid("6a9df514-c9a1-46f5-aa58-2adb1e5f501a");
			return _timeZoneEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("5ca90b6a-93e7-4448-befe-ab5166ec2cfe");
			DataSource.ModifiedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("17231440-1bf2-4a07-9668-6fcabd946d3e");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
				column.ModifiedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("547ba551-cbcf-4651-b277-cd422f17fd00");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
				column.ModifiedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("6fdcc4b8-e6b5-4a2d-ad38-810bc3e1768b");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
				column.ModifiedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("bbcfd764-ec5a-4654-bc2c-d07b047e74aa");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
				column.ModifiedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("fd7aa59f-9c88-46c8-bb71-27a95f4acacb");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
				column.ModifiedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("a4a8ea0c-27e0-430c-891a-e334b616c6cb");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
				column.ModifiedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("505e8eef-a17b-47b6-a078-17b1b22ada46");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
				column.ModifiedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("8fb75ea2-14b8-4bb1-8420-f3a650b11962");
			if (column != null) {
				column.UId = new Guid("0e3fbec3-cd69-41e4-bf05-b908e6a59282");
				column.Name = @"Country";
				column.CreatedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
				column.ModifiedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b9be9a1a-dc05-4574-b391-b8377b8f82f8");
			if (column != null) {
				column.UId = new Guid("4868bc57-e126-4b92-bab5-b68c423aaf21");
				column.Name = @"Region";
				column.CreatedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
				column.ModifiedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("8ff41b5d-ef8e-4f95-bc96-07b5d595a3eb");
			if (column != null) {
				column.UId = new Guid("6a9df514-c9a1-46f5-aa58-2adb1e5f501a");
				column.Name = @"TimeZone";
				column.CreatedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
				column.ModifiedInSchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
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
			return new CityEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new CityEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CityEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: CityEditPageEventsProcess

	/// <exclude/>
	public class CityEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.CityEditPageSchemaUserControl
	{

		public CityEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CityEditPageEventsProcess";
			SchemaUId = new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("36f62a34-ace3-4bb8-8c15-7d1fc932d5b1");
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

	#region Class: CityEditPageEventsProcess

	/// <exclude/>
	public class CityEditPageEventsProcess : CityEditPageEventsProcess<Terrasoft.WebApp.CityEditPageSchemaUserControl>
	{

		public CityEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CityEditPageSchemaUserControl

	/// <exclude/>
	public partial class CityEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit CountryEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("CountryEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit RegionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("RegionEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit TimeZoneEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("TimeZoneEdit", true);
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
			var process = (CityEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new CityEditPageEventsProcess(UserConnection);
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
			SchemaName = "CityEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: CityEditPageEventsProcessSchema

	/// <exclude/>
	public class CityEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public CityEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CityEditPageEventsProcessSchema(CityEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CityEditPageEventsProcess";
			UId = new Guid("93ce7b64-2b5c-42db-a23c-a64ef23d278d");
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
			return new CityEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("93ce7b64-2b5c-42db-a23c-a64ef23d278d"));
		}

		#endregion

	}

	#endregion

}

