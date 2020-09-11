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

	#region Class: ForecastSheetSchema

	/// <exclude/>
	public class ForecastSheetSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ForecastSheetSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ForecastSheetSchema(ForecastSheetSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ForecastSheetSchema(ForecastSheetSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f97c7d7a-e614-4850-8ec4-98d8af22b3d0");
			RealUId = new Guid("f97c7d7a-e614-4850-8ec4-98d8af22b3d0");
			Name = "ForecastSheet";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b1851766-fc4e-478a-a7fc-b25a5c9c25b7")) == null) {
				Columns.Add(CreatePeriodTypeColumn());
			}
			if (Columns.FindByUId(new Guid("495329fc-5ca5-46b5-9dc1-68587bf681c1")) == null) {
				Columns.Add(CreateForecastEntityColumn());
			}
			if (Columns.FindByUId(new Guid("0393df71-4fb9-4678-9514-fffafa34225c")) == null) {
				Columns.Add(CreateForecastEntityInCellUIdColumn());
			}
			if (Columns.FindByUId(new Guid("0e84188f-0eb2-49e1-879c-582f2db767f3")) == null) {
				Columns.Add(CreateSettingColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("f502f4f8-f2e1-49ee-8768-8b93f970867c"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("f97c7d7a-e614-4850-8ec4-98d8af22b3d0"),
				ModifiedInSchemaUId = new Guid("f97c7d7a-e614-4850-8ec4-98d8af22b3d0"),
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreatePeriodTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b1851766-fc4e-478a-a7fc-b25a5c9c25b7"),
				Name = @"PeriodType",
				ReferenceSchemaUId = new Guid("3608a0e4-0235-4936-9c0e-99620e73940c"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f97c7d7a-e614-4850-8ec4-98d8af22b3d0"),
				ModifiedInSchemaUId = new Guid("f97c7d7a-e614-4850-8ec4-98d8af22b3d0"),
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39")
			};
		}

		protected virtual EntitySchemaColumn CreateForecastEntityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("495329fc-5ca5-46b5-9dc1-68587bf681c1"),
				Name = @"ForecastEntity",
				ReferenceSchemaUId = new Guid("c82db13a-7f77-4085-b3ef-91c5420fd417"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("f97c7d7a-e614-4850-8ec4-98d8af22b3d0"),
				ModifiedInSchemaUId = new Guid("f97c7d7a-e614-4850-8ec4-98d8af22b3d0"),
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39")
			};
		}

		protected virtual EntitySchemaColumn CreateForecastEntityInCellUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("0393df71-4fb9-4678-9514-fffafa34225c"),
				Name = @"ForecastEntityInCellUId",
				CreatedInSchemaUId = new Guid("f97c7d7a-e614-4850-8ec4-98d8af22b3d0"),
				ModifiedInSchemaUId = new Guid("f97c7d7a-e614-4850-8ec4-98d8af22b3d0"),
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39")
			};
		}

		protected virtual EntitySchemaColumn CreateSettingColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("0e84188f-0eb2-49e1-879c-582f2db767f3"),
				Name = @"Setting",
				CreatedInSchemaUId = new Guid("f97c7d7a-e614-4850-8ec4-98d8af22b3d0"),
				ModifiedInSchemaUId = new Guid("f97c7d7a-e614-4850-8ec4-98d8af22b3d0"),
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateForecastSheetEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateForecastSheetEventsProcessSchema() {
			var schema = new ForecastSheetEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ForecastSheet(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ForecastSheet_CoreForecastEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ForecastSheetSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ForecastSheetSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f97c7d7a-e614-4850-8ec4-98d8af22b3d0"));
		}

		#endregion

	}

	#endregion

	#region Class: ForecastSheet

	/// <summary>
	/// Forecast sheet.
	/// </summary>
	public class ForecastSheet : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ForecastSheet(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ForecastSheet";
		}

		public ForecastSheet(ForecastSheet source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <exclude/>
		public Guid PeriodTypeId {
			get {
				return GetTypedColumnValue<Guid>("PeriodTypeId");
			}
			set {
				SetColumnValue("PeriodTypeId", value);
				_periodType = null;
			}
		}

		/// <exclude/>
		public string PeriodTypeName {
			get {
				return GetTypedColumnValue<string>("PeriodTypeName");
			}
			set {
				SetColumnValue("PeriodTypeName", value);
				if (_periodType != null) {
					_periodType.Name = value;
				}
			}
		}

		private PeriodType _periodType;
		/// <summary>
		/// Period type.
		/// </summary>
		public PeriodType PeriodType {
			get {
				return _periodType ??
					(_periodType = LookupColumnEntities.GetEntity("PeriodType") as PeriodType);
			}
		}

		/// <exclude/>
		public Guid ForecastEntityId {
			get {
				return GetTypedColumnValue<Guid>("ForecastEntityId");
			}
			set {
				SetColumnValue("ForecastEntityId", value);
				_forecastEntity = null;
			}
		}

		/// <exclude/>
		public string ForecastEntityTitle {
			get {
				return GetTypedColumnValue<string>("ForecastEntityTitle");
			}
			set {
				SetColumnValue("ForecastEntityTitle", value);
				if (_forecastEntity != null) {
					_forecastEntity.Title = value;
				}
			}
		}

		private VwEntityObjects _forecastEntity;
		/// <summary>
		/// Forecast entity.
		/// </summary>
		public VwEntityObjects ForecastEntity {
			get {
				return _forecastEntity ??
					(_forecastEntity = LookupColumnEntities.GetEntity("ForecastEntity") as VwEntityObjects);
			}
		}

		/// <summary>
		/// UId of schema that contains forecast data.
		/// </summary>
		public Guid ForecastEntityInCellUId {
			get {
				return GetTypedColumnValue<Guid>("ForecastEntityInCellUId");
			}
			set {
				SetColumnValue("ForecastEntityInCellUId", value);
			}
		}

		/// <summary>
		/// Forecast setting.
		/// </summary>
		public string Setting {
			get {
				return GetTypedColumnValue<string>("Setting");
			}
			set {
				SetColumnValue("Setting", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ForecastSheet_CoreForecastEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ForecastSheet(this);
		}

		#endregion

	}

	#endregion

	#region Class: ForecastSheet_CoreForecastEventsProcess

	/// <exclude/>
	public partial class ForecastSheet_CoreForecastEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ForecastSheet
	{

		public ForecastSheet_CoreForecastEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ForecastSheet_CoreForecastEventsProcess";
			SchemaUId = new Guid("f97c7d7a-e614-4850-8ec4-98d8af22b3d0");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f97c7d7a-e614-4850-8ec4-98d8af22b3d0");
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

	#region Class: ForecastSheet_CoreForecastEventsProcess

	/// <exclude/>
	public class ForecastSheet_CoreForecastEventsProcess : ForecastSheet_CoreForecastEventsProcess<ForecastSheet>
	{

		public ForecastSheet_CoreForecastEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ForecastSheet_CoreForecastEventsProcess

	public partial class ForecastSheet_CoreForecastEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ForecastSheetEventsProcessSchema

	/// <exclude/>
	public class ForecastSheetEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ForecastSheetEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ForecastSheetEventsProcessSchema(ForecastSheetEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ForecastSheet_CoreForecastEventsProcess";
			UId = new Guid("2be6862f-5cae-4e51-b2ab-686a0ae7195e");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
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
			return new ForecastSheetEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2be6862f-5cae-4e51-b2ab-686a0ae7195e"));
		}

		#endregion

	}

	#endregion


	#region Class: ForecastSheetEventsProcess

	/// <exclude/>
	public class ForecastSheetEventsProcess : ForecastSheet_CoreForecastEventsProcess
	{

		public ForecastSheetEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

