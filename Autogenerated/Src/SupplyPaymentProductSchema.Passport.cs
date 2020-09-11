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

	#region Class: SupplyPaymentProduct_Passport_TerrasoftSchema

	/// <exclude/>
	public class SupplyPaymentProduct_Passport_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SupplyPaymentProduct_Passport_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SupplyPaymentProduct_Passport_TerrasoftSchema(SupplyPaymentProduct_Passport_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SupplyPaymentProduct_Passport_TerrasoftSchema(SupplyPaymentProduct_Passport_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIEAmEqf7ATV6vIrwdnL77pY1qU8Index() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("91b1eed5-16d3-464e-a42f-16d2d62f4ada");
			index.Name = "IEAmEqf7ATV6vIrwdnL77pY1qU8";
			index.CreatedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c");
			index.ModifiedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c");
			index.CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a");
			EntitySchemaIndexColumn productIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("f3c008c4-8798-4f49-98ab-9e3a2bbd46a7"),
				ColumnUId = new Guid("0ef3a26c-3aad-4cc7-9d86-6c8d152d26aa"),
				CreatedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				ModifiedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(productIdIndexColumn);
			EntitySchemaIndexColumn quantityIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("0dc5296c-4960-4d49-a4ee-3553cb79be2f"),
				ColumnUId = new Guid("1132d571-ee72-46ad-914f-4fb17dae6acd"),
				CreatedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				ModifiedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(quantityIndexColumn);
			EntitySchemaIndexColumn supplyPaymentElementIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("2deb8eea-7eed-4518-9339-6e788109f78a"),
				ColumnUId = new Guid("756bee7d-e59a-4e5c-a609-ab1475b575ba"),
				CreatedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				ModifiedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(supplyPaymentElementIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c");
			RealUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c");
			Name = "SupplyPaymentProduct_Passport_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("fb295fc3-2fbd-4310-9f4f-726412c4ea00");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("0ef3a26c-3aad-4cc7-9d86-6c8d152d26aa")) == null) {
				Columns.Add(CreateProductColumn());
			}
			if (Columns.FindByUId(new Guid("1132d571-ee72-46ad-914f-4fb17dae6acd")) == null) {
				Columns.Add(CreateQuantityColumn());
			}
			if (Columns.FindByUId(new Guid("731b8372-cfda-441c-ba9f-f6659d7d51e1")) == null) {
				Columns.Add(CreateAmountColumn());
			}
			if (Columns.FindByUId(new Guid("756bee7d-e59a-4e5c-a609-ab1475b575ba")) == null) {
				Columns.Add(CreateSupplyPaymentElementColumn());
			}
			if (Columns.FindByUId(new Guid("df43e248-5619-4045-a7e0-6b6a29e9aad4")) == null) {
				Columns.Add(CreateBaseQuantityColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0ef3a26c-3aad-4cc7-9d86-6c8d152d26aa"),
				Name = @"Product",
				ReferenceSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				ModifiedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				CreatedInPackageId = new Guid("fb295fc3-2fbd-4310-9f4f-726412c4ea00"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateQuantityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("1132d571-ee72-46ad-914f-4fb17dae6acd"),
				Name = @"Quantity",
				CreatedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				ModifiedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				CreatedInPackageId = new Guid("fb295fc3-2fbd-4310-9f4f-726412c4ea00")
			};
		}

		protected virtual EntitySchemaColumn CreateAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("731b8372-cfda-441c-ba9f-f6659d7d51e1"),
				Name = @"Amount",
				CreatedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				ModifiedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				CreatedInPackageId = new Guid("fb295fc3-2fbd-4310-9f4f-726412c4ea00")
			};
		}

		protected virtual EntitySchemaColumn CreateSupplyPaymentElementColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("756bee7d-e59a-4e5c-a609-ab1475b575ba"),
				Name = @"SupplyPaymentElement",
				ReferenceSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				ModifiedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				CreatedInPackageId = new Guid("fb295fc3-2fbd-4310-9f4f-726412c4ea00")
			};
		}

		protected virtual EntitySchemaColumn CreateBaseQuantityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float3")) {
				UId = new Guid("df43e248-5619-4045-a7e0-6b6a29e9aad4"),
				Name = @"BaseQuantity",
				CreatedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				ModifiedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				CreatedInPackageId = new Guid("efb45740-c35a-47f4-babf-491965306264")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIEAmEqf7ATV6vIrwdnL77pY1qU8Index());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSupplyPaymentProduct_Passport_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSupplyPaymentProduct_Passport_TerrasoftEventsProcessSchema() {
			var schema = new SupplyPaymentProduct_Passport_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SupplyPaymentProduct_Passport_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SupplyPaymentProduct_PassportEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SupplyPaymentProduct_Passport_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SupplyPaymentProduct_Passport_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"));
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentProduct_Passport_Terrasoft

	/// <summary>
	/// Products in the installment plan.
	/// </summary>
	public class SupplyPaymentProduct_Passport_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SupplyPaymentProduct_Passport_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SupplyPaymentProduct_Passport_Terrasoft";
		}

		public SupplyPaymentProduct_Passport_Terrasoft(SupplyPaymentProduct_Passport_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ProductId {
			get {
				return GetTypedColumnValue<Guid>("ProductId");
			}
			set {
				SetColumnValue("ProductId", value);
				_product = null;
			}
		}

		/// <exclude/>
		public string ProductName {
			get {
				return GetTypedColumnValue<string>("ProductName");
			}
			set {
				SetColumnValue("ProductName", value);
				if (_product != null) {
					_product.Name = value;
				}
			}
		}

		private OrderProduct _product;
		/// <summary>
		/// Product.
		/// </summary>
		public OrderProduct Product {
			get {
				return _product ??
					(_product = LookupColumnEntities.GetEntity("Product") as OrderProduct);
			}
		}

		/// <summary>
		/// Quantity.
		/// </summary>
		public Decimal Quantity {
			get {
				return GetTypedColumnValue<Decimal>("Quantity");
			}
			set {
				SetColumnValue("Quantity", value);
			}
		}

		/// <summary>
		/// Amount.
		/// </summary>
		public Decimal Amount {
			get {
				return GetTypedColumnValue<Decimal>("Amount");
			}
			set {
				SetColumnValue("Amount", value);
			}
		}

		/// <exclude/>
		public Guid SupplyPaymentElementId {
			get {
				return GetTypedColumnValue<Guid>("SupplyPaymentElementId");
			}
			set {
				SetColumnValue("SupplyPaymentElementId", value);
				_supplyPaymentElement = null;
			}
		}

		/// <exclude/>
		public string SupplyPaymentElementName {
			get {
				return GetTypedColumnValue<string>("SupplyPaymentElementName");
			}
			set {
				SetColumnValue("SupplyPaymentElementName", value);
				if (_supplyPaymentElement != null) {
					_supplyPaymentElement.Name = value;
				}
			}
		}

		private SupplyPaymentElement _supplyPaymentElement;
		/// <summary>
		/// Installment plan.
		/// </summary>
		public SupplyPaymentElement SupplyPaymentElement {
			get {
				return _supplyPaymentElement ??
					(_supplyPaymentElement = LookupColumnEntities.GetEntity("SupplyPaymentElement") as SupplyPaymentElement);
			}
		}

		/// <summary>
		/// Quantity, Base units.
		/// </summary>
		public Decimal BaseQuantity {
			get {
				return GetTypedColumnValue<Decimal>("BaseQuantity");
			}
			set {
				SetColumnValue("BaseQuantity", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SupplyPaymentProduct_PassportEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SupplyPaymentProduct_Passport_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("SupplyPaymentProduct_Passport_TerrasoftDeleting", e);
			Validating += (s, e) => ThrowEvent("SupplyPaymentProduct_Passport_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SupplyPaymentProduct_Passport_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentProduct_PassportEventsProcess

	/// <exclude/>
	public partial class SupplyPaymentProduct_PassportEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SupplyPaymentProduct_Passport_Terrasoft
	{

		public SupplyPaymentProduct_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SupplyPaymentProduct_PassportEventsProcess";
			SchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c");
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

	#region Class: SupplyPaymentProduct_PassportEventsProcess

	/// <exclude/>
	public class SupplyPaymentProduct_PassportEventsProcess : SupplyPaymentProduct_PassportEventsProcess<SupplyPaymentProduct_Passport_Terrasoft>
	{

		public SupplyPaymentProduct_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SupplyPaymentProduct_PassportEventsProcess

	public partial class SupplyPaymentProduct_PassportEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentProduct_Passport_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class SupplyPaymentProduct_Passport_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SupplyPaymentProduct_Passport_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SupplyPaymentProduct_Passport_TerrasoftEventsProcessSchema(SupplyPaymentProduct_Passport_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SupplyPaymentProduct_PassportEventsProcess";
			UId = new Guid("d4b4b70c-fe21-449c-989d-82f459a42750");
			CreatedInPackageId = new Guid("fb295fc3-2fbd-4310-9f4f-726412c4ea00");
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
				UId = new Guid("94c49450-f709-4477-b930-9db7295ca546"),
				Name = "Terrasoft.Configuration.Passport",
				Alias = "",
				CreatedInPackageId = new Guid("a002bd5f-14f1-4196-ac19-0a0feddeb334")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7bcdf9e2-ae22-42f1-adc7-ff03f7780178"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("a002bd5f-14f1-4196-ac19-0a0feddeb334")
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
			return new SupplyPaymentProduct_Passport_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d4b4b70c-fe21-449c-989d-82f459a42750"));
		}

		#endregion

	}

	#endregion

}

