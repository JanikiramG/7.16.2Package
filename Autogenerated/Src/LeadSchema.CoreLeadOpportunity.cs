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

	#region Class: Lead_CoreLeadOpportunity_TerrasoftSchema

	/// <exclude/>
	public class Lead_CoreLeadOpportunity_TerrasoftSchema : Terrasoft.Configuration.Lead_WebLeadForm_TerrasoftSchema
	{

		#region Constructors: Public

		public Lead_CoreLeadOpportunity_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Lead_CoreLeadOpportunity_TerrasoftSchema(Lead_CoreLeadOpportunity_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Lead_CoreLeadOpportunity_TerrasoftSchema(Lead_CoreLeadOpportunity_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIMLLeadModifiedOnIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("e0ee791a-7d9e-4ef7-8653-eb995a3f6d74");
			index.Name = "IMLLeadModifiedOn";
			index.CreatedInSchemaUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258");
			index.ModifiedInSchemaUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258");
			index.CreatedInPackageId = new Guid("296a0a1e-e6de-4406-bbd8-86a62e047ff0");
			EntitySchemaIndexColumn modifiedOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("aaa8ad09-ce33-4f85-9c6f-46d679ad61ee"),
				ColumnUId = new Guid("9928edec-4272-425a-93bb-48743fee4b04"),
				CreatedInSchemaUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258"),
				ModifiedInSchemaUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258"),
				CreatedInPackageId = new Guid("296a0a1e-e6de-4406-bbd8-86a62e047ff0"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(modifiedOnIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIDX_LeadNameIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("bf3f62f3-5d38-4031-a648-58b036f8f19d");
			index.Name = "IDX_LeadName";
			index.CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			index.ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			index.CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06");
			EntitySchemaIndexColumn leadNameIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("2c3ed9bd-ff44-447d-b4af-c6a4e4090a5a"),
				ColumnUId = new Guid("d06ba9af-faf5-4741-a672-e154ae561a94"),
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(leadNameIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("601457d2-f86e-4ee0-bdf2-eeb9ef04a107");
			Name = "Lead_CoreLeadOpportunity_Terrasoft";
			ParentSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			ExtendParent = true;
			CreatedInPackageId = new Guid("b1a963da-a78f-4fae-8e9e-52d870dd0ef3");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("7cfff438-9ee8-4272-816d-5deb7d0c9d36")) == null) {
				Columns.Add(CreateOpportunityColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateOpportunityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7cfff438-9ee8-4272-816d-5deb7d0c9d36"),
				Name = @"Opportunity",
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("601457d2-f86e-4ee0-bdf2-eeb9ef04a107"),
				ModifiedInSchemaUId = new Guid("601457d2-f86e-4ee0-bdf2-eeb9ef04a107"),
				CreatedInPackageId = new Guid("b1a963da-a78f-4fae-8e9e-52d870dd0ef3")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIMLLeadModifiedOnIndex());
			Indexes.Add(CreateIDX_LeadNameIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLead_CoreLeadOpportunity_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateLead_CoreLeadOpportunity_TerrasoftEventsProcessSchema() {
			var schema = new Lead_CoreLeadOpportunity_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Lead_CoreLeadOpportunity_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Lead_CoreLeadOpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Lead_CoreLeadOpportunity_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Lead_CoreLeadOpportunity_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("601457d2-f86e-4ee0-bdf2-eeb9ef04a107"));
		}

		#endregion

	}

	#endregion

	#region Class: Lead_CoreLeadOpportunity_Terrasoft

	/// <summary>
	/// Lead.
	/// </summary>
	public class Lead_CoreLeadOpportunity_Terrasoft : Terrasoft.Configuration.Lead_WebLeadForm_Terrasoft
	{

		#region Constructors: Public

		public Lead_CoreLeadOpportunity_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Lead_CoreLeadOpportunity_Terrasoft";
		}

		public Lead_CoreLeadOpportunity_Terrasoft(Lead_CoreLeadOpportunity_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid OpportunityId {
			get {
				return GetTypedColumnValue<Guid>("OpportunityId");
			}
			set {
				SetColumnValue("OpportunityId", value);
				_opportunity = null;
			}
		}

		/// <exclude/>
		public string OpportunityTitle {
			get {
				return GetTypedColumnValue<string>("OpportunityTitle");
			}
			set {
				SetColumnValue("OpportunityTitle", value);
				if (_opportunity != null) {
					_opportunity.Title = value;
				}
			}
		}

		private Opportunity _opportunity;
		/// <summary>
		/// Opportunity.
		/// </summary>
		public Opportunity Opportunity {
			get {
				return _opportunity ??
					(_opportunity = LookupColumnEntities.GetEntity("Opportunity") as Opportunity);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Lead_CoreLeadOpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Lead_CoreLeadOpportunity_TerrasoftDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Lead_CoreLeadOpportunity_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Lead_CoreLeadOpportunityEventsProcess

	/// <exclude/>
	public partial class Lead_CoreLeadOpportunityEventsProcess<TEntity> : Terrasoft.Configuration.Lead_WebLeadFormEventsProcess<TEntity> where TEntity : Lead_CoreLeadOpportunity_Terrasoft
	{

		public Lead_CoreLeadOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Lead_CoreLeadOpportunityEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("601457d2-f86e-4ee0-bdf2-eeb9ef04a107");
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

	#region Class: Lead_CoreLeadOpportunityEventsProcess

	/// <exclude/>
	public class Lead_CoreLeadOpportunityEventsProcess : Lead_CoreLeadOpportunityEventsProcess<Lead_CoreLeadOpportunity_Terrasoft>
	{

		public Lead_CoreLeadOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Lead_CoreLeadOpportunityEventsProcess

	public partial class Lead_CoreLeadOpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: Lead_CoreLeadOpportunity_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Lead_CoreLeadOpportunity_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Lead_WebLeadForm_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Lead_CoreLeadOpportunity_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Lead_CoreLeadOpportunity_TerrasoftEventsProcessSchema(Lead_CoreLeadOpportunity_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Lead_CoreLeadOpportunityEventsProcess";
			UId = new Guid("43ab6994-29c4-4f63-a2a5-f9feb3eff762");
			CreatedInPackageId = new Guid("b1a963da-a78f-4fae-8e9e-52d870dd0ef3");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("60550bfb-e424-448d-bc5b-ccf6184f7414");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet3_1ea23c903cb148e0bb649f37eb872df4 = CreateLaneSet3_1ea23c903cb148e0bb649f37eb872df4LaneSet();
			LaneSets.Add(schemaLaneSet3_1ea23c903cb148e0bb649f37eb872df4);
			ProcessSchemaLane schemaLane3_202e282dcb79493e9bacd4846602ca82 = CreateLane3_202e282dcb79493e9bacd4846602ca82Lane();
			schemaLaneSet3_1ea23c903cb148e0bb649f37eb872df4.Lanes.Add(schemaLane3_202e282dcb79493e9bacd4846602ca82);
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet3_1ea23c903cb148e0bb649f37eb872df4LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet3_1ea23c903cb148e0bb649f37eb872df4 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("1ea23c90-3cb1-48e0-bb64-9f37eb872df4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("065de26f-5ffd-4bc4-b862-ab37d85ac483"),
				CreatedInPackageId = new Guid("a35d3948-d583-4f59-a553-58b34ce2286e"),
				CreatedInSchemaUId = new Guid("43ab6994-29c4-4f63-a2a5-f9feb3eff762"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("43ab6994-29c4-4f63-a2a5-f9feb3eff762"),
				Name = @"LaneSet3_1ea23c903cb148e0bb649f37eb872df4",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet3_1ea23c903cb148e0bb649f37eb872df4;
		}

		protected virtual ProcessSchemaLane CreateLane3_202e282dcb79493e9bacd4846602ca82Lane() {
			ProcessSchemaLane schemaLane3_202e282dcb79493e9bacd4846602ca82 = new ProcessSchemaLane(this) {
				UId = new Guid("202e282d-cb79-493e-9bac-d4846602ca82"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1ea23c90-3cb1-48e0-bb64-9f37eb872df4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("a35d3948-d583-4f59-a553-58b34ce2286e"),
				CreatedInSchemaUId = new Guid("43ab6994-29c4-4f63-a2a5-f9feb3eff762"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("43ab6994-29c4-4f63-a2a5-f9feb3eff762"),
				Name = @"Lane3_202e282dcb79493e9bacd4846602ca82",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane3_202e282dcb79493e9bacd4846602ca82;
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
				CreatedInPackageId = new Guid("b1a963da-a78f-4fae-8e9e-52d870dd0ef3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("b1a963da-a78f-4fae-8e9e-52d870dd0ef3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
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
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("b1a963da-a78f-4fae-8e9e-52d870dd0ef3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
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
			return new Lead_CoreLeadOpportunity_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("43ab6994-29c4-4f63-a2a5-f9feb3eff762"));
		}

		#endregion

	}

	#endregion

}

