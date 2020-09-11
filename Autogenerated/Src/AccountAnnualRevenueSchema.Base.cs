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

	#region Class: AccountAnnualRevenueSchema

	/// <exclude/>
	public class AccountAnnualRevenueSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public AccountAnnualRevenueSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountAnnualRevenueSchema(AccountAnnualRevenueSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountAnnualRevenueSchema(AccountAnnualRevenueSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("24d201f8-5f03-47f3-9e7b-1c967c11d7b9");
			RealUId = new Guid("24d201f8-5f03-47f3-9e7b-1c967c11d7b9");
			Name = "AccountAnnualRevenue";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryOrderColumn() {
			base.InitializePrimaryOrderColumn();
			PrimaryOrderColumn = CreateFromBaseCurrencyColumn();
			if (Columns.FindByUId(PrimaryOrderColumn.UId) == null) {
				Columns.Add(PrimaryOrderColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("94a2ebc5-c110-4929-94b4-baaafee43d7d")) == null) {
				Columns.Add(CreateToBaseCurrencyColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateFromBaseCurrencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("633ed4cd-fe02-423a-a4d4-062cae2a2ec4"),
				Name = @"FromBaseCurrency",
				CreatedInSchemaUId = new Guid("24d201f8-5f03-47f3-9e7b-1c967c11d7b9"),
				ModifiedInSchemaUId = new Guid("24d201f8-5f03-47f3-9e7b-1c967c11d7b9"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateToBaseCurrencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("94a2ebc5-c110-4929-94b4-baaafee43d7d"),
				Name = @"ToBaseCurrency",
				CreatedInSchemaUId = new Guid("24d201f8-5f03-47f3-9e7b-1c967c11d7b9"),
				ModifiedInSchemaUId = new Guid("24d201f8-5f03-47f3-9e7b-1c967c11d7b9"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAccountAnnualRevenueEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateAccountAnnualRevenueEventsProcessSchema() {
			var schema = new AccountAnnualRevenueEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AccountAnnualRevenue(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountAnnualRevenue_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountAnnualRevenueSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountAnnualRevenueSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("24d201f8-5f03-47f3-9e7b-1c967c11d7b9"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountAnnualRevenue

	/// <summary>
	/// Annual revenue of account.
	/// </summary>
	public class AccountAnnualRevenue : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public AccountAnnualRevenue(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountAnnualRevenue";
		}

		public AccountAnnualRevenue(AccountAnnualRevenue source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// From, base currency.
		/// </summary>
		public int FromBaseCurrency {
			get {
				return GetTypedColumnValue<int>("FromBaseCurrency");
			}
			set {
				SetColumnValue("FromBaseCurrency", value);
			}
		}

		/// <summary>
		/// To, base currency.
		/// </summary>
		public int ToBaseCurrency {
			get {
				return GetTypedColumnValue<int>("ToBaseCurrency");
			}
			set {
				SetColumnValue("ToBaseCurrency", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountAnnualRevenue_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AccountAnnualRevenueDeleted", e);
			Deleting += (s, e) => ThrowEvent("AccountAnnualRevenueDeleting", e);
			Inserted += (s, e) => ThrowEvent("AccountAnnualRevenueInserted", e);
			Inserting += (s, e) => ThrowEvent("AccountAnnualRevenueInserting", e);
			Saved += (s, e) => ThrowEvent("AccountAnnualRevenueSaved", e);
			Saving += (s, e) => ThrowEvent("AccountAnnualRevenueSaving", e);
			Validating += (s, e) => ThrowEvent("AccountAnnualRevenueValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountAnnualRevenue(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountAnnualRevenue_BaseEventsProcess

	/// <exclude/>
	public partial class AccountAnnualRevenue_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : AccountAnnualRevenue
	{

		public AccountAnnualRevenue_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountAnnualRevenue_BaseEventsProcess";
			SchemaUId = new Guid("24d201f8-5f03-47f3-9e7b-1c967c11d7b9");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("24d201f8-5f03-47f3-9e7b-1c967c11d7b9");
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

	#region Class: AccountAnnualRevenue_BaseEventsProcess

	/// <exclude/>
	public class AccountAnnualRevenue_BaseEventsProcess : AccountAnnualRevenue_BaseEventsProcess<AccountAnnualRevenue>
	{

		public AccountAnnualRevenue_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountAnnualRevenue_BaseEventsProcess

	public partial class AccountAnnualRevenue_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: AccountAnnualRevenueEventsProcessSchema

	/// <exclude/>
	public class AccountAnnualRevenueEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public AccountAnnualRevenueEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AccountAnnualRevenueEventsProcessSchema(AccountAnnualRevenueEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AccountAnnualRevenue_BaseEventsProcess";
			UId = new Guid("d08b8b70-ebc0-4a3e-ad25-62a1928fb747");
			CreatedInPackageId = new Guid("f95dbb7b-b17b-4e97-8e18-2aac94c049cf");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = Guid.Empty;
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
			return new AccountAnnualRevenueEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d08b8b70-ebc0-4a3e-ad25-62a1928fb747"));
		}

		#endregion

	}

	#endregion


	#region Class: AccountAnnualRevenueEventsProcess

	/// <exclude/>
	public class AccountAnnualRevenueEventsProcess : AccountAnnualRevenue_BaseEventsProcess
	{

		public AccountAnnualRevenueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

