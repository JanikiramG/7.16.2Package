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

	#region Class: PushNotificationHistorySchema

	/// <exclude/>
	public class PushNotificationHistorySchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public PushNotificationHistorySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public PushNotificationHistorySchema(PushNotificationHistorySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public PushNotificationHistorySchema(PushNotificationHistorySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIiCTh7tPwzoqw1CzkEjt5W7sO3bEIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("277c1ae8-3bad-4fd5-90da-9b544cc932bf");
			index.Name = "IiCTh7tPwzoqw1CzkEjt5W7sO3bE";
			index.CreatedInSchemaUId = new Guid("c8961918-65b6-427a-af9f-a979d47fc37d");
			index.ModifiedInSchemaUId = new Guid("c8961918-65b6-427a-af9f-a979d47fc37d");
			index.CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			EntitySchemaIndexColumn messageIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("830095b4-5c61-4c0f-ad9d-5327b57271f3"),
				ColumnUId = new Guid("d38f5bbd-445b-4e2f-aa9a-725b17654c7a"),
				CreatedInSchemaUId = new Guid("c8961918-65b6-427a-af9f-a979d47fc37d"),
				ModifiedInSchemaUId = new Guid("c8961918-65b6-427a-af9f-a979d47fc37d"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(messageIdIndexColumn);
			EntitySchemaIndexColumn sysAdminUnitIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("64d6856a-0d05-4e3f-b49c-2c4fd9b06596"),
				ColumnUId = new Guid("6fb7dd90-3573-4c09-bb48-f47beda695ee"),
				CreatedInSchemaUId = new Guid("c8961918-65b6-427a-af9f-a979d47fc37d"),
				ModifiedInSchemaUId = new Guid("c8961918-65b6-427a-af9f-a979d47fc37d"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(sysAdminUnitIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c8961918-65b6-427a-af9f-a979d47fc37d");
			RealUId = new Guid("c8961918-65b6-427a-af9f-a979d47fc37d");
			Name = "PushNotificationHistory";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("d38f5bbd-445b-4e2f-aa9a-725b17654c7a")) == null) {
				Columns.Add(CreateMessageIdColumn());
			}
			if (Columns.FindByUId(new Guid("6fb7dd90-3573-4c09-bb48-f47beda695ee")) == null) {
				Columns.Add(CreateSysAdminUnitIdColumn());
			}
			if (Columns.FindByUId(new Guid("12123e79-fe8e-437d-9d74-74dab195613e")) == null) {
				Columns.Add(CreateRemindTimeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateMessageIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("d38f5bbd-445b-4e2f-aa9a-725b17654c7a"),
				Name = @"MessageId",
				CreatedInSchemaUId = new Guid("c8961918-65b6-427a-af9f-a979d47fc37d"),
				ModifiedInSchemaUId = new Guid("c8961918-65b6-427a-af9f-a979d47fc37d"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa")
			};
		}

		protected virtual EntitySchemaColumn CreateSysAdminUnitIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("6fb7dd90-3573-4c09-bb48-f47beda695ee"),
				Name = @"SysAdminUnitId",
				CreatedInSchemaUId = new Guid("c8961918-65b6-427a-af9f-a979d47fc37d"),
				ModifiedInSchemaUId = new Guid("c8961918-65b6-427a-af9f-a979d47fc37d"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa")
			};
		}

		protected virtual EntitySchemaColumn CreateRemindTimeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("12123e79-fe8e-437d-9d74-74dab195613e"),
				Name = @"RemindTime",
				CreatedInSchemaUId = new Guid("c8961918-65b6-427a-af9f-a979d47fc37d"),
				ModifiedInSchemaUId = new Guid("c8961918-65b6-427a-af9f-a979d47fc37d"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIiCTh7tPwzoqw1CzkEjt5W7sO3bEIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreatePushNotificationHistoryEventsProcessSchema();
		}

		protected virtual ProcessSchema CreatePushNotificationHistoryEventsProcessSchema() {
			var schema = new PushNotificationHistoryEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new PushNotificationHistory(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new PushNotificationHistory_NUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new PushNotificationHistorySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new PushNotificationHistorySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c8961918-65b6-427a-af9f-a979d47fc37d"));
		}

		#endregion

	}

	#endregion

	#region Class: PushNotificationHistory

	/// <summary>
	/// Push notification history.
	/// </summary>
	public class PushNotificationHistory : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public PushNotificationHistory(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "PushNotificationHistory";
		}

		public PushNotificationHistory(PushNotificationHistory source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		public Guid MessageId {
			get {
				return GetTypedColumnValue<Guid>("MessageId");
			}
			set {
				SetColumnValue("MessageId", value);
			}
		}

		public Guid SysAdminUnitId {
			get {
				return GetTypedColumnValue<Guid>("SysAdminUnitId");
			}
			set {
				SetColumnValue("SysAdminUnitId", value);
			}
		}

		public DateTime RemindTime {
			get {
				return GetTypedColumnValue<DateTime>("RemindTime");
			}
			set {
				SetColumnValue("RemindTime", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new PushNotificationHistory_NUIEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("PushNotificationHistoryDeleted", e);
			Validating += (s, e) => ThrowEvent("PushNotificationHistoryValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PushNotificationHistory(this);
		}

		#endregion

	}

	#endregion

	#region Class: PushNotificationHistory_NUIEventsProcess

	/// <exclude/>
	public partial class PushNotificationHistory_NUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : PushNotificationHistory
	{

		public PushNotificationHistory_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "PushNotificationHistory_NUIEventsProcess";
			SchemaUId = new Guid("c8961918-65b6-427a-af9f-a979d47fc37d");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c8961918-65b6-427a-af9f-a979d47fc37d");
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

	#region Class: PushNotificationHistory_NUIEventsProcess

	/// <exclude/>
	public class PushNotificationHistory_NUIEventsProcess : PushNotificationHistory_NUIEventsProcess<PushNotificationHistory>
	{

		public PushNotificationHistory_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: PushNotificationHistory_NUIEventsProcess

	public partial class PushNotificationHistory_NUIEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: PushNotificationHistoryEventsProcessSchema

	/// <exclude/>
	public class PushNotificationHistoryEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public PushNotificationHistoryEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public PushNotificationHistoryEventsProcessSchema(PushNotificationHistoryEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "PushNotificationHistory_NUIEventsProcess";
			UId = new Guid("7cf51598-2802-4ec6-8b1f-82e3c39d5273");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
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
			return new PushNotificationHistoryEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7cf51598-2802-4ec6-8b1f-82e3c39d5273"));
		}

		#endregion

	}

	#endregion


	#region Class: PushNotificationHistoryEventsProcess

	/// <exclude/>
	public class PushNotificationHistoryEventsProcess : PushNotificationHistory_NUIEventsProcess
	{

		public PushNotificationHistoryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

