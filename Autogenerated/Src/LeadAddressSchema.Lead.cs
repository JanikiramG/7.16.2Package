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

	#region Class: LeadAddressSchema

	/// <exclude/>
	public class LeadAddressSchema : Terrasoft.Configuration.BaseAddressSchema
	{

		#region Constructors: Public

		public LeadAddressSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LeadAddressSchema(LeadAddressSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LeadAddressSchema(LeadAddressSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ea2ad15f-82cc-418c-a5dd-0c554e6ec419");
			RealUId = new Guid("ea2ad15f-82cc-418c-a5dd-0c554e6ec419");
			Name = "LeadAddress";
			ParentSchemaUId = new Guid("400e8687-9616-480d-9d81-61de0235cc86");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a0361711-6e10-4202-b9d8-1a4d54d702ec")) == null) {
				Columns.Add(CreateLeadColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("ea2ad15f-82cc-418c-a5dd-0c554e6ec419");
			column.CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("ea2ad15f-82cc-418c-a5dd-0c554e6ec419");
			column.CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("ea2ad15f-82cc-418c-a5dd-0c554e6ec419");
			column.CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("ea2ad15f-82cc-418c-a5dd-0c554e6ec419");
			column.CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("ea2ad15f-82cc-418c-a5dd-0c554e6ec419");
			column.CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd");
			return column;
		}

		protected override EntitySchemaColumn CreateAddressTypeColumn() {
			EntitySchemaColumn column = base.CreateAddressTypeColumn();
			column.ModifiedInSchemaUId = new Guid("ea2ad15f-82cc-418c-a5dd-0c554e6ec419");
			column.CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd");
			return column;
		}

		protected override EntitySchemaColumn CreateCountryColumn() {
			EntitySchemaColumn column = base.CreateCountryColumn();
			column.ModifiedInSchemaUId = new Guid("ea2ad15f-82cc-418c-a5dd-0c554e6ec419");
			column.CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd");
			return column;
		}

		protected override EntitySchemaColumn CreateRegionColumn() {
			EntitySchemaColumn column = base.CreateRegionColumn();
			column.ModifiedInSchemaUId = new Guid("ea2ad15f-82cc-418c-a5dd-0c554e6ec419");
			column.CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd");
			return column;
		}

		protected override EntitySchemaColumn CreateCityColumn() {
			EntitySchemaColumn column = base.CreateCityColumn();
			column.ModifiedInSchemaUId = new Guid("ea2ad15f-82cc-418c-a5dd-0c554e6ec419");
			column.CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd");
			return column;
		}

		protected override EntitySchemaColumn CreateAddressColumn() {
			EntitySchemaColumn column = base.CreateAddressColumn();
			column.ModifiedInSchemaUId = new Guid("ea2ad15f-82cc-418c-a5dd-0c554e6ec419");
			column.CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd");
			return column;
		}

		protected override EntitySchemaColumn CreateZipColumn() {
			EntitySchemaColumn column = base.CreateZipColumn();
			column.ModifiedInSchemaUId = new Guid("ea2ad15f-82cc-418c-a5dd-0c554e6ec419");
			column.CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd");
			return column;
		}

		protected override EntitySchemaColumn CreatePrimaryColumn() {
			EntitySchemaColumn column = base.CreatePrimaryColumn();
			column.ModifiedInSchemaUId = new Guid("ea2ad15f-82cc-418c-a5dd-0c554e6ec419");
			column.CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("ea2ad15f-82cc-418c-a5dd-0c554e6ec419");
			column.CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd");
			return column;
		}

		protected virtual EntitySchemaColumn CreateLeadColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a0361711-6e10-4202-b9d8-1a4d54d702ec"),
				Name = @"Lead",
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ea2ad15f-82cc-418c-a5dd-0c554e6ec419"),
				ModifiedInSchemaUId = new Guid("ea2ad15f-82cc-418c-a5dd-0c554e6ec419"),
				CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLeadAddressEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateLeadAddressEventsProcessSchema() {
			var schema = new LeadAddressEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LeadAddress(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LeadAddress_LeadEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LeadAddressSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LeadAddressSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ea2ad15f-82cc-418c-a5dd-0c554e6ec419"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadAddress

	/// <summary>
	/// Address of lead.
	/// </summary>
	public class LeadAddress : Terrasoft.Configuration.BaseAddress
	{

		#region Constructors: Public

		public LeadAddress(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LeadAddress";
		}

		public LeadAddress(LeadAddress source)
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LeadAddress_LeadEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("LeadAddressDeleted", e);
			Inserting += (s, e) => ThrowEvent("LeadAddressInserting", e);
			Validating += (s, e) => ThrowEvent("LeadAddressValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LeadAddress(this);
		}

		#endregion

	}

	#endregion

	#region Class: LeadAddress_LeadEventsProcess

	/// <exclude/>
	public partial class LeadAddress_LeadEventsProcess<TEntity> : Terrasoft.Configuration.BaseAddress_BaseEventsProcess<TEntity> where TEntity : LeadAddress
	{

		public LeadAddress_LeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadAddress_LeadEventsProcess";
			SchemaUId = new Guid("ea2ad15f-82cc-418c-a5dd-0c554e6ec419");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ea2ad15f-82cc-418c-a5dd-0c554e6ec419");
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

	#region Class: LeadAddress_LeadEventsProcess

	/// <exclude/>
	public class LeadAddress_LeadEventsProcess : LeadAddress_LeadEventsProcess<LeadAddress>
	{

		public LeadAddress_LeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LeadAddress_LeadEventsProcess

	public partial class LeadAddress_LeadEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: LeadAddressEventsProcessSchema

	/// <exclude/>
	public class LeadAddressEventsProcessSchema : Terrasoft.Configuration.BaseAddressEventsProcessSchema
	{

		#region Constructors: Public

		public LeadAddressEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LeadAddressEventsProcessSchema(LeadAddressEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LeadAddress_LeadEventsProcess";
			UId = new Guid("b7ed23cd-1537-4c14-acb5-93e1afda07a8");
			CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a");
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
				CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd")
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
			return new LeadAddressEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b7ed23cd-1537-4c14-acb5-93e1afda07a8"));
		}

		#endregion

	}

	#endregion


	#region Class: LeadAddressEventsProcess

	/// <exclude/>
	public class LeadAddressEventsProcess : LeadAddress_LeadEventsProcess
	{

		public LeadAddressEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

