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

	#region Class: ProcessInModulesSchema

	/// <exclude/>
	public class ProcessInModulesSchema : Terrasoft.Configuration.ProcessInModules_Base_TerrasoftSchema
	{

		#region Constructors: Public

		public ProcessInModulesSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProcessInModulesSchema(ProcessInModulesSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProcessInModulesSchema(ProcessInModulesSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("3659dc70-dc3e-437f-a4bc-d9a4f9f2b8d2");
			Name = "ProcessInModules";
			ParentSchemaUId = new Guid("60c0cee6-ecb8-4987-bb4a-053bc314ee8d");
			ExtendParent = true;
			CreatedInPackageId = new Guid("35c77563-f7ec-4c0b-91e3-f2665bae1236");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("aadb966f-e2f2-4239-b56f-51ba5fdf0533")) == null) {
				Columns.Add(CreatePositionColumn());
			}
			if (Columns.FindByUId(new Guid("18fd508a-8e32-454d-bd8a-82a9d4028ace")) == null) {
				Columns.Add(CreateParameterUIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("aadb966f-e2f2-4239-b56f-51ba5fdf0533"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("3659dc70-dc3e-437f-a4bc-d9a4f9f2b8d2"),
				ModifiedInSchemaUId = new Guid("3659dc70-dc3e-437f-a4bc-d9a4f9f2b8d2"),
				CreatedInPackageId = new Guid("35c77563-f7ec-4c0b-91e3-f2665bae1236")
			};
		}

		protected virtual EntitySchemaColumn CreateParameterUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("18fd508a-8e32-454d-bd8a-82a9d4028ace"),
				Name = @"ParameterUId",
				CreatedInSchemaUId = new Guid("3659dc70-dc3e-437f-a4bc-d9a4f9f2b8d2"),
				ModifiedInSchemaUId = new Guid("3659dc70-dc3e-437f-a4bc-d9a4f9f2b8d2"),
				CreatedInPackageId = new Guid("b6dd8d56-fd8d-40e5-b50e-aecf2d262cac")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateProcessInModulesEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateProcessInModulesEventsProcessSchema() {
			var schema = new ProcessInModulesEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProcessInModules(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProcessInModules_WizardsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProcessInModulesSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProcessInModulesSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3659dc70-dc3e-437f-a4bc-d9a4f9f2b8d2"));
		}

		#endregion

	}

	#endregion

	#region Class: ProcessInModules

	/// <summary>
	/// Business processes in sections.
	/// </summary>
	/// <remarks>
	/// Business processes in sections.
	/// </remarks>
	public class ProcessInModules : Terrasoft.Configuration.ProcessInModules_Base_Terrasoft
	{

		#region Constructors: Public

		public ProcessInModules(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProcessInModules";
		}

		public ProcessInModules(ProcessInModules source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
		/// Parameter.
		/// </summary>
		public Guid ParameterUId {
			get {
				return GetTypedColumnValue<Guid>("ParameterUId");
			}
			set {
				SetColumnValue("ParameterUId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProcessInModules_WizardsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ProcessInModulesDeleted", e);
			Validating += (s, e) => ThrowEvent("ProcessInModulesValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProcessInModules(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProcessInModules_WizardsEventsProcess

	/// <exclude/>
	public partial class ProcessInModules_WizardsEventsProcess<TEntity> : Terrasoft.Configuration.ProcessInModules_BaseEventsProcess<TEntity> where TEntity : ProcessInModules
	{

		public ProcessInModules_WizardsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProcessInModules_WizardsEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3659dc70-dc3e-437f-a4bc-d9a4f9f2b8d2");
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

	#region Class: ProcessInModules_WizardsEventsProcess

	/// <exclude/>
	public class ProcessInModules_WizardsEventsProcess : ProcessInModules_WizardsEventsProcess<ProcessInModules>
	{

		public ProcessInModules_WizardsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProcessInModules_WizardsEventsProcess

	public partial class ProcessInModules_WizardsEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ProcessInModulesEventsProcessSchema

	/// <exclude/>
	public class ProcessInModulesEventsProcessSchema : Terrasoft.Configuration.ProcessInModules_Base_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public ProcessInModulesEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ProcessInModulesEventsProcessSchema(ProcessInModulesEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ProcessInModules_WizardsEventsProcess";
			UId = new Guid("533b3ff5-ac86-422d-be27-9d6824aea948");
			CreatedInPackageId = new Guid("35c77563-f7ec-4c0b-91e3-f2665bae1236");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("92f949f0-b1b5-412b-9d89-812daaacdb74");
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
				CreatedInPackageId = new Guid("4272a093-21fd-42d2-8625-8b2085681c68")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("4272a093-21fd-42d2-8625-8b2085681c68")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("4272a093-21fd-42d2-8625-8b2085681c68")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("4272a093-21fd-42d2-8625-8b2085681c68")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("4272a093-21fd-42d2-8625-8b2085681c68")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("4272a093-21fd-42d2-8625-8b2085681c68")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("4272a093-21fd-42d2-8625-8b2085681c68")
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
			return new ProcessInModulesEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("533b3ff5-ac86-422d-be27-9d6824aea948"));
		}

		#endregion

	}

	#endregion


	#region Class: ProcessInModulesEventsProcess

	/// <exclude/>
	public class ProcessInModulesEventsProcess : ProcessInModules_WizardsEventsProcess
	{

		public ProcessInModulesEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

