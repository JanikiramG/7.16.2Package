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

	#region Class: VwVisaSchema

	/// <exclude/>
	public class VwVisaSchema : Terrasoft.Configuration.BaseVisaSchema
	{

		#region Constructors: Public

		public VwVisaSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwVisaSchema(VwVisaSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwVisaSchema(VwVisaSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835");
			RealUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835");
			Name = "VwVisa";
			ParentSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateTitleColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a1efb5d2-50f1-440a-ad35-0ab5a8892a72")) == null) {
				Columns.Add(CreateVisaSchemaNameColumn());
			}
			if (Columns.FindByUId(new Guid("6835dd49-a180-4735-8b33-527842610bd2")) == null) {
				Columns.Add(CreateVisaObjectIdColumn());
			}
			if (Columns.FindByUId(new Guid("94fdf3b7-f403-42e2-8e07-f64175027223")) == null) {
				Columns.Add(CreateVisaSchemaTypeIdColumn());
			}
			if (Columns.FindByUId(new Guid("05e15d73-c1a8-4e0b-9164-91d78dd3e4d5")) == null) {
				Columns.Add(CreateVisaTypeNameColumn());
			}
			if (Columns.FindByUId(new Guid("5d865518-09a7-4e5e-8903-83f34255b02e")) == null) {
				Columns.Add(CreateVisaSchemaCaptionColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835");
			column.CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835");
			column.CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835");
			column.CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835");
			column.CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835");
			column.CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835");
			column.CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			return column;
		}

		protected override EntitySchemaColumn CreateObjectiveColumn() {
			EntitySchemaColumn column = base.CreateObjectiveColumn();
			column.ModifiedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835");
			column.CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			return column;
		}

		protected override EntitySchemaColumn CreateVisaOwnerColumn() {
			EntitySchemaColumn column = base.CreateVisaOwnerColumn();
			column.ModifiedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835");
			column.CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			return column;
		}

		protected override EntitySchemaColumn CreateIsAllowedToDelegateColumn() {
			EntitySchemaColumn column = base.CreateIsAllowedToDelegateColumn();
			column.ModifiedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835");
			column.CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			return column;
		}

		protected override EntitySchemaColumn CreateDelegatedFromColumn() {
			EntitySchemaColumn column = base.CreateDelegatedFromColumn();
			column.ModifiedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835");
			column.CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			return column;
		}

		protected override EntitySchemaColumn CreateStatusColumn() {
			EntitySchemaColumn column = base.CreateStatusColumn();
			column.ModifiedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835");
			column.CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			return column;
		}

		protected override EntitySchemaColumn CreateSetByColumn() {
			EntitySchemaColumn column = base.CreateSetByColumn();
			column.ModifiedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835");
			column.CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			return column;
		}

		protected override EntitySchemaColumn CreateSetDateColumn() {
			EntitySchemaColumn column = base.CreateSetDateColumn();
			column.ModifiedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835");
			column.CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			return column;
		}

		protected override EntitySchemaColumn CreateIsCanceledColumn() {
			EntitySchemaColumn column = base.CreateIsCanceledColumn();
			column.ModifiedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835");
			column.CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			return column;
		}

		protected override EntitySchemaColumn CreateCommentColumn() {
			EntitySchemaColumn column = base.CreateCommentColumn();
			column.ModifiedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835");
			column.CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			return column;
		}

		protected virtual EntitySchemaColumn CreateTitleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("10e1449d-8e66-412c-8fc2-eeaae319bc17"),
				Name = @"Title",
				CreatedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835"),
				ModifiedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835"),
				CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb")
			};
		}

		protected virtual EntitySchemaColumn CreateVisaSchemaNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("a1efb5d2-50f1-440a-ad35-0ab5a8892a72"),
				Name = @"VisaSchemaName",
				CreatedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835"),
				ModifiedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			};
		}

		protected virtual EntitySchemaColumn CreateVisaObjectIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("6835dd49-a180-4735-8b33-527842610bd2"),
				Name = @"VisaObjectId",
				CreatedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835"),
				ModifiedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835"),
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			};
		}

		protected virtual EntitySchemaColumn CreateVisaSchemaTypeIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("94fdf3b7-f403-42e2-8e07-f64175027223"),
				Name = @"VisaSchemaTypeId",
				CreatedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835"),
				ModifiedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835"),
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			};
		}

		protected virtual EntitySchemaColumn CreateVisaTypeNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("05e15d73-c1a8-4e0b-9164-91d78dd3e4d5"),
				Name = @"VisaTypeName",
				CreatedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835"),
				ModifiedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835"),
				CreatedInPackageId = new Guid("85a972d5-aaea-43a7-af9b-d75884bd785b")
			};
		}

		protected virtual EntitySchemaColumn CreateVisaSchemaCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("5d865518-09a7-4e5e-8903-83f34255b02e"),
				Name = @"VisaSchemaCaption",
				CreatedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835"),
				ModifiedInSchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835"),
				CreatedInPackageId = new Guid("85a972d5-aaea-43a7-af9b-d75884bd785b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwVisaEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwVisaEventsProcessSchema() {
			var schema = new VwVisaEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwVisa(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwVisa_NUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwVisaSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwVisaSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("38d05501-e527-4220-b74d-68d71a2aa835"));
		}

		#endregion

	}

	#endregion

	#region Class: VwVisa

	/// <summary>
	/// Approval (view).
	/// </summary>
	public class VwVisa : Terrasoft.Configuration.BaseVisa
	{

		#region Constructors: Public

		public VwVisa(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwVisa";
		}

		public VwVisa(VwVisa source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Title.
		/// </summary>
		public string Title {
			get {
				return GetTypedColumnValue<string>("Title");
			}
			set {
				SetColumnValue("Title", value);
			}
		}

		/// <summary>
		/// Schema name.
		/// </summary>
		public string VisaSchemaName {
			get {
				return GetTypedColumnValue<string>("VisaSchemaName");
			}
			set {
				SetColumnValue("VisaSchemaName", value);
			}
		}

		/// <summary>
		/// Approval object Id.
		/// </summary>
		public Guid VisaObjectId {
			get {
				return GetTypedColumnValue<Guid>("VisaObjectId");
			}
			set {
				SetColumnValue("VisaObjectId", value);
			}
		}

		/// <summary>
		/// Approval object type Id.
		/// </summary>
		public Guid VisaSchemaTypeId {
			get {
				return GetTypedColumnValue<Guid>("VisaSchemaTypeId");
			}
			set {
				SetColumnValue("VisaSchemaTypeId", value);
			}
		}

		/// <summary>
		/// Approval object type name.
		/// </summary>
		public string VisaTypeName {
			get {
				return GetTypedColumnValue<string>("VisaTypeName");
			}
			set {
				SetColumnValue("VisaTypeName", value);
			}
		}

		/// <summary>
		/// Schema name.
		/// </summary>
		public string VisaSchemaCaption {
			get {
				return GetTypedColumnValue<string>("VisaSchemaCaption");
			}
			set {
				SetColumnValue("VisaSchemaCaption", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwVisa_NUIEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserted += (s, e) => ThrowEvent("VwVisaInserted", e);
			Inserting += (s, e) => ThrowEvent("VwVisaInserting", e);
			Saved += (s, e) => ThrowEvent("VwVisaSaved", e);
			Saving += (s, e) => ThrowEvent("VwVisaSaving", e);
			Validating += (s, e) => ThrowEvent("VwVisaValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwVisa(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwVisa_NUIEventsProcess

	/// <exclude/>
	public partial class VwVisa_NUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseVisa_NUIEventsProcess<TEntity> where TEntity : VwVisa
	{

		public VwVisa_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwVisa_NUIEventsProcess";
			SchemaUId = new Guid("38d05501-e527-4220-b74d-68d71a2aa835");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("38d05501-e527-4220-b74d-68d71a2aa835");
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

	#region Class: VwVisa_NUIEventsProcess

	/// <exclude/>
	public class VwVisa_NUIEventsProcess : VwVisa_NUIEventsProcess<VwVisa>
	{

		public VwVisa_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwVisa_NUIEventsProcess

	public partial class VwVisa_NUIEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwVisaEventsProcessSchema

	/// <exclude/>
	public class VwVisaEventsProcessSchema : Terrasoft.Configuration.BaseVisaEventsProcessSchema
	{

		#region Constructors: Public

		public VwVisaEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwVisaEventsProcessSchema(VwVisaEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwVisa_NUIEventsProcess";
			UId = new Guid("f33b96f0-1287-4dcb-ac3d-40c51d49e123");
			CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
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
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb")
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

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwVisaEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f33b96f0-1287-4dcb-ac3d-40c51d49e123"));
		}

		#endregion

	}

	#endregion


	#region Class: VwVisaEventsProcess

	/// <exclude/>
	public class VwVisaEventsProcess : VwVisa_NUIEventsProcess
	{

		public VwVisaEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

