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

	#region Class: FastReportDataSourceSchema

	/// <exclude/>
	public class FastReportDataSourceSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public FastReportDataSourceSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FastReportDataSourceSchema(FastReportDataSourceSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FastReportDataSourceSchema(FastReportDataSourceSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9c01d240-dae6-49b9-b997-809920e45fb1");
			RealUId = new Guid("9c01d240-dae6-49b9-b997-809920e45fb1");
			Name = "FastReportDataSource";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("a4b49bea-882f-4e7d-ae8d-44e3ec2194f3");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("8280c0b2-8af4-45f1-8734-d547fc37d697")) == null) {
				Columns.Add(CreateDataColumn());
			}
			if (Columns.FindByUId(new Guid("2e44c9ed-75ba-4c64-aa66-9830669a10ea")) == null) {
				Columns.Add(CreateTemplateColumn());
			}
			if (Columns.FindByUId(new Guid("bf9497a7-6276-49f1-b7c0-121e2f8cf2b7")) == null) {
				Columns.Add(CreateNameColumn());
			}
			if (Columns.FindByUId(new Guid("187bdef6-1563-4316-b4cd-989a554e0a9e")) == null) {
				Columns.Add(CreateTypeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("8280c0b2-8af4-45f1-8734-d547fc37d697"),
				Name = @"Data",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("9c01d240-dae6-49b9-b997-809920e45fb1"),
				ModifiedInSchemaUId = new Guid("9c01d240-dae6-49b9-b997-809920e45fb1"),
				CreatedInPackageId = new Guid("a4b49bea-882f-4e7d-ae8d-44e3ec2194f3")
			};
		}

		protected virtual EntitySchemaColumn CreateTemplateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2e44c9ed-75ba-4c64-aa66-9830669a10ea"),
				Name = @"Template",
				ReferenceSchemaUId = new Guid("05ba10ee-d7af-4596-b947-87d2dcf5f820"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9c01d240-dae6-49b9-b997-809920e45fb1"),
				ModifiedInSchemaUId = new Guid("9c01d240-dae6-49b9-b997-809920e45fb1"),
				CreatedInPackageId = new Guid("a4b49bea-882f-4e7d-ae8d-44e3ec2194f3")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("bf9497a7-6276-49f1-b7c0-121e2f8cf2b7"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("9c01d240-dae6-49b9-b997-809920e45fb1"),
				ModifiedInSchemaUId = new Guid("9c01d240-dae6-49b9-b997-809920e45fb1"),
				CreatedInPackageId = new Guid("a4b49bea-882f-4e7d-ae8d-44e3ec2194f3")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("187bdef6-1563-4316-b4cd-989a554e0a9e"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("069482a1-db1d-4821-9780-d20d75a63af6"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9c01d240-dae6-49b9-b997-809920e45fb1"),
				ModifiedInSchemaUId = new Guid("9c01d240-dae6-49b9-b997-809920e45fb1"),
				CreatedInPackageId = new Guid("0005402e-c4df-422a-beab-65ef1e6175ad")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateFastReportDataSourceEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateFastReportDataSourceEventsProcessSchema() {
			var schema = new FastReportDataSourceEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FastReportDataSource(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FastReportDataSource_FastReportEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FastReportDataSourceSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FastReportDataSourceSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9c01d240-dae6-49b9-b997-809920e45fb1"));
		}

		#endregion

	}

	#endregion

	#region Class: FastReportDataSource

	/// <summary>
	/// FastReportDataSource.
	/// </summary>
	public class FastReportDataSource : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public FastReportDataSource(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FastReportDataSource";
		}

		public FastReportDataSource(FastReportDataSource source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Data.
		/// </summary>
		public string Data {
			get {
				return GetTypedColumnValue<string>("Data");
			}
			set {
				SetColumnValue("Data", value);
			}
		}

		/// <exclude/>
		public Guid TemplateId {
			get {
				return GetTypedColumnValue<Guid>("TemplateId");
			}
			set {
				SetColumnValue("TemplateId", value);
				_template = null;
			}
		}

		private FastReportTemplate _template;
		/// <summary>
		/// Template.
		/// </summary>
		public FastReportTemplate Template {
			get {
				return _template ??
					(_template = LookupColumnEntities.GetEntity("Template") as FastReportTemplate);
			}
		}

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

		private FRDataSourceType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public FRDataSourceType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as FRDataSourceType);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FastReportDataSource_FastReportEventsProcess(UserConnection);
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
			return new FastReportDataSource(this);
		}

		#endregion

	}

	#endregion

	#region Class: FastReportDataSource_FastReportEventsProcess

	/// <exclude/>
	public partial class FastReportDataSource_FastReportEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : FastReportDataSource
	{

		public FastReportDataSource_FastReportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FastReportDataSource_FastReportEventsProcess";
			SchemaUId = new Guid("9c01d240-dae6-49b9-b997-809920e45fb1");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9c01d240-dae6-49b9-b997-809920e45fb1");
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

	#region Class: FastReportDataSource_FastReportEventsProcess

	/// <exclude/>
	public class FastReportDataSource_FastReportEventsProcess : FastReportDataSource_FastReportEventsProcess<FastReportDataSource>
	{

		public FastReportDataSource_FastReportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FastReportDataSource_FastReportEventsProcess

	public partial class FastReportDataSource_FastReportEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: FastReportDataSourceEventsProcessSchema

	/// <exclude/>
	public class FastReportDataSourceEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public FastReportDataSourceEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public FastReportDataSourceEventsProcessSchema(FastReportDataSourceEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "FastReportDataSource_FastReportEventsProcess";
			UId = new Guid("f7ff85c1-1d7e-4e79-8e55-3c98b93d120b");
			CreatedInPackageId = new Guid("a4b49bea-882f-4e7d-ae8d-44e3ec2194f3");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
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
			return new FastReportDataSourceEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f7ff85c1-1d7e-4e79-8e55-3c98b93d120b"));
		}

		#endregion

	}

	#endregion


	#region Class: FastReportDataSourceEventsProcess

	/// <exclude/>
	public class FastReportDataSourceEventsProcess : FastReportDataSource_FastReportEventsProcess
	{

		public FastReportDataSourceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

