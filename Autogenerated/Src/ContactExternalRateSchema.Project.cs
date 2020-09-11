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

	#region Class: ContactExternalRateSchema

	/// <exclude/>
	public class ContactExternalRateSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ContactExternalRateSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactExternalRateSchema(ContactExternalRateSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactExternalRateSchema(ContactExternalRateSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7533ac53-9aae-4fb8-9b2b-2166a81d669c");
			RealUId = new Guid("7533ac53-9aae-4fb8-9b2b-2166a81d669c");
			Name = "ContactExternalRate";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("156e609a-7dbd-4e26-afe8-e5fa96196410")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("13baab65-1b9c-4f7a-a054-8871d821ce08")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("ea66df6e-c03e-422d-9eb7-651363235ce6")) == null) {
				Columns.Add(CreateDueDateColumn());
			}
			if (Columns.FindByUId(new Guid("a2c99f8a-c4ed-4b95-8ecf-9e774aa30eb3")) == null) {
				Columns.Add(CreateRateColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("7533ac53-9aae-4fb8-9b2b-2166a81d669c");
			column.CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("7533ac53-9aae-4fb8-9b2b-2166a81d669c");
			column.CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("7533ac53-9aae-4fb8-9b2b-2166a81d669c");
			column.CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("7533ac53-9aae-4fb8-9b2b-2166a81d669c");
			column.CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("7533ac53-9aae-4fb8-9b2b-2166a81d669c");
			column.CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("7533ac53-9aae-4fb8-9b2b-2166a81d669c");
			column.CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc");
			return column;
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("156e609a-7dbd-4e26-afe8-e5fa96196410"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("7533ac53-9aae-4fb8-9b2b-2166a81d669c"),
				ModifiedInSchemaUId = new Guid("7533ac53-9aae-4fb8-9b2b-2166a81d669c"),
				CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc")
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("13baab65-1b9c-4f7a-a054-8871d821ce08"),
				Name = @"StartDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("7533ac53-9aae-4fb8-9b2b-2166a81d669c"),
				ModifiedInSchemaUId = new Guid("7533ac53-9aae-4fb8-9b2b-2166a81d669c"),
				CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDate")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateDueDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("ea66df6e-c03e-422d-9eb7-651363235ce6"),
				Name = @"DueDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("7533ac53-9aae-4fb8-9b2b-2166a81d669c"),
				ModifiedInSchemaUId = new Guid("7533ac53-9aae-4fb8-9b2b-2166a81d669c"),
				CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc")
			};
		}

		protected virtual EntitySchemaColumn CreateRateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("a2c99f8a-c4ed-4b95-8ecf-9e774aa30eb3"),
				Name = @"Rate",
				CreatedInSchemaUId = new Guid("7533ac53-9aae-4fb8-9b2b-2166a81d669c"),
				ModifiedInSchemaUId = new Guid("7533ac53-9aae-4fb8-9b2b-2166a81d669c"),
				CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateContactExternalRateEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateContactExternalRateEventsProcessSchema() {
			var schema = new ContactExternalRateEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ContactExternalRate(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactExternalRate_ProjectEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactExternalRateSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactExternalRateSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7533ac53-9aae-4fb8-9b2b-2166a81d669c"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactExternalRate

	/// <summary>
	/// External fee of employee.
	/// </summary>
	public class ContactExternalRate : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ContactExternalRate(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactExternalRate";
		}

		public ContactExternalRate(ContactExternalRate source)
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
			var process = new ContactExternalRate_ProjectEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContactExternalRateDeleted", e);
			Inserting += (s, e) => ThrowEvent("ContactExternalRateInserting", e);
			Validating += (s, e) => ThrowEvent("ContactExternalRateValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactExternalRate(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactExternalRate_ProjectEventsProcess

	/// <exclude/>
	public partial class ContactExternalRate_ProjectEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ContactExternalRate
	{

		public ContactExternalRate_ProjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactExternalRate_ProjectEventsProcess";
			SchemaUId = new Guid("7533ac53-9aae-4fb8-9b2b-2166a81d669c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7533ac53-9aae-4fb8-9b2b-2166a81d669c");
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

	#region Class: ContactExternalRate_ProjectEventsProcess

	/// <exclude/>
	public class ContactExternalRate_ProjectEventsProcess : ContactExternalRate_ProjectEventsProcess<ContactExternalRate>
	{

		public ContactExternalRate_ProjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContactExternalRate_ProjectEventsProcess

	public partial class ContactExternalRate_ProjectEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ContactExternalRateEventsProcessSchema

	/// <exclude/>
	public class ContactExternalRateEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ContactExternalRateEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ContactExternalRateEventsProcessSchema(ContactExternalRateEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ContactExternalRate_ProjectEventsProcess";
			UId = new Guid("301d34b3-efdd-476a-a586-c612c99ee75f");
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
			return new ContactExternalRateEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("301d34b3-efdd-476a-a586-c612c99ee75f"));
		}

		#endregion

	}

	#endregion


	#region Class: ContactExternalRateEventsProcess

	/// <exclude/>
	public class ContactExternalRateEventsProcess : ContactExternalRate_ProjectEventsProcess
	{

		public ContactExternalRateEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

