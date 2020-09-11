namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.Social;

	#region Class: SocialAccountSchema

	/// <exclude/>
	public class SocialAccountSchema : Terrasoft.Configuration.SocialAccount_Base_TerrasoftSchema
	{

		#region Constructors: Public

		public SocialAccountSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SocialAccountSchema(SocialAccountSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SocialAccountSchema(SocialAccountSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("dc63baee-1910-4c5c-a44c-248f2e0ba677");
			Name = "SocialAccount";
			ParentSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff");
			ExtendParent = true;
			CreatedInPackageId = new Guid("8298d0d1-46ab-4733-8a57-2f1bece9f07b");
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
			EventsProcessSchema = CreateSocialAccountEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSocialAccountEventsProcessSchema() {
			var schema = new SocialAccountEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SocialAccount(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SocialAccount_FacebookIntegrationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SocialAccountSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SocialAccountSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dc63baee-1910-4c5c-a44c-248f2e0ba677"));
		}

		#endregion

	}

	#endregion

	#region Class: SocialAccount

	/// <summary>
	/// Accounts in external resources.
	/// </summary>
	public class SocialAccount : Terrasoft.Configuration.SocialAccount_Base_Terrasoft
	{

		#region Constructors: Public

		public SocialAccount(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SocialAccount";
		}

		public SocialAccount(SocialAccount source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SocialAccount_FacebookIntegrationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SocialAccountDeleted", e);
			Validating += (s, e) => ThrowEvent("SocialAccountValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SocialAccount(this);
		}

		#endregion

	}

	#endregion

	#region Class: SocialAccount_FacebookIntegrationEventsProcess

	/// <exclude/>
	public partial class SocialAccount_FacebookIntegrationEventsProcess<TEntity> : Terrasoft.Configuration.SocialAccount_BaseEventsProcess<TEntity> where TEntity : SocialAccount
	{

		public SocialAccount_FacebookIntegrationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SocialAccount_FacebookIntegrationEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("dc63baee-1910-4c5c-a44c-248f2e0ba677");
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

	#region Class: SocialAccount_FacebookIntegrationEventsProcess

	/// <exclude/>
	public class SocialAccount_FacebookIntegrationEventsProcess : SocialAccount_FacebookIntegrationEventsProcess<SocialAccount>
	{

		public SocialAccount_FacebookIntegrationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SocialAccount_FacebookIntegrationEventsProcess

	public partial class SocialAccount_FacebookIntegrationEventsProcess<TEntity>
	{

		#region Methods: Public

		public override bool OnSocialAccountSaved(ProcessExecutingContext context) {
			SocialNetwork socialNetwork = GetSocialNetworkType();
			if (socialNetwork.Equals(SocialNetwork.Facebook)) {
				return true;
			}
			return base.OnSocialAccountSaved(context);
		}

		#endregion

	}

	#endregion

	#region Class: SocialAccountEventsProcessSchema

	/// <exclude/>
	public class SocialAccountEventsProcessSchema : Terrasoft.Configuration.SocialAccount_Base_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public SocialAccountEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SocialAccountEventsProcessSchema(SocialAccountEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SocialAccount_FacebookIntegrationEventsProcess";
			UId = new Guid("06bc1521-59f9-44e6-b63b-5f99323278a5");
			CreatedInPackageId = new Guid("8298d0d1-46ab-4733-8a57-2f1bece9f07b");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("4ee7b055-576b-4a87-8ed6-76e51b285cf9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				CreatedInPackageId = new Guid("8298d0d1-46ab-4733-8a57-2f1bece9f07b"),
				CreatedInSchemaUId = new Guid("06bc1521-59f9-44e6-b63b-5f99323278a5"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("06bc1521-59f9-44e6-b63b-5f99323278a5"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("a68e3a8d-2112-4cd7-9323-d0722a2b5e18"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4ee7b055-576b-4a87-8ed6-76e51b285cf9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8298d0d1-46ab-4733-8a57-2f1bece9f07b"),
				CreatedInSchemaUId = new Guid("06bc1521-59f9-44e6-b63b-5f99323278a5"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("06bc1521-59f9-44e6-b63b-5f99323278a5"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ad97be27-1447-4d06-97ca-6f07387e99d4"),
				Name = "Terrasoft.Social",
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

		protected override SchemaMethod CreateOnSocialAccountSavedMethod() {
			SchemaMethod method = base.CreateOnSocialAccountSavedMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,206,79,206,76,204,241,75,45,41,207,47,202,86,40,70,225,217,42,184,167,150,4,35,11,133,84,22,164,106,104,90,115,101,166,41,104,160,168,213,115,45,44,77,204,41,214,64,81,173,231,150,152,156,154,148,159,159,173,169,169,80,205,197,89,148,90,82,90,148,167,80,82,84,154,106,205,85,203,5,229,38,37,22,167,234,249,231,65,52,58,38,39,231,151,230,149,4,39,150,165,166,104,36,231,231,149,164,86,148,0,173,3,0,45,48,226,149,165,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SocialAccountEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("06bc1521-59f9-44e6-b63b-5f99323278a5"));
		}

		#endregion

	}

	#endregion


	#region Class: SocialAccountEventsProcess

	/// <exclude/>
	public class SocialAccountEventsProcess : SocialAccount_FacebookIntegrationEventsProcess
	{

		public SocialAccountEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

