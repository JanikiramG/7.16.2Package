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

	#region Class: Opportunity_OpportunityManagement_TerrasoftSchema

	/// <exclude/>
	public class Opportunity_OpportunityManagement_TerrasoftSchema : Terrasoft.Configuration.Opportunity_MLOpportunityScoring_TerrasoftSchema
	{

		#region Constructors: Public

		public Opportunity_OpportunityManagement_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Opportunity_OpportunityManagement_TerrasoftSchema(Opportunity_OpportunityManagement_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Opportunity_OpportunityManagement_TerrasoftSchema(Opportunity_OpportunityManagement_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIDX_OpportunityTitleIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("538d5288-c406-4b69-8f00-7b42c02cbdf3");
			index.Name = "IDX_OpportunityTitle";
			index.CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			index.ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			index.CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
			EntitySchemaIndexColumn titleIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("7a45b5d6-7ce5-4417-8995-a0f6d21a272b"),
				ColumnUId = new Guid("790563cf-fd14-4d5d-a5fd-b6eddb10d6d3"),
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(titleIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("fd8b49ff-a90d-4028-9e6c-236283611a31");
			Name = "Opportunity_OpportunityManagement_Terrasoft";
			ParentSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			ExtendParent = true;
			CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("9ecd00e7-8bc5-4f52-b361-477831d42559")) == null) {
				Columns.Add(CreateByProcessColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateByProcessColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("9ecd00e7-8bc5-4f52-b361-477831d42559"),
				Name = @"ByProcess",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("fd8b49ff-a90d-4028-9e6c-236283611a31"),
				ModifiedInSchemaUId = new Guid("fd8b49ff-a90d-4028-9e6c-236283611a31"),
				CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIDX_OpportunityTitleIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOpportunity_OpportunityManagement_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateOpportunity_OpportunityManagement_TerrasoftEventsProcessSchema() {
			var schema = new Opportunity_OpportunityManagement_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Opportunity_OpportunityManagement_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Opportunity_OpportunityManagementEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Opportunity_OpportunityManagement_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Opportunity_OpportunityManagement_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fd8b49ff-a90d-4028-9e6c-236283611a31"));
		}

		#endregion

	}

	#endregion

	#region Class: Opportunity_OpportunityManagement_Terrasoft

	/// <summary>
	/// Opportunity.
	/// </summary>
	public class Opportunity_OpportunityManagement_Terrasoft : Terrasoft.Configuration.Opportunity_MLOpportunityScoring_Terrasoft
	{

		#region Constructors: Public

		public Opportunity_OpportunityManagement_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Opportunity_OpportunityManagement_Terrasoft";
		}

		public Opportunity_OpportunityManagement_Terrasoft(Opportunity_OpportunityManagement_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// By process.
		/// </summary>
		public bool ByProcess {
			get {
				return GetTypedColumnValue<bool>("ByProcess");
			}
			set {
				SetColumnValue("ByProcess", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Opportunity_OpportunityManagementEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("Opportunity_OpportunityManagement_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Opportunity_OpportunityManagement_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Opportunity_OpportunityManagementEventsProcess

	/// <exclude/>
	public partial class Opportunity_OpportunityManagementEventsProcess<TEntity> : Terrasoft.Configuration.Opportunity_MLOpportunityScoringEventsProcess<TEntity> where TEntity : Opportunity_OpportunityManagement_Terrasoft
	{

		public Opportunity_OpportunityManagementEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Opportunity_OpportunityManagementEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fd8b49ff-a90d-4028-9e6c-236283611a31");
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

	#region Class: Opportunity_OpportunityManagementEventsProcess

	/// <exclude/>
	public class Opportunity_OpportunityManagementEventsProcess : Opportunity_OpportunityManagementEventsProcess<Opportunity_OpportunityManagement_Terrasoft>
	{

		public Opportunity_OpportunityManagementEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Opportunity_OpportunityManagementEventsProcess

	public partial class Opportunity_OpportunityManagementEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: Opportunity_OpportunityManagement_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Opportunity_OpportunityManagement_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Opportunity_MLOpportunityScoring_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Opportunity_OpportunityManagement_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Opportunity_OpportunityManagement_TerrasoftEventsProcessSchema(Opportunity_OpportunityManagement_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Opportunity_OpportunityManagementEventsProcess";
			UId = new Guid("73672337-e402-4cb5-ac38-c2b23abdccb9");
			CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("ca3fe4a1-ad9c-4113-9de6-9e2ac0ad826d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("eb1722ce-31bb-46e5-88f6-100c484b4f53"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("01014fbe-e86b-4976-a436-4f563cb960a5"),
				CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd"),
				CreatedInSchemaUId = new Guid("73672337-e402-4cb5-ac38-c2b23abdccb9"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("73672337-e402-4cb5-ac38-c2b23abdccb9"),
				Name = @"LaneSet1",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("5d41961a-59d2-4f5f-8bf7-d63a5f727e79"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eb1722ce-31bb-46e5-88f6-100c484b4f53"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd"),
				CreatedInSchemaUId = new Guid("73672337-e402-4cb5-ac38-c2b23abdccb9"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("73672337-e402-4cb5-ac38-c2b23abdccb9"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("99588ad2-b9c4-4ecd-87bc-9534b4a7be0d"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("b1a963da-a78f-4fae-8e9e-52d870dd0ef3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4648de12-5440-4895-9fdc-5e9b6f34f7e2"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("b1a963da-a78f-4fae-8e9e-52d870dd0ef3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c5a3eefb-8711-4da4-b899-2b19ce17d943"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("b1a963da-a78f-4fae-8e9e-52d870dd0ef3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("b1a963da-a78f-4fae-8e9e-52d870dd0ef3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("b1a963da-a78f-4fae-8e9e-52d870dd0ef3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("b1a963da-a78f-4fae-8e9e-52d870dd0ef3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("b1a963da-a78f-4fae-8e9e-52d870dd0ef3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("b1a963da-a78f-4fae-8e9e-52d870dd0ef3")
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
			return new Opportunity_OpportunityManagement_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("73672337-e402-4cb5-ac38-c2b23abdccb9"));
		}

		#endregion

	}

	#endregion

}

