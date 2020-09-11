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

	#region Class: LandingLeadDefaultsSchema

	/// <exclude/>
	public class LandingLeadDefaultsSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public LandingLeadDefaultsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LandingLeadDefaultsSchema(LandingLeadDefaultsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LandingLeadDefaultsSchema(LandingLeadDefaultsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a");
			RealUId = new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a");
			Name = "LandingLeadDefaults";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("2cebfd9b-fa03-4242-8ecd-21cd2ca5b8ba");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateDisplayValueColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("fcf2f5a1-d285-4f07-812e-1d2fb20d0388")) == null) {
				Columns.Add(CreateLandingColumn());
			}
			if (Columns.FindByUId(new Guid("60e8a89c-c7d6-471c-bd11-0404c42b77d5")) == null) {
				Columns.Add(CreateColumnUIdColumn());
			}
			if (Columns.FindByUId(new Guid("f7263c94-1955-4e73-970b-6a202e3111c6")) == null) {
				Columns.Add(CreateColumnCaptionColumn());
			}
			if (Columns.FindByUId(new Guid("2a8720f7-f29e-41ac-b88e-7e09663d0eaf")) == null) {
				Columns.Add(CreateGuidValueColumn());
			}
			if (Columns.FindByUId(new Guid("7ab20ae8-54c3-41b4-97f1-cdc62b1a0b79")) == null) {
				Columns.Add(CreateTextValueColumn());
			}
			if (Columns.FindByUId(new Guid("93abdf96-9e69-4c5e-acf7-e0dcf4c06a63")) == null) {
				Columns.Add(CreateIntegerValueColumn());
			}
			if (Columns.FindByUId(new Guid("4d3ff9f8-4304-4016-8e8f-45e204121ae8")) == null) {
				Columns.Add(CreateFloatValueColumn());
			}
			if (Columns.FindByUId(new Guid("873b4167-30f1-4bac-806a-fe8aa9ba0950")) == null) {
				Columns.Add(CreateBooleanValueColumn());
			}
			if (Columns.FindByUId(new Guid("5498d00f-8fb9-48e5-b9fe-d8d149012763")) == null) {
				Columns.Add(CreateDateTimeValueColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateLandingColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fcf2f5a1-d285-4f07-812e-1d2fb20d0388"),
				Name = @"Landing",
				ReferenceSchemaUId = new Guid("41ae7d8d-bec3-41df-a6f0-2ab0d08b3967"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a"),
				ModifiedInSchemaUId = new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a"),
				CreatedInPackageId = new Guid("2cebfd9b-fa03-4242-8ecd-21cd2ca5b8ba")
			};
		}

		protected virtual EntitySchemaColumn CreateDisplayValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("3fc79c7c-ddd6-4839-9ed4-c791481a2f02"),
				Name = @"DisplayValue",
				CreatedInSchemaUId = new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a"),
				ModifiedInSchemaUId = new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a"),
				CreatedInPackageId = new Guid("202cd6f4-4bd7-46f3-ba65-b53cf8adb6f1")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("60e8a89c-c7d6-471c-bd11-0404c42b77d5"),
				Name = @"ColumnUId",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a"),
				ModifiedInSchemaUId = new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a"),
				CreatedInPackageId = new Guid("2cebfd9b-fa03-4242-8ecd-21cd2ca5b8ba")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("f7263c94-1955-4e73-970b-6a202e3111c6"),
				Name = @"ColumnCaption",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a"),
				ModifiedInSchemaUId = new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a"),
				CreatedInPackageId = new Guid("2cebfd9b-fa03-4242-8ecd-21cd2ca5b8ba")
			};
		}

		protected virtual EntitySchemaColumn CreateGuidValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("2a8720f7-f29e-41ac-b88e-7e09663d0eaf"),
				Name = @"GuidValue",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a"),
				ModifiedInSchemaUId = new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a"),
				CreatedInPackageId = new Guid("e3031532-a059-4130-8d2e-6bdf35a52945")
			};
		}

		protected virtual EntitySchemaColumn CreateTextValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("7ab20ae8-54c3-41b4-97f1-cdc62b1a0b79"),
				Name = @"TextValue",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a"),
				ModifiedInSchemaUId = new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a"),
				CreatedInPackageId = new Guid("202cd6f4-4bd7-46f3-ba65-b53cf8adb6f1")
			};
		}

		protected virtual EntitySchemaColumn CreateIntegerValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("93abdf96-9e69-4c5e-acf7-e0dcf4c06a63"),
				Name = @"IntegerValue",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a"),
				ModifiedInSchemaUId = new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a"),
				CreatedInPackageId = new Guid("202cd6f4-4bd7-46f3-ba65-b53cf8adb6f1")
			};
		}

		protected virtual EntitySchemaColumn CreateFloatValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("4d3ff9f8-4304-4016-8e8f-45e204121ae8"),
				Name = @"FloatValue",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a"),
				ModifiedInSchemaUId = new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a"),
				CreatedInPackageId = new Guid("202cd6f4-4bd7-46f3-ba65-b53cf8adb6f1")
			};
		}

		protected virtual EntitySchemaColumn CreateBooleanValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("873b4167-30f1-4bac-806a-fe8aa9ba0950"),
				Name = @"BooleanValue",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a"),
				ModifiedInSchemaUId = new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a"),
				CreatedInPackageId = new Guid("202cd6f4-4bd7-46f3-ba65-b53cf8adb6f1")
			};
		}

		protected virtual EntitySchemaColumn CreateDateTimeValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("5498d00f-8fb9-48e5-b9fe-d8d149012763"),
				Name = @"DateTimeValue",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a"),
				ModifiedInSchemaUId = new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a"),
				CreatedInPackageId = new Guid("202cd6f4-4bd7-46f3-ba65-b53cf8adb6f1")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLandingLeadDefaultsEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateLandingLeadDefaultsEventsProcessSchema() {
			var schema = new LandingLeadDefaultsEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LandingLeadDefaults(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LandingLeadDefaults_WebLeadFormEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LandingLeadDefaultsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LandingLeadDefaultsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a"));
		}

		#endregion

	}

	#endregion

	#region Class: LandingLeadDefaults

	/// <summary>
	/// Default values for the lead fields.
	/// </summary>
	public class LandingLeadDefaults : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public LandingLeadDefaults(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LandingLeadDefaults";
		}

		public LandingLeadDefaults(LandingLeadDefaults source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid LandingId {
			get {
				return GetTypedColumnValue<Guid>("LandingId");
			}
			set {
				SetColumnValue("LandingId", value);
				_landing = null;
			}
		}

		/// <exclude/>
		public string LandingName {
			get {
				return GetTypedColumnValue<string>("LandingName");
			}
			set {
				SetColumnValue("LandingName", value);
				if (_landing != null) {
					_landing.Name = value;
				}
			}
		}

		private GeneratedWebForm _landing;
		/// <summary>
		/// Landing page.
		/// </summary>
		public GeneratedWebForm Landing {
			get {
				return _landing ??
					(_landing = LookupColumnEntities.GetEntity("Landing") as GeneratedWebForm);
			}
		}

		/// <summary>
		/// Value.
		/// </summary>
		public string DisplayValue {
			get {
				return GetTypedColumnValue<string>("DisplayValue");
			}
			set {
				SetColumnValue("DisplayValue", value);
			}
		}

		/// <summary>
		/// Lead field UId.
		/// </summary>
		public Guid ColumnUId {
			get {
				return GetTypedColumnValue<Guid>("ColumnUId");
			}
			set {
				SetColumnValue("ColumnUId", value);
			}
		}

		/// <summary>
		/// Lead field.
		/// </summary>
		public string ColumnCaption {
			get {
				return GetTypedColumnValue<string>("ColumnCaption");
			}
			set {
				SetColumnValue("ColumnCaption", value);
			}
		}

		/// <summary>
		/// Lookup column value.
		/// </summary>
		public Guid GuidValue {
			get {
				return GetTypedColumnValue<Guid>("GuidValue");
			}
			set {
				SetColumnValue("GuidValue", value);
			}
		}

		/// <summary>
		/// TextValue.
		/// </summary>
		public string TextValue {
			get {
				return GetTypedColumnValue<string>("TextValue");
			}
			set {
				SetColumnValue("TextValue", value);
			}
		}

		/// <summary>
		/// IntegerValue.
		/// </summary>
		public int IntegerValue {
			get {
				return GetTypedColumnValue<int>("IntegerValue");
			}
			set {
				SetColumnValue("IntegerValue", value);
			}
		}

		/// <summary>
		/// FloatValue.
		/// </summary>
		public Decimal FloatValue {
			get {
				return GetTypedColumnValue<Decimal>("FloatValue");
			}
			set {
				SetColumnValue("FloatValue", value);
			}
		}

		/// <summary>
		/// BooleanValue.
		/// </summary>
		public bool BooleanValue {
			get {
				return GetTypedColumnValue<bool>("BooleanValue");
			}
			set {
				SetColumnValue("BooleanValue", value);
			}
		}

		/// <summary>
		/// DateTimeValue.
		/// </summary>
		public DateTime DateTimeValue {
			get {
				return GetTypedColumnValue<DateTime>("DateTimeValue");
			}
			set {
				SetColumnValue("DateTimeValue", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LandingLeadDefaults_WebLeadFormEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("LandingLeadDefaultsDeleted", e);
			Validating += (s, e) => ThrowEvent("LandingLeadDefaultsValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LandingLeadDefaults(this);
		}

		#endregion

	}

	#endregion

	#region Class: LandingLeadDefaults_WebLeadFormEventsProcess

	/// <exclude/>
	public partial class LandingLeadDefaults_WebLeadFormEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : LandingLeadDefaults
	{

		public LandingLeadDefaults_WebLeadFormEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LandingLeadDefaults_WebLeadFormEventsProcess";
			SchemaUId = new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a");
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

	#region Class: LandingLeadDefaults_WebLeadFormEventsProcess

	/// <exclude/>
	public class LandingLeadDefaults_WebLeadFormEventsProcess : LandingLeadDefaults_WebLeadFormEventsProcess<LandingLeadDefaults>
	{

		public LandingLeadDefaults_WebLeadFormEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LandingLeadDefaults_WebLeadFormEventsProcess

	public partial class LandingLeadDefaults_WebLeadFormEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: LandingLeadDefaultsEventsProcessSchema

	/// <exclude/>
	public class LandingLeadDefaultsEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public LandingLeadDefaultsEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LandingLeadDefaultsEventsProcessSchema(LandingLeadDefaultsEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LandingLeadDefaults_WebLeadFormEventsProcess";
			UId = new Guid("dfe1546e-6fa4-431e-b934-2083bea03161");
			CreatedInPackageId = new Guid("2cebfd9b-fa03-4242-8ecd-21cd2ca5b8ba");
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
			return new LandingLeadDefaultsEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dfe1546e-6fa4-431e-b934-2083bea03161"));
		}

		#endregion

	}

	#endregion


	#region Class: LandingLeadDefaultsEventsProcess

	/// <exclude/>
	public class LandingLeadDefaultsEventsProcess : LandingLeadDefaults_WebLeadFormEventsProcess
	{

		public LandingLeadDefaultsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

