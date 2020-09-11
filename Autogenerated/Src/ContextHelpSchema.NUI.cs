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

	#region Class: ContextHelpSchema

	/// <exclude/>
	public class ContextHelpSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public ContextHelpSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContextHelpSchema(ContextHelpSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContextHelpSchema(ContextHelpSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2f0eac0f-fb07-4efd-9134-b2c5f34a58de");
			RealUId = new Guid("2f0eac0f-fb07-4efd-9134-b2c5f34a58de");
			Name = "ContextHelp";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("528446ff-ac57-46fd-bae2-0e30010fbf6e");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("29ee081e-46ef-43ad-ba0a-26760cf80722")) == null) {
				Columns.Add(CreateContextHelpIdColumn());
			}
			if (Columns.FindByUId(new Guid("d03ca814-c928-480b-9a6b-35a36feec58c")) == null) {
				Columns.Add(CreateLMSUrlColumn());
			}
			if (Columns.FindByUId(new Guid("33c93463-a379-43a2-969e-6d2bafdf51e8")) == null) {
				Columns.Add(CreateProductEditionColumn());
			}
			if (Columns.FindByUId(new Guid("90640866-5a16-4f3b-b98a-f8e41345176b")) == null) {
				Columns.Add(CreateConfigurationVersionColumn());
			}
			if (Columns.FindByUId(new Guid("ab361a09-e74b-464e-b369-410f22e745d7")) == null) {
				Columns.Add(CreateCodeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateContextHelpIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("29ee081e-46ef-43ad-ba0a-26760cf80722"),
				Name = @"ContextHelpId",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("2f0eac0f-fb07-4efd-9134-b2c5f34a58de"),
				ModifiedInSchemaUId = new Guid("2f0eac0f-fb07-4efd-9134-b2c5f34a58de"),
				CreatedInPackageId = new Guid("528446ff-ac57-46fd-bae2-0e30010fbf6e")
			};
		}

		protected virtual EntitySchemaColumn CreateLMSUrlColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("d03ca814-c928-480b-9a6b-35a36feec58c"),
				Name = @"LMSUrl",
				CreatedInSchemaUId = new Guid("2f0eac0f-fb07-4efd-9134-b2c5f34a58de"),
				ModifiedInSchemaUId = new Guid("2f0eac0f-fb07-4efd-9134-b2c5f34a58de"),
				CreatedInPackageId = new Guid("528446ff-ac57-46fd-bae2-0e30010fbf6e")
			};
		}

		protected virtual EntitySchemaColumn CreateProductEditionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("33c93463-a379-43a2-969e-6d2bafdf51e8"),
				Name = @"ProductEdition",
				CreatedInSchemaUId = new Guid("2f0eac0f-fb07-4efd-9134-b2c5f34a58de"),
				ModifiedInSchemaUId = new Guid("2f0eac0f-fb07-4efd-9134-b2c5f34a58de"),
				CreatedInPackageId = new Guid("528446ff-ac57-46fd-bae2-0e30010fbf6e")
			};
		}

		protected virtual EntitySchemaColumn CreateConfigurationVersionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("90640866-5a16-4f3b-b98a-f8e41345176b"),
				Name = @"ConfigurationVersion",
				CreatedInSchemaUId = new Guid("2f0eac0f-fb07-4efd-9134-b2c5f34a58de"),
				ModifiedInSchemaUId = new Guid("2f0eac0f-fb07-4efd-9134-b2c5f34a58de"),
				CreatedInPackageId = new Guid("528446ff-ac57-46fd-bae2-0e30010fbf6e")
			};
		}

		protected virtual EntitySchemaColumn CreateCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("ab361a09-e74b-464e-b369-410f22e745d7"),
				Name = @"Code",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("2f0eac0f-fb07-4efd-9134-b2c5f34a58de"),
				ModifiedInSchemaUId = new Guid("2f0eac0f-fb07-4efd-9134-b2c5f34a58de"),
				CreatedInPackageId = new Guid("528446ff-ac57-46fd-bae2-0e30010fbf6e")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateContextHelpEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateContextHelpEventsProcessSchema() {
			var schema = new ContextHelpEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ContextHelp(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContextHelp_NUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContextHelpSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContextHelpSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2f0eac0f-fb07-4efd-9134-b2c5f34a58de"));
		}

		#endregion

	}

	#endregion

	#region Class: ContextHelp

	/// <summary>
	/// Web help.
	/// </summary>
	public class ContextHelp : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public ContextHelp(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContextHelp";
		}

		public ContextHelp(ContextHelp source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Id.
		/// </summary>
		public int ContextHelpId {
			get {
				return GetTypedColumnValue<int>("ContextHelpId");
			}
			set {
				SetColumnValue("ContextHelpId", value);
			}
		}

		/// <summary>
		/// LMS address.
		/// </summary>
		public string LMSUrl {
			get {
				return GetTypedColumnValue<string>("LMSUrl");
			}
			set {
				SetColumnValue("LMSUrl", value);
			}
		}

		/// <summary>
		/// Product version.
		/// </summary>
		public string ProductEdition {
			get {
				return GetTypedColumnValue<string>("ProductEdition");
			}
			set {
				SetColumnValue("ProductEdition", value);
			}
		}

		/// <summary>
		/// Configuration version.
		/// </summary>
		public string ConfigurationVersion {
			get {
				return GetTypedColumnValue<string>("ConfigurationVersion");
			}
			set {
				SetColumnValue("ConfigurationVersion", value);
			}
		}

		/// <summary>
		/// Code.
		/// </summary>
		public string Code {
			get {
				return GetTypedColumnValue<string>("Code");
			}
			set {
				SetColumnValue("Code", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContextHelp_NUIEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContextHelpDeleted", e);
			Validating += (s, e) => ThrowEvent("ContextHelpValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContextHelp(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContextHelp_NUIEventsProcess

	/// <exclude/>
	public partial class ContextHelp_NUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : ContextHelp
	{

		public ContextHelp_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContextHelp_NUIEventsProcess";
			SchemaUId = new Guid("2f0eac0f-fb07-4efd-9134-b2c5f34a58de");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2f0eac0f-fb07-4efd-9134-b2c5f34a58de");
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

	#region Class: ContextHelp_NUIEventsProcess

	/// <exclude/>
	public class ContextHelp_NUIEventsProcess : ContextHelp_NUIEventsProcess<ContextHelp>
	{

		public ContextHelp_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContextHelp_NUIEventsProcess

	public partial class ContextHelp_NUIEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ContextHelpEventsProcessSchema

	/// <exclude/>
	public class ContextHelpEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public ContextHelpEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ContextHelpEventsProcessSchema(ContextHelpEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ContextHelp_NUIEventsProcess";
			UId = new Guid("26193d0e-d372-47c1-8181-85c3db795c43");
			CreatedInPackageId = new Guid("528446ff-ac57-46fd-bae2-0e30010fbf6e");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1");
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
			return new ContextHelpEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("26193d0e-d372-47c1-8181-85c3db795c43"));
		}

		#endregion

	}

	#endregion


	#region Class: ContextHelpEventsProcess

	/// <exclude/>
	public class ContextHelpEventsProcess : ContextHelp_NUIEventsProcess
	{

		public ContextHelpEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

