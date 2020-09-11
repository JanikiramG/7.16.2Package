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

	#region Class: DuplicatesRuleSchema

	/// <exclude/>
	public class DuplicatesRuleSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public DuplicatesRuleSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DuplicatesRuleSchema(DuplicatesRuleSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DuplicatesRuleSchema(DuplicatesRuleSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f9838ef2-f0f9-448c-b968-e36103b33919");
			RealUId = new Guid("f9838ef2-f0f9-448c-b968-e36103b33919");
			Name = "DuplicatesRule";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("ef5d5886-2372-4a6f-84cc-55847f52d4ab");
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
			if (Columns.FindByUId(new Guid("c5b7aaf3-72ad-43e0-bcbf-bfac66d50e2a")) == null) {
				Columns.Add(CreateIsActiveColumn());
			}
			if (Columns.FindByUId(new Guid("dfa9bd8a-dbc4-405a-9c29-701dc6bc6599")) == null) {
				Columns.Add(CreateObjectColumn());
			}
			if (Columns.FindByUId(new Guid("931042d0-27db-46dd-b76f-9316a51f2af2")) == null) {
				Columns.Add(CreateRuleBodyColumn());
			}
			if (Columns.FindByUId(new Guid("2739c1c8-709b-477a-bf07-f85fc4c70d31")) == null) {
				Columns.Add(CreateProcedureNameColumn());
			}
			if (Columns.FindByUId(new Guid("ee552907-b04c-4a84-9320-7370ea59ebdd")) == null) {
				Columns.Add(CreateUseAtSaveColumn());
			}
			if (Columns.FindByUId(new Guid("0c715ab8-cf10-44ce-b83e-7d287053d3a1")) == null) {
				Columns.Add(CreateSearchObjectColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("177e3690-29ef-4af4-8879-e9b925c47bda"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("f9838ef2-f0f9-448c-b968-e36103b33919"),
				ModifiedInSchemaUId = new Guid("f9838ef2-f0f9-448c-b968-e36103b33919"),
				CreatedInPackageId = new Guid("ef5d5886-2372-4a6f-84cc-55847f52d4ab"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateIsActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("c5b7aaf3-72ad-43e0-bcbf-bfac66d50e2a"),
				Name = @"IsActive",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("f9838ef2-f0f9-448c-b968-e36103b33919"),
				ModifiedInSchemaUId = new Guid("f9838ef2-f0f9-448c-b968-e36103b33919"),
				CreatedInPackageId = new Guid("ef5d5886-2372-4a6f-84cc-55847f52d4ab")
			};
		}

		protected virtual EntitySchemaColumn CreateObjectColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("dfa9bd8a-dbc4-405a-9c29-701dc6bc6599"),
				Name = @"Object",
				ReferenceSchemaUId = new Guid("7b529ef9-ace8-4808-a567-8cd121bedf9b"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("f9838ef2-f0f9-448c-b968-e36103b33919"),
				ModifiedInSchemaUId = new Guid("f9838ef2-f0f9-448c-b968-e36103b33919"),
				CreatedInPackageId = new Guid("ef5d5886-2372-4a6f-84cc-55847f52d4ab")
			};
		}

		protected virtual EntitySchemaColumn CreateRuleBodyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("931042d0-27db-46dd-b76f-9316a51f2af2"),
				Name = @"RuleBody",
				CreatedInSchemaUId = new Guid("f9838ef2-f0f9-448c-b968-e36103b33919"),
				ModifiedInSchemaUId = new Guid("f9838ef2-f0f9-448c-b968-e36103b33919"),
				CreatedInPackageId = new Guid("891b85fe-ef15-418d-a66c-ac70369b4f0c")
			};
		}

		protected virtual EntitySchemaColumn CreateProcedureNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("2739c1c8-709b-477a-bf07-f85fc4c70d31"),
				Name = @"ProcedureName",
				CreatedInSchemaUId = new Guid("f9838ef2-f0f9-448c-b968-e36103b33919"),
				ModifiedInSchemaUId = new Guid("f9838ef2-f0f9-448c-b968-e36103b33919"),
				CreatedInPackageId = new Guid("a4ad658c-2d44-4d01-81fe-dc433396f837")
			};
		}

		protected virtual EntitySchemaColumn CreateUseAtSaveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("ee552907-b04c-4a84-9320-7370ea59ebdd"),
				Name = @"UseAtSave",
				CreatedInSchemaUId = new Guid("f9838ef2-f0f9-448c-b968-e36103b33919"),
				ModifiedInSchemaUId = new Guid("f9838ef2-f0f9-448c-b968-e36103b33919"),
				CreatedInPackageId = new Guid("3066e968-6ad0-45b5-bf2b-b9af469e0d31")
			};
		}

		protected virtual EntitySchemaColumn CreateSearchObjectColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0c715ab8-cf10-44ce-b83e-7d287053d3a1"),
				Name = @"SearchObject",
				ReferenceSchemaUId = new Guid("7b529ef9-ace8-4808-a567-8cd121bedf9b"),
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("f9838ef2-f0f9-448c-b968-e36103b33919"),
				ModifiedInSchemaUId = new Guid("f9838ef2-f0f9-448c-b968-e36103b33919"),
				CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateDuplicatesRuleEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateDuplicatesRuleEventsProcessSchema() {
			var schema = new DuplicatesRuleEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DuplicatesRule(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DuplicatesRule_DeduplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DuplicatesRuleSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DuplicatesRuleSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f9838ef2-f0f9-448c-b968-e36103b33919"));
		}

		#endregion

	}

	#endregion

	#region Class: DuplicatesRule

	/// <summary>
	/// Duplicate rule.
	/// </summary>
	public class DuplicatesRule : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public DuplicatesRule(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DuplicatesRule";
		}

		public DuplicatesRule(DuplicatesRule source)
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

		/// <summary>
		/// Active.
		/// </summary>
		public bool IsActive {
			get {
				return GetTypedColumnValue<bool>("IsActive");
			}
			set {
				SetColumnValue("IsActive", value);
			}
		}

		/// <exclude/>
		public Guid ObjectId {
			get {
				return GetTypedColumnValue<Guid>("ObjectId");
			}
			set {
				SetColumnValue("ObjectId", value);
				_object = null;
			}
		}

		/// <exclude/>
		public string ObjectCaption {
			get {
				return GetTypedColumnValue<string>("ObjectCaption");
			}
			set {
				SetColumnValue("ObjectCaption", value);
				if (_object != null) {
					_object.Caption = value;
				}
			}
		}

		private VwDuplicatesRuleType _object;
		/// <summary>
		/// Rule type.
		/// </summary>
		public VwDuplicatesRuleType Object {
			get {
				return _object ??
					(_object = LookupColumnEntities.GetEntity("Object") as VwDuplicatesRuleType);
			}
		}

		/// <summary>
		/// Rule body.
		/// </summary>
		public string RuleBody {
			get {
				return GetTypedColumnValue<string>("RuleBody");
			}
			set {
				SetColumnValue("RuleBody", value);
			}
		}

		/// <summary>
		/// Procedure name.
		/// </summary>
		public string ProcedureName {
			get {
				return GetTypedColumnValue<string>("ProcedureName");
			}
			set {
				SetColumnValue("ProcedureName", value);
			}
		}

		/// <summary>
		/// Use this rule on save.
		/// </summary>
		public bool UseAtSave {
			get {
				return GetTypedColumnValue<bool>("UseAtSave");
			}
			set {
				SetColumnValue("UseAtSave", value);
			}
		}

		/// <exclude/>
		public Guid SearchObjectId {
			get {
				return GetTypedColumnValue<Guid>("SearchObjectId");
			}
			set {
				SetColumnValue("SearchObjectId", value);
				_searchObject = null;
			}
		}

		/// <exclude/>
		public string SearchObjectCaption {
			get {
				return GetTypedColumnValue<string>("SearchObjectCaption");
			}
			set {
				SetColumnValue("SearchObjectCaption", value);
				if (_searchObject != null) {
					_searchObject.Caption = value;
				}
			}
		}

		private VwDuplicatesRuleType _searchObject;
		/// <summary>
		/// Search object.
		/// </summary>
		public VwDuplicatesRuleType SearchObject {
			get {
				return _searchObject ??
					(_searchObject = LookupColumnEntities.GetEntity("SearchObject") as VwDuplicatesRuleType);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DuplicatesRule_DeduplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DuplicatesRuleDeleted", e);
			Validating += (s, e) => ThrowEvent("DuplicatesRuleValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DuplicatesRule(this);
		}

		#endregion

	}

	#endregion

	#region Class: DuplicatesRule_DeduplicationEventsProcess

	/// <exclude/>
	public partial class DuplicatesRule_DeduplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : DuplicatesRule
	{

		public DuplicatesRule_DeduplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DuplicatesRule_DeduplicationEventsProcess";
			SchemaUId = new Guid("f9838ef2-f0f9-448c-b968-e36103b33919");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f9838ef2-f0f9-448c-b968-e36103b33919");
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

	#region Class: DuplicatesRule_DeduplicationEventsProcess

	/// <exclude/>
	public class DuplicatesRule_DeduplicationEventsProcess : DuplicatesRule_DeduplicationEventsProcess<DuplicatesRule>
	{

		public DuplicatesRule_DeduplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DuplicatesRule_DeduplicationEventsProcess

	public partial class DuplicatesRule_DeduplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: DuplicatesRuleEventsProcessSchema

	/// <exclude/>
	public class DuplicatesRuleEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public DuplicatesRuleEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public DuplicatesRuleEventsProcessSchema(DuplicatesRuleEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "DuplicatesRule_DeduplicationEventsProcess";
			UId = new Guid("e2997f7b-6b6c-4793-8031-f7423c481bbe");
			CreatedInPackageId = new Guid("ef5d5886-2372-4a6f-84cc-55847f52d4ab");
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
			return new DuplicatesRuleEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e2997f7b-6b6c-4793-8031-f7423c481bbe"));
		}

		#endregion

	}

	#endregion


	#region Class: DuplicatesRuleEventsProcess

	/// <exclude/>
	public class DuplicatesRuleEventsProcess : DuplicatesRule_DeduplicationEventsProcess
	{

		public DuplicatesRuleEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

