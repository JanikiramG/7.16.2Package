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

	#region Class: EmailFolderColumnValuesSetting_Opportunity_TerrasoftSchema

	/// <exclude/>
	public class EmailFolderColumnValuesSetting_Opportunity_TerrasoftSchema : Terrasoft.Configuration.EmailFolderColumnValuesSetting_Base_TerrasoftSchema
	{

		#region Constructors: Public

		public EmailFolderColumnValuesSetting_Opportunity_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EmailFolderColumnValuesSetting_Opportunity_TerrasoftSchema(EmailFolderColumnValuesSetting_Opportunity_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EmailFolderColumnValuesSetting_Opportunity_TerrasoftSchema(EmailFolderColumnValuesSetting_Opportunity_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("69532f7a-527b-44ac-833d-61570d0ad673");
			Name = "EmailFolderColumnValuesSetting_Opportunity_Terrasoft";
			ParentSchemaUId = new Guid("77ffb765-d7ad-4f91-9027-92cdf97b4c1f");
			ExtendParent = true;
			CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("62283f71-c300-41f6-aa2b-0bd2cb7348ea")) == null) {
				Columns.Add(CreateOpportunityColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateOpportunityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("62283f71-c300-41f6-aa2b-0bd2cb7348ea"),
				Name = @"Opportunity",
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("69532f7a-527b-44ac-833d-61570d0ad673"),
				ModifiedInSchemaUId = new Guid("69532f7a-527b-44ac-833d-61570d0ad673"),
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateEmailFolderColumnValuesSetting_Opportunity_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateEmailFolderColumnValuesSetting_Opportunity_TerrasoftEventsProcessSchema() {
			var schema = new EmailFolderColumnValuesSetting_Opportunity_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new EmailFolderColumnValuesSetting_Opportunity_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EmailFolderColumnValuesSetting_OpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EmailFolderColumnValuesSetting_Opportunity_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EmailFolderColumnValuesSetting_Opportunity_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("69532f7a-527b-44ac-833d-61570d0ad673"));
		}

		#endregion

	}

	#endregion

	#region Class: EmailFolderColumnValuesSetting_Opportunity_Terrasoft

	/// <summary>
	/// Setup of email folder field values.
	/// </summary>
	public class EmailFolderColumnValuesSetting_Opportunity_Terrasoft : Terrasoft.Configuration.EmailFolderColumnValuesSetting_Base_Terrasoft
	{

		#region Constructors: Public

		public EmailFolderColumnValuesSetting_Opportunity_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EmailFolderColumnValuesSetting_Opportunity_Terrasoft";
		}

		public EmailFolderColumnValuesSetting_Opportunity_Terrasoft(EmailFolderColumnValuesSetting_Opportunity_Terrasoft source)
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
			var process = new EmailFolderColumnValuesSetting_OpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("EmailFolderColumnValuesSetting_Opportunity_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("EmailFolderColumnValuesSetting_Opportunity_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("EmailFolderColumnValuesSetting_Opportunity_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EmailFolderColumnValuesSetting_Opportunity_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: EmailFolderColumnValuesSetting_OpportunityEventsProcess

	/// <exclude/>
	public partial class EmailFolderColumnValuesSetting_OpportunityEventsProcess<TEntity> : Terrasoft.Configuration.EmailFolderColumnValuesSetting_BaseEventsProcess<TEntity> where TEntity : EmailFolderColumnValuesSetting_Opportunity_Terrasoft
	{

		public EmailFolderColumnValuesSetting_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EmailFolderColumnValuesSetting_OpportunityEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("69532f7a-527b-44ac-833d-61570d0ad673");
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

	#region Class: EmailFolderColumnValuesSetting_OpportunityEventsProcess

	/// <exclude/>
	public class EmailFolderColumnValuesSetting_OpportunityEventsProcess : EmailFolderColumnValuesSetting_OpportunityEventsProcess<EmailFolderColumnValuesSetting_Opportunity_Terrasoft>
	{

		public EmailFolderColumnValuesSetting_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EmailFolderColumnValuesSetting_OpportunityEventsProcess

	public partial class EmailFolderColumnValuesSetting_OpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: EmailFolderColumnValuesSetting_Opportunity_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class EmailFolderColumnValuesSetting_Opportunity_TerrasoftEventsProcessSchema : Terrasoft.Configuration.EmailFolderColumnValuesSetting_Base_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public EmailFolderColumnValuesSetting_Opportunity_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public EmailFolderColumnValuesSetting_Opportunity_TerrasoftEventsProcessSchema(EmailFolderColumnValuesSetting_Opportunity_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "EmailFolderColumnValuesSetting_OpportunityEventsProcess";
			UId = new Guid("417b2810-3343-43e0-b078-15ed9a1cd23f");
			CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("d93b1958-9229-49a3-a69b-22996633b6b3");
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
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6")
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
			return new EmailFolderColumnValuesSetting_Opportunity_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("417b2810-3343-43e0-b078-15ed9a1cd23f"));
		}

		#endregion

	}

	#endregion

}

