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

	#region Class: SysMsgLibSchema

	/// <exclude/>
	public class SysMsgLibSchema : Terrasoft.Configuration.BaseCodeLookupSchema
	{

		#region Constructors: Public

		public SysMsgLibSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysMsgLibSchema(SysMsgLibSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysMsgLibSchema(SysMsgLibSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("89b9f170-8aed-4f41-8659-c787b50df837");
			RealUId = new Guid("89b9f170-8aed-4f41-8659-c787b50df837");
			Name = "SysMsgLib";
			ParentSchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("4ad66197-8e63-4298-ac37-981399166904")) == null) {
				Columns.Add(CreateFullClassNameColumn());
			}
			if (Columns.FindByUId(new Guid("6eea683c-19c3-4347-b1db-1d9de5c232ab")) == null) {
				Columns.Add(CreateSetupPageSchemaNameColumn());
			}
			if (Columns.FindByUId(new Guid("e1f7baaf-124a-478c-b3d9-d31202568c5c")) == null) {
				Columns.Add(CreateLicOperationsColumn());
			}
			if (Columns.FindByUId(new Guid("88da31ac-dcbb-49e8-bdfb-30685ca1cae0")) == null) {
				Columns.Add(CreateCtiProviderNameColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("89b9f170-8aed-4f41-8659-c787b50df837");
			column.CreatedInPackageId = new Guid("fcbbf5a7-101d-4475-ad73-614f06386f57");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("89b9f170-8aed-4f41-8659-c787b50df837");
			column.CreatedInPackageId = new Guid("fcbbf5a7-101d-4475-ad73-614f06386f57");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("89b9f170-8aed-4f41-8659-c787b50df837");
			column.CreatedInPackageId = new Guid("fcbbf5a7-101d-4475-ad73-614f06386f57");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("89b9f170-8aed-4f41-8659-c787b50df837");
			column.CreatedInPackageId = new Guid("fcbbf5a7-101d-4475-ad73-614f06386f57");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("89b9f170-8aed-4f41-8659-c787b50df837");
			column.CreatedInPackageId = new Guid("fcbbf5a7-101d-4475-ad73-614f06386f57");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("89b9f170-8aed-4f41-8659-c787b50df837");
			column.CreatedInPackageId = new Guid("fcbbf5a7-101d-4475-ad73-614f06386f57");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("89b9f170-8aed-4f41-8659-c787b50df837");
			column.CreatedInPackageId = new Guid("fcbbf5a7-101d-4475-ad73-614f06386f57");
			return column;
		}

		protected override EntitySchemaColumn CreateCodeColumn() {
			EntitySchemaColumn column = base.CreateCodeColumn();
			column.ModifiedInSchemaUId = new Guid("89b9f170-8aed-4f41-8659-c787b50df837");
			column.CreatedInPackageId = new Guid("fcbbf5a7-101d-4475-ad73-614f06386f57");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("89b9f170-8aed-4f41-8659-c787b50df837");
			column.CreatedInPackageId = new Guid("fcbbf5a7-101d-4475-ad73-614f06386f57");
			return column;
		}

		protected virtual EntitySchemaColumn CreateFullClassNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("4ad66197-8e63-4298-ac37-981399166904"),
				Name = @"FullClassName",
				CreatedInSchemaUId = new Guid("89b9f170-8aed-4f41-8659-c787b50df837"),
				ModifiedInSchemaUId = new Guid("89b9f170-8aed-4f41-8659-c787b50df837"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSetupPageSchemaNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("6eea683c-19c3-4347-b1db-1d9de5c232ab"),
				Name = @"SetupPageSchemaName",
				CreatedInSchemaUId = new Guid("89b9f170-8aed-4f41-8659-c787b50df837"),
				ModifiedInSchemaUId = new Guid("89b9f170-8aed-4f41-8659-c787b50df837"),
				CreatedInPackageId = new Guid("fcbbf5a7-101d-4475-ad73-614f06386f57")
			};
		}

		protected virtual EntitySchemaColumn CreateLicOperationsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("e1f7baaf-124a-478c-b3d9-d31202568c5c"),
				Name = @"LicOperations",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("89b9f170-8aed-4f41-8659-c787b50df837"),
				ModifiedInSchemaUId = new Guid("89b9f170-8aed-4f41-8659-c787b50df837"),
				CreatedInPackageId = new Guid("fcbbf5a7-101d-4475-ad73-614f06386f57")
			};
		}

		protected virtual EntitySchemaColumn CreateCtiProviderNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("88da31ac-dcbb-49e8-bdfb-30685ca1cae0"),
				Name = @"CtiProviderName",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("89b9f170-8aed-4f41-8659-c787b50df837"),
				ModifiedInSchemaUId = new Guid("89b9f170-8aed-4f41-8659-c787b50df837"),
				CreatedInPackageId = new Guid("fcbbf5a7-101d-4475-ad73-614f06386f57"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"MsgServiceCtiProvider"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysMsgLibEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysMsgLibEventsProcessSchema() {
			var schema = new SysMsgLibEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysMsgLib(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysMsgLib_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysMsgLibSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysMsgLibSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("89b9f170-8aed-4f41-8659-c787b50df837"));
		}

		#endregion

	}

	#endregion

	#region Class: SysMsgLib

	/// <summary>
	/// Message exchange library.
	/// </summary>
	public class SysMsgLib : Terrasoft.Configuration.BaseCodeLookup
	{

		#region Constructors: Public

		public SysMsgLib(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysMsgLib";
		}

		public SysMsgLib(SysMsgLib source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Class and build.
		/// </summary>
		public string FullClassName {
			get {
				return GetTypedColumnValue<string>("FullClassName");
			}
			set {
				SetColumnValue("FullClassName", value);
			}
		}

		/// <summary>
		/// Setup page schema name.
		/// </summary>
		public string SetupPageSchemaName {
			get {
				return GetTypedColumnValue<string>("SetupPageSchemaName");
			}
			set {
				SetColumnValue("SetupPageSchemaName", value);
			}
		}

		/// <summary>
		/// Licensed operations.
		/// </summary>
		public string LicOperations {
			get {
				return GetTypedColumnValue<string>("LicOperations");
			}
			set {
				SetColumnValue("LicOperations", value);
			}
		}

		/// <summary>
		/// CTI provider class name.
		/// </summary>
		public string CtiProviderName {
			get {
				return GetTypedColumnValue<string>("CtiProviderName");
			}
			set {
				SetColumnValue("CtiProviderName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysMsgLib_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysMsgLibDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysMsgLibDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysMsgLibInserted", e);
			Inserting += (s, e) => ThrowEvent("SysMsgLibInserting", e);
			Saved += (s, e) => ThrowEvent("SysMsgLibSaved", e);
			Saving += (s, e) => ThrowEvent("SysMsgLibSaving", e);
			Validating += (s, e) => ThrowEvent("SysMsgLibValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysMsgLib(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysMsgLib_BaseEventsProcess

	/// <exclude/>
	public partial class SysMsgLib_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseCodeLookup_BaseEventsProcess<TEntity> where TEntity : SysMsgLib
	{

		public SysMsgLib_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysMsgLib_BaseEventsProcess";
			SchemaUId = new Guid("89b9f170-8aed-4f41-8659-c787b50df837");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("89b9f170-8aed-4f41-8659-c787b50df837");
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

	#region Class: SysMsgLib_BaseEventsProcess

	/// <exclude/>
	public class SysMsgLib_BaseEventsProcess : SysMsgLib_BaseEventsProcess<SysMsgLib>
	{

		public SysMsgLib_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysMsgLib_BaseEventsProcess

	public partial class SysMsgLib_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysMsgLibEventsProcessSchema

	/// <exclude/>
	public class SysMsgLibEventsProcessSchema : Terrasoft.Configuration.BaseCodeLookupEventsProcessSchema
	{

		#region Constructors: Public

		public SysMsgLibEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysMsgLibEventsProcessSchema(SysMsgLibEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysMsgLib_BaseEventsProcess";
			UId = new Guid("8486ddb9-4846-4304-abd3-234e62293c3d");
			CreatedInPackageId = new Guid("f25ac8e1-73cc-488f-8dc8-76a50a94117e");
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
				CreatedInPackageId = new Guid("fcbbf5a7-101d-4475-ad73-614f06386f57")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("fcbbf5a7-101d-4475-ad73-614f06386f57")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("fcbbf5a7-101d-4475-ad73-614f06386f57")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("fcbbf5a7-101d-4475-ad73-614f06386f57")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("fcbbf5a7-101d-4475-ad73-614f06386f57")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("fcbbf5a7-101d-4475-ad73-614f06386f57")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("fcbbf5a7-101d-4475-ad73-614f06386f57")
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
			return new SysMsgLibEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8486ddb9-4846-4304-abd3-234e62293c3d"));
		}

		#endregion

	}

	#endregion


	#region Class: SysMsgLibEventsProcess

	/// <exclude/>
	public class SysMsgLibEventsProcess : SysMsgLib_BaseEventsProcess
	{

		public SysMsgLibEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

