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

	#region Class: ChunkProcessResultSchema

	/// <exclude/>
	public class ChunkProcessResultSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ChunkProcessResultSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ChunkProcessResultSchema(ChunkProcessResultSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ChunkProcessResultSchema(ChunkProcessResultSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("51f35bd5-4faf-4c75-a7c2-b795acb6dfce");
			RealUId = new Guid("51f35bd5-4faf-4c75-a7c2-b795acb6dfce");
			Name = "ChunkProcessResult";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("43217ca0-9cc8-4686-97cb-b4e38c279a82")) == null) {
				Columns.Add(CreateImportSessionChunkColumn());
			}
			if (Columns.FindByUId(new Guid("c6b9a4ed-c0d3-4e08-a94e-033bd3174b28")) == null) {
				Columns.Add(CreateRowIndexColumn());
			}
			if (Columns.FindByUId(new Guid("c340fe4b-81bf-48c7-8d58-76b58ab301a6")) == null) {
				Columns.Add(CreateSuccessColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateImportSessionChunkColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("43217ca0-9cc8-4686-97cb-b4e38c279a82"),
				Name = @"ImportSessionChunk",
				ReferenceSchemaUId = new Guid("573c37a8-74f2-4cba-b256-3a4b87b625e7"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("51f35bd5-4faf-4c75-a7c2-b795acb6dfce"),
				ModifiedInSchemaUId = new Guid("51f35bd5-4faf-4c75-a7c2-b795acb6dfce"),
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8")
			};
		}

		protected virtual EntitySchemaColumn CreateRowIndexColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("c6b9a4ed-c0d3-4e08-a94e-033bd3174b28"),
				Name = @"RowIndex",
				CreatedInSchemaUId = new Guid("51f35bd5-4faf-4c75-a7c2-b795acb6dfce"),
				ModifiedInSchemaUId = new Guid("51f35bd5-4faf-4c75-a7c2-b795acb6dfce"),
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8")
			};
		}

		protected virtual EntitySchemaColumn CreateSuccessColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("c340fe4b-81bf-48c7-8d58-76b58ab301a6"),
				Name = @"Success",
				CreatedInSchemaUId = new Guid("51f35bd5-4faf-4c75-a7c2-b795acb6dfce"),
				ModifiedInSchemaUId = new Guid("51f35bd5-4faf-4c75-a7c2-b795acb6dfce"),
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateChunkProcessResultEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateChunkProcessResultEventsProcessSchema() {
			var schema = new ChunkProcessResultEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ChunkProcessResult(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ChunkProcessResult_FileImportEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ChunkProcessResultSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ChunkProcessResultSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("51f35bd5-4faf-4c75-a7c2-b795acb6dfce"));
		}

		#endregion

	}

	#endregion

	#region Class: ChunkProcessResult

	/// <summary>
	/// ImportChunkProcessResult.
	/// </summary>
	public class ChunkProcessResult : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ChunkProcessResult(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ChunkProcessResult";
		}

		public ChunkProcessResult(ChunkProcessResult source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ImportSessionChunkId {
			get {
				return GetTypedColumnValue<Guid>("ImportSessionChunkId");
			}
			set {
				SetColumnValue("ImportSessionChunkId", value);
				_importSessionChunk = null;
			}
		}

		private ImportSessionChunk _importSessionChunk;
		/// <summary>
		/// ImportSessionChunk.
		/// </summary>
		public ImportSessionChunk ImportSessionChunk {
			get {
				return _importSessionChunk ??
					(_importSessionChunk = LookupColumnEntities.GetEntity("ImportSessionChunk") as ImportSessionChunk);
			}
		}

		/// <summary>
		/// RowIndex.
		/// </summary>
		public int RowIndex {
			get {
				return GetTypedColumnValue<int>("RowIndex");
			}
			set {
				SetColumnValue("RowIndex", value);
			}
		}

		/// <summary>
		/// Success.
		/// </summary>
		public bool Success {
			get {
				return GetTypedColumnValue<bool>("Success");
			}
			set {
				SetColumnValue("Success", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ChunkProcessResult_FileImportEventsProcess(UserConnection);
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
			return new ChunkProcessResult(this);
		}

		#endregion

	}

	#endregion

	#region Class: ChunkProcessResult_FileImportEventsProcess

	/// <exclude/>
	public partial class ChunkProcessResult_FileImportEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ChunkProcessResult
	{

		public ChunkProcessResult_FileImportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ChunkProcessResult_FileImportEventsProcess";
			SchemaUId = new Guid("51f35bd5-4faf-4c75-a7c2-b795acb6dfce");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("51f35bd5-4faf-4c75-a7c2-b795acb6dfce");
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

	#region Class: ChunkProcessResult_FileImportEventsProcess

	/// <exclude/>
	public class ChunkProcessResult_FileImportEventsProcess : ChunkProcessResult_FileImportEventsProcess<ChunkProcessResult>
	{

		public ChunkProcessResult_FileImportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ChunkProcessResult_FileImportEventsProcess

	public partial class ChunkProcessResult_FileImportEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ChunkProcessResultEventsProcessSchema

	/// <exclude/>
	public class ChunkProcessResultEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ChunkProcessResultEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ChunkProcessResultEventsProcessSchema(ChunkProcessResultEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ChunkProcessResult_FileImportEventsProcess";
			UId = new Guid("5d574951-85f3-4f59-9873-0dae3c089906");
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
			return new ChunkProcessResultEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5d574951-85f3-4f59-9873-0dae3c089906"));
		}

		#endregion

	}

	#endregion


	#region Class: ChunkProcessResultEventsProcess

	/// <exclude/>
	public class ChunkProcessResultEventsProcess : ChunkProcessResult_FileImportEventsProcess
	{

		public ChunkProcessResultEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

