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

	#region Class: MailboxSyncSettingsSchema

	/// <exclude/>
	public class MailboxSyncSettingsSchema : Terrasoft.Configuration.MailboxSyncSettings_Exchange_TerrasoftSchema
	{

		#region Constructors: Public

		public MailboxSyncSettingsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MailboxSyncSettingsSchema(MailboxSyncSettingsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MailboxSyncSettingsSchema(MailboxSyncSettingsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("6b3862cd-127b-446a-a829-d027ada6df3d");
			Name = "MailboxSyncSettings";
			ParentSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315");
			ExtendParent = true;
			CreatedInPackageId = new Guid("312571d2-5e4d-43a6-b9ab-0f4de364b033");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("fe0b3b4a-7029-4031-b6a8-1718944fc658")) == null) {
				Columns.Add(CreatePersonalMetricsColumn());
			}
		}

		protected virtual EntitySchemaColumn CreatePersonalMetricsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("fe0b3b4a-7029-4031-b6a8-1718944fc658"),
				Name = @"PersonalMetrics",
				CreatedInSchemaUId = new Guid("6b3862cd-127b-446a-a829-d027ada6df3d"),
				ModifiedInSchemaUId = new Guid("6b3862cd-127b-446a-a829-d027ada6df3d"),
				CreatedInPackageId = new Guid("312571d2-5e4d-43a6-b9ab-0f4de364b033")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMailboxSyncSettingsEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateMailboxSyncSettingsEventsProcessSchema() {
			var schema = new MailboxSyncSettingsEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new MailboxSyncSettings(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new MailboxSyncSettings_ExchangeListenerEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MailboxSyncSettingsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MailboxSyncSettingsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6b3862cd-127b-446a-a829-d027ada6df3d"));
		}

		#endregion

	}

	#endregion

	#region Class: MailboxSyncSettings

	/// <summary>
	/// Mailbox synchronization settings.
	/// </summary>
	public class MailboxSyncSettings : Terrasoft.Configuration.MailboxSyncSettings_Exchange_Terrasoft
	{

		#region Constructors: Public

		public MailboxSyncSettings(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MailboxSyncSettings";
		}

		public MailboxSyncSettings(MailboxSyncSettings source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// PersonalMetrics.
		/// </summary>
		public bool PersonalMetrics {
			get {
				return GetTypedColumnValue<bool>("PersonalMetrics");
			}
			set {
				SetColumnValue("PersonalMetrics", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MailboxSyncSettings_ExchangeListenerEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("MailboxSyncSettingsDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MailboxSyncSettings(this);
		}

		#endregion

	}

	#endregion

	#region Class: MailboxSyncSettings_ExchangeListenerEventsProcess

	/// <exclude/>
	public partial class MailboxSyncSettings_ExchangeListenerEventsProcess<TEntity> : Terrasoft.Configuration.MailboxSyncSettings_ExchangeEventsProcess<TEntity> where TEntity : MailboxSyncSettings
	{

		public MailboxSyncSettings_ExchangeListenerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MailboxSyncSettings_ExchangeListenerEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6b3862cd-127b-446a-a829-d027ada6df3d");
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

	#region Class: MailboxSyncSettings_ExchangeListenerEventsProcess

	/// <exclude/>
	public class MailboxSyncSettings_ExchangeListenerEventsProcess : MailboxSyncSettings_ExchangeListenerEventsProcess<MailboxSyncSettings>
	{

		public MailboxSyncSettings_ExchangeListenerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MailboxSyncSettings_ExchangeListenerEventsProcess

	public partial class MailboxSyncSettings_ExchangeListenerEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: MailboxSyncSettingsEventsProcessSchema

	/// <exclude/>
	public class MailboxSyncSettingsEventsProcessSchema : Terrasoft.Configuration.MailboxSyncSettings_Exchange_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public MailboxSyncSettingsEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MailboxSyncSettingsEventsProcessSchema(MailboxSyncSettingsEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "MailboxSyncSettings_ExchangeListenerEventsProcess";
			UId = new Guid("338fa9b7-2dc2-4d00-afd5-476bf69956ba");
			CreatedInPackageId = new Guid("312571d2-5e4d-43a6-b9ab-0f4de364b033");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet3_d39fc3a98f9945b7bb474aae2b93fd26 = CreateLaneSet3_d39fc3a98f9945b7bb474aae2b93fd26LaneSet();
			LaneSets.Add(schemaLaneSet3_d39fc3a98f9945b7bb474aae2b93fd26);
			ProcessSchemaLane schemaLane3_37a8d09452044f239aacefdbfe85b686 = CreateLane3_37a8d09452044f239aacefdbfe85b686Lane();
			schemaLaneSet3_d39fc3a98f9945b7bb474aae2b93fd26.Lanes.Add(schemaLane3_37a8d09452044f239aacefdbfe85b686);
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet3_d39fc3a98f9945b7bb474aae2b93fd26LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet3_d39fc3a98f9945b7bb474aae2b93fd26 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("d39fc3a9-8f99-45b7-bb47-4aae2b93fd26"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				CreatedInPackageId = new Guid("312571d2-5e4d-43a6-b9ab-0f4de364b033"),
				CreatedInSchemaUId = new Guid("338fa9b7-2dc2-4d00-afd5-476bf69956ba"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("338fa9b7-2dc2-4d00-afd5-476bf69956ba"),
				Name = @"LaneSet3_d39fc3a98f9945b7bb474aae2b93fd26",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet3_d39fc3a98f9945b7bb474aae2b93fd26;
		}

		protected virtual ProcessSchemaLane CreateLane3_37a8d09452044f239aacefdbfe85b686Lane() {
			ProcessSchemaLane schemaLane3_37a8d09452044f239aacefdbfe85b686 = new ProcessSchemaLane(this) {
				UId = new Guid("37a8d094-5204-4f23-9aac-efdbfe85b686"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d39fc3a9-8f99-45b7-bb47-4aae2b93fd26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("312571d2-5e4d-43a6-b9ab-0f4de364b033"),
				CreatedInSchemaUId = new Guid("338fa9b7-2dc2-4d00-afd5-476bf69956ba"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("338fa9b7-2dc2-4d00-afd5-476bf69956ba"),
				Name = @"Lane3_37a8d09452044f239aacefdbfe85b686",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane3_37a8d09452044f239aacefdbfe85b686;
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
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
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
			return new MailboxSyncSettingsEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("338fa9b7-2dc2-4d00-afd5-476bf69956ba"));
		}

		#endregion

	}

	#endregion


	#region Class: MailboxSyncSettingsEventsProcess

	/// <exclude/>
	public class MailboxSyncSettingsEventsProcess : MailboxSyncSettings_ExchangeListenerEventsProcess
	{

		public MailboxSyncSettingsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

