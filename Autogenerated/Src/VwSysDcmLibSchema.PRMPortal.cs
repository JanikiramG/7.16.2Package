namespace Terrasoft.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: VwSysDcmLibSchema

	/// <exclude/>
	public class VwSysDcmLibSchema : Terrasoft.Configuration.VwSysDcmLib_DcmDesigner_TerrasoftSchema
	{

		#region Constructors: Public

		public VwSysDcmLibSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSysDcmLibSchema(VwSysDcmLibSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSysDcmLibSchema(VwSysDcmLibSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("fab81128-a5f7-4522-b60c-88fb44f9abe0");
			Name = "VwSysDcmLib";
			ParentSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a");
			ExtendParent = true;
			CreatedInPackageId = new Guid("2b000645-6072-461d-8963-11edfee86881");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwSysDcmLibEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwSysDcmLibEventsProcessSchema() {
			var schema = new VwSysDcmLibEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSysDcmLib(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSysDcmLib_PRMPortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSysDcmLibSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSysDcmLibSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fab81128-a5f7-4522-b60c-88fb44f9abe0"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSysDcmLib

	/// <summary>
	/// Dcm library (view).
	/// </summary>
	public class VwSysDcmLib : Terrasoft.Configuration.VwSysDcmLib_DcmDesigner_Terrasoft
	{

		#region Constructors: Public

		public VwSysDcmLib(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSysDcmLib";
		}

		public VwSysDcmLib(VwSysDcmLib source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSysDcmLib_PRMPortalEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysDcmLib(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysDcmLib_PRMPortalEventsProcess

	/// <exclude/>
	public partial class VwSysDcmLib_PRMPortalEventsProcess<TEntity> : Terrasoft.Configuration.VwSysDcmLib_DcmDesignerEventsProcess<TEntity> where TEntity : VwSysDcmLib
	{

		public VwSysDcmLib_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysDcmLib_PRMPortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fab81128-a5f7-4522-b60c-88fb44f9abe0");
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

	#region Class: VwSysDcmLib_PRMPortalEventsProcess

	/// <exclude/>
	public class VwSysDcmLib_PRMPortalEventsProcess : VwSysDcmLib_PRMPortalEventsProcess<VwSysDcmLib>
	{

		public VwSysDcmLib_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysDcmLib_PRMPortalEventsProcess

	public partial class VwSysDcmLib_PRMPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwSysDcmLibEventsProcessSchema

	/// <exclude/>
	public class VwSysDcmLibEventsProcessSchema : Terrasoft.Configuration.VwSysDcmLib_DcmDesigner_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public VwSysDcmLibEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwSysDcmLibEventsProcessSchema(VwSysDcmLibEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwSysDcmLib_PRMPortalEventsProcess";
			UId = new Guid("60364bc1-2182-475d-aed6-71bd42c5deed");
			CreatedInPackageId = new Guid("2b000645-6072-461d-8963-11edfee86881");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.11.3.1716";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("01a84b9b-c7ff-4516-a610-03115274662f");
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

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysDcmLibEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("60364bc1-2182-475d-aed6-71bd42c5deed"));
		}

		#endregion

	}

	#endregion


	#region Class: VwSysDcmLibEventsProcess

	/// <exclude/>
	public class VwSysDcmLibEventsProcess : VwSysDcmLib_PRMPortalEventsProcess
	{

		public VwSysDcmLibEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

