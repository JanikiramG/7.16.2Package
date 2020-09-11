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

	#region Class: EntityConnectionSchema

	/// <exclude/>
	public class EntityConnectionSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public EntityConnectionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EntityConnectionSchema(EntityConnectionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EntityConnectionSchema(EntityConnectionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("187a8e9a-6f0e-465d-aeb0-9556dfa93b7d");
			RealUId = new Guid("187a8e9a-6f0e-465d-aeb0-9556dfa93b7d");
			Name = "EntityConnection";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("cba1f828-e8f7-4368-82f1-f4ebfa3f0157");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("2d2a1d06-fa97-4bb5-b37c-6af8782f7a07")) == null) {
				Columns.Add(CreateSysEntitySchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("a79438c7-070f-4f50-b9c4-509c94770c82")) == null) {
				Columns.Add(CreateColumnUIdColumn());
			}
			if (Columns.FindByUId(new Guid("c1ab9d0a-ff01-456b-bc0f-d11cd879b870")) == null) {
				Columns.Add(CreatePositionColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("187a8e9a-6f0e-465d-aeb0-9556dfa93b7d");
			column.CreatedInPackageId = new Guid("cba1f828-e8f7-4368-82f1-f4ebfa3f0157");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("187a8e9a-6f0e-465d-aeb0-9556dfa93b7d");
			column.CreatedInPackageId = new Guid("cba1f828-e8f7-4368-82f1-f4ebfa3f0157");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("187a8e9a-6f0e-465d-aeb0-9556dfa93b7d");
			column.CreatedInPackageId = new Guid("cba1f828-e8f7-4368-82f1-f4ebfa3f0157");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("187a8e9a-6f0e-465d-aeb0-9556dfa93b7d");
			column.CreatedInPackageId = new Guid("cba1f828-e8f7-4368-82f1-f4ebfa3f0157");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("187a8e9a-6f0e-465d-aeb0-9556dfa93b7d");
			column.CreatedInPackageId = new Guid("cba1f828-e8f7-4368-82f1-f4ebfa3f0157");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("187a8e9a-6f0e-465d-aeb0-9556dfa93b7d");
			column.CreatedInPackageId = new Guid("cba1f828-e8f7-4368-82f1-f4ebfa3f0157");
			return column;
		}

		protected virtual EntitySchemaColumn CreateSysEntitySchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("2d2a1d06-fa97-4bb5-b37c-6af8782f7a07"),
				Name = @"SysEntitySchemaUId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("187a8e9a-6f0e-465d-aeb0-9556dfa93b7d"),
				ModifiedInSchemaUId = new Guid("187a8e9a-6f0e-465d-aeb0-9556dfa93b7d"),
				CreatedInPackageId = new Guid("cba1f828-e8f7-4368-82f1-f4ebfa3f0157")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("a79438c7-070f-4f50-b9c4-509c94770c82"),
				Name = @"ColumnUId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("187a8e9a-6f0e-465d-aeb0-9556dfa93b7d"),
				ModifiedInSchemaUId = new Guid("187a8e9a-6f0e-465d-aeb0-9556dfa93b7d"),
				CreatedInPackageId = new Guid("cba1f828-e8f7-4368-82f1-f4ebfa3f0157")
			};
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("c1ab9d0a-ff01-456b-bc0f-d11cd879b870"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("187a8e9a-6f0e-465d-aeb0-9556dfa93b7d"),
				ModifiedInSchemaUId = new Guid("187a8e9a-6f0e-465d-aeb0-9556dfa93b7d"),
				CreatedInPackageId = new Guid("766630f1-8a05-4fa8-862c-b93f376378cb")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateEntityConnectionEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateEntityConnectionEventsProcessSchema() {
			var schema = new EntityConnectionEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new EntityConnection(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EntityConnection_UIv2EventsProcess(userConnection);
		}

		public override object Clone() {
			return new EntityConnectionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EntityConnectionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("187a8e9a-6f0e-465d-aeb0-9556dfa93b7d"));
		}

		#endregion

	}

	#endregion

	#region Class: EntityConnection

	/// <summary>
	/// System object connection.
	/// </summary>
	public class EntityConnection : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public EntityConnection(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EntityConnection";
		}

		public EntityConnection(EntityConnection source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Section object.
		/// </summary>
		public Guid SysEntitySchemaUId {
			get {
				return GetTypedColumnValue<Guid>("SysEntitySchemaUId");
			}
			set {
				SetColumnValue("SysEntitySchemaUId", value);
			}
		}

		/// <summary>
		/// Connection column Id.
		/// </summary>
		public Guid ColumnUId {
			get {
				return GetTypedColumnValue<Guid>("ColumnUId");
			}
			set {
				SetColumnValue("ColumnUId", value);
			}
		}

		/// <summary>
		/// Position.
		/// </summary>
		public int Position {
			get {
				return GetTypedColumnValue<int>("Position");
			}
			set {
				SetColumnValue("Position", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EntityConnection_UIv2EventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("EntityConnectionDeleted", e);
			Inserting += (s, e) => ThrowEvent("EntityConnectionInserting", e);
			Validating += (s, e) => ThrowEvent("EntityConnectionValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EntityConnection(this);
		}

		#endregion

	}

	#endregion

	#region Class: EntityConnection_UIv2EventsProcess

	/// <exclude/>
	public partial class EntityConnection_UIv2EventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : EntityConnection
	{

		public EntityConnection_UIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EntityConnection_UIv2EventsProcess";
			SchemaUId = new Guid("187a8e9a-6f0e-465d-aeb0-9556dfa93b7d");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("187a8e9a-6f0e-465d-aeb0-9556dfa93b7d");
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

	#region Class: EntityConnection_UIv2EventsProcess

	/// <exclude/>
	public class EntityConnection_UIv2EventsProcess : EntityConnection_UIv2EventsProcess<EntityConnection>
	{

		public EntityConnection_UIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EntityConnection_UIv2EventsProcess

	public partial class EntityConnection_UIv2EventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: EntityConnectionEventsProcessSchema

	/// <exclude/>
	public class EntityConnectionEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public EntityConnectionEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public EntityConnectionEventsProcessSchema(EntityConnectionEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "EntityConnection_UIv2EventsProcess";
			UId = new Guid("1930ba33-c4cd-4a98-8325-25ca413b2510");
			CreatedInPackageId = new Guid("cba1f828-e8f7-4368-82f1-f4ebfa3f0157");
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
				CreatedInPackageId = new Guid("cba1f828-e8f7-4368-82f1-f4ebfa3f0157")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("cba1f828-e8f7-4368-82f1-f4ebfa3f0157")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("cba1f828-e8f7-4368-82f1-f4ebfa3f0157")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("cba1f828-e8f7-4368-82f1-f4ebfa3f0157")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("cba1f828-e8f7-4368-82f1-f4ebfa3f0157")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("cba1f828-e8f7-4368-82f1-f4ebfa3f0157")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("cba1f828-e8f7-4368-82f1-f4ebfa3f0157")
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
			return new EntityConnectionEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1930ba33-c4cd-4a98-8325-25ca413b2510"));
		}

		#endregion

	}

	#endregion


	#region Class: EntityConnectionEventsProcess

	/// <exclude/>
	public class EntityConnectionEventsProcess : EntityConnection_UIv2EventsProcess
	{

		public EntityConnectionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

