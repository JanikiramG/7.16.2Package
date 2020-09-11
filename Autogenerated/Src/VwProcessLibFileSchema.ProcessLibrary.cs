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

	#region Class: VwProcessLibFileSchema

	/// <exclude/>
	public class VwProcessLibFileSchema : Terrasoft.Configuration.FileSchema
	{

		#region Constructors: Public

		public VwProcessLibFileSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwProcessLibFileSchema(VwProcessLibFileSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwProcessLibFileSchema(VwProcessLibFileSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("46d85d4c-c6b5-4ed7-b600-a3b195d70acc");
			RealUId = new Guid("46d85d4c-c6b5-4ed7-b600-a3b195d70acc");
			Name = "VwProcessLibFile";
			ParentSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70");
			ExtendParent = false;
			CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("fbcd7bc3-cdd7-4522-8478-34010184d858")) == null) {
				Columns.Add(CreateVwProcessLibColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("46d85d4c-c6b5-4ed7-b600-a3b195d70acc");
			column.CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("46d85d4c-c6b5-4ed7-b600-a3b195d70acc");
			column.CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("46d85d4c-c6b5-4ed7-b600-a3b195d70acc");
			column.CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("46d85d4c-c6b5-4ed7-b600-a3b195d70acc");
			column.CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("46d85d4c-c6b5-4ed7-b600-a3b195d70acc");
			column.CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("46d85d4c-c6b5-4ed7-b600-a3b195d70acc");
			column.CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae");
			return column;
		}

		protected override EntitySchemaColumn CreateNotesColumn() {
			EntitySchemaColumn column = base.CreateNotesColumn();
			column.ModifiedInSchemaUId = new Guid("46d85d4c-c6b5-4ed7-b600-a3b195d70acc");
			column.CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae");
			return column;
		}

		protected override EntitySchemaColumn CreateLockedByColumn() {
			EntitySchemaColumn column = base.CreateLockedByColumn();
			column.ModifiedInSchemaUId = new Guid("46d85d4c-c6b5-4ed7-b600-a3b195d70acc");
			column.CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae");
			return column;
		}

		protected override EntitySchemaColumn CreateLockedOnColumn() {
			EntitySchemaColumn column = base.CreateLockedOnColumn();
			column.ModifiedInSchemaUId = new Guid("46d85d4c-c6b5-4ed7-b600-a3b195d70acc");
			column.CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae");
			return column;
		}

		protected override EntitySchemaColumn CreateDataColumn() {
			EntitySchemaColumn column = base.CreateDataColumn();
			column.ModifiedInSchemaUId = new Guid("46d85d4c-c6b5-4ed7-b600-a3b195d70acc");
			column.CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae");
			return column;
		}

		protected override EntitySchemaColumn CreateTypeColumn() {
			EntitySchemaColumn column = base.CreateTypeColumn();
			column.ModifiedInSchemaUId = new Guid("46d85d4c-c6b5-4ed7-b600-a3b195d70acc");
			column.CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae");
			return column;
		}

		protected override EntitySchemaColumn CreateVersionColumn() {
			EntitySchemaColumn column = base.CreateVersionColumn();
			column.ModifiedInSchemaUId = new Guid("46d85d4c-c6b5-4ed7-b600-a3b195d70acc");
			column.CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae");
			return column;
		}

		protected override EntitySchemaColumn CreateSizeColumn() {
			EntitySchemaColumn column = base.CreateSizeColumn();
			column.ModifiedInSchemaUId = new Guid("46d85d4c-c6b5-4ed7-b600-a3b195d70acc");
			column.CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("46d85d4c-c6b5-4ed7-b600-a3b195d70acc");
			column.CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae");
			return column;
		}

		protected virtual EntitySchemaColumn CreateVwProcessLibColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("fbcd7bc3-cdd7-4522-8478-34010184d858"),
				Name = @"VwProcessLib",
				CreatedInSchemaUId = new Guid("46d85d4c-c6b5-4ed7-b600-a3b195d70acc"),
				ModifiedInSchemaUId = new Guid("46d85d4c-c6b5-4ed7-b600-a3b195d70acc"),
				CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwProcessLibFileEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwProcessLibFileEventsProcessSchema() {
			var schema = new VwProcessLibFileEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwProcessLibFile(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwProcessLibFile_ProcessLibraryEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwProcessLibFileSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwProcessLibFileSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("46d85d4c-c6b5-4ed7-b600-a3b195d70acc"));
		}

		#endregion

	}

	#endregion

	#region Class: VwProcessLibFile

	/// <summary>
	/// Attachments detail object for "Process library" section object.
	/// </summary>
	public class VwProcessLibFile : Terrasoft.Configuration.File
	{

		#region Constructors: Public

		public VwProcessLibFile(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwProcessLibFile";
		}

		public VwProcessLibFile(VwProcessLibFile source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Process library.
		/// </summary>
		public Guid VwProcessLib {
			get {
				return GetTypedColumnValue<Guid>("VwProcessLib");
			}
			set {
				SetColumnValue("VwProcessLib", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwProcessLibFile_ProcessLibraryEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwProcessLibFileDeleted", e);
			Inserting += (s, e) => ThrowEvent("VwProcessLibFileInserting", e);
			Updated += (s, e) => ThrowEvent("VwProcessLibFileUpdated", e);
			Validating += (s, e) => ThrowEvent("VwProcessLibFileValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwProcessLibFile(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwProcessLibFile_ProcessLibraryEventsProcess

	/// <exclude/>
	public partial class VwProcessLibFile_ProcessLibraryEventsProcess<TEntity> : Terrasoft.Configuration.File_PRMPortalEventsProcess<TEntity> where TEntity : VwProcessLibFile
	{

		public VwProcessLibFile_ProcessLibraryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwProcessLibFile_ProcessLibraryEventsProcess";
			SchemaUId = new Guid("46d85d4c-c6b5-4ed7-b600-a3b195d70acc");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("46d85d4c-c6b5-4ed7-b600-a3b195d70acc");
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

	#region Class: VwProcessLibFile_ProcessLibraryEventsProcess

	/// <exclude/>
	public class VwProcessLibFile_ProcessLibraryEventsProcess : VwProcessLibFile_ProcessLibraryEventsProcess<VwProcessLibFile>
	{

		public VwProcessLibFile_ProcessLibraryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwProcessLibFile_ProcessLibraryEventsProcess

	public partial class VwProcessLibFile_ProcessLibraryEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwProcessLibFileEventsProcessSchema

	/// <exclude/>
	public class VwProcessLibFileEventsProcessSchema : Terrasoft.Configuration.FileEventsProcessSchema
	{

		#region Constructors: Public

		public VwProcessLibFileEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwProcessLibFileEventsProcessSchema(VwProcessLibFileEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwProcessLibFile_ProcessLibraryEventsProcess";
			UId = new Guid("76043d2c-96ee-47ab-bf8a-e110110219e7");
			CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = Guid.Empty;
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
				CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8344487b-4f62-45ad-a3a1-e073f07b2ef2"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e33423da-6c95-41fd-bf98-97c4161975e5"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("0eb5b1d6-fd83-46d8-a1cb-e9910b6e64ae")
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
			return new VwProcessLibFileEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("76043d2c-96ee-47ab-bf8a-e110110219e7"));
		}

		#endregion

	}

	#endregion


	#region Class: VwProcessLibFileEventsProcess

	/// <exclude/>
	public class VwProcessLibFileEventsProcess : VwProcessLibFile_ProcessLibraryEventsProcess
	{

		public VwProcessLibFileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

