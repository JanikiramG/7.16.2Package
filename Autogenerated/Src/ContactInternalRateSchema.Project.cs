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

	#region Class: ContactInternalRateSchema

	/// <exclude/>
	public class ContactInternalRateSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ContactInternalRateSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactInternalRateSchema(ContactInternalRateSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactInternalRateSchema(ContactInternalRateSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5f9c3e78-8e43-4222-bac8-64f48bb6da3c");
			RealUId = new Guid("5f9c3e78-8e43-4222-bac8-64f48bb6da3c");
			Name = "ContactInternalRate";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5187aba0-4cb3-4b4c-9749-12155cf1f8be")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("1026ea1d-5c1d-4387-ae30-51a2ccc30d0d")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("45c85960-b456-4c35-bd32-7b1a003916c4")) == null) {
				Columns.Add(CreateDueDateColumn());
			}
			if (Columns.FindByUId(new Guid("2ca15d8b-d409-4544-958c-90a36bd441e8")) == null) {
				Columns.Add(CreateRateColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("5f9c3e78-8e43-4222-bac8-64f48bb6da3c");
			column.CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("5f9c3e78-8e43-4222-bac8-64f48bb6da3c");
			column.CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("5f9c3e78-8e43-4222-bac8-64f48bb6da3c");
			column.CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("5f9c3e78-8e43-4222-bac8-64f48bb6da3c");
			column.CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("5f9c3e78-8e43-4222-bac8-64f48bb6da3c");
			column.CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("5f9c3e78-8e43-4222-bac8-64f48bb6da3c");
			column.CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc");
			return column;
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5187aba0-4cb3-4b4c-9749-12155cf1f8be"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("5f9c3e78-8e43-4222-bac8-64f48bb6da3c"),
				ModifiedInSchemaUId = new Guid("5f9c3e78-8e43-4222-bac8-64f48bb6da3c"),
				CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc")
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("1026ea1d-5c1d-4387-ae30-51a2ccc30d0d"),
				Name = @"StartDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("5f9c3e78-8e43-4222-bac8-64f48bb6da3c"),
				ModifiedInSchemaUId = new Guid("5f9c3e78-8e43-4222-bac8-64f48bb6da3c"),
				CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDate")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateDueDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("45c85960-b456-4c35-bd32-7b1a003916c4"),
				Name = @"DueDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("5f9c3e78-8e43-4222-bac8-64f48bb6da3c"),
				ModifiedInSchemaUId = new Guid("5f9c3e78-8e43-4222-bac8-64f48bb6da3c"),
				CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc")
			};
		}

		protected virtual EntitySchemaColumn CreateRateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("2ca15d8b-d409-4544-958c-90a36bd441e8"),
				Name = @"Rate",
				CreatedInSchemaUId = new Guid("5f9c3e78-8e43-4222-bac8-64f48bb6da3c"),
				ModifiedInSchemaUId = new Guid("5f9c3e78-8e43-4222-bac8-64f48bb6da3c"),
				CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateContactInternalRateEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateContactInternalRateEventsProcessSchema() {
			var schema = new ContactInternalRateEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ContactInternalRate(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactInternalRate_ProjectEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactInternalRateSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactInternalRateSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5f9c3e78-8e43-4222-bac8-64f48bb6da3c"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactInternalRate

	/// <summary>
	/// Hourly wage.
	/// </summary>
	public class ContactInternalRate : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ContactInternalRate(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactInternalRate";
		}

		public ContactInternalRate(ContactInternalRate source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
		/// Employee.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
			}
		}

		/// <summary>
		/// From.
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
		/// Till.
		/// </summary>
		public DateTime DueDate {
			get {
				return GetTypedColumnValue<DateTime>("DueDate");
			}
			set {
				SetColumnValue("DueDate", value);
			}
		}

		/// <summary>
		/// Rate, base currency.
		/// </summary>
		public Decimal Rate {
			get {
				return GetTypedColumnValue<Decimal>("Rate");
			}
			set {
				SetColumnValue("Rate", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContactInternalRate_ProjectEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContactInternalRateDeleted", e);
			Inserting += (s, e) => ThrowEvent("ContactInternalRateInserting", e);
			Validating += (s, e) => ThrowEvent("ContactInternalRateValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactInternalRate(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactInternalRate_ProjectEventsProcess

	/// <exclude/>
	public partial class ContactInternalRate_ProjectEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ContactInternalRate
	{

		public ContactInternalRate_ProjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactInternalRate_ProjectEventsProcess";
			SchemaUId = new Guid("5f9c3e78-8e43-4222-bac8-64f48bb6da3c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5f9c3e78-8e43-4222-bac8-64f48bb6da3c");
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

	#region Class: ContactInternalRate_ProjectEventsProcess

	/// <exclude/>
	public class ContactInternalRate_ProjectEventsProcess : ContactInternalRate_ProjectEventsProcess<ContactInternalRate>
	{

		public ContactInternalRate_ProjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContactInternalRate_ProjectEventsProcess

	public partial class ContactInternalRate_ProjectEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ContactInternalRateEventsProcessSchema

	/// <exclude/>
	public class ContactInternalRateEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ContactInternalRateEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ContactInternalRateEventsProcessSchema(ContactInternalRateEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ContactInternalRate_ProjectEventsProcess";
			UId = new Guid("8050b1d1-b3a9-4ac3-8575-239dbd9b1cba");
			CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc");
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
				CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc")
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
			return new ContactInternalRateEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8050b1d1-b3a9-4ac3-8575-239dbd9b1cba"));
		}

		#endregion

	}

	#endregion


	#region Class: ContactInternalRateEventsProcess

	/// <exclude/>
	public class ContactInternalRateEventsProcess : ContactInternalRate_ProjectEventsProcess
	{

		public ContactInternalRateEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

