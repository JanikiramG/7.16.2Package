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
	using Terrasoft.Core.Store;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: RemindingSchema

	/// <exclude/>
	public class RemindingSchema : Terrasoft.Configuration.Reminding_Base_TerrasoftSchema
	{

		#region Constructors: Public

		public RemindingSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public RemindingSchema(RemindingSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public RemindingSchema(RemindingSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("45b30a59-08c8-4185-af46-59e3503bda37");
			Name = "Reminding";
			ParentSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37");
			ExtendParent = true;
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateRemindingEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateRemindingEventsProcessSchema() {
			var schema = new RemindingEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Reminding(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Reminding_NUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new RemindingSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new RemindingSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("45b30a59-08c8-4185-af46-59e3503bda37"));
		}

		#endregion

	}

	#endregion

	#region Class: Reminding

	/// <summary>
	/// Notification.
	/// </summary>
	public class Reminding : Terrasoft.Configuration.Reminding_Base_Terrasoft
	{

		#region Constructors: Public

		public Reminding(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Reminding";
		}

		public Reminding(Reminding source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Reminding_NUIEventsProcess(UserConnection);
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
			return new Reminding(this);
		}

		#endregion

	}

	#endregion

	#region Class: Reminding_NUIEventsProcess

	/// <exclude/>
	public partial class Reminding_NUIEventsProcess<TEntity> : Terrasoft.Configuration.Reminding_BaseEventsProcess<TEntity> where TEntity : Reminding
	{

		public Reminding_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Reminding_NUIEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("45b30a59-08c8-4185-af46-59e3503bda37");
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

	#region Class: Reminding_NUIEventsProcess

	/// <exclude/>
	public class Reminding_NUIEventsProcess : Reminding_NUIEventsProcess<Reminding>
	{

		public Reminding_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Reminding_NUIEventsProcess

	public partial class Reminding_NUIEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual INotificationInfo GetNotificationInfo() {
			var notificationTypeName = TryGeNotificationTypeName();
			string loaderName = GetSchemaName(UserConnection.ClientUnitSchemaManager, Entity.LoaderId);
			string schemaName = GetSchemaName(UserConnection.EntitySchemaManager, Entity.SysEntitySchemaId);
			INotificationSettingsRepository notificationSettingsRepository = ClassFactory.Get<NotificationSettingsRepository>(
				new ConstructorArgument("userConnection", UserConnection));
			Guid notificationTypeId = Entity.NotificationTypeId;
			Guid imageId = notificationSettingsRepository.GetNotificationImage(Entity.SysEntitySchemaId, notificationTypeId);
			Guid sysAdminUnitId = NotificationUtilities.GetSysAdminUnitId(UserConnection, Entity.ContactId);
			var title = Entity.PopupTitle.IsNullOrWhiteSpace() ? Entity.Description : Entity.PopupTitle;
			return new NotificationInfo {
				Title = title,
				Body = Entity.SubjectCaption,
				ImageId = imageId,
				EntityId = Entity.SubjectId,
				EntitySchemaName = schemaName,
				MessageId = Entity.Id,
				LoaderName = loaderName,
				SysAdminUnit = sysAdminUnitId,
				GroupName = notificationTypeName,
				RemindTime = Entity.RemindTime
			};
		}

		public override void SendNotification() {
			base.SendNotification();
			if (UserConnection.GetIsFeatureEnabled("NotificationV2")) {
				var notificationInfo = GetNotificationInfo();
				var notificationSender = ClassFactory.Get<INotificationSender>(
					new ConstructorArgument("userConnection", UserConnection));
				notificationSender.Send(new[] {notificationInfo});
			}
		}

		#endregion

	}

	#endregion

	#region Class: RemindingEventsProcessSchema

	/// <exclude/>
	public class RemindingEventsProcessSchema : Terrasoft.Configuration.Reminding_Base_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public RemindingEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public RemindingEventsProcessSchema(RemindingEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Reminding_NUIEventsProcess";
			UId = new Guid("c04fb211-7daa-4bd5-a702-1afcbe0af0ab");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet2_0dd03fbfd29948f483b8df580c8a31f3 = CreateLaneSet2_0dd03fbfd29948f483b8df580c8a31f3LaneSet();
			LaneSets.Add(schemaLaneSet2_0dd03fbfd29948f483b8df580c8a31f3);
			ProcessSchemaLane schemaLane1_54d3c1b7983a4f5cbc6b058e09963644 = CreateLane1_54d3c1b7983a4f5cbc6b058e09963644Lane();
			schemaLaneSet2_0dd03fbfd29948f483b8df580c8a31f3.Lanes.Add(schemaLane1_54d3c1b7983a4f5cbc6b058e09963644);
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_0dd03fbfd29948f483b8df580c8a31f3LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_0dd03fbfd29948f483b8df580c8a31f3 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("0dd03fbf-d299-48f4-83b8-df580c8a31f3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				CreatedInSchemaUId = new Guid("c04fb211-7daa-4bd5-a702-1afcbe0af0ab"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("c04fb211-7daa-4bd5-a702-1afcbe0af0ab"),
				Name = @"LaneSet2_0dd03fbfd29948f483b8df580c8a31f3",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_0dd03fbfd29948f483b8df580c8a31f3;
		}

		protected virtual ProcessSchemaLane CreateLane1_54d3c1b7983a4f5cbc6b058e09963644Lane() {
			ProcessSchemaLane schemaLane1_54d3c1b7983a4f5cbc6b058e09963644 = new ProcessSchemaLane(this) {
				UId = new Guid("54d3c1b7-983a-4f5c-bc6b-058e09963644"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0dd03fbf-d299-48f4-83b8-df580c8a31f3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				CreatedInSchemaUId = new Guid("c04fb211-7daa-4bd5-a702-1afcbe0af0ab"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("c04fb211-7daa-4bd5-a702-1afcbe0af0ab"),
				Name = @"Lane1_54d3c1b7983a4f5cbc6b058e09963644",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1_54d3c1b7983a4f5cbc6b058e09963644;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetNotificationInfoMethod());
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
				UId = new Guid("e9f2af36-5bd4-4011-bdf7-7a9a1a840361"),
				Name = "Terrasoft.Messaging.Common",
				Alias = "",
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070")
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
				UId = new Guid("9cde8651-42c6-49d7-b787-c753a3038298"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b8e6bd6a-2d7c-4f2e-a093-60e828990868"),
				Name = "System.Linq",
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

		protected override SchemaMethod CreateSendNotificationMethod() {
			SchemaMethod method = base.CreateSendNotificationMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,80,59,11,194,48,16,158,219,95,113,100,74,64,58,184,250,0,17,43,93,186,136,46,226,144,182,87,9,212,11,228,161,72,233,127,55,113,234,99,253,238,123,94,37,45,102,23,164,166,212,78,181,170,150,78,105,226,98,147,170,22,248,213,162,57,106,34,172,35,154,157,209,21,54,71,233,188,193,19,201,170,195,134,179,177,238,182,102,66,64,159,38,111,105,128,70,135,130,90,13,59,8,6,229,12,141,81,11,122,236,131,38,8,142,157,180,54,151,181,211,230,27,227,183,69,185,160,237,121,154,36,132,31,8,77,173,51,62,146,15,230,233,95,72,142,51,63,153,192,86,48,221,36,98,252,50,250,255,17,30,76,239,15,232,231,67,134,160,25,126,61,170,30,15,56,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetNotificationInfoMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c9d64d27-0fe6-4b08-bc11-b666372b77ef"),
				Name = "GetNotificationInfo",
				CreatedInSchemaUId = new Guid("c04fb211-7daa-4bd5-a702-1afcbe0af0ab"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				ResultValueTypeName = "INotificationInfo"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,84,219,78,195,48,12,125,94,191,34,218,211,144,166,125,0,227,34,24,48,85,130,129,104,39,158,67,107,54,163,54,169,114,1,85,136,127,199,9,217,154,178,2,143,181,125,142,143,143,157,190,113,197,132,52,248,130,5,55,40,69,222,54,176,226,53,176,83,150,171,118,9,171,129,220,228,104,158,104,163,80,108,88,37,121,9,42,0,150,96,178,98,11,53,247,69,107,13,106,33,133,128,194,97,103,139,10,65,152,181,192,80,115,199,5,223,128,154,178,107,97,208,180,179,91,207,148,150,29,183,222,115,253,199,253,77,49,204,155,181,58,78,251,6,105,60,85,6,198,80,59,253,8,141,212,104,164,106,123,134,12,164,79,217,162,226,90,223,240,194,125,206,72,218,201,223,132,103,147,100,36,224,157,145,100,154,205,58,216,133,218,216,154,12,153,140,109,111,150,241,148,245,135,59,34,189,75,139,229,193,150,210,146,132,132,33,127,110,41,45,3,8,107,50,195,87,254,61,147,27,34,38,73,29,110,242,155,133,211,1,49,59,153,186,213,23,101,141,194,109,218,55,142,105,215,6,43,52,8,218,245,203,122,149,63,118,186,223,31,133,12,25,237,27,188,209,177,82,176,130,110,242,7,217,216,38,119,177,89,170,87,182,170,238,213,211,22,13,100,13,47,232,80,217,249,174,240,10,116,161,176,113,220,236,248,16,61,79,20,24,171,4,115,123,234,57,33,94,36,251,72,70,121,232,235,251,79,147,209,165,44,219,78,70,102,159,95,73,248,130,251,6,148,78,247,198,135,21,80,236,187,54,222,91,128,69,217,44,62,250,238,5,80,254,14,180,222,113,6,184,199,221,198,79,176,123,143,148,137,13,118,108,61,191,41,191,84,210,54,1,56,244,15,160,146,71,32,64,153,99,29,89,222,197,146,207,249,23,194,87,211,5,64,4,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new RemindingEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c04fb211-7daa-4bd5-a702-1afcbe0af0ab"));
		}

		#endregion

	}

	#endregion


	#region Class: RemindingEventsProcess

	/// <exclude/>
	public class RemindingEventsProcess : Reminding_NUIEventsProcess
	{

		public RemindingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

