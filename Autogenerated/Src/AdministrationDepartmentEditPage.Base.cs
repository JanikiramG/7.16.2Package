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
	using System.Linq;
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

	#region Class: AdministrationDepartmentEditPageSchema

	/// <exclude/>
	public class AdministrationDepartmentEditPageSchema : Terrasoft.WebApp.BaseAdministrationUnitEditPageSchema
	{

		#region Constructors: Public

		public AdministrationDepartmentEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AdministrationDepartmentEditPageSchema(AdministrationDepartmentEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ModifiedInSchemaUId = new Guid("921acc0b-bc2d-4d46-8422-3a3cd2c99b79");
		}

		private void UpdateSynchronizeWithLDAPCheckBox() {
			SynchronizeWithLDAPCheckBox.AjaxEvents.Check.IsProcessEventHandler = true;
		}

		private void UpdateLDAPEntryButton() {
			LDAPEntryButton.AjaxEvents.Click.IsProcessEventHandler = true;
			LDAPEntryButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2"),
				ItemUId = new Guid("ceeaa064-ff61-470b-8fac-088d723602d5"),
				ImageHash = @"54ac1a2d1db28aa44e6b7837c54cc5e6"
			};
			LDAPEntryButton.ModifiedInSchemaUId = new Guid("921acc0b-bc2d-4d46-8422-3a3cd2c99b79");
		}

		private void UpdateLDAPEntryEdit() {
			LDAPEntryEdit.Image = new ControlImage {};
			LDAPEntryEdit.ModifiedInSchemaUId = new Guid("921acc0b-bc2d-4d46-8422-3a3cd2c99b79");
		}

		private void UpdateLDAPControlLayout() {
			LDAPControlLayout.Image = new ControlImage {};
			LDAPControlLayout.ModifiedInSchemaUId = new Guid("921acc0b-bc2d-4d46-8422-3a3cd2c99b79");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("921acc0b-bc2d-4d46-8422-3a3cd2c99b79");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("921acc0b-bc2d-4d46-8422-3a3cd2c99b79");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("921acc0b-bc2d-4d46-8422-3a3cd2c99b79");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("921acc0b-bc2d-4d46-8422-3a3cd2c99b79");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("921acc0b-bc2d-4d46-8422-3a3cd2c99b79");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("921acc0b-bc2d-4d46-8422-3a3cd2c99b79");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("921acc0b-bc2d-4d46-8422-3a3cd2c99b79");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("921acc0b-bc2d-4d46-8422-3a3cd2c99b79");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("921acc0b-bc2d-4d46-8422-3a3cd2c99b79");
			RealUId = new Guid("921acc0b-bc2d-4d46-8422-3a3cd2c99b79");
			Name = "AdministrationDepartmentEditPage";
			ParentSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAdministrationDepartmentEditPageEventsProcessSchema();
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
			UpdateLDAPControlLayout();
			UpdateLDAPEntryEdit();
			UpdateLDAPEntryButton();
			UpdateSynchronizeWithLDAPCheckBox();
			UpdateNameEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, NameEdit);
			MainControlLayout.MoveItem(1, LDAPControlLayout);
			LDAPControlLayout.MoveItem(0, SynchronizeWithLDAPCheckBox);
			LDAPControlLayout.MoveItem(1, LDAPEntryEdit);
			LDAPEntryEdit.MoveItem(0, LDAPEntryButton);
			MainControlLayout.MoveItem(2, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateAdministrationDepartmentEditPageEventsProcessSchema() {
			var schema = new AdministrationDepartmentEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.Columns.FindByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.IsAlwaysSelect = true;
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("921acc0b-bc2d-4d46-8422-3a3cd2c99b79");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.IsAlwaysSelect = true;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("921acc0b-bc2d-4d46-8422-3a3cd2c99b79");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("3678b2d1-343e-4e0c-8a93-f082143be510");
			if (column != null) {
				column.IsAlwaysSelect = true;
				column.ModifiedInSchemaUId = new Guid("921acc0b-bc2d-4d46-8422-3a3cd2c99b79");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("a07a30ff-b3df-45db-a83c-bf89027250d8");
			if (column != null) {
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("921acc0b-bc2d-4d46-8422-3a3cd2c99b79");
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new AdministrationDepartmentEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new AdministrationDepartmentEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("921acc0b-bc2d-4d46-8422-3a3cd2c99b79"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AdministrationDepartmentEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AdministrationDepartmentEditPageEventsProcess

	/// <exclude/>
	public class AdministrationDepartmentEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseAdministrationUnitEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AdministrationDepartmentEditPageSchemaUserControl
	{

		public AdministrationDepartmentEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdministrationDepartmentEditPageEventsProcess";
			SchemaUId = new Guid("921acc0b-bc2d-4d46-8422-3a3cd2c99b79");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("921acc0b-bc2d-4d46-8422-3a3cd2c99b79");
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

		public override Dictionary<string, object> GetDefValues() {
			var defValues = base.GetDefValues();
			if (defValues.ContainsKey("ParentRole")) {
				var parentRoleId = new Guid(defValues["ParentRole"].ToString());
				var entitySchemaManager = UserConnection.EntitySchemaManager;
				var query = new EntitySchemaQuery(entitySchemaManager, "SysAdminUnit");
				var accountColumnName = query.AddColumn("Account.Id").Name;
				query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, query.RootSchema.GetPrimaryColumnName(),	parentRoleId));
				var entities = query.GetEntityCollection(UserConnection);
				if (entities.Count > 0) {
					Guid accountId = entities[0].GetTypedColumnValue<Guid>(accountColumnName);
					if (!accountId.Equals(Guid.Empty)) {
						defValues["Account"] = accountId;
					}
				}
			}
			return defValues;
		}

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

	#region Class: AdministrationDepartmentEditPageEventsProcess

	/// <exclude/>
	public class AdministrationDepartmentEditPageEventsProcess : AdministrationDepartmentEditPageEventsProcess<Terrasoft.WebApp.AdministrationDepartmentEditPageSchemaUserControl>
	{

		public AdministrationDepartmentEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdministrationDepartmentEditPageSchemaUserControl

	/// <exclude/>
	public partial class AdministrationDepartmentEditPageSchemaUserControl : Terrasoft.WebApp.BaseAdministrationUnitEditPageSchemaUserControl
	{

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
			var process = (AdministrationDepartmentEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AdministrationDepartmentEditPageEventsProcess(UserConnection);
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
			SchemaName = "AdministrationDepartmentEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: AdministrationDepartmentEditPageEventsProcessSchema

	/// <exclude/>
	public class AdministrationDepartmentEditPageEventsProcessSchema : Terrasoft.WebApp.BaseAdministrationUnitEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public AdministrationDepartmentEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AdministrationDepartmentEditPageEventsProcessSchema(AdministrationDepartmentEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AdministrationDepartmentEditPageEventsProcess";
			UId = new Guid("9cfa95bf-b893-4ab6-a416-f4f7b728a9a1");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet2_bee6a8ddb13144648a867c0745ad9a77 = CreateLaneSet2_bee6a8ddb13144648a867c0745ad9a77LaneSet();
			LaneSets.Add(schemaLaneSet2_bee6a8ddb13144648a867c0745ad9a77);
			ProcessSchemaLane schemaLane1_d94093d4e8bf496c82028aae234170ef = CreateLane1_d94093d4e8bf496c82028aae234170efLane();
			schemaLaneSet2_bee6a8ddb13144648a867c0745ad9a77.Lanes.Add(schemaLane1_d94093d4e8bf496c82028aae234170ef);
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_bee6a8ddb13144648a867c0745ad9a77LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_bee6a8ddb13144648a867c0745ad9a77 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("bee6a8dd-b131-4464-8a86-7c0745ad9a77"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("9cfa95bf-b893-4ab6-a416-f4f7b728a9a1"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("9cfa95bf-b893-4ab6-a416-f4f7b728a9a1"),
				Name = @"LaneSet2_bee6a8ddb13144648a867c0745ad9a77",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_bee6a8ddb13144648a867c0745ad9a77;
		}

		protected virtual ProcessSchemaLane CreateLane1_d94093d4e8bf496c82028aae234170efLane() {
			ProcessSchemaLane schemaLane1_d94093d4e8bf496c82028aae234170ef = new ProcessSchemaLane(this) {
				UId = new Guid("d94093d4-e8bf-496c-8202-8aae234170ef"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bee6a8dd-b131-4464-8a86-7c0745ad9a77"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("9cfa95bf-b893-4ab6-a416-f4f7b728a9a1"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("9cfa95bf-b893-4ab6-a416-f4f7b728a9a1"),
				Name = @"Lane1_d94093d4e8bf496c82028aae234170ef",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1_d94093d4e8bf496c82028aae234170ef;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9172e0a8-be67-4466-bee9-4324d80b45f1"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0127c4ec-c32d-490a-92db-dac6957dd282"),
				Name = "System.Linq",
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

		protected override SchemaMethod CreateGetDefValuesMethod() {
			SchemaMethod method = base.CreateGetDefValuesMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,82,93,107,194,48,20,125,174,224,127,200,250,148,130,4,223,221,4,233,156,200,216,112,234,182,7,241,33,107,175,26,104,19,77,83,71,25,251,239,187,73,218,218,205,65,219,135,219,243,113,115,78,206,92,147,20,118,111,60,43,161,32,119,228,131,23,192,102,96,238,155,25,141,70,253,158,216,17,218,162,88,172,164,225,66,22,143,80,209,112,193,53,72,179,84,25,132,81,68,190,250,189,224,140,146,199,118,58,79,81,85,194,39,153,149,34,189,136,108,186,196,45,91,171,149,209,66,238,105,100,237,156,4,254,20,166,90,37,7,200,249,19,151,124,15,26,149,94,11,208,232,47,33,49,66,73,54,189,6,53,252,83,9,186,170,189,187,176,23,59,167,255,168,15,72,184,170,138,73,154,11,249,42,133,9,219,77,120,146,168,82,154,88,101,101,46,159,121,14,168,234,212,217,36,77,253,148,134,19,15,98,243,52,140,152,5,89,182,71,61,136,204,128,46,44,154,250,73,172,129,27,240,243,119,97,14,152,5,50,44,136,250,97,172,114,140,80,20,74,174,171,35,176,233,169,228,217,160,54,93,42,101,252,226,182,168,133,22,57,215,213,101,57,26,13,130,110,252,127,18,21,174,102,175,132,116,159,12,178,51,159,40,253,29,176,227,218,246,27,46,150,143,167,36,99,50,244,101,7,182,214,38,33,215,117,131,220,12,183,214,192,238,95,135,228,154,191,181,132,49,189,202,212,57,57,171,155,86,205,159,187,160,150,194,166,249,209,84,245,21,11,130,206,69,170,147,15,183,104,222,82,157,218,55,126,240,197,71,131,41,181,188,220,244,209,15,208,137,14,76,248,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AdministrationDepartmentEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9cfa95bf-b893-4ab6-a416-f4f7b728a9a1"));
		}

		#endregion

	}

	#endregion

}

