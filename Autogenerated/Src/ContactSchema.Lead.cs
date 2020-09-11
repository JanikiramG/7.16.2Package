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

	#region Class: Contact_Lead_TerrasoftSchema

	/// <exclude/>
	public class Contact_Lead_TerrasoftSchema : Terrasoft.Configuration.Contact_SSP_TerrasoftSchema
	{

		#region Constructors: Public

		public Contact_Lead_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Contact_Lead_TerrasoftSchema(Contact_Lead_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Contact_Lead_TerrasoftSchema(Contact_Lead_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("5b07e28c-394d-465a-87c0-1e303692c055");
			Name = "Contact_Lead_Terrasoft";
			ParentSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			ExtendParent = true;
			CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae");
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
			EventsProcessSchema = CreateContact_Lead_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateContact_Lead_TerrasoftEventsProcessSchema() {
			var schema = new Contact_Lead_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Contact_Lead_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Contact_LeadEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Contact_Lead_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Contact_Lead_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5b07e28c-394d-465a-87c0-1e303692c055"));
		}

		#endregion

	}

	#endregion

	#region Class: Contact_Lead_Terrasoft

	/// <summary>
	/// Contact.
	/// </summary>
	public class Contact_Lead_Terrasoft : Terrasoft.Configuration.Contact_SSP_Terrasoft
	{

		#region Constructors: Public

		public Contact_Lead_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contact_Lead_Terrasoft";
		}

		public Contact_Lead_Terrasoft(Contact_Lead_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Contact_LeadEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Contact_Lead_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Contact_Lead_TerrasoftDeleting", e);
			Inserting += (s, e) => ThrowEvent("Contact_Lead_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("Contact_Lead_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Contact_Lead_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Contact_LeadEventsProcess

	/// <exclude/>
	public partial class Contact_LeadEventsProcess<TEntity> : Terrasoft.Configuration.Contact_SSPEventsProcess<TEntity> where TEntity : Contact_Lead_Terrasoft
	{

		public Contact_LeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Contact_LeadEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5b07e28c-394d-465a-87c0-1e303692c055");
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

	#region Class: Contact_LeadEventsProcess

	/// <exclude/>
	public class Contact_LeadEventsProcess : Contact_LeadEventsProcess<Contact_Lead_Terrasoft>
	{

		public Contact_LeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Contact_LeadEventsProcess

	public partial class Contact_LeadEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: Contact_Lead_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Contact_Lead_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Contact_SSP_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Contact_Lead_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Contact_Lead_TerrasoftEventsProcessSchema(Contact_Lead_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Contact_LeadEventsProcess";
			UId = new Guid("0c5bf711-06c2-40c3-8e70-4fd2a53c953d");
			CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e");
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
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("73bbc987-2ab8-4ce5-b0ec-c0299d1e72fc"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c6864213-e7e8-465d-9b94-a5a82f858e94"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("b8cfc307-6cc7-46a0-adc5-c5052e6561f5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3ae3ffad-15b4-47e6-a1e7-da480e16ae8a"),
				Name = "Terrasoft.Core.ImageAPI",
				Alias = "",
				CreatedInPackageId = new Guid("b8cfc307-6cc7-46a0-adc5-c5052e6561f5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0017f56e-396d-4e72-a989-2c9800690b07"),
				Name = "Terrasoft.Messaging.Common",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("169a8f30-18f7-46d5-9a44-edcbb48f0929"),
				Name = "System.Runtime.Remoting",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6cb575e2-395e-47ee-968f-9e85ebbb0e57"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
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
				UId = new Guid("5410f06b-83f8-43fa-bc49-82a2dd508d3c"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Contact_Lead_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0c5bf711-06c2-40c3-8e70-4fd2a53c953d"));
		}

		#endregion

	}

	#endregion

}

