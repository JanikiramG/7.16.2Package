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

	#region Class: MobilePhoneBlockListSchema

	/// <exclude/>
	public class MobilePhoneBlockListSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public MobilePhoneBlockListSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MobilePhoneBlockListSchema(MobilePhoneBlockListSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MobilePhoneBlockListSchema(MobilePhoneBlockListSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c83f17aa-dfa8-4805-9905-e07e2884ad01");
			RealUId = new Guid("c83f17aa-dfa8-4805-9905-e07e2884ad01");
			Name = "MobilePhoneBlockList";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("94e982b3-cf08-4489-924e-e7fda13fd117")) == null) {
				Columns.Add(CreateMobilePhoneColumn());
			}
			if (Columns.FindByUId(new Guid("cf64a527-c1e1-4c54-bb90-8c4f49984ea5")) == null) {
				Columns.Add(CreateBlockedOnColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("c83f17aa-dfa8-4805-9905-e07e2884ad01");
			column.CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("c83f17aa-dfa8-4805-9905-e07e2884ad01");
			column.CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("c83f17aa-dfa8-4805-9905-e07e2884ad01");
			column.CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("c83f17aa-dfa8-4805-9905-e07e2884ad01");
			column.CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("c83f17aa-dfa8-4805-9905-e07e2884ad01");
			column.CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("c83f17aa-dfa8-4805-9905-e07e2884ad01");
			column.CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7");
			return column;
		}

		protected virtual EntitySchemaColumn CreateMobilePhoneColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("94e982b3-cf08-4489-924e-e7fda13fd117"),
				Name = @"MobilePhone",
				CreatedInSchemaUId = new Guid("c83f17aa-dfa8-4805-9905-e07e2884ad01"),
				ModifiedInSchemaUId = new Guid("c83f17aa-dfa8-4805-9905-e07e2884ad01"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			};
		}

		protected virtual EntitySchemaColumn CreateBlockedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("cf64a527-c1e1-4c54-bb90-8c4f49984ea5"),
				Name = @"BlockedOn",
				CreatedInSchemaUId = new Guid("c83f17aa-dfa8-4805-9905-e07e2884ad01"),
				ModifiedInSchemaUId = new Guid("c83f17aa-dfa8-4805-9905-e07e2884ad01"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMobilePhoneBlockListEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateMobilePhoneBlockListEventsProcessSchema() {
			var schema = new MobilePhoneBlockListEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new MobilePhoneBlockList(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new MobilePhoneBlockList_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MobilePhoneBlockListSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MobilePhoneBlockListSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c83f17aa-dfa8-4805-9905-e07e2884ad01"));
		}

		#endregion

	}

	#endregion

	#region Class: MobilePhoneBlockList

	/// <summary>
	/// List of blocked numbers.
	/// </summary>
	public class MobilePhoneBlockList : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public MobilePhoneBlockList(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MobilePhoneBlockList";
		}

		public MobilePhoneBlockList(MobilePhoneBlockList source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Mobile phone.
		/// </summary>
		public string MobilePhone {
			get {
				return GetTypedColumnValue<string>("MobilePhone");
			}
			set {
				SetColumnValue("MobilePhone", value);
			}
		}

		/// <summary>
		/// Locked on.
		/// </summary>
		public DateTime BlockedOn {
			get {
				return GetTypedColumnValue<DateTime>("BlockedOn");
			}
			set {
				SetColumnValue("BlockedOn", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MobilePhoneBlockList_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("MobilePhoneBlockListDeleted", e);
			Inserting += (s, e) => ThrowEvent("MobilePhoneBlockListInserting", e);
			Validating += (s, e) => ThrowEvent("MobilePhoneBlockListValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MobilePhoneBlockList(this);
		}

		#endregion

	}

	#endregion

	#region Class: MobilePhoneBlockList_BaseEventsProcess

	/// <exclude/>
	public partial class MobilePhoneBlockList_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : MobilePhoneBlockList
	{

		public MobilePhoneBlockList_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MobilePhoneBlockList_BaseEventsProcess";
			SchemaUId = new Guid("c83f17aa-dfa8-4805-9905-e07e2884ad01");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c83f17aa-dfa8-4805-9905-e07e2884ad01");
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

	#region Class: MobilePhoneBlockList_BaseEventsProcess

	/// <exclude/>
	public class MobilePhoneBlockList_BaseEventsProcess : MobilePhoneBlockList_BaseEventsProcess<MobilePhoneBlockList>
	{

		public MobilePhoneBlockList_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MobilePhoneBlockList_BaseEventsProcess

	public partial class MobilePhoneBlockList_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: MobilePhoneBlockListEventsProcessSchema

	/// <exclude/>
	public class MobilePhoneBlockListEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public MobilePhoneBlockListEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MobilePhoneBlockListEventsProcessSchema(MobilePhoneBlockListEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "MobilePhoneBlockList_BaseEventsProcess";
			UId = new Guid("5d51c1bb-6ee7-490e-82f7-92b3faf6b860");
			CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7");
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
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
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
			return new MobilePhoneBlockListEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5d51c1bb-6ee7-490e-82f7-92b3faf6b860"));
		}

		#endregion

	}

	#endregion


	#region Class: MobilePhoneBlockListEventsProcess

	/// <exclude/>
	public class MobilePhoneBlockListEventsProcess : MobilePhoneBlockList_BaseEventsProcess
	{

		public MobilePhoneBlockListEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

