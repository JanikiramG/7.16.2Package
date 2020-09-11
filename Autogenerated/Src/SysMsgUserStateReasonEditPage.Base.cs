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

	#region Class: SysMsgUserStateReasonEditPageSchema

	/// <exclude/>
	public class SysMsgUserStateReasonEditPageSchema : Terrasoft.WebApp.BaseCodeLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.LookupEdit _sysMsgUserStateEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit SysMsgUserStateEdit {
			get {
				return _sysMsgUserStateEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public SysMsgUserStateReasonEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysMsgUserStateReasonEditPageSchema(SysMsgUserStateReasonEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("00b1ac54-1d1c-4372-bce0-f0a93bc8cce8");
			NameEdit.ModifiedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
		}

		private void UpdateCodeEdit() {
			CodeEdit.Image = new ControlImage {};
			CodeEdit.ColumnUId = new Guid("72d9b42a-cf41-43df-b983-95518102cef3");
			CodeEdit.ModifiedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("bbf041e1-51eb-44b6-b20a-09237a436fba");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
			RealUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
			Name = "SysMsgUserStateReasonEditPage";
			ParentSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
			CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysMsgUserStateReasonEditPageEventsProcessSchema();
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
			UpdateCodeEdit();
			UpdateNameEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, NameEdit);
			MainControlLayout.MoveItem(1, CodeEdit);
			MainControlLayout.InsertItem(2, CreateSysMsgUserStateEdit());
			MainControlLayout.MoveItem(3, DescriptionEdit);
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

		protected virtual EmbeddedProcessSchema CreateSysMsgUserStateReasonEditPageEventsProcessSchema() {
			var schema = new SysMsgUserStateReasonEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateSysMsgUserStateEdit() {
			_sysMsgUserStateEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_sysMsgUserStateEdit.UId = new Guid("7d648a73-cb99-46d4-bf68-e8bc7040d4d8");
			_sysMsgUserStateEdit.Name = "SysMsgUserStateEdit";
			_sysMsgUserStateEdit.CreatedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
			_sysMsgUserStateEdit.ModifiedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
			_sysMsgUserStateEdit.CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845");
			_sysMsgUserStateEdit.Tag = "";
			_sysMsgUserStateEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sysMsgUserStateEdit.Image = new ControlImage {};
			_sysMsgUserStateEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_sysMsgUserStateEdit.DataSource = "DataSource";
			_sysMsgUserStateEdit.ColumnUId = new Guid("a1418d06-7414-459f-91ba-d88911cf9794");
			return _sysMsgUserStateEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("1a286a70-31d9-40f9-9583-7e81ccf743a1");
			DataSource.ModifiedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("b312268e-be0a-490c-8372-e6855fd5978b");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
				column.ModifiedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("d50a5ef8-cc93-48de-9a67-e44cac99b064");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
				column.ModifiedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("587521ba-7519-481e-aca2-88adfb8370c4");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
				column.ModifiedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("6b474dc1-2d43-473e-82cf-3f98caa3b786");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
				column.ModifiedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("57b8afd4-f12c-48e4-bea1-632d83d6080a");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
				column.ModifiedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("00b1ac54-1d1c-4372-bce0-f0a93bc8cce8");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
				column.ModifiedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("bbf041e1-51eb-44b6-b20a-09237a436fba");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
				column.ModifiedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("13aad544-ec30-4e76-a373-f0cff3202e24");
			if (column != null) {
				column.UId = new Guid("72d9b42a-cf41-43df-b983-95518102cef3");
				column.Name = @"Code";
				column.CreatedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
				column.ModifiedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("0f5ac60f-ad5c-4d56-a2d3-45b87d335fe8");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
				column.ModifiedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("59993ff0-1373-4acf-9eff-e2cec861f065");
			if (column != null) {
				column.UId = new Guid("445be15b-5e7c-4898-a4df-cfc81f1b62a0");
				column.Name = @"Image";
				column.CreatedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
				column.ModifiedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("eadd9d6f-9fe1-46fc-87a8-9167c91ae635");
			if (column != null) {
				column.UId = new Guid("a1418d06-7414-459f-91ba-d88911cf9794");
				column.Name = @"SysMsgUserState";
				column.CreatedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
				column.ModifiedInSchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
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
			return new SysMsgUserStateReasonEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysMsgUserStateReasonEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysMsgUserStateReasonEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysMsgUserStateReasonEditPageEventsProcess

	/// <exclude/>
	public class SysMsgUserStateReasonEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseCodeLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysMsgUserStateReasonEditPageSchemaUserControl
	{

		public SysMsgUserStateReasonEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysMsgUserStateReasonEditPageEventsProcess";
			SchemaUId = new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d5124bd1-23e2-4dc7-899a-8495be1b671f");
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

		private LocalizableString _duplicateCodeErrorMessage;
		public LocalizableString DuplicateCodeErrorMessage {
			get {
				return _duplicateCodeErrorMessage ?? (_duplicateCodeErrorMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DuplicateCodeErrorMessage.Value"));
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

		public override bool AreConditionsCorrect(Entity row) {
			var isValid = base.AreConditionsCorrect(row);
			if (!isValid) {
				return isValid;
			}
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, row.SchemaName);
			var columnNameCount = esq.AddColumn(esq.CreateAggregationFunction(
				AggregationTypeStrict.Count, "Id")).Name;
			if (IsEdit) {
				var filterId = esq.CreateFilterWithParameters(FilterComparisonType.NotEqual, "Id", row.PrimaryColumnValue);
				esq.Filters.Add(filterId);
			}
			var filterCode = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Code",
				row.GetTypedColumnValue<string>("Code"));
			esq.Filters.Add(filterCode);
			
			var entityCollection = esq.GetEntityCollection(UserConnection);
			var entity = entityCollection[0];
			var count = entity.GetTypedColumnValue<int>(columnNameCount);
			isValid = count == 0;
			if (!isValid) {
				Page.BaseMessagePanel.AddMessage(Warning, DuplicateCodeErrorMessage, MessageType.Warning);
			}
			return isValid;
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

	#region Class: SysMsgUserStateReasonEditPageEventsProcess

	/// <exclude/>
	public class SysMsgUserStateReasonEditPageEventsProcess : SysMsgUserStateReasonEditPageEventsProcess<Terrasoft.WebApp.SysMsgUserStateReasonEditPageSchemaUserControl>
	{

		public SysMsgUserStateReasonEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysMsgUserStateReasonEditPageSchemaUserControl

	/// <exclude/>
	public partial class SysMsgUserStateReasonEditPageSchemaUserControl : Terrasoft.WebApp.BaseCodeLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.LookupEdit SysMsgUserStateEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("SysMsgUserStateEdit", true);
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
			var process = (SysMsgUserStateReasonEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysMsgUserStateReasonEditPageEventsProcess(UserConnection);
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
			SchemaName = "SysMsgUserStateReasonEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysMsgUserStateReasonEditPageEventsProcessSchema

	/// <exclude/>
	public class SysMsgUserStateReasonEditPageEventsProcessSchema : Terrasoft.WebApp.BaseCodeLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysMsgUserStateReasonEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysMsgUserStateReasonEditPageEventsProcessSchema(SysMsgUserStateReasonEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysMsgUserStateReasonEditPageEventsProcess";
			UId = new Guid("d26d382e-1ec1-4f68-9933-da0b8e0357c0");
			CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35");
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
			LocalizableStrings.Add(CreateDuplicateCodeErrorMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateDuplicateCodeErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6b5fdbf8-9d42-45fa-bb51-08ba5d063ebf"),
				Name = "DuplicateCodeErrorMessage",
				CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845"),
				CreatedInSchemaUId = new Guid("d26d382e-1ec1-4f68-9933-da0b8e0357c0"),
				ModifiedInSchemaUId = new Guid("d26d382e-1ec1-4f68-9933-da0b8e0357c0")
			};
			return localizableString;
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
				CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845")
			});
		}

		protected override SchemaMethod CreateAreConditionsCorrectMethod() {
			SchemaMethod method = base.CreateAreConditionsCorrectMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,77,79,195,48,12,61,51,105,255,33,236,148,74,85,197,157,15,105,148,130,118,0,13,241,117,64,28,66,235,149,72,109,50,156,20,52,33,254,59,118,146,193,84,237,196,45,177,157,247,158,237,151,15,133,66,187,71,213,233,70,156,138,87,229,160,152,35,148,214,52,218,107,107,92,105,17,161,246,18,237,103,118,60,157,232,149,144,135,169,62,19,95,211,201,1,130,31,208,108,49,168,228,123,58,249,32,80,112,239,4,104,224,83,84,198,107,191,185,171,223,160,87,183,3,224,70,62,56,64,162,48,4,76,28,197,110,193,181,50,170,5,204,5,17,22,49,116,163,122,96,110,70,173,109,55,244,134,35,165,29,140,39,6,226,41,230,77,83,134,132,228,91,137,160,60,204,219,22,161,85,76,112,57,152,64,36,73,238,78,248,126,179,134,59,143,186,246,69,0,203,197,108,209,204,178,172,96,248,212,235,194,85,52,136,216,41,243,175,116,231,1,23,77,34,142,84,151,33,248,164,253,219,82,33,189,165,139,147,49,88,218,126,173,80,187,200,86,220,88,95,189,15,170,139,84,177,201,37,234,94,225,38,54,64,67,28,66,179,7,12,31,49,28,247,39,183,204,217,223,136,87,137,162,129,127,202,217,106,97,136,89,206,203,36,61,87,224,57,217,236,8,58,113,52,38,211,158,201,88,153,177,134,253,250,56,207,217,228,129,176,88,2,234,226,166,147,76,98,168,70,153,145,37,182,235,142,0,252,108,84,255,124,244,242,235,136,228,131,80,177,87,189,54,254,76,142,156,19,204,252,235,251,4,114,42,142,246,122,124,73,150,44,206,233,111,92,131,115,116,94,42,3,29,119,157,238,242,73,161,161,1,229,226,98,88,119,186,166,37,240,32,42,68,139,169,36,23,233,16,6,159,234,211,46,71,95,232,7,28,56,140,58,147,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysMsgUserStateReasonEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d26d382e-1ec1-4f68-9933-da0b8e0357c0"));
		}

		#endregion

	}

	#endregion

}

