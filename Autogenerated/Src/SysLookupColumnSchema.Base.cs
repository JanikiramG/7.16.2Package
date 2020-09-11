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

	#region Class: SysLookupColumnSchema

	/// <exclude/>
	public class SysLookupColumnSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysLookupColumnSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysLookupColumnSchema(SysLookupColumnSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysLookupColumnSchema(SysLookupColumnSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6c654cdc-23c2-49ea-b957-8b5252bea05e");
			RealUId = new Guid("6c654cdc-23c2-49ea-b957-8b5252bea05e");
			Name = "SysLookupColumn";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("c8c10f8f-cfb2-454d-89f6-1fa2b845c0ea")) == null) {
				Columns.Add(CreateSysLookupColumn());
			}
			if (Columns.FindByUId(new Guid("219ff834-643d-4ad3-b154-48f81c3a9c07")) == null) {
				Columns.Add(CreateMetaPathColumn());
			}
			if (Columns.FindByUId(new Guid("d4305e9c-d71c-4b59-8e1c-8309d2970c2f")) == null) {
				Columns.Add(CreatePositionColumn());
			}
			if (Columns.FindByUId(new Guid("dbae20af-93a5-4df8-a239-7cc89873a61e")) == null) {
				Columns.Add(CreateCaptionColumn());
			}
			if (Columns.FindByUId(new Guid("be9f648c-cc8e-4e88-8adb-e9b852486155")) == null) {
				Columns.Add(CreateWidthColumn());
			}
			if (Columns.FindByUId(new Guid("e6806a6c-6698-4696-8e66-df3cfd9eb580")) == null) {
				Columns.Add(CreateSysOrderDirectionColumn());
			}
			if (Columns.FindByUId(new Guid("b72ca89d-b132-4b40-a26e-9d6d34d0ddaf")) == null) {
				Columns.Add(CreateMetaCaptionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysLookupColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c8c10f8f-cfb2-454d-89f6-1fa2b845c0ea"),
				Name = @"SysLookup",
				ReferenceSchemaUId = new Guid("aa3cc352-3095-43c9-ace8-6301f50a0a80"),
				IsCascade = true,
				CreatedInSchemaUId = new Guid("6c654cdc-23c2-49ea-b957-8b5252bea05e"),
				ModifiedInSchemaUId = new Guid("6c654cdc-23c2-49ea-b957-8b5252bea05e"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateMetaPathColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("219ff834-643d-4ad3-b154-48f81c3a9c07"),
				Name = @"MetaPath",
				CreatedInSchemaUId = new Guid("6c654cdc-23c2-49ea-b957-8b5252bea05e"),
				ModifiedInSchemaUId = new Guid("6c654cdc-23c2-49ea-b957-8b5252bea05e"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("d4305e9c-d71c-4b59-8e1c-8309d2970c2f"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("6c654cdc-23c2-49ea-b957-8b5252bea05e"),
				ModifiedInSchemaUId = new Guid("6c654cdc-23c2-49ea-b957-8b5252bea05e"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("dbae20af-93a5-4df8-a239-7cc89873a61e"),
				Name = @"Caption",
				CreatedInSchemaUId = new Guid("6c654cdc-23c2-49ea-b957-8b5252bea05e"),
				ModifiedInSchemaUId = new Guid("6c654cdc-23c2-49ea-b957-8b5252bea05e"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateWidthColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("be9f648c-cc8e-4e88-8adb-e9b852486155"),
				Name = @"Width",
				CreatedInSchemaUId = new Guid("6c654cdc-23c2-49ea-b957-8b5252bea05e"),
				ModifiedInSchemaUId = new Guid("6c654cdc-23c2-49ea-b957-8b5252bea05e"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateSysOrderDirectionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e6806a6c-6698-4696-8e66-df3cfd9eb580"),
				Name = @"SysOrderDirection",
				ReferenceSchemaUId = new Guid("a1198732-ee72-49a0-b9e7-2b61461f6122"),
				CreatedInSchemaUId = new Guid("6c654cdc-23c2-49ea-b957-8b5252bea05e"),
				ModifiedInSchemaUId = new Guid("6c654cdc-23c2-49ea-b957-8b5252bea05e"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateMetaCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("b72ca89d-b132-4b40-a26e-9d6d34d0ddaf"),
				Name = @"MetaCaption",
				CreatedInSchemaUId = new Guid("6c654cdc-23c2-49ea-b957-8b5252bea05e"),
				ModifiedInSchemaUId = new Guid("6c654cdc-23c2-49ea-b957-8b5252bea05e"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysLookupColumnEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysLookupColumnEventsProcessSchema() {
			var schema = new SysLookupColumnEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysLookupColumn(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysLookupColumn_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysLookupColumnSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysLookupColumnSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6c654cdc-23c2-49ea-b957-8b5252bea05e"));
		}

		#endregion

	}

	#endregion

	#region Class: SysLookupColumn

	/// <summary>
	/// Lookup column.
	/// </summary>
	public class SysLookupColumn : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysLookupColumn(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysLookupColumn";
		}

		public SysLookupColumn(SysLookupColumn source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysLookupId {
			get {
				return GetTypedColumnValue<Guid>("SysLookupId");
			}
			set {
				SetColumnValue("SysLookupId", value);
				_sysLookup = null;
			}
		}

		/// <exclude/>
		public string SysLookupName {
			get {
				return GetTypedColumnValue<string>("SysLookupName");
			}
			set {
				SetColumnValue("SysLookupName", value);
				if (_sysLookup != null) {
					_sysLookup.Name = value;
				}
			}
		}

		private SysLookup _sysLookup;
		/// <summary>
		/// Lookup.
		/// </summary>
		public SysLookup SysLookup {
			get {
				return _sysLookup ??
					(_sysLookup = LookupColumnEntities.GetEntity("SysLookup") as SysLookup);
			}
		}

		/// <summary>
		/// Column Id.
		/// </summary>
		public string MetaPath {
			get {
				return GetTypedColumnValue<string>("MetaPath");
			}
			set {
				SetColumnValue("MetaPath", value);
			}
		}

		/// <summary>
		/// Position.
		/// </summary>
		public int Position {
			get {
				return GetTypedColumnValue<int>("Position");
			}
			set {
				SetColumnValue("Position", value);
			}
		}

		/// <summary>
		/// Title.
		/// </summary>
		public string Caption {
			get {
				return GetTypedColumnValue<string>("Caption");
			}
			set {
				SetColumnValue("Caption", value);
			}
		}

		/// <summary>
		/// Width.
		/// </summary>
		public int Width {
			get {
				return GetTypedColumnValue<int>("Width");
			}
			set {
				SetColumnValue("Width", value);
			}
		}

		/// <exclude/>
		public Guid SysOrderDirectionId {
			get {
				return GetTypedColumnValue<Guid>("SysOrderDirectionId");
			}
			set {
				SetColumnValue("SysOrderDirectionId", value);
				_sysOrderDirection = null;
			}
		}

		/// <exclude/>
		public string SysOrderDirectionName {
			get {
				return GetTypedColumnValue<string>("SysOrderDirectionName");
			}
			set {
				SetColumnValue("SysOrderDirectionName", value);
				if (_sysOrderDirection != null) {
					_sysOrderDirection.Name = value;
				}
			}
		}

		private SysOrderDirection _sysOrderDirection;
		/// <summary>
		/// Sort by.
		/// </summary>
		public SysOrderDirection SysOrderDirection {
			get {
				return _sysOrderDirection ??
					(_sysOrderDirection = LookupColumnEntities.GetEntity("SysOrderDirection") as SysOrderDirection);
			}
		}

		/// <summary>
		/// Column.
		/// </summary>
		public string MetaCaption {
			get {
				return GetTypedColumnValue<string>("MetaCaption");
			}
			set {
				SetColumnValue("MetaCaption", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysLookupColumn_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysLookupColumnDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysLookupColumnDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysLookupColumnInserted", e);
			Inserting += (s, e) => ThrowEvent("SysLookupColumnInserting", e);
			Saved += (s, e) => ThrowEvent("SysLookupColumnSaved", e);
			Saving += (s, e) => ThrowEvent("SysLookupColumnSaving", e);
			Validating += (s, e) => ThrowEvent("SysLookupColumnValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysLookupColumn(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysLookupColumn_BaseEventsProcess

	/// <exclude/>
	public partial class SysLookupColumn_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysLookupColumn
	{

		public SysLookupColumn_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysLookupColumn_BaseEventsProcess";
			SchemaUId = new Guid("6c654cdc-23c2-49ea-b957-8b5252bea05e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6c654cdc-23c2-49ea-b957-8b5252bea05e");
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

	#region Class: SysLookupColumn_BaseEventsProcess

	/// <exclude/>
	public class SysLookupColumn_BaseEventsProcess : SysLookupColumn_BaseEventsProcess<SysLookupColumn>
	{

		public SysLookupColumn_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysLookupColumn_BaseEventsProcess

	public partial class SysLookupColumn_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysLookupColumnEventsProcessSchema

	/// <exclude/>
	public class SysLookupColumnEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysLookupColumnEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysLookupColumnEventsProcessSchema(SysLookupColumnEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysLookupColumn_BaseEventsProcess";
			UId = new Guid("7b7c2932-9084-44c5-b77c-243e8f5ee412");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = Guid.Empty;
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
			return new SysLookupColumnEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7b7c2932-9084-44c5-b77c-243e8f5ee412"));
		}

		#endregion

	}

	#endregion


	#region Class: SysLookupColumnEventsProcess

	/// <exclude/>
	public class SysLookupColumnEventsProcess : SysLookupColumn_BaseEventsProcess
	{

		public SysLookupColumnEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

