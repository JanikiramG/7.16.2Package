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

	#region Class: CompetitorProduct_Base_TerrasoftSchema

	/// <exclude/>
	public class CompetitorProduct_Base_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public CompetitorProduct_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CompetitorProduct_Base_TerrasoftSchema(CompetitorProduct_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CompetitorProduct_Base_TerrasoftSchema(CompetitorProduct_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a90cf5af-917c-4b33-8eee-832906dbe6d5");
			RealUId = new Guid("a90cf5af-917c-4b33-8eee-832906dbe6d5");
			Name = "CompetitorProduct_Base_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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
			if (Columns.FindByUId(new Guid("27274924-78bf-4c01-b980-a934997f4a5f")) == null) {
				Columns.Add(CreateCompetitorColumn());
			}
			if (Columns.FindByUId(new Guid("d533eb3b-aa86-413e-88f1-7ee456dda433")) == null) {
				Columns.Add(CreateWeaknessColumn());
			}
			if (Columns.FindByUId(new Guid("fa76bce1-6298-45a5-9f64-fd4d081136af")) == null) {
				Columns.Add(CreateStrengthsColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCompetitorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("27274924-78bf-4c01-b980-a934997f4a5f"),
				Name = @"Competitor",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("a90cf5af-917c-4b33-8eee-832906dbe6d5"),
				ModifiedInSchemaUId = new Guid("a90cf5af-917c-4b33-8eee-832906dbe6d5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("3d005156-0544-4b66-b8ab-0e82042396ad"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("a90cf5af-917c-4b33-8eee-832906dbe6d5"),
				ModifiedInSchemaUId = new Guid("a90cf5af-917c-4b33-8eee-832906dbe6d5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateWeaknessColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("d533eb3b-aa86-413e-88f1-7ee456dda433"),
				Name = @"Weakness",
				CreatedInSchemaUId = new Guid("a90cf5af-917c-4b33-8eee-832906dbe6d5"),
				ModifiedInSchemaUId = new Guid("a90cf5af-917c-4b33-8eee-832906dbe6d5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateStrengthsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("fa76bce1-6298-45a5-9f64-fd4d081136af"),
				Name = @"Strengths",
				CreatedInSchemaUId = new Guid("a90cf5af-917c-4b33-8eee-832906dbe6d5"),
				ModifiedInSchemaUId = new Guid("a90cf5af-917c-4b33-8eee-832906dbe6d5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsLocalizable = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCompetitorProduct_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCompetitorProduct_Base_TerrasoftEventsProcessSchema() {
			var schema = new CompetitorProduct_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CompetitorProduct_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CompetitorProduct_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CompetitorProduct_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CompetitorProduct_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a90cf5af-917c-4b33-8eee-832906dbe6d5"));
		}

		#endregion

	}

	#endregion

	#region Class: CompetitorProduct_Base_Terrasoft

	/// <summary>
	/// Competitor product.
	/// </summary>
	public class CompetitorProduct_Base_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public CompetitorProduct_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CompetitorProduct_Base_Terrasoft";
		}

		public CompetitorProduct_Base_Terrasoft(CompetitorProduct_Base_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid CompetitorId {
			get {
				return GetTypedColumnValue<Guid>("CompetitorId");
			}
			set {
				SetColumnValue("CompetitorId", value);
				_competitor = null;
			}
		}

		/// <exclude/>
		public string CompetitorName {
			get {
				return GetTypedColumnValue<string>("CompetitorName");
			}
			set {
				SetColumnValue("CompetitorName", value);
				if (_competitor != null) {
					_competitor.Name = value;
				}
			}
		}

		private Account _competitor;
		/// <summary>
		/// Manufacturer.
		/// </summary>
		public Account Competitor {
			get {
				return _competitor ??
					(_competitor = LookupColumnEntities.GetEntity("Competitor") as Account);
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
		/// Weaknesses.
		/// </summary>
		public string Weakness {
			get {
				return GetTypedColumnValue<string>("Weakness");
			}
			set {
				SetColumnValue("Weakness", value);
			}
		}

		/// <summary>
		/// Strengths.
		/// </summary>
		public string Strengths {
			get {
				return GetTypedColumnValue<string>("Strengths");
			}
			set {
				SetColumnValue("Strengths", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CompetitorProduct_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CompetitorProduct_Base_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("CompetitorProduct_Base_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("CompetitorProduct_Base_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("CompetitorProduct_Base_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("CompetitorProduct_Base_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("CompetitorProduct_Base_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("CompetitorProduct_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CompetitorProduct_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: CompetitorProduct_BaseEventsProcess

	/// <exclude/>
	public partial class CompetitorProduct_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : CompetitorProduct_Base_Terrasoft
	{

		public CompetitorProduct_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CompetitorProduct_BaseEventsProcess";
			SchemaUId = new Guid("a90cf5af-917c-4b33-8eee-832906dbe6d5");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a90cf5af-917c-4b33-8eee-832906dbe6d5");
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

	#region Class: CompetitorProduct_BaseEventsProcess

	/// <exclude/>
	public class CompetitorProduct_BaseEventsProcess : CompetitorProduct_BaseEventsProcess<CompetitorProduct_Base_Terrasoft>
	{

		public CompetitorProduct_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CompetitorProduct_BaseEventsProcess

	public partial class CompetitorProduct_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: CompetitorProduct_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class CompetitorProduct_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public CompetitorProduct_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CompetitorProduct_Base_TerrasoftEventsProcessSchema(CompetitorProduct_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CompetitorProduct_BaseEventsProcess";
			UId = new Guid("a2b2082c-c264-4588-8f9a-a618cd417d13");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = Guid.Empty;
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
			return new CompetitorProduct_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a2b2082c-c264-4588-8f9a-a618cd417d13"));
		}

		#endregion

	}

	#endregion

}

