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

	#region Class: InvoiceVisaSchema

	/// <exclude/>
	public class InvoiceVisaSchema : Terrasoft.Configuration.BaseVisaSchema
	{

		#region Constructors: Public

		public InvoiceVisaSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public InvoiceVisaSchema(InvoiceVisaSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public InvoiceVisaSchema(InvoiceVisaSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ec034d19-5185-497d-9066-29f2973037f1");
			RealUId = new Guid("ec034d19-5185-497d-9066-29f2973037f1");
			Name = "InvoiceVisa";
			ParentSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66");
			ExtendParent = false;
			CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a77a54ba-d2b3-4ddb-b195-2c2d14a375b6")) == null) {
				Columns.Add(CreateInvoiceColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateInvoiceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a77a54ba-d2b3-4ddb-b195-2c2d14a375b6"),
				Name = @"Invoice",
				ReferenceSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("ec034d19-5185-497d-9066-29f2973037f1"),
				ModifiedInSchemaUId = new Guid("ec034d19-5185-497d-9066-29f2973037f1"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateInvoiceVisaEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateInvoiceVisaEventsProcessSchema() {
			var schema = new InvoiceVisaEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new InvoiceVisa(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new InvoiceVisa_InvoiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new InvoiceVisaSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new InvoiceVisaSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ec034d19-5185-497d-9066-29f2973037f1"));
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceVisa

	/// <summary>
	/// Invoice approval .
	/// </summary>
	public class InvoiceVisa : Terrasoft.Configuration.BaseVisa
	{

		#region Constructors: Public

		public InvoiceVisa(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "InvoiceVisa";
		}

		public InvoiceVisa(InvoiceVisa source)
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
			var process = new InvoiceVisa_InvoiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserted += (s, e) => ThrowEvent("InvoiceVisaInserted", e);
			Inserting += (s, e) => ThrowEvent("InvoiceVisaInserting", e);
			Saved += (s, e) => ThrowEvent("InvoiceVisaSaved", e);
			Saving += (s, e) => ThrowEvent("InvoiceVisaSaving", e);
			Validating += (s, e) => ThrowEvent("InvoiceVisaValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new InvoiceVisa(this);
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceVisa_InvoiceEventsProcess

	/// <exclude/>
	public partial class InvoiceVisa_InvoiceEventsProcess<TEntity> : Terrasoft.Configuration.BaseVisa_NUIEventsProcess<TEntity> where TEntity : InvoiceVisa
	{

		public InvoiceVisa_InvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "InvoiceVisa_InvoiceEventsProcess";
			SchemaUId = new Guid("ec034d19-5185-497d-9066-29f2973037f1");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ec034d19-5185-497d-9066-29f2973037f1");
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

	#region Class: InvoiceVisa_InvoiceEventsProcess

	/// <exclude/>
	public class InvoiceVisa_InvoiceEventsProcess : InvoiceVisa_InvoiceEventsProcess<InvoiceVisa>
	{

		public InvoiceVisa_InvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: InvoiceVisa_InvoiceEventsProcess

	public partial class InvoiceVisa_InvoiceEventsProcess<TEntity>
	{

		#region Methods: Public

		public override List<string> GetVisaTemplateSchemaQueryColumns() {
			List<string> columns = base.GetVisaTemplateSchemaQueryColumns();
			columns.AddRange( new string[] {
				"Invoice.Number",
				"Invoice.StartDate",
				"Invoice.Currency.ShortName",
				"Invoice.Amount",
				"Invoice.Owner.Name",
				"Invoice.Contact.Name",
				"Invoice.Account.Name"
			});
			return columns;
		}

		public override INotificationInfo GetNotificationInfo() {
			Entity.Invoice.FetchFromDB(Entity.InvoiceId);
			var invoice = Entity.Invoice;
			var invoiceDate = invoice.StartDate.ToString(PopupBodyDateFormat);
			var accountName = invoice.AccountName;
			var contactName = invoice.ContactName;
			var accountContactString = string.Join(", ", new[] {accountName, contactName}.Where(s => s.IsNotEmpty()));
			var body = string.Format(PopupBodyTemplate, invoice.Number, invoiceDate, accountContactString);
			var notificationInfo = base.GetNotificationInfo();
			notificationInfo.EntityId = invoice.Id;
			notificationInfo.Body = body;
			return notificationInfo;
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceVisaEventsProcessSchema

	/// <exclude/>
	public class InvoiceVisaEventsProcessSchema : Terrasoft.Configuration.BaseVisaEventsProcessSchema
	{

		#region Constructors: Public

		public InvoiceVisaEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public InvoiceVisaEventsProcessSchema(InvoiceVisaEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "InvoiceVisa_InvoiceEventsProcess";
			UId = new Guid("57a16a0c-a579-4550-82af-55422d483008");
			CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524");
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
			ProcessSchemaLaneSet schemaLaneSet2_a9eee6076a6547968d6d9037cd50ad75 = CreateLaneSet2_a9eee6076a6547968d6d9037cd50ad75LaneSet();
			LaneSets.Add(schemaLaneSet2_a9eee6076a6547968d6d9037cd50ad75);
			ProcessSchemaLane schemaLane3_fa7907a4f3694c9ab24d9b97ff796c28 = CreateLane3_fa7907a4f3694c9ab24d9b97ff796c28Lane();
			schemaLaneSet2_a9eee6076a6547968d6d9037cd50ad75.Lanes.Add(schemaLane3_fa7907a4f3694c9ab24d9b97ff796c28);
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_a9eee6076a6547968d6d9037cd50ad75LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_a9eee6076a6547968d6d9037cd50ad75 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("a9eee607-6a65-4796-8d6d-9037cd50ad75"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("0831ed7d-04c4-455d-af2c-3fdb5376a294"),
				CreatedInSchemaUId = new Guid("57a16a0c-a579-4550-82af-55422d483008"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("57a16a0c-a579-4550-82af-55422d483008"),
				Name = @"LaneSet2_a9eee6076a6547968d6d9037cd50ad75",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_a9eee6076a6547968d6d9037cd50ad75;
		}

		protected virtual ProcessSchemaLane CreateLane3_fa7907a4f3694c9ab24d9b97ff796c28Lane() {
			ProcessSchemaLane schemaLane3_fa7907a4f3694c9ab24d9b97ff796c28 = new ProcessSchemaLane(this) {
				UId = new Guid("fa7907a4-f369-4c9a-b24d-9b97ff796c28"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a9eee607-6a65-4796-8d6d-9037cd50ad75"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("0831ed7d-04c4-455d-af2c-3fdb5376a294"),
				CreatedInSchemaUId = new Guid("57a16a0c-a579-4550-82af-55422d483008"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("57a16a0c-a579-4550-82af-55422d483008"),
				Name = @"Lane3_fa7907a4f3694c9ab24d9b97ff796c28",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane3_fa7907a4f3694c9ab24d9b97ff796c28;
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

		protected override SchemaMethod CreateGetVisaTemplateSchemaQueryColumnsMethod() {
			SchemaMethod method = base.CreateGetVisaTemplateSchemaQueryColumnsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,203,10,194,48,16,69,215,22,250,15,161,171,10,146,31,240,1,165,130,8,162,104,197,141,184,136,233,80,11,102,34,147,137,165,136,255,174,165,10,86,221,222,115,239,129,153,69,233,120,228,152,74,44,38,66,219,179,55,232,196,88,28,149,3,57,3,222,149,78,109,193,92,206,138,33,211,39,48,106,237,129,234,180,45,198,253,97,24,188,70,50,201,243,141,194,2,98,129,80,137,86,185,63,136,91,24,244,162,57,94,109,169,65,46,189,57,2,69,131,207,44,99,69,60,125,250,187,113,234,137,0,117,45,179,147,37,94,42,243,197,19,99,61,114,55,91,85,8,36,127,187,169,69,86,154,255,144,68,235,70,211,146,48,184,55,7,17,176,39,124,63,99,248,0,144,118,58,197,34,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetNotificationInfoMethod() {
			SchemaMethod method = base.CreateGetNotificationInfoMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,81,77,75,196,48,16,189,11,254,135,224,41,133,146,63,176,172,96,221,86,226,161,8,187,224,65,60,164,105,118,55,96,102,74,58,93,41,226,127,55,181,173,253,112,33,135,228,189,55,243,230,77,82,32,75,173,144,112,65,171,141,200,12,233,115,230,209,237,18,158,46,40,89,70,155,219,155,139,242,204,246,0,219,178,165,98,73,239,20,117,146,225,37,246,164,60,117,152,56,224,158,188,133,19,127,193,170,169,18,44,219,14,206,208,59,69,163,133,210,26,27,160,92,185,121,143,135,9,29,116,26,129,148,94,235,30,39,116,217,111,32,122,255,80,80,255,94,196,51,90,224,119,49,11,7,204,231,219,59,251,154,249,199,115,147,111,241,122,54,222,240,154,109,239,89,45,100,157,35,165,174,162,150,71,209,56,123,17,18,77,189,251,92,83,214,131,113,213,71,200,27,255,77,155,55,174,48,62,158,239,45,190,58,240,104,0,72,246,104,181,34,139,32,225,136,193,172,80,181,17,79,134,242,21,197,187,154,181,94,244,223,38,203,217,202,100,121,77,152,244,81,186,68,129,246,134,26,15,255,236,55,63,125,172,130,237,67,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new InvoiceVisaEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("57a16a0c-a579-4550-82af-55422d483008"));
		}

		#endregion

	}

	#endregion


	#region Class: InvoiceVisaEventsProcess

	/// <exclude/>
	public class InvoiceVisaEventsProcess : InvoiceVisa_InvoiceEventsProcess
	{

		public InvoiceVisaEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

