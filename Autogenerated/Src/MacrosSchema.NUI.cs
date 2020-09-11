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

	#region Class: MacrosSchema

	/// <exclude/>
	public class MacrosSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public MacrosSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MacrosSchema(MacrosSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MacrosSchema(MacrosSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1");
			RealUId = new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1");
			Name = "Macros";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f");
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
			if (Columns.FindByUId(new Guid("916da6c3-c20d-4b62-833b-bad07832beed")) == null) {
				Columns.Add(CreateCommandColumn());
			}
			if (Columns.FindByUId(new Guid("56f88702-f845-4a06-b282-836e2fcc9689")) == null) {
				Columns.Add(CreateMainParamColumn());
			}
			if (Columns.FindByUId(new Guid("09a029f7-4063-4850-ae8a-783f32fcb677")) == null) {
				Columns.Add(CreateAdditionalParamColumn());
			}
			if (Columns.FindByUId(new Guid("ad30cc8e-0fcb-4b21-9f3e-334d3d8055e7")) == null) {
				Columns.Add(CreateAdditionalParamValueColumn());
			}
			if (Columns.FindByUId(new Guid("d21e1f43-8478-477a-9b15-6811f48b0753")) == null) {
				Columns.Add(CreateMainParamTypeColumn());
			}
			if (Columns.FindByUId(new Guid("9d018884-31bf-4ff3-98e9-a865348fbcc7")) == null) {
				Columns.Add(CreateIsSharedColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1");
			column.CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1");
			column.CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1");
			column.CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1");
			column.CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1");
			column.CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1");
			column.CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f");
			return column;
		}

		protected virtual EntitySchemaColumn CreateCommandColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("916da6c3-c20d-4b62-833b-bad07832beed"),
				Name = @"Command",
				ReferenceSchemaUId = new Guid("0feb9eed-fd62-4ea6-8fd4-2514306e1090"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1"),
				ModifiedInSchemaUId = new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1"),
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("867eb790-be19-4cbb-8807-a36ceaca7b67"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1"),
				ModifiedInSchemaUId = new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1"),
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateMainParamColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("56f88702-f845-4a06-b282-836e2fcc9689"),
				Name = @"MainParam",
				ReferenceSchemaUId = new Guid("28f7da1a-3f4d-4f2d-9d25-75c965cded5d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1"),
				ModifiedInSchemaUId = new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1"),
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			};
		}

		protected virtual EntitySchemaColumn CreateAdditionalParamColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("09a029f7-4063-4850-ae8a-783f32fcb677"),
				Name = @"AdditionalParam",
				ReferenceSchemaUId = new Guid("d066f42d-ebdf-4672-b739-e506edba751b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1"),
				ModifiedInSchemaUId = new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1"),
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			};
		}

		protected virtual EntitySchemaColumn CreateAdditionalParamValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("ad30cc8e-0fcb-4b21-9f3e-334d3d8055e7"),
				Name = @"AdditionalParamValue",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1"),
				ModifiedInSchemaUId = new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1"),
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			};
		}

		protected virtual EntitySchemaColumn CreateMainParamTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("d21e1f43-8478-477a-9b15-6811f48b0753"),
				Name = @"MainParamType",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1"),
				ModifiedInSchemaUId = new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1"),
				CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d")
			};
		}

		protected virtual EntitySchemaColumn CreateIsSharedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("9d018884-31bf-4ff3-98e9-a865348fbcc7"),
				Name = @"IsShared",
				CreatedInSchemaUId = new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1"),
				ModifiedInSchemaUId = new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1"),
				CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMacrosEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateMacrosEventsProcessSchema() {
			var schema = new MacrosEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Macros(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Macros_NUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MacrosSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MacrosSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1"));
		}

		#endregion

	}

	#endregion

	#region Class: Macros

	/// <summary>
	/// Command line macro.
	/// </summary>
	public class Macros : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public Macros(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Macros";
		}

		public Macros(Macros source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid CommandId {
			get {
				return GetTypedColumnValue<Guid>("CommandId");
			}
			set {
				SetColumnValue("CommandId", value);
				_command = null;
			}
		}

		/// <exclude/>
		public string CommandName {
			get {
				return GetTypedColumnValue<string>("CommandName");
			}
			set {
				SetColumnValue("CommandName", value);
				if (_command != null) {
					_command.Name = value;
				}
			}
		}

		private Command _command;
		/// <summary>
		/// Keyword.
		/// </summary>
		public Command Command {
			get {
				return _command ??
					(_command = LookupColumnEntities.GetEntity("Command") as Command);
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

		/// <exclude/>
		public Guid MainParamId {
			get {
				return GetTypedColumnValue<Guid>("MainParamId");
			}
			set {
				SetColumnValue("MainParamId", value);
				_mainParam = null;
			}
		}

		/// <exclude/>
		public string MainParamName {
			get {
				return GetTypedColumnValue<string>("MainParamName");
			}
			set {
				SetColumnValue("MainParamName", value);
				if (_mainParam != null) {
					_mainParam.Name = value;
				}
			}
		}

		private MainParam _mainParam;
		/// <summary>
		/// Primary parameter.
		/// </summary>
		public MainParam MainParam {
			get {
				return _mainParam ??
					(_mainParam = LookupColumnEntities.GetEntity("MainParam") as MainParam);
			}
		}

		/// <exclude/>
		public Guid AdditionalParamId {
			get {
				return GetTypedColumnValue<Guid>("AdditionalParamId");
			}
			set {
				SetColumnValue("AdditionalParamId", value);
				_additionalParam = null;
			}
		}

		/// <exclude/>
		public string AdditionalParamColumnCaption {
			get {
				return GetTypedColumnValue<string>("AdditionalParamColumnCaption");
			}
			set {
				SetColumnValue("AdditionalParamColumnCaption", value);
				if (_additionalParam != null) {
					_additionalParam.ColumnCaption = value;
				}
			}
		}

		private AdditionalParam _additionalParam;
		/// <summary>
		/// Additional parameter.
		/// </summary>
		public AdditionalParam AdditionalParam {
			get {
				return _additionalParam ??
					(_additionalParam = LookupColumnEntities.GetEntity("AdditionalParam") as AdditionalParam);
			}
		}

		/// <summary>
		/// Additional parameter value.
		/// </summary>
		public string AdditionalParamValue {
			get {
				return GetTypedColumnValue<string>("AdditionalParamValue");
			}
			set {
				SetColumnValue("AdditionalParamValue", value);
			}
		}

		/// <summary>
		/// Code of main parameter card type.
		/// </summary>
		public string MainParamType {
			get {
				return GetTypedColumnValue<string>("MainParamType");
			}
			set {
				SetColumnValue("MainParamType", value);
			}
		}

		/// <summary>
		/// Common.
		/// </summary>
		public bool IsShared {
			get {
				return GetTypedColumnValue<bool>("IsShared");
			}
			set {
				SetColumnValue("IsShared", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Macros_NUIEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("MacrosDeleted", e);
			Inserting += (s, e) => ThrowEvent("MacrosInserting", e);
			Validating += (s, e) => ThrowEvent("MacrosValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Macros(this);
		}

		#endregion

	}

	#endregion

	#region Class: Macros_NUIEventsProcess

	/// <exclude/>
	public partial class Macros_NUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : Macros
	{

		public Macros_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Macros_NUIEventsProcess";
			SchemaUId = new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d58c84bf-23c6-462c-a99a-d46acf8b91a1");
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

	#region Class: Macros_NUIEventsProcess

	/// <exclude/>
	public class Macros_NUIEventsProcess : Macros_NUIEventsProcess<Macros>
	{

		public Macros_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Macros_NUIEventsProcess

	public partial class Macros_NUIEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: MacrosEventsProcessSchema

	/// <exclude/>
	public class MacrosEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public MacrosEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MacrosEventsProcessSchema(MacrosEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Macros_NUIEventsProcess";
			UId = new Guid("2fbfb2dc-5d28-4ef9-b3cc-d5d3edc24eb4");
			CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f");
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
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
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
			return new MacrosEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2fbfb2dc-5d28-4ef9-b3cc-d5d3edc24eb4"));
		}

		#endregion

	}

	#endregion


	#region Class: MacrosEventsProcess

	/// <exclude/>
	public class MacrosEventsProcess : Macros_NUIEventsProcess
	{

		public MacrosEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

