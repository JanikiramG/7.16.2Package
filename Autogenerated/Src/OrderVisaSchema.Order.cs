namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using System.Text;
	using System.Text.RegularExpressions;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration.RightsService;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Mail;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: OrderVisaSchema

	/// <exclude/>
	public class OrderVisaSchema : Terrasoft.Configuration.BaseVisaSchema
	{

		#region Constructors: Public

		public OrderVisaSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OrderVisaSchema(OrderVisaSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OrderVisaSchema(OrderVisaSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5ebe74ce-17ca-4c68-97e6-8e25e01e47c5");
			RealUId = new Guid("5ebe74ce-17ca-4c68-97e6-8e25e01e47c5");
			Name = "OrderVisa";
			ParentSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66");
			ExtendParent = false;
			CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("20073fe5-438b-4250-bdb9-1cc0573c7db3")) == null) {
				Columns.Add(CreateOrderColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateOrderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("20073fe5-438b-4250-bdb9-1cc0573c7db3"),
				Name = @"Order",
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("5ebe74ce-17ca-4c68-97e6-8e25e01e47c5"),
				ModifiedInSchemaUId = new Guid("5ebe74ce-17ca-4c68-97e6-8e25e01e47c5"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOrderVisaEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateOrderVisaEventsProcessSchema() {
			var schema = new OrderVisaEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OrderVisa(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OrderVisa_OrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OrderVisaSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OrderVisaSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5ebe74ce-17ca-4c68-97e6-8e25e01e47c5"));
		}

		#endregion

	}

	#endregion

	#region Class: OrderVisa

	/// <summary>
	/// Order approval.
	/// </summary>
	public class OrderVisa : Terrasoft.Configuration.BaseVisa
	{

		#region Constructors: Public

		public OrderVisa(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OrderVisa";
		}

		public OrderVisa(OrderVisa source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid OrderId {
			get {
				return GetTypedColumnValue<Guid>("OrderId");
			}
			set {
				SetColumnValue("OrderId", value);
				_order = null;
			}
		}

		/// <exclude/>
		public string OrderNumber {
			get {
				return GetTypedColumnValue<string>("OrderNumber");
			}
			set {
				SetColumnValue("OrderNumber", value);
				if (_order != null) {
					_order.Number = value;
				}
			}
		}

		private Order _order;
		/// <summary>
		/// Order.
		/// </summary>
		public Order Order {
			get {
				return _order ??
					(_order = LookupColumnEntities.GetEntity("Order") as Order);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OrderVisa_OrderEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("OrderVisaInserting", e);
			Validating += (s, e) => ThrowEvent("OrderVisaValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OrderVisa(this);
		}

		#endregion

	}

	#endregion

	#region Class: OrderVisa_OrderEventsProcess

	/// <exclude/>
	public partial class OrderVisa_OrderEventsProcess<TEntity> : Terrasoft.Configuration.BaseVisa_NUIEventsProcess<TEntity> where TEntity : OrderVisa
	{

		public OrderVisa_OrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OrderVisa_OrderEventsProcess";
			SchemaUId = new Guid("5ebe74ce-17ca-4c68-97e6-8e25e01e47c5");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5ebe74ce-17ca-4c68-97e6-8e25e01e47c5");
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

	#region Class: OrderVisa_OrderEventsProcess

	/// <exclude/>
	public class OrderVisa_OrderEventsProcess : OrderVisa_OrderEventsProcess<OrderVisa>
	{

		public OrderVisa_OrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OrderVisa_OrderEventsProcess

	public partial class OrderVisa_OrderEventsProcess<TEntity>
	{

		#region Methods: Public

		public override List<string> GetVisaTemplateSchemaQueryColumns() {
			List<string> columns = base.GetVisaTemplateSchemaQueryColumns();
			columns.AddRange( new string[] {
				"Order.Number",
				"Order.Date",
				"Order.Currency.ShortName",
				"Order.Amount",
				"Order.Owner.Name",
				"Order.Contact.Name",
				"Order.Account.Name"
			});
			return columns;
		}

		public override INotificationInfo GetNotificationInfo() {
			Entity.Order.FetchFromDB(Entity.OrderId);
			var order = Entity.Order;	
			var orderDate = order.Date.ToString(PopupBodyDateFormat);
			var accountName = order.AccountName;
			var contactName = order.ContactName;
			var accountContactString = string.Join(", ", new[] {accountName, contactName}.Where(s => s.IsNotEmpty()));
			var body = string.Format(PopupBodyTemplate, order.Number, orderDate, accountContactString);
			var notificationInfo = base.GetNotificationInfo();
			notificationInfo.EntityId = order.Id;
			notificationInfo.Body = body;
			return notificationInfo;
		}

		#endregion

	}

	#endregion

	#region Class: OrderVisaEventsProcessSchema

	/// <exclude/>
	public class OrderVisaEventsProcessSchema : Terrasoft.Configuration.BaseVisaEventsProcessSchema
	{

		#region Constructors: Public

		public OrderVisaEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public OrderVisaEventsProcessSchema(OrderVisaEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OrderVisa_OrderEventsProcess";
			UId = new Guid("85fe4cd4-c8b0-4fc3-9344-8ef0fb6cfaf1");
			CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet2_c228eb2c686246ca995c7ff8abb8429a = CreateLaneSet2_c228eb2c686246ca995c7ff8abb8429aLaneSet();
			LaneSets.Add(schemaLaneSet2_c228eb2c686246ca995c7ff8abb8429a);
			ProcessSchemaLane schemaLane1_15f73962490a4d8e9436f975b32b66c6 = CreateLane1_15f73962490a4d8e9436f975b32b66c6Lane();
			schemaLaneSet2_c228eb2c686246ca995c7ff8abb8429a.Lanes.Add(schemaLane1_15f73962490a4d8e9436f975b32b66c6);
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_c228eb2c686246ca995c7ff8abb8429aLaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_c228eb2c686246ca995c7ff8abb8429a = new ProcessSchemaLaneSet(this) {
				UId = new Guid("c228eb2c-6862-46ca-995c-7ff8abb8429a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("e8c4bc03-2f14-47b7-8005-47fab57cc1b8"),
				CreatedInSchemaUId = new Guid("85fe4cd4-c8b0-4fc3-9344-8ef0fb6cfaf1"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("85fe4cd4-c8b0-4fc3-9344-8ef0fb6cfaf1"),
				Name = @"LaneSet2_c228eb2c686246ca995c7ff8abb8429a",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_c228eb2c686246ca995c7ff8abb8429a;
		}

		protected virtual ProcessSchemaLane CreateLane1_15f73962490a4d8e9436f975b32b66c6Lane() {
			ProcessSchemaLane schemaLane1_15f73962490a4d8e9436f975b32b66c6 = new ProcessSchemaLane(this) {
				UId = new Guid("15f73962-490a-4d8e-9436-f975b32b66c6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c228eb2c-6862-46ca-995c-7ff8abb8429a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("e8c4bc03-2f14-47b7-8005-47fab57cc1b8"),
				CreatedInSchemaUId = new Guid("85fe4cd4-c8b0-4fc3-9344-8ef0fb6cfaf1"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("85fe4cd4-c8b0-4fc3-9344-8ef0fb6cfaf1"),
				Name = @"Lane1_15f73962490a4d8e9436f975b32b66c6",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1_15f73962490a4d8e9436f975b32b66c6;
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
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b4ea420f-1747-4595-ab25-789126e98c6b"),
				Name = "Terrasoft.Mail",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b77beabe-3462-4019-89ec-c7f463df7906"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("995f3b91-8c49-4a3e-91e8-844a842e4cf2"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("370cbd11-d7ba-41e3-92a8-c2e20475dfbc"),
				Name = "Terrasoft.Configuration.RightsService",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("60de445f-ad8e-4e3f-9462-87883ee929ac"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("868a8008-4580-40bf-9a3e-88b0ed6fd0af"),
				Name = "System.Collections",
				Alias = "",
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fdad31d6-a4d0-48ab-ac06-588a5897466d"),
				Name = "System.Text.RegularExpressions",
				Alias = "",
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("af74f3ab-a423-4d68-94c0-9cf65b0acea5"),
				Name = "Terrasoft.Messaging.Common",
				Alias = "",
				CreatedInPackageId = new Guid("7f0d2206-b4d4-499c-aac2-6529fbb3d8c3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d5bb3512-71e0-482a-9c7e-16bf22c586b7"),
				Name = "Terrasoft.Nui.ServiceModel.DataContract",
				Alias = "DataContract",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("be94874c-996f-4f96-b0a8-7dfeaccae86f"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c261d1c9-cc98-44e8-aabd-7806d1dc26ec"),
				Name = "Terrasoft.Core.DcmProcess",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		protected override SchemaMethod CreateGetVisaTemplateSchemaQueryColumnsMethod() {
			SchemaMethod method = base.CreateGetVisaTemplateSchemaQueryColumnsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,143,193,10,130,64,16,134,207,249,20,139,39,131,240,5,172,64,12,186,132,82,70,151,232,176,174,131,10,238,108,204,206,34,18,189,123,138,21,214,113,190,249,255,143,153,67,99,121,109,153,26,172,182,66,153,214,105,180,98,35,10,105,33,220,3,95,26,43,207,160,239,173,100,200,85,13,90,30,29,80,159,76,193,96,25,121,239,78,24,151,229,73,98,5,129,64,232,196,100,188,222,196,195,91,248,25,149,64,97,234,116,1,228,175,190,96,55,56,103,99,226,136,0,85,31,230,181,33,78,165,158,47,99,109,28,242,12,100,29,142,206,223,84,98,144,165,226,127,28,43,53,182,39,236,61,135,163,9,216,17,126,254,141,94,23,138,250,92,5,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetNotificationInfoMethod() {
			SchemaMethod method = base.CreateGetNotificationInfoMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,81,193,74,196,48,16,61,43,248,15,193,83,10,37,63,80,86,176,110,43,221,67,87,112,193,131,120,72,211,89,55,96,50,37,157,42,69,252,119,211,109,107,186,235,66,14,51,243,222,204,155,55,201,44,105,234,197,214,213,224,68,14,164,14,185,67,179,78,121,182,0,138,58,74,110,174,63,165,99,56,164,108,197,150,104,114,181,192,214,146,192,227,199,88,12,137,216,225,51,57,109,223,249,19,54,93,147,98,221,15,229,28,157,145,52,143,149,74,97,103,169,148,38,52,223,135,218,196,82,104,73,170,83,214,67,168,157,206,154,128,81,219,211,219,99,32,54,168,45,191,141,153,127,22,190,94,223,216,247,66,59,94,74,252,136,151,3,56,224,45,91,221,177,86,20,109,137,148,153,134,122,30,69,243,222,149,119,19,102,143,158,130,207,29,152,230,195,123,141,167,93,203,206,84,224,226,112,168,248,226,178,243,112,139,164,247,90,73,210,104,11,187,71,47,84,201,22,196,35,80,121,6,241,161,231,156,47,198,79,42,234,191,99,21,245,37,90,58,154,24,188,120,216,1,117,206,254,19,79,126,1,113,94,76,204,41,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OrderVisaEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("85fe4cd4-c8b0-4fc3-9344-8ef0fb6cfaf1"));
		}

		#endregion

	}

	#endregion


	#region Class: OrderVisaEventsProcess

	/// <exclude/>
	public class OrderVisaEventsProcess : OrderVisa_OrderEventsProcess
	{

		public OrderVisaEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

