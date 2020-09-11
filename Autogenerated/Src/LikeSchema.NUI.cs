namespace Terrasoft.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: LikeSchema

	/// <exclude/>
	public class LikeSchema : Terrasoft.Core.Entities.EntitySchema
	{

		#region Constructors: Public

		public LikeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LikeSchema(LikeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LikeSchema(LikeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("19798138-68cb-45df-abc7-b1e7ffbe8a90");
			RealUId = new Guid("19798138-68cb-45df-abc7-b1e7ffbe8a90");
			Name = "Like";
			ParentSchemaUId = new Guid("1b56b061-4e91-4974-9038-df8340e534f2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("eb96f059-97b4-4cc9-b308-10d25043227f");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryColumn() {
			base.InitializePrimaryColumn();
			PrimaryColumn = CreateIdColumn();
			if (Columns.FindByUId(PrimaryColumn.UId) == null) {
				Columns.Add(PrimaryColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("268b15c2-da98-494f-82d8-ca3a5f39251e")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("8612c47d-7980-4d77-93ca-8cc8f1c8c8aa")) == null) {
				Columns.Add(CreateKnowledgeBaseColumn());
			}
			if (Columns.FindByUId(new Guid("4775d5fc-f847-4145-8472-960c2ebc7628")) == null) {
				Columns.Add(CreateLikeItColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("b60697a9-8c22-4657-b0e4-85bb341bdd94"),
				Name = @"Id",
				CreatedInSchemaUId = new Guid("19798138-68cb-45df-abc7-b1e7ffbe8a90"),
				ModifiedInSchemaUId = new Guid("19798138-68cb-45df-abc7-b1e7ffbe8a90"),
				CreatedInPackageId = new Guid("eb96f059-97b4-4cc9-b308-10d25043227f"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"AutoGuid")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("268b15c2-da98-494f-82d8-ca3a5f39251e"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("19798138-68cb-45df-abc7-b1e7ffbe8a90"),
				ModifiedInSchemaUId = new Guid("19798138-68cb-45df-abc7-b1e7ffbe8a90"),
				CreatedInPackageId = new Guid("eb96f059-97b4-4cc9-b308-10d25043227f")
			};
		}

		protected virtual EntitySchemaColumn CreateKnowledgeBaseColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8612c47d-7980-4d77-93ca-8cc8f1c8c8aa"),
				Name = @"KnowledgeBase",
				ReferenceSchemaUId = new Guid("0326868c-ce5e-4934-8f1f-178801bfe6c3"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("19798138-68cb-45df-abc7-b1e7ffbe8a90"),
				ModifiedInSchemaUId = new Guid("19798138-68cb-45df-abc7-b1e7ffbe8a90"),
				CreatedInPackageId = new Guid("eb96f059-97b4-4cc9-b308-10d25043227f")
			};
		}

		protected virtual EntitySchemaColumn CreateLikeItColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("4775d5fc-f847-4145-8472-960c2ebc7628"),
				Name = @"LikeIt",
				CreatedInSchemaUId = new Guid("19798138-68cb-45df-abc7-b1e7ffbe8a90"),
				ModifiedInSchemaUId = new Guid("19798138-68cb-45df-abc7-b1e7ffbe8a90"),
				CreatedInPackageId = new Guid("eb96f059-97b4-4cc9-b308-10d25043227f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLikeEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateLikeEventsProcessSchema() {
			var schema = new LikeEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Like(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Like_NUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LikeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LikeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("19798138-68cb-45df-abc7-b1e7ffbe8a90"));
		}

		#endregion

	}

	#endregion

	#region Class: Like

	/// <summary>
	/// Like.
	/// </summary>
	public class Like : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public Like(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Like";
		}

		public Like(Like source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Id.
		/// </summary>
		public Guid Id {
			get {
				return GetTypedColumnValue<Guid>("Id");
			}
			set {
				SetColumnValue("Id", value);
			}
		}

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
		public Guid KnowledgeBaseId {
			get {
				return GetTypedColumnValue<Guid>("KnowledgeBaseId");
			}
			set {
				SetColumnValue("KnowledgeBaseId", value);
				_knowledgeBase = null;
			}
		}

		/// <exclude/>
		public string KnowledgeBaseName {
			get {
				return GetTypedColumnValue<string>("KnowledgeBaseName");
			}
			set {
				SetColumnValue("KnowledgeBaseName", value);
				if (_knowledgeBase != null) {
					_knowledgeBase.Name = value;
				}
			}
		}

		private KnowledgeBase _knowledgeBase;
		/// <summary>
		/// Article.
		/// </summary>
		public KnowledgeBase KnowledgeBase {
			get {
				return _knowledgeBase ??
					(_knowledgeBase = LookupColumnEntities.GetEntity("KnowledgeBase") as KnowledgeBase);
			}
		}

		/// <summary>
		/// LikeIt.
		/// </summary>
		public int LikeIt {
			get {
				return GetTypedColumnValue<int>("LikeIt");
			}
			set {
				SetColumnValue("LikeIt", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Like_NUIEventsProcess(UserConnection);
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
			return new Like(this);
		}

		#endregion

	}

	#endregion

	#region Class: Like_NUIEventsProcess

	/// <exclude/>
	public partial class Like_NUIEventsProcess<TEntity> : Terrasoft.Core.Process.EmbeddedProcess where TEntity : Like
	{

		private TEntity _entity;
		public TEntity Entity {
			get {
				return _entity;
			}
			set {
				_entity = value;
			}
		}

		public Like_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Like_NUIEventsProcess";
			SchemaUId = new Guid("19798138-68cb-45df-abc7-b1e7ffbe8a90");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("19798138-68cb-45df-abc7-b1e7ffbe8a90");
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

	#region Class: Like_NUIEventsProcess

	/// <exclude/>
	public class Like_NUIEventsProcess : Like_NUIEventsProcess<Like>
	{

		public Like_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Like_NUIEventsProcess

	public partial class Like_NUIEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: LikeEventsProcessSchema

	/// <exclude/>
	public class LikeEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public LikeEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LikeEventsProcessSchema(LikeEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Like_NUIEventsProcess";
			UId = new Guid("a5f92aeb-a609-4916-b226-4a3f272213a8");
			CreatedInPackageId = new Guid("eb96f059-97b4-4cc9-b308-10d25043227f");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
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

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LikeEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a5f92aeb-a609-4916-b226-4a3f272213a8"));
		}

		#endregion

	}

	#endregion


	#region Class: LikeEventsProcess

	/// <exclude/>
	public class LikeEventsProcess : Like_NUIEventsProcess
	{

		public LikeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

