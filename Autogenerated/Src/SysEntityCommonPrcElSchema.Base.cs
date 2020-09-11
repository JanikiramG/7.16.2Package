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

	#region Class: SysEntityCommonPrcElSchema

	/// <exclude/>
	public class SysEntityCommonPrcElSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysEntityCommonPrcElSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysEntityCommonPrcElSchema(SysEntityCommonPrcElSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysEntityCommonPrcElSchema(SysEntityCommonPrcElSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6522ab5b-d5b7-4f10-9f18-6ad2af4bd0aa");
			RealUId = new Guid("6522ab5b-d5b7-4f10-9f18-6ad2af4bd0aa");
			Name = "SysEntityCommonPrcEl";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("2fb1dd9a-631b-4de5-848b-864da401622e")) == null) {
				Columns.Add(CreateRecordIdColumn());
			}
			if (Columns.FindByUId(new Guid("4221321d-f854-4a7a-a5bf-79ccb6e0c25f")) == null) {
				Columns.Add(CreateProcessElementColumn());
			}
			if (Columns.FindByUId(new Guid("ed345527-3139-4274-885d-c79980210801")) == null) {
				Columns.Add(CreateConditionDataColumn());
			}
			if (Columns.FindByUId(new Guid("1fe74aef-615c-42eb-9a90-489a49b4d78c")) == null) {
				Columns.Add(CreateChangedColumnsColumn());
			}
			if (Columns.FindByUId(new Guid("75a9960c-432d-4b4a-ac8a-2c9fd5a902b8")) == null) {
				Columns.Add(CreateRecordChangeTypeColumn());
			}
			if (Columns.FindByUId(new Guid("6d61aa94-cfae-4c1f-8eb8-f7e393a6257a")) == null) {
				Columns.Add(CreateEntitySchemaUIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateRecordIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("2fb1dd9a-631b-4de5-848b-864da401622e"),
				Name = @"RecordId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("6522ab5b-d5b7-4f10-9f18-6ad2af4bd0aa"),
				ModifiedInSchemaUId = new Guid("6522ab5b-d5b7-4f10-9f18-6ad2af4bd0aa"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateProcessElementColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4221321d-f854-4a7a-a5bf-79ccb6e0c25f"),
				Name = @"ProcessElement",
				ReferenceSchemaUId = new Guid("a195aa99-8c5b-47e0-a9a6-9bac0ddd5bd0"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("6522ab5b-d5b7-4f10-9f18-6ad2af4bd0aa"),
				ModifiedInSchemaUId = new Guid("6522ab5b-d5b7-4f10-9f18-6ad2af4bd0aa"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateConditionDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("ed345527-3139-4274-885d-c79980210801"),
				Name = @"ConditionData",
				CreatedInSchemaUId = new Guid("6522ab5b-d5b7-4f10-9f18-6ad2af4bd0aa"),
				ModifiedInSchemaUId = new Guid("6522ab5b-d5b7-4f10-9f18-6ad2af4bd0aa"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateChangedColumnsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("1fe74aef-615c-42eb-9a90-489a49b4d78c"),
				Name = @"ChangedColumns",
				CreatedInSchemaUId = new Guid("6522ab5b-d5b7-4f10-9f18-6ad2af4bd0aa"),
				ModifiedInSchemaUId = new Guid("6522ab5b-d5b7-4f10-9f18-6ad2af4bd0aa"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateRecordChangeTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("75a9960c-432d-4b4a-ac8a-2c9fd5a902b8"),
				Name = @"RecordChangeType",
				CreatedInSchemaUId = new Guid("6522ab5b-d5b7-4f10-9f18-6ad2af4bd0aa"),
				ModifiedInSchemaUId = new Guid("6522ab5b-d5b7-4f10-9f18-6ad2af4bd0aa"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("6d61aa94-cfae-4c1f-8eb8-f7e393a6257a"),
				Name = @"EntitySchemaUId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("6522ab5b-d5b7-4f10-9f18-6ad2af4bd0aa"),
				ModifiedInSchemaUId = new Guid("6522ab5b-d5b7-4f10-9f18-6ad2af4bd0aa"),
				CreatedInPackageId = new Guid("f22d92fb-0351-4268-afec-308cab404801")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysEntityCommonPrcElEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysEntityCommonPrcElEventsProcessSchema() {
			var schema = new SysEntityCommonPrcElEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysEntityCommonPrcEl(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysEntityCommonPrcEl_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysEntityCommonPrcElSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysEntityCommonPrcElSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6522ab5b-d5b7-4f10-9f18-6ad2af4bd0aa"));
		}

		#endregion

	}

	#endregion

	#region Class: SysEntityCommonPrcEl

	/// <summary>
	/// Process item finishing conditions.
	/// </summary>
	public class SysEntityCommonPrcEl : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysEntityCommonPrcEl(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysEntityCommonPrcEl";
		}

		public SysEntityCommonPrcEl(SysEntityCommonPrcEl source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Object record.
		/// </summary>
		public Guid RecordId {
			get {
				return GetTypedColumnValue<Guid>("RecordId");
			}
			set {
				SetColumnValue("RecordId", value);
			}
		}

		/// <exclude/>
		public Guid ProcessElementId {
			get {
				return GetTypedColumnValue<Guid>("ProcessElementId");
			}
			set {
				SetColumnValue("ProcessElementId", value);
				_processElement = null;
			}
		}

		private SysProcessElementData _processElement;
		/// <summary>
		/// Process item.
		/// </summary>
		public SysProcessElementData ProcessElement {
			get {
				return _processElement ??
					(_processElement = LookupColumnEntities.GetEntity("ProcessElement") as SysProcessElementData);
			}
		}

		/// <summary>
		/// Finishing conditions.
		/// </summary>
		public string ConditionData {
			get {
				return GetTypedColumnValue<string>("ConditionData");
			}
			set {
				SetColumnValue("ConditionData", value);
			}
		}

		/// <summary>
		/// Completing condition by modified column.
		/// </summary>
		public string ChangedColumns {
			get {
				return GetTypedColumnValue<string>("ChangedColumns");
			}
			set {
				SetColumnValue("ChangedColumns", value);
			}
		}

		/// <summary>
		/// Modification type.
		/// </summary>
		public int RecordChangeType {
			get {
				return GetTypedColumnValue<int>("RecordChangeType");
			}
			set {
				SetColumnValue("RecordChangeType", value);
			}
		}

		/// <summary>
		/// Object schema.
		/// </summary>
		public Guid EntitySchemaUId {
			get {
				return GetTypedColumnValue<Guid>("EntitySchemaUId");
			}
			set {
				SetColumnValue("EntitySchemaUId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysEntityCommonPrcEl_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysEntityCommonPrcElDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysEntityCommonPrcElDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysEntityCommonPrcElInserted", e);
			Inserting += (s, e) => ThrowEvent("SysEntityCommonPrcElInserting", e);
			Saved += (s, e) => ThrowEvent("SysEntityCommonPrcElSaved", e);
			Saving += (s, e) => ThrowEvent("SysEntityCommonPrcElSaving", e);
			Validating += (s, e) => ThrowEvent("SysEntityCommonPrcElValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysEntityCommonPrcEl(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysEntityCommonPrcEl_BaseEventsProcess

	/// <exclude/>
	public partial class SysEntityCommonPrcEl_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysEntityCommonPrcEl
	{

		public SysEntityCommonPrcEl_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysEntityCommonPrcEl_BaseEventsProcess";
			SchemaUId = new Guid("6522ab5b-d5b7-4f10-9f18-6ad2af4bd0aa");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6522ab5b-d5b7-4f10-9f18-6ad2af4bd0aa");
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

	#region Class: SysEntityCommonPrcEl_BaseEventsProcess

	/// <exclude/>
	public class SysEntityCommonPrcEl_BaseEventsProcess : SysEntityCommonPrcEl_BaseEventsProcess<SysEntityCommonPrcEl>
	{

		public SysEntityCommonPrcEl_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysEntityCommonPrcEl_BaseEventsProcess

	public partial class SysEntityCommonPrcEl_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysEntityCommonPrcElEventsProcessSchema

	/// <exclude/>
	public class SysEntityCommonPrcElEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysEntityCommonPrcElEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysEntityCommonPrcElEventsProcessSchema(SysEntityCommonPrcElEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysEntityCommonPrcEl_BaseEventsProcess";
			UId = new Guid("02f942ee-7aeb-4698-a096-dafa839fcb3c");
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
			return new SysEntityCommonPrcElEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("02f942ee-7aeb-4698-a096-dafa839fcb3c"));
		}

		#endregion

	}

	#endregion


	#region Class: SysEntityCommonPrcElEventsProcess

	/// <exclude/>
	public class SysEntityCommonPrcElEventsProcess : SysEntityCommonPrcEl_BaseEventsProcess
	{

		public SysEntityCommonPrcElEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

