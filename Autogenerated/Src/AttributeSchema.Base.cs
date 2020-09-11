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

	#region Class: AttributeSchema

	/// <exclude/>
	public class AttributeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public AttributeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AttributeSchema(AttributeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AttributeSchema(AttributeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d37a89fc-7355-4900-aba8-94c22235a9fe");
			RealUId = new Guid("d37a89fc-7355-4900-aba8-94c22235a9fe");
			Name = "Attribute";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("1eaec39e-dbba-4241-80e6-084c8a8bf98d")) == null) {
				Columns.Add(CreateOwnerSchemaColumn());
			}
			if (Columns.FindByUId(new Guid("0c037038-1544-42c9-a543-22bc346ad772")) == null) {
				Columns.Add(CreateCaptionColumn());
			}
			if (Columns.FindByUId(new Guid("232c4528-76b5-4385-8e09-e19b66404db9")) == null) {
				Columns.Add(CreateValueTypeColumn());
			}
			if (Columns.FindByUId(new Guid("6ec5a0d1-c38b-4da8-80b7-25114b8736d5")) == null) {
				Columns.Add(CreateReferenceSchemaColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("d37a89fc-7355-4900-aba8-94c22235a9fe");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("d37a89fc-7355-4900-aba8-94c22235a9fe");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected virtual EntitySchemaColumn CreateOwnerSchemaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1eaec39e-dbba-4241-80e6-084c8a8bf98d"),
				Name = @"OwnerSchema",
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d37a89fc-7355-4900-aba8-94c22235a9fe"),
				ModifiedInSchemaUId = new Guid("d37a89fc-7355-4900-aba8-94c22235a9fe"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("0c037038-1544-42c9-a543-22bc346ad772"),
				Name = @"Caption",
				CreatedInSchemaUId = new Guid("d37a89fc-7355-4900-aba8-94c22235a9fe"),
				ModifiedInSchemaUId = new Guid("d37a89fc-7355-4900-aba8-94c22235a9fe"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateValueTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("232c4528-76b5-4385-8e09-e19b66404db9"),
				Name = @"ValueType",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("d37a89fc-7355-4900-aba8-94c22235a9fe"),
				ModifiedInSchemaUId = new Guid("d37a89fc-7355-4900-aba8-94c22235a9fe"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateReferenceSchemaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6ec5a0d1-c38b-4da8-80b7-25114b8736d5"),
				Name = @"ReferenceSchema",
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d37a89fc-7355-4900-aba8-94c22235a9fe"),
				ModifiedInSchemaUId = new Guid("d37a89fc-7355-4900-aba8-94c22235a9fe"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAttributeEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateAttributeEventsProcessSchema() {
			var schema = new AttributeEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Attribute(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Attribute_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AttributeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AttributeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d37a89fc-7355-4900-aba8-94c22235a9fe"));
		}

		#endregion

	}

	#endregion

	#region Class: Attribute

	/// <summary>
	/// Checkbox.
	/// </summary>
	public class Attribute : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public Attribute(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Attribute";
		}

		public Attribute(Attribute source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid OwnerSchemaId {
			get {
				return GetTypedColumnValue<Guid>("OwnerSchemaId");
			}
			set {
				SetColumnValue("OwnerSchemaId", value);
				_ownerSchema = null;
			}
		}

		/// <exclude/>
		public string OwnerSchemaCaption {
			get {
				return GetTypedColumnValue<string>("OwnerSchemaCaption");
			}
			set {
				SetColumnValue("OwnerSchemaCaption", value);
				if (_ownerSchema != null) {
					_ownerSchema.Caption = value;
				}
			}
		}

		private SysSchema _ownerSchema;
		/// <summary>
		/// Schema.
		/// </summary>
		public SysSchema OwnerSchema {
			get {
				return _ownerSchema ??
					(_ownerSchema = LookupColumnEntities.GetEntity("OwnerSchema") as SysSchema);
			}
		}

		/// <summary>
		/// Title.
		/// </summary>
		public string Caption {
			get {
				return GetTypedColumnValue<string>("Caption");
			}
			set {
				SetColumnValue("Caption", value);
			}
		}

		/// <summary>
		/// Data type.
		/// </summary>
		public Guid ValueType {
			get {
				return GetTypedColumnValue<Guid>("ValueType");
			}
			set {
				SetColumnValue("ValueType", value);
			}
		}

		/// <exclude/>
		public Guid ReferenceSchemaId {
			get {
				return GetTypedColumnValue<Guid>("ReferenceSchemaId");
			}
			set {
				SetColumnValue("ReferenceSchemaId", value);
				_referenceSchema = null;
			}
		}

		/// <exclude/>
		public string ReferenceSchemaCaption {
			get {
				return GetTypedColumnValue<string>("ReferenceSchemaCaption");
			}
			set {
				SetColumnValue("ReferenceSchemaCaption", value);
				if (_referenceSchema != null) {
					_referenceSchema.Caption = value;
				}
			}
		}

		private SysSchema _referenceSchema;
		/// <summary>
		/// Lookup.
		/// </summary>
		public SysSchema ReferenceSchema {
			get {
				return _referenceSchema ??
					(_referenceSchema = LookupColumnEntities.GetEntity("ReferenceSchema") as SysSchema);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Attribute_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AttributeDeleted", e);
			Deleting += (s, e) => ThrowEvent("AttributeDeleting", e);
			Inserted += (s, e) => ThrowEvent("AttributeInserted", e);
			Inserting += (s, e) => ThrowEvent("AttributeInserting", e);
			Saved += (s, e) => ThrowEvent("AttributeSaved", e);
			Saving += (s, e) => ThrowEvent("AttributeSaving", e);
			Validating += (s, e) => ThrowEvent("AttributeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Attribute(this);
		}

		#endregion

	}

	#endregion

	#region Class: Attribute_BaseEventsProcess

	/// <exclude/>
	public partial class Attribute_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : Attribute
	{

		public Attribute_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Attribute_BaseEventsProcess";
			SchemaUId = new Guid("d37a89fc-7355-4900-aba8-94c22235a9fe");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d37a89fc-7355-4900-aba8-94c22235a9fe");
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

	#region Class: Attribute_BaseEventsProcess

	/// <exclude/>
	public class Attribute_BaseEventsProcess : Attribute_BaseEventsProcess<Attribute>
	{

		public Attribute_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Attribute_BaseEventsProcess

	public partial class Attribute_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: AttributeEventsProcessSchema

	/// <exclude/>
	public class AttributeEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public AttributeEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AttributeEventsProcessSchema(AttributeEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Attribute_BaseEventsProcess";
			UId = new Guid("a84232e3-e318-450f-9b88-ab744ff404fe");
			CreatedInPackageId = new Guid("b466acb1-8049-4776-835c-a1e006a6057c");
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
			return new AttributeEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a84232e3-e318-450f-9b88-ab744ff404fe"));
		}

		#endregion

	}

	#endregion


	#region Class: AttributeEventsProcess

	/// <exclude/>
	public class AttributeEventsProcess : Attribute_BaseEventsProcess
	{

		public AttributeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

