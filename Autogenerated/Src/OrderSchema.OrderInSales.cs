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
	using Terrasoft.Configuration;
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

	#region Class: Order_OrderInSales_TerrasoftSchema

	/// <exclude/>
	public class Order_OrderInSales_TerrasoftSchema : Terrasoft.Configuration.Order_Passport_TerrasoftSchema
	{

		#region Constructors: Public

		public Order_OrderInSales_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Order_OrderInSales_TerrasoftSchema(Order_OrderInSales_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Order_OrderInSales_TerrasoftSchema(Order_OrderInSales_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("243f55eb-0a8f-4508-a570-c3c2606c3403");
			Name = "Order_OrderInSales_Terrasoft";
			ParentSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			ExtendParent = true;
			CreatedInPackageId = new Guid("11b832b1-75bb-4c0d-bb5d-5aa5088efe52");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("7fe04af6-f7c7-4bb2-8413-b65da9e4f33c")) == null) {
				Columns.Add(CreateOpportunityColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateOpportunityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7fe04af6-f7c7-4bb2-8413-b65da9e4f33c"),
				Name = @"Opportunity",
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("243f55eb-0a8f-4508-a570-c3c2606c3403"),
				ModifiedInSchemaUId = new Guid("243f55eb-0a8f-4508-a570-c3c2606c3403"),
				CreatedInPackageId = new Guid("8aa371b9-719f-4904-b382-2e02c0a6ba74")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOrder_OrderInSales_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateOrder_OrderInSales_TerrasoftEventsProcessSchema() {
			var schema = new Order_OrderInSales_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Order_OrderInSales_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Order_OrderInSalesEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Order_OrderInSales_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Order_OrderInSales_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("243f55eb-0a8f-4508-a570-c3c2606c3403"));
		}

		#endregion

	}

	#endregion

	#region Class: Order_OrderInSales_Terrasoft

	/// <summary>
	/// Order.
	/// </summary>
	public class Order_OrderInSales_Terrasoft : Terrasoft.Configuration.Order_Passport_Terrasoft
	{

		#region Constructors: Public

		public Order_OrderInSales_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Order_OrderInSales_Terrasoft";
		}

		public Order_OrderInSales_Terrasoft(Order_OrderInSales_Terrasoft source)
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
			var process = new Order_OrderInSalesEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Order_OrderInSales_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("Order_OrderInSales_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Order_OrderInSales_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Order_OrderInSales_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Order_OrderInSales_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Order_OrderInSales_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Order_OrderInSalesEventsProcess

	/// <exclude/>
	public partial class Order_OrderInSalesEventsProcess<TEntity> : Terrasoft.Configuration.Order_PassportEventsProcess<TEntity> where TEntity : Order_OrderInSales_Terrasoft
	{

		public Order_OrderInSalesEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Order_OrderInSalesEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("243f55eb-0a8f-4508-a570-c3c2606c3403");
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

	#region Class: Order_OrderInSalesEventsProcess

	/// <exclude/>
	public class Order_OrderInSalesEventsProcess : Order_OrderInSalesEventsProcess<Order_OrderInSales_Terrasoft>
	{

		public Order_OrderInSalesEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Order_OrderInSalesEventsProcess

	public partial class Order_OrderInSalesEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: Order_OrderInSales_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Order_OrderInSales_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Order_Passport_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Order_OrderInSales_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Order_OrderInSales_TerrasoftEventsProcessSchema(Order_OrderInSales_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Order_OrderInSalesEventsProcess";
			UId = new Guid("b5d4e427-4f0f-4b1a-94f3-a15ba1ebe08a");
			CreatedInPackageId = new Guid("11b832b1-75bb-4c0d-bb5d-5aa5088efe52");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b");
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
				CreatedInPackageId = new Guid("11b832b1-75bb-4c0d-bb5d-5aa5088efe52")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("11b832b1-75bb-4c0d-bb5d-5aa5088efe52")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("11b832b1-75bb-4c0d-bb5d-5aa5088efe52")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("11b832b1-75bb-4c0d-bb5d-5aa5088efe52")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("11b832b1-75bb-4c0d-bb5d-5aa5088efe52")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("11b832b1-75bb-4c0d-bb5d-5aa5088efe52")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("11b832b1-75bb-4c0d-bb5d-5aa5088efe52")
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e367e682-e0e1-481b-90fa-2080cf131acc"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a435aadb-cccf-48cf-b82e-d0bd146a0851"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("d6ad04c1-fa0b-4adb-bfd8-17ec17775a03")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Order_OrderInSales_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b5d4e427-4f0f-4b1a-94f3-a15ba1ebe08a"));
		}

		#endregion

	}

	#endregion

}

