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

	#region Class: CompletenessParameterSchema

	/// <exclude/>
	public class CompletenessParameterSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public CompletenessParameterSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CompletenessParameterSchema(CompletenessParameterSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CompletenessParameterSchema(CompletenessParameterSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af");
			RealUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af");
			Name = "CompletenessParameter";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("c7634d9a-901d-4a66-9f11-34c80c5250ce");
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
			if (Columns.FindByUId(new Guid("cd516d07-f502-4606-ac54-c721b5fd7f2d")) == null) {
				Columns.Add(CreateCompletenessColumn());
			}
			if (Columns.FindByUId(new Guid("e045700a-4d46-4394-bf48-9c044ae2d565")) == null) {
				Columns.Add(CreateAttributeIdColumn());
			}
			if (Columns.FindByUId(new Guid("0fe2a233-d221-4849-b2b0-c6a229dc58d0")) == null) {
				Columns.Add(CreatePercentageColumn());
			}
			if (Columns.FindByUId(new Guid("0029abe7-0fe0-4eaa-aae4-bb9b84fc0e0e")) == null) {
				Columns.Add(CreateIsColumnColumn());
			}
			if (Columns.FindByUId(new Guid("9e8282cb-eecd-48be-ad1c-8306e07ddf06")) == null) {
				Columns.Add(CreateIsDetailColumn());
			}
			if (Columns.FindByUId(new Guid("90b4a00c-7d86-4be9-95da-6ac1ecd7331c")) == null) {
				Columns.Add(CreateColumnNameColumn());
			}
			if (Columns.FindByUId(new Guid("d681fa67-895c-43cb-958a-79db23f0a56a")) == null) {
				Columns.Add(CreateDetailEntityNameColumn());
			}
			if (Columns.FindByUId(new Guid("93aca6cc-e550-49c8-ae3c-4a04f7c23b54")) == null) {
				Columns.Add(CreateDetailColumnColumn());
			}
			if (Columns.FindByUId(new Guid("22a62cf0-73bb-46d3-bf48-7a1196f8b8d0")) == null) {
				Columns.Add(CreateMasterColumnColumn());
			}
			if (Columns.FindByUId(new Guid("120f702e-9f04-4d90-adeb-4650888893a9")) == null) {
				Columns.Add(CreateTypeColumnColumn());
			}
			if (Columns.FindByUId(new Guid("1091fbaf-5122-40b1-b2f1-832f82969070")) == null) {
				Columns.Add(CreateTypeValueColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCompletenessColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("cd516d07-f502-4606-ac54-c721b5fd7f2d"),
				Name = @"Completeness",
				ReferenceSchemaUId = new Guid("ebed4408-f780-4a36-9e21-68c7e20c04e0"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"),
				ModifiedInSchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"),
				CreatedInPackageId = new Guid("c7634d9a-901d-4a66-9f11-34c80c5250ce")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("ce1827f9-db39-4ae9-bf8d-a389242bf4b7"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"),
				ModifiedInSchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"),
				CreatedInPackageId = new Guid("c7634d9a-901d-4a66-9f11-34c80c5250ce"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateAttributeIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("e045700a-4d46-4394-bf48-9c044ae2d565"),
				Name = @"AttributeId",
				CreatedInSchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"),
				ModifiedInSchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"),
				CreatedInPackageId = new Guid("37401b15-d755-4de2-9a31-d493a123233f")
			};
		}

		protected virtual EntitySchemaColumn CreatePercentageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("0fe2a233-d221-4849-b2b0-c6a229dc58d0"),
				Name = @"Percentage",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"),
				ModifiedInSchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"),
				CreatedInPackageId = new Guid("c7634d9a-901d-4a66-9f11-34c80c5250ce"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"0"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateIsColumnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("0029abe7-0fe0-4eaa-aae4-bb9b84fc0e0e"),
				Name = @"IsColumn",
				CreatedInSchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"),
				ModifiedInSchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"),
				CreatedInPackageId = new Guid("c7634d9a-901d-4a66-9f11-34c80c5250ce")
			};
		}

		protected virtual EntitySchemaColumn CreateIsDetailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("9e8282cb-eecd-48be-ad1c-8306e07ddf06"),
				Name = @"IsDetail",
				CreatedInSchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"),
				ModifiedInSchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"),
				CreatedInPackageId = new Guid("c7634d9a-901d-4a66-9f11-34c80c5250ce")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("90b4a00c-7d86-4be9-95da-6ac1ecd7331c"),
				Name = @"ColumnName",
				CreatedInSchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"),
				ModifiedInSchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"),
				CreatedInPackageId = new Guid("c7634d9a-901d-4a66-9f11-34c80c5250ce")
			};
		}

		protected virtual EntitySchemaColumn CreateDetailEntityNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("d681fa67-895c-43cb-958a-79db23f0a56a"),
				Name = @"DetailEntityName",
				CreatedInSchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"),
				ModifiedInSchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"),
				CreatedInPackageId = new Guid("c7634d9a-901d-4a66-9f11-34c80c5250ce")
			};
		}

		protected virtual EntitySchemaColumn CreateDetailColumnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("93aca6cc-e550-49c8-ae3c-4a04f7c23b54"),
				Name = @"DetailColumn",
				CreatedInSchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"),
				ModifiedInSchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"),
				CreatedInPackageId = new Guid("37401b15-d755-4de2-9a31-d493a123233f")
			};
		}

		protected virtual EntitySchemaColumn CreateMasterColumnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("22a62cf0-73bb-46d3-bf48-7a1196f8b8d0"),
				Name = @"MasterColumn",
				CreatedInSchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"),
				ModifiedInSchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"),
				CreatedInPackageId = new Guid("37401b15-d755-4de2-9a31-d493a123233f")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("120f702e-9f04-4d90-adeb-4650888893a9"),
				Name = @"TypeColumn",
				CreatedInSchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"),
				ModifiedInSchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"),
				CreatedInPackageId = new Guid("37401b15-d755-4de2-9a31-d493a123233f")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("1091fbaf-5122-40b1-b2f1-832f82969070"),
				Name = @"TypeValue",
				CreatedInSchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"),
				ModifiedInSchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"),
				CreatedInPackageId = new Guid("37401b15-d755-4de2-9a31-d493a123233f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCompletenessParameterEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCompletenessParameterEventsProcessSchema() {
			var schema = new CompletenessParameterEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CompletenessParameter(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CompletenessParameter_CompletenessEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CompletenessParameterSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CompletenessParameterSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af"));
		}

		#endregion

	}

	#endregion

	#region Class: CompletenessParameter

	/// <summary>
	/// Data entry compliance parameter.
	/// </summary>
	public class CompletenessParameter : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public CompletenessParameter(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CompletenessParameter";
		}

		public CompletenessParameter(CompletenessParameter source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid CompletenessId {
			get {
				return GetTypedColumnValue<Guid>("CompletenessId");
			}
			set {
				SetColumnValue("CompletenessId", value);
				_completeness = null;
			}
		}

		/// <exclude/>
		public string CompletenessName {
			get {
				return GetTypedColumnValue<string>("CompletenessName");
			}
			set {
				SetColumnValue("CompletenessName", value);
				if (_completeness != null) {
					_completeness.Name = value;
				}
			}
		}

		private Completeness _completeness;
		/// <summary>
		/// Data entry compliance.
		/// </summary>
		public Completeness Completeness {
			get {
				return _completeness ??
					(_completeness = LookupColumnEntities.GetEntity("Completeness") as Completeness);
			}
		}

		/// <summary>
		/// Attribute name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <summary>
		/// Attribute Id.
		/// </summary>
		public Guid AttributeId {
			get {
				return GetTypedColumnValue<Guid>("AttributeId");
			}
			set {
				SetColumnValue("AttributeId", value);
			}
		}

		/// <summary>
		/// Data population percentage, %.
		/// </summary>
		public int Percentage {
			get {
				return GetTypedColumnValue<int>("Percentage");
			}
			set {
				SetColumnValue("Percentage", value);
			}
		}

		/// <summary>
		/// Column usage option.
		/// </summary>
		public bool IsColumn {
			get {
				return GetTypedColumnValue<bool>("IsColumn");
			}
			set {
				SetColumnValue("IsColumn", value);
			}
		}

		/// <summary>
		/// Detail usage option.
		/// </summary>
		public bool IsDetail {
			get {
				return GetTypedColumnValue<bool>("IsDetail");
			}
			set {
				SetColumnValue("IsDetail", value);
			}
		}

		/// <summary>
		/// Column name.
		/// </summary>
		public string ColumnName {
			get {
				return GetTypedColumnValue<string>("ColumnName");
			}
			set {
				SetColumnValue("ColumnName", value);
			}
		}

		/// <summary>
		/// Object column name.
		/// </summary>
		public string DetailEntityName {
			get {
				return GetTypedColumnValue<string>("DetailEntityName");
			}
			set {
				SetColumnValue("DetailEntityName", value);
			}
		}

		/// <summary>
		/// Detail column name.
		/// </summary>
		public string DetailColumn {
			get {
				return GetTypedColumnValue<string>("DetailColumn");
			}
			set {
				SetColumnValue("DetailColumn", value);
			}
		}

		/// <summary>
		/// Detail column wizard.
		/// </summary>
		public string MasterColumn {
			get {
				return GetTypedColumnValue<string>("MasterColumn");
			}
			set {
				SetColumnValue("MasterColumn", value);
			}
		}

		/// <summary>
		/// Column name with detail type.
		/// </summary>
		public string TypeColumn {
			get {
				return GetTypedColumnValue<string>("TypeColumn");
			}
			set {
				SetColumnValue("TypeColumn", value);
			}
		}

		/// <summary>
		/// Type column value.
		/// </summary>
		public Guid TypeValue {
			get {
				return GetTypedColumnValue<Guid>("TypeValue");
			}
			set {
				SetColumnValue("TypeValue", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CompletenessParameter_CompletenessEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CompletenessParameterDeleted", e);
			Validating += (s, e) => ThrowEvent("CompletenessParameterValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CompletenessParameter(this);
		}

		#endregion

	}

	#endregion

	#region Class: CompletenessParameter_CompletenessEventsProcess

	/// <exclude/>
	public partial class CompletenessParameter_CompletenessEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : CompletenessParameter
	{

		public CompletenessParameter_CompletenessEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CompletenessParameter_CompletenessEventsProcess";
			SchemaUId = new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2f64722b-a049-4e96-a95e-53b7f2b054af");
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

	#region Class: CompletenessParameter_CompletenessEventsProcess

	/// <exclude/>
	public class CompletenessParameter_CompletenessEventsProcess : CompletenessParameter_CompletenessEventsProcess<CompletenessParameter>
	{

		public CompletenessParameter_CompletenessEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CompletenessParameter_CompletenessEventsProcess

	public partial class CompletenessParameter_CompletenessEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: CompletenessParameterEventsProcessSchema

	/// <exclude/>
	public class CompletenessParameterEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public CompletenessParameterEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CompletenessParameterEventsProcessSchema(CompletenessParameterEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CompletenessParameter_CompletenessEventsProcess";
			UId = new Guid("77c16a33-c921-4031-9d43-a9e6265a097d");
			CreatedInPackageId = new Guid("c7634d9a-901d-4a66-9f11-34c80c5250ce");
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
			return new CompletenessParameterEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("77c16a33-c921-4031-9d43-a9e6265a097d"));
		}

		#endregion

	}

	#endregion


	#region Class: CompletenessParameterEventsProcess

	/// <exclude/>
	public class CompletenessParameterEventsProcess : CompletenessParameter_CompletenessEventsProcess
	{

		public CompletenessParameterEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

