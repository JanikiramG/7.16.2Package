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
	using Terrasoft.Configuration.PRM;
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

	#region Class: LeadSchema

	/// <exclude/>
	public class LeadSchema : Terrasoft.Configuration.Lead_OpportunityManagement_TerrasoftSchema
	{

		#region Constructors: Public

		public LeadSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LeadSchema(LeadSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LeadSchema(LeadSchema source)
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
			RealUId = new Guid("2439c822-3b08-441e-9e5f-e93344d355d7");
			Name = "Lead";
			ParentSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			ExtendParent = true;
			CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
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
			EventsProcessSchema = CreateLeadEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateLeadEventsProcessSchema() {
			var schema = new LeadEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Lead(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Lead_SalesEnterpriseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LeadSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LeadSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2439c822-3b08-441e-9e5f-e93344d355d7"));
		}

		#endregion

	}

	#endregion

	#region Class: Lead

	/// <summary>
	/// Lead.
	/// </summary>
	public class Lead : Terrasoft.Configuration.Lead_OpportunityManagement_Terrasoft
	{

		#region Constructors: Public

		public Lead(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Lead";
		}

		public Lead(Lead source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Lead_SalesEnterpriseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("LeadDeleted", e);
			Inserted += (s, e) => ThrowEvent("LeadInserted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Lead(this);
		}

		#endregion

	}

	#endregion

	#region Class: Lead_SalesEnterpriseEventsProcess

	/// <exclude/>
	public partial class Lead_SalesEnterpriseEventsProcess<TEntity> : Terrasoft.Configuration.Lead_OpportunityManagementEventsProcess<TEntity> where TEntity : Lead
	{

		public Lead_SalesEnterpriseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Lead_SalesEnterpriseEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2439c822-3b08-441e-9e5f-e93344d355d7");
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

	#region Class: Lead_SalesEnterpriseEventsProcess

	/// <exclude/>
	public class Lead_SalesEnterpriseEventsProcess : Lead_SalesEnterpriseEventsProcess<Lead>
	{

		public Lead_SalesEnterpriseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Lead_SalesEnterpriseEventsProcess

	public partial class Lead_SalesEnterpriseEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void LeadInserting() {
			base.LeadInserting();
			string bpmHrefColumnName = "BpmHref";
			string bpmRefColumnName = "BpmRef";
			string bpmHref = Entity.IsColumnValueLoaded(bpmHrefColumnName) 
				? Entity.GetTypedColumnValue<string>(bpmHrefColumnName) : String.Empty;
			string bpmRef = Entity.IsColumnValueLoaded(bpmRefColumnName) 
				? Entity.GetTypedColumnValue<string>(bpmRefColumnName) : String.Empty;
			Terrasoft.Configuration.LeadSourceHelper lsh = 
				new Terrasoft.Configuration.LeadSourceHelper(UserConnection, bpmHref, bpmRef);
			lsh.ComputeMediumAndSource();
			Guid resultLeadMediumId = lsh.ResultLeadMediumId;
			Guid resultLeadSourceId = lsh.ResultLeadSourceId;
			if (resultLeadMediumId != Guid.Empty) {
				Entity.SetColumnValue("LeadMediumId", resultLeadMediumId);
			}
			if (resultLeadSourceId != Guid.Empty) {
				Entity.SetColumnValue("LeadSourceId", resultLeadSourceId);
			}
		}

		#endregion

	}

	#endregion

	#region Class: LeadEventsProcessSchema

	/// <exclude/>
	public class LeadEventsProcessSchema : Terrasoft.Configuration.Lead_OpportunityManagement_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public LeadEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LeadEventsProcessSchema(LeadEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Lead_SalesEnterpriseEventsProcess";
			UId = new Guid("7da36be2-d18a-48e3-bee4-f2081049a18f");
			CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("8809225a-873c-47d0-b036-0b91f1749b42");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet5_d1b5a94d449143ca84ab0cb535528c8b = CreateLaneSet5_d1b5a94d449143ca84ab0cb535528c8bLaneSet();
			LaneSets.Add(schemaLaneSet5_d1b5a94d449143ca84ab0cb535528c8b);
			ProcessSchemaLane schemaLane5_5ff3677edbb34d84b7348720fb4a92d1 = CreateLane5_5ff3677edbb34d84b7348720fb4a92d1Lane();
			schemaLaneSet5_d1b5a94d449143ca84ab0cb535528c8b.Lanes.Add(schemaLane5_5ff3677edbb34d84b7348720fb4a92d1);
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet5_d1b5a94d449143ca84ab0cb535528c8bLaneSet() {
			ProcessSchemaLaneSet schemaLaneSet5_d1b5a94d449143ca84ab0cb535528c8b = new ProcessSchemaLaneSet(this) {
				UId = new Guid("d1b5a94d-4491-43ca-84ab-0cb535528c8b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6ebac0a6-c477-45bb-8d3e-6cbd90c0aa78"),
				CreatedInPackageId = new Guid("a5c00ace-6d1b-471a-b946-811548884dc8"),
				CreatedInSchemaUId = new Guid("7da36be2-d18a-48e3-bee4-f2081049a18f"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("7da36be2-d18a-48e3-bee4-f2081049a18f"),
				Name = @"LaneSet5_d1b5a94d449143ca84ab0cb535528c8b",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet5_d1b5a94d449143ca84ab0cb535528c8b;
		}

		protected virtual ProcessSchemaLane CreateLane5_5ff3677edbb34d84b7348720fb4a92d1Lane() {
			ProcessSchemaLane schemaLane5_5ff3677edbb34d84b7348720fb4a92d1 = new ProcessSchemaLane(this) {
				UId = new Guid("5ff3677e-dbb3-4d84-b734-8720fb4a92d1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1b5a94d-4491-43ca-84ab-0cb535528c8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("a5c00ace-6d1b-471a-b946-811548884dc8"),
				CreatedInSchemaUId = new Guid("7da36be2-d18a-48e3-bee4-f2081049a18f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("7da36be2-d18a-48e3-bee4-f2081049a18f"),
				Name = @"Lane5_5ff3677edbb34d84b7348720fb4a92d1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane5_5ff3677edbb34d84b7348720fb4a92d1;
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
				CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72")
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
				UId = new Guid("68e5b019-87de-4d69-b7d9-eb3b79989128"),
				Name = "Terrasoft.Configuration.PRM",
				Alias = "",
				CreatedInPackageId = new Guid("1bc37faf-30bf-4d4a-b067-5fd52b4ccffd")
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

		protected override SchemaMethod CreateLeadInsertingMethod() {
			SchemaMethod method = base.CreateLeadInsertingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,145,223,78,131,48,20,198,175,225,41,42,87,144,16,30,192,57,141,46,203,70,50,189,128,233,125,183,30,102,19,218,146,254,137,33,198,119,183,93,193,32,16,167,222,53,61,231,247,125,223,57,231,128,21,100,59,192,36,231,10,164,166,252,20,39,139,80,105,105,95,232,208,176,173,132,106,37,106,195,248,19,102,128,150,40,122,240,159,209,176,171,152,105,42,70,61,14,178,165,53,215,84,183,89,174,60,240,130,107,3,59,129,9,144,120,98,151,160,48,184,235,137,13,232,125,219,0,25,112,55,94,253,118,142,188,70,229,185,152,173,89,163,219,81,216,139,57,138,255,198,40,126,78,177,7,41,177,18,149,206,86,130,87,244,100,36,214,84,240,243,5,74,97,228,17,182,80,55,32,81,173,94,109,200,48,224,240,134,126,11,197,207,246,132,182,133,195,209,213,211,126,235,105,55,181,61,172,149,181,34,172,49,26,30,129,80,195,238,121,39,225,206,190,49,148,32,9,202,212,218,105,251,142,156,216,32,142,43,38,133,9,225,165,102,136,190,176,8,105,133,226,25,139,171,37,114,90,126,79,9,122,15,131,110,223,37,232,193,170,227,104,72,69,233,76,90,59,199,199,200,229,43,214,159,92,122,234,155,75,255,233,92,62,1,17,117,220,216,60,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LeadEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7da36be2-d18a-48e3-bee4-f2081049a18f"));
		}

		#endregion

	}

	#endregion


	#region Class: LeadEventsProcess

	/// <exclude/>
	public class LeadEventsProcess : Lead_SalesEnterpriseEventsProcess
	{

		public LeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

