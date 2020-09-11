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

	#region Class: RelationTypeSchema

	/// <exclude/>
	public class RelationTypeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public RelationTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public RelationTypeSchema(RelationTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public RelationTypeSchema(RelationTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23");
			RealUId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23");
			Name = "RelationType";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("f4e69913-fe63-4238-bf3c-1107f516ed75")) == null) {
				Columns.Add(CreateForContactContactColumn());
			}
			if (Columns.FindByUId(new Guid("a4671b71-f200-4c14-b7fa-2cb2fe5492b4")) == null) {
				Columns.Add(CreateForAccountContactColumn());
			}
			if (Columns.FindByUId(new Guid("09ad639a-d97b-457f-89a6-7a173badefb5")) == null) {
				Columns.Add(CreateForContactAccountColumn());
			}
			if (Columns.FindByUId(new Guid("6838568d-88cd-402c-bddf-c798342238f0")) == null) {
				Columns.Add(CreateForAccountAccountColumn());
			}
			if (Columns.FindByUId(new Guid("46e3c8e9-74e4-4da6-af3f-06ec44c5dc73")) == null) {
				Columns.Add(CreateReverseRelationTypeColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected virtual EntitySchemaColumn CreateForContactContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("f4e69913-fe63-4238-bf3c-1107f516ed75"),
				Name = @"ForContactContact",
				CreatedInSchemaUId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23"),
				ModifiedInSchemaUId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateForAccountContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("a4671b71-f200-4c14-b7fa-2cb2fe5492b4"),
				Name = @"ForAccountContact",
				CreatedInSchemaUId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23"),
				ModifiedInSchemaUId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateForContactAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("09ad639a-d97b-457f-89a6-7a173badefb5"),
				Name = @"ForContactAccount",
				CreatedInSchemaUId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23"),
				ModifiedInSchemaUId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateForAccountAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("6838568d-88cd-402c-bddf-c798342238f0"),
				Name = @"ForAccountAccount",
				CreatedInSchemaUId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23"),
				ModifiedInSchemaUId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateReverseRelationTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("46e3c8e9-74e4-4da6-af3f-06ec44c5dc73"),
				Name = @"ReverseRelationType",
				ReferenceSchemaUId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23"),
				CreatedInSchemaUId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23"),
				ModifiedInSchemaUId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateRelationTypeEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateRelationTypeEventsProcessSchema() {
			var schema = new RelationTypeEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new RelationType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new RelationType_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new RelationTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new RelationTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23"));
		}

		#endregion

	}

	#endregion

	#region Class: RelationType

	/// <summary>
	/// Relationship type.
	/// </summary>
	public class RelationType : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public RelationType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "RelationType";
		}

		public RelationType(RelationType source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Contact-Contact.
		/// </summary>
		public bool ForContactContact {
			get {
				return GetTypedColumnValue<bool>("ForContactContact");
			}
			set {
				SetColumnValue("ForContactContact", value);
			}
		}

		/// <summary>
		/// Account-Contact.
		/// </summary>
		public bool ForAccountContact {
			get {
				return GetTypedColumnValue<bool>("ForAccountContact");
			}
			set {
				SetColumnValue("ForAccountContact", value);
			}
		}

		/// <summary>
		/// Contact-Account.
		/// </summary>
		public bool ForContactAccount {
			get {
				return GetTypedColumnValue<bool>("ForContactAccount");
			}
			set {
				SetColumnValue("ForContactAccount", value);
			}
		}

		/// <summary>
		/// Account-Account.
		/// </summary>
		public bool ForAccountAccount {
			get {
				return GetTypedColumnValue<bool>("ForAccountAccount");
			}
			set {
				SetColumnValue("ForAccountAccount", value);
			}
		}

		/// <exclude/>
		public Guid ReverseRelationTypeId {
			get {
				return GetTypedColumnValue<Guid>("ReverseRelationTypeId");
			}
			set {
				SetColumnValue("ReverseRelationTypeId", value);
				_reverseRelationType = null;
			}
		}

		/// <exclude/>
		public string ReverseRelationTypeName {
			get {
				return GetTypedColumnValue<string>("ReverseRelationTypeName");
			}
			set {
				SetColumnValue("ReverseRelationTypeName", value);
				if (_reverseRelationType != null) {
					_reverseRelationType.Name = value;
				}
			}
		}

		private RelationType _reverseRelationType;
		/// <summary>
		/// Inverse relationship.
		/// </summary>
		public RelationType ReverseRelationType {
			get {
				return _reverseRelationType ??
					(_reverseRelationType = LookupColumnEntities.GetEntity("ReverseRelationType") as RelationType);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new RelationType_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("RelationTypeDeleted", e);
			Deleting += (s, e) => ThrowEvent("RelationTypeDeleting", e);
			Inserted += (s, e) => ThrowEvent("RelationTypeInserted", e);
			Inserting += (s, e) => ThrowEvent("RelationTypeInserting", e);
			Saved += (s, e) => ThrowEvent("RelationTypeSaved", e);
			Saving += (s, e) => ThrowEvent("RelationTypeSaving", e);
			Validating += (s, e) => ThrowEvent("RelationTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new RelationType(this);
		}

		#endregion

	}

	#endregion

	#region Class: RelationType_BaseEventsProcess

	/// <exclude/>
	public partial class RelationType_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : RelationType
	{

		public RelationType_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "RelationType_BaseEventsProcess";
			SchemaUId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23");
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

	#region Class: RelationType_BaseEventsProcess

	/// <exclude/>
	public class RelationType_BaseEventsProcess : RelationType_BaseEventsProcess<RelationType>
	{

		public RelationType_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: RelationType_BaseEventsProcess

	public partial class RelationType_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: RelationTypeEventsProcessSchema

	/// <exclude/>
	public class RelationTypeEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public RelationTypeEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public RelationTypeEventsProcessSchema(RelationTypeEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "RelationType_BaseEventsProcess";
			UId = new Guid("3d4c14fe-74db-46ba-8ff6-2ad9e998929b");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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
			return new RelationTypeEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3d4c14fe-74db-46ba-8ff6-2ad9e998929b"));
		}

		#endregion

	}

	#endregion


	#region Class: RelationTypeEventsProcess

	/// <exclude/>
	public class RelationTypeEventsProcess : RelationType_BaseEventsProcess
	{

		public RelationTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

