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

	#region Class: SysDetailSchema

	/// <exclude/>
	public class SysDetailSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysDetailSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysDetailSchema(SysDetailSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysDetailSchema(SysDetailSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("363c2008-c733-407d-9b01-9e6a7cd9a77a");
			RealUId = new Guid("363c2008-c733-407d-9b01-9e6a7cd9a77a");
			Name = "SysDetail";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e63e45b4-0bf6-4e6f-9a89-2f7851e26fd2");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateCaptionColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("8585929c-62ae-4673-ae8d-bb37f87e5144")) == null) {
				Columns.Add(CreateDetailSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("631e7238-2751-4a21-b6d6-9f1ac0c84f95")) == null) {
				Columns.Add(CreateEntitySchemaUIdColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("363c2008-c733-407d-9b01-9e6a7cd9a77a");
			column.CreatedInPackageId = new Guid("e63e45b4-0bf6-4e6f-9a89-2f7851e26fd2");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("363c2008-c733-407d-9b01-9e6a7cd9a77a");
			column.CreatedInPackageId = new Guid("e63e45b4-0bf6-4e6f-9a89-2f7851e26fd2");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("363c2008-c733-407d-9b01-9e6a7cd9a77a");
			column.CreatedInPackageId = new Guid("e63e45b4-0bf6-4e6f-9a89-2f7851e26fd2");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("363c2008-c733-407d-9b01-9e6a7cd9a77a");
			column.CreatedInPackageId = new Guid("e63e45b4-0bf6-4e6f-9a89-2f7851e26fd2");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("363c2008-c733-407d-9b01-9e6a7cd9a77a");
			column.CreatedInPackageId = new Guid("e63e45b4-0bf6-4e6f-9a89-2f7851e26fd2");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("363c2008-c733-407d-9b01-9e6a7cd9a77a");
			column.CreatedInPackageId = new Guid("e63e45b4-0bf6-4e6f-9a89-2f7851e26fd2");
			return column;
		}

		protected virtual EntitySchemaColumn CreateCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("49ad8ee2-65a6-4cdd-b8f6-85c2f10a54dc"),
				Name = @"Caption",
				CreatedInSchemaUId = new Guid("363c2008-c733-407d-9b01-9e6a7cd9a77a"),
				ModifiedInSchemaUId = new Guid("363c2008-c733-407d-9b01-9e6a7cd9a77a"),
				CreatedInPackageId = new Guid("e63e45b4-0bf6-4e6f-9a89-2f7851e26fd2"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateDetailSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("8585929c-62ae-4673-ae8d-bb37f87e5144"),
				Name = @"DetailSchemaUId",
				CreatedInSchemaUId = new Guid("363c2008-c733-407d-9b01-9e6a7cd9a77a"),
				ModifiedInSchemaUId = new Guid("363c2008-c733-407d-9b01-9e6a7cd9a77a"),
				CreatedInPackageId = new Guid("e63e45b4-0bf6-4e6f-9a89-2f7851e26fd2")
			};
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("631e7238-2751-4a21-b6d6-9f1ac0c84f95"),
				Name = @"EntitySchemaUId",
				CreatedInSchemaUId = new Guid("363c2008-c733-407d-9b01-9e6a7cd9a77a"),
				ModifiedInSchemaUId = new Guid("363c2008-c733-407d-9b01-9e6a7cd9a77a"),
				CreatedInPackageId = new Guid("e63e45b4-0bf6-4e6f-9a89-2f7851e26fd2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysDetailEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysDetailEventsProcessSchema() {
			var schema = new SysDetailEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysDetail(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysDetail_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysDetailSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysDetailSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("363c2008-c733-407d-9b01-9e6a7cd9a77a"));
		}

		#endregion

	}

	#endregion

	#region Class: SysDetail

	/// <summary>
	/// Details lookup.
	/// </summary>
	public class SysDetail : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysDetail(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysDetail";
		}

		public SysDetail(SysDetail source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Title.
		/// </summary>
		public string Caption {
			get {
				return GetTypedColumnValue<string>("Caption");
			}
			set {
				SetColumnValue("Caption", value);
			}
		}

		/// <summary>
		/// Detail schema.
		/// </summary>
		public Guid DetailSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("DetailSchemaUId");
			}
			set {
				SetColumnValue("DetailSchemaUId", value);
			}
		}

		/// <summary>
		/// Object schema.
		/// </summary>
		public Guid EntitySchemaUId {
			get {
				return GetTypedColumnValue<Guid>("EntitySchemaUId");
			}
			set {
				SetColumnValue("EntitySchemaUId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysDetail_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysDetailDeleted", e);
			Inserting += (s, e) => ThrowEvent("SysDetailInserting", e);
			Validating += (s, e) => ThrowEvent("SysDetailValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysDetail(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysDetail_BaseEventsProcess

	/// <exclude/>
	public partial class SysDetail_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysDetail
	{

		public SysDetail_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysDetail_BaseEventsProcess";
			SchemaUId = new Guid("363c2008-c733-407d-9b01-9e6a7cd9a77a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("363c2008-c733-407d-9b01-9e6a7cd9a77a");
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

	#region Class: SysDetail_BaseEventsProcess

	/// <exclude/>
	public class SysDetail_BaseEventsProcess : SysDetail_BaseEventsProcess<SysDetail>
	{

		public SysDetail_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysDetail_BaseEventsProcess

	public partial class SysDetail_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysDetailEventsProcessSchema

	/// <exclude/>
	public class SysDetailEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysDetailEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysDetailEventsProcessSchema(SysDetailEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysDetail_BaseEventsProcess";
			UId = new Guid("fa8ef2c3-6362-4e9a-bf3a-040904451403");
			CreatedInPackageId = new Guid("e63e45b4-0bf6-4e6f-9a89-2f7851e26fd2");
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
				CreatedInPackageId = new Guid("e63e45b4-0bf6-4e6f-9a89-2f7851e26fd2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("e63e45b4-0bf6-4e6f-9a89-2f7851e26fd2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("e63e45b4-0bf6-4e6f-9a89-2f7851e26fd2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("e63e45b4-0bf6-4e6f-9a89-2f7851e26fd2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("e63e45b4-0bf6-4e6f-9a89-2f7851e26fd2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e63e45b4-0bf6-4e6f-9a89-2f7851e26fd2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e63e45b4-0bf6-4e6f-9a89-2f7851e26fd2")
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
			return new SysDetailEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fa8ef2c3-6362-4e9a-bf3a-040904451403"));
		}

		#endregion

	}

	#endregion


	#region Class: SysDetailEventsProcess

	/// <exclude/>
	public class SysDetailEventsProcess : SysDetail_BaseEventsProcess
	{

		public SysDetailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

