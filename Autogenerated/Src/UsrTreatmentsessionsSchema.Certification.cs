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

	#region Class: UsrTreatmentsessionsSchema

	/// <exclude/>
	public class UsrTreatmentsessionsSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public UsrTreatmentsessionsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrTreatmentsessionsSchema(UsrTreatmentsessionsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrTreatmentsessionsSchema(UsrTreatmentsessionsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1fb12a5c-bdf3-44b2-a889-4f405cfc7364");
			RealUId = new Guid("1fb12a5c-bdf3-44b2-a889-4f405cfc7364");
			Name = "UsrTreatmentsessions";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("6b7558a3-7144-4658-a45d-bb760f4e7e93");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("cc7a4d75-5a7d-4ccc-85f6-4199d0a60abe")) == null) {
				Columns.Add(CreateUsrTreatmentsessiondateColumn());
			}
			if (Columns.FindByUId(new Guid("42765071-51ef-473a-a77f-6dbd3936f280")) == null) {
				Columns.Add(CreateUsrOperatorColumn());
			}
			if (Columns.FindByUId(new Guid("55da1cad-09d5-4f2b-8b27-d370bfcbacc8")) == null) {
				Columns.Add(CreateUsrSessiondurationminutesColumn());
			}
			if (Columns.FindByUId(new Guid("82472dd4-a5b0-48f6-b836-8e132699e899")) == null) {
				Columns.Add(CreateUsrPriceColumn());
			}
			if (Columns.FindByUId(new Guid("023860c3-4ba7-4064-aa1e-f2b0ec964c98")) == null) {
				Columns.Add(CreateUsrTreatmentProgramsColumn());
			}
			if (Columns.FindByUId(new Guid("0ff67e8d-7555-4f9d-bbb6-5fac16932cb0")) == null) {
				Columns.Add(CreateUsrSessionstatusColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("1fb12a5c-bdf3-44b2-a889-4f405cfc7364");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("1fb12a5c-bdf3-44b2-a889-4f405cfc7364");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("1fb12a5c-bdf3-44b2-a889-4f405cfc7364");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("1fb12a5c-bdf3-44b2-a889-4f405cfc7364");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("1fb12a5c-bdf3-44b2-a889-4f405cfc7364");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("1fb12a5c-bdf3-44b2-a889-4f405cfc7364");
			return column;
		}

		protected virtual EntitySchemaColumn CreateUsrTreatmentsessiondateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("cc7a4d75-5a7d-4ccc-85f6-4199d0a60abe"),
				Name = @"UsrTreatmentsessiondate",
				IsCascade = true,
				CreatedInSchemaUId = new Guid("1fb12a5c-bdf3-44b2-a889-4f405cfc7364"),
				ModifiedInSchemaUId = new Guid("1fb12a5c-bdf3-44b2-a889-4f405cfc7364"),
				CreatedInPackageId = new Guid("6b7558a3-7144-4658-a45d-bb760f4e7e93")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrOperatorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("42765071-51ef-473a-a77f-6dbd3936f280"),
				Name = @"UsrOperator",
				IsCascade = true,
				CreatedInSchemaUId = new Guid("1fb12a5c-bdf3-44b2-a889-4f405cfc7364"),
				ModifiedInSchemaUId = new Guid("1fb12a5c-bdf3-44b2-a889-4f405cfc7364"),
				CreatedInPackageId = new Guid("6b7558a3-7144-4658-a45d-bb760f4e7e93")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrSessiondurationminutesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("55da1cad-09d5-4f2b-8b27-d370bfcbacc8"),
				Name = @"UsrSessiondurationminutes",
				IsCascade = true,
				CreatedInSchemaUId = new Guid("1fb12a5c-bdf3-44b2-a889-4f405cfc7364"),
				ModifiedInSchemaUId = new Guid("1fb12a5c-bdf3-44b2-a889-4f405cfc7364"),
				CreatedInPackageId = new Guid("6b7558a3-7144-4658-a45d-bb760f4e7e93")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrPriceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("82472dd4-a5b0-48f6-b836-8e132699e899"),
				Name = @"UsrPrice",
				IsCascade = true,
				CreatedInSchemaUId = new Guid("1fb12a5c-bdf3-44b2-a889-4f405cfc7364"),
				ModifiedInSchemaUId = new Guid("1fb12a5c-bdf3-44b2-a889-4f405cfc7364"),
				CreatedInPackageId = new Guid("6b7558a3-7144-4658-a45d-bb760f4e7e93")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrTreatmentProgramsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("023860c3-4ba7-4064-aa1e-f2b0ec964c98"),
				Name = @"UsrTreatmentPrograms",
				ReferenceSchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("1fb12a5c-bdf3-44b2-a889-4f405cfc7364"),
				ModifiedInSchemaUId = new Guid("1fb12a5c-bdf3-44b2-a889-4f405cfc7364"),
				CreatedInPackageId = new Guid("6b7558a3-7144-4658-a45d-bb760f4e7e93")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrSessionstatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0ff67e8d-7555-4f9d-bbb6-5fac16932cb0"),
				Name = @"UsrSessionstatus",
				ReferenceSchemaUId = new Guid("01c513a8-d910-4cd6-bfb5-4cdc99624a54"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("1fb12a5c-bdf3-44b2-a889-4f405cfc7364"),
				ModifiedInSchemaUId = new Guid("1fb12a5c-bdf3-44b2-a889-4f405cfc7364"),
				CreatedInPackageId = new Guid("6b7558a3-7144-4658-a45d-bb760f4e7e93")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateUsrTreatmentsessionsEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateUsrTreatmentsessionsEventsProcessSchema() {
			var schema = new UsrTreatmentsessionsEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new UsrTreatmentsessions(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrTreatmentsessions_CertificationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrTreatmentsessionsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrTreatmentsessionsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1fb12a5c-bdf3-44b2-a889-4f405cfc7364"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrTreatmentsessions

	/// <summary>
	/// Treatment sessions.
	/// </summary>
	public class UsrTreatmentsessions : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public UsrTreatmentsessions(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrTreatmentsessions";
		}

		public UsrTreatmentsessions(UsrTreatmentsessions source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Treatment session date.
		/// </summary>
		public DateTime UsrTreatmentsessiondate {
			get {
				return GetTypedColumnValue<DateTime>("UsrTreatmentsessiondate");
			}
			set {
				SetColumnValue("UsrTreatmentsessiondate", value);
			}
		}

		/// <summary>
		/// Operator.
		/// </summary>
		public string UsrOperator {
			get {
				return GetTypedColumnValue<string>("UsrOperator");
			}
			set {
				SetColumnValue("UsrOperator", value);
			}
		}

		/// <summary>
		/// Session duration minutes.
		/// </summary>
		public string UsrSessiondurationminutes {
			get {
				return GetTypedColumnValue<string>("UsrSessiondurationminutes");
			}
			set {
				SetColumnValue("UsrSessiondurationminutes", value);
			}
		}

		/// <summary>
		/// Price.
		/// </summary>
		public Decimal UsrPrice {
			get {
				return GetTypedColumnValue<Decimal>("UsrPrice");
			}
			set {
				SetColumnValue("UsrPrice", value);
			}
		}

		/// <exclude/>
		public Guid UsrTreatmentProgramsId {
			get {
				return GetTypedColumnValue<Guid>("UsrTreatmentProgramsId");
			}
			set {
				SetColumnValue("UsrTreatmentProgramsId", value);
				_usrTreatmentPrograms = null;
			}
		}

		/// <exclude/>
		public string UsrTreatmentProgramsUsrName {
			get {
				return GetTypedColumnValue<string>("UsrTreatmentProgramsUsrName");
			}
			set {
				SetColumnValue("UsrTreatmentProgramsUsrName", value);
				if (_usrTreatmentPrograms != null) {
					_usrTreatmentPrograms.UsrName = value;
				}
			}
		}

		private UsrTreatmentprograms _usrTreatmentPrograms;
		/// <summary>
		/// Treatment Programs.
		/// </summary>
		public UsrTreatmentprograms UsrTreatmentPrograms {
			get {
				return _usrTreatmentPrograms ??
					(_usrTreatmentPrograms = LookupColumnEntities.GetEntity("UsrTreatmentPrograms") as UsrTreatmentprograms);
			}
		}

		/// <exclude/>
		public Guid UsrSessionstatusId {
			get {
				return GetTypedColumnValue<Guid>("UsrSessionstatusId");
			}
			set {
				SetColumnValue("UsrSessionstatusId", value);
				_usrSessionstatus = null;
			}
		}

		/// <exclude/>
		public string UsrSessionstatusName {
			get {
				return GetTypedColumnValue<string>("UsrSessionstatusName");
			}
			set {
				SetColumnValue("UsrSessionstatusName", value);
				if (_usrSessionstatus != null) {
					_usrSessionstatus.Name = value;
				}
			}
		}

		private UsrSessionstatus _usrSessionstatus;
		/// <summary>
		/// Session status.
		/// </summary>
		public UsrSessionstatus UsrSessionstatus {
			get {
				return _usrSessionstatus ??
					(_usrSessionstatus = LookupColumnEntities.GetEntity("UsrSessionstatus") as UsrSessionstatus);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UsrTreatmentsessions_CertificationEventsProcess(UserConnection);
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
			return new UsrTreatmentsessions(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrTreatmentsessions_CertificationEventsProcess

	/// <exclude/>
	public partial class UsrTreatmentsessions_CertificationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : UsrTreatmentsessions
	{

		public UsrTreatmentsessions_CertificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrTreatmentsessions_CertificationEventsProcess";
			SchemaUId = new Guid("1fb12a5c-bdf3-44b2-a889-4f405cfc7364");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1fb12a5c-bdf3-44b2-a889-4f405cfc7364");
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

	#region Class: UsrTreatmentsessions_CertificationEventsProcess

	/// <exclude/>
	public class UsrTreatmentsessions_CertificationEventsProcess : UsrTreatmentsessions_CertificationEventsProcess<UsrTreatmentsessions>
	{

		public UsrTreatmentsessions_CertificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrTreatmentsessions_CertificationEventsProcess

	public partial class UsrTreatmentsessions_CertificationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: UsrTreatmentsessionsEventsProcessSchema

	/// <exclude/>
	public class UsrTreatmentsessionsEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public UsrTreatmentsessionsEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public UsrTreatmentsessionsEventsProcessSchema(UsrTreatmentsessionsEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "UsrTreatmentsessions_CertificationEventsProcess";
			UId = new Guid("a38ef35d-a0f3-4f4b-b194-71a1d7513e3e");
			CreatedInPackageId = new Guid("6b7558a3-7144-4658-a45d-bb760f4e7e93");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.16.2.1600";
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
			return new UsrTreatmentsessionsEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a38ef35d-a0f3-4f4b-b194-71a1d7513e3e"));
		}

		#endregion

	}

	#endregion


	#region Class: UsrTreatmentsessionsEventsProcess

	/// <exclude/>
	public class UsrTreatmentsessionsEventsProcess : UsrTreatmentsessions_CertificationEventsProcess
	{

		public UsrTreatmentsessionsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

