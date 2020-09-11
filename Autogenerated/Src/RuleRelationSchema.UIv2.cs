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

	#region Class: RuleRelationSchema

	/// <exclude/>
	public class RuleRelationSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public RuleRelationSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public RuleRelationSchema(RuleRelationSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public RuleRelationSchema(RuleRelationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1be83bef-9c97-43f4-a578-a2fe0f45d7fd");
			RealUId = new Guid("1be83bef-9c97-43f4-a578-a2fe0f45d7fd");
			Name = "RuleRelation";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("93ee616e-e44a-4ac3-9178-cdca5a3a4303");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("409f998a-e2f9-45d5-80f0-72e58f6f5714")) == null) {
				Columns.Add(CreateEntitySchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("81cc6ff9-b3c0-41ac-9532-b2f8c8109b70")) == null) {
				Columns.Add(CreateEntitySchemaColumnUIdColumn());
			}
			if (Columns.FindByUId(new Guid("660da5c1-37dd-4913-8e53-abf546136159")) == null) {
				Columns.Add(CreateEntitySchemaSearchUIdColumn());
			}
			if (Columns.FindByUId(new Guid("7d180e22-277d-4ddb-aedd-5b41c0f3019a")) == null) {
				Columns.Add(CreateEntitySchemaSearchColumnUIdColumn());
			}
			if (Columns.FindByUId(new Guid("822820d3-efdf-40c9-ad63-6540c275d28d")) == null) {
				Columns.Add(CreateRuleColumn());
			}
			if (Columns.FindByUId(new Guid("a9098506-c700-415f-ad51-2d48879df1f4")) == null) {
				Columns.Add(CreatePositionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("409f998a-e2f9-45d5-80f0-72e58f6f5714"),
				Name = @"EntitySchemaUId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("1be83bef-9c97-43f4-a578-a2fe0f45d7fd"),
				ModifiedInSchemaUId = new Guid("1be83bef-9c97-43f4-a578-a2fe0f45d7fd"),
				CreatedInPackageId = new Guid("93ee616e-e44a-4ac3-9178-cdca5a3a4303")
			};
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaColumnUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("81cc6ff9-b3c0-41ac-9532-b2f8c8109b70"),
				Name = @"EntitySchemaColumnUId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("1be83bef-9c97-43f4-a578-a2fe0f45d7fd"),
				ModifiedInSchemaUId = new Guid("1be83bef-9c97-43f4-a578-a2fe0f45d7fd"),
				CreatedInPackageId = new Guid("93ee616e-e44a-4ac3-9178-cdca5a3a4303")
			};
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaSearchUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("660da5c1-37dd-4913-8e53-abf546136159"),
				Name = @"EntitySchemaSearchUId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("1be83bef-9c97-43f4-a578-a2fe0f45d7fd"),
				ModifiedInSchemaUId = new Guid("1be83bef-9c97-43f4-a578-a2fe0f45d7fd"),
				CreatedInPackageId = new Guid("93ee616e-e44a-4ac3-9178-cdca5a3a4303")
			};
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaSearchColumnUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("7d180e22-277d-4ddb-aedd-5b41c0f3019a"),
				Name = @"EntitySchemaSearchColumnUId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("1be83bef-9c97-43f4-a578-a2fe0f45d7fd"),
				ModifiedInSchemaUId = new Guid("1be83bef-9c97-43f4-a578-a2fe0f45d7fd"),
				CreatedInPackageId = new Guid("93ee616e-e44a-4ac3-9178-cdca5a3a4303")
			};
		}

		protected virtual EntitySchemaColumn CreateRuleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("822820d3-efdf-40c9-ad63-6540c275d28d"),
				Name = @"Rule",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("1be83bef-9c97-43f4-a578-a2fe0f45d7fd"),
				ModifiedInSchemaUId = new Guid("1be83bef-9c97-43f4-a578-a2fe0f45d7fd"),
				CreatedInPackageId = new Guid("93ee616e-e44a-4ac3-9178-cdca5a3a4303")
			};
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("a9098506-c700-415f-ad51-2d48879df1f4"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("1be83bef-9c97-43f4-a578-a2fe0f45d7fd"),
				ModifiedInSchemaUId = new Guid("1be83bef-9c97-43f4-a578-a2fe0f45d7fd"),
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateRuleRelationEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateRuleRelationEventsProcessSchema() {
			var schema = new RuleRelationEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new RuleRelation(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new RuleRelation_UIv2EventsProcess(userConnection);
		}

		public override object Clone() {
			return new RuleRelationSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new RuleRelationSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1be83bef-9c97-43f4-a578-a2fe0f45d7fd"));
		}

		#endregion

	}

	#endregion

	#region Class: RuleRelation

	/// <summary>
	/// Rules for connecting emails to system sections.
	/// </summary>
	public class RuleRelation : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public RuleRelation(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "RuleRelation";
		}

		public RuleRelation(RuleRelation source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Connect to entity.
		/// </summary>
		public Guid EntitySchemaUId {
			get {
				return GetTypedColumnValue<Guid>("EntitySchemaUId");
			}
			set {
				SetColumnValue("EntitySchemaUId", value);
			}
		}

		/// <summary>
		/// Column to search notification in.
		/// </summary>
		public Guid EntitySchemaColumnUId {
			get {
				return GetTypedColumnValue<Guid>("EntitySchemaColumnUId");
			}
			set {
				SetColumnValue("EntitySchemaColumnUId", value);
			}
		}

		/// <summary>
		/// Search entity.
		/// </summary>
		public Guid EntitySchemaSearchUId {
			get {
				return GetTypedColumnValue<Guid>("EntitySchemaSearchUId");
			}
			set {
				SetColumnValue("EntitySchemaSearchUId", value);
			}
		}

		/// <summary>
		/// Column for comparison.
		/// </summary>
		public Guid EntitySchemaSearchColumnUId {
			get {
				return GetTypedColumnValue<Guid>("EntitySchemaSearchColumnUId");
			}
			set {
				SetColumnValue("EntitySchemaSearchColumnUId", value);
			}
		}

		/// <summary>
		/// Rule.
		/// </summary>
		public string Rule {
			get {
				return GetTypedColumnValue<string>("Rule");
			}
			set {
				SetColumnValue("Rule", value);
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new RuleRelation_UIv2EventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("RuleRelationDeleted", e);
			Validating += (s, e) => ThrowEvent("RuleRelationValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new RuleRelation(this);
		}

		#endregion

	}

	#endregion

	#region Class: RuleRelation_UIv2EventsProcess

	/// <exclude/>
	public partial class RuleRelation_UIv2EventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : RuleRelation
	{

		public RuleRelation_UIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "RuleRelation_UIv2EventsProcess";
			SchemaUId = new Guid("1be83bef-9c97-43f4-a578-a2fe0f45d7fd");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1be83bef-9c97-43f4-a578-a2fe0f45d7fd");
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

	#region Class: RuleRelation_UIv2EventsProcess

	/// <exclude/>
	public class RuleRelation_UIv2EventsProcess : RuleRelation_UIv2EventsProcess<RuleRelation>
	{

		public RuleRelation_UIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: RuleRelation_UIv2EventsProcess

	public partial class RuleRelation_UIv2EventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: RuleRelationEventsProcessSchema

	/// <exclude/>
	public class RuleRelationEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public RuleRelationEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public RuleRelationEventsProcessSchema(RuleRelationEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "RuleRelation_UIv2EventsProcess";
			UId = new Guid("c034138b-ddf3-475b-8ff4-861009d8432c");
			CreatedInPackageId = new Guid("93ee616e-e44a-4ac3-9178-cdca5a3a4303");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1");
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
			return new RuleRelationEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c034138b-ddf3-475b-8ff4-861009d8432c"));
		}

		#endregion

	}

	#endregion


	#region Class: RuleRelationEventsProcess

	/// <exclude/>
	public class RuleRelationEventsProcess : RuleRelation_UIv2EventsProcess
	{

		public RuleRelationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

