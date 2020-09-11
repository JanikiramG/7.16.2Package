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

	#region Class: OrderProduct_ProductCatalogueInOrder_TerrasoftSchema

	/// <exclude/>
	public class OrderProduct_ProductCatalogueInOrder_TerrasoftSchema : Terrasoft.Configuration.OrderProduct_Order_TerrasoftSchema
	{

		#region Constructors: Public

		public OrderProduct_ProductCatalogueInOrder_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OrderProduct_ProductCatalogueInOrder_TerrasoftSchema(OrderProduct_ProductCatalogueInOrder_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OrderProduct_ProductCatalogueInOrder_TerrasoftSchema(OrderProduct_ProductCatalogueInOrder_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("6a489998-7f84-4171-815d-5894a5826838");
			Name = "OrderProduct_ProductCatalogueInOrder_Terrasoft";
			ParentSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			ExtendParent = true;
			CreatedInPackageId = new Guid("205fe81c-724a-4cdd-84e3-8959f298b37c");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreatePriceListColumn() {
			EntitySchemaColumn column = base.CreatePriceListColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"fa689c95-c63c-4908-8fd2-19a95e0425bd"
			};
			column.ModifiedInSchemaUId = new Guid("6a489998-7f84-4171-815d-5894a5826838");
			column.CreatedInPackageId = new Guid("205fe81c-724a-4cdd-84e3-8959f298b37c");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOrderProduct_ProductCatalogueInOrder_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateOrderProduct_ProductCatalogueInOrder_TerrasoftEventsProcessSchema() {
			var schema = new OrderProduct_ProductCatalogueInOrder_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OrderProduct_ProductCatalogueInOrder_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OrderProduct_ProductCatalogueInOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OrderProduct_ProductCatalogueInOrder_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OrderProduct_ProductCatalogueInOrder_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6a489998-7f84-4171-815d-5894a5826838"));
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_ProductCatalogueInOrder_Terrasoft

	/// <summary>
	/// Product in order.
	/// </summary>
	public class OrderProduct_ProductCatalogueInOrder_Terrasoft : Terrasoft.Configuration.OrderProduct_Order_Terrasoft
	{

		#region Constructors: Public

		public OrderProduct_ProductCatalogueInOrder_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OrderProduct_ProductCatalogueInOrder_Terrasoft";
		}

		public OrderProduct_ProductCatalogueInOrder_Terrasoft(OrderProduct_ProductCatalogueInOrder_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OrderProduct_ProductCatalogueInOrderEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("OrderProduct_ProductCatalogueInOrder_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("OrderProduct_ProductCatalogueInOrder_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OrderProduct_ProductCatalogueInOrder_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_ProductCatalogueInOrderEventsProcess

	/// <exclude/>
	public partial class OrderProduct_ProductCatalogueInOrderEventsProcess<TEntity> : Terrasoft.Configuration.OrderProduct_OrderEventsProcess<TEntity> where TEntity : OrderProduct_ProductCatalogueInOrder_Terrasoft
	{

		public OrderProduct_ProductCatalogueInOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OrderProduct_ProductCatalogueInOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6a489998-7f84-4171-815d-5894a5826838");
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

	#region Class: OrderProduct_ProductCatalogueInOrderEventsProcess

	/// <exclude/>
	public class OrderProduct_ProductCatalogueInOrderEventsProcess : OrderProduct_ProductCatalogueInOrderEventsProcess<OrderProduct_ProductCatalogueInOrder_Terrasoft>
	{

		public OrderProduct_ProductCatalogueInOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OrderProduct_ProductCatalogueInOrderEventsProcess

	public partial class OrderProduct_ProductCatalogueInOrderEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void UpdatePrimaryAmounts() {
			if (NeedRecalcPrimaryValues){
				base.UpdatePrimaryAmounts();
			}
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_ProductCatalogueInOrder_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class OrderProduct_ProductCatalogueInOrder_TerrasoftEventsProcessSchema : Terrasoft.Configuration.OrderProduct_Order_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public OrderProduct_ProductCatalogueInOrder_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public OrderProduct_ProductCatalogueInOrder_TerrasoftEventsProcessSchema(OrderProduct_ProductCatalogueInOrder_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OrderProduct_ProductCatalogueInOrderEventsProcess";
			UId = new Guid("08608fcc-386b-4eb4-8161-dda6e4024794");
			CreatedInPackageId = new Guid("205fe81c-724a-4cdd-84e3-8959f298b37c");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("d81b042c-af0c-4cb4-af65-2a192919ae3d");
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

		protected override SchemaMethod CreateUpdatePrimaryAmountsMethod() {
			SchemaMethod method = base.CreateUpdatePrimaryAmountsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,240,75,77,77,9,74,77,78,204,73,14,40,202,204,77,44,170,12,75,204,41,77,45,214,172,230,229,226,76,74,44,78,213,11,45,72,73,44,73,133,74,58,230,230,151,230,149,20,107,104,90,243,114,213,2,0,89,182,162,134,63,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OrderProduct_ProductCatalogueInOrder_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("08608fcc-386b-4eb4-8161-dda6e4024794"));
		}

		#endregion

	}

	#endregion

}

