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

	#region Class: BaseProductInterestSchema

	/// <exclude/>
	[IsVirtual]
	public class BaseProductInterestSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public BaseProductInterestSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BaseProductInterestSchema(BaseProductInterestSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BaseProductInterestSchema(BaseProductInterestSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3f1650f6-0086-4d7d-8a8e-003fa7bb64e7");
			RealUId = new Guid("3f1650f6-0086-4d7d-8a8e-003fa7bb64e7");
			Name = "BaseProductInterest";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("f7dba1f9-106d-4109-91ed-e5bf0425611d")) == null) {
				Columns.Add(CreateProductColumn());
			}
			if (Columns.FindByUId(new Guid("0d71fb26-6979-40fc-b54d-e7f465a2d767")) == null) {
				Columns.Add(CreateAmountColumn());
			}
			if (Columns.FindByUId(new Guid("81e1ebf2-5012-4841-9e49-452747fd7fda")) == null) {
				Columns.Add(CreateDateOfProposalColumn());
			}
			if (Columns.FindByUId(new Guid("703411de-845b-46d1-a4d7-13bcd105a3d1")) == null) {
				Columns.Add(CreateResultOfProposalColumn());
			}
			if (Columns.FindByUId(new Guid("0cc772ae-1d06-4c9c-97ca-e71b9cc140b7")) == null) {
				Columns.Add(CreateCommentsColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f7dba1f9-106d-4109-91ed-e5bf0425611d"),
				Name = @"Product",
				ReferenceSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3f1650f6-0086-4d7d-8a8e-003fa7bb64e7"),
				ModifiedInSchemaUId = new Guid("3f1650f6-0086-4d7d-8a8e-003fa7bb64e7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("0d71fb26-6979-40fc-b54d-e7f465a2d767"),
				Name = @"Amount",
				CreatedInSchemaUId = new Guid("3f1650f6-0086-4d7d-8a8e-003fa7bb64e7"),
				ModifiedInSchemaUId = new Guid("3f1650f6-0086-4d7d-8a8e-003fa7bb64e7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDateOfProposalColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("81e1ebf2-5012-4841-9e49-452747fd7fda"),
				Name = @"DateOfProposal",
				CreatedInSchemaUId = new Guid("3f1650f6-0086-4d7d-8a8e-003fa7bb64e7"),
				ModifiedInSchemaUId = new Guid("3f1650f6-0086-4d7d-8a8e-003fa7bb64e7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateResultOfProposalColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("703411de-845b-46d1-a4d7-13bcd105a3d1"),
				Name = @"ResultOfProposal",
				ReferenceSchemaUId = new Guid("801a201c-7040-4489-a705-5896b20d2f52"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3f1650f6-0086-4d7d-8a8e-003fa7bb64e7"),
				ModifiedInSchemaUId = new Guid("3f1650f6-0086-4d7d-8a8e-003fa7bb64e7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCommentsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("0cc772ae-1d06-4c9c-97ca-e71b9cc140b7"),
				Name = @"Comments",
				CreatedInSchemaUId = new Guid("3f1650f6-0086-4d7d-8a8e-003fa7bb64e7"),
				ModifiedInSchemaUId = new Guid("3f1650f6-0086-4d7d-8a8e-003fa7bb64e7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseProductInterestEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateBaseProductInterestEventsProcessSchema() {
			var schema = new BaseProductInterestEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BaseProductInterest(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BaseProductInterest_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BaseProductInterestSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BaseProductInterestSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3f1650f6-0086-4d7d-8a8e-003fa7bb64e7"));
		}

		#endregion

	}

	#endregion

	#region Class: BaseProductInterest

	/// <summary>
	/// Base interest to product.
	/// </summary>
	public class BaseProductInterest : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public BaseProductInterest(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BaseProductInterest";
		}

		public BaseProductInterest(BaseProductInterest source)
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

		private Product _product;
		/// <summary>
		/// Product.
		/// </summary>
		public Product Product {
			get {
				return _product ??
					(_product = LookupColumnEntities.GetEntity("Product") as Product);
			}
		}

		/// <summary>
		/// Quantity.
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
		/// Quoted on.
		/// </summary>
		public DateTime DateOfProposal {
			get {
				return GetTypedColumnValue<DateTime>("DateOfProposal");
			}
			set {
				SetColumnValue("DateOfProposal", value);
			}
		}

		/// <exclude/>
		public Guid ResultOfProposalId {
			get {
				return GetTypedColumnValue<Guid>("ResultOfProposalId");
			}
			set {
				SetColumnValue("ResultOfProposalId", value);
				_resultOfProposal = null;
			}
		}

		/// <exclude/>
		public string ResultOfProposalName {
			get {
				return GetTypedColumnValue<string>("ResultOfProposalName");
			}
			set {
				SetColumnValue("ResultOfProposalName", value);
				if (_resultOfProposal != null) {
					_resultOfProposal.Name = value;
				}
			}
		}

		private PropositionResult _resultOfProposal;
		/// <summary>
		/// Interest.
		/// </summary>
		public PropositionResult ResultOfProposal {
			get {
				return _resultOfProposal ??
					(_resultOfProposal = LookupColumnEntities.GetEntity("ResultOfProposal") as PropositionResult);
			}
		}

		/// <summary>
		/// Comments.
		/// </summary>
		public string Comments {
			get {
				return GetTypedColumnValue<string>("Comments");
			}
			set {
				SetColumnValue("Comments", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BaseProductInterest_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BaseProductInterestDeleted", e);
			Deleting += (s, e) => ThrowEvent("BaseProductInterestDeleting", e);
			Inserted += (s, e) => ThrowEvent("BaseProductInterestInserted", e);
			Inserting += (s, e) => ThrowEvent("BaseProductInterestInserting", e);
			Saved += (s, e) => ThrowEvent("BaseProductInterestSaved", e);
			Saving += (s, e) => ThrowEvent("BaseProductInterestSaving", e);
			Validating += (s, e) => ThrowEvent("BaseProductInterestValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseProductInterest(this);
		}

		#endregion

	}

	#endregion

	#region Class: BaseProductInterest_BaseEventsProcess

	/// <exclude/>
	public partial class BaseProductInterest_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : BaseProductInterest
	{

		public BaseProductInterest_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseProductInterest_BaseEventsProcess";
			SchemaUId = new Guid("3f1650f6-0086-4d7d-8a8e-003fa7bb64e7");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3f1650f6-0086-4d7d-8a8e-003fa7bb64e7");
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

	#region Class: BaseProductInterest_BaseEventsProcess

	/// <exclude/>
	public class BaseProductInterest_BaseEventsProcess : BaseProductInterest_BaseEventsProcess<BaseProductInterest>
	{

		public BaseProductInterest_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseProductInterest_BaseEventsProcess

	public partial class BaseProductInterest_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: BaseProductInterestEventsProcessSchema

	/// <exclude/>
	public class BaseProductInterestEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public BaseProductInterestEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseProductInterestEventsProcessSchema(BaseProductInterestEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseProductInterest_BaseEventsProcess";
			UId = new Guid("f2aa1d64-5b39-481e-8ce2-bbdf0dc5cba2");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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
			return new BaseProductInterestEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f2aa1d64-5b39-481e-8ce2-bbdf0dc5cba2"));
		}

		#endregion

	}

	#endregion


	#region Class: BaseProductInterestEventsProcess

	/// <exclude/>
	public class BaseProductInterestEventsProcess : BaseProductInterest_BaseEventsProcess
	{

		public BaseProductInterestEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

