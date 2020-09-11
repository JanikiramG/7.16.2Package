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

	#region Class: QualifyStatus_Lead_TerrasoftSchema

	/// <exclude/>
	public class QualifyStatus_Lead_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public QualifyStatus_Lead_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public QualifyStatus_Lead_TerrasoftSchema(QualifyStatus_Lead_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public QualifyStatus_Lead_TerrasoftSchema(QualifyStatus_Lead_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44");
			RealUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44");
			Name = "QualifyStatus_Lead_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("c3cce05b-84ce-4d10-ad34-8d9cc9a35abf")) == null) {
				Columns.Add(CreateStageNumberColumn());
			}
			if (Columns.FindByUId(new Guid("f83ff4ec-8cda-4067-9262-b71bc587746d")) == null) {
				Columns.Add(CreateColorColumn());
			}
			if (Columns.FindByUId(new Guid("c4e29fea-f73c-4780-91c1-995285f7397a")) == null) {
				Columns.Add(CreateIsDisplayedColumn());
			}
			if (Columns.FindByUId(new Guid("eb37a354-ec7b-4077-a79d-5ff3cc521b99")) == null) {
				Columns.Add(CreateStageOrderColumn());
			}
			if (Columns.FindByUId(new Guid("58c481ee-ed40-4e89-98a1-11ce7d3bdff3")) == null) {
				Columns.Add(CreateStageInnerOrderColumn());
			}
			if (Columns.FindByUId(new Guid("b40801fd-7858-4a95-8d35-0fee83285cb2")) == null) {
				Columns.Add(CreateIsFinalColumn());
			}
			if (Columns.FindByUId(new Guid("db9586bb-31b8-4078-a1fc-2d0588c294ac")) == null) {
				Columns.Add(CreateSuccessfulColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44");
			column.CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44");
			column.CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44");
			column.CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44");
			column.CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44");
			column.CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44");
			column.CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44");
			column.CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44");
			column.CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5");
			return column;
		}

		protected virtual EntitySchemaColumn CreateStageNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("c3cce05b-84ce-4d10-ad34-8d9cc9a35abf"),
				Name = @"StageNumber",
				CreatedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				CreatedInPackageId = new Guid("af77c4b2-f9ec-497f-9388-8112501477da")
			};
		}

		protected virtual EntitySchemaColumn CreateColorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("f83ff4ec-8cda-4067-9262-b71bc587746d"),
				Name = @"Color",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				CreatedInPackageId = new Guid("1a7afc7f-95ec-4933-ad5b-fbf6e891e557")
			};
		}

		protected virtual EntitySchemaColumn CreateIsDisplayedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("c4e29fea-f73c-4780-91c1-995285f7397a"),
				Name = @"IsDisplayed",
				CreatedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				CreatedInPackageId = new Guid("1a7afc7f-95ec-4933-ad5b-fbf6e891e557")
			};
		}

		protected virtual EntitySchemaColumn CreateStageOrderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("eb37a354-ec7b-4077-a79d-5ff3cc521b99"),
				Name = @"StageOrder",
				CreatedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				CreatedInPackageId = new Guid("1a7afc7f-95ec-4933-ad5b-fbf6e891e557")
			};
		}

		protected virtual EntitySchemaColumn CreateStageInnerOrderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("58c481ee-ed40-4e89-98a1-11ce7d3bdff3"),
				Name = @"StageInnerOrder",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				CreatedInPackageId = new Guid("1a7afc7f-95ec-4933-ad5b-fbf6e891e557")
			};
		}

		protected virtual EntitySchemaColumn CreateIsFinalColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("b40801fd-7858-4a95-8d35-0fee83285cb2"),
				Name = @"IsFinal",
				CreatedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				CreatedInPackageId = new Guid("ffff327e-8320-4d3b-80f3-cd12dd0dbcc4")
			};
		}

		protected virtual EntitySchemaColumn CreateSuccessfulColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("db9586bb-31b8-4078-a1fc-2d0588c294ac"),
				Name = @"Successful",
				CreatedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateQualifyStatus_Lead_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateQualifyStatus_Lead_TerrasoftEventsProcessSchema() {
			var schema = new QualifyStatus_Lead_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new QualifyStatus_Lead_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new QualifyStatus_LeadEventsProcess(userConnection);
		}

		public override object Clone() {
			return new QualifyStatus_Lead_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new QualifyStatus_Lead_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"));
		}

		#endregion

	}

	#endregion

	#region Class: QualifyStatus_Lead_Terrasoft

	/// <summary>
	/// Lead stage.
	/// </summary>
	public class QualifyStatus_Lead_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public QualifyStatus_Lead_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "QualifyStatus_Lead_Terrasoft";
		}

		public QualifyStatus_Lead_Terrasoft(QualifyStatus_Lead_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Stage number.
		/// </summary>
		public int StageNumber {
			get {
				return GetTypedColumnValue<int>("StageNumber");
			}
			set {
				SetColumnValue("StageNumber", value);
			}
		}

		/// <summary>
		/// Color.
		/// </summary>
		public string Color {
			get {
				return GetTypedColumnValue<string>("Color");
			}
			set {
				SetColumnValue("Color", value);
			}
		}

		/// <summary>
		/// Display in Workflow Bar.
		/// </summary>
		public bool IsDisplayed {
			get {
				return GetTypedColumnValue<bool>("IsDisplayed");
			}
			set {
				SetColumnValue("IsDisplayed", value);
			}
		}

		/// <summary>
		/// Primary order in Workflow Bar.
		/// </summary>
		public int StageOrder {
			get {
				return GetTypedColumnValue<int>("StageOrder");
			}
			set {
				SetColumnValue("StageOrder", value);
			}
		}

		/// <summary>
		/// Secondary order in Workflow Bar.
		/// </summary>
		public int StageInnerOrder {
			get {
				return GetTypedColumnValue<int>("StageInnerOrder");
			}
			set {
				SetColumnValue("StageInnerOrder", value);
			}
		}

		/// <summary>
		/// Is final.
		/// </summary>
		public bool IsFinal {
			get {
				return GetTypedColumnValue<bool>("IsFinal");
			}
			set {
				SetColumnValue("IsFinal", value);
			}
		}

		/// <summary>
		/// Successful.
		/// </summary>
		public bool Successful {
			get {
				return GetTypedColumnValue<bool>("Successful");
			}
			set {
				SetColumnValue("Successful", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new QualifyStatus_LeadEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("QualifyStatus_Lead_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("QualifyStatus_Lead_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("QualifyStatus_Lead_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new QualifyStatus_Lead_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: QualifyStatus_LeadEventsProcess

	/// <exclude/>
	public partial class QualifyStatus_LeadEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : QualifyStatus_Lead_Terrasoft
	{

		public QualifyStatus_LeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "QualifyStatus_LeadEventsProcess";
			SchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44");
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

	#region Class: QualifyStatus_LeadEventsProcess

	/// <exclude/>
	public class QualifyStatus_LeadEventsProcess : QualifyStatus_LeadEventsProcess<QualifyStatus_Lead_Terrasoft>
	{

		public QualifyStatus_LeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: QualifyStatus_LeadEventsProcess

	public partial class QualifyStatus_LeadEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: QualifyStatus_Lead_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class QualifyStatus_Lead_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public QualifyStatus_Lead_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public QualifyStatus_Lead_TerrasoftEventsProcessSchema(QualifyStatus_Lead_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "QualifyStatus_LeadEventsProcess";
			UId = new Guid("522c5349-1e0a-43c1-9cbc-7b12cb01c134");
			CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1");
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
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5")
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
			return new QualifyStatus_Lead_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("522c5349-1e0a-43c1-9cbc-7b12cb01c134"));
		}

		#endregion

	}

	#endregion

}

