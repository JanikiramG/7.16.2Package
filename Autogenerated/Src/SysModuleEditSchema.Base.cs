﻿namespace Terrasoft.Configuration
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

	#region Class: SysModuleEditSchema

	/// <exclude/>
	public class SysModuleEditSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysModuleEditSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysModuleEditSchema(SysModuleEditSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysModuleEditSchema(SysModuleEditSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001");
			RealUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001");
			Name = "SysModuleEdit";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreatePageCaptionColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("f7b189f1-06c6-4b54-bb04-eaf91625177f")) == null) {
				Columns.Add(CreateSysModuleEntityColumn());
			}
			if (Columns.FindByUId(new Guid("56c33b79-2d9a-4b49-adb4-79df03d178e9")) == null) {
				Columns.Add(CreateTypeColumnValueColumn());
			}
			if (Columns.FindByUId(new Guid("c53035ba-426a-4b98-a5fa-2d2966b2c908")) == null) {
				Columns.Add(CreateUseModuleDetailsColumn());
			}
			if (Columns.FindByUId(new Guid("ca35057b-1338-4316-9d6f-8c35f98f5db5")) == null) {
				Columns.Add(CreatePositionColumn());
			}
			if (Columns.FindByUId(new Guid("a90e57e9-5e2c-40e8-80e2-3ac8b48f9619")) == null) {
				Columns.Add(CreateHelpContextIdColumn());
			}
			if (Columns.FindByUId(new Guid("ae683a77-0faf-4743-a1c2-abadf29f6e98")) == null) {
				Columns.Add(CreateSysPageSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("fcd5ccc3-2a7a-4a9d-b8b8-e78f76efe747")) == null) {
				Columns.Add(CreateCardSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("a19bf4bf-e22b-49b5-b6e0-918ff6290020")) == null) {
				Columns.Add(CreateActionKindCaptionColumn());
			}
			if (Columns.FindByUId(new Guid("f14f9a76-5ad3-47f9-b175-b7648b7bd340")) == null) {
				Columns.Add(CreateActionKindNameColumn());
			}
			if (Columns.FindByUId(new Guid("350ddc16-b017-4661-ae25-33482662a8d2")) == null) {
				Columns.Add(CreateMiniPageSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("9cf420d8-04d4-4c81-ac33-8d00dc0704b9")) == null) {
				Columns.Add(CreateSearchRowSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("a4fcaa97-6bfa-4e5e-a130-6a9515254107")) == null) {
				Columns.Add(CreateMiniPageModesColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysModuleEntityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f7b189f1-06c6-4b54-bb04-eaf91625177f"),
				Name = @"SysModuleEntity",
				ReferenceSchemaUId = new Guid("9c762665-90ad-497b-ac4b-45bb729630a1"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				ModifiedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumnValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("56c33b79-2d9a-4b49-adb4-79df03d178e9"),
				Name = @"TypeColumnValue",
				CreatedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				ModifiedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateUseModuleDetailsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("c53035ba-426a-4b98-a5fa-2d2966b2c908"),
				Name = @"UseModuleDetails",
				CreatedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				ModifiedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("ca35057b-1338-4316-9d6f-8c35f98f5db5"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				ModifiedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateHelpContextIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("a90e57e9-5e2c-40e8-80e2-3ac8b48f9619"),
				Name = @"HelpContextId",
				CreatedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				ModifiedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSysPageSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("ae683a77-0faf-4743-a1c2-abadf29f6e98"),
				Name = @"SysPageSchemaUId",
				CreatedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				ModifiedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCardSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("fcd5ccc3-2a7a-4a9d-b8b8-e78f76efe747"),
				Name = @"CardSchemaUId",
				CreatedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				ModifiedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			};
		}

		protected virtual EntitySchemaColumn CreateActionKindCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("a19bf4bf-e22b-49b5-b6e0-918ff6290020"),
				Name = @"ActionKindCaption",
				CreatedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				ModifiedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateActionKindNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("f14f9a76-5ad3-47f9-b175-b7648b7bd340"),
				Name = @"ActionKindName",
				CreatedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				ModifiedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			};
		}

		protected virtual EntitySchemaColumn CreatePageCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("55132174-2b96-4e0a-830c-b8e952b12c45"),
				Name = @"PageCaption",
				CreatedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				ModifiedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateMiniPageSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("350ddc16-b017-4661-ae25-33482662a8d2"),
				Name = @"MiniPageSchemaUId",
				CreatedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				ModifiedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				CreatedInPackageId = new Guid("40561dec-97e9-4817-b93e-dc5c85e54502")
			};
		}

		protected virtual EntitySchemaColumn CreateSearchRowSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("9cf420d8-04d4-4c81-ac33-8d00dc0704b9"),
				Name = @"SearchRowSchemaUId",
				CreatedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				ModifiedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateMiniPageModesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("a4fcaa97-6bfa-4e5e-a130-6a9515254107"),
				Name = @"MiniPageModes",
				CreatedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				ModifiedInSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001"),
				CreatedInPackageId = new Guid("06739286-487c-4c5b-9980-238a37b699a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysModuleEditEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysModuleEditEventsProcessSchema() {
			var schema = new SysModuleEditEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysModuleEdit(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysModuleEdit_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysModuleEditSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysModuleEditSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("24666f2d-049f-4867-ae2c-db681c40c001"));
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleEdit

	/// <summary>
	/// Section card.
	/// </summary>
	public class SysModuleEdit : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysModuleEdit(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysModuleEdit";
		}

		public SysModuleEdit(SysModuleEdit source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysModuleEntityId {
			get {
				return GetTypedColumnValue<Guid>("SysModuleEntityId");
			}
			set {
				SetColumnValue("SysModuleEntityId", value);
				_sysModuleEntity = null;
			}
		}

		private SysModuleEntity _sysModuleEntity;
		/// <summary>
		/// Section object.
		/// </summary>
		public SysModuleEntity SysModuleEntity {
			get {
				return _sysModuleEntity ??
					(_sysModuleEntity = LookupColumnEntities.GetEntity("SysModuleEntity") as SysModuleEntity);
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

		/// <summary>
		/// Use details of section.
		/// </summary>
		public bool UseModuleDetails {
			get {
				return GetTypedColumnValue<bool>("UseModuleDetails");
			}
			set {
				SetColumnValue("UseModuleDetails", value);
			}
		}

		/// <summary>
		/// Position.
		/// </summary>
		public int Position {
			get {
				return GetTypedColumnValue<int>("Position");
			}
			set {
				SetColumnValue("Position", value);
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
		/// Identifier of card page.
		/// </summary>
		public Guid SysPageSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("SysPageSchemaUId");
			}
			set {
				SetColumnValue("SysPageSchemaUId", value);
			}
		}

		/// <summary>
		/// Unique identifier of edit page schema.
		/// </summary>
		public Guid CardSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("CardSchemaUId");
			}
			set {
				SetColumnValue("CardSchemaUId", value);
			}
		}

		/// <summary>
		/// User task caption.
		/// </summary>
		public string ActionKindCaption {
			get {
				return GetTypedColumnValue<string>("ActionKindCaption");
			}
			set {
				SetColumnValue("ActionKindCaption", value);
			}
		}

		/// <summary>
		/// User task name.
		/// </summary>
		public string ActionKindName {
			get {
				return GetTypedColumnValue<string>("ActionKindName");
			}
			set {
				SetColumnValue("ActionKindName", value);
			}
		}

		/// <summary>
		/// Edit page caption.
		/// </summary>
		public string PageCaption {
			get {
				return GetTypedColumnValue<string>("PageCaption");
			}
			set {
				SetColumnValue("PageCaption", value);
			}
		}

		/// <summary>
		/// Unique identifier of mini page schema.
		/// </summary>
		public Guid MiniPageSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("MiniPageSchemaUId");
			}
			set {
				SetColumnValue("MiniPageSchemaUId", value);
			}
		}

		/// <summary>
		/// Unique identifier of schema for search row view .
		/// </summary>
		public Guid SearchRowSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("SearchRowSchemaUId");
			}
			set {
				SetColumnValue("SearchRowSchemaUId", value);
			}
		}

		/// <summary>
		/// Mini page modes.
		/// </summary>
		public string MiniPageModes {
			get {
				return GetTypedColumnValue<string>("MiniPageModes");
			}
			set {
				SetColumnValue("MiniPageModes", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysModuleEdit_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysModuleEditDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysModuleEditDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysModuleEditInserted", e);
			Inserting += (s, e) => ThrowEvent("SysModuleEditInserting", e);
			Saved += (s, e) => ThrowEvent("SysModuleEditSaved", e);
			Saving += (s, e) => ThrowEvent("SysModuleEditSaving", e);
			Validating += (s, e) => ThrowEvent("SysModuleEditValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleEdit(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleEdit_BaseEventsProcess

	/// <exclude/>
	public partial class SysModuleEdit_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysModuleEdit
	{

		public SysModuleEdit_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleEdit_BaseEventsProcess";
			SchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("24666f2d-049f-4867-ae2c-db681c40c001");
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

	#region Class: SysModuleEdit_BaseEventsProcess

	/// <exclude/>
	public class SysModuleEdit_BaseEventsProcess : SysModuleEdit_BaseEventsProcess<SysModuleEdit>
	{

		public SysModuleEdit_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleEdit_BaseEventsProcess

	public partial class SysModuleEdit_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysModuleEditEventsProcessSchema

	/// <exclude/>
	public class SysModuleEditEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysModuleEditEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysModuleEditEventsProcessSchema(SysModuleEditEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysModuleEdit_BaseEventsProcess";
			UId = new Guid("a36fb202-818e-47e1-b149-ab739429c93b");
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
			return new SysModuleEditEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a36fb202-818e-47e1-b149-ab739429c93b"));
		}

		#endregion

	}

	#endregion


	#region Class: SysModuleEditEventsProcess

	/// <exclude/>
	public class SysModuleEditEventsProcess : SysModuleEdit_BaseEventsProcess
	{

		public SysModuleEditEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

