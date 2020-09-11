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

	#region Class: VwContactModuleHistorySchema

	/// <exclude/>
	public class VwContactModuleHistorySchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VwContactModuleHistorySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwContactModuleHistorySchema(VwContactModuleHistorySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwContactModuleHistorySchema(VwContactModuleHistorySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b2df669b-ebc2-4e72-913c-bf68895c27a1");
			RealUId = new Guid("b2df669b-ebc2-4e72-913c-bf68895c27a1");
			Name = "VwContactModuleHistory";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("62195e1c-47bf-4dbd-b7fc-67d37beb217a");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("59152be0-65ec-4e43-b6a5-97a915c11273")) == null) {
				Columns.Add(CreateTitleColumn());
			}
			if (Columns.FindByUId(new Guid("7dc47acd-cfe7-401a-a13e-2a89842b965b")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("4aa9817a-2188-40db-aa80-e6b8fa6b7681")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("4e6bcc15-1230-4f21-9b99-a0374d32324e")) == null) {
				Columns.Add(CreateSysEntityColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("b2df669b-ebc2-4e72-913c-bf68895c27a1");
			column.CreatedInPackageId = new Guid("62195e1c-47bf-4dbd-b7fc-67d37beb217a");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("b2df669b-ebc2-4e72-913c-bf68895c27a1");
			column.CreatedInPackageId = new Guid("62195e1c-47bf-4dbd-b7fc-67d37beb217a");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("b2df669b-ebc2-4e72-913c-bf68895c27a1");
			column.CreatedInPackageId = new Guid("62195e1c-47bf-4dbd-b7fc-67d37beb217a");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("b2df669b-ebc2-4e72-913c-bf68895c27a1");
			column.CreatedInPackageId = new Guid("62195e1c-47bf-4dbd-b7fc-67d37beb217a");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("b2df669b-ebc2-4e72-913c-bf68895c27a1");
			column.CreatedInPackageId = new Guid("62195e1c-47bf-4dbd-b7fc-67d37beb217a");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("b2df669b-ebc2-4e72-913c-bf68895c27a1");
			column.CreatedInPackageId = new Guid("62195e1c-47bf-4dbd-b7fc-67d37beb217a");
			return column;
		}

		protected virtual EntitySchemaColumn CreateTitleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("59152be0-65ec-4e43-b6a5-97a915c11273"),
				Name = @"Title",
				CreatedInSchemaUId = new Guid("b2df669b-ebc2-4e72-913c-bf68895c27a1"),
				ModifiedInSchemaUId = new Guid("b2df669b-ebc2-4e72-913c-bf68895c27a1"),
				CreatedInPackageId = new Guid("62195e1c-47bf-4dbd-b7fc-67d37beb217a")
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("7dc47acd-cfe7-401a-a13e-2a89842b965b"),
				Name = @"StartDate",
				CreatedInSchemaUId = new Guid("b2df669b-ebc2-4e72-913c-bf68895c27a1"),
				ModifiedInSchemaUId = new Guid("b2df669b-ebc2-4e72-913c-bf68895c27a1"),
				CreatedInPackageId = new Guid("62195e1c-47bf-4dbd-b7fc-67d37beb217a")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4aa9817a-2188-40db-aa80-e6b8fa6b7681"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInSchemaUId = new Guid("b2df669b-ebc2-4e72-913c-bf68895c27a1"),
				ModifiedInSchemaUId = new Guid("b2df669b-ebc2-4e72-913c-bf68895c27a1"),
				CreatedInPackageId = new Guid("62195e1c-47bf-4dbd-b7fc-67d37beb217a")
			};
		}

		protected virtual EntitySchemaColumn CreateSysEntityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4e6bcc15-1230-4f21-9b99-a0374d32324e"),
				Name = @"SysEntity",
				ReferenceSchemaUId = new Guid("a2d407a1-cda4-4344-ac71-88a4e2bf9c28"),
				CreatedInSchemaUId = new Guid("b2df669b-ebc2-4e72-913c-bf68895c27a1"),
				ModifiedInSchemaUId = new Guid("b2df669b-ebc2-4e72-913c-bf68895c27a1"),
				CreatedInPackageId = new Guid("62195e1c-47bf-4dbd-b7fc-67d37beb217a")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwContactModuleHistoryEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwContactModuleHistoryEventsProcessSchema() {
			var schema = new VwContactModuleHistoryEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwContactModuleHistory(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwContactModuleHistory_UIv2EventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwContactModuleHistorySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwContactModuleHistorySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b2df669b-ebc2-4e72-913c-bf68895c27a1"));
		}

		#endregion

	}

	#endregion

	#region Class: VwContactModuleHistory

	/// <summary>
	/// Contacts section history (view).
	/// </summary>
	public class VwContactModuleHistory : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VwContactModuleHistory(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwContactModuleHistory";
		}

		public VwContactModuleHistory(VwContactModuleHistory source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Title.
		/// </summary>
		public string Title {
			get {
				return GetTypedColumnValue<string>("Title");
			}
			set {
				SetColumnValue("Title", value);
			}
		}

		/// <summary>
		/// Date.
		/// </summary>
		public DateTime StartDate {
			get {
				return GetTypedColumnValue<DateTime>("StartDate");
			}
			set {
				SetColumnValue("StartDate", value);
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
		public Guid SysEntityId {
			get {
				return GetTypedColumnValue<Guid>("SysEntityId");
			}
			set {
				SetColumnValue("SysEntityId", value);
				_sysEntity = null;
			}
		}

		/// <exclude/>
		public string SysEntityName {
			get {
				return GetTypedColumnValue<string>("SysEntityName");
			}
			set {
				SetColumnValue("SysEntityName", value);
				if (_sysEntity != null) {
					_sysEntity.Name = value;
				}
			}
		}

		private VwSysModuleEntity _sysEntity;
		/// <summary>
		/// Object.
		/// </summary>
		public VwSysModuleEntity SysEntity {
			get {
				return _sysEntity ??
					(_sysEntity = LookupColumnEntities.GetEntity("SysEntity") as VwSysModuleEntity);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwContactModuleHistory_UIv2EventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwContactModuleHistoryDeleted", e);
			Inserting += (s, e) => ThrowEvent("VwContactModuleHistoryInserting", e);
			Validating += (s, e) => ThrowEvent("VwContactModuleHistoryValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwContactModuleHistory(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwContactModuleHistory_UIv2EventsProcess

	/// <exclude/>
	public partial class VwContactModuleHistory_UIv2EventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : VwContactModuleHistory
	{

		public VwContactModuleHistory_UIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwContactModuleHistory_UIv2EventsProcess";
			SchemaUId = new Guid("b2df669b-ebc2-4e72-913c-bf68895c27a1");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b2df669b-ebc2-4e72-913c-bf68895c27a1");
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

	#region Class: VwContactModuleHistory_UIv2EventsProcess

	/// <exclude/>
	public class VwContactModuleHistory_UIv2EventsProcess : VwContactModuleHistory_UIv2EventsProcess<VwContactModuleHistory>
	{

		public VwContactModuleHistory_UIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwContactModuleHistory_UIv2EventsProcess

	public partial class VwContactModuleHistory_UIv2EventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwContactModuleHistoryEventsProcessSchema

	/// <exclude/>
	public class VwContactModuleHistoryEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public VwContactModuleHistoryEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwContactModuleHistoryEventsProcessSchema(VwContactModuleHistoryEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwContactModuleHistory_UIv2EventsProcess";
			UId = new Guid("488a1187-9255-45ce-866f-47e4b0b453ed");
			CreatedInPackageId = new Guid("62195e1c-47bf-4dbd-b7fc-67d37beb217a");
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
				CreatedInPackageId = new Guid("62195e1c-47bf-4dbd-b7fc-67d37beb217a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("62195e1c-47bf-4dbd-b7fc-67d37beb217a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("62195e1c-47bf-4dbd-b7fc-67d37beb217a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("62195e1c-47bf-4dbd-b7fc-67d37beb217a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("62195e1c-47bf-4dbd-b7fc-67d37beb217a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("62195e1c-47bf-4dbd-b7fc-67d37beb217a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("62195e1c-47bf-4dbd-b7fc-67d37beb217a")
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
			return new VwContactModuleHistoryEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("488a1187-9255-45ce-866f-47e4b0b453ed"));
		}

		#endregion

	}

	#endregion


	#region Class: VwContactModuleHistoryEventsProcess

	/// <exclude/>
	public class VwContactModuleHistoryEventsProcess : VwContactModuleHistory_UIv2EventsProcess
	{

		public VwContactModuleHistoryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

