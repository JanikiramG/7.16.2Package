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

	#region Class: NotificationProviderSchema

	/// <exclude/>
	public class NotificationProviderSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public NotificationProviderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public NotificationProviderSchema(NotificationProviderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public NotificationProviderSchema(NotificationProviderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("74494ba7-82f2-4966-84cc-3af84d4eb6fb");
			RealUId = new Guid("74494ba7-82f2-4966-84cc-3af84d4eb6fb");
			Name = "NotificationProvider";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a664c9a9-6373-437f-9be3-23f33a134628")) == null) {
				Columns.Add(CreateClassNameColumn());
			}
			if (Columns.FindByUId(new Guid("c84e4a7d-70dc-4ad9-9ac5-bd885086b5b9")) == null) {
				Columns.Add(CreateTypeColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("74494ba7-82f2-4966-84cc-3af84d4eb6fb");
			column.CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("74494ba7-82f2-4966-84cc-3af84d4eb6fb");
			column.CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("74494ba7-82f2-4966-84cc-3af84d4eb6fb");
			column.CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("74494ba7-82f2-4966-84cc-3af84d4eb6fb");
			column.CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("74494ba7-82f2-4966-84cc-3af84d4eb6fb");
			column.CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("74494ba7-82f2-4966-84cc-3af84d4eb6fb");
			column.CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("74494ba7-82f2-4966-84cc-3af84d4eb6fb");
			column.CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("74494ba7-82f2-4966-84cc-3af84d4eb6fb");
			column.CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152");
			return column;
		}

		protected virtual EntitySchemaColumn CreateClassNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("a664c9a9-6373-437f-9be3-23f33a134628"),
				Name = @"ClassName",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("74494ba7-82f2-4966-84cc-3af84d4eb6fb"),
				ModifiedInSchemaUId = new Guid("74494ba7-82f2-4966-84cc-3af84d4eb6fb"),
				CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("c84e4a7d-70dc-4ad9-9ac5-bd885086b5b9"),
				Name = @"Type",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("74494ba7-82f2-4966-84cc-3af84d4eb6fb"),
				ModifiedInSchemaUId = new Guid("74494ba7-82f2-4966-84cc-3af84d4eb6fb"),
				CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"0"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateNotificationProviderEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateNotificationProviderEventsProcessSchema() {
			var schema = new NotificationProviderEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new NotificationProvider(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new NotificationProvider_NUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new NotificationProviderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new NotificationProviderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("74494ba7-82f2-4966-84cc-3af84d4eb6fb"));
		}

		#endregion

	}

	#endregion

	#region Class: NotificationProvider

	/// <summary>
	/// Notification provider.
	/// </summary>
	public class NotificationProvider : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public NotificationProvider(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "NotificationProvider";
		}

		public NotificationProvider(NotificationProvider source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Class name.
		/// </summary>
		public string ClassName {
			get {
				return GetTypedColumnValue<string>("ClassName");
			}
			set {
				SetColumnValue("ClassName", value);
			}
		}

		/// <summary>
		/// Type.
		/// </summary>
		public int Type {
			get {
				return GetTypedColumnValue<int>("Type");
			}
			set {
				SetColumnValue("Type", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new NotificationProvider_NUIEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("NotificationProviderDeleted", e);
			Inserting += (s, e) => ThrowEvent("NotificationProviderInserting", e);
			Validating += (s, e) => ThrowEvent("NotificationProviderValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new NotificationProvider(this);
		}

		#endregion

	}

	#endregion

	#region Class: NotificationProvider_NUIEventsProcess

	/// <exclude/>
	public partial class NotificationProvider_NUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : NotificationProvider
	{

		public NotificationProvider_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "NotificationProvider_NUIEventsProcess";
			SchemaUId = new Guid("74494ba7-82f2-4966-84cc-3af84d4eb6fb");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("74494ba7-82f2-4966-84cc-3af84d4eb6fb");
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

	#region Class: NotificationProvider_NUIEventsProcess

	/// <exclude/>
	public class NotificationProvider_NUIEventsProcess : NotificationProvider_NUIEventsProcess<NotificationProvider>
	{

		public NotificationProvider_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: NotificationProvider_NUIEventsProcess

	public partial class NotificationProvider_NUIEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: NotificationProviderEventsProcessSchema

	/// <exclude/>
	public class NotificationProviderEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public NotificationProviderEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public NotificationProviderEventsProcessSchema(NotificationProviderEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "NotificationProvider_NUIEventsProcess";
			UId = new Guid("5166cb7e-9088-4815-a5c4-37ea7fbe362b");
			CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1");
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
				CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152")
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
			return new NotificationProviderEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5166cb7e-9088-4815-a5c4-37ea7fbe362b"));
		}

		#endregion

	}

	#endregion


	#region Class: NotificationProviderEventsProcess

	/// <exclude/>
	public class NotificationProviderEventsProcess : NotificationProvider_NUIEventsProcess
	{

		public NotificationProviderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

