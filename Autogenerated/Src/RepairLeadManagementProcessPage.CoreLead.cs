namespace Terrasoft.WebApp
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;

	#region Class: RepairLeadManagementProcessPageSchema

	/// <exclude/>
	public class RepairLeadManagementProcessPageSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.Button _updateLeadQualifyStatusButton;
		public Terrasoft.UI.WebControls.Controls.Button UpdateLeadQualifyStatusButton {
			get {
				return _updateLeadQualifyStatusButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _checkLeadCountButton;
		public Terrasoft.UI.WebControls.Controls.Button CheckLeadCountButton {
			get {
				return _checkLeadCountButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _leadToProcessCountLabel;
		public Terrasoft.UI.WebControls.Controls.Label LeadToProcessCountLabel {
			get {
				return _leadToProcessCountLabel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _runProcessButton;
		public Terrasoft.UI.WebControls.Controls.Button RunProcessButton {
			get {
				return _runProcessButton;
			}
		}

		#endregion

		#region Constructors: Public

		public RepairLeadManagementProcessPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public RepairLeadManagementProcessPageSchema(RepairLeadManagementProcessPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2f3abfab-4b6e-400e-91df-1054c5e52e8a");
			RealUId = new Guid("2f3abfab-4b6e-400e-91df-1054c5e52e8a");
			Name = "RepairLeadManagementProcessPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateRepairLeadManagementProcessPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateUpdateLeadQualifyStatusButton());
			Controls.AddAt(1, CreateCheckLeadCountButton());
			Controls.AddAt(2, CreateLeadToProcessCountLabel());
			Controls.AddAt(3, CreateRunProcessButton());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateRepairLeadManagementProcessPageEventsProcessSchema() {
			var schema = new RepairLeadManagementProcessPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateUpdateLeadQualifyStatusButton() {
			_updateLeadQualifyStatusButton = new Terrasoft.UI.WebControls.Controls.Button();
			_updateLeadQualifyStatusButton.UId = new Guid("4f75333d-4941-4087-9517-1d44dec27fee");
			_updateLeadQualifyStatusButton.Name = "UpdateLeadQualifyStatusButton";
			_updateLeadQualifyStatusButton.CreatedInSchemaUId = new Guid("2f3abfab-4b6e-400e-91df-1054c5e52e8a");
			_updateLeadQualifyStatusButton.ModifiedInSchemaUId = new Guid("2f3abfab-4b6e-400e-91df-1054c5e52e8a");
			_updateLeadQualifyStatusButton.CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379");
			_updateLeadQualifyStatusButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_updateLeadQualifyStatusButton.AjaxEvents.Click.ShowLoadMask = true;
			_updateLeadQualifyStatusButton.Tag = "";
			_updateLeadQualifyStatusButton.Image = new ControlImage {};
			return _updateLeadQualifyStatusButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCheckLeadCountButton() {
			_checkLeadCountButton = new Terrasoft.UI.WebControls.Controls.Button();
			_checkLeadCountButton.UId = new Guid("799cf077-ffe8-4448-9c71-75c6de755472");
			_checkLeadCountButton.Name = "CheckLeadCountButton";
			_checkLeadCountButton.CreatedInSchemaUId = new Guid("2f3abfab-4b6e-400e-91df-1054c5e52e8a");
			_checkLeadCountButton.ModifiedInSchemaUId = new Guid("2f3abfab-4b6e-400e-91df-1054c5e52e8a");
			_checkLeadCountButton.CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379");
			_checkLeadCountButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_checkLeadCountButton.AjaxEvents.Click.ShowLoadMask = true;
			_checkLeadCountButton.Tag = "";
			_checkLeadCountButton.Image = new ControlImage {};
			return _checkLeadCountButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateLeadToProcessCountLabel() {
			_leadToProcessCountLabel = new Terrasoft.UI.WebControls.Controls.Label();
			_leadToProcessCountLabel.UId = new Guid("488ead34-d806-4ae2-a99e-f2b7abc40548");
			_leadToProcessCountLabel.Name = "LeadToProcessCountLabel";
			_leadToProcessCountLabel.CreatedInSchemaUId = new Guid("2f3abfab-4b6e-400e-91df-1054c5e52e8a");
			_leadToProcessCountLabel.ModifiedInSchemaUId = new Guid("2f3abfab-4b6e-400e-91df-1054c5e52e8a");
			_leadToProcessCountLabel.CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379");
			_leadToProcessCountLabel.Tag = "";
			_leadToProcessCountLabel.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_leadToProcessCountLabel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _leadToProcessCountLabel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateRunProcessButton() {
			_runProcessButton = new Terrasoft.UI.WebControls.Controls.Button();
			_runProcessButton.UId = new Guid("3d6342b3-a40b-4986-9668-641e95c0802e");
			_runProcessButton.Name = "RunProcessButton";
			_runProcessButton.CreatedInSchemaUId = new Guid("2f3abfab-4b6e-400e-91df-1054c5e52e8a");
			_runProcessButton.ModifiedInSchemaUId = new Guid("2f3abfab-4b6e-400e-91df-1054c5e52e8a");
			_runProcessButton.CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379");
			_runProcessButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_runProcessButton.AjaxEvents.Click.ShowLoadMask = true;
			_runProcessButton.Tag = "";
			_runProcessButton.Image = new ControlImage {};
			return _runProcessButton;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new RepairLeadManagementProcessPageSchemaUserControl();
		}

		public override object Clone() {
			return new RepairLeadManagementProcessPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2f3abfab-4b6e-400e-91df-1054c5e52e8a"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new RepairLeadManagementProcessPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: RepairLeadManagementProcessPageEventsProcess

	/// <exclude/>
	public class RepairLeadManagementProcessPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.RepairLeadManagementProcessPageSchemaUserControl
	{

		private TPage _page;
		public TPage Page {
			get {
				return _page;
			}
			set {
				_page = value;
			}
		}

		public RepairLeadManagementProcessPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "RepairLeadManagementProcessPageEventsProcess";
			SchemaUId = new Guid("2f3abfab-4b6e-400e-91df-1054c5e52e8a");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2f3abfab-4b6e-400e-91df-1054c5e52e8a");
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

		private ProcessFlowElement _runProcessButtonClickEventSubProcess;
		public ProcessFlowElement RunProcessButtonClickEventSubProcess {
			get {
				return _runProcessButtonClickEventSubProcess ?? (_runProcessButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "RunProcessButtonClickEventSubProcess",
					SchemaElementUId = new Guid("338a62a0-0589-468f-bd6a-89e5d4239514"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _runProcessButtonClickStartMessage;
		public ProcessFlowElement RunProcessButtonClickStartMessage {
			get {
				return _runProcessButtonClickStartMessage ?? (_runProcessButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "RunProcessButtonClickStartMessage",
					SchemaElementUId = new Guid("25ea602f-09ca-4f1f-b9e8-4dab7f0fae3f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _runProcessButtonClickScriptTask;
		public ProcessScriptTask RunProcessButtonClickScriptTask {
			get {
				return _runProcessButtonClickScriptTask ?? (_runProcessButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RunProcessButtonClickScriptTask",
					SchemaElementUId = new Guid("70009737-434e-497e-86bf-91745a27cc8f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RunProcessButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _updateLeadQualifyStatusButtonClickEventSubProcess;
		public ProcessFlowElement UpdateLeadQualifyStatusButtonClickEventSubProcess {
			get {
				return _updateLeadQualifyStatusButtonClickEventSubProcess ?? (_updateLeadQualifyStatusButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "UpdateLeadQualifyStatusButtonClickEventSubProcess",
					SchemaElementUId = new Guid("73cf55f3-10b8-4132-891b-50b5cb6c286e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _updateLeadQualifyStatusButtonClickStartMessage;
		public ProcessFlowElement UpdateLeadQualifyStatusButtonClickStartMessage {
			get {
				return _updateLeadQualifyStatusButtonClickStartMessage ?? (_updateLeadQualifyStatusButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "UpdateLeadQualifyStatusButtonClickStartMessage",
					SchemaElementUId = new Guid("b7f2cc33-7b73-4e62-8373-ba89ef865267"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _updateLeadQualifyStatusButtonClickScriptTask;
		public ProcessScriptTask UpdateLeadQualifyStatusButtonClickScriptTask {
			get {
				return _updateLeadQualifyStatusButtonClickScriptTask ?? (_updateLeadQualifyStatusButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdateLeadQualifyStatusButtonClickScriptTask",
					SchemaElementUId = new Guid("0312264a-9bac-4134-a9c5-4640ea8b3ada"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateLeadQualifyStatusButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _checkLeadCountEventSubProcess;
		public ProcessFlowElement CheckLeadCountEventSubProcess {
			get {
				return _checkLeadCountEventSubProcess ?? (_checkLeadCountEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "CheckLeadCountEventSubProcess",
					SchemaElementUId = new Guid("5cfe4dfc-9c9f-47d3-90dd-8a3bfaba52e7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _checkLeadCountButtonClickStartMessage;
		public ProcessFlowElement CheckLeadCountButtonClickStartMessage {
			get {
				return _checkLeadCountButtonClickStartMessage ?? (_checkLeadCountButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CheckLeadCountButtonClickStartMessage",
					SchemaElementUId = new Guid("c5e2266c-614c-4dac-a91e-bf6102f09331"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _checkLeadCountButtonClickScriptTask;
		public ProcessScriptTask CheckLeadCountButtonClickScriptTask {
			get {
				return _checkLeadCountButtonClickScriptTask ?? (_checkLeadCountButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckLeadCountButtonClickScriptTask",
					SchemaElementUId = new Guid("a03e2278-907e-4146-913b-ae193d82fd59"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckLeadCountButtonClickScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[RunProcessButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { RunProcessButtonClickEventSubProcess };
			FlowElements[RunProcessButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { RunProcessButtonClickStartMessage };
			FlowElements[RunProcessButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { RunProcessButtonClickScriptTask };
			FlowElements[UpdateLeadQualifyStatusButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateLeadQualifyStatusButtonClickEventSubProcess };
			FlowElements[UpdateLeadQualifyStatusButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateLeadQualifyStatusButtonClickStartMessage };
			FlowElements[UpdateLeadQualifyStatusButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateLeadQualifyStatusButtonClickScriptTask };
			FlowElements[CheckLeadCountEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckLeadCountEventSubProcess };
			FlowElements[CheckLeadCountButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckLeadCountButtonClickStartMessage };
			FlowElements[CheckLeadCountButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckLeadCountButtonClickScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "RunProcessButtonClickEventSubProcess":
						break;
					case "RunProcessButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("RunProcessButtonClickScriptTask");
						break;
					case "RunProcessButtonClickScriptTask":
						break;
					case "UpdateLeadQualifyStatusButtonClickEventSubProcess":
						break;
					case "UpdateLeadQualifyStatusButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("UpdateLeadQualifyStatusButtonClickScriptTask");
						break;
					case "UpdateLeadQualifyStatusButtonClickScriptTask":
						break;
					case "CheckLeadCountEventSubProcess":
						break;
					case "CheckLeadCountButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("CheckLeadCountButtonClickScriptTask");
						break;
					case "CheckLeadCountButtonClickScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("RunProcessButtonClickStartMessage");
			ActivatedEventElements.Add("UpdateLeadQualifyStatusButtonClickStartMessage");
			ActivatedEventElements.Add("CheckLeadCountButtonClickStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "RunProcessButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "RunProcessButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "RunProcessButtonClickStartMessage";
					result = RunProcessButtonClickStartMessage.Execute(context);
					break;
				case "RunProcessButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "RunProcessButtonClickScriptTask";
					result = RunProcessButtonClickScriptTask.Execute(context, RunProcessButtonClickScriptTaskExecute);
					break;
				case "UpdateLeadQualifyStatusButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "UpdateLeadQualifyStatusButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateLeadQualifyStatusButtonClickStartMessage";
					result = UpdateLeadQualifyStatusButtonClickStartMessage.Execute(context);
					break;
				case "UpdateLeadQualifyStatusButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateLeadQualifyStatusButtonClickScriptTask";
					result = UpdateLeadQualifyStatusButtonClickScriptTask.Execute(context, UpdateLeadQualifyStatusButtonClickScriptTaskExecute);
					break;
				case "CheckLeadCountEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "CheckLeadCountButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckLeadCountButtonClickStartMessage";
					result = CheckLeadCountButtonClickStartMessage.Execute(context);
					break;
				case "CheckLeadCountButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckLeadCountButtonClickScriptTask";
					result = CheckLeadCountButtonClickScriptTask.Execute(context, CheckLeadCountButtonClickScriptTaskExecute);
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

		public virtual bool RunProcessButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			var leadSelect = new Select(UserConnection)
				.Top(10)
				.Column("Id")
				.From("Lead")
				.Where("QualificationProcessId").IsNull() as Select;
			List<Guid> records = new List<Guid>();
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader reader = leadSelect.ExecuteReader(dbExecutor)) {
					while (reader.Read()) {
						Guid id = UserConnection.DBTypeConverter.DBValueToGuid(reader[0]);
						records.Add(id);
					}
				}
			}
			
			ProcessSchema schema = UserConnection.ProcessSchemaManager.GetInstanceByName("LeadManagement");
			foreach (Guid recordId in records) {
				Process process = schema.CreateProcess(UserConnection);
				process.SetPropertyValue("LeadId", recordId);
				process.Execute(UserConnection);
			}
			return true;
			/* FIX FOR PROCESS WITH START EVENT
			var leadSelect = new Select(UserConnection)
				.Column("Id")
				.From("Lead")
				.Where("QualificationProcessId").IsNull() as Select;
			List<Guid> records = new List<Guid>();
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader reader = leadSelect.ExecuteReader(dbExecutor)) {
					while (reader.Read()) {
						Guid id = UserConnection.DBTypeConverter.DBValueToGuid(reader[0]);
						records.Add(id);
					}
				}
			}
			Guid startSignalUId = new Guid("dfe52c03-1fda-4a51-b1a9-2a440caacabe");
			ProcessSchema schema = UserConnection.ProcessSchemaManager.GetInstanceByName("LeadManagement");
			foreach (Guid recordId in records) {
				Process process = schema.CreateProcess(UserConnection);
				process.IsProcessExecutedBySignal = true;
				process.Execute(UserConnection);
				var startSignal = (ProcessStartSignalEvent)process.FlowElements[startSignalUId][0];
				startSignal.RecordId = recordId;
				process.InternalContext.SenderName = startSignal.Name;
				try {
					startSignal.Execute(process.InternalContext);
				} catch {
					//// Пустой блок catch добавлен специально, для того чтобы отработали все подписчики изменения объекта
				}
				process.WritePropertiesData();
			}
			return true;
			*/
		}

		public virtual bool UpdateLeadQualifyStatusButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			new Update(UserConnection, "Lead")
																	/*Квалификация*/
				.Set("QualifyStatusId", Column.Parameter(new Guid("D790A45D-03FF-4DDB-9DEA-8087722C582C")))
				.Where("QualificationProcessId").IsNull()
																	/*Новый*/
				.And("StatusId").IsEqual(Column.Parameter(new Guid("BD3511F8-F36B-1410-4493-1C6F65E16A07")))
				.Execute();
			
			new Update(UserConnection, "Lead")
																	/*Квалификация*/
				.Set("QualifyStatusId", Column.Parameter(new Guid("D790A45D-03FF-4DDB-9DEA-8087722C582C")))
				.Where("QualificationProcessId").IsNull()
				.And("StatusId").In(
													/*Квалифицирован как новый*/
					Column.Parameter(new Guid("7D372F02-F46B-1410-4593-1C6F65E16A07")),
													/*Квалифицирован как существующий*/
					Column.Parameter(new Guid("7D3F3116-F46B-1410-4693-1C6F65E16A07"))
				)
				.And("QualifiedContactId").IsNull()
				.Execute();
			
			new Update(UserConnection, "Lead")
																	/*Распределение*/
				.Set("QualifyStatusId", Column.Parameter(new Guid("14CFC644-E3ED-497E-8279-ED4319BB8093")))
				.Where("QualificationProcessId").IsNull()
				.And("StatusId").In(
													/*Квалифицирован как новый*/
					Column.Parameter(new Guid("7D372F02-F46B-1410-4593-1C6F65E16A07")),
													/*Квалифицирован как существующий*/
					Column.Parameter(new Guid("7D3F3116-F46B-1410-4693-1C6F65E16A07"))
				)
				.And("QualifiedContactId").Not().IsNull()
				.Execute();
			
			new Update(UserConnection, "Lead")
																	/*Потребность отсутствует*/
				.Set("QualifyStatusId", Column.Parameter(new Guid("51ADC3EC-3503-4B10-A00B-8BE3B0E11F08")))
				.Where("QualificationProcessId").IsNull()
																	/*Более не заинтересован*/
				.And("StatusId").IsEqual(Column.Parameter(new Guid("3DB90F2A-F46B-1410-4693-1C6F65E16A07")))
				.Execute();
			
			new Update(UserConnection, "Lead")
																	/*Дисквалифицирован*/
				.Set("QualifyStatusId", Column.Parameter(new Guid("128C3718-771A-4D1E-9035-6FA135CA5F70")))
				.Where("QualificationProcessId").IsNull()
				.And("StatusId").In(
													/*Утрачен*/
					Column.Parameter(new Guid("FD3D301E-F46B-1410-4693-1C6F65E16A07")),
													/*Невозможно связаться*/
					Column.Parameter(new Guid("7D3D1124-F46B-1410-4693-1C6F65E16A07"))
				)
				.Execute();
			return true;
		}

		public virtual bool CheckLeadCountButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			var selectCount = new Select(UserConnection)
				.Column(Func.Count("Id"))
				.From("Lead")
				.Where("QualificationProcessId").IsNull() as Select;
			var count = selectCount.ExecuteScalar<int>();
			Page.LeadToProcessCountLabel.Caption = string.Format("Lead to process: {0}", count);
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "RunProcessButtonClick":
							if (ActivatedEventElements.Contains("RunProcessButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("RunProcessButtonClickStartMessage");
						}
						break;
					case "UpdateLeadQualifyStatusButtonClick":
							if (ActivatedEventElements.Contains("UpdateLeadQualifyStatusButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("UpdateLeadQualifyStatusButtonClickStartMessage");
						}
						break;
					case "CheckLeadCountButtonClick":
							if (ActivatedEventElements.Contains("CheckLeadCountButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("CheckLeadCountButtonClickStartMessage");
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

	#region Class: RepairLeadManagementProcessPageEventsProcess

	/// <exclude/>
	public class RepairLeadManagementProcessPageEventsProcess : RepairLeadManagementProcessPageEventsProcess<Terrasoft.WebApp.RepairLeadManagementProcessPageSchemaUserControl>
	{

		public RepairLeadManagementProcessPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: RepairLeadManagementProcessPageSchemaUserControl

	/// <exclude/>
	public partial class RepairLeadManagementProcessPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.Button UpdateLeadQualifyStatusButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("UpdateLeadQualifyStatusButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button CheckLeadCountButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("CheckLeadCountButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label LeadToProcessCountLabel {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("LeadToProcessCountLabel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button RunProcessButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("RunProcessButton", true);
			}
		}

		private Terrasoft.UI.WebControls.Controls.ScriptManager _scriptManager;
		public Terrasoft.UI.WebControls.Controls.ScriptManager ScriptManager {
			get {
				if (this._scriptManager != null) {
					return this._scriptManager;
				}
				if (!this.DesignMode && this.Page != null) {
					this._scriptManager = ScriptManager.GetCurrent(this.Page);
					if (this._scriptManager != null) {
						return this._scriptManager;
					}
				}
				if (this.Page != null) {
					this._scriptManager = ControlUtilities.FindControl(this.Page,
						"Terrasoft.UI.WebControls.ScriptManagerProxy") as ScriptManager;
					if (this._scriptManager != null) {
						return this._scriptManager;
					}
					this._scriptManager = (ScriptManager)ControlUtilities.FindControl(this.Page,
						"Terrasoft.UI.WebControls.ScriptManager");
					if (this.DesignMode && this._scriptManager == null) {
						this._scriptManager = new ScriptManager();
						this.Page.Controls.Add(this._scriptManager);
					}
				}
				if (this._scriptManager == null) {
					throw new InvalidOperationException("The Terrasoft Script Manager Control " +
						"is missing from this Page." +
						Environment.NewLine + Environment.NewLine +
						"Please add the following Script Manager tag inside the <body> or " +
						"<form> of this Page." +
						Environment.NewLine + Environment.NewLine + "Example" +
						Environment.NewLine + Environment.NewLine +
						" <ext:Script Manager runat=\"server\" />");
				}
				return this._scriptManager;
			}
		}

		#endregion

		#region Methods: Protected

		protected override void PageLoadComplete(object sender, EventArgs e) {
			if (!((PageContainer)PageContainer).IsPageLoadCompleted) {
				((PageContainer)PageContainer).IsPageLoadCompleted = true;
				ThrowEvent("PageLoadComplete");
			}
		}

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			UpdateLeadQualifyStatusButton.AjaxEvents.Click.Event += UpdateLeadQualifyStatusButtonClick;
			CheckLeadCountButton.AjaxEvents.Click.Event += CheckLeadCountButtonClick;
			RunProcessButton.AjaxEvents.Click.Event += RunProcessButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			UpdateLeadQualifyStatusButton.AjaxEvents.Click.Event -= UpdateLeadQualifyStatusButtonClick;
			CheckLeadCountButton.AjaxEvents.Click.Event -= CheckLeadCountButtonClick;
			RunProcessButton.AjaxEvents.Click.Event -= RunProcessButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (RepairLeadManagementProcessPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new RepairLeadManagementProcessPageEventsProcess(UserConnection);
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

		public virtual void UpdateLeadQualifyStatusButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("UpdateLeadQualifyStatusButtonClick");
		}

		public virtual void CheckLeadCountButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("CheckLeadCountButtonClick");
		}

		public virtual void RunProcessButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("RunProcessButtonClick");
		}

		public virtual void ThrowClientEvent(string message, params object[] parameters) {
			string key = CopyParameters(parameters);
			ScriptManager.AddScript("if (window.opener) { if (window.key) {window.opener.Terrasoft.AjaxMethods.ThrowClientEvent(window.key, '" + message + "', '" + key + "')}}");
		}

		public virtual void AjaxRefresh() {
			ScriptManager.AddScript("window.Terrasoft.AjaxMethods.ThrowClientEvent(null, null);");
		}

		public virtual void AddScript(string script) {
			this.ScriptManager.AddScript(script);
		}

		public virtual void RegisterClientScriptIncludeInternal(string key, string resourceName) {
			this.ScriptManager.RegisterClientScriptIncludeInternal(key, resourceName);
		}

		public virtual void RegisterClientScriptBlock(string key, string script) {
			this.ScriptManager.RegisterClientScriptBlock(key, script);
		}

		public override void SetSchemaName() {
			SchemaName = "RepairLeadManagementProcessPage";
		}

		#endregion

	}

	#endregion

	#region Class: RepairLeadManagementProcessPageEventsProcessSchema

	/// <exclude/>
	public class RepairLeadManagementProcessPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public RepairLeadManagementProcessPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public RepairLeadManagementProcessPageEventsProcessSchema(RepairLeadManagementProcessPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "RepairLeadManagementProcessPageEventsProcess";
			UId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55");
			CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaMainLaneSet = CreateMainLaneSetLaneSet();
			LaneSets.Add(schemaMainLaneSet);
			ProcessSchemaLane schemaMainLane = CreateMainLaneLane();
			schemaMainLaneSet.Lanes.Add(schemaMainLane);
			ProcessSchemaEventSubProcess runprocessbuttonclickeventsubprocess = CreateRunProcessButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(runprocessbuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess updateleadqualifystatusbuttonclickeventsubprocess = CreateUpdateLeadQualifyStatusButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(updateleadqualifystatusbuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess checkleadcounteventsubprocess = CreateCheckLeadCountEventSubProcessEventSubProcess();
			FlowElements.Add(checkleadcounteventsubprocess);
			ProcessSchemaStartMessageEvent runprocessbuttonclickstartmessage = CreateRunProcessButtonClickStartMessageStartMessageEvent();
			runprocessbuttonclickeventsubprocess.FlowElements.Add(runprocessbuttonclickstartmessage);
			ProcessSchemaScriptTask runprocessbuttonclickscripttask = CreateRunProcessButtonClickScriptTaskScriptTask();
			runprocessbuttonclickeventsubprocess.FlowElements.Add(runprocessbuttonclickscripttask);
			ProcessSchemaStartMessageEvent updateleadqualifystatusbuttonclickstartmessage = CreateUpdateLeadQualifyStatusButtonClickStartMessageStartMessageEvent();
			updateleadqualifystatusbuttonclickeventsubprocess.FlowElements.Add(updateleadqualifystatusbuttonclickstartmessage);
			ProcessSchemaScriptTask updateleadqualifystatusbuttonclickscripttask = CreateUpdateLeadQualifyStatusButtonClickScriptTaskScriptTask();
			updateleadqualifystatusbuttonclickeventsubprocess.FlowElements.Add(updateleadqualifystatusbuttonclickscripttask);
			ProcessSchemaStartMessageEvent checkleadcountbuttonclickstartmessage = CreateCheckLeadCountButtonClickStartMessageStartMessageEvent();
			checkleadcounteventsubprocess.FlowElements.Add(checkleadcountbuttonclickstartmessage);
			ProcessSchemaScriptTask checkleadcountbuttonclickscripttask = CreateCheckLeadCountButtonClickScriptTaskScriptTask();
			checkleadcounteventsubprocess.FlowElements.Add(checkleadcountbuttonclickscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("a55014af-f92a-400e-aa5b-3b7e3e50aae6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379"),
				CreatedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("25ea602f-09ca-4f1f-b9e8-4dab7f0fae3f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("70009737-434e-497e-86bf-91745a27cc8f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("bf5573ce-07df-416d-8d5d-dda1fc3b4582"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379"),
				CreatedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b7f2cc33-7b73-4e62-8373-ba89ef865267"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0312264a-9bac-4134-a9c5-4640ea8b3ada"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("130e2d40-2351-4c34-8a80-e568ce2dbba2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379"),
				CreatedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c5e2266c-614c-4dac-a91e-bf6102f09331"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a03e2278-907e-4146-913b-ae193d82fd59"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateMainLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaMainLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("140b7041-31ac-45eb-a7c5-b8577120454e"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379"),
				CreatedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				Name = @"MainLaneSet",
				Position = new Point(5, 5),
				Size = new Size(1035, 162),
				UseBackgroundMode = false
			};
			return schemaMainLaneSet;
		}

		protected virtual ProcessSchemaLane CreateMainLaneLane() {
			ProcessSchemaLane schemaMainLane = new ProcessSchemaLane(this) {
				UId = new Guid("e4d6e240-54ef-48dc-8eb9-25cf09a8c26d"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("140b7041-31ac-45eb-a7c5-b8577120454e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379"),
				CreatedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				Name = @"MainLane",
				Position = new Point(29, 0),
				Size = new Size(1006, 162),
				UseBackgroundMode = false
			};
			return schemaMainLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateRunProcessButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaRunProcessButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("338a62a0-0589-468f-bd6a-89e5d4239514"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e4d6e240-54ef-48dc-8eb9-25cf09a8c26d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379"),
				CreatedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				Name = @"RunProcessButtonClickEventSubProcess",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(274, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaRunProcessButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateRunProcessButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("25ea602f-09ca-4f1f-b9e8-4dab7f0fae3f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("338a62a0-0589-468f-bd6a-89e5d4239514"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379"),
				CreatedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"RunProcessButtonClick",
				ModifiedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				Name = @"RunProcessButtonClickStartMessage",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateRunProcessButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("70009737-434e-497e-86bf-91745a27cc8f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("338a62a0-0589-468f-bd6a-89e5d4239514"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379"),
				CreatedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				Name = @"RunProcessButtonClickScriptTask",
				Position = new Point(190, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,95,79,19,65,16,127,110,147,126,135,77,159,174,132,30,45,194,131,209,154,208,127,120,9,2,182,5,76,8,15,203,221,150,94,114,221,107,246,246,90,26,67,34,152,72,162,38,126,4,191,130,69,137,21,164,124,133,189,111,228,236,222,246,159,96,162,111,198,216,220,245,118,103,103,126,51,243,155,153,237,98,134,60,130,157,58,241,136,205,81,1,81,210,67,241,198,216,9,8,43,249,148,194,218,245,105,38,149,76,152,13,191,99,228,115,106,89,242,189,176,77,141,180,229,164,213,190,202,252,182,145,222,0,172,120,191,215,34,140,24,233,231,33,246,220,166,107,99,137,177,205,124,155,4,129,52,49,173,96,51,244,60,35,131,112,160,29,62,74,37,55,220,128,63,94,15,93,231,9,98,196,246,153,19,232,144,166,7,70,6,244,194,192,165,71,200,40,23,43,199,196,14,185,207,144,115,56,89,22,208,124,228,102,133,6,33,35,229,226,84,100,100,50,232,37,68,169,113,172,50,230,184,6,161,19,6,126,213,167,48,67,139,25,67,147,88,195,152,186,210,40,137,94,203,245,8,50,98,83,83,170,141,29,36,18,50,104,4,207,157,168,202,197,70,191,67,64,208,37,140,131,89,185,184,139,189,144,52,124,105,161,177,246,115,7,50,93,128,209,116,152,107,142,99,184,78,44,60,129,63,120,225,73,37,53,181,117,187,69,218,24,5,241,231,142,207,57,173,103,152,226,35,112,188,78,184,69,3,142,169,77,138,253,77,220,38,113,25,227,227,54,161,60,45,221,53,125,8,201,110,33,67,37,20,135,99,65,102,116,92,169,56,97,237,1,117,244,183,160,99,49,75,96,206,137,62,254,185,183,100,58,218,194,172,19,14,90,29,32,165,175,8,137,163,129,158,89,156,120,157,211,215,197,185,7,18,136,97,132,135,140,34,206,66,2,130,165,5,84,181,94,160,234,86,13,109,215,182,74,149,122,29,237,89,141,167,168,222,88,171,53,80,101,183,178,217,72,37,187,127,54,18,255,231,224,47,154,3,229,4,90,153,241,186,123,68,177,183,99,57,154,56,5,150,118,154,100,117,217,206,61,200,230,155,14,206,174,224,213,124,246,48,143,31,102,151,241,202,74,206,198,216,198,135,68,117,251,191,51,78,86,160,149,116,241,156,98,63,230,6,176,244,88,252,198,40,37,228,84,204,16,11,198,198,56,251,169,180,210,133,244,50,99,180,170,231,247,42,158,74,57,216,159,47,202,1,20,84,162,206,72,161,93,52,7,133,9,29,115,121,80,104,14,208,131,184,56,57,230,112,77,80,104,12,201,175,36,101,6,71,138,164,33,103,253,184,245,102,15,199,25,254,2,85,165,122,130,96,74,161,52,202,120,9,126,72,124,140,94,71,167,209,153,24,137,111,72,12,196,53,44,174,180,150,248,2,155,129,248,36,46,64,124,41,110,80,116,42,110,197,101,244,70,12,65,120,29,189,23,55,98,180,40,213,174,163,15,72,97,124,22,35,20,157,171,229,32,122,135,196,40,58,139,94,129,242,64,174,164,145,24,34,113,1,56,151,8,160,70,96,122,43,134,224,255,28,32,175,228,217,80,124,21,223,165,51,245,14,1,87,65,189,133,237,149,68,136,231,97,66,221,30,115,85,171,200,59,213,37,129,28,114,227,222,251,113,97,233,7,187,29,114,240,16,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateUpdateLeadQualifyStatusButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaUpdateLeadQualifyStatusButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("73cf55f3-10b8-4132-891b-50b5cb6c286e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e4d6e240-54ef-48dc-8eb9-25cf09a8c26d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379"),
				CreatedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				Name = @"UpdateLeadQualifyStatusButtonClickEventSubProcess",
				Position = new Point(322, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(262, 136),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaUpdateLeadQualifyStatusButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateUpdateLeadQualifyStatusButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b7f2cc33-7b73-4e62-8373-ba89ef865267"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73cf55f3-10b8-4132-891b-50b5cb6c286e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379"),
				CreatedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"UpdateLeadQualifyStatusButtonClick",
				ModifiedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				Name = @"UpdateLeadQualifyStatusButtonClickStartMessage",
				Position = new Point(43, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateLeadQualifyStatusButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0312264a-9bac-4134-a9c5-4640ea8b3ada"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73cf55f3-10b8-4132-891b-50b5cb6c286e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379"),
				CreatedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				Name = @"UpdateLeadQualifyStatusButtonClickScriptTask",
				Position = new Point(176, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,149,111,107,211,64,28,199,31,111,176,247,16,250,40,29,187,238,46,119,249,199,30,37,185,156,12,100,76,198,240,113,104,79,44,116,169,166,9,234,51,215,201,68,20,135,224,35,97,40,248,6,230,176,174,110,118,190,133,203,59,242,119,117,157,219,170,219,44,21,65,44,36,109,67,123,247,253,243,249,37,169,124,96,172,223,107,36,185,52,215,59,50,139,218,105,42,235,121,179,157,46,24,149,155,50,105,84,170,115,179,51,231,94,139,243,234,141,218,87,123,234,72,245,203,39,170,175,14,213,94,185,13,159,119,230,23,225,183,181,53,153,155,149,91,69,210,106,222,121,180,150,39,121,209,89,110,84,22,140,168,221,42,54,210,218,106,146,37,27,50,151,153,153,194,206,55,138,102,195,172,112,215,199,1,179,57,194,84,8,196,56,15,145,207,227,0,121,216,115,93,203,138,108,207,138,42,213,170,86,82,187,125,87,102,114,180,126,179,158,104,169,171,89,187,46,59,122,155,106,109,185,179,82,180,90,230,207,84,239,170,99,181,95,62,87,159,191,235,12,82,216,250,84,160,254,103,124,31,86,53,47,17,26,114,106,19,34,60,36,168,19,34,194,8,70,140,249,20,145,200,17,142,29,19,39,192,238,72,104,252,80,214,11,72,181,186,52,55,59,55,155,254,187,49,143,7,153,154,103,205,92,52,50,52,241,88,119,1,215,6,134,246,165,14,13,53,56,215,206,204,37,62,92,78,93,75,96,11,9,118,218,130,61,222,194,194,239,139,40,55,203,173,242,153,234,193,123,23,196,108,149,47,225,91,255,122,146,4,37,196,57,43,201,25,151,4,171,252,72,236,36,91,217,0,24,242,164,158,143,229,58,5,130,222,1,51,155,234,43,56,237,169,143,112,28,193,49,0,71,189,73,25,34,44,18,145,195,24,138,105,204,17,243,221,24,121,150,235,163,152,51,74,252,48,244,176,79,255,51,244,119,25,90,105,231,230,212,73,122,171,142,203,238,144,163,15,58,102,237,174,124,97,12,47,106,195,221,145,93,48,222,157,20,46,155,4,60,162,113,132,168,141,41,98,33,36,16,96,28,34,47,140,105,136,99,184,243,98,111,10,207,129,87,80,153,30,132,158,6,6,78,7,208,91,95,13,64,127,79,27,132,129,57,169,116,226,231,4,229,161,143,133,21,92,81,229,180,186,121,13,28,110,2,126,191,100,115,226,105,183,188,136,186,196,67,174,75,2,120,98,144,24,249,152,218,200,17,1,161,118,20,216,194,197,127,102,218,223,15,97,219,43,159,234,27,214,149,163,35,56,229,20,131,186,203,243,190,56,205,187,176,248,62,100,116,160,190,192,249,147,230,26,198,23,40,222,209,76,104,192,129,234,157,235,12,46,39,196,98,215,28,220,179,133,103,50,47,178,212,200,179,66,46,125,3,3,196,37,169,138,9,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateCheckLeadCountEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaCheckLeadCountEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5cfe4dfc-9c9f-47d3-90dd-8a3bfaba52e7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e4d6e240-54ef-48dc-8eb9-25cf09a8c26d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379"),
				CreatedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				Name = @"CheckLeadCountEventSubProcess",
				Position = new Point(595, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(274, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaCheckLeadCountEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCheckLeadCountButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c5e2266c-614c-4dac-a91e-bf6102f09331"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5cfe4dfc-9c9f-47d3-90dd-8a3bfaba52e7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379"),
				CreatedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CheckLeadCountButtonClick",
				ModifiedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				Name = @"CheckLeadCountButtonClickStartMessage",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckLeadCountButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a03e2278-907e-4146-913b-ae193d82fd59"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5cfe4dfc-9c9f-47d3-90dd-8a3bfaba52e7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379"),
				CreatedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"),
				Name = @"CheckLeadCountButtonClickScriptTask",
				Position = new Point(141, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,142,77,75,3,49,16,134,207,22,250,31,134,156,178,32,193,115,171,94,150,46,20,138,180,84,241,60,198,105,27,200,206,148,73,82,5,241,191,187,217,221,131,183,249,120,63,158,27,42,36,138,228,115,43,133,51,60,1,211,23,28,199,139,125,75,164,173,48,15,115,16,110,150,139,59,215,74,44,61,219,174,176,119,163,195,154,237,167,105,198,95,167,210,91,179,35,28,14,117,127,191,144,146,53,135,130,49,156,130,199,26,178,87,241,148,82,245,184,109,122,41,49,218,6,48,205,141,235,229,226,54,0,249,25,229,31,152,219,124,147,47,153,142,30,35,234,99,224,252,108,155,65,190,199,51,185,90,249,42,115,244,40,223,225,7,69,215,226,181,118,214,164,172,129,207,174,19,237,49,79,140,144,5,174,147,101,5,63,15,191,230,126,234,173,169,74,185,40,67,214,66,235,63,211,126,12,174,34,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f4cb658c-788e-4420-bc8d-890bda8d6d93"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("dd83cf8d-0f68-468b-b99e-7ee6e58a2420"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new RepairLeadManagementProcessPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5303f6ac-67f5-4145-abc3-8effe7524f55"));
		}

		#endregion

	}

	#endregion

}

