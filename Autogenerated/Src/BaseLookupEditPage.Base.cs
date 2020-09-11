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

	#region Class: BaseLookupEditPageSchema

	/// <exclude/>
	public class BaseLookupEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TextEdit _nameEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return _nameEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MemoEdit _descriptionEdit;
		public Terrasoft.UI.WebControls.Controls.MemoEdit DescriptionEdit {
			get {
				return _descriptionEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public BaseLookupEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseLookupEditPageSchema(BaseLookupEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			RealUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			Name = "BaseLookupEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 295;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseLookupEditPageEventsProcessSchema();
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
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.InsertItem(0, CreateNameEdit());
			MainControlLayout.InsertItem(1, CreateDescriptionEdit());
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

		protected virtual EmbeddedProcessSchema CreateBaseLookupEditPageEventsProcessSchema() {
			var schema = new BaseLookupEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateNameEdit() {
			_nameEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_nameEdit.UId = new Guid("f346227a-92a1-41c7-8956-ef550000b989");
			_nameEdit.Name = "NameEdit";
			_nameEdit.CreatedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			_nameEdit.ModifiedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			_nameEdit.CreatedInPackageId = Guid.Empty;
			_nameEdit.Tag = "";
			_nameEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_nameEdit.Image = new ControlImage {};
			_nameEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_nameEdit.DataSource = "DataSource";
			_nameEdit.ColumnUId = new Guid("c7937dde-e4a2-4ade-9680-2afd525e57b7");
			return _nameEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MemoEdit CreateDescriptionEdit() {
			_descriptionEdit = new Terrasoft.UI.WebControls.Controls.MemoEdit();
			_descriptionEdit.UId = new Guid("ed911ca6-9974-405b-9bda-2d8dfba67761");
			_descriptionEdit.Name = "DescriptionEdit";
			_descriptionEdit.CreatedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			_descriptionEdit.ModifiedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			_descriptionEdit.CreatedInPackageId = Guid.Empty;
			_descriptionEdit.Tag = "";
			_descriptionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_descriptionEdit.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_descriptionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_descriptionEdit.DataSource = "DataSource";
			_descriptionEdit.ColumnUId = new Guid("56a015fc-ea02-45e4-af0f-a3855e7cdae5");
			return _descriptionEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			DataSource.ModifiedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("e3fc8255-ce7b-4efb-8b18-608c750a7853");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
				column.ModifiedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("c7937dde-e4a2-4ade-9680-2afd525e57b7");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
				column.ModifiedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("1c2fb2a7-d7bd-4c96-af50-77f36140288b");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
				column.ModifiedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("de531eff-e342-4dda-b282-b0bc51b3a7ef");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
				column.ModifiedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("0a4f5e1e-96fa-46f2-b1d8-a8eec64a96de");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
				column.ModifiedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("043d2c2e-30ec-4998-ba42-1c208a81fde9");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
				column.ModifiedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("56a015fc-ea02-45e4-af0f-a3855e7cdae5");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
				column.ModifiedInSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
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
			return new BaseLookupEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseLookupEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseLookupEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseLookupEditPageEventsProcess

	/// <exclude/>
	public class BaseLookupEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		public BaseLookupEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseLookupEditPageEventsProcess";
			SchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
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

		private ProcessFlowElement _subProcessBaseLookupEditPagePageLoadComplete;
		public ProcessFlowElement SubProcessBaseLookupEditPagePageLoadComplete {
			get {
				return _subProcessBaseLookupEditPagePageLoadComplete ?? (_subProcessBaseLookupEditPagePageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessBaseLookupEditPagePageLoadComplete",
					SchemaElementUId = new Guid("894e684e-8b4d-4eeb-b193-8928455c460a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageBaseLookupEditPagePageLoadComplete;
		public ProcessFlowElement StartMessageBaseLookupEditPagePageLoadComplete {
			get {
				return _startMessageBaseLookupEditPagePageLoadComplete ?? (_startMessageBaseLookupEditPagePageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageBaseLookupEditPagePageLoadComplete",
					SchemaElementUId = new Guid("dd28f58e-eeff-47c3-b5ea-2563d70d69c4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskBaseLookupEditPagePageLoadComplete;
		public ProcessScriptTask ScriptTaskBaseLookupEditPagePageLoadComplete {
			get {
				return _scriptTaskBaseLookupEditPagePageLoadComplete ?? (_scriptTaskBaseLookupEditPagePageLoadComplete = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskBaseLookupEditPagePageLoadComplete",
					SchemaElementUId = new Guid("7e7564a0-ed36-4491-a3df-a9345a4905a4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskBaseLookupEditPagePageLoadCompleteExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowBasePageLoadComplete;
		public ProcessThrowMessageEvent IntermediateThrowBasePageLoadComplete {
			get {
				return _intermediateThrowBasePageLoadComplete ?? (_intermediateThrowBasePageLoadComplete = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowBasePageLoadComplete",
					SchemaElementUId = new Guid("6c76560f-7b03-4ef2-b10b-ba7ebac2e6ad"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SubProcessBaseLookupEditPagePageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessBaseLookupEditPagePageLoadComplete };
			FlowElements[StartMessageBaseLookupEditPagePageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageBaseLookupEditPagePageLoadComplete };
			FlowElements[ScriptTaskBaseLookupEditPagePageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskBaseLookupEditPagePageLoadComplete };
			FlowElements[IntermediateThrowBasePageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowBasePageLoadComplete };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcessBaseLookupEditPagePageLoadComplete":
						break;
					case "StartMessageBaseLookupEditPagePageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptTaskBaseLookupEditPagePageLoadComplete");
						break;
					case "ScriptTaskBaseLookupEditPagePageLoadComplete":
						e.Context.QueueTasks.Enqueue("IntermediateThrowBasePageLoadComplete");
						break;
					case "IntermediateThrowBasePageLoadComplete":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageBaseLookupEditPagePageLoadComplete");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcessBaseLookupEditPagePageLoadComplete":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageBaseLookupEditPagePageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageBaseLookupEditPagePageLoadComplete";
					result = StartMessageBaseLookupEditPagePageLoadComplete.Execute(context);
					break;
				case "ScriptTaskBaseLookupEditPagePageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskBaseLookupEditPagePageLoadComplete";
					result = ScriptTaskBaseLookupEditPagePageLoadComplete.Execute(context, ScriptTaskBaseLookupEditPagePageLoadCompleteExecute);
					break;
				case "IntermediateThrowBasePageLoadComplete":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowBasePageLoadComplete.Execute(context);
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

		public virtual bool ScriptTaskBaseLookupEditPagePageLoadCompleteExecute(ProcessExecutingContext context) {
			Guid schemaUId = new Guid(Page.Request.QueryString["entitySchemaUId"].ToString());
			Page.DataSource.SchemaUId = schemaUId;
			SynchronizeDataSourceStructure = true;
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessageBaseLookupEditPagePageLoadComplete")) {
							context.QueueTasks.Enqueue("StartMessageBaseLookupEditPagePageLoadComplete");
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

	#region Class: BaseLookupEditPageEventsProcess

	/// <exclude/>
	public class BaseLookupEditPageEventsProcess : BaseLookupEditPageEventsProcess<Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl>
	{

		public BaseLookupEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseLookupEditPageSchemaUserControl

	/// <exclude/>
	public partial class BaseLookupEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("NameEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MemoEdit DescriptionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.MemoEdit)PageContainer.FindPageControl("DescriptionEdit", true);
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
			var process = (BaseLookupEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseLookupEditPageEventsProcess(UserConnection);
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
			SchemaName = "BaseLookupEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseLookupEditPageEventsProcessSchema

	/// <exclude/>
	public class BaseLookupEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public BaseLookupEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseLookupEditPageEventsProcessSchema(BaseLookupEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseLookupEditPageEventsProcess";
			UId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet153 = CreateLaneSet153LaneSet();
			LaneSets.Add(schemaLaneSet153);
			ProcessSchemaLane schemaLane400 = CreateLane400Lane();
			schemaLaneSet153.Lanes.Add(schemaLane400);
			ProcessSchemaEventSubProcess subprocessbaselookupeditpagepageloadcomplete = CreateSubProcessBaseLookupEditPagePageLoadCompleteEventSubProcess();
			FlowElements.Add(subprocessbaselookupeditpagepageloadcomplete);
			ProcessSchemaStartMessageEvent startmessagebaselookupeditpagepageloadcomplete = CreateStartMessageBaseLookupEditPagePageLoadCompleteStartMessageEvent();
			subprocessbaselookupeditpagepageloadcomplete.FlowElements.Add(startmessagebaselookupeditpagepageloadcomplete);
			ProcessSchemaScriptTask scripttaskbaselookupeditpagepageloadcomplete = CreateScriptTaskBaseLookupEditPagePageLoadCompleteScriptTask();
			subprocessbaselookupeditpagepageloadcomplete.FlowElements.Add(scripttaskbaselookupeditpagepageloadcomplete);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowbasepageloadcomplete = CreateIntermediateThrowBasePageLoadCompleteIntermediateThrowMessageEvent();
			subprocessbaselookupeditpagepageloadcomplete.FlowElements.Add(intermediatethrowbasepageloadcomplete);
			FlowElements.Add(CreateSequenceFlow2818SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2819SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2818SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2818",
				UId = new Guid("bbba5f70-7311-47de-ba04-328ebb2bd1ce"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CurveCenterPosition = new Point(152, 638),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dd28f58e-eeff-47c3-b5ea-2563d70d69c4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7e7564a0-ed36-4491-a3df-a9345a4905a4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2819SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2819",
				UId = new Guid("8ffc0af2-cbf2-46f3-8a76-0a4791c51194"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CurveCenterPosition = new Point(292, 647),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7e7564a0-ed36-4491-a3df-a9345a4905a4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6c76560f-7b03-4ef2-b10b-ba7ebac2e6ad"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet153LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet153 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("43a1bc46-04c3-4d25-b934-61e9b70968b7"),
				ContainerItemIndex = 2,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				Name = @"LaneSet153",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 560),
				Size = new Size(762, 175),
				UseBackgroundMode = false
			};
			return schemaLaneSet153;
		}

		protected virtual ProcessSchemaLane CreateLane400Lane() {
			ProcessSchemaLane schemaLane400 = new ProcessSchemaLane(this) {
				UId = new Guid("452d20a9-3b10-495d-b8e9-a79b0decc5b6"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("43a1bc46-04c3-4d25-b934-61e9b70968b7"),
				CreatedInOwnerSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				Name = @"Lane400",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(733, 175),
				UseBackgroundMode = false
			};
			return schemaLane400;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessBaseLookupEditPagePageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessBaseLookupEditPagePageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("894e684e-8b4d-4eeb-b193-8928455c460a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("452d20a9-3b10-495d-b8e9-a79b0decc5b6"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				Name = @"SubProcessBaseLookupEditPagePageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(316, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessBaseLookupEditPagePageLoadComplete;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageBaseLookupEditPagePageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("dd28f58e-eeff-47c3-b5ea-2563d70d69c4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("894e684e-8b4d-4eeb-b193-8928455c460a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				Name = @"StartMessageBaseLookupEditPagePageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(21, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskBaseLookupEditPagePageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7e7564a0-ed36-4491-a3df-a9345a4905a4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("894e684e-8b4d-4eeb-b193-8928455c460a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				Name = @"ScriptTaskBaseLookupEditPagePageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,77,187,10,194,48,20,221,243,21,161,83,187,228,7,138,155,80,220,212,232,36,14,33,61,180,25,188,193,219,123,145,248,245,6,139,143,237,188,207,160,105,180,75,156,113,11,231,221,104,55,150,240,176,67,21,219,125,152,224,142,184,43,22,113,7,5,23,47,156,104,186,52,32,73,82,252,167,212,92,221,41,175,94,219,117,189,121,23,183,65,130,207,202,17,206,255,173,127,159,122,227,11,197,153,51,165,39,126,225,58,163,81,148,81,179,21,162,55,140,74,105,37,47,103,195,137,138,173,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowBasePageLoadCompleteIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("6c76560f-7b03-4ef2-b10b-ba7ebac2e6ad"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("894e684e-8b4d-4eeb-b193-8928455c460a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				Name = @"IntermediateThrowBasePageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(246, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
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
			return new BaseLookupEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a9025da9-8220-4758-a93e-a034578ef23b"));
		}

		#endregion

	}

	#endregion

}

