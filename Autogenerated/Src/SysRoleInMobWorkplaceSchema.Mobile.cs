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

	#region Class: SysRoleInMobWorkplaceSchema

	/// <exclude/>
	public class SysRoleInMobWorkplaceSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysRoleInMobWorkplaceSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysRoleInMobWorkplaceSchema(SysRoleInMobWorkplaceSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysRoleInMobWorkplaceSchema(SysRoleInMobWorkplaceSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9ae19253-237b-4118-9a52-00457a54cd2c");
			RealUId = new Guid("9ae19253-237b-4118-9a52-00457a54cd2c");
			Name = "SysRoleInMobWorkplace";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("c1cb05bd-938c-4278-baef-f070f0a69ab7");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("6228e93a-cf49-4f31-b0f6-1451f369561d")) == null) {
				Columns.Add(CreateSysRoleColumn());
			}
			if (Columns.FindByUId(new Guid("f44ceed8-218c-49a0-8148-9fff988ec938")) == null) {
				Columns.Add(CreateSysMobileWorkplaceColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysRoleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6228e93a-cf49-4f31-b0f6-1451f369561d"),
				Name = @"SysRole",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("9ae19253-237b-4118-9a52-00457a54cd2c"),
				ModifiedInSchemaUId = new Guid("9ae19253-237b-4118-9a52-00457a54cd2c"),
				CreatedInPackageId = new Guid("c1cb05bd-938c-4278-baef-f070f0a69ab7")
			};
		}

		protected virtual EntitySchemaColumn CreateSysMobileWorkplaceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f44ceed8-218c-49a0-8148-9fff988ec938"),
				Name = @"SysMobileWorkplace",
				ReferenceSchemaUId = new Guid("5149a215-3fff-4d7e-ac0e-43816e19cce5"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("9ae19253-237b-4118-9a52-00457a54cd2c"),
				ModifiedInSchemaUId = new Guid("9ae19253-237b-4118-9a52-00457a54cd2c"),
				CreatedInPackageId = new Guid("c1cb05bd-938c-4278-baef-f070f0a69ab7")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysRoleInMobWorkplaceEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysRoleInMobWorkplaceEventsProcessSchema() {
			var schema = new SysRoleInMobWorkplaceEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysRoleInMobWorkplace(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysRoleInMobWorkplace_MobileEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysRoleInMobWorkplaceSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysRoleInMobWorkplaceSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9ae19253-237b-4118-9a52-00457a54cd2c"));
		}

		#endregion

	}

	#endregion

	#region Class: SysRoleInMobWorkplace

	/// <summary>
	/// Mobile application workplace roles.
	/// </summary>
	public class SysRoleInMobWorkplace : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysRoleInMobWorkplace(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysRoleInMobWorkplace";
		}

		public SysRoleInMobWorkplace(SysRoleInMobWorkplace source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysRoleId {
			get {
				return GetTypedColumnValue<Guid>("SysRoleId");
			}
			set {
				SetColumnValue("SysRoleId", value);
				_sysRole = null;
			}
		}

		/// <exclude/>
		public string SysRoleName {
			get {
				return GetTypedColumnValue<string>("SysRoleName");
			}
			set {
				SetColumnValue("SysRoleName", value);
				if (_sysRole != null) {
					_sysRole.Name = value;
				}
			}
		}

		private SysAdminUnit _sysRole;
		/// <summary>
		/// Role.
		/// </summary>
		public SysAdminUnit SysRole {
			get {
				return _sysRole ??
					(_sysRole = LookupColumnEntities.GetEntity("SysRole") as SysAdminUnit);
			}
		}

		/// <exclude/>
		public Guid SysMobileWorkplaceId {
			get {
				return GetTypedColumnValue<Guid>("SysMobileWorkplaceId");
			}
			set {
				SetColumnValue("SysMobileWorkplaceId", value);
				_sysMobileWorkplace = null;
			}
		}

		/// <exclude/>
		public string SysMobileWorkplaceName {
			get {
				return GetTypedColumnValue<string>("SysMobileWorkplaceName");
			}
			set {
				SetColumnValue("SysMobileWorkplaceName", value);
				if (_sysMobileWorkplace != null) {
					_sysMobileWorkplace.Name = value;
				}
			}
		}

		private SysMobileWorkplace _sysMobileWorkplace;
		/// <summary>
		/// Mobile application workplace.
		/// </summary>
		public SysMobileWorkplace SysMobileWorkplace {
			get {
				return _sysMobileWorkplace ??
					(_sysMobileWorkplace = LookupColumnEntities.GetEntity("SysMobileWorkplace") as SysMobileWorkplace);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysRoleInMobWorkplace_MobileEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysRoleInMobWorkplaceDeleted", e);
			Validating += (s, e) => ThrowEvent("SysRoleInMobWorkplaceValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysRoleInMobWorkplace(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysRoleInMobWorkplace_MobileEventsProcess

	/// <exclude/>
	public partial class SysRoleInMobWorkplace_MobileEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysRoleInMobWorkplace
	{

		public SysRoleInMobWorkplace_MobileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysRoleInMobWorkplace_MobileEventsProcess";
			SchemaUId = new Guid("9ae19253-237b-4118-9a52-00457a54cd2c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9ae19253-237b-4118-9a52-00457a54cd2c");
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

	#region Class: SysRoleInMobWorkplace_MobileEventsProcess

	/// <exclude/>
	public class SysRoleInMobWorkplace_MobileEventsProcess : SysRoleInMobWorkplace_MobileEventsProcess<SysRoleInMobWorkplace>
	{

		public SysRoleInMobWorkplace_MobileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysRoleInMobWorkplace_MobileEventsProcess

	public partial class SysRoleInMobWorkplace_MobileEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysRoleInMobWorkplaceEventsProcessSchema

	/// <exclude/>
	public class SysRoleInMobWorkplaceEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysRoleInMobWorkplaceEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysRoleInMobWorkplaceEventsProcessSchema(SysRoleInMobWorkplaceEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysRoleInMobWorkplace_MobileEventsProcess";
			UId = new Guid("ead81a5f-8a5b-43e7-94b7-08361285720f");
			CreatedInPackageId = new Guid("c1cb05bd-938c-4278-baef-f070f0a69ab7");
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
			return new SysRoleInMobWorkplaceEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ead81a5f-8a5b-43e7-94b7-08361285720f"));
		}

		#endregion

	}

	#endregion


	#region Class: SysRoleInMobWorkplaceEventsProcess

	/// <exclude/>
	public class SysRoleInMobWorkplaceEventsProcess : SysRoleInMobWorkplace_MobileEventsProcess
	{

		public SysRoleInMobWorkplaceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

