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

	#region Class: WorkingTimeInterval_Calendar_TerrasoftSchema

	/// <exclude/>
	public class WorkingTimeInterval_Calendar_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public WorkingTimeInterval_Calendar_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public WorkingTimeInterval_Calendar_TerrasoftSchema(WorkingTimeInterval_Calendar_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public WorkingTimeInterval_Calendar_TerrasoftSchema(WorkingTimeInterval_Calendar_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3c971b13-45b1-49f4-af05-db8566668def");
			RealUId = new Guid("3c971b13-45b1-49f4-af05-db8566668def");
			Name = "WorkingTimeInterval_Calendar_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("1cca11f5-a9a8-4121-948c-9440212c73d5")) == null) {
				Columns.Add(CreateDayInCalendarColumn());
			}
			if (Columns.FindByUId(new Guid("d5043099-3e07-4aaf-9cf4-3faad2243c72")) == null) {
				Columns.Add(CreateFromColumn());
			}
			if (Columns.FindByUId(new Guid("45d1db09-15c2-47f6-b437-2ed41d7c1e61")) == null) {
				Columns.Add(CreateToColumn());
			}
			if (Columns.FindByUId(new Guid("1649e728-2418-4a49-b71d-556593140c7e")) == null) {
				Columns.Add(CreateIndexColumn());
			}
			if (Columns.FindByUId(new Guid("e669ecc9-ac38-4001-a477-92777c072f08")) == null) {
				Columns.Add(CreateDayOffColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("3c971b13-45b1-49f4-af05-db8566668def");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("3c971b13-45b1-49f4-af05-db8566668def");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("3c971b13-45b1-49f4-af05-db8566668def");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("3c971b13-45b1-49f4-af05-db8566668def");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("3c971b13-45b1-49f4-af05-db8566668def");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("3c971b13-45b1-49f4-af05-db8566668def");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected virtual EntitySchemaColumn CreateDayInCalendarColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1cca11f5-a9a8-4121-948c-9440212c73d5"),
				Name = @"DayInCalendar",
				ReferenceSchemaUId = new Guid("13665ad9-ac50-479b-b43c-765d03988626"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("3c971b13-45b1-49f4-af05-db8566668def"),
				ModifiedInSchemaUId = new Guid("3c971b13-45b1-49f4-af05-db8566668def"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			};
		}

		protected virtual EntitySchemaColumn CreateFromColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Time")) {
				UId = new Guid("d5043099-3e07-4aaf-9cf4-3faad2243c72"),
				Name = @"From",
				CreatedInSchemaUId = new Guid("3c971b13-45b1-49f4-af05-db8566668def"),
				ModifiedInSchemaUId = new Guid("3c971b13-45b1-49f4-af05-db8566668def"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			};
		}

		protected virtual EntitySchemaColumn CreateToColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Time")) {
				UId = new Guid("45d1db09-15c2-47f6-b437-2ed41d7c1e61"),
				Name = @"To",
				CreatedInSchemaUId = new Guid("3c971b13-45b1-49f4-af05-db8566668def"),
				ModifiedInSchemaUId = new Guid("3c971b13-45b1-49f4-af05-db8566668def"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			};
		}

		protected virtual EntitySchemaColumn CreateIndexColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("1649e728-2418-4a49-b71d-556593140c7e"),
				Name = @"Index",
				CreatedInSchemaUId = new Guid("3c971b13-45b1-49f4-af05-db8566668def"),
				ModifiedInSchemaUId = new Guid("3c971b13-45b1-49f4-af05-db8566668def"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			};
		}

		protected virtual EntitySchemaColumn CreateDayOffColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e669ecc9-ac38-4001-a477-92777c072f08"),
				Name = @"DayOff",
				ReferenceSchemaUId = new Guid("77bd6a64-4931-4aeb-b124-5cdee0325c8a"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("3c971b13-45b1-49f4-af05-db8566668def"),
				ModifiedInSchemaUId = new Guid("3c971b13-45b1-49f4-af05-db8566668def"),
				CreatedInPackageId = new Guid("d2179f89-6a33-4745-96ee-fd30f06a5c1f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateWorkingTimeInterval_Calendar_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateWorkingTimeInterval_Calendar_TerrasoftEventsProcessSchema() {
			var schema = new WorkingTimeInterval_Calendar_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new WorkingTimeInterval_Calendar_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new WorkingTimeInterval_CalendarEventsProcess(userConnection);
		}

		public override object Clone() {
			return new WorkingTimeInterval_Calendar_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new WorkingTimeInterval_Calendar_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3c971b13-45b1-49f4-af05-db8566668def"));
		}

		#endregion

	}

	#endregion

	#region Class: WorkingTimeInterval_Calendar_Terrasoft

	/// <summary>
	/// Working time intervals.
	/// </summary>
	public class WorkingTimeInterval_Calendar_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public WorkingTimeInterval_Calendar_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "WorkingTimeInterval_Calendar_Terrasoft";
		}

		public WorkingTimeInterval_Calendar_Terrasoft(WorkingTimeInterval_Calendar_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid DayInCalendarId {
			get {
				return GetTypedColumnValue<Guid>("DayInCalendarId");
			}
			set {
				SetColumnValue("DayInCalendarId", value);
				_dayInCalendar = null;
			}
		}

		private DayInCalendar _dayInCalendar;
		/// <summary>
		/// Day in calendar.
		/// </summary>
		public DayInCalendar DayInCalendar {
			get {
				return _dayInCalendar ??
					(_dayInCalendar = LookupColumnEntities.GetEntity("DayInCalendar") as DayInCalendar);
			}
		}

		/// <summary>
		/// from.
		/// </summary>
		public DateTime From {
			get {
				return GetTypedColumnValue<DateTime>("From");
			}
			set {
				SetColumnValue("From", value);
			}
		}

		/// <summary>
		/// till.
		/// </summary>
		public DateTime To {
			get {
				return GetTypedColumnValue<DateTime>("To");
			}
			set {
				SetColumnValue("To", value);
			}
		}

		/// <summary>
		/// Index.
		/// </summary>
		public int Index {
			get {
				return GetTypedColumnValue<int>("Index");
			}
			set {
				SetColumnValue("Index", value);
			}
		}

		/// <exclude/>
		public Guid DayOffId {
			get {
				return GetTypedColumnValue<Guid>("DayOffId");
			}
			set {
				SetColumnValue("DayOffId", value);
				_dayOff = null;
			}
		}

		private DayOff _dayOff;
		/// <summary>
		/// Day off.
		/// </summary>
		public DayOff DayOff {
			get {
				return _dayOff ??
					(_dayOff = LookupColumnEntities.GetEntity("DayOff") as DayOff);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new WorkingTimeInterval_CalendarEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("WorkingTimeInterval_Calendar_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("WorkingTimeInterval_Calendar_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("WorkingTimeInterval_Calendar_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new WorkingTimeInterval_Calendar_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: WorkingTimeInterval_CalendarEventsProcess

	/// <exclude/>
	public partial class WorkingTimeInterval_CalendarEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : WorkingTimeInterval_Calendar_Terrasoft
	{

		public WorkingTimeInterval_CalendarEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "WorkingTimeInterval_CalendarEventsProcess";
			SchemaUId = new Guid("3c971b13-45b1-49f4-af05-db8566668def");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3c971b13-45b1-49f4-af05-db8566668def");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
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

	#region Class: WorkingTimeInterval_CalendarEventsProcess

	/// <exclude/>
	public class WorkingTimeInterval_CalendarEventsProcess : WorkingTimeInterval_CalendarEventsProcess<WorkingTimeInterval_Calendar_Terrasoft>
	{

		public WorkingTimeInterval_CalendarEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: WorkingTimeInterval_CalendarEventsProcess

	public partial class WorkingTimeInterval_CalendarEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: WorkingTimeInterval_Calendar_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class WorkingTimeInterval_Calendar_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public WorkingTimeInterval_Calendar_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public WorkingTimeInterval_Calendar_TerrasoftEventsProcessSchema(WorkingTimeInterval_Calendar_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "WorkingTimeInterval_CalendarEventsProcess";
			UId = new Guid("988d02f5-ce76-4ad3-8470-d8e50aca4cbe");
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
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
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
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
			return new WorkingTimeInterval_Calendar_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("988d02f5-ce76-4ad3-8470-d8e50aca4cbe"));
		}

		#endregion

	}

	#endregion

}

