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

	#region Class: SyncErrorHandlerSchema

	/// <exclude/>
	public class SyncErrorHandlerSchema : Terrasoft.Configuration.BaseCodeLookupSchema
	{

		#region Constructors: Public

		public SyncErrorHandlerSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SyncErrorHandlerSchema(SyncErrorHandlerSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SyncErrorHandlerSchema(SyncErrorHandlerSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b0d04bcc-80ac-4f23-b266-580d0578a3b0");
			RealUId = new Guid("b0d04bcc-80ac-4f23-b266-580d0578a3b0");
			Name = "SyncErrorHandler";
			ParentSchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("09346b97-c61d-4e37-8edf-cb80bd14a948")) == null) {
				Columns.Add(CreateExceptionClassColumn());
			}
			if (Columns.FindByUId(new Guid("1a34508d-0d95-4a46-bfae-9f61278bddea")) == null) {
				Columns.Add(CreateMessageFilterColumn());
			}
			if (Columns.FindByUId(new Guid("82832c73-4117-4f13-bb56-93cbb2887622")) == null) {
				Columns.Add(CreateRetryCountColumn());
			}
			if (Columns.FindByUId(new Guid("bb874d17-d87f-4259-aec8-242ab6c71a4a")) == null) {
				Columns.Add(CreateErrorCodeColumn());
			}
			if (Columns.FindByUId(new Guid("61d1fa8b-fa3d-4bd4-9362-d06041ea2732")) == null) {
				Columns.Add(CreateNotStopSyncingColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateExceptionClassColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("09346b97-c61d-4e37-8edf-cb80bd14a948"),
				Name = @"ExceptionClass",
				CreatedInSchemaUId = new Guid("b0d04bcc-80ac-4f23-b266-580d0578a3b0"),
				ModifiedInSchemaUId = new Guid("b0d04bcc-80ac-4f23-b266-580d0578a3b0"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateMessageFilterColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("1a34508d-0d95-4a46-bfae-9f61278bddea"),
				Name = @"MessageFilter",
				CreatedInSchemaUId = new Guid("b0d04bcc-80ac-4f23-b266-580d0578a3b0"),
				ModifiedInSchemaUId = new Guid("b0d04bcc-80ac-4f23-b266-580d0578a3b0"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateRetryCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("82832c73-4117-4f13-bb56-93cbb2887622"),
				Name = @"RetryCount",
				CreatedInSchemaUId = new Guid("b0d04bcc-80ac-4f23-b266-580d0578a3b0"),
				ModifiedInSchemaUId = new Guid("b0d04bcc-80ac-4f23-b266-580d0578a3b0"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateErrorCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("bb874d17-d87f-4259-aec8-242ab6c71a4a"),
				Name = @"ErrorCode",
				ReferenceSchemaUId = new Guid("ff5ba9c1-ee5d-4485-b6b4-da2865a0508d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("b0d04bcc-80ac-4f23-b266-580d0578a3b0"),
				ModifiedInSchemaUId = new Guid("b0d04bcc-80ac-4f23-b266-580d0578a3b0"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateNotStopSyncingColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("61d1fa8b-fa3d-4bd4-9362-d06041ea2732"),
				Name = @"NotStopSyncing",
				CreatedInSchemaUId = new Guid("b0d04bcc-80ac-4f23-b266-580d0578a3b0"),
				ModifiedInSchemaUId = new Guid("b0d04bcc-80ac-4f23-b266-580d0578a3b0"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSyncErrorHandlerEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSyncErrorHandlerEventsProcessSchema() {
			var schema = new SyncErrorHandlerEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SyncErrorHandler(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SyncErrorHandler_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SyncErrorHandlerSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SyncErrorHandlerSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b0d04bcc-80ac-4f23-b266-580d0578a3b0"));
		}

		#endregion

	}

	#endregion

	#region Class: SyncErrorHandler

	/// <summary>
	/// Synchronization error handler.
	/// </summary>
	public class SyncErrorHandler : Terrasoft.Configuration.BaseCodeLookup
	{

		#region Constructors: Public

		public SyncErrorHandler(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SyncErrorHandler";
		}

		public SyncErrorHandler(SyncErrorHandler source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Exception class name.
		/// </summary>
		public string ExceptionClass {
			get {
				return GetTypedColumnValue<string>("ExceptionClass");
			}
			set {
				SetColumnValue("ExceptionClass", value);
			}
		}

		/// <summary>
		/// Exception message filter.
		/// </summary>
		public string MessageFilter {
			get {
				return GetTypedColumnValue<string>("MessageFilter");
			}
			set {
				SetColumnValue("MessageFilter", value);
			}
		}

		/// <summary>
		/// Synchronization retry attempts count.
		/// </summary>
		public int RetryCount {
			get {
				return GetTypedColumnValue<int>("RetryCount");
			}
			set {
				SetColumnValue("RetryCount", value);
			}
		}

		/// <exclude/>
		public Guid ErrorCodeId {
			get {
				return GetTypedColumnValue<Guid>("ErrorCodeId");
			}
			set {
				SetColumnValue("ErrorCodeId", value);
				_errorCode = null;
			}
		}

		/// <exclude/>
		public string ErrorCodeName {
			get {
				return GetTypedColumnValue<string>("ErrorCodeName");
			}
			set {
				SetColumnValue("ErrorCodeName", value);
				if (_errorCode != null) {
					_errorCode.Name = value;
				}
			}
		}

		private SyncErrorMessage _errorCode;
		/// <summary>
		/// Error code identifier.
		/// </summary>
		public SyncErrorMessage ErrorCode {
			get {
				return _errorCode ??
					(_errorCode = LookupColumnEntities.GetEntity("ErrorCode") as SyncErrorMessage);
			}
		}

		/// <summary>
		/// Do not stop syncing.
		/// </summary>
		public bool NotStopSyncing {
			get {
				return GetTypedColumnValue<bool>("NotStopSyncing");
			}
			set {
				SetColumnValue("NotStopSyncing", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SyncErrorHandler_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SyncErrorHandlerDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SyncErrorHandler(this);
		}

		#endregion

	}

	#endregion

	#region Class: SyncErrorHandler_BaseEventsProcess

	/// <exclude/>
	public partial class SyncErrorHandler_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseCodeLookup_BaseEventsProcess<TEntity> where TEntity : SyncErrorHandler
	{

		public SyncErrorHandler_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SyncErrorHandler_BaseEventsProcess";
			SchemaUId = new Guid("b0d04bcc-80ac-4f23-b266-580d0578a3b0");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b0d04bcc-80ac-4f23-b266-580d0578a3b0");
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

	#region Class: SyncErrorHandler_BaseEventsProcess

	/// <exclude/>
	public class SyncErrorHandler_BaseEventsProcess : SyncErrorHandler_BaseEventsProcess<SyncErrorHandler>
	{

		public SyncErrorHandler_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SyncErrorHandler_BaseEventsProcess

	public partial class SyncErrorHandler_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SyncErrorHandlerEventsProcessSchema

	/// <exclude/>
	public class SyncErrorHandlerEventsProcessSchema : Terrasoft.Configuration.BaseCodeLookupEventsProcessSchema
	{

		#region Constructors: Public

		public SyncErrorHandlerEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SyncErrorHandlerEventsProcessSchema(SyncErrorHandlerEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SyncErrorHandler_BaseEventsProcess";
			UId = new Guid("d46b0d86-69f9-46d6-8e47-9edf3967fcbd");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2");
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
			return new SyncErrorHandlerEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d46b0d86-69f9-46d6-8e47-9edf3967fcbd"));
		}

		#endregion

	}

	#endregion


	#region Class: SyncErrorHandlerEventsProcess

	/// <exclude/>
	public class SyncErrorHandlerEventsProcess : SyncErrorHandler_BaseEventsProcess
	{

		public SyncErrorHandlerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

