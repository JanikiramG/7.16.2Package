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

	#region Class: SysSqlScriptDependencySchema

	/// <exclude/>
	public class SysSqlScriptDependencySchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysSqlScriptDependencySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysSqlScriptDependencySchema(SysSqlScriptDependencySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysSqlScriptDependencySchema(SysSqlScriptDependencySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIUSysSqlScriptDependencyIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = true
			};
			index.UId = new Guid("0c928959-ae31-4207-b372-a16c9e677bf7");
			index.Name = "IUSysSqlScriptDependency";
			index.CreatedInSchemaUId = new Guid("59b473c1-b952-4f6c-b6e3-285cedf4f31c");
			index.ModifiedInSchemaUId = new Guid("59b473c1-b952-4f6c-b6e3-285cedf4f31c");
			index.CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7");
			EntitySchemaIndexColumn sysSqlScriptIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("7c5d864f-3656-4f7a-bfcf-02862076d088"),
				ColumnUId = new Guid("55306f65-4d03-4020-823a-b8c90b740375"),
				CreatedInSchemaUId = new Guid("59b473c1-b952-4f6c-b6e3-285cedf4f31c"),
				ModifiedInSchemaUId = new Guid("59b473c1-b952-4f6c-b6e3-285cedf4f31c"),
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(sysSqlScriptIdIndexColumn);
			EntitySchemaIndexColumn dependOnSqlScriptIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("0226d7dc-843a-4f6d-9a8c-4eaff46ad91f"),
				ColumnUId = new Guid("365d9065-6c2d-475d-8962-6ec682fe8c2f"),
				CreatedInSchemaUId = new Guid("59b473c1-b952-4f6c-b6e3-285cedf4f31c"),
				ModifiedInSchemaUId = new Guid("59b473c1-b952-4f6c-b6e3-285cedf4f31c"),
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(dependOnSqlScriptIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("59b473c1-b952-4f6c-b6e3-285cedf4f31c");
			RealUId = new Guid("59b473c1-b952-4f6c-b6e3-285cedf4f31c");
			Name = "SysSqlScriptDependency";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("55306f65-4d03-4020-823a-b8c90b740375")) == null) {
				Columns.Add(CreateSysSqlScriptColumn());
			}
			if (Columns.FindByUId(new Guid("365d9065-6c2d-475d-8962-6ec682fe8c2f")) == null) {
				Columns.Add(CreateDependOnSqlScriptColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("59b473c1-b952-4f6c-b6e3-285cedf4f31c");
			column.CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("59b473c1-b952-4f6c-b6e3-285cedf4f31c");
			column.CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("59b473c1-b952-4f6c-b6e3-285cedf4f31c");
			column.CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("59b473c1-b952-4f6c-b6e3-285cedf4f31c");
			column.CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("59b473c1-b952-4f6c-b6e3-285cedf4f31c");
			column.CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("59b473c1-b952-4f6c-b6e3-285cedf4f31c");
			column.CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7");
			return column;
		}

		protected virtual EntitySchemaColumn CreateSysSqlScriptColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("55306f65-4d03-4020-823a-b8c90b740375"),
				Name = @"SysSqlScript",
				ReferenceSchemaUId = new Guid("d06ec721-ade7-4d80-b187-059f61168f9d"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("59b473c1-b952-4f6c-b6e3-285cedf4f31c"),
				ModifiedInSchemaUId = new Guid("59b473c1-b952-4f6c-b6e3-285cedf4f31c"),
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7")
			};
		}

		protected virtual EntitySchemaColumn CreateDependOnSqlScriptColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("365d9065-6c2d-475d-8962-6ec682fe8c2f"),
				Name = @"DependOnSqlScript",
				ReferenceSchemaUId = new Guid("d06ec721-ade7-4d80-b187-059f61168f9d"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("59b473c1-b952-4f6c-b6e3-285cedf4f31c"),
				ModifiedInSchemaUId = new Guid("59b473c1-b952-4f6c-b6e3-285cedf4f31c"),
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIUSysSqlScriptDependencyIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysSqlScriptDependencyEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysSqlScriptDependencyEventsProcessSchema() {
			var schema = new SysSqlScriptDependencyEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysSqlScriptDependency(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysSqlScriptDependency_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysSqlScriptDependencySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysSqlScriptDependencySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("59b473c1-b952-4f6c-b6e3-285cedf4f31c"));
		}

		#endregion

	}

	#endregion

	#region Class: SysSqlScriptDependency

	/// <summary>
	/// SQL script dependencies.
	/// </summary>
	public class SysSqlScriptDependency : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysSqlScriptDependency(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysSqlScriptDependency";
		}

		public SysSqlScriptDependency(SysSqlScriptDependency source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysSqlScriptId {
			get {
				return GetTypedColumnValue<Guid>("SysSqlScriptId");
			}
			set {
				SetColumnValue("SysSqlScriptId", value);
				_sysSqlScript = null;
			}
		}

		private SysPackageSqlScript _sysSqlScript;
		/// <summary>
		/// SQL script.
		/// </summary>
		public SysPackageSqlScript SysSqlScript {
			get {
				return _sysSqlScript ??
					(_sysSqlScript = LookupColumnEntities.GetEntity("SysSqlScript") as SysPackageSqlScript);
			}
		}

		/// <exclude/>
		public Guid DependOnSqlScriptId {
			get {
				return GetTypedColumnValue<Guid>("DependOnSqlScriptId");
			}
			set {
				SetColumnValue("DependOnSqlScriptId", value);
				_dependOnSqlScript = null;
			}
		}

		private SysPackageSqlScript _dependOnSqlScript;
		/// <summary>
		/// Depends on SQL script.
		/// </summary>
		public SysPackageSqlScript DependOnSqlScript {
			get {
				return _dependOnSqlScript ??
					(_dependOnSqlScript = LookupColumnEntities.GetEntity("DependOnSqlScript") as SysPackageSqlScript);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysSqlScriptDependency_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysSqlScriptDependencyDeleted", e);
			Inserting += (s, e) => ThrowEvent("SysSqlScriptDependencyInserting", e);
			Validating += (s, e) => ThrowEvent("SysSqlScriptDependencyValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysSqlScriptDependency(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysSqlScriptDependency_BaseEventsProcess

	/// <exclude/>
	public partial class SysSqlScriptDependency_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysSqlScriptDependency
	{

		public SysSqlScriptDependency_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysSqlScriptDependency_BaseEventsProcess";
			SchemaUId = new Guid("59b473c1-b952-4f6c-b6e3-285cedf4f31c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("59b473c1-b952-4f6c-b6e3-285cedf4f31c");
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

	#region Class: SysSqlScriptDependency_BaseEventsProcess

	/// <exclude/>
	public class SysSqlScriptDependency_BaseEventsProcess : SysSqlScriptDependency_BaseEventsProcess<SysSqlScriptDependency>
	{

		public SysSqlScriptDependency_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysSqlScriptDependency_BaseEventsProcess

	public partial class SysSqlScriptDependency_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysSqlScriptDependencyEventsProcessSchema

	/// <exclude/>
	public class SysSqlScriptDependencyEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysSqlScriptDependencyEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysSqlScriptDependencyEventsProcessSchema(SysSqlScriptDependencyEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysSqlScriptDependency_BaseEventsProcess";
			UId = new Guid("a2b29c27-02f2-43cc-ab3c-7e339330716b");
			CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7");
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
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7")
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
			return new SysSqlScriptDependencyEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a2b29c27-02f2-43cc-ab3c-7e339330716b"));
		}

		#endregion

	}

	#endregion


	#region Class: SysSqlScriptDependencyEventsProcess

	/// <exclude/>
	public class SysSqlScriptDependencyEventsProcess : SysSqlScriptDependency_BaseEventsProcess
	{

		public SysSqlScriptDependencyEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

