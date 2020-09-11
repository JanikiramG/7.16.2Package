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

	#region Class: SspPageDetailSchema

	/// <exclude/>
	public class SspPageDetailSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SspPageDetailSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SspPageDetailSchema(SspPageDetailSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SspPageDetailSchema(SspPageDetailSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8974e567-f0e1-4ce6-96f5-d663ca93cb07");
			RealUId = new Guid("8974e567-f0e1-4ce6-96f5-d663ca93cb07");
			Name = "SspPageDetail";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("479f70b4-9acf-4e9e-85c9-3a190e2b8f8d");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("f8cd1f5c-b6e0-4a37-88ee-05929d09b2e8")) == null) {
				Columns.Add(CreateCardSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("8f11220c-7647-4c8c-90b9-b79e03e8f6ee")) == null) {
				Columns.Add(CreateEntitySchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("3205952e-7126-45fa-b720-9cd99f7875ae")) == null) {
				Columns.Add(CreateSysDetailColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCardSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("f8cd1f5c-b6e0-4a37-88ee-05929d09b2e8"),
				Name = @"CardSchemaUId",
				CreatedInSchemaUId = new Guid("8974e567-f0e1-4ce6-96f5-d663ca93cb07"),
				ModifiedInSchemaUId = new Guid("8974e567-f0e1-4ce6-96f5-d663ca93cb07"),
				CreatedInPackageId = new Guid("479f70b4-9acf-4e9e-85c9-3a190e2b8f8d")
			};
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("8f11220c-7647-4c8c-90b9-b79e03e8f6ee"),
				Name = @"EntitySchemaUId",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8974e567-f0e1-4ce6-96f5-d663ca93cb07"),
				ModifiedInSchemaUId = new Guid("8974e567-f0e1-4ce6-96f5-d663ca93cb07"),
				CreatedInPackageId = new Guid("479f70b4-9acf-4e9e-85c9-3a190e2b8f8d")
			};
		}

		protected virtual EntitySchemaColumn CreateSysDetailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3205952e-7126-45fa-b720-9cd99f7875ae"),
				Name = @"SysDetail",
				ReferenceSchemaUId = new Guid("363c2008-c733-407d-9b01-9e6a7cd9a77a"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8974e567-f0e1-4ce6-96f5-d663ca93cb07"),
				ModifiedInSchemaUId = new Guid("8974e567-f0e1-4ce6-96f5-d663ca93cb07"),
				CreatedInPackageId = new Guid("479f70b4-9acf-4e9e-85c9-3a190e2b8f8d")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSspPageDetailEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSspPageDetailEventsProcessSchema() {
			var schema = new SspPageDetailEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SspPageDetail(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SspPageDetail_NUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SspPageDetailSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SspPageDetailSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8974e567-f0e1-4ce6-96f5-d663ca93cb07"));
		}

		#endregion

	}

	#endregion

	#region Class: SspPageDetail

	/// <summary>
	/// SspPageDetail.
	/// </summary>
	public class SspPageDetail : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SspPageDetail(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SspPageDetail";
		}

		public SspPageDetail(SspPageDetail source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// CardSchemaUId.
		/// </summary>
		public Guid CardSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("CardSchemaUId");
			}
			set {
				SetColumnValue("CardSchemaUId", value);
			}
		}

		/// <summary>
		/// EntitySchemaUId.
		/// </summary>
		public Guid EntitySchemaUId {
			get {
				return GetTypedColumnValue<Guid>("EntitySchemaUId");
			}
			set {
				SetColumnValue("EntitySchemaUId", value);
			}
		}

		/// <exclude/>
		public Guid SysDetailId {
			get {
				return GetTypedColumnValue<Guid>("SysDetailId");
			}
			set {
				SetColumnValue("SysDetailId", value);
				_sysDetail = null;
			}
		}

		/// <exclude/>
		public string SysDetailCaption {
			get {
				return GetTypedColumnValue<string>("SysDetailCaption");
			}
			set {
				SetColumnValue("SysDetailCaption", value);
				if (_sysDetail != null) {
					_sysDetail.Caption = value;
				}
			}
		}

		private SysDetail _sysDetail;
		/// <summary>
		/// SysDetail.
		/// </summary>
		public SysDetail SysDetail {
			get {
				return _sysDetail ??
					(_sysDetail = LookupColumnEntities.GetEntity("SysDetail") as SysDetail);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SspPageDetail_NUIEventsProcess(UserConnection);
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
			return new SspPageDetail(this);
		}

		#endregion

	}

	#endregion

	#region Class: SspPageDetail_NUIEventsProcess

	/// <exclude/>
	public partial class SspPageDetail_NUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SspPageDetail
	{

		public SspPageDetail_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SspPageDetail_NUIEventsProcess";
			SchemaUId = new Guid("8974e567-f0e1-4ce6-96f5-d663ca93cb07");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8974e567-f0e1-4ce6-96f5-d663ca93cb07");
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

	#region Class: SspPageDetail_NUIEventsProcess

	/// <exclude/>
	public class SspPageDetail_NUIEventsProcess : SspPageDetail_NUIEventsProcess<SspPageDetail>
	{

		public SspPageDetail_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SspPageDetail_NUIEventsProcess

	public partial class SspPageDetail_NUIEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SspPageDetailEventsProcessSchema

	/// <exclude/>
	public class SspPageDetailEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SspPageDetailEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SspPageDetailEventsProcessSchema(SspPageDetailEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SspPageDetail_NUIEventsProcess";
			UId = new Guid("363b496a-67e8-497f-8d00-235c47ccf340");
			CreatedInPackageId = new Guid("479f70b4-9acf-4e9e-85c9-3a190e2b8f8d");
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
			return new SspPageDetailEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("363b496a-67e8-497f-8d00-235c47ccf340"));
		}

		#endregion

	}

	#endregion


	#region Class: SspPageDetailEventsProcess

	/// <exclude/>
	public class SspPageDetailEventsProcess : SspPageDetail_NUIEventsProcess
	{

		public SspPageDetailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

