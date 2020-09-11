namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using System.Text;
	using System.Text.RegularExpressions;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration.RightsService;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Mail;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: ContractVisaSchema

	/// <exclude/>
	public class ContractVisaSchema : Terrasoft.Configuration.BaseVisaSchema
	{

		#region Constructors: Public

		public ContractVisaSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContractVisaSchema(ContractVisaSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContractVisaSchema(ContractVisaSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5");
			RealUId = new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5");
			Name = "ContractVisa";
			ParentSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66");
			ExtendParent = false;
			CreatedInPackageId = new Guid("26258d2f-5eb6-4391-98b9-20659e44f505");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("fe0dfac8-c69e-4744-b030-d6998935c904")) == null) {
				Columns.Add(CreateContractColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateContractColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fe0dfac8-c69e-4744-b030-d6998935c904"),
				Name = @"Contract",
				ReferenceSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5"),
				ModifiedInSchemaUId = new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5"),
				CreatedInPackageId = new Guid("26258d2f-5eb6-4391-98b9-20659e44f505")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateContractVisaEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateContractVisaEventsProcessSchema() {
			var schema = new ContractVisaEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ContractVisa(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContractVisa_CoreContractsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContractVisaSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContractVisaSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5"));
		}

		#endregion

	}

	#endregion

	#region Class: ContractVisa

	/// <summary>
	/// Contract approval.
	/// </summary>
	public class ContractVisa : Terrasoft.Configuration.BaseVisa
	{

		#region Constructors: Public

		public ContractVisa(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContractVisa";
		}

		public ContractVisa(ContractVisa source)
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
			var process = new ContractVisa_CoreContractsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserted += (s, e) => ThrowEvent("ContractVisaInserted", e);
			Inserting += (s, e) => ThrowEvent("ContractVisaInserting", e);
			Saved += (s, e) => ThrowEvent("ContractVisaSaved", e);
			Saving += (s, e) => ThrowEvent("ContractVisaSaving", e);
			Validating += (s, e) => ThrowEvent("ContractVisaValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContractVisa(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContractVisa_CoreContractsEventsProcess

	/// <exclude/>
	public partial class ContractVisa_CoreContractsEventsProcess<TEntity> : Terrasoft.Configuration.BaseVisa_NUIEventsProcess<TEntity> where TEntity : ContractVisa
	{

		public ContractVisa_CoreContractsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContractVisa_CoreContractsEventsProcess";
			SchemaUId = new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private LocalizableString _popupBodyTemplateWithoutDate;
		public LocalizableString PopupBodyTemplateWithoutDate {
			get {
				return _popupBodyTemplateWithoutDate ?? (_popupBodyTemplateWithoutDate = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.PopupBodyTemplateWithoutDate.Value"));
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

	#region Class: ContractVisa_CoreContractsEventsProcess

	/// <exclude/>
	public class ContractVisa_CoreContractsEventsProcess : ContractVisa_CoreContractsEventsProcess<ContractVisa>
	{

		public ContractVisa_CoreContractsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContractVisa_CoreContractsEventsProcess

	public partial class ContractVisa_CoreContractsEventsProcess<TEntity>
	{

		#region Methods: Public

		public override INotificationInfo GetNotificationInfo() {
			Entity.Contract.FetchFromDB(Entity.ContractId);
			var contract = Entity.Contract;
			var contractDateString = contract.StartDate == default(DateTime) 
				? string.Empty
				: contract.StartDate.ToString(PopupBodyDateFormat);
			var accountName = contract.AccountName;
			var contactName = contract.ContactName;
			var accountContactString = string.Join(", ", new[] {accountName, contactName}.Where(s => s.IsNotEmpty()));
			var body = contractDateString.IsNullOrEmpty()
				? string.Format(PopupBodyTemplateWithoutDate, contract.Number, accountContactString)
				: string.Format(PopupBodyTemplate, contract.Number, contractDateString, accountContactString);
			var notificationInfo = base.GetNotificationInfo();
			notificationInfo.EntityId = contract.Id;
			notificationInfo.Body = body;
			return notificationInfo;
		}

		#endregion

	}

	#endregion

	#region Class: ContractVisaEventsProcessSchema

	/// <exclude/>
	public class ContractVisaEventsProcessSchema : Terrasoft.Configuration.BaseVisaEventsProcessSchema
	{

		#region Constructors: Public

		public ContractVisaEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ContractVisaEventsProcessSchema(ContractVisaEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ContractVisa_CoreContractsEventsProcess";
			UId = new Guid("a1cbce3c-4238-401d-a808-7f6948bf50f9");
			CreatedInPackageId = new Guid("26258d2f-5eb6-4391-98b9-20659e44f505");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet2_7c76af6ce85840258f3cae7c7e936dfb = CreateLaneSet2_7c76af6ce85840258f3cae7c7e936dfbLaneSet();
			LaneSets.Add(schemaLaneSet2_7c76af6ce85840258f3cae7c7e936dfb);
			ProcessSchemaLane schemaLane3_7377570e070a41c48d99db1d4ada4a6f = CreateLane3_7377570e070a41c48d99db1d4ada4a6fLane();
			schemaLaneSet2_7c76af6ce85840258f3cae7c7e936dfb.Lanes.Add(schemaLane3_7377570e070a41c48d99db1d4ada4a6f);
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreatePopupBodyTemplateWithoutDateLocalizableString());
		}

		protected virtual SchemaLocalizableString CreatePopupBodyTemplateWithoutDateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("acc8af18-8da2-46cd-b986-d1fca2513ef3"),
				Name = "PopupBodyTemplateWithoutDate",
				CreatedInPackageId = new Guid("d07c15be-3f83-4fdc-a9ea-aad9ed069b01"),
				CreatedInSchemaUId = new Guid("a1cbce3c-4238-401d-a808-7f6948bf50f9"),
				ModifiedInSchemaUId = new Guid("a1cbce3c-4238-401d-a808-7f6948bf50f9")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_7c76af6ce85840258f3cae7c7e936dfbLaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_7c76af6ce85840258f3cae7c7e936dfb = new ProcessSchemaLaneSet(this) {
				UId = new Guid("7c76af6c-e858-4025-8f3c-ae7c7e936dfb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("d07c15be-3f83-4fdc-a9ea-aad9ed069b01"),
				CreatedInSchemaUId = new Guid("a1cbce3c-4238-401d-a808-7f6948bf50f9"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("a1cbce3c-4238-401d-a808-7f6948bf50f9"),
				Name = @"LaneSet2_7c76af6ce85840258f3cae7c7e936dfb",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_7c76af6ce85840258f3cae7c7e936dfb;
		}

		protected virtual ProcessSchemaLane CreateLane3_7377570e070a41c48d99db1d4ada4a6fLane() {
			ProcessSchemaLane schemaLane3_7377570e070a41c48d99db1d4ada4a6f = new ProcessSchemaLane(this) {
				UId = new Guid("7377570e-070a-41c4-8d99-db1d4ada4a6f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7c76af6c-e858-4025-8f3c-ae7c7e936dfb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("d07c15be-3f83-4fdc-a9ea-aad9ed069b01"),
				CreatedInSchemaUId = new Guid("a1cbce3c-4238-401d-a808-7f6948bf50f9"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a1cbce3c-4238-401d-a808-7f6948bf50f9"),
				Name = @"Lane3_7377570e070a41c48d99db1d4ada4a6f",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane3_7377570e070a41c48d99db1d4ada4a6f;
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
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b4ea420f-1747-4595-ab25-789126e98c6b"),
				Name = "Terrasoft.Mail",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b77beabe-3462-4019-89ec-c7f463df7906"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("995f3b91-8c49-4a3e-91e8-844a842e4cf2"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("370cbd11-d7ba-41e3-92a8-c2e20475dfbc"),
				Name = "Terrasoft.Configuration.RightsService",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("60de445f-ad8e-4e3f-9462-87883ee929ac"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("868a8008-4580-40bf-9a3e-88b0ed6fd0af"),
				Name = "System.Collections",
				Alias = "",
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fdad31d6-a4d0-48ab-ac06-588a5897466d"),
				Name = "System.Text.RegularExpressions",
				Alias = "",
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("af74f3ab-a423-4d68-94c0-9cf65b0acea5"),
				Name = "Terrasoft.Messaging.Common",
				Alias = "",
				CreatedInPackageId = new Guid("7f0d2206-b4d4-499c-aac2-6529fbb3d8c3")
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
				UId = new Guid("be94874c-996f-4f96-b0a8-7dfeaccae86f"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c261d1c9-cc98-44e8-aabd-7806d1dc26ec"),
				Name = "Terrasoft.Core.DcmProcess",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		protected override SchemaMethod CreateGetNotificationInfoMethod() {
			SchemaMethod method = base.CreateGetNotificationInfoMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,203,106,195,48,16,60,55,144,127,16,61,201,96,244,1,13,110,169,243,40,238,193,45,36,144,67,233,65,177,55,141,192,146,140,188,106,9,165,255,94,249,145,90,113,28,10,190,104,102,118,53,51,242,82,161,192,35,155,107,133,134,103,200,86,128,217,97,101,180,92,196,116,121,206,37,121,48,155,78,62,185,33,89,135,144,136,12,52,3,193,130,35,172,209,8,245,225,164,39,144,173,145,155,134,34,81,68,114,216,115,91,32,173,207,27,33,33,32,211,201,205,3,169,154,41,182,148,37,30,29,112,55,50,205,54,186,221,77,95,117,105,203,88,231,199,26,94,105,35,57,158,172,242,44,211,86,97,202,37,248,22,30,123,216,179,236,152,161,112,222,195,231,27,59,226,47,93,103,248,89,11,69,111,67,226,62,5,95,111,239,228,219,115,16,250,183,252,176,237,1,12,208,138,68,247,164,98,73,149,106,108,226,210,32,56,185,223,185,76,158,155,190,206,90,110,139,226,197,116,19,126,103,109,1,125,41,27,144,101,225,38,183,2,15,218,54,75,194,62,96,106,229,14,76,56,26,43,104,154,255,103,237,200,174,75,191,87,246,119,49,149,70,177,23,25,71,161,85,162,246,218,69,222,241,10,216,19,96,58,160,104,61,51,212,179,246,47,76,114,255,229,146,124,76,25,183,141,214,197,58,218,0,90,163,46,238,159,253,2,100,173,10,28,22,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContractVisaEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a1cbce3c-4238-401d-a808-7f6948bf50f9"));
		}

		#endregion

	}

	#endregion


	#region Class: ContractVisaEventsProcess

	/// <exclude/>
	public class ContractVisaEventsProcess : ContractVisa_CoreContractsEventsProcess
	{

		public ContractVisaEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

