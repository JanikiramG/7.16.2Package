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

	#region Class: UserAttributesSchema

	/// <exclude/>
	public class UserAttributesSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public UserAttributesSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UserAttributesSchema(UserAttributesSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UserAttributesSchema(UserAttributesSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8c843255-8f10-4737-a6f4-392762f6b682");
			RealUId = new Guid("8c843255-8f10-4737-a6f4-392762f6b682");
			Name = "UserAttributes";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f397f2af-3c2b-4e84-b720-c5ecf5003a68");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("caf44c9c-7c66-45a6-a760-238780b7f174")) == null) {
				Columns.Add(CreateBPMColumnColumn());
			}
			if (Columns.FindByUId(new Guid("5324c52a-6c90-4598-ad52-e1579600e340")) == null) {
				Columns.Add(CreateADColumnColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateBPMColumnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("caf44c9c-7c66-45a6-a760-238780b7f174"),
				Name = @"BPMColumn",
				CreatedInSchemaUId = new Guid("8c843255-8f10-4737-a6f4-392762f6b682"),
				ModifiedInSchemaUId = new Guid("8c843255-8f10-4737-a6f4-392762f6b682"),
				CreatedInPackageId = new Guid("f397f2af-3c2b-4e84-b720-c5ecf5003a68")
			};
		}

		protected virtual EntitySchemaColumn CreateADColumnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("5324c52a-6c90-4598-ad52-e1579600e340"),
				Name = @"ADColumn",
				CreatedInSchemaUId = new Guid("8c843255-8f10-4737-a6f4-392762f6b682"),
				ModifiedInSchemaUId = new Guid("8c843255-8f10-4737-a6f4-392762f6b682"),
				CreatedInPackageId = new Guid("f397f2af-3c2b-4e84-b720-c5ecf5003a68")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateUserAttributesEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateUserAttributesEventsProcessSchema() {
			var schema = new UserAttributesEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new UserAttributes(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UserAttributes_LDAPEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UserAttributesSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UserAttributesSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8c843255-8f10-4737-a6f4-392762f6b682"));
		}

		#endregion

	}

	#endregion

	#region Class: UserAttributes

	/// <summary>
	/// User attributes.
	/// </summary>
	public class UserAttributes : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public UserAttributes(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UserAttributes";
		}

		public UserAttributes(UserAttributes source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Creatio column.
		/// </summary>
		public string BPMColumn {
			get {
				return GetTypedColumnValue<string>("BPMColumn");
			}
			set {
				SetColumnValue("BPMColumn", value);
			}
		}

		/// <summary>
		/// Active Directory column.
		/// </summary>
		public string ADColumn {
			get {
				return GetTypedColumnValue<string>("ADColumn");
			}
			set {
				SetColumnValue("ADColumn", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UserAttributes_LDAPEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("UserAttributesDeleted", e);
			Validating += (s, e) => ThrowEvent("UserAttributesValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new UserAttributes(this);
		}

		#endregion

	}

	#endregion

	#region Class: UserAttributes_LDAPEventsProcess

	/// <exclude/>
	public partial class UserAttributes_LDAPEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : UserAttributes
	{

		public UserAttributes_LDAPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UserAttributes_LDAPEventsProcess";
			SchemaUId = new Guid("8c843255-8f10-4737-a6f4-392762f6b682");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8c843255-8f10-4737-a6f4-392762f6b682");
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

	#region Class: UserAttributes_LDAPEventsProcess

	/// <exclude/>
	public class UserAttributes_LDAPEventsProcess : UserAttributes_LDAPEventsProcess<UserAttributes>
	{

		public UserAttributes_LDAPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UserAttributes_LDAPEventsProcess

	public partial class UserAttributes_LDAPEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: UserAttributesEventsProcessSchema

	/// <exclude/>
	public class UserAttributesEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public UserAttributesEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public UserAttributesEventsProcessSchema(UserAttributesEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "UserAttributes_LDAPEventsProcess";
			UId = new Guid("ac0c05f9-4fd5-4c13-b5c8-4028e2e86d70");
			CreatedInPackageId = new Guid("f397f2af-3c2b-4e84-b720-c5ecf5003a68");
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
			return new UserAttributesEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ac0c05f9-4fd5-4c13-b5c8-4028e2e86d70"));
		}

		#endregion

	}

	#endregion


	#region Class: UserAttributesEventsProcess

	/// <exclude/>
	public class UserAttributesEventsProcess : UserAttributes_LDAPEventsProcess
	{

		public UserAttributesEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

