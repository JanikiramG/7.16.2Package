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

	#region Class: VwOpportunityInStageSchema

	/// <exclude/>
	public class VwOpportunityInStageSchema : Terrasoft.Configuration.OpportunityInStageSchema
	{

		#region Constructors: Public

		public VwOpportunityInStageSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwOpportunityInStageSchema(VwOpportunityInStageSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwOpportunityInStageSchema(VwOpportunityInStageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385");
			RealUId = new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385");
			Name = "VwOpportunityInStage";
			ParentSchemaUId = new Guid("670a893d-5eed-421d-b5d9-1db15b5d9ab6");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3e6297d5-b6c6-4703-a5bc-154a906c8a25");
			IsDBView = true;
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
			if (Columns.FindByUId(new Guid("82a4ba38-b4c0-450f-98f0-523a4ff58c90")) == null) {
				Columns.Add(CreateStageNumberColumn());
			}
			if (Columns.FindByUId(new Guid("4b246f52-5433-4d2a-9bac-1f44ae38f970")) == null) {
				Columns.Add(CreateAmountColumn());
			}
			if (Columns.FindByUId(new Guid("d0251a34-366d-48ab-9487-d14e95e6f510")) == null) {
				Columns.Add(CreatePrimaryCurrencySymbolColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385");
			column.CreatedInPackageId = new Guid("d3e6e211-3ade-40f4-a8bd-7597c41dcdfe");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385");
			column.CreatedInPackageId = new Guid("d3e6e211-3ade-40f4-a8bd-7597c41dcdfe");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385");
			column.CreatedInPackageId = new Guid("d3e6e211-3ade-40f4-a8bd-7597c41dcdfe");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385");
			column.CreatedInPackageId = new Guid("d3e6e211-3ade-40f4-a8bd-7597c41dcdfe");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385");
			column.CreatedInPackageId = new Guid("d3e6e211-3ade-40f4-a8bd-7597c41dcdfe");
			return column;
		}

		protected override EntitySchemaColumn CreateOpportunityColumn() {
			EntitySchemaColumn column = base.CreateOpportunityColumn();
			column.ModifiedInSchemaUId = new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385");
			column.CreatedInPackageId = new Guid("d3e6e211-3ade-40f4-a8bd-7597c41dcdfe");
			return column;
		}

		protected override EntitySchemaColumn CreateStageColumn() {
			EntitySchemaColumn column = base.CreateStageColumn();
			column.ModifiedInSchemaUId = new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385");
			column.CreatedInPackageId = new Guid("d3e6e211-3ade-40f4-a8bd-7597c41dcdfe");
			return column;
		}

		protected override EntitySchemaColumn CreateStartDateColumn() {
			EntitySchemaColumn column = base.CreateStartDateColumn();
			column.ModifiedInSchemaUId = new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385");
			column.CreatedInPackageId = new Guid("d3e6e211-3ade-40f4-a8bd-7597c41dcdfe");
			return column;
		}

		protected override EntitySchemaColumn CreateDueDateColumn() {
			EntitySchemaColumn column = base.CreateDueDateColumn();
			column.ModifiedInSchemaUId = new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385");
			column.CreatedInPackageId = new Guid("d3e6e211-3ade-40f4-a8bd-7597c41dcdfe");
			return column;
		}

		protected override EntitySchemaColumn CreateOwnerColumn() {
			EntitySchemaColumn column = base.CreateOwnerColumn();
			column.ModifiedInSchemaUId = new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385");
			column.CreatedInPackageId = new Guid("d3e6e211-3ade-40f4-a8bd-7597c41dcdfe");
			return column;
		}

		protected override EntitySchemaColumn CreateCommentsColumn() {
			EntitySchemaColumn column = base.CreateCommentsColumn();
			column.ModifiedInSchemaUId = new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385");
			column.CreatedInPackageId = new Guid("d3e6e211-3ade-40f4-a8bd-7597c41dcdfe");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385");
			column.CreatedInPackageId = new Guid("d3e6e211-3ade-40f4-a8bd-7597c41dcdfe");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("1bc2b3d1-8b19-46aa-b3c5-8579d276a23f"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385"),
				ModifiedInSchemaUId = new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385"),
				CreatedInPackageId = new Guid("d3e6e211-3ade-40f4-a8bd-7597c41dcdfe")
			};
		}

		protected virtual EntitySchemaColumn CreateStageNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("82a4ba38-b4c0-450f-98f0-523a4ff58c90"),
				Name = @"StageNumber",
				CreatedInSchemaUId = new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385"),
				ModifiedInSchemaUId = new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385"),
				CreatedInPackageId = new Guid("299aa982-7b66-457f-8180-2115389bc06f")
			};
		}

		protected virtual EntitySchemaColumn CreateAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("4b246f52-5433-4d2a-9bac-1f44ae38f970"),
				Name = @"Amount",
				CreatedInSchemaUId = new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385"),
				ModifiedInSchemaUId = new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385"),
				CreatedInPackageId = new Guid("d3e6e211-3ade-40f4-a8bd-7597c41dcdfe")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryCurrencySymbolColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("d0251a34-366d-48ab-9487-d14e95e6f510"),
				Name = @"PrimaryCurrencySymbol",
				CreatedInSchemaUId = new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385"),
				ModifiedInSchemaUId = new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385"),
				CreatedInPackageId = new Guid("8957ea5b-97f7-4bd3-945c-7e13b0567362")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwOpportunityInStageEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwOpportunityInStageEventsProcessSchema() {
			var schema = new VwOpportunityInStageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwOpportunityInStage(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwOpportunityInStage_OpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwOpportunityInStageSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwOpportunityInStageSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385"));
		}

		#endregion

	}

	#endregion

	#region Class: VwOpportunityInStage

	/// <summary>
	/// Opportunity stages view.
	/// </summary>
	public class VwOpportunityInStage : Terrasoft.Configuration.OpportunityInStage
	{

		#region Constructors: Public

		public VwOpportunityInStage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwOpportunityInStage";
		}

		public VwOpportunityInStage(VwOpportunityInStage source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Stage name.
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
		/// Stage number.
		/// </summary>
		public int StageNumber {
			get {
				return GetTypedColumnValue<int>("StageNumber");
			}
			set {
				SetColumnValue("StageNumber", value);
			}
		}

		/// <summary>
		/// Amount.
		/// </summary>
		public Decimal Amount {
			get {
				return GetTypedColumnValue<Decimal>("Amount");
			}
			set {
				SetColumnValue("Amount", value);
			}
		}

		/// <summary>
		/// Base currency symbol.
		/// </summary>
		public string PrimaryCurrencySymbol {
			get {
				return GetTypedColumnValue<string>("PrimaryCurrencySymbol");
			}
			set {
				SetColumnValue("PrimaryCurrencySymbol", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwOpportunityInStage_OpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwOpportunityInStageDeleted", e);
			Inserting += (s, e) => ThrowEvent("VwOpportunityInStageInserting", e);
			Validating += (s, e) => ThrowEvent("VwOpportunityInStageValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwOpportunityInStage(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwOpportunityInStage_OpportunityEventsProcess

	/// <exclude/>
	public partial class VwOpportunityInStage_OpportunityEventsProcess<TEntity> : Terrasoft.Configuration.OpportunityInStage_PRMPortalEventsProcess<TEntity> where TEntity : VwOpportunityInStage
	{

		public VwOpportunityInStage_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwOpportunityInStage_OpportunityEventsProcess";
			SchemaUId = new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8a03c126-7f82-49a3-8df3-b420e59dd385");
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

	#region Class: VwOpportunityInStage_OpportunityEventsProcess

	/// <exclude/>
	public class VwOpportunityInStage_OpportunityEventsProcess : VwOpportunityInStage_OpportunityEventsProcess<VwOpportunityInStage>
	{

		public VwOpportunityInStage_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwOpportunityInStage_OpportunityEventsProcess

	public partial class VwOpportunityInStage_OpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwOpportunityInStageEventsProcessSchema

	/// <exclude/>
	public class VwOpportunityInStageEventsProcessSchema : Terrasoft.Configuration.OpportunityInStageEventsProcessSchema
	{

		#region Constructors: Public

		public VwOpportunityInStageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwOpportunityInStageEventsProcessSchema(VwOpportunityInStageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwOpportunityInStage_OpportunityEventsProcess";
			UId = new Guid("85c80837-e90f-45da-9620-7a5350554b4e");
			CreatedInPackageId = new Guid("d3e6e211-3ade-40f4-a8bd-7597c41dcdfe");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("cff77af8-56bc-4be4-89ec-c83540044bb9");
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
				CreatedInPackageId = new Guid("d3e6e211-3ade-40f4-a8bd-7597c41dcdfe")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("d3e6e211-3ade-40f4-a8bd-7597c41dcdfe")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("d3e6e211-3ade-40f4-a8bd-7597c41dcdfe")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("d3e6e211-3ade-40f4-a8bd-7597c41dcdfe")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("d3e6e211-3ade-40f4-a8bd-7597c41dcdfe")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("d3e6e211-3ade-40f4-a8bd-7597c41dcdfe")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("d3e6e211-3ade-40f4-a8bd-7597c41dcdfe")
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
			return new VwOpportunityInStageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("85c80837-e90f-45da-9620-7a5350554b4e"));
		}

		#endregion

	}

	#endregion


	#region Class: VwOpportunityInStageEventsProcess

	/// <exclude/>
	public class VwOpportunityInStageEventsProcess : VwOpportunityInStage_OpportunityEventsProcess
	{

		public VwOpportunityInStageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

