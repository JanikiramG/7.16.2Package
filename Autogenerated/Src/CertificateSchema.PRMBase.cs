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
	using Terrasoft.Configuration;
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

	#region Class: CertificateSchema

	/// <exclude/>
	public class CertificateSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public CertificateSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CertificateSchema(CertificateSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CertificateSchema(CertificateSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("36558ee5-03f9-4ffd-8272-c648af79e097");
			RealUId = new Guid("36558ee5-03f9-4ffd-8272-c648af79e097");
			Name = "Certificate";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateCertificateNumberColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeMasterRecordColumn() {
			base.InitializeMasterRecordColumn();
			MasterRecordColumn = CreateContactColumn();
			if (Columns.FindByUId(MasterRecordColumn.UId) == null) {
				Columns.Add(MasterRecordColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("8e0dae65-fe30-4c60-b66c-26ecd6bb5ca1")) == null) {
				Columns.Add(CreateEducationActivityColumn());
			}
			if (Columns.FindByUId(new Guid("6e7732f6-6737-4771-b851-a89c614ccc04")) == null) {
				Columns.Add(CreateIssueDateColumn());
			}
			if (Columns.FindByUId(new Guid("8d14b73c-a593-4d44-9611-afac9ae65422")) == null) {
				Columns.Add(CreateExpireDateColumn());
			}
			if (Columns.FindByUId(new Guid("9c060e50-0cc7-4718-ad10-96f18625f3c4")) == null) {
				Columns.Add(CreateCompetenceLevelColumn());
			}
			if (Columns.FindByUId(new Guid("070a13af-37f3-465d-92cd-eae0f6ad659d")) == null) {
				Columns.Add(CreateResultScoreColumn());
			}
			if (Columns.FindByUId(new Guid("6ea2e256-0605-4c1d-b070-5b4356917abb")) == null) {
				Columns.Add(CreateCommentsColumn());
			}
			if (Columns.FindByUId(new Guid("45e54b8a-af02-42ea-a8b9-09f40f868885")) == null) {
				Columns.Add(CreateNotificationSentColumn());
			}
			if (Columns.FindByUId(new Guid("df63e6cc-2afa-46b5-aafc-07b48e9adb12")) == null) {
				Columns.Add(CreateDateOfNotificationColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0f4104c8-9581-4af6-901a-28bb15e5b42f"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("36558ee5-03f9-4ffd-8272-c648af79e097"),
				ModifiedInSchemaUId = new Guid("36558ee5-03f9-4ffd-8272-c648af79e097"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039")
			};
		}

		protected virtual EntitySchemaColumn CreateEducationActivityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8e0dae65-fe30-4c60-b66c-26ecd6bb5ca1"),
				Name = @"EducationActivity",
				ReferenceSchemaUId = new Guid("48a0ddfd-a99e-4bf5-8b5a-e56dfec31e0c"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("36558ee5-03f9-4ffd-8272-c648af79e097"),
				ModifiedInSchemaUId = new Guid("36558ee5-03f9-4ffd-8272-c648af79e097"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039")
			};
		}

		protected virtual EntitySchemaColumn CreateIssueDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("6e7732f6-6737-4771-b851-a89c614ccc04"),
				Name = @"IssueDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("36558ee5-03f9-4ffd-8272-c648af79e097"),
				ModifiedInSchemaUId = new Guid("36558ee5-03f9-4ffd-8272-c648af79e097"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039")
			};
		}

		protected virtual EntitySchemaColumn CreateExpireDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("8d14b73c-a593-4d44-9611-afac9ae65422"),
				Name = @"ExpireDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("36558ee5-03f9-4ffd-8272-c648af79e097"),
				ModifiedInSchemaUId = new Guid("36558ee5-03f9-4ffd-8272-c648af79e097"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039")
			};
		}

		protected virtual EntitySchemaColumn CreateCompetenceLevelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9c060e50-0cc7-4718-ad10-96f18625f3c4"),
				Name = @"CompetenceLevel",
				ReferenceSchemaUId = new Guid("54c499af-04aa-4eb5-9815-f23e12685d68"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("36558ee5-03f9-4ffd-8272-c648af79e097"),
				ModifiedInSchemaUId = new Guid("36558ee5-03f9-4ffd-8272-c648af79e097"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039")
			};
		}

		protected virtual EntitySchemaColumn CreateResultScoreColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("070a13af-37f3-465d-92cd-eae0f6ad659d"),
				Name = @"ResultScore",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("36558ee5-03f9-4ffd-8272-c648af79e097"),
				ModifiedInSchemaUId = new Guid("36558ee5-03f9-4ffd-8272-c648af79e097"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039")
			};
		}

		protected virtual EntitySchemaColumn CreateCertificateNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("46f778b8-2e42-4f45-91c4-65a9c75d2e3d"),
				Name = @"CertificateNumber",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("36558ee5-03f9-4ffd-8272-c648af79e097"),
				ModifiedInSchemaUId = new Guid("36558ee5-03f9-4ffd-8272-c648af79e097"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039")
			};
		}

		protected virtual EntitySchemaColumn CreateCommentsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("6ea2e256-0605-4c1d-b070-5b4356917abb"),
				Name = @"Comments",
				CreatedInSchemaUId = new Guid("36558ee5-03f9-4ffd-8272-c648af79e097"),
				ModifiedInSchemaUId = new Guid("36558ee5-03f9-4ffd-8272-c648af79e097"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039")
			};
		}

		protected virtual EntitySchemaColumn CreateNotificationSentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("45e54b8a-af02-42ea-a8b9-09f40f868885"),
				Name = @"NotificationSent",
				CreatedInSchemaUId = new Guid("36558ee5-03f9-4ffd-8272-c648af79e097"),
				ModifiedInSchemaUId = new Guid("36558ee5-03f9-4ffd-8272-c648af79e097"),
				CreatedInPackageId = new Guid("c753c9c2-3fc1-46be-9c9c-b15f50a19487")
			};
		}

		protected virtual EntitySchemaColumn CreateDateOfNotificationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("df63e6cc-2afa-46b5-aafc-07b48e9adb12"),
				Name = @"DateOfNotification",
				CreatedInSchemaUId = new Guid("36558ee5-03f9-4ffd-8272-c648af79e097"),
				ModifiedInSchemaUId = new Guid("36558ee5-03f9-4ffd-8272-c648af79e097"),
				CreatedInPackageId = new Guid("c753c9c2-3fc1-46be-9c9c-b15f50a19487")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCertificateEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCertificateEventsProcessSchema() {
			var schema = new CertificateEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Certificate(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Certificate_PRMBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CertificateSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CertificateSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("36558ee5-03f9-4ffd-8272-c648af79e097"));
		}

		#endregion

	}

	#endregion

	#region Class: Certificate

	/// <summary>
	/// Certificate.
	/// </summary>
	public class Certificate : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public Certificate(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Certificate";
		}

		public Certificate(Certificate source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public string ContactName {
			get {
				return GetTypedColumnValue<string>("ContactName");
			}
			set {
				SetColumnValue("ContactName", value);
				if (_contact != null) {
					_contact.Name = value;
				}
			}
		}

		private Contact _contact;
		/// <summary>
		/// Contact.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
			}
		}

		/// <exclude/>
		public Guid EducationActivityId {
			get {
				return GetTypedColumnValue<Guid>("EducationActivityId");
			}
			set {
				SetColumnValue("EducationActivityId", value);
				_educationActivity = null;
			}
		}

		/// <exclude/>
		public string EducationActivityName {
			get {
				return GetTypedColumnValue<string>("EducationActivityName");
			}
			set {
				SetColumnValue("EducationActivityName", value);
				if (_educationActivity != null) {
					_educationActivity.Name = value;
				}
			}
		}

		private EducationActivity _educationActivity;
		/// <summary>
		/// Education activity.
		/// </summary>
		public EducationActivity EducationActivity {
			get {
				return _educationActivity ??
					(_educationActivity = LookupColumnEntities.GetEntity("EducationActivity") as EducationActivity);
			}
		}

		/// <summary>
		/// Issue date.
		/// </summary>
		public DateTime IssueDate {
			get {
				return GetTypedColumnValue<DateTime>("IssueDate");
			}
			set {
				SetColumnValue("IssueDate", value);
			}
		}

		/// <summary>
		/// Expire date.
		/// </summary>
		public DateTime ExpireDate {
			get {
				return GetTypedColumnValue<DateTime>("ExpireDate");
			}
			set {
				SetColumnValue("ExpireDate", value);
			}
		}

		/// <exclude/>
		public Guid CompetenceLevelId {
			get {
				return GetTypedColumnValue<Guid>("CompetenceLevelId");
			}
			set {
				SetColumnValue("CompetenceLevelId", value);
				_competenceLevel = null;
			}
		}

		/// <exclude/>
		public string CompetenceLevelName {
			get {
				return GetTypedColumnValue<string>("CompetenceLevelName");
			}
			set {
				SetColumnValue("CompetenceLevelName", value);
				if (_competenceLevel != null) {
					_competenceLevel.Name = value;
				}
			}
		}

		private CompetenceLevel _competenceLevel;
		/// <summary>
		/// Competence level.
		/// </summary>
		public CompetenceLevel CompetenceLevel {
			get {
				return _competenceLevel ??
					(_competenceLevel = LookupColumnEntities.GetEntity("CompetenceLevel") as CompetenceLevel);
			}
		}

		/// <summary>
		/// Result score.
		/// </summary>
		public Decimal ResultScore {
			get {
				return GetTypedColumnValue<Decimal>("ResultScore");
			}
			set {
				SetColumnValue("ResultScore", value);
			}
		}

		/// <summary>
		/// Number.
		/// </summary>
		public string CertificateNumber {
			get {
				return GetTypedColumnValue<string>("CertificateNumber");
			}
			set {
				SetColumnValue("CertificateNumber", value);
			}
		}

		/// <summary>
		/// Comments.
		/// </summary>
		public string Comments {
			get {
				return GetTypedColumnValue<string>("Comments");
			}
			set {
				SetColumnValue("Comments", value);
			}
		}

		/// <summary>
		/// Notification of expiration has been sent.
		/// </summary>
		public bool NotificationSent {
			get {
				return GetTypedColumnValue<bool>("NotificationSent");
			}
			set {
				SetColumnValue("NotificationSent", value);
			}
		}

		/// <summary>
		/// Date of notification.
		/// </summary>
		public DateTime DateOfNotification {
			get {
				return GetTypedColumnValue<DateTime>("DateOfNotification");
			}
			set {
				SetColumnValue("DateOfNotification", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Certificate_PRMBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CertificateDeleted", e);
			Saved += (s, e) => ThrowEvent("CertificateSaved", e);
			Validating += (s, e) => ThrowEvent("CertificateValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Certificate(this);
		}

		#endregion

	}

	#endregion

	#region Class: Certificate_PRMBaseEventsProcess

	/// <exclude/>
	public partial class Certificate_PRMBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : Certificate
	{

		public Certificate_PRMBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Certificate_PRMBaseEventsProcess";
			SchemaUId = new Guid("36558ee5-03f9-4ffd-8272-c648af79e097");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("36558ee5-03f9-4ffd-8272-c648af79e097");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("245b7732-2d0d-4792-b142-408984b3d8ab"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _actualizeCertificateOnSaved;
		public ProcessScriptTask ActualizeCertificateOnSaved {
			get {
				return _actualizeCertificateOnSaved ?? (_actualizeCertificateOnSaved = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActualizeCertificateOnSaved",
					SchemaElementUId = new Guid("1ef5e2d2-87e3-458f-9996-e4c66ec75441"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ActualizeCertificateOnSavedExecute,
				});
			}
		}

		private ProcessFlowElement _onSaved;
		public ProcessFlowElement OnSaved {
			get {
				return _onSaved ?? (_onSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OnSaved",
					SchemaElementUId = new Guid("f4dc1393-7869-4849-a327-3624058e5369"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _actualizeCertificateOnDeleted;
		public ProcessScriptTask ActualizeCertificateOnDeleted {
			get {
				return _actualizeCertificateOnDeleted ?? (_actualizeCertificateOnDeleted = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActualizeCertificateOnDeleted",
					SchemaElementUId = new Guid("00c82811-5ca1-415f-ac47-007ef7f86e99"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ActualizeCertificateOnDeletedExecute,
				});
			}
		}

		private ProcessFlowElement _onDeletedStartMessage;
		public ProcessFlowElement OnDeletedStartMessage {
			get {
				return _onDeletedStartMessage ?? (_onDeletedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OnDeletedStartMessage",
					SchemaElementUId = new Guid("16ad7ea8-dc80-48c8-a7e1-871f2106dd05"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _certificateDeletedIntermediateThrowMessage;
		public ProcessThrowMessageEvent CertificateDeletedIntermediateThrowMessage {
			get {
				return _certificateDeletedIntermediateThrowMessage ?? (_certificateDeletedIntermediateThrowMessage = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "CertificateDeletedIntermediateThrowMessage",
					SchemaElementUId = new Guid("dc297e47-c3cb-4aa9-80a5-d9889fa38706"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "CertificateDeleted",
						ThrowToBase = true,
				});
			}
		}

		private ProcessThrowMessageEvent _onSavedIntermediateThrowMessage;
		public ProcessThrowMessageEvent OnSavedIntermediateThrowMessage {
			get {
				return _onSavedIntermediateThrowMessage ?? (_onSavedIntermediateThrowMessage = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "OnSavedIntermediateThrowMessage",
					SchemaElementUId = new Guid("1e9f0d78-96f3-4315-b353-8fc1adf1f9f2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "CertificateSaved",
						ThrowToBase = true,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ActualizeCertificateOnSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ActualizeCertificateOnSaved };
			FlowElements[OnSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { OnSaved };
			FlowElements[ActualizeCertificateOnDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { ActualizeCertificateOnDeleted };
			FlowElements[OnDeletedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OnDeletedStartMessage };
			FlowElements[CertificateDeletedIntermediateThrowMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CertificateDeletedIntermediateThrowMessage };
			FlowElements[OnSavedIntermediateThrowMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OnSavedIntermediateThrowMessage };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "ActualizeCertificateOnSaved":
						e.Context.QueueTasks.Enqueue("OnSavedIntermediateThrowMessage");
						break;
					case "OnSaved":
						e.Context.QueueTasks.Enqueue("ActualizeCertificateOnSaved");
						break;
					case "ActualizeCertificateOnDeleted":
						e.Context.QueueTasks.Enqueue("CertificateDeletedIntermediateThrowMessage");
						break;
					case "OnDeletedStartMessage":
						e.Context.QueueTasks.Enqueue("ActualizeCertificateOnDeleted");
						break;
					case "CertificateDeletedIntermediateThrowMessage":
						break;
					case "OnSavedIntermediateThrowMessage":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("OnSaved");
			ActivatedEventElements.Add("OnDeletedStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "ActualizeCertificateOnSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActualizeCertificateOnSaved";
					result = ActualizeCertificateOnSaved.Execute(context, ActualizeCertificateOnSavedExecute);
					break;
				case "OnSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "OnSaved";
					result = OnSaved.Execute(context);
					break;
				case "ActualizeCertificateOnDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActualizeCertificateOnDeleted";
					result = ActualizeCertificateOnDeleted.Execute(context, ActualizeCertificateOnDeletedExecute);
					break;
				case "OnDeletedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OnDeletedStartMessage";
					result = OnDeletedStartMessage.Execute(context);
					break;
				case "CertificateDeletedIntermediateThrowMessage":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "CertificateDeleted");
					result = CertificateDeletedIntermediateThrowMessage.Execute(context);
					break;
				case "OnSavedIntermediateThrowMessage":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "CertificateSaved");
					result = OnSavedIntermediateThrowMessage.Execute(context);
					break;
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

		public virtual bool ActualizeCertificateOnSavedExecute(ProcessExecutingContext context) {
			ActualizeCertificateCount(Entity.GetTypedColumnValue<Guid>("ContactId"));
			return true;
		}

		public virtual bool ActualizeCertificateOnDeletedExecute(ProcessExecutingContext context) {
			ActualizeCertificateCount(Entity.GetTypedOldColumnValue<Guid>("ContactId"));
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "CertificateSaved":
							if (ActivatedEventElements.Contains("OnSaved")) {
							context.QueueTasks.Enqueue("OnSaved");
						}
						break;
					case "CertificateDeleted":
							if (ActivatedEventElements.Contains("OnDeletedStartMessage")) {
							context.QueueTasks.Enqueue("OnDeletedStartMessage");
						}
						break;
			}
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

	#region Class: Certificate_PRMBaseEventsProcess

	/// <exclude/>
	public class Certificate_PRMBaseEventsProcess : Certificate_PRMBaseEventsProcess<Certificate>
	{

		public Certificate_PRMBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Certificate_PRMBaseEventsProcess

	public partial class Certificate_PRMBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void ActualizeCertificateCount(Guid ContactId) {
			var select = new Select(UserConnection).Top(1)
				.Column("part", "Id")
				.From("Contact").As("cont")
				.Join(JoinType.Inner, "Account").As("acc")
					.On("cont", "AccountId").IsEqual("acc", "Id")
				.Join(JoinType.Inner, "Partnership").As("part")
					.On("part", "AccountId").IsEqual("acc", "Id")
				.Where("cont", "Id").IsEqual(Column.Parameter(ContactId))
					.And("part", "IsActive").IsEqual(Column.Parameter(true)) as Select;
			Guid partnershipId;
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				partnershipId = select.ExecuteScalar<Guid>(dbExecutor);
			}
			if (partnershipId != Guid.Empty) {
				var columnsMapping = new Dictionary<string,string>();
				columnsMapping.Add("Id","Id");
				columnsMapping.Add("Count","IntValue");
				var actualizer = ConfigureEntityDataActualizer(partnershipId);
				actualizer.Actualize("Id", "PartnershipParameter", columnsMapping);
			}
		}

		public virtual EntityDataActualizer ConfigureEntityDataActualizer(Guid partnershipId) {
			var entityDataContext = new EntityActualizatorDataContext(UserConnection);
			var dataExtractor = new PartnershipCertifiedContactsDataExtractor(UserConnection);
			var partnershipFilter = GetFilterByPartnership(partnershipId);
			dataExtractor.AddFilter(partnershipFilter);
			var actualizer = new EntityDataActualizer(UserConnection, dataExtractor, entityDataContext);
			return actualizer;
		}

		public virtual QueryCondition GetFilterByPartnership(Guid partnershipId) {
			var partnershipFilter = new QueryCondition(QueryConditionType.Equal);
			partnershipFilter.ConditionType = QueryConditionType.Block;
			partnershipFilter.LeftExpression = new QueryColumnExpression("part", "Id");
			partnershipFilter.IsEqual(Column.Parameter(partnershipId));
			return partnershipFilter;
		}

		#endregion

	}

	#endregion

	#region Class: CertificateEventsProcessSchema

	/// <exclude/>
	public class CertificateEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public CertificateEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CertificateEventsProcessSchema(CertificateEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Certificate_PRMBaseEventsProcess";
			UId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef");
			CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039");
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
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaScriptTask actualizecertificateonsaved = CreateActualizeCertificateOnSavedScriptTask();
			eventsubprocess1.FlowElements.Add(actualizecertificateonsaved);
			ProcessSchemaStartMessageEvent onsaved = CreateOnSavedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(onsaved);
			ProcessSchemaScriptTask actualizecertificateondeleted = CreateActualizeCertificateOnDeletedScriptTask();
			eventsubprocess1.FlowElements.Add(actualizecertificateondeleted);
			ProcessSchemaStartMessageEvent ondeletedstartmessage = CreateOnDeletedStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(ondeletedstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent certificatedeletedintermediatethrowmessage = CreateCertificateDeletedIntermediateThrowMessageIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(certificatedeletedintermediatethrowmessage);
			ProcessSchemaIntermediateThrowMessageEvent onsavedintermediatethrowmessage = CreateOnSavedIntermediateThrowMessageIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(onsavedintermediatethrowmessage);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("7fc5f945-5957-43fb-a21d-838e5768e276"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("ad40b837-06de-4802-b0a3-084f3cf30f81"),
				CreatedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f4dc1393-7869-4849-a327-3624058e5369"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1ef5e2d2-87e3-458f-9996-e4c66ec75441"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("ce07ec6f-6fc3-4b19-8fad-f83725714aca"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5ba4a2eb-61ca-4e70-8fdd-27f13e04fc78"),
				CreatedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("16ad7ea8-dc80-48c8-a7e1-871f2106dd05"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("00c82811-5ca1-415f-ac47-007ef7f86e99"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("edc31ab6-b254-425d-9ce8-683bd12b9fe0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5ba4a2eb-61ca-4e70-8fdd-27f13e04fc78"),
				CreatedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("00c82811-5ca1-415f-ac47-007ef7f86e99"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dc297e47-c3cb-4aa9-80a5-d9889fa38706"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("5cf1dee8-cc3d-4d73-9718-8ab09cc0204f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5ba4a2eb-61ca-4e70-8fdd-27f13e04fc78"),
				CreatedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1ef5e2d2-87e3-458f-9996-e4c66ec75441"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1e9f0d78-96f3-4315-b353-8fc1adf1f9f2"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("88257e7e-ccde-4764-8fac-1b09f0b48f81"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("ad40b837-06de-4802-b0a3-084f3cf30f81"),
				CreatedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				Name = @"LaneSet1",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("0e498d92-b213-4345-be44-2c09613519a9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("88257e7e-ccde-4764-8fac-1b09f0b48f81"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("ad40b837-06de-4802-b0a3-084f3cf30f81"),
				CreatedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("245b7732-2d0d-4792-b142-408984b3d8ab"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0e498d92-b213-4345-be44-2c09613519a9"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5ba4a2eb-61ca-4e70-8fdd-27f13e04fc78"),
				CreatedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(140, 57),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(680, 500),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaScriptTask CreateActualizeCertificateOnSavedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1ef5e2d2-87e3-458f-9996-e4c66ec75441"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("245b7732-2d0d-4792-b142-408984b3d8ab"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("ad40b837-06de-4802-b0a3-084f3cf30f81"),
				CreatedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				Name = @"ActualizeCertificateOnSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(145, 124),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,5,193,65,10,128,32,16,5,208,125,167,8,87,186,233,2,69,16,18,210,62,218,139,78,48,96,99,200,159,133,157,190,247,182,4,141,133,63,242,212,192,55,167,8,242,85,5,118,23,48,250,20,8,103,127,41,251,90,244,145,43,22,165,37,40,231,213,26,95,5,49,225,200,198,185,121,104,4,109,50,162,41,205,63,85,227,35,229,86,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOnSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f4dc1393-7869-4849-a327-3624058e5369"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("245b7732-2d0d-4792-b142-408984b3d8ab"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("ad40b837-06de-4802-b0a3-084f3cf30f81"),
				CreatedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CertificateSaved",
				ModifiedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				Name = @"OnSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(30, 138),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateActualizeCertificateOnDeletedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("00c82811-5ca1-415f-ac47-007ef7f86e99"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("245b7732-2d0d-4792-b142-408984b3d8ab"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5ba4a2eb-61ca-4e70-8fdd-27f13e04fc78"),
				CreatedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				Name = @"ActualizeCertificateOnDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(139, 259),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,5,193,49,10,128,48,12,5,208,221,83,136,83,187,120,1,69,144,34,226,228,34,238,165,141,16,168,169,132,159,65,79,239,123,115,130,197,194,31,5,82,240,197,41,130,66,53,129,91,4,140,183,95,9,199,251,80,222,75,14,181,216,45,103,44,70,227,106,156,39,215,133,42,136,9,91,238,188,31,26,37,152,74,11,53,26,126,145,33,126,21,89,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOnDeletedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("16ad7ea8-dc80-48c8-a7e1-871f2106dd05"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("245b7732-2d0d-4792-b142-408984b3d8ab"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5ba4a2eb-61ca-4e70-8fdd-27f13e04fc78"),
				CreatedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CertificateDeleted",
				ModifiedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				Name = @"OnDeletedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(33, 273),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateCertificateDeletedIntermediateThrowMessageIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("dc297e47-c3cb-4aa9-80a5-d9889fa38706"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("245b7732-2d0d-4792-b142-408984b3d8ab"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5ba4a2eb-61ca-4e70-8fdd-27f13e04fc78"),
				CreatedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"CertificateDeleted",
				ModifiedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				Name = @"CertificateDeletedIntermediateThrowMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(303, 273),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateOnSavedIntermediateThrowMessageIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("1e9f0d78-96f3-4315-b353-8fc1adf1f9f2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("245b7732-2d0d-4792-b142-408984b3d8ab"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5ba4a2eb-61ca-4e70-8fdd-27f13e04fc78"),
				CreatedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"CertificateSaved",
				ModifiedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				Name = @"OnSavedIntermediateThrowMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(302, 138),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateActualizeCertificateCountMethod());
			Methods.Add(CreateConfigureEntityDataActualizerMethod());
			Methods.Add(CreateGetFilterByPartnershipMethod());
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
				UId = new Guid("d6a0d4e8-8acf-4325-90c4-22e4a799bb68"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("ad40b837-06de-4802-b0a3-084f3cf30f81")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("bf1fc976-69e2-4225-b3ff-733b355fcf86"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("ad40b837-06de-4802-b0a3-084f3cf30f81")
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

		protected virtual SchemaMethod CreateActualizeCertificateCountMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8ae6b6e9-858c-4c60-81e0-efeabb39b752"),
				Name = "ActualizeCertificateCount",
				CreatedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				CreatedInPackageId = new Guid("5ba4a2eb-61ca-4e70-8fdd-27f13e04fc78"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5611d5cd-bb1e-40cd-8188-13f363f6f17d"),
				Name = "ContactId",
				CreatedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				ModifiedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("5ba4a2eb-61ca-4e70-8fdd-27f13e04fc78")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,93,79,131,48,20,125,134,95,81,121,42,201,210,196,231,109,38,184,161,193,196,104,178,169,207,181,116,91,19,40,181,31,83,52,254,119,111,11,3,73,212,248,2,237,237,57,231,158,158,219,35,213,200,240,138,51,139,150,72,242,87,180,9,27,252,96,184,94,53,82,194,90,52,50,37,219,70,225,243,52,142,200,170,169,92,45,113,162,168,182,201,12,37,69,153,248,242,149,110,106,156,0,195,82,102,147,148,100,6,39,12,118,225,240,166,17,18,251,207,182,85,156,20,160,170,129,153,49,214,56,121,2,83,198,60,54,34,119,178,103,142,16,223,131,20,38,127,113,180,234,144,99,227,159,181,239,193,29,172,204,65,168,94,63,248,29,26,156,220,255,163,193,211,129,107,62,90,154,64,187,48,8,116,163,53,183,92,227,62,128,162,76,67,171,76,150,223,146,50,25,132,121,228,127,241,173,118,60,77,17,53,253,28,230,241,181,19,37,82,227,117,138,114,30,59,35,228,30,225,35,204,174,124,206,223,56,115,182,209,48,191,233,208,72,46,141,211,124,125,57,150,48,104,127,196,209,68,14,120,221,3,32,157,18,223,48,90,81,189,240,141,47,240,168,159,206,227,207,88,236,16,158,178,207,150,200,35,73,94,43,219,6,117,111,139,133,139,153,91,170,148,183,218,61,173,181,8,38,168,110,23,198,106,168,207,186,223,5,6,237,104,74,33,89,9,209,65,216,179,144,248,47,231,171,240,128,0,34,237,35,173,28,15,64,223,31,102,0,249,138,119,238,99,129,251,239,196,30,162,200,165,21,182,93,83,75,179,225,124,122,29,207,31,185,100,128,117,86,38,239,106,24,26,212,167,222,124,82,95,14,38,53,48,88,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateConfigureEntityDataActualizerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fa102a2f-1b17-4563-9dd6-0affe2594107"),
				Name = "ConfigureEntityDataActualizer",
				CreatedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				CreatedInPackageId = new Guid("de8ae9a8-a9a7-4323-ba50-b61a787183b3"),
				ResultValueTypeName = "EntityDataActualizer"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8bc7ac31-f1c0-4e0f-8318-3542aee0923e"),
				Name = "partnershipId",
				CreatedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				ModifiedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("de8ae9a8-a9a7-4323-ba50-b61a787183b3")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,65,14,130,64,12,69,247,158,98,150,152,16,47,64,92,32,160,113,231,198,3,52,76,141,77,72,33,165,32,120,122,7,33,58,35,238,154,206,235,155,223,246,32,6,89,73,199,28,20,178,154,21,7,53,123,195,248,48,197,187,159,150,218,65,69,79,208,90,60,38,186,182,40,174,102,44,149,106,222,38,155,222,169,172,3,138,65,5,74,71,47,154,11,136,50,74,123,167,38,67,81,186,17,218,73,226,152,54,247,249,255,202,230,59,126,164,74,113,210,158,80,231,250,48,122,246,200,67,207,214,141,7,105,118,169,181,243,80,180,82,46,95,193,178,42,74,112,129,41,100,250,121,250,73,25,135,59,199,235,107,58,185,160,118,194,158,63,121,1,84,1,155,22,120,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetFilterByPartnershipMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8ec6da65-c4a2-4ff0-8747-331e534c5307"),
				Name = "GetFilterByPartnership",
				CreatedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				CreatedInPackageId = new Guid("de8ae9a8-a9a7-4323-ba50-b61a787183b3"),
				ResultValueTypeName = "QueryCondition"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0d6c3f42-fa46-4ac0-ba29-e449ba61004d"),
				Name = "partnershipId",
				CreatedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				ModifiedInSchemaUId = new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("de8ae9a8-a9a7-4323-ba50-b61a787183b3")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,193,10,2,33,20,69,247,125,133,184,114,32,252,129,161,77,49,129,208,162,160,31,144,124,145,228,60,237,169,213,252,125,86,139,146,113,249,184,247,92,14,239,174,137,5,77,9,129,226,197,134,173,117,9,136,173,24,194,131,29,50,208,180,241,104,108,178,30,69,125,30,167,0,114,184,101,237,186,126,49,91,144,85,175,236,53,224,181,243,167,107,139,221,193,57,13,207,64,16,99,233,214,50,46,143,248,203,4,127,211,124,201,184,50,188,233,161,226,199,81,124,73,185,215,164,71,40,129,248,171,42,211,21,150,32,101,194,249,51,250,23,34,35,225,163,35,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CertificateEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("13dc4dbd-d366-4e48-b2dd-add54636f7ef"));
		}

		#endregion

	}

	#endregion


	#region Class: CertificateEventsProcess

	/// <exclude/>
	public class CertificateEventsProcess : Certificate_PRMBaseEventsProcess
	{

		public CertificateEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

