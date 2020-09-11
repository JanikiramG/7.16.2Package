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

	#region Class: SysReportTemplateSchema

	/// <exclude/>
	public class SysReportTemplateSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysReportTemplateSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysReportTemplateSchema(SysReportTemplateSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysReportTemplateSchema(SysReportTemplateSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("44a0ae94-90a3-45b6-8bc7-2d16cf6434c1");
			RealUId = new Guid("44a0ae94-90a3-45b6-8bc7-2d16cf6434c1");
			Name = "SysReportTemplate";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("7609649d-94a6-447b-b054-9d91465ffa7b");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("354138b2-c693-41e9-89a2-4655bbe86b21")) == null) {
				Columns.Add(CreateFileColumn());
			}
			if (Columns.FindByUId(new Guid("473b458f-2ca7-4a01-8bd9-ec47f6074618")) == null) {
				Columns.Add(CreateSizeColumn());
			}
			if (Columns.FindByUId(new Guid("fbe70cde-8d7a-4401-b3fe-e765d813e199")) == null) {
				Columns.Add(CreateReportIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateFileColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("File")) {
				UId = new Guid("354138b2-c693-41e9-89a2-4655bbe86b21"),
				Name = @"File",
				CreatedInSchemaUId = new Guid("44a0ae94-90a3-45b6-8bc7-2d16cf6434c1"),
				ModifiedInSchemaUId = new Guid("44a0ae94-90a3-45b6-8bc7-2d16cf6434c1"),
				CreatedInPackageId = new Guid("7609649d-94a6-447b-b054-9d91465ffa7b")
			};
		}

		protected virtual EntitySchemaColumn CreateSizeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("473b458f-2ca7-4a01-8bd9-ec47f6074618"),
				Name = @"Size",
				CreatedInSchemaUId = new Guid("44a0ae94-90a3-45b6-8bc7-2d16cf6434c1"),
				ModifiedInSchemaUId = new Guid("44a0ae94-90a3-45b6-8bc7-2d16cf6434c1"),
				CreatedInPackageId = new Guid("7609649d-94a6-447b-b054-9d91465ffa7b")
			};
		}

		protected virtual EntitySchemaColumn CreateReportIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("fbe70cde-8d7a-4401-b3fe-e765d813e199"),
				Name = @"ReportId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("44a0ae94-90a3-45b6-8bc7-2d16cf6434c1"),
				ModifiedInSchemaUId = new Guid("44a0ae94-90a3-45b6-8bc7-2d16cf6434c1"),
				CreatedInPackageId = new Guid("7609649d-94a6-447b-b054-9d91465ffa7b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysReportTemplateEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysReportTemplateEventsProcessSchema() {
			var schema = new SysReportTemplateEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysReportTemplate(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysReportTemplate_WordReportingEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysReportTemplateSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysReportTemplateSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("44a0ae94-90a3-45b6-8bc7-2d16cf6434c1"));
		}

		#endregion

	}

	#endregion

	#region Class: SysReportTemplate

	/// <summary>
	/// SysReportTemplate.
	/// </summary>
	public class SysReportTemplate : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysReportTemplate(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysReportTemplate";
		}

		public SysReportTemplate(SysReportTemplate source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Size.
		/// </summary>
		public int Size {
			get {
				return GetTypedColumnValue<int>("Size");
			}
			set {
				SetColumnValue("Size", value);
			}
		}

		/// <summary>
		/// ReportId.
		/// </summary>
		public Guid ReportId {
			get {
				return GetTypedColumnValue<Guid>("ReportId");
			}
			set {
				SetColumnValue("ReportId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysReportTemplate_WordReportingEventsProcess(UserConnection);
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
			return new SysReportTemplate(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysReportTemplate_WordReportingEventsProcess

	/// <exclude/>
	public partial class SysReportTemplate_WordReportingEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysReportTemplate
	{

		public SysReportTemplate_WordReportingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysReportTemplate_WordReportingEventsProcess";
			SchemaUId = new Guid("44a0ae94-90a3-45b6-8bc7-2d16cf6434c1");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("44a0ae94-90a3-45b6-8bc7-2d16cf6434c1");
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

	#region Class: SysReportTemplate_WordReportingEventsProcess

	/// <exclude/>
	public class SysReportTemplate_WordReportingEventsProcess : SysReportTemplate_WordReportingEventsProcess<SysReportTemplate>
	{

		public SysReportTemplate_WordReportingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysReportTemplate_WordReportingEventsProcess

	public partial class SysReportTemplate_WordReportingEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysReportTemplateEventsProcessSchema

	/// <exclude/>
	public class SysReportTemplateEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysReportTemplateEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysReportTemplateEventsProcessSchema(SysReportTemplateEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysReportTemplate_WordReportingEventsProcess";
			UId = new Guid("ed592b7a-04fd-4025-8f1e-ac3a26358f65");
			CreatedInPackageId = new Guid("7609649d-94a6-447b-b054-9d91465ffa7b");
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
			return new SysReportTemplateEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ed592b7a-04fd-4025-8f1e-ac3a26358f65"));
		}

		#endregion

	}

	#endregion


	#region Class: SysReportTemplateEventsProcess

	/// <exclude/>
	public class SysReportTemplateEventsProcess : SysReportTemplate_WordReportingEventsProcess
	{

		public SysReportTemplateEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

