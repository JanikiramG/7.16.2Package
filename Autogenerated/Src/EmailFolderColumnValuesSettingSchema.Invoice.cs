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

	#region Class: EmailFolderColumnValuesSetting_Invoice_TerrasoftSchema

	/// <exclude/>
	public class EmailFolderColumnValuesSetting_Invoice_TerrasoftSchema : Terrasoft.Configuration.EmailFolderColumnValuesSetting_Opportunity_TerrasoftSchema
	{

		#region Constructors: Public

		public EmailFolderColumnValuesSetting_Invoice_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EmailFolderColumnValuesSetting_Invoice_TerrasoftSchema(EmailFolderColumnValuesSetting_Invoice_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EmailFolderColumnValuesSetting_Invoice_TerrasoftSchema(EmailFolderColumnValuesSetting_Invoice_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("75a2d8b1-b9f5-4d66-a1a1-c16330027696");
			Name = "EmailFolderColumnValuesSetting_Invoice_Terrasoft";
			ParentSchemaUId = new Guid("77ffb765-d7ad-4f91-9027-92cdf97b4c1f");
			ExtendParent = true;
			CreatedInPackageId = new Guid("afbb269b-fc54-494c-b1eb-1fd3a323385c");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("f06bf4d6-d855-4a73-99f6-2f8ebd6d63f2")) == null) {
				Columns.Add(CreateInvoiceColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateInvoiceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f06bf4d6-d855-4a73-99f6-2f8ebd6d63f2"),
				Name = @"Invoice",
				ReferenceSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("75a2d8b1-b9f5-4d66-a1a1-c16330027696"),
				ModifiedInSchemaUId = new Guid("75a2d8b1-b9f5-4d66-a1a1-c16330027696"),
				CreatedInPackageId = new Guid("eceefca3-5a45-46fe-8b09-e72ef0cd9d7e")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateEmailFolderColumnValuesSetting_Invoice_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateEmailFolderColumnValuesSetting_Invoice_TerrasoftEventsProcessSchema() {
			var schema = new EmailFolderColumnValuesSetting_Invoice_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new EmailFolderColumnValuesSetting_Invoice_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EmailFolderColumnValuesSetting_InvoiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EmailFolderColumnValuesSetting_Invoice_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EmailFolderColumnValuesSetting_Invoice_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("75a2d8b1-b9f5-4d66-a1a1-c16330027696"));
		}

		#endregion

	}

	#endregion

	#region Class: EmailFolderColumnValuesSetting_Invoice_Terrasoft

	/// <summary>
	/// Setup of email folder field values.
	/// </summary>
	public class EmailFolderColumnValuesSetting_Invoice_Terrasoft : Terrasoft.Configuration.EmailFolderColumnValuesSetting_Opportunity_Terrasoft
	{

		#region Constructors: Public

		public EmailFolderColumnValuesSetting_Invoice_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EmailFolderColumnValuesSetting_Invoice_Terrasoft";
		}

		public EmailFolderColumnValuesSetting_Invoice_Terrasoft(EmailFolderColumnValuesSetting_Invoice_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid InvoiceId {
			get {
				return GetTypedColumnValue<Guid>("InvoiceId");
			}
			set {
				SetColumnValue("InvoiceId", value);
				_invoice = null;
			}
		}

		/// <exclude/>
		public string InvoiceNumber {
			get {
				return GetTypedColumnValue<string>("InvoiceNumber");
			}
			set {
				SetColumnValue("InvoiceNumber", value);
				if (_invoice != null) {
					_invoice.Number = value;
				}
			}
		}

		private Invoice _invoice;
		/// <summary>
		/// Invoice.
		/// </summary>
		public Invoice Invoice {
			get {
				return _invoice ??
					(_invoice = LookupColumnEntities.GetEntity("Invoice") as Invoice);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EmailFolderColumnValuesSetting_InvoiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("EmailFolderColumnValuesSetting_Invoice_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("EmailFolderColumnValuesSetting_Invoice_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("EmailFolderColumnValuesSetting_Invoice_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EmailFolderColumnValuesSetting_Invoice_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: EmailFolderColumnValuesSetting_InvoiceEventsProcess

	/// <exclude/>
	public partial class EmailFolderColumnValuesSetting_InvoiceEventsProcess<TEntity> : Terrasoft.Configuration.EmailFolderColumnValuesSetting_OpportunityEventsProcess<TEntity> where TEntity : EmailFolderColumnValuesSetting_Invoice_Terrasoft
	{

		public EmailFolderColumnValuesSetting_InvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EmailFolderColumnValuesSetting_InvoiceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("75a2d8b1-b9f5-4d66-a1a1-c16330027696");
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

	#region Class: EmailFolderColumnValuesSetting_InvoiceEventsProcess

	/// <exclude/>
	public class EmailFolderColumnValuesSetting_InvoiceEventsProcess : EmailFolderColumnValuesSetting_InvoiceEventsProcess<EmailFolderColumnValuesSetting_Invoice_Terrasoft>
	{

		public EmailFolderColumnValuesSetting_InvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EmailFolderColumnValuesSetting_InvoiceEventsProcess

	public partial class EmailFolderColumnValuesSetting_InvoiceEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: EmailFolderColumnValuesSetting_Invoice_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class EmailFolderColumnValuesSetting_Invoice_TerrasoftEventsProcessSchema : Terrasoft.Configuration.EmailFolderColumnValuesSetting_Opportunity_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public EmailFolderColumnValuesSetting_Invoice_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public EmailFolderColumnValuesSetting_Invoice_TerrasoftEventsProcessSchema(EmailFolderColumnValuesSetting_Invoice_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "EmailFolderColumnValuesSetting_InvoiceEventsProcess";
			UId = new Guid("4217149f-3fef-449e-9030-01e2e499c3f7");
			CreatedInPackageId = new Guid("eceefca3-5a45-46fe-8b09-e72ef0cd9d7e");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("d93b1958-9229-49a3-a69b-22996633b6b3");
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
				CreatedInPackageId = new Guid("eceefca3-5a45-46fe-8b09-e72ef0cd9d7e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("eceefca3-5a45-46fe-8b09-e72ef0cd9d7e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("eceefca3-5a45-46fe-8b09-e72ef0cd9d7e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("eceefca3-5a45-46fe-8b09-e72ef0cd9d7e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("eceefca3-5a45-46fe-8b09-e72ef0cd9d7e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("eceefca3-5a45-46fe-8b09-e72ef0cd9d7e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("eceefca3-5a45-46fe-8b09-e72ef0cd9d7e")
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
			return new EmailFolderColumnValuesSetting_Invoice_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4217149f-3fef-449e-9030-01e2e499c3f7"));
		}

		#endregion

	}

	#endregion

}

