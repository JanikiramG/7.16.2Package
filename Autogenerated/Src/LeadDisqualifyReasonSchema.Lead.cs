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

	#region Class: LeadDisqualifyReasonSchema

	/// <exclude/>
	public class LeadDisqualifyReasonSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public LeadDisqualifyReasonSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LeadDisqualifyReasonSchema(LeadDisqualifyReasonSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LeadDisqualifyReasonSchema(LeadDisqualifyReasonSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("086904b2-10a7-4156-bb21-c23a98228ace");
			RealUId = new Guid("086904b2-10a7-4156-bb21-c23a98228ace");
			Name = "LeadDisqualifyReason";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("086904b2-10a7-4156-bb21-c23a98228ace");
			column.CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("086904b2-10a7-4156-bb21-c23a98228ace");
			column.CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("086904b2-10a7-4156-bb21-c23a98228ace");
			column.CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("086904b2-10a7-4156-bb21-c23a98228ace");
			column.CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("086904b2-10a7-4156-bb21-c23a98228ace");
			column.CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("086904b2-10a7-4156-bb21-c23a98228ace");
			column.CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("086904b2-10a7-4156-bb21-c23a98228ace");
			column.CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("086904b2-10a7-4156-bb21-c23a98228ace");
			column.CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLeadDisqualifyReasonEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateLeadDisqualifyReasonEventsProcessSchema() {
			var schema = new LeadDisqualifyReasonEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LeadDisqualifyReason(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LeadDisqualifyReason_LeadEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LeadDisqualifyReasonSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LeadDisqualifyReasonSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("086904b2-10a7-4156-bb21-c23a98228ace"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadDisqualifyReason

	/// <summary>
	/// Disqualification reason.
	/// </summary>
	public class LeadDisqualifyReason : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public LeadDisqualifyReason(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LeadDisqualifyReason";
		}

		public LeadDisqualifyReason(LeadDisqualifyReason source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LeadDisqualifyReason_LeadEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("LeadDisqualifyReasonDeleted", e);
			Inserting += (s, e) => ThrowEvent("LeadDisqualifyReasonInserting", e);
			Validating += (s, e) => ThrowEvent("LeadDisqualifyReasonValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LeadDisqualifyReason(this);
		}

		#endregion

	}

	#endregion

	#region Class: LeadDisqualifyReason_LeadEventsProcess

	/// <exclude/>
	public partial class LeadDisqualifyReason_LeadEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : LeadDisqualifyReason
	{

		public LeadDisqualifyReason_LeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadDisqualifyReason_LeadEventsProcess";
			SchemaUId = new Guid("086904b2-10a7-4156-bb21-c23a98228ace");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("086904b2-10a7-4156-bb21-c23a98228ace");
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

	#region Class: LeadDisqualifyReason_LeadEventsProcess

	/// <exclude/>
	public class LeadDisqualifyReason_LeadEventsProcess : LeadDisqualifyReason_LeadEventsProcess<LeadDisqualifyReason>
	{

		public LeadDisqualifyReason_LeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LeadDisqualifyReason_LeadEventsProcess

	public partial class LeadDisqualifyReason_LeadEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: LeadDisqualifyReasonEventsProcessSchema

	/// <exclude/>
	public class LeadDisqualifyReasonEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public LeadDisqualifyReasonEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LeadDisqualifyReasonEventsProcessSchema(LeadDisqualifyReasonEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LeadDisqualifyReason_LeadEventsProcess";
			UId = new Guid("34e5c2c9-8a6e-4254-80c0-4f5fc6eadcac");
			CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577");
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
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577")
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
			return new LeadDisqualifyReasonEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("34e5c2c9-8a6e-4254-80c0-4f5fc6eadcac"));
		}

		#endregion

	}

	#endregion


	#region Class: LeadDisqualifyReasonEventsProcess

	/// <exclude/>
	public class LeadDisqualifyReasonEventsProcess : LeadDisqualifyReason_LeadEventsProcess
	{

		public LeadDisqualifyReasonEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

