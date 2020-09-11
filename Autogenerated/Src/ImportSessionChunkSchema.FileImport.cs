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

	#region Class: ImportSessionChunkSchema

	/// <exclude/>
	public class ImportSessionChunkSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ImportSessionChunkSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ImportSessionChunkSchema(ImportSessionChunkSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ImportSessionChunkSchema(ImportSessionChunkSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("573c37a8-74f2-4cba-b256-3a4b87b625e7");
			RealUId = new Guid("573c37a8-74f2-4cba-b256-3a4b87b625e7");
			Name = "ImportSessionChunk";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("26a2a19e-2d5f-44fb-bbfa-6a5fa78e9942")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("1c68b0b3-1bea-4817-af7c-5d19e0a7910d")) == null) {
				Columns.Add(CreateStateColumn());
			}
			if (Columns.FindByUId(new Guid("b7b5f0b3-b065-47c2-9c36-059090ecc7f7")) == null) {
				Columns.Add(CreateDataColumn());
			}
			if (Columns.FindByUId(new Guid("33f2cc01-d286-48a9-b262-b721333fbec6")) == null) {
				Columns.Add(CreateImportParametersColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("26a2a19e-2d5f-44fb-bbfa-6a5fa78e9942"),
				Name = @"Type",
				CreatedInSchemaUId = new Guid("573c37a8-74f2-4cba-b256-3a4b87b625e7"),
				ModifiedInSchemaUId = new Guid("573c37a8-74f2-4cba-b256-3a4b87b625e7"),
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8")
			};
		}

		protected virtual EntitySchemaColumn CreateStateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("1c68b0b3-1bea-4817-af7c-5d19e0a7910d"),
				Name = @"State",
				CreatedInSchemaUId = new Guid("573c37a8-74f2-4cba-b256-3a4b87b625e7"),
				ModifiedInSchemaUId = new Guid("573c37a8-74f2-4cba-b256-3a4b87b625e7"),
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8")
			};
		}

		protected virtual EntitySchemaColumn CreateDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("b7b5f0b3-b065-47c2-9c36-059090ecc7f7"),
				Name = @"Data",
				CreatedInSchemaUId = new Guid("573c37a8-74f2-4cba-b256-3a4b87b625e7"),
				ModifiedInSchemaUId = new Guid("573c37a8-74f2-4cba-b256-3a4b87b625e7"),
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8")
			};
		}

		protected virtual EntitySchemaColumn CreateImportParametersColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("33f2cc01-d286-48a9-b262-b721333fbec6"),
				Name = @"ImportParameters",
				ReferenceSchemaUId = new Guid("5706d121-64c5-4c09-a4a3-ee6e82c47e1a"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("573c37a8-74f2-4cba-b256-3a4b87b625e7"),
				ModifiedInSchemaUId = new Guid("573c37a8-74f2-4cba-b256-3a4b87b625e7"),
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateImportSessionChunkEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateImportSessionChunkEventsProcessSchema() {
			var schema = new ImportSessionChunkEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ImportSessionChunk(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ImportSessionChunk_FileImportEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ImportSessionChunkSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ImportSessionChunkSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("573c37a8-74f2-4cba-b256-3a4b87b625e7"));
		}

		#endregion

	}

	#endregion

	#region Class: ImportSessionChunk

	/// <summary>
	/// ImportSessionChunk.
	/// </summary>
	/// <remarks>
	/// Import session chunks.
	/// </remarks>
	public class ImportSessionChunk : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ImportSessionChunk(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ImportSessionChunk";
		}

		public ImportSessionChunk(ImportSessionChunk source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Type.
		/// </summary>
		/// <remarks>
		/// Chunk data type.
		/// </remarks>
		public int Type {
			get {
				return GetTypedColumnValue<int>("Type");
			}
			set {
				SetColumnValue("Type", value);
			}
		}

		/// <summary>
		/// State.
		/// </summary>
		/// <remarks>
		/// Chunk state.
		/// </remarks>
		public int State {
			get {
				return GetTypedColumnValue<int>("State");
			}
			set {
				SetColumnValue("State", value);
			}
		}

		/// <exclude/>
		public Guid ImportParametersId {
			get {
				return GetTypedColumnValue<Guid>("ImportParametersId");
			}
			set {
				SetColumnValue("ImportParametersId", value);
				_importParameters = null;
			}
		}

		private FileImportParameters _importParameters;
		/// <summary>
		/// ImportParameters.
		/// </summary>
		public FileImportParameters ImportParameters {
			get {
				return _importParameters ??
					(_importParameters = LookupColumnEntities.GetEntity("ImportParameters") as FileImportParameters);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ImportSessionChunk_FileImportEventsProcess(UserConnection);
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
			return new ImportSessionChunk(this);
		}

		#endregion

	}

	#endregion

	#region Class: ImportSessionChunk_FileImportEventsProcess

	/// <exclude/>
	public partial class ImportSessionChunk_FileImportEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ImportSessionChunk
	{

		public ImportSessionChunk_FileImportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ImportSessionChunk_FileImportEventsProcess";
			SchemaUId = new Guid("573c37a8-74f2-4cba-b256-3a4b87b625e7");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("573c37a8-74f2-4cba-b256-3a4b87b625e7");
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

	#region Class: ImportSessionChunk_FileImportEventsProcess

	/// <exclude/>
	public class ImportSessionChunk_FileImportEventsProcess : ImportSessionChunk_FileImportEventsProcess<ImportSessionChunk>
	{

		public ImportSessionChunk_FileImportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ImportSessionChunk_FileImportEventsProcess

	public partial class ImportSessionChunk_FileImportEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ImportSessionChunkEventsProcessSchema

	/// <exclude/>
	public class ImportSessionChunkEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ImportSessionChunkEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ImportSessionChunkEventsProcessSchema(ImportSessionChunkEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ImportSessionChunk_FileImportEventsProcess";
			UId = new Guid("b017e2e5-2ba4-4879-b0f1-5abf18d87801");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
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
			return new ImportSessionChunkEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b017e2e5-2ba4-4879-b0f1-5abf18d87801"));
		}

		#endregion

	}

	#endregion


	#region Class: ImportSessionChunkEventsProcess

	/// <exclude/>
	public class ImportSessionChunkEventsProcess : ImportSessionChunk_FileImportEventsProcess
	{

		public ImportSessionChunkEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

