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

	#region Class: FileImportParametersSchema

	/// <exclude/>
	public class FileImportParametersSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public FileImportParametersSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FileImportParametersSchema(FileImportParametersSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FileImportParametersSchema(FileImportParametersSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5706d121-64c5-4c09-a4a3-ee6e82c47e1a");
			RealUId = new Guid("5706d121-64c5-4c09-a4a3-ee6e82c47e1a");
			Name = "FileImportParameters";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a1dbb834-2aaa-477e-9c5c-90a41c321589")) == null) {
				Columns.Add(CreateImportParametersColumn());
			}
			if (Columns.FindByUId(new Guid("3e6cfbb3-6df0-435a-aa33-6ccde3ebaf21")) == null) {
				Columns.Add(CreateImportEntitiesColumn());
			}
			if (Columns.FindByUId(new Guid("f188489e-f20b-459f-9a3e-7a24f88889fc")) == null) {
				Columns.Add(CreateStageColumn());
			}
			if (Columns.FindByUId(new Guid("baff0d99-eaa1-432c-8e5f-309182d9df13")) == null) {
				Columns.Add(CreateFileDataColumn());
			}
			if (Columns.FindByUId(new Guid("bc6d22d5-2f36-43dd-8732-2d2b3844dfbb")) == null) {
				Columns.Add(CreateSizeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateImportParametersColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("a1dbb834-2aaa-477e-9c5c-90a41c321589"),
				Name = @"ImportParameters",
				CreatedInSchemaUId = new Guid("5706d121-64c5-4c09-a4a3-ee6e82c47e1a"),
				ModifiedInSchemaUId = new Guid("5706d121-64c5-4c09-a4a3-ee6e82c47e1a"),
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8")
			};
		}

		protected virtual EntitySchemaColumn CreateImportEntitiesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("3e6cfbb3-6df0-435a-aa33-6ccde3ebaf21"),
				Name = @"ImportEntities",
				CreatedInSchemaUId = new Guid("5706d121-64c5-4c09-a4a3-ee6e82c47e1a"),
				ModifiedInSchemaUId = new Guid("5706d121-64c5-4c09-a4a3-ee6e82c47e1a"),
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8")
			};
		}

		protected virtual EntitySchemaColumn CreateStageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("f188489e-f20b-459f-9a3e-7a24f88889fc"),
				Name = @"Stage",
				CreatedInSchemaUId = new Guid("5706d121-64c5-4c09-a4a3-ee6e82c47e1a"),
				ModifiedInSchemaUId = new Guid("5706d121-64c5-4c09-a4a3-ee6e82c47e1a"),
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8")
			};
		}

		protected virtual EntitySchemaColumn CreateFileDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("baff0d99-eaa1-432c-8e5f-309182d9df13"),
				Name = @"FileData",
				CreatedInSchemaUId = new Guid("5706d121-64c5-4c09-a4a3-ee6e82c47e1a"),
				ModifiedInSchemaUId = new Guid("5706d121-64c5-4c09-a4a3-ee6e82c47e1a"),
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8")
			};
		}

		protected virtual EntitySchemaColumn CreateSizeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("bc6d22d5-2f36-43dd-8732-2d2b3844dfbb"),
				Name = @"Size",
				CreatedInSchemaUId = new Guid("5706d121-64c5-4c09-a4a3-ee6e82c47e1a"),
				ModifiedInSchemaUId = new Guid("5706d121-64c5-4c09-a4a3-ee6e82c47e1a"),
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateFileImportParametersEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateFileImportParametersEventsProcessSchema() {
			var schema = new FileImportParametersEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FileImportParameters(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FileImportParameters_FileImportEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FileImportParametersSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FileImportParametersSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5706d121-64c5-4c09-a4a3-ee6e82c47e1a"));
		}

		#endregion

	}

	#endregion

	#region Class: FileImportParameters

	/// <summary>
	/// FileImportParameters.
	/// </summary>
	public class FileImportParameters : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public FileImportParameters(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FileImportParameters";
		}

		public FileImportParameters(FileImportParameters source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Stage.
		/// </summary>
		public int Stage {
			get {
				return GetTypedColumnValue<int>("Stage");
			}
			set {
				SetColumnValue("Stage", value);
			}
		}

		/// <summary>
		/// File size.
		/// </summary>
		public int Size {
			get {
				return GetTypedColumnValue<int>("Size");
			}
			set {
				SetColumnValue("Size", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FileImportParameters_FileImportEventsProcess(UserConnection);
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
			return new FileImportParameters(this);
		}

		#endregion

	}

	#endregion

	#region Class: FileImportParameters_FileImportEventsProcess

	/// <exclude/>
	public partial class FileImportParameters_FileImportEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : FileImportParameters
	{

		public FileImportParameters_FileImportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FileImportParameters_FileImportEventsProcess";
			SchemaUId = new Guid("5706d121-64c5-4c09-a4a3-ee6e82c47e1a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5706d121-64c5-4c09-a4a3-ee6e82c47e1a");
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

	#region Class: FileImportParameters_FileImportEventsProcess

	/// <exclude/>
	public class FileImportParameters_FileImportEventsProcess : FileImportParameters_FileImportEventsProcess<FileImportParameters>
	{

		public FileImportParameters_FileImportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FileImportParameters_FileImportEventsProcess

	public partial class FileImportParameters_FileImportEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: FileImportParametersEventsProcessSchema

	/// <exclude/>
	public class FileImportParametersEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public FileImportParametersEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public FileImportParametersEventsProcessSchema(FileImportParametersEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "FileImportParameters_FileImportEventsProcess";
			UId = new Guid("100dd3ab-c0a3-40c5-be9d-e806ea4e6c71");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
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
			return new FileImportParametersEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("100dd3ab-c0a3-40c5-be9d-e806ea4e6c71"));
		}

		#endregion

	}

	#endregion


	#region Class: FileImportParametersEventsProcess

	/// <exclude/>
	public class FileImportParametersEventsProcess : FileImportParameters_FileImportEventsProcess
	{

		public FileImportParametersEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}
