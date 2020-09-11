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

	#region Class: DocumentRelationshipSchema

	/// <exclude/>
	public class DocumentRelationshipSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public DocumentRelationshipSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DocumentRelationshipSchema(DocumentRelationshipSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DocumentRelationshipSchema(DocumentRelationshipSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("779e5db8-6738-4148-8e68-c235ba046df2");
			RealUId = new Guid("779e5db8-6738-4148-8e68-c235ba046df2");
			Name = "DocumentRelationship";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("93f2b0e4-b421-42dc-86e5-35e5b932239c");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("dbbc32c7-bce6-455f-9003-ea928b705dc7")) == null) {
				Columns.Add(CreateDocumentAColumn());
			}
			if (Columns.FindByUId(new Guid("ed6b9265-f38d-4097-bb04-834186dbd51f")) == null) {
				Columns.Add(CreateDocumentBColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateDocumentAColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("dbbc32c7-bce6-455f-9003-ea928b705dc7"),
				Name = @"DocumentA",
				ReferenceSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("779e5db8-6738-4148-8e68-c235ba046df2"),
				ModifiedInSchemaUId = new Guid("779e5db8-6738-4148-8e68-c235ba046df2"),
				CreatedInPackageId = new Guid("93f2b0e4-b421-42dc-86e5-35e5b932239c")
			};
		}

		protected virtual EntitySchemaColumn CreateDocumentBColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ed6b9265-f38d-4097-bb04-834186dbd51f"),
				Name = @"DocumentB",
				ReferenceSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("779e5db8-6738-4148-8e68-c235ba046df2"),
				ModifiedInSchemaUId = new Guid("779e5db8-6738-4148-8e68-c235ba046df2"),
				CreatedInPackageId = new Guid("93f2b0e4-b421-42dc-86e5-35e5b932239c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateDocumentRelationshipEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateDocumentRelationshipEventsProcessSchema() {
			var schema = new DocumentRelationshipEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DocumentRelationship(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DocumentRelationship_DocumentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DocumentRelationshipSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DocumentRelationshipSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("779e5db8-6738-4148-8e68-c235ba046df2"));
		}

		#endregion

	}

	#endregion

	#region Class: DocumentRelationship

	/// <summary>
	/// Document relationships.
	/// </summary>
	public class DocumentRelationship : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public DocumentRelationship(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DocumentRelationship";
		}

		public DocumentRelationship(DocumentRelationship source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid DocumentAId {
			get {
				return GetTypedColumnValue<Guid>("DocumentAId");
			}
			set {
				SetColumnValue("DocumentAId", value);
				_documentA = null;
			}
		}

		/// <exclude/>
		public string DocumentANumber {
			get {
				return GetTypedColumnValue<string>("DocumentANumber");
			}
			set {
				SetColumnValue("DocumentANumber", value);
				if (_documentA != null) {
					_documentA.Number = value;
				}
			}
		}

		private Document _documentA;
		/// <summary>
		/// Document.
		/// </summary>
		public Document DocumentA {
			get {
				return _documentA ??
					(_documentA = LookupColumnEntities.GetEntity("DocumentA") as Document);
			}
		}

		/// <exclude/>
		public Guid DocumentBId {
			get {
				return GetTypedColumnValue<Guid>("DocumentBId");
			}
			set {
				SetColumnValue("DocumentBId", value);
				_documentB = null;
			}
		}

		/// <exclude/>
		public string DocumentBNumber {
			get {
				return GetTypedColumnValue<string>("DocumentBNumber");
			}
			set {
				SetColumnValue("DocumentBNumber", value);
				if (_documentB != null) {
					_documentB.Number = value;
				}
			}
		}

		private Document _documentB;
		/// <summary>
		/// Connected document.
		/// </summary>
		public Document DocumentB {
			get {
				return _documentB ??
					(_documentB = LookupColumnEntities.GetEntity("DocumentB") as Document);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DocumentRelationship_DocumentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DocumentRelationshipDeleted", e);
			Validating += (s, e) => ThrowEvent("DocumentRelationshipValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DocumentRelationship(this);
		}

		#endregion

	}

	#endregion

	#region Class: DocumentRelationship_DocumentEventsProcess

	/// <exclude/>
	public partial class DocumentRelationship_DocumentEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : DocumentRelationship
	{

		public DocumentRelationship_DocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DocumentRelationship_DocumentEventsProcess";
			SchemaUId = new Guid("779e5db8-6738-4148-8e68-c235ba046df2");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("779e5db8-6738-4148-8e68-c235ba046df2");
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

	#region Class: DocumentRelationship_DocumentEventsProcess

	/// <exclude/>
	public class DocumentRelationship_DocumentEventsProcess : DocumentRelationship_DocumentEventsProcess<DocumentRelationship>
	{

		public DocumentRelationship_DocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DocumentRelationship_DocumentEventsProcess

	public partial class DocumentRelationship_DocumentEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: DocumentRelationshipEventsProcessSchema

	/// <exclude/>
	public class DocumentRelationshipEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public DocumentRelationshipEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public DocumentRelationshipEventsProcessSchema(DocumentRelationshipEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "DocumentRelationship_DocumentEventsProcess";
			UId = new Guid("a2392910-6d19-4c0e-ab2b-c77caf1d4245");
			CreatedInPackageId = new Guid("93f2b0e4-b421-42dc-86e5-35e5b932239c");
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
			return new DocumentRelationshipEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a2392910-6d19-4c0e-ab2b-c77caf1d4245"));
		}

		#endregion

	}

	#endregion


	#region Class: DocumentRelationshipEventsProcess

	/// <exclude/>
	public class DocumentRelationshipEventsProcess : DocumentRelationship_DocumentEventsProcess
	{

		public DocumentRelationshipEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

