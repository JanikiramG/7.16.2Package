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

	#region Class: LocationHistorySchema

	/// <exclude/>
	public class LocationHistorySchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public LocationHistorySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LocationHistorySchema(LocationHistorySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LocationHistorySchema(LocationHistorySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bba63d30-4b4c-4ea9-ba86-9471539c412e");
			RealUId = new Guid("bba63d30-4b4c-4ea9-ba86-9471539c412e");
			Name = "LocationHistory";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("8392ee26-2372-47a0-881e-d5bd71fa247e");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateLongitudeColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("0bdd32ce-2a40-4d1b-b550-961462870281")) == null) {
				Columns.Add(CreateDateColumn());
			}
			if (Columns.FindByUId(new Guid("c4e708df-a366-4c33-b4f9-7a6e48721271")) == null) {
				Columns.Add(CreateLatitudeColumn());
			}
			if (Columns.FindByUId(new Guid("c48b7efc-759a-4c02-a096-5c21b2f9149a")) == null) {
				Columns.Add(CreateIsApproximateColumn());
			}
			if (Columns.FindByUId(new Guid("2b96bf18-ea4a-4a0d-bbdd-230d4b2b334d")) == null) {
				Columns.Add(CreateContactColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("0bdd32ce-2a40-4d1b-b550-961462870281"),
				Name = @"Date",
				CreatedInSchemaUId = new Guid("bba63d30-4b4c-4ea9-ba86-9471539c412e"),
				ModifiedInSchemaUId = new Guid("bba63d30-4b4c-4ea9-ba86-9471539c412e"),
				CreatedInPackageId = new Guid("8392ee26-2372-47a0-881e-d5bd71fa247e")
			};
		}

		protected virtual EntitySchemaColumn CreateLongitudeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("b5387ae7-874c-418a-9758-e7de5036e228"),
				Name = @"Longitude",
				CreatedInSchemaUId = new Guid("bba63d30-4b4c-4ea9-ba86-9471539c412e"),
				ModifiedInSchemaUId = new Guid("bba63d30-4b4c-4ea9-ba86-9471539c412e"),
				CreatedInPackageId = new Guid("8392ee26-2372-47a0-881e-d5bd71fa247e")
			};
		}

		protected virtual EntitySchemaColumn CreateLatitudeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("c4e708df-a366-4c33-b4f9-7a6e48721271"),
				Name = @"Latitude",
				CreatedInSchemaUId = new Guid("bba63d30-4b4c-4ea9-ba86-9471539c412e"),
				ModifiedInSchemaUId = new Guid("bba63d30-4b4c-4ea9-ba86-9471539c412e"),
				CreatedInPackageId = new Guid("8392ee26-2372-47a0-881e-d5bd71fa247e")
			};
		}

		protected virtual EntitySchemaColumn CreateIsApproximateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("c48b7efc-759a-4c02-a096-5c21b2f9149a"),
				Name = @"IsApproximate",
				CreatedInSchemaUId = new Guid("bba63d30-4b4c-4ea9-ba86-9471539c412e"),
				ModifiedInSchemaUId = new Guid("bba63d30-4b4c-4ea9-ba86-9471539c412e"),
				CreatedInPackageId = new Guid("8392ee26-2372-47a0-881e-d5bd71fa247e")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2b96bf18-ea4a-4a0d-bbdd-230d4b2b334d"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("bba63d30-4b4c-4ea9-ba86-9471539c412e"),
				ModifiedInSchemaUId = new Guid("bba63d30-4b4c-4ea9-ba86-9471539c412e"),
				CreatedInPackageId = new Guid("8392ee26-2372-47a0-881e-d5bd71fa247e"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLocationHistoryEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateLocationHistoryEventsProcessSchema() {
			var schema = new LocationHistoryEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LocationHistory(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LocationHistory_MobileEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LocationHistorySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LocationHistorySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bba63d30-4b4c-4ea9-ba86-9471539c412e"));
		}

		#endregion

	}

	#endregion

	#region Class: LocationHistory

	/// <summary>
	/// Users location history.
	/// </summary>
	public class LocationHistory : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public LocationHistory(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LocationHistory";
		}

		public LocationHistory(LocationHistory source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Date.
		/// </summary>
		public DateTime Date {
			get {
				return GetTypedColumnValue<DateTime>("Date");
			}
			set {
				SetColumnValue("Date", value);
			}
		}

		/// <summary>
		/// Longitude.
		/// </summary>
		public string Longitude {
			get {
				return GetTypedColumnValue<string>("Longitude");
			}
			set {
				SetColumnValue("Longitude", value);
			}
		}

		/// <summary>
		/// Latitude.
		/// </summary>
		public string Latitude {
			get {
				return GetTypedColumnValue<string>("Latitude");
			}
			set {
				SetColumnValue("Latitude", value);
			}
		}

		/// <summary>
		/// Approximate coordinates.
		/// </summary>
		public bool IsApproximate {
			get {
				return GetTypedColumnValue<bool>("IsApproximate");
			}
			set {
				SetColumnValue("IsApproximate", value);
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LocationHistory_MobileEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("LocationHistoryDeleted", e);
			Validating += (s, e) => ThrowEvent("LocationHistoryValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LocationHistory(this);
		}

		#endregion

	}

	#endregion

	#region Class: LocationHistory_MobileEventsProcess

	/// <exclude/>
	public partial class LocationHistory_MobileEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : LocationHistory
	{

		public LocationHistory_MobileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LocationHistory_MobileEventsProcess";
			SchemaUId = new Guid("bba63d30-4b4c-4ea9-ba86-9471539c412e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("bba63d30-4b4c-4ea9-ba86-9471539c412e");
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

	#region Class: LocationHistory_MobileEventsProcess

	/// <exclude/>
	public class LocationHistory_MobileEventsProcess : LocationHistory_MobileEventsProcess<LocationHistory>
	{

		public LocationHistory_MobileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LocationHistory_MobileEventsProcess

	public partial class LocationHistory_MobileEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: LocationHistoryEventsProcessSchema

	/// <exclude/>
	public class LocationHistoryEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public LocationHistoryEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LocationHistoryEventsProcessSchema(LocationHistoryEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LocationHistory_MobileEventsProcess";
			UId = new Guid("c21bb418-b673-4be7-b22d-8d5b9fd5dc54");
			CreatedInPackageId = new Guid("8392ee26-2372-47a0-881e-d5bd71fa247e");
			CreatedInSchemaUId = Guid.Empty;
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
			return new LocationHistoryEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c21bb418-b673-4be7-b22d-8d5b9fd5dc54"));
		}

		#endregion

	}

	#endregion


	#region Class: LocationHistoryEventsProcess

	/// <exclude/>
	public class LocationHistoryEventsProcess : LocationHistory_MobileEventsProcess
	{

		public LocationHistoryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

