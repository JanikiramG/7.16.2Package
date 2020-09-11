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
	using System.Text;
	using System.Threading;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
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

	#region Class: RecordAllChangesGridPageSchema

	/// <exclude/>
	public class RecordAllChangesGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Constructors: Public

		public RecordAllChangesGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public RecordAllChangesGridPageSchema(RecordAllChangesGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.Hidden = true;
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.DblClick.IsProcessEventHandler = true;
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
			RealUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
			Name = "RecordAllChangesGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			HelpContextId = "209";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateRecordAllChangesGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateTreeGrid();
			UpdateShowChangelogMenuItem();
			UpdateCallMenuItem();
			UpdateSendTemplateEmailMenuItem();
			UpdateSendEmailMenuItem();
			UpdateButtonsControlLayout();
			UpdateContextHelpButton();
			UpdatePrintButton();
			UpdateActionButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateCopyButton();
			UpdateAddButton();
			TopLevelControl.MoveItem(0, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.MoveItem(4, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(5, ActionButton);
			ButtonsControlLayout.MoveItem(6, PrintButton);
			ButtonsControlLayout.MoveItem(7, ContextHelpButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateRecordAllChangesGridPageEventsProcessSchema() {
			var schema = new RecordAllChangesGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			DataSource.ModifiedInSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("34013801-2323-4def-904a-2f4d3a266689");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
				column.ModifiedInSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("b90e17d5-7d10-443d-a97d-d718434877e6");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
				column.ModifiedInSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("abdf321f-8ed8-4960-a86e-f00d65caa865");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
				column.ModifiedInSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("e603d62a-f9fd-4304-94ba-df7b48627c00");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
				column.ModifiedInSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("637e4097-0f3b-4300-8b59-fc3c85c8447f");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
				column.ModifiedInSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
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
			return new RecordAllChangesGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new RecordAllChangesGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new RecordAllChangesGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: RecordAllChangesGridPageEventsProcess

	/// <exclude/>
	public class RecordAllChangesGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.RecordAllChangesGridPageSchemaUserControl
	{

		public RecordAllChangesGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "RecordAllChangesGridPageEventsProcess";
			SchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41");
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

		public virtual Object PreviousRow {
			get;
			set;
		}

		public virtual bool HighlightColumns {
			get;
			set;
		}

		public virtual bool HighlightColumnsCheckPerformed {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("074dec6b-de12-4d45-acbd-9c9caaf3f2de"),
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
					SchemaElementUId = new Guid("21cecfed-aad5-458d-8a59-4d4324b82122"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("aef29484-9722-4891-a9d7-641ebc699997"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess10;
		public ProcessFlowElement EventSubProcess10 {
			get {
				return _eventSubProcess10 ?? (_eventSubProcess10 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess10",
					SchemaElementUId = new Guid("64941253-b61e-47ec-8e20-725567e82d4c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage5;
		public ProcessFlowElement StartMessage5 {
			get {
				return _startMessage5 ?? (_startMessage5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage5",
					SchemaElementUId = new Guid("cb4f3280-dcf7-4cf5-bd3d-ba462efa2a16"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask4;
		public ProcessScriptTask ScriptTask4 {
			get {
				return _scriptTask4 ?? (_scriptTask4 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4",
					SchemaElementUId = new Guid("16fd4318-a1d8-4610-be1c-87793f8a563e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess11;
		public ProcessFlowElement EventSubProcess11 {
			get {
				return _eventSubProcess11 ?? (_eventSubProcess11 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess11",
					SchemaElementUId = new Guid("247e676b-329d-4b57-99ca-b5013d6f5b5c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage6;
		public ProcessFlowElement StartMessage6 {
			get {
				return _startMessage6 ?? (_startMessage6 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage6",
					SchemaElementUId = new Guid("b3d52290-a674-4da4-92ca-0bb2e5ebdd60"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask5;
		public ProcessScriptTask ScriptTask5 {
			get {
				return _scriptTask5 ?? (_scriptTask5 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask5",
					SchemaElementUId = new Guid("7952a871-affe-4fbb-b7fb-babad163fe44"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask5Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess12;
		public ProcessFlowElement EventSubProcess12 {
			get {
				return _eventSubProcess12 ?? (_eventSubProcess12 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess12",
					SchemaElementUId = new Guid("2e4022fc-9c5a-4dc3-a2c6-f398623cce0d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage7;
		public ProcessFlowElement StartMessage7 {
			get {
				return _startMessage7 ?? (_startMessage7 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage7",
					SchemaElementUId = new Guid("f9bbf389-c3f4-43fb-b290-c799c2e264fa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _treeGridDblClickScriptTask6;
		public ProcessScriptTask TreeGridDblClickScriptTask6 {
			get {
				return _treeGridDblClickScriptTask6 ?? (_treeGridDblClickScriptTask6 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "TreeGridDblClickScriptTask6",
					SchemaElementUId = new Guid("a69a7d39-e352-4a6c-8314-e8179c34736c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = TreeGridDblClickScriptTask6Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess9;
		public ProcessFlowElement EventSubProcess9 {
			get {
				return _eventSubProcess9 ?? (_eventSubProcess9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess9",
					SchemaElementUId = new Guid("2b5b9a9f-43e1-4ec0-a2ae-000434abd052"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4;
		public ProcessFlowElement StartMessage4 {
			get {
				return _startMessage4 ?? (_startMessage4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4",
					SchemaElementUId = new Guid("bc44eba4-e46a-4e05-88ae-8c459281d8dd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _initScriptTask3;
		public ProcessScriptTask InitScriptTask3 {
			get {
				return _initScriptTask3 ?? (_initScriptTask3 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitScriptTask3",
					SchemaElementUId = new Guid("e25eeee3-c165-4b31-a6b8-0e57b3a55bb3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTask3Execute,
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
					SchemaElementUId = new Guid("57c41220-c3d6-47b2-81f9-ce5f9320f13a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess8;
		public ProcessFlowElement EventSubProcess8 {
			get {
				return _eventSubProcess8 ?? (_eventSubProcess8 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess8",
					SchemaElementUId = new Guid("7224accb-42a5-4ae8-a6d1-de7b9cf4458f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3;
		public ProcessFlowElement StartMessage3 {
			get {
				return _startMessage3 ?? (_startMessage3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3",
					SchemaElementUId = new Guid("10344222-1502-4b10-a94a-14e9610e47fb"),
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
					SchemaElementUId = new Guid("eeffacd4-b9b3-48bf-a6b6-7481be78ae3d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _pageLoadCompleteScriptTask;
		public ProcessScriptTask PageLoadCompleteScriptTask {
			get {
				return _pageLoadCompleteScriptTask ?? (_pageLoadCompleteScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageLoadCompleteScriptTask",
					SchemaElementUId = new Guid("2ce11531-605b-4ea2-9827-9add050f625a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[StartMessage5.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage5 };
			FlowElements[ScriptTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4 };
			FlowElements[EventSubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess11 };
			FlowElements[StartMessage6.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage6 };
			FlowElements[ScriptTask5.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask5 };
			FlowElements[EventSubProcess12.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess12 };
			FlowElements[StartMessage7.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage7 };
			FlowElements[TreeGridDblClickScriptTask6.SchemaElementUId] = new Collection<ProcessFlowElement> { TreeGridDblClickScriptTask6 };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[StartMessage4.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4 };
			FlowElements[InitScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask3 };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[StartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
					case "EventSubProcess10":
						break;
					case "StartMessage5":
						e.Context.QueueTasks.Enqueue("ScriptTask4");
						break;
					case "ScriptTask4":
						break;
					case "EventSubProcess11":
						break;
					case "StartMessage6":
						e.Context.QueueTasks.Enqueue("ScriptTask5");
						break;
					case "ScriptTask5":
						break;
					case "EventSubProcess12":
						break;
					case "StartMessage7":
						e.Context.QueueTasks.Enqueue("TreeGridDblClickScriptTask6");
						break;
					case "TreeGridDblClickScriptTask6":
						break;
					case "EventSubProcess9":
						break;
					case "StartMessage4":
						e.Context.QueueTasks.Enqueue("InitScriptTask3");
						break;
					case "InitScriptTask3":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "IntermediateThrowMessageEvent2":
						break;
					case "EventSubProcess8":
						break;
					case "StartMessage3":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("StartMessage5");
			ActivatedEventElements.Add("StartMessage6");
			ActivatedEventElements.Add("StartMessage7");
			ActivatedEventElements.Add("StartMessage4");
			ActivatedEventElements.Add("StartMessage3");
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
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage5":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage5";
					result = StartMessage5.Execute(context);
					break;
				case "ScriptTask4":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4";
					result = ScriptTask4.Execute(context, ScriptTask4Execute);
					break;
				case "EventSubProcess11":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage6":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage6";
					result = StartMessage6.Execute(context);
					break;
				case "ScriptTask5":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask5";
					result = ScriptTask5.Execute(context, ScriptTask5Execute);
					break;
				case "EventSubProcess12":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage7":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage7";
					result = StartMessage7.Execute(context);
					break;
				case "TreeGridDblClickScriptTask6":
					context.QueueTasks.Dequeue();
					context.SenderName = "TreeGridDblClickScriptTask6";
					result = TreeGridDblClickScriptTask6.Execute(context, TreeGridDblClickScriptTask6Execute);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4";
					result = StartMessage4.Execute(context);
					break;
				case "InitScriptTask3":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitScriptTask3";
					result = InitScriptTask3.Execute(context, InitScriptTask3Execute);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent2.Execute(context);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3";
					result = StartMessage3.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "PageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask";
					result = PageLoadCompleteScriptTask.Execute(context, PageLoadCompleteScriptTaskExecute);
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

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "HighlightColumnsCheckPerformed":
					HighlightColumnsCheckPerformed = reader.GetValue<System.Boolean>();
				break;
				case "HighlightColumns":
					HighlightColumns = reader.GetValue<System.Boolean>();
				break;
				case "PreviousRow":
					PreviousRow = reader.GetSerializableObjectValue();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ScriptTask4Execute(ProcessExecutingContext context) {
			var dataSource = Page.DataSource;
			if (dataSource.Schema == null) {
				return true;
			}
			var filterGroup = dataSource.FindFiltersGroupByName("LogFilters");
			if (filterGroup != null) {
				dataSource.CurrentStructure.Filters.Remove(filterGroup);
			}
			filterGroup = dataSource.CurrentStructure.CreateFiltersGroup("LogFilters", LogicalOperationStrict.And);
			var filter = dataSource.CurrentStructure.CreateFilterWithParameters(dataSource.Schema,Terrasoft.Core.Entities.FilterComparisonType.Equal, "ChangeTracked" , SelectedNodePrimaryColumnValue);
			filter.IsEnabled = true;
			filterGroup.Add(filter);
			dataSource.CurrentStructure.Filters.Add(filterGroup);
			return true;
		}

		public virtual bool ScriptTask5Execute(ProcessExecutingContext context) {
			var dataSource = Page.DataSource;
			if (dataSource.Schema == null) {
				return true;
			}
			Page.TreeGrid.Clear();
			dataSource.LoadRows();
			return true;
		}

		public virtual bool TreeGridDblClickScriptTask6Execute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool InitScriptTask3Execute(ProcessExecutingContext context) {
			IsDetailGrid =  true;
			HighlightColumnsCheckPerformed = false;
			Page.TreeGrid.GetRowConfigHandler = GetRowConfig;
			Page.DataSource.Loaded += Page.TreeGrid.DataLoaded;
			var defValuesId = Page.GetParameterValue("defValuesId");
			if(defValuesId != null) {
				var parameters = (Dictionary<string,object>)UserConnection.SessionData[defValuesId.ToString()];
				if (parameters["schemaId"] != null) {
					SysEntitySchemaId = (Guid) parameters["schemaId"];
				}
				var page = Page.AspPage as Terrasoft.UI.WebControls.Page;		
				if (page.UseProfile) {	
					var args = new ProfileKeyEventArgs();
					args.Key = SysEntitySchemaId.ToString() + "_DETAIL";
					page.InitializeProfile(args, true);
				}
			}
			return true;
		}

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			var defValuesId = Page.GetParameterValue("defValuesId");
			if(defValuesId != null) {
				var parameters = (Dictionary<string,object>)UserConnection.SessionData[defValuesId.ToString()];
				if (parameters["schemaId"] != null) {
					SysEntitySchemaId = (Guid)parameters["schemaId"];
				}
				object entityIdObj;
				bool success = parameters.TryGetValue("entityId", out entityIdObj); 
				if (success) {
					SelectedNodePrimaryColumnValue = Guid.Parse(entityIdObj.ToString());
				}
			}
			var dataSource = Page.DataSource;
			dataSource.CurrentStructure.Columns.Clear();
			var schema = UserConnection.EntitySchemaManager.GetInstanceByUId(SysEntitySchemaId);
			EntitySchema logSchema = (schema as EntitySchema).GetTrackChangesInDBSchema();
			Guid logSchemaUId = logSchema.UId;
			dataSource.Schema = logSchema;
			InitializeDataSourceCurrentStructure(); 
			var page = Page.AspPage as Terrasoft.UI.WebControls.Page;
			if (page.UseProfile) {
				dataSource.IsProfileReaded = false;
				dataSource.InitializeProfile();
			}
			dataSource.LoadRows();
			return true;
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public virtual void InitializeDataSourceCurrentStructure() {
			var dataSource = Page.DataSource;
			var schema = dataSource.Schema;
			if (schema.PrimaryColumn == null) {
				throw new NullOrEmptyException(new LocalizableString("Terrasoft.Core",
					"EntitySchema.Exception.Unspecified.PrimaryColumn"), schema.Name);
			}
			DataSourceStructure currentStructure = dataSource.CurrentStructure;
			Guid schemaPrimaryColumnUId = (schema.PrimaryColumn != null) ? schema.PrimaryColumn.UId : Guid.Empty;
			if (schemaPrimaryColumnUId != Guid.Empty) {
				currentStructure.AddColumnByMetaPath(schemaPrimaryColumnUId.ToString()).IsVisible = false;
			}
			Guid schemaPrimaryDisplayColumnUId = (schema.PrimaryDisplayColumn != null) ? schema.PrimaryDisplayColumn.UId : Guid.Empty;
			if (schemaPrimaryDisplayColumnUId != Guid.Empty) {
				currentStructure.AddColumnByMetaPath(schemaPrimaryDisplayColumnUId.ToString()).IsVisible = true;
			}
			EntitySchemaColumn modifiedByColumn = schema.FindSchemaColumnByPath("ChangeTrackedBy");
			EntitySchemaColumn modifiedOnColumn = schema.FindSchemaColumnByPath("ChangeTrackedOn");
			EntitySchemaColumn changeTypeColumn = schema.FindSchemaColumnByPath("ChangeType");
			if (modifiedByColumn != null) {
				currentStructure.AddColumnByMetaPath(modifiedByColumn.UId.ToString());
			}
			if (modifiedOnColumn != null) {
				var structureColumn = currentStructure.AddColumnByMetaPath(modifiedOnColumn.UId.ToString());
				structureColumn.OrderPosition = 1;
				structureColumn.OrderDirection = OrderDirection.Descending;
			}
			if (changeTypeColumn != null) {
				currentStructure.AddColumnByMetaPath(changeTypeColumn.UId.ToString());
			}
			//var entitySchema = Schema as EntitySchema;
			var entitySchema = dataSource.Schema;
			foreach (EntitySchemaColumn column in entitySchema.Columns)
				if (column.IsTrackChangesInDB) {
					EntitySchemaColumn logColumn = schema.FindSchemaColumnByPath(column.Name);		
					if ((entitySchema.PrimaryDisplayColumn != null) && (entitySchema.PrimaryDisplayColumn.Name != logColumn.Name)) {		
						currentStructure.AddColumnByMetaPath(logColumn.UId.ToString());
					}
			}
		}

		public virtual DataSourceRowConfig GetRowConfig(Entity row) {
			if (!HighlightColumnsCheckPerformed) {
				HighlightColumns = GetColumnsHighlightState();
				HighlightColumnsCheckPerformed = true;
			}
			string primaryColumnName = row.Schema.PrimaryColumn.Name;
			string primaryColumnValue = row.GetColumnValue(primaryColumnName).ToString();
			string backgroundColor = "";
			var config = new DataSourceRowConfig(primaryColumnValue);
			if (row.GetColumnValueNames().Contains("ChangeTypeId")) {
				Guid changeType = row.GetTypedColumnValue<Guid>("ChangeTypeId");
				if (changeType == new Guid("A852C33F-0BDD-E011-92C3-00155D04C01D")) {
					backgroundColor = "Green";
				} else if (changeType == new Guid("AA52C33F-0BDD-E011-92C3-00155D04C01D")) {
					backgroundColor = "Red";
				} else {
					backgroundColor = "Blue";
				}
			}
			var cellsBackground = new Dictionary<string, DataSourceRowColumnBackgroundColorConfigValue>();
			if (PreviousRow != null && HighlightColumns) {
				var previousRow = PreviousRow as Entity;
				foreach (var column in row.Schema.Columns) {
					if ((column.Name != "ModifiedOn") && (column.Name != "ModifiedBy") 
						&& (column.Name != "ChangeTrackedBy") && (column.Name != "ChangeTrackedOn")
						&& (column.Name != "ChangeType")) {
						EntityColumnValue currentValue = row.FindEntityColumnValue(column.Name);
						EntityColumnValue prevValue = previousRow.FindEntityColumnValue(column.Name);
						if (currentValue != null && prevValue != null && !Object.Equals(currentValue.Value, prevValue.Value)) {
							cellsBackground.Add(column.Name, new DataSourceRowColumnBackgroundColorConfigValue("#FFF30F"));
						}
					}
				}
			}
			PreviousRow = row;
			config.AddConfig(new DataSourceRowColorConfigValue(backgroundColor));
			config.AddConfig(new DataSourceRowColumnsBackgroundColorConfigValue(cellsBackground));
			return config;
		}

		public override string GetRegisterEditPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return string.Empty;
		}

		public override void CreateContextMenu() {
			return;
		}

		public virtual bool GetColumnsHighlightState() {
			var dataSourceStructure = Page.DataSource.CurrentStructure;
			foreach (var structureColumn in dataSourceStructure.Columns) {
				string columnName = structureColumn.Name;
				if ((columnName != "ChangeTrackedOn") && (columnName != "ModifiedOn")
					&& (structureColumn.IsSortable) && (structureColumn.OrderPosition != 0)) {
					return false;
				}
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "DataSourceActiveRowChanged":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
							ProcessQueue(context);
							return;
						}
						break;
					case "BasePrepareFilters":
							if (ActivatedEventElements.Contains("StartMessage5")) {
							context.QueueTasks.Enqueue("StartMessage5");
							ProcessQueue(context);
							return;
						}
						break;
					case "GridPageRefreshRow":
							if (ActivatedEventElements.Contains("StartMessage6")) {
							context.QueueTasks.Enqueue("StartMessage6");
							ProcessQueue(context);
							return;
						}
						break;
					case "TreeGridDblClick":
							if (ActivatedEventElements.Contains("StartMessage7")) {
							context.QueueTasks.Enqueue("StartMessage7");
							ProcessQueue(context);
							return;
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("StartMessage4")) {
							context.QueueTasks.Enqueue("StartMessage4");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessage3")) {
							context.QueueTasks.Enqueue("StartMessage3");
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
			if (!HasMapping("HighlightColumnsCheckPerformed") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("HighlightColumnsCheckPerformed", HighlightColumnsCheckPerformed, false);
			}
			if (!HasMapping("HighlightColumns") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("HighlightColumns", HighlightColumns, false);
			}
			if (PreviousRow != null) {
				if (PreviousRow.GetType().IsSerializable ||
					PreviousRow.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("PreviousRow", PreviousRow, null);
				}
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: RecordAllChangesGridPageEventsProcess

	/// <exclude/>
	public class RecordAllChangesGridPageEventsProcess : RecordAllChangesGridPageEventsProcess<Terrasoft.WebApp.RecordAllChangesGridPageSchemaUserControl>
	{

		public RecordAllChangesGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: RecordAllChangesGridPageSchemaUserControl

	/// <exclude/>
	public partial class RecordAllChangesGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			TreeGrid.AjaxEvents.DblClick.Event += TreeGridDblClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			TreeGrid.AjaxEvents.DblClick.Event -= TreeGridDblClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (RecordAllChangesGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new RecordAllChangesGridPageEventsProcess(UserConnection);
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

		public virtual void TreeGridDblClick(object sender, EventArgs e) {
			object result = ThrowEvent("TreeGridDblClick");
		}

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
			SchemaName = "RecordAllChangesGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: RecordAllChangesGridPageEventsProcessSchema

	/// <exclude/>
	public class RecordAllChangesGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public RecordAllChangesGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public RecordAllChangesGridPageEventsProcessSchema(RecordAllChangesGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "RecordAllChangesGridPageEventsProcess";
			UId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreatePreviousRowParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("81c53518-3193-4d45-9fb4-2b9d042d434c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"PreviousRow",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateHighlightColumnsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("67d9769e-6535-41ba-b217-9a110c852104"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"HighlightColumns",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateHighlightColumnsCheckPerformedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5835311d-ce5e-4f5f-9eab-a0b66c6ca3f1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"HighlightColumnsCheckPerformed",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreatePreviousRowParameter());
			Parameters.Add(CreateHighlightColumnsParameter());
			Parameters.Add(CreateHighlightColumnsCheckPerformedParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet581 = CreateLaneSet581LaneSet();
			LaneSets.Add(schemaLaneSet581);
			ProcessSchemaLane schemaLane2053 = CreateLane2053Lane();
			schemaLaneSet581.Lanes.Add(schemaLane2053);
			ProcessSchemaLane schemaTreeGridLane1 = CreateTreeGridLane1Lane();
			schemaLaneSet581.Lanes.Add(schemaTreeGridLane1);
			ProcessSchemaLane schemaPageLane1 = CreatePageLane1Lane();
			schemaLaneSet581.Lanes.Add(schemaPageLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaEventSubProcess eventsubprocess11 = CreateEventSubProcess11EventSubProcess();
			FlowElements.Add(eventsubprocess11);
			ProcessSchemaEventSubProcess eventsubprocess12 = CreateEventSubProcess12EventSubProcess();
			FlowElements.Add(eventsubprocess12);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			ProcessSchemaStartMessageEvent startmessage5 = CreateStartMessage5StartMessageEvent();
			eventsubprocess10.FlowElements.Add(startmessage5);
			ProcessSchemaScriptTask scripttask4 = CreateScriptTask4ScriptTask();
			eventsubprocess10.FlowElements.Add(scripttask4);
			ProcessSchemaStartMessageEvent startmessage6 = CreateStartMessage6StartMessageEvent();
			eventsubprocess11.FlowElements.Add(startmessage6);
			ProcessSchemaScriptTask scripttask5 = CreateScriptTask5ScriptTask();
			eventsubprocess11.FlowElements.Add(scripttask5);
			ProcessSchemaStartMessageEvent startmessage7 = CreateStartMessage7StartMessageEvent();
			eventsubprocess12.FlowElements.Add(startmessage7);
			ProcessSchemaScriptTask treegriddblclickscripttask6 = CreateTreeGridDblClickScriptTask6ScriptTask();
			eventsubprocess12.FlowElements.Add(treegriddblclickscripttask6);
			ProcessSchemaStartMessageEvent startmessage4 = CreateStartMessage4StartMessageEvent();
			eventsubprocess9.FlowElements.Add(startmessage4);
			ProcessSchemaScriptTask initscripttask3 = CreateInitScriptTask3ScriptTask();
			eventsubprocess9.FlowElements.Add(initscripttask3);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess9.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaStartMessageEvent startmessage3 = CreateStartMessage3StartMessageEvent();
			eventsubprocess8.FlowElements.Add(startmessage3);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess8.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			eventsubprocess8.FlowElements.Add(pageloadcompletescripttask);
			FlowElements.Add(CreateSequenceFlow12718SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12719SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12720SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12721SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12722SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12723SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12724SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12718SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12718",
				UId = new Guid("14186300-6b46-4a42-b8d1-1ae3be41ca69"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				CurveCenterPosition = new Point(168, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("21cecfed-aad5-458d-8a59-4d4324b82122"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("aef29484-9722-4891-a9d7-641ebc699997"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12719SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12719",
				UId = new Guid("74a34a51-c4ef-4901-bb4b-92eea3fdcc2a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				CurveCenterPosition = new Point(180, 258),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("10344222-1502-4b10-a94a-14e9610e47fb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("eeffacd4-b9b3-48bf-a6b6-7481be78ae3d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12720SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12720",
				UId = new Guid("82a32303-10e5-4545-a6e0-461529438b45"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				CurveCenterPosition = new Point(312, 258),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("eeffacd4-b9b3-48bf-a6b6-7481be78ae3d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2ce11531-605b-4ea2-9827-9add050f625a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12721SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12721",
				UId = new Guid("fc93237b-a329-4d25-9194-b070e77d18c0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				CurveCenterPosition = new Point(168, 428),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bc44eba4-e46a-4e05-88ae-8c459281d8dd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e25eeee3-c165-4b31-a6b8-0e57b3a55bb3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12722SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12722",
				UId = new Guid("b2e724d5-abd8-48bc-ad9d-f4765545fb52"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				CurveCenterPosition = new Point(334, 428),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e25eeee3-c165-4b31-a6b8-0e57b3a55bb3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("57c41220-c3d6-47b2-81f9-ce5f9320f13a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12723SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12723",
				UId = new Guid("14225a8f-b65b-4824-b849-ca933929b693"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				CurveCenterPosition = new Point(170, 596),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cb4f3280-dcf7-4cf5-bd3d-ba462efa2a16"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("16fd4318-a1d8-4610-be1c-87793f8a563e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12724SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12724",
				UId = new Guid("17cfe50e-3973-4c2e-a7a8-c4f853a99325"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				CurveCenterPosition = new Point(484, 595),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b3d52290-a674-4da4-92ca-0bb2e5ebdd60"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7952a871-affe-4fbb-b7fb-babad163fe44"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("4db9e1e1-9151-4e00-b7af-e2d3be12ec67"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f9bbf389-c3f4-43fb-b290-c799c2e264fa"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a69a7d39-e352-4a6c-8314-e8179c34736c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet581LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet581 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("c3b75ae2-6759-44c5-b2d3-1853b6e5b0eb"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"LaneSet581",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(913, 1143),
				UseBackgroundMode = false
			};
			return schemaLaneSet581;
		}

		protected virtual ProcessSchemaLane CreateLane2053Lane() {
			ProcessSchemaLane schemaLane2053 = new ProcessSchemaLane(this) {
				UId = new Guid("2eb3a09b-b297-46eb-b61c-474756c3f865"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("c3b75ae2-6759-44c5-b2d3-1853b6e5b0eb"),
				CreatedInOwnerSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"Lane2053",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 212),
				Size = new Size(884, 529),
				UseBackgroundMode = false
			};
			return schemaLane2053;
		}

		protected virtual ProcessSchemaLane CreateTreeGridLane1Lane() {
			ProcessSchemaLane schemaTreeGridLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("ecc26fbf-c646-4e4f-81a1-9eff2e02ccf6"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("c3b75ae2-6759-44c5-b2d3-1853b6e5b0eb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"TreeGridLane1",
				Position = new Point(29, 0),
				Size = new Size(884, 207),
				UseBackgroundMode = false
			};
			return schemaTreeGridLane1;
		}

		protected virtual ProcessSchemaLane CreatePageLane1Lane() {
			ProcessSchemaLane schemaPageLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("69a10ad8-1a21-45e1-8ff9-70bb457e65c7"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("c3b75ae2-6759-44c5-b2d3-1853b6e5b0eb"),
				CreatedInOwnerSchemaUId = new Guid("038f55ad-dc39-4dea-b9d4-b777f708fe41"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"PageLane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 746),
				Size = new Size(884, 397),
				UseBackgroundMode = false
			};
			return schemaPageLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("074dec6b-de12-4d45-acbd-9c9caaf3f2de"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2eb3a09b-b297-46eb-b61c-474756c3f865"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(280, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("21cecfed-aad5-458d-8a59-4d4324b82122"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("074dec6b-de12-4d45-acbd-9c9caaf3f2de"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DataSourceActiveRowChanged",
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"StartMessage2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("aef29484-9722-4891-a9d7-641ebc699997"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("074dec6b-de12-4d45-acbd-9c9caaf3f2de"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("64941253-b61e-47ec-8e20-725567e82d4c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2eb3a09b-b297-46eb-b61c-474756c3f865"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"EventSubProcess10",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 175),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(280, 172),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage5StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("cb4f3280-dcf7-4cf5-bd3d-ba462efa2a16"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("64941253-b61e-47ec-8e20-725567e82d4c"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BasePrepareFilters",
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"StartMessage5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask4ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("16fd4318-a1d8-4610-be1c-87793f8a563e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("64941253-b61e-47ec-8e20-725567e82d4c"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"ScriptTask4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,205,74,3,49,16,62,219,167,136,123,106,97,201,11,72,15,117,109,69,144,90,220,162,231,49,153,109,131,217,100,157,157,20,138,248,238,78,127,180,145,34,232,49,51,243,253,204,55,217,0,41,11,12,117,76,100,80,141,213,2,86,168,111,190,43,87,3,215,168,225,105,66,215,102,141,45,168,241,88,133,228,253,72,189,15,46,8,57,81,80,76,73,198,63,6,27,161,108,156,103,164,91,138,169,19,206,12,62,115,193,206,246,205,126,223,189,222,206,161,197,97,113,31,87,199,114,49,58,104,230,20,151,153,90,70,86,37,34,12,92,139,178,17,11,59,246,61,133,126,196,54,110,48,167,24,237,156,253,234,234,140,168,34,4,198,220,232,15,139,165,146,135,51,224,31,58,36,96,23,131,64,157,97,61,9,86,148,78,9,252,67,230,217,241,122,1,36,105,236,36,206,35,47,151,72,4,125,108,88,87,81,176,211,192,142,29,246,199,165,171,216,118,64,174,143,97,185,237,164,251,150,192,151,170,168,214,16,86,184,36,48,175,104,11,85,170,26,61,26,70,59,143,22,23,228,90,160,109,21,125,106,195,19,248,132,98,254,96,92,223,245,211,0,47,30,173,172,112,184,108,150,158,158,88,123,76,87,16,127,185,200,9,240,117,142,252,215,124,2,203,236,35,102,134,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("247e676b-329d-4b57-99ca-b5013d6f5b5c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2eb3a09b-b297-46eb-b61c-474756c3f865"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"EventSubProcess11",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 357),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(350, 156),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage6StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b3d52290-a674-4da4-92ca-0bb2e5ebdd60"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("247e676b-329d-4b57-99ca-b5013d6f5b5c"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"GridPageRefreshRow",
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"StartMessage6",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask5ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7952a871-affe-4fbb-b7fb-babad163fe44"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("247e676b-329d-4b57-99ca-b5013d6f5b5c"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"ScriptTask5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(155, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,73,44,73,12,206,47,45,74,78,85,176,85,8,72,76,79,213,115,129,139,88,115,101,166,41,104,32,84,232,5,39,103,164,230,38,42,216,218,42,228,149,230,228,104,42,84,115,113,22,165,150,148,22,229,41,148,20,149,2,149,215,114,129,77,8,41,74,77,117,47,202,76,209,115,206,73,77,44,210,208,180,230,66,50,195,39,63,49,37,40,191,188,24,36,140,172,25,0,17,143,11,218,141,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess12EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess12 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2e4022fc-9c5a-4dc3-a2c6-f398623cce0d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ecc26fbf-c646-4e4f-81a1-9eff2e02ccf6"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"EventSubProcess12",
				Position = new Point(36, 16),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(325, 177),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess12;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage7StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f9bbf389-c3f4-43fb-b290-c799c2e264fa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2e4022fc-9c5a-4dc3-a2c6-f398623cce0d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"TreeGridDblClick",
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"StartMessage7",
				Position = new Point(35, 84),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateTreeGridDblClickScriptTask6ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a69a7d39-e352-4a6c-8314-e8179c34736c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2e4022fc-9c5a-4dc3-a2c6-f398623cce0d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"TreeGridDblClickScriptTask6",
				Position = new Point(189, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2b5b9a9f-43e1-4ec0-a2ae-000434abd052"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("69a10ad8-1a21-45e1-8ff9-70bb457e65c7"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"EventSubProcess9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 33),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(427, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage4StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("bc44eba4-e46a-4e05-88ae-8c459281d8dd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2b5b9a9f-43e1-4ec0-a2ae-000434abd052"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"StartMessage4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTask3ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e25eeee3-c165-4b31-a6b8-0e57b3a55bb3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2b5b9a9f-43e1-4ec0-a2ae-000434abd052"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"InitScriptTask3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,146,97,75,195,48,16,134,63,87,240,63,196,126,106,217,200,31,208,9,99,27,91,209,15,195,78,253,48,134,220,218,107,23,205,18,185,164,27,83,252,239,94,234,166,21,133,150,64,238,121,223,123,239,72,230,198,232,65,233,41,169,82,12,132,240,212,224,229,249,217,76,213,27,205,191,31,89,221,108,141,27,109,176,120,153,35,85,150,182,24,192,10,180,11,224,28,106,148,11,66,12,6,114,138,254,206,238,71,214,84,170,158,129,41,53,18,179,221,219,147,100,12,30,114,219,80,129,242,214,66,201,158,189,129,248,109,22,144,175,26,139,118,64,162,196,234,1,116,131,46,11,9,90,152,173,231,64,176,69,143,212,214,146,184,67,197,41,43,85,149,116,133,23,3,97,26,173,83,241,126,126,22,5,215,215,147,222,177,105,50,86,133,87,214,0,29,174,156,39,101,234,190,93,63,99,225,175,211,123,135,196,51,24,108,1,153,163,115,124,134,144,203,142,191,92,216,188,213,37,233,138,155,71,170,18,201,79,135,101,236,138,13,110,129,163,173,126,39,137,242,131,155,24,175,252,33,63,18,33,205,180,81,101,42,254,215,7,247,143,239,25,106,60,173,100,232,94,195,41,192,137,5,18,129,179,149,151,247,153,124,196,53,199,247,100,181,147,1,184,140,162,239,124,44,227,241,230,100,43,165,145,3,133,74,107,12,84,135,181,24,220,139,99,245,6,15,147,29,26,63,228,74,18,246,27,69,1,146,124,207,224,159,41,58,251,16,61,17,63,141,39,139,97,118,27,183,186,182,111,102,148,87,160,213,219,169,125,18,236,250,237,67,76,143,51,242,71,232,27,50,95,207,243,19,134,13,38,111,180,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("57c41220-c3d6-47b2-81f9-ce5f9320f13a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2b5b9a9f-43e1-4ec0-a2ae-000434abd052"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(294, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7224accb-42a5-4ae8-a6d1-de7b9cf4458f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("69a10ad8-1a21-45e1-8ff9-70bb457e65c7"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"EventSubProcess8",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 208),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(427, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("10344222-1502-4b10-a94a-14e9610e47fb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7224accb-42a5-4ae8-a6d1-de7b9cf4458f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"StartMessage3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("eeffacd4-b9b3-48bf-a6b6-7481be78ae3d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7224accb-42a5-4ae8-a6d1-de7b9cf4458f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(161, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2ce11531-605b-4ea2-9827-9add050f625a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7224accb-42a5-4ae8-a6d1-de7b9cf4458f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(273, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,83,219,106,220,48,16,125,222,64,254,65,221,39,27,130,126,96,155,66,227,45,193,208,203,18,239,182,15,33,15,179,214,216,81,170,149,130,46,41,219,146,127,239,72,190,167,5,27,35,205,204,57,103,206,140,95,192,50,129,205,119,80,1,93,41,216,53,219,65,139,252,22,253,14,44,156,208,163,77,177,108,61,203,90,231,155,203,11,217,100,243,194,119,215,76,7,165,114,246,231,242,98,245,66,168,207,67,189,35,208,108,43,107,47,141,6,123,126,239,188,149,186,189,50,199,39,172,253,135,252,224,208,22,70,107,76,9,188,66,231,232,187,5,15,247,51,124,190,55,85,170,203,242,7,34,95,201,134,101,19,195,253,218,213,143,120,2,146,246,176,84,178,170,206,238,147,246,210,159,171,62,35,170,185,13,82,228,255,47,143,224,175,244,118,242,24,166,218,82,124,59,62,197,200,209,24,197,92,168,107,82,73,64,19,4,223,219,51,153,214,123,53,84,173,175,152,9,11,144,124,195,122,245,61,202,32,19,21,209,161,248,106,4,238,172,60,145,81,133,81,225,164,19,34,81,69,201,156,102,226,48,155,193,205,108,201,123,229,244,68,251,5,25,88,153,96,107,28,102,186,29,111,40,115,10,243,34,88,75,144,132,19,106,31,44,93,36,98,199,11,133,96,179,136,27,1,59,139,8,236,205,192,230,238,126,1,77,76,54,174,79,169,157,7,93,227,205,249,80,138,236,159,41,68,212,249,13,83,166,173,6,134,172,231,2,199,230,57,121,196,221,91,168,127,22,143,160,91,90,11,189,189,233,66,73,101,180,104,194,57,164,81,143,71,78,231,101,223,35,221,152,67,241,82,75,47,65,201,223,56,217,245,214,160,44,13,177,219,241,118,180,247,163,123,142,223,40,122,143,214,130,51,141,39,82,254,3,143,228,150,183,70,57,30,19,210,175,19,151,151,106,200,202,157,53,141,84,216,173,193,76,93,233,250,200,29,130,192,216,74,3,202,197,234,69,214,40,183,207,78,70,188,46,250,252,108,64,220,153,95,46,133,44,82,7,154,81,43,184,249,11,62,251,59,224,252,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateInitializeDataSourceCurrentStructureMethod());
			Methods.Add(CreateGetRowConfigMethod());
			Methods.Add(CreateGetColumnsHighlightStateMethod());
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
		}

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterEditPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterEditPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateCreateContextMenuMethod() {
			SchemaMethod method = base.CreateCreateContextMenuMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,179,6,0,7,133,17,243,7,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeDataSourceCurrentStructureMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("dc178233-e5d0-428b-9913-c9fd106c655e"),
				Name = "InitializeDataSourceCurrentStructure",
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,85,203,142,218,48,20,93,39,95,225,201,98,68,164,145,71,221,22,161,170,60,90,33,181,3,18,76,247,174,115,1,171,137,141,108,103,166,105,197,191,215,143,16,242,130,129,81,87,32,223,115,207,185,231,248,98,94,136,68,9,209,100,37,114,73,1,141,208,146,108,1,79,171,147,97,248,98,16,138,238,32,35,166,122,130,226,149,59,27,134,108,131,6,190,142,151,146,101,68,22,19,145,230,25,71,163,17,226,121,154,198,232,111,24,232,157,20,175,136,195,43,122,50,71,11,57,203,246,186,152,253,166,176,215,76,240,129,45,124,19,148,164,236,15,249,153,194,74,75,198,183,131,104,13,82,18,37,54,26,79,132,132,232,33,12,130,104,198,53,211,133,23,199,21,3,126,230,106,15,148,109,24,36,205,49,162,248,161,28,31,63,145,12,226,97,120,8,79,246,140,82,78,117,46,1,209,92,74,224,250,116,208,48,59,105,85,135,225,215,156,37,37,113,67,239,121,158,152,214,254,68,238,142,137,124,66,125,117,108,123,63,34,203,140,93,64,245,112,59,34,134,236,132,116,33,183,45,224,207,73,226,241,227,226,59,104,178,36,122,119,134,13,175,69,25,122,28,227,185,250,193,20,51,247,96,140,108,72,170,192,102,214,245,59,101,106,159,146,75,182,27,136,243,238,27,176,107,66,232,40,255,143,44,218,164,103,35,49,148,46,145,250,38,150,22,51,145,184,21,28,87,191,129,163,213,47,140,39,117,232,184,112,19,68,147,29,225,91,88,75,66,127,217,182,200,236,231,5,222,5,127,23,239,130,159,225,165,30,85,236,225,70,94,211,97,41,237,205,116,60,223,213,126,247,87,93,67,155,1,183,210,183,97,215,149,170,20,234,74,238,153,58,202,84,110,110,210,63,242,118,245,131,22,51,94,200,4,228,82,40,102,31,31,163,243,225,28,102,202,36,208,18,212,60,192,83,80,20,120,98,52,142,6,59,215,113,115,148,109,134,190,40,31,31,109,86,80,219,6,51,91,249,133,40,84,95,19,255,250,183,160,61,255,1,27,243,60,19,186,67,131,190,29,243,31,140,55,120,176,175,170,56,12,156,115,63,237,92,185,141,245,75,166,230,124,58,118,214,131,30,218,84,108,175,220,217,146,219,191,254,65,96,232,172,226,160,49,205,229,7,235,254,30,189,13,119,2,182,167,154,204,75,26,7,78,244,186,11,60,53,119,151,48,56,132,135,127,17,171,130,219,176,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRowConfigMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a9142fd5-572e-4f3c-95fd-7906260aee69"),
				Name = "GetRowConfig",
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "DataSourceRowConfig"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e015d26f-4b36-4ff4-abf2-48202df08f00"),
				Name = "row",
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				ModifiedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,93,111,218,48,20,125,78,165,254,7,147,73,85,34,65,20,198,144,54,209,86,130,80,216,30,182,162,82,237,221,77,46,224,53,216,204,113,138,80,197,127,159,63,72,112,66,74,43,237,129,72,248,158,123,238,241,185,247,154,44,144,215,250,78,150,171,84,254,68,196,210,124,77,179,104,5,241,243,12,248,130,241,53,36,62,122,189,188,112,234,24,116,131,166,80,252,41,131,115,129,5,120,254,160,33,161,74,42,211,5,207,65,2,247,151,23,153,224,132,46,209,134,147,53,230,59,131,255,133,215,32,65,156,109,131,121,188,130,53,14,102,118,56,80,241,65,115,234,111,156,230,69,110,169,81,31,122,39,37,252,224,145,205,53,135,86,125,160,123,194,241,243,146,179,156,38,18,201,184,228,114,93,25,125,193,28,197,140,46,200,82,158,80,216,162,49,22,120,206,114,30,195,3,219,70,58,226,157,74,81,196,68,250,124,170,71,41,200,60,63,144,169,2,19,154,121,110,180,194,116,9,143,187,13,252,72,92,223,88,63,205,73,130,226,50,112,188,153,250,151,88,116,215,10,121,91,39,81,205,80,229,109,6,35,95,193,61,119,248,181,255,57,234,245,38,157,112,52,30,119,238,194,110,183,243,77,30,116,194,176,219,239,143,195,47,81,216,29,23,82,156,6,103,166,28,128,42,123,156,61,130,52,3,116,182,216,240,255,138,61,64,98,151,122,11,54,146,110,24,156,30,48,221,56,72,211,108,84,66,139,14,146,88,16,70,101,195,174,77,239,219,245,166,42,119,71,213,10,166,211,218,242,91,175,232,238,140,195,11,97,121,38,147,80,75,146,231,105,138,174,174,80,125,13,204,213,148,160,141,149,112,131,236,116,156,161,59,42,136,216,169,27,200,125,1,28,175,144,103,166,79,145,32,66,237,197,168,48,235,86,123,241,113,73,148,24,247,39,75,200,130,64,114,79,93,95,169,122,19,48,218,73,128,162,113,154,80,135,193,226,210,142,3,244,93,148,170,248,30,159,156,146,178,231,142,185,185,189,201,113,206,57,80,97,175,245,132,208,228,4,104,211,235,169,111,34,83,174,23,76,86,7,62,204,168,135,219,22,100,245,250,200,109,29,182,238,159,254,64,44,130,187,191,57,78,179,74,110,160,191,237,99,158,57,40,173,112,106,51,27,12,147,196,150,212,110,122,132,206,207,171,231,126,154,76,38,189,112,34,13,55,23,218,171,239,190,92,149,89,101,42,165,215,18,101,222,60,85,253,240,198,53,149,173,150,169,237,164,46,246,33,26,53,201,103,228,215,28,209,188,28,68,206,233,225,101,30,252,3,220,139,36,3,210,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetColumnsHighlightStateMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("49712d51-9d92-4c1e-bc95-7335e1389ad8"),
				Name = "GetColumnsHighlightState",
				CreatedInSchemaUId = new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,177,14,130,48,16,134,231,246,41,78,6,3,11,113,39,78,184,56,40,38,248,2,103,57,176,17,218,228,218,186,24,223,93,42,74,12,113,253,255,239,190,255,238,200,208,160,199,218,6,86,84,123,14,202,7,38,216,194,9,59,202,119,115,149,151,129,153,140,159,145,66,182,150,9,213,21,210,251,40,113,223,188,180,125,24,12,104,243,207,155,79,173,203,224,33,197,120,162,77,7,234,29,29,113,136,171,11,77,30,227,66,10,221,66,154,254,128,171,45,36,229,21,77,71,103,70,117,163,166,50,73,6,235,53,44,161,131,109,116,171,167,94,10,17,137,229,196,222,213,150,61,94,122,154,12,203,190,226,134,248,100,157,246,218,154,40,221,100,239,247,5,211,72,25,104,177,119,241,199,167,124,202,79,52,26,168,120,1,51,165,207,59,91,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new RecordAllChangesGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("725033ac-0828-4df9-abdc-15ef5fb9f329"));
		}

		#endregion

	}

	#endregion

}

