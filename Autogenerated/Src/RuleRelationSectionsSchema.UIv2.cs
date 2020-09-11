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

	#region Class: RuleRelationSectionsSchema

	/// <exclude/>
	public class RuleRelationSectionsSchema : Terrasoft.Configuration.LookupSchema
	{

		#region Constructors: Public

		public RuleRelationSectionsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public RuleRelationSectionsSchema(RuleRelationSectionsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public RuleRelationSectionsSchema(RuleRelationSectionsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("adc2e665-7f74-49ee-a3d1-d63482aec3f6");
			RealUId = new Guid("adc2e665-7f74-49ee-a3d1-d63482aec3f6");
			Name = "RuleRelationSections";
			ParentSchemaUId = new Guid("2aecdb97-990e-4c17-96f4-240ca6531c84");
			ExtendParent = false;
			CreatedInPackageId = new Guid("324e2ed3-507d-49c0-9940-71ebe071d56d");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b2e3a06a-cb04-4642-8735-e116e955de07")) == null) {
				Columns.Add(CreateSectionSchemaUIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSectionSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("b2e3a06a-cb04-4642-8735-e116e955de07"),
				Name = @"SectionSchemaUId",
				CreatedInSchemaUId = new Guid("adc2e665-7f74-49ee-a3d1-d63482aec3f6"),
				ModifiedInSchemaUId = new Guid("adc2e665-7f74-49ee-a3d1-d63482aec3f6"),
				CreatedInPackageId = new Guid("324e2ed3-507d-49c0-9940-71ebe071d56d")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateRuleRelationSectionsEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateRuleRelationSectionsEventsProcessSchema() {
			var schema = new RuleRelationSectionsEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new RuleRelationSections(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new RuleRelationSections_UIv2EventsProcess(userConnection);
		}

		public override object Clone() {
			return new RuleRelationSectionsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new RuleRelationSectionsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("adc2e665-7f74-49ee-a3d1-d63482aec3f6"));
		}

		#endregion

	}

	#endregion

	#region Class: RuleRelationSections

	/// <summary>
	/// Sections that can be connected to emails.
	/// </summary>
	public class RuleRelationSections : Terrasoft.Configuration.Lookup
	{

		#region Constructors: Public

		public RuleRelationSections(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "RuleRelationSections";
		}

		public RuleRelationSections(RuleRelationSections source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// SectionSchemaUId.
		/// </summary>
		public Guid SectionSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("SectionSchemaUId");
			}
			set {
				SetColumnValue("SectionSchemaUId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new RuleRelationSections_UIv2EventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("RuleRelationSectionsDeleted", e);
			Validating += (s, e) => ThrowEvent("RuleRelationSectionsValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new RuleRelationSections(this);
		}

		#endregion

	}

	#endregion

	#region Class: RuleRelationSections_UIv2EventsProcess

	/// <exclude/>
	public partial class RuleRelationSections_UIv2EventsProcess<TEntity> : Terrasoft.Configuration.Lookup_BaseEventsProcess<TEntity> where TEntity : RuleRelationSections
	{

		public RuleRelationSections_UIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "RuleRelationSections_UIv2EventsProcess";
			SchemaUId = new Guid("adc2e665-7f74-49ee-a3d1-d63482aec3f6");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("adc2e665-7f74-49ee-a3d1-d63482aec3f6");
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

	#region Class: RuleRelationSections_UIv2EventsProcess

	/// <exclude/>
	public class RuleRelationSections_UIv2EventsProcess : RuleRelationSections_UIv2EventsProcess<RuleRelationSections>
	{

		public RuleRelationSections_UIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: RuleRelationSections_UIv2EventsProcess

	public partial class RuleRelationSections_UIv2EventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: RuleRelationSectionsEventsProcessSchema

	/// <exclude/>
	public class RuleRelationSectionsEventsProcessSchema : Terrasoft.Configuration.LookupEventsProcessSchema
	{

		#region Constructors: Public

		public RuleRelationSectionsEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public RuleRelationSectionsEventsProcessSchema(RuleRelationSectionsEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "RuleRelationSections_UIv2EventsProcess";
			UId = new Guid("758c45e2-e564-4970-a057-a003dada6589");
			CreatedInPackageId = new Guid("324e2ed3-507d-49c0-9940-71ebe071d56d");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("1e337b8d-0013-4c23-87df-2e46aad2b9c1");
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
			return new RuleRelationSectionsEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("758c45e2-e564-4970-a057-a003dada6589"));
		}

		#endregion

	}

	#endregion


	#region Class: RuleRelationSectionsEventsProcess

	/// <exclude/>
	public class RuleRelationSectionsEventsProcess : RuleRelationSections_UIv2EventsProcess
	{

		public RuleRelationSectionsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

