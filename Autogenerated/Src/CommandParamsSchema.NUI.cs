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

	#region Class: CommandParamsSchema

	/// <exclude/>
	public class CommandParamsSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public CommandParamsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CommandParamsSchema(CommandParamsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CommandParamsSchema(CommandParamsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e2f77269-f819-46fd-8799-9d5ecef00f8e");
			RealUId = new Guid("e2f77269-f819-46fd-8799-9d5ecef00f8e");
			Name = "CommandParams";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("d75d1e5f-0414-4dff-a8d7-e415c6f43067")) == null) {
				Columns.Add(CreateCommandColumn());
			}
			if (Columns.FindByUId(new Guid("b796b8eb-9c18-41d7-a7d3-67248cc78185")) == null) {
				Columns.Add(CreateMainParamColumn());
			}
			if (Columns.FindByUId(new Guid("1da56012-f89d-437f-ab67-8e7e41aa114f")) == null) {
				Columns.Add(CreateAdditionalParamColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("e2f77269-f819-46fd-8799-9d5ecef00f8e");
			column.CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("e2f77269-f819-46fd-8799-9d5ecef00f8e");
			column.CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("e2f77269-f819-46fd-8799-9d5ecef00f8e");
			column.CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("e2f77269-f819-46fd-8799-9d5ecef00f8e");
			column.CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("e2f77269-f819-46fd-8799-9d5ecef00f8e");
			column.CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("e2f77269-f819-46fd-8799-9d5ecef00f8e");
			column.CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f");
			return column;
		}

		protected virtual EntitySchemaColumn CreateCommandColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d75d1e5f-0414-4dff-a8d7-e415c6f43067"),
				Name = @"Command",
				ReferenceSchemaUId = new Guid("0feb9eed-fd62-4ea6-8fd4-2514306e1090"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e2f77269-f819-46fd-8799-9d5ecef00f8e"),
				ModifiedInSchemaUId = new Guid("e2f77269-f819-46fd-8799-9d5ecef00f8e"),
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			};
		}

		protected virtual EntitySchemaColumn CreateMainParamColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b796b8eb-9c18-41d7-a7d3-67248cc78185"),
				Name = @"MainParam",
				ReferenceSchemaUId = new Guid("28f7da1a-3f4d-4f2d-9d25-75c965cded5d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e2f77269-f819-46fd-8799-9d5ecef00f8e"),
				ModifiedInSchemaUId = new Guid("e2f77269-f819-46fd-8799-9d5ecef00f8e"),
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			};
		}

		protected virtual EntitySchemaColumn CreateAdditionalParamColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1da56012-f89d-437f-ab67-8e7e41aa114f"),
				Name = @"AdditionalParam",
				ReferenceSchemaUId = new Guid("d066f42d-ebdf-4672-b739-e506edba751b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e2f77269-f819-46fd-8799-9d5ecef00f8e"),
				ModifiedInSchemaUId = new Guid("e2f77269-f819-46fd-8799-9d5ecef00f8e"),
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCommandParamsEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCommandParamsEventsProcessSchema() {
			var schema = new CommandParamsEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CommandParams(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CommandParams_NUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CommandParamsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CommandParamsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e2f77269-f819-46fd-8799-9d5ecef00f8e"));
		}

		#endregion

	}

	#endregion

	#region Class: CommandParams

	/// <summary>
	/// Parameters of macros for command line.
	/// </summary>
	public class CommandParams : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public CommandParams(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CommandParams";
		}

		public CommandParams(CommandParams source)
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
		/// Command.
		/// </summary>
		public Command Command {
			get {
				return _command ??
					(_command = LookupColumnEntities.GetEntity("Command") as Command);
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CommandParams_NUIEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CommandParamsDeleted", e);
			Inserting += (s, e) => ThrowEvent("CommandParamsInserting", e);
			Validating += (s, e) => ThrowEvent("CommandParamsValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CommandParams(this);
		}

		#endregion

	}

	#endregion

	#region Class: CommandParams_NUIEventsProcess

	/// <exclude/>
	public partial class CommandParams_NUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : CommandParams
	{

		public CommandParams_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CommandParams_NUIEventsProcess";
			SchemaUId = new Guid("e2f77269-f819-46fd-8799-9d5ecef00f8e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e2f77269-f819-46fd-8799-9d5ecef00f8e");
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

	#region Class: CommandParams_NUIEventsProcess

	/// <exclude/>
	public class CommandParams_NUIEventsProcess : CommandParams_NUIEventsProcess<CommandParams>
	{

		public CommandParams_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CommandParams_NUIEventsProcess

	public partial class CommandParams_NUIEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: CommandParamsEventsProcessSchema

	/// <exclude/>
	public class CommandParamsEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public CommandParamsEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CommandParamsEventsProcessSchema(CommandParamsEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CommandParams_NUIEventsProcess";
			UId = new Guid("128ec432-6162-4a35-95da-432ba3cf3a3e");
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
			return new CommandParamsEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("128ec432-6162-4a35-95da-432ba3cf3a3e"));
		}

		#endregion

	}

	#endregion


	#region Class: CommandParamsEventsProcess

	/// <exclude/>
	public class CommandParamsEventsProcess : CommandParams_NUIEventsProcess
	{

		public CommandParamsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

