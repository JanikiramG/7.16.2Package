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

	#region Class: ListenerByNotifierSchema

	/// <exclude/>
	public class ListenerByNotifierSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ListenerByNotifierSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ListenerByNotifierSchema(ListenerByNotifierSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ListenerByNotifierSchema(ListenerByNotifierSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("63845207-7cec-41ff-baf5-425b69236020");
			RealUId = new Guid("63845207-7cec-41ff-baf5-425b69236020");
			Name = "ListenerByNotifier";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b4ad7210-1e2c-4a25-8f9c-bff818d48783");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b606eb57-6d58-435e-b69b-ac57d73c4c29")) == null) {
				Columns.Add(CreateMessageNotifierColumn());
			}
			if (Columns.FindByUId(new Guid("bf4e2548-f0a6-4b3f-bb6c-711826502b0d")) == null) {
				Columns.Add(CreateMessageListenerColumn());
			}
			if (Columns.FindByUId(new Guid("9deea5b1-d5bd-4c81-8e55-76d396376457")) == null) {
				Columns.Add(CreateNotifierConnectionColumnColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateMessageNotifierColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b606eb57-6d58-435e-b69b-ac57d73c4c29"),
				Name = @"MessageNotifier",
				ReferenceSchemaUId = new Guid("eb2f5124-c41f-4166-9caf-7986912ddea1"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("63845207-7cec-41ff-baf5-425b69236020"),
				ModifiedInSchemaUId = new Guid("63845207-7cec-41ff-baf5-425b69236020"),
				CreatedInPackageId = new Guid("b4ad7210-1e2c-4a25-8f9c-bff818d48783")
			};
		}

		protected virtual EntitySchemaColumn CreateMessageListenerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("bf4e2548-f0a6-4b3f-bb6c-711826502b0d"),
				Name = @"MessageListener",
				ReferenceSchemaUId = new Guid("34c308f0-dd59-4069-9613-4093b945b9be"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("63845207-7cec-41ff-baf5-425b69236020"),
				ModifiedInSchemaUId = new Guid("63845207-7cec-41ff-baf5-425b69236020"),
				CreatedInPackageId = new Guid("b4ad7210-1e2c-4a25-8f9c-bff818d48783")
			};
		}

		protected virtual EntitySchemaColumn CreateNotifierConnectionColumnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("9deea5b1-d5bd-4c81-8e55-76d396376457"),
				Name = @"NotifierConnectionColumn",
				CreatedInSchemaUId = new Guid("63845207-7cec-41ff-baf5-425b69236020"),
				ModifiedInSchemaUId = new Guid("63845207-7cec-41ff-baf5-425b69236020"),
				CreatedInPackageId = new Guid("cf777bca-d84e-40ce-8c41-2703b994b306")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateListenerByNotifierEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateListenerByNotifierEventsProcessSchema() {
			var schema = new ListenerByNotifierEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ListenerByNotifier(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ListenerByNotifier_MessageEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ListenerByNotifierSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ListenerByNotifierSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("63845207-7cec-41ff-baf5-425b69236020"));
		}

		#endregion

	}

	#endregion

	#region Class: ListenerByNotifier

	/// <summary>
	/// Listener by notifier.
	/// </summary>
	public class ListenerByNotifier : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ListenerByNotifier(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ListenerByNotifier";
		}

		public ListenerByNotifier(ListenerByNotifier source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid MessageNotifierId {
			get {
				return GetTypedColumnValue<Guid>("MessageNotifierId");
			}
			set {
				SetColumnValue("MessageNotifierId", value);
				_messageNotifier = null;
			}
		}

		/// <exclude/>
		public string MessageNotifierName {
			get {
				return GetTypedColumnValue<string>("MessageNotifierName");
			}
			set {
				SetColumnValue("MessageNotifierName", value);
				if (_messageNotifier != null) {
					_messageNotifier.Name = value;
				}
			}
		}

		private MessageNotifier _messageNotifier;
		/// <summary>
		/// Notifier.
		/// </summary>
		public MessageNotifier MessageNotifier {
			get {
				return _messageNotifier ??
					(_messageNotifier = LookupColumnEntities.GetEntity("MessageNotifier") as MessageNotifier);
			}
		}

		/// <exclude/>
		public Guid MessageListenerId {
			get {
				return GetTypedColumnValue<Guid>("MessageListenerId");
			}
			set {
				SetColumnValue("MessageListenerId", value);
				_messageListener = null;
			}
		}

		/// <exclude/>
		public string MessageListenerName {
			get {
				return GetTypedColumnValue<string>("MessageListenerName");
			}
			set {
				SetColumnValue("MessageListenerName", value);
				if (_messageListener != null) {
					_messageListener.Name = value;
				}
			}
		}

		private MessageListener _messageListener;
		/// <summary>
		/// Listener.
		/// </summary>
		public MessageListener MessageListener {
			get {
				return _messageListener ??
					(_messageListener = LookupColumnEntities.GetEntity("MessageListener") as MessageListener);
			}
		}

		/// <summary>
		/// Notifier connection column name.
		/// </summary>
		public string NotifierConnectionColumn {
			get {
				return GetTypedColumnValue<string>("NotifierConnectionColumn");
			}
			set {
				SetColumnValue("NotifierConnectionColumn", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ListenerByNotifier_MessageEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ListenerByNotifierDeleted", e);
			Validating += (s, e) => ThrowEvent("ListenerByNotifierValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ListenerByNotifier(this);
		}

		#endregion

	}

	#endregion

	#region Class: ListenerByNotifier_MessageEventsProcess

	/// <exclude/>
	public partial class ListenerByNotifier_MessageEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ListenerByNotifier
	{

		public ListenerByNotifier_MessageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ListenerByNotifier_MessageEventsProcess";
			SchemaUId = new Guid("63845207-7cec-41ff-baf5-425b69236020");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("63845207-7cec-41ff-baf5-425b69236020");
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

	#region Class: ListenerByNotifier_MessageEventsProcess

	/// <exclude/>
	public class ListenerByNotifier_MessageEventsProcess : ListenerByNotifier_MessageEventsProcess<ListenerByNotifier>
	{

		public ListenerByNotifier_MessageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ListenerByNotifier_MessageEventsProcess

	public partial class ListenerByNotifier_MessageEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ListenerByNotifierEventsProcessSchema

	/// <exclude/>
	public class ListenerByNotifierEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ListenerByNotifierEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ListenerByNotifierEventsProcessSchema(ListenerByNotifierEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ListenerByNotifier_MessageEventsProcess";
			UId = new Guid("35c15f2e-c307-47f3-90e8-37103331063d");
			CreatedInPackageId = new Guid("b4ad7210-1e2c-4a25-8f9c-bff818d48783");
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
			return new ListenerByNotifierEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("35c15f2e-c307-47f3-90e8-37103331063d"));
		}

		#endregion

	}

	#endregion


	#region Class: ListenerByNotifierEventsProcess

	/// <exclude/>
	public class ListenerByNotifierEventsProcess : ListenerByNotifier_MessageEventsProcess
	{

		public ListenerByNotifierEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

