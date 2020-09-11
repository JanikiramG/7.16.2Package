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

	#region Class: SysPrcActualVersionSchema

	/// <exclude/>
	public class SysPrcActualVersionSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysPrcActualVersionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysPrcActualVersionSchema(SysPrcActualVersionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysPrcActualVersionSchema(SysPrcActualVersionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8ae8036d-83a8-491c-ae1d-bf2f1b9ff2ee");
			RealUId = new Guid("8ae8036d-83a8-491c-ae1d-bf2f1b9ff2ee");
			Name = "SysPrcActualVersion";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3949d191-f356-45da-a437-95abb1839b71");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("2d01445a-bdd7-4d32-997d-f7d675a618ec")) == null) {
				Columns.Add(CreateRootVersionSchemaColumn());
			}
			if (Columns.FindByUId(new Guid("1e810c3d-f15c-4511-afc4-6e69f1e6c7a5")) == null) {
				Columns.Add(CreateActualVersionSchemaColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateRootVersionSchemaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2d01445a-bdd7-4d32-997d-f7d675a618ec"),
				Name = @"RootVersionSchema",
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("8ae8036d-83a8-491c-ae1d-bf2f1b9ff2ee"),
				ModifiedInSchemaUId = new Guid("8ae8036d-83a8-491c-ae1d-bf2f1b9ff2ee"),
				CreatedInPackageId = new Guid("3949d191-f356-45da-a437-95abb1839b71")
			};
		}

		protected virtual EntitySchemaColumn CreateActualVersionSchemaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1e810c3d-f15c-4511-afc4-6e69f1e6c7a5"),
				Name = @"ActualVersionSchema",
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8ae8036d-83a8-491c-ae1d-bf2f1b9ff2ee"),
				ModifiedInSchemaUId = new Guid("8ae8036d-83a8-491c-ae1d-bf2f1b9ff2ee"),
				CreatedInPackageId = new Guid("3949d191-f356-45da-a437-95abb1839b71")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysPrcActualVersionEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysPrcActualVersionEventsProcessSchema() {
			var schema = new SysPrcActualVersionEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysPrcActualVersion(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysPrcActualVersion_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysPrcActualVersionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysPrcActualVersionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8ae8036d-83a8-491c-ae1d-bf2f1b9ff2ee"));
		}

		#endregion

	}

	#endregion

	#region Class: SysPrcActualVersion

	/// <summary>
	/// Actual process version.
	/// </summary>
	public class SysPrcActualVersion : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysPrcActualVersion(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysPrcActualVersion";
		}

		public SysPrcActualVersion(SysPrcActualVersion source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid RootVersionSchemaId {
			get {
				return GetTypedColumnValue<Guid>("RootVersionSchemaId");
			}
			set {
				SetColumnValue("RootVersionSchemaId", value);
				_rootVersionSchema = null;
			}
		}

		/// <exclude/>
		public string RootVersionSchemaCaption {
			get {
				return GetTypedColumnValue<string>("RootVersionSchemaCaption");
			}
			set {
				SetColumnValue("RootVersionSchemaCaption", value);
				if (_rootVersionSchema != null) {
					_rootVersionSchema.Caption = value;
				}
			}
		}

		private SysSchema _rootVersionSchema;
		/// <summary>
		/// Root version.
		/// </summary>
		public SysSchema RootVersionSchema {
			get {
				return _rootVersionSchema ??
					(_rootVersionSchema = LookupColumnEntities.GetEntity("RootVersionSchema") as SysSchema);
			}
		}

		/// <exclude/>
		public Guid ActualVersionSchemaId {
			get {
				return GetTypedColumnValue<Guid>("ActualVersionSchemaId");
			}
			set {
				SetColumnValue("ActualVersionSchemaId", value);
				_actualVersionSchema = null;
			}
		}

		/// <exclude/>
		public string ActualVersionSchemaCaption {
			get {
				return GetTypedColumnValue<string>("ActualVersionSchemaCaption");
			}
			set {
				SetColumnValue("ActualVersionSchemaCaption", value);
				if (_actualVersionSchema != null) {
					_actualVersionSchema.Caption = value;
				}
			}
		}

		private SysSchema _actualVersionSchema;
		/// <summary>
		/// Actual version.
		/// </summary>
		public SysSchema ActualVersionSchema {
			get {
				return _actualVersionSchema ??
					(_actualVersionSchema = LookupColumnEntities.GetEntity("ActualVersionSchema") as SysSchema);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysPrcActualVersion_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysPrcActualVersionDeleted", e);
			Validating += (s, e) => ThrowEvent("SysPrcActualVersionValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysPrcActualVersion(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysPrcActualVersion_BaseEventsProcess

	/// <exclude/>
	public partial class SysPrcActualVersion_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysPrcActualVersion
	{

		public SysPrcActualVersion_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysPrcActualVersion_BaseEventsProcess";
			SchemaUId = new Guid("8ae8036d-83a8-491c-ae1d-bf2f1b9ff2ee");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8ae8036d-83a8-491c-ae1d-bf2f1b9ff2ee");
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

	#region Class: SysPrcActualVersion_BaseEventsProcess

	/// <exclude/>
	public class SysPrcActualVersion_BaseEventsProcess : SysPrcActualVersion_BaseEventsProcess<SysPrcActualVersion>
	{

		public SysPrcActualVersion_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysPrcActualVersion_BaseEventsProcess

	public partial class SysPrcActualVersion_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysPrcActualVersionEventsProcessSchema

	/// <exclude/>
	public class SysPrcActualVersionEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysPrcActualVersionEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysPrcActualVersionEventsProcessSchema(SysPrcActualVersionEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysPrcActualVersion_BaseEventsProcess";
			UId = new Guid("896663c0-9cc9-42da-878c-11b2607f633c");
			CreatedInPackageId = new Guid("3949d191-f356-45da-a437-95abb1839b71");
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
			return new SysPrcActualVersionEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("896663c0-9cc9-42da-878c-11b2607f633c"));
		}

		#endregion

	}

	#endregion


	#region Class: SysPrcActualVersionEventsProcess

	/// <exclude/>
	public class SysPrcActualVersionEventsProcess : SysPrcActualVersion_BaseEventsProcess
	{

		public SysPrcActualVersionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

