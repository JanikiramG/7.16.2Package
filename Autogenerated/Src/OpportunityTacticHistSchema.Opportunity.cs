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

	#region Class: OpportunityTacticHistSchema

	/// <exclude/>
	public class OpportunityTacticHistSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public OpportunityTacticHistSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityTacticHistSchema(OpportunityTacticHistSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityTacticHistSchema(OpportunityTacticHistSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fa59b9ec-2339-465b-80c3-b4928fa0ea33");
			RealUId = new Guid("fa59b9ec-2339-465b-80c3-b4928fa0ea33");
			Name = "OpportunityTacticHist";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e899430a-48fa-4f6a-9b67-5894fb68c21a");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("beceea29-c777-4c3c-8f75-1dcf744669f1")) == null) {
				Columns.Add(CreateTacticsColumn());
			}
			if (Columns.FindByUId(new Guid("e8795bde-27ed-4fd4-8f16-c65a2fc3916e")) == null) {
				Columns.Add(CreateCheckDateColumn());
			}
			if (Columns.FindByUId(new Guid("7c4a4905-83b5-46ce-8e55-91462c2d11dc")) == null) {
				Columns.Add(CreateModifyDateColumn());
			}
			if (Columns.FindByUId(new Guid("22fce03b-6a18-46ef-b5fc-24f55aa83663")) == null) {
				Columns.Add(CreateOpportunityColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("fa59b9ec-2339-465b-80c3-b4928fa0ea33");
			column.CreatedInPackageId = new Guid("e899430a-48fa-4f6a-9b67-5894fb68c21a");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("fa59b9ec-2339-465b-80c3-b4928fa0ea33");
			column.CreatedInPackageId = new Guid("e899430a-48fa-4f6a-9b67-5894fb68c21a");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("fa59b9ec-2339-465b-80c3-b4928fa0ea33");
			column.CreatedInPackageId = new Guid("e899430a-48fa-4f6a-9b67-5894fb68c21a");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("fa59b9ec-2339-465b-80c3-b4928fa0ea33");
			column.CreatedInPackageId = new Guid("e899430a-48fa-4f6a-9b67-5894fb68c21a");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("fa59b9ec-2339-465b-80c3-b4928fa0ea33");
			column.CreatedInPackageId = new Guid("e899430a-48fa-4f6a-9b67-5894fb68c21a");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("fa59b9ec-2339-465b-80c3-b4928fa0ea33");
			column.CreatedInPackageId = new Guid("e899430a-48fa-4f6a-9b67-5894fb68c21a");
			return column;
		}

		protected virtual EntitySchemaColumn CreateTacticsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("beceea29-c777-4c3c-8f75-1dcf744669f1"),
				Name = @"Tactics",
				CreatedInSchemaUId = new Guid("fa59b9ec-2339-465b-80c3-b4928fa0ea33"),
				ModifiedInSchemaUId = new Guid("fa59b9ec-2339-465b-80c3-b4928fa0ea33"),
				CreatedInPackageId = new Guid("e899430a-48fa-4f6a-9b67-5894fb68c21a")
			};
		}

		protected virtual EntitySchemaColumn CreateCheckDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("e8795bde-27ed-4fd4-8f16-c65a2fc3916e"),
				Name = @"CheckDate",
				CreatedInSchemaUId = new Guid("fa59b9ec-2339-465b-80c3-b4928fa0ea33"),
				ModifiedInSchemaUId = new Guid("fa59b9ec-2339-465b-80c3-b4928fa0ea33"),
				CreatedInPackageId = new Guid("e899430a-48fa-4f6a-9b67-5894fb68c21a")
			};
		}

		protected virtual EntitySchemaColumn CreateModifyDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("7c4a4905-83b5-46ce-8e55-91462c2d11dc"),
				Name = @"ModifyDate",
				CreatedInSchemaUId = new Guid("fa59b9ec-2339-465b-80c3-b4928fa0ea33"),
				ModifiedInSchemaUId = new Guid("fa59b9ec-2339-465b-80c3-b4928fa0ea33"),
				CreatedInPackageId = new Guid("e899430a-48fa-4f6a-9b67-5894fb68c21a")
			};
		}

		protected virtual EntitySchemaColumn CreateOpportunityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("22fce03b-6a18-46ef-b5fc-24f55aa83663"),
				Name = @"Opportunity",
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fa59b9ec-2339-465b-80c3-b4928fa0ea33"),
				ModifiedInSchemaUId = new Guid("fa59b9ec-2339-465b-80c3-b4928fa0ea33"),
				CreatedInPackageId = new Guid("e899430a-48fa-4f6a-9b67-5894fb68c21a")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOpportunityTacticHistEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateOpportunityTacticHistEventsProcessSchema() {
			var schema = new OpportunityTacticHistEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OpportunityTacticHist(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityTacticHist_OpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityTacticHistSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityTacticHistSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fa59b9ec-2339-465b-80c3-b4928fa0ea33"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityTacticHist

	/// <summary>
	/// Sales tactics history.
	/// </summary>
	public class OpportunityTacticHist : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public OpportunityTacticHist(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityTacticHist";
		}

		public OpportunityTacticHist(OpportunityTacticHist source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Sales tactics.
		/// </summary>
		public string Tactics {
			get {
				return GetTypedColumnValue<string>("Tactics");
			}
			set {
				SetColumnValue("Tactics", value);
			}
		}

		/// <summary>
		/// Verified on.
		/// </summary>
		public DateTime CheckDate {
			get {
				return GetTypedColumnValue<DateTime>("CheckDate");
			}
			set {
				SetColumnValue("CheckDate", value);
			}
		}

		/// <summary>
		/// Modified on.
		/// </summary>
		public DateTime ModifyDate {
			get {
				return GetTypedColumnValue<DateTime>("ModifyDate");
			}
			set {
				SetColumnValue("ModifyDate", value);
			}
		}

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
			var process = new OpportunityTacticHist_OpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OpportunityTacticHistDeleted", e);
			Inserting += (s, e) => ThrowEvent("OpportunityTacticHistInserting", e);
			Validating += (s, e) => ThrowEvent("OpportunityTacticHistValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityTacticHist(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityTacticHist_OpportunityEventsProcess

	/// <exclude/>
	public partial class OpportunityTacticHist_OpportunityEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : OpportunityTacticHist
	{

		public OpportunityTacticHist_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityTacticHist_OpportunityEventsProcess";
			SchemaUId = new Guid("fa59b9ec-2339-465b-80c3-b4928fa0ea33");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fa59b9ec-2339-465b-80c3-b4928fa0ea33");
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

	#region Class: OpportunityTacticHist_OpportunityEventsProcess

	/// <exclude/>
	public class OpportunityTacticHist_OpportunityEventsProcess : OpportunityTacticHist_OpportunityEventsProcess<OpportunityTacticHist>
	{

		public OpportunityTacticHist_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunityTacticHist_OpportunityEventsProcess

	public partial class OpportunityTacticHist_OpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: OpportunityTacticHistEventsProcessSchema

	/// <exclude/>
	public class OpportunityTacticHistEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public OpportunityTacticHistEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public OpportunityTacticHistEventsProcessSchema(OpportunityTacticHistEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OpportunityTacticHist_OpportunityEventsProcess";
			UId = new Guid("840b9b20-8147-4caf-9c21-76e82db4cdb4");
			CreatedInPackageId = new Guid("e899430a-48fa-4f6a-9b67-5894fb68c21a");
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
				CreatedInPackageId = new Guid("e899430a-48fa-4f6a-9b67-5894fb68c21a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("e899430a-48fa-4f6a-9b67-5894fb68c21a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("e899430a-48fa-4f6a-9b67-5894fb68c21a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("e899430a-48fa-4f6a-9b67-5894fb68c21a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("e899430a-48fa-4f6a-9b67-5894fb68c21a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e899430a-48fa-4f6a-9b67-5894fb68c21a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e899430a-48fa-4f6a-9b67-5894fb68c21a")
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
			return new OpportunityTacticHistEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("840b9b20-8147-4caf-9c21-76e82db4cdb4"));
		}

		#endregion

	}

	#endregion


	#region Class: OpportunityTacticHistEventsProcess

	/// <exclude/>
	public class OpportunityTacticHistEventsProcess : OpportunityTacticHist_OpportunityEventsProcess
	{

		public OpportunityTacticHistEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

