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

	#region Class: BaseFolderSchema

	/// <exclude/>
	[IsVirtual]
	public class BaseFolderSchema : Terrasoft.Configuration.BaseHierarchicalLookupSchema
	{

		#region Constructors: Public

		public BaseFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BaseFolderSchema(BaseFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BaseFolderSchema(BaseFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d602bf96-d029-4b07-9755-63c8f5cb5ed5");
			RealUId = new Guid("d602bf96-d029-4b07-9755-63c8f5cb5ed5");
			Name = "BaseFolder";
			ParentSchemaUId = new Guid("5a39bd7c-8880-456c-aaf7-7645ce114e62");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("e44c8807-bc0e-4415-b41c-2272c8fbdf42")) == null) {
				Columns.Add(CreateFolderTypeColumn());
			}
			if (Columns.FindByUId(new Guid("4d5be702-fa8a-4b6b-97d0-f666b99f108e")) == null) {
				Columns.Add(CreateSearchDataColumn());
			}
			if (Columns.FindByUId(new Guid("7194c633-a5a9-48cf-a96c-d8b548878b2f")) == null) {
				Columns.Add(CreateOptimizationTypeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateFolderTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e44c8807-bc0e-4415-b41c-2272c8fbdf42"),
				Name = @"FolderType",
				ReferenceSchemaUId = new Guid("6fce7412-b527-4e0d-94f1-4b4c02d8e69f"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d602bf96-d029-4b07-9755-63c8f5cb5ed5"),
				ModifiedInSchemaUId = new Guid("d602bf96-d029-4b07-9755-63c8f5cb5ed5"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"9dc5f6e6-2a61-4de8-a059-de30f4e74f24"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateSearchDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("4d5be702-fa8a-4b6b-97d0-f666b99f108e"),
				Name = @"SearchData",
				CreatedInSchemaUId = new Guid("d602bf96-d029-4b07-9755-63c8f5cb5ed5"),
				ModifiedInSchemaUId = new Guid("d602bf96-d029-4b07-9755-63c8f5cb5ed5"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateOptimizationTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("7194c633-a5a9-48cf-a96c-d8b548878b2f"),
				Name = @"OptimizationType",
				CreatedInSchemaUId = new Guid("d602bf96-d029-4b07-9755-63c8f5cb5ed5"),
				ModifiedInSchemaUId = new Guid("d602bf96-d029-4b07-9755-63c8f5cb5ed5"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseFolderEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateBaseFolderEventsProcessSchema() {
			var schema = new BaseFolderEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BaseFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BaseFolder_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BaseFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BaseFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d602bf96-d029-4b07-9755-63c8f5cb5ed5"));
		}

		#endregion

	}

	#endregion

	#region Class: BaseFolder

	/// <summary>
	/// Base folder.
	/// </summary>
	public class BaseFolder : Terrasoft.Configuration.BaseHierarchicalLookup
	{

		#region Constructors: Public

		public BaseFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BaseFolder";
		}

		public BaseFolder(BaseFolder source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid FolderTypeId {
			get {
				return GetTypedColumnValue<Guid>("FolderTypeId");
			}
			set {
				SetColumnValue("FolderTypeId", value);
				_folderType = null;
			}
		}

		/// <exclude/>
		public string FolderTypeName {
			get {
				return GetTypedColumnValue<string>("FolderTypeName");
			}
			set {
				SetColumnValue("FolderTypeName", value);
				if (_folderType != null) {
					_folderType.Name = value;
				}
			}
		}

		private FolderType _folderType;
		/// <summary>
		/// Folder type.
		/// </summary>
		public FolderType FolderType {
			get {
				return _folderType ??
					(_folderType = LookupColumnEntities.GetEntity("FolderType") as FolderType);
			}
		}

		/// <summary>
		/// Optimization type.
		/// </summary>
		public int OptimizationType {
			get {
				return GetTypedColumnValue<int>("OptimizationType");
			}
			set {
				SetColumnValue("OptimizationType", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BaseFolder_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BaseFolderDeleted", e);
			Deleting += (s, e) => ThrowEvent("BaseFolderDeleting", e);
			Inserted += (s, e) => ThrowEvent("BaseFolderInserted", e);
			Inserting += (s, e) => ThrowEvent("BaseFolderInserting", e);
			Saved += (s, e) => ThrowEvent("BaseFolderSaved", e);
			Saving += (s, e) => ThrowEvent("BaseFolderSaving", e);
			Validating += (s, e) => ThrowEvent("BaseFolderValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: BaseFolder_BaseEventsProcess

	/// <exclude/>
	public partial class BaseFolder_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseHierarchicalLookup_BaseEventsProcess<TEntity> where TEntity : BaseFolder
	{

		public BaseFolder_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseFolder_BaseEventsProcess";
			SchemaUId = new Guid("d602bf96-d029-4b07-9755-63c8f5cb5ed5");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d602bf96-d029-4b07-9755-63c8f5cb5ed5");
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

	#region Class: BaseFolder_BaseEventsProcess

	/// <exclude/>
	public class BaseFolder_BaseEventsProcess : BaseFolder_BaseEventsProcess<BaseFolder>
	{

		public BaseFolder_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseFolder_BaseEventsProcess

	public partial class BaseFolder_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void CheckCanManageLookups() {
			return;
		}

		#endregion

	}

	#endregion

	#region Class: BaseFolderEventsProcessSchema

	/// <exclude/>
	public class BaseFolderEventsProcessSchema : Terrasoft.Configuration.BaseHierarchicalLookupEventsProcessSchema
	{

		#region Constructors: Public

		public BaseFolderEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseFolderEventsProcessSchema(BaseFolderEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseFolder_BaseEventsProcess";
			UId = new Guid("cfd53d66-8891-4a3e-9c4f-4b8970e3e405");
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
			ProcessSchemaLaneSet schemaLaneSet2_c3e8f192cc304669a6071645c059196e = CreateLaneSet2_c3e8f192cc304669a6071645c059196eLaneSet();
			LaneSets.Add(schemaLaneSet2_c3e8f192cc304669a6071645c059196e);
			ProcessSchemaLane schemaLane1_713628351bbe4a029470c26f777cd5e2 = CreateLane1_713628351bbe4a029470c26f777cd5e2Lane();
			schemaLaneSet2_c3e8f192cc304669a6071645c059196e.Lanes.Add(schemaLane1_713628351bbe4a029470c26f777cd5e2);
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_c3e8f192cc304669a6071645c059196eLaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_c3e8f192cc304669a6071645c059196e = new ProcessSchemaLaneSet(this) {
				UId = new Guid("c3e8f192-cc30-4669-a607-1645c059196e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("5c73c17e-d296-43d5-8c44-3859337f6bc6"),
				CreatedInPackageId = new Guid("3e5bd282-4d8c-413e-b456-f52e075a6aaa"),
				CreatedInSchemaUId = new Guid("cfd53d66-8891-4a3e-9c4f-4b8970e3e405"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("cfd53d66-8891-4a3e-9c4f-4b8970e3e405"),
				Name = @"LaneSet2_c3e8f192cc304669a6071645c059196e",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_c3e8f192cc304669a6071645c059196e;
		}

		protected virtual ProcessSchemaLane CreateLane1_713628351bbe4a029470c26f777cd5e2Lane() {
			ProcessSchemaLane schemaLane1_713628351bbe4a029470c26f777cd5e2 = new ProcessSchemaLane(this) {
				UId = new Guid("71362835-1bbe-4a02-9470-c26f777cd5e2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c3e8f192-cc30-4669-a607-1645c059196e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("3e5bd282-4d8c-413e-b456-f52e075a6aaa"),
				CreatedInSchemaUId = new Guid("cfd53d66-8891-4a3e-9c4f-4b8970e3e405"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("cfd53d66-8891-4a3e-9c4f-4b8970e3e405"),
				Name = @"Lane1_713628351bbe4a029470c26f777cd5e2",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1_713628351bbe4a029470c26f777cd5e2;
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

		protected override SchemaMethod CreateCheckCanManageLookupsMethod() {
			SchemaMethod method = base.CreateCheckCanManageLookupsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,179,6,0,7,133,17,243,7,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseFolderEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cfd53d66-8891-4a3e-9c4f-4b8970e3e405"));
		}

		#endregion

	}

	#endregion


	#region Class: BaseFolderEventsProcess

	/// <exclude/>
	public class BaseFolderEventsProcess : BaseFolder_BaseEventsProcess
	{

		public BaseFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

