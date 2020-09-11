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

	#region Class: PartnershipParameterSchema

	/// <exclude/>
	public class PartnershipParameterSchema : Terrasoft.Configuration.PartnershipParameter_PRMBase_TerrasoftSchema
	{

		#region Constructors: Public

		public PartnershipParameterSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public PartnershipParameterSchema(PartnershipParameterSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public PartnershipParameterSchema(PartnershipParameterSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("c57527fd-e61f-4be7-a1ea-597100a577f5");
			Name = "PartnershipParameter";
			ParentSchemaUId = new Guid("7f8f62f1-29e5-4dd7-b206-f083a712f039");
			ExtendParent = true;
			CreatedInPackageId = new Guid("d0cf4ca6-907d-4eba-86db-4399f9ff6801");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreatePartnershipParameterEventsProcessSchema();
		}

		protected virtual ProcessSchema CreatePartnershipParameterEventsProcessSchema() {
			var schema = new PartnershipParameterEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new PartnershipParameter(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new PartnershipParameter_PRMOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new PartnershipParameterSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new PartnershipParameterSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c57527fd-e61f-4be7-a1ea-597100a577f5"));
		}

		#endregion

	}

	#endregion

	#region Class: PartnershipParameter

	/// <summary>
	/// PartnershipParameter.
	/// </summary>
	public class PartnershipParameter : Terrasoft.Configuration.PartnershipParameter_PRMBase_Terrasoft
	{

		#region Constructors: Public

		public PartnershipParameter(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "PartnershipParameter";
		}

		public PartnershipParameter(PartnershipParameter source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new PartnershipParameter_PRMOrderEventsProcess(UserConnection);
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
			return new PartnershipParameter(this);
		}

		#endregion

	}

	#endregion

	#region Class: PartnershipParameter_PRMOrderEventsProcess

	/// <exclude/>
	public partial class PartnershipParameter_PRMOrderEventsProcess<TEntity> : Terrasoft.Configuration.PartnershipParameter_PRMBaseEventsProcess<TEntity> where TEntity : PartnershipParameter
	{

		public PartnershipParameter_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "PartnershipParameter_PRMOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c57527fd-e61f-4be7-a1ea-597100a577f5");
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

	#region Class: PartnershipParameter_PRMOrderEventsProcess

	/// <exclude/>
	public class PartnershipParameter_PRMOrderEventsProcess : PartnershipParameter_PRMOrderEventsProcess<PartnershipParameter>
	{

		public PartnershipParameter_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: PartnershipParameterEventsProcessSchema

	/// <exclude/>
	public class PartnershipParameterEventsProcessSchema : Terrasoft.Configuration.PartnershipParameter_PRMBase_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public PartnershipParameterEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public PartnershipParameterEventsProcessSchema(PartnershipParameterEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "PartnershipParameter_PRMOrderEventsProcess";
			UId = new Guid("bd0d0e49-762c-4190-bab7-f7a9006afcab");
			CreatedInPackageId = new Guid("d0cf4ca6-907d-4eba-86db-4399f9ff6801");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet_4f1c3fc77c3448c2bca96658cae7b012 = CreateLaneSet_4f1c3fc77c3448c2bca96658cae7b012LaneSet();
			LaneSets.Add(schemaLaneSet_4f1c3fc77c3448c2bca96658cae7b012);
			ProcessSchemaLane schemaLane_5f6d21a08a884bbb9301a2102d24f60c = CreateLane_5f6d21a08a884bbb9301a2102d24f60cLane();
			schemaLaneSet_4f1c3fc77c3448c2bca96658cae7b012.Lanes.Add(schemaLane_5f6d21a08a884bbb9301a2102d24f60c);
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet_4f1c3fc77c3448c2bca96658cae7b012LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet_4f1c3fc77c3448c2bca96658cae7b012 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("4f1c3fc7-7c34-48c2-bca9-6658cae7b012"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("1da899d5-828e-41ba-ac65-e64e524380ea"),
				CreatedInPackageId = new Guid("3979ff30-e540-4bb1-ad27-b87d378563be"),
				CreatedInSchemaUId = new Guid("bd0d0e49-762c-4190-bab7-f7a9006afcab"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("bd0d0e49-762c-4190-bab7-f7a9006afcab"),
				Name = @"LaneSet_4f1c3fc77c3448c2bca96658cae7b012",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet_4f1c3fc77c3448c2bca96658cae7b012;
		}

		protected virtual ProcessSchemaLane CreateLane_5f6d21a08a884bbb9301a2102d24f60cLane() {
			ProcessSchemaLane schemaLane_5f6d21a08a884bbb9301a2102d24f60c = new ProcessSchemaLane(this) {
				UId = new Guid("5f6d21a0-8a88-4bbb-9301-a2102d24f60c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f1c3fc7-7c34-48c2-bca9-6658cae7b012"),
				CreatedInOwnerSchemaUId = new Guid("bd0d0e49-762c-4190-bab7-f7a9006afcab"),
				CreatedInPackageId = new Guid("3979ff30-e540-4bb1-ad27-b87d378563be"),
				CreatedInSchemaUId = new Guid("bd0d0e49-762c-4190-bab7-f7a9006afcab"),
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("bd0d0e49-762c-4190-bab7-f7a9006afcab"),
				Name = @"Lane_5f6d21a08a884bbb9301a2102d24f60c",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane_5f6d21a08a884bbb9301a2102d24f60c;
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
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8360e463-41b5-41d2-843f-59f49671d0da"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PartnershipParameterEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bd0d0e49-762c-4190-bab7-f7a9006afcab"));
		}

		#endregion

	}

	#endregion


	#region Class: PartnershipParameterEventsProcess

	/// <exclude/>
	public class PartnershipParameterEventsProcess : PartnershipParameter_PRMOrderEventsProcess
	{

		public PartnershipParameterEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

