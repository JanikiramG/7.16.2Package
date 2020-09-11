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

	#region Class: SysPackageDependencySchema

	/// <exclude/>
	public class SysPackageDependencySchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysPackageDependencySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysPackageDependencySchema(SysPackageDependencySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysPackageDependencySchema(SysPackageDependencySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIUSysPackageDependencyIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = true
			};
			index.UId = new Guid("ba965c2e-9ac7-42ae-a536-a735885488bd");
			index.Name = "IUSysPackageDependency";
			index.CreatedInSchemaUId = new Guid("16e4e4cb-df27-4968-b6aa-53fb05a4930e");
			index.ModifiedInSchemaUId = new Guid("16e4e4cb-df27-4968-b6aa-53fb05a4930e");
			index.CreatedInPackageId = new Guid("80155737-b02e-45ce-84b4-f0a3630e5d9b");
			EntitySchemaIndexColumn sysPackageIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("bc81cbd0-f635-4c94-bb6d-7c262e7168b3"),
				ColumnUId = new Guid("d32e6ee6-285a-42fc-966f-639a4f11155c"),
				CreatedInSchemaUId = new Guid("16e4e4cb-df27-4968-b6aa-53fb05a4930e"),
				ModifiedInSchemaUId = new Guid("16e4e4cb-df27-4968-b6aa-53fb05a4930e"),
				CreatedInPackageId = new Guid("80155737-b02e-45ce-84b4-f0a3630e5d9b"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(sysPackageIdIndexColumn);
			EntitySchemaIndexColumn dependOnPackageIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("4c67d57b-f753-4940-abd1-8bd3d0fddffc"),
				ColumnUId = new Guid("cf935ff5-e4ae-4f42-b7ef-2b291f93fc1b"),
				CreatedInSchemaUId = new Guid("16e4e4cb-df27-4968-b6aa-53fb05a4930e"),
				ModifiedInSchemaUId = new Guid("16e4e4cb-df27-4968-b6aa-53fb05a4930e"),
				CreatedInPackageId = new Guid("80155737-b02e-45ce-84b4-f0a3630e5d9b"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(dependOnPackageIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("16e4e4cb-df27-4968-b6aa-53fb05a4930e");
			RealUId = new Guid("16e4e4cb-df27-4968-b6aa-53fb05a4930e");
			Name = "SysPackageDependency";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("d32e6ee6-285a-42fc-966f-639a4f11155c")) == null) {
				Columns.Add(CreateSysPackageColumn());
			}
			if (Columns.FindByUId(new Guid("cf935ff5-e4ae-4f42-b7ef-2b291f93fc1b")) == null) {
				Columns.Add(CreateDependOnPackageColumn());
			}
			if (Columns.FindByUId(new Guid("9eb77032-011e-4e09-aace-f6f67de4f121")) == null) {
				Columns.Add(CreateDependOnPackageVersionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysPackageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d32e6ee6-285a-42fc-966f-639a4f11155c"),
				Name = @"SysPackage",
				ReferenceSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("16e4e4cb-df27-4968-b6aa-53fb05a4930e"),
				ModifiedInSchemaUId = new Guid("16e4e4cb-df27-4968-b6aa-53fb05a4930e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDependOnPackageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("cf935ff5-e4ae-4f42-b7ef-2b291f93fc1b"),
				Name = @"DependOnPackage",
				ReferenceSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("16e4e4cb-df27-4968-b6aa-53fb05a4930e"),
				ModifiedInSchemaUId = new Guid("16e4e4cb-df27-4968-b6aa-53fb05a4930e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDependOnPackageVersionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("9eb77032-011e-4e09-aace-f6f67de4f121"),
				Name = @"DependOnPackageVersion",
				CreatedInSchemaUId = new Guid("16e4e4cb-df27-4968-b6aa-53fb05a4930e"),
				ModifiedInSchemaUId = new Guid("16e4e4cb-df27-4968-b6aa-53fb05a4930e"),
				CreatedInPackageId = new Guid("58989fa1-7b3a-4f33-8264-ccd39fc37194")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIUSysPackageDependencyIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysPackageDependencyEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysPackageDependencyEventsProcessSchema() {
			var schema = new SysPackageDependencyEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysPackageDependency(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysPackageDependency_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysPackageDependencySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysPackageDependencySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("16e4e4cb-df27-4968-b6aa-53fb05a4930e"));
		}

		#endregion

	}

	#endregion

	#region Class: SysPackageDependency

	/// <summary>
	/// Package dependencies.
	/// </summary>
	public class SysPackageDependency : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysPackageDependency(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysPackageDependency";
		}

		public SysPackageDependency(SysPackageDependency source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysPackageId {
			get {
				return GetTypedColumnValue<Guid>("SysPackageId");
			}
			set {
				SetColumnValue("SysPackageId", value);
				_sysPackage = null;
			}
		}

		/// <exclude/>
		public string SysPackageName {
			get {
				return GetTypedColumnValue<string>("SysPackageName");
			}
			set {
				SetColumnValue("SysPackageName", value);
				if (_sysPackage != null) {
					_sysPackage.Name = value;
				}
			}
		}

		private SysPackage _sysPackage;
		/// <summary>
		/// Package.
		/// </summary>
		public SysPackage SysPackage {
			get {
				return _sysPackage ??
					(_sysPackage = LookupColumnEntities.GetEntity("SysPackage") as SysPackage);
			}
		}

		/// <exclude/>
		public Guid DependOnPackageId {
			get {
				return GetTypedColumnValue<Guid>("DependOnPackageId");
			}
			set {
				SetColumnValue("DependOnPackageId", value);
				_dependOnPackage = null;
			}
		}

		/// <exclude/>
		public string DependOnPackageName {
			get {
				return GetTypedColumnValue<string>("DependOnPackageName");
			}
			set {
				SetColumnValue("DependOnPackageName", value);
				if (_dependOnPackage != null) {
					_dependOnPackage.Name = value;
				}
			}
		}

		private SysPackage _dependOnPackage;
		/// <summary>
		/// Depends on package.
		/// </summary>
		public SysPackage DependOnPackage {
			get {
				return _dependOnPackage ??
					(_dependOnPackage = LookupColumnEntities.GetEntity("DependOnPackage") as SysPackage);
			}
		}

		/// <summary>
		/// Depends on package version.
		/// </summary>
		public string DependOnPackageVersion {
			get {
				return GetTypedColumnValue<string>("DependOnPackageVersion");
			}
			set {
				SetColumnValue("DependOnPackageVersion", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysPackageDependency_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysPackageDependencyDeleted", e);
			Inserting += (s, e) => ThrowEvent("SysPackageDependencyInserting", e);
			Validating += (s, e) => ThrowEvent("SysPackageDependencyValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysPackageDependency(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysPackageDependency_BaseEventsProcess

	/// <exclude/>
	public partial class SysPackageDependency_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysPackageDependency
	{

		public SysPackageDependency_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysPackageDependency_BaseEventsProcess";
			SchemaUId = new Guid("16e4e4cb-df27-4968-b6aa-53fb05a4930e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("16e4e4cb-df27-4968-b6aa-53fb05a4930e");
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

	#region Class: SysPackageDependency_BaseEventsProcess

	/// <exclude/>
	public class SysPackageDependency_BaseEventsProcess : SysPackageDependency_BaseEventsProcess<SysPackageDependency>
	{

		public SysPackageDependency_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysPackageDependency_BaseEventsProcess

	public partial class SysPackageDependency_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysPackageDependencyEventsProcessSchema

	/// <exclude/>
	public class SysPackageDependencyEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysPackageDependencyEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysPackageDependencyEventsProcessSchema(SysPackageDependencyEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysPackageDependency_BaseEventsProcess";
			UId = new Guid("5744302a-340d-481e-bbd7-91893ef34e6c");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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
			return new SysPackageDependencyEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5744302a-340d-481e-bbd7-91893ef34e6c"));
		}

		#endregion

	}

	#endregion


	#region Class: SysPackageDependencyEventsProcess

	/// <exclude/>
	public class SysPackageDependencyEventsProcess : SysPackageDependency_BaseEventsProcess
	{

		public SysPackageDependencyEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

