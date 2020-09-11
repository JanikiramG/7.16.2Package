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

	#region Class: ContextElementSchema

	/// <exclude/>
	public class ContextElementSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ContextElementSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContextElementSchema(ContextElementSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContextElementSchema(ContextElementSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("de1889aa-69c4-4a40-b06e-88d03365e9d4");
			RealUId = new Guid("de1889aa-69c4-4a40-b06e-88d03365e9d4");
			Name = "ContextElement";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("14a29563-3c13-443c-a7aa-8d0c90d831c2");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("baf2be39-2fd5-487e-8864-be2cdf31791d")) == null) {
				Columns.Add(CreateClientUnitSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("5cf57de2-8f47-4d48-90ea-07414707b694")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("cd6ce280-8f61-4f67-90e4-6b6ed9da6d0f")) == null) {
				Columns.Add(CreateIsDefaultColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("de1889aa-69c4-4a40-b06e-88d03365e9d4");
			column.CreatedInPackageId = new Guid("9cb36bb0-ef94-4bd9-b530-e0e0d5d64a20");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("de1889aa-69c4-4a40-b06e-88d03365e9d4");
			column.CreatedInPackageId = new Guid("9cb36bb0-ef94-4bd9-b530-e0e0d5d64a20");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("de1889aa-69c4-4a40-b06e-88d03365e9d4");
			column.CreatedInPackageId = new Guid("9cb36bb0-ef94-4bd9-b530-e0e0d5d64a20");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("de1889aa-69c4-4a40-b06e-88d03365e9d4");
			column.CreatedInPackageId = new Guid("9cb36bb0-ef94-4bd9-b530-e0e0d5d64a20");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("de1889aa-69c4-4a40-b06e-88d03365e9d4");
			column.CreatedInPackageId = new Guid("9cb36bb0-ef94-4bd9-b530-e0e0d5d64a20");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("de1889aa-69c4-4a40-b06e-88d03365e9d4");
			column.CreatedInPackageId = new Guid("9cb36bb0-ef94-4bd9-b530-e0e0d5d64a20");
			return column;
		}

		protected virtual EntitySchemaColumn CreateClientUnitSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("baf2be39-2fd5-487e-8864-be2cdf31791d"),
				Name = @"ClientUnitSchemaUId",
				CreatedInSchemaUId = new Guid("de1889aa-69c4-4a40-b06e-88d03365e9d4"),
				ModifiedInSchemaUId = new Guid("de1889aa-69c4-4a40-b06e-88d03365e9d4"),
				CreatedInPackageId = new Guid("9cb36bb0-ef94-4bd9-b530-e0e0d5d64a20")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("1960723b-09ff-462a-adad-d8fd2195ac69"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("de1889aa-69c4-4a40-b06e-88d03365e9d4"),
				ModifiedInSchemaUId = new Guid("de1889aa-69c4-4a40-b06e-88d03365e9d4"),
				CreatedInPackageId = new Guid("9cb36bb0-ef94-4bd9-b530-e0e0d5d64a20"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("5cf57de2-8f47-4d48-90ea-07414707b694"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("de1889aa-69c4-4a40-b06e-88d03365e9d4"),
				ModifiedInSchemaUId = new Guid("de1889aa-69c4-4a40-b06e-88d03365e9d4"),
				CreatedInPackageId = new Guid("9cb36bb0-ef94-4bd9-b530-e0e0d5d64a20"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateIsDefaultColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("cd6ce280-8f61-4f67-90e4-6b6ed9da6d0f"),
				Name = @"IsDefault",
				CreatedInSchemaUId = new Guid("de1889aa-69c4-4a40-b06e-88d03365e9d4"),
				ModifiedInSchemaUId = new Guid("de1889aa-69c4-4a40-b06e-88d03365e9d4"),
				CreatedInPackageId = new Guid("14a29563-3c13-443c-a7aa-8d0c90d831c2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateContextElementEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateContextElementEventsProcessSchema() {
			var schema = new ContextElementEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ContextElement(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContextElement_ProcessDesignerEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContextElementSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContextElementSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("de1889aa-69c4-4a40-b06e-88d03365e9d4"));
		}

		#endregion

	}

	#endregion

	#region Class: ContextElement

	/// <summary>
	/// Context item.
	/// </summary>
	public class ContextElement : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ContextElement(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContextElement";
		}

		public ContextElement(ContextElement source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Widget module client schema UId.
		/// </summary>
		public Guid ClientUnitSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("ClientUnitSchemaUId");
			}
			set {
				SetColumnValue("ClientUnitSchemaUId", value);
			}
		}

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <summary>
		/// Description.
		/// </summary>
		public string Description {
			get {
				return GetTypedColumnValue<string>("Description");
			}
			set {
				SetColumnValue("Description", value);
			}
		}

		/// <summary>
		/// Show by default.
		/// </summary>
		public bool IsDefault {
			get {
				return GetTypedColumnValue<bool>("IsDefault");
			}
			set {
				SetColumnValue("IsDefault", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContextElement_ProcessDesignerEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContextElementDeleted", e);
			Inserting += (s, e) => ThrowEvent("ContextElementInserting", e);
			Validating += (s, e) => ThrowEvent("ContextElementValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContextElement(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContextElement_ProcessDesignerEventsProcess

	/// <exclude/>
	public partial class ContextElement_ProcessDesignerEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ContextElement
	{

		public ContextElement_ProcessDesignerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContextElement_ProcessDesignerEventsProcess";
			SchemaUId = new Guid("de1889aa-69c4-4a40-b06e-88d03365e9d4");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("de1889aa-69c4-4a40-b06e-88d03365e9d4");
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

	#region Class: ContextElement_ProcessDesignerEventsProcess

	/// <exclude/>
	public class ContextElement_ProcessDesignerEventsProcess : ContextElement_ProcessDesignerEventsProcess<ContextElement>
	{

		public ContextElement_ProcessDesignerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContextElement_ProcessDesignerEventsProcess

	public partial class ContextElement_ProcessDesignerEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ContextElementEventsProcessSchema

	/// <exclude/>
	public class ContextElementEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ContextElementEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ContextElementEventsProcessSchema(ContextElementEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ContextElement_ProcessDesignerEventsProcess";
			UId = new Guid("003e77e2-e7b5-4a04-a846-2870cbbb0259");
			CreatedInPackageId = new Guid("14a29563-3c13-443c-a7aa-8d0c90d831c2");
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
				CreatedInPackageId = new Guid("9cb36bb0-ef94-4bd9-b530-e0e0d5d64a20")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("9cb36bb0-ef94-4bd9-b530-e0e0d5d64a20")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("9cb36bb0-ef94-4bd9-b530-e0e0d5d64a20")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("9cb36bb0-ef94-4bd9-b530-e0e0d5d64a20")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("9cb36bb0-ef94-4bd9-b530-e0e0d5d64a20")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("9cb36bb0-ef94-4bd9-b530-e0e0d5d64a20")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("9cb36bb0-ef94-4bd9-b530-e0e0d5d64a20")
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
			return new ContextElementEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("003e77e2-e7b5-4a04-a846-2870cbbb0259"));
		}

		#endregion

	}

	#endregion


	#region Class: ContextElementEventsProcess

	/// <exclude/>
	public class ContextElementEventsProcess : ContextElement_ProcessDesignerEventsProcess
	{

		public ContextElementEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

