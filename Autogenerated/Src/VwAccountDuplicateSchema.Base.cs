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

	#region Class: VwAccountDuplicateSchema

	/// <exclude/>
	public class VwAccountDuplicateSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VwAccountDuplicateSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwAccountDuplicateSchema(VwAccountDuplicateSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwAccountDuplicateSchema(VwAccountDuplicateSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("80cf3d69-0e4b-47fc-a0d6-e62acc462de6");
			RealUId = new Guid("80cf3d69-0e4b-47fc-a0d6-e62acc462de6");
			Name = "VwAccountDuplicate";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("0bda0655-2587-4fed-aa62-d1e0e5df7e3b")) == null) {
				Columns.Add(CreateEntity1Column());
			}
			if (Columns.FindByUId(new Guid("541dcd93-7a3a-47a5-b0c5-954d02a6d4c4")) == null) {
				Columns.Add(CreateEntity2Column());
			}
			if (Columns.FindByUId(new Guid("be543c08-ffc7-4159-9002-abbf854fc007")) == null) {
				Columns.Add(CreateStatusOfDuplicateColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateEntity1Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0bda0655-2587-4fed-aa62-d1e0e5df7e3b"),
				Name = @"Entity1",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInSchemaUId = new Guid("80cf3d69-0e4b-47fc-a0d6-e62acc462de6"),
				ModifiedInSchemaUId = new Guid("80cf3d69-0e4b-47fc-a0d6-e62acc462de6"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateEntity2Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("541dcd93-7a3a-47a5-b0c5-954d02a6d4c4"),
				Name = @"Entity2",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInSchemaUId = new Guid("80cf3d69-0e4b-47fc-a0d6-e62acc462de6"),
				ModifiedInSchemaUId = new Guid("80cf3d69-0e4b-47fc-a0d6-e62acc462de6"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateStatusOfDuplicateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("be543c08-ffc7-4159-9002-abbf854fc007"),
				Name = @"StatusOfDuplicate",
				ReferenceSchemaUId = new Guid("590f25a6-b7bf-4ca0-816a-415e3518a148"),
				CreatedInSchemaUId = new Guid("80cf3d69-0e4b-47fc-a0d6-e62acc462de6"),
				ModifiedInSchemaUId = new Guid("80cf3d69-0e4b-47fc-a0d6-e62acc462de6"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwAccountDuplicateEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwAccountDuplicateEventsProcessSchema() {
			var schema = new VwAccountDuplicateEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwAccountDuplicate(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwAccountDuplicate_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwAccountDuplicateSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwAccountDuplicateSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("80cf3d69-0e4b-47fc-a0d6-e62acc462de6"));
		}

		#endregion

	}

	#endregion

	#region Class: VwAccountDuplicate

	/// <summary>
	/// Account duplicate (view).
	/// </summary>
	public class VwAccountDuplicate : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VwAccountDuplicate(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwAccountDuplicate";
		}

		public VwAccountDuplicate(VwAccountDuplicate source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid Entity1Id {
			get {
				return GetTypedColumnValue<Guid>("Entity1Id");
			}
			set {
				SetColumnValue("Entity1Id", value);
				_entity1 = null;
			}
		}

		/// <exclude/>
		public string Entity1Name {
			get {
				return GetTypedColumnValue<string>("Entity1Name");
			}
			set {
				SetColumnValue("Entity1Name", value);
				if (_entity1 != null) {
					_entity1.Name = value;
				}
			}
		}

		private Account _entity1;
		/// <summary>
		/// Record 1.
		/// </summary>
		public Account Entity1 {
			get {
				return _entity1 ??
					(_entity1 = LookupColumnEntities.GetEntity("Entity1") as Account);
			}
		}

		/// <exclude/>
		public Guid Entity2Id {
			get {
				return GetTypedColumnValue<Guid>("Entity2Id");
			}
			set {
				SetColumnValue("Entity2Id", value);
				_entity2 = null;
			}
		}

		/// <exclude/>
		public string Entity2Name {
			get {
				return GetTypedColumnValue<string>("Entity2Name");
			}
			set {
				SetColumnValue("Entity2Name", value);
				if (_entity2 != null) {
					_entity2.Name = value;
				}
			}
		}

		private Account _entity2;
		/// <summary>
		/// Record 2.
		/// </summary>
		public Account Entity2 {
			get {
				return _entity2 ??
					(_entity2 = LookupColumnEntities.GetEntity("Entity2") as Account);
			}
		}

		/// <exclude/>
		public Guid StatusOfDuplicateId {
			get {
				return GetTypedColumnValue<Guid>("StatusOfDuplicateId");
			}
			set {
				SetColumnValue("StatusOfDuplicateId", value);
				_statusOfDuplicate = null;
			}
		}

		/// <exclude/>
		public string StatusOfDuplicateName {
			get {
				return GetTypedColumnValue<string>("StatusOfDuplicateName");
			}
			set {
				SetColumnValue("StatusOfDuplicateName", value);
				if (_statusOfDuplicate != null) {
					_statusOfDuplicate.Name = value;
				}
			}
		}

		private DuplicateStatus _statusOfDuplicate;
		/// <summary>
		/// Record status.
		/// </summary>
		public DuplicateStatus StatusOfDuplicate {
			get {
				return _statusOfDuplicate ??
					(_statusOfDuplicate = LookupColumnEntities.GetEntity("StatusOfDuplicate") as DuplicateStatus);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwAccountDuplicate_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwAccountDuplicateDeleted", e);
			Deleting += (s, e) => ThrowEvent("VwAccountDuplicateDeleting", e);
			Inserted += (s, e) => ThrowEvent("VwAccountDuplicateInserted", e);
			Inserting += (s, e) => ThrowEvent("VwAccountDuplicateInserting", e);
			Saved += (s, e) => ThrowEvent("VwAccountDuplicateSaved", e);
			Saving += (s, e) => ThrowEvent("VwAccountDuplicateSaving", e);
			Validating += (s, e) => ThrowEvent("VwAccountDuplicateValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwAccountDuplicate(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwAccountDuplicate_BaseEventsProcess

	/// <exclude/>
	public partial class VwAccountDuplicate_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : VwAccountDuplicate
	{

		public VwAccountDuplicate_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwAccountDuplicate_BaseEventsProcess";
			SchemaUId = new Guid("80cf3d69-0e4b-47fc-a0d6-e62acc462de6");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("80cf3d69-0e4b-47fc-a0d6-e62acc462de6");
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

	#region Class: VwAccountDuplicate_BaseEventsProcess

	/// <exclude/>
	public class VwAccountDuplicate_BaseEventsProcess : VwAccountDuplicate_BaseEventsProcess<VwAccountDuplicate>
	{

		public VwAccountDuplicate_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwAccountDuplicate_BaseEventsProcess

	public partial class VwAccountDuplicate_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwAccountDuplicateEventsProcessSchema

	/// <exclude/>
	public class VwAccountDuplicateEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public VwAccountDuplicateEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwAccountDuplicateEventsProcessSchema(VwAccountDuplicateEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwAccountDuplicate_BaseEventsProcess";
			UId = new Guid("5342d059-5130-4b68-9004-5602c362eae1");
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
			return new VwAccountDuplicateEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5342d059-5130-4b68-9004-5602c362eae1"));
		}

		#endregion

	}

	#endregion


	#region Class: VwAccountDuplicateEventsProcess

	/// <exclude/>
	public class VwAccountDuplicateEventsProcess : VwAccountDuplicate_BaseEventsProcess
	{

		public VwAccountDuplicateEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

