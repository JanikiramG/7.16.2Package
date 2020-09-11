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
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.Web.Common;

	#region Class: SysModuleEditDetailEditPageSchema

	/// <exclude/>
	public class SysModuleEditDetailEditPageSchema : Terrasoft.WebApp.SysModuleDetailEditPageSchema
	{

		#region Constructors: Public

		public SysModuleEditDetailEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysModuleEditDetailEditPageSchema(SysModuleEditDetailEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
		}

		private void UpdateCaptionEdit() {
			CaptionEdit.Image = new ControlImage {};
			CaptionEdit.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
		}

		private void UpdateSysPageSchemaEdit() {
			SysPageSchemaEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			SysPageSchemaEdit.Image = new ControlImage {};
			SysPageSchemaEdit.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
		}

		private void UpdateSysEntitySchemaEdit() {
			SysEntitySchemaEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			SysEntitySchemaEdit.Image = new ControlImage {};
			SysEntitySchemaEdit.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
		}

		private void UpdateTypeColumnEdit() {
			TypeColumnEdit.Image = new ControlImage {};
			TypeColumnEdit.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
		}

		private void UpdateDetailParentAsscContainer() {
			DetailParentAsscContainer.PageSchemaUId = new Guid("9b5d868d-9040-4e43-9879-7d9da3e75b35");
			DetailParentAsscContainer.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
		}

		private void UpdateAssociationTab() {
			AssociationTab.Image = new ControlImage {};
			AssociationTab.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
		}

		private void UpdateSysModuleEditContainer() {
			SysModuleEditContainer.Image = new ControlImage {};
			SysModuleEditContainer.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
			RealUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
			Name = "SysModuleEditDetailEditPage";
			ParentSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysModuleEditDetailEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateSysModuleEditContainer();
			UpdateAssociationTab();
			UpdateDetailParentAsscContainer();
			UpdateMainControlLayout();
			UpdateCustomControls();
			UpdateTypeColumnEdit();
			UpdateSysEntitySchemaEdit();
			UpdateSysPageSchemaEdit();
			UpdateCaptionEdit();
			UpdateButtonsControlLayout();
			UpdateDesignerModeButton();
			UpdateApplyChangesButton();
			UpdateContextHelpButton();
			UpdateCancelButton();
			UpdateOKButton();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, OKButton);
			ButtonsControlLayout.MoveItem(1, CancelButton);
			ButtonsControlLayout.MoveItem(2, SpacerButton);
			ButtonsControlLayout.MoveItem(3, ContextHelpButton);
			ButtonsControlLayout.MoveItem(4, ApplyChangesButton);
			ButtonsControlLayout.MoveItem(5, DesignerModeButton);
			TopLevelControl.MoveItem(2, MainControlLayout);
			MainControlLayout.MoveItem(0, CaptionEdit);
			MainControlLayout.MoveItem(1, SysPageSchemaEdit);
			MainControlLayout.MoveItem(2, SysEntitySchemaEdit);
			MainControlLayout.MoveItem(3, TypeColumnEdit);
			MainControlLayout.MoveItem(4, CustomControls);
			TopLevelControl.MoveItem(3, OptionsPanel);
			OptionsPanel.MoveItem(0, AssociationTab);
			AssociationTab.MoveItem(0, DetailParentAsscContainer);
			OptionsPanel.MoveItem(1, SysModuleEditContainer);
			SysModuleEditContainer.MoveItem(0, SysModuleEditPageContainer);
			TopLevelControl.MoveItem(4, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSysModuleEditDetailEditPageEventsProcessSchema() {
			var schema = new SysModuleEditDetailEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("86442450-82a2-4f99-8f51-670bcffd214d");
			DataSource.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("7fd0ce8f-fcf0-4b9d-a5e8-3515dae4cc54");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
				column.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("4729e371-a41b-43a8-b57d-d16df80d4ab8");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
				column.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("6cbedea5-18c9-4e66-9754-7168f82c1ba6");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
				column.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("04f51ca8-57a1-4764-aa4c-10665b1c9b5f");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
				column.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("e75e4417-74f8-4798-9e08-e2237cf9ea76");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
				column.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("1e0bc741-7c86-4512-955d-6948f9273acc");
			if (column != null) {
				column.UId = new Guid("2936dafa-313e-464d-b576-aebda42c34fa");
				column.Name = @"Caption";
				column.CreatedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
				column.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("62ca3788-1388-4db8-976c-91ba8930672a");
			if (column != null) {
				column.UId = new Guid("44fecbff-b0a9-46fc-85e5-53b70455cb5e");
				column.Name = @"SysModuleEdit";
				column.CreatedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
				column.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("1af37555-5e0e-4a99-99e0-472a65641527");
			if (column != null) {
				column.UId = new Guid("2ddea198-66b5-47cb-804d-26c2ec7ef2d8");
				column.Name = @"SysModuleGrid";
				column.CreatedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
				column.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3ea6606a-f53a-4d8e-8bbb-90eda75e4509");
			if (column != null) {
				column.UId = new Guid("e05005c4-3e7c-40af-94bb-1ce7d0c9a357");
				column.Name = @"Position";
				column.CreatedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
				column.ModifiedInSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
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
			return new SysModuleEditDetailEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysModuleEditDetailEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysModuleEditDetailEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleEditDetailEditPageEventsProcess

	/// <exclude/>
	public class SysModuleEditDetailEditPageEventsProcess<TPage> : Terrasoft.WebApp.SysModuleDetailEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysModuleEditDetailEditPageSchemaUserControl
	{

		public SysModuleEditDetailEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleEditDetailEditPageEventsProcess";
			SchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
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

		private ProcessFlowElement _eventSubProcess13;
		public ProcessFlowElement EventSubProcess13 {
			get {
				return _eventSubProcess13 ?? (_eventSubProcess13 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess13",
					SchemaElementUId = new Guid("4ac668c9-ff01-4f7d-a8cf-04ae48032d2b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage12;
		public ProcessFlowElement StartMessage12 {
			get {
				return _startMessage12 ?? (_startMessage12 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage12",
					SchemaElementUId = new Guid("88e696a6-5a92-4ea1-82d4-687c9acc2c03"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent3;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent3 {
			get {
				return _intermediateThrowMessageEvent3 ?? (_intermediateThrowMessageEvent3 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent3",
					SchemaElementUId = new Guid("a8504cde-666a-4a0e-a8dc-e9db45201740"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptTask14;
		public ProcessScriptTask ScriptTask14 {
			get {
				return _scriptTask14 ?? (_scriptTask14 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask14",
					SchemaElementUId = new Guid("5b817c40-40a1-4995-a92b-76246b9183cc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask14Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess13.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess13 };
			FlowElements[StartMessage12.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage12 };
			FlowElements[IntermediateThrowMessageEvent3.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent3 };
			FlowElements[ScriptTask14.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask14 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess13":
						break;
					case "StartMessage12":
						e.Context.QueueTasks.Enqueue("ScriptTask14");
						break;
					case "IntermediateThrowMessageEvent3":
						break;
					case "ScriptTask14":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent3");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage12");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess13":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage12":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage12";
					result = StartMessage12.Execute(context);
					break;
				case "IntermediateThrowMessageEvent3":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent3.Execute(context);
					break;
				case "ScriptTask14":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask14";
					result = ScriptTask14.Execute(context, ScriptTask14Execute);
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

		public virtual bool ScriptTask14Execute(ProcessExecutingContext context) {
			Page.DataSource.BeforeInsert += delegate (object sender, DataSourceEventArgs e) {
				var selectedModuleEditIdParam = Page.GetParameterValue("ParentEntityId");
				if (selectedModuleEditIdParam != null) {
					e.Row.SetColumnValue("SysModuleEditId", new Guid(selectedModuleEditIdParam.ToString()));
				}
			};
			return true;
		}

		public override void OkClickMethod() {
			string caption = Page.CaptionEdit.LocalizableText.GetCultureValue(UserConnection.GetPrimaryCultureInfo());
			var converters = new JsonConverter[] {new GuidJsonConverter()};
			string id = Json.Serialize(Page.DataSource.ActiveRow.PrimaryColumnValue, converters[0]);
			Page.ScriptManager.AddScript(Page.DataSource.ClientID + 
					".onActiveRowColumnValuesChangedResponse(" 
					 + id + ",{\"Caption\" : {columnValue: "
					 + Json.Serialize(caption) + "}});");
			NeedRefreshGrid = true;
			if(IsCopy){
				Page.ScriptManager.AddScript(Page.DataSource.ClientID + ".save();");
			}
			else{
				if (CloseWindowAfterSave) {
					Page.ScriptManager.AddScript(
						"if (" + Page.DataSource.ClientID + ".activeRow.modifiedValues) {" 
							+ Page.DataSource.ClientID + ".save(); " + 
						"} else { window.close(); }"
					);
				} else {
					Page.ScriptManager.AddScript(Page.DataSource.ClientID + ".save();");
				}
			
			UserConnection.ApplicationCache.WithLocalCaching(Terrasoft.Configuration.CacheUtilities.WorkspaceCacheGroup).
					SetOrRemoveValue(Terrasoft.Configuration.CacheUtilities.DetailsCache, null);
			}
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public override void BeforeSaveRowOnConditionsCorrect(Entity row) {
			var moduleGrid = GetSysModuleGridId();
			row.SetColumnValue("SysModuleGridId", moduleGrid);
		}

		public override Dictionary<string, object> GetDefValues() {
			Dictionary<string, object> defValues = base.GetDefValues();
			defValues["SysModule"] = SelectedModuleId;
			return defValues;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessage12")) {
							context.QueueTasks.Enqueue("StartMessage12");
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

	#region Class: SysModuleEditDetailEditPageEventsProcess

	/// <exclude/>
	public class SysModuleEditDetailEditPageEventsProcess : SysModuleEditDetailEditPageEventsProcess<Terrasoft.WebApp.SysModuleEditDetailEditPageSchemaUserControl>
	{

		public SysModuleEditDetailEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleEditDetailEditPageSchemaUserControl

	/// <exclude/>
	public partial class SysModuleEditDetailEditPageSchemaUserControl : Terrasoft.WebApp.SysModuleDetailEditPageSchemaUserControl
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
			var process = (SysModuleEditDetailEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysModuleEditDetailEditPageEventsProcess(UserConnection);
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
			SchemaName = "SysModuleEditDetailEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleEditDetailEditPageEventsProcessSchema

	/// <exclude/>
	public class SysModuleEditDetailEditPageEventsProcessSchema : Terrasoft.WebApp.SysModuleDetailEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysModuleEditDetailEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysModuleEditDetailEditPageEventsProcessSchema(SysModuleEditDetailEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysModuleEditDetailEditPageEventsProcess";
			UId = new Guid("60b5d318-586e-4a29-a59d-a5fce8632d18");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1040 = CreateLaneSet1040LaneSet();
			LaneSets.Add(schemaLaneSet1040);
			ProcessSchemaLane schemaLane3614 = CreateLane3614Lane();
			schemaLaneSet1040.Lanes.Add(schemaLane3614);
			ProcessSchemaEventSubProcess eventsubprocess13 = CreateEventSubProcess13EventSubProcess();
			FlowElements.Add(eventsubprocess13);
			ProcessSchemaStartMessageEvent startmessage12 = CreateStartMessage12StartMessageEvent();
			eventsubprocess13.FlowElements.Add(startmessage12);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent3 = CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent();
			eventsubprocess13.FlowElements.Add(intermediatethrowmessageevent3);
			ProcessSchemaScriptTask scripttask14 = CreateScriptTask14ScriptTask();
			eventsubprocess13.FlowElements.Add(scripttask14);
			FlowElements.Add(CreateSequenceFlow20540SequenceFlow());
			FlowElements.Add(CreateSequenceFlow20541SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20540SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20540",
				UId = new Guid("8c224283-f933-4b7c-a72f-7bb878c89db9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("60b5d318-586e-4a29-a59d-a5fce8632d18"),
				CurveCenterPosition = new Point(156, 102),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("60b5d318-586e-4a29-a59d-a5fce8632d18"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("88e696a6-5a92-4ea1-82d4-687c9acc2c03"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5b817c40-40a1-4995-a92b-76246b9183cc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20541SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20541",
				UId = new Guid("9d2f2faf-e3e4-419e-b9ab-1e3e515b7171"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("60b5d318-586e-4a29-a59d-a5fce8632d18"),
				CurveCenterPosition = new Point(265, 101),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("60b5d318-586e-4a29-a59d-a5fce8632d18"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5b817c40-40a1-4995-a92b-76246b9183cc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a8504cde-666a-4a0e-a8dc-e9db45201740"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1040LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1040 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("8711e2fe-89db-4c87-8b71-c7788e51cdb3"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("60b5d318-586e-4a29-a59d-a5fce8632d18"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("60b5d318-586e-4a29-a59d-a5fce8632d18"),
				Name = @"LaneSet1040",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(666, 214),
				UseBackgroundMode = false
			};
			return schemaLaneSet1040;
		}

		protected virtual ProcessSchemaLane CreateLane3614Lane() {
			ProcessSchemaLane schemaLane3614 = new ProcessSchemaLane(this) {
				UId = new Guid("9bfd8859-4362-4d11-b00b-f116ca5f4998"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("8711e2fe-89db-4c87-8b71-c7788e51cdb3"),
				CreatedInOwnerSchemaUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("60b5d318-586e-4a29-a59d-a5fce8632d18"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("60b5d318-586e-4a29-a59d-a5fce8632d18"),
				Name = @"Lane3614",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(637, 214),
				UseBackgroundMode = false
			};
			return schemaLane3614;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess13EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess13 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4ac668c9-ff01-4f7d-a8cf-04ae48032d2b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9bfd8859-4362-4d11-b00b-f116ca5f4998"),
				CreatedInOwnerSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("60b5d318-586e-4a29-a59d-a5fce8632d18"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("60b5d318-586e-4a29-a59d-a5fce8632d18"),
				Name = @"EventSubProcess13",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 23),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(266, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess13;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage12StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("88e696a6-5a92-4ea1-82d4-687c9acc2c03"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4ac668c9-ff01-4f7d-a8cf-04ae48032d2b"),
				CreatedInOwnerSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("60b5d318-586e-4a29-a59d-a5fce8632d18"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("60b5d318-586e-4a29-a59d-a5fce8632d18"),
				Name = @"StartMessage12",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("a8504cde-666a-4a0e-a8dc-e9db45201740"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4ac668c9-ff01-4f7d-a8cf-04ae48032d2b"),
				CreatedInOwnerSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("60b5d318-586e-4a29-a59d-a5fce8632d18"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("60b5d318-586e-4a29-a59d-a5fce8632d18"),
				Name = @"IntermediateThrowMessageEvent3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(211, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask14ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5b817c40-40a1-4995-a92b-76246b9183cc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4ac668c9-ff01-4f7d-a8cf-04ae48032d2b"),
				CreatedInOwnerSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("60b5d318-586e-4a29-a59d-a5fce8632d18"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("60b5d318-586e-4a29-a59d-a5fce8632d18"),
				Name = @"ScriptTask14",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,193,106,194,64,20,69,215,201,87,188,102,149,160,204,15,132,44,218,26,36,139,66,48,165,251,169,115,13,35,227,27,120,121,163,136,248,239,141,82,208,141,203,11,231,158,123,123,59,194,172,172,218,33,38,217,194,124,96,23,5,29,79,16,165,69,67,14,1,163,85,80,25,127,247,216,42,77,96,7,89,210,163,211,30,193,250,46,227,68,168,232,146,103,71,43,51,21,102,24,238,43,186,20,208,58,175,157,235,173,216,3,53,212,223,38,215,208,123,134,66,126,108,72,40,139,57,207,162,150,213,235,185,115,69,85,231,153,223,81,249,90,245,214,16,167,16,238,163,25,204,38,158,204,0,253,140,33,29,248,223,57,156,167,231,94,177,36,198,137,214,201,187,215,94,243,29,7,21,207,99,89,85,183,19,215,252,90,231,2,77,194,164,146,80,255,1,215,87,70,148,52,1,0,0 }
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
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6ad4b694-5a68-4f8e-93c8-16a6bd0f77d3"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d3fb8cf1-e005-49ff-9f3d-b44f37d3bade"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected override SchemaMethod CreateOkClickMethodMethod() {
			SchemaMethod method = base.CreateOkClickMethodMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,203,110,219,48,16,60,203,128,255,129,224,73,66,12,162,231,4,61,24,114,97,56,232,35,176,147,250,144,228,192,82,43,123,17,154,20,150,148,221,212,208,191,151,164,228,52,77,129,36,232,77,220,157,157,153,29,138,206,19,154,13,83,178,241,104,13,251,200,174,228,6,68,217,31,63,85,232,197,103,171,164,198,95,242,135,134,107,248,233,197,28,124,217,106,223,18,124,151,186,133,252,198,1,149,214,24,80,113,36,182,175,8,119,146,30,7,212,194,212,54,47,138,139,241,104,47,137,41,107,246,64,30,200,5,45,3,7,118,233,172,41,79,197,219,123,118,140,197,121,139,213,95,141,188,232,2,129,235,205,98,21,102,99,91,172,128,48,154,131,60,217,158,73,47,87,182,37,5,98,26,220,236,97,105,15,226,228,198,234,118,103,146,229,201,51,23,183,31,238,163,181,52,190,82,132,141,255,34,77,56,144,152,86,85,95,248,135,187,212,8,198,47,102,236,140,141,71,89,198,133,53,79,114,207,100,92,185,149,102,3,213,18,92,99,141,131,156,39,120,152,10,11,156,49,62,57,222,241,33,232,59,206,206,217,81,253,153,61,103,124,192,190,216,115,184,168,34,18,116,93,113,193,163,251,175,16,85,106,2,183,157,83,74,199,83,11,161,129,117,190,112,165,109,30,139,99,160,251,223,37,185,112,114,15,249,32,214,141,71,160,29,68,66,172,89,94,106,235,96,141,166,178,135,105,29,18,93,5,104,193,98,247,117,189,8,200,120,100,224,65,226,85,117,249,116,151,59,91,97,141,80,245,249,6,153,62,210,44,123,131,97,240,207,248,112,101,25,239,88,92,130,29,217,33,89,23,42,174,17,33,93,10,62,46,154,157,48,111,238,242,238,236,178,16,222,120,244,226,197,76,155,70,163,146,241,187,148,106,11,98,141,126,155,94,93,60,134,31,62,191,6,34,233,108,237,69,24,171,113,211,82,66,139,4,191,241,168,209,35,56,177,182,244,224,26,169,32,213,231,100,219,166,16,209,252,10,252,55,90,194,206,238,135,55,251,78,194,25,120,137,218,165,234,132,153,86,235,244,3,252,6,216,238,64,120,52,4,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateBeforeSaveRowOnConditionsCorrectMethod() {
			SchemaMethod method = base.CreateBeforeSaveRowOnConditionsCorrectMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,205,79,41,205,73,117,47,202,76,81,176,85,112,79,45,9,174,44,246,133,11,121,166,104,104,90,115,21,229,151,235,5,167,150,56,231,231,148,230,230,133,37,230,148,166,106,40,161,41,83,210,65,50,8,168,5,0,33,210,123,242,90,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetDefValuesMethod() {
			SchemaMethod method = base.CreateGetDefValuesMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,201,76,46,201,204,207,75,44,170,180,41,46,41,202,204,75,215,81,200,79,202,74,77,46,177,83,72,73,77,11,75,204,41,77,45,86,176,85,72,74,44,78,213,115,79,45,113,129,137,105,104,90,115,193,21,68,43,5,87,22,251,230,167,148,230,164,42,197,2,85,7,167,230,0,77,72,77,129,8,121,166,88,115,21,165,150,148,22,229,33,140,180,6,0,127,249,67,81,120,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleEditDetailEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("60b5d318-586e-4a29-a59d-a5fce8632d18"));
		}

		#endregion

	}

	#endregion

}

