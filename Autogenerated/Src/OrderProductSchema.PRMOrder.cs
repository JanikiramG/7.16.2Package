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

	#region Class: OrderProduct_PRMOrder_TerrasoftSchema

	/// <exclude/>
	public class OrderProduct_PRMOrder_TerrasoftSchema : Terrasoft.Configuration.OrderProduct_Passport_TerrasoftSchema
	{

		#region Constructors: Public

		public OrderProduct_PRMOrder_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OrderProduct_PRMOrder_TerrasoftSchema(OrderProduct_PRMOrder_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OrderProduct_PRMOrder_TerrasoftSchema(OrderProduct_PRMOrder_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("1e7d093d-bab7-4ded-aa2e-6032727b09b7");
			Name = "OrderProduct_PRMOrder_Terrasoft";
			ParentSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			ExtendParent = true;
			CreatedInPackageId = new Guid("5ad21e1a-95d7-43e1-8821-5a5bb2a4bde1");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeMasterRecordColumn() {
			base.InitializeMasterRecordColumn();
			MasterRecordColumn = CreateOrderColumn();
			if (Columns.FindByUId(MasterRecordColumn.UId) == null) {
				Columns.Add(MasterRecordColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOrderProduct_PRMOrder_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateOrderProduct_PRMOrder_TerrasoftEventsProcessSchema() {
			var schema = new OrderProduct_PRMOrder_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OrderProduct_PRMOrder_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OrderProduct_PRMOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OrderProduct_PRMOrder_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OrderProduct_PRMOrder_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1e7d093d-bab7-4ded-aa2e-6032727b09b7"));
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_PRMOrder_Terrasoft

	/// <summary>
	/// Product in order.
	/// </summary>
	public class OrderProduct_PRMOrder_Terrasoft : Terrasoft.Configuration.OrderProduct_Passport_Terrasoft
	{

		#region Constructors: Public

		public OrderProduct_PRMOrder_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OrderProduct_PRMOrder_Terrasoft";
		}

		public OrderProduct_PRMOrder_Terrasoft(OrderProduct_PRMOrder_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OrderProduct_PRMOrderEventsProcess(UserConnection);
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
			return new OrderProduct_PRMOrder_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_PRMOrderEventsProcess

	/// <exclude/>
	public partial class OrderProduct_PRMOrderEventsProcess<TEntity> : Terrasoft.Configuration.OrderProduct_PassportEventsProcess<TEntity> where TEntity : OrderProduct_PRMOrder_Terrasoft
	{

		public OrderProduct_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OrderProduct_PRMOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1e7d093d-bab7-4ded-aa2e-6032727b09b7");
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

	#region Class: OrderProduct_PRMOrderEventsProcess

	/// <exclude/>
	public class OrderProduct_PRMOrderEventsProcess : OrderProduct_PRMOrderEventsProcess<OrderProduct_PRMOrder_Terrasoft>
	{

		public OrderProduct_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OrderProduct_PRMOrderEventsProcess

	public partial class OrderProduct_PRMOrderEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void RecalculateOrderAmount() {
			base.RecalculateOrderAmount();
			var helper = ClassFactory.Get<OrderAmountHelper>(new ConstructorArgument("userConnection", UserConnection));
			if (IsProductDeleted){
				if (SupplyPaymentElementsToRecalc != null) {
					var speIds = (List<Guid>)SupplyPaymentElementsToRecalc;
					helper.OnOrderProductDeleted(Entity.GetTypedColumnValue<Guid>("OrderId"), speIds);
				}
			} else {
				var changedColumnValues = ChangedColumnValues as IEnumerable<EntityColumnValue>;
				helper.OnOrderProductChanged(Entity.PrimaryColumnValue, changedColumnValues);
			}
		}

		public override void UpdatePrimaryAmounts() {
			if (NeedRecalcPrimaryValues){
				base.UpdatePrimaryAmounts();
			}
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_PRMOrder_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class OrderProduct_PRMOrder_TerrasoftEventsProcessSchema : Terrasoft.Configuration.OrderProduct_Passport_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public OrderProduct_PRMOrder_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public OrderProduct_PRMOrder_TerrasoftEventsProcessSchema(OrderProduct_PRMOrder_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OrderProduct_PRMOrderEventsProcess";
			UId = new Guid("ec9aef09-8701-4412-bb38-35cf41d09059");
			CreatedInPackageId = new Guid("5ad21e1a-95d7-43e1-8821-5a5bb2a4bde1");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58");
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
				UId = new Guid("548ae0cd-ca9a-4b2e-bceb-0a9122f820fe"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("ea2e3ae4-7b44-4850-bdfa-8147ce4d763d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("56e97a4f-c9b4-4a16-ad24-0d5926b8d5a1"),
				Name = "Terrasoft.Configuration.Passport",
				Alias = "",
				CreatedInPackageId = new Guid("ea2e3ae4-7b44-4850-bdfa-8147ce4d763d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("205fe81c-724a-4cdd-84e3-8959f298b37c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("205fe81c-724a-4cdd-84e3-8959f298b37c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("205fe81c-724a-4cdd-84e3-8959f298b37c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("205fe81c-724a-4cdd-84e3-8959f298b37c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("205fe81c-724a-4cdd-84e3-8959f298b37c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("205fe81c-724a-4cdd-84e3-8959f298b37c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("205fe81c-724a-4cdd-84e3-8959f298b37c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f4ae16a-b6b6-4ad3-a4ea-e8db646b0b90"),
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

		protected override SchemaMethod CreateRecalculateOrderAmountMethod() {
			SchemaMethod method = base.CreateRecalculateOrderAmountMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,221,106,131,64,16,133,175,21,124,135,173,87,10,226,11,196,8,193,218,84,40,68,218,180,247,27,119,154,8,227,174,236,79,139,148,188,123,29,77,65,33,244,106,97,230,156,51,223,217,19,55,144,190,66,195,177,113,200,45,28,180,0,189,235,148,147,54,138,55,129,255,197,53,187,0,246,160,217,150,21,200,141,121,226,141,85,122,72,247,96,179,133,250,121,18,229,145,132,111,86,40,105,172,118,164,219,233,179,235,96,12,11,157,1,61,46,36,52,182,85,50,76,216,251,106,16,211,181,246,147,69,149,169,181,18,163,249,17,16,44,136,248,39,240,61,90,188,185,190,199,161,230,3,229,149,8,244,152,163,154,225,217,195,150,73,135,24,51,146,123,132,109,122,168,132,25,177,163,151,214,216,108,239,90,145,199,255,134,108,200,58,183,77,15,114,42,183,102,137,74,105,91,59,117,63,14,61,136,66,161,235,228,7,71,7,115,126,20,78,174,74,132,113,114,3,160,94,222,53,240,175,12,208,192,132,71,116,205,133,203,243,42,129,80,139,59,83,110,88,85,202,241,23,53,63,33,100,51,194,66,145,211,129,187,212,183,180,63,234,90,183,29,215,75,107,114,15,131,128,71,222,95,248,207,38,227,26,2,0,0 };
			return method;
		}

		protected override SchemaMethod CreateUpdatePrimaryAmountsMethod() {
			SchemaMethod method = base.CreateUpdatePrimaryAmountsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,240,75,77,77,9,74,77,78,204,73,14,40,202,204,77,44,170,12,75,204,41,77,45,214,172,230,229,226,76,74,44,78,213,11,45,72,73,44,73,133,74,58,230,230,151,230,149,20,107,104,90,243,114,213,2,0,89,182,162,134,63,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OrderProduct_PRMOrder_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ec9aef09-8701-4412-bb38-35cf41d09059"));
		}

		#endregion

	}

	#endregion

}

