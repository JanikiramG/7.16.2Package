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

	#region Class: SysEntitySchemaOperationRightSchema

	/// <exclude/>
	public class SysEntitySchemaOperationRightSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysEntitySchemaOperationRightSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysEntitySchemaOperationRightSchema(SysEntitySchemaOperationRightSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysEntitySchemaOperationRightSchema(SysEntitySchemaOperationRightSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f028c2c5-facc-4109-8cfa-75b2b6620527");
			RealUId = new Guid("f028c2c5-facc-4109-8cfa-75b2b6620527");
			Name = "SysEntitySchemaOperationRight";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("d27e9964-a7a6-46dd-9f9a-7cb470c33b98")) == null) {
				Columns.Add(CreateSysAdminUnitColumn());
			}
			if (Columns.FindByUId(new Guid("a3dc68d6-f74e-4a57-8411-77a88dfe0bbb")) == null) {
				Columns.Add(CreateCanReadColumn());
			}
			if (Columns.FindByUId(new Guid("21a61238-45dc-4089-9882-cc1be097cbf8")) == null) {
				Columns.Add(CreateCanAppendColumn());
			}
			if (Columns.FindByUId(new Guid("379b41a2-dfb5-4069-a267-88ec0653e391")) == null) {
				Columns.Add(CreateCanEditColumn());
			}
			if (Columns.FindByUId(new Guid("2cda2c20-d48a-44d0-b266-5542730b1ad9")) == null) {
				Columns.Add(CreateCanDeleteColumn());
			}
			if (Columns.FindByUId(new Guid("a72532ba-4755-4b2f-8079-c382ae6d0e9a")) == null) {
				Columns.Add(CreatePositionColumn());
			}
			if (Columns.FindByUId(new Guid("134c280f-f7a7-4ac5-beeb-4ab1ed9e4ff5")) == null) {
				Columns.Add(CreateSubjectSchemaUIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysAdminUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d27e9964-a7a6-46dd-9f9a-7cb470c33b98"),
				Name = @"SysAdminUnit",
				ReferenceSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsWeakReference = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("f028c2c5-facc-4109-8cfa-75b2b6620527"),
				ModifiedInSchemaUId = new Guid("f028c2c5-facc-4109-8cfa-75b2b6620527"),
				CreatedInPackageId = new Guid("7a22b6a0-37cb-4535-8949-1111b2b1ad98")
			};
		}

		protected virtual EntitySchemaColumn CreateCanReadColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("a3dc68d6-f74e-4a57-8411-77a88dfe0bbb"),
				Name = @"CanRead",
				CreatedInSchemaUId = new Guid("f028c2c5-facc-4109-8cfa-75b2b6620527"),
				ModifiedInSchemaUId = new Guid("f028c2c5-facc-4109-8cfa-75b2b6620527"),
				CreatedInPackageId = new Guid("7a22b6a0-37cb-4535-8949-1111b2b1ad98")
			};
		}

		protected virtual EntitySchemaColumn CreateCanAppendColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("21a61238-45dc-4089-9882-cc1be097cbf8"),
				Name = @"CanAppend",
				CreatedInSchemaUId = new Guid("f028c2c5-facc-4109-8cfa-75b2b6620527"),
				ModifiedInSchemaUId = new Guid("f028c2c5-facc-4109-8cfa-75b2b6620527"),
				CreatedInPackageId = new Guid("7a22b6a0-37cb-4535-8949-1111b2b1ad98")
			};
		}

		protected virtual EntitySchemaColumn CreateCanEditColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("379b41a2-dfb5-4069-a267-88ec0653e391"),
				Name = @"CanEdit",
				CreatedInSchemaUId = new Guid("f028c2c5-facc-4109-8cfa-75b2b6620527"),
				ModifiedInSchemaUId = new Guid("f028c2c5-facc-4109-8cfa-75b2b6620527"),
				CreatedInPackageId = new Guid("7a22b6a0-37cb-4535-8949-1111b2b1ad98")
			};
		}

		protected virtual EntitySchemaColumn CreateCanDeleteColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("2cda2c20-d48a-44d0-b266-5542730b1ad9"),
				Name = @"CanDelete",
				CreatedInSchemaUId = new Guid("f028c2c5-facc-4109-8cfa-75b2b6620527"),
				ModifiedInSchemaUId = new Guid("f028c2c5-facc-4109-8cfa-75b2b6620527"),
				CreatedInPackageId = new Guid("7a22b6a0-37cb-4535-8949-1111b2b1ad98")
			};
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("a72532ba-4755-4b2f-8079-c382ae6d0e9a"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("f028c2c5-facc-4109-8cfa-75b2b6620527"),
				ModifiedInSchemaUId = new Guid("f028c2c5-facc-4109-8cfa-75b2b6620527"),
				CreatedInPackageId = new Guid("7a22b6a0-37cb-4535-8949-1111b2b1ad98")
			};
		}

		protected virtual EntitySchemaColumn CreateSubjectSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("134c280f-f7a7-4ac5-beeb-4ab1ed9e4ff5"),
				Name = @"SubjectSchemaUId",
				CreatedInSchemaUId = new Guid("f028c2c5-facc-4109-8cfa-75b2b6620527"),
				ModifiedInSchemaUId = new Guid("f028c2c5-facc-4109-8cfa-75b2b6620527"),
				CreatedInPackageId = new Guid("7a22b6a0-37cb-4535-8949-1111b2b1ad98")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysEntitySchemaOperationRightEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysEntitySchemaOperationRightEventsProcessSchema() {
			var schema = new SysEntitySchemaOperationRightEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysEntitySchemaOperationRight(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysEntitySchemaOperationRight_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysEntitySchemaOperationRightSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysEntitySchemaOperationRightSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f028c2c5-facc-4109-8cfa-75b2b6620527"));
		}

		#endregion

	}

	#endregion

	#region Class: SysEntitySchemaOperationRight

	/// <summary>
	/// Operation permissions.
	/// </summary>
	public class SysEntitySchemaOperationRight : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysEntitySchemaOperationRight(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysEntitySchemaOperationRight";
		}

		public SysEntitySchemaOperationRight(SysEntitySchemaOperationRight source)
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

		private VwSysAdminUnit _sysAdminUnit;
		/// <summary>
		/// User/role.
		/// </summary>
		public VwSysAdminUnit SysAdminUnit {
			get {
				return _sysAdminUnit ??
					(_sysAdminUnit = LookupColumnEntities.GetEntity("SysAdminUnit") as VwSysAdminUnit);
			}
		}

		/// <summary>
		/// Read.
		/// </summary>
		public bool CanRead {
			get {
				return GetTypedColumnValue<bool>("CanRead");
			}
			set {
				SetColumnValue("CanRead", value);
			}
		}

		/// <summary>
		/// New.
		/// </summary>
		public bool CanAppend {
			get {
				return GetTypedColumnValue<bool>("CanAppend");
			}
			set {
				SetColumnValue("CanAppend", value);
			}
		}

		/// <summary>
		/// Edit.
		/// </summary>
		public bool CanEdit {
			get {
				return GetTypedColumnValue<bool>("CanEdit");
			}
			set {
				SetColumnValue("CanEdit", value);
			}
		}

		/// <summary>
		/// Delete.
		/// </summary>
		public bool CanDelete {
			get {
				return GetTypedColumnValue<bool>("CanDelete");
			}
			set {
				SetColumnValue("CanDelete", value);
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

		/// <summary>
		/// Object.
		/// </summary>
		public Guid SubjectSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("SubjectSchemaUId");
			}
			set {
				SetColumnValue("SubjectSchemaUId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysEntitySchemaOperationRight_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysEntitySchemaOperationRightDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysEntitySchemaOperationRightDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysEntitySchemaOperationRightInserted", e);
			Inserting += (s, e) => ThrowEvent("SysEntitySchemaOperationRightInserting", e);
			Saved += (s, e) => ThrowEvent("SysEntitySchemaOperationRightSaved", e);
			Saving += (s, e) => ThrowEvent("SysEntitySchemaOperationRightSaving", e);
			Validating += (s, e) => ThrowEvent("SysEntitySchemaOperationRightValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysEntitySchemaOperationRight(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysEntitySchemaOperationRight_BaseEventsProcess

	/// <exclude/>
	public partial class SysEntitySchemaOperationRight_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysEntitySchemaOperationRight
	{

		public SysEntitySchemaOperationRight_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysEntitySchemaOperationRight_BaseEventsProcess";
			SchemaUId = new Guid("f028c2c5-facc-4109-8cfa-75b2b6620527");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f028c2c5-facc-4109-8cfa-75b2b6620527");
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

	#region Class: SysEntitySchemaOperationRight_BaseEventsProcess

	/// <exclude/>
	public class SysEntitySchemaOperationRight_BaseEventsProcess : SysEntitySchemaOperationRight_BaseEventsProcess<SysEntitySchemaOperationRight>
	{

		public SysEntitySchemaOperationRight_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysEntitySchemaOperationRight_BaseEventsProcess

	public partial class SysEntitySchemaOperationRight_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysEntitySchemaOperationRightEventsProcessSchema

	/// <exclude/>
	public class SysEntitySchemaOperationRightEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysEntitySchemaOperationRightEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysEntitySchemaOperationRightEventsProcessSchema(SysEntitySchemaOperationRightEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysEntitySchemaOperationRight_BaseEventsProcess";
			UId = new Guid("4dde1672-7c72-4e06-b38d-71fa348b115c");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = Guid.Empty;
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
			return new SysEntitySchemaOperationRightEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4dde1672-7c72-4e06-b38d-71fa348b115c"));
		}

		#endregion

	}

	#endregion


	#region Class: SysEntitySchemaOperationRightEventsProcess

	/// <exclude/>
	public class SysEntitySchemaOperationRightEventsProcess : SysEntitySchemaOperationRight_BaseEventsProcess
	{

		public SysEntitySchemaOperationRightEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

