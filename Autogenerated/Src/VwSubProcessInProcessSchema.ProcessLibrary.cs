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

	#region Class: VwSubProcessInProcessSchema

	/// <exclude/>
	public class VwSubProcessInProcessSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VwSubProcessInProcessSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSubProcessInProcessSchema(VwSubProcessInProcessSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSubProcessInProcessSchema(VwSubProcessInProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a10f252b-6909-4b86-ae7f-5eae28c78e12");
			RealUId = new Guid("a10f252b-6909-4b86-ae7f-5eae28c78e12");
			Name = "VwSubProcessInProcess";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("462ab5a4-d59d-41f7-9e05-ca80a935cf00")) == null) {
				Columns.Add(CreateHostProcessColumn());
			}
			if (Columns.FindByUId(new Guid("cc877183-d49f-4b8b-82a4-4eeab7ed525a")) == null) {
				Columns.Add(CreateParentProcessColumn());
			}
			if (Columns.FindByUId(new Guid("a3aced01-18cf-43bb-ab73-dca82a7cfa3e")) == null) {
				Columns.Add(CreateSubProcessColumn());
			}
			if (Columns.FindByUId(new Guid("92ca3bc9-2ed6-4388-b826-697e1d1c7fa0")) == null) {
				Columns.Add(CreateParentSubProcessColumn());
			}
			if (Columns.FindByUId(new Guid("1a783861-0266-486a-b584-e68d40e9a48b")) == null) {
				Columns.Add(CreateActiveSubProcessColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateHostProcessColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("462ab5a4-d59d-41f7-9e05-ca80a935cf00"),
				Name = @"HostProcess",
				ReferenceSchemaUId = new Guid("e6e68ac1-495d-4727-a7a7-9b531ab9f849"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a10f252b-6909-4b86-ae7f-5eae28c78e12"),
				ModifiedInSchemaUId = new Guid("a10f252b-6909-4b86-ae7f-5eae28c78e12"),
				CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd")
			};
		}

		protected virtual EntitySchemaColumn CreateParentProcessColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("cc877183-d49f-4b8b-82a4-4eeab7ed525a"),
				Name = @"ParentProcess",
				ReferenceSchemaUId = new Guid("e6e68ac1-495d-4727-a7a7-9b531ab9f849"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a10f252b-6909-4b86-ae7f-5eae28c78e12"),
				ModifiedInSchemaUId = new Guid("a10f252b-6909-4b86-ae7f-5eae28c78e12"),
				CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd")
			};
		}

		protected virtual EntitySchemaColumn CreateSubProcessColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a3aced01-18cf-43bb-ab73-dca82a7cfa3e"),
				Name = @"SubProcess",
				ReferenceSchemaUId = new Guid("e6e68ac1-495d-4727-a7a7-9b531ab9f849"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a10f252b-6909-4b86-ae7f-5eae28c78e12"),
				ModifiedInSchemaUId = new Guid("a10f252b-6909-4b86-ae7f-5eae28c78e12"),
				CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd")
			};
		}

		protected virtual EntitySchemaColumn CreateParentSubProcessColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("92ca3bc9-2ed6-4388-b826-697e1d1c7fa0"),
				Name = @"ParentSubProcess",
				ReferenceSchemaUId = new Guid("e6e68ac1-495d-4727-a7a7-9b531ab9f849"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a10f252b-6909-4b86-ae7f-5eae28c78e12"),
				ModifiedInSchemaUId = new Guid("a10f252b-6909-4b86-ae7f-5eae28c78e12"),
				CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd")
			};
		}

		protected virtual EntitySchemaColumn CreateActiveSubProcessColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1a783861-0266-486a-b584-e68d40e9a48b"),
				Name = @"ActiveSubProcess",
				ReferenceSchemaUId = new Guid("e6e68ac1-495d-4727-a7a7-9b531ab9f849"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a10f252b-6909-4b86-ae7f-5eae28c78e12"),
				ModifiedInSchemaUId = new Guid("a10f252b-6909-4b86-ae7f-5eae28c78e12"),
				CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwSubProcessInProcessEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwSubProcessInProcessEventsProcessSchema() {
			var schema = new VwSubProcessInProcessEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSubProcessInProcess(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSubProcessInProcess_ProcessLibraryEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSubProcessInProcessSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSubProcessInProcessSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a10f252b-6909-4b86-ae7f-5eae28c78e12"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSubProcessInProcess

	/// <summary>
	/// VwSubProcessInProcess.
	/// </summary>
	public class VwSubProcessInProcess : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VwSubProcessInProcess(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSubProcessInProcess";
		}

		public VwSubProcessInProcess(VwSubProcessInProcess source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid HostProcessId {
			get {
				return GetTypedColumnValue<Guid>("HostProcessId");
			}
			set {
				SetColumnValue("HostProcessId", value);
				_hostProcess = null;
			}
		}

		/// <exclude/>
		public string HostProcessCaption {
			get {
				return GetTypedColumnValue<string>("HostProcessCaption");
			}
			set {
				SetColumnValue("HostProcessCaption", value);
				if (_hostProcess != null) {
					_hostProcess.Caption = value;
				}
			}
		}

		private VwProcessLib _hostProcess;
		/// <summary>
		/// Process.
		/// </summary>
		public VwProcessLib HostProcess {
			get {
				return _hostProcess ??
					(_hostProcess = LookupColumnEntities.GetEntity("HostProcess") as VwProcessLib);
			}
		}

		/// <exclude/>
		public Guid ParentProcessId {
			get {
				return GetTypedColumnValue<Guid>("ParentProcessId");
			}
			set {
				SetColumnValue("ParentProcessId", value);
				_parentProcess = null;
			}
		}

		/// <exclude/>
		public string ParentProcessCaption {
			get {
				return GetTypedColumnValue<string>("ParentProcessCaption");
			}
			set {
				SetColumnValue("ParentProcessCaption", value);
				if (_parentProcess != null) {
					_parentProcess.Caption = value;
				}
			}
		}

		private VwProcessLib _parentProcess;
		/// <summary>
		/// Parent version process.
		/// </summary>
		public VwProcessLib ParentProcess {
			get {
				return _parentProcess ??
					(_parentProcess = LookupColumnEntities.GetEntity("ParentProcess") as VwProcessLib);
			}
		}

		/// <exclude/>
		public Guid SubProcessId {
			get {
				return GetTypedColumnValue<Guid>("SubProcessId");
			}
			set {
				SetColumnValue("SubProcessId", value);
				_subProcess = null;
			}
		}

		/// <exclude/>
		public string SubProcessCaption {
			get {
				return GetTypedColumnValue<string>("SubProcessCaption");
			}
			set {
				SetColumnValue("SubProcessCaption", value);
				if (_subProcess != null) {
					_subProcess.Caption = value;
				}
			}
		}

		private VwProcessLib _subProcess;
		/// <summary>
		/// Sub-process.
		/// </summary>
		public VwProcessLib SubProcess {
			get {
				return _subProcess ??
					(_subProcess = LookupColumnEntities.GetEntity("SubProcess") as VwProcessLib);
			}
		}

		/// <exclude/>
		public Guid ParentSubProcessId {
			get {
				return GetTypedColumnValue<Guid>("ParentSubProcessId");
			}
			set {
				SetColumnValue("ParentSubProcessId", value);
				_parentSubProcess = null;
			}
		}

		/// <exclude/>
		public string ParentSubProcessCaption {
			get {
				return GetTypedColumnValue<string>("ParentSubProcessCaption");
			}
			set {
				SetColumnValue("ParentSubProcessCaption", value);
				if (_parentSubProcess != null) {
					_parentSubProcess.Caption = value;
				}
			}
		}

		private VwProcessLib _parentSubProcess;
		/// <summary>
		/// Parent version sub-process.
		/// </summary>
		public VwProcessLib ParentSubProcess {
			get {
				return _parentSubProcess ??
					(_parentSubProcess = LookupColumnEntities.GetEntity("ParentSubProcess") as VwProcessLib);
			}
		}

		/// <exclude/>
		public Guid ActiveSubProcessId {
			get {
				return GetTypedColumnValue<Guid>("ActiveSubProcessId");
			}
			set {
				SetColumnValue("ActiveSubProcessId", value);
				_activeSubProcess = null;
			}
		}

		/// <exclude/>
		public string ActiveSubProcessCaption {
			get {
				return GetTypedColumnValue<string>("ActiveSubProcessCaption");
			}
			set {
				SetColumnValue("ActiveSubProcessCaption", value);
				if (_activeSubProcess != null) {
					_activeSubProcess.Caption = value;
				}
			}
		}

		private VwProcessLib _activeSubProcess;
		/// <summary>
		/// Active version of sub-process.
		/// </summary>
		public VwProcessLib ActiveSubProcess {
			get {
				return _activeSubProcess ??
					(_activeSubProcess = LookupColumnEntities.GetEntity("ActiveSubProcess") as VwProcessLib);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSubProcessInProcess_ProcessLibraryEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwSubProcessInProcessDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSubProcessInProcess(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSubProcessInProcess_ProcessLibraryEventsProcess

	/// <exclude/>
	public partial class VwSubProcessInProcess_ProcessLibraryEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : VwSubProcessInProcess
	{

		public VwSubProcessInProcess_ProcessLibraryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSubProcessInProcess_ProcessLibraryEventsProcess";
			SchemaUId = new Guid("a10f252b-6909-4b86-ae7f-5eae28c78e12");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a10f252b-6909-4b86-ae7f-5eae28c78e12");
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

	#region Class: VwSubProcessInProcess_ProcessLibraryEventsProcess

	/// <exclude/>
	public class VwSubProcessInProcess_ProcessLibraryEventsProcess : VwSubProcessInProcess_ProcessLibraryEventsProcess<VwSubProcessInProcess>
	{

		public VwSubProcessInProcess_ProcessLibraryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSubProcessInProcess_ProcessLibraryEventsProcess

	public partial class VwSubProcessInProcess_ProcessLibraryEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwSubProcessInProcessEventsProcessSchema

	/// <exclude/>
	public class VwSubProcessInProcessEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public VwSubProcessInProcessEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwSubProcessInProcessEventsProcessSchema(VwSubProcessInProcessEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwSubProcessInProcess_ProcessLibraryEventsProcess";
			UId = new Guid("87863e64-932f-405f-88ea-e49ae2953af0");
			CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
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
			return new VwSubProcessInProcessEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("87863e64-932f-405f-88ea-e49ae2953af0"));
		}

		#endregion

	}

	#endregion


	#region Class: VwSubProcessInProcessEventsProcess

	/// <exclude/>
	public class VwSubProcessInProcessEventsProcess : VwSubProcessInProcess_ProcessLibraryEventsProcess
	{

		public VwSubProcessInProcessEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

