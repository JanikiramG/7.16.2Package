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

	#region Class: ExcelFileDataInLookupsSchema

	/// <exclude/>
	public class ExcelFileDataInLookupsSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ExcelFileDataInLookupsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ExcelFileDataInLookupsSchema(ExcelFileDataInLookupsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ExcelFileDataInLookupsSchema(ExcelFileDataInLookupsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("463eddd8-ef41-4a2a-9963-1e131327faf8");
			RealUId = new Guid("463eddd8-ef41-4a2a-9963-1e131327faf8");
			Name = "ExcelFileDataInLookups";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("4be45828-978b-4473-988f-276ea3484655")) == null) {
				Columns.Add(CreateFileValueColumn());
			}
			if (Columns.FindByUId(new Guid("33792c84-0b35-4ba6-879e-8434afe9e322")) == null) {
				Columns.Add(CreateLookupNameColumn());
			}
			if (Columns.FindByUId(new Guid("13179879-4384-45a3-8279-7ced655b39c0")) == null) {
				Columns.Add(CreateLookupValueColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateFileValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("4be45828-978b-4473-988f-276ea3484655"),
				Name = @"FileValue",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("463eddd8-ef41-4a2a-9963-1e131327faf8"),
				ModifiedInSchemaUId = new Guid("463eddd8-ef41-4a2a-9963-1e131327faf8"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateLookupNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("33792c84-0b35-4ba6-879e-8434afe9e322"),
				Name = @"LookupName",
				CreatedInSchemaUId = new Guid("463eddd8-ef41-4a2a-9963-1e131327faf8"),
				ModifiedInSchemaUId = new Guid("463eddd8-ef41-4a2a-9963-1e131327faf8"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateLookupValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("13179879-4384-45a3-8279-7ced655b39c0"),
				Name = @"LookupValue",
				CreatedInSchemaUId = new Guid("463eddd8-ef41-4a2a-9963-1e131327faf8"),
				ModifiedInSchemaUId = new Guid("463eddd8-ef41-4a2a-9963-1e131327faf8"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateExcelFileDataInLookupsEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateExcelFileDataInLookupsEventsProcessSchema() {
			var schema = new ExcelFileDataInLookupsEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ExcelFileDataInLookups(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ExcelFileDataInLookups_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ExcelFileDataInLookupsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ExcelFileDataInLookupsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("463eddd8-ef41-4a2a-9963-1e131327faf8"));
		}

		#endregion

	}

	#endregion

	#region Class: ExcelFileDataInLookups

	/// <summary>
	/// Data value from file in lookup.
	/// </summary>
	public class ExcelFileDataInLookups : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ExcelFileDataInLookups(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ExcelFileDataInLookups";
		}

		public ExcelFileDataInLookups(ExcelFileDataInLookups source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Value in file.
		/// </summary>
		public string FileValue {
			get {
				return GetTypedColumnValue<string>("FileValue");
			}
			set {
				SetColumnValue("FileValue", value);
			}
		}

		/// <summary>
		/// Lookup name.
		/// </summary>
		public string LookupName {
			get {
				return GetTypedColumnValue<string>("LookupName");
			}
			set {
				SetColumnValue("LookupName", value);
			}
		}

		/// <summary>
		/// Value in lookup.
		/// </summary>
		public string LookupValue {
			get {
				return GetTypedColumnValue<string>("LookupValue");
			}
			set {
				SetColumnValue("LookupValue", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ExcelFileDataInLookups_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ExcelFileDataInLookupsDeleted", e);
			Deleting += (s, e) => ThrowEvent("ExcelFileDataInLookupsDeleting", e);
			Inserted += (s, e) => ThrowEvent("ExcelFileDataInLookupsInserted", e);
			Inserting += (s, e) => ThrowEvent("ExcelFileDataInLookupsInserting", e);
			Saved += (s, e) => ThrowEvent("ExcelFileDataInLookupsSaved", e);
			Saving += (s, e) => ThrowEvent("ExcelFileDataInLookupsSaving", e);
			Validating += (s, e) => ThrowEvent("ExcelFileDataInLookupsValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ExcelFileDataInLookups(this);
		}

		#endregion

	}

	#endregion

	#region Class: ExcelFileDataInLookups_BaseEventsProcess

	/// <exclude/>
	public partial class ExcelFileDataInLookups_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ExcelFileDataInLookups
	{

		public ExcelFileDataInLookups_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ExcelFileDataInLookups_BaseEventsProcess";
			SchemaUId = new Guid("463eddd8-ef41-4a2a-9963-1e131327faf8");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("463eddd8-ef41-4a2a-9963-1e131327faf8");
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

	#region Class: ExcelFileDataInLookups_BaseEventsProcess

	/// <exclude/>
	public class ExcelFileDataInLookups_BaseEventsProcess : ExcelFileDataInLookups_BaseEventsProcess<ExcelFileDataInLookups>
	{

		public ExcelFileDataInLookups_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ExcelFileDataInLookups_BaseEventsProcess

	public partial class ExcelFileDataInLookups_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ExcelFileDataInLookupsEventsProcessSchema

	/// <exclude/>
	public class ExcelFileDataInLookupsEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ExcelFileDataInLookupsEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ExcelFileDataInLookupsEventsProcessSchema(ExcelFileDataInLookupsEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ExcelFileDataInLookups_BaseEventsProcess";
			UId = new Guid("513c013d-39d3-4ccb-a3f8-c37fd72c7202");
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
			return new ExcelFileDataInLookupsEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("513c013d-39d3-4ccb-a3f8-c37fd72c7202"));
		}

		#endregion

	}

	#endregion


	#region Class: ExcelFileDataInLookupsEventsProcess

	/// <exclude/>
	public class ExcelFileDataInLookupsEventsProcess : ExcelFileDataInLookups_BaseEventsProcess
	{

		public ExcelFileDataInLookupsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

