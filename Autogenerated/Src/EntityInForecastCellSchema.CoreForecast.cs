namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: EntityInForecastCellSchema

	/// <exclude/>
	[IsVirtual]
	public class EntityInForecastCellSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public EntityInForecastCellSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EntityInForecastCellSchema(EntityInForecastCellSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EntityInForecastCellSchema(EntityInForecastCellSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3a622ca4-e1ea-4273-8b41-c20129310fd7");
			RealUId = new Guid("3a622ca4-e1ea-4273-8b41-c20129310fd7");
			Name = "EntityInForecastCell";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeMasterRecordColumn() {
			base.InitializeMasterRecordColumn();
			MasterRecordColumn = CreateRowColumn();
			if (Columns.FindByUId(MasterRecordColumn.UId) == null) {
				Columns.Add(MasterRecordColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("13a9c898-7ab7-4784-9ba0-607934f8868a")) == null) {
				Columns.Add(CreatePeriodColumn());
			}
			if (Columns.FindByUId(new Guid("c74827b5-2f09-40cb-9461-d327016a4dc1")) == null) {
				Columns.Add(CreateSheetColumn());
			}
			if (Columns.FindByUId(new Guid("154f4031-1e3d-40fb-b9bb-6105f0bd369b")) == null) {
				Columns.Add(CreateIndicatorColumn());
			}
			if (Columns.FindByUId(new Guid("0a3fb99b-1aff-4b2f-a21a-4a00e81891ca")) == null) {
				Columns.Add(CreateAmountColumn());
			}
			if (Columns.FindByUId(new Guid("bc25e330-e553-424f-9893-395bd4905e23")) == null) {
				Columns.Add(CreatePrimaryAmountColumn());
			}
			if (Columns.FindByUId(new Guid("86994e3d-15be-4347-b059-33142ce79636")) == null) {
				Columns.Add(CreateCurrencyColumn());
			}
			if (Columns.FindByUId(new Guid("21795fb2-399d-4456-9678-1a2703ea8b74")) == null) {
				Columns.Add(CreateValueColumn());
			}
			if (Columns.FindByUId(new Guid("4f7afe87-8872-46c7-bd31-d6a74ec15319")) == null) {
				Columns.Add(CreateForecastColumnColumn());
			}
		}

		protected virtual EntitySchemaColumn CreatePeriodColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("13a9c898-7ab7-4784-9ba0-607934f8868a"),
				Name = @"Period",
				ReferenceSchemaUId = new Guid("5b473ba3-604c-41d6-b25d-032754dad4d2"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3a622ca4-e1ea-4273-8b41-c20129310fd7"),
				ModifiedInSchemaUId = new Guid("3a622ca4-e1ea-4273-8b41-c20129310fd7"),
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39")
			};
		}

		protected virtual EntitySchemaColumn CreateSheetColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c74827b5-2f09-40cb-9461-d327016a4dc1"),
				Name = @"Sheet",
				ReferenceSchemaUId = new Guid("f97c7d7a-e614-4850-8ec4-98d8af22b3d0"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3a622ca4-e1ea-4273-8b41-c20129310fd7"),
				ModifiedInSchemaUId = new Guid("3a622ca4-e1ea-4273-8b41-c20129310fd7"),
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39")
			};
		}

		protected virtual EntitySchemaColumn CreateIndicatorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("154f4031-1e3d-40fb-b9bb-6105f0bd369b"),
				Name = @"Indicator",
				ReferenceSchemaUId = new Guid("e0b448d7-44a9-465c-8de0-2f79c3415fba"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3a622ca4-e1ea-4273-8b41-c20129310fd7"),
				ModifiedInSchemaUId = new Guid("3a622ca4-e1ea-4273-8b41-c20129310fd7"),
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39")
			};
		}

		protected virtual EntitySchemaColumn CreateAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("0a3fb99b-1aff-4b2f-a21a-4a00e81891ca"),
				Name = @"Amount",
				CreatedInSchemaUId = new Guid("3a622ca4-e1ea-4273-8b41-c20129310fd7"),
				ModifiedInSchemaUId = new Guid("3a622ca4-e1ea-4273-8b41-c20129310fd7"),
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("bc25e330-e553-424f-9893-395bd4905e23"),
				Name = @"PrimaryAmount",
				CreatedInSchemaUId = new Guid("3a622ca4-e1ea-4273-8b41-c20129310fd7"),
				ModifiedInSchemaUId = new Guid("3a622ca4-e1ea-4273-8b41-c20129310fd7"),
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39")
			};
		}

		protected virtual EntitySchemaColumn CreateCurrencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("86994e3d-15be-4347-b059-33142ce79636"),
				Name = @"Currency",
				ReferenceSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3a622ca4-e1ea-4273-8b41-c20129310fd7"),
				ModifiedInSchemaUId = new Guid("3a622ca4-e1ea-4273-8b41-c20129310fd7"),
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39")
			};
		}

		protected virtual EntitySchemaColumn CreateValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("21795fb2-399d-4456-9678-1a2703ea8b74"),
				Name = @"Value",
				CreatedInSchemaUId = new Guid("3a622ca4-e1ea-4273-8b41-c20129310fd7"),
				ModifiedInSchemaUId = new Guid("3a622ca4-e1ea-4273-8b41-c20129310fd7"),
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39")
			};
		}

		protected virtual EntitySchemaColumn CreateRowColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3d9e1aa4-a486-4d06-ba84-1541c00327d5"),
				Name = @"Row",
				ReferenceSchemaUId = new Guid("01fb1058-f049-48ab-96fb-cbe5989efe01"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("3a622ca4-e1ea-4273-8b41-c20129310fd7"),
				ModifiedInSchemaUId = new Guid("3a622ca4-e1ea-4273-8b41-c20129310fd7"),
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39")
			};
		}

		protected virtual EntitySchemaColumn CreateForecastColumnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4f7afe87-8872-46c7-bd31-d6a74ec15319"),
				Name = @"ForecastColumn",
				ReferenceSchemaUId = new Guid("321d7bc3-45fe-41f8-af38-6643602b116d"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("3a622ca4-e1ea-4273-8b41-c20129310fd7"),
				ModifiedInSchemaUId = new Guid("3a622ca4-e1ea-4273-8b41-c20129310fd7"),
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateEntityInForecastCellEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateEntityInForecastCellEventsProcessSchema() {
			var schema = new EntityInForecastCellEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new EntityInForecastCell(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EntityInForecastCell_CoreForecastEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EntityInForecastCellSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EntityInForecastCellSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3a622ca4-e1ea-4273-8b41-c20129310fd7"));
		}

		#endregion

	}

	#endregion

	#region Class: EntityInForecastCell

	/// <summary>
	/// Forecast cell base object.
	/// </summary>
	public class EntityInForecastCell : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public EntityInForecastCell(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EntityInForecastCell";
		}

		public EntityInForecastCell(EntityInForecastCell source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid PeriodId {
			get {
				return GetTypedColumnValue<Guid>("PeriodId");
			}
			set {
				SetColumnValue("PeriodId", value);
				_period = null;
			}
		}

		/// <exclude/>
		public string PeriodName {
			get {
				return GetTypedColumnValue<string>("PeriodName");
			}
			set {
				SetColumnValue("PeriodName", value);
				if (_period != null) {
					_period.Name = value;
				}
			}
		}

		private Period _period;
		/// <summary>
		/// Period.
		/// </summary>
		public Period Period {
			get {
				return _period ??
					(_period = LookupColumnEntities.GetEntity("Period") as Period);
			}
		}

		/// <exclude/>
		public Guid SheetId {
			get {
				return GetTypedColumnValue<Guid>("SheetId");
			}
			set {
				SetColumnValue("SheetId", value);
				_sheet = null;
			}
		}

		/// <exclude/>
		public string SheetName {
			get {
				return GetTypedColumnValue<string>("SheetName");
			}
			set {
				SetColumnValue("SheetName", value);
				if (_sheet != null) {
					_sheet.Name = value;
				}
			}
		}

		private ForecastSheet _sheet;
		/// <summary>
		/// Forecast sheet.
		/// </summary>
		public ForecastSheet Sheet {
			get {
				return _sheet ??
					(_sheet = LookupColumnEntities.GetEntity("Sheet") as ForecastSheet);
			}
		}

		/// <exclude/>
		public Guid IndicatorId {
			get {
				return GetTypedColumnValue<Guid>("IndicatorId");
			}
			set {
				SetColumnValue("IndicatorId", value);
				_indicator = null;
			}
		}

		/// <exclude/>
		public string IndicatorName {
			get {
				return GetTypedColumnValue<string>("IndicatorName");
			}
			set {
				SetColumnValue("IndicatorName", value);
				if (_indicator != null) {
					_indicator.Name = value;
				}
			}
		}

		private ForecastIndicator _indicator;
		/// <summary>
		/// Forecast indicator.
		/// </summary>
		public ForecastIndicator Indicator {
			get {
				return _indicator ??
					(_indicator = LookupColumnEntities.GetEntity("Indicator") as ForecastIndicator);
			}
		}

		/// <summary>
		/// Amount.
		/// </summary>
		public Decimal Amount {
			get {
				return GetTypedColumnValue<Decimal>("Amount");
			}
			set {
				SetColumnValue("Amount", value);
			}
		}

		/// <summary>
		/// Primary amount.
		/// </summary>
		public Decimal PrimaryAmount {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryAmount");
			}
			set {
				SetColumnValue("PrimaryAmount", value);
			}
		}

		/// <exclude/>
		public Guid CurrencyId {
			get {
				return GetTypedColumnValue<Guid>("CurrencyId");
			}
			set {
				SetColumnValue("CurrencyId", value);
				_currency = null;
			}
		}

		/// <exclude/>
		public string CurrencyName {
			get {
				return GetTypedColumnValue<string>("CurrencyName");
			}
			set {
				SetColumnValue("CurrencyName", value);
				if (_currency != null) {
					_currency.Name = value;
				}
			}
		}

		private Currency _currency;
		/// <summary>
		/// Currency.
		/// </summary>
		public Currency Currency {
			get {
				return _currency ??
					(_currency = LookupColumnEntities.GetEntity("Currency") as Currency);
			}
		}

		/// <summary>
		/// Value.
		/// </summary>
		public Decimal Value {
			get {
				return GetTypedColumnValue<Decimal>("Value");
			}
			set {
				SetColumnValue("Value", value);
			}
		}

		/// <exclude/>
		public Guid RowId {
			get {
				return GetTypedColumnValue<Guid>("RowId");
			}
			set {
				SetColumnValue("RowId", value);
				_row = null;
			}
		}

		private ForecastRow _row;
		/// <summary>
		/// Row.
		/// </summary>
		public ForecastRow Row {
			get {
				return _row ??
					(_row = LookupColumnEntities.GetEntity("Row") as ForecastRow);
			}
		}

		/// <exclude/>
		public Guid ForecastColumnId {
			get {
				return GetTypedColumnValue<Guid>("ForecastColumnId");
			}
			set {
				SetColumnValue("ForecastColumnId", value);
				_forecastColumn = null;
			}
		}

		/// <exclude/>
		public string ForecastColumnTitle {
			get {
				return GetTypedColumnValue<string>("ForecastColumnTitle");
			}
			set {
				SetColumnValue("ForecastColumnTitle", value);
				if (_forecastColumn != null) {
					_forecastColumn.Title = value;
				}
			}
		}

		private ForecastColumn _forecastColumn;
		/// <summary>
		/// Forecast column.
		/// </summary>
		public ForecastColumn ForecastColumn {
			get {
				return _forecastColumn ??
					(_forecastColumn = LookupColumnEntities.GetEntity("ForecastColumn") as ForecastColumn);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EntityInForecastCell_CoreForecastEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("EntityInForecastCellInserting", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EntityInForecastCell(this);
		}

		#endregion

	}

	#endregion

	#region Class: EntityInForecastCell_CoreForecastEventsProcess

	/// <exclude/>
	public partial class EntityInForecastCell_CoreForecastEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : EntityInForecastCell
	{

		public EntityInForecastCell_CoreForecastEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EntityInForecastCell_CoreForecastEventsProcess";
			SchemaUId = new Guid("3a622ca4-e1ea-4273-8b41-c20129310fd7");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3a622ca4-e1ea-4273-8b41-c20129310fd7");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _begoreInsertingSubProcess;
		public ProcessFlowElement BegoreInsertingSubProcess {
			get {
				return _begoreInsertingSubProcess ?? (_begoreInsertingSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BegoreInsertingSubProcess",
					SchemaElementUId = new Guid("e76578f2-02c9-4bc7-96dc-1545c51fbc14"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_5f1d8c94b8a84f12b0fa9200276f8f0f;
		public ProcessFlowElement StartMessage3_5f1d8c94b8a84f12b0fa9200276f8f0f {
			get {
				return _startMessage3_5f1d8c94b8a84f12b0fa9200276f8f0f ?? (_startMessage3_5f1d8c94b8a84f12b0fa9200276f8f0f = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_5f1d8c94b8a84f12b0fa9200276f8f0f",
					SchemaElementUId = new Guid("5f1d8c94-b8a8-4f12-b0fa-9200276f8f0f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_b1b245f13a7c49c6a28245ecb0dccaf8;
		public ProcessScriptTask ScriptTask3_b1b245f13a7c49c6a28245ecb0dccaf8 {
			get {
				return _scriptTask3_b1b245f13a7c49c6a28245ecb0dccaf8 ?? (_scriptTask3_b1b245f13a7c49c6a28245ecb0dccaf8 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_b1b245f13a7c49c6a28245ecb0dccaf8",
					SchemaElementUId = new Guid("b1b245f1-3a7c-49c6-a282-45ecb0dccaf8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_b1b245f13a7c49c6a28245ecb0dccaf8Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[BegoreInsertingSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BegoreInsertingSubProcess };
			FlowElements[StartMessage3_5f1d8c94b8a84f12b0fa9200276f8f0f.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_5f1d8c94b8a84f12b0fa9200276f8f0f };
			FlowElements[ScriptTask3_b1b245f13a7c49c6a28245ecb0dccaf8.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_b1b245f13a7c49c6a28245ecb0dccaf8 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "BegoreInsertingSubProcess":
						break;
					case "StartMessage3_5f1d8c94b8a84f12b0fa9200276f8f0f":
						e.Context.QueueTasks.Enqueue("ScriptTask3_b1b245f13a7c49c6a28245ecb0dccaf8");
						break;
					case "ScriptTask3_b1b245f13a7c49c6a28245ecb0dccaf8":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_5f1d8c94b8a84f12b0fa9200276f8f0f");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "BegoreInsertingSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_5f1d8c94b8a84f12b0fa9200276f8f0f":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_5f1d8c94b8a84f12b0fa9200276f8f0f";
					result = StartMessage3_5f1d8c94b8a84f12b0fa9200276f8f0f.Execute(context);
					break;
				case "ScriptTask3_b1b245f13a7c49c6a28245ecb0dccaf8":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_b1b245f13a7c49c6a28245ecb0dccaf8";
					result = ScriptTask3_b1b245f13a7c49c6a28245ecb0dccaf8.Execute(context, ScriptTask3_b1b245f13a7c49c6a28245ecb0dccaf8Execute);
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

		public virtual bool ScriptTask3_b1b245f13a7c49c6a28245ecb0dccaf8Execute(ProcessExecutingContext context) {
			SetForecastRow();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "EntityInForecastCellInserting":
							if (ActivatedEventElements.Contains("StartMessage3_5f1d8c94b8a84f12b0fa9200276f8f0f")) {
							context.QueueTasks.Enqueue("StartMessage3_5f1d8c94b8a84f12b0fa9200276f8f0f");
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

	#region Class: EntityInForecastCell_CoreForecastEventsProcess

	/// <exclude/>
	public class EntityInForecastCell_CoreForecastEventsProcess : EntityInForecastCell_CoreForecastEventsProcess<EntityInForecastCell>
	{

		public EntityInForecastCell_CoreForecastEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EntityInForecastCellEventsProcessSchema

	/// <exclude/>
	public class EntityInForecastCellEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public EntityInForecastCellEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public EntityInForecastCellEventsProcessSchema(EntityInForecastCellEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "EntityInForecastCell_CoreForecastEventsProcess";
			UId = new Guid("1b9ceb7d-17ea-4a1b-aac0-51f3abdc8464");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet_2cc62bfcb60b4ba0ab66cf4f1d83054a = CreateLaneSet_2cc62bfcb60b4ba0ab66cf4f1d83054aLaneSet();
			LaneSets.Add(schemaLaneSet_2cc62bfcb60b4ba0ab66cf4f1d83054a);
			ProcessSchemaLane schemaLane_c69bd247e2464962876d640a81693d17 = CreateLane_c69bd247e2464962876d640a81693d17Lane();
			schemaLaneSet_2cc62bfcb60b4ba0ab66cf4f1d83054a.Lanes.Add(schemaLane_c69bd247e2464962876d640a81693d17);
			ProcessSchemaEventSubProcess begoreinsertingsubprocess = CreateBegoreInsertingSubProcessEventSubProcess();
			FlowElements.Add(begoreinsertingsubprocess);
			ProcessSchemaStartMessageEvent startmessage3_5f1d8c94b8a84f12b0fa9200276f8f0f = CreateStartMessage3_5f1d8c94b8a84f12b0fa9200276f8f0fStartMessageEvent();
			begoreinsertingsubprocess.FlowElements.Add(startmessage3_5f1d8c94b8a84f12b0fa9200276f8f0f);
			ProcessSchemaScriptTask scripttask3_b1b245f13a7c49c6a28245ecb0dccaf8 = CreateScriptTask3_b1b245f13a7c49c6a28245ecb0dccaf8ScriptTask();
			begoreinsertingsubprocess.FlowElements.Add(scripttask3_b1b245f13a7c49c6a28245ecb0dccaf8);
			FlowElements.Add(CreateSequenceFlow4_3cd14483c976467090987b2d2a904de4SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4_3cd14483c976467090987b2d2a904de4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4_3cd14483c976467090987b2d2a904de4",
				UId = new Guid("3cd14483-c976-4670-9098-7b2d2a904de4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("ac31baee-da21-4a6a-8206-cc9cad5b9385"),
				CreatedInSchemaUId = new Guid("1b9ceb7d-17ea-4a1b-aac0-51f3abdc8464"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1b9ceb7d-17ea-4a1b-aac0-51f3abdc8464"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(353, 237),
				SequenceFlowStartPointPosition = new Point(255, 237),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5f1d8c94-b8a8-4f12-b0fa-9200276f8f0f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b1b245f1-3a7c-49c6-a282-45ecb0dccaf8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet_2cc62bfcb60b4ba0ab66cf4f1d83054aLaneSet() {
			ProcessSchemaLaneSet schemaLaneSet_2cc62bfcb60b4ba0ab66cf4f1d83054a = new ProcessSchemaLaneSet(this) {
				UId = new Guid("2cc62bfc-b60b-4ba0-ab66-cf4f1d83054a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("ac31baee-da21-4a6a-8206-cc9cad5b9385"),
				CreatedInSchemaUId = new Guid("1b9ceb7d-17ea-4a1b-aac0-51f3abdc8464"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("1b9ceb7d-17ea-4a1b-aac0-51f3abdc8464"),
				Name = @"LaneSet_2cc62bfcb60b4ba0ab66cf4f1d83054a",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(0, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet_2cc62bfcb60b4ba0ab66cf4f1d83054a;
		}

		protected virtual ProcessSchemaLane CreateLane_c69bd247e2464962876d640a81693d17Lane() {
			ProcessSchemaLane schemaLane_c69bd247e2464962876d640a81693d17 = new ProcessSchemaLane(this) {
				UId = new Guid("c69bd247-e246-4962-876d-640a81693d17"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2cc62bfc-b60b-4ba0-ab66-cf4f1d83054a"),
				CreatedInOwnerSchemaUId = new Guid("1b9ceb7d-17ea-4a1b-aac0-51f3abdc8464"),
				CreatedInPackageId = new Guid("ac31baee-da21-4a6a-8206-cc9cad5b9385"),
				CreatedInSchemaUId = new Guid("1b9ceb7d-17ea-4a1b-aac0-51f3abdc8464"),
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("1b9ceb7d-17ea-4a1b-aac0-51f3abdc8464"),
				Name = @"Lane_c69bd247e2464962876d640a81693d17",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane_c69bd247e2464962876d640a81693d17;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBegoreInsertingSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBegoreInsertingSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e76578f2-02c9-4bc7-96dc-1545c51fbc14"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c69bd247-e246-4962-876d-640a81693d17"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("ac31baee-da21-4a6a-8206-cc9cad5b9385"),
				CreatedInSchemaUId = new Guid("1b9ceb7d-17ea-4a1b-aac0-51f3abdc8464"),
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1b9ceb7d-17ea-4a1b-aac0-51f3abdc8464"),
				Name = @"BegoreInsertingSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(204, 86),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 300),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBegoreInsertingSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3_5f1d8c94b8a84f12b0fa9200276f8f0fStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5f1d8c94-b8a8-4f12-b0fa-9200276f8f0f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e76578f2-02c9-4bc7-96dc-1545c51fbc14"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("ac31baee-da21-4a6a-8206-cc9cad5b9385"),
				CreatedInSchemaUId = new Guid("1b9ceb7d-17ea-4a1b-aac0-51f3abdc8464"),
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EntityInForecastCellInserting",
				ModifiedInSchemaUId = new Guid("1b9ceb7d-17ea-4a1b-aac0-51f3abdc8464"),
				Name = @"StartMessage3_5f1d8c94b8a84f12b0fa9200276f8f0f",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 135),
				SerializeToDB = false,
				Size = new Size(31, 31),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3_b1b245f13a7c49c6a28245ecb0dccaf8ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b1b245f1-3a7c-49c6-a282-45ecb0dccaf8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e76578f2-02c9-4bc7-96dc-1545c51fbc14"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("ac31baee-da21-4a6a-8206-cc9cad5b9385"),
				CreatedInSchemaUId = new Guid("1b9ceb7d-17ea-4a1b-aac0-51f3abdc8464"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1b9ceb7d-17ea-4a1b-aac0-51f3abdc8464"),
				Name = @"ScriptTask3_b1b245f13a7c49c6a28245ecb0dccaf8",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(149, 123),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = true,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,113,203,47,74,77,78,44,46,9,202,47,215,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,175,188,219,199,31,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d5bb3512-71e0-482a-9c7e-16bf22c586b7"),
				Name = "Terrasoft.Nui.ServiceModel.DataContract",
				Alias = "DataContract",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b261d1c9-cc98-44e8-aabd-7806d1dc26ed"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c261d1c9-cc98-44e8-aabd-7806d1dc26ec"),
				Name = "Terrasoft.Core.DcmProcess",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aca2294b-e209-4c40-9400-0d59d9ecd1ea"),
				Name = "Terrasoft.GlobalSearch.Indexing",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5410f06b-83f8-43fa-bc49-82a2dd508d3c"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EntityInForecastCellEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1b9ceb7d-17ea-4a1b-aac0-51f3abdc8464"));
		}

		#endregion

	}

	#endregion


	#region Class: EntityInForecastCellEventsProcess

	/// <exclude/>
	public class EntityInForecastCellEventsProcess : EntityInForecastCell_CoreForecastEventsProcess
	{

		public EntityInForecastCellEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

