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

	#region Class: BaseEnrichedDataSchema

	/// <exclude/>
	[IsVirtual]
	public class BaseEnrichedDataSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public BaseEnrichedDataSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BaseEnrichedDataSchema(BaseEnrichedDataSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BaseEnrichedDataSchema(BaseEnrichedDataSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a06e4cd4-ea74-48da-9c77-b37d20d162db");
			RealUId = new Guid("a06e4cd4-ea74-48da-9c77-b37d20d162db");
			Name = "BaseEnrichedData";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("8f65d303-02ac-4efc-966c-086ff392449b");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("8c36bc65-9bce-4d31-84e6-eb38d8126487")) == null) {
				Columns.Add(CreateSearchDateColumn());
			}
			if (Columns.FindByUId(new Guid("9f0edf01-a026-429c-b26b-3f0db9279106")) == null) {
				Columns.Add(CreateCategoryTagColumn());
			}
			if (Columns.FindByUId(new Guid("8ea74488-8ee4-43d3-81f6-edbd8f4f70a5")) == null) {
				Columns.Add(CreateValueColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSearchDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("8c36bc65-9bce-4d31-84e6-eb38d8126487"),
				Name = @"SearchDate",
				CreatedInSchemaUId = new Guid("a06e4cd4-ea74-48da-9c77-b37d20d162db"),
				ModifiedInSchemaUId = new Guid("a06e4cd4-ea74-48da-9c77-b37d20d162db"),
				CreatedInPackageId = new Guid("8f65d303-02ac-4efc-966c-086ff392449b")
			};
		}

		protected virtual EntitySchemaColumn CreateCategoryTagColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("9f0edf01-a026-429c-b26b-3f0db9279106"),
				Name = @"CategoryTag",
				CreatedInSchemaUId = new Guid("a06e4cd4-ea74-48da-9c77-b37d20d162db"),
				ModifiedInSchemaUId = new Guid("a06e4cd4-ea74-48da-9c77-b37d20d162db"),
				CreatedInPackageId = new Guid("8f65d303-02ac-4efc-966c-086ff392449b")
			};
		}

		protected virtual EntitySchemaColumn CreateValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("8ea74488-8ee4-43d3-81f6-edbd8f4f70a5"),
				Name = @"Value",
				CreatedInSchemaUId = new Guid("a06e4cd4-ea74-48da-9c77-b37d20d162db"),
				ModifiedInSchemaUId = new Guid("a06e4cd4-ea74-48da-9c77-b37d20d162db"),
				CreatedInPackageId = new Guid("8f65d303-02ac-4efc-966c-086ff392449b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseEnrichedDataEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateBaseEnrichedDataEventsProcessSchema() {
			var schema = new BaseEnrichedDataEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BaseEnrichedData(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BaseEnrichedData_EnrichmentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BaseEnrichedDataSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BaseEnrichedDataSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a06e4cd4-ea74-48da-9c77-b37d20d162db"));
		}

		#endregion

	}

	#endregion

	#region Class: BaseEnrichedData

	/// <summary>
	/// Base object for unprocessed enriched data.
	/// </summary>
	public class BaseEnrichedData : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public BaseEnrichedData(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BaseEnrichedData";
		}

		public BaseEnrichedData(BaseEnrichedData source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Search date.
		/// </summary>
		public DateTime SearchDate {
			get {
				return GetTypedColumnValue<DateTime>("SearchDate");
			}
			set {
				SetColumnValue("SearchDate", value);
			}
		}

		/// <summary>
		/// Information category tag.
		/// </summary>
		public string CategoryTag {
			get {
				return GetTypedColumnValue<string>("CategoryTag");
			}
			set {
				SetColumnValue("CategoryTag", value);
			}
		}

		/// <summary>
		/// Value.
		/// </summary>
		public string Value {
			get {
				return GetTypedColumnValue<string>("Value");
			}
			set {
				SetColumnValue("Value", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BaseEnrichedData_EnrichmentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BaseEnrichedDataDeleted", e);
			Validating += (s, e) => ThrowEvent("BaseEnrichedDataValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseEnrichedData(this);
		}

		#endregion

	}

	#endregion

	#region Class: BaseEnrichedData_EnrichmentEventsProcess

	/// <exclude/>
	public partial class BaseEnrichedData_EnrichmentEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : BaseEnrichedData
	{

		public BaseEnrichedData_EnrichmentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseEnrichedData_EnrichmentEventsProcess";
			SchemaUId = new Guid("a06e4cd4-ea74-48da-9c77-b37d20d162db");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a06e4cd4-ea74-48da-9c77-b37d20d162db");
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

	#region Class: BaseEnrichedData_EnrichmentEventsProcess

	/// <exclude/>
	public class BaseEnrichedData_EnrichmentEventsProcess : BaseEnrichedData_EnrichmentEventsProcess<BaseEnrichedData>
	{

		public BaseEnrichedData_EnrichmentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseEnrichedData_EnrichmentEventsProcess

	public partial class BaseEnrichedData_EnrichmentEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: BaseEnrichedDataEventsProcessSchema

	/// <exclude/>
	public class BaseEnrichedDataEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public BaseEnrichedDataEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseEnrichedDataEventsProcessSchema(BaseEnrichedDataEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseEnrichedData_EnrichmentEventsProcess";
			UId = new Guid("2c521f91-ecca-454a-995b-db42d9990feb");
			CreatedInPackageId = new Guid("8f65d303-02ac-4efc-966c-086ff392449b");
			CreatedInSchemaUId = Guid.Empty;
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
			return new BaseEnrichedDataEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2c521f91-ecca-454a-995b-db42d9990feb"));
		}

		#endregion

	}

	#endregion


	#region Class: BaseEnrichedDataEventsProcess

	/// <exclude/>
	public class BaseEnrichedDataEventsProcess : BaseEnrichedData_EnrichmentEventsProcess
	{

		public BaseEnrichedDataEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

