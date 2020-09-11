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

	#region Class: LeadInQualifyStatus_Lead_TerrasoftSchema

	/// <exclude/>
	public class LeadInQualifyStatus_Lead_TerrasoftSchema : Terrasoft.Configuration.BaseEntityInStageSchema
	{

		#region Constructors: Public

		public LeadInQualifyStatus_Lead_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LeadInQualifyStatus_Lead_TerrasoftSchema(LeadInQualifyStatus_Lead_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LeadInQualifyStatus_Lead_TerrasoftSchema(LeadInQualifyStatus_Lead_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("071aba13-b2b4-4050-aa8f-dab49a65b4b1");
			RealUId = new Guid("071aba13-b2b4-4050-aa8f-dab49a65b4b1");
			Name = "LeadInQualifyStatus_Lead_Terrasoft";
			ParentSchemaUId = new Guid("86cb4c67-4231-4904-be40-b9019d87311d");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f9fafc40-d3f4-4cb9-84c5-854e0eeffd97");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("c206c35e-5504-4e34-905b-d59ab54f754e")) == null) {
				Columns.Add(CreateLeadColumn());
			}
			if (Columns.FindByUId(new Guid("e02b4e41-afa4-4124-9d4d-ba9b1ddf14a0")) == null) {
				Columns.Add(CreateQualifyStatusColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateLeadColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c206c35e-5504-4e34-905b-d59ab54f754e"),
				Name = @"Lead",
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("071aba13-b2b4-4050-aa8f-dab49a65b4b1"),
				ModifiedInSchemaUId = new Guid("071aba13-b2b4-4050-aa8f-dab49a65b4b1"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06")
			};
		}

		protected virtual EntitySchemaColumn CreateQualifyStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e02b4e41-afa4-4124-9d4d-ba9b1ddf14a0"),
				Name = @"QualifyStatus",
				ReferenceSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("071aba13-b2b4-4050-aa8f-dab49a65b4b1"),
				ModifiedInSchemaUId = new Guid("071aba13-b2b4-4050-aa8f-dab49a65b4b1"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLeadInQualifyStatus_Lead_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateLeadInQualifyStatus_Lead_TerrasoftEventsProcessSchema() {
			var schema = new LeadInQualifyStatus_Lead_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LeadInQualifyStatus_Lead_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LeadInQualifyStatus_LeadEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LeadInQualifyStatus_Lead_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LeadInQualifyStatus_Lead_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("071aba13-b2b4-4050-aa8f-dab49a65b4b1"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadInQualifyStatus_Lead_Terrasoft

	/// <summary>
	/// Stage in lead.
	/// </summary>
	public class LeadInQualifyStatus_Lead_Terrasoft : Terrasoft.Configuration.BaseEntityInStage
	{

		#region Constructors: Public

		public LeadInQualifyStatus_Lead_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LeadInQualifyStatus_Lead_Terrasoft";
		}

		public LeadInQualifyStatus_Lead_Terrasoft(LeadInQualifyStatus_Lead_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid LeadId {
			get {
				return GetTypedColumnValue<Guid>("LeadId");
			}
			set {
				SetColumnValue("LeadId", value);
				_lead = null;
			}
		}

		/// <exclude/>
		public string LeadLeadName {
			get {
				return GetTypedColumnValue<string>("LeadLeadName");
			}
			set {
				SetColumnValue("LeadLeadName", value);
				if (_lead != null) {
					_lead.LeadName = value;
				}
			}
		}

		private Lead _lead;
		/// <summary>
		/// Lead.
		/// </summary>
		public Lead Lead {
			get {
				return _lead ??
					(_lead = LookupColumnEntities.GetEntity("Lead") as Lead);
			}
		}

		/// <exclude/>
		public Guid QualifyStatusId {
			get {
				return GetTypedColumnValue<Guid>("QualifyStatusId");
			}
			set {
				SetColumnValue("QualifyStatusId", value);
				_qualifyStatus = null;
			}
		}

		/// <exclude/>
		public string QualifyStatusName {
			get {
				return GetTypedColumnValue<string>("QualifyStatusName");
			}
			set {
				SetColumnValue("QualifyStatusName", value);
				if (_qualifyStatus != null) {
					_qualifyStatus.Name = value;
				}
			}
		}

		private QualifyStatus _qualifyStatus;
		/// <summary>
		/// Lead stage.
		/// </summary>
		public QualifyStatus QualifyStatus {
			get {
				return _qualifyStatus ??
					(_qualifyStatus = LookupColumnEntities.GetEntity("QualifyStatus") as QualifyStatus);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LeadInQualifyStatus_LeadEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LeadInQualifyStatus_Lead_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: LeadInQualifyStatus_LeadEventsProcess

	/// <exclude/>
	public partial class LeadInQualifyStatus_LeadEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntityInStage_BaseEventsProcess<TEntity> where TEntity : LeadInQualifyStatus_Lead_Terrasoft
	{

		public LeadInQualifyStatus_LeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadInQualifyStatus_LeadEventsProcess";
			SchemaUId = new Guid("071aba13-b2b4-4050-aa8f-dab49a65b4b1");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("071aba13-b2b4-4050-aa8f-dab49a65b4b1");
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

	#region Class: LeadInQualifyStatus_LeadEventsProcess

	/// <exclude/>
	public class LeadInQualifyStatus_LeadEventsProcess : LeadInQualifyStatus_LeadEventsProcess<LeadInQualifyStatus_Lead_Terrasoft>
	{

		public LeadInQualifyStatus_LeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LeadInQualifyStatus_LeadEventsProcess

	public partial class LeadInQualifyStatus_LeadEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: LeadInQualifyStatus_Lead_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class LeadInQualifyStatus_Lead_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityInStageEventsProcessSchema
	{

		#region Constructors: Public

		public LeadInQualifyStatus_Lead_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LeadInQualifyStatus_Lead_TerrasoftEventsProcessSchema(LeadInQualifyStatus_Lead_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LeadInQualifyStatus_LeadEventsProcess";
			UId = new Guid("2a914d4e-dd35-4d05-a0aa-e096db3484a4");
			CreatedInPackageId = new Guid("f9fafc40-d3f4-4cb9-84c5-854e0eeffd97");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("96547ce4-b9e3-41a6-a89e-b30ee2729a2b");
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
			return new LeadInQualifyStatus_Lead_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2a914d4e-dd35-4d05-a0aa-e096db3484a4"));
		}

		#endregion

	}

	#endregion

}

