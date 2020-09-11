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

	#region Class: MainParamLczOldSchema

	/// <exclude/>
	public class MainParamLczOldSchema : Terrasoft.Configuration.BaseLczEntitySchema
	{

		#region Constructors: Public

		public MainParamLczOldSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MainParamLczOldSchema(MainParamLczOldSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MainParamLczOldSchema(MainParamLczOldSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("24164caf-0471-406d-b77c-f47b1b4abc1b");
			RealUId = new Guid("24164caf-0471-406d-b77c-f47b1b4abc1b");
			Name = "MainParamLczOld";
			ParentSchemaUId = new Guid("b7cd8e8f-a017-4f73-b1fe-efb9e938e1d2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("5af8fc1f-99e6-4265-b65c-5e9401c4c7dd");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("24164caf-0471-406d-b77c-f47b1b4abc1b");
			column.CreatedInPackageId = new Guid("5af8fc1f-99e6-4265-b65c-5e9401c4c7dd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("24164caf-0471-406d-b77c-f47b1b4abc1b");
			column.CreatedInPackageId = new Guid("5af8fc1f-99e6-4265-b65c-5e9401c4c7dd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("24164caf-0471-406d-b77c-f47b1b4abc1b");
			column.CreatedInPackageId = new Guid("5af8fc1f-99e6-4265-b65c-5e9401c4c7dd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("24164caf-0471-406d-b77c-f47b1b4abc1b");
			column.CreatedInPackageId = new Guid("5af8fc1f-99e6-4265-b65c-5e9401c4c7dd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("24164caf-0471-406d-b77c-f47b1b4abc1b");
			column.CreatedInPackageId = new Guid("5af8fc1f-99e6-4265-b65c-5e9401c4c7dd");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("24164caf-0471-406d-b77c-f47b1b4abc1b");
			column.CreatedInPackageId = new Guid("5af8fc1f-99e6-4265-b65c-5e9401c4c7dd");
			return column;
		}

		protected override EntitySchemaColumn CreateRecordColumn() {
			EntitySchemaColumn column = base.CreateRecordColumn();
			column.ReferenceSchemaUId = new Guid("28f7da1a-3f4d-4f2d-9d25-75c965cded5d");
			column.ColumnValueName = @"RecordId";
			column.DisplayColumnValueName = @"RecordName";
			column.ModifiedInSchemaUId = new Guid("24164caf-0471-406d-b77c-f47b1b4abc1b");
			column.CreatedInPackageId = new Guid("5af8fc1f-99e6-4265-b65c-5e9401c4c7dd");
			return column;
		}

		protected override EntitySchemaColumn CreateColumnUIdColumn() {
			EntitySchemaColumn column = base.CreateColumnUIdColumn();
			column.ModifiedInSchemaUId = new Guid("24164caf-0471-406d-b77c-f47b1b4abc1b");
			column.CreatedInPackageId = new Guid("5af8fc1f-99e6-4265-b65c-5e9401c4c7dd");
			return column;
		}

		protected override EntitySchemaColumn CreateSysCultureColumn() {
			EntitySchemaColumn column = base.CreateSysCultureColumn();
			column.ModifiedInSchemaUId = new Guid("24164caf-0471-406d-b77c-f47b1b4abc1b");
			column.CreatedInPackageId = new Guid("5af8fc1f-99e6-4265-b65c-5e9401c4c7dd");
			return column;
		}

		protected override EntitySchemaColumn CreateValueColumn() {
			EntitySchemaColumn column = base.CreateValueColumn();
			column.ModifiedInSchemaUId = new Guid("24164caf-0471-406d-b77c-f47b1b4abc1b");
			column.CreatedInPackageId = new Guid("5af8fc1f-99e6-4265-b65c-5e9401c4c7dd");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMainParamLczOldEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateMainParamLczOldEventsProcessSchema() {
			var schema = new MainParamLczOldEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new MainParamLczOld(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new MainParamLczOld_NUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MainParamLczOldSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MainParamLczOldSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("24164caf-0471-406d-b77c-f47b1b4abc1b"));
		}

		#endregion

	}

	#endregion

	#region Class: MainParamLczOld

	/// <summary>
	/// MainParam localization table.
	/// </summary>
	public class MainParamLczOld : Terrasoft.Configuration.BaseLczEntity
	{

		#region Constructors: Public

		public MainParamLczOld(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MainParamLczOld";
		}

		public MainParamLczOld(MainParamLczOld source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MainParamLczOld_NUIEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("MainParamLczOldDeleted", e);
			Inserting += (s, e) => ThrowEvent("MainParamLczOldInserting", e);
			Validating += (s, e) => ThrowEvent("MainParamLczOldValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MainParamLczOld(this);
		}

		#endregion

	}

	#endregion

	#region Class: MainParamLczOld_NUIEventsProcess

	/// <exclude/>
	public partial class MainParamLczOld_NUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseLczEntity_BaseEventsProcess<TEntity> where TEntity : MainParamLczOld
	{

		public MainParamLczOld_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MainParamLczOld_NUIEventsProcess";
			SchemaUId = new Guid("24164caf-0471-406d-b77c-f47b1b4abc1b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("24164caf-0471-406d-b77c-f47b1b4abc1b");
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

	#region Class: MainParamLczOld_NUIEventsProcess

	/// <exclude/>
	public class MainParamLczOld_NUIEventsProcess : MainParamLczOld_NUIEventsProcess<MainParamLczOld>
	{

		public MainParamLczOld_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MainParamLczOld_NUIEventsProcess

	public partial class MainParamLczOld_NUIEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: MainParamLczOldEventsProcessSchema

	/// <exclude/>
	public class MainParamLczOldEventsProcessSchema : Terrasoft.Configuration.BaseLczEntityEventsProcessSchema
	{

		#region Constructors: Public

		public MainParamLczOldEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MainParamLczOldEventsProcessSchema(MainParamLczOldEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "MainParamLczOld_NUIEventsProcess";
			UId = new Guid("4b832c13-eb52-44c9-9c6f-10766ab4e80a");
			CreatedInPackageId = new Guid("5af8fc1f-99e6-4265-b65c-5e9401c4c7dd");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("6e59757a-fca9-4970-9d87-b2373359b50b");
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
				CreatedInPackageId = new Guid("5af8fc1f-99e6-4265-b65c-5e9401c4c7dd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("5af8fc1f-99e6-4265-b65c-5e9401c4c7dd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("5af8fc1f-99e6-4265-b65c-5e9401c4c7dd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("5af8fc1f-99e6-4265-b65c-5e9401c4c7dd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("5af8fc1f-99e6-4265-b65c-5e9401c4c7dd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("5af8fc1f-99e6-4265-b65c-5e9401c4c7dd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("5af8fc1f-99e6-4265-b65c-5e9401c4c7dd")
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
			return new MainParamLczOldEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4b832c13-eb52-44c9-9c6f-10766ab4e80a"));
		}

		#endregion

	}

	#endregion


	#region Class: MainParamLczOldEventsProcess

	/// <exclude/>
	public class MainParamLczOldEventsProcess : MainParamLczOld_NUIEventsProcess
	{

		public MainParamLczOldEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

