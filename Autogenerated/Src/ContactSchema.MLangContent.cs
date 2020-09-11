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
	using System.Runtime.Remoting;
	using SystemSettings = Terrasoft.Core.Configuration.SysSettings;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.EntitySynchronization;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Contact_MLangContent_TerrasoftSchema

	/// <exclude/>
	public class Contact_MLangContent_TerrasoftSchema : Terrasoft.Configuration.Contact_Mobile_TerrasoftSchema
	{

		#region Constructors: Public

		public Contact_MLangContent_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Contact_MLangContent_TerrasoftSchema(Contact_MLangContent_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Contact_MLangContent_TerrasoftSchema(Contact_MLangContent_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("d32f53dd-783a-4e71-b094-b84f4caf68fd");
			Name = "Contact_MLangContent_Terrasoft";
			ParentSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			ExtendParent = true;
			CreatedInPackageId = new Guid("f767c979-312c-4d92-9d28-97b2835309c5");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateLanguageColumn() {
			EntitySchemaColumn column = base.CreateLanguageColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Settings,
				ValueSource = @"DefaultMessageLanguage"
			};
			column.ModifiedInSchemaUId = new Guid("d32f53dd-783a-4e71-b094-b84f4caf68fd");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateContact_MLangContent_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateContact_MLangContent_TerrasoftEventsProcessSchema() {
			var schema = new Contact_MLangContent_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Contact_MLangContent_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Contact_MLangContentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Contact_MLangContent_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Contact_MLangContent_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d32f53dd-783a-4e71-b094-b84f4caf68fd"));
		}

		#endregion

	}

	#endregion

	#region Class: Contact_MLangContent_Terrasoft

	/// <summary>
	/// Contact.
	/// </summary>
	public class Contact_MLangContent_Terrasoft : Terrasoft.Configuration.Contact_Mobile_Terrasoft
	{

		#region Constructors: Public

		public Contact_MLangContent_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contact_MLangContent_Terrasoft";
		}

		public Contact_MLangContent_Terrasoft(Contact_MLangContent_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Contact_MLangContentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("Contact_MLangContent_TerrasoftInserting", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Contact_MLangContent_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Contact_MLangContentEventsProcess

	/// <exclude/>
	public partial class Contact_MLangContentEventsProcess<TEntity> : Terrasoft.Configuration.Contact_MobileEventsProcess<TEntity> where TEntity : Contact_MLangContent_Terrasoft
	{

		public Contact_MLangContentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Contact_MLangContentEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d32f53dd-783a-4e71-b094-b84f4caf68fd");
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

	#region Class: Contact_MLangContentEventsProcess

	/// <exclude/>
	public class Contact_MLangContentEventsProcess : Contact_MLangContentEventsProcess<Contact_MLangContent_Terrasoft>
	{

		public Contact_MLangContentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Contact_MLangContentEventsProcess

	public partial class Contact_MLangContentEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: Contact_MLangContent_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Contact_MLangContent_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Contact_Mobile_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Contact_MLangContent_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Contact_MLangContent_TerrasoftEventsProcessSchema(Contact_MLangContent_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Contact_MLangContentEventsProcess";
			UId = new Guid("c2eec2ff-9fd3-4198-ac37-804ce00f0ee2");
			CreatedInPackageId = new Guid("f767c979-312c-4d92-9d28-97b2835309c5");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet2_acee279c7864435f9a3b08e9430ffce9 = CreateLaneSet2_acee279c7864435f9a3b08e9430ffce9LaneSet();
			LaneSets.Add(schemaLaneSet2_acee279c7864435f9a3b08e9430ffce9);
			ProcessSchemaLane schemaLane3_6680beacbb77460093a7ed929baeb872 = CreateLane3_6680beacbb77460093a7ed929baeb872Lane();
			schemaLaneSet2_acee279c7864435f9a3b08e9430ffce9.Lanes.Add(schemaLane3_6680beacbb77460093a7ed929baeb872);
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_acee279c7864435f9a3b08e9430ffce9LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_acee279c7864435f9a3b08e9430ffce9 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("acee279c-7864-435f-9a3b-08e9430ffce9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("f767c979-312c-4d92-9d28-97b2835309c5"),
				CreatedInSchemaUId = new Guid("c2eec2ff-9fd3-4198-ac37-804ce00f0ee2"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("c2eec2ff-9fd3-4198-ac37-804ce00f0ee2"),
				Name = @"LaneSet2_acee279c7864435f9a3b08e9430ffce9",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_acee279c7864435f9a3b08e9430ffce9;
		}

		protected virtual ProcessSchemaLane CreateLane3_6680beacbb77460093a7ed929baeb872Lane() {
			ProcessSchemaLane schemaLane3_6680beacbb77460093a7ed929baeb872 = new ProcessSchemaLane(this) {
				UId = new Guid("6680beac-bb77-4600-93a7-ed929baeb872"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("acee279c-7864-435f-9a3b-08e9430ffce9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("f767c979-312c-4d92-9d28-97b2835309c5"),
				CreatedInSchemaUId = new Guid("c2eec2ff-9fd3-4198-ac37-804ce00f0ee2"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("c2eec2ff-9fd3-4198-ac37-804ce00f0ee2"),
				Name = @"Lane3_6680beacbb77460093a7ed929baeb872",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane3_6680beacbb77460093a7ed929baeb872;
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
				UId = new Guid("73bbc987-2ab8-4ce5-b0ec-c0299d1e72fc"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0017f56e-396d-4e72-a989-2c9800690b07"),
				Name = "Terrasoft.Messaging.Common",
				Alias = "",
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("169a8f30-18f7-46d5-9a44-edcbb48f0929"),
				Name = "System.Runtime.Remoting",
				Alias = "",
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6cb575e2-395e-47ee-968f-9e85ebbb0e57"),
				Name = "System.Linq",
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
				UId = new Guid("03538de8-86d4-4eea-8c1d-8051bbb379ed"),
				Name = "Terrasoft.Configuration.EntitySynchronization",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("baa69609-d62f-4726-b4b5-736f7fd1042f"),
				Name = "Terrasoft.Core.Configuration.SysSettings",
				Alias = "SystemSettings",
				CreatedInPackageId = new Guid("f767c979-312c-4d92-9d28-97b2835309c5")
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
			return new Contact_MLangContent_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c2eec2ff-9fd3-4198-ac37-804ce00f0ee2"));
		}

		#endregion

	}

	#endregion

}

