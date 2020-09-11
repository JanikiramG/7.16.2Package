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

	#region Class: OppContactMotivatorsEditPageSchema

	/// <exclude/>
	public class OppContactMotivatorsEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.LookupEdit _typeEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit TypeEdit {
			get {
				return _typeEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public OppContactMotivatorsEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public OppContactMotivatorsEditPageSchema(OppContactMotivatorsEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("0c5fee15-bb38-4b19-af64-1d13edd1c830");
			NameEdit.ModifiedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("eae9ca25-0f51-4654-9e1d-02a97c7ac2ea");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
			RealUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
			Name = "OppContactMotivatorsEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOppContactMotivatorsEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(1, CreateTypeEdit());
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

		protected virtual EmbeddedProcessSchema CreateOppContactMotivatorsEditPageEventsProcessSchema() {
			var schema = new OppContactMotivatorsEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateTypeEdit() {
			_typeEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_typeEdit.UId = new Guid("b56068a7-7a14-4c41-914e-9785f3a73659");
			_typeEdit.Name = "TypeEdit";
			_typeEdit.CreatedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
			_typeEdit.ModifiedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
			_typeEdit.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			_typeEdit.Tag = "";
			_typeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_typeEdit.Image = new ControlImage {};
			_typeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_typeEdit.DataSource = "DataSource";
			_typeEdit.ColumnUId = new Guid("236b02f1-3c7b-401b-b4fe-1be5f435cda9");
			_typeEdit.Required = true;
			return _typeEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("16ab0b58-3f64-418d-849c-bf9ccd3b3bb6");
			DataSource.ModifiedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("978f8d4a-901e-4ec3-94cd-4f9e58e7029f");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
				column.ModifiedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("5b936678-eea6-41a3-96f6-8da0bddd7fd6");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
				column.ModifiedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("0ae45143-6d1a-408e-bf20-88126dbdebf1");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
				column.ModifiedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("b311644f-59ae-4c2c-84e3-53de12c015bd");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
				column.ModifiedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("5acc6f76-6e8b-4654-b670-bf03a6b9891e");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
				column.ModifiedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("0c5fee15-bb38-4b19-af64-1d13edd1c830");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
				column.ModifiedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("eae9ca25-0f51-4654-9e1d-02a97c7ac2ea");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
				column.ModifiedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("574c37e0-6844-466b-ada9-1208387aacc5");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
				column.ModifiedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("5c9ccd90-06fc-4547-9eb4-c63723b2d23e");
			if (column != null) {
				column.UId = new Guid("236b02f1-3c7b-401b-b4fe-1be5f435cda9");
				column.Name = @"Type";
				column.CreatedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
				column.ModifiedInSchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new OppContactMotivatorsEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new OppContactMotivatorsEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new OppContactMotivatorsEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: OppContactMotivatorsEditPageEventsProcess

	/// <exclude/>
	public class OppContactMotivatorsEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.OppContactMotivatorsEditPageSchemaUserControl
	{

		public OppContactMotivatorsEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OppContactMotivatorsEditPageEventsProcess";
			SchemaUId = new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("993bcc55-0ee4-4952-bdc3-03e3b4c4b9fc");
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

	#region Class: OppContactMotivatorsEditPageEventsProcess

	/// <exclude/>
	public class OppContactMotivatorsEditPageEventsProcess : OppContactMotivatorsEditPageEventsProcess<Terrasoft.WebApp.OppContactMotivatorsEditPageSchemaUserControl>
	{

		public OppContactMotivatorsEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OppContactMotivatorsEditPageSchemaUserControl

	/// <exclude/>
	public partial class OppContactMotivatorsEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.LookupEdit TypeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("TypeEdit", true);
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
			var process = (OppContactMotivatorsEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new OppContactMotivatorsEditPageEventsProcess(UserConnection);
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
			SchemaName = "OppContactMotivatorsEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: OppContactMotivatorsEditPageEventsProcessSchema

	/// <exclude/>
	public class OppContactMotivatorsEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public OppContactMotivatorsEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public OppContactMotivatorsEditPageEventsProcessSchema(OppContactMotivatorsEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OppContactMotivatorsEditPageEventsProcess";
			UId = new Guid("3438b020-1580-4cfd-ac01-0c7b6ad6f0cb");
			CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
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
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OppContactMotivatorsEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3438b020-1580-4cfd-ac01-0c7b6ad6f0cb"));
		}

		#endregion

	}

	#endregion

}

