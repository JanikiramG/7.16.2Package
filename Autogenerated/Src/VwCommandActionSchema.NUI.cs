﻿namespace Terrasoft.Configuration
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

	#region Class: VwCommandActionSchema

	/// <exclude/>
	public class VwCommandActionSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VwCommandActionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwCommandActionSchema(VwCommandActionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwCommandActionSchema(VwCommandActionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659");
			RealUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659");
			Name = "VwCommandAction";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("d076e889-7b35-4491-96b0-281af3634c94")) == null) {
				Columns.Add(CreateCaptionColumn());
			}
			if (Columns.FindByUId(new Guid("2976ee4e-a09e-4a84-913d-31901c852026")) == null) {
				Columns.Add(CreateCodeColumn());
			}
			if (Columns.FindByUId(new Guid("37ec9df9-b82c-4221-a446-9a15814e8df0")) == null) {
				Columns.Add(CreateColumnCaptionColumn());
			}
			if (Columns.FindByUId(new Guid("bd00c8db-0fea-4696-858c-10c5b239ada9")) == null) {
				Columns.Add(CreateSubjectColumnUIdColumn());
			}
			if (Columns.FindByUId(new Guid("a67e6a3a-8849-4335-bb13-aba9b35b90d1")) == null) {
				Columns.Add(CreateSubjectSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("41b7bf71-a7b3-4df0-abfc-ba9943380893")) == null) {
				Columns.Add(CreateAdditionalParamValueColumn());
			}
			if (Columns.FindByUId(new Guid("e6c8a1d7-4cd8-4181-ab7d-2bf2888b5649")) == null) {
				Columns.Add(CreateOrderColumnColumn());
			}
			if (Columns.FindByUId(new Guid("5cbd8d64-ed5d-4560-b9d5-ff7504698316")) == null) {
				Columns.Add(CreateTypeColumnUIdColumn());
			}
			if (Columns.FindByUId(new Guid("66ba297c-2aca-481c-9320-ca0b96e28ab7")) == null) {
				Columns.Add(CreateMainParamCationColumn());
			}
			if (Columns.FindByUId(new Guid("16d06141-c531-4ab1-b3ff-0500858a3f5f")) == null) {
				Columns.Add(CreateTypeColumnCodeColumn());
			}
			if (Columns.FindByUId(new Guid("8ab11973-fbd4-4068-bb0f-2114094e80a6")) == null) {
				Columns.Add(CreateIsSharedColumn());
			}
			if (Columns.FindByUId(new Guid("473cb35f-8cff-4f3c-81f3-3e133aa96838")) == null) {
				Columns.Add(CreateCommandActionIdColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659");
			column.CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659");
			column.CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659");
			column.CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659");
			column.CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659");
			column.CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659");
			column.CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f");
			return column;
		}

		protected virtual EntitySchemaColumn CreateCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("d076e889-7b35-4491-96b0-281af3634c94"),
				Name = @"Caption",
				CreatedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"),
				ModifiedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"),
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			};
		}

		protected virtual EntitySchemaColumn CreateCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("2976ee4e-a09e-4a84-913d-31901c852026"),
				Name = @"Code",
				CreatedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"),
				ModifiedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"),
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("37ec9df9-b82c-4221-a446-9a15814e8df0"),
				Name = @"ColumnCaption",
				CreatedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"),
				ModifiedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"),
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			};
		}

		protected virtual EntitySchemaColumn CreateSubjectColumnUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("bd00c8db-0fea-4696-858c-10c5b239ada9"),
				Name = @"SubjectColumnUId",
				CreatedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"),
				ModifiedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"),
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			};
		}

		protected virtual EntitySchemaColumn CreateSubjectSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("a67e6a3a-8849-4335-bb13-aba9b35b90d1"),
				Name = @"SubjectSchemaUId",
				CreatedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"),
				ModifiedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"),
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			};
		}

		protected virtual EntitySchemaColumn CreateAdditionalParamValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("41b7bf71-a7b3-4df0-abfc-ba9943380893"),
				Name = @"AdditionalParamValue",
				CreatedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"),
				ModifiedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"),
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			};
		}

		protected virtual EntitySchemaColumn CreateOrderColumnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("e6c8a1d7-4cd8-4181-ab7d-2bf2888b5649"),
				Name = @"OrderColumn",
				CreatedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"),
				ModifiedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"),
				CreatedInPackageId = new Guid("670e19aa-ce71-45ac-9b28-4384434342e2")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumnUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("5cbd8d64-ed5d-4560-b9d5-ff7504698316"),
				Name = @"TypeColumnUId",
				CreatedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"),
				ModifiedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"),
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			};
		}

		protected virtual EntitySchemaColumn CreateMainParamCationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("66ba297c-2aca-481c-9320-ca0b96e28ab7"),
				Name = @"MainParamCation",
				CreatedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"),
				ModifiedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"),
				CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumnCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("16d06141-c531-4ab1-b3ff-0500858a3f5f"),
				Name = @"TypeColumnCode",
				CreatedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"),
				ModifiedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"),
				CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d")
			};
		}

		protected virtual EntitySchemaColumn CreateIsSharedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("8ab11973-fbd4-4068-bb0f-2114094e80a6"),
				Name = @"IsShared",
				CreatedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"),
				ModifiedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"),
				CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d")
			};
		}

		protected virtual EntitySchemaColumn CreateCommandActionIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("473cb35f-8cff-4f3c-81f3-3e133aa96838"),
				Name = @"CommandActionId",
				CreatedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"),
				ModifiedInSchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwCommandActionEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwCommandActionEventsProcessSchema() {
			var schema = new VwCommandActionEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwCommandAction(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwCommandAction_NUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwCommandActionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwCommandActionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659"));
		}

		#endregion

	}

	#endregion

	#region Class: VwCommandAction

	/// <summary>
	/// Macros in command line (view).
	/// </summary>
	public class VwCommandAction : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VwCommandAction(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwCommandAction";
		}

		public VwCommandAction(VwCommandAction source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Hint line.
		/// </summary>
		public string Caption {
			get {
				return GetTypedColumnValue<string>("Caption");
			}
			set {
				SetColumnValue("Caption", value);
			}
		}

		/// <summary>
		/// Command code.
		/// </summary>
		public string Code {
			get {
				return GetTypedColumnValue<string>("Code");
			}
			set {
				SetColumnValue("Code", value);
			}
		}

		/// <summary>
		/// Column caption.
		/// </summary>
		public string ColumnCaption {
			get {
				return GetTypedColumnValue<string>("ColumnCaption");
			}
			set {
				SetColumnValue("ColumnCaption", value);
			}
		}

		/// <summary>
		/// Unique identifier of schema column in workspace.
		/// </summary>
		public Guid SubjectColumnUId {
			get {
				return GetTypedColumnValue<Guid>("SubjectColumnUId");
			}
			set {
				SetColumnValue("SubjectColumnUId", value);
			}
		}

		/// <summary>
		/// Unique identifier of schema in workspace.
		/// </summary>
		public Guid SubjectSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("SubjectSchemaUId");
			}
			set {
				SetColumnValue("SubjectSchemaUId", value);
			}
		}

		/// <summary>
		/// Additional parameter value.
		/// </summary>
		public string AdditionalParamValue {
			get {
				return GetTypedColumnValue<string>("AdditionalParamValue");
			}
			set {
				SetColumnValue("AdditionalParamValue", value);
			}
		}

		/// <summary>
		/// Order.
		/// </summary>
		public int OrderColumn {
			get {
				return GetTypedColumnValue<int>("OrderColumn");
			}
			set {
				SetColumnValue("OrderColumn", value);
			}
		}

		/// <summary>
		/// Type column for working with different cards.
		/// </summary>
		public Guid TypeColumnUId {
			get {
				return GetTypedColumnValue<Guid>("TypeColumnUId");
			}
			set {
				SetColumnValue("TypeColumnUId", value);
			}
		}

		/// <summary>
		/// Parameter main caption.
		/// </summary>
		public string MainParamCation {
			get {
				return GetTypedColumnValue<string>("MainParamCation");
			}
			set {
				SetColumnValue("MainParamCation", value);
			}
		}

		/// <summary>
		/// Value of card type code.
		/// </summary>
		public string TypeColumnCode {
			get {
				return GetTypedColumnValue<string>("TypeColumnCode");
			}
			set {
				SetColumnValue("TypeColumnCode", value);
			}
		}

		/// <summary>
		/// Common.
		/// </summary>
		public bool IsShared {
			get {
				return GetTypedColumnValue<bool>("IsShared");
			}
			set {
				SetColumnValue("IsShared", value);
			}
		}

		/// <summary>
		/// CommandActionId.
		/// </summary>
		public Guid CommandActionId {
			get {
				return GetTypedColumnValue<Guid>("CommandActionId");
			}
			set {
				SetColumnValue("CommandActionId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwCommandAction_NUIEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwCommandActionDeleted", e);
			Inserting += (s, e) => ThrowEvent("VwCommandActionInserting", e);
			Validating += (s, e) => ThrowEvent("VwCommandActionValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwCommandAction(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwCommandAction_NUIEventsProcess

	/// <exclude/>
	public partial class VwCommandAction_NUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : VwCommandAction
	{

		public VwCommandAction_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwCommandAction_NUIEventsProcess";
			SchemaUId = new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("14be23fa-5693-4c2c-9a07-b2f6c346f659");
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

	#region Class: VwCommandAction_NUIEventsProcess

	/// <exclude/>
	public class VwCommandAction_NUIEventsProcess : VwCommandAction_NUIEventsProcess<VwCommandAction>
	{

		public VwCommandAction_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwCommandAction_NUIEventsProcess

	public partial class VwCommandAction_NUIEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwCommandActionEventsProcessSchema

	/// <exclude/>
	public class VwCommandActionEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public VwCommandActionEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwCommandActionEventsProcessSchema(VwCommandActionEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwCommandAction_NUIEventsProcess";
			UId = new Guid("323fbbbe-023b-4b6b-b7e5-7d972c2eb5dd");
			CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f");
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
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f")
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
			return new VwCommandActionEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("323fbbbe-023b-4b6b-b7e5-7d972c2eb5dd"));
		}

		#endregion

	}

	#endregion


	#region Class: VwCommandActionEventsProcess

	/// <exclude/>
	public class VwCommandActionEventsProcess : VwCommandAction_NUIEventsProcess
	{

		public VwCommandActionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}
