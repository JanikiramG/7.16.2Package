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

	#region Class: EditPageModificationSchema

	/// <exclude/>
	public class EditPageModificationSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public EditPageModificationSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EditPageModificationSchema(EditPageModificationSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EditPageModificationSchema(EditPageModificationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("af25bf86-7f6d-44cc-a9ee-085e1bb737d3");
			RealUId = new Guid("af25bf86-7f6d-44cc-a9ee-085e1bb737d3");
			Name = "EditPageModification";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("d2208f83-bdfd-4190-b89d-739eaee71a53")) == null) {
				Columns.Add(CreateSerializedDataColumn());
			}
			if (Columns.FindByUId(new Guid("faa9faa7-0529-4e95-88f7-3137e89d229e")) == null) {
				Columns.Add(CreateEditPageNameColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("af25bf86-7f6d-44cc-a9ee-085e1bb737d3");
			column.CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("af25bf86-7f6d-44cc-a9ee-085e1bb737d3");
			column.CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("af25bf86-7f6d-44cc-a9ee-085e1bb737d3");
			column.CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("af25bf86-7f6d-44cc-a9ee-085e1bb737d3");
			column.CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("af25bf86-7f6d-44cc-a9ee-085e1bb737d3");
			column.CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("af25bf86-7f6d-44cc-a9ee-085e1bb737d3");
			column.CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da");
			return column;
		}

		protected virtual EntitySchemaColumn CreateSerializedDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("d2208f83-bdfd-4190-b89d-739eaee71a53"),
				Name = @"SerializedData",
				CreatedInSchemaUId = new Guid("af25bf86-7f6d-44cc-a9ee-085e1bb737d3"),
				ModifiedInSchemaUId = new Guid("af25bf86-7f6d-44cc-a9ee-085e1bb737d3"),
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			};
		}

		protected virtual EntitySchemaColumn CreateEditPageNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("faa9faa7-0529-4e95-88f7-3137e89d229e"),
				Name = @"EditPageName",
				CreatedInSchemaUId = new Guid("af25bf86-7f6d-44cc-a9ee-085e1bb737d3"),
				ModifiedInSchemaUId = new Guid("af25bf86-7f6d-44cc-a9ee-085e1bb737d3"),
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateEditPageModificationEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateEditPageModificationEventsProcessSchema() {
			var schema = new EditPageModificationEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new EditPageModification(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EditPageModification_NUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EditPageModificationSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EditPageModificationSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("af25bf86-7f6d-44cc-a9ee-085e1bb737d3"));
		}

		#endregion

	}

	#endregion

	#region Class: EditPageModification

	/// <summary>
	/// Edit card modification object.
	/// </summary>
	public class EditPageModification : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public EditPageModification(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EditPageModification";
		}

		public EditPageModification(EditPageModification source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Serialize data.
		/// </summary>
		public string SerializedData {
			get {
				return GetTypedColumnValue<string>("SerializedData");
			}
			set {
				SetColumnValue("SerializedData", value);
			}
		}

		/// <summary>
		/// Edit page name.
		/// </summary>
		public string EditPageName {
			get {
				return GetTypedColumnValue<string>("EditPageName");
			}
			set {
				SetColumnValue("EditPageName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EditPageModification_NUIEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("EditPageModificationDeleted", e);
			Inserting += (s, e) => ThrowEvent("EditPageModificationInserting", e);
			Validating += (s, e) => ThrowEvent("EditPageModificationValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EditPageModification(this);
		}

		#endregion

	}

	#endregion

	#region Class: EditPageModification_NUIEventsProcess

	/// <exclude/>
	public partial class EditPageModification_NUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : EditPageModification
	{

		public EditPageModification_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EditPageModification_NUIEventsProcess";
			SchemaUId = new Guid("af25bf86-7f6d-44cc-a9ee-085e1bb737d3");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("af25bf86-7f6d-44cc-a9ee-085e1bb737d3");
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

	#region Class: EditPageModification_NUIEventsProcess

	/// <exclude/>
	public class EditPageModification_NUIEventsProcess : EditPageModification_NUIEventsProcess<EditPageModification>
	{

		public EditPageModification_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EditPageModification_NUIEventsProcess

	public partial class EditPageModification_NUIEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: EditPageModificationEventsProcessSchema

	/// <exclude/>
	public class EditPageModificationEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public EditPageModificationEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public EditPageModificationEventsProcessSchema(EditPageModificationEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "EditPageModification_NUIEventsProcess";
			UId = new Guid("b7d3172e-54b0-49c9-b0b7-c73a672015a6");
			CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da");
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
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
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
			return new EditPageModificationEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b7d3172e-54b0-49c9-b0b7-c73a672015a6"));
		}

		#endregion

	}

	#endregion


	#region Class: EditPageModificationEventsProcess

	/// <exclude/>
	public class EditPageModificationEventsProcess : EditPageModification_NUIEventsProcess
	{

		public EditPageModificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

