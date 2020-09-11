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
	using Terrasoft.Configuration.Passport;
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

	#region Class: OrderSchema

	/// <exclude/>
	public class OrderSchema : Terrasoft.Configuration.Order_OrderInSales_TerrasoftSchema
	{

		#region Constructors: Public

		public OrderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OrderSchema(OrderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OrderSchema(OrderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("c1f6301f-aced-4265-bb12-97c4e4fa1693");
			Name = "Order";
			ParentSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			ExtendParent = true;
			CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateNumberColumn() {
			EntitySchemaColumn column = base.CreateNumberColumn();
			column.IsTrackChangesInDB = false;
			column.ModifiedInSchemaUId = new Guid("c1f6301f-aced-4265-bb12-97c4e4fa1693");
			return column;
		}

		protected override EntitySchemaColumn CreateAccountColumn() {
			EntitySchemaColumn column = base.CreateAccountColumn();
			column.IsTrackChangesInDB = false;
			column.ModifiedInSchemaUId = new Guid("c1f6301f-aced-4265-bb12-97c4e4fa1693");
			return column;
		}

		protected override EntitySchemaColumn CreateDateColumn() {
			EntitySchemaColumn column = base.CreateDateColumn();
			column.IsTrackChangesInDB = false;
			column.ModifiedInSchemaUId = new Guid("c1f6301f-aced-4265-bb12-97c4e4fa1693");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOrderEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateOrderEventsProcessSchema() {
			var schema = new OrderEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Order(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Order_PRMOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OrderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OrderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c1f6301f-aced-4265-bb12-97c4e4fa1693"));
		}

		#endregion

	}

	#endregion

	#region Class: Order

	/// <summary>
	/// Order.
	/// </summary>
	public class Order : Terrasoft.Configuration.Order_OrderInSales_Terrasoft
	{

		#region Constructors: Public

		public Order(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Order";
		}

		public Order(Order source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Order_PRMOrderEventsProcess(UserConnection);
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
			return new Order(this);
		}

		#endregion

	}

	#endregion

	#region Class: Order_PRMOrderEventsProcess

	/// <exclude/>
	public partial class Order_PRMOrderEventsProcess<TEntity> : Terrasoft.Configuration.Order_OrderInSalesEventsProcess<TEntity> where TEntity : Order
	{

		public Order_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Order_PRMOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c1f6301f-aced-4265-bb12-97c4e4fa1693");
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

	#region Class: Order_PRMOrderEventsProcess

	/// <exclude/>
	public class Order_PRMOrderEventsProcess : Order_PRMOrderEventsProcess<Order>
	{

		public Order_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Order_PRMOrderEventsProcess

	public partial class Order_PRMOrderEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void UpdateProductAmounts() {
			base.UpdateProductAmounts();
			if (NeedFinRecalc) {
				var orderAmountHelper = ClassFactory.Get<Terrasoft.Configuration.Passport.OrderAmountHelper>(new ConstructorArgument("userConnection", UserConnection));
				orderAmountHelper.UpdateAmountsByOrderId(Entity.GetTypedColumnValue<Guid>("Id"));
			}
		}

		#endregion

	}

	#endregion

	#region Class: OrderEventsProcessSchema

	/// <exclude/>
	public class OrderEventsProcessSchema : Terrasoft.Configuration.Order_OrderInSales_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public OrderEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public OrderEventsProcessSchema(OrderEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Order_PRMOrderEventsProcess";
			UId = new Guid("b6286694-75b6-4100-8173-9955bd488d54");
			CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
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
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e367e682-e0e1-481b-90fa-2080cf131acc"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c16ac00d-efc7-4f36-8327-68fce32dfe3c"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6922ed45-6469-416f-93a0-047b732a5c23"),
				Name = "Terrasoft.Configuration.Passport",
				Alias = "",
				CreatedInPackageId = new Guid("a002bd5f-14f1-4196-ac19-0a0feddeb334")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a435aadb-cccf-48cf-b82e-d0bd146a0851"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("d6ad04c1-fa0b-4adb-bfd8-17ec17775a03")
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

		protected override SchemaMethod CreateUpdateProductAmountsMethod() {
			SchemaMethod method = base.CreateUpdateProductAmountsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,143,65,110,194,48,16,69,215,112,10,43,43,71,170,124,129,2,18,141,10,101,211,162,10,186,159,218,19,100,201,25,71,227,153,162,8,113,247,38,148,77,219,237,204,211,251,255,127,66,65,119,236,3,8,238,57,7,245,178,238,178,146,20,91,63,206,99,107,236,43,98,216,68,122,71,15,201,215,230,50,159,125,1,155,204,1,249,135,124,193,212,35,155,165,105,18,148,178,1,47,153,7,183,69,89,28,144,25,74,110,197,53,153,218,120,82,6,137,153,220,126,228,250,204,226,222,254,90,86,150,240,108,70,186,8,235,36,90,243,73,59,36,177,149,22,228,241,65,232,39,71,245,96,142,191,14,245,88,119,246,175,213,125,217,125,210,211,112,11,220,5,251,76,18,229,86,242,48,244,24,154,156,180,163,15,72,138,139,173,198,176,178,213,46,84,147,242,250,13,84,85,78,194,32,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OrderEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b6286694-75b6-4100-8173-9955bd488d54"));
		}

		#endregion

	}

	#endregion


	#region Class: OrderEventsProcess

	/// <exclude/>
	public class OrderEventsProcess : Order_PRMOrderEventsProcess
	{

		public OrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

