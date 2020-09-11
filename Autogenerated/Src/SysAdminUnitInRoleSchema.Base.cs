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

	#region Class: SysAdminUnitInRoleSchema

	/// <exclude/>
	public class SysAdminUnitInRoleSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysAdminUnitInRoleSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysAdminUnitInRoleSchema(SysAdminUnitInRoleSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysAdminUnitInRoleSchema(SysAdminUnitInRoleSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIX_SysAdminUnitId_RoleIdIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("a06bccf5-1fe1-41aa-acc2-479826506f52");
			index.Name = "IX_SysAdminUnitId_RoleId";
			index.CreatedInSchemaUId = new Guid("54be68f8-96c2-4418-b83b-286c226c0ac4");
			index.ModifiedInSchemaUId = new Guid("54be68f8-96c2-4418-b83b-286c226c0ac4");
			index.CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			EntitySchemaIndexColumn sysAdminUnitIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("0eabdfc1-9e18-43b8-8a5b-3e19813d4429"),
				ColumnUId = new Guid("584b4fdf-e7a2-46f7-9535-a815953034ea"),
				CreatedInSchemaUId = new Guid("54be68f8-96c2-4418-b83b-286c226c0ac4"),
				ModifiedInSchemaUId = new Guid("54be68f8-96c2-4418-b83b-286c226c0ac4"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(sysAdminUnitIdIndexColumn);
			EntitySchemaIndexColumn sysAdminUnitRoleIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("e945ca05-2e1a-401e-b430-9f45eff110be"),
				ColumnUId = new Guid("9c4879dd-36a9-41d9-b9d3-72bfaa200fb0"),
				CreatedInSchemaUId = new Guid("54be68f8-96c2-4418-b83b-286c226c0ac4"),
				ModifiedInSchemaUId = new Guid("54be68f8-96c2-4418-b83b-286c226c0ac4"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(sysAdminUnitRoleIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("54be68f8-96c2-4418-b83b-286c226c0ac4");
			RealUId = new Guid("54be68f8-96c2-4418-b83b-286c226c0ac4");
			Name = "SysAdminUnitInRole";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("584b4fdf-e7a2-46f7-9535-a815953034ea")) == null) {
				Columns.Add(CreateSysAdminUnitColumn());
			}
			if (Columns.FindByUId(new Guid("9c4879dd-36a9-41d9-b9d3-72bfaa200fb0")) == null) {
				Columns.Add(CreateSysAdminUnitRoleIdColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("54be68f8-96c2-4418-b83b-286c226c0ac4");
			column.CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("54be68f8-96c2-4418-b83b-286c226c0ac4");
			column.CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("54be68f8-96c2-4418-b83b-286c226c0ac4");
			column.CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("54be68f8-96c2-4418-b83b-286c226c0ac4");
			column.CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("54be68f8-96c2-4418-b83b-286c226c0ac4");
			column.CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("54be68f8-96c2-4418-b83b-286c226c0ac4");
			column.CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81");
			return column;
		}

		protected virtual EntitySchemaColumn CreateSysAdminUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("584b4fdf-e7a2-46f7-9535-a815953034ea"),
				Name = @"SysAdminUnit",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				IsCascade = true,
				CreatedInSchemaUId = new Guid("54be68f8-96c2-4418-b83b-286c226c0ac4"),
				ModifiedInSchemaUId = new Guid("54be68f8-96c2-4418-b83b-286c226c0ac4"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81")
			};
		}

		protected virtual EntitySchemaColumn CreateSysAdminUnitRoleIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("9c4879dd-36a9-41d9-b9d3-72bfaa200fb0"),
				Name = @"SysAdminUnitRoleId",
				CreatedInSchemaUId = new Guid("54be68f8-96c2-4418-b83b-286c226c0ac4"),
				ModifiedInSchemaUId = new Guid("54be68f8-96c2-4418-b83b-286c226c0ac4"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIX_SysAdminUnitId_RoleIdIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysAdminUnitInRoleEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysAdminUnitInRoleEventsProcessSchema() {
			var schema = new SysAdminUnitInRoleEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysAdminUnitInRole(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysAdminUnitInRole_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysAdminUnitInRoleSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysAdminUnitInRoleSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("54be68f8-96c2-4418-b83b-286c226c0ac4"));
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnitInRole

	/// <summary>
	/// User role.
	/// </summary>
	public class SysAdminUnitInRole : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysAdminUnitInRole(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysAdminUnitInRole";
		}

		public SysAdminUnitInRole(SysAdminUnitInRole source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysAdminUnitId {
			get {
				return GetTypedColumnValue<Guid>("SysAdminUnitId");
			}
			set {
				SetColumnValue("SysAdminUnitId", value);
				_sysAdminUnit = null;
			}
		}

		/// <exclude/>
		public string SysAdminUnitName {
			get {
				return GetTypedColumnValue<string>("SysAdminUnitName");
			}
			set {
				SetColumnValue("SysAdminUnitName", value);
				if (_sysAdminUnit != null) {
					_sysAdminUnit.Name = value;
				}
			}
		}

		private SysAdminUnit _sysAdminUnit;
		/// <summary>
		/// User.
		/// </summary>
		public SysAdminUnit SysAdminUnit {
			get {
				return _sysAdminUnit ??
					(_sysAdminUnit = LookupColumnEntities.GetEntity("SysAdminUnit") as SysAdminUnit);
			}
		}

		/// <summary>
		/// User role Id.
		/// </summary>
		public Guid SysAdminUnitRoleId {
			get {
				return GetTypedColumnValue<Guid>("SysAdminUnitRoleId");
			}
			set {
				SetColumnValue("SysAdminUnitRoleId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysAdminUnitInRole_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysAdminUnitInRoleDeleted", e);
			Inserting += (s, e) => ThrowEvent("SysAdminUnitInRoleInserting", e);
			Validating += (s, e) => ThrowEvent("SysAdminUnitInRoleValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysAdminUnitInRole(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnitInRole_BaseEventsProcess

	/// <exclude/>
	public partial class SysAdminUnitInRole_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysAdminUnitInRole
	{

		public SysAdminUnitInRole_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysAdminUnitInRole_BaseEventsProcess";
			SchemaUId = new Guid("54be68f8-96c2-4418-b83b-286c226c0ac4");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("54be68f8-96c2-4418-b83b-286c226c0ac4");
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

	#region Class: SysAdminUnitInRole_BaseEventsProcess

	/// <exclude/>
	public class SysAdminUnitInRole_BaseEventsProcess : SysAdminUnitInRole_BaseEventsProcess<SysAdminUnitInRole>
	{

		public SysAdminUnitInRole_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysAdminUnitInRole_BaseEventsProcess

	public partial class SysAdminUnitInRole_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysAdminUnitInRoleEventsProcessSchema

	/// <exclude/>
	public class SysAdminUnitInRoleEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysAdminUnitInRoleEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysAdminUnitInRoleEventsProcessSchema(SysAdminUnitInRoleEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysAdminUnitInRole_BaseEventsProcess";
			UId = new Guid("09b7ef42-786a-4312-aaf7-30d4570ffd41");
			CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81");
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
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81")
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
			return new SysAdminUnitInRoleEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("09b7ef42-786a-4312-aaf7-30d4570ffd41"));
		}

		#endregion

	}

	#endregion


	#region Class: SysAdminUnitInRoleEventsProcess

	/// <exclude/>
	public class SysAdminUnitInRoleEventsProcess : SysAdminUnitInRole_BaseEventsProcess
	{

		public SysAdminUnitInRoleEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

