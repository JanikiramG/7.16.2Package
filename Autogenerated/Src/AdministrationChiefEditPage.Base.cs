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

	#region Class: AdministrationChiefEditPageSchema

	/// <exclude/>
	public class AdministrationChiefEditPageSchema : Terrasoft.WebApp.BaseAdministrationUnitEditPageSchema
	{

		#region Constructors: Public

		public AdministrationChiefEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AdministrationChiefEditPageSchema(AdministrationChiefEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("48e2ceab-1b0d-4dd3-9a63-f09ddc124210");
			NameEdit.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
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
			LDAPEntryButton.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
		}

		private void UpdateLDAPEntryEdit() {
			LDAPEntryEdit.Image = new ControlImage {};
			LDAPEntryEdit.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
		}

		private void UpdateLDAPControlLayout() {
			LDAPControlLayout.Image = new ControlImage {};
			LDAPControlLayout.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
			RealUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
			Name = "AdministrationChiefEditPage";
			ParentSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAdministrationChiefEditPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateAdministrationChiefEditPageEventsProcessSchema() {
			var schema = new AdministrationChiefEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("4c911290-a0d9-49b2-b793-1f155f40e3e8");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("a08256e0-0e43-4875-9b56-d5694c8810a6");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("5acd2cbd-dbae-475f-8397-c6fcb184b037");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("ac921122-42f5-4548-8837-d449272bc2e6");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("17600cba-b677-4adb-84be-f700462edcf5");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("48e2ceab-1b0d-4dd3-9a63-f09ddc124210");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("e0060cb2-41bd-4237-b4d6-8d5fe8cf3252");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3b1b6e4c-aa09-413c-9ded-a6ad81bb93c1");
			if (column != null) {
				column.UId = new Guid("530e37a6-64ea-4a7b-bd98-c647006f06a8");
				column.Name = @"SysAdminUnitType";
				column.CreatedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3678b2d1-343e-4e0c-8a93-f082143be510");
			if (column != null) {
				column.UId = new Guid("bb4afdcb-dca5-4678-8fb4-7f1af4e386ae");
				column.Name = @"ParentRole";
				column.CreatedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("45d5d808-1ad8-42bf-aaf2-177dcd2079c7");
			if (column != null) {
				column.UId = new Guid("9d9200ad-e20d-4fab-b4d6-c89aa0e4ef41");
				column.Name = @"Account";
				column.CreatedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("72a7351e-36cf-40f9-b334-0a7563bd60fb");
			if (column != null) {
				column.UId = new Guid("93000b71-ea0b-4823-a9c7-ced59dadfaac");
				column.Name = @"IsDirectoryEntry";
				column.CreatedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("8280981b-5189-40a1-b700-6a35c572dba2");
			if (column != null) {
				column.UId = new Guid("f16176d9-451a-4df4-b5d2-445145f28dd3");
				column.Name = @"TimeZone";
				column.CreatedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("a07a30ff-b3df-45db-a83c-bf89027250d8");
			if (column != null) {
				column.UId = new Guid("b0d6f9d6-2771-46bf-8d9e-7931c67af91f");
				column.Name = @"UserPassword";
				column.CreatedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("a986b074-459c-40b1-b4b6-0e286b3ef123");
			if (column != null) {
				column.UId = new Guid("6dda7626-ae96-40d2-9484-87aa3e4d96a0");
				column.Name = @"Active";
				column.CreatedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
				column.ModifiedInSchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
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
			return new AdministrationChiefEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new AdministrationChiefEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AdministrationChiefEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AdministrationChiefEditPageEventsProcess

	/// <exclude/>
	public class AdministrationChiefEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseAdministrationUnitEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AdministrationChiefEditPageSchemaUserControl
	{

		public AdministrationChiefEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdministrationChiefEditPageEventsProcess";
			SchemaUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
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

	#region Class: AdministrationChiefEditPageEventsProcess

	/// <exclude/>
	public class AdministrationChiefEditPageEventsProcess : AdministrationChiefEditPageEventsProcess<Terrasoft.WebApp.AdministrationChiefEditPageSchemaUserControl>
	{

		public AdministrationChiefEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdministrationChiefEditPageSchemaUserControl

	/// <exclude/>
	public partial class AdministrationChiefEditPageSchemaUserControl : Terrasoft.WebApp.BaseAdministrationUnitEditPageSchemaUserControl
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
			var process = (AdministrationChiefEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AdministrationChiefEditPageEventsProcess(UserConnection);
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
			SchemaName = "AdministrationChiefEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: AdministrationChiefEditPageEventsProcessSchema

	/// <exclude/>
	public class AdministrationChiefEditPageEventsProcessSchema : Terrasoft.WebApp.BaseAdministrationUnitEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public AdministrationChiefEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AdministrationChiefEditPageEventsProcessSchema(AdministrationChiefEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AdministrationChiefEditPageEventsProcess";
			UId = new Guid("fd7ff559-5d8a-4c45-a8e4-99abea1cd91c");
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
			ProcessSchemaLaneSet schemaLaneSet2_9e100672b8694ef694016206d40bf667 = CreateLaneSet2_9e100672b8694ef694016206d40bf667LaneSet();
			LaneSets.Add(schemaLaneSet2_9e100672b8694ef694016206d40bf667);
			ProcessSchemaLane schemaLane1_9c4c16e6d56440ee8ae98d884f651c38 = CreateLane1_9c4c16e6d56440ee8ae98d884f651c38Lane();
			schemaLaneSet2_9e100672b8694ef694016206d40bf667.Lanes.Add(schemaLane1_9c4c16e6d56440ee8ae98d884f651c38);
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_9e100672b8694ef694016206d40bf667LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_9e100672b8694ef694016206d40bf667 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("9e100672-b869-4ef6-9401-6206d40bf667"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("fd7ff559-5d8a-4c45-a8e4-99abea1cd91c"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("fd7ff559-5d8a-4c45-a8e4-99abea1cd91c"),
				Name = @"LaneSet2_9e100672b8694ef694016206d40bf667",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_9e100672b8694ef694016206d40bf667;
		}

		protected virtual ProcessSchemaLane CreateLane1_9c4c16e6d56440ee8ae98d884f651c38Lane() {
			ProcessSchemaLane schemaLane1_9c4c16e6d56440ee8ae98d884f651c38 = new ProcessSchemaLane(this) {
				UId = new Guid("9c4c16e6-d564-40ee-8ae9-8d884f651c38"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9e100672-b869-4ef6-9401-6206d40bf667"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("fd7ff559-5d8a-4c45-a8e4-99abea1cd91c"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("fd7ff559-5d8a-4c45-a8e4-99abea1cd91c"),
				Name = @"Lane1_9c4c16e6d56440ee8ae98d884f651c38",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1_9c4c16e6d56440ee8ae98d884f651c38;
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
			return new AdministrationChiefEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fd7ff559-5d8a-4c45-a8e4-99abea1cd91c"));
		}

		#endregion

	}

	#endregion

}

