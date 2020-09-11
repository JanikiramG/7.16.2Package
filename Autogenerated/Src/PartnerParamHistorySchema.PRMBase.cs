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
	using Terrasoft.Configuration;
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

	#region Class: PartnerParamHistorySchema

	/// <exclude/>
	public class PartnerParamHistorySchema : Terrasoft.Configuration.PartnershipParameterSchema
	{

		#region Constructors: Public

		public PartnerParamHistorySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public PartnerParamHistorySchema(PartnerParamHistorySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public PartnerParamHistorySchema(PartnerParamHistorySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("488977f0-7923-47ae-ba50-d05c93101210");
			RealUId = new Guid("488977f0-7923-47ae-ba50-d05c93101210");
			Name = "PartnerParamHistory";
			ParentSchemaUId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f43a6760-9275-4070-90a5-eacccad59d8c");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("2a24e7e0-4ac5-4077-8160-f7e69ede3e2c")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("b2cc7804-e355-4e23-9527-91cb2c08e533")) == null) {
				Columns.Add(CreateEndDateColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("2a24e7e0-4ac5-4077-8160-f7e69ede3e2c"),
				Name = @"StartDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("488977f0-7923-47ae-ba50-d05c93101210"),
				ModifiedInSchemaUId = new Guid("488977f0-7923-47ae-ba50-d05c93101210"),
				CreatedInPackageId = new Guid("f43a6760-9275-4070-90a5-eacccad59d8c"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDateTime")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateEndDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("b2cc7804-e355-4e23-9527-91cb2c08e533"),
				Name = @"EndDate",
				CreatedInSchemaUId = new Guid("488977f0-7923-47ae-ba50-d05c93101210"),
				ModifiedInSchemaUId = new Guid("488977f0-7923-47ae-ba50-d05c93101210"),
				CreatedInPackageId = new Guid("f43a6760-9275-4070-90a5-eacccad59d8c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreatePartnerParamHistoryEventsProcessSchema();
		}

		protected virtual ProcessSchema CreatePartnerParamHistoryEventsProcessSchema() {
			var schema = new PartnerParamHistoryEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new PartnerParamHistory(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new PartnerParamHistory_PRMBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new PartnerParamHistorySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new PartnerParamHistorySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("488977f0-7923-47ae-ba50-d05c93101210"));
		}

		#endregion

	}

	#endregion

	#region Class: PartnerParamHistory

	/// <summary>
	/// History of partnership parameter.
	/// </summary>
	public class PartnerParamHistory : Terrasoft.Configuration.PartnershipParameter
	{

		#region Constructors: Public

		public PartnerParamHistory(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "PartnerParamHistory";
		}

		public PartnerParamHistory(PartnerParamHistory source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Start date.
		/// </summary>
		public DateTime StartDate {
			get {
				return GetTypedColumnValue<DateTime>("StartDate");
			}
			set {
				SetColumnValue("StartDate", value);
			}
		}

		/// <summary>
		/// End date.
		/// </summary>
		public DateTime EndDate {
			get {
				return GetTypedColumnValue<DateTime>("EndDate");
			}
			set {
				SetColumnValue("EndDate", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new PartnerParamHistory_PRMBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("PartnerParamHistoryDeleted", e);
			Deleting += (s, e) => ThrowEvent("PartnerParamHistoryDeleting", e);
			Validating += (s, e) => ThrowEvent("PartnerParamHistoryValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PartnerParamHistory(this);
		}

		#endregion

	}

	#endregion

	#region Class: PartnerParamHistory_PRMBaseEventsProcess

	/// <exclude/>
	public partial class PartnerParamHistory_PRMBaseEventsProcess<TEntity> : Terrasoft.Configuration.PartnershipParameter_PRMOrderEventsProcess<TEntity> where TEntity : PartnerParamHistory
	{

		public PartnerParamHistory_PRMBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "PartnerParamHistory_PRMBaseEventsProcess";
			SchemaUId = new Guid("488977f0-7923-47ae-ba50-d05c93101210");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("488977f0-7923-47ae-ba50-d05c93101210");
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

	#region Class: PartnerParamHistory_PRMBaseEventsProcess

	/// <exclude/>
	public class PartnerParamHistory_PRMBaseEventsProcess : PartnerParamHistory_PRMBaseEventsProcess<PartnerParamHistory>
	{

		public PartnerParamHistory_PRMBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: PartnerParamHistory_PRMBaseEventsProcess

	public partial class PartnerParamHistory_PRMBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public override bool UpdateStringValueMethod() {
			return true;
		}

		#endregion

	}

	#endregion

	#region Class: PartnerParamHistoryEventsProcessSchema

	/// <exclude/>
	public class PartnerParamHistoryEventsProcessSchema : Terrasoft.Configuration.PartnershipParameterEventsProcessSchema
	{

		#region Constructors: Public

		public PartnerParamHistoryEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public PartnerParamHistoryEventsProcessSchema(PartnerParamHistoryEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "PartnerParamHistory_PRMBaseEventsProcess";
			UId = new Guid("176237ba-3bf8-4221-acab-d5fcd09bb654");
			CreatedInPackageId = new Guid("f43a6760-9275-4070-90a5-eacccad59d8c");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea");
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

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
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
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8360e463-41b5-41d2-843f-59f49671d0da"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("005ad3fb-44f2-4317-ae32-8e4b6c6b0bac"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("f43a6760-9275-4070-90a5-eacccad59d8c")
			});
		}

		protected override SchemaMethod CreateUpdateStringValueMethodMethod() {
			SchemaMethod method = base.CreateUpdateStringValueMethodMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PartnerParamHistoryEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("176237ba-3bf8-4221-acab-d5fcd09bb654"));
		}

		#endregion

	}

	#endregion


	#region Class: PartnerParamHistoryEventsProcess

	/// <exclude/>
	public class PartnerParamHistoryEventsProcess : PartnerParamHistory_PRMBaseEventsProcess
	{

		public PartnerParamHistoryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

