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

	#region Class: SysPrcActivityLinksSchema

	/// <exclude/>
	public class SysPrcActivityLinksSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysPrcActivityLinksSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysPrcActivityLinksSchema(SysPrcActivityLinksSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysPrcActivityLinksSchema(SysPrcActivityLinksSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("85a55635-eb65-4c32-a415-b95a05b510b1");
			RealUId = new Guid("85a55635-eb65-4c32-a415-b95a05b510b1");
			Name = "SysPrcActivityLinks";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f909d548-ea0a-4163-99d5-5d01014acefb");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateActivityColumnNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("c8fa17ce-92b8-4dcb-a5bb-f68ace90f826")) == null) {
				Columns.Add(CreateActivityColumnIdColumn());
			}
			if (Columns.FindByUId(new Guid("3bdb0a72-1eb5-445a-a9bc-0d2151ff756d")) == null) {
				Columns.Add(CreatePositionColumn());
			}
			if (Columns.FindByUId(new Guid("e1669a67-6399-4fd2-a514-704497a88dce")) == null) {
				Columns.Add(CreateIsActiveColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("85a55635-eb65-4c32-a415-b95a05b510b1");
			column.CreatedInPackageId = new Guid("f909d548-ea0a-4163-99d5-5d01014acefb");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("85a55635-eb65-4c32-a415-b95a05b510b1");
			column.CreatedInPackageId = new Guid("f909d548-ea0a-4163-99d5-5d01014acefb");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("85a55635-eb65-4c32-a415-b95a05b510b1");
			column.CreatedInPackageId = new Guid("f909d548-ea0a-4163-99d5-5d01014acefb");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("85a55635-eb65-4c32-a415-b95a05b510b1");
			column.CreatedInPackageId = new Guid("f909d548-ea0a-4163-99d5-5d01014acefb");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("85a55635-eb65-4c32-a415-b95a05b510b1");
			column.CreatedInPackageId = new Guid("f909d548-ea0a-4163-99d5-5d01014acefb");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("85a55635-eb65-4c32-a415-b95a05b510b1");
			column.CreatedInPackageId = new Guid("f909d548-ea0a-4163-99d5-5d01014acefb");
			return column;
		}

		protected virtual EntitySchemaColumn CreateActivityColumnIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("c8fa17ce-92b8-4dcb-a5bb-f68ace90f826"),
				Name = @"ActivityColumnId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("85a55635-eb65-4c32-a415-b95a05b510b1"),
				ModifiedInSchemaUId = new Guid("85a55635-eb65-4c32-a415-b95a05b510b1"),
				CreatedInPackageId = new Guid("f909d548-ea0a-4163-99d5-5d01014acefb")
			};
		}

		protected virtual EntitySchemaColumn CreateActivityColumnNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("6cbbfb0b-8a52-46a5-ac40-61fca4017949"),
				Name = @"ActivityColumnName",
				CreatedInSchemaUId = new Guid("85a55635-eb65-4c32-a415-b95a05b510b1"),
				ModifiedInSchemaUId = new Guid("85a55635-eb65-4c32-a415-b95a05b510b1"),
				CreatedInPackageId = new Guid("f909d548-ea0a-4163-99d5-5d01014acefb")
			};
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("3bdb0a72-1eb5-445a-a9bc-0d2151ff756d"),
				Name = @"Position",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("85a55635-eb65-4c32-a415-b95a05b510b1"),
				ModifiedInSchemaUId = new Guid("85a55635-eb65-4c32-a415-b95a05b510b1"),
				CreatedInPackageId = new Guid("f909d548-ea0a-4163-99d5-5d01014acefb")
			};
		}

		protected virtual EntitySchemaColumn CreateIsActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("e1669a67-6399-4fd2-a514-704497a88dce"),
				Name = @"IsActive",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("85a55635-eb65-4c32-a415-b95a05b510b1"),
				ModifiedInSchemaUId = new Guid("85a55635-eb65-4c32-a415-b95a05b510b1"),
				CreatedInPackageId = new Guid("f909d548-ea0a-4163-99d5-5d01014acefb")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysPrcActivityLinksEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysPrcActivityLinksEventsProcessSchema() {
			var schema = new SysPrcActivityLinksEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysPrcActivityLinks(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysPrcActivityLinks_ProcessDesignerEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysPrcActivityLinksSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysPrcActivityLinksSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("85a55635-eb65-4c32-a415-b95a05b510b1"));
		}

		#endregion

	}

	#endregion

	#region Class: SysPrcActivityLinks

	/// <summary>
	/// Connection fields for activity process item.
	/// </summary>
	public class SysPrcActivityLinks : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysPrcActivityLinks(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysPrcActivityLinks";
		}

		public SysPrcActivityLinks(SysPrcActivityLinks source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Activity column Id.
		/// </summary>
		public Guid ActivityColumnId {
			get {
				return GetTypedColumnValue<Guid>("ActivityColumnId");
			}
			set {
				SetColumnValue("ActivityColumnId", value);
			}
		}

		/// <summary>
		/// Activity column.
		/// </summary>
		public string ActivityColumnName {
			get {
				return GetTypedColumnValue<string>("ActivityColumnName");
			}
			set {
				SetColumnValue("ActivityColumnName", value);
			}
		}

		/// <summary>
		/// Number.
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
			var process = new SysPrcActivityLinks_ProcessDesignerEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysPrcActivityLinksDeleted", e);
			Inserting += (s, e) => ThrowEvent("SysPrcActivityLinksInserting", e);
			Validating += (s, e) => ThrowEvent("SysPrcActivityLinksValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysPrcActivityLinks(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysPrcActivityLinks_ProcessDesignerEventsProcess

	/// <exclude/>
	public partial class SysPrcActivityLinks_ProcessDesignerEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysPrcActivityLinks
	{

		public SysPrcActivityLinks_ProcessDesignerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysPrcActivityLinks_ProcessDesignerEventsProcess";
			SchemaUId = new Guid("85a55635-eb65-4c32-a415-b95a05b510b1");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("85a55635-eb65-4c32-a415-b95a05b510b1");
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

	#region Class: SysPrcActivityLinks_ProcessDesignerEventsProcess

	/// <exclude/>
	public class SysPrcActivityLinks_ProcessDesignerEventsProcess : SysPrcActivityLinks_ProcessDesignerEventsProcess<SysPrcActivityLinks>
	{

		public SysPrcActivityLinks_ProcessDesignerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysPrcActivityLinks_ProcessDesignerEventsProcess

	public partial class SysPrcActivityLinks_ProcessDesignerEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysPrcActivityLinksEventsProcessSchema

	/// <exclude/>
	public class SysPrcActivityLinksEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysPrcActivityLinksEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysPrcActivityLinksEventsProcessSchema(SysPrcActivityLinksEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysPrcActivityLinks_ProcessDesignerEventsProcess";
			UId = new Guid("b71e5096-a7b2-47c1-a3cb-6ac4cfa4d935");
			CreatedInPackageId = new Guid("f909d548-ea0a-4163-99d5-5d01014acefb");
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
				CreatedInPackageId = new Guid("f909d548-ea0a-4163-99d5-5d01014acefb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("f909d548-ea0a-4163-99d5-5d01014acefb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("f909d548-ea0a-4163-99d5-5d01014acefb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("f909d548-ea0a-4163-99d5-5d01014acefb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("f909d548-ea0a-4163-99d5-5d01014acefb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("f909d548-ea0a-4163-99d5-5d01014acefb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("f909d548-ea0a-4163-99d5-5d01014acefb")
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
			return new SysPrcActivityLinksEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b71e5096-a7b2-47c1-a3cb-6ac4cfa4d935"));
		}

		#endregion

	}

	#endregion


	#region Class: SysPrcActivityLinksEventsProcess

	/// <exclude/>
	public class SysPrcActivityLinksEventsProcess : SysPrcActivityLinks_ProcessDesignerEventsProcess
	{

		public SysPrcActivityLinksEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

