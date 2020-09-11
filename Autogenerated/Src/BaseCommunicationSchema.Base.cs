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

	#region Class: BaseCommunicationSchema

	/// <exclude/>
	[IsVirtual]
	public class BaseCommunicationSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public BaseCommunicationSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BaseCommunicationSchema(BaseCommunicationSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BaseCommunicationSchema(BaseCommunicationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("33245659-4fea-425d-b591-9ed4bdeacaf5");
			RealUId = new Guid("33245659-4fea-425d-b591-9ed4bdeacaf5");
			Name = "BaseCommunication";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNumberColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("12f1d73a-43c5-4a52-9bd6-3e0ecafd3fb4")) == null) {
				Columns.Add(CreateCommunicationTypeColumn());
			}
			if (Columns.FindByUId(new Guid("0c103353-496a-4ff9-a8eb-877dfed4af26")) == null) {
				Columns.Add(CreatePositionColumn());
			}
			if (Columns.FindByUId(new Guid("c8c5a7d8-f9c8-420a-af2a-cdb3f130e16d")) == null) {
				Columns.Add(CreateSocialMediaIdColumn());
			}
			if (Columns.FindByUId(new Guid("44278aac-22bf-44eb-8b94-c5e9b3525027")) == null) {
				Columns.Add(CreateSearchNumberColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCommunicationTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("12f1d73a-43c5-4a52-9bd6-3e0ecafd3fb4"),
				Name = @"CommunicationType",
				ReferenceSchemaUId = new Guid("d846cb4f-f18d-469e-83ff-e961f3fba873"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("33245659-4fea-425d-b591-9ed4bdeacaf5"),
				ModifiedInSchemaUId = new Guid("33245659-4fea-425d-b591-9ed4bdeacaf5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("02fcae57-fafa-4e4f-9367-b58317a6e2ec"),
				Name = @"Number",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("33245659-4fea-425d-b591-9ed4bdeacaf5"),
				ModifiedInSchemaUId = new Guid("33245659-4fea-425d-b591-9ed4bdeacaf5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("0c103353-496a-4ff9-a8eb-877dfed4af26"),
				Name = @"Position",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("33245659-4fea-425d-b591-9ed4bdeacaf5"),
				ModifiedInSchemaUId = new Guid("33245659-4fea-425d-b591-9ed4bdeacaf5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSocialMediaIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("c8c5a7d8-f9c8-420a-af2a-cdb3f130e16d"),
				Name = @"SocialMediaId",
				CreatedInSchemaUId = new Guid("33245659-4fea-425d-b591-9ed4bdeacaf5"),
				ModifiedInSchemaUId = new Guid("33245659-4fea-425d-b591-9ed4bdeacaf5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSearchNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("44278aac-22bf-44eb-8b94-c5e9b3525027"),
				Name = @"SearchNumber",
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("33245659-4fea-425d-b591-9ed4bdeacaf5"),
				ModifiedInSchemaUId = new Guid("33245659-4fea-425d-b591-9ed4bdeacaf5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseCommunicationEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateBaseCommunicationEventsProcessSchema() {
			var schema = new BaseCommunicationEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BaseCommunication(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BaseCommunication_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BaseCommunicationSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BaseCommunicationSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("33245659-4fea-425d-b591-9ed4bdeacaf5"));
		}

		#endregion

	}

	#endregion

	#region Class: BaseCommunication

	/// <summary>
	/// Base communication option.
	/// </summary>
	public class BaseCommunication : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public BaseCommunication(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BaseCommunication";
		}

		public BaseCommunication(BaseCommunication source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid CommunicationTypeId {
			get {
				return GetTypedColumnValue<Guid>("CommunicationTypeId");
			}
			set {
				SetColumnValue("CommunicationTypeId", value);
				_communicationType = null;
			}
		}

		/// <exclude/>
		public string CommunicationTypeName {
			get {
				return GetTypedColumnValue<string>("CommunicationTypeName");
			}
			set {
				SetColumnValue("CommunicationTypeName", value);
				if (_communicationType != null) {
					_communicationType.Name = value;
				}
			}
		}

		private CommunicationType _communicationType;
		/// <summary>
		/// Type.
		/// </summary>
		public CommunicationType CommunicationType {
			get {
				return _communicationType ??
					(_communicationType = LookupColumnEntities.GetEntity("CommunicationType") as CommunicationType);
			}
		}

		/// <summary>
		/// Number.
		/// </summary>
		public string Number {
			get {
				return GetTypedColumnValue<string>("Number");
			}
			set {
				SetColumnValue("Number", value);
			}
		}

		/// <summary>
		/// Position.
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
		/// Social network Id.
		/// </summary>
		public string SocialMediaId {
			get {
				return GetTypedColumnValue<string>("SocialMediaId");
			}
			set {
				SetColumnValue("SocialMediaId", value);
			}
		}

		/// <summary>
		/// Number for search.
		/// </summary>
		public string SearchNumber {
			get {
				return GetTypedColumnValue<string>("SearchNumber");
			}
			set {
				SetColumnValue("SearchNumber", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BaseCommunication_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BaseCommunicationDeleted", e);
			Deleting += (s, e) => ThrowEvent("BaseCommunicationDeleting", e);
			Inserted += (s, e) => ThrowEvent("BaseCommunicationInserted", e);
			Inserting += (s, e) => ThrowEvent("BaseCommunicationInserting", e);
			Saved += (s, e) => ThrowEvent("BaseCommunicationSaved", e);
			Saving += (s, e) => ThrowEvent("BaseCommunicationSaving", e);
			Validating += (s, e) => ThrowEvent("BaseCommunicationValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseCommunication(this);
		}

		#endregion

	}

	#endregion

	#region Class: BaseCommunication_BaseEventsProcess

	/// <exclude/>
	public partial class BaseCommunication_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : BaseCommunication
	{

		public BaseCommunication_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseCommunication_BaseEventsProcess";
			SchemaUId = new Guid("33245659-4fea-425d-b591-9ed4bdeacaf5");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("33245659-4fea-425d-b591-9ed4bdeacaf5");
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

	#region Class: BaseCommunication_BaseEventsProcess

	/// <exclude/>
	public class BaseCommunication_BaseEventsProcess : BaseCommunication_BaseEventsProcess<BaseCommunication>
	{

		public BaseCommunication_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseCommunication_BaseEventsProcess

	public partial class BaseCommunication_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual Entity GetCommunicationParentEntity(string schemaName, Guid id) {
			var schema = UserConnection.EntitySchemaManager.GetInstanceByName(schemaName);
			var entity = schema.CreateEntity(UserConnection);
			entity.FetchFromDB(id);
			return entity;
		}

		public virtual bool GetCanEditColumn(string schemaName, string columnName) {
			EntitySchemaColumnRightLevel rightLevel = UserConnection.DBSecurityEngine
					.GetEntitySchemaColumnRightLevel(schemaName, columnName, SchemaOperationRightLevels.CanEdit);
			return (rightLevel & EntitySchemaColumnRightLevel.CanEdit) == EntitySchemaColumnRightLevel.CanEdit;
		}

		public virtual void UpdateCommunicationParentEntity(string schemaName, Guid parentEntityId, string typedColumnName) {
			var parentEntity = GetCommunicationParentEntity(schemaName, parentEntityId);
			if (parentEntity == null) {
				return;
			}
			bool isCanEdit = GetCanEditColumn(schemaName, typedColumnName);
			if (isCanEdit) {
				var number = Entity.GetTypedColumnValue<string>("Number");
				SetCommunicationParentEntityColumns(parentEntity);
			}
			parentEntity.SetColumnValue("ModifiedOn", DateTime.UtcNow);
			parentEntity.CreateUpdate().Execute();
			TrackingChangedColumns(parentEntity);
		}

		public virtual void SetCommunicationParentEntityColumns(Entity parentEntity) {
		}

		public virtual void TrackingChangedColumns(Entity parentEntity) {
			var schemaName = parentEntity.Schema.Name;
			var parentSchema = UserConnection.EntitySchemaManager.FindInstanceByName(schemaName);
			parentEntity.TrackChangeInDB(parentSchema);
		}

		#endregion

	}

	#endregion

	#region Class: BaseCommunicationEventsProcessSchema

	/// <exclude/>
	public class BaseCommunicationEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public BaseCommunicationEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseCommunicationEventsProcessSchema(BaseCommunicationEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseCommunication_BaseEventsProcess";
			UId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = Guid.Empty;
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet2_540e51a2f8cf4b08b7d8c9485f1efb31 = CreateLaneSet2_540e51a2f8cf4b08b7d8c9485f1efb31LaneSet();
			LaneSets.Add(schemaLaneSet2_540e51a2f8cf4b08b7d8c9485f1efb31);
			ProcessSchemaLane schemaLane1_13f80133a7044b6c9917d80722522a06 = CreateLane1_13f80133a7044b6c9917d80722522a06Lane();
			schemaLaneSet2_540e51a2f8cf4b08b7d8c9485f1efb31.Lanes.Add(schemaLane1_13f80133a7044b6c9917d80722522a06);
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_540e51a2f8cf4b08b7d8c9485f1efb31LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_540e51a2f8cf4b08b7d8c9485f1efb31 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("540e51a2-f8cf-4b08-b7d8-c9485f1efb31"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				Name = @"LaneSet2_540e51a2f8cf4b08b7d8c9485f1efb31",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_540e51a2f8cf4b08b7d8c9485f1efb31;
		}

		protected virtual ProcessSchemaLane CreateLane1_13f80133a7044b6c9917d80722522a06Lane() {
			ProcessSchemaLane schemaLane1_13f80133a7044b6c9917d80722522a06 = new ProcessSchemaLane(this) {
				UId = new Guid("13f80133-a704-4b6c-9917-d80722522a06"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("540e51a2-f8cf-4b08-b7d8-c9485f1efb31"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				Name = @"Lane1_13f80133a7044b6c9917d80722522a06",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1_13f80133a7044b6c9917d80722522a06;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetCommunicationParentEntityMethod());
			Methods.Add(CreateGetCanEditColumnMethod());
			Methods.Add(CreateUpdateCommunicationParentEntityMethod());
			Methods.Add(CreateSetCommunicationParentEntityColumnsMethod());
			Methods.Add(CreateTrackingChangedColumnsMethod());
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

		protected virtual SchemaMethod CreateGetCommunicationParentEntityMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9656483c-1be6-4798-93df-0070982d00fa"),
				Name = "GetCommunicationParentEntity",
				CreatedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "Entity"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4cdda664-7537-4030-9720-f23e15c79282"),
				Name = "schemaName",
				CreatedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				ModifiedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("930fc268-7f61-4b3f-82b0-38871bc1ac7f"),
				Name = "id",
				CreatedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				ModifiedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,141,59,14,194,48,16,68,123,78,225,210,52,190,64,68,147,31,162,128,6,229,0,43,103,148,184,240,90,90,47,145,114,123,156,152,134,110,180,179,239,205,70,98,178,95,17,201,220,204,148,33,93,98,134,215,144,216,13,172,65,247,247,217,62,137,105,129,184,59,244,193,89,137,61,218,253,69,17,182,210,71,188,54,151,173,232,112,98,69,87,27,215,9,72,81,101,246,127,162,16,245,219,141,80,191,142,146,98,223,218,48,151,187,64,63,194,63,89,243,5,39,63,150,159,167,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetCanEditColumnMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3e79850f-dc9a-41ef-a78d-7992c091ce0d"),
				Name = "GetCanEditColumn",
				CreatedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bc8ac77d-b290-490f-8b47-a40525962899"),
				Name = "schemaName",
				CreatedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				ModifiedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7bfb23d7-9eab-41fb-86e9-de1e7128aa77"),
				Name = "columnName",
				CreatedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				ModifiedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,43,201,44,169,12,78,206,72,205,77,116,206,207,41,205,205,11,202,76,207,40,241,73,45,75,205,81,40,66,48,109,21,66,139,83,139,156,243,243,242,82,147,75,50,243,243,244,92,156,130,83,147,75,139,128,154,93,243,210,51,243,82,185,56,57,245,220,83,75,92,241,152,167,81,12,22,246,75,204,77,213,81,72,6,75,66,216,16,229,254,5,169,69,137,32,179,17,58,138,245,156,19,243,92,83,50,75,52,173,185,138,82,75,74,139,242,20,52,144,28,165,166,128,207,58,184,94,5,91,91,162,20,90,3,0,83,235,142,227,13,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateCommunicationParentEntityMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3663894d-0ad0-4729-a215-83dc83e24a52"),
				Name = "UpdateCommunicationParentEntity",
				CreatedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ab79d2f8-a0d2-4874-bf13-d6935c6bbb63"),
				Name = "schemaName",
				CreatedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				ModifiedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a9cef3f5-1d90-4e3e-88c5-3f44aaf2ba50"),
				Name = "parentEntityId",
				CreatedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				ModifiedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("850aec4a-c821-4a66-8096-41275c8b1dcf"),
				Name = "typedColumnName",
				CreatedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				ModifiedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,79,77,79,194,48,24,62,179,100,255,161,217,169,75,200,254,128,226,101,46,134,3,211,196,225,189,180,47,208,216,190,93,186,183,40,49,254,119,59,42,200,60,112,105,218,167,207,231,65,120,214,11,15,72,13,146,166,35,91,176,39,160,218,89,27,80,75,65,218,225,203,213,55,31,228,30,172,104,133,133,249,68,183,84,229,93,158,233,45,227,83,183,5,195,96,76,201,190,242,108,230,129,130,199,72,251,206,179,141,115,134,233,161,22,216,40,77,191,169,233,81,59,19,44,78,146,232,216,131,74,248,8,156,163,46,250,228,127,136,91,48,216,13,248,232,151,10,84,209,182,251,19,191,9,19,224,126,32,175,113,247,192,139,246,68,46,70,187,217,235,141,213,73,60,76,166,149,105,199,53,84,157,60,46,57,188,88,57,165,183,26,212,51,22,115,246,40,8,58,109,161,90,147,108,221,199,168,159,136,107,15,145,177,238,85,60,121,89,53,159,32,195,120,139,188,206,11,249,30,43,215,123,129,187,243,150,255,117,126,0,68,244,73,131,202,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetCommunicationParentEntityColumnsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("eb4b5212-08bf-4b99-b74e-19237ec3b864"),
				Name = "SetCommunicationParentEntityColumns",
				CreatedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3a9ad324-62fa-4b66-84f8-00f14f954905"),
				Name = "parentEntity",
				CreatedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				ModifiedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateTrackingChangedColumnsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f0baa467-d9c1-43c3-a12d-3928f587e25a"),
				Name = "TrackingChangedColumns",
				CreatedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("80475a7e-c1fb-45ee-8ef0-ac7ba0bc3dc0"),
				Name = "parentEntity",
				CreatedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				ModifiedInSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,141,59,14,131,48,16,68,123,78,225,18,26,95,192,74,195,79,162,72,26,146,3,172,204,10,172,136,33,90,175,144,184,125,32,46,8,237,188,153,121,43,137,137,126,226,153,30,52,179,185,153,15,9,67,27,104,208,205,246,63,98,15,228,178,117,175,38,154,226,189,252,138,44,213,2,176,215,176,192,166,85,162,119,2,141,44,182,13,24,58,68,37,120,46,183,227,41,63,125,133,203,46,190,167,144,127,87,19,97,228,14,117,153,255,235,10,247,5,32,45,3,9,172,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseCommunicationEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"));
		}

		#endregion

	}

	#endregion


	#region Class: BaseCommunicationEventsProcess

	/// <exclude/>
	public class BaseCommunicationEventsProcess : BaseCommunication_BaseEventsProcess
	{

		public BaseCommunicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

