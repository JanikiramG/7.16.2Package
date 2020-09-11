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
	using System.Security;
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
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: BaseTag_Base_TerrasoftSchema

	/// <exclude/>
	[IsVirtual]
	public class BaseTag_Base_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public BaseTag_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BaseTag_Base_TerrasoftSchema(BaseTag_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BaseTag_Base_TerrasoftSchema(BaseTag_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9e3f203c-e905-4de5-9468-335b193f2439");
			RealUId = new Guid("9e3f203c-e905-4de5-9468-335b193f2439");
			Name = "BaseTag_Base_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
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
			if (Columns.FindByUId(new Guid("f2e0d52d-58a4-4d49-aa03-89f023007a40")) == null) {
				Columns.Add(CreateTypeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f2e0d52d-58a4-4d49-aa03-89f023007a40"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("10970fa5-3714-4d73-968c-4e411dd7d691"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("9e3f203c-e905-4de5-9468-335b193f2439"),
				ModifiedInSchemaUId = new Guid("9e3f203c-e905-4de5-9468-335b193f2439"),
				CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704"),
				IsSimpleLookup = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"8d7f6d6c-4ca5-4b43-bdd9-a5e01a582260"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("43733df0-6000-45de-861c-88d3b8821a46"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("9e3f203c-e905-4de5-9468-335b193f2439"),
				ModifiedInSchemaUId = new Guid("9e3f203c-e905-4de5-9468-335b193f2439"),
				CreatedInPackageId = new Guid("33fd549c-d822-4724-9446-a45b07d23a52")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseTag_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateBaseTag_Base_TerrasoftEventsProcessSchema() {
			var schema = new BaseTag_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BaseTag_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BaseTag_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BaseTag_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BaseTag_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9e3f203c-e905-4de5-9468-335b193f2439"));
		}

		#endregion

	}

	#endregion

	#region Class: BaseTag_Base_Terrasoft

	/// <summary>
	/// Base tag.
	/// </summary>
	public class BaseTag_Base_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public BaseTag_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BaseTag_Base_Terrasoft";
		}

		public BaseTag_Base_Terrasoft(BaseTag_Base_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private TagType _type;
		/// <summary>
		/// Tag type.
		/// </summary>
		public TagType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as TagType);
			}
		}

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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BaseTag_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BaseTag_Base_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("BaseTag_Base_TerrasoftDeleting", e);
			Inserting += (s, e) => ThrowEvent("BaseTag_Base_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("BaseTag_Base_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("BaseTag_Base_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("BaseTag_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseTag_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: BaseTag_BaseEventsProcess

	/// <exclude/>
	public partial class BaseTag_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : BaseTag_Base_Terrasoft
	{

		public BaseTag_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseTag_BaseEventsProcess";
			SchemaUId = new Guid("9e3f203c-e905-4de5-9468-335b193f2439");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9e3f203c-e905-4de5-9468-335b193f2439");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _baseTagEventSubProcess;
		public ProcessFlowElement BaseTagEventSubProcess {
			get {
				return _baseTagEventSubProcess ?? (_baseTagEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseTagEventSubProcess",
					SchemaElementUId = new Guid("6dbf5dda-4d64-4099-884a-494cd8f0c095"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseTagInsertingStartMessage;
		public ProcessFlowElement BaseTagInsertingStartMessage {
			get {
				return _baseTagInsertingStartMessage ?? (_baseTagInsertingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseTagInsertingStartMessage",
					SchemaElementUId = new Guid("a1b270cb-8f4b-4c6e-b4e1-b9f9b340d7ff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseTagSavingStartMessage;
		public ProcessFlowElement BaseTagSavingStartMessage {
			get {
				return _baseTagSavingStartMessage ?? (_baseTagSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseTagSavingStartMessage",
					SchemaElementUId = new Guid("b8e4b061-3d27-4de5-b413-6456b12b2046"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseTagDeletingStartMessage;
		public ProcessFlowElement BaseTagDeletingStartMessage {
			get {
				return _baseTagDeletingStartMessage ?? (_baseTagDeletingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseTagDeletingStartMessage",
					SchemaElementUId = new Guid("ec4af0d1-59ee-437e-9c22-02846b20380f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _checkCanManageTagsScriptTask;
		public ProcessScriptTask CheckCanManageTagsScriptTask {
			get {
				return _checkCanManageTagsScriptTask ?? (_checkCanManageTagsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckCanManageTagsScriptTask",
					SchemaElementUId = new Guid("8aad90ac-cf62-4d8f-86f6-b492225d55aa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckCanManageTagsScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _baseTagOnSavedSubProcess;
		public ProcessFlowElement BaseTagOnSavedSubProcess {
			get {
				return _baseTagOnSavedSubProcess ?? (_baseTagOnSavedSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseTagOnSavedSubProcess",
					SchemaElementUId = new Guid("d0c19376-5f7e-406f-9882-6638ea199785"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseTagSavedStartMessage;
		public ProcessFlowElement BaseTagSavedStartMessage {
			get {
				return _baseTagSavedStartMessage ?? (_baseTagSavedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseTagSavedStartMessage",
					SchemaElementUId = new Guid("e8b4239f-7a04-462c-b2c3-afecdf60306d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _checkTagTypeAndGrantAdditionalRightsScript;
		public ProcessScriptTask CheckTagTypeAndGrantAdditionalRightsScript {
			get {
				return _checkTagTypeAndGrantAdditionalRightsScript ?? (_checkTagTypeAndGrantAdditionalRightsScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckTagTypeAndGrantAdditionalRightsScript",
					SchemaElementUId = new Guid("723ea0a4-edc3-4c98-b16e-06efc59d5608"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckTagTypeAndGrantAdditionalRightsScriptExecute,
				});
			}
		}

		private LocalizableString _changeTypeFailMsg;
		public LocalizableString ChangeTypeFailMsg {
			get {
				return _changeTypeFailMsg ?? (_changeTypeFailMsg = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ChangeTypeFailMsg.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[BaseTagEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseTagEventSubProcess };
			FlowElements[BaseTagInsertingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseTagInsertingStartMessage };
			FlowElements[BaseTagSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseTagSavingStartMessage };
			FlowElements[BaseTagDeletingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseTagDeletingStartMessage };
			FlowElements[CheckCanManageTagsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckCanManageTagsScriptTask };
			FlowElements[BaseTagOnSavedSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseTagOnSavedSubProcess };
			FlowElements[BaseTagSavedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseTagSavedStartMessage };
			FlowElements[CheckTagTypeAndGrantAdditionalRightsScript.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckTagTypeAndGrantAdditionalRightsScript };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "BaseTagEventSubProcess":
						break;
					case "BaseTagInsertingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckCanManageTagsScriptTask");
						break;
					case "BaseTagSavingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckCanManageTagsScriptTask");
						break;
					case "BaseTagDeletingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckCanManageTagsScriptTask");
						break;
					case "CheckCanManageTagsScriptTask":
						break;
					case "BaseTagOnSavedSubProcess":
						break;
					case "BaseTagSavedStartMessage":
						e.Context.QueueTasks.Enqueue("CheckTagTypeAndGrantAdditionalRightsScript");
						break;
					case "CheckTagTypeAndGrantAdditionalRightsScript":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("BaseTagInsertingStartMessage");
			ActivatedEventElements.Add("BaseTagSavingStartMessage");
			ActivatedEventElements.Add("BaseTagDeletingStartMessage");
			ActivatedEventElements.Add("BaseTagSavedStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "BaseTagEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BaseTagInsertingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseTagInsertingStartMessage";
					result = BaseTagInsertingStartMessage.Execute(context);
					break;
				case "BaseTagSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseTagSavingStartMessage";
					result = BaseTagSavingStartMessage.Execute(context);
					break;
				case "BaseTagDeletingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseTagDeletingStartMessage";
					result = BaseTagDeletingStartMessage.Execute(context);
					break;
				case "CheckCanManageTagsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckCanManageTagsScriptTask";
					result = CheckCanManageTagsScriptTask.Execute(context, CheckCanManageTagsScriptTaskExecute);
					break;
				case "BaseTagOnSavedSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BaseTagSavedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseTagSavedStartMessage";
					result = BaseTagSavedStartMessage.Execute(context);
					break;
				case "CheckTagTypeAndGrantAdditionalRightsScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckTagTypeAndGrantAdditionalRightsScript";
					result = CheckTagTypeAndGrantAdditionalRightsScript.Execute(context, CheckTagTypeAndGrantAdditionalRightsScriptExecute);
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

		public virtual bool CheckCanManageTagsScriptTaskExecute(ProcessExecutingContext context) {
			CheckCanManageTags();
			return true;
		}

		public virtual bool CheckTagTypeAndGrantAdditionalRightsScriptExecute(ProcessExecutingContext context) {
			CheckTagTypeAndGrantAdditionalRights();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "BaseTag_Base_TerrasoftInserting":
							if (ActivatedEventElements.Contains("BaseTagInsertingStartMessage")) {
							context.QueueTasks.Enqueue("BaseTagInsertingStartMessage");
						}
						break;
					case "BaseTag_Base_TerrasoftSaving":
							if (ActivatedEventElements.Contains("BaseTagSavingStartMessage")) {
							context.QueueTasks.Enqueue("BaseTagSavingStartMessage");
						}
						break;
					case "BaseTag_Base_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("BaseTagDeletingStartMessage")) {
							context.QueueTasks.Enqueue("BaseTagDeletingStartMessage");
						}
						break;
					case "BaseTag_Base_TerrasoftSaved":
							if (ActivatedEventElements.Contains("BaseTagSavedStartMessage")) {
							context.QueueTasks.Enqueue("BaseTagSavedStartMessage");
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

	#region Class: BaseTag_BaseEventsProcess

	/// <exclude/>
	public class BaseTag_BaseEventsProcess : BaseTag_BaseEventsProcess<BaseTag_Base_Terrasoft>
	{

		public BaseTag_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseTag_BaseEventsProcess

	public partial class BaseTag_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void CheckCanManageTags() {
			Guid typeOldId = Entity.GetTypedOldColumnValue<Guid>("TypeId");
			Guid typeId = Entity.GetTypedColumnValue<Guid>("TypeId");
			if (typeOldId != Guid.Empty && typeOldId != TSConfiguration.TagConsts.PrivateTagTypeUId && typeOldId != typeId) {
				throw new SecurityException(ChangeTypeFailMsg);
			}
			if (typeId == TSConfiguration.TagConsts.CorporateTagTypeUId) {
				UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageCorporateTags");
			}
			if (typeId == TSConfiguration.TagConsts.PublicTagTypeUId) {
				UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManagePublicTags");
			}
		}

		public virtual void CheckTagTypeAndGrantAdditionalRights() {
			Guid typeId = Entity.GetTypedColumnValue<Guid>("TypeId");
			if (typeId == TSConfiguration.TagConsts.CorporateTagTypeUId) {
				UserConnection.DBSecurityEngine.SetEntitySchemaRecordRightLevel(TSConfiguration.BaseConsts.AllEmployersSysAdminUnitUId, 
						Entity.Schema, Entity.PrimaryColumnValue, SchemaRecordRightLevels.All); 
			}
			if (typeId == TSConfiguration.TagConsts.PublicTagTypeUId) {
				UserConnection.DBSecurityEngine.SetEntitySchemaRecordRightLevel(TSConfiguration.BaseConsts.AllEmployersSysAdminUnitUId, 
						Entity.Schema, Entity.PrimaryColumnValue, SchemaRecordRightLevels.All);
			}
		}

		#endregion

	}

	#endregion

	#region Class: BaseTag_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class BaseTag_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public BaseTag_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseTag_Base_TerrasoftEventsProcessSchema(BaseTag_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseTag_BaseEventsProcess";
			UId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd");
			CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704");
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
			ProcessSchemaEventSubProcess basetageventsubprocess = CreateBaseTagEventSubProcessEventSubProcess();
			FlowElements.Add(basetageventsubprocess);
			ProcessSchemaEventSubProcess basetagonsavedsubprocess = CreateBaseTagOnSavedSubProcessEventSubProcess();
			FlowElements.Add(basetagonsavedsubprocess);
			ProcessSchemaStartMessageEvent basetaginsertingstartmessage = CreateBaseTagInsertingStartMessageStartMessageEvent();
			basetageventsubprocess.FlowElements.Add(basetaginsertingstartmessage);
			ProcessSchemaStartMessageEvent basetagsavingstartmessage = CreateBaseTagSavingStartMessageStartMessageEvent();
			basetageventsubprocess.FlowElements.Add(basetagsavingstartmessage);
			ProcessSchemaStartMessageEvent basetagdeletingstartmessage = CreateBaseTagDeletingStartMessageStartMessageEvent();
			basetageventsubprocess.FlowElements.Add(basetagdeletingstartmessage);
			ProcessSchemaScriptTask checkcanmanagetagsscripttask = CreateCheckCanManageTagsScriptTaskScriptTask();
			basetageventsubprocess.FlowElements.Add(checkcanmanagetagsscripttask);
			ProcessSchemaStartMessageEvent basetagsavedstartmessage = CreateBaseTagSavedStartMessageStartMessageEvent();
			basetagonsavedsubprocess.FlowElements.Add(basetagsavedstartmessage);
			ProcessSchemaScriptTask checktagtypeandgrantadditionalrightsscript = CreateCheckTagTypeAndGrantAdditionalRightsScriptScriptTask();
			basetagonsavedsubprocess.FlowElements.Add(checktagtypeandgrantadditionalrightsscript);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateChangeTypeFailMsgLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateChangeTypeFailMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3b957c26-aef9-4946-b756-c4d146576721"),
				Name = "ChangeTypeFailMsg",
				CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704"),
				CreatedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				ModifiedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("b2c7625c-40ea-4b15-8ca2-b33203e4080b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704"),
				CreatedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				CurveCenterPosition = new Point(184, 87),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a1b270cb-8f4b-4c6e-b4e1-b9f9b340d7ff"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8aad90ac-cf62-4d8f-86f6-b492225d55aa"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("5155bed7-77ea-41b0-bb70-22fa7aabf45e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704"),
				CreatedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				CurveCenterPosition = new Point(200, 117),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b8e4b061-3d27-4de5-b413-6456b12b2046"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8aad90ac-cf62-4d8f-86f6-b492225d55aa"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("53995fa7-524f-45e3-a3bb-9ab4bb3c8a0c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704"),
				CreatedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				CurveCenterPosition = new Point(195, 148),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ec4af0d1-59ee-437e-9c22-02846b20380f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8aad90ac-cf62-4d8f-86f6-b492225d55aa"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("6f7142c1-7052-4923-8e03-6e131dd778d1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("7ef175d1-30fa-42f5-9f26-d5b1d45b0001"),
				CreatedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				CurveCenterPosition = new Point(564, 112),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e8b4239f-7a04-462c-b2c3-afecdf60306d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("723ea0a4-edc3-4c98-b16e-06efc59d5608"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("cdb205c4-1b80-4f50-a15e-7e0985ff5a84"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704"),
				CreatedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1165, 352),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("03deeb28-d36f-43a9-814d-9972bcad809d"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("cdb205c4-1b80-4f50-a15e-7e0985ff5a84"),
				CreatedInOwnerSchemaUId = new Guid("9e3f203c-e905-4de5-9468-335b193f2439"),
				CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704"),
				CreatedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1136, 352),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBaseTagEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBaseTagEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6dbf5dda-4d64-4099-884a-494cd8f0c095"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("03deeb28-d36f-43a9-814d-9972bcad809d"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704"),
				CreatedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				Name = @"BaseTagEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(342, 217),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBaseTagEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseTagInsertingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a1b270cb-8f4b-4c6e-b4e1-b9f9b340d7ff"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6dbf5dda-4d64-4099-884a-494cd8f0c095"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704"),
				CreatedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BaseTagInserting",
				ModifiedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				Name = @"BaseTagInsertingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(28, 21),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseTagSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b8e4b061-3d27-4de5-b413-6456b12b2046"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6dbf5dda-4d64-4099-884a-494cd8f0c095"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704"),
				CreatedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BaseTagSaving",
				ModifiedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				Name = @"BaseTagSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 79),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseTagDeletingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ec4af0d1-59ee-437e-9c22-02846b20380f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6dbf5dda-4d64-4099-884a-494cd8f0c095"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704"),
				CreatedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BaseTagDeleting",
				ModifiedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				Name = @"BaseTagDeletingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(28, 140),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckCanManageTagsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8aad90ac-cf62-4d8f-86f6-b492225d55aa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6dbf5dda-4d64-4099-884a-494cd8f0c095"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704"),
				CreatedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				Name = @"CheckCanManageTagsScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(211, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,72,77,206,118,78,204,243,77,204,75,76,79,13,73,76,47,214,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,204,150,62,72,35,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBaseTagOnSavedSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBaseTagOnSavedSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d0c19376-5f7e-406f-9882-6638ea199785"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("03deeb28-d36f-43a9-814d-9972bcad809d"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("7ef175d1-30fa-42f5-9f26-d5b1d45b0001"),
				CreatedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				Name = @"BaseTagOnSavedSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(413, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(252, 217),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBaseTagOnSavedSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseTagSavedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e8b4239f-7a04-462c-b2c3-afecdf60306d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0c19376-5f7e-406f-9882-6638ea199785"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("7ef175d1-30fa-42f5-9f26-d5b1d45b0001"),
				CreatedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BaseTagSaved",
				ModifiedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				Name = @"BaseTagSavedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 79),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckTagTypeAndGrantAdditionalRightsScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("723ea0a4-edc3-4c98-b16e-06efc59d5608"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0c19376-5f7e-406f-9882-6638ea199785"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("7ef175d1-30fa-42f5-9f26-d5b1d45b0001"),
				CreatedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				Name = @"CheckTagTypeAndGrantAdditionalRightsScript",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(120, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,72,77,206,14,73,76,15,169,44,72,117,204,75,113,47,74,204,43,113,76,73,201,44,201,204,207,75,204,9,202,76,207,40,41,214,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,76,153,211,191,53,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateCheckCanManageTagsMethod());
			Methods.Add(CreateCheckTagTypeAndGrantAdditionalRightsMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1780b526-d514-4313-82bb-ccde3a076659"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2dbbf1ce-3aeb-46cb-91d2-fc61dcde5456"),
				Name = "System.Security",
				Alias = "",
				CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704")
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

		protected virtual SchemaMethod CreateCheckCanManageTagsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ca105b65-67ac-433f-9137-1cf573305510"),
				Name = "CheckCanManageTags",
				CreatedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				CreatedInPackageId = new Guid("7ef175d1-30fa-42f5-9f26-d5b1d45b0001"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,143,177,110,194,48,20,69,231,34,241,15,110,6,20,150,252,64,75,135,186,33,98,64,32,17,186,187,206,195,177,8,207,145,253,92,136,170,254,123,237,166,133,130,42,164,14,93,175,239,61,239,184,240,186,98,212,181,176,104,170,89,197,38,44,71,210,212,101,5,80,25,210,42,196,220,52,126,135,207,162,241,112,95,132,250,67,154,196,167,89,149,140,239,134,131,226,27,240,219,250,250,84,111,88,122,58,125,59,97,177,146,229,187,150,58,54,26,177,179,167,114,197,13,110,180,242,86,144,54,152,149,66,133,192,145,203,150,86,191,10,130,16,68,244,58,212,47,183,189,221,152,189,13,7,55,84,91,179,103,8,123,182,2,233,109,144,205,15,18,218,200,76,121,45,80,65,164,76,133,110,230,78,69,201,247,147,103,252,225,53,19,110,108,107,236,153,75,127,116,237,192,134,14,130,252,92,60,61,30,111,163,210,8,25,175,65,110,185,192,252,16,114,130,69,11,61,59,77,66,56,23,40,20,252,100,187,228,143,98,75,255,210,104,249,15,86,71,240,151,210,7,95,212,90,205,78,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCheckTagTypeAndGrantAdditionalRightsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e834b7f8-305a-4cd6-900c-712322df3d1b"),
				Name = "CheckTagTypeAndGrantAdditionalRights",
				CreatedInSchemaUId = new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"),
				CreatedInPackageId = new Guid("7ef175d1-30fa-42f5-9f26-d5b1d45b0001"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,144,189,106,195,64,16,132,107,25,252,14,135,43,9,132,94,192,118,192,86,132,48,164,48,62,41,253,69,183,150,23,238,71,220,143,225,8,121,247,108,100,27,66,72,145,58,237,48,179,223,206,180,17,37,11,105,130,131,100,91,214,152,128,33,85,45,132,142,36,89,91,21,181,121,21,42,194,166,37,227,83,190,234,102,235,170,88,47,23,120,102,249,35,185,101,29,175,173,57,227,24,157,8,104,77,213,137,145,4,31,124,85,91,55,89,82,129,164,175,120,127,144,5,123,95,46,178,222,131,35,143,129,97,78,60,239,57,12,209,209,3,141,25,209,64,197,33,220,30,226,195,5,180,56,193,96,157,60,225,120,9,47,112,5,149,255,68,238,133,135,59,115,167,84,163,39,101,19,56,207,147,223,73,141,166,55,24,136,93,50,66,103,217,189,234,237,116,249,104,126,116,168,133,75,223,138,151,236,119,250,204,40,214,116,236,227,239,83,28,227,155,194,225,63,238,64,51,124,2,0,88,128,212,75,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseTag_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c15a7212-db83-4ba3-b590-bda557ffc2fd"));
		}

		#endregion

	}

	#endregion

}

