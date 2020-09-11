namespace Terrasoft.Configuration
{

	using CoreSysCulture = Terrasoft.Core.Configuration.SysCulture;
	using CoreSysSettings = Terrasoft.Core.Configuration.SysSettings;
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
	using Terrasoft.Configuration.Translation;
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

	#region Class: SysCultureSchema

	/// <exclude/>
	public class SysCultureSchema : Terrasoft.Configuration.SysCulture_Base_TerrasoftSchema
	{

		#region Constructors: Public

		public SysCultureSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysCultureSchema(SysCultureSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysCultureSchema(SysCultureSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("b3195259-2c68-44b4-a6e9-c7d250a1522a");
			Name = "SysCulture";
			ParentSchemaUId = new Guid("ffc193e1-04bc-472b-bdc0-3333d1df84e4");
			ExtendParent = true;
			CreatedInPackageId = new Guid("40d35dd0-7421-45de-9f03-34d8a7341beb");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryImageColumn() {
			base.InitializePrimaryImageColumn();
			PrimaryImageColumn = CreateImageColumn();
			if (Columns.FindByUId(PrimaryImageColumn.UId) == null) {
				Columns.Add(PrimaryImageColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("88a9958c-6878-4adb-b534-d894dda3c7e8")) == null) {
				Columns.Add(CreateActiveColumn());
			}
			if (Columns.FindByUId(new Guid("46bd9122-9f52-4b8a-930b-f1b9d5b21b1a")) == null) {
				Columns.Add(CreateIndexColumn());
			}
			if (Columns.FindByUId(new Guid("08419b1c-0aec-49ab-9229-ecc7c42b6279")) == null) {
				Columns.Add(CreateLanguageColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.RequirementType = EntitySchemaColumnRequirementType.None;
			column.ModifiedInSchemaUId = new Guid("b3195259-2c68-44b4-a6e9-c7d250a1522a");
			return column;
		}

		protected virtual EntitySchemaColumn CreateImageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ImageLookup")) {
				UId = new Guid("cb8ceccd-8515-47d9-87ed-5dcb1249571d"),
				Name = @"Image",
				ReferenceSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("b3195259-2c68-44b4-a6e9-c7d250a1522a"),
				ModifiedInSchemaUId = new Guid("b3195259-2c68-44b4-a6e9-c7d250a1522a"),
				CreatedInPackageId = new Guid("40d35dd0-7421-45de-9f03-34d8a7341beb")
			};
		}

		protected virtual EntitySchemaColumn CreateActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("88a9958c-6878-4adb-b534-d894dda3c7e8"),
				Name = @"Active",
				CreatedInSchemaUId = new Guid("b3195259-2c68-44b4-a6e9-c7d250a1522a"),
				ModifiedInSchemaUId = new Guid("b3195259-2c68-44b4-a6e9-c7d250a1522a"),
				CreatedInPackageId = new Guid("40d35dd0-7421-45de-9f03-34d8a7341beb")
			};
		}

		protected virtual EntitySchemaColumn CreateIndexColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("46bd9122-9f52-4b8a-930b-f1b9d5b21b1a"),
				Name = @"Index",
				CreatedInSchemaUId = new Guid("b3195259-2c68-44b4-a6e9-c7d250a1522a"),
				ModifiedInSchemaUId = new Guid("b3195259-2c68-44b4-a6e9-c7d250a1522a"),
				CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("08419b1c-0aec-49ab-9229-ecc7c42b6279"),
				Name = @"Language",
				ReferenceSchemaUId = new Guid("2f96cb61-7e14-41e5-980a-bcb856edab51"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("b3195259-2c68-44b4-a6e9-c7d250a1522a"),
				ModifiedInSchemaUId = new Guid("b3195259-2c68-44b4-a6e9-c7d250a1522a"),
				CreatedInPackageId = new Guid("cde2c5f9-9833-484d-a601-140e8f10df72")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysCultureEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysCultureEventsProcessSchema() {
			var schema = new SysCultureEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysCulture(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysCulture_TranslationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysCultureSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysCultureSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b3195259-2c68-44b4-a6e9-c7d250a1522a"));
		}

		#endregion

	}

	#endregion

	#region Class: SysCulture

	/// <summary>
	/// Culture.
	/// </summary>
	public class SysCulture : Terrasoft.Configuration.SysCulture_Base_Terrasoft
	{

		#region Constructors: Public

		public SysCulture(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysCulture";
		}

		public SysCulture(SysCulture source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ImageId {
			get {
				return GetTypedColumnValue<Guid>("ImageId");
			}
			set {
				SetColumnValue("ImageId", value);
				_image = null;
			}
		}

		/// <exclude/>
		public string ImageName {
			get {
				return GetTypedColumnValue<string>("ImageName");
			}
			set {
				SetColumnValue("ImageName", value);
				if (_image != null) {
					_image.Name = value;
				}
			}
		}

		private SysImage _image;
		/// <summary>
		/// Image.
		/// </summary>
		public SysImage Image {
			get {
				return _image ??
					(_image = LookupColumnEntities.GetEntity("Image") as SysImage);
			}
		}

		/// <summary>
		/// Active.
		/// </summary>
		public bool Active {
			get {
				return GetTypedColumnValue<bool>("Active");
			}
			set {
				SetColumnValue("Active", value);
			}
		}

		/// <summary>
		/// Index.
		/// </summary>
		public int Index {
			get {
				return GetTypedColumnValue<int>("Index");
			}
			set {
				SetColumnValue("Index", value);
			}
		}

		/// <exclude/>
		public Guid LanguageId {
			get {
				return GetTypedColumnValue<Guid>("LanguageId");
			}
			set {
				SetColumnValue("LanguageId", value);
				_language = null;
			}
		}

		/// <exclude/>
		public string LanguageName {
			get {
				return GetTypedColumnValue<string>("LanguageName");
			}
			set {
				SetColumnValue("LanguageName", value);
				if (_language != null) {
					_language.Name = value;
				}
			}
		}

		private SysLanguage _language;
		/// <summary>
		/// Name.
		/// </summary>
		public SysLanguage Language {
			get {
				return _language ??
					(_language = LookupColumnEntities.GetEntity("Language") as SysLanguage);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysCulture_TranslationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysCultureDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysCultureDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysCultureInserted", e);
			Inserting += (s, e) => ThrowEvent("SysCultureInserting", e);
			Updated += (s, e) => ThrowEvent("SysCultureUpdated", e);
			Updating += (s, e) => ThrowEvent("SysCultureUpdating", e);
			Validating += (s, e) => ThrowEvent("SysCultureValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysCulture(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysCulture_TranslationEventsProcess

	/// <exclude/>
	public partial class SysCulture_TranslationEventsProcess<TEntity> : Terrasoft.Configuration.SysCulture_BaseEventsProcess<TEntity> where TEntity : SysCulture
	{

		public SysCulture_TranslationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysCulture_TranslationEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b3195259-2c68-44b4-a6e9-c7d250a1522a");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual string TranslationColumnName {
			get;
			set;
		}

		public virtual string VerificationColumnName {
			get;
			set;
		}

		public virtual string IsChangedColumnName {
			get;
			set;
		}

		private ProcessFlowElement _sysCultureUpdatingEventSubProcess;
		public ProcessFlowElement SysCultureUpdatingEventSubProcess {
			get {
				return _sysCultureUpdatingEventSubProcess ?? (_sysCultureUpdatingEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SysCultureUpdatingEventSubProcess",
					SchemaElementUId = new Guid("6274a749-6cd6-40d7-a0d8-1bb1516a655a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _sysCultureUpdatingScriptTask;
		public ProcessScriptTask SysCultureUpdatingScriptTask {
			get {
				return _sysCultureUpdatingScriptTask ?? (_sysCultureUpdatingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SysCultureUpdatingScriptTask",
					SchemaElementUId = new Guid("9563ff96-fbeb-47ec-b863-db13ed157ec5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SysCultureUpdatingScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _sysCultureUpdatingStartMessage;
		public ProcessFlowElement SysCultureUpdatingStartMessage {
			get {
				return _sysCultureUpdatingStartMessage ?? (_sysCultureUpdatingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysCultureUpdatingStartMessage",
					SchemaElementUId = new Guid("0d6a48e3-0f75-4cb5-8cc2-2ac44d0b7d7e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysCultureDeletingEventSubProcess;
		public ProcessFlowElement SysCultureDeletingEventSubProcess {
			get {
				return _sysCultureDeletingEventSubProcess ?? (_sysCultureDeletingEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SysCultureDeletingEventSubProcess",
					SchemaElementUId = new Guid("0464738a-4230-45a1-a58b-f1142f3bf36d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysCultureDeletingStartMessage;
		public ProcessFlowElement SysCultureDeletingStartMessage {
			get {
				return _sysCultureDeletingStartMessage ?? (_sysCultureDeletingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysCultureDeletingStartMessage",
					SchemaElementUId = new Guid("57b197c5-c301-4dc4-949a-3246316c3250"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _sysCultureDeletingScriptTask;
		public ProcessScriptTask SysCultureDeletingScriptTask {
			get {
				return _sysCultureDeletingScriptTask ?? (_sysCultureDeletingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SysCultureDeletingScriptTask",
					SchemaElementUId = new Guid("9d74c5fc-517b-4b89-a033-6e3c560e0712"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SysCultureDeletingScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _sysCultureDeletedEventSubProcess;
		public ProcessFlowElement SysCultureDeletedEventSubProcess {
			get {
				return _sysCultureDeletedEventSubProcess ?? (_sysCultureDeletedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SysCultureDeletedEventSubProcess",
					SchemaElementUId = new Guid("a48de969-1568-48b1-aaff-3fffd960bc92"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysCultureDeletedStartMessage;
		public ProcessFlowElement SysCultureDeletedStartMessage {
			get {
				return _sysCultureDeletedStartMessage ?? (_sysCultureDeletedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysCultureDeletedStartMessage",
					SchemaElementUId = new Guid("f0bb7779-7e4b-4b9c-b6ef-fc4612f871fc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _sysCultureDeletedScriptTask;
		public ProcessScriptTask SysCultureDeletedScriptTask {
			get {
				return _sysCultureDeletedScriptTask ?? (_sysCultureDeletedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SysCultureDeletedScriptTask",
					SchemaElementUId = new Guid("417b649a-0020-49ce-a0b0-7ea51e3ad63f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SysCultureDeletedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _sysCultureInsertedEventSubProcess;
		public ProcessFlowElement SysCultureInsertedEventSubProcess {
			get {
				return _sysCultureInsertedEventSubProcess ?? (_sysCultureInsertedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SysCultureInsertedEventSubProcess",
					SchemaElementUId = new Guid("0e047308-c85b-45a7-b520-cc9d38d85f07"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysCultureInsertedStartMessage;
		public ProcessFlowElement SysCultureInsertedStartMessage {
			get {
				return _sysCultureInsertedStartMessage ?? (_sysCultureInsertedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysCultureInsertedStartMessage",
					SchemaElementUId = new Guid("24fa61f5-d7b8-4e24-a05f-00bae4e5930e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _sysCultureInsertedScriptTask;
		public ProcessScriptTask SysCultureInsertedScriptTask {
			get {
				return _sysCultureInsertedScriptTask ?? (_sysCultureInsertedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SysCultureInsertedScriptTask",
					SchemaElementUId = new Guid("09228bb8-07d0-4f76-a911-92297660ce4b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SysCultureInsertedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _sysCultureUpdatedEventSubProcess;
		public ProcessFlowElement SysCultureUpdatedEventSubProcess {
			get {
				return _sysCultureUpdatedEventSubProcess ?? (_sysCultureUpdatedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SysCultureUpdatedEventSubProcess",
					SchemaElementUId = new Guid("be9f8091-e648-4d74-bf5a-34dcccba8e7e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysCultureUpdatedStartMessage;
		public ProcessFlowElement SysCultureUpdatedStartMessage {
			get {
				return _sysCultureUpdatedStartMessage ?? (_sysCultureUpdatedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysCultureUpdatedStartMessage",
					SchemaElementUId = new Guid("d3cb8011-0958-4b27-ad4a-e2a0079e4c70"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _sysCultureUpdatedScriptTask;
		public ProcessScriptTask SysCultureUpdatedScriptTask {
			get {
				return _sysCultureUpdatedScriptTask ?? (_sysCultureUpdatedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SysCultureUpdatedScriptTask",
					SchemaElementUId = new Guid("2a72de0b-5404-4477-a60e-7cc5520dc409"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SysCultureUpdatedScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SysCultureUpdatingEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SysCultureUpdatingEventSubProcess };
			FlowElements[SysCultureUpdatingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SysCultureUpdatingScriptTask };
			FlowElements[SysCultureUpdatingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SysCultureUpdatingStartMessage };
			FlowElements[SysCultureDeletingEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SysCultureDeletingEventSubProcess };
			FlowElements[SysCultureDeletingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SysCultureDeletingStartMessage };
			FlowElements[SysCultureDeletingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SysCultureDeletingScriptTask };
			FlowElements[SysCultureDeletedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SysCultureDeletedEventSubProcess };
			FlowElements[SysCultureDeletedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SysCultureDeletedStartMessage };
			FlowElements[SysCultureDeletedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SysCultureDeletedScriptTask };
			FlowElements[SysCultureInsertedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SysCultureInsertedEventSubProcess };
			FlowElements[SysCultureInsertedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SysCultureInsertedStartMessage };
			FlowElements[SysCultureInsertedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SysCultureInsertedScriptTask };
			FlowElements[SysCultureUpdatedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SysCultureUpdatedEventSubProcess };
			FlowElements[SysCultureUpdatedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SysCultureUpdatedStartMessage };
			FlowElements[SysCultureUpdatedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SysCultureUpdatedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SysCultureUpdatingEventSubProcess":
						break;
					case "SysCultureUpdatingScriptTask":
						break;
					case "SysCultureUpdatingStartMessage":
						e.Context.QueueTasks.Enqueue("SysCultureUpdatingScriptTask");
						break;
					case "SysCultureDeletingEventSubProcess":
						break;
					case "SysCultureDeletingStartMessage":
						e.Context.QueueTasks.Enqueue("SysCultureDeletingScriptTask");
						break;
					case "SysCultureDeletingScriptTask":
						break;
					case "SysCultureDeletedEventSubProcess":
						break;
					case "SysCultureDeletedStartMessage":
						e.Context.QueueTasks.Enqueue("SysCultureDeletedScriptTask");
						break;
					case "SysCultureDeletedScriptTask":
						break;
					case "SysCultureInsertedEventSubProcess":
						break;
					case "SysCultureInsertedStartMessage":
						e.Context.QueueTasks.Enqueue("SysCultureInsertedScriptTask");
						break;
					case "SysCultureInsertedScriptTask":
						break;
					case "SysCultureUpdatedEventSubProcess":
						break;
					case "SysCultureUpdatedStartMessage":
						e.Context.QueueTasks.Enqueue("SysCultureUpdatedScriptTask");
						break;
					case "SysCultureUpdatedScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SysCultureUpdatingStartMessage");
			ActivatedEventElements.Add("SysCultureDeletingStartMessage");
			ActivatedEventElements.Add("SysCultureDeletedStartMessage");
			ActivatedEventElements.Add("SysCultureInsertedStartMessage");
			ActivatedEventElements.Add("SysCultureUpdatedStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SysCultureUpdatingEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SysCultureUpdatingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysCultureUpdatingScriptTask";
					result = SysCultureUpdatingScriptTask.Execute(context, SysCultureUpdatingScriptTaskExecute);
					break;
				case "SysCultureUpdatingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysCultureUpdatingStartMessage";
					result = SysCultureUpdatingStartMessage.Execute(context);
					break;
				case "SysCultureDeletingEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SysCultureDeletingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysCultureDeletingStartMessage";
					result = SysCultureDeletingStartMessage.Execute(context);
					break;
				case "SysCultureDeletingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysCultureDeletingScriptTask";
					result = SysCultureDeletingScriptTask.Execute(context, SysCultureDeletingScriptTaskExecute);
					break;
				case "SysCultureDeletedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SysCultureDeletedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysCultureDeletedStartMessage";
					result = SysCultureDeletedStartMessage.Execute(context);
					break;
				case "SysCultureDeletedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysCultureDeletedScriptTask";
					result = SysCultureDeletedScriptTask.Execute(context, SysCultureDeletedScriptTaskExecute);
					break;
				case "SysCultureInsertedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SysCultureInsertedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysCultureInsertedStartMessage";
					result = SysCultureInsertedStartMessage.Execute(context);
					break;
				case "SysCultureInsertedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysCultureInsertedScriptTask";
					result = SysCultureInsertedScriptTask.Execute(context, SysCultureInsertedScriptTaskExecute);
					break;
				case "SysCultureUpdatedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SysCultureUpdatedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysCultureUpdatedStartMessage";
					result = SysCultureUpdatedStartMessage.Execute(context);
					break;
				case "SysCultureUpdatedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysCultureUpdatedScriptTask";
					result = SysCultureUpdatedScriptTask.Execute(context, SysCultureUpdatedScriptTaskExecute);
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

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "IsChangedColumnName":
					IsChangedColumnName = reader.GetValue<System.String>();
				break;
				case "VerificationColumnName":
					VerificationColumnName = reader.GetValue<System.String>();
				break;
				case "TranslationColumnName":
					TranslationColumnName = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool SysCultureUpdatingScriptTaskExecute(ProcessExecutingContext context) {
			return OnSysCultureUpdating(context);
		}

		public virtual bool SysCultureDeletingScriptTaskExecute(ProcessExecutingContext context) {
			return OnSysCultureDeleting(context);
		}

		public virtual bool SysCultureDeletedScriptTaskExecute(ProcessExecutingContext context) {
			return OnSysCultureDeleted(context);
		}

		public virtual bool SysCultureInsertedScriptTaskExecute(ProcessExecutingContext context) {
			return OnSysCultureInserted(context);
		}

		public virtual bool SysCultureUpdatedScriptTaskExecute(ProcessExecutingContext context) {
			return OnSysCultureUpdated(context);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SysCultureUpdating":
							if (ActivatedEventElements.Contains("SysCultureUpdatingStartMessage")) {
							context.QueueTasks.Enqueue("SysCultureUpdatingStartMessage");
						}
						break;
					case "SysCultureDeleting":
							if (ActivatedEventElements.Contains("SysCultureDeletingStartMessage")) {
							context.QueueTasks.Enqueue("SysCultureDeletingStartMessage");
						}
						break;
					case "SysCultureDeleted":
							if (ActivatedEventElements.Contains("SysCultureDeletedStartMessage")) {
							context.QueueTasks.Enqueue("SysCultureDeletedStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "SysCultureInserted":
							if (ActivatedEventElements.Contains("SysCultureInsertedStartMessage")) {
							context.QueueTasks.Enqueue("SysCultureInsertedStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "SysCultureUpdated":
							if (ActivatedEventElements.Contains("SysCultureUpdatedStartMessage")) {
							context.QueueTasks.Enqueue("SysCultureUpdatedStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("IsChangedColumnName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsChangedColumnName", IsChangedColumnName, null);
			}
			if (!HasMapping("VerificationColumnName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("VerificationColumnName", VerificationColumnName, null);
			}
			if (!HasMapping("TranslationColumnName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("TranslationColumnName", TranslationColumnName, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SysCulture_TranslationEventsProcess

	/// <exclude/>
	public class SysCulture_TranslationEventsProcess : SysCulture_TranslationEventsProcess<SysCulture>
	{

		public SysCulture_TranslationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysCulture_TranslationEventsProcess

	public partial class SysCulture_TranslationEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void SetName() {
			string code = GetLanguageCode(Entity.LanguageId);
			Entity.SetColumnValue("Name", code);
		}

		public virtual string GetLanguageCode(Guid id) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysLanguage");
			esq.AddColumn("Code");
			var entity = esq.GetEntity(UserConnection, id);
			return entity.GetTypedColumnValue<string>("Code");
		}

		public virtual void ResetSysAdminUnitCulture(Guid cultureId) {
			var primaryCultureId = (Guid)CoreSysSettings.GetValue(UserConnection, "PrimaryCulture");
			EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByName("VwSysAdminUnit");
			EntitySchemaColumn sysCultureColumn = entitySchema.Columns.GetByName("SysCulture");
			Update update = new Update(UserConnection, "VwSysAdminUnit");
			update
				.Set(sysCultureColumn.ColumnValueName, Column.Parameter(primaryCultureId))
				.Where(sysCultureColumn.ColumnValueName)
					.IsEqual(Column.Parameter(cultureId));
			update.Execute();
		}

		public virtual void DeleteTranslation() {
			Update update = new Update(UserConnection, "SysTranslation")
				.Set(TranslationColumnName, Column.Parameter(string.Empty))
				.Set(VerificationColumnName, Column.Parameter(false))
				.Set(IsChangedColumnName, Column.Parameter(false));
			update.Execute();
		}

		public virtual bool OnSysCultureDeleting(ProcessExecutingContext  context) {
			CheckCanDelete(Entity.PrimaryColumnValue);
			ResetSysAdminUnitCulture(Entity.PrimaryColumnValue);
			PrepareTranslationDeletingParameters(Entity.Index);
			return true;
		}

		public virtual bool OnSysCultureUpdating(ProcessExecutingContext  context) {
			SetName();
			if (!IsActive()) {
				ResetSysAdminUnitCulture(Entity.PrimaryColumnValue);
			}
			return true;
		}

		public virtual bool IsActive() {
			if (Entity.Active) {
				return true;
			}
			IEnumerable<EntityColumnValue> changedColumnValues = Entity.GetChangedColumnValues();
			EntityColumnValue activeColumnValue = changedColumnValues.Find(columnValue => columnValue.Name.Equals("Active"));
			if (activeColumnValue == null) {
				return true;
			}
			return false;
		}

		public virtual bool OnSysCultureDeleted(ProcessExecutingContext context) {
			DeleteTranslation();
			CoreSysCulture.ResetSysCulturesCache(UserConnection);
			return true;
		}

		public virtual void PrepareTranslationDeletingParameters(int cultureIndex) {
			ISysCultureInfoProvider sysCultureInfoProvider = ClassFactory.Get<SysCultureInfoProvider>(
				new ConstructorArgument("userConnection", UserConnection));
			ISysCultureInfo sysCultureInfo = sysCultureInfoProvider.Read(cultureIndex);
			TranslationColumnName = sysCultureInfo.TranslationColumnName;
			VerificationColumnName = sysCultureInfo.VerificationColumnName;
			IsChangedColumnName = sysCultureInfo.IsChangedColumnName;
		}

		public virtual void CheckCanDelete(Guid cultureId) {
			var primaryCultureId = (Guid)CoreSysSettings.GetValue(UserConnection, "PrimaryCulture");
			if (cultureId.Equals(primaryCultureId)) {
				throw new InvalidOperationException();
			}
		}

		public virtual bool OnSysCultureInserted(ProcessExecutingContext context) {
			CoreSysCulture.ResetSysCulturesCache(UserConnection);
			NormalizeDefaultCulture();
			return true;
		}

		public virtual bool OnSysCultureUpdated(ProcessExecutingContext context) {
			CoreSysCulture.ResetSysCulturesCache(UserConnection);
			NormalizeDefaultCulture();
			return true;
		}

		public virtual void NormalizeDefaultCulture() {
			var defaultCulture = Entity.GetTypedColumnValue<bool>("Default");
			if (defaultCulture) {
				var update = new Update(UserConnection, Entity.Schema.Name)
					.Set("Default", Column.Parameter(false))
					.Where("Id").IsNotEqual(Column.Parameter(Entity.PrimaryColumnValue))
					.And("Default").IsEqual(Column.Parameter(true));
				update.Execute();
			}
		}

		#endregion

	}

	#endregion

	#region Class: SysCultureEventsProcessSchema

	/// <exclude/>
	public class SysCultureEventsProcessSchema : Terrasoft.Configuration.SysCulture_Base_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public SysCultureEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysCultureEventsProcessSchema(SysCultureEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysCulture_TranslationEventsProcess";
			UId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44");
			CreatedInPackageId = new Guid("40d35dd0-7421-45de-9f03-34d8a7341beb");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateTranslationColumnNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("bcd0fca0-3ea8-48c8-9f3c-76feff73daf1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Name = @"TranslationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateVerificationColumnNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b8aed30e-4f1d-4e81-8204-4a75e355f274"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Name = @"VerificationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsChangedColumnNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b3b8c575-dbfa-4339-a119-562e75d68640"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Name = @"IsChangedColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateTranslationColumnNameParameter());
			Parameters.Add(CreateVerificationColumnNameParameter());
			Parameters.Add(CreateIsChangedColumnNameParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaSysCultureLaneSet = CreateSysCultureLaneSetLaneSet();
			LaneSets.Add(schemaSysCultureLaneSet);
			ProcessSchemaLane schemaSysCultureLane = CreateSysCultureLaneLane();
			schemaSysCultureLaneSet.Lanes.Add(schemaSysCultureLane);
			ProcessSchemaEventSubProcess syscultureupdatingeventsubprocess = CreateSysCultureUpdatingEventSubProcessEventSubProcess();
			FlowElements.Add(syscultureupdatingeventsubprocess);
			ProcessSchemaEventSubProcess sysculturedeletingeventsubprocess = CreateSysCultureDeletingEventSubProcessEventSubProcess();
			FlowElements.Add(sysculturedeletingeventsubprocess);
			ProcessSchemaEventSubProcess sysculturedeletedeventsubprocess = CreateSysCultureDeletedEventSubProcessEventSubProcess();
			FlowElements.Add(sysculturedeletedeventsubprocess);
			ProcessSchemaEventSubProcess syscultureinsertedeventsubprocess = CreateSysCultureInsertedEventSubProcessEventSubProcess();
			FlowElements.Add(syscultureinsertedeventsubprocess);
			ProcessSchemaEventSubProcess syscultureupdatedeventsubprocess = CreateSysCultureUpdatedEventSubProcessEventSubProcess();
			FlowElements.Add(syscultureupdatedeventsubprocess);
			ProcessSchemaScriptTask syscultureupdatingscripttask = CreateSysCultureUpdatingScriptTaskScriptTask();
			syscultureupdatingeventsubprocess.FlowElements.Add(syscultureupdatingscripttask);
			ProcessSchemaStartMessageEvent syscultureupdatingstartmessage = CreateSysCultureUpdatingStartMessageStartMessageEvent();
			syscultureupdatingeventsubprocess.FlowElements.Add(syscultureupdatingstartmessage);
			ProcessSchemaStartMessageEvent sysculturedeletingstartmessage = CreateSysCultureDeletingStartMessageStartMessageEvent();
			sysculturedeletingeventsubprocess.FlowElements.Add(sysculturedeletingstartmessage);
			ProcessSchemaScriptTask sysculturedeletingscripttask = CreateSysCultureDeletingScriptTaskScriptTask();
			sysculturedeletingeventsubprocess.FlowElements.Add(sysculturedeletingscripttask);
			ProcessSchemaStartMessageEvent sysculturedeletedstartmessage = CreateSysCultureDeletedStartMessageStartMessageEvent();
			sysculturedeletedeventsubprocess.FlowElements.Add(sysculturedeletedstartmessage);
			ProcessSchemaScriptTask sysculturedeletedscripttask = CreateSysCultureDeletedScriptTaskScriptTask();
			sysculturedeletedeventsubprocess.FlowElements.Add(sysculturedeletedscripttask);
			ProcessSchemaStartMessageEvent syscultureinsertedstartmessage = CreateSysCultureInsertedStartMessageStartMessageEvent();
			syscultureinsertedeventsubprocess.FlowElements.Add(syscultureinsertedstartmessage);
			ProcessSchemaScriptTask syscultureinsertedscripttask = CreateSysCultureInsertedScriptTaskScriptTask();
			syscultureinsertedeventsubprocess.FlowElements.Add(syscultureinsertedscripttask);
			ProcessSchemaStartMessageEvent syscultureupdatedstartmessage = CreateSysCultureUpdatedStartMessageStartMessageEvent();
			syscultureupdatedeventsubprocess.FlowElements.Add(syscultureupdatedstartmessage);
			ProcessSchemaScriptTask syscultureupdatedscripttask = CreateSysCultureUpdatedScriptTaskScriptTask();
			syscultureupdatedeventsubprocess.FlowElements.Add(syscultureupdatedscripttask);
			FlowElements.Add(CreateSysCultureUpdatingSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSysCultureDeletingSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSysCultureDeletedSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSysCultureUpdatingSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SysCultureUpdatingSequenceFlow",
				UId = new Guid("489db802-1de2-42f3-b773-31e9761efa54"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CreatedInPackageId = new Guid("cde2c5f9-9833-484d-a601-140e8f10df72"),
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0d6a48e3-0f75-4cb5-8cc2-2ac44d0b7d7e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9563ff96-fbeb-47ec-b863-db13ed157ec5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSysCultureDeletingSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SysCultureDeletingSequenceFlow",
				UId = new Guid("d609f0ee-ff04-4520-8633-57e09c3e71d4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CreatedInPackageId = new Guid("1ebee996-6478-42d7-a335-a5c9b0267cce"),
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("57b197c5-c301-4dc4-949a-3246316c3250"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9d74c5fc-517b-4b89-a033-6e3c560e0712"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSysCultureDeletedSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SysCultureDeletedSequenceFlow",
				UId = new Guid("43aecaa4-5d56-4991-857a-a294a22b1678"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9"),
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f0bb7779-7e4b-4b9c-b6ef-fc4612f871fc"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("417b649a-0020-49ce-a0b0-7ea51e3ad63f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("f1e67bd8-7fe5-4dbf-93b0-52e88e2674f3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CreatedInPackageId = new Guid("bd0f3d13-28b7-4ea4-9e77-5d8e78f971dc"),
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("24fa61f5-d7b8-4e24-a05f-00bae4e5930e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("09228bb8-07d0-4f76-a911-92297660ce4b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("d090cb43-66d1-496e-a199-d0e9623e2e2c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CreatedInPackageId = new Guid("bd0f3d13-28b7-4ea4-9e77-5d8e78f971dc"),
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d3cb8011-0958-4b27-ad4a-e2a0079e4c70"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2a72de0b-5404-4477-a60e-7cc5520dc409"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateSysCultureLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaSysCultureLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("b948a11d-81bf-4982-beb1-d60a7d836c94"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe"),
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Name = @"SysCultureLaneSet",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaSysCultureLaneSet;
		}

		protected virtual ProcessSchemaLane CreateSysCultureLaneLane() {
			ProcessSchemaLane schemaSysCultureLane = new ProcessSchemaLane(this) {
				UId = new Guid("cc0b4f4a-561b-4239-9b80-2d7df67f84b3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b948a11d-81bf-4982-beb1-d60a7d836c94"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe"),
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Name = @"SysCultureLane",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaSysCultureLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSysCultureUpdatingEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSysCultureUpdatingEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6274a749-6cd6-40d7-a0d8-1bb1516a655a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cc0b4f4a-561b-4239-9b80-2d7df67f84b3"),
				CreatedInOwnerSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CreatedInPackageId = new Guid("cde2c5f9-9833-484d-a601-140e8f10df72"),
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Name = @"SysCultureUpdatingEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 180),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(204, 127),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSysCultureUpdatingEventSubProcess;
		}

		protected virtual ProcessSchemaScriptTask CreateSysCultureUpdatingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9563ff96-fbeb-47ec-b863-db13ed157ec5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6274a749-6cd6-40d7-a0d8-1bb1516a655a"),
				CreatedInOwnerSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CreatedInPackageId = new Guid("cde2c5f9-9833-484d-a601-140e8f10df72"),
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Name = @"SysCultureUpdatingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(111, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,240,207,11,174,44,118,46,205,1,114,82,67,11,82,18,75,50,243,210,53,146,243,243,74,82,43,74,52,173,1,217,178,33,118,37,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysCultureUpdatingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0d6a48e3-0f75-4cb5-8cc2-2ac44d0b7d7e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6274a749-6cd6-40d7-a0d8-1bb1516a655a"),
				CreatedInOwnerSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CreatedInPackageId = new Guid("cde2c5f9-9833-484d-a601-140e8f10df72"),
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysCultureUpdating",
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Name = @"SysCultureUpdatingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(34, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSysCultureDeletingEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSysCultureDeletingEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0464738a-4230-45a1-a58b-f1142f3bf36d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cc0b4f4a-561b-4239-9b80-2d7df67f84b3"),
				CreatedInOwnerSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CreatedInPackageId = new Guid("1ebee996-6478-42d7-a335-a5c9b0267cce"),
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Name = @"SysCultureDeletingEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 330),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(204, 124),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSysCultureDeletingEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysCultureDeletingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("57b197c5-c301-4dc4-949a-3246316c3250"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0464738a-4230-45a1-a58b-f1142f3bf36d"),
				CreatedInOwnerSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CreatedInPackageId = new Guid("1ebee996-6478-42d7-a335-a5c9b0267cce"),
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysCultureDeleting",
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Name = @"SysCultureDeletingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSysCultureDeletingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9d74c5fc-517b-4b89-a033-6e3c560e0712"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0464738a-4230-45a1-a58b-f1142f3bf36d"),
				CreatedInOwnerSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CreatedInPackageId = new Guid("1ebee996-6478-42d7-a335-a5c9b0267cce"),
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Name = @"SysCultureDeletingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(100, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,240,207,11,174,44,118,46,205,1,114,82,93,82,115,82,75,50,243,210,53,146,243,243,74,82,43,74,52,173,1,253,215,64,173,37,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSysCultureDeletedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSysCultureDeletedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a48de969-1568-48b1-aaff-3fffd960bc92"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cc0b4f4a-561b-4239-9b80-2d7df67f84b3"),
				CreatedInOwnerSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9"),
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Name = @"SysCultureDeletedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(240, 330),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(204, 124),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSysCultureDeletedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysCultureDeletedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f0bb7779-7e4b-4b9c-b6ef-fc4612f871fc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a48de969-1568-48b1-aaff-3fffd960bc92"),
				CreatedInOwnerSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9"),
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysCultureDeleted",
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Name = @"SysCultureDeletedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 39),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSysCultureDeletedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("417b649a-0020-49ce-a0b0-7ea51e3ad63f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a48de969-1568-48b1-aaff-3fffd960bc92"),
				CreatedInOwnerSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9"),
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Name = @"SysCultureDeletedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(100, 25),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,240,207,11,174,44,118,46,205,1,114,82,93,82,115,82,75,82,83,52,146,243,243,74,82,43,74,52,173,1,198,186,54,165,36,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSysCultureInsertedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSysCultureInsertedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0e047308-c85b-45a7-b520-cc9d38d85f07"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cc0b4f4a-561b-4239-9b80-2d7df67f84b3"),
				CreatedInOwnerSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CreatedInPackageId = new Guid("bd0f3d13-28b7-4ea4-9e77-5d8e78f971dc"),
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Name = @"SysCultureInsertedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(240, 40),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(204, 122),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSysCultureInsertedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysCultureInsertedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("24fa61f5-d7b8-4e24-a05f-00bae4e5930e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0e047308-c85b-45a7-b520-cc9d38d85f07"),
				CreatedInOwnerSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CreatedInPackageId = new Guid("bd0f3d13-28b7-4ea4-9e77-5d8e78f971dc"),
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysCultureInserted",
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Name = @"SysCultureInsertedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 40),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSysCultureInsertedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("09228bb8-07d0-4f76-a911-92297660ce4b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0e047308-c85b-45a7-b520-cc9d38d85f07"),
				CreatedInOwnerSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CreatedInPackageId = new Guid("bd0f3d13-28b7-4ea4-9e77-5d8e78f971dc"),
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Name = @"SysCultureInsertedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(103, 26),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,240,207,11,174,44,118,46,205,1,114,82,61,243,138,83,139,74,82,83,52,146,243,243,74,82,43,74,52,173,1,181,26,53,96,37,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSysCultureUpdatedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSysCultureUpdatedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("be9f8091-e648-4d74-bf5a-34dcccba8e7e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cc0b4f4a-561b-4239-9b80-2d7df67f84b3"),
				CreatedInOwnerSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CreatedInPackageId = new Guid("bd0f3d13-28b7-4ea4-9e77-5d8e78f971dc"),
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Name = @"SysCultureUpdatedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(242, 180),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(200, 127),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSysCultureUpdatedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysCultureUpdatedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d3cb8011-0958-4b27-ad4a-e2a0079e4c70"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("be9f8091-e648-4d74-bf5a-34dcccba8e7e"),
				CreatedInOwnerSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CreatedInPackageId = new Guid("bd0f3d13-28b7-4ea4-9e77-5d8e78f971dc"),
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysCultureUpdated",
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Name = @"SysCultureUpdatedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(27, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSysCultureUpdatedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2a72de0b-5404-4477-a60e-7cc5520dc409"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("be9f8091-e648-4d74-bf5a-34dcccba8e7e"),
				CreatedInOwnerSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CreatedInPackageId = new Guid("bd0f3d13-28b7-4ea4-9e77-5d8e78f971dc"),
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Name = @"SysCultureUpdatedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(102, 27),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,240,207,11,174,44,118,46,205,1,114,82,67,11,82,18,75,82,83,52,146,243,243,74,82,43,74,52,173,1,236,72,154,127,36,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSetNameMethod());
			Methods.Add(CreateGetLanguageCodeMethod());
			Methods.Add(CreateResetSysAdminUnitCultureMethod());
			Methods.Add(CreateDeleteTranslationMethod());
			Methods.Add(CreateOnSysCultureDeletingMethod());
			Methods.Add(CreateOnSysCultureUpdatingMethod());
			Methods.Add(CreateIsActiveMethod());
			Methods.Add(CreateOnSysCultureDeletedMethod());
			Methods.Add(CreatePrepareTranslationDeletingParametersMethod());
			Methods.Add(CreateCheckCanDeleteMethod());
			Methods.Add(CreateOnSysCultureInsertedMethod());
			Methods.Add(CreateOnSysCultureUpdatedMethod());
			Methods.Add(CreateNormalizeDefaultCultureMethod());
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
				UId = new Guid("e36c1c49-392a-467c-9b41-9228fed41905"),
				Name = "Terrasoft.Core.Configuration.SysSettings",
				Alias = "CoreSysSettings",
				CreatedInPackageId = new Guid("042e9c40-f908-4dbc-8700-38ab7dc9d26a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d5bb3512-71e0-482a-9c7e-16bf22c586b7"),
				Name = "Terrasoft.Nui.ServiceModel.DataContract",
				Alias = "DataContract",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7e60571c-89c0-4463-90d5-fe82bbcecf2e"),
				Name = "Terrasoft.Configuration.Translation",
				Alias = "",
				CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b261d1c9-cc98-44e8-aabd-7806d1dc26ed"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fa1a3634-2ea3-48c1-bd5f-1c8500b044b4"),
				Name = "Terrasoft.Core.Configuration.SysCulture",
				Alias = "CoreSysCulture",
				CreatedInPackageId = new Guid("bd0f3d13-28b7-4ea4-9e77-5d8e78f971dc")
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

		protected virtual SchemaMethod CreateSetNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cac4843c-3e85-448d-b68d-a3c1c86f3b1c"),
				Name = "SetName",
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				CreatedInPackageId = new Guid("cde2c5f9-9833-484d-a601-140e8f10df72"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,46,41,202,204,75,87,72,206,79,73,85,176,85,112,79,45,241,73,204,75,47,77,76,79,117,6,138,104,184,230,149,100,150,84,234,193,196,60,83,52,173,185,160,98,193,169,37,206,249,57,165,185,121,97,137,57,165,169,26,74,126,137,185,169,74,58,96,131,52,173,1,36,235,232,199,86,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetLanguageCodeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e676d2d7-c330-4095-8a97-5985877b1c35"),
				Name = "GetLanguageCode",
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				CreatedInPackageId = new Guid("7f83dd52-6610-4ad2-b4da-cde5aa69885c"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d76966cf-0933-4fbb-945f-e61dafa1928c"),
				Name = "id",
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("7f83dd52-6610-4ad2-b4da-cde5aa69885c")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,141,205,10,194,48,16,6,239,62,197,146,83,133,210,23,240,7,36,136,23,61,72,213,123,104,150,24,104,55,186,73,42,121,123,147,90,68,60,238,50,223,204,168,24,208,63,97,3,132,47,216,83,176,33,181,221,29,7,117,142,200,169,186,122,100,233,136,176,11,214,81,243,11,156,20,41,131,92,131,104,147,63,42,50,49,159,98,185,90,100,95,179,211,90,186,62,14,84,9,233,244,244,30,75,106,218,231,90,97,14,24,62,190,191,74,13,86,103,158,49,68,166,121,82,224,75,122,224,108,189,169,62,226,218,7,182,100,182,223,196,27,125,234,61,73,205,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateResetSysAdminUnitCultureMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("dba15bdd-2da9-4239-893a-558fba7bc673"),
				Name = "ResetSysAdminUnitCulture",
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				CreatedInPackageId = new Guid("1ebee996-6478-42d7-a335-a5c9b0267cce"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("767c9bab-b1c8-4ed4-8895-e16d9fcec696"),
				Name = "cultureId",
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("1ebee996-6478-42d7-a335-a5c9b0267cce")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,193,110,131,48,12,134,207,237,83,88,156,130,84,229,5,42,14,27,66,21,135,77,149,16,221,217,2,171,141,4,166,75,156,117,188,253,66,161,91,129,195,78,145,127,217,223,255,219,249,66,11,87,107,90,180,125,234,27,241,150,242,26,18,80,7,111,234,56,237,44,21,189,43,72,196,240,217,233,3,201,9,27,79,170,116,100,211,142,153,42,49,29,239,32,58,206,16,81,188,223,102,44,70,250,162,186,80,139,64,207,69,2,243,113,253,220,250,134,140,103,178,131,85,206,78,144,43,122,237,223,177,37,21,157,110,33,203,75,221,26,46,217,200,210,35,237,26,223,50,184,222,77,33,38,33,153,153,235,81,189,175,242,224,22,191,35,3,179,188,214,40,4,126,124,18,96,186,193,168,173,183,94,39,26,199,182,27,29,110,166,150,89,38,243,251,9,7,235,29,76,250,17,109,40,133,172,90,126,69,28,7,214,199,133,44,253,75,11,157,27,157,187,236,211,99,163,86,224,234,143,248,72,169,179,111,170,124,216,43,222,255,0,67,42,235,79,6,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDeleteTranslationMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8d2ab901-f4c5-4879-b25c-e53ad0c8d9ea"),
				Name = "DeleteTranslation",
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,143,189,10,194,48,20,133,103,251,20,161,83,2,37,47,80,156,66,7,23,17,106,220,47,233,109,13,36,183,37,63,104,223,222,106,80,220,116,58,231,124,240,13,71,47,3,36,100,185,196,158,17,222,152,126,13,174,35,6,53,19,161,73,118,166,134,213,253,26,207,1,40,58,120,130,90,84,59,217,99,226,95,76,205,46,123,58,130,199,134,149,46,79,16,182,153,48,240,152,130,165,73,118,126,73,171,120,203,23,12,118,180,230,183,61,130,139,248,209,14,81,93,129,38,28,254,113,218,170,220,147,221,29,77,222,158,137,246,1,252,111,92,36,247,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnSysCultureDeletingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d8d0047b-a96c-4c63-abe1-4116fe7a0413"),
				Name = "OnSysCultureDeleting",
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				CreatedInPackageId = new Guid("5bb0d1bd-fb48-4884-8a1c-84058bcf48c3"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f542d331-5214-438c-bd04-aef992c3f436"),
				Name = "context",
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext ",
				CreatedInPackageId = new Guid("5bb0d1bd-fb48-4884-8a1c-84058bcf48c3")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,205,59,14,2,49,12,69,209,158,85,80,66,195,6,166,66,25,10,186,136,95,111,205,60,129,133,227,65,142,45,145,221,19,9,209,178,128,123,110,122,96,122,38,210,17,2,199,230,160,206,222,118,217,184,144,181,180,72,20,189,145,4,182,195,234,132,10,63,183,186,159,11,235,85,217,83,136,135,253,143,178,225,69,134,139,145,86,33,231,229,123,98,189,103,50,42,253,105,245,7,28,117,198,187,55,134,206,234,218,45,48,124,0,73,86,110,124,160,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnSysCultureUpdatingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9485ce2d-68ef-4843-b3a1-91d96d52612d"),
				Name = "OnSysCultureUpdating",
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				CreatedInPackageId = new Guid("5bb0d1bd-fb48-4884-8a1c-84058bcf48c3"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("41cf5625-7df5-4f03-ad18-ad94210f3128"),
				Name = "context",
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext ",
				CreatedInPackageId = new Guid("5bb0d1bd-fb48-4884-8a1c-84058bcf48c3")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,241,75,204,77,213,208,180,230,202,76,83,208,80,244,44,118,76,46,201,44,3,10,104,42,84,115,113,6,165,22,167,150,4,87,22,59,166,228,102,230,133,230,101,150,56,151,230,148,148,22,165,106,184,230,149,100,150,84,234,5,20,101,230,38,22,85,58,231,231,148,230,230,133,37,230,148,166,2,13,170,229,42,74,5,42,202,83,40,41,42,77,181,6,0,218,113,97,177,98,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsActiveMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("42b0a0cb-8fd3-4bfb-8a19-adb1400335a1"),
				Name = "IsActive",
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				CreatedInPackageId = new Guid("5bb0d1bd-fb48-4884-8a1c-84058bcf48c3"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,143,193,10,194,48,16,68,207,230,43,150,158,146,75,126,160,70,144,82,197,139,71,239,177,221,106,32,221,98,154,21,68,252,119,131,45,24,104,143,59,59,188,153,113,29,200,154,162,139,47,189,111,162,123,162,130,183,216,4,140,28,8,98,96,44,197,71,156,106,226,30,131,189,122,220,78,230,106,240,220,211,197,122,198,29,52,119,75,55,108,51,109,4,3,51,245,136,177,90,254,165,42,197,130,4,246,215,32,87,204,26,92,31,28,181,178,201,109,169,196,255,212,103,219,163,174,31,108,253,40,139,105,86,161,82,162,75,99,87,50,12,16,123,191,54,124,62,187,4,194,242,11,130,44,184,141,43,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnSysCultureDeletedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8ccc53bf-7cff-42b1-b01b-a386bf348cb1"),
				Name = "OnSysCultureDeleted",
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				CreatedInPackageId = new Guid("5bb0d1bd-fb48-4884-8a1c-84058bcf48c3"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b02990f2-2708-4e55-9623-bb3308ab5cae"),
				Name = "context",
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("5bb0d1bd-fb48-4884-8a1c-84058bcf48c3")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,73,205,73,45,73,13,41,74,204,43,206,73,44,201,204,207,211,208,180,230,114,206,47,74,13,174,44,118,46,205,41,41,45,74,213,11,74,45,78,45,65,240,139,157,19,147,51,82,53,66,139,83,139,156,243,243,242,82,147,65,218,128,186,138,82,129,178,121,10,37,69,165,169,214,0,118,165,253,25,87,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePrepareTranslationDeletingParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("13ad553e-8efe-44e0-80fc-d1b8e9baa6d3"),
				Name = "PrepareTranslationDeletingParameters",
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				CreatedInPackageId = new Guid("5bb0d1bd-fb48-4884-8a1c-84058bcf48c3"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("09da0a94-36d1-44ba-b494-f7ba38516c9a"),
				Name = "cultureIndex",
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("5bb0d1bd-fb48-4884-8a1c-84058bcf48c3")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,143,203,10,194,48,16,69,215,246,43,74,87,45,72,127,160,42,72,64,233,70,196,215,62,36,83,13,164,19,152,73,212,254,189,233,194,69,53,232,118,238,185,135,59,237,113,96,17,172,15,4,45,118,110,79,238,110,52,80,206,233,243,50,23,86,50,111,164,242,142,134,122,11,126,145,22,172,202,108,134,240,200,133,67,246,20,70,124,77,215,208,3,250,178,8,12,20,3,4,229,141,195,98,158,159,39,135,170,106,178,118,170,253,216,19,119,164,7,214,7,144,186,84,239,64,195,51,186,78,36,145,173,28,213,194,217,208,227,78,246,240,165,168,147,88,147,93,128,76,103,212,223,122,154,139,159,176,184,73,188,130,254,85,78,64,205,11,247,45,24,44,155,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCheckCanDeleteMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c7b664c2-61dc-46ed-8e62-5cbe0da1c576"),
				Name = "CheckCanDelete",
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				CreatedInPackageId = new Guid("5bb0d1bd-fb48-4884-8a1c-84058bcf48c3"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("059876a8-de0c-457a-8fa1-2ed75aee2773"),
				Name = "cultureId",
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("5bb0d1bd-fb48-4884-8a1c-84058bcf48c3")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,205,177,10,194,48,16,128,225,217,62,197,209,41,1,233,11,136,83,40,165,147,66,209,61,36,167,30,196,36,189,36,173,69,124,119,237,224,160,219,63,125,255,164,25,34,211,93,243,162,138,203,133,177,183,176,7,209,21,178,82,5,198,97,73,3,230,76,254,154,154,14,243,89,187,130,226,148,144,85,240,30,77,166,224,183,80,31,127,136,90,238,42,186,128,48,95,177,105,199,162,93,18,255,39,41,225,89,109,242,141,195,12,30,103,232,253,164,29,217,67,68,214,171,220,62,12,198,53,196,71,124,189,1,197,102,39,63,172,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnSysCultureInsertedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7a6cf38c-a46a-4b38-9736-c1c4491351d7"),
				Name = "OnSysCultureInserted",
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				CreatedInPackageId = new Guid("bd0f3d13-28b7-4ea4-9e77-5d8e78f971dc"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ae118b90-e17e-45c1-857e-56d23edfde01"),
				Name = "context",
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("bd0f3d13-28b7-4ea4-9e77-5d8e78f971dc")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,47,74,13,174,44,118,46,205,41,41,45,74,213,11,74,45,78,45,65,240,139,157,19,147,51,82,53,66,139,83,139,156,243,243,242,82,147,75,50,243,243,52,173,185,252,242,139,114,19,115,50,171,82,93,82,211,18,129,74,161,202,53,128,82,69,169,64,86,158,66,73,81,105,170,53,0,114,35,248,32,93,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnSysCultureUpdatedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("18507726-4131-4afd-b3da-9445b5efd730"),
				Name = "OnSysCultureUpdated",
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				CreatedInPackageId = new Guid("bd0f3d13-28b7-4ea4-9e77-5d8e78f971dc"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("13395ca7-fb2a-462e-adae-e5135956dd7a"),
				Name = "context",
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				ModifiedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("bd0f3d13-28b7-4ea4-9e77-5d8e78f971dc")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,47,74,13,174,44,118,46,205,41,41,45,74,213,11,74,45,78,45,65,240,139,157,19,147,51,82,53,66,139,83,139,156,243,243,242,82,147,75,50,243,243,52,173,185,252,242,139,114,19,115,50,171,82,93,82,211,18,129,74,161,202,53,128,82,69,169,64,86,158,66,73,81,105,170,53,0,114,35,248,32,93,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateNormalizeDefaultCultureMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2a66354d-a4b5-4a1a-b2c5-6e2c2c1bf5ca"),
				Name = "NormalizeDefaultCulture",
				CreatedInSchemaUId = new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"),
				CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,143,205,138,194,64,16,132,207,201,83,12,57,205,128,204,11,248,3,146,13,139,23,17,252,59,183,153,14,6,38,51,110,167,71,13,226,187,59,26,151,85,100,15,125,232,166,234,171,174,35,144,48,88,65,176,156,199,9,132,98,44,10,199,53,119,250,27,121,213,29,208,228,222,134,198,109,192,6,28,237,188,183,19,153,125,245,150,76,13,211,186,18,242,157,160,196,37,77,142,17,28,14,6,248,14,116,120,18,235,199,34,215,45,82,238,157,195,146,107,239,6,191,89,203,114,143,13,232,57,52,168,210,36,209,75,228,191,148,129,232,95,208,11,160,40,96,36,89,129,109,81,61,164,219,61,18,202,108,102,50,165,103,237,220,115,241,19,192,202,15,203,51,105,65,117,3,212,189,148,234,49,83,103,94,122,69,210,63,24,166,187,99,152,38,125,59,93,156,177,12,177,88,60,93,111,117,5,4,3,78,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysCultureEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aea3d633-21c9-482b-9dda-c12f73f59c44"));
		}

		#endregion

	}

	#endregion


	#region Class: SysCultureEventsProcess

	/// <exclude/>
	public class SysCultureEventsProcess : SysCulture_TranslationEventsProcess
	{

		public SysCultureEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

