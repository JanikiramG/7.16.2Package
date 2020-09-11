﻿namespace Terrasoft.Configuration
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

	#region Class: ScoringRuleSchema

	/// <exclude/>
	public class ScoringRuleSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ScoringRuleSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ScoringRuleSchema(ScoringRuleSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ScoringRuleSchema(ScoringRuleSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b0122734-10d9-4a5b-9364-e8fd3ceccf85");
			RealUId = new Guid("b0122734-10d9-4a5b-9364-e8fd3ceccf85");
			Name = "ScoringRule";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("2172ffdc-40f1-4f25-9efc-3451f9e465a1");
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
			if (Columns.FindByUId(new Guid("c1a837b6-00f6-422e-a657-42b5eb5f53c1")) == null) {
				Columns.Add(CreateScoringModelColumn());
			}
			if (Columns.FindByUId(new Guid("c334f0d3-732f-4d3a-ad3a-4bd4da1e3874")) == null) {
				Columns.Add(CreateFilterDataColumn());
			}
			if (Columns.FindByUId(new Guid("af32b496-b372-4f2a-96bb-5fe5c824c913")) == null) {
				Columns.Add(CreateScoringCountColumn());
			}
			if (Columns.FindByUId(new Guid("6c1fada8-2146-44df-ae01-f078c276724c")) == null) {
				Columns.Add(CreateScoringPointsColumn());
			}
			if (Columns.FindByUId(new Guid("fa1b00ad-e47f-41ca-bcbe-785167a4fc72")) == null) {
				Columns.Add(CreateDurationColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("b2fd743d-292c-4c0f-93b1-69dd045bf617"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("b0122734-10d9-4a5b-9364-e8fd3ceccf85"),
				ModifiedInSchemaUId = new Guid("b0122734-10d9-4a5b-9364-e8fd3ceccf85"),
				CreatedInPackageId = new Guid("2172ffdc-40f1-4f25-9efc-3451f9e465a1")
			};
		}

		protected virtual EntitySchemaColumn CreateScoringModelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c1a837b6-00f6-422e-a657-42b5eb5f53c1"),
				Name = @"ScoringModel",
				ReferenceSchemaUId = new Guid("3dfc230a-58bc-4ab3-9dbe-7eb8225edfa0"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("b0122734-10d9-4a5b-9364-e8fd3ceccf85"),
				ModifiedInSchemaUId = new Guid("b0122734-10d9-4a5b-9364-e8fd3ceccf85"),
				CreatedInPackageId = new Guid("2172ffdc-40f1-4f25-9efc-3451f9e465a1")
			};
		}

		protected virtual EntitySchemaColumn CreateFilterDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("c334f0d3-732f-4d3a-ad3a-4bd4da1e3874"),
				Name = @"FilterData",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("b0122734-10d9-4a5b-9364-e8fd3ceccf85"),
				ModifiedInSchemaUId = new Guid("b0122734-10d9-4a5b-9364-e8fd3ceccf85"),
				CreatedInPackageId = new Guid("2172ffdc-40f1-4f25-9efc-3451f9e465a1")
			};
		}

		protected virtual EntitySchemaColumn CreateScoringCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("af32b496-b372-4f2a-96bb-5fe5c824c913"),
				Name = @"ScoringCount",
				CreatedInSchemaUId = new Guid("b0122734-10d9-4a5b-9364-e8fd3ceccf85"),
				ModifiedInSchemaUId = new Guid("b0122734-10d9-4a5b-9364-e8fd3ceccf85"),
				CreatedInPackageId = new Guid("2172ffdc-40f1-4f25-9efc-3451f9e465a1"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"1"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateScoringPointsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float4")) {
				UId = new Guid("6c1fada8-2146-44df-ae01-f078c276724c"),
				Name = @"ScoringPoints",
				CreatedInSchemaUId = new Guid("b0122734-10d9-4a5b-9364-e8fd3ceccf85"),
				ModifiedInSchemaUId = new Guid("b0122734-10d9-4a5b-9364-e8fd3ceccf85"),
				CreatedInPackageId = new Guid("2172ffdc-40f1-4f25-9efc-3451f9e465a1")
			};
		}

		protected virtual EntitySchemaColumn CreateDurationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("fa1b00ad-e47f-41ca-bcbe-785167a4fc72"),
				Name = @"Duration",
				CreatedInSchemaUId = new Guid("b0122734-10d9-4a5b-9364-e8fd3ceccf85"),
				ModifiedInSchemaUId = new Guid("b0122734-10d9-4a5b-9364-e8fd3ceccf85"),
				CreatedInPackageId = new Guid("2172ffdc-40f1-4f25-9efc-3451f9e465a1"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"1"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateScoringRuleEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateScoringRuleEventsProcessSchema() {
			var schema = new ScoringRuleEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ScoringRule(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ScoringRule_BaseScoringEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ScoringRuleSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ScoringRuleSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b0122734-10d9-4a5b-9364-e8fd3ceccf85"));
		}

		#endregion

	}

	#endregion

	#region Class: ScoringRule

	/// <summary>
	/// Scoring rule.
	/// </summary>
	public class ScoringRule : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ScoringRule(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ScoringRule";
		}

		public ScoringRule(ScoringRule source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Rule name.
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
		public Guid ScoringModelId {
			get {
				return GetTypedColumnValue<Guid>("ScoringModelId");
			}
			set {
				SetColumnValue("ScoringModelId", value);
				_scoringModel = null;
			}
		}

		/// <exclude/>
		public string ScoringModelName {
			get {
				return GetTypedColumnValue<string>("ScoringModelName");
			}
			set {
				SetColumnValue("ScoringModelName", value);
				if (_scoringModel != null) {
					_scoringModel.Name = value;
				}
			}
		}

		private ScoringModel _scoringModel;
		/// <summary>
		/// Scoring model.
		/// </summary>
		public ScoringModel ScoringModel {
			get {
				return _scoringModel ??
					(_scoringModel = LookupColumnEntities.GetEntity("ScoringModel") as ScoringModel);
			}
		}

		/// <summary>
		/// Filter.
		/// </summary>
		public string FilterData {
			get {
				return GetTypedColumnValue<string>("FilterData");
			}
			set {
				SetColumnValue("FilterData", value);
			}
		}

		/// <summary>
		/// Number of times applied.
		/// </summary>
		public int ScoringCount {
			get {
				return GetTypedColumnValue<int>("ScoringCount");
			}
			set {
				SetColumnValue("ScoringCount", value);
			}
		}

		/// <summary>
		/// Scoring points.
		/// </summary>
		public Decimal ScoringPoints {
			get {
				return GetTypedColumnValue<Decimal>("ScoringPoints");
			}
			set {
				SetColumnValue("ScoringPoints", value);
			}
		}

		/// <summary>
		/// Effective for, days.
		/// </summary>
		public int Duration {
			get {
				return GetTypedColumnValue<int>("Duration");
			}
			set {
				SetColumnValue("Duration", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ScoringRule_BaseScoringEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ScoringRuleDeleted", e);
			Validating += (s, e) => ThrowEvent("ScoringRuleValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ScoringRule(this);
		}

		#endregion

	}

	#endregion

	#region Class: ScoringRule_BaseScoringEventsProcess

	/// <exclude/>
	public partial class ScoringRule_BaseScoringEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ScoringRule
	{

		public ScoringRule_BaseScoringEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ScoringRule_BaseScoringEventsProcess";
			SchemaUId = new Guid("b0122734-10d9-4a5b-9364-e8fd3ceccf85");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b0122734-10d9-4a5b-9364-e8fd3ceccf85");
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

	#region Class: ScoringRule_BaseScoringEventsProcess

	/// <exclude/>
	public class ScoringRule_BaseScoringEventsProcess : ScoringRule_BaseScoringEventsProcess<ScoringRule>
	{

		public ScoringRule_BaseScoringEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ScoringRule_BaseScoringEventsProcess

	public partial class ScoringRule_BaseScoringEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ScoringRuleEventsProcessSchema

	/// <exclude/>
	public class ScoringRuleEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ScoringRuleEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ScoringRuleEventsProcessSchema(ScoringRuleEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ScoringRule_BaseScoringEventsProcess";
			UId = new Guid("b7d54e9d-9aa6-48d2-8036-e5b113c080fa");
			CreatedInPackageId = new Guid("2172ffdc-40f1-4f25-9efc-3451f9e465a1");
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
			return new ScoringRuleEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b7d54e9d-9aa6-48d2-8036-e5b113c080fa"));
		}

		#endregion

	}

	#endregion


	#region Class: ScoringRuleEventsProcess

	/// <exclude/>
	public class ScoringRuleEventsProcess : ScoringRule_BaseScoringEventsProcess
	{

		public ScoringRuleEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

