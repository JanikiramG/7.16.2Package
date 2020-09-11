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

	#region Class: AdministrationTeamEditPageSchema

	/// <exclude/>
	public class AdministrationTeamEditPageSchema : Terrasoft.WebApp.BaseAdministrationUnitEditPageSchema
	{

		#region Constructors: Public

		public AdministrationTeamEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AdministrationTeamEditPageSchema(AdministrationTeamEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ModifiedInSchemaUId = new Guid("5cc6b39d-d152-4768-91d7-ed417fca9073");
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
			LDAPEntryButton.ModifiedInSchemaUId = new Guid("5cc6b39d-d152-4768-91d7-ed417fca9073");
		}

		private void UpdateLDAPEntryEdit() {
			LDAPEntryEdit.Image = new ControlImage {};
			LDAPEntryEdit.ModifiedInSchemaUId = new Guid("5cc6b39d-d152-4768-91d7-ed417fca9073");
		}

		private void UpdateLDAPControlLayout() {
			LDAPControlLayout.Image = new ControlImage {};
			LDAPControlLayout.ModifiedInSchemaUId = new Guid("5cc6b39d-d152-4768-91d7-ed417fca9073");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("5cc6b39d-d152-4768-91d7-ed417fca9073");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("5cc6b39d-d152-4768-91d7-ed417fca9073");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("5cc6b39d-d152-4768-91d7-ed417fca9073");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("5cc6b39d-d152-4768-91d7-ed417fca9073");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("5cc6b39d-d152-4768-91d7-ed417fca9073");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("5cc6b39d-d152-4768-91d7-ed417fca9073");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("5cc6b39d-d152-4768-91d7-ed417fca9073");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("5cc6b39d-d152-4768-91d7-ed417fca9073");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5cc6b39d-d152-4768-91d7-ed417fca9073");
			RealUId = new Guid("5cc6b39d-d152-4768-91d7-ed417fca9073");
			Name = "AdministrationTeamEditPage";
			ParentSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			HelpContextId = "256";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAdministrationTeamEditPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateAdministrationTeamEditPageEventsProcessSchema() {
			var schema = new AdministrationTeamEditPageEventsProcessSchema(ProcessSchemaManager, this);
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
				column.ModifiedInSchemaUId = new Guid("5cc6b39d-d152-4768-91d7-ed417fca9073");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.IsAlwaysSelect = true;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("5cc6b39d-d152-4768-91d7-ed417fca9073");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("3678b2d1-343e-4e0c-8a93-f082143be510");
			if (column != null) {
				column.IsAlwaysSelect = true;
				column.ModifiedInSchemaUId = new Guid("5cc6b39d-d152-4768-91d7-ed417fca9073");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("a07a30ff-b3df-45db-a83c-bf89027250d8");
			if (column != null) {
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("5cc6b39d-d152-4768-91d7-ed417fca9073");
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new AdministrationTeamEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new AdministrationTeamEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5cc6b39d-d152-4768-91d7-ed417fca9073"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AdministrationTeamEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AdministrationTeamEditPageEventsProcess

	/// <exclude/>
	public class AdministrationTeamEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseAdministrationUnitEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AdministrationTeamEditPageSchemaUserControl
	{

		public AdministrationTeamEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdministrationTeamEditPageEventsProcess";
			SchemaUId = new Guid("5cc6b39d-d152-4768-91d7-ed417fca9073");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5cc6b39d-d152-4768-91d7-ed417fca9073");
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
			var parentRoleIdObj = Page.GetParameterValue("ParentRole");
			if (parentRoleIdObj != null) {
				var parentRoleId = new Guid(parentRoleIdObj.ToString());
				if (parentRoleId != Guid.Empty) {
					defValues["ParentRole"] = parentRoleId;
				}
			}
			if ((Guid)defValues["ParentRole"] != Guid.Empty) {
				var sysAdminUnit = new SysAdminUnit(Page.UserConnection);
				if (sysAdminUnit.FetchFromDB((Guid)defValues["ParentRole"])) {
					defValues["ConnectionType"] = sysAdminUnit.GetColumnValue("ConnectionType");
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

	#region Class: AdministrationTeamEditPageEventsProcess

	/// <exclude/>
	public class AdministrationTeamEditPageEventsProcess : AdministrationTeamEditPageEventsProcess<Terrasoft.WebApp.AdministrationTeamEditPageSchemaUserControl>
	{

		public AdministrationTeamEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdministrationTeamEditPageSchemaUserControl

	/// <exclude/>
	public partial class AdministrationTeamEditPageSchemaUserControl : Terrasoft.WebApp.BaseAdministrationUnitEditPageSchemaUserControl
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
			var process = (AdministrationTeamEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AdministrationTeamEditPageEventsProcess(UserConnection);
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
			SchemaName = "AdministrationTeamEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: AdministrationTeamEditPageEventsProcessSchema

	/// <exclude/>
	public class AdministrationTeamEditPageEventsProcessSchema : Terrasoft.WebApp.BaseAdministrationUnitEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public AdministrationTeamEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AdministrationTeamEditPageEventsProcessSchema(AdministrationTeamEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AdministrationTeamEditPageEventsProcess";
			UId = new Guid("305345da-ba3e-4821-8599-b8ad87bc7397");
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
			ProcessSchemaLaneSet schemaLaneSet2_ab89a139aa0242c78dac26e6062d530e = CreateLaneSet2_ab89a139aa0242c78dac26e6062d530eLaneSet();
			LaneSets.Add(schemaLaneSet2_ab89a139aa0242c78dac26e6062d530e);
			ProcessSchemaLane schemaLane1_baa83156cb234e998ad06b0a45109c5c = CreateLane1_baa83156cb234e998ad06b0a45109c5cLane();
			schemaLaneSet2_ab89a139aa0242c78dac26e6062d530e.Lanes.Add(schemaLane1_baa83156cb234e998ad06b0a45109c5c);
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_ab89a139aa0242c78dac26e6062d530eLaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_ab89a139aa0242c78dac26e6062d530e = new ProcessSchemaLaneSet(this) {
				UId = new Guid("ab89a139-aa02-42c7-8dac-26e6062d530e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("305345da-ba3e-4821-8599-b8ad87bc7397"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("305345da-ba3e-4821-8599-b8ad87bc7397"),
				Name = @"LaneSet2_ab89a139aa0242c78dac26e6062d530e",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_ab89a139aa0242c78dac26e6062d530e;
		}

		protected virtual ProcessSchemaLane CreateLane1_baa83156cb234e998ad06b0a45109c5cLane() {
			ProcessSchemaLane schemaLane1_baa83156cb234e998ad06b0a45109c5c = new ProcessSchemaLane(this) {
				UId = new Guid("baa83156-cb23-4e99-8ad0-6b0a45109c5c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab89a139-aa02-42c7-8dac-26e6062d530e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("305345da-ba3e-4821-8599-b8ad87bc7397"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("305345da-ba3e-4821-8599-b8ad87bc7397"),
				Name = @"Lane1_baa83156cb234e998ad06b0a45109c5c",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1_baa83156cb234e998ad06b0a45109c5c;
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
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,189,78,195,48,20,70,231,68,202,59,152,78,246,146,23,168,58,64,75,43,38,34,218,178,32,6,183,185,45,70,246,117,228,159,162,8,245,221,177,147,146,132,20,88,173,239,28,223,239,218,39,110,72,9,135,103,46,61,88,50,35,59,110,33,95,129,91,124,159,81,54,205,210,83,72,85,220,0,186,39,45,225,161,124,220,189,135,108,193,143,77,182,224,134,43,112,96,26,130,78,138,46,57,137,176,56,16,58,134,111,102,4,189,148,140,124,102,105,50,182,7,53,194,7,89,121,81,142,193,124,163,215,206,8,60,82,22,213,201,216,29,197,145,203,239,85,229,234,86,159,116,253,94,134,163,189,134,107,134,104,212,157,179,244,220,14,76,163,133,253,69,254,114,75,44,97,107,123,91,42,129,91,20,238,82,98,61,56,162,205,194,182,22,204,92,35,194,222,9,141,93,139,33,155,47,193,237,223,150,70,171,197,221,255,147,176,235,138,189,123,83,87,109,205,31,238,240,96,115,45,189,194,203,107,141,242,172,223,131,1,231,13,246,223,99,250,5,235,43,132,117,45,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AdministrationTeamEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("305345da-ba3e-4821-8599-b8ad87bc7397"));
		}

		#endregion

	}

	#endregion

}

