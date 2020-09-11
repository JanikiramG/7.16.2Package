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

	#region Class: SysModuleReportSchema

	/// <exclude/>
	public class SysModuleReportSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysModuleReportSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysModuleReportSchema(SysModuleReportSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysModuleReportSchema(SysModuleReportSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297");
			RealUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297");
			Name = "SysModuleReport";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateCaptionColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b6607c22-ca01-41f0-8637-610221a869b6")) == null) {
				Columns.Add(CreateSysModuleColumn());
			}
			if (Columns.FindByUId(new Guid("b99f16cb-925d-48f2-94e9-98f9eb249048")) == null) {
				Columns.Add(CreateAutoPreviewColumn());
			}
			if (Columns.FindByUId(new Guid("5c6855ee-1bce-4a62-901b-50482def049b")) == null) {
				Columns.Add(CreateHelpContextIdColumn());
			}
			if (Columns.FindByUId(new Guid("aba36b7e-96c2-4005-a9b9-64ceee36aaac")) == null) {
				Columns.Add(CreateMacrosListColumn());
			}
			if (Columns.FindByUId(new Guid("94f2a9f7-55c7-4ecf-9b64-17583ddc058b")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("cb6b495c-384d-4a40-9f93-35c6dfb79a3b")) == null) {
				Columns.Add(CreateFileColumn());
			}
			if (Columns.FindByUId(new Guid("362bb0b0-d3da-4b01-abe6-a617e1b1257f")) == null) {
				Columns.Add(CreateFileNameColumn());
			}
			if (Columns.FindByUId(new Guid("8e01622f-e04b-480a-859a-01df55c30729")) == null) {
				Columns.Add(CreateSysReportSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("1f17f6cb-8a86-408c-9207-d2f8b22ae1b7")) == null) {
				Columns.Add(CreateSysOptionsPageSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("3b976c18-5bfe-482a-8ac1-a9377075a627")) == null) {
				Columns.Add(CreateShowInSectionColumn());
			}
			if (Columns.FindByUId(new Guid("9a75dacc-e0b6-456c-af91-1a1a369eaa3b")) == null) {
				Columns.Add(CreateShowInCardColumn());
			}
			if (Columns.FindByUId(new Guid("025ae038-8c4b-46b8-8d94-239ef3ac7911")) == null) {
				Columns.Add(CreateConvertInPDFColumn());
			}
			if (Columns.FindByUId(new Guid("e6df7487-eab8-49eb-8f5b-e8a222db5de3")) == null) {
				Columns.Add(CreateTypeColumnValueColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("3fb83606-040e-4fdb-aeb6-a9357886dcb3"),
				Name = @"Caption",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				ModifiedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateSysModuleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b6607c22-ca01-41f0-8637-610221a869b6"),
				Name = @"SysModule",
				ReferenceSchemaUId = new Guid("2b2ed767-0b4b-4a7b-9de2-d48e14a2c0c5"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				ModifiedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAutoPreviewColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("b99f16cb-925d-48f2-94e9-98f9eb249048"),
				Name = @"AutoPreview",
				CreatedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				ModifiedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateHelpContextIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("5c6855ee-1bce-4a62-901b-50482def049b"),
				Name = @"HelpContextId",
				CreatedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				ModifiedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateMacrosListColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("aba36b7e-96c2-4005-a9b9-64ceee36aaac"),
				Name = @"MacrosList",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				ModifiedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("94f2a9f7-55c7-4ecf-9b64-17583ddc058b"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("0349fa8b-b851-4301-bc18-2c36e3d8bc0d"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				ModifiedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateFileColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("File")) {
				UId = new Guid("cb6b495c-384d-4a40-9f93-35c6dfb79a3b"),
				Name = @"File",
				CreatedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				ModifiedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateFileNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("362bb0b0-d3da-4b01-abe6-a617e1b1257f"),
				Name = @"FileName",
				CreatedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				ModifiedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSysReportSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("8e01622f-e04b-480a-859a-01df55c30729"),
				Name = @"SysReportSchemaUId",
				CreatedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				ModifiedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSysOptionsPageSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("1f17f6cb-8a86-408c-9207-d2f8b22ae1b7"),
				Name = @"SysOptionsPageSchemaUId",
				CreatedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				ModifiedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateShowInSectionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("3b976c18-5bfe-482a-8ac1-a9377075a627"),
				Name = @"ShowInSection",
				CreatedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				ModifiedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90")
			};
		}

		protected virtual EntitySchemaColumn CreateShowInCardColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("9a75dacc-e0b6-456c-af91-1a1a369eaa3b"),
				Name = @"ShowInCard",
				CreatedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				ModifiedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90")
			};
		}

		protected virtual EntitySchemaColumn CreateConvertInPDFColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("025ae038-8c4b-46b8-8d94-239ef3ac7911"),
				Name = @"ConvertInPDF",
				CreatedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				ModifiedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumnValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("e6df7487-eab8-49eb-8f5b-e8a222db5de3"),
				Name = @"TypeColumnValue",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				ModifiedInSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysModuleReportEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysModuleReportEventsProcessSchema() {
			var schema = new SysModuleReportEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysModuleReport(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysModuleReport_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysModuleReportSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysModuleReportSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"));
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReport

	/// <summary>
	/// Printable.
	/// </summary>
	public class SysModuleReport : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysModuleReport(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysModuleReport";
		}

		public SysModuleReport(SysModuleReport source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Title.
		/// </summary>
		public string Caption {
			get {
				return GetTypedColumnValue<string>("Caption");
			}
			set {
				SetColumnValue("Caption", value);
			}
		}

		/// <exclude/>
		public Guid SysModuleId {
			get {
				return GetTypedColumnValue<Guid>("SysModuleId");
			}
			set {
				SetColumnValue("SysModuleId", value);
				_sysModule = null;
			}
		}

		/// <exclude/>
		public string SysModuleCaption {
			get {
				return GetTypedColumnValue<string>("SysModuleCaption");
			}
			set {
				SetColumnValue("SysModuleCaption", value);
				if (_sysModule != null) {
					_sysModule.Caption = value;
				}
			}
		}

		private SysModule _sysModule;
		/// <summary>
		/// Section.
		/// </summary>
		public SysModule SysModule {
			get {
				return _sysModule ??
					(_sysModule = LookupColumnEntities.GetEntity("SysModule") as SysModule);
			}
		}

		/// <summary>
		/// Automatic preview.
		/// </summary>
		public bool AutoPreview {
			get {
				return GetTypedColumnValue<bool>("AutoPreview");
			}
			set {
				SetColumnValue("AutoPreview", value);
			}
		}

		/// <summary>
		/// Contextual help Id.
		/// </summary>
		public string HelpContextId {
			get {
				return GetTypedColumnValue<string>("HelpContextId");
			}
			set {
				SetColumnValue("HelpContextId", value);
			}
		}

		/// <summary>
		/// List of fields.
		/// </summary>
		public string MacrosList {
			get {
				return GetTypedColumnValue<string>("MacrosList");
			}
			set {
				SetColumnValue("MacrosList", value);
			}
		}

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private SysModuleReportType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public SysModuleReportType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as SysModuleReportType);
			}
		}

		/// <summary>
		/// File name.
		/// </summary>
		public string FileName {
			get {
				return GetTypedColumnValue<string>("FileName");
			}
			set {
				SetColumnValue("FileName", value);
			}
		}

		/// <summary>
		/// Unique identifier of printable form.
		/// </summary>
		public Guid SysReportSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("SysReportSchemaUId");
			}
			set {
				SetColumnValue("SysReportSchemaUId", value);
			}
		}

		/// <summary>
		/// Unique identifier of printable form setup.
		/// </summary>
		public Guid SysOptionsPageSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("SysOptionsPageSchemaUId");
			}
			set {
				SetColumnValue("SysOptionsPageSchemaUId", value);
			}
		}

		/// <summary>
		/// Show in section.
		/// </summary>
		public bool ShowInSection {
			get {
				return GetTypedColumnValue<bool>("ShowInSection");
			}
			set {
				SetColumnValue("ShowInSection", value);
			}
		}

		/// <summary>
		/// Show in card.
		/// </summary>
		public bool ShowInCard {
			get {
				return GetTypedColumnValue<bool>("ShowInCard");
			}
			set {
				SetColumnValue("ShowInCard", value);
			}
		}

		/// <summary>
		/// Convert to PDF.
		/// </summary>
		public bool ConvertInPDF {
			get {
				return GetTypedColumnValue<bool>("ConvertInPDF");
			}
			set {
				SetColumnValue("ConvertInPDF", value);
			}
		}

		/// <summary>
		/// Type column value.
		/// </summary>
		public Guid TypeColumnValue {
			get {
				return GetTypedColumnValue<Guid>("TypeColumnValue");
			}
			set {
				SetColumnValue("TypeColumnValue", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysModuleReport_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysModuleReportDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysModuleReportDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysModuleReportInserted", e);
			Inserting += (s, e) => ThrowEvent("SysModuleReportInserting", e);
			Saved += (s, e) => ThrowEvent("SysModuleReportSaved", e);
			Saving += (s, e) => ThrowEvent("SysModuleReportSaving", e);
			Validating += (s, e) => ThrowEvent("SysModuleReportValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleReport(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReport_BaseEventsProcess

	/// <exclude/>
	public partial class SysModuleReport_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysModuleReport
	{

		public SysModuleReport_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleReport_BaseEventsProcess";
			SchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297");
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

	#region Class: SysModuleReport_BaseEventsProcess

	/// <exclude/>
	public class SysModuleReport_BaseEventsProcess : SysModuleReport_BaseEventsProcess<SysModuleReport>
	{

		public SysModuleReport_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleReport_BaseEventsProcess

	public partial class SysModuleReport_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysModuleReportEventsProcessSchema

	/// <exclude/>
	public class SysModuleReportEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysModuleReportEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysModuleReportEventsProcessSchema(SysModuleReportEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysModuleReport_BaseEventsProcess";
			UId = new Guid("04bf2a64-063c-4e43-9be6-e40b3b90fe09");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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
			return new SysModuleReportEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("04bf2a64-063c-4e43-9be6-e40b3b90fe09"));
		}

		#endregion

	}

	#endregion


	#region Class: SysModuleReportEventsProcess

	/// <exclude/>
	public class SysModuleReportEventsProcess : SysModuleReport_BaseEventsProcess
	{

		public SysModuleReportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

