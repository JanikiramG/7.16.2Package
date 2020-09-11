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
	using Terrasoft.Configuration;
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

	#region Class: PartnershipParameter_PRMBase_TerrasoftSchema

	/// <exclude/>
	public class PartnershipParameter_PRMBase_TerrasoftSchema : Terrasoft.Configuration.SpecificationInObjectSchema
	{

		#region Constructors: Public

		public PartnershipParameter_PRMBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public PartnershipParameter_PRMBase_TerrasoftSchema(PartnershipParameter_PRMBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public PartnershipParameter_PRMBase_TerrasoftSchema(PartnershipParameter_PRMBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039");
			RealUId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039");
			Name = "PartnershipParameter_PRMBase_Terrasoft";
			ParentSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			ExtendParent = false;
			CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeMasterRecordColumn() {
			base.InitializeMasterRecordColumn();
			MasterRecordColumn = CreatePartnershipColumn();
			if (Columns.FindByUId(MasterRecordColumn.UId) == null) {
				Columns.Add(MasterRecordColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a8b3d081-45a1-4cd1-aa0f-b129c1104cab")) == null) {
				Columns.Add(CreatePartnerParamCategoryColumn());
			}
			if (Columns.FindByUId(new Guid("6798596b-f967-4e78-a1e3-72d6c773937c")) == null) {
				Columns.Add(CreateScoreColumn());
			}
			if (Columns.FindByUId(new Guid("f864e780-a6a7-4362-be29-4a6ff91ff769")) == null) {
				Columns.Add(CreatePartnershipParameterTypeColumn());
			}
			if (Columns.FindByUId(new Guid("ee91e889-b5bd-4e7a-9773-3dccf95db043")) == null) {
				Columns.Add(CreateParameterTypeColumn());
			}
			if (Columns.FindByUId(new Guid("becc053f-4689-4c9f-a734-d50a7b7918e1")) == null) {
				Columns.Add(CreatePartnerLevelColumn());
			}
			if (Columns.FindByUId(new Guid("fe29d48b-7375-4d8d-92fe-398d8d3e749e")) == null) {
				Columns.Add(CreateParameterValueTypeColumn());
			}
			if (Columns.FindByUId(new Guid("08549aac-10a6-4502-8f99-3a7371534355")) == null) {
				Columns.Add(CreateCurrentValueColumn());
			}
			if (Columns.FindByUId(new Guid("dd554807-4b43-4424-a13e-4d82d1e1c65c")) == null) {
				Columns.Add(CreateGuidValueColumn());
			}
		}

		protected override EntitySchemaColumn CreateFloatValueColumn() {
			EntitySchemaColumn column = base.CreateFloatValueColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("Float3");
			column.ModifiedInSchemaUId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039");
			return column;
		}

		protected override EntitySchemaColumn CreateSpecificationColumn() {
			EntitySchemaColumn column = base.CreateSpecificationColumn();
			column.RequirementType = EntitySchemaColumnRequirementType.None;
			column.ModifiedInSchemaUId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039");
			return column;
		}

		protected virtual EntitySchemaColumn CreatePartnerParamCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a8b3d081-45a1-4cd1-aa0f-b129c1104cab"),
				Name = @"PartnerParamCategory",
				ReferenceSchemaUId = new Guid("7a91ebee-2015-4ee4-bc69-12fb6a22ad6e"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039"),
				ModifiedInSchemaUId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb")
			};
		}

		protected virtual EntitySchemaColumn CreateScoreColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("6798596b-f967-4e78-a1e3-72d6c773937c"),
				Name = @"Score",
				CreatedInSchemaUId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039"),
				ModifiedInSchemaUId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"0"
				}
			};
		}

		protected virtual EntitySchemaColumn CreatePartnershipColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("edf932a5-9b80-4be1-9f8c-17ff782e83c9"),
				Name = @"Partnership",
				ReferenceSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039"),
				ModifiedInSchemaUId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb")
			};
		}

		protected virtual EntitySchemaColumn CreatePartnershipParameterTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f864e780-a6a7-4362-be29-4a6ff91ff769"),
				Name = @"PartnershipParameterType",
				ReferenceSchemaUId = new Guid("dc90b3b7-0cd1-41a3-a9f0-24322ece222a"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039"),
				ModifiedInSchemaUId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb")
			};
		}

		protected virtual EntitySchemaColumn CreateParameterTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ee91e889-b5bd-4e7a-9773-3dccf95db043"),
				Name = @"ParameterType",
				ReferenceSchemaUId = new Guid("ab9ef8b5-8cff-4a02-88e8-a6e8e926f152"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039"),
				ModifiedInSchemaUId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb")
			};
		}

		protected virtual EntitySchemaColumn CreatePartnerLevelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("becc053f-4689-4c9f-a734-d50a7b7918e1"),
				Name = @"PartnerLevel",
				ReferenceSchemaUId = new Guid("0e098241-437e-4443-b864-0c5cc0cd1a80"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039"),
				ModifiedInSchemaUId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb")
			};
		}

		protected virtual EntitySchemaColumn CreateParameterValueTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fe29d48b-7375-4d8d-92fe-398d8d3e749e"),
				Name = @"ParameterValueType",
				ReferenceSchemaUId = new Guid("787ae6a1-f727-4c4e-964a-c09e24083810"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039"),
				ModifiedInSchemaUId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb")
			};
		}

		protected virtual EntitySchemaColumn CreateCurrentValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("08549aac-10a6-4502-8f99-3a7371534355"),
				Name = @"CurrentValue",
				CreatedInSchemaUId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039"),
				ModifiedInSchemaUId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb")
			};
		}

		protected virtual EntitySchemaColumn CreateGuidValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("dd554807-4b43-4424-a13e-4d82d1e1c65c"),
				Name = @"GuidValue",
				CreatedInSchemaUId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039"),
				ModifiedInSchemaUId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039"),
				CreatedInPackageId = new Guid("6f0ddd54-2f1a-468d-afb8-9805de4678f7")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreatePartnershipParameter_PRMBase_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreatePartnershipParameter_PRMBase_TerrasoftEventsProcessSchema() {
			var schema = new PartnershipParameter_PRMBase_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new PartnershipParameter_PRMBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new PartnershipParameter_PRMBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new PartnershipParameter_PRMBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new PartnershipParameter_PRMBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039"));
		}

		#endregion

	}

	#endregion

	#region Class: PartnershipParameter_PRMBase_Terrasoft

	/// <summary>
	/// PartnershipParameter.
	/// </summary>
	public class PartnershipParameter_PRMBase_Terrasoft : Terrasoft.Configuration.SpecificationInObject
	{

		#region Constructors: Public

		public PartnershipParameter_PRMBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "PartnershipParameter_PRMBase_Terrasoft";
		}

		public PartnershipParameter_PRMBase_Terrasoft(PartnershipParameter_PRMBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid PartnerParamCategoryId {
			get {
				return GetTypedColumnValue<Guid>("PartnerParamCategoryId");
			}
			set {
				SetColumnValue("PartnerParamCategoryId", value);
				_partnerParamCategory = null;
			}
		}

		/// <exclude/>
		public string PartnerParamCategoryName {
			get {
				return GetTypedColumnValue<string>("PartnerParamCategoryName");
			}
			set {
				SetColumnValue("PartnerParamCategoryName", value);
				if (_partnerParamCategory != null) {
					_partnerParamCategory.Name = value;
				}
			}
		}

		private PartnerParamCategory _partnerParamCategory;
		/// <summary>
		/// Parameter.
		/// </summary>
		public PartnerParamCategory PartnerParamCategory {
			get {
				return _partnerParamCategory ??
					(_partnerParamCategory = LookupColumnEntities.GetEntity("PartnerParamCategory") as PartnerParamCategory);
			}
		}

		/// <summary>
		/// Score.
		/// </summary>
		public int Score {
			get {
				return GetTypedColumnValue<int>("Score");
			}
			set {
				SetColumnValue("Score", value);
			}
		}

		/// <exclude/>
		public Guid PartnershipId {
			get {
				return GetTypedColumnValue<Guid>("PartnershipId");
			}
			set {
				SetColumnValue("PartnershipId", value);
				_partnership = null;
			}
		}

		/// <exclude/>
		public string PartnershipName {
			get {
				return GetTypedColumnValue<string>("PartnershipName");
			}
			set {
				SetColumnValue("PartnershipName", value);
				if (_partnership != null) {
					_partnership.Name = value;
				}
			}
		}

		private Partnership _partnership;
		/// <summary>
		/// Partnership.
		/// </summary>
		public Partnership Partnership {
			get {
				return _partnership ??
					(_partnership = LookupColumnEntities.GetEntity("Partnership") as Partnership);
			}
		}

		/// <exclude/>
		public Guid PartnershipParameterTypeId {
			get {
				return GetTypedColumnValue<Guid>("PartnershipParameterTypeId");
			}
			set {
				SetColumnValue("PartnershipParameterTypeId", value);
				_partnershipParameterType = null;
			}
		}

		/// <exclude/>
		public string PartnershipParameterTypeName {
			get {
				return GetTypedColumnValue<string>("PartnershipParameterTypeName");
			}
			set {
				SetColumnValue("PartnershipParameterTypeName", value);
				if (_partnershipParameterType != null) {
					_partnershipParameterType.Name = value;
				}
			}
		}

		private PartnershipParamType _partnershipParameterType;
		/// <summary>
		/// Type.
		/// </summary>
		public PartnershipParamType PartnershipParameterType {
			get {
				return _partnershipParameterType ??
					(_partnershipParameterType = LookupColumnEntities.GetEntity("PartnershipParameterType") as PartnershipParamType);
			}
		}

		/// <exclude/>
		public Guid ParameterTypeId {
			get {
				return GetTypedColumnValue<Guid>("ParameterTypeId");
			}
			set {
				SetColumnValue("ParameterTypeId", value);
				_parameterType = null;
			}
		}

		/// <exclude/>
		public string ParameterTypeName {
			get {
				return GetTypedColumnValue<string>("ParameterTypeName");
			}
			set {
				SetColumnValue("ParameterTypeName", value);
				if (_parameterType != null) {
					_parameterType.Name = value;
				}
			}
		}

		private ParameterType _parameterType;
		/// <summary>
		/// Kind.
		/// </summary>
		public ParameterType ParameterType {
			get {
				return _parameterType ??
					(_parameterType = LookupColumnEntities.GetEntity("ParameterType") as ParameterType);
			}
		}

		/// <exclude/>
		public Guid PartnerLevelId {
			get {
				return GetTypedColumnValue<Guid>("PartnerLevelId");
			}
			set {
				SetColumnValue("PartnerLevelId", value);
				_partnerLevel = null;
			}
		}

		/// <exclude/>
		public string PartnerLevelName {
			get {
				return GetTypedColumnValue<string>("PartnerLevelName");
			}
			set {
				SetColumnValue("PartnerLevelName", value);
				if (_partnerLevel != null) {
					_partnerLevel.Name = value;
				}
			}
		}

		private PartnerLevel _partnerLevel;
		/// <summary>
		/// Partner level.
		/// </summary>
		public PartnerLevel PartnerLevel {
			get {
				return _partnerLevel ??
					(_partnerLevel = LookupColumnEntities.GetEntity("PartnerLevel") as PartnerLevel);
			}
		}

		/// <exclude/>
		public Guid ParameterValueTypeId {
			get {
				return GetTypedColumnValue<Guid>("ParameterValueTypeId");
			}
			set {
				SetColumnValue("ParameterValueTypeId", value);
				_parameterValueType = null;
			}
		}

		/// <exclude/>
		public string ParameterValueTypeName {
			get {
				return GetTypedColumnValue<string>("ParameterValueTypeName");
			}
			set {
				SetColumnValue("ParameterValueTypeName", value);
				if (_parameterValueType != null) {
					_parameterValueType.Name = value;
				}
			}
		}

		private SpecificationType _parameterValueType;
		/// <summary>
		/// Parameter value type.
		/// </summary>
		public SpecificationType ParameterValueType {
			get {
				return _parameterValueType ??
					(_parameterValueType = LookupColumnEntities.GetEntity("ParameterValueType") as SpecificationType);
			}
		}

		/// <summary>
		/// Current value.
		/// </summary>
		public string CurrentValue {
			get {
				return GetTypedColumnValue<string>("CurrentValue");
			}
			set {
				SetColumnValue("CurrentValue", value);
			}
		}

		/// <summary>
		/// Value (GUID).
		/// </summary>
		public Guid GuidValue {
			get {
				return GetTypedColumnValue<Guid>("GuidValue");
			}
			set {
				SetColumnValue("GuidValue", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new PartnershipParameter_PRMBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("PartnershipParameter_PRMBase_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("PartnershipParameter_PRMBase_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("PartnershipParameter_PRMBase_TerrasoftInserted", e);
			Saved += (s, e) => ThrowEvent("PartnershipParameter_PRMBase_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("PartnershipParameter_PRMBase_TerrasoftSaving", e);
			Updated += (s, e) => ThrowEvent("PartnershipParameter_PRMBase_TerrasoftUpdated", e);
			Validating += (s, e) => ThrowEvent("PartnershipParameter_PRMBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PartnershipParameter_PRMBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: PartnershipParameter_PRMBaseEventsProcess

	/// <exclude/>
	public partial class PartnershipParameter_PRMBaseEventsProcess<TEntity> : Terrasoft.Configuration.SpecificationInObject_SpecificationEventsProcess<TEntity> where TEntity : PartnershipParameter_PRMBase_Terrasoft
	{

		public PartnershipParameter_PRMBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "PartnershipParameter_PRMBaseEventsProcess";
			SchemaUId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _partnershipParameterInsertedEventSubProcess;
		public ProcessFlowElement PartnershipParameterInsertedEventSubProcess {
			get {
				return _partnershipParameterInsertedEventSubProcess ?? (_partnershipParameterInsertedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PartnershipParameterInsertedEventSubProcess",
					SchemaElementUId = new Guid("58b2f32b-e174-4f81-8e17-e35ee3d4bfb6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _partnershipParameterInsertedStartMessage;
		public ProcessFlowElement PartnershipParameterInsertedStartMessage {
			get {
				return _partnershipParameterInsertedStartMessage ?? (_partnershipParameterInsertedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PartnershipParameterInsertedStartMessage",
					SchemaElementUId = new Guid("68b36cd4-19a6-43ea-8945-e5e6f32bf77b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _partnershipParameterInsertedScriptTask;
		public ProcessScriptTask PartnershipParameterInsertedScriptTask {
			get {
				return _partnershipParameterInsertedScriptTask ?? (_partnershipParameterInsertedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PartnershipParameterInsertedScriptTask",
					SchemaElementUId = new Guid("374fe5a3-af87-4882-9854-eae1c144b7aa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PartnershipParameterInsertedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _partnershipParameterUpdatedEventSubProcess;
		public ProcessFlowElement PartnershipParameterUpdatedEventSubProcess {
			get {
				return _partnershipParameterUpdatedEventSubProcess ?? (_partnershipParameterUpdatedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PartnershipParameterUpdatedEventSubProcess",
					SchemaElementUId = new Guid("29dd2f7c-7523-49f8-9c5c-a62b44831cc2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _partnershipParameterUpdated;
		public ProcessFlowElement PartnershipParameterUpdated {
			get {
				return _partnershipParameterUpdated ?? (_partnershipParameterUpdated = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PartnershipParameterUpdated",
					SchemaElementUId = new Guid("17912aea-7fe8-482c-9bc0-5a51796a8e03"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _partnershipParameterUpdatedScriptTask;
		public ProcessScriptTask PartnershipParameterUpdatedScriptTask {
			get {
				return _partnershipParameterUpdatedScriptTask ?? (_partnershipParameterUpdatedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PartnershipParameterUpdatedScriptTask",
					SchemaElementUId = new Guid("2a4528d5-a40f-4568-8073-513e97b429d6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PartnershipParameterUpdatedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _partnershipParameterSavingEventSubProcess;
		public ProcessFlowElement PartnershipParameterSavingEventSubProcess {
			get {
				return _partnershipParameterSavingEventSubProcess ?? (_partnershipParameterSavingEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PartnershipParameterSavingEventSubProcess",
					SchemaElementUId = new Guid("f2bcb474-79f3-444c-8bf8-0cb3d691405b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _partnershipParameterSavingScriptTask;
		public ProcessScriptTask PartnershipParameterSavingScriptTask {
			get {
				return _partnershipParameterSavingScriptTask ?? (_partnershipParameterSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PartnershipParameterSavingScriptTask",
					SchemaElementUId = new Guid("200c319d-3dde-4996-b711-56bf8298a038"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PartnershipParameterSavingScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _partnershipParameterSavingMessage;
		public ProcessFlowElement PartnershipParameterSavingMessage {
			get {
				return _partnershipParameterSavingMessage ?? (_partnershipParameterSavingMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PartnershipParameterSavingMessage",
					SchemaElementUId = new Guid("72398059-48ca-4df6-a168-f36531810fb0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _partnershipParameterDeletingEventSubProcess;
		public ProcessFlowElement PartnershipParameterDeletingEventSubProcess {
			get {
				return _partnershipParameterDeletingEventSubProcess ?? (_partnershipParameterDeletingEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PartnershipParameterDeletingEventSubProcess",
					SchemaElementUId = new Guid("a95eee94-4968-4e28-84e2-811399ff1f21"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _partnershipParameterDeleting;
		public ProcessFlowElement PartnershipParameterDeleting {
			get {
				return _partnershipParameterDeleting ?? (_partnershipParameterDeleting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PartnershipParameterDeleting",
					SchemaElementUId = new Guid("4bb52952-13a4-4c2f-8c8f-b26b3ba4eef5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _partnershipParameterDeletingScriptTask;
		public ProcessScriptTask PartnershipParameterDeletingScriptTask {
			get {
				return _partnershipParameterDeletingScriptTask ?? (_partnershipParameterDeletingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PartnershipParameterDeletingScriptTask",
					SchemaElementUId = new Guid("bac119b1-8369-42d0-aff0-ddfa09bd560e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PartnershipParameterDeletingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[PartnershipParameterInsertedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PartnershipParameterInsertedEventSubProcess };
			FlowElements[PartnershipParameterInsertedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PartnershipParameterInsertedStartMessage };
			FlowElements[PartnershipParameterInsertedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PartnershipParameterInsertedScriptTask };
			FlowElements[PartnershipParameterUpdatedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PartnershipParameterUpdatedEventSubProcess };
			FlowElements[PartnershipParameterUpdated.SchemaElementUId] = new Collection<ProcessFlowElement> { PartnershipParameterUpdated };
			FlowElements[PartnershipParameterUpdatedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PartnershipParameterUpdatedScriptTask };
			FlowElements[PartnershipParameterSavingEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PartnershipParameterSavingEventSubProcess };
			FlowElements[PartnershipParameterSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PartnershipParameterSavingScriptTask };
			FlowElements[PartnershipParameterSavingMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PartnershipParameterSavingMessage };
			FlowElements[PartnershipParameterDeletingEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PartnershipParameterDeletingEventSubProcess };
			FlowElements[PartnershipParameterDeleting.SchemaElementUId] = new Collection<ProcessFlowElement> { PartnershipParameterDeleting };
			FlowElements[PartnershipParameterDeletingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PartnershipParameterDeletingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "PartnershipParameterInsertedEventSubProcess":
						break;
					case "PartnershipParameterInsertedStartMessage":
						e.Context.QueueTasks.Enqueue("PartnershipParameterInsertedScriptTask");
						break;
					case "PartnershipParameterInsertedScriptTask":
						break;
					case "PartnershipParameterUpdatedEventSubProcess":
						break;
					case "PartnershipParameterUpdated":
						e.Context.QueueTasks.Enqueue("PartnershipParameterUpdatedScriptTask");
						break;
					case "PartnershipParameterUpdatedScriptTask":
						break;
					case "PartnershipParameterSavingEventSubProcess":
						break;
					case "PartnershipParameterSavingScriptTask":
						break;
					case "PartnershipParameterSavingMessage":
						e.Context.QueueTasks.Enqueue("PartnershipParameterSavingScriptTask");
						break;
					case "PartnershipParameterDeletingEventSubProcess":
						break;
					case "PartnershipParameterDeleting":
						e.Context.QueueTasks.Enqueue("PartnershipParameterDeletingScriptTask");
						break;
					case "PartnershipParameterDeletingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("PartnershipParameterInsertedStartMessage");
			ActivatedEventElements.Add("PartnershipParameterUpdated");
			ActivatedEventElements.Add("PartnershipParameterSavingMessage");
			ActivatedEventElements.Add("PartnershipParameterDeleting");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "PartnershipParameterInsertedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "PartnershipParameterInsertedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PartnershipParameterInsertedStartMessage";
					result = PartnershipParameterInsertedStartMessage.Execute(context);
					break;
				case "PartnershipParameterInsertedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PartnershipParameterInsertedScriptTask";
					result = PartnershipParameterInsertedScriptTask.Execute(context, PartnershipParameterInsertedScriptTaskExecute);
					break;
				case "PartnershipParameterUpdatedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "PartnershipParameterUpdated":
					context.QueueTasks.Dequeue();
					context.SenderName = "PartnershipParameterUpdated";
					result = PartnershipParameterUpdated.Execute(context);
					break;
				case "PartnershipParameterUpdatedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PartnershipParameterUpdatedScriptTask";
					result = PartnershipParameterUpdatedScriptTask.Execute(context, PartnershipParameterUpdatedScriptTaskExecute);
					break;
				case "PartnershipParameterSavingEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "PartnershipParameterSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PartnershipParameterSavingScriptTask";
					result = PartnershipParameterSavingScriptTask.Execute(context, PartnershipParameterSavingScriptTaskExecute);
					break;
				case "PartnershipParameterSavingMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PartnershipParameterSavingMessage";
					result = PartnershipParameterSavingMessage.Execute(context);
					break;
				case "PartnershipParameterDeletingEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "PartnershipParameterDeleting":
					context.QueueTasks.Dequeue();
					context.SenderName = "PartnershipParameterDeleting";
					result = PartnershipParameterDeleting.Execute(context);
					break;
				case "PartnershipParameterDeletingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PartnershipParameterDeletingScriptTask";
					result = PartnershipParameterDeletingScriptTask.Execute(context, PartnershipParameterDeletingScriptTaskExecute);
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

		public virtual bool PartnershipParameterInsertedScriptTaskExecute(ProcessExecutingContext context) {
			if (UserConnection.GetIsFeatureEnabled("EnableOldPartnershipLogic")) {
				PartnershipHelper partnershipHelper
					= ClassFactory.Get<PartnershipHelper>(new ConstructorArgument("userConnection", UserConnection));
			partnershipHelper.AddNewPartnershipParameterHistory(Entity);
			}
			return true;
		}

		public virtual bool PartnershipParameterUpdatedScriptTaskExecute(ProcessExecutingContext context) {
			if (UserConnection.GetIsFeatureEnabled("EnableOldPartnershipLogic")) {
				PartnershipHelper partnershipHelper
					= ClassFactory.Get<PartnershipHelper>(new ConstructorArgument("userConnection", UserConnection));
				var changedColumns = Entity.GetChangedColumnValues().Where(cv => cv.Value != cv.OldValue);
				Guid partnershipId = Entity.GetTypedColumnValue<Guid>("PartnershipId");
				partnershipHelper.RecalculateAllScore(partnershipId);
				if (changedColumns.All(x => x.Name != "PartnerLevelId")) {
					partnershipHelper.ChangePartnershipLevel(partnershipId);
				}
				partnershipHelper.SetPartnershipScoreLeft(partnershipId);
				partnershipHelper.AddNewPartnershipParameterHistory(Entity);
			}
			return true;
		}

		public virtual bool PartnershipParameterSavingScriptTaskExecute(ProcessExecutingContext context) {
			CopyValueToCurrentValueColumn();
			return true;
		}

		public virtual bool PartnershipParameterDeletingScriptTaskExecute(ProcessExecutingContext context) {
			if (UserConnection.GetIsFeatureEnabled("EnableOldPartnershipLogic")) {
				PartnershipHelper partnershipHelper
					= ClassFactory.Get<PartnershipHelper>(new ConstructorArgument("userConnection", UserConnection));
			partnershipHelper.SetParameterHistoryEndDate(Entity);
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PartnershipParameter_PRMBase_TerrasoftInserted":
							if (ActivatedEventElements.Contains("PartnershipParameterInsertedStartMessage")) {
							context.QueueTasks.Enqueue("PartnershipParameterInsertedStartMessage");
						}
						break;
					case "PartnershipParameter_PRMBase_TerrasoftUpdated":
							if (ActivatedEventElements.Contains("PartnershipParameterUpdated")) {
							context.QueueTasks.Enqueue("PartnershipParameterUpdated");
						}
						break;
					case "PartnershipParameter_PRMBase_TerrasoftSaving":
							if (ActivatedEventElements.Contains("PartnershipParameterSavingMessage")) {
							context.QueueTasks.Enqueue("PartnershipParameterSavingMessage");
						}
						break;
					case "PartnershipParameter_PRMBase_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("PartnershipParameterDeleting")) {
							context.QueueTasks.Enqueue("PartnershipParameterDeleting");
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

	#region Class: PartnershipParameter_PRMBaseEventsProcess

	/// <exclude/>
	public class PartnershipParameter_PRMBaseEventsProcess : PartnershipParameter_PRMBaseEventsProcess<PartnershipParameter_PRMBase_Terrasoft>
	{

		public PartnershipParameter_PRMBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: PartnershipParameter_PRMBase_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class PartnershipParameter_PRMBase_TerrasoftEventsProcessSchema : Terrasoft.Configuration.SpecificationInObjectEventsProcessSchema
	{

		#region Constructors: Public

		public PartnershipParameter_PRMBase_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public PartnershipParameter_PRMBase_TerrasoftEventsProcessSchema(PartnershipParameter_PRMBase_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "PartnershipParameter_PRMBaseEventsProcess";
			UId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea");
			CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet2 = CreateLaneSet2LaneSet();
			LaneSets.Add(schemaLaneSet2);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet2.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess partnershipparameterinsertedeventsubprocess = CreatePartnershipParameterInsertedEventSubProcessEventSubProcess();
			FlowElements.Add(partnershipparameterinsertedeventsubprocess);
			ProcessSchemaEventSubProcess partnershipparameterupdatedeventsubprocess = CreatePartnershipParameterUpdatedEventSubProcessEventSubProcess();
			FlowElements.Add(partnershipparameterupdatedeventsubprocess);
			ProcessSchemaEventSubProcess partnershipparametersavingeventsubprocess = CreatePartnershipParameterSavingEventSubProcessEventSubProcess();
			FlowElements.Add(partnershipparametersavingeventsubprocess);
			ProcessSchemaEventSubProcess partnershipparameterdeletingeventsubprocess = CreatePartnershipParameterDeletingEventSubProcessEventSubProcess();
			FlowElements.Add(partnershipparameterdeletingeventsubprocess);
			ProcessSchemaStartMessageEvent partnershipparameterinsertedstartmessage = CreatePartnershipParameterInsertedStartMessageStartMessageEvent();
			partnershipparameterinsertedeventsubprocess.FlowElements.Add(partnershipparameterinsertedstartmessage);
			ProcessSchemaScriptTask partnershipparameterinsertedscripttask = CreatePartnershipParameterInsertedScriptTaskScriptTask();
			partnershipparameterinsertedeventsubprocess.FlowElements.Add(partnershipparameterinsertedscripttask);
			ProcessSchemaStartMessageEvent partnershipparameterupdated = CreatePartnershipParameterUpdatedStartMessageEvent();
			partnershipparameterupdatedeventsubprocess.FlowElements.Add(partnershipparameterupdated);
			ProcessSchemaScriptTask partnershipparameterupdatedscripttask = CreatePartnershipParameterUpdatedScriptTaskScriptTask();
			partnershipparameterupdatedeventsubprocess.FlowElements.Add(partnershipparameterupdatedscripttask);
			ProcessSchemaScriptTask partnershipparametersavingscripttask = CreatePartnershipParameterSavingScriptTaskScriptTask();
			partnershipparametersavingeventsubprocess.FlowElements.Add(partnershipparametersavingscripttask);
			ProcessSchemaStartMessageEvent partnershipparametersavingmessage = CreatePartnershipParameterSavingMessageStartMessageEvent();
			partnershipparametersavingeventsubprocess.FlowElements.Add(partnershipparametersavingmessage);
			ProcessSchemaStartMessageEvent partnershipparameterdeleting = CreatePartnershipParameterDeletingStartMessageEvent();
			partnershipparameterdeletingeventsubprocess.FlowElements.Add(partnershipparameterdeleting);
			ProcessSchemaScriptTask partnershipparameterdeletingscripttask = CreatePartnershipParameterDeletingScriptTaskScriptTask();
			partnershipparameterdeletingeventsubprocess.FlowElements.Add(partnershipparameterdeletingscripttask);
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("1226d7dc-8903-4546-8d1c-de55a1557bfe"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e"),
				CreatedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("68b36cd4-19a6-43ea-8945-e5e6f32bf77b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("374fe5a3-af87-4882-9854-eae1c144b7aa"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("d4a578de-8ed3-4933-8434-bd957d36e4ee"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb"),
				CreatedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("17912aea-7fe8-482c-9bc0-5a51796a8e03"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2a4528d5-a40f-4568-8073-513e97b429d6"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(168, 483));
			schemaFlow.PolylinePointPositions.Add(new Point(168, 497));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("4391ea47-c9f3-460c-bb3c-ca64e758d8e4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb"),
				CreatedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("72398059-48ca-4df6-a168-f36531810fb0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("200c319d-3dde-4996-b711-56bf8298a038"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("50b0c887-3110-4fec-a5ac-d09cbfd0739f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039"),
				CreatedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4bb52952-13a4-4c2f-8c8f-b26b3ba4eef5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bac119b1-8369-42d0-aff0-ddfa09bd560e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("79829477-5655-4e3e-8e87-dc6b991b5448"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb"),
				CreatedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				Name = @"LaneSet2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(0, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet2;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("ccddd163-9fa9-4247-80c4-8ea544364286"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("79829477-5655-4e3e-8e87-dc6b991b5448"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb"),
				CreatedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				Name = @"Lane2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePartnershipParameterInsertedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPartnershipParameterInsertedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("58b2f32b-e174-4f81-8e17-e35ee3d4bfb6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ccddd163-9fa9-4247-80c4-8ea544364286"),
				CreatedInOwnerSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e"),
				CreatedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				Name = @"PartnershipParameterInsertedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(60, 255),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 145),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPartnershipParameterInsertedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePartnershipParameterInsertedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("68b36cd4-19a6-43ea-8945-e5e6f32bf77b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("58b2f32b-e174-4f81-8e17-e35ee3d4bfb6"),
				CreatedInOwnerSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e"),
				CreatedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PartnershipParameterInserted",
				ModifiedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				Name = @"PartnershipParameterInsertedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(34, 34),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePartnershipParameterInsertedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("374fe5a3-af87-4882-9854-eae1c144b7aa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("58b2f32b-e174-4f81-8e17-e35ee3d4bfb6"),
				CreatedInOwnerSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e"),
				CreatedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				Name = @"PartnershipParameterInsertedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(182, 20),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,143,209,10,130,64,16,69,159,245,43,22,159,86,8,127,192,10,68,52,131,168,94,250,128,205,157,106,65,71,153,157,69,36,250,247,86,122,209,124,187,92,230,114,206,152,135,144,55,11,148,119,136,80,179,233,48,57,0,31,109,9,138,29,65,129,234,222,128,150,209,47,92,26,125,85,196,8,100,95,166,63,117,79,83,71,113,44,222,97,48,171,43,104,122,32,209,255,55,97,16,236,68,222,40,107,75,85,115,71,227,68,218,174,134,123,137,48,8,239,99,153,220,116,151,209,211,181,128,44,35,183,16,141,54,98,105,30,199,105,184,162,38,153,214,103,24,102,24,31,85,11,12,84,25,59,105,200,2,217,240,232,199,159,144,192,127,141,194,147,33,253,2,212,92,154,71,27,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePartnershipParameterUpdatedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPartnershipParameterUpdatedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("29dd2f7c-7523-49f8-9c5c-a62b44831cc2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ccddd163-9fa9-4247-80c4-8ea544364286"),
				CreatedInOwnerSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb"),
				CreatedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				Name = @"PartnershipParameterUpdatedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 435),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(324, 145),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPartnershipParameterUpdatedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePartnershipParameterUpdatedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("17912aea-7fe8-482c-9bc0-5a51796a8e03"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("29dd2f7c-7523-49f8-9c5c-a62b44831cc2"),
				CreatedInOwnerSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb"),
				CreatedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PartnershipParameterUpdated",
				ModifiedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				Name = @"PartnershipParameterUpdated",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(31, 35),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePartnershipParameterUpdatedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2a4528d5-a40f-4568-8073-513e97b429d6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("29dd2f7c-7523-49f8-9c5c-a62b44831cc2"),
				CreatedInOwnerSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb"),
				CreatedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				Name = @"PartnershipParameterUpdatedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(206, 35),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,82,89,139,194,48,16,126,110,127,197,108,159,82,88,250,7,180,130,20,47,16,87,214,61,158,99,50,106,32,166,37,71,85,22,255,251,38,149,133,116,235,219,100,50,223,49,135,56,0,249,52,168,171,90,41,100,86,212,170,88,160,93,153,57,82,235,52,206,20,221,75,228,36,123,4,111,146,111,169,182,10,181,57,137,102,93,31,5,203,242,28,126,210,36,74,47,81,54,168,161,249,159,73,147,164,132,74,82,99,230,148,217,90,223,130,210,120,0,156,16,133,23,240,126,140,213,46,212,77,245,209,157,81,89,146,185,158,209,236,21,250,206,243,124,148,38,45,213,192,78,84,29,145,87,181,116,103,101,160,132,153,178,194,118,122,85,252,245,69,165,67,67,242,226,251,132,26,9,107,161,156,0,107,139,46,15,47,101,136,125,203,221,51,112,47,156,224,113,95,43,222,227,254,184,53,61,230,113,168,159,144,108,27,35,178,64,52,152,77,241,142,140,74,230,36,181,56,149,114,199,106,239,167,167,20,96,194,47,171,223,91,225,139,201,53,216,190,22,27,122,238,76,255,233,173,177,69,25,4,187,5,61,209,124,204,34,94,104,64,12,101,239,207,12,239,208,70,200,206,240,26,15,118,136,30,66,167,156,111,240,18,161,125,232,189,91,212,75,97,194,97,144,199,76,61,250,158,106,244,119,168,192,223,2,142,126,1,50,75,191,216,173,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePartnershipParameterSavingEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPartnershipParameterSavingEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f2bcb474-79f3-444c-8bf8-0cb3d691405b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ccddd163-9fa9-4247-80c4-8ea544364286"),
				CreatedInOwnerSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb"),
				CreatedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				Name = @"PartnershipParameterSavingEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(60, 55),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 145),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPartnershipParameterSavingEventSubProcess;
		}

		protected virtual ProcessSchemaScriptTask CreatePartnershipParameterSavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("200c319d-3dde-4996-b711-56bf8298a038"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f2bcb474-79f3-444c-8bf8-0cb3d691405b"),
				CreatedInOwnerSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb"),
				CreatedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				Name = @"PartnershipParameterSavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(182, 45),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,47,168,12,75,204,41,77,13,201,119,46,45,42,74,205,43,1,243,156,243,115,74,115,243,52,52,173,185,138,82,75,74,139,242,20,74,138,74,83,173,1,156,20,62,238,45,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePartnershipParameterSavingMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("72398059-48ca-4df6-a168-f36531810fb0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f2bcb474-79f3-444c-8bf8-0cb3d691405b"),
				CreatedInOwnerSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb"),
				CreatedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PartnershipParameterSaving",
				ModifiedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				Name = @"PartnershipParameterSavingMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(34, 59),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePartnershipParameterDeletingEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPartnershipParameterDeletingEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a95eee94-4968-4e28-84e2-811399ff1f21"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ccddd163-9fa9-4247-80c4-8ea544364286"),
				CreatedInOwnerSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039"),
				CreatedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				Name = @"PartnershipParameterDeletingEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(460, 160),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(313, 300),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPartnershipParameterDeletingEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePartnershipParameterDeletingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4bb52952-13a4-4c2f-8c8f-b26b3ba4eef5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a95eee94-4968-4e28-84e2-811399ff1f21"),
				CreatedInOwnerSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039"),
				CreatedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PartnershipParameterDeleting",
				ModifiedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				Name = @"PartnershipParameterDeleting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(40, 115),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePartnershipParameterDeletingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bac119b1-8369-42d0-aff0-ddfa09bd560e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a95eee94-4968-4e28-84e2-811399ff1f21"),
				CreatedInOwnerSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039"),
				CreatedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				Name = @"PartnershipParameterDeletingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(200, 101),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,143,221,10,130,64,16,133,175,245,41,22,175,86,136,94,192,10,162,44,131,160,32,122,128,77,79,182,176,142,50,59,18,18,189,123,43,221,244,115,55,28,206,225,251,198,94,149,62,123,240,170,37,66,41,182,165,233,22,178,243,27,24,233,25,57,153,139,67,165,147,247,113,112,213,209,176,16,216,223,108,183,111,107,91,38,105,170,30,113,244,17,23,112,29,88,117,191,73,28,69,115,181,114,198,251,141,41,165,229,97,36,205,254,134,11,77,184,171,224,227,133,251,177,183,228,186,111,64,162,147,254,75,52,153,168,111,243,52,205,226,63,234,244,4,9,12,211,64,192,133,245,35,56,167,106,109,4,58,39,177,50,132,213,51,102,132,119,73,5,36,178,23,51,149,203,37,20,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateCopyValueToCurrentValueColumnMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8360e463-41b5-41d2-843f-59f49671d0da"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("005ad3fb-44f2-4317-ae32-8e4b6c6b0bac"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("f43a6760-9275-4070-90a5-eacccad59d8c")
			});
		}

		protected override SchemaMethod CreateUpdateStringValueMethodMethod() {
			SchemaMethod method = base.CreateUpdateStringValueMethodMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCopyValueToCurrentValueColumnMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("991b12e1-5eed-4b5f-a655-a5a0ba6b812f"),
				Name = "CopyValueToCurrentValueColumn",
				CreatedInSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,205,106,195,48,16,132,207,246,83,44,58,201,16,242,0,78,234,210,152,54,237,37,24,146,22,122,84,236,109,34,42,75,70,63,13,166,244,221,43,217,129,218,113,8,189,217,163,153,111,118,183,96,218,74,212,230,200,155,103,20,13,106,104,38,202,29,228,130,25,243,196,74,171,116,59,95,163,93,22,151,166,140,74,60,65,174,164,177,218,5,223,131,62,184,26,165,165,196,25,212,254,65,98,105,185,146,100,6,175,35,33,73,22,241,218,241,42,20,179,26,45,234,55,38,28,238,218,6,95,42,223,253,40,45,183,93,107,144,170,92,9,87,203,206,178,12,177,140,146,226,74,144,120,170,31,133,203,3,148,127,137,141,247,121,228,100,197,64,207,199,182,85,27,64,244,218,80,1,125,226,182,60,2,189,96,39,240,29,71,37,51,8,100,165,148,64,214,63,145,52,142,162,47,166,97,239,197,78,185,189,215,57,155,77,240,11,207,57,231,182,163,137,41,201,157,214,254,220,125,223,108,208,116,15,239,104,230,59,181,237,174,65,19,72,97,163,6,255,29,116,175,145,125,250,143,10,63,152,19,54,253,119,207,141,45,250,243,79,151,24,22,254,252,2,76,234,232,0,128,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PartnershipParameter_PRMBase_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"));
		}

		#endregion

	}

	#endregion

}

