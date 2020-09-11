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

	#region Class: MessagePublisherBySectionSchema

	/// <exclude/>
	public class MessagePublisherBySectionSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public MessagePublisherBySectionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MessagePublisherBySectionSchema(MessagePublisherBySectionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MessagePublisherBySectionSchema(MessagePublisherBySectionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1bd40929-9ab9-40ad-9af7-d6abcab85bf8");
			RealUId = new Guid("1bd40929-9ab9-40ad-9af7-d6abcab85bf8");
			Name = "MessagePublisherBySection";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("7c74fc90-4a57-4e68-9eda-fe0982d1250d");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("e182df32-2660-448d-b97e-ce6721de888c")) == null) {
				Columns.Add(CreateSectionColumn());
			}
			if (Columns.FindByUId(new Guid("fb377f13-6cad-4a71-9f5a-064d198cb667")) == null) {
				Columns.Add(CreateMessagePublisherColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSectionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e182df32-2660-448d-b97e-ce6721de888c"),
				Name = @"Section",
				ReferenceSchemaUId = new Guid("2b2ed767-0b4b-4a7b-9de2-d48e14a2c0c5"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1bd40929-9ab9-40ad-9af7-d6abcab85bf8"),
				ModifiedInSchemaUId = new Guid("1bd40929-9ab9-40ad-9af7-d6abcab85bf8"),
				CreatedInPackageId = new Guid("7c74fc90-4a57-4e68-9eda-fe0982d1250d")
			};
		}

		protected virtual EntitySchemaColumn CreateMessagePublisherColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fb377f13-6cad-4a71-9f5a-064d198cb667"),
				Name = @"MessagePublisher",
				ReferenceSchemaUId = new Guid("ab702f57-7428-4bae-8b60-25747782d3c3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1bd40929-9ab9-40ad-9af7-d6abcab85bf8"),
				ModifiedInSchemaUId = new Guid("1bd40929-9ab9-40ad-9af7-d6abcab85bf8"),
				CreatedInPackageId = new Guid("7c74fc90-4a57-4e68-9eda-fe0982d1250d")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMessagePublisherBySectionEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateMessagePublisherBySectionEventsProcessSchema() {
			var schema = new MessagePublisherBySectionEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new MessagePublisherBySection(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new MessagePublisherBySection_MessagePublisherEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MessagePublisherBySectionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MessagePublisherBySectionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1bd40929-9ab9-40ad-9af7-d6abcab85bf8"));
		}

		#endregion

	}

	#endregion

	#region Class: MessagePublisherBySection

	/// <summary>
	/// Message publisher by section.
	/// </summary>
	public class MessagePublisherBySection : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public MessagePublisherBySection(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MessagePublisherBySection";
		}

		public MessagePublisherBySection(MessagePublisherBySection source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SectionId {
			get {
				return GetTypedColumnValue<Guid>("SectionId");
			}
			set {
				SetColumnValue("SectionId", value);
				_section = null;
			}
		}

		/// <exclude/>
		public string SectionCaption {
			get {
				return GetTypedColumnValue<string>("SectionCaption");
			}
			set {
				SetColumnValue("SectionCaption", value);
				if (_section != null) {
					_section.Caption = value;
				}
			}
		}

		private SysModule _section;
		/// <summary>
		/// Section.
		/// </summary>
		public SysModule Section {
			get {
				return _section ??
					(_section = LookupColumnEntities.GetEntity("Section") as SysModule);
			}
		}

		/// <exclude/>
		public Guid MessagePublisherId {
			get {
				return GetTypedColumnValue<Guid>("MessagePublisherId");
			}
			set {
				SetColumnValue("MessagePublisherId", value);
				_messagePublisher = null;
			}
		}

		/// <exclude/>
		public string MessagePublisherName {
			get {
				return GetTypedColumnValue<string>("MessagePublisherName");
			}
			set {
				SetColumnValue("MessagePublisherName", value);
				if (_messagePublisher != null) {
					_messagePublisher.Name = value;
				}
			}
		}

		private MessagePublisher _messagePublisher;
		/// <summary>
		/// Message publisher.
		/// </summary>
		public MessagePublisher MessagePublisher {
			get {
				return _messagePublisher ??
					(_messagePublisher = LookupColumnEntities.GetEntity("MessagePublisher") as MessagePublisher);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MessagePublisherBySection_MessagePublisherEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("MessagePublisherBySectionDeleted", e);
			Validating += (s, e) => ThrowEvent("MessagePublisherBySectionValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MessagePublisherBySection(this);
		}

		#endregion

	}

	#endregion

	#region Class: MessagePublisherBySection_MessagePublisherEventsProcess

	/// <exclude/>
	public partial class MessagePublisherBySection_MessagePublisherEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : MessagePublisherBySection
	{

		public MessagePublisherBySection_MessagePublisherEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MessagePublisherBySection_MessagePublisherEventsProcess";
			SchemaUId = new Guid("1bd40929-9ab9-40ad-9af7-d6abcab85bf8");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1bd40929-9ab9-40ad-9af7-d6abcab85bf8");
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

	#region Class: MessagePublisherBySection_MessagePublisherEventsProcess

	/// <exclude/>
	public class MessagePublisherBySection_MessagePublisherEventsProcess : MessagePublisherBySection_MessagePublisherEventsProcess<MessagePublisherBySection>
	{

		public MessagePublisherBySection_MessagePublisherEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MessagePublisherBySection_MessagePublisherEventsProcess

	public partial class MessagePublisherBySection_MessagePublisherEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: MessagePublisherBySectionEventsProcessSchema

	/// <exclude/>
	public class MessagePublisherBySectionEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public MessagePublisherBySectionEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MessagePublisherBySectionEventsProcessSchema(MessagePublisherBySectionEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "MessagePublisherBySection_MessagePublisherEventsProcess";
			UId = new Guid("50a09313-ccf6-4dba-8a5f-ac7e625b404c");
			CreatedInPackageId = new Guid("7c74fc90-4a57-4e68-9eda-fe0982d1250d");
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
			return new MessagePublisherBySectionEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("50a09313-ccf6-4dba-8a5f-ac7e625b404c"));
		}

		#endregion

	}

	#endregion


	#region Class: MessagePublisherBySectionEventsProcess

	/// <exclude/>
	public class MessagePublisherBySectionEventsProcess : MessagePublisherBySection_MessagePublisherEventsProcess
	{

		public MessagePublisherBySectionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

