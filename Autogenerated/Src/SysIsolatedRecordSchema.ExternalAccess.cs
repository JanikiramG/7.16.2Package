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

	#region Class: SysIsolatedRecordSchema

	/// <exclude/>
	public class SysIsolatedRecordSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysIsolatedRecordSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysIsolatedRecordSchema(SysIsolatedRecordSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysIsolatedRecordSchema(SysIsolatedRecordSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d0dba5bf-0248-4a93-9396-583751d97281");
			RealUId = new Guid("d0dba5bf-0248-4a93-9396-583751d97281");
			Name = "SysIsolatedRecord";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("7e406f3f-0514-4d14-a20b-c3a59a45194f");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateEntitySchemaNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("3653f165-0d35-45ea-8acf-48a669a5a28a")) == null) {
				Columns.Add(CreateRecordIdColumn());
			}
			if (Columns.FindByUId(new Guid("fa580cbe-be37-4f0d-b166-aed558042ea0")) == null) {
				Columns.Add(CreateExternalAccessColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("537fa4ca-25c5-4484-b722-f3e5b730adad"),
				Name = @"EntitySchemaName",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d0dba5bf-0248-4a93-9396-583751d97281"),
				ModifiedInSchemaUId = new Guid("d0dba5bf-0248-4a93-9396-583751d97281"),
				CreatedInPackageId = new Guid("7e406f3f-0514-4d14-a20b-c3a59a45194f")
			};
		}

		protected virtual EntitySchemaColumn CreateRecordIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("3653f165-0d35-45ea-8acf-48a669a5a28a"),
				Name = @"RecordId",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d0dba5bf-0248-4a93-9396-583751d97281"),
				ModifiedInSchemaUId = new Guid("d0dba5bf-0248-4a93-9396-583751d97281"),
				CreatedInPackageId = new Guid("7e406f3f-0514-4d14-a20b-c3a59a45194f")
			};
		}

		protected virtual EntitySchemaColumn CreateExternalAccessColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fa580cbe-be37-4f0d-b166-aed558042ea0"),
				Name = @"ExternalAccess",
				ReferenceSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d0dba5bf-0248-4a93-9396-583751d97281"),
				ModifiedInSchemaUId = new Guid("d0dba5bf-0248-4a93-9396-583751d97281"),
				CreatedInPackageId = new Guid("edb637f8-a36b-404a-83af-5c35db85ff97")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysIsolatedRecordEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysIsolatedRecordEventsProcessSchema() {
			var schema = new SysIsolatedRecordEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysIsolatedRecord(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysIsolatedRecord_ExternalAccessEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysIsolatedRecordSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysIsolatedRecordSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d0dba5bf-0248-4a93-9396-583751d97281"));
		}

		#endregion

	}

	#endregion

	#region Class: SysIsolatedRecord

	/// <summary>
	/// SysIsolatedRecord.
	/// </summary>
	public class SysIsolatedRecord : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysIsolatedRecord(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysIsolatedRecord";
		}

		public SysIsolatedRecord(SysIsolatedRecord source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Entity schema name.
		/// </summary>
		public string EntitySchemaName {
			get {
				return GetTypedColumnValue<string>("EntitySchemaName");
			}
			set {
				SetColumnValue("EntitySchemaName", value);
			}
		}

		/// <summary>
		/// Record id.
		/// </summary>
		public Guid RecordId {
			get {
				return GetTypedColumnValue<Guid>("RecordId");
			}
			set {
				SetColumnValue("RecordId", value);
			}
		}

		/// <exclude/>
		public Guid ExternalAccessId {
			get {
				return GetTypedColumnValue<Guid>("ExternalAccessId");
			}
			set {
				SetColumnValue("ExternalAccessId", value);
				_externalAccess = null;
			}
		}

		/// <exclude/>
		public string ExternalAccessAccessReason {
			get {
				return GetTypedColumnValue<string>("ExternalAccessAccessReason");
			}
			set {
				SetColumnValue("ExternalAccessAccessReason", value);
				if (_externalAccess != null) {
					_externalAccess.AccessReason = value;
				}
			}
		}

		private ExternalAccess _externalAccess;
		/// <summary>
		/// Created by external access.
		/// </summary>
		public ExternalAccess ExternalAccess {
			get {
				return _externalAccess ??
					(_externalAccess = LookupColumnEntities.GetEntity("ExternalAccess") as ExternalAccess);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysIsolatedRecord_ExternalAccessEventsProcess(UserConnection);
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
			return new SysIsolatedRecord(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysIsolatedRecord_ExternalAccessEventsProcess

	/// <exclude/>
	public partial class SysIsolatedRecord_ExternalAccessEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysIsolatedRecord
	{

		public SysIsolatedRecord_ExternalAccessEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysIsolatedRecord_ExternalAccessEventsProcess";
			SchemaUId = new Guid("d0dba5bf-0248-4a93-9396-583751d97281");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d0dba5bf-0248-4a93-9396-583751d97281");
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

	#region Class: SysIsolatedRecord_ExternalAccessEventsProcess

	/// <exclude/>
	public class SysIsolatedRecord_ExternalAccessEventsProcess : SysIsolatedRecord_ExternalAccessEventsProcess<SysIsolatedRecord>
	{

		public SysIsolatedRecord_ExternalAccessEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysIsolatedRecord_ExternalAccessEventsProcess

	public partial class SysIsolatedRecord_ExternalAccessEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysIsolatedRecordEventsProcessSchema

	/// <exclude/>
	public class SysIsolatedRecordEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysIsolatedRecordEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysIsolatedRecordEventsProcessSchema(SysIsolatedRecordEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysIsolatedRecord_ExternalAccessEventsProcess";
			UId = new Guid("f498d043-0b86-4857-a196-338242b1f3a1");
			CreatedInPackageId = new Guid("7e406f3f-0514-4d14-a20b-c3a59a45194f");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.14.4.0";
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
			return new SysIsolatedRecordEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f498d043-0b86-4857-a196-338242b1f3a1"));
		}

		#endregion

	}

	#endregion


	#region Class: SysIsolatedRecordEventsProcess

	/// <exclude/>
	public class SysIsolatedRecordEventsProcess : SysIsolatedRecord_ExternalAccessEventsProcess
	{

		public SysIsolatedRecordEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

