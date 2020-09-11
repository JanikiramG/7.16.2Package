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

	#region Class: SysMsgUserStateReasonSchema

	/// <exclude/>
	public class SysMsgUserStateReasonSchema : Terrasoft.Configuration.BaseCodeImageLookupSchema
	{

		#region Constructors: Public

		public SysMsgUserStateReasonSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysMsgUserStateReasonSchema(SysMsgUserStateReasonSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysMsgUserStateReasonSchema(SysMsgUserStateReasonSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1a286a70-31d9-40f9-9583-7e81ccf743a1");
			RealUId = new Guid("1a286a70-31d9-40f9-9583-7e81ccf743a1");
			Name = "SysMsgUserStateReason";
			ParentSchemaUId = new Guid("c21771d2-01fa-4646-96b0-e4b69e582b44");
			ExtendParent = false;
			CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("eadd9d6f-9fe1-46fc-87a8-9167c91ae635")) == null) {
				Columns.Add(CreateSysMsgUserStateColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("1a286a70-31d9-40f9-9583-7e81ccf743a1");
			column.CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("1a286a70-31d9-40f9-9583-7e81ccf743a1");
			column.CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("1a286a70-31d9-40f9-9583-7e81ccf743a1");
			column.CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("1a286a70-31d9-40f9-9583-7e81ccf743a1");
			column.CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("1a286a70-31d9-40f9-9583-7e81ccf743a1");
			column.CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("ShortText");
			column.ModifiedInSchemaUId = new Guid("1a286a70-31d9-40f9-9583-7e81ccf743a1");
			column.CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("1a286a70-31d9-40f9-9583-7e81ccf743a1");
			column.CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845");
			return column;
		}

		protected override EntitySchemaColumn CreateCodeColumn() {
			EntitySchemaColumn column = base.CreateCodeColumn();
			column.ModifiedInSchemaUId = new Guid("1a286a70-31d9-40f9-9583-7e81ccf743a1");
			column.CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("1a286a70-31d9-40f9-9583-7e81ccf743a1");
			column.CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845");
			return column;
		}

		protected override EntitySchemaColumn CreateImageColumn() {
			EntitySchemaColumn column = base.CreateImageColumn();
			column.ModifiedInSchemaUId = new Guid("1a286a70-31d9-40f9-9583-7e81ccf743a1");
			column.CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845");
			return column;
		}

		protected virtual EntitySchemaColumn CreateSysMsgUserStateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("eadd9d6f-9fe1-46fc-87a8-9167c91ae635"),
				Name = @"SysMsgUserState",
				ReferenceSchemaUId = new Guid("bb85a556-c9b9-41ee-acfa-eabc9bfb84ac"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("1a286a70-31d9-40f9-9583-7e81ccf743a1"),
				ModifiedInSchemaUId = new Guid("1a286a70-31d9-40f9-9583-7e81ccf743a1"),
				CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysMsgUserStateReasonEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysMsgUserStateReasonEventsProcessSchema() {
			var schema = new SysMsgUserStateReasonEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysMsgUserStateReason(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysMsgUserStateReason_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysMsgUserStateReasonSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysMsgUserStateReasonSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1a286a70-31d9-40f9-9583-7e81ccf743a1"));
		}

		#endregion

	}

	#endregion

	#region Class: SysMsgUserStateReason

	/// <summary>
	/// User status reason while messaging.
	/// </summary>
	public class SysMsgUserStateReason : Terrasoft.Configuration.BaseCodeImageLookup
	{

		#region Constructors: Public

		public SysMsgUserStateReason(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysMsgUserStateReason";
		}

		public SysMsgUserStateReason(SysMsgUserStateReason source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysMsgUserStateId {
			get {
				return GetTypedColumnValue<Guid>("SysMsgUserStateId");
			}
			set {
				SetColumnValue("SysMsgUserStateId", value);
				_sysMsgUserState = null;
			}
		}

		/// <exclude/>
		public string SysMsgUserStateName {
			get {
				return GetTypedColumnValue<string>("SysMsgUserStateName");
			}
			set {
				SetColumnValue("SysMsgUserStateName", value);
				if (_sysMsgUserState != null) {
					_sysMsgUserState.Name = value;
				}
			}
		}

		private SysMsgUserState _sysMsgUserState;
		/// <summary>
		/// User status.
		/// </summary>
		public SysMsgUserState SysMsgUserState {
			get {
				return _sysMsgUserState ??
					(_sysMsgUserState = LookupColumnEntities.GetEntity("SysMsgUserState") as SysMsgUserState);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysMsgUserStateReason_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysMsgUserStateReasonDeleted", e);
			Inserting += (s, e) => ThrowEvent("SysMsgUserStateReasonInserting", e);
			Validating += (s, e) => ThrowEvent("SysMsgUserStateReasonValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysMsgUserStateReason(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysMsgUserStateReason_BaseEventsProcess

	/// <exclude/>
	public partial class SysMsgUserStateReason_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseCodeImageLookup_BaseEventsProcess<TEntity> where TEntity : SysMsgUserStateReason
	{

		public SysMsgUserStateReason_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysMsgUserStateReason_BaseEventsProcess";
			SchemaUId = new Guid("1a286a70-31d9-40f9-9583-7e81ccf743a1");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1a286a70-31d9-40f9-9583-7e81ccf743a1");
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

	#region Class: SysMsgUserStateReason_BaseEventsProcess

	/// <exclude/>
	public class SysMsgUserStateReason_BaseEventsProcess : SysMsgUserStateReason_BaseEventsProcess<SysMsgUserStateReason>
	{

		public SysMsgUserStateReason_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysMsgUserStateReason_BaseEventsProcess

	public partial class SysMsgUserStateReason_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysMsgUserStateReasonEventsProcessSchema

	/// <exclude/>
	public class SysMsgUserStateReasonEventsProcessSchema : Terrasoft.Configuration.BaseCodeImageLookupEventsProcessSchema
	{

		#region Constructors: Public

		public SysMsgUserStateReasonEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysMsgUserStateReasonEventsProcessSchema(SysMsgUserStateReasonEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysMsgUserStateReason_BaseEventsProcess";
			UId = new Guid("642ddc4c-2556-4c1b-886c-a023f238cddd");
			CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845");
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
				CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("7689c850-1a27-48e1-bfba-7dca05204845")
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
			return new SysMsgUserStateReasonEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("642ddc4c-2556-4c1b-886c-a023f238cddd"));
		}

		#endregion

	}

	#endregion


	#region Class: SysMsgUserStateReasonEventsProcess

	/// <exclude/>
	public class SysMsgUserStateReasonEventsProcess : SysMsgUserStateReason_BaseEventsProcess
	{

		public SysMsgUserStateReasonEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

