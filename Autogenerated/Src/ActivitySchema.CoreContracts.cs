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
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Web;
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
	using Terrasoft.Core.Store;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Activity_CoreContracts_TerrasoftSchema

	/// <exclude/>
	public class Activity_CoreContracts_TerrasoftSchema : Terrasoft.Configuration.Activity_Invoice_TerrasoftSchema
	{

		#region Constructors: Public

		public Activity_CoreContracts_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Activity_CoreContracts_TerrasoftSchema(Activity_CoreContracts_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Activity_CoreContracts_TerrasoftSchema(Activity_CoreContracts_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("0980553d-2d8c-48cc-86cb-7c9dcf593ba4");
			Name = "Activity_CoreContracts_Terrasoft";
			ParentSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			ExtendParent = true;
			CreatedInPackageId = new Guid("35a1e95b-1cfe-4e66-8afa-90d42fa38092");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("8b9e6930-54d2-4533-ab94-865a0c5d7db7")) == null) {
				Columns.Add(CreateContractColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateContractColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8b9e6930-54d2-4533-ab94-865a0c5d7db7"),
				Name = @"Contract",
				ReferenceSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("0980553d-2d8c-48cc-86cb-7c9dcf593ba4"),
				ModifiedInSchemaUId = new Guid("0980553d-2d8c-48cc-86cb-7c9dcf593ba4"),
				CreatedInPackageId = new Guid("35a1e95b-1cfe-4e66-8afa-90d42fa38092")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateActivity_CoreContracts_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateActivity_CoreContracts_TerrasoftEventsProcessSchema() {
			var schema = new Activity_CoreContracts_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Activity_CoreContracts_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Activity_CoreContractsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Activity_CoreContracts_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Activity_CoreContracts_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0980553d-2d8c-48cc-86cb-7c9dcf593ba4"));
		}

		#endregion

	}

	#endregion

	#region Class: Activity_CoreContracts_Terrasoft

	/// <summary>
	/// Activity.
	/// </summary>
	public class Activity_CoreContracts_Terrasoft : Terrasoft.Configuration.Activity_Invoice_Terrasoft
	{

		#region Constructors: Public

		public Activity_CoreContracts_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Activity_CoreContracts_Terrasoft";
		}

		public Activity_CoreContracts_Terrasoft(Activity_CoreContracts_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ContractId {
			get {
				return GetTypedColumnValue<Guid>("ContractId");
			}
			set {
				SetColumnValue("ContractId", value);
				_contract = null;
			}
		}

		/// <exclude/>
		public string ContractNumber {
			get {
				return GetTypedColumnValue<string>("ContractNumber");
			}
			set {
				SetColumnValue("ContractNumber", value);
				if (_contract != null) {
					_contract.Number = value;
				}
			}
		}

		private Contract _contract;
		/// <summary>
		/// Contract.
		/// </summary>
		public Contract Contract {
			get {
				return _contract ??
					(_contract = LookupColumnEntities.GetEntity("Contract") as Contract);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Activity_CoreContractsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Activity_CoreContracts_TerrasoftDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Activity_CoreContracts_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Activity_CoreContractsEventsProcess

	/// <exclude/>
	public partial class Activity_CoreContractsEventsProcess<TEntity> : Terrasoft.Configuration.Activity_InvoiceEventsProcess<TEntity> where TEntity : Activity_CoreContracts_Terrasoft
	{

		public Activity_CoreContractsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Activity_CoreContractsEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0980553d-2d8c-48cc-86cb-7c9dcf593ba4");
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

	#region Class: Activity_CoreContractsEventsProcess

	/// <exclude/>
	public class Activity_CoreContractsEventsProcess : Activity_CoreContractsEventsProcess<Activity_CoreContracts_Terrasoft>
	{

		public Activity_CoreContractsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Activity_CoreContractsEventsProcess

	public partial class Activity_CoreContractsEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void PrepereSynchronizeSubjectRemindingUserTask(SynchronizeSubjectRemindingUserTask userTask, Guid contact, DateTime remindTime, bool active, Guid source) {
			base.PrepereSynchronizeSubjectRemindingUserTask(userTask, contact, remindTime, active, source);
			bool isFeatureEnabled = FeatureUtilities.GetIsFeatureEnabled(UserConnection, "NotificationV2");
			if (isFeatureEnabled && active) {
				IRemindingTextFormer textFormer = ClassFactory.Get<ActivityRemindingTextFormer>(
					new ConstructorArgument("userConnection", UserConnection));
				string accountName = GetLookupDisplayColumnValue(Entity, "Account");
				string contactName = GetLookupDisplayColumnValue(Entity, "Contact");
				string title = Entity.GetTypedColumnValue<string>("Title");
				userTask.SubjectCaption = textFormer.GetBody(new Dictionary<string, object> {
					{"AccountName", accountName},
					{"ContactName", contactName},
					{"Title", title}
				});
				userTask.PopupTitle = textFormer.GetTitle(new Dictionary<string, object>());
			}
		}

		#endregion

	}

	#endregion

	#region Class: Activity_CoreContracts_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Activity_CoreContracts_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Activity_Invoice_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Activity_CoreContracts_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Activity_CoreContracts_TerrasoftEventsProcessSchema(Activity_CoreContracts_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Activity_CoreContractsEventsProcess";
			UId = new Guid("d11c9e3d-84c2-4deb-9d2a-2be14431afea");
			CreatedInPackageId = new Guid("35a1e95b-1cfe-4e66-8afa-90d42fa38092");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797");
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

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f83cbea2-10c5-4739-96f1-116937efce77"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("19024591-23ea-4b03-9800-93149198129b"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
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
				UId = new Guid("ca241c6a-6bd2-4e33-ae26-164063bfb504"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ed374225-e41d-4643-8234-a4c89997d648"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("9b2ffa7b-51c7-46d9-b749-4bade78db945")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("49a41b26-e223-4e0d-a40a-f81877cefa7a"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c8f03a62-627b-4c3c-a7a8-dca7a5be0e70"),
				Name = "System.Text.RegularExpressions",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8141ed71-f702-4246-8bcd-71fef757fdc4"),
				Name = "System.Web",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		protected override SchemaMethod CreatePrepereSynchronizeSubjectRemindingUserTaskMethod() {
			SchemaMethod method = base.CreatePrepereSynchronizeSubjectRemindingUserTaskMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,95,79,194,48,20,197,159,183,79,209,236,129,148,164,225,193,87,129,4,7,24,18,67,136,12,223,203,118,193,202,214,187,244,143,58,9,223,221,118,27,50,212,196,248,180,238,246,158,211,223,185,237,150,107,24,172,20,148,160,96,93,201,244,89,161,20,31,176,182,219,23,72,205,35,20,66,102,66,238,55,26,84,194,245,129,218,118,193,72,138,210,240,212,48,162,234,166,68,20,192,136,43,136,87,247,213,104,85,10,253,219,112,139,152,19,161,231,192,141,85,48,147,124,155,67,70,70,164,45,108,140,200,133,17,160,7,247,96,22,223,218,168,63,53,70,41,29,137,64,201,72,180,68,35,118,34,229,254,247,233,38,114,254,98,71,232,15,251,94,175,5,233,147,99,24,44,190,82,36,240,110,230,168,10,80,196,92,150,35,18,231,92,235,185,147,160,170,60,200,112,226,213,194,84,191,40,199,52,12,2,9,111,196,129,105,163,172,23,77,212,222,22,32,13,141,236,21,113,196,200,117,132,190,35,14,156,202,57,58,194,20,173,52,75,94,128,67,112,167,62,32,30,108,57,21,186,204,121,21,99,110,11,249,196,115,11,116,38,141,99,113,241,39,141,36,234,184,180,183,240,31,151,184,145,116,93,220,78,238,245,77,143,31,65,82,149,144,117,228,195,166,115,76,163,196,247,214,226,243,91,24,180,175,37,230,165,15,233,124,46,211,245,94,119,152,85,212,143,108,42,234,41,112,85,181,118,140,96,173,28,251,123,10,142,231,128,62,77,196,186,19,58,177,122,63,190,164,141,88,55,123,187,223,176,177,38,207,41,12,78,87,152,43,44,109,153,180,81,175,17,235,234,31,140,212,223,222,233,19,120,187,20,90,49,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Activity_CoreContracts_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d11c9e3d-84c2-4deb-9d2a-2be14431afea"));
		}

		#endregion

	}

	#endregion

}

