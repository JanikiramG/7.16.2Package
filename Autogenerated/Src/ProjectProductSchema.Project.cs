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

	#region Class: ProjectProductSchema

	/// <exclude/>
	public class ProjectProductSchema : Terrasoft.Configuration.BaseProductEntrySchema
	{

		#region Constructors: Public

		public ProjectProductSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProjectProductSchema(ProjectProductSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProjectProductSchema(ProjectProductSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			RealUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			Name = "ProjectProduct";
			ParentSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4");
			ExtendParent = false;
			CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("888eeaa9-213e-4ec1-8efd-9c689ef5ed86")) == null) {
				Columns.Add(CreateProjectColumn());
			}
			if (Columns.FindByUId(new Guid("cd01ea82-5717-4020-9340-fb67bbb6e221")) == null) {
				Columns.Add(CreateCostColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateNotesColumn() {
			EntitySchemaColumn column = base.CreateNotesColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateProductColumn() {
			EntitySchemaColumn column = base.CreateProductColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateCustomProductColumn() {
			EntitySchemaColumn column = base.CreateCustomProductColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateDeliveryDateColumn() {
			EntitySchemaColumn column = base.CreateDeliveryDateColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateQuantityColumn() {
			EntitySchemaColumn column = base.CreateQuantityColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateUnitColumn() {
			EntitySchemaColumn column = base.CreateUnitColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreatePrimaryPriceColumn() {
			EntitySchemaColumn column = base.CreatePrimaryPriceColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreatePriceColumn() {
			EntitySchemaColumn column = base.CreatePriceColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreatePrimaryAmountColumn() {
			EntitySchemaColumn column = base.CreatePrimaryAmountColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateAmountColumn() {
			EntitySchemaColumn column = base.CreateAmountColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreatePrimaryDiscountAmountColumn() {
			EntitySchemaColumn column = base.CreatePrimaryDiscountAmountColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateDiscountAmountColumn() {
			EntitySchemaColumn column = base.CreateDiscountAmountColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateDiscountPercentColumn() {
			EntitySchemaColumn column = base.CreateDiscountPercentColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateTaxColumn() {
			EntitySchemaColumn column = base.CreateTaxColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreatePrimaryTaxAmountColumn() {
			EntitySchemaColumn column = base.CreatePrimaryTaxAmountColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateTaxAmountColumn() {
			EntitySchemaColumn column = base.CreateTaxAmountColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreatePrimaryTotalAmountColumn() {
			EntitySchemaColumn column = base.CreatePrimaryTotalAmountColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateTotalAmountColumn() {
			EntitySchemaColumn column = base.CreateTotalAmountColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateDiscountTaxColumn() {
			EntitySchemaColumn column = base.CreateDiscountTaxColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			column.CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			return column;
		}

		protected virtual EntitySchemaColumn CreateProjectColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("888eeaa9-213e-4ec1-8efd-9c689ef5ed86"),
				Name = @"Project",
				ReferenceSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336"),
				ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected virtual EntitySchemaColumn CreateCostColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("cd01ea82-5717-4020-9340-fb67bbb6e221"),
				Name = @"Cost",
				CreatedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336"),
				ModifiedInSchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateProjectProductEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateProjectProductEventsProcessSchema() {
			var schema = new ProjectProductEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProjectProduct(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProjectProduct_ProjectEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProjectProductSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProjectProductSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336"));
		}

		#endregion

	}

	#endregion

	#region Class: ProjectProduct

	/// <summary>
	/// Product in project.
	/// </summary>
	public class ProjectProduct : Terrasoft.Configuration.BaseProductEntry
	{

		#region Constructors: Public

		public ProjectProduct(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProjectProduct";
		}

		public ProjectProduct(ProjectProduct source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ProjectId {
			get {
				return GetTypedColumnValue<Guid>("ProjectId");
			}
			set {
				SetColumnValue("ProjectId", value);
				_project = null;
			}
		}

		/// <exclude/>
		public string ProjectName {
			get {
				return GetTypedColumnValue<string>("ProjectName");
			}
			set {
				SetColumnValue("ProjectName", value);
				if (_project != null) {
					_project.Name = value;
				}
			}
		}

		private Project _project;
		/// <summary>
		/// Project.
		/// </summary>
		public Project Project {
			get {
				return _project ??
					(_project = LookupColumnEntities.GetEntity("Project") as Project);
			}
		}

		/// <summary>
		/// Prime cost.
		/// </summary>
		public Decimal Cost {
			get {
				return GetTypedColumnValue<Decimal>("Cost");
			}
			set {
				SetColumnValue("Cost", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProjectProduct_ProjectEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ProjectProductDeleted", e);
			Inserting += (s, e) => ThrowEvent("ProjectProductInserting", e);
			Validating += (s, e) => ThrowEvent("ProjectProductValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProjectProduct(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProjectProduct_ProjectEventsProcess

	/// <exclude/>
	public partial class ProjectProduct_ProjectEventsProcess<TEntity> : Terrasoft.Configuration.BaseProductEntry_ProductCatalogueEventsProcess<TEntity> where TEntity : ProjectProduct
	{

		public ProjectProduct_ProjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProjectProduct_ProjectEventsProcess";
			SchemaUId = new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4d57a5cd-c540-4eb1-b90e-db10a046c336");
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

	#region Class: ProjectProduct_ProjectEventsProcess

	/// <exclude/>
	public class ProjectProduct_ProjectEventsProcess : ProjectProduct_ProjectEventsProcess<ProjectProduct>
	{

		public ProjectProduct_ProjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProjectProduct_ProjectEventsProcess

	public partial class ProjectProduct_ProjectEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ProjectProductEventsProcessSchema

	/// <exclude/>
	public class ProjectProductEventsProcessSchema : Terrasoft.Configuration.BaseProductEntryEventsProcessSchema
	{

		#region Constructors: Public

		public ProjectProductEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ProjectProductEventsProcessSchema(ProjectProductEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ProjectProduct_ProjectEventsProcess";
			UId = new Guid("58505a56-9729-406e-b86d-9c28e1474ad7");
			CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b");
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
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb")
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
			return new ProjectProductEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("58505a56-9729-406e-b86d-9c28e1474ad7"));
		}

		#endregion

	}

	#endregion


	#region Class: ProjectProductEventsProcess

	/// <exclude/>
	public class ProjectProductEventsProcess : ProjectProduct_ProjectEventsProcess
	{

		public ProjectProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

