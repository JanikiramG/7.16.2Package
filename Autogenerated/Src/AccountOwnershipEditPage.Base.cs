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

	#region Class: AccountOwnershipEditPageSchema

	/// <exclude/>
	public class AccountOwnershipEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
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

		public AccountOwnershipEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AccountOwnershipEditPageSchema(AccountOwnershipEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("e7b0c673-3d31-438e-bb36-0aa5f38be28a");
			NameEdit.ModifiedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("666041df-24f1-4e25-bc98-7cbad127f221");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
			RealUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
			Name = "AccountOwnershipEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 320;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAccountOwnershipEditPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateAccountOwnershipEditPageEventsProcessSchema() {
			var schema = new AccountOwnershipEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateCountryEdit() {
			_countryEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_countryEdit.UId = new Guid("c4848d33-1961-4fff-acd1-da95454b776c");
			_countryEdit.Name = "CountryEdit";
			_countryEdit.CreatedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
			_countryEdit.ModifiedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
			_countryEdit.CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6");
			_countryEdit.Tag = "";
			_countryEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_countryEdit.Image = new ControlImage {};
			_countryEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_countryEdit.DataSource = "DataSource";
			_countryEdit.ColumnUId = new Guid("1d784c40-efbb-495c-ad81-967eb83454d5");
			return _countryEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("ce243c2c-b7d3-4dc4-b474-ab24c677801b");
			DataSource.ModifiedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("287fbceb-4d24-417e-ad1a-f122b9fec856");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
				column.ModifiedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("2f4548db-dd1b-417d-a5bb-bf51f7266246");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
				column.ModifiedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("809b2343-42c0-4df7-8168-716477980682");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
				column.ModifiedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("804791e7-db5e-4496-b6fc-4334b49cc447");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
				column.ModifiedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("9808341a-27e8-47a3-b34e-e3d4f530cbcb");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
				column.ModifiedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("e7b0c673-3d31-438e-bb36-0aa5f38be28a");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
				column.ModifiedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("666041df-24f1-4e25-bc98-7cbad127f221");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
				column.ModifiedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("bd9ec46e-6371-466e-87ec-1adf995e47c7");
			if (column != null) {
				column.UId = new Guid("1d784c40-efbb-495c-ad81-967eb83454d5");
				column.Name = @"Country";
				column.CreatedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
				column.ModifiedInSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
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
			return new AccountOwnershipEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new AccountOwnershipEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AccountOwnershipEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AccountOwnershipEditPageEventsProcess

	/// <exclude/>
	public class AccountOwnershipEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AccountOwnershipEditPageSchemaUserControl
	{

		public AccountOwnershipEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountOwnershipEditPageEventsProcess";
			SchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b");
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

		private ProcessFlowElement _subProcessAccountOwnershipPageLoadComplete;
		public ProcessFlowElement SubProcessAccountOwnershipPageLoadComplete {
			get {
				return _subProcessAccountOwnershipPageLoadComplete ?? (_subProcessAccountOwnershipPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessAccountOwnershipPageLoadComplete",
					SchemaElementUId = new Guid("84686767-28fb-4efc-993c-6dfdb7650a52"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageAccountOwnerShipPageLoadComplete;
		public ProcessFlowElement StartMessageAccountOwnerShipPageLoadComplete {
			get {
				return _startMessageAccountOwnerShipPageLoadComplete ?? (_startMessageAccountOwnerShipPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageAccountOwnerShipPageLoadComplete",
					SchemaElementUId = new Guid("5485f030-ab12-4a84-a33f-09d91590a901"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageAccountOwnershipPageLoadComplete;
		public ProcessThrowMessageEvent IntermediateThrowMessageAccountOwnershipPageLoadComplete {
			get {
				return _intermediateThrowMessageAccountOwnershipPageLoadComplete ?? (_intermediateThrowMessageAccountOwnershipPageLoadComplete = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageAccountOwnershipPageLoadComplete",
					SchemaElementUId = new Guid("88f578bd-4653-4eb8-99de-3bd3ffa4b390"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptTaskAccountOwnershipPageLoadComplete;
		public ProcessScriptTask ScriptTaskAccountOwnershipPageLoadComplete {
			get {
				return _scriptTaskAccountOwnershipPageLoadComplete ?? (_scriptTaskAccountOwnershipPageLoadComplete = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskAccountOwnershipPageLoadComplete",
					SchemaElementUId = new Guid("bbf6509e-13da-45bf-ba20-5d982d933dac"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskAccountOwnershipPageLoadCompleteExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SubProcessAccountOwnershipPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessAccountOwnershipPageLoadComplete };
			FlowElements[StartMessageAccountOwnerShipPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageAccountOwnerShipPageLoadComplete };
			FlowElements[IntermediateThrowMessageAccountOwnershipPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageAccountOwnershipPageLoadComplete };
			FlowElements[ScriptTaskAccountOwnershipPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskAccountOwnershipPageLoadComplete };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcessAccountOwnershipPageLoadComplete":
						break;
					case "StartMessageAccountOwnerShipPageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptTaskAccountOwnershipPageLoadComplete");
						break;
					case "IntermediateThrowMessageAccountOwnershipPageLoadComplete":
						break;
					case "ScriptTaskAccountOwnershipPageLoadComplete":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageAccountOwnershipPageLoadComplete");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageAccountOwnerShipPageLoadComplete");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcessAccountOwnershipPageLoadComplete":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageAccountOwnerShipPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageAccountOwnerShipPageLoadComplete";
					result = StartMessageAccountOwnerShipPageLoadComplete.Execute(context);
					break;
				case "IntermediateThrowMessageAccountOwnershipPageLoadComplete":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageAccountOwnershipPageLoadComplete.Execute(context);
					break;
				case "ScriptTaskAccountOwnershipPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskAccountOwnershipPageLoadComplete";
					result = ScriptTaskAccountOwnershipPageLoadComplete.Execute(context, ScriptTaskAccountOwnershipPageLoadCompleteExecute);
					break;
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

		public virtual bool ScriptTaskAccountOwnershipPageLoadCompleteExecute(ProcessExecutingContext context) {
			Guid schemaUId = new Guid(Page.Request.QueryString["entitySchemaUId"].ToString());
			Page.DataSource.SchemaUId = schemaUId;
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessageAccountOwnerShipPageLoadComplete")) {
							context.QueueTasks.Enqueue("StartMessageAccountOwnerShipPageLoadComplete");
							ProcessQueue(context);
							return;
						}
						break;
			}
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

	#region Class: AccountOwnershipEditPageEventsProcess

	/// <exclude/>
	public class AccountOwnershipEditPageEventsProcess : AccountOwnershipEditPageEventsProcess<Terrasoft.WebApp.AccountOwnershipEditPageSchemaUserControl>
	{

		public AccountOwnershipEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountOwnershipEditPageSchemaUserControl

	/// <exclude/>
	public partial class AccountOwnershipEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
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
			var process = (AccountOwnershipEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AccountOwnershipEditPageEventsProcess(UserConnection);
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
			SchemaName = "AccountOwnershipEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: AccountOwnershipEditPageEventsProcessSchema

	/// <exclude/>
	public class AccountOwnershipEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public AccountOwnershipEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AccountOwnershipEditPageEventsProcessSchema(AccountOwnershipEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AccountOwnershipEditPageEventsProcess";
			UId = new Guid("226676d3-3090-41e7-9411-8c6ffe3a0b09");
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
			ProcessSchemaLaneSet schemaLaneSet1150 = CreateLaneSet1150LaneSet();
			LaneSets.Add(schemaLaneSet1150);
			ProcessSchemaLane schemaLane3862 = CreateLane3862Lane();
			schemaLaneSet1150.Lanes.Add(schemaLane3862);
			ProcessSchemaEventSubProcess subprocessaccountownershippageloadcomplete = CreateSubProcessAccountOwnershipPageLoadCompleteEventSubProcess();
			FlowElements.Add(subprocessaccountownershippageloadcomplete);
			ProcessSchemaStartMessageEvent startmessageaccountownershippageloadcomplete = CreateStartMessageAccountOwnerShipPageLoadCompleteStartMessageEvent();
			subprocessaccountownershippageloadcomplete.FlowElements.Add(startmessageaccountownershippageloadcomplete);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageaccountownershippageloadcomplete = CreateIntermediateThrowMessageAccountOwnershipPageLoadCompleteIntermediateThrowMessageEvent();
			subprocessaccountownershippageloadcomplete.FlowElements.Add(intermediatethrowmessageaccountownershippageloadcomplete);
			ProcessSchemaScriptTask scripttaskaccountownershippageloadcomplete = CreateScriptTaskAccountOwnershipPageLoadCompleteScriptTask();
			subprocessaccountownershippageloadcomplete.FlowElements.Add(scripttaskaccountownershippageloadcomplete);
			FlowElements.Add(CreateSequenceFlow21655SequenceFlow());
			FlowElements.Add(CreateSequenceFlow21656SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow21655SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow21655",
				UId = new Guid("1cae9d8a-6d11-4bd8-a372-12f63a471aa5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("226676d3-3090-41e7-9411-8c6ffe3a0b09"),
				CurveCenterPosition = new Point(154, 648),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("226676d3-3090-41e7-9411-8c6ffe3a0b09"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5485f030-ab12-4a84-a33f-09d91590a901"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bbf6509e-13da-45bf-ba20-5d982d933dac"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow21656SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow21656",
				UId = new Guid("c1be9064-59f7-4cb6-bf63-4e0ce69afa56"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("226676d3-3090-41e7-9411-8c6ffe3a0b09"),
				CurveCenterPosition = new Point(245, 645),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("226676d3-3090-41e7-9411-8c6ffe3a0b09"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bbf6509e-13da-45bf-ba20-5d982d933dac"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("88f578bd-4653-4eb8-99de-3bd3ffa4b390"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1150LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1150 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("37d852d8-5dc9-456c-9b29-76569d184e8b"),
				ContainerItemIndex = 3,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("226676d3-3090-41e7-9411-8c6ffe3a0b09"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("226676d3-3090-41e7-9411-8c6ffe3a0b09"),
				Name = @"LaneSet1150",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 746),
				Size = new Size(775, 175),
				UseBackgroundMode = false
			};
			return schemaLaneSet1150;
		}

		protected virtual ProcessSchemaLane CreateLane3862Lane() {
			ProcessSchemaLane schemaLane3862 = new ProcessSchemaLane(this) {
				UId = new Guid("cad79462-452d-404f-85a7-36ebec5eec76"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("37d852d8-5dc9-456c-9b29-76569d184e8b"),
				CreatedInOwnerSchemaUId = new Guid("91660b0a-9999-4ca9-89dd-45637bd2e72b"),
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("226676d3-3090-41e7-9411-8c6ffe3a0b09"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("226676d3-3090-41e7-9411-8c6ffe3a0b09"),
				Name = @"Lane3862",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(746, 175),
				UseBackgroundMode = false
			};
			return schemaLane3862;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessAccountOwnershipPageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessAccountOwnershipPageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("84686767-28fb-4efc-993c-6dfdb7650a52"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cad79462-452d-404f-85a7-36ebec5eec76"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("226676d3-3090-41e7-9411-8c6ffe3a0b09"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("226676d3-3090-41e7-9411-8c6ffe3a0b09"),
				Name = @"SubProcessAccountOwnershipPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(259, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessAccountOwnershipPageLoadComplete;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageAccountOwnerShipPageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5485f030-ab12-4a84-a33f-09d91590a901"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("84686767-28fb-4efc-993c-6dfdb7650a52"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("226676d3-3090-41e7-9411-8c6ffe3a0b09"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("226676d3-3090-41e7-9411-8c6ffe3a0b09"),
				Name = @"StartMessageAccountOwnerShipPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(21, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageAccountOwnershipPageLoadCompleteIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("88f578bd-4653-4eb8-99de-3bd3ffa4b390"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("84686767-28fb-4efc-993c-6dfdb7650a52"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("226676d3-3090-41e7-9411-8c6ffe3a0b09"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("226676d3-3090-41e7-9411-8c6ffe3a0b09"),
				Name = @"IntermediateThrowMessageAccountOwnershipPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(189, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskAccountOwnershipPageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bbf6509e-13da-45bf-ba20-5d982d933dac"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("84686767-28fb-4efc-993c-6dfdb7650a52"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("226676d3-3090-41e7-9411-8c6ffe3a0b09"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("226676d3-3090-41e7-9411-8c6ffe3a0b09"),
				Name = @"ScriptTaskAccountOwnershipPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(84, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,47,205,76,81,40,78,206,72,205,77,12,245,76,81,176,85,200,75,45,87,112,7,10,106,4,36,166,167,234,5,165,22,150,166,22,151,232,5,150,166,22,85,6,151,20,101,230,165,71,43,165,230,149,100,150,84,6,195,52,41,197,234,133,228,67,228,52,52,53,173,185,192,26,93,18,75,18,131,243,75,139,146,83,245,130,145,76,135,219,100,205,85,148,90,82,90,148,167,80,82,84,154,106,13,0,38,32,75,245,134,0,0,0 }
			};
			
			return ScriptTask;
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
			return new AccountOwnershipEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("226676d3-3090-41e7-9411-8c6ffe3a0b09"));
		}

		#endregion

	}

	#endregion

}

