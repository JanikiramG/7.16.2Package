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

	#region Class: SAMLFieldNameConverterSchema

	/// <exclude/>
	public class SAMLFieldNameConverterSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SAMLFieldNameConverterSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SAMLFieldNameConverterSchema(SAMLFieldNameConverterSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SAMLFieldNameConverterSchema(SAMLFieldNameConverterSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("50489d87-286f-420c-a306-ae2bdd7356fc");
			RealUId = new Guid("50489d87-286f-420c-a306-ae2bdd7356fc");
			Name = "SAMLFieldNameConverter";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("90e8157f-4651-4349-83a7-f0455fc70915");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("1cca6142-7ef1-4d7b-b068-9f180e6a3ce7")) == null) {
				Columns.Add(CreateSAMLFieldNameColumn());
			}
			if (Columns.FindByUId(new Guid("30e7fb61-c0a7-4f3a-9b56-4f3f980b7b05")) == null) {
				Columns.Add(CreateContactFieldNameColumn());
			}
			if (Columns.FindByUId(new Guid("f758a26f-dbaf-409f-a617-6a75e720fb27")) == null) {
				Columns.Add(CreateColumnDefaultValueColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSAMLFieldNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("1cca6142-7ef1-4d7b-b068-9f180e6a3ce7"),
				Name = @"SAMLFieldName",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("50489d87-286f-420c-a306-ae2bdd7356fc"),
				ModifiedInSchemaUId = new Guid("50489d87-286f-420c-a306-ae2bdd7356fc"),
				CreatedInPackageId = new Guid("90e8157f-4651-4349-83a7-f0455fc70915")
			};
		}

		protected virtual EntitySchemaColumn CreateContactFieldNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("30e7fb61-c0a7-4f3a-9b56-4f3f980b7b05"),
				Name = @"ContactFieldName",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("50489d87-286f-420c-a306-ae2bdd7356fc"),
				ModifiedInSchemaUId = new Guid("50489d87-286f-420c-a306-ae2bdd7356fc"),
				CreatedInPackageId = new Guid("90e8157f-4651-4349-83a7-f0455fc70915")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnDefaultValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("f758a26f-dbaf-409f-a617-6a75e720fb27"),
				Name = @"ColumnDefaultValue",
				CreatedInSchemaUId = new Guid("50489d87-286f-420c-a306-ae2bdd7356fc"),
				ModifiedInSchemaUId = new Guid("50489d87-286f-420c-a306-ae2bdd7356fc"),
				CreatedInPackageId = new Guid("90e8157f-4651-4349-83a7-f0455fc70915")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSAMLFieldNameConverterEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSAMLFieldNameConverterEventsProcessSchema() {
			var schema = new SAMLFieldNameConverterEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SAMLFieldNameConverter(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SAMLFieldNameConverter_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SAMLFieldNameConverterSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SAMLFieldNameConverterSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("50489d87-286f-420c-a306-ae2bdd7356fc"));
		}

		#endregion

	}

	#endregion

	#region Class: SAMLFieldNameConverter

	/// <summary>
	/// SAML field name converter to contact field name.
	/// </summary>
	public class SAMLFieldNameConverter : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SAMLFieldNameConverter(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SAMLFieldNameConverter";
		}

		public SAMLFieldNameConverter(SAMLFieldNameConverter source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// SAML field attribute.
		/// </summary>
		public string SAMLFieldName {
			get {
				return GetTypedColumnValue<string>("SAMLFieldName");
			}
			set {
				SetColumnValue("SAMLFieldName", value);
			}
		}

		/// <summary>
		/// Contact field name.
		/// </summary>
		public string ContactFieldName {
			get {
				return GetTypedColumnValue<string>("ContactFieldName");
			}
			set {
				SetColumnValue("ContactFieldName", value);
			}
		}

		/// <summary>
		/// Column default value.
		/// </summary>
		public string ColumnDefaultValue {
			get {
				return GetTypedColumnValue<string>("ColumnDefaultValue");
			}
			set {
				SetColumnValue("ColumnDefaultValue", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SAMLFieldNameConverter_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SAMLFieldNameConverterDeleted", e);
			Validating += (s, e) => ThrowEvent("SAMLFieldNameConverterValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SAMLFieldNameConverter(this);
		}

		#endregion

	}

	#endregion

	#region Class: SAMLFieldNameConverter_BaseEventsProcess

	/// <exclude/>
	public partial class SAMLFieldNameConverter_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SAMLFieldNameConverter
	{

		public SAMLFieldNameConverter_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SAMLFieldNameConverter_BaseEventsProcess";
			SchemaUId = new Guid("50489d87-286f-420c-a306-ae2bdd7356fc");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("50489d87-286f-420c-a306-ae2bdd7356fc");
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

	#region Class: SAMLFieldNameConverter_BaseEventsProcess

	/// <exclude/>
	public class SAMLFieldNameConverter_BaseEventsProcess : SAMLFieldNameConverter_BaseEventsProcess<SAMLFieldNameConverter>
	{

		public SAMLFieldNameConverter_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SAMLFieldNameConverter_BaseEventsProcess

	public partial class SAMLFieldNameConverter_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SAMLFieldNameConverterEventsProcessSchema

	/// <exclude/>
	public class SAMLFieldNameConverterEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SAMLFieldNameConverterEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SAMLFieldNameConverterEventsProcessSchema(SAMLFieldNameConverterEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SAMLFieldNameConverter_BaseEventsProcess";
			UId = new Guid("e77d93a5-d955-4240-92cc-c1066b0bfc9b");
			CreatedInPackageId = new Guid("90e8157f-4651-4349-83a7-f0455fc70915");
			CreatedInSchemaUId = Guid.Empty;
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
			return new SAMLFieldNameConverterEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e77d93a5-d955-4240-92cc-c1066b0bfc9b"));
		}

		#endregion

	}

	#endregion


	#region Class: SAMLFieldNameConverterEventsProcess

	/// <exclude/>
	public class SAMLFieldNameConverterEventsProcess : SAMLFieldNameConverter_BaseEventsProcess
	{

		public SAMLFieldNameConverterEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

