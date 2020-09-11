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

	#region Class: Contract_SalesContracts_TerrasoftSchema

	/// <exclude/>
	public class Contract_SalesContracts_TerrasoftSchema : Terrasoft.Configuration.Contract_CoreContracts_TerrasoftSchema
	{

		#region Constructors: Public

		public Contract_SalesContracts_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Contract_SalesContracts_TerrasoftSchema(Contract_SalesContracts_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Contract_SalesContracts_TerrasoftSchema(Contract_SalesContracts_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("463a2ce9-85a4-4b8c-9ac2-a98b80ac08c1");
			Name = "Contract_SalesContracts_Terrasoft";
			ParentSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810");
			ExtendParent = true;
			CreatedInPackageId = new Guid("8fca2d52-b411-4398-ba35-ffd14745bc94");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("0561563f-b671-4042-9e2e-4feb3f3fcb53")) == null) {
				Columns.Add(CreateCurrencyColumn());
			}
			if (Columns.FindByUId(new Guid("bc319d17-d7a1-4aeb-8f1e-36ec18941db0")) == null) {
				Columns.Add(CreateCurrencyRateColumn());
			}
			if (Columns.FindByUId(new Guid("5ff95d4a-7286-4bac-9a51-d9cd908e2bfe")) == null) {
				Columns.Add(CreateAmountColumn());
			}
			if (Columns.FindByUId(new Guid("a58b9876-0419-47ba-aa66-4f487ba132d0")) == null) {
				Columns.Add(CreatePrimaryAmountColumn());
			}
		}

		protected override EntitySchemaColumn CreateTypeColumn() {
			EntitySchemaColumn column = base.CreateTypeColumn();
			column.ModifiedInSchemaUId = new Guid("463a2ce9-85a4-4b8c-9ac2-a98b80ac08c1");
			return column;
		}

		protected virtual EntitySchemaColumn CreateCurrencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0561563f-b671-4042-9e2e-4feb3f3fcb53"),
				Name = @"Currency",
				ReferenceSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("463a2ce9-85a4-4b8c-9ac2-a98b80ac08c1"),
				ModifiedInSchemaUId = new Guid("463a2ce9-85a4-4b8c-9ac2-a98b80ac08c1"),
				CreatedInPackageId = new Guid("8fca2d52-b411-4398-ba35-ffd14745bc94"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"PrimaryCurrency"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateCurrencyRateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float8")) {
				UId = new Guid("bc319d17-d7a1-4aeb-8f1e-36ec18941db0"),
				Name = @"CurrencyRate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("463a2ce9-85a4-4b8c-9ac2-a98b80ac08c1"),
				ModifiedInSchemaUId = new Guid("463a2ce9-85a4-4b8c-9ac2-a98b80ac08c1"),
				CreatedInPackageId = new Guid("8fca2d52-b411-4398-ba35-ffd14745bc94")
			};
		}

		protected virtual EntitySchemaColumn CreateAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("5ff95d4a-7286-4bac-9a51-d9cd908e2bfe"),
				Name = @"Amount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("463a2ce9-85a4-4b8c-9ac2-a98b80ac08c1"),
				ModifiedInSchemaUId = new Guid("463a2ce9-85a4-4b8c-9ac2-a98b80ac08c1"),
				CreatedInPackageId = new Guid("8fca2d52-b411-4398-ba35-ffd14745bc94")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("a58b9876-0419-47ba-aa66-4f487ba132d0"),
				Name = @"PrimaryAmount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("463a2ce9-85a4-4b8c-9ac2-a98b80ac08c1"),
				ModifiedInSchemaUId = new Guid("463a2ce9-85a4-4b8c-9ac2-a98b80ac08c1"),
				CreatedInPackageId = new Guid("8fca2d52-b411-4398-ba35-ffd14745bc94")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateContract_SalesContracts_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateContract_SalesContracts_TerrasoftEventsProcessSchema() {
			var schema = new Contract_SalesContracts_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Contract_SalesContracts_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Contract_SalesContractsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Contract_SalesContracts_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Contract_SalesContracts_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("463a2ce9-85a4-4b8c-9ac2-a98b80ac08c1"));
		}

		#endregion

	}

	#endregion

	#region Class: Contract_SalesContracts_Terrasoft

	/// <summary>
	/// Contract.
	/// </summary>
	public class Contract_SalesContracts_Terrasoft : Terrasoft.Configuration.Contract_CoreContracts_Terrasoft
	{

		#region Constructors: Public

		public Contract_SalesContracts_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contract_SalesContracts_Terrasoft";
		}

		public Contract_SalesContracts_Terrasoft(Contract_SalesContracts_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid CurrencyId {
			get {
				return GetTypedColumnValue<Guid>("CurrencyId");
			}
			set {
				SetColumnValue("CurrencyId", value);
				_currency = null;
			}
		}

		/// <exclude/>
		public string CurrencyName {
			get {
				return GetTypedColumnValue<string>("CurrencyName");
			}
			set {
				SetColumnValue("CurrencyName", value);
				if (_currency != null) {
					_currency.Name = value;
				}
			}
		}

		private Currency _currency;
		/// <summary>
		/// Currency.
		/// </summary>
		public Currency Currency {
			get {
				return _currency ??
					(_currency = LookupColumnEntities.GetEntity("Currency") as Currency);
			}
		}

		/// <summary>
		/// Exchange rate.
		/// </summary>
		public Decimal CurrencyRate {
			get {
				return GetTypedColumnValue<Decimal>("CurrencyRate");
			}
			set {
				SetColumnValue("CurrencyRate", value);
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

		/// <summary>
		/// Amount, base currency.
		/// </summary>
		public Decimal PrimaryAmount {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryAmount");
			}
			set {
				SetColumnValue("PrimaryAmount", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Contract_SalesContractsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Contract_SalesContracts_TerrasoftDeleted", e);
			Validating += (s, e) => ThrowEvent("Contract_SalesContracts_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Contract_SalesContracts_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Contract_SalesContractsEventsProcess

	/// <exclude/>
	public partial class Contract_SalesContractsEventsProcess<TEntity> : Terrasoft.Configuration.Contract_CoreContractsEventsProcess<TEntity> where TEntity : Contract_SalesContracts_Terrasoft
	{

		public Contract_SalesContractsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Contract_SalesContractsEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("463a2ce9-85a4-4b8c-9ac2-a98b80ac08c1");
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

	#region Class: Contract_SalesContractsEventsProcess

	/// <exclude/>
	public class Contract_SalesContractsEventsProcess : Contract_SalesContractsEventsProcess<Contract_SalesContracts_Terrasoft>
	{

		public Contract_SalesContractsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Contract_SalesContractsEventsProcess

	public partial class Contract_SalesContractsEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: Contract_SalesContracts_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Contract_SalesContracts_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Contract_CoreContracts_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Contract_SalesContracts_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Contract_SalesContracts_TerrasoftEventsProcessSchema(Contract_SalesContracts_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Contract_SalesContractsEventsProcess";
			UId = new Guid("23a3d81d-008b-49a5-8830-30fe183b4640");
			CreatedInPackageId = new Guid("8fca2d52-b411-4398-ba35-ffd14745bc94");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("37f144c9-f2b6-4c56-8111-460248e89c07");
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
			return new Contract_SalesContracts_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("23a3d81d-008b-49a5-8830-30fe183b4640"));
		}

		#endregion

	}

	#endregion

}

