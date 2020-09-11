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

	#region Class: SysOperationResultSchema

	/// <exclude/>
	public class SysOperationResultSchema : Terrasoft.Configuration.BaseCodeImageLookupSchema
	{

		#region Constructors: Public

		public SysOperationResultSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysOperationResultSchema(SysOperationResultSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysOperationResultSchema(SysOperationResultSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIX_SysOperationResultCodeIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = true
			};
			index.UId = new Guid("218135df-d179-4f44-85ea-7ccb70d11c27");
			index.Name = "IX_SysOperationResultCode";
			index.CreatedInSchemaUId = new Guid("d13590dc-314e-4edc-a2c2-7db0e82e672e");
			index.ModifiedInSchemaUId = new Guid("d13590dc-314e-4edc-a2c2-7db0e82e672e");
			index.CreatedInPackageId = new Guid("097f7d5f-7a55-4df4-9734-034f9246a1c2");
			EntitySchemaIndexColumn codeIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("1631418b-80b6-42d8-84ef-5fe1173fbd75"),
				ColumnUId = new Guid("13aad544-ec30-4e76-a373-f0cff3202e24"),
				CreatedInSchemaUId = new Guid("d13590dc-314e-4edc-a2c2-7db0e82e672e"),
				ModifiedInSchemaUId = new Guid("d13590dc-314e-4edc-a2c2-7db0e82e672e"),
				CreatedInPackageId = new Guid("097f7d5f-7a55-4df4-9734-034f9246a1c2"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(codeIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d13590dc-314e-4edc-a2c2-7db0e82e672e");
			RealUId = new Guid("d13590dc-314e-4edc-a2c2-7db0e82e672e");
			Name = "SysOperationResult";
			ParentSchemaUId = new Guid("c21771d2-01fa-4646-96b0-e4b69e582b44");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b40b5a4a-23e9-4656-9186-2b322b13e540");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryImageColumn() {
			base.InitializePrimaryImageColumn();
			PrimaryImageColumn = CreateImageColumn();
			if (Columns.FindByUId(PrimaryImageColumn.UId) == null) {
				Columns.Add(PrimaryImageColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("d13590dc-314e-4edc-a2c2-7db0e82e672e");
			column.CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("d13590dc-314e-4edc-a2c2-7db0e82e672e");
			column.CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("d13590dc-314e-4edc-a2c2-7db0e82e672e");
			column.CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("d13590dc-314e-4edc-a2c2-7db0e82e672e");
			column.CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("d13590dc-314e-4edc-a2c2-7db0e82e672e");
			column.CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("d13590dc-314e-4edc-a2c2-7db0e82e672e");
			column.CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("d13590dc-314e-4edc-a2c2-7db0e82e672e");
			column.CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f");
			return column;
		}

		protected override EntitySchemaColumn CreateCodeColumn() {
			EntitySchemaColumn column = base.CreateCodeColumn();
			column.ModifiedInSchemaUId = new Guid("d13590dc-314e-4edc-a2c2-7db0e82e672e");
			column.CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("d13590dc-314e-4edc-a2c2-7db0e82e672e");
			column.CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f");
			return column;
		}

		protected override EntitySchemaColumn CreateImageColumn() {
			EntitySchemaColumn column = base.CreateImageColumn();
			column.ModifiedInSchemaUId = new Guid("d13590dc-314e-4edc-a2c2-7db0e82e672e");
			column.CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIX_SysOperationResultCodeIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysOperationResultEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysOperationResultEventsProcessSchema() {
			var schema = new SysOperationResultEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysOperationResult(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysOperationResult_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysOperationResultSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysOperationResultSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d13590dc-314e-4edc-a2c2-7db0e82e672e"));
		}

		#endregion

	}

	#endregion

	#region Class: SysOperationResult

	/// <summary>
	/// Event results.
	/// </summary>
	public class SysOperationResult : Terrasoft.Configuration.BaseCodeImageLookup
	{

		#region Constructors: Public

		public SysOperationResult(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysOperationResult";
		}

		public SysOperationResult(SysOperationResult source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysOperationResult_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysOperationResultDeleted", e);
			Inserting += (s, e) => ThrowEvent("SysOperationResultInserting", e);
			Validating += (s, e) => ThrowEvent("SysOperationResultValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysOperationResult(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysOperationResult_BaseEventsProcess

	/// <exclude/>
	public partial class SysOperationResult_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseCodeImageLookup_BaseEventsProcess<TEntity> where TEntity : SysOperationResult
	{

		public SysOperationResult_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysOperationResult_BaseEventsProcess";
			SchemaUId = new Guid("d13590dc-314e-4edc-a2c2-7db0e82e672e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d13590dc-314e-4edc-a2c2-7db0e82e672e");
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

	#region Class: SysOperationResult_BaseEventsProcess

	/// <exclude/>
	public class SysOperationResult_BaseEventsProcess : SysOperationResult_BaseEventsProcess<SysOperationResult>
	{

		public SysOperationResult_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysOperationResult_BaseEventsProcess

	public partial class SysOperationResult_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysOperationResultEventsProcessSchema

	/// <exclude/>
	public class SysOperationResultEventsProcessSchema : Terrasoft.Configuration.BaseCodeImageLookupEventsProcessSchema
	{

		#region Constructors: Public

		public SysOperationResultEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysOperationResultEventsProcessSchema(SysOperationResultEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysOperationResult_BaseEventsProcess";
			UId = new Guid("ae62e36e-23aa-47bc-ac28-59fe5840f1ec");
			CreatedInPackageId = new Guid("b40b5a4a-23e9-4656-9186-2b322b13e540");
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
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f")
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
			return new SysOperationResultEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ae62e36e-23aa-47bc-ac28-59fe5840f1ec"));
		}

		#endregion

	}

	#endregion


	#region Class: SysOperationResultEventsProcess

	/// <exclude/>
	public class SysOperationResultEventsProcess : SysOperationResult_BaseEventsProcess
	{

		public SysOperationResultEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

