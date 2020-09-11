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
	using System.Runtime.Remoting;
	using SystemSettings = Terrasoft.Core.Configuration.SysSettings;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.EntitySynchronization;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.ImageAPI;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: ContactSchema

	/// <exclude/>
	public class ContactSchema : Terrasoft.Configuration.Contact_Lead_TerrasoftSchema
	{

		#region Constructors: Public

		public ContactSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactSchema(ContactSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactSchema(ContactSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("5426b243-3e54-41e2-9db1-818dfe27d291");
			Name = "Contact";
			ParentSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			ExtendParent = true;
			CreatedInPackageId = new Guid("6ee8d7b1-3226-4f2d-bb21-2207f8a78f18");
			IsDBView = false;
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
			EventsProcessSchema = CreateContactEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateContactEventsProcessSchema() {
			var schema = new ContactEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Contact(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Contact_SalesEnterpriseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5426b243-3e54-41e2-9db1-818dfe27d291"));
		}

		#endregion

	}

	#endregion

	#region Class: Contact

	/// <summary>
	/// Contact.
	/// </summary>
	public class Contact : Terrasoft.Configuration.Contact_Lead_Terrasoft
	{

		#region Constructors: Public

		public Contact(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contact";
		}

		public Contact(Contact source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Contact_SalesEnterpriseEventsProcess(UserConnection);
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
			return new Contact(this);
		}

		#endregion

	}

	#endregion

	#region Class: Contact_SalesEnterpriseEventsProcess

	/// <exclude/>
	public partial class Contact_SalesEnterpriseEventsProcess<TEntity> : Terrasoft.Configuration.Contact_LeadEventsProcess<TEntity> where TEntity : Contact
	{

		public Contact_SalesEnterpriseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Contact_SalesEnterpriseEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5426b243-3e54-41e2-9db1-818dfe27d291");
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

	#region Class: Contact_SalesEnterpriseEventsProcess

	/// <exclude/>
	public class Contact_SalesEnterpriseEventsProcess : Contact_SalesEnterpriseEventsProcess<Contact>
	{

		public Contact_SalesEnterpriseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Contact_SalesEnterpriseEventsProcess

	public partial class Contact_SalesEnterpriseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ContactEventsProcessSchema

	/// <exclude/>
	public class ContactEventsProcessSchema : Terrasoft.Configuration.Contact_Lead_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public ContactEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ContactEventsProcessSchema(ContactEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Contact_SalesEnterpriseEventsProcess";
			UId = new Guid("4b2be6a3-7a9e-464a-a34a-3c203c7b398a");
			CreatedInPackageId = new Guid("6ee8d7b1-3226-4f2d-bb21-2207f8a78f18");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("dd144634-5c4a-4630-949a-5a6f3829049a");
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
				CreatedInPackageId = new Guid("6ee8d7b1-3226-4f2d-bb21-2207f8a78f18")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("6ee8d7b1-3226-4f2d-bb21-2207f8a78f18")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("6ee8d7b1-3226-4f2d-bb21-2207f8a78f18")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("6ee8d7b1-3226-4f2d-bb21-2207f8a78f18")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("6ee8d7b1-3226-4f2d-bb21-2207f8a78f18")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("6ee8d7b1-3226-4f2d-bb21-2207f8a78f18")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("6ee8d7b1-3226-4f2d-bb21-2207f8a78f18")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("73bbc987-2ab8-4ce5-b0ec-c0299d1e72fc"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("6ee8d7b1-3226-4f2d-bb21-2207f8a78f18")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c6864213-e7e8-465d-9b94-a5a82f858e94"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("6ee8d7b1-3226-4f2d-bb21-2207f8a78f18")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3ae3ffad-15b4-47e6-a1e7-da480e16ae8a"),
				Name = "Terrasoft.Core.ImageAPI",
				Alias = "",
				CreatedInPackageId = new Guid("6ee8d7b1-3226-4f2d-bb21-2207f8a78f18")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0017f56e-396d-4e72-a989-2c9800690b07"),
				Name = "Terrasoft.Messaging.Common",
				Alias = "",
				CreatedInPackageId = new Guid("6ee8d7b1-3226-4f2d-bb21-2207f8a78f18")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("169a8f30-18f7-46d5-9a44-edcbb48f0929"),
				Name = "System.Runtime.Remoting",
				Alias = "",
				CreatedInPackageId = new Guid("6ee8d7b1-3226-4f2d-bb21-2207f8a78f18")
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
				UId = new Guid("03538de8-86d4-4eea-8c1d-8051bbb379ed"),
				Name = "Terrasoft.Configuration.EntitySynchronization",
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
				UId = new Guid("baa69609-d62f-4726-b4b5-736f7fd1042f"),
				Name = "Terrasoft.Core.Configuration.SysSettings",
				Alias = "SystemSettings",
				CreatedInPackageId = new Guid("f767c979-312c-4d92-9d28-97b2835309c5")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4b2be6a3-7a9e-464a-a34a-3c203c7b398a"));
		}

		#endregion

	}

	#endregion


	#region Class: ContactEventsProcess

	/// <exclude/>
	public class ContactEventsProcess : Contact_SalesEnterpriseEventsProcess
	{

		public ContactEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

