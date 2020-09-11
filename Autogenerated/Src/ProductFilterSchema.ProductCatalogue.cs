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

	#region Class: ProductFilterSchema

	/// <exclude/>
	public class ProductFilterSchema : Terrasoft.Configuration.BaseEntityWithPositionSchema
	{

		#region Constructors: Public

		public ProductFilterSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProductFilterSchema(ProductFilterSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProductFilterSchema(ProductFilterSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb");
			RealUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb");
			Name = "ProductFilter";
			ParentSchemaUId = new Guid("73d33bed-4682-45cb-ad25-a29b5ab88c96");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("8bd08717-6b65-4a00-80d9-79635a65686e")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("a6202f2a-1d22-43a9-8317-d13d5ef8e23d")) == null) {
				Columns.Add(CreateSpecificationColumn());
			}
			if (Columns.FindByUId(new Guid("1afcdffa-6c83-453b-8a1d-4b4c33e892b5")) == null) {
				Columns.Add(CreateColumnPathColumn());
			}
			if (Columns.FindByUId(new Guid("94385fd4-8ada-4588-bddb-54237940630d")) == null) {
				Columns.Add(CreateReferenceSchemaNameColumn());
			}
			if (Columns.FindByUId(new Guid("8037dbff-8c5b-4098-abac-11f636bae1fe")) == null) {
				Columns.Add(CreateColumnCaptionColumn());
			}
			if (Columns.FindByUId(new Guid("16ac06f7-cf6b-4c69-996b-4b10b986c633")) == null) {
				Columns.Add(CreateProductTypeColumn());
			}
			if (Columns.FindByUId(new Guid("04e82d78-89c8-4a9e-b24b-7520f5ec54cf")) == null) {
				Columns.Add(CreateColumnDataValueTypeColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreatePositionColumn() {
			EntitySchemaColumn column = base.CreatePositionColumn();
			column.ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("7c08467c-87c4-4147-af83-37665a501f97"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8bd08717-6b65-4a00-80d9-79635a65686e"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("54ab3775-a12e-418d-a6ad-9365d00a53a9"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected virtual EntitySchemaColumn CreateSpecificationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a6202f2a-1d22-43a9-8317-d13d5ef8e23d"),
				Name = @"Specification",
				ReferenceSchemaUId = new Guid("ec3cebc4-ea18-40ea-9b0f-e348570481ef"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnPathColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("1afcdffa-6c83-453b-8a1d-4b4c33e892b5"),
				Name = @"ColumnPath",
				CreatedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected virtual EntitySchemaColumn CreateReferenceSchemaNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("94385fd4-8ada-4588-bddb-54237940630d"),
				Name = @"ReferenceSchemaName",
				CreatedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("8037dbff-8c5b-4098-abac-11f636bae1fe"),
				Name = @"ColumnCaption",
				CreatedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected virtual EntitySchemaColumn CreateProductTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("16ac06f7-cf6b-4c69-996b-4b10b986c633"),
				Name = @"ProductType",
				ReferenceSchemaUId = new Guid("41663f5e-affb-406e-b92d-4d72eea6f8a8"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnDataValueTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("04e82d78-89c8-4a9e-b24b-7520f5ec54cf"),
				Name = @"ColumnDataValueType",
				CreatedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateProductFilterEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateProductFilterEventsProcessSchema() {
			var schema = new ProductFilterEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProductFilter(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProductFilter_ProductCatalogueEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProductFilterSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProductFilterSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"));
		}

		#endregion

	}

	#endregion

	#region Class: ProductFilter

	/// <summary>
	/// Product filter.
	/// </summary>
	public class ProductFilter : Terrasoft.Configuration.BaseEntityWithPosition
	{

		#region Constructors: Public

		public ProductFilter(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProductFilter";
		}

		public ProductFilter(ProductFilter source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private ProductFilterType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public ProductFilterType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as ProductFilterType);
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

		/// <summary>
		/// Column path.
		/// </summary>
		public string ColumnPath {
			get {
				return GetTypedColumnValue<string>("ColumnPath");
			}
			set {
				SetColumnValue("ColumnPath", value);
			}
		}

		/// <summary>
		/// Schema.
		/// </summary>
		public string ReferenceSchemaName {
			get {
				return GetTypedColumnValue<string>("ReferenceSchemaName");
			}
			set {
				SetColumnValue("ReferenceSchemaName", value);
			}
		}

		/// <summary>
		/// Product field.
		/// </summary>
		public string ColumnCaption {
			get {
				return GetTypedColumnValue<string>("ColumnCaption");
			}
			set {
				SetColumnValue("ColumnCaption", value);
			}
		}

		/// <exclude/>
		public Guid ProductTypeId {
			get {
				return GetTypedColumnValue<Guid>("ProductTypeId");
			}
			set {
				SetColumnValue("ProductTypeId", value);
				_productType = null;
			}
		}

		/// <exclude/>
		public string ProductTypeName {
			get {
				return GetTypedColumnValue<string>("ProductTypeName");
			}
			set {
				SetColumnValue("ProductTypeName", value);
				if (_productType != null) {
					_productType.Name = value;
				}
			}
		}

		private ProductType _productType;
		/// <summary>
		/// Product type.
		/// </summary>
		public ProductType ProductType {
			get {
				return _productType ??
					(_productType = LookupColumnEntities.GetEntity("ProductType") as ProductType);
			}
		}

		/// <summary>
		/// Column data type.
		/// </summary>
		public int ColumnDataValueType {
			get {
				return GetTypedColumnValue<int>("ColumnDataValueType");
			}
			set {
				SetColumnValue("ColumnDataValueType", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProductFilter_ProductCatalogueEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("ProductFilterValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProductFilter(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProductFilter_ProductCatalogueEventsProcess

	/// <exclude/>
	public partial class ProductFilter_ProductCatalogueEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntityWithPosition_BaseEventsProcess<TEntity> where TEntity : ProductFilter
	{

		public ProductFilter_ProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductFilter_ProductCatalogueEventsProcess";
			SchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb");
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

	#region Class: ProductFilter_ProductCatalogueEventsProcess

	/// <exclude/>
	public class ProductFilter_ProductCatalogueEventsProcess : ProductFilter_ProductCatalogueEventsProcess<ProductFilter>
	{

		public ProductFilter_ProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductFilter_ProductCatalogueEventsProcess

	public partial class ProductFilter_ProductCatalogueEventsProcess<TEntity>
	{

		#region Methods: Public

		public override EntitySchemaQueryFilterCollection GetDetailFilter(Entity entity, EntitySchemaQuery esq) {
			var productTypeId = entity.GetTypedColumnValue<Guid>("ProductTypeId");
			if (productTypeId != null && productTypeId!=Guid.Empty) {
				var filterValues = new object[] { productTypeId };
				var resultFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "ProductType", filterValues);
				var resultCollection = new EntitySchemaQueryFilterCollection(esq, resultFilter);
				return resultCollection;
			} else return null;
		}

		public override string GetGrouppingColumnNames() {
			return "ProductTypeId";
		}

		#endregion

	}

	#endregion

	#region Class: ProductFilterEventsProcessSchema

	/// <exclude/>
	public class ProductFilterEventsProcessSchema : Terrasoft.Configuration.BaseEntityWithPositionEventsProcessSchema
	{

		#region Constructors: Public

		public ProductFilterEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ProductFilterEventsProcessSchema(ProductFilterEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ProductFilter_ProductCatalogueEventsProcess";
			UId = new Guid("abbac0f3-8e56-4f84-9c3e-37d3dcf8b32a");
			CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c");
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
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
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

		protected override SchemaMethod CreateGetDetailFilterMethod() {
			SchemaMethod method = base.CreateGetDetailFilterMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,205,106,195,48,16,132,207,13,228,29,54,62,4,27,140,95,192,117,47,198,13,189,165,180,180,135,210,131,106,111,136,138,126,156,213,42,197,132,188,123,101,197,129,184,61,106,180,51,243,237,30,5,65,79,182,243,45,191,14,61,62,117,80,1,26,150,60,20,27,140,82,87,91,229,181,121,19,202,227,253,198,203,238,33,77,182,183,142,36,43,151,11,185,131,116,158,179,170,192,120,165,96,189,158,23,172,170,49,164,104,116,207,67,6,167,229,226,238,24,24,118,82,49,82,44,113,1,193,224,15,216,175,111,108,249,227,19,78,127,8,207,229,100,34,116,94,241,99,180,142,220,238,80,212,132,130,241,34,189,75,222,111,5,9,141,225,225,210,139,88,91,221,11,146,206,154,49,173,104,14,94,168,28,110,55,74,242,25,77,54,111,11,215,80,1,75,90,51,97,54,241,90,47,237,30,181,120,246,72,195,181,231,58,151,6,174,124,198,26,35,9,217,147,249,151,26,190,206,128,202,33,76,3,227,17,203,95,132,156,229,133,167,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetGrouppingColumnNamesMethod() {
			SchemaMethod method = base.CreateGetGrouppingColumnNamesMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,80,10,40,202,79,41,77,46,9,169,44,72,245,76,81,178,6,0,132,152,93,208,23,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProductFilterEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("abbac0f3-8e56-4f84-9c3e-37d3dcf8b32a"));
		}

		#endregion

	}

	#endregion


	#region Class: ProductFilterEventsProcess

	/// <exclude/>
	public class ProductFilterEventsProcess : ProductFilter_ProductCatalogueEventsProcess
	{

		public ProductFilterEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

