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

	#region Class: VwRelationshipSchema

	/// <exclude/>
	public class VwRelationshipSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VwRelationshipSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwRelationshipSchema(VwRelationshipSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwRelationshipSchema(VwRelationshipSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2");
			RealUId = new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2");
			Name = "VwRelationship";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("772cc7bf-33cf-47fc-8974-8fb30f347cb1")) == null) {
				Columns.Add(CreateOurColumn());
			}
			if (Columns.FindByUId(new Guid("96fb2789-0c6f-4224-a8b1-adaf3f1333ff")) == null) {
				Columns.Add(CreateRelatedColumn());
			}
			if (Columns.FindByUId(new Guid("64c36ec4-8aa4-4956-8ec1-84f77109cbd1")) == null) {
				Columns.Add(CreateOutputRelationTypeColumn());
			}
			if (Columns.FindByUId(new Guid("c1906647-8f51-421c-bd72-15274c685c4e")) == null) {
				Columns.Add(CreateOutputReverseRelationTypeColumn());
			}
			if (Columns.FindByUId(new Guid("40c11f7d-777d-4824-8c81-478edba4adc7")) == null) {
				Columns.Add(CreateContactAColumn());
			}
			if (Columns.FindByUId(new Guid("0f033282-0eb8-4d85-aea1-e5e90e776364")) == null) {
				Columns.Add(CreateAccountAColumn());
			}
			if (Columns.FindByUId(new Guid("e2ccc5c6-cb0e-41c4-86f6-c295a6ee9fe5")) == null) {
				Columns.Add(CreateContactBColumn());
			}
			if (Columns.FindByUId(new Guid("957df48d-b997-445e-90b3-90201edeaf28")) == null) {
				Columns.Add(CreateAccountBColumn());
			}
			if (Columns.FindByUId(new Guid("0c47c5a9-172d-4306-9f3d-463cb56b6e1c")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("af999a48-8fff-44e0-aca1-5314a2f2cf52")) == null) {
				Columns.Add(CreateActiveColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateOurColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("772cc7bf-33cf-47fc-8974-8fb30f347cb1"),
				Name = @"Our",
				CreatedInSchemaUId = new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2"),
				ModifiedInSchemaUId = new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateRelatedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("96fb2789-0c6f-4224-a8b1-adaf3f1333ff"),
				Name = @"Related",
				CreatedInSchemaUId = new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2"),
				ModifiedInSchemaUId = new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateOutputRelationTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("64c36ec4-8aa4-4956-8ec1-84f77109cbd1"),
				Name = @"OutputRelationType",
				CreatedInSchemaUId = new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2"),
				ModifiedInSchemaUId = new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateOutputReverseRelationTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("c1906647-8f51-421c-bd72-15274c685c4e"),
				Name = @"OutputReverseRelationType",
				CreatedInSchemaUId = new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2"),
				ModifiedInSchemaUId = new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateContactAColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("40c11f7d-777d-4824-8c81-478edba4adc7"),
				Name = @"ContactA",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2"),
				ModifiedInSchemaUId = new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountAColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0f033282-0eb8-4d85-aea1-e5e90e776364"),
				Name = @"AccountA",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2"),
				ModifiedInSchemaUId = new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateContactBColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e2ccc5c6-cb0e-41c4-86f6-c295a6ee9fe5"),
				Name = @"ContactB",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2"),
				ModifiedInSchemaUId = new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountBColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("957df48d-b997-445e-90b3-90201edeaf28"),
				Name = @"AccountB",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2"),
				ModifiedInSchemaUId = new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("0c47c5a9-172d-4306-9f3d-463cb56b6e1c"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2"),
				ModifiedInSchemaUId = new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2"),
				CreatedInPackageId = new Guid("5e998412-5e01-46d8-be42-5973a05fadaa")
			};
		}

		protected virtual EntitySchemaColumn CreateActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("af999a48-8fff-44e0-aca1-5314a2f2cf52"),
				Name = @"Active",
				CreatedInSchemaUId = new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2"),
				ModifiedInSchemaUId = new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2"),
				CreatedInPackageId = new Guid("5e998412-5e01-46d8-be42-5973a05fadaa")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwRelationshipEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwRelationshipEventsProcessSchema() {
			var schema = new VwRelationshipEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwRelationship(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwRelationship_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwRelationshipSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwRelationshipSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2"));
		}

		#endregion

	}

	#endregion

	#region Class: VwRelationship

	/// <summary>
	/// Relationship (view).
	/// </summary>
	public class VwRelationship : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VwRelationship(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwRelationship";
		}

		public VwRelationship(VwRelationship source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Our.
		/// </summary>
		public string Our {
			get {
				return GetTypedColumnValue<string>("Our");
			}
			set {
				SetColumnValue("Our", value);
			}
		}

		/// <summary>
		/// Connected.
		/// </summary>
		public string Related {
			get {
				return GetTypedColumnValue<string>("Related");
			}
			set {
				SetColumnValue("Related", value);
			}
		}

		/// <summary>
		/// Relationship type.
		/// </summary>
		public string OutputRelationType {
			get {
				return GetTypedColumnValue<string>("OutputRelationType");
			}
			set {
				SetColumnValue("OutputRelationType", value);
			}
		}

		/// <summary>
		/// Inverse relationship type.
		/// </summary>
		public string OutputReverseRelationType {
			get {
				return GetTypedColumnValue<string>("OutputReverseRelationType");
			}
			set {
				SetColumnValue("OutputReverseRelationType", value);
			}
		}

		/// <exclude/>
		public Guid ContactAId {
			get {
				return GetTypedColumnValue<Guid>("ContactAId");
			}
			set {
				SetColumnValue("ContactAId", value);
				_contactA = null;
			}
		}

		/// <exclude/>
		public string ContactAName {
			get {
				return GetTypedColumnValue<string>("ContactAName");
			}
			set {
				SetColumnValue("ContactAName", value);
				if (_contactA != null) {
					_contactA.Name = value;
				}
			}
		}

		private Contact _contactA;
		/// <summary>
		/// Contact A.
		/// </summary>
		public Contact ContactA {
			get {
				return _contactA ??
					(_contactA = LookupColumnEntities.GetEntity("ContactA") as Contact);
			}
		}

		/// <exclude/>
		public Guid AccountAId {
			get {
				return GetTypedColumnValue<Guid>("AccountAId");
			}
			set {
				SetColumnValue("AccountAId", value);
				_accountA = null;
			}
		}

		/// <exclude/>
		public string AccountAName {
			get {
				return GetTypedColumnValue<string>("AccountAName");
			}
			set {
				SetColumnValue("AccountAName", value);
				if (_accountA != null) {
					_accountA.Name = value;
				}
			}
		}

		private Account _accountA;
		/// <summary>
		/// Account A.
		/// </summary>
		public Account AccountA {
			get {
				return _accountA ??
					(_accountA = LookupColumnEntities.GetEntity("AccountA") as Account);
			}
		}

		/// <exclude/>
		public Guid ContactBId {
			get {
				return GetTypedColumnValue<Guid>("ContactBId");
			}
			set {
				SetColumnValue("ContactBId", value);
				_contactB = null;
			}
		}

		/// <exclude/>
		public string ContactBName {
			get {
				return GetTypedColumnValue<string>("ContactBName");
			}
			set {
				SetColumnValue("ContactBName", value);
				if (_contactB != null) {
					_contactB.Name = value;
				}
			}
		}

		private Contact _contactB;
		/// <summary>
		/// Contact B.
		/// </summary>
		public Contact ContactB {
			get {
				return _contactB ??
					(_contactB = LookupColumnEntities.GetEntity("ContactB") as Contact);
			}
		}

		/// <exclude/>
		public Guid AccountBId {
			get {
				return GetTypedColumnValue<Guid>("AccountBId");
			}
			set {
				SetColumnValue("AccountBId", value);
				_accountB = null;
			}
		}

		/// <exclude/>
		public string AccountBName {
			get {
				return GetTypedColumnValue<string>("AccountBName");
			}
			set {
				SetColumnValue("AccountBName", value);
				if (_accountB != null) {
					_accountB.Name = value;
				}
			}
		}

		private Account _accountB;
		/// <summary>
		/// Account B.
		/// </summary>
		public Account AccountB {
			get {
				return _accountB ??
					(_accountB = LookupColumnEntities.GetEntity("AccountB") as Account);
			}
		}

		/// <summary>
		/// Description.
		/// </summary>
		public string Description {
			get {
				return GetTypedColumnValue<string>("Description");
			}
			set {
				SetColumnValue("Description", value);
			}
		}

		/// <summary>
		/// Actual.
		/// </summary>
		public bool Active {
			get {
				return GetTypedColumnValue<bool>("Active");
			}
			set {
				SetColumnValue("Active", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwRelationship_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwRelationshipDeleted", e);
			Inserting += (s, e) => ThrowEvent("VwRelationshipInserting", e);
			Validating += (s, e) => ThrowEvent("VwRelationshipValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwRelationship(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwRelationship_BaseEventsProcess

	/// <exclude/>
	public partial class VwRelationship_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : VwRelationship
	{

		public VwRelationship_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwRelationship_BaseEventsProcess";
			SchemaUId = new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2");
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

	#region Class: VwRelationship_BaseEventsProcess

	/// <exclude/>
	public class VwRelationship_BaseEventsProcess : VwRelationship_BaseEventsProcess<VwRelationship>
	{

		public VwRelationship_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwRelationship_BaseEventsProcess

	public partial class VwRelationship_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwRelationshipEventsProcessSchema

	/// <exclude/>
	public class VwRelationshipEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public VwRelationshipEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwRelationshipEventsProcessSchema(VwRelationshipEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwRelationship_BaseEventsProcess";
			UId = new Guid("54033437-6604-4378-8bba-2375c25b76b5");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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
			return new VwRelationshipEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("54033437-6604-4378-8bba-2375c25b76b5"));
		}

		#endregion

	}

	#endregion


	#region Class: VwRelationshipEventsProcess

	/// <exclude/>
	public class VwRelationshipEventsProcess : VwRelationship_BaseEventsProcess
	{

		public VwRelationshipEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

