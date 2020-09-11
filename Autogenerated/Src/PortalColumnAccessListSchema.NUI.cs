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

	#region Class: PortalColumnAccessListSchema

	/// <exclude/>
	public class PortalColumnAccessListSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public PortalColumnAccessListSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public PortalColumnAccessListSchema(PortalColumnAccessListSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public PortalColumnAccessListSchema(PortalColumnAccessListSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d9062f7d-b700-4b1a-972c-9864e8553bb1");
			RealUId = new Guid("d9062f7d-b700-4b1a-972c-9864e8553bb1");
			Name = "PortalColumnAccessList";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b03360a8-d50e-4cb0-a1d7-6d46d0b31bff")) == null) {
				Columns.Add(CreatePortalSchemaListColumn());
			}
			if (Columns.FindByUId(new Guid("087f5050-1d50-4639-905e-b75eea498ff8")) == null) {
				Columns.Add(CreateColumnUIdColumn());
			}
			if (Columns.FindByUId(new Guid("9ed7e3f6-ce67-41fb-8dcc-16c9c5e4d08f")) == null) {
				Columns.Add(CreateColumnNameColumn());
			}
		}

		protected virtual EntitySchemaColumn CreatePortalSchemaListColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b03360a8-d50e-4cb0-a1d7-6d46d0b31bff"),
				Name = @"PortalSchemaList",
				ReferenceSchemaUId = new Guid("b5bda4b9-d2bf-4b39-8ba5-1883ac2583a7"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("d9062f7d-b700-4b1a-972c-9864e8553bb1"),
				ModifiedInSchemaUId = new Guid("d9062f7d-b700-4b1a-972c-9864e8553bb1"),
				CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("087f5050-1d50-4639-905e-b75eea498ff8"),
				Name = @"ColumnUId",
				CreatedInSchemaUId = new Guid("d9062f7d-b700-4b1a-972c-9864e8553bb1"),
				ModifiedInSchemaUId = new Guid("d9062f7d-b700-4b1a-972c-9864e8553bb1"),
				CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("9ed7e3f6-ce67-41fb-8dcc-16c9c5e4d08f"),
				Name = @"ColumnName",
				CreatedInSchemaUId = new Guid("d9062f7d-b700-4b1a-972c-9864e8553bb1"),
				ModifiedInSchemaUId = new Guid("d9062f7d-b700-4b1a-972c-9864e8553bb1"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreatePortalColumnAccessListEventsProcessSchema();
		}

		protected virtual ProcessSchema CreatePortalColumnAccessListEventsProcessSchema() {
			var schema = new PortalColumnAccessListEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new PortalColumnAccessList(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new PortalColumnAccessList_NUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new PortalColumnAccessListSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new PortalColumnAccessListSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d9062f7d-b700-4b1a-972c-9864e8553bb1"));
		}

		#endregion

	}

	#endregion

	#region Class: PortalColumnAccessList

	/// <summary>
	/// PortalColumnAccessList.
	/// </summary>
	public class PortalColumnAccessList : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public PortalColumnAccessList(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "PortalColumnAccessList";
		}

		public PortalColumnAccessList(PortalColumnAccessList source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid PortalSchemaListId {
			get {
				return GetTypedColumnValue<Guid>("PortalSchemaListId");
			}
			set {
				SetColumnValue("PortalSchemaListId", value);
				_portalSchemaList = null;
			}
		}

		/// <exclude/>
		public string PortalSchemaListAccessEntitySchemaName {
			get {
				return GetTypedColumnValue<string>("PortalSchemaListAccessEntitySchemaName");
			}
			set {
				SetColumnValue("PortalSchemaListAccessEntitySchemaName", value);
				if (_portalSchemaList != null) {
					_portalSchemaList.AccessEntitySchemaName = value;
				}
			}
		}

		private PortalSchemaAccessList _portalSchemaList;
		/// <summary>
		/// List of schema fields for portal access.
		/// </summary>
		public PortalSchemaAccessList PortalSchemaList {
			get {
				return _portalSchemaList ??
					(_portalSchemaList = LookupColumnEntities.GetEntity("PortalSchemaList") as PortalSchemaAccessList);
			}
		}

		/// <summary>
		/// Column.
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
		/// Column name.
		/// </summary>
		public string ColumnName {
			get {
				return GetTypedColumnValue<string>("ColumnName");
			}
			set {
				SetColumnValue("ColumnName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new PortalColumnAccessList_NUIEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("PortalColumnAccessListDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PortalColumnAccessList(this);
		}

		#endregion

	}

	#endregion

	#region Class: PortalColumnAccessList_NUIEventsProcess

	/// <exclude/>
	public partial class PortalColumnAccessList_NUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : PortalColumnAccessList
	{

		public PortalColumnAccessList_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "PortalColumnAccessList_NUIEventsProcess";
			SchemaUId = new Guid("d9062f7d-b700-4b1a-972c-9864e8553bb1");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d9062f7d-b700-4b1a-972c-9864e8553bb1");
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

	#region Class: PortalColumnAccessList_NUIEventsProcess

	/// <exclude/>
	public class PortalColumnAccessList_NUIEventsProcess : PortalColumnAccessList_NUIEventsProcess<PortalColumnAccessList>
	{

		public PortalColumnAccessList_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: PortalColumnAccessList_NUIEventsProcess

	public partial class PortalColumnAccessList_NUIEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: PortalColumnAccessListEventsProcessSchema

	/// <exclude/>
	public class PortalColumnAccessListEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public PortalColumnAccessListEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public PortalColumnAccessListEventsProcessSchema(PortalColumnAccessListEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "PortalColumnAccessList_NUIEventsProcess";
			UId = new Guid("6226cfca-1553-4f57-abb1-f55bef605bcd");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
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
			return new PortalColumnAccessListEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6226cfca-1553-4f57-abb1-f55bef605bcd"));
		}

		#endregion

	}

	#endregion


	#region Class: PortalColumnAccessListEventsProcess

	/// <exclude/>
	public class PortalColumnAccessListEventsProcess : PortalColumnAccessList_NUIEventsProcess
	{

		public PortalColumnAccessListEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

