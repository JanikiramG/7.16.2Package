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

	#region Class: SysEntityPrcStartEventSchema

	/// <exclude/>
	public class SysEntityPrcStartEventSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysEntityPrcStartEventSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysEntityPrcStartEventSchema(SysEntityPrcStartEventSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysEntityPrcStartEventSchema(SysEntityPrcStartEventSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("242f3dc6-e518-471f-a378-bdcc0dd39f05");
			RealUId = new Guid("242f3dc6-e518-471f-a378-bdcc0dd39f05");
			Name = "SysEntityPrcStartEvent";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("e5f93276-5bd3-4d2e-9557-2ac88fa9589e")) == null) {
				Columns.Add(CreateProcessSchemaColumn());
			}
			if (Columns.FindByUId(new Guid("b1124703-2023-4b89-95be-983cf4da02e3")) == null) {
				Columns.Add(CreateProcessSchemaElementUIdColumn());
			}
			if (Columns.FindByUId(new Guid("58db3489-5436-4a1f-9c5f-3ccdd246a5f1")) == null) {
				Columns.Add(CreateRecordChangeTypeColumn());
			}
			if (Columns.FindByUId(new Guid("4b947135-42bf-4c4d-8998-18e9c22bd16f")) == null) {
				Columns.Add(CreateConditionDataColumn());
			}
			if (Columns.FindByUId(new Guid("f5817e5b-fddb-4e9d-9658-d6f3f2b8aba7")) == null) {
				Columns.Add(CreateChangedColumnsColumn());
			}
			if (Columns.FindByUId(new Guid("e7b416c5-1d0b-404a-a479-9c7b5c4aa49f")) == null) {
				Columns.Add(CreateWaitingRandomSignalColumn());
			}
			if (Columns.FindByUId(new Guid("7af4c988-a223-467e-a3b1-308ad5a4d230")) == null) {
				Columns.Add(CreateSignalColumn());
			}
			if (Columns.FindByUId(new Guid("05e649df-eb5f-4670-8943-7e25969ac5c9")) == null) {
				Columns.Add(CreateEntitySchemaUIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateProcessSchemaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e5f93276-5bd3-4d2e-9557-2ac88fa9589e"),
				Name = @"ProcessSchema",
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("242f3dc6-e518-471f-a378-bdcc0dd39f05"),
				ModifiedInSchemaUId = new Guid("242f3dc6-e518-471f-a378-bdcc0dd39f05"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateProcessSchemaElementUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("b1124703-2023-4b89-95be-983cf4da02e3"),
				Name = @"ProcessSchemaElementUId",
				CreatedInSchemaUId = new Guid("242f3dc6-e518-471f-a378-bdcc0dd39f05"),
				ModifiedInSchemaUId = new Guid("242f3dc6-e518-471f-a378-bdcc0dd39f05"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateRecordChangeTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("58db3489-5436-4a1f-9c5f-3ccdd246a5f1"),
				Name = @"RecordChangeType",
				CreatedInSchemaUId = new Guid("242f3dc6-e518-471f-a378-bdcc0dd39f05"),
				ModifiedInSchemaUId = new Guid("242f3dc6-e518-471f-a378-bdcc0dd39f05"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateConditionDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("4b947135-42bf-4c4d-8998-18e9c22bd16f"),
				Name = @"ConditionData",
				CreatedInSchemaUId = new Guid("242f3dc6-e518-471f-a378-bdcc0dd39f05"),
				ModifiedInSchemaUId = new Guid("242f3dc6-e518-471f-a378-bdcc0dd39f05"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateChangedColumnsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("f5817e5b-fddb-4e9d-9658-d6f3f2b8aba7"),
				Name = @"ChangedColumns",
				CreatedInSchemaUId = new Guid("242f3dc6-e518-471f-a378-bdcc0dd39f05"),
				ModifiedInSchemaUId = new Guid("242f3dc6-e518-471f-a378-bdcc0dd39f05"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateWaitingRandomSignalColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("e7b416c5-1d0b-404a-a479-9c7b5c4aa49f"),
				Name = @"WaitingRandomSignal",
				CreatedInSchemaUId = new Guid("242f3dc6-e518-471f-a378-bdcc0dd39f05"),
				ModifiedInSchemaUId = new Guid("242f3dc6-e518-471f-a378-bdcc0dd39f05"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateSignalColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("7af4c988-a223-467e-a3b1-308ad5a4d230"),
				Name = @"Signal",
				CreatedInSchemaUId = new Guid("242f3dc6-e518-471f-a378-bdcc0dd39f05"),
				ModifiedInSchemaUId = new Guid("242f3dc6-e518-471f-a378-bdcc0dd39f05"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("05e649df-eb5f-4670-8943-7e25969ac5c9"),
				Name = @"EntitySchemaUId",
				CreatedInSchemaUId = new Guid("242f3dc6-e518-471f-a378-bdcc0dd39f05"),
				ModifiedInSchemaUId = new Guid("242f3dc6-e518-471f-a378-bdcc0dd39f05"),
				CreatedInPackageId = new Guid("f22d92fb-0351-4268-afec-308cab404801")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysEntityPrcStartEventEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysEntityPrcStartEventEventsProcessSchema() {
			var schema = new SysEntityPrcStartEventEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysEntityPrcStartEvent(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysEntityPrcStartEvent_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysEntityPrcStartEventSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysEntityPrcStartEventSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("242f3dc6-e518-471f-a378-bdcc0dd39f05"));
		}

		#endregion

	}

	#endregion

	#region Class: SysEntityPrcStartEvent

	/// <summary>
	/// Start event of business process.
	/// </summary>
	public class SysEntityPrcStartEvent : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysEntityPrcStartEvent(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysEntityPrcStartEvent";
		}

		public SysEntityPrcStartEvent(SysEntityPrcStartEvent source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ProcessSchemaId {
			get {
				return GetTypedColumnValue<Guid>("ProcessSchemaId");
			}
			set {
				SetColumnValue("ProcessSchemaId", value);
				_processSchema = null;
			}
		}

		/// <exclude/>
		public string ProcessSchemaCaption {
			get {
				return GetTypedColumnValue<string>("ProcessSchemaCaption");
			}
			set {
				SetColumnValue("ProcessSchemaCaption", value);
				if (_processSchema != null) {
					_processSchema.Caption = value;
				}
			}
		}

		private SysSchema _processSchema;
		/// <summary>
		/// Process schema.
		/// </summary>
		public SysSchema ProcessSchema {
			get {
				return _processSchema ??
					(_processSchema = LookupColumnEntities.GetEntity("ProcessSchema") as SysSchema);
			}
		}

		/// <summary>
		/// Process item.
		/// </summary>
		public Guid ProcessSchemaElementUId {
			get {
				return GetTypedColumnValue<Guid>("ProcessSchemaElementUId");
			}
			set {
				SetColumnValue("ProcessSchemaElementUId", value);
			}
		}

		/// <summary>
		/// Modification type.
		/// </summary>
		public int RecordChangeType {
			get {
				return GetTypedColumnValue<int>("RecordChangeType");
			}
			set {
				SetColumnValue("RecordChangeType", value);
			}
		}

		/// <summary>
		/// Event start conditions.
		/// </summary>
		public string ConditionData {
			get {
				return GetTypedColumnValue<string>("ConditionData");
			}
			set {
				SetColumnValue("ConditionData", value);
			}
		}

		/// <summary>
		/// Event start conditions by changed columns.
		/// </summary>
		public string ChangedColumns {
			get {
				return GetTypedColumnValue<string>("ChangedColumns");
			}
			set {
				SetColumnValue("ChangedColumns", value);
			}
		}

		/// <summary>
		/// Catch custom signal.
		/// </summary>
		public bool WaitingRandomSignal {
			get {
				return GetTypedColumnValue<bool>("WaitingRandomSignal");
			}
			set {
				SetColumnValue("WaitingRandomSignal", value);
			}
		}

		/// <summary>
		/// Signal.
		/// </summary>
		public string Signal {
			get {
				return GetTypedColumnValue<string>("Signal");
			}
			set {
				SetColumnValue("Signal", value);
			}
		}

		/// <summary>
		/// Object schema.
		/// </summary>
		public Guid EntitySchemaUId {
			get {
				return GetTypedColumnValue<Guid>("EntitySchemaUId");
			}
			set {
				SetColumnValue("EntitySchemaUId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysEntityPrcStartEvent_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysEntityPrcStartEventDeleted", e);
			Inserted += (s, e) => ThrowEvent("SysEntityPrcStartEventInserted", e);
			Inserting += (s, e) => ThrowEvent("SysEntityPrcStartEventInserting", e);
			Saving += (s, e) => ThrowEvent("SysEntityPrcStartEventSaving", e);
			Validating += (s, e) => ThrowEvent("SysEntityPrcStartEventValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysEntityPrcStartEvent(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysEntityPrcStartEvent_BaseEventsProcess

	/// <exclude/>
	public partial class SysEntityPrcStartEvent_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysEntityPrcStartEvent
	{

		public SysEntityPrcStartEvent_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysEntityPrcStartEvent_BaseEventsProcess";
			SchemaUId = new Guid("242f3dc6-e518-471f-a378-bdcc0dd39f05");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("242f3dc6-e518-471f-a378-bdcc0dd39f05");
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

	#region Class: SysEntityPrcStartEvent_BaseEventsProcess

	/// <exclude/>
	public class SysEntityPrcStartEvent_BaseEventsProcess : SysEntityPrcStartEvent_BaseEventsProcess<SysEntityPrcStartEvent>
	{

		public SysEntityPrcStartEvent_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysEntityPrcStartEvent_BaseEventsProcess

	public partial class SysEntityPrcStartEvent_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysEntityPrcStartEventEventsProcessSchema

	/// <exclude/>
	public class SysEntityPrcStartEventEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysEntityPrcStartEventEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysEntityPrcStartEventEventsProcessSchema(SysEntityPrcStartEventEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysEntityPrcStartEvent_BaseEventsProcess";
			UId = new Guid("a7027aaa-f026-4566-b2e1-82a7d7a47b3f");
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
			return new SysEntityPrcStartEventEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a7027aaa-f026-4566-b2e1-82a7d7a47b3f"));
		}

		#endregion

	}

	#endregion


	#region Class: SysEntityPrcStartEventEventsProcess

	/// <exclude/>
	public class SysEntityPrcStartEventEventsProcess : SysEntityPrcStartEvent_BaseEventsProcess
	{

		public SysEntityPrcStartEventEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

