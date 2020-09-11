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

	#region Class: LDAPElementSchema

	/// <exclude/>
	public class LDAPElementSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public LDAPElementSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LDAPElementSchema(LDAPElementSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LDAPElementSchema(LDAPElementSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb");
			RealUId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb");
			Name = "LDAPElement";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("9455e8ee-c1b2-4f85-8263-bcf4e7ad4866");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("bba6f929-b032-47e6-b76c-4cb9d3a8fcce")) == null) {
				Columns.Add(CreateLDAPEntryIdColumn());
			}
			if (Columns.FindByUId(new Guid("618fc314-1662-4d00-8235-7f8571a488e8")) == null) {
				Columns.Add(CreateLDAPEntryDNColumn());
			}
			if (Columns.FindByUId(new Guid("9f0e8450-bf80-4261-8bea-91a4a0e451a5")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("8339497f-6132-4a4d-941f-2977ad5e2c7e")) == null) {
				Columns.Add(CreateFullNameColumn());
			}
			if (Columns.FindByUId(new Guid("f474acfb-f0b9-4bd0-8489-8bd9b604ef91")) == null) {
				Columns.Add(CreateCompanyColumn());
			}
			if (Columns.FindByUId(new Guid("6e42f252-a516-46aa-9fef-041bd6585b44")) == null) {
				Columns.Add(CreateEmailColumn());
			}
			if (Columns.FindByUId(new Guid("106226b4-7044-4525-a664-9c9930b5e325")) == null) {
				Columns.Add(CreatePhoneColumn());
			}
			if (Columns.FindByUId(new Guid("9b020abb-bff7-49f8-8d29-cc180847128f")) == null) {
				Columns.Add(CreateJobTitleColumn());
			}
			if (Columns.FindByUId(new Guid("6c4cca34-44bb-4fa8-bfab-0aec32048eb5")) == null) {
				Columns.Add(CreateIsActiveColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb");
			return column;
		}

		protected virtual EntitySchemaColumn CreateLDAPEntryIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("bba6f929-b032-47e6-b76c-4cb9d3a8fcce"),
				Name = @"LDAPEntryId",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb"),
				ModifiedInSchemaUId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb"),
				CreatedInPackageId = new Guid("9455e8ee-c1b2-4f85-8263-bcf4e7ad4866")
			};
		}

		protected virtual EntitySchemaColumn CreateLDAPEntryDNColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("618fc314-1662-4d00-8235-7f8571a488e8"),
				Name = @"LDAPEntryDN",
				CreatedInSchemaUId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb"),
				ModifiedInSchemaUId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb"),
				CreatedInPackageId = new Guid("9455e8ee-c1b2-4f85-8263-bcf4e7ad4866")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("9f0e8450-bf80-4261-8bea-91a4a0e451a5"),
				Name = @"Type",
				CreatedInSchemaUId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb"),
				ModifiedInSchemaUId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb"),
				CreatedInPackageId = new Guid("d1304e55-520c-4566-9530-483a3299e343")
			};
		}

		protected virtual EntitySchemaColumn CreateFullNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("8339497f-6132-4a4d-941f-2977ad5e2c7e"),
				Name = @"FullName",
				CreatedInSchemaUId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb"),
				ModifiedInSchemaUId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb"),
				CreatedInPackageId = new Guid("7ac00ac8-4704-4c6a-999a-db94daccf6cd")
			};
		}

		protected virtual EntitySchemaColumn CreateCompanyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("f474acfb-f0b9-4bd0-8489-8bd9b604ef91"),
				Name = @"Company",
				CreatedInSchemaUId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb"),
				ModifiedInSchemaUId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb"),
				CreatedInPackageId = new Guid("7ac00ac8-4704-4c6a-999a-db94daccf6cd")
			};
		}

		protected virtual EntitySchemaColumn CreateEmailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("6e42f252-a516-46aa-9fef-041bd6585b44"),
				Name = @"Email",
				CreatedInSchemaUId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb"),
				ModifiedInSchemaUId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb"),
				CreatedInPackageId = new Guid("7ac00ac8-4704-4c6a-999a-db94daccf6cd")
			};
		}

		protected virtual EntitySchemaColumn CreatePhoneColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("106226b4-7044-4525-a664-9c9930b5e325"),
				Name = @"Phone",
				CreatedInSchemaUId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb"),
				ModifiedInSchemaUId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb"),
				CreatedInPackageId = new Guid("7ac00ac8-4704-4c6a-999a-db94daccf6cd")
			};
		}

		protected virtual EntitySchemaColumn CreateJobTitleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("9b020abb-bff7-49f8-8d29-cc180847128f"),
				Name = @"JobTitle",
				CreatedInSchemaUId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb"),
				ModifiedInSchemaUId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb"),
				CreatedInPackageId = new Guid("7ac00ac8-4704-4c6a-999a-db94daccf6cd")
			};
		}

		protected virtual EntitySchemaColumn CreateIsActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("6c4cca34-44bb-4fa8-bfab-0aec32048eb5"),
				Name = @"IsActive",
				CreatedInSchemaUId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb"),
				ModifiedInSchemaUId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb"),
				CreatedInPackageId = new Guid("e430cf7d-0a41-4669-8668-da1aca11ad49")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLDAPElementEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateLDAPElementEventsProcessSchema() {
			var schema = new LDAPElementEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LDAPElement(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LDAPElement_LDAPEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LDAPElementSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LDAPElementSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2811d726-f327-44be-9548-c8d90edee2cb"));
		}

		#endregion

	}

	#endregion

	#region Class: LDAPElement

	/// <summary>
	/// LDAP element.
	/// </summary>
	public class LDAPElement : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public LDAPElement(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LDAPElement";
		}

		public LDAPElement(LDAPElement source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// LDAP element Id.
		/// </summary>
		public string LDAPEntryId {
			get {
				return GetTypedColumnValue<string>("LDAPEntryId");
			}
			set {
				SetColumnValue("LDAPEntryId", value);
			}
		}

		/// <summary>
		/// LDAP element unique name.
		/// </summary>
		public string LDAPEntryDN {
			get {
				return GetTypedColumnValue<string>("LDAPEntryDN");
			}
			set {
				SetColumnValue("LDAPEntryDN", value);
			}
		}

		/// <summary>
		/// Type.
		/// </summary>
		public int Type {
			get {
				return GetTypedColumnValue<int>("Type");
			}
			set {
				SetColumnValue("Type", value);
			}
		}

		/// <summary>
		/// Full name.
		/// </summary>
		public string FullName {
			get {
				return GetTypedColumnValue<string>("FullName");
			}
			set {
				SetColumnValue("FullName", value);
			}
		}

		/// <summary>
		/// Company.
		/// </summary>
		public string Company {
			get {
				return GetTypedColumnValue<string>("Company");
			}
			set {
				SetColumnValue("Company", value);
			}
		}

		/// <summary>
		/// Email.
		/// </summary>
		public string Email {
			get {
				return GetTypedColumnValue<string>("Email");
			}
			set {
				SetColumnValue("Email", value);
			}
		}

		/// <summary>
		/// Phone.
		/// </summary>
		public string Phone {
			get {
				return GetTypedColumnValue<string>("Phone");
			}
			set {
				SetColumnValue("Phone", value);
			}
		}

		/// <summary>
		/// Job title.
		/// </summary>
		public string JobTitle {
			get {
				return GetTypedColumnValue<string>("JobTitle");
			}
			set {
				SetColumnValue("JobTitle", value);
			}
		}

		/// <summary>
		/// Active user.
		/// </summary>
		public bool IsActive {
			get {
				return GetTypedColumnValue<bool>("IsActive");
			}
			set {
				SetColumnValue("IsActive", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LDAPElement_LDAPEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("LDAPElementDeleted", e);
			Validating += (s, e) => ThrowEvent("LDAPElementValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LDAPElement(this);
		}

		#endregion

	}

	#endregion

	#region Class: LDAPElement_LDAPEventsProcess

	/// <exclude/>
	public partial class LDAPElement_LDAPEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : LDAPElement
	{

		public LDAPElement_LDAPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LDAPElement_LDAPEventsProcess";
			SchemaUId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2811d726-f327-44be-9548-c8d90edee2cb");
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

	#region Class: LDAPElement_LDAPEventsProcess

	/// <exclude/>
	public class LDAPElement_LDAPEventsProcess : LDAPElement_LDAPEventsProcess<LDAPElement>
	{

		public LDAPElement_LDAPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LDAPElement_LDAPEventsProcess

	public partial class LDAPElement_LDAPEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: LDAPElementEventsProcessSchema

	/// <exclude/>
	public class LDAPElementEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public LDAPElementEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LDAPElementEventsProcessSchema(LDAPElementEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LDAPElement_LDAPEventsProcess";
			UId = new Guid("8db5b349-f767-4223-bcd1-e9ccd010a990");
			CreatedInPackageId = new Guid("9455e8ee-c1b2-4f85-8263-bcf4e7ad4866");
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
			return new LDAPElementEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8db5b349-f767-4223-bcd1-e9ccd010a990"));
		}

		#endregion

	}

	#endregion


	#region Class: LDAPElementEventsProcess

	/// <exclude/>
	public class LDAPElementEventsProcess : LDAPElement_LDAPEventsProcess
	{

		public LDAPElementEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

