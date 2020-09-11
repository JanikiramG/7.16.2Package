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

	#region Class: SysSSPEntitySchemaAccessListSchema

	/// <exclude/>
	public class SysSSPEntitySchemaAccessListSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysSSPEntitySchemaAccessListSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysSSPEntitySchemaAccessListSchema(SysSSPEntitySchemaAccessListSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysSSPEntitySchemaAccessListSchema(SysSSPEntitySchemaAccessListSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3f07dee2-b2d5-4a28-9a59-1ef7d6fa85ab");
			RealUId = new Guid("3f07dee2-b2d5-4a28-9a59-1ef7d6fa85ab");
			Name = "SysSSPEntitySchemaAccessList";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("0bea0088-e6a2-4f3a-b02e-e01a15923e73");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("8d2d0d7c-7a7d-4bb1-ba25-e10883e91a1c")) == null) {
				Columns.Add(CreateEntitySchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("e0aa088b-0b83-44e5-b8c8-23c8c56aa362")) == null) {
				Columns.Add(CreateIsPresetColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("3f07dee2-b2d5-4a28-9a59-1ef7d6fa85ab");
			column.CreatedInPackageId = new Guid("0bea0088-e6a2-4f3a-b02e-e01a15923e73");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("3f07dee2-b2d5-4a28-9a59-1ef7d6fa85ab");
			column.CreatedInPackageId = new Guid("0bea0088-e6a2-4f3a-b02e-e01a15923e73");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("3f07dee2-b2d5-4a28-9a59-1ef7d6fa85ab");
			column.CreatedInPackageId = new Guid("0bea0088-e6a2-4f3a-b02e-e01a15923e73");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("3f07dee2-b2d5-4a28-9a59-1ef7d6fa85ab");
			column.CreatedInPackageId = new Guid("0bea0088-e6a2-4f3a-b02e-e01a15923e73");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("3f07dee2-b2d5-4a28-9a59-1ef7d6fa85ab");
			column.CreatedInPackageId = new Guid("0bea0088-e6a2-4f3a-b02e-e01a15923e73");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("3f07dee2-b2d5-4a28-9a59-1ef7d6fa85ab");
			column.CreatedInPackageId = new Guid("0bea0088-e6a2-4f3a-b02e-e01a15923e73");
			return column;
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("8d2d0d7c-7a7d-4bb1-ba25-e10883e91a1c"),
				Name = @"EntitySchemaUId",
				CreatedInSchemaUId = new Guid("3f07dee2-b2d5-4a28-9a59-1ef7d6fa85ab"),
				ModifiedInSchemaUId = new Guid("3f07dee2-b2d5-4a28-9a59-1ef7d6fa85ab"),
				CreatedInPackageId = new Guid("0bea0088-e6a2-4f3a-b02e-e01a15923e73")
			};
		}

		protected virtual EntitySchemaColumn CreateIsPresetColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("e0aa088b-0b83-44e5-b8c8-23c8c56aa362"),
				Name = @"IsPreset",
				CreatedInSchemaUId = new Guid("3f07dee2-b2d5-4a28-9a59-1ef7d6fa85ab"),
				ModifiedInSchemaUId = new Guid("3f07dee2-b2d5-4a28-9a59-1ef7d6fa85ab"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysSSPEntitySchemaAccessListEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysSSPEntitySchemaAccessListEventsProcessSchema() {
			var schema = new SysSSPEntitySchemaAccessListEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysSSPEntitySchemaAccessList(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysSSPEntitySchemaAccessList_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysSSPEntitySchemaAccessListSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysSSPEntitySchemaAccessListSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3f07dee2-b2d5-4a28-9a59-1ef7d6fa85ab"));
		}

		#endregion

	}

	#endregion

	#region Class: SysSSPEntitySchemaAccessList

	/// <summary>
	/// List of objects available for portal users.
	/// </summary>
	public class SysSSPEntitySchemaAccessList : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysSSPEntitySchemaAccessList(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysSSPEntitySchemaAccessList";
		}

		public SysSSPEntitySchemaAccessList(SysSSPEntitySchemaAccessList source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Object Id.
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
		/// Preset object.
		/// </summary>
		public bool IsPreset {
			get {
				return GetTypedColumnValue<bool>("IsPreset");
			}
			set {
				SetColumnValue("IsPreset", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysSSPEntitySchemaAccessList_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysSSPEntitySchemaAccessListDeleted", e);
			Inserting += (s, e) => ThrowEvent("SysSSPEntitySchemaAccessListInserting", e);
			Validating += (s, e) => ThrowEvent("SysSSPEntitySchemaAccessListValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysSSPEntitySchemaAccessList(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysSSPEntitySchemaAccessList_BaseEventsProcess

	/// <exclude/>
	public partial class SysSSPEntitySchemaAccessList_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysSSPEntitySchemaAccessList
	{

		public SysSSPEntitySchemaAccessList_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysSSPEntitySchemaAccessList_BaseEventsProcess";
			SchemaUId = new Guid("3f07dee2-b2d5-4a28-9a59-1ef7d6fa85ab");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3f07dee2-b2d5-4a28-9a59-1ef7d6fa85ab");
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

	#region Class: SysSSPEntitySchemaAccessList_BaseEventsProcess

	/// <exclude/>
	public class SysSSPEntitySchemaAccessList_BaseEventsProcess : SysSSPEntitySchemaAccessList_BaseEventsProcess<SysSSPEntitySchemaAccessList>
	{

		public SysSSPEntitySchemaAccessList_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysSSPEntitySchemaAccessList_BaseEventsProcess

	public partial class SysSSPEntitySchemaAccessList_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysSSPEntitySchemaAccessListEventsProcessSchema

	/// <exclude/>
	public class SysSSPEntitySchemaAccessListEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysSSPEntitySchemaAccessListEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysSSPEntitySchemaAccessListEventsProcessSchema(SysSSPEntitySchemaAccessListEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysSSPEntitySchemaAccessList_BaseEventsProcess";
			UId = new Guid("eee587b1-8246-4a99-ae24-27a064ce2d88");
			CreatedInPackageId = new Guid("0bea0088-e6a2-4f3a-b02e-e01a15923e73");
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
				CreatedInPackageId = new Guid("0bea0088-e6a2-4f3a-b02e-e01a15923e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("0bea0088-e6a2-4f3a-b02e-e01a15923e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("0bea0088-e6a2-4f3a-b02e-e01a15923e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("0bea0088-e6a2-4f3a-b02e-e01a15923e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("0bea0088-e6a2-4f3a-b02e-e01a15923e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("0bea0088-e6a2-4f3a-b02e-e01a15923e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("0bea0088-e6a2-4f3a-b02e-e01a15923e73")
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
			return new SysSSPEntitySchemaAccessListEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eee587b1-8246-4a99-ae24-27a064ce2d88"));
		}

		#endregion

	}

	#endregion


	#region Class: SysSSPEntitySchemaAccessListEventsProcess

	/// <exclude/>
	public class SysSSPEntitySchemaAccessListEventsProcess : SysSSPEntitySchemaAccessList_BaseEventsProcess
	{

		public SysSSPEntitySchemaAccessListEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

