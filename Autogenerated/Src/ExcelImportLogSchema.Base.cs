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

	#region Class: ExcelImportLogSchema

	/// <exclude/>
	public class ExcelImportLogSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ExcelImportLogSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ExcelImportLogSchema(ExcelImportLogSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ExcelImportLogSchema(ExcelImportLogSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b974e2ae-655d-4f5c-9a3c-cb58ae3ad3d0");
			RealUId = new Guid("b974e2ae-655d-4f5c-9a3c-cb58ae3ad3d0");
			Name = "ExcelImportLog";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateMessageTextColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("3db83ec2-10df-4784-9a2b-adb75c2b7ca2")) == null) {
				Columns.Add(CreateExcelImportColumn());
			}
			if (Columns.FindByUId(new Guid("fac8913b-2251-4a13-b757-5faa0e73896f")) == null) {
				Columns.Add(CreateNameColumn());
			}
			if (Columns.FindByUId(new Guid("b767be74-4241-4c80-acc8-e4b88f0e829f")) == null) {
				Columns.Add(CreateStackTraceColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateMessageTextColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("008aa210-1706-4bb0-b5c9-ba9d4b7031f7"),
				Name = @"MessageText",
				CreatedInSchemaUId = new Guid("b974e2ae-655d-4f5c-9a3c-cb58ae3ad3d0"),
				ModifiedInSchemaUId = new Guid("b974e2ae-655d-4f5c-9a3c-cb58ae3ad3d0"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateExcelImportColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3db83ec2-10df-4784-9a2b-adb75c2b7ca2"),
				Name = @"ExcelImport",
				ReferenceSchemaUId = new Guid("85811a1d-f704-4381-b169-eeb0ca280754"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("b974e2ae-655d-4f5c-9a3c-cb58ae3ad3d0"),
				ModifiedInSchemaUId = new Guid("b974e2ae-655d-4f5c-9a3c-cb58ae3ad3d0"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("fac8913b-2251-4a13-b757-5faa0e73896f"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("b974e2ae-655d-4f5c-9a3c-cb58ae3ad3d0"),
				ModifiedInSchemaUId = new Guid("b974e2ae-655d-4f5c-9a3c-cb58ae3ad3d0"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			};
		}

		protected virtual EntitySchemaColumn CreateStackTraceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("b767be74-4241-4c80-acc8-e4b88f0e829f"),
				Name = @"StackTrace",
				CreatedInSchemaUId = new Guid("b974e2ae-655d-4f5c-9a3c-cb58ae3ad3d0"),
				ModifiedInSchemaUId = new Guid("b974e2ae-655d-4f5c-9a3c-cb58ae3ad3d0"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateExcelImportLogEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateExcelImportLogEventsProcessSchema() {
			var schema = new ExcelImportLogEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ExcelImportLog(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ExcelImportLog_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ExcelImportLogSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ExcelImportLogSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b974e2ae-655d-4f5c-9a3c-cb58ae3ad3d0"));
		}

		#endregion

	}

	#endregion

	#region Class: ExcelImportLog

	/// <summary>
	/// Excel import log.
	/// </summary>
	public class ExcelImportLog : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ExcelImportLog(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ExcelImportLog";
		}

		public ExcelImportLog(ExcelImportLog source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Message text.
		/// </summary>
		public string MessageText {
			get {
				return GetTypedColumnValue<string>("MessageText");
			}
			set {
				SetColumnValue("MessageText", value);
			}
		}

		/// <exclude/>
		public Guid ExcelImportId {
			get {
				return GetTypedColumnValue<Guid>("ExcelImportId");
			}
			set {
				SetColumnValue("ExcelImportId", value);
				_excelImport = null;
			}
		}

		private ExcelImport _excelImport;
		/// <summary>
		/// Excel import.
		/// </summary>
		public ExcelImport ExcelImport {
			get {
				return _excelImport ??
					(_excelImport = LookupColumnEntities.GetEntity("ExcelImport") as ExcelImport);
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

		/// <summary>
		/// Stack trace.
		/// </summary>
		public string StackTrace {
			get {
				return GetTypedColumnValue<string>("StackTrace");
			}
			set {
				SetColumnValue("StackTrace", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ExcelImportLog_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ExcelImportLogDeleted", e);
			Deleting += (s, e) => ThrowEvent("ExcelImportLogDeleting", e);
			Inserted += (s, e) => ThrowEvent("ExcelImportLogInserted", e);
			Inserting += (s, e) => ThrowEvent("ExcelImportLogInserting", e);
			Saved += (s, e) => ThrowEvent("ExcelImportLogSaved", e);
			Saving += (s, e) => ThrowEvent("ExcelImportLogSaving", e);
			Validating += (s, e) => ThrowEvent("ExcelImportLogValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ExcelImportLog(this);
		}

		#endregion

	}

	#endregion

	#region Class: ExcelImportLog_BaseEventsProcess

	/// <exclude/>
	public partial class ExcelImportLog_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ExcelImportLog
	{

		public ExcelImportLog_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ExcelImportLog_BaseEventsProcess";
			SchemaUId = new Guid("b974e2ae-655d-4f5c-9a3c-cb58ae3ad3d0");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b974e2ae-655d-4f5c-9a3c-cb58ae3ad3d0");
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

	#region Class: ExcelImportLog_BaseEventsProcess

	/// <exclude/>
	public class ExcelImportLog_BaseEventsProcess : ExcelImportLog_BaseEventsProcess<ExcelImportLog>
	{

		public ExcelImportLog_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ExcelImportLog_BaseEventsProcess

	public partial class ExcelImportLog_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ExcelImportLogEventsProcessSchema

	/// <exclude/>
	public class ExcelImportLogEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ExcelImportLogEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ExcelImportLogEventsProcessSchema(ExcelImportLogEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ExcelImportLog_BaseEventsProcess";
			UId = new Guid("2aae74fc-88b0-4adf-a63d-dfbe8798d133");
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
			return new ExcelImportLogEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2aae74fc-88b0-4adf-a63d-dfbe8798d133"));
		}

		#endregion

	}

	#endregion


	#region Class: ExcelImportLogEventsProcess

	/// <exclude/>
	public class ExcelImportLogEventsProcess : ExcelImportLog_BaseEventsProcess
	{

		public ExcelImportLogEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

