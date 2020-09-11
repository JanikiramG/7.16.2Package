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
	using System.Runtime.Remoting;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.EntitySynchronization;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.ImageAPI;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Contact_Mobile_TerrasoftSchema

	/// <exclude/>
	public class Contact_Mobile_TerrasoftSchema : Terrasoft.Configuration.Contact_Base_TerrasoftSchema
	{

		#region Constructors: Public

		public Contact_Mobile_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Contact_Mobile_TerrasoftSchema(Contact_Mobile_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Contact_Mobile_TerrasoftSchema(Contact_Mobile_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("f9ede072-a4c8-47ed-8ab0-30a8f7150d18");
			Name = "Contact_Mobile_Terrasoft";
			ParentSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			ExtendParent = true;
			CreatedInPackageId = new Guid("b8cfc307-6cc7-46a0-adc5-c5052e6561f5");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateContact_Mobile_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateContact_Mobile_TerrasoftEventsProcessSchema() {
			var schema = new Contact_Mobile_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Contact_Mobile_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Contact_MobileEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Contact_Mobile_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Contact_Mobile_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f9ede072-a4c8-47ed-8ab0-30a8f7150d18"));
		}

		#endregion

	}

	#endregion

	#region Class: Contact_Mobile_Terrasoft

	/// <summary>
	/// Contact.
	/// </summary>
	public class Contact_Mobile_Terrasoft : Terrasoft.Configuration.Contact_Base_Terrasoft
	{

		#region Constructors: Public

		public Contact_Mobile_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contact_Mobile_Terrasoft";
		}

		public Contact_Mobile_Terrasoft(Contact_Mobile_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Contact_MobileEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Contact_Mobile_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Contact_Mobile_TerrasoftDeleting", e);
			Inserting += (s, e) => ThrowEvent("Contact_Mobile_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Contact_Mobile_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Contact_Mobile_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Contact_Mobile_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Contact_Mobile_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Contact_MobileEventsProcess

	/// <exclude/>
	public partial class Contact_MobileEventsProcess<TEntity> : Terrasoft.Configuration.Contact_BaseEventsProcess<TEntity> where TEntity : Contact_Mobile_Terrasoft
	{

		public Contact_MobileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Contact_MobileEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f9ede072-a4c8-47ed-8ab0-30a8f7150d18");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool PhotoHasChanged {
			get;
			set;
		}

		private ProcessFlowElement _afterContactSavedSubProcess;
		public ProcessFlowElement AfterContactSavedSubProcess {
			get {
				return _afterContactSavedSubProcess ?? (_afterContactSavedSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "AfterContactSavedSubProcess",
					SchemaElementUId = new Guid("2c97aaf4-5182-4b15-b835-75ec33ee5521"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _afterContactSavedScriptTask;
		public ProcessScriptTask AfterContactSavedScriptTask {
			get {
				return _afterContactSavedScriptTask ?? (_afterContactSavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AfterContactSavedScriptTask",
					SchemaElementUId = new Guid("3c54a5d6-8af4-404e-9d53-69c1edc927e0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AfterContactSavedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _afterContactSaved;
		public ProcessFlowElement AfterContactSaved {
			get {
				return _afterContactSaved ?? (_afterContactSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AfterContactSaved",
					SchemaElementUId = new Guid("1865f3ed-b02b-4930-bbf0-b4cf6905c009"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _beforeContactSavingScriptTaskSubProcess;
		public ProcessFlowElement BeforeContactSavingScriptTaskSubProcess {
			get {
				return _beforeContactSavingScriptTaskSubProcess ?? (_beforeContactSavingScriptTaskSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BeforeContactSavingScriptTaskSubProcess",
					SchemaElementUId = new Guid("5ad7c733-cd63-4655-bf51-8687d8ef19bf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _beforeContactSaving;
		public ProcessFlowElement BeforeContactSaving {
			get {
				return _beforeContactSaving ?? (_beforeContactSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BeforeContactSaving",
					SchemaElementUId = new Guid("278bfb7b-88df-4a5f-a4f2-47138e41c417"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _beforeContactSavingScriptTask;
		public ProcessScriptTask BeforeContactSavingScriptTask {
			get {
				return _beforeContactSavingScriptTask ?? (_beforeContactSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BeforeContactSavingScriptTask",
					SchemaElementUId = new Guid("9b206c93-d7ce-4779-9555-54f2b5881509"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BeforeContactSavingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[AfterContactSavedSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { AfterContactSavedSubProcess };
			FlowElements[AfterContactSavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AfterContactSavedScriptTask };
			FlowElements[AfterContactSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { AfterContactSaved };
			FlowElements[BeforeContactSavingScriptTaskSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BeforeContactSavingScriptTaskSubProcess };
			FlowElements[BeforeContactSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { BeforeContactSaving };
			FlowElements[BeforeContactSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BeforeContactSavingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "AfterContactSavedSubProcess":
						break;
					case "AfterContactSavedScriptTask":
						break;
					case "AfterContactSaved":
						e.Context.QueueTasks.Enqueue("AfterContactSavedScriptTask");
						break;
					case "BeforeContactSavingScriptTaskSubProcess":
						break;
					case "BeforeContactSaving":
						e.Context.QueueTasks.Enqueue("BeforeContactSavingScriptTask");
						break;
					case "BeforeContactSavingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("AfterContactSaved");
			ActivatedEventElements.Add("BeforeContactSaving");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "AfterContactSavedSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "AfterContactSavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AfterContactSavedScriptTask";
					result = AfterContactSavedScriptTask.Execute(context, AfterContactSavedScriptTaskExecute);
					break;
				case "AfterContactSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "AfterContactSaved";
					result = AfterContactSaved.Execute(context);
					break;
				case "BeforeContactSavingScriptTaskSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BeforeContactSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "BeforeContactSaving";
					result = BeforeContactSaving.Execute(context);
					break;
				case "BeforeContactSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BeforeContactSavingScriptTask";
					result = BeforeContactSavingScriptTask.Execute(context, BeforeContactSavingScriptTaskExecute);
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
				case "PhotoHasChanged":
					PhotoHasChanged = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool AfterContactSavedScriptTaskExecute(ProcessExecutingContext context) {
			if (PhotoHasChanged) {
				Guid photoId = Entity.GetTypedColumnValue<Guid>("PhotoId");
				if (photoId != Guid.Empty) {
					ImageAPI imageApi = new ImageAPI(UserConnection);
					ImageData imageData = imageApi.Get(photoId);
					if (imageData.Stream.Length == 0) {
						imageApi.Save(imageData.PreviewStream, photoId);
					} else {
						imageApi.SaveThumbnail(photoId, 256, 256, null, 75);
					}
				}
			}
			return true;
		}

		public virtual bool BeforeContactSavingScriptTaskExecute(ProcessExecutingContext context) {
			PhotoHasChanged = Entity.GetChangedColumnValues().ToArray().Any(x => x.Name == "PhotoId");
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Contact_Mobile_TerrasoftSaved":
							if (ActivatedEventElements.Contains("AfterContactSaved")) {
							context.QueueTasks.Enqueue("AfterContactSaved");
							ProcessQueue(context);
							return;
						}
						break;
					case "Contact_Mobile_TerrasoftSaving":
							if (ActivatedEventElements.Contains("BeforeContactSaving")) {
							context.QueueTasks.Enqueue("BeforeContactSaving");
							ProcessQueue(context);
							return;
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("PhotoHasChanged") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("PhotoHasChanged", PhotoHasChanged, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: Contact_MobileEventsProcess

	/// <exclude/>
	public class Contact_MobileEventsProcess : Contact_MobileEventsProcess<Contact_Mobile_Terrasoft>
	{

		public Contact_MobileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Contact_MobileEventsProcess

	public partial class Contact_MobileEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: Contact_Mobile_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Contact_Mobile_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Contact_Base_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Contact_Mobile_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Contact_Mobile_TerrasoftEventsProcessSchema(Contact_Mobile_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Contact_MobileEventsProcess";
			UId = new Guid("dd144634-5c4a-4630-949a-5a6f3829049a");
			CreatedInPackageId = new Guid("b8cfc307-6cc7-46a0-adc5-c5052e6561f5");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreatePhotoHasChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("03b67d93-e331-4721-b5d6-1dd8d57aa5e5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("dd144634-5c4a-4630-949a-5a6f3829049a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("dd144634-5c4a-4630-949a-5a6f3829049a"),
				Name = @"PhotoHasChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreatePhotoHasChangedParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess aftercontactsavedsubprocess = CreateAfterContactSavedSubProcessEventSubProcess();
			FlowElements.Add(aftercontactsavedsubprocess);
			ProcessSchemaEventSubProcess beforecontactsavingscripttasksubprocess = CreateBeforeContactSavingScriptTaskSubProcessEventSubProcess();
			FlowElements.Add(beforecontactsavingscripttasksubprocess);
			ProcessSchemaScriptTask aftercontactsavedscripttask = CreateAfterContactSavedScriptTaskScriptTask();
			aftercontactsavedsubprocess.FlowElements.Add(aftercontactsavedscripttask);
			ProcessSchemaStartMessageEvent aftercontactsaved = CreateAfterContactSavedStartMessageEvent();
			aftercontactsavedsubprocess.FlowElements.Add(aftercontactsaved);
			ProcessSchemaStartMessageEvent beforecontactsaving = CreateBeforeContactSavingStartMessageEvent();
			beforecontactsavingscripttasksubprocess.FlowElements.Add(beforecontactsaving);
			ProcessSchemaScriptTask beforecontactsavingscripttask = CreateBeforeContactSavingScriptTaskScriptTask();
			beforecontactsavingscripttasksubprocess.FlowElements.Add(beforecontactsavingscripttask);
			FlowElements.Add(CreateMobileSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateMobileSequenceFlow3SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateMobileSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "MobileSequenceFlow2",
				UId = new Guid("fd448560-5fc8-4bf6-9ebc-d353e10e40fd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("e30c1ce8-20e8-4007-a817-82094f89b177"),
				CreatedInSchemaUId = new Guid("dd144634-5c4a-4630-949a-5a6f3829049a"),
				CurveCenterPosition = new Point(201, 95),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("dd144634-5c4a-4630-949a-5a6f3829049a"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1865f3ed-b02b-4930-bbf0-b4cf6905c009"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3c54a5d6-8af4-404e-9d53-69c1edc927e0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateMobileSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "MobileSequenceFlow3",
				UId = new Guid("2719a48a-db5d-475a-91b5-1c4d7fa23191"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("e30c1ce8-20e8-4007-a817-82094f89b177"),
				CreatedInSchemaUId = new Guid("dd144634-5c4a-4630-949a-5a6f3829049a"),
				CurveCenterPosition = new Point(209, 287),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("dd144634-5c4a-4630-949a-5a6f3829049a"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("278bfb7b-88df-4a5f-a4f2-47138e41c417"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9b206c93-d7ce-4779-9555-54f2b5881509"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("2888208c-39df-47af-99da-fa5d3325249c"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("b8cfc307-6cc7-46a0-adc5-c5052e6561f5"),
				CreatedInSchemaUId = new Guid("dd144634-5c4a-4630-949a-5a6f3829049a"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("dd144634-5c4a-4630-949a-5a6f3829049a"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1211, 417),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("7505f8f4-b59d-4c4b-a238-5629789b2c97"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("2888208c-39df-47af-99da-fa5d3325249c"),
				CreatedInOwnerSchemaUId = new Guid("f9ede072-a4c8-47ed-8ab0-30a8f7150d18"),
				CreatedInPackageId = new Guid("b8cfc307-6cc7-46a0-adc5-c5052e6561f5"),
				CreatedInSchemaUId = new Guid("dd144634-5c4a-4630-949a-5a6f3829049a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("dd144634-5c4a-4630-949a-5a6f3829049a"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1182, 417),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateAfterContactSavedSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaAfterContactSavedSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2c97aaf4-5182-4b15-b835-75ec33ee5521"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7505f8f4-b59d-4c4b-a238-5629789b2c97"),
				CreatedInOwnerSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("b8cfc307-6cc7-46a0-adc5-c5052e6561f5"),
				CreatedInSchemaUId = new Guid("dd144634-5c4a-4630-949a-5a6f3829049a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("dd144634-5c4a-4630-949a-5a6f3829049a"),
				Name = @"AfterContactSavedSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(280, 172),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaAfterContactSavedSubProcess;
		}

		protected virtual ProcessSchemaScriptTask CreateAfterContactSavedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3c54a5d6-8af4-404e-9d53-69c1edc927e0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2c97aaf4-5182-4b15-b835-75ec33ee5521"),
				CreatedInOwnerSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("b8cfc307-6cc7-46a0-adc5-c5052e6561f5"),
				CreatedInSchemaUId = new Guid("dd144634-5c4a-4630-949a-5a6f3829049a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("dd144634-5c4a-4630-949a-5a6f3829049a"),
				Name = @"AfterContactSavedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(162, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,193,74,196,48,16,134,207,237,83,140,123,234,66,41,34,172,30,214,8,82,151,181,224,161,176,171,247,104,199,54,144,78,74,58,217,165,200,190,187,77,99,203,30,132,16,134,228,255,190,249,213,55,36,101,99,216,188,202,62,111,36,213,88,173,225,39,142,246,78,85,208,249,143,162,2,1,59,98,197,67,182,71,62,14,29,86,185,209,174,165,15,169,29,62,250,228,83,178,42,67,118,181,222,198,145,26,165,51,123,35,192,39,178,93,219,241,48,169,163,162,149,53,62,151,5,168,105,232,212,184,128,240,12,243,123,242,222,163,205,13,17,126,177,50,228,141,129,121,145,44,3,52,77,98,17,248,98,243,198,41,238,27,44,193,236,192,22,101,155,189,33,213,220,128,16,112,27,138,68,11,127,144,39,188,2,74,139,39,133,231,192,165,112,109,190,0,234,30,255,193,143,141,107,63,73,42,61,23,73,225,110,115,255,119,145,211,58,133,135,77,80,196,227,185,196,22,217,89,2,182,14,183,191,209,9,101,146,135,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAfterContactSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1865f3ed-b02b-4930-bbf0-b4cf6905c009"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2c97aaf4-5182-4b15-b835-75ec33ee5521"),
				CreatedInOwnerSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("e30c1ce8-20e8-4007-a817-82094f89b177"),
				CreatedInSchemaUId = new Guid("dd144634-5c4a-4630-949a-5a6f3829049a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ContactSaved",
				ModifiedInSchemaUId = new Guid("dd144634-5c4a-4630-949a-5a6f3829049a"),
				Name = @"AfterContactSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBeforeContactSavingScriptTaskSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBeforeContactSavingScriptTaskSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5ad7c733-cd63-4655-bf51-8687d8ef19bf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7505f8f4-b59d-4c4b-a238-5629789b2c97"),
				CreatedInOwnerSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("e30c1ce8-20e8-4007-a817-82094f89b177"),
				CreatedInSchemaUId = new Guid("dd144634-5c4a-4630-949a-5a6f3829049a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("dd144634-5c4a-4630-949a-5a6f3829049a"),
				Name = @"BeforeContactSavingScriptTaskSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 203),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(280, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBeforeContactSavingScriptTaskSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBeforeContactSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("278bfb7b-88df-4a5f-a4f2-47138e41c417"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5ad7c733-cd63-4655-bf51-8687d8ef19bf"),
				CreatedInOwnerSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("e30c1ce8-20e8-4007-a817-82094f89b177"),
				CreatedInSchemaUId = new Guid("dd144634-5c4a-4630-949a-5a6f3829049a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ContactSaving",
				ModifiedInSchemaUId = new Guid("dd144634-5c4a-4630-949a-5a6f3829049a"),
				Name = @"BeforeContactSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBeforeContactSavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9b206c93-d7ce-4779-9555-54f2b5881509"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5ad7c733-cd63-4655-bf51-8687d8ef19bf"),
				CreatedInOwnerSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("e30c1ce8-20e8-4007-a817-82094f89b177"),
				CreatedInSchemaUId = new Guid("dd144634-5c4a-4630-949a-5a6f3829049a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("dd144634-5c4a-4630-949a-5a6f3829049a"),
				Name = @"BeforeContactSavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(148, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,200,200,47,201,247,72,44,118,206,72,204,75,79,77,81,176,85,112,205,43,201,44,169,212,115,79,45,129,138,57,231,231,148,230,230,133,37,230,148,166,22,107,104,234,133,228,59,22,21,37,86,2,89,142,121,149,26,21,10,182,118,10,21,122,126,137,185,169,10,182,182,10,74,1,32,243,60,83,148,52,173,121,185,138,82,75,74,139,242,20,74,138,74,83,173,1,240,186,134,58,104,0,0,0 }
			};
			
			return ScriptTask;
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
				CreatedInPackageId = new Guid("b8cfc307-6cc7-46a0-adc5-c5052e6561f5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("b8cfc307-6cc7-46a0-adc5-c5052e6561f5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("b8cfc307-6cc7-46a0-adc5-c5052e6561f5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("b8cfc307-6cc7-46a0-adc5-c5052e6561f5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("b8cfc307-6cc7-46a0-adc5-c5052e6561f5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("b8cfc307-6cc7-46a0-adc5-c5052e6561f5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("b8cfc307-6cc7-46a0-adc5-c5052e6561f5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("73bbc987-2ab8-4ce5-b0ec-c0299d1e72fc"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("b8cfc307-6cc7-46a0-adc5-c5052e6561f5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c6864213-e7e8-465d-9b94-a5a82f858e94"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("b8cfc307-6cc7-46a0-adc5-c5052e6561f5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3ae3ffad-15b4-47e6-a1e7-da480e16ae8a"),
				Name = "Terrasoft.Core.ImageAPI",
				Alias = "",
				CreatedInPackageId = new Guid("b8cfc307-6cc7-46a0-adc5-c5052e6561f5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0017f56e-396d-4e72-a989-2c9800690b07"),
				Name = "Terrasoft.Messaging.Common",
				Alias = "",
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("169a8f30-18f7-46d5-9a44-edcbb48f0929"),
				Name = "System.Runtime.Remoting",
				Alias = "",
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6cb575e2-395e-47ee-968f-9e85ebbb0e57"),
				Name = "System.Linq",
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
				UId = new Guid("03538de8-86d4-4eea-8c1d-8051bbb379ed"),
				Name = "Terrasoft.Configuration.EntitySynchronization",
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
			return new Contact_Mobile_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dd144634-5c4a-4630-949a-5a6f3829049a"));
		}

		#endregion

	}

	#endregion

}

