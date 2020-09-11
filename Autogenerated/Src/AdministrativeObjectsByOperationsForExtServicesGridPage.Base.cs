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
	using System.Security;
	using System.Text;
	using System.Threading;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.OperationLog;
	using Terrasoft.Core.Packages;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.Reports;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using TSConfiguration = Terrasoft.Configuration;
	using web = System.Web;
	using WebControls = Terrasoft.UI.WebControls.Controls;

	#region Class: AdministrativeObjectsByOperationsForExtServicesGridPageSchema

	/// <exclude/>
	public class AdministrativeObjectsByOperationsForExtServicesGridPageSchema : Terrasoft.WebApp.AdministrativeObjectsByOperationsGridPageSchema
	{

		#region Constructors: Public

		public AdministrativeObjectsByOperationsForExtServicesGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AdministrativeObjectsByOperationsForExtServicesGridPageSchema(AdministrativeObjectsByOperationsForExtServicesGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714");
		}

		private void UpdateUpButton() {
			UpButton.AjaxEvents.Click.IsProcessEventHandler = true;
			UpButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45"),
				ImageHash = @"237f430c77240f66f9368acf2476bfc0"
			};
			UpButton.ModifiedInSchemaUId = new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714");
		}

		private void UpdateDownButton() {
			DownButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DownButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45"),
				ImageHash = @"237f430c77240f66f9368acf2476bfc0"
			};
			DownButton.ModifiedInSchemaUId = new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714");
		}

		private void UpdateShowRelatedRightsCheckBox() {
			ShowRelatedRightsCheckBox.AjaxEvents.Check.IsProcessEventHandler = true;
		}

		private void UpdateCheckBoxControlLayout() {
			CheckBoxControlLayout.Image = new ControlImage {};
			CheckBoxControlLayout.ModifiedInSchemaUId = new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714");
		}

		private void UpdateOwnMenuItem() {
			OwnMenuItem.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			OwnMenuItem.AjaxEvents.CheckChange.ShowLoadMask = true;
			OwnMenuItem.Image = new ControlImage {};
			OwnMenuItem.ModifiedInSchemaUId = new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714");
		}

		private void UpdateAllMenuItem() {
			AllMenuItem.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			AllMenuItem.AjaxEvents.CheckChange.ShowLoadMask = true;
			AllMenuItem.Image = new ControlImage {};
			AllMenuItem.ModifiedInSchemaUId = new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714");
		}

		private void UpdateShowRelatedRightsButton() {
			ShowRelatedRightsButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1"),
				ImageHash = @"57f7aae3209afa943cac8813eca36f32"
			};
			ShowRelatedRightsButton.ModifiedInSchemaUId = new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
			TreeGrid.AjaxEvents.SelectionChange.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714");
			RealUId = new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714");
			Name = "AdministrativeObjectsByOperationsForExtServicesGridPage";
			ParentSchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			HelpContextId = "792";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAdministrativeObjectsByOperationsForExtServicesGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateTreeGrid();
			UpdateShowChangelogMenuItem();
			UpdateCallMenuItem();
			UpdateSendTemplateEmailMenuItem();
			UpdateSendEmailMenuItem();
			UpdateButtonsControlLayout();
			UpdateActionButton();
			UpdateContextHelpButton();
			UpdateShowRelatedRightsButton();
			UpdateAllMenuItem();
			UpdateOwnMenuItem();
			UpdatePrintButton();
			UpdateCheckBoxControlLayout();
			UpdateShowRelatedRightsCheckBox();
			UpdateDownButton();
			UpdateUpButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateCopyButton();
			UpdateAddButton();
			TopLevelControl.MoveItem(0, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.MoveItem(4, UpButton);
			ButtonsControlLayout.MoveItem(5, DownButton);
			ButtonsControlLayout.MoveItem(6, CheckBoxControlLayout);
			CheckBoxControlLayout.MoveItem(0, ShowRelatedRightsCheckBox);
			ButtonsControlLayout.MoveItem(7, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(8, PrintButton);
			ButtonsControlLayout.MoveItem(9, ShowRelatedRightsButton);
			ShowRelatedRightsButton.MoveItem(0, OwnMenuItem);
			ShowRelatedRightsButton.MoveItem(1, AllMenuItem);
			ButtonsControlLayout.MoveItem(10, ContextHelpButton);
			ButtonsControlLayout.MoveItem(11, ActionButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateAdministrativeObjectsByOperationsForExtServicesGridPageEventsProcessSchema() {
			var schema = new AdministrativeObjectsByOperationsForExtServicesGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.Columns.FindByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.IsVisible = false;
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("d27e9964-a7a6-46dd-9f9a-7cb470c33b98");
			if (column != null) {
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714");
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new AdministrativeObjectsByOperationsForExtServicesGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new AdministrativeObjectsByOperationsForExtServicesGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AdministrativeObjectsByOperationsForExtServicesGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeObjectsByOperationsForExtServicesGridPageEventsProcess

	/// <exclude/>
	public class AdministrativeObjectsByOperationsForExtServicesGridPageEventsProcess<TPage> : Terrasoft.WebApp.AdministrativeObjectsByOperationsGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AdministrativeObjectsByOperationsForExtServicesGridPageSchemaUserControl
	{

		public AdministrativeObjectsByOperationsForExtServicesGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdministrativeObjectsByOperationsForExtServicesGridPageEventsProcess";
			SchemaUId = new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714");
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

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("9ca9d8ce-f985-4d3b-b58b-cb89e53300c9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage1;
		public ProcessFlowElement StartMessage1 {
			get {
				return _startMessage1 ?? (_startMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage1",
					SchemaElementUId = new Guid("b059c661-03f1-483d-8e35-6bf28484c382"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage2;
		public ProcessFlowElement StartMessage2 {
			get {
				return _startMessage2 ?? (_startMessage2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage2",
					SchemaElementUId = new Guid("18af8380-494a-442f-af1b-b487d7cbba2e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent1 {
			get {
				return _intermediateThrowMessageEvent1 ?? (_intermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("9914cef6-bfe6-432c-898f-d1d4c70a24c0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent2;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent2 {
			get {
				return _intermediateThrowMessageEvent2 ?? (_intermediateThrowMessageEvent2 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent2",
					SchemaElementUId = new Guid("d5219369-e9ed-40c5-9392-5cb36b302cc7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptTaskInit;
		public ProcessScriptTask ScriptTaskInit {
			get {
				return _scriptTaskInit ?? (_scriptTaskInit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskInit",
					SchemaElementUId = new Guid("c9247790-f08b-4f05-b663-8ab7bdf431d9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskInitExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[ScriptTaskInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskInit };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("ScriptTaskInit");
						break;
					case "IntermediateThrowMessageEvent2":
						e.Context.QueueTasks.Enqueue("ScriptTaskInit");
						break;
					case "ScriptTaskInit":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage1");
			ActivatedEventElements.Add("StartMessage2");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent2.Execute(context);
					break;
				case "ScriptTaskInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskInit";
					result = ScriptTaskInit.Execute(context, ScriptTaskInitExecute);
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

		public virtual bool ScriptTaskInitExecute(ProcessExecutingContext context) {
			// VirtualDataSourceID = "OperationRightsVirtualDataSource";
			// OperationRightCode = "CanChangeEntitySchemaOperationRightLevel";
			RightsSchemaName = "SysExtServiceOperationRight";
			// RightsGrouppingColumnNames = "SubjectSchemaId";
			return true;
		}

		public override void ChangeRightItemPosition(Guid primaryColumnValue, int position, bool increasePosition, string subjectSchema) {
			base.ChangeRightItemPosition(primaryColumnValue, position, increasePosition, subjectSchema);
			OperationLogger.Instance.LogEntitySchemaExternalServiceRightEdit(Page.UserConnection, primaryColumnValue);
		}

		public override void RedactedSelectedUser(Guid recordId, string redactedColumnName) {
			VirtualDataSource virtualDataSource = GetVirtualDataSource();
			EntitySchema schema = Page.DataSource.Schema;
			Entity entity = schema.CreateEntity(Page.UserConnection);
			if (entity.FetchFromDB(recordId)) {
				DBSecurityEngine securityEngine = UserConnection.DBSecurityEngine;
				Guid subjectSchemaId = entity.GetTypedColumnValue<Guid>("SubjectSchemaUId");
				string entitySchemaName = UserConnection.EntitySchemaManager.GetItemByUId(subjectSchemaId).Name;
				Guid adminUnitId = entity.GetTypedColumnValue<Guid>("SysAdminUnitId");
				bool isAllowed = !entity.GetTypedColumnValue<bool>(redactedColumnName);
				SchemaOperationRightLevels rightLevel = SchemaOperationRightLevels.None;
				try {
					switch (redactedColumnName) {
						case "CanRead":
							securityEngine.SetEntitySchemaReadingAllowed(adminUnitId, entitySchemaName, isAllowed);
							securityEngine.SetExtServiceOperationAllowed(adminUnitId, entitySchemaName, SchemaOperationRightLevels.CanRead, isAllowed);
							break;
						case "CanAppend":
							securityEngine.SetEntitySchemaAppendingAllowed(adminUnitId, entitySchemaName, isAllowed);
							securityEngine.SetExtServiceOperationAllowed(adminUnitId, entitySchemaName, SchemaOperationRightLevels.CanAppend, isAllowed);
							break;
						case "CanEdit":
							securityEngine.SetEntitySchemaEditingAllowed(adminUnitId, entitySchemaName, isAllowed);
							securityEngine.SetExtServiceOperationAllowed(adminUnitId, entitySchemaName, SchemaOperationRightLevels.CanEdit, isAllowed);
							break;
						case "CanDelete":
							securityEngine.SetEntitySchemaDeletingAllowed(adminUnitId, entitySchemaName, isAllowed);
							securityEngine.SetExtServiceOperationAllowed(adminUnitId, entitySchemaName, SchemaOperationRightLevels.CanDelete, isAllowed);
							break;
					}
				} catch (SecurityException securityException) {
					MessagePanel messagePanel = ControlUtilities.FindControl(Page.AspPage.Controls[0], "BaseMessagePanel", true) as MessagePanel;
					if (messagePanel != null) {
						messagePanel.Clear();
						messagePanel.AddMessage(Warning, securityException.Message, MessageType.Warning);
					}
				}
				securityEngine.ClearOperationRightsCache();
			}
			virtualDataSource.LoadRow(recordId, null);
		}

		public override Guid SetOperationsRightLevel(Guid adminUnitId, Guid schemaUId, SchemaOperationRightLevels rightLevel) {
			return UserConnection.DBSecurityEngine.SetExtServiceOperationsRightLevel(adminUnitId, schemaUId, rightLevel);
		}

		public override string GetOperationRightSchemaName() {
			return "SysExtServiceOperationRight";
		}

		public override void DeleteOperationsRightLevel(Guid recordId) {
			UserConnection.DBSecurityEngine.DeleteExtServiceOperationsRightLevel(recordId);
		}

		public override void SetIsAdministratedByOperations() {
			IsOperationAdministrated = true;
		}

		public override Guid SetOperationAllowed(Guid adminUnitId, Guid schemaUId, SchemaOperationRightLevels operation, bool isAllowed) {
			return  UserConnection.DBSecurityEngine.SetExtServiceOperationAllowed(adminUnitId, schemaUId, operation, isAllowed);
		}

		public override void SetEntitySchemaAdministratedByOperations(Guid schemaId, bool isAdministrated) {
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComlete":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
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

	#region Class: AdministrativeObjectsByOperationsForExtServicesGridPageEventsProcess

	/// <exclude/>
	public class AdministrativeObjectsByOperationsForExtServicesGridPageEventsProcess : AdministrativeObjectsByOperationsForExtServicesGridPageEventsProcess<Terrasoft.WebApp.AdministrativeObjectsByOperationsForExtServicesGridPageSchemaUserControl>
	{

		public AdministrativeObjectsByOperationsForExtServicesGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdministrativeObjectsByOperationsForExtServicesGridPageSchemaUserControl

	/// <exclude/>
	public partial class AdministrativeObjectsByOperationsForExtServicesGridPageSchemaUserControl : Terrasoft.WebApp.AdministrativeObjectsByOperationsGridPageSchemaUserControl
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
			var process = (AdministrativeObjectsByOperationsForExtServicesGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AdministrativeObjectsByOperationsForExtServicesGridPageEventsProcess(UserConnection);
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
			SchemaName = "AdministrativeObjectsByOperationsForExtServicesGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeObjectsByOperationsForExtServicesGridPageEventsProcessSchema

	/// <exclude/>
	public class AdministrativeObjectsByOperationsForExtServicesGridPageEventsProcessSchema : Terrasoft.WebApp.AdministrativeObjectsByOperationsGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public AdministrativeObjectsByOperationsForExtServicesGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AdministrativeObjectsByOperationsForExtServicesGridPageEventsProcessSchema(AdministrativeObjectsByOperationsForExtServicesGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AdministrativeObjectsByOperationsForExtServicesGridPageEventsProcess";
			UId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage1);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage2);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaScriptTask scripttaskinit = CreateScriptTaskInitScriptTask();
			eventsubprocess1.FlowElements.Add(scripttaskinit);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("d5b5b594-336e-4d1e-9ae3-3b3056bfaa39"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"),
				CurveCenterPosition = new Point(215, 86),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b059c661-03f1-483d-8e35-6bf28484c382"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9914cef6-bfe6-432c-898f-d1d4c70a24c0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("f287d3ad-f6b0-4c72-89f6-75e3565138d8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"),
				CurveCenterPosition = new Point(218, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("18af8380-494a-442f-af1b-b487d7cbba2e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d5219369-e9ed-40c5-9392-5cb36b302cc7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("f82c9ee5-31eb-4560-af48-ecdd665a3575"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"),
				CurveCenterPosition = new Point(287, 127),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9914cef6-bfe6-432c-898f-d1d4c70a24c0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c9247790-f08b-4f05-b663-8ab7bdf431d9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("2e66438f-1aa9-4906-8f31-95a2726effe1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"),
				CurveCenterPosition = new Point(284, 178),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d5219369-e9ed-40c5-9392-5cb36b302cc7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c9247790-f08b-4f05-b663-8ab7bdf431d9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("12c81b8e-7544-410b-9c57-570ea2122c43"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(889, 415),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("f3621139-e9f2-44a9-a19a-e2412c29ccd8"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("12c81b8e-7544-410b-9c57-570ea2122c43"),
				CreatedInOwnerSchemaUId = new Guid("ed91c906-bc01-4ac3-a2a5-98c2008fb714"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(860, 415),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9ca9d8ce-f985-4d3b-b58b-cb89e53300c9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f3621139-e9f2-44a9-a19a-e2412c29ccd8"),
				CreatedInOwnerSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(64, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(371, 392),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b059c661-03f1-483d-8e35-6bf28484c382"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9ca9d8ce-f985-4d3b-b58b-cb89e53300c9"),
				CreatedInOwnerSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(49, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("18af8380-494a-442f-af1b-b487d7cbba2e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9ca9d8ce-f985-4d3b-b58b-cb89e53300c9"),
				CreatedInOwnerSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComlete",
				ModifiedInSchemaUId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"),
				Name = @"StartMessage2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(49, 182),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("9914cef6-bfe6-432c-898f-d1d4c70a24c0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9ca9d8ce-f985-4d3b-b58b-cb89e53300c9"),
				CreatedInOwnerSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(126, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("d5219369-e9ed-40c5-9392-5cb36b302cc7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9ca9d8ce-f985-4d3b-b58b-cb89e53300c9"),
				CreatedInOwnerSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(126, 182),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c9247790-f08b-4f05-b663-8ab7bdf431d9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9ca9d8ce-f985-4d3b-b58b-cb89e53300c9"),
				CreatedInOwnerSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"),
				Name = @"ScriptTaskInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(189, 105),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,205,65,10,131,48,16,133,225,125,161,119,8,94,32,7,144,174,162,20,161,180,96,160,251,105,28,52,69,19,25,103,164,222,190,196,116,35,221,255,223,123,90,171,167,39,22,24,43,96,176,81,200,97,83,169,139,42,30,51,18,176,143,161,245,253,192,203,95,85,148,231,147,214,234,152,153,216,97,194,6,130,25,32,244,88,7,246,188,89,55,224,4,199,244,134,43,142,105,36,239,231,228,14,211,238,237,182,212,31,182,72,171,119,120,116,191,223,172,174,20,101,158,125,232,77,28,101,10,137,47,187,151,215,27,29,231,209,166,75,134,144,133,130,98,18,44,191,60,102,221,115,246,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9d7efbbf-8549-484c-9592-82bf90843f5d"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("95c66740-e509-4ca4-b1ef-c7a6bb406ec0"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7c7fbab2-546c-4dd3-ba02-c8f1ddbc356d"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5869487f-ebcd-414c-9fb2-40b8f070b351"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41c60d94-6edf-44e4-9edb-0e16c226d725"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("92dceabc-4c2b-49a1-baa4-e5bdfa59f339"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa8aa1ac-15e9-42cc-9636-16aa514d5797"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10a2ccab-756c-4712-b1b8-f4ebab9f54a0"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f5452a8-39be-4d73-aff7-044da2a7684d"),
				Name = "System.Threading",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0655a6cd-c0cc-42ef-b029-8e7b7f8cbd5b"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("17212d8c-b11f-4e06-a811-afae9b4bf246"),
				Name = "Terrasoft.Core.OperationLog",
				Alias = "",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("57e43cd6-21b8-4cf0-8269-102825ad68c4"),
				Name = "Terrasoft.Core.OperationLog",
				Alias = "",
				CreatedInPackageId = new Guid("0bea0088-e6a2-4f3a-b02e-e01a15923e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4cb6d400-f8bb-48de-a251-d01086f4fa90"),
				Name = "System.Security",
				Alias = "",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f6d0c1c0-59dd-466d-9521-afefd098b9ec"),
				Name = "Terrasoft.Core.Packages",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		protected override SchemaMethod CreateChangeRightItemPositionMethod() {
			SchemaMethod method = base.CreateChangeRightItemPositionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,78,189,14,130,48,16,222,125,10,70,72,72,95,128,145,48,144,152,216,72,116,63,234,165,61,67,175,228,122,24,121,123,81,140,139,227,247,255,141,144,209,180,1,216,227,153,124,208,94,49,218,148,73,41,113,57,11,69,144,181,77,211,18,249,10,211,130,117,49,127,197,186,32,118,130,91,220,254,152,188,140,119,116,58,184,128,17,170,230,112,154,81,224,45,29,147,247,40,166,231,172,192,14,205,134,59,86,210,117,183,118,79,69,97,152,6,148,7,185,253,72,119,35,45,45,120,52,151,140,210,38,230,173,249,179,242,255,170,106,94,8,253,4,244,199,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateRedactedSelectedUserMethod() {
			SchemaMethod method = base.CreateRedactedSelectedUserMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,86,203,142,218,48,20,93,103,164,249,7,79,86,65,138,172,174,75,25,137,231,8,105,102,58,130,66,23,85,23,38,190,5,183,142,29,217,14,12,170,230,223,107,199,33,36,64,81,182,108,48,185,207,115,206,13,215,44,153,50,57,225,35,98,200,92,230,42,1,180,61,179,244,208,19,152,229,169,57,234,116,239,239,198,194,48,179,159,39,27,72,9,210,254,232,161,55,178,6,124,140,196,222,95,133,35,240,71,175,204,192,67,5,196,128,119,70,69,242,66,131,26,74,33,32,49,76,10,215,137,253,66,145,207,195,19,48,201,102,162,100,58,26,68,10,18,169,232,148,118,58,232,239,253,93,48,26,204,33,201,149,141,26,139,53,19,128,116,243,177,135,154,149,241,105,130,237,20,60,229,140,34,157,175,126,219,24,15,125,74,109,102,217,221,106,241,109,159,1,29,74,158,167,98,73,120,14,95,92,198,99,20,206,235,57,139,41,13,29,240,64,27,197,196,186,76,247,190,87,146,94,192,82,23,243,133,8,171,131,114,221,166,6,210,193,222,150,139,78,48,117,176,171,83,33,38,52,101,98,33,152,105,139,118,175,251,199,20,143,117,37,37,71,76,247,57,151,59,112,101,30,174,212,113,193,143,118,2,148,36,230,224,113,136,138,74,30,228,215,12,20,113,228,102,108,189,49,207,176,5,174,145,170,190,219,6,255,143,195,175,210,207,195,168,125,49,220,64,239,152,157,60,186,212,210,7,4,9,209,128,194,33,17,51,32,52,252,92,216,130,230,59,128,231,96,234,74,187,72,59,159,146,114,84,83,49,62,155,89,124,212,166,32,121,185,248,187,153,131,218,178,4,42,86,45,139,95,209,162,164,116,1,192,202,254,120,254,116,155,236,251,89,6,162,37,127,31,123,19,10,120,168,45,53,24,83,102,218,41,224,34,111,130,191,3,218,146,253,8,56,24,104,199,191,136,189,9,1,60,171,171,18,124,216,143,15,148,144,98,81,84,187,253,61,129,204,213,59,222,7,7,75,185,57,94,64,107,187,112,223,136,176,91,41,173,63,244,144,93,209,70,73,190,48,140,219,23,5,52,158,48,65,75,163,191,174,250,58,43,206,210,168,127,124,250,25,163,112,96,135,81,175,27,198,200,168,220,238,42,162,81,221,94,224,118,247,91,163,239,67,15,137,156,243,195,102,171,251,240,144,3,81,81,73,190,225,233,83,90,150,142,190,19,37,236,84,227,115,206,184,12,137,15,48,220,106,199,101,124,231,40,163,187,188,154,179,45,26,55,167,163,135,196,206,172,0,99,19,206,254,61,224,103,73,232,76,238,170,155,58,246,180,186,255,0,186,180,223,98,122,8,0,0 };
			return method;
		}

		protected override SchemaMethod CreateSetOperationsRightLevelMethod() {
			SchemaMethod method = base.CreateSetOperationsRightLevelMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,61,202,193,10,64,64,16,6,224,87,113,164,228,5,220,176,7,165,148,109,31,96,91,127,107,138,161,217,33,222,94,46,110,223,225,19,232,41,156,185,4,105,119,102,4,165,157,171,174,177,8,167,144,62,134,35,49,42,11,53,183,90,200,69,1,227,1,241,223,75,19,197,69,7,92,88,115,63,111,196,142,73,251,185,204,82,88,176,121,247,81,254,82,212,47,58,8,44,197,109,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetOperationRightSchemaNameMethod() {
			SchemaMethod method = base.CreateGetOperationRightSchemaNameMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,80,10,174,44,118,173,40,9,78,45,42,203,76,78,245,47,72,45,74,44,201,204,207,11,202,76,207,40,81,178,6,0,204,178,81,112,37,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateDeleteOperationsRightLevelMethod() {
			SchemaMethod method = base.CreateDeleteOperationsRightLevelMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,21,202,65,10,128,32,16,5,208,235,212,198,11,180,43,93,4,65,144,116,128,208,143,13,200,24,227,36,117,251,232,173,223,94,33,83,97,70,80,42,108,236,232,17,110,33,125,29,39,98,24,139,12,133,123,212,67,26,5,172,23,228,248,107,221,40,157,186,160,33,119,130,80,36,206,177,31,62,95,153,130,184,79,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateSetIsAdministratedByOperationsMethod() {
			SchemaMethod method = base.CreateSetIsAdministratedByOperationsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,44,246,47,72,45,74,44,201,204,207,115,76,201,205,204,203,44,46,1,242,82,83,20,108,21,74,138,74,83,173,1,117,146,206,229,32,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateSetOperationAllowedMethod() {
			SchemaMethod method = base.CreateSetOperationAllowedMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,53,202,65,10,131,48,16,5,208,171,100,217,66,240,2,93,85,235,194,85,23,33,7,8,201,71,7,116,34,147,137,181,183,23,65,119,111,241,4,90,133,141,241,5,210,101,102,68,165,204,205,167,117,136,85,72,255,61,143,196,104,28,180,223,213,65,54,138,248,174,144,112,190,247,60,231,31,210,35,164,133,216,51,233,144,172,41,113,194,18,252,201,124,71,107,168,92,249,249,58,0,128,197,165,212,116,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateSetEntitySchemaAdministratedByOperationsMethod() {
			SchemaMethod method = base.CreateSetEntitySchemaAdministratedByOperationsMethod();
			method.IsOverride = true;
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AdministrativeObjectsByOperationsForExtServicesGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0c86c4fc-13fc-4583-9efe-da77547605e5"));
		}

		#endregion

	}

	#endregion

}

