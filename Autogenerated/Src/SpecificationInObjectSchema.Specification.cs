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

	#region Class: SpecificationInObjectSchema

	/// <exclude/>
	public class SpecificationInObjectSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SpecificationInObjectSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecificationInObjectSchema(SpecificationInObjectSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecificationInObjectSchema(SpecificationInObjectSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			RealUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			Name = "SpecificationInObject";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("8d363901-e536-4e02-82ef-7921ad3ad215")) == null) {
				Columns.Add(CreateStringValueColumn());
			}
			if (Columns.FindByUId(new Guid("985cfb03-dc38-4589-97e8-1663035e12cb")) == null) {
				Columns.Add(CreateIntValueColumn());
			}
			if (Columns.FindByUId(new Guid("1492aef9-5567-4ce2-b308-5b7d581aebb7")) == null) {
				Columns.Add(CreateFloatValueColumn());
			}
			if (Columns.FindByUId(new Guid("43656d13-5970-40fa-a6cc-b9d34b1d3636")) == null) {
				Columns.Add(CreateBooleanValueColumn());
			}
			if (Columns.FindByUId(new Guid("6adaf528-b0c1-4e74-a20f-70933fc06ddd")) == null) {
				Columns.Add(CreateSpecificationColumn());
			}
			if (Columns.FindByUId(new Guid("e81eee9a-1b68-4318-9a9f-20dadd47c823")) == null) {
				Columns.Add(CreateListItemValueColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			column.CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			column.CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			column.CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			column.CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			column.CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			column.CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
			return column;
		}

		protected virtual EntitySchemaColumn CreateStringValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("8d363901-e536-4e02-82ef-7921ad3ad215"),
				Name = @"StringValue",
				CreatedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				ModifiedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			};
		}

		protected virtual EntitySchemaColumn CreateIntValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("985cfb03-dc38-4589-97e8-1663035e12cb"),
				Name = @"IntValue",
				CreatedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				ModifiedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			};
		}

		protected virtual EntitySchemaColumn CreateFloatValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("1492aef9-5567-4ce2-b308-5b7d581aebb7"),
				Name = @"FloatValue",
				CreatedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				ModifiedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			};
		}

		protected virtual EntitySchemaColumn CreateBooleanValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("43656d13-5970-40fa-a6cc-b9d34b1d3636"),
				Name = @"BooleanValue",
				CreatedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				ModifiedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			};
		}

		protected virtual EntitySchemaColumn CreateSpecificationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6adaf528-b0c1-4e74-a20f-70933fc06ddd"),
				Name = @"Specification",
				ReferenceSchemaUId = new Guid("ec3cebc4-ea18-40ea-9b0f-e348570481ef"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				ModifiedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			};
		}

		protected virtual EntitySchemaColumn CreateListItemValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e81eee9a-1b68-4318-9a9f-20dadd47c823"),
				Name = @"ListItemValue",
				ReferenceSchemaUId = new Guid("99bb0a66-4041-4261-a6f2-f37806ba3f65"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				ModifiedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSpecificationInObjectEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSpecificationInObjectEventsProcessSchema() {
			var schema = new SpecificationInObjectEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SpecificationInObject(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SpecificationInObject_SpecificationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecificationInObjectSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecificationInObjectSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"));
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationInObject

	/// <summary>
	/// Feature in object.
	/// </summary>
	public class SpecificationInObject : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SpecificationInObject(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SpecificationInObject";
		}

		public SpecificationInObject(SpecificationInObject source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Value.
		/// </summary>
		public string StringValue {
			get {
				return GetTypedColumnValue<string>("StringValue");
			}
			set {
				SetColumnValue("StringValue", value);
			}
		}

		/// <summary>
		/// Value (integer).
		/// </summary>
		public int IntValue {
			get {
				return GetTypedColumnValue<int>("IntValue");
			}
			set {
				SetColumnValue("IntValue", value);
			}
		}

		/// <summary>
		/// Value (decimal).
		/// </summary>
		public Decimal FloatValue {
			get {
				return GetTypedColumnValue<Decimal>("FloatValue");
			}
			set {
				SetColumnValue("FloatValue", value);
			}
		}

		/// <summary>
		/// Value (Boolean).
		/// </summary>
		public bool BooleanValue {
			get {
				return GetTypedColumnValue<bool>("BooleanValue");
			}
			set {
				SetColumnValue("BooleanValue", value);
			}
		}

		/// <exclude/>
		public Guid SpecificationId {
			get {
				return GetTypedColumnValue<Guid>("SpecificationId");
			}
			set {
				SetColumnValue("SpecificationId", value);
				_specification = null;
			}
		}

		/// <exclude/>
		public string SpecificationName {
			get {
				return GetTypedColumnValue<string>("SpecificationName");
			}
			set {
				SetColumnValue("SpecificationName", value);
				if (_specification != null) {
					_specification.Name = value;
				}
			}
		}

		private Specification _specification;
		/// <summary>
		/// Feature.
		/// </summary>
		public Specification Specification {
			get {
				return _specification ??
					(_specification = LookupColumnEntities.GetEntity("Specification") as Specification);
			}
		}

		/// <exclude/>
		public Guid ListItemValueId {
			get {
				return GetTypedColumnValue<Guid>("ListItemValueId");
			}
			set {
				SetColumnValue("ListItemValueId", value);
				_listItemValue = null;
			}
		}

		/// <exclude/>
		public string ListItemValueName {
			get {
				return GetTypedColumnValue<string>("ListItemValueName");
			}
			set {
				SetColumnValue("ListItemValueName", value);
				if (_listItemValue != null) {
					_listItemValue.Name = value;
				}
			}
		}

		private SpecificationListItem _listItemValue;
		/// <summary>
		/// Value (drop-down list).
		/// </summary>
		public SpecificationListItem ListItemValue {
			get {
				return _listItemValue ??
					(_listItemValue = LookupColumnEntities.GetEntity("ListItemValue") as SpecificationListItem);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SpecificationInObject_SpecificationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SpecificationInObjectDeleted", e);
			Inserting += (s, e) => ThrowEvent("SpecificationInObjectInserting", e);
			Saving += (s, e) => ThrowEvent("SpecificationInObjectSaving", e);
			Validating += (s, e) => ThrowEvent("SpecificationInObjectValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SpecificationInObject(this);
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationInObject_SpecificationEventsProcess

	/// <exclude/>
	public partial class SpecificationInObject_SpecificationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SpecificationInObject
	{

		public SpecificationInObject_SpecificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecificationInObject_SpecificationEventsProcess";
			SchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _savingEventSubProcess;
		public ProcessFlowElement SavingEventSubProcess {
			get {
				return _savingEventSubProcess ?? (_savingEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SavingEventSubProcess",
					SchemaElementUId = new Guid("6e056378-b8f9-44bd-acc1-750e07f572be"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _updateStringValueScriptTask;
		public ProcessScriptTask UpdateStringValueScriptTask {
			get {
				return _updateStringValueScriptTask ?? (_updateStringValueScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdateStringValueScriptTask",
					SchemaElementUId = new Guid("8de824ce-68cc-4ccb-89dc-5e28f6ca65c2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateStringValueScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _specificationInObjectSaving;
		public ProcessFlowElement SpecificationInObjectSaving {
			get {
				return _specificationInObjectSaving ?? (_specificationInObjectSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SpecificationInObjectSaving",
					SchemaElementUId = new Guid("25a044df-358d-4a85-917e-b23df6b34944"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private LocalizableString _yes;
		public LocalizableString Yes {
			get {
				return _yes ?? (_yes = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.Yes.Value"));
			}
		}

		private LocalizableString _no;
		public LocalizableString No {
			get {
				return _no ?? (_no = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.No.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SavingEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SavingEventSubProcess };
			FlowElements[UpdateStringValueScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateStringValueScriptTask };
			FlowElements[SpecificationInObjectSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { SpecificationInObjectSaving };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SavingEventSubProcess":
						break;
					case "UpdateStringValueScriptTask":
						break;
					case "SpecificationInObjectSaving":
						e.Context.QueueTasks.Enqueue("UpdateStringValueScriptTask");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SpecificationInObjectSaving");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SavingEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "UpdateStringValueScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateStringValueScriptTask";
					result = UpdateStringValueScriptTask.Execute(context, UpdateStringValueScriptTaskExecute);
					break;
				case "SpecificationInObjectSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "SpecificationInObjectSaving";
					result = SpecificationInObjectSaving.Execute(context);
					break;
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

		public virtual bool UpdateStringValueScriptTaskExecute(ProcessExecutingContext context) {
			return UpdateStringValueMethod();
			/*
			// Convert specification value to StringValue
			
			var specificationTypeId = string.Empty;
			var specificationValue = string.Empty;
			
			if (Entity.SpecificationId == Guid.Empty) {
				return true;
			};
			
			var esqResult = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Specification");
			esqResult.AddColumn("Type");
			var specEntity = esqResult.GetEntity(UserConnection, Entity.SpecificationId);
			specificationTypeId = specEntity.GetTypedColumnValue<string>("TypeId");
			
			// if not string value
			if (specificationTypeId != "7aad419a-9e7a-4785-8d13-c7ff1402e13d") {
				Entity.SetColumnValue("StringValue", string.Empty);
			};
			
			switch(specificationTypeId) {
				// string type
				case ("7aad419a-9e7a-4785-8d13-c7ff1402e13d"):
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("ListItemValue", null);
					return true;
				// int type
				case ("2212241a-71eb-468b-a3d5-c0f39dfe51c9"):
					specificationValue = Entity.GetTypedColumnValue<string>("IntValue");
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("ListItemValue", null);
					break;
				// float type
				case ("beb46531-4f29-452c-be18-1ed5f1aa8b80"):
					specificationValue = Entity.GetTypedColumnValue<string>("FloatValue");
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("ListItemValue", null);
					break;
				// boolean type
				case ("359e0e35-bb39-4f07-9b9f-aec6ad076828"):
					if (Entity.GetTypedColumnValue<bool>("BooleanValue")) {
						specificationValue = Yes.ToString();
					} else {
						specificationValue = No.ToString();
					}
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("ListItemValue", null);
					break;
				// list item value
				case ("ecf578a0-4b4d-40e6-909c-39af2a798d32"):
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("BooleanValue", false);
					if (Entity.ListItemValueId != Guid.Empty ) {
						specificationValue = Entity.ListItemValueName;
					} 
					break;
				default: return true;
			};
			
			Entity.SetColumnValue("StringValue", specificationValue);
			
			return true;
			*/
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SpecificationInObjectSaving":
							if (ActivatedEventElements.Contains("SpecificationInObjectSaving")) {
							context.QueueTasks.Enqueue("SpecificationInObjectSaving");
						}
						break;
			}
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

	#region Class: SpecificationInObject_SpecificationEventsProcess

	/// <exclude/>
	public class SpecificationInObject_SpecificationEventsProcess : SpecificationInObject_SpecificationEventsProcess<SpecificationInObject>
	{

		public SpecificationInObject_SpecificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SpecificationInObject_SpecificationEventsProcess

	public partial class SpecificationInObject_SpecificationEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual bool UpdateStringValueMethod() {
			// Convert specification value to StringValue
			
			var specificationTypeId = string.Empty;
			var specificationValue = string.Empty;
			
			if (Entity.SpecificationId == Guid.Empty) {
				return true;
			};
			
			var esqResult = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Specification");
			esqResult.AddColumn("Type");
			var specEntity = esqResult.GetEntity(UserConnection, Entity.SpecificationId);
			specificationTypeId = specEntity.GetTypedColumnValue<string>("TypeId");
			
			// if not string value
			if (specificationTypeId != "7aad419a-9e7a-4785-8d13-c7ff1402e13d") {
				Entity.SetColumnValue("StringValue", string.Empty);
			};
			
			switch(specificationTypeId) {
				// string type
				case ("7aad419a-9e7a-4785-8d13-c7ff1402e13d"):
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("ListItemValueId", null);
					return true;
				// int type
				case ("2212241a-71eb-468b-a3d5-c0f39dfe51c9"):
					specificationValue = Entity.GetTypedColumnValue<string>("IntValue");
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("ListItemValueId", null);
					break;
				// float type
				case ("beb46531-4f29-452c-be18-1ed5f1aa8b80"):
					specificationValue = Entity.GetTypedColumnValue<string>("FloatValue");
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("ListItemValueId", null);
					break;
				// boolean type
				case ("359e0e35-bb39-4f07-9b9f-aec6ad076828"):
					if (Entity.GetTypedColumnValue<bool>("BooleanValue")) {
						specificationValue = Yes.ToString();
					} else {
						specificationValue = No.ToString();
					}
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("ListItemValueId", null);
					break;
				// list item value
				case ("ecf578a0-4b4d-40e6-909c-39af2a798d32"):
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("BooleanValue", false);
					if (Entity.ListItemValueId != Guid.Empty ) {
						var listItemResult = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SpecificationListItem");
						listItemResult.AddColumn("Name");
						var listItem = listItemResult.GetEntity(UserConnection, Entity.ListItemValueId);
						specificationValue = listItem.GetTypedColumnValue<string>("Name");
					} 
					break;
				default: return true;
			};
			
			Entity.SetColumnValue("StringValue", specificationValue);
			
			return true;
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationInObjectEventsProcessSchema

	/// <exclude/>
	public class SpecificationInObjectEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SpecificationInObjectEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SpecificationInObjectEventsProcessSchema(SpecificationInObjectEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SpecificationInObject_SpecificationEventsProcess";
			UId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994");
			CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
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
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess savingeventsubprocess = CreateSavingEventSubProcessEventSubProcess();
			FlowElements.Add(savingeventsubprocess);
			ProcessSchemaScriptTask updatestringvaluescripttask = CreateUpdateStringValueScriptTaskScriptTask();
			savingeventsubprocess.FlowElements.Add(updatestringvaluescripttask);
			ProcessSchemaStartMessageEvent specificationinobjectsaving = CreateSpecificationInObjectSavingStartMessageEvent();
			savingeventsubprocess.FlowElements.Add(specificationinobjectsaving);
			FlowElements.Add(CreateSpecificationInObjectSavingSequenceFlowSequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateYesLocalizableString());
			LocalizableStrings.Add(CreateNoLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateYesLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1fd70e5d-493a-45f7-8c5d-75afb580fc3e"),
				Name = "Yes",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e"),
				CreatedInSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				ModifiedInSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNoLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9f60f57e-e8fc-40b5-90a9-9305a302785b"),
				Name = "No",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e"),
				CreatedInSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				ModifiedInSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSpecificationInObjectSavingSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SpecificationInObjectSavingSequenceFlow",
				UId = new Guid("6a4f925d-69dd-4093-9b01-df4bb625b54f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e"),
				CreatedInSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				CurveCenterPosition = new Point(500, 85),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("25a044df-358d-4a85-917e-b23df6b34944"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8de824ce-68cc-4ccb-89dc-5e28f6ca65c2"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("3f570021-1b1b-41a7-aab8-04e4f2a620b1"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e"),
				CreatedInSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(750, 184),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("e7087fbf-644c-4a16-a827-222d54474b51"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("3f570021-1b1b-41a7-aab8-04e4f2a620b1"),
				CreatedInOwnerSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e"),
				CreatedInSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(721, 184),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSavingEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSavingEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6e056378-b8f9-44bd-acc1-750e07f572be"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e7087fbf-644c-4a16-a827-222d54474b51"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e"),
				CreatedInSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				Name = @"SavingEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(406, 161),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSavingEventSubProcess;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateStringValueScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8de824ce-68cc-4ccb-89dc-5e28f6ca65c2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6e056378-b8f9-44bd-acc1-750e07f572be"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e"),
				CreatedInSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				Name = @"UpdateStringValueScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(238, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,149,95,79,219,48,20,197,159,87,169,223,193,235,83,138,112,201,223,38,129,129,180,33,134,42,13,164,13,152,180,199,155,248,26,162,165,78,151,56,160,106,226,187,207,137,147,146,150,180,170,180,77,226,161,47,238,185,199,231,254,174,99,231,40,203,92,144,187,5,3,137,55,50,79,196,253,119,72,75,188,66,249,144,49,99,124,50,28,28,29,168,223,17,57,207,196,35,230,146,20,11,140,19,158,196,32,147,76,144,199,74,76,100,70,58,181,195,193,112,240,8,249,186,242,118,185,192,25,35,167,164,168,133,147,139,249,66,46,79,122,132,181,197,107,221,112,144,112,98,92,8,153,200,229,228,166,91,80,185,158,146,203,50,97,90,60,38,191,135,131,119,185,110,76,230,37,170,234,231,147,54,20,22,191,190,97,81,166,82,109,33,240,137,104,199,155,248,1,231,240,181,196,124,105,220,21,152,171,102,5,198,149,251,164,43,184,2,1,247,152,31,146,209,90,130,81,133,105,101,60,249,200,216,121,150,150,115,97,140,170,174,235,127,219,54,181,155,218,251,69,126,137,82,175,110,236,124,72,250,187,173,236,182,160,93,109,80,153,86,203,77,144,154,233,7,77,244,76,167,154,177,58,87,61,90,69,86,100,178,33,174,71,170,113,247,109,243,254,148,140,124,0,230,90,33,208,16,125,160,174,31,120,52,96,150,67,99,159,115,203,53,109,180,28,101,95,207,161,237,1,101,39,138,49,234,28,151,209,225,218,172,199,171,113,21,79,137,140,31,250,66,104,107,149,188,137,44,213,170,90,136,161,64,98,236,153,238,88,21,108,75,55,19,178,141,102,86,121,182,10,63,167,25,188,72,39,187,197,159,178,44,69,16,173,156,67,90,224,206,130,47,73,33,103,18,231,109,133,40,211,84,23,172,159,238,138,68,34,228,6,6,219,182,108,219,181,128,250,22,70,212,157,6,17,5,135,121,52,54,185,19,50,142,158,21,135,13,134,222,15,112,159,147,180,2,245,38,41,69,57,194,207,134,15,175,50,108,16,138,48,114,167,158,99,81,151,219,33,117,61,59,166,17,90,1,181,144,121,220,2,8,162,192,252,91,66,157,222,119,118,177,247,145,251,79,124,34,109,187,65,200,241,66,52,209,241,104,20,57,138,16,55,125,26,70,33,167,128,241,20,152,233,79,3,59,104,8,117,174,231,62,32,149,255,217,70,250,177,254,142,183,208,253,129,197,228,54,211,23,133,161,3,63,19,84,221,238,42,186,206,94,213,252,171,131,185,247,132,246,3,158,42,21,73,148,172,189,112,91,230,24,115,207,15,192,164,110,228,50,234,154,56,165,161,25,198,212,9,129,219,224,135,1,115,236,183,117,125,117,70,191,214,187,126,45,94,94,102,178,115,222,125,14,215,48,199,102,242,107,252,24,114,80,111,231,49,233,123,230,247,123,114,94,69,208,207,225,186,225,193,209,31,147,143,25,168,33,9,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSpecificationInObjectSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("25a044df-358d-4a85-917e-b23df6b34944"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6e056378-b8f9-44bd-acc1-750e07f572be"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e"),
				CreatedInSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SpecificationInObjectSaving",
				ModifiedInSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				Name = @"SpecificationInObjectSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(70, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateUpdateStringValueMethodMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
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

		protected virtual SchemaMethod CreateUpdateStringValueMethodMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8f401dbf-e4e6-40a3-b68b-7a5472305a65"),
				Name = "UpdateStringValueMethod",
				CreatedInSchemaUId = new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"),
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,86,93,107,219,48,20,125,110,32,255,65,203,83,2,81,226,207,216,110,215,194,86,218,18,216,10,91,187,193,30,101,235,170,53,115,228,206,150,83,194,232,127,159,100,217,169,237,58,89,96,29,244,49,202,185,231,158,123,238,149,174,231,115,116,158,242,53,100,2,229,15,16,197,44,142,136,136,83,142,214,36,41,0,137,20,221,136,44,230,119,223,213,207,225,96,56,88,147,172,141,188,221,60,192,146,162,83,148,151,192,217,197,234,65,108,78,122,128,37,197,75,220,112,16,51,52,190,224,34,22,155,217,77,51,64,177,158,162,171,34,166,26,60,65,191,135,131,163,12,68,145,113,36,178,2,100,244,211,73,45,10,242,95,95,33,47,18,33,83,112,120,68,154,241,38,186,135,21,249,82,64,182,25,127,203,33,147,197,114,136,20,251,172,9,248,76,56,185,131,108,138,70,45,5,163,137,164,223,18,207,62,80,122,158,38,197,138,143,71,170,234,242,223,186,76,205,38,115,63,195,175,64,232,211,78,230,41,234,175,86,209,237,176,118,155,64,145,170,227,74,72,233,233,123,237,232,153,86,181,164,165,174,225,96,62,71,210,89,158,138,202,113,221,82,109,119,95,154,119,167,104,228,17,66,29,51,32,56,0,143,96,199,243,93,236,83,211,198,145,199,152,233,24,22,152,182,164,47,251,80,215,0,162,33,101,60,106,140,203,104,218,234,245,100,219,174,252,49,22,209,125,159,8,77,45,149,87,146,133,60,149,7,17,201,1,141,15,84,119,44,3,118,169,91,114,81,75,51,148,158,157,192,203,36,37,207,208,217,126,240,199,52,77,128,240,26,206,72,146,195,222,128,79,113,46,150,2,86,229,79,217,176,41,226,69,146,232,144,246,124,43,47,98,46,58,70,88,150,105,89,142,73,176,103,66,136,157,133,31,98,98,83,23,71,6,179,3,202,192,53,163,160,50,162,247,10,30,50,75,91,171,222,168,79,97,6,228,103,229,16,83,42,58,30,133,16,58,11,215,54,177,195,172,0,59,174,21,225,16,76,31,155,64,93,102,18,226,135,190,241,175,30,53,170,223,91,199,193,99,247,223,28,10,53,113,199,35,219,13,192,0,219,197,97,104,75,143,152,225,225,32,12,24,38,16,45,8,53,188,133,111,249,149,71,141,71,186,207,18,197,127,214,209,63,209,183,121,135,191,63,32,159,221,166,250,185,24,107,193,79,8,100,189,251,130,174,211,23,49,175,53,156,7,247,232,80,203,19,137,67,177,4,214,15,111,237,58,68,204,245,124,98,96,39,116,40,118,12,88,224,192,8,34,108,7,132,89,196,11,124,106,91,111,235,25,107,52,191,83,189,218,26,207,27,26,213,29,87,91,49,169,144,175,190,149,107,9,213,157,59,106,39,106,110,233,107,178,170,111,102,75,146,20,211,9,250,235,174,238,212,93,145,246,14,105,77,189,255,237,104,104,123,66,173,217,161,192,136,212,116,140,250,62,117,14,91,187,47,100,233,79,130,38,225,31,108,211,41,199,250,9,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SpecificationInObjectEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fef1f06c-5ee3-4d09-90ef-efd2c0e33994"));
		}

		#endregion

	}

	#endregion


	#region Class: SpecificationInObjectEventsProcess

	/// <exclude/>
	public class SpecificationInObjectEventsProcess : SpecificationInObject_SpecificationEventsProcess
	{

		public SpecificationInObjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

