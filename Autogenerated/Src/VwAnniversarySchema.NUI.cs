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

	#region Class: VwAnniversarySchema

	/// <exclude/>
	public class VwAnniversarySchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VwAnniversarySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwAnniversarySchema(VwAnniversarySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwAnniversarySchema(VwAnniversarySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("303f5779-e867-4e1c-8fdc-e4768f15b4eb");
			RealUId = new Guid("303f5779-e867-4e1c-8fdc-e4768f15b4eb");
			Name = "VwAnniversary";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("4e1dac3c-e1c7-48d2-aca5-8d464830f2e4")) == null) {
				Columns.Add(CreateDateColumn());
			}
			if (Columns.FindByUId(new Guid("23ff3869-b4ee-465b-b5e1-c59d867c1838")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("e714bd7b-415c-4d06-8a9b-eaec0c08d07f")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("988f58e6-3577-416a-b979-37cbb5c05965")) == null) {
				Columns.Add(CreateAnniversaryTypeColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("303f5779-e867-4e1c-8fdc-e4768f15b4eb");
			column.CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("303f5779-e867-4e1c-8fdc-e4768f15b4eb");
			column.CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("303f5779-e867-4e1c-8fdc-e4768f15b4eb");
			column.CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("303f5779-e867-4e1c-8fdc-e4768f15b4eb");
			column.CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("303f5779-e867-4e1c-8fdc-e4768f15b4eb");
			column.CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("303f5779-e867-4e1c-8fdc-e4768f15b4eb");
			column.CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd");
			return column;
		}

		protected virtual EntitySchemaColumn CreateDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("4e1dac3c-e1c7-48d2-aca5-8d464830f2e4"),
				Name = @"Date",
				CreatedInSchemaUId = new Guid("303f5779-e867-4e1c-8fdc-e4768f15b4eb"),
				ModifiedInSchemaUId = new Guid("303f5779-e867-4e1c-8fdc-e4768f15b4eb"),
				CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("23ff3869-b4ee-465b-b5e1-c59d867c1838"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("303f5779-e867-4e1c-8fdc-e4768f15b4eb"),
				ModifiedInSchemaUId = new Guid("303f5779-e867-4e1c-8fdc-e4768f15b4eb"),
				CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e714bd7b-415c-4d06-8a9b-eaec0c08d07f"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("303f5779-e867-4e1c-8fdc-e4768f15b4eb"),
				ModifiedInSchemaUId = new Guid("303f5779-e867-4e1c-8fdc-e4768f15b4eb"),
				CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd")
			};
		}

		protected virtual EntitySchemaColumn CreateAnniversaryTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("988f58e6-3577-416a-b979-37cbb5c05965"),
				Name = @"AnniversaryType",
				ReferenceSchemaUId = new Guid("b8215eaa-bf43-4a00-8bca-8eea8a5a0c14"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("303f5779-e867-4e1c-8fdc-e4768f15b4eb"),
				ModifiedInSchemaUId = new Guid("303f5779-e867-4e1c-8fdc-e4768f15b4eb"),
				CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwAnniversaryEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwAnniversaryEventsProcessSchema() {
			var schema = new VwAnniversaryEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwAnniversary(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwAnniversary_NUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwAnniversarySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwAnniversarySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("303f5779-e867-4e1c-8fdc-e4768f15b4eb"));
		}

		#endregion

	}

	#endregion

	#region Class: VwAnniversary

	/// <summary>
	/// Noteworthy event.
	/// </summary>
	public class VwAnniversary : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VwAnniversary(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwAnniversary";
		}

		public VwAnniversary(VwAnniversary source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Date.
		/// </summary>
		public DateTime Date {
			get {
				return GetTypedColumnValue<DateTime>("Date");
			}
			set {
				SetColumnValue("Date", value);
			}
		}

		/// <exclude/>
		public Guid AccountId {
			get {
				return GetTypedColumnValue<Guid>("AccountId");
			}
			set {
				SetColumnValue("AccountId", value);
				_account = null;
			}
		}

		/// <exclude/>
		public string AccountName {
			get {
				return GetTypedColumnValue<string>("AccountName");
			}
			set {
				SetColumnValue("AccountName", value);
				if (_account != null) {
					_account.Name = value;
				}
			}
		}

		private Account _account;
		/// <summary>
		/// Account.
		/// </summary>
		public Account Account {
			get {
				return _account ??
					(_account = LookupColumnEntities.GetEntity("Account") as Account);
			}
		}

		/// <exclude/>
		public Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public string ContactName {
			get {
				return GetTypedColumnValue<string>("ContactName");
			}
			set {
				SetColumnValue("ContactName", value);
				if (_contact != null) {
					_contact.Name = value;
				}
			}
		}

		private Contact _contact;
		/// <summary>
		/// Contact.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
			}
		}

		/// <exclude/>
		public Guid AnniversaryTypeId {
			get {
				return GetTypedColumnValue<Guid>("AnniversaryTypeId");
			}
			set {
				SetColumnValue("AnniversaryTypeId", value);
				_anniversaryType = null;
			}
		}

		/// <exclude/>
		public string AnniversaryTypeName {
			get {
				return GetTypedColumnValue<string>("AnniversaryTypeName");
			}
			set {
				SetColumnValue("AnniversaryTypeName", value);
				if (_anniversaryType != null) {
					_anniversaryType.Name = value;
				}
			}
		}

		private AnniversaryType _anniversaryType;
		/// <summary>
		/// Noteworthy event type.
		/// </summary>
		public AnniversaryType AnniversaryType {
			get {
				return _anniversaryType ??
					(_anniversaryType = LookupColumnEntities.GetEntity("AnniversaryType") as AnniversaryType);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwAnniversary_NUIEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwAnniversaryDeleted", e);
			Inserting += (s, e) => ThrowEvent("VwAnniversaryInserting", e);
			Validating += (s, e) => ThrowEvent("VwAnniversaryValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwAnniversary(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwAnniversary_NUIEventsProcess

	/// <exclude/>
	public partial class VwAnniversary_NUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : VwAnniversary
	{

		public VwAnniversary_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwAnniversary_NUIEventsProcess";
			SchemaUId = new Guid("303f5779-e867-4e1c-8fdc-e4768f15b4eb");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("303f5779-e867-4e1c-8fdc-e4768f15b4eb");
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

	#region Class: VwAnniversary_NUIEventsProcess

	/// <exclude/>
	public class VwAnniversary_NUIEventsProcess : VwAnniversary_NUIEventsProcess<VwAnniversary>
	{

		public VwAnniversary_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwAnniversary_NUIEventsProcess

	public partial class VwAnniversary_NUIEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwAnniversaryEventsProcessSchema

	/// <exclude/>
	public class VwAnniversaryEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public VwAnniversaryEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwAnniversaryEventsProcessSchema(VwAnniversaryEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwAnniversary_NUIEventsProcess";
			UId = new Guid("1d3a7377-4547-4de4-91c5-e51161013fdc");
			CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd");
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
				CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("b85710ff-ea7b-435e-8c26-df40c9e1a6fd")
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
			return new VwAnniversaryEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d3a7377-4547-4de4-91c5-e51161013fdc"));
		}

		#endregion

	}

	#endregion


	#region Class: VwAnniversaryEventsProcess

	/// <exclude/>
	public class VwAnniversaryEventsProcess : VwAnniversary_NUIEventsProcess
	{

		public VwAnniversaryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

