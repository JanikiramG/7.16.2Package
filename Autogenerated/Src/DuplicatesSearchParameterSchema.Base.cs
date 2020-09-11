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

	#region Class: DuplicatesSearchParameterSchema

	/// <exclude/>
	public class DuplicatesSearchParameterSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public DuplicatesSearchParameterSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DuplicatesSearchParameterSchema(DuplicatesSearchParameterSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DuplicatesSearchParameterSchema(DuplicatesSearchParameterSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("01bff6c2-1ae4-4430-ba9f-1f77bade9c3a");
			RealUId = new Guid("01bff6c2-1ae4-4430-ba9f-1f77bade9c3a");
			Name = "DuplicatesSearchParameter";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("ed4d38f1-8201-4d23-8fdc-02b52528cf6c")) == null) {
				Columns.Add(CreatePerformSearchOnSaveColumn());
			}
			if (Columns.FindByUId(new Guid("ffd92a9f-638d-4ebf-87ac-13491fc06b6b")) == null) {
				Columns.Add(CreatePerformSheduledSearchColumn());
			}
			if (Columns.FindByUId(new Guid("1c6bfa4f-0ac6-4408-b832-ea48841f7989")) == null) {
				Columns.Add(CreateSearchTimeColumn());
			}
			if (Columns.FindByUId(new Guid("c4bd8f7c-c3be-4e95-a605-454497caf252")) == null) {
				Columns.Add(CreateSearchByModifiedOnlyColumn());
			}
			if (Columns.FindByUId(new Guid("6a56afbb-1647-403c-ba34-9e208c491d87")) == null) {
				Columns.Add(CreateSearchByAllColumn());
			}
			if (Columns.FindByUId(new Guid("f9f0e6eb-dd6e-4894-af0e-f6654c51fbb0")) == null) {
				Columns.Add(CreateDaysColumn());
			}
			if (Columns.FindByUId(new Guid("f304f0b5-31de-4d89-b3bc-e7b617e264eb")) == null) {
				Columns.Add(CreateSchemaToSearchColumn());
			}
			if (Columns.FindByUId(new Guid("9e03ae6d-244b-4439-98cc-01c71eb220a0")) == null) {
				Columns.Add(CreateSchemaToSearchNameColumn());
			}
		}

		protected virtual EntitySchemaColumn CreatePerformSearchOnSaveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("ed4d38f1-8201-4d23-8fdc-02b52528cf6c"),
				Name = @"PerformSearchOnSave",
				CreatedInSchemaUId = new Guid("01bff6c2-1ae4-4430-ba9f-1f77bade9c3a"),
				ModifiedInSchemaUId = new Guid("01bff6c2-1ae4-4430-ba9f-1f77bade9c3a"),
				CreatedInPackageId = new Guid("8bf8ae5e-52c9-44c1-a099-364797b55805")
			};
		}

		protected virtual EntitySchemaColumn CreatePerformSheduledSearchColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("ffd92a9f-638d-4ebf-87ac-13491fc06b6b"),
				Name = @"PerformSheduledSearch",
				CreatedInSchemaUId = new Guid("01bff6c2-1ae4-4430-ba9f-1f77bade9c3a"),
				ModifiedInSchemaUId = new Guid("01bff6c2-1ae4-4430-ba9f-1f77bade9c3a"),
				CreatedInPackageId = new Guid("8bf8ae5e-52c9-44c1-a099-364797b55805")
			};
		}

		protected virtual EntitySchemaColumn CreateSearchTimeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Time")) {
				UId = new Guid("1c6bfa4f-0ac6-4408-b832-ea48841f7989"),
				Name = @"SearchTime",
				CreatedInSchemaUId = new Guid("01bff6c2-1ae4-4430-ba9f-1f77bade9c3a"),
				ModifiedInSchemaUId = new Guid("01bff6c2-1ae4-4430-ba9f-1f77bade9c3a"),
				CreatedInPackageId = new Guid("8bf8ae5e-52c9-44c1-a099-364797b55805")
			};
		}

		protected virtual EntitySchemaColumn CreateSearchByModifiedOnlyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("c4bd8f7c-c3be-4e95-a605-454497caf252"),
				Name = @"SearchByModifiedOnly",
				CreatedInSchemaUId = new Guid("01bff6c2-1ae4-4430-ba9f-1f77bade9c3a"),
				ModifiedInSchemaUId = new Guid("01bff6c2-1ae4-4430-ba9f-1f77bade9c3a"),
				CreatedInPackageId = new Guid("8bf8ae5e-52c9-44c1-a099-364797b55805")
			};
		}

		protected virtual EntitySchemaColumn CreateSearchByAllColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("6a56afbb-1647-403c-ba34-9e208c491d87"),
				Name = @"SearchByAll",
				CreatedInSchemaUId = new Guid("01bff6c2-1ae4-4430-ba9f-1f77bade9c3a"),
				ModifiedInSchemaUId = new Guid("01bff6c2-1ae4-4430-ba9f-1f77bade9c3a"),
				CreatedInPackageId = new Guid("8bf8ae5e-52c9-44c1-a099-364797b55805")
			};
		}

		protected virtual EntitySchemaColumn CreateDaysColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("f9f0e6eb-dd6e-4894-af0e-f6654c51fbb0"),
				Name = @"Days",
				CreatedInSchemaUId = new Guid("01bff6c2-1ae4-4430-ba9f-1f77bade9c3a"),
				ModifiedInSchemaUId = new Guid("01bff6c2-1ae4-4430-ba9f-1f77bade9c3a"),
				CreatedInPackageId = new Guid("8bf8ae5e-52c9-44c1-a099-364797b55805")
			};
		}

		protected virtual EntitySchemaColumn CreateSchemaToSearchColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("f304f0b5-31de-4d89-b3bc-e7b617e264eb"),
				Name = @"SchemaToSearch",
				CreatedInSchemaUId = new Guid("01bff6c2-1ae4-4430-ba9f-1f77bade9c3a"),
				ModifiedInSchemaUId = new Guid("01bff6c2-1ae4-4430-ba9f-1f77bade9c3a"),
				CreatedInPackageId = new Guid("8bf8ae5e-52c9-44c1-a099-364797b55805")
			};
		}

		protected virtual EntitySchemaColumn CreateSchemaToSearchNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("9e03ae6d-244b-4439-98cc-01c71eb220a0"),
				Name = @"SchemaToSearchName",
				CreatedInSchemaUId = new Guid("01bff6c2-1ae4-4430-ba9f-1f77bade9c3a"),
				ModifiedInSchemaUId = new Guid("01bff6c2-1ae4-4430-ba9f-1f77bade9c3a"),
				CreatedInPackageId = new Guid("8bf8ae5e-52c9-44c1-a099-364797b55805")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateDuplicatesSearchParameterEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateDuplicatesSearchParameterEventsProcessSchema() {
			var schema = new DuplicatesSearchParameterEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DuplicatesSearchParameter(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DuplicatesSearchParameter_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DuplicatesSearchParameterSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DuplicatesSearchParameterSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("01bff6c2-1ae4-4430-ba9f-1f77bade9c3a"));
		}

		#endregion

	}

	#endregion

	#region Class: DuplicatesSearchParameter

	/// <summary>
	/// Duplicates search settings.
	/// </summary>
	public class DuplicatesSearchParameter : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public DuplicatesSearchParameter(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DuplicatesSearchParameter";
		}

		public DuplicatesSearchParameter(DuplicatesSearchParameter source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Search when saving record.
		/// </summary>
		public bool PerformSearchOnSave {
			get {
				return GetTypedColumnValue<bool>("PerformSearchOnSave");
			}
			set {
				SetColumnValue("PerformSearchOnSave", value);
			}
		}

		/// <summary>
		/// Scheduled search.
		/// </summary>
		public bool PerformSheduledSearch {
			get {
				return GetTypedColumnValue<bool>("PerformSheduledSearch");
			}
			set {
				SetColumnValue("PerformSheduledSearch", value);
			}
		}

		/// <summary>
		/// Search time.
		/// </summary>
		public DateTime SearchTime {
			get {
				return GetTypedColumnValue<DateTime>("SearchTime");
			}
			set {
				SetColumnValue("SearchTime", value);
			}
		}

		/// <summary>
		/// Search in modified objects only.
		/// </summary>
		public bool SearchByModifiedOnly {
			get {
				return GetTypedColumnValue<bool>("SearchByModifiedOnly");
			}
			set {
				SetColumnValue("SearchByModifiedOnly", value);
			}
		}

		/// <summary>
		/// Search in all objects.
		/// </summary>
		public bool SearchByAll {
			get {
				return GetTypedColumnValue<bool>("SearchByAll");
			}
			set {
				SetColumnValue("SearchByAll", value);
			}
		}

		/// <summary>
		/// Days.
		/// </summary>
		public int Days {
			get {
				return GetTypedColumnValue<int>("Days");
			}
			set {
				SetColumnValue("Days", value);
			}
		}

		/// <summary>
		/// Schema.
		/// </summary>
		public Guid SchemaToSearch {
			get {
				return GetTypedColumnValue<Guid>("SchemaToSearch");
			}
			set {
				SetColumnValue("SchemaToSearch", value);
			}
		}

		/// <summary>
		/// Object name.
		/// </summary>
		public string SchemaToSearchName {
			get {
				return GetTypedColumnValue<string>("SchemaToSearchName");
			}
			set {
				SetColumnValue("SchemaToSearchName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DuplicatesSearchParameter_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DuplicatesSearchParameterDeleted", e);
			Deleting += (s, e) => ThrowEvent("DuplicatesSearchParameterDeleting", e);
			Inserted += (s, e) => ThrowEvent("DuplicatesSearchParameterInserted", e);
			Inserting += (s, e) => ThrowEvent("DuplicatesSearchParameterInserting", e);
			Saved += (s, e) => ThrowEvent("DuplicatesSearchParameterSaved", e);
			Saving += (s, e) => ThrowEvent("DuplicatesSearchParameterSaving", e);
			Validating += (s, e) => ThrowEvent("DuplicatesSearchParameterValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DuplicatesSearchParameter(this);
		}

		#endregion

	}

	#endregion

	#region Class: DuplicatesSearchParameter_BaseEventsProcess

	/// <exclude/>
	public partial class DuplicatesSearchParameter_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : DuplicatesSearchParameter
	{

		public DuplicatesSearchParameter_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DuplicatesSearchParameter_BaseEventsProcess";
			SchemaUId = new Guid("01bff6c2-1ae4-4430-ba9f-1f77bade9c3a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("01bff6c2-1ae4-4430-ba9f-1f77bade9c3a");
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

	#region Class: DuplicatesSearchParameter_BaseEventsProcess

	/// <exclude/>
	public class DuplicatesSearchParameter_BaseEventsProcess : DuplicatesSearchParameter_BaseEventsProcess<DuplicatesSearchParameter>
	{

		public DuplicatesSearchParameter_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DuplicatesSearchParameter_BaseEventsProcess

	public partial class DuplicatesSearchParameter_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: DuplicatesSearchParameterEventsProcessSchema

	/// <exclude/>
	public class DuplicatesSearchParameterEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public DuplicatesSearchParameterEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public DuplicatesSearchParameterEventsProcessSchema(DuplicatesSearchParameterEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "DuplicatesSearchParameter_BaseEventsProcess";
			UId = new Guid("69cb676c-325b-4764-bbae-9e48643be2b7");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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
			return new DuplicatesSearchParameterEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("69cb676c-325b-4764-bbae-9e48643be2b7"));
		}

		#endregion

	}

	#endregion


	#region Class: DuplicatesSearchParameterEventsProcess

	/// <exclude/>
	public class DuplicatesSearchParameterEventsProcess : DuplicatesSearchParameter_BaseEventsProcess
	{

		public DuplicatesSearchParameterEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

