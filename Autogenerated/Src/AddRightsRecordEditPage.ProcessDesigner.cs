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
	using System.Text;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: AddRightsRecordEditPageSchema

	/// <exclude/>
	public class AddRightsRecordEditPageSchema : Terrasoft.WebApp.DeleteRightsRecordEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _operationRightLevelControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout OperationRightLevelControlLayout {
			get {
				return _operationRightLevelControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _allowRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton AllowRadioButton {
			get {
				return _allowRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _allowAndGrantRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton AllowAndGrantRadioButton {
			get {
				return _allowAndGrantRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _denyRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton DenyRadioButton {
			get {
				return _denyRadioButton;
			}
		}

		#endregion

		#region Constructors: Public

		public AddRightsRecordEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AddRightsRecordEditPageSchema(AddRightsRecordEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateOperationsControlLayout() {
			OperationsControlLayout.Image = new ControlImage {};
			OperationsControlLayout.ModifiedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
		}

		private void UpdateRolesRadioButton() {
			RolesRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
		}

		private void UpdateRolesParameterValueEdit() {
			RolesParameterValueEdit.Image = new ControlImage {};
			RolesParameterValueEdit.ModifiedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
		}

		private void UpdateControlLayout5() {
			ControlLayout5.Image = new ControlImage {};
			ControlLayout5.ModifiedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
		}

		private void UpdateControlLayout2() {
			ControlLayout2.Image = new ControlImage {};
			ControlLayout2.ModifiedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
		}

		private void UpdateEmployeeRadioButton() {
			EmployeeRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
		}

		private void UpdateEmployeeParameterValueEdit() {
			EmployeeParameterValueEdit.Image = new ControlImage {};
			EmployeeParameterValueEdit.ModifiedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
		}

		private void UpdateControlLayout7() {
			ControlLayout7.Image = new ControlImage {};
			ControlLayout7.ModifiedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
		}

		private void UpdateControlLayout3() {
			ControlLayout3.Image = new ControlImage {};
			ControlLayout3.ModifiedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
		}

		private void UpdateEmployeesRadioButton() {
			EmployeesRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
		}

		private void UpdateControlLayout9() {
			ControlLayout9.Image = new ControlImage {};
			ControlLayout9.ModifiedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
		}

		private void UpdateControlLayout4() {
			ControlLayout4.Image = new ControlImage {};
			ControlLayout4.ModifiedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
		}

		private void UpdateAllRolesAndUsersRadioButton() {
			AllRolesAndUsersRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
		}

		private void UpdateControlLayout1() {
			ControlLayout1.Image = new ControlImage {};
			ControlLayout1.Enabled = false;
			ControlLayout1.Hidden = true;
			ControlLayout1.ModifiedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
		}

		private void UpdateRemoveRightsControlLayout() {
			RemoveRightsControlLayout.Image = new ControlImage {};
			RemoveRightsControlLayout.ModifiedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
			RealUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
			Name = "AddRightsRecordEditPage";
			ParentSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			Height = 500;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAddRightsRecordEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateButtonsControlLayout();
			UpdateCancelButton();
			UpdateOkButton();
			UpdateMainControlLayout();
			UpdateRemoveRightsControlLayout();
			UpdateControlLayout1();
			UpdateAllRolesAndUsersRadioButton();
			UpdateControlLayout4();
			UpdateControlLayout9();
			UpdateEmployeesRadioButton();
			UpdateControlLayout3();
			UpdateControlLayout7();
			UpdateEmployeeParameterValueEdit();
			UpdateEmployeeRadioButton();
			UpdateControlLayout2();
			UpdateControlLayout5();
			UpdateRolesParameterValueEdit();
			UpdateRolesRadioButton();
			UpdateOperationsControlLayout();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, OperationsControlLayout);
			OperationsControlLayout.MoveItem(0, RightToReadCheckBox);
			OperationsControlLayout.MoveItem(1, RightToChangeCheckBox);
			OperationsControlLayout.MoveItem(2, RightToRemoveCheckBox);
			MainControlLayout.InsertItem(1, CreateOperationRightLevelControlLayout());
			OperationRightLevelControlLayout.InsertItem(0, CreateAllowRadioButton());
			OperationRightLevelControlLayout.InsertItem(1, CreateAllowAndGrantRadioButton());
			OperationRightLevelControlLayout.InsertItem(2, CreateDenyRadioButton());
			MainControlLayout.MoveItem(2, RemoveRightsControlLayout);
			RemoveRightsControlLayout.MoveItem(0, ControlLayout2);
			ControlLayout2.MoveItem(0, RolesRadioButton);
			ControlLayout2.MoveItem(1, ControlLayout5);
			ControlLayout5.MoveItem(0, RolesParameterValueEdit);
			RemoveRightsControlLayout.MoveItem(1, ControlLayout3);
			ControlLayout3.MoveItem(0, EmployeeRadioButton);
			ControlLayout3.MoveItem(1, ControlLayout7);
			ControlLayout7.MoveItem(0, EmployeeParameterValueEdit);
			RemoveRightsControlLayout.MoveItem(2, ControlLayout4);
			ControlLayout4.MoveItem(0, EmployeesRadioButton);
			ControlLayout4.MoveItem(1, ControlLayout9);
			ControlLayout9.MoveItem(0, ContactFilterEdit);
			RemoveRightsControlLayout.MoveItem(3, ControlLayout1);
			ControlLayout1.MoveItem(0, AllRolesAndUsersRadioButton);
			TopLevelControl.MoveItem(2, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, Spacer1);
			ButtonsControlLayout.MoveItem(1, OkButton);
			ButtonsControlLayout.MoveItem(2, CancelButton);
			TopLevelControl.MoveItem(3, EntityDataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateAddRightsRecordEditPageEventsProcessSchema() {
			var schema = new AddRightsRecordEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateAllowRadioButton() {
			_allowRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_allowRadioButton.UId = new Guid("c8342c16-fd7a-4500-bd38-807635c99aa2");
			_allowRadioButton.Name = "AllowRadioButton";
			_allowRadioButton.CreatedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
			_allowRadioButton.ModifiedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
			_allowRadioButton.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_allowRadioButton.Tag = "";
			_allowRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_allowRadioButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_allowRadioButton.GroupName = "OperationRightLevelGroup";
			return _allowRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateAllowAndGrantRadioButton() {
			_allowAndGrantRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_allowAndGrantRadioButton.UId = new Guid("f0a00190-0c23-425a-a8e5-80a9800e6e57");
			_allowAndGrantRadioButton.Name = "AllowAndGrantRadioButton";
			_allowAndGrantRadioButton.CreatedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
			_allowAndGrantRadioButton.ModifiedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
			_allowAndGrantRadioButton.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_allowAndGrantRadioButton.Tag = "";
			_allowAndGrantRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_allowAndGrantRadioButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_allowAndGrantRadioButton.GroupName = "OperationRightLevelGroup";
			return _allowAndGrantRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateDenyRadioButton() {
			_denyRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_denyRadioButton.UId = new Guid("0c5d8d34-05ef-47d6-813f-106246d05462");
			_denyRadioButton.Name = "DenyRadioButton";
			_denyRadioButton.CreatedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
			_denyRadioButton.ModifiedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
			_denyRadioButton.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_denyRadioButton.Tag = "";
			_denyRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_denyRadioButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_denyRadioButton.GroupName = "OperationRightLevelGroup";
			return _denyRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateOperationRightLevelControlLayout() {
			_operationRightLevelControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_operationRightLevelControlLayout.UId = new Guid("1153c300-2bba-47b1-b266-979021c34dd2");
			_operationRightLevelControlLayout.Name = "OperationRightLevelControlLayout";
			_operationRightLevelControlLayout.CreatedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
			_operationRightLevelControlLayout.ModifiedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
			_operationRightLevelControlLayout.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_operationRightLevelControlLayout.Tag = "";
			_operationRightLevelControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(100);
			_operationRightLevelControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_operationRightLevelControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_operationRightLevelControlLayout.StartNewAlignGroup = false;
			_operationRightLevelControlLayout.Image = new ControlImage {};
			_operationRightLevelControlLayout.Edges = "";
			return _operationRightLevelControlLayout;
		}

		protected override void UpdateEntityDataSource() {
			base.UpdateEntityDataSource();
			DataSourceStructureColumn column = null;
			column = EntityDataSource.DefStructure.Columns.FindByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.IsAlwaysSelect = true;
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
			}
			column = EntityDataSource.DefStructure.Columns.FindByMetaPath("a5cca792-47dd-428a-83fb-5c92bdd97ff8");
			if (column != null) {
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new AddRightsRecordEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new AddRightsRecordEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AddRightsRecordEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AddRightsRecordEditPageEventsProcess

	/// <exclude/>
	public class AddRightsRecordEditPageEventsProcess<TPage> : Terrasoft.WebApp.DeleteRightsRecordEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AddRightsRecordEditPageSchemaUserControl
	{

		public AddRightsRecordEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AddRightsRecordEditPageEventsProcess";
			SchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
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

		public virtual Guid EntitySchemaUId {
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

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "EntitySchemaUId":
					EntitySchemaUId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public override void AssignEditedItem(Dictionary<string, object> item) {
			base.AssignEditedItem(item);
			string operationRightLevel = "OperationRightLevel";
			string value;
			if (Page.AllowRadioButton.Checked) {
				value = ((int)EntitySchemaRecordRightLevel.Allow).ToString();
				item.Add(operationRightLevel, value);
				return;
			}
			if (Page.AllowAndGrantRadioButton.Checked) {
				value = ((int)EntitySchemaRecordRightLevel.AllowAndGrant).ToString();
				item.Add(operationRightLevel, value);
				return;
			}
			if (Page.DenyRadioButton.Checked) {
				value = ((int)EntitySchemaRecordRightLevel.Deny).ToString();
				item.Add(operationRightLevel, value);
				return;
			}
		}

		public override void AssignControlValues(Dictionary<string, object> item) {
			base.AssignControlValues(item);
			if (item == null) {
				Page.AllowRadioButton.Checked = true;
				return;
			}
			var operationRightLevel = (string)item["OperationRightLevel"];
			var rightLevel = (EntitySchemaRecordRightLevel)Enum
				.Parse(typeof(EntitySchemaRecordRightLevel), operationRightLevel);
			if (rightLevel == EntitySchemaRecordRightLevel.Deny) {
				Page.DenyRadioButton.Checked = true;
			} else if (rightLevel == EntitySchemaRecordRightLevel.Allow) {
				Page.AllowRadioButton.Checked = true;
			} else if (rightLevel == EntitySchemaRecordRightLevel.AllowAndGrant) {
				Page.AllowAndGrantRadioButton.Checked = true;
			}
		}

		public override void HandleOnPageLoaded() {
			EntitySchemaUId = new Guid(Page.GetParameterValue("entitySchemaUId").ToString());
			EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(EntitySchemaUId);
			Page.DenyRadioButton.Enabled = entitySchema.UseDenyRecordRights;
			base.HandleOnPageLoaded();
			if (string.IsNullOrEmpty(ItemId)) {
				Page.AllRolesAndUsersRadioButton.Checked = false;
				Page.RolesRadioButton.Checked = true;
				Page.RolesParameterValueEdit.Enabled = true;
				Page.RolesParameterValueEdit.SetRequired(true);
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("EntitySchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntitySchemaUId", EntitySchemaUId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: AddRightsRecordEditPageEventsProcess

	/// <exclude/>
	public class AddRightsRecordEditPageEventsProcess : AddRightsRecordEditPageEventsProcess<Terrasoft.WebApp.AddRightsRecordEditPageSchemaUserControl>
	{

		public AddRightsRecordEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AddRightsRecordEditPageSchemaUserControl

	/// <exclude/>
	public partial class AddRightsRecordEditPageSchemaUserControl : Terrasoft.WebApp.DeleteRightsRecordEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout OperationRightLevelControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("OperationRightLevelControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton AllowRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("AllowRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton AllowAndGrantRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("AllowAndGrantRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton DenyRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("DenyRadioButton", true);
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
			var process = (AddRightsRecordEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AddRightsRecordEditPageEventsProcess(UserConnection);
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
			SchemaName = "AddRightsRecordEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: AddRightsRecordEditPageEventsProcessSchema

	/// <exclude/>
	public class AddRightsRecordEditPageEventsProcessSchema : Terrasoft.WebApp.DeleteRightsRecordEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public AddRightsRecordEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AddRightsRecordEditPageEventsProcessSchema(AddRightsRecordEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AddRightsRecordEditPageEventsProcess";
			UId = new Guid("890de03d-9ff8-4fdb-bb9f-4a9fbf723053");
			CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3f6b5ffe-4d23-40c8-9718-2066a60dca0e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("890de03d-9ff8-4fdb-bb9f-4a9fbf723053"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("890de03d-9ff8-4fdb-bb9f-4a9fbf723053"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEntitySchemaUIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet2 = CreateLaneSet2LaneSet();
			LaneSets.Add(schemaLaneSet2);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet2.Lanes.Add(schemaLane1);
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("1e499899-902d-45ec-87d8-99f7a70126a0"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("890de03d-9ff8-4fdb-bb9f-4a9fbf723053"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("890de03d-9ff8-4fdb-bb9f-4a9fbf723053"),
				Name = @"LaneSet2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1197, 150),
				UseBackgroundMode = false
			};
			return schemaLaneSet2;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("bfc512cc-b2c1-4110-b89b-b04757ff89c3"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("1e499899-902d-45ec-87d8-99f7a70126a0"),
				CreatedInOwnerSchemaUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("890de03d-9ff8-4fdb-bb9f-4a9fbf723053"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("890de03d-9ff8-4fdb-bb9f-4a9fbf723053"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1168, 150),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("bbade363-be8c-4c87-8b52-f1efacd7aed4"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ecb18468-0b11-44f0-b175-94ba323f9853"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("14b62c8a-1e84-40df-8dd4-8fc7c0ca4094"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("bd64efde-bc13-41d8-81af-d97e15a6cd80"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ec439e80-3be7-4fa6-87dc-2510c7bf0362"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
		}

		protected override SchemaMethod CreateAssignEditedItemMethod() {
			SchemaMethod method = base.CreateAssignEditedItemMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,206,193,10,130,64,16,6,224,179,66,239,176,116,90,33,124,129,232,96,37,17,4,133,245,2,155,59,233,144,206,198,58,26,17,189,123,171,17,66,117,203,219,236,50,243,255,223,81,85,16,70,85,133,25,197,26,25,244,154,161,148,110,40,131,233,200,175,216,34,101,194,92,192,42,70,67,9,102,57,111,160,129,66,204,196,120,251,253,61,238,143,26,85,212,224,158,120,18,114,167,50,215,82,20,230,154,40,141,102,94,51,27,10,23,57,164,103,208,129,184,143,124,175,91,119,169,82,34,113,16,19,35,223,246,105,14,165,74,32,53,86,247,29,175,160,32,60,152,125,215,36,91,169,215,146,195,72,107,249,3,59,121,97,186,61,11,92,91,114,211,227,147,22,145,94,89,69,60,24,241,29,56,40,117,9,116,27,66,216,230,252,15,123,2,52,175,144,123,63,2,0,0 };
			return method;
		}

		protected override SchemaMethod CreateAssignControlValuesMethod() {
			SchemaMethod method = base.CreateAssignControlValuesMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,145,207,106,195,48,12,135,207,13,228,29,68,79,9,140,188,64,201,161,235,202,46,133,150,12,118,25,59,120,137,154,152,57,82,145,229,142,48,250,238,115,59,202,186,63,4,202,110,178,208,167,79,252,252,98,60,22,115,239,109,75,11,38,21,118,143,198,5,244,153,85,236,243,89,154,216,45,156,106,40,75,160,224,92,14,239,105,50,217,152,54,98,206,241,91,101,26,203,183,65,149,169,88,116,88,191,98,3,37,168,4,140,240,68,80,131,80,172,14,105,178,55,2,188,67,49,106,153,42,219,118,186,194,61,186,56,157,121,21,75,109,126,244,60,77,215,191,103,166,207,179,79,94,190,97,75,82,171,195,67,221,97,111,42,172,89,154,47,36,95,82,232,227,5,197,198,136,199,76,135,29,242,118,156,184,249,235,188,115,6,151,230,18,198,246,20,119,72,195,69,76,199,231,104,74,7,64,231,17,174,180,156,210,191,234,55,254,225,153,83,115,47,134,244,167,239,220,31,247,126,0,155,75,205,231,101,2,0,0 };
			return method;
		}

		protected override SchemaMethod CreateHandleOnPageLoadedMethod() {
			SchemaMethod method = base.CreateHandleOnPageLoadedMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,189,78,195,48,16,199,103,42,245,29,162,78,206,226,23,168,24,218,18,149,72,64,171,132,178,95,227,107,98,225,156,193,62,11,69,136,119,199,182,132,148,34,6,230,251,253,191,174,34,214,60,181,221,128,35,156,106,85,220,22,132,31,197,62,104,37,142,208,163,220,35,31,193,193,136,140,238,5,76,64,177,194,107,201,170,148,207,182,101,167,169,23,101,185,94,46,170,217,189,152,195,209,252,228,209,237,44,17,118,172,45,201,57,250,8,20,3,93,74,172,201,51,80,135,219,41,250,139,234,58,47,69,228,106,119,72,83,3,74,219,109,96,206,102,112,54,152,38,204,67,101,140,204,36,118,214,169,70,247,3,251,232,112,6,143,242,30,72,25,60,80,178,123,176,160,80,137,228,174,47,133,240,121,144,172,253,83,48,230,224,170,241,141,39,81,51,142,177,64,89,124,46,23,55,185,195,198,152,198,26,244,27,82,105,154,159,247,217,13,216,189,230,62,23,48,30,215,63,154,44,248,27,100,23,126,113,215,207,175,148,230,217,206,127,225,45,114,131,239,65,187,184,46,9,210,194,175,111,44,24,76,197,247,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AddRightsRecordEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("890de03d-9ff8-4fdb-bb9f-4a9fbf723053"));
		}

		#endregion

	}

	#endregion

}

