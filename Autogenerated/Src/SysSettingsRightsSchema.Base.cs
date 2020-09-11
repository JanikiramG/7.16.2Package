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

	#region Class: SysSettingsRightsSchema

	/// <exclude/>
	public class SysSettingsRightsSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysSettingsRightsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysSettingsRightsSchema(SysSettingsRightsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysSettingsRightsSchema(SysSettingsRightsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIvyrY7L49OyjFyuk8DRTHSArtTcIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = true
			};
			index.UId = new Guid("aa3a7a07-c9ce-4d54-9559-af4332e6d0b3");
			index.Name = "IvyrY7L49OyjFyuk8DRTHSArtTc";
			index.CreatedInSchemaUId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c");
			index.ModifiedInSchemaUId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c");
			index.CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0");
			EntitySchemaIndexColumn sysSettingsCodeIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("2598d90e-4593-4bf1-8593-13facdd63a16"),
				ColumnUId = new Guid("5e6eb364-6b37-4993-bafe-8688c8f83fa0"),
				CreatedInSchemaUId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c"),
				ModifiedInSchemaUId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c"),
				CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(sysSettingsCodeIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c");
			RealUId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c");
			Name = "SysSettingsRights";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5e6eb364-6b37-4993-bafe-8688c8f83fa0")) == null) {
				Columns.Add(CreateSysSettingsCodeColumn());
			}
			if (Columns.FindByUId(new Guid("9f37604b-7361-4e21-9abf-8c357922d9a0")) == null) {
				Columns.Add(CreateReadOperationCodeColumn());
			}
			if (Columns.FindByUId(new Guid("d92aec3b-cfd9-40c2-b613-b71690edbeb8")) == null) {
				Columns.Add(CreateReadWriteOperationCodeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysSettingsCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("5e6eb364-6b37-4993-bafe-8688c8f83fa0"),
				Name = @"SysSettingsCode",
				CreatedInSchemaUId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c"),
				ModifiedInSchemaUId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c"),
				CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0")
			};
		}

		protected virtual EntitySchemaColumn CreateReadOperationCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("9f37604b-7361-4e21-9abf-8c357922d9a0"),
				Name = @"ReadOperationCode",
				CreatedInSchemaUId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c"),
				ModifiedInSchemaUId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c"),
				CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0")
			};
		}

		protected virtual EntitySchemaColumn CreateReadWriteOperationCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("d92aec3b-cfd9-40c2-b613-b71690edbeb8"),
				Name = @"ReadWriteOperationCode",
				CreatedInSchemaUId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c"),
				ModifiedInSchemaUId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c"),
				CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIvyrY7L49OyjFyuk8DRTHSArtTcIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysSettingsRightsEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysSettingsRightsEventsProcessSchema() {
			var schema = new SysSettingsRightsEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysSettingsRights(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysSettingsRights_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysSettingsRightsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysSettingsRightsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c"));
		}

		#endregion

	}

	#endregion

	#region Class: SysSettingsRights

	/// <summary>
	/// SysSettingsRights.
	/// </summary>
	public class SysSettingsRights : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysSettingsRights(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysSettingsRights";
		}

		public SysSettingsRights(SysSettingsRights source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// SysSettingsCode.
		/// </summary>
		public string SysSettingsCode {
			get {
				return GetTypedColumnValue<string>("SysSettingsCode");
			}
			set {
				SetColumnValue("SysSettingsCode", value);
			}
		}

		/// <summary>
		/// ReadOperationCode.
		/// </summary>
		public string ReadOperationCode {
			get {
				return GetTypedColumnValue<string>("ReadOperationCode");
			}
			set {
				SetColumnValue("ReadOperationCode", value);
			}
		}

		/// <summary>
		/// ReadWriteOperationCode.
		/// </summary>
		public string ReadWriteOperationCode {
			get {
				return GetTypedColumnValue<string>("ReadWriteOperationCode");
			}
			set {
				SetColumnValue("ReadWriteOperationCode", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysSettingsRights_BaseEventsProcess(UserConnection);
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
			return new SysSettingsRights(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysSettingsRights_BaseEventsProcess

	/// <exclude/>
	public partial class SysSettingsRights_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysSettingsRights
	{

		public SysSettingsRights_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysSettingsRights_BaseEventsProcess";
			SchemaUId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c");
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

	#region Class: SysSettingsRights_BaseEventsProcess

	/// <exclude/>
	public class SysSettingsRights_BaseEventsProcess : SysSettingsRights_BaseEventsProcess<SysSettingsRights>
	{

		public SysSettingsRights_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysSettingsRights_BaseEventsProcess

	public partial class SysSettingsRights_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysSettingsRightsEventsProcessSchema

	/// <exclude/>
	public class SysSettingsRightsEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysSettingsRightsEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysSettingsRightsEventsProcessSchema(SysSettingsRightsEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysSettingsRights_BaseEventsProcess";
			UId = new Guid("66ed403c-1e84-4ca3-994a-8908609b7d69");
			CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
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
			ProcessSchemaLaneSet schemaLaneSet2_9a0649e10b244fff853a200521c2930a = CreateLaneSet2_9a0649e10b244fff853a200521c2930aLaneSet();
			LaneSets.Add(schemaLaneSet2_9a0649e10b244fff853a200521c2930a);
			ProcessSchemaLane schemaLane1_c7a6650920784135a20abd49d7600968 = CreateLane1_c7a6650920784135a20abd49d7600968Lane();
			schemaLaneSet2_9a0649e10b244fff853a200521c2930a.Lanes.Add(schemaLane1_c7a6650920784135a20abd49d7600968);
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_9a0649e10b244fff853a200521c2930aLaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_9a0649e10b244fff853a200521c2930a = new ProcessSchemaLaneSet(this) {
				UId = new Guid("9a0649e1-0b24-4fff-853a-200521c2930a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0"),
				CreatedInSchemaUId = new Guid("66ed403c-1e84-4ca3-994a-8908609b7d69"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("66ed403c-1e84-4ca3-994a-8908609b7d69"),
				Name = @"LaneSet2_9a0649e10b244fff853a200521c2930a",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_9a0649e10b244fff853a200521c2930a;
		}

		protected virtual ProcessSchemaLane CreateLane1_c7a6650920784135a20abd49d7600968Lane() {
			ProcessSchemaLane schemaLane1_c7a6650920784135a20abd49d7600968 = new ProcessSchemaLane(this) {
				UId = new Guid("c7a66509-2078-4135-a20a-bd49d7600968"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9a0649e1-0b24-4fff-853a-200521c2930a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0"),
				CreatedInSchemaUId = new Guid("66ed403c-1e84-4ca3-994a-8908609b7d69"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("66ed403c-1e84-4ca3-994a-8908609b7d69"),
				Name = @"Lane1_c7a6650920784135a20abd49d7600968",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1_c7a6650920784135a20abd49d7600968;
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
			return new SysSettingsRightsEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("66ed403c-1e84-4ca3-994a-8908609b7d69"));
		}

		#endregion

	}

	#endregion


	#region Class: SysSettingsRightsEventsProcess

	/// <exclude/>
	public class SysSettingsRightsEventsProcess : SysSettingsRights_BaseEventsProcess
	{

		public SysSettingsRightsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

