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

	#region Class: MultiLookupImageSchema

	/// <exclude/>
	public class MultiLookupImageSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public MultiLookupImageSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MultiLookupImageSchema(MultiLookupImageSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MultiLookupImageSchema(MultiLookupImageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1d678b87-fc77-4218-91af-9aa8fd8fc943");
			RealUId = new Guid("1d678b87-fc77-4218-91af-9aa8fd8fc943");
			Name = "MultiLookupImage";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f9b20943-08ce-493b-8317-f8df2c35f81f");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("3deb26ba-c2c1-4b2d-a8c1-be665c523372")) == null) {
				Columns.Add(CreateCodeColumn());
			}
			if (Columns.FindByUId(new Guid("62037abd-6b76-46c3-8645-13839e7bca9f")) == null) {
				Columns.Add(CreateLookupImageColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("3deb26ba-c2c1-4b2d-a8c1-be665c523372"),
				Name = @"Code",
				CreatedInSchemaUId = new Guid("1d678b87-fc77-4218-91af-9aa8fd8fc943"),
				ModifiedInSchemaUId = new Guid("1d678b87-fc77-4218-91af-9aa8fd8fc943"),
				CreatedInPackageId = new Guid("f9b20943-08ce-493b-8317-f8df2c35f81f")
			};
		}

		protected virtual EntitySchemaColumn CreateLookupImageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ImageLookup")) {
				UId = new Guid("62037abd-6b76-46c3-8645-13839e7bca9f"),
				Name = @"LookupImage",
				ReferenceSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1d678b87-fc77-4218-91af-9aa8fd8fc943"),
				ModifiedInSchemaUId = new Guid("1d678b87-fc77-4218-91af-9aa8fd8fc943"),
				CreatedInPackageId = new Guid("f9b20943-08ce-493b-8317-f8df2c35f81f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMultiLookupImageEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateMultiLookupImageEventsProcessSchema() {
			var schema = new MultiLookupImageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new MultiLookupImage(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new MultiLookupImage_NUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MultiLookupImageSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MultiLookupImageSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d678b87-fc77-4218-91af-9aa8fd8fc943"));
		}

		#endregion

	}

	#endregion

	#region Class: MultiLookupImage

	/// <summary>
	/// Images for MultiLookup.
	/// </summary>
	public class MultiLookupImage : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public MultiLookupImage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MultiLookupImage";
		}

		public MultiLookupImage(MultiLookupImage source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Code.
		/// </summary>
		public string Code {
			get {
				return GetTypedColumnValue<string>("Code");
			}
			set {
				SetColumnValue("Code", value);
			}
		}

		/// <exclude/>
		public Guid LookupImageId {
			get {
				return GetTypedColumnValue<Guid>("LookupImageId");
			}
			set {
				SetColumnValue("LookupImageId", value);
				_lookupImage = null;
			}
		}

		/// <exclude/>
		public string LookupImageName {
			get {
				return GetTypedColumnValue<string>("LookupImageName");
			}
			set {
				SetColumnValue("LookupImageName", value);
				if (_lookupImage != null) {
					_lookupImage.Name = value;
				}
			}
		}

		private SysImage _lookupImage;
		/// <summary>
		/// Lookup image.
		/// </summary>
		public SysImage LookupImage {
			get {
				return _lookupImage ??
					(_lookupImage = LookupColumnEntities.GetEntity("LookupImage") as SysImage);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MultiLookupImage_NUIEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("MultiLookupImageDeleted", e);
			Validating += (s, e) => ThrowEvent("MultiLookupImageValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MultiLookupImage(this);
		}

		#endregion

	}

	#endregion

	#region Class: MultiLookupImage_NUIEventsProcess

	/// <exclude/>
	public partial class MultiLookupImage_NUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : MultiLookupImage
	{

		public MultiLookupImage_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MultiLookupImage_NUIEventsProcess";
			SchemaUId = new Guid("1d678b87-fc77-4218-91af-9aa8fd8fc943");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1d678b87-fc77-4218-91af-9aa8fd8fc943");
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

	#region Class: MultiLookupImage_NUIEventsProcess

	/// <exclude/>
	public class MultiLookupImage_NUIEventsProcess : MultiLookupImage_NUIEventsProcess<MultiLookupImage>
	{

		public MultiLookupImage_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MultiLookupImage_NUIEventsProcess

	public partial class MultiLookupImage_NUIEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: MultiLookupImageEventsProcessSchema

	/// <exclude/>
	public class MultiLookupImageEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public MultiLookupImageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MultiLookupImageEventsProcessSchema(MultiLookupImageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "MultiLookupImage_NUIEventsProcess";
			UId = new Guid("3a9d5406-7cb4-4e0d-94c9-ec1f7219c39b");
			CreatedInPackageId = new Guid("f9b20943-08ce-493b-8317-f8df2c35f81f");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
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
			return new MultiLookupImageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3a9d5406-7cb4-4e0d-94c9-ec1f7219c39b"));
		}

		#endregion

	}

	#endregion


	#region Class: MultiLookupImageEventsProcess

	/// <exclude/>
	public class MultiLookupImageEventsProcess : MultiLookupImage_NUIEventsProcess
	{

		public MultiLookupImageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

