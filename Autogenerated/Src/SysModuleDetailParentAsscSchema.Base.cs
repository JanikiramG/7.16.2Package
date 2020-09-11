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

	#region Class: SysModuleDetailParentAsscSchema

	/// <exclude/>
	public class SysModuleDetailParentAsscSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysModuleDetailParentAsscSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysModuleDetailParentAsscSchema(SysModuleDetailParentAsscSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysModuleDetailParentAsscSchema(SysModuleDetailParentAsscSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d6facb3e-bfdd-42b0-84ad-0b6fc4efcc4a");
			RealUId = new Guid("d6facb3e-bfdd-42b0-84ad-0b6fc4efcc4a");
			Name = "SysModuleDetailParentAssc";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("409a4029-8e03-4311-abff-2e90e67f1278")) == null) {
				Columns.Add(CreateSysModuleDetailColumn());
			}
			if (Columns.FindByUId(new Guid("5b8011d0-ab25-4bd3-af7f-324de8bdcb9d")) == null) {
				Columns.Add(CreateColumnMetaPathColumn());
			}
			if (Columns.FindByUId(new Guid("d4ba8734-5856-4590-9c08-bc69c0045e80")) == null) {
				Columns.Add(CreateParentColumnMetaPathColumn());
			}
			if (Columns.FindByUId(new Guid("532f9d91-9e4d-4529-87fe-e3134b350613")) == null) {
				Columns.Add(CreateSysParentAssociationTypeColumn());
			}
			if (Columns.FindByUId(new Guid("d3fc50dc-6e97-4d26-99b7-8ecbb1b5cdca")) == null) {
				Columns.Add(CreateColumnCaptionColumn());
			}
			if (Columns.FindByUId(new Guid("4410aff7-71fb-49e9-9a60-13f48da30bc9")) == null) {
				Columns.Add(CreateParentColumnCaptionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysModuleDetailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("409a4029-8e03-4311-abff-2e90e67f1278"),
				Name = @"SysModuleDetail",
				ReferenceSchemaUId = new Guid("fac3d18a-97ac-4d97-8997-31241d391675"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("d6facb3e-bfdd-42b0-84ad-0b6fc4efcc4a"),
				ModifiedInSchemaUId = new Guid("d6facb3e-bfdd-42b0-84ad-0b6fc4efcc4a"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnMetaPathColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("5b8011d0-ab25-4bd3-af7f-324de8bdcb9d"),
				Name = @"ColumnMetaPath",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("d6facb3e-bfdd-42b0-84ad-0b6fc4efcc4a"),
				ModifiedInSchemaUId = new Guid("d6facb3e-bfdd-42b0-84ad-0b6fc4efcc4a"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateParentColumnMetaPathColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("d4ba8734-5856-4590-9c08-bc69c0045e80"),
				Name = @"ParentColumnMetaPath",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("d6facb3e-bfdd-42b0-84ad-0b6fc4efcc4a"),
				ModifiedInSchemaUId = new Guid("d6facb3e-bfdd-42b0-84ad-0b6fc4efcc4a"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateSysParentAssociationTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("532f9d91-9e4d-4529-87fe-e3134b350613"),
				Name = @"SysParentAssociationType",
				ReferenceSchemaUId = new Guid("4e846bca-f751-4fd9-9059-1707707b9d9d"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("d6facb3e-bfdd-42b0-84ad-0b6fc4efcc4a"),
				ModifiedInSchemaUId = new Guid("d6facb3e-bfdd-42b0-84ad-0b6fc4efcc4a"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("d3fc50dc-6e97-4d26-99b7-8ecbb1b5cdca"),
				Name = @"ColumnCaption",
				CreatedInSchemaUId = new Guid("d6facb3e-bfdd-42b0-84ad-0b6fc4efcc4a"),
				ModifiedInSchemaUId = new Guid("d6facb3e-bfdd-42b0-84ad-0b6fc4efcc4a"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateParentColumnCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("4410aff7-71fb-49e9-9a60-13f48da30bc9"),
				Name = @"ParentColumnCaption",
				CreatedInSchemaUId = new Guid("d6facb3e-bfdd-42b0-84ad-0b6fc4efcc4a"),
				ModifiedInSchemaUId = new Guid("d6facb3e-bfdd-42b0-84ad-0b6fc4efcc4a"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysModuleDetailParentAsscEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysModuleDetailParentAsscEventsProcessSchema() {
			var schema = new SysModuleDetailParentAsscEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysModuleDetailParentAssc(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysModuleDetailParentAssc_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysModuleDetailParentAsscSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysModuleDetailParentAsscSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d6facb3e-bfdd-42b0-84ad-0b6fc4efcc4a"));
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleDetailParentAssc

	/// <summary>
	/// Detail parent connection.
	/// </summary>
	public class SysModuleDetailParentAssc : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysModuleDetailParentAssc(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysModuleDetailParentAssc";
		}

		public SysModuleDetailParentAssc(SysModuleDetailParentAssc source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysModuleDetailId {
			get {
				return GetTypedColumnValue<Guid>("SysModuleDetailId");
			}
			set {
				SetColumnValue("SysModuleDetailId", value);
				_sysModuleDetail = null;
			}
		}

		/// <exclude/>
		public string SysModuleDetailCaption {
			get {
				return GetTypedColumnValue<string>("SysModuleDetailCaption");
			}
			set {
				SetColumnValue("SysModuleDetailCaption", value);
				if (_sysModuleDetail != null) {
					_sysModuleDetail.Caption = value;
				}
			}
		}

		private SysModuleDetail _sysModuleDetail;
		/// <summary>
		/// Detail.
		/// </summary>
		public SysModuleDetail SysModuleDetail {
			get {
				return _sysModuleDetail ??
					(_sysModuleDetail = LookupColumnEntities.GetEntity("SysModuleDetail") as SysModuleDetail);
			}
		}

		/// <summary>
		/// Column path.
		/// </summary>
		public string ColumnMetaPath {
			get {
				return GetTypedColumnValue<string>("ColumnMetaPath");
			}
			set {
				SetColumnValue("ColumnMetaPath", value);
			}
		}

		/// <summary>
		/// Path to parent column.
		/// </summary>
		public string ParentColumnMetaPath {
			get {
				return GetTypedColumnValue<string>("ParentColumnMetaPath");
			}
			set {
				SetColumnValue("ParentColumnMetaPath", value);
			}
		}

		/// <exclude/>
		public Guid SysParentAssociationTypeId {
			get {
				return GetTypedColumnValue<Guid>("SysParentAssociationTypeId");
			}
			set {
				SetColumnValue("SysParentAssociationTypeId", value);
				_sysParentAssociationType = null;
			}
		}

		/// <exclude/>
		public string SysParentAssociationTypeName {
			get {
				return GetTypedColumnValue<string>("SysParentAssociationTypeName");
			}
			set {
				SetColumnValue("SysParentAssociationTypeName", value);
				if (_sysParentAssociationType != null) {
					_sysParentAssociationType.Name = value;
				}
			}
		}

		private SysParentAssociationType _sysParentAssociationType;
		/// <summary>
		/// Parent connection type.
		/// </summary>
		public SysParentAssociationType SysParentAssociationType {
			get {
				return _sysParentAssociationType ??
					(_sysParentAssociationType = LookupColumnEntities.GetEntity("SysParentAssociationType") as SysParentAssociationType);
			}
		}

		/// <summary>
		/// Detail column.
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
		/// Parent object column.
		/// </summary>
		public string ParentColumnCaption {
			get {
				return GetTypedColumnValue<string>("ParentColumnCaption");
			}
			set {
				SetColumnValue("ParentColumnCaption", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysModuleDetailParentAssc_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysModuleDetailParentAsscDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysModuleDetailParentAsscDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysModuleDetailParentAsscInserted", e);
			Inserting += (s, e) => ThrowEvent("SysModuleDetailParentAsscInserting", e);
			Saved += (s, e) => ThrowEvent("SysModuleDetailParentAsscSaved", e);
			Saving += (s, e) => ThrowEvent("SysModuleDetailParentAsscSaving", e);
			Validating += (s, e) => ThrowEvent("SysModuleDetailParentAsscValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleDetailParentAssc(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleDetailParentAssc_BaseEventsProcess

	/// <exclude/>
	public partial class SysModuleDetailParentAssc_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysModuleDetailParentAssc
	{

		public SysModuleDetailParentAssc_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleDetailParentAssc_BaseEventsProcess";
			SchemaUId = new Guid("d6facb3e-bfdd-42b0-84ad-0b6fc4efcc4a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d6facb3e-bfdd-42b0-84ad-0b6fc4efcc4a");
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

	#region Class: SysModuleDetailParentAssc_BaseEventsProcess

	/// <exclude/>
	public class SysModuleDetailParentAssc_BaseEventsProcess : SysModuleDetailParentAssc_BaseEventsProcess<SysModuleDetailParentAssc>
	{

		public SysModuleDetailParentAssc_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleDetailParentAssc_BaseEventsProcess

	public partial class SysModuleDetailParentAssc_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysModuleDetailParentAsscEventsProcessSchema

	/// <exclude/>
	public class SysModuleDetailParentAsscEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysModuleDetailParentAsscEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysModuleDetailParentAsscEventsProcessSchema(SysModuleDetailParentAsscEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysModuleDetailParentAssc_BaseEventsProcess";
			UId = new Guid("3913458c-821a-4656-b4df-6fb08790e901");
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
			return new SysModuleDetailParentAsscEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3913458c-821a-4656-b4df-6fb08790e901"));
		}

		#endregion

	}

	#endregion


	#region Class: SysModuleDetailParentAsscEventsProcess

	/// <exclude/>
	public class SysModuleDetailParentAsscEventsProcess : SysModuleDetailParentAssc_BaseEventsProcess
	{

		public SysModuleDetailParentAsscEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

