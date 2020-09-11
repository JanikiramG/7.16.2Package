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

	#region Class: ContactCorrespondenceSchema

	/// <exclude/>
	public class ContactCorrespondenceSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ContactCorrespondenceSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactCorrespondenceSchema(ContactCorrespondenceSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactCorrespondenceSchema(ContactCorrespondenceSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fc7305a2-ef55-4d53-9f55-4ed4744d37c4");
			RealUId = new Guid("fc7305a2-ef55-4d53-9f55-4ed4744d37c4");
			Name = "ContactCorrespondence";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("1283089a-a4ff-4c97-9007-af5fe276bdde")) == null) {
				Columns.Add(CreateSourceContactIdColumn());
			}
			if (Columns.FindByUId(new Guid("811c39ae-0996-44e6-b581-273b1a9ff65e")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("0438f5bf-2e14-4866-b679-70f55be1bfae")) == null) {
				Columns.Add(CreateSourceAccountColumn());
			}
			if (Columns.FindByUId(new Guid("f2f8c264-0a7f-49ef-aa75-48f6443b2d0d")) == null) {
				Columns.Add(CreateSourceColumn());
			}
			if (Columns.FindByUId(new Guid("92306301-054b-43d3-8e19-6443cbb77ad1")) == null) {
				Columns.Add(CreateIsDeletedColumn());
			}
			if (Columns.FindByUId(new Guid("a11c226f-20c4-426b-838a-3efe54afd2d9")) == null) {
				Columns.Add(CreateSocialAccountNameColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("fc7305a2-ef55-4d53-9f55-4ed4744d37c4");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("fc7305a2-ef55-4d53-9f55-4ed4744d37c4");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("fc7305a2-ef55-4d53-9f55-4ed4744d37c4");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("fc7305a2-ef55-4d53-9f55-4ed4744d37c4");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("fc7305a2-ef55-4d53-9f55-4ed4744d37c4");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("fc7305a2-ef55-4d53-9f55-4ed4744d37c4");
			return column;
		}

		protected virtual EntitySchemaColumn CreateSourceContactIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("1283089a-a4ff-4c97-9007-af5fe276bdde"),
				Name = @"SourceContactId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("fc7305a2-ef55-4d53-9f55-4ed4744d37c4"),
				ModifiedInSchemaUId = new Guid("fc7305a2-ef55-4d53-9f55-4ed4744d37c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("811c39ae-0996-44e6-b581-273b1a9ff65e"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("fc7305a2-ef55-4d53-9f55-4ed4744d37c4"),
				ModifiedInSchemaUId = new Guid("fc7305a2-ef55-4d53-9f55-4ed4744d37c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSourceAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0438f5bf-2e14-4866-b679-70f55be1bfae"),
				Name = @"SourceAccount",
				ReferenceSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("fc7305a2-ef55-4d53-9f55-4ed4744d37c4"),
				ModifiedInSchemaUId = new Guid("fc7305a2-ef55-4d53-9f55-4ed4744d37c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSourceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f2f8c264-0a7f-49ef-aa75-48f6443b2d0d"),
				Name = @"Source",
				ReferenceSchemaUId = new Guid("d846cb4f-f18d-469e-83ff-e961f3fba873"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fc7305a2-ef55-4d53-9f55-4ed4744d37c4"),
				ModifiedInSchemaUId = new Guid("fc7305a2-ef55-4d53-9f55-4ed4744d37c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsDeletedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("92306301-054b-43d3-8e19-6443cbb77ad1"),
				Name = @"IsDeleted",
				CreatedInSchemaUId = new Guid("fc7305a2-ef55-4d53-9f55-4ed4744d37c4"),
				ModifiedInSchemaUId = new Guid("fc7305a2-ef55-4d53-9f55-4ed4744d37c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSocialAccountNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("a11c226f-20c4-426b-838a-3efe54afd2d9"),
				Name = @"SocialAccountName",
				CreatedInSchemaUId = new Guid("fc7305a2-ef55-4d53-9f55-4ed4744d37c4"),
				ModifiedInSchemaUId = new Guid("fc7305a2-ef55-4d53-9f55-4ed4744d37c4"),
				CreatedInPackageId = new Guid("45b7d114-643d-4217-a8b2-b9950d3eddb7")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateContactCorrespondenceEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateContactCorrespondenceEventsProcessSchema() {
			var schema = new ContactCorrespondenceEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ContactCorrespondence(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactCorrespondence_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactCorrespondenceSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactCorrespondenceSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fc7305a2-ef55-4d53-9f55-4ed4744d37c4"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactCorrespondence

	/// <summary>
	/// Contact in External Resources.
	/// </summary>
	public class ContactCorrespondence : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ContactCorrespondence(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactCorrespondence";
		}

		public ContactCorrespondence(ContactCorrespondence source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// External Resource Contact ID.
		/// </summary>
		public string SourceContactId {
			get {
				return GetTypedColumnValue<string>("SourceContactId");
			}
			set {
				SetColumnValue("SourceContactId", value);
			}
		}

		/// <exclude/>
		public Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public string ContactName {
			get {
				return GetTypedColumnValue<string>("ContactName");
			}
			set {
				SetColumnValue("ContactName", value);
				if (_contact != null) {
					_contact.Name = value;
				}
			}
		}

		private Contact _contact;
		/// <summary>
		/// Contact.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
			}
		}

		/// <exclude/>
		public Guid SourceAccountId {
			get {
				return GetTypedColumnValue<Guid>("SourceAccountId");
			}
			set {
				SetColumnValue("SourceAccountId", value);
				_sourceAccount = null;
			}
		}

		/// <exclude/>
		public string SourceAccountLogin {
			get {
				return GetTypedColumnValue<string>("SourceAccountLogin");
			}
			set {
				SetColumnValue("SourceAccountLogin", value);
				if (_sourceAccount != null) {
					_sourceAccount.Login = value;
				}
			}
		}

		private SocialAccount _sourceAccount;
		/// <summary>
		/// External Resource User Account ID.
		/// </summary>
		public SocialAccount SourceAccount {
			get {
				return _sourceAccount ??
					(_sourceAccount = LookupColumnEntities.GetEntity("SourceAccount") as SocialAccount);
			}
		}

		/// <exclude/>
		public Guid SourceId {
			get {
				return GetTypedColumnValue<Guid>("SourceId");
			}
			set {
				SetColumnValue("SourceId", value);
				_source = null;
			}
		}

		/// <exclude/>
		public string SourceName {
			get {
				return GetTypedColumnValue<string>("SourceName");
			}
			set {
				SetColumnValue("SourceName", value);
				if (_source != null) {
					_source.Name = value;
				}
			}
		}

		private CommunicationType _source;
		/// <summary>
		/// Resource.
		/// </summary>
		public CommunicationType Source {
			get {
				return _source ??
					(_source = LookupColumnEntities.GetEntity("Source") as CommunicationType);
			}
		}

		/// <summary>
		/// Deleted.
		/// </summary>
		public bool IsDeleted {
			get {
				return GetTypedColumnValue<bool>("IsDeleted");
			}
			set {
				SetColumnValue("IsDeleted", value);
			}
		}

		/// <summary>
		/// Social account name.
		/// </summary>
		public string SocialAccountName {
			get {
				return GetTypedColumnValue<string>("SocialAccountName");
			}
			set {
				SetColumnValue("SocialAccountName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContactCorrespondence_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContactCorrespondenceDeleted", e);
			Inserting += (s, e) => ThrowEvent("ContactCorrespondenceInserting", e);
			Validating += (s, e) => ThrowEvent("ContactCorrespondenceValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactCorrespondence(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactCorrespondence_BaseEventsProcess

	/// <exclude/>
	public partial class ContactCorrespondence_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ContactCorrespondence
	{

		public ContactCorrespondence_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactCorrespondence_BaseEventsProcess";
			SchemaUId = new Guid("fc7305a2-ef55-4d53-9f55-4ed4744d37c4");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fc7305a2-ef55-4d53-9f55-4ed4744d37c4");
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

	#region Class: ContactCorrespondence_BaseEventsProcess

	/// <exclude/>
	public class ContactCorrespondence_BaseEventsProcess : ContactCorrespondence_BaseEventsProcess<ContactCorrespondence>
	{

		public ContactCorrespondence_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContactCorrespondence_BaseEventsProcess

	public partial class ContactCorrespondence_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ContactCorrespondenceEventsProcessSchema

	/// <exclude/>
	public class ContactCorrespondenceEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ContactCorrespondenceEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ContactCorrespondenceEventsProcessSchema(ContactCorrespondenceEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ContactCorrespondence_BaseEventsProcess";
			UId = new Guid("19acee5a-cd7a-4907-8e24-ebc876242510");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
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
			return new ContactCorrespondenceEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("19acee5a-cd7a-4907-8e24-ebc876242510"));
		}

		#endregion

	}

	#endregion


	#region Class: ContactCorrespondenceEventsProcess

	/// <exclude/>
	public class ContactCorrespondenceEventsProcess : ContactCorrespondence_BaseEventsProcess
	{

		public ContactCorrespondenceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

