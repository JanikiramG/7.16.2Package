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

	#region Class: OptionalFuncSspRoleSchema

	/// <exclude/>
	public class OptionalFuncSspRoleSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public OptionalFuncSspRoleSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OptionalFuncSspRoleSchema(OptionalFuncSspRoleSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OptionalFuncSspRoleSchema(OptionalFuncSspRoleSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6683ee62-4939-41cc-9a61-e15b10dcbe81");
			RealUId = new Guid("6683ee62-4939-41cc-9a61-e15b10dcbe81");
			Name = "OptionalFuncSspRole";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("427d9055-0683-4368-b3bd-0704922bfd2e")) == null) {
				Columns.Add(CreateOrgRoleColumn());
			}
			if (Columns.FindByUId(new Guid("62fb7143-70e0-4a89-9939-06587e4cf53d")) == null) {
				Columns.Add(CreateFuncRoleColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateOrgRoleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("427d9055-0683-4368-b3bd-0704922bfd2e"),
				Name = @"OrgRole",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("6683ee62-4939-41cc-9a61-e15b10dcbe81"),
				ModifiedInSchemaUId = new Guid("6683ee62-4939-41cc-9a61-e15b10dcbe81"),
				CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c")
			};
		}

		protected virtual EntitySchemaColumn CreateFuncRoleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("62fb7143-70e0-4a89-9939-06587e4cf53d"),
				Name = @"FuncRole",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("6683ee62-4939-41cc-9a61-e15b10dcbe81"),
				ModifiedInSchemaUId = new Guid("6683ee62-4939-41cc-9a61-e15b10dcbe81"),
				CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOptionalFuncSspRoleEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateOptionalFuncSspRoleEventsProcessSchema() {
			var schema = new OptionalFuncSspRoleEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OptionalFuncSspRole(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OptionalFuncSspRole_SSPEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OptionalFuncSspRoleSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OptionalFuncSspRoleSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6683ee62-4939-41cc-9a61-e15b10dcbe81"));
		}

		#endregion

	}

	#endregion

	#region Class: OptionalFuncSspRole

	/// <summary>
	/// Roles for portal organization.
	/// </summary>
	public class OptionalFuncSspRole : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public OptionalFuncSspRole(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OptionalFuncSspRole";
		}

		public OptionalFuncSspRole(OptionalFuncSspRole source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid OrgRoleId {
			get {
				return GetTypedColumnValue<Guid>("OrgRoleId");
			}
			set {
				SetColumnValue("OrgRoleId", value);
				_orgRole = null;
			}
		}

		/// <exclude/>
		public string OrgRoleName {
			get {
				return GetTypedColumnValue<string>("OrgRoleName");
			}
			set {
				SetColumnValue("OrgRoleName", value);
				if (_orgRole != null) {
					_orgRole.Name = value;
				}
			}
		}

		private SysAdminUnit _orgRole;
		/// <summary>
		/// Organizational role.
		/// </summary>
		public SysAdminUnit OrgRole {
			get {
				return _orgRole ??
					(_orgRole = LookupColumnEntities.GetEntity("OrgRole") as SysAdminUnit);
			}
		}

		/// <exclude/>
		public Guid FuncRoleId {
			get {
				return GetTypedColumnValue<Guid>("FuncRoleId");
			}
			set {
				SetColumnValue("FuncRoleId", value);
				_funcRole = null;
			}
		}

		/// <exclude/>
		public string FuncRoleName {
			get {
				return GetTypedColumnValue<string>("FuncRoleName");
			}
			set {
				SetColumnValue("FuncRoleName", value);
				if (_funcRole != null) {
					_funcRole.Name = value;
				}
			}
		}

		private SysAdminUnit _funcRole;
		/// <summary>
		/// Functional role.
		/// </summary>
		public SysAdminUnit FuncRole {
			get {
				return _funcRole ??
					(_funcRole = LookupColumnEntities.GetEntity("FuncRole") as SysAdminUnit);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OptionalFuncSspRole_SSPEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OptionalFuncSspRole(this);
		}

		#endregion

	}

	#endregion

	#region Class: OptionalFuncSspRole_SSPEventsProcess

	/// <exclude/>
	public partial class OptionalFuncSspRole_SSPEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : OptionalFuncSspRole
	{

		public OptionalFuncSspRole_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OptionalFuncSspRole_SSPEventsProcess";
			SchemaUId = new Guid("6683ee62-4939-41cc-9a61-e15b10dcbe81");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6683ee62-4939-41cc-9a61-e15b10dcbe81");
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

	#region Class: OptionalFuncSspRole_SSPEventsProcess

	/// <exclude/>
	public class OptionalFuncSspRole_SSPEventsProcess : OptionalFuncSspRole_SSPEventsProcess<OptionalFuncSspRole>
	{

		public OptionalFuncSspRole_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OptionalFuncSspRole_SSPEventsProcess

	public partial class OptionalFuncSspRole_SSPEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: OptionalFuncSspRoleEventsProcessSchema

	/// <exclude/>
	public class OptionalFuncSspRoleEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public OptionalFuncSspRoleEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public OptionalFuncSspRoleEventsProcessSchema(OptionalFuncSspRoleEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OptionalFuncSspRole_SSPEventsProcess";
			UId = new Guid("7a55c070-9d15-4120-a790-4ef1cb4aafad");
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
			return new OptionalFuncSspRoleEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7a55c070-9d15-4120-a790-4ef1cb4aafad"));
		}

		#endregion

	}

	#endregion


	#region Class: OptionalFuncSspRoleEventsProcess

	/// <exclude/>
	public class OptionalFuncSspRoleEventsProcess : OptionalFuncSspRole_SSPEventsProcess
	{

		public OptionalFuncSspRoleEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

