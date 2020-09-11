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
	using System.IO;
	using System.Text;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using UIWebControls = Terrasoft.UI.WebControls.Controls;

	#region Class: ParameterizedChartPageSchema

	/// <exclude/>
	public class ParameterizedChartPageSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _mainControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout MainControlLayout {
			get {
				return _mainControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Chart _chart;
		public Terrasoft.UI.WebControls.Controls.Chart Chart {
			get {
				return _chart;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ChartXAxis _highchartXAxis1;
		public Terrasoft.UI.WebControls.Controls.ChartXAxis HighchartXAxis1 {
			get {
				return _highchartXAxis1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ChartYAxis _highchartYAxis1;
		public Terrasoft.UI.WebControls.Controls.ChartYAxis HighchartYAxis1 {
			get {
				return _highchartYAxis1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ChartSeries _chartSeries;
		public Terrasoft.UI.WebControls.Controls.ChartSeries ChartSeries {
			get {
				return _chartSeries;
			}
		}

		#endregion

		#region Constructors: Public

		public ParameterizedChartPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ParameterizedChartPageSchema(ParameterizedChartPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("90cdaef8-fcad-486f-ade3-0ad8db15a644");
			RealUId = new Guid("90cdaef8-fcad-486f-ade3-0ad8db15a644");
			Name = "ParameterizedChartPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateParameterizedChartPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateMainControlLayout());
			MainControlLayout.InsertItem(0, CreateChart());
			Chart.InsertItem(0, CreateChartSeries());
			Chart.InsertItem(0, CreateHighchartXAxis1());
			Chart.InsertItem(1, CreateHighchartYAxis1());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateParameterizedChartPageEventsProcessSchema() {
			var schema = new ParameterizedChartPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ChartSeries CreateChartSeries() {
			_chartSeries = new Terrasoft.UI.WebControls.Controls.ChartSeries();
			_chartSeries.UId = new Guid("09bc895d-9e50-43e0-b569-fdeb29e263c6");
			_chartSeries.Name = "ChartSeries";
			_chartSeries.CreatedInSchemaUId = new Guid("90cdaef8-fcad-486f-ade3-0ad8db15a644");
			_chartSeries.ModifiedInSchemaUId = new Guid("90cdaef8-fcad-486f-ade3-0ad8db15a644");
			_chartSeries.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_chartSeries.Tag = "";
			return _chartSeries;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ChartXAxis CreateHighchartXAxis1() {
			_highchartXAxis1 = new Terrasoft.UI.WebControls.Controls.ChartXAxis();
			_highchartXAxis1.UId = new Guid("f4cb3753-ded4-4224-aa09-71aff7985572");
			_highchartXAxis1.Name = "HighchartXAxis1";
			_highchartXAxis1.CreatedInSchemaUId = new Guid("90cdaef8-fcad-486f-ade3-0ad8db15a644");
			_highchartXAxis1.ModifiedInSchemaUId = new Guid("90cdaef8-fcad-486f-ade3-0ad8db15a644");
			_highchartXAxis1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_highchartXAxis1.Tag = "";
			return _highchartXAxis1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ChartYAxis CreateHighchartYAxis1() {
			_highchartYAxis1 = new Terrasoft.UI.WebControls.Controls.ChartYAxis();
			_highchartYAxis1.UId = new Guid("1edfc747-96c3-43bb-943e-04ffbdac4191");
			_highchartYAxis1.Name = "HighchartYAxis1";
			_highchartYAxis1.CreatedInSchemaUId = new Guid("90cdaef8-fcad-486f-ade3-0ad8db15a644");
			_highchartYAxis1.ModifiedInSchemaUId = new Guid("90cdaef8-fcad-486f-ade3-0ad8db15a644");
			_highchartYAxis1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_highchartYAxis1.Tag = "";
			return _highchartYAxis1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Chart CreateChart() {
			_chart = new Terrasoft.UI.WebControls.Controls.Chart();
			_chart.UId = new Guid("ca81bd93-4ddb-4cce-88fb-e41d16f22371");
			_chart.Name = "Chart";
			_chart.CreatedInSchemaUId = new Guid("90cdaef8-fcad-486f-ade3-0ad8db15a644");
			_chart.ModifiedInSchemaUId = new Guid("90cdaef8-fcad-486f-ade3-0ad8db15a644");
			_chart.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_chart.Tag = "";
			_chart.Edges = "";
			_chart.LegendPosition = Terrasoft.UI.WebControls.Controls.ChartLegendPosition.None;
			_chart.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_chart.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _chart;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateMainControlLayout() {
			_mainControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_mainControlLayout.UId = new Guid("37b5e01a-3d89-42c0-bc25-ed14c6e71210");
			_mainControlLayout.Name = "MainControlLayout";
			_mainControlLayout.CreatedInSchemaUId = new Guid("90cdaef8-fcad-486f-ade3-0ad8db15a644");
			_mainControlLayout.ModifiedInSchemaUId = new Guid("90cdaef8-fcad-486f-ade3-0ad8db15a644");
			_mainControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_mainControlLayout.Tag = "";
			_mainControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainControlLayout.StartNewAlignGroup = false;
			_mainControlLayout.Image = new ControlImage {};
			_mainControlLayout.Edges = "";
			return _mainControlLayout;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new ParameterizedChartPageSchemaUserControl();
		}

		public override object Clone() {
			return new ParameterizedChartPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("90cdaef8-fcad-486f-ade3-0ad8db15a644"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ParameterizedChartPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ParameterizedChartPageEventsProcess

	/// <exclude/>
	public class ParameterizedChartPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.ParameterizedChartPageSchemaUserControl
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

		public ParameterizedChartPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ParameterizedChartPageEventsProcess";
			SchemaUId = new Guid("90cdaef8-fcad-486f-ade3-0ad8db15a644");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("90cdaef8-fcad-486f-ade3-0ad8db15a644");
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

		public virtual Guid ChartPropertyId {
			get;
			set;
		}

		public virtual Guid SelectedEntitySchemaId {
			get;
			set;
		}

		public virtual Object ChartEQS {
			get;
			set;
		}

		public virtual string ChartHeader {
			get;
			set;
		}

		public virtual string XAxisCaption {
			get;
			set;
		}

		public virtual string YAxisCaption {
			get;
			set;
		}

		public virtual Object ChartSeriesKind {
			get;
			set;
		}

		public virtual Object ChartAggregationType {
			get;
			set;
		}

		public virtual string AggregationColumnName {
			get;
			set;
		}

		public virtual string GroupByColumnName {
			get;
			set;
		}

		public virtual Object OrderDirection {
			get;
			set;
		}

		public virtual string OrderByColumnName {
			get;
			set;
		}

		public virtual string GroupByTypeDateTime {
			get;
			set;
		}

		public virtual string ModuleAccessColumnName {
			get;
			set;
		}

		public virtual Object PointType {
			get;
			set;
		}

		public virtual string SerializedFilters {
			get;
			set;
		}

		public virtual bool HasXAxis {
			get;
			set;
		}

		public virtual bool HasYAxis {
			get;
			set;
		}

		public virtual bool IsEditMode {
			get;
			set;
		}

		public virtual Object ChartPointsSeries {
			get;
			set;
		}

		public virtual string ListenerPageProcessUId {
			get;
			set;
		}

		public virtual string SerializedModuleFilters {
			get;
			set;
		}

		public virtual Guid ModuleEntitySchemaId {
			get;
			set;
		}

		private ProcessFlowElement _processChangesEventSubProcess;
		public ProcessFlowElement ProcessChangesEventSubProcess {
			get {
				return _processChangesEventSubProcess ?? (_processChangesEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ProcessChangesEventSubProcess",
					SchemaElementUId = new Guid("e71d7a7b-aa4c-4656-9500-5dcc457db0e8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _processChangesStartMessage;
		public ProcessFlowElement ProcessChangesStartMessage {
			get {
				return _processChangesStartMessage ?? (_processChangesStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ProcessChangesStartMessage",
					SchemaElementUId = new Guid("a71886a4-026f-4aa1-9bf3-2cc9661bcc90"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _processChangesScriptTask;
		public ProcessScriptTask ProcessChangesScriptTask {
			get {
				return _processChangesScriptTask ?? (_processChangesScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProcessChangesScriptTask",
					SchemaElementUId = new Guid("c561dda2-4655-488b-b0b8-890bcb00ad6d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ProcessChangesScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _initEventSubProcess;
		public ProcessFlowElement InitEventSubProcess {
			get {
				return _initEventSubProcess ?? (_initEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "InitEventSubProcess",
					SchemaElementUId = new Guid("93a9f3d0-17ee-4d29-bc0f-332fc19e4a01"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _initStartMessage;
		public ProcessFlowElement InitStartMessage {
			get {
				return _initStartMessage ?? (_initStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InitStartMessage",
					SchemaElementUId = new Guid("e76d93f0-5c71-4b0b-a333-370f45a44343"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _initScriptTask;
		public ProcessScriptTask InitScriptTask {
			get {
				return _initScriptTask ?? (_initScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitScriptTask",
					SchemaElementUId = new Guid("cfe7daea-5257-4b54-92f6-efd6037c6b14"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTaskExecute,
				});
			}
		}

		private LocalizableString _chartCaption;
		public LocalizableString ChartCaption {
			get {
				return _chartCaption ?? (_chartCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ChartCaption.Value"));
			}
		}

		private LocalizableString _seriesCaption;
		public LocalizableString SeriesCaption {
			get {
				return _seriesCaption ?? (_seriesCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SeriesCaption.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ProcessChangesEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessChangesEventSubProcess };
			FlowElements[ProcessChangesStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessChangesStartMessage };
			FlowElements[ProcessChangesScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessChangesScriptTask };
			FlowElements[InitEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { InitEventSubProcess };
			FlowElements[InitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitStartMessage };
			FlowElements[InitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ProcessChangesEventSubProcess":
						break;
					case "ProcessChangesStartMessage":
						e.Context.QueueTasks.Enqueue("ProcessChangesScriptTask");
						break;
					case "ProcessChangesScriptTask":
						break;
					case "InitEventSubProcess":
						break;
					case "InitStartMessage":
						e.Context.QueueTasks.Enqueue("InitScriptTask");
						break;
					case "InitScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ProcessChangesStartMessage");
			ActivatedEventElements.Add("InitStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "ProcessChangesEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ProcessChangesStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProcessChangesStartMessage";
					result = ProcessChangesStartMessage.Execute(context);
					break;
				case "ProcessChangesScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProcessChangesScriptTask";
					result = ProcessChangesScriptTask.Execute(context, ProcessChangesScriptTaskExecute);
					break;
				case "InitEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "InitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitStartMessage";
					result = InitStartMessage.Execute(context);
					break;
				case "InitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitScriptTask";
					result = InitScriptTask.Execute(context, InitScriptTaskExecute);
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
				case "ModuleEntitySchemaId":
					ModuleEntitySchemaId = reader.GetValue<System.Guid>();
				break;
				case "SerializedModuleFilters":
					SerializedModuleFilters = reader.GetValue<System.String>();
				break;
				case "ListenerPageProcessUId":
					ListenerPageProcessUId = reader.GetValue<System.String>();
				break;
				case "ChartPointsSeries":
					ChartPointsSeries = reader.GetSerializableObjectValue();
				break;
				case "IsEditMode":
					IsEditMode = reader.GetValue<System.Boolean>();
				break;
				case "HasYAxis":
					HasYAxis = reader.GetValue<System.Boolean>();
				break;
				case "HasXAxis":
					HasXAxis = reader.GetValue<System.Boolean>();
				break;
				case "SerializedFilters":
					SerializedFilters = reader.GetValue<System.String>();
				break;
				case "PointType":
					PointType = reader.GetSerializableObjectValue();
				break;
				case "ModuleAccessColumnName":
					ModuleAccessColumnName = reader.GetValue<System.String>();
				break;
				case "GroupByTypeDateTime":
					GroupByTypeDateTime = reader.GetValue<System.String>();
				break;
				case "OrderByColumnName":
					OrderByColumnName = reader.GetValue<System.String>();
				break;
				case "OrderDirection":
					OrderDirection = reader.GetSerializableObjectValue();
				break;
				case "GroupByColumnName":
					GroupByColumnName = reader.GetValue<System.String>();
				break;
				case "AggregationColumnName":
					AggregationColumnName = reader.GetValue<System.String>();
				break;
				case "ChartAggregationType":
					ChartAggregationType = reader.GetSerializableObjectValue();
				break;
				case "ChartSeriesKind":
					ChartSeriesKind = reader.GetSerializableObjectValue();
				break;
				case "YAxisCaption":
					YAxisCaption = reader.GetValue<System.String>();
				break;
				case "XAxisCaption":
					XAxisCaption = reader.GetValue<System.String>();
				break;
				case "ChartHeader":
					ChartHeader = reader.GetValue<System.String>();
				break;
				case "ChartEQS":
					ChartEQS = reader.GetSerializableObjectValue();
				break;
				case "SelectedEntitySchemaId":
					SelectedEntitySchemaId = reader.GetValue<System.Guid>();
				break;
				case "ChartPropertyId":
					ChartPropertyId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ProcessChangesScriptTaskExecute(ProcessExecutingContext context) {
			GetDBDataByChartPropertyId();
			HasXAxis = HasYAxis = (ChartSeriesKind)ChartSeriesKind != UIWebControls.ChartSeriesKind.Pie;
			InitializeChartProperties();
			AddPoints();
			var chart = Page.Chart;
			var xAxis = chart.Axis[0];
			var yAxis = chart.Axis[1];
			xAxis.SetCaption(XAxisCaption);
			xAxis.SetVisible(HasXAxis);
			yAxis.SetCaption(YAxisCaption);
			yAxis.SetVisible(HasYAxis);
			chart.Series[0].SetSeriesKind((ChartSeriesKind)ChartSeriesKind);
			Page.Chart.Draw();
			return true;
		}

		public virtual bool InitScriptTaskExecute(ProcessExecutingContext context) {
			if (ChartSeriesKind == null) {
				ChartSeriesKind = UIWebControls.ChartSeriesKind.Line;
			}
			return true;
		}

		public virtual void GetDBDataByChartPropertyId() {
			if (ChartPropertyId != Guid.Empty) {
				ClearOldData();
				EntitySchemaManager entitySchemaManager = UserConnection.EntitySchemaManager;
				Entity chartPropertyEntity = entitySchemaManager.FindInstanceByName("SysModuleAnalyticsChart").CreateEntity(UserConnection);
				if (chartPropertyEntity.FetchFromDB(ChartPropertyId)) {
					var entitySchema = entitySchemaManager.GetInstanceByUId(chartPropertyEntity.GetTypedColumnValue<Guid>("EntityShemaUId"));
					SelectedEntitySchemaId = chartPropertyEntity.GetTypedColumnValue<Guid>("EntityShemaUId");
					ChartEQS = new EntitySchemaQuery(entitySchema);
					ChartHeader = chartPropertyEntity.GetTypedColumnValue<string>("Caption");
					XAxisCaption = chartPropertyEntity.GetTypedColumnValue<string>("XAxisCaption");
					YAxisCaption = chartPropertyEntity.GetTypedColumnValue<string>("YAxisCaption");
					ChartSeriesKind = (ChartSeriesKind)Enum.Parse(typeof(ChartSeriesKind), chartPropertyEntity.GetTypedColumnValue<string>("SeriesKind"), true);
					ChartAggregationType = GetAggregationType(chartPropertyEntity.GetTypedColumnValue<Guid>("SysAggregationTypeId"));
					AggregationColumnName = GetColumnName(chartPropertyEntity.GetTypedColumnValue<string>("YAxisColumnMetaPath"), SelectedEntitySchemaId);
					if (string.IsNullOrEmpty(AggregationColumnName)) {
						AggregationColumnName = entitySchema.PrimaryColumn.Name;
					}
					GroupByColumnName = GetColumnName(chartPropertyEntity.GetTypedColumnValue<string>("XAxisColumnMetaPath"), SelectedEntitySchemaId);
					OrderDirection = (OrderDirectionStrict)Enum.Parse(typeof(OrderDirectionStrict), chartPropertyEntity.GetTypedColumnValue<string>("OrderDirection"), true);
					OrderByColumnName = chartPropertyEntity.GetTypedColumnValue<string>("OrderByAxis");
					GroupByTypeDateTime = GetGroupByTypeDateTime(chartPropertyEntity.GetTypedColumnValue<Guid>("SysDateTimeFormatId"));;
					ModuleAccessColumnName = GetColumnName(chartPropertyEntity.GetTypedColumnValue<string>("ModuleSchemaColumnMetaPath"), SelectedEntitySchemaId);		
					PointType = ChartHelper.GetChartPointType(
						new EntitySchemaQuery(entitySchema),
						AggregationColumnName, 
						GroupByColumnName,
						UserConnection.DataValueTypeManager);
					var data = (byte[])chartPropertyEntity.GetBytesValue("FilterData");
					if (data != null) {
						SerializedFilters = UTF8Encoding.UTF8.GetString(data, 0, data.Length);
					}
				}
				ChartPropertyId = Guid.Empty;
			}
		}

		public virtual void ClearOldData() {
			SelectedEntitySchemaId = Guid.Empty;
			ChartHeader = string.Empty;
			XAxisCaption = string.Empty;
			YAxisCaption = string.Empty;
			ChartSeriesKind = UIWebControls.ChartSeriesKind.Line;
			ChartAggregationType = null;
			AggregationColumnName = string.Empty;
			GroupByColumnName = string.Empty;
			OrderDirection = null;
			OrderByColumnName = string.Empty;
			GroupByTypeDateTime = string.Empty;
			ModuleAccessColumnName = string.Empty;
			SerializedFilters = string.Empty;
		}

		public virtual string GetColumnName(string serializedStr, Guid entityId) {
			string result = string.Empty;
			if (!string.IsNullOrEmpty(serializedStr)) {
				JObject jObject = Json.Deserialize(serializedStr) as JObject;
				string columnIdStr = (jObject["metaPath"] as JValue).Value.ToString();
				var entitySchema = UserConnection.EntitySchemaManager.FindInstanceByUId(entityId);
				if (entitySchema != null && !string.IsNullOrEmpty(columnIdStr)) {
					result = entitySchema.GetSchemaColumnPathByMetaPath(columnIdStr);
				}	
			}
			return result;
		}

		public virtual AggregationTypeStrict GetAggregationType(Guid chartAggregationType) {
			var result = AggregationTypeStrict.Count;
			if (chartAggregationType == Guid.Empty) {
				return result;
			}
			var chartAggTypeESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysAggregationType");  
			chartAggTypeESQ.AddColumn("Id");      
			var aggregationTypeCodeColumn = chartAggTypeESQ.AddColumn("Code");
			var chartAggTypeIdFilter = chartAggTypeESQ.CreateFilterWithParameters(
				FilterComparisonType.Equal, "Id", chartAggregationType);
			chartAggTypeESQ.Filters.Add(chartAggTypeIdFilter);  
			var entityCollection = chartAggTypeESQ.GetEntityCollection(UserConnection);
			if (entityCollection != null && entityCollection.Count > 0) {
				var aggTypeCode = entityCollection[0].GetTypedColumnValue<string>(aggregationTypeCodeColumn.Name);
				if (!string.IsNullOrEmpty(aggTypeCode)) {
					result = (AggregationTypeStrict)Enum.Parse(typeof(AggregationTypeStrict), aggTypeCode, true);
				}
			}
			return result;
		}

		public virtual string GetGroupByTypeDateTime(Guid groupByTypeDateTimeId) {
			var result = string.Empty;
			if (groupByTypeDateTimeId == Guid.Empty) {
				return result;
			}
			var groupByTypeESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysDateTimeFormat");  
			groupByTypeESQ.AddColumn("Id");      
			var descriptionColumn = groupByTypeESQ.AddColumn("Code");
			var groupByTypeIdFilter = groupByTypeESQ.CreateFilterWithParameters(
				FilterComparisonType.Equal, "Id", groupByTypeDateTimeId);
			groupByTypeESQ.Filters.Add(groupByTypeIdFilter);  
			var entityCollection = groupByTypeESQ.GetEntityCollection(UserConnection);
			if (entityCollection != null && entityCollection.Count > 0) {
				result = entityCollection[0].GetTypedColumnValue<string>(descriptionColumn.Name);
			}
			return result;
		}

		public virtual void InitializeChartProperties() {
			if (string.IsNullOrEmpty(GroupByColumnName) || string.IsNullOrEmpty(AggregationColumnName) || ChartAggregationType == null) {
				return;
			}
			var chartEQS = (EntitySchemaQuery)ChartEQS;
			var groupByColumn = new Dictionary<string, EntitySchemaQueryColumn>();
			groupByColumn = GroupByColumnsBuildColumns(chartEQS);
			if (!string.IsNullOrEmpty(OrderByColumnName) && OrderByColumnName.Equals("GroupByField")) {
				if (((OrderDirectionStrict)OrderDirection).Equals(OrderDirectionStrict.Ascending)) {
					foreach(var key in groupByColumn.Keys) {
						groupByColumn[key].OrderByAsc();
					}
				} else {
					foreach(var key in groupByColumn.Keys) {
						groupByColumn[key].OrderByDesc();
					}
				}
			}
			var aggregationValueColumn = chartEQS.AddColumn(chartEQS.CreateAggregationFunction(
				(AggregationTypeStrict)ChartAggregationType, AggregationColumnName));
			if (!string.IsNullOrEmpty(OrderByColumnName) && OrderByColumnName.Equals("ChartEntityColumn")) {
				if (((OrderDirectionStrict)OrderDirection).Equals(OrderDirectionStrict.Ascending)) {
					aggregationValueColumn.OrderByAsc();
				} else {
					aggregationValueColumn.OrderByDesc();
				}
			}	
			var filters = chartEQS.Filters;
			var groupColumn = chartEQS.RootSchema.FindSchemaColumnByPath(GroupByColumnName);
			if (groupColumn.RequirementType.Equals(EntitySchemaColumnRequirementType.None)) {
			    var filter = chartEQS.CreateIsNotNullFilter(GroupByColumnName);
				filters.Add(filter);
			}
			string chartSchemaName = chartEQS.GetSchema().Name;
			if (!string.IsNullOrEmpty(SerializedFilters)) {
				var customFilterList = GetESQFilters(chartSchemaName, SerializedFilters);
				filters.Add(customFilterList);
			}
			if (!IsEditMode && !string.IsNullOrEmpty(ModuleAccessColumnName)
					&& !string.IsNullOrEmpty(SerializedModuleFilters)) {
			    if (ModuleEntitySchemaId.Equals(SelectedEntitySchemaId)) {
					var moduleFilters = GetESQFilters(chartSchemaName, SerializedModuleFilters);
					filters.Add(moduleFilters);         
				} else {
					var entitySchemaManager = UserConnection.EntitySchemaManager;
					var moduleSchema = entitySchemaManager.GetInstanceByUId(ModuleEntitySchemaId);
					var moduleFilters = EntitySchemaUtilities.DataSourceFiltersToESQFilters(
							UserConnection, moduleSchema, SerializedModuleFilters);
					DisableEmptyEntitySchemaQueryFilters(moduleFilters);
					var gridPageESQ = new EntitySchemaQuery(moduleSchema);
					gridPageESQ.AddColumn("Id");
					gridPageESQ.Filters.Add(moduleFilters);
					Select chartSelect = chartEQS.GetSelectQuery(UserConnection);
					Select gridPageSelect = gridPageESQ.GetSelectQuery(UserConnection);
					var condition = chartSelect.AddCondition(LogicalOperation.And);
					var relationESQ = new EntitySchemaQuery(entitySchemaManager, chartSchemaName);
					relationESQ.AddColumn(ModuleAccessColumnName);
					Select relationSelect = relationESQ.GetSelectQuery(UserConnection);
					relationSelect.SourceExpression.Alias = String.Format("{0}_relation", chartSchemaName);
					var relationEqualCondition = relationSelect.AddCondition(LogicalOperation.And);
					relationEqualCondition.LeftExpression = 
							new QueryColumnExpression(String.Format("{0}_relation", chartSchemaName), 
									chartEQS.PrimaryQueryColumn.Path);
					relationEqualCondition.IsEqual(chartSchemaName, chartEQS.PrimaryQueryColumn.Path);
					var relationCondition = relationSelect.AddCondition(LogicalOperation.And);
					relationCondition.LeftExpression = 
							new QueryColumnExpression(relationSelect.Columns[0].SourceAlias, 
									relationSelect.Columns[0].SourceColumnAlias);
					relationCondition.In(gridPageSelect);
					condition.Exists(relationSelect);
				}
			}
			var entitySchemaColumnAggregationValue = chartEQS.GetSchema().Columns.GetByName(aggregationValueColumn.Name);
			var entityCollection = chartEQS.GetEntityCollection(Page.UserConnection);
			PointType = ChartHelper.GetChartPointType(
				chartEQS, AggregationColumnName, GroupByColumnName, UserConnection.DataValueTypeManager);
			switch ((ChartPointType)PointType) {
				case ChartPointType.Double_DateTime:
					ChartPointsSeries = GetChartPointTypeDoubleDateTime(entityCollection, entitySchemaColumnAggregationValue, chartEQS, groupByColumn);
					break;
				case ChartPointType.String_Double:
					ChartPointsSeries = GetChartPointTypeStringDouble(entityCollection, entitySchemaColumnAggregationValue, chartEQS, groupByColumn);
					break;
				case ChartPointType.Double_Double:
					ChartPointsSeries = GetChartPointTypeDoubleDouble(entityCollection, entitySchemaColumnAggregationValue, chartEQS, groupByColumn);
					break;
				default: 
					ChartPointsSeries = null;
					break;
			}
		}

		public virtual Dictionary<string, EntitySchemaQueryColumn> GroupByColumnsBuildColumns(EntitySchemaQuery entitySchemaQuery) {
			var result = new Dictionary<string, EntitySchemaQueryColumn>();
			if (string.IsNullOrEmpty(GroupByTypeDateTime)) {
				result.Add("Property", entitySchemaQuery.AddColumn(GroupByColumnName));
			}
			else {
				if (GroupByTypeDateTime.Split(';').Length == 1) {
					var intervalTypeName = GroupByTypeDateTime.Split(';')[0];
					var intervalType = (EntitySchemaDatePartQueryFunctionInterval)Enum.Parse(typeof(EntitySchemaDatePartQueryFunctionInterval), intervalTypeName, true);
					result.Add(intervalTypeName, entitySchemaQuery.AddColumn(entitySchemaQuery.CreateDatePartFunction(intervalType, GroupByColumnName)));
				}
				else {
					var intervalTypeName1 = GroupByTypeDateTime.Split(';')[0];
					var intervalType1 = (EntitySchemaDatePartQueryFunctionInterval)Enum.Parse(typeof(EntitySchemaDatePartQueryFunctionInterval), intervalTypeName1, true);
					result.Add(intervalTypeName1, entitySchemaQuery.AddColumn(entitySchemaQuery.CreateDatePartFunction(intervalType1, GroupByColumnName)));		
					var intervalTypeName2 = GroupByTypeDateTime.Split(';')[1];
					var intervalType2 = (EntitySchemaDatePartQueryFunctionInterval)Enum.Parse(typeof(EntitySchemaDatePartQueryFunctionInterval), intervalTypeName2, true);
					result.Add(intervalTypeName2 , entitySchemaQuery.AddColumn(entitySchemaQuery.CreateDatePartFunction(intervalType2, GroupByColumnName)));
				}
			}
			return result;
		}

		public virtual List<Tuple<double, DateTime>> GetChartPointTypeDoubleDateTime(EntityCollection entityCollection, Terrasoft.Core.Entities.EntitySchemaColumn entitySchemaColumnAggregationValue, EntitySchemaQuery chartEQS, Dictionary<string, EntitySchemaQueryColumn> groupByColumn) {
			var result = new List<Tuple<double, DateTime>>();
			foreach (var item in entityCollection) {
				var name = Convert.ToDouble(GroupByColumnsGetSeriesName(item, groupByColumn, chartEQS));
				var aggregationValue = item.GetTypedColumnValue<DateTime>(entitySchemaColumnAggregationValue);
				result.Add(Tuple.Create(name, aggregationValue));
			}
			return result;
		}

		public virtual List<Tuple<string, double>> GetChartPointTypeStringDouble(EntityCollection entityCollection, Terrasoft.Core.Entities.EntitySchemaColumn entitySchemaColumnAggregationValue, EntitySchemaQuery chartEQS, Dictionary<string, EntitySchemaQueryColumn> groupByColumn) {
			var result = new List<Tuple<string, double>>();
			foreach (var item in entityCollection) {
				var name = GroupByColumnsGetSeriesName(item, groupByColumn, chartEQS);
				var aggregationValue = item.GetTypedColumnValue<double>(entitySchemaColumnAggregationValue);
				result.Add(Tuple.Create(name, aggregationValue));
			}
			return result;
		}

		public virtual List<Tuple<double, double>> GetChartPointTypeDoubleDouble(EntityCollection entityCollection, Terrasoft.Core.Entities.EntitySchemaColumn entitySchemaColumnAggregationValue, EntitySchemaQuery chartEQS, Dictionary<string, EntitySchemaQueryColumn> groupByColumn) {
			var result = new List<Tuple<double, double>>();
			foreach (var item in entityCollection) {
				var name = Convert.ToDouble(GroupByColumnsGetSeriesName(item, groupByColumn, chartEQS));
				var aggregationValue = item.GetTypedColumnValue<double>(entitySchemaColumnAggregationValue);
				result.Add(Tuple.Create(name, aggregationValue));
			}
			return result;
		}

		public virtual string GroupByColumnsGetSeriesName(Entity item, Dictionary<string, EntitySchemaQueryColumn> groupByColumn, EntitySchemaQuery entitySchemaQuery) {
			var result = string.Empty;
			if (string.IsNullOrEmpty(GroupByTypeDateTime)) {
				var entitySchemaColumnName = entitySchemaQuery.GetSchema().Columns.GetByName(groupByColumn["Property"].Name);
				result = item.GetColumnDisplayValue(entitySchemaColumnName);
			} else {
				if (GroupByTypeDateTime.Split(';').Length == 1) 
				{
					result = Convert.ToString(item.GetColumnValue(groupByColumn[GroupByTypeDateTime].Name));
				} else {		
					result = Convert.ToString(item.GetColumnValue(groupByColumn[GroupByTypeDateTime.Split(';')[0]].Name));
					result += "-";
					result += Convert.ToString(item.GetColumnValue(groupByColumn[GroupByTypeDateTime.Split(';')[1]].Name));
				}
			}
			return result;
		}

		public virtual EntitySchemaQueryFilterCollection GetESQFilters(string schemaName, string serializedFilters) {
			var filters = EntitySchemaUtilities.DataSourceFiltersToESQFilters(UserConnection, schemaName, serializedFilters);
			return filters;
		}

		public virtual void AddPoints() {
			if (PointType == null) {
				return;
			}
			var chart = Page.Chart;
			chart.Series[0].ClearPoints();
			switch((ChartPointType)PointType) {
				case ChartPointType.Double_DateTime:
					chart.Series[0].AddPoints((List<Tuple<double, DateTime>>)ChartPointsSeries);
					break;
				case ChartPointType.String_Double:
					chart.Series[0].AddPoints((List<Tuple<string, double>>)ChartPointsSeries);
					break;
				case ChartPointType.Double_Double:
					chart.Series[0].AddPoints((List<Tuple<double, double>>)ChartPointsSeries);
					break;		
				case ChartPointType.None:
					break;
			}
		}

		public virtual void DisableEmptyEntitySchemaQueryFilters(IEnumerable<IEntitySchemaQueryFilterItem> queryFilterCollection) {
			foreach (var item in queryFilterCollection) {
							var filter = item as EntitySchemaQueryFilter;
							if (filter != null) {
								if (filter.RightExpressions.Count == 0 && filter.ComparisonType != FilterComparisonType.IsNull &&
										filter.ComparisonType != FilterComparisonType.IsNotNull) {
									filter.IsEnabled = false;
									continue;
								}
								if (filter.LeftExpression != null &&
										filter.LeftExpression.ExpressionType == EntitySchemaQueryExpressionType.SubQuery) {
									DisableEmptyEntitySchemaQueryFilters(filter.LeftExpression.SubQuery.Filters);
								}
								foreach (var rightExpression in filter.RightExpressions) {
									if (rightExpression.ExpressionType == EntitySchemaQueryExpressionType.SubQuery) {
										DisableEmptyEntitySchemaQueryFilters(rightExpression.SubQuery.Filters);
									}
								}
							} else {
								DisableEmptyEntitySchemaQueryFilters((EntitySchemaQueryFilterCollection)item);
							}
						}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ProcessChanges":
							if (ActivatedEventElements.Contains("ProcessChangesStartMessage")) {
							context.QueueTasks.Enqueue("ProcessChangesStartMessage");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("InitStartMessage")) {
							context.QueueTasks.Enqueue("InitStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("ModuleEntitySchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ModuleEntitySchemaId", ModuleEntitySchemaId, Guid.Empty);
			}
			if (!HasMapping("SerializedModuleFilters") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SerializedModuleFilters", SerializedModuleFilters, null);
			}
			if (!HasMapping("ListenerPageProcessUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ListenerPageProcessUId", ListenerPageProcessUId, null);
			}
			if (ChartPointsSeries != null) {
				if (ChartPointsSeries.GetType().IsSerializable ||
					ChartPointsSeries.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ChartPointsSeries", ChartPointsSeries, null);
				}
			}
			if (!HasMapping("IsEditMode") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsEditMode", IsEditMode, false);
			}
			if (!HasMapping("HasYAxis") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("HasYAxis", HasYAxis, false);
			}
			if (!HasMapping("HasXAxis") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("HasXAxis", HasXAxis, false);
			}
			if (!HasMapping("SerializedFilters") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SerializedFilters", SerializedFilters, null);
			}
			if (PointType != null) {
				if (PointType.GetType().IsSerializable ||
					PointType.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("PointType", PointType, null);
				}
			}
			if (!HasMapping("ModuleAccessColumnName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ModuleAccessColumnName", ModuleAccessColumnName, null);
			}
			if (!HasMapping("GroupByTypeDateTime") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("GroupByTypeDateTime", GroupByTypeDateTime, null);
			}
			if (!HasMapping("OrderByColumnName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("OrderByColumnName", OrderByColumnName, null);
			}
			if (OrderDirection != null) {
				if (OrderDirection.GetType().IsSerializable ||
					OrderDirection.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("OrderDirection", OrderDirection, null);
				}
			}
			if (!HasMapping("GroupByColumnName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("GroupByColumnName", GroupByColumnName, null);
			}
			if (!HasMapping("AggregationColumnName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("AggregationColumnName", AggregationColumnName, null);
			}
			if (ChartAggregationType != null) {
				if (ChartAggregationType.GetType().IsSerializable ||
					ChartAggregationType.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ChartAggregationType", ChartAggregationType, null);
				}
			}
			if (ChartSeriesKind != null) {
				if (ChartSeriesKind.GetType().IsSerializable ||
					ChartSeriesKind.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ChartSeriesKind", ChartSeriesKind, null);
				}
			}
			if (!HasMapping("YAxisCaption") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("YAxisCaption", YAxisCaption, null);
			}
			if (!HasMapping("XAxisCaption") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("XAxisCaption", XAxisCaption, null);
			}
			if (!HasMapping("ChartHeader") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ChartHeader", ChartHeader, null);
			}
			if (ChartEQS != null) {
				if (ChartEQS.GetType().IsSerializable ||
					ChartEQS.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ChartEQS", ChartEQS, null);
				}
			}
			if (!HasMapping("SelectedEntitySchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SelectedEntitySchemaId", SelectedEntitySchemaId, Guid.Empty);
			}
			if (!HasMapping("ChartPropertyId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ChartPropertyId", ChartPropertyId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: ParameterizedChartPageEventsProcess

	/// <exclude/>
	public class ParameterizedChartPageEventsProcess : ParameterizedChartPageEventsProcess<Terrasoft.WebApp.ParameterizedChartPageSchemaUserControl>
	{

		public ParameterizedChartPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ParameterizedChartPageSchemaUserControl

	/// <exclude/>
	public partial class ParameterizedChartPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout MainControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("MainControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Chart Chart {
			get {
				return (Terrasoft.UI.WebControls.Controls.Chart)PageContainer.FindPageControl("Chart", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ChartXAxis HighchartXAxis1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ChartXAxis)PageContainer.FindPageControl("HighchartXAxis1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ChartYAxis HighchartYAxis1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ChartYAxis)PageContainer.FindPageControl("HighchartYAxis1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ChartSeries ChartSeries {
			get {
				return (Terrasoft.UI.WebControls.Controls.ChartSeries)PageContainer.FindPageControl("ChartSeries", true);
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
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (ParameterizedChartPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ParameterizedChartPageEventsProcess(UserConnection);
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
			SchemaName = "ParameterizedChartPage";
		}

		#endregion

	}

	#endregion

	#region Class: ParameterizedChartPageEventsProcessSchema

	/// <exclude/>
	public class ParameterizedChartPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public ParameterizedChartPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ParameterizedChartPageEventsProcessSchema(ParameterizedChartPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ParameterizedChartPageEventsProcess";
			UId = new Guid("07be521c-fd87-4389-95ec-599134df2577");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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

		protected virtual ProcessSchemaParameter CreateChartPropertyIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0de82a67-b11d-44f4-8b2f-44720c3fc1c0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"ChartPropertyId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8a092d46-c075-40ba-a0d0-b20819ab7641"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"SelectedEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateChartEQSParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1490d8a8-e7de-4135-94a0-fd7f7b31a0fc"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"ChartEQS",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateChartHeaderParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f277982f-11e9-4f90-bb44-7a130307c2e0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"ChartHeader",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateXAxisCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6700a30f-0032-4214-a569-7ab1ca5badf2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"XAxisCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateYAxisCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7aa3edcd-bb15-421b-90b7-887e460d5ce5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"YAxisCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateChartSeriesKindParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4baed520-60bc-4769-be13-febc72c41f24"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"ChartSeriesKind",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateChartAggregationTypeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d96c1e42-ed21-45f5-9afc-d11836277c5c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"ChartAggregationType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateAggregationColumnNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a6a91f8e-5278-4426-b94b-0fedcc528af7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateGroupByColumnNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3d6e0622-d140-43bf-9313-9253655ae7ec"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"GroupByColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateOrderDirectionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("778fd20a-d3a8-442b-a08e-ce2f2263d82d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"OrderDirection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateOrderByColumnNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("97fee13a-92c4-4fbc-bbfd-8ad51ca99d2c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"OrderByColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateGroupByTypeDateTimeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4ff88487-ed4a-417b-8682-6fe83af7820c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"GroupByTypeDateTime",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateModuleAccessColumnNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6255838a-8033-4b67-9fe4-e73a3252b649"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"ModuleAccessColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePointTypeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("df464584-62c0-4450-a695-02d4ba5787f8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"PointType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSerializedFiltersParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("92991937-40c8-4bb7-8e18-1c4b210ffe5d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"SerializedFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateHasXAxisParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("92b7b1d7-c3ae-4685-88ab-0bee854df58c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"HasXAxis",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateHasYAxisParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1e6eb47c-19d9-4e99-8827-cb0cf8d86549"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"HasYAxis",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsEditModeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d34d79f6-4144-4daf-a7fd-fb218e1c80a6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"IsEditMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateChartPointsSeriesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b9751712-b9be-4f14-a4da-fb2920ddbb28"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"ChartPointsSeries",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateListenerPageProcessUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("813fb5db-a09d-4a81-ac4c-97e66503b669"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"ListenerPageProcessUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSerializedModuleFiltersParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("979bbc4b-50f9-437c-bb41-292aa3886a84"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"SerializedModuleFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateModuleEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("747f0f2c-83e6-4e50-8db4-11ce38cb009f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"ModuleEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateChartPropertyIdParameter());
			Parameters.Add(CreateSelectedEntitySchemaIdParameter());
			Parameters.Add(CreateChartEQSParameter());
			Parameters.Add(CreateChartHeaderParameter());
			Parameters.Add(CreateXAxisCaptionParameter());
			Parameters.Add(CreateYAxisCaptionParameter());
			Parameters.Add(CreateChartSeriesKindParameter());
			Parameters.Add(CreateChartAggregationTypeParameter());
			Parameters.Add(CreateAggregationColumnNameParameter());
			Parameters.Add(CreateGroupByColumnNameParameter());
			Parameters.Add(CreateOrderDirectionParameter());
			Parameters.Add(CreateOrderByColumnNameParameter());
			Parameters.Add(CreateGroupByTypeDateTimeParameter());
			Parameters.Add(CreateModuleAccessColumnNameParameter());
			Parameters.Add(CreatePointTypeParameter());
			Parameters.Add(CreateSerializedFiltersParameter());
			Parameters.Add(CreateHasXAxisParameter());
			Parameters.Add(CreateHasYAxisParameter());
			Parameters.Add(CreateIsEditModeParameter());
			Parameters.Add(CreateChartPointsSeriesParameter());
			Parameters.Add(CreateListenerPageProcessUIdParameter());
			Parameters.Add(CreateSerializedModuleFiltersParameter());
			Parameters.Add(CreateModuleEntitySchemaIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess processchangeseventsubprocess = CreateProcessChangesEventSubProcessEventSubProcess();
			FlowElements.Add(processchangeseventsubprocess);
			ProcessSchemaEventSubProcess initeventsubprocess = CreateInitEventSubProcessEventSubProcess();
			FlowElements.Add(initeventsubprocess);
			ProcessSchemaStartMessageEvent processchangesstartmessage = CreateProcessChangesStartMessageStartMessageEvent();
			processchangeseventsubprocess.FlowElements.Add(processchangesstartmessage);
			ProcessSchemaScriptTask processchangesscripttask = CreateProcessChangesScriptTaskScriptTask();
			processchangeseventsubprocess.FlowElements.Add(processchangesscripttask);
			ProcessSchemaStartMessageEvent initstartmessage = CreateInitStartMessageStartMessageEvent();
			initeventsubprocess.FlowElements.Add(initstartmessage);
			ProcessSchemaScriptTask initscripttask = CreateInitScriptTaskScriptTask();
			initeventsubprocess.FlowElements.Add(initscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateChartCaptionLocalizableString());
			LocalizableStrings.Add(CreateSeriesCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateChartCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b840861a-d493-4f17-a8e0-6c6972c6e721"),
				Name = "ChartCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSeriesCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3e50a7a1-4834-46ae-bb30-45846034c685"),
				Name = "SeriesCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("2d86c284-97c4-4523-b2e6-c69e0500bc5e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				CurveCenterPosition = new Point(193, 105),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a71886a4-026f-4aa1-9bf3-2cc9661bcc90"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c561dda2-4655-488b-b0b8-890bcb00ad6d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("ca875a26-4c1a-4146-9eea-e4817534dddf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				CurveCenterPosition = new Point(190, 284),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e76d93f0-5c71-4b0b-a333-370f45a44343"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cfe7daea-5257-4b54-92f6-efd6037c6b14"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("ad30c37e-cdfb-4cb1-9cae-0cf146390871"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1096, 373),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("56a5704d-943a-4e7f-b040-5b98a5b3f98a"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("ad30c37e-cdfb-4cb1-9cae-0cf146390871"),
				CreatedInOwnerSchemaUId = new Guid("90cdaef8-fcad-486f-ade3-0ad8db15a644"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1067, 373),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateProcessChangesEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaProcessChangesEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e71d7a7b-aa4c-4656-9500-5dcc457db0e8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("56a5704d-943a-4e7f-b040-5b98a5b3f98a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"ProcessChangesEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 23),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(266, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaProcessChangesEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateProcessChangesStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a71886a4-026f-4aa1-9bf3-2cc9661bcc90"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e71d7a7b-aa4c-4656-9500-5dcc457db0e8"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ProcessChanges",
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"ProcessChangesStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateProcessChangesScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c561dda2-4655-488b-b0b8-890bcb00ad6d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e71d7a7b-aa4c-4656-9500-5dcc457db0e8"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"ProcessChangesScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(147, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,79,75,3,49,16,197,239,130,223,33,222,178,151,160,231,210,67,187,11,186,120,89,40,254,89,196,195,212,29,116,96,73,202,100,170,141,159,222,36,155,210,178,10,222,242,120,191,55,51,121,183,40,205,186,1,129,117,168,63,128,165,99,183,67,150,208,14,186,90,92,94,220,129,127,94,29,200,171,165,138,207,190,60,117,70,55,200,132,254,158,236,80,205,180,186,90,170,135,246,9,183,181,179,194,110,244,102,6,152,142,48,78,111,45,9,193,72,223,120,190,59,50,121,247,106,24,58,71,86,38,245,9,172,222,18,21,247,119,240,142,211,200,98,28,202,97,25,48,73,188,92,191,22,47,252,246,110,146,151,51,102,131,82,195,78,200,89,157,63,90,68,117,14,60,146,167,237,136,250,88,70,50,195,60,221,207,210,225,143,116,127,76,79,183,76,125,196,75,19,118,42,71,255,87,111,154,112,170,192,52,12,95,185,34,70,217,179,85,194,123,92,252,0,129,118,142,240,216,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateInitEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaInitEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("93a9f3d0-17ee-4d29-bc0f-332fc19e4a01"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("56a5704d-943a-4e7f-b040-5b98a5b3f98a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"InitEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(49, 203),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(259, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaInitEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e76d93f0-5c71-4b0b-a333-370f45a44343"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("93a9f3d0-17ee-4d29-bc0f-332fc19e4a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"InitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cfe7daea-5257-4b54-92f6-efd6037c6b14"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("93a9f3d0-17ee-4d29-bc0f-332fc19e4a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Name = @"InitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,112,206,72,44,42,9,78,45,202,76,45,246,206,204,75,81,176,181,85,200,43,205,201,209,84,168,230,229,226,196,144,84,8,245,12,79,77,114,206,207,43,41,202,207,41,214,67,147,215,243,201,204,75,181,230,229,170,229,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,186,34,154,81,103,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetDBDataByChartPropertyIdMethod());
			Methods.Add(CreateClearOldDataMethod());
			Methods.Add(CreateGetColumnNameMethod());
			Methods.Add(CreateGetAggregationTypeMethod());
			Methods.Add(CreateGetGroupByTypeDateTimeMethod());
			Methods.Add(CreateInitializeChartPropertiesMethod());
			Methods.Add(CreateGroupByColumnsBuildColumnsMethod());
			Methods.Add(CreateGetChartPointTypeDoubleDateTimeMethod());
			Methods.Add(CreateGetChartPointTypeStringDoubleMethod());
			Methods.Add(CreateGetChartPointTypeDoubleDoubleMethod());
			Methods.Add(CreateGroupByColumnsGetSeriesNameMethod());
			Methods.Add(CreateGetESQFiltersMethod());
			Methods.Add(CreateAddPointsMethod());
			Methods.Add(CreateDisableEmptyEntitySchemaQueryFiltersMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7c683da2-70fe-4c10-89b5-a6181f2773cf"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0b4f302c-0de9-4599-9be9-2aa208792d62"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a348a1ed-09bb-4501-af86-718219f2a86d"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("16694736-dc71-4c68-9136-a64abb2b8d22"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1e2c750d-e1fc-48bc-a13b-84b325dc6d4f"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "UIWebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateGetDBDataByChartPropertyIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("538bda47-be7e-446b-9001-79c98c33b280"),
				Name = "GetDBDataByChartPropertyId",
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,193,142,218,48,16,61,83,169,255,144,230,148,72,40,234,177,82,75,37,8,132,162,150,133,85,216,106,87,85,15,110,50,27,44,37,14,178,157,182,238,106,255,189,99,59,52,33,4,9,232,30,64,138,199,243,230,205,204,27,219,244,209,241,194,45,225,114,205,203,29,112,169,22,169,243,102,228,204,43,154,6,179,98,39,149,239,60,189,126,53,8,115,32,124,149,167,83,34,137,231,191,199,149,25,147,84,170,56,217,66,65,150,132,145,12,184,3,61,107,35,231,78,0,15,75,198,32,145,180,100,65,143,99,131,231,36,109,46,245,218,168,15,56,136,40,75,23,76,72,194,18,152,168,27,82,128,231,198,74,44,203,180,202,97,204,72,174,36,77,132,201,205,245,131,144,3,145,96,1,189,67,70,38,29,138,117,232,137,29,68,32,147,109,196,203,98,58,233,214,201,183,165,25,252,36,135,153,159,224,59,7,217,208,189,91,164,189,225,112,211,70,237,32,13,203,188,42,216,87,146,87,240,65,247,226,163,231,214,117,211,144,232,237,250,134,246,32,134,28,179,128,180,93,85,108,225,168,175,144,151,160,27,112,147,240,236,54,70,56,6,191,156,118,140,219,10,184,242,218,121,182,92,62,1,73,77,235,207,37,33,36,167,44,67,26,33,217,233,150,212,241,239,199,191,169,168,151,174,65,107,251,215,144,15,255,9,249,112,12,105,82,142,129,83,16,159,81,147,136,234,117,150,252,25,171,138,96,77,184,0,79,34,116,249,120,180,99,120,57,149,198,219,69,119,201,43,104,241,25,103,25,135,140,104,154,26,1,73,33,86,103,241,82,5,226,116,117,16,26,29,182,12,214,83,15,164,141,218,124,159,29,176,83,110,99,89,130,36,107,34,183,58,217,126,213,91,38,122,146,173,127,176,16,55,85,158,175,184,57,200,188,94,138,251,33,62,153,64,91,226,193,154,211,130,112,101,55,4,122,135,9,249,172,255,230,188,172,118,19,245,146,217,223,95,158,253,138,227,228,77,41,183,71,155,214,226,225,74,140,216,137,236,17,100,239,182,43,84,121,136,115,168,76,99,235,148,232,186,0,19,165,75,83,15,96,93,121,237,130,247,19,108,232,190,246,61,134,43,52,191,119,141,74,94,16,105,37,111,226,214,87,77,146,128,16,47,217,118,139,107,251,122,126,247,7,3,205,105,93,82,38,235,137,175,207,226,124,103,111,31,123,125,237,237,158,81,253,25,199,250,240,244,120,12,29,99,59,82,190,117,233,220,251,250,233,96,18,213,209,235,75,209,246,79,95,160,41,90,181,90,127,40,9,223,190,251,39,106,54,65,171,48,32,158,27,209,92,162,210,208,207,109,6,223,192,224,251,133,225,220,239,39,91,159,147,36,167,127,32,181,46,66,191,73,54,209,187,25,75,202,84,31,19,250,67,163,199,166,1,6,99,232,188,29,26,78,193,23,96,153,220,250,255,230,92,255,186,15,166,246,123,9,55,62,255,5,73,205,101,173,85,9,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateClearOldDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("20623712-14b4-400d-89e0-14562ca77933"),
				Name = "ClearOldData",
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,75,14,194,48,12,68,247,156,130,19,244,2,136,69,105,249,137,223,162,32,96,25,154,81,177,148,38,149,227,72,148,211,211,82,144,16,160,110,253,102,198,30,103,48,200,5,122,106,133,164,206,242,43,74,181,212,195,241,112,30,72,71,211,178,146,122,52,72,174,138,101,1,165,193,13,241,194,100,139,55,59,197,55,242,137,170,132,156,253,129,231,62,248,76,205,192,4,191,34,219,238,60,44,143,184,36,206,10,59,227,163,47,30,173,201,226,229,138,139,130,81,168,54,118,95,87,104,172,54,24,51,26,124,204,19,103,66,105,183,170,196,207,226,57,187,80,77,234,30,197,142,155,170,41,113,243,154,238,242,46,254,57,238,53,190,162,219,163,82,37,216,211,31,205,198,233,96,16,231,57,188,239,137,106,155,43,67,119,232,25,25,1,251,111,197,3,171,189,87,27,187,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetColumnNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("62cb7b03-1d84-4346-8d6c-75eadc3ce4c2"),
				Name = "GetColumnName",
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5f610871-90aa-4d98-b615-1e11204e11b7"),
				Name = "serializedStr",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("904338c1-397e-4fd4-8303-cfa3d72e080b"),
				Name = "entityId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,145,193,78,195,48,12,134,207,205,83,120,59,76,237,37,47,80,245,178,49,80,39,141,33,149,113,65,28,66,107,182,76,169,139,18,23,169,160,189,59,105,26,77,27,226,228,36,246,255,217,254,227,216,106,58,128,69,215,27,134,2,92,184,203,117,251,201,67,46,244,7,164,179,248,84,186,199,222,152,157,13,169,212,161,213,202,232,111,108,42,182,89,6,63,34,217,236,222,79,88,51,156,98,44,96,227,58,146,119,120,169,253,163,2,229,32,138,114,145,76,109,160,238,76,223,82,57,22,120,66,26,97,175,243,22,89,61,41,62,206,223,130,236,69,153,30,51,25,130,124,238,170,32,78,51,207,249,82,22,144,88,243,80,213,71,108,149,167,236,125,223,85,71,228,65,218,79,180,190,202,110,21,169,3,90,121,175,169,41,201,177,162,26,151,195,190,108,210,137,81,54,35,115,244,225,134,57,43,128,188,27,176,88,192,255,254,92,173,49,185,147,92,44,190,6,201,7,228,233,180,10,130,113,195,229,176,141,187,222,80,252,24,231,68,156,133,69,238,45,197,31,203,197,47,246,7,61,124,193,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetAggregationTypeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7fc623a9-7659-4b76-af90-8b423b35c119"),
				Name = "GetAggregationType",
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "AggregationTypeStrict"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("263630e6-d5ae-4da1-887d-08d0ca18b479"),
				Name = "chartAggregationType",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,147,203,110,130,64,20,134,215,242,20,163,11,51,36,132,184,183,54,49,132,26,23,181,53,244,178,104,186,152,192,17,73,134,193,206,197,134,52,190,123,207,204,104,163,136,101,7,252,231,252,223,185,237,153,36,18,148,225,154,204,200,188,44,37,148,76,87,141,120,105,119,144,105,89,229,58,78,26,35,244,52,168,54,132,230,91,38,117,71,69,102,51,178,48,85,17,167,245,78,183,33,249,9,6,18,180,145,226,152,119,26,28,130,61,186,156,98,109,76,154,173,209,78,192,55,73,133,174,116,155,229,91,168,217,218,128,108,233,171,2,153,52,66,64,110,29,226,115,193,35,19,172,4,25,145,81,214,170,14,198,40,156,18,18,116,76,226,121,81,36,13,55,181,160,163,101,225,36,246,113,60,236,50,62,105,10,240,82,36,251,39,141,213,97,162,171,146,150,197,67,197,53,200,158,232,68,2,211,224,127,191,87,122,251,204,36,171,1,95,20,13,6,254,115,210,212,59,38,43,229,89,226,244,203,48,142,101,34,115,68,250,154,142,0,93,23,159,72,89,86,218,7,230,250,99,169,193,117,20,235,225,190,197,61,196,11,208,105,71,213,153,75,232,23,226,42,215,16,199,106,56,39,227,241,149,143,95,36,114,79,38,110,73,142,51,56,245,30,41,186,1,31,147,79,75,98,21,199,246,191,49,110,224,78,225,94,138,242,158,222,156,96,188,194,254,34,225,192,34,14,189,60,94,170,21,130,61,73,183,166,244,204,57,116,56,131,191,43,160,189,103,16,166,194,212,49,142,78,1,213,248,181,217,220,208,69,231,85,69,68,75,227,80,14,120,6,151,119,241,11,106,43,164,27,123,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetGroupByTypeDateTimeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7b8633fc-34b2-4a57-a613-59cfacbb3b45"),
				Name = "GetGroupByTypeDateTime",
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("cae45b26-0f62-486d-98c8-a929acc9ec28"),
				Name = "groupByTypeDateTimeId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,146,65,79,194,64,16,133,207,244,87,140,28,72,155,144,134,59,66,162,181,16,14,26,9,168,7,227,97,195,142,176,201,118,183,206,238,98,26,227,127,119,183,139,9,180,218,91,219,55,51,223,188,121,71,70,64,104,156,180,48,3,99,73,168,125,94,86,181,109,166,137,120,135,116,79,218,213,183,205,182,169,241,142,89,220,138,10,87,28,102,51,88,58,193,163,48,131,175,100,64,104,29,169,83,167,105,242,157,28,125,223,179,226,114,179,246,253,21,126,66,169,172,176,205,102,119,192,138,173,29,82,147,62,25,164,66,43,133,59,43,180,202,207,5,247,76,177,61,210,24,134,155,198,252,2,44,52,85,204,14,179,41,64,114,57,34,191,225,188,208,210,85,42,29,174,120,171,8,79,11,195,209,236,72,212,97,68,148,120,158,255,171,11,205,209,215,119,215,88,241,133,144,22,169,95,91,16,122,188,248,247,69,216,195,35,35,86,161,127,49,105,50,136,159,11,93,213,140,132,209,42,20,229,229,135,99,210,111,230,65,199,240,167,207,126,126,103,74,108,100,2,105,250,7,86,107,73,64,198,214,67,191,140,140,166,246,121,151,104,203,142,168,115,136,44,38,160,215,234,202,223,209,73,9,163,81,111,76,94,104,167,44,204,97,114,10,197,41,87,93,221,235,228,45,0,4,150,147,227,207,76,58,188,142,249,155,167,189,91,229,15,222,204,44,228,234,50,104,63,220,3,99,81,190,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeChartPropertiesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ac3d098c-bb10-40aa-8a21-02c4e1ba22c8"),
				Name = "InitializeChartProperties",
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,88,89,111,219,56,16,126,86,128,252,7,213,15,5,5,8,66,159,155,205,2,62,228,174,177,105,142,58,217,151,162,8,88,105,108,19,213,225,82,212,182,106,155,255,190,164,134,178,72,29,169,131,77,155,39,133,115,240,155,111,134,51,147,176,141,75,10,193,89,182,13,86,197,101,153,36,87,60,76,247,162,34,111,120,94,238,103,213,60,79,202,52,187,164,41,120,238,143,31,238,160,234,116,187,229,176,165,130,229,89,71,125,190,163,92,24,226,219,106,15,238,249,185,155,73,107,207,253,126,122,226,112,16,37,207,206,78,79,30,78,79,254,165,220,141,148,69,120,179,118,207,93,18,102,130,137,106,29,237,32,165,55,37,240,202,155,107,233,25,42,111,77,140,210,34,131,47,238,130,69,234,38,202,171,63,16,172,239,246,252,160,193,159,196,147,126,186,62,172,184,139,89,201,146,88,127,147,6,155,50,99,146,183,23,131,108,92,241,24,184,77,220,203,151,110,239,52,8,63,151,52,41,200,68,95,184,100,144,196,19,15,89,81,222,9,122,90,48,14,117,68,107,121,89,36,60,251,208,107,220,12,233,6,211,34,130,44,150,16,181,91,103,147,115,160,209,142,40,242,62,65,229,178,204,230,48,248,27,170,66,235,58,150,228,189,84,255,16,232,40,164,223,154,59,199,145,89,115,30,92,72,10,120,214,11,22,96,223,112,40,15,218,214,210,63,52,41,225,144,182,38,55,193,52,214,249,58,164,43,152,75,76,2,140,50,92,150,89,77,19,145,190,73,167,60,53,205,67,149,235,187,195,149,254,188,245,128,53,94,151,44,74,127,117,81,12,115,218,203,181,153,230,199,77,218,236,169,196,57,152,185,13,75,4,240,194,76,213,18,143,204,199,220,207,231,187,60,23,248,116,165,126,22,227,39,170,205,170,107,42,118,3,157,74,231,195,240,24,188,131,207,165,36,34,133,76,168,84,54,12,153,173,1,53,187,138,151,121,6,200,148,43,127,218,72,76,140,88,96,50,237,185,80,153,199,184,134,113,57,154,7,85,167,4,191,61,236,126,88,60,232,20,1,41,27,243,154,55,160,5,196,11,148,236,209,178,91,3,103,52,97,223,32,214,52,235,116,215,77,182,44,68,158,226,249,5,43,132,106,123,32,194,245,141,86,37,29,16,190,219,247,214,141,165,235,83,71,85,3,92,21,97,204,196,219,60,6,85,250,195,120,165,180,76,96,26,69,80,20,6,101,170,218,70,109,90,84,104,109,69,170,210,165,110,71,145,153,232,85,220,164,127,13,137,124,27,16,219,210,230,97,40,170,82,211,241,83,120,178,17,213,173,204,164,43,181,197,110,243,211,121,104,10,2,24,224,222,210,140,110,235,226,187,43,128,207,243,44,195,183,29,132,125,165,51,59,6,148,73,203,1,127,170,180,86,89,33,104,22,193,172,186,91,197,131,172,121,103,99,172,152,122,119,130,37,76,48,40,130,5,21,116,157,151,60,106,52,111,115,131,187,122,4,56,118,24,190,133,245,39,116,46,88,65,63,74,140,170,20,122,35,190,185,37,237,219,97,179,97,241,181,140,92,226,209,123,67,207,3,49,161,160,165,97,101,204,153,201,74,206,237,158,124,57,158,108,165,138,149,167,95,59,126,119,94,122,125,136,72,108,146,44,7,205,149,7,31,38,134,35,220,212,237,32,151,243,64,29,53,16,208,8,67,212,34,114,145,111,89,68,147,171,61,240,186,239,7,211,204,40,8,14,73,125,250,24,159,3,117,231,119,219,29,122,52,188,25,60,143,116,8,147,141,198,240,192,134,233,233,8,54,108,251,0,139,55,252,186,231,242,202,58,230,132,81,85,239,107,236,70,203,156,167,84,144,201,247,87,15,247,141,233,100,36,38,139,37,213,125,230,6,235,157,123,143,36,126,216,93,112,1,27,209,98,150,222,241,165,169,164,24,219,111,171,65,158,22,141,175,253,57,206,161,92,175,57,75,229,194,109,120,15,212,100,126,20,165,156,9,234,160,223,66,143,243,106,210,249,124,76,254,15,18,59,23,235,191,25,222,191,250,160,171,168,46,157,150,187,159,169,227,65,109,52,6,113,149,17,251,245,163,226,225,53,7,225,87,57,135,139,14,178,195,94,134,91,23,244,22,160,105,103,183,27,219,64,52,100,117,54,171,84,234,200,200,86,216,188,129,246,58,41,72,240,217,117,156,135,29,49,81,193,5,253,151,122,157,51,92,207,164,125,189,47,255,5,201,30,199,88,253,235,65,174,166,76,115,193,200,250,238,187,189,69,205,239,78,87,53,201,234,144,148,79,221,187,20,142,226,11,19,209,78,174,229,246,173,94,251,85,143,241,136,202,121,110,171,4,139,188,148,195,235,94,122,134,91,150,194,107,149,186,86,165,80,147,15,244,194,97,91,162,97,99,71,186,140,250,71,164,180,125,100,190,253,231,25,86,208,71,185,206,126,58,27,193,141,205,226,30,81,28,143,26,205,208,234,183,99,110,184,126,34,102,205,244,175,199,28,195,134,150,137,120,237,142,65,83,255,47,177,76,30,254,3,63,38,163,108,184,17,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGroupByColumnsBuildColumnsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ecd05305-b775-4059-9841-eda59b09d55b"),
				Name = "GroupByColumnsBuildColumns",
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<string, EntitySchemaQueryColumn>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8873cb4b-71ec-4805-8301-faf74fc0936b"),
				Name = "entitySchemaQuery",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchemaQuery",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,148,65,107,194,64,16,133,207,217,95,177,120,113,3,33,52,185,166,22,90,181,69,40,214,162,183,210,67,208,81,23,146,77,152,204,90,150,226,127,111,214,24,176,77,180,182,32,30,151,157,247,230,205,55,203,110,98,228,8,133,78,136,247,184,130,15,62,144,115,146,153,138,209,220,22,132,82,173,60,62,84,36,201,76,231,107,72,227,87,13,104,250,89,162,83,117,39,220,136,201,37,23,85,157,63,42,198,58,73,94,112,152,230,100,196,19,102,58,127,48,51,147,195,32,38,152,201,20,92,151,127,50,167,234,230,223,47,22,162,51,193,44,7,36,211,241,56,252,108,98,43,170,70,181,87,117,26,199,214,41,98,91,6,73,1,214,209,102,104,105,231,79,243,68,146,232,70,93,215,127,6,181,162,53,239,245,120,176,11,225,108,202,185,165,34,192,77,156,88,145,117,45,9,156,182,121,187,121,143,90,180,165,78,28,50,178,202,73,140,180,27,227,81,171,29,208,209,94,224,14,149,78,253,242,186,0,65,165,56,91,254,65,235,53,50,123,156,80,131,107,99,29,128,109,86,157,194,219,188,235,35,148,57,234,44,117,140,111,182,30,111,217,138,205,177,101,78,189,152,86,202,193,127,49,7,215,228,28,156,7,58,184,0,233,224,8,106,199,57,66,56,252,157,112,208,74,56,188,38,225,240,60,194,33,191,0,226,240,196,107,222,50,4,210,168,246,223,100,196,190,0,113,192,90,206,51,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetChartPointTypeDoubleDateTimeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0c30242f-a385-4260-9299-c64da887e31b"),
				Name = "GetChartPointTypeDoubleDateTime",
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Tuple<double, DateTime>>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9a275a33-c52d-49af-9f5e-2e33a3c3dba3"),
				Name = "entityCollection",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntityCollection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4be683c5-6cb1-4760-acb0-5fac1a4aae1d"),
				Name = "entitySchemaColumnAggregationValue",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.Core.Entities.EntitySchemaColumn",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("87a0b16b-3d3d-4d53-aea9-c80d451c6ba0"),
				Name = "chartEQS",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchemaQuery",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("dcbb75d1-90ce-4bac-b237-3e3c553f5e12"),
				Name = "groupByColumn",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, EntitySchemaQueryColumn>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,193,74,196,64,16,68,207,230,43,250,56,129,144,31,216,184,176,102,151,189,136,32,9,222,199,164,76,6,38,51,161,211,19,89,196,127,119,38,17,17,61,119,213,171,234,90,53,19,99,9,86,232,158,28,222,233,209,44,82,181,97,182,168,122,31,94,45,10,58,107,65,107,38,28,143,42,63,100,111,158,161,187,145,212,26,173,70,48,145,113,4,39,70,110,181,183,22,157,24,239,114,250,200,238,146,192,233,9,145,92,123,183,130,165,108,253,121,131,170,43,251,48,63,36,71,152,220,114,133,52,96,131,229,41,202,85,130,22,52,252,86,20,212,141,154,229,242,220,228,177,194,70,214,195,192,24,116,74,123,209,54,164,148,100,44,35,171,189,205,232,119,227,118,170,126,62,80,123,209,166,27,49,233,93,113,250,195,73,252,125,145,242,212,247,106,155,162,172,227,207,2,149,190,41,254,37,167,74,159,25,67,2,187,239,49,15,95,230,68,255,13,88,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetChartPointTypeStringDoubleMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("45741d2a-0ad8-460d-8cab-63e69cd46b2b"),
				Name = "GetChartPointTypeStringDouble",
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Tuple<string, double>>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a3876235-5f8d-4755-88e6-af698739e501"),
				Name = "entityCollection",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntityCollection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("65acebdd-d37c-4dcf-8956-b81d6e0f4d7e"),
				Name = "entitySchemaColumnAggregationValue",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.Core.Entities.EntitySchemaColumn",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3416253a-f1d3-469d-9c73-b75ddd401ca0"),
				Name = "chartEQS",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchemaQuery",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("360bf066-c58c-4af3-a550-27c585319a5b"),
				Name = "groupByColumn",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, EntitySchemaQueryColumn>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,193,106,195,48,16,68,207,245,87,236,81,6,227,31,136,27,72,67,201,37,20,138,67,239,170,61,149,5,178,100,86,171,148,80,250,239,149,236,28,74,123,158,153,183,51,123,213,76,140,152,156,208,35,121,124,210,217,70,233,46,105,113,232,162,176,245,166,161,49,164,119,135,253,94,213,187,234,35,48,244,48,145,186,230,160,21,204,100,61,193,139,149,219,49,56,135,65,108,240,53,125,85,15,197,224,245,140,204,61,113,72,203,83,49,164,217,199,19,164,7,91,196,151,172,170,194,104,200,252,118,52,52,76,154,229,249,181,207,7,87,142,54,134,97,116,97,191,105,151,10,179,228,218,140,186,220,22,140,91,110,149,186,123,91,181,149,234,135,9,179,222,244,195,31,74,161,111,219,219,195,56,170,117,116,123,204,251,4,170,52,111,254,221,173,115,228,187,98,72,98,127,127,219,238,7,233,211,32,211,66,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetChartPointTypeDoubleDoubleMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3f89fae9-d752-4d30-a2e2-70b151de356b"),
				Name = "GetChartPointTypeDoubleDouble",
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Tuple<double, double>>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4f6f88de-96e5-4fb0-9ae9-705108128d87"),
				Name = "entityCollection",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntityCollection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4ce54672-aeee-4f01-a532-1b8d31827310"),
				Name = "entitySchemaColumnAggregationValue",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.Core.Entities.EntitySchemaColumn",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c06ad94f-f944-40a4-baa1-d01519c6cf8e"),
				Name = "chartEQS",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchemaQuery",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e877c4b0-fbab-4df0-9835-b642c1c6324c"),
				Name = "groupByColumn",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, EntitySchemaQueryColumn>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,65,107,195,48,12,133,207,203,175,208,209,129,144,63,208,54,208,101,163,151,49,24,9,187,187,137,150,24,28,59,40,114,74,41,253,239,179,226,30,202,118,210,65,239,125,122,79,171,38,32,92,130,101,56,128,195,11,124,152,133,247,109,152,45,238,123,31,206,22,11,72,179,170,84,190,203,126,60,161,238,70,80,107,52,26,198,9,140,3,116,108,248,90,123,107,177,99,227,93,14,183,236,69,4,78,79,24,185,181,119,43,18,151,173,127,219,80,234,68,62,204,175,226,8,147,91,78,200,13,146,193,229,51,202,149,64,11,24,158,21,5,116,163,38,126,255,106,242,24,97,35,235,97,32,28,180,92,251,214,54,200,21,49,150,145,213,94,103,236,147,113,91,61,122,84,42,197,108,186,17,39,157,246,199,63,20,161,167,111,148,199,190,87,219,27,202,58,54,102,84,210,165,248,119,87,2,221,51,66,14,228,30,143,220,253,2,52,180,4,148,84,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGroupByColumnsGetSeriesNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5138fe0a-fc66-4c17-b577-e865af863e33"),
				Name = "GroupByColumnsGetSeriesName",
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f819e9db-dbdb-4ec8-a488-355b195e9762"),
				Name = "item",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e8371896-dca4-4919-976c-bca596287e5a"),
				Name = "groupByColumn",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, EntitySchemaQueryColumn>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e7c91ba9-aa8e-4775-895f-5cf2110645e3"),
				Name = "entitySchemaQuery",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchemaQuery",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,146,189,106,195,48,20,133,103,235,41,132,151,72,148,138,102,54,94,146,148,80,40,105,139,77,151,144,65,148,91,71,32,201,66,63,6,81,252,238,181,98,167,181,33,99,70,221,115,143,190,115,132,58,110,177,5,23,164,199,37,118,222,10,221,176,103,101,124,44,144,248,198,100,154,188,184,67,144,242,205,94,20,178,183,109,48,155,88,71,3,59,238,161,22,10,40,197,63,40,235,134,203,64,123,225,99,245,117,6,197,183,173,12,74,31,184,130,225,242,185,240,17,192,70,182,7,63,30,9,101,227,170,75,179,77,76,14,210,140,148,81,56,230,239,182,53,96,125,204,79,44,201,180,64,217,95,110,225,65,37,231,184,187,19,206,72,30,63,185,12,64,110,199,25,220,61,6,233,32,165,78,61,111,84,98,149,145,194,147,85,177,162,236,21,116,227,207,184,44,241,154,98,148,13,166,127,248,182,213,221,16,140,213,109,117,121,44,178,76,51,198,88,150,185,65,155,90,165,90,215,100,89,118,127,204,172,212,241,233,52,131,94,65,15,37,206,31,243,229,224,254,232,245,28,221,163,30,89,240,193,234,233,39,22,232,23,154,54,22,194,150,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetESQFiltersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("69198c72-de52-4ec6-bce5-71aafd2cf219"),
				Name = "GetESQFilters",
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "EntitySchemaQueryFilterCollection"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("28099650-fed3-42e6-9449-abb09020a5e8"),
				Name = "schemaName",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f7240ac1-0bed-4314-be13-8333973724f2"),
				Name = "serializedFilters",
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,203,204,41,73,45,42,86,176,85,112,205,43,201,44,169,12,78,206,72,205,77,12,45,201,204,201,44,201,76,45,214,115,73,44,73,12,206,47,45,74,78,117,131,168,12,201,119,13,14,132,178,53,66,139,83,139,156,243,243,242,82,147,75,50,243,243,116,20,138,193,186,253,18,115,83,129,236,212,162,204,196,156,204,170,212,20,168,106,77,107,94,174,162,212,146,210,162,60,152,173,214,0,138,66,69,2,130,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAddPointsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7c04c094-ae32-452f-9da3-62cbe59b42ea"),
				Name = "AddPoints",
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,143,79,11,130,64,16,197,207,43,248,29,230,184,66,72,231,76,33,244,24,17,232,45,34,54,157,114,105,91,99,119,45,34,250,238,217,154,69,129,80,221,230,207,123,243,123,195,55,64,231,21,151,38,59,31,16,194,16,100,45,132,7,23,215,33,10,77,173,100,224,58,87,215,57,50,5,121,201,148,129,16,230,108,139,126,124,111,154,157,29,250,41,42,142,122,49,92,250,177,64,166,236,65,77,189,102,175,79,220,228,37,165,86,255,4,121,175,202,162,114,166,17,222,37,126,82,213,107,129,171,132,25,204,248,30,71,141,140,124,210,38,69,241,96,209,41,215,102,156,213,7,129,227,194,58,7,208,89,163,200,123,221,214,173,251,158,141,144,181,66,182,11,122,2,164,70,113,185,93,181,57,126,192,107,235,27,64,27,227,79,120,247,253,175,240,238,247,239,224,132,244,224,103,149,108,169,93,200,235,13,0,223,184,228,41,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDisableEmptyEntitySchemaQueryFiltersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6654b71d-bdac-4cb0-9e30-9c2a6b8642dd"),
				Name = "DisableEmptyEntitySchemaQueryFilters",
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("44b9beed-263f-4368-8040-92bf772d9da8"),
				Name = "queryFilterCollection",
				CreatedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				ModifiedInSchemaUId = new Guid("07be521c-fd87-4389-95ec-599134df2577"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "IEnumerable<IEntitySchemaQueryFilterItem>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,83,203,106,195,48,16,60,187,208,127,216,94,130,115,17,189,7,159,82,23,2,37,208,166,63,160,184,171,90,32,75,174,36,151,154,226,127,175,228,87,100,39,134,4,234,139,204,238,206,206,204,174,196,148,70,154,229,16,127,83,13,220,98,1,92,194,87,133,186,126,230,194,162,222,42,33,48,179,92,201,53,252,222,223,69,238,243,149,172,77,66,210,65,168,129,84,90,110,235,67,150,99,65,95,79,240,77,7,225,12,226,30,242,144,128,172,132,24,187,5,57,242,198,63,115,155,254,148,26,141,113,140,134,108,85,37,45,36,9,60,194,106,213,147,186,96,81,82,205,141,146,239,117,137,190,225,32,53,140,147,157,217,59,30,135,235,121,162,232,102,188,178,251,137,212,161,195,206,164,146,30,5,126,184,1,48,42,12,110,134,130,76,185,57,200,106,12,52,231,38,95,144,5,30,135,121,92,208,57,45,36,167,223,86,182,27,202,217,204,167,37,228,80,29,219,112,96,224,137,27,47,60,45,74,91,47,172,204,92,22,58,118,35,125,217,122,238,145,133,87,73,79,87,233,111,213,194,146,3,117,126,74,51,224,255,216,190,206,247,156,122,209,241,104,185,63,27,64,119,9,70,186,171,200,226,133,76,240,224,252,219,26,56,59,166,230,15,232,100,246,208,175,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ParameterizedChartPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("07be521c-fd87-4389-95ec-599134df2577"));
		}

		#endregion

	}

	#endregion

}

