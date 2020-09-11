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

	#region Class: UsrTreatmentprogramsSchema

	/// <exclude/>
	public class UsrTreatmentprogramsSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public UsrTreatmentprogramsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrTreatmentprogramsSchema(UsrTreatmentprogramsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrTreatmentprogramsSchema(UsrTreatmentprogramsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a");
			RealUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a");
			Name = "UsrTreatmentprograms";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("6b7558a3-7144-4658-a45d-bb760f4e7e93");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateUsrNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("73bdbd8d-3628-42ba-898f-19f1acbb345b")) == null) {
				Columns.Add(CreateUsrNotesColumn());
			}
			if (Columns.FindByUId(new Guid("aaee7678-d9e3-4c98-9b71-7c48eaf04d99")) == null) {
				Columns.Add(CreateUsrTitleColumn());
			}
			if (Columns.FindByUId(new Guid("02664d17-318f-4345-89bc-4a90c35f2bd1")) == null) {
				Columns.Add(CreateUsrCodeColumn());
			}
			if (Columns.FindByUId(new Guid("58bda777-87ec-43ac-beda-0090e3bbc4b3")) == null) {
				Columns.Add(CreateUsrTreatmentprogramfrequencyColumn());
			}
			if (Columns.FindByUId(new Guid("cfcb9d33-bec4-428a-8d81-c40792706a1b")) == null) {
				Columns.Add(CreateUsrOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("e91f76e8-fc60-4af8-8c41-45eed8aba54a")) == null) {
				Columns.Add(CreateUsrNotes1Column());
			}
			if (Columns.FindByUId(new Guid("9b585042-d312-4cc0-82be-c09f7a946dee")) == null) {
				Columns.Add(CreateUsrIsActiveColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a");
			return column;
		}

		protected virtual EntitySchemaColumn CreateUsrNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Text")) {
				UId = new Guid("db398df7-5bb9-4ded-9e3a-c88ce84ea014"),
				Name = @"UsrName",
				CreatedInSchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a"),
				ModifiedInSchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a"),
				CreatedInPackageId = new Guid("6b7558a3-7144-4658-a45d-bb760f4e7e93")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("73bdbd8d-3628-42ba-898f-19f1acbb345b"),
				Name = @"UsrNotes",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a"),
				ModifiedInSchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a"),
				CreatedInPackageId = new Guid("6b7558a3-7144-4658-a45d-bb760f4e7e93")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrTitleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Text")) {
				UId = new Guid("aaee7678-d9e3-4c98-9b71-7c48eaf04d99"),
				Name = @"UsrTitle",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a"),
				ModifiedInSchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a"),
				CreatedInPackageId = new Guid("6b7558a3-7144-4658-a45d-bb760f4e7e93")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Text")) {
				UId = new Guid("02664d17-318f-4345-89bc-4a90c35f2bd1"),
				Name = @"UsrCode",
				CreatedInSchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a"),
				ModifiedInSchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a"),
				CreatedInPackageId = new Guid("6b7558a3-7144-4658-a45d-bb760f4e7e93")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrTreatmentprogramfrequencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("58bda777-87ec-43ac-beda-0090e3bbc4b3"),
				Name = @"UsrTreatmentprogramfrequency",
				ReferenceSchemaUId = new Guid("a65aed75-d6c4-43b5-9b0c-bcf1a00ec0eb"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a"),
				ModifiedInSchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a"),
				CreatedInPackageId = new Guid("6b7558a3-7144-4658-a45d-bb760f4e7e93")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("cfcb9d33-bec4-428a-8d81-c40792706a1b"),
				Name = @"UsrOwner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a"),
				ModifiedInSchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a"),
				CreatedInPackageId = new Guid("6b7558a3-7144-4658-a45d-bb760f4e7e93")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrNotes1Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Text")) {
				UId = new Guid("e91f76e8-fc60-4af8-8c41-45eed8aba54a"),
				Name = @"UsrNotes1",
				CreatedInSchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a"),
				ModifiedInSchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a"),
				CreatedInPackageId = new Guid("6b7558a3-7144-4658-a45d-bb760f4e7e93")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrIsActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("9b585042-d312-4cc0-82be-c09f7a946dee"),
				Name = @"UsrIsActive",
				CreatedInSchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a"),
				ModifiedInSchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a"),
				CreatedInPackageId = new Guid("6b7558a3-7144-4658-a45d-bb760f4e7e93")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateUsrTreatmentprogramsEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateUsrTreatmentprogramsEventsProcessSchema() {
			var schema = new UsrTreatmentprogramsEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new UsrTreatmentprograms(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrTreatmentprograms_CertificationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrTreatmentprogramsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrTreatmentprogramsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrTreatmentprograms

	/// <summary>
	/// Treatment programs.
	/// </summary>
	public class UsrTreatmentprograms : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public UsrTreatmentprograms(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrTreatmentprograms";
		}

		public UsrTreatmentprograms(UsrTreatmentprograms source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public string UsrName {
			get {
				return GetTypedColumnValue<string>("UsrName");
			}
			set {
				SetColumnValue("UsrName", value);
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string UsrNotes {
			get {
				return GetTypedColumnValue<string>("UsrNotes");
			}
			set {
				SetColumnValue("UsrNotes", value);
			}
		}

		/// <summary>
		/// Title.
		/// </summary>
		public string UsrTitle {
			get {
				return GetTypedColumnValue<string>("UsrTitle");
			}
			set {
				SetColumnValue("UsrTitle", value);
			}
		}

		/// <summary>
		/// Code.
		/// </summary>
		public string UsrCode {
			get {
				return GetTypedColumnValue<string>("UsrCode");
			}
			set {
				SetColumnValue("UsrCode", value);
			}
		}

		/// <exclude/>
		public Guid UsrTreatmentprogramfrequencyId {
			get {
				return GetTypedColumnValue<Guid>("UsrTreatmentprogramfrequencyId");
			}
			set {
				SetColumnValue("UsrTreatmentprogramfrequencyId", value);
				_usrTreatmentprogramfrequency = null;
			}
		}

		/// <exclude/>
		public string UsrTreatmentprogramfrequencyName {
			get {
				return GetTypedColumnValue<string>("UsrTreatmentprogramfrequencyName");
			}
			set {
				SetColumnValue("UsrTreatmentprogramfrequencyName", value);
				if (_usrTreatmentprogramfrequency != null) {
					_usrTreatmentprogramfrequency.Name = value;
				}
			}
		}

		private UsrTreatmentprogramfrequency _usrTreatmentprogramfrequency;
		/// <summary>
		/// Treatment program frequency.
		/// </summary>
		public UsrTreatmentprogramfrequency UsrTreatmentprogramfrequency {
			get {
				return _usrTreatmentprogramfrequency ??
					(_usrTreatmentprogramfrequency = LookupColumnEntities.GetEntity("UsrTreatmentprogramfrequency") as UsrTreatmentprogramfrequency);
			}
		}

		/// <exclude/>
		public Guid UsrOwnerId {
			get {
				return GetTypedColumnValue<Guid>("UsrOwnerId");
			}
			set {
				SetColumnValue("UsrOwnerId", value);
				_usrOwner = null;
			}
		}

		/// <exclude/>
		public string UsrOwnerName {
			get {
				return GetTypedColumnValue<string>("UsrOwnerName");
			}
			set {
				SetColumnValue("UsrOwnerName", value);
				if (_usrOwner != null) {
					_usrOwner.Name = value;
				}
			}
		}

		private Contact _usrOwner;
		/// <summary>
		/// Owner.
		/// </summary>
		public Contact UsrOwner {
			get {
				return _usrOwner ??
					(_usrOwner = LookupColumnEntities.GetEntity("UsrOwner") as Contact);
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string UsrNotes1 {
			get {
				return GetTypedColumnValue<string>("UsrNotes1");
			}
			set {
				SetColumnValue("UsrNotes1", value);
			}
		}

		/// <summary>
		/// Active.
		/// </summary>
		public bool UsrIsActive {
			get {
				return GetTypedColumnValue<bool>("UsrIsActive");
			}
			set {
				SetColumnValue("UsrIsActive", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UsrTreatmentprograms_CertificationEventsProcess(UserConnection);
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
			return new UsrTreatmentprograms(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrTreatmentprograms_CertificationEventsProcess

	/// <exclude/>
	public partial class UsrTreatmentprograms_CertificationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : UsrTreatmentprograms
	{

		public UsrTreatmentprograms_CertificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrTreatmentprograms_CertificationEventsProcess";
			SchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a");
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

	#region Class: UsrTreatmentprograms_CertificationEventsProcess

	/// <exclude/>
	public class UsrTreatmentprograms_CertificationEventsProcess : UsrTreatmentprograms_CertificationEventsProcess<UsrTreatmentprograms>
	{

		public UsrTreatmentprograms_CertificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrTreatmentprograms_CertificationEventsProcess

	public partial class UsrTreatmentprograms_CertificationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: UsrTreatmentprogramsEventsProcessSchema

	/// <exclude/>
	public class UsrTreatmentprogramsEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public UsrTreatmentprogramsEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public UsrTreatmentprogramsEventsProcessSchema(UsrTreatmentprogramsEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "UsrTreatmentprograms_CertificationEventsProcess";
			UId = new Guid("af33dc10-5d16-488b-9fa9-efe0e7cde1df");
			CreatedInPackageId = new Guid("6b7558a3-7144-4658-a45d-bb760f4e7e93");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.16.2.1600";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override ProcessSchemaParameter CreateNextProcessElementReadyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d9e67329-fde2-4fbd-aa49-2d69ca3d2b5b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"NextProcessElementReady",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override ProcessSchemaParameter CreateIsProcessModeSaveParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4cb16350-d39b-4247-9da5-33032cf8667d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"IsProcessModeSave",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override ProcessSchemaParameter CreateCanUseDcmParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d185837a-b568-43f2-a09a-28512af1957a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"CanUseDcm",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
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
			return new UsrTreatmentprogramsEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("af33dc10-5d16-488b-9fa9-efe0e7cde1df"));
		}

		#endregion

	}

	#endregion


	#region Class: UsrTreatmentprogramsEventsProcess

	/// <exclude/>
	public class UsrTreatmentprogramsEventsProcess : UsrTreatmentprograms_CertificationEventsProcess
	{

		public UsrTreatmentprogramsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

