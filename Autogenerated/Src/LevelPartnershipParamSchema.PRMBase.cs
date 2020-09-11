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

	#region Class: LevelPartnershipParamSchema

	/// <exclude/>
	public class LevelPartnershipParamSchema : Terrasoft.Configuration.SpecificationInObjectSchema
	{

		#region Constructors: Public

		public LevelPartnershipParamSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LevelPartnershipParamSchema(LevelPartnershipParamSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LevelPartnershipParamSchema(LevelPartnershipParamSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIX_Type_Category_LevelIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("7ee36c6e-e5f8-4e00-a5d8-fcb96c868edd");
			index.Name = "IX_Type_Category_Level";
			index.CreatedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02");
			index.ModifiedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02");
			index.CreatedInPackageId = new Guid("6f0ddd54-2f1a-468d-afb8-9805de4678f7");
			EntitySchemaIndexColumn parameterTypeIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("366c3486-b99d-4f68-a222-059423fdbbc2"),
				ColumnUId = new Guid("a5778b0b-b937-41ac-a4d7-0c64ecc0f05a"),
				CreatedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"),
				ModifiedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"),
				CreatedInPackageId = new Guid("6f0ddd54-2f1a-468d-afb8-9805de4678f7"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(parameterTypeIdIndexColumn);
			EntitySchemaIndexColumn partnerParamCategoryIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("21e26266-6da3-425e-97f5-33154709ea15"),
				ColumnUId = new Guid("d608765d-801d-4f7c-8c30-4d7ef78714f8"),
				CreatedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"),
				ModifiedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"),
				CreatedInPackageId = new Guid("6f0ddd54-2f1a-468d-afb8-9805de4678f7"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(partnerParamCategoryIdIndexColumn);
			EntitySchemaIndexColumn partnerLevelIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("1c03279b-3fdd-4550-9092-c1a64433667b"),
				ColumnUId = new Guid("c63f6117-889a-4392-9f96-e3481b37bc80"),
				CreatedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"),
				ModifiedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"),
				CreatedInPackageId = new Guid("6f0ddd54-2f1a-468d-afb8-9805de4678f7"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(partnerLevelIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02");
			RealUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02");
			Name = "LevelPartnershipParam";
			ParentSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			ExtendParent = false;
			CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = true;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a5778b0b-b937-41ac-a4d7-0c64ecc0f05a")) == null) {
				Columns.Add(CreateParameterTypeColumn());
			}
			if (Columns.FindByUId(new Guid("d608765d-801d-4f7c-8c30-4d7ef78714f8")) == null) {
				Columns.Add(CreatePartnerParamCategoryColumn());
			}
			if (Columns.FindByUId(new Guid("166fe5b5-da1f-468f-a10b-979518bacb54")) == null) {
				Columns.Add(CreateScoreColumn());
			}
			if (Columns.FindByUId(new Guid("34e4df89-d84c-442e-ba6f-27bdca7e44f0")) == null) {
				Columns.Add(CreateNameColumn());
			}
			if (Columns.FindByUId(new Guid("4115c82b-4097-425b-977d-72cd78a597d1")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("ca8ad119-a755-403c-b4aa-44040a467a8a")) == null) {
				Columns.Add(CreateDueDateColumn());
			}
			if (Columns.FindByUId(new Guid("c63f6117-889a-4392-9f96-e3481b37bc80")) == null) {
				Columns.Add(CreatePartnerLevelColumn());
			}
			if (Columns.FindByUId(new Guid("238028dc-4139-48a6-82a8-9e862ec8cf28")) == null) {
				Columns.Add(CreateParameterValueTypeColumn());
			}
			if (Columns.FindByUId(new Guid("7127ee6d-6f5e-4c97-b2fa-fece79aa8bf6")) == null) {
				Columns.Add(CreateGuidValueColumn());
			}
		}

		protected override EntitySchemaColumn CreateFloatValueColumn() {
			EntitySchemaColumn column = base.CreateFloatValueColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("Float3");
			column.ModifiedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02");
			return column;
		}

		protected override EntitySchemaColumn CreateSpecificationColumn() {
			EntitySchemaColumn column = base.CreateSpecificationColumn();
			column.RequirementType = EntitySchemaColumnRequirementType.None;
			column.ModifiedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02");
			return column;
		}

		protected virtual EntitySchemaColumn CreateParameterTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a5778b0b-b937-41ac-a4d7-0c64ecc0f05a"),
				Name = @"ParameterType",
				ReferenceSchemaUId = new Guid("ab9ef8b5-8cff-4a02-88e8-a6e8e926f152"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"),
				ModifiedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb")
			};
		}

		protected virtual EntitySchemaColumn CreatePartnerParamCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d608765d-801d-4f7c-8c30-4d7ef78714f8"),
				Name = @"PartnerParamCategory",
				ReferenceSchemaUId = new Guid("7a91ebee-2015-4ee4-bc69-12fb6a22ad6e"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"),
				ModifiedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb")
			};
		}

		protected virtual EntitySchemaColumn CreateScoreColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("166fe5b5-da1f-468f-a10b-979518bacb54"),
				Name = @"Score",
				CreatedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"),
				ModifiedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("34e4df89-d84c-442e-ba6f-27bdca7e44f0"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"),
				ModifiedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb")
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("4115c82b-4097-425b-977d-72cd78a597d1"),
				Name = @"StartDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"),
				ModifiedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb")
			};
		}

		protected virtual EntitySchemaColumn CreateDueDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("ca8ad119-a755-403c-b4aa-44040a467a8a"),
				Name = @"DueDate",
				CreatedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"),
				ModifiedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb")
			};
		}

		protected virtual EntitySchemaColumn CreatePartnerLevelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c63f6117-889a-4392-9f96-e3481b37bc80"),
				Name = @"PartnerLevel",
				ReferenceSchemaUId = new Guid("0e098241-437e-4443-b864-0c5cc0cd1a80"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"),
				ModifiedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb")
			};
		}

		protected virtual EntitySchemaColumn CreateParameterValueTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("238028dc-4139-48a6-82a8-9e862ec8cf28"),
				Name = @"ParameterValueType",
				ReferenceSchemaUId = new Guid("787ae6a1-f727-4c4e-964a-c09e24083810"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"),
				ModifiedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb")
			};
		}

		protected virtual EntitySchemaColumn CreateGuidValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("7127ee6d-6f5e-4c97-b2fa-fece79aa8bf6"),
				Name = @"GuidValue",
				CreatedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"),
				ModifiedInSchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"),
				CreatedInPackageId = new Guid("6f0ddd54-2f1a-468d-afb8-9805de4678f7")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIX_Type_Category_LevelIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLevelPartnershipParamEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateLevelPartnershipParamEventsProcessSchema() {
			var schema = new LevelPartnershipParamEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LevelPartnershipParam(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LevelPartnershipParam_PRMBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LevelPartnershipParamSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LevelPartnershipParamSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02"));
		}

		#endregion

	}

	#endregion

	#region Class: LevelPartnershipParam

	/// <summary>
	/// LevelPartnershipParam.
	/// </summary>
	public class LevelPartnershipParam : Terrasoft.Configuration.SpecificationInObject
	{

		#region Constructors: Public

		public LevelPartnershipParam(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LevelPartnershipParam";
		}

		public LevelPartnershipParam(LevelPartnershipParam source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
		/// Parameter Type.
		/// </summary>
		public ParameterType ParameterType {
			get {
				return _parameterType ??
					(_parameterType = LookupColumnEntities.GetEntity("ParameterType") as ParameterType);
			}
		}

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
		/// Partner Param Category.
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

		/// <summary>
		/// StartDate.
		/// </summary>
		public DateTime StartDate {
			get {
				return GetTypedColumnValue<DateTime>("StartDate");
			}
			set {
				SetColumnValue("StartDate", value);
			}
		}

		/// <summary>
		/// DueDate.
		/// </summary>
		public DateTime DueDate {
			get {
				return GetTypedColumnValue<DateTime>("DueDate");
			}
			set {
				SetColumnValue("DueDate", value);
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
		/// Partner Level.
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
			var process = new LevelPartnershipParam_PRMBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("LevelPartnershipParamDeleted", e);
			Validating += (s, e) => ThrowEvent("LevelPartnershipParamValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LevelPartnershipParam(this);
		}

		#endregion

	}

	#endregion

	#region Class: LevelPartnershipParam_PRMBaseEventsProcess

	/// <exclude/>
	public partial class LevelPartnershipParam_PRMBaseEventsProcess<TEntity> : Terrasoft.Configuration.SpecificationInObject_SpecificationEventsProcess<TEntity> where TEntity : LevelPartnershipParam
	{

		public LevelPartnershipParam_PRMBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LevelPartnershipParam_PRMBaseEventsProcess";
			SchemaUId = new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3ecb12bd-fc78-4b4c-acb9-e846918c8a02");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_d0dcca1dbaaa418598629955476a9a20;
		public ProcessFlowElement EventSubProcess3_d0dcca1dbaaa418598629955476a9a20 {
			get {
				return _eventSubProcess3_d0dcca1dbaaa418598629955476a9a20 ?? (_eventSubProcess3_d0dcca1dbaaa418598629955476a9a20 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_d0dcca1dbaaa418598629955476a9a20",
					SchemaElementUId = new Guid("d0dcca1d-baaa-4185-9862-9955476a9a20"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_1e31c06892df417aa6ebf6cbdcf32e7d;
		public ProcessScriptTask ScriptTask3_1e31c06892df417aa6ebf6cbdcf32e7d {
			get {
				return _scriptTask3_1e31c06892df417aa6ebf6cbdcf32e7d ?? (_scriptTask3_1e31c06892df417aa6ebf6cbdcf32e7d = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_1e31c06892df417aa6ebf6cbdcf32e7d",
					SchemaElementUId = new Guid("1e31c068-92df-417a-a6eb-f6cbdcf32e7d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_1e31c06892df417aa6ebf6cbdcf32e7dExecute,
				});
			}
		}

		private ProcessFlowElement _validating_StartMessage3_6404d648f597427390bfbfacffed9a2b;
		public ProcessFlowElement Validating_StartMessage3_6404d648f597427390bfbfacffed9a2b {
			get {
				return _validating_StartMessage3_6404d648f597427390bfbfacffed9a2b ?? (_validating_StartMessage3_6404d648f597427390bfbfacffed9a2b = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "Validating_StartMessage3_6404d648f597427390bfbfacffed9a2b",
					SchemaElementUId = new Guid("6404d648-f597-4273-90bf-bfacffed9a2b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private LocalizableString _duplicatesValidationExceptionMessage;
		public LocalizableString DuplicatesValidationExceptionMessage {
			get {
				return _duplicatesValidationExceptionMessage ?? (_duplicatesValidationExceptionMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DuplicatesValidationExceptionMessage.Value"));
			}
		}

		private LocalizableString _wrongDatesExceptionMessage;
		public LocalizableString WrongDatesExceptionMessage {
			get {
				return _wrongDatesExceptionMessage ?? (_wrongDatesExceptionMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.WrongDatesExceptionMessage.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_d0dcca1dbaaa418598629955476a9a20.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_d0dcca1dbaaa418598629955476a9a20 };
			FlowElements[ScriptTask3_1e31c06892df417aa6ebf6cbdcf32e7d.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_1e31c06892df417aa6ebf6cbdcf32e7d };
			FlowElements[Validating_StartMessage3_6404d648f597427390bfbfacffed9a2b.SchemaElementUId] = new Collection<ProcessFlowElement> { Validating_StartMessage3_6404d648f597427390bfbfacffed9a2b };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_d0dcca1dbaaa418598629955476a9a20":
						break;
					case "ScriptTask3_1e31c06892df417aa6ebf6cbdcf32e7d":
						break;
					case "Validating_StartMessage3_6404d648f597427390bfbfacffed9a2b":
						e.Context.QueueTasks.Enqueue("ScriptTask3_1e31c06892df417aa6ebf6cbdcf32e7d");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("Validating_StartMessage3_6404d648f597427390bfbfacffed9a2b");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_d0dcca1dbaaa418598629955476a9a20":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptTask3_1e31c06892df417aa6ebf6cbdcf32e7d":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_1e31c06892df417aa6ebf6cbdcf32e7d";
					result = ScriptTask3_1e31c06892df417aa6ebf6cbdcf32e7d.Execute(context, ScriptTask3_1e31c06892df417aa6ebf6cbdcf32e7dExecute);
					break;
				case "Validating_StartMessage3_6404d648f597427390bfbfacffed9a2b":
					context.QueueTasks.Dequeue();
					context.SenderName = "Validating_StartMessage3_6404d648f597427390bfbfacffed9a2b";
					result = Validating_StartMessage3_6404d648f597427390bfbfacffed9a2b.Execute(context);
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

		public virtual bool ScriptTask3_1e31c06892df417aa6ebf6cbdcf32e7dExecute(ProcessExecutingContext context) {
				CheckDates(Entity);
				CheckIsDuplicated(Entity);
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "LevelPartnershipParamValidating":
							if (ActivatedEventElements.Contains("Validating_StartMessage3_6404d648f597427390bfbfacffed9a2b")) {
							context.QueueTasks.Enqueue("Validating_StartMessage3_6404d648f597427390bfbfacffed9a2b");
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

	#region Class: LevelPartnershipParam_PRMBaseEventsProcess

	/// <exclude/>
	public class LevelPartnershipParam_PRMBaseEventsProcess : LevelPartnershipParam_PRMBaseEventsProcess<LevelPartnershipParam>
	{

		public LevelPartnershipParam_PRMBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LevelPartnershipParamEventsProcessSchema

	/// <exclude/>
	public class LevelPartnershipParamEventsProcessSchema : Terrasoft.Configuration.SpecificationInObjectEventsProcessSchema
	{

		#region Constructors: Public

		public LevelPartnershipParamEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LevelPartnershipParamEventsProcessSchema(LevelPartnershipParamEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LevelPartnershipParam_PRMBaseEventsProcess";
			UId = new Guid("aa4f23ef-168e-4a29-811a-c114a36c37c7");
			CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
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
			ProcessSchemaLaneSet schemaLaneSet_f72b2d736bba4e388085c1dd8f73a877 = CreateLaneSet_f72b2d736bba4e388085c1dd8f73a877LaneSet();
			LaneSets.Add(schemaLaneSet_f72b2d736bba4e388085c1dd8f73a877);
			ProcessSchemaLane schemaLane_d26d5ce4fb3d4595975d6323c354f0c0 = CreateLane_d26d5ce4fb3d4595975d6323c354f0c0Lane();
			schemaLaneSet_f72b2d736bba4e388085c1dd8f73a877.Lanes.Add(schemaLane_d26d5ce4fb3d4595975d6323c354f0c0);
			ProcessSchemaEventSubProcess eventsubprocess3_d0dcca1dbaaa418598629955476a9a20 = CreateEventSubProcess3_d0dcca1dbaaa418598629955476a9a20EventSubProcess();
			FlowElements.Add(eventsubprocess3_d0dcca1dbaaa418598629955476a9a20);
			ProcessSchemaScriptTask scripttask3_1e31c06892df417aa6ebf6cbdcf32e7d = CreateScriptTask3_1e31c06892df417aa6ebf6cbdcf32e7dScriptTask();
			eventsubprocess3_d0dcca1dbaaa418598629955476a9a20.FlowElements.Add(scripttask3_1e31c06892df417aa6ebf6cbdcf32e7d);
			ProcessSchemaStartMessageEvent validating_startmessage3_6404d648f597427390bfbfacffed9a2b = CreateValidating_StartMessage3_6404d648f597427390bfbfacffed9a2bStartMessageEvent();
			eventsubprocess3_d0dcca1dbaaa418598629955476a9a20.FlowElements.Add(validating_startmessage3_6404d648f597427390bfbfacffed9a2b);
			FlowElements.Add(CreateSequenceFlow4_307d6dacc44a4080b1e06f778910c08bSequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateDuplicatesValidationExceptionMessageLocalizableString());
			LocalizableStrings.Add(CreateWrongDatesExceptionMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateDuplicatesValidationExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e69bbbd3-9799-4d2c-b1d6-f96df6284305"),
				Name = "DuplicatesValidationExceptionMessage",
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb"),
				CreatedInSchemaUId = new Guid("aa4f23ef-168e-4a29-811a-c114a36c37c7"),
				ModifiedInSchemaUId = new Guid("aa4f23ef-168e-4a29-811a-c114a36c37c7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWrongDatesExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("78ed3905-f84b-4954-9070-b11b4b7ea127"),
				Name = "WrongDatesExceptionMessage",
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb"),
				CreatedInSchemaUId = new Guid("aa4f23ef-168e-4a29-811a-c114a36c37c7"),
				ModifiedInSchemaUId = new Guid("aa4f23ef-168e-4a29-811a-c114a36c37c7")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4_307d6dacc44a4080b1e06f778910c08bSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4_307d6dacc44a4080b1e06f778910c08b",
				UId = new Guid("307d6dac-c44a-4080-b1e0-6f778910c08b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				CreatedInPackageId = new Guid("62e2670f-4c32-43aa-bc37-36955a5d8127"),
				CreatedInSchemaUId = new Guid("aa4f23ef-168e-4a29-811a-c114a36c37c7"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("aa4f23ef-168e-4a29-811a-c114a36c37c7"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6404d648-f597-4273-90bf-bfacffed9a2b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1e31c068-92df-417a-a6eb-f6cbdcf32e7d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet_f72b2d736bba4e388085c1dd8f73a877LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet_f72b2d736bba4e388085c1dd8f73a877 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("f72b2d73-6bba-4e38-8085-c1dd8f73a877"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				CreatedInPackageId = new Guid("62e2670f-4c32-43aa-bc37-36955a5d8127"),
				CreatedInSchemaUId = new Guid("aa4f23ef-168e-4a29-811a-c114a36c37c7"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("aa4f23ef-168e-4a29-811a-c114a36c37c7"),
				Name = @"LaneSet_f72b2d736bba4e388085c1dd8f73a877",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(0, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet_f72b2d736bba4e388085c1dd8f73a877;
		}

		protected virtual ProcessSchemaLane CreateLane_d26d5ce4fb3d4595975d6323c354f0c0Lane() {
			ProcessSchemaLane schemaLane_d26d5ce4fb3d4595975d6323c354f0c0 = new ProcessSchemaLane(this) {
				UId = new Guid("d26d5ce4-fb3d-4595-975d-6323c354f0c0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f72b2d73-6bba-4e38-8085-c1dd8f73a877"),
				CreatedInOwnerSchemaUId = new Guid("aa4f23ef-168e-4a29-811a-c114a36c37c7"),
				CreatedInPackageId = new Guid("62e2670f-4c32-43aa-bc37-36955a5d8127"),
				CreatedInSchemaUId = new Guid("aa4f23ef-168e-4a29-811a-c114a36c37c7"),
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("aa4f23ef-168e-4a29-811a-c114a36c37c7"),
				Name = @"Lane_d26d5ce4fb3d4595975d6323c354f0c0",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane_d26d5ce4fb3d4595975d6323c354f0c0;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3_d0dcca1dbaaa418598629955476a9a20EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3_d0dcca1dbaaa418598629955476a9a20 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d0dcca1d-baaa-4185-9862-9955476a9a20"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d26d5ce4-fb3d-4595-975d-6323c354f0c0"),
				CreatedInOwnerSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				CreatedInPackageId = new Guid("62e2670f-4c32-43aa-bc37-36955a5d8127"),
				CreatedInSchemaUId = new Guid("aa4f23ef-168e-4a29-811a-c114a36c37c7"),
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("aa4f23ef-168e-4a29-811a-c114a36c37c7"),
				Name = @"EventSubProcess3_d0dcca1dbaaa418598629955476a9a20",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(700, 220),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3_d0dcca1dbaaa418598629955476a9a20;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3_1e31c06892df417aa6ebf6cbdcf32e7dScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1e31c068-92df-417a-a6eb-f6cbdcf32e7d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0dcca1d-baaa-4185-9862-9955476a9a20"),
				CreatedInOwnerSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				CreatedInPackageId = new Guid("62e2670f-4c32-43aa-bc37-36955a5d8127"),
				CreatedInSchemaUId = new Guid("aa4f23ef-168e-4a29-811a-c114a36c37c7"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("aa4f23ef-168e-4a29-811a-c114a36c37c7"),
				Name = @"ScriptTask3_1e31c06892df417aa6ebf6cbdcf32e7d",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(191, 70),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = true,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,227,116,206,72,77,206,118,73,44,73,45,214,112,205,43,201,44,169,212,180,230,226,4,11,122,22,187,148,22,228,100,38,3,229,82,16,114,69,169,37,165,69,121,10,37,69,165,169,214,0,4,222,168,112,61,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateValidating_StartMessage3_6404d648f597427390bfbfacffed9a2bStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6404d648-f597-4273-90bf-bfacffed9a2b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0dcca1d-baaa-4185-9862-9955476a9a20"),
				CreatedInOwnerSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				CreatedInPackageId = new Guid("62e2670f-4c32-43aa-bc37-36955a5d8127"),
				CreatedInSchemaUId = new Guid("aa4f23ef-168e-4a29-811a-c114a36c37c7"),
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"LevelPartnershipParamValidating",
				ModifiedInSchemaUId = new Guid("aa4f23ef-168e-4a29-811a-c114a36c37c7"),
				Name = @"Validating_StartMessage3_6404d648f597427390bfbfacffed9a2b",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(62, 84),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
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
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LevelPartnershipParamEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aa4f23ef-168e-4a29-811a-c114a36c37c7"));
		}

		#endregion

	}

	#endregion


	#region Class: LevelPartnershipParamEventsProcess

	/// <exclude/>
	public class LevelPartnershipParamEventsProcess : LevelPartnershipParam_PRMBaseEventsProcess
	{

		public LevelPartnershipParamEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

