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

	#region Class: EntitySynchronizerSchema

	/// <exclude/>
	public class EntitySynchronizerSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public EntitySynchronizerSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EntitySynchronizerSchema(EntitySynchronizerSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EntitySynchronizerSchema(EntitySynchronizerSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateRemoteKey_UniqueIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = true
			};
			index.UId = new Guid("c00c6925-bb27-4a0c-98bc-fae1917e28cd");
			index.Name = "RemoteKey_Unique";
			index.CreatedInSchemaUId = new Guid("062699d9-028d-4266-8f21-66b4c9394f54");
			index.ModifiedInSchemaUId = new Guid("062699d9-028d-4266-8f21-66b4c9394f54");
			index.CreatedInPackageId = new Guid("008b5e35-cd1d-462d-aec0-4fb9d28e872d");
			EntitySchemaIndexColumn remoteKeyIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("3295e00f-7a7b-4aa0-aba7-b8e24eb9587c"),
				ColumnUId = new Guid("75ec57bf-77be-4b9e-9c83-7e05c32c40ef"),
				CreatedInSchemaUId = new Guid("062699d9-028d-4266-8f21-66b4c9394f54"),
				ModifiedInSchemaUId = new Guid("062699d9-028d-4266-8f21-66b4c9394f54"),
				CreatedInPackageId = new Guid("008b5e35-cd1d-462d-aec0-4fb9d28e872d"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(remoteKeyIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateEntity_CreatedBy_System_UniqueIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = true
			};
			index.UId = new Guid("f6eefece-6677-4ce0-8d2f-0cc1a55fbb45");
			index.Name = "Entity_CreatedBy_System_Unique";
			index.CreatedInSchemaUId = new Guid("062699d9-028d-4266-8f21-66b4c9394f54");
			index.ModifiedInSchemaUId = new Guid("062699d9-028d-4266-8f21-66b4c9394f54");
			index.CreatedInPackageId = new Guid("008b5e35-cd1d-462d-aec0-4fb9d28e872d");
			EntitySchemaIndexColumn entityIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("dcaaed9c-c7ca-4711-8d4f-60c5ff69278f"),
				ColumnUId = new Guid("222df7a2-ccbd-4184-8ac2-89653ca4a2d7"),
				CreatedInSchemaUId = new Guid("062699d9-028d-4266-8f21-66b4c9394f54"),
				ModifiedInSchemaUId = new Guid("062699d9-028d-4266-8f21-66b4c9394f54"),
				CreatedInPackageId = new Guid("008b5e35-cd1d-462d-aec0-4fb9d28e872d"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(entityIdIndexColumn);
			EntitySchemaIndexColumn createdByIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("a5f5cc32-1f03-4679-a2ae-c570b7d08d99"),
				ColumnUId = new Guid("ebf6bb93-8aa6-4a01-900d-c6ea67affe21"),
				CreatedInSchemaUId = new Guid("062699d9-028d-4266-8f21-66b4c9394f54"),
				ModifiedInSchemaUId = new Guid("062699d9-028d-4266-8f21-66b4c9394f54"),
				CreatedInPackageId = new Guid("008b5e35-cd1d-462d-aec0-4fb9d28e872d"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(createdByIdIndexColumn);
			EntitySchemaIndexColumn integrationSystemIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("068b6a66-be5b-46de-805c-692e201d4046"),
				ColumnUId = new Guid("e97bcaf3-daf4-4132-ae8d-966512fd3090"),
				CreatedInSchemaUId = new Guid("062699d9-028d-4266-8f21-66b4c9394f54"),
				ModifiedInSchemaUId = new Guid("062699d9-028d-4266-8f21-66b4c9394f54"),
				CreatedInPackageId = new Guid("e0bd8020-de17-4815-83cd-c2dac7bbc324"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(integrationSystemIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("062699d9-028d-4266-8f21-66b4c9394f54");
			RealUId = new Guid("062699d9-028d-4266-8f21-66b4c9394f54");
			Name = "EntitySynchronizer";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("008b5e35-cd1d-462d-aec0-4fb9d28e872d");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("75ec57bf-77be-4b9e-9c83-7e05c32c40ef")) == null) {
				Columns.Add(CreateRemoteKeyColumn());
			}
			if (Columns.FindByUId(new Guid("222df7a2-ccbd-4184-8ac2-89653ca4a2d7")) == null) {
				Columns.Add(CreateEntityIdColumn());
			}
			if (Columns.FindByUId(new Guid("e97bcaf3-daf4-4132-ae8d-966512fd3090")) == null) {
				Columns.Add(CreateIntegrationSystemColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateRemoteKeyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("75ec57bf-77be-4b9e-9c83-7e05c32c40ef"),
				Name = @"RemoteKey",
				CreatedInSchemaUId = new Guid("062699d9-028d-4266-8f21-66b4c9394f54"),
				ModifiedInSchemaUId = new Guid("062699d9-028d-4266-8f21-66b4c9394f54"),
				CreatedInPackageId = new Guid("008b5e35-cd1d-462d-aec0-4fb9d28e872d")
			};
		}

		protected virtual EntitySchemaColumn CreateEntityIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("222df7a2-ccbd-4184-8ac2-89653ca4a2d7"),
				Name = @"EntityId",
				CreatedInSchemaUId = new Guid("062699d9-028d-4266-8f21-66b4c9394f54"),
				ModifiedInSchemaUId = new Guid("062699d9-028d-4266-8f21-66b4c9394f54"),
				CreatedInPackageId = new Guid("008b5e35-cd1d-462d-aec0-4fb9d28e872d")
			};
		}

		protected virtual EntitySchemaColumn CreateIntegrationSystemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("e97bcaf3-daf4-4132-ae8d-966512fd3090"),
				Name = @"IntegrationSystem",
				CreatedInSchemaUId = new Guid("062699d9-028d-4266-8f21-66b4c9394f54"),
				ModifiedInSchemaUId = new Guid("062699d9-028d-4266-8f21-66b4c9394f54"),
				CreatedInPackageId = new Guid("e0bd8020-de17-4815-83cd-c2dac7bbc324")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateRemoteKey_UniqueIndex());
			Indexes.Add(CreateEntity_CreatedBy_System_UniqueIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateEntitySynchronizerEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateEntitySynchronizerEventsProcessSchema() {
			var schema = new EntitySynchronizerEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new EntitySynchronizer(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EntitySynchronizer_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EntitySynchronizerSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EntitySynchronizerSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("062699d9-028d-4266-8f21-66b4c9394f54"));
		}

		#endregion

	}

	#endregion

	#region Class: EntitySynchronizer

	/// <summary>
	/// Entity external repository linkage.
	/// </summary>
	public class EntitySynchronizer : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public EntitySynchronizer(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EntitySynchronizer";
		}

		public EntitySynchronizer(EntitySynchronizer source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Remote key.
		/// </summary>
		public string RemoteKey {
			get {
				return GetTypedColumnValue<string>("RemoteKey");
			}
			set {
				SetColumnValue("RemoteKey", value);
			}
		}

		/// <summary>
		/// EntityId.
		/// </summary>
		public Guid EntityId {
			get {
				return GetTypedColumnValue<Guid>("EntityId");
			}
			set {
				SetColumnValue("EntityId", value);
			}
		}

		/// <summary>
		/// IntegrationSystem.
		/// </summary>
		public string IntegrationSystem {
			get {
				return GetTypedColumnValue<string>("IntegrationSystem");
			}
			set {
				SetColumnValue("IntegrationSystem", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EntitySynchronizer_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("EntitySynchronizerDeleted", e);
			Validating += (s, e) => ThrowEvent("EntitySynchronizerValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EntitySynchronizer(this);
		}

		#endregion

	}

	#endregion

	#region Class: EntitySynchronizer_BaseEventsProcess

	/// <exclude/>
	public partial class EntitySynchronizer_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : EntitySynchronizer
	{

		public EntitySynchronizer_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EntitySynchronizer_BaseEventsProcess";
			SchemaUId = new Guid("062699d9-028d-4266-8f21-66b4c9394f54");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("062699d9-028d-4266-8f21-66b4c9394f54");
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

	#region Class: EntitySynchronizer_BaseEventsProcess

	/// <exclude/>
	public class EntitySynchronizer_BaseEventsProcess : EntitySynchronizer_BaseEventsProcess<EntitySynchronizer>
	{

		public EntitySynchronizer_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EntitySynchronizer_BaseEventsProcess

	public partial class EntitySynchronizer_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: EntitySynchronizerEventsProcessSchema

	/// <exclude/>
	public class EntitySynchronizerEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public EntitySynchronizerEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public EntitySynchronizerEventsProcessSchema(EntitySynchronizerEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "EntitySynchronizer_BaseEventsProcess";
			UId = new Guid("dc53631f-7e39-442e-a29e-02a206064b90");
			CreatedInPackageId = new Guid("008b5e35-cd1d-462d-aec0-4fb9d28e872d");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
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
			return new EntitySynchronizerEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dc53631f-7e39-442e-a29e-02a206064b90"));
		}

		#endregion

	}

	#endregion


	#region Class: EntitySynchronizerEventsProcess

	/// <exclude/>
	public class EntitySynchronizerEventsProcess : EntitySynchronizer_BaseEventsProcess
	{

		public EntitySynchronizerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

