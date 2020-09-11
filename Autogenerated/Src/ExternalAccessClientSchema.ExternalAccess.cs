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

	#region Class: ExternalAccessClientSchema

	/// <exclude/>
	public class ExternalAccessClientSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ExternalAccessClientSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ExternalAccessClientSchema(ExternalAccessClientSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ExternalAccessClientSchema(ExternalAccessClientSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1d2bb308-dffb-4dd5-8518-f94ff54ea7cf");
			RealUId = new Guid("1d2bb308-dffb-4dd5-8518-f94ff54ea7cf");
			Name = "ExternalAccessClient";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("c3c7809d-fee0-4b66-8bb6-9b3983c2cffd");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateClientIdColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializePrimaryOrderColumn() {
			base.InitializePrimaryOrderColumn();
			PrimaryOrderColumn = CreateClientIdColumn();
			if (Columns.FindByUId(PrimaryOrderColumn.UId) == null) {
				Columns.Add(PrimaryOrderColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected virtual EntitySchemaColumn CreateClientIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("445514b2-7265-4b3c-8622-11287c879e29"),
				Name = @"ClientId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1d2bb308-dffb-4dd5-8518-f94ff54ea7cf"),
				ModifiedInSchemaUId = new Guid("1d2bb308-dffb-4dd5-8518-f94ff54ea7cf"),
				CreatedInPackageId = new Guid("c3c7809d-fee0-4b66-8bb6-9b3983c2cffd")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateExternalAccessClientEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateExternalAccessClientEventsProcessSchema() {
			var schema = new ExternalAccessClientEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ExternalAccessClient(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ExternalAccessClient_ExternalAccessEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ExternalAccessClientSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ExternalAccessClientSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d2bb308-dffb-4dd5-8518-f94ff54ea7cf"));
		}

		#endregion

	}

	#endregion

	#region Class: ExternalAccessClient

	/// <summary>
	/// External access client.
	/// </summary>
	public class ExternalAccessClient : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ExternalAccessClient(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ExternalAccessClient";
		}

		public ExternalAccessClient(ExternalAccessClient source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Client ID.
		/// </summary>
		public string ClientId {
			get {
				return GetTypedColumnValue<string>("ClientId");
			}
			set {
				SetColumnValue("ClientId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ExternalAccessClient_ExternalAccessEventsProcess(UserConnection);
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
			return new ExternalAccessClient(this);
		}

		#endregion

	}

	#endregion

	#region Class: ExternalAccessClient_ExternalAccessEventsProcess

	/// <exclude/>
	public partial class ExternalAccessClient_ExternalAccessEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ExternalAccessClient
	{

		public ExternalAccessClient_ExternalAccessEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ExternalAccessClient_ExternalAccessEventsProcess";
			SchemaUId = new Guid("1d2bb308-dffb-4dd5-8518-f94ff54ea7cf");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1d2bb308-dffb-4dd5-8518-f94ff54ea7cf");
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

	#region Class: ExternalAccessClient_ExternalAccessEventsProcess

	/// <exclude/>
	public class ExternalAccessClient_ExternalAccessEventsProcess : ExternalAccessClient_ExternalAccessEventsProcess<ExternalAccessClient>
	{

		public ExternalAccessClient_ExternalAccessEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ExternalAccessClient_ExternalAccessEventsProcess

	public partial class ExternalAccessClient_ExternalAccessEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ExternalAccessClientEventsProcessSchema

	/// <exclude/>
	public class ExternalAccessClientEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ExternalAccessClientEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ExternalAccessClientEventsProcessSchema(ExternalAccessClientEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ExternalAccessClient_ExternalAccessEventsProcess";
			UId = new Guid("65cb75d7-2b5b-42ad-8448-410806b70276");
			CreatedInPackageId = new Guid("c3c7809d-fee0-4b66-8bb6-9b3983c2cffd");
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
			return new ExternalAccessClientEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("65cb75d7-2b5b-42ad-8448-410806b70276"));
		}

		#endregion

	}

	#endregion


	#region Class: ExternalAccessClientEventsProcess

	/// <exclude/>
	public class ExternalAccessClientEventsProcess : ExternalAccessClient_ExternalAccessEventsProcess
	{

		public ExternalAccessClientEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}
