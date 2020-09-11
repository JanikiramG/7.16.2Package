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

	#region Class: SupplyPaymentTemplateItem_Passport_TerrasoftSchema

	/// <exclude/>
	public class SupplyPaymentTemplateItem_Passport_TerrasoftSchema : Terrasoft.Configuration.SupplyPaymentSchema
	{

		#region Constructors: Public

		public SupplyPaymentTemplateItem_Passport_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SupplyPaymentTemplateItem_Passport_TerrasoftSchema(SupplyPaymentTemplateItem_Passport_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SupplyPaymentTemplateItem_Passport_TerrasoftSchema(SupplyPaymentTemplateItem_Passport_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d");
			RealUId = new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d");
			Name = "SupplyPaymentTemplateItem_Passport_Terrasoft";
			ParentSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			ExtendParent = false;
			CreatedInPackageId = new Guid("95c2c84b-bfbc-40cb-9e93-5fad29a6591d");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
			DesignLocalizationSchemaName = @"SysSupplyPaymTemplItemLcz";
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a475fc53-6351-463d-955a-da01d88603a1")) == null) {
				Columns.Add(CreatePreviousElementColumn());
			}
			if (Columns.FindByUId(new Guid("3952ea59-baa1-477e-accf-77267f1ba3c2")) == null) {
				Columns.Add(CreateSupplyPaymentTemplateColumn());
			}
		}

		protected override EntitySchemaColumn CreateDelayTypeColumn() {
			EntitySchemaColumn column = base.CreateDelayTypeColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"b664126f-211f-44a1-acd8-6d9d8a1601c7"
			};
			column.ModifiedInSchemaUId = new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("874f79e7-3065-426d-af73-7db36c904b2f"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d"),
				ModifiedInSchemaUId = new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d"),
				CreatedInPackageId = new Guid("95c2c84b-bfbc-40cb-9e93-5fad29a6591d"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreatePreviousElementColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a475fc53-6351-463d-955a-da01d88603a1"),
				Name = @"PreviousElement",
				ReferenceSchemaUId = new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d"),
				ModifiedInSchemaUId = new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d"),
				CreatedInPackageId = new Guid("95c2c84b-bfbc-40cb-9e93-5fad29a6591d")
			};
		}

		protected virtual EntitySchemaColumn CreateSupplyPaymentTemplateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3952ea59-baa1-477e-accf-77267f1ba3c2"),
				Name = @"SupplyPaymentTemplate",
				ReferenceSchemaUId = new Guid("69262e8a-b4fc-4a03-bab9-5720e19291ef"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d"),
				ModifiedInSchemaUId = new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d"),
				CreatedInPackageId = new Guid("95c2c84b-bfbc-40cb-9e93-5fad29a6591d")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSupplyPaymentTemplateItem_Passport_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSupplyPaymentTemplateItem_Passport_TerrasoftEventsProcessSchema() {
			var schema = new SupplyPaymentTemplateItem_Passport_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SupplyPaymentTemplateItem_Passport_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SupplyPaymentTemplateItem_PassportEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SupplyPaymentTemplateItem_Passport_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SupplyPaymentTemplateItem_Passport_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d"));
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentTemplateItem_Passport_Terrasoft

	/// <summary>
	/// Installment plan template item.
	/// </summary>
	public class SupplyPaymentTemplateItem_Passport_Terrasoft : Terrasoft.Configuration.SupplyPayment
	{

		#region Constructors: Public

		public SupplyPaymentTemplateItem_Passport_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SupplyPaymentTemplateItem_Passport_Terrasoft";
		}

		public SupplyPaymentTemplateItem_Passport_Terrasoft(SupplyPaymentTemplateItem_Passport_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <exclude/>
		public Guid PreviousElementId {
			get {
				return GetTypedColumnValue<Guid>("PreviousElementId");
			}
			set {
				SetColumnValue("PreviousElementId", value);
				_previousElement = null;
			}
		}

		/// <exclude/>
		public string PreviousElementName {
			get {
				return GetTypedColumnValue<string>("PreviousElementName");
			}
			set {
				SetColumnValue("PreviousElementName", value);
				if (_previousElement != null) {
					_previousElement.Name = value;
				}
			}
		}

		private SupplyPaymentTemplateItem _previousElement;
		/// <summary>
		/// Previous entry.
		/// </summary>
		public SupplyPaymentTemplateItem PreviousElement {
			get {
				return _previousElement ??
					(_previousElement = LookupColumnEntities.GetEntity("PreviousElement") as SupplyPaymentTemplateItem);
			}
		}

		/// <exclude/>
		public Guid SupplyPaymentTemplateId {
			get {
				return GetTypedColumnValue<Guid>("SupplyPaymentTemplateId");
			}
			set {
				SetColumnValue("SupplyPaymentTemplateId", value);
				_supplyPaymentTemplate = null;
			}
		}

		/// <exclude/>
		public string SupplyPaymentTemplateName {
			get {
				return GetTypedColumnValue<string>("SupplyPaymentTemplateName");
			}
			set {
				SetColumnValue("SupplyPaymentTemplateName", value);
				if (_supplyPaymentTemplate != null) {
					_supplyPaymentTemplate.Name = value;
				}
			}
		}

		private SupplyPaymentTemplate _supplyPaymentTemplate;
		/// <summary>
		/// Installment plan template.
		/// </summary>
		public SupplyPaymentTemplate SupplyPaymentTemplate {
			get {
				return _supplyPaymentTemplate ??
					(_supplyPaymentTemplate = LookupColumnEntities.GetEntity("SupplyPaymentTemplate") as SupplyPaymentTemplate);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SupplyPaymentTemplateItem_PassportEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SupplyPaymentTemplateItem_Passport_TerrasoftDeleted", e);
			Saving += (s, e) => ThrowEvent("SupplyPaymentTemplateItem_Passport_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("SupplyPaymentTemplateItem_Passport_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SupplyPaymentTemplateItem_Passport_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentTemplateItem_PassportEventsProcess

	/// <exclude/>
	public partial class SupplyPaymentTemplateItem_PassportEventsProcess<TEntity> : Terrasoft.Configuration.SupplyPayment_PassportEventsProcess<TEntity> where TEntity : SupplyPaymentTemplateItem_Passport_Terrasoft
	{

		public SupplyPaymentTemplateItem_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SupplyPaymentTemplateItem_PassportEventsProcess";
			SchemaUId = new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d");
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

	#region Class: SupplyPaymentTemplateItem_PassportEventsProcess

	/// <exclude/>
	public class SupplyPaymentTemplateItem_PassportEventsProcess : SupplyPaymentTemplateItem_PassportEventsProcess<SupplyPaymentTemplateItem_Passport_Terrasoft>
	{

		public SupplyPaymentTemplateItem_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SupplyPaymentTemplateItem_PassportEventsProcess

	public partial class SupplyPaymentTemplateItem_PassportEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentTemplateItem_Passport_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class SupplyPaymentTemplateItem_Passport_TerrasoftEventsProcessSchema : Terrasoft.Configuration.SupplyPaymentEventsProcessSchema
	{

		#region Constructors: Public

		public SupplyPaymentTemplateItem_Passport_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SupplyPaymentTemplateItem_Passport_TerrasoftEventsProcessSchema(SupplyPaymentTemplateItem_Passport_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SupplyPaymentTemplateItem_PassportEventsProcess";
			UId = new Guid("65bc58e5-9c20-4362-8565-924c8ca72b1a");
			CreatedInPackageId = new Guid("95c2c84b-bfbc-40cb-9e93-5fad29a6591d");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f");
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
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1ac96112-fb04-4624-88a4-cfff3402c464"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a")
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
			return new SupplyPaymentTemplateItem_Passport_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("65bc58e5-9c20-4362-8565-924c8ca72b1a"));
		}

		#endregion

	}

	#endregion

}

