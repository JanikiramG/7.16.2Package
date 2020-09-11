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

	#region Class: SysSubProcessInProcessSchema

	/// <exclude/>
	public class SysSubProcessInProcessSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysSubProcessInProcessSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysSubProcessInProcessSchema(SysSubProcessInProcessSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysSubProcessInProcessSchema(SysSubProcessInProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("40bba32d-291c-41a1-8445-64f60f26b2d4");
			RealUId = new Guid("40bba32d-291c-41a1-8445-64f60f26b2d4");
			Name = "SysSubProcessInProcess";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("fb7efc77-f006-4653-89e5-383b980315d3")) == null) {
				Columns.Add(CreateProcessUIdColumn());
			}
			if (Columns.FindByUId(new Guid("f089ad99-d3d8-4d17-b0d4-0008e761a4a0")) == null) {
				Columns.Add(CreateParentProcessUIdColumn());
			}
			if (Columns.FindByUId(new Guid("f3c1536b-43cc-48bc-ab57-93671ffc76ef")) == null) {
				Columns.Add(CreateSubProcessUIdColumn());
			}
			if (Columns.FindByUId(new Guid("0c275024-8301-4d0e-9d16-2b9d849e8870")) == null) {
				Columns.Add(CreateParentSubProcessUIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateProcessUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("fb7efc77-f006-4653-89e5-383b980315d3"),
				Name = @"ProcessUId",
				CreatedInSchemaUId = new Guid("40bba32d-291c-41a1-8445-64f60f26b2d4"),
				ModifiedInSchemaUId = new Guid("40bba32d-291c-41a1-8445-64f60f26b2d4"),
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			};
		}

		protected virtual EntitySchemaColumn CreateParentProcessUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("f089ad99-d3d8-4d17-b0d4-0008e761a4a0"),
				Name = @"ParentProcessUId",
				CreatedInSchemaUId = new Guid("40bba32d-291c-41a1-8445-64f60f26b2d4"),
				ModifiedInSchemaUId = new Guid("40bba32d-291c-41a1-8445-64f60f26b2d4"),
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			};
		}

		protected virtual EntitySchemaColumn CreateSubProcessUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("f3c1536b-43cc-48bc-ab57-93671ffc76ef"),
				Name = @"SubProcessUId",
				CreatedInSchemaUId = new Guid("40bba32d-291c-41a1-8445-64f60f26b2d4"),
				ModifiedInSchemaUId = new Guid("40bba32d-291c-41a1-8445-64f60f26b2d4"),
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			};
		}

		protected virtual EntitySchemaColumn CreateParentSubProcessUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("0c275024-8301-4d0e-9d16-2b9d849e8870"),
				Name = @"ParentSubProcessUId",
				CreatedInSchemaUId = new Guid("40bba32d-291c-41a1-8445-64f60f26b2d4"),
				ModifiedInSchemaUId = new Guid("40bba32d-291c-41a1-8445-64f60f26b2d4"),
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysSubProcessInProcessEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysSubProcessInProcessEventsProcessSchema() {
			var schema = new SysSubProcessInProcessEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysSubProcessInProcess(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysSubProcessInProcess_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysSubProcessInProcessSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysSubProcessInProcessSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("40bba32d-291c-41a1-8445-64f60f26b2d4"));
		}

		#endregion

	}

	#endregion

	#region Class: SysSubProcessInProcess

	/// <summary>
	/// SysSubProcessInProcess.
	/// </summary>
	public class SysSubProcessInProcess : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysSubProcessInProcess(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysSubProcessInProcess";
		}

		public SysSubProcessInProcess(SysSubProcessInProcess source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// ProcessUId.
		/// </summary>
		public Guid ProcessUId {
			get {
				return GetTypedColumnValue<Guid>("ProcessUId");
			}
			set {
				SetColumnValue("ProcessUId", value);
			}
		}

		/// <summary>
		/// ParentProcessUId.
		/// </summary>
		public Guid ParentProcessUId {
			get {
				return GetTypedColumnValue<Guid>("ParentProcessUId");
			}
			set {
				SetColumnValue("ParentProcessUId", value);
			}
		}

		/// <summary>
		/// SubProcessUId.
		/// </summary>
		public Guid SubProcessUId {
			get {
				return GetTypedColumnValue<Guid>("SubProcessUId");
			}
			set {
				SetColumnValue("SubProcessUId", value);
			}
		}

		/// <summary>
		/// ParentSubProcessUId.
		/// </summary>
		public Guid ParentSubProcessUId {
			get {
				return GetTypedColumnValue<Guid>("ParentSubProcessUId");
			}
			set {
				SetColumnValue("ParentSubProcessUId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysSubProcessInProcess_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysSubProcessInProcessDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysSubProcessInProcess(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysSubProcessInProcess_BaseEventsProcess

	/// <exclude/>
	public partial class SysSubProcessInProcess_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysSubProcessInProcess
	{

		public SysSubProcessInProcess_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysSubProcessInProcess_BaseEventsProcess";
			SchemaUId = new Guid("40bba32d-291c-41a1-8445-64f60f26b2d4");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("40bba32d-291c-41a1-8445-64f60f26b2d4");
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

	#region Class: SysSubProcessInProcess_BaseEventsProcess

	/// <exclude/>
	public class SysSubProcessInProcess_BaseEventsProcess : SysSubProcessInProcess_BaseEventsProcess<SysSubProcessInProcess>
	{

		public SysSubProcessInProcess_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysSubProcessInProcess_BaseEventsProcess

	public partial class SysSubProcessInProcess_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysSubProcessInProcessEventsProcessSchema

	/// <exclude/>
	public class SysSubProcessInProcessEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysSubProcessInProcessEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysSubProcessInProcessEventsProcessSchema(SysSubProcessInProcessEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysSubProcessInProcess_BaseEventsProcess";
			UId = new Guid("66c47f3d-6699-46b3-9315-8f5401a93b23");
			CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90");
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
			return new SysSubProcessInProcessEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("66c47f3d-6699-46b3-9315-8f5401a93b23"));
		}

		#endregion

	}

	#endregion


	#region Class: SysSubProcessInProcessEventsProcess

	/// <exclude/>
	public class SysSubProcessInProcessEventsProcess : SysSubProcessInProcess_BaseEventsProcess
	{

		public SysSubProcessInProcessEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

