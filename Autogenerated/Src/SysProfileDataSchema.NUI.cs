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

	#region Class: SysProfileDataSchema

	/// <exclude/>
	public class SysProfileDataSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysProfileDataSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysProfileDataSchema(SysProfileDataSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysProfileDataSchema(SysProfileDataSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIX_Key_ContactId_SysCultureIdIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("d3dfae03-aa00-444e-8428-947e6de02824");
			index.Name = "IX_Key_ContactId_SysCultureId";
			index.CreatedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b");
			index.ModifiedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b");
			index.CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			EntitySchemaIndexColumn keyIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("c0b8a6cc-6db8-45c0-8093-1e5b2245b975"),
				ColumnUId = new Guid("3bb9d182-ad73-4379-9d51-2003c862a90c"),
				CreatedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b"),
				ModifiedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(keyIndexColumn);
			EntitySchemaIndexColumn contactIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("86c88d72-a918-4e03-9523-56e1895bfc86"),
				ColumnUId = new Guid("03a27b75-6d7f-4be4-b0fd-f03ffd8a7aab"),
				CreatedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b"),
				ModifiedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(contactIdIndexColumn);
			EntitySchemaIndexColumn sysCultureIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("ff33ca0e-e777-402d-b923-94fff2b53455"),
				ColumnUId = new Guid("fd26b95c-06ba-4595-915e-bc5657d10842"),
				CreatedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b"),
				ModifiedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(sysCultureIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b");
			RealUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b");
			Name = "SysProfileData";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("216b38f5-e2c3-462b-ae2e-1df80fc21b33")) == null) {
				Columns.Add(CreateSysUserColumn());
			}
			if (Columns.FindByUId(new Guid("6851587b-0b7a-45cb-a5a5-31994420d81b")) == null) {
				Columns.Add(CreateObjectIdColumn());
			}
			if (Columns.FindByUId(new Guid("3bb9d182-ad73-4379-9d51-2003c862a90c")) == null) {
				Columns.Add(CreateKeyColumn());
			}
			if (Columns.FindByUId(new Guid("986fc9ee-72b2-4cc9-af5e-ed64af54d30f")) == null) {
				Columns.Add(CreateObjectDataColumn());
			}
			if (Columns.FindByUId(new Guid("99d21524-ccad-45c1-998d-e9de6a6412af")) == null) {
				Columns.Add(CreateObjectDifferenceColumn());
			}
			if (Columns.FindByUId(new Guid("03a27b75-6d7f-4be4-b0fd-f03ffd8a7aab")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("fd26b95c-06ba-4595-915e-bc5657d10842")) == null) {
				Columns.Add(CreateSysCultureColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b");
			column.CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b");
			column.CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b");
			column.CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b");
			column.CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b");
			column.CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b");
			column.CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d");
			return column;
		}

		protected virtual EntitySchemaColumn CreateSysUserColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("216b38f5-e2c3-462b-ae2e-1df80fc21b33"),
				Name = @"SysUser",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b"),
				ModifiedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b"),
				CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d")
			};
		}

		protected virtual EntitySchemaColumn CreateObjectIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("6851587b-0b7a-45cb-a5a5-31994420d81b"),
				Name = @"ObjectId",
				CreatedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b"),
				ModifiedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b"),
				CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d")
			};
		}

		protected virtual EntitySchemaColumn CreateKeyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("3bb9d182-ad73-4379-9d51-2003c862a90c"),
				Name = @"Key",
				CreatedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b"),
				ModifiedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b"),
				CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d")
			};
		}

		protected virtual EntitySchemaColumn CreateObjectDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("986fc9ee-72b2-4cc9-af5e-ed64af54d30f"),
				Name = @"ObjectData",
				CreatedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b"),
				ModifiedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b"),
				CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d")
			};
		}

		protected virtual EntitySchemaColumn CreateObjectDifferenceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("99d21524-ccad-45c1-998d-e9de6a6412af"),
				Name = @"ObjectDifference",
				CreatedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b"),
				ModifiedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b"),
				CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("03a27b75-6d7f-4be4-b0fd-f03ffd8a7aab"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b"),
				ModifiedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b"),
				CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d")
			};
		}

		protected virtual EntitySchemaColumn CreateSysCultureColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fd26b95c-06ba-4595-915e-bc5657d10842"),
				Name = @"SysCulture",
				ReferenceSchemaUId = new Guid("ffc193e1-04bc-472b-bdc0-3333d1df84e4"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b"),
				ModifiedInSchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIX_Key_ContactId_SysCultureIdIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysProfileDataEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysProfileDataEventsProcessSchema() {
			var schema = new SysProfileDataEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysProfileData(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysProfileData_NUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysProfileDataSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysProfileDataSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a3251d81-1788-4245-88f1-23ae03e4057b"));
		}

		#endregion

	}

	#endregion

	#region Class: SysProfileData

	/// <summary>
	/// User profile.
	/// </summary>
	public class SysProfileData : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysProfileData(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysProfileData";
		}

		public SysProfileData(SysProfileData source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysUserId {
			get {
				return GetTypedColumnValue<Guid>("SysUserId");
			}
			set {
				SetColumnValue("SysUserId", value);
				_sysUser = null;
			}
		}

		/// <exclude/>
		public string SysUserName {
			get {
				return GetTypedColumnValue<string>("SysUserName");
			}
			set {
				SetColumnValue("SysUserName", value);
				if (_sysUser != null) {
					_sysUser.Name = value;
				}
			}
		}

		private SysAdminUnit _sysUser;
		/// <summary>
		/// Object.
		/// </summary>
		public SysAdminUnit SysUser {
			get {
				return _sysUser ??
					(_sysUser = LookupColumnEntities.GetEntity("SysUser") as SysAdminUnit);
			}
		}

		/// <summary>
		/// Unique identifier of object.
		/// </summary>
		public Guid ObjectId {
			get {
				return GetTypedColumnValue<Guid>("ObjectId");
			}
			set {
				SetColumnValue("ObjectId", value);
			}
		}

		/// <summary>
		/// Key.
		/// </summary>
		public string Key {
			get {
				return GetTypedColumnValue<string>("Key");
			}
			set {
				SetColumnValue("Key", value);
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
		public Guid SysCultureId {
			get {
				return GetTypedColumnValue<Guid>("SysCultureId");
			}
			set {
				SetColumnValue("SysCultureId", value);
				_sysCulture = null;
			}
		}

		/// <exclude/>
		public string SysCultureName {
			get {
				return GetTypedColumnValue<string>("SysCultureName");
			}
			set {
				SetColumnValue("SysCultureName", value);
				if (_sysCulture != null) {
					_sysCulture.Name = value;
				}
			}
		}

		private SysCulture _sysCulture;
		/// <summary>
		/// Culture.
		/// </summary>
		public SysCulture SysCulture {
			get {
				return _sysCulture ??
					(_sysCulture = LookupColumnEntities.GetEntity("SysCulture") as SysCulture);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysProfileData_NUIEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysProfileDataDeleted", e);
			Inserting += (s, e) => ThrowEvent("SysProfileDataInserting", e);
			Validating += (s, e) => ThrowEvent("SysProfileDataValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysProfileData(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysProfileData_NUIEventsProcess

	/// <exclude/>
	public partial class SysProfileData_NUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysProfileData
	{

		public SysProfileData_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysProfileData_NUIEventsProcess";
			SchemaUId = new Guid("a3251d81-1788-4245-88f1-23ae03e4057b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a3251d81-1788-4245-88f1-23ae03e4057b");
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

	#region Class: SysProfileData_NUIEventsProcess

	/// <exclude/>
	public class SysProfileData_NUIEventsProcess : SysProfileData_NUIEventsProcess<SysProfileData>
	{

		public SysProfileData_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysProfileData_NUIEventsProcess

	public partial class SysProfileData_NUIEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysProfileDataEventsProcessSchema

	/// <exclude/>
	public class SysProfileDataEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysProfileDataEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysProfileDataEventsProcessSchema(SysProfileDataEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysProfileData_NUIEventsProcess";
			UId = new Guid("25f534dd-066a-4375-948c-6155311854b6");
			CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d");
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
				CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d")
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
			return new SysProfileDataEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("25f534dd-066a-4375-948c-6155311854b6"));
		}

		#endregion

	}

	#endregion


	#region Class: SysProfileDataEventsProcess

	/// <exclude/>
	public class SysProfileDataEventsProcess : SysProfileData_NUIEventsProcess
	{

		public SysProfileDataEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

