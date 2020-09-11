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

	#region Class: SysModuleEditLczOldSchema

	/// <exclude/>
	public class SysModuleEditLczOldSchema : Terrasoft.Configuration.BaseLczEntitySchema
	{

		#region Constructors: Public

		public SysModuleEditLczOldSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysModuleEditLczOldSchema(SysModuleEditLczOldSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysModuleEditLczOldSchema(SysModuleEditLczOldSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			RealUId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			Name = "SysModuleEditLczOld";
			ParentSchemaUId = new Guid("b7cd8e8f-a017-4f73-b1fe-efb9e938e1d2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			column.CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			column.CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			column.CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			column.CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			column.CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			column.CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
			return column;
		}

		protected override EntitySchemaColumn CreateRecordColumn() {
			EntitySchemaColumn column = base.CreateRecordColumn();
			column.ReferenceSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001");
			column.ColumnValueName = @"RecordId";
			column.DisplayColumnValueName = @"RecordPageCaption";
			column.ModifiedInSchemaUId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			column.CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
			return column;
		}

		protected override EntitySchemaColumn CreateColumnUIdColumn() {
			EntitySchemaColumn column = base.CreateColumnUIdColumn();
			column.ModifiedInSchemaUId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			column.CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
			return column;
		}

		protected override EntitySchemaColumn CreateSysCultureColumn() {
			EntitySchemaColumn column = base.CreateSysCultureColumn();
			column.ModifiedInSchemaUId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			column.CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
			return column;
		}

		protected override EntitySchemaColumn CreateValueColumn() {
			EntitySchemaColumn column = base.CreateValueColumn();
			column.ModifiedInSchemaUId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			column.CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysModuleEditLczOldEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysModuleEditLczOldEventsProcessSchema() {
			var schema = new SysModuleEditLczOldEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysModuleEditLczOld(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysModuleEditLczOld_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysModuleEditLczOldSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysModuleEditLczOldSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f"));
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleEditLczOld

	/// <summary>
	/// SysModuleEdit localization table.
	/// </summary>
	public class SysModuleEditLczOld : Terrasoft.Configuration.BaseLczEntity
	{

		#region Constructors: Public

		public SysModuleEditLczOld(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysModuleEditLczOld";
		}

		public SysModuleEditLczOld(SysModuleEditLczOld source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysModuleEditLczOld_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysModuleEditLczOldDeleted", e);
			Inserting += (s, e) => ThrowEvent("SysModuleEditLczOldInserting", e);
			Validating += (s, e) => ThrowEvent("SysModuleEditLczOldValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleEditLczOld(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleEditLczOld_BaseEventsProcess

	/// <exclude/>
	public partial class SysModuleEditLczOld_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLczEntity_BaseEventsProcess<TEntity> where TEntity : SysModuleEditLczOld
	{

		public SysModuleEditLczOld_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleEditLczOld_BaseEventsProcess";
			SchemaUId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
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

	#region Class: SysModuleEditLczOld_BaseEventsProcess

	/// <exclude/>
	public class SysModuleEditLczOld_BaseEventsProcess : SysModuleEditLczOld_BaseEventsProcess<SysModuleEditLczOld>
	{

		public SysModuleEditLczOld_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleEditLczOld_BaseEventsProcess

	public partial class SysModuleEditLczOld_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysModuleEditLczOldEventsProcessSchema

	/// <exclude/>
	public class SysModuleEditLczOldEventsProcessSchema : Terrasoft.Configuration.BaseLczEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysModuleEditLczOldEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysModuleEditLczOldEventsProcessSchema(SysModuleEditLczOldEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysModuleEditLczOld_BaseEventsProcess";
			UId = new Guid("fc0e6b61-9e36-4da3-9197-162376cb7608");
			CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
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
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e")
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
			return new SysModuleEditLczOldEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fc0e6b61-9e36-4da3-9197-162376cb7608"));
		}

		#endregion

	}

	#endregion


	#region Class: SysModuleEditLczOldEventsProcess

	/// <exclude/>
	public class SysModuleEditLczOldEventsProcess : SysModuleEditLczOld_BaseEventsProcess
	{

		public SysModuleEditLczOldEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

