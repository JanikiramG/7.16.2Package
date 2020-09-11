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

	#region Class: UsrTreatmentprogramsFileSchema

	/// <exclude/>
	public class UsrTreatmentprogramsFileSchema : Terrasoft.Configuration.FileSchema
	{

		#region Constructors: Public

		public UsrTreatmentprogramsFileSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrTreatmentprogramsFileSchema(UsrTreatmentprogramsFileSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrTreatmentprogramsFileSchema(UsrTreatmentprogramsFileSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a1c03826-e2fe-4a08-bb79-f19d4357d2fe");
			RealUId = new Guid("a1c03826-e2fe-4a08-bb79-f19d4357d2fe");
			Name = "UsrTreatmentprogramsFile";
			ParentSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70");
			ExtendParent = false;
			CreatedInPackageId = new Guid("6b7558a3-7144-4658-a45d-bb760f4e7e93");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("cd782d89-77fe-4f56-a1c3-ce9ad2acff3b")) == null) {
				Columns.Add(CreateUsrTreatmentprogramsColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("a1c03826-e2fe-4a08-bb79-f19d4357d2fe");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("a1c03826-e2fe-4a08-bb79-f19d4357d2fe");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("a1c03826-e2fe-4a08-bb79-f19d4357d2fe");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("a1c03826-e2fe-4a08-bb79-f19d4357d2fe");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("a1c03826-e2fe-4a08-bb79-f19d4357d2fe");
			return column;
		}

		protected override EntitySchemaColumn CreateTypeColumn() {
			EntitySchemaColumn column = base.CreateTypeColumn();
			column.IsIndexed = true;
			column.ModifiedInSchemaUId = new Guid("a1c03826-e2fe-4a08-bb79-f19d4357d2fe");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("a1c03826-e2fe-4a08-bb79-f19d4357d2fe");
			return column;
		}

		protected virtual EntitySchemaColumn CreateUsrTreatmentprogramsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("cd782d89-77fe-4f56-a1c3-ce9ad2acff3b"),
				Name = @"UsrTreatmentprograms",
				ReferenceSchemaUId = new Guid("01b85c44-0df3-4799-a503-e72fc4a1ea2a"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("a1c03826-e2fe-4a08-bb79-f19d4357d2fe"),
				ModifiedInSchemaUId = new Guid("a1c03826-e2fe-4a08-bb79-f19d4357d2fe"),
				CreatedInPackageId = new Guid("6b7558a3-7144-4658-a45d-bb760f4e7e93")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateUsrTreatmentprogramsFileEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateUsrTreatmentprogramsFileEventsProcessSchema() {
			var schema = new UsrTreatmentprogramsFileEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new UsrTreatmentprogramsFile(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrTreatmentprogramsFile_CertificationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrTreatmentprogramsFileSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrTreatmentprogramsFileSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a1c03826-e2fe-4a08-bb79-f19d4357d2fe"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrTreatmentprogramsFile

	/// <summary>
	/// Treatment programs attachment.
	/// </summary>
	public class UsrTreatmentprogramsFile : Terrasoft.Configuration.File
	{

		#region Constructors: Public

		public UsrTreatmentprogramsFile(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrTreatmentprogramsFile";
		}

		public UsrTreatmentprogramsFile(UsrTreatmentprogramsFile source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid UsrTreatmentprogramsId {
			get {
				return GetTypedColumnValue<Guid>("UsrTreatmentprogramsId");
			}
			set {
				SetColumnValue("UsrTreatmentprogramsId", value);
				_usrTreatmentprograms = null;
			}
		}

		/// <exclude/>
		public string UsrTreatmentprogramsUsrName {
			get {
				return GetTypedColumnValue<string>("UsrTreatmentprogramsUsrName");
			}
			set {
				SetColumnValue("UsrTreatmentprogramsUsrName", value);
				if (_usrTreatmentprograms != null) {
					_usrTreatmentprograms.UsrName = value;
				}
			}
		}

		private UsrTreatmentprograms _usrTreatmentprograms;
		/// <summary>
		/// Treatment programs.
		/// </summary>
		public UsrTreatmentprograms UsrTreatmentprograms {
			get {
				return _usrTreatmentprograms ??
					(_usrTreatmentprograms = LookupColumnEntities.GetEntity("UsrTreatmentprograms") as UsrTreatmentprograms);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UsrTreatmentprogramsFile_CertificationEventsProcess(UserConnection);
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
			return new UsrTreatmentprogramsFile(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrTreatmentprogramsFile_CertificationEventsProcess

	/// <exclude/>
	public partial class UsrTreatmentprogramsFile_CertificationEventsProcess<TEntity> : Terrasoft.Configuration.File_PRMPortalEventsProcess<TEntity> where TEntity : UsrTreatmentprogramsFile
	{

		public UsrTreatmentprogramsFile_CertificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrTreatmentprogramsFile_CertificationEventsProcess";
			SchemaUId = new Guid("a1c03826-e2fe-4a08-bb79-f19d4357d2fe");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a1c03826-e2fe-4a08-bb79-f19d4357d2fe");
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

	#region Class: UsrTreatmentprogramsFile_CertificationEventsProcess

	/// <exclude/>
	public class UsrTreatmentprogramsFile_CertificationEventsProcess : UsrTreatmentprogramsFile_CertificationEventsProcess<UsrTreatmentprogramsFile>
	{

		public UsrTreatmentprogramsFile_CertificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrTreatmentprogramsFile_CertificationEventsProcess

	public partial class UsrTreatmentprogramsFile_CertificationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: UsrTreatmentprogramsFileEventsProcessSchema

	/// <exclude/>
	public class UsrTreatmentprogramsFileEventsProcessSchema : Terrasoft.Configuration.FileEventsProcessSchema
	{

		#region Constructors: Public

		public UsrTreatmentprogramsFileEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public UsrTreatmentprogramsFileEventsProcessSchema(UsrTreatmentprogramsFileEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "UsrTreatmentprogramsFile_CertificationEventsProcess";
			UId = new Guid("6d5e2e16-b109-465f-aa98-57faa133a973");
			CreatedInPackageId = new Guid("6b7558a3-7144-4658-a45d-bb760f4e7e93");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.16.2.1600";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("84c38674-6336-4d4b-8398-5ae20c73c912");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override ProcessSchemaParameter CreateNextProcessElementReadyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d9e67329-fde2-4fbd-aa49-2d69ca3d2b5b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"NextProcessElementReady",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override ProcessSchemaParameter CreateIsProcessModeSaveParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4cb16350-d39b-4247-9da5-33032cf8667d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"IsProcessModeSave",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override ProcessSchemaParameter CreateCanUseDcmParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d185837a-b568-43f2-a09a-28512af1957a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"CanUseDcm",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
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
				UId = new Guid("8344487b-4f62-45ad-a3a1-e073f07b2ef2"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e33423da-6c95-41fd-bf98-97c4161975e5"),
				Name = "System.Linq",
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
				UId = new Guid("36db9306-521c-4d94-87c4-a02688862caa"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("8a6b5719-da97-4634-8f04-4375bc29ffcf")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aca2294b-e209-4c40-9400-0d59d9ecd1ea"),
				Name = "Terrasoft.GlobalSearch.Indexing",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new UsrTreatmentprogramsFileEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6d5e2e16-b109-465f-aa98-57faa133a973"));
		}

		#endregion

	}

	#endregion


	#region Class: UsrTreatmentprogramsFileEventsProcess

	/// <exclude/>
	public class UsrTreatmentprogramsFileEventsProcess : UsrTreatmentprogramsFile_CertificationEventsProcess
	{

		public UsrTreatmentprogramsFileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

