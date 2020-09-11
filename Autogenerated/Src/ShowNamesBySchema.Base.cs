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

	#region Class: ShowNamesBySchema

	/// <exclude/>
	public class ShowNamesBySchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public ShowNamesBySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ShowNamesBySchema(ShowNamesBySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ShowNamesBySchema(ShowNamesBySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fe0e9a8c-3ba6-46fb-835e-71ac1d91e2b7");
			RealUId = new Guid("fe0e9a8c-3ba6-46fb-835e-71ac1d91e2b7");
			Name = "ShowNamesBy";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5741501e-fb86-4c7b-b1ac-4a2cd53430ce")) == null) {
				Columns.Add(CreateSeparatorColumn());
			}
			if (Columns.FindByUId(new Guid("f36a44b8-faf2-42ce-a4af-f44e45795230")) == null) {
				Columns.Add(CreateConverterColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("fe0e9a8c-3ba6-46fb-835e-71ac1d91e2b7");
			column.CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("fe0e9a8c-3ba6-46fb-835e-71ac1d91e2b7");
			column.CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("fe0e9a8c-3ba6-46fb-835e-71ac1d91e2b7");
			column.CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("fe0e9a8c-3ba6-46fb-835e-71ac1d91e2b7");
			column.CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("fe0e9a8c-3ba6-46fb-835e-71ac1d91e2b7");
			column.CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("fe0e9a8c-3ba6-46fb-835e-71ac1d91e2b7");
			column.CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("fe0e9a8c-3ba6-46fb-835e-71ac1d91e2b7");
			column.CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("fe0e9a8c-3ba6-46fb-835e-71ac1d91e2b7");
			column.CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847");
			return column;
		}

		protected virtual EntitySchemaColumn CreateSeparatorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("5741501e-fb86-4c7b-b1ac-4a2cd53430ce"),
				Name = @"Separator",
				CreatedInSchemaUId = new Guid("fe0e9a8c-3ba6-46fb-835e-71ac1d91e2b7"),
				ModifiedInSchemaUId = new Guid("fe0e9a8c-3ba6-46fb-835e-71ac1d91e2b7"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			};
		}

		protected virtual EntitySchemaColumn CreateConverterColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("f36a44b8-faf2-42ce-a4af-f44e45795230"),
				Name = @"Converter",
				CreatedInSchemaUId = new Guid("fe0e9a8c-3ba6-46fb-835e-71ac1d91e2b7"),
				ModifiedInSchemaUId = new Guid("fe0e9a8c-3ba6-46fb-835e-71ac1d91e2b7"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateShowNamesByEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateShowNamesByEventsProcessSchema() {
			var schema = new ShowNamesByEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ShowNamesBy(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ShowNamesBy_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ShowNamesBySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ShowNamesBySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fe0e9a8c-3ba6-46fb-835e-71ac1d91e2b7"));
		}

		#endregion

	}

	#endregion

	#region Class: ShowNamesBy

	/// <summary>
	/// Order of first/last names.
	/// </summary>
	public class ShowNamesBy : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public ShowNamesBy(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ShowNamesBy";
		}

		public ShowNamesBy(ShowNamesBy source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Separator line.
		/// </summary>
		public string Separator {
			get {
				return GetTypedColumnValue<string>("Separator");
			}
			set {
				SetColumnValue("Separator", value);
			}
		}

		/// <summary>
		/// Converter.
		/// </summary>
		public string Converter {
			get {
				return GetTypedColumnValue<string>("Converter");
			}
			set {
				SetColumnValue("Converter", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ShowNamesBy_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ShowNamesByDeleted", e);
			Inserting += (s, e) => ThrowEvent("ShowNamesByInserting", e);
			Validating += (s, e) => ThrowEvent("ShowNamesByValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ShowNamesBy(this);
		}

		#endregion

	}

	#endregion

	#region Class: ShowNamesBy_BaseEventsProcess

	/// <exclude/>
	public partial class ShowNamesBy_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : ShowNamesBy
	{

		public ShowNamesBy_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ShowNamesBy_BaseEventsProcess";
			SchemaUId = new Guid("fe0e9a8c-3ba6-46fb-835e-71ac1d91e2b7");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fe0e9a8c-3ba6-46fb-835e-71ac1d91e2b7");
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

	#region Class: ShowNamesBy_BaseEventsProcess

	/// <exclude/>
	public class ShowNamesBy_BaseEventsProcess : ShowNamesBy_BaseEventsProcess<ShowNamesBy>
	{

		public ShowNamesBy_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ShowNamesBy_BaseEventsProcess

	public partial class ShowNamesBy_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ShowNamesByEventsProcessSchema

	/// <exclude/>
	public class ShowNamesByEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public ShowNamesByEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ShowNamesByEventsProcessSchema(ShowNamesByEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ShowNamesBy_BaseEventsProcess";
			UId = new Guid("1e2bf47f-3e17-4ee3-be12-4869eeeee85b");
			CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1");
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
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
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
			return new ShowNamesByEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1e2bf47f-3e17-4ee3-be12-4869eeeee85b"));
		}

		#endregion

	}

	#endregion


	#region Class: ShowNamesByEventsProcess

	/// <exclude/>
	public class ShowNamesByEventsProcess : ShowNamesBy_BaseEventsProcess
	{

		public ShowNamesByEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

