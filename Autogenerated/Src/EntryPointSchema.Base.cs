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

	#region Class: EntryPointSchema

	/// <exclude/>
	public class EntryPointSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public EntryPointSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EntryPointSchema(EntryPointSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EntryPointSchema(EntryPointSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e06571a7-f0b7-4768-a81c-aa27ee9a8d6c");
			RealUId = new Guid("e06571a7-f0b7-4768-a81c-aa27ee9a8d6c");
			Name = "EntryPoint";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("032ca095-8ea3-4c30-84d3-0f5af8c0f190")) == null) {
				Columns.Add(CreateSysProcessElementDataColumn());
			}
			if (Columns.FindByUId(new Guid("96fe0d37-dc0e-4ecd-8d67-12814012eb68")) == null) {
				Columns.Add(CreateEntitySchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("69ba4ecb-56d0-49bd-bfa7-789ff042bbb5")) == null) {
				Columns.Add(CreateEntityIdColumn());
			}
			if (Columns.FindByUId(new Guid("68c51ef9-4eb7-4919-92b4-428237e8bdb9")) == null) {
				Columns.Add(CreateIsActiveColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("e06571a7-f0b7-4768-a81c-aa27ee9a8d6c");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("e06571a7-f0b7-4768-a81c-aa27ee9a8d6c");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("e06571a7-f0b7-4768-a81c-aa27ee9a8d6c");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("e06571a7-f0b7-4768-a81c-aa27ee9a8d6c");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("e06571a7-f0b7-4768-a81c-aa27ee9a8d6c");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("e06571a7-f0b7-4768-a81c-aa27ee9a8d6c");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected virtual EntitySchemaColumn CreateSysProcessElementDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("032ca095-8ea3-4c30-84d3-0f5af8c0f190"),
				Name = @"SysProcessElementData",
				ReferenceSchemaUId = new Guid("a195aa99-8c5b-47e0-a9a6-9bac0ddd5bd0"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e06571a7-f0b7-4768-a81c-aa27ee9a8d6c"),
				ModifiedInSchemaUId = new Guid("e06571a7-f0b7-4768-a81c-aa27ee9a8d6c"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			};
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("96fe0d37-dc0e-4ecd-8d67-12814012eb68"),
				Name = @"EntitySchemaUId",
				CreatedInSchemaUId = new Guid("e06571a7-f0b7-4768-a81c-aa27ee9a8d6c"),
				ModifiedInSchemaUId = new Guid("e06571a7-f0b7-4768-a81c-aa27ee9a8d6c"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			};
		}

		protected virtual EntitySchemaColumn CreateEntityIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("69ba4ecb-56d0-49bd-bfa7-789ff042bbb5"),
				Name = @"EntityId",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e06571a7-f0b7-4768-a81c-aa27ee9a8d6c"),
				ModifiedInSchemaUId = new Guid("e06571a7-f0b7-4768-a81c-aa27ee9a8d6c"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			};
		}

		protected virtual EntitySchemaColumn CreateIsActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("68c51ef9-4eb7-4919-92b4-428237e8bdb9"),
				Name = @"IsActive",
				CreatedInSchemaUId = new Guid("e06571a7-f0b7-4768-a81c-aa27ee9a8d6c"),
				ModifiedInSchemaUId = new Guid("e06571a7-f0b7-4768-a81c-aa27ee9a8d6c"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateEntryPointEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateEntryPointEventsProcessSchema() {
			var schema = new EntryPointEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new EntryPoint(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EntryPoint_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EntryPointSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EntryPointSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e06571a7-f0b7-4768-a81c-aa27ee9a8d6c"));
		}

		#endregion

	}

	#endregion

	#region Class: EntryPoint

	/// <summary>
	/// Entry points.
	/// </summary>
	public class EntryPoint : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public EntryPoint(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EntryPoint";
		}

		public EntryPoint(EntryPoint source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysProcessElementDataId {
			get {
				return GetTypedColumnValue<Guid>("SysProcessElementDataId");
			}
			set {
				SetColumnValue("SysProcessElementDataId", value);
				_sysProcessElementData = null;
			}
		}

		private SysProcessElementData _sysProcessElementData;
		/// <summary>
		/// Process item.
		/// </summary>
		public SysProcessElementData SysProcessElementData {
			get {
				return _sysProcessElementData ??
					(_sysProcessElementData = LookupColumnEntities.GetEntity("SysProcessElementData") as SysProcessElementData);
			}
		}

		/// <summary>
		/// Binding object.
		/// </summary>
		public Guid EntitySchemaUId {
			get {
				return GetTypedColumnValue<Guid>("EntitySchemaUId");
			}
			set {
				SetColumnValue("EntitySchemaUId", value);
			}
		}

		/// <summary>
		/// Binding object instance.
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
		/// Active.
		/// </summary>
		public bool IsActive {
			get {
				return GetTypedColumnValue<bool>("IsActive");
			}
			set {
				SetColumnValue("IsActive", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EntryPoint_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("EntryPointDeleted", e);
			Inserting += (s, e) => ThrowEvent("EntryPointInserting", e);
			Validating += (s, e) => ThrowEvent("EntryPointValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EntryPoint(this);
		}

		#endregion

	}

	#endregion

	#region Class: EntryPoint_BaseEventsProcess

	/// <exclude/>
	public partial class EntryPoint_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : EntryPoint
	{

		public EntryPoint_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EntryPoint_BaseEventsProcess";
			SchemaUId = new Guid("e06571a7-f0b7-4768-a81c-aa27ee9a8d6c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e06571a7-f0b7-4768-a81c-aa27ee9a8d6c");
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

	#region Class: EntryPoint_BaseEventsProcess

	/// <exclude/>
	public class EntryPoint_BaseEventsProcess : EntryPoint_BaseEventsProcess<EntryPoint>
	{

		public EntryPoint_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EntryPoint_BaseEventsProcess

	public partial class EntryPoint_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: EntryPointEventsProcessSchema

	/// <exclude/>
	public class EntryPointEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public EntryPointEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public EntryPointEventsProcessSchema(EntryPointEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "EntryPoint_BaseEventsProcess";
			UId = new Guid("ae3e877d-f8d2-4c1c-a1f3-b38fa69ecce1");
			CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
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
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
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
			return new EntryPointEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ae3e877d-f8d2-4c1c-a1f3-b38fa69ecce1"));
		}

		#endregion

	}

	#endregion


	#region Class: EntryPointEventsProcess

	/// <exclude/>
	public class EntryPointEventsProcess : EntryPoint_BaseEventsProcess
	{

		public EntryPointEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

