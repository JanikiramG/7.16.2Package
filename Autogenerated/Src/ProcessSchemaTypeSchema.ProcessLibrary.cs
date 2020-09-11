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

	#region Class: ProcessSchemaTypeSchema

	/// <exclude/>
	public class ProcessSchemaTypeSchema : Terrasoft.Configuration.BaseCodeLookupSchema
	{

		#region Constructors: Public

		public ProcessSchemaTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProcessSchemaTypeSchema(ProcessSchemaTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProcessSchemaTypeSchema(ProcessSchemaTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cd5b7045-5f50-4fff-9b87-a4036df2355a");
			RealUId = new Guid("cd5b7045-5f50-4fff-9b87-a4036df2355a");
			Name = "ProcessSchemaType";
			ParentSchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("42153226-7fbf-4ddd-9a0b-5c3f0ef85ffa");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("cd5b7045-5f50-4fff-9b87-a4036df2355a");
			column.CreatedInPackageId = new Guid("42153226-7fbf-4ddd-9a0b-5c3f0ef85ffa");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("cd5b7045-5f50-4fff-9b87-a4036df2355a");
			column.CreatedInPackageId = new Guid("42153226-7fbf-4ddd-9a0b-5c3f0ef85ffa");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("cd5b7045-5f50-4fff-9b87-a4036df2355a");
			column.CreatedInPackageId = new Guid("42153226-7fbf-4ddd-9a0b-5c3f0ef85ffa");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("cd5b7045-5f50-4fff-9b87-a4036df2355a");
			column.CreatedInPackageId = new Guid("42153226-7fbf-4ddd-9a0b-5c3f0ef85ffa");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("cd5b7045-5f50-4fff-9b87-a4036df2355a");
			column.CreatedInPackageId = new Guid("42153226-7fbf-4ddd-9a0b-5c3f0ef85ffa");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("cd5b7045-5f50-4fff-9b87-a4036df2355a");
			column.CreatedInPackageId = new Guid("42153226-7fbf-4ddd-9a0b-5c3f0ef85ffa");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("cd5b7045-5f50-4fff-9b87-a4036df2355a");
			column.CreatedInPackageId = new Guid("42153226-7fbf-4ddd-9a0b-5c3f0ef85ffa");
			return column;
		}

		protected override EntitySchemaColumn CreateCodeColumn() {
			EntitySchemaColumn column = base.CreateCodeColumn();
			column.ModifiedInSchemaUId = new Guid("cd5b7045-5f50-4fff-9b87-a4036df2355a");
			column.CreatedInPackageId = new Guid("42153226-7fbf-4ddd-9a0b-5c3f0ef85ffa");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("cd5b7045-5f50-4fff-9b87-a4036df2355a");
			column.CreatedInPackageId = new Guid("42153226-7fbf-4ddd-9a0b-5c3f0ef85ffa");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateProcessSchemaTypeEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateProcessSchemaTypeEventsProcessSchema() {
			var schema = new ProcessSchemaTypeEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProcessSchemaType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProcessSchemaType_ProcessLibraryEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProcessSchemaTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProcessSchemaTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cd5b7045-5f50-4fff-9b87-a4036df2355a"));
		}

		#endregion

	}

	#endregion

	#region Class: ProcessSchemaType

	/// <summary>
	/// Process schema type.
	/// </summary>
	public class ProcessSchemaType : Terrasoft.Configuration.BaseCodeLookup
	{

		#region Constructors: Public

		public ProcessSchemaType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProcessSchemaType";
		}

		public ProcessSchemaType(ProcessSchemaType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProcessSchemaType_ProcessLibraryEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ProcessSchemaTypeDeleted", e);
			Inserting += (s, e) => ThrowEvent("ProcessSchemaTypeInserting", e);
			Validating += (s, e) => ThrowEvent("ProcessSchemaTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProcessSchemaType(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProcessSchemaType_ProcessLibraryEventsProcess

	/// <exclude/>
	public partial class ProcessSchemaType_ProcessLibraryEventsProcess<TEntity> : Terrasoft.Configuration.BaseCodeLookup_BaseEventsProcess<TEntity> where TEntity : ProcessSchemaType
	{

		public ProcessSchemaType_ProcessLibraryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProcessSchemaType_ProcessLibraryEventsProcess";
			SchemaUId = new Guid("cd5b7045-5f50-4fff-9b87-a4036df2355a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("cd5b7045-5f50-4fff-9b87-a4036df2355a");
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

	#region Class: ProcessSchemaType_ProcessLibraryEventsProcess

	/// <exclude/>
	public class ProcessSchemaType_ProcessLibraryEventsProcess : ProcessSchemaType_ProcessLibraryEventsProcess<ProcessSchemaType>
	{

		public ProcessSchemaType_ProcessLibraryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProcessSchemaType_ProcessLibraryEventsProcess

	public partial class ProcessSchemaType_ProcessLibraryEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ProcessSchemaTypeEventsProcessSchema

	/// <exclude/>
	public class ProcessSchemaTypeEventsProcessSchema : Terrasoft.Configuration.BaseCodeLookupEventsProcessSchema
	{

		#region Constructors: Public

		public ProcessSchemaTypeEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ProcessSchemaTypeEventsProcessSchema(ProcessSchemaTypeEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ProcessSchemaType_ProcessLibraryEventsProcess";
			UId = new Guid("f293781e-54b2-49cd-81cc-8c5d72c130d5");
			CreatedInPackageId = new Guid("42153226-7fbf-4ddd-9a0b-5c3f0ef85ffa");
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
				CreatedInPackageId = new Guid("42153226-7fbf-4ddd-9a0b-5c3f0ef85ffa")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("42153226-7fbf-4ddd-9a0b-5c3f0ef85ffa")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("42153226-7fbf-4ddd-9a0b-5c3f0ef85ffa")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("42153226-7fbf-4ddd-9a0b-5c3f0ef85ffa")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("42153226-7fbf-4ddd-9a0b-5c3f0ef85ffa")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("42153226-7fbf-4ddd-9a0b-5c3f0ef85ffa")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("42153226-7fbf-4ddd-9a0b-5c3f0ef85ffa")
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
			return new ProcessSchemaTypeEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f293781e-54b2-49cd-81cc-8c5d72c130d5"));
		}

		#endregion

	}

	#endregion


	#region Class: ProcessSchemaTypeEventsProcess

	/// <exclude/>
	public class ProcessSchemaTypeEventsProcess : ProcessSchemaType_ProcessLibraryEventsProcess
	{

		public ProcessSchemaTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

